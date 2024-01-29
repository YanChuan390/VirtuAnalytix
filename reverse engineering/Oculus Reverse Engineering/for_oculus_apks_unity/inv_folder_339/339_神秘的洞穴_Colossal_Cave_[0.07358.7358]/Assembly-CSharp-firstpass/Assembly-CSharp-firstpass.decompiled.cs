using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using ES3Internal;
using ES3Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
public class ES3Serializable : Attribute
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE7B5FC", Offset = "0xE7B5FC", VA = "0xE7B5FC")]
	public ES3Serializable()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
public class ES3NonSerializable : Attribute
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE7B604", Offset = "0xE7B604", VA = "0xE7B604")]
	public ES3NonSerializable()
	{
	}
}
[Token(Token = "0x2000005")]
public class ES3AutoSave : MonoBehaviour, ISerializationCallbackReceiver
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool saveLayer;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool saveTag;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool saveName;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool saveHideFlags;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool saveActive;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool saveChildren;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	private bool isQuitting;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<UnityEngine.Component> componentsToSave;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE7B60C", Offset = "0xE7B60C", VA = "0xE7B60C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE7B618", Offset = "0xE7B618", VA = "0xE7B618")]
	public void Awake()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE7B998", Offset = "0xE7B998", VA = "0xE7B998")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE7B9A4", Offset = "0xE7B9A4", VA = "0xE7B9A4")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE7BA60", Offset = "0xE7BA60", VA = "0xE7BA60", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE7BA64", Offset = "0xE7BA64", VA = "0xE7BA64", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE7BB6C", Offset = "0xE7BB6C", VA = "0xE7BB6C")]
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
		[Token(Token = "0x4000014")]
		None,
		[Token(Token = "0x4000015")]
		Awake,
		[Token(Token = "0x4000016")]
		Start
	}

	[Token(Token = "0x2000009")]
	public enum SaveEvent
	{
		[Token(Token = "0x4000018")]
		None,
		[Token(Token = "0x4000019")]
		OnApplicationQuit,
		[Token(Token = "0x400001A")]
		OnApplicationPause
	}

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ES3AutoSaveMgr _current;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveEvent saveEvent;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LoadEvent loadEvent;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ES3SerializableSettings settings;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HashSet<ES3AutoSave> autoSaves;

	[Token(Token = "0x17000003")]
	public static ES3AutoSaveMgr Current
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xE7B6BC", Offset = "0xE7B6BC", VA = "0xE7B6BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public static ES3AutoSaveMgr Instance
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE7BD5C", Offset = "0xE7BD5C", VA = "0xE7BD5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE7BD60", Offset = "0xE7BD60", VA = "0xE7BD60")]
	public void Save()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xE7C528", Offset = "0xE7C528", VA = "0xE7C528")]
	public void Load()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xE7C644", Offset = "0xE7C644", VA = "0xE7C644")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE7C658", Offset = "0xE7C658", VA = "0xE7C658")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE7C7D0", Offset = "0xE7C7D0", VA = "0xE7C7D0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xE7C7E4", Offset = "0xE7C7E4", VA = "0xE7C7E4")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE7B8EC", Offset = "0xE7B8EC", VA = "0xE7B8EC")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE7B9B4", Offset = "0xE7B9B4", VA = "0xE7B9B4")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE7C684", Offset = "0xE7C684", VA = "0xE7C684")]
	public void GetAutoSaves()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xE7C84C", Offset = "0xE7C84C", VA = "0xE7C84C")]
	public ES3AutoSaveMgr()
	{
	}
}
[Token(Token = "0x200000A")]
public class ES3
{
	[Token(Token = "0x200000B")]
	public enum Location
	{
		[Token(Token = "0x400001C")]
		File,
		[Token(Token = "0x400001D")]
		PlayerPrefs,
		[Token(Token = "0x400001E")]
		InternalMS,
		[Token(Token = "0x400001F")]
		Resources,
		[Token(Token = "0x4000020")]
		Cache
	}

	[Token(Token = "0x200000C")]
	public enum Directory
	{
		[Token(Token = "0x4000022")]
		PersistentDataPath,
		[Token(Token = "0x4000023")]
		DataPath
	}

	[Token(Token = "0x200000D")]
	public enum EncryptionType
	{
		[Token(Token = "0x4000025")]
		None,
		[Token(Token = "0x4000026")]
		AES
	}

	[Token(Token = "0x200000E")]
	public enum CompressionType
	{
		[Token(Token = "0x4000028")]
		None,
		[Token(Token = "0x4000029")]
		Gzip
	}

	[Token(Token = "0x200000F")]
	public enum Format
	{
		[Token(Token = "0x400002B")]
		JSON
	}

	[Token(Token = "0x2000010")]
	public enum ReferenceMode
	{
		[Token(Token = "0x400002D")]
		ByRef,
		[Token(Token = "0x400002E")]
		ByValue,
		[Token(Token = "0x400002F")]
		ByRefAndValue
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE7C9C8", Offset = "0xE7C9C8", VA = "0xE7C9C8")]
	public static void Save(string key, object value)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE7CAA8", Offset = "0xE7CAA8", VA = "0xE7CAA8")]
	public static void Save(string key, object value, string filePath)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE7CB3C", Offset = "0xE7CB3C", VA = "0xE7CB3C")]
	public static void Save(string key, object value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE7CBDC", Offset = "0xE7CBDC", VA = "0xE7CBDC")]
	public static void Save(string key, object value, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000023")]
	public static void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x6000024")]
	public static void Save<T>(string key, T value, string filePath)
	{
	}

	[Token(Token = "0x6000025")]
	public static void Save<T>(string key, T value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000026")]
	public static void Save<T>(string key, T value, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE7CC3C", Offset = "0xE7CC3C", VA = "0xE7CC3C")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE7CEF0", Offset = "0xE7CEF0", VA = "0xE7CEF0")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE7CF64", Offset = "0xE7CF64", VA = "0xE7CF64")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE7CCA0", Offset = "0xE7CCA0", VA = "0xE7CCA0")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE7D5B0", Offset = "0xE7D5B0", VA = "0xE7D5B0")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE7D64C", Offset = "0xE7D64C", VA = "0xE7D64C")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE7D6C0", Offset = "0xE7D6C0", VA = "0xE7D6C0")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE7D614", Offset = "0xE7D614", VA = "0xE7D614")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE7D738", Offset = "0xE7D738", VA = "0xE7D738")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE7D9D4", Offset = "0xE7D9D4", VA = "0xE7D9D4")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE7D79C", Offset = "0xE7D79C", VA = "0xE7D79C")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xE7DAC8", Offset = "0xE7DAC8", VA = "0xE7DAC8")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xE7DD88", Offset = "0xE7DD88", VA = "0xE7DD88")]
	public static void AppendRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xE7DDFC", Offset = "0xE7DDFC", VA = "0xE7DDFC")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xE7DB2C", Offset = "0xE7DB2C", VA = "0xE7DB2C")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE7DE74", Offset = "0xE7DE74", VA = "0xE7DE74")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xE7DEF8", Offset = "0xE7DEF8", VA = "0xE7DEF8")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xE7DEEC", Offset = "0xE7DEEC", VA = "0xE7DEEC")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xE7E114", Offset = "0xE7E114", VA = "0xE7E114")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xE7E18C", Offset = "0xE7E18C", VA = "0xE7E18C")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xE7DF74", Offset = "0xE7DF74", VA = "0xE7DF74")]
	public static void SaveImage(Texture2D texture, int quality, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xE7E214", Offset = "0xE7E214", VA = "0xE7E214")]
	public static object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xE7E290", Offset = "0xE7E290", VA = "0xE7E290")]
	public static object Load(string key, string filePath)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xE7E31C", Offset = "0xE7E31C", VA = "0xE7E31C")]
	public static object Load(string key, string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xE7E3AC", Offset = "0xE7E3AC", VA = "0xE7E3AC")]
	public static object Load(string key, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE7E404", Offset = "0xE7E404", VA = "0xE7E404")]
	public static object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xE7E490", Offset = "0xE7E490", VA = "0xE7E490")]
	public static object Load(string key, string filePath, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xE7E524", Offset = "0xE7E524", VA = "0xE7E524")]
	public static object Load(string key, string filePath, object defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE7E5C4", Offset = "0xE7E5C4", VA = "0xE7E5C4")]
	public static object Load(string key, object defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000045")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x6000046")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000047")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000048")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000049")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600004A")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600004B")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600004C")]
	public static void LoadInto<T>(string key, object obj) where T : class
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xE7E624", Offset = "0xE7E624", VA = "0xE7E624")]
	public static void LoadInto(string key, string filePath, object obj)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xE7E6B8", Offset = "0xE7E6B8", VA = "0xE7E6B8")]
	public static void LoadInto(string key, string filePath, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xE7E758", Offset = "0xE7E758", VA = "0xE7E758")]
	public static void LoadInto(string key, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000050")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000051")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x6000052")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000053")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xE7E7B8", Offset = "0xE7E7B8", VA = "0xE7E7B8")]
	public static string LoadString(string key, string defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xE7E81C", Offset = "0xE7E81C", VA = "0xE7E81C")]
	public static string LoadString(string key, string defaultValue, [Optional] string filePath, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xE7E88C", Offset = "0xE7E88C", VA = "0xE7E88C")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xE7EE2C", Offset = "0xE7EE2C", VA = "0xE7EE2C")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xE7EE90", Offset = "0xE7EE90", VA = "0xE7EE90")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xE7E8E8", Offset = "0xE7E8E8", VA = "0xE7E8E8")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xE7EFA0", Offset = "0xE7EFA0", VA = "0xE7EFA0")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xE7F03C", Offset = "0xE7F03C", VA = "0xE7F03C")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xE7F0A0", Offset = "0xE7F0A0", VA = "0xE7F0A0")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xE7EFFC", Offset = "0xE7EFFC", VA = "0xE7EFFC")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xE7F110", Offset = "0xE7F110", VA = "0xE7F110")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xE7F188", Offset = "0xE7F188", VA = "0xE7F188")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xE7F178", Offset = "0xE7F178", VA = "0xE7F178")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xE7F1FC", Offset = "0xE7F1FC", VA = "0xE7F1FC")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xE7F274", Offset = "0xE7F274", VA = "0xE7F274")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xE7F2E8", Offset = "0xE7F2E8", VA = "0xE7F2E8")]
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
	[Address(RVA = "0xE7FA98", Offset = "0xE7FA98", VA = "0xE7FA98")]
	internal static byte[] Serialize(object value, ES3Type type, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	public static T Deserialize<T>(byte[] bytes, [Optional] ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xE800B8", Offset = "0xE800B8", VA = "0xE800B8")]
	internal static object Deserialize(ES3Type type, byte[] bytes, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	public static void DeserializeInto<T>(byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000069")]
	public static void DeserializeInto<T>(ES3Type type, byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xE805E4", Offset = "0xE805E4", VA = "0xE805E4")]
	public static byte[] EncryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xE807BC", Offset = "0xE807BC", VA = "0xE807BC")]
	public static byte[] DecryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xE80894", Offset = "0xE80894", VA = "0xE80894")]
	public static string EncryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xE80954", Offset = "0xE80954", VA = "0xE80954")]
	public static string DecryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xE80A14", Offset = "0xE80A14", VA = "0xE80A14")]
	public static byte[] CompressBytes(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xE80D70", Offset = "0xE80D70", VA = "0xE80D70")]
	public static byte[] DecompressBytes(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xE811E8", Offset = "0xE811E8", VA = "0xE811E8")]
	public static string CompressString(string str)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xE81298", Offset = "0xE81298", VA = "0xE81298")]
	public static string DecompressString(string str)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xE81348", Offset = "0xE81348", VA = "0xE81348")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xE814F4", Offset = "0xE814F4", VA = "0xE814F4")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xE81558", Offset = "0xE81558", VA = "0xE81558")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xE813A4", Offset = "0xE813A4", VA = "0xE813A4")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xE8164C", Offset = "0xE8164C", VA = "0xE8164C")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xE81B38", Offset = "0xE81B38", VA = "0xE81B38")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xE816DC", Offset = "0xE816DC", VA = "0xE816DC")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xE81FAC", Offset = "0xE81FAC", VA = "0xE81FAC")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xE82438", Offset = "0xE82438", VA = "0xE82438")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xE8203C", Offset = "0xE8203C", VA = "0xE8203C")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xE824D8", Offset = "0xE824D8", VA = "0xE824D8")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xE82810", Offset = "0xE82810", VA = "0xE82810")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xE82568", Offset = "0xE82568", VA = "0xE82568")]
	public static void CopyDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xE82BB4", Offset = "0xE82BB4", VA = "0xE82BB4")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xE82DD4", Offset = "0xE82DD4", VA = "0xE82DD4")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xE82C44", Offset = "0xE82C44", VA = "0xE82C44")]
	public static void RenameDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xE82E74", Offset = "0xE82E74", VA = "0xE82E74")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xE83000", Offset = "0xE83000", VA = "0xE83000")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xE82ED8", Offset = "0xE82ED8", VA = "0xE82ED8")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xE83070", Offset = "0xE83070", VA = "0xE83070")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xE830D4", Offset = "0xE830D4", VA = "0xE830D4")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xE83148", Offset = "0xE83148", VA = "0xE83148")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xE7C26C", Offset = "0xE7C26C", VA = "0xE7C26C")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xE83280", Offset = "0xE83280", VA = "0xE83280")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xE834C0", Offset = "0xE834C0", VA = "0xE834C0")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xE83534", Offset = "0xE83534", VA = "0xE83534")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xE832E4", Offset = "0xE832E4", VA = "0xE832E4")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xE83700", Offset = "0xE83700", VA = "0xE83700")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xE8375C", Offset = "0xE8375C", VA = "0xE8375C")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xE837C0", Offset = "0xE837C0", VA = "0xE837C0")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xE7C0BC", Offset = "0xE7C0BC", VA = "0xE7C0BC")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xE838B4", Offset = "0xE838B4", VA = "0xE838B4")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xE83918", Offset = "0xE83918", VA = "0xE83918")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xE828B0", Offset = "0xE828B0", VA = "0xE828B0")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xE83988", Offset = "0xE83988", VA = "0xE83988")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xE83F50", Offset = "0xE83F50", VA = "0xE83F50")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xE83FB4", Offset = "0xE83FB4", VA = "0xE83FB4")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xE839E4", Offset = "0xE839E4", VA = "0xE839E4")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xE841FC", Offset = "0xE841FC", VA = "0xE841FC")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xE84290", Offset = "0xE84290", VA = "0xE84290")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xE842F4", Offset = "0xE842F4", VA = "0xE842F4")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xE829DC", Offset = "0xE829DC", VA = "0xE829DC")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xE843F8", Offset = "0xE843F8", VA = "0xE843F8")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xE84454", Offset = "0xE84454", VA = "0xE84454")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xE844B8", Offset = "0xE844B8", VA = "0xE844B8")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xE82AE8", Offset = "0xE82AE8", VA = "0xE82AE8")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xE84528", Offset = "0xE84528", VA = "0xE84528")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xE8461C", Offset = "0xE8461C", VA = "0xE8461C")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xE84680", Offset = "0xE84680", VA = "0xE84680")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xE84584", Offset = "0xE84584", VA = "0xE84584")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xE846F0", Offset = "0xE846F0", VA = "0xE846F0")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xE84808", Offset = "0xE84808", VA = "0xE84808")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xE84754", Offset = "0xE84754", VA = "0xE84754")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xE84878", Offset = "0xE84878", VA = "0xE84878")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xE84A60", Offset = "0xE84A60", VA = "0xE84A60")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xE84AC4", Offset = "0xE84AC4", VA = "0xE84AC4")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xE848D4", Offset = "0xE848D4", VA = "0xE848D4")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xE84C1C", Offset = "0xE84C1C", VA = "0xE84C1C")]
	public static void StoreCachedFile()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xE84EB4", Offset = "0xE84EB4", VA = "0xE84EB4")]
	public static void StoreCachedFile(string filePath)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xE84F18", Offset = "0xE84F18", VA = "0xE84F18")]
	public static void StoreCachedFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xE7C4D4", Offset = "0xE7C4D4", VA = "0xE7C4D4")]
	public static void StoreCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xE84F88", Offset = "0xE84F88", VA = "0xE84F88")]
	public static void CacheFile()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xE84FE4", Offset = "0xE84FE4", VA = "0xE84FE4")]
	public static void CacheFile(string filePath)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xE85048", Offset = "0xE85048", VA = "0xE85048")]
	public static void CacheFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xE7C218", Offset = "0xE7C218", VA = "0xE7C218")]
	public static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xE85250", Offset = "0xE85250", VA = "0xE85250")]
	public static void Init()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xE852C8", Offset = "0xE852C8", VA = "0xE852C8")]
	public ES3()
	{
	}
}
[Token(Token = "0x2000011")]
public class ES3File
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static Dictionary<string, ES3File> cachedFiles;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, ES3Data> cache;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool syncWithFile;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DateTime timestamp;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xE852D0", Offset = "0xE852D0", VA = "0xE852D0")]
	public ES3File()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xE85878", Offset = "0xE85878", VA = "0xE85878")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xE858F0", Offset = "0xE858F0", VA = "0xE858F0")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xE8596C", Offset = "0xE8596C", VA = "0xE8596C")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xE85974", Offset = "0xE85974", VA = "0xE85974")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xE859E8", Offset = "0xE859E8", VA = "0xE859E8")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xE85A64", Offset = "0xE85A64", VA = "0xE85A64")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xE85338", Offset = "0xE85338", VA = "0xE85338")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xE85BCC", Offset = "0xE85BCC", VA = "0xE85BCC")]
	public ES3File(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xE85CF4", Offset = "0xE85CF4", VA = "0xE85CF4")]
	public void Sync()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xE860E8", Offset = "0xE860E8", VA = "0xE860E8")]
	public void Sync(string filePath, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xE85CFC", Offset = "0xE85CFC", VA = "0xE85CFC")]
	public void Sync([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xE861B0", Offset = "0xE861B0", VA = "0xE861B0")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xE86200", Offset = "0xE86200", VA = "0xE86200")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	public void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xE7D0F4", Offset = "0xE7D0F4", VA = "0xE7D0F4")]
	public void SaveRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xE7DA4C", Offset = "0xE7DA4C", VA = "0xE7DA4C")]
	public void AppendRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xE863A4", Offset = "0xE863A4", VA = "0xE863A4")]
	public object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xE863FC", Offset = "0xE863FC", VA = "0xE863FC")]
	public object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60000C9")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60000CA")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xE7EF00", Offset = "0xE7EF00", VA = "0xE7EF00")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xE869EC", Offset = "0xE869EC", VA = "0xE869EC")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xE8645C", Offset = "0xE8645C", VA = "0xE8645C")]
	internal byte[] GetBytes([Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xE86A94", Offset = "0xE86A94", VA = "0xE86A94")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xE86AEC", Offset = "0xE86AEC", VA = "0xE86AEC")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xE86B44", Offset = "0xE86B44", VA = "0xE86B44")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xE86CA4", Offset = "0xE86CA4", VA = "0xE86CA4")]
	public Type GetKeyType(string key)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xE7CFDC", Offset = "0xE7CFDC", VA = "0xE7CFDC")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static ES3File GetOrCreateCachedFile(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xE850B8", Offset = "0xE850B8", VA = "0xE850B8")]
	internal static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xE84C6C", Offset = "0xE84C6C", VA = "0xE84C6C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void Store([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xE815C8", Offset = "0xE815C8", VA = "0xE815C8")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void RemoveCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xE81BD8", Offset = "0xE81BD8", VA = "0xE81BD8")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void CopyCachedFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xE831C0", Offset = "0xE831C0", VA = "0xE831C0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xE835AC", Offset = "0xE835AC", VA = "0xE835AC")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xE83830", Offset = "0xE83830", VA = "0xE83830")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xE84024", Offset = "0xE84024", VA = "0xE84024")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xE84364", Offset = "0xE84364", VA = "0xE84364")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xE84B34", Offset = "0xE84B34", VA = "0xE84B34")]
	internal static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}
}
[Token(Token = "0x2000012")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xE86FEC", Offset = "0xE86FEC", VA = "0xE86FEC")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000013")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase
{
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xE86FF4", Offset = "0xE86FF4", VA = "0xE86FF4")]
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
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int col;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int row;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE8731C", Offset = "0xE8731C", VA = "0xE8731C")]
		public Index(int col, int row)
		{
		}
	}

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int cols;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int rows;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Index, string> cells;

	[Token(Token = "0x4000038")]
	private const string QUOTE = "\"";

	[Token(Token = "0x4000039")]
	private const char QUOTE_CHAR = '"';

	[Token(Token = "0x400003A")]
	private const char COMMA_CHAR = ',';

	[Token(Token = "0x400003B")]
	private const char NEWLINE_CHAR = '\n';

	[Token(Token = "0x400003C")]
	private const string ESCAPED_QUOTE = "\"\"";

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static char[] CHARS_TO_ESCAPE;

	[Token(Token = "0x17000005")]
	public int ColumnCount
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE8704C", Offset = "0xE8704C", VA = "0xE8704C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public int RowCount
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE87054", Offset = "0xE87054", VA = "0xE87054")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xE8705C", Offset = "0xE8705C", VA = "0xE8705C")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xE87280", Offset = "0xE87280", VA = "0xE87280")]
	private void SetCellString(int col, int row, string value)
	{
	}

	[Token(Token = "0x60000E4")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xE87324", Offset = "0xE87324", VA = "0xE87324")]
	public object GetCell(Type type, int col, int row)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xE8772C", Offset = "0xE8772C", VA = "0xE8772C")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xE877D8", Offset = "0xE877D8", VA = "0xE877D8")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xE877B0", Offset = "0xE877B0", VA = "0xE877B0")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xE87B48", Offset = "0xE87B48", VA = "0xE87B48")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xE87C20", Offset = "0xE87C20", VA = "0xE87C20")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xE87860", Offset = "0xE87860", VA = "0xE87860")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xE87CC0", Offset = "0xE87CC0", VA = "0xE87CC0")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xE880A8", Offset = "0xE880A8", VA = "0xE880A8")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xE88124", Offset = "0xE88124", VA = "0xE88124")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xE8812C", Offset = "0xE8812C", VA = "0xE8812C")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xE881A8", Offset = "0xE881A8", VA = "0xE881A8")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xE87D38", Offset = "0xE87D38", VA = "0xE87D38")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xE8840C", Offset = "0xE8840C", VA = "0xE8840C")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xE88534", Offset = "0xE88534", VA = "0xE88534")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xE88230", Offset = "0xE88230", VA = "0xE88230")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE88608", Offset = "0xE88608", VA = "0xE88608")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x2000016")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000017")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderPropertyEnumerator <>4__this;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600013B")]
				[Address(RVA = "0xE890E4", Offset = "0xE890E4", VA = "0xE890E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013D")]
				[Address(RVA = "0xE8912C", Offset = "0xE8912C", VA = "0xE8912C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0xE89008", Offset = "0xE89008", VA = "0xE89008")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000139")]
			[Address(RVA = "0xE89030", Offset = "0xE89030", VA = "0xE89030", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0xE89034", Offset = "0xE89034", VA = "0xE89034", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0xE890EC", Offset = "0xE890EC", VA = "0xE890EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE888B0", Offset = "0xE888B0", VA = "0xE888B0")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE84188", Offset = "0xE84188", VA = "0xE84188")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__2))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000019")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderRawEnumerator <>4__this;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000143")]
				[Address(RVA = "0xE89324", Offset = "0xE89324", VA = "0xE89324", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000145")]
				[Address(RVA = "0xE8936C", Offset = "0xE8936C", VA = "0xE8936C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0xE89134", Offset = "0xE89134", VA = "0xE89134")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0xE8915C", Offset = "0xE8915C", VA = "0xE8915C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0xE89160", Offset = "0xE89160", VA = "0xE89160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0xE8932C", Offset = "0xE8932C", VA = "0xE8932C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE88950", Offset = "0xE88950", VA = "0xE88950")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE85B58", Offset = "0xE85B58", VA = "0xE85B58")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__2))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected int serializationDepth;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal string overridePropertiesName;

	[Token(Token = "0x17000007")]
	public virtual ES3ReaderPropertyEnumerator Properties
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE88840", Offset = "0xE88840", VA = "0xE88840", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE888E0", Offset = "0xE888E0", VA = "0xE888E0", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000F8")]
	internal abstract int Read_int();

	[Token(Token = "0x60000F9")]
	internal abstract float Read_float();

	[Token(Token = "0x60000FA")]
	internal abstract bool Read_bool();

	[Token(Token = "0x60000FB")]
	internal abstract char Read_char();

	[Token(Token = "0x60000FC")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x60000FD")]
	internal abstract double Read_double();

	[Token(Token = "0x60000FE")]
	internal abstract long Read_long();

	[Token(Token = "0x60000FF")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x6000100")]
	internal abstract byte Read_byte();

	[Token(Token = "0x6000101")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x6000102")]
	internal abstract short Read_short();

	[Token(Token = "0x6000103")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x6000104")]
	internal abstract uint Read_uint();

	[Token(Token = "0x6000105")]
	internal abstract string Read_string();

	[Token(Token = "0x6000106")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x6000107")]
	internal abstract long Read_ref();

	[Token(Token = "0x6000108")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract string ReadPropertyName();

	[Token(Token = "0x6000109")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x600010A")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x600010B")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x600010C")]
	public abstract void Dispose();

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xE88730", Offset = "0xE88730", VA = "0xE88730", Slot = "26")]
	internal virtual bool Goto(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE887EC", Offset = "0xE887EC", VA = "0xE887EC", Slot = "27")]
	internal virtual bool StartReadObject()
	{
		return default(bool);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE88800", Offset = "0xE88800", VA = "0xE88800", Slot = "28")]
	internal virtual void EndReadObject()
	{
	}

	[Token(Token = "0x6000110")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x6000111")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x6000112")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x6000113")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x6000114")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x6000115")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x6000116")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x6000117")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x6000118")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x6000119")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xE88810", Offset = "0xE88810", VA = "0xE88810")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE88980", Offset = "0xE88980", VA = "0xE88980", Slot = "41")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x600011E")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600011F")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x6000120")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000121")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE88994", Offset = "0xE88994", VA = "0xE88994")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public long ReadRefProperty()
	{
		return default(long);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xE889C4", Offset = "0xE889C4", VA = "0xE889C4")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE88A98", Offset = "0xE88A98", VA = "0xE88A98")]
	public object SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE88C38", Offset = "0xE88C38", VA = "0xE88C38")]
	public object SetPrivateField(string name, object value, object objectContainingField)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000127")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000128")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000129")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x600012A")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600012B")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600012C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x600012D")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xE88DD8", Offset = "0xE88DD8", VA = "0xE88DD8")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xE88E34", Offset = "0xE88E34", VA = "0xE88E34")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xE88E98", Offset = "0xE88E98", VA = "0xE88E98")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xE83668", Offset = "0xE83668", VA = "0xE83668")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xE88F08", Offset = "0xE88F08", VA = "0xE88F08")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xE862CC", Offset = "0xE862CC", VA = "0xE862CC")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xE88F6C", Offset = "0xE88F6C", VA = "0xE88F6C")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xE80554", Offset = "0xE80554", VA = "0xE80554")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x200001B")]
