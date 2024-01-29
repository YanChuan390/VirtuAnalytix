using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Core.Tokens;
using YamlDotNet.Serialization.TypeInspectors;
using YamlDotNet.Serialization.Utilities;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
internal static class NativeDll
{
	[PreserveSig]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x11A18CC", Offset = "0x11A18CC", VA = "0x11A18CC")]
	public static extern IntPtr LoadLibrary(string dllToLoad);

	[PreserveSig]
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x11A1964", Offset = "0x11A1964", VA = "0x11A1964")]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

	[PreserveSig]
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x11A1A10", Offset = "0x11A1A10", VA = "0x11A1A10")]
	public static extern bool FreeLibrary(IntPtr hModule);

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x11A1A98", Offset = "0x11A1A98", VA = "0x11A1A98")]
	public static Delegate GetFunctionDelegate(IntPtr pDll, string procedureName, Type t)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public class NativeInputWrapper : IDisposable
{
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x765C70", Offset = "0x765C70")]
	private delegate uint InitializeController(ref int result);

	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x765C84", Offset = "0x765C84")]
	private delegate int DestroyController(uint handleId, ref int result);

	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x765C98", Offset = "0x765C98")]
	private delegate void UpdateControllers(uint handleId, ref int result);

	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x765CAC", Offset = "0x765CAC")]
	private delegate uint GetButtons(uint handleId, int userId);

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E98", Offset = "0x765E98")]
	private bool <IsInitialized>k__BackingField;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private uint _handleId;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr _pDll;

	[Token(Token = "0x17000001")]
	public bool IsInitialized
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x11A1BE8", Offset = "0x11A1BE8", VA = "0x11A1BE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766278", Offset = "0x766278")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x11A1BF0", Offset = "0x11A1BF0", VA = "0x11A1BF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766288", Offset = "0x766288")]
		private set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x11A1BFC", Offset = "0x11A1BFC", VA = "0x11A1BFC")]
	public NativeInputWrapper()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x11A1E24", Offset = "0x11A1E24", VA = "0x11A1E24")]
	public void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x11A1F54", Offset = "0x11A1F54", VA = "0x11A1F54")]
	public uint GetButtonsState(int userId)
	{
		return default(uint);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x11A2090", Offset = "0x11A2090", VA = "0x11A2090", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace YamlDotNet
{
	[Token(Token = "0x2000004")]
	internal static class StandardRegexOptions
	{
		[Token(Token = "0x4000004")]
		public const RegexOptions Compiled = RegexOptions.None;
	}
	[Token(Token = "0x2000005")]
	internal static class ReflectionExtensions
	{
		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765CC0", Offset = "0x765CC0")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BindingFlags instancePublic;

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x17B4508", Offset = "0x17B4508", VA = "0x17B4508")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x17B4510", Offset = "0x17B4510", VA = "0x17B4510")]
			internal IEnumerable<PropertyInfo> <GetPublicProperties>b__0(Type i)
			{
				return null;
			}
		}

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly FieldInfo remoteStackTraceField;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1190834", Offset = "0x1190834", VA = "0x1190834")]
		public static bool IsValueType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x11A7D4C", Offset = "0x11A7D4C", VA = "0x11A7D4C")]
		public static bool IsGenericType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1191E9C", Offset = "0x1191E9C", VA = "0x1191E9C")]
		public static bool IsInterface(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x11A7D6C", Offset = "0x11A7D6C", VA = "0x11A7D6C")]
		public static bool IsEnum(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x11A7D8C", Offset = "0x11A7D8C", VA = "0x11A7D8C")]
		public static bool HasDefaultConstructor(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x118DC64", Offset = "0x118DC64", VA = "0x118DC64")]
		public static TypeCode GetTypeCode(this Type type)
		{
			return default(TypeCode);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x119E0F4", Offset = "0x119E0F4", VA = "0x119E0F4")]
		public static PropertyInfo GetPublicProperty(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x11A7B0C", Offset = "0x11A7B0C", VA = "0x11A7B0C")]
		public static IEnumerable<PropertyInfo> GetPublicProperties(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x11A7E74", Offset = "0x11A7E74", VA = "0x11A7E74")]
		public static IEnumerable<MethodInfo> GetPublicStaticMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x11A7E98", Offset = "0x11A7E98", VA = "0x11A7E98")]
		public static MethodInfo GetPublicStaticMethod(this Type type, string name, params Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x119E0D8", Offset = "0x119E0D8", VA = "0x119E0D8")]
		public static MethodInfo GetPublicInstanceMethod(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x11A7EC0", Offset = "0x11A7EC0", VA = "0x11A7EC0")]
		public static Exception Unwrap(this TargetInvocationException ex)
		{
			return null;
		}
	}
	[Token(Token = "0x2000006")]
	internal sealed class CultureInfoAdapter : CultureInfo
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly IFormatProvider _provider;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1190CC4", Offset = "0x1190CC4", VA = "0x1190CC4")]
		public CultureInfoAdapter(CultureInfo baseCulture, IFormatProvider provider)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1190D64", Offset = "0x1190D64", VA = "0x1190D64", Slot = "19")]
		public override object GetFormat(Type formatType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000007")]
	internal static class PropertyInfoExtensions
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x11A7730", Offset = "0x11A7730", VA = "0x11A7730")]
		public static object ReadValue(this PropertyInfo property, object target)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization
{
	[Token(Token = "0x2000008")]
	public sealed class Deserializer
	{
		[Token(Token = "0x20000B5")]
		private class TypeDescriptorProxy : ITypeInspector
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ITypeInspector TypeDescriptor;

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x17B1E3C", Offset = "0x17B1E3C", VA = "0x17B1E3C", Slot = "4")]
			public IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
			{
				return null;
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x17B1F00", Offset = "0x17B1F00", VA = "0x17B1F00", Slot = "5")]
			public IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched)
			{
				return null;
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x17B1FE0", Offset = "0x17B1FE0", VA = "0x17B1FE0")]
			public TypeDescriptorProxy()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Type> predefinedTagMappings;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, Type> tagMappings;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<IYamlTypeConverter> converters;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TypeDescriptorProxy typeDescriptor;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IValueDeserializer valueDeserializer;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765EA8", Offset = "0x765EA8")]
		private IList<INodeDeserializer> <NodeDeserializers>k__BackingField;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765EB8", Offset = "0x765EB8")]
		private IList<INodeTypeResolver> <TypeResolvers>k__BackingField;

		[Token(Token = "0x17000002")]
		public IList<INodeDeserializer> NodeDeserializers
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x11920E4", Offset = "0x11920E4", VA = "0x11920E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766368", Offset = "0x766368")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x11920EC", Offset = "0x11920EC", VA = "0x11920EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766378", Offset = "0x766378")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public IList<INodeTypeResolver> TypeResolvers
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x11920F4", Offset = "0x11920F4", VA = "0x11920F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766388", Offset = "0x766388")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x11920FC", Offset = "0x11920FC", VA = "0x11920FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766398", Offset = "0x766398")]
			private set
			{
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1192104", Offset = "0x1192104", VA = "0x1192104")]
		public Deserializer([Optional] IObjectFactory objectFactory, [Optional] INamingConvention namingConvention, bool ignoreUnmatched = false)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x11931E4", Offset = "0x11931E4", VA = "0x11931E4")]
		public void RegisterTagMapping(string tag, Type type)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1193250", Offset = "0x1193250", VA = "0x1193250")]
		public void RegisterTypeConverter(IYamlTypeConverter typeConverter)
		{
		}

		[Token(Token = "0x6000023")]
		public T Deserialize<T>(TextReader input)
		{
			return (T)null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x11932B4", Offset = "0x11932B4", VA = "0x11932B4")]
		public object Deserialize(TextReader input)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x119334C", Offset = "0x119334C", VA = "0x119334C")]
		public object Deserialize(TextReader input, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		public T Deserialize<T>(EventReader reader)
		{
			return (T)null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1193830", Offset = "0x1193830", VA = "0x1193830")]
		public object Deserialize(EventReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1193494", Offset = "0x1193494", VA = "0x1193494")]
		public object Deserialize(EventReader reader, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	public abstract class EventInfo
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765EC8", Offset = "0x765EC8")]
		private IObjectDescriptor <Source>k__BackingField;

		[Token(Token = "0x17000004")]
		public IObjectDescriptor Source
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x119B4E8", Offset = "0x119B4E8", VA = "0x119B4E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7663A8", Offset = "0x7663A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x119B4F0", Offset = "0x119B4F0", VA = "0x119B4F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7663B8", Offset = "0x7663B8")]
			private set
			{
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x118CF30", Offset = "0x118CF30", VA = "0x118CF30")]
		protected EventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AliasEventInfo : EventInfo
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765ED8", Offset = "0x765ED8")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x17000005")]
		public string Alias
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x118CF64", Offset = "0x118CF64", VA = "0x118CF64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7663C8", Offset = "0x7663C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x118CF6C", Offset = "0x118CF6C", VA = "0x118CF6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7663D8", Offset = "0x7663D8")]
			set
			{
			}
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x118CEFC", Offset = "0x118CEFC", VA = "0x118CEFC")]
		public AliasEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class ObjectEventInfo : EventInfo
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765EE8", Offset = "0x765EE8")]
		private string <Anchor>k__BackingField;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765EF8", Offset = "0x765EF8")]
		private string <Tag>k__BackingField;

		[Token(Token = "0x17000006")]
		public string Anchor
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x11A344C", Offset = "0x11A344C", VA = "0x11A344C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7663E8", Offset = "0x7663E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x11A3454", Offset = "0x11A3454", VA = "0x11A3454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7663F8", Offset = "0x7663F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public string Tag
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x11A345C", Offset = "0x11A345C", VA = "0x11A345C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766408", Offset = "0x766408")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x11A3464", Offset = "0x11A3464", VA = "0x11A3464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766418", Offset = "0x766418")]
			set
			{
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x11A0620", Offset = "0x11A0620", VA = "0x11A0620")]
		protected ObjectEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public sealed class ScalarEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F08", Offset = "0x765F08")]
		private string <RenderedValue>k__BackingField;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F18", Offset = "0x765F18")]
		private ScalarStyle <Style>k__BackingField;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F28", Offset = "0x765F28")]
		private bool <IsPlainImplicit>k__BackingField;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F38", Offset = "0x765F38")]
		private bool <IsQuotedImplicit>k__BackingField;

		[Token(Token = "0x17000008")]
		public string RenderedValue
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x11A8AA4", Offset = "0x11A8AA4", VA = "0x11A8AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766428", Offset = "0x766428")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x11A8AAC", Offset = "0x11A8AAC", VA = "0x11A8AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766438", Offset = "0x766438")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x11A8AB4", Offset = "0x11A8AB4", VA = "0x11A8AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766448", Offset = "0x766448")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x11A8ABC", Offset = "0x11A8ABC", VA = "0x11A8ABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766458", Offset = "0x766458")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool IsPlainImplicit
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x11A8AC4", Offset = "0x11A8AC4", VA = "0x11A8AC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766468", Offset = "0x766468")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x11A8ACC", Offset = "0x11A8ACC", VA = "0x11A8ACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766478", Offset = "0x766478")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool IsQuotedImplicit
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x11A8AD8", Offset = "0x11A8AD8", VA = "0x11A8AD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766488", Offset = "0x766488")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x11A8AE0", Offset = "0x11A8AE0", VA = "0x11A8AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766498", Offset = "0x766498")]
			set
			{
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x118E8A0", Offset = "0x118E8A0", VA = "0x118E8A0")]
		public ScalarEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public sealed class MappingStartEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F48", Offset = "0x765F48")]
		private bool <IsImplicit>k__BackingField;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F58", Offset = "0x765F58")]
		private MappingStyle <Style>k__BackingField;

		[Token(Token = "0x1700000C")]
		public bool IsImplicit
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x11A0654", Offset = "0x11A0654", VA = "0x11A0654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7664A8", Offset = "0x7664A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x11A065C", Offset = "0x11A065C", VA = "0x11A065C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7664B8", Offset = "0x7664B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public MappingStyle Style
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x11A0668", Offset = "0x11A0668", VA = "0x11A0668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7664C8", Offset = "0x7664C8")]
			get
			{
				return default(MappingStyle);
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x11A0670", Offset = "0x11A0670", VA = "0x11A0670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7664D8", Offset = "0x7664D8")]
			set
			{
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x118E478", Offset = "0x118E478", VA = "0x118E478")]
		public MappingStartEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public sealed class MappingEndEventInfo : EventInfo
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x119B038", Offset = "0x119B038", VA = "0x119B038")]
		public MappingEndEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public sealed class SequenceStartEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F68", Offset = "0x765F68")]
		private bool <IsImplicit>k__BackingField;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F78", Offset = "0x765F78")]
		private SequenceStyle <Style>k__BackingField;

		[Token(Token = "0x1700000E")]
		public bool IsImplicit
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x17A1AA4", Offset = "0x17A1AA4", VA = "0x17A1AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7664E8", Offset = "0x7664E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x17A1AAC", Offset = "0x17A1AAC", VA = "0x17A1AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7664F8", Offset = "0x7664F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public SequenceStyle Style
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x17A1AB8", Offset = "0x17A1AB8", VA = "0x17A1AB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766508", Offset = "0x766508")]
			get
			{
				return default(SequenceStyle);
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x17A1AC0", Offset = "0x17A1AC0", VA = "0x17A1AC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766518", Offset = "0x766518")]
			set
			{
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17A1A9C", Offset = "0x17A1A9C", VA = "0x17A1A9C")]
		public SequenceStartEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public sealed class SequenceEndEventInfo : EventInfo
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x17A1640", Offset = "0x17A1640", VA = "0x17A1640")]
		public SequenceEndEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000011")]
	public interface IAliasProvider
	{
		[Token(Token = "0x600004A")]
		string GetAlias(object target);
	}
	[Token(Token = "0x2000012")]
	public interface IEventEmitter
	{
		[Token(Token = "0x600004B")]
		void Emit(AliasEventInfo eventInfo);

		[Token(Token = "0x600004C")]
		void Emit(ScalarEventInfo eventInfo);

		[Token(Token = "0x600004D")]
		void Emit(MappingStartEventInfo eventInfo);

		[Token(Token = "0x600004E")]
		void Emit(MappingEndEventInfo eventInfo);

		[Token(Token = "0x600004F")]
		void Emit(SequenceStartEventInfo eventInfo);

		[Token(Token = "0x6000050")]
		void Emit(SequenceEndEventInfo eventInfo);
	}
	[Token(Token = "0x2000013")]
	public interface INamingConvention
	{
		[Token(Token = "0x6000051")]
		string Apply(string value);
	}
	[Token(Token = "0x2000014")]
	public interface INodeDeserializer
	{
		[Token(Token = "0x6000052")]
		bool Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value);
	}
	[Token(Token = "0x2000015")]
	public interface INodeTypeResolver
	{
		[Token(Token = "0x6000053")]
		bool Resolve(NodeEvent nodeEvent, ref Type currentType);
	}
	[Token(Token = "0x2000016")]
	public interface IObjectDescriptor
	{
		[Token(Token = "0x17000010")]
		object Value
		{
			[Token(Token = "0x6000054")]
			get;
		}

		[Token(Token = "0x17000011")]
		Type Type
		{
			[Token(Token = "0x6000055")]
			get;
		}

		[Token(Token = "0x17000012")]
		Type StaticType
		{
			[Token(Token = "0x6000056")]
			get;
		}

		[Token(Token = "0x17000013")]
		ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000057")]
			get;
		}
	}
	[Token(Token = "0x2000017")]
	public interface IObjectFactory
	{
		[Token(Token = "0x6000058")]
		object Create(Type type);
	}
	[Token(Token = "0x2000018")]
	public interface IObjectGraphTraversalStrategy
	{
		[Token(Token = "0x6000059")]
		void Traverse(IObjectDescriptor graph, IObjectGraphVisitor visitor);
	}
	[Token(Token = "0x2000019")]
	public interface IObjectGraphVisitor
	{
		[Token(Token = "0x600005A")]
		bool Enter(IObjectDescriptor value);

		[Token(Token = "0x600005B")]
		bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value);

		[Token(Token = "0x600005C")]
		bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value);

		[Token(Token = "0x600005D")]
		void VisitScalar(IObjectDescriptor scalar);

		[Token(Token = "0x600005E")]
		void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType);

		[Token(Token = "0x600005F")]
		void VisitMappingEnd(IObjectDescriptor mapping);

		[Token(Token = "0x6000060")]
		void VisitSequenceStart(IObjectDescriptor sequence, Type elementType);

		[Token(Token = "0x6000061")]
		void VisitSequenceEnd(IObjectDescriptor sequence);
	}
	[Token(Token = "0x200001A")]
	public interface IPropertyDescriptor
	{
		[Token(Token = "0x17000014")]
		string Name
		{
			[Token(Token = "0x6000062")]
			get;
		}

		[Token(Token = "0x17000015")]
		bool CanWrite
		{
			[Token(Token = "0x6000063")]
			get;
		}

		[Token(Token = "0x17000016")]
		Type Type
		{
			[Token(Token = "0x6000064")]
			get;
		}

		[Token(Token = "0x17000017")]
		Type TypeOverride
		{
			[Token(Token = "0x6000065")]
			get;
			[Token(Token = "0x6000066")]
			set;
		}

		[Token(Token = "0x17000018")]
		int Order
		{
			[Token(Token = "0x6000067")]
			get;
			[Token(Token = "0x6000068")]
			set;
		}

		[Token(Token = "0x17000019")]
		ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000069")]
			get;
			[Token(Token = "0x600006A")]
			set;
		}

		[Token(Token = "0x600006B")]
		T GetCustomAttribute<T>() where T : Attribute;

		[Token(Token = "0x600006C")]
		IObjectDescriptor Read(object target);

		[Token(Token = "0x600006D")]
		void Write(object target, object value);
	}
	[Token(Token = "0x200001B")]
	public interface ITypeInspector
	{
		[Token(Token = "0x600006E")]
		IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container);

		[Token(Token = "0x600006F")]
		IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched);
	}
	[Token(Token = "0x200001C")]
	public interface ITypeResolver
	{
		[Token(Token = "0x6000070")]
		Type Resolve(Type staticType, object actualValue);
	}
	[Token(Token = "0x200001D")]
	public interface IValueDeserializer
	{
		[Token(Token = "0x6000071")]
		object DeserializeValue(EventReader reader, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer);
	}
	[Token(Token = "0x200001E")]
	public interface IValuePromise
	{
		[Token(Token = "0x14000001")]
		event Action<object> ValueAvailable;
	}
	[Token(Token = "0x200001F")]
	public interface IYamlSerializable
	{
		[Token(Token = "0x6000074")]
		void ReadYaml(IParser parser);

		[Token(Token = "0x6000075")]
		void WriteYaml(IEmitter emitter);
	}
	[Token(Token = "0x2000020")]
	public interface IYamlTypeConverter
	{
		[Token(Token = "0x6000076")]
		bool Accepts(Type type);

		[Token(Token = "0x6000077")]
		object ReadYaml(IParser parser, Type type);

		[Token(Token = "0x6000078")]
		void WriteYaml(IEmitter emitter, object value, Type type);
	}
	[Token(Token = "0x2000021")]
	public sealed class ObjectDescriptor : IObjectDescriptor
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F88", Offset = "0x765F88")]
		private object <Value>k__BackingField;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765F98", Offset = "0x765F98")]
		private Type <Type>k__BackingField;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765FA8", Offset = "0x765FA8")]
		private Type <StaticType>k__BackingField;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765FB8", Offset = "0x765FB8")]
		private ScalarStyle <ScalarStyle>k__BackingField;

		[Token(Token = "0x1700001A")]
		public object Value
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x11A340C", Offset = "0x11A340C", VA = "0x11A340C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766548", Offset = "0x766548")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x11A3414", Offset = "0x11A3414", VA = "0x11A3414")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766558", Offset = "0x766558")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Type Type
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x11A341C", Offset = "0x11A341C", VA = "0x11A341C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766568", Offset = "0x766568")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x11A3424", Offset = "0x11A3424", VA = "0x11A3424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766578", Offset = "0x766578")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Type StaticType
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x11A342C", Offset = "0x11A342C", VA = "0x11A342C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766588", Offset = "0x766588")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x11A3434", Offset = "0x11A3434", VA = "0x11A3434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766598", Offset = "0x766598")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x11A343C", Offset = "0x11A343C", VA = "0x11A343C", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7665A8", Offset = "0x7665A8")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x11A3444", Offset = "0x11A3444", VA = "0x11A3444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7665B8", Offset = "0x7665B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x119C27C", Offset = "0x119C27C", VA = "0x119C27C")]
		public ObjectDescriptor(object value, Type type, Type staticType)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x119C284", Offset = "0x119C284", VA = "0x119C284")]
		public ObjectDescriptor(object value, Type type, Type staticType, ScalarStyle scalarStyle)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public sealed class PropertyDescriptor : IPropertyDescriptor
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IPropertyDescriptor baseDescriptor;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765FC8", Offset = "0x765FC8")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765FD8", Offset = "0x765FD8")]
		private int <Order>k__BackingField;

		[Token(Token = "0x1700001E")]
		public string Name
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x11A7148", Offset = "0x11A7148", VA = "0x11A7148", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7665C8", Offset = "0x7665C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x11A7150", Offset = "0x11A7150", VA = "0x11A7150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7665D8", Offset = "0x7665D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Type Type
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x11A7158", Offset = "0x11A7158", VA = "0x11A7158", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public Type TypeOverride
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x11A7208", Offset = "0x11A7208", VA = "0x11A7208", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x11A72B8", Offset = "0x11A72B8", VA = "0x11A72B8", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public int Order
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x11A7378", Offset = "0x11A7378", VA = "0x11A7378", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7665E8", Offset = "0x7665E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x11A7380", Offset = "0x11A7380", VA = "0x11A7380", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7665F8", Offset = "0x7665F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x11A7388", Offset = "0x11A7388", VA = "0x11A7388", Slot = "11")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x11A7438", Offset = "0x11A7438", VA = "0x11A7438", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool CanWrite
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x11A74F8", Offset = "0x11A74F8", VA = "0x11A74F8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x11A17EC", Offset = "0x11A17EC", VA = "0x11A17EC")]
		public PropertyDescriptor(IPropertyDescriptor baseDescriptor)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x11A75A8", Offset = "0x11A75A8", VA = "0x11A75A8", Slot = "15")]
		public void Write(object target, object value)
		{
		}

		[Token(Token = "0x600008F")]
		public T GetCustomAttribute<T>() where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x11A7670", Offset = "0x11A7670", VA = "0x11A7670", Slot = "14")]
		public IObjectDescriptor Read(object target)
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	[Flags]
	public enum SerializationOptions
	{
		[Token(Token = "0x4000022")]
		None = 0,
		[Token(Token = "0x4000023")]
		Roundtrip = 1,
		[Token(Token = "0x4000024")]
		DisableAliases = 2,
		[Token(Token = "0x4000025")]
		EmitDefaults = 4,
		[Token(Token = "0x4000026")]
		JsonCompatible = 8,
		[Token(Token = "0x4000027")]
		DefaultToStaticType = 0x10
	}
	[Token(Token = "0x2000024")]
	public sealed class Serializer
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765FE8", Offset = "0x765FE8")]
		private IList<IYamlTypeConverter> <Converters>k__BackingField;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly SerializationOptions options;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly INamingConvention namingConvention;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ITypeResolver typeResolver;

		[Token(Token = "0x17000024")]
		internal IList<IYamlTypeConverter> Converters
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x17A1AC8", Offset = "0x17A1AC8", VA = "0x17A1AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766608", Offset = "0x766608")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x17A1AD0", Offset = "0x17A1AD0", VA = "0x17A1AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766618", Offset = "0x766618")]
			private set
			{
			}
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x17A1AD8", Offset = "0x17A1AD8", VA = "0x17A1AD8")]
		public Serializer(SerializationOptions options = SerializationOptions.None, [Optional] INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x17A1FA0", Offset = "0x17A1FA0", VA = "0x17A1FA0")]
		private bool IsOptionSet(SerializationOptions option)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x17A1FB8", Offset = "0x17A1FB8", VA = "0x17A1FB8")]
		public void RegisterTypeConverter(IYamlTypeConverter converter)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x17A2078", Offset = "0x17A2078", VA = "0x17A2078")]
		public void Serialize(TextWriter writer, object graph)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x17A2274", Offset = "0x17A2274", VA = "0x17A2274")]
		public void Serialize(TextWriter writer, object graph, Type type)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x17A20F0", Offset = "0x17A20F0", VA = "0x17A20F0")]
		public void Serialize(IEmitter emitter, object graph)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x17A22FC", Offset = "0x17A22FC", VA = "0x17A22FC")]
		public void Serialize(IEmitter emitter, object graph, Type type)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x17A2434", Offset = "0x17A2434", VA = "0x17A2434")]
		private void EmitDocument(IEmitter emitter, IObjectDescriptor graph)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x17A2A34", Offset = "0x17A2A34", VA = "0x17A2A34")]
		private IObjectGraphVisitor CreateEmittingVisitor(IEmitter emitter, IObjectGraphTraversalStrategy traversalStrategy, IEventEmitter eventEmitter, IObjectDescriptor graph)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x17A2950", Offset = "0x17A2950", VA = "0x17A2950")]
		private IEventEmitter CreateEventEmitter(IEmitter emitter)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x17A2778", Offset = "0x17A2778", VA = "0x17A2778")]
		private IObjectGraphTraversalStrategy CreateTraversalStrategy()
		{
			return null;
		}
	}
	[Token(Token = "0x2000025")]
	public sealed class StreamFragment : IYamlSerializable
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<ParsingEvent> events;

		[Token(Token = "0x17000025")]
		public IList<ParsingEvent> Events
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x17A3940", Offset = "0x17A3940", VA = "0x17A3940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x17A3948", Offset = "0x17A3948", VA = "0x17A3948", Slot = "4")]
		private void YamlDotNet.Serialization.IYamlSerializable.ReadYaml(IParser parser)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x17A3B88", Offset = "0x17A3B88", VA = "0x17A3B88", Slot = "5")]
		private void YamlDotNet.Serialization.IYamlSerializable.WriteYaml(IEmitter emitter)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x17A3D1C", Offset = "0x17A3D1C", VA = "0x17A3D1C")]
		public StreamFragment()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public sealed class TagMappings
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, Type> mappings;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x17A4E88", Offset = "0x17A4E88", VA = "0x17A4E88")]
		public TagMappings()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x17A4F0C", Offset = "0x17A4F0C", VA = "0x17A4F0C")]
		public TagMappings(IDictionary<string, Type> mappings)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x17A4FA0", Offset = "0x17A4FA0", VA = "0x17A4FA0")]
		public void Add(string tag, Type mapping)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x17A5068", Offset = "0x17A5068", VA = "0x17A5068")]
		internal Type GetMapping(string tag)
		{
			return null;
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x765A14", Offset = "0x765A14")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x765A14", Offset = "0x765A14")]
	public class YamlAliasAttribute : Attribute
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765FF8", Offset = "0x765FF8")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x17000026")]
		public string Alias
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x17A8928", Offset = "0x17A8928", VA = "0x17A8928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766628", Offset = "0x766628")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x17A8930", Offset = "0x17A8930", VA = "0x17A8930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766638", Offset = "0x766638")]
			set
			{
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x17A8938", Offset = "0x17A8938", VA = "0x17A8938")]
		public YamlAliasAttribute(string alias)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public sealed class YamlAttributesTypeInspector : TypeInspectorSkeleton
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765CD0", Offset = "0x765CD0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IPropertyDescriptor, bool> <>9__2_0;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<IPropertyDescriptor, IPropertyDescriptor> <>9__2_1;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IPropertyDescriptor, int> <>9__2_2;

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x17B4F18", Offset = "0x17B4F18", VA = "0x17B4F18")]
			public <>c()
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x17B4F20", Offset = "0x17B4F20", VA = "0x17B4F20")]
			internal bool <GetProperties>b__2_0(IPropertyDescriptor p)
			{
				return default(bool);
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x17B4FEC", Offset = "0x17B4FEC", VA = "0x17B4FEC")]
			internal IPropertyDescriptor <GetProperties>b__2_1(IPropertyDescriptor p)
			{
				return null;
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x17B5270", Offset = "0x17B5270", VA = "0x17B5270")]
			internal int <GetProperties>b__2_2(IPropertyDescriptor p)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x17A2D68", Offset = "0x17A2D68", VA = "0x17A2D68")]
		public YamlAttributesTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17A8D3C", Offset = "0x17A8D3C", VA = "0x17A8D3C", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}
	}
	[Token(Token = "0x2000029")]
	internal static class YamlFormatter
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NumberFormatInfo NumberFormat;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x17A5B5C", Offset = "0x17A5B5C", VA = "0x17A5B5C")]
		public static string FormatNumber(object number)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x17A5AAC", Offset = "0x17A5AAC", VA = "0x17A5AAC")]
		public static string FormatBoolean(object boolean)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x17A5C00", Offset = "0x17A5C00", VA = "0x17A5C00")]
		public static string FormatDateTime(object dateTime)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x17A5CE0", Offset = "0x17A5CE0", VA = "0x17A5CE0")]
		public static string FormatTimeSpan(object timeSpan)
		{
			return null;
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x765A70", Offset = "0x765A70")]
	public sealed class YamlIgnoreAttribute : Attribute
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x17AA0C8", Offset = "0x17AA0C8", VA = "0x17AA0C8")]
		public YamlIgnoreAttribute()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x765AA4", Offset = "0x765AA4")]
	public sealed class YamlMemberAttribute : Attribute
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766008", Offset = "0x766008")]
		private Type <SerializeAs>k__BackingField;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766018", Offset = "0x766018")]
		private int <Order>k__BackingField;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766028", Offset = "0x766028")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766038", Offset = "0x766038")]
		private ScalarStyle <ScalarStyle>k__BackingField;

		[Token(Token = "0x17000027")]
		public Type SerializeAs
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x17ACCEC", Offset = "0x17ACCEC", VA = "0x17ACCEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766648", Offset = "0x766648")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x17ACCF4", Offset = "0x17ACCF4", VA = "0x17ACCF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766658", Offset = "0x766658")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int Order
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x17ACCFC", Offset = "0x17ACCFC", VA = "0x17ACCFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766668", Offset = "0x766668")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x17ACD04", Offset = "0x17ACD04", VA = "0x17ACD04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766678", Offset = "0x766678")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public string Alias
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x17ACD0C", Offset = "0x17ACD0C", VA = "0x17ACD0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766688", Offset = "0x766688")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x17ACD14", Offset = "0x17ACD14", VA = "0x17ACD14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766698", Offset = "0x766698")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x17ACD1C", Offset = "0x17ACD1C", VA = "0x17ACD1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7666A8", Offset = "0x7666A8")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x17ACD24", Offset = "0x17ACD24", VA = "0x17ACD24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7666B8", Offset = "0x7666B8")]
			set
			{
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x17ACD2C", Offset = "0x17ACD2C", VA = "0x17ACD2C")]
		public YamlMemberAttribute()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x17ACD54", Offset = "0x17ACD54", VA = "0x17ACD54")]
		public YamlMemberAttribute(Type serializeAs)
		{
		}
	}
}
namespace YamlDotNet.Serialization.ValueDeserializers
{
	[Token(Token = "0x200002C")]
	public sealed class AliasValueDeserializer : IValueDeserializer
	{
		[Token(Token = "0x20000B7")]
		private sealed class AliasState : Dictionary<string, ValuePromise>, IPostDeserializationCallback
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x17B12A8", Offset = "0x17B12A8", VA = "0x17B12A8", Slot = "35")]
			public void OnDeserialization()
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x17B1468", Offset = "0x17B1468", VA = "0x17B1468")]
			public AliasState()
			{
			}
		}

