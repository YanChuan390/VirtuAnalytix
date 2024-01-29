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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF18", Offset = "0x80AF18")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BindingFlags instancePublic;

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x125DD44", Offset = "0x125DD44", VA = "0x125DD44")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x125E02C", Offset = "0x125E02C", VA = "0x125E02C")]
			internal IEnumerable<PropertyInfo> <GetPublicProperties>b__0(Type i)
			{
				return null;
			}
		}

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly FieldInfo remoteStackTraceField;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x125D940", Offset = "0x125D940", VA = "0x125D940")]
		public static Type BaseType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x125D974", Offset = "0x125D974", VA = "0x125D974")]
		public static bool IsValueType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x125D9A0", Offset = "0x125D9A0", VA = "0x125D9A0")]
		public static bool IsGenericType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x125D9D4", Offset = "0x125D9D4", VA = "0x125D9D4")]
		public static bool IsInterface(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x125DA00", Offset = "0x125DA00", VA = "0x125DA00")]
		public static bool IsEnum(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x125DA34", Offset = "0x125DA34", VA = "0x125DA34")]
		public static bool HasDefaultConstructor(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x125DB28", Offset = "0x125DB28", VA = "0x125DB28")]
		public static TypeCode GetTypeCode(this Type type)
		{
			return default(TypeCode);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x125BF24", Offset = "0x125BF24", VA = "0x125BF24")]
		public static PropertyInfo GetPublicProperty(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x125DB90", Offset = "0x125DB90", VA = "0x125DB90")]
		public static IEnumerable<PropertyInfo> GetPublicProperties(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x125DD4C", Offset = "0x125DD4C", VA = "0x125DD4C")]
		public static IEnumerable<MethodInfo> GetPublicStaticMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x125DD84", Offset = "0x125DD84", VA = "0x125DD84")]
		public static MethodInfo GetPublicStaticMethod(this Type type, string name, params Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x125BEEC", Offset = "0x125BEEC", VA = "0x125BEEC")]
		public static MethodInfo GetPublicInstanceMethod(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x125DDD4", Offset = "0x125DDD4", VA = "0x125DDD4")]
		public static Exception Unwrap(this TargetInvocationException ex)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x125DF38", Offset = "0x125DF38", VA = "0x125DF38")]
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
		[Address(RVA = "0x125BB54", Offset = "0x125BB54", VA = "0x125BB54")]
		public CultureInfoAdapter(CultureInfo baseCulture, IFormatProvider provider)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x125BBF4", Offset = "0x125BBF4", VA = "0x125BBF4", Slot = "19")]
		public override object GetFormat(Type formatType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000005")]
	internal static class PropertyInfoExtensions
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x125D8F0", Offset = "0x125D8F0", VA = "0x125D8F0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF28", Offset = "0x80AF28")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF38", Offset = "0x80AF38")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF48", Offset = "0x80AF48")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF58", Offset = "0x80AF58")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF68", Offset = "0x80AF68")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF78", Offset = "0x80AF78")]
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
				[Address(RVA = "0xFE3C1C", Offset = "0xFE3C1C", VA = "0xFE3C1C", Slot = "4")]
				public IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
				{
					return null;
				}

				[Token(Token = "0x600065F")]
				[Address(RVA = "0xFE3CE8", Offset = "0xFE3CE8", VA = "0xFE3CE8", Slot = "5")]
				public IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched)
				{
					return null;
				}

				[Token(Token = "0x6000660")]
				[Address(RVA = "0xFE3760", Offset = "0xFE3760", VA = "0xFE3760")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B7E0", Offset = "0x80B7E0")]
			private IList<INodeDeserializer> <NodeDeserializers>k__BackingField;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B7F0", Offset = "0x80B7F0")]
			private IList<INodeTypeResolver> <TypeResolvers>k__BackingField;

			[Token(Token = "0x170000C6")]
			public IList<INodeDeserializer> NodeDeserializers
			{
				[Token(Token = "0x6000501")]
				[Address(RVA = "0xFE21EC", Offset = "0xFE21EC", VA = "0xFE21EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CB10", Offset = "0x80CB10")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000502")]
				[Address(RVA = "0xFE3750", Offset = "0xFE3750", VA = "0xFE3750")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CB20", Offset = "0x80CB20")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			public IList<INodeTypeResolver> TypeResolvers
			{
				[Token(Token = "0x6000503")]
				[Address(RVA = "0xFE2228", Offset = "0xFE2228", VA = "0xFE2228")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CB30", Offset = "0x80CB30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000504")]
				[Address(RVA = "0xFE3758", Offset = "0xFE3758", VA = "0xFE3758")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CB40", Offset = "0x80CB40")]
				private set
				{
				}
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0xFE22DC", Offset = "0xFE22DC", VA = "0xFE22DC")]
			public BackwardsCompatibleConfiguration(IObjectFactory objectFactory, INamingConvention namingConvention, bool ignoreUnmatched, YamlAttributeOverrides overrides)
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0xFE2F38", Offset = "0xFE2F38", VA = "0xFE2F38")]
			public void RegisterTagMapping(string tag, Type type)
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0xFE2FEC", Offset = "0xFE2FEC", VA = "0xFE2FEC")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80D1E4", Offset = "0x80D1E4")]
		public IList<INodeDeserializer> NodeDeserializers
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xFE21B8", Offset = "0xFE21B8", VA = "0xFE21B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80D21C", Offset = "0x80D21C")]
		public IList<INodeTypeResolver> TypeResolvers
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xFE21F4", Offset = "0xFE21F4", VA = "0xFE21F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xFE212C", Offset = "0xFE212C", VA = "0xFE212C")]
		private void ThrowUnlessInBackwardsCompatibleMode()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xFE2230", Offset = "0xFE2230", VA = "0xFE2230")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80BA50", Offset = "0x80BA50")]
		public Deserializer([Optional] IObjectFactory objectFactory, [Optional] INamingConvention namingConvention, bool ignoreUnmatched = false, [Optional] YamlAttributeOverrides overrides)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xFE2EEC", Offset = "0xFE2EEC", VA = "0xFE2EEC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80BA88", Offset = "0x80BA88")]
		public void RegisterTagMapping(string tag, Type type)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xFE2FB0", Offset = "0xFE2FB0", VA = "0xFE2FB0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80BAC0", Offset = "0x80BAC0")]
		public void RegisterTypeConverter(IYamlTypeConverter typeConverter)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xFE3060", Offset = "0xFE3060", VA = "0xFE3060")]
		public Deserializer()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xFE30EC", Offset = "0xFE30EC", VA = "0xFE30EC")]
		private Deserializer(IValueDeserializer valueDeserializer)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xFE3190", Offset = "0xFE3190", VA = "0xFE3190")]
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
		[Address(RVA = "0xFDD158", Offset = "0xFDD158", VA = "0xFDD158")]
		public object Deserialize(TextReader input)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xFE326C", Offset = "0xFE326C", VA = "0xFE326C")]
		public object Deserialize(string input, Type type)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xFE31F0", Offset = "0xFE31F0", VA = "0xFE31F0")]
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
		[Address(RVA = "0xFE36C0", Offset = "0xFE36C0", VA = "0xFE36C0")]
		public object Deserialize(IParser parser)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xFE33AC", Offset = "0xFE33AC", VA = "0xFE33AC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF88", Offset = "0x80AF88")]
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
			[Address(RVA = "0xFE4F78", Offset = "0xFE4F78", VA = "0xFE4F78")]
			public <>c()
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0xFE4F80", Offset = "0xFE4F80", VA = "0xFE4F80")]
			internal ITypeInspector <.ctor>b__5_0(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0xFE4FE4", Offset = "0xFE4FE4", VA = "0xFE4FE4")]
			internal ITypeInspector <.ctor>b__5_2(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0xFE5048", Offset = "0xFE5048", VA = "0xFE5048")]
			internal ITypeInspector <.ctor>b__5_4(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0xFE50AC", Offset = "0xFE50AC", VA = "0xFE50AC")]
			internal INodeDeserializer <.ctor>b__5_8(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0xFE5108", Offset = "0xFE5108", VA = "0xFE5108")]
			internal INodeDeserializer <.ctor>b__5_9(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0xFE5164", Offset = "0xFE5164", VA = "0xFE5164")]
			internal INodeDeserializer <.ctor>b__5_10(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0xFE51C0", Offset = "0xFE51C0", VA = "0xFE51C0")]
			internal INodeDeserializer <.ctor>b__5_13(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0xFE521C", Offset = "0xFE521C", VA = "0xFE521C")]
			internal INodeTypeResolver <.ctor>b__5_15(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0xFE5278", Offset = "0xFE5278", VA = "0xFE5278")]
			internal INodeTypeResolver <.ctor>b__5_16(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0xFE52D4", Offset = "0xFE52D4", VA = "0xFE52D4")]
			internal INodeTypeResolver <.ctor>b__5_18(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0xFE5330", Offset = "0xFE5330", VA = "0xFE5330")]
			internal INodeTypeResolver <.ctor>b__5_19(Nothing _)
			{
				return null;
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0xFE538C", Offset = "0xFE538C", VA = "0xFE538C")]
			internal void <WithNodeDeserializer>b__10_0(IRegistrationLocationSelectionSyntax<INodeDeserializer> w)
			{
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0xFE5440", Offset = "0xFE5440", VA = "0xFE5440")]
			internal void <WithNodeTypeResolver>b__15_0(IRegistrationLocationSelectionSyntax<INodeTypeResolver> w)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AF98", Offset = "0x80AF98")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public INodeDeserializer nodeDeserializer;

			[Token(Token = "0x6000518")]
			[Address(RVA = "0xFE4284", Offset = "0xFE4284", VA = "0xFE4284")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000519")]
			[Address(RVA = "0xFE54F4", Offset = "0xFE54F4", VA = "0xFE54F4")]
			internal INodeDeserializer <WithNodeDeserializer>b__0(Nothing _)
			{
				return null;
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AFA8", Offset = "0x80AFA8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AFB8", Offset = "0x80AFB8")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public INodeTypeResolver nodeTypeResolver;

			[Token(Token = "0x600051C")]
			[Address(RVA = "0xFE4634", Offset = "0xFE4634", VA = "0xFE4634")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600051D")]
			[Address(RVA = "0xFE54FC", Offset = "0xFE54FC", VA = "0xFE54FC")]
			internal INodeTypeResolver <WithNodeTypeResolver>b__0(Nothing _)
			{
				return null;
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AFC8", Offset = "0x80AFC8")]
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
			[Address(RVA = "0xFE3DD0", Offset = "0xFE3DD0", VA = "0xFE3DD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xFDC110", Offset = "0xFDC110", VA = "0xFDC110")]
		public DeserializerBuilder()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xFE3DD4", Offset = "0xFE3DD4", VA = "0xFE3DD4")]
		public DeserializerBuilder WithObjectFactory(IObjectFactory objectFactory)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xFE3E70", Offset = "0xFE3E70", VA = "0xFE3E70")]
		public DeserializerBuilder WithObjectFactory(Func<Type, object> objectFactory)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xFE3FCC", Offset = "0xFE3FCC", VA = "0xFE3FCC")]
		public DeserializerBuilder WithNodeDeserializer(INodeDeserializer nodeDeserializer)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xFE40D0", Offset = "0xFE40D0", VA = "0xFE40D0")]
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
		[Address(RVA = "0xFE428C", Offset = "0xFE428C", VA = "0xFE428C")]
		public DeserializerBuilder WithoutNodeDeserializer(Type nodeDeserializerType)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xFE437C", Offset = "0xFE437C", VA = "0xFE437C")]
		public DeserializerBuilder WithNodeTypeResolver(INodeTypeResolver nodeTypeResolver)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xFE4480", Offset = "0xFE4480", VA = "0xFE4480")]
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
		[Address(RVA = "0xFE463C", Offset = "0xFE463C", VA = "0xFE463C")]
		public DeserializerBuilder WithoutNodeTypeResolver(Type nodeTypeResolverType)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xFE472C", Offset = "0xFE472C", VA = "0xFE472C")]
		public DeserializerBuilder WithTagMapping(string tag, Type type)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xFE4908", Offset = "0xFE4908", VA = "0xFE4908")]
		public DeserializerBuilder WithoutTagMapping(string tag)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xFE4A1C", Offset = "0xFE4A1C", VA = "0xFE4A1C")]
		public DeserializerBuilder IgnoreUnmatchedProperties()
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xFDD144", Offset = "0xFDD144", VA = "0xFDD144")]
		public Deserializer Build()
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xFE4A28", Offset = "0xFE4A28", VA = "0xFE4A28")]
		public IValueDeserializer BuildValueDeserializer()
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xFE4AF0", Offset = "0xFE4AF0", VA = "0xFE4AF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BAF8", Offset = "0x80BAF8")]
		private ITypeInspector <.ctor>b__5_1(ITypeInspector inner)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xFE4B70", Offset = "0xFE4B70", VA = "0xFE4B70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB08", Offset = "0x80BB08")]
		private ITypeInspector <.ctor>b__5_3(ITypeInspector inner)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xFE4C00", Offset = "0xFE4C00", VA = "0xFE4C00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB18", Offset = "0x80BB18")]
		private INodeDeserializer <.ctor>b__5_5(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xFE4C68", Offset = "0xFE4C68", VA = "0xFE4C68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB28", Offset = "0x80BB28")]
		private INodeDeserializer <.ctor>b__5_6(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xFE4CD0", Offset = "0xFE4CD0", VA = "0xFE4CD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB38", Offset = "0x80BB38")]
		private INodeDeserializer <.ctor>b__5_7(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xFE4D4C", Offset = "0xFE4D4C", VA = "0xFE4D4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB48", Offset = "0x80BB48")]
		private INodeDeserializer <.ctor>b__5_11(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xFE4DB4", Offset = "0xFE4DB4", VA = "0xFE4DB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB58", Offset = "0x80BB58")]
		private INodeDeserializer <.ctor>b__5_12(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xFE4E1C", Offset = "0xFE4E1C", VA = "0xFE4E1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB68", Offset = "0x80BB68")]
		private INodeDeserializer <.ctor>b__5_14(Nothing _)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xFE4EB0", Offset = "0xFE4EB0", VA = "0xFE4EB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB78", Offset = "0x80BB78")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B320", Offset = "0x80B320")]
		private IObjectGraphVisitor<IEmitter> <InnerVisitor>k__BackingField;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B330", Offset = "0x80B330")]
		private IEventEmitter <EventEmitter>k__BackingField;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B340", Offset = "0x80B340")]
		private ObjectSerializer <NestedObjectSerializer>k__BackingField;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B350", Offset = "0x80B350")]
		private IEnumerable<IYamlTypeConverter> <TypeConverters>k__BackingField;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IEnumerable<IObjectGraphVisitor<Nothing>> preProcessingPhaseVisitors;

		[Token(Token = "0x17000005")]
		public IObjectGraphVisitor<IEmitter> InnerVisitor
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xFE5504", Offset = "0xFE5504", VA = "0xFE5504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB88", Offset = "0x80BB88")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xFE550C", Offset = "0xFE550C", VA = "0xFE550C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BB98", Offset = "0x80BB98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public IEventEmitter EventEmitter
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xFE5514", Offset = "0xFE5514", VA = "0xFE5514")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BBA8", Offset = "0x80BBA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xFE551C", Offset = "0xFE551C", VA = "0xFE551C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BBB8", Offset = "0x80BBB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public ObjectSerializer NestedObjectSerializer
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xFE5524", Offset = "0xFE5524", VA = "0xFE5524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BBC8", Offset = "0x80BBC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xFE552C", Offset = "0xFE552C", VA = "0xFE552C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BBD8", Offset = "0x80BBD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public IEnumerable<IYamlTypeConverter> TypeConverters
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xFE5534", Offset = "0xFE5534", VA = "0xFE5534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BBE8", Offset = "0x80BBE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0xFE553C", Offset = "0xFE553C", VA = "0xFE553C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BBF8", Offset = "0x80BBF8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xFE5544", Offset = "0xFE5544", VA = "0xFE5544")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B360", Offset = "0x80B360")]
		private IObjectDescriptor <Source>k__BackingField;

		[Token(Token = "0x17000009")]
		public IObjectDescriptor Source
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0xFE5EC8", Offset = "0xFE5EC8", VA = "0xFE5EC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC08", Offset = "0x80BC08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xFE7C54", Offset = "0xFE7C54", VA = "0xFE7C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC18", Offset = "0x80BC18")]
			private set
			{
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xFE1650", Offset = "0xFE1650", VA = "0xFE1650")]
		protected EventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class AliasEventInfo : EventInfo
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B370", Offset = "0x80B370")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x1700000A")]
		public string Alias
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xFE167C", Offset = "0xFE167C", VA = "0xFE167C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC28", Offset = "0x80BC28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xFE1684", Offset = "0xFE1684", VA = "0xFE1684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC38", Offset = "0x80BC38")]
			set
			{
			}
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xFE1624", Offset = "0xFE1624", VA = "0xFE1624")]
		public AliasEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class ObjectEventInfo : EventInfo
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B380", Offset = "0x80B380")]
		private string <Anchor>k__BackingField;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B390", Offset = "0x80B390")]
		private string <Tag>k__BackingField;

		[Token(Token = "0x1700000B")]
		public string Anchor
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xFE77D4", Offset = "0xFE77D4", VA = "0xFE77D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC48", Offset = "0x80BC48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xFECA70", Offset = "0xFECA70", VA = "0xFECA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC58", Offset = "0x80BC58")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public string Tag
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xFE77DC", Offset = "0xFE77DC", VA = "0xFE77DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC68", Offset = "0x80BC68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xFE5ED0", Offset = "0xFE5ED0", VA = "0xFE5ED0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC78", Offset = "0x80BC78")]
			set
			{
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xFE7CB4", Offset = "0xFE7CB4", VA = "0xFE7CB4")]
		protected ObjectEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public sealed class ScalarEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B3A0", Offset = "0x80B3A0")]
		private string <RenderedValue>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B3B0", Offset = "0x80B3B0")]
		private ScalarStyle <Style>k__BackingField;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B3C0", Offset = "0x80B3C0")]
		private bool <IsPlainImplicit>k__BackingField;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B3D0", Offset = "0x80B3D0")]
		private bool <IsQuotedImplicit>k__BackingField;

		[Token(Token = "0x1700000D")]
		public string RenderedValue
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xFE77E4", Offset = "0xFE77E4", VA = "0xFE77E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC88", Offset = "0x80BC88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0xFE66AC", Offset = "0xFE66AC", VA = "0xFE66AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BC98", Offset = "0x80BC98")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xFE71F8", Offset = "0xFE71F8", VA = "0xFE71F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BCA8", Offset = "0x80BCA8")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xFE66A4", Offset = "0xFE66A4", VA = "0xFE66A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BCB8", Offset = "0x80BCB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool IsPlainImplicit
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xFE77EC", Offset = "0xFE77EC", VA = "0xFE77EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BCC8", Offset = "0x80BCC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xFE6698", Offset = "0xFE6698", VA = "0xFE6698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BCD8", Offset = "0x80BCD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool IsQuotedImplicit
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xFE77F4", Offset = "0xFE77F4", VA = "0xFE77F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BCE8", Offset = "0x80BCE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xFF0C70", Offset = "0xFF0C70", VA = "0xFF0C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BCF8", Offset = "0x80BCF8")]
			set
			{
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xFEE218", Offset = "0xFEE218", VA = "0xFEE218")]
		public ScalarEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public sealed class MappingStartEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B3E0", Offset = "0x80B3E0")]
		private bool <IsImplicit>k__BackingField;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B3F0", Offset = "0x80B3F0")]
		private MappingStyle <Style>k__BackingField;

		[Token(Token = "0x17000011")]
		public bool IsImplicit
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xFE7944", Offset = "0xFE7944", VA = "0xFE7944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BD08", Offset = "0x80BD08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xFE7CE0", Offset = "0xFE7CE0", VA = "0xFE7CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BD18", Offset = "0x80BD18")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public MappingStyle Style
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xFE794C", Offset = "0xFE794C", VA = "0xFE794C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BD28", Offset = "0x80BD28")]
			get
			{
				return default(MappingStyle);
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xFE6700", Offset = "0xFE6700", VA = "0xFE6700")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BD38", Offset = "0x80BD38")]
			set
			{
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xFE7C88", Offset = "0xFE7C88", VA = "0xFE7C88")]
		public MappingStartEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000011")]
	public sealed class MappingEndEventInfo : EventInfo
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xFE7C5C", Offset = "0xFE7C5C", VA = "0xFE7C5C")]
		public MappingEndEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public sealed class SequenceStartEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B400", Offset = "0x80B400")]
		private bool <IsImplicit>k__BackingField;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B410", Offset = "0x80B410")]
		private SequenceStyle <Style>k__BackingField;

		[Token(Token = "0x17000013")]
		public bool IsImplicit
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xFE7B6C", Offset = "0xFE7B6C", VA = "0xFE7B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BD48", Offset = "0x80BD48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xFF0C7C", Offset = "0xFF0C7C", VA = "0xFF0C7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BD58", Offset = "0x80BD58")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public SequenceStyle Style
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xFE7B74", Offset = "0xFE7B74", VA = "0xFE7B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BD68", Offset = "0x80BD68")]
			get
			{
				return default(SequenceStyle);
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xFE6754", Offset = "0xFE6754", VA = "0xFE6754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BD78", Offset = "0x80BD78")]
			set
			{
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xFEDFF0", Offset = "0xFEDFF0", VA = "0xFEDFF0")]
		public SequenceStartEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public sealed class SequenceEndEventInfo : EventInfo
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xFEF9B0", Offset = "0xFEF9B0", VA = "0xFEF9B0")]
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
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80AC48", Offset = "0x80AC48")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B2E0", Offset = "0x80B2E0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AFD8", Offset = "0x80AFD8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AFE8", Offset = "0x80AFE8")]
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
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80BDA8", Offset = "0x80BDA8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80AFF8", Offset = "0x80AFF8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B008", Offset = "0x80B008")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B018", Offset = "0x80B018")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B028", Offset = "0x80B028")]
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
		[Address(RVA = "0xFEC164", Offset = "0xFEC164", VA = "0xFEC164")]
		private Nothing()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public sealed class ObjectDescriptor : IObjectDescriptor
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B420", Offset = "0x80B420")]
		private object <Value>k__BackingField;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B430", Offset = "0x80B430")]
		private Type <Type>k__BackingField;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B440", Offset = "0x80B440")]
		private Type <StaticType>k__BackingField;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B450", Offset = "0x80B450")]
		private ScalarStyle <ScalarStyle>k__BackingField;

		[Token(Token = "0x17000021")]
		public object Value
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xFEC16C", Offset = "0xFEC16C", VA = "0xFEC16C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BE4C", Offset = "0x80BE4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xFEC174", Offset = "0xFEC174", VA = "0xFEC174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BE5C", Offset = "0x80BE5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Type Type
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xFEC17C", Offset = "0xFEC17C", VA = "0xFEC17C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BE6C", Offset = "0x80BE6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xFEC184", Offset = "0xFEC184", VA = "0xFEC184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BE7C", Offset = "0x80BE7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Type StaticType
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xFEC18C", Offset = "0xFEC18C", VA = "0xFEC18C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BE8C", Offset = "0x80BE8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xFEC194", Offset = "0xFEC194", VA = "0xFEC194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BE9C", Offset = "0x80BE9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xFEC19C", Offset = "0xFEC19C", VA = "0xFEC19C", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BEAC", Offset = "0x80BEAC")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xFEC1A4", Offset = "0xFEC1A4", VA = "0xFEC1A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BEBC", Offset = "0x80BEBC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xFEC1AC", Offset = "0xFEC1AC", VA = "0xFEC1AC")]
		public ObjectDescriptor(object value, Type type, Type staticType)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xFEC1B4", Offset = "0xFEC1B4", VA = "0xFEC1B4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B460", Offset = "0x80B460")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B470", Offset = "0x80B470")]
		private int <Order>k__BackingField;

		[Token(Token = "0x17000025")]
		public string Name
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xFF0650", Offset = "0xFF0650", VA = "0xFF0650", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BECC", Offset = "0x80BECC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xFF0648", Offset = "0xFF0648", VA = "0xFF0648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BEDC", Offset = "0x80BEDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Type Type
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xFF0658", Offset = "0xFF0658", VA = "0xFF0658", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public Type TypeOverride
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xFF0710", Offset = "0xFF0710", VA = "0xFF0710", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xFF07C8", Offset = "0xFF07C8", VA = "0xFF07C8", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int Order
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xFF0890", Offset = "0xFF0890", VA = "0xFF0890", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BEEC", Offset = "0x80BEEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xFF0898", Offset = "0xFF0898", VA = "0xFF0898", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BEFC", Offset = "0x80BEFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xFF08A0", Offset = "0xFF08A0", VA = "0xFF08A0", Slot = "11")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xFF0958", Offset = "0xFF0958", VA = "0xFF0958", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool CanWrite
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xFF0A20", Offset = "0xFF0A20", VA = "0xFF0A20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xFF0574", Offset = "0xFF0574", VA = "0xFF0574")]
		public PropertyDescriptor(IPropertyDescriptor baseDescriptor)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xFF0AD8", Offset = "0xFF0AD8", VA = "0xFF0AD8", Slot = "15")]
		public void Write(object target, object value)
		{
		}

		[Token(Token = "0x60000EC")]
		public T GetCustomAttribute<T>() where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xFF0BA8", Offset = "0xFF0BA8", VA = "0xFF0BA8", Slot = "14")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B2F0", Offset = "0x80B2F0")]
			private sealed class <>c__DisplayClass10_0
			{
				[Token(Token = "0x4000256")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public BackwardsCompatibleConfiguration <>4__this;

				[Token(Token = "0x4000257")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public IEmitter emitter;

				[Token(Token = "0x6000663")]
				[Address(RVA = "0xFF19E4", Offset = "0xFF19E4", VA = "0xFF19E4")]
				public <>c__DisplayClass10_0()
				{
				}

				[Token(Token = "0x6000664")]
				[Address(RVA = "0xFF1E68", Offset = "0xFF1E68", VA = "0xFF1E68")]
				internal void <CreateEmittingVisitor>b__0(object v, Type t)
				{
				}
			}

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B800", Offset = "0x80B800")]
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
				[Address(RVA = "0xFF1030", Offset = "0xFF1030", VA = "0xFF1030")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CBC0", Offset = "0x80CBC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000540")]
				[Address(RVA = "0xFF178C", Offset = "0xFF178C", VA = "0xFF178C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CBD0", Offset = "0x80CBD0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0xFF0DA4", Offset = "0xFF0DA4", VA = "0xFF0DA4")]
			public BackwardsCompatibleConfiguration(SerializationOptions options, INamingConvention namingConvention, YamlAttributeOverrides overrides)
			{
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0xFF1794", Offset = "0xFF1794", VA = "0xFF1794")]
			public bool IsOptionSet(SerializationOptions option)
			{
				return default(bool);
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xFF17A4", Offset = "0xFF17A4", VA = "0xFF17A4")]
			private IObjectGraphVisitor<IEmitter> CreateEmittingVisitor(IEmitter emitter, IObjectGraphTraversalStrategy traversalStrategy, IEventEmitter eventEmitter, IObjectDescriptor graph)
			{
				return null;
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xFF19EC", Offset = "0xFF19EC", VA = "0xFF19EC")]
			private IEventEmitter CreateEventEmitter()
			{
				return null;
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xFF1AA0", Offset = "0xFF1AA0", VA = "0xFF1AA0")]
			private IObjectGraphTraversalStrategy CreateTraversalStrategy()
			{
				return null;
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0xFF1C44", Offset = "0xFF1C44", VA = "0xFF1C44", Slot = "4")]
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
		[Address(RVA = "0xFF0C88", Offset = "0xFF0C88", VA = "0xFF0C88")]
		private void ThrowUnlessInBackwardsCompatibleMode()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xFF0D14", Offset = "0xFF0D14", VA = "0xFF0D14")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80BF0C", Offset = "0x80BF0C")]
		public Serializer(SerializationOptions options = SerializationOptions.None, [Optional] INamingConvention namingConvention, [Optional] YamlAttributeOverrides overrides)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xFF0F4C", Offset = "0xFF0F4C", VA = "0xFF0F4C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80BF44", Offset = "0x80BF44")]
		public void RegisterTypeConverter(IYamlTypeConverter converter)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xFF1038", Offset = "0xFF1038", VA = "0xFF1038")]
		public Serializer()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xFF10AC", Offset = "0xFF10AC", VA = "0xFF10AC")]
		private Serializer(IValueSerializer valueSerializer)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xFF1150", Offset = "0xFF1150", VA = "0xFF1150")]
		public static Serializer FromValueSerializer(IValueSerializer valueSerializer)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xFF11B0", Offset = "0xFF11B0", VA = "0xFF11B0")]
		public void Serialize(TextWriter writer, object graph)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xFDDDC0", Offset = "0xFDDDC0", VA = "0xFDDDC0")]
		public string Serialize(object graph)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xFF12D4", Offset = "0xFF12D4", VA = "0xFF12D4")]
		public void Serialize(TextWriter writer, object graph, Type type)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xFF122C", Offset = "0xFF122C", VA = "0xFF122C")]
		public void Serialize(IEmitter emitter, object graph)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xFF1360", Offset = "0xFF1360", VA = "0xFF1360")]
		public void Serialize(IEmitter emitter, object graph, Type type)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xFF1464", Offset = "0xFF1464", VA = "0xFF1464")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B300", Offset = "0x80B300")]
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
				[Address(RVA = "0x18E5E70", Offset = "0x18E5E70", VA = "0x18E5E70")]
				public <>c__DisplayClass6_0()
				{
				}

				[Token(Token = "0x6000666")]
				[Address(RVA = "0x18E5E78", Offset = "0x18E5E78", VA = "0x18E5E78")]
				internal void <SerializeValue>b__0(object v, Type t)
				{
				}

				[Token(Token = "0x6000667")]
				[Address(RVA = "0x18E5EC4", Offset = "0x18E5EC4", VA = "0x18E5EC4")]
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
			[Address(RVA = "0xFF2C24", Offset = "0xFF2C24", VA = "0xFF2C24")]
			public ValueSerializer(IObjectGraphTraversalStrategy traversalStrategy, IEventEmitter eventEmitter, IEnumerable<IYamlTypeConverter> typeConverters, LazyComponentRegistrationList<IEnumerable<IYamlTypeConverter>, IObjectGraphVisitor<Nothing>> preProcessingPhaseObjectGraphVisitorFactories, LazyComponentRegistrationList<EmissionPhaseObjectGraphVisitorArgs, IObjectGraphVisitor<IEmitter>> emissionPhaseObjectGraphVisitorFactories)
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0xFF3738", Offset = "0xFF3738", VA = "0xFF3738", Slot = "4")]
			public void SerializeValue(IEmitter emitter, object value, Type type)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B038", Offset = "0x80B038")]
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
			[Address(RVA = "0xFF2F00", Offset = "0xFF2F00", VA = "0xFF2F00")]
			public <>c()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xFF2F08", Offset = "0xFF2F08", VA = "0xFF2F08")]
			internal ITypeInspector <.ctor>b__5_0(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0xFF2F6C", Offset = "0xFF2F6C", VA = "0xFF2F6C")]
			internal ITypeInspector <.ctor>b__5_2(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0xFF2FD0", Offset = "0xFF2FD0", VA = "0xFF2FD0")]
			internal IObjectGraphVisitor<Nothing> <.ctor>b__5_4(IEnumerable<IYamlTypeConverter> typeConverters)
			{
				return null;
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0xFF3030", Offset = "0xFF3030", VA = "0xFF3030")]
			internal IObjectGraphVisitor<IEmitter> <.ctor>b__5_5(EmissionPhaseObjectGraphVisitorArgs args)
			{
				return null;
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0xFF30DC", Offset = "0xFF30DC", VA = "0xFF30DC")]
			internal IObjectGraphVisitor<IEmitter> <.ctor>b__5_6(EmissionPhaseObjectGraphVisitorArgs args)
			{
				return null;
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0xFF319C", Offset = "0xFF319C", VA = "0xFF319C")]
			internal IObjectGraphVisitor<IEmitter> <.ctor>b__5_7(EmissionPhaseObjectGraphVisitorArgs args)
			{
				return null;
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0xFF3210", Offset = "0xFF3210", VA = "0xFF3210")]
			internal IEventEmitter <.ctor>b__5_8(IEventEmitter inner)
			{
				return null;
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0xFF3274", Offset = "0xFF3274", VA = "0xFF3274")]
			internal IObjectGraphTraversalStrategy <EnsureRoundtrip>b__15_0(ITypeInspector typeInspector, ITypeResolver typeResolver, IEnumerable<IYamlTypeConverter> typeConverters)
			{
				return null;
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0xFF32F4", Offset = "0xFF32F4", VA = "0xFF32F4")]
			internal TypeAssigningEventEmitter <EnsureRoundtrip>b__15_1(IEventEmitter inner)
			{
				return null;
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0xFF335C", Offset = "0xFF335C", VA = "0xFF335C")]
			internal void <EnsureRoundtrip>b__15_2(IRegistrationLocationSelectionSyntax<IEventEmitter> loc)
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0xFF3428", Offset = "0xFF3428", VA = "0xFF3428")]
			internal ReadableAndWritablePropertiesTypeInspector <EnsureRoundtrip>b__15_3(ITypeInspector inner)
			{
				return null;
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0xFF348C", Offset = "0xFF348C", VA = "0xFF348C")]
			internal void <EnsureRoundtrip>b__15_4(IRegistrationLocationSelectionSyntax<ITypeInspector> loc)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0xFF3540", Offset = "0xFF3540", VA = "0xFF3540")]
			internal void <JsonCompatible>b__18_0(IRegistrationLocationSelectionSyntax<IYamlTypeConverter> w)
			{
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0xFF360C", Offset = "0xFF360C", VA = "0xFF360C")]
			internal JsonEventEmitter <JsonCompatible>b__18_1(IEventEmitter inner)
			{
				return null;
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xFF366C", Offset = "0xFF366C", VA = "0xFF366C")]
			internal void <JsonCompatible>b__18_2(IRegistrationLocationSelectionSyntax<IEventEmitter> loc)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B048", Offset = "0x80B048")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B058", Offset = "0x80B058")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B068", Offset = "0x80B068")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B078", Offset = "0x80B078")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B088", Offset = "0x80B088")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B098", Offset = "0x80B098")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B0A8", Offset = "0x80B0A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B0B8", Offset = "0x80B0B8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B0C8", Offset = "0x80B0C8")]
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
			[Address(RVA = "0xFF1EB0", Offset = "0xFF1EB0", VA = "0xFF1EB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xFDD1E8", Offset = "0xFDD1E8", VA = "0xFDD1E8")]
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
		[Address(RVA = "0xFF1EB4", Offset = "0xFF1EB4", VA = "0xFF1EB4")]
		public SerializerBuilder WithoutEventEmitter(Type eventEmitterType)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xFF1FA4", Offset = "0xFF1FA4", VA = "0xFF1FA4")]
		public SerializerBuilder WithTagMapping(string tag, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xFF2228", Offset = "0xFF2228", VA = "0xFF2228")]
		public SerializerBuilder WithoutTagMapping(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xFF23E8", Offset = "0xFF23E8", VA = "0xFF23E8")]
		public SerializerBuilder EnsureRoundtrip()
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xFF272C", Offset = "0xFF272C", VA = "0xFF272C")]
		public SerializerBuilder DisableAliases()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xFF281C", Offset = "0xFF281C", VA = "0xFF281C")]
		public SerializerBuilder EmitDefaults()
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xFDDB2C", Offset = "0xFDDB2C", VA = "0xFDDB2C")]
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
		[Address(RVA = "0xFF28CC", Offset = "0xFF28CC", VA = "0xFF28CC")]
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
		[Address(RVA = "0xFF29BC", Offset = "0xFF29BC", VA = "0xFF29BC")]
		public SerializerBuilder WithoutEmissionPhaseObjectGraphVisitor(Type objectGraphVisitorType)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xFDDDAC", Offset = "0xFDDDAC", VA = "0xFDDDAC")]
		public Serializer Build()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xFF2AAC", Offset = "0xFF2AAC", VA = "0xFF2AAC")]
		public IValueSerializer BuildValueSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xFF2C78", Offset = "0xFF2C78", VA = "0xFF2C78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BF7C", Offset = "0x80BF7C")]
		private ITypeInspector <.ctor>b__5_1(ITypeInspector inner)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xFF2CF8", Offset = "0xFF2CF8", VA = "0xFF2CF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BF8C", Offset = "0x80BF8C")]
		private ITypeInspector <.ctor>b__5_3(ITypeInspector inner)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xFF2D88", Offset = "0xFF2D88", VA = "0xFF2D88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BF9C", Offset = "0x80BF9C")]
		private IObjectGraphTraversalStrategy <.ctor>b__5_9(ITypeInspector typeInspector, ITypeResolver typeResolver, IEnumerable<IYamlTypeConverter> typeConverters)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xFF2E28", Offset = "0xFF2E28", VA = "0xFF2E28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BFAC", Offset = "0x80BFAC")]
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
			[Address(RVA = "0x18E5F7C", Offset = "0x18E5F7C", VA = "0x18E5F7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x18E5F84", Offset = "0x18E5F84", VA = "0x18E5F84", Slot = "4")]
		private void YamlDotNet.Serialization.IYamlConvertible.Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x18E61F4", Offset = "0x18E61F4", VA = "0x18E61F4", Slot = "5")]
		private void YamlDotNet.Serialization.IYamlConvertible.Write(IEmitter emitter, ObjectSerializer nestedObjectSerializer)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x18E6388", Offset = "0x18E6388", VA = "0x18E6388")]
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
		[Address(RVA = "0x18E63F8", Offset = "0x18E63F8", VA = "0x18E63F8")]
		public TagMappings()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x18E646C", Offset = "0x18E646C", VA = "0x18E646C")]
		public TagMappings(IDictionary<string, Type> mappings)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x18E64F0", Offset = "0x18E64F0", VA = "0x18E64F0")]
		public void Add(string tag, Type mapping)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x18E65C0", Offset = "0x18E65C0", VA = "0x18E65C0")]
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
			[Address(RVA = "0x8BE820", Offset = "0x8BE820", VA = "0x8BE820")]
			public AttributeKey(Type attributeType, string propertyName)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x8BE828", Offset = "0x8BE828", VA = "0x8BE828", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x8BE830", Offset = "0x8BE830", VA = "0x8BE830", Slot = "2")]
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
			[Address(RVA = "0x18EC1A0", Offset = "0x18EC1A0", VA = "0x18EC1A0")]
			public AttributeMapping(Type registeredType, Attribute attribute)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x18EC6C0", Offset = "0x18EC6C0", VA = "0x18EC6C0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x18EC7A0", Offset = "0x18EC7A0", VA = "0x18EC7A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x18EC80C", Offset = "0x18EC80C", VA = "0x18EC80C")]
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
		[Address(RVA = "0x18EBF68", Offset = "0x18EBF68", VA = "0x18EBF68")]
		public void Add(Type type, string member, Attribute attribute)
		{
		}

		[Token(Token = "0x6000121")]
		public void Add<TClass>(Expression<Func<TClass, object>> propertyAccessor, Attribute attribute)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x18EC1E0", Offset = "0x18EC1E0", VA = "0x18EC1E0")]
		public YamlAttributeOverrides Clone()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x18EC524", Offset = "0x18EC524", VA = "0x18EC524")]
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
				[Address(RVA = "0x18ECBF8", Offset = "0x18ECBF8", VA = "0x18ECBF8", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			public bool CanWrite
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0x18ECCAC", Offset = "0x18ECCAC", VA = "0x18ECCAC", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CD")]
			public Type Type
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0x18ECD64", Offset = "0x18ECD64", VA = "0x18ECD64", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public Type TypeOverride
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0x18ECE1C", Offset = "0x18ECE1C", VA = "0x18ECE1C", Slot = "7")]
				get
				{
					return null;
				}
				[Token(Token = "0x600057B")]
				[Address(RVA = "0x18ECED4", Offset = "0x18ECED4", VA = "0x18ECED4", Slot = "8")]
				set
				{
				}
			}

			[Token(Token = "0x170000CF")]
			public int Order
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0x18ECF9C", Offset = "0x18ECF9C", VA = "0x18ECF9C", Slot = "9")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600057D")]
				[Address(RVA = "0x18ED054", Offset = "0x18ED054", VA = "0x18ED054", Slot = "10")]
				set
				{
				}
			}

			[Token(Token = "0x170000D0")]
			public ScalarStyle ScalarStyle
			{
				[Token(Token = "0x600057E")]
				[Address(RVA = "0x18ED11C", Offset = "0x18ED11C", VA = "0x18ED11C", Slot = "11")]
				get
				{
					return default(ScalarStyle);
				}
				[Token(Token = "0x600057F")]
				[Address(RVA = "0x18ED1D4", Offset = "0x18ED1D4", VA = "0x18ED1D4", Slot = "12")]
				set
				{
				}
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x18ECBB8", Offset = "0x18ECBB8", VA = "0x18ECBB8")]
			public OverridePropertyDescriptor(IPropertyDescriptor baseDescriptor, YamlAttributeOverrides overrides, Type classType)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x18ED29C", Offset = "0x18ED29C", VA = "0x18ED29C", Slot = "15")]
			public void Write(object target, object value)
			{
			}

			[Token(Token = "0x6000581")]
			public T GetCustomAttribute<T>() where T : Attribute
			{
				return null;
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x18ED36C", Offset = "0x18ED36C", VA = "0x18ED36C", Slot = "14")]
			public IObjectDescriptor Read(object target)
			{
				return null;
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B0D8", Offset = "0x80B0D8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public YamlAttributeOverridesInspector <>4__this;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type type;

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x18ECB24", Offset = "0x18ECB24", VA = "0x18ECB24")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x18ECB2C", Offset = "0x18ECB2C", VA = "0x18ECB2C")]
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
		[Address(RVA = "0x18EC950", Offset = "0x18EC950", VA = "0x18EC950")]
		public YamlAttributeOverridesInspector(ITypeInspector innerTypeDescriptor, YamlAttributeOverrides overrides)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x18EC988", Offset = "0x18EC988", VA = "0x18EC988", Slot = "6")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B0E8", Offset = "0x80B0E8")]
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
			[Address(RVA = "0x18ED79C", Offset = "0x18ED79C", VA = "0x18ED79C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x18ED7A4", Offset = "0x18ED7A4", VA = "0x18ED7A4")]
			internal bool <GetProperties>b__2_0(IPropertyDescriptor p)
			{
				return default(bool);
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x18ED87C", Offset = "0x18ED87C", VA = "0x18ED87C")]
			internal IPropertyDescriptor <GetProperties>b__2_1(IPropertyDescriptor p)
			{
				return null;
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x18EDA70", Offset = "0x18EDA70", VA = "0x18EDA70")]
			internal int <GetProperties>b__2_2(IPropertyDescriptor p)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x18ED434", Offset = "0x18ED434", VA = "0x18ED434")]
		public YamlAttributesTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x18ED460", Offset = "0x18ED460", VA = "0x18ED460", Slot = "6")]
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
		[Address(RVA = "0x18EDB24", Offset = "0x18EDB24", VA = "0x18EDB24")]
		public static string FormatNumber(object number)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x18EDBC0", Offset = "0x18EDBC0", VA = "0x18EDBC0")]
		public static string FormatNumber(double number)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x18EDC44", Offset = "0x18EDC44", VA = "0x18EDC44")]
		public static string FormatNumber(float number)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x18EDCC8", Offset = "0x18EDCC8", VA = "0x18EDCC8")]
		public static string FormatBoolean(object boolean)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x18EDD6C", Offset = "0x18EDD6C", VA = "0x18EDD6C")]
		public static string FormatDateTime(object dateTime)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x18EDE18", Offset = "0x18EDE18", VA = "0x18EDE18")]
		public static string FormatTimeSpan(object timeSpan)
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x80ACA0", Offset = "0x80ACA0")]
	public sealed class YamlIgnoreAttribute : Attribute
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x18EE198", Offset = "0x18EE198", VA = "0x18EE198")]
		public YamlIgnoreAttribute()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x80ACDC", Offset = "0x80ACDC")]
	public sealed class YamlMemberAttribute : Attribute
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B480", Offset = "0x80B480")]
		private Type <SerializeAs>k__BackingField;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B490", Offset = "0x80B490")]
		private int <Order>k__BackingField;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B4A0", Offset = "0x80B4A0")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B4B0", Offset = "0x80B4B0")]
		private bool <ApplyNamingConventions>k__BackingField;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B4C0", Offset = "0x80B4C0")]
		private ScalarStyle <ScalarStyle>k__BackingField;

		[Token(Token = "0x1700002D")]
		public Type SerializeAs
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x18EDA50", Offset = "0x18EDA50", VA = "0x18EDA50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BFBC", Offset = "0x80BFBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x18EE1A0", Offset = "0x18EE1A0", VA = "0x18EE1A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BFCC", Offset = "0x80BFCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public int Order
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x18EDA58", Offset = "0x18EDA58", VA = "0x18EDA58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BFDC", Offset = "0x80BFDC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x18EE1A8", Offset = "0x18EE1A8", VA = "0x18EE1A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BFEC", Offset = "0x80BFEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public string Alias
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x18EDA68", Offset = "0x18EDA68", VA = "0x18EDA68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80BFFC", Offset = "0x80BFFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x18EE1B0", Offset = "0x18EE1B0", VA = "0x18EE1B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C00C", Offset = "0x80C00C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool ApplyNamingConventions
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x18E6CD4", Offset = "0x18E6CD4", VA = "0x18E6CD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C01C", Offset = "0x80C01C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x18EE1B8", Offset = "0x18EE1B8", VA = "0x18EE1B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C02C", Offset = "0x80C02C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x18EDA60", Offset = "0x18EDA60", VA = "0x18EDA60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C03C", Offset = "0x80C03C")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x18EE1C4", Offset = "0x18EE1C4", VA = "0x18EE1C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C04C", Offset = "0x80C04C")]
			set
			{
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x18EE1CC", Offset = "0x18EE1CC", VA = "0x18EE1CC")]
		public YamlMemberAttribute()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x18EE1FC", Offset = "0x18EE1FC", VA = "0x18EE1FC")]
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
			[Address(RVA = "0x18EB000", Offset = "0x18EB000", VA = "0x18EB000", Slot = "34")]
			public void OnDeserialization()
			{
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x18EB21C", Offset = "0x18EB21C", VA = "0x18EB21C")]
			public AliasState()
			{
			}
		}

		[Token(Token = "0x20000FD")]
		private sealed class ValuePromise : IValuePromise
		{
			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B820", Offset = "0x80B820")]
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
				[Address(RVA = "0x18EAE68", Offset = "0x18EAE68", VA = "0x18EAE68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CC00", Offset = "0x80CC00")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600058F")]
				[Address(RVA = "0x18EB444", Offset = "0x18EB444", VA = "0x18EB444")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CC10", Offset = "0x80CC10")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			public object Value
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0x18EAE70", Offset = "0x18EAE70", VA = "0x18EAE70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x18EAF34", Offset = "0x18EAF34", VA = "0x18EAF34")]
				set
				{
				}
			}

			[Token(Token = "0x14000002")]
			public event Action<object> ValueAvailable
			{
				[Token(Token = "0x600058C")]
				[Address(RVA = "0x18EB26C", Offset = "0x18EB26C", VA = "0x18EB26C", Slot = "4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CBE0", Offset = "0x80CBE0")]
				add
				{
				}
				[Token(Token = "0x600058D")]
				[Address(RVA = "0x18EB358", Offset = "0x18EB358", VA = "0x18EB358", Slot = "5")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CBF0", Offset = "0x80CBF0")]
				remove
				{
				}
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x18EAE3C", Offset = "0x18EAE3C", VA = "0x18EAE3C")]
			public ValuePromise(YamlDotNet.Core.Events.AnchorAlias alias)
			{
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x18EAF00", Offset = "0x18EAF00", VA = "0x18EAF00")]
			public ValuePromise(object value)
			{
			}
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IValueDeserializer innerDeserializer;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x18EA9F8", Offset = "0x18EA9F8", VA = "0x18EA9F8")]
		public AliasValueDeserializer(IValueDeserializer innerDeserializer)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x18EAA9C", Offset = "0x18EAA9C", VA = "0x18EAA9C", Slot = "4")]
		public object DeserializeValue(IParser parser, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer)
		{
			return null;
		}
	}
	[Token(Token = "0x200003B")]
	public sealed class NodeValueDeserializer : IValueDeserializer
	{
		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B0F8", Offset = "0x80B0F8")]
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
			[Address(RVA = "0x18EBB54", Offset = "0x18EBB54", VA = "0x18EBB54")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x18EBE90", Offset = "0x18EBE90", VA = "0x18EBE90")]
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
		[Address(RVA = "0x18EB450", Offset = "0x18EB450", VA = "0x18EB450")]
		public NodeValueDeserializer(IList<INodeDeserializer> deserializers, IList<INodeTypeResolver> typeResolvers)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x18EB51C", Offset = "0x18EB51C", VA = "0x18EB51C", Slot = "4")]
		public object DeserializeValue(IParser parser, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x18EBB5C", Offset = "0x18EBB5C", VA = "0x18EBB5C")]
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
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80AD18", Offset = "0x80AD18")]
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
			[Address(RVA = "0x18E802C", Offset = "0x18E802C", VA = "0x18E802C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x18E7DF4", Offset = "0x18E7DF4", VA = "0x18E7DF4")]
		public void Add(string anchor, object @object)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x18E7F5C", Offset = "0x18E7F5C", VA = "0x18E7F5C")]
		public bool TryGetAnchor(object @object, out string anchor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x18E818C", Offset = "0x18E818C", VA = "0x18E818C")]
		public ObjectAnchorCollection()
		{
		}
	}
	[Token(Token = "0x200003E")]
	internal static class ReflectionUtility
	{
		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B108", Offset = "0x80B108")]
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
				[Address(RVA = "0x18E8800", Offset = "0x18E8800", VA = "0x18E8800", Slot = "6")]
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
				[Address(RVA = "0x18E8870", Offset = "0x18E8870", VA = "0x18E8870", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x18E8624", Offset = "0x18E8624", VA = "0x18E8624")]
			[DebuggerHidden]
			public <GetImplementedInterfaces>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x18E865C", Offset = "0x18E865C", VA = "0x18E865C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x18E8660", Offset = "0x18E8660", VA = "0x18E8660", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x18E8808", Offset = "0x18E8808", VA = "0x18E8808", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x18E8878", Offset = "0x18E8878", VA = "0x18E8878", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x18E8928", Offset = "0x18E8928", VA = "0x18E8928", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x18E8224", Offset = "0x18E8224", VA = "0x18E8224")]
		public static Type GetImplementedGenericInterface(Type type, Type genericInterfaceType)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x18E85A0", Offset = "0x18E85A0", VA = "0x18E85A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80C05C", Offset = "0x80C05C")]
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
		[Address(RVA = "0x18E892C", Offset = "0x18E892C", VA = "0x18E892C")]
		public void OnDeserialization()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x18E8CB4", Offset = "0x18E8CB4", VA = "0x18E8CB4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x18E9034", Offset = "0x18E9034", VA = "0x18E9034")]
		public SerializerState()
		{
		}
	}
	[Token(Token = "0x2000040")]
	internal static class StringExtensions
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B118", Offset = "0x80B118")]
		private sealed class <>c
		{
			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static MatchEvaluator <>9__0_0;

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x18E9538", Offset = "0x18E9538", VA = "0x18E9538")]
			public <>c()
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x18E9540", Offset = "0x18E9540", VA = "0x18E9540")]
			internal string <ToCamelOrPascalCase>b__0_0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B128", Offset = "0x80B128")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string separator;

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x18E94CC", Offset = "0x18E94CC", VA = "0x18E94CC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x18E95EC", Offset = "0x18E95EC", VA = "0x18E95EC")]
			internal string <FromCamelCase>b__0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x18E90A4", Offset = "0x18E90A4", VA = "0x18E90A4")]
		private static string ToCamelOrPascalCase(string str, Func<char, char> firstLetterTransform)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x18E9254", Offset = "0x18E9254", VA = "0x18E9254")]
		public static string ToCamelCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x18E92D0", Offset = "0x18E92D0", VA = "0x18E92D0")]
		public static string ToPascalCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x18E934C", Offset = "0x18E934C", VA = "0x18E934C")]
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
		[Address(RVA = "0x18E96B8", Offset = "0x18E96B8", VA = "0x18E96B8")]
		public static object ChangeType(object value, Type destinationType)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x18EA940", Offset = "0x18EA940", VA = "0x18EA940")]
		public static object ChangeType(object value, Type destinationType, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x18E9738", Offset = "0x18E9738", VA = "0x18E9738")]
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
		[Address(RVA = "0x18E7DC4", Offset = "0x18E7DC4", VA = "0x18E7DC4", Slot = "4")]
		public Type Resolve(Type staticType, object actualValue)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x18E7DDC", Offset = "0x18E7DDC", VA = "0x18E7DDC")]
		public DynamicTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public sealed class StaticTypeResolver : ITypeResolver
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x18E7DE4", Offset = "0x18E7DE4", VA = "0x18E7DE4", Slot = "4")]
		public Type Resolve(Type staticType, object actualValue)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x18E7DEC", Offset = "0x18E7DEC", VA = "0x18E7DEC")]
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
		[Address(RVA = "0x18E66A0", Offset = "0x18E66A0", VA = "0x18E66A0")]
		public CachedTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x18E6774", Offset = "0x18E6774", VA = "0x18E6774", Slot = "6")]
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
		[Address(RVA = "0x18E68C0", Offset = "0x18E68C0", VA = "0x18E68C0")]
		public NamingConventionTypeInspector(ITypeInspector innerTypeDescriptor, INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x18E698C", Offset = "0x18E698C", VA = "0x18E698C", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x18E6AAC", Offset = "0x18E6AAC", VA = "0x18E6AAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C0F0", Offset = "0x80C0F0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B138", Offset = "0x80B138")]
		private sealed class <>c
		{
			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IPropertyDescriptor, bool> <>9__2_0;

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x18E6EEC", Offset = "0x18E6EEC", VA = "0x18E6EEC")]
			public <>c()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x18E6EF4", Offset = "0x18E6EF4", VA = "0x18E6EF4")]
			internal bool <GetProperties>b__2_0(IPropertyDescriptor p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector _innerTypeDescriptor;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x18E6CDC", Offset = "0x18E6CDC", VA = "0x18E6CDC")]
		public ReadableAndWritablePropertiesTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x18E6D08", Offset = "0x18E6D08", VA = "0x18E6D08", Slot = "6")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B830", Offset = "0x80B830")]
			private Type <TypeOverride>k__BackingField;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B840", Offset = "0x80B840")]
			private int <Order>k__BackingField;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B850", Offset = "0x80B850")]
			private ScalarStyle <ScalarStyle>k__BackingField;

			[Token(Token = "0x170000D5")]
			public string Name
			{
				[Token(Token = "0x60005A7")]
				[Address(RVA = "0x18E72AC", Offset = "0x18E72AC", VA = "0x18E72AC", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			public Type Type
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x18E72E0", Offset = "0x18E72E0", VA = "0x18E72E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			public Type TypeOverride
			{
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0x18E7318", Offset = "0x18E7318", VA = "0x18E7318", Slot = "7")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CC90", Offset = "0x80CC90")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x18E7320", Offset = "0x18E7320", VA = "0x18E7320", Slot = "8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCA0", Offset = "0x80CCA0")]
				set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			public int Order
			{
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0x18E7328", Offset = "0x18E7328", VA = "0x18E7328", Slot = "9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCB0", Offset = "0x80CCB0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0x18E7330", Offset = "0x18E7330", VA = "0x18E7330", Slot = "10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCC0", Offset = "0x80CCC0")]
				set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			public bool CanWrite
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x18E7338", Offset = "0x18E7338", VA = "0x18E7338", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DA")]
			public ScalarStyle ScalarStyle
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0x18E7370", Offset = "0x18E7370", VA = "0x18E7370", Slot = "11")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCD0", Offset = "0x80CCD0")]
				get
				{
					return default(ScalarStyle);
				}
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x18E72A4", Offset = "0x18E72A4", VA = "0x18E72A4", Slot = "12")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCE0", Offset = "0x80CCE0")]
				set
				{
				}
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x18E7268", Offset = "0x18E7268", VA = "0x18E7268")]
			public ReflectionPropertyDescriptor(PropertyInfo propertyInfo, ITypeResolver typeResolver)
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x18E7378", Offset = "0x18E7378", VA = "0x18E7378", Slot = "15")]
			public void Write(object target, object value)
			{
			}

			[Token(Token = "0x60005B1")]
			public T GetCustomAttribute<T>() where T : Attribute
			{
				return null;
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x18E73CC", Offset = "0x18E73CC", VA = "0x18E73CC", Slot = "14")]
			public IObjectDescriptor Read(object target)
			{
				return null;
			}
		}

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeResolver _typeResolver;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x18E6FA8", Offset = "0x18E6FA8", VA = "0x18E6FA8")]
		public ReadablePropertiesTypeInspector(ITypeResolver typeResolver)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x18E704C", Offset = "0x18E704C", VA = "0x18E704C")]
		private static bool IsValidProperty(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x18E70D4", Offset = "0x18E70D4", VA = "0x18E70D4", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x18E71F0", Offset = "0x18E71F0", VA = "0x18E71F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C100", Offset = "0x80C100")]
		private IPropertyDescriptor <GetProperties>b__3_0(PropertyInfo p)
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	public abstract class TypeInspectorSkeleton : ITypeInspector
	{
		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B148", Offset = "0x80B148")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x18E7BD8", Offset = "0x18E7BD8", VA = "0x18E7BD8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x18E7CFC", Offset = "0x18E7CFC", VA = "0x18E7CFC")]
			internal bool <GetProperty>b__0(IPropertyDescriptor p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B158", Offset = "0x80B158")]
		private sealed class <>c
		{
			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IPropertyDescriptor, string> <>9__1_1;

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x18E7C44", Offset = "0x18E7C44", VA = "0x18E7C44")]
			public <>c()
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x18E7C4C", Offset = "0x18E7C4C", VA = "0x18E7C4C")]
			internal string <GetProperty>b__1_1(IPropertyDescriptor p)
			{
				return null;
			}
		}

		[Token(Token = "0x6000165")]
		public abstract IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container);

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x18E7544", Offset = "0x18E7544", VA = "0x18E7544", Slot = "5")]
		public IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x18E676C", Offset = "0x18E676C", VA = "0x18E676C")]
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
			[Address(RVA = "0xFED70C", Offset = "0xFED70C", VA = "0xFED70C")]
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
		[Address(RVA = "0xFED180", Offset = "0xFED180", VA = "0xFED180")]
		public AnchorAssigner(IEnumerable<IYamlTypeConverter> typeConverters)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xFED294", Offset = "0xFED294", VA = "0xFED294", Slot = "12")]
		protected override bool Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xFED504", Offset = "0xFED504", VA = "0xFED504", Slot = "14")]
		protected override bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xFED50C", Offset = "0xFED50C", VA = "0xFED50C", Slot = "13")]
		protected override bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xFED514", Offset = "0xFED514", VA = "0xFED514", Slot = "17")]
		protected override void VisitScalar(IObjectDescriptor scalar)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xFED518", Offset = "0xFED518", VA = "0xFED518", Slot = "16")]
		protected override void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xFED700", Offset = "0xFED700", VA = "0xFED700", Slot = "15")]
		protected override void VisitMappingEnd(IObjectDescriptor mapping)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xFED704", Offset = "0xFED704", VA = "0xFED704", Slot = "19")]
		protected override void VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xFED708", Offset = "0xFED708", VA = "0xFED708", Slot = "18")]
		protected override void VisitSequenceEnd(IObjectDescriptor sequence)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xFED51C", Offset = "0xFED51C", VA = "0xFED51C")]
		private void VisitObject(IObjectDescriptor value)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xFED714", Offset = "0xFED714", VA = "0xFED714", Slot = "20")]
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
		[Address(RVA = "0xFED80C", Offset = "0xFED80C", VA = "0xFED80C")]
		public AnchorAssigningObjectGraphVisitor(IObjectGraphVisitor<IEmitter> nextVisitor, IEventEmitter eventEmitter, IAliasProvider aliasProvider)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xFED8D0", Offset = "0xFED8D0", VA = "0xFED8D0", Slot = "12")]
		public override bool Enter(IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xFEDBF0", Offset = "0xFEDBF0", VA = "0xFEDBF0", Slot = "16")]
		public override void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, IEmitter context)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xFEDDF0", Offset = "0xFEDDF0", VA = "0xFEDDF0", Slot = "18")]
		public override void VisitSequenceStart(IObjectDescriptor sequence, Type elementType, IEmitter context)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xFEE01C", Offset = "0xFEE01C", VA = "0xFEE01C", Slot = "15")]
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
		[Address(RVA = "0xFED8A4", Offset = "0xFED8A4", VA = "0xFED8A4")]
		protected ChainedObjectGraphVisitor(IObjectGraphVisitor<IEmitter> nextVisitor)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xFEDB24", Offset = "0xFEDB24", VA = "0xFEDB24", Slot = "12")]
		public virtual bool Enter(IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xFEE2F0", Offset = "0xFEE2F0", VA = "0xFEE2F0", Slot = "13")]
		public virtual bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xFEE3D0", Offset = "0xFEE3D0", VA = "0xFEE3D0", Slot = "14")]
		public virtual bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xFEE4B0", Offset = "0xFEE4B0", VA = "0xFEE4B0", Slot = "15")]
		public virtual void VisitScalar(IObjectDescriptor scalar, IEmitter context)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xFEE580", Offset = "0xFEE580", VA = "0xFEE580", Slot = "16")]
		public virtual void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, IEmitter context)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xFEE668", Offset = "0xFEE668", VA = "0xFEE668", Slot = "17")]
		public virtual void VisitMappingEnd(IObjectDescriptor mapping, IEmitter context)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xFEE738", Offset = "0xFEE738", VA = "0xFEE738", Slot = "18")]
		public virtual void VisitSequenceStart(IObjectDescriptor sequence, Type elementType, IEmitter context)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xFEE818", Offset = "0xFEE818", VA = "0xFEE818", Slot = "19")]
		public virtual void VisitSequenceEnd(IObjectDescriptor sequence, IEmitter context)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public sealed class CustomSerializationObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B168", Offset = "0x80B168")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IObjectDescriptor value;

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xFEEDB0", Offset = "0xFEEDB0", VA = "0xFEEDB0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xFEEDB8", Offset = "0xFEEDB8", VA = "0xFEEDB8")]
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
		[Address(RVA = "0xFEE8E8", Offset = "0xFEE8E8", VA = "0xFEE8E8")]
		public CustomSerializationObjectGraphVisitor(IObjectGraphVisitor<IEmitter> nextVisitor, IEnumerable<IYamlTypeConverter> typeConverters, ObjectSerializer nestedObjectSerializer)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xFEE984", Offset = "0xFEE984", VA = "0xFEE984", Slot = "12")]
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
		[Address(RVA = "0xFEEEF8", Offset = "0xFEEEF8", VA = "0xFEEEF8")]
		public DefaultExclusiveObjectGraphVisitor(IObjectGraphVisitor<IEmitter> nextVisitor)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xFEEF24", Offset = "0xFEEF24", VA = "0xFEEF24")]
		private static object GetDefault(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xFEEFAC", Offset = "0xFEEFAC", VA = "0xFEEFAC", Slot = "13")]
		public override bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xFEF15C", Offset = "0xFEF15C", VA = "0xFEF15C", Slot = "14")]
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
		[Address(RVA = "0xFEF4C0", Offset = "0xFEF4C0", VA = "0xFEF4C0")]
		public EmittingObjectGraphVisitor(IEventEmitter eventEmitter)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xFEF4EC", Offset = "0xFEF4EC", VA = "0xFEF4EC", Slot = "4")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.Enter(IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xFEF4F4", Offset = "0xFEF4F4", VA = "0xFEF4F4", Slot = "5")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.EnterMapping(IObjectDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xFEF4FC", Offset = "0xFEF4FC", VA = "0xFEF4FC", Slot = "6")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.EnterMapping(IPropertyDescriptor key, IObjectDescriptor value, IEmitter context)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xFEF504", Offset = "0xFEF504", VA = "0xFEF504", Slot = "7")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitScalar(IObjectDescriptor scalar, IEmitter context)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xFEF5F0", Offset = "0xFEF5F0", VA = "0xFEF5F0", Slot = "8")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, IEmitter context)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xFEF6E0", Offset = "0xFEF6E0", VA = "0xFEF6E0", Slot = "9")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitMappingEnd(IObjectDescriptor mapping, IEmitter context)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xFEF7D0", Offset = "0xFEF7D0", VA = "0xFEF7D0", Slot = "10")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitSequenceStart(IObjectDescriptor sequence, Type elementType, IEmitter context)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xFEF8C0", Offset = "0xFEF8C0", VA = "0xFEF8C0", Slot = "11")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Core.IEmitter>.VisitSequenceEnd(IObjectDescriptor sequence, IEmitter context)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public abstract class PreProcessingPhaseObjectGraphVisitorSkeleton : IObjectGraphVisitor<Nothing>
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B178", Offset = "0x80B178")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IObjectDescriptor value;

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xFEFBF4", Offset = "0xFEFBF4", VA = "0xFEFBF4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xFEFC68", Offset = "0xFEFC68", VA = "0xFEFC68")]
			internal bool <YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.Enter>b__0(IYamlTypeConverter t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly IEnumerable<IYamlTypeConverter> typeConverters;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xFED1FC", Offset = "0xFED1FC", VA = "0xFED1FC")]
		public PreProcessingPhaseObjectGraphVisitorSkeleton(IEnumerable<IYamlTypeConverter> typeConverters)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xFEF9DC", Offset = "0xFEF9DC", VA = "0xFEF9DC", Slot = "4")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.Enter(IObjectDescriptor value, Nothing context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xFEFBFC", Offset = "0xFEFBFC", VA = "0xFEFBFC", Slot = "6")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.EnterMapping(IPropertyDescriptor key, IObjectDescriptor value, Nothing context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xFEFC08", Offset = "0xFEFC08", VA = "0xFEFC08", Slot = "5")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.EnterMapping(IObjectDescriptor key, IObjectDescriptor value, Nothing context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xFEFC18", Offset = "0xFEFC18", VA = "0xFEFC18", Slot = "9")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitMappingEnd(IObjectDescriptor mapping, Nothing context)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xFEFC28", Offset = "0xFEFC28", VA = "0xFEFC28", Slot = "8")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType, Nothing context)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xFEFC38", Offset = "0xFEFC38", VA = "0xFEFC38", Slot = "7")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitScalar(IObjectDescriptor scalar, Nothing context)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xFEFC48", Offset = "0xFEFC48", VA = "0xFEFC48", Slot = "11")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor<YamlDotNet.Serialization.Nothing>.VisitSequenceEnd(IObjectDescriptor sequence, Nothing context)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xFEFC58", Offset = "0xFEFC58", VA = "0xFEFC58", Slot = "10")]
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
		[Address(RVA = "0xFECEEC", Offset = "0xFECEEC", VA = "0xFECEEC")]
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
		[Address(RVA = "0xFED044", Offset = "0xFED044", VA = "0xFED044")]
		private IObjectDescriptor GetObjectDescriptor(object value, Type staticType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public class RoundtripObjectGraphTraversalStrategy : FullObjectGraphTraversalStrategy
	{
		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B188", Offset = "0x80B188")]
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
		[Address(RVA = "0xFED148", Offset = "0xFED148", VA = "0xFED148")]
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
		[Address(RVA = "0xFECA78", Offset = "0xFECA78", VA = "0xFECA78", Slot = "4")]
		public object Create(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xFE3768", Offset = "0xFE3768", VA = "0xFE3768")]
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
		[Address(RVA = "0xFE3F28", Offset = "0xFE3F28", VA = "0xFE3F28")]
		public LambdaObjectFactory(Func<Type, object> factory)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xFECE7C", Offset = "0xFECE7C", VA = "0xFECE7C", Slot = "4")]
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
		[Address(RVA = "0xFEBC80", Offset = "0xFEBC80", VA = "0xFEBC80", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xFE39EC", Offset = "0xFE39EC", VA = "0xFE39EC")]
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
		[Address(RVA = "0xFE3940", Offset = "0xFE3940", VA = "0xFE3940")]
		public TagNodeTypeResolver(IDictionary<string, Type> tagMappings)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xFEBDD8", Offset = "0xFEBDD8", VA = "0xFEBDD8", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000056")]
	public sealed class TypeNameInTagNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xFEBF10", Offset = "0xFEBF10", VA = "0xFEBF10", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xFE39E4", Offset = "0xFE39E4", VA = "0xFE39E4")]
		public TypeNameInTagNodeTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public sealed class YamlConvertibleTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xFEC02C", Offset = "0xFEC02C", VA = "0xFEC02C", Slot = "4")]
		public bool Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xFE3930", Offset = "0xFE3930", VA = "0xFE3930")]
		public YamlConvertibleTypeResolver()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public sealed class YamlSerializableTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xFEC0C8", Offset = "0xFEC0C8", VA = "0xFEC0C8", Slot = "4")]
		public bool Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xFE3938", Offset = "0xFE3938", VA = "0xFE3938")]
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
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80B198", Offset = "0x80B198")]
		private sealed class ArrayList : IList, ICollection, IEnumerable
		{
			[Token(Token = "0x200012C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B310", Offset = "0x80B310")]
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
					[Address(RVA = "0xFE8AA4", Offset = "0xFE8AA4", VA = "0xFE8AA4", Slot = "4")]
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
					[Address(RVA = "0xFE8B14", Offset = "0xFE8B14", VA = "0xFE8B14", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0xFE89A4", Offset = "0xFE89A4", VA = "0xFE89A4")]
				[DebuggerHidden]
				public <GetEnumerator>d__24(int <>1__state)
				{
				}

				[Token(Token = "0x6000669")]
				[Address(RVA = "0xFE89D0", Offset = "0xFE89D0", VA = "0xFE89D0", Slot = "5")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x600066A")]
				[Address(RVA = "0xFE89D4", Offset = "0xFE89D4", VA = "0xFE89D4", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x600066C")]
				[Address(RVA = "0xFE8AAC", Offset = "0xFE8AAC", VA = "0xFE8AAC", Slot = "8")]
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
				[Address(RVA = "0xFE875C", Offset = "0xFE875C", VA = "0xFE875C", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DC")]
			public bool IsReadOnly
			{
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0xFE8764", Offset = "0xFE8764", VA = "0xFE8764", Slot = "9")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DD")]
			public object Item
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0xFE883C", Offset = "0xFE883C", VA = "0xFE883C", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0xFE8890", Offset = "0xFE8890", VA = "0xFE8890", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x170000DE")]
			public int Count
			{
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0xFE8480", Offset = "0xFE8480", VA = "0xFE8480", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000DF")]
			public bool IsSynchronized
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0xFE8920", Offset = "0xFE8920", VA = "0xFE8920", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E0")]
			public object SyncRoot
			{
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0xFE8928", Offset = "0xFE8928", VA = "0xFE8928", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xFE7F3C", Offset = "0xFE7F3C", VA = "0xFE7F3C")]
			public ArrayList()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xFE850C", Offset = "0xFE850C", VA = "0xFE850C", Slot = "6")]
			public int Add(object value)
			{
				return default(int);
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xFE84B0", Offset = "0xFE84B0", VA = "0xFE84B0", Slot = "8")]
			public void Clear()
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xFE8624", Offset = "0xFE8624", VA = "0xFE8624", Slot = "7")]
			public bool Contains(object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xFE868C", Offset = "0xFE868C", VA = "0xFE868C", Slot = "11")]
			public int IndexOf(object value)
			{
				return default(int);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xFE86F4", Offset = "0xFE86F4", VA = "0xFE86F4", Slot = "12")]
			public void Insert(int index, object value)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xFE876C", Offset = "0xFE876C", VA = "0xFE876C", Slot = "13")]
			public void Remove(object value)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xFE87D4", Offset = "0xFE87D4", VA = "0xFE87D4", Slot = "14")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xFE8488", Offset = "0xFE8488", VA = "0xFE8488", Slot = "15")]
			public void CopyTo(Array array, int index)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xFE8930", Offset = "0xFE8930", VA = "0xFE8930", Slot = "19")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80CCF0", Offset = "0x80CCF0")]
			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xFE7DCC", Offset = "0xFE7DCC", VA = "0xFE7DCC", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xFE3884", Offset = "0xFE3884", VA = "0xFE3884")]
		public ArrayNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public sealed class CollectionNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B1D0", Offset = "0x80B1D0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IList result;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type tItem;

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xFE8F00", Offset = "0xFE8F00", VA = "0xFE8F00")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B1E0", Offset = "0x80B1E0")]
		private sealed class <>c__DisplayClass3_1
		{
			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass3_0 CS$<>8__locals1;

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xFE8F08", Offset = "0xFE8F08", VA = "0xFE8F08")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xFE8F10", Offset = "0xFE8F10", VA = "0xFE8F10")]
			internal void <DeserializeHelper>b__0(object v)
			{
			}
		}

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xFE38B8", Offset = "0xFE38B8", VA = "0xFE38B8")]
		public CollectionNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xFE8B1C", Offset = "0xFE8B1C", VA = "0xFE8B1C", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xFE7F64", Offset = "0xFE7F64", VA = "0xFE7F64")]
		internal static void DeserializeHelper(Type tItem, IParser parser, Func<IParser, Type, object> nestedObjectDeserializer, IList result, bool canUpdate)
		{
		}
	}
	[Token(Token = "0x200005B")]
	public sealed class DictionaryNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B1F0", Offset = "0x80B1F0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IDictionary result;

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xFE98A4", Offset = "0xFE98A4", VA = "0xFE98A4")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B200", Offset = "0x80B200")]
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
			[Address(RVA = "0xFE98AC", Offset = "0xFE98AC", VA = "0xFE98AC")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xFE98BC", Offset = "0xFE98BC", VA = "0xFE98BC")]
			internal void <DeserializeHelper>b__0(object v)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xFE999C", Offset = "0xFE999C", VA = "0xFE999C")]
			internal void <DeserializeHelper>b__1(object v)
			{
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B210", Offset = "0x80B210")]
		private sealed class <>c__DisplayClass3_2
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool hasFirstPart;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass3_1 CS$<>8__locals2;

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xFE98B4", Offset = "0xFE98B4", VA = "0xFE98B4")]
			public <>c__DisplayClass3_2()
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xFE9A7C", Offset = "0xFE9A7C", VA = "0xFE9A7C")]
			internal void <DeserializeHelper>b__2(object v)
			{
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xFE9BA4", Offset = "0xFE9BA4", VA = "0xFE9BA4")]
			internal void <DeserializeHelper>b__3(object v)
			{
			}
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xFE388C", Offset = "0xFE388C", VA = "0xFE388C")]
		public DictionaryNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xFE9018", Offset = "0xFE9018", VA = "0xFE9018", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xFE93D0", Offset = "0xFE93D0", VA = "0xFE93D0")]
		private static void DeserializeHelper(Type tKey, Type tValue, IParser parser, Func<IParser, Type, object> nestedObjectDeserializer, IDictionary result)
		{
		}
	}
	[Token(Token = "0x200005C")]
	public sealed class EnumerableNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xFE9CCC", Offset = "0xFE9CCC", VA = "0xFE9CCC", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xFE38E4", Offset = "0xFE38E4", VA = "0xFE38E4")]
		public EnumerableNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public sealed class NullNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xFE9F4C", Offset = "0xFE9F4C", VA = "0xFE9F4C", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xFE9FD8", Offset = "0xFE9FD8", VA = "0xFE9FD8")]
		private bool NodeIsNull(NodeEvent nodeEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xFE3874", Offset = "0xFE3874", VA = "0xFE3874")]
		public NullNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public sealed class ObjectNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B220", Offset = "0x80B220")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IPropertyDescriptor property;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xFEA6A0", Offset = "0xFEA6A0", VA = "0xFEA6A0")]
			public <>c__DisplayClass4_0()
			{
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B230", Offset = "0x80B230")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object valueRef;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xFEA6A8", Offset = "0xFEA6A8", VA = "0xFEA6A8")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xFEA6B0", Offset = "0xFEA6B0", VA = "0xFEA6B0")]
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
		[Address(RVA = "0xFE38EC", Offset = "0xFE38EC", VA = "0xFE38EC")]
		public ObjectNodeDeserializer(IObjectFactory objectFactory, ITypeInspector typeDescriptor, bool ignoreUnmatched)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xFEA140", Offset = "0xFEA140", VA = "0xFEA140", Slot = "4")]
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
		[Address(RVA = "0xFEA828", Offset = "0xFEA828", VA = "0xFEA828", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xFEAC48", Offset = "0xFEAC48", VA = "0xFEAC48")]
		private object DeserializeBooleanHelper(string value)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xFEAD84", Offset = "0xFEAD84", VA = "0xFEAD84")]
		private object DeserializeIntegerHelper(TypeCode typeCode, string value)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xFEB228", Offset = "0xFEB228", VA = "0xFEB228")]
		private static object CastInteger(long number, TypeCode typeCode)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xFEB36C", Offset = "0xFEB36C", VA = "0xFEB36C")]
		private static object CastInteger(ulong number, TypeCode typeCode)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xFE387C", Offset = "0xFE387C", VA = "0xFE387C")]
		public ScalarNodeDeserializer()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public sealed class TypeConverterNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B240", Offset = "0x80B240")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type expectedType;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xFEB618", Offset = "0xFEB618", VA = "0xFEB618")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xFEB620", Offset = "0xFEB620", VA = "0xFEB620")]
			internal bool <YamlDotNet.Serialization.INodeDeserializer.Deserialize>b__0(IYamlTypeConverter c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEnumerable<IYamlTypeConverter> converters;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xFE37D0", Offset = "0xFE37D0", VA = "0xFE37D0")]
		public TypeConverterNodeDeserializer(IEnumerable<IYamlTypeConverter> converters)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xFEB4AC", Offset = "0xFEB4AC", VA = "0xFEB4AC", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000061")]
	public sealed class YamlConvertibleNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B250", Offset = "0x80B250")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<IParser, Type, object> nestedObjectDeserializer;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IParser parser;

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xFEB9AC", Offset = "0xFEB9AC", VA = "0xFEB9AC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xFEB9C4", Offset = "0xFEB9C4", VA = "0xFEB9C4")]
			internal object <Deserialize>b__0(Type type)
			{
				return null;
			}
		}

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory objectFactory;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xFE3778", Offset = "0xFE3778", VA = "0xFE3778")]
		public YamlConvertibleNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xFEB6E4", Offset = "0xFEB6E4", VA = "0xFEB6E4", Slot = "4")]
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
		[Address(RVA = "0xFE37A4", Offset = "0xFE37A4", VA = "0xFE37A4")]
		public YamlSerializableNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xFEBA3C", Offset = "0xFEBA3C", VA = "0xFEBA3C", Slot = "4")]
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
		[Address(RVA = "0xFE7CEC", Offset = "0xFE7CEC", VA = "0xFE7CEC", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xFDEF68", Offset = "0xFDEF68", VA = "0xFDEF68")]
		public CamelCaseNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public sealed class HyphenatedNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xFE7CF8", Offset = "0xFE7CF8", VA = "0xFE7CF8", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xFE7D4C", Offset = "0xFE7D4C", VA = "0xFE7D4C")]
		public HyphenatedNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public sealed class NullNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xFE7D54", Offset = "0xFE7D54", VA = "0xFE7D54", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xFE3770", Offset = "0xFE3770", VA = "0xFE3770")]
		public NullNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public sealed class PascalCaseNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xFE7D5C", Offset = "0xFE7D5C", VA = "0xFE7D5C", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xFE7D68", Offset = "0xFE7D68", VA = "0xFE7D68")]
		public PascalCaseNamingConvention()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public sealed class UnderscoredNamingConvention : INamingConvention
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xFE7D70", Offset = "0xFE7D70", VA = "0xFE7D70", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xFE7DC4", Offset = "0xFE7DC4", VA = "0xFE7DC4")]
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
		[Address(RVA = "0xFE5698", Offset = "0xFE5698", VA = "0xFE5698")]
		protected ChainedEventEmitter(IEventEmitter nextEmitter)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xFE573C", Offset = "0xFE573C", VA = "0xFE573C", Slot = "10")]
		public virtual void Emit(AliasEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xFE5808", Offset = "0xFE5808", VA = "0xFE5808", Slot = "11")]
		public virtual void Emit(ScalarEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xFE58D8", Offset = "0xFE58D8", VA = "0xFE58D8", Slot = "12")]
		public virtual void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xFE59A8", Offset = "0xFE59A8", VA = "0xFE59A8", Slot = "13")]
		public virtual void Emit(MappingEndEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xFE5A78", Offset = "0xFE5A78", VA = "0xFE5A78", Slot = "14")]
		public virtual void Emit(SequenceStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xFE5B48", Offset = "0xFE5B48", VA = "0xFE5B48", Slot = "15")]
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
		[Address(RVA = "0xFE5C18", Offset = "0xFE5C18", VA = "0xFE5C18")]
		public CustomTagEventEmitter(IEventEmitter inner, IDictionary<Type, string> tagMappings)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xFE5C40", Offset = "0xFE5C40", VA = "0xFE5C40", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}
	}
	[Token(Token = "0x200006A")]
	public sealed class JsonEventEmitter : ChainedEventEmitter
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xFE5ED8", Offset = "0xFE5ED8", VA = "0xFE5ED8")]
		public JsonEventEmitter(IEventEmitter nextEmitter)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xFE5EDC", Offset = "0xFE5EDC", VA = "0xFE5EDC", Slot = "10")]
		public override void Emit(AliasEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xFE5F50", Offset = "0xFE5F50", VA = "0xFE5F50", Slot = "11")]
		public override void Emit(ScalarEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xFE66B4", Offset = "0xFE66B4", VA = "0xFE66B4", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xFE6708", Offset = "0xFE6708", VA = "0xFE6708", Slot = "14")]
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
		[Address(RVA = "0xFE675C", Offset = "0xFE675C", VA = "0xFE675C")]
		public TypeAssigningEventEmitter(IEventEmitter nextEmitter, bool assignTypeWhenDifferent)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xFE6788", Offset = "0xFE6788", VA = "0xFE6788", Slot = "11")]
		public override void Emit(ScalarEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xFE7200", Offset = "0xFE7200", VA = "0xFE7200", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xFE7528", Offset = "0xFE7528", VA = "0xFE7528", Slot = "14")]
		public override void Emit(SequenceStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xFE723C", Offset = "0xFE723C", VA = "0xFE723C")]
		private void AssignTypeIfDifferent(ObjectEventInfo eventInfo)
		{
		}
	}
	[Token(Token = "0x200006C")]
	public sealed class WriterEventEmitter : IEventEmitter
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xFE7564", Offset = "0xFE7564", VA = "0xFE7564", Slot = "4")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(AliasEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xFE7654", Offset = "0xFE7654", VA = "0xFE7654", Slot = "5")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(ScalarEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xFE77FC", Offset = "0xFE77FC", VA = "0xFE77FC", Slot = "6")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xFE7954", Offset = "0xFE7954", VA = "0xFE7954", Slot = "7")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(MappingEndEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xFE7A24", Offset = "0xFE7A24", VA = "0xFE7A24", Slot = "8")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(SequenceStartEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xFE7B7C", Offset = "0xFE7B7C", VA = "0xFE7B7C", Slot = "9")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(SequenceEndEventInfo eventInfo, IEmitter emitter)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xFE7C4C", Offset = "0xFE7C4C", VA = "0xFE7C4C")]
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
		[Address(RVA = "0xFE168C", Offset = "0xFE168C", VA = "0xFE168C")]
		public DateTimeConverter(DateTimeKind kind = DateTimeKind.Utc, [Optional] IFormatProvider provider, params string[] formats)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xFE1774", Offset = "0xFE1774", VA = "0xFE1774", Slot = "4")]
		public bool Accepts(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xFE17F8", Offset = "0xFE17F8", VA = "0xFE17F8", Slot = "5")]
		public object ReadYaml(IParser parser, Type type)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xFE1B38", Offset = "0xFE1B38", VA = "0xFE1B38", Slot = "6")]
		public void WriteYaml(IEmitter emitter, object value, Type type)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xFE1ABC", Offset = "0xFE1ABC", VA = "0xFE1ABC")]
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
		[Address(RVA = "0xFE1CB4", Offset = "0xFE1CB4", VA = "0xFE1CB4")]
		public GuidConverter(bool jsonCompatible)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xFE1CE4", Offset = "0xFE1CE4", VA = "0xFE1CE4", Slot = "4")]
		public bool Accepts(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xFE1D68", Offset = "0xFE1D68", VA = "0xFE1D68", Slot = "5")]
		public object ReadYaml(IParser parser, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xFE1FDC", Offset = "0xFE1FDC", VA = "0xFE1FDC", Slot = "6")]
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
		[Address(RVA = "0x125E06C", Offset = "0x125E06C", VA = "0x125E06C")]
		public void AddAnchor(YamlNode node)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x125E298", Offset = "0x125E298", VA = "0x125E298")]
		public YamlNode GetNode(string anchor, bool throwException, Mark start, Mark end)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x125E424", Offset = "0x125E424", VA = "0x125E424")]
		public void AddNodeWithUnresolvedAliases(YamlNode node)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x125E4EC", Offset = "0x125E4EC", VA = "0x125E4EC")]
		public void ResolveAliases()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x125E798", Offset = "0x125E798", VA = "0x125E798")]
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
			[Address(RVA = "0x125E830", Offset = "0x125E830", VA = "0x125E830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x125E838", Offset = "0x125E838", VA = "0x125E838")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B260", Offset = "0x80B260")]
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
				[Address(RVA = "0x125EC90", Offset = "0x125EC90", VA = "0x125EC90", Slot = "6")]
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
				[Address(RVA = "0x125ED00", Offset = "0x125ED00", VA = "0x125ED00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x125EC0C", Offset = "0x125EC0C", VA = "0x125EC0C")]
			[DebuggerHidden]
			public <SafeAllNodes>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x125EC4C", Offset = "0x125EC4C", VA = "0x125EC4C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x125EC50", Offset = "0x125EC50", VA = "0x125EC50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x125EC98", Offset = "0x125EC98", VA = "0x125EC98", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x125ED08", Offset = "0x125ED08", VA = "0x125ED08", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x125EDB8", Offset = "0x125EDB8", VA = "0x125EDB8", Slot = "5")]
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
			[Address(RVA = "0x125EC44", Offset = "0x125EC44", VA = "0x125EC44", Slot = "9")]
			get
			{
				return default(YamlNodeType);
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x125E8A8", Offset = "0x125E8A8", VA = "0x125E8A8")]
		internal YamlAliasNode(string anchor)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x125E8DC", Offset = "0x125E8DC", VA = "0x125E8DC", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x125E950", Offset = "0x125E950", VA = "0x125E950", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x125E9C4", Offset = "0x125E9C4", VA = "0x125E9C4", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x125EA38", Offset = "0x125EA38", VA = "0x125EA38", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x125EB1C", Offset = "0x125EB1C", VA = "0x125EB1C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x125EB24", Offset = "0x125EB24", VA = "0x125EB24", Slot = "7")]
		internal override string ToString(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x125EB88", Offset = "0x125EB88", VA = "0x125EB88", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80C110", Offset = "0x80C110")]
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
			[Address(RVA = "0x125F0D0", Offset = "0x125F0D0", VA = "0x125F0D0")]
			public void AssignAnchors(YamlDocument document)
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x125F720", Offset = "0x125F720", VA = "0x125F720")]
			private bool VisitNodeAndFindDuplicates(YamlNode node)
			{
				return default(bool);
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x125F814", Offset = "0x125F814", VA = "0x125F814", Slot = "11")]
			public override void Visit(YamlScalarNode scalar)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x125F818", Offset = "0x125F818", VA = "0x125F818", Slot = "13")]
			public override void Visit(YamlMappingNode mapping)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x125F858", Offset = "0x125F858", VA = "0x125F858", Slot = "12")]
			public override void Visit(YamlSequenceNode sequence)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x125F038", Offset = "0x125F038", VA = "0x125F038")]
			public AnchorAssigningVisitor()
			{
			}
		}

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B4D0", Offset = "0x80B4D0")]
		private YamlNode <RootNode>k__BackingField;

		[Token(Token = "0x17000035")]
		public YamlNode RootNode
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x125EDBC", Offset = "0x125EDBC", VA = "0x125EDBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C174", Offset = "0x80C174")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x125EDC4", Offset = "0x125EDC4", VA = "0x125EDC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C184", Offset = "0x80C184")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x125F6F0", Offset = "0x125F6F0", VA = "0x125F6F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x125EDCC", Offset = "0x125EDCC", VA = "0x125EDCC")]
		public YamlDocument(YamlNode rootNode)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x125EDF8", Offset = "0x125EDF8", VA = "0x125EDF8")]
		public YamlDocument(string rootNode)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x125EE74", Offset = "0x125EE74", VA = "0x125EE74")]
		internal YamlDocument(IParser parser)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x125EFCC", Offset = "0x125EFCC", VA = "0x125EFCC")]
		private void AssignAnchors()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x125F47C", Offset = "0x125F47C", VA = "0x125F47C")]
		internal void Save(IEmitter emitter, bool assignAnchors = true)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x125F62C", Offset = "0x125F62C", VA = "0x125F62C")]
		public void Accept(IYamlVisitor visitor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public sealed class YamlMappingNode : YamlNode, IEnumerable<KeyValuePair<YamlNode, YamlNode>>, IEnumerable, IYamlConvertible
	{
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B270", Offset = "0x80B270")]
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
				[Address(RVA = "0xFD6364", Offset = "0xFD6364", VA = "0xFD6364", Slot = "6")]
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
				[Address(RVA = "0xFD63D4", Offset = "0xFD63D4", VA = "0xFD63D4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xFD5994", Offset = "0xFD5994", VA = "0xFD5994")]
			[DebuggerHidden]
			public <SafeAllNodes>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xFD59CC", Offset = "0xFD59CC", VA = "0xFD59CC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xFD5CB4", Offset = "0xFD5CB4", VA = "0xFD5CB4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xFD5BF4", Offset = "0xFD5BF4", VA = "0xFD5BF4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xFD5A74", Offset = "0xFD5A74", VA = "0xFD5A74")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xFD5B34", Offset = "0xFD5B34", VA = "0xFD5B34")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xFD636C", Offset = "0xFD636C", VA = "0xFD636C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xFD63DC", Offset = "0xFD63DC", VA = "0xFD63DC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xFD649C", Offset = "0xFD649C", VA = "0xFD649C", Slot = "5")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B4E0", Offset = "0x80B4E0")]
		private MappingStyle <Style>k__BackingField;

		[Token(Token = "0x17000037")]
		public IDictionary<YamlNode, YamlNode> Children
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x125F898", Offset = "0x125F898", VA = "0x125F898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public MappingStyle Style
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x125F8A0", Offset = "0x125F8A0", VA = "0x125F8A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C194", Offset = "0x80C194")]
			get
			{
				return default(MappingStyle);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x125F8A8", Offset = "0x125F8A8", VA = "0x125F8A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C1A4", Offset = "0x80C1A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public override YamlNodeType NodeType
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x1262190", Offset = "0x1262190", VA = "0x1262190", Slot = "9")]
			get
			{
				return default(YamlNodeType);
			}
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x125F8B0", Offset = "0x125F8B0", VA = "0x125F8B0")]
		internal YamlMappingNode(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x125F940", Offset = "0x125F940", VA = "0x125F940")]
		private void Load(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x125FC74", Offset = "0x125FC74", VA = "0x125FC74")]
		public YamlMappingNode()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x125FCE4", Offset = "0x125FCE4", VA = "0x125FCE4")]
		public YamlMappingNode(int dummy)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x125FD54", Offset = "0x125FD54", VA = "0x125FD54")]
		public YamlMappingNode(params KeyValuePair<YamlNode, YamlNode>[] children)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x125FD58", Offset = "0x125FD58", VA = "0x125FD58")]
		public YamlMappingNode(IEnumerable<KeyValuePair<YamlNode, YamlNode>> children)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x12600AC", Offset = "0x12600AC", VA = "0x12600AC")]
		public YamlMappingNode(params YamlNode[] children)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x12600B0", Offset = "0x12600B0", VA = "0x12600B0")]
		public YamlMappingNode(IEnumerable<YamlNode> children)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x12604B4", Offset = "0x12604B4", VA = "0x12604B4")]
		public void Add(YamlNode key, YamlNode value)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1260584", Offset = "0x1260584", VA = "0x1260584")]
		public void Add(string key, YamlNode value)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1260674", Offset = "0x1260674", VA = "0x1260674")]
		public void Add(YamlNode key, string value)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1260764", Offset = "0x1260764", VA = "0x1260764")]
		public void Add(string key, string value)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1260874", Offset = "0x1260874", VA = "0x1260874", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x12613A4", Offset = "0x12613A4", VA = "0x12613A4", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1261810", Offset = "0x1261810", VA = "0x1261810", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x12618D4", Offset = "0x12618D4", VA = "0x12618D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1261DD0", Offset = "0x1261DD0", VA = "0x1261DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x12620F8", Offset = "0x12620F8", VA = "0x12620F8", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80C1B4", Offset = "0x80C1B4")]
		internal override IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1262198", Offset = "0x1262198", VA = "0x1262198", Slot = "7")]
		internal override string ToString(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1262668", Offset = "0x1262668", VA = "0x1262668", Slot = "10")]
		public IEnumerator<KeyValuePair<YamlNode, YamlNode>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x126271C", Offset = "0x126271C", VA = "0x126271C", Slot = "11")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1262720", Offset = "0x1262720", VA = "0x1262720", Slot = "12")]
		private void YamlDotNet.Serialization.IYamlConvertible.Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1262790", Offset = "0x1262790", VA = "0x1262790", Slot = "13")]
		private void YamlDotNet.Serialization.IYamlConvertible.Write(IEmitter emitter, ObjectSerializer nestedObjectSerializer)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1262808", Offset = "0x1262808", VA = "0x1262808")]
		public static YamlMappingNode FromObject(object mapping)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80AD60", Offset = "0x80AD60")]
	public abstract class YamlNode
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B280", Offset = "0x80B280")]
		private sealed class <>c
		{
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, YamlNode> <>9__37_0;

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xFD75B4", Offset = "0xFD75B4", VA = "0xFD75B4")]
			public <>c()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xFD75BC", Offset = "0xFD75BC", VA = "0xFD75BC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B4F0", Offset = "0x80B4F0")]
		private string <Anchor>k__BackingField;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B500", Offset = "0x80B500")]
		private string <Tag>k__BackingField;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B510", Offset = "0x80B510")]
		private Mark <Start>k__BackingField;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B520", Offset = "0x80B520")]
		private Mark <End>k__BackingField;

		[Token(Token = "0x1700003A")]
		public string Anchor
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xFD64A0", Offset = "0xFD64A0", VA = "0xFD64A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C218", Offset = "0x80C218")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xFD64A8", Offset = "0xFD64A8", VA = "0xFD64A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C228", Offset = "0x80C228")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public string Tag
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xFD64B0", Offset = "0xFD64B0", VA = "0xFD64B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C238", Offset = "0x80C238")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xFD64B8", Offset = "0xFD64B8", VA = "0xFD64B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C248", Offset = "0x80C248")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Mark Start
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xFD64C0", Offset = "0xFD64C0", VA = "0xFD64C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C258", Offset = "0x80C258")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0xFD64C8", Offset = "0xFD64C8", VA = "0xFD64C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C268", Offset = "0x80C268")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public Mark End
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0xFD64D0", Offset = "0xFD64D0", VA = "0xFD64D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C278", Offset = "0x80C278")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xFD64D8", Offset = "0xFD64D8", VA = "0xFD64D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C288", Offset = "0x80C288")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xFD6BB8", Offset = "0xFD6BB8", VA = "0xFD6BB8")]
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
			[Address(RVA = "0xFD7228", Offset = "0xFD7228", VA = "0xFD7228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public YamlNode Item
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xFD73B0", Offset = "0xFD73B0", VA = "0xFD73B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xFD64E0", Offset = "0xFD64E0", VA = "0xFD64E0")]
		internal void Load(NodeEvent yamlEvent, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xFD65C4", Offset = "0xFD65C4", VA = "0xFD65C4")]
		internal static YamlNode ParseNode(IParser parser, DocumentLoadingState state)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		internal abstract void ResolveAliases(DocumentLoadingState state);

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xFD6910", Offset = "0xFD6910", VA = "0xFD6910")]
		internal void Save(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000249")]
		internal abstract void Emit(IEmitter emitter, EmitterState state);

		[Token(Token = "0x600024A")]
		public abstract void Accept(IYamlVisitor visitor);

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xFD6A7C", Offset = "0xFD6A7C", VA = "0xFD6A7C")]
		protected bool Equals(YamlNode other)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xFD6AE0", Offset = "0xFD6AE0", VA = "0xFD6AE0")]
		protected static bool SafeEquals(object first, object second)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xFD6B10", Offset = "0xFD6B10", VA = "0xFD6B10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xFD6B28", Offset = "0xFD6B28", VA = "0xFD6B28")]
		protected static int GetHashCode(object value)
		{
			return default(int);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xFD6B3C", Offset = "0xFD6B3C", VA = "0xFD6B3C")]
		protected static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xFD6B48", Offset = "0xFD6B48", VA = "0xFD6B48", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		internal abstract string ToString(RecursionLevel level);

		[Token(Token = "0x6000253")]
		internal abstract IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level);

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xFD6C28", Offset = "0xFD6C28", VA = "0xFD6C28")]
		public static implicit operator YamlNode(string value)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xFD6CB8", Offset = "0xFD6CB8", VA = "0xFD6CB8")]
		public static implicit operator YamlNode(string[] sequence)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xFD711C", Offset = "0xFD711C", VA = "0xFD711C")]
		public static explicit operator string(YamlNode scalar)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xFD7548", Offset = "0xFD7548", VA = "0xFD7548")]
		protected YamlNode()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public sealed class YamlNodeIdentityEqualityComparer : IEqualityComparer<YamlNode>
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xFD75C4", Offset = "0xFD75C4", VA = "0xFD75C4", Slot = "4")]
		public bool Equals(YamlNode x, YamlNode y)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xFD75D0", Offset = "0xFD75D0", VA = "0xFD75D0", Slot = "5")]
		public int GetHashCode(YamlNode obj)
		{
			return default(int);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xFD7604", Offset = "0xFD7604", VA = "0xFD7604")]
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
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x80AD98", Offset = "0x80AD98")]
	public sealed class YamlScalarNode : YamlNode, IYamlConvertible
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B290", Offset = "0x80B290")]
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
				[Address(RVA = "0xFD7C7C", Offset = "0xFD7C7C", VA = "0xFD7C7C", Slot = "6")]
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
				[Address(RVA = "0xFD7CEC", Offset = "0xFD7CEC", VA = "0xFD7CEC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xFD7B08", Offset = "0xFD7B08", VA = "0xFD7B08")]
			[DebuggerHidden]
			public <SafeAllNodes>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xFD7C38", Offset = "0xFD7C38", VA = "0xFD7C38", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xFD7C3C", Offset = "0xFD7C3C", VA = "0xFD7C3C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xFD7C84", Offset = "0xFD7C84", VA = "0xFD7C84", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0xFD7CF4", Offset = "0xFD7CF4", VA = "0xFD7CF4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xFD7DA4", Offset = "0xFD7DA4", VA = "0xFD7DA4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B530", Offset = "0x80B530")]
		private string <Value>k__BackingField;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B540", Offset = "0x80B540")]
		private ScalarStyle <Style>k__BackingField;

		[Token(Token = "0x17000042")]
		public string Value
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xFD7220", Offset = "0xFD7220", VA = "0xFD7220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C298", Offset = "0x80C298")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xFD760C", Offset = "0xFD760C", VA = "0xFD760C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C2A8", Offset = "0x80C2A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0xFD7614", Offset = "0xFD7614", VA = "0xFD7614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C2B8", Offset = "0x80C2B8")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xFD761C", Offset = "0xFD761C", VA = "0xFD761C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C2C8", Offset = "0x80C2C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public override YamlNodeType NodeType
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xFD7B40", Offset = "0xFD7B40", VA = "0xFD7B40", Slot = "9")]
			get
			{
				return default(YamlNodeType);
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xFD6840", Offset = "0xFD6840", VA = "0xFD6840")]
		internal YamlScalarNode(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xFD7624", Offset = "0xFD7624", VA = "0xFD7624")]
		private void Load(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xFD76E4", Offset = "0xFD76E4", VA = "0xFD76E4")]
		public YamlScalarNode()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xFD6C8C", Offset = "0xFD6C8C", VA = "0xFD6C8C")]
		public YamlScalarNode(string value)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xFD76EC", Offset = "0xFD76EC", VA = "0xFD76EC", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xFD7760", Offset = "0xFD7760", VA = "0xFD7760", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xFD786C", Offset = "0xFD786C", VA = "0xFD786C", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xFD7930", Offset = "0xFD7930", VA = "0xFD7930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xFD7A00", Offset = "0xFD7A00", VA = "0xFD7A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xFD7A54", Offset = "0xFD7A54", VA = "0xFD7A54")]
		public static explicit operator string(YamlScalarNode value)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xFD7A7C", Offset = "0xFD7A7C", VA = "0xFD7A7C", Slot = "7")]
		internal override string ToString(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xFD7A84", Offset = "0xFD7A84", VA = "0xFD7A84", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80C2D8", Offset = "0x80C2D8")]
		internal override IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xFD7B48", Offset = "0xFD7B48", VA = "0xFD7B48", Slot = "10")]
		private void YamlDotNet.Serialization.IYamlConvertible.Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xFD7BBC", Offset = "0xFD7BBC", VA = "0xFD7BBC", Slot = "11")]
		private void YamlDotNet.Serialization.IYamlConvertible.Write(IEmitter emitter, ObjectSerializer nestedObjectSerializer)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x80ADD0", Offset = "0x80ADD0")]
	public sealed class YamlSequenceNode : YamlNode, IEnumerable<YamlNode>, IEnumerable, IYamlConvertible
	{
		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B2A0", Offset = "0x80B2A0")]
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
				[Address(RVA = "0xFD9D24", Offset = "0xFD9D24", VA = "0xFD9D24", Slot = "6")]
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
				[Address(RVA = "0xFD9D94", Offset = "0xFD9D94", VA = "0xFD9D94", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xFD90D8", Offset = "0xFD90D8", VA = "0xFD90D8")]
			[DebuggerHidden]
			public <SafeAllNodes>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xFD9694", Offset = "0xFD9694", VA = "0xFD9694", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0xFD988C", Offset = "0xFD988C", VA = "0xFD988C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0xFD97CC", Offset = "0xFD97CC", VA = "0xFD97CC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0xFD970C", Offset = "0xFD970C", VA = "0xFD970C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0xFD9D2C", Offset = "0xFD9D2C", VA = "0xFD9D2C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0xFD9D9C", Offset = "0xFD9D9C", VA = "0xFD9D9C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xFD9E5C", Offset = "0xFD9E5C", VA = "0xFD9E5C", Slot = "5")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B550", Offset = "0x80B550")]
		private SequenceStyle <Style>k__BackingField;

		[Token(Token = "0x17000045")]
		public IList<YamlNode> Children
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xFD73A8", Offset = "0xFD73A8", VA = "0xFD73A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public SequenceStyle Style
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xFD7DA8", Offset = "0xFD7DA8", VA = "0xFD7DA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C33C", Offset = "0x80C33C")]
			get
			{
				return default(SequenceStyle);
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xFD7DB0", Offset = "0xFD7DB0", VA = "0xFD7DB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C34C", Offset = "0x80C34C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override YamlNodeType NodeType
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xFD9110", Offset = "0xFD9110", VA = "0xFD9110", Slot = "9")]
			get
			{
				return default(YamlNodeType);
			}
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xFD6880", Offset = "0xFD6880", VA = "0xFD6880")]
		internal YamlSequenceNode(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xFD7DB8", Offset = "0xFD7DB8", VA = "0xFD7DB8")]
		private void Load(IParser parser, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xFD7F9C", Offset = "0xFD7F9C", VA = "0xFD7F9C")]
		public YamlSequenceNode()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xFD800C", Offset = "0xFD800C", VA = "0xFD800C")]
		public YamlSequenceNode(params YamlNode[] children)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xFD6DD0", Offset = "0xFD6DD0", VA = "0xFD6DD0")]
		public YamlSequenceNode(IEnumerable<YamlNode> children)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xFD8010", Offset = "0xFD8010", VA = "0xFD8010")]
		public void Add(YamlNode child)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xFD80D8", Offset = "0xFD80D8", VA = "0xFD80D8")]
		public void Add(string child)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xFD81C0", Offset = "0xFD81C0", VA = "0xFD81C0", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xFD8594", Offset = "0xFD8594", VA = "0xFD8594", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xFD8970", Offset = "0xFD8970", VA = "0xFD8970", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xFD8A34", Offset = "0xFD8A34", VA = "0xFD8A34", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xFD8D84", Offset = "0xFD8D84", VA = "0xFD8D84", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xFD9030", Offset = "0xFD9030", VA = "0xFD9030", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80C35C", Offset = "0x80C35C")]
		internal override IEnumerable<YamlNode> SafeAllNodes(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xFD9118", Offset = "0xFD9118", VA = "0xFD9118", Slot = "7")]
		internal override string ToString(RecursionLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xFD94EC", Offset = "0xFD94EC", VA = "0xFD94EC", Slot = "10")]
		public IEnumerator<YamlNode> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xFD95A0", Offset = "0xFD95A0", VA = "0xFD95A0", Slot = "11")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xFD95A4", Offset = "0xFD95A4", VA = "0xFD95A4", Slot = "12")]
		private void YamlDotNet.Serialization.IYamlConvertible.Read(IParser parser, Type expectedType, ObjectDeserializer nestedObjectDeserializer)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xFD9618", Offset = "0xFD9618", VA = "0xFD9618", Slot = "13")]
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
			[Address(RVA = "0xFD9E60", Offset = "0xFD9E60", VA = "0xFD9E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xFD9E68", Offset = "0xFD9E68", VA = "0xFD9E68")]
		public YamlStream()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xFD9ED8", Offset = "0xFD9ED8", VA = "0xFD9ED8")]
		public YamlStream(params YamlDocument[] documents)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xFD9EDC", Offset = "0xFD9EDC", VA = "0xFD9EDC")]
		public YamlStream(IEnumerable<YamlDocument> documents)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xFDA228", Offset = "0xFDA228", VA = "0xFDA228")]
		public void Add(YamlDocument document)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xFDA2F0", Offset = "0xFDA2F0", VA = "0xFDA2F0")]
		public void Load(TextReader input)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xFDA364", Offset = "0xFDA364", VA = "0xFDA364")]
		public void Load(IParser parser)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xFDA520", Offset = "0xFDA520", VA = "0xFDA520")]
		public void Save(TextWriter output)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xFDA528", Offset = "0xFDA528", VA = "0xFDA528")]
		public void Save(TextWriter output, bool assignAnchors)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xFDA914", Offset = "0xFDA914", VA = "0xFDA914")]
		public void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xFDA9D4", Offset = "0xFDA9D4", VA = "0xFDA9D4", Slot = "4")]
		public IEnumerator<YamlDocument> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xFDAA88", Offset = "0xFDAA88", VA = "0xFDAA88", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x80AE08", Offset = "0x80AE08")]
	public abstract class YamlVisitor : IYamlVisitor
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xFDAA8C", Offset = "0xFDAA8C", VA = "0xFDAA8C", Slot = "9")]
		protected virtual void Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xFDAA90", Offset = "0xFDAA90", VA = "0xFDAA90", Slot = "10")]
		protected virtual void Visited(YamlStream stream)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xFDAA94", Offset = "0xFDAA94", VA = "0xFDAA94", Slot = "11")]
		protected virtual void Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xFDAA98", Offset = "0xFDAA98", VA = "0xFDAA98", Slot = "12")]
		protected virtual void Visited(YamlDocument document)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xFDAA9C", Offset = "0xFDAA9C", VA = "0xFDAA9C", Slot = "13")]
		protected virtual void Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xFDAAA0", Offset = "0xFDAAA0", VA = "0xFDAAA0", Slot = "14")]
		protected virtual void Visited(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xFDAAA4", Offset = "0xFDAAA4", VA = "0xFDAAA4", Slot = "15")]
		protected virtual void Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xFDAAA8", Offset = "0xFDAAA8", VA = "0xFDAAA8", Slot = "16")]
		protected virtual void Visited(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xFDAAAC", Offset = "0xFDAAAC", VA = "0xFDAAAC", Slot = "17")]
		protected virtual void Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xFDAAB0", Offset = "0xFDAAB0", VA = "0xFDAAB0", Slot = "18")]
		protected virtual void Visited(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xFDAAB4", Offset = "0xFDAAB4", VA = "0xFDAAB4", Slot = "19")]
		protected virtual void VisitChildren(YamlStream stream)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xFDAD6C", Offset = "0xFDAD6C", VA = "0xFDAD6C", Slot = "20")]
		protected virtual void VisitChildren(YamlDocument document)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xFDADE8", Offset = "0xFDADE8", VA = "0xFDADE8", Slot = "21")]
		protected virtual void VisitChildren(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xFDB0A4", Offset = "0xFDB0A4", VA = "0xFDB0A4", Slot = "22")]
		protected virtual void VisitChildren(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xFDB3C8", Offset = "0xFDB3C8", VA = "0xFDB3C8", Slot = "4")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xFDB41C", Offset = "0xFDB41C", VA = "0xFDB41C", Slot = "5")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xFDB470", Offset = "0xFDB470", VA = "0xFDB470", Slot = "6")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xFDB4B0", Offset = "0xFDB4B0", VA = "0xFDB4B0", Slot = "7")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xFDB50C", Offset = "0xFDB50C", VA = "0xFDB50C", Slot = "8")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xFDB568", Offset = "0xFDB568", VA = "0xFDB568")]
		protected YamlVisitor()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public abstract class YamlVisitorBase : IYamlVisitor
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xFDB570", Offset = "0xFDB570", VA = "0xFDB570", Slot = "9")]
		public virtual void Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xFDB580", Offset = "0xFDB580", VA = "0xFDB580", Slot = "10")]
		public virtual void Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xFDB590", Offset = "0xFDB590", VA = "0xFDB590", Slot = "11")]
		public virtual void Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xFDB594", Offset = "0xFDB594", VA = "0xFDB594", Slot = "12")]
		public virtual void Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xFDB5A4", Offset = "0xFDB5A4", VA = "0xFDB5A4", Slot = "13")]
		public virtual void Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xFDB5B4", Offset = "0xFDB5B4", VA = "0xFDB5B4", Slot = "14")]
		protected virtual void VisitPair(YamlNode key, YamlNode value)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xFDB61C", Offset = "0xFDB61C", VA = "0xFDB61C", Slot = "15")]
		protected virtual void VisitChildren(YamlStream stream)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xFDB8D4", Offset = "0xFDB8D4", VA = "0xFDB8D4", Slot = "16")]
		protected virtual void VisitChildren(YamlDocument document)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xFDB950", Offset = "0xFDB950", VA = "0xFDB950", Slot = "17")]
		protected virtual void VisitChildren(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xFDBC0C", Offset = "0xFDBC0C", VA = "0xFDBC0C", Slot = "18")]
		protected virtual void VisitChildren(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xFDBF08", Offset = "0xFDBF08", VA = "0xFDBF08")]
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
		[Address(RVA = "0x125BCB8", Offset = "0x125BCB8", VA = "0x125BCB8")]
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
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80AE50", Offset = "0x80AE50")]
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
			[Address(RVA = "0x125C27C", Offset = "0x125C27C", VA = "0x125C27C", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x125C2E4", Offset = "0x125C2E4", VA = "0x125C2E4", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public object Item
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x125C41C", Offset = "0x125C41C", VA = "0x125C41C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x125C484", Offset = "0x125C484", VA = "0x125C484", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public int Count
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x125C640", Offset = "0x125C640", VA = "0x125C640", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x125C6A8", Offset = "0x125C6A8", VA = "0x125C6A8", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public object SyncRoot
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x125C710", Offset = "0x125C710", VA = "0x125C710", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x125BD74", Offset = "0x125BD74", VA = "0x125BD74")]
		public GenericCollectionToNonGenericAdapter(object genericCollection, Type genericCollectionType, Type genericListType)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x125BF58", Offset = "0x125BF58", VA = "0x125BF58", Slot = "6")]
		public int Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x125C0DC", Offset = "0x125C0DC", VA = "0x125C0DC", Slot = "8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x125C144", Offset = "0x125C144", VA = "0x125C144", Slot = "7")]
		public bool Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x125C1AC", Offset = "0x125C1AC", VA = "0x125C1AC", Slot = "11")]
		public int IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x125C214", Offset = "0x125C214", VA = "0x125C214", Slot = "12")]
		public void Insert(int index, object value)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x125C34C", Offset = "0x125C34C", VA = "0x125C34C", Slot = "13")]
		public void Remove(object value)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x125C3B4", Offset = "0x125C3B4", VA = "0x125C3B4", Slot = "14")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x125C5D8", Offset = "0x125C5D8", VA = "0x125C5D8", Slot = "15")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x125C778", Offset = "0x125C778", VA = "0x125C778", Slot = "19")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80AE88", Offset = "0x80AE88")]
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
				[Address(RVA = "0x125D50C", Offset = "0x125D50C", VA = "0x125D50C", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Token(Token = "0x170000EA")]
			public object Key
			{
				[Token(Token = "0x6000611")]
				[Address(RVA = "0x125D55C", Offset = "0x125D55C", VA = "0x125D55C", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			public object Value
			{
				[Token(Token = "0x6000612")]
				[Address(RVA = "0x125D638", Offset = "0x125D638", VA = "0x125D638", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			public object Current
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x125D718", Offset = "0x125D718", VA = "0x125D718", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x125CB68", Offset = "0x125CB68", VA = "0x125CB68")]
			public DictionaryEnumerator(object genericDictionary, Type genericDictionaryType)
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x125D784", Offset = "0x125D784", VA = "0x125D784", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x125D838", Offset = "0x125D838", VA = "0x125D838", Slot = "9")]
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
			[Address(RVA = "0x125CE4C", Offset = "0x125CE4C", VA = "0x125CE4C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x125CEB4", Offset = "0x125CEB4", VA = "0x125CEB4", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public ICollection Keys
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x125CF1C", Offset = "0x125CF1C", VA = "0x125CF1C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public ICollection Values
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x125CFEC", Offset = "0x125CFEC", VA = "0x125CFEC", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public object Item
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x125D054", Offset = "0x125D054", VA = "0x125D054", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x125D0BC", Offset = "0x125D0BC", VA = "0x125D0BC", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public int Count
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x125D254", Offset = "0x125D254", VA = "0x125D254", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x125D2BC", Offset = "0x125D2BC", VA = "0x125D2BC", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public object SyncRoot
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x125D324", Offset = "0x125D324", VA = "0x125D324", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x125C8F8", Offset = "0x125C8F8", VA = "0x125C8F8")]
		public GenericDictionaryToNonGenericAdapter(object genericDictionary, Type genericDictionaryType)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x125C9BC", Offset = "0x125C9BC", VA = "0x125C9BC", Slot = "13")]
		public void Add(object key, object value)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x125CA24", Offset = "0x125CA24", VA = "0x125CA24", Slot = "14")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x125CA8C", Offset = "0x125CA8C", VA = "0x125CA8C", Slot = "15")]
		public bool Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x125CAF4", Offset = "0x125CAF4", VA = "0x125CAF4", Slot = "6")]
		public IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x125CF84", Offset = "0x125CF84", VA = "0x125CF84", Slot = "7")]
		public void Remove(object key)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x125D1EC", Offset = "0x125D1EC", VA = "0x125D1EC", Slot = "8")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x125D38C", Offset = "0x125D38C", VA = "0x125D38C", Slot = "12")]
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
		[Address(RVA = "0xFDBF48", Offset = "0xFDBF48", VA = "0xFDBF48")]
		public ConvertYamlToJson(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xFDBF74", Offset = "0xFDBF74", VA = "0xFDBF74")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x80C3D0", Offset = "0x80C3D0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B860", Offset = "0x80B860")]
			private string <Receipt>k__BackingField;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B870", Offset = "0x80B870")]
			private DateTime <Date>k__BackingField;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B880", Offset = "0x80B880")]
			private Customer <Customer>k__BackingField;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B890", Offset = "0x80B890")]
			private List<OrderItem> <Items>k__BackingField;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B8A0", Offset = "0x80B8A0")]
			private Address <BillTo>k__BackingField;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B8B0", Offset = "0x80B8B0")]
			private Address <ShipTo>k__BackingField;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B8C0", Offset = "0x80B8C0")]
			private string <SpecialDelivery>k__BackingField;

			[Token(Token = "0x170000ED")]
			public string Receipt
			{
				[Token(Token = "0x6000616")]
				[Address(RVA = "0xFDF014", Offset = "0xFDF014", VA = "0xFDF014")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF14", Offset = "0x80CF14")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000617")]
				[Address(RVA = "0xFDF01C", Offset = "0xFDF01C", VA = "0xFDF01C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF24", Offset = "0x80CF24")]
				set
				{
				}
			}

			[Token(Token = "0x170000EE")]
			public DateTime Date
			{
				[Token(Token = "0x6000618")]
				[Address(RVA = "0xFDF024", Offset = "0xFDF024", VA = "0xFDF024")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF34", Offset = "0x80CF34")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x6000619")]
				[Address(RVA = "0xFDF02C", Offset = "0xFDF02C", VA = "0xFDF02C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF44", Offset = "0x80CF44")]
				set
				{
				}
			}

			[Token(Token = "0x170000EF")]
			public Customer Customer
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0xFDF034", Offset = "0xFDF034", VA = "0xFDF034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF54", Offset = "0x80CF54")]
				get
				{
					return null;
				}
				[Token(Token = "0x600061B")]
				[Address(RVA = "0xFDF03C", Offset = "0xFDF03C", VA = "0xFDF03C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF64", Offset = "0x80CF64")]
				set
				{
				}
			}

			[Token(Token = "0x170000F0")]
			public List<OrderItem> Items
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0xFDEF70", Offset = "0xFDEF70", VA = "0xFDEF70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF74", Offset = "0x80CF74")]
				get
				{
					return null;
				}
				[Token(Token = "0x600061D")]
				[Address(RVA = "0xFDF044", Offset = "0xFDF044", VA = "0xFDF044")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF84", Offset = "0x80CF84")]
				set
				{
				}
			}

			[Token(Token = "0x170000F1")]
			[AttributeAttribute(Name = "YamlMemberAttribute", RVA = "0x80D254", Offset = "0x80D254")]
			public Address BillTo
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0xFDEFBC", Offset = "0xFDEFBC", VA = "0xFDEFBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CF94", Offset = "0x80CF94")]
				get
				{
					return null;
				}
				[Token(Token = "0x600061F")]
				[Address(RVA = "0xFDF04C", Offset = "0xFDF04C", VA = "0xFDF04C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CFA4", Offset = "0x80CFA4")]
				set
				{
				}
			}

			[Token(Token = "0x170000F2")]
			[AttributeAttribute(Name = "YamlMemberAttribute", RVA = "0x80D2A8", Offset = "0x80D2A8")]
			public Address ShipTo
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0xFDEF9C", Offset = "0xFDEF9C", VA = "0xFDEF9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CFB4", Offset = "0x80CFB4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000621")]
				[Address(RVA = "0xFDF054", Offset = "0xFDF054", VA = "0xFDF054")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CFC4", Offset = "0x80CFC4")]
				set
				{
				}
			}

			[Token(Token = "0x170000F3")]
			public string SpecialDelivery
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0xFDEFC4", Offset = "0xFDEFC4", VA = "0xFDEFC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CFD4", Offset = "0x80CFD4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000623")]
				[Address(RVA = "0xFDF05C", Offset = "0xFDF05C", VA = "0xFDF05C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CFE4", Offset = "0x80CFE4")]
				set
				{
				}
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0xFDF064", Offset = "0xFDF064", VA = "0xFDF064")]
			public Order()
			{
			}
		}

		[Token(Token = "0x200011C")]
		public class Customer
		{
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B8D0", Offset = "0x80B8D0")]
			private string <Given>k__BackingField;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B8E0", Offset = "0x80B8E0")]
			private string <Family>k__BackingField;

			[Token(Token = "0x170000F4")]
			public string Given
			{
				[Token(Token = "0x6000625")]
				[Address(RVA = "0xFDEFEC", Offset = "0xFDEFEC", VA = "0xFDEFEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CFF4", Offset = "0x80CFF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000626")]
				[Address(RVA = "0xFDEFF4", Offset = "0xFDEFF4", VA = "0xFDEFF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D004", Offset = "0x80D004")]
				set
				{
				}
			}

			[Token(Token = "0x170000F5")]
			public string Family
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0xFDEFFC", Offset = "0xFDEFFC", VA = "0xFDEFFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D014", Offset = "0x80D014")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000628")]
				[Address(RVA = "0xFDF004", Offset = "0xFDF004", VA = "0xFDF004")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D024", Offset = "0x80D024")]
				set
				{
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0xFDF00C", Offset = "0xFDF00C", VA = "0xFDF00C")]
			public Customer()
			{
			}
		}

		[Token(Token = "0x200011D")]
		public class OrderItem
		{
			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B8F0", Offset = "0x80B8F0")]
			private string <PartNo>k__BackingField;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B900", Offset = "0x80B900")]
			private string <Descrip>k__BackingField;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B910", Offset = "0x80B910")]
			private decimal <Price>k__BackingField;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B920", Offset = "0x80B920")]
			private int <Quantity>k__BackingField;

			[Token(Token = "0x170000F6")]
			[AttributeAttribute(Name = "YamlMemberAttribute", RVA = "0x80D2FC", Offset = "0x80D2FC")]
			public string PartNo
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0xFDEF78", Offset = "0xFDEF78", VA = "0xFDEF78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D034", Offset = "0x80D034")]
				get
				{
					return null;
				}
				[Token(Token = "0x600062B")]
				[Address(RVA = "0xFDF06C", Offset = "0xFDF06C", VA = "0xFDF06C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D044", Offset = "0x80D044")]
				set
				{
				}
			}

			[Token(Token = "0x170000F7")]
			public string Descrip
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0xFDEF94", Offset = "0xFDEF94", VA = "0xFDEF94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D054", Offset = "0x80D054")]
				get
				{
					return null;
				}
				[Token(Token = "0x600062D")]
				[Address(RVA = "0xFDF074", Offset = "0xFDF074", VA = "0xFDF074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D064", Offset = "0x80D064")]
				set
				{
				}
			}

			[Token(Token = "0x170000F8")]
			public decimal Price
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0xFDEF88", Offset = "0xFDEF88", VA = "0xFDEF88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D074", Offset = "0x80D074")]
				get
				{
					return default(decimal);
				}
				[Token(Token = "0x600062F")]
				[Address(RVA = "0xFDF07C", Offset = "0xFDF07C", VA = "0xFDF07C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D084", Offset = "0x80D084")]
				set
				{
				}
			}

			[Token(Token = "0x170000F9")]
			public int Quantity
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0xFDEF80", Offset = "0xFDEF80", VA = "0xFDEF80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D094", Offset = "0x80D094")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000631")]
				[Address(RVA = "0xFDF084", Offset = "0xFDF084", VA = "0xFDF084")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0A4", Offset = "0x80D0A4")]
				set
				{
				}
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0xFDF08C", Offset = "0xFDF08C", VA = "0xFDF08C")]
			public OrderItem()
			{
			}
		}

		[Token(Token = "0x200011E")]
		public class Address
		{
			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B930", Offset = "0x80B930")]
			private string <Street>k__BackingField;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B940", Offset = "0x80B940")]
			private string <City>k__BackingField;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B950", Offset = "0x80B950")]
			private string <State>k__BackingField;

			[Token(Token = "0x170000FA")]
			public string Street
			{
				[Token(Token = "0x6000633")]
				[Address(RVA = "0xFDEFA4", Offset = "0xFDEFA4", VA = "0xFDEFA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0B4", Offset = "0x80D0B4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000634")]
				[Address(RVA = "0xFDEFCC", Offset = "0xFDEFCC", VA = "0xFDEFCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0C4", Offset = "0x80D0C4")]
				set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			public string City
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0xFDEFAC", Offset = "0xFDEFAC", VA = "0xFDEFAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0D4", Offset = "0x80D0D4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000636")]
				[Address(RVA = "0xFDEFD4", Offset = "0xFDEFD4", VA = "0xFDEFD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0E4", Offset = "0x80D0E4")]
				set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			public string State
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0xFDEFB4", Offset = "0xFDEFB4", VA = "0xFDEFB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0F4", Offset = "0x80D0F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000638")]
				[Address(RVA = "0xFDEFDC", Offset = "0xFDEFDC", VA = "0xFDEFDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D104", Offset = "0x80D104")]
				set
				{
				}
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0xFDEFE4", Offset = "0xFDEFE4", VA = "0xFDEFE4")]
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
		[Address(RVA = "0xFDDF3C", Offset = "0xFDDF3C", VA = "0xFDDF3C")]
		public DeserializeObjectGraph(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xFDDF68", Offset = "0xFDDF68", VA = "0xFDDF68")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x80C430", Offset = "0x80C430")]
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
		[Address(RVA = "0xFDF094", Offset = "0xFDF094", VA = "0xFDF094")]
		public DeserializingMultipleDocuments(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xFDF0C0", Offset = "0xFDF0C0", VA = "0xFDF0C0")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x80C490", Offset = "0x80C490")]
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
		[Address(RVA = "0xFE03A8", Offset = "0xFE03A8", VA = "0xFE03A8")]
		public LoadingAYamlStream(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xFE03D4", Offset = "0xFE03D4", VA = "0xFE03D4")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x80C4F0", Offset = "0x80C4F0")]
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
		[Address(RVA = "0xFE112C", Offset = "0xFE112C", VA = "0xFE112C")]
		public SerializeObjectGraph(ITestOutputHelper output)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xFE1158", Offset = "0xFE1158", VA = "0xFE1158")]
		[AttributeAttribute(Name = "SampleAttribute", RVA = "0x80C550", Offset = "0x80C550")]
		public void Main()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class Address
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B560", Offset = "0x80B560")]
		private string <street>k__BackingField;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B570", Offset = "0x80B570")]
		private string <city>k__BackingField;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B580", Offset = "0x80B580")]
		private string <state>k__BackingField;

		[Token(Token = "0x17000057")]
		public string street
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xFDBF10", Offset = "0xFDBF10", VA = "0xFDBF10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C5B0", Offset = "0x80C5B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xFDBF18", Offset = "0xFDBF18", VA = "0xFDBF18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C5C0", Offset = "0x80C5C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public string city
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xFDBF20", Offset = "0xFDBF20", VA = "0xFDBF20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C5D0", Offset = "0x80C5D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xFDBF28", Offset = "0xFDBF28", VA = "0xFDBF28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C5E0", Offset = "0x80C5E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public string state
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xFDBF30", Offset = "0xFDBF30", VA = "0xFDBF30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C5F0", Offset = "0x80C5F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xFDBF38", Offset = "0xFDBF38", VA = "0xFDBF38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C600", Offset = "0x80C600")]
			set
			{
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xFDBF40", Offset = "0xFDBF40", VA = "0xFDBF40")]
		public Address()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class Receipt
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B590", Offset = "0x80B590")]
		private string <receipt>k__BackingField;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B5A0", Offset = "0x80B5A0")]
		private DateTime <date>k__BackingField;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B5B0", Offset = "0x80B5B0")]
		private Customer <customer>k__BackingField;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B5C0", Offset = "0x80B5C0")]
		private Item[] <items>k__BackingField;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B5D0", Offset = "0x80B5D0")]
		private Address <bill_to>k__BackingField;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B5E0", Offset = "0x80B5E0")]
		private Address <ship_to>k__BackingField;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B5F0", Offset = "0x80B5F0")]
		private string <specialDelivery>k__BackingField;

		[Token(Token = "0x1700005A")]
		public string receipt
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xFE10B4", Offset = "0xFE10B4", VA = "0xFE10B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C610", Offset = "0x80C610")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xFE10BC", Offset = "0xFE10BC", VA = "0xFE10BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C620", Offset = "0x80C620")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public DateTime date
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xFE10C4", Offset = "0xFE10C4", VA = "0xFE10C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C630", Offset = "0x80C630")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xFE10CC", Offset = "0xFE10CC", VA = "0xFE10CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C640", Offset = "0x80C640")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public Customer customer
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xFE10D4", Offset = "0xFE10D4", VA = "0xFE10D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C650", Offset = "0x80C650")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xFE10DC", Offset = "0xFE10DC", VA = "0xFE10DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C660", Offset = "0x80C660")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public Item[] items
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xFE10E4", Offset = "0xFE10E4", VA = "0xFE10E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C670", Offset = "0x80C670")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xFE10EC", Offset = "0xFE10EC", VA = "0xFE10EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C680", Offset = "0x80C680")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Address bill_to
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xFE10F4", Offset = "0xFE10F4", VA = "0xFE10F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C690", Offset = "0x80C690")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xFE10FC", Offset = "0xFE10FC", VA = "0xFE10FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C6A0", Offset = "0x80C6A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Address ship_to
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xFE1104", Offset = "0xFE1104", VA = "0xFE1104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C6B0", Offset = "0x80C6B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xFE110C", Offset = "0xFE110C", VA = "0xFE110C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C6C0", Offset = "0x80C6C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public string specialDelivery
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xFE1114", Offset = "0xFE1114", VA = "0xFE1114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C6D0", Offset = "0x80C6D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xFE111C", Offset = "0xFE111C", VA = "0xFE111C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C6E0", Offset = "0x80C6E0")]
			set
			{
			}
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xFE1124", Offset = "0xFE1124", VA = "0xFE1124")]
		public Receipt()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class Customer
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B600", Offset = "0x80B600")]
		private string <given>k__BackingField;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B610", Offset = "0x80B610")]
		private string <family>k__BackingField;

		[Token(Token = "0x17000061")]
		public string given
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xFDDF14", Offset = "0xFDDF14", VA = "0xFDDF14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C6F0", Offset = "0x80C6F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xFDDF1C", Offset = "0xFDDF1C", VA = "0xFDDF1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C700", Offset = "0x80C700")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public string family
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xFDDF24", Offset = "0xFDDF24", VA = "0xFDDF24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C710", Offset = "0x80C710")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xFDDF2C", Offset = "0xFDDF2C", VA = "0xFDDF2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C720", Offset = "0x80C720")]
			set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xFDDF34", Offset = "0xFDDF34", VA = "0xFDDF34")]
		public Customer()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class Item
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B620", Offset = "0x80B620")]
		private string <part_no>k__BackingField;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B630", Offset = "0x80B630")]
		private string <descrip>k__BackingField;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B640", Offset = "0x80B640")]
		private decimal <price>k__BackingField;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B650", Offset = "0x80B650")]
		private int <quantity>k__BackingField;

		[Token(Token = "0x17000063")]
		public string part_no
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xFE035C", Offset = "0xFE035C", VA = "0xFE035C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C730", Offset = "0x80C730")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xFE0364", Offset = "0xFE0364", VA = "0xFE0364")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C740", Offset = "0x80C740")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public string descrip
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xFE036C", Offset = "0xFE036C", VA = "0xFE036C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C750", Offset = "0x80C750")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xFE0374", Offset = "0xFE0374", VA = "0xFE0374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C760", Offset = "0x80C760")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public decimal price
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xFE037C", Offset = "0xFE037C", VA = "0xFE037C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C770", Offset = "0x80C770")]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xFE0388", Offset = "0xFE0388", VA = "0xFE0388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C780", Offset = "0x80C780")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public int quantity
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xFE0390", Offset = "0xFE0390", VA = "0xFE0390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C790", Offset = "0x80C790")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xFE0398", Offset = "0xFE0398", VA = "0xFE0398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C7A0", Offset = "0x80C7A0")]
			set
			{
			}
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xFE03A0", Offset = "0xFE03A0", VA = "0xFE03A0")]
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
			[Address(RVA = "0xFE0168", Offset = "0xFE0168", VA = "0xFE0168", Slot = "4")]
			public void WriteLine()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0xFE0198", Offset = "0xFE0198", VA = "0xFE0198", Slot = "5")]
			public void WriteLine(string value)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0xFDFFBC", Offset = "0xFDFFBC", VA = "0xFDFFBC", Slot = "6")]
			public void WriteLine(string format, params object[] args)
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0xFE01D0", Offset = "0xFE01D0", VA = "0xFE01D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0xFE0024", Offset = "0xFE0024", VA = "0xFE0024")]
			public void Clear()
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xFE0100", Offset = "0xFE0100", VA = "0xFE0100")]
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
		[Address(RVA = "0xFDF410", Offset = "0xFDF410", VA = "0xFDF410")]
		public static string[] GetAllTestNames()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xFDF720", Offset = "0xFDF720", VA = "0xFDF720")]
		public static string[] GetAllTestTitles()
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xFDFA1C", Offset = "0xFDFA1C", VA = "0xFDFA1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xFE0084", Offset = "0xFE0084", VA = "0xFE0084")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B660", Offset = "0x80B660")]
		private string <DisplayName>k__BackingField;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B670", Offset = "0x80B670")]
		private string <Description>k__BackingField;

		[Token(Token = "0x17000067")]
		public string DisplayName
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xFE0204", Offset = "0xFE0204", VA = "0xFE0204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C7B0", Offset = "0x80C7B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0xFE020C", Offset = "0xFE020C", VA = "0xFE020C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C7C0", Offset = "0x80C7C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public string Title
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xFDFA14", Offset = "0xFDFA14", VA = "0xFDFA14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xFE0214", Offset = "0xFE0214", VA = "0xFE0214")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public string Description
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xFDFFB4", Offset = "0xFDFFB4", VA = "0xFDFFB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C7D0", Offset = "0x80C7D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xFE0280", Offset = "0xFE0280", VA = "0xFE0280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C7E0", Offset = "0x80C7E0")]
			set
			{
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xFE0288", Offset = "0xFE0288", VA = "0xFE0288")]
		public SampleAttribute()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public static class TestOutputHelperExtensions
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xFE0290", Offset = "0xFE0290", VA = "0xFE0290")]
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
		[Address(RVA = "0x12454F4", Offset = "0x12454F4", VA = "0x12454F4")]
		public AnchorNotFoundException()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1245560", Offset = "0x1245560", VA = "0x1245560")]
		public AnchorNotFoundException(string message)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x12455DC", Offset = "0x12455DC", VA = "0x12455DC")]
		public AnchorNotFoundException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x12455EC", Offset = "0x12455EC", VA = "0x12455EC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B680", Offset = "0x80B680")]
		private int <Index>k__BackingField;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B690", Offset = "0x80B690")]
		private int <Line>k__BackingField;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B6A0", Offset = "0x80B6A0")]
		private int <LineOffset>k__BackingField;

		[Token(Token = "0x1700006C")]
		public int Index
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1245860", Offset = "0x1245860", VA = "0x1245860")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C800", Offset = "0x80C800")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1245868", Offset = "0x1245868", VA = "0x1245868")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C810", Offset = "0x80C810")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int Line
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1245870", Offset = "0x1245870", VA = "0x1245870")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C820", Offset = "0x80C820")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1245878", Offset = "0x1245878", VA = "0x1245878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C830", Offset = "0x80C830")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public int LineOffset
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1245880", Offset = "0x1245880", VA = "0x1245880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C840", Offset = "0x80C840")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1245888", Offset = "0x1245888", VA = "0x1245888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C850", Offset = "0x80C850")]
			set
			{
			}
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1245890", Offset = "0x1245890", VA = "0x1245890")]
		public Cursor()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x12458BC", Offset = "0x12458BC", VA = "0x12458BC")]
		public Cursor(Cursor cursor)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1245934", Offset = "0x1245934", VA = "0x1245934")]
		public Mark Mark()
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1245AC8", Offset = "0x1245AC8", VA = "0x1245AC8")]
		public void Skip()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1245AE4", Offset = "0x1245AE4", VA = "0x1245AE4")]
		public void SkipLineByOffset(int offset)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1245AFC", Offset = "0x1245AFC", VA = "0x1245AFC")]
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
			[Address(RVA = "0x1245E5C", Offset = "0x1245E5C", VA = "0x1245E5C")]
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
			[Address(RVA = "0x1245E64", Offset = "0x1245E64", VA = "0x1245E64")]
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
			[Address(RVA = "0x1245E6C", Offset = "0x1245E6C", VA = "0x1245E6C")]
			public ScalarData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B2B0", Offset = "0x80B2B0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static MatchEvaluator <>9__89_0;

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x124BFB8", Offset = "0x124BFB8", VA = "0x124BFB8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x124BFC0", Offset = "0x124BFC0", VA = "0x124BFC0")]
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
		[Address(RVA = "0x1245B14", Offset = "0x1245B14", VA = "0x1245B14")]
		public Emitter(TextWriter output)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1245B24", Offset = "0x1245B24", VA = "0x1245B24")]
		public Emitter(TextWriter output, int bestIndent)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1245B30", Offset = "0x1245B30", VA = "0x1245B30")]
		public Emitter(TextWriter output, int bestIndent, int bestWidth)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1245B38", Offset = "0x1245B38", VA = "0x1245B38")]
		public Emitter(TextWriter output, int bestIndent, int bestWidth, bool isCanonical)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1245F7C", Offset = "0x1245F7C", VA = "0x1245F7C", Slot = "4")]
		public void Emit(ParsingEvent @event)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x12464F8", Offset = "0x12464F8", VA = "0x12464F8")]
		private bool NeedMoreEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x12460E0", Offset = "0x12460E0", VA = "0x12460E0")]
		private void AnalyzeEvent(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x124674C", Offset = "0x124674C", VA = "0x124674C")]
		private void AnalyzeAnchor(string anchor, bool isAlias)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x12467A4", Offset = "0x12467A4", VA = "0x12467A4")]
		private void AnalyzeScalar(YamlDotNet.Core.Events.Scalar scalar)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x124747C", Offset = "0x124747C", VA = "0x124747C")]
		private bool ValueIsRepresentableInOutputEncoding(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1245E74", Offset = "0x1245E74", VA = "0x1245E74")]
		private bool IsUnicode(Encoding encoding)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1247108", Offset = "0x1247108", VA = "0x1247108")]
		private void AnalyzeTag(string tag)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1246270", Offset = "0x1246270", VA = "0x1246270")]
		private void StateMachine(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x124768C", Offset = "0x124768C", VA = "0x124768C")]
		private void EmitComment(YamlDotNet.Core.Events.Comment comment)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1247754", Offset = "0x1247754", VA = "0x1247754")]
		private void EmitStreamStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1247844", Offset = "0x1247844", VA = "0x1247844")]
		private void EmitDocumentStart(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1248ED8", Offset = "0x1248ED8", VA = "0x1248ED8")]
		private TagDirectiveCollection NonDefaultTagsAmong(IEnumerable<TagDirective> tagCollection)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x12492A8", Offset = "0x12492A8", VA = "0x12492A8")]
		private void AnalyzeVersionDirective(VersionDirective versionDirective)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x124936C", Offset = "0x124936C", VA = "0x124936C")]
		private static void AppendTagDirectiveTo(TagDirective value, bool allowDuplicates, TagDirectiveCollection tagDirectives)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1248148", Offset = "0x1248148", VA = "0x1248148")]
		private void EmitDocumentContent(ParsingEvent evt)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x12496E4", Offset = "0x12496E4", VA = "0x12496E4")]
		private void EmitNode(ParsingEvent evt, bool isRoot, bool isMapping, bool isSimpleKey)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1249898", Offset = "0x1249898", VA = "0x1249898")]
		private void EmitAlias()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1249908", Offset = "0x1249908", VA = "0x1249908")]
		private void EmitScalar(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1249CD4", Offset = "0x1249CD4", VA = "0x1249CD4")]
		private void SelectScalarStyle(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x124A1EC", Offset = "0x124A1EC", VA = "0x124A1EC")]
		private void ProcessScalar()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x124A37C", Offset = "0x124A37C", VA = "0x124A37C")]
		private void WritePlainScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x124A5F8", Offset = "0x124A5F8", VA = "0x124A5F8")]
		private void WriteSingleQuotedScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x124A888", Offset = "0x124A888", VA = "0x124A888")]
		private void WriteDoubleQuotedScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x124AE94", Offset = "0x124AE94", VA = "0x124AE94")]
		private void WriteLiteralScalar(string value)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x124B0A0", Offset = "0x124B0A0", VA = "0x124B0A0")]
		private void WriteFoldedScalar(string value)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x124B4BC", Offset = "0x124B4BC", VA = "0x124B4BC")]
		private static bool IsSpace(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x124B4CC", Offset = "0x124B4CC", VA = "0x124B4CC")]
		private static bool IsBreak(char character, out char breakChar)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x124B83C", Offset = "0x124B83C", VA = "0x124B83C")]
		private static bool IsBlank(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x124B53C", Offset = "0x124B53C", VA = "0x124B53C")]
		private static bool IsPrintable(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x124B5A4", Offset = "0x124B5A4", VA = "0x124B5A4")]
		private static bool IsHighSurrogate(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x124B5B4", Offset = "0x124B5B4", VA = "0x124B5B4")]
		private static bool IsLowSurrogate(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x12499D8", Offset = "0x12499D8", VA = "0x12499D8")]
		private void EmitSequenceStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1249AF8", Offset = "0x1249AF8", VA = "0x1249AF8")]
		private void EmitMappingStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1249C18", Offset = "0x1249C18", VA = "0x1249C18")]
		private void ProcessAnchor()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1249FF0", Offset = "0x1249FF0", VA = "0x1249FF0")]
		private void ProcessTag()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x12481D0", Offset = "0x12481D0", VA = "0x12481D0")]
		private void EmitDocumentEnd(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x12482FC", Offset = "0x12482FC", VA = "0x12482FC")]
		private void EmitFlowSequenceItem(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1248504", Offset = "0x1248504", VA = "0x1248504")]
		private void EmitFlowMappingKey(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1248780", Offset = "0x1248780", VA = "0x1248780")]
		private void EmitFlowMappingValue(ParsingEvent evt, bool isSimple)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1248874", Offset = "0x1248874", VA = "0x1248874")]
		private void EmitBlockSequenceItem(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x12489F8", Offset = "0x12489F8", VA = "0x12489F8")]
		private void EmitBlockMappingKey(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1248BB0", Offset = "0x1248BB0", VA = "0x1248BB0")]
		private void EmitBlockMappingValue(ParsingEvent evt, bool isSimple)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x124A13C", Offset = "0x124A13C", VA = "0x124A13C")]
		private void IncreaseIndent(bool isFlow, bool isIndentless)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x12494E0", Offset = "0x12494E0", VA = "0x12494E0")]
		private bool CheckEmptyDocument()
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x124BB34", Offset = "0x124BB34", VA = "0x124BB34")]
		private bool CheckSimpleKey()
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x124BD94", Offset = "0x124BD94", VA = "0x124BD94")]
		private int SafeStringLength(string value)
		{
			return default(int);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x124B860", Offset = "0x124B860", VA = "0x124B860")]
		private bool CheckEmptySequence()
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x124B9B8", Offset = "0x124B9B8", VA = "0x124B9B8")]
		private bool CheckEmptyMapping()
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x124B5C8", Offset = "0x124B5C8", VA = "0x124B5C8")]
		private void WriteBlockScalarHints(string value)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1249234", Offset = "0x1249234", VA = "0x1249234")]
		private void WriteIndicator(string indicator, bool needWhitespace, bool whitespace, bool indentation)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1248CE8", Offset = "0x1248CE8", VA = "0x1248CE8")]
		private void WriteIndent()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x124BB08", Offset = "0x124BB08", VA = "0x124BB08")]
		private void WriteAnchor(string value)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x124944C", Offset = "0x124944C", VA = "0x124944C")]
		private void WriteTagHandle(string value)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1249490", Offset = "0x1249490", VA = "0x1249490")]
		private void WriteTagContent(string value, bool needsWhitespace)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x124BDAC", Offset = "0x124BDAC", VA = "0x124BDAC")]
		private string UrlEncode(string text)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1248C90", Offset = "0x1248C90", VA = "0x1248C90")]
		private void Write(char value)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1248DDC", Offset = "0x1248DDC", VA = "0x1248DDC")]
		private void Write(string value)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1248E58", Offset = "0x1248E58", VA = "0x1248E58")]
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
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80AED0", Offset = "0x80AED0")]
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
		[Address(RVA = "0x124E658", Offset = "0x124E658", VA = "0x124E658")]
		public ForwardAnchorNotSupportedException()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x124E65C", Offset = "0x124E65C", VA = "0x124E65C")]
		public ForwardAnchorNotSupportedException(string message)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x124E660", Offset = "0x124E660", VA = "0x124E660")]
		public ForwardAnchorNotSupportedException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x124E668", Offset = "0x124E668", VA = "0x124E668")]
		public ForwardAnchorNotSupportedException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000095")]
	internal static class HashCode
	{
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x124E66C", Offset = "0x124E66C", VA = "0x124E66C")]
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
			[Address(RVA = "0x124E778", Offset = "0x124E778", VA = "0x124E778", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x124E678", Offset = "0x124E678", VA = "0x124E678")]
		public LookAheadBuffer(TextReader input, int capacity)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x124E798", Offset = "0x124E798", VA = "0x124E798")]
		private int GetIndexForOffset(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x124E7FC", Offset = "0x124E7FC", VA = "0x124E7FC", Slot = "5")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x124E920", Offset = "0x124E920", VA = "0x124E920")]
		public void Cache(int length)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x124E9EC", Offset = "0x124E9EC", VA = "0x124E9EC", Slot = "6")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B6B0", Offset = "0x80B6B0")]
		private int <Index>k__BackingField;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B6C0", Offset = "0x80B6C0")]
		private int <Line>k__BackingField;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B6D0", Offset = "0x80B6D0")]
		private int <Column>k__BackingField;

		[Token(Token = "0x17000076")]
		public int Index
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x124EAB4", Offset = "0x124EAB4", VA = "0x124EAB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C860", Offset = "0x80C860")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x124EABC", Offset = "0x124EABC", VA = "0x124EABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C870", Offset = "0x80C870")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public int Line
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x124EAC4", Offset = "0x124EAC4", VA = "0x124EAC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C880", Offset = "0x80C880")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x124EACC", Offset = "0x124EACC", VA = "0x124EACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C890", Offset = "0x80C890")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public int Column
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x124EAD4", Offset = "0x124EAD4", VA = "0x124EAD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C8A0", Offset = "0x80C8A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x124EADC", Offset = "0x124EADC", VA = "0x124EADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C8B0", Offset = "0x80C8B0")]
			private set
			{
			}
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x124EAE4", Offset = "0x124EAE4", VA = "0x124EAE4")]
		public Mark()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x12459AC", Offset = "0x12459AC", VA = "0x12459AC")]
		public Mark(int index, int line, int column)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x124EB10", Offset = "0x124EB10", VA = "0x124EB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x124EBD0", Offset = "0x124EBD0", VA = "0x124EBD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x124EC8C", Offset = "0x124EC8C", VA = "0x124EC8C", Slot = "4")]
		public bool Equals(Mark other)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x124ECCC", Offset = "0x124ECCC", VA = "0x124ECCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x124ED44", Offset = "0x124ED44", VA = "0x124ED44", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x124EE18", Offset = "0x124EE18", VA = "0x124EE18", Slot = "5")]
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
		[Address(RVA = "0x124EF50", Offset = "0x124EF50", VA = "0x124EF50")]
		public MaximumRecursionLevelReachedException()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x124EF54", Offset = "0x124EF54", VA = "0x124EF54")]
		public MaximumRecursionLevelReachedException(string message)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x124EF58", Offset = "0x124EF58", VA = "0x124EF58")]
		public MaximumRecursionLevelReachedException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x124EF60", Offset = "0x124EF60", VA = "0x124EF60")]
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
			[Address(RVA = "0x124FA70", Offset = "0x124FA70", VA = "0x124FA70")]
			public ParsingEvent Clone(ParsingEvent e)
			{
				return null;
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x124FAB4", Offset = "0x124FAB4", VA = "0x124FAB4", Slot = "4")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.AnchorAlias e)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x124FB6C", Offset = "0x124FB6C", VA = "0x124FB6C", Slot = "5")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.StreamStart e)
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x124FBD4", Offset = "0x124FBD4", VA = "0x124FBD4", Slot = "6")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.StreamEnd e)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x124FC3C", Offset = "0x124FC3C", VA = "0x124FC3C", Slot = "7")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.DocumentStart e)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x124FCA4", Offset = "0x124FCA4", VA = "0x124FCA4", Slot = "8")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.DocumentEnd e)
			{
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x124FD0C", Offset = "0x124FD0C", VA = "0x124FD0C", Slot = "9")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.Scalar e)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x124FE4C", Offset = "0x124FE4C", VA = "0x124FE4C", Slot = "10")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(SequenceStart e)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x124FF48", Offset = "0x124FF48", VA = "0x124FF48", Slot = "11")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(SequenceEnd e)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x124FFE0", Offset = "0x124FFE0", VA = "0x124FFE0", Slot = "12")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(MappingStart e)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x12500DC", Offset = "0x12500DC", VA = "0x12500DC", Slot = "13")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(MappingEnd e)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1250174", Offset = "0x1250174", VA = "0x1250174", Slot = "14")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.Comment e)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x124F890", Offset = "0x124F890", VA = "0x124F890")]
			public ParsingEventCloner()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B2C0", Offset = "0x80B2C0")]
		private sealed class <>c
		{
			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IEnumerable<ParsingEvent>, IEnumerable<ParsingEvent>> <>9__8_0;

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x124F8FC", Offset = "0x124F8FC", VA = "0x124F8FC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x124F904", Offset = "0x124F904", VA = "0x124F904")]
			internal IEnumerable<ParsingEvent> <MoveNext>b__8_0(IEnumerable<ParsingEvent> e)
			{
				return null;
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B2D0", Offset = "0x80B2D0")]
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
			[Address(RVA = "0x124F888", Offset = "0x124F888", VA = "0x124F888")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x124F90C", Offset = "0x124F90C", VA = "0x124F90C")]
			internal bool <GetMappingEvents>b__0(ParsingEvent e)
			{
				return default(bool);
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x124F9C0", Offset = "0x124F9C0", VA = "0x124F9C0")]
			internal bool <GetMappingEvents>b__1(ParsingEvent e)
			{
				return default(bool);
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x124FA18", Offset = "0x124FA18", VA = "0x124FA18")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B6E0", Offset = "0x80B6E0")]
		private ParsingEvent <Current>k__BackingField;

		[Token(Token = "0x17000079")]
		public ParsingEvent Current
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x124EFF0", Offset = "0x124EFF0", VA = "0x124EFF0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C8C0", Offset = "0x80C8C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x124EFF8", Offset = "0x124EFF8", VA = "0x124EFF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C8D0", Offset = "0x80C8D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x124EF64", Offset = "0x124EF64", VA = "0x124EF64")]
		public MergingParser(IParser innerParser)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x124F000", Offset = "0x124F000", VA = "0x124F000", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x124F6B4", Offset = "0x124F6B4", VA = "0x124F6B4")]
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
				[Address(RVA = "0x1250858", Offset = "0x1250858", VA = "0x1250858")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x12503F0", Offset = "0x12503F0", VA = "0x12503F0")]
			public void Enqueue(ParsingEvent @event)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x1250AE8", Offset = "0x1250AE8", VA = "0x1250AE8")]
			public ParsingEvent Dequeue()
			{
				return null;
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x125071C", Offset = "0x125071C", VA = "0x125071C")]
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
			[Address(RVA = "0x12507AC", Offset = "0x12507AC", VA = "0x12507AC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x12501DC", Offset = "0x12501DC", VA = "0x12501DC")]
		private Token GetCurrentToken()
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1250494", Offset = "0x1250494", VA = "0x1250494")]
		public Parser(TextReader input)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1250660", Offset = "0x1250660", VA = "0x1250660")]
		public Parser(IScanner scanner)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x12507B4", Offset = "0x12507B4", VA = "0x12507B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x12508E8", Offset = "0x12508E8", VA = "0x12508E8")]
		private ParsingEvent StateMachine()
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x125321C", Offset = "0x125321C", VA = "0x125321C")]
		private void Skip()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1250B7C", Offset = "0x1250B7C", VA = "0x1250B7C")]
		private ParsingEvent ParseStreamStart()
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1250CB0", Offset = "0x1250CB0", VA = "0x1250CB0")]
		private ParsingEvent ParseDocumentStart(bool isImplicit)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x12532EC", Offset = "0x12532EC", VA = "0x12532EC")]
		private VersionDirective ProcessDirectives(TagDirectiveCollection tags)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x12535C0", Offset = "0x12535C0", VA = "0x12535C0")]
		private static void AddTagDirectives(TagDirectiveCollection directives, IEnumerable<TagDirective> source)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x12511AC", Offset = "0x12511AC", VA = "0x12511AC")]
		private ParsingEvent ParseDocumentContent()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1253890", Offset = "0x1253890", VA = "0x1253890")]
		private static ParsingEvent ProcessEmptyScalar(Mark position)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x12514E4", Offset = "0x12514E4", VA = "0x12514E4")]
		private ParsingEvent ParseNode(bool isBlock, bool isIndentlessSequence)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x12513E4", Offset = "0x12513E4", VA = "0x12513E4")]
		private ParsingEvent ParseDocumentEnd()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1251C84", Offset = "0x1251C84", VA = "0x1251C84")]
		private ParsingEvent ParseBlockSequenceEntry(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1251F50", Offset = "0x1251F50", VA = "0x1251F50")]
		private ParsingEvent ParseIndentlessSequenceEntry()
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x12521CC", Offset = "0x12521CC", VA = "0x12521CC")]
		private ParsingEvent ParseBlockMappingKey(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x12524D8", Offset = "0x12524D8", VA = "0x12524D8")]
		private ParsingEvent ParseBlockMappingValue()
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x12526AC", Offset = "0x12526AC", VA = "0x12526AC")]
		private ParsingEvent ParseFlowSequenceEntry(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x125297C", Offset = "0x125297C", VA = "0x125297C")]
		private ParsingEvent ParseFlowSequenceEntryMappingKey()
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1252AE8", Offset = "0x1252AE8", VA = "0x1252AE8")]
		private ParsingEvent ParseFlowSequenceEntryMappingValue()
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1252C50", Offset = "0x1252C50", VA = "0x1252C50")]
		private ParsingEvent ParseFlowSequenceEntryMappingEnd()
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1252CF4", Offset = "0x1252CF4", VA = "0x1252CF4")]
		private ParsingEvent ParseFlowMappingKey(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x12530A0", Offset = "0x12530A0", VA = "0x12530A0")]
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
		[Address(RVA = "0x1253960", Offset = "0x1253960", VA = "0x1253960")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B6F0", Offset = "0x80B6F0")]
		private int <Maximum>k__BackingField;

		[Token(Token = "0x1700007B")]
		public int Maximum
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1253A6C", Offset = "0x1253A6C", VA = "0x1253A6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C930", Offset = "0x80C930")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1253A74", Offset = "0x1253A74", VA = "0x1253A74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C940", Offset = "0x80C940")]
			private set
			{
			}
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1253A7C", Offset = "0x1253A7C", VA = "0x1253A7C")]
		public RecursionLevel(int maximum)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1253AA8", Offset = "0x1253AA8", VA = "0x1253AA8")]
		public void Increment()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1253B30", Offset = "0x1253B30", VA = "0x1253B30")]
		public bool TryIncrement()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1253B54", Offset = "0x1253B54", VA = "0x1253B54")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B700", Offset = "0x80B700")]
		private bool <SkipComments>k__BackingField;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B710", Offset = "0x80B710")]
		private Token <Current>k__BackingField;

		[Token(Token = "0x1700007C")]
		public bool SkipComments
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1253BE8", Offset = "0x1253BE8", VA = "0x1253BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C950", Offset = "0x80C950")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1253BF0", Offset = "0x1253BF0", VA = "0x1253BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C960", Offset = "0x80C960")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Token Current
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1253BFC", Offset = "0x1253BFC", VA = "0x1253BFC", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C970", Offset = "0x80C970")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1253C04", Offset = "0x1253C04", VA = "0x1253C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C980", Offset = "0x80C980")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Mark CurrentPosition
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1253C0C", Offset = "0x1253C0C", VA = "0x1253C0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1250508", Offset = "0x1250508", VA = "0x1250508")]
		public Scanner(TextReader input, bool skipComments = true)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1253C38", Offset = "0x1253C38", VA = "0x1253C38", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1253C7C", Offset = "0x1253C7C", VA = "0x1253C7C", Slot = "7")]
		public bool MoveNextWithoutConsuming()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1253C5C", Offset = "0x1253C5C", VA = "0x1253C5C", Slot = "8")]
		public void ConsumeCurrent()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1253F40", Offset = "0x1253F40", VA = "0x1253F40")]
		private char ReadCurrentCharacter()
		{
			return default(char);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1254058", Offset = "0x1254058", VA = "0x1254058")]
		private char ReadLine()
		{
			return default(char);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1253D3C", Offset = "0x1253D3C", VA = "0x1253D3C")]
		private void FetchMoreTokens()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1254E18", Offset = "0x1254E18", VA = "0x1254E18")]
		private static bool StartsWith(StringBuilder what, char start)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x12542E4", Offset = "0x12542E4", VA = "0x12542E4")]
		private void StaleSimpleKeys()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1254528", Offset = "0x1254528", VA = "0x1254528")]
		private void FetchNextToken()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1255F18", Offset = "0x1255F18", VA = "0x1255F18")]
		private bool CheckWhiteSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1255FE0", Offset = "0x1255FE0", VA = "0x1255FE0")]
		private bool IsDocumentIndicator()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1253FB8", Offset = "0x1253FB8", VA = "0x1253FB8")]
		private void Skip()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1254118", Offset = "0x1254118", VA = "0x1254118")]
		private void SkipLine()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1254FF0", Offset = "0x1254FF0", VA = "0x1254FF0")]
		private void ScanToNextToken()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1256190", Offset = "0x1256190", VA = "0x1256190")]
		private void ProcessComment()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1254EF8", Offset = "0x1254EF8", VA = "0x1254EF8")]
		private void FetchStreamStart()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1255098", Offset = "0x1255098", VA = "0x1255098")]
		private void UnrollIndent(int column)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x12551A0", Offset = "0x12551A0", VA = "0x12551A0")]
		private void FetchStreamEnd()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1255290", Offset = "0x1255290", VA = "0x1255290")]
		private void FetchDirective()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1256680", Offset = "0x1256680", VA = "0x1256680")]
		private Token ScanDirective()
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1255318", Offset = "0x1255318", VA = "0x1255318")]
		private void FetchDocumentIndicator(bool isStartToken)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x125543C", Offset = "0x125543C", VA = "0x125543C")]
		private void FetchFlowCollectionStart(bool isSequenceToken)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1256F34", Offset = "0x1256F34", VA = "0x1256F34")]
		private void IncreaseFlowLevel()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1255518", Offset = "0x1255518", VA = "0x1255518")]
		private void FetchFlowCollectionEnd(bool isSequenceToken)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1257038", Offset = "0x1257038", VA = "0x1257038")]
		private void DecreaseFlowLevel()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x12555F0", Offset = "0x12555F0", VA = "0x12555F0")]
		private void FetchFlowEntry()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x12556D0", Offset = "0x12556D0", VA = "0x12556D0")]
		private void FetchBlockEntry()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x125585C", Offset = "0x125585C", VA = "0x125585C")]
		private void FetchKey()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x12559F0", Offset = "0x12559F0", VA = "0x12559F0")]
		private void FetchValue()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x125715C", Offset = "0x125715C", VA = "0x125715C")]
		private void RollIndent(int column, int number, bool isSequence, Mark position)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1255C78", Offset = "0x1255C78", VA = "0x1255C78")]
		private void FetchAnchor(bool isAlias)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x125742C", Offset = "0x125742C", VA = "0x125742C")]
		private Token ScanAnchor(bool isAlias)
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1255D04", Offset = "0x1255D04", VA = "0x1255D04")]
		private void FetchTag()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x12576F4", Offset = "0x12576F4", VA = "0x12576F4")]
		private Token ScanTag()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1255D80", Offset = "0x1255D80", VA = "0x1255D80")]
		private void FetchBlockScalar(bool isLiteral)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1257F5C", Offset = "0x1257F5C", VA = "0x1257F5C")]
		private Token ScanBlockScalar(bool isLiteral)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x12586B0", Offset = "0x12586B0", VA = "0x12586B0")]
		private int ScanBlockScalarBreaks(int currentIndent, StringBuilder breaks, Mark start, ref Mark end)
		{
			return default(int);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1255E10", Offset = "0x1255E10", VA = "0x1255E10")]
		private void FetchFlowScalar(bool isSingleQuoted)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x12589A4", Offset = "0x12589A4", VA = "0x12589A4")]
		private Token ScanFlowScalar(bool isSingleQuoted)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1255E9C", Offset = "0x1255E9C", VA = "0x1255E9C")]
		private void FetchPlainScalar()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1259378", Offset = "0x1259378", VA = "0x1259378")]
		private Token ScanPlainScalar()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1256540", Offset = "0x1256540", VA = "0x1256540")]
		private void RemoveSimpleKey()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x125689C", Offset = "0x125689C", VA = "0x125689C")]
		private string ScanDirectiveName(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1259A78", Offset = "0x1259A78", VA = "0x1259A78")]
		private void SkipWhitespaces()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1256A68", Offset = "0x1256A68", VA = "0x1256A68")]
		private Token ScanVersionDirectiveValue(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1256BC8", Offset = "0x1256BC8", VA = "0x1256BC8")]
		private Token ScanTagDirectiveValue(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1257A0C", Offset = "0x1257A0C", VA = "0x1257A0C")]
		private string ScanTagUri(string head, Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1259E80", Offset = "0x1259E80", VA = "0x1259E80")]
		private string ScanUriEscapes(Mark start)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1257C84", Offset = "0x1257C84", VA = "0x1257C84")]
		private string ScanTagHandle(bool isDirective, Mark start)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1259AF0", Offset = "0x1259AF0", VA = "0x1259AF0")]
		private int ScanVersionDirectiveNumber(Mark start)
		{
			return default(int);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1256DEC", Offset = "0x1256DEC", VA = "0x1256DEC")]
		private void SaveSimpleKey()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class SemanticErrorException : YamlException
	{
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x125A6B0", Offset = "0x125A6B0", VA = "0x125A6B0")]
		public SemanticErrorException()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x125A6B4", Offset = "0x125A6B4", VA = "0x125A6B4")]
		public SemanticErrorException(string message)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x124F880", Offset = "0x124F880", VA = "0x124F880")]
		public SemanticErrorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x125A6B8", Offset = "0x125A6B8", VA = "0x125A6B8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B720", Offset = "0x80B720")]
		private bool <IsPossible>k__BackingField;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B730", Offset = "0x80B730")]
		private bool <IsRequired>k__BackingField;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B740", Offset = "0x80B740")]
		private int <TokenNumber>k__BackingField;

		[Token(Token = "0x1700007F")]
		public bool IsPossible
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1254518", Offset = "0x1254518", VA = "0x1254518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C990", Offset = "0x80C990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1254EEC", Offset = "0x1254EEC", VA = "0x1254EEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C9A0", Offset = "0x80C9A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool IsRequired
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1254EDC", Offset = "0x1254EDC", VA = "0x1254EDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C9B0", Offset = "0x80C9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x125A6BC", Offset = "0x125A6BC", VA = "0x125A6BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C9C0", Offset = "0x80C9C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public int TokenNumber
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1254520", Offset = "0x1254520", VA = "0x1254520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C9D0", Offset = "0x80C9D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x125A6C8", Offset = "0x125A6C8", VA = "0x125A6C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C9E0", Offset = "0x80C9E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public int Index
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1254EB0", Offset = "0x1254EB0", VA = "0x1254EB0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000083")]
		public int Line
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1254E84", Offset = "0x1254E84", VA = "0x1254E84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000084")]
		public int LineOffset
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1257358", Offset = "0x1257358", VA = "0x1257358")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000085")]
		public Mark Mark
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x125732C", Offset = "0x125732C", VA = "0x125732C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x125645C", Offset = "0x125645C", VA = "0x125645C")]
		public SimpleKey()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x125A230", Offset = "0x125A230", VA = "0x125A230")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B750", Offset = "0x80B750")]
		private int <Position>k__BackingField;

		[Token(Token = "0x17000086")]
		public int Position
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1247644", Offset = "0x1247644", VA = "0x1247644")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80C9F0", Offset = "0x80C9F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x125A6D0", Offset = "0x125A6D0", VA = "0x125A6D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA00", Offset = "0x80CA00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public int Length
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x124764C", Offset = "0x124764C", VA = "0x124764C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000088")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x125A6D8", Offset = "0x125A6D8", VA = "0x125A6D8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1247450", Offset = "0x1247450", VA = "0x1247450")]
		public StringLookAheadBuffer(string value)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x125A720", Offset = "0x125A720", VA = "0x125A720", Slot = "5")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x125A6E0", Offset = "0x125A6E0", VA = "0x125A6E0")]
		private bool IsOutside(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x125A77C", Offset = "0x125A77C", VA = "0x125A77C", Slot = "6")]
		public void Skip(int length)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class SyntaxErrorException : YamlException
	{
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x125A828", Offset = "0x125A828", VA = "0x125A828")]
		public SyntaxErrorException()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x124B5C4", Offset = "0x124B5C4", VA = "0x124B5C4")]
		public SyntaxErrorException(string message)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1254EE4", Offset = "0x1254EE4", VA = "0x1254EE4")]
		public SyntaxErrorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x125A82C", Offset = "0x125A82C", VA = "0x125A82C")]
		public SyntaxErrorException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TagDirectiveCollection : KeyedCollection<string, TagDirective>
	{
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1245E0C", Offset = "0x1245E0C", VA = "0x1245E0C")]
		public TagDirectiveCollection()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x125A830", Offset = "0x125A830", VA = "0x125A830")]
		public TagDirectiveCollection(IEnumerable<TagDirective> tagDirectives)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x125AAE4", Offset = "0x125AAE4", VA = "0x125AAE4", Slot = "39")]
		protected override string GetKeyForItem(TagDirective item)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x124966C", Offset = "0x124966C", VA = "0x124966C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B760", Offset = "0x80B760")]
		private int <Major>k__BackingField;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B770", Offset = "0x80B770")]
		private int <Minor>k__BackingField;

		[Token(Token = "0x17000089")]
		public int Major
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x124965C", Offset = "0x124965C", VA = "0x124965C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA10", Offset = "0x80CA10")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x125B954", Offset = "0x125B954", VA = "0x125B954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA20", Offset = "0x80CA20")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public int Minor
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1249664", Offset = "0x1249664", VA = "0x1249664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA30", Offset = "0x80CA30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x125B95C", Offset = "0x125B95C", VA = "0x125B95C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA40", Offset = "0x80CA40")]
			private set
			{
			}
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1259C78", Offset = "0x1259C78", VA = "0x1259C78")]
		public Version(int major, int minor)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x125B964", Offset = "0x125B964", VA = "0x125B964", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x125BA20", Offset = "0x125BA20", VA = "0x125BA20", Slot = "2")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B780", Offset = "0x80B780")]
		private Mark <Start>k__BackingField;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B790", Offset = "0x80B790")]
		private Mark <End>k__BackingField;

		[Token(Token = "0x1700008B")]
		public Mark Start
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x125BA74", Offset = "0x125BA74", VA = "0x125BA74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA50", Offset = "0x80CA50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x125BA7C", Offset = "0x125BA7C", VA = "0x125BA7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA60", Offset = "0x80CA60")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public Mark End
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x125BA84", Offset = "0x125BA84", VA = "0x125BA84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA70", Offset = "0x80CA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x125BA8C", Offset = "0x125BA8C", VA = "0x125BA8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA80", Offset = "0x80CA80")]
			private set
			{
			}
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x12454F8", Offset = "0x12454F8", VA = "0x12454F8")]
		public YamlException()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1245564", Offset = "0x1245564", VA = "0x1245564")]
		public YamlException(string message)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x12455E4", Offset = "0x12455E4", VA = "0x12455E4")]
		public YamlException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x125BA94", Offset = "0x125BA94", VA = "0x125BA94")]
		public YamlException(Mark start, Mark end, string message, Exception innerException)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x12455F0", Offset = "0x12455F0", VA = "0x12455F0")]
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
			[Address(RVA = "0x1253948", Offset = "0x1253948", VA = "0x1253948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x125AB10", Offset = "0x125AB10", VA = "0x125AB10")]
		public Anchor(string value)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x12576B4", Offset = "0x12576B4", VA = "0x12576B4")]
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
			[Address(RVA = "0x1253930", Offset = "0x1253930", VA = "0x1253930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x125ABD4", Offset = "0x125ABD4", VA = "0x125ABD4")]
		public AnchorAlias(string value)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1257674", Offset = "0x1257674", VA = "0x1257674")]
		public AnchorAlias(string value, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class BlockEnd : Token
	{
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x125AC60", Offset = "0x125AC60", VA = "0x125AC60")]
		public BlockEnd()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1256508", Offset = "0x1256508", VA = "0x1256508")]
		public BlockEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class BlockEntry : Token
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x125ACDC", Offset = "0x125ACDC", VA = "0x125ACDC")]
		public BlockEntry()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x12572BC", Offset = "0x12572BC", VA = "0x12572BC")]
		public BlockEntry(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class BlockMappingStart : Token
	{
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x125AD58", Offset = "0x125AD58", VA = "0x125AD58")]
		public BlockMappingStart()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x12573F4", Offset = "0x12573F4", VA = "0x12573F4")]
		public BlockMappingStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class BlockSequenceStart : Token
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x125ADD4", Offset = "0x125ADD4", VA = "0x125ADD4")]
		public BlockSequenceStart()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x12573BC", Offset = "0x12573BC", VA = "0x12573BC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B7A0", Offset = "0x80B7A0")]
		private string <Value>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B7B0", Offset = "0x80B7B0")]
		private bool <IsInline>k__BackingField;

		[Token(Token = "0x1700008F")]
		public string Value
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x12503D0", Offset = "0x12503D0", VA = "0x12503D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CA90", Offset = "0x80CA90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x125AE50", Offset = "0x125AE50", VA = "0x125AE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CAA0", Offset = "0x80CAA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool IsInline
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x12503D8", Offset = "0x12503D8", VA = "0x12503D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CAB0", Offset = "0x80CAB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x125AE58", Offset = "0x125AE58", VA = "0x125AE58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CAC0", Offset = "0x80CAC0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x125AE64", Offset = "0x125AE64", VA = "0x125AE64")]
		public Comment(string value, bool isInline)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1256408", Offset = "0x1256408", VA = "0x1256408")]
		public Comment(string value, bool isInline, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class DocumentEnd : Token
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x125AEFC", Offset = "0x125AEFC", VA = "0x125AEFC")]
		public DocumentEnd()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1256D7C", Offset = "0x1256D7C", VA = "0x1256D7C")]
		public DocumentEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class DocumentStart : Token
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x125AF78", Offset = "0x125AF78", VA = "0x125AF78")]
		public DocumentStart()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1256DB4", Offset = "0x1256DB4", VA = "0x1256DB4")]
		public DocumentStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class FlowEntry : Token
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x125AFF4", Offset = "0x125AFF4", VA = "0x125AFF4")]
		public FlowEntry()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1257124", Offset = "0x1257124", VA = "0x1257124")]
		public FlowEntry(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class FlowMappingEnd : Token
	{
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x125B070", Offset = "0x125B070", VA = "0x125B070")]
		public FlowMappingEnd()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x12570EC", Offset = "0x12570EC", VA = "0x12570EC")]
		public FlowMappingEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class FlowMappingStart : Token
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x125B0EC", Offset = "0x125B0EC", VA = "0x125B0EC")]
		public FlowMappingStart()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1257000", Offset = "0x1257000", VA = "0x1257000")]
		public FlowMappingStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class FlowSequenceEnd : Token
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x125B168", Offset = "0x125B168", VA = "0x125B168")]
		public FlowSequenceEnd()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x12570B4", Offset = "0x12570B4", VA = "0x12570B4")]
		public FlowSequenceEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class FlowSequenceStart : Token
	{
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x125B1E4", Offset = "0x125B1E4", VA = "0x125B1E4")]
		public FlowSequenceStart()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1256FC8", Offset = "0x1256FC8", VA = "0x1256FC8")]
		public FlowSequenceStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class Key : Token
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x125B260", Offset = "0x125B260", VA = "0x125B260")]
		public Key()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x12572F4", Offset = "0x12572F4", VA = "0x12572F4")]
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
			[Address(RVA = "0x1253958", Offset = "0x1253958", VA = "0x1253958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1253950", Offset = "0x1253950", VA = "0x1253950")]
			get
			{
				return default(ScalarStyle);
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x125B2DC", Offset = "0x125B2DC", VA = "0x125B2DC")]
		public Scalar(string value)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x125B2E4", Offset = "0x125B2E4", VA = "0x125B2E4")]
		public Scalar(string value, ScalarStyle style)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1258954", Offset = "0x1258954", VA = "0x1258954")]
		public Scalar(string value, ScalarStyle style, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public class StreamEnd : Token
	{
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x125B378", Offset = "0x125B378", VA = "0x125B378")]
		public StreamEnd()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1256648", Offset = "0x1256648", VA = "0x1256648")]
		public StreamEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public class StreamStart : Token
	{
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x125B3F4", Offset = "0x125B3F4", VA = "0x125B3F4")]
		public StreamStart()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x12564D0", Offset = "0x12564D0", VA = "0x12564D0")]
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
			[Address(RVA = "0x1253938", Offset = "0x1253938", VA = "0x1253938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public string Suffix
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1253940", Offset = "0x1253940", VA = "0x1253940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x125B470", Offset = "0x125B470", VA = "0x125B470")]
		public Tag(string handle, string suffix)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1257F10", Offset = "0x1257F10", VA = "0x1257F10")]
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
			[Address(RVA = "0x1247684", Offset = "0x1247684", VA = "0x1247684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public string Prefix
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x124767C", Offset = "0x124767C", VA = "0x124767C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x12457D4", Offset = "0x12457D4", VA = "0x12457D4")]
		public TagDirective(string handle, string prefix)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1259CF0", Offset = "0x1259CF0", VA = "0x1259CF0")]
		public TagDirective(string handle, string prefix, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x125B500", Offset = "0x125B500", VA = "0x125B500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x125B5F0", Offset = "0x125B5F0", VA = "0x125B5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x125B654", Offset = "0x125B654", VA = "0x125B654", Slot = "3")]
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
			[Address(RVA = "0x12503E0", Offset = "0x12503E0", VA = "0x12503E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public Mark End
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x12503E8", Offset = "0x12503E8", VA = "0x12503E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x125AB9C", Offset = "0x125AB9C", VA = "0x125AB9C")]
		protected Token(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class Value : Token
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x125B74C", Offset = "0x125B74C", VA = "0x125B74C")]
		public Value()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1257384", Offset = "0x1257384", VA = "0x1257384")]
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
			[Address(RVA = "0x1249654", Offset = "0x1249654", VA = "0x1249654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x125B7C8", Offset = "0x125B7C8", VA = "0x125B7C8")]
		public VersionDirective(Version version)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1259CB0", Offset = "0x1259CB0", VA = "0x1259CB0")]
		public VersionDirective(Version version, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x125B854", Offset = "0x125B854", VA = "0x125B854", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x125B920", Offset = "0x125B920", VA = "0x125B920", Slot = "2")]
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
			[Address(RVA = "0x124C12C", Offset = "0x124C12C", VA = "0x124C12C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x1700009B")]
		public string Value
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1246744", Offset = "0x1246744", VA = "0x1246744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x124C134", Offset = "0x124C134", VA = "0x124C134")]
		public AnchorAlias(string value, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x124C29C", Offset = "0x124C29C", VA = "0x124C29C")]
		public AnchorAlias(string value)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x124C320", Offset = "0x124C320", VA = "0x124C320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x124C39C", Offset = "0x124C39C", VA = "0x124C39C", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class Comment : ParsingEvent
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B7C0", Offset = "0x80B7C0")]
		private string <Value>k__BackingField;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80B7D0", Offset = "0x80B7D0")]
		private bool <IsInline>k__BackingField;

		[Token(Token = "0x1700009C")]
		public string Value
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1248E50", Offset = "0x1248E50", VA = "0x1248E50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CAD0", Offset = "0x80CAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x124C45C", Offset = "0x124C45C", VA = "0x124C45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CAE0", Offset = "0x80CAE0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public bool IsInline
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1248C88", Offset = "0x1248C88", VA = "0x1248C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CAF0", Offset = "0x80CAF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x124C464", Offset = "0x124C464", VA = "0x124C464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CB00", Offset = "0x80CB00")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		internal override EventType Type
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x124C55C", Offset = "0x124C55C", VA = "0x124C55C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x124C470", Offset = "0x124C470", VA = "0x124C470")]
		public Comment(string value, bool isInline)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x124C508", Offset = "0x124C508", VA = "0x124C508")]
		public Comment(string value, bool isInline, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x124C564", Offset = "0x124C564", VA = "0x124C564", Slot = "6")]
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
			[Address(RVA = "0x124C628", Offset = "0x124C628", VA = "0x124C628", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A0")]
		internal override EventType Type
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x124C630", Offset = "0x124C630", VA = "0x124C630", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000A1")]
		public bool IsImplicit
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x124BB2C", Offset = "0x124BB2C", VA = "0x124BB2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x124C638", Offset = "0x124C638", VA = "0x124C638")]
		public DocumentEnd(bool isImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x124C67C", Offset = "0x124C67C", VA = "0x124C67C")]
		public DocumentEnd(bool isImplicit)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x124C70C", Offset = "0x124C70C", VA = "0x124C70C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x124C7B8", Offset = "0x124C7B8", VA = "0x124C7B8", Slot = "6")]
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
			[Address(RVA = "0x124C87C", Offset = "0x124C87C", VA = "0x124C87C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A3")]
		internal override EventType Type
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x124C884", Offset = "0x124C884", VA = "0x124C884", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000A4")]
		public TagDirectiveCollection Tags
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1248ED0", Offset = "0x1248ED0", VA = "0x1248ED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public VersionDirective Version
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x124922C", Offset = "0x124922C", VA = "0x124922C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public bool IsImplicit
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1248EC8", Offset = "0x1248EC8", VA = "0x1248EC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x124C88C", Offset = "0x124C88C", VA = "0x124C88C")]
		public DocumentStart(VersionDirective version, TagDirectiveCollection tags, bool isImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x124C8E4", Offset = "0x124C8E4", VA = "0x124C8E4")]
		public DocumentStart(VersionDirective version, TagDirectiveCollection tags, bool isImplicit)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x124C988", Offset = "0x124C988", VA = "0x124C988")]
		public DocumentStart(Mark start, Mark end)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x124C9CC", Offset = "0x124C9CC", VA = "0x124C9CC")]
		public DocumentStart()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x124CA54", Offset = "0x124CA54", VA = "0x124CA54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x124CB00", Offset = "0x124CB00", VA = "0x124CB00", Slot = "6")]
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
			[Address(RVA = "0x124CBC4", Offset = "0x124CBC4", VA = "0x124CBC4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A8")]
		internal override EventType Type
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x124CBCC", Offset = "0x124CBCC", VA = "0x124CBCC", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x124CBD4", Offset = "0x124CBD4", VA = "0x124CBD4")]
		public MappingEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x124CC0C", Offset = "0x124CC0C", VA = "0x124CC0C")]
		public MappingEnd()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x124CC88", Offset = "0x124CC88", VA = "0x124CC88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x124CCD0", Offset = "0x124CCD0", VA = "0x124CCD0", Slot = "6")]
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
			[Address(RVA = "0x124CD94", Offset = "0x124CD94", VA = "0x124CD94", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AA")]
		internal override EventType Type
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x124CD9C", Offset = "0x124CD9C", VA = "0x124CD9C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000AB")]
		public bool IsImplicit
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x124CDA4", Offset = "0x124CDA4", VA = "0x124CDA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x124CDAC", Offset = "0x124CDAC", VA = "0x124CDAC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		public MappingStyle Style
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x124B9B0", Offset = "0x124B9B0", VA = "0x124B9B0")]
			get
			{
				return default(MappingStyle);
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x124CDBC", Offset = "0x124CDBC", VA = "0x124CDBC")]
		public MappingStart(string anchor, string tag, bool isImplicit, MappingStyle style, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x124CFE8", Offset = "0x124CFE8", VA = "0x124CFE8")]
		public MappingStart(string anchor, string tag, bool isImplicit, MappingStyle style)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x124D08C", Offset = "0x124D08C", VA = "0x124D08C")]
		public MappingStart()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x124D110", Offset = "0x124D110", VA = "0x124D110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x124D338", Offset = "0x124D338", VA = "0x124D338", Slot = "6")]
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
			[Address(RVA = "0x12470F8", Offset = "0x12470F8", VA = "0x12470F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public string Tag
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1247100", Offset = "0x1247100", VA = "0x1247100")]
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
		[Address(RVA = "0x124CE70", Offset = "0x124CE70", VA = "0x124CE70")]
		protected NodeEvent(string anchor, string tag, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x124D3FC", Offset = "0x124D3FC", VA = "0x124D3FC")]
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
			[Address(RVA = "0x124D504", Offset = "0x124D504", VA = "0x124D504", Slot = "4")]
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
			[Address(RVA = "0x124D50C", Offset = "0x124D50C", VA = "0x124D50C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public Mark End
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x124D514", Offset = "0x124D514", VA = "0x124D514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C6")]
		public abstract void Accept(IParsingEventVisitor visitor);

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x124C264", Offset = "0x124C264", VA = "0x124C264")]
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
			[Address(RVA = "0x124D51C", Offset = "0x124D51C", VA = "0x124D51C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000B6")]
		public string Value
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x1247448", Offset = "0x1247448", VA = "0x1247448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public ScalarStyle Style
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x124A364", Offset = "0x124A364", VA = "0x124A364")]
			get
			{
				return default(ScalarStyle);
			}
		}

		[Token(Token = "0x170000B8")]
		public bool IsPlainImplicit
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x124A36C", Offset = "0x124A36C", VA = "0x124A36C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B9")]
		public bool IsQuotedImplicit
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x124A374", Offset = "0x124A374", VA = "0x124A374")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BA")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x124D524", Offset = "0x124D524", VA = "0x124D524", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x124D544", Offset = "0x124D544", VA = "0x124D544")]
		public Scalar(string anchor, string tag, string value, ScalarStyle style, bool isPlainImplicit, bool isQuotedImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x124D614", Offset = "0x124D614", VA = "0x124D614")]
		public Scalar(string anchor, string tag, string value, ScalarStyle style, bool isPlainImplicit, bool isQuotedImplicit)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x124D6DC", Offset = "0x124D6DC", VA = "0x124D6DC")]
		public Scalar(string value)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x124D780", Offset = "0x124D780", VA = "0x124D780")]
		public Scalar(string tag, string value)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x124D828", Offset = "0x124D828", VA = "0x124D828")]
		public Scalar(string anchor, string tag, string value)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x124D8DC", Offset = "0x124D8DC", VA = "0x124D8DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x124DBB8", Offset = "0x124DBB8", VA = "0x124DBB8", Slot = "6")]
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
			[Address(RVA = "0x124DC7C", Offset = "0x124DC7C", VA = "0x124DC7C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BC")]
		internal override EventType Type
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x124DC84", Offset = "0x124DC84", VA = "0x124DC84", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x124DC8C", Offset = "0x124DC8C", VA = "0x124DC8C")]
		public SequenceEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x124DCC4", Offset = "0x124DCC4", VA = "0x124DCC4")]
		public SequenceEnd()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x124DD40", Offset = "0x124DD40", VA = "0x124DD40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x124DD88", Offset = "0x124DD88", VA = "0x124DD88", Slot = "6")]
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
			[Address(RVA = "0x124DE4C", Offset = "0x124DE4C", VA = "0x124DE4C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BE")]
		internal override EventType Type
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x124DE54", Offset = "0x124DE54", VA = "0x124DE54", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x170000BF")]
		public bool IsImplicit
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x124DE5C", Offset = "0x124DE5C", VA = "0x124DE5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x124DE64", Offset = "0x124DE64", VA = "0x124DE64", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		public SequenceStyle Style
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x124B858", Offset = "0x124B858", VA = "0x124B858")]
			get
			{
				return default(SequenceStyle);
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x124DE74", Offset = "0x124DE74", VA = "0x124DE74")]
		public SequenceStart(string anchor, string tag, bool isImplicit, SequenceStyle style, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x124DF28", Offset = "0x124DF28", VA = "0x124DF28")]
		public SequenceStart(string anchor, string tag, bool isImplicit, SequenceStyle style)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x124DFCC", Offset = "0x124DFCC", VA = "0x124DFCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x124E1F4", Offset = "0x124E1F4", VA = "0x124E1F4", Slot = "6")]
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
			[Address(RVA = "0x124E2B8", Offset = "0x124E2B8", VA = "0x124E2B8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C3")]
		internal override EventType Type
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x124E2C0", Offset = "0x124E2C0", VA = "0x124E2C0", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x124E2C8", Offset = "0x124E2C8", VA = "0x124E2C8")]
		public StreamEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x124E300", Offset = "0x124E300", VA = "0x124E300")]
		public StreamEnd()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x124E37C", Offset = "0x124E37C", VA = "0x124E37C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x124E3C4", Offset = "0x124E3C4", VA = "0x124E3C4", Slot = "6")]
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
			[Address(RVA = "0x124E488", Offset = "0x124E488", VA = "0x124E488", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C5")]
		internal override EventType Type
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x124E490", Offset = "0x124E490", VA = "0x124E490", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x124E498", Offset = "0x124E498", VA = "0x124E498")]
		public StreamStart()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x124E514", Offset = "0x124E514", VA = "0x124E514")]
		public StreamStart(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x124E54C", Offset = "0x124E54C", VA = "0x124E54C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x124E594", Offset = "0x124E594", VA = "0x124E594", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
}
