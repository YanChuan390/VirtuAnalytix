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
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using ES3Internal;
using ES3Types;
using Il2CppDummyDll;
using TMPro;
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
	[Address(RVA = "0x1912D40", Offset = "0x1912D40", VA = "0x1912D40")]
	public ES3Serializable()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
public class ES3NonSerializable : Attribute
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1912D48", Offset = "0x1912D48", VA = "0x1912D48")]
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
	[Address(RVA = "0x1912D50", Offset = "0x1912D50", VA = "0x1912D50")]
	public void Reset()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1912D5C", Offset = "0x1912D5C", VA = "0x1912D5C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x19130DC", Offset = "0x19130DC", VA = "0x19130DC")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x19130E8", Offset = "0x19130E8", VA = "0x19130E8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x19131A4", Offset = "0x19131A4", VA = "0x19131A4", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x19131A8", Offset = "0x19131A8", VA = "0x19131A8", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x19132B0", Offset = "0x19132B0", VA = "0x19132B0")]
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
		[Address(RVA = "0x1912E00", Offset = "0x1912E00", VA = "0x1912E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public static ES3AutoSaveMgr Instance
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x19134A0", Offset = "0x19134A0", VA = "0x19134A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x19134A4", Offset = "0x19134A4", VA = "0x19134A4")]
	public void Save()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1913C6C", Offset = "0x1913C6C", VA = "0x1913C6C")]
	public void Load()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1913D88", Offset = "0x1913D88", VA = "0x1913D88")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1913D9C", Offset = "0x1913D9C", VA = "0x1913D9C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1913F14", Offset = "0x1913F14", VA = "0x1913F14")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1913F28", Offset = "0x1913F28", VA = "0x1913F28")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1913030", Offset = "0x1913030", VA = "0x1913030")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x19130F8", Offset = "0x19130F8", VA = "0x19130F8")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1913DC8", Offset = "0x1913DC8", VA = "0x1913DC8")]
	public void GetAutoSaves()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1913F90", Offset = "0x1913F90", VA = "0x1913F90")]
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
	[Address(RVA = "0x191410C", Offset = "0x191410C", VA = "0x191410C")]
	public static void Save(string key, object value)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x19141EC", Offset = "0x19141EC", VA = "0x19141EC")]
	public static void Save(string key, object value, string filePath)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1914280", Offset = "0x1914280", VA = "0x1914280")]
	public static void Save(string key, object value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1914320", Offset = "0x1914320", VA = "0x1914320")]
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
	[Address(RVA = "0x1914380", Offset = "0x1914380", VA = "0x1914380")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1914634", Offset = "0x1914634", VA = "0x1914634")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x19146A8", Offset = "0x19146A8", VA = "0x19146A8")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x19143E4", Offset = "0x19143E4", VA = "0x19143E4")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1914CF4", Offset = "0x1914CF4", VA = "0x1914CF4")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1914D90", Offset = "0x1914D90", VA = "0x1914D90")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1914E04", Offset = "0x1914E04", VA = "0x1914E04")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1914D58", Offset = "0x1914D58", VA = "0x1914D58")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1914E7C", Offset = "0x1914E7C", VA = "0x1914E7C")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1915118", Offset = "0x1915118", VA = "0x1915118")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1914EE0", Offset = "0x1914EE0", VA = "0x1914EE0")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x191520C", Offset = "0x191520C", VA = "0x191520C")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x19154CC", Offset = "0x19154CC", VA = "0x19154CC")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1915270", Offset = "0x1915270", VA = "0x1915270")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1915544", Offset = "0x1915544", VA = "0x1915544")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x19155C8", Offset = "0x19155C8", VA = "0x19155C8")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x19155BC", Offset = "0x19155BC", VA = "0x19155BC")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x19157E4", Offset = "0x19157E4", VA = "0x19157E4")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x191585C", Offset = "0x191585C", VA = "0x191585C")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1915644", Offset = "0x1915644", VA = "0x1915644")]
	public static void SaveImage(Texture2D texture, int quality, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x19158E4", Offset = "0x19158E4", VA = "0x19158E4")]
	public static object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1915960", Offset = "0x1915960", VA = "0x1915960")]
	public static object Load(string key, string filePath)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x19159EC", Offset = "0x19159EC", VA = "0x19159EC")]
	public static object Load(string key, string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1915A7C", Offset = "0x1915A7C", VA = "0x1915A7C")]
	public static object Load(string key, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1915AD4", Offset = "0x1915AD4", VA = "0x1915AD4")]
	public static object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1915B60", Offset = "0x1915B60", VA = "0x1915B60")]
	public static object Load(string key, string filePath, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1915BF4", Offset = "0x1915BF4", VA = "0x1915BF4")]
	public static object Load(string key, string filePath, object defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1915C94", Offset = "0x1915C94", VA = "0x1915C94")]
	public static object Load(string key, object defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000044")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x6000045")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000046")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000047")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000048")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000049")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600004A")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600004B")]
	public static void LoadInto<T>(string key, object obj) where T : class
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1915CF4", Offset = "0x1915CF4", VA = "0x1915CF4")]
	public static void LoadInto(string key, string filePath, object obj)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1915D88", Offset = "0x1915D88", VA = "0x1915D88")]
	public static void LoadInto(string key, string filePath, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1915E28", Offset = "0x1915E28", VA = "0x1915E28")]
	public static void LoadInto(string key, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x600004F")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000050")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x6000051")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000052")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1915E88", Offset = "0x1915E88", VA = "0x1915E88")]
	public static string LoadString(string key, string defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1915EEC", Offset = "0x1915EEC", VA = "0x1915EEC")]
	public static string LoadString(string key, string defaultValue, [Optional] string filePath, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1915F5C", Offset = "0x1915F5C", VA = "0x1915F5C")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x19164FC", Offset = "0x19164FC", VA = "0x19164FC")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1916560", Offset = "0x1916560", VA = "0x1916560")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1915FB8", Offset = "0x1915FB8", VA = "0x1915FB8")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1916668", Offset = "0x1916668", VA = "0x1916668")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1916704", Offset = "0x1916704", VA = "0x1916704")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1916768", Offset = "0x1916768", VA = "0x1916768")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x19166C4", Offset = "0x19166C4", VA = "0x19166C4")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x19167D8", Offset = "0x19167D8", VA = "0x19167D8")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1916850", Offset = "0x1916850", VA = "0x1916850")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1916840", Offset = "0x1916840", VA = "0x1916840")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x19168C4", Offset = "0x19168C4", VA = "0x19168C4")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x191693C", Offset = "0x191693C", VA = "0x191693C")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x19169B0", Offset = "0x19169B0", VA = "0x19169B0")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	public static byte[] Serialize<T>(T value, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1917160", Offset = "0x1917160", VA = "0x1917160")]
	internal static byte[] Serialize(object value, ES3Type type, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	public static T Deserialize<T>(byte[] bytes, [Optional] ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1917780", Offset = "0x1917780", VA = "0x1917780")]
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
	[Address(RVA = "0x1917CAC", Offset = "0x1917CAC", VA = "0x1917CAC")]
	public static byte[] EncryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1917E84", Offset = "0x1917E84", VA = "0x1917E84")]
	public static byte[] DecryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1917F5C", Offset = "0x1917F5C", VA = "0x1917F5C")]
	public static string EncryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x191800C", Offset = "0x191800C", VA = "0x191800C")]
	public static string DecryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x19180BC", Offset = "0x19180BC", VA = "0x19180BC")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1918268", Offset = "0x1918268", VA = "0x1918268")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x19182CC", Offset = "0x19182CC", VA = "0x19182CC")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1918118", Offset = "0x1918118", VA = "0x1918118")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x19183C0", Offset = "0x19183C0", VA = "0x19183C0")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1918834", Offset = "0x1918834", VA = "0x1918834")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1918450", Offset = "0x1918450", VA = "0x1918450")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1918CA8", Offset = "0x1918CA8", VA = "0x1918CA8")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1919134", Offset = "0x1919134", VA = "0x1919134")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1918D38", Offset = "0x1918D38", VA = "0x1918D38")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x19191D4", Offset = "0x19191D4", VA = "0x19191D4")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x191950C", Offset = "0x191950C", VA = "0x191950C")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1919264", Offset = "0x1919264", VA = "0x1919264")]
	public static void CopyDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x19198B0", Offset = "0x19198B0", VA = "0x19198B0")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1919AD0", Offset = "0x1919AD0", VA = "0x1919AD0")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1919940", Offset = "0x1919940", VA = "0x1919940")]
	public static void RenameDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1919B70", Offset = "0x1919B70", VA = "0x1919B70")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1919CFC", Offset = "0x1919CFC", VA = "0x1919CFC")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1919BD4", Offset = "0x1919BD4", VA = "0x1919BD4")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1919D6C", Offset = "0x1919D6C", VA = "0x1919D6C")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1919DD0", Offset = "0x1919DD0", VA = "0x1919DD0")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1919E44", Offset = "0x1919E44", VA = "0x1919E44")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x19139B0", Offset = "0x19139B0", VA = "0x19139B0")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1919F7C", Offset = "0x1919F7C", VA = "0x1919F7C")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x191A1BC", Offset = "0x191A1BC", VA = "0x191A1BC")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x191A230", Offset = "0x191A230", VA = "0x191A230")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1919FE0", Offset = "0x1919FE0", VA = "0x1919FE0")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x191A3FC", Offset = "0x191A3FC", VA = "0x191A3FC")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x191A458", Offset = "0x191A458", VA = "0x191A458")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x191A4BC", Offset = "0x191A4BC", VA = "0x191A4BC")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1913800", Offset = "0x1913800", VA = "0x1913800")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x191A5B0", Offset = "0x191A5B0", VA = "0x191A5B0")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x191A614", Offset = "0x191A614", VA = "0x191A614")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x19195AC", Offset = "0x19195AC", VA = "0x19195AC")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x191A684", Offset = "0x191A684", VA = "0x191A684")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x191AC4C", Offset = "0x191AC4C", VA = "0x191AC4C")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x191ACB0", Offset = "0x191ACB0", VA = "0x191ACB0")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x191A6E0", Offset = "0x191A6E0", VA = "0x191A6E0")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x191AEF8", Offset = "0x191AEF8", VA = "0x191AEF8")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x191AF8C", Offset = "0x191AF8C", VA = "0x191AF8C")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x191AFF0", Offset = "0x191AFF0", VA = "0x191AFF0")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x19196D8", Offset = "0x19196D8", VA = "0x19196D8")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x191B0F4", Offset = "0x191B0F4", VA = "0x191B0F4")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x191B150", Offset = "0x191B150", VA = "0x191B150")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x191B1B4", Offset = "0x191B1B4", VA = "0x191B1B4")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x19197E4", Offset = "0x19197E4", VA = "0x19197E4")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x191B224", Offset = "0x191B224", VA = "0x191B224")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x191B318", Offset = "0x191B318", VA = "0x191B318")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x191B37C", Offset = "0x191B37C", VA = "0x191B37C")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x191B280", Offset = "0x191B280", VA = "0x191B280")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x191B3EC", Offset = "0x191B3EC", VA = "0x191B3EC")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x191B504", Offset = "0x191B504", VA = "0x191B504")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x191B450", Offset = "0x191B450", VA = "0x191B450")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x191B574", Offset = "0x191B574", VA = "0x191B574")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x191B75C", Offset = "0x191B75C", VA = "0x191B75C")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x191B7C0", Offset = "0x191B7C0", VA = "0x191B7C0")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x191B5D0", Offset = "0x191B5D0", VA = "0x191B5D0")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x191B918", Offset = "0x191B918", VA = "0x191B918")]
	public static void StoreCachedFile()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x191BBB0", Offset = "0x191BBB0", VA = "0x191BBB0")]
	public static void StoreCachedFile(string filePath)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x191BC14", Offset = "0x191BC14", VA = "0x191BC14")]
	public static void StoreCachedFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1913C18", Offset = "0x1913C18", VA = "0x1913C18")]
	public static void StoreCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x191BC84", Offset = "0x191BC84", VA = "0x191BC84")]
	public static void CacheFile()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x191BCE0", Offset = "0x191BCE0", VA = "0x191BCE0")]
	public static void CacheFile(string filePath)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x191BD44", Offset = "0x191BD44", VA = "0x191BD44")]
	public static void CacheFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x191395C", Offset = "0x191395C", VA = "0x191395C")]
	public static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x191BF4C", Offset = "0x191BF4C", VA = "0x191BF4C")]
	public static void Init()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x191BFC4", Offset = "0x191BFC4", VA = "0x191BFC4")]
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
	internal static Dictionary<string, ES3File> cachedFiles;

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

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x191BFCC", Offset = "0x191BFCC", VA = "0x191BFCC")]
	public ES3File()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x191C574", Offset = "0x191C574", VA = "0x191C574")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x191C5EC", Offset = "0x191C5EC", VA = "0x191C5EC")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x191C668", Offset = "0x191C668", VA = "0x191C668")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x191C670", Offset = "0x191C670", VA = "0x191C670")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x191C6E4", Offset = "0x191C6E4", VA = "0x191C6E4")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x191C760", Offset = "0x191C760", VA = "0x191C760")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x191C034", Offset = "0x191C034", VA = "0x191C034")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x191C8C8", Offset = "0x191C8C8", VA = "0x191C8C8")]
	public ES3File(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x191C9F0", Offset = "0x191C9F0", VA = "0x191C9F0")]
	public void Sync()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x191CDE0", Offset = "0x191CDE0", VA = "0x191CDE0")]
	public void Sync(string filePath, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x191C9F8", Offset = "0x191C9F8", VA = "0x191C9F8")]
	public void Sync([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x191CEA8", Offset = "0x191CEA8", VA = "0x191CEA8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x191CEF8", Offset = "0x191CEF8", VA = "0x191CEF8")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	public void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1914838", Offset = "0x1914838", VA = "0x1914838")]
	public void SaveRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1915190", Offset = "0x1915190", VA = "0x1915190")]
	public void AppendRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x191D09C", Offset = "0x191D09C", VA = "0x191D09C")]
	public object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x191D0F4", Offset = "0x191D0F4", VA = "0x191D0F4")]
	public object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60000C4")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60000C5")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x19165D0", Offset = "0x19165D0", VA = "0x19165D0")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x191D6DC", Offset = "0x191D6DC", VA = "0x191D6DC")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x191D154", Offset = "0x191D154", VA = "0x191D154")]
	internal byte[] GetBytes([Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x191D784", Offset = "0x191D784", VA = "0x191D784")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x191D7DC", Offset = "0x191D7DC", VA = "0x191D7DC")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x191D834", Offset = "0x191D834", VA = "0x191D834")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x191D994", Offset = "0x191D994", VA = "0x191D994")]
	public Type GetKeyType(string key)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1914720", Offset = "0x1914720", VA = "0x1914720")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static ES3File GetOrCreateCachedFile(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x191BDB4", Offset = "0x191BDB4", VA = "0x191BDB4")]
	internal static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x191B968", Offset = "0x191B968", VA = "0x191B968")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void Store([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x191833C", Offset = "0x191833C", VA = "0x191833C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void RemoveCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x19188D4", Offset = "0x19188D4", VA = "0x19188D4")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void CopyCachedFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1919EBC", Offset = "0x1919EBC", VA = "0x1919EBC")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x191A2A8", Offset = "0x191A2A8", VA = "0x191A2A8")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x191A52C", Offset = "0x191A52C", VA = "0x191A52C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x191AD20", Offset = "0x191AD20", VA = "0x191AD20")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x191B060", Offset = "0x191B060", VA = "0x191B060")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x191B830", Offset = "0x191B830", VA = "0x191B830")]
	internal static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}
}
[Token(Token = "0x2000012")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x191DCDC", Offset = "0x191DCDC", VA = "0x191DCDC")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000013")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase
{
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x191DCE4", Offset = "0x191DCE4", VA = "0x191DCE4")]
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

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x191E00C", Offset = "0x191E00C", VA = "0x191E00C")]
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
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x191DD3C", Offset = "0x191DD3C", VA = "0x191DD3C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public int RowCount
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x191DD44", Offset = "0x191DD44", VA = "0x191DD44")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x191DD4C", Offset = "0x191DD4C", VA = "0x191DD4C")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x191DF70", Offset = "0x191DF70", VA = "0x191DF70")]
	private void SetCellString(int col, int row, string value)
	{
	}

	[Token(Token = "0x60000DF")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x191E014", Offset = "0x191E014", VA = "0x191E014")]
	public object GetCell(Type type, int col, int row)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x191E41C", Offset = "0x191E41C", VA = "0x191E41C")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x191E4C8", Offset = "0x191E4C8", VA = "0x191E4C8")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x191E4A0", Offset = "0x191E4A0", VA = "0x191E4A0")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x191E838", Offset = "0x191E838", VA = "0x191E838")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x191E910", Offset = "0x191E910", VA = "0x191E910")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x191E550", Offset = "0x191E550", VA = "0x191E550")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x191E9B0", Offset = "0x191E9B0", VA = "0x191E9B0")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x191ED8C", Offset = "0x191ED8C", VA = "0x191ED8C")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x191EE08", Offset = "0x191EE08", VA = "0x191EE08")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x191EE10", Offset = "0x191EE10", VA = "0x191EE10")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x191EE8C", Offset = "0x191EE8C", VA = "0x191EE8C")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x191EA28", Offset = "0x191EA28", VA = "0x191EA28")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x191F0F0", Offset = "0x191F0F0", VA = "0x191F0F0")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x191F218", Offset = "0x191F218", VA = "0x191F218")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x191EF14", Offset = "0x191EF14", VA = "0x191EF14")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x191F2EC", Offset = "0x191F2EC", VA = "0x191F2EC")]
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
				[Token(Token = "0x6000136")]
				[Address(RVA = "0x191FDC8", Offset = "0x191FDC8", VA = "0x191FDC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000138")]
				[Address(RVA = "0x191FE10", Offset = "0x191FE10", VA = "0x191FE10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x191FCEC", Offset = "0x191FCEC", VA = "0x191FCEC")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x191FD14", Offset = "0x191FD14", VA = "0x191FD14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x191FD18", Offset = "0x191FD18", VA = "0x191FD18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x191FDD0", Offset = "0x191FDD0", VA = "0x191FDD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x191F594", Offset = "0x191F594", VA = "0x191F594")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x191AE84", Offset = "0x191AE84", VA = "0x191AE84")]
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
				[Token(Token = "0x600013E")]
				[Address(RVA = "0x1920008", Offset = "0x1920008", VA = "0x1920008", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000140")]
				[Address(RVA = "0x1920050", Offset = "0x1920050", VA = "0x1920050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x191FE18", Offset = "0x191FE18", VA = "0x191FE18")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x191FE40", Offset = "0x191FE40", VA = "0x191FE40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600013D")]
			[Address(RVA = "0x191FE44", Offset = "0x191FE44", VA = "0x191FE44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1920010", Offset = "0x1920010", VA = "0x1920010", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x191F634", Offset = "0x191F634", VA = "0x191F634")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x191C854", Offset = "0x191C854", VA = "0x191C854")]
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
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x191F524", Offset = "0x191F524", VA = "0x191F524", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x191F5C4", Offset = "0x191F5C4", VA = "0x191F5C4", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000F3")]
	internal abstract int Read_int();

	[Token(Token = "0x60000F4")]
	internal abstract float Read_float();

	[Token(Token = "0x60000F5")]
	internal abstract bool Read_bool();

	[Token(Token = "0x60000F6")]
	internal abstract char Read_char();

	[Token(Token = "0x60000F7")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x60000F8")]
	internal abstract double Read_double();

	[Token(Token = "0x60000F9")]
	internal abstract long Read_long();

	[Token(Token = "0x60000FA")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x60000FB")]
	internal abstract byte Read_byte();

	[Token(Token = "0x60000FC")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x60000FD")]
	internal abstract short Read_short();

	[Token(Token = "0x60000FE")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x60000FF")]
	internal abstract uint Read_uint();

	[Token(Token = "0x6000100")]
	internal abstract string Read_string();

	[Token(Token = "0x6000101")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x6000102")]
	internal abstract long Read_ref();

	[Token(Token = "0x6000103")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract string ReadPropertyName();

	[Token(Token = "0x6000104")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x6000105")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x6000106")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x6000107")]
	public abstract void Dispose();

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x191F414", Offset = "0x191F414", VA = "0x191F414", Slot = "26")]
	internal virtual bool Goto(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x191F4D0", Offset = "0x191F4D0", VA = "0x191F4D0", Slot = "27")]
	internal virtual bool StartReadObject()
	{
		return default(bool);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x191F4E4", Offset = "0x191F4E4", VA = "0x191F4E4", Slot = "28")]
	internal virtual void EndReadObject()
	{
	}

	[Token(Token = "0x600010B")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x600010C")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x600010D")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x600010E")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x600010F")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x6000110")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x6000111")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x6000112")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x6000113")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x6000114")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x191F4F4", Offset = "0x191F4F4", VA = "0x191F4F4")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x191F664", Offset = "0x191F664", VA = "0x191F664", Slot = "41")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x6000119")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600011A")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x600011B")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600011C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x191F678", Offset = "0x191F678", VA = "0x191F678")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public long ReadRefProperty()
	{
		return default(long);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x191F6A8", Offset = "0x191F6A8", VA = "0x191F6A8")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x191F77C", Offset = "0x191F77C", VA = "0x191F77C")]
	public object SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x191F91C", Offset = "0x191F91C", VA = "0x191F91C")]
	public object SetPrivateField(string name, object value, object objectContainingField)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000122")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000123")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000124")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000125")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000126")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000127")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000128")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x191FABC", Offset = "0x191FABC", VA = "0x191FABC")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x191FB18", Offset = "0x191FB18", VA = "0x191FB18")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x191FB7C", Offset = "0x191FB7C", VA = "0x191FB7C")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x191A364", Offset = "0x191A364", VA = "0x191A364")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x191FBEC", Offset = "0x191FBEC", VA = "0x191FBEC")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x191CFC4", Offset = "0x191CFC4", VA = "0x191CFC4")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x191FC50", Offset = "0x191FC50", VA = "0x191FC50")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1917C1C", Offset = "0x1917C1C", VA = "0x1917C1C")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x200001B")]
