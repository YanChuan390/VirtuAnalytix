using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using ES3Internal;
using ES3Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Networking;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612FE8", Offset = "0x612FE8")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x61A5EC", Offset = "0x61A5EC")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x61A600", Offset = "0x61A600")]
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
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x612FF8", Offset = "0x612FF8")]
public class ES3Serializable : Attribute
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x13C98F8", Offset = "0x13C98F8", VA = "0x13C98F8")]
	public ES3Serializable()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61300C", Offset = "0x61300C")]
public class ES3NonSerializable : Attribute
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x13BE35C", Offset = "0x13BE35C", VA = "0x13BE35C")]
	public ES3NonSerializable()
	{
	}
}
[Token(Token = "0x2000005")]
public class ES3AutoSave : MonoBehaviour, ISerializationCallbackReceiver
{
	[Serializable]
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613020", Offset = "0x613020")]
	private sealed class <>c
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Component> <>9__7_0;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x11F7838", Offset = "0x11F7838", VA = "0x11F7838")]
		public <>c()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x11F7840", Offset = "0x11F7840", VA = "0x11F7840")]
		internal bool <OnAfterDeserialize>b__7_0(Component c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool saveChildren;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool isQuitting;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Component> componentsToSave;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9FCD28", Offset = "0x9FCD28", VA = "0x9FCD28")]
	public void Awake()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9FD1DC", Offset = "0x9FD1DC", VA = "0x9FD1DC")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9FD1E8", Offset = "0x9FD1E8", VA = "0x9FD1E8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9FD364", Offset = "0x9FD364", VA = "0x9FD364", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x9FD368", Offset = "0x9FD368", VA = "0x9FD368", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9FD494", Offset = "0x9FD494", VA = "0x9FD494")]
	public ES3AutoSave()
	{
	}
}
[Token(Token = "0x2000007")]
public class ES3AutoSaveMgr : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	public enum LoadEvent
	{
		[Token(Token = "0x400000F")]
		None,
		[Token(Token = "0x4000010")]
		Awake,
		[Token(Token = "0x4000011")]
		Start
	}

	[Token(Token = "0x2000009")]
	public enum SaveEvent
	{
		[Token(Token = "0x4000013")]
		None,
		[Token(Token = "0x4000014")]
		OnApplicationQuit,
		[Token(Token = "0x4000015")]
		OnApplicationPause
	}

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ES3AutoSaveMgr _current;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveEvent saveEvent;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LoadEvent loadEvent;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ES3SerializableSettings settings;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HashSet<ES3AutoSave> autoSaves;

	[Token(Token = "0x17000003")]
	public static ES3AutoSaveMgr Current
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x9FCE24", Offset = "0x9FCE24", VA = "0x9FCE24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public static ES3AutoSaveMgr Instance
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x9FD518", Offset = "0x9FD518", VA = "0x9FD518")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x9FD570", Offset = "0x9FD570", VA = "0x9FD570")]
	public void Save()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x9FD810", Offset = "0x9FD810", VA = "0x9FD810")]
	public void Load()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x9FD8B8", Offset = "0x9FD8B8", VA = "0x9FD8B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x9FD8CC", Offset = "0x9FD8CC", VA = "0x9FD8CC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x9FDA7C", Offset = "0x9FDA7C", VA = "0x9FDA7C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x9FDA90", Offset = "0x9FDA90", VA = "0x9FDA90")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x9FD0D4", Offset = "0x9FD0D4", VA = "0x9FD0D4")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x9FD25C", Offset = "0x9FD25C", VA = "0x9FD25C")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9FDAFC", Offset = "0x9FDAFC", VA = "0x9FDAFC")]
	public ES3AutoSaveMgr()
	{
	}
}
[Token(Token = "0x200000A")]
public static class ES3
{
	[Token(Token = "0x200000B")]
	public enum Location
	{
		[Token(Token = "0x4000017")]
		File,
		[Token(Token = "0x4000018")]
		PlayerPrefs,
		[Token(Token = "0x4000019")]
		InternalMS,
		[Token(Token = "0x400001A")]
		Resources,
		[Token(Token = "0x400001B")]
		Cache
	}

	[Token(Token = "0x200000C")]
	public enum Directory
	{
		[Token(Token = "0x400001D")]
		PersistentDataPath,
		[Token(Token = "0x400001E")]
		DataPath
	}

	[Token(Token = "0x200000D")]
	public enum EncryptionType
	{
		[Token(Token = "0x4000020")]
		None,
		[Token(Token = "0x4000021")]
		AES
	}

	[Token(Token = "0x200000E")]
	public enum CompressionType
	{
		[Token(Token = "0x4000023")]
		None,
		[Token(Token = "0x4000024")]
		Gzip
	}

	[Token(Token = "0x200000F")]
	public enum Format
	{
		[Token(Token = "0x4000026")]
		JSON
	}

	[Token(Token = "0x2000010")]
	public enum ReferenceMode
	{
		[Token(Token = "0x4000028")]
		ByRef,
		[Token(Token = "0x4000029")]
		ByValue,
		[Token(Token = "0x400002A")]
		ByRefAndValue
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x9F3144", Offset = "0x9F3144", VA = "0x9F3144")]
	public static void Save(string key, object value)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x9F31D4", Offset = "0x9F31D4", VA = "0x9F31D4")]
	public static void Save(string key, object value, string filePath)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x9F3268", Offset = "0x9F3268", VA = "0x9F3268")]
	public static void Save(string key, object value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9F3308", Offset = "0x9F3308", VA = "0x9F3308")]
	public static void Save(string key, object value, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000022")]
	public static void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x6000023")]
	public static void Save<T>(string key, T value, string filePath)
	{
	}

	[Token(Token = "0x6000024")]
	public static void Save<T>(string key, T value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000025")]
	public static void Save<T>(string key, T value, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x9F34A0", Offset = "0x9F34A0", VA = "0x9F34A0")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x9F3704", Offset = "0x9F3704", VA = "0x9F3704")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9F3778", Offset = "0x9F3778", VA = "0x9F3778")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9F3508", Offset = "0x9F3508", VA = "0x9F3508")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9F41BC", Offset = "0x9F41BC", VA = "0x9F41BC")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9F4268", Offset = "0x9F4268", VA = "0x9F4268")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9F42DC", Offset = "0x9F42DC", VA = "0x9F42DC")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x9F4224", Offset = "0x9F4224", VA = "0x9F4224")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9F4354", Offset = "0x9F4354", VA = "0x9F4354")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9F45C0", Offset = "0x9F45C0", VA = "0x9F45C0")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9F43BC", Offset = "0x9F43BC", VA = "0x9F43BC")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9F46B8", Offset = "0x9F46B8", VA = "0x9F46B8")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x9F4948", Offset = "0x9F4948", VA = "0x9F4948")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x9F4720", Offset = "0x9F4720", VA = "0x9F4720")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x9F49C0", Offset = "0x9F49C0", VA = "0x9F49C0")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x9F4BCC", Offset = "0x9F4BCC", VA = "0x9F4BCC")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x9F4A34", Offset = "0x9F4A34", VA = "0x9F4A34")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x9F4CA8", Offset = "0x9F4CA8", VA = "0x9F4CA8")]
	public static object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x9F4D28", Offset = "0x9F4D28", VA = "0x9F4D28")]
	public static object Load(string key, string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x9F4DB4", Offset = "0x9F4DB4", VA = "0x9F4DB4")]
	public static object Load(string key, string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x9F4E44", Offset = "0x9F4E44", VA = "0x9F4E44")]
	public static object Load(string key, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x600003C")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x600003D")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600003E")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600003F")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000040")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000041")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000042")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000043")]
	public static void LoadInto<T>(string key, object obj) where T : class
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x9F4EA0", Offset = "0x9F4EA0", VA = "0x9F4EA0")]
	public static void LoadInto(string key, string filePath, object obj)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x9F4F34", Offset = "0x9F4F34", VA = "0x9F4F34")]
	public static void LoadInto(string key, string filePath, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x9F4FD4", Offset = "0x9F4FD4", VA = "0x9F4FD4")]
	public static void LoadInto(string key, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000047")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000048")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x6000049")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x600004A")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x9F5038", Offset = "0x9F5038", VA = "0x9F5038")]
	public static string LoadString(string key, string defaultValue, [Optional] string filePath)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x9F50D0", Offset = "0x9F50D0", VA = "0x9F50D0")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x9F55F4", Offset = "0x9F55F4", VA = "0x9F55F4")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x9F5658", Offset = "0x9F5658", VA = "0x9F5658")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x9F5130", Offset = "0x9F5130", VA = "0x9F5130")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x9F5768", Offset = "0x9F5768", VA = "0x9F5768")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x9F5814", Offset = "0x9F5814", VA = "0x9F5814")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x9F5878", Offset = "0x9F5878", VA = "0x9F5878")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x9F57C8", Offset = "0x9F57C8", VA = "0x9F57C8")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x9F58E8", Offset = "0x9F58E8", VA = "0x9F58E8")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x9F5964", Offset = "0x9F5964", VA = "0x9F5964")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x9F5950", Offset = "0x9F5950", VA = "0x9F5950")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x9F59D8", Offset = "0x9F59D8", VA = "0x9F59D8")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x9F5A4C", Offset = "0x9F5A4C", VA = "0x9F5A4C")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x9F5AC4", Offset = "0x9F5AC4", VA = "0x9F5AC4")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	public static byte[] Serialize<T>(T value, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	public static T Deserialize<T>(byte[] bytes, [Optional] ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x9F5EC0", Offset = "0x9F5EC0", VA = "0x9F5EC0")]
	internal static object Deserialize(ES3Type type, byte[] bytes, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	public static void DeserializeInto<T>(byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x600005E")]
	public static void DeserializeInto<T>(ES3Type type, byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x9F6230", Offset = "0x9F6230", VA = "0x9F6230")]
	public static byte[] EncryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x9F632C", Offset = "0x9F632C", VA = "0x9F632C")]
	public static byte[] DecryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x9F6428", Offset = "0x9F6428", VA = "0x9F6428")]
	public static string EncryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x9F64EC", Offset = "0x9F64EC", VA = "0x9F64EC")]
	public static string DecryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x9F65B0", Offset = "0x9F65B0", VA = "0x9F65B0")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x9F6784", Offset = "0x9F6784", VA = "0x9F6784")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x9F67E8", Offset = "0x9F67E8", VA = "0x9F67E8")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x9F6610", Offset = "0x9F6610", VA = "0x9F6610")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x9F6968", Offset = "0x9F6968", VA = "0x9F6968")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x9F6E34", Offset = "0x9F6E34", VA = "0x9F6E34")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x9F69F8", Offset = "0x9F69F8", VA = "0x9F69F8")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x9F72CC", Offset = "0x9F72CC", VA = "0x9F72CC")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x9F77B4", Offset = "0x9F77B4", VA = "0x9F77B4")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x9F735C", Offset = "0x9F735C", VA = "0x9F735C")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x9F785C", Offset = "0x9F785C", VA = "0x9F785C")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x9F7BB8", Offset = "0x9F7BB8", VA = "0x9F7BB8")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x9F78EC", Offset = "0x9F78EC", VA = "0x9F78EC")]
	public static void CopyDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x9F8058", Offset = "0x9F8058", VA = "0x9F8058")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x9F82A0", Offset = "0x9F82A0", VA = "0x9F82A0")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x9F80E8", Offset = "0x9F80E8", VA = "0x9F80E8")]
	public static void RenameDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x9F83D4", Offset = "0x9F83D4", VA = "0x9F83D4")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9F8574", Offset = "0x9F8574", VA = "0x9F8574")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x9F8438", Offset = "0x9F8438", VA = "0x9F8438")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x9F85E4", Offset = "0x9F85E4", VA = "0x9F85E4")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x9F886C", Offset = "0x9F886C", VA = "0x9F886C")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x9F88E0", Offset = "0x9F88E0", VA = "0x9F88E0")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x9F864C", Offset = "0x9F864C", VA = "0x9F864C")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x9F8BA8", Offset = "0x9F8BA8", VA = "0x9F8BA8")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x9F8DD4", Offset = "0x9F8DD4", VA = "0x9F8DD4")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x9F8E48", Offset = "0x9F8E48", VA = "0x9F8E48")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x9F8C10", Offset = "0x9F8C10", VA = "0x9F8C10")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x9F8F88", Offset = "0x9F8F88", VA = "0x9F8F88")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x9F8FE8", Offset = "0x9F8FE8", VA = "0x9F8FE8")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x9F904C", Offset = "0x9F904C", VA = "0x9F904C")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x9F8A14", Offset = "0x9F8A14", VA = "0x9F8A14")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x9F914C", Offset = "0x9F914C", VA = "0x9F914C")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x9F91B0", Offset = "0x9F91B0", VA = "0x9F91B0")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x9F7C58", Offset = "0x9F7C58", VA = "0x9F7C58")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x9F9220", Offset = "0x9F9220", VA = "0x9F9220")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x9F96D4", Offset = "0x9F96D4", VA = "0x9F96D4")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x9F9738", Offset = "0x9F9738", VA = "0x9F9738")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x9F9280", Offset = "0x9F9280", VA = "0x9F9280")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x9F9910", Offset = "0x9F9910", VA = "0x9F9910")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x9F99B4", Offset = "0x9F99B4", VA = "0x9F99B4")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x9F9A18", Offset = "0x9F9A18", VA = "0x9F9A18")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x9F7DA4", Offset = "0x9F7DA4", VA = "0x9F7DA4")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x9F9C50", Offset = "0x9F9C50", VA = "0x9F9C50")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x9F9CB0", Offset = "0x9F9CB0", VA = "0x9F9CB0")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x9F9D14", Offset = "0x9F9D14", VA = "0x9F9D14")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x9F7F80", Offset = "0x9F7F80", VA = "0x9F7F80")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x9F9EF8", Offset = "0x9F9EF8", VA = "0x9F9EF8")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x9F9FFC", Offset = "0x9F9FFC", VA = "0x9F9FFC")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x9FA060", Offset = "0x9FA060", VA = "0x9FA060")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x9F9F58", Offset = "0x9F9F58", VA = "0x9F9F58")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x9FA0D0", Offset = "0x9FA0D0", VA = "0x9FA0D0")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x9FA1F4", Offset = "0x9FA1F4", VA = "0x9FA1F4")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x9FA134", Offset = "0x9FA134", VA = "0x9FA134")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x9FA264", Offset = "0x9FA264", VA = "0x9FA264")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x9FA474", Offset = "0x9FA474", VA = "0x9FA474")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x9FA4D8", Offset = "0x9FA4D8", VA = "0x9FA4D8")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x9FA2C4", Offset = "0x9FA2C4", VA = "0x9FA2C4")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x9FA748", Offset = "0x9FA748", VA = "0x9FA748")]
	public static void StoreCachedFile()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x9FAA08", Offset = "0x9FAA08", VA = "0x9FAA08")]
	public static void StoreCachedFile(string filePath)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x9FAACC", Offset = "0x9FAACC", VA = "0x9FAACC")]
	public static void StoreCachedFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x9FAA6C", Offset = "0x9FAA6C", VA = "0x9FAA6C")]
	public static void StoreCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x9FAB3C", Offset = "0x9FAB3C", VA = "0x9FAB3C")]
	public static void CacheFile()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x9FABFC", Offset = "0x9FABFC", VA = "0x9FABFC")]
	public static void CacheFile(string filePath)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x9FAC60", Offset = "0x9FAC60", VA = "0x9FAC60")]
	public static void CacheFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x9FAB9C", Offset = "0x9FAB9C", VA = "0x9FAB9C")]
	public static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x9FAE90", Offset = "0x9FAE90", VA = "0x9FAE90")]
	public static void Init()
	{
	}
}
[Token(Token = "0x2000011")]
public class ES3File
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A614", Offset = "0x61A614")]
	internal static Dictionary<string, ES3File> cachedFiles;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, ES3Data> cache;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool syncWithFile;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DateTime timestamp;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xA02FA0", Offset = "0xA02FA0", VA = "0xA02FA0")]
	public ES3File()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xA034D0", Offset = "0xA034D0", VA = "0xA034D0")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xA03548", Offset = "0xA03548", VA = "0xA03548")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x9FE598", Offset = "0x9FE598", VA = "0x9FE598")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xA035C4", Offset = "0xA035C4", VA = "0xA035C4")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xA0363C", Offset = "0xA0363C", VA = "0xA0363C")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xA036B8", Offset = "0xA036B8", VA = "0xA036B8")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xA0300C", Offset = "0xA0300C", VA = "0xA0300C")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xA03740", Offset = "0xA03740", VA = "0xA03740")]
	public ES3File(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xA03870", Offset = "0xA03870", VA = "0xA03870")]
	public void Sync()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xA03C40", Offset = "0xA03C40", VA = "0xA03C40")]
	public void Sync(string filePath, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xA03878", Offset = "0xA03878", VA = "0xA03878")]
	public void Sync([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xA03CB8", Offset = "0xA03CB8", VA = "0xA03CB8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xA03D0C", Offset = "0xA03D0C", VA = "0xA03D0C")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	public void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x9F3918", Offset = "0x9F3918", VA = "0x9F3918")]
	public void SaveRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x9F4638", Offset = "0x9F4638", VA = "0x9F4638")]
	public void AppendRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xA03DDC", Offset = "0xA03DDC", VA = "0xA03DDC")]
	public object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xA03E38", Offset = "0xA03E38", VA = "0xA03E38")]
	public object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B9")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60000BA")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x9F56C8", Offset = "0x9F56C8", VA = "0x9F56C8")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xA03E9C", Offset = "0xA03E9C", VA = "0xA03E9C")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x9FF658", Offset = "0x9FF658", VA = "0x9FF658")]
	internal byte[] GetBytes([Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xA03F48", Offset = "0xA03F48", VA = "0xA03F48")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xA03FAC", Offset = "0xA03FAC", VA = "0xA03FAC")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xA04010", Offset = "0xA04010", VA = "0xA04010")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xA0413C", Offset = "0xA0413C", VA = "0xA0413C")]
	public Type GetKeyType(string key)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x9F37F0", Offset = "0x9F37F0", VA = "0x9F37F0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A764", Offset = "0x61A764")]
	internal static ES3File GetOrCreateCachedFile(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x9FACD0", Offset = "0x9FACD0", VA = "0x9FACD0")]
	internal static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x9FA7A4", Offset = "0x9FA7A4", VA = "0x9FA7A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A778", Offset = "0x61A778")]
	internal static void Store([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x9F68D8", Offset = "0x9F68D8", VA = "0x9F68D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A78C", Offset = "0x61A78C")]
	internal static void RemoveCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x9F6EE4", Offset = "0x9F6EE4", VA = "0x9F6EE4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A7A0", Offset = "0x61A7A0")]
	internal static void CopyCachedFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x9F8958", Offset = "0x9F8958", VA = "0x9F8958")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A7B4", Offset = "0x61A7B4")]
	internal static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x9F8EC0", Offset = "0x9F8EC0", VA = "0x9F8EC0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A7C8", Offset = "0x61A7C8")]
	internal static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x9F90BC", Offset = "0x9F90BC", VA = "0x9F90BC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A7DC", Offset = "0x61A7DC")]
	internal static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x9F97A8", Offset = "0x9F97A8", VA = "0x9F97A8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A7F0", Offset = "0x61A7F0")]
	internal static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x9F9A88", Offset = "0x9F9A88", VA = "0x9F9A88")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A804", Offset = "0x61A804")]
	internal static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x9FA61C", Offset = "0x9FA61C", VA = "0x9FA61C")]
	internal static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}
}
[Token(Token = "0x2000012")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xA052A4", Offset = "0xA052A4", VA = "0xA052A4")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000013")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase
{
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x13C2D94", Offset = "0x13C2D94", VA = "0x13C2D94")]
	public ES3ReferenceMgr()
	{
	}
}
[Token(Token = "0x2000014")]
public class ES3Spreadsheet
{
	[Token(Token = "0x2000015")]
	protected struct Index
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int col;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int row;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1939210", Offset = "0x1939210", VA = "0x1939210")]
		public Index(int col, int row)
		{
		}
	}

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int cols;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int rows;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Index, string> cells;

	[Token(Token = "0x4000033")]
	private const string QUOTE = "\"";

	[Token(Token = "0x4000034")]
	private const char QUOTE_CHAR = '"';

	[Token(Token = "0x4000035")]
	private const char COMMA_CHAR = ',';

	[Token(Token = "0x4000036")]
	private const char NEWLINE_CHAR = '\n';

	[Token(Token = "0x4000037")]
	private const string ESCAPED_QUOTE = "\"\"";

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static char[] CHARS_TO_ESCAPE;

	[Token(Token = "0x17000005")]
	public int ColumnCount
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x13CAD0C", Offset = "0x13CAD0C", VA = "0x13CAD0C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public int RowCount
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x13CAD14", Offset = "0x13CAD14", VA = "0x13CAD14")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000D2")]
	public void SetCell<T>(int col, int row, T value)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x13CAD1C", Offset = "0x13CAD1C", VA = "0x13CAD1C")]
	private void SetCellString(int col, int row, string value)
	{
	}

	[Token(Token = "0x60000D4")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x13CADDC", Offset = "0x13CADDC", VA = "0x13CADDC")]
	internal object GetCell(Type type, int col, int row)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x13CB458", Offset = "0x13CB458", VA = "0x13CB458")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x13CB504", Offset = "0x13CB504", VA = "0x13CB504")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x13CB4D4", Offset = "0x13CB4D4", VA = "0x13CB4D4")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x13CB858", Offset = "0x13CB858", VA = "0x13CB858")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x13CB92C", Offset = "0x13CB92C", VA = "0x13CB92C")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x13CB584", Offset = "0x13CB584", VA = "0x13CB584")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x13CB9CC", Offset = "0x13CB9CC", VA = "0x13CB9CC")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x13CBD88", Offset = "0x13CBD88", VA = "0x13CBD88")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x13CBE00", Offset = "0x13CBE00", VA = "0x13CBE00")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x13CBE08", Offset = "0x13CBE08", VA = "0x13CBE08")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x13CBE80", Offset = "0x13CBE80", VA = "0x13CBE80")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x13CBA40", Offset = "0x13CBA40", VA = "0x13CBA40")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x13CC0C0", Offset = "0x13CC0C0", VA = "0x13CC0C0")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x13CC1DC", Offset = "0x13CC1DC", VA = "0x13CC1DC")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x13CBF04", Offset = "0x13CBF04", VA = "0x13CBF04")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x13CC2C0", Offset = "0x13CC2C0", VA = "0x13CC2C0")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x2000016")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x613030", Offset = "0x613030")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613044", Offset = "0x613044")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderPropertyEnumerator <>4__this;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0x193949C", Offset = "0x193949C", VA = "0x193949C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600012D")]
				[Address(RVA = "0x19394E4", Offset = "0x19394E4", VA = "0x19394E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x19393B8", Offset = "0x19393B8", VA = "0x19393B8")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x19393E4", Offset = "0x19393E4", VA = "0x19393E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x19393E8", Offset = "0x19393E8", VA = "0x19393E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x19394A4", Offset = "0x19394A4", VA = "0x19394A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x11F9B7C", Offset = "0x11F9B7C", VA = "0x11F9B7C")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x11F9BB0", Offset = "0x11F9BB0", VA = "0x11F9BB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61A8B8", Offset = "0x61A8B8")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x613054", Offset = "0x613054")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613068", Offset = "0x613068")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderRawEnumerator <>4__this;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000133")]
				[Address(RVA = "0x193969C", Offset = "0x193969C", VA = "0x193969C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000135")]
				[Address(RVA = "0x19396E4", Offset = "0x19396E4", VA = "0x19396E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x19394EC", Offset = "0x19394EC", VA = "0x19394EC")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1939518", Offset = "0x1939518", VA = "0x1939518", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x193951C", Offset = "0x193951C", VA = "0x193951C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x19396A4", Offset = "0x19396A4", VA = "0x19396A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x11F9C28", Offset = "0x11F9C28", VA = "0x11F9C28")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x11F4020", Offset = "0x11F4020", VA = "0x11F4020")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61A968", Offset = "0x61A968")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected int serializationDepth;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal string overridePropertiesName;

	[Token(Token = "0x17000007")]
	public virtual ES3ReaderPropertyEnumerator Properties
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x13C0F6C", Offset = "0x13C0F6C", VA = "0x13C0F6C", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x13C0FCC", Offset = "0x13C0FCC", VA = "0x13C0FCC", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E8")]
	internal abstract int Read_int();

	[Token(Token = "0x60000E9")]
	internal abstract float Read_float();

	[Token(Token = "0x60000EA")]
	internal abstract bool Read_bool();

	[Token(Token = "0x60000EB")]
	internal abstract char Read_char();

	[Token(Token = "0x60000EC")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x60000ED")]
	internal abstract double Read_double();

	[Token(Token = "0x60000EE")]
	internal abstract long Read_long();

	[Token(Token = "0x60000EF")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x60000F0")]
	internal abstract byte Read_byte();

	[Token(Token = "0x60000F1")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x60000F2")]
	internal abstract short Read_short();

	[Token(Token = "0x60000F3")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x60000F4")]
	internal abstract uint Read_uint();

	[Token(Token = "0x60000F5")]
	internal abstract string Read_string();

	[Token(Token = "0x60000F6")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x60000F7")]
	internal abstract long Read_ref();

	[Token(Token = "0x60000F8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A818", Offset = "0x61A818")]
	public abstract string ReadPropertyName();

	[Token(Token = "0x60000F9")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x60000FA")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x60000FB")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x60000FC")]
	public abstract void Dispose();

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x13C0E50", Offset = "0x13C0E50", VA = "0x13C0E50", Slot = "26")]
	internal virtual bool Goto(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x13C0F14", Offset = "0x13C0F14", VA = "0x13C0F14", Slot = "27")]
	internal virtual bool StartReadObject()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x13C0F28", Offset = "0x13C0F28", VA = "0x13C0F28", Slot = "28")]
	internal virtual void EndReadObject()
	{
	}

	[Token(Token = "0x6000100")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x6000101")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x6000102")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x6000103")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x6000104")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x6000105")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x6000106")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x6000107")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x6000108")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x6000109")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x13C0F38", Offset = "0x13C0F38", VA = "0x13C0F38")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x13C102C", Offset = "0x13C102C", VA = "0x13C102C", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A82C", Offset = "0x61A82C")]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x600010E")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600010F")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x6000110")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A840", Offset = "0x61A840")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000111")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A854", Offset = "0x61A854")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x13C1040", Offset = "0x13C1040", VA = "0x13C1040")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A868", Offset = "0x61A868")]
	public long ReadRefProperty()
	{
		return default(long);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x13C107C", Offset = "0x13C107C", VA = "0x13C107C")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x13C1C00", Offset = "0x13C1C00", VA = "0x13C1C00")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x13C1E28", Offset = "0x13C1E28", VA = "0x13C1E28")]
	public void SetPrivateField(string name, object value, object objectContainingField)
	{
	}

	[Token(Token = "0x6000116")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000117")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000118")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000119")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x600011A")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600011B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A87C", Offset = "0x61A87C")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600011C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A890", Offset = "0x61A890")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x600011D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A8A4", Offset = "0x61A8A4")]
	internal Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x13C2050", Offset = "0x13C2050", VA = "0x13C2050")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x13C21A8", Offset = "0x13C21A8", VA = "0x13C21A8")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x13C2208", Offset = "0x13C2208", VA = "0x13C2208")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x13C210C", Offset = "0x13C210C", VA = "0x13C210C")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x13C26A8", Offset = "0x13C26A8", VA = "0x13C26A8")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x13C2708", Offset = "0x13C2708", VA = "0x13C2708")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x13C2BB8", Offset = "0x13C2BB8", VA = "0x13C2BB8")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x13C2C58", Offset = "0x13C2C58", VA = "0x13C2C58")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x200001B")]
