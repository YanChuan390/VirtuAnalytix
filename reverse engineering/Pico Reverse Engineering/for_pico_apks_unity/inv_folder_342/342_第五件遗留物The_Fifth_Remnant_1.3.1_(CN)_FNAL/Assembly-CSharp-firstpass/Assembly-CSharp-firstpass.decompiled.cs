using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ES3Internal;
using ES3Types;
using Il2CppDummyDll;
using UniRx.Diagnostics;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1041168", Offset = "0x1041168")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x10463F8", Offset = "0x10463F8")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x104640C", Offset = "0x104640C")]
	private readonly <type>j__TPar <type>i__Field;

	[Token(Token = "0x17000001")]
	public <assembly>j__TPar assembly
	{
		[Token(Token = "0x6000001")]
		get
		{
			return (<assembly>j__TPar)null;
		}
	}

	[Token(Token = "0x17000002")]
	public <type>j__TPar type
	{
		[Token(Token = "0x6000002")]
		get
		{
			return (<type>j__TPar)null;
		}
	}

	[Token(Token = "0x6000003")]
	[DebuggerHidden]
	public <>f__AnonymousType0(<assembly>j__TPar assembly, <type>j__TPar type)
	{
	}

	[Token(Token = "0x6000004")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1041178", Offset = "0x1041178")]
internal sealed class <>f__AnonymousType1<<google>j__TPar, <bing>j__TPar>
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1046420", Offset = "0x1046420")]
	private readonly <google>j__TPar <google>i__Field;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1046434", Offset = "0x1046434")]
	private readonly <bing>j__TPar <bing>i__Field;

	[Token(Token = "0x17000003")]
	public <google>j__TPar google
	{
		[Token(Token = "0x6000007")]
		get
		{
			return (<google>j__TPar)null;
		}
	}

	[Token(Token = "0x17000004")]
	public <bing>j__TPar bing
	{
		[Token(Token = "0x6000008")]
		get
		{
			return (<bing>j__TPar)null;
		}
	}

	[Token(Token = "0x6000009")]
	[DebuggerHidden]
	public <>f__AnonymousType1(<google>j__TPar google, <bing>j__TPar bing)
	{
	}

	[Token(Token = "0x600000A")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1041188", Offset = "0x1041188")]
public class ES3Serializable : Attribute
{
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x396E418", Offset = "0x396E418", VA = "0x396E418")]
	public ES3Serializable()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x104119C", Offset = "0x104119C")]
public class ES3NonSerializable : Attribute
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2782FC4", Offset = "0x2782FC4", VA = "0x2782FC4")]
	public ES3NonSerializable()
	{
	}
}
[Token(Token = "0x2000006")]
public class ES3AutoSave : MonoBehaviour, ISerializationCallbackReceiver
{
	[Serializable]
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10411B0", Offset = "0x10411B0")]
	private sealed class <>c
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Component> <>9__13_0;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2FDD630", Offset = "0x2FDD630", VA = "0x2FDD630")]
		public <>c()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2FDD638", Offset = "0x2FDD638", VA = "0x2FDD638")]
		internal bool <OnAfterDeserialize>b__13_0(Component c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool saveLayer;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool saveTag;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool saveName;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool saveHideFlags;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool saveActive;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool saveChildren;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	private bool isQuitting;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Component> componentsToSave;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2775A68", Offset = "0x2775A68", VA = "0x2775A68")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2775A74", Offset = "0x2775A74", VA = "0x2775A74")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2775F18", Offset = "0x2775F18", VA = "0x2775F18")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2775F24", Offset = "0x2775F24", VA = "0x2775F24")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x27760A0", Offset = "0x27760A0", VA = "0x27760A0", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x27760A4", Offset = "0x27760A4", VA = "0x27760A4", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x27761C8", Offset = "0x27761C8", VA = "0x27761C8")]
	public ES3AutoSave()
	{
	}
}
[Token(Token = "0x2000008")]
public class ES3AutoSaveMgr : MonoBehaviour
{
	[Token(Token = "0x2000009")]
	public enum LoadEvent
	{
		[Token(Token = "0x4000016")]
		None,
		[Token(Token = "0x4000017")]
		Awake,
		[Token(Token = "0x4000018")]
		Start
	}

	[Token(Token = "0x200000A")]
	public enum SaveEvent
	{
		[Token(Token = "0x400001A")]
		None,
		[Token(Token = "0x400001B")]
		OnApplicationQuit,
		[Token(Token = "0x400001C")]
		OnApplicationPause
	}

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ES3AutoSaveMgr _current;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveEvent saveEvent;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LoadEvent loadEvent;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ES3SerializableSettings settings;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HashSet<ES3AutoSave> autoSaves;

	[Token(Token = "0x17000005")]
	public static ES3AutoSaveMgr Current
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2775B70", Offset = "0x2775B70", VA = "0x2775B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public static ES3AutoSaveMgr Instance
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2776250", Offset = "0x2776250", VA = "0x2776250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x27762A8", Offset = "0x27762A8", VA = "0x27762A8")]
	public void Save()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2776548", Offset = "0x2776548", VA = "0x2776548")]
	public void Load()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x277666C", Offset = "0x277666C", VA = "0x277666C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2776680", Offset = "0x2776680", VA = "0x2776680")]
	public void Awake()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2776818", Offset = "0x2776818", VA = "0x2776818")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x277682C", Offset = "0x277682C", VA = "0x277682C")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2775E10", Offset = "0x2775E10", VA = "0x2775E10")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2775F98", Offset = "0x2775F98", VA = "0x2775F98")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2776898", Offset = "0x2776898", VA = "0x2776898")]
	public ES3AutoSaveMgr()
	{
	}
}
[Token(Token = "0x200000B")]
public static class ES3
{
	[Token(Token = "0x200000C")]
	public enum Location
	{
		[Token(Token = "0x400001E")]
		File,
		[Token(Token = "0x400001F")]
		PlayerPrefs,
		[Token(Token = "0x4000020")]
		InternalMS,
		[Token(Token = "0x4000021")]
		Resources,
		[Token(Token = "0x4000022")]
		Cache
	}

	[Token(Token = "0x200000D")]
	public enum Directory
	{
		[Token(Token = "0x4000024")]
		PersistentDataPath,
		[Token(Token = "0x4000025")]
		DataPath
	}

	[Token(Token = "0x200000E")]
	public enum EncryptionType
	{
		[Token(Token = "0x4000027")]
		None,
		[Token(Token = "0x4000028")]
		AES
	}

	[Token(Token = "0x200000F")]
	public enum CompressionType
	{
		[Token(Token = "0x400002A")]
		None,
		[Token(Token = "0x400002B")]
		Gzip
	}

	[Token(Token = "0x2000010")]
	public enum Format
	{
		[Token(Token = "0x400002D")]
		JSON
	}