public class ES3XMLReader
{
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1920058", Offset = "0x1920058", VA = "0x1920058")]
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

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1920060", Offset = "0x1920060", VA = "0x1920060")]
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool typeChecking;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool safeReflection;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public int serializationDepthLimit;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string[] assemblyNames;

	[Token(Token = "0x1700000D")]
	public static ES3Defaults defaultSettingsScriptableObject
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1920134", Offset = "0x1920134", VA = "0x1920134")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public static ES3Settings defaultSettings
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1917D84", Offset = "0x1917D84", VA = "0x1917D84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	internal static ES3Settings unencryptedUncompressedSettings
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1920244", Offset = "0x1920244", VA = "0x1920244")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public ES3.Location location
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x19137BC", Offset = "0x19137BC", VA = "0x19137BC")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x19203F0", Offset = "0x19203F0", VA = "0x19203F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public string FullPath
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1916DFC", Offset = "0x1916DFC", VA = "0x1916DFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1914198", Offset = "0x1914198", VA = "0x1914198")]
	public ES3Settings([Optional] string path, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1920794", Offset = "0x1920794", VA = "0x1920794")]
	public ES3Settings(string path, params Enum[] enums)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x191DA84", Offset = "0x191DA84", VA = "0x191DA84")]
	public ES3Settings(params Enum[] enums)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x19207D4", Offset = "0x19207D4", VA = "0x19207D4")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x192080C", Offset = "0x192080C", VA = "0x192080C")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1920498", Offset = "0x1920498", VA = "0x1920498")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x19203F8", Offset = "0x19203F8", VA = "0x19203F8")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x191C7E8", Offset = "0x191C7E8", VA = "0x191C7E8", Slot = "4")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x19206D8", Offset = "0x19206D8", VA = "0x19206D8")]
	private void CopyInto(ES3Settings newSettings)
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x19200DC", Offset = "0x19200DC", VA = "0x19200DC")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1920C34", Offset = "0x1920C34", VA = "0x1920C34")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1920C98", Offset = "0x1920C98", VA = "0x1920C98")]
	public ES3SerializableSettings(string path)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x19140A0", Offset = "0x19140A0", VA = "0x19140A0")]
	public ES3SerializableSettings(string path, ES3.Location location)
	{
	}
}
[Token(Token = "0x200001F")]
public class ES3Ref
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long id;

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1920D0C", Offset = "0x1920D0C", VA = "0x1920D0C")]
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
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x1923730", Offset = "0x1923730", VA = "0x1923730", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1923778", Offset = "0x1923778", VA = "0x1923778", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x19214DC", Offset = "0x19214DC", VA = "0x19214DC")]
		[DebuggerHidden]
		public <Sync>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x19235E8", Offset = "0x19235E8", VA = "0x19235E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x19235EC", Offset = "0x19235EC", VA = "0x19235EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1923738", Offset = "0x1923738", VA = "0x1923738", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <UploadFile>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public long fileTimestamp;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] bytes;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x1923B5C", Offset = "0x1923B5C", VA = "0x1923B5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x1923BA4", Offset = "0x1923BA4", VA = "0x1923BA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1921DFC", Offset = "0x1921DFC", VA = "0x1921DFC")]
		[DebuggerHidden]
		public <UploadFile>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1923780", Offset = "0x1923780", VA = "0x1923780", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x192379C", Offset = "0x192379C", VA = "0x192379C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1923AAC", Offset = "0x1923AAC", VA = "0x1923AAC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1923B64", Offset = "0x1923B64", VA = "0x1923B64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class <DownloadFile>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3File es3File;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x192403C", Offset = "0x192403C", VA = "0x192403C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1924084", Offset = "0x1924084", VA = "0x1924084", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1922490", Offset = "0x1922490", VA = "0x1922490")]
		[DebuggerHidden]
		public <DownloadFile>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1923BAC", Offset = "0x1923BAC", VA = "0x1923BAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1923BC8", Offset = "0x1923BC8", VA = "0x1923BC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1923F8C", Offset = "0x1923F8C", VA = "0x1923F8C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1924044", Offset = "0x1924044", VA = "0x1924044", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class <DownloadFile>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x19244D8", Offset = "0x19244D8", VA = "0x19244D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1924520", Offset = "0x1924520", VA = "0x1924520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x19224B8", Offset = "0x19224B8", VA = "0x19224B8")]
		[DebuggerHidden]
		public <DownloadFile>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x192408C", Offset = "0x192408C", VA = "0x192408C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x19240A8", Offset = "0x19240A8", VA = "0x19240A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1924428", Offset = "0x1924428", VA = "0x1924428")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x19244E0", Offset = "0x19244E0", VA = "0x19244E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class <DeleteFile>d__53 : IEnumerator<object>, IEnumerator, IDisposable
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
		public string user;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1924868", Offset = "0x1924868", VA = "0x1924868", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x19248B0", Offset = "0x19248B0", VA = "0x19248B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1922994", Offset = "0x1922994", VA = "0x1922994")]
		[DebuggerHidden]
		public <DeleteFile>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1924528", Offset = "0x1924528", VA = "0x1924528", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1924544", Offset = "0x1924544", VA = "0x1924544", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x19247B8", Offset = "0x19247B8", VA = "0x19247B8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1924870", Offset = "0x1924870", VA = "0x1924870", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class <RenameFile>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Settings newSettings;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x1924C38", Offset = "0x1924C38", VA = "0x1924C38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1924C80", Offset = "0x1924C80", VA = "0x1924C80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1922EF4", Offset = "0x1922EF4", VA = "0x1922EF4")]
		[DebuggerHidden]
		public <RenameFile>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x19248B8", Offset = "0x19248B8", VA = "0x19248B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x19248D4", Offset = "0x19248D4", VA = "0x19248D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1924B88", Offset = "0x1924B88", VA = "0x1924B88")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1924C40", Offset = "0x1924C40", VA = "0x1924C40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class <DownloadFilenames>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x1925014", Offset = "0x1925014", VA = "0x1925014", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x192505C", Offset = "0x192505C", VA = "0x192505C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1922FC0", Offset = "0x1922FC0", VA = "0x1922FC0")]
		[DebuggerHidden]
		public <DownloadFilenames>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1924C88", Offset = "0x1924C88", VA = "0x1924C88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1924CA4", Offset = "0x1924CA4", VA = "0x1924CA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1924F64", Offset = "0x1924F64", VA = "0x1924F64")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x192501C", Offset = "0x192501C", VA = "0x192501C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class <SearchFilenames>d__62 : IEnumerator<object>, IEnumerator, IDisposable
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
		public string user;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string searchPattern;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1925438", Offset = "0x1925438", VA = "0x1925438", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x1925480", Offset = "0x1925480", VA = "0x1925480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x19230A8", Offset = "0x19230A8", VA = "0x19230A8")]
		[DebuggerHidden]
		public <SearchFilenames>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1925064", Offset = "0x1925064", VA = "0x1925064", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1925080", Offset = "0x1925080", VA = "0x1925080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1925388", Offset = "0x1925388", VA = "0x1925388")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1925440", Offset = "0x1925440", VA = "0x1925440", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class <DownloadTimestamp>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1925814", Offset = "0x1925814", VA = "0x1925814", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x192585C", Offset = "0x192585C", VA = "0x192585C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1923584", Offset = "0x1923584", VA = "0x1923584")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1925488", Offset = "0x1925488", VA = "0x1925488", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x19254A4", Offset = "0x19254A4", VA = "0x19254A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1925764", Offset = "0x1925764", VA = "0x1925764")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x192581C", Offset = "0x192581C", VA = "0x192581C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int timeout;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Encoding encoding;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private byte[] _data;

	[Token(Token = "0x17000012")]
	public byte[] data
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1920DE8", Offset = "0x1920DE8", VA = "0x1920DE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	public string text
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1920DF0", Offset = "0x1920DF0", VA = "0x1920DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public string[] filenames
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1920E28", Offset = "0x1920E28", VA = "0x1920E28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public DateTime timestamp
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1920EEC", Offset = "0x1920EEC", VA = "0x1920EEC")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1920D34", Offset = "0x1920D34", VA = "0x1920D34")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1920D84", Offset = "0x1920D84", VA = "0x1920D84")]
	public ES3Cloud(string url, string apiKey, int timeout)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1921028", Offset = "0x1921028", VA = "0x1921028")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1921168", Offset = "0x1921168", VA = "0x1921168")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x19211F8", Offset = "0x19211F8", VA = "0x19211F8")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x192128C", Offset = "0x192128C", VA = "0x192128C")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1921318", Offset = "0x1921318", VA = "0x1921318")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x19213AC", Offset = "0x19213AC", VA = "0x19213AC")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x192144C", Offset = "0x192144C", VA = "0x192144C")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x19210A8", Offset = "0x19210A8", VA = "0x19210A8")]
	[IteratorStateMachine(typeof(<Sync>d__20))]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1921504", Offset = "0x1921504", VA = "0x1921504")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x19215DC", Offset = "0x19215DC", VA = "0x19215DC")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x192167C", Offset = "0x192167C", VA = "0x192167C")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1921720", Offset = "0x1921720", VA = "0x1921720")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x19217B8", Offset = "0x19217B8", VA = "0x19217B8")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x192185C", Offset = "0x192185C", VA = "0x192185C")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x192190C", Offset = "0x192190C", VA = "0x192190C")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x19219A8", Offset = "0x19219A8", VA = "0x19219A8")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1921C3C", Offset = "0x1921C3C", VA = "0x1921C3C")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1921CF8", Offset = "0x1921CF8", VA = "0x1921CF8")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1921594", Offset = "0x1921594", VA = "0x1921594")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1921DA4", Offset = "0x1921DA4", VA = "0x1921DA4")]
	public IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1921B58", Offset = "0x1921B58", VA = "0x1921B58")]
	[IteratorStateMachine(typeof(<UploadFile>d__33))]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password, long fileTimestamp)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1921E24", Offset = "0x1921E24", VA = "0x1921E24")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1921F70", Offset = "0x1921F70", VA = "0x1921F70")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1922004", Offset = "0x1922004", VA = "0x1922004")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x192209C", Offset = "0x192209C", VA = "0x192209C")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x192212C", Offset = "0x192212C", VA = "0x192212C")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x19221C4", Offset = "0x19221C4", VA = "0x19221C4")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1922268", Offset = "0x1922268", VA = "0x1922268")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x19222FC", Offset = "0x19222FC", VA = "0x19222FC")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1922424", Offset = "0x1922424", VA = "0x1922424")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1922488", Offset = "0x1922488", VA = "0x1922488")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x192235C", Offset = "0x192235C", VA = "0x192235C")]
	[IteratorStateMachine(typeof(<DownloadFile>d__44))]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1921EA8", Offset = "0x1921EA8", VA = "0x1921EA8")]
	[IteratorStateMachine(typeof(<DownloadFile>d__45))]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x19224E0", Offset = "0x19224E0", VA = "0x19224E0")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1922620", Offset = "0x1922620", VA = "0x1922620")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x19226B0", Offset = "0x19226B0", VA = "0x19226B0")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1922744", Offset = "0x1922744", VA = "0x1922744")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x19227D0", Offset = "0x19227D0", VA = "0x19227D0")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1922864", Offset = "0x1922864", VA = "0x1922864")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1922904", Offset = "0x1922904", VA = "0x1922904")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1922560", Offset = "0x1922560", VA = "0x1922560")]
	[IteratorStateMachine(typeof(<DeleteFile>d__53))]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x19229BC", Offset = "0x19229BC", VA = "0x19229BC")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1922B44", Offset = "0x1922B44", VA = "0x1922B44")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1922C04", Offset = "0x1922C04", VA = "0x1922C04")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1922CB4", Offset = "0x1922CB4", VA = "0x1922CB4")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1922D74", Offset = "0x1922D74", VA = "0x1922D74")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1922E38", Offset = "0x1922E38", VA = "0x1922E38")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1922A70", Offset = "0x1922A70", VA = "0x1922A70")]
	[IteratorStateMachine(typeof(<RenameFile>d__60))]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1922F1C", Offset = "0x1922F1C", VA = "0x1922F1C")]
	[IteratorStateMachine(typeof(<DownloadFilenames>d__61))]
	public IEnumerator DownloadFilenames(string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1922FE8", Offset = "0x1922FE8", VA = "0x1922FE8")]
	[IteratorStateMachine(typeof(<SearchFilenames>d__62))]
	public IEnumerator SearchFilenames(string searchPattern, string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x19230D0", Offset = "0x19230D0", VA = "0x19230D0")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1923210", Offset = "0x1923210", VA = "0x1923210")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x19232A0", Offset = "0x19232A0", VA = "0x19232A0")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1923334", Offset = "0x1923334", VA = "0x1923334")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x19233C0", Offset = "0x19233C0", VA = "0x19233C0")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1923454", Offset = "0x1923454", VA = "0x1923454")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x19234F4", Offset = "0x19234F4", VA = "0x19234F4")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1923150", Offset = "0x1923150", VA = "0x1923150")]
	[IteratorStateMachine(typeof(<DownloadTimestamp>d__70))]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1921A60", Offset = "0x1921A60", VA = "0x1921A60")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x19235AC", Offset = "0x19235AC", VA = "0x19235AC")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x19235C4", Offset = "0x19235C4", VA = "0x19235C4", Slot = "4")]
	protected override void Reset()
	{
	}
}
[Token(Token = "0x200002A")]
public abstract class ES3Writer : IDisposable
{
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HashSet<string> keysToDelete;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool writeHeaderAndFooter;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	internal bool overwriteKeys;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int serializationDepth;