public class ES3XMLReader
{
	[Token(Token = "0x6000146")]
	[Address(RVA = "0xE89374", Offset = "0xE89374", VA = "0xE89374")]
	public ES3XMLReader()
	{
	}
}
[Token(Token = "0x200001C")]
public class ES3Defaults : ScriptableObject
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ES3SerializableSettings settings;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool addMgrToSceneAutomatically;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool autoUpdateReferences;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool addAllPrefabsToManager;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool logDebugInfo;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool logWarnings;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool logErrors;

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xE8937C", Offset = "0xE8937C", VA = "0xE8937C")]
	public ES3Defaults()
	{
	}
}
[Token(Token = "0x200001D")]
public class ES3Settings : ICloneable
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES3Settings _defaults;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES3Defaults _defaultSettingsScriptableObject;

	[Token(Token = "0x4000054")]
	private const string defaultSettingsPath = "ES3/ES3Defaults";

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ES3Settings _unencryptedUncompressedSettings;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string[] resourcesExtensions;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private ES3.Location _location;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ES3.EncryptionType encryptionType;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ES3.CompressionType compressionType;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string encryptionPassword;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES3.Directory directory;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ES3.Format format;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool prettyPrint;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bufferSize;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool saveChildren;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool postprocessRawCachedData;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool typeChecking;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool safeReflection;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public int serializationDepthLimit;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string[] assemblyNames;

	[Token(Token = "0x1700000D")]
	public static ES3Defaults defaultSettingsScriptableObject
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE89450", Offset = "0xE89450", VA = "0xE89450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public static ES3Settings defaultSettings
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE806BC", Offset = "0xE806BC", VA = "0xE806BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	internal static ES3Settings unencryptedUncompressedSettings
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xE89560", Offset = "0xE89560", VA = "0xE89560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public ES3.Location location
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE7C078", Offset = "0xE7C078", VA = "0xE7C078")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE8970C", Offset = "0xE8970C", VA = "0xE8970C")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public string FullPath
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE7F734", Offset = "0xE7F734", VA = "0xE7F734")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xE7CA54", Offset = "0xE7CA54", VA = "0xE7CA54")]
	public ES3Settings([Optional] string path, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xE89AB8", Offset = "0xE89AB8", VA = "0xE89AB8")]
	public ES3Settings(string path, params Enum[] enums)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xE86D94", Offset = "0xE86D94", VA = "0xE86D94")]
	public ES3Settings(params Enum[] enums)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xE89AF8", Offset = "0xE89AF8", VA = "0xE89AF8")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xE89B30", Offset = "0xE89B30", VA = "0xE89B30")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xE897B4", Offset = "0xE897B4", VA = "0xE897B4")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xE89714", Offset = "0xE89714", VA = "0xE89714")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xE85AEC", Offset = "0xE85AEC", VA = "0xE85AEC", Slot = "4")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xE899F4", Offset = "0xE899F4", VA = "0xE899F4")]
	private void CopyInto(ES3Settings newSettings)
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x6000158")]
	[Address(RVA = "0xE893F8", Offset = "0xE893F8", VA = "0xE893F8")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xE89F58", Offset = "0xE89F58", VA = "0xE89F58")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xE89FBC", Offset = "0xE89FBC", VA = "0xE89FBC")]
	public ES3SerializableSettings(string path)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xE7C95C", Offset = "0xE7C95C", VA = "0xE7C95C")]
	public ES3SerializableSettings(string path, ES3.Location location)
	{
	}
}
[Token(Token = "0x200001F")]
public class ES3Ref
{
	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long id;

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xE8A030", Offset = "0xE8A030", VA = "0xE8A030")]
	public ES3Ref(long id)
	{
	}
}
[Token(Token = "0x2000020")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class <Sync>d__20 : IEnumerator<object>, IEnumerator, IDisposable
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
		public string user;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xE8CA54", Offset = "0xE8CA54", VA = "0xE8CA54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xE8CA9C", Offset = "0xE8CA9C", VA = "0xE8CA9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE8A800", Offset = "0xE8A800", VA = "0xE8A800")]
		[DebuggerHidden]
		public <Sync>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE8C90C", Offset = "0xE8C90C", VA = "0xE8C90C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE8C910", Offset = "0xE8C910", VA = "0xE8C910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE8CA5C", Offset = "0xE8CA5C", VA = "0xE8CA5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <UploadFile>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public long fileTimestamp;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] bytes;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xE8CE80", Offset = "0xE8CE80", VA = "0xE8CE80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xE8CEC8", Offset = "0xE8CEC8", VA = "0xE8CEC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE8B120", Offset = "0xE8B120", VA = "0xE8B120")]
		[DebuggerHidden]
		public <UploadFile>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE8CAA4", Offset = "0xE8CAA4", VA = "0xE8CAA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE8CAC0", Offset = "0xE8CAC0", VA = "0xE8CAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE8CDD0", Offset = "0xE8CDD0", VA = "0xE8CDD0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE8CE88", Offset = "0xE8CE88", VA = "0xE8CE88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class <DownloadFile>d__44 : IEnumerator<object>, IEnumerator, IDisposable
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
		public ES3File es3File;

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

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xE8D360", Offset = "0xE8D360", VA = "0xE8D360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xE8D3A8", Offset = "0xE8D3A8", VA = "0xE8D3A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE8B7B4", Offset = "0xE8B7B4", VA = "0xE8B7B4")]
		[DebuggerHidden]
		public <DownloadFile>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE8CED0", Offset = "0xE8CED0", VA = "0xE8CED0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE8CEEC", Offset = "0xE8CEEC", VA = "0xE8CEEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE8D2B0", Offset = "0xE8D2B0", VA = "0xE8D2B0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE8D368", Offset = "0xE8D368", VA = "0xE8D368", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class <DownloadFile>d__45 : IEnumerator<object>, IEnumerator, IDisposable
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
		public long timestamp;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xE8D7FC", Offset = "0xE8D7FC", VA = "0xE8D7FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xE8D844", Offset = "0xE8D844", VA = "0xE8D844", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE8B7DC", Offset = "0xE8B7DC", VA = "0xE8B7DC")]
		[DebuggerHidden]
		public <DownloadFile>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE8D3B0", Offset = "0xE8D3B0", VA = "0xE8D3B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE8D3CC", Offset = "0xE8D3CC", VA = "0xE8D3CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE8D74C", Offset = "0xE8D74C", VA = "0xE8D74C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE8D804", Offset = "0xE8D804", VA = "0xE8D804", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class <DeleteFile>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xE8DB8C", Offset = "0xE8DB8C", VA = "0xE8DB8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xE8DBD4", Offset = "0xE8DBD4", VA = "0xE8DBD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE8BCB8", Offset = "0xE8BCB8", VA = "0xE8BCB8")]
		[DebuggerHidden]
		public <DeleteFile>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE8D84C", Offset = "0xE8D84C", VA = "0xE8D84C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE8D868", Offset = "0xE8D868", VA = "0xE8D868", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE8DADC", Offset = "0xE8DADC", VA = "0xE8DADC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE8DB94", Offset = "0xE8DB94", VA = "0xE8DB94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class <RenameFile>d__60 : IEnumerator<object>, IEnumerator, IDisposable
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
		public ES3Settings settings;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Settings newSettings;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xE8DF5C", Offset = "0xE8DF5C", VA = "0xE8DF5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xE8DFA4", Offset = "0xE8DFA4", VA = "0xE8DFA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE8C218", Offset = "0xE8C218", VA = "0xE8C218")]
		[DebuggerHidden]
		public <RenameFile>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE8DBDC", Offset = "0xE8DBDC", VA = "0xE8DBDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE8DBF8", Offset = "0xE8DBF8", VA = "0xE8DBF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE8DEAC", Offset = "0xE8DEAC", VA = "0xE8DEAC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE8DF64", Offset = "0xE8DF64", VA = "0xE8DF64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class <DownloadFilenames>d__61 : IEnumerator<object>, IEnumerator, IDisposable
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
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xE8E338", Offset = "0xE8E338", VA = "0xE8E338", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xE8E380", Offset = "0xE8E380", VA = "0xE8E380", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE8C2E4", Offset = "0xE8C2E4", VA = "0xE8C2E4")]
		[DebuggerHidden]
		public <DownloadFilenames>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE8DFAC", Offset = "0xE8DFAC", VA = "0xE8DFAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE8DFC8", Offset = "0xE8DFC8", VA = "0xE8DFC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE8E288", Offset = "0xE8E288", VA = "0xE8E288")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE8E340", Offset = "0xE8E340", VA = "0xE8E340", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class <SearchFilenames>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string searchPattern;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xE8E75C", Offset = "0xE8E75C", VA = "0xE8E75C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xE8E7A4", Offset = "0xE8E7A4", VA = "0xE8E7A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE8C3CC", Offset = "0xE8C3CC", VA = "0xE8C3CC")]
		[DebuggerHidden]
		public <SearchFilenames>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE8E388", Offset = "0xE8E388", VA = "0xE8E388", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE8E3A4", Offset = "0xE8E3A4", VA = "0xE8E3A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE8E6AC", Offset = "0xE8E6AC", VA = "0xE8E6AC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE8E764", Offset = "0xE8E764", VA = "0xE8E764", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class <DownloadTimestamp>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xE8EB38", Offset = "0xE8EB38", VA = "0xE8EB38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE8EB80", Offset = "0xE8EB80", VA = "0xE8EB80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE8C8A8", Offset = "0xE8C8A8", VA = "0xE8C8A8")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE8E7AC", Offset = "0xE8E7AC", VA = "0xE8E7AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE8E7C8", Offset = "0xE8E7C8", VA = "0xE8E7C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE8EA88", Offset = "0xE8EA88", VA = "0xE8EA88")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xE8EB40", Offset = "0xE8EB40", VA = "0xE8EB40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int timeout;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Encoding encoding;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private byte[] _data;

	[Token(Token = "0x17000012")]
	public byte[] data
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE8A10C", Offset = "0xE8A10C", VA = "0xE8A10C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	public string text
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE8A114", Offset = "0xE8A114", VA = "0xE8A114")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public string[] filenames
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE8A14C", Offset = "0xE8A14C", VA = "0xE8A14C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public DateTime timestamp
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE8A210", Offset = "0xE8A210", VA = "0xE8A210")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xE8A058", Offset = "0xE8A058", VA = "0xE8A058")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xE8A0A8", Offset = "0xE8A0A8", VA = "0xE8A0A8")]
	public ES3Cloud(string url, string apiKey, int timeout)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xE8A34C", Offset = "0xE8A34C", VA = "0xE8A34C")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xE8A48C", Offset = "0xE8A48C", VA = "0xE8A48C")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xE8A51C", Offset = "0xE8A51C", VA = "0xE8A51C")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xE8A5B0", Offset = "0xE8A5B0", VA = "0xE8A5B0")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xE8A63C", Offset = "0xE8A63C", VA = "0xE8A63C")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xE8A6D0", Offset = "0xE8A6D0", VA = "0xE8A6D0")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xE8A770", Offset = "0xE8A770", VA = "0xE8A770")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xE8A3CC", Offset = "0xE8A3CC", VA = "0xE8A3CC")]
	[IteratorStateMachine(typeof(<Sync>d__20))]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xE8A828", Offset = "0xE8A828", VA = "0xE8A828")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xE8A900", Offset = "0xE8A900", VA = "0xE8A900")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xE8A9A0", Offset = "0xE8A9A0", VA = "0xE8A9A0")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xE8AA44", Offset = "0xE8AA44", VA = "0xE8AA44")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xE8AADC", Offset = "0xE8AADC", VA = "0xE8AADC")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xE8AB80", Offset = "0xE8AB80", VA = "0xE8AB80")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xE8AC30", Offset = "0xE8AC30", VA = "0xE8AC30")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xE8ACCC", Offset = "0xE8ACCC", VA = "0xE8ACCC")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xE8AF60", Offset = "0xE8AF60", VA = "0xE8AF60")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xE8B01C", Offset = "0xE8B01C", VA = "0xE8B01C")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xE8A8B8", Offset = "0xE8A8B8", VA = "0xE8A8B8")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xE8B0C8", Offset = "0xE8B0C8", VA = "0xE8B0C8")]
	public IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xE8AE7C", Offset = "0xE8AE7C", VA = "0xE8AE7C")]
	[IteratorStateMachine(typeof(<UploadFile>d__33))]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password, long fileTimestamp)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xE8B148", Offset = "0xE8B148", VA = "0xE8B148")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xE8B294", Offset = "0xE8B294", VA = "0xE8B294")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xE8B328", Offset = "0xE8B328", VA = "0xE8B328")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xE8B3C0", Offset = "0xE8B3C0", VA = "0xE8B3C0")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xE8B450", Offset = "0xE8B450", VA = "0xE8B450")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xE8B4E8", Offset = "0xE8B4E8", VA = "0xE8B4E8")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xE8B58C", Offset = "0xE8B58C", VA = "0xE8B58C")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xE8B620", Offset = "0xE8B620", VA = "0xE8B620")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xE8B748", Offset = "0xE8B748", VA = "0xE8B748")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xE8B7AC", Offset = "0xE8B7AC", VA = "0xE8B7AC")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xE8B680", Offset = "0xE8B680", VA = "0xE8B680")]
	[IteratorStateMachine(typeof(<DownloadFile>d__44))]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xE8B1CC", Offset = "0xE8B1CC", VA = "0xE8B1CC")]
	[IteratorStateMachine(typeof(<DownloadFile>d__45))]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xE8B804", Offset = "0xE8B804", VA = "0xE8B804")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xE8B944", Offset = "0xE8B944", VA = "0xE8B944")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xE8B9D4", Offset = "0xE8B9D4", VA = "0xE8B9D4")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xE8BA68", Offset = "0xE8BA68", VA = "0xE8BA68")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xE8BAF4", Offset = "0xE8BAF4", VA = "0xE8BAF4")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xE8BB88", Offset = "0xE8BB88", VA = "0xE8BB88")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xE8BC28", Offset = "0xE8BC28", VA = "0xE8BC28")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xE8B884", Offset = "0xE8B884", VA = "0xE8B884")]
	[IteratorStateMachine(typeof(<DeleteFile>d__53))]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xE8BCE0", Offset = "0xE8BCE0", VA = "0xE8BCE0")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xE8BE68", Offset = "0xE8BE68", VA = "0xE8BE68")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xE8BF28", Offset = "0xE8BF28", VA = "0xE8BF28")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xE8BFD8", Offset = "0xE8BFD8", VA = "0xE8BFD8")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xE8C098", Offset = "0xE8C098", VA = "0xE8C098")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xE8C15C", Offset = "0xE8C15C", VA = "0xE8C15C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xE8BD94", Offset = "0xE8BD94", VA = "0xE8BD94")]
	[IteratorStateMachine(typeof(<RenameFile>d__60))]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xE8C240", Offset = "0xE8C240", VA = "0xE8C240")]
	[IteratorStateMachine(typeof(<DownloadFilenames>d__61))]
	public IEnumerator DownloadFilenames(string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xE8C30C", Offset = "0xE8C30C", VA = "0xE8C30C")]
	[IteratorStateMachine(typeof(<SearchFilenames>d__62))]
	public IEnumerator SearchFilenames(string searchPattern, string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xE8C3F4", Offset = "0xE8C3F4", VA = "0xE8C3F4")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xE8C534", Offset = "0xE8C534", VA = "0xE8C534")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xE8C5C4", Offset = "0xE8C5C4", VA = "0xE8C5C4")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xE8C658", Offset = "0xE8C658", VA = "0xE8C658")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xE8C6E4", Offset = "0xE8C6E4", VA = "0xE8C6E4")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xE8C778", Offset = "0xE8C778", VA = "0xE8C778")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xE8C818", Offset = "0xE8C818", VA = "0xE8C818")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xE8C474", Offset = "0xE8C474", VA = "0xE8C474")]
	[IteratorStateMachine(typeof(<DownloadTimestamp>d__70))]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xE8AD84", Offset = "0xE8AD84", VA = "0xE8AD84")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xE8C8D0", Offset = "0xE8C8D0", VA = "0xE8C8D0")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xE8C8E8", Offset = "0xE8C8E8", VA = "0xE8C8E8", Slot = "4")]
	protected override void Reset()
	{
	}
}
[Token(Token = "0x200002A")]
public abstract class ES3Writer : IDisposable
{
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HashSet<string> keysToDelete;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool writeHeaderAndFooter;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	internal bool overwriteKeys;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int serializationDepth;

