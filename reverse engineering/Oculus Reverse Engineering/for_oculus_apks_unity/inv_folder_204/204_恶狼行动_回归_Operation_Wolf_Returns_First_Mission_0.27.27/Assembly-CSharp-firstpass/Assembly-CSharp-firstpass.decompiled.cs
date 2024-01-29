using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Borodar.RainbowAssets.Core.Json.Internal;
using Borodar.RainbowAssets.Core.Json.Serialization;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Borodar.RainbowAssets.Core.Json
{
	[Token(Token = "0x2000002")]
	public interface IJsonWriter
	{
		[Token(Token = "0x6000001")]
		void WriteStartObject(int propertyCount);

		[Token(Token = "0x6000002")]
		void WritePropertyKey(string key);

		[Token(Token = "0x6000003")]
		void WriteEndObject();

		[Token(Token = "0x6000004")]
		void WriteStartArray(int arrayLength);

		[Token(Token = "0x6000005")]
		void WriteEndArray();

		[Token(Token = "0x6000006")]
		void WriteNull();

		[Token(Token = "0x6000007")]
		void WriteInteger(long value);

		[Token(Token = "0x6000008")]
		void WriteDouble(double value);

		[Token(Token = "0x6000009")]
		void WriteString(string value);

		[Token(Token = "0x600000A")]
		void WriteBoolean(bool value);

		[Token(Token = "0x600000B")]
		void WriteBinary(byte[] value);
	}
	[Token(Token = "0x2000003")]
	public sealed class JsonArrayNode : JsonNode, IList<JsonNode>, ICollection<JsonNode>, IEnumerable<JsonNode>, IEnumerable
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<JsonNode> nodes;

		[Token(Token = "0x17000001")]
		public JsonNode this[int index]
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xED5FC0", Offset = "0xED5FC0", VA = "0xED5FC0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xED6018", Offset = "0xED6018", VA = "0xED6018", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public int Count
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xED6080", Offset = "0xED6080", VA = "0xED6080", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000003")]
		private bool System.Collections.Generic.ICollection<Borodar.RainbowAssets.Core.Json.JsonNode>.IsReadOnly
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xED60C8", Offset = "0xED60C8", VA = "0xED60C8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600000C")]
		public static JsonArrayNode FromArray<T>(T[] array)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xED516C", Offset = "0xED516C", VA = "0xED516C")]
		public static JsonArrayNode FromCollection(IEnumerable collection)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xED54C0", Offset = "0xED54C0", VA = "0xED54C0")]
		public JsonArrayNode()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xED5AE0", Offset = "0xED5AE0", VA = "0xED5AE0")]
		public JsonArrayNode(int length)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xED5C10", Offset = "0xED5C10", VA = "0xED5C10")]
		public JsonArrayNode(JsonNode[] nodes)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xED5DA4", Offset = "0xED5DA4", VA = "0xED5DA4")]
		public JsonArrayNode(IEnumerable<JsonNode> collection)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xED5EA8", Offset = "0xED5EA8", VA = "0xED5EA8", Slot = "10")]
		public int IndexOf(JsonNode item)
		{
			return default(int);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xED5F00", Offset = "0xED5F00", VA = "0xED5F00", Slot = "11")]
		public void Insert(int index, JsonNode item)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xED5F68", Offset = "0xED5F68", VA = "0xED5F68", Slot = "12")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xED5A28", Offset = "0xED5A28", VA = "0xED5A28", Slot = "15")]
		public void Add(JsonNode item)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xED60D0", Offset = "0xED60D0", VA = "0xED60D0", Slot = "16")]
		public void Clear()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xED6140", Offset = "0xED6140", VA = "0xED6140", Slot = "17")]
		public bool Contains(JsonNode item)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xED6198", Offset = "0xED6198", VA = "0xED6198", Slot = "18")]
		public void CopyTo(JsonNode[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xED6200", Offset = "0xED6200", VA = "0xED6200", Slot = "19")]
		public bool Remove(JsonNode item)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xED6258", Offset = "0xED6258", VA = "0xED6258", Slot = "20")]
		public IEnumerator<JsonNode> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xED62E8", Offset = "0xED62E8", VA = "0xED62E8", Slot = "21")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xED6378", Offset = "0xED6378", VA = "0xED6378", Slot = "5")]
		public override JsonNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xED650C", Offset = "0xED650C", VA = "0xED650C", Slot = "6")]
		public override object ConvertTo(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xED6A24", Offset = "0xED6A24", VA = "0xED6A24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xED6B14", Offset = "0xED6B14", VA = "0xED6B14", Slot = "7")]
		public override void Write(IJsonWriter writer)
		{
		}
	}
	[Token(Token = "0x2000004")]
	public sealed class JsonBooleanNode : JsonNode
	{
		[Token(Token = "0x17000004")]
		public bool Value
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xED6E00", Offset = "0xED6E00", VA = "0xED6E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0xED6E08", Offset = "0xED6E08", VA = "0xED6E08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xED6DCC", Offset = "0xED6DCC", VA = "0xED6DCC")]
		public JsonBooleanNode()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xED6DD4", Offset = "0xED6DD4", VA = "0xED6DD4")]
		public JsonBooleanNode(bool value)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xED6E14", Offset = "0xED6E14", VA = "0xED6E14", Slot = "5")]
		public override JsonNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xED6E7C", Offset = "0xED6E7C", VA = "0xED6E7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xED6EE8", Offset = "0xED6EE8", VA = "0xED6EE8", Slot = "6")]
		public override object ConvertTo(Type type)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xED7008", Offset = "0xED7008", VA = "0xED7008", Slot = "7")]
		public override void Write(IJsonWriter writer)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public sealed class JsonDoubleNode : JsonNode
	{
		[Token(Token = "0x17000005")]
		public double Value
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xED70E8", Offset = "0xED70E8", VA = "0xED70E8")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xED70F0", Offset = "0xED70F0", VA = "0xED70F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xED70B8", Offset = "0xED70B8", VA = "0xED70B8")]
		public JsonDoubleNode()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xED70C0", Offset = "0xED70C0", VA = "0xED70C0")]
		public JsonDoubleNode(double value)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xED70F8", Offset = "0xED70F8", VA = "0xED70F8", Slot = "5")]
		public override JsonNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xED7160", Offset = "0xED7160", VA = "0xED7160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xED72E0", Offset = "0xED72E0", VA = "0xED72E0", Slot = "6")]
		public override object ConvertTo(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xED7400", Offset = "0xED7400", VA = "0xED7400", Slot = "7")]
		public override void Write(IJsonWriter writer)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class JsonException : Exception
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xED74B4", Offset = "0xED74B4", VA = "0xED74B4")]
		public JsonException()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xED750C", Offset = "0xED750C", VA = "0xED750C")]
		public JsonException(string message)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xED7574", Offset = "0xED7574", VA = "0xED7574")]
		public JsonException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xED75E4", Offset = "0xED75E4", VA = "0xED75E4")]
		protected JsonException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class JsonFormattingUtility
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0xED7664", Offset = "0xED7664", VA = "0xED7664")]
		private static bool DoubleStringIsIntegerValue(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xED7168", Offset = "0xED7168", VA = "0xED7168")]
		public static string DoubleToString(double value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000008")]
	public sealed class JsonIntegerNode : JsonNode
	{
		[Token(Token = "0x17000006")]
		public long Value
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xED7720", Offset = "0xED7720", VA = "0xED7720")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xED7728", Offset = "0xED7728", VA = "0xED7728")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public ulong UnsignedValue
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xED7730", Offset = "0xED7730", VA = "0xED7730")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xED7738", Offset = "0xED7738", VA = "0xED7738")]
			set
			{
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xED76F0", Offset = "0xED76F0", VA = "0xED76F0")]
		public JsonIntegerNode()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xED76F8", Offset = "0xED76F8", VA = "0xED76F8")]
		public JsonIntegerNode(long value)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xED7740", Offset = "0xED7740", VA = "0xED7740", Slot = "5")]
		public override JsonNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xED77A8", Offset = "0xED77A8", VA = "0xED77A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xED7820", Offset = "0xED7820", VA = "0xED7820", Slot = "6")]
		public override object ConvertTo(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xED79B4", Offset = "0xED79B4", VA = "0xED79B4", Slot = "7")]
		public override void Write(IJsonWriter writer)
		{
		}
	}
	[Token(Token = "0x2000009")]
	public abstract class JsonNode : ICloneable
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0xED7A60", Offset = "0xED7A60", VA = "0xED7A60")]
		public static JsonNode ReadFrom(string json)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xED7C70", Offset = "0xED7C70", VA = "0xED7C70")]
		public static JsonNode ReadFrom(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xED7C08", Offset = "0xED7C08", VA = "0xED7C08")]
		public static JsonNode ReadFrom(TextReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xED5548", Offset = "0xED5548", VA = "0xED5548")]
		public static JsonNode ConvertFrom(object value)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xED80EC", Offset = "0xED80EC", VA = "0xED80EC")]
		private static JsonObjectNode FromDictionaryStyleCollection(ICollection collection, MetaType metaType)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xED8AC8", Offset = "0xED8AC8", VA = "0xED8AC8", Slot = "4")]
		private object System.ICloneable.Clone()
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		public abstract JsonNode Clone();

		[Token(Token = "0x600004B")]
		public abstract object ConvertTo(Type type);

		[Token(Token = "0x600004C")]
		public T ConvertTo<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xED6A84", Offset = "0xED6A84", VA = "0xED6A84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		public abstract void Write(IJsonWriter writer);

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xED5AD8", Offset = "0xED5AD8", VA = "0xED5AD8")]
		protected JsonNode()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public sealed class JsonObjectNode : JsonNode, IDictionary<string, JsonNode>, ICollection<KeyValuePair<string, JsonNode>>, IEnumerable<KeyValuePair<string, JsonNode>>, IEnumerable
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, JsonNode> properties;

		[Token(Token = "0x17000008")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xED8D10", Offset = "0xED8D10", VA = "0xED8D10", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public ICollection<JsonNode> Values
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xED8D60", Offset = "0xED8D60", VA = "0xED8D60", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public JsonNode this[string key]
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xED8DB0", Offset = "0xED8DB0", VA = "0xED8DB0", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xED8A60", Offset = "0xED8A60", VA = "0xED8A60", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public int Count
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xED8E20", Offset = "0xED8E20", VA = "0xED8E20", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Borodar.RainbowAssets.Core.Json.JsonNode>>.IsReadOnly
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xED8E70", Offset = "0xED8E70", VA = "0xED8E70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xED8524", Offset = "0xED8524", VA = "0xED8524")]
		internal static JsonObjectNode FromInstance(object instance)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		public static JsonObjectNode FromDictionary<TValue>(IDictionary<string, TValue> dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xED89D8", Offset = "0xED89D8", VA = "0xED89D8")]
		public JsonObjectNode()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xED8B90", Offset = "0xED8B90", VA = "0xED8B90", Slot = "8")]
		public void Add(string key, JsonNode value)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xED8BF8", Offset = "0xED8BF8", VA = "0xED8BF8", Slot = "19")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xED8C50", Offset = "0xED8C50", VA = "0xED8C50", Slot = "20")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xED8CA8", Offset = "0xED8CA8", VA = "0xED8CA8", Slot = "9")]
		public bool TryGetValue(string key, out JsonNode value)
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xED8F14", Offset = "0xED8F14", VA = "0xED8F14", Slot = "12")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Borodar.RainbowAssets.Core.Json.JsonNode>>.Add(KeyValuePair<string, JsonNode> item)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xED8F94", Offset = "0xED8F94", VA = "0xED8F94", Slot = "13")]
		public void Clear()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xED8FE4", Offset = "0xED8FE4", VA = "0xED8FE4", Slot = "14")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Borodar.RainbowAssets.Core.Json.JsonNode>>.Contains(KeyValuePair<string, JsonNode> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xED9048", Offset = "0xED9048", VA = "0xED9048", Slot = "15")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Borodar.RainbowAssets.Core.Json.JsonNode>>.CopyTo(KeyValuePair<string, JsonNode>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xED9104", Offset = "0xED9104", VA = "0xED9104", Slot = "16")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Borodar.RainbowAssets.Core.Json.JsonNode>>.Remove(KeyValuePair<string, JsonNode> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xED91C0", Offset = "0xED91C0", VA = "0xED91C0", Slot = "17")]
		public IEnumerator<KeyValuePair<string, JsonNode>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xED9254", Offset = "0xED9254", VA = "0xED9254", Slot = "18")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xED92E8", Offset = "0xED92E8", VA = "0xED92E8", Slot = "5")]
		public override JsonNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xED9490", Offset = "0xED9490", VA = "0xED9490", Slot = "6")]
		public override object ConvertTo(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xED9C78", Offset = "0xED9C78", VA = "0xED9C78", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xED9CD8", Offset = "0xED9CD8", VA = "0xED9CD8", Slot = "7")]
		public override void Write(IJsonWriter writer)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class JsonParserException : JsonException
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string message;

		[Token(Token = "0x1700000D")]
		public override string Message
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xEDA0F0", Offset = "0xEDA0F0", VA = "0xEDA0F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public int LineNumber
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xEDA1D8", Offset = "0xEDA1D8", VA = "0xEDA1D8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xEDA1E0", Offset = "0xEDA1E0", VA = "0xEDA1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int LinePosition
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xEDA1E8", Offset = "0xEDA1E8", VA = "0xEDA1E8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xEDA1F0", Offset = "0xEDA1F0", VA = "0xEDA1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xEDA01C", Offset = "0xEDA01C", VA = "0xEDA01C")]
		public JsonParserException(string message, int lineNumber, int linePosition)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xEDA044", Offset = "0xEDA044", VA = "0xEDA044")]
		protected JsonParserException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xEDA1F8", Offset = "0xEDA1F8", VA = "0xEDA1F8", Slot = "10")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class JsonPropertyAttribute : Attribute
	{
		[Token(Token = "0x17000010")]
		public string Name
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xEDA2DC", Offset = "0xEDA2DC", VA = "0xEDA2DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xEDA2E4", Offset = "0xEDA2E4", VA = "0xEDA2E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xEDA2A4", Offset = "0xEDA2A4", VA = "0xEDA2A4")]
		public JsonPropertyAttribute()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xEDA2AC", Offset = "0xEDA2AC", VA = "0xEDA2AC")]
		public JsonPropertyAttribute(string propertyName)
		{
		}
	}
	[Token(Token = "0x200000D")]
	internal sealed class JsonReader
	{
		[Token(Token = "0x200000E")]
		private enum ReadPhase
		{
			[Token(Token = "0x4000019")]
			ReadingStream,
			[Token(Token = "0x400001A")]
			HasReachedEndOfStream,
			[Token(Token = "0x400001B")]
			HasReachedEndOfInput
		}

		[Token(Token = "0x400000A")]
		private const int MaximumLookahead = 6;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TextReader jsonReader;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder stringLiteral;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StringBuilder unicodeSequence;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private char[] buffer;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int bufferSize;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int bufferPos;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ReadPhase phase;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool hasReachedEnd;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int lineNumber;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int linePosition;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool initLineEnding;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private char lineEnding;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lineEndingLength;

		[Token(Token = "0x17000011")]
		private bool HasReachedEnd
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xEDA704", Offset = "0xEDA704", VA = "0xEDA704")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xED7CD8", Offset = "0xED7CD8", VA = "0xED7CD8")]
		public static JsonReader Create(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xED7E28", Offset = "0xED7E28", VA = "0xED7E28")]
		public static JsonReader Create(TextReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xEDA2EC", Offset = "0xEDA2EC", VA = "0xEDA2EC")]
		private JsonReader(TextReader reader)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xEDA410", Offset = "0xEDA410", VA = "0xEDA410")]
		private void ReadBuffer()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xEDA72C", Offset = "0xEDA72C", VA = "0xEDA72C")]
		private char Peek()
		{
			return default(char);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xEDA760", Offset = "0xEDA760", VA = "0xEDA760")]
		private char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xEDA798", Offset = "0xEDA798", VA = "0xEDA798")]
		private char ReadChar()
		{
			return default(char);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xEDA82C", Offset = "0xEDA82C", VA = "0xEDA82C")]
		private void Accept(int count = 1)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xEDA688", Offset = "0xEDA688", VA = "0xEDA688")]
		private void SkipWhitespace()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xEDA864", Offset = "0xEDA864", VA = "0xEDA864")]
		private bool MatchString(string match)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xED7DEC", Offset = "0xED7DEC", VA = "0xED7DEC")]
		public JsonNode Read()
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xEDA92C", Offset = "0xEDA92C", VA = "0xEDA92C")]
		private JsonNode ReadValue()
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xEDB048", Offset = "0xEDB048", VA = "0xEDB048")]
		private string ReadStringLiteral(string context)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xEDB810", Offset = "0xEDB810", VA = "0xEDB810")]
		private void CheckStringCharacter(char c, string context)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xEDB430", Offset = "0xEDB430", VA = "0xEDB430")]
		private JsonNode ReadArray()
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xEDB58C", Offset = "0xEDB58C", VA = "0xEDB58C")]
		private JsonNode ReadObject()
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xEDAC44", Offset = "0xEDAC44", VA = "0xEDAC44")]
		private JsonNode ReadNumeric()
		{
			return null;
		}
	}
	[Token(Token = "0x200000F")]
	public sealed class JsonStringNode : JsonNode
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string value;

		[Token(Token = "0x17000012")]
		public string Value
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xEDB9DC", Offset = "0xEDB9DC", VA = "0xEDB9DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xEDB974", Offset = "0xEDB974", VA = "0xEDB974")]
			set
			{
			}
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xEDB91C", Offset = "0xEDB91C", VA = "0xEDB91C")]
		public JsonStringNode()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xED80B0", Offset = "0xED80B0", VA = "0xED80B0")]
		public JsonStringNode(string value)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xEDB9E4", Offset = "0xEDB9E4", VA = "0xEDB9E4", Slot = "5")]
		public override JsonNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xEDBA54", Offset = "0xEDBA54", VA = "0xEDBA54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xEDBAD0", Offset = "0xEDBAD0", VA = "0xEDBAD0", Slot = "6")]
		public override object ConvertTo(Type type)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xEDBBC0", Offset = "0xEDBBC0", VA = "0xEDBBC0", Slot = "7")]
		public override void Write(IJsonWriter writer)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class JsonUtility
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xEDBC6C", Offset = "0xEDBC6C", VA = "0xEDBC6C")]
		public static JsonNode ReadFrom(string json)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xEDBC70", Offset = "0xEDBC70", VA = "0xEDBC70")]
		public static JsonNode ReadFrom(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xEDBC74", Offset = "0xEDBC74", VA = "0xEDBC74")]
		public static JsonNode ReadFrom(TextReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xEDBC78", Offset = "0xEDBC78", VA = "0xEDBC78")]
		public static JsonNode ConvertFrom(object value)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xEDBC7C", Offset = "0xEDBC7C", VA = "0xEDBC7C")]
		public static void WriteTo(this JsonNode node, StringBuilder builder)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xEDBD1C", Offset = "0xEDBD1C", VA = "0xEDBD1C")]
		public static void WriteTo(this JsonNode node, StringBuilder builder, JsonWriterSettings settings)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xEDBE8C", Offset = "0xEDBE8C", VA = "0xEDBE8C")]
		public static void WriteTo(this JsonNode node, Stream stream)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xEDBF2C", Offset = "0xEDBF2C", VA = "0xEDBF2C")]
		public static void WriteTo(this JsonNode node, Stream stream, JsonWriterSettings settings)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xEDC0E8", Offset = "0xEDC0E8", VA = "0xEDC0E8")]
		public static void WriteTo(this JsonNode node, TextWriter textWriter)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xEDC188", Offset = "0xEDC188", VA = "0xEDC188")]
		public static void WriteTo(this JsonNode node, TextWriter textWriter, JsonWriterSettings settings)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xEDC2AC", Offset = "0xEDC2AC", VA = "0xEDC2AC")]
		public static string ToJsonString(this JsonNode node)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xED8AD4", Offset = "0xED8AD4", VA = "0xED8AD4")]
		public static string ToJsonString(this JsonNode node, JsonWriterSettings settings)
		{
			return null;
		}
	}
	[Token(Token = "0x2000011")]
	public sealed class JsonWriter : IJsonWriter
	{
		[Token(Token = "0x2000012")]
		private enum WriteContext
		{
			[Token(Token = "0x4000022")]
			Root,
			[Token(Token = "0x4000023")]
			Object,
			[Token(Token = "0x4000024")]
			Array
		}

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TextWriter writer;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SimpleStack<WriteContext> writeContextStack;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isWriteContextEmpty;

		[Token(Token = "0x17000013")]
		public JsonWriterSettings Settings
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xEDC74C", Offset = "0xEDC74C", VA = "0xEDC74C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xEDC754", Offset = "0xEDC754", VA = "0xEDC754")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xEDC3A0", Offset = "0xEDC3A0", VA = "0xEDC3A0")]
		public static JsonWriter Create()
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xEDC33C", Offset = "0xEDC33C", VA = "0xEDC33C")]
		public static JsonWriter Create(JsonWriterSettings settings)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xEDC428", Offset = "0xEDC428", VA = "0xEDC428")]
		public static JsonWriter Create(StringBuilder builder)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xEDBD60", Offset = "0xEDBD60", VA = "0xEDBD60")]
		public static JsonWriter Create(StringBuilder builder, JsonWriterSettings settings)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xEDC4B8", Offset = "0xEDC4B8", VA = "0xEDC4B8")]
		public static JsonWriter Create(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xEDBF70", Offset = "0xEDBF70", VA = "0xEDBF70")]
		public static JsonWriter Create(Stream stream, JsonWriterSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xEDC6B0", Offset = "0xEDC6B0", VA = "0xEDC6B0")]
		public static JsonWriter Create(TextWriter textWriter)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xEDC1CC", Offset = "0xEDC1CC", VA = "0xEDC1CC")]
		public static JsonWriter Create(TextWriter textWriter, JsonWriterSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xEDC548", Offset = "0xEDC548", VA = "0xEDC548")]
		private JsonWriter(TextWriter textWriter, JsonWriterSettings settings)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xEDC75C", Offset = "0xEDC75C", VA = "0xEDC75C")]
		private void WriteIndent()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xEDC7FC", Offset = "0xEDC7FC", VA = "0xEDC7FC")]
		private void WriteLine()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xEDC83C", Offset = "0xEDC83C", VA = "0xEDC83C")]
		private void WriteSpace()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xEDC8B4", Offset = "0xEDC8B4", VA = "0xEDC8B4")]
		private void WriteEscapedLiteral(string value)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xEDCAEC", Offset = "0xEDCAEC", VA = "0xEDCAEC")]
		private void DoBeginValue()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xEDCB84", Offset = "0xEDCB84", VA = "0xEDCB84")]
		private void DoEndValue()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xEDCB8C", Offset = "0xEDCB8C", VA = "0xEDCB8C")]
		private void WriteValueRaw(string content)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xEDCC04", Offset = "0xEDCC04", VA = "0xEDCC04", Slot = "4")]
		public void WriteStartObject(int propertyCount)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xEDCC74", Offset = "0xEDCC74", VA = "0xEDCC74")]
		public void WriteStartObject()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xEDCCF8", Offset = "0xEDCCF8", VA = "0xEDCCF8", Slot = "5")]
		public void WritePropertyKey(string key)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xEDCDC0", Offset = "0xEDCDC0", VA = "0xEDCDC0", Slot = "6")]
		public void WriteEndObject()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xEDCE4C", Offset = "0xEDCE4C", VA = "0xEDCE4C", Slot = "7")]
		public void WriteStartArray(int arrayLength)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xEDCEBC", Offset = "0xEDCEBC", VA = "0xEDCEBC")]
		public void WriteStartArray()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xEDCF40", Offset = "0xEDCF40", VA = "0xEDCF40", Slot = "8")]
		public void WriteEndArray()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xEDBE44", Offset = "0xEDBE44", VA = "0xEDBE44", Slot = "9")]
		public void WriteNull()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xEDCFCC", Offset = "0xEDCFCC", VA = "0xEDCFCC", Slot = "10")]
		public void WriteInteger(long value)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xEDD04C", Offset = "0xEDD04C", VA = "0xEDD04C", Slot = "11")]
		public void WriteDouble(double value)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xEDD068", Offset = "0xEDD068", VA = "0xEDD068", Slot = "12")]
		public void WriteString(string value)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xEDD0D4", Offset = "0xEDD0D4", VA = "0xEDD0D4", Slot = "13")]
		public void WriteBoolean(bool value)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xEDD144", Offset = "0xEDD144", VA = "0xEDD144", Slot = "14")]
		public void WriteBinary(byte[] value)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xEDD204", Offset = "0xEDD204", VA = "0xEDD204", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000013")]
	public sealed class JsonWriterSettings
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool indent;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string indentChars;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string newlineChars;

		[Token(Token = "0x17000014")]
		internal static JsonWriterSettings DefaultSettings
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xEDD2F4", Offset = "0xEDD2F4", VA = "0xEDD2F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xEDD34C", Offset = "0xEDD34C", VA = "0xEDD34C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xEDD54C", Offset = "0xEDD54C", VA = "0xEDD54C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xEDD554", Offset = "0xEDD554", VA = "0xEDD554")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool Indent
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xEDD5BC", Offset = "0xEDD5BC", VA = "0xEDD5BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xEDD5C4", Offset = "0xEDD5C4", VA = "0xEDD5C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public string IndentChars
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xEDD5E8", Offset = "0xEDD5E8", VA = "0xEDD5E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xEDD5F0", Offset = "0xEDD5F0", VA = "0xEDD5F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public string NewLineChars
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xEDD66C", Offset = "0xEDD66C", VA = "0xEDD66C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xEDD674", Offset = "0xEDD674", VA = "0xEDD674")]
			set
			{
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xEDD3B4", Offset = "0xEDD3B4", VA = "0xEDD3B4")]
		static JsonWriterSettings()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xEDD4A8", Offset = "0xEDD4A8", VA = "0xEDD4A8")]
		public JsonWriterSettings()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xEDC740", Offset = "0xEDC740", VA = "0xEDC740")]
		public void MarkReadOnly()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xEDD560", Offset = "0xEDD560", VA = "0xEDD560")]
		private void CheckReadOnly()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xEDD4C4", Offset = "0xEDD4C4", VA = "0xEDD4C4")]
		public void Reset()
		{
		}
	}
}
namespace Borodar.RainbowAssets.Core.Json.Serialization
{
	[Token(Token = "0x2000014")]
	internal sealed class MetaType
	{
		[Token(Token = "0x2000015")]
		internal enum NodeType
		{
			[Token(Token = "0x4000037")]
			Unknown,
			[Token(Token = "0x4000038")]
			Integer,
			[Token(Token = "0x4000039")]
			Double,
			[Token(Token = "0x400003A")]
			Boolean,
			[Token(Token = "0x400003B")]
			String,
			[Token(Token = "0x400003C")]
			Array,
			[Token(Token = "0x400003D")]
			Object
		}

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, MetaType> s_MetaTypeCache;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<MethodInfo> onSerializingMethods;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<MethodInfo> onSerializedMethods;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<MethodInfo> onDeserializingMethods;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<MethodInfo> onDeserializedMethods;

		[Token(Token = "0x17000019")]
		public Type Type
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xEDE504", Offset = "0xEDE504", VA = "0xEDE504")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xEDE50C", Offset = "0xEDE50C", VA = "0xEDE50C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Type GenericCollectionElementType
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xEDE514", Offset = "0xEDE514", VA = "0xEDE514")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xEDE51C", Offset = "0xEDE51C", VA = "0xEDE51C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool IsGenericCollection
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xEDE524", Offset = "0xEDE524", VA = "0xEDE524")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public bool IsCollection
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xEDE584", Offset = "0xEDE584", VA = "0xEDE584")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xEDE58C", Offset = "0xEDE58C", VA = "0xEDE58C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public PropertyInfo KeyPropertyInfo
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xEDE598", Offset = "0xEDE598", VA = "0xEDE598")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xEDE5A0", Offset = "0xEDE5A0", VA = "0xEDE5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public PropertyInfo ValuePropertyInfo
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xEDE5A8", Offset = "0xEDE5A8", VA = "0xEDE5A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xEDE5B0", Offset = "0xEDE5B0", VA = "0xEDE5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool IsDictionaryStyleCollection
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xED80DC", Offset = "0xED80DC", VA = "0xED80DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public NodeType TargetNodeType
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xEDE5B8", Offset = "0xEDE5B8", VA = "0xEDE5B8")]
			[CompilerGenerated]
			get
			{
				return default(NodeType);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xEDE5C0", Offset = "0xEDE5C0", VA = "0xEDE5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public IList<SerializableMember> SerializableMembers
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xEDE954", Offset = "0xEDE954", VA = "0xEDE954")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xEDE95C", Offset = "0xEDE95C", VA = "0xEDE95C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xED7ED8", Offset = "0xED7ED8", VA = "0xED7ED8")]
		public static MetaType FromType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xEDD6F0", Offset = "0xEDD6F0", VA = "0xEDD6F0")]
		private MetaType(Type type)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xEDD74C", Offset = "0xEDD74C", VA = "0xEDD74C")]
		private void ScanForCollection()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xEDD884", Offset = "0xEDD884", VA = "0xEDD884")]
		private void ScanForDictionaryStyleCollection()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xEDDA4C", Offset = "0xEDDA4C", VA = "0xEDDA4C")]
		private NodeType DetermineTargetNodeType()
		{
			return default(NodeType);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xEDDB68", Offset = "0xEDDB68", VA = "0xEDDB68")]
		private void SearchForSerializableMembers()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xEDE964", Offset = "0xEDE964", VA = "0xEDE964")]
		private static string ResolvePropertyName(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xEDDF28", Offset = "0xEDDF28", VA = "0xEDDF28")]
		private void SearchForSerializationCallbacks()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xEDEA8C", Offset = "0xEDEA8C", VA = "0xEDEA8C")]
		private void Invoke(List<MethodInfo> callbacks, object obj, StreamingContext context)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xED8B60", Offset = "0xED8B60", VA = "0xED8B60")]
		public void InvokeOnSerializing(object obj, StreamingContext context)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xED8B78", Offset = "0xED8B78", VA = "0xED8B78")]
		public void InvokeOnSerialized(object obj, StreamingContext context)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xED9C48", Offset = "0xED9C48", VA = "0xED9C48")]
		public void InvokeOnDeserializing(object obj, StreamingContext context)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xED9C60", Offset = "0xED9C60", VA = "0xED9C60")]
		public void InvokeOnDeserialized(object obj, StreamingContext context)
		{
		}
	}
	[Token(Token = "0x2000016")]
	internal static class ReflectionUtility
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xEDE5C8", Offset = "0xEDE5C8", VA = "0xEDE5C8")]
		public static bool IsNumericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xEDE704", Offset = "0xEDE704", VA = "0xEDE704")]
		public static bool IsIntegralType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xEDE81C", Offset = "0xEDE81C", VA = "0xEDE81C")]
		public static bool IsBooleanType(Type type)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000017")]
	internal struct SerializableMember
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string ResolvedName;
	}
}
namespace Borodar.RainbowAssets.Core.Json.Internal
{
	[Token(Token = "0x2000018")]
	internal sealed class SimpleStack<T>
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> stack;

		[Token(Token = "0x17000022")]
		public int Count
		{
			[Token(Token = "0x60000EA")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000EB")]
		public void Push(T value)
		{
		}

		[Token(Token = "0x60000EC")]
		public T Pop()
		{
			return (T)null;
		}

		[Token(Token = "0x60000ED")]
		public T Peek()
		{
			return (T)null;
		}

		[Token(Token = "0x60000EE")]
		public SimpleStack()
		{
		}
	}
}
namespace Borodar.RainbowAssets.Core.Games
{
	[Token(Token = "0x2000019")]
	public static class ExceptionUtility
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xEDEE60", Offset = "0xEDEE60", VA = "0xEDEE60")]
		public static void CheckExpectedStringArgument(string arg, string paramName)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xEDEF38", Offset = "0xEDEF38", VA = "0xEDEF38")]
		public static void CheckArgumentNotNull(object arg, string paramName)
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public sealed class DependencyAttribute : Attribute
	{
		[Token(Token = "0x17000023")]
		public Type DependencyType
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xEDEFBC", Offset = "0xEDEFBC", VA = "0xEDEFBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xEDEFC4", Offset = "0xEDEFC4", VA = "0xEDEFC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xEDEF8C", Offset = "0xEDEF8C", VA = "0xEDEF8C")]
		public DependencyAttribute(Type dependencyType)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public sealed class DontDestroyOnLoad : MonoBehaviour
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xEDEFCC", Offset = "0xEDEFCC", VA = "0xEDEFCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xEDF024", Offset = "0xEDF024", VA = "0xEDF024")]
		public DontDestroyOnLoad()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public static class UnityExceptionUtility
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xEDF02C", Offset = "0xEDF02C", VA = "0xEDF02C")]
		public static void CheckArgumentObjectValid(UnityEngine.Object arg, string paramName)
		{
		}
	}
}
namespace Borodar.RainbowAssets.Core.Games.Reflection
{
	[Token(Token = "0x200001D")]
	public static class TypeMeta
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, Type[]> s_DiscoveredTypeCache;

		[Token(Token = "0x60000F7")]
		public static Type[] DiscoverImplementations<T>()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xEDF114", Offset = "0xEDF114", VA = "0xEDF114")]
		public static Type[] DiscoverImplementations(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xEDF3E8", Offset = "0xEDF3E8", VA = "0xEDF3E8")]
		private static IEnumerable<Type> DiscoverImplementationsInternal(Type type, Assembly assembly)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xEDF5A8", Offset = "0xEDF5A8", VA = "0xEDF5A8")]
		public static IEnumerable<Type> GetAnnotatedDependencies(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xEDF748", Offset = "0xEDF748", VA = "0xEDF748")]
		public static string NicifyName(string typeName, [Optional] string unwantedSuffix)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xEDF924", Offset = "0xEDF924", VA = "0xEDF924")]
		public static string NicifyCompoundName(string typeName, char sourceSeparator = '_', string targetSeparator = " - ", [Optional] string unwantedSuffix)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xEDFAB4", Offset = "0xEDFAB4", VA = "0xEDFAB4")]
		public static string NicifyNamespaceQualifiedName(string namespaceName, string name)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xEDF8B0", Offset = "0xEDF8B0", VA = "0xEDF8B0")]
		public static string RemoveUnwantedSuffix(string typeName, string unwantedSuffix)
		{
			return null;
		}
	}
}
namespace Borodar.RainbowAssets.Core.Games.Collections
{
	[Token(Token = "0x2000020")]
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ReorderableListAttribute : PropertyAttribute
	{
		[Token(Token = "0x17000024")]
		public string ElementsPropertyName
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xEDFDC8", Offset = "0xEDFDC8", VA = "0xEDFDC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0xEDFDD0", Offset = "0xEDFDD0", VA = "0xEDFDD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Type DroppableObjectType
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xEDFDD8", Offset = "0xEDFDD8", VA = "0xEDFDD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xEDFDE0", Offset = "0xEDFDE0", VA = "0xEDFDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public ReorderableListFlags Flags
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xEDFDE8", Offset = "0xEDFDE8", VA = "0xEDFDE8")]
			[CompilerGenerated]
			get
			{
				return default(ReorderableListFlags);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xEDFDF0", Offset = "0xEDFDF0", VA = "0xEDFDF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xEDFD70", Offset = "0xEDFD70", VA = "0xEDFD70")]
		public ReorderableListAttribute(string elementsPropertyName = "elements", [Optional] Type droppableObjectType, ReorderableListFlags flags = (ReorderableListFlags)0)
		{
		}
	}
	[Token(Token = "0x2000021")]
	[Flags]
	public enum ReorderableListFlags
	{
		[Token(Token = "0x400004D")]
		DisableReordering = 1,
		[Token(Token = "0x400004E")]
		HideAddButton = 2,
		[Token(Token = "0x400004F")]
		HideRemoveButtons = 4,
		[Token(Token = "0x4000050")]
		DisableContextMenu = 8,
		[Token(Token = "0x4000051")]
		DisableDuplicateCommand = 0x10,
		[Token(Token = "0x4000052")]
		DisableAutoFocus = 0x20,
		[Token(Token = "0x4000053")]
		ShowIndices = 0x40,
		[Token(Token = "0x4000054")]
		DisableAutoScroll = 0x100,
		[Token(Token = "0x4000055")]
		ShowSizeField = 0x200
	}
}