	[Token(Token = "0x2000011")]
	public enum ReferenceMode
	{
		[Token(Token = "0x400002F")]
		ByRef,
		[Token(Token = "0x4000030")]
		ByValue,
		[Token(Token = "0x4000031")]
		ByRefAndValue
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x276BD50", Offset = "0x276BD50", VA = "0x276BD50")]
	public static void Save(string key, object value)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x276BDE0", Offset = "0x276BDE0", VA = "0x276BDE0")]
	public static void Save(string key, object value, string filePath)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x276BE74", Offset = "0x276BE74", VA = "0x276BE74")]
	public static void Save(string key, object value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x276BF14", Offset = "0x276BF14", VA = "0x276BF14")]
	public static void Save(string key, object value, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000029")]
	public static void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x600002A")]
	public static void Save<T>(string key, T value, string filePath)
	{
	}

	[Token(Token = "0x600002B")]
	public static void Save<T>(string key, T value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002C")]
	public static void Save<T>(string key, T value, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x276BF78", Offset = "0x276BF78", VA = "0x276BF78")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x276C1DC", Offset = "0x276C1DC", VA = "0x276C1DC")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x276C250", Offset = "0x276C250", VA = "0x276C250")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x276BFE0", Offset = "0x276BFE0", VA = "0x276BFE0")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x276CCA4", Offset = "0x276CCA4", VA = "0x276CCA4")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x276CD50", Offset = "0x276CD50", VA = "0x276CD50")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x276CDC4", Offset = "0x276CDC4", VA = "0x276CDC4")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x276CD0C", Offset = "0x276CD0C", VA = "0x276CD0C")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x276CE3C", Offset = "0x276CE3C", VA = "0x276CE3C")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x276D0A8", Offset = "0x276D0A8", VA = "0x276D0A8")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x276CEA4", Offset = "0x276CEA4", VA = "0x276CEA4")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x276D1A0", Offset = "0x276D1A0", VA = "0x276D1A0")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x276D430", Offset = "0x276D430", VA = "0x276D430")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x276D208", Offset = "0x276D208", VA = "0x276D208")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x276D4A8", Offset = "0x276D4A8", VA = "0x276D4A8")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x276D52C", Offset = "0x276D52C", VA = "0x276D52C")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x276D520", Offset = "0x276D520", VA = "0x276D520")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x276D748", Offset = "0x276D748", VA = "0x276D748")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x276D7C0", Offset = "0x276D7C0", VA = "0x276D7C0")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x276D5A8", Offset = "0x276D5A8", VA = "0x276D5A8")]
	public static void SaveImage(Texture2D texture, int quality, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x276D8AC", Offset = "0x276D8AC", VA = "0x276D8AC")]
	public static object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x276D92C", Offset = "0x276D92C", VA = "0x276D92C")]
	public static object Load(string key, string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x276D9B8", Offset = "0x276D9B8", VA = "0x276D9B8")]
	public static object Load(string key, string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x276DA48", Offset = "0x276DA48", VA = "0x276DA48")]
	public static object Load(string key, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000046")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x6000047")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000048")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000049")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600004A")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600004B")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600004C")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600004D")]
	public static void LoadInto<T>(string key, object obj) where T : class
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x276DAA4", Offset = "0x276DAA4", VA = "0x276DAA4")]
	public static void LoadInto(string key, string filePath, object obj)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x276DB38", Offset = "0x276DB38", VA = "0x276DB38")]
	public static void LoadInto(string key, string filePath, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x276DBD8", Offset = "0x276DBD8", VA = "0x276DBD8")]
	public static void LoadInto(string key, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000051")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000052")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x6000053")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000054")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x276DC3C", Offset = "0x276DC3C", VA = "0x276DC3C")]
	public static string LoadString(string key, string defaultValue, [Optional] string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x276DCD4", Offset = "0x276DCD4", VA = "0x276DCD4")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x276E1F8", Offset = "0x276E1F8", VA = "0x276E1F8")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x276E25C", Offset = "0x276E25C", VA = "0x276E25C")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x276DD34", Offset = "0x276DD34", VA = "0x276DD34")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x276E36C", Offset = "0x276E36C", VA = "0x276E36C")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x276E418", Offset = "0x276E418", VA = "0x276E418")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x276E47C", Offset = "0x276E47C", VA = "0x276E47C")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x276E3CC", Offset = "0x276E3CC", VA = "0x276E3CC")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x276E4EC", Offset = "0x276E4EC", VA = "0x276E4EC")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x276E568", Offset = "0x276E568", VA = "0x276E568")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x276E554", Offset = "0x276E554", VA = "0x276E554")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x276E5DC", Offset = "0x276E5DC", VA = "0x276E5DC")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x276E650", Offset = "0x276E650", VA = "0x276E650")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x276E6C8", Offset = "0x276E6C8", VA = "0x276E6C8")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	public static byte[] Serialize<T>(T value, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	public static T Deserialize<T>(byte[] bytes, [Optional] ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x276EAC4", Offset = "0x276EAC4", VA = "0x276EAC4")]
	internal static object Deserialize(ES3Type type, byte[] bytes, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	public static void DeserializeInto<T>(byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000068")]
	public static void DeserializeInto<T>(ES3Type type, byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x276EEBC", Offset = "0x276EEBC", VA = "0x276EEBC")]
	public static byte[] EncryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x276EFB8", Offset = "0x276EFB8", VA = "0x276EFB8")]
	public static byte[] DecryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x276F0B4", Offset = "0x276F0B4", VA = "0x276F0B4")]
	public static string EncryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x276F178", Offset = "0x276F178", VA = "0x276F178")]
	public static string DecryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x276F23C", Offset = "0x276F23C", VA = "0x276F23C")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x276F410", Offset = "0x276F410", VA = "0x276F410")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x276F474", Offset = "0x276F474", VA = "0x276F474")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x276F29C", Offset = "0x276F29C", VA = "0x276F29C")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x276F5F4", Offset = "0x276F5F4", VA = "0x276F5F4")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x276FAC0", Offset = "0x276FAC0", VA = "0x276FAC0")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x276F684", Offset = "0x276F684", VA = "0x276F684")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x276FF58", Offset = "0x276FF58", VA = "0x276FF58")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2770440", Offset = "0x2770440", VA = "0x2770440")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x276FFE8", Offset = "0x276FFE8", VA = "0x276FFE8")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x27704E8", Offset = "0x27704E8", VA = "0x27704E8")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2770844", Offset = "0x2770844", VA = "0x2770844")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2770578", Offset = "0x2770578", VA = "0x2770578")]
	public static void CopyDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2770CE4", Offset = "0x2770CE4", VA = "0x2770CE4")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2770F2C", Offset = "0x2770F2C", VA = "0x2770F2C")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2770D74", Offset = "0x2770D74", VA = "0x2770D74")]
	public static void RenameDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2771060", Offset = "0x2771060", VA = "0x2771060")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2771200", Offset = "0x2771200", VA = "0x2771200")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x27710C4", Offset = "0x27710C4", VA = "0x27710C4")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2771270", Offset = "0x2771270", VA = "0x2771270")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x27714F8", Offset = "0x27714F8", VA = "0x27714F8")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x277156C", Offset = "0x277156C", VA = "0x277156C")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x27712D8", Offset = "0x27712D8", VA = "0x27712D8")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2771834", Offset = "0x2771834", VA = "0x2771834")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2771A5C", Offset = "0x2771A5C", VA = "0x2771A5C")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2771AD0", Offset = "0x2771AD0", VA = "0x2771AD0")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x277189C", Offset = "0x277189C", VA = "0x277189C")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2771CAC", Offset = "0x2771CAC", VA = "0x2771CAC")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2771D0C", Offset = "0x2771D0C", VA = "0x2771D0C")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2771D70", Offset = "0x2771D70", VA = "0x2771D70")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x27716A0", Offset = "0x27716A0", VA = "0x27716A0")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2771E70", Offset = "0x2771E70", VA = "0x2771E70")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2771ED4", Offset = "0x2771ED4", VA = "0x2771ED4")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x27708E4", Offset = "0x27708E4", VA = "0x27708E4")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2771F44", Offset = "0x2771F44", VA = "0x2771F44")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x27723F4", Offset = "0x27723F4", VA = "0x27723F4")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2772458", Offset = "0x2772458", VA = "0x2772458")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2771FA4", Offset = "0x2771FA4", VA = "0x2771FA4")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2772630", Offset = "0x2772630", VA = "0x2772630")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x27726C8", Offset = "0x27726C8", VA = "0x27726C8")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x277272C", Offset = "0x277272C", VA = "0x277272C")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2770A30", Offset = "0x2770A30", VA = "0x2770A30")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x277294C", Offset = "0x277294C", VA = "0x277294C")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x27729AC", Offset = "0x27729AC", VA = "0x27729AC")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2772A10", Offset = "0x2772A10", VA = "0x2772A10")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2770C0C", Offset = "0x2770C0C", VA = "0x2770C0C")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2772BE8", Offset = "0x2772BE8", VA = "0x2772BE8")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2772CEC", Offset = "0x2772CEC", VA = "0x2772CEC")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2772D50", Offset = "0x2772D50", VA = "0x2772D50")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2772C48", Offset = "0x2772C48", VA = "0x2772C48")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2772DC0", Offset = "0x2772DC0", VA = "0x2772DC0")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2772EE4", Offset = "0x2772EE4", VA = "0x2772EE4")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2772E24", Offset = "0x2772E24", VA = "0x2772E24")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2772F54", Offset = "0x2772F54", VA = "0x2772F54")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2773164", Offset = "0x2773164", VA = "0x2773164")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x27731C8", Offset = "0x27731C8", VA = "0x27731C8")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2772FB4", Offset = "0x2772FB4", VA = "0x2772FB4")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2773438", Offset = "0x2773438", VA = "0x2773438")]
	public static void StoreCachedFile()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x27736EC", Offset = "0x27736EC", VA = "0x27736EC")]
	public static void StoreCachedFile(string filePath)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x27737B0", Offset = "0x27737B0", VA = "0x27737B0")]
	public static void StoreCachedFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2773750", Offset = "0x2773750", VA = "0x2773750")]
	public static void StoreCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2773820", Offset = "0x2773820", VA = "0x2773820")]
	public static void CacheFile()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x27738E0", Offset = "0x27738E0", VA = "0x27738E0")]
	public static void CacheFile(string filePath)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2773944", Offset = "0x2773944", VA = "0x2773944")]
	public static void CacheFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2773880", Offset = "0x2773880", VA = "0x2773880")]
	public static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2773B74", Offset = "0x2773B74", VA = "0x2773B74")]
	public static void Init()
	{
	}
}
[Token(Token = "0x2000012")]
public class ES3File
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046448", Offset = "0x1046448")]
	internal static Dictionary<string, ES3File> cachedFiles;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, ES3Data> cache;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool syncWithFile;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DateTime timestamp;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x277C1D8", Offset = "0x277C1D8", VA = "0x277C1D8")]
	public ES3File()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x277C6E4", Offset = "0x277C6E4", VA = "0x277C6E4")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x277C75C", Offset = "0x277C75C", VA = "0x277C75C")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x27772FC", Offset = "0x27772FC", VA = "0x27772FC")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x277C7D8", Offset = "0x277C7D8", VA = "0x277C7D8")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x277C850", Offset = "0x277C850", VA = "0x277C850")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x277C8CC", Offset = "0x277C8CC", VA = "0x277C8CC")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x277C244", Offset = "0x277C244", VA = "0x277C244")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x277C954", Offset = "0x277C954", VA = "0x277C954")]
	public ES3File(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x277CA64", Offset = "0x277CA64", VA = "0x277CA64")]
	public void Sync()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x277CE34", Offset = "0x277CE34", VA = "0x277CE34")]
	public void Sync(string filePath, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x277CA6C", Offset = "0x277CA6C", VA = "0x277CA6C")]
	public void Sync([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x277CEAC", Offset = "0x277CEAC", VA = "0x277CEAC")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x277CF00", Offset = "0x277CF00", VA = "0x277CF00")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	public void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x276C3E4", Offset = "0x276C3E4", VA = "0x276C3E4")]
	public void SaveRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x276D120", Offset = "0x276D120", VA = "0x276D120")]
	public void AppendRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x277D0A0", Offset = "0x277D0A0", VA = "0x277D0A0")]
	public object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x277D0FC", Offset = "0x277D0FC", VA = "0x277D0FC")]
	public object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60000C3")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60000C4")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x276E2CC", Offset = "0x276E2CC", VA = "0x276E2CC")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x277D160", Offset = "0x277D160", VA = "0x277D160")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x277836C", Offset = "0x277836C", VA = "0x277836C")]
	internal byte[] GetBytes([Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x277D20C", Offset = "0x277D20C", VA = "0x277D20C")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x277D270", Offset = "0x277D270", VA = "0x277D270")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x277D2D4", Offset = "0x277D2D4", VA = "0x277D2D4")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x277D400", Offset = "0x277D400", VA = "0x277D400")]
	public Type GetKeyType(string key)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x276C2C8", Offset = "0x276C2C8", VA = "0x276C2C8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046628", Offset = "0x1046628")]
	internal static ES3File GetOrCreateCachedFile(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x27739B4", Offset = "0x27739B4", VA = "0x27739B4")]
	internal static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2773494", Offset = "0x2773494", VA = "0x2773494")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x104663C", Offset = "0x104663C")]
	internal static void Store([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x276F564", Offset = "0x276F564", VA = "0x276F564")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046650", Offset = "0x1046650")]
	internal static void RemoveCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x276FB70", Offset = "0x276FB70", VA = "0x276FB70")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046664", Offset = "0x1046664")]
	internal static void CopyCachedFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x27715E4", Offset = "0x27715E4", VA = "0x27715E4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046678", Offset = "0x1046678")]
	internal static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2771B48", Offset = "0x2771B48", VA = "0x2771B48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x104668C", Offset = "0x104668C")]
	internal static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2771DE0", Offset = "0x2771DE0", VA = "0x2771DE0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10466A0", Offset = "0x10466A0")]
	internal static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x27724C8", Offset = "0x27724C8", VA = "0x27724C8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10466B4", Offset = "0x10466B4")]
	internal static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x277279C", Offset = "0x277279C", VA = "0x277279C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10466C8", Offset = "0x10466C8")]
	internal static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x277330C", Offset = "0x277330C", VA = "0x277330C")]
	internal static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}
}
[Token(Token = "0x2000013")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x277E7CC", Offset = "0x277E7CC", VA = "0x277E7CC")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000014")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase
{
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x27858B0", Offset = "0x27858B0", VA = "0x27858B0")]
	public ES3ReferenceMgr()
	{
	}
}
[Token(Token = "0x2000015")]
public class ES3Spreadsheet
{
	[Token(Token = "0x2000016")]
	protected struct Index
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int col;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int row;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2FE01B8", Offset = "0x2FE01B8", VA = "0x2FE01B8")]
		public Index(int col, int row)
		{
		}
	}

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int cols;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int rows;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Index, string> cells;

	[Token(Token = "0x400003A")]
	private const string QUOTE = "\"";

	[Token(Token = "0x400003B")]
	private const char QUOTE_CHAR = '"';

	[Token(Token = "0x400003C")]
	private const char COMMA_CHAR = ',';

	[Token(Token = "0x400003D")]
	private const char NEWLINE_CHAR = '\n';

	[Token(Token = "0x400003E")]
	private const string ESCAPED_QUOTE = "\"\"";

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static char[] CHARS_TO_ESCAPE;

	[Token(Token = "0x17000007")]
	public int ColumnCount
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x396F700", Offset = "0x396F700", VA = "0x396F700")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public int RowCount
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x396F708", Offset = "0x396F708", VA = "0x396F708")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000DC")]
	public void SetCell<T>(int col, int row, T value)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x396F710", Offset = "0x396F710", VA = "0x396F710")]
	private void SetCellString(int col, int row, string value)
	{
	}

	[Token(Token = "0x60000DE")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x396F7D0", Offset = "0x396F7D0", VA = "0x396F7D0")]
	internal object GetCell(Type type, int col, int row)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x396FE60", Offset = "0x396FE60", VA = "0x396FE60")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x396FF10", Offset = "0x396FF10", VA = "0x396FF10")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x396FEE0", Offset = "0x396FEE0", VA = "0x396FEE0")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x3970684", Offset = "0x3970684", VA = "0x3970684")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x3970758", Offset = "0x3970758", VA = "0x3970758")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x39703B0", Offset = "0x39703B0", VA = "0x39703B0")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x39707F8", Offset = "0x39707F8", VA = "0x39707F8")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x3970BC4", Offset = "0x3970BC4", VA = "0x3970BC4")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x3970C3C", Offset = "0x3970C3C", VA = "0x3970C3C")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x3970C44", Offset = "0x3970C44", VA = "0x3970C44")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x3970CC0", Offset = "0x3970CC0", VA = "0x3970CC0")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x3970870", Offset = "0x3970870", VA = "0x3970870")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x3970EF8", Offset = "0x3970EF8", VA = "0x3970EF8")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x3971014", Offset = "0x3971014", VA = "0x3971014")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x3970D44", Offset = "0x3970D44", VA = "0x3970D44")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x39710F8", Offset = "0x39710F8", VA = "0x39710F8")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x2000017")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10411C0", Offset = "0x10411C0")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10411D4", Offset = "0x10411D4")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderPropertyEnumerator <>4__this;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000135")]
				[Address(RVA = "0x2FE2CCC", Offset = "0x2FE2CCC", VA = "0x2FE2CCC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000137")]
				[Address(RVA = "0x2FE2D14", Offset = "0x2FE2D14", VA = "0x2FE2D14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2FDF830", Offset = "0x2FDF830", VA = "0x2FDF830")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2FE2C3C", Offset = "0x2FE2C3C", VA = "0x2FE2C3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2FE2C40", Offset = "0x2FE2C40", VA = "0x2FE2C40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2FE2CD4", Offset = "0x2FE2CD4", VA = "0x2FE2CD4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2FDF798", Offset = "0x2FDF798", VA = "0x2FDF798")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2FDF7C4", Offset = "0x2FDF7C4", VA = "0x2FDF7C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x104677C", Offset = "0x104677C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10411E4", Offset = "0x10411E4")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10411F8", Offset = "0x10411F8")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderRawEnumerator <>4__this;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600013D")]
				[Address(RVA = "0x2FE2EE4", Offset = "0x2FE2EE4", VA = "0x2FE2EE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013F")]
				[Address(RVA = "0x2FE2F2C", Offset = "0x2FE2F2C", VA = "0x2FE2F2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2FDF888", Offset = "0x2FDF888", VA = "0x2FDF888")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2FE2D1C", Offset = "0x2FE2D1C", VA = "0x2FE2D1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2FE2D20", Offset = "0x2FE2D20", VA = "0x2FE2D20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2FE2EEC", Offset = "0x2FE2EEC", VA = "0x2FE2EEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2FDF85C", Offset = "0x2FDF85C", VA = "0x2FDF85C")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2FD8978", Offset = "0x2FD8978", VA = "0x2FD8978")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x104682C", Offset = "0x104682C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected int serializationDepth;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal string overridePropertiesName;

	[Token(Token = "0x17000009")]
	public virtual ES3ReaderPropertyEnumerator Properties
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2784F88", Offset = "0x2784F88", VA = "0x2784F88", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2784FE8", Offset = "0x2784FE8", VA = "0x2784FE8", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000F2")]
	internal abstract int Read_int();

	[Token(Token = "0x60000F3")]
	internal abstract float Read_float();

	[Token(Token = "0x60000F4")]
	internal abstract bool Read_bool();

	[Token(Token = "0x60000F5")]
	internal abstract char Read_char();

	[Token(Token = "0x60000F6")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x60000F7")]
	internal abstract double Read_double();

	[Token(Token = "0x60000F8")]
	internal abstract long Read_long();

	[Token(Token = "0x60000F9")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x60000FA")]
	internal abstract byte Read_byte();

	[Token(Token = "0x60000FB")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x60000FC")]
	internal abstract short Read_short();

	[Token(Token = "0x60000FD")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x60000FE")]
	internal abstract uint Read_uint();

	[Token(Token = "0x60000FF")]
	internal abstract string Read_string();

	[Token(Token = "0x6000100")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x6000101")]
	internal abstract long Read_ref();

	[Token(Token = "0x6000102")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10466DC", Offset = "0x10466DC")]
	public abstract string ReadPropertyName();

	[Token(Token = "0x6000103")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x6000104")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x6000105")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x6000106")]
	public abstract void Dispose();

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2784EC4", Offset = "0x2784EC4", VA = "0x2784EC4", Slot = "26")]
	internal virtual bool Goto(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x277FBF0", Offset = "0x277FBF0", VA = "0x277FBF0", Slot = "27")]
	internal virtual bool StartReadObject()
	{
		return default(bool);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x277FF14", Offset = "0x277FF14", VA = "0x277FF14", Slot = "28")]
	internal virtual void EndReadObject()
	{
	}

	[Token(Token = "0x600010A")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x600010B")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x600010C")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x600010D")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x600010E")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x600010F")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x6000110")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x6000111")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x6000112")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x6000113")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x277E934", Offset = "0x277E934", VA = "0x277E934")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2785048", Offset = "0x2785048", VA = "0x2785048", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10466F0", Offset = "0x10466F0")]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x6000118")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000119")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x600011A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046704", Offset = "0x1046704")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600011B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046718", Offset = "0x1046718")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x278505C", Offset = "0x278505C", VA = "0x278505C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x104672C", Offset = "0x104672C")]
	public long ReadRefProperty()
	{
		return default(long);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2785098", Offset = "0x2785098", VA = "0x2785098")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2785178", Offset = "0x2785178", VA = "0x2785178")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x27853A0", Offset = "0x27853A0", VA = "0x27853A0")]
	public void SetPrivateField(string name, object value, object objectContainingField)
	{
	}

	[Token(Token = "0x6000120")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000121")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000122")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000123")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000124")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000125")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046740", Offset = "0x1046740")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000126")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046754", Offset = "0x1046754")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000127")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046768", Offset = "0x1046768")]
	internal Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x27855C8", Offset = "0x27855C8", VA = "0x27855C8")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2785628", Offset = "0x2785628", VA = "0x2785628")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x278568C", Offset = "0x278568C", VA = "0x278568C")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x2771C10", Offset = "0x2771C10", VA = "0x2771C10")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x27856FC", Offset = "0x27856FC", VA = "0x27856FC")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x277CFD0", Offset = "0x277CFD0", VA = "0x277CFD0")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x2785764", Offset = "0x2785764", VA = "0x2785764")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x276EE30", Offset = "0x276EE30", VA = "0x276EE30")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public class ES3XMLReader
{
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x2FD8ADC", Offset = "0x2FD8ADC", VA = "0x2FD8ADC")]
	public ES3XMLReader()
	{
	}
}
[Token(Token = "0x200001D")]
public class ES3Defaults : ScriptableObject
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ES3SerializableSettings settings;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool addMgrToSceneAutomatically;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool autoUpdateReferences;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool addAllPrefabsToManager;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool logDebugInfo;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool logWarnings;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool logErrors;

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x277B474", Offset = "0x277B474", VA = "0x277B474")]
	public ES3Defaults()
	{
	}
}
[Token(Token = "0x200001E")]
public class ES3Settings : ICloneable
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES3Settings _defaults;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES3Defaults _defaultSettingsScriptableObject;

	[Token(Token = "0x4000056")]
	private const string defaultSettingsPath = "ES3/ES3Defaults";

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ES3Settings _unencryptedUncompressedSettings;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string[] resourcesExtensions;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private ES3.Location _location;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ES3.EncryptionType encryptionType;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ES3.CompressionType compressionType;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string encryptionPassword;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES3.Directory directory;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ES3.Format format;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool prettyPrint;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bufferSize;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool saveChildren;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x104647C", Offset = "0x104647C")]
	public bool typeChecking;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046490", Offset = "0x1046490")]
	public bool safeReflection;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10464A4", Offset = "0x10464A4")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10464B8", Offset = "0x10464B8")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10464CC", Offset = "0x10464CC")]
	public int serializationDepthLimit;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10464E0", Offset = "0x10464E0")]
	public string[] assemblyNames;

	[Token(Token = "0x1700000F")]
	public static ES3Defaults defaultSettingsScriptableObject
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x396E7D0", Offset = "0x396E7D0", VA = "0x396E7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public static ES3Settings defaultSettings
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x396E904", Offset = "0x396E904", VA = "0x396E904")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000011")]
	internal static ES3Settings unencryptedUncompressedSettings
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x396EA24", Offset = "0x396EA24", VA = "0x396EA24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	public ES3.Location location
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x396ED98", Offset = "0x396ED98", VA = "0x396ED98")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x396EDE8", Offset = "0x396EDE8", VA = "0x396EDE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public string FullPath
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x396EDF0", Offset = "0x396EDF0", VA = "0x396EDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x396F224", Offset = "0x396F224", VA = "0x396F224")]
	public ES3Settings([Optional] string path, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x396F304", Offset = "0x396F304", VA = "0x396F304")]
	public ES3Settings(string path, params Enum[] enums)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x396EBCC", Offset = "0x396EBCC", VA = "0x396EBCC")]
	public ES3Settings(params Enum[] enums)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x396F334", Offset = "0x396F334", VA = "0x396F334")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x396F370", Offset = "0x396F370", VA = "0x396F370")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x396E484", Offset = "0x396E484", VA = "0x396E484")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10468DC", Offset = "0x10468DC")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x396F180", Offset = "0x396F180", VA = "0x396F180")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x396F3AC", Offset = "0x396F3AC", VA = "0x396F3AC", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10468F0", Offset = "0x10468F0")]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x396F270", Offset = "0x396F270", VA = "0x396F270")]
	private void CopyInto(ES3Settings newSettings)
	{
	}
}
[Serializable]
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1041208", Offset = "0x1041208")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x396E420", Offset = "0x396E420", VA = "0x396E420")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x396E670", Offset = "0x396E670", VA = "0x396E670")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x396E6E0", Offset = "0x396E6E0", VA = "0x396E6E0")]
	public ES3SerializableSettings(string path)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x396E758", Offset = "0x396E758", VA = "0x396E758")]
	public ES3SerializableSettings(string path, ES3.Location location)
	{
	}
}
[Token(Token = "0x2000020")]
public class ES3Ref
{
	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long id;

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x2785804", Offset = "0x2785804", VA = "0x2785804")]
	public ES3Ref(long id)
	{
	}
}
[Token(Token = "0x2000021")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104121C", Offset = "0x104121C")]
	private sealed class <Sync>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x2FDF35C", Offset = "0x2FDF35C", VA = "0x2FDF35C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x2FDF3A4", Offset = "0x2FDF3A4", VA = "0x2FDF3A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2FDF200", Offset = "0x2FDF200", VA = "0x2FDF200")]
		[DebuggerHidden]
		public <Sync>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2FDF22C", Offset = "0x2FDF22C", VA = "0x2FDF22C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2FDF230", Offset = "0x2FDF230", VA = "0x2FDF230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2FDF364", Offset = "0x2FDF364", VA = "0x2FDF364", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104122C", Offset = "0x104122C")]
	private sealed class <UploadFile>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public long fileTimestamp;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] bytes;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x2FDF748", Offset = "0x2FDF748", VA = "0x2FDF748", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x2FDF790", Offset = "0x2FDF790", VA = "0x2FDF790", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2FDF3AC", Offset = "0x2FDF3AC", VA = "0x2FDF3AC")]
		[DebuggerHidden]
		public <UploadFile>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2FDF3D8", Offset = "0x2FDF3D8", VA = "0x2FDF3D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2FDF4B0", Offset = "0x2FDF4B0", VA = "0x2FDF4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2FDF3F4", Offset = "0x2FDF3F4", VA = "0x2FDF3F4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2FDF750", Offset = "0x2FDF750", VA = "0x2FDF750", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104123C", Offset = "0x104123C")]
	private sealed class <DownloadFile>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3File es3File;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x2FDDECC", Offset = "0x2FDDECC", VA = "0x2FDDECC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x2FDDF14", Offset = "0x2FDDF14", VA = "0x2FDDF14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2FDDA88", Offset = "0x2FDDA88", VA = "0x2FDDA88")]
		[DebuggerHidden]
		public <DownloadFile>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2FDDAB4", Offset = "0x2FDDAB4", VA = "0x2FDDAB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2FDDB8C", Offset = "0x2FDDB8C", VA = "0x2FDDB8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2FDDAD0", Offset = "0x2FDDAD0", VA = "0x2FDDAD0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2FDDED4", Offset = "0x2FDDED4", VA = "0x2FDDED4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104124C", Offset = "0x104124C")]
	private sealed class <DownloadFile>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x2FDE318", Offset = "0x2FDE318", VA = "0x2FDE318", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x2FDE360", Offset = "0x2FDE360", VA = "0x2FDE360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2FDDF1C", Offset = "0x2FDDF1C", VA = "0x2FDDF1C")]
		[DebuggerHidden]
		public <DownloadFile>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2FDDF48", Offset = "0x2FDDF48", VA = "0x2FDDF48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2FDE020", Offset = "0x2FDE020", VA = "0x2FDE020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2FDDF64", Offset = "0x2FDDF64", VA = "0x2FDDF64")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2FDE320", Offset = "0x2FDE320", VA = "0x2FDE320", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104125C", Offset = "0x104125C")]
	private sealed class <DeleteFile>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2FDDA38", Offset = "0x2FDDA38", VA = "0x2FDDA38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2FDDA80", Offset = "0x2FDDA80", VA = "0x2FDDA80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2FDD730", Offset = "0x2FDD730", VA = "0x2FDD730")]
		[DebuggerHidden]
		public <DeleteFile>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2FDD75C", Offset = "0x2FDD75C", VA = "0x2FDD75C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2FDD834", Offset = "0x2FDD834", VA = "0x2FDD834", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2FDD778", Offset = "0x2FDD778", VA = "0x2FDD778")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2FDDA40", Offset = "0x2FDDA40", VA = "0x2FDDA40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104126C", Offset = "0x104126C")]
	private sealed class <RenameFile>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Settings newSettings;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2FDEDD8", Offset = "0x2FDEDD8", VA = "0x2FDEDD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2FDEE20", Offset = "0x2FDEE20", VA = "0x2FDEE20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2FDEA94", Offset = "0x2FDEA94", VA = "0x2FDEA94")]
		[DebuggerHidden]
		public <RenameFile>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2FDEAC0", Offset = "0x2FDEAC0", VA = "0x2FDEAC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2FDEB98", Offset = "0x2FDEB98", VA = "0x2FDEB98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2FDEADC", Offset = "0x2FDEADC", VA = "0x2FDEADC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2FDEDE0", Offset = "0x2FDEDE0", VA = "0x2FDEDE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104127C", Offset = "0x104127C")]
	private sealed class <DownloadFilenames>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x2FDE6B0", Offset = "0x2FDE6B0", VA = "0x2FDE6B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2FDE6F8", Offset = "0x2FDE6F8", VA = "0x2FDE6F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2FDE368", Offset = "0x2FDE368", VA = "0x2FDE368")]
		[DebuggerHidden]
		public <DownloadFilenames>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2FDE394", Offset = "0x2FDE394", VA = "0x2FDE394", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2FDE46C", Offset = "0x2FDE46C", VA = "0x2FDE46C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2FDE3B0", Offset = "0x2FDE3B0", VA = "0x2FDE3B0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2FDE6B8", Offset = "0x2FDE6B8", VA = "0x2FDE6B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104128C", Offset = "0x104128C")]
	private sealed class <SearchFilenames>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string searchPattern;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2FDF1B0", Offset = "0x2FDF1B0", VA = "0x2FDF1B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x2FDF1F8", Offset = "0x2FDF1F8", VA = "0x2FDF1F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2FDEE28", Offset = "0x2FDEE28", VA = "0x2FDEE28")]
		[DebuggerHidden]
		public <SearchFilenames>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2FDEE54", Offset = "0x2FDEE54", VA = "0x2FDEE54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2FDEF2C", Offset = "0x2FDEF2C", VA = "0x2FDEF2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2FDEE70", Offset = "0x2FDEE70", VA = "0x2FDEE70")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2FDF1B8", Offset = "0x2FDF1B8", VA = "0x2FDF1B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104129C", Offset = "0x104129C")]
	private sealed class <DownloadTimestamp>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x2FDEA44", Offset = "0x2FDEA44", VA = "0x2FDEA44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x2FDEA8C", Offset = "0x2FDEA8C", VA = "0x2FDEA8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2FDE700", Offset = "0x2FDE700", VA = "0x2FDE700")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2FDE72C", Offset = "0x2FDE72C", VA = "0x2FDE72C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2FDE804", Offset = "0x2FDE804", VA = "0x2FDE804", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2FDE748", Offset = "0x2FDE748", VA = "0x2FDE748")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2FDEA4C", Offset = "0x2FDEA4C", VA = "0x2FDEA4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int timeout;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Encoding encoding;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private byte[] _data;

	[Token(Token = "0x17000014")]
	public byte[] data
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x27776E4", Offset = "0x27776E4", VA = "0x27776E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public string text
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x27776EC", Offset = "0x27776EC", VA = "0x27776EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public string[] filenames
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2777720", Offset = "0x2777720", VA = "0x2777720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000017")]
	public DateTime timestamp
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x27777EC", Offset = "0x27777EC", VA = "0x27777EC")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2777638", Offset = "0x2777638", VA = "0x2777638")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x2777688", Offset = "0x2777688", VA = "0x2777688")]
	public ES3Cloud(string url, string apiKey, int timeout)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2777970", Offset = "0x2777970", VA = "0x2777970")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x2777A80", Offset = "0x2777A80", VA = "0x2777A80")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2777B10", Offset = "0x2777B10", VA = "0x2777B10")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x2777BA4", Offset = "0x2777BA4", VA = "0x2777BA4")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x2777C30", Offset = "0x2777C30", VA = "0x2777C30")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x2777CC4", Offset = "0x2777CC4", VA = "0x2777CC4")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x2777D64", Offset = "0x2777D64", VA = "0x2777D64")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x27779F4", Offset = "0x27779F4", VA = "0x27779F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1046904", Offset = "0x1046904")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x2777DF4", Offset = "0x2777DF4", VA = "0x2777DF4")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x2777EDC", Offset = "0x2777EDC", VA = "0x2777EDC")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x2777F7C", Offset = "0x2777F7C", VA = "0x2777F7C")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x2778020", Offset = "0x2778020", VA = "0x2778020")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x27780B8", Offset = "0x27780B8", VA = "0x27780B8")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x277815C", Offset = "0x277815C", VA = "0x277815C")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x277820C", Offset = "0x277820C", VA = "0x277820C")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x27782A8", Offset = "0x27782A8", VA = "0x27782A8")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x2778A1C", Offset = "0x2778A1C", VA = "0x2778A1C")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x2778AE4", Offset = "0x2778AE4", VA = "0x2778AE4")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x2777E90", Offset = "0x2777E90", VA = "0x2777E90")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x2778BA4", Offset = "0x2778BA4", VA = "0x2778BA4")]
	public IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x277897C", Offset = "0x277897C", VA = "0x277897C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1046964", Offset = "0x1046964")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password, long fileTimestamp)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2778C08", Offset = "0x2778C08", VA = "0x2778C08")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x2778D24", Offset = "0x2778D24", VA = "0x2778D24")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2778DB8", Offset = "0x2778DB8", VA = "0x2778DB8")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2778E50", Offset = "0x2778E50", VA = "0x2778E50")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x2778EE0", Offset = "0x2778EE0", VA = "0x2778EE0")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x2778F78", Offset = "0x2778F78", VA = "0x2778F78")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x277901C", Offset = "0x277901C", VA = "0x277901C")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x27790B0", Offset = "0x27790B0", VA = "0x27790B0")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x27791A8", Offset = "0x27791A8", VA = "0x27791A8")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x2779210", Offset = "0x2779210", VA = "0x2779210")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2779114", Offset = "0x2779114", VA = "0x2779114")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10469C4", Offset = "0x10469C4")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2778C90", Offset = "0x2778C90", VA = "0x2778C90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1046A24", Offset = "0x1046A24")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x2779218", Offset = "0x2779218", VA = "0x2779218")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x2779328", Offset = "0x2779328", VA = "0x2779328")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x27793B8", Offset = "0x27793B8", VA = "0x27793B8")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x277944C", Offset = "0x277944C", VA = "0x277944C")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x27794D8", Offset = "0x27794D8", VA = "0x27794D8")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x277956C", Offset = "0x277956C", VA = "0x277956C")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x277960C", Offset = "0x277960C", VA = "0x277960C")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x277929C", Offset = "0x277929C", VA = "0x277929C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1046A84", Offset = "0x1046A84")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x277969C", Offset = "0x277969C", VA = "0x277969C")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x27797EC", Offset = "0x27797EC", VA = "0x27797EC")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x27798AC", Offset = "0x27798AC", VA = "0x27798AC")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x2779964", Offset = "0x2779964", VA = "0x2779964")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x2779A24", Offset = "0x2779A24", VA = "0x2779A24")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x2779AF0", Offset = "0x2779AF0", VA = "0x2779AF0")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x2779758", Offset = "0x2779758", VA = "0x2779758")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1046AE4", Offset = "0x1046AE4")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x2779BAC", Offset = "0x2779BAC", VA = "0x2779BAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1046B44", Offset = "0x1046B44")]
	public IEnumerator DownloadFilenames(string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x2779C2C", Offset = "0x2779C2C", VA = "0x2779C2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1046BA4", Offset = "0x1046BA4")]
	public IEnumerator SearchFilenames(string searchPattern, string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x2779CB8", Offset = "0x2779CB8", VA = "0x2779CB8")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x2779DC8", Offset = "0x2779DC8", VA = "0x2779DC8")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x2779E58", Offset = "0x2779E58", VA = "0x2779E58")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x2779EEC", Offset = "0x2779EEC", VA = "0x2779EEC")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x2779F78", Offset = "0x2779F78", VA = "0x2779F78")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x277A00C", Offset = "0x277A00C", VA = "0x277A00C")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x277A0AC", Offset = "0x277A0AC", VA = "0x277A0AC")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x2779D3C", Offset = "0x2779D3C", VA = "0x2779D3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1046C04", Offset = "0x1046C04")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x277886C", Offset = "0x277886C", VA = "0x277886C")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x277A13C", Offset = "0x277A13C", VA = "0x277A13C")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x277A158", Offset = "0x277A158", VA = "0x277A158", Slot = "4")]
	protected override void Reset()
	{
	}
}
[Token(Token = "0x200002B")]
public abstract class ES3Writer : IDisposable
{
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HashSet<string> keysToDelete;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool writeHeaderAndFooter;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	internal bool overwriteKeys;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int serializationDepth;