	[Token(Token = "0x60001D9")]
	internal abstract void WriteNull();

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1925864", Offset = "0x1925864", VA = "0x1925864", Slot = "6")]
	internal virtual void StartWriteFile()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1925874", Offset = "0x1925874", VA = "0x1925874", Slot = "7")]
	internal virtual void EndWriteFile()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1925884", Offset = "0x1925884", VA = "0x1925884", Slot = "8")]
	internal virtual void StartWriteObject(string name)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1925894", Offset = "0x1925894", VA = "0x1925894", Slot = "9")]
	internal virtual void EndWriteObject(string name)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x19258A4", Offset = "0x19258A4", VA = "0x19258A4", Slot = "10")]
	internal virtual void StartWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x192596C", Offset = "0x192596C", VA = "0x192596C", Slot = "11")]
	internal virtual void EndWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1925970", Offset = "0x1925970", VA = "0x1925970", Slot = "12")]
	internal virtual void StartWriteCollection()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1925980", Offset = "0x1925980", VA = "0x1925980", Slot = "13")]
	internal virtual void EndWriteCollection()
	{
	}

	[Token(Token = "0x60001E2")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x60001E3")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x60001E4")]
	internal abstract void StartWriteDictionary();

	[Token(Token = "0x60001E5")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x60001E6")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x60001E7")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x60001E8")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x60001E9")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x60001EA")]
	public abstract void Dispose();

	[Token(Token = "0x60001EB")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x60001EC")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x60001ED")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x60001EE")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x60001EF")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x60001F0")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x60001F1")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x60001F2")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x60001F3")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x60001F4")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x60001F5")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x60001F6")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x60001F7")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x60001F8")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x60001F9")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x60001FA")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1925990", Offset = "0x1925990", VA = "0x1925990")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1925A64", Offset = "0x1925A64", VA = "0x1925A64", Slot = "39")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x60001FD")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1925BE0", Offset = "0x1925BE0", VA = "0x1925BE0", Slot = "41")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1925D10", Offset = "0x1925D10", VA = "0x1925D10", Slot = "42")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1925DD0", Offset = "0x1925DD0", VA = "0x1925DD0", Slot = "43")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x192680C", Offset = "0x192680C", VA = "0x192680C", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1926974", Offset = "0x1926974", VA = "0x1926974", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x192699C", Offset = "0x192699C", VA = "0x192699C", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000204")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1926ACC", Offset = "0x1926ACC", VA = "0x1926ACC", Slot = "48")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1926AF4", Offset = "0x1926AF4", VA = "0x1926AF4", Slot = "49")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1926B80", Offset = "0x1926B80", VA = "0x1926B80", Slot = "50")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1926C8C", Offset = "0x1926C8C", VA = "0x1926C8C")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1926E90", Offset = "0x1926E90", VA = "0x1926E90")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1927094", Offset = "0x1927094", VA = "0x1927094")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1927250", Offset = "0x1927250", VA = "0x1927250")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x192740C", Offset = "0x192740C", VA = "0x192740C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x192760C", Offset = "0x192760C", VA = "0x192760C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x1925B4C", Offset = "0x1925B4C", VA = "0x1925B4C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x192780C", Offset = "0x192780C", VA = "0x192780C")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1919F6C", Offset = "0x1919F6C", VA = "0x1919F6C")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x191CE58", Offset = "0x191CE58", VA = "0x191CE58")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1917608", Offset = "0x1917608", VA = "0x1917608")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1926A20", Offset = "0x1926A20", VA = "0x1926A20")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected bool SerializationDepthLimitExceeded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1927888", Offset = "0x1927888", VA = "0x1927888", Slot = "51")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x19278E0", Offset = "0x19278E0", VA = "0x19278E0")]
	protected void Merge()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1927A48", Offset = "0x1927A48", VA = "0x1927A48")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1927DB0", Offset = "0x1927DB0", VA = "0x1927DB0", Slot = "52")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1927DC4", Offset = "0x1927DC4", VA = "0x1927DC4", Slot = "53")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200002B")]
