using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using ES3Internal;
using ES3Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8552D0", Offset = "0x8552D0")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x85A43C", Offset = "0x85A43C")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x85A450", Offset = "0x85A450")]
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
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x8552E0", Offset = "0x8552E0")]
public class ES3Serializable : Attribute
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1CEDD20", Offset = "0x1CEDD20", VA = "0x1CEDD20")]
	public ES3Serializable()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x8552F4", Offset = "0x8552F4")]
public class ES3NonSerializable : Attribute
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1511464", Offset = "0x1511464", VA = "0x1511464")]
	public ES3NonSerializable()
	{
	}
}
[Token(Token = "0x2000005")]
public class ES3AutoSave : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool saveChildren;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool isQuitting;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public List<Component> componentsToSave;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x15023E0", Offset = "0x15023E0", VA = "0x15023E0")]
	public void Awake()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1502884", Offset = "0x1502884", VA = "0x1502884")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1502890", Offset = "0x1502890", VA = "0x1502890")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1502A0C", Offset = "0x1502A0C", VA = "0x1502A0C")]
	public ES3AutoSave()
	{
	}
}
[Token(Token = "0x2000006")]
public class ES3AutoSaveMgr : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	public enum LoadEvent
	{
		[Token(Token = "0x400000D")]
		None,
		[Token(Token = "0x400000E")]
		Awake,
		[Token(Token = "0x400000F")]
		Start
	}

	[Token(Token = "0x2000008")]
	public enum SaveEvent
	{
		[Token(Token = "0x4000011")]
		None,
		[Token(Token = "0x4000012")]
		OnApplicationQuit,
		[Token(Token = "0x4000013")]
		OnApplicationPause
	}

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ES3AutoSaveMgr _current;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveEvent saveEvent;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LoadEvent loadEvent;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ES3SerializableSettings settings;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HashSet<ES3AutoSave> autoSaves;

	[Token(Token = "0x17000003")]
	public static ES3AutoSaveMgr Current
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x15024DC", Offset = "0x15024DC", VA = "0x15024DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public static ES3AutoSaveMgr Instance
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1502A84", Offset = "0x1502A84", VA = "0x1502A84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1502ADC", Offset = "0x1502ADC", VA = "0x1502ADC")]
	public void Save()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1502D7C", Offset = "0x1502D7C", VA = "0x1502D7C")]
	public void Load()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1502E24", Offset = "0x1502E24", VA = "0x1502E24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1502E38", Offset = "0x1502E38", VA = "0x1502E38")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1502FD0", Offset = "0x1502FD0", VA = "0x1502FD0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1502FE4", Offset = "0x1502FE4", VA = "0x1502FE4")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x150277C", Offset = "0x150277C", VA = "0x150277C")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1502904", Offset = "0x1502904", VA = "0x1502904")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1503050", Offset = "0x1503050", VA = "0x1503050")]
	public ES3AutoSaveMgr()
	{
	}
}
[Token(Token = "0x2000009")]
public static class ES3
{
	[Token(Token = "0x200000A")]
	public enum Location
	{
		[Token(Token = "0x4000015")]
		File,
		[Token(Token = "0x4000016")]
		PlayerPrefs,
		[Token(Token = "0x4000017")]
		InternalMS,
		[Token(Token = "0x4000018")]
		Resources,
		[Token(Token = "0x4000019")]
		Cache
	}

	[Token(Token = "0x200000B")]
	public enum Directory
	{
		[Token(Token = "0x400001B")]
		PersistentDataPath,
		[Token(Token = "0x400001C")]
		DataPath
	}

	[Token(Token = "0x200000C")]
	public enum EncryptionType
	{
		[Token(Token = "0x400001E")]
		None,
		[Token(Token = "0x400001F")]
		AES
	}

	[Token(Token = "0x200000D")]
	public enum CompressionType
	{
		[Token(Token = "0x4000021")]
		None,
		[Token(Token = "0x4000022")]
		Gzip
	}

	[Token(Token = "0x200000E")]
	public enum Format
	{
		[Token(Token = "0x4000024")]
		JSON,
		[Token(Token = "0x4000025")]
		Binary_Alpha
	}

	[Token(Token = "0x200000F")]
	public enum ReferenceMode
	{
		[Token(Token = "0x4000027")]
		ByRef,
		[Token(Token = "0x4000028")]
		ByValue,
		[Token(Token = "0x4000029")]
		ByRefAndValue
	}

	[Token(Token = "0x6000019")]
	public static void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x600001A")]
	public static void Save<T>(string key, T value, string filePath)
	{
	}