	[Token(Token = "0x60001DE")]
	internal abstract void WriteNull();

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xE8EB88", Offset = "0xE8EB88", VA = "0xE8EB88", Slot = "6")]
	internal virtual void StartWriteFile()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xE8EB98", Offset = "0xE8EB98", VA = "0xE8EB98", Slot = "7")]
	internal virtual void EndWriteFile()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xE8EBA8", Offset = "0xE8EBA8", VA = "0xE8EBA8", Slot = "8")]
	internal virtual void StartWriteObject(string name)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xE8EBB8", Offset = "0xE8EBB8", VA = "0xE8EBB8", Slot = "9")]
	internal virtual void EndWriteObject(string name)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xE8EBC8", Offset = "0xE8EBC8", VA = "0xE8EBC8", Slot = "10")]
	internal virtual void StartWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xE8EC90", Offset = "0xE8EC90", VA = "0xE8EC90", Slot = "11")]
	internal virtual void EndWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xE8EC94", Offset = "0xE8EC94", VA = "0xE8EC94", Slot = "12")]
	internal virtual void StartWriteCollection()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xE8ECA4", Offset = "0xE8ECA4", VA = "0xE8ECA4", Slot = "13")]
	internal virtual void EndWriteCollection()
	{
	}

	[Token(Token = "0x60001E7")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x60001E8")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x60001E9")]
	internal abstract void StartWriteDictionary();

	[Token(Token = "0x60001EA")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x60001EB")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x60001EC")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x60001ED")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x60001EE")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x60001EF")]
	public abstract void Dispose();

	[Token(Token = "0x60001F0")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x60001F1")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x60001F2")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x60001F3")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x60001F4")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x60001F5")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x60001F6")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x60001F7")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x60001F8")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x60001F9")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x60001FA")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x60001FB")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x60001FC")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x60001FD")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x60001FE")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x60001FF")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xE8ECB4", Offset = "0xE8ECB4", VA = "0xE8ECB4")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xE8ED88", Offset = "0xE8ED88", VA = "0xE8ED88", Slot = "39")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x6000202")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xE8EF04", Offset = "0xE8EF04", VA = "0xE8EF04", Slot = "41")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xE8F034", Offset = "0xE8F034", VA = "0xE8F034", Slot = "42")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xE8F0F4", Offset = "0xE8F0F4", VA = "0xE8F0F4", Slot = "43")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xE8FB30", Offset = "0xE8FB30", VA = "0xE8FB30", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xE8FC98", Offset = "0xE8FC98", VA = "0xE8FC98", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xE8FCC0", Offset = "0xE8FCC0", VA = "0xE8FCC0", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000209")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xE8FDF0", Offset = "0xE8FDF0", VA = "0xE8FDF0", Slot = "48")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xE8FE18", Offset = "0xE8FE18", VA = "0xE8FE18", Slot = "49")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xE8FEA4", Offset = "0xE8FEA4", VA = "0xE8FEA4", Slot = "50")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xE8FFB0", Offset = "0xE8FFB0", VA = "0xE8FFB0")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xE901B4", Offset = "0xE901B4", VA = "0xE901B4")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xE903B8", Offset = "0xE903B8", VA = "0xE903B8")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xE90574", Offset = "0xE90574", VA = "0xE90574")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xE90730", Offset = "0xE90730", VA = "0xE90730")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xE90930", Offset = "0xE90930", VA = "0xE90930")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xE8EE70", Offset = "0xE8EE70", VA = "0xE8EE70")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xE90B30", Offset = "0xE90B30", VA = "0xE90B30")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xE83270", Offset = "0xE83270", VA = "0xE83270")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xE86160", Offset = "0xE86160", VA = "0xE86160")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xE7FF40", Offset = "0xE7FF40", VA = "0xE7FF40")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xE8FD44", Offset = "0xE8FD44", VA = "0xE8FD44")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected bool SerializationDepthLimitExceeded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xE90BAC", Offset = "0xE90BAC", VA = "0xE90BAC", Slot = "51")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xE90C04", Offset = "0xE90C04", VA = "0xE90C04")]
	protected void Merge()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xE90D6C", Offset = "0xE90D6C", VA = "0xE90D6C")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xE910D4", Offset = "0xE910D4", VA = "0xE910D4", Slot = "52")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xE910E8", Offset = "0xE910E8", VA = "0xE910E8", Slot = "53")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200002B")]
public class ES3XMLWriter
{
	[Token(Token = "0x600021E")]
	[Address(RVA = "0xE911AC", Offset = "0xE911AC", VA = "0xE911AC")]
	public ES3XMLWriter()
	{
	}
}
namespace SuperPivot
{
	[Token(Token = "0x200002C")]
	public static class API
	{
		[Token(Token = "0x200002D")]
		public enum Space
		{
			[Token(Token = "0x40000B6")]
			Global,
			[Token(Token = "0x40000B7")]
			Local
		}

		[Token(Token = "0x200002E")]
		public enum CanChangePivotResult
		{
			[Token(Token = "0x40000B9")]
			Yes,
			[Token(Token = "0x40000BA")]
			No,
			[Token(Token = "0x40000BB")]
			NoButShowMoveButton
		}