public class ES3XMLWriter
{
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1927E88", Offset = "0x1927E88", VA = "0x1927E88")]
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
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1927E90", Offset = "0x1927E90", VA = "0x1927E90")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1928004", Offset = "0x1928004", VA = "0x1928004", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600021C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200002D")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1928008", Offset = "0x1928008", VA = "0x1928008")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x19280CC", Offset = "0x19280CC", VA = "0x19280CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600021F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1928250", Offset = "0x1928250", VA = "0x1928250")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1928340", Offset = "0x1928340", VA = "0x1928340", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x6000224")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x192855C", Offset = "0x192855C", VA = "0x192855C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x19287B0", Offset = "0x19287B0", VA = "0x19287B0", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1928A94", Offset = "0x1928A94", VA = "0x1928A94")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1928A98", Offset = "0x1928A98", VA = "0x1928A98", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600022A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1928D44", Offset = "0x1928D44", VA = "0x1928D44", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1929058", Offset = "0x1929058", VA = "0x1929058", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000030")]
	[Preserve]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x19293D4", Offset = "0x19293D4", VA = "0x19293D4")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x19293D8", Offset = "0x19293D8", VA = "0x19293D8")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1929448", Offset = "0x1929448", VA = "0x1929448", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x19295C4", Offset = "0x19295C4", VA = "0x19295C4", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1929820", Offset = "0x1929820", VA = "0x1929820", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000031")]
	[Preserve]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type elementType;

		[Token(Token = "0x6000235")]
		public abstract object Read(ES3Reader reader);

		[Token(Token = "0x6000236")]
		public abstract void ReadInto(ES3Reader reader, object obj);

		[Token(Token = "0x6000237")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1928254", Offset = "0x1928254", VA = "0x1928254")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1929410", Offset = "0x1929410", VA = "0x1929410")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1929E64", Offset = "0x1929E64", VA = "0x1929E64", Slot = "4")]
		[Preserve]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600023B")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1929E74", Offset = "0x1929E74", VA = "0x1929E74", Slot = "12")]
		[Preserve]
		protected virtual void ReadICollectionInto(ES3Reader reader, ICollection collection, ES3Type elementType)
		{
		}
	}
	[Token(Token = "0x2000032")]
	[Preserve]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type keyType;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ES3Type valueType;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x192A3E0", Offset = "0x192A3E0", VA = "0x192A3E0")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x192A504", Offset = "0x192A504", VA = "0x192A504")]
		public ES3DictionaryType(Type type, ES3Type keyType, ES3Type valueType)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x192A560", Offset = "0x192A560", VA = "0x192A560", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x19263C4", Offset = "0x19263C4", VA = "0x19263C4")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000242")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x192A580", Offset = "0x192A580", VA = "0x192A580")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x192A7B8", Offset = "0x192A7B8", VA = "0x192A7B8")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000033")]
	[Preserve]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x192AB20", Offset = "0x192AB20", VA = "0x192AB20")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x192AB24", Offset = "0x192AB24", VA = "0x192AB24", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000248")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x192B180", Offset = "0x192B180", VA = "0x192B180", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x192B450", Offset = "0x192B450", VA = "0x192B450", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000034")]
	[Preserve]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x192B4A0", Offset = "0x192B4A0", VA = "0x192B4A0")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x192B4A4", Offset = "0x192B4A4", VA = "0x192B4A4")]
		public ES3ListType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x192B4DC", Offset = "0x192B4DC", VA = "0x192B4DC", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600024F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x192B90C", Offset = "0x192B90C", VA = "0x192B90C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x192BAEC", Offset = "0x192BAEC", VA = "0x192BAEC", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000035")]
	[Preserve]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x192C0A4", Offset = "0x192C0A4", VA = "0x192C0A4")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x192C0A8", Offset = "0x192C0A8", VA = "0x192C0A8", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000255")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x192C4B4", Offset = "0x192C4B4", VA = "0x192C4B4", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x192C784", Offset = "0x192C784", VA = "0x192C784", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000036")]
	[Preserve]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x192CD18", Offset = "0x192CD18", VA = "0x192CD18")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x192CD1C", Offset = "0x192CD1C", VA = "0x192CD1C", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600025B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x192D128", Offset = "0x192D128", VA = "0x192D128", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x192D54C", Offset = "0x192D54C", VA = "0x192D54C", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000038")]
	[Preserve]
	public abstract class ES3ComponentType : ES3UnityObjectType
	{
		[Token(Token = "0x40000BC")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x192DB80", Offset = "0x192DB80", VA = "0x192DB80")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x6000263")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x6000264")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x192DBC0", Offset = "0x192DBC0", VA = "0x192DBC0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000266")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000267")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x192DE3C", Offset = "0x192DE3C", VA = "0x192DE3C")]
		private static UnityEngine.Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x192DEE0", Offset = "0x192DEE0", VA = "0x192DEE0")]
		public static UnityEngine.Component CreateComponent(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000039")]
	[Preserve]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x192DFDC", Offset = "0x192DFDC", VA = "0x192DFDC")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x600026C")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x600026D")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x600026E")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x192DFE0", Offset = "0x192DFE0", VA = "0x192DFE0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000270")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200003A")]
	[Preserve]
	public abstract class ES3ScriptableObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x192E28C", Offset = "0x192E28C", VA = "0x192E28C")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000273")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000274")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x192E2AC", Offset = "0x192E2AC", VA = "0x192E2AC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000276")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000277")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200003B")]
	[Preserve]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class ES3Type
	{
		[Token(Token = "0x40000BD")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isEnum;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isReflectedType;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUnsupported;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int priority;

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1927F44", Offset = "0x1927F44", VA = "0x1927F44")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x600027A")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x600027B")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x600027C")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x192E190", Offset = "0x192E190", VA = "0x192E190")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x192E42C", Offset = "0x192E42C", VA = "0x192E42C")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x192E478", Offset = "0x192E478", VA = "0x192E478")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x192E5B8", Offset = "0x192E5B8", VA = "0x192E5B8")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x192E5AC", Offset = "0x192E5AC", VA = "0x192E5AC")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1930124", Offset = "0x1930124", VA = "0x1930124")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x19302C4", Offset = "0x19302C4", VA = "0x19302C4")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x200003D")]
	[Preserve]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x192DBA0", Offset = "0x192DBA0", VA = "0x192DBA0")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x6000286")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000287")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000288")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x19302F4", Offset = "0x19302F4", VA = "0x19302F4", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1930308", Offset = "0x1930308", VA = "0x1930308", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x600028B")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600028C")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1930570", Offset = "0x1930570", VA = "0x1930570")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003E")]
	[ES3Properties(new string[] { "bytes" })]
	[Preserve]
	public class ES3Type_BigInteger : ES3Type
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x19306C8", Offset = "0x19306C8", VA = "0x19306C8")]
		public ES3Type_BigInteger()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x193077C", Offset = "0x193077C", VA = "0x193077C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000290")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	public class ES3Type_BigIntegerArray : ES3ArrayType
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1930860", Offset = "0x1930860", VA = "0x1930860")]
		public ES3Type_BigIntegerArray()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[Preserve]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x193094C", Offset = "0x193094C", VA = "0x193094C")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1930A08", Offset = "0x1930A08", VA = "0x1930A08", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000294")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1930A90", Offset = "0x1930A90", VA = "0x1930A90")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[Preserve]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1930B7C", Offset = "0x1930B7C", VA = "0x1930B7C")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1930C38", Offset = "0x1930C38", VA = "0x1930C38", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000298")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	[Preserve]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1930CC0", Offset = "0x1930CC0", VA = "0x1930CC0")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1930D7C", Offset = "0x1930D7C", VA = "0x1930D7C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600029B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	[Preserve]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1930E04", Offset = "0x1930E04", VA = "0x1930E04")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1930EC0", Offset = "0x1930EC0", VA = "0x1930EC0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600029E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000045")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1930F48", Offset = "0x1930F48", VA = "0x1930F48")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[Preserve]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1931034", Offset = "0x1931034", VA = "0x1931034")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x19310E8", Offset = "0x19310E8", VA = "0x19310E8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002A2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000047")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x19311F8", Offset = "0x19311F8", VA = "0x19311F8")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[Preserve]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x19312E4", Offset = "0x19312E4", VA = "0x19312E4")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x19313A0", Offset = "0x19313A0", VA = "0x19313A0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002A6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000049")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1931428", Offset = "0x1931428", VA = "0x1931428")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[Preserve]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1931514", Offset = "0x1931514", VA = "0x1931514")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x19315D0", Offset = "0x19315D0", VA = "0x19315D0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002AA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004B")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1931658", Offset = "0x1931658", VA = "0x1931658")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[Preserve]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type underlyingType;

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1931744", Offset = "0x1931744", VA = "0x1931744")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1931800", Offset = "0x1931800", VA = "0x1931800", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002AE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	[Preserve]
	public class ES3Type_ES3Ref : ES3Type
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x193227C", Offset = "0x193227C", VA = "0x193227C")]
		public ES3Type_ES3Ref()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1932348", Offset = "0x1932348", VA = "0x1932348", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004E")]
	public class ES3Type_ES3RefArray : ES3ArrayType
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1932460", Offset = "0x1932460", VA = "0x1932460")]
		public ES3Type_ES3RefArray()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class ES3Type_ES3RefDictionary : ES3DictionaryType
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x19325E4", Offset = "0x19325E4", VA = "0x19325E4")]
		public ES3Type_ES3RefDictionary()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[Preserve]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1932750", Offset = "0x1932750", VA = "0x1932750")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x193280C", Offset = "0x193280C", VA = "0x193280C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1932894", Offset = "0x1932894", VA = "0x1932894")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[Preserve]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1932980", Offset = "0x1932980", VA = "0x1932980")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1932A3C", Offset = "0x1932A3C", VA = "0x1932A3C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002BD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000053")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1932AC4", Offset = "0x1932AC4", VA = "0x1932AC4")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[Preserve]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1932BB0", Offset = "0x1932BB0", VA = "0x1932BB0")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1932C6C", Offset = "0x1932C6C", VA = "0x1932C6C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000055")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1932D00", Offset = "0x1932D00", VA = "0x1932D00")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[Preserve]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1932DEC", Offset = "0x1932DEC", VA = "0x1932DEC")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1932EA8", Offset = "0x1932EA8", VA = "0x1932EA8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1932F30", Offset = "0x1932F30", VA = "0x1932F30")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[Preserve]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x193301C", Offset = "0x193301C", VA = "0x193301C")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x19330D8", Offset = "0x19330D8", VA = "0x19330D8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002C9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1933160", Offset = "0x1933160", VA = "0x1933160")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[Preserve]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x193324C", Offset = "0x193324C", VA = "0x193324C")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1933308", Offset = "0x1933308", VA = "0x1933308", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002CD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1933390", Offset = "0x1933390", VA = "0x1933390")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[Preserve]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x193347C", Offset = "0x193347C", VA = "0x193347C")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1933538", Offset = "0x1933538", VA = "0x1933538", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005D")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x19335B4", Offset = "0x19335B4", VA = "0x19335B4")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[Preserve]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x19336A0", Offset = "0x19336A0", VA = "0x19336A0")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x193375C", Offset = "0x193375C", VA = "0x193375C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x19337E4", Offset = "0x19337E4", VA = "0x19337E4")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[Preserve]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x19338D0", Offset = "0x19338D0", VA = "0x19338D0")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x193398C", Offset = "0x193398C", VA = "0x193398C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002D9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000061")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1933A14", Offset = "0x1933A14", VA = "0x1933A14")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[Preserve]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1933B00", Offset = "0x1933B00", VA = "0x1933B00")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1933BBC", Offset = "0x1933BBC", VA = "0x1933BBC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002DD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1933C44", Offset = "0x1933C44", VA = "0x1933C44")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[Preserve]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1933D30", Offset = "0x1933D30", VA = "0x1933D30")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1933DEC", Offset = "0x1933DEC", VA = "0x1933DEC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1933E74", Offset = "0x1933E74", VA = "0x1933E74")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[Preserve]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1933F60", Offset = "0x1933F60", VA = "0x1933F60")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1933F8C", Offset = "0x1933F8C", VA = "0x1933F8C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E5")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000067")]
	[Preserve]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1933F90", Offset = "0x1933F90", VA = "0x1933F90")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1933FB8", Offset = "0x1933FB8", VA = "0x1933FB8", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E8")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000068")]
	[Preserve]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1933FBC", Offset = "0x1933FBC", VA = "0x1933FBC")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1933FE8", Offset = "0x1933FE8", VA = "0x1933FE8", Slot = "14")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002EC")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000069")]
	[Preserve]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1933FEC", Offset = "0x1933FEC", VA = "0x1933FEC")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1934008", Offset = "0x1934008", VA = "0x1934008")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x193403C", Offset = "0x193403C", VA = "0x193403C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
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
	}
	[Token(Token = "0x200006A")]
	[Preserve]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x19343BC", Offset = "0x19343BC", VA = "0x19343BC")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x19343E8", Offset = "0x19343E8", VA = "0x19343E8", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F4")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006B")]
	[Preserve]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x19343EC", Offset = "0x19343EC", VA = "0x19343EC")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1934414", Offset = "0x1934414", VA = "0x1934414", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006C")]
	[Preserve]
	[ES3Properties(new string[] { "center", "size", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1934418", Offset = "0x1934418", VA = "0x1934418")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x19344D8", Offset = "0x19344D8", VA = "0x19344D8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002FC")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006D")]
	[Preserve]
	[ES3Properties(new string[] { "size", "density", "isTrigger", "usedByEffector", "offset", "sharedMaterial", "enabled" })]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1934790", Offset = "0x1934790", VA = "0x1934790")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1934850", Offset = "0x1934850", VA = "0x1934850", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002FF")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006E")]
	[ES3Properties(new string[]
	{
		"fieldOfView", "nearClipPlane", "farClipPlane", "renderingPath", "allowHDR", "orthographicSize", "orthographic", "opaqueSortMode", "transparencySortMode", "depth",
		"aspect", "cullingMask", "eventMask", "backgroundColor", "rect", "pixelRect", "worldToCameraMatrix", "projectionMatrix", "nonJitteredProjectionMatrix", "useJitteredProjectionMatrixForTransparentRendering",
		"clearFlags", "stereoSeparation", "stereoConvergence", "cameraType", "stereoTargetEye", "targetDisplay", "useOcclusionCulling", "cullingMatrix", "layerCullSpherical", "depthTextureMode",
		"clearStencilAfterLightingPass", "enabled", "hideFlags"
	})]
	[Preserve]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1934B98", Offset = "0x1934B98", VA = "0x1934B98")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1934C58", Offset = "0x1934C58", VA = "0x1934C58", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000302")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ES3Properties(new string[] { "center", "radius", "height", "direction", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	[Preserve]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x19367F4", Offset = "0x19367F4", VA = "0x19367F4")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x19368AC", Offset = "0x19368AC", VA = "0x19368AC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000305")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000070")]
	[Preserve]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1936CB4", Offset = "0x1936CB4", VA = "0x1936CB4")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1936D6C", Offset = "0x1936D6C", VA = "0x1936D6C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000308")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000071")]
	[ES3Properties(new string[]
	{
		"sprite", "overrideSprite", "type", "preserveAspect", "fillCenter", "fillMethod", "fillAmount", "fillClockwise", "fillOrigin", "alphaHitTestMinimumThreshold",
		"useSpriteMesh", "pixelsPerUnitMultiplier", "material", "onCullStateChanged", "maskable", "color", "raycastTarget", "useLegacyMeshGeneration", "useGUILayout", "enabled",
		"hideFlags"
	})]
	[Preserve]
	public class ES3Type_Image : ES3ComponentType
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1936D70", Offset = "0x1936D70", VA = "0x1936D70")]
		public ES3Type_Image()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1936E34", Offset = "0x1936E34", VA = "0x1936E34", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600030B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ES3Type_ImageArray : ES3ArrayType
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1937624", Offset = "0x1937624", VA = "0x1937624")]
		public ES3Type_ImageArray()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[Preserve]
	[ES3Properties(new string[] { "sharedMesh", "convex", "inflateMesh", "skinWidth", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x19376FC", Offset = "0x19376FC", VA = "0x19376FC")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x19377B4", Offset = "0x19377B4", VA = "0x19377B4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600030F")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1937AA0", Offset = "0x1937AA0", VA = "0x1937AA0")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[ES3Properties(new string[] { "sharedMesh" })]
	[Preserve]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1937B78", Offset = "0x1937B78", VA = "0x1937B78")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1937C30", Offset = "0x1937C30", VA = "0x1937C30", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000313")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1937CCC", Offset = "0x1937CCC", VA = "0x1937CCC")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"additionalVertexStreams", "enabled", "shadowCastingMode", "receiveShadows", "sharedMaterials", "lightmapIndex", "realtimeLightmapIndex", "lightmapScaleOffset", "motionVectorGenerationMode", "realtimeLightmapScaleOffset",
		"lightProbeUsage", "lightProbeProxyVolumeOverride", "probeAnchor", "reflectionProbeUsage", "sortingLayerName", "sortingLayerID", "sortingOrder"
	})]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1937DA4", Offset = "0x1937DA4", VA = "0x1937DA4")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1937E5C", Offset = "0x1937E5C", VA = "0x1937E5C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000317")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x19385A8", Offset = "0x19385A8", VA = "0x19385A8")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"time", "hideFlags", "collision", "colorBySpeed", "colorOverLifetime", "emission", "externalForces", "forceOverLifetime", "inheritVelocity", "lights",
		"limitVelocityOverLifetime", "main", "noise", "rotatonBySpeed", "rotationOverLifetime", "shape", "sizeBySpeed", "sizeOverLifetime", "subEmitters", "textureSheetAnimation",
		"trails", "trigger", "useAutoRandomSeed", "velocityOverLifetime", "isPaused", "isPlaying", "isStopped"
	})]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1938680", Offset = "0x1938680", VA = "0x1938680")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1938738", Offset = "0x1938738", VA = "0x1938738", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600031B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007A")]
	[Preserve]
	[ES3Properties(new string[] { "points", "pathCount", "paths", "density", "isTrigger", "usedByEffector", "offset", "sharedMaterial", "enabled" })]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1939228", Offset = "0x1939228", VA = "0x1939228")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x19392E0", Offset = "0x19392E0", VA = "0x19392E0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600031E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x19397E8", Offset = "0x19397E8", VA = "0x19397E8")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[ES3Properties(new string[]
	{
		"texture", "uvRect", "onCullStateChanged", "maskable", "color", "raycastTarget", "useLegacyMeshGeneration", "material", "useGUILayout", "enabled",
		"hideFlags"
	})]
	[Preserve]
	public class ES3Type_RawImage : ES3ComponentType
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x19398C0", Offset = "0x19398C0", VA = "0x19398C0")]
		public ES3Type_RawImage()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1939984", Offset = "0x1939984", VA = "0x1939984", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000322")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class ES3Type_RawImageArray : ES3ArrayType
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1939E60", Offset = "0x1939E60", VA = "0x1939E60")]
		public ES3Type_RawImageArray()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"velocity", "angularVelocity", "drag", "angularDrag", "mass", "useGravity", "maxDepenetrationVelocity", "isKinematic", "freezeRotation", "constraints",
		"collisionDetectionMode", "centerOfMass", "inertiaTensorRotation", "inertiaTensor", "detectCollisions", "position", "rotation", "interpolation", "solverIterations", "sleepThreshold",
		"maxAngularVelocity", "solverVelocityIterations"
	})]
	public class ES3Type_Rigidbody : ES3ComponentType
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1939F38", Offset = "0x1939F38", VA = "0x1939F38")]
		public ES3Type_Rigidbody()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1939FFC", Offset = "0x1939FFC", VA = "0x1939FFC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000326")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class ES3UserType_RigidbodyArray : ES3ArrayType
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x193A96C", Offset = "0x193A96C", VA = "0x193A96C")]
		public ES3UserType_RigidbodyArray()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[ES3Properties(new string[] { "center", "radius", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	[Preserve]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x193AA44", Offset = "0x193AA44", VA = "0x193AA44")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x193AAFC", Offset = "0x193AAFC", VA = "0x193AAFC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000081")]
	[ES3Properties(new string[]
	{
		"font", "text", "supportRichText", "resizeTextForBestFit", "resizeTextMinSize", "resizeTextMaxSize", "alignment", "alignByGeometry", "fontSize", "horizontalOverflow",
		"verticalOverflow", "lineSpacing", "fontStyle", "onCullStateChanged", "maskable", "color", "raycastTarget", "material", "useGUILayout", "enabled",
		"tag", "name", "hideFlags"
	})]
	[Preserve]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x193AE28", Offset = "0x193AE28", VA = "0x193AE28")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x193AEE0", Offset = "0x193AEE0", VA = "0x193AEE0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[ES3Properties(new string[] { "localPosition", "localRotation", "localScale", "parent", "siblingIndex" })]
	[Preserve]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int countRead;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ES3Type Instance;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x193B6BC", Offset = "0x193B6BC", VA = "0x193B6BC")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x193B76C", Offset = "0x193B76C", VA = "0x193B76C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000330")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000083")]
	[Preserve]
	[ES3Properties(new string[] { "keys", "preWrapMode", "postWrapMode" })]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x193B9C8", Offset = "0x193B9C8", VA = "0x193B9C8")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x193BA80", Offset = "0x193BA80", VA = "0x193BA80", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000333")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000084")]
	[Preserve]
	[ES3Properties(new string[] { "name", "samples", "channels", "frequency", "sampleData" })]
	public class ES3Type_AudioClip : ES3UnityObjectType
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x193BC24", Offset = "0x193BC24", VA = "0x193BC24")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x193BCDC", Offset = "0x193BCDC", VA = "0x193BCDC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000337")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000338")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000085")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x193BF2C", Offset = "0x193BF2C", VA = "0x193BF2C")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[Preserve]
	[ES3Properties(new string[] { "boneIndex0", "boneIndex1", "boneIndex2", "boneIndex3", "weight0", "weight1", "weight2", "weight3" })]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x193C004", Offset = "0x193C004", VA = "0x193C004")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x193C0BC", Offset = "0x193C0BC", VA = "0x193C0BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600033C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000087")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x193C48C", Offset = "0x193C48C", VA = "0x193C48C")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[Preserve]
	[ES3Properties(new string[] { "center", "size" })]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x193C564", Offset = "0x193C564", VA = "0x193C564")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x193C61C", Offset = "0x193C61C", VA = "0x193C61C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000340")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000089")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x193C79C", Offset = "0x193C79C", VA = "0x193C79C")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[Preserve]
	[ES3Properties(new string[] { "time", "count", "minCount", "maxCount", "cycleCount", "repeatInterval", "probability" })]
	public class ES3Type_Burst : ES3Type
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x193C874", Offset = "0x193C874", VA = "0x193C874")]
		public ES3Type_Burst()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x193C938", Offset = "0x193C938", VA = "0x193C938", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000344")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public class ES3Type_BurstArray : ES3ArrayType
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x193CD24", Offset = "0x193CD24", VA = "0x193CD24")]
		public ES3Type_BurstArray()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "type", "mode", "dampen", "dampenMultiplier", "bounce", "bounceMultiplier", "lifetimeLoss", "lifetimeLossMultiplier", "minKillSpeed",
		"maxKillSpeed", "collidesWith", "enableDynamicColliders", "maxCollisionShapes", "quality", "voxelSize", "radiusScale", "sendCollisionMessages"
	})]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x193CDFC", Offset = "0x193CDFC", VA = "0x193CDFC")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x193CEB4", Offset = "0x193CEB4", VA = "0x193CEB4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000348")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008D")]
	[Preserve]
	[ES3Properties(new string[] { "r", "g", "b", "a" })]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x193D5BC", Offset = "0x193D5BC", VA = "0x193D5BC")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x193D674", Offset = "0x193D674", VA = "0x193D674", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600034C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x193D86C", Offset = "0x193D86C", VA = "0x193D86C")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[Preserve]
	[ES3Properties(new string[] { "r", "g", "b", "a" })]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x193D944", Offset = "0x193D944", VA = "0x193D944")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x193D9FC", Offset = "0x193D9FC", VA = "0x193D9FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000350")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x193DBFC", Offset = "0x193DBFC", VA = "0x193DBFC")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000090")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x193DC20", Offset = "0x193DC20", VA = "0x193DC20")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "color", "range" })]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x193DCF8", Offset = "0x193DCF8", VA = "0x193DCF8")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x193DDB0", Offset = "0x193DDB0", VA = "0x193DDB0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000355")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000092")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "color" })]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x193DFF8", Offset = "0x193DFF8", VA = "0x193DFF8")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x193E0B0", Offset = "0x193E0B0", VA = "0x193E0B0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000359")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000093")]
	[ES3Properties(new string[] { "enabled", "rateOverTime", "rateOverTimeMultiplier", "rateOverDistance", "rateOverDistanceMultiplier" })]
	[Preserve]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x193E270", Offset = "0x193E270", VA = "0x193E270")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x193E328", Offset = "0x193E328", VA = "0x193E328", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600035D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000094")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "multiplier" })]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x193E6C0", Offset = "0x193E6C0", VA = "0x193E6C0")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x193E778", Offset = "0x193E778", VA = "0x193E778", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000361")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000095")]
	[ES3Properties(new string[] { "hideFlags" })]
	[Preserve]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x193E914", Offset = "0x193E914", VA = "0x193E914")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x193E9CC", Offset = "0x193E9CC", VA = "0x193E9CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000365")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x193EAA0", Offset = "0x193EAA0", VA = "0x193EAA0")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[ES3Properties(new string[] { "material", "name" })]
	[Preserve]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x193EB78", Offset = "0x193EB78", VA = "0x193EB78")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x193EC30", Offset = "0x193EC30", VA = "0x193EC30", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600036A")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600036B")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x193ED2C", Offset = "0x193ED2C", VA = "0x193ED2C")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "x", "y", "z", "xMultiplier", "yMultiplier", "zMultiplier", "space", "randomized" })]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x193EE04", Offset = "0x193EE04", VA = "0x193EE04")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x193EEBC", Offset = "0x193EEBC", VA = "0x193EEBC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600036F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009A")]
	[Preserve]
	[ES3Properties(new string[] { "layer", "isStatic", "tag", "name", "hideFlags", "children", "components" })]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x4000122")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x4000123")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool saveChildren;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x193F348", Offset = "0x193F348", VA = "0x193F348")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x193F400", Offset = "0x193F400", VA = "0x193F400", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x6000373")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x193FFAC", Offset = "0x193FFAC", VA = "0x193FFAC")]
		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x19405D4", Offset = "0x19405D4", VA = "0x19405D4")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x193FC08", Offset = "0x193FC08", VA = "0x193FC08")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1940668", Offset = "0x1940668", VA = "0x1940668", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000379")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600037A")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200009C")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x19406EC", Offset = "0x19406EC", VA = "0x19406EC")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[Preserve]
	[ES3Properties(new string[] { "colorKeys", "alphaKeys", "mode" })]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x19407C4", Offset = "0x19407C4", VA = "0x19407C4")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x194087C", Offset = "0x194087C", VA = "0x194087C", Slot = "4")]
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
	[Token(Token = "0x200009E")]
	[ES3Properties(new string[] { "alpha", "time" })]
	[Preserve]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1940A2C", Offset = "0x1940A2C", VA = "0x1940A2C")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1940AE4", Offset = "0x1940AE4", VA = "0x1940AE4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000384")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200009F")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1940C30", Offset = "0x1940C30", VA = "0x1940C30")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[ES3Properties(new string[] { "color", "time" })]
	[Preserve]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1940D08", Offset = "0x1940D08", VA = "0x1940D08")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1940DC0", Offset = "0x1940DC0", VA = "0x1940DC0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000388")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A1")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1940F38", Offset = "0x1940F38", VA = "0x1940F38")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[Preserve]
	[ES3Properties(new string[] { "value" })]
	public class ES3Type_Guid : ES3Type
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1941010", Offset = "0x1941010", VA = "0x1941010")]
		public ES3Type_Guid()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x19410C8", Offset = "0x19410C8", VA = "0x19410C8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600038C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	public class ES3Type_GuidArray : ES3ArrayType
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x19411AC", Offset = "0x19411AC", VA = "0x19411AC")]
		public ES3Type_GuidArray()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "mode", "curve", "curveMultiplier" })]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1941284", Offset = "0x1941284", VA = "0x1941284")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x194133C", Offset = "0x194133C", VA = "0x194133C", Slot = "4")]
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
	[Token(Token = "0x20000A5")]
	[Preserve]
	[ES3Properties(new string[] { "time", "value", "inTangent", "outTangent" })]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x19415D8", Offset = "0x19415D8", VA = "0x19415D8")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1941690", Offset = "0x1941690", VA = "0x1941690", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000394")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A6")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x19418C4", Offset = "0x19418C4", VA = "0x19418C4")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[ES3Properties(new string[] { "colorKeys", "alphaKeys", "mode" })]
	[Preserve]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x194199C", Offset = "0x194199C", VA = "0x194199C")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1941A54", Offset = "0x1941A54", VA = "0x1941A54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000398")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A8")]
	[ES3Properties(new string[]
	{
		"type", "color", "intensity", "bounceIntensity", "shadows", "shadowStrength", "shadowResolution", "shadowCustomResolution", "shadowBias", "shadowNormalBias",
		"shadowNearPlane", "range", "spotAngle", "cookieSize", "cookie", "flare", "renderMode", "cullingMask", "areaSize", "lightmappingMode",
		"enabled", "hideFlags"
	})]
	[Preserve]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1941B64", Offset = "0x1941B64", VA = "0x1941B64")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1941C1C", Offset = "0x1941C1C", VA = "0x1941C1C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600039B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "ratio", "useRandomDistribution", "light", "useParticleColor", "sizeAffectsRange", "alphaAffectsIntensity", "range", "rangeMultiplier", "intensity",
		"intensityMultiplier", "maxLights"
	})]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1942470", Offset = "0x1942470", VA = "0x1942470")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1942528", Offset = "0x1942528", VA = "0x1942528", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600039E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "limitX", "limitXMultiplier", "limitY", "limitYMultiplier", "limitZ", "limitZMultiplier", "limit", "limitMultiplier", "dampen",
		"separateAxes", "space"
	})]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1942ABC", Offset = "0x1942ABC", VA = "0x1942ABC")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1942B74", Offset = "0x1942B74", VA = "0x1942B74", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"duration", "loop", "prewarm", "startDelay", "startDelayMultiplier", "startLifetime", "startLifetimeMultiplier", "startSpeed", "startSpeedMultiplier", "startSize3D",
		"startSize", "startSizeMultiplier", "startSizeX", "startSizeXMultiplier", "startSizeY", "startSizeYMultiplier", "startSizeZ", "startSizeZMultiplier", "startRotation3D", "startRotation",
		"startRotationMultiplier", "startRotationX", "startRotationXMultiplier", "startRotationY", "startRotationYMultiplier", "startRotationZ", "startRotationZMultiplier", "randomizeRotationDirection", "startColor", "gravityModifier",
		"gravityModifierMultiplier", "simulationSpace", "customSimulationSpace", "simulationSpeed", "scalingMode", "playOnAwake", "maxParticles"
	})]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1943114", Offset = "0x1943114", VA = "0x1943114")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x19431CC", Offset = "0x19431CC", VA = "0x19431CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[Preserve]
	[ES3Properties(new string[] { "shader", "renderQueue", "shaderKeywords", "globalIlluminationFlags", "properties" })]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x19440D8", Offset = "0x19440D8", VA = "0x19440D8")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1944190", Offset = "0x1944190", VA = "0x1944190", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AA")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1949FA0", Offset = "0x1949FA0", VA = "0x1949FA0")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[Preserve]
	[ES3Properties(new string[] { "col0", "col1", "col2", "col3" })]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x194A078", Offset = "0x194A078", VA = "0x194A078")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x194A130", Offset = "0x194A130", VA = "0x194A130", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x194A384", Offset = "0x194A384", VA = "0x194A384")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[ES3Properties(new string[]
	{
		"bounds", "subMeshCount", "boneWeights", "bindposes", "vertices", "normals", "tangents", "uv", "uv2", "uv3",
		"uv4", "colors32", "triangles", "subMeshes"
	})]
	[Preserve]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x194A45C", Offset = "0x194A45C", VA = "0x194A45C")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x194A514", Offset = "0x194A514", VA = "0x194A514", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B3")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[ES3Properties(new string[] { "mode", "curveMultiplier", "curveMax", "curveMin", "constantMax", "constantMin", "constant", "curve" })]
	[Preserve]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x194AB4C", Offset = "0x194AB4C", VA = "0x194AB4C")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x194AC04", Offset = "0x194AC04", VA = "0x194AC04", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B7")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[Preserve]
	[ES3Properties(new string[] { "mode", "gradientMax", "gradientMin", "colorMax", "colorMin", "color", "gradient" })]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x194AF8C", Offset = "0x194AF8C", VA = "0x194AF8C")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x194B044", Offset = "0x194B044", VA = "0x194B044", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003BB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B3")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "separateAxes", "strength", "strengthMultiplier", "strengthX", "strengthXMultiplier", "strengthY", "strengthYMultiplier", "strengthZ", "strengthZMultiplier",
		"frequency", "damping", "octaveCount", "octaveMultiplier", "octaveScale", "quality", "scrollSpeed", "scrollSpeedMultiplier", "remapEnabled", "remap",
		"remapMultiplier", "remapX", "remapXMultiplier", "remapY", "remapYMultiplier", "remapZ", "remapZMultiplier"
	})]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x194B398", Offset = "0x194B398", VA = "0x194B398")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x194B450", Offset = "0x194B450", VA = "0x194B450", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003BE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[Preserve]
	[ES3Properties(new string[] { "dynamicFriction", "staticFriction", "bounciness", "frictionCombine", "bounceCombine" })]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x194BF8C", Offset = "0x194BF8C", VA = "0x194BF8C")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x194C044", Offset = "0x194C044", VA = "0x194C044", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C2")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003C3")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x194C2CC", Offset = "0x194C2CC", VA = "0x194C2CC")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[Preserve]
	[ES3Properties(new string[] { "bounciness", "friction" })]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x194C3A4", Offset = "0x194C3A4", VA = "0x194C3A4")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x194C45C", Offset = "0x194C45C", VA = "0x194C45C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C7")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003C8")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B7")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x194C5AC", Offset = "0x194C5AC", VA = "0x194C5AC")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "z", "w" })]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x194C684", Offset = "0x194C684", VA = "0x194C684")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x194C73C", Offset = "0x194C73C", VA = "0x194C73C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003CC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B9")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x194C934", Offset = "0x194C934", VA = "0x194C934")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[ES3Properties(new string[] { "x", "y", "width", "height" })]
	[Preserve]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x194CA0C", Offset = "0x194CA0C", VA = "0x194CA0C")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x194CAC4", Offset = "0x194CAC4", VA = "0x194CAC4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BB")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"anchorMin", "anchorMax", "anchoredPosition", "sizeDelta", "pivot", "offsetMin", "offsetMax", "localPosition", "localRotation", "localScale",
		"parent", "hideFlags"
	})]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x194CCE8", Offset = "0x194CCE8", VA = "0x194CCE8")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x194CDA0", Offset = "0x194CDA0", VA = "0x194CDA0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D3")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[ES3Properties(new string[]
	{
		"width", "height", "dimension", "graphicsFormat", "useMipMap", "vrUsage", "memorylessMode", "format", "stencilFormat", "autoGenerateMips",
		"volumeDepth", "antiAliasing", "bindTextureMS", "enableRandomWrite", "useDynamicScale", "isPowerOfTwo", "depth", "descriptor", "masterTextureLimit", "anisotropicFiltering",
		"wrapMode", "wrapModeU", "wrapModeV", "wrapModeW", "filterMode", "anisoLevel", "mipMapBias", "imageContentsHash", "streamingTextureForceLoadAll", "streamingTextureDiscardUnusedMips",
		"allowThreadedTextureCreation", "name"
	})]
	[Preserve]
	public class ES3Type_RenderTexture : ES3ObjectType
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x194D2C4", Offset = "0x194D2C4", VA = "0x194D2C4")]
		public ES3Type_RenderTexture()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x194D37C", Offset = "0x194D37C", VA = "0x194D37C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D6")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003D7")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BD")]
	public class ES3Type_RenderTextureArray : ES3ArrayType
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x194DA48", Offset = "0x194DA48", VA = "0x194DA48")]
		public ES3Type_RenderTextureArray()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[ES3Properties(new string[] { "enabled", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes", "range" })]
	[Preserve]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x194DB20", Offset = "0x194DB20", VA = "0x194DB20")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x194DBD8", Offset = "0x194DBD8", VA = "0x194DBD8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes" })]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x194E070", Offset = "0x194E070", VA = "0x194E070")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x194E128", Offset = "0x194E128", VA = "0x194E128", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[Preserve]
	[ES3Properties(new string[] { "name", "maximumLOD" })]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x194E550", Offset = "0x194E550", VA = "0x194E550")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x194E608", Offset = "0x194E608", VA = "0x194E608", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x194E760", Offset = "0x194E760", VA = "0x194E760")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "shapeType", "randomDirectionAmount", "sphericalDirectionAmount", "alignToDirection", "radius", "angle", "length", "box", "meshShapeType",
		"mesh", "meshRenderer", "skinnedMeshRenderer", "useMeshMaterialIndex", "meshMaterialIndex", "useMeshColors", "normalOffset", "meshScale", "arc"
	})]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x194E838", Offset = "0x194E838", VA = "0x194E838")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x194E8F0", Offset = "0x194E8F0", VA = "0x194E8F0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "size", "sizeMultiplier", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes",
		"range"
	})]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x194F058", Offset = "0x194F058", VA = "0x194F058")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x194F110", Offset = "0x194F110", VA = "0x194F110", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003EC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "size", "sizeMultiplier", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes" })]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x194F66C", Offset = "0x194F66C", VA = "0x194F66C")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x194F724", Offset = "0x194F724", VA = "0x194F724", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"bones", "rootBone", "quality", "sharedMesh", "updateWhenOffscreen", "skinnedMotionVectors", "localBounds", "enabled", "shadowCastingMode", "receiveShadows",
		"sharedMaterials", "lightmapIndex", "realtimeLightmapIndex", "lightmapScaleOffset", "motionVectorGenerationMode", "realtimeLightmapScaleOffset", "lightProbeUsage", "lightProbeProxyVolumeOverride", "probeAnchor", "reflectionProbeUsage",
		"sortingLayerName", "sortingLayerID", "sortingOrder"
	})]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x194FC10", Offset = "0x194FC10", VA = "0x194FC10")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x194FCC8", Offset = "0x194FCC8", VA = "0x194FCC8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F4")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1950708", Offset = "0x1950708", VA = "0x1950708")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[ES3Properties(new string[] { "texture", "rect", "pivot", "pixelsPerUnit", "border" })]
	[Preserve]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x19507E0", Offset = "0x19507E0", VA = "0x19507E0")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1950898", Offset = "0x1950898", VA = "0x1950898", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F8")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003F9")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C8")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"sprite", "color", "flipX", "flipY", "enabled", "shadowCastingMode", "receiveShadows", "sharedMaterials", "lightmapIndex", "realtimeLightmapIndex",
		"lightmapScaleOffset", "motionVectorGenerationMode", "realtimeLightmapScaleOffset", "lightProbeUsage", "lightProbeProxyVolumeOverride", "probeAnchor", "reflectionProbeUsage", "sortingLayerName", "sortingLayerID", "sortingOrder"
	})]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1950BF4", Offset = "0x1950BF4", VA = "0x1950BF4")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1950CAC", Offset = "0x1950CAC", VA = "0x1950CAC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FC")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x19514FC", Offset = "0x19514FC", VA = "0x19514FC")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[Preserve]
	[ES3Properties(new string[] { "properties", "systems", "types" })]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x19515D4", Offset = "0x19515D4", VA = "0x19515D4")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x195168C", Offset = "0x195168C", VA = "0x195168C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000400")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[Preserve]
	[ES3Properties(new string[] { "filterMode", "anisoLevel", "wrapMode", "mipMapBias", "rawTextureData" })]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1951940", Offset = "0x1951940", VA = "0x1951940")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x19519F8", Offset = "0x19519F8", VA = "0x19519F8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000404")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000405")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CC")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1951B8C", Offset = "0x1951B8C", VA = "0x1951B8C")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[Preserve]
	[ES3Properties(new string[] { "filterMode", "anisoLevel", "wrapMode", "mipMapBias", "rawTextureData" })]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1951C64", Offset = "0x1951C64", VA = "0x1951C64")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1951D1C", Offset = "0x1951D1C", VA = "0x1951D1C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000409")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600040A")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x19521A4", Offset = "0x19521A4", VA = "0x19521A4")]
		protected bool IsReadable(Texture2D instance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000CE")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x19523B0", Offset = "0x19523B0", VA = "0x19523B0")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "numTilesX", "numTilesY", "animation", "useRandomRow", "frameOverTime", "frameOverTimeMultiplier", "startFrame", "startFrameMultiplier", "cycleCount",
		"rowIndex", "uvChannelMask", "flipU", "flipV"
	})]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1952488", Offset = "0x1952488", VA = "0x1952488")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1952540", Offset = "0x1952540", VA = "0x1952540", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600040F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[ES3Properties(new string[]
	{
		"enabled", "ratio", "lifetime", "lifetimeMultiplier", "minVertexDistance", "textureMode", "worldSpace", "dieWithParticles", "sizeAffectsWidth", "sizeAffectsLifetime",
		"inheritParticleColor", "colorOverLifetime", "widthOverTrail", "widthOverTrailMultiplier", "colorOverTrail"
	})]
	[Preserve]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1952B00", Offset = "0x1952B00", VA = "0x1952B00")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1952BB8", Offset = "0x1952BB8", VA = "0x1952BB8", Slot = "4")]
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
	[Token(Token = "0x20000D1")]
	[ES3Properties(new string[] { "enabled", "inside", "outside", "enter", "exit", "radiusScale" })]
	[Preserve]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x19532C8", Offset = "0x19532C8", VA = "0x19532C8")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1953380", Offset = "0x1953380", VA = "0x1953380", Slot = "4")]
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
	[Token(Token = "0x20000D2")]
	[ES3Properties(new string[] { "x", "y" })]
	[Preserve]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1953680", Offset = "0x1953680", VA = "0x1953680")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1953738", Offset = "0x1953738", VA = "0x1953738", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600041B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D3")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1953884", Offset = "0x1953884", VA = "0x1953884")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y" })]
	public class ES3Type_Vector2Int : ES3Type
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x195395C", Offset = "0x195395C", VA = "0x195395C")]
		public ES3Type_Vector2Int()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1953A14", Offset = "0x1953A14", VA = "0x1953A14", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600041F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D5")]
	public class ES3Type_Vector2IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1953B64", Offset = "0x1953B64", VA = "0x1953B64")]
		public ES3Type_Vector2IntArray()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "z" })]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1953C3C", Offset = "0x1953C3C", VA = "0x1953C3C")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1953CF4", Offset = "0x1953CF4", VA = "0x1953CF4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000423")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D7")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1953E98", Offset = "0x1953E98", VA = "0x1953E98")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[ES3Properties(new string[] { "x", "y", "z" })]
	[Preserve]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1953F70", Offset = "0x1953F70", VA = "0x1953F70")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1954028", Offset = "0x1954028", VA = "0x1954028", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000427")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D9")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x19541CC", Offset = "0x19541CC", VA = "0x19541CC")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[ES3Properties(new string[] { "x", "y", "z", "w" })]
	[Preserve]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x19542A4", Offset = "0x19542A4", VA = "0x19542A4")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x195435C", Offset = "0x195435C", VA = "0x195435C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600042B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1954554", Offset = "0x1954554", VA = "0x1954554")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DB")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x195468C", Offset = "0x195468C", VA = "0x195468C")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[Preserve]
	[ES3Properties(new string[] { "enabled", "x", "y", "z", "xMultiplier", "yMultiplier", "zMultiplier", "space" })]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1954764", Offset = "0x1954764", VA = "0x1954764")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x195481C", Offset = "0x195481C", VA = "0x195481C", Slot = "4")]
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
}
namespace ES3Internal
{
	[Token(Token = "0x20000DD")]
	internal static class ES3Debug
	{
		[Token(Token = "0x4000169")]
		private const string disableInfoMsg = "\n<i>To disable these messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Info'</i>";