public class ES3XMLReader
{
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x11F4190", Offset = "0x11F4190", VA = "0x11F4190")]
	public ES3XMLReader()
	{
	}
}
[Token(Token = "0x200001C")]
public class ES3Defaults : ScriptableObject
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ES3SerializableSettings settings;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool addMgrToSceneAutomatically;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool autoUpdateReferences;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool addAllPrefabsToManager;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool logDebugInfo;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool logWarnings;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool logErrors;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xA02378", Offset = "0xA02378", VA = "0xA02378")]
	public ES3Defaults()
	{
	}
}
[Token(Token = "0x200001D")]
public class ES3Settings : ICloneable
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES3Settings _defaults;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES3Defaults _defaultSettingsScriptableObject;

	[Token(Token = "0x400004F")]
	private const string defaultSettingsPath = "ES3/ES3Defaults";

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ES3Settings _unencryptedUncompressedSettings;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string[] resourcesExtensions;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private ES3.Location _location;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ES3.EncryptionType encryptionType;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ES3.CompressionType compressionType;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string encryptionPassword;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES3.Directory directory;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ES3.Format format;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool prettyPrint;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bufferSize;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool saveChildren;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A648", Offset = "0x61A648")]
	public bool typeChecking;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A65C", Offset = "0x61A65C")]
	public bool safeReflection;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A670", Offset = "0x61A670")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A684", Offset = "0x61A684")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A698", Offset = "0x61A698")]
	public int serializationDepthLimit;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A6AC", Offset = "0x61A6AC")]
	public string[] assemblyNames;

	[Token(Token = "0x1700000D")]
	public static ES3Defaults defaultSettingsScriptableObject
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x13C9D04", Offset = "0x13C9D04", VA = "0x13C9D04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public static ES3Settings defaultSettings
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x13C9E38", Offset = "0x13C9E38", VA = "0x13C9E38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	internal static ES3Settings unencryptedUncompressedSettings
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x13C9F5C", Offset = "0x13C9F5C", VA = "0x13C9F5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public ES3.Location location
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x13CA2F4", Offset = "0x13CA2F4", VA = "0x13CA2F4")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x13CA344", Offset = "0x13CA344", VA = "0x13CA344")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public string FullPath
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x13CA34C", Offset = "0x13CA34C", VA = "0x13CA34C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x13C20A8", Offset = "0x13C20A8", VA = "0x13C20A8")]
	public ES3Settings([Optional] string path, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x13CA848", Offset = "0x13CA848", VA = "0x13CA848")]
	public ES3Settings(string path, params Enum[] enums)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x13CA128", Offset = "0x13CA128", VA = "0x13CA128")]
	public ES3Settings(params Enum[] enums)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x13CA88C", Offset = "0x13CA88C", VA = "0x13CA88C")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x13CA8D0", Offset = "0x13CA8D0", VA = "0x13CA8D0")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x13C9964", Offset = "0x13C9964", VA = "0x13C9964")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61AA18", Offset = "0x61AA18")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x13CA6DC", Offset = "0x13CA6DC", VA = "0x13CA6DC")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x13CA914", Offset = "0x13CA914", VA = "0x13CA914", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61AA2C", Offset = "0x61AA2C")]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x13CA780", Offset = "0x13CA780", VA = "0x13CA780")]
	private void CopyInto(ES3Settings newSettings)
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x613078", Offset = "0x613078")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x13C9900", Offset = "0x13C9900", VA = "0x13C9900")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x13C9B9C", Offset = "0x13C9B9C", VA = "0x13C9B9C")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x13C9C0C", Offset = "0x13C9C0C", VA = "0x13C9C0C")]
	public ES3SerializableSettings(string path)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x13C9C8C", Offset = "0x13C9C8C", VA = "0x13C9C8C")]
	public ES3SerializableSettings(string path, ES3.Location location)
	{
	}
}
[Token(Token = "0x200001F")]
public class ES3Ref
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long id;

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x13C2CE8", Offset = "0x13C2CE8", VA = "0x13C2CE8")]
	public ES3Ref(long id)
	{
	}
}
[Token(Token = "0x2000020")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61308C", Offset = "0x61308C")]
	private sealed class <Sync>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x11F9710", Offset = "0x11F9710", VA = "0x11F9710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x11F9758", Offset = "0x11F9758", VA = "0x11F9758", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x11F959C", Offset = "0x11F959C", VA = "0x11F959C")]
		[DebuggerHidden]
		public <Sync>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x11F95C8", Offset = "0x11F95C8", VA = "0x11F95C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x11F95CC", Offset = "0x11F95CC", VA = "0x11F95CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x11F9718", Offset = "0x11F9718", VA = "0x11F9718", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61309C", Offset = "0x61309C")]
	private sealed class <UploadFile>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public long fileTimestamp;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] bytes;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x11F9B2C", Offset = "0x11F9B2C", VA = "0x11F9B2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x11F9B74", Offset = "0x11F9B74", VA = "0x11F9B74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x11F9760", Offset = "0x11F9760", VA = "0x11F9760")]
		[DebuggerHidden]
		public <UploadFile>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x11F978C", Offset = "0x11F978C", VA = "0x11F978C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x11F9864", Offset = "0x11F9864", VA = "0x11F9864", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x11F97A8", Offset = "0x11F97A8", VA = "0x11F97A8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x11F9B34", Offset = "0x11F9B34", VA = "0x11F9B34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6130AC", Offset = "0x6130AC")]
	private sealed class <DownloadFile>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3File es3File;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x11F8144", Offset = "0x11F8144", VA = "0x11F8144", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x11F818C", Offset = "0x11F818C", VA = "0x11F818C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x11F7CC0", Offset = "0x11F7CC0", VA = "0x11F7CC0")]
		[DebuggerHidden]
		public <DownloadFile>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x11F7CEC", Offset = "0x11F7CEC", VA = "0x11F7CEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x11F7DC4", Offset = "0x11F7DC4", VA = "0x11F7DC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x11F7D08", Offset = "0x11F7D08", VA = "0x11F7D08")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x11F814C", Offset = "0x11F814C", VA = "0x11F814C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6130BC", Offset = "0x6130BC")]
	private sealed class <DownloadFile>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x11F85D0", Offset = "0x11F85D0", VA = "0x11F85D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x11F8618", Offset = "0x11F8618", VA = "0x11F8618", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x11F8194", Offset = "0x11F8194", VA = "0x11F8194")]
		[DebuggerHidden]
		public <DownloadFile>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x11F81C0", Offset = "0x11F81C0", VA = "0x11F81C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x11F8298", Offset = "0x11F8298", VA = "0x11F8298", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x11F81DC", Offset = "0x11F81DC", VA = "0x11F81DC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x11F85D8", Offset = "0x11F85D8", VA = "0x11F85D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6130CC", Offset = "0x6130CC")]
	private sealed class <DeleteFile>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x11F7C70", Offset = "0x11F7C70", VA = "0x11F7C70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x11F7CB8", Offset = "0x11F7CB8", VA = "0x11F7CB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x11F7938", Offset = "0x11F7938", VA = "0x11F7938")]
		[DebuggerHidden]
		public <DeleteFile>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x11F7964", Offset = "0x11F7964", VA = "0x11F7964", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x11F7A3C", Offset = "0x11F7A3C", VA = "0x11F7A3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x11F7980", Offset = "0x11F7980", VA = "0x11F7980")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x11F7C78", Offset = "0x11F7C78", VA = "0x11F7C78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6130DC", Offset = "0x6130DC")]
	private sealed class <RenameFile>d__60 : IEnumerator<object>, IEnumerator, IDisposable
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
		public ES3Settings newSettings;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x11F9138", Offset = "0x11F9138", VA = "0x11F9138", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x11F9180", Offset = "0x11F9180", VA = "0x11F9180", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x11F8DC4", Offset = "0x11F8DC4", VA = "0x11F8DC4")]
		[DebuggerHidden]
		public <RenameFile>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x11F8DF0", Offset = "0x11F8DF0", VA = "0x11F8DF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x11F8EC8", Offset = "0x11F8EC8", VA = "0x11F8EC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x11F8E0C", Offset = "0x11F8E0C", VA = "0x11F8E0C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x11F9140", Offset = "0x11F9140", VA = "0x11F9140", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6130EC", Offset = "0x6130EC")]
	private sealed class <DownloadFilenames>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x11F89A4", Offset = "0x11F89A4", VA = "0x11F89A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x11F89EC", Offset = "0x11F89EC", VA = "0x11F89EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x11F8620", Offset = "0x11F8620", VA = "0x11F8620")]
		[DebuggerHidden]
		public <DownloadFilenames>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x11F864C", Offset = "0x11F864C", VA = "0x11F864C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x11F8724", Offset = "0x11F8724", VA = "0x11F8724", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x11F8668", Offset = "0x11F8668", VA = "0x11F8668")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x11F89AC", Offset = "0x11F89AC", VA = "0x11F89AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6130FC", Offset = "0x6130FC")]
	private sealed class <SearchFilenames>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string searchPattern;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x11F954C", Offset = "0x11F954C", VA = "0x11F954C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x11F9594", Offset = "0x11F9594", VA = "0x11F9594", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x11F9188", Offset = "0x11F9188", VA = "0x11F9188")]
		[DebuggerHidden]
		public <SearchFilenames>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x11F91B4", Offset = "0x11F91B4", VA = "0x11F91B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x11F928C", Offset = "0x11F928C", VA = "0x11F928C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x11F91D0", Offset = "0x11F91D0", VA = "0x11F91D0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x11F9554", Offset = "0x11F9554", VA = "0x11F9554", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61310C", Offset = "0x61310C")]
	private sealed class <DownloadTimestamp>d__70 : IEnumerator<object>, IEnumerator, IDisposable
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
		public ES3Settings settings;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x11F8D74", Offset = "0x11F8D74", VA = "0x11F8D74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x11F8DBC", Offset = "0x11F8DBC", VA = "0x11F8DBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x11F89F4", Offset = "0x11F89F4", VA = "0x11F89F4")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x11F8A20", Offset = "0x11F8A20", VA = "0x11F8A20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x11F8AF8", Offset = "0x11F8AF8", VA = "0x11F8AF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x11F8A3C", Offset = "0x11F8A3C", VA = "0x11F8A3C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x11F8D7C", Offset = "0x11F8D7C", VA = "0x11F8D7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int timeout;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Encoding encoding;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private byte[] _data;

	[Token(Token = "0x17000012")]
	public byte[] data
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x9FE998", Offset = "0x9FE998", VA = "0x9FE998")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	public string text
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x9FE9A0", Offset = "0x9FE9A0", VA = "0x9FE9A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public string[] filenames
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x9FE9D4", Offset = "0x9FE9D4", VA = "0x9FE9D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public DateTime timestamp
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x9FEAA0", Offset = "0x9FEAA0", VA = "0x9FEAA0")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x9FE8D4", Offset = "0x9FE8D4", VA = "0x9FE8D4")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x9FE930", Offset = "0x9FE930", VA = "0x9FE930")]
	public ES3Cloud(string url, string apiKey, int timeout)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x9FEC24", Offset = "0x9FEC24", VA = "0x9FEC24")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x9FED6C", Offset = "0x9FED6C", VA = "0x9FED6C")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x9FEDFC", Offset = "0x9FEDFC", VA = "0x9FEDFC")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x9FEE90", Offset = "0x9FEE90", VA = "0x9FEE90")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x9FEF1C", Offset = "0x9FEF1C", VA = "0x9FEF1C")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x9FEFB0", Offset = "0x9FEFB0", VA = "0x9FEFB0")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x9FF050", Offset = "0x9FF050", VA = "0x9FF050")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x9FECA8", Offset = "0x9FECA8", VA = "0x9FECA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AA40", Offset = "0x61AA40")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x9FF0E0", Offset = "0x9FF0E0", VA = "0x9FF0E0")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x9FF1C8", Offset = "0x9FF1C8", VA = "0x9FF1C8")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x9FF268", Offset = "0x9FF268", VA = "0x9FF268")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x9FF30C", Offset = "0x9FF30C", VA = "0x9FF30C")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x9FF3A4", Offset = "0x9FF3A4", VA = "0x9FF3A4")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x9FF448", Offset = "0x9FF448", VA = "0x9FF448")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x9FF4F8", Offset = "0x9FF4F8", VA = "0x9FF4F8")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x9FF594", Offset = "0x9FF594", VA = "0x9FF594")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x9FFD50", Offset = "0x9FFD50", VA = "0x9FFD50")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x9FFE18", Offset = "0x9FFE18", VA = "0x9FFE18")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x9FF17C", Offset = "0x9FF17C", VA = "0x9FF17C")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x9FFED8", Offset = "0x9FFED8", VA = "0x9FFED8")]
	public IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x9FFC68", Offset = "0x9FFC68", VA = "0x9FFC68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AAA0", Offset = "0x61AAA0")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password, long fileTimestamp)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x9FFF3C", Offset = "0x9FFF3C", VA = "0x9FFF3C")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xA00090", Offset = "0xA00090", VA = "0xA00090")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xA00124", Offset = "0xA00124", VA = "0xA00124")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xA001BC", Offset = "0xA001BC", VA = "0xA001BC")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xA0024C", Offset = "0xA0024C", VA = "0xA0024C")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xA002E4", Offset = "0xA002E4", VA = "0xA002E4")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xA00388", Offset = "0xA00388", VA = "0xA00388")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xA0041C", Offset = "0xA0041C", VA = "0xA0041C")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xA0054C", Offset = "0xA0054C", VA = "0xA0054C")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xA005B4", Offset = "0xA005B4", VA = "0xA005B4")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xA00480", Offset = "0xA00480", VA = "0xA00480")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AB00", Offset = "0x61AB00")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x9FFFC4", Offset = "0x9FFFC4", VA = "0x9FFFC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AB60", Offset = "0x61AB60")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xA005BC", Offset = "0xA005BC", VA = "0xA005BC")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xA00704", Offset = "0xA00704", VA = "0xA00704")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xA00794", Offset = "0xA00794", VA = "0xA00794")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xA00828", Offset = "0xA00828", VA = "0xA00828")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xA008B4", Offset = "0xA008B4", VA = "0xA008B4")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xA00948", Offset = "0xA00948", VA = "0xA00948")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xA009E8", Offset = "0xA009E8", VA = "0xA009E8")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xA00640", Offset = "0xA00640", VA = "0xA00640")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61ABC0", Offset = "0x61ABC0")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xA00A78", Offset = "0xA00A78", VA = "0xA00A78")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xA00C0C", Offset = "0xA00C0C", VA = "0xA00C0C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xA00CCC", Offset = "0xA00CCC", VA = "0xA00CCC")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xA00D84", Offset = "0xA00D84", VA = "0xA00D84")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xA00E44", Offset = "0xA00E44", VA = "0xA00E44")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xA00F10", Offset = "0xA00F10", VA = "0xA00F10")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xA00B34", Offset = "0xA00B34", VA = "0xA00B34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AC20", Offset = "0x61AC20")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xA00FCC", Offset = "0xA00FCC", VA = "0xA00FCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AC80", Offset = "0x61AC80")]
	public IEnumerator DownloadFilenames(string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xA01074", Offset = "0xA01074", VA = "0xA01074")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61ACE0", Offset = "0x61ACE0")]
	public IEnumerator SearchFilenames(string searchPattern, string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xA01138", Offset = "0xA01138", VA = "0xA01138")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xA01280", Offset = "0xA01280", VA = "0xA01280")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xA01310", Offset = "0xA01310", VA = "0xA01310")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xA013A4", Offset = "0xA013A4", VA = "0xA013A4")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xA01430", Offset = "0xA01430", VA = "0xA01430")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xA014C4", Offset = "0xA014C4", VA = "0xA014C4")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xA01564", Offset = "0xA01564", VA = "0xA01564")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xA011BC", Offset = "0xA011BC", VA = "0xA011BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AD40", Offset = "0x61AD40")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x9FFB58", Offset = "0x9FFB58", VA = "0x9FFB58")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xA015F4", Offset = "0xA015F4", VA = "0xA015F4")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xA01610", Offset = "0xA01610", VA = "0xA01610", Slot = "4")]
	protected override void Reset()
	{
	}
}
[Token(Token = "0x200002A")]
public abstract class ES3Writer : IDisposable
{
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HashSet<string> keysToDelete;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool writeHeaderAndFooter;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	internal bool overwriteKeys;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int serializationDepth;