		[Token(Token = "0x20000B8")]
		private sealed class ValuePromise : IValuePromise
		{
			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766238", Offset = "0x766238")]
			private bool <HasValue>k__BackingField;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object value;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public readonly YamlDotNet.Core.Events.AnchorAlias Alias;

			[Token(Token = "0x170000AA")]
			public bool HasValue
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x17B15F4", Offset = "0x17B15F4", VA = "0x17B15F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766CD8", Offset = "0x766CD8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x17B15FC", Offset = "0x17B15FC", VA = "0x17B15FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766CE8", Offset = "0x766CE8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			public object Value
			{
				[Token(Token = "0x600041F")]
				[Address(RVA = "0x17B1678", Offset = "0x17B1678", VA = "0x17B1678")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000420")]
				[Address(RVA = "0x17B16DC", Offset = "0x17B16DC", VA = "0x17B16DC")]
				set
				{
				}
			}

			[Token(Token = "0x14000002")]
			public event Action<object> ValueAvailable
			{
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x17B14B4", Offset = "0x17B14B4", VA = "0x17B14B4", Slot = "4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766CB8", Offset = "0x766CB8")]
				add
				{
				}
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x17B1554", Offset = "0x17B1554", VA = "0x17B1554", Slot = "5")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766CC8", Offset = "0x766CC8")]
				remove
				{
				}
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x17B1608", Offset = "0x17B1608", VA = "0x17B1608")]
			public ValuePromise(YamlDotNet.Core.Events.AnchorAlias alias)
			{
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x17B163C", Offset = "0x17B163C", VA = "0x17B163C")]
			public ValuePromise(object value)
			{
			}
		}

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IValueDeserializer innerDeserializer;

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x118CF74", Offset = "0x118CF74", VA = "0x118CF74")]
		public AliasValueDeserializer(IValueDeserializer innerDeserializer)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x118CFF4", Offset = "0x118CFF4", VA = "0x118CFF4", Slot = "4")]
		public object DeserializeValue(EventReader reader, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer)
		{
			return null;
		}
	}
	[Token(Token = "0x200002D")]
	public sealed class NodeValueDeserializer : IValueDeserializer
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765CE0", Offset = "0x765CE0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IValueDeserializer nestedObjectDeserializer;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SerializerState state;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<EventReader, Type, object> <>9__0;

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x17B3F4C", Offset = "0x17B3F4C", VA = "0x17B3F4C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x17B3F54", Offset = "0x17B3F54", VA = "0x17B3F54")]
			internal object <DeserializeValue>b__0(EventReader r, Type t)
			{
				return null;
			}
		}

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IList<INodeDeserializer> deserializers;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IList<INodeTypeResolver> typeResolvers;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1193124", Offset = "0x1193124", VA = "0x1193124")]
		public NodeValueDeserializer(IList<INodeDeserializer> deserializers, IList<INodeTypeResolver> typeResolvers)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x11A23D4", Offset = "0x11A23D4", VA = "0x11A23D4", Slot = "4")]
		public object DeserializeValue(EventReader reader, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x11A2A28", Offset = "0x11A2A28", VA = "0x11A2A28")]
		private Type GetTypeFromEvent(NodeEvent nodeEvent, Type currentType)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.Utilities
{
	[Token(Token = "0x200002E")]
	public interface IPostDeserializationCallback
	{
		[Token(Token = "0x60000C0")]
		void OnDeserialization();
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x765AD8", Offset = "0x765AD8")]
	internal sealed class ObjectAnchorCollection
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, object> objectsByAnchor;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IDictionary<object, string> anchorsByObject;

		[Token(Token = "0x1700002B")]
		public object Item
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x11A31CC", Offset = "0x11A31CC", VA = "0x11A31CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x11A2FA0", Offset = "0x11A2FA0", VA = "0x11A2FA0")]
		public void Add(string anchor, object @object)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x11A3104", Offset = "0x11A3104", VA = "0x11A3104")]
		public bool TryGetAnchor(object @object, out string anchor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x11A333C", Offset = "0x11A333C", VA = "0x11A333C")]
		public ObjectAnchorCollection()
		{
		}
	}
	[Token(Token = "0x2000030")]
	internal static class ReflectionUtility
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765CF0", Offset = "0x765CF0")]
		private sealed class <GetImplementedInterfaces>d__1 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Type <>2__current;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Type type;

			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Type <>3__type;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Type[] <>7__wrap1;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;

			[Token(Token = "0x170000AC")]
			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Token(Token = "0x6000426")]
				[Address(RVA = "0x17B46EC", Offset = "0x17B46EC", VA = "0x17B46EC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000428")]
				[Address(RVA = "0x17B4734", Offset = "0x17B4734", VA = "0x17B4734", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x17B453C", Offset = "0x17B453C", VA = "0x17B453C")]
			[DebuggerHidden]
			public <GetImplementedInterfaces>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x17B4574", Offset = "0x17B4574", VA = "0x17B4574", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x17B4578", Offset = "0x17B4578", VA = "0x17B4578", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x17B46F4", Offset = "0x17B46F4", VA = "0x17B46F4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x17B473C", Offset = "0x17B473C", VA = "0x17B473C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x17B47EC", Offset = "0x17B47EC", VA = "0x17B47EC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x11902CC", Offset = "0x11902CC", VA = "0x11902CC")]
		public static Type GetImplementedGenericInterface(Type type, Type genericInterfaceType)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x11A809C", Offset = "0x11A809C", VA = "0x11A809C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7666C8", Offset = "0x7666C8")]
		public static IEnumerable<Type> GetImplementedInterfaces(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000031")]
	public sealed class SerializerState : IDisposable
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<Type, object> items;

		[Token(Token = "0x60000C7")]
		public T Get<T>() where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x17A2D9C", Offset = "0x17A2D9C", VA = "0x17A2D9C")]
		public void OnDeserialization()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x17A3160", Offset = "0x17A3160", VA = "0x17A3160", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x17A3518", Offset = "0x17A3518", VA = "0x17A3518")]
		public SerializerState()
		{
		}
	}
	[Token(Token = "0x2000032")]
	internal static class StringExtensions
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765D00", Offset = "0x765D00")]
		private sealed class <>c
		{
			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static MatchEvaluator <>9__0_0;

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x17B4998", Offset = "0x17B4998", VA = "0x17B4998")]
			public <>c()
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x17B49A0", Offset = "0x17B49A0", VA = "0x17B49A0")]
			internal string <ToCamelOrPascalCase>b__0_0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765D10", Offset = "0x765D10")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string separator;

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x17A43CC", Offset = "0x17A43CC", VA = "0x17A43CC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0x17B4A20", Offset = "0x17B4A20", VA = "0x17B4A20")]
			internal string <FromCamelCase>b__0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x17A3F2C", Offset = "0x17A3F2C", VA = "0x17A3F2C")]
		private static string ToCamelOrPascalCase(string str, Func<char, char> firstLetterTransform)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x17A4100", Offset = "0x17A4100", VA = "0x17A4100")]
		public static string ToCamelCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x17A4190", Offset = "0x17A4190", VA = "0x17A4190")]
		public static string ToPascalCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x17A4220", Offset = "0x17A4220", VA = "0x17A4220")]
		public static string FromCamelCase(this string str, string separator)
		{
			return null;
		}
	}
	[Token(Token = "0x2000033")]
	public static class TypeConverter
	{
		[Token(Token = "0x60000CF")]
		public static T ChangeType<T>(object value)
		{
			return (T)null;
		}

		[Token(Token = "0x60000D0")]
		public static T ChangeType<T>(object value, IFormatProvider provider)
		{
			return (T)null;
		}

		[Token(Token = "0x60000D1")]
		public static T ChangeType<T>(object value, CultureInfo culture)
		{
			return (T)null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x17A6084", Offset = "0x17A6084", VA = "0x17A6084")]
		public static object ChangeType(object value, Type destinationType)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x17A7368", Offset = "0x17A7368", VA = "0x17A7368")]
		public static object ChangeType(object value, Type destinationType, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x17A6100", Offset = "0x17A6100", VA = "0x17A6100")]
		public static object ChangeType(object value, Type destinationType, CultureInfo culture)
		{
			return null;
		}
	}
	[Token(Token = "0x2000034")]
	internal static class YamlTypeConverters
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IEnumerable<IYamlTypeConverter> _builtInTypeConverters;

		[Token(Token = "0x1700002C")]
		public static IEnumerable<IYamlTypeConverter> BuiltInConverters
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x17AFC24", Offset = "0x17AFC24", VA = "0x17AFC24")]
			get
			{
				return null;
			}
		}
	}
}
namespace YamlDotNet.Serialization.TypeResolvers
{
	[Token(Token = "0x2000035")]
	public sealed class DynamicTypeResolver : ITypeResolver
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x11953FC", Offset = "0x11953FC", VA = "0x11953FC", Slot = "4")]
		public Type Resolve(Type staticType, object actualValue)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1195414", Offset = "0x1195414", VA = "0x1195414")]
		public DynamicTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public sealed class StaticTypeResolver : ITypeResolver
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x17A375C", Offset = "0x17A375C", VA = "0x17A375C", Slot = "4")]
		public Type Resolve(Type staticType, object actualValue)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x17A1FB0", Offset = "0x17A1FB0", VA = "0x17A1FB0")]
		public StaticTypeResolver()
		{
		}
	}
}
namespace YamlDotNet.Serialization.TypeInspectors
{
	[Token(Token = "0x2000037")]
	public sealed class CachedTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Type, List<IPropertyDescriptor>> cache;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x118F1C8", Offset = "0x118F1C8", VA = "0x118F1C8")]
		public CachedTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x118F2B4", Offset = "0x118F2B4", VA = "0x118F2B4", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	public sealed class NamingConventionTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly INamingConvention namingConvention;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1192FB8", Offset = "0x1192FB8", VA = "0x1192FB8")]
		public NamingConventionTypeInspector(ITypeInspector innerTypeDescriptor, INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x11A1528", Offset = "0x11A1528", VA = "0x11A1528", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x11A1670", Offset = "0x11A1670", VA = "0x11A1670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766758", Offset = "0x766758")]
		private IPropertyDescriptor <GetProperties>b__3_0(IPropertyDescriptor p)
		{
			return null;
		}
	}
	[Token(Token = "0x2000039")]
	public sealed class ReadableAndWritablePropertiesTypeInspector : TypeInspectorSkeleton
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765D20", Offset = "0x765D20")]
		private sealed class <>c
		{
			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IPropertyDescriptor, bool> <>9__2_0;

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x17B41D4", Offset = "0x17B41D4", VA = "0x17B41D4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x17B41DC", Offset = "0x17B41DC", VA = "0x17B41DC")]
			internal bool <GetProperties>b__2_0(IPropertyDescriptor p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector _innerTypeDescriptor;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1192F84", Offset = "0x1192F84", VA = "0x1192F84")]
		public ReadableAndWritablePropertiesTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x11A776C", Offset = "0x11A776C", VA = "0x11A776C", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	public sealed class ReadablePropertiesTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x20000BE")]
		private sealed class ReflectionPropertyDescriptor : IPropertyDescriptor
		{
			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly PropertyInfo _propertyInfo;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly ITypeResolver _typeResolver;

			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766248", Offset = "0x766248")]
			private Type <TypeOverride>k__BackingField;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766258", Offset = "0x766258")]
			private int <Order>k__BackingField;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766268", Offset = "0x766268")]
			private ScalarStyle <ScalarStyle>k__BackingField;

			[Token(Token = "0x170000AE")]
			public string Name
			{
				[Token(Token = "0x6000434")]
				[Address(RVA = "0x17B42E0", Offset = "0x17B42E0", VA = "0x17B42E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			public Type Type
			{
				[Token(Token = "0x6000435")]
				[Address(RVA = "0x17B4300", Offset = "0x17B4300", VA = "0x17B4300", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			public Type TypeOverride
			{
				[Token(Token = "0x6000436")]
				[Address(RVA = "0x17B4324", Offset = "0x17B4324", VA = "0x17B4324", Slot = "7")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766D68", Offset = "0x766D68")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000437")]
				[Address(RVA = "0x17B432C", Offset = "0x17B432C", VA = "0x17B432C", Slot = "8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766D78", Offset = "0x766D78")]
				set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			public int Order
			{
				[Token(Token = "0x6000438")]
				[Address(RVA = "0x17B4334", Offset = "0x17B4334", VA = "0x17B4334", Slot = "9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766D88", Offset = "0x766D88")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000439")]
				[Address(RVA = "0x17B433C", Offset = "0x17B433C", VA = "0x17B433C", Slot = "10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766D98", Offset = "0x766D98")]
				set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			public bool CanWrite
			{
				[Token(Token = "0x600043A")]
				[Address(RVA = "0x17B4344", Offset = "0x17B4344", VA = "0x17B4344", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B3")]
			public ScalarStyle ScalarStyle
			{
				[Token(Token = "0x600043B")]
				[Address(RVA = "0x17B4368", Offset = "0x17B4368", VA = "0x17B4368", Slot = "11")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766DA8", Offset = "0x766DA8")]
				get
				{
					return default(ScalarStyle);
				}
				[Token(Token = "0x600043C")]
				[Address(RVA = "0x17B4370", Offset = "0x17B4370", VA = "0x17B4370", Slot = "12")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766DB8", Offset = "0x766DB8")]
				set
				{
				}
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x17B4288", Offset = "0x17B4288", VA = "0x17B4288")]
			public ReflectionPropertyDescriptor(PropertyInfo propertyInfo, ITypeResolver typeResolver)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x17B4378", Offset = "0x17B4378", VA = "0x17B4378", Slot = "15")]
			public void Write(object target, object value)
			{
			}

			[Token(Token = "0x600043E")]
			public T GetCustomAttribute<T>() where T : Attribute
			{
				return null;
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x17B43A0", Offset = "0x17B43A0", VA = "0x17B43A0", Slot = "14")]
			public IObjectDescriptor Read(object target)
			{
				return null;
			}
		}

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeResolver _typeResolver;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1192F04", Offset = "0x1192F04", VA = "0x1192F04")]
		public ReadablePropertiesTypeInspector(ITypeResolver typeResolver)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x11A7928", Offset = "0x11A7928", VA = "0x11A7928")]
		private static bool IsValidProperty(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x11A7998", Offset = "0x11A7998", VA = "0x11A7998", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x11A7CD8", Offset = "0x11A7CD8", VA = "0x11A7CD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766768", Offset = "0x766768")]
		private IPropertyDescriptor <GetProperties>b__3_0(PropertyInfo p)
		{
			return null;
		}
	}
	[Token(Token = "0x200003B")]
	public abstract class TypeInspectorSkeleton : ITypeInspector
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765D30", Offset = "0x765D30")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x17A7E08", Offset = "0x17A7E08", VA = "0x17A7E08")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x17B4C90", Offset = "0x17B4C90", VA = "0x17B4C90")]
			internal bool <GetProperty>b__0(IPropertyDescriptor p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765D40", Offset = "0x765D40")]
		private sealed class <>c
		{
			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IPropertyDescriptor, string> <>9__1_1;

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x17B4BE0", Offset = "0x17B4BE0", VA = "0x17B4BE0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x17B4BE8", Offset = "0x17B4BE8", VA = "0x17B4BE8")]
			internal string <GetProperty>b__1_1(IPropertyDescriptor p)
			{
				return null;
			}
		}

		[Token(Token = "0x60000E6")]
		public abstract IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container);

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x17A7680", Offset = "0x17A7680", VA = "0x17A7680", Slot = "5")]
		public IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x17A7E10", Offset = "0x17A7E10", VA = "0x17A7E10")]
		protected TypeInspectorSkeleton()
		{
		}
	}
}
namespace YamlDotNet.Serialization.ObjectGraphVisitors
{
	[Token(Token = "0x200003C")]
	public sealed class AnchorAssigner : IObjectGraphVisitor, IAliasProvider
	{
		[Token(Token = "0x20000C1")]
		private class AnchorAssignment
		{
			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Anchor;

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x17B17B4", Offset = "0x17B17B4", VA = "0x17B17B4")]
			public AnchorAssignment()
			{
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<object, AnchorAssignment> assignments;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint nextId;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x118D848", Offset = "0x118D848", VA = "0x118D848", Slot = "4")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x118DCC8", Offset = "0x118DCC8", VA = "0x118DCC8", Slot = "5")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x118DCD0", Offset = "0x118DCD0", VA = "0x118DCD0", Slot = "6")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x118DCD8", Offset = "0x118DCD8", VA = "0x118DCD8", Slot = "7")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitScalar(IObjectDescriptor scalar)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x118DCDC", Offset = "0x118DCDC", VA = "0x118DCDC", Slot = "8")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x118DCE0", Offset = "0x118DCE0", VA = "0x118DCE0", Slot = "9")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitMappingEnd(IObjectDescriptor mapping)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x118DCE4", Offset = "0x118DCE4", VA = "0x118DCE4", Slot = "10")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x118DCE8", Offset = "0x118DCE8", VA = "0x118DCE8", Slot = "11")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitSequenceEnd(IObjectDescriptor sequence)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x118DCEC", Offset = "0x118DCEC", VA = "0x118DCEC", Slot = "12")]
		private string YamlDotNet.Serialization.IAliasProvider.GetAlias(object target)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x118DDD4", Offset = "0x118DDD4", VA = "0x118DDD4")]
		public AnchorAssigner()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public sealed class AnchorAssigningObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IEventEmitter eventEmitter;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IAliasProvider aliasProvider;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly HashSet<string> emittedAliases;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x118DE58", Offset = "0x118DE58", VA = "0x118DE58")]
		public AnchorAssigningObjectGraphVisitor(IObjectGraphVisitor nextVisitor, IEventEmitter eventEmitter, IAliasProvider aliasProvider)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x118DF5C", Offset = "0x118DF5C", VA = "0x118DF5C", Slot = "12")]
		public override bool Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x118E270", Offset = "0x118E270", VA = "0x118E270", Slot = "16")]
		public override void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x118E4AC", Offset = "0x118E4AC", VA = "0x118E4AC", Slot = "18")]
		public override void VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x118E6A8", Offset = "0x118E6A8", VA = "0x118E6A8", Slot = "15")]
		public override void VisitScalar(IObjectDescriptor scalar)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public abstract class ChainedObjectGraphVisitor : IObjectGraphVisitor
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectGraphVisitor nextVisitor;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x118DF28", Offset = "0x118DF28", VA = "0x118DF28")]
		protected ChainedObjectGraphVisitor(IObjectGraphVisitor nextVisitor)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x118E1B4", Offset = "0x118E1B4", VA = "0x118E1B4", Slot = "12")]
		public virtual bool Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x118F920", Offset = "0x118F920", VA = "0x118F920", Slot = "13")]
		public virtual bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x118F9E8", Offset = "0x118F9E8", VA = "0x118F9E8", Slot = "14")]
		public virtual bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x118FAB0", Offset = "0x118FAB0", VA = "0x118FAB0", Slot = "15")]
		public virtual void VisitScalar(IObjectDescriptor scalar)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x118FB70", Offset = "0x118FB70", VA = "0x118FB70", Slot = "16")]
		public virtual void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x118FC48", Offset = "0x118FC48", VA = "0x118FC48", Slot = "17")]
		public virtual void VisitMappingEnd(IObjectDescriptor mapping)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x118FD08", Offset = "0x118FD08", VA = "0x118FD08", Slot = "18")]
		public virtual void VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x118FDD0", Offset = "0x118FDD0", VA = "0x118FDD0", Slot = "19")]
		public virtual void VisitSequenceEnd(IObjectDescriptor sequence)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public sealed class CustomSerializationObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765D50", Offset = "0x765D50")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IObjectDescriptor value;

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x17B1CF8", Offset = "0x17B1CF8", VA = "0x17B1CF8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x17B1D00", Offset = "0x17B1D00", VA = "0x17B1D00")]
			internal bool <Enter>b__0(IYamlTypeConverter t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IEmitter emitter;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IEnumerable<IYamlTypeConverter> typeConverters;

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1191094", Offset = "0x1191094", VA = "0x1191094")]
		public CustomSerializationObjectGraphVisitor(IEmitter emitter, IObjectGraphVisitor nextVisitor, IEnumerable<IYamlTypeConverter> typeConverters)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x11911D8", Offset = "0x11911D8", VA = "0x11911D8", Slot = "12")]
		public override bool Enter(IObjectDescriptor value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000040")]
	public sealed class DefaultExclusiveObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IEqualityComparer<object> _objectComparer;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x11916BC", Offset = "0x11916BC", VA = "0x11916BC")]
		public DefaultExclusiveObjectGraphVisitor(IObjectGraphVisitor nextVisitor)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x11916F0", Offset = "0x11916F0", VA = "0x11916F0")]
		private static object GetDefault(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x119177C", Offset = "0x119177C", VA = "0x119177C", Slot = "13")]
		public override bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x119192C", Offset = "0x119192C", VA = "0x119192C", Slot = "14")]
		public override bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000041")]
	public sealed class EmittingObjectGraphVisitor : IObjectGraphVisitor
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEventEmitter eventEmitter;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x119AD14", Offset = "0x119AD14", VA = "0x119AD14")]
		public EmittingObjectGraphVisitor(IEventEmitter eventEmitter)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x119AD48", Offset = "0x119AD48", VA = "0x119AD48", Slot = "4")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x119AD50", Offset = "0x119AD50", VA = "0x119AD50", Slot = "5")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x119AD58", Offset = "0x119AD58", VA = "0x119AD58", Slot = "6")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x119AD60", Offset = "0x119AD60", VA = "0x119AD60", Slot = "7")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitScalar(IObjectDescriptor scalar)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x119AE48", Offset = "0x119AE48", VA = "0x119AE48", Slot = "8")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x119AF40", Offset = "0x119AF40", VA = "0x119AF40", Slot = "9")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitMappingEnd(IObjectDescriptor mapping)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x119B06C", Offset = "0x119B06C", VA = "0x119B06C", Slot = "10")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x119B158", Offset = "0x119B158", VA = "0x119B158", Slot = "11")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitSequenceEnd(IObjectDescriptor sequence)
		{
		}
	}
}
namespace YamlDotNet.Serialization.ObjectGraphTraversalStrategies
{
	[Token(Token = "0x2000042")]
	public class FullObjectGraphTraversalStrategy : IObjectGraphTraversalStrategy
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly Serializer serializer;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int maxRecursion;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ITypeInspector typeDescriptor;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ITypeResolver typeResolver;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private INamingConvention namingConvention;

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x119B914", Offset = "0x119B914", VA = "0x119B914")]
		public FullObjectGraphTraversalStrategy(Serializer serializer, ITypeInspector typeDescriptor, ITypeResolver typeResolver, int maxRecursion, INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x119BA98", Offset = "0x119BA98", VA = "0x119BA98", Slot = "4")]
		private void YamlDotNet.Serialization.IObjectGraphTraversalStrategy.Traverse(IObjectDescriptor graph, IObjectGraphVisitor visitor)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x119BAA8", Offset = "0x119BAA8", VA = "0x119BAA8", Slot = "5")]
		protected virtual void Traverse(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x119C3E8", Offset = "0x119C3E8", VA = "0x119C3E8", Slot = "6")]
		protected virtual void TraverseObject(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x119CFE0", Offset = "0x119CFE0", VA = "0x119CFE0", Slot = "7")]
		protected virtual void TraverseDictionary(IObjectDescriptor dictionary, IObjectGraphVisitor visitor, int currentDepth, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x119C9F4", Offset = "0x119C9F4", VA = "0x119C9F4")]
		private void TraverseList(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x119D824", Offset = "0x119D824", VA = "0x119D824", Slot = "8")]
		protected virtual void TraverseProperties(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x119D71C", Offset = "0x119D71C", VA = "0x119D71C")]
		private IObjectDescriptor GetObjectDescriptor(object value, Type staticType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	public class RoundtripObjectGraphTraversalStrategy : FullObjectGraphTraversalStrategy
	{
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765D60", Offset = "0x765D60")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IObjectDescriptor value;

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x17B47F0", Offset = "0x17B47F0", VA = "0x17B47F0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x17B47F8", Offset = "0x17B47F8", VA = "0x17B47F8")]
			internal bool <TraverseProperties>b__0(IYamlTypeConverter c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x11A8114", Offset = "0x11A8114", VA = "0x11A8114")]
		public RoundtripObjectGraphTraversalStrategy(Serializer serializer, ITypeInspector typeDescriptor, ITypeResolver typeResolver, int maxRecursion)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x11A811C", Offset = "0x11A811C", VA = "0x11A811C", Slot = "8")]
		protected override void TraverseProperties(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}
	}
}
namespace YamlDotNet.Serialization.ObjectFactories
{
	[Token(Token = "0x2000044")]
	public sealed class DefaultObjectFactory : IObjectFactory
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, Type> defaultInterfaceImplementations;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1191C94", Offset = "0x1191C94", VA = "0x1191C94", Slot = "4")]
		public object Create(Type type)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1191EB4", Offset = "0x1191EB4", VA = "0x1191EB4")]
		public DefaultObjectFactory()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public sealed class LambdaObjectFactory : IObjectFactory
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Func<Type, object> _factory;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x119F99C", Offset = "0x119F99C", VA = "0x119F99C")]
		public LambdaObjectFactory(Func<Type, object> factory)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x119FA1C", Offset = "0x119FA1C", VA = "0x119FA1C", Slot = "4")]
		public object Create(Type type)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.NodeTypeResolvers
{
	[Token(Token = "0x2000046")]
	public sealed class DefaultContainersNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1191518", Offset = "0x1191518", VA = "0x1191518", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x11916B4", Offset = "0x11916B4", VA = "0x11916B4")]
		public DefaultContainersNodeTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public sealed class TagNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, Type> tagMappings;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x17A5140", Offset = "0x17A5140", VA = "0x17A5140")]
		public TagNodeTypeResolver(IDictionary<string, Type> tagMappings)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x17A51C0", Offset = "0x17A51C0", VA = "0x17A51C0", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000048")]
	public sealed class TypeNameInTagNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x17A7E18", Offset = "0x17A7E18", VA = "0x17A7E18", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x17A7F84", Offset = "0x17A7F84", VA = "0x17A7F84")]
		public TypeNameInTagNodeTypeResolver()
		{
		}
	}
}
namespace YamlDotNet.Serialization.NodeDeserializers
{
	[Token(Token = "0x2000049")]
	public sealed class ArrayNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x765D70", Offset = "0x765D70")]
		private sealed class ArrayList : IList, ICollection, IEnumerable
		{
			[Token(Token = "0x20000D9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E88", Offset = "0x765E88")]
			private sealed class <GetEnumerator>d__24 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000196")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int <>1__state;

				[Token(Token = "0x4000197")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private object <>2__current;

				[Token(Token = "0x4000198")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public ArrayList <>4__this;

				[Token(Token = "0x4000199")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private int <i>5__2;

				[Token(Token = "0x170000C6")]
				private object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[Token(Token = "0x60004B8")]
					[Address(RVA = "0x17B6920", Offset = "0x17B6920", VA = "0x17B6920", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x170000C7")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x60004BA")]
					[Address(RVA = "0x17B6968", Offset = "0x17B6968", VA = "0x17B6968", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x60004B5")]
				[Address(RVA = "0x17B1BE0", Offset = "0x17B1BE0", VA = "0x17B1BE0")]
				[DebuggerHidden]
				public <GetEnumerator>d__24(int <>1__state)
				{
				}

				[Token(Token = "0x60004B6")]
				[Address(RVA = "0x17B686C", Offset = "0x17B686C", VA = "0x17B686C", Slot = "5")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x60004B7")]
				[Address(RVA = "0x17B6870", Offset = "0x17B6870", VA = "0x17B6870", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x60004B9")]
				[Address(RVA = "0x17B6928", Offset = "0x17B6928", VA = "0x17B6928", Slot = "8")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object[] data;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int count;

			[Token(Token = "0x170000B4")]
			public bool IsFixedSize
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x17B19E8", Offset = "0x17B19E8", VA = "0x17B19E8", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B5")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x17B19F0", Offset = "0x17B19F0", VA = "0x17B19F0", Slot = "9")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B6")]
			public object Item
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x17B1A78", Offset = "0x17B1A78", VA = "0x17B1A78", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x17B1AB4", Offset = "0x17B1AB4", VA = "0x17B1AB4", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x170000B7")]
			public int Count
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x17B1B50", Offset = "0x17B1B50", VA = "0x17B1B50", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000B8")]
			public bool IsSynchronized
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x17B1B58", Offset = "0x17B1B58", VA = "0x17B1B58", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B9")]
			public object SyncRoot
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x17B1B60", Offset = "0x17B1B60", VA = "0x17B1B60", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x17B17BC", Offset = "0x17B17BC", VA = "0x17B17BC")]
			public ArrayList()
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x17B1848", Offset = "0x17B1848", VA = "0x17B1848", Slot = "6")]
			public int Add(object value)
			{
				return default(int);
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x17B17E4", Offset = "0x17B17E4", VA = "0x17B17E4", Slot = "8")]
			public void Clear()
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x17B1928", Offset = "0x17B1928", VA = "0x17B1928", Slot = "7")]
			public bool Contains(object value)
			{
				return default(bool);
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x17B1968", Offset = "0x17B1968", VA = "0x17B1968", Slot = "11")]
			public int IndexOf(object value)
			{
				return default(int);
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x17B19A8", Offset = "0x17B19A8", VA = "0x17B19A8", Slot = "12")]
			public void Insert(int index, object value)
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x17B19F8", Offset = "0x17B19F8", VA = "0x17B19F8", Slot = "13")]
			public void Remove(object value)
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x17B1A38", Offset = "0x17B1A38", VA = "0x17B1A38", Slot = "14")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x17B1B30", Offset = "0x17B1B30", VA = "0x17B1B30", Slot = "15")]
			public void CopyTo(Array array, int index)
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x17B1B68", Offset = "0x17B1B68", VA = "0x17B1B68", Slot = "18")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x766DC8", Offset = "0x766DC8")]
			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x118E99C", Offset = "0x118E99C", VA = "0x118E99C", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x118EFD0", Offset = "0x118EFD0", VA = "0x118EFD0")]
		public ArrayNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public sealed class CollectionNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765DA8", Offset = "0x765DA8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IList result;

			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type tItem;

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x17B1C0C", Offset = "0x17B1C0C", VA = "0x17B1C0C")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765DB8", Offset = "0x765DB8")]
		private sealed class <>c__DisplayClass3_1
		{
			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass3_0 CS$<>8__locals1;

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x17B1C14", Offset = "0x17B1C14", VA = "0x17B1C14")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x17B1C1C", Offset = "0x17B1C1C", VA = "0x17B1C1C")]
			internal void <DeserializeHelper>b__0(object v)
			{
			}
		}

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x118FE90", Offset = "0x118FE90", VA = "0x118FE90")]
		public CollectionNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x118FEC4", Offset = "0x118FEC4", VA = "0x118FEC4", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x118EAD8", Offset = "0x118EAD8", VA = "0x118EAD8")]
		internal static void DeserializeHelper(Type tItem, EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, IList result, bool canUpdate)
		{
		}
	}
	[Token(Token = "0x200004B")]
	public sealed class DictionaryNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765DC8", Offset = "0x765DC8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IDictionary result;

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x17B1FE8", Offset = "0x17B1FE8", VA = "0x17B1FE8")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765DD8", Offset = "0x765DD8")]
		private sealed class <>c__DisplayClass3_1
		{
			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object key;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object value;

			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass3_0 CS$<>8__locals1;

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x17B1FF0", Offset = "0x17B1FF0", VA = "0x17B1FF0")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x17B1FF8", Offset = "0x17B1FF8", VA = "0x17B1FF8")]
			internal void <DeserializeHelper>b__0(object v)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x17B20C8", Offset = "0x17B20C8", VA = "0x17B20C8")]
			internal void <DeserializeHelper>b__1(object v)
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765DE8", Offset = "0x765DE8")]
		private sealed class <>c__DisplayClass3_2
		{
			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool hasFirstPart;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass3_1 CS$<>8__locals2;

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x17B2198", Offset = "0x17B2198", VA = "0x17B2198")]
			public <>c__DisplayClass3_2()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x17B21A0", Offset = "0x17B21A0", VA = "0x17B21A0")]
			internal void <DeserializeHelper>b__2(object v)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x17B22A4", Offset = "0x17B22A4", VA = "0x17B22A4")]
			internal void <DeserializeHelper>b__3(object v)
			{
			}
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1193088", Offset = "0x1193088", VA = "0x1193088")]
		public DictionaryNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1193B50", Offset = "0x1193B50", VA = "0x1193B50", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1193FC0", Offset = "0x1193FC0", VA = "0x1193FC0")]
		private static void DeserializeHelper(Type tKey, Type tValue, EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, IDictionary result)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public sealed class EnumerableNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x119B244", Offset = "0x119B244", VA = "0x119B244", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x11930BC", Offset = "0x11930BC", VA = "0x11930BC")]
		public EnumerableNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public sealed class NullNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x11A2D78", Offset = "0x11A2D78", VA = "0x11A2D78", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x11A2E10", Offset = "0x11A2E10", VA = "0x11A2E10")]
		private bool NodeIsNull(NodeEvent nodeEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1193078", Offset = "0x1193078", VA = "0x1193078")]
		public NullNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public sealed class ObjectNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765DF8", Offset = "0x765DF8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IPropertyDescriptor property;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object valueRef;

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x17B4024", Offset = "0x17B4024", VA = "0x17B4024")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x17B402C", Offset = "0x17B402C", VA = "0x17B402C")]
			internal void <YamlDotNet.Serialization.INodeDeserializer.Deserialize>b__0(object v)
			{
			}
		}

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ITypeInspector _typeDescriptor;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly bool _ignoreUnmatched;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x11930C4", Offset = "0x11930C4", VA = "0x11930C4")]
		public ObjectNodeDeserializer(IObjectFactory objectFactory, ITypeInspector typeDescriptor, bool ignoreUnmatched)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x11A346C", Offset = "0x11A346C", VA = "0x11A346C", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004F")]
	public sealed class ScalarNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x11A8AEC", Offset = "0x11A8AEC", VA = "0x11A8AEC", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x11A8F90", Offset = "0x11A8F90", VA = "0x11A8F90")]
		private object DeserializeIntegerHelper(TypeCode typeCode, string value, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1193080", Offset = "0x1193080", VA = "0x1193080")]
		public ScalarNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public sealed class TypeConverterNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E08", Offset = "0x765E08")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type expectedType;

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x17A7678", Offset = "0x17A7678", VA = "0x17A7678")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x17B4AC0", Offset = "0x17B4AC0", VA = "0x17B4AC0")]
			internal bool <YamlDotNet.Serialization.INodeDeserializer.Deserialize>b__0(IYamlTypeConverter c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEnumerable<IYamlTypeConverter> converters;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x17A7428", Offset = "0x17A7428", VA = "0x17A7428")]
		public TypeConverterNodeDeserializer(IEnumerable<IYamlTypeConverter> converters)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x17A74A8", Offset = "0x17A74A8", VA = "0x17A74A8", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
}
namespace YamlDotNet.Serialization.NamingConventions
{
	[Token(Token = "0x2000051")]
	public sealed class CamelCaseNamingConvention : INamingConvention
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x118F410", Offset = "0x118F410", VA = "0x118F410", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x118F41C", Offset = "0x118F41C", VA = "0x118F41C")]
		public CamelCaseNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public sealed class HyphenatedNamingConvention : INamingConvention
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x119F1A4", Offset = "0x119F1A4", VA = "0x119F1A4", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x119F1F4", Offset = "0x119F1F4", VA = "0x119F1F4")]
		public HyphenatedNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public sealed class NullNamingConvention : INamingConvention
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x11A2D70", Offset = "0x11A2D70", VA = "0x11A2D70", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1192EFC", Offset = "0x1192EFC", VA = "0x1192EFC")]
		public NullNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public sealed class PascalCaseNamingConvention : INamingConvention
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x11A7134", Offset = "0x11A7134", VA = "0x11A7134", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x11A7140", Offset = "0x11A7140", VA = "0x11A7140")]
		public PascalCaseNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public sealed class UnderscoredNamingConvention : INamingConvention
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x17A7F8C", Offset = "0x17A7F8C", VA = "0x17A7F8C", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x17A7FD8", Offset = "0x17A7FD8", VA = "0x17A7FD8")]
		public UnderscoredNamingConvention()
		{
		}
	}
}
namespace YamlDotNet.Serialization.EventEmitters
{
	[Token(Token = "0x2000056")]
	public abstract class ChainedEventEmitter : IEventEmitter
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly IEventEmitter nextEmitter;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x118F424", Offset = "0x118F424", VA = "0x118F424")]
		protected ChainedEventEmitter(IEventEmitter nextEmitter)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x118F4A4", Offset = "0x118F4A4", VA = "0x118F4A4", Slot = "10")]
		public virtual void Emit(AliasEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x118F560", Offset = "0x118F560", VA = "0x118F560", Slot = "11")]
		public virtual void Emit(ScalarEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x118F620", Offset = "0x118F620", VA = "0x118F620", Slot = "12")]
		public virtual void Emit(MappingStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x118F6E0", Offset = "0x118F6E0", VA = "0x118F6E0", Slot = "13")]
		public virtual void Emit(MappingEndEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x118F7A0", Offset = "0x118F7A0", VA = "0x118F7A0", Slot = "14")]
		public virtual void Emit(SequenceStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x118F860", Offset = "0x118F860", VA = "0x118F860", Slot = "15")]
		public virtual void Emit(SequenceEndEventInfo eventInfo)
		{
		}
	}
	[Token(Token = "0x2000057")]
	public sealed class JsonEventEmitter : ChainedEventEmitter
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x119F1FC", Offset = "0x119F1FC", VA = "0x119F1FC")]
		public JsonEventEmitter(IEventEmitter nextEmitter)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x119F200", Offset = "0x119F200", VA = "0x119F200", Slot = "10")]
		public override void Emit(AliasEventInfo eventInfo)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x119F254", Offset = "0x119F254", VA = "0x119F254", Slot = "11")]
		public override void Emit(ScalarEventInfo eventInfo)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x119F8E8", Offset = "0x119F8E8", VA = "0x119F8E8", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x119F904", Offset = "0x119F904", VA = "0x119F904", Slot = "14")]
		public override void Emit(SequenceStartEventInfo eventInfo)
		{
		}
	}
	[Token(Token = "0x2000058")]
	public sealed class TypeAssigningEventEmitter : ChainedEventEmitter
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly bool _assignTypeWhenDifferent;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x17A2D38", Offset = "0x17A2D38", VA = "0x17A2D38")]
		public TypeAssigningEventEmitter(IEventEmitter nextEmitter, bool assignTypeWhenDifferent)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x17A52E0", Offset = "0x17A52E0", VA = "0x17A52E0", Slot = "11")]
		public override void Emit(ScalarEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x17A5D70", Offset = "0x17A5D70", VA = "0x17A5D70", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x17A6054", Offset = "0x17A6054", VA = "0x17A6054", Slot = "14")]
		public override void Emit(SequenceStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x17A5DA0", Offset = "0x17A5DA0", VA = "0x17A5DA0")]
		private void AssignTypeIfDifferent(ObjectEventInfo eventInfo)
		{
		}
	}
	[Token(Token = "0x2000059")]
	public sealed class WriterEventEmitter : IEventEmitter
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEmitter emitter;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x17A2D04", Offset = "0x17A2D04", VA = "0x17A2D04")]
		public WriterEventEmitter(IEmitter emitter)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x17A8354", Offset = "0x17A8354", VA = "0x17A8354", Slot = "4")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(AliasEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x17A8444", Offset = "0x17A8444", VA = "0x17A8444", Slot = "5")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(ScalarEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x17A8568", Offset = "0x17A8568", VA = "0x17A8568", Slot = "6")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(MappingStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x17A8674", Offset = "0x17A8674", VA = "0x17A8674", Slot = "7")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(MappingEndEventInfo eventInfo)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x17A874C", Offset = "0x17A874C", VA = "0x17A874C", Slot = "8")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(SequenceStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x17A8854", Offset = "0x17A8854", VA = "0x17A8854", Slot = "9")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(SequenceEndEventInfo eventInfo)
		{
		}
	}
}
namespace YamlDotNet.Serialization.Converters
{
	[Token(Token = "0x200005A")]
	public class GuidConverter : IYamlTypeConverter
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x119ED5C", Offset = "0x119ED5C", VA = "0x119ED5C", Slot = "4")]
		public bool Accepts(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x119EDE8", Offset = "0x119EDE8", VA = "0x119EDE8", Slot = "5")]
		public object ReadYaml(IParser parser, Type type)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x119EF90", Offset = "0x119EF90", VA = "0x119EF90", Slot = "6")]
		public void WriteYaml(IEmitter emitter, object value, Type type)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x119F190", Offset = "0x119F190", VA = "0x119F190")]
		public GuidConverter()
		{
		}
	}
}
namespace YamlDotNet.RepresentationModel
{
	[Token(Token = "0x200005B")]
	internal class DocumentLoadingState
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, YamlNode> anchors;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IList<YamlNode> nodesWithUnresolvedAliases;

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x11947F8", Offset = "0x11947F8", VA = "0x11947F8")]
		public void AddAnchor(YamlNode node)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1194A44", Offset = "0x1194A44", VA = "0x1194A44")]
		public YamlNode GetNode(string anchor, bool throwException, Mark start, Mark end)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1194BE4", Offset = "0x1194BE4", VA = "0x1194BE4")]
		public void AddNodeWithUnresolvedAliases(YamlNode node)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1194CA4", Offset = "0x1194CA4", VA = "0x1194CA4")]
		public void ResolveAliases()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1194F64", Offset = "0x1194F64", VA = "0x1194F64")]
		public DocumentLoadingState()
		{
		}
	}
	[Token(Token = "0x200005C")]
	internal class EmitterState
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly HashSet<string> emittedAnchors;

		[Token(Token = "0x1700002D")]
		public HashSet<string> EmittedAnchors
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x119AC88", Offset = "0x119AC88", VA = "0x119AC88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x119AC90", Offset = "0x119AC90", VA = "0x119AC90")]
		public EmitterState()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public interface IYamlVisitor
	{
		[Token(Token = "0x6000167")]
		void Visit(YamlStream stream);

		[Token(Token = "0x6000168")]
		void Visit(YamlDocument document);

		[Token(Token = "0x6000169")]
		void Visit(YamlScalarNode scalar);

		[Token(Token = "0x600016A")]
		void Visit(YamlSequenceNode sequence);

		[Token(Token = "0x600016B")]
		void Visit(YamlMappingNode mapping);
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	internal class YamlAliasNode : YamlNode
	{
		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E18", Offset = "0x765E18")]
		private sealed class <get_AllNodes>d__8 : IEnumerable<YamlNode>, IEnumerable, IEnumerator<YamlNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private YamlNode <>2__current;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YamlAliasNode <>4__this;

			[Token(Token = "0x170000BA")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x17B4DB0", Offset = "0x17B4DB0", VA = "0x17B4DB0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x17B4DF8", Offset = "0x17B4DF8", VA = "0x17B4DF8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x17A8D04", Offset = "0x17A8D04", VA = "0x17A8D04")]
			[DebuggerHidden]
			public <get_AllNodes>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x17B4D50", Offset = "0x17B4D50", VA = "0x17B4D50", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x17B4D54", Offset = "0x17B4D54", VA = "0x17B4D54", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x17B4DB8", Offset = "0x17B4DB8", VA = "0x17B4DB8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x17B4E00", Offset = "0x17B4E00", VA = "0x17B4E00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x17B4EB0", Offset = "0x17B4EB0", VA = "0x17B4EB0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public override IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x17A8C7C", Offset = "0x17A8C7C", VA = "0x17A8C7C", Slot = "7")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x766778", Offset = "0x766778")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x17A896C", Offset = "0x17A896C", VA = "0x17A896C")]
		internal YamlAliasNode(string anchor)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x17A89A8", Offset = "0x17A89A8", VA = "0x17A89A8", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x17A89FC", Offset = "0x17A89FC", VA = "0x17A89FC", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x17A8A50", Offset = "0x17A8A50", VA = "0x17A8A50", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x17A8AA4", Offset = "0x17A8AA4", VA = "0x17A8AA4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x17A8BFC", Offset = "0x17A8BFC", VA = "0x17A8BFC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x17A8C2C", Offset = "0x17A8C2C", VA = "0x17A8C2C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class YamlDocument
	{
		[Token(Token = "0x20000CD")]
		private class AnchorAssigningVisitor : YamlVisitor
		{
			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly HashSet<string> existingAnchors;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly Dictionary<YamlNode, bool> visitedNodes;

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x17A96DC", Offset = "0x17A96DC", VA = "0x17A96DC")]
			public void AssignAnchors(YamlDocument document)
			{
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x17B531C", Offset = "0x17B531C", VA = "0x17B531C")]
			private void VisitNode(YamlNode node)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x17B5434", Offset = "0x17B5434", VA = "0x17B5434", Slot = "13")]
			protected override void Visit(YamlScalarNode scalar)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x17B5438", Offset = "0x17B5438", VA = "0x17B5438", Slot = "17")]
			protected override void Visit(YamlMappingNode mapping)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x17B543C", Offset = "0x17B543C", VA = "0x17B543C", Slot = "15")]
			protected override void Visit(YamlSequenceNode sequence)
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x17A960C", Offset = "0x17A960C", VA = "0x17A960C")]
			public AnchorAssigningVisitor()
			{
			}
		}

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766048", Offset = "0x766048")]
		private YamlNode <RootNode>k__BackingField;

		[Token(Token = "0x1700002F")]
		public YamlNode RootNode
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x17A90C0", Offset = "0x17A90C0", VA = "0x17A90C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7667D8", Offset = "0x7667D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x17A90C8", Offset = "0x17A90C8", VA = "0x17A90C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7667E8", Offset = "0x7667E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x17A9D80", Offset = "0x17A9D80", VA = "0x17A9D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x17A90D0", Offset = "0x17A90D0", VA = "0x17A90D0")]
		public YamlDocument(YamlNode rootNode)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x17A9104", Offset = "0x17A9104", VA = "0x17A9104")]
		public YamlDocument(string rootNode)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x17A91C4", Offset = "0x17A91C4", VA = "0x17A91C4")]
		internal YamlDocument(EventReader events)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x17A95A8", Offset = "0x17A95A8", VA = "0x17A95A8")]
		private void AssignAnchors()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x17A99B4", Offset = "0x17A99B4", VA = "0x17A99B4")]
		internal void Save(IEmitter emitter, bool assignAnchors = true)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x17A9CC4", Offset = "0x17A9CC4", VA = "0x17A9CC4")]
		public void Accept(IYamlVisitor visitor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class YamlMappingNode : YamlNode, IEnumerable<KeyValuePair<YamlNode, YamlNode>>, IEnumerable
	{
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E28", Offset = "0x765E28")]
		private sealed class <get_AllNodes>d__23 : IEnumerable<YamlNode>, IEnumerable, IEnumerator<YamlNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private YamlNode <>2__current;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YamlMappingNode <>4__this;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<KeyValuePair<YamlNode, YamlNode>> <>7__wrap1;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private KeyValuePair<YamlNode, YamlNode> <child>5__3;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private IEnumerator<YamlNode> <>7__wrap3;

			[Token(Token = "0x170000BC")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x600047D")]
				[Address(RVA = "0x17B5E68", Offset = "0x17B5E68", VA = "0x17B5E68", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600047F")]
				[Address(RVA = "0x17B5EB0", Offset = "0x17B5EB0", VA = "0x17B5EB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x17AC7E0", Offset = "0x17AC7E0", VA = "0x17AC7E0")]
			[DebuggerHidden]
			public <get_AllNodes>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x17B5440", Offset = "0x17B5440", VA = "0x17B5440", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x17B5794", Offset = "0x17B5794", VA = "0x17B5794", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x17B56D8", Offset = "0x17B56D8", VA = "0x17B56D8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x17B5560", Offset = "0x17B5560", VA = "0x17B5560")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x17B561C", Offset = "0x17B561C", VA = "0x17B561C")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x17B5E70", Offset = "0x17B5E70", VA = "0x17B5E70", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x17B5EB8", Offset = "0x17B5EB8", VA = "0x17B5EB8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x17B5F68", Offset = "0x17B5F68", VA = "0x17B5F68", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IDictionary<YamlNode, YamlNode> children;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766058", Offset = "0x766058")]
		private MappingStyle <Style>k__BackingField;

		[Token(Token = "0x17000031")]
		public IDictionary<YamlNode, YamlNode> Children
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x17AA0D0", Offset = "0x17AA0D0", VA = "0x17AA0D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public MappingStyle Style
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x17AA0D8", Offset = "0x17AA0D8", VA = "0x17AA0D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7667F8", Offset = "0x7667F8")]
			get
			{
				return default(MappingStyle);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x17AA0E0", Offset = "0x17AA0E0", VA = "0x17AA0E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766808", Offset = "0x766808")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public override IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x17AC758", Offset = "0x17AC758", VA = "0x17AC758", Slot = "7")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x766818", Offset = "0x766818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x17AA0E8", Offset = "0x17AA0E8", VA = "0x17AA0E8")]
		internal YamlMappingNode(EventReader events, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x17AA4F4", Offset = "0x17AA4F4", VA = "0x17AA4F4")]
		public YamlMappingNode()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x17AA578", Offset = "0x17AA578", VA = "0x17AA578")]
		public YamlMappingNode(params KeyValuePair<YamlNode, YamlNode>[] children)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x17AA57C", Offset = "0x17AA57C", VA = "0x17AA57C")]
		public YamlMappingNode(IEnumerable<KeyValuePair<YamlNode, YamlNode>> children)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x17AA928", Offset = "0x17AA928", VA = "0x17AA928")]
		public YamlMappingNode(params YamlNode[] children)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x17AA92C", Offset = "0x17AA92C", VA = "0x17AA92C")]
		public YamlMappingNode(IEnumerable<YamlNode> children)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x17AAD54", Offset = "0x17AAD54", VA = "0x17AAD54")]
		public void Add(YamlNode key, YamlNode value)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x17AAE1C", Offset = "0x17AAE1C", VA = "0x17AAE1C")]
		public void Add(string key, YamlNode value)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x17AAF1C", Offset = "0x17AAF1C", VA = "0x17AAF1C")]
		public void Add(YamlNode key, string value)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x17AB01C", Offset = "0x17AB01C", VA = "0x17AB01C")]
		public void Add(string key, string value)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x17AB148", Offset = "0x17AB148", VA = "0x17AB148", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x17AB9D8", Offset = "0x17AB9D8", VA = "0x17AB9D8", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x17ABE2C", Offset = "0x17ABE2C", VA = "0x17ABE2C", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x17ABEE8", Offset = "0x17ABEE8", VA = "0x17ABEE8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x17AC410", Offset = "0x17AC410", VA = "0x17AC410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x17AC818", Offset = "0x17AC818", VA = "0x17AC818", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x17ACC3C", Offset = "0x17ACC3C", VA = "0x17ACC3C", Slot = "8")]
		public IEnumerator<KeyValuePair<YamlNode, YamlNode>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x17ACCE8", Offset = "0x17ACCE8", VA = "0x17ACCE8", Slot = "9")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public abstract class YamlNode
	{
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766068", Offset = "0x766068")]
		private string <Anchor>k__BackingField;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766078", Offset = "0x766078")]
		private string <Tag>k__BackingField;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766088", Offset = "0x766088")]
		private Mark <Start>k__BackingField;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766098", Offset = "0x766098")]
		private Mark <End>k__BackingField;

		[Token(Token = "0x17000034")]
		public string Anchor
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x17ACD8C", Offset = "0x17ACD8C", VA = "0x17ACD8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766878", Offset = "0x766878")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x17ACD94", Offset = "0x17ACD94", VA = "0x17ACD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766888", Offset = "0x766888")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public string Tag
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x17ACD9C", Offset = "0x17ACD9C", VA = "0x17ACD9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766898", Offset = "0x766898")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x17ACDA4", Offset = "0x17ACDA4", VA = "0x17ACDA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7668A8", Offset = "0x7668A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Mark Start
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x17ACDAC", Offset = "0x17ACDAC", VA = "0x17ACDAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7668B8", Offset = "0x7668B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x17ACDB4", Offset = "0x17ACDB4", VA = "0x17ACDB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7668C8", Offset = "0x7668C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Mark End
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x17ACDBC", Offset = "0x17ACDBC", VA = "0x17ACDBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7668D8", Offset = "0x7668D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x17ACDC4", Offset = "0x17ACDC4", VA = "0x17ACDC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7668E8", Offset = "0x7668E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public abstract IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x60001A6")]
			get;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x17AA470", Offset = "0x17AA470", VA = "0x17AA470")]
		internal void Load(NodeEvent yamlEvent, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x17A935C", Offset = "0x17A935C", VA = "0x17A935C")]
		internal static YamlNode ParseNode(EventReader events, DocumentLoadingState state)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		internal abstract void ResolveAliases(DocumentLoadingState state);

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x17A9B74", Offset = "0x17A9B74", VA = "0x17A9B74")]
		internal void Save(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x600019F")]
		internal abstract void Emit(IEmitter emitter, EmitterState state);

		[Token(Token = "0x60001A0")]
		public abstract void Accept(IYamlVisitor visitor);

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x17A8B84", Offset = "0x17A8B84", VA = "0x17A8B84")]
		protected bool Equals(YamlNode other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x17A8BCC", Offset = "0x17A8BCC", VA = "0x17A8BCC")]
		protected static bool SafeEquals(object first, object second)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x17A8C14", Offset = "0x17A8C14", VA = "0x17A8C14", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x17AC738", Offset = "0x17AC738", VA = "0x17AC738")]
		protected static int GetHashCode(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x17AC74C", Offset = "0x17AC74C", VA = "0x17AC74C")]
		protected static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x17A89A0", Offset = "0x17A89A0", VA = "0x17A89A0")]
		protected YamlNode()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public sealed class YamlNodeIdentityEqualityComparer : IEqualityComparer<YamlNode>
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x17AD0B4", Offset = "0x17AD0B4", VA = "0x17AD0B4", Slot = "4")]
		public bool Equals(YamlNode x, YamlNode y)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x17AD0C0", Offset = "0x17AD0C0", VA = "0x17AD0C0", Slot = "5")]
		public int GetHashCode(YamlNode obj)
		{
			return default(int);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x17AD0E0", Offset = "0x17AD0E0", VA = "0x17AD0E0")]
		public YamlNodeIdentityEqualityComparer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x765B20", Offset = "0x765B20")]
	public class YamlScalarNode : YamlNode
	{
		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E38", Offset = "0x765E38")]
		private sealed class <get_AllNodes>d__20 : IEnumerable<YamlNode>, IEnumerable, IEnumerator<YamlNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private YamlNode <>2__current;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YamlScalarNode <>4__this;

			[Token(Token = "0x170000BE")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x17B5FCC", Offset = "0x17B5FCC", VA = "0x17B5FCC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x17B6014", Offset = "0x17B6014", VA = "0x17B6014", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x17AD574", Offset = "0x17AD574", VA = "0x17AD574")]
			[DebuggerHidden]
			public <get_AllNodes>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x17B5F6C", Offset = "0x17B5F6C", VA = "0x17B5F6C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x17B5F70", Offset = "0x17B5F70", VA = "0x17B5F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x17B5FD4", Offset = "0x17B5FD4", VA = "0x17B5FD4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x17B601C", Offset = "0x17B601C", VA = "0x17B601C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x17B60CC", Offset = "0x17B60CC", VA = "0x17B60CC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7660A8", Offset = "0x7660A8")]
		private string <Value>k__BackingField;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7660B8", Offset = "0x7660B8")]
		private ScalarStyle <Style>k__BackingField;

		[Token(Token = "0x17000039")]
		public string Value
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x17AD0E8", Offset = "0x17AD0E8", VA = "0x17AD0E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7668F8", Offset = "0x7668F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x17AD0F0", Offset = "0x17AD0F0", VA = "0x17AD0F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766908", Offset = "0x766908")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public ScalarStyle Style
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x17AD0F8", Offset = "0x17AD0F8", VA = "0x17AD0F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766918", Offset = "0x766918")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x17AD100", Offset = "0x17AD100", VA = "0x17AD100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766928", Offset = "0x766928")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public override IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x17AD4EC", Offset = "0x17AD4EC", VA = "0x17AD4EC", Slot = "7")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x766938", Offset = "0x766938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x17ACDCC", Offset = "0x17ACDCC", VA = "0x17ACDCC")]
		internal YamlScalarNode(EventReader events, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x17AD108", Offset = "0x17AD108", VA = "0x17AD108")]
		public YamlScalarNode()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x17A9190", Offset = "0x17A9190", VA = "0x17A9190")]
		public YamlScalarNode(string value)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x17AD110", Offset = "0x17AD110", VA = "0x17AD110", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x17AD164", Offset = "0x17AD164", VA = "0x17AD164", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x17AD270", Offset = "0x17AD270", VA = "0x17AD270", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x17AD32C", Offset = "0x17AD32C", VA = "0x17AD32C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x17AD40C", Offset = "0x17AD40C", VA = "0x17AD40C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x17AD460", Offset = "0x17AD460", VA = "0x17AD460")]
		public static implicit operator YamlScalarNode(string value)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x17AD4CC", Offset = "0x17AD4CC", VA = "0x17AD4CC")]
		public static explicit operator string(YamlScalarNode value)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x17AD4E4", Offset = "0x17AD4E4", VA = "0x17AD4E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x765B58", Offset = "0x765B58")]
	public class YamlSequenceNode : YamlNode, IEnumerable<YamlNode>, IEnumerable
	{
		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E48", Offset = "0x765E48")]
		private sealed class <get_AllNodes>d__19 : IEnumerable<YamlNode>, IEnumerable, IEnumerator<YamlNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private YamlNode <>2__current;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YamlSequenceNode <>4__this;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<YamlNode> <>7__wrap1;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<YamlNode> <>7__wrap2;

			[Token(Token = "0x170000C0")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x600048F")]
				[Address(RVA = "0x17B6768", Offset = "0x17B6768", VA = "0x17B6768", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000491")]
				[Address(RVA = "0x17B67B0", Offset = "0x17B67B0", VA = "0x17B67B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x17AEAB8", Offset = "0x17AEAB8", VA = "0x17AEAB8")]
			[DebuggerHidden]
			public <get_AllNodes>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x17B60D0", Offset = "0x17B60D0", VA = "0x17B60D0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x17B62D8", Offset = "0x17B62D8", VA = "0x17B62D8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x17B621C", Offset = "0x17B621C", VA = "0x17B621C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x17B6160", Offset = "0x17B6160", VA = "0x17B6160")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x17B6770", Offset = "0x17B6770", VA = "0x17B6770", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x17B67B8", Offset = "0x17B67B8", VA = "0x17B67B8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x17B6868", Offset = "0x17B6868", VA = "0x17B6868", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IList<YamlNode> children;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7660C8", Offset = "0x7660C8")]
		private SequenceStyle <Style>k__BackingField;

		[Token(Token = "0x1700003C")]
		public IList<YamlNode> Children
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x17AD5AC", Offset = "0x17AD5AC", VA = "0x17AD5AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public SequenceStyle Style
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x17AD5B4", Offset = "0x17AD5B4", VA = "0x17AD5B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766998", Offset = "0x766998")]
			get
			{
				return default(SequenceStyle);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x17AD5BC", Offset = "0x17AD5BC", VA = "0x17AD5BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7669A8", Offset = "0x7669A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x17AEA30", Offset = "0x17AEA30", VA = "0x17AEA30", Slot = "7")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7669B8", Offset = "0x7669B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x17ACE70", Offset = "0x17ACE70", VA = "0x17ACE70")]
		internal YamlSequenceNode(EventReader events, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x17AD5C4", Offset = "0x17AD5C4", VA = "0x17AD5C4")]
		public YamlSequenceNode()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x17AD648", Offset = "0x17AD648", VA = "0x17AD648")]
		public YamlSequenceNode(params YamlNode[] children)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x17AD64C", Offset = "0x17AD64C", VA = "0x17AD64C")]
		public YamlSequenceNode(IEnumerable<YamlNode> children)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x17AD9E8", Offset = "0x17AD9E8", VA = "0x17AD9E8")]
		public void Add(YamlNode child)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x17ADAA8", Offset = "0x17ADAA8", VA = "0x17ADAA8")]
		public void Add(string child)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x17ADBA0", Offset = "0x17ADBA0", VA = "0x17ADBA0", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x17ADF38", Offset = "0x17ADF38", VA = "0x17ADF38", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x17AE348", Offset = "0x17AE348", VA = "0x17AE348", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x17AE404", Offset = "0x17AE404", VA = "0x17AE404", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x17AE74C", Offset = "0x17AE74C", VA = "0x17AE74C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x17AEAF0", Offset = "0x17AEAF0", VA = "0x17AEAF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x17AEE78", Offset = "0x17AEE78", VA = "0x17AEE78", Slot = "8")]
		public IEnumerator<YamlNode> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x17AEF24", Offset = "0x17AEF24", VA = "0x17AEF24", Slot = "9")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class YamlStream : IEnumerable<YamlDocument>, IEnumerable
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IList<YamlDocument> documents;

		[Token(Token = "0x1700003F")]
		public IList<YamlDocument> Documents
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x17AEF28", Offset = "0x17AEF28", VA = "0x17AEF28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x17AEF30", Offset = "0x17AEF30", VA = "0x17AEF30")]
		public YamlStream()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x17AEFB4", Offset = "0x17AEFB4", VA = "0x17AEFB4")]
		public YamlStream(params YamlDocument[] documents)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x17AEFB8", Offset = "0x17AEFB8", VA = "0x17AEFB8")]
		public YamlStream(IEnumerable<YamlDocument> documents)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x17AF354", Offset = "0x17AF354", VA = "0x17AF354")]
		public void Add(YamlDocument document)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x17AF414", Offset = "0x17AF414", VA = "0x17AF414")]
		public void Load(TextReader input)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x17AF4B0", Offset = "0x17AF4B0", VA = "0x17AF4B0")]
		public void Load(EventReader reader)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x17AF68C", Offset = "0x17AF68C", VA = "0x17AF68C")]
		public void Save(TextWriter output)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x17AF694", Offset = "0x17AF694", VA = "0x17AF694")]
		public void Save(TextWriter output, bool assignAnchors)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x17AFABC", Offset = "0x17AFABC", VA = "0x17AFABC")]
		public void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x17AFB74", Offset = "0x17AFB74", VA = "0x17AFB74", Slot = "4")]
		public IEnumerator<YamlDocument> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x17AFC20", Offset = "0x17AFC20", VA = "0x17AFC20", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x765B90", Offset = "0x765B90")]
	public abstract class YamlVisitor : IYamlVisitor
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x17AFD78", Offset = "0x17AFD78", VA = "0x17AFD78", Slot = "9")]
		protected virtual void Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x17AFD7C", Offset = "0x17AFD7C", VA = "0x17AFD7C", Slot = "10")]
		protected virtual void Visited(YamlStream stream)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x17AFD80", Offset = "0x17AFD80", VA = "0x17AFD80", Slot = "11")]
		protected virtual void Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x17AFD84", Offset = "0x17AFD84", VA = "0x17AFD84", Slot = "12")]
		protected virtual void Visited(YamlDocument document)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x17AFD88", Offset = "0x17AFD88", VA = "0x17AFD88", Slot = "13")]
		protected virtual void Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x17AFD8C", Offset = "0x17AFD8C", VA = "0x17AFD8C", Slot = "14")]
		protected virtual void Visited(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x17AFD90", Offset = "0x17AFD90", VA = "0x17AFD90", Slot = "15")]
		protected virtual void Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x17AFD94", Offset = "0x17AFD94", VA = "0x17AFD94", Slot = "16")]
		protected virtual void Visited(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x17AFD98", Offset = "0x17AFD98", VA = "0x17AFD98", Slot = "17")]
		protected virtual void Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x17AFD9C", Offset = "0x17AFD9C", VA = "0x17AFD9C", Slot = "18")]
		protected virtual void Visited(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x17AFDA0", Offset = "0x17AFDA0", VA = "0x17AFDA0", Slot = "19")]
		protected virtual void VisitChildren(YamlStream stream)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x17B0060", Offset = "0x17B0060", VA = "0x17B0060", Slot = "20")]
		protected virtual void VisitChildren(YamlDocument document)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x17B0090", Offset = "0x17B0090", VA = "0x17B0090", Slot = "21")]
		protected virtual void VisitChildren(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x17B0358", Offset = "0x17B0358", VA = "0x17B0358", Slot = "22")]
		protected virtual void VisitChildren(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x17B0664", Offset = "0x17B0664", VA = "0x17B0664", Slot = "4")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x17B06B8", Offset = "0x17B06B8", VA = "0x17B06B8", Slot = "5")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x17B070C", Offset = "0x17B070C", VA = "0x17B070C", Slot = "6")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x17B0750", Offset = "0x17B0750", VA = "0x17B0750", Slot = "7")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x17B07AC", Offset = "0x17B07AC", VA = "0x17B07AC", Slot = "8")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x17B0808", Offset = "0x17B0808", VA = "0x17B0808")]
		protected YamlVisitor()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public abstract class YamlVisitorBase : IYamlVisitor
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x17B0810", Offset = "0x17B0810", VA = "0x17B0810", Slot = "9")]
		protected virtual void Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x17B0820", Offset = "0x17B0820", VA = "0x17B0820", Slot = "10")]
		protected virtual void Visited(YamlStream stream)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x17B0824", Offset = "0x17B0824", VA = "0x17B0824", Slot = "11")]
		protected virtual void Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x17B0834", Offset = "0x17B0834", VA = "0x17B0834", Slot = "12")]
		protected virtual void Visited(YamlDocument document)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x17B0838", Offset = "0x17B0838", VA = "0x17B0838", Slot = "13")]
		protected virtual void Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x17B083C", Offset = "0x17B083C", VA = "0x17B083C", Slot = "14")]
		protected virtual void Visited(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x17B0840", Offset = "0x17B0840", VA = "0x17B0840", Slot = "15")]
		protected virtual void Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x17B0850", Offset = "0x17B0850", VA = "0x17B0850", Slot = "16")]
		protected virtual void Visited(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x17B0854", Offset = "0x17B0854", VA = "0x17B0854", Slot = "17")]
		protected virtual void Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x17B0864", Offset = "0x17B0864", VA = "0x17B0864", Slot = "18")]
		protected virtual void Visited(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x17B0868", Offset = "0x17B0868", VA = "0x17B0868", Slot = "19")]
		protected virtual void VisitPair(YamlNode key, YamlNode value)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x17B08B8", Offset = "0x17B08B8", VA = "0x17B08B8", Slot = "20")]
		protected virtual void VisitChildren(YamlStream stream)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x17B0B78", Offset = "0x17B0B78", VA = "0x17B0B78", Slot = "21")]
		protected virtual void VisitChildren(YamlDocument document)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x17B0BA8", Offset = "0x17B0BA8", VA = "0x17B0BA8", Slot = "22")]
		protected virtual void VisitChildren(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x17B0E70", Offset = "0x17B0E70", VA = "0x17B0E70", Slot = "23")]
		protected virtual void VisitChildren(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x17B115C", Offset = "0x17B115C", VA = "0x17B115C", Slot = "4")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x17B1198", Offset = "0x17B1198", VA = "0x17B1198", Slot = "5")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x17B11D4", Offset = "0x17B11D4", VA = "0x17B11D4", Slot = "6")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x17B1218", Offset = "0x17B1218", VA = "0x17B1218", Slot = "7")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x17B125C", Offset = "0x17B125C", VA = "0x17B125C", Slot = "8")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x17B12A0", Offset = "0x17B12A0", VA = "0x17B12A0")]
		protected YamlVisitorBase()
		{
		}
	}
}
namespace YamlDotNet.Helpers
{
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x765BC8", Offset = "0x765BC8")]
	internal sealed class GenericCollectionToNonGenericAdapter : IList, ICollection, IEnumerable
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object genericCollection;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly MethodInfo addMethod;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly MethodInfo indexerSetter;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly MethodInfo countGetter;

		[Token(Token = "0x17000040")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x119E338", Offset = "0x119E338", VA = "0x119E338", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x119E378", Offset = "0x119E378", VA = "0x119E378", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public object Item
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x119E438", Offset = "0x119E438", VA = "0x119E438", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x119E478", Offset = "0x119E478", VA = "0x119E478", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int Count
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x119E5F0", Offset = "0x119E5F0", VA = "0x119E5F0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000044")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x119E630", Offset = "0x119E630", VA = "0x119E630", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public object SyncRoot
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x119E670", Offset = "0x119E670", VA = "0x119E670", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1190674", Offset = "0x1190674", VA = "0x1190674")]
		public GenericCollectionToNonGenericAdapter(object genericCollection, Type genericCollectionType, Type genericListType)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x119E10C", Offset = "0x119E10C", VA = "0x119E10C", Slot = "6")]
		public int Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x119E238", Offset = "0x119E238", VA = "0x119E238", Slot = "8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x119E278", Offset = "0x119E278", VA = "0x119E278", Slot = "7")]
		public bool Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x119E2B8", Offset = "0x119E2B8", VA = "0x119E2B8", Slot = "11")]
		public int IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x119E2F8", Offset = "0x119E2F8", VA = "0x119E2F8", Slot = "12")]
		public void Insert(int index, object value)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x119E3B8", Offset = "0x119E3B8", VA = "0x119E3B8", Slot = "13")]
		public void Remove(object value)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x119E3F8", Offset = "0x119E3F8", VA = "0x119E3F8", Slot = "14")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x119E5B0", Offset = "0x119E5B0", VA = "0x119E5B0", Slot = "15")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x119E6B0", Offset = "0x119E6B0", VA = "0x119E6B0", Slot = "18")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x765C00", Offset = "0x765C00")]
	internal sealed class GenericDictionaryToNonGenericAdapter : IDictionary, ICollection, IEnumerable
	{
		[Token(Token = "0x20000D1")]
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IEnumerator enumerator;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly MethodInfo getKeyMethod;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly MethodInfo getValueMethod;

			[Token(Token = "0x170000C2")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6000495")]
				[Address(RVA = "0x17B27D8", Offset = "0x17B27D8", VA = "0x17B27D8", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Token(Token = "0x170000C3")]
			public object Key
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0x17B2828", Offset = "0x17B2828", VA = "0x17B2828", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			public object Value
			{
				[Token(Token = "0x6000497")]
				[Address(RVA = "0x17B28F4", Offset = "0x17B28F4", VA = "0x17B28F4", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			public object Current
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0x17B29C0", Offset = "0x17B29C0", VA = "0x17B29C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x17B2584", Offset = "0x17B2584", VA = "0x17B2584")]
			public DictionaryEnumerator(object genericDictionary, Type genericDictionaryType)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x17B2A28", Offset = "0x17B2A28", VA = "0x17B2A28", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x17B2AD4", Offset = "0x17B2AD4", VA = "0x17B2AD4", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object genericDictionary;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Type genericDictionaryType;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly MethodInfo indexerSetter;

		[Token(Token = "0x17000046")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x119E8D8", Offset = "0x119E8D8", VA = "0x119E8D8", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x119E918", Offset = "0x119E918", VA = "0x119E918", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public ICollection Keys
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x119E958", Offset = "0x119E958", VA = "0x119E958", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public ICollection Values
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x119E9D8", Offset = "0x119E9D8", VA = "0x119E9D8", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public object Item
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x119EA18", Offset = "0x119EA18", VA = "0x119EA18", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x119EA58", Offset = "0x119EA58", VA = "0x119EA58", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int Count
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x119EBA4", Offset = "0x119EBA4", VA = "0x119EBA4", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x119EBE4", Offset = "0x119EBE4", VA = "0x119EBE4", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public object SyncRoot
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x119EC24", Offset = "0x119EC24", VA = "0x119EC24", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1193EE4", Offset = "0x1193EE4", VA = "0x1193EE4")]
		public GenericDictionaryToNonGenericAdapter(object genericDictionary, Type genericDictionaryType)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x119E7A8", Offset = "0x119E7A8", VA = "0x119E7A8", Slot = "14")]
		public void Add(object key, object value)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x119E7E8", Offset = "0x119E7E8", VA = "0x119E7E8", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x119E828", Offset = "0x119E828", VA = "0x119E828", Slot = "7")]
		public bool Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x119E868", Offset = "0x119E868", VA = "0x119E868", Slot = "8")]
		public IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x119E998", Offset = "0x119E998", VA = "0x119E998", Slot = "9")]
		public void Remove(object key)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x119EB64", Offset = "0x119EB64", VA = "0x119EB64", Slot = "10")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x119EC64", Offset = "0x119EC64", VA = "0x119EC64", Slot = "13")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
namespace YamlDotNet.Core
{
	[Serializable]
	[Token(Token = "0x200006A")]
	public class AnchorNotFoundException : YamlException
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x118E97C", Offset = "0x118E97C", VA = "0x118E97C")]
		public AnchorNotFoundException()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x118E984", Offset = "0x118E984", VA = "0x118E984")]
		public AnchorNotFoundException(string message)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x118E98C", Offset = "0x118E98C", VA = "0x118E98C")]
		public AnchorNotFoundException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x118E994", Offset = "0x118E994", VA = "0x118E994")]
		public AnchorNotFoundException(string message, Exception inner)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	internal class CharacterAnalyzer<TBuffer> where TBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TBuffer buffer;

		[Token(Token = "0x1700004E")]
		public TBuffer Buffer
		{
			[Token(Token = "0x6000229")]
			get
			{
				return (TBuffer)null;
			}
		}

		[Token(Token = "0x1700004F")]
		public bool EndOfInput
		{
			[Token(Token = "0x600022A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000228")]
		public CharacterAnalyzer(TBuffer buffer)
		{
		}

		[Token(Token = "0x600022B")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x600022C")]
		public void Skip(int length)
		{
		}

		[Token(Token = "0x600022D")]
		public bool IsAlphaNumericDashOrUnderscore(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		public bool IsAscii(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		public bool IsPrintable(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		public bool IsDigit(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		public int AsDigit(int offset = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6000232")]
		public bool IsHex(int offset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		public int AsHex(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x6000234")]
		public bool IsSpace(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		public bool IsZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		public bool IsTab(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		public bool IsWhite(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		public bool IsBreak(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		public bool IsCrLf(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		public bool IsBreakOrZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600023B")]
		public bool IsWhiteBreakOrZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		public bool Check(char expected, int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		public bool Check(string expectedCharacters, int offset = 0)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200006C")]
	internal static class Constants
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TagDirective[] DefaultTagDirectives;

		[Token(Token = "0x4000075")]
		public const int MajorVersion = 1;

		[Token(Token = "0x4000076")]
		public const int MinorVersion = 1;

		[Token(Token = "0x4000077")]
		public const char HandleCharacter = '!';

		[Token(Token = "0x4000078")]
		public const string DefaultHandle = "!";
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	internal class Cursor
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7660D8", Offset = "0x7660D8")]
		private int <Index>k__BackingField;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7660E8", Offset = "0x7660E8")]
		private int <Line>k__BackingField;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7660F8", Offset = "0x7660F8")]
		private int <LineOffset>k__BackingField;

		[Token(Token = "0x17000050")]
		public int Index
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x1190E20", Offset = "0x1190E20", VA = "0x1190E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A18", Offset = "0x766A18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1190E28", Offset = "0x1190E28", VA = "0x1190E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A28", Offset = "0x766A28")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int Line
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x1190E30", Offset = "0x1190E30", VA = "0x1190E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A38", Offset = "0x766A38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x1190E38", Offset = "0x1190E38", VA = "0x1190E38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A48", Offset = "0x766A48")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int LineOffset
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x1190E40", Offset = "0x1190E40", VA = "0x1190E40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A58", Offset = "0x766A58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1190E48", Offset = "0x1190E48", VA = "0x1190E48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A68", Offset = "0x766A68")]
			set
			{
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1190E50", Offset = "0x1190E50", VA = "0x1190E50")]
		public Cursor()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1190E7C", Offset = "0x1190E7C", VA = "0x1190E7C")]
		public Cursor(Cursor cursor)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1190EC4", Offset = "0x1190EC4", VA = "0x1190EC4")]
		public Mark Mark()
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1191048", Offset = "0x1191048", VA = "0x1191048")]
		public void Skip()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1191064", Offset = "0x1191064", VA = "0x1191064")]
		public void SkipLineByOffset(int offset)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x119107C", Offset = "0x119107C", VA = "0x119107C")]
		public void ForceSkipLineAfterNonBreak()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class DuplicateAnchorException : YamlException
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x11953E4", Offset = "0x11953E4", VA = "0x11953E4")]
		public DuplicateAnchorException()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x11953EC", Offset = "0x11953EC", VA = "0x11953EC")]
		public DuplicateAnchorException(string message)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x118D344", Offset = "0x118D344", VA = "0x118D344")]
		public DuplicateAnchorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x11953F4", Offset = "0x11953F4", VA = "0x11953F4")]
		public DuplicateAnchorException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class Emitter : IEmitter
	{
		[Token(Token = "0x20000D2")]
		private class AnchorData
		{
			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string anchor;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isAlias;

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x17B256C", Offset = "0x17B256C", VA = "0x17B256C")]
			public AnchorData()
			{
			}
		}

		[Token(Token = "0x20000D3")]
		private class TagData
		{
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string handle;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string suffix;

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x17B257C", Offset = "0x17B257C", VA = "0x17B257C")]
			public TagData()
			{
			}
		}

		[Token(Token = "0x20000D4")]
		private class ScalarData
		{
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string value;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isMultiline;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool isFlowPlainAllowed;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool isBlockPlainAllowed;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
			public bool isSingleQuotedAllowed;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isBlockAllowed;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ScalarStyle style;

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x17B2574", Offset = "0x17B2574", VA = "0x17B2574")]
			public ScalarData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E58", Offset = "0x765E58")]
		private sealed class <>c
		{
			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static MatchEvaluator <>9__87_0;

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x17B240C", Offset = "0x17B240C", VA = "0x17B240C")]
			public <>c()
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x17B2414", Offset = "0x17B2414", VA = "0x17B2414")]
			internal string <UrlEncode>b__87_0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x400007C")]
		private const int MinBestIndent = 2;

		[Token(Token = "0x400007D")]
		private const int MaxBestIndent = 9;

		[Token(Token = "0x400007E")]
		private const int MaxAliasLength = 128;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex uriReplacer;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TextWriter output;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly bool outputUsesUnicodeEncoding;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private readonly bool isCanonical;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly int bestIndent;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int bestWidth;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private EmitterState state;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Stack<EmitterState> states;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Queue<ParsingEvent> events;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Stack<int> indents;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly TagDirectiveCollection tagDirectives;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int indent;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int flowLevel;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isMappingContext;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool isSimpleKeyContext;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool isRootContext;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int column;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isWhitespace;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isIndentation;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isOpenEnded;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool isDocumentEndWritten;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly AnchorData anchorData;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly TagData tagData;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly ScalarData scalarData;

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x119541C", Offset = "0x119541C", VA = "0x119541C")]
		public Emitter(TextWriter output)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x119542C", Offset = "0x119542C", VA = "0x119542C")]
		public Emitter(TextWriter output, int bestIndent)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1195438", Offset = "0x1195438", VA = "0x1195438")]
		public Emitter(TextWriter output, int bestIndent, int bestWidth)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1195440", Offset = "0x1195440", VA = "0x1195440")]
		public Emitter(TextWriter output, int bestIndent, int bestWidth, bool isCanonical)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1195938", Offset = "0x1195938", VA = "0x1195938", Slot = "4")]
		public void Emit(ParsingEvent @event)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1195EDC", Offset = "0x1195EDC", VA = "0x1195EDC")]
		private bool NeedMoreEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1195AA0", Offset = "0x1195AA0", VA = "0x1195AA0")]
		private void AnalyzeEvent(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x11960FC", Offset = "0x11960FC", VA = "0x11960FC")]
		private void AnalyzeAnchor(string anchor, bool isAlias)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1196140", Offset = "0x1196140", VA = "0x1196140")]
		private void AnalyzeScalar(YamlDotNet.Core.Events.Scalar scalar)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1196B24", Offset = "0x1196B24", VA = "0x1196B24")]
		private bool ValueIsRepresentableInOutputEncoding(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x119581C", Offset = "0x119581C", VA = "0x119581C")]
		private bool IsUnicode(Encoding encoding)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x119681C", Offset = "0x119681C", VA = "0x119681C")]
		private void AnalyzeTag(string tag)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1195C50", Offset = "0x1195C50", VA = "0x1195C50")]
		private void StateMachine(ParsingEvent evt)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1196CA4", Offset = "0x1196CA4", VA = "0x1196CA4")]
		private void EmitComment(YamlDotNet.Core.Events.Comment comment)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1196D50", Offset = "0x1196D50", VA = "0x1196D50")]
		private void EmitStreamStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1196E48", Offset = "0x1196E48", VA = "0x1196E48")]
		private void EmitDocumentStart(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1198384", Offset = "0x1198384", VA = "0x1198384")]
		private TagDirectiveCollection NonDefaultTagsAmong(IEnumerable<TagDirective> tagCollection)
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1198858", Offset = "0x1198858", VA = "0x1198858")]
		private void AnalyzeVersionDirective(VersionDirective versionDirective)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x11988E0", Offset = "0x11988E0", VA = "0x11988E0")]
		private void AppendTagDirectiveTo(TagDirective value, bool allowDuplicates, TagDirectiveCollection tagDirectives)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1197718", Offset = "0x1197718", VA = "0x1197718")]
		private void EmitDocumentContent(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1198BEC", Offset = "0x1198BEC", VA = "0x1198BEC")]
		private void EmitNode(ParsingEvent evt, bool isRoot, bool isMapping, bool isSimpleKey)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1198D38", Offset = "0x1198D38", VA = "0x1198D38")]
		private void EmitAlias()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1198D9C", Offset = "0x1198D9C", VA = "0x1198D9C")]
		private void EmitScalar(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x11990CC", Offset = "0x11990CC", VA = "0x11990CC")]
		private void SelectScalarStyle(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x119947C", Offset = "0x119947C", VA = "0x119947C")]
		private void ProcessScalar()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1199560", Offset = "0x1199560", VA = "0x1199560")]
		private void WritePlainScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1199788", Offset = "0x1199788", VA = "0x1199788")]
		private void WriteSingleQuotedScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x11999C8", Offset = "0x11999C8", VA = "0x11999C8")]
		private void WriteDoubleQuotedScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1199E28", Offset = "0x1199E28", VA = "0x1199E28")]
		private void WriteLiteralScalar(string value)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1199FB8", Offset = "0x1199FB8", VA = "0x1199FB8")]
		private void WriteFoldedScalar(string value)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x119A32C", Offset = "0x119A32C", VA = "0x119A32C")]
		private static bool IsSpace(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x119A33C", Offset = "0x119A33C", VA = "0x119A33C")]
		private static bool IsBreak(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x119A62C", Offset = "0x119A62C", VA = "0x119A62C")]
		private static bool IsBlank(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x119A378", Offset = "0x119A378", VA = "0x119A378")]
		private static bool IsPrintable(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1198E64", Offset = "0x1198E64", VA = "0x1198E64")]
		private void EmitSequenceStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1198F44", Offset = "0x1198F44", VA = "0x1198F44")]
		private void EmitMappingStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1199024", Offset = "0x1199024", VA = "0x1199024")]
		private void ProcessAnchor()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x11992F4", Offset = "0x11992F4", VA = "0x11992F4")]
		private void ProcessTag()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1197794", Offset = "0x1197794", VA = "0x1197794")]
		private void EmitDocumentEnd(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x11978D4", Offset = "0x11978D4", VA = "0x11978D4")]
		private void EmitFlowSequenceItem(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1197B00", Offset = "0x1197B00", VA = "0x1197B00")]
		private void EmitFlowMappingKey(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1197DA0", Offset = "0x1197DA0", VA = "0x1197DA0")]
		private void EmitFlowMappingValue(ParsingEvent evt, bool isSimple)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1197E90", Offset = "0x1197E90", VA = "0x1197E90")]
		private void EmitBlockSequenceItem(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1198024", Offset = "0x1198024", VA = "0x1198024")]
		private void EmitBlockMappingKey(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x11981E0", Offset = "0x11981E0", VA = "0x11981E0")]
		private void EmitBlockMappingValue(ParsingEvent evt, bool isSimple)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x11993E4", Offset = "0x11993E4", VA = "0x11993E4")]
		private void IncreaseIndent(bool isFlow, bool isIndentless)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1198A4C", Offset = "0x1198A4C", VA = "0x1198A4C")]
		private bool CheckEmptyDocument()
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x119A924", Offset = "0x119A924", VA = "0x119A924")]
		private bool CheckSimpleKey()
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x119AA98", Offset = "0x119AA98", VA = "0x119AA98")]
		private int SafeStringLength(string value)
		{
			return default(int);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x119A648", Offset = "0x119A648", VA = "0x119A648")]
		private bool CheckEmptySequence()
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x119A7A4", Offset = "0x119A7A4", VA = "0x119A7A4")]
		private bool CheckEmptyMapping()
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x119A3E0", Offset = "0x119A3E0", VA = "0x119A3E0")]
		private void WriteBlockScalarHints(string value)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1198704", Offset = "0x1198704", VA = "0x1198704")]
		private void WriteIndicator(string indicator, bool needWhitespace, bool whitespace, bool indentation)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1198778", Offset = "0x1198778", VA = "0x1198778")]
		private void WriteIndent()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x119A900", Offset = "0x119A900", VA = "0x119A900")]
		private void WriteAnchor(string value)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x11989B8", Offset = "0x11989B8", VA = "0x11989B8")]
		private void WriteTagHandle(string value)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x11989FC", Offset = "0x11989FC", VA = "0x11989FC")]
		private void WriteTagContent(string value, bool needsWhitespace)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x119AAAC", Offset = "0x119AAAC", VA = "0x119AAAC")]
		private string UrlEncode(string text)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x11982B8", Offset = "0x11982B8", VA = "0x11982B8")]
		private void Write(char value)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1198334", Offset = "0x1198334", VA = "0x1198334")]
		private void Write(string value)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x11982F8", Offset = "0x11982F8", VA = "0x11982F8")]
		private void WriteBreak()
		{
		}
	}
	[Token(Token = "0x2000070")]
	internal enum EmitterState
	{
		[Token(Token = "0x4000098")]
		StreamStart,
		[Token(Token = "0x4000099")]
		StreamEnd,
		[Token(Token = "0x400009A")]
		FirstDocumentStart,
		[Token(Token = "0x400009B")]
		DocumentStart,
		[Token(Token = "0x400009C")]
		DocumentContent,
		[Token(Token = "0x400009D")]
		DocumentEnd,
		[Token(Token = "0x400009E")]
		FlowSequenceFirstItem,
		[Token(Token = "0x400009F")]
		FlowSequenceItem,
		[Token(Token = "0x40000A0")]
		FlowMappingFirstKey,
		[Token(Token = "0x40000A1")]
		FlowMappingKey,
		[Token(Token = "0x40000A2")]
		FlowMappingSimpleValue,
		[Token(Token = "0x40000A3")]
		FlowMappingValue,
		[Token(Token = "0x40000A4")]
		BlockSequenceFirstItem,
		[Token(Token = "0x40000A5")]
		BlockSequenceItem,
		[Token(Token = "0x40000A6")]
		BlockMappingFirstKey,
		[Token(Token = "0x40000A7")]
		BlockMappingKey,
		[Token(Token = "0x40000A8")]
		BlockMappingSimpleValue,
		[Token(Token = "0x40000A9")]
		BlockMappingValue
	}
	[Token(Token = "0x2000071")]
	public class EventReader
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IParser parser;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool endOfStream;

		[Token(Token = "0x17000053")]
		public IParser Parser
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x119B5B8", Offset = "0x119B5B8", VA = "0x119B5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1193458", Offset = "0x1193458", VA = "0x1193458")]
		public EventReader(IParser parser)
		{
		}

		[Token(Token = "0x600028F")]
		public T Expect<T>() where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		public bool Accept<T>() where T : ParsingEvent
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x119B5C0", Offset = "0x119B5C0", VA = "0x119B5C0")]
		private void ThrowIfAtEndOfStream()
		{
		}

		[Token(Token = "0x6000292")]
		public T Allow<T>() where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		public T Peek<T>() where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x119B60C", Offset = "0x119B60C", VA = "0x119B60C")]
		public void SkipThisAndNestedEvents()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x119B4F8", Offset = "0x119B4F8", VA = "0x119B4F8")]
		private void MoveNext()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x765C38", Offset = "0x765C38")]
	public class FakeList<T>
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IEnumerator<T> collection;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int currentIndex;

		[Token(Token = "0x17000054")]
		public T Item
		{
			[Token(Token = "0x6000298")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6000296")]
		public FakeList(IEnumerator<T> collection)
		{
		}

		[Token(Token = "0x6000297")]
		public FakeList(IEnumerable<T> collection)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class ForwardAnchorNotSupportedException : YamlException
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x119B8FC", Offset = "0x119B8FC", VA = "0x119B8FC")]
		public ForwardAnchorNotSupportedException()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x119B904", Offset = "0x119B904", VA = "0x119B904")]
		public ForwardAnchorNotSupportedException(string message)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x119084C", Offset = "0x119084C", VA = "0x119084C")]
		public ForwardAnchorNotSupportedException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x119B90C", Offset = "0x119B90C", VA = "0x119B90C")]
		public ForwardAnchorNotSupportedException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000074")]
	internal static class HashCode
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x119F198", Offset = "0x119F198", VA = "0x119F198")]
		public static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000075")]
	public interface IEmitter
	{
		[Token(Token = "0x600029E")]
		void Emit(ParsingEvent @event);
	}
	[Token(Token = "0x2000076")]
	internal interface ILookAheadBuffer
	{
		[Token(Token = "0x17000055")]
		bool EndOfInput
		{
			[Token(Token = "0x600029F")]
			get;
		}

		[Token(Token = "0x60002A0")]
		char Peek(int offset);

		[Token(Token = "0x60002A1")]
		void Skip(int length);
	}
	[Token(Token = "0x2000077")]
	public interface IParser
	{
		[Token(Token = "0x17000056")]
		ParsingEvent Current
		{
			[Token(Token = "0x60002A2")]
			get;
		}

		[Token(Token = "0x60002A3")]
		bool MoveNext();
	}
	[Token(Token = "0x2000078")]
	public interface IScanner
	{
		[Token(Token = "0x17000057")]
		Mark CurrentPosition
		{
			[Token(Token = "0x60002A4")]
			get;
		}

		[Token(Token = "0x17000058")]
		Token Current
		{
			[Token(Token = "0x60002A5")]
			get;
		}

		[Token(Token = "0x60002A6")]
		bool MoveNext();

		[Token(Token = "0x60002A7")]
		bool MoveNextWithoutConsuming();

		[Token(Token = "0x60002A8")]
		void ConsumeCurrent();
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class InsertionQueue<T>
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IList<T> items;

		[Token(Token = "0x17000059")]
		public int Count
		{
			[Token(Token = "0x60002A9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002AA")]
		public void Enqueue(T item)
		{
		}

		[Token(Token = "0x60002AB")]
		public T Dequeue()
		{
			return (T)null;
		}

		[Token(Token = "0x60002AC")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x60002AD")]
		public InsertionQueue()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class LookAheadBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TextReader input;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly char[] buffer;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int firstIndex;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int count;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool endOfInput;

		[Token(Token = "0x1700005A")]
		public bool EndOfInput
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x119FBA4", Offset = "0x119FBA4", VA = "0x119FBA4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x119FA80", Offset = "0x119FA80", VA = "0x119FA80")]
		public LookAheadBuffer(TextReader input, int capacity)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x119FBC4", Offset = "0x119FBC4", VA = "0x119FBC4")]
		private int GetIndexForOffset(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x119FBF4", Offset = "0x119FBF4", VA = "0x119FBF4", Slot = "5")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x119FCE8", Offset = "0x119FCE8", VA = "0x119FCE8")]
		public void Cache(int length)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x119FD8C", Offset = "0x119FD8C", VA = "0x119FD8C", Slot = "6")]
		public void Skip(int length)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class Mark : IEquatable<Mark>, IComparable<Mark>, IComparable
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Mark Empty;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766108", Offset = "0x766108")]
		private int <Index>k__BackingField;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766118", Offset = "0x766118")]
		private int <Line>k__BackingField;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766128", Offset = "0x766128")]
		private int <Column>k__BackingField;

		[Token(Token = "0x1700005B")]
		public int Index
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x11A0678", Offset = "0x11A0678", VA = "0x11A0678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A78", Offset = "0x766A78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x11A0680", Offset = "0x11A0680", VA = "0x11A0680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A88", Offset = "0x766A88")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public int Line
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x11A0688", Offset = "0x11A0688", VA = "0x11A0688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766A98", Offset = "0x766A98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x11A0690", Offset = "0x11A0690", VA = "0x11A0690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766AA8", Offset = "0x766AA8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public int Column
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x11A0698", Offset = "0x11A0698", VA = "0x11A0698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766AB8", Offset = "0x766AB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x11A06A0", Offset = "0x11A06A0", VA = "0x11A06A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766AC8", Offset = "0x766AC8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x11A06A8", Offset = "0x11A06A8", VA = "0x11A06A8")]
		public Mark()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1190F38", Offset = "0x1190F38", VA = "0x1190F38")]
		public Mark(int index, int line, int column)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x11A06D4", Offset = "0x11A06D4", VA = "0x11A06D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x11A079C", Offset = "0x11A079C", VA = "0x11A079C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x11A0854", Offset = "0x11A0854", VA = "0x11A0854", Slot = "4")]
		public bool Equals(Mark other)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x11A0894", Offset = "0x11A0894", VA = "0x11A0894", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x11A090C", Offset = "0x11A090C", VA = "0x11A090C", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x11A09E0", Offset = "0x11A09E0", VA = "0x11A09E0", Slot = "5")]
		public int CompareTo(Mark other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200007C")]
	public sealed class MergingParser : IParser
	{
		[Token(Token = "0x20000D6")]
		private class ParsingEventCloner : IParsingEventVisitor
		{
			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ParsingEvent clonedEvent;

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x17B2D38", Offset = "0x17B2D38", VA = "0x17B2D38")]
			public ParsingEvent Clone(ParsingEvent e)
			{
				return null;
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x17B2D74", Offset = "0x17B2D74", VA = "0x17B2D74", Slot = "4")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.AnchorAlias e)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x17B2E08", Offset = "0x17B2E08", VA = "0x17B2E08", Slot = "5")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.StreamStart e)
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x17B2E48", Offset = "0x17B2E48", VA = "0x17B2E48", Slot = "6")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.StreamEnd e)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x17B2E88", Offset = "0x17B2E88", VA = "0x17B2E88", Slot = "7")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.DocumentStart e)
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x17B2EC8", Offset = "0x17B2EC8", VA = "0x17B2EC8", Slot = "8")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.DocumentEnd e)
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x17B2F08", Offset = "0x17B2F08", VA = "0x17B2F08", Slot = "9")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.Scalar e)
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x17B2FD0", Offset = "0x17B2FD0", VA = "0x17B2FD0", Slot = "10")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(SequenceStart e)
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x17B307C", Offset = "0x17B307C", VA = "0x17B307C", Slot = "11")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(SequenceEnd e)
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x17B3100", Offset = "0x17B3100", VA = "0x17B3100", Slot = "12")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(MappingStart e)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x17B31B0", Offset = "0x17B31B0", VA = "0x17B31B0", Slot = "13")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(MappingEnd e)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x17B3234", Offset = "0x17B3234", VA = "0x17B3234", Slot = "14")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.Comment e)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x17B3274", Offset = "0x17B3274", VA = "0x17B3274")]
			public ParsingEventCloner()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E68", Offset = "0x765E68")]
		private sealed class <>c
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IEnumerable<ParsingEvent>, IEnumerable<ParsingEvent>> <>9__8_0;

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x17B2BE8", Offset = "0x17B2BE8", VA = "0x17B2BE8")]
			public <>c()
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x17B2BF0", Offset = "0x17B2BF0", VA = "0x17B2BF0")]
			internal IEnumerable<ParsingEvent> <MoveNext>b__8_0(IEnumerable<ParsingEvent> e)
			{
				return null;
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765E78", Offset = "0x765E78")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string mappingAlias;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nesting;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParsingEventCloner cloner;

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x17B2BF8", Offset = "0x17B2BF8", VA = "0x17B2BF8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x17B2C00", Offset = "0x17B2C00", VA = "0x17B2C00")]
			internal bool <GetMappingEvents>b__0(ParsingEvent e)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x17B2CAC", Offset = "0x17B2CAC", VA = "0x17B2CAC")]
			internal bool <GetMappingEvents>b__1(ParsingEvent e)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x17B2CF8", Offset = "0x17B2CF8", VA = "0x17B2CF8")]
			internal ParsingEvent <GetMappingEvents>b__2(ParsingEvent e)
			{
				return null;
			}
		}

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<ParsingEvent> _allEvents;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IParser _innerParser;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _currentIndex;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766138", Offset = "0x766138")]
		private ParsingEvent <Current>k__BackingField;

		[Token(Token = "0x1700005E")]
		public ParsingEvent Current
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x11A0BA0", Offset = "0x11A0BA0", VA = "0x11A0BA0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766AD8", Offset = "0x766AD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x11A0BA8", Offset = "0x11A0BA8", VA = "0x11A0BA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766AE8", Offset = "0x766AE8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x11A0AF8", Offset = "0x11A0AF8", VA = "0x11A0AF8")]
		public MergingParser(IParser innerParser)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11A0BB0", Offset = "0x11A0BB0", VA = "0x11A0BB0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x11A12D0", Offset = "0x11A12D0", VA = "0x11A12D0")]
		private IEnumerable<ParsingEvent> GetMappingEvents(string mappingAlias)
		{
			return null;
		}
	}
	[Token(Token = "0x200007D")]
	public class Parser : IParser
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Stack<ParserState> states;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TagDirectiveCollection tagDirectives;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParserState state;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IScanner scanner;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParsingEvent current;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Token currentToken;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Queue<ParsingEvent> pendingEvents;

		[Token(Token = "0x1700005F")]
		public ParsingEvent Current
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x11A3F08", Offset = "0x11A3F08", VA = "0x11A3F08", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x11A39B8", Offset = "0x11A39B8", VA = "0x11A39B8")]
		private Token GetCurrentToken()
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x11933E8", Offset = "0x11933E8", VA = "0x11933E8")]
		public Parser(TextReader input)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x11A3DE4", Offset = "0x11A3DE4", VA = "0x11A3DE4")]
		public Parser(IScanner scanner)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x11A3F10", Offset = "0x11A3F10", VA = "0x11A3F10", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x11A3FEC", Offset = "0x11A3FEC", VA = "0x11A3FEC")]
		private ParsingEvent StateMachine()
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x11A68EC", Offset = "0x11A68EC", VA = "0x11A68EC")]
		private void Skip()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x11A40F0", Offset = "0x11A40F0", VA = "0x11A40F0")]
		private ParsingEvent ParseStreamStart()
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x11A4230", Offset = "0x11A4230", VA = "0x11A4230")]
		private ParsingEvent ParseDocumentStart(bool isImplicit)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x11A69C0", Offset = "0x11A69C0", VA = "0x11A69C0")]
		private VersionDirective ProcessDirectives(TagDirectiveCollection tags)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x11A6CA0", Offset = "0x11A6CA0", VA = "0x11A6CA0")]
		private static void AddTagDirectives(TagDirectiveCollection directives, IEnumerable<TagDirective> source)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x11A4770", Offset = "0x11A4770", VA = "0x11A4770")]
		private ParsingEvent ParseDocumentContent()
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x11A6F9C", Offset = "0x11A6F9C", VA = "0x11A6F9C")]
		private static ParsingEvent ProcessEmptyScalar(Mark position)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11A4AD8", Offset = "0x11A4AD8", VA = "0x11A4AD8")]
		private ParsingEvent ParseNode(bool isBlock, bool isIndentlessSequence)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x11A49DC", Offset = "0x11A49DC", VA = "0x11A49DC")]
		private ParsingEvent ParseDocumentEnd()
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x11A52CC", Offset = "0x11A52CC", VA = "0x11A52CC")]
		private ParsingEvent ParseBlockSequenceEntry(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x11A559C", Offset = "0x11A559C", VA = "0x11A559C")]
		private ParsingEvent ParseIndentlessSequenceEntry()
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x11A5834", Offset = "0x11A5834", VA = "0x11A5834")]
		private ParsingEvent ParseBlockMappingKey(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x11A5B4C", Offset = "0x11A5B4C", VA = "0x11A5B4C")]
		private ParsingEvent ParseBlockMappingValue()
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11A5D28", Offset = "0x11A5D28", VA = "0x11A5D28")]
		private ParsingEvent ParseFlowSequenceEntry(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x11A601C", Offset = "0x11A601C", VA = "0x11A601C")]
		private ParsingEvent ParseFlowSequenceEntryMappingKey()
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x11A6198", Offset = "0x11A6198", VA = "0x11A6198")]
		private ParsingEvent ParseFlowSequenceEntryMappingValue()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x11A6310", Offset = "0x11A6310", VA = "0x11A6310")]
		private ParsingEvent ParseFlowSequenceEntryMappingEnd()
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x11A63A4", Offset = "0x11A63A4", VA = "0x11A63A4")]
		private ParsingEvent ParseFlowMappingKey(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x11A6760", Offset = "0x11A6760", VA = "0x11A6760")]
		private ParsingEvent ParseFlowMappingValue(bool isEmpty)
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	internal enum ParserState
	{
		[Token(Token = "0x40000C4")]
		StreamStart,
		[Token(Token = "0x40000C5")]
		StreamEnd,
		[Token(Token = "0x40000C6")]
		ImplicitDocumentStart,
		[Token(Token = "0x40000C7")]
		DocumentStart,
		[Token(Token = "0x40000C8")]
		DocumentContent,
		[Token(Token = "0x40000C9")]
		DocumentEnd,
		[Token(Token = "0x40000CA")]
		BlockNode,
		[Token(Token = "0x40000CB")]
		BlockNodeOrIndentlessSequence,
		[Token(Token = "0x40000CC")]
		FlowNode,
		[Token(Token = "0x40000CD")]
		BlockSequenceFirstEntry,
		[Token(Token = "0x40000CE")]
		BlockSequenceEntry,
		[Token(Token = "0x40000CF")]
		IndentlessSequenceEntry,
		[Token(Token = "0x40000D0")]
		BlockMappingFirstKey,
		[Token(Token = "0x40000D1")]
		BlockMappingKey,
		[Token(Token = "0x40000D2")]
		BlockMappingValue,
		[Token(Token = "0x40000D3")]
		FlowSequenceFirstEntry,
		[Token(Token = "0x40000D4")]
		FlowSequenceEntry,
		[Token(Token = "0x40000D5")]
		FlowSequenceEntryMappingKey,
		[Token(Token = "0x40000D6")]
		FlowSequenceEntryMappingValue,
		[Token(Token = "0x40000D7")]
		FlowSequenceEntryMappingEnd,
		[Token(Token = "0x40000D8")]
		FlowMappingFirstKey,
		[Token(Token = "0x40000D9")]
		FlowMappingKey,
		[Token(Token = "0x40000DA")]
		FlowMappingValue,
		[Token(Token = "0x40000DB")]
		FlowMappingEmptyValue
	}
	[Token(Token = "0x200007F")]
	public enum ScalarStyle
	{
		[Token(Token = "0x40000DD")]
		Any,
		[Token(Token = "0x40000DE")]
		Plain,
		[Token(Token = "0x40000DF")]
		SingleQuoted,
		[Token(Token = "0x40000E0")]
		DoubleQuoted,
		[Token(Token = "0x40000E1")]
		Literal,
		[Token(Token = "0x40000E2")]
		Folded
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class Scanner : IScanner
	{
		[Token(Token = "0x40000E3")]
		private const int MaxVersionNumberLength = 9;

		[Token(Token = "0x40000E4")]
		private const int MaxBufferLength = 8;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IDictionary<char, char> simpleEscapeCodes;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Stack<int> indents;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly InsertionQueue<Token> tokens;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Stack<SimpleKey> simpleKeys;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly CharacterAnalyzer<LookAheadBuffer> analyzer;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Cursor cursor;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool streamStartProduced;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool streamEndProduced;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int indent;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool simpleKeyAllowed;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int flowLevel;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int tokensParsed;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool tokenAvailable;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Token previous;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766148", Offset = "0x766148")]
		private bool <SkipComments>k__BackingField;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766158", Offset = "0x766158")]
		private Token <Current>k__BackingField;

		[Token(Token = "0x17000060")]
		public bool SkipComments
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x11A9434", Offset = "0x11A9434", VA = "0x11A9434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766AF8", Offset = "0x766AF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x11A943C", Offset = "0x11A943C", VA = "0x11A943C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B08", Offset = "0x766B08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public Token Current
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x11A9448", Offset = "0x11A9448", VA = "0x11A9448", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B18", Offset = "0x766B18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x11A9450", Offset = "0x11A9450", VA = "0x11A9450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B28", Offset = "0x766B28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public Mark CurrentPosition
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x11A9458", Offset = "0x11A9458", VA = "0x11A9458", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x11A3BE8", Offset = "0x11A3BE8", VA = "0x11A3BE8")]
		public Scanner(TextReader input, bool skipComments = true)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x11A9470", Offset = "0x11A9470", VA = "0x11A9470", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x11A94E8", Offset = "0x11A94E8", VA = "0x11A94E8", Slot = "7")]
		public bool MoveNextWithoutConsuming()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x11A94A0", Offset = "0x11A94A0", VA = "0x11A94A0", Slot = "8")]
		public void ConsumeCurrent()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x11A97C4", Offset = "0x11A97C4", VA = "0x11A97C4")]
		private char ReadCurrentCharacter()
		{
			return default(char);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x11A98A4", Offset = "0x11A98A4", VA = "0x11A98A4")]
		private char ReadLine()
		{
			return default(char);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x11A95B4", Offset = "0x11A95B4", VA = "0x11A95B4")]
		private void FetchMoreTokens()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x11AA43C", Offset = "0x11AA43C", VA = "0x11AA43C")]
		private static bool StartsWith(StringBuilder what, char start)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x11A9AE4", Offset = "0x11A9AE4", VA = "0x11A9AE4")]
		private void StaleSimpleKeys()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x11A9CF4", Offset = "0x11A9CF4", VA = "0x11A9CF4")]
		private void FetchNextToken()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x11AB3F0", Offset = "0x11AB3F0", VA = "0x11AB3F0")]
		private bool CheckWhiteSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x11AB494", Offset = "0x11AB494", VA = "0x11AB494")]
		private bool IsDocumentIndicator()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x11A9830", Offset = "0x11A9830", VA = "0x11A9830")]
		private void Skip()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x11A9964", Offset = "0x11A9964", VA = "0x11A9964")]
		private void SkipLine()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11AA5A0", Offset = "0x11AA5A0", VA = "0x11AA5A0")]
		private void ScanToNextToken()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x11AB5F4", Offset = "0x11AB5F4", VA = "0x11AB5F4")]
		private void ProcessComment()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x11AA498", Offset = "0x11AA498", VA = "0x11AA498")]
		private void FetchStreamStart()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x11AA63C", Offset = "0x11AA63C", VA = "0x11AA63C")]
		private void UnrollIndent(int column)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x11AA740", Offset = "0x11AA740", VA = "0x11AA740")]
		private void FetchStreamEnd()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x11AA824", Offset = "0x11AA824", VA = "0x11AA824")]
		private void FetchDirective()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x11AB964", Offset = "0x11AB964", VA = "0x11AB964")]
		private Token ScanDirective()
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x11AA8A0", Offset = "0x11AA8A0", VA = "0x11AA8A0")]
		private void FetchDocumentIndicator(bool isStartToken)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x11AA9B8", Offset = "0x11AA9B8", VA = "0x11AA9B8")]
		private void FetchFlowCollectionStart(bool isSequenceToken)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x11AC194", Offset = "0x11AC194", VA = "0x11AC194")]
		private void IncreaseFlowLevel()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x11AAA98", Offset = "0x11AAA98", VA = "0x11AAA98")]
		private void FetchFlowCollectionEnd(bool isSequenceToken)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x11AC230", Offset = "0x11AC230", VA = "0x11AC230")]
		private void DecreaseFlowLevel()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x11AAB74", Offset = "0x11AAB74", VA = "0x11AAB74")]
		private void FetchFlowEntry()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x11AAC44", Offset = "0x11AAC44", VA = "0x11AAC44")]
		private void FetchBlockEntry()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x11AADA4", Offset = "0x11AADA4", VA = "0x11AADA4")]
		private void FetchKey()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x11AAF0C", Offset = "0x11AAF0C", VA = "0x11AAF0C")]
		private void FetchValue()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x11AC2A0", Offset = "0x11AC2A0", VA = "0x11AC2A0")]
		private void RollIndent(int column, int number, bool isSequence, Mark position)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x11AB18C", Offset = "0x11AB18C", VA = "0x11AB18C")]
		private void FetchAnchor(bool isAlias)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x11AC3FC", Offset = "0x11AC3FC", VA = "0x11AC3FC")]
		private Token ScanAnchor(bool isAlias)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x11AB20C", Offset = "0x11AB20C", VA = "0x11AB20C")]
		private void FetchTag()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x11AC648", Offset = "0x11AC648", VA = "0x11AC648")]
		private Token ScanTag()
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x11AB27C", Offset = "0x11AB27C", VA = "0x11AB27C")]
		private void FetchBlockScalar(bool isLiteral)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x11ACD48", Offset = "0x11ACD48", VA = "0x11ACD48")]
		private Token ScanBlockScalar(bool isLiteral)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x11AD40C", Offset = "0x11AD40C", VA = "0x11AD40C")]
		private int ScanBlockScalarBreaks(int currentIndent, StringBuilder breaks, Mark start, ref Mark end)
		{
			return default(int);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x11AB300", Offset = "0x11AB300", VA = "0x11AB300")]
		private void FetchFlowScalar(bool isSingleQuoted)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x11AD67C", Offset = "0x11AD67C", VA = "0x11AD67C")]
		private Token ScanFlowScalar(bool isSingleQuoted)
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x11AB380", Offset = "0x11AB380", VA = "0x11AB380")]
		private void FetchPlainScalar()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x11ADF80", Offset = "0x11ADF80", VA = "0x11ADF80")]
		private Token ScanPlainScalar()
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x11AB86C", Offset = "0x11AB86C", VA = "0x11AB86C")]
		private void RemoveSimpleKey()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x11ABB80", Offset = "0x11ABB80", VA = "0x11ABB80")]
		private string ScanDirectiveName(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11AE5C8", Offset = "0x11AE5C8", VA = "0x11AE5C8")]
		private void SkipWhitespaces()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x11ABD24", Offset = "0x11ABD24", VA = "0x11ABD24")]
		private Token ScanVersionDirectiveValue(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x11ABE9C", Offset = "0x11ABE9C", VA = "0x11ABE9C")]
		private Token ScanTagDirectiveValue(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x11AC914", Offset = "0x11AC914", VA = "0x11AC914")]
		private string ScanTagUri(string head, Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x11AE7B4", Offset = "0x11AE7B4", VA = "0x11AE7B4")]
		private char ScanUriEscapes(Mark start)
		{
			return default(char);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x11ACB24", Offset = "0x11ACB24", VA = "0x11ACB24")]
		private string ScanTagHandle(bool isDirective, Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x11AE638", Offset = "0x11AE638", VA = "0x11AE638")]
		private int ScanVersionDirectiveNumber(Mark start)
		{
			return default(int);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x11AC050", Offset = "0x11AC050", VA = "0x11AC050")]
		private void SaveSimpleKey()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class SemanticErrorException : YamlException
	{
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x17A1344", Offset = "0x17A1344", VA = "0x17A1344")]
		public SemanticErrorException()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x17A13AC", Offset = "0x17A13AC", VA = "0x17A13AC")]
		public SemanticErrorException(string message)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x17A1424", Offset = "0x17A1424", VA = "0x17A1424")]
		public SemanticErrorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x17A1434", Offset = "0x17A1434", VA = "0x17A1434")]
		public SemanticErrorException(string message, Exception inner)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	internal class SimpleKey
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Cursor cursor;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766168", Offset = "0x766168")]
		private bool <IsPossible>k__BackingField;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766178", Offset = "0x766178")]
		private bool <IsRequired>k__BackingField;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766188", Offset = "0x766188")]
		private int <TokenNumber>k__BackingField;

		[Token(Token = "0x17000063")]
		public bool IsPossible
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x17A359C", Offset = "0x17A359C", VA = "0x17A359C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B38", Offset = "0x766B38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x17A35A4", Offset = "0x17A35A4", VA = "0x17A35A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B48", Offset = "0x766B48")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool IsRequired
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x17A35B0", Offset = "0x17A35B0", VA = "0x17A35B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B58", Offset = "0x766B58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x17A35B8", Offset = "0x17A35B8", VA = "0x17A35B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B68", Offset = "0x766B68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public int TokenNumber
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x17A35C4", Offset = "0x17A35C4", VA = "0x17A35C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B78", Offset = "0x766B78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x17A35CC", Offset = "0x17A35CC", VA = "0x17A35CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B88", Offset = "0x766B88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public int Index
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x17A35D4", Offset = "0x17A35D4", VA = "0x17A35D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000067")]
		public int Line
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x17A35F0", Offset = "0x17A35F0", VA = "0x17A35F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000068")]
		public int LineOffset
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x17A360C", Offset = "0x17A360C", VA = "0x17A360C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000069")]
		public Mark Mark
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x17A3628", Offset = "0x17A3628", VA = "0x17A3628")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x17A3644", Offset = "0x17A3644", VA = "0x17A3644")]
		public SimpleKey()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x17A36B4", Offset = "0x17A36B4", VA = "0x17A36B4")]
		public SimpleKey(bool isPossible, bool isRequired, int tokenNumber, Cursor cursor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	internal class StringLookAheadBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string value;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766198", Offset = "0x766198")]
		private int <Position>k__BackingField;

		[Token(Token = "0x1700006A")]
		public int Position
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x17A43D4", Offset = "0x17A43D4", VA = "0x17A43D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766B98", Offset = "0x766B98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x17A43DC", Offset = "0x17A43DC", VA = "0x17A43DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766BA8", Offset = "0x766BA8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public int Length
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x17A4418", Offset = "0x17A4418", VA = "0x17A4418")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006C")]
		public bool EndOfInput
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x17A4434", Offset = "0x17A4434", VA = "0x17A4434", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x17A43E4", Offset = "0x17A43E4", VA = "0x17A43E4")]
		public StringLookAheadBuffer(string value)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x17A4480", Offset = "0x17A4480", VA = "0x17A4480", Slot = "5")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x17A445C", Offset = "0x17A445C", VA = "0x17A445C")]
		private bool IsOutside(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x17A44BC", Offset = "0x17A44BC", VA = "0x17A44BC", Slot = "6")]
		public void Skip(int length)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class SyntaxErrorException : YamlException
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x17A4538", Offset = "0x17A4538", VA = "0x17A4538")]
		public SyntaxErrorException()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x17A453C", Offset = "0x17A453C", VA = "0x17A453C")]
		public SyntaxErrorException(string message)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x17A4540", Offset = "0x17A4540", VA = "0x17A4540")]
		public SyntaxErrorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x17A4548", Offset = "0x17A4548", VA = "0x17A4548")]
		public SyntaxErrorException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class TagDirectiveCollection : KeyedCollection<string, TagDirective>
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x17A4AC4", Offset = "0x17A4AC4", VA = "0x17A4AC4")]
		public TagDirectiveCollection()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x17A4B10", Offset = "0x17A4B10", VA = "0x17A4B10")]
		public TagDirectiveCollection(IEnumerable<TagDirective> tagDirectives)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x17A4DFC", Offset = "0x17A4DFC", VA = "0x17A4DFC", Slot = "38")]
		protected override string GetKeyForItem(TagDirective item)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x17A4E14", Offset = "0x17A4E14", VA = "0x17A4E14")]
		public new bool Contains(TagDirective directive)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class Version
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7661A8", Offset = "0x7661A8")]
		private int <Major>k__BackingField;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7661B8", Offset = "0x7661B8")]
		private int <Minor>k__BackingField;

		[Token(Token = "0x1700006D")]
		public int Major
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x17A8054", Offset = "0x17A8054", VA = "0x17A8054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766BB8", Offset = "0x766BB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x17A805C", Offset = "0x17A805C", VA = "0x17A805C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766BC8", Offset = "0x766BC8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public int Minor
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x17A8064", Offset = "0x17A8064", VA = "0x17A8064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766BD8", Offset = "0x766BD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x17A806C", Offset = "0x17A806C", VA = "0x17A806C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766BE8", Offset = "0x766BE8")]
			private set
			{
			}
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x17A8074", Offset = "0x17A8074", VA = "0x17A8074")]
		public Version(int major, int minor)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x17A80AC", Offset = "0x17A80AC", VA = "0x17A80AC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x17A8160", Offset = "0x17A8160", VA = "0x17A8160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class YamlException : Exception
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7661C8", Offset = "0x7661C8")]
		private Mark <Start>k__BackingField;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7661D8", Offset = "0x7661D8")]
		private Mark <End>k__BackingField;

		[Token(Token = "0x1700006F")]
		public Mark Start
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x17A9DA0", Offset = "0x17A9DA0", VA = "0x17A9DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766BF8", Offset = "0x766BF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x17A9DA8", Offset = "0x17A9DA8", VA = "0x17A9DA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C08", Offset = "0x766C08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Mark End
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x17A9DB0", Offset = "0x17A9DB0", VA = "0x17A9DB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C18", Offset = "0x766C18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x17A9DB8", Offset = "0x17A9DB8", VA = "0x17A9DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C28", Offset = "0x766C28")]
			private set
			{
			}
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x17A1348", Offset = "0x17A1348", VA = "0x17A1348")]
		public YamlException()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x17A13B0", Offset = "0x17A13B0", VA = "0x17A13B0")]
		public YamlException(string message)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x17A142C", Offset = "0x17A142C", VA = "0x17A142C")]
		public YamlException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x17A9DC0", Offset = "0x17A9DC0", VA = "0x17A9DC0")]
		public YamlException(Mark start, Mark end, string message, Exception innerException)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x17A1438", Offset = "0x17A1438", VA = "0x17A1438")]
		public YamlException(string message, Exception inner)
		{
		}
	}
}
namespace YamlDotNet.Core.Tokens
{
	[Serializable]
	[Token(Token = "0x2000088")]
	public class Anchor : Token
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x17000071")]
		public string Value
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x118D34C", Offset = "0x118D34C", VA = "0x118D34C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x118D354", Offset = "0x118D354", VA = "0x118D354")]
		public Anchor(string value)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x118D3E4", Offset = "0x118D3E4", VA = "0x118D3E4")]
		public Anchor(string value, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class AnchorAlias : Token
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x17000072")]
		public string Value
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x118D774", Offset = "0x118D774", VA = "0x118D774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x118D77C", Offset = "0x118D77C", VA = "0x118D77C")]
		public AnchorAlias(string value)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x118D80C", Offset = "0x118D80C", VA = "0x118D80C")]
		public AnchorAlias(string value, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class BlockEnd : Token
	{
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x118EFD8", Offset = "0x118EFD8", VA = "0x118EFD8")]
		public BlockEnd()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x118F04C", Offset = "0x118F04C", VA = "0x118F04C")]
		public BlockEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class BlockEntry : Token
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x118F054", Offset = "0x118F054", VA = "0x118F054")]
		public BlockEntry()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x118F0C8", Offset = "0x118F0C8", VA = "0x118F0C8")]
		public BlockEntry(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008C")]
	public class BlockMappingStart : Token
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x118F0D0", Offset = "0x118F0D0", VA = "0x118F0D0")]
		public BlockMappingStart()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x118F144", Offset = "0x118F144", VA = "0x118F144")]
		public BlockMappingStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class BlockSequenceStart : Token
	{
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x118F14C", Offset = "0x118F14C", VA = "0x118F14C")]
		public BlockSequenceStart()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x118F1C0", Offset = "0x118F1C0", VA = "0x118F1C0")]
		public BlockSequenceStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public class Comment : Token
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7661E8", Offset = "0x7661E8")]
		private string <Value>k__BackingField;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7661F8", Offset = "0x7661F8")]
		private bool <IsInline>k__BackingField;

		[Token(Token = "0x17000073")]
		public string Value
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x1190A28", Offset = "0x1190A28", VA = "0x1190A28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C38", Offset = "0x766C38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1190A30", Offset = "0x1190A30", VA = "0x1190A30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C48", Offset = "0x766C48")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool IsInline
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1190A38", Offset = "0x1190A38", VA = "0x1190A38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C58", Offset = "0x766C58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1190A40", Offset = "0x1190A40", VA = "0x1190A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C68", Offset = "0x766C68")]
			private set
			{
			}
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1190A4C", Offset = "0x1190A4C", VA = "0x1190A4C")]
		public Comment(string value, bool isInline)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1190AE8", Offset = "0x1190AE8", VA = "0x1190AE8")]
		public Comment(string value, bool isInline, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public class DocumentEnd : Token
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x119477C", Offset = "0x119477C", VA = "0x119477C")]
		public DocumentEnd()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x11947F0", Offset = "0x11947F0", VA = "0x11947F0")]
		public DocumentEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class DocumentStart : Token
	{
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1195368", Offset = "0x1195368", VA = "0x1195368")]
		public DocumentStart()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x11953DC", Offset = "0x11953DC", VA = "0x11953DC")]
		public DocumentStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class FlowEntry : Token
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x119B690", Offset = "0x119B690", VA = "0x119B690")]
		public FlowEntry()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x119B704", Offset = "0x119B704", VA = "0x119B704")]
		public FlowEntry(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class FlowMappingEnd : Token
	{
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x119B70C", Offset = "0x119B70C", VA = "0x119B70C")]
		public FlowMappingEnd()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x119B780", Offset = "0x119B780", VA = "0x119B780")]
		public FlowMappingEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class FlowMappingStart : Token
	{
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x119B788", Offset = "0x119B788", VA = "0x119B788")]
		public FlowMappingStart()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x119B7FC", Offset = "0x119B7FC", VA = "0x119B7FC")]
		public FlowMappingStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class FlowSequenceEnd : Token
	{
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x119B804", Offset = "0x119B804", VA = "0x119B804")]
		public FlowSequenceEnd()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x119B878", Offset = "0x119B878", VA = "0x119B878")]
		public FlowSequenceEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class FlowSequenceStart : Token
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x119B880", Offset = "0x119B880", VA = "0x119B880")]
		public FlowSequenceStart()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x119B8F4", Offset = "0x119B8F4", VA = "0x119B8F4")]
		public FlowSequenceStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class Key : Token
	{
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x119F920", Offset = "0x119F920", VA = "0x119F920")]
		public Key()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x119F994", Offset = "0x119F994", VA = "0x119F994")]
		public Key(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class Scalar : Token
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ScalarStyle style;

		[Token(Token = "0x17000075")]
		public string Value
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x11A89A0", Offset = "0x11A89A0", VA = "0x11A89A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x11A89A8", Offset = "0x11A89A8", VA = "0x11A89A8")]
			get
			{
				return default(ScalarStyle);
			}
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x11A89B0", Offset = "0x11A89B0", VA = "0x11A89B0")]
		public Scalar(string value)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x11A89B8", Offset = "0x11A89B8", VA = "0x11A89B8")]
		public Scalar(string value, ScalarStyle style)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x11A8A54", Offset = "0x11A8A54", VA = "0x11A8A54")]
		public Scalar(string value, ScalarStyle style, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class StreamEnd : Token
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x17A387C", Offset = "0x17A387C", VA = "0x17A387C")]
		public StreamEnd()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x17A38EC", Offset = "0x17A38EC", VA = "0x17A38EC")]
		public StreamEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class StreamStart : Token
	{
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x17A3EB8", Offset = "0x17A3EB8", VA = "0x17A3EB8")]
		public StreamStart()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x17A3F28", Offset = "0x17A3F28", VA = "0x17A3F28")]
		public StreamStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class Tag : Token
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string handle;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string suffix;

		[Token(Token = "0x17000077")]
		public string Handle
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x17A454C", Offset = "0x17A454C", VA = "0x17A454C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public string Suffix
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x17A4554", Offset = "0x17A4554", VA = "0x17A4554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x17A455C", Offset = "0x17A455C", VA = "0x17A455C")]
		public Tag(string handle, string suffix)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x17A45E4", Offset = "0x17A45E4", VA = "0x17A45E4")]
		public Tag(string handle, string suffix, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class TagDirective : Token
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string handle;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string prefix;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex tagHandleValidator;

		[Token(Token = "0x17000079")]
		public string Handle
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x17A4638", Offset = "0x17A4638", VA = "0x17A4638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public string Prefix
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x17A4640", Offset = "0x17A4640", VA = "0x17A4640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x17A4648", Offset = "0x17A4648", VA = "0x17A4648")]
		public TagDirective(string handle, string prefix)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x17A46D0", Offset = "0x17A46D0", VA = "0x17A46D0")]
		public TagDirective(string handle, string prefix, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x17A4890", Offset = "0x17A4890", VA = "0x17A4890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x17A4958", Offset = "0x17A4958", VA = "0x17A4958", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x17A49AC", Offset = "0x17A49AC", VA = "0x17A49AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public abstract class Token
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Mark start;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Mark end;

		[Token(Token = "0x1700007B")]
		public Mark Start
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x17A52D0", Offset = "0x17A52D0", VA = "0x17A52D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public Mark End
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x17A52D8", Offset = "0x17A52D8", VA = "0x17A52D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x17A38F0", Offset = "0x17A38F0", VA = "0x17A38F0")]
		protected Token(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class Value : Token
	{
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x17A7FE0", Offset = "0x17A7FE0", VA = "0x17A7FE0")]
		public Value()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x17A8050", Offset = "0x17A8050", VA = "0x17A8050")]
		public Value(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class VersionDirective : Token
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Version version;

		[Token(Token = "0x1700007D")]
		public Version Version
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x17A81B4", Offset = "0x17A81B4", VA = "0x17A81B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x17A81BC", Offset = "0x17A81BC", VA = "0x17A81BC")]
		public VersionDirective(Version version)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x17A8248", Offset = "0x17A8248", VA = "0x17A8248")]
		public VersionDirective(Version version, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x17A8280", Offset = "0x17A8280", VA = "0x17A8280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x17A8334", Offset = "0x17A8334", VA = "0x17A8334", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace YamlDotNet.Core.Events
{
	[Token(Token = "0x200009F")]
	public class AnchorAlias : ParsingEvent
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x1700007E")]
		internal override EventType Type
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x118D420", Offset = "0x118D420", VA = "0x118D420", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x1700007F")]
		public string Value
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x118D428", Offset = "0x118D428", VA = "0x118D428")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x118D430", Offset = "0x118D430", VA = "0x118D430")]
		public AnchorAlias(string value, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x118D5B8", Offset = "0x118D5B8", VA = "0x118D5B8")]
		public AnchorAlias(string value)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x118D638", Offset = "0x118D638", VA = "0x118D638", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x118D6BC", Offset = "0x118D6BC", VA = "0x118D6BC", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class Comment : ParsingEvent
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766208", Offset = "0x766208")]
		private string <Value>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766218", Offset = "0x766218")]
		private bool <IsInline>k__BackingField;

		[Token(Token = "0x17000080")]
		public string Value
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x1190854", Offset = "0x1190854", VA = "0x1190854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C78", Offset = "0x766C78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x119085C", Offset = "0x119085C", VA = "0x119085C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C88", Offset = "0x766C88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool IsInline
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1190864", Offset = "0x1190864", VA = "0x1190864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766C98", Offset = "0x766C98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x119086C", Offset = "0x119086C", VA = "0x119086C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x766CA8", Offset = "0x766CA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		internal override EventType Type
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x1190964", Offset = "0x1190964", VA = "0x1190964", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1190878", Offset = "0x1190878", VA = "0x1190878")]
		public Comment(string value, bool isInline)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1190914", Offset = "0x1190914", VA = "0x1190914")]
		public Comment(string value, bool isInline, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x119096C", Offset = "0x119096C", VA = "0x119096C", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class DocumentEnd : ParsingEvent
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly bool isImplicit;

		[Token(Token = "0x17000083")]
		public override int NestingIncrease
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x119452C", Offset = "0x119452C", VA = "0x119452C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000084")]
		internal override EventType Type
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1194534", Offset = "0x1194534", VA = "0x1194534", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x17000085")]
		public bool IsImplicit
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x119453C", Offset = "0x119453C", VA = "0x119453C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1194544", Offset = "0x1194544", VA = "0x1194544")]
		public DocumentEnd(bool isImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1194578", Offset = "0x1194578", VA = "0x1194578")]
		public DocumentEnd(bool isImplicit)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1194600", Offset = "0x1194600", VA = "0x1194600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x11946C0", Offset = "0x11946C0", VA = "0x11946C0", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class DocumentStart : ParsingEvent
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly TagDirectiveCollection tags;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly VersionDirective version;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x17000086")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x1195034", Offset = "0x1195034", VA = "0x1195034", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		internal override EventType Type
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x119503C", Offset = "0x119503C", VA = "0x119503C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x17000088")]
		public TagDirectiveCollection Tags
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1195044", Offset = "0x1195044", VA = "0x1195044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public VersionDirective Version
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x119504C", Offset = "0x119504C", VA = "0x119504C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public bool IsImplicit
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x1195054", Offset = "0x1195054", VA = "0x1195054")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x119505C", Offset = "0x119505C", VA = "0x119505C")]
		public DocumentStart(VersionDirective version, TagDirectiveCollection tags, bool isImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x11950C0", Offset = "0x11950C0", VA = "0x11950C0")]
		public DocumentStart(VersionDirective version, TagDirectiveCollection tags, bool isImplicit)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1195158", Offset = "0x1195158", VA = "0x1195158")]
		public DocumentStart(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1195170", Offset = "0x1195170", VA = "0x1195170")]
		public DocumentStart()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x11951EC", Offset = "0x11951EC", VA = "0x11951EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x11952AC", Offset = "0x11952AC", VA = "0x11952AC", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	internal enum EventType
	{
		[Token(Token = "0x4000115")]
		None,
		[Token(Token = "0x4000116")]
		StreamStart,
		[Token(Token = "0x4000117")]
		StreamEnd,
		[Token(Token = "0x4000118")]
		DocumentStart,
		[Token(Token = "0x4000119")]
		DocumentEnd,
		[Token(Token = "0x400011A")]
		Alias,
		[Token(Token = "0x400011B")]
		Scalar,
		[Token(Token = "0x400011C")]
		SequenceStart,
		[Token(Token = "0x400011D")]
		SequenceEnd,
		[Token(Token = "0x400011E")]
		MappingStart,
		[Token(Token = "0x400011F")]
		MappingEnd,
		[Token(Token = "0x4000120")]
		Comment
	}
	[Token(Token = "0x20000A4")]
	public interface IParsingEventVisitor
	{
		[Token(Token = "0x60003AE")]
		void Visit(AnchorAlias e);

		[Token(Token = "0x60003AF")]
		void Visit(StreamStart e);

		[Token(Token = "0x60003B0")]
		void Visit(StreamEnd e);

		[Token(Token = "0x60003B1")]
		void Visit(DocumentStart e);

		[Token(Token = "0x60003B2")]
		void Visit(DocumentEnd e);

		[Token(Token = "0x60003B3")]
		void Visit(Scalar e);

		[Token(Token = "0x60003B4")]
		void Visit(SequenceStart e);

		[Token(Token = "0x60003B5")]
		void Visit(SequenceEnd e);

		[Token(Token = "0x60003B6")]
		void Visit(MappingStart e);

		[Token(Token = "0x60003B7")]
		void Visit(MappingEnd e);

		[Token(Token = "0x60003B8")]
		void Visit(Comment e);
	}
	[Token(Token = "0x20000A5")]
	public class MappingEnd : ParsingEvent
	{
		[Token(Token = "0x1700008B")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x119FE3C", Offset = "0x119FE3C", VA = "0x119FE3C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008C")]
		internal override EventType Type
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x119FE44", Offset = "0x119FE44", VA = "0x119FE44", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x119FE4C", Offset = "0x119FE4C", VA = "0x119FE4C")]
		public MappingEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x119FE50", Offset = "0x119FE50", VA = "0x119FE50")]
		public MappingEnd()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x119FEC0", Offset = "0x119FEC0", VA = "0x119FEC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x119FF04", Offset = "0x119FF04", VA = "0x119FF04", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class MappingStart : NodeEvent
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly MappingStyle style;

		[Token(Token = "0x1700008D")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x119FFC0", Offset = "0x119FFC0", VA = "0x119FFC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008E")]
		internal override EventType Type
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x119FFC8", Offset = "0x119FFC8", VA = "0x119FFC8", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x1700008F")]
		public bool IsImplicit
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x119FFD0", Offset = "0x119FFD0", VA = "0x119FFD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x119FFD8", Offset = "0x119FFD8", VA = "0x119FFD8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public MappingStyle Style
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x119FFE8", Offset = "0x119FFE8", VA = "0x119FFE8")]
			get
			{
				return default(MappingStyle);
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x119FFF0", Offset = "0x119FFF0", VA = "0x119FFF0")]
		public MappingStart(string anchor, string tag, bool isImplicit, MappingStyle style, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x11A0230", Offset = "0x11A0230", VA = "0x11A0230")]
		public MappingStart(string anchor, string tag, bool isImplicit, MappingStyle style)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x11A02D0", Offset = "0x11A02D0", VA = "0x11A02D0")]
		public MappingStart()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x11A0350", Offset = "0x11A0350", VA = "0x11A0350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x11A0564", Offset = "0x11A0564", VA = "0x11A0564", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public enum MappingStyle
	{
		[Token(Token = "0x4000124")]
		Any,
		[Token(Token = "0x4000125")]
		Block,
		[Token(Token = "0x4000126")]
		Flow
	}
	[Token(Token = "0x20000A8")]
	public abstract class NodeEvent : ParsingEvent
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Regex anchorValidator;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string anchor;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string tag;

		[Token(Token = "0x17000092")]
		public string Anchor
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x11A22A8", Offset = "0x11A22A8", VA = "0x11A22A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public string Tag
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x11A22B0", Offset = "0x11A22B0", VA = "0x11A22B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public abstract bool IsCanonical
		{
			[Token(Token = "0x60003CB")]
			get;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x11A00A0", Offset = "0x11A00A0", VA = "0x11A00A0")]
		protected NodeEvent(string anchor, string tag, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x11A22B8", Offset = "0x11A22B8", VA = "0x11A22B8")]
		protected NodeEvent(string anchor, string tag)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public abstract class ParsingEvent
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Mark start;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Mark end;

		[Token(Token = "0x17000095")]
		public virtual int NestingIncrease
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x11A711C", Offset = "0x11A711C", VA = "0x11A711C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000096")]
		internal abstract EventType Type
		{
			[Token(Token = "0x60003D0")]
			get;
		}

		[Token(Token = "0x17000097")]
		public Mark Start
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x11A7124", Offset = "0x11A7124", VA = "0x11A7124")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public Mark End
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x11A712C", Offset = "0x11A712C", VA = "0x11A712C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D3")]
		public abstract void Accept(IParsingEventVisitor visitor);

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x118D568", Offset = "0x118D568", VA = "0x118D568")]
		internal ParsingEvent(Mark start, Mark end)
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class Scalar : NodeEvent
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string value;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly ScalarStyle style;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private readonly bool isPlainImplicit;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private readonly bool isQuotedImplicit;

		[Token(Token = "0x17000099")]
		internal override EventType Type
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x11A83E4", Offset = "0x11A83E4", VA = "0x11A83E4", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x1700009A")]
		public string Value
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x11A83EC", Offset = "0x11A83EC", VA = "0x11A83EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public ScalarStyle Style
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x11A83F4", Offset = "0x11A83F4", VA = "0x11A83F4")]
			get
			{
				return default(ScalarStyle);
			}
		}

		[Token(Token = "0x1700009C")]
		public bool IsPlainImplicit
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x11A83FC", Offset = "0x11A83FC", VA = "0x11A83FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public bool IsQuotedImplicit
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x11A8404", Offset = "0x11A8404", VA = "0x11A8404")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x11A840C", Offset = "0x11A840C", VA = "0x11A840C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x11A7044", Offset = "0x11A7044", VA = "0x11A7044")]
		public Scalar(string anchor, string tag, string value, ScalarStyle style, bool isPlainImplicit, bool isQuotedImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x11A842C", Offset = "0x11A842C", VA = "0x11A842C")]
		public Scalar(string anchor, string tag, string value, ScalarStyle style, bool isPlainImplicit, bool isQuotedImplicit)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x119F0F0", Offset = "0x119F0F0", VA = "0x119F0F0")]
		public Scalar(string value)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x11A84F0", Offset = "0x11A84F0", VA = "0x11A84F0")]
		public Scalar(string tag, string value)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x11A8594", Offset = "0x11A8594", VA = "0x11A8594")]
		public Scalar(string anchor, string tag, string value)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x11A8644", Offset = "0x11A8644", VA = "0x11A8644", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x11A88E4", Offset = "0x11A88E4", VA = "0x11A88E4", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class SequenceEnd : ParsingEvent
	{
		[Token(Token = "0x1700009F")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x17A14B4", Offset = "0x17A14B4", VA = "0x17A14B4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A0")]
		internal override EventType Type
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x17A14BC", Offset = "0x17A14BC", VA = "0x17A14BC", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x17A14C4", Offset = "0x17A14C4", VA = "0x17A14C4")]
		public SequenceEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x17A14CC", Offset = "0x17A14CC", VA = "0x17A14CC")]
		public SequenceEnd()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x17A1540", Offset = "0x17A1540", VA = "0x17A1540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x17A1584", Offset = "0x17A1584", VA = "0x17A1584", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class SequenceStart : NodeEvent
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly SequenceStyle style;

		[Token(Token = "0x170000A1")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x17A1648", Offset = "0x17A1648", VA = "0x17A1648", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A2")]
		internal override EventType Type
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x17A1650", Offset = "0x17A1650", VA = "0x17A1650", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000A3")]
		public bool IsImplicit
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x17A1658", Offset = "0x17A1658", VA = "0x17A1658")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x17A1660", Offset = "0x17A1660", VA = "0x17A1660", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		public SequenceStyle Style
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x17A1670", Offset = "0x17A1670", VA = "0x17A1670")]
			get
			{
				return default(SequenceStyle);
			}
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x17A1678", Offset = "0x17A1678", VA = "0x17A1678")]
		public SequenceStart(string anchor, string tag, bool isImplicit, SequenceStyle style, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x17A172C", Offset = "0x17A172C", VA = "0x17A172C")]
		public SequenceStart(string anchor, string tag, bool isImplicit, SequenceStyle style)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x17A17CC", Offset = "0x17A17CC", VA = "0x17A17CC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x17A19E0", Offset = "0x17A19E0", VA = "0x17A19E0", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public enum SequenceStyle
	{
		[Token(Token = "0x4000133")]
		Any,
		[Token(Token = "0x4000134")]
		Block,
		[Token(Token = "0x4000135")]
		Flow
	}
	[Token(Token = "0x20000AE")]
	public class StreamEnd : ParsingEvent
	{
		[Token(Token = "0x170000A6")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x17A3764", Offset = "0x17A3764", VA = "0x17A3764", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		internal override EventType Type
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x17A376C", Offset = "0x17A376C", VA = "0x17A376C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x17A3774", Offset = "0x17A3774", VA = "0x17A3774")]
		public StreamEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x17A2C90", Offset = "0x17A2C90", VA = "0x17A2C90")]
		public StreamEnd()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x17A377C", Offset = "0x17A377C", VA = "0x17A377C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x17A37C0", Offset = "0x17A37C0", VA = "0x17A37C0", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class StreamStart : ParsingEvent
	{
		[Token(Token = "0x170000A8")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x17A3DA0", Offset = "0x17A3DA0", VA = "0x17A3DA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A9")]
		internal override EventType Type
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x17A3DA8", Offset = "0x17A3DA8", VA = "0x17A3DA8", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x17A2C1C", Offset = "0x17A2C1C", VA = "0x17A2C1C")]
		public StreamStart()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x17A3DB0", Offset = "0x17A3DB0", VA = "0x17A3DB0")]
		public StreamStart(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x17A3DB8", Offset = "0x17A3DB8", VA = "0x17A3DB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x17A3DFC", Offset = "0x17A3DFC", VA = "0x17A3DFC", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
}