	[Token(Token = "0x60001D8")]
	internal abstract void WriteNull();

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2FD6658", Offset = "0x2FD6658", VA = "0x2FD6658", Slot = "6")]
	internal virtual void StartWriteFile()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2FD6668", Offset = "0x2FD6668", VA = "0x2FD6668", Slot = "7")]
	internal virtual void EndWriteFile()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2FD6678", Offset = "0x2FD6678", VA = "0x2FD6678", Slot = "8")]
	internal virtual void StartWriteObject(string name)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x2FD6688", Offset = "0x2FD6688", VA = "0x2FD6688", Slot = "9")]
	internal virtual void EndWriteObject(string name)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x2FD6698", Offset = "0x2FD6698", VA = "0x2FD6698", Slot = "10")]
	internal virtual void StartWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x2FD6768", Offset = "0x2FD6768", VA = "0x2FD6768", Slot = "11")]
	internal virtual void EndWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x2FD676C", Offset = "0x2FD676C", VA = "0x2FD676C", Slot = "12")]
	internal virtual void StartWriteCollection()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2FD677C", Offset = "0x2FD677C", VA = "0x2FD677C", Slot = "13")]
	internal virtual void EndWriteCollection()
	{
	}

	[Token(Token = "0x60001E1")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x60001E2")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x60001E3")]
	internal abstract void StartWriteDictionary();

	[Token(Token = "0x60001E4")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x60001E5")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x60001E6")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x60001E7")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x60001E8")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x60001E9")]
	public abstract void Dispose();

	[Token(Token = "0x60001EA")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x60001EB")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x60001EC")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x60001ED")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x60001EE")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x60001EF")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x60001F0")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x60001F1")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x60001F2")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x60001F3")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x60001F4")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x60001F5")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x60001F6")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x60001F7")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x60001F8")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x60001F9")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x2FD678C", Offset = "0x2FD678C", VA = "0x2FD678C")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x2FD6840", Offset = "0x2FD6840", VA = "0x2FD6840", Slot = "39")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x60001FC")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x2FD692C", Offset = "0x2FD692C", VA = "0x2FD692C", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046F34", Offset = "0x1046F34")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x2FD6A68", Offset = "0x2FD6A68", VA = "0x2FD6A68", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046F48", Offset = "0x1046F48")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x2FD6B34", Offset = "0x2FD6B34", VA = "0x2FD6B34", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046F5C", Offset = "0x1046F5C")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x2FD7110", Offset = "0x2FD7110", VA = "0x2FD7110", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x2FD7288", Offset = "0x2FD7288", VA = "0x2FD7288", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x2FD72B0", Offset = "0x2FD72B0", VA = "0x2FD72B0", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000203")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x2FD73E8", Offset = "0x2FD73E8", VA = "0x2FD73E8", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046F70", Offset = "0x1046F70")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x2FD7410", Offset = "0x2FD7410", VA = "0x2FD7410", Slot = "49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046F84", Offset = "0x1046F84")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x2FD74AC", Offset = "0x2FD74AC", VA = "0x2FD74AC", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046F98", Offset = "0x1046F98")]
	public virtual void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x2FD75C4", Offset = "0x2FD75C4", VA = "0x2FD75C4")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x2FD78B0", Offset = "0x2FD78B0", VA = "0x2FD78B0")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x2FD7AB4", Offset = "0x2FD7AB4", VA = "0x2FD7AB4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046FAC", Offset = "0x1046FAC")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x2FD7C74", Offset = "0x2FD7C74", VA = "0x2FD7C74")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046FC0", Offset = "0x1046FC0")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x2FD7E34", Offset = "0x2FD7E34", VA = "0x2FD7E34")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046FD4", Offset = "0x1046FD4")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x2FD8030", Offset = "0x2FD8030", VA = "0x2FD8030")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046FE8", Offset = "0x1046FE8")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x2FD5E6C", Offset = "0x2FD5E6C", VA = "0x2FD5E6C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046FFC", Offset = "0x1046FFC")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x2FD822C", Offset = "0x2FD822C", VA = "0x2FD822C")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x2FD82A8", Offset = "0x2FD82A8", VA = "0x2FD82A8")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x2FD82B8", Offset = "0x2FD82B8", VA = "0x2FD82B8")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x2FD8318", Offset = "0x2FD8318", VA = "0x2FD8318")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x2FD7338", Offset = "0x2FD7338", VA = "0x2FD7338")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1047010", Offset = "0x1047010")]
	protected bool SerializationDepthLimitExceeded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x2FD849C", Offset = "0x2FD849C", VA = "0x2FD849C", Slot = "51")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1047024", Offset = "0x1047024")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x2FD8500", Offset = "0x2FD8500", VA = "0x2FD8500")]
	protected void Merge()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2FD864C", Offset = "0x2FD864C", VA = "0x2FD864C")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2FD89E4", Offset = "0x2FD89E4", VA = "0x2FD89E4", Slot = "52")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2FD89F8", Offset = "0x2FD89F8", VA = "0x2FD89F8", Slot = "53")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200002C")]