		[Token(Token = "0x40000B4")]
		public const float Version = 2.3f;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE911B4", Offset = "0xE911B4", VA = "0xE911B4")]
		public static Vector3 GetPivotPosition(this Transform self, Space space = Space.Global)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE911D4", Offset = "0xE911D4", VA = "0xE911D4")]
		public static Quaternion GetPivotRotation(this Transform self, Space space = Space.Global)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE911F4", Offset = "0xE911F4", VA = "0xE911F4")]
		public static bool CanChangePivot(Transform target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE9146C", Offset = "0xE9146C", VA = "0xE9146C")]
		public static bool CanChangePivot(Transform target, out string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE91484", Offset = "0xE91484", VA = "0xE91484")]
		public static bool HasAtLeastOneTransformWithResult(Transform[] targets, params CanChangePivotResult[] validResults)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE91214", Offset = "0xE91214", VA = "0xE91214")]
		private static CanChangePivotResult CanChangePivotPrivate(Transform target, out string reason)
		{
			return default(CanChangePivotResult);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE91530", Offset = "0xE91530", VA = "0xE91530")]
		public static void SetPivotPosition(Transform target, Vector3 pos, Space space = Space.Global)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE91AB8", Offset = "0xE91AB8", VA = "0xE91AB8")]
		[Obsolete("Use 'SuperPivot.API.SetPivotPosition' instead")]
		public static void SetPivot(Transform target, Vector3 pos, Space space = Space.Global)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE91ABC", Offset = "0xE91ABC", VA = "0xE91ABC")]
		public static void SetPivotRotation(Transform target, Vector3 euler, Space space = Space.Global)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE91C40", Offset = "0xE91C40", VA = "0xE91C40")]
		public static void SetPivotRotation(Transform target, Quaternion quat, Space space = Space.Global)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE91600", Offset = "0xE91600", VA = "0xE91600")]
		private static Transform[] OnChangePivotBegin(Transform target, out Matrix4x4 oldToNewMatrix)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE91798", Offset = "0xE91798", VA = "0xE91798")]
		private static void OnChangePivotEnd(Transform target, Transform[] children, Matrix4x4 oldToNewMatrix)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE91778", Offset = "0xE91778", VA = "0xE91778")]
		private static void SetPositionPrivate(Transform target, Vector3 pos, Space space = Space.Global)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE91D14", Offset = "0xE91D14", VA = "0xE91D14")]
		private static void SetRotationPrivate(Transform target, Quaternion quat, Space space = Space.Global)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE91BB0", Offset = "0xE91BB0", VA = "0xE91BB0")]
		private static void SetRotationPrivate(Transform target, Vector3 euler, Space space = Space.Global)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ShowPivot : MonoBehaviour
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visible;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color color;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE91D34", Offset = "0xE91D34", VA = "0xE91D34")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE91DEC", Offset = "0xE91DEC", VA = "0xE91DEC")]
		public ShowPivot()
		{
		}
	}
}
namespace SuperPivot.Samples
{
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	public class MoveToParentPivotPosition : MonoBehaviour
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowRotation;

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE91E08", Offset = "0xE91E08", VA = "0xE91E08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE91F24", Offset = "0xE91F24", VA = "0xE91F24")]
		public MoveToParentPivotPosition()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class RotateAroundPivot : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE91F2C", Offset = "0xE91F2C", VA = "0xE91F2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE9202C", Offset = "0xE9202C", VA = "0xE9202C")]
		public RotateAroundPivot()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[RequireComponent(typeof(Collider))]
	public class SetPivotUnderMouseClick : MonoBehaviour
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE9203C", Offset = "0xE9203C", VA = "0xE9203C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE92210", Offset = "0xE92210", VA = "0xE92210")]
		public SetPivotUnderMouseClick()
		{
		}
	}
}
namespace ES3Types
{
	[Token(Token = "0x2000033")]
	[Preserve]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE92218", Offset = "0xE92218", VA = "0xE92218")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE9238C", Offset = "0xE9238C", VA = "0xE9238C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000238")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000034")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE92390", Offset = "0xE92390", VA = "0xE92390")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE92454", Offset = "0xE92454", VA = "0xE92454", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600023B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xE925D8", Offset = "0xE925D8", VA = "0xE925D8")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE926C8", Offset = "0xE926C8", VA = "0xE926C8", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x6000240")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE928E4", Offset = "0xE928E4", VA = "0xE928E4", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE92B38", Offset = "0xE92B38", VA = "0xE92B38", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xE92E1C", Offset = "0xE92E1C", VA = "0xE92E1C")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE92E20", Offset = "0xE92E20", VA = "0xE92E20", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000246")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE930CC", Offset = "0xE930CC", VA = "0xE930CC", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE933E0", Offset = "0xE933E0", VA = "0xE933E0", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000037")]
	[Preserve]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE9375C", Offset = "0xE9375C", VA = "0xE9375C")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE93760", Offset = "0xE93760", VA = "0xE93760")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE937D0", Offset = "0xE937D0", VA = "0xE937D0", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE9394C", Offset = "0xE9394C", VA = "0xE9394C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE93BA8", Offset = "0xE93BA8", VA = "0xE93BA8", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000038")]
	[Preserve]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type elementType;

		[Token(Token = "0x6000251")]
		public abstract object Read(ES3Reader reader);

		[Token(Token = "0x6000252")]
		public abstract void ReadInto(ES3Reader reader, object obj);

		[Token(Token = "0x6000253")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE925DC", Offset = "0xE925DC", VA = "0xE925DC")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE93798", Offset = "0xE93798", VA = "0xE93798")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE941EC", Offset = "0xE941EC", VA = "0xE941EC", Slot = "4")]
		[Preserve]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000257")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE941FC", Offset = "0xE941FC", VA = "0xE941FC", Slot = "12")]
		[Preserve]
		protected virtual void ReadICollectionInto(ES3Reader reader, ICollection collection, ES3Type elementType)
		{
		}
	}
	[Token(Token = "0x2000039")]
	[Preserve]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type keyType;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ES3Type valueType;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE94768", Offset = "0xE94768", VA = "0xE94768")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE9488C", Offset = "0xE9488C", VA = "0xE9488C")]
		public ES3DictionaryType(Type type, ES3Type keyType, ES3Type valueType)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE948E8", Offset = "0xE948E8", VA = "0xE948E8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE8F6E8", Offset = "0xE8F6E8", VA = "0xE8F6E8")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600025E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE94908", Offset = "0xE94908", VA = "0xE94908")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xE94B40", Offset = "0xE94B40", VA = "0xE94B40")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200003A")]
	[Preserve]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE94EA8", Offset = "0xE94EA8", VA = "0xE94EA8")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE94EAC", Offset = "0xE94EAC", VA = "0xE94EAC", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000264")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE95508", Offset = "0xE95508", VA = "0xE95508", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xE957D8", Offset = "0xE957D8", VA = "0xE957D8", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200003B")]
	[Preserve]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE95828", Offset = "0xE95828", VA = "0xE95828")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE9582C", Offset = "0xE9582C", VA = "0xE9582C")]
		public ES3ListType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE95864", Offset = "0xE95864", VA = "0xE95864", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600026B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xE95C94", Offset = "0xE95C94", VA = "0xE95C94", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xE95E74", Offset = "0xE95E74", VA = "0xE95E74", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200003C")]
	[Preserve]
	public class ES3NativeArrayType : ES3CollectionType
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xE9642C", Offset = "0xE9642C", VA = "0xE9642C")]
		public ES3NativeArrayType(Type type)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xE96430", Offset = "0xE96430", VA = "0xE96430")]
		public ES3NativeArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xE96468", Offset = "0xE96468", VA = "0xE96468", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE9685C", Offset = "0xE9685C", VA = "0xE9685C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE96C08", Offset = "0xE96C08", VA = "0xE96C08", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xE969AC", Offset = "0xE969AC", VA = "0xE969AC")]
		private Array ReadAsArray(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200003E")]
	[Preserve]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE96F20", Offset = "0xE96F20", VA = "0xE96F20")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE96F24", Offset = "0xE96F24", VA = "0xE96F24", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600027C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE97330", Offset = "0xE97330", VA = "0xE97330", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE97600", Offset = "0xE97600", VA = "0xE97600", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200003F")]
	[Preserve]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE97B94", Offset = "0xE97B94", VA = "0xE97B94")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE97B98", Offset = "0xE97B98", VA = "0xE97B98", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000282")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE97FA4", Offset = "0xE97FA4", VA = "0xE97FA4", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE983C8", Offset = "0xE983C8", VA = "0xE983C8", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000041")]
	[Preserve]
	public class ES3TupleType : ES3Type
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type[] es3Types;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Type[] types;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE989FC", Offset = "0xE989FC", VA = "0xE989FC")]
		public ES3TupleType(Type type)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE98BBC", Offset = "0xE98BBC", VA = "0xE98BBC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE98BDC", Offset = "0xE98BDC", VA = "0xE98BDC")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600028C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	[Preserve]
	public abstract class ES3ComponentType : ES3UnityObjectType
	{
		[Token(Token = "0x40000D0")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE98D94", Offset = "0xE98D94", VA = "0xE98D94")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x600028E")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x600028F")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE98DD4", Offset = "0xE98DD4", VA = "0xE98DD4", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000291")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000292")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE99050", Offset = "0xE99050", VA = "0xE99050")]
		private static UnityEngine.Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE990F4", Offset = "0xE990F4", VA = "0xE990F4")]
		public static UnityEngine.Component CreateComponent(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	[Preserve]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE991F0", Offset = "0xE991F0", VA = "0xE991F0")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x6000297")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000298")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x6000299")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE991F4", Offset = "0xE991F4", VA = "0xE991F4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600029B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000044")]
	[Preserve]
	public abstract class ES3ScriptableObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE994A0", Offset = "0xE994A0", VA = "0xE994A0")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x600029E")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x600029F")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE994C0", Offset = "0xE994C0", VA = "0xE994C0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002A1")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002A2")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000045")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Preserve]
	public abstract class ES3Type
	{
		[Token(Token = "0x40000D1")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTuple;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isEnum;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isReflectedType;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isUnsupported;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int priority;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE922CC", Offset = "0xE922CC", VA = "0xE922CC")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x60002A5")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x60002A6")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x60002A7")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE993A4", Offset = "0xE993A4", VA = "0xE993A4")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE99640", Offset = "0xE99640", VA = "0xE99640")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE9968C", Offset = "0xE9968C", VA = "0xE9968C")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE997CC", Offset = "0xE997CC", VA = "0xE997CC")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE997C0", Offset = "0xE997C0", VA = "0xE997C0")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE9B338", Offset = "0xE9B338", VA = "0xE9B338")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE9B4D8", Offset = "0xE9B4D8", VA = "0xE9B4D8")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x2000047")]
	[Preserve]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE98DB4", Offset = "0xE98DB4", VA = "0xE98DB4")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60002B1")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x60002B2")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60002B3")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE9B508", Offset = "0xE9B508", VA = "0xE9B508", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE9B51C", Offset = "0xE9B51C", VA = "0xE9B51C", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x60002B6")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002B7")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE9B784", Offset = "0xE9B784", VA = "0xE9B784")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000048")]
	[Preserve]
	[ES3Properties(new string[] { "bytes" })]
	public class ES3Type_BigInteger : ES3Type
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE9B8DC", Offset = "0xE9B8DC", VA = "0xE9B8DC")]
		public ES3Type_BigInteger()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE9B990", Offset = "0xE9B990", VA = "0xE9B990", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002BB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000049")]
	public class ES3Type_BigIntegerArray : ES3ArrayType
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE9BA74", Offset = "0xE9BA74", VA = "0xE9BA74")]
		public ES3Type_BigIntegerArray()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[Preserve]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE9BB60", Offset = "0xE9BB60", VA = "0xE9BB60")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE9BC1C", Offset = "0xE9BC1C", VA = "0xE9BC1C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002BF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004B")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xE9BCA4", Offset = "0xE9BCA4", VA = "0xE9BCA4")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[Preserve]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xE9BD90", Offset = "0xE9BD90", VA = "0xE9BD90")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xE9BE4C", Offset = "0xE9BE4C", VA = "0xE9BE4C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	[Preserve]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xE9BED4", Offset = "0xE9BED4", VA = "0xE9BED4")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xE9BF90", Offset = "0xE9BF90", VA = "0xE9BF90", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004E")]
	[Preserve]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xE9C018", Offset = "0xE9C018", VA = "0xE9C018")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xE9C0D4", Offset = "0xE9C0D4", VA = "0xE9C0D4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004F")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xE9C15C", Offset = "0xE9C15C", VA = "0xE9C15C")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[Preserve]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xE9C248", Offset = "0xE9C248", VA = "0xE9C248")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xE9C2FC", Offset = "0xE9C2FC", VA = "0xE9C2FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002CD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xE9C40C", Offset = "0xE9C40C", VA = "0xE9C40C")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[Preserve]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xE9C4F8", Offset = "0xE9C4F8", VA = "0xE9C4F8")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xE9C5B4", Offset = "0xE9C5B4", VA = "0xE9C5B4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000053")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xE9C63C", Offset = "0xE9C63C", VA = "0xE9C63C")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[Preserve]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xE9C728", Offset = "0xE9C728", VA = "0xE9C728")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xE9C7E4", Offset = "0xE9C7E4", VA = "0xE9C7E4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000055")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xE9C86C", Offset = "0xE9C86C", VA = "0xE9C86C")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[Preserve]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type underlyingType;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE9C958", Offset = "0xE9C958", VA = "0xE9C958")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xE9CA14", Offset = "0xE9CA14", VA = "0xE9CA14", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	[Preserve]
	public class ES3Type_ES3Ref : ES3Type
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xE9E490", Offset = "0xE9E490", VA = "0xE9E490")]
		public ES3Type_ES3Ref()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xE9E560", Offset = "0xE9E560", VA = "0xE9E560", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002DC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public class ES3Type_ES3RefArray : ES3ArrayType
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xE9E678", Offset = "0xE9E678", VA = "0xE9E678")]
		public ES3Type_ES3RefArray()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class ES3Type_ES3RefDictionary : ES3DictionaryType
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xE9E7E4", Offset = "0xE9E7E4", VA = "0xE9E7E4")]
		public ES3Type_ES3RefDictionary()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[Preserve]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xE9E954", Offset = "0xE9E954", VA = "0xE9E954")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xE9EA14", Offset = "0xE9EA14", VA = "0xE9EA14", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xE9EA9C", Offset = "0xE9EA9C", VA = "0xE9EA9C")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[Preserve]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xE9EB74", Offset = "0xE9EB74", VA = "0xE9EB74")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xE9EC34", Offset = "0xE9EC34", VA = "0xE9EC34", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005D")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xE9ECBC", Offset = "0xE9ECBC", VA = "0xE9ECBC")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[Preserve]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xE9ED94", Offset = "0xE9ED94", VA = "0xE9ED94")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xE9EE54", Offset = "0xE9EE54", VA = "0xE9EE54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002EC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xE9EEE8", Offset = "0xE9EEE8", VA = "0xE9EEE8")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[Preserve]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xE9EFC0", Offset = "0xE9EFC0", VA = "0xE9EFC0")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xE9F080", Offset = "0xE9F080", VA = "0xE9F080", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000061")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xE9F108", Offset = "0xE9F108", VA = "0xE9F108")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[Preserve]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xE9F1E0", Offset = "0xE9F1E0", VA = "0xE9F1E0")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xE9F2A0", Offset = "0xE9F2A0", VA = "0xE9F2A0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xE9F328", Offset = "0xE9F328", VA = "0xE9F328")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[Preserve]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xE9F400", Offset = "0xE9F400", VA = "0xE9F400")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xE9F4C0", Offset = "0xE9F4C0", VA = "0xE9F4C0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xE9F548", Offset = "0xE9F548", VA = "0xE9F548")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[Preserve]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xE9F620", Offset = "0xE9F620", VA = "0xE9F620")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xE9F6E0", Offset = "0xE9F6E0", VA = "0xE9F6E0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002FC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xE9F75C", Offset = "0xE9F75C", VA = "0xE9F75C")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[Preserve]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xE9F834", Offset = "0xE9F834", VA = "0xE9F834")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xE9F8F4", Offset = "0xE9F8F4", VA = "0xE9F8F4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000300")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xE9F97C", Offset = "0xE9F97C", VA = "0xE9F97C")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[Preserve]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xE9FA54", Offset = "0xE9FA54", VA = "0xE9FA54")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xE9FB14", Offset = "0xE9FB14", VA = "0xE9FB14", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000304")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xE9FB9C", Offset = "0xE9FB9C", VA = "0xE9FB9C")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[Preserve]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xE9FC74", Offset = "0xE9FC74", VA = "0xE9FC74")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xE9FD34", Offset = "0xE9FD34", VA = "0xE9FD34", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000308")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006D")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xE9FDBC", Offset = "0xE9FDBC", VA = "0xE9FDBC")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[Preserve]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xE9FE94", Offset = "0xE9FE94", VA = "0xE9FE94")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xE9FF54", Offset = "0xE9FF54", VA = "0xE9FF54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600030C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xE9FFDC", Offset = "0xE9FFDC", VA = "0xE9FFDC")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[Preserve]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xEA00B4", Offset = "0xEA00B4", VA = "0xEA00B4")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xEA00E0", Offset = "0xEA00E0", VA = "0xEA00E0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000310")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000071")]
	[Preserve]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000311")]
		[Address(RVA = "0xEA00E8", Offset = "0xEA00E8", VA = "0xEA00E8")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xEA0114", Offset = "0xEA0114", VA = "0xEA0114", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000313")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000072")]
	[Preserve]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x6000315")]
		[Address(RVA = "0xEA011C", Offset = "0xEA011C", VA = "0xEA011C")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xEA0148", Offset = "0xEA0148", VA = "0xEA0148", Slot = "14")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000317")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000073")]
	[Preserve]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0xEA0150", Offset = "0xEA0150", VA = "0xEA0150")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xEA0170", Offset = "0xEA0170", VA = "0xEA0170")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xEA01AC", Offset = "0xEA01AC", VA = "0xEA01AC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600031B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000074")]
	[Preserve]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xEA0530", Offset = "0xEA0530", VA = "0xEA0530")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xEA055C", Offset = "0xEA055C", VA = "0xEA055C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600031F")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000075")]
	[Preserve]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0xEA0564", Offset = "0xEA0564", VA = "0xEA0564")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xEA0590", Offset = "0xEA0590", VA = "0xEA0590", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000323")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000076")]
	[ES3Properties(new string[] { "center", "size", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	[Preserve]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xEA0598", Offset = "0xEA0598", VA = "0xEA0598")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xEA0650", Offset = "0xEA0650", VA = "0xEA0650", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000327")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000077")]
	[Preserve]
	[ES3Properties(new string[] { "size", "density", "isTrigger", "usedByEffector", "offset", "sharedMaterial", "enabled" })]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xEA0908", Offset = "0xEA0908", VA = "0xEA0908")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xEA09C0", Offset = "0xEA09C0", VA = "0xEA09C0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000078")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"fieldOfView", "nearClipPlane", "farClipPlane", "renderingPath", "allowHDR", "orthographicSize", "orthographic", "opaqueSortMode", "transparencySortMode", "depth",
		"aspect", "cullingMask", "eventMask", "backgroundColor", "rect", "pixelRect", "worldToCameraMatrix", "projectionMatrix", "nonJitteredProjectionMatrix", "useJitteredProjectionMatrixForTransparentRendering",
		"clearFlags", "stereoSeparation", "stereoConvergence", "cameraType", "stereoTargetEye", "targetDisplay", "useOcclusionCulling", "cullingMatrix", "layerCullSpherical", "depthTextureMode",
		"clearStencilAfterLightingPass", "enabled", "hideFlags"
	})]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xEA0D08", Offset = "0xEA0D08", VA = "0xEA0D08")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xEA0DC0", Offset = "0xEA0DC0", VA = "0xEA0DC0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000079")]
	[Preserve]
	[ES3Properties(new string[] { "center", "radius", "height", "direction", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xEA195C", Offset = "0xEA195C", VA = "0xEA195C")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xEA1A14", Offset = "0xEA1A14", VA = "0xEA1A14", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000330")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007A")]
	[Preserve]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xEA1E1C", Offset = "0xEA1E1C", VA = "0xEA1E1C")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xEA1ED4", Offset = "0xEA1ED4", VA = "0xEA1ED4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000333")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007B")]
	[ES3Properties(new string[]
	{
		"sprite", "overrideSprite", "type", "preserveAspect", "fillCenter", "fillMethod", "fillAmount", "fillClockwise", "fillOrigin", "alphaHitTestMinimumThreshold",
		"useSpriteMesh", "pixelsPerUnitMultiplier", "material", "onCullStateChanged", "maskable", "color", "raycastTarget", "useLegacyMeshGeneration", "useGUILayout", "enabled",
		"hideFlags"
	})]
	[Preserve]
	public class ES3Type_Image : ES3ComponentType
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xEA1ED8", Offset = "0xEA1ED8", VA = "0xEA1ED8")]
		public ES3Type_Image()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xEA1F9C", Offset = "0xEA1F9C", VA = "0xEA1F9C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000336")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class ES3Type_ImageArray : ES3ArrayType
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xEA278C", Offset = "0xEA278C", VA = "0xEA278C")]
		public ES3Type_ImageArray()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[ES3Properties(new string[] { "sharedMesh", "convex", "inflateMesh", "skinWidth", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	[Preserve]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xEA2864", Offset = "0xEA2864", VA = "0xEA2864")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xEA291C", Offset = "0xEA291C", VA = "0xEA291C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600033A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xEA2C08", Offset = "0xEA2C08", VA = "0xEA2C08")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[Preserve]
	[ES3Properties(new string[] { "sharedMesh" })]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xEA2CE0", Offset = "0xEA2CE0", VA = "0xEA2CE0")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xEA2D98", Offset = "0xEA2D98", VA = "0xEA2D98", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600033E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xEA2E34", Offset = "0xEA2E34", VA = "0xEA2E34")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"additionalVertexStreams", "enabled", "shadowCastingMode", "receiveShadows", "sharedMaterials", "lightmapIndex", "realtimeLightmapIndex", "lightmapScaleOffset", "motionVectorGenerationMode", "realtimeLightmapScaleOffset",
		"lightProbeUsage", "lightProbeProxyVolumeOverride", "probeAnchor", "reflectionProbeUsage", "sortingLayerName", "sortingLayerID", "sortingOrder"
	})]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xEA2F0C", Offset = "0xEA2F0C", VA = "0xEA2F0C")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xEA2FC4", Offset = "0xEA2FC4", VA = "0xEA2FC4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000342")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xEA3710", Offset = "0xEA3710", VA = "0xEA3710")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[ES3Properties(new string[]
	{
		"time", "hideFlags", "collision", "colorBySpeed", "colorOverLifetime", "emission", "externalForces", "forceOverLifetime", "inheritVelocity", "lights",
		"limitVelocityOverLifetime", "main", "noise", "rotatonBySpeed", "rotationOverLifetime", "shape", "sizeBySpeed", "sizeOverLifetime", "subEmitters", "textureSheetAnimation",
		"trails", "trigger", "useAutoRandomSeed", "velocityOverLifetime", "isPaused", "isPlaying", "isStopped"
	})]
	[Preserve]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xEA37E8", Offset = "0xEA37E8", VA = "0xEA37E8")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xEA38A0", Offset = "0xEA38A0", VA = "0xEA38A0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000346")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000084")]
	[ES3Properties(new string[] { "points", "pathCount", "paths", "density", "isTrigger", "usedByEffector", "offset", "sharedMaterial", "enabled" })]
	[Preserve]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xEA4390", Offset = "0xEA4390", VA = "0xEA4390")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xEA4448", Offset = "0xEA4448", VA = "0xEA4448", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000349")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xEA4950", Offset = "0xEA4950", VA = "0xEA4950")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[ES3Properties(new string[]
	{
		"texture", "uvRect", "onCullStateChanged", "maskable", "color", "raycastTarget", "useLegacyMeshGeneration", "material", "useGUILayout", "enabled",
		"hideFlags"
	})]
	[Preserve]
	public class ES3Type_RawImage : ES3ComponentType
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xEA4A28", Offset = "0xEA4A28", VA = "0xEA4A28")]
		public ES3Type_RawImage()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xEA4AEC", Offset = "0xEA4AEC", VA = "0xEA4AEC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600034D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class ES3Type_RawImageArray : ES3ArrayType
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xEA4FC8", Offset = "0xEA4FC8", VA = "0xEA4FC8")]
		public ES3Type_RawImageArray()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[ES3Properties(new string[]
	{
		"velocity", "angularVelocity", "drag", "angularDrag", "mass", "useGravity", "maxDepenetrationVelocity", "isKinematic", "freezeRotation", "constraints",
		"collisionDetectionMode", "centerOfMass", "inertiaTensorRotation", "inertiaTensor", "detectCollisions", "position", "rotation", "interpolation", "solverIterations", "sleepThreshold",
		"maxAngularVelocity", "solverVelocityIterations"
	})]
	[Preserve]
	public class ES3Type_Rigidbody : ES3ComponentType
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xEA50A0", Offset = "0xEA50A0", VA = "0xEA50A0")]
		public ES3Type_Rigidbody()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xEA5164", Offset = "0xEA5164", VA = "0xEA5164", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000351")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class ES3UserType_RigidbodyArray : ES3ArrayType
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xEA5A1C", Offset = "0xEA5A1C", VA = "0xEA5A1C")]
		public ES3UserType_RigidbodyArray()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[ES3Properties(new string[] { "center", "radius", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	[Preserve]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xEA5AF4", Offset = "0xEA5AF4", VA = "0xEA5AF4")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xEA5BAC", Offset = "0xEA5BAC", VA = "0xEA5BAC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000355")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008B")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"font", "text", "supportRichText", "resizeTextForBestFit", "resizeTextMinSize", "resizeTextMaxSize", "alignment", "alignByGeometry", "fontSize", "horizontalOverflow",
		"verticalOverflow", "lineSpacing", "fontStyle", "onCullStateChanged", "maskable", "color", "raycastTarget", "material", "useGUILayout", "enabled",
		"tag", "name", "hideFlags"
	})]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xEA5ED8", Offset = "0xEA5ED8", VA = "0xEA5ED8")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xEA5F90", Offset = "0xEA5F90", VA = "0xEA5F90", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000358")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008C")]
	[Preserve]
	[ES3Properties(new string[] { "localPosition", "localRotation", "localScale", "parent", "siblingIndex" })]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int countRead;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ES3Type Instance;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xEA676C", Offset = "0xEA676C", VA = "0xEA676C")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xEA681C", Offset = "0xEA681C", VA = "0xEA681C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600035B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008D")]
	[Preserve]
	[ES3Properties(new string[] { "keys", "preWrapMode", "postWrapMode" })]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xEA6A78", Offset = "0xEA6A78", VA = "0xEA6A78")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xEA6B30", Offset = "0xEA6B30", VA = "0xEA6B30", Slot = "4")]
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
	[Token(Token = "0x200008E")]
	[Preserve]
	[ES3Properties(new string[] { "name", "samples", "channels", "frequency", "sampleData" })]
	public class ES3Type_AudioClip : ES3UnityObjectType
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xEA6CD4", Offset = "0xEA6CD4", VA = "0xEA6CD4")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xEA6D8C", Offset = "0xEA6D8C", VA = "0xEA6D8C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000362")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000363")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200008F")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xEA6FDC", Offset = "0xEA6FDC", VA = "0xEA6FDC")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[Preserve]
	[ES3Properties(new string[] { "boneIndex0", "boneIndex1", "boneIndex2", "boneIndex3", "weight0", "weight1", "weight2", "weight3" })]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xEA70B4", Offset = "0xEA70B4", VA = "0xEA70B4")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xEA716C", Offset = "0xEA716C", VA = "0xEA716C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000367")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000091")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xEA753C", Offset = "0xEA753C", VA = "0xEA753C")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[ES3Properties(new string[] { "center", "size" })]
	[Preserve]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xEA7614", Offset = "0xEA7614", VA = "0xEA7614")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xEA76CC", Offset = "0xEA76CC", VA = "0xEA76CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600036B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xEA784C", Offset = "0xEA784C", VA = "0xEA784C")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[ES3Properties(new string[] { "time", "count", "minCount", "maxCount", "cycleCount", "repeatInterval", "probability" })]
	[Preserve]
	public class ES3Type_Burst : ES3Type
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xEA7924", Offset = "0xEA7924", VA = "0xEA7924")]
		public ES3Type_Burst()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xEA79E8", Offset = "0xEA79E8", VA = "0xEA79E8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600036F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	public class ES3Type_BurstArray : ES3ArrayType
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xEA7DD4", Offset = "0xEA7DD4", VA = "0xEA7DD4")]
		public ES3Type_BurstArray()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[ES3Properties(new string[]
	{
		"enabled", "type", "mode", "dampen", "dampenMultiplier", "bounce", "bounceMultiplier", "lifetimeLoss", "lifetimeLossMultiplier", "minKillSpeed",
		"maxKillSpeed", "collidesWith", "enableDynamicColliders", "maxCollisionShapes", "quality", "voxelSize", "radiusScale", "sendCollisionMessages"
	})]
	[Preserve]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xEA7EAC", Offset = "0xEA7EAC", VA = "0xEA7EAC")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xEA7F64", Offset = "0xEA7F64", VA = "0xEA7F64", Slot = "4")]
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
	[Token(Token = "0x2000097")]
	[ES3Properties(new string[] { "r", "g", "b", "a" })]
	[Preserve]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xEA866C", Offset = "0xEA866C", VA = "0xEA866C")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xEA8724", Offset = "0xEA8724", VA = "0xEA8724", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000377")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xEA891C", Offset = "0xEA891C", VA = "0xEA891C")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[ES3Properties(new string[] { "r", "g", "b", "a" })]
	[Preserve]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xEA89F4", Offset = "0xEA89F4", VA = "0xEA89F4")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xEA8AAC", Offset = "0xEA8AAC", VA = "0xEA8AAC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600037B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xEA8CAC", Offset = "0xEA8CAC", VA = "0xEA8CAC")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009A")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xEA8CD0", Offset = "0xEA8CD0", VA = "0xEA8CD0")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "color", "range" })]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xEA8DA8", Offset = "0xEA8DA8", VA = "0xEA8DA8")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xEA8E60", Offset = "0xEA8E60", VA = "0xEA8E60", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000380")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009C")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "color" })]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xEA90A8", Offset = "0xEA90A8", VA = "0xEA90A8")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xEA9160", Offset = "0xEA9160", VA = "0xEA9160", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000384")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009D")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "rateOverTime", "rateOverTimeMultiplier", "rateOverDistance", "rateOverDistanceMultiplier" })]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xEA9320", Offset = "0xEA9320", VA = "0xEA9320")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xEA93D8", Offset = "0xEA93D8", VA = "0xEA93D8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000388")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009E")]
	[ES3Properties(new string[] { "enabled", "multiplier" })]
	[Preserve]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xEA9770", Offset = "0xEA9770", VA = "0xEA9770")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xEA9828", Offset = "0xEA9828", VA = "0xEA9828", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600038C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009F")]
	[ES3Properties(new string[] { "hideFlags" })]
	[Preserve]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xEA99C4", Offset = "0xEA99C4", VA = "0xEA99C4")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xEA9A7C", Offset = "0xEA9A7C", VA = "0xEA9A7C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000390")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xEA9B50", Offset = "0xEA9B50", VA = "0xEA9B50")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[ES3Properties(new string[] { "material", "name" })]
	[Preserve]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xEA9C28", Offset = "0xEA9C28", VA = "0xEA9C28")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xEA9CE0", Offset = "0xEA9CE0", VA = "0xEA9CE0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000395")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000396")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A2")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xEA9DDC", Offset = "0xEA9DDC", VA = "0xEA9DDC")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[ES3Properties(new string[] { "enabled", "x", "y", "z", "xMultiplier", "yMultiplier", "zMultiplier", "space", "randomized" })]
	[Preserve]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xEA9EB4", Offset = "0xEA9EB4", VA = "0xEA9EB4")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xEA9F6C", Offset = "0xEA9F6C", VA = "0xEA9F6C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600039A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[Preserve]
	[ES3Properties(new string[] { "layer", "isStatic", "tag", "name", "hideFlags", "children", "components" })]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x4000137")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x4000138")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool saveChildren;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xEAA3F8", Offset = "0xEAA3F8", VA = "0xEAA3F8")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xEAA4B0", Offset = "0xEAA4B0", VA = "0xEAA4B0", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x600039E")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xEAB3B8", Offset = "0xEAB3B8", VA = "0xEAB3B8")]
		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xEABBA0", Offset = "0xEABBA0", VA = "0xEABBA0")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xEAB014", Offset = "0xEAB014", VA = "0xEAB014")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xEABC2C", Offset = "0xEABC2C", VA = "0xEABC2C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A4")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003A5")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A6")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xEABCB0", Offset = "0xEABCB0", VA = "0xEABCB0")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[Preserve]
	[ES3Properties(new string[] { "colorKeys", "alphaKeys", "mode" })]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xEABD88", Offset = "0xEABD88", VA = "0xEABD88")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xEABE40", Offset = "0xEABE40", VA = "0xEABE40", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[ES3Properties(new string[] { "alpha", "time" })]
	[Preserve]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xEABFF0", Offset = "0xEABFF0", VA = "0xEABFF0")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xEAC0A8", Offset = "0xEAC0A8", VA = "0xEAC0A8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xEAC1F4", Offset = "0xEAC1F4", VA = "0xEAC1F4")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[Preserve]
	[ES3Properties(new string[] { "color", "time" })]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xEAC2CC", Offset = "0xEAC2CC", VA = "0xEAC2CC")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xEAC384", Offset = "0xEAC384", VA = "0xEAC384", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AB")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xEAC4FC", Offset = "0xEAC4FC", VA = "0xEAC4FC")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[Preserve]
	[ES3Properties(new string[] { "value" })]
	public class ES3Type_Guid : ES3Type
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xEAC5D4", Offset = "0xEAC5D4", VA = "0xEAC5D4")]
		public ES3Type_Guid()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xEAC68C", Offset = "0xEAC68C", VA = "0xEAC68C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AD")]
	public class ES3Type_GuidArray : ES3ArrayType
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xEAC770", Offset = "0xEAC770", VA = "0xEAC770")]
		public ES3Type_GuidArray()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "mode", "curve", "curveMultiplier" })]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xEAC848", Offset = "0xEAC848", VA = "0xEAC848")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xEAC900", Offset = "0xEAC900", VA = "0xEAC900", Slot = "4")]
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
	[Token(Token = "0x20000AF")]
	[Preserve]
	[ES3Properties(new string[] { "time", "value", "inTangent", "outTangent" })]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xEACB9C", Offset = "0xEACB9C", VA = "0xEACB9C")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xEACC54", Offset = "0xEACC54", VA = "0xEACC54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003BF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xEACE88", Offset = "0xEACE88", VA = "0xEACE88")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[Preserve]
	[ES3Properties(new string[] { "colorKeys", "alphaKeys", "mode" })]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xEACF60", Offset = "0xEACF60", VA = "0xEACF60")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xEAD018", Offset = "0xEAD018", VA = "0xEAD018", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B2")]
	[ES3Properties(new string[]
	{
		"type", "color", "intensity", "bounceIntensity", "shadows", "shadowStrength", "shadowResolution", "shadowCustomResolution", "shadowBias", "shadowNormalBias",
		"shadowNearPlane", "range", "spotAngle", "cookieSize", "cookie", "flare", "renderMode", "cullingMask", "areaSize", "lightmappingMode",
		"enabled", "hideFlags"
	})]
	[Preserve]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xEAD128", Offset = "0xEAD128", VA = "0xEAD128")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xEAD1E0", Offset = "0xEAD1E0", VA = "0xEAD1E0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C6")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "ratio", "useRandomDistribution", "light", "useParticleColor", "sizeAffectsRange", "alphaAffectsIntensity", "range", "rangeMultiplier", "intensity",
		"intensityMultiplier", "maxLights"
	})]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xEADA34", Offset = "0xEADA34", VA = "0xEADA34")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xEADAEC", Offset = "0xEADAEC", VA = "0xEADAEC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "limitX", "limitXMultiplier", "limitY", "limitYMultiplier", "limitZ", "limitZMultiplier", "limit", "limitMultiplier", "dampen",
		"separateAxes", "space"
	})]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xEAE080", Offset = "0xEAE080", VA = "0xEAE080")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xEAE138", Offset = "0xEAE138", VA = "0xEAE138", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003CD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[ES3Properties(new string[]
	{
		"duration", "loop", "prewarm", "startDelay", "startDelayMultiplier", "startLifetime", "startLifetimeMultiplier", "startSpeed", "startSpeedMultiplier", "startSize3D",
		"startSize", "startSizeMultiplier", "startSizeX", "startSizeXMultiplier", "startSizeY", "startSizeYMultiplier", "startSizeZ", "startSizeZMultiplier", "startRotation3D", "startRotation",
		"startRotationMultiplier", "startRotationX", "startRotationXMultiplier", "startRotationY", "startRotationYMultiplier", "startRotationZ", "startRotationZMultiplier", "randomizeRotationDirection", "startColor", "gravityModifier",
		"gravityModifierMultiplier", "simulationSpace", "customSimulationSpace", "simulationSpeed", "scalingMode", "playOnAwake", "maxParticles"
	})]
	[Preserve]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xEAE6D8", Offset = "0xEAE6D8", VA = "0xEAE6D8")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xEAE790", Offset = "0xEAE790", VA = "0xEAE790", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[Preserve]
	[ES3Properties(new string[] { "shader", "renderQueue", "shaderKeywords", "globalIlluminationFlags", "properties" })]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xEAF69C", Offset = "0xEAF69C", VA = "0xEAF69C")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xEAF754", Offset = "0xEAF754", VA = "0xEAF754", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D5")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xEAFC10", Offset = "0xEAFC10", VA = "0xEAFC10")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[Preserve]
	[ES3Properties(new string[] { "col0", "col1", "col2", "col3" })]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xEAFCE8", Offset = "0xEAFCE8", VA = "0xEAFCE8")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xEAFDA0", Offset = "0xEAFDA0", VA = "0xEAFDA0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B9")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xEAFFF4", Offset = "0xEAFFF4", VA = "0xEAFFF4")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"bounds", "subMeshCount", "boneWeights", "bindposes", "vertices", "normals", "tangents", "uv", "uv2", "uv3",
		"uv4", "colors32", "triangles", "subMeshes"
	})]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xEB00CC", Offset = "0xEB00CC", VA = "0xEB00CC")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xEB0184", Offset = "0xEB0184", VA = "0xEB0184", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DE")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[Preserve]
	[ES3Properties(new string[] { "mode", "curveMultiplier", "curveMax", "curveMin", "constantMax", "constantMin", "constant", "curve" })]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xEB0D80", Offset = "0xEB0D80", VA = "0xEB0D80")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xEB0E38", Offset = "0xEB0E38", VA = "0xEB0E38", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E2")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[Preserve]
	[ES3Properties(new string[] { "mode", "gradientMax", "gradientMin", "colorMax", "colorMin", "color", "gradient" })]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xEB11C0", Offset = "0xEB11C0", VA = "0xEB11C0")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xEB1278", Offset = "0xEB1278", VA = "0xEB1278", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BD")]
	[ES3Properties(new string[]
	{
		"enabled", "separateAxes", "strength", "strengthMultiplier", "strengthX", "strengthXMultiplier", "strengthY", "strengthYMultiplier", "strengthZ", "strengthZMultiplier",
		"frequency", "damping", "octaveCount", "octaveMultiplier", "octaveScale", "quality", "scrollSpeed", "scrollSpeedMultiplier", "remapEnabled", "remap",
		"remapMultiplier", "remapX", "remapXMultiplier", "remapY", "remapYMultiplier", "remapZ", "remapZMultiplier"
	})]
	[Preserve]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xEB15CC", Offset = "0xEB15CC", VA = "0xEB15CC")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xEB1684", Offset = "0xEB1684", VA = "0xEB1684", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[ES3Properties(new string[] { "dynamicFriction", "staticFriction", "bounciness", "frictionCombine", "bounceCombine" })]
	[Preserve]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xEB21C0", Offset = "0xEB21C0", VA = "0xEB21C0")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xEB2278", Offset = "0xEB2278", VA = "0xEB2278", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003ED")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003EE")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BF")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xEB2500", Offset = "0xEB2500", VA = "0xEB2500")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[Preserve]
	[ES3Properties(new string[] { "bounciness", "friction" })]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xEB25D8", Offset = "0xEB25D8", VA = "0xEB25D8")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xEB2690", Offset = "0xEB2690", VA = "0xEB2690", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F2")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003F3")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xEB27E0", Offset = "0xEB27E0", VA = "0xEB27E0")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "z", "w" })]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xEB28B8", Offset = "0xEB28B8", VA = "0xEB28B8")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xEB2970", Offset = "0xEB2970", VA = "0xEB2970", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C3")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xEB2B68", Offset = "0xEB2B68", VA = "0xEB2B68")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "width", "height" })]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xEB2C40", Offset = "0xEB2C40", VA = "0xEB2C40")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xEB2CF8", Offset = "0xEB2CF8", VA = "0xEB2CF8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C5")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"anchorMin", "anchorMax", "anchoredPosition", "sizeDelta", "pivot", "offsetMin", "offsetMax", "localPosition", "localRotation", "localScale",
		"parent", "hideFlags"
	})]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xEB2F1C", Offset = "0xEB2F1C", VA = "0xEB2F1C")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xEB2FD4", Offset = "0xEB2FD4", VA = "0xEB2FD4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FE")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"width", "height", "dimension", "graphicsFormat", "useMipMap", "vrUsage", "memorylessMode", "format", "stencilFormat", "autoGenerateMips",
		"volumeDepth", "antiAliasing", "bindTextureMS", "enableRandomWrite", "useDynamicScale", "isPowerOfTwo", "depth", "descriptor", "masterTextureLimit", "anisotropicFiltering",
		"wrapMode", "wrapModeU", "wrapModeV", "wrapModeW", "filterMode", "anisoLevel", "mipMapBias", "imageContentsHash", "streamingTextureForceLoadAll", "streamingTextureDiscardUnusedMips",
		"allowThreadedTextureCreation", "name"
	})]
	public class ES3Type_RenderTexture : ES3ObjectType
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xEB34F8", Offset = "0xEB34F8", VA = "0xEB34F8")]
		public ES3Type_RenderTexture()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEB35B0", Offset = "0xEB35B0", VA = "0xEB35B0", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000401")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000402")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C7")]
	public class ES3Type_RenderTextureArray : ES3ArrayType
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xEB3C7C", Offset = "0xEB3C7C", VA = "0xEB3C7C")]
		public ES3Type_RenderTextureArray()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes", "range" })]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xEB3D54", Offset = "0xEB3D54", VA = "0xEB3D54")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xEB3E0C", Offset = "0xEB3E0C", VA = "0xEB3E0C", Slot = "4")]
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
	[Token(Token = "0x20000C9")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes" })]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xEB42A4", Offset = "0xEB42A4", VA = "0xEB42A4")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xEB435C", Offset = "0xEB435C", VA = "0xEB435C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600040A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[Preserve]
	[ES3Properties(new string[] { "name", "maximumLOD" })]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xEB4784", Offset = "0xEB4784", VA = "0xEB4784")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xEB483C", Offset = "0xEB483C", VA = "0xEB483C", Slot = "4")]
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
	[Token(Token = "0x20000CB")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xEB4994", Offset = "0xEB4994", VA = "0xEB4994")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "shapeType", "randomDirectionAmount", "sphericalDirectionAmount", "alignToDirection", "radius", "angle", "length", "box", "meshShapeType",
		"mesh", "meshRenderer", "skinnedMeshRenderer", "useMeshMaterialIndex", "meshMaterialIndex", "useMeshColors", "normalOffset", "meshScale", "arc"
	})]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xEB4A6C", Offset = "0xEB4A6C", VA = "0xEB4A6C")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xEB4B24", Offset = "0xEB4B24", VA = "0xEB4B24", Slot = "4")]
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
	[Token(Token = "0x20000CD")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "size", "sizeMultiplier", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes",
		"range"
	})]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xEB528C", Offset = "0xEB528C", VA = "0xEB528C")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xEB5344", Offset = "0xEB5344", VA = "0xEB5344", Slot = "4")]
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
	[Token(Token = "0x20000CE")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "size", "sizeMultiplier", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes" })]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xEB58A0", Offset = "0xEB58A0", VA = "0xEB58A0")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xEB5958", Offset = "0xEB5958", VA = "0xEB5958", Slot = "4")]
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
	[Token(Token = "0x20000CF")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"bones", "rootBone", "quality", "sharedMesh", "updateWhenOffscreen", "skinnedMotionVectors", "localBounds", "enabled", "shadowCastingMode", "receiveShadows",
		"sharedMaterials", "lightmapIndex", "realtimeLightmapIndex", "lightmapScaleOffset", "motionVectorGenerationMode", "realtimeLightmapScaleOffset", "lightProbeUsage", "lightProbeProxyVolumeOverride", "probeAnchor", "reflectionProbeUsage",
		"sortingLayerName", "sortingLayerID", "sortingOrder"
	})]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xEB5E44", Offset = "0xEB5E44", VA = "0xEB5E44")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xEB5EFC", Offset = "0xEB5EFC", VA = "0xEB5EFC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600041F")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xEB693C", Offset = "0xEB693C", VA = "0xEB693C")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[Preserve]
	[ES3Properties(new string[] { "texture", "rect", "pivot", "pixelsPerUnit", "border" })]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xEB6A14", Offset = "0xEB6A14", VA = "0xEB6A14")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xEB6ACC", Offset = "0xEB6ACC", VA = "0xEB6ACC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000423")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000424")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D2")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"sprite", "color", "flipX", "flipY", "enabled", "shadowCastingMode", "receiveShadows", "sharedMaterials", "lightmapIndex", "realtimeLightmapIndex",
		"lightmapScaleOffset", "motionVectorGenerationMode", "realtimeLightmapScaleOffset", "lightProbeUsage", "lightProbeProxyVolumeOverride", "probeAnchor", "reflectionProbeUsage", "sortingLayerName", "sortingLayerID", "sortingOrder"
	})]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xEB6E28", Offset = "0xEB6E28", VA = "0xEB6E28")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xEB6EE0", Offset = "0xEB6EE0", VA = "0xEB6EE0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000427")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xEB7730", Offset = "0xEB7730", VA = "0xEB7730")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[Preserve]
	[ES3Properties(new string[] { "properties", "systems", "types" })]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xEB7808", Offset = "0xEB7808", VA = "0xEB7808")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xEB78C0", Offset = "0xEB78C0", VA = "0xEB78C0", Slot = "4")]
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
	[Token(Token = "0x20000D5")]
	[Preserve]
	[ES3Properties(new string[] { "filterMode", "anisoLevel", "wrapMode", "mipMapBias", "rawTextureData" })]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xEB7B74", Offset = "0xEB7B74", VA = "0xEB7B74")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xEB7C2C", Offset = "0xEB7C2C", VA = "0xEB7C2C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600042F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000430")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D6")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xEB7DC0", Offset = "0xEB7DC0", VA = "0xEB7DC0")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[Preserve]
	[ES3Properties(new string[] { "filterMode", "anisoLevel", "wrapMode", "mipMapBias", "rawTextureData" })]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xEB7E98", Offset = "0xEB7E98", VA = "0xEB7E98")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xEB7F50", Offset = "0xEB7F50", VA = "0xEB7F50", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000434")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000435")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xEB83D8", Offset = "0xEB83D8", VA = "0xEB83D8")]
		protected bool IsReadable(Texture2D instance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D8")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xEB8460", Offset = "0xEB8460", VA = "0xEB8460")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[ES3Properties(new string[]
	{
		"enabled", "numTilesX", "numTilesY", "animation", "useRandomRow", "frameOverTime", "frameOverTimeMultiplier", "startFrame", "startFrameMultiplier", "cycleCount",
		"rowIndex", "uvChannelMask", "flipU", "flipV"
	})]
	[Preserve]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xEB8538", Offset = "0xEB8538", VA = "0xEB8538")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xEB85F0", Offset = "0xEB85F0", VA = "0xEB85F0", Slot = "4")]
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
	[Token(Token = "0x20000DA")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "ratio", "lifetime", "lifetimeMultiplier", "minVertexDistance", "textureMode", "worldSpace", "dieWithParticles", "sizeAffectsWidth", "sizeAffectsLifetime",
		"inheritParticleColor", "colorOverLifetime", "widthOverTrail", "widthOverTrailMultiplier", "colorOverTrail"
	})]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xEB8BB0", Offset = "0xEB8BB0", VA = "0xEB8BB0")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xEB8C68", Offset = "0xEB8C68", VA = "0xEB8C68", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600043E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "inside", "outside", "enter", "exit", "radiusScale" })]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xEB9378", Offset = "0xEB9378", VA = "0xEB9378")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xEB9430", Offset = "0xEB9430", VA = "0xEB9430", Slot = "4")]
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
	[Token(Token = "0x20000DC")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y" })]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xEB9730", Offset = "0xEB9730", VA = "0xEB9730")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xEB97E8", Offset = "0xEB97E8", VA = "0xEB97E8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000446")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DD")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xEB9934", Offset = "0xEB9934", VA = "0xEB9934")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[ES3Properties(new string[] { "x", "y" })]
	[Preserve]
	public class ES3Type_Vector2Int : ES3Type
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xEB9A0C", Offset = "0xEB9A0C", VA = "0xEB9A0C")]
		public ES3Type_Vector2Int()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xEB9AC4", Offset = "0xEB9AC4", VA = "0xEB9AC4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600044A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DF")]
	public class ES3Type_Vector2IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xEB9C14", Offset = "0xEB9C14", VA = "0xEB9C14")]
		public ES3Type_Vector2IntArray()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "z" })]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xEB9CEC", Offset = "0xEB9CEC", VA = "0xEB9CEC")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xEB9DA4", Offset = "0xEB9DA4", VA = "0xEB9DA4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600044E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E1")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xEB9F48", Offset = "0xEB9F48", VA = "0xEB9F48")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "z" })]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xEBA020", Offset = "0xEBA020", VA = "0xEBA020")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xEBA0D8", Offset = "0xEBA0D8", VA = "0xEBA0D8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000452")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E3")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xEBA27C", Offset = "0xEBA27C", VA = "0xEBA27C")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "z", "w" })]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xEBA354", Offset = "0xEBA354", VA = "0xEBA354")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xEBA40C", Offset = "0xEBA40C", VA = "0xEBA40C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000456")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xEBA604", Offset = "0xEBA604", VA = "0xEBA604")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E5")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xEBA73C", Offset = "0xEBA73C", VA = "0xEBA73C")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[ES3Properties(new string[] { "enabled", "x", "y", "z", "xMultiplier", "yMultiplier", "zMultiplier", "space" })]
	[Preserve]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xEBA814", Offset = "0xEBA814", VA = "0xEBA814")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xEBA8CC", Offset = "0xEBA8CC", VA = "0xEBA8CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600045B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x20000E7")]
	internal static class ES3Debug
	{
		[Token(Token = "0x400017E")]
		private const string disableInfoMsg = "\n<i>To disable these messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Info'</i>";

		[Token(Token = "0x400017F")]
		private const string disableWarningMsg = "\n<i>To disable warnings from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Warnings'</i>";

		[Token(Token = "0x4000180")]
		private const string disableErrorMsg = "\n<i>To disable these error messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Errors'</i>";

		[Token(Token = "0x4000181")]
		private const char indentChar = '-';

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xEBACE8", Offset = "0xEBACE8", VA = "0xEBACE8")]
		public static void Log(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xEB0BFC", Offset = "0xEB0BFC", VA = "0xEB0BFC")]
		public static void LogWarning(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xEBAEF4", Offset = "0xEBAEF4", VA = "0xEBAEF4")]
		public static void LogError(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xEBAE90", Offset = "0xEBAE90", VA = "0xEBAE90")]
		private static string Indent(int size)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E8")]
	public static class ES3Hash
	{
		[Token(Token = "0x6000461")]
		[Address(RVA = "0xEBB078", Offset = "0xEBB078", VA = "0xEBB078")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E9")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x6000462")]
		public abstract byte[] Encrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000463")]
		public abstract byte[] Decrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000464")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000465")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xEBB274", Offset = "0xEBB274", VA = "0xEBB274")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xEBB354", Offset = "0xEBB354", VA = "0xEBB354")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x4000182")]
		private const int ivSize = 16;

		[Token(Token = "0x4000183")]
		private const int keySize = 16;

		[Token(Token = "0x4000184")]
		private const int pwIterations = 100;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xEBB35C", Offset = "0xEBB35C", VA = "0xEBB35C", Slot = "4")]
		public override byte[] Encrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xEBB67C", Offset = "0xEBB67C", VA = "0xEBB67C", Slot = "5")]
		public override byte[] Decrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xEBB99C", Offset = "0xEBB99C", VA = "0xEBB99C", Slot = "6")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xEBBEF8", Offset = "0xEBBEF8", VA = "0xEBBEF8", Slot = "7")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xEBC490", Offset = "0xEBC490", VA = "0xEBC490")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool disposed;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xEBC498", Offset = "0xEBC498", VA = "0xEBC498")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xEBC554", Offset = "0xEBC554", VA = "0xEBC554", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public struct ES3Data
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xEBC5D8", Offset = "0xEBC5D8", VA = "0xEBC5D8")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xEBC6A0", Offset = "0xEBC6A0", VA = "0xEBC6A0")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public static class ES3IO
	{
		[Token(Token = "0x20000EE")]
		public enum ES3FileMode
		{
			[Token(Token = "0x4000191")]
			Read,
			[Token(Token = "0x4000192")]
			Write,
			[Token(Token = "0x4000193")]
			Append
		}

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly string persistentDataPath;

		[Token(Token = "0x400018E")]
		internal const string backupFileSuffix = ".bac";

		[Token(Token = "0x400018F")]
		internal const string temporaryFileSuffix = ".tmp";

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xEBC6D0", Offset = "0xEBC6D0", VA = "0xEBC6D0")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xEBC7A0", Offset = "0xEBC7A0", VA = "0xEBC7A0")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xEBC7F8", Offset = "0xEBC7F8", VA = "0xEBC7F8")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xEBC798", Offset = "0xEBC798", VA = "0xEBC798")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xEBC86C", Offset = "0xEBC86C", VA = "0xEBC86C")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xEBC874", Offset = "0xEBC874", VA = "0xEBC874")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xEBC87C", Offset = "0xEBC87C", VA = "0xEBC87C")]
		public static void MoveDirectory(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xEBC884", Offset = "0xEBC884", VA = "0xEBC884")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xEBC88C", Offset = "0xEBC88C", VA = "0xEBC88C")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xEBC894", Offset = "0xEBC894", VA = "0xEBC894")]
		public static string GetDirectoryPath(string path, char seperator = '/')
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xEBC98C", Offset = "0xEBC98C", VA = "0xEBC98C")]
		public static bool UsesForwardSlash(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xEBC9E0", Offset = "0xEBC9E0", VA = "0xEBC9E0")]
		public static string CombinePathAndFilename(string directoryPath, string fileOrDirectoryName)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xEBCA8C", Offset = "0xEBCA8C", VA = "0xEBCA8C")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xEBCBEC", Offset = "0xEBCBEC", VA = "0xEBCBEC")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xEBCC64", Offset = "0xEBCC64", VA = "0xEBCC64")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xEBCD78", Offset = "0xEBCD78", VA = "0xEBCD78")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xEBCD80", Offset = "0xEBCD80", VA = "0xEBCD80")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xEBCD88", Offset = "0xEBCD88", VA = "0xEBCD88")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xEBD1F4", Offset = "0xEBD1F4", VA = "0xEBD1F4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xEBD3E0", Offset = "0xEBD3E0", VA = "0xEBD3E0")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xEBD458", Offset = "0xEBD458", VA = "0xEBD458")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xEBD578", Offset = "0xEBD578", VA = "0xEBD578")]
		public Dictionary<string, string> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xEBD7E8", Offset = "0xEBD7E8", VA = "0xEBD7E8")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xEBD52C", Offset = "0xEBD52C", VA = "0xEBD52C")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xEBDBB4", Offset = "0xEBDBB4", VA = "0xEBDBB4")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F0")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _lock;

		[Token(Token = "0x4000197")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HashSet<ES3ReferenceMgrBase> mgrs;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Random rng;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ES3RefIdDictionary _refId;

		[Token(Token = "0x17000028")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0xEAACB0", Offset = "0xEAACB0", VA = "0xEAACB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public bool IsInitialised
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0xEBDE44", Offset = "0xEBDE44", VA = "0xEBDE44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public ES3RefIdDictionary refId
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0xEBDEA0", Offset = "0xEBDEA0", VA = "0xEBDEA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0xEBE0B4", Offset = "0xEBE0B4", VA = "0xEBE0B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public ES3GlobalReferences GlobalReferences
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0xEBE0BC", Offset = "0xEBE0BC", VA = "0xEBE0BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xEBDC30", Offset = "0xEBDC30", VA = "0xEBDC30")]
		public static ES3ReferenceMgrBase GetManagerFromScene(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xEBE0C4", Offset = "0xEBE0C4", VA = "0xEBE0C4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xEBE194", Offset = "0xEBE194", VA = "0xEBE194")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xEBE96C", Offset = "0xEBE96C", VA = "0xEBE96C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xEBE818", Offset = "0xEBE818", VA = "0xEBE818")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xEBEA70", Offset = "0xEBEA70", VA = "0xEBEA70")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xEBED58", Offset = "0xEBED58", VA = "0xEBED58")]
		internal UnityEngine.Object Get(long id, Type type, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xEBF3E8", Offset = "0xEBF3E8", VA = "0xEBF3E8")]
		public UnityEngine.Object Get(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xEBF3F4", Offset = "0xEBF3F4", VA = "0xEBF3F4")]
		public ES3Prefab GetPrefab(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xEBF84C", Offset = "0xEBF84C", VA = "0xEBF84C")]
		public long GetPrefab(ES3Prefab prefabToFind, bool suppressWarnings = false)
		{
			return default(long);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xEAAE34", Offset = "0xEAAE34", VA = "0xEAAE34")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xEAB9CC", Offset = "0xEAB9CC", VA = "0xEAB9CC")]
		public long Add(UnityEngine.Object obj, long id)
		{
			return default(long);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xEBFCA8", Offset = "0xEBFCA8", VA = "0xEBFCA8")]
		public bool AddPrefab(ES3Prefab prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xEBFD90", Offset = "0xEBFD90", VA = "0xEBFD90")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xEC0380", Offset = "0xEC0380", VA = "0xEC0380")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xEBE388", Offset = "0xEBE388", VA = "0xEBE388")]
		public void RemoveNullValues()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xEC08A4", Offset = "0xEC08A4", VA = "0xEC08A4")]
		public void RemoveNullOrInvalidValues()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xEC0C18", Offset = "0xEC0C18", VA = "0xEC0C18")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xEC0D3C", Offset = "0xEC0D3C", VA = "0xEC0D3C")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xEC0D98", Offset = "0xEC0D98", VA = "0xEC0D98")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xEC0DF0", Offset = "0xEC0DF0", VA = "0xEC0DF0")]
		public void ChangeId(long oldId, long newId)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xEBDA2C", Offset = "0xEBDA2C", VA = "0xEBDA2C")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xEBD524", Offset = "0xEBD524", VA = "0xEBD524")]
		internal static bool CanBeSaved(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xEC0E68", Offset = "0xEC0E68", VA = "0xEC0E68")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F4")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xEC12EC", Offset = "0xEC12EC", VA = "0xEC12EC", Slot = "48")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xEC12F8", Offset = "0xEC12F8", VA = "0xEC12F8", Slot = "49")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xEC1360", Offset = "0xEC1360", VA = "0xEC1360")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xEC13A8", Offset = "0xEC13A8", VA = "0xEC13A8", Slot = "48")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xEC1410", Offset = "0xEC1410", VA = "0xEC1410", Slot = "49")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xEC141C", Offset = "0xEC141C", VA = "0xEC141C")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public static class ES3Reflection
	{
		[Token(Token = "0x20000F7")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x1700002D")]
			public bool IsNull
			{
				[Token(Token = "0x60004E3")]
				[Address(RVA = "0xEC58FC", Offset = "0xEC58FC", VA = "0xEC58FC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002E")]
			public string Name
			{
				[Token(Token = "0x60004E4")]
				[Address(RVA = "0xEC5938", Offset = "0xEC5938", VA = "0xEC5938")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			public Type MemberType
			{
				[Token(Token = "0x60004E5")]
				[Address(RVA = "0xEC5968", Offset = "0xEC5968", VA = "0xEC5968")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			public bool IsPublic
			{
				[Token(Token = "0x60004E6")]
				[Address(RVA = "0xEC59AC", Offset = "0xEC59AC", VA = "0xEC59AC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000031")]
			public bool IsProtected
			{
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0xEC5A38", Offset = "0xEC5A38", VA = "0xEC5A38")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool IsStatic
			{
				[Token(Token = "0x60004E8")]
				[Address(RVA = "0xEC5A88", Offset = "0xEC5A88", VA = "0xEC5A88")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xEC3390", Offset = "0xEC3390", VA = "0xEC3390")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xEC5AD8", Offset = "0xEC5AD8", VA = "0xEC5AD8")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xEC5B1C", Offset = "0xEC5B1C", VA = "0xEC5B1C")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x20000F8")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xEC3D94", Offset = "0xEC3D94", VA = "0xEC3D94")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xEC5B68", Offset = "0xEC5B68", VA = "0xEC5B68")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes, BindingFlags bindingAttr)
			{
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xEC5BF8", Offset = "0xEC5BF8", VA = "0xEC5BF8")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x40001A8")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x40001A9")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x40001AA")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] excludedPropertyNames;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Type es3SerializableAttributeType;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Type es3NonSerializableAttributeType;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x1700002C")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xEC1464", Offset = "0xEC1464", VA = "0xEC1464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xEC16C4", Offset = "0xEC16C4", VA = "0xEC16C4")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xEC186C", Offset = "0xEC186C", VA = "0xEC186C")]
		public static List<FieldInfo> GetSerializableFields(Type type, [Optional] List<FieldInfo> serializableFields, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xEC2190", Offset = "0xEC2190", VA = "0xEC2190")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, [Optional] List<PropertyInfo> serializableProperties, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xEC1EA0", Offset = "0xEC1EA0", VA = "0xEC1EA0")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xEC2AFC", Offset = "0xEC2AFC", VA = "0xEC2AFC")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xEC2D8C", Offset = "0xEC2D8C", VA = "0xEC2D8C")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xEC2F04", Offset = "0xEC2F04", VA = "0xEC2F04")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xEC2F80", Offset = "0xEC2F80", VA = "0xEC2F80")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xEC2F88", Offset = "0xEC2F88", VA = "0xEC2F88")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xEC3044", Offset = "0xEC3044", VA = "0xEC3044")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xEC35B8", Offset = "0xEC35B8", VA = "0xEC35B8")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xEC3774", Offset = "0xEC3774", VA = "0xEC3774")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x60004C6")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xEC3938", Offset = "0xEC3938", VA = "0xEC3938")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xEC1E80", Offset = "0xEC1E80", VA = "0xEC1E80")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xEC3CAC", Offset = "0xEC3CAC", VA = "0xEC3CAC")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xEC182C", Offset = "0xEC182C", VA = "0xEC182C")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xEC3CCC", Offset = "0xEC3CCC", VA = "0xEC3CCC")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xEC3CEC", Offset = "0xEC3CEC", VA = "0xEC3CEC")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xEC3D0C", Offset = "0xEC3D0C", VA = "0xEC3D0C")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xEC2AE8", Offset = "0xEC2AE8", VA = "0xEC2AE8")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xEC184C", Offset = "0xEC184C", VA = "0xEC184C")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xEC3E0C", Offset = "0xEC3E0C", VA = "0xEC3E0C")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xEC3E20", Offset = "0xEC3E20", VA = "0xEC3E20")]
		public static bool IsInterface(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xEC180C", Offset = "0xEC180C", VA = "0xEC180C")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xEC28D8", Offset = "0xEC28D8", VA = "0xEC28D8")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xEC3E34", Offset = "0xEC3E34", VA = "0xEC3E34")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xEC2CC4", Offset = "0xEC2CC4", VA = "0xEC2CC4")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xEC3E54", Offset = "0xEC3E54", VA = "0xEC3E54")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xEC3EEC", Offset = "0xEC3EEC", VA = "0xEC3EEC")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xEC3634", Offset = "0xEC3634", VA = "0xEC3634")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xEC37F0", Offset = "0xEC37F0", VA = "0xEC37F0")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xEC3FCC", Offset = "0xEC3FCC", VA = "0xEC3FCC")]
		public static MethodInfo[] GetMethods(Type type, string methodName)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xEC27E8", Offset = "0xEC27E8", VA = "0xEC27E8")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xEC1E74", Offset = "0xEC1E74", VA = "0xEC1E74")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xEC27C8", Offset = "0xEC27C8", VA = "0xEC27C8")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xEC40E8", Offset = "0xEC40E8", VA = "0xEC40E8")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xEC2170", Offset = "0xEC2170", VA = "0xEC2170")]
		public static Type BaseType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xEC417C", Offset = "0xEC417C", VA = "0xEC417C")]
		public static Type GetType(string typeString)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xEC4B38", Offset = "0xEC4B38", VA = "0xEC4B38")]
		public static string GetTypeString(Type type)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000FC")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x60004F8")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x60004F9")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x60004FA")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60004FB")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60004FC")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x60004FD")]
		public bool ChangeKey(TKey oldKey, TKey newKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x40001C3")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamReader baseReader;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xEC5E38", Offset = "0xEC5E38", VA = "0xEC5E38")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xEC6060", Offset = "0xEC6060", VA = "0xEC6060", Slot = "21")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xEC65B8", Offset = "0xEC65B8", VA = "0xEC65B8", Slot = "22")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xEC6754", Offset = "0xEC6754", VA = "0xEC6754", Slot = "23")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xEC6764", Offset = "0xEC6764", VA = "0xEC6764", Slot = "27")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xEC6A58", Offset = "0xEC6A58", VA = "0xEC6A58", Slot = "28")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xEC6A78", Offset = "0xEC6A78", VA = "0xEC6A78", Slot = "29")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xEC6A88", Offset = "0xEC6A88", VA = "0xEC6A88", Slot = "30")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xEC6A8C", Offset = "0xEC6A8C", VA = "0xEC6A8C", Slot = "31")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xEC6AC4", Offset = "0xEC6AC4", VA = "0xEC6AC4", Slot = "32")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xEC6ACC", Offset = "0xEC6ACC", VA = "0xEC6ACC", Slot = "33")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xEC6AD0", Offset = "0xEC6AD0", VA = "0xEC6AD0", Slot = "34")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xEC6B94", Offset = "0xEC6B94", VA = "0xEC6B94", Slot = "35")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xEC6B9C", Offset = "0xEC6B9C", VA = "0xEC6B9C", Slot = "36")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xEC6BA0", Offset = "0xEC6BA0", VA = "0xEC6BA0", Slot = "37")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xEC6BD8", Offset = "0xEC6BD8", VA = "0xEC6BD8", Slot = "38")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xEC6C9C", Offset = "0xEC6C9C", VA = "0xEC6C9C")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xEC6DC4", Offset = "0xEC6DC4", VA = "0xEC6DC4", Slot = "24")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xEC6D68", Offset = "0xEC6D68", VA = "0xEC6D68")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xEC62B4", Offset = "0xEC62B4", VA = "0xEC62B4")]
		private char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
		{
			return default(char);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xEC6784", Offset = "0xEC6784", VA = "0xEC6784")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xEC63B0", Offset = "0xEC63B0", VA = "0xEC63B0")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xEC7370", Offset = "0xEC7370", VA = "0xEC7370")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xEC754C", Offset = "0xEC754C", VA = "0xEC754C")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xEC622C", Offset = "0xEC622C", VA = "0xEC622C")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xEC7750", Offset = "0xEC7750", VA = "0xEC7750")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xEC5FB0", Offset = "0xEC5FB0", VA = "0xEC5FB0")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xEC7338", Offset = "0xEC7338", VA = "0xEC7338")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xEC72B4", Offset = "0xEC72B4", VA = "0xEC72B4")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xEC72C8", Offset = "0xEC72C8", VA = "0xEC72C8")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xEC62A0", Offset = "0xEC62A0", VA = "0xEC62A0")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xEC6388", Offset = "0xEC6388", VA = "0xEC6388")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xEC77C4", Offset = "0xEC77C4", VA = "0xEC77C4")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xEC77D4", Offset = "0xEC77D4", VA = "0xEC77D4")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xEC7894", Offset = "0xEC7894", VA = "0xEC7894", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xEC7A34", Offset = "0xEC7A34", VA = "0xEC7A34", Slot = "20")]
		internal override long Read_ref()
		{
			return default(long);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xEC7B6C", Offset = "0xEC7B6C", VA = "0xEC7B6C", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xEC7BE0", Offset = "0xEC7BE0", VA = "0xEC7BE0", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xEC7C54", Offset = "0xEC7C54", VA = "0xEC7C54", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xEC7C68", Offset = "0xEC7C68", VA = "0xEC7C68", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xEC7CD0", Offset = "0xEC7CD0", VA = "0xEC7CD0", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xEC7D70", Offset = "0xEC7D70", VA = "0xEC7D70", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xEC7DE4", Offset = "0xEC7DE4", VA = "0xEC7DE4", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xEC7DF8", Offset = "0xEC7DF8", VA = "0xEC7DF8", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xEC7E0C", Offset = "0xEC7E0C", VA = "0xEC7E0C", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xEC7E20", Offset = "0xEC7E20", VA = "0xEC7E20", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xEC7E38", Offset = "0xEC7E38", VA = "0xEC7E38", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xEC7E50", Offset = "0xEC7E50", VA = "0xEC7E50", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xEC7E68", Offset = "0xEC7E68", VA = "0xEC7E68", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xEC7E80", Offset = "0xEC7E80", VA = "0xEC7E80", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xEC7EF4", Offset = "0xEC7EF4", VA = "0xEC7EF4", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class ES3GlobalReferences : ScriptableObject
	{
		[Token(Token = "0x17000033")]
		public static ES3GlobalReferences Instance
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0xEC7F10", Offset = "0xEC7F10", VA = "0xEC7F10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xEC7F18", Offset = "0xEC7F18", VA = "0xEC7F18")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xEC7F20", Offset = "0xEC7F20", VA = "0xEC7F20")]
		public long GetOrAdd(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xEC7F28", Offset = "0xEC7F28", VA = "0xEC7F28")]
		public void RemoveInvalidKeys()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xEC7F2C", Offset = "0xEC7F2C", VA = "0xEC7F2C")]
		public ES3GlobalReferences()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoUpdateReferences;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xEC7F34", Offset = "0xEC7F34", VA = "0xEC7F34")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public enum ES3FileMode
	{
		[Token(Token = "0x40001C8")]
		Read,
		[Token(Token = "0x40001C9")]
		Write,
		[Token(Token = "0x40001CA")]
		Append
	}
	[Token(Token = "0x2000102")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xEC7F44", Offset = "0xEC7F44", VA = "0xEC7F44")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xEC8008", Offset = "0xEC8008", VA = "0xEC8008")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xEC8100", Offset = "0xEC8100", VA = "0xEC8100")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xEC8120", Offset = "0xEC8120", VA = "0xEC8120")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xEC8130", Offset = "0xEC8130", VA = "0xEC8130", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000103")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xEC8150", Offset = "0xEC8150", VA = "0xEC8150")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xEC828C", Offset = "0xEC828C", VA = "0xEC828C")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xEC819C", Offset = "0xEC819C", VA = "0xEC819C")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xEC82D4", Offset = "0xEC82D4", VA = "0xEC82D4", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000104")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x17000034")]
		public bool Exists
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xEC8550", Offset = "0xEC8550", VA = "0xEC8550")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xEC8570", Offset = "0xEC8570", VA = "0xEC8570")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xEC8594", Offset = "0xEC8594", VA = "0xEC8594")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xEC8688", Offset = "0xEC8688", VA = "0xEC8688", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public static class ES3Stream
	{
		[Token(Token = "0x6000549")]
		[Address(RVA = "0xEC8694", Offset = "0xEC8694", VA = "0xEC8694")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xEC8B50", Offset = "0xEC8B50", VA = "0xEC8B50")]
		public static Stream CreateStream(Stream stream, ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xEC8F28", Offset = "0xEC8F28", VA = "0xEC8F28")]
		public static void CopyTo(Stream source, Stream destination)
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class ES3Member
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xEC8F3C", Offset = "0xEC8F3C", VA = "0xEC8F3C")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xEC8F94", Offset = "0xEC8F94", VA = "0xEC8F94")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x2000107")]
	[Preserve]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ES3Type lastAccessedType;

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xEC28EC", Offset = "0xEC28EC", VA = "0xEC28EC")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xEC9D00", Offset = "0xEC9D00", VA = "0xEC9D00")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xEC9DE0", Offset = "0xEC9DE0", VA = "0xEC9DE0")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xEC9274", Offset = "0xEC9274", VA = "0xEC9274")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xEC9018", Offset = "0xEC9018", VA = "0xEC9018")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class ES3WebClass
	{
		[Token(Token = "0x2000109")]
		[CompilerGenerated]
		private sealed class <SendWebRequest>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3WebClass <>4__this;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000562")]
				[Address(RVA = "0xECA7E4", Offset = "0xECA7E4", VA = "0xECA7E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000564")]
				[Address(RVA = "0xECA82C", Offset = "0xECA82C", VA = "0xECA82C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xECA718", Offset = "0xECA718", VA = "0xECA718")]
			[DebuggerHidden]
			public <SendWebRequest>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0xECA768", Offset = "0xECA768", VA = "0xECA768", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xECA76C", Offset = "0xECA76C", VA = "0xECA76C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0xECA7EC", Offset = "0xECA7EC", VA = "0xECA7EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityWebRequest _webRequest;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isDone;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string error;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long errorCode;

		[Token(Token = "0x17000035")]
		public float uploadProgress
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xECA038", Offset = "0xECA038", VA = "0xECA038")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public float downloadProgress
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xECA050", Offset = "0xECA050", VA = "0xECA050")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public bool isError
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0xECA068", Offset = "0xECA068", VA = "0xECA068")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xECA09C", Offset = "0xECA09C", VA = "0xECA09C")]
		public static bool IsNetworkError(UnityWebRequest www)
		{
			return default(bool);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xECA0C0", Offset = "0xECA0C0", VA = "0xECA0C0")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xECA178", Offset = "0xECA178", VA = "0xECA178")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xECA26C", Offset = "0xECA26C", VA = "0xECA26C")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xECA2FC", Offset = "0xECA2FC", VA = "0xECA2FC")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xECA488", Offset = "0xECA488", VA = "0xECA488")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xECA688", Offset = "0xECA688", VA = "0xECA688")]
		[IteratorStateMachine(typeof(<SendWebRequest>d__19))]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xECA740", Offset = "0xECA740", VA = "0xECA740", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x200010A")]
	internal enum ES3SpecialByte : byte
	{
		[Token(Token = "0x40001E4")]
		Null = 0,
		[Token(Token = "0x40001E5")]
		Bool = 1,
		[Token(Token = "0x40001E6")]
		Byte = 2,
		[Token(Token = "0x40001E7")]
		Sbyte = 3,
		[Token(Token = "0x40001E8")]
		Char = 4,
		[Token(Token = "0x40001E9")]
		Decimal = 5,
		[Token(Token = "0x40001EA")]
		Double = 6,
		[Token(Token = "0x40001EB")]
		Float = 7,
		[Token(Token = "0x40001EC")]
		Int = 8,
		[Token(Token = "0x40001ED")]
		Uint = 9,
		[Token(Token = "0x40001EE")]
		Long = 10,
		[Token(Token = "0x40001EF")]
		Ulong = 11,
		[Token(Token = "0x40001F0")]
		Short = 12,
		[Token(Token = "0x40001F1")]
		Ushort = 13,
		[Token(Token = "0x40001F2")]
		String = 14,
		[Token(Token = "0x40001F3")]
		ByteArray = 15,
		[Token(Token = "0x40001F4")]
		Collection = 128,
		[Token(Token = "0x40001F5")]
		Dictionary = 129,
		[Token(Token = "0x40001F6")]
		CollectionItem = 130,
		[Token(Token = "0x40001F7")]
		Object = 254,
		[Token(Token = "0x40001F8")]
		Terminator = byte.MaxValue
	}
	[Token(Token = "0x200010B")]
	internal static class ES3Binary
	{
		[Token(Token = "0x40001F9")]
		internal const string ObjectTerminator = ".";

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<ES3SpecialByte, Type> IdToType;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<Type, ES3SpecialByte> TypeToId;

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xECA834", Offset = "0xECA834", VA = "0xECA834")]
		internal static ES3SpecialByte TypeToByte(Type type)
		{
			return default(ES3SpecialByte);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xECA8D8", Offset = "0xECA8D8", VA = "0xECA8D8")]
		internal static Type ByteToType(ES3SpecialByte b)
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xECA92C", Offset = "0xECA92C", VA = "0xECA92C")]
		internal static Type ByteToType(byte b)
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xECAA14", Offset = "0xECAA14", VA = "0xECAA14")]
		internal static bool IsPrimitive(ES3SpecialByte b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010C")]
	internal class ES3CacheWriter : ES3Writer
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ES3File es3File;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xECB0C4", Offset = "0xECB0C4", VA = "0xECB0C4")]
		internal ES3CacheWriter(ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x600056B")]
		public override void Write<T>(string key, object value)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xECB164", Offset = "0xECB164", VA = "0xECB164", Slot = "39")]
		internal override void Write(string key, Type type, byte[] value)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xECB1B0", Offset = "0xECB1B0", VA = "0xECB1B0", Slot = "41")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void Write(Type type, string key, object value)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xECB218", Offset = "0xECB218", VA = "0xECB218", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xECB21C", Offset = "0xECB21C", VA = "0xECB21C", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xECB220", Offset = "0xECB220", VA = "0xECB220", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xECB224", Offset = "0xECB224", VA = "0xECB224", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xECB228", Offset = "0xECB228", VA = "0xECB228", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xECB22C", Offset = "0xECB22C", VA = "0xECB22C", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xECB230", Offset = "0xECB230", VA = "0xECB230", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xECB234", Offset = "0xECB234", VA = "0xECB234", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xECB238", Offset = "0xECB238", VA = "0xECB238", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xECB23C", Offset = "0xECB23C", VA = "0xECB23C", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xECB240", Offset = "0xECB240", VA = "0xECB240", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xECB244", Offset = "0xECB244", VA = "0xECB244", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xECB248", Offset = "0xECB248", VA = "0xECB248", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xECB24C", Offset = "0xECB24C", VA = "0xECB24C", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xECB250", Offset = "0xECB250", VA = "0xECB250", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xECB254", Offset = "0xECB254", VA = "0xECB254", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xECB258", Offset = "0xECB258", VA = "0xECB258")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xECB260", Offset = "0xECB260", VA = "0xECB260")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xECB264", Offset = "0xECB264", VA = "0xECB264", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xECB268", Offset = "0xECB268", VA = "0xECB268", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xECB26C", Offset = "0xECB26C", VA = "0xECB26C", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xECB270", Offset = "0xECB270", VA = "0xECB270", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xECB278", Offset = "0xECB278", VA = "0xECB278", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xECB27C", Offset = "0xECB27C", VA = "0xECB27C", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xECB280", Offset = "0xECB280", VA = "0xECB280", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xECB284", Offset = "0xECB284", VA = "0xECB284", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xECB288", Offset = "0xECB288", VA = "0xECB288", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xECB28C", Offset = "0xECB28C", VA = "0xECB28C", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xECB290", Offset = "0xECB290", VA = "0xECB290", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xECB294", Offset = "0xECB294", VA = "0xECB294", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xECB298", Offset = "0xECB298", VA = "0xECB298", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xECB29C", Offset = "0xECB29C", VA = "0xECB29C", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xECB2A0", Offset = "0xECB2A0", VA = "0xECB2A0", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xECB2A4", Offset = "0xECB2A4", VA = "0xECB2A4", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xECB2A8", Offset = "0xECB2A8", VA = "0xECB2A8", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xECB2AC", Offset = "0xECB2AC", VA = "0xECB2AC", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200010D")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xECB2B0", Offset = "0xECB2B0", VA = "0xECB2B0")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xECB2BC", Offset = "0xECB2BC", VA = "0xECB2BC")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xECB378", Offset = "0xECB378", VA = "0xECB378", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xECB39C", Offset = "0xECB39C", VA = "0xECB39C", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xECB44C", Offset = "0xECB44C", VA = "0xECB44C", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xECB4C8", Offset = "0xECB4C8", VA = "0xECB4C8", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xECB588", Offset = "0xECB588", VA = "0xECB588", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xECB638", Offset = "0xECB638", VA = "0xECB638", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xECB65C", Offset = "0xECB65C", VA = "0xECB65C", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xECB680", Offset = "0xECB680", VA = "0xECB680", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xECB6A4", Offset = "0xECB6A4", VA = "0xECB6A4", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xECB72C", Offset = "0xECB72C", VA = "0xECB72C", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xECB7B4", Offset = "0xECB7B4", VA = "0xECB7B4", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xECB83C", Offset = "0xECB83C", VA = "0xECB83C", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xECB8C4", Offset = "0xECB8C4", VA = "0xECB8C4", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xECB904", Offset = "0xECB904", VA = "0xECB904", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xECB980", Offset = "0xECB980", VA = "0xECB980", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xECBBBC", Offset = "0xECBBBC", VA = "0xECBBBC", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xECBC18", Offset = "0xECBC18", VA = "0xECBC18")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xECBC48", Offset = "0xECBC48", VA = "0xECBC48")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xECBD1C", Offset = "0xECBD1C", VA = "0xECBD1C", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xECBDB4", Offset = "0xECBDB4", VA = "0xECBDB4", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xECBDF4", Offset = "0xECBDF4", VA = "0xECBDF4", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xECBE40", Offset = "0xECBE40", VA = "0xECBE40", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xECBF08", Offset = "0xECBF08", VA = "0xECBF08", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xECBF10", Offset = "0xECBF10", VA = "0xECBF10", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xECBF4C", Offset = "0xECBF4C", VA = "0xECBF4C", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xECBF8C", Offset = "0xECBF8C", VA = "0xECBF8C", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xECBFC8", Offset = "0xECBFC8", VA = "0xECBFC8", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xECC004", Offset = "0xECC004", VA = "0xECC004", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xECC038", Offset = "0xECC038", VA = "0xECC038", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xECC03C", Offset = "0xECC03C", VA = "0xECC03C", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xECC04C", Offset = "0xECC04C", VA = "0xECC04C", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xECC05C", Offset = "0xECC05C", VA = "0xECC05C", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xECC090", Offset = "0xECC090", VA = "0xECC090", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xECC0B8", Offset = "0xECC0B8", VA = "0xECC0B8", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xECC0BC", Offset = "0xECC0BC", VA = "0xECC0BC", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xECC0C0", Offset = "0xECC0C0", VA = "0xECC0C0", Slot = "22")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xECBC8C", Offset = "0xECBC8C", VA = "0xECBC8C")]
		public void WriteNewlineAndTabs()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200010E")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xECC0DC", Offset = "0xECC0DC", VA = "0xECC0DC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xECC290", Offset = "0xECC290", VA = "0xECC290")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xECC41C", Offset = "0xECC41C", VA = "0xECC41C")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xECC5BC", Offset = "0xECC5BC", VA = "0xECC5BC")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xECC624", Offset = "0xECC624", VA = "0xECC624")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xECC68C", Offset = "0xECC68C", VA = "0xECC68C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xECC6E4", Offset = "0xECC6E4", VA = "0xECC6E4")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xECC75C", Offset = "0xECC75C", VA = "0xECC75C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xECC7B4", Offset = "0xECC7B4", VA = "0xECC7B4")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xECC80C", Offset = "0xECC80C", VA = "0xECC80C")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xECC864", Offset = "0xECC864", VA = "0xECC864")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xECC8BC", Offset = "0xECC8BC", VA = "0xECC8BC")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xECC91C", Offset = "0xECC91C", VA = "0xECC91C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xECC978", Offset = "0xECC978", VA = "0xECC978")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xECC9D0", Offset = "0xECC9D0", VA = "0xECC9D0")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000112")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xECCAF0", Offset = "0xECCAF0", VA = "0xECCAF0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xECCCA8", Offset = "0xECCCA8", VA = "0xECCCA8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xECCE54", Offset = "0xECCE54", VA = "0xECCE54")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xECD000", Offset = "0xECD000", VA = "0xECD000")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xECD1AC", Offset = "0xECD1AC", VA = "0xECD1AC")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xECD360", Offset = "0xECD360", VA = "0xECD360")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xECD5C8", Offset = "0xECD5C8", VA = "0xECD5C8")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xECDAD4", Offset = "0xECDAD4", VA = "0xECDAD4")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xECDD48", Offset = "0xECDD48", VA = "0xECDD48")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xECDFDC", Offset = "0xECDFDC", VA = "0xECDFDC")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xECE1B0", Offset = "0xECE1B0", VA = "0xECE1B0")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xECE7C4", Offset = "0xECE7C4", VA = "0xECE7C4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xECE974", Offset = "0xECE974", VA = "0xECE974")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xECEB1C", Offset = "0xECEB1C", VA = "0xECEB1C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xECECC4", Offset = "0xECECC4", VA = "0xECECC4")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xECEE54", Offset = "0xECEE54", VA = "0xECEE54")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xECF288", Offset = "0xECF288", VA = "0xECF288")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xECF578", Offset = "0xECF578", VA = "0xECF578")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000126")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000614")]
		[Address(RVA = "0xECFB80", Offset = "0xECFB80", VA = "0xECFB80")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xECFD34", Offset = "0xECFD34", VA = "0xECFD34")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xECFEC0", Offset = "0xECFEC0", VA = "0xECFEC0")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xED009C", Offset = "0xED009C", VA = "0xED009C")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200012A")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x200012B")]
		public static class Utils
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xED4C5C", Offset = "0xED4C5C", VA = "0xED4C5C")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xED0394", Offset = "0xED0394", VA = "0xED0394")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xED0520", Offset = "0xED0520", VA = "0xED0520")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xED06D4", Offset = "0xED06D4", VA = "0xED06D4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xED0860", Offset = "0xED0860", VA = "0xED0860")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xED0A14", Offset = "0xED0A14", VA = "0xED0A14")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xED0BA0", Offset = "0xED0BA0", VA = "0xED0BA0")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xED0D50", Offset = "0xED0D50", VA = "0xED0D50")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xED0F34", Offset = "0xED0F34", VA = "0xED0F34")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xED10E0", Offset = "0xED10E0", VA = "0xED10E0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xED128C", Offset = "0xED128C", VA = "0xED128C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xED1438", Offset = "0xED1438", VA = "0xED1438")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xED15EC", Offset = "0xED15EC", VA = "0xED15EC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xED1778", Offset = "0xED1778", VA = "0xED1778")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xED1914", Offset = "0xED1914", VA = "0xED1914")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xED1AC0", Offset = "0xED1AC0", VA = "0xED1AC0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xED1C64", Offset = "0xED1C64", VA = "0xED1C64")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xED1E08", Offset = "0xED1E08", VA = "0xED1E08")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xED1FBC", Offset = "0xED1FBC", VA = "0xED1FBC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xED2164", Offset = "0xED2164", VA = "0xED2164")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xED230C", Offset = "0xED230C", VA = "0xED230C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xED24B4", Offset = "0xED24B4", VA = "0xED24B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xED2660", Offset = "0xED2660", VA = "0xED2660")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xED280C", Offset = "0xED280C", VA = "0xED280C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xED29A8", Offset = "0xED29A8", VA = "0xED29A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xED2B48", Offset = "0xED2B48", VA = "0xED2B48")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xED2CE8", Offset = "0xED2CE8", VA = "0xED2CE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xED2E94", Offset = "0xED2E94", VA = "0xED2E94")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xED3050", Offset = "0xED3050", VA = "0xED3050")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xED3234", Offset = "0xED3234", VA = "0xED3234")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xED3420", Offset = "0xED3420", VA = "0xED3420")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xED3848", Offset = "0xED3848", VA = "0xED3848")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xED39E8", Offset = "0xED39E8", VA = "0xED39E8")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xED3B78", Offset = "0xED3B78", VA = "0xED3B78")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xED3D08", Offset = "0xED3D08", VA = "0xED3D08")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xED3EA4", Offset = "0xED3EA4", VA = "0xED3EA4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xED4058", Offset = "0xED4058", VA = "0xED4058")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xED4250", Offset = "0xED4250", VA = "0xED4250")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xED43DC", Offset = "0xED43DC", VA = "0xED43DC")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xED4614", Offset = "0xED4614", VA = "0xED4614")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xED482C", Offset = "0xED482C", VA = "0xED482C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xED4A44", Offset = "0xED4A44", VA = "0xED4A44")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000154")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x2000157")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0xED7018", Offset = "0xED7018", VA = "0xED7018", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0xED7250", Offset = "0xED7250", VA = "0xED7250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000158")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0xED725C", Offset = "0xED725C", VA = "0xED725C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xED74B8", Offset = "0xED74B8", VA = "0xED74B8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000159")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xED74C4", Offset = "0xED74C4", VA = "0xED74C4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xED76E8", Offset = "0xED76E8", VA = "0xED76E8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200015A")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xED76F4", Offset = "0xED76F4", VA = "0xED76F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xED7934", Offset = "0xED7934", VA = "0xED7934", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200015B")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xED7940", Offset = "0xED7940", VA = "0xED7940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0xED7B98", Offset = "0xED7B98", VA = "0xED7B98", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200015C")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xED7BA4", Offset = "0xED7BA4", VA = "0xED7BA4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xED7DD0", Offset = "0xED7DD0", VA = "0xED7DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xED5BE4", Offset = "0xED5BE4", VA = "0xED5BE4")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xED5DC4", Offset = "0xED5DC4", VA = "0xED5DC4")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xED5FB0", Offset = "0xED5FB0", VA = "0xED5FB0")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xED60AC", Offset = "0xED60AC", VA = "0xED60AC")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xED61A8", Offset = "0xED61A8", VA = "0xED61A8")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xED62A4", Offset = "0xED62A4", VA = "0xED62A4")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xED63B4", Offset = "0xED63B4", VA = "0xED63B4")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xED64D4", Offset = "0xED64D4", VA = "0xED64D4")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xED65D0", Offset = "0xED65D0", VA = "0xED65D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xED67DC", Offset = "0xED67DC", VA = "0xED67DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xED69E8", Offset = "0xED69E8", VA = "0xED69E8")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xED6AD4", Offset = "0xED6AD4", VA = "0xED6AD4")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xED6BC0", Offset = "0xED6BC0", VA = "0xED6BC0")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xED6CAC", Offset = "0xED6CAC", VA = "0xED6CAC")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xED6DA0", Offset = "0xED6DA0", VA = "0xED6DA0")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xED6E9C", Offset = "0xED6E9C", VA = "0xED6E9C")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200015D")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200015E")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0xED7DDC", Offset = "0xED7DDC", VA = "0xED7DDC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xED607C", Offset = "0xED607C", VA = "0xED607C")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200015F")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006EB")]
				[Address(RVA = "0xED7E0C", Offset = "0xED7E0C", VA = "0xED7E0C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xED6178", Offset = "0xED6178", VA = "0xED6178")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000160")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006ED")]
				[Address(RVA = "0xED7E6C", Offset = "0xED7E6C", VA = "0xED7E6C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xED6274", Offset = "0xED6274", VA = "0xED6274")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000161")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700003D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0xED7E88", Offset = "0xED7E88", VA = "0xED7E88", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xED6378", Offset = "0xED6378", VA = "0xED6378")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000162")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700003E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0xED7EC8", Offset = "0xED7EC8", VA = "0xED7EC8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0xED6490", Offset = "0xED6490", VA = "0xED6490")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000163")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003F")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0xED7F20", Offset = "0xED7F20", VA = "0xED7F20", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xED65A0", Offset = "0xED65A0", VA = "0xED65A0")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000164")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000165")]
		public static class Physics
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xED80B0", Offset = "0xED80B0", VA = "0xED80B0")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xED81B0", Offset = "0xED81B0", VA = "0xED81B0")]
			public static bool HasRigidbody2D(UnityEngine.Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xED823C", Offset = "0xED823C", VA = "0xED823C")]
			[Preserve]
			public static bool HasRigidbody(UnityEngine.Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xED82C8", Offset = "0xED82C8", VA = "0xED82C8")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xED7F54", Offset = "0xED7F54", VA = "0xED7F54")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xED8008", Offset = "0xED8008", VA = "0xED8008")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000167")]
		public enum AnimationType
		{
			[Token(Token = "0x40002A9")]
			None,
			[Token(Token = "0x40002AA")]
			Move,
			[Token(Token = "0x40002AB")]
			LocalMove,
			[Token(Token = "0x40002AC")]
			Rotate,
			[Token(Token = "0x40002AD")]
			LocalRotate,
			[Token(Token = "0x40002AE")]
			Scale,
			[Token(Token = "0x40002AF")]
			Color,
			[Token(Token = "0x40002B0")]
			Fade,
			[Token(Token = "0x40002B1")]
			Text,
			[Token(Token = "0x40002B2")]
			PunchPosition,
			[Token(Token = "0x40002B3")]
			PunchRotation,
			[Token(Token = "0x40002B4")]
			PunchScale,
			[Token(Token = "0x40002B5")]
			ShakePosition,
			[Token(Token = "0x40002B6")]
			ShakeRotation,
			[Token(Token = "0x40002B7")]
			ShakeScale,
			[Token(Token = "0x40002B8")]
			CameraAspect,
			[Token(Token = "0x40002B9")]
			CameraBackgroundColor,
			[Token(Token = "0x40002BA")]
			CameraFieldOfView,
			[Token(Token = "0x40002BB")]
			CameraOrthoSize,
			[Token(Token = "0x40002BC")]
			CameraPixelRect,
			[Token(Token = "0x40002BD")]
			CameraRect,
			[Token(Token = "0x40002BE")]
			UIWidthHeight
		}

		[Token(Token = "0x2000168")]
		public enum TargetType
		{
			[Token(Token = "0x40002C0")]
			Unset,
			[Token(Token = "0x40002C1")]
			Camera,
			[Token(Token = "0x40002C2")]
			CanvasGroup,
			[Token(Token = "0x40002C3")]
			Image,
			[Token(Token = "0x40002C4")]
			Light,
			[Token(Token = "0x40002C5")]
			RectTransform,
			[Token(Token = "0x40002C6")]
			Renderer,
			[Token(Token = "0x40002C7")]
			SpriteRenderer,
			[Token(Token = "0x40002C8")]
			Rigidbody,
			[Token(Token = "0x40002C9")]
			Rigidbody2D,
			[Token(Token = "0x40002CA")]
			Text,
			[Token(Token = "0x40002CB")]
			Transform,
			[Token(Token = "0x40002CC")]
			tk2dBaseSprite,
			[Token(Token = "0x40002CD")]
			tk2dTextMesh,
			[Token(Token = "0x40002CE")]
			TextMeshPro,
			[Token(Token = "0x40002CF")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UnityEngine.Component target;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xED840C", Offset = "0xED840C", VA = "0xED840C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xED84D8", Offset = "0xED84D8", VA = "0xED84D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xED85A4", Offset = "0xED85A4", VA = "0xED85A4")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xED8610", Offset = "0xED8610", VA = "0xED8610")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xED9AF8", Offset = "0xED9AF8", VA = "0xED9AF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xED9B30", Offset = "0xED9B30", VA = "0xED9B30")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xED9B34", Offset = "0xED9B34", VA = "0xED9B34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xED8654", Offset = "0xED8654", VA = "0xED8654")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xED9D9C", Offset = "0xED9D9C", VA = "0xED9D9C", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xED9E08", Offset = "0xED9E08", VA = "0xED9E08", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xED9E74", Offset = "0xED9E74", VA = "0xED9E74", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xED9EE0", Offset = "0xED9EE0", VA = "0xED9EE0", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xED9F4C", Offset = "0xED9F4C", VA = "0xED9F4C", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xED9FB8", Offset = "0xED9FB8", VA = "0xED9FB8", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xEDA09C", Offset = "0xEDA09C", VA = "0xEDA09C", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xEDA0AC", Offset = "0xEDA0AC", VA = "0xEDA0AC", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xEDA3F8", Offset = "0xEDA3F8", VA = "0xEDA3F8", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xEDA468", Offset = "0xEDA468", VA = "0xEDA468", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xEDA4E8", Offset = "0xEDA4E8", VA = "0xEDA4E8")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xEDA564", Offset = "0xEDA564", VA = "0xEDA564")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xEDA5BC", Offset = "0xEDA5BC", VA = "0xEDA5BC")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xEDA614", Offset = "0xEDA614", VA = "0xEDA614")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xEDA690", Offset = "0xEDA690", VA = "0xEDA690")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xEDA6E8", Offset = "0xEDA6E8", VA = "0xEDA6E8")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xEDA764", Offset = "0xEDA764", VA = "0xEDA764")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xEDA7BC", Offset = "0xEDA7BC", VA = "0xEDA7BC")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xEDA8F0", Offset = "0xEDA8F0", VA = "0xEDA8F0")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xEDA970", Offset = "0xEDA970", VA = "0xEDA970")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xEDA9E0", Offset = "0xEDA9E0", VA = "0xEDA9E0")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xEDAA6C", Offset = "0xEDAA6C", VA = "0xEDAA6C")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xEDAAE0", Offset = "0xEDAAE0", VA = "0xEDAAE0")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xED9B8C", Offset = "0xED9B8C", VA = "0xED9B8C")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xEDAC2C", Offset = "0xEDAC2C", VA = "0xEDAC2C")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xED9B74", Offset = "0xED9B74", VA = "0xED9B74")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xEDA1A4", Offset = "0xEDA1A4", VA = "0xEDA1A4")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xEDAC5C", Offset = "0xEDAC5C", VA = "0xEDAC5C")]
		public DOTweenAnimation()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000720")]
		public static bool IsSameOrSubclassOf<T>(this UnityEngine.Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200016A")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x6000721")]
		[Address(RVA = "0xEDBE4C", Offset = "0xEDBE4C", VA = "0xEDBE4C")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xEDBE9C", Offset = "0xEDBE9C", VA = "0xEDBE9C")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xEDC260", Offset = "0xEDC260", VA = "0xEDC260")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