	[Token(Token = "0x600001B")]
	public static void Save<T>(string key, T value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600001C")]
	public static void Save<T>(string key, T value, ES3Settings settings)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x14F8A24", Offset = "0x14F8A24", VA = "0x14F8A24")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x14F8C88", Offset = "0x14F8C88", VA = "0x14F8C88")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x14F8CFC", Offset = "0x14F8CFC", VA = "0x14F8CFC")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x14F8A8C", Offset = "0x14F8A8C", VA = "0x14F8A8C")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x14F94F8", Offset = "0x14F94F8", VA = "0x14F94F8")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x14F95A4", Offset = "0x14F95A4", VA = "0x14F95A4")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x14F9618", Offset = "0x14F9618", VA = "0x14F9618")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x14F9560", Offset = "0x14F9560", VA = "0x14F9560")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x14F9690", Offset = "0x14F9690", VA = "0x14F9690")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x14F98FC", Offset = "0x14F98FC", VA = "0x14F98FC")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x14F96F8", Offset = "0x14F96F8", VA = "0x14F96F8")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x14F99F4", Offset = "0x14F99F4", VA = "0x14F99F4")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x14F9C84", Offset = "0x14F9C84", VA = "0x14F9C84")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x14F9A5C", Offset = "0x14F9A5C", VA = "0x14F9A5C")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x14F9CFC", Offset = "0x14F9CFC", VA = "0x14F9CFC")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x14F9F08", Offset = "0x14F9F08", VA = "0x14F9F08")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x14F9D70", Offset = "0x14F9D70", VA = "0x14F9D70")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x14F9FE4", Offset = "0x14F9FE4", VA = "0x14F9FE4")]
	public static object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x14FA064", Offset = "0x14FA064", VA = "0x14FA064")]
	public static object Load(string key, string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x14FA0F0", Offset = "0x14FA0F0", VA = "0x14FA0F0")]
	public static object Load(string key, string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x14FA180", Offset = "0x14FA180", VA = "0x14FA180")]
	public static object Load(string key, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000033")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x6000034")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000035")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000036")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000037")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000038")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000039")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600003A")]
	public static void LoadInto<T>(string key, object obj) where T : class
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x14FA1DC", Offset = "0x14FA1DC", VA = "0x14FA1DC")]
	public static void LoadInto(string key, string filePath, object obj)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x14FA270", Offset = "0x14FA270", VA = "0x14FA270")]
	public static void LoadInto(string key, string filePath, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x14FA310", Offset = "0x14FA310", VA = "0x14FA310")]
	public static void LoadInto(string key, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003E")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x600003F")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x6000040")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000041")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x14FA374", Offset = "0x14FA374", VA = "0x14FA374")]
	public static string LoadString(string key, string defaultValue, string filePath = "")
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x14FA408", Offset = "0x14FA408", VA = "0x14FA408")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x14FA8B8", Offset = "0x14FA8B8", VA = "0x14FA8B8")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x14FA91C", Offset = "0x14FA91C", VA = "0x14FA91C")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x14FA468", Offset = "0x14FA468", VA = "0x14FA468")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x14FAE7C", Offset = "0x14FAE7C", VA = "0x14FAE7C")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x14FAF28", Offset = "0x14FAF28", VA = "0x14FAF28")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x14FAF8C", Offset = "0x14FAF8C", VA = "0x14FAF8C")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x14FAEDC", Offset = "0x14FAEDC", VA = "0x14FAEDC")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x14FAFFC", Offset = "0x14FAFFC", VA = "0x14FAFFC")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x14FB078", Offset = "0x14FB078", VA = "0x14FB078")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x14FB064", Offset = "0x14FB064", VA = "0x14FB064")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x14FB0EC", Offset = "0x14FB0EC", VA = "0x14FB0EC")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x14FB160", Offset = "0x14FB160", VA = "0x14FB160")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x14FB1D8", Offset = "0x14FB1D8", VA = "0x14FB1D8")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	public static byte[] Serialize<T>(T value, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	public static T Deserialize<T>(byte[] bytes, [Optional] ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x14FB5D4", Offset = "0x14FB5D4", VA = "0x14FB5D4")]
	internal static object Deserialize(ES3Type type, byte[] bytes, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	public static void DeserializeInto<T>(byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000055")]
	public static void DeserializeInto<T>(ES3Type type, byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x14FB940", Offset = "0x14FB940", VA = "0x14FB940")]
	public static byte[] EncryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x14FBA3C", Offset = "0x14FBA3C", VA = "0x14FBA3C")]
	public static byte[] DecryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x14FBB38", Offset = "0x14FBB38", VA = "0x14FBB38")]
	public static string EncryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x14FBBFC", Offset = "0x14FBBFC", VA = "0x14FBBFC")]
	public static string DecryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x14FBCC0", Offset = "0x14FBCC0", VA = "0x14FBCC0")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x14FBE94", Offset = "0x14FBE94", VA = "0x14FBE94")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x14FBEF8", Offset = "0x14FBEF8", VA = "0x14FBEF8")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x14FBD20", Offset = "0x14FBD20", VA = "0x14FBD20")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x14FC078", Offset = "0x14FC078", VA = "0x14FC078")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x14FC544", Offset = "0x14FC544", VA = "0x14FC544")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x14FC108", Offset = "0x14FC108", VA = "0x14FC108")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x14FC9DC", Offset = "0x14FC9DC", VA = "0x14FC9DC")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x14FCEC4", Offset = "0x14FCEC4", VA = "0x14FCEC4")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x14FCA6C", Offset = "0x14FCA6C", VA = "0x14FCA6C")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x14FCF6C", Offset = "0x14FCF6C", VA = "0x14FCF6C")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x14FD2C8", Offset = "0x14FD2C8", VA = "0x14FD2C8")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x14FCFFC", Offset = "0x14FCFFC", VA = "0x14FCFFC")]
	public static void CopyDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x14FD768", Offset = "0x14FD768", VA = "0x14FD768")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x14FD9B0", Offset = "0x14FD9B0", VA = "0x14FD9B0")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x14FD7F8", Offset = "0x14FD7F8", VA = "0x14FD7F8")]
	public static void RenameDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x14FDAE4", Offset = "0x14FDAE4", VA = "0x14FDAE4")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x14FDC84", Offset = "0x14FDC84", VA = "0x14FDC84")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x14FDB48", Offset = "0x14FDB48", VA = "0x14FDB48")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x14FDCF4", Offset = "0x14FDCF4", VA = "0x14FDCF4")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x14FDF7C", Offset = "0x14FDF7C", VA = "0x14FDF7C")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x14FDFF0", Offset = "0x14FDFF0", VA = "0x14FDFF0")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x14FDD5C", Offset = "0x14FDD5C", VA = "0x14FDD5C")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x14FE2B8", Offset = "0x14FE2B8", VA = "0x14FE2B8")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x14FE4E0", Offset = "0x14FE4E0", VA = "0x14FE4E0")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x14FE554", Offset = "0x14FE554", VA = "0x14FE554")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x14FE320", Offset = "0x14FE320", VA = "0x14FE320")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x14FE76C", Offset = "0x14FE76C", VA = "0x14FE76C")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x14FE7CC", Offset = "0x14FE7CC", VA = "0x14FE7CC")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x14FE830", Offset = "0x14FE830", VA = "0x14FE830")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x14FE124", Offset = "0x14FE124", VA = "0x14FE124")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x14FE930", Offset = "0x14FE930", VA = "0x14FE930")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x14FE994", Offset = "0x14FE994", VA = "0x14FE994")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x14FD368", Offset = "0x14FD368", VA = "0x14FD368")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x14FEA04", Offset = "0x14FEA04", VA = "0x14FEA04")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x14FEEB4", Offset = "0x14FEEB4", VA = "0x14FEEB4")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x14FEF18", Offset = "0x14FEF18", VA = "0x14FEF18")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x14FEA64", Offset = "0x14FEA64", VA = "0x14FEA64")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x14FF0F0", Offset = "0x14FF0F0", VA = "0x14FF0F0")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x14FF150", Offset = "0x14FF150", VA = "0x14FF150")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x14FF1B4", Offset = "0x14FF1B4", VA = "0x14FF1B4")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x14FD4B4", Offset = "0x14FD4B4", VA = "0x14FD4B4")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x14FF3D4", Offset = "0x14FF3D4", VA = "0x14FF3D4")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x14FF434", Offset = "0x14FF434", VA = "0x14FF434")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x14FF498", Offset = "0x14FF498", VA = "0x14FF498")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x14FD690", Offset = "0x14FD690", VA = "0x14FD690")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x14FF670", Offset = "0x14FF670", VA = "0x14FF670")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x14FF774", Offset = "0x14FF774", VA = "0x14FF774")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x14FF7D8", Offset = "0x14FF7D8", VA = "0x14FF7D8")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x14FF6D0", Offset = "0x14FF6D0", VA = "0x14FF6D0")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x14FF848", Offset = "0x14FF848", VA = "0x14FF848")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x14FF96C", Offset = "0x14FF96C", VA = "0x14FF96C")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x14FF8AC", Offset = "0x14FF8AC", VA = "0x14FF8AC")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x14FF9DC", Offset = "0x14FF9DC", VA = "0x14FF9DC")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x14FFBEC", Offset = "0x14FFBEC", VA = "0x14FFBEC")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x14FFC50", Offset = "0x14FFC50", VA = "0x14FFC50")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x14FFA3C", Offset = "0x14FFA3C", VA = "0x14FFA3C")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x14FFEC0", Offset = "0x14FFEC0", VA = "0x14FFEC0")]
	public static void StoreCachedFile()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x15000EC", Offset = "0x15000EC", VA = "0x15000EC")]
	public static void StoreCachedFile(string filePath)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x15001B0", Offset = "0x15001B0", VA = "0x15001B0")]
	public static void StoreCachedFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1500150", Offset = "0x1500150", VA = "0x1500150")]
	public static void StoreCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1500220", Offset = "0x1500220", VA = "0x1500220")]
	public static void CacheFile()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x15002E0", Offset = "0x15002E0", VA = "0x15002E0")]
	public static void CacheFile(string filePath)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1500344", Offset = "0x1500344", VA = "0x1500344")]
	public static void CacheFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1500280", Offset = "0x1500280", VA = "0x1500280")]
	public static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1500574", Offset = "0x1500574", VA = "0x1500574")]
	public static void Init()
	{
	}
}
[Token(Token = "0x2000010")]
public class ES3File
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A474", Offset = "0x85A474")]
	internal static Dictionary<string, ES3File> cachedFiles;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, ES3Data> cache;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool syncWithFile;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DateTime timestamp;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x150B39C", Offset = "0x150B39C", VA = "0x150B39C")]
	public ES3File()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x150B8A8", Offset = "0x150B8A8", VA = "0x150B8A8")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x150B920", Offset = "0x150B920", VA = "0x150B920")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x150720C", Offset = "0x150720C", VA = "0x150720C")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x150B99C", Offset = "0x150B99C", VA = "0x150B99C")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x150BA14", Offset = "0x150BA14", VA = "0x150BA14")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x150BA90", Offset = "0x150BA90", VA = "0x150BA90")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x150B408", Offset = "0x150B408", VA = "0x150B408")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x150BB18", Offset = "0x150BB18", VA = "0x150BB18")]
	public ES3File(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x150BC28", Offset = "0x150BC28", VA = "0x150BC28")]
	public void Sync()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x150BFFC", Offset = "0x150BFFC", VA = "0x150BFFC")]
	public void Sync(string filePath, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x150BC30", Offset = "0x150BC30", VA = "0x150BC30")]
	public void Sync([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x150C074", Offset = "0x150C074", VA = "0x150C074")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x150C0C8", Offset = "0x150C0C8", VA = "0x150C0C8")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	public void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x14F8E90", Offset = "0x14F8E90", VA = "0x14F8E90")]
	public void SaveRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x14F9974", Offset = "0x14F9974", VA = "0x14F9974")]
	public void AppendRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x150C2A4", Offset = "0x150C2A4", VA = "0x150C2A4")]
	public object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x150C300", Offset = "0x150C300", VA = "0x150C300")]
	public object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B0")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B1")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x14FA98C", Offset = "0x14FA98C", VA = "0x14FA98C")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x150C364", Offset = "0x150C364", VA = "0x150C364")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x150C410", Offset = "0x150C410", VA = "0x150C410")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x150C474", Offset = "0x150C474", VA = "0x150C474")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x150C4D8", Offset = "0x150C4D8", VA = "0x150C4D8")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x150C604", Offset = "0x150C604", VA = "0x150C604")]
	public Type GetKeyType(string key)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x14F8D74", Offset = "0x14F8D74", VA = "0x14F8D74")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A5C4", Offset = "0x85A5C4")]
	internal static ES3File GetOrCreateCachedFile(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x15003B4", Offset = "0x15003B4", VA = "0x15003B4")]
	internal static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x14FFF1C", Offset = "0x14FFF1C", VA = "0x14FFF1C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A5D8", Offset = "0x85A5D8")]
	internal static void Store([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x14FBFE8", Offset = "0x14FBFE8", VA = "0x14FBFE8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A5EC", Offset = "0x85A5EC")]
	internal static void RemoveCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x14FC5F4", Offset = "0x14FC5F4", VA = "0x14FC5F4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A600", Offset = "0x85A600")]
	internal static void CopyCachedFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x14FE068", Offset = "0x14FE068", VA = "0x14FE068")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A614", Offset = "0x85A614")]
	internal static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x14FE5CC", Offset = "0x14FE5CC", VA = "0x14FE5CC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A628", Offset = "0x85A628")]
	internal static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x14FE8A0", Offset = "0x14FE8A0", VA = "0x14FE8A0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A63C", Offset = "0x85A63C")]
	internal static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x14FEF88", Offset = "0x14FEF88", VA = "0x14FEF88")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A650", Offset = "0x85A650")]
	internal static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x14FF224", Offset = "0x14FF224", VA = "0x14FF224")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A664", Offset = "0x85A664")]
	internal static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x14FFD94", Offset = "0x14FFD94", VA = "0x14FFD94")]
	internal static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}
}
[Token(Token = "0x2000011")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x150D754", Offset = "0x150D754", VA = "0x150D754")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000012")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase
{
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1513C18", Offset = "0x1513C18", VA = "0x1513C18")]
	public ES3ReferenceMgr()
	{
	}
}
[Token(Token = "0x2000013")]
public class ES3Spreadsheet
{
	[Token(Token = "0x2000014")]
	protected struct Index
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int col;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int row;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1F5AD90", Offset = "0x1F5AD90", VA = "0x1F5AD90")]
		public Index(int col, int row)
		{
		}
	}

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int cols;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int rows;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Index, string> cells;

	[Token(Token = "0x4000032")]
	private const string QUOTE = "\"";

	[Token(Token = "0x4000033")]
	private const char QUOTE_CHAR = '"';

	[Token(Token = "0x4000034")]
	private const char COMMA_CHAR = ',';

	[Token(Token = "0x4000035")]
	private const char NEWLINE_CHAR = '\n';

	[Token(Token = "0x4000036")]
	private const string ESCAPED_QUOTE = "\"\"";

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static char[] CHARS_TO_ESCAPE;

	[Token(Token = "0x17000005")]
	public int ColumnCount
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1CEF05C", Offset = "0x1CEF05C", VA = "0x1CEF05C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public int RowCount
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1CEF064", Offset = "0x1CEF064", VA = "0x1CEF064")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1CEEFBC", Offset = "0x1CEEFBC", VA = "0x1CEEFBC")]
	public ES3Spreadsheet()
	{
	}

	[Token(Token = "0x60000C9")]
	public void SetCell<T>(int col, int row, T value)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1CEF06C", Offset = "0x1CEF06C", VA = "0x1CEF06C")]
	private void SetCellString(int col, int row, string value)
	{
	}

	[Token(Token = "0x60000CB")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1CEF12C", Offset = "0x1CEF12C", VA = "0x1CEF12C")]
	internal object GetCell(Type type, int col, int row)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1CEFCFC", Offset = "0x1CEFCFC", VA = "0x1CEFCFC")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1CEFDB8", Offset = "0x1CEFDB8", VA = "0x1CEFDB8")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1CEFD80", Offset = "0x1CEFD80", VA = "0x1CEFD80")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1CF06A0", Offset = "0x1CF06A0", VA = "0x1CF06A0")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1CF077C", Offset = "0x1CF077C", VA = "0x1CF077C")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1CF025C", Offset = "0x1CF025C", VA = "0x1CF025C")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1CF0820", Offset = "0x1CF0820", VA = "0x1CF0820")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1CF0ED8", Offset = "0x1CF0ED8", VA = "0x1CF0ED8")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1CF0F50", Offset = "0x1CF0F50", VA = "0x1CF0F50")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1CF0F58", Offset = "0x1CF0F58", VA = "0x1CF0F58")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1CF0FD4", Offset = "0x1CF0FD4", VA = "0x1CF0FD4")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1CF0898", Offset = "0x1CF0898", VA = "0x1CF0898")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1CF120C", Offset = "0x1CF120C", VA = "0x1CF120C")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1CF1328", Offset = "0x1CF1328", VA = "0x1CF1328")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1CF1058", Offset = "0x1CF1058", VA = "0x1CF1058")]
	private string[,] ToArray()
	{
		return null;
	}
}
[Token(Token = "0x2000015")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x855308", Offset = "0x855308")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85531C", Offset = "0x85531C")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderPropertyEnumerator <>4__this;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000121")]
				[Address(RVA = "0x1F5AF8C", Offset = "0x1F5AF8C", VA = "0x1F5AF8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000123")]
				[Address(RVA = "0x1F5AFD4", Offset = "0x1F5AFD4", VA = "0x1F5AFD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1F5A4A0", Offset = "0x1F5A4A0", VA = "0x1F5A4A0")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1F5AEFC", Offset = "0x1F5AEFC", VA = "0x1F5AEFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1F5AF00", Offset = "0x1F5AF00", VA = "0x1F5AF00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1F5AF94", Offset = "0x1F5AF94", VA = "0x1F5AF94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1F5A408", Offset = "0x1F5A408", VA = "0x1F5A408")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1F5A434", Offset = "0x1F5A434", VA = "0x1F5A434")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A718", Offset = "0x85A718")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85532C", Offset = "0x85532C")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855340", Offset = "0x855340")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderRawEnumerator <>4__this;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000129")]
				[Address(RVA = "0x1F5B154", Offset = "0x1F5B154", VA = "0x1F5B154", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0x1F5B19C", Offset = "0x1F5B19C", VA = "0x1F5B19C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1F5A4F8", Offset = "0x1F5A4F8", VA = "0x1F5A4F8")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1F5AFDC", Offset = "0x1F5AFDC", VA = "0x1F5AFDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1F5AFE0", Offset = "0x1F5AFE0", VA = "0x1F5AFE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1F5B15C", Offset = "0x1F5B15C", VA = "0x1F5B15C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1F5A4CC", Offset = "0x1F5A4CC", VA = "0x1F5A4CC")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1F58088", Offset = "0x1F58088", VA = "0x1F58088")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A7C8", Offset = "0x85A7C8")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected int serializationDepth;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal string overridePropertiesName;

	[Token(Token = "0x17000007")]
	public virtual ES3ReaderPropertyEnumerator Properties
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x15133C0", Offset = "0x15133C0", VA = "0x15133C0", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1513420", Offset = "0x1513420", VA = "0x1513420", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000DE")]
	internal abstract int Read_int();

	[Token(Token = "0x60000DF")]
	internal abstract float Read_float();

	[Token(Token = "0x60000E0")]
	internal abstract bool Read_bool();

	[Token(Token = "0x60000E1")]
	internal abstract char Read_char();

	[Token(Token = "0x60000E2")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x60000E3")]
	internal abstract double Read_double();

	[Token(Token = "0x60000E4")]
	internal abstract long Read_long();

	[Token(Token = "0x60000E5")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x60000E6")]
	internal abstract byte Read_byte();

	[Token(Token = "0x60000E7")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x60000E8")]
	internal abstract short Read_short();

	[Token(Token = "0x60000E9")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x60000EA")]
	internal abstract uint Read_uint();

	[Token(Token = "0x60000EB")]
	internal abstract string Read_string();

	[Token(Token = "0x60000EC")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x60000ED")]
	internal abstract long Read_ref();

	[Token(Token = "0x60000EE")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A678", Offset = "0x85A678")]
	public abstract string ReadPropertyName();

	[Token(Token = "0x60000EF")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x60000F0")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x60000F1")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x60000F2")]
	public abstract void Dispose();

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x15132FC", Offset = "0x15132FC", VA = "0x15132FC", Slot = "26")]
	internal virtual bool Goto(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x150417C", Offset = "0x150417C", VA = "0x150417C", Slot = "27")]
	internal virtual bool StartReadObject()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x15041A0", Offset = "0x15041A0", VA = "0x15041A0", Slot = "28")]
	internal virtual void EndReadObject()
	{
	}

	[Token(Token = "0x60000F6")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x60000F7")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x60000F8")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x60000F9")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x60000FA")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x60000FB")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x60000FC")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x60000FD")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x60000FE")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x60000FF")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1503AB0", Offset = "0x1503AB0", VA = "0x1503AB0")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1513480", Offset = "0x1513480", VA = "0x1513480", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A68C", Offset = "0x85A68C")]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x6000104")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000105")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x6000106")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A6A0", Offset = "0x85A6A0")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000107")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A6B4", Offset = "0x85A6B4")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1513494", Offset = "0x1513494", VA = "0x1513494")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A6C8", Offset = "0x85A6C8")]
	public long ReadRefProperty()
	{
		return default(long);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x15134D0", Offset = "0x15134D0", VA = "0x15134D0")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x15135B4", Offset = "0x15135B4", VA = "0x15135B4")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1513754", Offset = "0x1513754", VA = "0x1513754")]
	public void SetPrivateField(string name, object value, object objectContainingField)
	{
	}

	[Token(Token = "0x600010C")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x600010D")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600010E")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x600010F")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000110")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000111")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A6DC", Offset = "0x85A6DC")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000112")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A6F0", Offset = "0x85A6F0")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000113")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A704", Offset = "0x85A704")]
	internal Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x15138F4", Offset = "0x15138F4", VA = "0x15138F4")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1513954", Offset = "0x1513954", VA = "0x1513954")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x15139B8", Offset = "0x15139B8", VA = "0x15139B8")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x14FE694", Offset = "0x14FE694", VA = "0x14FE694")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1513A28", Offset = "0x1513A28", VA = "0x1513A28")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x150C198", Offset = "0x150C198", VA = "0x150C198")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1513A90", Offset = "0x1513A90", VA = "0x1513A90")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x14FB878", Offset = "0x14FB878", VA = "0x14FB878")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public class ES3XMLReader
{
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1F581AC", Offset = "0x1F581AC", VA = "0x1F581AC")]
	public ES3XMLReader()
	{
	}
}
[Token(Token = "0x200001B")]
public class ES3Defaults : ScriptableObject
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ES3SerializableSettings settings;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool addMgrToSceneAutomatically;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool autoUpdateReferences;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool addAllPrefabsToManager;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool logDebugInfo;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool logWarnings;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool logErrors;

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x150A7BC", Offset = "0x150A7BC", VA = "0x150A7BC")]
	public ES3Defaults()
	{
	}
}
[Token(Token = "0x200001C")]
public class ES3Settings : ICloneable
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES3Settings _defaults;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES3Defaults _defaultSettingsScriptableObject;

	[Token(Token = "0x400004E")]
	private const string defaultSettingsPath = "ES3/ES3Defaults";

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ES3Settings _unencryptedUncompressedSettings;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string[] resourcesExtensions;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private ES3.Location _location;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ES3.EncryptionType encryptionType;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ES3.CompressionType compressionType;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string encryptionPassword;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES3.Directory directory;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ES3.Format format;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool prettyPrint;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bufferSize;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool saveChildren;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A4A8", Offset = "0x85A4A8")]
	public bool typeChecking;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A4BC", Offset = "0x85A4BC")]
	public bool safeReflection;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A4D0", Offset = "0x85A4D0")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A4E4", Offset = "0x85A4E4")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A4F8", Offset = "0x85A4F8")]
	public int serializationDepthLimit;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A50C", Offset = "0x85A50C")]
	public string[] assemblyNames;

	[Token(Token = "0x1700000D")]
	public static ES3Defaults defaultSettingsScriptableObject
	{
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1CEE0D8", Offset = "0x1CEE0D8", VA = "0x1CEE0D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public static ES3Settings defaultSettings
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1CEE20C", Offset = "0x1CEE20C", VA = "0x1CEE20C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	internal static ES3Settings unencryptedUncompressedSettings
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1CEE32C", Offset = "0x1CEE32C", VA = "0x1CEE32C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public ES3.Location location
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1CEE6A0", Offset = "0x1CEE6A0", VA = "0x1CEE6A0")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1CEE6F0", Offset = "0x1CEE6F0", VA = "0x1CEE6F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public string FullPath
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1CEE6F8", Offset = "0x1CEE6F8", VA = "0x1CEE6F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1CE99F0", Offset = "0x1CE99F0", VA = "0x1CE99F0")]
	public ES3Settings([Optional] string path, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1CEEBC0", Offset = "0x1CEEBC0", VA = "0x1CEEBC0")]
	public ES3Settings(string path, params Enum[] enums)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1CEE4D4", Offset = "0x1CEE4D4", VA = "0x1CEE4D4")]
	public ES3Settings(params Enum[] enums)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1CEEBF0", Offset = "0x1CEEBF0", VA = "0x1CEEBF0")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1CEEC2C", Offset = "0x1CEEC2C", VA = "0x1CEEC2C")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1CEDD8C", Offset = "0x1CEDD8C", VA = "0x1CEDD8C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A878", Offset = "0x85A878")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1CEEA88", Offset = "0x1CEEA88", VA = "0x1CEEA88")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1CEEC68", Offset = "0x1CEEC68", VA = "0x1CEEC68", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A88C", Offset = "0x85A88C")]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1CEEB2C", Offset = "0x1CEEB2C", VA = "0x1CEEB2C")]
	private void CopyInto(ES3Settings newSettings)
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x855350", Offset = "0x855350")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1CEDD28", Offset = "0x1CEDD28", VA = "0x1CEDD28")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1CEDF78", Offset = "0x1CEDF78", VA = "0x1CEDF78")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1CEDFE8", Offset = "0x1CEDFE8", VA = "0x1CEDFE8")]
	public ES3SerializableSettings(string path)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1CEE060", Offset = "0x1CEE060", VA = "0x1CEE060")]
	public ES3SerializableSettings(string path, ES3.Location location)
	{
	}
}
[Token(Token = "0x200001E")]
public class ES3Ref
{
	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long id;

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1513B6C", Offset = "0x1513B6C", VA = "0x1513B6C")]
	public ES3Ref(long id)
	{
	}
}
[Token(Token = "0x200001F")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855364", Offset = "0x855364")]
	private sealed class <Sync>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1F59FE4", Offset = "0x1F59FE4", VA = "0x1F59FE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1F5A02C", Offset = "0x1F5A02C", VA = "0x1F5A02C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1F59E88", Offset = "0x1F59E88", VA = "0x1F59E88")]
		[DebuggerHidden]
		public <Sync>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1F59EB4", Offset = "0x1F59EB4", VA = "0x1F59EB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1F59EB8", Offset = "0x1F59EB8", VA = "0x1F59EB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1F59FEC", Offset = "0x1F59FEC", VA = "0x1F59FEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855374", Offset = "0x855374")]
	private sealed class <UploadFile>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public long fileTimestamp;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] bytes;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1F5A3B8", Offset = "0x1F5A3B8", VA = "0x1F5A3B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1F5A400", Offset = "0x1F5A400", VA = "0x1F5A400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1F5A034", Offset = "0x1F5A034", VA = "0x1F5A034")]
		[DebuggerHidden]
		public <UploadFile>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1F5A060", Offset = "0x1F5A060", VA = "0x1F5A060", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1F5A138", Offset = "0x1F5A138", VA = "0x1F5A138", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1F5A07C", Offset = "0x1F5A07C", VA = "0x1F5A07C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1F5A3C0", Offset = "0x1F5A3C0", VA = "0x1F5A3C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855384", Offset = "0x855384")]
	private sealed class <DownloadFile>d__42 : IEnumerator<object>, IEnumerator, IDisposable
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
		public ES3File es3File;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1F58BCC", Offset = "0x1F58BCC", VA = "0x1F58BCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1F58C14", Offset = "0x1F58C14", VA = "0x1F58C14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1F587A0", Offset = "0x1F587A0", VA = "0x1F587A0")]
		[DebuggerHidden]
		public <DownloadFile>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1F587CC", Offset = "0x1F587CC", VA = "0x1F587CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1F588A4", Offset = "0x1F588A4", VA = "0x1F588A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1F587E8", Offset = "0x1F587E8", VA = "0x1F587E8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1F58BD4", Offset = "0x1F58BD4", VA = "0x1F58BD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855394", Offset = "0x855394")]
	private sealed class <DownloadFile>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x1F59000", Offset = "0x1F59000", VA = "0x1F59000", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1F59048", Offset = "0x1F59048", VA = "0x1F59048", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1F58C1C", Offset = "0x1F58C1C", VA = "0x1F58C1C")]
		[DebuggerHidden]
		public <DownloadFile>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1F58C48", Offset = "0x1F58C48", VA = "0x1F58C48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1F58D20", Offset = "0x1F58D20", VA = "0x1F58D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1F58C64", Offset = "0x1F58C64", VA = "0x1F58C64")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1F59008", Offset = "0x1F59008", VA = "0x1F59008", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8553A4", Offset = "0x8553A4")]
	private sealed class <DeleteFile>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1F58750", Offset = "0x1F58750", VA = "0x1F58750", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x1F58798", Offset = "0x1F58798", VA = "0x1F58798", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1F58460", Offset = "0x1F58460", VA = "0x1F58460")]
		[DebuggerHidden]
		public <DeleteFile>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1F5848C", Offset = "0x1F5848C", VA = "0x1F5848C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1F58564", Offset = "0x1F58564", VA = "0x1F58564", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1F584A8", Offset = "0x1F584A8", VA = "0x1F584A8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1F58758", Offset = "0x1F58758", VA = "0x1F58758", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8553B4", Offset = "0x8553B4")]
	private sealed class <RenameFile>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Settings newSettings;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1F59A78", Offset = "0x1F59A78", VA = "0x1F59A78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1F59AC0", Offset = "0x1F59AC0", VA = "0x1F59AC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1F5974C", Offset = "0x1F5974C", VA = "0x1F5974C")]
		[DebuggerHidden]
		public <RenameFile>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1F59778", Offset = "0x1F59778", VA = "0x1F59778", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1F59850", Offset = "0x1F59850", VA = "0x1F59850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1F59794", Offset = "0x1F59794", VA = "0x1F59794")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1F59A80", Offset = "0x1F59A80", VA = "0x1F59A80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8553C4", Offset = "0x8553C4")]
	private sealed class <DownloadFilenames>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1F59380", Offset = "0x1F59380", VA = "0x1F59380", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x1F593C8", Offset = "0x1F593C8", VA = "0x1F593C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1F59050", Offset = "0x1F59050", VA = "0x1F59050")]
		[DebuggerHidden]
		public <DownloadFilenames>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1F5907C", Offset = "0x1F5907C", VA = "0x1F5907C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1F59154", Offset = "0x1F59154", VA = "0x1F59154", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1F59098", Offset = "0x1F59098", VA = "0x1F59098")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1F59388", Offset = "0x1F59388", VA = "0x1F59388", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8553D4", Offset = "0x8553D4")]
	private sealed class <SearchFilenames>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string searchPattern;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1F59E38", Offset = "0x1F59E38", VA = "0x1F59E38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x1F59E80", Offset = "0x1F59E80", VA = "0x1F59E80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1F59AC8", Offset = "0x1F59AC8", VA = "0x1F59AC8")]
		[DebuggerHidden]
		public <SearchFilenames>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1F59AF4", Offset = "0x1F59AF4", VA = "0x1F59AF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1F59BCC", Offset = "0x1F59BCC", VA = "0x1F59BCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1F59B10", Offset = "0x1F59B10", VA = "0x1F59B10")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1F59E40", Offset = "0x1F59E40", VA = "0x1F59E40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8553E4", Offset = "0x8553E4")]
	private sealed class <DownloadTimestamp>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1F596FC", Offset = "0x1F596FC", VA = "0x1F596FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x1F59744", Offset = "0x1F59744", VA = "0x1F59744", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1F593D0", Offset = "0x1F593D0", VA = "0x1F593D0")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1F593FC", Offset = "0x1F593FC", VA = "0x1F593FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1F594D4", Offset = "0x1F594D4", VA = "0x1F594D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1F59418", Offset = "0x1F59418", VA = "0x1F59418")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1F59704", Offset = "0x1F59704", VA = "0x1F59704", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Encoding encoding;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private byte[] _data;

	[Token(Token = "0x17000012")]
	public byte[] data
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1507590", Offset = "0x1507590", VA = "0x1507590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	public string text
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1507598", Offset = "0x1507598", VA = "0x1507598")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public string[] filenames
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x15075CC", Offset = "0x15075CC", VA = "0x15075CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public DateTime timestamp
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1507698", Offset = "0x1507698", VA = "0x1507698")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1507548", Offset = "0x1507548", VA = "0x1507548")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x150781C", Offset = "0x150781C", VA = "0x150781C")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x150792C", Offset = "0x150792C", VA = "0x150792C")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x15079BC", Offset = "0x15079BC", VA = "0x15079BC")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1507A50", Offset = "0x1507A50", VA = "0x1507A50")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1507ADC", Offset = "0x1507ADC", VA = "0x1507ADC")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1507B70", Offset = "0x1507B70", VA = "0x1507B70")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1507C10", Offset = "0x1507C10", VA = "0x1507C10")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x15078A0", Offset = "0x15078A0", VA = "0x15078A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A8A0", Offset = "0x85A8A0")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1507CA0", Offset = "0x1507CA0", VA = "0x1507CA0")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1507D88", Offset = "0x1507D88", VA = "0x1507D88")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1507E28", Offset = "0x1507E28", VA = "0x1507E28")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1507ECC", Offset = "0x1507ECC", VA = "0x1507ECC")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1507F64", Offset = "0x1507F64", VA = "0x1507F64")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1508008", Offset = "0x1508008", VA = "0x1508008")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x15080B8", Offset = "0x15080B8", VA = "0x15080B8")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1508154", Offset = "0x1508154", VA = "0x1508154")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x15083C4", Offset = "0x15083C4", VA = "0x15083C4")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1508488", Offset = "0x1508488", VA = "0x1508488")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1507D3C", Offset = "0x1507D3C", VA = "0x1507D3C")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1508544", Offset = "0x1508544", VA = "0x1508544")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1508324", Offset = "0x1508324", VA = "0x1508324")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A900", Offset = "0x85A900")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password, long fileTimestamp)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x15085A8", Offset = "0x15085A8", VA = "0x15085A8")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x15086C4", Offset = "0x15086C4", VA = "0x15086C4")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1508758", Offset = "0x1508758", VA = "0x1508758")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x15087F0", Offset = "0x15087F0", VA = "0x15087F0")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1508880", Offset = "0x1508880", VA = "0x1508880")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1508918", Offset = "0x1508918", VA = "0x1508918")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x15089BC", Offset = "0x15089BC", VA = "0x15089BC")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1508A50", Offset = "0x1508A50", VA = "0x1508A50")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1508B48", Offset = "0x1508B48", VA = "0x1508B48")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1508BB0", Offset = "0x1508BB0", VA = "0x1508BB0")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1508AB4", Offset = "0x1508AB4", VA = "0x1508AB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A960", Offset = "0x85A960")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1508630", Offset = "0x1508630", VA = "0x1508630")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A9C0", Offset = "0x85A9C0")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1508BB8", Offset = "0x1508BB8", VA = "0x1508BB8")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1508CC8", Offset = "0x1508CC8", VA = "0x1508CC8")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1508D58", Offset = "0x1508D58", VA = "0x1508D58")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1508DEC", Offset = "0x1508DEC", VA = "0x1508DEC")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1508E78", Offset = "0x1508E78", VA = "0x1508E78")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1508F0C", Offset = "0x1508F0C", VA = "0x1508F0C")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1508FAC", Offset = "0x1508FAC", VA = "0x1508FAC")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1508C3C", Offset = "0x1508C3C", VA = "0x1508C3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AA20", Offset = "0x85AA20")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x150903C", Offset = "0x150903C", VA = "0x150903C")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x150918C", Offset = "0x150918C", VA = "0x150918C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x150924C", Offset = "0x150924C", VA = "0x150924C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1509304", Offset = "0x1509304", VA = "0x1509304")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x15093C4", Offset = "0x15093C4", VA = "0x15093C4")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1509490", Offset = "0x1509490", VA = "0x1509490")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x15090F8", Offset = "0x15090F8", VA = "0x15090F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AA80", Offset = "0x85AA80")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x150954C", Offset = "0x150954C", VA = "0x150954C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AAE0", Offset = "0x85AAE0")]
	public IEnumerator DownloadFilenames(string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x15095CC", Offset = "0x15095CC", VA = "0x15095CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AB40", Offset = "0x85AB40")]
	public IEnumerator SearchFilenames(string searchPattern, string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1509658", Offset = "0x1509658", VA = "0x1509658")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1509768", Offset = "0x1509768", VA = "0x1509768")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x15097F8", Offset = "0x15097F8", VA = "0x15097F8")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x150988C", Offset = "0x150988C", VA = "0x150988C")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1509918", Offset = "0x1509918", VA = "0x1509918")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x15099AC", Offset = "0x15099AC", VA = "0x15099AC")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1509A4C", Offset = "0x1509A4C", VA = "0x1509A4C")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x15096DC", Offset = "0x15096DC", VA = "0x15096DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85ABA0", Offset = "0x85ABA0")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1508214", Offset = "0x1508214", VA = "0x1508214")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1509ADC", Offset = "0x1509ADC", VA = "0x1509ADC")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1509AF8", Offset = "0x1509AF8", VA = "0x1509AF8", Slot = "4")]
	protected override void Reset()
	{
	}
}
[Token(Token = "0x2000029")]
public abstract class ES3Writer : IDisposable
{
	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HashSet<string> keysToDelete;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool writeHeaderAndFooter;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	internal bool overwriteKeys;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int serializationDepth;