public class ES3XMLWriter
{
	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2FD8AE4", Offset = "0x2FD8AE4", VA = "0x2FD8AE4")]
	public ES3XMLWriter()
	{
	}
}
[Token(Token = "0x200002D")]
public class RemoteDebugServerFactory : MonoBehaviour
{
	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int ServerPort;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int BroadcastPort;

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2FD8DF4", Offset = "0x2FD8DF4", VA = "0x2FD8DF4")]
	public void Awake()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2FD923C", Offset = "0x2FD923C", VA = "0x2FD923C")]
	public RemoteDebugServerFactory()
	{
	}
}
namespace UniRx.Examples
{
	[Token(Token = "0x200002E")]
	public class Sample01_ObservableWWW : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10412AC", Offset = "0x10412AC")]
		private sealed class <>c
		{
			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<string> <>9__0_0;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<Exception> <>9__0_1;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<string, IObservable<string>> <>9__0_3;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<string, string, <>f__AnonymousType1<string, string>> <>9__0_4;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Action<<>f__AnonymousType1<string, string>> <>9__0_5;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Action<string[]> <>9__0_6;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Action<float> <>9__0_7;

			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Action<WWWErrorException> <>9__0_2;

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x2FE048C", Offset = "0x2FE048C", VA = "0x2FE048C")]
			public <>c()
			{
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x2FE0494", Offset = "0x2FE0494", VA = "0x2FE0494")]
			internal void <Start>b__0_0(string x)
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2FE051C", Offset = "0x2FE051C", VA = "0x2FE051C")]
			internal void <Start>b__0_1(Exception ex)
			{
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x2FE0580", Offset = "0x2FE0580", VA = "0x2FE0580")]
			internal IObservable<string> <Start>b__0_3(string google)
			{
				return null;
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2FE05D0", Offset = "0x2FE05D0", VA = "0x2FE05D0")]
			internal <>f__AnonymousType1<string, string> <Start>b__0_4(string google, string bing)
			{
				return null;
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2FE0654", Offset = "0x2FE0654", VA = "0x2FE0654")]
			internal void <Start>b__0_5(<>f__AnonymousType1<string, string> x)
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2FE0740", Offset = "0x2FE0740", VA = "0x2FE0740")]
			internal void <Start>b__0_6(string[] xs)
			{
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x2FE0838", Offset = "0x2FE0838", VA = "0x2FE0838")]
			internal void <Start>b__0_7(float x)
			{
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2FE08DC", Offset = "0x2FE08DC", VA = "0x2FE08DC")]
			internal void <Start>b__0_2(WWWErrorException ex)
			{
			}
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2FD9250", Offset = "0x2FD9250", VA = "0x2FD9250")]
		private void Start()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2FD9C30", Offset = "0x2FD9C30", VA = "0x2FD9C30")]
		public Sample01_ObservableWWW()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class Sample02_ObservableTriggers : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10412BC", Offset = "0x10412BC")]
		private sealed class <>c
		{
			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Unit> <>9__0_0;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__0_1;

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2FE0B4C", Offset = "0x2FE0B4C", VA = "0x2FE0B4C")]
			public <>c()
			{
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2FE0B54", Offset = "0x2FE0B54", VA = "0x2FE0B54")]
			internal void <Start>b__0_0(Unit x)
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2FE0BC8", Offset = "0x2FE0BC8", VA = "0x2FE0BC8")]
			internal void <Start>b__0_1()
			{
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2FD9C38", Offset = "0x2FD9C38", VA = "0x2FD9C38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2FD9ED8", Offset = "0x2FD9ED8", VA = "0x2FD9ED8")]
		public Sample02_ObservableTriggers()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Sample04_ConvertFromUnityCallback : MonoBehaviour
	{
		[Token(Token = "0x2000033")]
		private class LogCallback
		{
			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Condition;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string StackTrace;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LogType LogType;

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2FE0DAC", Offset = "0x2FE0DAC", VA = "0x2FE0DAC")]
			public LogCallback()
			{
			}
		}

		[Token(Token = "0x2000034")]
		private static class LogHelper
		{
			[Token(Token = "0x2000035")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10412CC", Offset = "0x10412CC")]
			private sealed class <>c__DisplayClass0_0
			{
				[Token(Token = "0x40000C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Action<LogCallback> h;

				[Token(Token = "0x6000231")]
				[Address(RVA = "0x2FE3048", Offset = "0x2FE3048", VA = "0x2FE3048")]
				public <>c__DisplayClass0_0()
				{
				}

				[Token(Token = "0x6000232")]
				[Address(RVA = "0x2FE3068", Offset = "0x2FE3068", VA = "0x2FE3068")]
				internal void <LogCallbackAsObservable>b__3(string condition, string stackTrace, LogType type)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000036")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10412DC", Offset = "0x10412DC")]
			private sealed class <>c
			{
				[Token(Token = "0x40000C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly <>c <>9;

				[Token(Token = "0x40000C8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static Func<Action<LogCallback>, Application.LogCallback> <>9__0_0;

				[Token(Token = "0x40000C9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static Action<Application.LogCallback> <>9__0_1;

				[Token(Token = "0x40000CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public static Action<Application.LogCallback> <>9__0_2;

				[Token(Token = "0x6000234")]
				[Address(RVA = "0x2FE2F94", Offset = "0x2FE2F94", VA = "0x2FE2F94")]
				public <>c()
				{
				}

				[Token(Token = "0x6000235")]
				[Address(RVA = "0x2FE2F9C", Offset = "0x2FE2F9C", VA = "0x2FE2F9C")]
				internal Application.LogCallback <LogCallbackAsObservable>b__0_0(Action<LogCallback> h)
				{
					return null;
				}

				[Token(Token = "0x6000236")]
				[Address(RVA = "0x2FE3050", Offset = "0x2FE3050", VA = "0x2FE3050")]
				internal void <LogCallbackAsObservable>b__0_1(Application.LogCallback h)
				{
				}

				[Token(Token = "0x6000237")]
				[Address(RVA = "0x2FE305C", Offset = "0x2FE305C", VA = "0x2FE305C")]
				internal void <LogCallbackAsObservable>b__0_2(Application.LogCallback h)
				{
				}
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2FDA298", Offset = "0x2FDA298", VA = "0x2FDA298")]
			public static IObservable<LogCallback> LogCallbackAsObservable()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10412EC", Offset = "0x10412EC")]
		private sealed class <>c
		{
			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<LogCallback, bool> <>9__2_0;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<LogCallback> <>9__2_1;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<LogCallback, bool> <>9__2_2;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Action<LogCallback> <>9__2_3;

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2FE0C9C", Offset = "0x2FE0C9C", VA = "0x2FE0C9C")]
			public <>c()
			{
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x2FE0CA4", Offset = "0x2FE0CA4", VA = "0x2FE0CA4")]
			internal bool <Awake>b__2_0(LogCallback x)
			{
				return default(bool);
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x2FE0CC4", Offset = "0x2FE0CC4", VA = "0x2FE0CC4")]
			internal void <Awake>b__2_1(LogCallback x)
			{
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x2FE0D28", Offset = "0x2FE0D28", VA = "0x2FE0D28")]
			internal bool <Awake>b__2_2(LogCallback x)
			{
				return default(bool);
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2FE0D48", Offset = "0x2FE0D48", VA = "0x2FE0D48")]
			internal void <Awake>b__2_3(LogCallback x)
			{
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2FD9EE0", Offset = "0x2FD9EE0", VA = "0x2FD9EE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2FDA51C", Offset = "0x2FDA51C", VA = "0x2FDA51C")]
		public Sample04_ConvertFromUnityCallback()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Sample05_ConvertFromCoroutine
	{
		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10412FC", Offset = "0x10412FC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string url;

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x2FDA628", Offset = "0x2FDA628", VA = "0x2FDA628")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2FE0DB4", Offset = "0x2FE0DB4", VA = "0x2FE0DB4")]
			internal IEnumerator <GetWWW>b__0(IObserver<string> observer, CancellationToken cancellationToken)
			{
				return null;
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104130C", Offset = "0x104130C")]
		private sealed class <GetWWWCore>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40000D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IObserver<string> observer;

			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private WWW <www>5__2;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000246")]
				[Address(RVA = "0x2FE1080", Offset = "0x2FE1080", VA = "0x2FE1080", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000248")]
				[Address(RVA = "0x2FE10C8", Offset = "0x2FE10C8", VA = "0x2FE10C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x2FDA6B0", Offset = "0x2FDA6B0", VA = "0x2FDA6B0")]
			[DebuggerHidden]
			public <GetWWWCore>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x2FE0DBC", Offset = "0x2FE0DBC", VA = "0x2FE0DBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2FE0DC0", Offset = "0x2FE0DC0", VA = "0x2FE0DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x2FE1088", Offset = "0x2FE1088", VA = "0x2FE1088", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2FDA524", Offset = "0x2FDA524", VA = "0x2FDA524")]
		public static IObservable<string> GetWWW(string url)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2FDA630", Offset = "0x2FDA630", VA = "0x2FDA630")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1047038", Offset = "0x1047038")]
		private static IEnumerator GetWWWCore(string url, IObserver<string> observer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2FDA6DC", Offset = "0x2FDA6DC", VA = "0x2FDA6DC")]
		public Sample05_ConvertFromCoroutine()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class Sample06_ConvertToCoroutine : MonoBehaviour
	{
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104131C", Offset = "0x104131C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2FE1188", Offset = "0x2FE1188", VA = "0x2FE1188")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2FE1190", Offset = "0x2FE1190", VA = "0x2FE1190")]
			internal void <ComplexCoroutineTest>b__0(int x)
			{
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x2FE1198", Offset = "0x2FE1198", VA = "0x2FE1198")]
			internal void <ComplexCoroutineTest>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104132C", Offset = "0x104132C")]
		private sealed class <ComplexCoroutineTest>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private <>c__DisplayClass1_0 <>8__1;

			[Token(Token = "0x1700002C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000253")]
				[Address(RVA = "0x2FE1524", Offset = "0x2FE1524", VA = "0x2FE1524", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000255")]
				[Address(RVA = "0x2FE156C", Offset = "0x2FE156C", VA = "0x2FE156C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x2FDA76C", Offset = "0x2FDA76C", VA = "0x2FDA76C")]
			[DebuggerHidden]
			public <ComplexCoroutineTest>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x2FE11A0", Offset = "0x2FE11A0", VA = "0x2FE11A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2FE11A4", Offset = "0x2FE11A4", VA = "0x2FE11A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2FE152C", Offset = "0x2FE152C", VA = "0x2FE152C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104133C", Offset = "0x104133C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Sample06_ConvertToCoroutine, Transform> <>9__2_0;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Transform, bool> <>9__2_1;

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x2FE1130", Offset = "0x2FE1130", VA = "0x2FE1130")]
			public <>c()
			{
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x2FE1138", Offset = "0x2FE1138", VA = "0x2FE1138")]
			internal Transform <TestNewCustomYieldInstruction>b__2_0(Sample06_ConvertToCoroutine x)
			{
				return null;
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x2FE1154", Offset = "0x2FE1154", VA = "0x2FE1154")]
			internal bool <TestNewCustomYieldInstruction>b__2_1(Transform x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104134C", Offset = "0x104134C")]
		private sealed class <TestNewCustomYieldInstruction>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Sample06_ConvertToCoroutine <>4__this;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ObservableYieldInstruction<string> <o>5__2;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600025D")]
				[Address(RVA = "0x2FE1AD4", Offset = "0x2FE1AD4", VA = "0x2FE1AD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600025F")]
				[Address(RVA = "0x2FE1B1C", Offset = "0x2FE1B1C", VA = "0x2FE1B1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x2FDA804", Offset = "0x2FDA804", VA = "0x2FDA804")]
			[DebuggerHidden]
			public <TestNewCustomYieldInstruction>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x2FE1574", Offset = "0x2FE1574", VA = "0x2FE1574", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x2FE1578", Offset = "0x2FE1578", VA = "0x2FE1578", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x2FE1ADC", Offset = "0x2FE1ADC", VA = "0x2FE1ADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2FDA6E4", Offset = "0x2FDA6E4", VA = "0x2FDA6E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2FDA710", Offset = "0x2FDA710", VA = "0x2FDA710")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10470E8", Offset = "0x10470E8")]
		private IEnumerator ComplexCoroutineTest()
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2FDA798", Offset = "0x2FDA798", VA = "0x2FDA798")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1047148", Offset = "0x1047148")]
		private IEnumerator TestNewCustomYieldInstruction()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2FDA830", Offset = "0x2FDA830", VA = "0x2FDA830")]
		public Sample06_ConvertToCoroutine()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class Sample07_OrchestratIEnumerator : MonoBehaviour
	{
		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104135C", Offset = "0x104135C")]
		private sealed class <AsyncA>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000267")]
				[Address(RVA = "0x2FE1C44", Offset = "0x2FE1C44", VA = "0x2FE1C44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000269")]
				[Address(RVA = "0x2FE1C8C", Offset = "0x2FE1C8C", VA = "0x2FE1C8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x2FDA894", Offset = "0x2FDA894", VA = "0x2FDA894")]
			[DebuggerHidden]
			public <AsyncA>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x2FE1B24", Offset = "0x2FE1B24", VA = "0x2FE1B24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2FE1B28", Offset = "0x2FE1B28", VA = "0x2FE1B28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x2FE1C4C", Offset = "0x2FE1C4C", VA = "0x2FE1C4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104136C", Offset = "0x104136C")]
		private sealed class <AsyncB>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000032")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600026D")]
				[Address(RVA = "0x2FE1DB0", Offset = "0x2FE1DB0", VA = "0x2FE1DB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600026F")]
				[Address(RVA = "0x2FE1DF8", Offset = "0x2FE1DF8", VA = "0x2FE1DF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2FDA91C", Offset = "0x2FDA91C", VA = "0x2FDA91C")]
			[DebuggerHidden]
			public <AsyncB>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2FE1C94", Offset = "0x2FE1C94", VA = "0x2FE1C94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2FE1C98", Offset = "0x2FE1C98", VA = "0x2FE1C98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2FE1DB8", Offset = "0x2FE1DB8", VA = "0x2FE1DB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2FDA838", Offset = "0x2FDA838", VA = "0x2FDA838")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1047248", Offset = "0x1047248")]
		private IEnumerator AsyncA()
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2FDA8C0", Offset = "0x2FDA8C0", VA = "0x2FDA8C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10472A8", Offset = "0x10472A8")]
		private IEnumerator AsyncB()
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2FDA948", Offset = "0x2FDA948", VA = "0x2FDA948")]
		private void Start()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2FDAA8C", Offset = "0x2FDAA8C", VA = "0x2FDAA8C")]
		public Sample07_OrchestratIEnumerator()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class Sample08_DetectDoubleClick : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104137C", Offset = "0x104137C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<long, bool> <>9__0_0;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<IList<long>, bool> <>9__0_1;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<IList<long>> <>9__0_2;

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x2FE1E60", Offset = "0x2FE1E60", VA = "0x2FE1E60")]
			public <>c()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2FE1E68", Offset = "0x2FE1E68", VA = "0x2FE1E68")]
			internal bool <Start>b__0_0(long _)
			{
				return default(bool);
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x2FE1E74", Offset = "0x2FE1E74", VA = "0x2FE1E74")]
			internal bool <Start>b__0_1(IList<long> xs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x2FE1F28", Offset = "0x2FE1F28", VA = "0x2FE1F28")]
			internal void <Start>b__0_2(IList<long> xs)
			{
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2FDAA94", Offset = "0x2FDAA94", VA = "0x2FDAA94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2FDAE64", Offset = "0x2FDAE64", VA = "0x2FDAE64")]
		public Sample08_DetectDoubleClick()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class Sample09_EventHandling : MonoBehaviour
	{
		[Token(Token = "0x2000046")]
		public class MyEventArgs : EventArgs
		{
			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1046514", Offset = "0x1046514")]
			private int <MyProperty>k__BackingField;

			[Token(Token = "0x17000035")]
			public int MyProperty
			{
				[Token(Token = "0x600027F")]
				[Address(RVA = "0x2FE23DC", Offset = "0x2FE23DC", VA = "0x2FE23DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10473E8", Offset = "0x10473E8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000280")]
				[Address(RVA = "0x2FE23E4", Offset = "0x2FE23E4", VA = "0x2FE23E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10473F8", Offset = "0x10473F8")]
				set
				{
				}
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x2FE23EC", Offset = "0x2FE23EC", VA = "0x2FE23EC")]
			public MyEventArgs()
			{
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104138C", Offset = "0x104138C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Sample09_EventHandling <>4__this;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int capture;

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x2FDB6B0", Offset = "0x2FDB6B0", VA = "0x2FDB6B0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x2FE2214", Offset = "0x2FE2214", VA = "0x2FE2214")]
			internal void <Start>b__1(EventHandler<MyEventArgs> h)
			{
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x2FE222C", Offset = "0x2FE222C", VA = "0x2FE222C")]
			internal void <Start>b__2(EventHandler<MyEventArgs> h)
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x2FE2244", Offset = "0x2FE2244", VA = "0x2FE2244")]
			internal void <Start>b__4(EventHandler<MyEventArgs> h)
			{
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x2FE225C", Offset = "0x2FE225C", VA = "0x2FE225C")]
			internal void <Start>b__5(EventHandler<MyEventArgs> h)
			{
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x2FE2274", Offset = "0x2FE2274", VA = "0x2FE2274")]
			internal void <Start>b__6(Action<int> h)
			{
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x2FE228C", Offset = "0x2FE228C", VA = "0x2FE228C")]
			internal void <Start>b__7(Action<int> h)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2FE22A4", Offset = "0x2FE22A4", VA = "0x2FE22A4")]
			internal EventHandler<MyEventArgs> <Start>b__8(EventHandler<MyEventArgs> h)
			{
				return null;
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2FE2348", Offset = "0x2FE2348", VA = "0x2FE2348")]
			internal void <Start>b__9(EventHandler<MyEventArgs> h)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x2FE2360", Offset = "0x2FE2360", VA = "0x2FE2360")]
			internal void <Start>b__10(EventHandler<MyEventArgs> h)
			{
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104139C", Offset = "0x104139C")]
		private sealed class <>c__DisplayClass11_1
		{
			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<MyEventArgs> h;

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x2FE220C", Offset = "0x2FE220C", VA = "0x2FE220C")]
			public <>c__DisplayClass11_1()
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x2FE2378", Offset = "0x2FE2378", VA = "0x2FE2378")]
			internal void <Start>b__11(object sender, MyEventArgs e)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10413AC", Offset = "0x10413AC")]
		private sealed class <>c
		{
			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<EventHandler<MyEventArgs>, EventHandler<MyEventArgs>> <>9__11_0;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Action<MyEventArgs>, EventHandler<MyEventArgs>> <>9__11_3;

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x2FE20B8", Offset = "0x2FE20B8", VA = "0x2FE20B8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x2FE20C0", Offset = "0x2FE20C0", VA = "0x2FE20C0")]
			internal EventHandler<MyEventArgs> <Start>b__11_0(EventHandler<MyEventArgs> h)
			{
				return null;
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x2FE214C", Offset = "0x2FE214C", VA = "0x2FE214C")]
			internal EventHandler<MyEventArgs> <Start>b__11_3(Action<MyEventArgs> h)
			{
				return null;
			}
		}

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CompositeDisposable disposables;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Subject<int> onBarBar;

		[Token(Token = "0x17000034")]
		public IObservable<int> OnBarBar
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x2FDB0EC", Offset = "0x2FDB0EC", VA = "0x2FDB0EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event EventHandler<MyEventArgs> FooBar
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x2FDAE6C", Offset = "0x2FDAE6C", VA = "0x2FDAE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10473A8", Offset = "0x10473A8")]
			add
			{
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x2FDAF0C", Offset = "0x2FDAF0C", VA = "0x2FDAF0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10473B8", Offset = "0x10473B8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<int> FooFoo
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x2FDAFAC", Offset = "0x2FDAFAC", VA = "0x2FDAFAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10473C8", Offset = "0x10473C8")]
			add
			{
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x2FDB04C", Offset = "0x2FDB04C", VA = "0x2FDB04C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10473D8", Offset = "0x10473D8")]
			remove
			{
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2FDB0F4", Offset = "0x2FDB0F4", VA = "0x2FDB0F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2FDB6B8", Offset = "0x2FDB6B8", VA = "0x2FDB6B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2FDB6D4", Offset = "0x2FDB6D4", VA = "0x2FDB6D4")]
		public Sample09_EventHandling()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class Sample10_MainThreadDispatcher
	{
		[Serializable]
		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10413BC", Offset = "0x10413BC")]
		private sealed class <>c
		{
			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<object> <>9__0_0;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<long> <>9__0_1;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<Unit> <>9__0_2;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Action<Unit> <>9__0_3;

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x2FE24B0", Offset = "0x2FE24B0", VA = "0x2FE24B0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x2FE24B8", Offset = "0x2FE24B8", VA = "0x2FE24B8")]
			internal void <Run>b__0_0(object _)
			{
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0x2FE252C", Offset = "0x2FE252C", VA = "0x2FE252C")]
			internal void <Run>b__0_1(long x)
			{
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x2FE25C8", Offset = "0x2FE25C8", VA = "0x2FE25C8")]
			internal Unit <Run>b__0_2()
			{
				return default(Unit);
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2FE2614", Offset = "0x2FE2614", VA = "0x2FE2614")]
			internal void <Run>b__0_3(Unit x)
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10413CC", Offset = "0x10413CC")]
		private sealed class <TestAsync>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600029E")]
				[Address(RVA = "0x2FE28D0", Offset = "0x2FE28D0", VA = "0x2FE28D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A0")]
				[Address(RVA = "0x2FE2918", Offset = "0x2FE2918", VA = "0x2FE2918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x2FDBD08", Offset = "0x2FDBD08", VA = "0x2FDBD08")]
			[DebuggerHidden]
			public <TestAsync>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x2FE26B0", Offset = "0x2FE26B0", VA = "0x2FE26B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x2FE26B4", Offset = "0x2FE26B4", VA = "0x2FE26B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2FE28D8", Offset = "0x2FE28D8", VA = "0x2FE28D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2FDB778", Offset = "0x2FDB778", VA = "0x2FDB778")]
		public void Run()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2FDBCAC", Offset = "0x2FDBCAC", VA = "0x2FDBCAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1047408", Offset = "0x1047408")]
		private IEnumerator TestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2FDBD34", Offset = "0x2FDBD34", VA = "0x2FDBD34")]
		public Sample10_MainThreadDispatcher()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class Sample11_Logger
	{
		[Serializable]
		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10413DC", Offset = "0x10413DC")]
		private sealed class <>c
		{
			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<LogEntry, bool> <>9__1_0;

			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<LogEntry> <>9__1_1;

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x2FE2980", Offset = "0x2FE2980", VA = "0x2FE2980")]
			public <>c()
			{
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x2FE2988", Offset = "0x2FE2988", VA = "0x2FE2988")]
			internal bool <ApplicationInitialize>b__1_0(LogEntry x)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x2FE2998", Offset = "0x2FE2998", VA = "0x2FE2998")]
			internal void <ApplicationInitialize>b__1_1(LogEntry x)
			{
			}
		}

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly UniRx.Diagnostics.Logger logger;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2FDBD3C", Offset = "0x2FDBD3C", VA = "0x2FDBD3C")]
		public void ApplicationInitialize()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2FDBFA4", Offset = "0x2FDBFA4", VA = "0x2FDBFA4")]
		public void Run()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2FDC0D4", Offset = "0x2FDC0D4", VA = "0x2FDC0D4")]
		public Sample11_Logger()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class Sample12_ReactiveProperty : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10413EC", Offset = "0x10413EC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__7_1;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<float, string> <>9__7_2;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<bool, bool> <>9__7_3;

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2FE29FC", Offset = "0x2FE29FC", VA = "0x2FE29FC")]
			public <>c()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2FE2A04", Offset = "0x2FE2A04", VA = "0x2FE2A04")]
			internal bool <Start>b__7_1(string x)
			{
				return default(bool);
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x2FE2A10", Offset = "0x2FE2A10", VA = "0x2FE2A10")]
			internal string <Start>b__7_2(float x)
			{
				return null;
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2FE2AA0", Offset = "0x2FE2AA0", VA = "0x2FE2AA0")]
			internal bool <Start>b__7_3(bool isDead)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button MyButton;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Toggle MyToggle;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputField MyInput;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text MyText;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Slider MySlider;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IntReactiveProperty IntRxProp;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Enemy enemy;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2FDC168", Offset = "0x2FDC168", VA = "0x2FDC168")]
		private void Start()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2FDC6B0", Offset = "0x2FDC6B0", VA = "0x2FDC6B0")]
		public Sample12_ReactiveProperty()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2FDC740", Offset = "0x2FDC740", VA = "0x2FDC740")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10474B8", Offset = "0x10474B8")]
		private void <Start>b__7_0(Unit _)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2FDC860", Offset = "0x2FDC860", VA = "0x2FDC860")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10474C8", Offset = "0x10474C8")]
		private void <Start>b__7_4(bool _)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class Enemy
	{
		[Serializable]
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10413FC", Offset = "0x10413FC")]
		private sealed class <>c
		{
			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<long, bool> <>9__8_0;

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x2FE0418", Offset = "0x2FE0418", VA = "0x2FE0418")]
			public <>c()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x2FE0420", Offset = "0x2FE0420", VA = "0x2FE0420")]
			internal bool <.ctor>b__8_0(long x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1046524", Offset = "0x1046524")]
		private IReactiveProperty<long> <CurrentHp>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1046534", Offset = "0x1046534")]
		private IReadOnlyReactiveProperty<bool> <IsDead>k__BackingField;

		[Token(Token = "0x17000038")]
		public IReactiveProperty<long> CurrentHp
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x2FD8BD8", Offset = "0x2FD8BD8", VA = "0x2FD8BD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10474D8", Offset = "0x10474D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x2FD8BE0", Offset = "0x2FD8BE0", VA = "0x2FD8BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10474E8", Offset = "0x10474E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public IReadOnlyReactiveProperty<bool> IsDead
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2FD8BE8", Offset = "0x2FD8BE8", VA = "0x2FD8BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10474F8", Offset = "0x10474F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x2FD8BF0", Offset = "0x2FD8BF0", VA = "0x2FD8BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1047508", Offset = "0x1047508")]
			private set
			{
			}
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2FD8BF8", Offset = "0x2FD8BF8", VA = "0x2FD8BF8")]
		public Enemy(int initialHp)
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class Sample13_ToDoApp : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104140C", Offset = "0x104140C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__7_1;

			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, bool> <>9__7_2;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<CollectionRemoveEvent<GameObject>> <>9__7_6;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<GameObject, bool> <>9__7_8;

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x2FE2B08", Offset = "0x2FE2B08", VA = "0x2FE2B08")]
			public <>c()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x2FE2B10", Offset = "0x2FE2B10", VA = "0x2FE2B10")]
			internal bool <Start>b__7_1(string _)
			{
				return default(bool);
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x2FE2B1C", Offset = "0x2FE2B1C", VA = "0x2FE2B1C")]
			internal bool <Start>b__7_2(string x)
			{
				return default(bool);
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x2FE2B6C", Offset = "0x2FE2B6C", VA = "0x2FE2B6C")]
			internal void <Start>b__7_6(CollectionRemoveEvent<GameObject> x)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x2FE2BDC", Offset = "0x2FE2BDC", VA = "0x2FE2BDC")]
			internal bool <Start>b__7_8(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text Title;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputField ToDoInput;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Button AddButton;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button ClearButton;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject TodoList;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject SampleItemPrefab;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ReactiveCollection<GameObject> toDos;

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2FDC8A8", Offset = "0x2FDC8A8", VA = "0x2FDC8A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2FDCF88", Offset = "0x2FDCF88", VA = "0x2FDCF88")]
		public Sample13_ToDoApp()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2FDD000", Offset = "0x2FDD000", VA = "0x2FDD000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1047518", Offset = "0x1047518")]
		private string <Start>b__7_0(Unit _)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2FDD01C", Offset = "0x2FDD01C", VA = "0x2FDD01C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1047528", Offset = "0x1047528")]
		private void <Start>b__7_3(string x)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2FDD1B8", Offset = "0x2FDD1B8", VA = "0x2FDD1B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1047538", Offset = "0x1047538")]
		private void <Start>b__7_4(int x)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2FDD24C", Offset = "0x2FDD24C", VA = "0x2FDD24C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1047548", Offset = "0x1047548")]
		private void <Start>b__7_5(CollectionAddEvent<GameObject> x)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2FDD2D4", Offset = "0x2FDD2D4", VA = "0x2FDD2D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1047558", Offset = "0x1047558")]
		private void <Start>b__7_7(Unit _)
		{
		}
	}
}
namespace ES3Types
{
	[Token(Token = "0x2000055")]
	[Preserve]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x3979538", Offset = "0x3979538", VA = "0x3979538")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x39795FC", Offset = "0x39795FC", VA = "0x39795FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x3979604", Offset = "0x3979604", VA = "0x3979604")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x39796C8", Offset = "0x39796C8", VA = "0x39796C8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002CD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2773C04", Offset = "0x2773C04", VA = "0x2773C04")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2773CFC", Offset = "0x2773CFC", VA = "0x2773CFC", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x60002D2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2773F18", Offset = "0x2773F18", VA = "0x2773F18", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2774198", Offset = "0x2774198", VA = "0x2774198", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2774468", Offset = "0x2774468", VA = "0x2774468")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x277446C", Offset = "0x277446C", VA = "0x277446C", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002D8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2774720", Offset = "0x2774720", VA = "0x2774720", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2774A74", Offset = "0x2774A74", VA = "0x2774A74", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000059")]
	[Preserve]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2774DE4", Offset = "0x2774DE4", VA = "0x2774DE4")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2774DE8", Offset = "0x2774DE8", VA = "0x2774DE8")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2774E50", Offset = "0x2774E50", VA = "0x2774E50", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2774FD4", Offset = "0x2774FD4", VA = "0x2774FD4", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x277528C", Offset = "0x277528C", VA = "0x277528C", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200005A")]
	[Preserve]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type elementType;

		[Token(Token = "0x60002E3")]
		public abstract object Read(ES3Reader reader);

		[Token(Token = "0x60002E4")]
		public abstract void ReadInto(ES3Reader reader, object obj);

		[Token(Token = "0x60002E5")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2773C08", Offset = "0x2773C08", VA = "0x2773C08")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2774E1C", Offset = "0x2774E1C", VA = "0x2774E1C")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x277A2D0", Offset = "0x277A2D0", VA = "0x277A2D0", Slot = "4")]
		[Preserve]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E9")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EA")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x277A2E0", Offset = "0x277A2E0", VA = "0x277A2E0", Slot = "12")]
		[Preserve]
		protected virtual void ReadICollectionInto(ES3Reader reader, ICollection collection, ES3Type elementType)
		{
		}
	}
	[Token(Token = "0x200005B")]
	[Preserve]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type keyType;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ES3Type valueType;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x277B4E4", Offset = "0x277B4E4", VA = "0x277B4E4")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x277B604", Offset = "0x277B604", VA = "0x277B604")]
		public ES3DictionaryType(Type type, ES3Type keyType, ES3Type valueType)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x277B654", Offset = "0x277B654", VA = "0x277B654", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x277B678", Offset = "0x277B678", VA = "0x277B678")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002F0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x277BA88", Offset = "0x277BA88", VA = "0x277BA88")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x277BE5C", Offset = "0x277BE5C", VA = "0x277BE5C")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200005C")]
	[Preserve]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x277DAA4", Offset = "0x277DAA4", VA = "0x277DAA4")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x277DAA8", Offset = "0x277DAA8", VA = "0x277DAA8", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002F6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x277E088", Offset = "0x277E088", VA = "0x277E088", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x277E5F0", Offset = "0x277E5F0", VA = "0x277E5F0", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200005D")]
	[Preserve]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2782390", Offset = "0x2782390", VA = "0x2782390")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2782394", Offset = "0x2782394", VA = "0x2782394")]
		public ES3ListType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x27823C8", Offset = "0x27823C8", VA = "0x27823C8", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002FD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x27827AC", Offset = "0x27827AC", VA = "0x27827AC", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2782994", Offset = "0x2782994", VA = "0x2782994", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200005E")]
	[Preserve]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x27842AC", Offset = "0x27842AC", VA = "0x27842AC")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x27842B0", Offset = "0x27842B0", VA = "0x27842B0", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000303")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2784680", Offset = "0x2784680", VA = "0x2784680", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x278496C", Offset = "0x278496C", VA = "0x278496C", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200005F")]
	[Preserve]
	public class ES3StackType : ES3CollectionType
	{
		[Serializable]
		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x104149C", Offset = "0x104149C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MethodInfo, bool> <>9__4_0;

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x2FE0220", Offset = "0x2FE0220", VA = "0x2FE0220")]
			public <>c()
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x2FE0228", Offset = "0x2FE0228", VA = "0x2FE0228")]
			internal bool <Read>b__4_0(MethodInfo t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x3971200", Offset = "0x3971200", VA = "0x3971200")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x3971208", Offset = "0x3971208", VA = "0x3971208", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000309")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x39715D8", Offset = "0x39715D8", VA = "0x39715D8", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x3971A3C", Offset = "0x3971A3C", VA = "0x3971A3C", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000061")]
	[Preserve]
	public abstract class ES3ComponentType : ES3UnityObjectType
	{
		[Token(Token = "0x4000124")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x277A810", Offset = "0x277A810", VA = "0x277A810")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x6000311")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x6000312")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x277A818", Offset = "0x277A818", VA = "0x277A818", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000314")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000315")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x277AF7C", Offset = "0x277AF7C", VA = "0x277AF7C")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x277B038", Offset = "0x277B038", VA = "0x277B038")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000062")]
	[Preserve]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2782FCC", Offset = "0x2782FCC", VA = "0x2782FCC")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x600031A")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x600031B")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x600031C")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2782FD4", Offset = "0x2782FD4", VA = "0x2782FD4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600031E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000063")]
	[Preserve]
	public abstract class ES3ScriptableObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x396E1FC", Offset = "0x396E1FC", VA = "0x396E1FC")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000321")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000322")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x396E204", Offset = "0x396E204", VA = "0x396E204", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000324")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000325")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	[Preserve]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x10414DC", Offset = "0x10414DC")]
	public abstract class ES3Type
	{
		[Token(Token = "0x4000125")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isEnum;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isReflectedType;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUnsupported;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int priority;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x397238C", Offset = "0x397238C", VA = "0x397238C")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x6000328")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x6000329")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x600032A")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x397262C", Offset = "0x397262C", VA = "0x397262C")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x600032C")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x397273C", Offset = "0x397273C", VA = "0x397273C")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x3972774", Offset = "0x3972774", VA = "0x3972774")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x39728C4", Offset = "0x39728C4", VA = "0x39728C4")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x39728B8", Offset = "0x39728B8", VA = "0x39728B8")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x397437C", Offset = "0x397437C", VA = "0x397437C")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1041518", Offset = "0x1041518")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2784280", Offset = "0x2784280", VA = "0x2784280")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x2000066")]
	[Preserve]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2FCF6A0", Offset = "0x2FCF6A0", VA = "0x2FCF6A0")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x6000334")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000335")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000336")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2FD5A6C", Offset = "0x2FD5A6C", VA = "0x2FD5A6C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2FD5A80", Offset = "0x2FD5A80", VA = "0x2FD5A80", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x6000339")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600033A")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2FD5CF8", Offset = "0x2FD5CF8", VA = "0x2FD5CF8")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000067")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x104153C", Offset = "0x104153C")]
	public class ES3Type_Random : ES3ObjectType
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x3FB6C70", Offset = "0x3FB6C70", VA = "0x3FB6C70")]
		public ES3Type_Random()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x3FB6D38", Offset = "0x3FB6D38", VA = "0x3FB6D38", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600033E")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600033F")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000068")]
	public class ES3Type_RandomArray : ES3ArrayType
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x3FB6E40", Offset = "0x3FB6E40", VA = "0x3FB6E40")]
		public ES3Type_RandomArray()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[Preserve]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x3979240", Offset = "0x3979240", VA = "0x3979240")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x3979304", Offset = "0x3979304", VA = "0x3979304", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000344")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006A")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x3979440", Offset = "0x3979440", VA = "0x3979440")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[Preserve]
	public class ES3Type_ES3Ref : ES3Type
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x3979868", Offset = "0x3979868", VA = "0x3979868")]
		public ES3Type_ES3Ref()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x3979934", Offset = "0x3979934", VA = "0x3979934", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000349")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	public class ES3Type_ES3RefArray : ES3ArrayType
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x3979A40", Offset = "0x3979A40", VA = "0x3979A40")]
		public ES3Type_ES3RefArray()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class ES3Type_ES3RefDictionary : ES3DictionaryType
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x3979BAC", Offset = "0x3979BAC", VA = "0x3979BAC")]
		public ES3Type_ES3RefDictionary()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[Preserve]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2FD1470", Offset = "0x2FD1470", VA = "0x2FD1470")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2FD1540", Offset = "0x2FD1540", VA = "0x2FD1540", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000351")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2FD15D8", Offset = "0x2FD15D8", VA = "0x2FD15D8")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[Preserve]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2FD2E38", Offset = "0x2FD2E38", VA = "0x2FD2E38")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2FD2F08", Offset = "0x2FD2F08", VA = "0x2FD2F08", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000356")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2FD2FA0", Offset = "0x2FD2FA0", VA = "0x2FD2FA0")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[Preserve]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2FD3098", Offset = "0x2FD3098", VA = "0x2FD3098")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2FD3168", Offset = "0x2FD3168", VA = "0x2FD3168", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600035B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000073")]
	[Preserve]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2FD3200", Offset = "0x2FD3200", VA = "0x2FD3200")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2FD32D0", Offset = "0x2FD32D0", VA = "0x2FD32D0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600035F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000074")]
	[Preserve]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2FD3368", Offset = "0x2FD3368", VA = "0x2FD3368")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2FD3438", Offset = "0x2FD3438", VA = "0x2FD3438", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000363")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2FD34D0", Offset = "0x2FD34D0", VA = "0x2FD34D0")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[Preserve]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2FD35C8", Offset = "0x2FD35C8", VA = "0x2FD35C8")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2FD3698", Offset = "0x2FD3698", VA = "0x2FD3698", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000368")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2FD3730", Offset = "0x2FD3730", VA = "0x2FD3730")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[Preserve]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2FD3828", Offset = "0x2FD3828", VA = "0x2FD3828")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2FD38F8", Offset = "0x2FD38F8", VA = "0x2FD38F8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600036D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2FD3990", Offset = "0x2FD3990", VA = "0x2FD3990")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[Preserve]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type underlyingType;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2FD3A88", Offset = "0x2FD3A88", VA = "0x2FD3A88")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2FD3B54", Offset = "0x2FD3B54", VA = "0x2FD3B54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000372")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	[Preserve]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2FD4610", Offset = "0x2FD4610", VA = "0x2FD4610")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2FD46E0", Offset = "0x2FD46E0", VA = "0x2FD46E0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000376")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200007C")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2FD4778", Offset = "0x2FD4778", VA = "0x2FD4778")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[Preserve]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2FD4870", Offset = "0x2FD4870", VA = "0x2FD4870")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2FD4940", Offset = "0x2FD4940", VA = "0x2FD4940", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600037B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2FD49D8", Offset = "0x2FD49D8", VA = "0x2FD49D8")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[Preserve]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x397DC0C", Offset = "0x397DC0C", VA = "0x397DC0C")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x397DCD8", Offset = "0x397DCD8", VA = "0x397DCD8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000380")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000080")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x397DD7C", Offset = "0x397DD7C", VA = "0x397DD7C")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[Preserve]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2FD4AD0", Offset = "0x2FD4AD0", VA = "0x2FD4AD0")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2FD4BA0", Offset = "0x2FD4BA0", VA = "0x2FD4BA0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000385")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2FD4C38", Offset = "0x2FD4C38", VA = "0x2FD4C38")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[Preserve]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2FD4D30", Offset = "0x2FD4D30", VA = "0x2FD4D30")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2FD4E00", Offset = "0x2FD4E00", VA = "0x2FD4E00", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600038A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2FD4E98", Offset = "0x2FD4E98", VA = "0x2FD4E98")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[Preserve]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2FD4F90", Offset = "0x2FD4F90", VA = "0x2FD4F90")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2FD5060", Offset = "0x2FD5060", VA = "0x2FD5060", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600038F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000086")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2FD50F8", Offset = "0x2FD50F8", VA = "0x2FD50F8")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[Preserve]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2FD51F0", Offset = "0x2FD51F0", VA = "0x2FD51F0")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2FD52C0", Offset = "0x2FD52C0", VA = "0x2FD52C0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000394")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x3FBD888", Offset = "0x3FBD888", VA = "0x3FBD888")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[Preserve]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x2FD534C", Offset = "0x2FD534C", VA = "0x2FD534C")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2FD541C", Offset = "0x2FD541C", VA = "0x2FD541C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000399")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2FD54B4", Offset = "0x2FD54B4", VA = "0x2FD54B4")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[Preserve]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2FD55AC", Offset = "0x2FD55AC", VA = "0x2FD55AC")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2FD567C", Offset = "0x2FD567C", VA = "0x2FD567C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600039E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200008C")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2FD5714", Offset = "0x2FD5714", VA = "0x2FD5714")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[Preserve]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2FD580C", Offset = "0x2FD580C", VA = "0x2FD580C")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2FD58DC", Offset = "0x2FD58DC", VA = "0x2FD58DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2FD5974", Offset = "0x2FD5974", VA = "0x2FD5974")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[Preserve]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x27882CC", Offset = "0x27882CC", VA = "0x27882CC")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2788304", Offset = "0x2788304", VA = "0x2788304", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A8")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000090")]
	[Preserve]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x278830C", Offset = "0x278830C", VA = "0x278830C")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2788344", Offset = "0x2788344", VA = "0x2788344", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AB")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000091")]
	[Preserve]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x278834C", Offset = "0x278834C", VA = "0x278834C")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2788384", Offset = "0x2788384", VA = "0x2788384", Slot = "14")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AF")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000092")]
	[Preserve]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x278838C", Offset = "0x278838C", VA = "0x278838C")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x27883B8", Offset = "0x27883B8", VA = "0x27883B8")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x27883F8", Offset = "0x27883F8", VA = "0x27883F8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000093")]
	[Preserve]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x27887EC", Offset = "0x27887EC", VA = "0x27887EC")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2788824", Offset = "0x2788824", VA = "0x2788824", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B7")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000094")]
	[Preserve]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x278882C", Offset = "0x278882C", VA = "0x278882C")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2788864", Offset = "0x2788864", VA = "0x2788864", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003BB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000095")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1041780", Offset = "0x1041780")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x397630C", Offset = "0x397630C", VA = "0x397630C")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x39763D4", Offset = "0x39763D4", VA = "0x39763D4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003BF")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000096")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1041854", Offset = "0x1041854")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x397667C", Offset = "0x397667C", VA = "0x397667C")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x3976744", Offset = "0x3976744", VA = "0x3976744", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C3")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000097")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1041938", Offset = "0x1041938")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x3976A8C", Offset = "0x3976A8C", VA = "0x3976A8C")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x3976B54", Offset = "0x3976B54", VA = "0x3976B54", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C7")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1041BBC", Offset = "0x1041BBC")]
	[Preserve]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x39776F8", Offset = "0x39776F8", VA = "0x39776F8")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x39777C0", Offset = "0x39777C0", VA = "0x39777C0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003CB")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000099")]
	[Preserve]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x397A144", Offset = "0x397A144", VA = "0x397A144")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x397A20C", Offset = "0x397A20C", VA = "0x397A20C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003CF")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009A")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1041CC0", Offset = "0x1041CC0")]
	public class ES3Type_Image : ES3ComponentType
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x397CDD4", Offset = "0x397CDD4", VA = "0x397CDD4")]
		public ES3Type_Image()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x397CEA4", Offset = "0x397CEA4", VA = "0x397CEA4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D3")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class ES3Type_ImageArray : ES3ArrayType
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x397D75C", Offset = "0x397D75C", VA = "0x397D75C")]
		public ES3Type_ImageArray()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1041E84", Offset = "0x1041E84")]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x401E3D0", Offset = "0x401E3D0", VA = "0x401E3D0")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x401E498", Offset = "0x401E498", VA = "0x401E498", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D8")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x401E7BC", Offset = "0x401E7BC", VA = "0x401E7BC")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1041F78", Offset = "0x1041F78")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x401E8B4", Offset = "0x401E8B4", VA = "0x401E8B4")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x401E97C", Offset = "0x401E97C", VA = "0x401E97C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DD")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x401EA28", Offset = "0x401EA28", VA = "0x401EA28")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1041FFC", Offset = "0x1041FFC")]
	[Preserve]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x401EB20", Offset = "0x401EB20", VA = "0x401EB20")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x401EBE8", Offset = "0x401EBE8", VA = "0x401EBE8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E2")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x3FB3794", Offset = "0x3FB3794", VA = "0x3FB3794")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042180", Offset = "0x1042180")]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x3FB4E10", Offset = "0x3FB4E10", VA = "0x3FB4E10")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x3FB4ED8", Offset = "0x3FB4ED8", VA = "0x3FB4ED8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E7")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10423A4", Offset = "0x10423A4")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x3FB614C", Offset = "0x3FB614C", VA = "0x3FB614C")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x3FB6214", Offset = "0x3FB6214", VA = "0x3FB6214", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003EB")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x3FB679C", Offset = "0x3FB679C", VA = "0x3FB679C")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10424A8", Offset = "0x10424A8")]
	public class ES3Type_RawImage : ES3ComponentType
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x3FB6F38", Offset = "0x3FB6F38", VA = "0x3FB6F38")]
		public ES3Type_RawImage()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x3FB7008", Offset = "0x3FB7008", VA = "0x3FB7008", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F0")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class ES3Type_RawImageArray : ES3ArrayType
	{
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x3FB7564", Offset = "0x3FB7564", VA = "0x3FB7564")]
		public ES3Type_RawImageArray()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10425CC", Offset = "0x10425CC")]
	[Preserve]
	public class ES3Type_Rigidbody : ES3ComponentType
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x3FB88A4", Offset = "0x3FB88A4", VA = "0x3FB88A4")]
		public ES3Type_Rigidbody()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x3FB8974", Offset = "0x3FB8974", VA = "0x3FB8974", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F5")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class ES3UserType_RigidbodyArray : ES3ArrayType
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2FD5F0C", Offset = "0x2FD5F0C", VA = "0x2FD5F0C")]
		public ES3UserType_RigidbodyArray()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10427A0", Offset = "0x10427A0")]
	[Preserve]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x3FBC480", Offset = "0x3FBC480", VA = "0x3FBC480")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x3FBC548", Offset = "0x3FBC548", VA = "0x3FBC548", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FA")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042874", Offset = "0x1042874")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2FCEAB4", Offset = "0x2FCEAB4", VA = "0x2FCEAB4")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2FCEB7C", Offset = "0x2FCEB7C", VA = "0x2FCEB7C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FE")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042A58", Offset = "0x1042A58")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int countRead;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ES3Type Instance;

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2FD0DB8", Offset = "0x2FD0DB8", VA = "0x2FD0DB8")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2FD0E80", Offset = "0x2FD0E80", VA = "0x2FD0E80", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000402")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042B0C", Offset = "0x1042B0C")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x3975384", Offset = "0x3975384", VA = "0x3975384")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x3975448", Offset = "0x3975448", VA = "0x3975448", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000406")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042BB0", Offset = "0x1042BB0")]
	[Preserve]
	public class ES3Type_AudioClip : ES3UnityObjectType
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x39755EC", Offset = "0x39755EC", VA = "0x39755EC")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x39756B4", Offset = "0x39756B4", VA = "0x39756B4", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600040B")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600040C")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AE")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x39758FC", Offset = "0x39758FC", VA = "0x39758FC")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042C74", Offset = "0x1042C74")]
	[Preserve]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x39759F4", Offset = "0x39759F4", VA = "0x39759F4")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x3975AB8", Offset = "0x3975AB8", VA = "0x3975AB8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000411")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x3975EB4", Offset = "0x3975EB4", VA = "0x3975EB4")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042D68", Offset = "0x1042D68")]
	[Preserve]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3975FAC", Offset = "0x3975FAC", VA = "0x3975FAC")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x3976070", Offset = "0x3976070", VA = "0x3976070", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000416")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B2")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x3976214", Offset = "0x3976214", VA = "0x3976214")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042DFC", Offset = "0x1042DFC")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x3977C48", Offset = "0x3977C48", VA = "0x3977C48")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x3977D0C", Offset = "0x3977D0C", VA = "0x3977D0C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600041B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1042F90", Offset = "0x1042F90")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x397840C", Offset = "0x397840C", VA = "0x397840C")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x39784D0", Offset = "0x39784D0", VA = "0x39784D0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000420")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x3978B08", Offset = "0x3978B08", VA = "0x3978B08")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043044", Offset = "0x1043044")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x39786EC", Offset = "0x39786EC", VA = "0x39786EC")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x39787B0", Offset = "0x39787B0", VA = "0x39787B0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000425")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x39789C8", Offset = "0x39789C8", VA = "0x39789C8")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B7")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x3978A10", Offset = "0x3978A10", VA = "0x3978A10")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10430F8", Offset = "0x10430F8")]
	[Preserve]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x3978C00", Offset = "0x3978C00", VA = "0x3978C00")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x3978CC4", Offset = "0x3978CC4", VA = "0x3978CC4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600042B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x104319C", Offset = "0x104319C")]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x3978F70", Offset = "0x3978F70", VA = "0x3978F70")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x3979034", Offset = "0x3979034", VA = "0x3979034", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000430")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043230", Offset = "0x1043230")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x3979D1C", Offset = "0x3979D1C", VA = "0x3979D1C")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x3979DE0", Offset = "0x3979DE0", VA = "0x3979DE0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000435")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10432F4", Offset = "0x10432F4")]
	[Preserve]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x397A214", Offset = "0x397A214", VA = "0x397A214")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x397A2D8", Offset = "0x397A2D8", VA = "0x397A2D8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600043A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043388", Offset = "0x1043388")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x397A4B8", Offset = "0x397A4B8", VA = "0x397A4B8")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x397A57C", Offset = "0x397A57C", VA = "0x397A57C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600043F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x397A654", Offset = "0x397A654", VA = "0x397A654")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x104340C", Offset = "0x104340C")]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x397A74C", Offset = "0x397A74C", VA = "0x397A74C")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x397A814", Offset = "0x397A814", VA = "0x397A814", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000445")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000446")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BF")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x397A940", Offset = "0x397A940", VA = "0x397A940")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10434A0", Offset = "0x10434A0")]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x397AA38", Offset = "0x397AA38", VA = "0x397AA38")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x397AAFC", Offset = "0x397AAFC", VA = "0x397AAFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600044B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10435A4", Offset = "0x10435A4")]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1043688", Offset = "0x1043688")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Predicate<Component> <>9__0;

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x2FE0254", Offset = "0x2FE0254", VA = "0x2FE0254")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x2FE025C", Offset = "0x2FE025C", VA = "0x2FE025C")]
			internal bool <ReadComponents>b__0(Component x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000188")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x4000189")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool saveChildren;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x397AFEC", Offset = "0x397AFEC", VA = "0x397AFEC")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x397B0B4", Offset = "0x397B0B4", VA = "0x397B0B4", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x6000450")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x397BCA4", Offset = "0x397BCA4", VA = "0x397BCA4")]
		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x397C328", Offset = "0x397C328", VA = "0x397C328")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x397B988", Offset = "0x397B988", VA = "0x397B988")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x397C3BC", Offset = "0x397C3BC", VA = "0x397C3BC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000456")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000457")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C3")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x397C3C4", Offset = "0x397C3C4", VA = "0x397C3C4")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043698", Offset = "0x1043698")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x397C4BC", Offset = "0x397C4BC", VA = "0x397C4BC")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x397C580", Offset = "0x397C580", VA = "0x397C580", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600045E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x104373C", Offset = "0x104373C")]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x397C730", Offset = "0x397C730", VA = "0x397C730")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x397C7F4", Offset = "0x397C7F4", VA = "0x397C7F4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000463")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C6")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x397C964", Offset = "0x397C964", VA = "0x397C964")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10437D0", Offset = "0x10437D0")]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x397CA5C", Offset = "0x397CA5C", VA = "0x397CA5C")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x397CB20", Offset = "0x397CB20", VA = "0x397CB20", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000468")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C8")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x397CCDC", Offset = "0x397CCDC", VA = "0x397CCDC")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043864", Offset = "0x1043864")]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x397D854", Offset = "0x397D854", VA = "0x397D854")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x397D918", Offset = "0x397D918", VA = "0x397D918", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600046D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043918", Offset = "0x1043918")]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x397DE74", Offset = "0x397DE74", VA = "0x397DE74")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x397DF38", Offset = "0x397DF38", VA = "0x397DF38", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000472")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CB")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x397E188", Offset = "0x397E188", VA = "0x397E188")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10439CC", Offset = "0x10439CC")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x397E280", Offset = "0x397E280", VA = "0x397E280")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x397E344", Offset = "0x397E344", VA = "0x397E344", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000477")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CD")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043A70", Offset = "0x1043A70")]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x397E478", Offset = "0x397E478", VA = "0x397E478")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x397E540", Offset = "0x397E540", VA = "0x397E540", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600047B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043C44", Offset = "0x1043C44")]
	[Preserve]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x397EE38", Offset = "0x397EE38", VA = "0x397EE38")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x397EEFC", Offset = "0x397EEFC", VA = "0x397EEFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600047F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043D78", Offset = "0x1043D78")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x397F520", Offset = "0x397F520", VA = "0x397F520")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x397F5E4", Offset = "0x397F5E4", VA = "0x397F5E4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000484")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1043EAC", Offset = "0x1043EAC")]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x397FBE8", Offset = "0x397FBE8", VA = "0x397FBE8")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x397FCAC", Offset = "0x397FCAC", VA = "0x397FCAC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000489")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044170", Offset = "0x1044170")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x4017158", Offset = "0x4017158", VA = "0x4017158")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x4017220", Offset = "0x4017220", VA = "0x4017220", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600048E")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x401D768", Offset = "0x401D768", VA = "0x401D768")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044234", Offset = "0x1044234")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x401D860", Offset = "0x401D860", VA = "0x401D860")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x401D928", Offset = "0x401D928", VA = "0x401D928", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000494")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D4")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x401DB9C", Offset = "0x401DB9C", VA = "0x401DB9C")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10442E8", Offset = "0x10442E8")]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x401DC94", Offset = "0x401DC94", VA = "0x401DC94")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x401DD5C", Offset = "0x401DD5C", VA = "0x401DD5C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000499")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x104443C", Offset = "0x104443C")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x3FB388C", Offset = "0x3FB388C", VA = "0x3FB388C")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x3FB3954", Offset = "0x3FB3954", VA = "0x3FB3954", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600049E")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044530", Offset = "0x1044530")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x3FB3D10", Offset = "0x3FB3D10", VA = "0x3FB3D10")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x3FB3DD8", Offset = "0x3FB3DD8", VA = "0x3FB3DD8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004A3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D8")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044614", Offset = "0x1044614")]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x3FB4164", Offset = "0x3FB4164", VA = "0x3FB4164")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x3FB422C", Offset = "0x3FB422C", VA = "0x3FB422C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004A7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044838", Offset = "0x1044838")]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x3FB59AC", Offset = "0x3FB59AC", VA = "0x3FB59AC")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x3FB5A74", Offset = "0x3FB5A74", VA = "0x3FB5A74", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004AC")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004AD")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DA")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x3FB5D1C", Offset = "0x3FB5D1C", VA = "0x3FB5D1C")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10448FC", Offset = "0x10448FC")]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x3FB5E14", Offset = "0x3FB5E14", VA = "0x3FB5E14")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x3FB5EDC", Offset = "0x3FB5EDC", VA = "0x3FB5EDC", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004B2")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004B3")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DC")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x3FB6054", Offset = "0x3FB6054", VA = "0x3FB6054")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044990", Offset = "0x1044990")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x3FB6894", Offset = "0x3FB6894", VA = "0x3FB6894")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x3FB695C", Offset = "0x3FB695C", VA = "0x3FB695C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004B8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DE")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x3FB6B78", Offset = "0x3FB6B78", VA = "0x3FB6B78")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044A44", Offset = "0x1044A44")]
	[Preserve]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x3FB765C", Offset = "0x3FB765C", VA = "0x3FB765C")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x3FB7724", Offset = "0x3FB7724", VA = "0x3FB7724", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004BD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044AF8", Offset = "0x1044AF8")]
	[Preserve]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x3FB7964", Offset = "0x3FB7964", VA = "0x3FB7964")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x3FB7A2C", Offset = "0x3FB7A2C", VA = "0x3FB7A2C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004C1")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044C2C", Offset = "0x1044C2C")]
	public class ES3Type_RenderTexture : ES3ObjectType
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x3FB7FAC", Offset = "0x3FB7FAC", VA = "0x3FB7FAC")]
		public ES3Type_RenderTexture()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x3FB8074", Offset = "0x3FB8074", VA = "0x3FB8074", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004C5")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004C6")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E2")]
	public class ES3Type_RenderTextureArray : ES3ArrayType
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x3FB87AC", Offset = "0x3FB87AC", VA = "0x3FB87AC")]
		public ES3Type_RenderTextureArray()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044EA0", Offset = "0x1044EA0")]
	[Preserve]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x3FB93A4", Offset = "0x3FB93A4", VA = "0x3FB93A4")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x3FB946C", Offset = "0x3FB946C", VA = "0x3FB946C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004CB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1044FA4", Offset = "0x1044FA4")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x3FB9994", Offset = "0x3FB9994", VA = "0x3FB9994")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x3FB9A5C", Offset = "0x3FB9A5C", VA = "0x3FB9A5C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004D0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045098", Offset = "0x1045098")]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x3FB9EF0", Offset = "0x3FB9EF0", VA = "0x3FB9EF0")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x3FB9FB8", Offset = "0x3FB9FB8", VA = "0x3FB9FB8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004D5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x3FBA158", Offset = "0x3FBA158", VA = "0x3FBA158")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x104512C", Offset = "0x104512C")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x3FBA250", Offset = "0x3FBA250", VA = "0x3FBA250")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x3FBA318", Offset = "0x3FBA318", VA = "0x3FBA318", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004DB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10452D0", Offset = "0x10452D0")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x3FBAAFC", Offset = "0x3FBAAFC", VA = "0x3FBAAFC")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x3FBABC4", Offset = "0x3FBABC4", VA = "0x3FBABC4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004E0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10453F4", Offset = "0x10453F4")]
	[Preserve]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x3FBB1AC", Offset = "0x3FBB1AC", VA = "0x3FBB1AC")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x3FBB274", Offset = "0x3FBB274", VA = "0x3FBB274", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004E5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045508", Offset = "0x1045508")]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x3FBB7C8", Offset = "0x3FBB7C8", VA = "0x3FBB7C8")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x3FBB890", Offset = "0x3FBB890", VA = "0x3FBB890", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004EA")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x3FBC388", Offset = "0x3FBC388", VA = "0x3FBC388")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10456EC", Offset = "0x10456EC")]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x3FBC8D4", Offset = "0x3FBC8D4", VA = "0x3FBC8D4")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x3FBC99C", Offset = "0x3FBC99C", VA = "0x3FBC99C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004EF")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004F0")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000ED")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10457B0", Offset = "0x10457B0")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x3FBCD90", Offset = "0x3FBCD90", VA = "0x3FBCD90")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x3FBCE58", Offset = "0x3FBCE58", VA = "0x3FBCE58", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004F4")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x3FBD790", Offset = "0x3FBD790", VA = "0x3FBD790")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045964", Offset = "0x1045964")]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x3FBD980", Offset = "0x3FBD980", VA = "0x3FBD980")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x3FBDA48", Offset = "0x3FBDA48", VA = "0x3FBDA48", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004F9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045A08", Offset = "0x1045A08")]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2FCF350", Offset = "0x2FCF350", VA = "0x2FCF350")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2FCF418", Offset = "0x2FCF418", VA = "0x2FCF418", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004FE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004FF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F1")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2FCFD38", Offset = "0x2FCFD38", VA = "0x2FCFD38")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045ACC", Offset = "0x1045ACC")]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2FCF5CC", Offset = "0x2FCF5CC", VA = "0x2FCF5CC")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2FCF6D0", Offset = "0x2FCF6D0", VA = "0x2FCF6D0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000504")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000505")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2FCFBA8", Offset = "0x2FCFBA8", VA = "0x2FCFBA8")]
		protected bool IsReadable(Texture2D instance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F3")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2FCFC40", Offset = "0x2FCFC40", VA = "0x2FCFC40")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045B90", Offset = "0x1045B90")]
	[Preserve]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2FCFE30", Offset = "0x2FCFE30", VA = "0x2FCFE30")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2FCFEF8", Offset = "0x2FCFEF8", VA = "0x2FCFEF8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600050B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045CE4", Offset = "0x1045CE4")]
	[Preserve]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2FD0544", Offset = "0x2FD0544", VA = "0x2FD0544")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2FD060C", Offset = "0x2FD060C", VA = "0x2FD060C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000510")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045E48", Offset = "0x1045E48")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2FD1074", Offset = "0x2FD1074", VA = "0x2FD1074")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2FD113C", Offset = "0x2FD113C", VA = "0x2FD113C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000515")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045F1C", Offset = "0x1045F1C")]
	[Preserve]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2FD16D0", Offset = "0x2FD16D0", VA = "0x2FD16D0")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2FD1798", Offset = "0x2FD1798", VA = "0x2FD1798", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600051A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F8")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2FD1908", Offset = "0x2FD1908", VA = "0x2FD1908")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1045FB0", Offset = "0x1045FB0")]
	[Preserve]
	public class ES3Type_Vector2Int : ES3Type
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2FD1A00", Offset = "0x2FD1A00", VA = "0x2FD1A00")]
		public ES3Type_Vector2Int()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2FD1AC8", Offset = "0x2FD1AC8", VA = "0x2FD1AC8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600051F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FA")]
	public class ES3Type_Vector2IntArray : ES3ArrayType
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2FD1C3C", Offset = "0x2FD1C3C", VA = "0x2FD1C3C")]
		public ES3Type_Vector2IntArray()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1046044", Offset = "0x1046044")]
	[Preserve]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2FD1D34", Offset = "0x2FD1D34", VA = "0x2FD1D34")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x2FD1DFC", Offset = "0x2FD1DFC", VA = "0x2FD1DFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000524")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FC")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2FD1FC4", Offset = "0x2FD1FC4", VA = "0x2FD1FC4")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x10460E8", Offset = "0x10460E8")]
	[Preserve]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2FD20BC", Offset = "0x2FD20BC", VA = "0x2FD20BC")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2FD2184", Offset = "0x2FD2184", VA = "0x2FD2184", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000529")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FE")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2FD2384", Offset = "0x2FD2384", VA = "0x2FD2384")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x104618C", Offset = "0x104618C")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2FD247C", Offset = "0x2FD247C", VA = "0x2FD247C")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2FD2544", Offset = "0x2FD2544", VA = "0x2FD2544", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600052E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2FD275C", Offset = "0x2FD275C", VA = "0x2FD275C")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000100")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2FD27FC", Offset = "0x2FD27FC", VA = "0x2FD27FC")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x1046240", Offset = "0x1046240")]
	[Preserve]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2FD28F4", Offset = "0x2FD28F4", VA = "0x2FD28F4")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2FD29BC", Offset = "0x2FD29BC", VA = "0x2FD29BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000534")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x2000102")]
	internal static class ES3Debug
	{
		[Token(Token = "0x40001CD")]
		private const string disableInfoMsg = "\n<i>To disable these messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Info'</i>";

		[Token(Token = "0x40001CE")]
		private const string disableWarningMsg = "\n<i>To disable warnings from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Warnings'</i>";

		[Token(Token = "0x40001CF")]
		private const string disableErrorMsg = "\n<i>To disable these error messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Errors'</i>";

		[Token(Token = "0x40001D0")]
		private const char indentChar = '-';

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x277B210", Offset = "0x277B210", VA = "0x277B210")]
		public static void Log(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2775884", Offset = "0x2775884", VA = "0x2775884")]
		public static void LogWarning(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2777350", Offset = "0x2777350", VA = "0x2777350")]
		public static void LogError(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x277B3FC", Offset = "0x277B3FC", VA = "0x277B3FC")]
		private static string Indent(int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000103")]
	public static class ES3Hash
	{
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x277D8D8", Offset = "0x277D8D8", VA = "0x277D8D8")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000104")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x600053C")]
		public abstract byte[] Encrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x600053D")]
		public abstract byte[] Decrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x600053E")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x600053F")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2FD8AEC", Offset = "0x2FD8AEC", VA = "0x2FD8AEC")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2FD8BD0", Offset = "0x2FD8BD0", VA = "0x2FD8BD0")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x40001D1")]
		private const int ivSize = 16;

		[Token(Token = "0x40001D2")]
		private const int keySize = 16;

		[Token(Token = "0x40001D3")]
		private const int pwIterations = 100;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x276AFD0", Offset = "0x276AFD0", VA = "0x276AFD0", Slot = "4")]
		public override byte[] Encrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x276B240", Offset = "0x276B240", VA = "0x276B240", Slot = "5")]
		public override byte[] Decrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x276B4B0", Offset = "0x276B4B0", VA = "0x276B4B0", Slot = "6")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x276B908", Offset = "0x276B908", VA = "0x276B908", Slot = "7")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x276BD48", Offset = "0x276BD48", VA = "0x276BD48")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool disposed;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2FDD488", Offset = "0x2FDD488", VA = "0x2FDD488")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2FDD530", Offset = "0x2FDD530", VA = "0x2FDD530", Slot = "18")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000107")]
	public struct ES3Data
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x277B140", Offset = "0x277B140", VA = "0x277B140")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x277B208", Offset = "0x277B208", VA = "0x277B208")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x2000108")]
	public static class ES3IO
	{
		[Token(Token = "0x2000109")]
		public enum ES3FileMode
		{
			[Token(Token = "0x40001E0")]
			Read,
			[Token(Token = "0x40001E1")]
			Write,
			[Token(Token = "0x40001E2")]
			Append
		}

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly string persistentDataPath;

		[Token(Token = "0x40001DD")]
		internal const string backupFileSuffix = ".bac";

		[Token(Token = "0x40001DE")]
		internal const string temporaryFileSuffix = ".tmp";

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2773238", Offset = "0x2773238", VA = "0x2773238")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x276D848", Offset = "0x276D848", VA = "0x276D848")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x276F4E4", Offset = "0x276F4E4", VA = "0x276F4E4")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x276FB60", Offset = "0x276FB60", VA = "0x276FB60")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x27704E0", Offset = "0x27704E0", VA = "0x27704E0")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x276FB68", Offset = "0x276FB68", VA = "0x276FB68")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2771058", Offset = "0x2771058", VA = "0x2771058")]
		public static void MoveDirectory(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x2770A28", Offset = "0x2770A28", VA = "0x2770A28")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2770FCC", Offset = "0x2770FCC", VA = "0x2770FCC")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x277D788", Offset = "0x277D788", VA = "0x277D788")]
		public static string GetDirectoryPath(string path, char seperator = '/')
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x277E644", Offset = "0x277E644", VA = "0x277E644")]
		public static bool UsesForwardSlash(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2770B54", Offset = "0x2770B54", VA = "0x2770B54")]
		public static string CombinePathAndFilename(string directoryPath, string fileOrDirectoryName)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2772A80", Offset = "0x2772A80", VA = "0x2772A80")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2770FD4", Offset = "0x2770FD4", VA = "0x2770FD4")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x277283C", Offset = "0x277283C", VA = "0x277283C")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x277E69C", Offset = "0x277E69C", VA = "0x277E69C")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x277E6A4", Offset = "0x277E6A4", VA = "0x277E6A4")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x276C828", Offset = "0x276C828", VA = "0x276C828")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2783600", Offset = "0x2783600", VA = "0x2783600")]
		public void Awake()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x27837E4", Offset = "0x27837E4", VA = "0x27837E4")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2783860", Offset = "0x2783860", VA = "0x2783860")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2783998", Offset = "0x2783998", VA = "0x2783998")]
		public Dictionary<string, string> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2783C00", Offset = "0x2783C00", VA = "0x2783C00")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2783940", Offset = "0x2783940", VA = "0x2783940")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x27841CC", Offset = "0x27841CC", VA = "0x27841CC")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010B")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1046344", Offset = "0x1046344")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Object obj;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__0;

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x2FDFA20", Offset = "0x2FDFA20", VA = "0x2FDFA20")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x2FDFA28", Offset = "0x2FDFA28", VA = "0x2FDFA28")]
			internal bool <Remove>b__0(KeyValuePair<long, UnityEngine.Object> kvp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1046354", Offset = "0x1046354")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long referenceID;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<UnityEngine.Object, long>, bool> <>9__0;

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x2FDFAAC", Offset = "0x2FDFAAC", VA = "0x2FDFAAC")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x2FDFAB4", Offset = "0x2FDFAB4", VA = "0x2FDFAB4")]
			internal bool <Remove>b__0(KeyValuePair<UnityEngine.Object, long> kvp)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1046364", Offset = "0x1046364")]
		private sealed class <>c
		{
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__31_0;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, long> <>9__31_1;

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x2FDF914", Offset = "0x2FDF914", VA = "0x2FDF914")]
			public <>c()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x2FDF91C", Offset = "0x2FDF91C", VA = "0x2FDF91C")]
			internal bool <RemoveNullOrInvalidValues>b__31_0(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x2FDF9E0", Offset = "0x2FDF9E0", VA = "0x2FDF9E0")]
			internal long <RemoveNullOrInvalidValues>b__31_1(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(long);
			}
		}

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _lock;

		[Token(Token = "0x40001E6")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HashSet<ES3ReferenceMgrBase> mgrs;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Random rng;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ES3RefIdDictionary _refId;

		[Token(Token = "0x1700003A")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x277AAC8", Offset = "0x277AAC8", VA = "0x277AAC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public bool IsInitialised
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x27859DC", Offset = "0x27859DC", VA = "0x27859DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public ES3RefIdDictionary refId
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x2785A3C", Offset = "0x2785A3C", VA = "0x2785A3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x2785C20", Offset = "0x2785C20", VA = "0x2785C20")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public ES3GlobalReferences GlobalReferences
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x2785C28", Offset = "0x2785C28", VA = "0x2785C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2785C30", Offset = "0x2785C30", VA = "0x2785C30")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x2786010", Offset = "0x2786010", VA = "0x2786010")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2785ED4", Offset = "0x2785ED4", VA = "0x2785ED4")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x278609C", Offset = "0x278609C", VA = "0x278609C")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x27862E8", Offset = "0x27862E8", VA = "0x27862E8")]
		internal UnityEngine.Object Get(long id, Type type, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2786830", Offset = "0x2786830", VA = "0x2786830")]
		public UnityEngine.Object Get(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x278683C", Offset = "0x278683C", VA = "0x278683C")]
		public ES3Prefab GetPrefab(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2786C38", Offset = "0x2786C38", VA = "0x2786C38")]
		public long GetPrefab(ES3Prefab prefabToFind, bool suppressWarnings = false)
		{
			return default(long);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x277ADC8", Offset = "0x277ADC8", VA = "0x277ADC8")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x2783E38", Offset = "0x2783E38", VA = "0x2783E38")]
		public long Add(UnityEngine.Object obj, long id)
		{
			return default(long);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2787044", Offset = "0x2787044", VA = "0x2787044")]
		public bool AddPrefab(ES3Prefab prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x27870E4", Offset = "0x27870E4", VA = "0x27870E4")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x27875E0", Offset = "0x27875E0", VA = "0x27875E0")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2787AEC", Offset = "0x2787AEC", VA = "0x2787AEC")]
		public void RemoveNullOrInvalidValues()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x2787E58", Offset = "0x2787E58", VA = "0x2787E58")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x2787F84", Offset = "0x2787F84", VA = "0x2787F84")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x2787FEC", Offset = "0x2787FEC", VA = "0x2787FEC")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x2788050", Offset = "0x2788050", VA = "0x2788050")]
		public void ChangeId(long oldId, long newId)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x2784024", Offset = "0x2784024", VA = "0x2784024")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x2783938", Offset = "0x2783938", VA = "0x2783938")]
		internal static bool CanBeSaved(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2785910", Offset = "0x2785910", VA = "0x2785910")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x277E700", Offset = "0x277E700", VA = "0x277E700", Slot = "47")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x277E70C", Offset = "0x277E70C", VA = "0x277E70C", Slot = "48")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x277E780", Offset = "0x277E780", VA = "0x277E780")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046374", Offset = "0x1046374")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2785830", Offset = "0x2785830", VA = "0x2785830", Slot = "47")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x27858A4", Offset = "0x27858A4", VA = "0x27858A4", Slot = "48")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2784234", Offset = "0x2784234", VA = "0x2784234")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public static class ES3Reflection
	{
		[Token(Token = "0x2000112")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x1700003F")]
			public bool IsNull
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0x2FD77C8", Offset = "0x2FD77C8", VA = "0x2FD77C8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000040")]
			public string Name
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0x2FDFD40", Offset = "0x2FDFD40", VA = "0x2FDFD40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000041")]
			public Type MemberType
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0x2FD7864", Offset = "0x2FD7864", VA = "0x2FD7864")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000042")]
			public bool IsPublic
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x2FDFD74", Offset = "0x2FDFD74", VA = "0x2FDFD74")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000043")]
			public bool IsProtected
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x2FDFE14", Offset = "0x2FDFE14", VA = "0x2FDFE14")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000044")]
			public bool IsStatic
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x2FDFE68", Offset = "0x2FDFE68", VA = "0x2FDFE68")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2FDFEBC", Offset = "0x2FDFEBC", VA = "0x2FDFEBC")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x2FE004C", Offset = "0x2FE004C", VA = "0x2FE004C")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x2FD7814", Offset = "0x2FD7814", VA = "0x2FD7814")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x2000113")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x2FE0094", Offset = "0x2FE0094", VA = "0x2FE0094")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x2FE0110", Offset = "0x2FE0110", VA = "0x2FE0110")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes, BindingFlags bindingAttr)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x2FE019C", Offset = "0x2FE019C", VA = "0x2FE019C")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1046388", Offset = "0x1046388")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x2FDFC60", Offset = "0x2FDFC60", VA = "0x2FDFC60")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x2FDFC68", Offset = "0x2FDFC68", VA = "0x2FDFC68")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1046398", Offset = "0x1046398")]
		private sealed class <>c
		{
			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__27_0;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, <>f__AnonymousType0<Assembly, Type>> <>9__27_1;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType0<Assembly, Type>, Type> <>9__27_3;

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x2FDFB68", Offset = "0x2FDFB68", VA = "0x2FDFB68")]
			public <>c()
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2FDFB70", Offset = "0x2FDFB70", VA = "0x2FDFB70")]
			internal IEnumerable<Type> <GetDerivedTypes>b__27_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x2FDFB94", Offset = "0x2FDFB94", VA = "0x2FDFB94")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__27_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x2FDFC18", Offset = "0x2FDFC18", VA = "0x2FDFC18")]
			internal Type <GetDerivedTypes>b__27_3(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10463A8", Offset = "0x10463A8")]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string methodName;

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x2FDFCF8", Offset = "0x2FDFCF8", VA = "0x2FDFCF8")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x2FDFD00", Offset = "0x2FDFD00", VA = "0x2FDFD00")]
			internal bool <GetMethods>b__0(MethodInfo t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001F5")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x40001F6")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x40001F7")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] excludedPropertyNames;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Type es3SerializableAttributeType;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Type es3NonSerializableAttributeType;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x1700003E")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x278886C", Offset = "0x278886C", VA = "0x278886C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x277A164", Offset = "0x277A164", VA = "0x277A164")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2788B94", Offset = "0x2788B94", VA = "0x2788B94")]
		public static List<FieldInfo> GetSerializableFields(Type type, [Optional] List<FieldInfo> serializableFields, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2789574", Offset = "0x2789574", VA = "0x2789574")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, [Optional] List<PropertyInfo> serializableProperties, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x27891EC", Offset = "0x27891EC", VA = "0x27891EC")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x277BCD0", Offset = "0x277BCD0", VA = "0x277BCD0")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x277E450", Offset = "0x277E450", VA = "0x277E450")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2775204", Offset = "0x2775204", VA = "0x2775204")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2774190", Offset = "0x2774190", VA = "0x2774190")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x277E394", Offset = "0x277E394", VA = "0x277E394")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2789E60", Offset = "0x2789E60", VA = "0x2789E60")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2785314", Offset = "0x2785314", VA = "0x2785314")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x278553C", Offset = "0x278553C", VA = "0x278553C")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x600059B")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x278A444", Offset = "0x278A444", VA = "0x278A444")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x27887CC", Offset = "0x27887CC", VA = "0x27887CC")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x278A804", Offset = "0x278A804", VA = "0x278A804")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x277E374", Offset = "0x277E374", VA = "0x277E374")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x278A824", Offset = "0x278A824", VA = "0x278A824")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x278A844", Offset = "0x278A844", VA = "0x278A844")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x278A864", Offset = "0x278A864", VA = "0x278A864")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2789D40", Offset = "0x2789D40", VA = "0x2789D40")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2788B74", Offset = "0x2788B74", VA = "0x2788B74")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x278A8EC", Offset = "0x278A8EC", VA = "0x278A8EC")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x278A904", Offset = "0x278A904", VA = "0x278A904")]
		public static bool IsInterface(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2788B54", Offset = "0x2788B54", VA = "0x2788B54")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2789D28", Offset = "0x2789D28", VA = "0x2789D28")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x278A91C", Offset = "0x278A91C", VA = "0x278A91C")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2789D58", Offset = "0x2789D58", VA = "0x2789D58")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x278A93C", Offset = "0x278A93C", VA = "0x278A93C")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x278A9B4", Offset = "0x278A9B4", VA = "0x278A9B4")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x278A184", Offset = "0x278A184", VA = "0x278A184")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x278A2E0", Offset = "0x278A2E0", VA = "0x278A2E0")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x278AAA0", Offset = "0x278AAA0", VA = "0x278AAA0")]
		public static MethodInfo[] GetMethods(Type type, string methodName)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2789C18", Offset = "0x2789C18", VA = "0x2789C18")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x27891E0", Offset = "0x27891E0", VA = "0x27891E0")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2789BF4", Offset = "0x2789BF4", VA = "0x2789BF4")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x278ABBC", Offset = "0x278ABBC", VA = "0x278ABBC")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x27831B0", Offset = "0x27831B0", VA = "0x27831B0")]
		public static Type BaseType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x277F12C", Offset = "0x277F12C", VA = "0x277F12C")]
		public static Type GetType(string typeString)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x278AC64", Offset = "0x278AC64", VA = "0x278AC64")]
		public static string GetTypeString(Type type)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000117")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10463B8", Offset = "0x10463B8")]
		private sealed class <>c
		{
			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, bool> <>9__6_0;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, TKey> <>9__6_1;

			[Token(Token = "0x60005D5")]
			public <>c()
			{
			}

			[Token(Token = "0x60005D6")]
			internal bool <RemoveNullValues>b__6_0(KeyValuePair<TKey, TVal> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x60005D7")]
			internal TKey <RemoveNullValues>b__6_1(KeyValuePair<TKey, TVal> pair)
			{
				return (TKey)null;
			}
		}

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x60005CD")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x60005CE")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x60005CF")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60005D0")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60005D1")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x60005D2")]
		public bool ChangeKey(TKey oldKey, TKey newKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x4000210")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamReader baseReader;

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x277E7D4", Offset = "0x277E7D4", VA = "0x277E7D4")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x277EA14", Offset = "0x277EA14", VA = "0x277EA14", Slot = "21")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x277EF8C", Offset = "0x277EF8C", VA = "0x277EF8C", Slot = "22")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x277FBCC", Offset = "0x277FBCC", VA = "0x277FBCC", Slot = "23")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x277FBDC", Offset = "0x277FBDC", VA = "0x277FBDC", Slot = "27")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x277FEE4", Offset = "0x277FEE4", VA = "0x277FEE4", Slot = "28")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x277FF24", Offset = "0x277FF24", VA = "0x277FF24", Slot = "29")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x277FF34", Offset = "0x277FF34", VA = "0x277FF34", Slot = "30")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x277FF38", Offset = "0x277FF38", VA = "0x277FF38", Slot = "31")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x277FF7C", Offset = "0x277FF7C", VA = "0x277FF7C", Slot = "32")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x277FF84", Offset = "0x277FF84", VA = "0x277FF84", Slot = "33")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x277FF88", Offset = "0x277FF88", VA = "0x277FF88", Slot = "34")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2780050", Offset = "0x2780050", VA = "0x2780050", Slot = "35")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2780058", Offset = "0x2780058", VA = "0x2780058", Slot = "36")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x278005C", Offset = "0x278005C", VA = "0x278005C", Slot = "37")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x27800A0", Offset = "0x27800A0", VA = "0x27800A0", Slot = "38")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2780168", Offset = "0x2780168", VA = "0x2780168")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x27802A8", Offset = "0x27802A8", VA = "0x27802A8", Slot = "24")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2780240", Offset = "0x2780240", VA = "0x2780240")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x277EC74", Offset = "0x277EC74", VA = "0x277EC74")]
		private char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
		{
			return default(char);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x277FC04", Offset = "0x277FC04", VA = "0x277FC04")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x277ED80", Offset = "0x277ED80", VA = "0x277ED80")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2780824", Offset = "0x2780824", VA = "0x2780824")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2780A0C", Offset = "0x2780A0C", VA = "0x2780A0C")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x277EBE0", Offset = "0x277EBE0", VA = "0x277EBE0")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2780C14", Offset = "0x2780C14", VA = "0x2780C14")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x277E960", Offset = "0x277E960", VA = "0x277E960")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x27807EC", Offset = "0x27807EC", VA = "0x27807EC")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2780768", Offset = "0x2780768", VA = "0x2780768")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x278077C", Offset = "0x278077C", VA = "0x278077C")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x277EC60", Offset = "0x277EC60", VA = "0x277EC60")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x277ED54", Offset = "0x277ED54", VA = "0x277ED54")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2780C94", Offset = "0x2780C94", VA = "0x2780C94")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2780CA4", Offset = "0x2780CA4", VA = "0x2780CA4")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2780D7C", Offset = "0x2780D7C", VA = "0x2780D7C", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2780F40", Offset = "0x2780F40", VA = "0x2780F40", Slot = "20")]
		internal override long Read_ref()
		{
			return default(long);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2781084", Offset = "0x2781084", VA = "0x2781084", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x2781104", Offset = "0x2781104", VA = "0x2781104", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x2781184", Offset = "0x2781184", VA = "0x2781184", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x278119C", Offset = "0x278119C", VA = "0x278119C", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2781210", Offset = "0x2781210", VA = "0x2781210", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x27812C4", Offset = "0x27812C4", VA = "0x27812C4", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x2781378", Offset = "0x2781378", VA = "0x2781378", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2781390", Offset = "0x2781390", VA = "0x2781390", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x27813A8", Offset = "0x27813A8", VA = "0x27813A8", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x27813C0", Offset = "0x27813C0", VA = "0x27813C0", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x27813DC", Offset = "0x27813DC", VA = "0x27813DC", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x27813F8", Offset = "0x27813F8", VA = "0x27813F8", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x2781414", Offset = "0x2781414", VA = "0x2781414", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2781430", Offset = "0x2781430", VA = "0x2781430", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x27814B0", Offset = "0x27814B0", VA = "0x27814B0", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class ES3GlobalReferences : ScriptableObject
	{
		[Token(Token = "0x17000045")]
		public static ES3GlobalReferences Instance
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x277D8B4", Offset = "0x277D8B4", VA = "0x277D8B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x277D8BC", Offset = "0x277D8BC", VA = "0x277D8BC")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x277D8C4", Offset = "0x277D8C4", VA = "0x277D8C4")]
		public long GetOrAdd(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x277D8CC", Offset = "0x277D8CC", VA = "0x277D8CC")]
		public void RemoveInvalidKeys()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x277D8D0", Offset = "0x277D8D0", VA = "0x277D8D0")]
		public ES3GlobalReferences()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoUpdateReferences;

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x277B464", Offset = "0x277B464", VA = "0x277B464")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public enum ES3FileMode
	{
		[Token(Token = "0x4000215")]
		Read,
		[Token(Token = "0x4000216")]
		Write,
		[Token(Token = "0x4000217")]
		Append
	}
	[Token(Token = "0x200011D")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x277D57C", Offset = "0x277D57C", VA = "0x277D57C")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x277D64C", Offset = "0x277D64C", VA = "0x277D64C")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x277D758", Offset = "0x277D758", VA = "0x277D758")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x277D778", Offset = "0x277D778", VA = "0x277D778")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x277D894", Offset = "0x277D894", VA = "0x277D894", Slot = "18")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x200011E")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x27831D0", Offset = "0x27831D0", VA = "0x27831D0")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x2783308", Offset = "0x2783308", VA = "0x2783308")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2783214", Offset = "0x2783214", VA = "0x2783214")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2783354", Offset = "0x2783354", VA = "0x2783354", Slot = "18")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x200011F")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x17000046")]
		public bool Exists
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x396E09C", Offset = "0x396E09C", VA = "0x396E09C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x396E0C0", Offset = "0x396E0C0", VA = "0x396E0C0")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x396E0F0", Offset = "0x396E0F0", VA = "0x396E0F0")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x396E1F0", Offset = "0x396E1F0", VA = "0x396E1F0", Slot = "18")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000120")]
	public static class ES3Stream
	{
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x396FF90", Offset = "0x396FF90", VA = "0x396FF90")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x3971F94", Offset = "0x3971F94", VA = "0x3971F94")]
		public static Stream CreateStream(Stream stream, ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x3972374", Offset = "0x3972374", VA = "0x3972374")]
		public static void CopyTo(Stream source, Stream destination)
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class ES3Member
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2782F10", Offset = "0x2782F10", VA = "0x2782F10")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2782F54", Offset = "0x2782F54", VA = "0x2782F54")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x2000122")]
	[Preserve]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1046594", Offset = "0x1046594")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ES3Type lastAccessedType;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x396FC18", Offset = "0x396FC18", VA = "0x396FC18")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x39751F8", Offset = "0x39751F8", VA = "0x39751F8")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x3972450", Offset = "0x3972450", VA = "0x3972450")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x3974784", Offset = "0x3974784", VA = "0x3974784")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x397451C", Offset = "0x397451C", VA = "0x397451C")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class ES3WebClass
	{
		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10463D8", Offset = "0x10463D8")]
		private sealed class <SendWebRequest>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3WebClass <>4__this;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x1700004A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x2FE0368", Offset = "0x2FE0368", VA = "0x2FE0368", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x2FE03B0", Offset = "0x2FE03B0", VA = "0x2FE03B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x2FD6620", Offset = "0x2FD6620", VA = "0x2FD6620")]
			[DebuggerHidden]
			public <SendWebRequest>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x2FE02F0", Offset = "0x2FE02F0", VA = "0x2FE02F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x2FE02F4", Offset = "0x2FE02F4", VA = "0x2FE02F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2FE0370", Offset = "0x2FE0370", VA = "0x2FE0370", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityWebRequest _webRequest;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isDone;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string error;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long errorCode;

		[Token(Token = "0x17000047")]
		public float uploadProgress
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x2FD6004", Offset = "0x2FD6004", VA = "0x2FD6004")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000048")]
		public float downloadProgress
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x2FD601C", Offset = "0x2FD601C", VA = "0x2FD601C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000049")]
		public bool isError
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x2FD6034", Offset = "0x2FD6034", VA = "0x2FD6034")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x2FD6074", Offset = "0x2FD6074", VA = "0x2FD6074")]
		public static bool IsNetworkError(UnityWebRequest www)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2FD609C", Offset = "0x2FD609C", VA = "0x2FD609C")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x2FD612C", Offset = "0x2FD612C", VA = "0x2FD612C")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x2FD61D0", Offset = "0x2FD61D0", VA = "0x2FD61D0")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x2FD6270", Offset = "0x2FD6270", VA = "0x2FD6270")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x2FD63D0", Offset = "0x2FD63D0", VA = "0x2FD63D0")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2FD65A8", Offset = "0x2FD65A8", VA = "0x2FD65A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10475A8", Offset = "0x10475A8")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2FD664C", Offset = "0x2FD664C", VA = "0x2FD664C", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x2000125")]
	internal enum ES3SpecialByte : byte
	{
		[Token(Token = "0x4000231")]
		Null = 0,
		[Token(Token = "0x4000232")]
		Bool = 1,
		[Token(Token = "0x4000233")]
		Byte = 2,
		[Token(Token = "0x4000234")]
		Sbyte = 3,
		[Token(Token = "0x4000235")]
		Char = 4,
		[Token(Token = "0x4000236")]
		Decimal = 5,
		[Token(Token = "0x4000237")]
		Double = 6,
		[Token(Token = "0x4000238")]
		Float = 7,
		[Token(Token = "0x4000239")]
		Int = 8,
		[Token(Token = "0x400023A")]
		Uint = 9,
		[Token(Token = "0x400023B")]
		Long = 10,
		[Token(Token = "0x400023C")]
		Ulong = 11,
		[Token(Token = "0x400023D")]
		Short = 12,
		[Token(Token = "0x400023E")]
		Ushort = 13,
		[Token(Token = "0x400023F")]
		String = 14,
		[Token(Token = "0x4000240")]
		ByteArray = 15,
		[Token(Token = "0x4000241")]
		Collection = 128,
		[Token(Token = "0x4000242")]
		Dictionary = 129,
		[Token(Token = "0x4000243")]
		CollectionItem = 130,
		[Token(Token = "0x4000244")]
		Object = 254,
		[Token(Token = "0x4000245")]
		Terminator = byte.MaxValue
	}
	[Token(Token = "0x2000126")]
	internal static class ES3Binary
	{
		[Token(Token = "0x4000246")]
		internal const string ObjectTerminator = ".";

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<ES3SpecialByte, Type> IdToType;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<Type, ES3SpecialByte> TypeToId;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x27769BC", Offset = "0x27769BC", VA = "0x27769BC")]
		internal static ES3SpecialByte TypeToByte(Type type)
		{
			return default(ES3SpecialByte);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x2776A6C", Offset = "0x2776A6C", VA = "0x2776A6C")]
		internal static Type ByteToType(ES3SpecialByte b)
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x2776ACC", Offset = "0x2776ACC", VA = "0x2776ACC")]
		internal static Type ByteToType(byte b)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2776BC8", Offset = "0x2776BC8", VA = "0x2776BC8")]
		internal static bool IsPrimitive(ES3SpecialByte b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000127")]
	internal class ES3CacheWriter : ES3Writer
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ES3File es3File;

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2777268", Offset = "0x2777268", VA = "0x2777268")]
		internal ES3CacheWriter(ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000640")]
		public override void Write<T>(string key, object value)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2777304", Offset = "0x2777304", VA = "0x2777304", Slot = "39")]
		internal override void Write(string key, Type type, byte[] value)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2777534", Offset = "0x2777534", VA = "0x2777534", Slot = "41")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1047658", Offset = "0x1047658")]
		public override void Write(Type type, string key, object value)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x27775A0", Offset = "0x27775A0", VA = "0x27775A0", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x27775A4", Offset = "0x27775A4", VA = "0x27775A4", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x27775A8", Offset = "0x27775A8", VA = "0x27775A8", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x27775AC", Offset = "0x27775AC", VA = "0x27775AC", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x27775B0", Offset = "0x27775B0", VA = "0x27775B0", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x27775B4", Offset = "0x27775B4", VA = "0x27775B4", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x27775B8", Offset = "0x27775B8", VA = "0x27775B8", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x27775BC", Offset = "0x27775BC", VA = "0x27775BC", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x27775C0", Offset = "0x27775C0", VA = "0x27775C0", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x27775C4", Offset = "0x27775C4", VA = "0x27775C4", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x27775C8", Offset = "0x27775C8", VA = "0x27775C8", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x27775CC", Offset = "0x27775CC", VA = "0x27775CC", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x27775D0", Offset = "0x27775D0", VA = "0x27775D0", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x27775D4", Offset = "0x27775D4", VA = "0x27775D4", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x27775D8", Offset = "0x27775D8", VA = "0x27775D8", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x27775DC", Offset = "0x27775DC", VA = "0x27775DC", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x27775E0", Offset = "0x27775E0", VA = "0x27775E0")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x27775E8", Offset = "0x27775E8", VA = "0x27775E8")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x27775EC", Offset = "0x27775EC", VA = "0x27775EC", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x27775F0", Offset = "0x27775F0", VA = "0x27775F0", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x27775F4", Offset = "0x27775F4", VA = "0x27775F4", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x27775F8", Offset = "0x27775F8", VA = "0x27775F8", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2777600", Offset = "0x2777600", VA = "0x2777600", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2777604", Offset = "0x2777604", VA = "0x2777604", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2777608", Offset = "0x2777608", VA = "0x2777608", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x277760C", Offset = "0x277760C", VA = "0x277760C", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2777610", Offset = "0x2777610", VA = "0x2777610", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2777614", Offset = "0x2777614", VA = "0x2777614", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2777618", Offset = "0x2777618", VA = "0x2777618", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x277761C", Offset = "0x277761C", VA = "0x277761C", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x2777620", Offset = "0x2777620", VA = "0x2777620", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x2777624", Offset = "0x2777624", VA = "0x2777624", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x2777628", Offset = "0x2777628", VA = "0x2777628", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x277762C", Offset = "0x277762C", VA = "0x277762C", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x2777630", Offset = "0x2777630", VA = "0x2777630", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x2777634", Offset = "0x2777634", VA = "0x2777634", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000128")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x27814CC", Offset = "0x27814CC", VA = "0x27814CC")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x27814D8", Offset = "0x27814D8", VA = "0x27814D8")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2781584", Offset = "0x2781584", VA = "0x2781584", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x27815A8", Offset = "0x27815A8", VA = "0x27815A8", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2781664", Offset = "0x2781664", VA = "0x2781664", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x27816EC", Offset = "0x27816EC", VA = "0x27816EC", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x2781790", Offset = "0x2781790", VA = "0x2781790", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x278184C", Offset = "0x278184C", VA = "0x278184C", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2781870", Offset = "0x2781870", VA = "0x2781870", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2781894", Offset = "0x2781894", VA = "0x2781894", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x27818B8", Offset = "0x27818B8", VA = "0x27818B8", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x278194C", Offset = "0x278194C", VA = "0x278194C", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x27819E0", Offset = "0x27819E0", VA = "0x27819E0", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x2781A74", Offset = "0x2781A74", VA = "0x2781A74", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x2781B08", Offset = "0x2781B08", VA = "0x2781B08", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x2781B4C", Offset = "0x2781B4C", VA = "0x2781B4C", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x2781BD4", Offset = "0x2781BD4", VA = "0x2781BD4", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2781E0C", Offset = "0x2781E0C", VA = "0x2781E0C", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x2781E6C", Offset = "0x2781E6C", VA = "0x2781E6C")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x2781EA0", Offset = "0x2781EA0", VA = "0x2781EA0")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x2781F84", Offset = "0x2781F84", VA = "0x2781F84", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x2782020", Offset = "0x2782020", VA = "0x2782020", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x278206C", Offset = "0x278206C", VA = "0x278206C", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x27820C8", Offset = "0x27820C8", VA = "0x27820C8", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x2782194", Offset = "0x2782194", VA = "0x2782194", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x278219C", Offset = "0x278219C", VA = "0x278219C", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x27821E4", Offset = "0x27821E4", VA = "0x27821E4", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2782230", Offset = "0x2782230", VA = "0x2782230", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x2782278", Offset = "0x2782278", VA = "0x2782278", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x27822C0", Offset = "0x27822C0", VA = "0x27822C0", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x27822F0", Offset = "0x27822F0", VA = "0x27822F0", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x27822F4", Offset = "0x27822F4", VA = "0x27822F4", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2782304", Offset = "0x2782304", VA = "0x2782304", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2782314", Offset = "0x2782314", VA = "0x2782314", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x2782344", Offset = "0x2782344", VA = "0x2782344", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x278236C", Offset = "0x278236C", VA = "0x278236C", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2782370", Offset = "0x2782370", VA = "0x2782370", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x2782374", Offset = "0x2782374", VA = "0x2782374", Slot = "22")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x2781EF0", Offset = "0x2781EF0", VA = "0x2781EF0")]
		public void WriteNewlineAndTabs()
		{
		}
	}
}