	[Token(Token = "0x60001CE")]
	internal abstract void WriteNull();

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x11F1DA4", Offset = "0x11F1DA4", VA = "0x11F1DA4", Slot = "6")]
	internal virtual void StartWriteFile()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x11F1DB4", Offset = "0x11F1DB4", VA = "0x11F1DB4", Slot = "7")]
	internal virtual void EndWriteFile()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x11F1DC4", Offset = "0x11F1DC4", VA = "0x11F1DC4", Slot = "8")]
	internal virtual void StartWriteObject(string name)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x11F1DD4", Offset = "0x11F1DD4", VA = "0x11F1DD4", Slot = "9")]
	internal virtual void EndWriteObject(string name)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x11F1DE4", Offset = "0x11F1DE4", VA = "0x11F1DE4", Slot = "10")]
	internal virtual void StartWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x11F1EB4", Offset = "0x11F1EB4", VA = "0x11F1EB4", Slot = "11")]
	internal virtual void EndWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x11F1EB8", Offset = "0x11F1EB8", VA = "0x11F1EB8", Slot = "12")]
	internal virtual void StartWriteCollection()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x11F1EC8", Offset = "0x11F1EC8", VA = "0x11F1EC8", Slot = "13")]
	internal virtual void EndWriteCollection()
	{
	}

	[Token(Token = "0x60001D7")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x60001D8")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x60001D9")]
	internal abstract void StartWriteDictionary();

	[Token(Token = "0x60001DA")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x60001DB")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x60001DC")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x60001DD")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x60001DE")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x60001DF")]
	public abstract void Dispose();

	[Token(Token = "0x60001E0")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x60001E1")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x60001E2")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x60001E3")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x60001E4")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x60001E5")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x60001E6")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x60001E7")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x60001E8")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x60001E9")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x60001EA")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x60001EB")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x60001EC")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x60001ED")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x60001EE")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x60001EF")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x11F1ED8", Offset = "0x11F1ED8", VA = "0x11F1ED8")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x11F1FA8", Offset = "0x11F1FA8", VA = "0x11F1FA8", Slot = "39")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x60001F2")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x11F2094", Offset = "0x11F2094", VA = "0x11F2094", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B070", Offset = "0x61B070")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x11F21D0", Offset = "0x11F21D0", VA = "0x11F21D0", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B084", Offset = "0x61B084")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x11F229C", Offset = "0x11F229C", VA = "0x11F229C", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B098", Offset = "0x61B098")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x11F27C0", Offset = "0x11F27C0", VA = "0x11F27C0", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x11F2938", Offset = "0x11F2938", VA = "0x11F2938", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x11F2960", Offset = "0x11F2960", VA = "0x11F2960", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60001F9")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x11F2A98", Offset = "0x11F2A98", VA = "0x11F2A98", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B0AC", Offset = "0x61B0AC")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x11F2AC0", Offset = "0x11F2AC0", VA = "0x11F2AC0", Slot = "49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B0C0", Offset = "0x61B0C0")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x11F2B5C", Offset = "0x11F2B5C", VA = "0x11F2B5C", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B0D4", Offset = "0x61B0D4")]
	public virtual void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x11F2C74", Offset = "0x11F2C74", VA = "0x11F2C74")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x11F2F60", Offset = "0x11F2F60", VA = "0x11F2F60")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x11F3164", Offset = "0x11F3164", VA = "0x11F3164")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B0E8", Offset = "0x61B0E8")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x11F3324", Offset = "0x11F3324", VA = "0x11F3324")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B0FC", Offset = "0x61B0FC")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x11F34E4", Offset = "0x11F34E4", VA = "0x11F34E4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B110", Offset = "0x61B110")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x11F36E0", Offset = "0x11F36E0", VA = "0x11F36E0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B124", Offset = "0x61B124")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x11F155C", Offset = "0x11F155C", VA = "0x11F155C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B138", Offset = "0x61B138")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x11F38DC", Offset = "0x11F38DC", VA = "0x11F38DC")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x11F3958", Offset = "0x11F3958", VA = "0x11F3958")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x11F3968", Offset = "0x11F3968", VA = "0x11F3968")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x11F39C8", Offset = "0x11F39C8", VA = "0x11F39C8")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x11F29E8", Offset = "0x11F29E8", VA = "0x11F29E8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B14C", Offset = "0x61B14C")]
	protected bool SerializationDepthLimitExceeded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x11F3B4C", Offset = "0x11F3B4C", VA = "0x11F3B4C", Slot = "51")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B160", Offset = "0x61B160")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x11F3BB0", Offset = "0x11F3BB0", VA = "0x11F3BB0")]
	protected void Merge()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x11F3CFC", Offset = "0x11F3CFC", VA = "0x11F3CFC")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x11F4098", Offset = "0x11F4098", VA = "0x11F4098", Slot = "52")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x11F40AC", Offset = "0x11F40AC", VA = "0x11F40AC", Slot = "53")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200002B")]