namespace CrazyMinnow.SALSA.OneClicks
{
	[Token(Token = "0x200016D")]
	public class OneClickBase : MonoBehaviour
	{
		[Token(Token = "0x40002D2")]
		public const string RESOURCE_CLIP = "Assets/Crazy Minnow Studio/Examples/Audio/Promo-male.mp3";

		[Token(Token = "0x40002D3")]
		public const string PREFAB_ALERT_TITLE = "Prefab Unpack Warning";

		[Token(Token = "0x40002D4")]
		public const string PREFAB_ALERT_MSG = "Your selection is a prefab and must be unpacked to apply this setup. You can create a new prefab once the setup is complete. Do you want to proceed?";

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static List<SkinnedMeshRenderer> requiredSmrs;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static List<OneClickConfiguration> oneClickConfigurations;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static Salsa salsa;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static Emoter emoter;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static UmaUepProxy uepProxy;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected static GameObject selectedObject;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected static float emphasizerTrigger;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected static bool autoAdjustAnalysis;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		protected static bool autoAdjustMicrophone;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected static float audioUpdateDelay;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected static float loCutoff;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected static float hiCutoff;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected static bool useAdvDyn;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected static float advDynPrimaryBias;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected static bool useAdvDynJitter;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected static float advDynJitterAmount;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected static float advDynJitterProb;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected static float advDynSecondaryMix;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected static float emphasisChance;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected static bool useRandomEmotes;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected static bool isChancePerEmote;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected static int numRandomEmotesPerCycle;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected static float randomEmoteMinTimer;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected static float randomEmoteMaxTimer;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected static float randomChance;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		protected static bool useRandomFrac;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected static float randomFracBias;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected static bool useRandomHoldDuration;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected static float randomHoldDurationMin;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected static float randomHoldDurationMax;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected static LerpEasings.EasingType easingType;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static OneClickConfiguration currentConfiguration;

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xEDC67C", Offset = "0xEDC67C", VA = "0xEDC67C")]
		protected static void NewConfiguration(OneClickConfiguration.ConfigType configType)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xEDC948", Offset = "0xEDC948", VA = "0xEDC948")]
		protected static void AddSmrSearch(string search)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xEDCA28", Offset = "0xEDCA28", VA = "0xEDCA28")]
		protected static void NewExpression(string expressionName)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xEDCC70", Offset = "0xEDCC70", VA = "0xEDCC70")]
		protected static void AddShapeComponent(string[] blendshapeNames, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f, bool useRegex = false)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xEDCE9C", Offset = "0xEDCE9C", VA = "0xEDCE9C")]
		protected static void AddUepPoseComponent(string poseName, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xEDD0B8", Offset = "0xEDD0B8", VA = "0xEDD0B8")]
		protected static void AddAnimatorComponent(string componentName, string animatorSearch, float durOn, float durHold, float durOff, int parmIndex, bool isTriggereParmBiDir = false)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xEDD2F8", Offset = "0xEDD2F8", VA = "0xEDD2F8")]
		protected static void AddBoneComponent(string componentSearchName, TformBase maxTform, float durOn, float durHold, float durOff, string componentName = "", bool constrainPos = false, bool constrainRot = true, bool constrainScl = false)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xEDD58C", Offset = "0xEDD58C", VA = "0xEDD58C")]
		protected static void AddEmoteFlags(bool isRandom, bool isEmph, bool isRepeater, float frac = 1f, bool isAlwaysEmph = false)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xEDD6E4", Offset = "0xEDD6E4", VA = "0xEDD6E4")]
		protected static void DoOneClickiness(GameObject go, AudioClip clip)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xEDDA04", Offset = "0xEDDA04", VA = "0xEDDA04")]
		private static bool FindSkinnedMeshRenderers(OneClickConfiguration configuration)
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xEDE2B8", Offset = "0xEDE2B8", VA = "0xEDE2B8")]
		private static void ConfigEmoterSettings(QueueProcessor qp)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xEDDF58", Offset = "0xEDDF58", VA = "0xEDDF58")]
		private static void ConfigureSalsaSettings(AudioClip clip, QueueProcessor qp)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xEDEF48", Offset = "0xEDEF48", VA = "0xEDEF48")]
		protected static void Init()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xEDE544", Offset = "0xEDE544", VA = "0xEDE544")]
		private static void ConfigureModuleExpressions(OneClickConfiguration configuration)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xEDF020", Offset = "0xEDF020", VA = "0xEDF020")]
		private static Expression InitializeExpressionType(OneClickConfiguration configuration, int exp)
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xEDF488", Offset = "0xEDF488", VA = "0xEDF488")]
		private static int RegexFindBlendshapeName(SkinnedMeshRenderer smr, string bName)
		{
			return default(int);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xEDFB94", Offset = "0xEDFB94", VA = "0xEDFB94")]
		private static string[] GetBlendshapeNames(SkinnedMeshRenderer smr)
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xEDF94C", Offset = "0xEDF94C", VA = "0xEDF94C")]
		private static TformBase ConvertBoneToTform(Transform bone)
		{
			return default(TformBase);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xEDF824", Offset = "0xEDF824", VA = "0xEDF824")]
		private static Transform FindBone(string componentSearchName)
		{
			return null;
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xEDFA6C", Offset = "0xEDFA6C", VA = "0xEDFA6C")]
		private static Animator FindAnimator(string componentSearchName)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xEDF738", Offset = "0xEDF738", VA = "0xEDF738")]
		private static void ApplyCommonSettingsToComponent(ExpressionComponent component, OneClickComponent oneClickComponent, int componentNumber)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xEDF57C", Offset = "0xEDF57C", VA = "0xEDF57C")]
		private static int CreateNewComponent(int componentCount, Expression expression)
		{
			return default(int);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xEDFCC8", Offset = "0xEDFCC8", VA = "0xEDFCC8")]
		public OneClickBase()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class OneClickBoxHead : OneClickBase
	{
		[Token(Token = "0x6000741")]
		[Address(RVA = "0xEDFE44", Offset = "0xEDFE44", VA = "0xEDFE44")]
		public static void Setup(GameObject gameObject, AudioClip clip)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xEE0600", Offset = "0xEE0600", VA = "0xEE0600")]
		public OneClickBoxHead()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class OneClickBoxHeadEyes : MonoBehaviour
	{
		[Token(Token = "0x6000743")]
		[Address(RVA = "0xEE0658", Offset = "0xEE0658", VA = "0xEE0658")]
		public static void Setup(GameObject go)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xEE0F88", Offset = "0xEE0F88", VA = "0xEE0F88")]
		public OneClickBoxHeadEyes()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class OneClickComponent
	{
		[Token(Token = "0x2000171")]
		public enum ComponentType
		{
			[Token(Token = "0x40002FB")]
			Shape,
			[Token(Token = "0x40002FC")]
			UMA,
			[Token(Token = "0x40002FD")]
			Bone,
			[Token(Token = "0x40002FE")]
			Animator
		}

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ComponentType type;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string componentName;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float durOn;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float durHold;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float durOff;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xEE0F90", Offset = "0xEE0F90", VA = "0xEE0F90")]
		public OneClickComponent()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class OneClickShapeComponent : OneClickComponent
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] blendshapeNames;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxAmount;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool useRegex;

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xEDCE10", Offset = "0xEDCE10", VA = "0xEDCE10")]
		public OneClickShapeComponent(string componentName, string[] blendshapeNames, float maxAmount, float durOn, float durHold, float durOff, ComponentType type, bool useRegex)
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class OneClickBoneComponent : OneClickComponent
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string componentSearchName;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TformBase max;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool usePos;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useRot;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool useScl;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xEDD4D4", Offset = "0xEDD4D4", VA = "0xEDD4D4")]
		public OneClickBoneComponent(string componentName, string boneSearchName, TformBase max, bool usePos, bool useRot, bool useScl, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class OneClickUepComponent : OneClickComponent
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string poseName;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxAmount;

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xEDD034", Offset = "0xEDD034", VA = "0xEDD034")]
		public OneClickUepComponent(string componentName, string poseName, float maxAmount, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class OneClickAnimatorComponent : OneClickComponent
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string componentSearchName;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int animationParmIndex;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isTriggerParmBiDirectional;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xEDD264", Offset = "0xEDD264", VA = "0xEDD264")]
		public OneClickAnimatorComponent(string componentName, string animatorSearchName, int animationParmIndex, bool isTriggerParmBiDirectional, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class OneClickConfiguration
	{
		[Token(Token = "0x2000177")]
		public enum ConfigType
		{
			[Token(Token = "0x4000310")]
			Salsa,
			[Token(Token = "0x4000311")]
			Emoter
		}

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ConfigType type;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> smrSearches;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<OneClickExpression> oneClickExpressions;

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xEDC7DC", Offset = "0xEDC7DC", VA = "0xEDC7DC")]
		public OneClickConfiguration(ConfigType type)
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class OneClickExpression
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<OneClickComponent> components;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xEE0F98", Offset = "0xEE0F98", VA = "0xEE0F98")]
		public OneClickExpression()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xEDCBE0", Offset = "0xEDCBE0", VA = "0xEDCBE0")]
		public OneClickExpression(string name, List<OneClickComponent> components)
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class OneClickEmoterExpression : OneClickExpression
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isRandom;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isEmphasis;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isAlwaysEmphasis;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isRepeater;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float expressionDynamics;

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xEDCC24", Offset = "0xEDCC24", VA = "0xEDCC24")]
		public OneClickEmoterExpression(string name, List<OneClickComponent> components)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xEDD6BC", Offset = "0xEDD6BC", VA = "0xEDD6BC")]
		public void SetEmoterBools(bool isRand, bool isEmph, bool isRep, float frac, bool isAlwaysEmph = false)
		{
		}
	}
}