	[Token(Token = "0x60001C3")]
	internal abstract void WriteNull();

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1F55DE4", Offset = "0x1F55DE4", VA = "0x1F55DE4", Slot = "6")]
	internal virtual void StartWriteFile()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1F55DF4", Offset = "0x1F55DF4", VA = "0x1F55DF4", Slot = "7")]
	internal virtual void EndWriteFile()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1F55E04", Offset = "0x1F55E04", VA = "0x1F55E04", Slot = "8")]
	internal virtual void StartWriteObject(string name)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1F55E14", Offset = "0x1F55E14", VA = "0x1F55E14", Slot = "9")]
	internal virtual void EndWriteObject(string name)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1F55E24", Offset = "0x1F55E24", VA = "0x1F55E24", Slot = "10")]
	internal virtual void StartWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1F55EF4", Offset = "0x1F55EF4", VA = "0x1F55EF4", Slot = "11")]
	internal virtual void EndWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1F55EF8", Offset = "0x1F55EF8", VA = "0x1F55EF8", Slot = "12")]
	internal virtual void StartWriteCollection()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1F55F08", Offset = "0x1F55F08", VA = "0x1F55F08", Slot = "13")]
	internal virtual void EndWriteCollection()
	{
	}

	[Token(Token = "0x60001CC")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x60001CD")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x60001CE")]
	internal abstract void StartWriteDictionary();

	[Token(Token = "0x60001CF")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x60001D0")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x60001D1")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x60001D2")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x60001D3")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x60001D4")]
	public abstract void Dispose();

	[Token(Token = "0x60001D5")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x60001D6")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x60001D7")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x60001D8")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x60001D9")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x60001DA")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x60001DB")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x60001DC")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x60001DD")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x60001DE")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x60001DF")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x60001E0")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x60001E1")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x60001E2")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x60001E3")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x60001E4")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1F55F18", Offset = "0x1F55F18", VA = "0x1F55F18")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1F55FCC", Offset = "0x1F55FCC", VA = "0x1F55FCC", Slot = "39")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x60001E7")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1F560B8", Offset = "0x1F560B8", VA = "0x1F560B8", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AED0", Offset = "0x85AED0")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1F561F4", Offset = "0x1F561F4", VA = "0x1F561F4", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AEE4", Offset = "0x85AEE4")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1F562C0", Offset = "0x1F562C0", VA = "0x1F562C0", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AEF8", Offset = "0x85AEF8")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1F567E4", Offset = "0x1F567E4", VA = "0x1F567E4", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1F5695C", Offset = "0x1F5695C", VA = "0x1F5695C", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1F56984", Offset = "0x1F56984", VA = "0x1F56984", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60001EE")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1F56ABC", Offset = "0x1F56ABC", VA = "0x1F56ABC", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AF0C", Offset = "0x85AF0C")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1F56AE4", Offset = "0x1F56AE4", VA = "0x1F56AE4", Slot = "49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AF20", Offset = "0x85AF20")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1F56B80", Offset = "0x1F56B80", VA = "0x1F56B80", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AF34", Offset = "0x85AF34")]
	public virtual void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1F56C98", Offset = "0x1F56C98", VA = "0x1F56C98")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1F56F84", Offset = "0x1F56F84", VA = "0x1F56F84")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1F57188", Offset = "0x1F57188", VA = "0x1F57188")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AF48", Offset = "0x85AF48")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1F57348", Offset = "0x1F57348", VA = "0x1F57348")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AF5C", Offset = "0x85AF5C")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1F57508", Offset = "0x1F57508", VA = "0x1F57508")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AF70", Offset = "0x85AF70")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1F57704", Offset = "0x1F57704", VA = "0x1F57704")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AF84", Offset = "0x85AF84")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1F55624", Offset = "0x1F55624", VA = "0x1F55624")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AF98", Offset = "0x85AF98")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1F57900", Offset = "0x1F57900", VA = "0x1F57900")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1F5797C", Offset = "0x1F5797C", VA = "0x1F5797C")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1F5798C", Offset = "0x1F5798C", VA = "0x1F5798C")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1F579EC", Offset = "0x1F579EC", VA = "0x1F579EC")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1F56A0C", Offset = "0x1F56A0C", VA = "0x1F56A0C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AFAC", Offset = "0x85AFAC")]
	protected bool SerializationDepthLimitExceeded()
	{
		return default(bool);
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1F57BB4", Offset = "0x1F57BB4", VA = "0x1F57BB4", Slot = "51")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85AFC0", Offset = "0x85AFC0")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1F57C18", Offset = "0x1F57C18", VA = "0x1F57C18")]
	protected void Merge()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1F57D64", Offset = "0x1F57D64", VA = "0x1F57D64")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1F580F4", Offset = "0x1F580F4", VA = "0x1F580F4", Slot = "52")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1F58108", Offset = "0x1F58108", VA = "0x1F58108", Slot = "53")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200002A")]