public class ES3XMLWriter
{
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x11F4198", Offset = "0x11F4198", VA = "0x11F4198")]
	public ES3XMLWriter()
	{
	}
}
namespace ES3Types
{
	[Token(Token = "0x200002C")]
	[Preserve]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x13D3DD0", Offset = "0x13D3DD0", VA = "0x13D3DD0")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x13D3E98", Offset = "0x13D3E98", VA = "0x13D3E98", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000211")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200002D")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x13D3EA0", Offset = "0x13D3EA0", VA = "0x13D3EA0")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x13D3F68", Offset = "0x13D3F68", VA = "0x13D3F68", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000215")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x9FAF20", Offset = "0x9FAF20", VA = "0x9FAF20")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x9FB030", Offset = "0x9FB030", VA = "0x9FB030", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x600021A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x9FB24C", Offset = "0x9FB24C", VA = "0x9FB24C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x9FB4C4", Offset = "0x9FB4C4", VA = "0x9FB4C4", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x9FB794", Offset = "0x9FB794", VA = "0x9FB794")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x9FB798", Offset = "0x9FB798", VA = "0x9FB798", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000220")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x9FBA4C", Offset = "0x9FBA4C", VA = "0x9FBA4C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x9FBDA0", Offset = "0x9FBDA0", VA = "0x9FBDA0", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000030")]
	[Preserve]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9FC110", Offset = "0x9FC110", VA = "0x9FC110")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9FC114", Offset = "0x9FC114", VA = "0x9FC114")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x9FC194", Offset = "0x9FC194", VA = "0x9FC194", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9FC318", Offset = "0x9FC318", VA = "0x9FC318", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9FC54C", Offset = "0x9FC54C", VA = "0x9FC54C", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000031")]
	[Preserve]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type elementType;

		[Token(Token = "0x600022B")]
		public abstract object Read(ES3Reader reader);

		[Token(Token = "0x600022C")]
		public abstract void ReadInto(ES3Reader reader, object obj);

		[Token(Token = "0x600022D")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x9FAF24", Offset = "0x9FAF24", VA = "0x9FAF24")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x9FC154", Offset = "0x9FC154", VA = "0x9FC154")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA01640", Offset = "0xA01640", VA = "0xA01640", Slot = "4")]
		[Preserve]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000231")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA01650", Offset = "0xA01650", VA = "0xA01650", Slot = "12")]
		[Preserve]
		protected virtual void ReadICollectionInto(ES3Reader reader, ICollection collection, ES3Type elementType)
		{
		}
	}
	[Token(Token = "0x2000032")]
	[Preserve]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type keyType;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ES3Type valueType;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA023F4", Offset = "0xA023F4", VA = "0xA023F4")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA02538", Offset = "0xA02538", VA = "0xA02538")]
		public ES3DictionaryType(Type type, ES3Type keyType, ES3Type valueType)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA025A4", Offset = "0xA025A4", VA = "0xA025A4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA025C8", Offset = "0xA025C8", VA = "0xA025C8")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000238")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xA029D8", Offset = "0xA029D8", VA = "0xA029D8")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xA02C24", Offset = "0xA02C24", VA = "0xA02C24")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000033")]
	[Preserve]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA047E4", Offset = "0xA047E4", VA = "0xA047E4")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA047E8", Offset = "0xA047E8", VA = "0xA047E8", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600023E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA04DC8", Offset = "0xA04DC8", VA = "0xA04DC8", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA050C0", Offset = "0xA050C0", VA = "0xA050C0", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000034")]
	[Preserve]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x13BD580", Offset = "0x13BD580", VA = "0x13BD580")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x13BD588", Offset = "0x13BD588", VA = "0x13BD588")]
		public ES3ListType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x13BD590", Offset = "0x13BD590", VA = "0x13BD590", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000245")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x13BD974", Offset = "0x13BD974", VA = "0x13BD974", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x13BDCEC", Offset = "0x13BDCEC", VA = "0x13BDCEC", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000035")]
	[Preserve]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x13BFFBC", Offset = "0x13BFFBC", VA = "0x13BFFBC")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x13BFFC4", Offset = "0x13BFFC4", VA = "0x13BFFC4", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600024B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x13C0394", Offset = "0x13C0394", VA = "0x13C0394", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x13C08F8", Offset = "0x13C08F8", VA = "0x13C08F8", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000036")]
	[Preserve]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x13CC3D8", Offset = "0x13CC3D8", VA = "0x13CC3D8")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x13CC3E0", Offset = "0x13CC3E0", VA = "0x13CC3E0", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000251")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x13CC7B0", Offset = "0x13CC7B0", VA = "0x13CC7B0", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x13CCAA8", Offset = "0x13CCAA8", VA = "0x13CCAA8", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000037")]
	[Preserve]
	public abstract class ES3ComponentType : ES3UnityObjectType
	{
		[Token(Token = "0x40000B5")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA01B80", Offset = "0xA01B80", VA = "0xA01B80")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x6000256")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x6000257")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA01B88", Offset = "0xA01B88", VA = "0xA01B88", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000259")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600025A")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA01E40", Offset = "0xA01E40", VA = "0xA01E40")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA01EFC", Offset = "0xA01EFC", VA = "0xA01EFC")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	[Preserve]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x13BE364", Offset = "0x13BE364", VA = "0x13BE364")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x600025F")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000260")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x6000261")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x13BE440", Offset = "0x13BE440", VA = "0x13BE440", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000263")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000039")]
	[Preserve]
	public abstract class ES3ScriptableObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x13C5B90", Offset = "0x13C5B90", VA = "0x13C5B90")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000266")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000267")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x13C96E8", Offset = "0x13C96E8", VA = "0x13C96E8", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000269")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600026A")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x6131CC", Offset = "0x6131CC")]
	[Preserve]
	public abstract class ES3Type
	{
		[Token(Token = "0x40000B6")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isReflectedType;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUnsupported;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int priority;

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x13BE368", Offset = "0x13BE368", VA = "0x13BE368")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x600026D")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x600026E")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x600026F")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x13BE614", Offset = "0x13BE614", VA = "0x13BE614")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x13CD1F4", Offset = "0x13CD1F4", VA = "0x13CD1F4")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x13C59DC", Offset = "0x13C59DC", VA = "0x13C59DC")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x13CD250", Offset = "0x13CD250", VA = "0x13CD250")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x13C59CC", Offset = "0x13C59CC", VA = "0x13C59CC")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x13C5BFC", Offset = "0x13C5BFC", VA = "0x13C5BFC")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x613208", Offset = "0x613208")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x13BFF88", Offset = "0x13BFF88", VA = "0x13BFF88")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x200003C")]
	[Preserve]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x11E8D90", Offset = "0x11E8D90", VA = "0x11E8D90")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x6000279")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x600027A")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x600027B")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x11F115C", Offset = "0x11F115C", VA = "0x11F115C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x11F1170", Offset = "0x11F1170", VA = "0x11F1170", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x600027E")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600027F")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x11F13E8", Offset = "0x11F13E8", VA = "0x11F13E8")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61322C", Offset = "0x61322C")]
	[Preserve]
	public class ES3Type_Random : ES3ObjectType
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x18CE004", Offset = "0x18CE004", VA = "0x18CE004")]
		public ES3Type_Random()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x18CE0D0", Offset = "0x18CE0D0", VA = "0x18CE0D0", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000283")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000284")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200003E")]
	public class ES3Type_RandomArray : ES3ArrayType
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x18CE1D8", Offset = "0x18CE1D8", VA = "0x18CE1D8")]
		public ES3Type_RandomArray()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[Preserve]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x13D3AD0", Offset = "0x13D3AD0", VA = "0x13D3AD0")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x13D3B98", Offset = "0x13D3B98", VA = "0x13D3B98", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000289")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000040")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x13D3CD4", Offset = "0x13D3CD4", VA = "0x13D3CD4")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[Preserve]
	public class ES3Type_ES3Ref : ES3Type
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x13D40AC", Offset = "0x13D40AC", VA = "0x13D40AC")]
		public ES3Type_ES3Ref()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x13D417C", Offset = "0x13D417C", VA = "0x13D417C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600028E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	public class ES3Type_ES3RefArray : ES3ArrayType
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x13D4230", Offset = "0x13D4230", VA = "0x13D4230")]
		public ES3Type_ES3RefArray()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class ES3Type_ES3RefDictionary : ES3DictionaryType
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x13D432C", Offset = "0x13D432C", VA = "0x13D432C")]
		public ES3Type_ES3RefDictionary()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[Preserve]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x11ECA84", Offset = "0x11ECA84", VA = "0x11ECA84")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x11ECB58", Offset = "0x11ECB58", VA = "0x11ECB58", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000294")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000045")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x11ECBF0", Offset = "0x11ECBF0", VA = "0x11ECBF0")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[Preserve]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x11EE480", Offset = "0x11EE480", VA = "0x11EE480")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x11EE554", Offset = "0x11EE554", VA = "0x11EE554", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000299")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000047")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x11EE5EC", Offset = "0x11EE5EC", VA = "0x11EE5EC")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[Preserve]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x11EE6E8", Offset = "0x11EE6E8", VA = "0x11EE6E8")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x11EE7BC", Offset = "0x11EE7BC", VA = "0x11EE7BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600029E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000049")]
	[Preserve]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x11EE854", Offset = "0x11EE854", VA = "0x11EE854")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x11EE928", Offset = "0x11EE928", VA = "0x11EE928", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002A2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004A")]
	[Preserve]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x11EE9C0", Offset = "0x11EE9C0", VA = "0x11EE9C0")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x11EEA94", Offset = "0x11EEA94", VA = "0x11EEA94", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002A6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004B")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x11EEB2C", Offset = "0x11EEB2C", VA = "0x11EEB2C")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[Preserve]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x11EEC28", Offset = "0x11EEC28", VA = "0x11EEC28")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x11EECFC", Offset = "0x11EECFC", VA = "0x11EECFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002AB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x11EED94", Offset = "0x11EED94", VA = "0x11EED94")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[Preserve]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x11EEE90", Offset = "0x11EEE90", VA = "0x11EEE90")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x11EEF64", Offset = "0x11EEF64", VA = "0x11EEF64", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004F")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x11EEFFC", Offset = "0x11EEFFC", VA = "0x11EEFFC")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[Preserve]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type underlyingType;

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x11EF0F8", Offset = "0x11EF0F8", VA = "0x11EF0F8")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x11EF1D0", Offset = "0x11EF1D0", VA = "0x11EF1D0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	[Preserve]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x11EFCBC", Offset = "0x11EFCBC", VA = "0x11EFCBC")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x11EFD90", Offset = "0x11EFD90", VA = "0x11EFD90", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x11EFE28", Offset = "0x11EFE28", VA = "0x11EFE28")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[Preserve]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x11EFF24", Offset = "0x11EFF24", VA = "0x11EFF24")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x11EFFF8", Offset = "0x11EFFF8", VA = "0x11EFFF8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002BE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x11F0090", Offset = "0x11F0090", VA = "0x11F0090")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[Preserve]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x188C40C", Offset = "0x188C40C", VA = "0x188C40C")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x188C4E0", Offset = "0x188C4E0", VA = "0x188C4E0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x188C584", Offset = "0x188C584", VA = "0x188C584")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[Preserve]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11F018C", Offset = "0x11F018C", VA = "0x11F018C")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x11F0260", Offset = "0x11F0260", VA = "0x11F0260", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x11F02F8", Offset = "0x11F02F8", VA = "0x11F02F8")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[Preserve]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11F03F4", Offset = "0x11F03F4", VA = "0x11F03F4")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x11F04C8", Offset = "0x11F04C8", VA = "0x11F04C8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002CD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005A")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x11F0560", Offset = "0x11F0560", VA = "0x11F0560")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[Preserve]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x11F065C", Offset = "0x11F065C", VA = "0x11F065C")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x11F0730", Offset = "0x11F0730", VA = "0x11F0730", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005C")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x11F07C8", Offset = "0x11F07C8", VA = "0x11F07C8")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[Preserve]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11F08C4", Offset = "0x11F08C4", VA = "0x11F08C4")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x11F0998", Offset = "0x11F0998", VA = "0x11F0998", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005E")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x11E9C4C", Offset = "0x11E9C4C", VA = "0x11E9C4C")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[Preserve]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x11F0A24", Offset = "0x11F0A24", VA = "0x11F0A24")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11F0AF8", Offset = "0x11F0AF8", VA = "0x11F0AF8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002DC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000060")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x11F0B90", Offset = "0x11F0B90", VA = "0x11F0B90")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[Preserve]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x11F0C8C", Offset = "0x11F0C8C", VA = "0x11F0C8C")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x11F0D60", Offset = "0x11F0D60", VA = "0x11F0D60", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000062")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x11F0DF8", Offset = "0x11F0DF8", VA = "0x11F0DF8")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[Preserve]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11F0EF4", Offset = "0x11F0EF4", VA = "0x11F0EF4")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x11F0FC8", Offset = "0x11F0FC8", VA = "0x11F0FC8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x11F1060", Offset = "0x11F1060", VA = "0x11F1060")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[Preserve]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x13C5994", Offset = "0x13C5994", VA = "0x13C5994")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x13C59D8", Offset = "0x13C59D8", VA = "0x13C59D8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002EB")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000066")]
	[Preserve]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x13C5B20", Offset = "0x13C5B20", VA = "0x13C5B20")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x13C5B54", Offset = "0x13C5B54", VA = "0x13C5B54", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002EE")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000067")]
	[Preserve]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x13C5B58", Offset = "0x13C5B58", VA = "0x13C5B58")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x13C5B98", Offset = "0x13C5B98", VA = "0x13C5B98", Slot = "14")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F2")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000068")]
	[Preserve]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x13C5B9C", Offset = "0x13C5B9C", VA = "0x13C5B9C")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x13C5BC4", Offset = "0x13C5BC4", VA = "0x13C5BC4")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x13C5DA8", Offset = "0x13C5DA8", VA = "0x13C5DA8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000069")]
	[Preserve]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x13C6194", Offset = "0x13C6194", VA = "0x13C6194")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x13C61CC", Offset = "0x13C61CC", VA = "0x13C61CC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002FA")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006A")]
	[Preserve]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x13C61D0", Offset = "0x13C61D0", VA = "0x13C61D0")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x13C6204", Offset = "0x13C6204", VA = "0x13C6204", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002FE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006B")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x613494", Offset = "0x613494")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x13D0B70", Offset = "0x13D0B70", VA = "0x13D0B70")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x13D0C3C", Offset = "0x13D0C3C", VA = "0x13D0C3C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000302")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006C")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6135B0", Offset = "0x6135B0")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x13D0EE4", Offset = "0x13D0EE4", VA = "0x13D0EE4")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x13D0FB0", Offset = "0x13D0FB0", VA = "0x13D0FB0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000306")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6136E8", Offset = "0x6136E8")]
	[Preserve]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x13D12F8", Offset = "0x13D12F8", VA = "0x13D12F8")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x13D13C4", Offset = "0x13D13C4", VA = "0x13D13C4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600030A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x613AF8", Offset = "0x613AF8")]
	[Preserve]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x13D1F68", Offset = "0x13D1F68", VA = "0x13D1F68")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x13D2034", Offset = "0x13D2034", VA = "0x13D2034", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600030E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006F")]
	[Preserve]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x13D4858", Offset = "0x13D4858", VA = "0x13D4858")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x13D4924", Offset = "0x13D4924", VA = "0x13D4924", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000312")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x613C5C", Offset = "0x613C5C")]
	[Preserve]
	public class ES3Type_Image : ES3ComponentType
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x188B5C0", Offset = "0x188B5C0", VA = "0x188B5C0")]
		public ES3Type_Image()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x188B698", Offset = "0x188B698", VA = "0x188B698", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000316")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class ES3Type_ImageArray : ES3ArrayType
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x188BF50", Offset = "0x188BF50", VA = "0x188BF50")]
		public ES3Type_ImageArray()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x613F1C", Offset = "0x613F1C")]
	[Preserve]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x18C9ABC", Offset = "0x18C9ABC", VA = "0x18C9ABC")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x18C9B88", Offset = "0x18C9B88", VA = "0x18C9B88", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600031B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x18C9EAC", Offset = "0x18C9EAC", VA = "0x18C9EAC")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x614070", Offset = "0x614070")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x18C9FA8", Offset = "0x18C9FA8", VA = "0x18C9FA8")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x18CA074", Offset = "0x18CA074", VA = "0x18CA074", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000320")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x18CA120", Offset = "0x18CA120", VA = "0x18CA120")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x614100", Offset = "0x614100")]
	[Preserve]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x18CA21C", Offset = "0x18CA21C", VA = "0x18CA21C")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x18CA2E8", Offset = "0x18CA2E8", VA = "0x18CA2E8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000325")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x18CAAF4", Offset = "0x18CAAF4", VA = "0x18CAAF4")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x614350", Offset = "0x614350")]
	[Preserve]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x18CC180", Offset = "0x18CC180", VA = "0x18CC180")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x18CC24C", Offset = "0x18CC24C", VA = "0x18CC24C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000079")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6146B8", Offset = "0x6146B8")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x18CD4D0", Offset = "0x18CD4D0", VA = "0x18CD4D0")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x18CD59C", Offset = "0x18CD59C", VA = "0x18CD59C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x18CDB24", Offset = "0x18CDB24", VA = "0x18CDB24")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x614828", Offset = "0x614828")]
	[Preserve]
	public class ES3Type_RawImage : ES3ComponentType
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x18CE2D4", Offset = "0x18CE2D4", VA = "0x18CE2D4")]
		public ES3Type_RawImage()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x18CE3AC", Offset = "0x18CE3AC", VA = "0x18CE3AC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000333")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class ES3Type_RawImageArray : ES3ArrayType
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x18CE908", Offset = "0x18CE908", VA = "0x18CE908")]
		public ES3Type_RawImageArray()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6149D0", Offset = "0x6149D0")]
	[Preserve]
	public class ES3Type_Rigidbody : ES3ComponentType
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x18CFC5C", Offset = "0x18CFC5C", VA = "0x18CFC5C")]
		public ES3Type_Rigidbody()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x18CFD34", Offset = "0x18CFD34", VA = "0x18CFD34", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000338")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class ES3UserType_RigidbodyArray : ES3ArrayType
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11F15FC", Offset = "0x11F15FC", VA = "0x11F15FC")]
		public ES3UserType_RigidbodyArray()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x614CAC", Offset = "0x614CAC")]
	[Preserve]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x11E8860", Offset = "0x11E8860", VA = "0x11E8860")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x11E892C", Offset = "0x11E892C", VA = "0x11E892C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600033D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x614DC8", Offset = "0x614DC8")]
	[Preserve]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x11EA0D4", Offset = "0x11EA0D4", VA = "0x11EA0D4")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x11EA1A0", Offset = "0x11EA1A0", VA = "0x11EA1A0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000341")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000081")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6150C0", Offset = "0x6150C0")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int countRead;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ES3Type Instance;

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x11EC3C4", Offset = "0x11EC3C4", VA = "0x11EC3C4")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x11EC490", Offset = "0x11EC490", VA = "0x11EC490", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000345")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6151A4", Offset = "0x6151A4")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x13CFBCC", Offset = "0x13CFBCC", VA = "0x13CFBCC")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x13CFC94", Offset = "0x13CFC94", VA = "0x13CFC94", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000349")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000083")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61526C", Offset = "0x61526C")]
	public class ES3Type_AudioClip : ES3UnityObjectType
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x13CFE38", Offset = "0x13CFE38", VA = "0x13CFE38")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x13CFF04", Offset = "0x13CFF04", VA = "0x13CFF04", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600034E")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600034F")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x13D014C", Offset = "0x13D014C", VA = "0x13D014C")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61536C", Offset = "0x61536C")]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x13D0248", Offset = "0x13D0248", VA = "0x13D0248")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x13D0310", Offset = "0x13D0310", VA = "0x13D0310", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000354")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000086")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x13D070C", Offset = "0x13D070C", VA = "0x13D070C")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6154C0", Offset = "0x6154C0")]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x13D0808", Offset = "0x13D0808", VA = "0x13D0808")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x13D08D0", Offset = "0x13D08D0", VA = "0x13D08D0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000359")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x13D0A74", Offset = "0x13D0A74", VA = "0x13D0A74")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61556C", Offset = "0x61556C")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x13D24BC", Offset = "0x13D24BC", VA = "0x13D24BC")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x13D2584", Offset = "0x13D2584", VA = "0x13D2584", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600035E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008A")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6157D8", Offset = "0x6157D8")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x13D2C84", Offset = "0x13D2C84", VA = "0x13D2C84")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x13D2D4C", Offset = "0x13D2D4C", VA = "0x13D2D4C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000363")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x13D338C", Offset = "0x13D338C", VA = "0x13D338C")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6158BC", Offset = "0x6158BC")]
	[Preserve]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x13D2F68", Offset = "0x13D2F68", VA = "0x13D2F68")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x13D3030", Offset = "0x13D3030", VA = "0x13D3030", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000368")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x13D3248", Offset = "0x13D3248", VA = "0x13D3248")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008D")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x13D3290", Offset = "0x13D3290", VA = "0x13D3290")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6159A0", Offset = "0x6159A0")]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x13D3488", Offset = "0x13D3488", VA = "0x13D3488")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x13D3550", Offset = "0x13D3550", VA = "0x13D3550", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600036E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008F")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x615A68", Offset = "0x615A68")]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x13D37FC", Offset = "0x13D37FC", VA = "0x13D37FC")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x13D38C4", Offset = "0x13D38C4", VA = "0x13D38C4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000373")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000090")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x615B14", Offset = "0x615B14")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x13D442C", Offset = "0x13D442C", VA = "0x13D442C")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x13D44F4", Offset = "0x13D44F4", VA = "0x13D44F4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000378")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000091")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x615C14", Offset = "0x615C14")]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x13D492C", Offset = "0x13D492C", VA = "0x13D492C")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x13D49F4", Offset = "0x13D49F4", VA = "0x13D49F4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600037D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000092")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x615CC0", Offset = "0x615CC0")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x13D4BD4", Offset = "0x13D4BD4", VA = "0x13D4BD4")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x13D4C9C", Offset = "0x13D4C9C", VA = "0x13D4C9C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000382")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1888F50", Offset = "0x1888F50", VA = "0x1888F50")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x615D50", Offset = "0x615D50")]
	[Preserve]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x188904C", Offset = "0x188904C", VA = "0x188904C")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1889118", Offset = "0x1889118", VA = "0x1889118", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000388")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000389")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1889244", Offset = "0x1889244", VA = "0x1889244")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x615DFC", Offset = "0x615DFC")]
	[Preserve]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1889340", Offset = "0x1889340", VA = "0x1889340")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x188940C", Offset = "0x188940C", VA = "0x188940C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600038E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000097")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x615F6C", Offset = "0x615F6C")]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6160A4", Offset = "0x6160A4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Predicate<Component> <>9__0;

			[Token(Token = "0x600039C")]
			[Address(RVA = "0x1939218", Offset = "0x1939218", VA = "0x1939218")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1939220", Offset = "0x1939220", VA = "0x1939220")]
			internal bool <ReadComponents>b__0(Component x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000118")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x4000119")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool saveChildren;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x18898FC", Offset = "0x18898FC", VA = "0x18898FC")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x18899C8", Offset = "0x18899C8", VA = "0x18899C8", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x6000393")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x188A464", Offset = "0x188A464", VA = "0x188A464")]
		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x188AAF0", Offset = "0x188AAF0", VA = "0x188AAF0")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x188A148", Offset = "0x188A148", VA = "0x188A148")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x188AB84", Offset = "0x188AB84", VA = "0x188AB84", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000399")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600039A")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000099")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x188AB8C", Offset = "0x188AB8C", VA = "0x188AB8C")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6160B4", Offset = "0x6160B4")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x188AC88", Offset = "0x188AC88", VA = "0x188AC88")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x188AD54", Offset = "0x188AD54", VA = "0x188AD54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009B")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61617C", Offset = "0x61617C")]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x188AF04", Offset = "0x188AF04", VA = "0x188AF04")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x188AFD0", Offset = "0x188AFD0", VA = "0x188AFD0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200009C")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x188B140", Offset = "0x188B140", VA = "0x188B140")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x616228", Offset = "0x616228")]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x188B23C", Offset = "0x188B23C", VA = "0x188B23C")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x188B308", Offset = "0x188B308", VA = "0x188B308", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200009E")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x188B4C4", Offset = "0x188B4C4", VA = "0x188B4C4")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6162D4", Offset = "0x6162D4")]
	[Preserve]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x188C04C", Offset = "0x188C04C", VA = "0x188C04C")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x188C118", Offset = "0x188C118", VA = "0x188C118", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6163B8", Offset = "0x6163B8")]
	[Preserve]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x188C680", Offset = "0x188C680", VA = "0x188C680")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x188C74C", Offset = "0x188C74C", VA = "0x188C74C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A1")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x188C99C", Offset = "0x188C99C", VA = "0x188C99C")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61649C", Offset = "0x61649C")]
	[Preserve]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x188CA98", Offset = "0x188CA98", VA = "0x188CA98")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x188CB64", Offset = "0x188CB64", VA = "0x188CB64", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003BA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x616564", Offset = "0x616564")]
	[Preserve]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x188CC98", Offset = "0x188CC98", VA = "0x188CC98")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x188CD64", Offset = "0x188CD64", VA = "0x188CD64", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003BE")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x616840", Offset = "0x616840")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x188D65C", Offset = "0x188D65C", VA = "0x188D65C")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x188D728", Offset = "0x188D728", VA = "0x188D728", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x616A04", Offset = "0x616A04")]
	[Preserve]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x188DD4C", Offset = "0x188DD4C", VA = "0x188DD4C")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x188DE18", Offset = "0x188DE18", VA = "0x188DE18", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x616BC8", Offset = "0x616BC8")]
	[Preserve]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x188E41C", Offset = "0x188E41C", VA = "0x188E41C")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x188E4E8", Offset = "0x188E4E8", VA = "0x188E4E8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003CC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617048", Offset = "0x617048")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x188F4D0", Offset = "0x188F4D0", VA = "0x188F4D0")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x188F59C", Offset = "0x188F59C", VA = "0x188F59C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D1")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x18C8E44", Offset = "0x18C8E44", VA = "0x18C8E44")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617148", Offset = "0x617148")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x18C8F40", Offset = "0x18C8F40", VA = "0x18C8F40")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x18C900C", Offset = "0x18C900C", VA = "0x18C900C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AA")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x18C9280", Offset = "0x18C9280", VA = "0x18C9280")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61722C", Offset = "0x61722C")]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x18C937C", Offset = "0x18C937C", VA = "0x18C937C")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x18C9448", Offset = "0x18C9448", VA = "0x18C9448", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DC")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617428", Offset = "0x617428")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x18CABF0", Offset = "0x18CABF0", VA = "0x18CABF0")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x18CACBC", Offset = "0x18CACBC", VA = "0x18CACBC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E1")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61757C", Offset = "0x61757C")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x18CB078", Offset = "0x18CB078", VA = "0x18CB078")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x18CB144", Offset = "0x18CB144", VA = "0x18CB144", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6176B4", Offset = "0x6176B4")]
	[Preserve]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x18CB4D0", Offset = "0x18CB4D0", VA = "0x18CB4D0")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x18CB59C", Offset = "0x18CB59C", VA = "0x18CB59C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003EA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617A1C", Offset = "0x617A1C")]
	[Preserve]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x18CCD20", Offset = "0x18CCD20", VA = "0x18CCD20")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x18CCDEC", Offset = "0x18CCDEC", VA = "0x18CCDEC", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003EF")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003F0")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x18CD094", Offset = "0x18CD094", VA = "0x18CD094")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617B1C", Offset = "0x617B1C")]
	[Preserve]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x18CD190", Offset = "0x18CD190", VA = "0x18CD190")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x18CD25C", Offset = "0x18CD25C", VA = "0x18CD25C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F5")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003F6")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B2")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x18CD3D4", Offset = "0x18CD3D4", VA = "0x18CD3D4")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617BC8", Offset = "0x617BC8")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x18CDC20", Offset = "0x18CDC20", VA = "0x18CDC20")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x18CDCEC", Offset = "0x18CDCEC", VA = "0x18CDCEC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B4")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x18CDF08", Offset = "0x18CDF08", VA = "0x18CDF08")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617CAC", Offset = "0x617CAC")]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x18CEA04", Offset = "0x18CEA04", VA = "0x18CEA04")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x18CEAD0", Offset = "0x18CEAD0", VA = "0x18CEAD0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000400")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617D90", Offset = "0x617D90")]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x18CED10", Offset = "0x18CED10", VA = "0x18CED10")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x18CEDDC", Offset = "0x18CEDDC", VA = "0x18CEDDC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000404")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x617F54", Offset = "0x617F54")]
	public class ES3Type_RenderTexture : ES3ObjectType
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x18CF35C", Offset = "0x18CF35C", VA = "0x18CF35C")]
		public ES3Type_RenderTexture()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x18CF428", Offset = "0x18CF428", VA = "0x18CF428", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000408")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000409")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B8")]
	public class ES3Type_RenderTextureArray : ES3ArrayType
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x18CFB60", Offset = "0x18CFB60", VA = "0x18CFB60")]
		public ES3Type_RenderTextureArray()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x618348", Offset = "0x618348")]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x18D0764", Offset = "0x18D0764", VA = "0x18D0764")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x18D0830", Offset = "0x18D0830", VA = "0x18D0830", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600040E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6184B8", Offset = "0x6184B8")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x18D0D58", Offset = "0x18D0D58", VA = "0x18D0D58")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x18D0E24", Offset = "0x18D0E24", VA = "0x18D0E24", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000413")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61860C", Offset = "0x61860C")]
	[Preserve]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x18D12B8", Offset = "0x18D12B8", VA = "0x18D12B8")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x18D1384", Offset = "0x18D1384", VA = "0x18D1384", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000418")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x18D1524", Offset = "0x18D1524", VA = "0x18D1524")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6186B8", Offset = "0x6186B8")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x18D1620", Offset = "0x18D1620", VA = "0x18D1620")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x18D16EC", Offset = "0x18D16EC", VA = "0x18D16EC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600041E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x618940", Offset = "0x618940")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x18D1ED0", Offset = "0x18D1ED0", VA = "0x18D1ED0")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x18D1F9C", Offset = "0x18D1F9C", VA = "0x18D1F9C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000423")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x618AE8", Offset = "0x618AE8")]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x18D2584", Offset = "0x18D2584", VA = "0x18D2584")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x18D2650", Offset = "0x18D2650", VA = "0x18D2650", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000428")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x618C74", Offset = "0x618C74")]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x18D2BA4", Offset = "0x18D2BA4", VA = "0x18D2BA4")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x18D2C70", Offset = "0x18D2C70", VA = "0x18D2C70", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600042D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x11E8764", Offset = "0x11E8764", VA = "0x11E8764")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x618F6C", Offset = "0x618F6C")]
	[Preserve]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x11E8CB8", Offset = "0x11E8CB8", VA = "0x11E8CB8")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x11E8DC0", Offset = "0x11E8DC0", VA = "0x11E8DC0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000432")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000433")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x61906C", Offset = "0x61906C")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x11E914C", Offset = "0x11E914C", VA = "0x11E914C")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x11E9218", Offset = "0x11E9218", VA = "0x11E9218", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000437")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x11E9B50", Offset = "0x11E9B50", VA = "0x11E9B50")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x619310", Offset = "0x619310")]
	[Preserve]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x11E9D48", Offset = "0x11E9D48", VA = "0x11E9D48")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x11E9E14", Offset = "0x11E9E14", VA = "0x11E9E14", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600043C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6193D8", Offset = "0x6193D8")]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x11EA974", Offset = "0x11EA974", VA = "0x11EA974")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x11EAA40", Offset = "0x11EAA40", VA = "0x11EAA40", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000441")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000442")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C7")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x11EB338", Offset = "0x11EB338", VA = "0x11EB338")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6194D8", Offset = "0x6194D8")]
	[Preserve]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x11EABF4", Offset = "0x11EABF4", VA = "0x11EABF4")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x11EACCC", Offset = "0x11EACCC", VA = "0x11EACCC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000447")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000448")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x11EB1A4", Offset = "0x11EB1A4", VA = "0x11EB1A4")]
		protected bool IsReadable(Texture2D instance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C9")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x11EB23C", Offset = "0x11EB23C", VA = "0x11EB23C")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6195D8", Offset = "0x6195D8")]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x11EB434", Offset = "0x11EB434", VA = "0x11EB434")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x11EB500", Offset = "0x11EB500", VA = "0x11EB500", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600044E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6197D4", Offset = "0x6197D4")]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x11EBB4C", Offset = "0x11EBB4C", VA = "0x11EBB4C")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x11EBC18", Offset = "0x11EBC18", VA = "0x11EBC18", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000453")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x6199EC", Offset = "0x6199EC")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x11EC684", Offset = "0x11EC684", VA = "0x11EC684")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x11EC750", Offset = "0x11EC750", VA = "0x11EC750", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000458")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x619B08", Offset = "0x619B08")]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x11ECCEC", Offset = "0x11ECCEC", VA = "0x11ECCEC")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x11ECDB8", Offset = "0x11ECDB8", VA = "0x11ECDB8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600045D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CE")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x11ECF28", Offset = "0x11ECF28", VA = "0x11ECF28")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x619BB4", Offset = "0x619BB4")]
	public class ES3Type_Vector2Int : ES3Type
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x11ED024", Offset = "0x11ED024", VA = "0x11ED024")]
		public ES3Type_Vector2Int()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x11ED0F0", Offset = "0x11ED0F0", VA = "0x11ED0F0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000462")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D0")]
	public class ES3Type_Vector2IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x11ED264", Offset = "0x11ED264", VA = "0x11ED264")]
		public ES3Type_Vector2IntArray()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x619C60", Offset = "0x619C60")]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x11ED360", Offset = "0x11ED360", VA = "0x11ED360")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x11ED42C", Offset = "0x11ED42C", VA = "0x11ED42C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000467")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D2")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x11ED5F4", Offset = "0x11ED5F4", VA = "0x11ED5F4")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x619D28", Offset = "0x619D28")]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x11ED6F0", Offset = "0x11ED6F0", VA = "0x11ED6F0")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x11ED7BC", Offset = "0x11ED7BC", VA = "0x11ED7BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600046C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D4")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x11ED9BC", Offset = "0x11ED9BC", VA = "0x11ED9BC")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x619DF0", Offset = "0x619DF0")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x11EDAB8", Offset = "0x11EDAB8", VA = "0x11EDAB8")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x11EDB84", Offset = "0x11EDB84", VA = "0x11EDB84", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000471")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x11EDD9C", Offset = "0x11EDD9C", VA = "0x11EDD9C")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D6")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x11EDE3C", Offset = "0x11EDE3C", VA = "0x11EDE3C")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x619ED4", Offset = "0x619ED4")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x11EDF38", Offset = "0x11EDF38", VA = "0x11EDF38")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x11EE004", Offset = "0x11EE004", VA = "0x11EE004", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000477")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x20000D8")]
	internal static class ES3Debug
	{
		[Token(Token = "0x400015D")]
		private const string disableInfoMsg = "\n<i>To disable these messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Info'</i>";

		[Token(Token = "0x400015E")]
		private const string disableWarningMsg = "\n<i>To disable warnings from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Warnings'</i>";

		[Token(Token = "0x400015F")]
		private const string disableErrorMsg = "\n<i>To disable these error messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Errors'</i>";

		[Token(Token = "0x4000160")]
		private const char indentChar = '-';

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xA02114", Offset = "0xA02114", VA = "0xA02114")]
		public static void Log(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x9FCB44", Offset = "0x9FCB44", VA = "0x9FCB44")]
		public static void LogWarning(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x9FE5EC", Offset = "0x9FE5EC", VA = "0x9FE5EC")]
		public static void LogError(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xA02300", Offset = "0xA02300", VA = "0xA02300")]
		private static string Indent(int size)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D9")]
	public static class ES3Hash
	{
		[Token(Token = "0x600047E")]
		[Address(RVA = "0xA04618", Offset = "0xA04618", VA = "0xA04618")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DA")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x600047F")]
		public abstract byte[] Encrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000480")]
		public abstract byte[] Decrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000481")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000482")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x11F41A0", Offset = "0x11F41A0", VA = "0x11F41A0")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x11F4284", Offset = "0x11F4284", VA = "0x11F4284")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x4000161")]
		private const int ivSize = 16;

		[Token(Token = "0x4000162")]
		private const int keySize = 16;

		[Token(Token = "0x4000163")]
		private const int pwIterations = 100;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x9E7CDC", Offset = "0x9E7CDC", VA = "0x9E7CDC", Slot = "4")]
		public override byte[] Encrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x9E7F4C", Offset = "0x9E7F4C", VA = "0x9E7F4C", Slot = "5")]
		public override byte[] Decrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x9E81BC", Offset = "0x9E81BC", VA = "0x9E81BC", Slot = "6")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x9E8610", Offset = "0x9E8610", VA = "0x9E8610", Slot = "7")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x9E8A4C", Offset = "0x9E8A4C", VA = "0x9E8A4C")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool disposed;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x11F428C", Offset = "0x11F428C", VA = "0x11F428C")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x11F4358", Offset = "0x11F4358", VA = "0x11F4358", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public struct ES3Data
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xA02004", Offset = "0xA02004", VA = "0xA02004")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xA020E0", Offset = "0xA020E0", VA = "0xA020E0")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public static class ES3IO
	{
		[Token(Token = "0x20000DF")]
		public enum ES3FileMode
		{
			[Token(Token = "0x4000170")]
			Read,
			[Token(Token = "0x4000171")]
			Write,
			[Token(Token = "0x4000172")]
			Append
		}

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly string persistentDataPath;

		[Token(Token = "0x400016D")]
		internal const string backupFileSuffix = ".bac";

		[Token(Token = "0x400016E")]
		internal const string temporaryFileSuffix = ".tmp";

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x9FA548", Offset = "0x9FA548", VA = "0x9FA548")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x9F4C44", Offset = "0x9F4C44", VA = "0x9F4C44")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x9F6858", Offset = "0x9F6858", VA = "0x9F6858")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x9F6ED4", Offset = "0x9F6ED4", VA = "0x9F6ED4")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x9F7854", Offset = "0x9F7854", VA = "0x9F7854")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x9F6EDC", Offset = "0x9F6EDC", VA = "0x9F6EDC")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x9F83CC", Offset = "0x9F83CC", VA = "0x9F83CC")]
		public static void MoveDirectory(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x9F7D9C", Offset = "0x9F7D9C", VA = "0x9F7D9C")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x9F8340", Offset = "0x9F8340", VA = "0x9F8340")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xA044C8", Offset = "0xA044C8", VA = "0xA044C8")]
		public static string GetDirectoryPath(string path, char seperator = '/')
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xA05114", Offset = "0xA05114", VA = "0xA05114")]
		public static bool UsesForwardSlash(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x9F7EC8", Offset = "0x9F7EC8", VA = "0x9F7EC8")]
		public static string CombinePathAndFilename(string directoryPath, string fileOrDirectoryName)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x9F9D84", Offset = "0x9F9D84", VA = "0x9F9D84")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x9F8348", Offset = "0x9F8348", VA = "0x9F8348")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x9F9B28", Offset = "0x9F9B28", VA = "0x9F9B28")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xA0516C", Offset = "0xA0516C", VA = "0xA0516C")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xA05174", Offset = "0xA05174", VA = "0xA05174")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x9F3D60", Offset = "0x9F3D60", VA = "0x9F3D60")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x13BEDE8", Offset = "0x13BEDE8", VA = "0x13BEDE8")]
		public void Awake()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x13BF4D8", Offset = "0x13BF4D8", VA = "0x13BF4D8")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x13BF554", Offset = "0x13BF554", VA = "0x13BF554")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x13BF68C", Offset = "0x13BF68C", VA = "0x13BF68C")]
		public Dictionary<string, string> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x13BF8F4", Offset = "0x13BF8F4", VA = "0x13BF8F4")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x13BF634", Offset = "0x13BF634", VA = "0x13BF634")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x13BFEC8", Offset = "0x13BFEC8", VA = "0x13BFEC8")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E1")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A038", Offset = "0x61A038")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Object obj;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__0;

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x11F9DCC", Offset = "0x11F9DCC", VA = "0x11F9DCC")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x11F9DD4", Offset = "0x11F9DD4", VA = "0x11F9DD4")]
			internal bool <Remove>b__0(KeyValuePair<long, UnityEngine.Object> kvp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A048", Offset = "0x61A048")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long referenceID;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<UnityEngine.Object, long>, bool> <>9__0;

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x11F9E58", Offset = "0x11F9E58", VA = "0x11F9E58")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x11F9E60", Offset = "0x11F9E60", VA = "0x11F9E60")]
			internal bool <Remove>b__0(KeyValuePair<UnityEngine.Object, long> kvp)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A058", Offset = "0x61A058")]
		private sealed class <>c
		{
			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__31_0;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, long> <>9__31_1;

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x11F9CC0", Offset = "0x11F9CC0", VA = "0x11F9CC0")]
			public <>c()
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x11F9CC8", Offset = "0x11F9CC8", VA = "0x11F9CC8")]
			internal bool <RemoveNullOrInvalidValues>b__31_0(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x11F9D8C", Offset = "0x11F9D8C", VA = "0x11F9D8C")]
			internal long <RemoveNullOrInvalidValues>b__31_1(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(long);
			}
		}

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _lock;

		[Token(Token = "0x4000176")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HashSet<ES3ReferenceMgrBase> mgrs;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Random rng;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ES3RefIdDictionary _refId;

		[Token(Token = "0x17000028")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x13BEFCC", Offset = "0x13BEFCC", VA = "0x13BEFCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public bool IsInitialised
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x13C2EE8", Offset = "0x13C2EE8", VA = "0x13C2EE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public ES3RefIdDictionary refId
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x13C2F48", Offset = "0x13C2F48", VA = "0x13C2F48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x13C313C", Offset = "0x13C313C", VA = "0x13C313C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public ES3GlobalReferences GlobalReferences
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x13C3144", Offset = "0x13C3144", VA = "0x13C3144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x13C314C", Offset = "0x13C314C", VA = "0x13C314C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x13C353C", Offset = "0x13C353C", VA = "0x13C353C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x13C3400", Offset = "0x13C3400", VA = "0x13C3400")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x13C35C8", Offset = "0x13C35C8", VA = "0x13C35C8")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x13C3814", Offset = "0x13C3814", VA = "0x13C3814")]
		internal UnityEngine.Object Get(long id, Type type, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x13C3E64", Offset = "0x13C3E64", VA = "0x13C3E64")]
		public UnityEngine.Object Get(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x13C3E70", Offset = "0x13C3E70", VA = "0x13C3E70")]
		public ES3Prefab GetPrefab(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x13C4270", Offset = "0x13C4270", VA = "0x13C4270")]
		public long GetPrefab(ES3Prefab prefabToFind, bool suppressWarnings = false)
		{
			return default(long);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x13BF2E0", Offset = "0x13BF2E0", VA = "0x13BF2E0")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x13BFB2C", Offset = "0x13BFB2C", VA = "0x13BFB2C")]
		public long Add(UnityEngine.Object obj, long id)
		{
			return default(long);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x13C4680", Offset = "0x13C4680", VA = "0x13C4680")]
		public bool AddPrefab(ES3Prefab prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x13C4720", Offset = "0x13C4720", VA = "0x13C4720")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x13C4C3C", Offset = "0x13C4C3C", VA = "0x13C4C3C")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x13C5164", Offset = "0x13C5164", VA = "0x13C5164")]
		public void RemoveNullOrInvalidValues()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x13C5504", Offset = "0x13C5504", VA = "0x13C5504")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x13C5630", Offset = "0x13C5630", VA = "0x13C5630")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x13C5698", Offset = "0x13C5698", VA = "0x13C5698")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x13C56FC", Offset = "0x13C56FC", VA = "0x13C56FC")]
		public void ChangeId(long oldId, long newId)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x13BFD18", Offset = "0x13BFD18", VA = "0x13BFD18")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x13BF62C", Offset = "0x13BF62C", VA = "0x13BF62C")]
		internal static bool CanBeSaved(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x13C2DF4", Offset = "0x13C2DF4", VA = "0x13C2DF4")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E5")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xA051D8", Offset = "0xA051D8", VA = "0xA051D8", Slot = "35")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xA051E4", Offset = "0xA051E4", VA = "0xA051E4", Slot = "36")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xA05258", Offset = "0xA05258", VA = "0xA05258")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A068", Offset = "0x61A068")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x13C2D14", Offset = "0x13C2D14", VA = "0x13C2D14", Slot = "35")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x13C2D88", Offset = "0x13C2D88", VA = "0x13C2D88", Slot = "36")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x13BFF3C", Offset = "0x13BFF3C", VA = "0x13BFF3C")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public static class ES3Reflection
	{
		[Token(Token = "0x20000E8")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x1700002D")]
			public bool IsNull
			{
				[Token(Token = "0x60004FA")]
				[Address(RVA = "0x11F2E78", Offset = "0x11F2E78", VA = "0x11F2E78")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002E")]
			public string Name
			{
				[Token(Token = "0x60004FB")]
				[Address(RVA = "0x11FA0A8", Offset = "0x11FA0A8", VA = "0x11FA0A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			public Type MemberType
			{
				[Token(Token = "0x60004FC")]
				[Address(RVA = "0x11F2F14", Offset = "0x11F2F14", VA = "0x11F2F14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			public bool IsPublic
			{
				[Token(Token = "0x60004FD")]
				[Address(RVA = "0x11FA0DC", Offset = "0x11FA0DC", VA = "0x11FA0DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000031")]
			public bool IsProtected
			{
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0x11FA17C", Offset = "0x11FA17C", VA = "0x11FA17C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool IsStatic
			{
				[Token(Token = "0x60004FF")]
				[Address(RVA = "0x11FA1D0", Offset = "0x11FA1D0", VA = "0x11FA1D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x11FA224", Offset = "0x11FA224", VA = "0x11FA224")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x11FA404", Offset = "0x11FA404", VA = "0x11FA404")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x11F2EC4", Offset = "0x11F2EC4", VA = "0x11F2EC4")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x20000E9")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x19390DC", Offset = "0x19390DC", VA = "0x19390DC")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1939160", Offset = "0x1939160", VA = "0x1939160")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes, BindingFlags bindingAttr)
			{
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x19391F4", Offset = "0x19391F4", VA = "0x19391F4")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A07C", Offset = "0x61A07C")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x11FA010", Offset = "0x11FA010", VA = "0x11FA010")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x11FA018", Offset = "0x11FA018", VA = "0x11FA018")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A08C", Offset = "0x61A08C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__27_0;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, <>f__AnonymousType0<Assembly, Type>> <>9__27_1;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType0<Assembly, Type>, Type> <>9__27_3;

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x11F9F18", Offset = "0x11F9F18", VA = "0x11F9F18")]
			public <>c()
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x11F9F20", Offset = "0x11F9F20", VA = "0x11F9F20")]
			internal IEnumerable<Type> <GetDerivedTypes>b__27_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x11F9F44", Offset = "0x11F9F44", VA = "0x11F9F44")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__27_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x11F9FC8", Offset = "0x11F9FC8", VA = "0x11F9FC8")]
			internal Type <GetDerivedTypes>b__27_3(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x4000185")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x4000186")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x4000187")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] excludedPropertyNames;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Type es3SerializableAttributeType;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Type es3NonSerializableAttributeType;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x1700002C")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x13C6208", Offset = "0x13C6208", VA = "0x13C6208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x13C64EC", Offset = "0x13C64EC", VA = "0x13C64EC")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x13C66C4", Offset = "0x13C66C4", VA = "0x13C66C4")]
		public static List<FieldInfo> GetSerializableFields(Type type, [Optional] List<FieldInfo> serializableFields, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x13C707C", Offset = "0x13C707C", VA = "0x13C707C")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, [Optional] List<PropertyInfo> serializableProperties, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x13C6CFC", Offset = "0x13C6CFC", VA = "0x13C6CFC")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x13BDB5C", Offset = "0x13BDB5C", VA = "0x13BDB5C")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x13C0754", Offset = "0x13C0754", VA = "0x13C0754")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x13C7964", Offset = "0x13C7964", VA = "0x13C7964")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x13C79EC", Offset = "0x13C79EC", VA = "0x13C79EC")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x13C068C", Offset = "0x13C068C", VA = "0x13C068C")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x13C79F4", Offset = "0x13C79F4", VA = "0x13C79F4")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x13C1D9C", Offset = "0x13C1D9C", VA = "0x13C1D9C")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x13C1FC4", Offset = "0x13C1FC4", VA = "0x13C1FC4")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x60004DE")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x13C7FF4", Offset = "0x13C7FF4", VA = "0x13C7FF4")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x13C6174", Offset = "0x13C6174", VA = "0x13C6174")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x13C83DC", Offset = "0x13C83DC", VA = "0x13C83DC")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x13C6684", Offset = "0x13C6684", VA = "0x13C6684")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x13C83FC", Offset = "0x13C83FC", VA = "0x13C83FC")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x13C841C", Offset = "0x13C841C", VA = "0x13C841C")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x13C843C", Offset = "0x13C843C", VA = "0x13C843C")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x13C7844", Offset = "0x13C7844", VA = "0x13C7844")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x13C66A4", Offset = "0x13C66A4", VA = "0x13C66A4")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x13C84C4", Offset = "0x13C84C4", VA = "0x13C84C4")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x13C84DC", Offset = "0x13C84DC", VA = "0x13C84DC")]
		public static bool IsInterface(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x13C6664", Offset = "0x13C6664", VA = "0x13C6664")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x13C782C", Offset = "0x13C782C", VA = "0x13C782C")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x13C84F4", Offset = "0x13C84F4", VA = "0x13C84F4")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x13C785C", Offset = "0x13C785C", VA = "0x13C785C")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x13C8514", Offset = "0x13C8514", VA = "0x13C8514")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x13C858C", Offset = "0x13C858C", VA = "0x13C858C")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x13C7D34", Offset = "0x13C7D34", VA = "0x13C7D34")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x13C7E90", Offset = "0x13C7E90", VA = "0x13C7E90")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x13C771C", Offset = "0x13C771C", VA = "0x13C771C")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x13C6CF0", Offset = "0x13C6CF0", VA = "0x13C6CF0")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x13C76FC", Offset = "0x13C76FC", VA = "0x13C76FC")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x13C8678", Offset = "0x13C8678", VA = "0x13C8678")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x13BE724", Offset = "0x13BE724", VA = "0x13BE724")]
		public static Type BaseType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x13C115C", Offset = "0x13C115C", VA = "0x13C115C")]
		public static Type GetType(string typeString)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x13C8720", Offset = "0x13C8720", VA = "0x13C8720")]
		public static string GetTypeString(Type type)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000EC")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A09C", Offset = "0x61A09C")]
		private sealed class <>c
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, bool> <>9__6_0;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, TKey> <>9__6_1;

			[Token(Token = "0x6000515")]
			public <>c()
			{
			}

			[Token(Token = "0x6000516")]
			internal bool <RemoveNullValues>b__6_0(KeyValuePair<TKey, TVal> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x6000517")]
			internal TKey <RemoveNullValues>b__6_1(KeyValuePair<TKey, TVal> pair)
			{
				return (TKey)null;
			}
		}

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x600050D")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x600050E")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x600050F")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000510")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000511")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x6000512")]
		public bool ChangeKey(TKey oldKey, TKey newKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x400019F")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamReader baseReader;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xA052AC", Offset = "0xA052AC", VA = "0xA052AC")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xA054D0", Offset = "0xA054D0", VA = "0xA054D0", Slot = "21")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xA05A48", Offset = "0xA05A48", VA = "0xA05A48", Slot = "22")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xA05BEC", Offset = "0xA05BEC", VA = "0xA05BEC", Slot = "23")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xA05BFC", Offset = "0xA05BFC", VA = "0xA05BFC", Slot = "27")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xA05F04", Offset = "0xA05F04", VA = "0xA05F04", Slot = "28")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xA05F30", Offset = "0xA05F30", VA = "0xA05F30", Slot = "29")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xA05F40", Offset = "0xA05F40", VA = "0xA05F40", Slot = "30")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xA05F44", Offset = "0xA05F44", VA = "0xA05F44", Slot = "31")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xA05F88", Offset = "0xA05F88", VA = "0xA05F88", Slot = "32")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xA05F90", Offset = "0xA05F90", VA = "0xA05F90", Slot = "33")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xA05F94", Offset = "0xA05F94", VA = "0xA05F94", Slot = "34")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xA0605C", Offset = "0xA0605C", VA = "0xA0605C", Slot = "35")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xA06064", Offset = "0xA06064", VA = "0xA06064", Slot = "36")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xA06068", Offset = "0xA06068", VA = "0xA06068", Slot = "37")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xA060AC", Offset = "0xA060AC", VA = "0xA060AC", Slot = "38")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xA06174", Offset = "0xA06174", VA = "0xA06174")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xA062B0", Offset = "0xA062B0", VA = "0xA062B0", Slot = "24")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xA0624C", Offset = "0xA0624C", VA = "0xA0624C")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xA05730", Offset = "0xA05730", VA = "0xA05730")]
		private char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
		{
			return default(char);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA05C28", Offset = "0xA05C28", VA = "0xA05C28")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA0583C", Offset = "0xA0583C", VA = "0xA0583C")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xA0682C", Offset = "0xA0682C", VA = "0xA0682C")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xA06A10", Offset = "0xA06A10", VA = "0xA06A10")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xA0569C", Offset = "0xA0569C", VA = "0xA0569C")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xA06C18", Offset = "0xA06C18", VA = "0xA06C18")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xA0541C", Offset = "0xA0541C", VA = "0xA0541C")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xA067F4", Offset = "0xA067F4", VA = "0xA067F4")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xA06770", Offset = "0xA06770", VA = "0xA06770")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xA06784", Offset = "0xA06784", VA = "0xA06784")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xA0571C", Offset = "0xA0571C", VA = "0xA0571C")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xA05810", Offset = "0xA05810", VA = "0xA05810")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xA06C98", Offset = "0xA06C98", VA = "0xA06C98")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xA06CA8", Offset = "0xA06CA8", VA = "0xA06CA8")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xA06D80", Offset = "0xA06D80", VA = "0xA06D80", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xA06F44", Offset = "0xA06F44", VA = "0xA06F44", Slot = "20")]
		internal override long Read_ref()
		{
			return default(long);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xA0708C", Offset = "0xA0708C", VA = "0xA0708C", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xA0710C", Offset = "0xA0710C", VA = "0xA0710C", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xA0718C", Offset = "0xA0718C", VA = "0xA0718C", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xA071A4", Offset = "0xA071A4", VA = "0xA071A4", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xA07218", Offset = "0xA07218", VA = "0xA07218", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xA072CC", Offset = "0xA072CC", VA = "0xA072CC", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xA07380", Offset = "0xA07380", VA = "0xA07380", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xA07398", Offset = "0xA07398", VA = "0xA07398", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xA073B0", Offset = "0xA073B0", VA = "0xA073B0", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xA073C8", Offset = "0xA073C8", VA = "0xA073C8", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xA073E4", Offset = "0xA073E4", VA = "0xA073E4", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xA07400", Offset = "0xA07400", VA = "0xA07400", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xA0741C", Offset = "0xA0741C", VA = "0xA0741C", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xA07438", Offset = "0xA07438", VA = "0xA07438", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xA074B8", Offset = "0xA074B8", VA = "0xA074B8", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class ES3GlobalReferences : ScriptableObject
	{
		[Token(Token = "0x17000033")]
		public static ES3GlobalReferences Instance
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0xA045F4", Offset = "0xA045F4", VA = "0xA045F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xA045FC", Offset = "0xA045FC", VA = "0xA045FC")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xA04604", Offset = "0xA04604", VA = "0xA04604")]
		public long GetOrAdd(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xA0460C", Offset = "0xA0460C", VA = "0xA0460C")]
		public void RemoveInvalidKeys()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xA04610", Offset = "0xA04610", VA = "0xA04610")]
		public ES3GlobalReferences()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoUpdateReferences;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xA02368", Offset = "0xA02368", VA = "0xA02368")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public enum ES3FileMode
	{
		[Token(Token = "0x40001A4")]
		Read,
		[Token(Token = "0x40001A5")]
		Write,
		[Token(Token = "0x40001A6")]
		Append
	}
	[Token(Token = "0x20000F2")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xA042BC", Offset = "0xA042BC", VA = "0xA042BC")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xA0438C", Offset = "0xA0438C", VA = "0xA0438C")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xA04498", Offset = "0xA04498", VA = "0xA04498")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xA044B8", Offset = "0xA044B8", VA = "0xA044B8")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xA045D4", Offset = "0xA045D4", VA = "0xA045D4", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000F3")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x13BE9A0", Offset = "0x13BE9A0", VA = "0x13BE9A0")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x13BEAE4", Offset = "0x13BEAE4", VA = "0x13BEAE4")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x13BE9F0", Offset = "0x13BE9F0", VA = "0x13BE9F0")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x13BEB3C", Offset = "0x13BEB3C", VA = "0x13BEB3C", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x17000034")]
		public bool Exists
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x13C9588", Offset = "0x13C9588", VA = "0x13C9588")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x13C95AC", Offset = "0x13C95AC", VA = "0x13C95AC")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x13C95DC", Offset = "0x13C95DC", VA = "0x13C95DC")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x13C96DC", Offset = "0x13C96DC", VA = "0x13C96DC", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public static class ES3Stream
	{
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x13C2274", Offset = "0x13C2274", VA = "0x13C2274")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x13C27D8", Offset = "0x13C27D8", VA = "0x13C27D8")]
		public static Stream CreateStream(Stream stream, ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x13CD000", Offset = "0x13CD000", VA = "0x13CD000")]
		public static void CopyTo(Stream source, Stream destination)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class ES3Member
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x13BE268", Offset = "0x13BE268", VA = "0x13BE268")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x13BE2C8", Offset = "0x13BE2C8", VA = "0x13BE2C8")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[Preserve]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61A710", Offset = "0x61A710")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ES3Type lastAccessedType;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x13BE744", Offset = "0x13BE744", VA = "0x13BE744")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x13CFA28", Offset = "0x13CFA28", VA = "0x13CFA28")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x13CD018", Offset = "0x13CD018", VA = "0x13CD018")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x13CEFD8", Offset = "0x13CEFD8", VA = "0x13CEFD8")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x13CED68", Offset = "0x13CED68", VA = "0x13CED68")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class ES3WebClass
	{
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A0BC", Offset = "0x61A0BC")]
		private sealed class <SendWebRequest>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3WebClass <>4__this;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000577")]
				[Address(RVA = "0x1939368", Offset = "0x1939368", VA = "0x1939368", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0x19393B0", Offset = "0x19393B0", VA = "0x19393B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x19392B4", Offset = "0x19392B4", VA = "0x19392B4")]
			[DebuggerHidden]
			public <SendWebRequest>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x19392E0", Offset = "0x19392E0", VA = "0x19392E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x19392E4", Offset = "0x19392E4", VA = "0x19392E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1939370", Offset = "0x1939370", VA = "0x1939370", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityWebRequest _webRequest;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isDone;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string error;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long errorCode;

		[Token(Token = "0x17000035")]
		public float uploadProgress
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x11F16F8", Offset = "0x11F16F8", VA = "0x11F16F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public float downloadProgress
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x11F1710", Offset = "0x11F1710", VA = "0x11F1710")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public bool isError
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x11F1728", Offset = "0x11F1728", VA = "0x11F1728")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x11F1768", Offset = "0x11F1768", VA = "0x11F1768")]
		public static bool IsNetworkError(UnityWebRequest www)
		{
			return default(bool);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x11F1790", Offset = "0x11F1790", VA = "0x11F1790")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x11F1844", Offset = "0x11F1844", VA = "0x11F1844")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x11F18E8", Offset = "0x11F18E8", VA = "0x11F18E8")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x11F1988", Offset = "0x11F1988", VA = "0x11F1988")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x11F1AE8", Offset = "0x11F1AE8", VA = "0x11F1AE8")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x11F1CDC", Offset = "0x11F1CDC", VA = "0x11F1CDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61B1B4", Offset = "0x61B1B4")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x11F1D70", Offset = "0x11F1D70", VA = "0x11F1D70", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	internal enum ES3SpecialByte : byte
	{
		[Token(Token = "0x40001C0")]
		Null = 0,
		[Token(Token = "0x40001C1")]
		Bool = 1,
		[Token(Token = "0x40001C2")]
		Byte = 2,
		[Token(Token = "0x40001C3")]
		Sbyte = 3,
		[Token(Token = "0x40001C4")]
		Char = 4,
		[Token(Token = "0x40001C5")]
		Decimal = 5,
		[Token(Token = "0x40001C6")]
		Double = 6,
		[Token(Token = "0x40001C7")]
		Float = 7,
		[Token(Token = "0x40001C8")]
		Int = 8,
		[Token(Token = "0x40001C9")]
		Uint = 9,
		[Token(Token = "0x40001CA")]
		Long = 10,
		[Token(Token = "0x40001CB")]
		Ulong = 11,
		[Token(Token = "0x40001CC")]
		Short = 12,
		[Token(Token = "0x40001CD")]
		Ushort = 13,
		[Token(Token = "0x40001CE")]
		String = 14,
		[Token(Token = "0x40001CF")]
		ByteArray = 15,
		[Token(Token = "0x40001D0")]
		Collection = 128,
		[Token(Token = "0x40001D1")]
		Dictionary = 129,
		[Token(Token = "0x40001D2")]
		CollectionItem = 130,
		[Token(Token = "0x40001D3")]
		Object = 254,
		[Token(Token = "0x40001D4")]
		Terminator = byte.MaxValue
	}
	[Token(Token = "0x20000FB")]
	internal static class ES3Binary
	{
		[Token(Token = "0x40001D5")]
		internal const string ObjectTerminator = ".";

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<ES3SpecialByte, Type> IdToType;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<Type, ES3SpecialByte> TypeToId;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x9FDC44", Offset = "0x9FDC44", VA = "0x9FDC44")]
		internal static ES3SpecialByte TypeToByte(Type type)
		{
			return default(ES3SpecialByte);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x9FDCF4", Offset = "0x9FDCF4", VA = "0x9FDCF4")]
		internal static Type ByteToType(ES3SpecialByte b)
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x9FDD54", Offset = "0x9FDD54", VA = "0x9FDD54")]
		internal static Type ByteToType(byte b)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x9FDE50", Offset = "0x9FDE50", VA = "0x9FDE50")]
		internal static bool IsPrimitive(ES3SpecialByte b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FC")]
	internal class ES3CacheWriter : ES3Writer
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ES3File es3File;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x9FE4FC", Offset = "0x9FE4FC", VA = "0x9FE4FC")]
		internal ES3CacheWriter(ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000580")]
		public override void Write<T>(string key, object value)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x9FE5A0", Offset = "0x9FE5A0", VA = "0x9FE5A0", Slot = "39")]
		internal override void Write(string key, Type type, byte[] value)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x9FE7D0", Offset = "0x9FE7D0", VA = "0x9FE7D0", Slot = "41")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x61B264", Offset = "0x61B264")]
		public override void Write(Type type, string key, object value)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x9FE83C", Offset = "0x9FE83C", VA = "0x9FE83C", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x9FE840", Offset = "0x9FE840", VA = "0x9FE840", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x9FE844", Offset = "0x9FE844", VA = "0x9FE844", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x9FE848", Offset = "0x9FE848", VA = "0x9FE848", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x9FE84C", Offset = "0x9FE84C", VA = "0x9FE84C", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x9FE850", Offset = "0x9FE850", VA = "0x9FE850", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x9FE854", Offset = "0x9FE854", VA = "0x9FE854", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x9FE858", Offset = "0x9FE858", VA = "0x9FE858", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x9FE85C", Offset = "0x9FE85C", VA = "0x9FE85C", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x9FE860", Offset = "0x9FE860", VA = "0x9FE860", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x9FE864", Offset = "0x9FE864", VA = "0x9FE864", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x9FE868", Offset = "0x9FE868", VA = "0x9FE868", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x9FE86C", Offset = "0x9FE86C", VA = "0x9FE86C", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x9FE870", Offset = "0x9FE870", VA = "0x9FE870", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x9FE874", Offset = "0x9FE874", VA = "0x9FE874", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x9FE878", Offset = "0x9FE878", VA = "0x9FE878", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x9FE87C", Offset = "0x9FE87C", VA = "0x9FE87C")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x9FE884", Offset = "0x9FE884", VA = "0x9FE884")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x9FE888", Offset = "0x9FE888", VA = "0x9FE888", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x9FE88C", Offset = "0x9FE88C", VA = "0x9FE88C", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x9FE890", Offset = "0x9FE890", VA = "0x9FE890", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x9FE894", Offset = "0x9FE894", VA = "0x9FE894", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x9FE89C", Offset = "0x9FE89C", VA = "0x9FE89C", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x9FE8A0", Offset = "0x9FE8A0", VA = "0x9FE8A0", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x9FE8A4", Offset = "0x9FE8A4", VA = "0x9FE8A4", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x9FE8A8", Offset = "0x9FE8A8", VA = "0x9FE8A8", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x9FE8AC", Offset = "0x9FE8AC", VA = "0x9FE8AC", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x9FE8B0", Offset = "0x9FE8B0", VA = "0x9FE8B0", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x9FE8B4", Offset = "0x9FE8B4", VA = "0x9FE8B4", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x9FE8B8", Offset = "0x9FE8B8", VA = "0x9FE8B8", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x9FE8BC", Offset = "0x9FE8BC", VA = "0x9FE8BC", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x9FE8C0", Offset = "0x9FE8C0", VA = "0x9FE8C0", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x9FE8C4", Offset = "0x9FE8C4", VA = "0x9FE8C4", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x9FE8C8", Offset = "0x9FE8C8", VA = "0x9FE8C8", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x9FE8CC", Offset = "0x9FE8CC", VA = "0x9FE8CC", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x9FE8D0", Offset = "0x9FE8D0", VA = "0x9FE8D0", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xA074D4", Offset = "0xA074D4", VA = "0xA074D4")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xA074E0", Offset = "0xA074E0", VA = "0xA074E0")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xA07598", Offset = "0xA07598", VA = "0xA07598", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xA075BC", Offset = "0xA075BC", VA = "0xA075BC", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xA07678", Offset = "0xA07678", VA = "0xA07678", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xA07700", Offset = "0xA07700", VA = "0xA07700", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xA077A4", Offset = "0xA077A4", VA = "0xA077A4", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xA07860", Offset = "0xA07860", VA = "0xA07860", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xA07884", Offset = "0xA07884", VA = "0xA07884", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xA078A8", Offset = "0xA078A8", VA = "0xA078A8", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xA078CC", Offset = "0xA078CC", VA = "0xA078CC", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xA07960", Offset = "0xA07960", VA = "0xA07960", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xA079F4", Offset = "0xA079F4", VA = "0xA079F4", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xA07A88", Offset = "0xA07A88", VA = "0xA07A88", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xA07B1C", Offset = "0xA07B1C", VA = "0xA07B1C", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xA07B60", Offset = "0xA07B60", VA = "0xA07B60", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xA07BE8", Offset = "0xA07BE8", VA = "0xA07BE8", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xA07E18", Offset = "0xA07E18", VA = "0xA07E18", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xA07E78", Offset = "0xA07E78", VA = "0xA07E78")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xA07EAC", Offset = "0xA07EAC", VA = "0xA07EAC")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xA07F88", Offset = "0xA07F88", VA = "0xA07F88", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xA08024", Offset = "0xA08024", VA = "0xA08024", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xA0806C", Offset = "0xA0806C", VA = "0xA0806C", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xA080C4", Offset = "0xA080C4", VA = "0xA080C4", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xA08184", Offset = "0xA08184", VA = "0xA08184", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xA0818C", Offset = "0xA0818C", VA = "0xA0818C", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xA081D0", Offset = "0xA081D0", VA = "0xA081D0", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xA08218", Offset = "0xA08218", VA = "0xA08218", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xA0825C", Offset = "0xA0825C", VA = "0xA0825C", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xA082A0", Offset = "0xA082A0", VA = "0xA082A0", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xA082CC", Offset = "0xA082CC", VA = "0xA082CC", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xA082D0", Offset = "0xA082D0", VA = "0xA082D0", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xA082E0", Offset = "0xA082E0", VA = "0xA082E0", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xA082F0", Offset = "0xA082F0", VA = "0xA082F0", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xA0831C", Offset = "0xA0831C", VA = "0xA0831C", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xA08340", Offset = "0xA08340", VA = "0xA08340", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xA08344", Offset = "0xA08344", VA = "0xA08344", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xA08348", Offset = "0xA08348", VA = "0xA08348", Slot = "22")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xA07EF8", Offset = "0xA07EF8", VA = "0xA07EF8")]
		public void WriteNewlineAndTabs()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x20000FE")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A0DC", Offset = "0x61A0DC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x11F46F0", Offset = "0x11F46F0", VA = "0x11F46F0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x11F46F8", Offset = "0x11F46F8", VA = "0x11F46F8")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x11F4714", Offset = "0x11F4714", VA = "0x11F4714")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A0EC", Offset = "0x61A0EC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x11F4730", Offset = "0x11F4730", VA = "0x11F4730")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x11F4738", Offset = "0x11F4738", VA = "0x11F4738")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x11F4754", Offset = "0x11F4754", VA = "0x11F4754")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A0FC", Offset = "0x61A0FC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x11F4770", Offset = "0x11F4770", VA = "0x11F4770")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x11F4778", Offset = "0x11F4778", VA = "0x11F4778")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x11F47B8", Offset = "0x11F47B8", VA = "0x11F47B8")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x9E8A54", Offset = "0x9E8A54", VA = "0x9E8A54")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x9E8C24", Offset = "0x9E8C24", VA = "0x9E8C24")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x9E8DCC", Offset = "0x9E8DCC", VA = "0x9E8DCC")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x9E8F88", Offset = "0x9E8F88", VA = "0x9E8F88")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x9E8FFC", Offset = "0x9E8FFC", VA = "0x9E8FFC")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x9E9070", Offset = "0x9E9070", VA = "0x9E9070")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x9E90D4", Offset = "0x9E90D4", VA = "0x9E90D4")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x9E9158", Offset = "0x9E9158", VA = "0x9E9158")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x9E91BC", Offset = "0x9E91BC", VA = "0x9E91BC")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x9E9220", Offset = "0x9E9220", VA = "0x9E9220")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x9E9284", Offset = "0x9E9284", VA = "0x9E9284")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x9E92E8", Offset = "0x9E92E8", VA = "0x9E92E8")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x9E9354", Offset = "0x9E9354", VA = "0x9E9354")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x9E93BC", Offset = "0x9E93BC", VA = "0x9E93BC")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x9E9420", Offset = "0x9E9420", VA = "0x9E9420")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000102")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A11C", Offset = "0x61A11C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x11F47DC", Offset = "0x11F47DC", VA = "0x11F47DC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x11F47E4", Offset = "0x11F47E4", VA = "0x11F47E4")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A12C", Offset = "0x61A12C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x11F4924", Offset = "0x11F4924", VA = "0x11F4924")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x11F492C", Offset = "0x11F492C", VA = "0x11F492C")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A13C", Offset = "0x61A13C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x11F4948", Offset = "0x11F4948", VA = "0x11F4948")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x11F4950", Offset = "0x11F4950", VA = "0x11F4950")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A14C", Offset = "0x61A14C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x11F496C", Offset = "0x11F496C", VA = "0x11F496C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x11F4974", Offset = "0x11F4974", VA = "0x11F4974")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A15C", Offset = "0x61A15C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x11F4990", Offset = "0x11F4990", VA = "0x11F4990")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x11F4998", Offset = "0x11F4998", VA = "0x11F4998")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A16C", Offset = "0x61A16C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x11F49B4", Offset = "0x11F49B4", VA = "0x11F49B4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x11F49BC", Offset = "0x11F49BC", VA = "0x11F49BC")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A17C", Offset = "0x61A17C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x11F49D8", Offset = "0x11F49D8", VA = "0x11F49D8")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x11F49E0", Offset = "0x11F49E0", VA = "0x11F49E0")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x11F49FC", Offset = "0x11F49FC", VA = "0x11F49FC")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x11F4A30", Offset = "0x11F4A30", VA = "0x11F4A30")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x11F4A4C", Offset = "0x11F4A4C", VA = "0x11F4A4C")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x11F4A68", Offset = "0x11F4A68", VA = "0x11F4A68")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A18C", Offset = "0x61A18C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x11F4B28", Offset = "0x11F4B28", VA = "0x11F4B28")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x11F4B30", Offset = "0x11F4B30", VA = "0x11F4B30")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A19C", Offset = "0x61A19C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x11F4B4C", Offset = "0x11F4B4C", VA = "0x11F4B4C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x11F4B54", Offset = "0x11F4B54", VA = "0x11F4B54")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x11F4B70", Offset = "0x11F4B70", VA = "0x11F4B70")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1AC", Offset = "0x61A1AC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x11F4C70", Offset = "0x11F4C70", VA = "0x11F4C70")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x11F4C78", Offset = "0x11F4C78", VA = "0x11F4C78")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1BC", Offset = "0x61A1BC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x11F4800", Offset = "0x11F4800", VA = "0x11F4800")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x11F4808", Offset = "0x11F4808", VA = "0x11F4808")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x11F4824", Offset = "0x11F4824", VA = "0x11F4824")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x9E9484", Offset = "0x9E9484", VA = "0x9E9484")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x9E9660", Offset = "0x9E9660", VA = "0x9E9660")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x9E9830", Offset = "0x9E9830", VA = "0x9E9830")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x9E9A00", Offset = "0x9E9A00", VA = "0x9E9A00")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x9E9BD0", Offset = "0x9E9BD0", VA = "0x9E9BD0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x9E9DA8", Offset = "0x9E9DA8", VA = "0x9E9DA8")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x9E9FFC", Offset = "0x9E9FFC", VA = "0x9E9FFC")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x9EA530", Offset = "0x9EA530", VA = "0x9EA530")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x9EA7AC", Offset = "0x9EA7AC", VA = "0x9EA7AC")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x9EAA48", Offset = "0x9EAA48", VA = "0x9EAA48")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9EAC38", Offset = "0x9EAC38", VA = "0x9EAC38")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200010E")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1DC", Offset = "0x61A1DC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x11F4C94", Offset = "0x11F4C94", VA = "0x11F4C94")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x11F4C9C", Offset = "0x11F4C9C", VA = "0x11F4C9C")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1EC", Offset = "0x61A1EC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x11F4CB8", Offset = "0x11F4CB8", VA = "0x11F4CB8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x11F4CC0", Offset = "0x11F4CC0", VA = "0x11F4CC0")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A1FC", Offset = "0x61A1FC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x11F4CDC", Offset = "0x11F4CDC", VA = "0x11F4CDC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x11F4CE4", Offset = "0x11F4CE4", VA = "0x11F4CE4")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A20C", Offset = "0x61A20C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x11F4D00", Offset = "0x11F4D00", VA = "0x11F4D00")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x11F4D08", Offset = "0x11F4D08", VA = "0x11F4D08")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A21C", Offset = "0x61A21C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x11F4D24", Offset = "0x11F4D24", VA = "0x11F4D24")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x11F4D2C", Offset = "0x11F4D2C", VA = "0x11F4D2C")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x11F4D48", Offset = "0x11F4D48", VA = "0x11F4D48")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x11F4D64", Offset = "0x11F4D64", VA = "0x11F4D64")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x11F4D98", Offset = "0x11F4D98", VA = "0x11F4D98")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x11F4DB4", Offset = "0x11F4DB4", VA = "0x11F4DB4")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x11F4DD0", Offset = "0x11F4DD0", VA = "0x11F4DD0")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A22C", Offset = "0x61A22C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x11F4E88", Offset = "0x11F4E88", VA = "0x11F4E88")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x11F4E90", Offset = "0x11F4E90", VA = "0x11F4E90")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x11F4EB8", Offset = "0x11F4EB8", VA = "0x11F4EB8")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A23C", Offset = "0x61A23C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x11F4ED4", Offset = "0x11F4ED4", VA = "0x11F4ED4")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x11F4EDC", Offset = "0x11F4EDC", VA = "0x11F4EDC")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x11F4EF8", Offset = "0x11F4EF8", VA = "0x11F4EF8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A24C", Offset = "0x61A24C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x11F4FF0", Offset = "0x11F4FF0", VA = "0x11F4FF0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x11F4FF8", Offset = "0x11F4FF8", VA = "0x11F4FF8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x11F5020", Offset = "0x11F5020", VA = "0x11F5020")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A25C", Offset = "0x61A25C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x11F503C", Offset = "0x11F503C", VA = "0x11F503C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x11F5044", Offset = "0x11F5044", VA = "0x11F5044")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x11F5060", Offset = "0x11F5060", VA = "0x11F5060")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x9EAE48", Offset = "0x9EAE48", VA = "0x9EAE48")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x9EB01C", Offset = "0x9EB01C", VA = "0x9EB01C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x9EB1E8", Offset = "0x9EB1E8", VA = "0x9EB1E8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x9EB3B4", Offset = "0x9EB3B4", VA = "0x9EB3B4")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x9EB560", Offset = "0x9EB560", VA = "0x9EB560")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x9EB9BC", Offset = "0x9EB9BC", VA = "0x9EB9BC")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x9EBCBC", Offset = "0x9EBCBC", VA = "0x9EBCBC")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x9EBFE0", Offset = "0x9EBFE0", VA = "0x9EBFE0")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x9EC1CC", Offset = "0x9EC1CC", VA = "0x9EC1CC")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000118")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A27C", Offset = "0x61A27C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x11F5158", Offset = "0x11F5158", VA = "0x11F5158")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x11F5160", Offset = "0x11F5160", VA = "0x11F5160")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x11F517C", Offset = "0x11F517C", VA = "0x11F517C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A28C", Offset = "0x61A28C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x11F5198", Offset = "0x11F5198", VA = "0x11F5198")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x11F51A0", Offset = "0x11F51A0", VA = "0x11F51A0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x11F51BC", Offset = "0x11F51BC", VA = "0x11F51BC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A29C", Offset = "0x61A29C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x11F51D8", Offset = "0x11F51D8", VA = "0x11F51D8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x11F51E0", Offset = "0x11F51E0", VA = "0x11F51E0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x11F51EC", Offset = "0x11F51EC", VA = "0x11F51EC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x9EC3DC", Offset = "0x9EC3DC", VA = "0x9EC3DC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x9EC5AC", Offset = "0x9EC5AC", VA = "0x9EC5AC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x9EC754", Offset = "0x9EC754", VA = "0x9EC754")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x9EC940", Offset = "0x9EC940", VA = "0x9EC940")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200011C")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x200011D")]
		public static class Utils
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x11F62C0", Offset = "0x11F62C0", VA = "0x11F62C0")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2BC", Offset = "0x61A2BC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x11F5298", Offset = "0x11F5298", VA = "0x11F5298")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x11F52A0", Offset = "0x11F52A0", VA = "0x11F52A0")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x11F52BC", Offset = "0x11F52BC", VA = "0x11F52BC")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2CC", Offset = "0x61A2CC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x11F5560", Offset = "0x11F5560", VA = "0x11F5560")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x11F5568", Offset = "0x11F5568", VA = "0x11F5568")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x11F558C", Offset = "0x11F558C", VA = "0x11F558C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2DC", Offset = "0x61A2DC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x11F5974", Offset = "0x11F5974", VA = "0x11F5974")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x11F597C", Offset = "0x11F597C", VA = "0x11F597C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x11F59A0", Offset = "0x11F59A0", VA = "0x11F59A0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2EC", Offset = "0x61A2EC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x11F5E78", Offset = "0x11F5E78", VA = "0x11F5E78")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x11F5E80", Offset = "0x11F5E80", VA = "0x11F5E80")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x11F5EA4", Offset = "0x11F5EA4", VA = "0x11F5EA4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2FC", Offset = "0x61A2FC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x11F5FD8", Offset = "0x11F5FD8", VA = "0x11F5FD8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x11F5FE0", Offset = "0x11F5FE0", VA = "0x11F5FE0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x11F6004", Offset = "0x11F6004", VA = "0x11F6004")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A30C", Offset = "0x61A30C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x11F6028", Offset = "0x11F6028", VA = "0x11F6028")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x11F6030", Offset = "0x11F6030", VA = "0x11F6030")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x11F604C", Offset = "0x11F604C", VA = "0x11F604C")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A31C", Offset = "0x61A31C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x11F6068", Offset = "0x11F6068", VA = "0x11F6068")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x11F6070", Offset = "0x11F6070", VA = "0x11F6070")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x11F60D4", Offset = "0x11F60D4", VA = "0x11F60D4")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A32C", Offset = "0x61A32C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x11F6130", Offset = "0x11F6130", VA = "0x11F6130")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x11F6138", Offset = "0x11F6138", VA = "0x11F6138")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x11F619C", Offset = "0x11F619C", VA = "0x11F619C")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A33C", Offset = "0x61A33C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x11F61F8", Offset = "0x11F61F8", VA = "0x11F61F8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x11F6200", Offset = "0x11F6200", VA = "0x11F6200")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x11F6264", Offset = "0x11F6264", VA = "0x11F6264")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A34C", Offset = "0x61A34C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x11F52D8", Offset = "0x11F52D8", VA = "0x11F52D8")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x11F52E0", Offset = "0x11F52E0", VA = "0x11F52E0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x11F5300", Offset = "0x11F5300", VA = "0x11F5300")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A35C", Offset = "0x61A35C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x11F531C", Offset = "0x11F531C", VA = "0x11F531C")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x11F5324", Offset = "0x11F5324", VA = "0x11F5324")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x11F5344", Offset = "0x11F5344", VA = "0x11F5344")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A36C", Offset = "0x61A36C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x11F5360", Offset = "0x11F5360", VA = "0x11F5360")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x11F5368", Offset = "0x11F5368", VA = "0x11F5368")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x11F5384", Offset = "0x11F5384", VA = "0x11F5384")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A37C", Offset = "0x61A37C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x11F53A0", Offset = "0x11F53A0", VA = "0x11F53A0")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x11F53A8", Offset = "0x11F53A8", VA = "0x11F53A8")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x11F53C4", Offset = "0x11F53C4", VA = "0x11F53C4")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A38C", Offset = "0x61A38C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x11F53E0", Offset = "0x11F53E0", VA = "0x11F53E0")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x11F53E8", Offset = "0x11F53E8", VA = "0x11F53E8")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x11F5404", Offset = "0x11F5404", VA = "0x11F5404")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A39C", Offset = "0x61A39C")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x11F5420", Offset = "0x11F5420", VA = "0x11F5420")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x11F5428", Offset = "0x11F5428", VA = "0x11F5428")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x11F5444", Offset = "0x11F5444", VA = "0x11F5444")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3AC", Offset = "0x61A3AC")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x11F5460", Offset = "0x11F5460", VA = "0x11F5460")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x11F5468", Offset = "0x11F5468", VA = "0x11F5468")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x11F5484", Offset = "0x11F5484", VA = "0x11F5484")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3BC", Offset = "0x61A3BC")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x11F54A0", Offset = "0x11F54A0", VA = "0x11F54A0")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x11F54A8", Offset = "0x11F54A8", VA = "0x11F54A8")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x11F54C4", Offset = "0x11F54C4", VA = "0x11F54C4")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3CC", Offset = "0x61A3CC")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x11F54E0", Offset = "0x11F54E0", VA = "0x11F54E0")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x11F54E8", Offset = "0x11F54E8", VA = "0x11F54E8")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x11F5504", Offset = "0x11F5504", VA = "0x11F5504")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3DC", Offset = "0x61A3DC")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x11F5520", Offset = "0x11F5520", VA = "0x11F5520")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x11F5528", Offset = "0x11F5528", VA = "0x11F5528")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x11F5544", Offset = "0x11F5544", VA = "0x11F5544")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3EC", Offset = "0x61A3EC")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x11F55B0", Offset = "0x11F55B0", VA = "0x11F55B0")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x11F55B8", Offset = "0x11F55B8", VA = "0x11F55B8")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x11F55D4", Offset = "0x11F55D4", VA = "0x11F55D4")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3FC", Offset = "0x61A3FC")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x11F55F0", Offset = "0x11F55F0", VA = "0x11F55F0")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x11F55F8", Offset = "0x11F55F8", VA = "0x11F55F8")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x11F5614", Offset = "0x11F5614", VA = "0x11F5614")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A40C", Offset = "0x61A40C")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x11F5630", Offset = "0x11F5630", VA = "0x11F5630")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x11F5638", Offset = "0x11F5638", VA = "0x11F5638")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x11F5654", Offset = "0x11F5654", VA = "0x11F5654")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A41C", Offset = "0x61A41C")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x11F5670", Offset = "0x11F5670", VA = "0x11F5670")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x11F5678", Offset = "0x11F5678", VA = "0x11F5678")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x11F5694", Offset = "0x11F5694", VA = "0x11F5694")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A42C", Offset = "0x61A42C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x11F56B0", Offset = "0x11F56B0", VA = "0x11F56B0")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x11F56B8", Offset = "0x11F56B8", VA = "0x11F56B8")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x11F56D4", Offset = "0x11F56D4", VA = "0x11F56D4")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A43C", Offset = "0x61A43C")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x11F56F0", Offset = "0x11F56F0", VA = "0x11F56F0")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x11F56F8", Offset = "0x11F56F8", VA = "0x11F56F8")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x11F5714", Offset = "0x11F5714", VA = "0x11F5714")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A44C", Offset = "0x61A44C")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x11F5730", Offset = "0x11F5730", VA = "0x11F5730")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x11F5738", Offset = "0x11F5738", VA = "0x11F5738")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x11F5760", Offset = "0x11F5760", VA = "0x11F5760")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A45C", Offset = "0x61A45C")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x11F577C", Offset = "0x11F577C", VA = "0x11F577C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x11F5784", Offset = "0x11F5784", VA = "0x11F5784")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x11F57AC", Offset = "0x11F57AC", VA = "0x11F57AC")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A46C", Offset = "0x61A46C")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x11F57C8", Offset = "0x11F57C8", VA = "0x11F57C8")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x11F57D0", Offset = "0x11F57D0", VA = "0x11F57D0")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x11F57F8", Offset = "0x11F57F8", VA = "0x11F57F8")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A47C", Offset = "0x61A47C")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x11F5814", Offset = "0x11F5814", VA = "0x11F5814")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x11F581C", Offset = "0x11F581C", VA = "0x11F581C")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x11F5838", Offset = "0x11F5838", VA = "0x11F5838")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x11F5854", Offset = "0x11F5854", VA = "0x11F5854")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x11F5888", Offset = "0x11F5888", VA = "0x11F5888")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x11F58A4", Offset = "0x11F58A4", VA = "0x11F58A4")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x11F58C0", Offset = "0x11F58C0", VA = "0x11F58C0")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A48C", Offset = "0x61A48C")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x11F59C4", Offset = "0x11F59C4", VA = "0x11F59C4")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x11F59CC", Offset = "0x11F59CC", VA = "0x11F59CC")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x11F5A20", Offset = "0x11F5A20", VA = "0x11F5A20")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A49C", Offset = "0x61A49C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x11F5A6C", Offset = "0x11F5A6C", VA = "0x11F5A6C")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x11F5A74", Offset = "0x11F5A74", VA = "0x11F5A74")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x11F5A90", Offset = "0x11F5A90", VA = "0x11F5A90")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4AC", Offset = "0x61A4AC")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x11F5AAC", Offset = "0x11F5AAC", VA = "0x11F5AAC")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x11F5AB4", Offset = "0x11F5AB4", VA = "0x11F5AB4")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x11F5AD0", Offset = "0x11F5AD0", VA = "0x11F5AD0")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4BC", Offset = "0x61A4BC")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x11F5AEC", Offset = "0x11F5AEC", VA = "0x11F5AEC")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x11F5AF4", Offset = "0x11F5AF4", VA = "0x11F5AF4")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x11F5B18", Offset = "0x11F5B18", VA = "0x11F5B18")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4CC", Offset = "0x61A4CC")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x11F5B3C", Offset = "0x11F5B3C", VA = "0x11F5B3C")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x11F5B44", Offset = "0x11F5B44", VA = "0x11F5B44")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x11F5B68", Offset = "0x11F5B68", VA = "0x11F5B68")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4DC", Offset = "0x61A4DC")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x11F5B8C", Offset = "0x11F5B8C", VA = "0x11F5B8C")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x11F5B94", Offset = "0x11F5B94", VA = "0x11F5B94")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x11F5B9C", Offset = "0x11F5B9C", VA = "0x11F5B9C")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4EC", Offset = "0x61A4EC")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x11F5C38", Offset = "0x11F5C38", VA = "0x11F5C38")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x11F5C40", Offset = "0x11F5C40", VA = "0x11F5C40")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x11F5C64", Offset = "0x11F5C64", VA = "0x11F5C64")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4FC", Offset = "0x61A4FC")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x11F5C88", Offset = "0x11F5C88", VA = "0x11F5C88")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x11F5C90", Offset = "0x11F5C90", VA = "0x11F5C90")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x11F5CB4", Offset = "0x11F5CB4", VA = "0x11F5CB4")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A50C", Offset = "0x61A50C")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x11F5CD8", Offset = "0x11F5CD8", VA = "0x11F5CD8")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x11F5CE0", Offset = "0x11F5CE0", VA = "0x11F5CE0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x11F5CEC", Offset = "0x11F5CEC", VA = "0x11F5CEC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A51C", Offset = "0x61A51C")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x11F5DA8", Offset = "0x11F5DA8", VA = "0x11F5DA8")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x11F5DB0", Offset = "0x11F5DB0", VA = "0x11F5DB0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x11F5DBC", Offset = "0x11F5DBC", VA = "0x11F5DBC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A52C", Offset = "0x61A52C")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x11F5EC8", Offset = "0x11F5EC8", VA = "0x11F5EC8")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x11F5ED0", Offset = "0x11F5ED0", VA = "0x11F5ED0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x11F5EDC", Offset = "0x11F5EDC", VA = "0x11F5EDC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A53C", Offset = "0x61A53C")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x11F5F98", Offset = "0x11F5F98", VA = "0x11F5F98")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x11F5FA0", Offset = "0x11F5FA0", VA = "0x11F5FA0")]
			internal Vector2 <DOShapeCircle>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x11F5FBC", Offset = "0x11F5FBC", VA = "0x11F5FBC")]
			internal void <DOShapeCircle>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x9ECB9C", Offset = "0x9ECB9C", VA = "0x9ECB9C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x9ECD44", Offset = "0x9ECD44", VA = "0x9ECD44")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x9ECF14", Offset = "0x9ECF14", VA = "0x9ECF14")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x9ED0BC", Offset = "0x9ED0BC", VA = "0x9ED0BC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x9ED28C", Offset = "0x9ED28C", VA = "0x9ED28C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x9ED434", Offset = "0x9ED434", VA = "0x9ED434")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x9ED600", Offset = "0x9ED600", VA = "0x9ED600")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x9ED7F4", Offset = "0x9ED7F4", VA = "0x9ED7F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x9ED9C4", Offset = "0x9ED9C4", VA = "0x9ED9C4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x9EDB94", Offset = "0x9EDB94", VA = "0x9EDB94")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x9EDD64", Offset = "0x9EDD64", VA = "0x9EDD64")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x9EDF34", Offset = "0x9EDF34", VA = "0x9EDF34")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x9EE0DC", Offset = "0x9EE0DC", VA = "0x9EE0DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x9EE294", Offset = "0x9EE294", VA = "0x9EE294")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x9EE464", Offset = "0x9EE464", VA = "0x9EE464")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x9EE62C", Offset = "0x9EE62C", VA = "0x9EE62C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x9EE7F4", Offset = "0x9EE7F4", VA = "0x9EE7F4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x9EE9CC", Offset = "0x9EE9CC", VA = "0x9EE9CC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x9EEB98", Offset = "0x9EEB98", VA = "0x9EEB98")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x9EED64", Offset = "0x9EED64", VA = "0x9EED64")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x9EEF30", Offset = "0x9EEF30", VA = "0x9EEF30")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x9EF100", Offset = "0x9EF100", VA = "0x9EF100")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x9EF2D0", Offset = "0x9EF2D0", VA = "0x9EF2D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x9EF488", Offset = "0x9EF488", VA = "0x9EF488")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x9EF644", Offset = "0x9EF644", VA = "0x9EF644")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x9EF800", Offset = "0x9EF800", VA = "0x9EF800")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x9EF9D0", Offset = "0x9EF9D0", VA = "0x9EF9D0")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x9EFBA8", Offset = "0x9EFBA8", VA = "0x9EFBA8")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x9EFDA8", Offset = "0x9EFDA8", VA = "0x9EFDA8")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x9EFFB0", Offset = "0x9EFFB0", VA = "0x9EFFB0")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x9F0404", Offset = "0x9F0404", VA = "0x9F0404")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x9F05C8", Offset = "0x9F05C8", VA = "0x9F05C8")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x9F077C", Offset = "0x9F077C", VA = "0x9F077C")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x9F0930", Offset = "0x9F0930", VA = "0x9F0930")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x9F0AF0", Offset = "0x9F0AF0", VA = "0x9F0AF0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x9F0CC0", Offset = "0x9F0CC0", VA = "0x9F0CC0")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x9F0EE8", Offset = "0x9F0EE8", VA = "0x9F0EE8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x9F1090", Offset = "0x9F1090", VA = "0x9F1090")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x9F12E4", Offset = "0x9F12E4", VA = "0x9F12E4")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x9F1548", Offset = "0x9F1548", VA = "0x9F1548")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x9F17AC", Offset = "0x9F17AC", VA = "0x9F17AC")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x9F1A10", Offset = "0x9F1A10", VA = "0x9F1A10")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000147")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A55C", Offset = "0x61A55C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x11F6504", Offset = "0x11F6504", VA = "0x11F6504")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x11F650C", Offset = "0x11F650C", VA = "0x11F650C")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x11F6530", Offset = "0x11F6530", VA = "0x11F6530")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A56C", Offset = "0x61A56C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x11F6554", Offset = "0x11F6554", VA = "0x11F6554")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x11F655C", Offset = "0x11F655C", VA = "0x11F655C")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x11F6580", Offset = "0x11F6580", VA = "0x11F6580")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A57C", Offset = "0x61A57C")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x11F65A4", Offset = "0x11F65A4", VA = "0x11F65A4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x11F67E8", Offset = "0x11F67E8", VA = "0x11F67E8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A58C", Offset = "0x61A58C")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x11F6EF8", Offset = "0x11F6EF8", VA = "0x11F6EF8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x11F7160", Offset = "0x11F7160", VA = "0x11F7160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A59C", Offset = "0x61A59C")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x11F6A4C", Offset = "0x11F6A4C", VA = "0x11F6A4C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x11F6C7C", Offset = "0x11F6C7C", VA = "0x11F6C7C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5AC", Offset = "0x61A5AC")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x11F67F4", Offset = "0x11F67F4", VA = "0x11F67F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x11F6A40", Offset = "0x11F6A40", VA = "0x11F6A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5BC", Offset = "0x61A5BC")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x11F6C88", Offset = "0x11F6C88", VA = "0x11F6C88", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x11F6EEC", Offset = "0x11F6EEC", VA = "0x11F6EEC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5CC", Offset = "0x61A5CC")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x11F716C", Offset = "0x11F716C", VA = "0x11F716C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x11F73A4", Offset = "0x11F73A4", VA = "0x11F73A4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x9F1C20", Offset = "0x9F1C20", VA = "0x9F1C20")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x9F1E10", Offset = "0x9F1E10", VA = "0x9F1E10")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x9F2014", Offset = "0x9F2014", VA = "0x9F2014")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x9F20D4", Offset = "0x9F20D4", VA = "0x9F20D4")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x9F2194", Offset = "0x9F2194", VA = "0x9F2194")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x9F2254", Offset = "0x9F2254", VA = "0x9F2254")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x9F2324", Offset = "0x9F2324", VA = "0x9F2324")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x9F23F4", Offset = "0x9F23F4", VA = "0x9F23F4")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x9F24B4", Offset = "0x9F24B4", VA = "0x9F24B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x9F26DC", Offset = "0x9F26DC", VA = "0x9F26DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x9F2904", Offset = "0x9F2904", VA = "0x9F2904")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x61B828", Offset = "0x61B828")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x9F2A20", Offset = "0x9F2A20", VA = "0x9F2A20")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x61B898", Offset = "0x61B898")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x9F2B3C", Offset = "0x9F2B3C", VA = "0x9F2B3C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x61B908", Offset = "0x61B908")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x9F2C58", Offset = "0x9F2C58", VA = "0x9F2C58")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x61B978", Offset = "0x61B978")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x9F2D84", Offset = "0x9F2D84", VA = "0x9F2D84")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x61B9E8", Offset = "0x61B9E8")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x9F2EB0", Offset = "0x9F2EB0", VA = "0x9F2EB0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x61BA58", Offset = "0x61BA58")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000150")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000151")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x11F43F8", Offset = "0x11F43F8", VA = "0x11F43F8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x11F442C", Offset = "0x11F442C", VA = "0x11F442C")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000152")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x11F45F0", Offset = "0x11F45F0", VA = "0x11F45F0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x11F4654", Offset = "0x11F4654", VA = "0x11F4654")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000153")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x11F44F4", Offset = "0x11F44F4", VA = "0x11F44F4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x11F4510", Offset = "0x11F4510", VA = "0x11F4510")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000154")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700003D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000710")]
				[Address(RVA = "0x11F4460", Offset = "0x11F4460", VA = "0x11F4460", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x11F44AC", Offset = "0x11F44AC", VA = "0x11F44AC")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000155")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700003E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000712")]
				[Address(RVA = "0x11F4544", Offset = "0x11F4544", VA = "0x11F4544", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x11F45A8", Offset = "0x11F45A8", VA = "0x11F45A8")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000156")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003F")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000714")]
				[Address(RVA = "0x11F4688", Offset = "0x11F4688", VA = "0x11F4688", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x11F46BC", Offset = "0x11F46BC", VA = "0x11F46BC")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000157")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000158")]
		public static class Physics
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x11F73B0", Offset = "0x11F73B0", VA = "0x11F73B0")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x11F74B4", Offset = "0x11F74B4", VA = "0x11F74B4")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x11F754C", Offset = "0x11F754C", VA = "0x11F754C")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x11F75E4", Offset = "0x11F75E4", VA = "0x11F75E4")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x9F2FCC", Offset = "0x9F2FCC", VA = "0x9F2FCC")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x9F3090", Offset = "0x9F3090", VA = "0x9F3090")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
