using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class QuaternionConverter : JsonConverter
{
	[JsonObject(MemberSerialization.OptIn)]
	private struct _Quaternion
	{
		[JsonProperty]
		public float x;

		[JsonProperty]
		public float y;

		[JsonProperty]
		public float z;

		[JsonProperty]
		public float w;
	}

	public override bool CanConvert(Type objectType)
	{
		return typeof(Quaternion) == objectType;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		_Quaternion quaternion = serializer.Deserialize<_Quaternion>(reader);
		return new Quaternion(quaternion.x, quaternion.y, quaternion.z, quaternion.w);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		Quaternion quaternion = (Quaternion)value;
		_Quaternion quaternion2 = default(_Quaternion);
		quaternion2.x = quaternion.x;
		quaternion2.y = quaternion.y;
		quaternion2.z = quaternion.z;
		quaternion2.w = quaternion.w;
		_Quaternion quaternion3 = quaternion2;
		serializer.Serialize(writer, quaternion3);
	}
}
public class RectConverter : JsonConverter
{
	[JsonObject(MemberSerialization.OptIn)]
	private struct _Rect
	{
		[JsonProperty]
		public float x;

		[JsonProperty]
		public float y;

		[JsonProperty]
		public float w;

		[JsonProperty]
		public float h;
	}

	public override bool CanConvert(Type objectType)
	{
		return typeof(Rect) == objectType;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		_Rect rect = serializer.Deserialize<_Rect>(reader);
		return new Rect(rect.x, rect.y, rect.w, rect.h);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		Rect rect = (Rect)value;
		_Rect rect2 = default(_Rect);
		rect2.x = rect.x;
		rect2.y = rect.y;
		rect2.w = rect.width;
		rect2.h = rect.height;
		_Rect rect3 = rect2;
		serializer.Serialize(writer, rect3);
	}
}
public class Vector2Converter : JsonConverter
{
	[JsonObject(MemberSerialization.OptIn)]
	private struct _Vector2
	{
		[JsonProperty]
		public float x;

		[JsonProperty]
		public float y;
	}

	public override bool CanConvert(Type objectType)
	{
		return typeof(Vector2) == objectType;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		_Vector2 vector = serializer.Deserialize<_Vector2>(reader);
		return new Vector2(vector.x, vector.y);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		Vector2 vector = (Vector2)value;
		_Vector2 vector2 = default(_Vector2);
		vector2.x = vector.x;
		vector2.y = vector.y;
		_Vector2 vector3 = vector2;
		serializer.Serialize(writer, vector3);
	}
}
public class Vector3Converter : JsonConverter
{
	[JsonObject(MemberSerialization.OptIn)]
	private struct _Vector3
	{
		[JsonProperty]
		public float x;

		[JsonProperty]
		public float y;

		[JsonProperty]
		public float z;
	}

	public override bool CanConvert(Type objectType)
	{
		return typeof(Vector3) == objectType;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		_Vector3 vector = serializer.Deserialize<_Vector3>(reader);
		return new Vector3(vector.x, vector.y, vector.z);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		Vector3 vector = (Vector3)value;
		_Vector3 vector2 = default(_Vector3);
		vector2.x = vector.x;
		vector2.y = vector.y;
		vector2.z = vector.z;
		_Vector3 vector3 = vector2;
		serializer.Serialize(writer, vector3);
	}
}
public class Vector4Converter : JsonConverter
{
	[JsonObject(MemberSerialization.OptIn)]
	private struct _Vector4
	{
		[JsonProperty]
		public float x;

		[JsonProperty]
		public float y;

		[JsonProperty]
		public float z;

		[JsonProperty]
		public float w;
	}

	public override bool CanConvert(Type objectType)
	{
		return typeof(Vector4) == objectType;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		_Vector4 vector = serializer.Deserialize<_Vector4>(reader);
		return new Vector4(vector.x, vector.y, vector.z, vector.w);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		Vector4 vector = (Vector4)value;
		_Vector4 vector2 = default(_Vector4);
		vector2.x = vector.x;
		vector2.y = vector.y;
		vector2.z = vector.z;
		vector2.w = vector.w;
		_Vector4 vector3 = vector2;
		serializer.Serialize(writer, vector3);
	}
}
namespace Newtonsoft.Json;

public class ColorConverter : JsonConverter
{
	[JsonObject(MemberSerialization.OptIn)]
	private struct _Color
	{
		[JsonProperty]
		public float r;

		[JsonProperty]
		public float g;

		[JsonProperty]
		public float b;

		[JsonProperty]
		public float a;
	}

	public override bool CanConvert(Type objectType)
	{
		return typeof(Color) == objectType;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		_Color color = serializer.Deserialize<_Color>(reader);
		return new Color(color.r, color.g, color.b, color.a);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		Color color = (Color)value;
		_Color color2 = default(_Color);
		color2.r = color.r;
		color2.g = color.g;
		color2.b = color.b;
		color2.a = color.a;
		_Color color3 = color2;
		serializer.Serialize(writer, color3);
	}
}