public class ES3XMLWriter
{
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1F581B4", Offset = "0x1F581B4", VA = "0x1F581B4")]
	public ES3XMLWriter()
	{
	}
}
namespace ES3Types
{
	[Token(Token = "0x200002B")]
	[Preserve]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1CF9310", Offset = "0x1CF9310", VA = "0x1CF9310")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1CF93D4", Offset = "0x1CF93D4", VA = "0x1CF93D4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000206")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1CF93DC", Offset = "0x1CF93DC", VA = "0x1CF93DC")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1CF94A0", Offset = "0x1CF94A0", VA = "0x1CF94A0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600020A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200002D")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1500604", Offset = "0x1500604", VA = "0x1500604")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1500700", Offset = "0x1500700", VA = "0x1500700", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x600020E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x150091C", Offset = "0x150091C", VA = "0x150091C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1500B94", Offset = "0x1500B94", VA = "0x1500B94", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1500E64", Offset = "0x1500E64", VA = "0x1500E64")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1500E68", Offset = "0x1500E68", VA = "0x1500E68", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000214")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x150111C", Offset = "0x150111C", VA = "0x150111C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1501470", Offset = "0x1501470", VA = "0x1501470", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200002F")]
	[Preserve]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x15017E0", Offset = "0x15017E0", VA = "0x15017E0")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x15017E4", Offset = "0x15017E4", VA = "0x15017E4")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x150184C", Offset = "0x150184C", VA = "0x150184C", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x15019D0", Offset = "0x15019D0", VA = "0x15019D0", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1501C04", Offset = "0x1501C04", VA = "0x1501C04", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000030")]
	[Preserve]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type elementType;

		[Token(Token = "0x600021F")]
		public abstract object Read(ES3Reader reader);

		[Token(Token = "0x6000220")]
		public abstract void ReadInto(ES3Reader reader, object obj);

		[Token(Token = "0x6000221")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1500608", Offset = "0x1500608", VA = "0x1500608")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1501818", Offset = "0x1501818", VA = "0x1501818")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1509B04", Offset = "0x1509B04", VA = "0x1509B04", Slot = "4")]
		[Preserve]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000225")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1509B14", Offset = "0x1509B14", VA = "0x1509B14", Slot = "12")]
		[Preserve]
		protected virtual void ReadICollectionInto(ES3Reader reader, ICollection collection, ES3Type elementType)
		{
		}
	}
	[Token(Token = "0x2000031")]
	[Preserve]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type keyType;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ES3Type valueType;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x150A82C", Offset = "0x150A82C", VA = "0x150A82C")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x150A950", Offset = "0x150A950", VA = "0x150A950")]
		public ES3DictionaryType(Type type, ES3Type keyType, ES3Type valueType)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x150A9A0", Offset = "0x150A9A0", VA = "0x150A9A0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x150A9C4", Offset = "0x150A9C4", VA = "0x150A9C4")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600022C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x150ADD4", Offset = "0x150ADD4", VA = "0x150ADD4")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x150B020", Offset = "0x150B020", VA = "0x150B020")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000032")]
	[Preserve]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x150CCA8", Offset = "0x150CCA8", VA = "0x150CCA8")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x150CCAC", Offset = "0x150CCAC", VA = "0x150CCAC", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000232")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x150D28C", Offset = "0x150D28C", VA = "0x150D28C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x150D578", Offset = "0x150D578", VA = "0x150D578", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000033")]
	[Preserve]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x151082C", Offset = "0x151082C", VA = "0x151082C")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1510830", Offset = "0x1510830", VA = "0x1510830")]
		public ES3ListType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1510864", Offset = "0x1510864", VA = "0x1510864", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000239")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1510C48", Offset = "0x1510C48", VA = "0x1510C48", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1510E34", Offset = "0x1510E34", VA = "0x1510E34", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000034")]
	[Preserve]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x15126D8", Offset = "0x15126D8", VA = "0x15126D8")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x15126DC", Offset = "0x15126DC", VA = "0x15126DC", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600023F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1512AAC", Offset = "0x1512AAC", VA = "0x1512AAC", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1512DA4", Offset = "0x1512DA4", VA = "0x1512DA4", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000035")]
	[Preserve]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1CF149C", Offset = "0x1CF149C", VA = "0x1CF149C")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1CF14A4", Offset = "0x1CF14A4", VA = "0x1CF14A4", Slot = "9")]
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
		[Address(RVA = "0x1CF1874", Offset = "0x1CF1874", VA = "0x1CF1874", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1CF1B60", Offset = "0x1CF1B60", VA = "0x1CF1B60", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000036")]
	[Preserve]
	public abstract class ES3ComponentType : ES3UnityObjectType
	{
		[Token(Token = "0x40000B3")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x150A044", Offset = "0x150A044", VA = "0x150A044")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x600024A")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x600024B")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x150A04C", Offset = "0x150A04C", VA = "0x150A04C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600024D")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600024E")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x150A4B0", Offset = "0x150A4B0", VA = "0x150A4B0")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x150A56C", Offset = "0x150A56C", VA = "0x150A56C")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000037")]
	[Preserve]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x151146C", Offset = "0x151146C", VA = "0x151146C")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x6000253")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000254")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x6000255")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1511474", Offset = "0x1511474", VA = "0x1511474", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000257")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000038")]
	[Preserve]
	public abstract class ES3ScriptableObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1CE8D94", Offset = "0x1CE8D94", VA = "0x1CE8D94")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x600025A")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x600025B")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1CEDB0C", Offset = "0x1CEDB0C", VA = "0x1CEDB0C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600025D")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600025E")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000039")]
	[Preserve]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8554A4", Offset = "0x8554A4")]
	public abstract class ES3Type
	{
		[Token(Token = "0x40000B4")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isReflectedType;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUnsupported;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int priority;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1CE8DC8", Offset = "0x1CE8DC8", VA = "0x1CE8DC8")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x6000261")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x6000262")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x6000263")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1CF268C", Offset = "0x1CF268C", VA = "0x1CF268C")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1CF279C", Offset = "0x1CF279C", VA = "0x1CF279C")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1CE8BDC", Offset = "0x1CE8BDC", VA = "0x1CE8BDC")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1CF27D4", Offset = "0x1CF27D4", VA = "0x1CF27D4")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1CE8BCC", Offset = "0x1CE8BCC", VA = "0x1CE8BCC")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1CE8ECC", Offset = "0x1CE8ECC", VA = "0x1CE8ECC")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x8554E0", Offset = "0x8554E0")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x15126AC", Offset = "0x15126AC", VA = "0x15126AC")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x200003B")]
	[Preserve]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1F4CF7C", Offset = "0x1F4CF7C", VA = "0x1F4CF7C")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x600026D")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x600026E")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x600026F")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1F55224", Offset = "0x1F55224", VA = "0x1F55224", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1F55238", Offset = "0x1F55238", VA = "0x1F55238", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x6000272")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000273")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1F554B0", Offset = "0x1F554B0", VA = "0x1F554B0")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003C")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x855504", Offset = "0x855504")]
	public class ES3Type_Random : ES3ObjectType
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x21E4BB0", Offset = "0x21E4BB0", VA = "0x21E4BB0")]
		public ES3Type_Random()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x21E4C78", Offset = "0x21E4C78", VA = "0x21E4C78", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000277")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000278")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200003D")]
	public class ES3Type_RandomArray : ES3ArrayType
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x21E4D80", Offset = "0x21E4D80", VA = "0x21E4D80")]
		public ES3Type_RandomArray()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[Preserve]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1CF9018", Offset = "0x1CF9018", VA = "0x1CF9018")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1CF90DC", Offset = "0x1CF90DC", VA = "0x1CF90DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600027D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1CF9218", Offset = "0x1CF9218", VA = "0x1CF9218")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[Preserve]
	public class ES3Type_ES3Ref : ES3Type
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1CF95E8", Offset = "0x1CF95E8", VA = "0x1CF95E8")]
		public ES3Type_ES3Ref()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1CF96B4", Offset = "0x1CF96B4", VA = "0x1CF96B4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000282")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public class ES3Type_ES3RefArray : ES3ArrayType
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1CF9768", Offset = "0x1CF9768", VA = "0x1CF9768")]
		public ES3Type_ES3RefArray()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class ES3Type_ES3RefDictionary : ES3DictionaryType
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1CF9860", Offset = "0x1CF9860", VA = "0x1CF9860")]
		public ES3Type_ES3RefDictionary()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[Preserve]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1F50C2C", Offset = "0x1F50C2C", VA = "0x1F50C2C")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1F50CFC", Offset = "0x1F50CFC", VA = "0x1F50CFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000288")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1F50D94", Offset = "0x1F50D94", VA = "0x1F50D94")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[Preserve]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1F525F4", Offset = "0x1F525F4", VA = "0x1F525F4")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1F526C4", Offset = "0x1F526C4", VA = "0x1F526C4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600028D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1F5275C", Offset = "0x1F5275C", VA = "0x1F5275C")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[Preserve]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1F52854", Offset = "0x1F52854", VA = "0x1F52854")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1F52924", Offset = "0x1F52924", VA = "0x1F52924", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000292")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	[Preserve]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1F529BC", Offset = "0x1F529BC", VA = "0x1F529BC")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1F52A8C", Offset = "0x1F52A8C", VA = "0x1F52A8C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000296")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000049")]
	[Preserve]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1F52B24", Offset = "0x1F52B24", VA = "0x1F52B24")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1F52BF4", Offset = "0x1F52BF4", VA = "0x1F52BF4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600029A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004A")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1F52C8C", Offset = "0x1F52C8C", VA = "0x1F52C8C")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[Preserve]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1F52D84", Offset = "0x1F52D84", VA = "0x1F52D84")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1F52E54", Offset = "0x1F52E54", VA = "0x1F52E54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600029F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1F52EEC", Offset = "0x1F52EEC", VA = "0x1F52EEC")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[Preserve]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1F52FE4", Offset = "0x1F52FE4", VA = "0x1F52FE4")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1F530B4", Offset = "0x1F530B4", VA = "0x1F530B4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002A4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004E")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1F5314C", Offset = "0x1F5314C", VA = "0x1F5314C")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[Preserve]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type underlyingType;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1F53244", Offset = "0x1F53244", VA = "0x1F53244")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1F5330C", Offset = "0x1F5330C", VA = "0x1F5330C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002A9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000050")]
	[Preserve]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1F53DC8", Offset = "0x1F53DC8", VA = "0x1F53DC8")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1F53E98", Offset = "0x1F53E98", VA = "0x1F53E98", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002AD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1F53F30", Offset = "0x1F53F30", VA = "0x1F53F30")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[Preserve]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1F54028", Offset = "0x1F54028", VA = "0x1F54028")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1F540F8", Offset = "0x1F540F8", VA = "0x1F540F8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000053")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1F54190", Offset = "0x1F54190", VA = "0x1F54190")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[Preserve]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x220F52C", Offset = "0x220F52C", VA = "0x220F52C")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x220F5FC", Offset = "0x220F5FC", VA = "0x220F5FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000055")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x220F6A0", Offset = "0x220F6A0", VA = "0x220F6A0")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[Preserve]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1F54288", Offset = "0x1F54288", VA = "0x1F54288")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1F54358", Offset = "0x1F54358", VA = "0x1F54358", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002BC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1F543F0", Offset = "0x1F543F0", VA = "0x1F543F0")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[Preserve]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1F544E8", Offset = "0x1F544E8", VA = "0x1F544E8")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1F545B8", Offset = "0x1F545B8", VA = "0x1F545B8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1F54650", Offset = "0x1F54650", VA = "0x1F54650")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[Preserve]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1F54748", Offset = "0x1F54748", VA = "0x1F54748")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1F54818", Offset = "0x1F54818", VA = "0x1F54818", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1F548B0", Offset = "0x1F548B0", VA = "0x1F548B0")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[Preserve]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1F549A8", Offset = "0x1F549A8", VA = "0x1F549A8")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1F54A78", Offset = "0x1F54A78", VA = "0x1F54A78", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002CB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005D")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1F4DE30", Offset = "0x1F4DE30", VA = "0x1F4DE30")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[Preserve]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1F54B04", Offset = "0x1F54B04", VA = "0x1F54B04")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1F54BD4", Offset = "0x1F54BD4", VA = "0x1F54BD4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1F54C6C", Offset = "0x1F54C6C", VA = "0x1F54C6C")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[Preserve]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1F54D64", Offset = "0x1F54D64", VA = "0x1F54D64")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1F54E34", Offset = "0x1F54E34", VA = "0x1F54E34", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000061")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1F54ECC", Offset = "0x1F54ECC", VA = "0x1F54ECC")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[Preserve]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1F54FC4", Offset = "0x1F54FC4", VA = "0x1F54FC4")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1F55094", Offset = "0x1F55094", VA = "0x1F55094", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002DA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1F5512C", Offset = "0x1F5512C", VA = "0x1F5512C")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[Preserve]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1CE8B94", Offset = "0x1CE8B94", VA = "0x1CE8B94")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1CE8BD8", Offset = "0x1CE8BD8", VA = "0x1CE8BD8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002DF")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000065")]
	[Preserve]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1CE8D20", Offset = "0x1CE8D20", VA = "0x1CE8D20")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1CE8D58", Offset = "0x1CE8D58", VA = "0x1CE8D58", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E2")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000066")]
	[Preserve]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1CE8D5C", Offset = "0x1CE8D5C", VA = "0x1CE8D5C")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1CE8D9C", Offset = "0x1CE8D9C", VA = "0x1CE8D9C", Slot = "14")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E6")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000067")]
	[Preserve]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1CE8DA0", Offset = "0x1CE8DA0", VA = "0x1CE8DA0")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1CE8E94", Offset = "0x1CE8E94", VA = "0x1CE8E94")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1CE9068", Offset = "0x1CE9068", VA = "0x1CE9068", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002EA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000068")]
	[Preserve]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1CE969C", Offset = "0x1CE969C", VA = "0x1CE969C")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1CE96D4", Offset = "0x1CE96D4", VA = "0x1CE96D4", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002EE")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000069")]
	[Preserve]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1CE96D8", Offset = "0x1CE96D8", VA = "0x1CE96D8")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1CE970C", Offset = "0x1CE970C", VA = "0x1CE970C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006A")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x855748", Offset = "0x855748")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1CF60E4", Offset = "0x1CF60E4", VA = "0x1CF60E4")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1CF61AC", Offset = "0x1CF61AC", VA = "0x1CF61AC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F6")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006B")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85581C", Offset = "0x85581C")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1CF6454", Offset = "0x1CF6454", VA = "0x1CF6454")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1CF651C", Offset = "0x1CF651C", VA = "0x1CF651C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002FA")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006C")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x855900", Offset = "0x855900")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1CF6864", Offset = "0x1CF6864", VA = "0x1CF6864")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1CF692C", Offset = "0x1CF692C", VA = "0x1CF692C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002FE")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x855B84", Offset = "0x855B84")]
	[Preserve]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1CF74D0", Offset = "0x1CF74D0", VA = "0x1CF74D0")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1CF7598", Offset = "0x1CF7598", VA = "0x1CF7598", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000302")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006E")]
	[Preserve]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1CF9D84", Offset = "0x1CF9D84", VA = "0x1CF9D84")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1CF9E4C", Offset = "0x1CF9E4C", VA = "0x1CF9E4C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000306")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006F")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x855C88", Offset = "0x855C88")]
	public class ES3Type_Image : ES3ComponentType
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1CFC710", Offset = "0x1CFC710", VA = "0x1CFC710")]
		public ES3Type_Image()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1CFC7E0", Offset = "0x1CFC7E0", VA = "0x1CFC7E0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600030A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class ES3Type_ImageArray : ES3ArrayType
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1CFD098", Offset = "0x1CFD098", VA = "0x1CFD098")]
		public ES3Type_ImageArray()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x855E4C", Offset = "0x855E4C")]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x21E06B0", Offset = "0x21E06B0", VA = "0x21E06B0")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x21E0778", Offset = "0x21E0778", VA = "0x21E0778", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600030F")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x21E0A9C", Offset = "0x21E0A9C", VA = "0x21E0A9C")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x855F40", Offset = "0x855F40")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x21E0B94", Offset = "0x21E0B94", VA = "0x21E0B94")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x21E0C5C", Offset = "0x21E0C5C", VA = "0x21E0C5C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000314")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x21E0D08", Offset = "0x21E0D08", VA = "0x21E0D08")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x855FC4", Offset = "0x855FC4")]
	[Preserve]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x21E0E00", Offset = "0x21E0E00", VA = "0x21E0E00")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x21E0EC8", Offset = "0x21E0EC8", VA = "0x21E0EC8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000319")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x21E16D4", Offset = "0x21E16D4", VA = "0x21E16D4")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856148", Offset = "0x856148")]
	[Preserve]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x21E2D50", Offset = "0x21E2D50", VA = "0x21E2D50")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x21E2E18", Offset = "0x21E2E18", VA = "0x21E2E18", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600031E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000078")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85636C", Offset = "0x85636C")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x21E408C", Offset = "0x21E408C", VA = "0x21E408C")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x21E4154", Offset = "0x21E4154", VA = "0x21E4154", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000322")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x21E46DC", Offset = "0x21E46DC", VA = "0x21E46DC")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856470", Offset = "0x856470")]
	public class ES3Type_RawImage : ES3ComponentType
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x21E4E78", Offset = "0x21E4E78", VA = "0x21E4E78")]
		public ES3Type_RawImage()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x21E4F48", Offset = "0x21E4F48", VA = "0x21E4F48", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000327")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class ES3Type_RawImageArray : ES3ArrayType
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x21E54A4", Offset = "0x21E54A4", VA = "0x21E54A4")]
		public ES3Type_RawImageArray()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856594", Offset = "0x856594")]
	public class ES3Type_Rigidbody : ES3ComponentType
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x21E67E4", Offset = "0x21E67E4", VA = "0x21E67E4")]
		public ES3Type_Rigidbody()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x21E68B4", Offset = "0x21E68B4", VA = "0x21E68B4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032C")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class ES3UserType_RigidbodyArray : ES3ArrayType
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1F556C4", Offset = "0x1F556C4", VA = "0x1F556C4")]
		public ES3UserType_RigidbodyArray()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856768", Offset = "0x856768")]
	[Preserve]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1F4CA54", Offset = "0x1F4CA54", VA = "0x1F4CA54")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1F4CB1C", Offset = "0x1F4CB1C", VA = "0x1F4CB1C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000331")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007F")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85683C", Offset = "0x85683C")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1F4E2A0", Offset = "0x1F4E2A0", VA = "0x1F4E2A0")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1F4E368", Offset = "0x1F4E368", VA = "0x1F4E368", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000335")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000080")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856A20", Offset = "0x856A20")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int countRead;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ES3Type Instance;

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1F50574", Offset = "0x1F50574", VA = "0x1F50574")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1F5063C", Offset = "0x1F5063C", VA = "0x1F5063C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000339")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000081")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856AD4", Offset = "0x856AD4")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1CF515C", Offset = "0x1CF515C", VA = "0x1CF515C")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1CF5220", Offset = "0x1CF5220", VA = "0x1CF5220", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600033D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856B78", Offset = "0x856B78")]
	public class ES3Type_AudioClip : ES3UnityObjectType
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1CF53C4", Offset = "0x1CF53C4", VA = "0x1CF53C4")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1CF548C", Offset = "0x1CF548C", VA = "0x1CF548C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000342")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000343")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1CF56D4", Offset = "0x1CF56D4", VA = "0x1CF56D4")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856C3C", Offset = "0x856C3C")]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1CF57CC", Offset = "0x1CF57CC", VA = "0x1CF57CC")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1CF5890", Offset = "0x1CF5890", VA = "0x1CF5890", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000348")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000085")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1CF5C8C", Offset = "0x1CF5C8C", VA = "0x1CF5C8C")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856D30", Offset = "0x856D30")]
	[Preserve]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1CF5D84", Offset = "0x1CF5D84", VA = "0x1CF5D84")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1CF5E48", Offset = "0x1CF5E48", VA = "0x1CF5E48", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600034D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000087")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1CF5FEC", Offset = "0x1CF5FEC", VA = "0x1CF5FEC")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856DC4", Offset = "0x856DC4")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1CF7A20", Offset = "0x1CF7A20", VA = "0x1CF7A20")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1CF7AE4", Offset = "0x1CF7AE4", VA = "0x1CF7AE4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000352")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000089")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x856F58", Offset = "0x856F58")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1CF81E4", Offset = "0x1CF81E4", VA = "0x1CF81E4")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1CF82A8", Offset = "0x1CF82A8", VA = "0x1CF82A8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000357")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1CF88E0", Offset = "0x1CF88E0", VA = "0x1CF88E0")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85700C", Offset = "0x85700C")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1CF84C4", Offset = "0x1CF84C4", VA = "0x1CF84C4")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1CF8588", Offset = "0x1CF8588", VA = "0x1CF8588", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600035C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1CF87A0", Offset = "0x1CF87A0", VA = "0x1CF87A0")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008C")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1CF87E8", Offset = "0x1CF87E8", VA = "0x1CF87E8")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8570C0", Offset = "0x8570C0")]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1CF89D8", Offset = "0x1CF89D8", VA = "0x1CF89D8")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1CF8A9C", Offset = "0x1CF8A9C", VA = "0x1CF8A9C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000362")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857164", Offset = "0x857164")]
	[Preserve]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1CF8D48", Offset = "0x1CF8D48", VA = "0x1CF8D48")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1CF8E0C", Offset = "0x1CF8E0C", VA = "0x1CF8E0C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000367")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008F")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8571F8", Offset = "0x8571F8")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1CF995C", Offset = "0x1CF995C", VA = "0x1CF995C")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1CF9A20", Offset = "0x1CF9A20", VA = "0x1CF9A20", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600036C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000090")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8572BC", Offset = "0x8572BC")]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1CF9E54", Offset = "0x1CF9E54", VA = "0x1CF9E54")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1CF9F18", Offset = "0x1CF9F18", VA = "0x1CF9F18", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000371")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000091")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857350", Offset = "0x857350")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1CFA0F8", Offset = "0x1CFA0F8", VA = "0x1CFA0F8")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1CFA1BC", Offset = "0x1CFA1BC", VA = "0x1CFA1BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000376")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1CFA294", Offset = "0x1CFA294", VA = "0x1CFA294")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8573D4", Offset = "0x8573D4")]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1CFA38C", Offset = "0x1CFA38C", VA = "0x1CFA38C")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1CFA454", Offset = "0x1CFA454", VA = "0x1CFA454", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600037C")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600037D")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1CFA580", Offset = "0x1CFA580", VA = "0x1CFA580")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857468", Offset = "0x857468")]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1CFA678", Offset = "0x1CFA678", VA = "0x1CFA678")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1CFA73C", Offset = "0x1CFA73C", VA = "0x1CFA73C", Slot = "4")]
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
	[Token(Token = "0x2000096")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85756C", Offset = "0x85756C")]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857650", Offset = "0x857650")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Predicate<Component> <>9__0;

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1F5AD98", Offset = "0x1F5AD98", VA = "0x1F5AD98")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x1F5ADA0", Offset = "0x1F5ADA0", VA = "0x1F5ADA0")]
			internal bool <ReadComponents>b__0(Component x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000116")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x4000117")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool saveChildren;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1CFAC2C", Offset = "0x1CFAC2C", VA = "0x1CFAC2C")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1CFACF4", Offset = "0x1CFACF4", VA = "0x1CFACF4", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x6000387")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1CFB768", Offset = "0x1CFB768", VA = "0x1CFB768")]
		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1CFBC64", Offset = "0x1CFBC64", VA = "0x1CFBC64")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1CFB44C", Offset = "0x1CFB44C", VA = "0x1CFB44C")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1CFBCF8", Offset = "0x1CFBCF8", VA = "0x1CFBCF8", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600038D")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600038E")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1CFBD00", Offset = "0x1CFBD00", VA = "0x1CFBD00")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857660", Offset = "0x857660")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1CFBDF8", Offset = "0x1CFBDF8", VA = "0x1CFBDF8")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1CFBEBC", Offset = "0x1CFBEBC", VA = "0x1CFBEBC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000395")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857704", Offset = "0x857704")]
	[Preserve]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1CFC06C", Offset = "0x1CFC06C", VA = "0x1CFC06C")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1CFC130", Offset = "0x1CFC130", VA = "0x1CFC130", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600039A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200009B")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1CFC2A0", Offset = "0x1CFC2A0", VA = "0x1CFC2A0")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857798", Offset = "0x857798")]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1CFC398", Offset = "0x1CFC398", VA = "0x1CFC398")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1CFC45C", Offset = "0x1CFC45C", VA = "0x1CFC45C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600039F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200009D")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1CFC618", Offset = "0x1CFC618", VA = "0x1CFC618")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85782C", Offset = "0x85782C")]
	[Preserve]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1CFD190", Offset = "0x1CFD190", VA = "0x1CFD190")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1CFD254", Offset = "0x1CFD254", VA = "0x1CFD254", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009F")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8578E0", Offset = "0x8578E0")]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x220F798", Offset = "0x220F798", VA = "0x220F798")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x220F860", Offset = "0x220F860", VA = "0x220F860", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A0")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x220FAB0", Offset = "0x220FAB0", VA = "0x220FAB0")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857994", Offset = "0x857994")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x220FBA8", Offset = "0x220FBA8", VA = "0x220FBA8")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x220FC70", Offset = "0x220FC70", VA = "0x220FC70", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A2")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857A38", Offset = "0x857A38")]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x220FDA4", Offset = "0x220FDA4", VA = "0x220FDA4")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x220FE6C", Offset = "0x220FE6C", VA = "0x220FE6C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B2")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857C0C", Offset = "0x857C0C")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2210764", Offset = "0x2210764", VA = "0x2210764")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x221082C", Offset = "0x221082C", VA = "0x221082C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857D40", Offset = "0x857D40")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2210E50", Offset = "0x2210E50", VA = "0x2210E50")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2210F18", Offset = "0x2210F18", VA = "0x2210F18", Slot = "4")]
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
	[Token(Token = "0x20000A5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x857E74", Offset = "0x857E74")]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x221151C", Offset = "0x221151C", VA = "0x221151C")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x22115E4", Offset = "0x22115E4", VA = "0x22115E4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858138", Offset = "0x858138")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x22125CC", Offset = "0x22125CC", VA = "0x22125CC")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2212694", Offset = "0x2212694", VA = "0x2212694", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C5")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x21DFA48", Offset = "0x21DFA48", VA = "0x21DFA48")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8581FC", Offset = "0x8581FC")]
	[Preserve]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x21DFB40", Offset = "0x21DFB40", VA = "0x21DFB40")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x21DFC08", Offset = "0x21DFC08", VA = "0x21DFC08", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003CB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x21DFE7C", Offset = "0x21DFE7C", VA = "0x21DFE7C")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8582B0", Offset = "0x8582B0")]
	[Preserve]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x21DFF74", Offset = "0x21DFF74", VA = "0x21DFF74")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x21E003C", Offset = "0x21E003C", VA = "0x21E003C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D0")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858404", Offset = "0x858404")]
	[Preserve]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x21E17CC", Offset = "0x21E17CC", VA = "0x21E17CC")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x21E1894", Offset = "0x21E1894", VA = "0x21E1894", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D5")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8584F8", Offset = "0x8584F8")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x21E1C50", Offset = "0x21E1C50", VA = "0x21E1C50")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x21E1D18", Offset = "0x21E1D18", VA = "0x21E1D18", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8585DC", Offset = "0x8585DC")]
	[Preserve]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x21E20A4", Offset = "0x21E20A4", VA = "0x21E20A4")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x21E216C", Offset = "0x21E216C", VA = "0x21E216C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858800", Offset = "0x858800")]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x21E38EC", Offset = "0x21E38EC", VA = "0x21E38EC")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x21E39B4", Offset = "0x21E39B4", VA = "0x21E39B4", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E3")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003E4")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x21E3C5C", Offset = "0x21E3C5C", VA = "0x21E3C5C")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8588C4", Offset = "0x8588C4")]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x21E3D54", Offset = "0x21E3D54", VA = "0x21E3D54")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x21E3E1C", Offset = "0x21E3E1C", VA = "0x21E3E1C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E9")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003EA")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B1")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x21E3F94", Offset = "0x21E3F94", VA = "0x21E3F94")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858958", Offset = "0x858958")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x21E47D4", Offset = "0x21E47D4", VA = "0x21E47D4")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x21E489C", Offset = "0x21E489C", VA = "0x21E489C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003EF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B3")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x21E4AB8", Offset = "0x21E4AB8", VA = "0x21E4AB8")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858A0C", Offset = "0x858A0C")]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x21E559C", Offset = "0x21E559C", VA = "0x21E559C")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x21E5664", Offset = "0x21E5664", VA = "0x21E5664", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858AC0", Offset = "0x858AC0")]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x21E58A4", Offset = "0x21E58A4", VA = "0x21E58A4")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x21E596C", Offset = "0x21E596C", VA = "0x21E596C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F8")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858BF4", Offset = "0x858BF4")]
	public class ES3Type_RenderTexture : ES3ObjectType
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x21E5EEC", Offset = "0x21E5EEC", VA = "0x21E5EEC")]
		public ES3Type_RenderTexture()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x21E5FB4", Offset = "0x21E5FB4", VA = "0x21E5FB4", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FC")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003FD")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B7")]
	public class ES3Type_RenderTextureArray : ES3ArrayType
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x21E66EC", Offset = "0x21E66EC", VA = "0x21E66EC")]
		public ES3Type_RenderTextureArray()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858E68", Offset = "0x858E68")]
	[Preserve]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x21E72E4", Offset = "0x21E72E4", VA = "0x21E72E4")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x21E73AC", Offset = "0x21E73AC", VA = "0x21E73AC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000402")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x858F6C", Offset = "0x858F6C")]
	[Preserve]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x21E78D4", Offset = "0x21E78D4", VA = "0x21E78D4")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x21E799C", Offset = "0x21E799C", VA = "0x21E799C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000407")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859060", Offset = "0x859060")]
	[Preserve]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x21E7E30", Offset = "0x21E7E30", VA = "0x21E7E30")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x21E7EF8", Offset = "0x21E7EF8", VA = "0x21E7EF8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600040C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x21E8098", Offset = "0x21E8098", VA = "0x21E8098")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8590F4", Offset = "0x8590F4")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x21E8190", Offset = "0x21E8190", VA = "0x21E8190")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x21E8258", Offset = "0x21E8258", VA = "0x21E8258", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000412")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859298", Offset = "0x859298")]
	[Preserve]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x21E8A3C", Offset = "0x21E8A3C", VA = "0x21E8A3C")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x21E8B04", Offset = "0x21E8B04", VA = "0x21E8B04", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000417")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8593BC", Offset = "0x8593BC")]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x21E90EC", Offset = "0x21E90EC", VA = "0x21E90EC")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x21E91B4", Offset = "0x21E91B4", VA = "0x21E91B4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600041C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8594D0", Offset = "0x8594D0")]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x21E9708", Offset = "0x21E9708", VA = "0x21E9708")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x21E97D0", Offset = "0x21E97D0", VA = "0x21E97D0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000421")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1F4C95C", Offset = "0x1F4C95C", VA = "0x1F4C95C")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8596B4", Offset = "0x8596B4")]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1F4CEA8", Offset = "0x1F4CEA8", VA = "0x1F4CEA8")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1F4CFAC", Offset = "0x1F4CFAC", VA = "0x1F4CFAC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000426")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000427")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C2")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859778", Offset = "0x859778")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1F4D338", Offset = "0x1F4D338", VA = "0x1F4D338")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1F4D400", Offset = "0x1F4D400", VA = "0x1F4D400", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600042B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1F4DD38", Offset = "0x1F4DD38", VA = "0x1F4DD38")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85992C", Offset = "0x85992C")]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1F4DF28", Offset = "0x1F4DF28", VA = "0x1F4DF28")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1F4DFF0", Offset = "0x1F4DFF0", VA = "0x1F4DFF0", Slot = "4")]
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
	[Token(Token = "0x20000C5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8599D0", Offset = "0x8599D0")]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1F4EB3C", Offset = "0x1F4EB3C", VA = "0x1F4EB3C")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1F4EC04", Offset = "0x1F4EC04", VA = "0x1F4EC04", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000435")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000436")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C6")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1F4F4F4", Offset = "0x1F4F4F4", VA = "0x1F4F4F4")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859A94", Offset = "0x859A94")]
	[Preserve]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1F4EDB8", Offset = "0x1F4EDB8", VA = "0x1F4EDB8")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1F4EE8C", Offset = "0x1F4EE8C", VA = "0x1F4EE8C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600043B")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600043C")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1F4F364", Offset = "0x1F4F364", VA = "0x1F4F364")]
		protected bool IsReadable(Texture2D instance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C8")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1F4F3FC", Offset = "0x1F4F3FC", VA = "0x1F4F3FC")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859B58", Offset = "0x859B58")]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1F4F5EC", Offset = "0x1F4F5EC", VA = "0x1F4F5EC")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1F4F6B4", Offset = "0x1F4F6B4", VA = "0x1F4F6B4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000442")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859CAC", Offset = "0x859CAC")]
	[Preserve]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1F4FD00", Offset = "0x1F4FD00", VA = "0x1F4FD00")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1F4FDC8", Offset = "0x1F4FDC8", VA = "0x1F4FDC8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000447")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859E10", Offset = "0x859E10")]
	[Preserve]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1F50830", Offset = "0x1F50830", VA = "0x1F50830")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1F508F8", Offset = "0x1F508F8", VA = "0x1F508F8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600044C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859EE4", Offset = "0x859EE4")]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1F50E8C", Offset = "0x1F50E8C", VA = "0x1F50E8C")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1F50F54", Offset = "0x1F50F54", VA = "0x1F50F54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000451")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CD")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1F510C4", Offset = "0x1F510C4", VA = "0x1F510C4")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x859F78", Offset = "0x859F78")]
	public class ES3Type_Vector2Int : ES3Type
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1F511BC", Offset = "0x1F511BC", VA = "0x1F511BC")]
		public ES3Type_Vector2Int()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1F51284", Offset = "0x1F51284", VA = "0x1F51284", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000456")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CF")]
	public class ES3Type_Vector2IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1F513F8", Offset = "0x1F513F8", VA = "0x1F513F8")]
		public ES3Type_Vector2IntArray()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85A00C", Offset = "0x85A00C")]
	[Preserve]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1F514F0", Offset = "0x1F514F0", VA = "0x1F514F0")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1F515B8", Offset = "0x1F515B8", VA = "0x1F515B8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600045B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D1")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1F51780", Offset = "0x1F51780", VA = "0x1F51780")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85A0B0", Offset = "0x85A0B0")]
	[Preserve]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1F51878", Offset = "0x1F51878", VA = "0x1F51878")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1F51940", Offset = "0x1F51940", VA = "0x1F51940", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000460")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D3")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1F51B40", Offset = "0x1F51B40", VA = "0x1F51B40")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85A154", Offset = "0x85A154")]
	[Preserve]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1F51C38", Offset = "0x1F51C38", VA = "0x1F51C38")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1F51D00", Offset = "0x1F51D00", VA = "0x1F51D00", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000465")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1F51F18", Offset = "0x1F51F18", VA = "0x1F51F18")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D5")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1F51FB8", Offset = "0x1F51FB8", VA = "0x1F51FB8")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x85A208", Offset = "0x85A208")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1F520B0", Offset = "0x1F520B0", VA = "0x1F520B0")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1F52178", Offset = "0x1F52178", VA = "0x1F52178", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600046B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x20000D7")]
	internal static class ES3Debug
	{
		[Token(Token = "0x400015B")]
		private const string disableInfoMsg = "\n<i>To disable these messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Info'</i>";

		[Token(Token = "0x400015C")]
		private const string disableWarningMsg = "\n<i>To disable warnings from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Warnings'</i>";

		[Token(Token = "0x400015D")]
		private const string disableErrorMsg = "\n<i>To disable these error messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Errors'</i>";

		[Token(Token = "0x400015E")]
		private const char indentChar = '-';

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1503BF0", Offset = "0x1503BF0", VA = "0x1503BF0")]
		public static void Log(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x15021FC", Offset = "0x15021FC", VA = "0x15021FC")]
		public static void LogWarning(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1507260", Offset = "0x1507260", VA = "0x1507260")]
		public static void LogError(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x150A744", Offset = "0x150A744", VA = "0x150A744")]
		private static string Indent(int size)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D8")]
	public static class ES3Hash
	{
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x150CADC", Offset = "0x150CADC", VA = "0x150CADC")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D9")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x6000473")]
		public abstract byte[] Encrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000474")]
		public abstract byte[] Decrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000475")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000476")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1F581BC", Offset = "0x1F581BC", VA = "0x1F581BC")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1F582A0", Offset = "0x1F582A0", VA = "0x1F582A0")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x400015F")]
		private const int ivSize = 16;

		[Token(Token = "0x4000160")]
		private const int keySize = 16;

		[Token(Token = "0x4000161")]
		private const int pwIterations = 100;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x14F7CA4", Offset = "0x14F7CA4", VA = "0x14F7CA4", Slot = "4")]
		public override byte[] Encrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x14F7F14", Offset = "0x14F7F14", VA = "0x14F7F14", Slot = "5")]
		public override byte[] Decrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x14F8184", Offset = "0x14F8184", VA = "0x14F8184", Slot = "6")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x14F85D8", Offset = "0x14F85D8", VA = "0x14F85D8", Slot = "7")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x14F8A14", Offset = "0x14F8A14", VA = "0x14F8A14")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1F58338", Offset = "0x1F58338", VA = "0x1F58338")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1F583E0", Offset = "0x1F583E0", VA = "0x1F583E0", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public struct ES3Data
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x150A674", Offset = "0x150A674", VA = "0x150A674")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x150A73C", Offset = "0x150A73C", VA = "0x150A73C")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public static class ES3IO
	{
		[Token(Token = "0x20000DE")]
		public enum ES3FileMode
		{
			[Token(Token = "0x400016D")]
			Read,
			[Token(Token = "0x400016E")]
			Write,
			[Token(Token = "0x400016F")]
			Append
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string persistentDataPath;

		[Token(Token = "0x400016A")]
		internal const string backupFileSuffix = ".bac";

		[Token(Token = "0x400016B")]
		internal const string temporaryFileSuffix = ".tmp";

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x14FFCC0", Offset = "0x14FFCC0", VA = "0x14FFCC0")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x14F9F80", Offset = "0x14F9F80", VA = "0x14F9F80")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x14FBF68", Offset = "0x14FBF68", VA = "0x14FBF68")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x14FC5E4", Offset = "0x14FC5E4", VA = "0x14FC5E4")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x14FCF64", Offset = "0x14FCF64", VA = "0x14FCF64")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x14FC5EC", Offset = "0x14FC5EC", VA = "0x14FC5EC")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x14FDADC", Offset = "0x14FDADC", VA = "0x14FDADC")]
		public static void MoveDirectory(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x14FD4AC", Offset = "0x14FD4AC", VA = "0x14FD4AC")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x14FDA50", Offset = "0x14FDA50", VA = "0x14FDA50")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x150C98C", Offset = "0x150C98C", VA = "0x150C98C")]
		public static string GetDirectoryPath(string path, char seperator = '/')
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x150D5CC", Offset = "0x150D5CC", VA = "0x150D5CC")]
		public static bool UsesForwardSlash(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x14FD5D8", Offset = "0x14FD5D8", VA = "0x14FD5D8")]
		public static string CombinePathAndFilename(string directoryPath, string fileOrDirectoryName)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x14FF508", Offset = "0x14FF508", VA = "0x14FF508")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x14FDA58", Offset = "0x14FDA58", VA = "0x14FDA58")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x14FF2C4", Offset = "0x14FF2C4", VA = "0x14FF2C4")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x150D624", Offset = "0x150D624", VA = "0x150D624")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x150D62C", Offset = "0x150D62C", VA = "0x150D62C")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x14F92D4", Offset = "0x14F92D4", VA = "0x14F92D4")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1511A74", Offset = "0x1511A74", VA = "0x1511A74")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1511C58", Offset = "0x1511C58", VA = "0x1511C58")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1511CD4", Offset = "0x1511CD4", VA = "0x1511CD4")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1511E0C", Offset = "0x1511E0C", VA = "0x1511E0C")]
		public Dictionary<string, string> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1512074", Offset = "0x1512074", VA = "0x1512074")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1511DB4", Offset = "0x1511DB4", VA = "0x1511DB4")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x15125F8", Offset = "0x15125F8", VA = "0x15125F8")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E0")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A30C", Offset = "0x85A30C")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Object obj;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__0;

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1F5A640", Offset = "0x1F5A640", VA = "0x1F5A640")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x1F5A648", Offset = "0x1F5A648", VA = "0x1F5A648")]
			internal bool <Remove>b__0(KeyValuePair<long, UnityEngine.Object> kvp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A31C", Offset = "0x85A31C")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long referenceID;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<UnityEngine.Object, long>, bool> <>9__0;

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1F5A6CC", Offset = "0x1F5A6CC", VA = "0x1F5A6CC")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1F5A6D4", Offset = "0x1F5A6D4", VA = "0x1F5A6D4")]
			internal bool <Remove>b__0(KeyValuePair<UnityEngine.Object, long> kvp)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A32C", Offset = "0x85A32C")]
		private sealed class <>c
		{
			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__31_0;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, long> <>9__31_1;

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1F5A584", Offset = "0x1F5A584", VA = "0x1F5A584")]
			public <>c()
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1F5A58C", Offset = "0x1F5A58C", VA = "0x1F5A58C")]
			internal bool <RemoveNullValues>b__31_0(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x1F5A600", Offset = "0x1F5A600", VA = "0x1F5A600")]
			internal long <RemoveNullValues>b__31_1(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(long);
			}
		}

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _lock;

		[Token(Token = "0x4000173")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HashSet<ES3ReferenceMgrBase> mgrs;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Random rng;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ES3RefIdDictionary _refId;

		[Token(Token = "0x17000028")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1504678", Offset = "0x1504678", VA = "0x1504678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public bool IsInitialised
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1513D44", Offset = "0x1513D44", VA = "0x1513D44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public ES3RefIdDictionary refId
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1513DA4", Offset = "0x1513DA4", VA = "0x1513DA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1513F88", Offset = "0x1513F88", VA = "0x1513F88")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public ES3GlobalReferences GlobalReferences
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1513F90", Offset = "0x1513F90", VA = "0x1513F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1513F98", Offset = "0x1513F98", VA = "0x1513F98")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1514378", Offset = "0x1514378", VA = "0x1514378")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x151423C", Offset = "0x151423C", VA = "0x151423C")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1514404", Offset = "0x1514404", VA = "0x1514404")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1514650", Offset = "0x1514650", VA = "0x1514650")]
		internal UnityEngine.Object Get(long id, Type type, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1514B98", Offset = "0x1514B98", VA = "0x1514B98")]
		public UnityEngine.Object Get(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1514BA4", Offset = "0x1514BA4", VA = "0x1514BA4")]
		public ES3Prefab GetPrefab(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1514FA0", Offset = "0x1514FA0", VA = "0x1514FA0")]
		public long GetPrefab(ES3Prefab prefabToFind, bool suppressWarnings = false)
		{
			return default(long);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x150A2FC", Offset = "0x150A2FC", VA = "0x150A2FC")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x15122AC", Offset = "0x15122AC", VA = "0x15122AC")]
		public long Add(UnityEngine.Object obj, long id)
		{
			return default(long);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x15153AC", Offset = "0x15153AC", VA = "0x15153AC")]
		public bool AddPrefab(ES3Prefab prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x151544C", Offset = "0x151544C", VA = "0x151544C")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1515948", Offset = "0x1515948", VA = "0x1515948")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1515E54", Offset = "0x1515E54", VA = "0x1515E54")]
		public void RemoveNullValues()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x15161C0", Offset = "0x15161C0", VA = "0x15161C0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x15162EC", Offset = "0x15162EC", VA = "0x15162EC")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1516354", Offset = "0x1516354", VA = "0x1516354")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x15163B8", Offset = "0x15163B8", VA = "0x15163B8")]
		public void ChangeId(long oldId, long newId)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1512450", Offset = "0x1512450", VA = "0x1512450")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1511DAC", Offset = "0x1511DAC", VA = "0x1511DAC")]
		internal static bool CanBeSaved(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1513C78", Offset = "0x1513C78", VA = "0x1513C78")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E4")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x150D688", Offset = "0x150D688", VA = "0x150D688", Slot = "38")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x150D694", Offset = "0x150D694", VA = "0x150D694", Slot = "39")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x150D708", Offset = "0x150D708", VA = "0x150D708")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A33C", Offset = "0x85A33C")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1513B98", Offset = "0x1513B98", VA = "0x1513B98", Slot = "38")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1513C0C", Offset = "0x1513C0C", VA = "0x1513C0C", Slot = "39")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1512660", Offset = "0x1512660", VA = "0x1512660")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public static class ES3Reflection
	{
		[Token(Token = "0x20000E7")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x1700002D")]
			public bool IsNull
			{
				[Token(Token = "0x60004EE")]
				[Address(RVA = "0x1F56E9C", Offset = "0x1F56E9C", VA = "0x1F56E9C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002E")]
			public string Name
			{
				[Token(Token = "0x60004EF")]
				[Address(RVA = "0x1F5A918", Offset = "0x1F5A918", VA = "0x1F5A918")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			public Type MemberType
			{
				[Token(Token = "0x60004F0")]
				[Address(RVA = "0x1F56F38", Offset = "0x1F56F38", VA = "0x1F56F38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			public bool IsPublic
			{
				[Token(Token = "0x60004F1")]
				[Address(RVA = "0x1F5A94C", Offset = "0x1F5A94C", VA = "0x1F5A94C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000031")]
			public bool IsProtected
			{
				[Token(Token = "0x60004F2")]
				[Address(RVA = "0x1F5A9EC", Offset = "0x1F5A9EC", VA = "0x1F5A9EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool IsStatic
			{
				[Token(Token = "0x60004F3")]
				[Address(RVA = "0x1F5AA40", Offset = "0x1F5AA40", VA = "0x1F5AA40")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1F5AA94", Offset = "0x1F5AA94", VA = "0x1F5AA94")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1F5AC24", Offset = "0x1F5AC24", VA = "0x1F5AC24")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1F56EE8", Offset = "0x1F56EE8", VA = "0x1F56EE8")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x20000E8")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1F5AC6C", Offset = "0x1F5AC6C", VA = "0x1F5AC6C")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1F5ACE8", Offset = "0x1F5ACE8", VA = "0x1F5ACE8")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes, BindingFlags bindingAttr)
			{
			}

			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1F5AD74", Offset = "0x1F5AD74", VA = "0x1F5AD74")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A350", Offset = "0x85A350")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1F5A880", Offset = "0x1F5A880", VA = "0x1F5A880")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1F5A888", Offset = "0x1F5A888", VA = "0x1F5A888")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A360", Offset = "0x85A360")]
		private sealed class <>c
		{
			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__27_0;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, <>f__AnonymousType0<Assembly, Type>> <>9__27_1;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType0<Assembly, Type>, Type> <>9__27_3;

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1F5A788", Offset = "0x1F5A788", VA = "0x1F5A788")]
			public <>c()
			{
			}

			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1F5A790", Offset = "0x1F5A790", VA = "0x1F5A790")]
			internal IEnumerable<Type> <GetDerivedTypes>b__27_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x1F5A7B4", Offset = "0x1F5A7B4", VA = "0x1F5A7B4")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__27_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x1F5A838", Offset = "0x1F5A838", VA = "0x1F5A838")]
			internal Type <GetDerivedTypes>b__27_3(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x4000182")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x4000183")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x4000184")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] excludedPropertyNames;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Type es3SerializableAttributeType;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Type es3NonSerializableAttributeType;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x1700002C")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x1CE9710", Offset = "0x1CE9710", VA = "0x1CE9710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1CE9A3C", Offset = "0x1CE9A3C", VA = "0x1CE9A3C")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1CE9C08", Offset = "0x1CE9C08", VA = "0x1CE9C08")]
		public static List<FieldInfo> GetSerializableFields(Type type, [Optional] List<FieldInfo> serializableFields, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1CEA598", Offset = "0x1CEA598", VA = "0x1CEA598")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, [Optional] List<PropertyInfo> serializableProperties, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1CEA1F4", Offset = "0x1CEA1F4", VA = "0x1CEA1F4")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1CEAEB4", Offset = "0x1CEAEB4", VA = "0x1CEAEB4")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1CEB044", Offset = "0x1CEB044", VA = "0x1CEB044")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1CEB1E8", Offset = "0x1CEB1E8", VA = "0x1CEB1E8")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1CEB270", Offset = "0x1CEB270", VA = "0x1CEB270")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1CEB278", Offset = "0x1CEB278", VA = "0x1CEB278")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1CEB334", Offset = "0x1CEB334", VA = "0x1CEB334")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1CEB658", Offset = "0x1CEB658", VA = "0x1CEB658")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1CEB840", Offset = "0x1CEB840", VA = "0x1CEB840")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x60004D2")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1CEBA30", Offset = "0x1CEBA30", VA = "0x1CEBA30")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1CE967C", Offset = "0x1CE967C", VA = "0x1CE967C")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1CEBDF0", Offset = "0x1CEBDF0", VA = "0x1CEBDF0")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1CE9BC8", Offset = "0x1CE9BC8", VA = "0x1CE9BC8")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1CEBE10", Offset = "0x1CEBE10", VA = "0x1CEBE10")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1CEBE30", Offset = "0x1CEBE30", VA = "0x1CEBE30")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1CEBE50", Offset = "0x1CEBE50", VA = "0x1CEBE50")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1CEAD94", Offset = "0x1CEAD94", VA = "0x1CEAD94")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1CE9BE8", Offset = "0x1CE9BE8", VA = "0x1CE9BE8")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1CEBED8", Offset = "0x1CEBED8", VA = "0x1CEBED8")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1CEBEF0", Offset = "0x1CEBEF0", VA = "0x1CEBEF0")]
		public static bool IsInterface(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1CE9BA8", Offset = "0x1CE9BA8", VA = "0x1CE9BA8")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1CEAD7C", Offset = "0x1CEAD7C", VA = "0x1CEAD7C")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1CEBF08", Offset = "0x1CEBF08", VA = "0x1CEBF08")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1CEADAC", Offset = "0x1CEADAC", VA = "0x1CEADAC")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1CEBF28", Offset = "0x1CEBF28", VA = "0x1CEBF28")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1CEBFA0", Offset = "0x1CEBFA0", VA = "0x1CEBFA0")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1CEB6E4", Offset = "0x1CEB6E4", VA = "0x1CEB6E4")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1CEB8CC", Offset = "0x1CEB8CC", VA = "0x1CEB8CC")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1CEAC6C", Offset = "0x1CEAC6C", VA = "0x1CEAC6C")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1CEA1E8", Offset = "0x1CEA1E8", VA = "0x1CEA1E8")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1CEAC48", Offset = "0x1CEAC48", VA = "0x1CEAC48")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1CEC08C", Offset = "0x1CEC08C", VA = "0x1CEC08C")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1CEA578", Offset = "0x1CEA578", VA = "0x1CEA578")]
		public static Type BaseType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1CEC134", Offset = "0x1CEC134", VA = "0x1CEC134")]
		public static Type GetType(string typeString)
		{
			return null;
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1CECBD8", Offset = "0x1CECBD8", VA = "0x1CECBD8")]
		public static string GetTypeString(Type type)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000EB")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A370", Offset = "0x85A370")]
		private sealed class <>c
		{
			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, bool> <>9__6_0;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, TKey> <>9__6_1;

			[Token(Token = "0x6000509")]
			public <>c()
			{
			}

			[Token(Token = "0x600050A")]
			internal bool <RemoveNullValues>b__6_0(KeyValuePair<TKey, TVal> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x600050B")]
			internal TKey <RemoveNullValues>b__6_1(KeyValuePair<TKey, TVal> pair)
			{
				return (TKey)null;
			}
		}

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x6000501")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x6000502")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x6000503")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000504")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000505")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x6000506")]
		public bool ChangeKey(TKey oldKey, TKey newKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class ES3BinaryReader : ES3Reader
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BinaryReader baseReader;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1503A20", Offset = "0x1503A20", VA = "0x1503A20")]
		internal ES3BinaryReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1503ADC", Offset = "0x1503ADC", VA = "0x1503ADC", Slot = "21")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1503DDC", Offset = "0x1503DDC", VA = "0x1503DDC", Slot = "22")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1504058", Offset = "0x1504058", VA = "0x1504058", Slot = "23")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1504138", Offset = "0x1504138", VA = "0x1504138", Slot = "27")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1504190", Offset = "0x1504190", VA = "0x1504190", Slot = "28")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x15041B0", Offset = "0x15041B0", VA = "0x15041B0", Slot = "29")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x15041DC", Offset = "0x15041DC", VA = "0x15041DC", Slot = "30")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x15041E0", Offset = "0x15041E0", VA = "0x15041E0", Slot = "31")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x150420C", Offset = "0x150420C", VA = "0x150420C", Slot = "32")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1504210", Offset = "0x1504210", VA = "0x1504210", Slot = "33")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1504214", Offset = "0x1504214", VA = "0x1504214", Slot = "34")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x150421C", Offset = "0x150421C", VA = "0x150421C", Slot = "35")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1504248", Offset = "0x1504248", VA = "0x1504248", Slot = "36")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x150424C", Offset = "0x150424C", VA = "0x150424C", Slot = "37")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1504254", Offset = "0x1504254", VA = "0x1504254", Slot = "38")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x150425C", Offset = "0x150425C", VA = "0x150425C", Slot = "24")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x15044D4", Offset = "0x15044D4", VA = "0x15044D4")]
		private void ReadElement(BinaryWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x150454C", Offset = "0x150454C", VA = "0x150454C", Slot = "20")]
		internal override long Read_ref()
		{
			return default(long);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1504978", Offset = "0x1504978", VA = "0x1504978", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x15049C0", Offset = "0x15049C0", VA = "0x15049C0", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1504A04", Offset = "0x1504A04", VA = "0x1504A04", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1504A4C", Offset = "0x1504A4C", VA = "0x1504A4C", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1504A84", Offset = "0x1504A84", VA = "0x1504A84", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1504AC8", Offset = "0x1504AC8", VA = "0x1504AC8", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1504B10", Offset = "0x1504B10", VA = "0x1504B10", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1504B58", Offset = "0x1504B58", VA = "0x1504B58", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1504BA0", Offset = "0x1504BA0", VA = "0x1504BA0", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1504BE8", Offset = "0x1504BE8", VA = "0x1504BE8", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1504C30", Offset = "0x1504C30", VA = "0x1504C30", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1504C74", Offset = "0x1504C74", VA = "0x1504C74", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1504CB8", Offset = "0x1504CB8", VA = "0x1504CB8", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1504D00", Offset = "0x1504D00", VA = "0x1504D00", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1504D48", Offset = "0x1504D48", VA = "0x1504D48", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85B014", Offset = "0x85B014")]
		public override T Read<T>(ES3Type type)
		{
			return (T)null;
		}

		[Token(Token = "0x600052F")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85B028", Offset = "0x85B028")]
		public override void ReadInto<T>(object obj, ES3Type type)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1503FAC", Offset = "0x1503FAC", VA = "0x1503FAC")]
		private int Read7BitEncodedInt()
		{
			return default(int);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1504DAC", Offset = "0x1504DAC", VA = "0x1504DAC", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x400019D")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamReader baseReader;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x150D75C", Offset = "0x150D75C", VA = "0x150D75C")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x150D970", Offset = "0x150D970", VA = "0x150D970", Slot = "21")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x150DEE8", Offset = "0x150DEE8", VA = "0x150DEE8", Slot = "22")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x150E08C", Offset = "0x150E08C", VA = "0x150E08C", Slot = "23")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x150E09C", Offset = "0x150E09C", VA = "0x150E09C", Slot = "27")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x150E390", Offset = "0x150E390", VA = "0x150E390", Slot = "28")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x150E3C0", Offset = "0x150E3C0", VA = "0x150E3C0", Slot = "29")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x150E3D0", Offset = "0x150E3D0", VA = "0x150E3D0", Slot = "30")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x150E3D4", Offset = "0x150E3D4", VA = "0x150E3D4", Slot = "31")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x150E418", Offset = "0x150E418", VA = "0x150E418", Slot = "32")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x150E420", Offset = "0x150E420", VA = "0x150E420", Slot = "33")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x150E424", Offset = "0x150E424", VA = "0x150E424", Slot = "34")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x150E4EC", Offset = "0x150E4EC", VA = "0x150E4EC", Slot = "35")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x150E4F4", Offset = "0x150E4F4", VA = "0x150E4F4", Slot = "36")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x150E4F8", Offset = "0x150E4F8", VA = "0x150E4F8", Slot = "37")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x150E53C", Offset = "0x150E53C", VA = "0x150E53C", Slot = "38")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x150E604", Offset = "0x150E604", VA = "0x150E604")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x150E744", Offset = "0x150E744", VA = "0x150E744", Slot = "24")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x150E6DC", Offset = "0x150E6DC", VA = "0x150E6DC")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x150DBD0", Offset = "0x150DBD0", VA = "0x150DBD0")]
		private char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
		{
			return default(char);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x150E0B0", Offset = "0x150E0B0", VA = "0x150E0B0")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x150DCDC", Offset = "0x150DCDC", VA = "0x150DCDC")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x150ECC0", Offset = "0x150ECC0", VA = "0x150ECC0")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x150EEA8", Offset = "0x150EEA8", VA = "0x150EEA8")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x150DB3C", Offset = "0x150DB3C", VA = "0x150DB3C")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x150F0B0", Offset = "0x150F0B0", VA = "0x150F0B0")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x150D8BC", Offset = "0x150D8BC", VA = "0x150D8BC")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x150EC88", Offset = "0x150EC88", VA = "0x150EC88")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x150EC04", Offset = "0x150EC04", VA = "0x150EC04")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x150EC18", Offset = "0x150EC18", VA = "0x150EC18")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x150DBBC", Offset = "0x150DBBC", VA = "0x150DBBC")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x150DCB0", Offset = "0x150DCB0", VA = "0x150DCB0")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x150F130", Offset = "0x150F130", VA = "0x150F130")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x150F140", Offset = "0x150F140", VA = "0x150F140")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x150F218", Offset = "0x150F218", VA = "0x150F218", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x150F3DC", Offset = "0x150F3DC", VA = "0x150F3DC", Slot = "20")]
		internal override long Read_ref()
		{
			return default(long);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x150F520", Offset = "0x150F520", VA = "0x150F520", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x150F5A0", Offset = "0x150F5A0", VA = "0x150F5A0", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x150F620", Offset = "0x150F620", VA = "0x150F620", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x150F638", Offset = "0x150F638", VA = "0x150F638", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x150F6AC", Offset = "0x150F6AC", VA = "0x150F6AC", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x150F760", Offset = "0x150F760", VA = "0x150F760", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x150F814", Offset = "0x150F814", VA = "0x150F814", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x150F82C", Offset = "0x150F82C", VA = "0x150F82C", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x150F844", Offset = "0x150F844", VA = "0x150F844", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x150F85C", Offset = "0x150F85C", VA = "0x150F85C", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x150F878", Offset = "0x150F878", VA = "0x150F878", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x150F894", Offset = "0x150F894", VA = "0x150F894", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x150F8B0", Offset = "0x150F8B0", VA = "0x150F8B0", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x150F8CC", Offset = "0x150F8CC", VA = "0x150F8CC", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x150F94C", Offset = "0x150F94C", VA = "0x150F94C", Slot = "25")]
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
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x150CAB8", Offset = "0x150CAB8", VA = "0x150CAB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x150CAC0", Offset = "0x150CAC0", VA = "0x150CAC0")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x150CAC8", Offset = "0x150CAC8", VA = "0x150CAC8")]
		public long GetOrAdd(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x150CAD0", Offset = "0x150CAD0", VA = "0x150CAD0")]
		public void RemoveInvalidKeys()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x150CAD4", Offset = "0x150CAD4", VA = "0x150CAD4")]
		public ES3GlobalReferences()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoUpdateReferences;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x150A7AC", Offset = "0x150A7AC", VA = "0x150A7AC")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public enum ES3FileMode
	{
		[Token(Token = "0x40001A2")]
		Read,
		[Token(Token = "0x40001A3")]
		Write,
		[Token(Token = "0x40001A4")]
		Append
	}
	[Token(Token = "0x20000F2")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x150C780", Offset = "0x150C780", VA = "0x150C780")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x150C850", Offset = "0x150C850", VA = "0x150C850")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x150C95C", Offset = "0x150C95C", VA = "0x150C95C")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x150C97C", Offset = "0x150C97C", VA = "0x150C97C")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x150CA98", Offset = "0x150CA98", VA = "0x150CA98", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000F3")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1511644", Offset = "0x1511644", VA = "0x1511644")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x151177C", Offset = "0x151177C", VA = "0x151177C")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1511688", Offset = "0x1511688", VA = "0x1511688")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x15117C8", Offset = "0x15117C8", VA = "0x15117C8", Slot = "17")]
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
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1CED9AC", Offset = "0x1CED9AC", VA = "0x1CED9AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1CED9D0", Offset = "0x1CED9D0", VA = "0x1CED9D0")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1CEDA00", Offset = "0x1CEDA00", VA = "0x1CEDA00")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1CEDB00", Offset = "0x1CEDB00", VA = "0x1CEDB00", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public static class ES3Stream
	{
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1CEFE3C", Offset = "0x1CEFE3C", VA = "0x1CEFE3C")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1CF20B8", Offset = "0x1CF20B8", VA = "0x1CF20B8")]
		public static Stream CreateStream(Stream stream, ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1CF2498", Offset = "0x1CF2498", VA = "0x1CF2498")]
		public static void CopyTo(Stream source, Stream destination)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class ES3Member
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x15113B0", Offset = "0x15113B0", VA = "0x15113B0")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x15113F4", Offset = "0x15113F4", VA = "0x15113F4")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[Preserve]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85A570", Offset = "0x85A570")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ES3Type lastAccessedType;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1CE9434", Offset = "0x1CE9434", VA = "0x1CE9434")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1CF4FD0", Offset = "0x1CF4FD0", VA = "0x1CF4FD0")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1CF24B0", Offset = "0x1CF24B0", VA = "0x1CF24B0")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1CF4530", Offset = "0x1CF4530", VA = "0x1CF4530")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1CF42C8", Offset = "0x1CF42C8", VA = "0x1CF42C8")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class ES3WebClass
	{
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A390", Offset = "0x85A390")]
		private sealed class <SendWebRequest>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3WebClass <>4__this;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000590")]
				[Address(RVA = "0x1F5AEAC", Offset = "0x1F5AEAC", VA = "0x1F5AEAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0x1F5AEF4", Offset = "0x1F5AEF4", VA = "0x1F5AEF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0x1F55DAC", Offset = "0x1F55DAC", VA = "0x1F55DAC")]
			[DebuggerHidden]
			public <SendWebRequest>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1F5AE34", Offset = "0x1F5AE34", VA = "0x1F5AE34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x1F5AE38", Offset = "0x1F5AE38", VA = "0x1F5AE38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1F5AEB4", Offset = "0x1F5AEB4", VA = "0x1F5AEB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityWebRequest _webRequest;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isDone;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string error;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long errorCode;

		[Token(Token = "0x17000035")]
		public float uploadProgress
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1F557BC", Offset = "0x1F557BC", VA = "0x1F557BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public float downloadProgress
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x1F557D4", Offset = "0x1F557D4", VA = "0x1F557D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public bool isError
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x1F557EC", Offset = "0x1F557EC", VA = "0x1F557EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1F5582C", Offset = "0x1F5582C", VA = "0x1F5582C")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1F558BC", Offset = "0x1F558BC", VA = "0x1F558BC")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1F55960", Offset = "0x1F55960", VA = "0x1F55960")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1F55A00", Offset = "0x1F55A00", VA = "0x1F55A00")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1F55B60", Offset = "0x1F55B60", VA = "0x1F55B60")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1F55D34", Offset = "0x1F55D34", VA = "0x1F55D34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85B03C", Offset = "0x85B03C")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1F55DD8", Offset = "0x1F55DD8", VA = "0x1F55DD8", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	internal enum ES3SpecialByte : byte
	{
		[Token(Token = "0x40001BE")]
		Null = 0,
		[Token(Token = "0x40001BF")]
		Bool = 1,
		[Token(Token = "0x40001C0")]
		Byte = 2,
		[Token(Token = "0x40001C1")]
		Sbyte = 3,
		[Token(Token = "0x40001C2")]
		Char = 4,
		[Token(Token = "0x40001C3")]
		Decimal = 5,
		[Token(Token = "0x40001C4")]
		Double = 6,
		[Token(Token = "0x40001C5")]
		Float = 7,
		[Token(Token = "0x40001C6")]
		Int = 8,
		[Token(Token = "0x40001C7")]
		Uint = 9,
		[Token(Token = "0x40001C8")]
		Long = 10,
		[Token(Token = "0x40001C9")]
		Ulong = 11,
		[Token(Token = "0x40001CA")]
		Short = 12,
		[Token(Token = "0x40001CB")]
		Ushort = 13,
		[Token(Token = "0x40001CC")]
		String = 14,
		[Token(Token = "0x40001CD")]
		ByteArray = 15,
		[Token(Token = "0x40001CE")]
		Collection = 128,
		[Token(Token = "0x40001CF")]
		Dictionary = 129,
		[Token(Token = "0x40001D0")]
		CollectionItem = 130,
		[Token(Token = "0x40001D1")]
		Object = 254,
		[Token(Token = "0x40001D2")]
		Terminator = byte.MaxValue
	}
	[Token(Token = "0x20000FB")]
	internal static class ES3Binary
	{
		[Token(Token = "0x40001D3")]
		internal const string ObjectTerminator = ".";

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<ES3SpecialByte, Type> IdToType;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<Type, ES3SpecialByte> TypeToId;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1503174", Offset = "0x1503174", VA = "0x1503174")]
		internal static ES3SpecialByte TypeToByte(Type type)
		{
			return default(ES3SpecialByte);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1503224", Offset = "0x1503224", VA = "0x1503224")]
		internal static Type ByteToType(ES3SpecialByte b)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1503284", Offset = "0x1503284", VA = "0x1503284")]
		internal static Type ByteToType(byte b)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1503380", Offset = "0x1503380", VA = "0x1503380")]
		internal static bool IsPrimitive(ES3SpecialByte b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FC")]
	internal class ES3BinaryWriter : ES3Writer
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal BinaryWriter baseWriter;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1504DCC", Offset = "0x1504DCC", VA = "0x1504DCC")]
		public ES3BinaryWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1504DD8", Offset = "0x1504DD8", VA = "0x1504DD8")]
		internal ES3BinaryWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1504E8C", Offset = "0x1504E8C", VA = "0x1504E8C", Slot = "39")]
		internal override void Write(string key, Type type, byte[] value)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x150540C", Offset = "0x150540C", VA = "0x150540C", Slot = "41")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85B0EC", Offset = "0x85B0EC")]
		public override void Write(Type type, string key, object value)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x15059A4", Offset = "0x15059A4", VA = "0x15059A4", Slot = "46")]
		public override void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1505E80", Offset = "0x1505E80", VA = "0x1505E80", Slot = "49")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85B100", Offset = "0x85B100")]
		public override void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1506364", Offset = "0x1506364", VA = "0x1506364", Slot = "50")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85B114", Offset = "0x85B114")]
		public override void WritePropertyByRef(string name, UnityEngine.Object value)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x15068FC", Offset = "0x15068FC", VA = "0x15068FC", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1506940", Offset = "0x1506940", VA = "0x1506940", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x150699C", Offset = "0x150699C", VA = "0x150699C", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x15069EC", Offset = "0x15069EC", VA = "0x15069EC", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1506A50", Offset = "0x1506A50", VA = "0x1506A50", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1506AAC", Offset = "0x1506AAC", VA = "0x1506AAC", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1506B00", Offset = "0x1506B00", VA = "0x1506B00", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1506B54", Offset = "0x1506B54", VA = "0x1506B54", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1506BA8", Offset = "0x1506BA8", VA = "0x1506BA8", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1506BF8", Offset = "0x1506BF8", VA = "0x1506BF8", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1506C48", Offset = "0x1506C48", VA = "0x1506C48", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1506C9C", Offset = "0x1506C9C", VA = "0x1506C9C", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1506CF0", Offset = "0x1506CF0", VA = "0x1506CF0", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1506D44", Offset = "0x1506D44", VA = "0x1506D44", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1506DB4", Offset = "0x1506DB4", VA = "0x1506DB4", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x15053B0", Offset = "0x15053B0", VA = "0x15053B0")]
		private void Write7BitEncodedInt(int value)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1506E08", Offset = "0x1506E08", VA = "0x1506E08", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1506E2C", Offset = "0x1506E2C", VA = "0x1506E2C", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1506EA0", Offset = "0x1506EA0", VA = "0x1506EA0", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1506EA8", Offset = "0x1506EA8", VA = "0x1506EA8", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1506F14", Offset = "0x1506F14", VA = "0x1506F14", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1506F58", Offset = "0x1506F58", VA = "0x1506F58", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1506F60", Offset = "0x1506F60", VA = "0x1506F60", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1506F9C", Offset = "0x1506F9C", VA = "0x1506F9C", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1507018", Offset = "0x1507018", VA = "0x1507018", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1507054", Offset = "0x1507054", VA = "0x1507054", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1507094", Offset = "0x1507094", VA = "0x1507094", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1507098", Offset = "0x1507098", VA = "0x1507098", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x15070BC", Offset = "0x15070BC", VA = "0x15070BC", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1507100", Offset = "0x1507100", VA = "0x1507100", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1507148", Offset = "0x1507148", VA = "0x1507148", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x150714C", Offset = "0x150714C", VA = "0x150714C", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1507150", Offset = "0x1507150", VA = "0x1507150", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1507154", Offset = "0x1507154", VA = "0x1507154", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1507158", Offset = "0x1507158", VA = "0x1507158", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	internal class ES3CacheWriter : ES3Writer
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ES3File es3File;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1507178", Offset = "0x1507178", VA = "0x1507178")]
		internal ES3CacheWriter(ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x60005C3")]
		public override void Write<T>(string key, object value)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1507214", Offset = "0x1507214", VA = "0x1507214", Slot = "39")]
		internal override void Write(string key, Type type, byte[] value)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1507444", Offset = "0x1507444", VA = "0x1507444", Slot = "41")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x85B128", Offset = "0x85B128")]
		public override void Write(Type type, string key, object value)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x15074B0", Offset = "0x15074B0", VA = "0x15074B0", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x15074B4", Offset = "0x15074B4", VA = "0x15074B4", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x15074B8", Offset = "0x15074B8", VA = "0x15074B8", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x15074BC", Offset = "0x15074BC", VA = "0x15074BC", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x15074C0", Offset = "0x15074C0", VA = "0x15074C0", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x15074C4", Offset = "0x15074C4", VA = "0x15074C4", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x15074C8", Offset = "0x15074C8", VA = "0x15074C8", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x15074CC", Offset = "0x15074CC", VA = "0x15074CC", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x15074D0", Offset = "0x15074D0", VA = "0x15074D0", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x15074D4", Offset = "0x15074D4", VA = "0x15074D4", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x15074D8", Offset = "0x15074D8", VA = "0x15074D8", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x15074DC", Offset = "0x15074DC", VA = "0x15074DC", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x15074E0", Offset = "0x15074E0", VA = "0x15074E0", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x15074E4", Offset = "0x15074E4", VA = "0x15074E4", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x15074E8", Offset = "0x15074E8", VA = "0x15074E8", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x15074EC", Offset = "0x15074EC", VA = "0x15074EC", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x15074F0", Offset = "0x15074F0", VA = "0x15074F0")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x15074F8", Offset = "0x15074F8", VA = "0x15074F8")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x15074FC", Offset = "0x15074FC", VA = "0x15074FC", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1507500", Offset = "0x1507500", VA = "0x1507500", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1507504", Offset = "0x1507504", VA = "0x1507504", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1507508", Offset = "0x1507508", VA = "0x1507508", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1507510", Offset = "0x1507510", VA = "0x1507510", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1507514", Offset = "0x1507514", VA = "0x1507514", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1507518", Offset = "0x1507518", VA = "0x1507518", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x150751C", Offset = "0x150751C", VA = "0x150751C", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1507520", Offset = "0x1507520", VA = "0x1507520", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1507524", Offset = "0x1507524", VA = "0x1507524", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1507528", Offset = "0x1507528", VA = "0x1507528", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x150752C", Offset = "0x150752C", VA = "0x150752C", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1507530", Offset = "0x1507530", VA = "0x1507530", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1507534", Offset = "0x1507534", VA = "0x1507534", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1507538", Offset = "0x1507538", VA = "0x1507538", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x150753C", Offset = "0x150753C", VA = "0x150753C", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1507540", Offset = "0x1507540", VA = "0x1507540", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1507544", Offset = "0x1507544", VA = "0x1507544", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x150F968", Offset = "0x150F968", VA = "0x150F968")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x150F974", Offset = "0x150F974", VA = "0x150F974")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x150FA20", Offset = "0x150FA20", VA = "0x150FA20", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x150FA44", Offset = "0x150FA44", VA = "0x150FA44", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x150FB00", Offset = "0x150FB00", VA = "0x150FB00", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x150FB88", Offset = "0x150FB88", VA = "0x150FB88", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x150FC2C", Offset = "0x150FC2C", VA = "0x150FC2C", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x150FCE8", Offset = "0x150FCE8", VA = "0x150FCE8", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x150FD0C", Offset = "0x150FD0C", VA = "0x150FD0C", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x150FD30", Offset = "0x150FD30", VA = "0x150FD30", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x150FD54", Offset = "0x150FD54", VA = "0x150FD54", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x150FDE8", Offset = "0x150FDE8", VA = "0x150FDE8", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x150FE7C", Offset = "0x150FE7C", VA = "0x150FE7C", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x150FF10", Offset = "0x150FF10", VA = "0x150FF10", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x150FFA4", Offset = "0x150FFA4", VA = "0x150FFA4", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x150FFE8", Offset = "0x150FFE8", VA = "0x150FFE8", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1510070", Offset = "0x1510070", VA = "0x1510070", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x15102A8", Offset = "0x15102A8", VA = "0x15102A8", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1510308", Offset = "0x1510308", VA = "0x1510308")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x151033C", Offset = "0x151033C", VA = "0x151033C")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1510420", Offset = "0x1510420", VA = "0x1510420", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x15104BC", Offset = "0x15104BC", VA = "0x15104BC", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1510508", Offset = "0x1510508", VA = "0x1510508", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1510564", Offset = "0x1510564", VA = "0x1510564", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1510630", Offset = "0x1510630", VA = "0x1510630", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1510638", Offset = "0x1510638", VA = "0x1510638", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1510680", Offset = "0x1510680", VA = "0x1510680", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x15106CC", Offset = "0x15106CC", VA = "0x15106CC", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1510714", Offset = "0x1510714", VA = "0x1510714", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x151075C", Offset = "0x151075C", VA = "0x151075C", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x151078C", Offset = "0x151078C", VA = "0x151078C", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1510790", Offset = "0x1510790", VA = "0x1510790", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x15107A0", Offset = "0x15107A0", VA = "0x15107A0", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x15107B0", Offset = "0x15107B0", VA = "0x15107B0", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x15107E0", Offset = "0x15107E0", VA = "0x15107E0", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1510808", Offset = "0x1510808", VA = "0x1510808", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x151080C", Offset = "0x151080C", VA = "0x151080C", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1510810", Offset = "0x1510810", VA = "0x1510810", Slot = "22")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x151038C", Offset = "0x151038C", VA = "0x151038C")]
		public void WriteNewlineAndTabs()
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x85A3A0", Offset = "0x85A3A0")]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x14F8A1C", Offset = "0x14F8A1C", VA = "0x14F8A1C")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public enum MessageCode
	{
		[Token(Token = "0x40001DB")]
		UnityReflectionMethodNotFound
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x85A3B4", Offset = "0x85A3B4")]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1F582A8", Offset = "0x1F582A8", VA = "0x1F582A8")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x85A3C8", Offset = "0x85A3C8")]
	public class RenameAttribute : Attribute
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string target;

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1F582B0", Offset = "0x1F582B0", VA = "0x1F582B0")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1F582B8", Offset = "0x1F582B8", VA = "0x1F582B8")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1F582E4", Offset = "0x1F582E4", VA = "0x1F582E4")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x85A3DC", Offset = "0x85A3DC")]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1F582EC", Offset = "0x1F582EC", VA = "0x1F582EC")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x85A3F0", Offset = "0x85A3F0")]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1F582F4", Offset = "0x1F582F4", VA = "0x1F582F4")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x85A404", Offset = "0x85A404")]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1F582FC", Offset = "0x1F582FC", VA = "0x1F582FC")]
		public SkipRenameAttribute()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x85A418", Offset = "0x85A418")]
	public class SuppressLogAttribute : Attribute
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MessageCode _messageCode;

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1F58304", Offset = "0x1F58304", VA = "0x1F58304")]
		private SuppressLogAttribute()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1F5830C", Offset = "0x1F5830C", VA = "0x1F5830C")]
		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
