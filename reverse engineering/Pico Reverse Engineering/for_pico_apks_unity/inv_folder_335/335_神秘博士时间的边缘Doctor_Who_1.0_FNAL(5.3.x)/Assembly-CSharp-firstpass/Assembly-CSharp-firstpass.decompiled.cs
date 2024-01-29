using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Core.Tokens;
using YamlDotNet.Samples.Helpers;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.EventEmitters;
using YamlDotNet.Serialization.TypeInspectors;
using YamlDotNet.Serialization.Utilities;

[assembly: AssemblyVersion("0.0.0.0")]
namespace YamlDotNet
{
	[Token(Token = "0x2000002")]
	internal static class StandardRegexOptions
	{
		[Token(Token = "0x4000001")]
		public const RegexOptions Compiled = RegexOptions.None;
	}
	[Token(Token = "0x2000003")]
	internal static class ReflectionExtensions
	{
		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673AB8", Offset = "0x673AB8")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BindingFlags instancePublic;

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xEE212C", Offset = "0xEE212C", VA = "0xEE212C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xEE2414", Offset = "0xEE2414", VA = "0xEE2414")]
			internal IEnumerable<PropertyInfo> <GetPublicProperties>b__0(Type i)
			{
				return null;
			}
		}

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly FieldInfo remoteStackTraceField;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xEE1D28", Offset = "0xEE1D28", VA = "0xEE1D28")]
		public static Type BaseType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xEE1D5C", Offset = "0xEE1D5C", VA = "0xEE1D5C")]
		public static bool IsValueType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xEE1D88", Offset = "0xEE1D88", VA = "0xEE1D88")]
		public static bool IsGenericType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xEE1DBC", Offset = "0xEE1DBC", VA = "0xEE1DBC")]
		public static bool IsInterface(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xEE1DE8", Offset = "0xEE1DE8", VA = "0xEE1DE8")]
		public static bool IsEnum(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xEE1E1C", Offset = "0xEE1E1C", VA = "0xEE1E1C")]
		public static bool HasDefaultConstructor(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xEE1F10", Offset = "0xEE1F10", VA = "0xEE1F10")]
		public static TypeCode GetTypeCode(this Type type)
		{
			return default(TypeCode);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xEE030C", Offset = "0xEE030C", VA = "0xEE030C")]
		public static PropertyInfo GetPublicProperty(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xEE1F78", Offset = "0xEE1F78", VA = "0xEE1F78")]
		public static IEnumerable<PropertyInfo> GetPublicProperties(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xEE2134", Offset = "0xEE2134", VA = "0xEE2134")]
		public static IEnumerable<MethodInfo> GetPublicStaticMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xEE216C", Offset = "0xEE216C", VA = "0xEE216C")]
		public static MethodInfo GetPublicStaticMethod(this Type type, string name, params Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xEE02D4", Offset = "0xEE02D4", VA = "0xEE02D4")]
		public static MethodInfo GetPublicInstanceMethod(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xEE21BC", Offset = "0xEE21BC", VA = "0xEE21BC")]
		public static Exception Unwrap(this TargetInvocationException ex)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xEE2320", Offset = "0xEE2320", VA = "0xEE2320")]
		public static bool IsInstanceOf(this Type type, object o)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000004")]
	internal sealed class CultureInfoAdapter : CultureInfo
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly IFormatProvider _provider;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xEDFF3C", Offset = "0xEDFF3C", VA = "0xEDFF3C")]
		public CultureInfoAdapter(CultureInfo baseCulture, IFormatProvider provider)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xEDFFDC", Offset = "0xEDFFDC", VA = "0xEDFFDC", Slot = "19")]
		public override object GetFormat(Type formatType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000005")]
	internal static class PropertyInfoExtensions
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xEE1CD8", Offset = "0xEE1CD8", VA = "0xEE1CD8")]
		public static object ReadValue(this PropertyInfo property, object target)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization
{
	[Token(Token = "0x2000006")]
	public abstract class BuilderSkeleton<TBuilder> where TBuilder : BuilderSkeleton<TBuilder>
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673AC8", Offset = "0x673AC8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<Nothing, IYamlTypeConverter> <>9__5_0;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<IRegistrationLocationSelectionSyntax<IYamlTypeConverter>> <>9__13_0;

			[Token(Token = "0x60004F3")]
			public <>c()
			{
			}

			[Token(Token = "0x60004F4")]
			internal IYamlTypeConverter <.ctor>b__5_0(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x60004F5")]
			internal void <WithTypeConverter>b__13_0(IRegistrationLocationSelectionSyntax<IYamlTypeConverter> w)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673AD8", Offset = "0x673AD8")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IYamlTypeConverter typeConverter;

			[Token(Token = "0x60004F6")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60004F7")]
			internal IYamlTypeConverter <WithTypeConverter>b__0(Nothing _)
			{
				return null;
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673AE8", Offset = "0x673AE8")]
		private sealed class <>c__DisplayClass15_0<TYamlTypeConverter> where TYamlTypeConverter : IYamlTypeConverter
		{
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WrapperFactory<IYamlTypeConverter, IYamlTypeConverter> typeConverterFactory;

			[Token(Token = "0x60004F8")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60004F9")]
			internal IYamlTypeConverter <WithTypeConverter>b__0(IYamlTypeConverter wrapped, Nothing _)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673AF8", Offset = "0x673AF8")]
		private sealed class <>c__18<TTypeInspector> where TTypeInspector : ITypeInspector
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__18<TTypeInspector> <>9;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<IRegistrationLocationSelectionSyntax<ITypeInspector>> <>9__18_0;

			[Token(Token = "0x60004FB")]
			public <>c__18()
			{
			}

			[Token(Token = "0x60004FC")]
			internal void <WithTypeInspector>b__18_0(IRegistrationLocationSelectionSyntax<ITypeInspector> w)
			{
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B08", Offset = "0x673B08")]
		private sealed class <>c__DisplayClass19_0<TTypeInspector> where TTypeInspector : ITypeInspector
		{
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<ITypeInspector, TTypeInspector> typeInspectorFactory;

			[Token(Token = "0x60004FD")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60004FE")]
			internal ITypeInspector <WithTypeInspector>b__0(ITypeInspector inner)
			{
				return null;
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B18", Offset = "0x673B18")]
		private sealed class <>c__DisplayClass20_0<TTypeInspector> where TTypeInspector : ITypeInspector
		{
			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WrapperFactory<ITypeInspector, ITypeInspector, TTypeInspector> typeInspectorFactory;

			[Token(Token = "0x60004FF")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000500")]
			internal ITypeInspector <WithTypeInspector>b__0(ITypeInspector wrapped, ITypeInspector inner)
			{
				return null;
			}
		}

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal INamingConvention namingConvention;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ITypeResolver typeResolver;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly YamlAttributeOverrides overrides;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly LazyComponentRegistrationList<Nothing, IYamlTypeConverter> typeConverterFactories;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly LazyComponentRegistrationList<ITypeInspector, ITypeInspector> typeInspectorFactories;

		[Token(Token = "0x17000001")]
		protected abstract TBuilder Self
		{
			[Token(Token = "0x6000014")]
			get;
		}

		[Token(Token = "0x6000013")]
		internal BuilderSkeleton()
		{
		}

		[Token(Token = "0x6000015")]
		internal ITypeInspector BuildTypeInspector()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		public TBuilder WithNamingConvention(INamingConvention namingConvention)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		public TBuilder WithTypeResolver(ITypeResolver typeResolver)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		public TBuilder WithAttributeOverride<TClass>(Expression<Func<TClass, object>> propertyAccessor, Attribute attribute)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		public TBuilder WithAttributeOverride(Type type, string member, Attribute attribute)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		public TBuilder WithTypeConverter(IYamlTypeConverter typeConverter)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		public TBuilder WithTypeConverter(IYamlTypeConverter typeConverter, Action<IRegistrationLocationSelectionSyntax<IYamlTypeConverter>> where)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		public TBuilder WithTypeConverter<TYamlTypeConverter>(WrapperFactory<IYamlTypeConverter, IYamlTypeConverter> typeConverterFactory, Action<ITrackingRegistrationLocationSelectionSyntax<IYamlTypeConverter>> where) where TYamlTypeConverter : IYamlTypeConverter
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		public TBuilder WithoutTypeConverter<TYamlTypeConverter>() where TYamlTypeConverter : IYamlTypeConverter
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		public TBuilder WithoutTypeConverter(Type converterType)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		public TBuilder WithTypeInspector<TTypeInspector>(Func<ITypeInspector, TTypeInspector> typeInspectorFactory) where TTypeInspector : ITypeInspector
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		public TBuilder WithTypeInspector<TTypeInspector>(Func<ITypeInspector, TTypeInspector> typeInspectorFactory, Action<IRegistrationLocationSelectionSyntax<ITypeInspector>> where) where TTypeInspector : ITypeInspector
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		public TBuilder WithTypeInspector<TTypeInspector>(WrapperFactory<ITypeInspector, ITypeInspector, TTypeInspector> typeInspectorFactory, Action<ITrackingRegistrationLocationSelectionSyntax<ITypeInspector>> where) where TTypeInspector : ITypeInspector
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		public TBuilder WithoutTypeInspector<TTypeInspector>() where TTypeInspector : ITypeInspector
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		public TBuilder WithoutTypeInspector(Type inspectorType)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		protected IEnumerable<IYamlTypeConverter> BuildTypeConverters()
		{
			return null;
		}
	}
	[Token(Token = "0x2000007")]
	public delegate TComponent WrapperFactory<TComponentBase, TComponent>(TComponentBase wrapped) where TComponent : TComponentBase;
	[Token(Token = "0x2000008")]
	public delegate TComponent WrapperFactory<TArgument, TComponentBase, TComponent>(TComponentBase wrapped, TArgument argument) where TComponent : TComponentBase;
	[Token(Token = "0x2000009")]
	public sealed class Deserializer
	{
		[Token(Token = "0x20000DB")]
		private class BackwardsCompatibleConfiguration
		{
			[Token(Token = "0x2000128")]
			private class TypeDescriptorProxy : ITypeInspector
			{
				[Token(Token = "0x4000253")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public ITypeInspector TypeDescriptor;

				[Token(Token = "0x600065E")]
				[Address(RVA = "0xCEBD40", Offset = "0xCEBD40", VA = "0xCEBD40", Slot = "4")]
				public IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
				{
					return null;
				}

				[Token(Token = "0x600065F")]
				[Address(RVA = "0xCEBE0C", Offset = "0xCEBE0C", VA = "0xCEBE0C", Slot = "5")]
				public IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched)
				{
					return null;
				}

				[Token(Token = "0x6000660")]
				[Address(RVA = "0xCEB884", Offset = "0xCEB884", VA = "0xCEB884")]
				public TypeDescriptorProxy()
				{
				}
			}

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly Dictionary<string, Type> predefinedTagMappings;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Dictionary<string, Type> tagMappings;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly List<IYamlTypeConverter> converters;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TypeDescriptorProxy typeDescriptor;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IValueDeserializer valueDeserializer;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674380", Offset = "0x674380")]
			private IList<INodeDeserializer> <NodeDeserializers>k__BackingField;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674390", Offset = "0x674390")]
			private IList<INodeTypeResolver> <TypeResolvers>k__BackingField;

			[Token(Token = "0x170000C6")]
			public IList<INodeDeserializer> NodeDeserializers
			{
				[Token(Token = "0x6000501")]
				[Address(RVA = "0xCEA310", Offset = "0xCEA310", VA = "0xCEA310")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6756B0", Offset = "0x6756B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000502")]
				[Address(RVA = "0xCEB874", Offset = "0xCEB874", VA = "0xCEB874")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6756C0", Offset = "0x6756C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			public IList<INodeTypeResolver> TypeResolvers
			{
				[Token(Token = "0x6000503")]
				[Address(RVA = "0xCEA34C", Offset = "0xCEA34C", VA = "0xCEA34C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6756D0", Offset = "0x6756D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000504")]
				[Address(RVA = "0xCEB87C", Offset = "0xCEB87C", VA = "0xCEB87C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6756E0", Offset = "0x6756E0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0xCEA400", Offset = "0xCEA400", VA = "0xCEA400")]
			public BackwardsCompatibleConfiguration(IObjectFactory objectFactory, INamingConvention namingConvention, bool ignoreUnmatched, YamlAttributeOverrides overrides)
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0xCEB05C", Offset = "0xCEB05C", VA = "0xCEB05C")]
			public void RegisterTagMapping(string tag, Type type)
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0xCEB110", Offset = "0xCEB110", VA = "0xCEB110")]
			public void RegisterTypeConverter(IYamlTypeConverter typeConverter)
			{
			}
		}

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly BackwardsCompatibleConfiguration backwardsCompatibleConfiguration;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IValueDeserializer valueDeserializer;

		[Token(Token = "0x17000002")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x675D84", Offset = "0x675D84")]
		public IList<INodeDeserializer> NodeDeserializers
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xCEA2DC", Offset = "0xCEA2DC", VA = "0xCEA2DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x675DBC", Offset = "0x675DBC")]
		public IList<INodeTypeResolver> TypeResolvers
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xCEA318", Offset = "0xCEA318", VA = "0xCEA318")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xCEA250", Offset = "0xCEA250", VA = "0xCEA250")]
		private void ThrowUnlessInBackwardsCompatibleMode()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xCEA354", Offset = "0xCEA354", VA = "0xCEA354")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6745F0", Offset = "0x6745F0")]
		public Deserializer([Optional] IObjectFactory objectFactory, [Optional] INamingConvention namingConvention, bool ignoreUnmatched = false, [Optional] YamlAttributeOverrides overrides)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xCEB010", Offset = "0xCEB010", VA = "0xCEB010")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x674628", Offset = "0x674628")]
		public void RegisterTagMapping(string tag, Type type)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xCEB0D4", Offset = "0xCEB0D4", VA = "0xCEB0D4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x674660", Offset = "0x674660")]
		public void RegisterTypeConverter(IYamlTypeConverter typeConverter)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xCEB184", Offset = "0xCEB184", VA = "0xCEB184")]
		public Deserializer()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xCEB210", Offset = "0xCEB210", VA = "0xCEB210")]
		private Deserializer(IValueDeserializer valueDeserializer)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xCEB2B4", Offset = "0xCEB2B4", VA = "0xCEB2B4")]
		public static Deserializer FromValueDeserializer(IValueDeserializer valueDeserializer)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		public T Deserialize<T>(string input)
		{
			return (T)null;
		}

		[Token(Token = "0x6000037")]
		public T Deserialize<T>(TextReader input)
		{
			return (T)null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xCE527C", Offset = "0xCE527C", VA = "0xCE527C")]
		public object Deserialize(TextReader input)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xCEB390", Offset = "0xCEB390", VA = "0xCEB390")]
		public object Deserialize(string input, Type type)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xCEB314", Offset = "0xCEB314", VA = "0xCEB314")]
		public object Deserialize(TextReader input, Type type)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		public T Deserialize<T>(IParser parser)
		{
			return (T)null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xCEB7E4", Offset = "0xCEB7E4", VA = "0xCEB7E4")]
		public object Deserialize(IParser parser)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xCEB4D0", Offset = "0xCEB4D0", VA = "0xCEB4D0")]
		public object Deserialize(IParser parser, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200000A")]
	public sealed class DeserializerBuilder : BuilderSkeleton<DeserializerBuilder>
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B28", Offset = "0x673B28")]
		private sealed class <>c
		{
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ITypeInspector, ITypeInspector> <>9__5_0;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<ITypeInspector, ITypeInspector> <>9__5_2;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<ITypeInspector, ITypeInspector> <>9__5_4;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Nothing, INodeDeserializer> <>9__5_8;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<Nothing, INodeDeserializer> <>9__5_9;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<Nothing, INodeDeserializer> <>9__5_10;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<Nothing, INodeDeserializer> <>9__5_13;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<Nothing, INodeTypeResolver> <>9__5_15;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<Nothing, INodeTypeResolver> <>9__5_16;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Func<Nothing, INodeTypeResolver> <>9__5_18;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<Nothing, INodeTypeResolver> <>9__5_19;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Action<IRegistrationLocationSelectionSyntax<INodeDeserializer>> <>9__10_0;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static Action<IRegistrationLocationSelectionSyntax<INodeTypeResolver>> <>9__15_0;

			[Token(Token = "0x600050A")]
			[Address(RVA = "0xCED09C", Offset = "0xCED09C", VA = "0xCED09C")]
			public <>c()
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0xCED0A4", Offset = "0xCED0A4", VA = "0xCED0A4")]
			internal ITypeInspector <.ctor>b__5_0(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0xCED108", Offset = "0xCED108", VA = "0xCED108")]
			internal ITypeInspector <.ctor>b__5_2(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0xCED16C", Offset = "0xCED16C", VA = "0xCED16C")]
			internal ITypeInspector <.ctor>b__5_4(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0xCED1D0", Offset = "0xCED1D0", VA = "0xCED1D0")]
			internal INodeDeserializer <.ctor>b__5_8(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0xCED22C", Offset = "0xCED22C", VA = "0xCED22C")]
			internal INodeDeserializer <.ctor>b__5_9(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0xCED288", Offset = "0xCED288", VA = "0xCED288")]
			internal INodeDeserializer <.ctor>b__5_10(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0xCED2E4", Offset = "0xCED2E4", VA = "0xCED2E4")]
			internal INodeDeserializer <.ctor>b__5_13(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0xCED340", Offset = "0xCED340", VA = "0xCED340")]
			internal INodeTypeResolver <.ctor>b__5_15(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0xCED39C", Offset = "0xCED39C", VA = "0xCED39C")]
			internal INodeTypeResolver <.ctor>b__5_16(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0xCED3F8", Offset = "0xCED3F8", VA = "0xCED3F8")]
			internal INodeTypeResolver <.ctor>b__5_18(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0xCED454", Offset = "0xCED454", VA = "0xCED454")]
			internal INodeTypeResolver <.ctor>b__5_19(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0xCED4B0", Offset = "0xCED4B0", VA = "0xCED4B0")]
			internal void <WithNodeDeserializer>b__10_0(IRegistrationLocationSelectionSyntax<INodeDeserializer> w)
			{
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0xCED564", Offset = "0xCED564", VA = "0xCED564")]
			internal void <WithNodeTypeResolver>b__15_0(IRegistrationLocationSelectionSyntax<INodeTypeResolver> w)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B38", Offset = "0x673B38")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public INodeDeserializer nodeDeserializer;

			[Token(Token = "0x6000518")]
			[Address(RVA = "0xCEC3A8", Offset = "0xCEC3A8", VA = "0xCEC3A8")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000519")]
			[Address(RVA = "0xCED618", Offset = "0xCED618", VA = "0xCED618")]
			internal INodeDeserializer <WithNodeDeserializer>b__0(Nothing _)
			{
				return null;
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B48", Offset = "0x673B48")]
		private sealed class <>c__DisplayClass12_0<TNodeDeserializer> where TNodeDeserializer : INodeDeserializer
		{
			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WrapperFactory<INodeDeserializer, TNodeDeserializer> nodeDeserializerFactory;

			[Token(Token = "0x600051A")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600051B")]
			internal INodeDeserializer <WithNodeDeserializer>b__0(INodeDeserializer wrapped, Nothing _)
			{
				return null;
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B58", Offset = "0x673B58")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public INodeTypeResolver nodeTypeResolver;

			[Token(Token = "0x600051C")]
			[Address(RVA = "0xCEC758", Offset = "0xCEC758", VA = "0xCEC758")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600051D")]
			[Address(RVA = "0xCED620", Offset = "0xCED620", VA = "0xCED620")]
			internal INodeTypeResolver <WithNodeTypeResolver>b__0(Nothing _)
			{
				return null;
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B68", Offset = "0x673B68")]
		private sealed class <>c__DisplayClass17_0<TNodeTypeResolver> where TNodeTypeResolver : INodeTypeResolver
		{
			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WrapperFactory<INodeTypeResolver, TNodeTypeResolver> nodeTypeResolverFactory;

			[Token(Token = "0x600051E")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600051F")]
			internal INodeTypeResolver <WithNodeTypeResolver>b__0(INodeTypeResolver wrapped, Nothing _)
			{
				return null;
			}
		}

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IObjectFactory objectFactory;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly LazyComponentRegistrationList<Nothing, INodeDeserializer> nodeDeserializerFactories;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly LazyComponentRegistrationList<Nothing, INodeTypeResolver> nodeTypeResolverFactories;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<string, Type> tagMappings;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool ignoreUnmatched;

		[Token(Token = "0x17000004")]
		protected override DeserializerBuilder Self
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xCEBEF4", Offset = "0xCEBEF4", VA = "0xCEBEF4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xCE4234", Offset = "0xCE4234", VA = "0xCE4234")]
		public DeserializerBuilder()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xCEBEF8", Offset = "0xCEBEF8", VA = "0xCEBEF8")]
		public DeserializerBuilder WithObjectFactory(IObjectFactory objectFactory)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xCEBF94", Offset = "0xCEBF94", VA = "0xCEBF94")]
		public DeserializerBuilder WithObjectFactory(Func<Type, object> objectFactory)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xCEC0F0", Offset = "0xCEC0F0", VA = "0xCEC0F0")]
		public DeserializerBuilder WithNodeDeserializer(INodeDeserializer nodeDeserializer)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xCEC1F4", Offset = "0xCEC1F4", VA = "0xCEC1F4")]
		public DeserializerBuilder WithNodeDeserializer(INodeDeserializer nodeDeserializer, Action<IRegistrationLocationSelectionSyntax<INodeDeserializer>> where)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		public DeserializerBuilder WithNodeDeserializer<TNodeDeserializer>(WrapperFactory<INodeDeserializer, TNodeDeserializer> nodeDeserializerFactory, Action<ITrackingRegistrationLocationSelectionSyntax<INodeDeserializer>> where) where TNodeDeserializer : INodeDeserializer
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		public DeserializerBuilder WithoutNodeDeserializer<TNodeDeserializer>() where TNodeDeserializer : INodeDeserializer
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xCEC3B0", Offset = "0xCEC3B0", VA = "0xCEC3B0")]
		public DeserializerBuilder WithoutNodeDeserializer(Type nodeDeserializerType)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xCEC4A0", Offset = "0xCEC4A0", VA = "0xCEC4A0")]
		public DeserializerBuilder WithNodeTypeResolver(INodeTypeResolver nodeTypeResolver)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xCEC5A4", Offset = "0xCEC5A4", VA = "0xCEC5A4")]
		public DeserializerBuilder WithNodeTypeResolver(INodeTypeResolver nodeTypeResolver, Action<IRegistrationLocationSelectionSyntax<INodeTypeResolver>> where)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		public DeserializerBuilder WithNodeTypeResolver<TNodeTypeResolver>(WrapperFactory<INodeTypeResolver, TNodeTypeResolver> nodeTypeResolverFactory, Action<ITrackingRegistrationLocationSelectionSyntax<INodeTypeResolver>> where) where TNodeTypeResolver : INodeTypeResolver
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		public DeserializerBuilder WithoutNodeTypeResolver<TNodeTypeResolver>() where TNodeTypeResolver : INodeTypeResolver
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xCEC760", Offset = "0xCEC760", VA = "0xCEC760")]
		public DeserializerBuilder WithoutNodeTypeResolver(Type nodeTypeResolverType)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xCEC850", Offset = "0xCEC850", VA = "0xCEC850")]
		public DeserializerBuilder WithTagMapping(string tag, Type type)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xCECA2C", Offset = "0xCECA2C", VA = "0xCECA2C")]
		public DeserializerBuilder WithoutTagMapping(string tag)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xCECB40", Offset = "0xCECB40", VA = "0xCECB40")]
		public DeserializerBuilder IgnoreUnmatchedProperties()
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xCE5268", Offset = "0xCE5268", VA = "0xCE5268")]
		public Deserializer Build()
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xCECB4C", Offset = "0xCECB4C", VA = "0xCECB4C")]
		public IValueDeserializer BuildValueDeserializer()
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xCECC14", Offset = "0xCECC14", VA = "0xCECC14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674698", Offset = "0x674698")]
		private ITypeInspector <.ctor>b__5_1(ITypeInspector inner)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xCECC94", Offset = "0xCECC94", VA = "0xCECC94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746A8", Offset = "0x6746A8")]
		private ITypeInspector <.ctor>b__5_3(ITypeInspector inner)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xCECD24", Offset = "0xCECD24", VA = "0xCECD24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746B8", Offset = "0x6746B8")]
		private INodeDeserializer <.ctor>b__5_5(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xCECD8C", Offset = "0xCECD8C", VA = "0xCECD8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746C8", Offset = "0x6746C8")]
		private INodeDeserializer <.ctor>b__5_6(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xCECDF4", Offset = "0xCECDF4", VA = "0xCECDF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746D8", Offset = "0x6746D8")]
		private INodeDeserializer <.ctor>b__5_7(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xCECE70", Offset = "0xCECE70", VA = "0xCECE70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746E8", Offset = "0x6746E8")]
		private INodeDeserializer <.ctor>b__5_11(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xCECED8", Offset = "0xCECED8", VA = "0xCECED8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746F8", Offset = "0x6746F8")]
		private INodeDeserializer <.ctor>b__5_12(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xCECF40", Offset = "0xCECF40", VA = "0xCECF40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674708", Offset = "0x674708")]
		private INodeDeserializer <.ctor>b__5_14(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xCECFD4", Offset = "0xCECFD4", VA = "0xCECFD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674718", Offset = "0x674718")]
		private INodeTypeResolver <.ctor>b__5_17(Nothing _)
		{
			return null;
		}
	}
	[Token(Token = "0x200000B")]
	public sealed class EmissionPhaseObjectGraphVisitorArgs
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673EC0", Offset = "0x673EC0")]
		private IObjectGraphVisitor<IEmitter> <InnerVisitor>k__BackingField;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673ED0", Offset = "0x673ED0")]
		private IEventEmitter <EventEmitter>k__BackingField;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673EE0", Offset = "0x673EE0")]
		private ObjectSerializer <NestedObjectSerializer>k__BackingField;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673EF0", Offset = "0x673EF0")]
		private IEnumerable<IYamlTypeConverter> <TypeConverters>k__BackingField;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IEnumerable<IObjectGraphVisitor<Nothing>> preProcessingPhaseVisitors;

		[Token(Token = "0x17000005")]
		public IObjectGraphVisitor<IEmitter> InnerVisitor
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xCED628", Offset = "0xCED628", VA = "0xCED628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674728", Offset = "0x674728")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xCED630", Offset = "0xCED630", VA = "0xCED630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674738", Offset = "0x674738")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public IEventEmitter EventEmitter
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xCED638", Offset = "0xCED638", VA = "0xCED638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674748", Offset = "0x674748")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xCED640", Offset = "0xCED640", VA = "0xCED640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674758", Offset = "0x674758")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public ObjectSerializer NestedObjectSerializer
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xCED648", Offset = "0xCED648", VA = "0xCED648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674768", Offset = "0x674768")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xCED650", Offset = "0xCED650", VA = "0xCED650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674778", Offset = "0x674778")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public IEnumerable<IYamlTypeConverter> TypeConverters
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xCED658", Offset = "0xCED658", VA = "0xCED658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674788", Offset = "0x674788")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0xCED660", Offset = "0xCED660", VA = "0xCED660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674798", Offset = "0x674798")]
			private set
			{
			}
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xCED668", Offset = "0xCED668", VA = "0xCED668")]
		public EmissionPhaseObjectGraphVisitorArgs(IObjectGraphVisitor<IEmitter> innerVisitor, IEventEmitter eventEmitter, IEnumerable<IObjectGraphVisitor<Nothing>> preProcessingPhaseVisitors, IEnumerable<IYamlTypeConverter> typeConverters, ObjectSerializer nestedObjectSerializer)
		{
		}

		[Token(Token = "0x6000063")]
		public T GetPreProcessingPhaseObjectGraphVisitor<T>() where T : IObjectGraphVisitor<Nothing>
		{
			return (T)null;
		}
	}
	[Token(Token = "0x200000C")]
	public abstract class EventInfo
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F00", Offset = "0x673F00")]
		private IObjectDescriptor <Source>k__BackingField;

		[Token(Token = "0x17000009")]
		public IObjectDescriptor Source
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0xCEDFEC", Offset = "0xCEDFEC", VA = "0xCEDFEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6747A8", Offset = "0x6747A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xCEFD78", Offset = "0xCEFD78", VA = "0xCEFD78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6747B8", Offset = "0x6747B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xCE9774", Offset = "0xCE9774", VA = "0xCE9774")]
		protected EventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class AliasEventInfo : EventInfo
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F10", Offset = "0x673F10")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x1700000A")]
		public string Alias
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xCE97A0", Offset = "0xCE97A0", VA = "0xCE97A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6747C8", Offset = "0x6747C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xCE97A8", Offset = "0xCE97A8", VA = "0xCE97A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6747D8", Offset = "0x6747D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xCE9748", Offset = "0xCE9748", VA = "0xCE9748")]
		public AliasEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class ObjectEventInfo : EventInfo
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F20", Offset = "0x673F20")]
		private string <Anchor>k__BackingField;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F30", Offset = "0x673F30")]
		private string <Tag>k__BackingField;

		[Token(Token = "0x1700000B")]
		public string Anchor
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xCEF8F8", Offset = "0xCEF8F8", VA = "0xCEF8F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6747E8", Offset = "0x6747E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xCF4B94", Offset = "0xCF4B94", VA = "0xCF4B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6747F8", Offset = "0x6747F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public string Tag
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xCEF900", Offset = "0xCEF900", VA = "0xCEF900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674808", Offset = "0x674808")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xCEDFF4", Offset = "0xCEDFF4", VA = "0xCEDFF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674818", Offset = "0x674818")]
			set
			{
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xCEFDD8", Offset = "0xCEFDD8", VA = "0xCEFDD8")]
		protected ObjectEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public sealed class ScalarEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F40", Offset = "0x673F40")]
		private string <RenderedValue>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F50", Offset = "0x673F50")]
		private ScalarStyle <Style>k__BackingField;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F60", Offset = "0x673F60")]
		private bool <IsPlainImplicit>k__BackingField;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F70", Offset = "0x673F70")]
		private bool <IsQuotedImplicit>k__BackingField;

		[Token(Token = "0x1700000D")]
		public string RenderedValue
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xCEF908", Offset = "0xCEF908", VA = "0xCEF908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674828", Offset = "0x674828")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0xCEE7D0", Offset = "0xCEE7D0", VA = "0xCEE7D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674838", Offset = "0x674838")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xCEF31C", Offset = "0xCEF31C", VA = "0xCEF31C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674848", Offset = "0x674848")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xCEE7C8", Offset = "0xCEE7C8", VA = "0xCEE7C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674858", Offset = "0x674858")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool IsPlainImplicit
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xCEF910", Offset = "0xCEF910", VA = "0xCEF910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674868", Offset = "0x674868")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xCEE7BC", Offset = "0xCEE7BC", VA = "0xCEE7BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674878", Offset = "0x674878")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool IsQuotedImplicit
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xCEF918", Offset = "0xCEF918", VA = "0xCEF918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674888", Offset = "0x674888")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xCF8D94", Offset = "0xCF8D94", VA = "0xCF8D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674898", Offset = "0x674898")]
			set
			{
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xCF633C", Offset = "0xCF633C", VA = "0xCF633C")]
		public ScalarEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public sealed class MappingStartEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F80", Offset = "0x673F80")]
		private bool <IsImplicit>k__BackingField;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673F90", Offset = "0x673F90")]
		private MappingStyle <Style>k__BackingField;

		[Token(Token = "0x17000011")]
		public bool IsImplicit
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xCEFA68", Offset = "0xCEFA68", VA = "0xCEFA68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6748A8", Offset = "0x6748A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xCEFE04", Offset = "0xCEFE04", VA = "0xCEFE04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6748B8", Offset = "0x6748B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public MappingStyle Style
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xCEFA70", Offset = "0xCEFA70", VA = "0xCEFA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6748C8", Offset = "0x6748C8")]
			get
			{
				return default(MappingStyle);
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xCEE824", Offset = "0xCEE824", VA = "0xCEE824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6748D8", Offset = "0x6748D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xCEFDAC", Offset = "0xCEFDAC", VA = "0xCEFDAC")]
		public MappingStartEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000011")]
	public sealed class MappingEndEventInfo : EventInfo
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xCEFD80", Offset = "0xCEFD80", VA = "0xCEFD80")]
		public MappingEndEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public sealed class SequenceStartEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673FA0", Offset = "0x673FA0")]
		private bool <IsImplicit>k__BackingField;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673FB0", Offset = "0x673FB0")]
		private SequenceStyle <Style>k__BackingField;

		[Token(Token = "0x17000013")]
		public bool IsImplicit
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xCEFC90", Offset = "0xCEFC90", VA = "0xCEFC90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6748E8", Offset = "0x6748E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xCF8DA0", Offset = "0xCF8DA0", VA = "0xCF8DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6748F8", Offset = "0x6748F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public SequenceStyle Style
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xCEFC98", Offset = "0xCEFC98", VA = "0xCEFC98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674908", Offset = "0x674908")]
			get
			{
				return default(SequenceStyle);
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xCEE878", Offset = "0xCEE878", VA = "0xCEE878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674918", Offset = "0x674918")]
			set
			{
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xCF6114", Offset = "0xCF6114", VA = "0xCF6114")]
		public SequenceStartEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public sealed class SequenceEndEventInfo : EventInfo
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xCF7AD4", Offset = "0xCF7AD4", VA = "0xCF7AD4")]
		public SequenceEndEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public interface IAliasProvider
	{
		[Token(Token = "0x6000084")]
		string GetAlias(object target);
	}
	[Token(Token = "0x2000015")]
	public interface IEventEmitter
	{
		[Token(Token = "0x6000085")]
		void Emit(AliasEventInfo eventInfo, IEmitter emitter);

		[Token(Token = "0x6000086")]
		void Emit(ScalarEventInfo eventInfo, IEmitter emitter);

		[Token(Token = "0x6000087")]
		void Emit(MappingStartEventInfo eventInfo, IEmitter emitter);

		[Token(Token = "0x6000088")]
		void Emit(MappingEndEventInfo eventInfo, IEmitter emitter);

		[Token(Token = "0x6000089")]
		void Emit(SequenceStartEventInfo eventInfo, IEmitter emitter);

		[Token(Token = "0x600008A")]
		void Emit(SequenceEndEventInfo eventInfo, IEmitter emitter);
	}
	[Token(Token = "0x2000016")]
	public interface INamingConvention
	{
		[Token(Token = "0x600008B")]
		string Apply(string value);
	}
	[Token(Token = "0x2000017")]
	public interface INodeDeserializer
	{
		[Token(Token = "0x600008C")]
		bool Deserialize(IParser reader, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value);
	}
	[Token(Token = "0x2000018")]
	public interface INodeTypeResolver
	{
		[Token(Token = "0x600008D")]
		bool Resolve(NodeEvent nodeEvent, ref Type currentType);
	}
	[Token(Token = "0x2000019")]
	public interface IObjectDescriptor
	{
		[Token(Token = "0x17000015")]
		object Value
		{
			[Token(Token = "0x600008E")]
			get;
		}

		[Token(Token = "0x17000016")]
		Type Type
		{
			[Token(Token = "0x600008F")]
			get;
		}

		[Token(Token = "0x17000017")]
		Type StaticType
		{
			[Token(Token = "0x6000090")]
			get;
		}

		[Token(Token = "0x17000018")]
		ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000091")]
			get;
		}
	}
	[Token(Token = "0x200001A")]
	public interface IObjectFactory
	{
		[Token(Token = "0x6000092")]
		object Create(Type type);
	}
	[Token(Token = "0x200001B")]
	public interface IObjectGraphTraversalStrategy
	{
		[Token(Token = "0x6000093")]
		void Traverse<TContext>(IObjectDescriptor graph, IObjectGraphVisitor<TContext> visitor, TContext context);
	}
	[Token(Token = "0x200001C")]
	public interface IObjectGraphVisitor<TContext>
	{
		[Token(Token = "0x6000094")]
		bool Enter(IObjectDescriptor value, TContext context);

		[Token(Token = "0x6000095")]
		bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value, TContext context);

		[Token(Token = "0x6000096")]
		bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value, TContext context);

		[Token(Token = "0x6000097")]
		void VisitScalar(IObjectDescriptor scalar, TContext context);

		[Token(Token = "0x6000098")]
		void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, TContext context);

		[Token(Token = "0x6000099")]
		void VisitMappingEnd(IObjectDescriptor mapping, TContext context);

		[Token(Token = "0x600009A")]
		void VisitSequenceStart(IObjectDescriptor sequence, Type elementType, TContext context);

		[Token(Token = "0x600009B")]
		void VisitSequenceEnd(IObjectDescriptor sequence, TContext context);
	}
	[Token(Token = "0x200001D")]
	public interface IPropertyDescriptor
	{
		[Token(Token = "0x17000019")]
		string Name
		{
			[Token(Token = "0x600009C")]
			get;
		}

		[Token(Token = "0x1700001A")]
		bool CanWrite
		{
			[Token(Token = "0x600009D")]
			get;
		}

		[Token(Token = "0x1700001B")]
		Type Type
		{
			[Token(Token = "0x600009E")]
			get;
		}

		[Token(Token = "0x1700001C")]
		Type TypeOverride
		{
			[Token(Token = "0x600009F")]
			get;
			[Token(Token = "0x60000A0")]
			set;
		}

		[Token(Token = "0x1700001D")]
		int Order
		{
			[Token(Token = "0x60000A1")]
			get;
			[Token(Token = "0x60000A2")]
			set;
		}

		[Token(Token = "0x1700001E")]
		ScalarStyle ScalarStyle
		{
			[Token(Token = "0x60000A3")]
			get;
			[Token(Token = "0x60000A4")]
			set;
		}

		[Token(Token = "0x60000A5")]
		T GetCustomAttribute<T>() where T : Attribute;

		[Token(Token = "0x60000A6")]
		IObjectDescriptor Read(object target);

		[Token(Token = "0x60000A7")]
		void Write(object target, object value);
	}
	[Token(Token = "0x200001E")]
	public interface IRegistrationLocationSelectionSyntax<TBaseRegistrationType>
	{
		[Token(Token = "0x60000A8")]
		void InsteadOf<TRegistrationType>() where TRegistrationType : TBaseRegistrationType;

		[Token(Token = "0x60000A9")]
		void Before<TRegistrationType>() where TRegistrationType : TBaseRegistrationType;

		[Token(Token = "0x60000AA")]
		void After<TRegistrationType>() where TRegistrationType : TBaseRegistrationType;

		[Token(Token = "0x60000AB")]
		void OnTop();

		[Token(Token = "0x60000AC")]
		void OnBottom();
	}
	[Token(Token = "0x200001F")]
	public interface ITrackingRegistrationLocationSelectionSyntax<TBaseRegistrationType>
	{
		[Token(Token = "0x60000AD")]
		void InsteadOf<TRegistrationType>() where TRegistrationType : TBaseRegistrationType;
	}
	[Token(Token = "0x2000020")]
	public interface ITypeInspector
	{
		[Token(Token = "0x60000AE")]
		IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container);

		[Token(Token = "0x60000AF")]
		IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched);
	}
	[Token(Token = "0x2000021")]
	public interface ITypeResolver
	{
		[Token(Token = "0x60000B0")]
		Type Resolve(Type staticType, object actualValue);
	}
	[Token(Token = "0x2000022")]
	public interface IValueDeserializer
	{
		[Token(Token = "0x60000B1")]
		object DeserializeValue(IParser parser, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer);
	}
	[Token(Token = "0x2000023")]
	public interface IValuePromise
	{
		[Token(Token = "0x14000001")]
		event Action<object> ValueAvailable;
	}
	[Token(Token = "0x2000024")]
	public interface IValueSerializer
	{
		[Token(Token = "0x60000B4")]
		void SerializeValue(IEmitter emitter, object value, Type type);
	}
	[Token(Token = "0x2000025")]
	public interface IYamlConvertible
	{
		[Token(Token = "0x60000B5")]
		void Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer);

		[Token(Token = "0x60000B6")]
		void Write(IEmitter emitter, ObjectSerializer nestedObjectSerializer);
	}
	[Token(Token = "0x2000026")]
	public delegate object ObjectDeserializer(Type type);
	[Token(Token = "0x2000027")]
	public delegate void ObjectSerializer(object value, [Optional] Type type);
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6737E8", Offset = "0x6737E8")]
	public interface IYamlSerializable
	{
		[Token(Token = "0x60000BF")]
		void ReadYaml(IParser parser);

		[Token(Token = "0x60000C0")]
		void WriteYaml(IEmitter emitter);
	}
	[Token(Token = "0x2000029")]
	public interface IYamlTypeConverter
	{
		[Token(Token = "0x60000C1")]
		bool Accepts(Type type);

		[Token(Token = "0x60000C2")]
		object ReadYaml(IParser parser, Type type);

		[Token(Token = "0x60000C3")]
		void WriteYaml(IEmitter emitter, object value, Type type);
	}
	[Token(Token = "0x200002A")]
	internal sealed class LazyComponentRegistrationList<TArgument, TComponent> : IEnumerable<Func<TArgument, TComponent>>, IEnumerable
	{
		[Token(Token = "0x20000E1")]
		public sealed class LazyComponentRegistration
		{
			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly Type ComponentType;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly Func<TArgument, TComponent> Factory;

			[Token(Token = "0x6000520")]
			public LazyComponentRegistration(Type componentType, Func<TArgument, TComponent> factory)
			{
			}
		}

		[Token(Token = "0x20000E2")]
		public sealed class TrackingLazyComponentRegistration
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly Type ComponentType;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly Func<TComponent, TArgument, TComponent> Factory;

			[Token(Token = "0x6000521")]
			public TrackingLazyComponentRegistration(Type componentType, Func<TComponent, TArgument, TComponent> factory)
			{
			}
		}

		[Token(Token = "0x20000E3")]
		private class RegistrationLocationSelector : IRegistrationLocationSelectionSyntax<TComponent>
		{
			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly LazyComponentRegistrationList<TArgument, TComponent> registrations;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly LazyComponentRegistration newRegistration;

			[Token(Token = "0x6000522")]
			public RegistrationLocationSelector(LazyComponentRegistrationList<TArgument, TComponent> registrations, LazyComponentRegistration newRegistration)
			{
			}

			[Token(Token = "0x6000523")]
			private void YamlDotNet.Serialization.IRegistrationLocationSelectionSyntax<TComponent>.InsteadOf<TRegistrationType>() where TRegistrationType : TComponent
			{
			}

			[Token(Token = "0x6000524")]
			private void YamlDotNet.Serialization.IRegistrationLocationSelectionSyntax<TComponent>.After<TRegistrationType>() where TRegistrationType : TComponent
			{
			}

			[Token(Token = "0x6000525")]
			private void YamlDotNet.Serialization.IRegistrationLocationSelectionSyntax<TComponent>.Before<TRegistrationType>() where TRegistrationType : TComponent
			{
			}

			[Token(Token = "0x6000526")]
			private void YamlDotNet.Serialization.IRegistrationLocationSelectionSyntax<TComponent>.OnBottom()
			{
			}

			[Token(Token = "0x6000527")]
			private void YamlDotNet.Serialization.IRegistrationLocationSelectionSyntax<TComponent>.OnTop()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		private class TrackingRegistrationLocationSelector : ITrackingRegistrationLocationSelectionSyntax<TComponent>
		{
			[Token(Token = "0x2000129")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E80", Offset = "0x673E80")]
			private sealed class <>c__DisplayClass3_0<TRegistrationType> where TRegistrationType : TComponent
			{
				[Token(Token = "0x4000254")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public TrackingRegistrationLocationSelector <>4__this;

				[Token(Token = "0x4000255")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Func<TArgument, TComponent> innerComponentFactory;

				[Token(Token = "0x6000661")]
				public <>c__DisplayClass3_0()
				{
				}

				[Token(Token = "0x6000662")]
				internal TComponent <YamlDotNet.Serialization.ITrackingRegistrationLocationSelectionSyntax<TComponent>.InsteadOf>b__0(TArgument arg)
				{
					return (TComponent)null;
				}
			}

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly LazyComponentRegistrationList<TArgument, TComponent> registrations;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly TrackingLazyComponentRegistration newRegistration;

			[Token(Token = "0x6000528")]
			public TrackingRegistrationLocationSelector(LazyComponentRegistrationList<TArgument, TComponent> registrations, TrackingLazyComponentRegistration newRegistration)
			{
			}

			[Token(Token = "0x6000529")]
			private void YamlDotNet.Serialization.ITrackingRegistrationLocationSelectionSyntax<TComponent>.InsteadOf<TRegistrationType>() where TRegistrationType : TComponent
			{
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B78", Offset = "0x673B78")]
		private sealed class <get_InReverseOrder>d__9 : IEnumerable<Func<TArgument, TComponent>>, IEnumerable, IEnumerator<Func<TArgument, TComponent>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Func<TArgument, TComponent> <>2__current;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LazyComponentRegistrationList<TArgument, TComponent> <>4__this;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x170000C8")]
			private Func<TArgument, TComponent> System.Collections.Generic.IEnumerator<System.Func<TArgument,TComponent>>.Current
			{
				[Token(Token = "0x600052D")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600052F")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600052A")]
			[DebuggerHidden]
			public <get_InReverseOrder>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600052B")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600052C")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600052E")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000530")]
			[DebuggerHidden]
			private IEnumerator<Func<TArgument, TComponent>> System.Collections.Generic.IEnumerable<System.Func<TArgument,TComponent>>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000531")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B88", Offset = "0x673B88")]
		private sealed class <>c
		{
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<LazyComponentRegistration, Func<TArgument, TComponent>> <>9__12_0;

			[Token(Token = "0x6000533")]
			public <>c()
			{
			}

			[Token(Token = "0x6000534")]
			internal Func<TArgument, TComponent> <GetEnumerator>b__12_0(LazyComponentRegistration e)
			{
				return null;
			}
		}

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<LazyComponentRegistration> entries;

		[Token(Token = "0x1700001F")]
		public int Count
		{
			[Token(Token = "0x60000C7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000020")]
		public IEnumerable<Func<TArgument, TComponent>> InReverseOrder
		{
			[Token(Token = "0x60000C8")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x674948", Offset = "0x674948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C4")]
		public LazyComponentRegistrationList<TArgument, TComponent> Clone()
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		public void Add(Type componentType, Func<TArgument, TComponent> factory)
		{
		}

		[Token(Token = "0x60000C6")]
		public void Remove(Type componentType)
		{
		}

		[Token(Token = "0x60000C9")]
		public IRegistrationLocationSelectionSyntax<TComponent> CreateRegistrationLocationSelector(Type componentType, Func<TArgument, TComponent> factory)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		public ITrackingRegistrationLocationSelectionSyntax<TComponent> CreateTrackingRegistrationLocationSelector(Type componentType, Func<TComponent, TArgument, TComponent> factory)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		public IEnumerator<Func<TArgument, TComponent>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		private int IndexOfRegistration(Type registrationType)
		{
			return default(int);
		}

		[Token(Token = "0x60000CE")]
		private void EnsureNoDuplicateRegistrationType(Type componentType)
		{
		}

		[Token(Token = "0x60000CF")]
		private int EnsureRegistrationExists<TRegistrationType>()
		{
			return default(int);
		}

		[Token(Token = "0x60000D0")]
		public LazyComponentRegistrationList()
		{
		}
	}
	[Token(Token = "0x200002B")]
	internal static class LazyComponentRegistrationListExtensions
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673B98", Offset = "0x673B98")]
		private sealed class <>c__0<TComponent>
		{
			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__0<TComponent> <>9;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<TComponent, Func<TComponent, TComponent>, TComponent> <>9__0_0;

			[Token(Token = "0x6000536")]
			public <>c__0()
			{
			}

			[Token(Token = "0x6000537")]
			internal TComponent <BuildComponentChain>b__0_0(TComponent inner, Func<TComponent, TComponent> factory)
			{
				return (TComponent)null;
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673BA8", Offset = "0x673BA8")]
		private sealed class <>c__DisplayClass1_0<TArgument, TComponent>
		{
			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<TComponent, TArgument> argumentBuilder;

			[Token(Token = "0x6000538")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000539")]
			internal TComponent <BuildComponentChain>b__0(TComponent inner, Func<TArgument, TComponent> factory)
			{
				return (TComponent)null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673BB8", Offset = "0x673BB8")]
		private sealed class <>c__2<TComponent>
		{
			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__2<TComponent> <>9;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<Func<Nothing, TComponent>, TComponent> <>9__2_0;

			[Token(Token = "0x600053B")]
			public <>c__2()
			{
			}

			[Token(Token = "0x600053C")]
			internal TComponent <BuildComponentList>b__2_0(Func<Nothing, TComponent> factory)
			{
				return (TComponent)null;
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673BC8", Offset = "0x673BC8")]
		private sealed class <>c__DisplayClass3_0<TArgument, TComponent>
		{
			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TArgument argument;

			[Token(Token = "0x600053D")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600053E")]
			internal TComponent <BuildComponentList>b__0(Func<TArgument, TComponent> factory)
			{
				return (TComponent)null;
			}
		}

		[Token(Token = "0x60000D1")]
		public static TComponent BuildComponentChain<TComponent>(this LazyComponentRegistrationList<TComponent, TComponent> registrations, TComponent innerComponent)
		{
			return (TComponent)null;
		}

		[Token(Token = "0x60000D2")]
		public static TComponent BuildComponentChain<TArgument, TComponent>(this LazyComponentRegistrationList<TArgument, TComponent> registrations, TComponent innerComponent, Func<TComponent, TArgument> argumentBuilder)
		{
			return (TComponent)null;
		}

		[Token(Token = "0x60000D3")]
		public static List<TComponent> BuildComponentList<TComponent>(this LazyComponentRegistrationList<Nothing, TComponent> registrations)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		public static List<TComponent> BuildComponentList<TArgument, TComponent>(this LazyComponentRegistrationList<TArgument, TComponent> registrations, TArgument argument)
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	public sealed class Nothing
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xCF4288", Offset = "0xCF4288", VA = "0xCF4288")]
		private Nothing()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public sealed class ObjectDescriptor : IObjectDescriptor
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673FC0", Offset = "0x673FC0")]
		private object <Value>k__BackingField;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673FD0", Offset = "0x673FD0")]
		private Type <Type>k__BackingField;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673FE0", Offset = "0x673FE0")]
		private Type <StaticType>k__BackingField;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673FF0", Offset = "0x673FF0")]
		private ScalarStyle <ScalarStyle>k__BackingField;

		[Token(Token = "0x17000021")]
		public object Value
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xCF4290", Offset = "0xCF4290", VA = "0xCF4290", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6749EC", Offset = "0x6749EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xCF4298", Offset = "0xCF4298", VA = "0xCF4298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6749FC", Offset = "0x6749FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Type Type
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xCF42A0", Offset = "0xCF42A0", VA = "0xCF42A0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A0C", Offset = "0x674A0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xCF42A8", Offset = "0xCF42A8", VA = "0xCF42A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A1C", Offset = "0x674A1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Type StaticType
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xCF42B0", Offset = "0xCF42B0", VA = "0xCF42B0", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A2C", Offset = "0x674A2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xCF42B8", Offset = "0xCF42B8", VA = "0xCF42B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A3C", Offset = "0x674A3C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xCF42C0", Offset = "0xCF42C0", VA = "0xCF42C0", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A4C", Offset = "0x674A4C")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xCF42C8", Offset = "0xCF42C8", VA = "0xCF42C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A5C", Offset = "0x674A5C")]
			private set
			{
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xCF42D0", Offset = "0xCF42D0", VA = "0xCF42D0")]
		public ObjectDescriptor(object value, Type type, Type staticType)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xCF42D8", Offset = "0xCF42D8", VA = "0xCF42D8")]
		public ObjectDescriptor(object value, Type type, Type staticType, ScalarStyle scalarStyle)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public sealed class PropertyDescriptor : IPropertyDescriptor
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IPropertyDescriptor baseDescriptor;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674000", Offset = "0x674000")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674010", Offset = "0x674010")]
		private int <Order>k__BackingField;

		[Token(Token = "0x17000025")]
		public string Name
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xCF8774", Offset = "0xCF8774", VA = "0xCF8774", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A6C", Offset = "0x674A6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xCF876C", Offset = "0xCF876C", VA = "0xCF876C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A7C", Offset = "0x674A7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Type Type
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xCF877C", Offset = "0xCF877C", VA = "0xCF877C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public Type TypeOverride
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xCF8834", Offset = "0xCF8834", VA = "0xCF8834", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xCF88EC", Offset = "0xCF88EC", VA = "0xCF88EC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int Order
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xCF89B4", Offset = "0xCF89B4", VA = "0xCF89B4", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A8C", Offset = "0x674A8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xCF89BC", Offset = "0xCF89BC", VA = "0xCF89BC", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A9C", Offset = "0x674A9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xCF89C4", Offset = "0xCF89C4", VA = "0xCF89C4", Slot = "11")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xCF8A7C", Offset = "0xCF8A7C", VA = "0xCF8A7C", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool CanWrite
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xCF8B44", Offset = "0xCF8B44", VA = "0xCF8B44", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xCF8698", Offset = "0xCF8698", VA = "0xCF8698")]
		public PropertyDescriptor(IPropertyDescriptor baseDescriptor)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xCF8BFC", Offset = "0xCF8BFC", VA = "0xCF8BFC", Slot = "15")]
		public void Write(object target, object value)
		{
		}

		[Token(Token = "0x60000EC")]
		public T GetCustomAttribute<T>() where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xCF8CCC", Offset = "0xCF8CCC", VA = "0xCF8CCC", Slot = "14")]
		public IObjectDescriptor Read(object target)
		{
			return null;
		}
	}
	[Token(Token = "0x200002F")]
	[Flags]
	public enum SerializationOptions
	{
		[Token(Token = "0x400002A")]
		None = 0,
		[Token(Token = "0x400002B")]
		Roundtrip = 1,
		[Token(Token = "0x400002C")]
		DisableAliases = 2,
		[Token(Token = "0x400002D")]
		EmitDefaults = 4,
		[Token(Token = "0x400002E")]
		JsonCompatible = 8,
		[Token(Token = "0x400002F")]
		DefaultToStaticType = 0x10
	}
	[Token(Token = "0x2000030")]
	public sealed class Serializer
	{
		[Token(Token = "0x20000EB")]
		private class BackwardsCompatibleConfiguration : IValueSerializer
		{
			[Token(Token = "0x200012A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E90", Offset = "0x673E90")]
			private sealed class <>c__DisplayClass10_0
			{
				[Token(Token = "0x4000256")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public BackwardsCompatibleConfiguration <>4__this;

				[Token(Token = "0x4000257")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public IEmitter emitter;

				[Token(Token = "0x6000663")]
				[Address(RVA = "0xCF9B08", Offset = "0xCF9B08", VA = "0xCF9B08")]
				public <>c__DisplayClass10_0()
				{
				}

				[Token(Token = "0x6000664")]
				[Address(RVA = "0xCF9F8C", Offset = "0xCF9F8C", VA = "0xCF9F8C")]
				internal void <CreateEmittingVisitor>b__0(object v, Type t)
				{
				}
			}

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743A0", Offset = "0x6743A0")]
			private IList<IYamlTypeConverter> <Converters>k__BackingField;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly SerializationOptions options;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly INamingConvention namingConvention;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly ITypeResolver typeResolver;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private readonly YamlAttributeOverrides overrides;

			[Token(Token = "0x170000CA")]
			public IList<IYamlTypeConverter> Converters
			{
				[Token(Token = "0x600053F")]
				[Address(RVA = "0xCF9154", Offset = "0xCF9154", VA = "0xCF9154")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675760", Offset = "0x675760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000540")]
				[Address(RVA = "0xCF98B0", Offset = "0xCF98B0", VA = "0xCF98B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675770", Offset = "0x675770")]
				private set
				{
				}
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0xCF8EC8", Offset = "0xCF8EC8", VA = "0xCF8EC8")]
			public BackwardsCompatibleConfiguration(SerializationOptions options, INamingConvention namingConvention, YamlAttributeOverrides overrides)
			{
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0xCF98B8", Offset = "0xCF98B8", VA = "0xCF98B8")]
			public bool IsOptionSet(SerializationOptions option)
			{
				return default(bool);
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xCF98C8", Offset = "0xCF98C8", VA = "0xCF98C8")]
			private IObjectGraphVisitor<IEmitter> CreateEmittingVisitor(IEmitter emitter, IObjectGraphTraversalStrategy traversalStrategy, IEventEmitter eventEmitter, IObjectDescriptor graph)
			{
				return null;
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xCF9B10", Offset = "0xCF9B10", VA = "0xCF9B10")]
			private IEventEmitter CreateEventEmitter()
			{
				return null;
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xCF9BC4", Offset = "0xCF9BC4", VA = "0xCF9BC4")]
			private IObjectGraphTraversalStrategy CreateTraversalStrategy()
			{
				return null;
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0xCF9D68", Offset = "0xCF9D68", VA = "0xCF9D68", Slot = "4")]
			public void SerializeValue(IEmitter emitter, object value, Type type)
			{
			}
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IValueSerializer valueSerializer;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly BackwardsCompatibleConfiguration backwardsCompatibleConfiguration;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xCF8DAC", Offset = "0xCF8DAC", VA = "0xCF8DAC")]
		private void ThrowUnlessInBackwardsCompatibleMode()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xCF8E38", Offset = "0xCF8E38", VA = "0xCF8E38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x674AAC", Offset = "0x674AAC")]
		public Serializer(SerializationOptions options = SerializationOptions.None, [Optional] INamingConvention namingConvention, [Optional] YamlAttributeOverrides overrides)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xCF9070", Offset = "0xCF9070", VA = "0xCF9070")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x674AE4", Offset = "0x674AE4")]
		public void RegisterTypeConverter(IYamlTypeConverter converter)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xCF915C", Offset = "0xCF915C", VA = "0xCF915C")]
		public Serializer()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xCF91D0", Offset = "0xCF91D0", VA = "0xCF91D0")]
		private Serializer(IValueSerializer valueSerializer)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xCF9274", Offset = "0xCF9274", VA = "0xCF9274")]
		public static Serializer FromValueSerializer(IValueSerializer valueSerializer)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xCF92D4", Offset = "0xCF92D4", VA = "0xCF92D4")]
		public void Serialize(TextWriter writer, object graph)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xCE5EE4", Offset = "0xCE5EE4", VA = "0xCE5EE4")]
		public string Serialize(object graph)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xCF93F8", Offset = "0xCF93F8", VA = "0xCF93F8")]
		public void Serialize(TextWriter writer, object graph, Type type)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xCF9350", Offset = "0xCF9350", VA = "0xCF9350")]
		public void Serialize(IEmitter emitter, object graph)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xCF9484", Offset = "0xCF9484", VA = "0xCF9484")]
		public void Serialize(IEmitter emitter, object graph, Type type)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xCF9588", Offset = "0xCF9588", VA = "0xCF9588")]
		private void EmitDocument(IEmitter emitter, object graph, Type type)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public sealed class SerializerBuilder : BuilderSkeleton<SerializerBuilder>
	{
		[Token(Token = "0x20000EC")]
		private class ValueSerializer : IValueSerializer
		{
			[Token(Token = "0x200012B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673EA0", Offset = "0x673EA0")]
			private sealed class <>c__DisplayClass6_0
			{
				[Token(Token = "0x4000258")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public ValueSerializer <>4__this;

				[Token(Token = "0x4000259")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public IEmitter emitter;

				[Token(Token = "0x400025A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public List<IObjectGraphVisitor<Nothing>> preProcessingPhaseObjectGraphVisitors;

				[Token(Token = "0x400025B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public ObjectSerializer nestedObjectSerializer;

				[Token(Token = "0x6000665")]
				[Address(RVA = "0x14A2AF8", Offset = "0x14A2AF8", VA = "0x14A2AF8")]
				public <>c__DisplayClass6_0()
				{
				}

				[Token(Token = "0x6000666")]
				[Address(RVA = "0x14A2B00", Offset = "0x14A2B00", VA = "0x14A2B00")]
				internal void <SerializeValue>b__0(object v, Type t)
				{
				}

				[Token(Token = "0x6000667")]
				[Address(RVA = "0x14A2B4C", Offset = "0x14A2B4C", VA = "0x14A2B4C")]
				internal EmissionPhaseObjectGraphVisitorArgs <SerializeValue>b__1(IObjectGraphVisitor<IEmitter> inner)
				{
					return null;
				}
			}

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IObjectGraphTraversalStrategy traversalStrategy;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly IEventEmitter eventEmitter;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly IEnumerable<IYamlTypeConverter> typeConverters;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly LazyComponentRegistrationList<IEnumerable<IYamlTypeConverter>, IObjectGraphVisitor<Nothing>> preProcessingPhaseObjectGraphVisitorFactories;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private readonly LazyComponentRegistrationList<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>> emissionPhaseObjectGraphVisitorFactories;

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xCFAD48", Offset = "0xCFAD48", VA = "0xCFAD48")]
			public ValueSerializer(IObjectGraphTraversalStrategy traversalStrategy, IEventEmitter eventEmitter, IEnumerable<IYamlTypeConverter> typeConverters, LazyComponentRegistrationList<IEnumerable<IYamlTypeConverter>, IObjectGraphVisitor<Nothing>> preProcessingPhaseObjectGraphVisitorFactories, LazyComponentRegistrationList<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>> emissionPhaseObjectGraphVisitorFactories)
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0xCFB85C", Offset = "0xCFB85C", VA = "0xCFB85C", Slot = "4")]
			public void SerializeValue(IEmitter emitter, object value, Type type)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673BD8", Offset = "0x673BD8")]
		private sealed class <>c
		{
			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ITypeInspector, ITypeInspector> <>9__5_0;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<ITypeInspector, ITypeInspector> <>9__5_2;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IEnumerable<IYamlTypeConverter>, IObjectGraphVisitor<Nothing>> <>9__5_4;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>> <>9__5_5;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>> <>9__5_6;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>> <>9__5_7;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<IEventEmitter, IEventEmitter> <>9__5_8;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<ITypeInspector, ITypeResolver, IEnumerable<IYamlTypeConverter>, IObjectGraphTraversalStrategy> <>9__15_0;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<IEventEmitter, TypeAssigningEventEmitter> <>9__15_1;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Action<IRegistrationLocationSelectionSyntax<IEventEmitter>> <>9__15_2;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<ITypeInspector, ReadableAndWritablePropertiesTypeInspector> <>9__15_3;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Action<IRegistrationLocationSelectionSyntax<ITypeInspector>> <>9__15_4;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static Action<IRegistrationLocationSelectionSyntax<IYamlTypeConverter>> <>9__18_0;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static Func<IEventEmitter, JsonEventEmitter> <>9__18_1;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static Action<IRegistrationLocationSelectionSyntax<IEventEmitter>> <>9__18_2;

			[Token(Token = "0x600054A")]
			[Address(RVA = "0xCFB024", Offset = "0xCFB024", VA = "0xCFB024")]
			public <>c()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xCFB02C", Offset = "0xCFB02C", VA = "0xCFB02C")]
			internal ITypeInspector <.ctor>b__5_0(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0xCFB090", Offset = "0xCFB090", VA = "0xCFB090")]
			internal ITypeInspector <.ctor>b__5_2(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0xCFB0F4", Offset = "0xCFB0F4", VA = "0xCFB0F4")]
			internal IObjectGraphVisitor<Nothing> <.ctor>b__5_4(IEnumerable<IYamlTypeConverter> typeConverters)
			{
				return null;
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0xCFB154", Offset = "0xCFB154", VA = "0xCFB154")]
			internal IObjectGraphVisitor<IEmitter> <.ctor>b__5_5(EmissionPhaseObjectGraphVisitorArgs args)
			{
				return null;
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0xCFB200", Offset = "0xCFB200", VA = "0xCFB200")]
			internal IObjectGraphVisitor<IEmitter> <.ctor>b__5_6(EmissionPhaseObjectGraphVisitorArgs args)
			{
				return null;
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0xCFB2C0", Offset = "0xCFB2C0", VA = "0xCFB2C0")]
			internal IObjectGraphVisitor<IEmitter> <.ctor>b__5_7(EmissionPhaseObjectGraphVisitorArgs args)
			{
				return null;
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0xCFB334", Offset = "0xCFB334", VA = "0xCFB334")]
			internal IEventEmitter <.ctor>b__5_8(IEventEmitter inner)
			{
				return null;
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0xCFB398", Offset = "0xCFB398", VA = "0xCFB398")]
			internal IObjectGraphTraversalStrategy <EnsureRoundtrip>b__15_0(ITypeInspector typeInspector, ITypeResolver typeResolver, IEnumerable<IYamlTypeConverter> typeConverters)
			{
				return null;
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0xCFB418", Offset = "0xCFB418", VA = "0xCFB418")]
			internal TypeAssigningEventEmitter <EnsureRoundtrip>b__15_1(IEventEmitter inner)
			{
				return null;
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0xCFB480", Offset = "0xCFB480", VA = "0xCFB480")]
			internal void <EnsureRoundtrip>b__15_2(IRegistrationLocationSelectionSyntax<IEventEmitter> loc)
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0xCFB54C", Offset = "0xCFB54C", VA = "0xCFB54C")]
			internal ReadableAndWritablePropertiesTypeInspector <EnsureRoundtrip>b__15_3(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0xCFB5B0", Offset = "0xCFB5B0", VA = "0xCFB5B0")]
			internal void <EnsureRoundtrip>b__15_4(IRegistrationLocationSelectionSyntax<ITypeInspector> loc)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0xCFB664", Offset = "0xCFB664", VA = "0xCFB664")]
			internal void <JsonCompatible>b__18_0(IRegistrationLocationSelectionSyntax<IYamlTypeConverter> w)
			{
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0xCFB730", Offset = "0xCFB730", VA = "0xCFB730")]
			internal JsonEventEmitter <JsonCompatible>b__18_1(IEventEmitter inner)
			{
				return null;
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xCFB790", Offset = "0xCFB790", VA = "0xCFB790")]
			internal void <JsonCompatible>b__18_2(IRegistrationLocationSelectionSyntax<IEventEmitter> loc)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673BE8", Offset = "0x673BE8")]
		private sealed class <>c__8<TEventEmitter> where TEventEmitter : IEventEmitter
		{
			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__8<TEventEmitter> <>9;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<IRegistrationLocationSelectionSyntax<IEventEmitter>> <>9__8_0;

			[Token(Token = "0x600055B")]
			public <>c__8()
			{
			}

			[Token(Token = "0x600055C")]
			internal void <WithEventEmitter>b__8_0(IRegistrationLocationSelectionSyntax<IEventEmitter> w)
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673BF8", Offset = "0x673BF8")]
		private sealed class <>c__DisplayClass9_0<TEventEmitter> where TEventEmitter : IEventEmitter
		{
			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<IEventEmitter, TEventEmitter> eventEmitterFactory;

			[Token(Token = "0x600055D")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600055E")]
			internal IEventEmitter <WithEventEmitter>b__0(IEventEmitter inner)
			{
				return null;
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C08", Offset = "0x673C08")]
		private sealed class <>c__DisplayClass10_0<TEventEmitter> where TEventEmitter : IEventEmitter
		{
			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WrapperFactory<IEventEmitter, IEventEmitter, TEventEmitter> eventEmitterFactory;

			[Token(Token = "0x600055F")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000560")]
			internal IEventEmitter <WithEventEmitter>b__0(IEventEmitter wrapped, IEventEmitter inner)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C18", Offset = "0x673C18")]
		private sealed class <>c__19<TObjectGraphVisitor> where TObjectGraphVisitor : IObjectGraphVisitor<Nothing>
		{
			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__19<TObjectGraphVisitor> <>9;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<IRegistrationLocationSelectionSyntax<IObjectGraphVisitor<Nothing>>> <>9__19_0;

			[Token(Token = "0x6000562")]
			public <>c__19()
			{
			}

			[Token(Token = "0x6000563")]
			internal void <WithPreProcessingPhaseObjectGraphVisitor>b__19_0(IRegistrationLocationSelectionSyntax<IObjectGraphVisitor<Nothing>> w)
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C28", Offset = "0x673C28")]
		private sealed class <>c__DisplayClass20_0<TObjectGraphVisitor> where TObjectGraphVisitor : IObjectGraphVisitor<Nothing>
		{
			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TObjectGraphVisitor objectGraphVisitor;

			[Token(Token = "0x6000564")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000565")]
			internal IObjectGraphVisitor<Nothing> <WithPreProcessingPhaseObjectGraphVisitor>b__0(IEnumerable<IYamlTypeConverter> _)
			{
				return null;
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C38", Offset = "0x673C38")]
		private sealed class <>c__DisplayClass21_0<TObjectGraphVisitor> where TObjectGraphVisitor : IObjectGraphVisitor<Nothing>
		{
			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WrapperFactory<IObjectGraphVisitor<Nothing>, TObjectGraphVisitor> objectGraphVisitorFactory;

			[Token(Token = "0x6000566")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000567")]
			internal IObjectGraphVisitor<Nothing> <WithPreProcessingPhaseObjectGraphVisitor>b__0(IObjectGraphVisitor<Nothing> wrapped, IEnumerable<IYamlTypeConverter> _)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C48", Offset = "0x673C48")]
		private sealed class <>c__24<TObjectGraphVisitor> where TObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
		{
			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__24<TObjectGraphVisitor> <>9;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<IRegistrationLocationSelectionSyntax<IObjectGraphVisitor<IEmitter>>> <>9__24_0;

			[Token(Token = "0x6000569")]
			public <>c__24()
			{
			}

			[Token(Token = "0x600056A")]
			internal void <WithEmissionPhaseObjectGraphVisitor>b__24_0(IRegistrationLocationSelectionSyntax<IObjectGraphVisitor<IEmitter>> w)
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C58", Offset = "0x673C58")]
		private sealed class <>c__DisplayClass25_0<TObjectGraphVisitor> where TObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
		{
			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<EmissionPhaseObjectGraphVisitorArgs, TObjectGraphVisitor> objectGraphVisitorFactory;

			[Token(Token = "0x600056B")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600056C")]
			internal IObjectGraphVisitor<IEmitter> <WithEmissionPhaseObjectGraphVisitor>b__0(EmissionPhaseObjectGraphVisitorArgs args)
			{
				return null;
			}
		}

		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C68", Offset = "0x673C68")]
		private sealed class <>c__DisplayClass26_0<TObjectGraphVisitor> where TObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
		{
			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WrapperFactory<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>, TObjectGraphVisitor> objectGraphVisitorFactory;

			[Token(Token = "0x600056D")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600056E")]
			internal IObjectGraphVisitor<IEmitter> <WithEmissionPhaseObjectGraphVisitor>b__0(IObjectGraphVisitor<IEmitter> wrapped, EmissionPhaseObjectGraphVisitorArgs args)
			{
				return null;
			}
		}

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Func<ITypeInspector, ITypeResolver, IEnumerable<IYamlTypeConverter>, IObjectGraphTraversalStrategy> objectGraphTraversalStrategyFactory;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly LazyComponentRegistrationList<IEnumerable<IYamlTypeConverter>, IObjectGraphVisitor<Nothing>> preProcessingPhaseObjectGraphVisitorFactories;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly LazyComponentRegistrationList<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>> emissionPhaseObjectGraphVisitorFactories;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly LazyComponentRegistrationList<IEventEmitter, IEventEmitter> eventEmitterFactories;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly IDictionary<Type, string> tagMappings;

		[Token(Token = "0x1700002B")]
		protected override SerializerBuilder Self
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xCF9FD4", Offset = "0xCF9FD4", VA = "0xCF9FD4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xCE530C", Offset = "0xCE530C", VA = "0xCE530C")]
		public SerializerBuilder()
		{
		}

		[Token(Token = "0x60000FC")]
		public SerializerBuilder WithEventEmitter<TEventEmitter>(Func<IEventEmitter, TEventEmitter> eventEmitterFactory) where TEventEmitter : IEventEmitter
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		public SerializerBuilder WithEventEmitter<TEventEmitter>(Func<IEventEmitter, TEventEmitter> eventEmitterFactory, Action<IRegistrationLocationSelectionSyntax<IEventEmitter>> where) where TEventEmitter : IEventEmitter
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		public SerializerBuilder WithEventEmitter<TEventEmitter>(WrapperFactory<IEventEmitter, IEventEmitter, TEventEmitter> eventEmitterFactory, Action<ITrackingRegistrationLocationSelectionSyntax<IEventEmitter>> where) where TEventEmitter : IEventEmitter
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		public SerializerBuilder WithoutEventEmitter<TEventEmitter>() where TEventEmitter : IEventEmitter
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xCF9FD8", Offset = "0xCF9FD8", VA = "0xCF9FD8")]
		public SerializerBuilder WithoutEventEmitter(Type eventEmitterType)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xCFA0C8", Offset = "0xCFA0C8", VA = "0xCFA0C8")]
		public SerializerBuilder WithTagMapping(string tag, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xCFA34C", Offset = "0xCFA34C", VA = "0xCFA34C")]
		public SerializerBuilder WithoutTagMapping(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xCFA50C", Offset = "0xCFA50C", VA = "0xCFA50C")]
		public SerializerBuilder EnsureRoundtrip()
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xCFA850", Offset = "0xCFA850", VA = "0xCFA850")]
		public SerializerBuilder DisableAliases()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xCFA940", Offset = "0xCFA940", VA = "0xCFA940")]
		public SerializerBuilder EmitDefaults()
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xCE5C50", Offset = "0xCE5C50", VA = "0xCE5C50")]
		public SerializerBuilder JsonCompatible()
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		public SerializerBuilder WithPreProcessingPhaseObjectGraphVisitor<TObjectGraphVisitor>(TObjectGraphVisitor objectGraphVisitor) where TObjectGraphVisitor : IObjectGraphVisitor<Nothing>
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		public SerializerBuilder WithPreProcessingPhaseObjectGraphVisitor<TObjectGraphVisitor>(TObjectGraphVisitor objectGraphVisitor, Action<IRegistrationLocationSelectionSyntax<IObjectGraphVisitor<Nothing>>> where) where TObjectGraphVisitor : IObjectGraphVisitor<Nothing>
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		public SerializerBuilder WithPreProcessingPhaseObjectGraphVisitor<TObjectGraphVisitor>(WrapperFactory<IObjectGraphVisitor<Nothing>, TObjectGraphVisitor> objectGraphVisitorFactory, Action<ITrackingRegistrationLocationSelectionSyntax<IObjectGraphVisitor<Nothing>>> where) where TObjectGraphVisitor : IObjectGraphVisitor<Nothing>
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		public SerializerBuilder WithoutPreProcessingPhaseObjectGraphVisitor<TObjectGraphVisitor>() where TObjectGraphVisitor : IObjectGraphVisitor<Nothing>
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xCFA9F0", Offset = "0xCFA9F0", VA = "0xCFA9F0")]
		public SerializerBuilder WithoutPreProcessingPhaseObjectGraphVisitor(Type objectGraphVisitorType)
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		public SerializerBuilder WithEmissionPhaseObjectGraphVisitor<TObjectGraphVisitor>(Func<EmissionPhaseObjectGraphVisitorArgs, TObjectGraphVisitor> objectGraphVisitorFactory) where TObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		public SerializerBuilder WithEmissionPhaseObjectGraphVisitor<TObjectGraphVisitor>(Func<EmissionPhaseObjectGraphVisitorArgs, TObjectGraphVisitor> objectGraphVisitorFactory, Action<IRegistrationLocationSelectionSyntax<IObjectGraphVisitor<IEmitter>>> where) where TObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		public SerializerBuilder WithEmissionPhaseObjectGraphVisitor<TObjectGraphVisitor>(WrapperFactory<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>, TObjectGraphVisitor> objectGraphVisitorFactory, Action<ITrackingRegistrationLocationSelectionSyntax<IObjectGraphVisitor<IEmitter>>> where) where TObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		public SerializerBuilder WithoutEmissionPhaseObjectGraphVisitor<TObjectGraphVisitor>() where TObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xCFAAE0", Offset = "0xCFAAE0", VA = "0xCFAAE0")]
		public SerializerBuilder WithoutEmissionPhaseObjectGraphVisitor(Type objectGraphVisitorType)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xCE5ED0", Offset = "0xCE5ED0", VA = "0xCE5ED0")]
		public Serializer Build()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xCFABD0", Offset = "0xCFABD0", VA = "0xCFABD0")]
		public IValueSerializer BuildValueSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xCFAD9C", Offset = "0xCFAD9C", VA = "0xCFAD9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B1C", Offset = "0x674B1C")]
		private ITypeInspector <.ctor>b__5_1(ITypeInspector inner)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xCFAE1C", Offset = "0xCFAE1C", VA = "0xCFAE1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B2C", Offset = "0x674B2C")]
		private ITypeInspector <.ctor>b__5_3(ITypeInspector inner)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xCFAEAC", Offset = "0xCFAEAC", VA = "0xCFAEAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B3C", Offset = "0x674B3C")]
		private IObjectGraphTraversalStrategy <.ctor>b__5_9(ITypeInspector typeInspector, ITypeResolver typeResolver, IEnumerable<IYamlTypeConverter> typeConverters)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xCFAF4C", Offset = "0xCFAF4C", VA = "0xCFAF4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B4C", Offset = "0x674B4C")]
		private CustomTagEventEmitter <.ctor>b__5_10(IEventEmitter inner)
		{
			return null;
		}
	}
	[Token(Token = "0x2000032")]
	public sealed class StreamFragment : IYamlConvertible
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<ParsingEvent> events;

		[Token(Token = "0x1700002C")]
		public IList<ParsingEvent> Events
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x14A2C04", Offset = "0x14A2C04", VA = "0x14A2C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x14A2C0C", Offset = "0x14A2C0C", VA = "0x14A2C0C", Slot = "4")]
		private void YamlDotNet.Serialization.IYamlConvertible.Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x14A2E7C", Offset = "0x14A2E7C", VA = "0x14A2E7C", Slot = "5")]
		private void YamlDotNet.Serialization.IYamlConvertible.Write(IEmitter emitter, ObjectSerializer nestedObjectSerializer)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x14A3010", Offset = "0x14A3010", VA = "0x14A3010")]
		public StreamFragment()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public sealed class TagMappings
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, Type> mappings;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x14A3080", Offset = "0x14A3080", VA = "0x14A3080")]
		public TagMappings()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x14A30F4", Offset = "0x14A30F4", VA = "0x14A30F4")]
		public TagMappings(IDictionary<string, Type> mappings)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x14A3178", Offset = "0x14A3178", VA = "0x14A3178")]
		public void Add(string tag, Type mapping)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x14A3248", Offset = "0x14A3248", VA = "0x14A3248")]
		internal Type GetMapping(string tag)
		{
			return null;
		}
	}
	[Token(Token = "0x2000034")]
	public sealed class YamlAttributeOverrides
	{
		[Token(Token = "0x20000F7")]
		private struct AttributeKey
		{
			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly Type AttributeType;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly string PropertyName;

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x700DF4", Offset = "0x700DF4", VA = "0x700DF4")]
			public AttributeKey(Type attributeType, string propertyName)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x700DFC", Offset = "0x700DFC", VA = "0x700DFC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x700E04", Offset = "0x700E04", VA = "0x700E04", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000F8")]
		private sealed class AttributeMapping
		{
			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly Type RegisteredType;

			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly Attribute Attribute;

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x14A8E28", Offset = "0x14A8E28", VA = "0x14A8E28")]
			public AttributeMapping(Type registeredType, Attribute attribute)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x14A9348", Offset = "0x14A9348", VA = "0x14A9348", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x14A9428", Offset = "0x14A9428", VA = "0x14A9428", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x14A9494", Offset = "0x14A9494", VA = "0x14A9494")]
			public int Matches(Type matchType)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<AttributeKey, List<AttributeMapping>> overrides;

		[Token(Token = "0x600011F")]
		public T GetAttribute<T>(Type type, string member) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x14A8BF0", Offset = "0x14A8BF0", VA = "0x14A8BF0")]
		public void Add(Type type, string member, Attribute attribute)
		{
		}

		[Token(Token = "0x6000121")]
		public void Add<TClass>(Expression<Func<TClass, object>> propertyAccessor, Attribute attribute)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x14A8E68", Offset = "0x14A8E68", VA = "0x14A8E68")]
		public YamlAttributeOverrides Clone()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x14A91AC", Offset = "0x14A91AC", VA = "0x14A91AC")]
		public YamlAttributeOverrides()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public sealed class YamlAttributeOverridesInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x20000F9")]
		public sealed class OverridePropertyDescriptor : IPropertyDescriptor
		{
			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IPropertyDescriptor baseDescriptor;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly YamlAttributeOverrides overrides;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly Type classType;

			[Token(Token = "0x170000CB")]
			public string Name
			{
				[Token(Token = "0x6000577")]
				[Address(RVA = "0x14A9880", Offset = "0x14A9880", VA = "0x14A9880", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			public bool CanWrite
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0x14A9934", Offset = "0x14A9934", VA = "0x14A9934", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CD")]
			public Type Type
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0x14A99EC", Offset = "0x14A99EC", VA = "0x14A99EC", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public Type TypeOverride
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0x14A9AA4", Offset = "0x14A9AA4", VA = "0x14A9AA4", Slot = "7")]
				get
				{
					return null;
				}
				[Token(Token = "0x600057B")]
				[Address(RVA = "0x14A9B5C", Offset = "0x14A9B5C", VA = "0x14A9B5C", Slot = "8")]
				set
				{
				}
			}

			[Token(Token = "0x170000CF")]
			public int Order
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0x14A9C24", Offset = "0x14A9C24", VA = "0x14A9C24", Slot = "9")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600057D")]
				[Address(RVA = "0x14A9CDC", Offset = "0x14A9CDC", VA = "0x14A9CDC", Slot = "10")]
				set
				{
				}
			}

			[Token(Token = "0x170000D0")]
			public ScalarStyle ScalarStyle
			{
				[Token(Token = "0x600057E")]
				[Address(RVA = "0x14A9DA4", Offset = "0x14A9DA4", VA = "0x14A9DA4", Slot = "11")]
				get
				{
					return default(ScalarStyle);
				}
				[Token(Token = "0x600057F")]
				[Address(RVA = "0x14A9E5C", Offset = "0x14A9E5C", VA = "0x14A9E5C", Slot = "12")]
				set
				{
				}
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x14A9840", Offset = "0x14A9840", VA = "0x14A9840")]
			public OverridePropertyDescriptor(IPropertyDescriptor baseDescriptor, YamlAttributeOverrides overrides, Type classType)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x14A9F24", Offset = "0x14A9F24", VA = "0x14A9F24", Slot = "15")]
			public void Write(object target, object value)
			{
			}

			[Token(Token = "0x6000581")]
			public T GetCustomAttribute<T>() where T : Attribute
			{
				return null;
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x14A9FF4", Offset = "0x14A9FF4", VA = "0x14A9FF4", Slot = "14")]
			public IObjectDescriptor Read(object target)
			{
				return null;
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C78", Offset = "0x673C78")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public YamlAttributeOverridesInspector <>4__this;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type type;

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x14A97AC", Offset = "0x14A97AC", VA = "0x14A97AC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x14A97B4", Offset = "0x14A97B4", VA = "0x14A97B4")]
			internal IPropertyDescriptor <GetProperties>b__0(IPropertyDescriptor p)
			{
				return null;
			}
		}

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly YamlAttributeOverrides overrides;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x14A95D8", Offset = "0x14A95D8", VA = "0x14A95D8")]
		public YamlAttributeOverridesInspector(ITypeInspector innerTypeDescriptor, YamlAttributeOverrides overrides)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x14A9610", Offset = "0x14A9610", VA = "0x14A9610", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}
	}
	[Token(Token = "0x2000036")]
	public sealed class YamlAttributesTypeInspector : TypeInspectorSkeleton
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C88", Offset = "0x673C88")]
		private sealed class <>c
		{
			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IPropertyDescriptor, bool> <>9__2_0;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<IPropertyDescriptor, IPropertyDescriptor> <>9__2_1;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IPropertyDescriptor, int> <>9__2_2;

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x14AA424", Offset = "0x14AA424", VA = "0x14AA424")]
			public <>c()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x14AA42C", Offset = "0x14AA42C", VA = "0x14AA42C")]
			internal bool <GetProperties>b__2_0(IPropertyDescriptor p)
			{
				return default(bool);
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x14AA504", Offset = "0x14AA504", VA = "0x14AA504")]
			internal IPropertyDescriptor <GetProperties>b__2_1(IPropertyDescriptor p)
			{
				return null;
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x14AA6F8", Offset = "0x14AA6F8", VA = "0x14AA6F8")]
			internal int <GetProperties>b__2_2(IPropertyDescriptor p)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x14AA0BC", Offset = "0x14AA0BC", VA = "0x14AA0BC")]
		public YamlAttributesTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x14AA0E8", Offset = "0x14AA0E8", VA = "0x14AA0E8", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}
	}
	[Token(Token = "0x2000037")]
	internal static class YamlFormatter
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NumberFormatInfo NumberFormat;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x14AA7AC", Offset = "0x14AA7AC", VA = "0x14AA7AC")]
		public static string FormatNumber(object number)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x14AA848", Offset = "0x14AA848", VA = "0x14AA848")]
		public static string FormatNumber(double number)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x14AA8CC", Offset = "0x14AA8CC", VA = "0x14AA8CC")]
		public static string FormatNumber(float number)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x14AA950", Offset = "0x14AA950", VA = "0x14AA950")]
		public static string FormatBoolean(object boolean)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x14AA9F4", Offset = "0x14AA9F4", VA = "0x14AA9F4")]
		public static string FormatDateTime(object dateTime)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x14AAAA0", Offset = "0x14AAAA0", VA = "0x14AAAA0")]
		public static string FormatTimeSpan(object timeSpan)
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x673840", Offset = "0x673840")]
	public sealed class YamlIgnoreAttribute : Attribute
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x14AAE20", Offset = "0x14AAE20", VA = "0x14AAE20")]
		public YamlIgnoreAttribute()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x67387C", Offset = "0x67387C")]
	public sealed class YamlMemberAttribute : Attribute
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674020", Offset = "0x674020")]
		private Type <SerializeAs>k__BackingField;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674030", Offset = "0x674030")]
		private int <Order>k__BackingField;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674040", Offset = "0x674040")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674050", Offset = "0x674050")]
		private bool <ApplyNamingConventions>k__BackingField;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674060", Offset = "0x674060")]
		private ScalarStyle <ScalarStyle>k__BackingField;

		[Token(Token = "0x1700002D")]
		public Type SerializeAs
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x14AA6D8", Offset = "0x14AA6D8", VA = "0x14AA6D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B5C", Offset = "0x674B5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x14AAE28", Offset = "0x14AAE28", VA = "0x14AAE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B6C", Offset = "0x674B6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public int Order
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x14AA6E0", Offset = "0x14AA6E0", VA = "0x14AA6E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B7C", Offset = "0x674B7C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x14AAE30", Offset = "0x14AAE30", VA = "0x14AAE30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B8C", Offset = "0x674B8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public string Alias
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x14AA6F0", Offset = "0x14AA6F0", VA = "0x14AA6F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B9C", Offset = "0x674B9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x14AAE38", Offset = "0x14AAE38", VA = "0x14AAE38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674BAC", Offset = "0x674BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool ApplyNamingConventions
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x14A395C", Offset = "0x14A395C", VA = "0x14A395C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674BBC", Offset = "0x674BBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x14AAE40", Offset = "0x14AAE40", VA = "0x14AAE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674BCC", Offset = "0x674BCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x14AA6E8", Offset = "0x14AA6E8", VA = "0x14AA6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674BDC", Offset = "0x674BDC")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x14AAE4C", Offset = "0x14AAE4C", VA = "0x14AAE4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674BEC", Offset = "0x674BEC")]
			set
			{
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x14AAE54", Offset = "0x14AAE54", VA = "0x14AAE54")]
		public YamlMemberAttribute()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x14AAE84", Offset = "0x14AAE84", VA = "0x14AAE84")]
		public YamlMemberAttribute(Type serializeAs)
		{
		}
	}
}
namespace YamlDotNet.Serialization.ValueDeserializers
{
	[Token(Token = "0x200003A")]
	public sealed class AliasValueDeserializer : IValueDeserializer
	{
		[Token(Token = "0x20000FC")]
		private sealed class AliasState : Dictionary<string, ValuePromise>, IPostDeserializationCallback
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x14A7C88", Offset = "0x14A7C88", VA = "0x14A7C88", Slot = "34")]
			public void OnDeserialization()
			{
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x14A7EA4", Offset = "0x14A7EA4", VA = "0x14A7EA4")]
			public AliasState()
			{
			}
		}

		[Token(Token = "0x20000FD")]
		private sealed class ValuePromise : IValuePromise
		{
			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743C0", Offset = "0x6743C0")]
			private bool <HasValue>k__BackingField;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object value;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public readonly YamlDotNet.Core.Events.AnchorAlias Alias;

			[Token(Token = "0x170000D1")]
			public bool HasValue
			{
				[Token(Token = "0x600058E")]
				[Address(RVA = "0x14A7AF0", Offset = "0x14A7AF0", VA = "0x14A7AF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6757A0", Offset = "0x6757A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600058F")]
				[Address(RVA = "0x14A80CC", Offset = "0x14A80CC", VA = "0x14A80CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6757B0", Offset = "0x6757B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			public object Value
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0x14A7AF8", Offset = "0x14A7AF8", VA = "0x14A7AF8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x14A7BBC", Offset = "0x14A7BBC", VA = "0x14A7BBC")]
				set
				{
				}
			}

			[Token(Token = "0x14000002")]
			public event Action<object> ValueAvailable
			{
				[Token(Token = "0x600058C")]
				[Address(RVA = "0x14A7EF4", Offset = "0x14A7EF4", VA = "0x14A7EF4", Slot = "4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675780", Offset = "0x675780")]
				add
				{
				}
				[Token(Token = "0x600058D")]
				[Address(RVA = "0x14A7FE0", Offset = "0x14A7FE0", VA = "0x14A7FE0", Slot = "5")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675790", Offset = "0x675790")]
				remove
				{
				}
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x14A7AC4", Offset = "0x14A7AC4", VA = "0x14A7AC4")]
			public ValuePromise(YamlDotNet.Core.Events.AnchorAlias alias)
			{
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x14A7B88", Offset = "0x14A7B88", VA = "0x14A7B88")]
			public ValuePromise(object value)
			{
			}
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IValueDeserializer innerDeserializer;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x14A7680", Offset = "0x14A7680", VA = "0x14A7680")]
		public AliasValueDeserializer(IValueDeserializer innerDeserializer)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x14A7724", Offset = "0x14A7724", VA = "0x14A7724", Slot = "4")]
		public object DeserializeValue(IParser parser, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer)
		{
			return null;
		}
	}
	[Token(Token = "0x200003B")]
	public sealed class NodeValueDeserializer : IValueDeserializer
	{
		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673C98", Offset = "0x673C98")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IValueDeserializer nestedObjectDeserializer;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SerializerState state;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<IParser, Type, object> <>9__0;

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x14A87DC", Offset = "0x14A87DC", VA = "0x14A87DC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x14A8B18", Offset = "0x14A8B18", VA = "0x14A8B18")]
			internal object <DeserializeValue>b__0(IParser r, Type t)
			{
				return null;
			}
		}

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IList<INodeDeserializer> deserializers;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IList<INodeTypeResolver> typeResolvers;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x14A80D8", Offset = "0x14A80D8", VA = "0x14A80D8")]
		public NodeValueDeserializer(IList<INodeDeserializer> deserializers, IList<INodeTypeResolver> typeResolvers)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x14A81A4", Offset = "0x14A81A4", VA = "0x14A81A4", Slot = "4")]
		public object DeserializeValue(IParser parser, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x14A87E4", Offset = "0x14A87E4", VA = "0x14A87E4")]
		private Type GetTypeFromEvent(NodeEvent nodeEvent, Type currentType)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.Utilities
{
	[Token(Token = "0x200003C")]
	public interface IPostDeserializationCallback
	{
		[Token(Token = "0x6000141")]
		void OnDeserialization();
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6738B8", Offset = "0x6738B8")]
	internal sealed class ObjectAnchorCollection
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, object> objectsByAnchor;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IDictionary<object, string> anchorsByObject;

		[Token(Token = "0x17000032")]
		public object Item
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x14A4CB4", Offset = "0x14A4CB4", VA = "0x14A4CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x14A4A7C", Offset = "0x14A4A7C", VA = "0x14A4A7C")]
		public void Add(string anchor, object @object)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x14A4BE4", Offset = "0x14A4BE4", VA = "0x14A4BE4")]
		public bool TryGetAnchor(object @object, out string anchor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x14A4E14", Offset = "0x14A4E14", VA = "0x14A4E14")]
		public ObjectAnchorCollection()
		{
		}
	}
	[Token(Token = "0x200003E")]
	internal static class ReflectionUtility
	{
		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673CA8", Offset = "0x673CA8")]
		private sealed class <GetImplementedInterfaces>d__1 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Type <>2__current;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Type type;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Type <>3__type;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Type[] <>7__wrap1;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;

			[Token(Token = "0x170000D3")]
			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Token(Token = "0x6000599")]
				[Address(RVA = "0x14A5488", Offset = "0x14A5488", VA = "0x14A5488", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600059B")]
				[Address(RVA = "0x14A54F8", Offset = "0x14A54F8", VA = "0x14A54F8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x14A52AC", Offset = "0x14A52AC", VA = "0x14A52AC")]
			[DebuggerHidden]
			public <GetImplementedInterfaces>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x14A52E4", Offset = "0x14A52E4", VA = "0x14A52E4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x14A52E8", Offset = "0x14A52E8", VA = "0x14A52E8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x14A5490", Offset = "0x14A5490", VA = "0x14A5490", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x14A5500", Offset = "0x14A5500", VA = "0x14A5500", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x14A55B0", Offset = "0x14A55B0", VA = "0x14A55B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x14A4EAC", Offset = "0x14A4EAC", VA = "0x14A4EAC")]
		public static Type GetImplementedGenericInterface(Type type, Type genericInterfaceType)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x14A5228", Offset = "0x14A5228", VA = "0x14A5228")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x674BFC", Offset = "0x674BFC")]
		public static IEnumerable<Type> GetImplementedInterfaces(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	public sealed class SerializerState : IDisposable
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<Type, object> items;

		[Token(Token = "0x6000148")]
		public T Get<T>() where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x14A55B4", Offset = "0x14A55B4", VA = "0x14A55B4")]
		public void OnDeserialization()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x14A593C", Offset = "0x14A593C", VA = "0x14A593C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x14A5CBC", Offset = "0x14A5CBC", VA = "0x14A5CBC")]
		public SerializerState()
		{
		}
	}
	[Token(Token = "0x2000040")]
	internal static class StringExtensions
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673CB8", Offset = "0x673CB8")]
		private sealed class <>c
		{
			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static MatchEvaluator <>9__0_0;

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x14A61C0", Offset = "0x14A61C0", VA = "0x14A61C0")]
			public <>c()
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x14A61C8", Offset = "0x14A61C8", VA = "0x14A61C8")]
			internal string <ToCamelOrPascalCase>b__0_0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673CC8", Offset = "0x673CC8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string separator;

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x14A6154", Offset = "0x14A6154", VA = "0x14A6154")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x14A6274", Offset = "0x14A6274", VA = "0x14A6274")]
			internal string <FromCamelCase>b__0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x14A5D2C", Offset = "0x14A5D2C", VA = "0x14A5D2C")]
		private static string ToCamelOrPascalCase(string str, Func<char, char> firstLetterTransform)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x14A5EDC", Offset = "0x14A5EDC", VA = "0x14A5EDC")]
		public static string ToCamelCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x14A5F58", Offset = "0x14A5F58", VA = "0x14A5F58")]
		public static string ToPascalCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x14A5FD4", Offset = "0x14A5FD4", VA = "0x14A5FD4")]
		public static string FromCamelCase(this string str, string separator)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public static class TypeConverter
	{
		[Token(Token = "0x6000150")]
		public static T ChangeType<T>(object value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000151")]
		public static T ChangeType<T>(object value, IFormatProvider provider)
		{
			return (T)null;
		}

		[Token(Token = "0x6000152")]
		public static T ChangeType<T>(object value, CultureInfo culture)
		{
			return (T)null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x14A6340", Offset = "0x14A6340", VA = "0x14A6340")]
		public static object ChangeType(object value, Type destinationType)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x14A75C8", Offset = "0x14A75C8", VA = "0x14A75C8")]
		public static object ChangeType(object value, Type destinationType, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x14A63C0", Offset = "0x14A63C0", VA = "0x14A63C0")]
		public static object ChangeType(object value, Type destinationType, CultureInfo culture)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.TypeResolvers
{
	[Token(Token = "0x2000042")]
	public sealed class DynamicTypeResolver : ITypeResolver
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x14A4A4C", Offset = "0x14A4A4C", VA = "0x14A4A4C", Slot = "4")]
		public Type Resolve(Type staticType, object actualValue)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x14A4A64", Offset = "0x14A4A64", VA = "0x14A4A64")]
		public DynamicTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public sealed class StaticTypeResolver : ITypeResolver
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x14A4A6C", Offset = "0x14A4A6C", VA = "0x14A4A6C", Slot = "4")]
		public Type Resolve(Type staticType, object actualValue)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x14A4A74", Offset = "0x14A4A74", VA = "0x14A4A74")]
		public StaticTypeResolver()
		{
		}
	}
}
namespace YamlDotNet.Serialization.TypeInspectors
{
	[Token(Token = "0x2000044")]
	public sealed class CachedTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Type, List<IPropertyDescriptor>> cache;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x14A3328", Offset = "0x14A3328", VA = "0x14A3328")]
		public CachedTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x14A33FC", Offset = "0x14A33FC", VA = "0x14A33FC", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}
	}
	[Token(Token = "0x2000045")]
	public sealed class NamingConventionTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly INamingConvention namingConvention;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x14A3548", Offset = "0x14A3548", VA = "0x14A3548")]
		public NamingConventionTypeInspector(ITypeInspector innerTypeDescriptor, INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x14A3614", Offset = "0x14A3614", VA = "0x14A3614", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x14A3734", Offset = "0x14A3734", VA = "0x14A3734")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674C90", Offset = "0x674C90")]
		private IPropertyDescriptor <GetProperties>b__3_0(IPropertyDescriptor p)
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public sealed class ReadableAndWritablePropertiesTypeInspector : TypeInspectorSkeleton
	{
		[Serializable]
		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673CD8", Offset = "0x673CD8")]
		private sealed class <>c
		{
			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IPropertyDescriptor, bool> <>9__2_0;

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x14A3B74", Offset = "0x14A3B74", VA = "0x14A3B74")]
			public <>c()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x14A3B7C", Offset = "0x14A3B7C", VA = "0x14A3B7C")]
			internal bool <GetProperties>b__2_0(IPropertyDescriptor p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector _innerTypeDescriptor;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x14A3964", Offset = "0x14A3964", VA = "0x14A3964")]
		public ReadableAndWritablePropertiesTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x14A3990", Offset = "0x14A3990", VA = "0x14A3990", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}
	}
	[Token(Token = "0x2000047")]
	public sealed class ReadablePropertiesTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x2000103")]
		private sealed class ReflectionPropertyDescriptor : IPropertyDescriptor
		{
			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly PropertyInfo _propertyInfo;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly ITypeResolver _typeResolver;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743D0", Offset = "0x6743D0")]
			private Type <TypeOverride>k__BackingField;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743E0", Offset = "0x6743E0")]
			private int <Order>k__BackingField;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743F0", Offset = "0x6743F0")]
			private ScalarStyle <ScalarStyle>k__BackingField;

			[Token(Token = "0x170000D5")]
			public string Name
			{
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0x14A3F34", Offset = "0x14A3F34", VA = "0x14A3F34", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			public Type Type
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x14A3F68", Offset = "0x14A3F68", VA = "0x14A3F68", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			public Type TypeOverride
			{
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0x14A3FA0", Offset = "0x14A3FA0", VA = "0x14A3FA0", Slot = "7")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675830", Offset = "0x675830")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x14A3FA8", Offset = "0x14A3FA8", VA = "0x14A3FA8", Slot = "8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675840", Offset = "0x675840")]
				set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			public int Order
			{
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0x14A3FB0", Offset = "0x14A3FB0", VA = "0x14A3FB0", Slot = "9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675850", Offset = "0x675850")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0x14A3FB8", Offset = "0x14A3FB8", VA = "0x14A3FB8", Slot = "10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675860", Offset = "0x675860")]
				set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			public bool CanWrite
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x14A3FC0", Offset = "0x14A3FC0", VA = "0x14A3FC0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DA")]
			public ScalarStyle ScalarStyle
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0x14A3FF8", Offset = "0x14A3FF8", VA = "0x14A3FF8", Slot = "11")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675870", Offset = "0x675870")]
				get
				{
					return default(ScalarStyle);
				}
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x14A3F2C", Offset = "0x14A3F2C", VA = "0x14A3F2C", Slot = "12")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675880", Offset = "0x675880")]
				set
				{
				}
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x14A3EF0", Offset = "0x14A3EF0", VA = "0x14A3EF0")]
			public ReflectionPropertyDescriptor(PropertyInfo propertyInfo, ITypeResolver typeResolver)
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x14A4000", Offset = "0x14A4000", VA = "0x14A4000", Slot = "15")]
			public void Write(object target, object value)
			{
			}

			[Token(Token = "0x60005B1")]
			public T GetCustomAttribute<T>() where T : Attribute
			{
				return null;
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x14A4054", Offset = "0x14A4054", VA = "0x14A4054", Slot = "14")]
			public IObjectDescriptor Read(object target)
			{
				return null;
			}
		}

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeResolver _typeResolver;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x14A3C30", Offset = "0x14A3C30", VA = "0x14A3C30")]
		public ReadablePropertiesTypeInspector(ITypeResolver typeResolver)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x14A3CD4", Offset = "0x14A3CD4", VA = "0x14A3CD4")]
		private static bool IsValidProperty(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x14A3D5C", Offset = "0x14A3D5C", VA = "0x14A3D5C", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x14A3E78", Offset = "0x14A3E78", VA = "0x14A3E78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674CA0", Offset = "0x674CA0")]
		private IPropertyDescriptor <GetProperties>b__3_0(PropertyInfo p)
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	public abstract class TypeInspectorSkeleton : ITypeInspector
	{
		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673CE8", Offset = "0x673CE8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x14A4860", Offset = "0x14A4860", VA = "0x14A4860")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x14A4984", Offset = "0x14A4984", VA = "0x14A4984")]
			internal bool <GetProperty>b__0(IPropertyDescriptor p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673CF8", Offset = "0x673CF8")]
		private sealed class <>c
		{
			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IPropertyDescriptor, string> <>9__1_1;

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x14A48CC", Offset = "0x14A48CC", VA = "0x14A48CC")]
			public <>c()
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x14A48D4", Offset = "0x14A48D4", VA = "0x14A48D4")]
			internal string <GetProperty>b__1_1(IPropertyDescriptor p)
			{
				return null;
			}
		}

		[Token(Token = "0x6000165")]
		public abstract IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container);

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x14A41CC", Offset = "0x14A41CC", VA = "0x14A41CC", Slot = "5")]
		public IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x14A33F4", Offset = "0x14A33F4", VA = "0x14A33F4")]
		protected TypeInspectorSkeleton()
		{
		}
	}
}
namespace YamlDotNet.Serialization.ObjectGraphVisitors
{
	[Token(Token = "0x2000049")]
	public sealed class AnchorAssigner : PreProcessingPhaseObjectGraphVisitorSkeleton, IAliasProvider
	{
		[Token(Token = "0x2000106")]
		private class AnchorAssignment
		{
			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Anchor;

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xCF5830", Offset = "0xCF5830", VA = "0xCF5830")]
			public AnchorAssignment()
			{
			}
		}

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IDictionary<object, AnchorAssignment> assignments;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint nextId;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xCF52A4", Offset = "0xCF52A4", VA = "0xCF52A4")]
		public AnchorAssigner(IEnumerable<IYamlTypeConverter> typeConverters)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xCF53B8", Offset = "0xCF53B8", VA = "0xCF53B8", Slot = "12")]
		protected override bool Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xCF5628", Offset = "0xCF5628", VA = "0xCF5628", Slot = "14")]
		protected override bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xCF5630", Offset = "0xCF5630", VA = "0xCF5630", Slot = "13")]
		protected override bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xCF5638", Offset = "0xCF5638", VA = "0xCF5638", Slot = "17")]
		protected override void VisitScalar(IObjectDescriptor scalar)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xCF563C", Offset = "0xCF563C", VA = "0xCF563C", Slot = "16")]
		protected override void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xCF5824", Offset = "0xCF5824", VA = "0xCF5824", Slot = "15")]
		protected override void VisitMappingEnd(IObjectDescriptor mapping)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xCF5828", Offset = "0xCF5828", VA = "0xCF5828", Slot = "19")]
		protected override void VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xCF582C", Offset = "0xCF582C", VA = "0xCF582C", Slot = "18")]
		protected override void VisitSequenceEnd(IObjectDescriptor sequence)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xCF5640", Offset = "0xCF5640", VA = "0xCF5640")]
		private void VisitObject(IObjectDescriptor value)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xCF5838", Offset = "0xCF5838", VA = "0xCF5838", Slot = "20")]
		private string YamlDotNet.Serialization.IAliasProvider.GetAlias(object target)
		{
			return null;
		}
	}
	[Token(Token = "0x200004A")]
	public sealed class AnchorAssigningObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IEventEmitter eventEmitter;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IAliasProvider aliasProvider;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly HashSet<string> emittedAliases;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xCF5930", Offset = "0xCF5930", VA = "0xCF5930")]
		public AnchorAssigningObjectGraphVisitor(IObjectGraphVisitor<IEmitter> nextVisitor, IEventEmitter eventEmitter, IAliasProvider aliasProvider)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xCF59F4", Offset = "0xCF59F4", VA = "0xCF59F4", Slot = "12")]
		public override bool Enter(IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xCF5D14", Offset = "0xCF5D14", VA = "0xCF5D14", Slot = "16")]
		public override void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, IEmitter context)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xCF5F14", Offset = "0xCF5F14", VA = "0xCF5F14", Slot = "18")]
		public override void VisitSequenceStart(IObjectDescriptor sequence, Type elementType, IEmitter context)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xCF6140", Offset = "0xCF6140", VA = "0xCF6140", Slot = "15")]
		public override void VisitScalar(IObjectDescriptor scalar, IEmitter context)
		{
		}
	}
	[Token(Token = "0x200004B")]
	public abstract class ChainedObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectGraphVisitor<IEmitter> nextVisitor;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xCF59C8", Offset = "0xCF59C8", VA = "0xCF59C8")]
		protected ChainedObjectGraphVisitor(IObjectGraphVisitor<IEmitter> nextVisitor)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xCF5C48", Offset = "0xCF5C48", VA = "0xCF5C48", Slot = "12")]
		public virtual bool Enter(IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xCF6414", Offset = "0xCF6414", VA = "0xCF6414", Slot = "13")]
		public virtual bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xCF64F4", Offset = "0xCF64F4", VA = "0xCF64F4", Slot = "14")]
		public virtual bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xCF65D4", Offset = "0xCF65D4", VA = "0xCF65D4", Slot = "15")]
		public virtual void VisitScalar(IObjectDescriptor scalar, IEmitter context)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xCF66A4", Offset = "0xCF66A4", VA = "0xCF66A4", Slot = "16")]
		public virtual void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, IEmitter context)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xCF678C", Offset = "0xCF678C", VA = "0xCF678C", Slot = "17")]
		public virtual void VisitMappingEnd(IObjectDescriptor mapping, IEmitter context)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xCF685C", Offset = "0xCF685C", VA = "0xCF685C", Slot = "18")]
		public virtual void VisitSequenceStart(IObjectDescriptor sequence, Type elementType, IEmitter context)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xCF693C", Offset = "0xCF693C", VA = "0xCF693C", Slot = "19")]
		public virtual void VisitSequenceEnd(IObjectDescriptor sequence, IEmitter context)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public sealed class CustomSerializationObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673D08", Offset = "0x673D08")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IObjectDescriptor value;

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xCF6ED4", Offset = "0xCF6ED4", VA = "0xCF6ED4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xCF6EDC", Offset = "0xCF6EDC", VA = "0xCF6EDC")]
			internal bool <Enter>b__0(IYamlTypeConverter t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IEnumerable<IYamlTypeConverter> typeConverters;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ObjectSerializer nestedObjectSerializer;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xCF6A0C", Offset = "0xCF6A0C", VA = "0xCF6A0C")]
		public CustomSerializationObjectGraphVisitor(IObjectGraphVisitor<IEmitter> nextVisitor, IEnumerable<IYamlTypeConverter> typeConverters, ObjectSerializer nestedObjectSerializer)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xCF6AA8", Offset = "0xCF6AA8", VA = "0xCF6AA8", Slot = "12")]
		public override bool Enter(IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004D")]
	public sealed class DefaultExclusiveObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IEqualityComparer<object> _objectComparer;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xCF701C", Offset = "0xCF701C", VA = "0xCF701C")]
		public DefaultExclusiveObjectGraphVisitor(IObjectGraphVisitor<IEmitter> nextVisitor)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xCF7048", Offset = "0xCF7048", VA = "0xCF7048")]
		private static object GetDefault(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xCF70D0", Offset = "0xCF70D0", VA = "0xCF70D0", Slot = "13")]
		public override bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xCF7280", Offset = "0xCF7280", VA = "0xCF7280", Slot = "14")]
		public override bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004E")]
	public sealed class EmittingObjectGraphVisitor : IObjectGraphVisitor<IEmitter>
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEventEmitter eventEmitter;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xCF75E4", Offset = "0xCF75E4", VA = "0xCF75E4")]
		public EmittingObjectGraphVisitor(IEventEmitter eventEmitter)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xCF7610", Offset = "0xCF7610", VA = "0xCF7610", Slot = "4")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.Enter(IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xCF7618", Offset = "0xCF7618", VA = "0xCF7618", Slot = "5")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.EnterMapping(IObjectDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xCF7620", Offset = "0xCF7620", VA = "0xCF7620", Slot = "6")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.EnterMapping(IPropertyDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xCF7628", Offset = "0xCF7628", VA = "0xCF7628", Slot = "7")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitScalar(IObjectDescriptor scalar, IEmitter context)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xCF7714", Offset = "0xCF7714", VA = "0xCF7714", Slot = "8")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, IEmitter context)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xCF7804", Offset = "0xCF7804", VA = "0xCF7804", Slot = "9")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitMappingEnd(IObjectDescriptor mapping, IEmitter context)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xCF78F4", Offset = "0xCF78F4", VA = "0xCF78F4", Slot = "10")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitSequenceStart(IObjectDescriptor sequence, Type elementType, IEmitter context)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xCF79E4", Offset = "0xCF79E4", VA = "0xCF79E4", Slot = "11")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitSequenceEnd(IObjectDescriptor sequence, IEmitter context)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public abstract class PreProcessingPhaseObjectGraphVisitorSkeleton : IObjectGraphVisitor<Nothing>
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673D18", Offset = "0x673D18")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IObjectDescriptor value;

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xCF7D18", Offset = "0xCF7D18", VA = "0xCF7D18")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xCF7D8C", Offset = "0xCF7D8C", VA = "0xCF7D8C")]
			internal bool <YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.Enter>b__0(IYamlTypeConverter t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly IEnumerable<IYamlTypeConverter> typeConverters;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xCF5320", Offset = "0xCF5320", VA = "0xCF5320")]
		public PreProcessingPhaseObjectGraphVisitorSkeleton(IEnumerable<IYamlTypeConverter> typeConverters)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xCF7B00", Offset = "0xCF7B00", VA = "0xCF7B00", Slot = "4")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.Enter(IObjectDescriptor value, Nothing context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xCF7D20", Offset = "0xCF7D20", VA = "0xCF7D20", Slot = "6")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.EnterMapping(IPropertyDescriptor key, IObjectDescriptor value, Nothing context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xCF7D2C", Offset = "0xCF7D2C", VA = "0xCF7D2C", Slot = "5")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.EnterMapping(IObjectDescriptor key, IObjectDescriptor value, Nothing context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xCF7D3C", Offset = "0xCF7D3C", VA = "0xCF7D3C", Slot = "9")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitMappingEnd(IObjectDescriptor mapping, Nothing context)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xCF7D4C", Offset = "0xCF7D4C", VA = "0xCF7D4C", Slot = "8")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, Nothing context)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xCF7D5C", Offset = "0xCF7D5C", VA = "0xCF7D5C", Slot = "7")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitScalar(IObjectDescriptor scalar, Nothing context)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xCF7D6C", Offset = "0xCF7D6C", VA = "0xCF7D6C", Slot = "11")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitSequenceEnd(IObjectDescriptor sequence, Nothing context)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xCF7D7C", Offset = "0xCF7D7C", VA = "0xCF7D7C", Slot = "10")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitSequenceStart(IObjectDescriptor sequence, Type elementType, Nothing context)
		{
		}

		[Token(Token = "0x600019A")]
		protected abstract bool Enter(IObjectDescriptor value);

		[Token(Token = "0x600019B")]
		protected abstract bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value);

		[Token(Token = "0x600019C")]
		protected abstract bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value);

		[Token(Token = "0x600019D")]
		protected abstract void VisitMappingEnd(IObjectDescriptor mapping);

		[Token(Token = "0x600019E")]
		protected abstract void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType);

		[Token(Token = "0x600019F")]
		protected abstract void VisitScalar(IObjectDescriptor scalar);

		[Token(Token = "0x60001A0")]
		protected abstract void VisitSequenceEnd(IObjectDescriptor sequence);

		[Token(Token = "0x60001A1")]
		protected abstract void VisitSequenceStart(IObjectDescriptor sequence, Type elementType);
	}
}
namespace YamlDotNet.Serialization.ObjectGraphTraversalStrategies
{
	[Token(Token = "0x2000050")]
	public class FullObjectGraphTraversalStrategy : IObjectGraphTraversalStrategy
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int maxRecursion;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ITypeInspector typeDescriptor;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ITypeResolver typeResolver;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private INamingConvention namingConvention;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xCF5010", Offset = "0xCF5010", VA = "0xCF5010")]
		public FullObjectGraphTraversalStrategy(ITypeInspector typeDescriptor, ITypeResolver typeResolver, int maxRecursion, INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x60001A3")]
		private void YamlDotNet.Serialization.IObjectGraphTraversalStrategy.Traverse<TContext>(IObjectDescriptor graph, IObjectGraphVisitor<TContext> visitor, TContext context)
		{
		}

		[Token(Token = "0x60001A4")]
		protected virtual void Traverse<TContext>(IObjectDescriptor value, IObjectGraphVisitor<TContext> visitor, int currentDepth, TContext context)
		{
		}

		[Token(Token = "0x60001A5")]
		protected virtual void TraverseObject<TContext>(IObjectDescriptor value, IObjectGraphVisitor<TContext> visitor, int currentDepth, TContext context)
		{
		}

		[Token(Token = "0x60001A6")]
		protected virtual void TraverseDictionary<TContext>(IObjectDescriptor dictionary, IObjectGraphVisitor<TContext> visitor, int currentDepth, Type keyType, Type valueType, TContext context)
		{
		}

		[Token(Token = "0x60001A7")]
		private void TraverseList<TContext>(IObjectDescriptor value, IObjectGraphVisitor<TContext> visitor, int currentDepth, TContext context)
		{
		}

		[Token(Token = "0x60001A8")]
		protected virtual void TraverseProperties<TContext>(IObjectDescriptor value, IObjectGraphVisitor<TContext> visitor, int currentDepth, TContext context)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xCF5168", Offset = "0xCF5168", VA = "0xCF5168")]
		private IObjectDescriptor GetObjectDescriptor(object value, Type staticType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public class RoundtripObjectGraphTraversalStrategy : FullObjectGraphTraversalStrategy
	{
		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673D28", Offset = "0x673D28")]
		private sealed class <>c__DisplayClass2_0<TContext>
		{
			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IObjectDescriptor value;

			[Token(Token = "0x60005BD")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005BE")]
			internal bool <TraverseProperties>b__0(IYamlTypeConverter c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IEnumerable<IYamlTypeConverter> converters;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xCF526C", Offset = "0xCF526C", VA = "0xCF526C")]
		public RoundtripObjectGraphTraversalStrategy(IEnumerable<IYamlTypeConverter> converters, ITypeInspector typeDescriptor, ITypeResolver typeResolver, int maxRecursion)
		{
		}

		[Token(Token = "0x60001AB")]
		protected override void TraverseProperties<TContext>(IObjectDescriptor value, IObjectGraphVisitor<TContext> visitor, int currentDepth, TContext context)
		{
		}
	}
}
namespace YamlDotNet.Serialization.ObjectFactories
{
	[Token(Token = "0x2000052")]
	public sealed class DefaultObjectFactory : IObjectFactory
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, Type> defaultInterfaceImplementations;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xCF4B9C", Offset = "0xCF4B9C", VA = "0xCF4B9C", Slot = "4")]
		public object Create(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xCEB88C", Offset = "0xCEB88C", VA = "0xCEB88C")]
		public DefaultObjectFactory()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public sealed class LambdaObjectFactory : IObjectFactory
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Func<Type, object> _factory;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xCEC04C", Offset = "0xCEC04C", VA = "0xCEC04C")]
		public LambdaObjectFactory(Func<Type, object> factory)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xCF4FA0", Offset = "0xCF4FA0", VA = "0xCF4FA0", Slot = "4")]
		public object Create(Type type)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.NodeTypeResolvers
{
	[Token(Token = "0x2000054")]
	public sealed class DefaultContainersNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xCF3DA4", Offset = "0xCF3DA4", VA = "0xCF3DA4", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xCEBB10", Offset = "0xCEBB10", VA = "0xCEBB10")]
		public DefaultContainersNodeTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public sealed class TagNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, Type> tagMappings;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xCEBA64", Offset = "0xCEBA64", VA = "0xCEBA64")]
		public TagNodeTypeResolver(IDictionary<string, Type> tagMappings)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xCF3EFC", Offset = "0xCF3EFC", VA = "0xCF3EFC", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000056")]
	public sealed class TypeNameInTagNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xCF4034", Offset = "0xCF4034", VA = "0xCF4034", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xCEBB08", Offset = "0xCEBB08", VA = "0xCEBB08")]
		public TypeNameInTagNodeTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public sealed class YamlConvertibleTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xCF4150", Offset = "0xCF4150", VA = "0xCF4150", Slot = "4")]
		public bool Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xCEBA54", Offset = "0xCEBA54", VA = "0xCEBA54")]
		public YamlConvertibleTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public sealed class YamlSerializableTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xCF41EC", Offset = "0xCF41EC", VA = "0xCF41EC", Slot = "4")]
		public bool Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xCEBA5C", Offset = "0xCEBA5C", VA = "0xCEBA5C")]
		public YamlSerializableTypeResolver()
		{
		}
	}
}
namespace YamlDotNet.Serialization.NodeDeserializers
{
	[Token(Token = "0x2000059")]
	public sealed class ArrayNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x673D38", Offset = "0x673D38")]
		private sealed class ArrayList : IList, ICollection, IEnumerable
		{
			[Token(Token = "0x200012C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673EB0", Offset = "0x673EB0")]
			private sealed class <GetEnumerator>d__24 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Token(Token = "0x400025C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int <>1__state;

				[Token(Token = "0x400025D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private object <>2__current;

				[Token(Token = "0x400025E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public ArrayList <>4__this;

				[Token(Token = "0x400025F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private int <i>5__2;

				[Token(Token = "0x170000FE")]
				private object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[Token(Token = "0x600066B")]
					[Address(RVA = "0xCF0BC8", Offset = "0xCF0BC8", VA = "0xCF0BC8", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x170000FF")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x600066D")]
					[Address(RVA = "0xCF0C38", Offset = "0xCF0C38", VA = "0xCF0C38", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0xCF0AC8", Offset = "0xCF0AC8", VA = "0xCF0AC8")]
				[DebuggerHidden]
				public <GetEnumerator>d__24(int <>1__state)
				{
				}

				[Token(Token = "0x6000669")]
				[Address(RVA = "0xCF0AF4", Offset = "0xCF0AF4", VA = "0xCF0AF4", Slot = "5")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x600066A")]
				[Address(RVA = "0xCF0AF8", Offset = "0xCF0AF8", VA = "0xCF0AF8", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x600066C")]
				[Address(RVA = "0xCF0BD0", Offset = "0xCF0BD0", VA = "0xCF0BD0", Slot = "8")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object[] data;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int count;

			[Token(Token = "0x170000DB")]
			public bool IsFixedSize
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0xCF0880", Offset = "0xCF0880", VA = "0xCF0880", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DC")]
			public bool IsReadOnly
			{
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0xCF0888", Offset = "0xCF0888", VA = "0xCF0888", Slot = "9")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DD")]
			public object Item
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0xCF0960", Offset = "0xCF0960", VA = "0xCF0960", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0xCF09B4", Offset = "0xCF09B4", VA = "0xCF09B4", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x170000DE")]
			public int Count
			{
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0xCF05A4", Offset = "0xCF05A4", VA = "0xCF05A4", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000DF")]
			public bool IsSynchronized
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0xCF0A44", Offset = "0xCF0A44", VA = "0xCF0A44", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E0")]
			public object SyncRoot
			{
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0xCF0A4C", Offset = "0xCF0A4C", VA = "0xCF0A4C", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xCF0060", Offset = "0xCF0060", VA = "0xCF0060")]
			public ArrayList()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xCF0630", Offset = "0xCF0630", VA = "0xCF0630", Slot = "6")]
			public int Add(object value)
			{
				return default(int);
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xCF05D4", Offset = "0xCF05D4", VA = "0xCF05D4", Slot = "8")]
			public void Clear()
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xCF0748", Offset = "0xCF0748", VA = "0xCF0748", Slot = "7")]
			public bool Contains(object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xCF07B0", Offset = "0xCF07B0", VA = "0xCF07B0", Slot = "11")]
			public int IndexOf(object value)
			{
				return default(int);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xCF0818", Offset = "0xCF0818", VA = "0xCF0818", Slot = "12")]
			public void Insert(int index, object value)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xCF0890", Offset = "0xCF0890", VA = "0xCF0890", Slot = "13")]
			public void Remove(object value)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xCF08F8", Offset = "0xCF08F8", VA = "0xCF08F8", Slot = "14")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xCF05AC", Offset = "0xCF05AC", VA = "0xCF05AC", Slot = "15")]
			public void CopyTo(Array array, int index)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xCF0A54", Offset = "0xCF0A54", VA = "0xCF0A54", Slot = "19")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675890", Offset = "0x675890")]
			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xCEFEF0", Offset = "0xCEFEF0", VA = "0xCEFEF0", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xCEB9A8", Offset = "0xCEB9A8", VA = "0xCEB9A8")]
		public ArrayNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public sealed class CollectionNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673D70", Offset = "0x673D70")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IList result;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type tItem;

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xCF1024", Offset = "0xCF1024", VA = "0xCF1024")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673D80", Offset = "0x673D80")]
		private sealed class <>c__DisplayClass3_1
		{
			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass3_0 CS$<>8__locals1;

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xCF102C", Offset = "0xCF102C", VA = "0xCF102C")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xCF1034", Offset = "0xCF1034", VA = "0xCF1034")]
			internal void <DeserializeHelper>b__0(object v)
			{
			}
		}

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xCEB9DC", Offset = "0xCEB9DC", VA = "0xCEB9DC")]
		public CollectionNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xCF0C40", Offset = "0xCF0C40", VA = "0xCF0C40", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xCF0088", Offset = "0xCF0088", VA = "0xCF0088")]
		internal static void DeserializeHelper(Type tItem, IParser parser, Func<IParser, Type, object> nestedObjectDeserializer, IList result, bool canUpdate)
		{
		}
	}
	[Token(Token = "0x200005B")]
	public sealed class DictionaryNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673D90", Offset = "0x673D90")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IDictionary result;

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xCF19C8", Offset = "0xCF19C8", VA = "0xCF19C8")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673DA0", Offset = "0x673DA0")]
		private sealed class <>c__DisplayClass3_1
		{
			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object key;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object value;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass3_0 CS$<>8__locals1;

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xCF19D0", Offset = "0xCF19D0", VA = "0xCF19D0")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xCF19E0", Offset = "0xCF19E0", VA = "0xCF19E0")]
			internal void <DeserializeHelper>b__0(object v)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xCF1AC0", Offset = "0xCF1AC0", VA = "0xCF1AC0")]
			internal void <DeserializeHelper>b__1(object v)
			{
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673DB0", Offset = "0x673DB0")]
		private sealed class <>c__DisplayClass3_2
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool hasFirstPart;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass3_1 CS$<>8__locals2;

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xCF19D8", Offset = "0xCF19D8", VA = "0xCF19D8")]
			public <>c__DisplayClass3_2()
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xCF1BA0", Offset = "0xCF1BA0", VA = "0xCF1BA0")]
			internal void <DeserializeHelper>b__2(object v)
			{
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xCF1CC8", Offset = "0xCF1CC8", VA = "0xCF1CC8")]
			internal void <DeserializeHelper>b__3(object v)
			{
			}
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xCEB9B0", Offset = "0xCEB9B0", VA = "0xCEB9B0")]
		public DictionaryNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xCF113C", Offset = "0xCF113C", VA = "0xCF113C", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xCF14F4", Offset = "0xCF14F4", VA = "0xCF14F4")]
		private static void DeserializeHelper(Type tKey, Type tValue, IParser parser, Func<IParser, Type, object> nestedObjectDeserializer, IDictionary result)
		{
		}
	}
	[Token(Token = "0x200005C")]
	public sealed class EnumerableNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xCF1DF0", Offset = "0xCF1DF0", VA = "0xCF1DF0", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xCEBA08", Offset = "0xCEBA08", VA = "0xCEBA08")]
		public EnumerableNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public sealed class NullNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xCF2070", Offset = "0xCF2070", VA = "0xCF2070", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xCF20FC", Offset = "0xCF20FC", VA = "0xCF20FC")]
		private bool NodeIsNull(NodeEvent nodeEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xCEB998", Offset = "0xCEB998", VA = "0xCEB998")]
		public NullNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public sealed class ObjectNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673DC0", Offset = "0x673DC0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IPropertyDescriptor property;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xCF27C4", Offset = "0xCF27C4", VA = "0xCF27C4")]
			public <>c__DisplayClass4_0()
			{
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673DD0", Offset = "0x673DD0")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object valueRef;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xCF27CC", Offset = "0xCF27CC", VA = "0xCF27CC")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xCF27D4", Offset = "0xCF27D4", VA = "0xCF27D4")]
			internal void <YamlDotNet.Serialization.INodeDeserializer.Deserialize>b__0(object v)
			{
			}
		}

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ITypeInspector _typeDescriptor;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly bool _ignoreUnmatched;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xCEBA10", Offset = "0xCEBA10", VA = "0xCEBA10")]
		public ObjectNodeDeserializer(IObjectFactory objectFactory, ITypeInspector typeDescriptor, bool ignoreUnmatched)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xCF2264", Offset = "0xCF2264", VA = "0xCF2264", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005F")]
	public sealed class ScalarNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x4000067")]
		private const string BooleanTruePattern = "^(true|y|yes|on)$";

		[Token(Token = "0x4000068")]
		private const string BooleanFalsePattern = "^(false|n|no|off)$";

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xCF294C", Offset = "0xCF294C", VA = "0xCF294C", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xCF2D6C", Offset = "0xCF2D6C", VA = "0xCF2D6C")]
		private object DeserializeBooleanHelper(string value)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xCF2EA8", Offset = "0xCF2EA8", VA = "0xCF2EA8")]
		private object DeserializeIntegerHelper(TypeCode typeCode, string value)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xCF334C", Offset = "0xCF334C", VA = "0xCF334C")]
		private static object CastInteger(long number, TypeCode typeCode)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xCF3490", Offset = "0xCF3490", VA = "0xCF3490")]
		private static object CastInteger(ulong number, TypeCode typeCode)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xCEB9A0", Offset = "0xCEB9A0", VA = "0xCEB9A0")]
		public ScalarNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public sealed class TypeConverterNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673DE0", Offset = "0x673DE0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type expectedType;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xCF373C", Offset = "0xCF373C", VA = "0xCF373C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xCF3744", Offset = "0xCF3744", VA = "0xCF3744")]
			internal bool <YamlDotNet.Serialization.INodeDeserializer.Deserialize>b__0(IYamlTypeConverter c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEnumerable<IYamlTypeConverter> converters;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xCEB8F4", Offset = "0xCEB8F4", VA = "0xCEB8F4")]
		public TypeConverterNodeDeserializer(IEnumerable<IYamlTypeConverter> converters)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xCF35D0", Offset = "0xCF35D0", VA = "0xCF35D0", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000061")]
	public sealed class YamlConvertibleNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673DF0", Offset = "0x673DF0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<IParser, Type, object> nestedObjectDeserializer;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IParser parser;

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xCF3AD0", Offset = "0xCF3AD0", VA = "0xCF3AD0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xCF3AE8", Offset = "0xCF3AE8", VA = "0xCF3AE8")]
			internal object <Deserialize>b__0(Type type)
			{
				return null;
			}
		}

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory objectFactory;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xCEB89C", Offset = "0xCEB89C", VA = "0xCEB89C")]
		public YamlConvertibleNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xCF3808", Offset = "0xCF3808", VA = "0xCF3808", Slot = "4")]
		public bool Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000062")]
	public sealed class YamlSerializableNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory objectFactory;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xCEB8C8", Offset = "0xCEB8C8", VA = "0xCEB8C8")]
		public YamlSerializableNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xCF3B60", Offset = "0xCF3B60", VA = "0xCF3B60", Slot = "4")]
		public bool Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
}
namespace YamlDotNet.Serialization.NamingConventions
{
	[Token(Token = "0x2000063")]
	public sealed class CamelCaseNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xCEFE10", Offset = "0xCEFE10", VA = "0xCEFE10", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xCE708C", Offset = "0xCE708C", VA = "0xCE708C")]
		public CamelCaseNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public sealed class HyphenatedNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xCEFE1C", Offset = "0xCEFE1C", VA = "0xCEFE1C", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xCEFE70", Offset = "0xCEFE70", VA = "0xCEFE70")]
		public HyphenatedNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public sealed class NullNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xCEFE78", Offset = "0xCEFE78", VA = "0xCEFE78", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xCEB894", Offset = "0xCEB894", VA = "0xCEB894")]
		public NullNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public sealed class PascalCaseNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xCEFE80", Offset = "0xCEFE80", VA = "0xCEFE80", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xCEFE8C", Offset = "0xCEFE8C", VA = "0xCEFE8C")]
		public PascalCaseNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public sealed class UnderscoredNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xCEFE94", Offset = "0xCEFE94", VA = "0xCEFE94", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xCEFEE8", Offset = "0xCEFEE8", VA = "0xCEFEE8")]
		public UnderscoredNamingConvention()
		{
		}
	}
}
namespace YamlDotNet.Serialization.EventEmitters
{
	[Token(Token = "0x2000068")]
	public abstract class ChainedEventEmitter : IEventEmitter
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly IEventEmitter nextEmitter;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xCED7BC", Offset = "0xCED7BC", VA = "0xCED7BC")]
		protected ChainedEventEmitter(IEventEmitter nextEmitter)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xCED860", Offset = "0xCED860", VA = "0xCED860", Slot = "10")]
		public virtual void Emit(AliasEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xCED92C", Offset = "0xCED92C", VA = "0xCED92C", Slot = "11")]
		public virtual void Emit(ScalarEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xCED9FC", Offset = "0xCED9FC", VA = "0xCED9FC", Slot = "12")]
		public virtual void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xCEDACC", Offset = "0xCEDACC", VA = "0xCEDACC", Slot = "13")]
		public virtual void Emit(MappingEndEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xCEDB9C", Offset = "0xCEDB9C", VA = "0xCEDB9C", Slot = "14")]
		public virtual void Emit(SequenceStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xCEDC6C", Offset = "0xCEDC6C", VA = "0xCEDC6C", Slot = "15")]
		public virtual void Emit(SequenceEndEventInfo eventInfo, IEmitter emitter)
		{
		}
	}
	[Token(Token = "0x2000069")]
	internal class CustomTagEventEmitter : ChainedEventEmitter
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IDictionary<Type, string> tagMappings;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xCEDD3C", Offset = "0xCEDD3C", VA = "0xCEDD3C")]
		public CustomTagEventEmitter(IEventEmitter inner, IDictionary<Type, string> tagMappings)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xCEDD64", Offset = "0xCEDD64", VA = "0xCEDD64", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}
	}
	[Token(Token = "0x200006A")]
	public sealed class JsonEventEmitter : ChainedEventEmitter
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xCEDFFC", Offset = "0xCEDFFC", VA = "0xCEDFFC")]
		public JsonEventEmitter(IEventEmitter nextEmitter)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xCEE000", Offset = "0xCEE000", VA = "0xCEE000", Slot = "10")]
		public override void Emit(AliasEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xCEE074", Offset = "0xCEE074", VA = "0xCEE074", Slot = "11")]
		public override void Emit(ScalarEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xCEE7D8", Offset = "0xCEE7D8", VA = "0xCEE7D8", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xCEE82C", Offset = "0xCEE82C", VA = "0xCEE82C", Slot = "14")]
		public override void Emit(SequenceStartEventInfo eventInfo, IEmitter emitter)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public sealed class TypeAssigningEventEmitter : ChainedEventEmitter
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly bool _assignTypeWhenDifferent;

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xCEE880", Offset = "0xCEE880", VA = "0xCEE880")]
		public TypeAssigningEventEmitter(IEventEmitter nextEmitter, bool assignTypeWhenDifferent)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xCEE8AC", Offset = "0xCEE8AC", VA = "0xCEE8AC", Slot = "11")]
		public override void Emit(ScalarEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xCEF324", Offset = "0xCEF324", VA = "0xCEF324", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xCEF64C", Offset = "0xCEF64C", VA = "0xCEF64C", Slot = "14")]
		public override void Emit(SequenceStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xCEF360", Offset = "0xCEF360", VA = "0xCEF360")]
		private void AssignTypeIfDifferent(ObjectEventInfo eventInfo)
		{
		}
	}
	[Token(Token = "0x200006C")]
	public sealed class WriterEventEmitter : IEventEmitter
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xCEF688", Offset = "0xCEF688", VA = "0xCEF688", Slot = "4")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(AliasEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xCEF778", Offset = "0xCEF778", VA = "0xCEF778", Slot = "5")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(ScalarEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xCEF920", Offset = "0xCEF920", VA = "0xCEF920", Slot = "6")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xCEFA78", Offset = "0xCEFA78", VA = "0xCEFA78", Slot = "7")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(MappingEndEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xCEFB48", Offset = "0xCEFB48", VA = "0xCEFB48", Slot = "8")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(SequenceStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xCEFCA0", Offset = "0xCEFCA0", VA = "0xCEFCA0", Slot = "9")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(SequenceEndEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xCEFD70", Offset = "0xCEFD70", VA = "0xCEFD70")]
		public WriterEventEmitter()
		{
		}
	}
}
namespace YamlDotNet.Serialization.Converters
{
	[Token(Token = "0x200006D")]
	public class DateTimeConverter : IYamlTypeConverter
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DateTimeKind kind;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IFormatProvider provider;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string[] formats;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xCE97B0", Offset = "0xCE97B0", VA = "0xCE97B0")]
		public DateTimeConverter(DateTimeKind kind = DateTimeKind.Utc, [Optional] IFormatProvider provider, params string[] formats)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xCE9898", Offset = "0xCE9898", VA = "0xCE9898", Slot = "4")]
		public bool Accepts(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xCE991C", Offset = "0xCE991C", VA = "0xCE991C", Slot = "5")]
		public object ReadYaml(IParser parser, Type type)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xCE9C5C", Offset = "0xCE9C5C", VA = "0xCE9C5C", Slot = "6")]
		public void WriteYaml(IEmitter emitter, object value, Type type)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xCE9BE0", Offset = "0xCE9BE0", VA = "0xCE9BE0")]
		private static DateTime EnsureDateTimeKind(DateTime dt, DateTimeKind kind)
		{
			return default(DateTime);
		}
	}
	[Token(Token = "0x200006E")]
	public class GuidConverter : IYamlTypeConverter
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly bool jsonCompatible;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xCE9DD8", Offset = "0xCE9DD8", VA = "0xCE9DD8")]
		public GuidConverter(bool jsonCompatible)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xCE9E08", Offset = "0xCE9E08", VA = "0xCE9E08", Slot = "4")]
		public bool Accepts(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xCE9E8C", Offset = "0xCE9E8C", VA = "0xCE9E8C", Slot = "5")]
		public object ReadYaml(IParser parser, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xCEA100", Offset = "0xCEA100", VA = "0xCEA100", Slot = "6")]
		public void WriteYaml(IEmitter emitter, object value, Type type)
		{
		}
	}
}
namespace YamlDotNet.RepresentationModel
{
	[Token(Token = "0x200006F")]
	internal class DocumentLoadingState
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, YamlNode> anchors;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IList<YamlNode> nodesWithUnresolvedAliases;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xEE2454", Offset = "0xEE2454", VA = "0xEE2454")]
		public void AddAnchor(YamlNode node)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xEE2680", Offset = "0xEE2680", VA = "0xEE2680")]
		public YamlNode GetNode(string anchor, bool throwException, Mark start, Mark end)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xEE280C", Offset = "0xEE280C", VA = "0xEE280C")]
		public void AddNodeWithUnresolvedAliases(YamlNode node)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xEE28D4", Offset = "0xEE28D4", VA = "0xEE28D4")]
		public void ResolveAliases()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xEE2B80", Offset = "0xEE2B80", VA = "0xEE2B80")]
		public DocumentLoadingState()
		{
		}
	}
	[Token(Token = "0x2000070")]
	internal class EmitterState
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly HashSet<string> emittedAnchors;

		[Token(Token = "0x17000033")]
		public HashSet<string> EmittedAnchors
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xEE2C18", Offset = "0xEE2C18", VA = "0xEE2C18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xEE2C20", Offset = "0xEE2C20", VA = "0xEE2C20")]
		public EmitterState()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public interface IYamlVisitor
	{
		[Token(Token = "0x600020A")]
		void Visit(YamlStream stream);

		[Token(Token = "0x600020B")]
		void Visit(YamlDocument document);

		[Token(Token = "0x600020C")]
		void Visit(YamlScalarNode scalar);

		[Token(Token = "0x600020D")]
		void Visit(YamlSequenceNode sequence);

		[Token(Token = "0x600020E")]
		void Visit(YamlMappingNode mapping);
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	internal class YamlAliasNode : YamlNode
	{
		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E00", Offset = "0x673E00")]
		private sealed class <SafeAllNodes>d__7 : IEnumerable<YamlNode>, IEnumerable, IEnumerator<YamlNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private YamlNode <>2__current;

			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YamlAliasNode <>4__this;

			[Token(Token = "0x170000E1")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0xEE3078", Offset = "0xEE3078", VA = "0xEE3078", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0xEE30E8", Offset = "0xEE30E8", VA = "0xEE30E8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xEE2FF4", Offset = "0xEE2FF4", VA = "0xEE2FF4")]
			[DebuggerHidden]
			public <SafeAllNodes>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xEE3034", Offset = "0xEE3034", VA = "0xEE3034", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xEE3038", Offset = "0xEE3038", VA = "0xEE3038", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xEE3080", Offset = "0xEE3080", VA = "0xEE3080", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xEE30F0", Offset = "0xEE30F0", VA = "0xEE30F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xEE31A0", Offset = "0xEE31A0", VA = "0xEE31A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public override YamlNodeType NodeType
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xEE302C", Offset = "0xEE302C", VA = "0xEE302C", Slot = "9")]
			get
			{
				return default(YamlNodeType);
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xEE2C90", Offset = "0xEE2C90", VA = "0xEE2C90")]
		internal YamlAliasNode(string anchor)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xEE2CC4", Offset = "0xEE2CC4", VA = "0xEE2CC4", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xEE2D38", Offset = "0xEE2D38", VA = "0xEE2D38", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xEE2DAC", Offset = "0xEE2DAC", VA = "0xEE2DAC", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xEE2E20", Offset = "0xEE2E20", VA = "0xEE2E20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xEE2F04", Offset = "0xEE2F04", VA = "0xEE2F04", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xEE2F0C", Offset = "0xEE2F0C", VA = "0xEE2F0C", Slot = "7")]
		internal override string ToString(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xEE2F70", Offset = "0xEE2F70", VA = "0xEE2F70", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x674CB0", Offset = "0x674CB0")]
		internal override IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class YamlDocument
	{
		[Token(Token = "0x2000115")]
		private class AnchorAssigningVisitor : YamlVisitorBase
		{
			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly HashSet<string> existingAnchors;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly Dictionary<YamlNode, bool> visitedNodes;

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xEE34B8", Offset = "0xEE34B8", VA = "0xEE34B8")]
			public void AssignAnchors(YamlDocument document)
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xEE3B08", Offset = "0xEE3B08", VA = "0xEE3B08")]
			private bool VisitNodeAndFindDuplicates(YamlNode node)
			{
				return default(bool);
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xEE3BFC", Offset = "0xEE3BFC", VA = "0xEE3BFC", Slot = "11")]
			public override void Visit(YamlScalarNode scalar)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xEE3C00", Offset = "0xEE3C00", VA = "0xEE3C00", Slot = "13")]
			public override void Visit(YamlMappingNode mapping)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xEE3C40", Offset = "0xEE3C40", VA = "0xEE3C40", Slot = "12")]
			public override void Visit(YamlSequenceNode sequence)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xEE3420", Offset = "0xEE3420", VA = "0xEE3420")]
			public AnchorAssigningVisitor()
			{
			}
		}

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674070", Offset = "0x674070")]
		private YamlNode <RootNode>k__BackingField;

		[Token(Token = "0x17000035")]
		public YamlNode RootNode
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xEE31A4", Offset = "0xEE31A4", VA = "0xEE31A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674D14", Offset = "0x674D14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xEE31AC", Offset = "0xEE31AC", VA = "0xEE31AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674D24", Offset = "0x674D24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xEE3AD8", Offset = "0xEE3AD8", VA = "0xEE3AD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xEE31B4", Offset = "0xEE31B4", VA = "0xEE31B4")]
		public YamlDocument(YamlNode rootNode)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xEE31E0", Offset = "0xEE31E0", VA = "0xEE31E0")]
		public YamlDocument(string rootNode)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xEE325C", Offset = "0xEE325C", VA = "0xEE325C")]
		internal YamlDocument(IParser parser)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xEE33B4", Offset = "0xEE33B4", VA = "0xEE33B4")]
		private void AssignAnchors()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xEE3864", Offset = "0xEE3864", VA = "0xEE3864")]
		internal void Save(IEmitter emitter, bool assignAnchors = true)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xEE3A14", Offset = "0xEE3A14", VA = "0xEE3A14")]
		public void Accept(IYamlVisitor visitor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public sealed class YamlMappingNode : YamlNode, IEnumerable<KeyValuePair<YamlNode, YamlNode>>, IEnumerable, IYamlConvertible
	{
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E10", Offset = "0x673E10")]
		private sealed class <SafeAllNodes>d__24 : IEnumerable<YamlNode>, IEnumerable, IEnumerator<YamlNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private YamlNode <>2__current;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RecursionLevel level;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RecursionLevel <>3__level;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public YamlMappingNode <>4__this;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator<KeyValuePair<YamlNode, YamlNode>> <>7__wrap1;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private KeyValuePair<YamlNode, YamlNode> <child>5__3;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private IEnumerator<YamlNode> <>7__wrap3;

			[Token(Token = "0x170000E3")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0xCDE488", Offset = "0xCDE488", VA = "0xCDE488", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0xCDE4F8", Offset = "0xCDE4F8", VA = "0xCDE4F8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xCDDAB8", Offset = "0xCDDAB8", VA = "0xCDDAB8")]
			[DebuggerHidden]
			public <SafeAllNodes>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xCDDAF0", Offset = "0xCDDAF0", VA = "0xCDDAF0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xCDDDD8", Offset = "0xCDDDD8", VA = "0xCDDDD8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xCDDD18", Offset = "0xCDDD18", VA = "0xCDDD18")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xCDDB98", Offset = "0xCDDB98", VA = "0xCDDB98")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xCDDC58", Offset = "0xCDDC58", VA = "0xCDDC58")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xCDE490", Offset = "0xCDE490", VA = "0xCDE490", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xCDE500", Offset = "0xCDE500", VA = "0xCDE500", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xCDE5C0", Offset = "0xCDE5C0", VA = "0xCDE5C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IDictionary<YamlNode, YamlNode> children;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674080", Offset = "0x674080")]
		private MappingStyle <Style>k__BackingField;

		[Token(Token = "0x17000037")]
		public IDictionary<YamlNode, YamlNode> Children
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xEE3C80", Offset = "0xEE3C80", VA = "0xEE3C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public MappingStyle Style
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xEE3C88", Offset = "0xEE3C88", VA = "0xEE3C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674D34", Offset = "0x674D34")]
			get
			{
				return default(MappingStyle);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xEE3C90", Offset = "0xEE3C90", VA = "0xEE3C90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674D44", Offset = "0x674D44")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public override YamlNodeType NodeType
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xEE6578", Offset = "0xEE6578", VA = "0xEE6578", Slot = "9")]
			get
			{
				return default(YamlNodeType);
			}
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xEE3C98", Offset = "0xEE3C98", VA = "0xEE3C98")]
		internal YamlMappingNode(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xEE3D28", Offset = "0xEE3D28", VA = "0xEE3D28")]
		private void Load(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xEE405C", Offset = "0xEE405C", VA = "0xEE405C")]
		public YamlMappingNode()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xEE40CC", Offset = "0xEE40CC", VA = "0xEE40CC")]
		public YamlMappingNode(int dummy)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xEE413C", Offset = "0xEE413C", VA = "0xEE413C")]
		public YamlMappingNode(params KeyValuePair<YamlNode, YamlNode>[] children)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xEE4140", Offset = "0xEE4140", VA = "0xEE4140")]
		public YamlMappingNode(IEnumerable<KeyValuePair<YamlNode, YamlNode>> children)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xEE4494", Offset = "0xEE4494", VA = "0xEE4494")]
		public YamlMappingNode(params YamlNode[] children)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xEE4498", Offset = "0xEE4498", VA = "0xEE4498")]
		public YamlMappingNode(IEnumerable<YamlNode> children)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xEE489C", Offset = "0xEE489C", VA = "0xEE489C")]
		public void Add(YamlNode key, YamlNode value)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xEE496C", Offset = "0xEE496C", VA = "0xEE496C")]
		public void Add(string key, YamlNode value)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xEE4A5C", Offset = "0xEE4A5C", VA = "0xEE4A5C")]
		public void Add(YamlNode key, string value)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xEE4B4C", Offset = "0xEE4B4C", VA = "0xEE4B4C")]
		public void Add(string key, string value)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xEE4C5C", Offset = "0xEE4C5C", VA = "0xEE4C5C", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xEE578C", Offset = "0xEE578C", VA = "0xEE578C", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xEE5BF8", Offset = "0xEE5BF8", VA = "0xEE5BF8", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xEE5CBC", Offset = "0xEE5CBC", VA = "0xEE5CBC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xEE61B8", Offset = "0xEE61B8", VA = "0xEE61B8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xEE64E0", Offset = "0xEE64E0", VA = "0xEE64E0", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x674D54", Offset = "0x674D54")]
		internal override IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xEE6580", Offset = "0xEE6580", VA = "0xEE6580", Slot = "7")]
		internal override string ToString(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xEE6A50", Offset = "0xEE6A50", VA = "0xEE6A50", Slot = "10")]
		public IEnumerator<KeyValuePair<YamlNode, YamlNode>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xEE6B04", Offset = "0xEE6B04", VA = "0xEE6B04", Slot = "11")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xEE6B08", Offset = "0xEE6B08", VA = "0xEE6B08", Slot = "12")]
		private void YamlDotNet.Serialization.IYamlConvertible.Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xEE6B78", Offset = "0xEE6B78", VA = "0xEE6B78", Slot = "13")]
		private void YamlDotNet.Serialization.IYamlConvertible.Write(IEmitter emitter, ObjectSerializer nestedObjectSerializer)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xEE6BF0", Offset = "0xEE6BF0", VA = "0xEE6BF0")]
		public static YamlMappingNode FromObject(object mapping)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x673900", Offset = "0x673900")]
	public abstract class YamlNode
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E20", Offset = "0x673E20")]
		private sealed class <>c
		{
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, YamlNode> <>9__37_0;

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xCDF6D8", Offset = "0xCDF6D8", VA = "0xCDF6D8")]
			public <>c()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xCDF6E0", Offset = "0xCDF6E0", VA = "0xCDF6E0")]
			internal YamlNode <op_Implicit>b__37_0(string i)
			{
				return null;
			}
		}

		[Token(Token = "0x4000079")]
		private const int MaximumRecursionLevel = 1000;

		[Token(Token = "0x400007A")]
		internal const string MaximumRecursionLevelReachedToStringValue = "WARNING! INFINITE RECURSION!";

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674090", Offset = "0x674090")]
		private string <Anchor>k__BackingField;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6740A0", Offset = "0x6740A0")]
		private string <Tag>k__BackingField;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6740B0", Offset = "0x6740B0")]
		private Mark <Start>k__BackingField;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6740C0", Offset = "0x6740C0")]
		private Mark <End>k__BackingField;

		[Token(Token = "0x1700003A")]
		public string Anchor
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xCDE5C4", Offset = "0xCDE5C4", VA = "0xCDE5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DB8", Offset = "0x674DB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xCDE5CC", Offset = "0xCDE5CC", VA = "0xCDE5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DC8", Offset = "0x674DC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public string Tag
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xCDE5D4", Offset = "0xCDE5D4", VA = "0xCDE5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DD8", Offset = "0x674DD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xCDE5DC", Offset = "0xCDE5DC", VA = "0xCDE5DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DE8", Offset = "0x674DE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Mark Start
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xCDE5E4", Offset = "0xCDE5E4", VA = "0xCDE5E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DF8", Offset = "0x674DF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0xCDE5EC", Offset = "0xCDE5EC", VA = "0xCDE5EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674E08", Offset = "0x674E08")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public Mark End
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0xCDE5F4", Offset = "0xCDE5F4", VA = "0xCDE5F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674E18", Offset = "0x674E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xCDE5FC", Offset = "0xCDE5FC", VA = "0xCDE5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674E28", Offset = "0x674E28")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xCDECDC", Offset = "0xCDECDC", VA = "0xCDECDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public abstract YamlNodeType NodeType
		{
			[Token(Token = "0x6000254")]
			get;
		}

		[Token(Token = "0x17000040")]
		public YamlNode Item
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xCDF34C", Offset = "0xCDF34C", VA = "0xCDF34C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public YamlNode Item
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xCDF4D4", Offset = "0xCDF4D4", VA = "0xCDF4D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xCDE604", Offset = "0xCDE604", VA = "0xCDE604")]
		internal void Load(NodeEvent yamlEvent, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xCDE6E8", Offset = "0xCDE6E8", VA = "0xCDE6E8")]
		internal static YamlNode ParseNode(IParser parser, DocumentLoadingState state)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		internal abstract void ResolveAliases(DocumentLoadingState state);

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xCDEA34", Offset = "0xCDEA34", VA = "0xCDEA34")]
		internal void Save(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000249")]
		internal abstract void Emit(IEmitter emitter, EmitterState state);

		[Token(Token = "0x600024A")]
		public abstract void Accept(IYamlVisitor visitor);

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xCDEBA0", Offset = "0xCDEBA0", VA = "0xCDEBA0")]
		protected bool Equals(YamlNode other)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xCDEC04", Offset = "0xCDEC04", VA = "0xCDEC04")]
		protected static bool SafeEquals(object first, object second)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xCDEC34", Offset = "0xCDEC34", VA = "0xCDEC34", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xCDEC4C", Offset = "0xCDEC4C", VA = "0xCDEC4C")]
		protected static int GetHashCode(object value)
		{
			return default(int);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xCDEC60", Offset = "0xCDEC60", VA = "0xCDEC60")]
		protected static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xCDEC6C", Offset = "0xCDEC6C", VA = "0xCDEC6C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		internal abstract string ToString(RecursionLevel level);

		[Token(Token = "0x6000253")]
		internal abstract IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level);

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xCDED4C", Offset = "0xCDED4C", VA = "0xCDED4C")]
		public static implicit operator YamlNode(string value)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xCDEDDC", Offset = "0xCDEDDC", VA = "0xCDEDDC")]
		public static implicit operator YamlNode(string[] sequence)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xCDF240", Offset = "0xCDF240", VA = "0xCDF240")]
		public static explicit operator string(YamlNode scalar)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xCDF66C", Offset = "0xCDF66C", VA = "0xCDF66C")]
		protected YamlNode()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public sealed class YamlNodeIdentityEqualityComparer : IEqualityComparer<YamlNode>
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xCDF6E8", Offset = "0xCDF6E8", VA = "0xCDF6E8", Slot = "4")]
		public bool Equals(YamlNode x, YamlNode y)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xCDF6F4", Offset = "0xCDF6F4", VA = "0xCDF6F4", Slot = "5")]
		public int GetHashCode(YamlNode obj)
		{
			return default(int);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xCDF728", Offset = "0xCDF728", VA = "0xCDF728")]
		public YamlNodeIdentityEqualityComparer()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public enum YamlNodeType
	{
		[Token(Token = "0x4000080")]
		Alias,
		[Token(Token = "0x4000081")]
		Mapping,
		[Token(Token = "0x4000082")]
		Scalar,
		[Token(Token = "0x4000083")]
		Sequence
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x673938", Offset = "0x673938")]
	public sealed class YamlScalarNode : YamlNode, IYamlConvertible
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E30", Offset = "0x673E30")]
		private sealed class <SafeAllNodes>d__19 : IEnumerable<YamlNode>, IEnumerable, IEnumerator<YamlNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private YamlNode <>2__current;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YamlScalarNode <>4__this;

			[Token(Token = "0x170000E5")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0xCDFDA0", Offset = "0xCDFDA0", VA = "0xCDFDA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0xCDFE10", Offset = "0xCDFE10", VA = "0xCDFE10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xCDFC2C", Offset = "0xCDFC2C", VA = "0xCDFC2C")]
			[DebuggerHidden]
			public <SafeAllNodes>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xCDFD5C", Offset = "0xCDFD5C", VA = "0xCDFD5C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xCDFD60", Offset = "0xCDFD60", VA = "0xCDFD60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xCDFDA8", Offset = "0xCDFDA8", VA = "0xCDFDA8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0xCDFE18", Offset = "0xCDFE18", VA = "0xCDFE18", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xCDFEC8", Offset = "0xCDFEC8", VA = "0xCDFEC8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6740D0", Offset = "0x6740D0")]
		private string <Value>k__BackingField;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6740E0", Offset = "0x6740E0")]
		private ScalarStyle <Style>k__BackingField;

		[Token(Token = "0x17000042")]
		public string Value
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xCDF344", Offset = "0xCDF344", VA = "0xCDF344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674E38", Offset = "0x674E38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xCDF730", Offset = "0xCDF730", VA = "0xCDF730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674E48", Offset = "0x674E48")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0xCDF738", Offset = "0xCDF738", VA = "0xCDF738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674E58", Offset = "0x674E58")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xCDF740", Offset = "0xCDF740", VA = "0xCDF740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674E68", Offset = "0x674E68")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public override YamlNodeType NodeType
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xCDFC64", Offset = "0xCDFC64", VA = "0xCDFC64", Slot = "9")]
			get
			{
				return default(YamlNodeType);
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xCDE964", Offset = "0xCDE964", VA = "0xCDE964")]
		internal YamlScalarNode(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xCDF748", Offset = "0xCDF748", VA = "0xCDF748")]
		private void Load(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xCDF808", Offset = "0xCDF808", VA = "0xCDF808")]
		public YamlScalarNode()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xCDEDB0", Offset = "0xCDEDB0", VA = "0xCDEDB0")]
		public YamlScalarNode(string value)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xCDF810", Offset = "0xCDF810", VA = "0xCDF810", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xCDF884", Offset = "0xCDF884", VA = "0xCDF884", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xCDF990", Offset = "0xCDF990", VA = "0xCDF990", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xCDFA54", Offset = "0xCDFA54", VA = "0xCDFA54", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xCDFB24", Offset = "0xCDFB24", VA = "0xCDFB24", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xCDFB78", Offset = "0xCDFB78", VA = "0xCDFB78")]
		public static explicit operator string(YamlScalarNode value)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xCDFBA0", Offset = "0xCDFBA0", VA = "0xCDFBA0", Slot = "7")]
		internal override string ToString(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xCDFBA8", Offset = "0xCDFBA8", VA = "0xCDFBA8", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x674E78", Offset = "0x674E78")]
		internal override IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xCDFC6C", Offset = "0xCDFC6C", VA = "0xCDFC6C", Slot = "10")]
		private void YamlDotNet.Serialization.IYamlConvertible.Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xCDFCE0", Offset = "0xCDFCE0", VA = "0xCDFCE0", Slot = "11")]
		private void YamlDotNet.Serialization.IYamlConvertible.Write(IEmitter emitter, ObjectSerializer nestedObjectSerializer)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x673970", Offset = "0x673970")]
	public sealed class YamlSequenceNode : YamlNode, IEnumerable<YamlNode>, IEnumerable, IYamlConvertible
	{
		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E40", Offset = "0x673E40")]
		private sealed class <SafeAllNodes>d__19 : IEnumerable<YamlNode>, IEnumerable, IEnumerator<YamlNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private YamlNode <>2__current;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RecursionLevel level;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RecursionLevel <>3__level;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public YamlSequenceNode <>4__this;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator<YamlNode> <>7__wrap1;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private IEnumerator<YamlNode> <>7__wrap2;

			[Token(Token = "0x170000E7")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x600060A")]
				[Address(RVA = "0xCE1E48", Offset = "0xCE1E48", VA = "0xCE1E48", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600060C")]
				[Address(RVA = "0xCE1EB8", Offset = "0xCE1EB8", VA = "0xCE1EB8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xCE11FC", Offset = "0xCE11FC", VA = "0xCE11FC")]
			[DebuggerHidden]
			public <SafeAllNodes>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xCE17B8", Offset = "0xCE17B8", VA = "0xCE17B8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0xCE19B0", Offset = "0xCE19B0", VA = "0xCE19B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0xCE18F0", Offset = "0xCE18F0", VA = "0xCE18F0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0xCE1830", Offset = "0xCE1830", VA = "0xCE1830")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0xCE1E50", Offset = "0xCE1E50", VA = "0xCE1E50", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0xCE1EC0", Offset = "0xCE1EC0", VA = "0xCE1EC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xCE1F80", Offset = "0xCE1F80", VA = "0xCE1F80", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IList<YamlNode> children;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6740F0", Offset = "0x6740F0")]
		private SequenceStyle <Style>k__BackingField;

		[Token(Token = "0x17000045")]
		public IList<YamlNode> Children
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xCDF4CC", Offset = "0xCDF4CC", VA = "0xCDF4CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public SequenceStyle Style
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xCDFECC", Offset = "0xCDFECC", VA = "0xCDFECC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674EDC", Offset = "0x674EDC")]
			get
			{
				return default(SequenceStyle);
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xCDFED4", Offset = "0xCDFED4", VA = "0xCDFED4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674EEC", Offset = "0x674EEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override YamlNodeType NodeType
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xCE1234", Offset = "0xCE1234", VA = "0xCE1234", Slot = "9")]
			get
			{
				return default(YamlNodeType);
			}
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xCDE9A4", Offset = "0xCDE9A4", VA = "0xCDE9A4")]
		internal YamlSequenceNode(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xCDFEDC", Offset = "0xCDFEDC", VA = "0xCDFEDC")]
		private void Load(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xCE00C0", Offset = "0xCE00C0", VA = "0xCE00C0")]
		public YamlSequenceNode()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xCE0130", Offset = "0xCE0130", VA = "0xCE0130")]
		public YamlSequenceNode(params YamlNode[] children)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xCDEEF4", Offset = "0xCDEEF4", VA = "0xCDEEF4")]
		public YamlSequenceNode(IEnumerable<YamlNode> children)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xCE0134", Offset = "0xCE0134", VA = "0xCE0134")]
		public void Add(YamlNode child)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xCE01FC", Offset = "0xCE01FC", VA = "0xCE01FC")]
		public void Add(string child)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xCE02E4", Offset = "0xCE02E4", VA = "0xCE02E4", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xCE06B8", Offset = "0xCE06B8", VA = "0xCE06B8", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xCE0A94", Offset = "0xCE0A94", VA = "0xCE0A94", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xCE0B58", Offset = "0xCE0B58", VA = "0xCE0B58", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xCE0EA8", Offset = "0xCE0EA8", VA = "0xCE0EA8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xCE1154", Offset = "0xCE1154", VA = "0xCE1154", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x674EFC", Offset = "0x674EFC")]
		internal override IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xCE123C", Offset = "0xCE123C", VA = "0xCE123C", Slot = "7")]
		internal override string ToString(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xCE1610", Offset = "0xCE1610", VA = "0xCE1610", Slot = "10")]
		public IEnumerator<YamlNode> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xCE16C4", Offset = "0xCE16C4", VA = "0xCE16C4", Slot = "11")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xCE16C8", Offset = "0xCE16C8", VA = "0xCE16C8", Slot = "12")]
		private void YamlDotNet.Serialization.IYamlConvertible.Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xCE173C", Offset = "0xCE173C", VA = "0xCE173C", Slot = "13")]
		private void YamlDotNet.Serialization.IYamlConvertible.Write(IEmitter emitter, ObjectSerializer nestedObjectSerializer)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class YamlStream : IEnumerable<YamlDocument>, IEnumerable
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IList<YamlDocument> documents;

		[Token(Token = "0x17000048")]
		public IList<YamlDocument> Documents
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0xCE1F84", Offset = "0xCE1F84", VA = "0xCE1F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xCE1F8C", Offset = "0xCE1F8C", VA = "0xCE1F8C")]
		public YamlStream()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xCE1FFC", Offset = "0xCE1FFC", VA = "0xCE1FFC")]
		public YamlStream(params YamlDocument[] documents)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xCE2000", Offset = "0xCE2000", VA = "0xCE2000")]
		public YamlStream(IEnumerable<YamlDocument> documents)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xCE234C", Offset = "0xCE234C", VA = "0xCE234C")]
		public void Add(YamlDocument document)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xCE2414", Offset = "0xCE2414", VA = "0xCE2414")]
		public void Load(TextReader input)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xCE2488", Offset = "0xCE2488", VA = "0xCE2488")]
		public void Load(IParser parser)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xCE2644", Offset = "0xCE2644", VA = "0xCE2644")]
		public void Save(TextWriter output)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xCE264C", Offset = "0xCE264C", VA = "0xCE264C")]
		public void Save(TextWriter output, bool assignAnchors)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xCE2A38", Offset = "0xCE2A38", VA = "0xCE2A38")]
		public void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xCE2AF8", Offset = "0xCE2AF8", VA = "0xCE2AF8", Slot = "4")]
		public IEnumerator<YamlDocument> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xCE2BAC", Offset = "0xCE2BAC", VA = "0xCE2BAC", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6739A8", Offset = "0x6739A8")]
	public abstract class YamlVisitor : IYamlVisitor
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xCE2BB0", Offset = "0xCE2BB0", VA = "0xCE2BB0", Slot = "9")]
		protected virtual void Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xCE2BB4", Offset = "0xCE2BB4", VA = "0xCE2BB4", Slot = "10")]
		protected virtual void Visited(YamlStream stream)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xCE2BB8", Offset = "0xCE2BB8", VA = "0xCE2BB8", Slot = "11")]
		protected virtual void Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xCE2BBC", Offset = "0xCE2BBC", VA = "0xCE2BBC", Slot = "12")]
		protected virtual void Visited(YamlDocument document)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xCE2BC0", Offset = "0xCE2BC0", VA = "0xCE2BC0", Slot = "13")]
		protected virtual void Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xCE2BC4", Offset = "0xCE2BC4", VA = "0xCE2BC4", Slot = "14")]
		protected virtual void Visited(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xCE2BC8", Offset = "0xCE2BC8", VA = "0xCE2BC8", Slot = "15")]
		protected virtual void Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xCE2BCC", Offset = "0xCE2BCC", VA = "0xCE2BCC", Slot = "16")]
		protected virtual void Visited(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xCE2BD0", Offset = "0xCE2BD0", VA = "0xCE2BD0", Slot = "17")]
		protected virtual void Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xCE2BD4", Offset = "0xCE2BD4", VA = "0xCE2BD4", Slot = "18")]
		protected virtual void Visited(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xCE2BD8", Offset = "0xCE2BD8", VA = "0xCE2BD8", Slot = "19")]
		protected virtual void VisitChildren(YamlStream stream)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xCE2E90", Offset = "0xCE2E90", VA = "0xCE2E90", Slot = "20")]
		protected virtual void VisitChildren(YamlDocument document)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xCE2F0C", Offset = "0xCE2F0C", VA = "0xCE2F0C", Slot = "21")]
		protected virtual void VisitChildren(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xCE31C8", Offset = "0xCE31C8", VA = "0xCE31C8", Slot = "22")]
		protected virtual void VisitChildren(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xCE34EC", Offset = "0xCE34EC", VA = "0xCE34EC", Slot = "4")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xCE3540", Offset = "0xCE3540", VA = "0xCE3540", Slot = "5")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xCE3594", Offset = "0xCE3594", VA = "0xCE3594", Slot = "6")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xCE35D4", Offset = "0xCE35D4", VA = "0xCE35D4", Slot = "7")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xCE3630", Offset = "0xCE3630", VA = "0xCE3630", Slot = "8")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xCE368C", Offset = "0xCE368C", VA = "0xCE368C")]
		protected YamlVisitor()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public abstract class YamlVisitorBase : IYamlVisitor
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xCE3694", Offset = "0xCE3694", VA = "0xCE3694", Slot = "9")]
		public virtual void Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xCE36A4", Offset = "0xCE36A4", VA = "0xCE36A4", Slot = "10")]
		public virtual void Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xCE36B4", Offset = "0xCE36B4", VA = "0xCE36B4", Slot = "11")]
		public virtual void Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xCE36B8", Offset = "0xCE36B8", VA = "0xCE36B8", Slot = "12")]
		public virtual void Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xCE36C8", Offset = "0xCE36C8", VA = "0xCE36C8", Slot = "13")]
		public virtual void Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xCE36D8", Offset = "0xCE36D8", VA = "0xCE36D8", Slot = "14")]
		protected virtual void VisitPair(YamlNode key, YamlNode value)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xCE3740", Offset = "0xCE3740", VA = "0xCE3740", Slot = "15")]
		protected virtual void VisitChildren(YamlStream stream)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xCE39F8", Offset = "0xCE39F8", VA = "0xCE39F8", Slot = "16")]
		protected virtual void VisitChildren(YamlDocument document)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xCE3A74", Offset = "0xCE3A74", VA = "0xCE3A74", Slot = "17")]
		protected virtual void VisitChildren(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xCE3D30", Offset = "0xCE3D30", VA = "0xCE3D30", Slot = "18")]
		protected virtual void VisitChildren(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xCE402C", Offset = "0xCE402C", VA = "0xCE402C")]
		protected YamlVisitorBase()
		{
		}
	}
}
namespace YamlDotNet.Helpers
{
	[Token(Token = "0x200007D")]
	public static class ExpressionExtensions
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xEE00A0", Offset = "0xEE00A0", VA = "0xEE00A0")]
		public static PropertyInfo AsProperty(this LambdaExpression propertyAccessor)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		private static TMemberInfo TryGetMemberExpression<TMemberInfo>(LambdaExpression lambdaExpression) where TMemberInfo : MemberInfo
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6739F0", Offset = "0x6739F0")]
	internal sealed class GenericCollectionToNonGenericAdapter : IList, ICollection, IEnumerable
	{
		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object genericCollection;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly MethodInfo addMethod;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly MethodInfo indexerSetter;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly MethodInfo countGetter;

		[Token(Token = "0x17000049")]
		public bool IsFixedSize
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xEE0664", Offset = "0xEE0664", VA = "0xEE0664", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xEE06CC", Offset = "0xEE06CC", VA = "0xEE06CC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public object Item
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xEE0804", Offset = "0xEE0804", VA = "0xEE0804", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xEE086C", Offset = "0xEE086C", VA = "0xEE086C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public int Count
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xEE0A28", Offset = "0xEE0A28", VA = "0xEE0A28", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xEE0A90", Offset = "0xEE0A90", VA = "0xEE0A90", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public object SyncRoot
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xEE0AF8", Offset = "0xEE0AF8", VA = "0xEE0AF8", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xEE015C", Offset = "0xEE015C", VA = "0xEE015C")]
		public GenericCollectionToNonGenericAdapter(object genericCollection, Type genericCollectionType, Type genericListType)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xEE0340", Offset = "0xEE0340", VA = "0xEE0340", Slot = "6")]
		public int Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xEE04C4", Offset = "0xEE04C4", VA = "0xEE04C4", Slot = "8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xEE052C", Offset = "0xEE052C", VA = "0xEE052C", Slot = "7")]
		public bool Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xEE0594", Offset = "0xEE0594", VA = "0xEE0594", Slot = "11")]
		public int IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xEE05FC", Offset = "0xEE05FC", VA = "0xEE05FC", Slot = "12")]
		public void Insert(int index, object value)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xEE0734", Offset = "0xEE0734", VA = "0xEE0734", Slot = "13")]
		public void Remove(object value)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xEE079C", Offset = "0xEE079C", VA = "0xEE079C", Slot = "14")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xEE09C0", Offset = "0xEE09C0", VA = "0xEE09C0", Slot = "15")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xEE0B60", Offset = "0xEE0B60", VA = "0xEE0B60", Slot = "19")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x673A28", Offset = "0x673A28")]
	internal sealed class GenericDictionaryToNonGenericAdapter : IDictionary, ICollection, IEnumerable
	{
		[Token(Token = "0x200011A")]
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IEnumerator enumerator;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly MethodInfo getKeyMethod;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly MethodInfo getValueMethod;

			[Token(Token = "0x170000E9")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6000610")]
				[Address(RVA = "0xEE18F4", Offset = "0xEE18F4", VA = "0xEE18F4", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Token(Token = "0x170000EA")]
			public object Key
			{
				[Token(Token = "0x6000611")]
				[Address(RVA = "0xEE1944", Offset = "0xEE1944", VA = "0xEE1944", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			public object Value
			{
				[Token(Token = "0x6000612")]
				[Address(RVA = "0xEE1A20", Offset = "0xEE1A20", VA = "0xEE1A20", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			public object Current
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0xEE1B00", Offset = "0xEE1B00", VA = "0xEE1B00", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0xEE0F50", Offset = "0xEE0F50", VA = "0xEE0F50")]
			public DictionaryEnumerator(object genericDictionary, Type genericDictionaryType)
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0xEE1B6C", Offset = "0xEE1B6C", VA = "0xEE1B6C", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0xEE1C20", Offset = "0xEE1C20", VA = "0xEE1C20", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object genericDictionary;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Type genericDictionaryType;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly MethodInfo indexerSetter;

		[Token(Token = "0x1700004F")]
		public bool IsFixedSize
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xEE1234", Offset = "0xEE1234", VA = "0xEE1234", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xEE129C", Offset = "0xEE129C", VA = "0xEE129C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public ICollection Keys
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xEE1304", Offset = "0xEE1304", VA = "0xEE1304", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public ICollection Values
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xEE13D4", Offset = "0xEE13D4", VA = "0xEE13D4", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public object Item
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xEE143C", Offset = "0xEE143C", VA = "0xEE143C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xEE14A4", Offset = "0xEE14A4", VA = "0xEE14A4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public int Count
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xEE163C", Offset = "0xEE163C", VA = "0xEE163C", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xEE16A4", Offset = "0xEE16A4", VA = "0xEE16A4", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public object SyncRoot
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xEE170C", Offset = "0xEE170C", VA = "0xEE170C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xEE0CE0", Offset = "0xEE0CE0", VA = "0xEE0CE0")]
		public GenericDictionaryToNonGenericAdapter(object genericDictionary, Type genericDictionaryType)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xEE0DA4", Offset = "0xEE0DA4", VA = "0xEE0DA4", Slot = "13")]
		public void Add(object key, object value)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xEE0E0C", Offset = "0xEE0E0C", VA = "0xEE0E0C", Slot = "14")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xEE0E74", Offset = "0xEE0E74", VA = "0xEE0E74", Slot = "15")]
		public bool Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xEE0EDC", Offset = "0xEE0EDC", VA = "0xEE0EDC", Slot = "6")]
		public IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xEE136C", Offset = "0xEE136C", VA = "0xEE136C", Slot = "7")]
		public void Remove(object key)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xEE15D4", Offset = "0xEE15D4", VA = "0xEE15D4", Slot = "8")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xEE1774", Offset = "0xEE1774", VA = "0xEE1774", Slot = "12")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
namespace YamlDotNet.Samples
{
	[Token(Token = "0x2000080")]
	public class ConvertYamlToJson
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITestOutputHelper output;

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xCE406C", Offset = "0xCE406C", VA = "0xCE406C")]
		public ConvertYamlToJson(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xCE4098", Offset = "0xCE4098", VA = "0xCE4098")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x674F70", Offset = "0x674F70")]
		public void Main()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class DeserializeObjectGraph
	{
		[Token(Token = "0x200011B")]
		public class Order
		{
			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674400", Offset = "0x674400")]
			private string <Receipt>k__BackingField;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674410", Offset = "0x674410")]
			private DateTime <Date>k__BackingField;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674420", Offset = "0x674420")]
			private Customer <Customer>k__BackingField;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674430", Offset = "0x674430")]
			private List<OrderItem> <Items>k__BackingField;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674440", Offset = "0x674440")]
			private Address <BillTo>k__BackingField;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674450", Offset = "0x674450")]
			private Address <ShipTo>k__BackingField;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674460", Offset = "0x674460")]
			private string <SpecialDelivery>k__BackingField;

			[Token(Token = "0x170000ED")]
			public string Receipt
			{
				[Token(Token = "0x6000616")]
				[Address(RVA = "0xCE7138", Offset = "0xCE7138", VA = "0xCE7138")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675AB4", Offset = "0x675AB4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000617")]
				[Address(RVA = "0xCE7140", Offset = "0xCE7140", VA = "0xCE7140")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675AC4", Offset = "0x675AC4")]
				set
				{
				}
			}

			[Token(Token = "0x170000EE")]
			public DateTime Date
			{
				[Token(Token = "0x6000618")]
				[Address(RVA = "0xCE7148", Offset = "0xCE7148", VA = "0xCE7148")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675AD4", Offset = "0x675AD4")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x6000619")]
				[Address(RVA = "0xCE7150", Offset = "0xCE7150", VA = "0xCE7150")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675AE4", Offset = "0x675AE4")]
				set
				{
				}
			}

			[Token(Token = "0x170000EF")]
			public Customer Customer
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0xCE7158", Offset = "0xCE7158", VA = "0xCE7158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675AF4", Offset = "0x675AF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600061B")]
				[Address(RVA = "0xCE7160", Offset = "0xCE7160", VA = "0xCE7160")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B04", Offset = "0x675B04")]
				set
				{
				}
			}

			[Token(Token = "0x170000F0")]
			public List<OrderItem> Items
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0xCE7094", Offset = "0xCE7094", VA = "0xCE7094")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B14", Offset = "0x675B14")]
				get
				{
					return null;
				}
				[Token(Token = "0x600061D")]
				[Address(RVA = "0xCE7168", Offset = "0xCE7168", VA = "0xCE7168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B24", Offset = "0x675B24")]
				set
				{
				}
			}

			[Token(Token = "0x170000F1")]
			[AttributeAttribute(Name = "YamlMemberAttribute", RVA = "0x675DF4", Offset = "0x675DF4")]
			public Address BillTo
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0xCE70E0", Offset = "0xCE70E0", VA = "0xCE70E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B34", Offset = "0x675B34")]
				get
				{
					return null;
				}
				[Token(Token = "0x600061F")]
				[Address(RVA = "0xCE7170", Offset = "0xCE7170", VA = "0xCE7170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B44", Offset = "0x675B44")]
				set
				{
				}
			}

			[Token(Token = "0x170000F2")]
			[AttributeAttribute(Name = "YamlMemberAttribute", RVA = "0x675E48", Offset = "0x675E48")]
			public Address ShipTo
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0xCE70C0", Offset = "0xCE70C0", VA = "0xCE70C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B54", Offset = "0x675B54")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000621")]
				[Address(RVA = "0xCE7178", Offset = "0xCE7178", VA = "0xCE7178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B64", Offset = "0x675B64")]
				set
				{
				}
			}

			[Token(Token = "0x170000F3")]
			public string SpecialDelivery
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0xCE70E8", Offset = "0xCE70E8", VA = "0xCE70E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B74", Offset = "0x675B74")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000623")]
				[Address(RVA = "0xCE7180", Offset = "0xCE7180", VA = "0xCE7180")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B84", Offset = "0x675B84")]
				set
				{
				}
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0xCE7188", Offset = "0xCE7188", VA = "0xCE7188")]
			public Order()
			{
			}
		}

		[Token(Token = "0x200011C")]
		public class Customer
		{
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674470", Offset = "0x674470")]
			private string <Given>k__BackingField;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674480", Offset = "0x674480")]
			private string <Family>k__BackingField;

			[Token(Token = "0x170000F4")]
			public string Given
			{
				[Token(Token = "0x6000625")]
				[Address(RVA = "0xCE7110", Offset = "0xCE7110", VA = "0xCE7110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675B94", Offset = "0x675B94")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000626")]
				[Address(RVA = "0xCE7118", Offset = "0xCE7118", VA = "0xCE7118")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675BA4", Offset = "0x675BA4")]
				set
				{
				}
			}

			[Token(Token = "0x170000F5")]
			public string Family
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0xCE7120", Offset = "0xCE7120", VA = "0xCE7120")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675BB4", Offset = "0x675BB4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000628")]
				[Address(RVA = "0xCE7128", Offset = "0xCE7128", VA = "0xCE7128")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675BC4", Offset = "0x675BC4")]
				set
				{
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0xCE7130", Offset = "0xCE7130", VA = "0xCE7130")]
			public Customer()
			{
			}
		}

		[Token(Token = "0x200011D")]
		public class OrderItem
		{
			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674490", Offset = "0x674490")]
			private string <PartNo>k__BackingField;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744A0", Offset = "0x6744A0")]
			private string <Descrip>k__BackingField;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744B0", Offset = "0x6744B0")]
			private decimal <Price>k__BackingField;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744C0", Offset = "0x6744C0")]
			private int <Quantity>k__BackingField;

			[Token(Token = "0x170000F6")]
			[AttributeAttribute(Name = "YamlMemberAttribute", RVA = "0x675E9C", Offset = "0x675E9C")]
			public string PartNo
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0xCE709C", Offset = "0xCE709C", VA = "0xCE709C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675BD4", Offset = "0x675BD4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600062B")]
				[Address(RVA = "0xCE7190", Offset = "0xCE7190", VA = "0xCE7190")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675BE4", Offset = "0x675BE4")]
				set
				{
				}
			}

			[Token(Token = "0x170000F7")]
			public string Descrip
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0xCE70B8", Offset = "0xCE70B8", VA = "0xCE70B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675BF4", Offset = "0x675BF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600062D")]
				[Address(RVA = "0xCE7198", Offset = "0xCE7198", VA = "0xCE7198")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C04", Offset = "0x675C04")]
				set
				{
				}
			}

			[Token(Token = "0x170000F8")]
			public decimal Price
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0xCE70AC", Offset = "0xCE70AC", VA = "0xCE70AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C14", Offset = "0x675C14")]
				get
				{
					return default(decimal);
				}
				[Token(Token = "0x600062F")]
				[Address(RVA = "0xCE71A0", Offset = "0xCE71A0", VA = "0xCE71A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C24", Offset = "0x675C24")]
				set
				{
				}
			}

			[Token(Token = "0x170000F9")]
			public int Quantity
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0xCE70A4", Offset = "0xCE70A4", VA = "0xCE70A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C34", Offset = "0x675C34")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000631")]
				[Address(RVA = "0xCE71A8", Offset = "0xCE71A8", VA = "0xCE71A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C44", Offset = "0x675C44")]
				set
				{
				}
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0xCE71B0", Offset = "0xCE71B0", VA = "0xCE71B0")]
			public OrderItem()
			{
			}
		}

		[Token(Token = "0x200011E")]
		public class Address
		{
			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744D0", Offset = "0x6744D0")]
			private string <Street>k__BackingField;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744E0", Offset = "0x6744E0")]
			private string <City>k__BackingField;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744F0", Offset = "0x6744F0")]
			private string <State>k__BackingField;

			[Token(Token = "0x170000FA")]
			public string Street
			{
				[Token(Token = "0x6000633")]
				[Address(RVA = "0xCE70C8", Offset = "0xCE70C8", VA = "0xCE70C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C54", Offset = "0x675C54")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000634")]
				[Address(RVA = "0xCE70F0", Offset = "0xCE70F0", VA = "0xCE70F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C64", Offset = "0x675C64")]
				set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			public string City
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0xCE70D0", Offset = "0xCE70D0", VA = "0xCE70D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C74", Offset = "0x675C74")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000636")]
				[Address(RVA = "0xCE70F8", Offset = "0xCE70F8", VA = "0xCE70F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C84", Offset = "0x675C84")]
				set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			public string State
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0xCE70D8", Offset = "0xCE70D8", VA = "0xCE70D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675C94", Offset = "0x675C94")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000638")]
				[Address(RVA = "0xCE7100", Offset = "0xCE7100", VA = "0xCE7100")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675CA4", Offset = "0x675CA4")]
				set
				{
				}
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0xCE7108", Offset = "0xCE7108", VA = "0xCE7108")]
			public Address()
			{
			}
		}

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITestOutputHelper output;

		[Token(Token = "0x4000092")]
		private const string Document = "---\n            receipt:    Oz-Ware Purchase Invoice\n            date:        2007-08-06\n            customer:\n                given:   Dorothy\n                family:  Gale\n\n            items:\n                - part_no:   A4786\n                  descrip:   Water Bucket (Filled)\n                  price:     1.47\n                  quantity:  4\n\n                - part_no:   E1628\n                  descrip:   High Heeled \"Ruby\" Slippers\n                  price:     100.27\n                  quantity:  1\n\n            bill-to:  &id001\n                street: |-\n                        123 Tornado Alley\n                        Suite 16\n                city:   East Westville\n                state:  KS\n\n            ship-to:  *id001\n\n            specialDelivery: >\n                Follow the Yellow Brick\n                Road to the Emerald City.\n                Pay no attention to the\n                man behind the curtain.\n...";

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xCE6060", Offset = "0xCE6060", VA = "0xCE6060")]
		public DeserializeObjectGraph(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xCE608C", Offset = "0xCE608C", VA = "0xCE608C")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x674FD0", Offset = "0x674FD0")]
		public void Main()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class DeserializingMultipleDocuments
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITestOutputHelper output;

		[Token(Token = "0x4000094")]
		private const string Document = "---\n- Prisoner\n- Goblet\n- Phoenix\n---\n- Memoirs\n- Snow \n- Ghost\t\t\n...";

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xCE71B8", Offset = "0xCE71B8", VA = "0xCE71B8")]
		public DeserializingMultipleDocuments(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xCE71E4", Offset = "0xCE71E4", VA = "0xCE71E4")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x675030", Offset = "0x675030")]
		public void Main()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class LoadingAYamlStream
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITestOutputHelper output;

		[Token(Token = "0x4000096")]
		private const string Document = "---\n            receipt:    Oz-Ware Purchase Invoice\n            date:        2007-08-06\n            customer:\n                given:   Dorothy\n                family:  Gale\n\n            items:\n                - part_no:   A4786\n                  descrip:   Water Bucket (Filled)\n                  price:     1.47\n                  quantity:  4\n\n                - part_no:   E1628\n                  descrip:   High Heeled \"Ruby\" Slippers\n                  price:     100.27\n                  quantity:  1\n\n            bill-to:  &id001\n                street: |\n                        123 Tornado Alley\n                        Suite 16\n                city:   East Westville\n                state:  KS\n\n            ship-to:  *id001\n\n            specialDelivery:  >\n                Follow the Yellow Brick\n                Road to the Emerald City.\n                Pay no attention to the\n                man behind the curtain.\n...";

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xCE84CC", Offset = "0xCE84CC", VA = "0xCE84CC")]
		public LoadingAYamlStream(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xCE84F8", Offset = "0xCE84F8", VA = "0xCE84F8")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x675090", Offset = "0x675090")]
		public void Main()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class SerializeObjectGraph
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITestOutputHelper output;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xCE9250", Offset = "0xCE9250", VA = "0xCE9250")]
		public SerializeObjectGraph(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xCE927C", Offset = "0xCE927C", VA = "0xCE927C")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x6750F0", Offset = "0x6750F0")]
		public void Main()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class Address
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674100", Offset = "0x674100")]
		private string <street>k__BackingField;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674110", Offset = "0x674110")]
		private string <city>k__BackingField;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674120", Offset = "0x674120")]
		private string <state>k__BackingField;

		[Token(Token = "0x17000057")]
		public string street
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xCE4034", Offset = "0xCE4034", VA = "0xCE4034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675150", Offset = "0x675150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xCE403C", Offset = "0xCE403C", VA = "0xCE403C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675160", Offset = "0x675160")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public string city
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xCE4044", Offset = "0xCE4044", VA = "0xCE4044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675170", Offset = "0x675170")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xCE404C", Offset = "0xCE404C", VA = "0xCE404C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675180", Offset = "0x675180")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public string state
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xCE4054", Offset = "0xCE4054", VA = "0xCE4054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675190", Offset = "0x675190")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xCE405C", Offset = "0xCE405C", VA = "0xCE405C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751A0", Offset = "0x6751A0")]
			set
			{
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xCE4064", Offset = "0xCE4064", VA = "0xCE4064")]
		public Address()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class Receipt
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674130", Offset = "0x674130")]
		private string <receipt>k__BackingField;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674140", Offset = "0x674140")]
		private DateTime <date>k__BackingField;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674150", Offset = "0x674150")]
		private Customer <customer>k__BackingField;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674160", Offset = "0x674160")]
		private Item[] <items>k__BackingField;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674170", Offset = "0x674170")]
		private Address <bill_to>k__BackingField;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674180", Offset = "0x674180")]
		private Address <ship_to>k__BackingField;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674190", Offset = "0x674190")]
		private string <specialDelivery>k__BackingField;

		[Token(Token = "0x1700005A")]
		public string receipt
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xCE91D8", Offset = "0xCE91D8", VA = "0xCE91D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751B0", Offset = "0x6751B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xCE91E0", Offset = "0xCE91E0", VA = "0xCE91E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751C0", Offset = "0x6751C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public DateTime date
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xCE91E8", Offset = "0xCE91E8", VA = "0xCE91E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751D0", Offset = "0x6751D0")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xCE91F0", Offset = "0xCE91F0", VA = "0xCE91F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751E0", Offset = "0x6751E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public Customer customer
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xCE91F8", Offset = "0xCE91F8", VA = "0xCE91F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751F0", Offset = "0x6751F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xCE9200", Offset = "0xCE9200", VA = "0xCE9200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675200", Offset = "0x675200")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public Item[] items
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xCE9208", Offset = "0xCE9208", VA = "0xCE9208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675210", Offset = "0x675210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xCE9210", Offset = "0xCE9210", VA = "0xCE9210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675220", Offset = "0x675220")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Address bill_to
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xCE9218", Offset = "0xCE9218", VA = "0xCE9218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675230", Offset = "0x675230")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xCE9220", Offset = "0xCE9220", VA = "0xCE9220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675240", Offset = "0x675240")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Address ship_to
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xCE9228", Offset = "0xCE9228", VA = "0xCE9228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675250", Offset = "0x675250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xCE9230", Offset = "0xCE9230", VA = "0xCE9230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675260", Offset = "0x675260")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public string specialDelivery
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xCE9238", Offset = "0xCE9238", VA = "0xCE9238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675270", Offset = "0x675270")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xCE9240", Offset = "0xCE9240", VA = "0xCE9240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675280", Offset = "0x675280")]
			set
			{
			}
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xCE9248", Offset = "0xCE9248", VA = "0xCE9248")]
		public Receipt()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class Customer
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741A0", Offset = "0x6741A0")]
		private string <given>k__BackingField;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741B0", Offset = "0x6741B0")]
		private string <family>k__BackingField;

		[Token(Token = "0x17000061")]
		public string given
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xCE6038", Offset = "0xCE6038", VA = "0xCE6038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675290", Offset = "0x675290")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xCE6040", Offset = "0xCE6040", VA = "0xCE6040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6752A0", Offset = "0x6752A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public string family
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xCE6048", Offset = "0xCE6048", VA = "0xCE6048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6752B0", Offset = "0x6752B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xCE6050", Offset = "0xCE6050", VA = "0xCE6050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6752C0", Offset = "0x6752C0")]
			set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xCE6058", Offset = "0xCE6058", VA = "0xCE6058")]
		public Customer()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class Item
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741C0", Offset = "0x6741C0")]
		private string <part_no>k__BackingField;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741D0", Offset = "0x6741D0")]
		private string <descrip>k__BackingField;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741E0", Offset = "0x6741E0")]
		private decimal <price>k__BackingField;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741F0", Offset = "0x6741F0")]
		private int <quantity>k__BackingField;

		[Token(Token = "0x17000063")]
		public string part_no
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xCE8480", Offset = "0xCE8480", VA = "0xCE8480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6752D0", Offset = "0x6752D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xCE8488", Offset = "0xCE8488", VA = "0xCE8488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6752E0", Offset = "0x6752E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public string descrip
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xCE8490", Offset = "0xCE8490", VA = "0xCE8490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6752F0", Offset = "0x6752F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xCE8498", Offset = "0xCE8498", VA = "0xCE8498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675300", Offset = "0x675300")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public decimal price
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xCE84A0", Offset = "0xCE84A0", VA = "0xCE84A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675310", Offset = "0x675310")]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xCE84AC", Offset = "0xCE84AC", VA = "0xCE84AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675320", Offset = "0x675320")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public int quantity
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xCE84B4", Offset = "0xCE84B4", VA = "0xCE84B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675330", Offset = "0x675330")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xCE84BC", Offset = "0xCE84BC", VA = "0xCE84BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675340", Offset = "0x675340")]
			set
			{
			}
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xCE84C4", Offset = "0xCE84C4", VA = "0xCE84C4")]
		public Item()
		{
		}
	}
}
namespace YamlDotNet.Samples.Helpers
{
	[Token(Token = "0x2000089")]
	public class ExampleRunner : MonoBehaviour
	{
		[Token(Token = "0x200011F")]
		private class StringTestOutputHelper : ITestOutputHelper
		{
			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder output;

			[Token(Token = "0x600063A")]
			[Address(RVA = "0xCE828C", Offset = "0xCE828C", VA = "0xCE828C", Slot = "4")]
			public void WriteLine()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0xCE82BC", Offset = "0xCE82BC", VA = "0xCE82BC", Slot = "5")]
			public void WriteLine(string value)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0xCE80E0", Offset = "0xCE80E0", VA = "0xCE80E0", Slot = "6")]
			public void WriteLine(string format, params object[] args)
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0xCE82F4", Offset = "0xCE82F4", VA = "0xCE82F4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0xCE8148", Offset = "0xCE8148", VA = "0xCE8148")]
			public void Clear()
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xCE8224", Offset = "0xCE8224", VA = "0xCE8224")]
			public StringTestOutputHelper()
			{
			}
		}

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringTestOutputHelper helper;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] disabledTests;

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xCE7534", Offset = "0xCE7534", VA = "0xCE7534")]
		public static string[] GetAllTestNames()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xCE7844", Offset = "0xCE7844", VA = "0xCE7844")]
		public static string[] GetAllTestTitles()
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xCE7B40", Offset = "0xCE7B40", VA = "0xCE7B40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xCE81A8", Offset = "0xCE81A8", VA = "0xCE81A8")]
		public ExampleRunner()
		{
		}
	}
	[Token(Token = "0x200008A")]
	internal class SampleAttribute : Attribute
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string title;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674200", Offset = "0x674200")]
		private string <DisplayName>k__BackingField;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674210", Offset = "0x674210")]
		private string <Description>k__BackingField;

		[Token(Token = "0x17000067")]
		public string DisplayName
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xCE8328", Offset = "0xCE8328", VA = "0xCE8328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675350", Offset = "0x675350")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0xCE8330", Offset = "0xCE8330", VA = "0xCE8330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675360", Offset = "0x675360")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public string Title
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xCE7B38", Offset = "0xCE7B38", VA = "0xCE7B38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xCE8338", Offset = "0xCE8338", VA = "0xCE8338")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public string Description
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xCE80D8", Offset = "0xCE80D8", VA = "0xCE80D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675370", Offset = "0x675370")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xCE83A4", Offset = "0xCE83A4", VA = "0xCE83A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675380", Offset = "0x675380")]
			set
			{
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xCE83AC", Offset = "0xCE83AC", VA = "0xCE83AC")]
		public SampleAttribute()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public static class TestOutputHelperExtensions
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xCE83B4", Offset = "0xCE83B4", VA = "0xCE83B4")]
		public static void WriteLine(this ITestOutputHelper output)
		{
		}
	}
	[Token(Token = "0x200008C")]
	public interface ITestOutputHelper
	{
		[Token(Token = "0x6000310")]
		void WriteLine();

		[Token(Token = "0x6000311")]
		void WriteLine(string value);

		[Token(Token = "0x6000312")]
		void WriteLine(string format, params object[] args);
	}
}
namespace YamlDotNet.Core
{
	[Serializable]
	[Token(Token = "0x200008D")]
	public class AnchorNotFoundException : YamlException
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xEC98DC", Offset = "0xEC98DC", VA = "0xEC98DC")]
		public AnchorNotFoundException()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xEC9948", Offset = "0xEC9948", VA = "0xEC9948")]
		public AnchorNotFoundException(string message)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xEC99C4", Offset = "0xEC99C4", VA = "0xEC99C4")]
		public AnchorNotFoundException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xEC99D4", Offset = "0xEC99D4", VA = "0xEC99D4")]
		public AnchorNotFoundException(string message, Exception inner)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	internal class CharacterAnalyzer<TBuffer> where TBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TBuffer buffer;

		[Token(Token = "0x1700006A")]
		public TBuffer Buffer
		{
			[Token(Token = "0x6000318")]
			get
			{
				return (TBuffer)null;
			}
		}

		[Token(Token = "0x1700006B")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000319")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000317")]
		public CharacterAnalyzer(TBuffer buffer)
		{
		}

		[Token(Token = "0x600031A")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x600031B")]
		public void Skip(int length)
		{
		}

		[Token(Token = "0x600031C")]
		public bool IsAlphaNumericDashOrUnderscore(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		public bool IsAscii(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		public bool IsPrintable(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		public bool IsDigit(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000320")]
		public int AsDigit(int offset = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6000321")]
		public bool IsHex(int offset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		public int AsHex(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x6000323")]
		public bool IsSpace(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		public bool IsZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000325")]
		public bool IsTab(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		public bool IsWhite(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		public bool IsBreak(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		public bool IsCrLf(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		public bool IsBreakOrZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		public bool IsWhiteBreakOrZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		public bool Check(char expected, int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600032C")]
		public bool Check(string expectedCharacters, int offset = 0)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008F")]
	internal static class Constants
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TagDirective[] DefaultTagDirectives;

		[Token(Token = "0x40000AF")]
		public const int MajorVersion = 1;

		[Token(Token = "0x40000B0")]
		public const int MinorVersion = 1;

		[Token(Token = "0x40000B1")]
		public const char HandleCharacter = '!';

		[Token(Token = "0x40000B2")]
		public const string DefaultHandle = "!";
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	internal class Cursor
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674220", Offset = "0x674220")]
		private int <Index>k__BackingField;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674230", Offset = "0x674230")]
		private int <Line>k__BackingField;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674240", Offset = "0x674240")]
		private int <LineOffset>k__BackingField;

		[Token(Token = "0x1700006C")]
		public int Index
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0xEC9C48", Offset = "0xEC9C48", VA = "0xEC9C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6753A0", Offset = "0x6753A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600032F")]
			[Address(RVA = "0xEC9C50", Offset = "0xEC9C50", VA = "0xEC9C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6753B0", Offset = "0x6753B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int Line
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xEC9C58", Offset = "0xEC9C58", VA = "0xEC9C58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6753C0", Offset = "0x6753C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0xEC9C60", Offset = "0xEC9C60", VA = "0xEC9C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6753D0", Offset = "0x6753D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public int LineOffset
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xEC9C68", Offset = "0xEC9C68", VA = "0xEC9C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6753E0", Offset = "0x6753E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0xEC9C70", Offset = "0xEC9C70", VA = "0xEC9C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6753F0", Offset = "0x6753F0")]
			set
			{
			}
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xEC9C78", Offset = "0xEC9C78", VA = "0xEC9C78")]
		public Cursor()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xEC9CA4", Offset = "0xEC9CA4", VA = "0xEC9CA4")]
		public Cursor(Cursor cursor)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xEC9D1C", Offset = "0xEC9D1C", VA = "0xEC9D1C")]
		public Mark Mark()
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xEC9EB0", Offset = "0xEC9EB0", VA = "0xEC9EB0")]
		public void Skip()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xEC9ECC", Offset = "0xEC9ECC", VA = "0xEC9ECC")]
		public void SkipLineByOffset(int offset)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xEC9EE4", Offset = "0xEC9EE4", VA = "0xEC9EE4")]
		public void ForceSkipLineAfterNonBreak()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class Emitter : IEmitter
	{
		[Token(Token = "0x2000120")]
		private class AnchorData
		{
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string anchor;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isAlias;

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xECA244", Offset = "0xECA244", VA = "0xECA244")]
			public AnchorData()
			{
			}
		}

		[Token(Token = "0x2000121")]
		private class TagData
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string handle;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string suffix;

			[Token(Token = "0x6000641")]
			[Address(RVA = "0xECA24C", Offset = "0xECA24C", VA = "0xECA24C")]
			public TagData()
			{
			}
		}

		[Token(Token = "0x2000122")]
		private class ScalarData
		{
			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string value;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isMultiline;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool isFlowPlainAllowed;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool isBlockPlainAllowed;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
			public bool isSingleQuotedAllowed;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isBlockAllowed;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			public bool hasSingleQuotes;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ScalarStyle style;

			[Token(Token = "0x6000642")]
			[Address(RVA = "0xECA254", Offset = "0xECA254", VA = "0xECA254")]
			public ScalarData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E50", Offset = "0x673E50")]
		private sealed class <>c
		{
			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static MatchEvaluator <>9__89_0;

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xED03A0", Offset = "0xED03A0", VA = "0xED03A0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xED03A8", Offset = "0xED03A8", VA = "0xED03A8")]
			internal string <UrlEncode>b__89_0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x40000B6")]
		private const int MinBestIndent = 2;

		[Token(Token = "0x40000B7")]
		private const int MaxBestIndent = 9;

		[Token(Token = "0x40000B8")]
		private const int MaxAliasLength = 128;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex uriReplacer;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TextWriter output;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly bool outputUsesUnicodeEncoding;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private readonly bool isCanonical;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly int bestIndent;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int bestWidth;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private EmitterState state;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Stack<EmitterState> states;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Queue<ParsingEvent> events;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Stack<int> indents;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly TagDirectiveCollection tagDirectives;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int indent;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int flowLevel;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isMappingContext;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool isSimpleKeyContext;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool isRootContext;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int column;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isWhitespace;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isIndentation;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isOpenEnded;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool isDocumentEndWritten;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly AnchorData anchorData;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly TagData tagData;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly ScalarData scalarData;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xEC9EFC", Offset = "0xEC9EFC", VA = "0xEC9EFC")]
		public Emitter(TextWriter output)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xEC9F0C", Offset = "0xEC9F0C", VA = "0xEC9F0C")]
		public Emitter(TextWriter output, int bestIndent)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xEC9F18", Offset = "0xEC9F18", VA = "0xEC9F18")]
		public Emitter(TextWriter output, int bestIndent, int bestWidth)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xEC9F20", Offset = "0xEC9F20", VA = "0xEC9F20")]
		public Emitter(TextWriter output, int bestIndent, int bestWidth, bool isCanonical)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xECA364", Offset = "0xECA364", VA = "0xECA364", Slot = "4")]
		public void Emit(ParsingEvent @event)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xECA8E0", Offset = "0xECA8E0", VA = "0xECA8E0")]
		private bool NeedMoreEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xECA4C8", Offset = "0xECA4C8", VA = "0xECA4C8")]
		private void AnalyzeEvent(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xECAB34", Offset = "0xECAB34", VA = "0xECAB34")]
		private void AnalyzeAnchor(string anchor, bool isAlias)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xECAB8C", Offset = "0xECAB8C", VA = "0xECAB8C")]
		private void AnalyzeScalar(YamlDotNet.Core.Events.Scalar scalar)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xECB864", Offset = "0xECB864", VA = "0xECB864")]
		private bool ValueIsRepresentableInOutputEncoding(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xECA25C", Offset = "0xECA25C", VA = "0xECA25C")]
		private bool IsUnicode(Encoding encoding)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xECB4F0", Offset = "0xECB4F0", VA = "0xECB4F0")]
		private void AnalyzeTag(string tag)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xECA658", Offset = "0xECA658", VA = "0xECA658")]
		private void StateMachine(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xECBA74", Offset = "0xECBA74", VA = "0xECBA74")]
		private void EmitComment(YamlDotNet.Core.Events.Comment comment)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xECBB3C", Offset = "0xECBB3C", VA = "0xECBB3C")]
		private void EmitStreamStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xECBC2C", Offset = "0xECBC2C", VA = "0xECBC2C")]
		private void EmitDocumentStart(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xECD2C0", Offset = "0xECD2C0", VA = "0xECD2C0")]
		private TagDirectiveCollection NonDefaultTagsAmong(IEnumerable<TagDirective> tagCollection)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xECD690", Offset = "0xECD690", VA = "0xECD690")]
		private void AnalyzeVersionDirective(VersionDirective versionDirective)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xECD754", Offset = "0xECD754", VA = "0xECD754")]
		private static void AppendTagDirectiveTo(TagDirective value, bool allowDuplicates, TagDirectiveCollection tagDirectives)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xECC530", Offset = "0xECC530", VA = "0xECC530")]
		private void EmitDocumentContent(ParsingEvent evt)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xECDACC", Offset = "0xECDACC", VA = "0xECDACC")]
		private void EmitNode(ParsingEvent evt, bool isRoot, bool isMapping, bool isSimpleKey)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xECDC80", Offset = "0xECDC80", VA = "0xECDC80")]
		private void EmitAlias()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xECDCF0", Offset = "0xECDCF0", VA = "0xECDCF0")]
		private void EmitScalar(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xECE0BC", Offset = "0xECE0BC", VA = "0xECE0BC")]
		private void SelectScalarStyle(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xECE5D4", Offset = "0xECE5D4", VA = "0xECE5D4")]
		private void ProcessScalar()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xECE764", Offset = "0xECE764", VA = "0xECE764")]
		private void WritePlainScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xECE9E0", Offset = "0xECE9E0", VA = "0xECE9E0")]
		private void WriteSingleQuotedScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xECEC70", Offset = "0xECEC70", VA = "0xECEC70")]
		private void WriteDoubleQuotedScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xECF27C", Offset = "0xECF27C", VA = "0xECF27C")]
		private void WriteLiteralScalar(string value)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xECF488", Offset = "0xECF488", VA = "0xECF488")]
		private void WriteFoldedScalar(string value)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xECF8A4", Offset = "0xECF8A4", VA = "0xECF8A4")]
		private static bool IsSpace(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xECF8B4", Offset = "0xECF8B4", VA = "0xECF8B4")]
		private static bool IsBreak(char character, out char breakChar)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xECFC24", Offset = "0xECFC24", VA = "0xECFC24")]
		private static bool IsBlank(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xECF924", Offset = "0xECF924", VA = "0xECF924")]
		private static bool IsPrintable(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xECF98C", Offset = "0xECF98C", VA = "0xECF98C")]
		private static bool IsHighSurrogate(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xECF99C", Offset = "0xECF99C", VA = "0xECF99C")]
		private static bool IsLowSurrogate(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xECDDC0", Offset = "0xECDDC0", VA = "0xECDDC0")]
		private void EmitSequenceStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xECDEE0", Offset = "0xECDEE0", VA = "0xECDEE0")]
		private void EmitMappingStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xECE000", Offset = "0xECE000", VA = "0xECE000")]
		private void ProcessAnchor()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xECE3D8", Offset = "0xECE3D8", VA = "0xECE3D8")]
		private void ProcessTag()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xECC5B8", Offset = "0xECC5B8", VA = "0xECC5B8")]
		private void EmitDocumentEnd(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xECC6E4", Offset = "0xECC6E4", VA = "0xECC6E4")]
		private void EmitFlowSequenceItem(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xECC8EC", Offset = "0xECC8EC", VA = "0xECC8EC")]
		private void EmitFlowMappingKey(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xECCB68", Offset = "0xECCB68", VA = "0xECCB68")]
		private void EmitFlowMappingValue(ParsingEvent evt, bool isSimple)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xECCC5C", Offset = "0xECCC5C", VA = "0xECCC5C")]
		private void EmitBlockSequenceItem(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xECCDE0", Offset = "0xECCDE0", VA = "0xECCDE0")]
		private void EmitBlockMappingKey(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xECCF98", Offset = "0xECCF98", VA = "0xECCF98")]
		private void EmitBlockMappingValue(ParsingEvent evt, bool isSimple)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xECE524", Offset = "0xECE524", VA = "0xECE524")]
		private void IncreaseIndent(bool isFlow, bool isIndentless)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xECD8C8", Offset = "0xECD8C8", VA = "0xECD8C8")]
		private bool CheckEmptyDocument()
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xECFF1C", Offset = "0xECFF1C", VA = "0xECFF1C")]
		private bool CheckSimpleKey()
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xED017C", Offset = "0xED017C", VA = "0xED017C")]
		private int SafeStringLength(string value)
		{
			return default(int);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xECFC48", Offset = "0xECFC48", VA = "0xECFC48")]
		private bool CheckEmptySequence()
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xECFDA0", Offset = "0xECFDA0", VA = "0xECFDA0")]
		private bool CheckEmptyMapping()
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xECF9B0", Offset = "0xECF9B0", VA = "0xECF9B0")]
		private void WriteBlockScalarHints(string value)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xECD61C", Offset = "0xECD61C", VA = "0xECD61C")]
		private void WriteIndicator(string indicator, bool needWhitespace, bool whitespace, bool indentation)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xECD0D0", Offset = "0xECD0D0", VA = "0xECD0D0")]
		private void WriteIndent()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xECFEF0", Offset = "0xECFEF0", VA = "0xECFEF0")]
		private void WriteAnchor(string value)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xECD834", Offset = "0xECD834", VA = "0xECD834")]
		private void WriteTagHandle(string value)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xECD878", Offset = "0xECD878", VA = "0xECD878")]
		private void WriteTagContent(string value, bool needsWhitespace)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xED0194", Offset = "0xED0194", VA = "0xED0194")]
		private string UrlEncode(string text)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xECD078", Offset = "0xECD078", VA = "0xECD078")]
		private void Write(char value)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xECD1C4", Offset = "0xECD1C4", VA = "0xECD1C4")]
		private void Write(string value)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xECD240", Offset = "0xECD240", VA = "0xECD240")]
		private void WriteBreak(char breakCharacter = '\n')
		{
		}
	}
	[Token(Token = "0x2000092")]
	internal enum EmitterState
	{
		[Token(Token = "0x40000D2")]
		StreamStart,
		[Token(Token = "0x40000D3")]
		StreamEnd,
		[Token(Token = "0x40000D4")]
		FirstDocumentStart,
		[Token(Token = "0x40000D5")]
		DocumentStart,
		[Token(Token = "0x40000D6")]
		DocumentContent,
		[Token(Token = "0x40000D7")]
		DocumentEnd,
		[Token(Token = "0x40000D8")]
		FlowSequenceFirstItem,
		[Token(Token = "0x40000D9")]
		FlowSequenceItem,
		[Token(Token = "0x40000DA")]
		FlowMappingFirstKey,
		[Token(Token = "0x40000DB")]
		FlowMappingKey,
		[Token(Token = "0x40000DC")]
		FlowMappingSimpleValue,
		[Token(Token = "0x40000DD")]
		FlowMappingValue,
		[Token(Token = "0x40000DE")]
		BlockSequenceFirstItem,
		[Token(Token = "0x40000DF")]
		BlockSequenceItem,
		[Token(Token = "0x40000E0")]
		BlockMappingFirstKey,
		[Token(Token = "0x40000E1")]
		BlockMappingKey,
		[Token(Token = "0x40000E2")]
		BlockMappingSimpleValue,
		[Token(Token = "0x40000E3")]
		BlockMappingValue
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x673A70", Offset = "0x673A70")]
	public class FakeList<T>
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IEnumerator<T> collection;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int currentIndex;

		[Token(Token = "0x1700006F")]
		public T Item
		{
			[Token(Token = "0x600037C")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x600037A")]
		public FakeList(IEnumerator<T> collection)
		{
		}

		[Token(Token = "0x600037B")]
		public FakeList(IEnumerable<T> collection)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class ForwardAnchorNotSupportedException : YamlException
	{
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xED2A40", Offset = "0xED2A40", VA = "0xED2A40")]
		public ForwardAnchorNotSupportedException()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xED2A44", Offset = "0xED2A44", VA = "0xED2A44")]
		public ForwardAnchorNotSupportedException(string message)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xED2A48", Offset = "0xED2A48", VA = "0xED2A48")]
		public ForwardAnchorNotSupportedException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xED2A50", Offset = "0xED2A50", VA = "0xED2A50")]
		public ForwardAnchorNotSupportedException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000095")]
	internal static class HashCode
	{
		[Token(Token = "0x6000381")]
		[Address(RVA = "0xED2A54", Offset = "0xED2A54", VA = "0xED2A54")]
		public static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000096")]
	public interface IEmitter
	{
		[Token(Token = "0x6000382")]
		void Emit(ParsingEvent @event);
	}
	[Token(Token = "0x2000097")]
	internal interface ILookAheadBuffer
	{
		[Token(Token = "0x17000070")]
		bool EndOfInput
		{
			[Token(Token = "0x6000383")]
			get;
		}

		[Token(Token = "0x6000384")]
		char Peek(int offset);

		[Token(Token = "0x6000385")]
		void Skip(int length);
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class InsertionQueue<T>
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IList<T> items;

		[Token(Token = "0x17000071")]
		public int Count
		{
			[Token(Token = "0x6000386")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000387")]
		public void Enqueue(T item)
		{
		}

		[Token(Token = "0x6000388")]
		public T Dequeue()
		{
			return (T)null;
		}

		[Token(Token = "0x6000389")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x600038A")]
		public InsertionQueue()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public interface IParser
	{
		[Token(Token = "0x17000072")]
		ParsingEvent Current
		{
			[Token(Token = "0x600038B")]
			get;
		}

		[Token(Token = "0x600038C")]
		bool MoveNext();
	}
	[Token(Token = "0x200009A")]
	public interface IScanner
	{
		[Token(Token = "0x17000073")]
		Mark CurrentPosition
		{
			[Token(Token = "0x600038D")]
			get;
		}

		[Token(Token = "0x17000074")]
		Token Current
		{
			[Token(Token = "0x600038E")]
			get;
		}

		[Token(Token = "0x600038F")]
		bool MoveNext();

		[Token(Token = "0x6000390")]
		bool MoveNextWithoutConsuming();

		[Token(Token = "0x6000391")]
		void ConsumeCurrent();
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class LookAheadBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TextReader input;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly char[] buffer;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int firstIndex;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int count;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool endOfInput;

		[Token(Token = "0x17000075")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0xED2B60", Offset = "0xED2B60", VA = "0xED2B60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xED2A60", Offset = "0xED2A60", VA = "0xED2A60")]
		public LookAheadBuffer(TextReader input, int capacity)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xED2B80", Offset = "0xED2B80", VA = "0xED2B80")]
		private int GetIndexForOffset(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xED2BE4", Offset = "0xED2BE4", VA = "0xED2BE4", Slot = "5")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xED2D08", Offset = "0xED2D08", VA = "0xED2D08")]
		public void Cache(int length)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xED2DD4", Offset = "0xED2DD4", VA = "0xED2DD4", Slot = "6")]
		public void Skip(int length)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class Mark : IEquatable<Mark>, IComparable<Mark>, IComparable
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Mark Empty;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674250", Offset = "0x674250")]
		private int <Index>k__BackingField;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674260", Offset = "0x674260")]
		private int <Line>k__BackingField;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674270", Offset = "0x674270")]
		private int <Column>k__BackingField;

		[Token(Token = "0x17000076")]
		public int Index
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0xED2E9C", Offset = "0xED2E9C", VA = "0xED2E9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675400", Offset = "0x675400")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xED2EA4", Offset = "0xED2EA4", VA = "0xED2EA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675410", Offset = "0x675410")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public int Line
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xED2EAC", Offset = "0xED2EAC", VA = "0xED2EAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675420", Offset = "0x675420")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xED2EB4", Offset = "0xED2EB4", VA = "0xED2EB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675430", Offset = "0x675430")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public int Column
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0xED2EBC", Offset = "0xED2EBC", VA = "0xED2EBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675440", Offset = "0x675440")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xED2EC4", Offset = "0xED2EC4", VA = "0xED2EC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675450", Offset = "0x675450")]
			private set
			{
			}
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xED2ECC", Offset = "0xED2ECC", VA = "0xED2ECC")]
		public Mark()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xEC9D94", Offset = "0xEC9D94", VA = "0xEC9D94")]
		public Mark(int index, int line, int column)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xED2EF8", Offset = "0xED2EF8", VA = "0xED2EF8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xED2FB8", Offset = "0xED2FB8", VA = "0xED2FB8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xED3074", Offset = "0xED3074", VA = "0xED3074", Slot = "4")]
		public bool Equals(Mark other)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xED30B4", Offset = "0xED30B4", VA = "0xED30B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xED312C", Offset = "0xED312C", VA = "0xED312C", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xED3200", Offset = "0xED3200", VA = "0xED3200", Slot = "5")]
		public int CompareTo(Mark other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class MaximumRecursionLevelReachedException : YamlException
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xED3338", Offset = "0xED3338", VA = "0xED3338")]
		public MaximumRecursionLevelReachedException()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xED333C", Offset = "0xED333C", VA = "0xED333C")]
		public MaximumRecursionLevelReachedException(string message)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xED3340", Offset = "0xED3340", VA = "0xED3340")]
		public MaximumRecursionLevelReachedException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xED3348", Offset = "0xED3348", VA = "0xED3348")]
		public MaximumRecursionLevelReachedException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x200009E")]
	public sealed class MergingParser : IParser
	{
		[Token(Token = "0x2000124")]
		private class ParsingEventCloner : IParsingEventVisitor
		{
			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ParsingEvent clonedEvent;

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xED3E58", Offset = "0xED3E58", VA = "0xED3E58")]
			public ParsingEvent Clone(ParsingEvent e)
			{
				return null;
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xED3E9C", Offset = "0xED3E9C", VA = "0xED3E9C", Slot = "4")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.AnchorAlias e)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xED3F54", Offset = "0xED3F54", VA = "0xED3F54", Slot = "5")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.StreamStart e)
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0xED3FBC", Offset = "0xED3FBC", VA = "0xED3FBC", Slot = "6")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.StreamEnd e)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0xED4024", Offset = "0xED4024", VA = "0xED4024", Slot = "7")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.DocumentStart e)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0xED408C", Offset = "0xED408C", VA = "0xED408C", Slot = "8")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.DocumentEnd e)
			{
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0xED40F4", Offset = "0xED40F4", VA = "0xED40F4", Slot = "9")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.Scalar e)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xED4234", Offset = "0xED4234", VA = "0xED4234", Slot = "10")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(SequenceStart e)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xED4330", Offset = "0xED4330", VA = "0xED4330", Slot = "11")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(SequenceEnd e)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xED43C8", Offset = "0xED43C8", VA = "0xED43C8", Slot = "12")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(MappingStart e)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0xED44C4", Offset = "0xED44C4", VA = "0xED44C4", Slot = "13")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(MappingEnd e)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0xED455C", Offset = "0xED455C", VA = "0xED455C", Slot = "14")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.Comment e)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0xED3C78", Offset = "0xED3C78", VA = "0xED3C78")]
			public ParsingEventCloner()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E60", Offset = "0x673E60")]
		private sealed class <>c
		{
			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IEnumerable<ParsingEvent>, IEnumerable<ParsingEvent>> <>9__8_0;

			[Token(Token = "0x6000654")]
			[Address(RVA = "0xED3CE4", Offset = "0xED3CE4", VA = "0xED3CE4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0xED3CEC", Offset = "0xED3CEC", VA = "0xED3CEC")]
			internal IEnumerable<ParsingEvent> <MoveNext>b__8_0(IEnumerable<ParsingEvent> e)
			{
				return null;
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673E70", Offset = "0x673E70")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string mappingAlias;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nesting;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParsingEventCloner cloner;

			[Token(Token = "0x6000656")]
			[Address(RVA = "0xED3C70", Offset = "0xED3C70", VA = "0xED3C70")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xED3CF4", Offset = "0xED3CF4", VA = "0xED3CF4")]
			internal bool <GetMappingEvents>b__0(ParsingEvent e)
			{
				return default(bool);
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0xED3DA8", Offset = "0xED3DA8", VA = "0xED3DA8")]
			internal bool <GetMappingEvents>b__1(ParsingEvent e)
			{
				return default(bool);
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xED3E00", Offset = "0xED3E00", VA = "0xED3E00")]
			internal ParsingEvent <GetMappingEvents>b__2(ParsingEvent e)
			{
				return null;
			}
		}

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<ParsingEvent> _allEvents;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IParser _innerParser;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _currentIndex;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674280", Offset = "0x674280")]
		private ParsingEvent <Current>k__BackingField;

		[Token(Token = "0x17000079")]
		public ParsingEvent Current
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xED33D8", Offset = "0xED33D8", VA = "0xED33D8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675460", Offset = "0x675460")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xED33E0", Offset = "0xED33E0", VA = "0xED33E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675470", Offset = "0x675470")]
			private set
			{
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xED334C", Offset = "0xED334C", VA = "0xED334C")]
		public MergingParser(IParser innerParser)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xED33E8", Offset = "0xED33E8", VA = "0xED33E8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xED3A9C", Offset = "0xED3A9C", VA = "0xED3A9C")]
		private IEnumerable<ParsingEvent> GetMappingEvents(string mappingAlias)
		{
			return null;
		}
	}
	[Token(Token = "0x200009F")]
	public class Parser : IParser
	{
		[Token(Token = "0x2000127")]
		private class EventQueue
		{
			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Queue<ParsingEvent> highPriorityEvents;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly Queue<ParsingEvent> normalPriorityEvents;

			[Token(Token = "0x170000FD")]
			public int Count
			{
				[Token(Token = "0x600065C")]
				[Address(RVA = "0xED4C40", Offset = "0xED4C40", VA = "0xED4C40")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xED47D8", Offset = "0xED47D8", VA = "0xED47D8")]
			public void Enqueue(ParsingEvent @event)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0xED4ED0", Offset = "0xED4ED0", VA = "0xED4ED0")]
			public ParsingEvent Dequeue()
			{
				return null;
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xED4B04", Offset = "0xED4B04", VA = "0xED4B04")]
			public EventQueue()
			{
			}
		}

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Stack<ParserState> states;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TagDirectiveCollection tagDirectives;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParserState state;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IScanner scanner;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParsingEvent currentEvent;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Token currentToken;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly EventQueue pendingEvents;

		[Token(Token = "0x1700007A")]
		public ParsingEvent Current
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xED4B94", Offset = "0xED4B94", VA = "0xED4B94", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xED45C4", Offset = "0xED45C4", VA = "0xED45C4")]
		private Token GetCurrentToken()
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xED487C", Offset = "0xED487C", VA = "0xED487C")]
		public Parser(TextReader input)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xED4A48", Offset = "0xED4A48", VA = "0xED4A48")]
		public Parser(IScanner scanner)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xED4B9C", Offset = "0xED4B9C", VA = "0xED4B9C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xED4CD0", Offset = "0xED4CD0", VA = "0xED4CD0")]
		private ParsingEvent StateMachine()
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xED7604", Offset = "0xED7604", VA = "0xED7604")]
		private void Skip()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xED4F64", Offset = "0xED4F64", VA = "0xED4F64")]
		private ParsingEvent ParseStreamStart()
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xED5098", Offset = "0xED5098", VA = "0xED5098")]
		private ParsingEvent ParseDocumentStart(bool isImplicit)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xED76D4", Offset = "0xED76D4", VA = "0xED76D4")]
		private VersionDirective ProcessDirectives(TagDirectiveCollection tags)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xED79A8", Offset = "0xED79A8", VA = "0xED79A8")]
		private static void AddTagDirectives(TagDirectiveCollection directives, IEnumerable<TagDirective> source)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xED5594", Offset = "0xED5594", VA = "0xED5594")]
		private ParsingEvent ParseDocumentContent()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xED7C78", Offset = "0xED7C78", VA = "0xED7C78")]
		private static ParsingEvent ProcessEmptyScalar(Mark position)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xED58CC", Offset = "0xED58CC", VA = "0xED58CC")]
		private ParsingEvent ParseNode(bool isBlock, bool isIndentlessSequence)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xED57CC", Offset = "0xED57CC", VA = "0xED57CC")]
		private ParsingEvent ParseDocumentEnd()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xED606C", Offset = "0xED606C", VA = "0xED606C")]
		private ParsingEvent ParseBlockSequenceEntry(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xED6338", Offset = "0xED6338", VA = "0xED6338")]
		private ParsingEvent ParseIndentlessSequenceEntry()
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xED65B4", Offset = "0xED65B4", VA = "0xED65B4")]
		private ParsingEvent ParseBlockMappingKey(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xED68C0", Offset = "0xED68C0", VA = "0xED68C0")]
		private ParsingEvent ParseBlockMappingValue()
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xED6A94", Offset = "0xED6A94", VA = "0xED6A94")]
		private ParsingEvent ParseFlowSequenceEntry(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xED6D64", Offset = "0xED6D64", VA = "0xED6D64")]
		private ParsingEvent ParseFlowSequenceEntryMappingKey()
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xED6ED0", Offset = "0xED6ED0", VA = "0xED6ED0")]
		private ParsingEvent ParseFlowSequenceEntryMappingValue()
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xED7038", Offset = "0xED7038", VA = "0xED7038")]
		private ParsingEvent ParseFlowSequenceEntryMappingEnd()
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xED70DC", Offset = "0xED70DC", VA = "0xED70DC")]
		private ParsingEvent ParseFlowMappingKey(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xED7488", Offset = "0xED7488", VA = "0xED7488")]
		private ParsingEvent ParseFlowMappingValue(bool isEmpty)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A0")]
	public static class ParserExtensions
	{
		[Token(Token = "0x60003C9")]
		public static T Expect<T>(this IParser parser) where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		public static bool Accept<T>(this IParser parser) where T : ParsingEvent
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		public static T Allow<T>(this IParser parser) where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		public static T Peek<T>(this IParser parser) where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xED7D48", Offset = "0xED7D48", VA = "0xED7D48")]
		public static void SkipThisAndNestedEvents(this IParser parser)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	internal enum ParserState
	{
		[Token(Token = "0x40000FC")]
		StreamStart,
		[Token(Token = "0x40000FD")]
		StreamEnd,
		[Token(Token = "0x40000FE")]
		ImplicitDocumentStart,
		[Token(Token = "0x40000FF")]
		DocumentStart,
		[Token(Token = "0x4000100")]
		DocumentContent,
		[Token(Token = "0x4000101")]
		DocumentEnd,
		[Token(Token = "0x4000102")]
		BlockNode,
		[Token(Token = "0x4000103")]
		BlockNodeOrIndentlessSequence,
		[Token(Token = "0x4000104")]
		FlowNode,
		[Token(Token = "0x4000105")]
		BlockSequenceFirstEntry,
		[Token(Token = "0x4000106")]
		BlockSequenceEntry,
		[Token(Token = "0x4000107")]
		IndentlessSequenceEntry,
		[Token(Token = "0x4000108")]
		BlockMappingFirstKey,
		[Token(Token = "0x4000109")]
		BlockMappingKey,
		[Token(Token = "0x400010A")]
		BlockMappingValue,
		[Token(Token = "0x400010B")]
		FlowSequenceFirstEntry,
		[Token(Token = "0x400010C")]
		FlowSequenceEntry,
		[Token(Token = "0x400010D")]
		FlowSequenceEntryMappingKey,
		[Token(Token = "0x400010E")]
		FlowSequenceEntryMappingValue,
		[Token(Token = "0x400010F")]
		FlowSequenceEntryMappingEnd,
		[Token(Token = "0x4000110")]
		FlowMappingFirstKey,
		[Token(Token = "0x4000111")]
		FlowMappingKey,
		[Token(Token = "0x4000112")]
		FlowMappingValue,
		[Token(Token = "0x4000113")]
		FlowMappingEmptyValue
	}
	[Token(Token = "0x20000A2")]
	internal class RecursionLevel
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int current;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674290", Offset = "0x674290")]
		private int <Maximum>k__BackingField;

		[Token(Token = "0x1700007B")]
		public int Maximum
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xED7E54", Offset = "0xED7E54", VA = "0xED7E54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6754D0", Offset = "0x6754D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xED7E5C", Offset = "0xED7E5C", VA = "0xED7E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6754E0", Offset = "0x6754E0")]
			private set
			{
			}
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xED7E64", Offset = "0xED7E64", VA = "0xED7E64")]
		public RecursionLevel(int maximum)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xED7E90", Offset = "0xED7E90", VA = "0xED7E90")]
		public void Increment()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xED7F18", Offset = "0xED7F18", VA = "0xED7F18")]
		public bool TryIncrement()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xED7F3C", Offset = "0xED7F3C", VA = "0xED7F3C")]
		public void Decrement()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public enum ScalarStyle
	{
		[Token(Token = "0x4000117")]
		Any,
		[Token(Token = "0x4000118")]
		Plain,
		[Token(Token = "0x4000119")]
		SingleQuoted,
		[Token(Token = "0x400011A")]
		DoubleQuoted,
		[Token(Token = "0x400011B")]
		Literal,
		[Token(Token = "0x400011C")]
		Folded
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class Scanner : IScanner
	{
		[Token(Token = "0x400011D")]
		private const int MaxVersionNumberLength = 9;

		[Token(Token = "0x400011E")]
		private const int MaxBufferLength = 8;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IDictionary<char, char> simpleEscapeCodes;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Stack<int> indents;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly InsertionQueue<Token> tokens;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Stack<SimpleKey> simpleKeys;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly CharacterAnalyzer<LookAheadBuffer> analyzer;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Cursor cursor;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool streamStartProduced;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool streamEndProduced;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int indent;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool simpleKeyAllowed;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int flowLevel;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int tokensParsed;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool tokenAvailable;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Token previous;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742A0", Offset = "0x6742A0")]
		private bool <SkipComments>k__BackingField;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742B0", Offset = "0x6742B0")]
		private Token <Current>k__BackingField;

		[Token(Token = "0x1700007C")]
		public bool SkipComments
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xED7FD0", Offset = "0xED7FD0", VA = "0xED7FD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6754F0", Offset = "0x6754F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xED7FD8", Offset = "0xED7FD8", VA = "0xED7FD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675500", Offset = "0x675500")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Token Current
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0xED7FE4", Offset = "0xED7FE4", VA = "0xED7FE4", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675510", Offset = "0x675510")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0xED7FEC", Offset = "0xED7FEC", VA = "0xED7FEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675520", Offset = "0x675520")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Mark CurrentPosition
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xED7FF4", Offset = "0xED7FF4", VA = "0xED7FF4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xED48F0", Offset = "0xED48F0", VA = "0xED48F0")]
		public Scanner(TextReader input, bool skipComments = true)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xED8020", Offset = "0xED8020", VA = "0xED8020", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xED8064", Offset = "0xED8064", VA = "0xED8064", Slot = "7")]
		public bool MoveNextWithoutConsuming()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xED8044", Offset = "0xED8044", VA = "0xED8044", Slot = "8")]
		public void ConsumeCurrent()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xED8328", Offset = "0xED8328", VA = "0xED8328")]
		private char ReadCurrentCharacter()
		{
			return default(char);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xED8440", Offset = "0xED8440", VA = "0xED8440")]
		private char ReadLine()
		{
			return default(char);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xED8124", Offset = "0xED8124", VA = "0xED8124")]
		private void FetchMoreTokens()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xED9200", Offset = "0xED9200", VA = "0xED9200")]
		private static bool StartsWith(StringBuilder what, char start)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xED86CC", Offset = "0xED86CC", VA = "0xED86CC")]
		private void StaleSimpleKeys()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xED8910", Offset = "0xED8910", VA = "0xED8910")]
		private void FetchNextToken()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xEDA300", Offset = "0xEDA300", VA = "0xEDA300")]
		private bool CheckWhiteSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xEDA3C8", Offset = "0xEDA3C8", VA = "0xEDA3C8")]
		private bool IsDocumentIndicator()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xED83A0", Offset = "0xED83A0", VA = "0xED83A0")]
		private void Skip()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xED8500", Offset = "0xED8500", VA = "0xED8500")]
		private void SkipLine()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xED93D8", Offset = "0xED93D8", VA = "0xED93D8")]
		private void ScanToNextToken()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xEDA578", Offset = "0xEDA578", VA = "0xEDA578")]
		private void ProcessComment()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xED92E0", Offset = "0xED92E0", VA = "0xED92E0")]
		private void FetchStreamStart()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xED9480", Offset = "0xED9480", VA = "0xED9480")]
		private void UnrollIndent(int column)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xED9588", Offset = "0xED9588", VA = "0xED9588")]
		private void FetchStreamEnd()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xED9678", Offset = "0xED9678", VA = "0xED9678")]
		private void FetchDirective()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xEDAA68", Offset = "0xEDAA68", VA = "0xEDAA68")]
		private Token ScanDirective()
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xED9700", Offset = "0xED9700", VA = "0xED9700")]
		private void FetchDocumentIndicator(bool isStartToken)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xED9824", Offset = "0xED9824", VA = "0xED9824")]
		private void FetchFlowCollectionStart(bool isSequenceToken)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xEDB31C", Offset = "0xEDB31C", VA = "0xEDB31C")]
		private void IncreaseFlowLevel()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xED9900", Offset = "0xED9900", VA = "0xED9900")]
		private void FetchFlowCollectionEnd(bool isSequenceToken)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xEDB420", Offset = "0xEDB420", VA = "0xEDB420")]
		private void DecreaseFlowLevel()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xED99D8", Offset = "0xED99D8", VA = "0xED99D8")]
		private void FetchFlowEntry()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xED9AB8", Offset = "0xED9AB8", VA = "0xED9AB8")]
		private void FetchBlockEntry()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xED9C44", Offset = "0xED9C44", VA = "0xED9C44")]
		private void FetchKey()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xED9DD8", Offset = "0xED9DD8", VA = "0xED9DD8")]
		private void FetchValue()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xEDB544", Offset = "0xEDB544", VA = "0xEDB544")]
		private void RollIndent(int column, int number, bool isSequence, Mark position)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xEDA060", Offset = "0xEDA060", VA = "0xEDA060")]
		private void FetchAnchor(bool isAlias)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xEDB814", Offset = "0xEDB814", VA = "0xEDB814")]
		private Token ScanAnchor(bool isAlias)
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xEDA0EC", Offset = "0xEDA0EC", VA = "0xEDA0EC")]
		private void FetchTag()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xEDBADC", Offset = "0xEDBADC", VA = "0xEDBADC")]
		private Token ScanTag()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xEDA168", Offset = "0xEDA168", VA = "0xEDA168")]
		private void FetchBlockScalar(bool isLiteral)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xEDC344", Offset = "0xEDC344", VA = "0xEDC344")]
		private Token ScanBlockScalar(bool isLiteral)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xEDCA98", Offset = "0xEDCA98", VA = "0xEDCA98")]
		private int ScanBlockScalarBreaks(int currentIndent, StringBuilder breaks, Mark start, ref Mark end)
		{
			return default(int);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xEDA1F8", Offset = "0xEDA1F8", VA = "0xEDA1F8")]
		private void FetchFlowScalar(bool isSingleQuoted)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEDCD8C", Offset = "0xEDCD8C", VA = "0xEDCD8C")]
		private Token ScanFlowScalar(bool isSingleQuoted)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xEDA284", Offset = "0xEDA284", VA = "0xEDA284")]
		private void FetchPlainScalar()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xEDD760", Offset = "0xEDD760", VA = "0xEDD760")]
		private Token ScanPlainScalar()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xEDA928", Offset = "0xEDA928", VA = "0xEDA928")]
		private void RemoveSimpleKey()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xEDAC84", Offset = "0xEDAC84", VA = "0xEDAC84")]
		private string ScanDirectiveName(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xEDDE60", Offset = "0xEDDE60", VA = "0xEDDE60")]
		private void SkipWhitespaces()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xEDAE50", Offset = "0xEDAE50", VA = "0xEDAE50")]
		private Token ScanVersionDirectiveValue(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xEDAFB0", Offset = "0xEDAFB0", VA = "0xEDAFB0")]
		private Token ScanTagDirectiveValue(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xEDBDF4", Offset = "0xEDBDF4", VA = "0xEDBDF4")]
		private string ScanTagUri(string head, Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xEDE268", Offset = "0xEDE268", VA = "0xEDE268")]
		private string ScanUriEscapes(Mark start)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xEDC06C", Offset = "0xEDC06C", VA = "0xEDC06C")]
		private string ScanTagHandle(bool isDirective, Mark start)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xEDDED8", Offset = "0xEDDED8", VA = "0xEDDED8")]
		private int ScanVersionDirectiveNumber(Mark start)
		{
			return default(int);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xEDB1D4", Offset = "0xEDB1D4", VA = "0xEDB1D4")]
		private void SaveSimpleKey()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class SemanticErrorException : YamlException
	{
		[Token(Token = "0x600040E")]
		[Address(RVA = "0xEDEA98", Offset = "0xEDEA98", VA = "0xEDEA98")]
		public SemanticErrorException()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xEDEA9C", Offset = "0xEDEA9C", VA = "0xEDEA9C")]
		public SemanticErrorException(string message)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xED3C68", Offset = "0xED3C68", VA = "0xED3C68")]
		public SemanticErrorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xEDEAA0", Offset = "0xEDEAA0", VA = "0xEDEAA0")]
		public SemanticErrorException(string message, Exception inner)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	internal class SimpleKey
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Cursor cursor;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742C0", Offset = "0x6742C0")]
		private bool <IsPossible>k__BackingField;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742D0", Offset = "0x6742D0")]
		private bool <IsRequired>k__BackingField;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742E0", Offset = "0x6742E0")]
		private int <TokenNumber>k__BackingField;

		[Token(Token = "0x1700007F")]
		public bool IsPossible
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xED8900", Offset = "0xED8900", VA = "0xED8900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675530", Offset = "0x675530")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xED92D4", Offset = "0xED92D4", VA = "0xED92D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675540", Offset = "0x675540")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool IsRequired
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xED92C4", Offset = "0xED92C4", VA = "0xED92C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675550", Offset = "0x675550")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xEDEAA4", Offset = "0xEDEAA4", VA = "0xEDEAA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675560", Offset = "0x675560")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public int TokenNumber
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xED8908", Offset = "0xED8908", VA = "0xED8908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675570", Offset = "0x675570")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xEDEAB0", Offset = "0xEDEAB0", VA = "0xEDEAB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675580", Offset = "0x675580")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public int Index
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0xED9298", Offset = "0xED9298", VA = "0xED9298")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000083")]
		public int Line
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xED926C", Offset = "0xED926C", VA = "0xED926C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000084")]
		public int LineOffset
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0xEDB740", Offset = "0xEDB740", VA = "0xEDB740")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000085")]
		public Mark Mark
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xEDB714", Offset = "0xEDB714", VA = "0xEDB714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xEDA844", Offset = "0xEDA844", VA = "0xEDA844")]
		public SimpleKey()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xEDE618", Offset = "0xEDE618", VA = "0xEDE618")]
		public SimpleKey(bool isPossible, bool isRequired, int tokenNumber, Cursor cursor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	internal class StringLookAheadBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string value;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742F0", Offset = "0x6742F0")]
		private int <Position>k__BackingField;

		[Token(Token = "0x17000086")]
		public int Position
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xECBA2C", Offset = "0xECBA2C", VA = "0xECBA2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675590", Offset = "0x675590")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xEDEAB8", Offset = "0xEDEAB8", VA = "0xEDEAB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6755A0", Offset = "0x6755A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public int Length
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xECBA34", Offset = "0xECBA34", VA = "0xECBA34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000088")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xEDEAC0", Offset = "0xEDEAC0", VA = "0xEDEAC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xECB838", Offset = "0xECB838", VA = "0xECB838")]
		public StringLookAheadBuffer(string value)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xEDEB08", Offset = "0xEDEB08", VA = "0xEDEB08", Slot = "5")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xEDEAC8", Offset = "0xEDEAC8", VA = "0xEDEAC8")]
		private bool IsOutside(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xEDEB64", Offset = "0xEDEB64", VA = "0xEDEB64", Slot = "6")]
		public void Skip(int length)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class SyntaxErrorException : YamlException
	{
		[Token(Token = "0x6000426")]
		[Address(RVA = "0xEDEC10", Offset = "0xEDEC10", VA = "0xEDEC10")]
		public SyntaxErrorException()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xECF9AC", Offset = "0xECF9AC", VA = "0xECF9AC")]
		public SyntaxErrorException(string message)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xED92CC", Offset = "0xED92CC", VA = "0xED92CC")]
		public SyntaxErrorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xEDEC14", Offset = "0xEDEC14", VA = "0xEDEC14")]
		public SyntaxErrorException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TagDirectiveCollection : KeyedCollection<string, TagDirective>
	{
		[Token(Token = "0x600042A")]
		[Address(RVA = "0xECA1F4", Offset = "0xECA1F4", VA = "0xECA1F4")]
		public TagDirectiveCollection()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xEDEC18", Offset = "0xEDEC18", VA = "0xEDEC18")]
		public TagDirectiveCollection(IEnumerable<TagDirective> tagDirectives)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xEDEECC", Offset = "0xEDEECC", VA = "0xEDEECC", Slot = "39")]
		protected override string GetKeyForItem(TagDirective item)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xECDA54", Offset = "0xECDA54", VA = "0xECDA54")]
		public new bool Contains(TagDirective directive)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class Version
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674300", Offset = "0x674300")]
		private int <Major>k__BackingField;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674310", Offset = "0x674310")]
		private int <Minor>k__BackingField;

		[Token(Token = "0x17000089")]
		public int Major
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xECDA44", Offset = "0xECDA44", VA = "0xECDA44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6755B0", Offset = "0x6755B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xEDFD3C", Offset = "0xEDFD3C", VA = "0xEDFD3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6755C0", Offset = "0x6755C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public int Minor
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xECDA4C", Offset = "0xECDA4C", VA = "0xECDA4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6755D0", Offset = "0x6755D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xEDFD44", Offset = "0xEDFD44", VA = "0xEDFD44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6755E0", Offset = "0x6755E0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xEDE060", Offset = "0xEDE060", VA = "0xEDE060")]
		public Version(int major, int minor)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xEDFD4C", Offset = "0xEDFD4C", VA = "0xEDFD4C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xEDFE08", Offset = "0xEDFE08", VA = "0xEDFE08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class YamlException : Exception
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674320", Offset = "0x674320")]
		private Mark <Start>k__BackingField;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674330", Offset = "0x674330")]
		private Mark <End>k__BackingField;

		[Token(Token = "0x1700008B")]
		public Mark Start
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0xEDFE5C", Offset = "0xEDFE5C", VA = "0xEDFE5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6755F0", Offset = "0x6755F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xEDFE64", Offset = "0xEDFE64", VA = "0xEDFE64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675600", Offset = "0x675600")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public Mark End
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xEDFE6C", Offset = "0xEDFE6C", VA = "0xEDFE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675610", Offset = "0x675610")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0xEDFE74", Offset = "0xEDFE74", VA = "0xEDFE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675620", Offset = "0x675620")]
			private set
			{
			}
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xEC98E0", Offset = "0xEC98E0", VA = "0xEC98E0")]
		public YamlException()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xEC994C", Offset = "0xEC994C", VA = "0xEC994C")]
		public YamlException(string message)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xEC99CC", Offset = "0xEC99CC", VA = "0xEC99CC")]
		public YamlException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xEDFE7C", Offset = "0xEDFE7C", VA = "0xEDFE7C")]
		public YamlException(Mark start, Mark end, string message, Exception innerException)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xEC99D8", Offset = "0xEC99D8", VA = "0xEC99D8")]
		public YamlException(string message, Exception inner)
		{
		}
	}
}
namespace YamlDotNet.Core.Tokens
{
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class Anchor : Token
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x1700008D")]
		public string Value
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xED7D30", Offset = "0xED7D30", VA = "0xED7D30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xEDEEF8", Offset = "0xEDEEF8", VA = "0xEDEEF8")]
		public Anchor(string value)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xEDBA9C", Offset = "0xEDBA9C", VA = "0xEDBA9C")]
		public Anchor(string value, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class AnchorAlias : Token
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x1700008E")]
		public string Value
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xED7D18", Offset = "0xED7D18", VA = "0xED7D18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xEDEFBC", Offset = "0xEDEFBC", VA = "0xEDEFBC")]
		public AnchorAlias(string value)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xEDBA5C", Offset = "0xEDBA5C", VA = "0xEDBA5C")]
		public AnchorAlias(string value, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class BlockEnd : Token
	{
		[Token(Token = "0x6000444")]
		[Address(RVA = "0xEDF048", Offset = "0xEDF048", VA = "0xEDF048")]
		public BlockEnd()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xEDA8F0", Offset = "0xEDA8F0", VA = "0xEDA8F0")]
		public BlockEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class BlockEntry : Token
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0xEDF0C4", Offset = "0xEDF0C4", VA = "0xEDF0C4")]
		public BlockEntry()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xEDB6A4", Offset = "0xEDB6A4", VA = "0xEDB6A4")]
		public BlockEntry(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class BlockMappingStart : Token
	{
		[Token(Token = "0x6000448")]
		[Address(RVA = "0xEDF140", Offset = "0xEDF140", VA = "0xEDF140")]
		public BlockMappingStart()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xEDB7DC", Offset = "0xEDB7DC", VA = "0xEDB7DC")]
		public BlockMappingStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class BlockSequenceStart : Token
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0xEDF1BC", Offset = "0xEDF1BC", VA = "0xEDF1BC")]
		public BlockSequenceStart()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xEDB7A4", Offset = "0xEDB7A4", VA = "0xEDB7A4")]
		public BlockSequenceStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class Comment : Token
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674340", Offset = "0x674340")]
		private string <Value>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674350", Offset = "0x674350")]
		private bool <IsInline>k__BackingField;

		[Token(Token = "0x1700008F")]
		public string Value
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xED47B8", Offset = "0xED47B8", VA = "0xED47B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675630", Offset = "0x675630")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xEDF238", Offset = "0xEDF238", VA = "0xEDF238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675640", Offset = "0x675640")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool IsInline
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xED47C0", Offset = "0xED47C0", VA = "0xED47C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675650", Offset = "0x675650")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xEDF240", Offset = "0xEDF240", VA = "0xEDF240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675660", Offset = "0x675660")]
			private set
			{
			}
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xEDF24C", Offset = "0xEDF24C", VA = "0xEDF24C")]
		public Comment(string value, bool isInline)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xEDA7F0", Offset = "0xEDA7F0", VA = "0xEDA7F0")]
		public Comment(string value, bool isInline, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class DocumentEnd : Token
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0xEDF2E4", Offset = "0xEDF2E4", VA = "0xEDF2E4")]
		public DocumentEnd()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xEDB164", Offset = "0xEDB164", VA = "0xEDB164")]
		public DocumentEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class DocumentStart : Token
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0xEDF360", Offset = "0xEDF360", VA = "0xEDF360")]
		public DocumentStart()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xEDB19C", Offset = "0xEDB19C", VA = "0xEDB19C")]
		public DocumentStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class FlowEntry : Token
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0xEDF3DC", Offset = "0xEDF3DC", VA = "0xEDF3DC")]
		public FlowEntry()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xEDB50C", Offset = "0xEDB50C", VA = "0xEDB50C")]
		public FlowEntry(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class FlowMappingEnd : Token
	{
		[Token(Token = "0x6000458")]
		[Address(RVA = "0xEDF458", Offset = "0xEDF458", VA = "0xEDF458")]
		public FlowMappingEnd()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xEDB4D4", Offset = "0xEDB4D4", VA = "0xEDB4D4")]
		public FlowMappingEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class FlowMappingStart : Token
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0xEDF4D4", Offset = "0xEDF4D4", VA = "0xEDF4D4")]
		public FlowMappingStart()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xEDB3E8", Offset = "0xEDB3E8", VA = "0xEDB3E8")]
		public FlowMappingStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class FlowSequenceEnd : Token
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0xEDF550", Offset = "0xEDF550", VA = "0xEDF550")]
		public FlowSequenceEnd()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xEDB49C", Offset = "0xEDB49C", VA = "0xEDB49C")]
		public FlowSequenceEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class FlowSequenceStart : Token
	{
		[Token(Token = "0x600045E")]
		[Address(RVA = "0xEDF5CC", Offset = "0xEDF5CC", VA = "0xEDF5CC")]
		public FlowSequenceStart()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xEDB3B0", Offset = "0xEDB3B0", VA = "0xEDB3B0")]
		public FlowSequenceStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class Key : Token
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0xEDF648", Offset = "0xEDF648", VA = "0xEDF648")]
		public Key()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xEDB6DC", Offset = "0xEDB6DC", VA = "0xEDB6DC")]
		public Key(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class Scalar : Token
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ScalarStyle style;

		[Token(Token = "0x17000091")]
		public string Value
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xED7D40", Offset = "0xED7D40", VA = "0xED7D40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xED7D38", Offset = "0xED7D38", VA = "0xED7D38")]
			get
			{
				return default(ScalarStyle);
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xEDF6C4", Offset = "0xEDF6C4", VA = "0xEDF6C4")]
		public Scalar(string value)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xEDF6CC", Offset = "0xEDF6CC", VA = "0xEDF6CC")]
		public Scalar(string value, ScalarStyle style)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xEDCD3C", Offset = "0xEDCD3C", VA = "0xEDCD3C")]
		public Scalar(string value, ScalarStyle style, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public class StreamEnd : Token
	{
		[Token(Token = "0x6000467")]
		[Address(RVA = "0xEDF760", Offset = "0xEDF760", VA = "0xEDF760")]
		public StreamEnd()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xEDAA30", Offset = "0xEDAA30", VA = "0xEDAA30")]
		public StreamEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public class StreamStart : Token
	{
		[Token(Token = "0x6000469")]
		[Address(RVA = "0xEDF7DC", Offset = "0xEDF7DC", VA = "0xEDF7DC")]
		public StreamStart()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xEDA8B8", Offset = "0xEDA8B8", VA = "0xEDA8B8")]
		public StreamStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class Tag : Token
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string handle;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string suffix;

		[Token(Token = "0x17000093")]
		public string Handle
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0xED7D20", Offset = "0xED7D20", VA = "0xED7D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public string Suffix
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0xED7D28", Offset = "0xED7D28", VA = "0xED7D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xEDF858", Offset = "0xEDF858", VA = "0xEDF858")]
		public Tag(string handle, string suffix)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xEDC2F8", Offset = "0xEDC2F8", VA = "0xEDC2F8")]
		public Tag(string handle, string suffix, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BF")]
	public class TagDirective : Token
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string handle;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string prefix;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex tagHandleValidator;

		[Token(Token = "0x17000095")]
		public string Handle
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0xECBA6C", Offset = "0xECBA6C", VA = "0xECBA6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public string Prefix
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0xECBA64", Offset = "0xECBA64", VA = "0xECBA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xEC9BBC", Offset = "0xEC9BBC", VA = "0xEC9BBC")]
		public TagDirective(string handle, string prefix)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xEDE0D8", Offset = "0xEDE0D8", VA = "0xEDE0D8")]
		public TagDirective(string handle, string prefix, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xEDF8E8", Offset = "0xEDF8E8", VA = "0xEDF8E8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xEDF9D8", Offset = "0xEDF9D8", VA = "0xEDF9D8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xEDFA3C", Offset = "0xEDFA3C", VA = "0xEDFA3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C0")]
	public abstract class Token
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Mark start;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Mark end;

		[Token(Token = "0x17000097")]
		public Mark Start
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0xED47C8", Offset = "0xED47C8", VA = "0xED47C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public Mark End
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0xED47D0", Offset = "0xED47D0", VA = "0xED47D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xEDEF84", Offset = "0xEDEF84", VA = "0xEDEF84")]
		protected Token(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class Value : Token
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0xEDFB34", Offset = "0xEDFB34", VA = "0xEDFB34")]
		public Value()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xEDB76C", Offset = "0xEDB76C", VA = "0xEDB76C")]
		public Value(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C2")]
	public class VersionDirective : Token
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Version version;

		[Token(Token = "0x17000099")]
		public Version Version
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xECDA3C", Offset = "0xECDA3C", VA = "0xECDA3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xEDFBB0", Offset = "0xEDFBB0", VA = "0xEDFBB0")]
		public VersionDirective(Version version)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xEDE098", Offset = "0xEDE098", VA = "0xEDE098")]
		public VersionDirective(Version version, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xEDFC3C", Offset = "0xEDFC3C", VA = "0xEDFC3C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xEDFD08", Offset = "0xEDFD08", VA = "0xEDFD08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace YamlDotNet.Core.Events
{
	[Token(Token = "0x20000C3")]
	public class AnchorAlias : ParsingEvent
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x1700009A")]
		internal override EventType Type
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0xED0514", Offset = "0xED0514", VA = "0xED0514", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x1700009B")]
		public string Value
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0xECAB2C", Offset = "0xECAB2C", VA = "0xECAB2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xED051C", Offset = "0xED051C", VA = "0xED051C")]
		public AnchorAlias(string value, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xED0684", Offset = "0xED0684", VA = "0xED0684")]
		public AnchorAlias(string value)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xED0708", Offset = "0xED0708", VA = "0xED0708", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xED0784", Offset = "0xED0784", VA = "0xED0784", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class Comment : ParsingEvent
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674360", Offset = "0x674360")]
		private string <Value>k__BackingField;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674370", Offset = "0x674370")]
		private bool <IsInline>k__BackingField;

		[Token(Token = "0x1700009C")]
		public string Value
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0xECD238", Offset = "0xECD238", VA = "0xECD238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675670", Offset = "0x675670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0xED0844", Offset = "0xED0844", VA = "0xED0844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675680", Offset = "0x675680")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public bool IsInline
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0xECD070", Offset = "0xECD070", VA = "0xECD070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675690", Offset = "0x675690")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0xED084C", Offset = "0xED084C", VA = "0xED084C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6756A0", Offset = "0x6756A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		internal override EventType Type
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0xED0944", Offset = "0xED0944", VA = "0xED0944", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xED0858", Offset = "0xED0858", VA = "0xED0858")]
		public Comment(string value, bool isInline)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xED08F0", Offset = "0xED08F0", VA = "0xED08F0")]
		public Comment(string value, bool isInline, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xED094C", Offset = "0xED094C", VA = "0xED094C", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class DocumentEnd : ParsingEvent
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly bool isImplicit;

		[Token(Token = "0x1700009F")]
		public override int NestingIncrease
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0xED0A10", Offset = "0xED0A10", VA = "0xED0A10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A0")]
		internal override EventType Type
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0xED0A18", Offset = "0xED0A18", VA = "0xED0A18", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000A1")]
		public bool IsImplicit
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xECFF14", Offset = "0xECFF14", VA = "0xECFF14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xED0A20", Offset = "0xED0A20", VA = "0xED0A20")]
		public DocumentEnd(bool isImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xED0A64", Offset = "0xED0A64", VA = "0xED0A64")]
		public DocumentEnd(bool isImplicit)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xED0AF4", Offset = "0xED0AF4", VA = "0xED0AF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xED0BA0", Offset = "0xED0BA0", VA = "0xED0BA0", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class DocumentStart : ParsingEvent
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly TagDirectiveCollection tags;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly VersionDirective version;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x170000A2")]
		public override int NestingIncrease
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xED0C64", Offset = "0xED0C64", VA = "0xED0C64", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A3")]
		internal override EventType Type
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xED0C6C", Offset = "0xED0C6C", VA = "0xED0C6C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000A4")]
		public TagDirectiveCollection Tags
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xECD2B8", Offset = "0xECD2B8", VA = "0xECD2B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public VersionDirective Version
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xECD614", Offset = "0xECD614", VA = "0xECD614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public bool IsImplicit
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xECD2B0", Offset = "0xECD2B0", VA = "0xECD2B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xED0C74", Offset = "0xED0C74", VA = "0xED0C74")]
		public DocumentStart(VersionDirective version, TagDirectiveCollection tags, bool isImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xED0CCC", Offset = "0xED0CCC", VA = "0xED0CCC")]
		public DocumentStart(VersionDirective version, TagDirectiveCollection tags, bool isImplicit)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xED0D70", Offset = "0xED0D70", VA = "0xED0D70")]
		public DocumentStart(Mark start, Mark end)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xED0DB4", Offset = "0xED0DB4", VA = "0xED0DB4")]
		public DocumentStart()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xED0E3C", Offset = "0xED0E3C", VA = "0xED0E3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xED0EE8", Offset = "0xED0EE8", VA = "0xED0EE8", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000C7")]
	internal enum EventType
	{
		[Token(Token = "0x400014F")]
		None,
		[Token(Token = "0x4000150")]
		StreamStart,
		[Token(Token = "0x4000151")]
		StreamEnd,
		[Token(Token = "0x4000152")]
		DocumentStart,
		[Token(Token = "0x4000153")]
		DocumentEnd,
		[Token(Token = "0x4000154")]
		Alias,
		[Token(Token = "0x4000155")]
		Scalar,
		[Token(Token = "0x4000156")]
		SequenceStart,
		[Token(Token = "0x4000157")]
		SequenceEnd,
		[Token(Token = "0x4000158")]
		MappingStart,
		[Token(Token = "0x4000159")]
		MappingEnd,
		[Token(Token = "0x400015A")]
		Comment
	}
	[Token(Token = "0x20000C8")]
	public interface IParsingEventVisitor
	{
		[Token(Token = "0x60004A1")]
		void Visit(AnchorAlias e);

		[Token(Token = "0x60004A2")]
		void Visit(StreamStart e);

		[Token(Token = "0x60004A3")]
		void Visit(StreamEnd e);

		[Token(Token = "0x60004A4")]
		void Visit(DocumentStart e);

		[Token(Token = "0x60004A5")]
		void Visit(DocumentEnd e);

		[Token(Token = "0x60004A6")]
		void Visit(Scalar e);

		[Token(Token = "0x60004A7")]
		void Visit(SequenceStart e);

		[Token(Token = "0x60004A8")]
		void Visit(SequenceEnd e);

		[Token(Token = "0x60004A9")]
		void Visit(MappingStart e);

		[Token(Token = "0x60004AA")]
		void Visit(MappingEnd e);

		[Token(Token = "0x60004AB")]
		void Visit(Comment e);
	}
	[Token(Token = "0x20000C9")]
	public class MappingEnd : ParsingEvent
	{
		[Token(Token = "0x170000A7")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xED0FAC", Offset = "0xED0FAC", VA = "0xED0FAC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A8")]
		internal override EventType Type
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xED0FB4", Offset = "0xED0FB4", VA = "0xED0FB4", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xED0FBC", Offset = "0xED0FBC", VA = "0xED0FBC")]
		public MappingEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xED0FF4", Offset = "0xED0FF4", VA = "0xED0FF4")]
		public MappingEnd()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xED1070", Offset = "0xED1070", VA = "0xED1070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xED10B8", Offset = "0xED10B8", VA = "0xED10B8", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class MappingStart : NodeEvent
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly MappingStyle style;

		[Token(Token = "0x170000A9")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xED117C", Offset = "0xED117C", VA = "0xED117C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AA")]
		internal override EventType Type
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xED1184", Offset = "0xED1184", VA = "0xED1184", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000AB")]
		public bool IsImplicit
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0xED118C", Offset = "0xED118C", VA = "0xED118C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xED1194", Offset = "0xED1194", VA = "0xED1194", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		public MappingStyle Style
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xECFD98", Offset = "0xECFD98", VA = "0xECFD98")]
			get
			{
				return default(MappingStyle);
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xED11A4", Offset = "0xED11A4", VA = "0xED11A4")]
		public MappingStart(string anchor, string tag, bool isImplicit, MappingStyle style, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xED13D0", Offset = "0xED13D0", VA = "0xED13D0")]
		public MappingStart(string anchor, string tag, bool isImplicit, MappingStyle style)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xED1474", Offset = "0xED1474", VA = "0xED1474")]
		public MappingStart()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xED14F8", Offset = "0xED14F8", VA = "0xED14F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xED1720", Offset = "0xED1720", VA = "0xED1720", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public enum MappingStyle
	{
		[Token(Token = "0x400015E")]
		Any,
		[Token(Token = "0x400015F")]
		Block,
		[Token(Token = "0x4000160")]
		Flow
	}
	[Token(Token = "0x20000CC")]
	public abstract class NodeEvent : ParsingEvent
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Regex anchorValidator;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string anchor;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string tag;

		[Token(Token = "0x170000AE")]
		public string Anchor
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xECB4E0", Offset = "0xECB4E0", VA = "0xECB4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public string Tag
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xECB4E8", Offset = "0xECB4E8", VA = "0xECB4E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public abstract bool IsCanonical
		{
			[Token(Token = "0x60004BE")]
			get;
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xED1258", Offset = "0xED1258", VA = "0xED1258")]
		protected NodeEvent(string anchor, string tag, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xED17E4", Offset = "0xED17E4", VA = "0xED17E4")]
		protected NodeEvent(string anchor, string tag)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public abstract class ParsingEvent
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Mark start;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Mark end;

		[Token(Token = "0x170000B1")]
		public virtual int NestingIncrease
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xED18EC", Offset = "0xED18EC", VA = "0xED18EC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B2")]
		internal abstract EventType Type
		{
			[Token(Token = "0x60004C3")]
			get;
		}

		[Token(Token = "0x170000B3")]
		public Mark Start
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xED18F4", Offset = "0xED18F4", VA = "0xED18F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public Mark End
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xED18FC", Offset = "0xED18FC", VA = "0xED18FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C6")]
		public abstract void Accept(IParsingEventVisitor visitor);

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xED064C", Offset = "0xED064C", VA = "0xED064C")]
		internal ParsingEvent(Mark start, Mark end)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class Scalar : NodeEvent
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string value;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly ScalarStyle style;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private readonly bool isPlainImplicit;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private readonly bool isQuotedImplicit;

		[Token(Token = "0x170000B5")]
		internal override EventType Type
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xED1904", Offset = "0xED1904", VA = "0xED1904", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000B6")]
		public string Value
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xECB830", Offset = "0xECB830", VA = "0xECB830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public ScalarStyle Style
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xECE74C", Offset = "0xECE74C", VA = "0xECE74C")]
			get
			{
				return default(ScalarStyle);
			}
		}

		[Token(Token = "0x170000B8")]
		public bool IsPlainImplicit
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xECE754", Offset = "0xECE754", VA = "0xECE754")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B9")]
		public bool IsQuotedImplicit
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xECE75C", Offset = "0xECE75C", VA = "0xECE75C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BA")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xED190C", Offset = "0xED190C", VA = "0xED190C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xED192C", Offset = "0xED192C", VA = "0xED192C")]
		public Scalar(string anchor, string tag, string value, ScalarStyle style, bool isPlainImplicit, bool isQuotedImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xED19FC", Offset = "0xED19FC", VA = "0xED19FC")]
		public Scalar(string anchor, string tag, string value, ScalarStyle style, bool isPlainImplicit, bool isQuotedImplicit)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xED1AC4", Offset = "0xED1AC4", VA = "0xED1AC4")]
		public Scalar(string value)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xED1B68", Offset = "0xED1B68", VA = "0xED1B68")]
		public Scalar(string tag, string value)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xED1C10", Offset = "0xED1C10", VA = "0xED1C10")]
		public Scalar(string anchor, string tag, string value)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xED1CC4", Offset = "0xED1CC4", VA = "0xED1CC4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xED1FA0", Offset = "0xED1FA0", VA = "0xED1FA0", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class SequenceEnd : ParsingEvent
	{
		[Token(Token = "0x170000BB")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xED2064", Offset = "0xED2064", VA = "0xED2064", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BC")]
		internal override EventType Type
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xED206C", Offset = "0xED206C", VA = "0xED206C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xED2074", Offset = "0xED2074", VA = "0xED2074")]
		public SequenceEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xED20AC", Offset = "0xED20AC", VA = "0xED20AC")]
		public SequenceEnd()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xED2128", Offset = "0xED2128", VA = "0xED2128", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xED2170", Offset = "0xED2170", VA = "0xED2170", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class SequenceStart : NodeEvent
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly SequenceStyle style;

		[Token(Token = "0x170000BD")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xED2234", Offset = "0xED2234", VA = "0xED2234", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BE")]
		internal override EventType Type
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xED223C", Offset = "0xED223C", VA = "0xED223C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000BF")]
		public bool IsImplicit
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xED2244", Offset = "0xED2244", VA = "0xED2244")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xED224C", Offset = "0xED224C", VA = "0xED224C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		public SequenceStyle Style
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xECFC40", Offset = "0xECFC40", VA = "0xECFC40")]
			get
			{
				return default(SequenceStyle);
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xED225C", Offset = "0xED225C", VA = "0xED225C")]
		public SequenceStart(string anchor, string tag, bool isImplicit, SequenceStyle style, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xED2310", Offset = "0xED2310", VA = "0xED2310")]
		public SequenceStart(string anchor, string tag, bool isImplicit, SequenceStyle style)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xED23B4", Offset = "0xED23B4", VA = "0xED23B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xED25DC", Offset = "0xED25DC", VA = "0xED25DC", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public enum SequenceStyle
	{
		[Token(Token = "0x400016D")]
		Any,
		[Token(Token = "0x400016E")]
		Block,
		[Token(Token = "0x400016F")]
		Flow
	}
	[Token(Token = "0x20000D2")]
	public class StreamEnd : ParsingEvent
	{
		[Token(Token = "0x170000C2")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xED26A0", Offset = "0xED26A0", VA = "0xED26A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C3")]
		internal override EventType Type
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xED26A8", Offset = "0xED26A8", VA = "0xED26A8", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xED26B0", Offset = "0xED26B0", VA = "0xED26B0")]
		public StreamEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xED26E8", Offset = "0xED26E8", VA = "0xED26E8")]
		public StreamEnd()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xED2764", Offset = "0xED2764", VA = "0xED2764", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xED27AC", Offset = "0xED27AC", VA = "0xED27AC", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class StreamStart : ParsingEvent
	{
		[Token(Token = "0x170000C4")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xED2870", Offset = "0xED2870", VA = "0xED2870", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C5")]
		internal override EventType Type
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xED2878", Offset = "0xED2878", VA = "0xED2878", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xED2880", Offset = "0xED2880", VA = "0xED2880")]
		public StreamStart()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xED28FC", Offset = "0xED28FC", VA = "0xED28FC")]
		public StreamStart(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xED2934", Offset = "0xED2934", VA = "0xED2934", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xED297C", Offset = "0xED297C", VA = "0xED297C", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
}