		[Token(Token = "0x400016A")]
		private const string disableWarningMsg = "\n<i>To disable warnings from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Warnings'</i>";

		[Token(Token = "0x400016B")]
		private const string disableErrorMsg = "\n<i>To disable these error messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Errors'</i>";

		[Token(Token = "0x400016C")]
		private const char indentChar = '-';

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1954C38", Offset = "0x1954C38", VA = "0x1954C38")]
		public static void Log(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x195222C", Offset = "0x195222C", VA = "0x195222C")]
		public static void LogWarning(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1954E44", Offset = "0x1954E44", VA = "0x1954E44")]
		public static void LogError(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1954DE0", Offset = "0x1954DE0", VA = "0x1954DE0")]
		private static string Indent(int size)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DE")]
	public static class ES3Hash
	{
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1954FC8", Offset = "0x1954FC8", VA = "0x1954FC8")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DF")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x6000437")]
		public abstract byte[] Encrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000438")]
		public abstract byte[] Decrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000439")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x600043A")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x19551C4", Offset = "0x19551C4", VA = "0x19551C4")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x19552A4", Offset = "0x19552A4", VA = "0x19552A4")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x400016D")]
		private const int ivSize = 16;

		[Token(Token = "0x400016E")]
		private const int keySize = 16;

		[Token(Token = "0x400016F")]
		private const int pwIterations = 100;

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x19552AC", Offset = "0x19552AC", VA = "0x19552AC", Slot = "4")]
		public override byte[] Encrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x19555CC", Offset = "0x19555CC", VA = "0x19555CC", Slot = "5")]
		public override byte[] Decrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x19558EC", Offset = "0x19558EC", VA = "0x19558EC", Slot = "6")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1955E48", Offset = "0x1955E48", VA = "0x1955E48", Slot = "7")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x19563E0", Offset = "0x19563E0", VA = "0x19563E0")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool disposed;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x19563E8", Offset = "0x19563E8", VA = "0x19563E8")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x19564A4", Offset = "0x19564A4", VA = "0x19564A4", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public struct ES3Data
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1956528", Offset = "0x1956528", VA = "0x1956528")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x19567E8", Offset = "0x19567E8", VA = "0x19567E8")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public static class ES3IO
	{
		[Token(Token = "0x20000E4")]
		public enum ES3FileMode
		{
			[Token(Token = "0x400017C")]
			Read,
			[Token(Token = "0x400017D")]
			Write,
			[Token(Token = "0x400017E")]
			Append
		}

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly string persistentDataPath;

		[Token(Token = "0x4000179")]
		internal const string backupFileSuffix = ".bac";

		[Token(Token = "0x400017A")]
		internal const string temporaryFileSuffix = ".tmp";

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1956818", Offset = "0x1956818", VA = "0x1956818")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x19568E8", Offset = "0x19568E8", VA = "0x19568E8")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1956940", Offset = "0x1956940", VA = "0x1956940")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x19568E0", Offset = "0x19568E0", VA = "0x19568E0")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x19569B4", Offset = "0x19569B4", VA = "0x19569B4")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x19569BC", Offset = "0x19569BC", VA = "0x19569BC")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x19569C4", Offset = "0x19569C4", VA = "0x19569C4")]
		public static void MoveDirectory(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x19569CC", Offset = "0x19569CC", VA = "0x19569CC")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x19569D4", Offset = "0x19569D4", VA = "0x19569D4")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x19569DC", Offset = "0x19569DC", VA = "0x19569DC")]
		public static string GetDirectoryPath(string path, char seperator = '/')
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1956AD4", Offset = "0x1956AD4", VA = "0x1956AD4")]
		public static bool UsesForwardSlash(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1956B28", Offset = "0x1956B28", VA = "0x1956B28")]
		public static string CombinePathAndFilename(string directoryPath, string fileOrDirectoryName)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1956BD4", Offset = "0x1956BD4", VA = "0x1956BD4")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1956D34", Offset = "0x1956D34", VA = "0x1956D34")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1956DAC", Offset = "0x1956DAC", VA = "0x1956DAC")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1956EC0", Offset = "0x1956EC0", VA = "0x1956EC0")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1956EC8", Offset = "0x1956EC8", VA = "0x1956EC8")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1956ED0", Offset = "0x1956ED0", VA = "0x1956ED0")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1957324", Offset = "0x1957324", VA = "0x1957324")]
		public void Awake()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1957830", Offset = "0x1957830", VA = "0x1957830")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x19578A8", Offset = "0x19578A8", VA = "0x19578A8")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x19579C8", Offset = "0x19579C8", VA = "0x19579C8")]
		public Dictionary<string, string> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1957C38", Offset = "0x1957C38", VA = "0x1957C38")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x195797C", Offset = "0x195797C", VA = "0x195797C")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x19581D8", Offset = "0x19581D8", VA = "0x19581D8")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E6")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _lock;

		[Token(Token = "0x4000182")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HashSet<ES3ReferenceMgrBase> mgrs;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Random rng;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ES3RefIdDictionary _refId;

		[Token(Token = "0x17000028")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1957510", Offset = "0x1957510", VA = "0x1957510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public bool IsInitialised
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1958438", Offset = "0x1958438", VA = "0x1958438")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public ES3RefIdDictionary refId
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1958494", Offset = "0x1958494", VA = "0x1958494")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x19586A4", Offset = "0x19586A4", VA = "0x19586A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public ES3GlobalReferences GlobalReferences
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x19586AC", Offset = "0x19586AC", VA = "0x19586AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1958298", Offset = "0x1958298", VA = "0x1958298")]
		public static ES3ReferenceMgrBase GetManagerFromScene(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x19586BC", Offset = "0x19586BC", VA = "0x19586BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x19589FC", Offset = "0x19589FC", VA = "0x19589FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x19588A8", Offset = "0x19588A8", VA = "0x19588A8")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1958A7C", Offset = "0x1958A7C", VA = "0x1958A7C")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1958CDC", Offset = "0x1958CDC", VA = "0x1958CDC")]
		internal UnityEngine.Object Get(long id, Type type, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1959294", Offset = "0x1959294", VA = "0x1959294")]
		public UnityEngine.Object Get(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x19592A0", Offset = "0x19592A0", VA = "0x19592A0")]
		public ES3Prefab GetPrefab(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1959674", Offset = "0x1959674", VA = "0x1959674")]
		public long GetPrefab(ES3Prefab prefabToFind, bool suppressWarnings = false)
		{
			return default(long);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1957694", Offset = "0x1957694", VA = "0x1957694")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1957E7C", Offset = "0x1957E7C", VA = "0x1957E7C")]
		public long Add(UnityEngine.Object obj, long id)
		{
			return default(long);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1959A54", Offset = "0x1959A54", VA = "0x1959A54")]
		public bool AddPrefab(ES3Prefab prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1959B3C", Offset = "0x1959B3C", VA = "0x1959B3C")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x195A070", Offset = "0x195A070", VA = "0x195A070")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x195A59C", Offset = "0x195A59C", VA = "0x195A59C")]
		public void RemoveNullOrInvalidValues()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x195A8F0", Offset = "0x195A8F0", VA = "0x195A8F0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x195AA14", Offset = "0x195AA14", VA = "0x195AA14")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x195AA70", Offset = "0x195AA70", VA = "0x195AA70")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x195AAC8", Offset = "0x195AAC8", VA = "0x195AAC8")]
		public void ChangeId(long oldId, long newId)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1958050", Offset = "0x1958050", VA = "0x1958050")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1957974", Offset = "0x1957974", VA = "0x1957974")]
		internal static bool CanBeSaved(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x195ACD4", Offset = "0x195ACD4", VA = "0x195ACD4")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EA")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x195B0D8", Offset = "0x195B0D8", VA = "0x195B0D8", Slot = "44")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x195B0E4", Offset = "0x195B0E4", VA = "0x195B0E4", Slot = "45")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x195ADD0", Offset = "0x195ADD0", VA = "0x195ADD0")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EB")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x195B14C", Offset = "0x195B14C", VA = "0x195B14C", Slot = "44")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x195B1B4", Offset = "0x195B1B4", VA = "0x195B1B4", Slot = "45")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1958250", Offset = "0x1958250", VA = "0x1958250")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public static class ES3Reflection
	{
		[Token(Token = "0x20000ED")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x1700002D")]
			public bool IsNull
			{
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0x195F4CC", Offset = "0x195F4CC", VA = "0x195F4CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002E")]
			public string Name
			{
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0x195F508", Offset = "0x195F508", VA = "0x195F508")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			public Type MemberType
			{
				[Token(Token = "0x60004B6")]
				[Address(RVA = "0x195F538", Offset = "0x195F538", VA = "0x195F538")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			public bool IsPublic
			{
				[Token(Token = "0x60004B7")]
				[Address(RVA = "0x195F57C", Offset = "0x195F57C", VA = "0x195F57C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000031")]
			public bool IsProtected
			{
				[Token(Token = "0x60004B8")]
				[Address(RVA = "0x195F608", Offset = "0x195F608", VA = "0x195F608")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool IsStatic
			{
				[Token(Token = "0x60004B9")]
				[Address(RVA = "0x195F658", Offset = "0x195F658", VA = "0x195F658")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x195CF8C", Offset = "0x195CF8C", VA = "0x195CF8C")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x195F6A8", Offset = "0x195F6A8", VA = "0x195F6A8")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x195F6EC", Offset = "0x195F6EC", VA = "0x195F6EC")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x20000EE")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x195D990", Offset = "0x195D990", VA = "0x195D990")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x195F738", Offset = "0x195F738", VA = "0x195F738")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes, BindingFlags bindingAttr)
			{
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x195F7C8", Offset = "0x195F7C8", VA = "0x195F7C8")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x4000191")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x4000192")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x4000193")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] excludedPropertyNames;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Type es3SerializableAttributeType;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Type es3NonSerializableAttributeType;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x1700002C")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x195B1C0", Offset = "0x195B1C0", VA = "0x195B1C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x195B4C4", Offset = "0x195B4C4", VA = "0x195B4C4")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x195B66C", Offset = "0x195B66C", VA = "0x195B66C")]
		public static List<FieldInfo> GetSerializableFields(Type type, [Optional] List<FieldInfo> serializableFields, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x195BFBC", Offset = "0x195BFBC", VA = "0x195BFBC")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, [Optional] List<PropertyInfo> serializableProperties, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x195BCA0", Offset = "0x195BCA0", VA = "0x195BCA0")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x195C818", Offset = "0x195C818", VA = "0x195C818")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x195C988", Offset = "0x195C988", VA = "0x195C988")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x195CB00", Offset = "0x195CB00", VA = "0x195CB00")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x195CB7C", Offset = "0x195CB7C", VA = "0x195CB7C")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x195CB84", Offset = "0x195CB84", VA = "0x195CB84")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x195CC40", Offset = "0x195CC40", VA = "0x195CC40")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x195D1B4", Offset = "0x195D1B4", VA = "0x195D1B4")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x195D370", Offset = "0x195D370", VA = "0x195D370")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x6000497")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x195D534", Offset = "0x195D534", VA = "0x195D534")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x195BC80", Offset = "0x195BC80", VA = "0x195BC80")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x195D8A8", Offset = "0x195D8A8", VA = "0x195D8A8")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x195B62C", Offset = "0x195B62C", VA = "0x195B62C")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x195D8C8", Offset = "0x195D8C8", VA = "0x195D8C8")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x195D8E8", Offset = "0x195D8E8", VA = "0x195D8E8")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x195D908", Offset = "0x195D908", VA = "0x195D908")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x195C718", Offset = "0x195C718", VA = "0x195C718")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x195B64C", Offset = "0x195B64C", VA = "0x195B64C")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x195DA08", Offset = "0x195DA08", VA = "0x195DA08")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x195DA1C", Offset = "0x195DA1C", VA = "0x195DA1C")]
		public static bool IsInterface(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x195B60C", Offset = "0x195B60C", VA = "0x195B60C")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x195C704", Offset = "0x195C704", VA = "0x195C704")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x195DA30", Offset = "0x195DA30", VA = "0x195DA30")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x195C72C", Offset = "0x195C72C", VA = "0x195C72C")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x195DA50", Offset = "0x195DA50", VA = "0x195DA50")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x195DABC", Offset = "0x195DABC", VA = "0x195DABC")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x195D230", Offset = "0x195D230", VA = "0x195D230")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x195D3EC", Offset = "0x195D3EC", VA = "0x195D3EC")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x195DB9C", Offset = "0x195DB9C", VA = "0x195DB9C")]
		public static MethodInfo[] GetMethods(Type type, string methodName)
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x195C614", Offset = "0x195C614", VA = "0x195C614")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x195BC74", Offset = "0x195BC74", VA = "0x195BC74")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x195C5F4", Offset = "0x195C5F4", VA = "0x195C5F4")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x195DCB8", Offset = "0x195DCB8", VA = "0x195DCB8")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x195BF9C", Offset = "0x195BF9C", VA = "0x195BF9C")]
		public static Type BaseType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x195DD4C", Offset = "0x195DD4C", VA = "0x195DD4C")]
		public static Type GetType(string typeString)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x195E708", Offset = "0x195E708", VA = "0x195E708")]
		public static string GetTypeString(Type type)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x60004C9")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x60004CA")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x60004CB")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60004CC")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60004CD")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x60004CE")]
		public bool ChangeKey(TKey oldKey, TKey newKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x40001AC")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamReader baseReader;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x195FA08", Offset = "0x195FA08", VA = "0x195FA08")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x195FC30", Offset = "0x195FC30", VA = "0x195FC30", Slot = "21")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1960184", Offset = "0x1960184", VA = "0x1960184", Slot = "22")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1960320", Offset = "0x1960320", VA = "0x1960320", Slot = "23")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1960330", Offset = "0x1960330", VA = "0x1960330", Slot = "27")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1960624", Offset = "0x1960624", VA = "0x1960624", Slot = "28")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1960644", Offset = "0x1960644", VA = "0x1960644", Slot = "29")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1960654", Offset = "0x1960654", VA = "0x1960654", Slot = "30")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1960658", Offset = "0x1960658", VA = "0x1960658", Slot = "31")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1960690", Offset = "0x1960690", VA = "0x1960690", Slot = "32")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1960698", Offset = "0x1960698", VA = "0x1960698", Slot = "33")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x196069C", Offset = "0x196069C", VA = "0x196069C", Slot = "34")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1960760", Offset = "0x1960760", VA = "0x1960760", Slot = "35")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1960768", Offset = "0x1960768", VA = "0x1960768", Slot = "36")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x196076C", Offset = "0x196076C", VA = "0x196076C", Slot = "37")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x19607A4", Offset = "0x19607A4", VA = "0x19607A4", Slot = "38")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1960868", Offset = "0x1960868", VA = "0x1960868")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x196098C", Offset = "0x196098C", VA = "0x196098C", Slot = "24")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1960934", Offset = "0x1960934", VA = "0x1960934")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x195FE80", Offset = "0x195FE80", VA = "0x195FE80")]
		private char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
		{
			return default(char);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1960350", Offset = "0x1960350", VA = "0x1960350")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x195FF7C", Offset = "0x195FF7C", VA = "0x195FF7C")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1960F38", Offset = "0x1960F38", VA = "0x1960F38")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1961114", Offset = "0x1961114", VA = "0x1961114")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x195FDF8", Offset = "0x195FDF8", VA = "0x195FDF8")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1961318", Offset = "0x1961318", VA = "0x1961318")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x195FB80", Offset = "0x195FB80", VA = "0x195FB80")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1960F00", Offset = "0x1960F00", VA = "0x1960F00")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1960E7C", Offset = "0x1960E7C", VA = "0x1960E7C")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1960E90", Offset = "0x1960E90", VA = "0x1960E90")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x195FE6C", Offset = "0x195FE6C", VA = "0x195FE6C")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x195FF54", Offset = "0x195FF54", VA = "0x195FF54")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x196138C", Offset = "0x196138C", VA = "0x196138C")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x196139C", Offset = "0x196139C", VA = "0x196139C")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x196145C", Offset = "0x196145C", VA = "0x196145C", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x19615FC", Offset = "0x19615FC", VA = "0x19615FC", Slot = "20")]
		internal override long Read_ref()
		{
			return default(long);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1961730", Offset = "0x1961730", VA = "0x1961730", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x19617A4", Offset = "0x19617A4", VA = "0x19617A4", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1961818", Offset = "0x1961818", VA = "0x1961818", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x196182C", Offset = "0x196182C", VA = "0x196182C", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1961894", Offset = "0x1961894", VA = "0x1961894", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1961934", Offset = "0x1961934", VA = "0x1961934", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x19619A8", Offset = "0x19619A8", VA = "0x19619A8", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x19619BC", Offset = "0x19619BC", VA = "0x19619BC", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x19619D0", Offset = "0x19619D0", VA = "0x19619D0", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x19619E4", Offset = "0x19619E4", VA = "0x19619E4", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x19619FC", Offset = "0x19619FC", VA = "0x19619FC", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1961A14", Offset = "0x1961A14", VA = "0x1961A14", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1961A2C", Offset = "0x1961A2C", VA = "0x1961A2C", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1961A44", Offset = "0x1961A44", VA = "0x1961A44", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1961AB8", Offset = "0x1961AB8", VA = "0x1961AB8", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class ES3GlobalReferences : ScriptableObject
	{
		[Token(Token = "0x17000033")]
		public static ES3GlobalReferences Instance
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x19586B4", Offset = "0x19586B4", VA = "0x19586B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x195928C", Offset = "0x195928C", VA = "0x195928C")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1959A4C", Offset = "0x1959A4C", VA = "0x1959A4C")]
		public long GetOrAdd(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x195A8EC", Offset = "0x195A8EC", VA = "0x195A8EC")]
		public void RemoveInvalidKeys()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1961AD4", Offset = "0x1961AD4", VA = "0x1961AD4")]
		public ES3GlobalReferences()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoUpdateReferences;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1961ADC", Offset = "0x1961ADC", VA = "0x1961ADC")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public enum ES3FileMode
	{
		[Token(Token = "0x40001B1")]
		Read,
		[Token(Token = "0x40001B2")]
		Write,
		[Token(Token = "0x40001B3")]
		Append
	}
	[Token(Token = "0x20000F8")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1961AEC", Offset = "0x1961AEC", VA = "0x1961AEC")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1961BB0", Offset = "0x1961BB0", VA = "0x1961BB0")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1961CA0", Offset = "0x1961CA0", VA = "0x1961CA0")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1961CC0", Offset = "0x1961CC0", VA = "0x1961CC0")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1961CD0", Offset = "0x1961CD0", VA = "0x1961CD0", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1961CF0", Offset = "0x1961CF0", VA = "0x1961CF0")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1961E2C", Offset = "0x1961E2C", VA = "0x1961E2C")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1961D3C", Offset = "0x1961D3C", VA = "0x1961D3C")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1961E74", Offset = "0x1961E74", VA = "0x1961E74", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x17000034")]
		public bool Exists
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x19620F0", Offset = "0x19620F0", VA = "0x19620F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1962110", Offset = "0x1962110", VA = "0x1962110")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1962134", Offset = "0x1962134", VA = "0x1962134")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1962228", Offset = "0x1962228", VA = "0x1962228", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public static class ES3Stream
	{
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1962234", Offset = "0x1962234", VA = "0x1962234")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x19626F0", Offset = "0x19626F0", VA = "0x19626F0")]
		public static Stream CreateStream(Stream stream, ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1962AC4", Offset = "0x1962AC4", VA = "0x1962AC4")]
		public static void CopyTo(Stream source, Stream destination)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class ES3Member
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1962AD8", Offset = "0x1962AD8", VA = "0x1962AD8")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1962B30", Offset = "0x1962B30", VA = "0x1962B30")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[Preserve]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ES3Type lastAccessedType;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x19565EC", Offset = "0x19565EC", VA = "0x19565EC")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1963840", Offset = "0x1963840", VA = "0x1963840")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1963920", Offset = "0x1963920", VA = "0x1963920")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1962E10", Offset = "0x1962E10", VA = "0x1962E10")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1962BB4", Offset = "0x1962BB4", VA = "0x1962BB4")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class ES3WebClass
	{
		[Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class <SendWebRequest>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3WebClass <>4__this;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x1964308", Offset = "0x1964308", VA = "0x1964308", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000535")]
				[Address(RVA = "0x1964350", Offset = "0x1964350", VA = "0x1964350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x196423C", Offset = "0x196423C", VA = "0x196423C")]
			[DebuggerHidden]
			public <SendWebRequest>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x196428C", Offset = "0x196428C", VA = "0x196428C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1964290", Offset = "0x1964290", VA = "0x1964290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1964310", Offset = "0x1964310", VA = "0x1964310", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityWebRequest _webRequest;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isDone;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string error;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long errorCode;

		[Token(Token = "0x17000035")]
		public float uploadProgress
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x1963B78", Offset = "0x1963B78", VA = "0x1963B78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public float downloadProgress
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x1963B90", Offset = "0x1963B90", VA = "0x1963B90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public bool isError
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x1963BA8", Offset = "0x1963BA8", VA = "0x1963BA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1963BDC", Offset = "0x1963BDC", VA = "0x1963BDC")]
		public static bool IsNetworkError(UnityWebRequest www)
		{
			return default(bool);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1963C00", Offset = "0x1963C00", VA = "0x1963C00")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1963CB8", Offset = "0x1963CB8", VA = "0x1963CB8")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1963DAC", Offset = "0x1963DAC", VA = "0x1963DAC")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1963E38", Offset = "0x1963E38", VA = "0x1963E38")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1963FC4", Offset = "0x1963FC4", VA = "0x1963FC4")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x19641AC", Offset = "0x19641AC", VA = "0x19641AC")]
		[IteratorStateMachine(typeof(<SendWebRequest>d__19))]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1964264", Offset = "0x1964264", VA = "0x1964264", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x2000100")]
	internal enum ES3SpecialByte : byte
	{
		[Token(Token = "0x40001CD")]
		Null = 0,
		[Token(Token = "0x40001CE")]
		Bool = 1,
		[Token(Token = "0x40001CF")]
		Byte = 2,
		[Token(Token = "0x40001D0")]
		Sbyte = 3,
		[Token(Token = "0x40001D1")]
		Char = 4,
		[Token(Token = "0x40001D2")]
		Decimal = 5,
		[Token(Token = "0x40001D3")]
		Double = 6,
		[Token(Token = "0x40001D4")]
		Float = 7,
		[Token(Token = "0x40001D5")]
		Int = 8,
		[Token(Token = "0x40001D6")]
		Uint = 9,
		[Token(Token = "0x40001D7")]
		Long = 10,
		[Token(Token = "0x40001D8")]
		Ulong = 11,
		[Token(Token = "0x40001D9")]
		Short = 12,
		[Token(Token = "0x40001DA")]
		Ushort = 13,
		[Token(Token = "0x40001DB")]
		String = 14,
		[Token(Token = "0x40001DC")]
		ByteArray = 15,
		[Token(Token = "0x40001DD")]
		Collection = 128,
		[Token(Token = "0x40001DE")]
		Dictionary = 129,
		[Token(Token = "0x40001DF")]
		CollectionItem = 130,
		[Token(Token = "0x40001E0")]
		Object = 254,
		[Token(Token = "0x40001E1")]
		Terminator = byte.MaxValue
	}
	[Token(Token = "0x2000101")]
	internal static class ES3Binary
	{
		[Token(Token = "0x40001E2")]
		internal const string ObjectTerminator = ".";

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<ES3SpecialByte, Type> IdToType;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<Type, ES3SpecialByte> TypeToId;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1964358", Offset = "0x1964358", VA = "0x1964358")]
		internal static ES3SpecialByte TypeToByte(Type type)
		{
			return default(ES3SpecialByte);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x19643FC", Offset = "0x19643FC", VA = "0x19643FC")]
		internal static Type ByteToType(ES3SpecialByte b)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1964450", Offset = "0x1964450", VA = "0x1964450")]
		internal static Type ByteToType(byte b)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1964538", Offset = "0x1964538", VA = "0x1964538")]
		internal static bool IsPrimitive(ES3SpecialByte b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000102")]
	internal class ES3CacheWriter : ES3Writer
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ES3File es3File;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1964BE8", Offset = "0x1964BE8", VA = "0x1964BE8")]
		internal ES3CacheWriter(ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x600053C")]
		public override void Write<T>(string key, object value)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1964C88", Offset = "0x1964C88", VA = "0x1964C88", Slot = "39")]
		internal override void Write(string key, Type type, byte[] value)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1964CD0", Offset = "0x1964CD0", VA = "0x1964CD0", Slot = "41")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void Write(Type type, string key, object value)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1964D38", Offset = "0x1964D38", VA = "0x1964D38", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1964D3C", Offset = "0x1964D3C", VA = "0x1964D3C", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1964D40", Offset = "0x1964D40", VA = "0x1964D40", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1964D44", Offset = "0x1964D44", VA = "0x1964D44", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1964D48", Offset = "0x1964D48", VA = "0x1964D48", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1964D4C", Offset = "0x1964D4C", VA = "0x1964D4C", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1964D50", Offset = "0x1964D50", VA = "0x1964D50", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1964D54", Offset = "0x1964D54", VA = "0x1964D54", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1964D58", Offset = "0x1964D58", VA = "0x1964D58", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1964D5C", Offset = "0x1964D5C", VA = "0x1964D5C", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1964D60", Offset = "0x1964D60", VA = "0x1964D60", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1964D64", Offset = "0x1964D64", VA = "0x1964D64", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1964D68", Offset = "0x1964D68", VA = "0x1964D68", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1964D6C", Offset = "0x1964D6C", VA = "0x1964D6C", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1964D70", Offset = "0x1964D70", VA = "0x1964D70", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1964D74", Offset = "0x1964D74", VA = "0x1964D74", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1964D78", Offset = "0x1964D78", VA = "0x1964D78")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1964D80", Offset = "0x1964D80", VA = "0x1964D80")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1964D84", Offset = "0x1964D84", VA = "0x1964D84", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1964D88", Offset = "0x1964D88", VA = "0x1964D88", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1964D8C", Offset = "0x1964D8C", VA = "0x1964D8C", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1964D90", Offset = "0x1964D90", VA = "0x1964D90", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1964D98", Offset = "0x1964D98", VA = "0x1964D98", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1964D9C", Offset = "0x1964D9C", VA = "0x1964D9C", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1964DA0", Offset = "0x1964DA0", VA = "0x1964DA0", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1964DA4", Offset = "0x1964DA4", VA = "0x1964DA4", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1964DA8", Offset = "0x1964DA8", VA = "0x1964DA8", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1964DAC", Offset = "0x1964DAC", VA = "0x1964DAC", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1964DB0", Offset = "0x1964DB0", VA = "0x1964DB0", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1964DB4", Offset = "0x1964DB4", VA = "0x1964DB4", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1964DB8", Offset = "0x1964DB8", VA = "0x1964DB8", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1964DBC", Offset = "0x1964DBC", VA = "0x1964DBC", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1964DC0", Offset = "0x1964DC0", VA = "0x1964DC0", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1964DC4", Offset = "0x1964DC4", VA = "0x1964DC4", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1964DC8", Offset = "0x1964DC8", VA = "0x1964DC8", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1964DCC", Offset = "0x1964DCC", VA = "0x1964DCC", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000103")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1964DD0", Offset = "0x1964DD0", VA = "0x1964DD0")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1964DDC", Offset = "0x1964DDC", VA = "0x1964DDC")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1964E98", Offset = "0x1964E98", VA = "0x1964E98", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1964EBC", Offset = "0x1964EBC", VA = "0x1964EBC", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1964F6C", Offset = "0x1964F6C", VA = "0x1964F6C", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1964FE8", Offset = "0x1964FE8", VA = "0x1964FE8", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x19650A8", Offset = "0x19650A8", VA = "0x19650A8", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1965158", Offset = "0x1965158", VA = "0x1965158", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x196517C", Offset = "0x196517C", VA = "0x196517C", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x19651A0", Offset = "0x19651A0", VA = "0x19651A0", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x19651C4", Offset = "0x19651C4", VA = "0x19651C4", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x196524C", Offset = "0x196524C", VA = "0x196524C", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x19652D4", Offset = "0x19652D4", VA = "0x19652D4", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x196535C", Offset = "0x196535C", VA = "0x196535C", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x19653E4", Offset = "0x19653E4", VA = "0x19653E4", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1965424", Offset = "0x1965424", VA = "0x1965424", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x19654A0", Offset = "0x19654A0", VA = "0x19654A0", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x19656D4", Offset = "0x19656D4", VA = "0x19656D4", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1965730", Offset = "0x1965730", VA = "0x1965730")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1965760", Offset = "0x1965760", VA = "0x1965760")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x196582C", Offset = "0x196582C", VA = "0x196582C", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x19658C4", Offset = "0x19658C4", VA = "0x19658C4", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1965900", Offset = "0x1965900", VA = "0x1965900", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1965948", Offset = "0x1965948", VA = "0x1965948", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1965A04", Offset = "0x1965A04", VA = "0x1965A04", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1965A0C", Offset = "0x1965A0C", VA = "0x1965A0C", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1965A44", Offset = "0x1965A44", VA = "0x1965A44", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1965A80", Offset = "0x1965A80", VA = "0x1965A80", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1965AB8", Offset = "0x1965AB8", VA = "0x1965AB8", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1965AF0", Offset = "0x1965AF0", VA = "0x1965AF0", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1965B20", Offset = "0x1965B20", VA = "0x1965B20", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1965B24", Offset = "0x1965B24", VA = "0x1965B24", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1965B34", Offset = "0x1965B34", VA = "0x1965B34", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1965B44", Offset = "0x1965B44", VA = "0x1965B44", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1965B74", Offset = "0x1965B74", VA = "0x1965B74", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1965B98", Offset = "0x1965B98", VA = "0x1965B98", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1965B9C", Offset = "0x1965B9C", VA = "0x1965B9C", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1965BA0", Offset = "0x1965BA0", VA = "0x1965BA0", Slot = "22")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x19657A0", Offset = "0x19657A0", VA = "0x19657A0")]
		public void WriteNewlineAndTabs()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000104")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1965BBC", Offset = "0x1965BBC", VA = "0x1965BBC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1965D70", Offset = "0x1965D70", VA = "0x1965D70")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1965EFC", Offset = "0x1965EFC", VA = "0x1965EFC")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x196609C", Offset = "0x196609C", VA = "0x196609C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1966104", Offset = "0x1966104", VA = "0x1966104")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x196616C", Offset = "0x196616C", VA = "0x196616C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x19661C4", Offset = "0x19661C4", VA = "0x19661C4")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x196623C", Offset = "0x196623C", VA = "0x196623C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1966294", Offset = "0x1966294", VA = "0x1966294")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x19662EC", Offset = "0x19662EC", VA = "0x19662EC")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1966344", Offset = "0x1966344", VA = "0x1966344")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x196639C", Offset = "0x196639C", VA = "0x196639C")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x19663FC", Offset = "0x19663FC", VA = "0x19663FC")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1966458", Offset = "0x1966458", VA = "0x1966458")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x19664B0", Offset = "0x19664B0", VA = "0x19664B0")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000108")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x19665D0", Offset = "0x19665D0", VA = "0x19665D0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1966788", Offset = "0x1966788", VA = "0x1966788")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1966934", Offset = "0x1966934", VA = "0x1966934")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1966AE0", Offset = "0x1966AE0", VA = "0x1966AE0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1966C8C", Offset = "0x1966C8C", VA = "0x1966C8C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1966E40", Offset = "0x1966E40", VA = "0x1966E40")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x19670A8", Offset = "0x19670A8", VA = "0x19670A8")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x19675B4", Offset = "0x19675B4", VA = "0x19675B4")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1967828", Offset = "0x1967828", VA = "0x1967828")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1967ABC", Offset = "0x1967ABC", VA = "0x1967ABC")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1967C90", Offset = "0x1967C90", VA = "0x1967C90")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000114")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x19682A4", Offset = "0x19682A4", VA = "0x19682A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1968454", Offset = "0x1968454", VA = "0x1968454")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x19685FC", Offset = "0x19685FC", VA = "0x19685FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x19687A4", Offset = "0x19687A4", VA = "0x19687A4")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1968934", Offset = "0x1968934", VA = "0x1968934")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1968D68", Offset = "0x1968D68", VA = "0x1968D68")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x196905C", Offset = "0x196905C", VA = "0x196905C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1969374", Offset = "0x1969374", VA = "0x1969374")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1969548", Offset = "0x1969548", VA = "0x1969548")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1969B74", Offset = "0x1969B74", VA = "0x1969B74")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1969D28", Offset = "0x1969D28", VA = "0x1969D28")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1969EB4", Offset = "0x1969EB4", VA = "0x1969EB4")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x196A090", Offset = "0x196A090", VA = "0x196A090")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000122")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000123")]
		public static class Utils
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x196ECFC", Offset = "0x196ECFC", VA = "0x196ECFC")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x196A388", Offset = "0x196A388", VA = "0x196A388")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x196A50C", Offset = "0x196A50C", VA = "0x196A50C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x196A6B8", Offset = "0x196A6B8", VA = "0x196A6B8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x196A83C", Offset = "0x196A83C", VA = "0x196A83C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x196A9E8", Offset = "0x196A9E8", VA = "0x196A9E8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x196AB6C", Offset = "0x196AB6C", VA = "0x196AB6C")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x196AD14", Offset = "0x196AD14", VA = "0x196AD14")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x196AEF8", Offset = "0x196AEF8", VA = "0x196AEF8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x196B09C", Offset = "0x196B09C", VA = "0x196B09C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x196B240", Offset = "0x196B240", VA = "0x196B240")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x196B3E4", Offset = "0x196B3E4", VA = "0x196B3E4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x196B590", Offset = "0x196B590", VA = "0x196B590")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x196B714", Offset = "0x196B714", VA = "0x196B714")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x196B8A8", Offset = "0x196B8A8", VA = "0x196B8A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x196BA4C", Offset = "0x196BA4C", VA = "0x196BA4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x196BBE8", Offset = "0x196BBE8", VA = "0x196BBE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x196BD84", Offset = "0x196BD84", VA = "0x196BD84")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x196BF30", Offset = "0x196BF30", VA = "0x196BF30")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x196C0D0", Offset = "0x196C0D0", VA = "0x196C0D0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x196C270", Offset = "0x196C270", VA = "0x196C270")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x196C410", Offset = "0x196C410", VA = "0x196C410")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x196C5B4", Offset = "0x196C5B4", VA = "0x196C5B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x196C758", Offset = "0x196C758", VA = "0x196C758")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x196C8EC", Offset = "0x196C8EC", VA = "0x196C8EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x196CA84", Offset = "0x196CA84", VA = "0x196CA84")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x196CC1C", Offset = "0x196CC1C", VA = "0x196CC1C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x196CDC0", Offset = "0x196CDC0", VA = "0x196CDC0")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x196CF74", Offset = "0x196CF74", VA = "0x196CF74")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x196D150", Offset = "0x196D150", VA = "0x196D150")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x196D334", Offset = "0x196D334", VA = "0x196D334")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x196D754", Offset = "0x196D754", VA = "0x196D754")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x196D8EC", Offset = "0x196D8EC", VA = "0x196D8EC")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x196DA74", Offset = "0x196DA74", VA = "0x196DA74")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x196DBFC", Offset = "0x196DBFC", VA = "0x196DBFC")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x196DD90", Offset = "0x196DD90", VA = "0x196DD90")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x196DF3C", Offset = "0x196DF3C", VA = "0x196DF3C")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x196E12C", Offset = "0x196E12C", VA = "0x196E12C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x196E2B0", Offset = "0x196E2B0", VA = "0x196E2B0")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x196E4E0", Offset = "0x196E4E0", VA = "0x196E4E0")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x196E6F0", Offset = "0x196E6F0", VA = "0x196E6F0")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x196E900", Offset = "0x196E900", VA = "0x196E900")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x196EB10", Offset = "0x196EB10", VA = "0x196EB10")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200014D")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x2000150")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1972238", Offset = "0x1972238", VA = "0x1972238", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1972470", Offset = "0x1972470", VA = "0x1972470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000151")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
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
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x197247C", Offset = "0x197247C", VA = "0x197247C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x19726D8", Offset = "0x19726D8", VA = "0x19726D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000152")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x19726E4", Offset = "0x19726E4", VA = "0x19726E4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1972908", Offset = "0x1972908", VA = "0x1972908", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000153")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1972914", Offset = "0x1972914", VA = "0x1972914", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1972B54", Offset = "0x1972B54", VA = "0x1972B54", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000154")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1972B60", Offset = "0x1972B60", VA = "0x1972B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1972DB8", Offset = "0x1972DB8", VA = "0x1972DB8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000155")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1972DC4", Offset = "0x1972DC4", VA = "0x1972DC4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1972FF0", Offset = "0x1972FF0", VA = "0x1972FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1970E04", Offset = "0x1970E04", VA = "0x1970E04")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1970FE4", Offset = "0x1970FE4", VA = "0x1970FE4")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x19711D0", Offset = "0x19711D0", VA = "0x19711D0")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x19712CC", Offset = "0x19712CC", VA = "0x19712CC")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x19713C8", Offset = "0x19713C8", VA = "0x19713C8")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x19714C4", Offset = "0x19714C4", VA = "0x19714C4")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x19715D4", Offset = "0x19715D4", VA = "0x19715D4")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x19716F4", Offset = "0x19716F4", VA = "0x19716F4")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x19717F0", Offset = "0x19717F0", VA = "0x19717F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x19719FC", Offset = "0x19719FC", VA = "0x19719FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1971C08", Offset = "0x1971C08", VA = "0x1971C08")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1971CF4", Offset = "0x1971CF4", VA = "0x1971CF4")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1971DE0", Offset = "0x1971DE0", VA = "0x1971DE0")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1971ECC", Offset = "0x1971ECC", VA = "0x1971ECC")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1971FC0", Offset = "0x1971FC0", VA = "0x1971FC0")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x19720BC", Offset = "0x19720BC", VA = "0x19720BC")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000156")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000157")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x1972FFC", Offset = "0x1972FFC", VA = "0x1972FFC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x197129C", Offset = "0x197129C", VA = "0x197129C")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000158")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x197302C", Offset = "0x197302C", VA = "0x197302C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1971398", Offset = "0x1971398", VA = "0x1971398")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000159")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0x197308C", Offset = "0x197308C", VA = "0x197308C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1971494", Offset = "0x1971494", VA = "0x1971494")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200015A")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700003D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x19730A8", Offset = "0x19730A8", VA = "0x19730A8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1971598", Offset = "0x1971598", VA = "0x1971598")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200015B")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700003E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x19730E8", Offset = "0x19730E8", VA = "0x19730E8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x19716B0", Offset = "0x19716B0", VA = "0x19716B0")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200015C")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700003F")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x1973140", Offset = "0x1973140", VA = "0x1973140", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x19717C0", Offset = "0x19717C0", VA = "0x19717C0")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200015D")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200015E")]
		public static class Physics
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x19732D0", Offset = "0x19732D0", VA = "0x19732D0")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x19733D0", Offset = "0x19733D0", VA = "0x19733D0")]
			public static bool HasRigidbody2D(UnityEngine.Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x197345C", Offset = "0x197345C", VA = "0x197345C")]
			[Preserve]
			public static bool HasRigidbody(UnityEngine.Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x19734E8", Offset = "0x19734E8", VA = "0x19734E8")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1973174", Offset = "0x1973174", VA = "0x1973174")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1973228", Offset = "0x1973228", VA = "0x1973228")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200015F")]
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000160")]
		public enum AnimationType
		{
			[Token(Token = "0x4000298")]
			None,
			[Token(Token = "0x4000299")]
			Move,
			[Token(Token = "0x400029A")]
			LocalMove,
			[Token(Token = "0x400029B")]
			Rotate,
			[Token(Token = "0x400029C")]
			LocalRotate,
			[Token(Token = "0x400029D")]
			Scale,
			[Token(Token = "0x400029E")]
			Color,
			[Token(Token = "0x400029F")]
			Fade,
			[Token(Token = "0x40002A0")]
			Text,
			[Token(Token = "0x40002A1")]
			PunchPosition,
			[Token(Token = "0x40002A2")]
			PunchRotation,
			[Token(Token = "0x40002A3")]
			PunchScale,
			[Token(Token = "0x40002A4")]
			ShakePosition,
			[Token(Token = "0x40002A5")]
			ShakeRotation,
			[Token(Token = "0x40002A6")]
			ShakeScale,
			[Token(Token = "0x40002A7")]
			CameraAspect,
			[Token(Token = "0x40002A8")]
			CameraBackgroundColor,
			[Token(Token = "0x40002A9")]
			CameraFieldOfView,
			[Token(Token = "0x40002AA")]
			CameraOrthoSize,
			[Token(Token = "0x40002AB")]
			CameraPixelRect,
			[Token(Token = "0x40002AC")]
			CameraRect,
			[Token(Token = "0x40002AD")]
			UIWidthHeight
		}

		[Token(Token = "0x2000161")]
		public enum TargetType
		{
			[Token(Token = "0x40002AF")]
			Unset,
			[Token(Token = "0x40002B0")]
			Camera,
			[Token(Token = "0x40002B1")]
			CanvasGroup,
			[Token(Token = "0x40002B2")]
			Image,
			[Token(Token = "0x40002B3")]
			Light,
			[Token(Token = "0x40002B4")]
			RectTransform,
			[Token(Token = "0x40002B5")]
			Renderer,
			[Token(Token = "0x40002B6")]
			SpriteRenderer,
			[Token(Token = "0x40002B7")]
			Rigidbody,
			[Token(Token = "0x40002B8")]
			Rigidbody2D,
			[Token(Token = "0x40002B9")]
			Text,
			[Token(Token = "0x40002BA")]
			Transform,
			[Token(Token = "0x40002BB")]
			tk2dBaseSprite,
			[Token(Token = "0x40002BC")]
			tk2dTextMesh,
			[Token(Token = "0x40002BD")]
			TextMeshPro,
			[Token(Token = "0x40002BE")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool autoGenerate;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isActive;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool isValid;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UnityEngine.Component target;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool optionalBool1;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x19736C4", Offset = "0x19736C4", VA = "0x19736C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1973790", Offset = "0x1973790", VA = "0x1973790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x197385C", Offset = "0x197385C", VA = "0x197385C")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x19738C8", Offset = "0x19738C8", VA = "0x19738C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1975090", Offset = "0x1975090", VA = "0x1975090")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x19750D0", Offset = "0x19750D0", VA = "0x19750D0")]
		private void Reset()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x19750D4", Offset = "0x19750D4", VA = "0x19750D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x197510C", Offset = "0x197510C", VA = "0x197510C")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1975144", Offset = "0x1975144", VA = "0x1975144")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x197517C", Offset = "0x197517C", VA = "0x197517C")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1975188", Offset = "0x1975188", VA = "0x1975188")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1973914", Offset = "0x1973914", VA = "0x1973914")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x19758C0", Offset = "0x19758C0", VA = "0x19758C0")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1975A18", Offset = "0x1975A18", VA = "0x1975A18")]
		public void SetAnimationTarget(UnityEngine.Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1975B04", Offset = "0x1975B04", VA = "0x1975B04", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1975B84", Offset = "0x1975B84", VA = "0x1975B84", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1975C04", Offset = "0x1975C04", VA = "0x1975C04", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1975C84", Offset = "0x1975C84", VA = "0x1975C84", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1975D04", Offset = "0x1975D04", VA = "0x1975D04", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1975D84", Offset = "0x1975D84", VA = "0x1975D84", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1975E68", Offset = "0x1975E68", VA = "0x1975E68", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1975E78", Offset = "0x1975E78", VA = "0x1975E78", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x19761D8", Offset = "0x19761D8", VA = "0x19761D8", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x197625C", Offset = "0x197625C", VA = "0x197625C", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x19762F0", Offset = "0x19762F0", VA = "0x19762F0")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1976378", Offset = "0x1976378", VA = "0x1976378")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x19763D0", Offset = "0x19763D0", VA = "0x19763D0")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1976428", Offset = "0x1976428", VA = "0x1976428")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x19764B0", Offset = "0x19764B0", VA = "0x19764B0")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1976508", Offset = "0x1976508", VA = "0x1976508")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1976590", Offset = "0x1976590", VA = "0x1976590")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x19765E8", Offset = "0x19765E8", VA = "0x19765E8")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1976724", Offset = "0x1976724", VA = "0x1976724")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x19767B8", Offset = "0x19767B8", VA = "0x19767B8")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1976828", Offset = "0x1976828", VA = "0x1976828")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x19768C0", Offset = "0x19768C0", VA = "0x19768C0")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1976934", Offset = "0x1976934", VA = "0x1976934")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x19769C0", Offset = "0x19769C0", VA = "0x19769C0")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x19751AC", Offset = "0x19751AC", VA = "0x19751AC")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1976A1C", Offset = "0x1976A1C", VA = "0x1976A1C")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1975194", Offset = "0x1975194", VA = "0x1975194")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x19758A0", Offset = "0x19758A0", VA = "0x19758A0")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1975F84", Offset = "0x1975F84", VA = "0x1975F84")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1976A54", Offset = "0x1976A54", VA = "0x1976A54")]
		public DOTweenAnimation()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000705")]
		public static bool IsSameOrSubclassOf<T>(this UnityEngine.Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000163")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1976C48", Offset = "0x1976C48", VA = "0x1976C48")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1976C98", Offset = "0x1976C98", VA = "0x1976C98")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x197705C", Offset = "0x197705C", VA = "0x197705C")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000166")]
	public enum TMPSkewSpanMode
	{
		[Token(Token = "0x40002C2")]
		Default,
		[Token(Token = "0x40002C3")]
		AsMaxSkewFactor
	}
	[Token(Token = "0x2000167")]
	public static class ShortcutExtensionsTMPText
	{
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x19753BC", Offset = "0x19753BC", VA = "0x19753BC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this TMP_Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1977480", Offset = "0x1977480", VA = "0x1977480")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1977660", Offset = "0x1977660", VA = "0x1977660")]
		public static TweenerCore<Color, Color, ColorOptions> DOOutlineColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1977840", Offset = "0x1977840", VA = "0x1977840")]
		public static TweenerCore<Color, Color, ColorOptions> DOGlowColor(this TMP_Text target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1975568", Offset = "0x1975568", VA = "0x1975568")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1977938", Offset = "0x1977938", VA = "0x1977938")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1977AC4", Offset = "0x1977AC4", VA = "0x1977AC4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1977C64", Offset = "0x1977C64", VA = "0x1977C64")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this TMP_Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1977E5C", Offset = "0x1977E5C", VA = "0x1977E5C")]
		public static TweenerCore<float, float, FloatOptions> DOFontSize(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1977FE8", Offset = "0x1977FE8", VA = "0x1977FE8")]
		public static TweenerCore<int, int, NoOptions> DOMaxVisibleCharacters(this TMP_Text target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x19756EC", Offset = "0x19756EC", VA = "0x19756EC")]
		public static TweenerCore<string, string, StringOptions> DOText(this TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
	[Token(Token = "0x2000172")]
	public class DOTweenTMPAnimator : IDisposable
	{
		[Token(Token = "0x2000173")]
		private struct CharVertices
		{
			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 bottomLeft;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 topLeft;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 topRight;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 bottomRight;

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x197D2A4", Offset = "0x197D2A4", VA = "0x197D2A4")]
			public CharVertices(Vector3 bottomLeft, Vector3 topLeft, Vector3 topRight, Vector3 bottomRight)
			{
			}
		}

		[Token(Token = "0x2000174")]
		private struct CharTransform
		{
			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int charIndex;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 offset;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion rotation;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 scale;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 _topLeftShift;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 _topRightShift;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 _bottomLeftShift;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 _bottomRightShift;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 _charMidBaselineOffset;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int _matIndex;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int _firstVertexIndex;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TMP_MeshInfo _meshInfo;

			[Token(Token = "0x17000042")]
			public bool isVisible
			{
				[Token(Token = "0x6000762")]
				[Address(RVA = "0x197D2D4", Offset = "0x197D2D4", VA = "0x197D2D4")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x197D2DC", Offset = "0x197D2DC", VA = "0x197D2DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1979868", Offset = "0x1979868", VA = "0x1979868")]
			public CharTransform(int charIndex, TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x19796F0", Offset = "0x19796F0", VA = "0x19796F0")]
			public void Refresh(TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1979A58", Offset = "0x1979A58", VA = "0x1979A58")]
			public void ResetAll(TMP_Text target, TMP_MeshInfo[] meshInfos, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x19795E0", Offset = "0x19795E0", VA = "0x19795E0")]
			public void ResetTransformationData()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x197D2E8", Offset = "0x197D2E8", VA = "0x197D2E8")]
			public void ResetGeometry(TMP_Text target, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x197D46C", Offset = "0x197D46C", VA = "0x197D46C")]
			public void ResetColors(TMP_Text target, TMP_MeshInfo[] meshInfos)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x197AA14", Offset = "0x197AA14", VA = "0x197AA14")]
			public Color32 GetColor(TMP_MeshInfo[] meshInfos)
			{
				return default(Color32);
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1979F54", Offset = "0x1979F54", VA = "0x1979F54")]
			public CharVertices GetVertices()
			{
				return default(CharVertices);
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x197DE64", Offset = "0x197DE64", VA = "0x197DE64")]
			public void UpdateAlpha(TMP_Text target, Color alphaColor, TMP_MeshInfo[] meshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x197ADE4", Offset = "0x197ADE4", VA = "0x197ADE4")]
			public void UpdateColor(TMP_Text target, Color32 color, TMP_MeshInfo[] meshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x197AEB0", Offset = "0x197AEB0", VA = "0x197AEB0")]
			public void UpdateGeometry(TMP_Text target, Vector3 offset, Quaternion rotation, Vector3 scale, TMP_MeshInfo[] cachedMeshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x197B720", Offset = "0x197B720", VA = "0x197B720")]
			public void ShiftVertices(TMP_Text target, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x197B9D8", Offset = "0x197B9D8", VA = "0x197B9D8")]
			public void ResetVerticesShift(TMP_Text target)
			{
			}
		}

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<TMP_Text, DOTweenTMPAnimator> _targetToAnimator;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<CharTransform> _charTransforms;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_MeshInfo[] _cachedMeshInfos;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _ignoreTextChangedEvent;

		[Token(Token = "0x17000040")]
		public TMP_Text target
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1978D48", Offset = "0x1978D48", VA = "0x1978D48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x1978D50", Offset = "0x1978D50", VA = "0x1978D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public TMP_TextInfo textInfo
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1978D58", Offset = "0x1978D58", VA = "0x1978D58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1978D60", Offset = "0x1978D60", VA = "0x1978D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1978D68", Offset = "0x1978D68", VA = "0x1978D68")]
		public DOTweenTMPAnimator(TMP_Text target)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x19794D8", Offset = "0x19794D8", VA = "0x19794D8")]
		public static void DisposeInstanceFor(TMP_Text target)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x19790D0", Offset = "0x19790D0", VA = "0x19790D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1979208", Offset = "0x1979208", VA = "0x1979208")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1979964", Offset = "0x1979964", VA = "0x1979964")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1979A8C", Offset = "0x1979A8C", VA = "0x1979A8C")]
		private void OnTextChanged(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1979B44", Offset = "0x1979B44", VA = "0x1979B44")]
		private bool ValidateChar(int charIndex, bool isTween = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1979CD4", Offset = "0x1979CD4", VA = "0x1979CD4")]
		private bool ValidateSpan(int fromCharIndex, int toCharIndex, out int firstVisibleCharIndex, out int lastVisibleCharIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1979E14", Offset = "0x1979E14", VA = "0x1979E14")]
		public void SkewSpanX(int fromCharIndex, int toCharIndex, float skewFactor, bool skewTop = true)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x197A1F4", Offset = "0x197A1F4", VA = "0x197A1F4")]
		public void SkewSpanY(int fromCharIndex, int toCharIndex, float skewFactor, TMPSkewSpanMode mode = TMPSkewSpanMode.Default, bool skewRight = true)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x197A910", Offset = "0x197A910", VA = "0x197A910")]
		public Color GetCharColor(int charIndex)
		{
			return default(Color);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x197AA64", Offset = "0x197AA64", VA = "0x197AA64")]
		public Vector3 GetCharOffset(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x197AB24", Offset = "0x197AB24", VA = "0x197AB24")]
		public Vector3 GetCharRotation(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x197AC08", Offset = "0x197AC08", VA = "0x197AC08")]
		public Vector3 GetCharScale(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x197ACC8", Offset = "0x197ACC8", VA = "0x197ACC8")]
		public void SetCharColor(int charIndex, Color32 color)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x197A7C0", Offset = "0x197A7C0", VA = "0x197A7C0")]
		public void SetCharOffset(int charIndex, Vector3 offset)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x197B2C4", Offset = "0x197B2C4", VA = "0x197B2C4")]
		public void SetCharRotation(int charIndex, Vector3 rotation)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x197B45C", Offset = "0x197B45C", VA = "0x197B45C")]
		public void SetCharScale(int charIndex, Vector3 scale)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x197B59C", Offset = "0x197B59C", VA = "0x197B59C")]
		public void ShiftCharVertices(int charIndex, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x197A010", Offset = "0x197A010", VA = "0x197A010")]
		public float SkewCharX(int charIndex, float skewFactor, bool skewTop = true)
		{
			return default(float);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x197A5A0", Offset = "0x197A5A0", VA = "0x197A5A0")]
		public float SkewCharY(int charIndex, float skewFactor, bool skewRight = true, bool fixedSkew = false)
		{
			return default(float);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x197B8D4", Offset = "0x197B8D4", VA = "0x197B8D4")]
		public void ResetVerticesShift(int charIndex)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x197BB80", Offset = "0x197BB80", VA = "0x197BB80")]
		public TweenerCore<Color, Color, ColorOptions> DOFadeChar(int charIndex, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x197BD0C", Offset = "0x197BD0C", VA = "0x197BD0C")]
		public TweenerCore<Color, Color, ColorOptions> DOColorChar(int charIndex, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x197BEC8", Offset = "0x197BEC8", VA = "0x197BEC8")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOOffsetChar(int charIndex, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x197C070", Offset = "0x197C070", VA = "0x197C070")]
		public TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateChar(int charIndex, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x197C214", Offset = "0x197C214", VA = "0x197C214")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x197C224", Offset = "0x197C224", VA = "0x197C224")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x197C3CC", Offset = "0x197C3CC", VA = "0x197C3CC")]
		public Tweener DOPunchCharOffset(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x197C618", Offset = "0x197C618", VA = "0x197C618")]
		public Tweener DOPunchCharRotation(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x197C864", Offset = "0x197C864", VA = "0x197C864")]
		public Tweener DOPunchCharScale(int charIndex, float punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x197C878", Offset = "0x197C878", VA = "0x197C878")]
		public Tweener DOPunchCharScale(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x197CAC4", Offset = "0x197CAC4", VA = "0x197CAC4")]
		public Tweener DOShakeCharOffset(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x197CAD8", Offset = "0x197CAD8", VA = "0x197CAD8")]
		public Tweener DOShakeCharOffset(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x197CD38", Offset = "0x197CD38", VA = "0x197CD38")]
		public Tweener DOShakeCharRotation(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x197CF98", Offset = "0x197CF98", VA = "0x197CF98")]
		public Tweener DOShakeCharScale(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x197CFAC", Offset = "0x197CFAC", VA = "0x197CFAC")]
		public Tweener DOShakeCharScale(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}
	}
}
