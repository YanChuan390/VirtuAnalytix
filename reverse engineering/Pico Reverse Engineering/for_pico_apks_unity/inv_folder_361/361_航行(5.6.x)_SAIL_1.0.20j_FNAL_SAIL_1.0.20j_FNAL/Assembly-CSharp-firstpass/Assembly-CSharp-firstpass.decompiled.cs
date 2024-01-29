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
using MonsterLove.StateMachine;
using RootMotion.Dynamics;
using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FEBF4", Offset = "0x9FEBF4")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xA065A8", Offset = "0xA065A8")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xA065BC", Offset = "0xA065BC")]
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
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9FEC04", Offset = "0x9FEC04")]
public class ES3Serializable : Attribute
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1864F20", Offset = "0x1864F20", VA = "0x1864F20")]
	public ES3Serializable()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9FEC18", Offset = "0x9FEC18")]
public class ES3NonSerializable : Attribute
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x185AF70", Offset = "0x185AF70", VA = "0x185AF70")]
	public ES3NonSerializable()
	{
	}
}
[Token(Token = "0x2000005")]
public class ES3AutoSave : MonoBehaviour, ISerializationCallbackReceiver
{
	[Serializable]
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FEC2C", Offset = "0x9FEC2C")]
	private sealed class <>c
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Component> <>9__13_0;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1391144", Offset = "0x1391144", VA = "0x1391144")]
		public <>c()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x139114C", Offset = "0x139114C", VA = "0x139114C")]
		internal bool <OnAfterDeserialize>b__13_0(Component c)
		{
			return default(bool);
		}
	}

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
	public List<Component> componentsToSave;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x15B35B8", Offset = "0x15B35B8", VA = "0x15B35B8")]
	public void Reset()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x15B35C4", Offset = "0x15B35C4", VA = "0x15B35C4")]
	public void Awake()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x15B3A78", Offset = "0x15B3A78", VA = "0x15B3A78")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x15B3A84", Offset = "0x15B3A84", VA = "0x15B3A84")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x15B3C00", Offset = "0x15B3C00", VA = "0x15B3C00", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x15B3C04", Offset = "0x15B3C04", VA = "0x15B3C04", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x15B3D30", Offset = "0x15B3D30", VA = "0x15B3D30")]
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
		[Address(RVA = "0x15B36C0", Offset = "0x15B36C0", VA = "0x15B36C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public static ES3AutoSaveMgr Instance
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x15B3DC4", Offset = "0x15B3DC4", VA = "0x15B3DC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x15B3E1C", Offset = "0x15B3E1C", VA = "0x15B3E1C")]
	public void Save()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x15B40BC", Offset = "0x15B40BC", VA = "0x15B40BC")]
	public void Load()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x15B41E0", Offset = "0x15B41E0", VA = "0x15B41E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x15B41F4", Offset = "0x15B41F4", VA = "0x15B41F4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x15B43A4", Offset = "0x15B43A4", VA = "0x15B43A4")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x15B43B8", Offset = "0x15B43B8", VA = "0x15B43B8")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x15B3970", Offset = "0x15B3970", VA = "0x15B3970")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x15B3AF8", Offset = "0x15B3AF8", VA = "0x15B3AF8")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x15B4424", Offset = "0x15B4424", VA = "0x15B4424")]
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
	[Address(RVA = "0x15AB3EC", Offset = "0x15AB3EC", VA = "0x15AB3EC")]
	public static void Save(string key, object value)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x15AB47C", Offset = "0x15AB47C", VA = "0x15AB47C")]
	public static void Save(string key, object value, string filePath)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x15AB510", Offset = "0x15AB510", VA = "0x15AB510")]
	public static void Save(string key, object value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x15AB5B0", Offset = "0x15AB5B0", VA = "0x15AB5B0")]
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
	[Address(RVA = "0x15AB614", Offset = "0x15AB614", VA = "0x15AB614")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x15AB884", Offset = "0x15AB884", VA = "0x15AB884")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x15AB8F8", Offset = "0x15AB8F8", VA = "0x15AB8F8")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x15AB67C", Offset = "0x15AB67C", VA = "0x15AB67C")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x15AB970", Offset = "0x15AB970", VA = "0x15AB970")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x15ABA1C", Offset = "0x15ABA1C", VA = "0x15ABA1C")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x15ABA90", Offset = "0x15ABA90", VA = "0x15ABA90")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x15AB9D8", Offset = "0x15AB9D8", VA = "0x15AB9D8")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x15ABB08", Offset = "0x15ABB08", VA = "0x15ABB08")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x15ABD7C", Offset = "0x15ABD7C", VA = "0x15ABD7C")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x15ABB70", Offset = "0x15ABB70", VA = "0x15ABB70")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x15ABDF4", Offset = "0x15ABDF4", VA = "0x15ABDF4")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x15AC08C", Offset = "0x15AC08C", VA = "0x15AC08C")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x15ABE5C", Offset = "0x15ABE5C", VA = "0x15ABE5C")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x15AC104", Offset = "0x15AC104", VA = "0x15AC104")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x15AC188", Offset = "0x15AC188", VA = "0x15AC188")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x15AC17C", Offset = "0x15AC17C", VA = "0x15AC17C")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x15AC3A8", Offset = "0x15AC3A8", VA = "0x15AC3A8")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x15AC420", Offset = "0x15AC420", VA = "0x15AC420")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x15AC204", Offset = "0x15AC204", VA = "0x15AC204")]
	public static void SaveImage(Texture2D texture, int quality, ES3Settings settings)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x15AC4A8", Offset = "0x15AC4A8", VA = "0x15AC4A8")]
	public static object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x15AC528", Offset = "0x15AC528", VA = "0x15AC528")]
	public static object Load(string key, string filePath)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x15AC5B4", Offset = "0x15AC5B4", VA = "0x15AC5B4")]
	public static object Load(string key, string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x15AC644", Offset = "0x15AC644", VA = "0x15AC644")]
	public static object Load(string key, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000040")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x6000041")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000042")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000043")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000044")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000045")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000046")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000047")]
	public static void LoadInto<T>(string key, object obj) where T : class
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x15AC6A0", Offset = "0x15AC6A0", VA = "0x15AC6A0")]
	public static void LoadInto(string key, string filePath, object obj)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x15AC734", Offset = "0x15AC734", VA = "0x15AC734")]
	public static void LoadInto(string key, string filePath, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x15AC7D4", Offset = "0x15AC7D4", VA = "0x15AC7D4")]
	public static void LoadInto(string key, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x600004B")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x600004C")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x600004D")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x600004E")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x15AC838", Offset = "0x15AC838", VA = "0x15AC838")]
	public static string LoadString(string key, string defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x15AC8A0", Offset = "0x15AC8A0", VA = "0x15AC8A0")]
	public static string LoadString(string key, string defaultValue, [Optional] string filePath, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x15AC914", Offset = "0x15AC914", VA = "0x15AC914")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x15ACE40", Offset = "0x15ACE40", VA = "0x15ACE40")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x15ACEA4", Offset = "0x15ACEA4", VA = "0x15ACEA4")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x15AC974", Offset = "0x15AC974", VA = "0x15AC974")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x15ACF14", Offset = "0x15ACF14", VA = "0x15ACF14")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x15ACFC0", Offset = "0x15ACFC0", VA = "0x15ACFC0")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x15AD024", Offset = "0x15AD024", VA = "0x15AD024")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x15ACF74", Offset = "0x15ACF74", VA = "0x15ACF74")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x15AD094", Offset = "0x15AD094", VA = "0x15AD094")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x15AD110", Offset = "0x15AD110", VA = "0x15AD110")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x15AD0FC", Offset = "0x15AD0FC", VA = "0x15AD0FC")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x15AD184", Offset = "0x15AD184", VA = "0x15AD184")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x15AD1F8", Offset = "0x15AD1F8", VA = "0x15AD1F8")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x15AD270", Offset = "0x15AD270", VA = "0x15AD270")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	public static byte[] Serialize<T>(T value, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x15AD670", Offset = "0x15AD670", VA = "0x15AD670")]
	internal static byte[] Serialize(object value, ES3Type type, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	public static T Deserialize<T>(byte[] bytes, [Optional] ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x15ADA2C", Offset = "0x15ADA2C", VA = "0x15ADA2C")]
	internal static object Deserialize(ES3Type type, byte[] bytes, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	public static void DeserializeInto<T>(byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000064")]
	public static void DeserializeInto<T>(ES3Type type, byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x15ADD9C", Offset = "0x15ADD9C", VA = "0x15ADD9C")]
	public static byte[] EncryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x15ADE98", Offset = "0x15ADE98", VA = "0x15ADE98")]
	public static byte[] DecryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x15ADF94", Offset = "0x15ADF94", VA = "0x15ADF94")]
	public static string EncryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x15AE058", Offset = "0x15AE058", VA = "0x15AE058")]
	public static string DecryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x15AE11C", Offset = "0x15AE11C", VA = "0x15AE11C")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x15AE2F8", Offset = "0x15AE2F8", VA = "0x15AE2F8")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x15AE35C", Offset = "0x15AE35C", VA = "0x15AE35C")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x15AE17C", Offset = "0x15AE17C", VA = "0x15AE17C")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x15AE3CC", Offset = "0x15AE3CC", VA = "0x15AE3CC")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x15AE8A0", Offset = "0x15AE8A0", VA = "0x15AE8A0")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x15AE45C", Offset = "0x15AE45C", VA = "0x15AE45C")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x15AE940", Offset = "0x15AE940", VA = "0x15AE940")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x15AEE34", Offset = "0x15AEE34", VA = "0x15AEE34")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x15AE9D0", Offset = "0x15AE9D0", VA = "0x15AE9D0")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x15AEED4", Offset = "0x15AEED4", VA = "0x15AEED4")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x15AF240", Offset = "0x15AF240", VA = "0x15AF240")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x15AEF64", Offset = "0x15AEF64", VA = "0x15AEF64")]
	public static void CopyDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x15AF62C", Offset = "0x15AF62C", VA = "0x15AF62C")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x15AF878", Offset = "0x15AF878", VA = "0x15AF878")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x15AF6BC", Offset = "0x15AF6BC", VA = "0x15AF6BC")]
	public static void RenameDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x15AF918", Offset = "0x15AF918", VA = "0x15AF918")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x15AFABC", Offset = "0x15AFABC", VA = "0x15AFABC")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x15AF97C", Offset = "0x15AF97C", VA = "0x15AF97C")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x15AFB2C", Offset = "0x15AFB2C", VA = "0x15AFB2C")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x15AFDB8", Offset = "0x15AFDB8", VA = "0x15AFDB8")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x15AFE2C", Offset = "0x15AFE2C", VA = "0x15AFE2C")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x15AFB94", Offset = "0x15AFB94", VA = "0x15AFB94")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x15B003C", Offset = "0x15B003C", VA = "0x15B003C")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x15B026C", Offset = "0x15B026C", VA = "0x15B026C")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x15B02E0", Offset = "0x15B02E0", VA = "0x15B02E0")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x15B00A4", Offset = "0x15B00A4", VA = "0x15B00A4")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x15B0358", Offset = "0x15B0358", VA = "0x15B0358")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x15B03B8", Offset = "0x15B03B8", VA = "0x15B03B8")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x15B041C", Offset = "0x15B041C", VA = "0x15B041C")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x15AFEA4", Offset = "0x15AFEA4", VA = "0x15AFEA4")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x15B048C", Offset = "0x15B048C", VA = "0x15B048C")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x15B04F0", Offset = "0x15B04F0", VA = "0x15B04F0")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x15AF2E0", Offset = "0x15AF2E0", VA = "0x15AF2E0")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x15B0560", Offset = "0x15B0560", VA = "0x15B0560")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x15B0A18", Offset = "0x15B0A18", VA = "0x15B0A18")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x15B0A7C", Offset = "0x15B0A7C", VA = "0x15B0A7C")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x15B05C0", Offset = "0x15B05C0", VA = "0x15B05C0")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x15B0AEC", Offset = "0x15B0AEC", VA = "0x15B0AEC")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x15B0B90", Offset = "0x15B0B90", VA = "0x15B0B90")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x15B0BF4", Offset = "0x15B0BF4", VA = "0x15B0BF4")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x15AF424", Offset = "0x15AF424", VA = "0x15AF424")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x15B0C64", Offset = "0x15B0C64", VA = "0x15B0C64")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x15B0CC4", Offset = "0x15B0CC4", VA = "0x15B0CC4")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x15B0D28", Offset = "0x15B0D28", VA = "0x15B0D28")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x15AF550", Offset = "0x15AF550", VA = "0x15AF550")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x15B0D98", Offset = "0x15B0D98", VA = "0x15B0D98")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x15B0E9C", Offset = "0x15B0E9C", VA = "0x15B0E9C")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x15B0F00", Offset = "0x15B0F00", VA = "0x15B0F00")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x15B0DF8", Offset = "0x15B0DF8", VA = "0x15B0DF8")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x15B0F70", Offset = "0x15B0F70", VA = "0x15B0F70")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x15B1094", Offset = "0x15B1094", VA = "0x15B1094")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x15B0FD4", Offset = "0x15B0FD4", VA = "0x15B0FD4")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x15B1104", Offset = "0x15B1104", VA = "0x15B1104")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x15B131C", Offset = "0x15B131C", VA = "0x15B131C")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x15B1380", Offset = "0x15B1380", VA = "0x15B1380")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x15B1164", Offset = "0x15B1164", VA = "0x15B1164")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x15B13F0", Offset = "0x15B13F0", VA = "0x15B13F0")]
	public static void StoreCachedFile()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x15B1450", Offset = "0x15B1450", VA = "0x15B1450")]
	public static void StoreCachedFile(string filePath)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x15B1518", Offset = "0x15B1518", VA = "0x15B1518")]
	public static void StoreCachedFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x15B14B4", Offset = "0x15B14B4", VA = "0x15B14B4")]
	public static void StoreCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x15B1588", Offset = "0x15B1588", VA = "0x15B1588")]
	public static void CacheFile()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x15B164C", Offset = "0x15B164C", VA = "0x15B164C")]
	public static void CacheFile(string filePath)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x15B16B0", Offset = "0x15B16B0", VA = "0x15B16B0")]
	public static void CacheFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x15B15E8", Offset = "0x15B15E8", VA = "0x15B15E8")]
	public static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x15B1720", Offset = "0x15B1720", VA = "0x15B1720")]
	public static void Init()
	{
	}
}
[Token(Token = "0x2000011")]
public class ES3File
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA065D0", Offset = "0xA065D0")]
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

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1850E48", Offset = "0x1850E48", VA = "0x1850E48")]
	public ES3File()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x18513CC", Offset = "0x18513CC", VA = "0x18513CC")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1851440", Offset = "0x1851440", VA = "0x1851440")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x18514B8", Offset = "0x18514B8", VA = "0x18514B8")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x18514C0", Offset = "0x18514C0", VA = "0x18514C0")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1851530", Offset = "0x1851530", VA = "0x1851530")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x18515A8", Offset = "0x18515A8", VA = "0x18515A8")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1850F10", Offset = "0x1850F10", VA = "0x1850F10")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x185172C", Offset = "0x185172C", VA = "0x185172C")]
	public ES3File(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1851C8C", Offset = "0x1851C8C", VA = "0x1851C8C")]
	public void Sync()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1852058", Offset = "0x1852058", VA = "0x1852058")]
	public void Sync(string filePath, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1851C94", Offset = "0x1851C94", VA = "0x1851C94")]
	public void Sync([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x18520CC", Offset = "0x18520CC", VA = "0x18520CC")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1852120", Offset = "0x1852120", VA = "0x1852120")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	public void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1851854", Offset = "0x1851854", VA = "0x1851854")]
	public void SaveRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x18522BC", Offset = "0x18522BC", VA = "0x18522BC")]
	public void AppendRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1852334", Offset = "0x1852334", VA = "0x1852334")]
	public object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1852390", Offset = "0x1852390", VA = "0x1852390")]
	public object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60000BF")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60000C0")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x18523F4", Offset = "0x18523F4", VA = "0x18523F4")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1852988", Offset = "0x1852988", VA = "0x1852988")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1852490", Offset = "0x1852490", VA = "0x1852490")]
	internal byte[] GetBytes([Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1852E14", Offset = "0x1852E14", VA = "0x1852E14")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1852E78", Offset = "0x1852E78", VA = "0x1852E78")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1852EDC", Offset = "0x1852EDC", VA = "0x1852EDC")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1853008", Offset = "0x1853008", VA = "0x1853008")]
	public Type GetKeyType(string key)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x18530FC", Offset = "0x18530FC", VA = "0x18530FC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B128", Offset = "0xA0B128")]
	internal static ES3File GetOrCreateCachedFile(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1853224", Offset = "0x1853224", VA = "0x1853224")]
	internal static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1853430", Offset = "0x1853430", VA = "0x1853430")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B13C", Offset = "0xA0B13C")]
	internal static void Store([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1853854", Offset = "0x1853854", VA = "0x1853854")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B150", Offset = "0xA0B150")]
	internal static void RemoveCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x18538E4", Offset = "0x18538E4", VA = "0x18538E4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B164", Offset = "0xA0B164")]
	internal static void CopyCachedFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1853CCC", Offset = "0x1853CCC", VA = "0x1853CCC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B178", Offset = "0xA0B178")]
	internal static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1853D88", Offset = "0x1853D88", VA = "0x1853D88")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B18C", Offset = "0xA0B18C")]
	internal static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1853E50", Offset = "0x1853E50", VA = "0x1853E50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B1A0", Offset = "0xA0B1A0")]
	internal static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1853EE0", Offset = "0x1853EE0", VA = "0x1853EE0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B1B4", Offset = "0xA0B1B4")]
	internal static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1854048", Offset = "0x1854048", VA = "0x1854048")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B1C8", Offset = "0xA0B1C8")]
	internal static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x18540E8", Offset = "0x18540E8", VA = "0x18540E8")]
	internal static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}
}
[Token(Token = "0x2000012")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1856414", Offset = "0x1856414", VA = "0x1856414")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000013")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase
{
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x185E360", Offset = "0x185E360", VA = "0x185E360")]
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

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1C5BFF4", Offset = "0x1C5BFF4", VA = "0x1C5BFF4")]
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
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1865D20", Offset = "0x1865D20", VA = "0x1865D20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public int RowCount
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1865D28", Offset = "0x1865D28", VA = "0x1865D28")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000D8")]
	public void SetCell<T>(int col, int row, T value)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1865D30", Offset = "0x1865D30", VA = "0x1865D30")]
	private void SetCellString(int col, int row, string value)
	{
	}

	[Token(Token = "0x60000DA")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1865DF0", Offset = "0x1865DF0", VA = "0x1865DF0")]
	internal object GetCell(Type type, int col, int row)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1866238", Offset = "0x1866238", VA = "0x1866238")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x18662E4", Offset = "0x18662E4", VA = "0x18662E4")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x18662B4", Offset = "0x18662B4", VA = "0x18662B4")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1866638", Offset = "0x1866638", VA = "0x1866638")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x186670C", Offset = "0x186670C", VA = "0x186670C")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1866364", Offset = "0x1866364", VA = "0x1866364")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x18667AC", Offset = "0x18667AC", VA = "0x18667AC")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1866B70", Offset = "0x1866B70", VA = "0x1866B70")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1866BE8", Offset = "0x1866BE8", VA = "0x1866BE8")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1866BF0", Offset = "0x1866BF0", VA = "0x1866BF0")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1866C68", Offset = "0x1866C68", VA = "0x1866C68")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1866820", Offset = "0x1866820", VA = "0x1866820")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1866EA8", Offset = "0x1866EA8", VA = "0x1866EA8")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1866FC4", Offset = "0x1866FC4", VA = "0x1866FC4")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1866CEC", Offset = "0x1866CEC", VA = "0x1866CEC")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x18670A8", Offset = "0x18670A8", VA = "0x18670A8")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x2000016")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FEC3C", Offset = "0x9FEC3C")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FEC50", Offset = "0x9FEC50")]
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
				[Token(Token = "0x6000131")]
				[Address(RVA = "0x1C5F6AC", Offset = "0x1C5F6AC", VA = "0x1C5F6AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000133")]
				[Address(RVA = "0x1C5F6F4", Offset = "0x1C5F6F4", VA = "0x1C5F6F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1C5B49C", Offset = "0x1C5B49C", VA = "0x1C5B49C")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1C5F5F4", Offset = "0x1C5F5F4", VA = "0x1C5F5F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1C5F5F8", Offset = "0x1C5F5F8", VA = "0x1C5F5F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1C5F6B4", Offset = "0x1C5F6B4", VA = "0x1C5F6B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1C5B3F0", Offset = "0x1C5B3F0", VA = "0x1C5B3F0")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1C5B424", Offset = "0x1C5B424", VA = "0x1C5B424")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B27C", Offset = "0xA0B27C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FEC60", Offset = "0x9FEC60")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FEC74", Offset = "0x9FEC74")]
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
				[Token(Token = "0x6000139")]
				[Address(RVA = "0x1C5F8D0", Offset = "0x1C5F8D0", VA = "0x1C5F8D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013B")]
				[Address(RVA = "0x1C5F918", Offset = "0x1C5F918", VA = "0x1C5F918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1C5B574", Offset = "0x1C5B574", VA = "0x1C5B574")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1C5F6FC", Offset = "0x1C5F6FC", VA = "0x1C5F6FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1C5F700", Offset = "0x1C5F700", VA = "0x1C5F700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1C5F8D8", Offset = "0x1C5F8D8", VA = "0x1C5F8D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1C5B4C8", Offset = "0x1C5B4C8", VA = "0x1C5B4C8")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1C5B4FC", Offset = "0x1C5B4FC", VA = "0x1C5B4FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B32C", Offset = "0xA0B32C")]
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
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x185D564", Offset = "0x185D564", VA = "0x185D564", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x185D5C4", Offset = "0x185D5C4", VA = "0x185D5C4", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000EE")]
	internal abstract int Read_int();

	[Token(Token = "0x60000EF")]
	internal abstract float Read_float();

	[Token(Token = "0x60000F0")]
	internal abstract bool Read_bool();

	[Token(Token = "0x60000F1")]
	internal abstract char Read_char();

	[Token(Token = "0x60000F2")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x60000F3")]
	internal abstract double Read_double();

	[Token(Token = "0x60000F4")]
	internal abstract long Read_long();

	[Token(Token = "0x60000F5")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x60000F6")]
	internal abstract byte Read_byte();

	[Token(Token = "0x60000F7")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x60000F8")]
	internal abstract short Read_short();

	[Token(Token = "0x60000F9")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x60000FA")]
	internal abstract uint Read_uint();

	[Token(Token = "0x60000FB")]
	internal abstract string Read_string();

	[Token(Token = "0x60000FC")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x60000FD")]
	internal abstract long Read_ref();

	[Token(Token = "0x60000FE")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B1DC", Offset = "0xA0B1DC")]
	public abstract string ReadPropertyName();

	[Token(Token = "0x60000FF")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x6000100")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x6000101")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x6000102")]
	public abstract void Dispose();

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x185D4A0", Offset = "0x185D4A0", VA = "0x185D4A0", Slot = "26")]
	internal virtual bool Goto(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1857864", Offset = "0x1857864", VA = "0x1857864", Slot = "27")]
	internal virtual bool StartReadObject()
	{
		return default(bool);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1857B88", Offset = "0x1857B88", VA = "0x1857B88", Slot = "28")]
	internal virtual void EndReadObject()
	{
	}

	[Token(Token = "0x6000106")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x6000107")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x6000108")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x6000109")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x600010A")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x600010B")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x600010C")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x600010D")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x600010E")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x600010F")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1856598", Offset = "0x1856598", VA = "0x1856598")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x185D624", Offset = "0x185D624", VA = "0x185D624", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B1F0", Offset = "0xA0B1F0")]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x6000114")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000115")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x6000116")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B204", Offset = "0xA0B204")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000117")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B218", Offset = "0xA0B218")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x185D638", Offset = "0x185D638", VA = "0x185D638")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B22C", Offset = "0xA0B22C")]
	public long ReadRefProperty()
	{
		return default(long);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x185D674", Offset = "0x185D674", VA = "0x185D674")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x185D754", Offset = "0x185D754", VA = "0x185D754")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x185D97C", Offset = "0x185D97C", VA = "0x185D97C")]
	public void SetPrivateField(string name, object value, object objectContainingField)
	{
	}

	[Token(Token = "0x600011C")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x600011D")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600011E")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x600011F")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000120")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000121")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B240", Offset = "0xA0B240")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000122")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B254", Offset = "0xA0B254")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000123")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B268", Offset = "0xA0B268")]
	internal Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x185DBA4", Offset = "0x185DBA4", VA = "0x185DBA4")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x185DBFC", Offset = "0x185DBFC", VA = "0x185DBFC")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x185DC5C", Offset = "0x185DC5C", VA = "0x185DC5C")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1851694", Offset = "0x1851694", VA = "0x1851694")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x185E12C", Offset = "0x185E12C", VA = "0x185E12C")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x18521F0", Offset = "0x18521F0", VA = "0x18521F0")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x185E18C", Offset = "0x185E18C", VA = "0x185E18C")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x185E228", Offset = "0x185E228", VA = "0x185E228")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x200001B")]
public class ES3XMLReader
{
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1939500", Offset = "0x1939500", VA = "0x1939500")]
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

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x15B87A8", Offset = "0x15B87A8", VA = "0x15B87A8")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA06604", Offset = "0xA06604")]
	public bool typeChecking;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA06618", Offset = "0xA06618")]
	public bool safeReflection;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0662C", Offset = "0xA0662C")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA06640", Offset = "0xA06640")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA06654", Offset = "0xA06654")]
	public int serializationDepthLimit;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA06668", Offset = "0xA06668")]
	public string[] assemblyNames;

	[Token(Token = "0x1700000D")]
	public static ES3Defaults defaultSettingsScriptableObject
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x186532C", Offset = "0x186532C", VA = "0x186532C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public static ES3Settings defaultSettings
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1865460", Offset = "0x1865460", VA = "0x1865460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	internal static ES3Settings unencryptedUncompressedSettings
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1865584", Offset = "0x1865584", VA = "0x1865584")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public ES3.Location location
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x18533E0", Offset = "0x18533E0", VA = "0x18533E0")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1865750", Offset = "0x1865750", VA = "0x1865750")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public string FullPath
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1855F5C", Offset = "0x1855F5C", VA = "0x1855F5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1850EAC", Offset = "0x1850EAC", VA = "0x1850EAC")]
	public ES3Settings([Optional] string path, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x18658C4", Offset = "0x18658C4", VA = "0x18658C4")]
	public ES3Settings(string path, params Enum[] enums)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1853688", Offset = "0x1853688", VA = "0x1853688")]
	public ES3Settings(params Enum[] enums)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1865908", Offset = "0x1865908", VA = "0x1865908")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x186594C", Offset = "0x186594C", VA = "0x186594C")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1864F8C", Offset = "0x1864F8C", VA = "0x1864F8C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B3DC", Offset = "0xA0B3DC")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1865758", Offset = "0x1865758", VA = "0x1865758")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x185162C", Offset = "0x185162C", VA = "0x185162C", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B3F0", Offset = "0xA0B3F0")]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x18657FC", Offset = "0x18657FC", VA = "0x18657FC")]
	private void CopyInto(ES3Settings newSettings)
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FEC84", Offset = "0x9FEC84")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1864F28", Offset = "0x1864F28", VA = "0x1864F28")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x18651C4", Offset = "0x18651C4", VA = "0x18651C4")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1865234", Offset = "0x1865234", VA = "0x1865234")]
	public ES3SerializableSettings(string path)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x18652B4", Offset = "0x18652B4", VA = "0x18652B4")]
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

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x185E2B4", Offset = "0x185E2B4", VA = "0x185E2B4")]
	public ES3Ref(long id)
	{
	}
}
[Token(Token = "0x2000020")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FEC98", Offset = "0x9FEC98")]
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
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x13930A8", Offset = "0x13930A8", VA = "0x13930A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x13930F0", Offset = "0x13930F0", VA = "0x13930F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1392F34", Offset = "0x1392F34", VA = "0x1392F34")]
		[DebuggerHidden]
		public <Sync>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1392F60", Offset = "0x1392F60", VA = "0x1392F60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1392F64", Offset = "0x1392F64", VA = "0x1392F64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x13930B0", Offset = "0x13930B0", VA = "0x13930B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FECA8", Offset = "0x9FECA8")]
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
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1C5B3A0", Offset = "0x1C5B3A0", VA = "0x1C5B3A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1C5B3E8", Offset = "0x1C5B3E8", VA = "0x1C5B3E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1C5AFC0", Offset = "0x1C5AFC0", VA = "0x1C5AFC0")]
		[DebuggerHidden]
		public <UploadFile>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1C5AFEC", Offset = "0x1C5AFEC", VA = "0x1C5AFEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1C5B0C4", Offset = "0x1C5B0C4", VA = "0x1C5B0C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1C5B008", Offset = "0x1C5B008", VA = "0x1C5B008")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1C5B3A8", Offset = "0x1C5B3A8", VA = "0x1C5B3A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FECB8", Offset = "0x9FECB8")]
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
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x1391A78", Offset = "0x1391A78", VA = "0x1391A78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x1391AC0", Offset = "0x1391AC0", VA = "0x1391AC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x13915E0", Offset = "0x13915E0", VA = "0x13915E0")]
		[DebuggerHidden]
		public <DownloadFile>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x139160C", Offset = "0x139160C", VA = "0x139160C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x13916E4", Offset = "0x13916E4", VA = "0x13916E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1391628", Offset = "0x1391628", VA = "0x1391628")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1391A80", Offset = "0x1391A80", VA = "0x1391A80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FECC8", Offset = "0x9FECC8")]
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
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1391F18", Offset = "0x1391F18", VA = "0x1391F18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1391F60", Offset = "0x1391F60", VA = "0x1391F60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1391AC8", Offset = "0x1391AC8", VA = "0x1391AC8")]
		[DebuggerHidden]
		public <DownloadFile>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1391AF4", Offset = "0x1391AF4", VA = "0x1391AF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1391BCC", Offset = "0x1391BCC", VA = "0x1391BCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1391B10", Offset = "0x1391B10", VA = "0x1391B10")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1391F20", Offset = "0x1391F20", VA = "0x1391F20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FECD8", Offset = "0x9FECD8")]
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
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1391590", Offset = "0x1391590", VA = "0x1391590", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x13915D8", Offset = "0x13915D8", VA = "0x13915D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1391244", Offset = "0x1391244", VA = "0x1391244")]
		[DebuggerHidden]
		public <DeleteFile>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1391270", Offset = "0x1391270", VA = "0x1391270", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1391348", Offset = "0x1391348", VA = "0x1391348", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x139128C", Offset = "0x139128C", VA = "0x139128C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1391598", Offset = "0x1391598", VA = "0x1391598", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FECE8", Offset = "0x9FECE8")]
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
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1392ABC", Offset = "0x1392ABC", VA = "0x1392ABC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1392B04", Offset = "0x1392B04", VA = "0x1392B04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1392734", Offset = "0x1392734", VA = "0x1392734")]
		[DebuggerHidden]
		public <RenameFile>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1392760", Offset = "0x1392760", VA = "0x1392760", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1392838", Offset = "0x1392838", VA = "0x1392838", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x139277C", Offset = "0x139277C", VA = "0x139277C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1392AC4", Offset = "0x1392AC4", VA = "0x1392AC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FECF8", Offset = "0x9FECF8")]
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
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1392300", Offset = "0x1392300", VA = "0x1392300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1392348", Offset = "0x1392348", VA = "0x1392348", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1391F68", Offset = "0x1391F68", VA = "0x1391F68")]
		[DebuggerHidden]
		public <DownloadFilenames>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1391F94", Offset = "0x1391F94", VA = "0x1391F94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x139206C", Offset = "0x139206C", VA = "0x139206C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1391FB0", Offset = "0x1391FB0", VA = "0x1391FB0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1392308", Offset = "0x1392308", VA = "0x1392308", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FED08", Offset = "0x9FED08")]
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
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x1392EE4", Offset = "0x1392EE4", VA = "0x1392EE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x1392F2C", Offset = "0x1392F2C", VA = "0x1392F2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1392B0C", Offset = "0x1392B0C", VA = "0x1392B0C")]
		[DebuggerHidden]
		public <SearchFilenames>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1392B38", Offset = "0x1392B38", VA = "0x1392B38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1392C10", Offset = "0x1392C10", VA = "0x1392C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1392B54", Offset = "0x1392B54", VA = "0x1392B54")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1392EEC", Offset = "0x1392EEC", VA = "0x1392EEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FED18", Offset = "0x9FED18")]
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
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x13926E4", Offset = "0x13926E4", VA = "0x13926E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x139272C", Offset = "0x139272C", VA = "0x139272C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1392350", Offset = "0x1392350", VA = "0x1392350")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x139237C", Offset = "0x139237C", VA = "0x139237C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1392454", Offset = "0x1392454", VA = "0x1392454", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1392398", Offset = "0x1392398", VA = "0x1392398")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x13926EC", Offset = "0x13926EC", VA = "0x13926EC", Slot = "8")]
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
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x15B52B8", Offset = "0x15B52B8", VA = "0x15B52B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	public string text
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x15B52C0", Offset = "0x15B52C0", VA = "0x15B52C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public string[] filenames
	{
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x15B52F4", Offset = "0x15B52F4", VA = "0x15B52F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public DateTime timestamp
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x15B53C4", Offset = "0x15B53C4", VA = "0x15B53C4")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x15B51F4", Offset = "0x15B51F4", VA = "0x15B51F4")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x15B5250", Offset = "0x15B5250", VA = "0x15B5250")]
	public ES3Cloud(string url, string apiKey, int timeout)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x15B5548", Offset = "0x15B5548", VA = "0x15B5548")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x15B5690", Offset = "0x15B5690", VA = "0x15B5690")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x15B5720", Offset = "0x15B5720", VA = "0x15B5720")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x15B57B4", Offset = "0x15B57B4", VA = "0x15B57B4")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x15B5840", Offset = "0x15B5840", VA = "0x15B5840")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x15B58D4", Offset = "0x15B58D4", VA = "0x15B58D4")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x15B5974", Offset = "0x15B5974", VA = "0x15B5974")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x15B55CC", Offset = "0x15B55CC", VA = "0x15B55CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B404", Offset = "0xA0B404")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x15B5A04", Offset = "0x15B5A04", VA = "0x15B5A04")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x15B5AEC", Offset = "0x15B5AEC", VA = "0x15B5AEC")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x15B5B8C", Offset = "0x15B5B8C", VA = "0x15B5B8C")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x15B5C30", Offset = "0x15B5C30", VA = "0x15B5C30")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x15B5CC8", Offset = "0x15B5CC8", VA = "0x15B5CC8")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x15B5D6C", Offset = "0x15B5D6C", VA = "0x15B5D6C")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x15B5E1C", Offset = "0x15B5E1C", VA = "0x15B5E1C")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x15B5EB8", Offset = "0x15B5EB8", VA = "0x15B5EB8")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x15B6178", Offset = "0x15B6178", VA = "0x15B6178")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x15B6244", Offset = "0x15B6244", VA = "0x15B6244")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x15B5AA0", Offset = "0x15B5AA0", VA = "0x15B5AA0")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x15B6308", Offset = "0x15B6308", VA = "0x15B6308")]
	public IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x15B6090", Offset = "0x15B6090", VA = "0x15B6090")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B464", Offset = "0xA0B464")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password, long fileTimestamp)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x15B636C", Offset = "0x15B636C", VA = "0x15B636C")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x15B64C0", Offset = "0x15B64C0", VA = "0x15B64C0")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x15B6554", Offset = "0x15B6554", VA = "0x15B6554")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x15B65EC", Offset = "0x15B65EC", VA = "0x15B65EC")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x15B667C", Offset = "0x15B667C", VA = "0x15B667C")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x15B6714", Offset = "0x15B6714", VA = "0x15B6714")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x15B67B8", Offset = "0x15B67B8", VA = "0x15B67B8")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x15B684C", Offset = "0x15B684C", VA = "0x15B684C")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x15B697C", Offset = "0x15B697C", VA = "0x15B697C")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x15B69E4", Offset = "0x15B69E4", VA = "0x15B69E4")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x15B68B0", Offset = "0x15B68B0", VA = "0x15B68B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B4C4", Offset = "0xA0B4C4")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x15B63F4", Offset = "0x15B63F4", VA = "0x15B63F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B524", Offset = "0xA0B524")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x15B69EC", Offset = "0x15B69EC", VA = "0x15B69EC")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x15B6B34", Offset = "0x15B6B34", VA = "0x15B6B34")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x15B6BC4", Offset = "0x15B6BC4", VA = "0x15B6BC4")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x15B6C58", Offset = "0x15B6C58", VA = "0x15B6C58")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x15B6CE4", Offset = "0x15B6CE4", VA = "0x15B6CE4")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x15B6D78", Offset = "0x15B6D78", VA = "0x15B6D78")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x15B6E18", Offset = "0x15B6E18", VA = "0x15B6E18")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x15B6A70", Offset = "0x15B6A70", VA = "0x15B6A70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B584", Offset = "0xA0B584")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x15B6EA8", Offset = "0x15B6EA8", VA = "0x15B6EA8")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x15B703C", Offset = "0x15B703C", VA = "0x15B703C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x15B70FC", Offset = "0x15B70FC", VA = "0x15B70FC")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x15B71B4", Offset = "0x15B71B4", VA = "0x15B71B4")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x15B7274", Offset = "0x15B7274", VA = "0x15B7274")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x15B7340", Offset = "0x15B7340", VA = "0x15B7340")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x15B6F64", Offset = "0x15B6F64", VA = "0x15B6F64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B5E4", Offset = "0xA0B5E4")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x15B73FC", Offset = "0x15B73FC", VA = "0x15B73FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B644", Offset = "0xA0B644")]
	public IEnumerator DownloadFilenames(string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x15B74A4", Offset = "0x15B74A4", VA = "0x15B74A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B6A4", Offset = "0xA0B6A4")]
	public IEnumerator SearchFilenames(string searchPattern, string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x15B7568", Offset = "0x15B7568", VA = "0x15B7568")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x15B76B0", Offset = "0x15B76B0", VA = "0x15B76B0")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x15B7740", Offset = "0x15B7740", VA = "0x15B7740")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x15B77D4", Offset = "0x15B77D4", VA = "0x15B77D4")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x15B7860", Offset = "0x15B7860", VA = "0x15B7860")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x15B78F4", Offset = "0x15B78F4", VA = "0x15B78F4")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x15B7994", Offset = "0x15B7994", VA = "0x15B7994")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x15B75EC", Offset = "0x15B75EC", VA = "0x15B75EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0B704", Offset = "0xA0B704")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x15B5F80", Offset = "0x15B5F80", VA = "0x15B5F80")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x15B7A24", Offset = "0x15B7A24", VA = "0x15B7A24")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x15B7A40", Offset = "0x15B7A40", VA = "0x15B7A40", Slot = "4")]
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

	[Token(Token = "0x60001D4")]
	internal abstract void WriteNull();

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1937120", Offset = "0x1937120", VA = "0x1937120", Slot = "6")]
	internal virtual void StartWriteFile()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1937130", Offset = "0x1937130", VA = "0x1937130", Slot = "7")]
	internal virtual void EndWriteFile()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1937140", Offset = "0x1937140", VA = "0x1937140", Slot = "8")]
	internal virtual void StartWriteObject(string name)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1937150", Offset = "0x1937150", VA = "0x1937150", Slot = "9")]
	internal virtual void EndWriteObject(string name)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1937160", Offset = "0x1937160", VA = "0x1937160", Slot = "10")]
	internal virtual void StartWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1937230", Offset = "0x1937230", VA = "0x1937230", Slot = "11")]
	internal virtual void EndWriteProperty(string name)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1937234", Offset = "0x1937234", VA = "0x1937234", Slot = "12")]
	internal virtual void StartWriteCollection()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1937244", Offset = "0x1937244", VA = "0x1937244", Slot = "13")]
	internal virtual void EndWriteCollection()
	{
	}

	[Token(Token = "0x60001DD")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x60001DE")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x60001DF")]
	internal abstract void StartWriteDictionary();

	[Token(Token = "0x60001E0")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x60001E1")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x60001E2")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x60001E3")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x60001E4")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x60001E5")]
	public abstract void Dispose();

	[Token(Token = "0x60001E6")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x60001E7")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x60001E8")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x60001E9")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x60001EA")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x60001EB")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x60001EC")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x60001ED")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x60001EE")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x60001EF")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x60001F0")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x60001F1")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x60001F2")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x60001F3")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x60001F4")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x60001F5")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1937254", Offset = "0x1937254", VA = "0x1937254")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1937324", Offset = "0x1937324", VA = "0x1937324", Slot = "39")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x60001F8")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1937410", Offset = "0x1937410", VA = "0x1937410", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BA34", Offset = "0xA0BA34")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x193754C", Offset = "0x193754C", VA = "0x193754C", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BA48", Offset = "0xA0BA48")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1937618", Offset = "0x1937618", VA = "0x1937618", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BA5C", Offset = "0xA0BA5C")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1937C4C", Offset = "0x1937C4C", VA = "0x1937C4C", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1937DC4", Offset = "0x1937DC4", VA = "0x1937DC4", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1937DEC", Offset = "0x1937DEC", VA = "0x1937DEC", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60001FF")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1937F24", Offset = "0x1937F24", VA = "0x1937F24", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BA70", Offset = "0xA0BA70")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1937F4C", Offset = "0x1937F4C", VA = "0x1937F4C", Slot = "49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BA84", Offset = "0xA0BA84")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1937FE8", Offset = "0x1937FE8", VA = "0x1937FE8", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BA98", Offset = "0xA0BA98")]
	public virtual void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1938100", Offset = "0x1938100", VA = "0x1938100")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1938310", Offset = "0x1938310", VA = "0x1938310")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1938520", Offset = "0x1938520", VA = "0x1938520")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BAAC", Offset = "0xA0BAAC")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x19386E8", Offset = "0x19386E8", VA = "0x19386E8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BAC0", Offset = "0xA0BAC0")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x19388B0", Offset = "0x19388B0", VA = "0x19388B0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BAD4", Offset = "0xA0BAD4")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1938AB4", Offset = "0x1938AB4", VA = "0x1938AB4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BAE8", Offset = "0xA0BAE8")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x19368D8", Offset = "0x19368D8", VA = "0x19368D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BAFC", Offset = "0xA0BAFC")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1938CB8", Offset = "0x1938CB8", VA = "0x1938CB8")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1938D34", Offset = "0x1938D34", VA = "0x1938D34")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1938D44", Offset = "0x1938D44", VA = "0x1938D44")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1938DA4", Offset = "0x1938DA4", VA = "0x1938DA4")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x1937E74", Offset = "0x1937E74", VA = "0x1937E74")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BB10", Offset = "0xA0BB10")]
	protected bool SerializationDepthLimitExceeded()
	{
		return default(bool);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1938F28", Offset = "0x1938F28", VA = "0x1938F28", Slot = "51")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0BB24", Offset = "0xA0BB24")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1938F8C", Offset = "0x1938F8C", VA = "0x1938F8C")]
	protected void Merge()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x19390D8", Offset = "0x19390D8", VA = "0x19390D8")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1939408", Offset = "0x1939408", VA = "0x1939408", Slot = "52")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x193941C", Offset = "0x193941C", VA = "0x193941C", Slot = "53")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200002B")]
public class ES3XMLWriter
{
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1939508", Offset = "0x1939508", VA = "0x1939508")]
	public ES3XMLWriter()
	{
	}
}
[Token(Token = "0x200002C")]
public class ColorChanger : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public enum States
	{
		[Token(Token = "0x40000B7")]
		Blue,
		[Token(Token = "0x40000B8")]
		Green,
		[Token(Token = "0x40000B9")]
		Red
	}

	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FED28", Offset = "0x9FED28")]
	private sealed class <Blue_Enter>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ColorChanger <>4__this;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x138FB14", Offset = "0x138FB14", VA = "0x138FB14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x138FB5C", Offset = "0x138FB5C", VA = "0x138FB5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x138F9D4", Offset = "0x138F9D4", VA = "0x138F9D4")]
		[DebuggerHidden]
		public <Blue_Enter>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x138FA00", Offset = "0x138FA00", VA = "0x138FA00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x138FA04", Offset = "0x138FA04", VA = "0x138FA04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x138FB1C", Offset = "0x138FB1C", VA = "0x138FB1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FED38", Offset = "0x9FED38")]
	private sealed class <Red_Enter>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ColorChanger <>4__this;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x138FE34", Offset = "0x138FE34", VA = "0x138FE34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x138FE7C", Offset = "0x138FE7C", VA = "0x138FE7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x138FCF4", Offset = "0x138FCF4", VA = "0x138FCF4")]
		[DebuggerHidden]
		public <Red_Enter>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x138FD20", Offset = "0x138FD20", VA = "0x138FD20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x138FD24", Offset = "0x138FD24", VA = "0x138FD24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x138FE3C", Offset = "0x138FE3C", VA = "0x138FE3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FED48", Offset = "0x9FED48")]
	private sealed class <Green_Enter>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ColorChanger <>4__this;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x138FCA4", Offset = "0x138FCA4", VA = "0x138FCA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x138FCEC", Offset = "0x138FCEC", VA = "0x138FCEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x138FB64", Offset = "0x138FB64", VA = "0x138FB64")]
		[DebuggerHidden]
		public <Green_Enter>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x138FB90", Offset = "0x138FB90", VA = "0x138FB90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x138FB94", Offset = "0x138FB94", VA = "0x138FB94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x138FCAC", Offset = "0x138FCAC", VA = "0x138FCAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float interval;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera cam;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private StateMachine<States> fsm;

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x15AA2CC", Offset = "0x15AA2CC", VA = "0x15AA2CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x15AA36C", Offset = "0x15AA36C", VA = "0x15AA36C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0BB38", Offset = "0xA0BB38")]
	private IEnumerator Blue_Enter()
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x15AA3E4", Offset = "0x15AA3E4", VA = "0x15AA3E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0BB98", Offset = "0xA0BB98")]
	private IEnumerator Red_Enter()
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x15AA45C", Offset = "0x15AA45C", VA = "0x15AA45C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0BBF8", Offset = "0xA0BBF8")]
	private IEnumerator Green_Enter()
	{
		return null;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x15AA4D4", Offset = "0x15AA4D4", VA = "0x15AA4D4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x15AA5C8", Offset = "0x15AA5C8", VA = "0x15AA5C8")]
	public ColorChanger()
	{
	}
}
[Token(Token = "0x2000031")]
public class ExampleAdvanced : MonoBehaviour
{
	[Token(Token = "0x2000032")]
	public enum States
	{
		[Token(Token = "0x40000CA")]
		Idle,
		[Token(Token = "0x40000CB")]
		Play,
		[Token(Token = "0x40000CC")]
		GameWin,
		[Token(Token = "0x40000CD")]
		GameLose
	}

	[Token(Token = "0x2000033")]
	public class Driver
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateEvent Update;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StateEvent OnGUI;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StateEvent<Item> OnItemSelected;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1C5C234", Offset = "0x1C5C234", VA = "0x1C5C234")]
		public Driver()
		{
		}
	}

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item prefab;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float roundTime;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Item> spawnedItems;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Item targetItem;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float playStartTime;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private StateMachine<States, Driver> fsm;

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1939604", Offset = "0x1939604", VA = "0x1939604")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x19396AC", Offset = "0x19396AC", VA = "0x19396AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1939708", Offset = "0x1939708", VA = "0x1939708")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1939764", Offset = "0x1939764", VA = "0x1939764")]
	private void DestroyItem(Item item)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1939914", Offset = "0x1939914", VA = "0x1939914")]
	private void Idle_OnGUI()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x19399F4", Offset = "0x19399F4", VA = "0x19399F4")]
	private void Play_Enter()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1939CE8", Offset = "0x1939CE8", VA = "0x1939CE8")]
	private void Play_OnGUI()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1939E3C", Offset = "0x1939E3C", VA = "0x1939E3C")]
	private void Play_Update()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1939EBC", Offset = "0x1939EBC", VA = "0x1939EBC")]
	private void Play_OnItemSelected(Item item)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1939F7C", Offset = "0x1939F7C", VA = "0x1939F7C")]
	private void GameWin_Enter()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x193A074", Offset = "0x193A074", VA = "0x193A074")]
	private void GameWin_OnGUI()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x193A1A4", Offset = "0x193A1A4", VA = "0x193A1A4")]
	private void GameWin_Exit()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x193A1D4", Offset = "0x193A1D4", VA = "0x193A1D4")]
	private void GameLose_Enter()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x193A2B8", Offset = "0x193A2B8", VA = "0x193A2B8")]
	private void GameLose_OnGUI()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x193A3E8", Offset = "0x193A3E8", VA = "0x193A3E8")]
	public ExampleAdvanced()
	{
	}
}
[Token(Token = "0x2000034")]
public class ExampleBasic : MonoBehaviour
{
	[Token(Token = "0x2000035")]
	public enum States
	{
		[Token(Token = "0x40000D6")]
		Init,
		[Token(Token = "0x40000D7")]
		Countdown,
		[Token(Token = "0x40000D8")]
		Play,
		[Token(Token = "0x40000D9")]
		Win,
		[Token(Token = "0x40000DA")]
		Lose
	}

	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FED58", Offset = "0x9FED58")]
	private sealed class <Countdown_Enter>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ExampleBasic <>4__this;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x1C5C4AC", Offset = "0x1C5C4AC", VA = "0x1C5C4AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x1C5C4F4", Offset = "0x1C5C4F4", VA = "0x1C5C4F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1C5C23C", Offset = "0x1C5C23C", VA = "0x1C5C23C")]
		[DebuggerHidden]
		public <Countdown_Enter>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1C5C268", Offset = "0x1C5C268", VA = "0x1C5C268", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1C5C26C", Offset = "0x1C5C26C", VA = "0x1C5C26C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1C5C4B4", Offset = "0x1C5C4B4", VA = "0x1C5C4B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float health;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float damage;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float startHealth;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private StateMachine<States, StateDriverUnity> fsm;

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x193A3F0", Offset = "0x193A3F0", VA = "0x193A3F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x193A4A0", Offset = "0x193A4A0", VA = "0x193A4A0")]
	private void Update()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x193A4FC", Offset = "0x193A4FC", VA = "0x193A4FC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x193A5A8", Offset = "0x193A5A8", VA = "0x193A5A8")]
	private void Init_Enter()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x193A61C", Offset = "0x193A61C", VA = "0x193A61C")]
	private void Init_OnGUI()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x193A748", Offset = "0x193A748", VA = "0x193A748")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0BD48", Offset = "0xA0BD48")]
	private IEnumerator Countdown_Enter()
	{
		return null;
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x193A7C0", Offset = "0x193A7C0", VA = "0x193A7C0")]
	private void Countdown_OnGUI()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x193A8A0", Offset = "0x193A8A0", VA = "0x193A8A0")]
	private void Play_Enter()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x193A914", Offset = "0x193A914", VA = "0x193A914")]
	private void Play_Update()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x193A9A4", Offset = "0x193A9A4", VA = "0x193A9A4")]
	private void Play_OnGUI()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x193AC1C", Offset = "0x193AC1C", VA = "0x193AC1C")]
	private void Play_Exit()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x193AC90", Offset = "0x193AC90", VA = "0x193AC90")]
	private void Lose_Enter()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x193AD04", Offset = "0x193AD04", VA = "0x193AD04")]
	private void Lose_OnGUI()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x193AE30", Offset = "0x193AE30", VA = "0x193AE30")]
	private void Win_Enter()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x193AEA4", Offset = "0x193AEA4", VA = "0x193AEA4")]
	private void Win_OnGUI()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x193AFD0", Offset = "0x193AFD0", VA = "0x193AFD0")]
	public ExampleBasic()
	{
	}
}
[Token(Token = "0x2000037")]
public class Item : MonoBehaviour
{
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isTarget;

	[Token(Token = "0x14000001")]
	public event Action<Item> Triggered
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1939C48", Offset = "0x1939C48", VA = "0x1939C48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BDF8", Offset = "0xA0BDF8")]
		add
		{
		}
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1939874", Offset = "0x1939874", VA = "0x1939874")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BE08", Offset = "0xA0BE08")]
		remove
		{
		}
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x193ED1C", Offset = "0x193ED1C", VA = "0x193ED1C")]
	public void OnMouseDown()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x193ED7C", Offset = "0x193ED7C", VA = "0x193ED7C")]
	public Item()
	{
	}
}
[Token(Token = "0x2000038")]
public class StressTest : MonoBehaviour
{
	[Token(Token = "0x2000039")]
	private enum States
	{
		[Token(Token = "0x40000E3")]
		State0,
		[Token(Token = "0x40000E4")]
		State1,
		[Token(Token = "0x40000E5")]
		State2,
		[Token(Token = "0x40000E6")]
		State3,
		[Token(Token = "0x40000E7")]
		State4,
		[Token(Token = "0x40000E8")]
		State5,
		[Token(Token = "0x40000E9")]
		State6,
		[Token(Token = "0x40000EA")]
		State7,
		[Token(Token = "0x40000EB")]
		State8,
		[Token(Token = "0x40000EC")]
		State9,
		[Token(Token = "0x40000ED")]
		State10,
		[Token(Token = "0x40000EE")]
		State11,
		[Token(Token = "0x40000EF")]
		State12,
		[Token(Token = "0x40000F0")]
		State13,
		[Token(Token = "0x40000F1")]
		State14
	}

	[Token(Token = "0x200003A")]
	public class Driver
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateEvent Update;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StateEvent<int> OnChanged;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1C5F210", Offset = "0x1C5F210", VA = "0x1C5F210")]
		public Driver()
		{
		}
	}

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private StateMachine<States, Driver> fsm;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int value;

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x138A114", Offset = "0x138A114", VA = "0x138A114")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x138A1BC", Offset = "0x138A1BC", VA = "0x138A1BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x138A274", Offset = "0x138A274", VA = "0x138A274")]
	private void State1_Update()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x138A284", Offset = "0x138A284", VA = "0x138A284")]
	private void State1_OnChanged(int value)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x138A28C", Offset = "0x138A28C", VA = "0x138A28C")]
	private void State2_Update()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x138A29C", Offset = "0x138A29C", VA = "0x138A29C")]
	private void State2_OnChanged(int value)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x138A2A8", Offset = "0x138A2A8", VA = "0x138A2A8")]
	public StressTest()
	{
	}
}
[Token(Token = "0x200003B")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x13885BC", Offset = "0x13885BC", VA = "0x13885BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x13886EC", Offset = "0x13886EC", VA = "0x13886EC")]
	public void OnRebuild()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1388780", Offset = "0x1388780", VA = "0x1388780")]
	private void OnMuscleDisconnected(Muscle m)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1388844", Offset = "0x1388844", VA = "0x1388844")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x13889C8", Offset = "0x13889C8", VA = "0x13889C8")]
	public Skeleton()
	{
	}
}
namespace RotaryHeart.Lib
{
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9FED68", Offset = "0x9FED68")]
	public class DataBaseExample : ScriptableObject
	{
		[Token(Token = "0x200003D")]
		public enum EnumExample
		{
			[Token(Token = "0x400010E")]
			None,
			[Token(Token = "0x400010F")]
			Value1,
			[Token(Token = "0x4000110")]
			Value2,
			[Token(Token = "0x4000111")]
			Value3,
			[Token(Token = "0x4000112")]
			Value4,
			[Token(Token = "0x4000113")]
			Value5,
			[Token(Token = "0x4000114")]
			Value6
		}

		[Serializable]
		[Token(Token = "0x200003E")]
		public class ChildTest
		{
			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color myChildColor;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool myChildBool;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Gradient test;

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1390168", Offset = "0x1390168", VA = "0x1390168")]
			public ChildTest()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003F")]
		public class ClassTest
		{
			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float test;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string test2;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion quat;

			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ChildTest[] childTest;

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x1390170", Offset = "0x1390170", VA = "0x1390170")]
			public ClassTest()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000040")]
		public class ArrayTest
		{
			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] myArray;

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x13900E8", Offset = "0x13900E8", VA = "0x13900E8")]
			public ArrayTest()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000041")]
		public class AdvancedGenericClass
		{
			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA06820", Offset = "0xA06820")]
			public float value;

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x138FF74", Offset = "0x138FF74", VA = "0x138FF74")]
			public bool Equals(AdvancedGenericClass other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x138FFA4", Offset = "0x138FFA4", VA = "0x138FFA4", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x13900D4", Offset = "0x13900D4", VA = "0x13900D4", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x13900E0", Offset = "0x13900E0", VA = "0x13900E0")]
			public AdvancedGenericClass()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000042")]
		public class Generic_String : SerializableDictionaryBase<ClassTest, string>
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x13903D0", Offset = "0x13903D0", VA = "0x13903D0")]
			public Generic_String()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000043")]
		public class Generic_Generic : SerializableDictionaryBase<ClassTest, ClassTest>
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x1390358", Offset = "0x1390358", VA = "0x1390358")]
			public Generic_Generic()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000044")]
		public class C_Int : SerializableDictionaryBase<char, int>
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x13900F0", Offset = "0x13900F0", VA = "0x13900F0")]
			public C_Int()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000045")]
		public class G_Int : SerializableDictionaryBase<Gradient, int>
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x13902E0", Offset = "0x13902E0", VA = "0x13902E0")]
			public G_Int()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000046")]
		public class I_GO : SerializableDictionaryBase<int, GameObject>
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x1390448", Offset = "0x1390448", VA = "0x1390448")]
			public I_GO()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000047")]
		public class GO_I : SerializableDictionaryBase<GameObject, int>
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x13901F0", Offset = "0x13901F0", VA = "0x13901F0")]
			public GO_I()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000048")]
		public class S_GO : SerializableDictionaryBase<string, GameObject>
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1390718", Offset = "0x1390718", VA = "0x1390718")]
			public S_GO()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000049")]
		public class GO_S : SerializableDictionaryBase<GameObject, string>
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1390268", Offset = "0x1390268", VA = "0x1390268")]
			public GO_S()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004A")]
		public class S_Mat : SerializableDictionaryBase<string, Material>
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1390808", Offset = "0x1390808", VA = "0x1390808")]
			public S_Mat()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004B")]
		public class Mat_S : SerializableDictionaryBase<Material, string>
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x13905B0", Offset = "0x13905B0", VA = "0x13905B0")]
			public Mat_S()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004C")]
		public class S_AC : SerializableDictionaryBase<string, AudioClip>
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x13906A0", Offset = "0x13906A0", VA = "0x13906A0")]
			public S_AC()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004D")]
		public class AC_S : SerializableDictionaryBase<AudioClip, string>
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x138FE84", Offset = "0x138FE84", VA = "0x138FE84")]
			public AC_S()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004E")]
		public class S_Sprite : SerializableDictionaryBase<string, Sprite>
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1390880", Offset = "0x1390880", VA = "0x1390880")]
			public S_Sprite()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004F")]
		public class V3_Q : SerializableDictionaryBase<Vector3, Quaternion>
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x13908F8", Offset = "0x13908F8", VA = "0x13908F8")]
			public V3_Q()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000050")]
		public class Q_V3 : SerializableDictionaryBase<Quaternion, Vector3>
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x1390628", Offset = "0x1390628", VA = "0x1390628")]
			public Q_V3()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000051")]
		public class S_GenericDictionary : SerializableDictionaryBase<string, ClassTest>
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x1390790", Offset = "0x1390790", VA = "0x1390790")]
			public S_GenericDictionary()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000052")]
		public class I_GenericDictionary : SerializableDictionaryBase<int, ClassTest>
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x13904C0", Offset = "0x13904C0", VA = "0x13904C0")]
			public I_GenericDictionary()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000053")]
		public class Int_IntArray : SerializableDictionaryBase<int, ArrayTest>
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x1390538", Offset = "0x1390538", VA = "0x1390538")]
			public Int_IntArray()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000054")]
		public class Enum_String : SerializableDictionaryBase<EnumExample, string>
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x1390178", Offset = "0x1390178", VA = "0x1390178")]
			public Enum_String()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000055")]
		public class AdvanGeneric_String : SerializableDictionaryBase<AdvancedGenericClass, string>
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x138FEFC", Offset = "0x138FEFC", VA = "0x138FEFC")]
			public AdvanGeneric_String()
			{
			}
		}

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Generic_String _genericString;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Generic_Generic _genericGeneric;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "IDAttribute", RVA = "0xA066AC", Offset = "0xA066AC")]
		[SerializeField]
		private S_GenericDictionary _stringGeneric;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private I_GenericDictionary _intGeneric;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private I_GO _intGameobject;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GO_I _gameobjectInt;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private S_GO _stringGameobject;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GO_S _gameobjectString;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private S_Mat _stringMaterial;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Mat_S _materialString;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private V3_Q _vector3Quaternion;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Q_V3 _quaternionVector3;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private S_AC _stringAudioClip;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AC_S _audioClipString;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private C_Int _charInt;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private G_Int _gradientInt;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Int_IntArray _intArray;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Enum_String _enumString;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[DrawKeyAsProperty]
		private AdvanGeneric_String _advancedGenericKey;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x15AA95C", Offset = "0x15AA95C", VA = "0x15AA95C")]
		public DataBaseExample()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9FEDC8", Offset = "0x9FEDC8")]
	public class NestedDB : ScriptableObject
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "IDAttribute", RVA = "0xA0683C", Offset = "0xA0683C")]
		[SerializeField]
		public MainDict nested;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x15764C8", Offset = "0x15764C8", VA = "0x15764C8")]
		public NestedDB()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class Example
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public QueryTriggerInteraction enumVal;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NestedDict nestedData;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x19395FC", Offset = "0x19395FC", VA = "0x19395FC")]
		public Example()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class NestedExample
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color color;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Nested2Dict deepNested;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1576548", Offset = "0x1576548", VA = "0x1576548")]
		public NestedExample()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class MainDict : SerializableDictionaryBase<string, Example>
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x156F174", Offset = "0x156F174", VA = "0x156F174")]
		public MainDict()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class NestedDict : SerializableDictionaryBase<int, NestedExample>
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x15764D0", Offset = "0x15764D0", VA = "0x15764D0")]
		public NestedDict()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class Nested2Dict : SerializableDictionaryBase<QueryTriggerInteraction, string>
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1576450", Offset = "0x1576450", VA = "0x1576450")]
		public Nested2Dict()
		{
		}
	}
}
namespace RotaryHeart.Lib.SerializableDictionary
{
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9FEE28", Offset = "0x9FEE28")]
	public class DrawKeyAsPropertyAttribute : Attribute
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15AB010", Offset = "0x15AB010", VA = "0x15AB010")]
		public DrawKeyAsPropertyAttribute()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9FEE3C", Offset = "0x9FEE3C")]
	public class IDAttribute : Attribute
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _id;

		[Token(Token = "0x17000030")]
		public string Id
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x193DFDC", Offset = "0x193DFDC", VA = "0x193DFDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x193DFE4", Offset = "0x193DFE4", VA = "0x193DFE4")]
		public IDAttribute(string id)
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class RequiredReferences : ScriptableObject
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _gameObject;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material _material;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _audioClip;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x13873A8", Offset = "0x13873A8", VA = "0x13873A8")]
		public RequiredReferences()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class ReorderableList
	{
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x13873A0", Offset = "0x13873A0", VA = "0x13873A0")]
		public ReorderableList()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public abstract class DrawableDictionary
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public ReorderableList reorderableList;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public RequiredReferences reqReferences;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isExpanded;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x15AB018", Offset = "0x15AB018", VA = "0x15AB018")]
		protected DrawableDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9FEE50", Offset = "0x9FEE50")]
	public class SerializableDictionaryBase<TKey, TValue> : DrawableDictionary, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, ISerializationCallbackReceiver
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> _dict;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<TKey, TValue> _staticEmptyDict;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _keyValues;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _keys;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> _values;

		[Token(Token = "0x17000031")]
		public TValue Item
		{
			[Token(Token = "0x6000291")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x6000292")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6000293")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6000294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public int Count
		{
			[Token(Token = "0x6000295")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000035")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
		{
			[Token(Token = "0x6000296")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028C")]
		public void CopyFrom(IDictionary<TKey, TValue> src)
		{
		}

		[Token(Token = "0x600028D")]
		public void CopyFrom(object src)
		{
		}

		[Token(Token = "0x600028E")]
		public void CopyTo(IDictionary<TKey, TValue> dest)
		{
		}

		[Token(Token = "0x600028F")]
		public Dictionary<TKey, TValue> Clone()
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6000299")]
		public void Clear()
		{
		}

		[Token(Token = "0x600029A")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x600029D")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600029F")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default(Dictionary<TKey, TValue>.Enumerator);
		}

		[Token(Token = "0x60002A1")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60002A4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60002A5")]
		public SerializableDictionaryBase()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9FEE88", Offset = "0x9FEE88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FEE88", Offset = "0x9FEE88")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000063")]
		public enum Mode
		{
			[Token(Token = "0x4000146")]
			AnimationClips,
			[Token(Token = "0x4000147")]
			AnimationStates,
			[Token(Token = "0x4000148")]
			PlayableDirector,
			[Token(Token = "0x4000149")]
			Realtime
		}

		[Token(Token = "0x2000064")]
		public delegate void BakerDelegate(AnimationClip clip, float time);

		[Serializable]
		[Token(Token = "0x2000065")]
		public class ClipSettings
		{
			[Serializable]
			[Token(Token = "0x2000066")]
			public enum BasedUponRotation
			{
				[Token(Token = "0x4000157")]
				Original,
				[Token(Token = "0x4000158")]
				BodyOrientation
			}

			[Serializable]
			[Token(Token = "0x2000067")]
			public enum BasedUponY
			{
				[Token(Token = "0x400015A")]
				Original,
				[Token(Token = "0x400015B")]
				CenterOfMass,
				[Token(Token = "0x400015C")]
				Feet
			}

			[Serializable]
			[Token(Token = "0x2000068")]
			public enum BasedUponXZ
			{
				[Token(Token = "0x400015E")]
				Original,
				[Token(Token = "0x400015F")]
				CenterOfMass
			}

			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool loopTime;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool loopBlend;

			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float cycleOffset;

			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool loopBlendOrientation;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public BasedUponRotation basedUponRotation;

			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float orientationOffsetY;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool loopBlendPositionY;

			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BasedUponY basedUponY;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float level;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool loopBlendPositionXZ;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public BasedUponXZ basedUponXZ;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool mirror;

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x138DF8C", Offset = "0x138DF8C", VA = "0x138DF8C")]
			public ClipSettings()
			{
			}
		}

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06908", Offset = "0xA06908")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA06908", Offset = "0xA06908")]
		public int frameRate;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06960", Offset = "0xA06960")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA06960", Offset = "0xA06960")]
		public float keyReductionError;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA069B8", Offset = "0xA069B8")]
		public Mode mode;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA069F0", Offset = "0xA069F0")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06A28", Offset = "0xA06A28")]
		public string[] animationStates;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06A60", Offset = "0xA06A60")]
		public string saveToFolder;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06A98", Offset = "0xA06A98")]
		public string appendName;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06AD0", Offset = "0xA06AD0")]
		public string saveName;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06B08", Offset = "0xA06B08")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06B18", Offset = "0xA06B18")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BakerDelegate OnStartClip;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BakerDelegate OnUpdateClip;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06B48", Offset = "0xA06B48")]
		public bool inheritClipSettings;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06B80", Offset = "0xA06B80")]
		public ClipSettings clipSettings;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06BB8", Offset = "0xA06BB8")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected bool addLoopFrame;

		[Token(Token = "0x17000036")]
		public bool isBaking
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1AB922C", Offset = "0x1AB922C", VA = "0x1AB922C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BEF8", Offset = "0xA0BEF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1AB9234", Offset = "0x1AB9234", VA = "0x1AB9234")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF08", Offset = "0xA0BF08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float bakingProgress
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1AB9240", Offset = "0x1AB9240", VA = "0x1AB9240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF18", Offset = "0xA0BF18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1AB9248", Offset = "0x1AB9248", VA = "0x1AB9248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF28", Offset = "0xA0BF28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		protected float clipLength
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1AB9250", Offset = "0x1AB9250", VA = "0x1AB9250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF38", Offset = "0xA0BF38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1AB9258", Offset = "0x1AB9258", VA = "0x1AB9258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF48", Offset = "0xA0BF48")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1AB910C", Offset = "0x1AB910C", VA = "0x1AB910C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0BE18", Offset = "0xA0BE18")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1AB9154", Offset = "0x1AB9154", VA = "0x1AB9154")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0BE50", Offset = "0xA0BE50")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1AB919C", Offset = "0x1AB919C", VA = "0x1AB919C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0BE88", Offset = "0xA0BE88")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1AB91E4", Offset = "0x1AB91E4", VA = "0x1AB91E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0BEC0", Offset = "0xA0BEC0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002AF")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x60002B0")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x60002B1")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x60002B2")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x60002B3")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1AB9260", Offset = "0x1AB9260", VA = "0x1AB9260")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1AB9264", Offset = "0x1AB9264", VA = "0x1AB9264")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1AB9268", Offset = "0x1AB9268", VA = "0x1AB9268")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1AB926C", Offset = "0x1AB926C", VA = "0x1AB926C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06BC8", Offset = "0xA06BC8")]
		public bool markAsLegacy;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06C00", Offset = "0xA06C00")]
		public Transform root;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06C38", Offset = "0xA06C38")]
		public Transform rootNode;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06C70", Offset = "0xA06C70")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06CA8", Offset = "0xA06CA8")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerTransform[] children;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int rootChildIndex;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x193B65C", Offset = "0x193B65C", VA = "0x193B65C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x193BA60", Offset = "0x193BA60", VA = "0x193BA60", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x193BA68", Offset = "0x193BA68", VA = "0x193BA68", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x193BB78", Offset = "0x193BB78", VA = "0x193BB78", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x193BBF4", Offset = "0x193BBF4", VA = "0x193BBF4", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x193BC70", Offset = "0x193BC70", VA = "0x193BC70", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x193B8B8", Offset = "0x193B8B8", VA = "0x193B8B8")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x193B98C", Offset = "0x193B98C", VA = "0x193B98C")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x193BCEC", Offset = "0x193BCEC", VA = "0x193BCEC")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class TQ
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x138BB44", Offset = "0x138BB44", VA = "0x138BB44")]
		public TQ()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x138BB4C", Offset = "0x138BB4C", VA = "0x138BB4C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class AvatarUtility
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1AB7EB8", Offset = "0x1AB7EB8", VA = "0x1AB7EB8")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1AB8120", Offset = "0x1AB8120", VA = "0x1AB8120")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1AB86E4", Offset = "0x1AB86E4", VA = "0x1AB86E4")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1AB8B90", Offset = "0x1AB8B90", VA = "0x1AB8B90")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1AB8100", Offset = "0x1AB8100", VA = "0x1AB8100")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1AB8D24", Offset = "0x1AB8D24", VA = "0x1AB8D24")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public static class BakerUtilities
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1ABA75C", Offset = "0x1ABA75C", VA = "0x1ABA75C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1ABC08C", Offset = "0x1ABC08C", VA = "0x1ABC08C")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1ABA1AC", Offset = "0x1ABA1AC", VA = "0x1ABA1AC")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1ABA7A4", Offset = "0x1ABA7A4", VA = "0x1ABA7A4")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1AB9CDC", Offset = "0x1AB9CDC", VA = "0x1AB9CDC")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1AB9380", Offset = "0x1AB9380", VA = "0x1AB9380")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1AB9694", Offset = "0x1AB9694", VA = "0x1AB9694")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1AB9870", Offset = "0x1AB9870", VA = "0x1AB9870")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1AB992C", Offset = "0x1AB992C", VA = "0x1AB992C")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1AB8C54", Offset = "0x1AB8C54", VA = "0x1AB8C54")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1AB99AC", Offset = "0x1AB99AC", VA = "0x1AB99AC")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1AB9538", Offset = "0x1AB9538", VA = "0x1AB9538")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1AB99B0", Offset = "0x1AB99B0", VA = "0x1AB99B0")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1AB9F40", Offset = "0x1AB9F40", VA = "0x1AB9F40")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1ABA03C", Offset = "0x1ABA03C", VA = "0x1ABA03C")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1ABA138", Offset = "0x1ABA138", VA = "0x1ABA138")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1ABA3A4", Offset = "0x1ABA3A4", VA = "0x1ABA3A4")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1ABA0B0", Offset = "0x1ABA0B0", VA = "0x1ABA0B0")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1ABA3A8", Offset = "0x1ABA3A8", VA = "0x1ABA3A8")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1ABA45C", Offset = "0x1ABA45C", VA = "0x1ABA45C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class BakerMuscle
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1ABA7A8", Offset = "0x1ABA7A8", VA = "0x1ABA7A8")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1ABA824", Offset = "0x1ABA824", VA = "0x1ABA824")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1ABB2C0", Offset = "0x1ABB2C0", VA = "0x1ABB2C0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1ABB374", Offset = "0x1ABB374", VA = "0x1ABB374")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1ABB25C", Offset = "0x1ABB25C", VA = "0x1ABB25C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1ABB46C", Offset = "0x1ABB46C", VA = "0x1ABB46C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1ABB4B4", Offset = "0x1ABB4B4", VA = "0x1ABB4B4")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class BakerTransform
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1ABB4BC", Offset = "0x1ABB4BC", VA = "0x1ABB4BC")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1ABB6AC", Offset = "0x1ABB6AC", VA = "0x1ABB6AC")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1ABB6C0", Offset = "0x1ABB6C0", VA = "0x1ABB6C0")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1ABB9AC", Offset = "0x1ABB9AC", VA = "0x1ABB9AC")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1ABB568", Offset = "0x1ABB568", VA = "0x1ABB568")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1ABBC60", Offset = "0x1ABBC60", VA = "0x1ABBC60")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1ABBCD4", Offset = "0x1ABBCD4", VA = "0x1ABBCD4")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1ABBE88", Offset = "0x1ABBE88", VA = "0x1ABBE88")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06CE0", Offset = "0xA06CE0")]
		public bool bakeHandIK;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA06D18", Offset = "0xA06D18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06D18", Offset = "0xA06D18")]
		public float IKKeyReductionError;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA06D70", Offset = "0xA06D70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06D70", Offset = "0xA06D70")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] muscles;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private HumanPose pose;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion bodyRotation;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mN;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x193D1CC", Offset = "0x193D1CC", VA = "0x193D1CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x193D760", Offset = "0x193D760", VA = "0x193D760", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x193D77C", Offset = "0x193D77C", VA = "0x193D77C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x193D858", Offset = "0x193D858", VA = "0x193D858", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x193D934", Offset = "0x193D934", VA = "0x193D934", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x193DB04", Offset = "0x193DB04", VA = "0x193DB04", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x193DE4C", Offset = "0x193DE4C", VA = "0x193DE4C")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x193DF38", Offset = "0x193DF38", VA = "0x193DF38")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public enum UpdateMode
		{
			[Token(Token = "0x40001C3")]
			Update,
			[Token(Token = "0x40001C4")]
			FixedUpdate,
			[Token(Token = "0x40001C5")]
			LateUpdate,
			[Token(Token = "0x40001C6")]
			FixedLateUpdate
		}

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA06DC4", Offset = "0xA06DC4")]
		public bool smoothFollow;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA06DFC", Offset = "0xA06DFC")]
		public float rotationSensitivity;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA06E34", Offset = "0xA06E34")]
		public float distance;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA06E6C", Offset = "0xA06E6C")]
		public LayerMask blockingLayers;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA06EA4", Offset = "0xA06EA4")]
		public float blockedOffset;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06EBC", Offset = "0xA06EBC")]
		private float <x>k__BackingField;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06ECC", Offset = "0xA06ECC")]
		private float <y>k__BackingField;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06EDC", Offset = "0xA06EDC")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000039")]
		public float x
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x15A566C", Offset = "0x15A566C", VA = "0x15A566C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF58", Offset = "0xA0BF58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x15A5674", Offset = "0x15A5674", VA = "0x15A5674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF68", Offset = "0xA0BF68")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float y
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x15A567C", Offset = "0x15A567C", VA = "0x15A567C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF78", Offset = "0xA0BF78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x15A5684", Offset = "0x15A5684", VA = "0x15A5684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF88", Offset = "0xA0BF88")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public float distanceTarget
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x15A568C", Offset = "0x15A568C", VA = "0x15A568C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BF98", Offset = "0xA0BF98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x15A5694", Offset = "0x15A5694", VA = "0x15A5694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0BFA8", Offset = "0xA0BFA8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		private float zoomAdd
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x15A5F7C", Offset = "0x15A5F7C", VA = "0x15A5F7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x15A569C", Offset = "0x15A569C", VA = "0x15A569C")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x15A56D8", Offset = "0x15A56D8", VA = "0x15A56D8")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x15A56E0", Offset = "0x15A56E0", VA = "0x15A56E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x15A57F0", Offset = "0x15A57F0", VA = "0x15A57F0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x15A584C", Offset = "0x15A584C", VA = "0x15A584C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x15A58B4", Offset = "0x15A58B4", VA = "0x15A58B4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x15A5918", Offset = "0x15A5918", VA = "0x15A5918")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x15A5824", Offset = "0x15A5824", VA = "0x15A5824")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x15A5A98", Offset = "0x15A5A98", VA = "0x15A5A98")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x15A5F4C", Offset = "0x15A5F4C", VA = "0x15A5F4C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x15A5FEC", Offset = "0x15A5FEC", VA = "0x15A5FEC")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x15A6098", Offset = "0x15A6098", VA = "0x15A6098")]
		private void Awake()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x15A60D0", Offset = "0x15A60D0", VA = "0x15A60D0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x15A6278", Offset = "0x15A6278", VA = "0x15A6278")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x15A62A8", Offset = "0x15A62A8", VA = "0x15A62A8")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public enum Axis
	{
		[Token(Token = "0x40001CD")]
		X,
		[Token(Token = "0x40001CE")]
		Y,
		[Token(Token = "0x40001CF")]
		Z
	}
	[Token(Token = "0x2000075")]
	public class AxisTools
	{
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1AB8D2C", Offset = "0x1AB8D2C", VA = "0x1AB8D2C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1AB8D50", Offset = "0x1AB8D50", VA = "0x1AB8D50")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1AB8D88", Offset = "0x1AB8D88", VA = "0x1AB8D88")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1AB8E78", Offset = "0x1AB8E78", VA = "0x1AB8E78")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1AB8E20", Offset = "0x1AB8E20", VA = "0x1AB8E20")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1AB8F10", Offset = "0x1AB8F10", VA = "0x1AB8F10")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1AB8F58", Offset = "0x1AB8F58", VA = "0x1AB8F58")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1AB9104", Offset = "0x1AB9104", VA = "0x1AB9104")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000077")]
		public class LimbOrientation
		{
			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x138F778", Offset = "0x138F778", VA = "0x138F778")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700003D")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1AC1998", Offset = "0x1AC1998", VA = "0x1AC1998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1AC1C08", Offset = "0x1AC1C08", VA = "0x1AC1C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1AC1918", Offset = "0x1AC1918", VA = "0x1AC1918")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000078")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public enum BoneType
		{
			[Token(Token = "0x40001EA")]
			Unassigned,
			[Token(Token = "0x40001EB")]
			Spine,
			[Token(Token = "0x40001EC")]
			Head,
			[Token(Token = "0x40001ED")]
			Arm,
			[Token(Token = "0x40001EE")]
			Leg,
			[Token(Token = "0x40001EF")]
			Tail,
			[Token(Token = "0x40001F0")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public enum BoneSide
		{
			[Token(Token = "0x40001F2")]
			Center,
			[Token(Token = "0x40001F3")]
			Left,
			[Token(Token = "0x40001F4")]
			Right
		}

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1AC1E78", Offset = "0x1AC1E78", VA = "0x1AC1E78")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1AC219C", Offset = "0x1AC219C", VA = "0x1AC219C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1AC2410", Offset = "0x1AC2410", VA = "0x1AC2410")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1AC2490", Offset = "0x1AC2490", VA = "0x1AC2490")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1AC2538", Offset = "0x1AC2538", VA = "0x1AC2538")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1AC2050", Offset = "0x1AC2050", VA = "0x1AC2050")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1AC2374", Offset = "0x1AC2374", VA = "0x1AC2374")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1AC2D68", Offset = "0x1AC2D68", VA = "0x1AC2D68")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1AC2B70", Offset = "0x1AC2B70", VA = "0x1AC2B70")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1AC2C6C", Offset = "0x1AC2C6C", VA = "0x1AC2C6C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1AC2750", Offset = "0x1AC2750", VA = "0x1AC2750")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1AC2800", Offset = "0x1AC2800", VA = "0x1AC2800")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1AC28B0", Offset = "0x1AC28B0", VA = "0x1AC28B0")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1AC2960", Offset = "0x1AC2960", VA = "0x1AC2960")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1AC2A10", Offset = "0x1AC2A10", VA = "0x1AC2A10")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1AC2AC0", Offset = "0x1AC2AC0", VA = "0x1AC2AC0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1AC2F70", Offset = "0x1AC2F70", VA = "0x1AC2F70")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1AC2668", Offset = "0x1AC2668", VA = "0x1AC2668")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1AC2EE0", Offset = "0x1AC2EE0", VA = "0x1AC2EE0")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1AC2FDC", Offset = "0x1AC2FDC", VA = "0x1AC2FDC")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1AC30B0", Offset = "0x1AC30B0", VA = "0x1AC30B0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1AC2E68", Offset = "0x1AC2E68", VA = "0x1AC2E68")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1AC2DF4", Offset = "0x1AC2DF4", VA = "0x1AC2DF4")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class BipedReferences
	{
		[Token(Token = "0x200007C")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000041")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600034E")]
				[Address(RVA = "0x138F83C", Offset = "0x138F83C", VA = "0x138F83C")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x138F828", Offset = "0x138F828", VA = "0x138F828")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700003F")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x15A17B0", Offset = "0x15A17B0", VA = "0x15A17B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public bool isEmpty
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x15A1B98", Offset = "0x15A1B98", VA = "0x15A1B98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x15A1BA8", Offset = "0x15A1BA8", VA = "0x15A1BA8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x15A1FD0", Offset = "0x15A1FD0", VA = "0x15A1FD0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x15A2404", Offset = "0x15A2404", VA = "0x15A2404")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x15A2B58", Offset = "0x15A2B58", VA = "0x15A2B58")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x15A26B4", Offset = "0x15A26B4", VA = "0x15A26B4")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x15A33E8", Offset = "0x15A33E8", VA = "0x15A33E8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x15A34E4", Offset = "0x15A34E4", VA = "0x15A34E4")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x15A3AA4", Offset = "0x15A3AA4", VA = "0x15A3AA4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x15A3884", Offset = "0x15A3884", VA = "0x15A3884")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x15A3700", Offset = "0x15A3700", VA = "0x15A3700")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x15A3584", Offset = "0x15A3584", VA = "0x15A3584")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x15A3990", Offset = "0x15A3990", VA = "0x15A3990")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x15A3B9C", Offset = "0x15A3B9C", VA = "0x15A3B9C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x15A4784", Offset = "0x15A4784", VA = "0x15A4784")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x15A41F4", Offset = "0x15A41F4", VA = "0x15A41F4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x15A4A80", Offset = "0x15A4A80", VA = "0x15A4A80")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x15A456C", Offset = "0x15A456C", VA = "0x15A456C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x15A4A88", Offset = "0x15A4A88", VA = "0x15A4A88")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x15A4A90", Offset = "0x15A4A90", VA = "0x15A4A90")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x15A4C64", Offset = "0x15A4C64", VA = "0x15A4C64")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x15A4E2C", Offset = "0x15A4E2C", VA = "0x15A4E2C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x15A2630", Offset = "0x15A2630", VA = "0x15A2630")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0xA06EEC", Offset = "0xA06EEC")]
		public string text;

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x15AA5D0", Offset = "0x15AA5D0", VA = "0x15AA5D0")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x15AADE0", Offset = "0x15AADE0", VA = "0x15AADE0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x15AAF28", Offset = "0x15AAF28", VA = "0x15AAF28")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class Hierarchy
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x193C32C", Offset = "0x193C32C", VA = "0x193C32C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x193C518", Offset = "0x193C518", VA = "0x193C518")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x193C3C4", Offset = "0x193C3C4", VA = "0x193C3C4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x193C638", Offset = "0x193C638", VA = "0x193C638")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x193C764", Offset = "0x193C764", VA = "0x193C764")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x193C9B8", Offset = "0x193C9B8", VA = "0x193C9B8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x193CAC0", Offset = "0x193CAC0", VA = "0x193CAC0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x193CC34", Offset = "0x193CC34", VA = "0x193CC34")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x193D010", Offset = "0x193D010", VA = "0x193D010")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x193CDD4", Offset = "0x193CDD4", VA = "0x193CDD4")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x193D1C4", Offset = "0x193D1C4", VA = "0x193D1C4")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x193E084", Offset = "0x193E084", VA = "0x193E084")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x193E110", Offset = "0x193E110", VA = "0x193E110")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400020E")]
		None,
		[Token(Token = "0x400020F")]
		InOutCubic,
		[Token(Token = "0x4000210")]
		InOutQuintic,
		[Token(Token = "0x4000211")]
		InOutSine,
		[Token(Token = "0x4000212")]
		InQuintic,
		[Token(Token = "0x4000213")]
		InQuartic,
		[Token(Token = "0x4000214")]
		InCubic,
		[Token(Token = "0x4000215")]
		InQuadratic,
		[Token(Token = "0x4000216")]
		InElastic,
		[Token(Token = "0x4000217")]
		InElasticSmall,
		[Token(Token = "0x4000218")]
		InElasticBig,
		[Token(Token = "0x4000219")]
		InSine,
		[Token(Token = "0x400021A")]
		InBack,
		[Token(Token = "0x400021B")]
		OutQuintic,
		[Token(Token = "0x400021C")]
		OutQuartic,
		[Token(Token = "0x400021D")]
		OutCubic,
		[Token(Token = "0x400021E")]
		OutInCubic,
		[Token(Token = "0x400021F")]
		OutInQuartic,
		[Token(Token = "0x4000220")]
		OutElastic,
		[Token(Token = "0x4000221")]
		OutElasticSmall,
		[Token(Token = "0x4000222")]
		OutElasticBig,
		[Token(Token = "0x4000223")]
		OutSine,
		[Token(Token = "0x4000224")]
		OutBack,
		[Token(Token = "0x4000225")]
		OutBackCubic,
		[Token(Token = "0x4000226")]
		OutBackQuartic,
		[Token(Token = "0x4000227")]
		BackInCubic,
		[Token(Token = "0x4000228")]
		BackInQuartic
	}
	[Token(Token = "0x2000082")]
	public class Interp
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x193E1A0", Offset = "0x193E1A0", VA = "0x193E1A0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x193EB4C", Offset = "0x193EB4C", VA = "0x193EB4C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x193EBC0", Offset = "0x193EBC0", VA = "0x193EBC0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x193E5B4", Offset = "0x193E5B4", VA = "0x193E5B4")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x193E5C0", Offset = "0x193E5C0", VA = "0x193E5C0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x193E5E4", Offset = "0x193E5E4", VA = "0x193E5E4")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x193E620", Offset = "0x193E620", VA = "0x193E620")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x193E638", Offset = "0x193E638", VA = "0x193E638")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x193E64C", Offset = "0x193E64C", VA = "0x193E64C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x193E660", Offset = "0x193E660", VA = "0x193E660")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x193E670", Offset = "0x193E670", VA = "0x193E670")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x193E6B8", Offset = "0x193E6B8", VA = "0x193E6B8")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x193E6F0", Offset = "0x193E6F0", VA = "0x193E6F0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x193E718", Offset = "0x193E718", VA = "0x193E718")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x193EC4C", Offset = "0x193EC4C", VA = "0x193EC4C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x193E74C", Offset = "0x193E74C", VA = "0x193E74C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x193E774", Offset = "0x193E774", VA = "0x193E774")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x193E7A4", Offset = "0x193E7A4", VA = "0x193E7A4")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x193E7D8", Offset = "0x193E7D8", VA = "0x193E7D8")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x193E81C", Offset = "0x193E81C", VA = "0x193E81C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x193E880", Offset = "0x193E880", VA = "0x193E880")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x193E8E4", Offset = "0x193E8E4", VA = "0x193E8E4")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x193E938", Offset = "0x193E938", VA = "0x193E938")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x193E98C", Offset = "0x193E98C", VA = "0x193E98C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x193E9C8", Offset = "0x193E9C8", VA = "0x193E9C8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x193EA00", Offset = "0x193EA00", VA = "0x193EA00")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x193EC80", Offset = "0x193EC80", VA = "0x193EC80")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x193EA48", Offset = "0x193EA48", VA = "0x193EA48")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x193EADC", Offset = "0x193EADC", VA = "0x193EADC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x193EB0C", Offset = "0x193EB0C", VA = "0x193EB0C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x193ED14", Offset = "0x193ED14", VA = "0x193ED14")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x193FE50", Offset = "0x193FE50", VA = "0x193FE50")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x193FEA8", Offset = "0x193FEA8", VA = "0x193FEA8")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x193FF74", Offset = "0x193FF74", VA = "0x193FF74")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x193FEC0", Offset = "0x193FEC0", VA = "0x193FEC0")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x193FF8C", Offset = "0x193FF8C", VA = "0x193FF8C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1940030", Offset = "0x1940030", VA = "0x1940030")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x194005C", Offset = "0x194005C", VA = "0x194005C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x19400AC", Offset = "0x19400AC", VA = "0x19400AC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1940118", Offset = "0x1940118", VA = "0x1940118")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x194022C", Offset = "0x194022C", VA = "0x194022C")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1940324", Offset = "0x1940324", VA = "0x1940324")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1940380", Offset = "0x1940380", VA = "0x1940380")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public abstract class LazySingleton<T> : MonoBehaviour where T : LazySingleton<T>
	{
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000042")]
		public static bool hasInstance
		{
			[Token(Token = "0x600038A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public static T instance
		{
			[Token(Token = "0x600038B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038C")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600038D")]
		protected LazySingleton()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public enum ShowIfMode
	{
		[Token(Token = "0x400022B")]
		Disabled,
		[Token(Token = "0x400022C")]
		Hidden
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9FEEF8", Offset = "0x9FEEF8")]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06EFC", Offset = "0xA06EFC")]
		private string <propName>k__BackingField;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06F0C", Offset = "0xA06F0C")]
		private object <propValue>k__BackingField;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06F1C", Offset = "0xA06F1C")]
		private object <otherPropValue>k__BackingField;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06F2C", Offset = "0xA06F2C")]
		private bool <indent>k__BackingField;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06F3C", Offset = "0xA06F3C")]
		private ShowIfMode <mode>k__BackingField;

		[Token(Token = "0x17000044")]
		public string propName
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x1387BFC", Offset = "0x1387BFC", VA = "0x1387BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C028", Offset = "0xA0C028")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1387C04", Offset = "0x1387C04", VA = "0x1387C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C038", Offset = "0xA0C038")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public object propValue
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x1387C0C", Offset = "0x1387C0C", VA = "0x1387C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C048", Offset = "0xA0C048")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x1387C14", Offset = "0x1387C14", VA = "0x1387C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C058", Offset = "0xA0C058")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public object otherPropValue
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x1387C1C", Offset = "0x1387C1C", VA = "0x1387C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C068", Offset = "0xA0C068")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x1387C24", Offset = "0x1387C24", VA = "0x1387C24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C078", Offset = "0xA0C078")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool indent
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x1387C2C", Offset = "0x1387C2C", VA = "0x1387C2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C088", Offset = "0xA0C088")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1387C34", Offset = "0x1387C34", VA = "0x1387C34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C098", Offset = "0xA0C098")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public ShowIfMode mode
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1387C40", Offset = "0x1387C40", VA = "0x1387C40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0A8", Offset = "0xA0C0A8")]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1387C48", Offset = "0x1387C48", VA = "0x1387C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0B8", Offset = "0xA0C0B8")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1387C50", Offset = "0x1387C50", VA = "0x1387C50")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9FEF30", Offset = "0x9FEF30")]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06F4C", Offset = "0xA06F4C")]
		private float <min>k__BackingField;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06F5C", Offset = "0xA06F5C")]
		private float <max>k__BackingField;

		[Token(Token = "0x17000049")]
		public float min
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x1387E68", Offset = "0x1387E68", VA = "0x1387E68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0C8", Offset = "0xA0C0C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x1387E70", Offset = "0x1387E70", VA = "0x1387E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0D8", Offset = "0xA0C0D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float max
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x1387E78", Offset = "0x1387E78", VA = "0x1387E78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0E8", Offset = "0xA0C0E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1387E80", Offset = "0x1387E80", VA = "0x1387E80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0F8", Offset = "0xA0C0F8")]
			private set
			{
			}
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1387E88", Offset = "0x1387E88", VA = "0x1387E88")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string color;

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1387CD4", Offset = "0x1387CD4", VA = "0x1387CD4")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1387D9C", Offset = "0x1387D9C", VA = "0x1387D9C")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x193FD34", Offset = "0x193FD34", VA = "0x193FD34")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x193FDC0", Offset = "0x193FDC0", VA = "0x193FDC0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public static class QuaTools
	{
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x13849F8", Offset = "0x13849F8", VA = "0x13849F8")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1384A54", Offset = "0x1384A54", VA = "0x1384A54")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1384AE4", Offset = "0x1384AE4", VA = "0x1384AE4")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1384C44", Offset = "0x1384C44", VA = "0x1384C44")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1384D00", Offset = "0x1384D00", VA = "0x1384D00")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1384DBC", Offset = "0x1384DBC", VA = "0x1384DBC")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1384F68", Offset = "0x1384F68", VA = "0x1384F68")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1384FB8", Offset = "0x1384FB8", VA = "0x1384FB8")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1385008", Offset = "0x1385008", VA = "0x1385008")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x13850B0", Offset = "0x13850B0", VA = "0x13850B0")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1385158", Offset = "0x1385158", VA = "0x1385158")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1385238", Offset = "0x1385238", VA = "0x1385238")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x138528C", Offset = "0x138528C", VA = "0x138528C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1385360", Offset = "0x1385360", VA = "0x1385360")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1385470", Offset = "0x1385470", VA = "0x1385470")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1385600", Offset = "0x1385600", VA = "0x1385600")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x13856F4", Offset = "0x13856F4", VA = "0x13856F4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1385800", Offset = "0x1385800", VA = "0x1385800")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x13858EC", Offset = "0x13858EC", VA = "0x13858EC")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1385948", Offset = "0x1385948", VA = "0x1385948")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1385A84", Offset = "0x1385A84", VA = "0x1385A84")]
		public static Quaternion MirrorYZ(Quaternion r)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200008B")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700004B")]
		public static T instance
		{
			[Token(Token = "0x60003B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B9")]
		public static void Clear()
		{
		}

		[Token(Token = "0x60003BA")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003BB")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06F6C", Offset = "0xA06F6C")]
		public bool fixTransforms;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700004C")]
		private bool animatePhysics
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1389348", Offset = "0x1389348", VA = "0x1389348")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		private bool isAnimated
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x1389694", Offset = "0x1389694", VA = "0x1389694")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1389208", Offset = "0x1389208", VA = "0x1389208")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x13892A8", Offset = "0x13892A8", VA = "0x13892A8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x13892AC", Offset = "0x13892AC", VA = "0x13892AC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x13892B0", Offset = "0x13892B0", VA = "0x13892B0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x13892B4", Offset = "0x13892B4", VA = "0x13892B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1389344", Offset = "0x1389344", VA = "0x1389344")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x13892EC", Offset = "0x13892EC", VA = "0x13892EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1389648", Offset = "0x1389648", VA = "0x1389648")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1389434", Offset = "0x1389434", VA = "0x1389434")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x138974C", Offset = "0x138974C", VA = "0x138974C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x13897A8", Offset = "0x13897A8", VA = "0x13897A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1389804", Offset = "0x1389804", VA = "0x1389804")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x138984C", Offset = "0x138984C", VA = "0x138984C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x138BBBC", Offset = "0x138BBBC", VA = "0x138BBBC")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x138BC7C", Offset = "0x138BC7C", VA = "0x138BC7C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x138BD3C", Offset = "0x138BD3C", VA = "0x138BD3C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x138BDFC", Offset = "0x138BDFC", VA = "0x138BDFC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public static class V2Tools
	{
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x138C828", Offset = "0x138C828", VA = "0x138C828")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x138C830", Offset = "0x138C830", VA = "0x138C830")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x138C880", Offset = "0x138C880", VA = "0x138C880")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x138C8D4", Offset = "0x138C8D4", VA = "0x138C8D4")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x138C9AC", Offset = "0x138C9AC", VA = "0x138C9AC")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008F")]
	public static class V3Tools
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x138CA40", Offset = "0x138CA40", VA = "0x138CA40")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x138CA64", Offset = "0x138CA64", VA = "0x138CA64")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x138CAAC", Offset = "0x138CAAC", VA = "0x138CAAC")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x138CB38", Offset = "0x138CB38", VA = "0x138CB38")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x138CB98", Offset = "0x138CB98", VA = "0x138CB98")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x138CBF8", Offset = "0x138CBF8", VA = "0x138CBF8")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x138CD14", Offset = "0x138CD14", VA = "0x138CD14")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x138CDB4", Offset = "0x138CDB4", VA = "0x138CDB4")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x138CDF0", Offset = "0x138CDF0", VA = "0x138CDF0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x138CEC0", Offset = "0x138CEC0", VA = "0x138CEC0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x138CFB8", Offset = "0x138CFB8", VA = "0x138CFB8")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x138D060", Offset = "0x138D060", VA = "0x138D060")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x138D1BC", Offset = "0x138D1BC", VA = "0x138D1BC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x138D338", Offset = "0x138D338", VA = "0x138D338")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x138D4BC", Offset = "0x138D4BC", VA = "0x138D4BC")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x138D578", Offset = "0x138D578", VA = "0x138D578")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x138D678", Offset = "0x138D678", VA = "0x138D678")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x138D700", Offset = "0x138D700", VA = "0x138D700")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x138D79C", Offset = "0x138D79C", VA = "0x138D79C")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x138D840", Offset = "0x138D840", VA = "0x138D840")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x138D830", Offset = "0x138D830", VA = "0x138D830")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000090")]
	public static class Warning
	{
		[Token(Token = "0x2000091")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x138D8C0", Offset = "0x138D8C0", VA = "0x138D8C0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x138D958", Offset = "0x138D958", VA = "0x138D958")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000092")]
	public class Actuator : MonoBehaviour
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spring;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float damper;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody r;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float lastSpring;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lastDamper;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1AB7894", Offset = "0x1AB7894", VA = "0x1AB7894")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1AB7B84", Offset = "0x1AB7B84", VA = "0x1AB7B84")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1AB7C84", Offset = "0x1AB7C84", VA = "0x1AB7C84")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1AB7CF4", Offset = "0x1AB7CF4", VA = "0x1AB7CF4")]
		public Actuator()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1AB7D44", Offset = "0x1AB7D44", VA = "0x1AB7D44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1AB7DAC", Offset = "0x1AB7DAC", VA = "0x1AB7DAC")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x2000095")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x2000096")]
		public delegate void BehaviourUpdateDelegate(float deltaTime);

		[Token(Token = "0x2000097")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x2000098")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x2000099")]
		public struct PuppetEvent
		{
			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA06FD4", Offset = "0xA06FD4")]
			public string switchToBehaviour;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0700C", Offset = "0xA0700C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07044", Offset = "0xA07044")]
			public UnityEvent unityEvent;

			[Token(Token = "0x400026D")]
			private const string empty = "";

			[Token(Token = "0x1700004F")]
			public bool switchBehaviour
			{
				[Token(Token = "0x6000434")]
				[Address(RVA = "0x138EE58", Offset = "0x138EE58", VA = "0x138EE58")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x138EEE8", Offset = "0x138EEE8", VA = "0x138EEE8")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009A")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000272")]
			private const string empty = "";

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x138DF94", Offset = "0x138DF94", VA = "0x138DF94")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x138E064", Offset = "0x138E064", VA = "0x138E064")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x138E164", Offset = "0x138E164", VA = "0x138E164")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x138E240", Offset = "0x138E240", VA = "0x138E240")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourUpdateDelegate OnPreFixedUpdate;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourUpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourUpdateDelegate OnPreLateUpdate;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourUpdateDelegate OnPreRead;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourUpdateDelegate OnPreWrite;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourUpdateDelegate OnPostFixedUpdate;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourUpdateDelegate OnPostUpdate;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourUpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourUpdateDelegate OnPostRead;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourUpdateDelegate OnPostWrite;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06FC4", Offset = "0xA06FC4")]
		private bool <forceActive>k__BackingField;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x4000269")]
		private const string typeSpringBase = "BehaviourBase";

		[Token(Token = "0x1700004E")]
		public bool forceActive
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1ABC72C", Offset = "0x1ABC72C", VA = "0x1ABC72C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C108", Offset = "0xA0C108")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x1ABC734", Offset = "0x1ABC734", VA = "0x1ABC734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C118", Offset = "0xA0C118")]
			protected set
			{
			}
		}

		[Token(Token = "0x60003F6")]
		public abstract void OnReactivate();

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1ABC6B0", Offset = "0x1ABC6B0", VA = "0x1ABC6B0", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1ABC6B4", Offset = "0x1ABC6B4", VA = "0x1ABC6B4", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1ABC6B8", Offset = "0x1ABC6B8", VA = "0x1ABC6B8", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1ABC6BC", Offset = "0x1ABC6BC", VA = "0x1ABC6BC", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1ABC6C0", Offset = "0x1ABC6C0", VA = "0x1ABC6C0", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1ABC6C4", Offset = "0x1ABC6C4", VA = "0x1ABC6C4", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1ABC6C8", Offset = "0x1ABC6C8", VA = "0x1ABC6C8", Slot = "11")]
		public virtual void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1ABC6CC", Offset = "0x1ABC6CC", VA = "0x1ABC6CC", Slot = "12")]
		public virtual void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1ABC6D0", Offset = "0x1ABC6D0", VA = "0x1ABC6D0", Slot = "13")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1ABC6E4", Offset = "0x1ABC6E4", VA = "0x1ABC6E4", Slot = "14")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1ABC6F8", Offset = "0x1ABC6F8", VA = "0x1ABC6F8", Slot = "15")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1ABC6FC", Offset = "0x1ABC6FC", VA = "0x1ABC6FC", Slot = "16")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1ABC700", Offset = "0x1ABC700", VA = "0x1ABC700", Slot = "17")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1ABC704", Offset = "0x1ABC704", VA = "0x1ABC704", Slot = "18")]
		protected virtual void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1ABC708", Offset = "0x1ABC708", VA = "0x1ABC708", Slot = "19")]
		protected virtual void OnUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1ABC70C", Offset = "0x1ABC70C", VA = "0x1ABC70C", Slot = "20")]
		protected virtual void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1ABC710", Offset = "0x1ABC710", VA = "0x1ABC710", Slot = "21")]
		protected virtual void OnReadBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1ABC714", Offset = "0x1ABC714", VA = "0x1ABC714", Slot = "22")]
		protected virtual void OnWriteBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1ABC718", Offset = "0x1ABC718", VA = "0x1ABC718", Slot = "23")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1ABC71C", Offset = "0x1ABC71C", VA = "0x1ABC71C", Slot = "24")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1ABC720", Offset = "0x1ABC720", VA = "0x1ABC720", Slot = "25")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1ABC724", Offset = "0x1ABC724", VA = "0x1ABC724", Slot = "26")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1ABC728", Offset = "0x1ABC728", VA = "0x1ABC728", Slot = "27")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1ABC740", Offset = "0x1ABC740", VA = "0x1ABC740")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1ABC7A0", Offset = "0x1ABC7A0", VA = "0x1ABC7A0")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1ABC80C", Offset = "0x1ABC80C", VA = "0x1ABC80C")]
		public void OnRead(float deltaTime)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1ABC894", Offset = "0x1ABC894", VA = "0x1ABC894")]
		public void OnWrite(float deltaTime)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1ABC91C", Offset = "0x1ABC91C", VA = "0x1ABC91C")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1ABC9AC", Offset = "0x1ABC9AC", VA = "0x1ABC9AC")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1ABCA5C", Offset = "0x1ABCA5C", VA = "0x1ABCA5C")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1ABCB0C", Offset = "0x1ABCB0C", VA = "0x1ABCB0C")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1ABCC30", Offset = "0x1ABCC30", VA = "0x1ABCC30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1ABCC88", Offset = "0x1ABCC88", VA = "0x1ABCC88")]
		public void FixedUpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1ABCD5C", Offset = "0x1ABCD5C", VA = "0x1ABCD5C")]
		public void UpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1ABCE30", Offset = "0x1ABCE30", VA = "0x1ABCE30")]
		public void LateUpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1ABCF04", Offset = "0x1ABCF04", VA = "0x1ABCF04", Slot = "28")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1ABCF48", Offset = "0x1ABCF48", VA = "0x1ABCF48", Slot = "29")]
		protected virtual string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1ABCF8C", Offset = "0x1ABCF8C", VA = "0x1ABCF8C")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1ABD0C0", Offset = "0x1ABD0C0", VA = "0x1ABD0C0")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1ABD1F4", Offset = "0x1ABD1F4", VA = "0x1ABD1F4")]
		protected void RemovePropMuscles()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1ABD328", Offset = "0x1ABD328", VA = "0x1ABD328", Slot = "30")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1ABD2A0", Offset = "0x1ABD2A0", VA = "0x1ABD2A0")]
		protected bool ContainsRemovablePropMuscle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1ABD534", Offset = "0x1ABD534", VA = "0x1ABD534")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9FEF68", Offset = "0x9FEF68")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FEF68", Offset = "0x9FEF68")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FEFC8", Offset = "0x9FEFC8")]
		private sealed class <SmoothActivate>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x17000050")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x138F320", Offset = "0x138F320", VA = "0x138F320", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x138F368", Offset = "0x138F368", VA = "0x138F368", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x138F104", Offset = "0x138F104", VA = "0x138F104")]
			[DebuggerHidden]
			public <SmoothActivate>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x138F130", Offset = "0x138F130", VA = "0x138F130", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x138F134", Offset = "0x138F134", VA = "0x138F134", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x138F328", Offset = "0x138F328", VA = "0x138F328", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000273")]
		private const string typeSpring = "BehaviourFall";

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0707C", Offset = "0xA0707C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA0707C", Offset = "0xA0707C")]
		public string stateName;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA070DC", Offset = "0xA070DC")]
		public float transitionDuration;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07114", Offset = "0xA07114")]
		public int layer;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0714C", Offset = "0xA0714C")]
		public float fixedTime;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA07184", Offset = "0xA07184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07184", Offset = "0xA07184")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA071E4", Offset = "0xA071E4")]
		public string blendParameter;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0721C", Offset = "0xA0721C")]
		public float writheHeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07254", Offset = "0xA07254")]
		public float writheYVelocity;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0728C", Offset = "0xA0728C")]
		public float blendSpeed;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA072C4", Offset = "0xA072C4")]
		public float blendMappingSpeed;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA072FC", Offset = "0xA072FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA072FC", Offset = "0xA072FC")]
		public bool canEnd;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0735C", Offset = "0xA0735C")]
		public float minTime;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07394", Offset = "0xA07394")]
		public float maxEndVelocity;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA073CC", Offset = "0xA073CC")]
		public PuppetEvent onEnd;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1ABD53C", Offset = "0x1ABD53C", VA = "0x1ABD53C", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1ABD580", Offset = "0x1ABD580", VA = "0x1ABD580")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C128", Offset = "0xA0C128")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1ABD5C8", Offset = "0x1ABD5C8", VA = "0x1ABD5C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C160", Offset = "0xA0C160")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1ABD610", Offset = "0x1ABD610", VA = "0x1ABD610", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1ABD6C8", Offset = "0x1ABD6C8", VA = "0x1ABD6C8", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1ABD6D0", Offset = "0x1ABD6D0", VA = "0x1ABD6D0", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1ABD650", Offset = "0x1ABD650", VA = "0x1ABD650")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0C198", Offset = "0xA0C198")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1ABD6DC", Offset = "0x1ABD6DC", VA = "0x1ABD6DC", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1ABDB2C", Offset = "0x1ABDB2C", VA = "0x1ABDB2C", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1ABDCAC", Offset = "0x1ABDCAC", VA = "0x1ABDCAC", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1ABD9E0", Offset = "0x1ABD9E0", VA = "0x1ABD9E0")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1ABD8CC", Offset = "0x1ABD8CC", VA = "0x1ABD8CC")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1ABDD14", Offset = "0x1ABDD14", VA = "0x1ABDD14", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1ABDD3C", Offset = "0x1ABDD3C", VA = "0x1ABDD3C")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9FEFD8", Offset = "0x9FEFD8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FEFD8", Offset = "0x9FEFD8")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public enum State
		{
			[Token(Token = "0x40002C1")]
			Puppet,
			[Token(Token = "0x40002C2")]
			Unpinned,
			[Token(Token = "0x40002C3")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public enum NormalMode
		{
			[Token(Token = "0x40002C5")]
			Active,
			[Token(Token = "0x40002C6")]
			Unmapped,
			[Token(Token = "0x40002C7")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class MasterProps
		{
			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x138F768", Offset = "0x138F768", VA = "0x138F768")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A1")]
		public struct MuscleProps
		{
			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07C9C", Offset = "0xA07C9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07C9C", Offset = "0xA07C9C")]
			public float unpinParents;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07CF0", Offset = "0xA07CF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07CF0", Offset = "0xA07CF0")]
			public float unpinChildren;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07D44", Offset = "0xA07D44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07D44", Offset = "0xA07D44")]
			public float unpinGroup;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07D98", Offset = "0xA07D98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07D98", Offset = "0xA07D98")]
			public float minMappingWeight;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07DEC", Offset = "0xA07DEC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07DEC", Offset = "0xA07DEC")]
			public float maxMappingWeight;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07E40", Offset = "0xA07E40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07E40", Offset = "0xA07E40")]
			public float minPinWeight;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07E94", Offset = "0xA07E94")]
			public bool disableColliders;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07ECC", Offset = "0xA07ECC")]
			public float regainPinSpeed;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07F04", Offset = "0xA07F04")]
			public float collisionResistance;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07F3C", Offset = "0xA07F3C")]
			public float knockOutDistance;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07F74", Offset = "0xA07F74")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07FAC", Offset = "0xA07FAC")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07FF4", Offset = "0xA07FF4")]
			public Muscle.Group[] groups;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0802C", Offset = "0xA0802C")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08064", Offset = "0xA08064")]
			public float multiplier;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0809C", Offset = "0xA0809C")]
			public float collisionThreshold;
		}

		[Token(Token = "0x20000A4")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x4000288")]
		private const string typeSpring = "BehaviourPuppet";

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA07404", Offset = "0xA07404")]
		public MasterProps masterProps;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0743C", Offset = "0xA0743C")]
		public LayerMask groundLayers;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07474", Offset = "0xA07474")]
		public LayerMask collisionLayers;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA074AC", Offset = "0xA074AC")]
		public float collisionThreshold;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA074E4", Offset = "0xA074E4")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0751C", Offset = "0xA0751C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0751C", Offset = "0xA0751C")]
		public int maxCollisions;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07570", Offset = "0xA07570")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07570", Offset = "0xA07570")]
		public float regainPinSpeed;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA075C8", Offset = "0xA075C8")]
		public float boostFalloff;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA07600", Offset = "0xA07600")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07600", Offset = "0xA07600")]
		public MuscleProps defaults;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07660", Offset = "0xA07660")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA07698", Offset = "0xA07698")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07698", Offset = "0xA07698")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07698", Offset = "0xA07698")]
		public float knockOutDistance;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA07714", Offset = "0xA07714")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07714", Offset = "0xA07714")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07768", Offset = "0xA07768")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA077A0", Offset = "0xA077A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA077A0", Offset = "0xA077A0")]
		public float pinWeightThreshold;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA077F4", Offset = "0xA077F4")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0782C", Offset = "0xA0782C")]
		public bool dropProps;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA07864", Offset = "0xA07864")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07864", Offset = "0xA07864")]
		public bool canGetUp;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA078C4", Offset = "0xA078C4")]
		public float getUpDelay;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA078FC", Offset = "0xA078FC")]
		public float blendToAnimationTime;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07934", Offset = "0xA07934")]
		public float maxGetUpVelocity;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0796C", Offset = "0xA0796C")]
		public float minGetUpDuration;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA079A4", Offset = "0xA079A4")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA079DC", Offset = "0xA079DC")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07A14", Offset = "0xA07A14")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07A4C", Offset = "0xA07A4C")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07A84", Offset = "0xA07A84")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07ABC", Offset = "0xA07ABC")]
		public bool isQuadruped;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07AF4", Offset = "0xA07AF4")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA07AF4", Offset = "0xA07AF4")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07B54", Offset = "0xA07B54")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07B8C", Offset = "0xA07B8C")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07BC4", Offset = "0xA07BC4")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07BFC", Offset = "0xA07BFC")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA07C34", Offset = "0xA07C34")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public CollisionDelegate OnCollision;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07C6C", Offset = "0xA07C6C")]
		private State <state>k__BackingField;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private float unpinnedTimer;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private float getUpTimer;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private Vector3 hipsForward;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private Vector3 hipsUp;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private bool getUpTargetFixed;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private int collisions;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool eventsEnabled;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private float lastKnockOutDistance;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
		private bool getupDisabled;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A5")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A6")]
		private bool hasBoosted;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07C8C", Offset = "0xA07C8C")]
		private Vector3 <getUpPosition>k__BackingField;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private bool dropPropFlag;

		[Token(Token = "0x17000052")]
		public State state
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1ABDEBC", Offset = "0x1ABDEBC", VA = "0x1ABDEBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C2B8", Offset = "0xA0C2B8")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1ABDEC4", Offset = "0x1ABDEC4", VA = "0x1ABDEC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C2C8", Offset = "0xA0C2C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 getUpPosition
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1AC15D4", Offset = "0x1AC15D4", VA = "0x1AC15D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C2D8", Offset = "0xA0C2D8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1AC15E4", Offset = "0x1AC15E4", VA = "0x1AC15E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C2E8", Offset = "0xA0C2E8")]
			set
			{
			}
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1ABDDE8", Offset = "0x1ABDDE8", VA = "0x1ABDDE8", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1ABDE2C", Offset = "0x1ABDE2C", VA = "0x1ABDE2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C248", Offset = "0xA0C248")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1ABDE74", Offset = "0x1ABDE74", VA = "0x1ABDE74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C280", Offset = "0xA0C280")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1ABDECC", Offset = "0x1ABDECC", VA = "0x1ABDECC", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1ABE1C4", Offset = "0x1ABE1C4", VA = "0x1ABE1C4")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1ABE238", Offset = "0x1ABE238", VA = "0x1ABE238", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1ABE2D0", Offset = "0x1ABE2D0", VA = "0x1ABE2D0", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1ABE8F0", Offset = "0x1ABE8F0", VA = "0x1ABE8F0", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1ABF070", Offset = "0x1ABF070", VA = "0x1ABF070", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1ABF114", Offset = "0x1ABF114", VA = "0x1ABF114", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1ABF11C", Offset = "0x1ABF11C", VA = "0x1ABF11C", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1ABF1A4", Offset = "0x1ABF1A4", VA = "0x1ABF1A4", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1ABF1B0", Offset = "0x1ABF1B0", VA = "0x1ABF1B0", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1ABF90C", Offset = "0x1ABF90C", VA = "0x1ABF90C", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1ABFBE0", Offset = "0x1ABFBE0", VA = "0x1ABFBE0")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1ABFCC8", Offset = "0x1ABFCC8", VA = "0x1ABFCC8", Slot = "21")]
		protected override void OnReadBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1ABFAA4", Offset = "0x1ABFAA4", VA = "0x1ABFAA4")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to, float deltaTime)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1ABFF4C", Offset = "0x1ABFF4C", VA = "0x1ABFF4C", Slot = "13")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1ABFF90", Offset = "0x1ABFF90", VA = "0x1ABFF90", Slot = "14")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1ABFF14", Offset = "0x1ABFF14", VA = "0x1ABFF14")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1ABFFCC", Offset = "0x1ABFFCC", VA = "0x1ABFFCC")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1AC0004", Offset = "0x1AC0004", VA = "0x1AC0004", Slot = "30")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1AC0018", Offset = "0x1AC0018", VA = "0x1AC0018")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1AC0230", Offset = "0x1AC0230", VA = "0x1AC0230")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1AC02C0", Offset = "0x1AC02C0", VA = "0x1AC02C0")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1AC03D8", Offset = "0x1AC03D8", VA = "0x1AC03D8")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1AC059C", Offset = "0x1AC059C", VA = "0x1AC059C")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1AC0304", Offset = "0x1AC0304", VA = "0x1AC0304")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1AC0614", Offset = "0x1AC0614", VA = "0x1AC0614")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1AC06B8", Offset = "0x1AC06B8", VA = "0x1AC06B8")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1AC0370", Offset = "0x1AC0370", VA = "0x1AC0370")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1AC0728", Offset = "0x1AC0728", VA = "0x1AC0728")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1AC07CC", Offset = "0x1AC07CC", VA = "0x1AC07CC")]
		public void Unpin()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1AC07D4", Offset = "0x1AC07D4", VA = "0x1AC07D4", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1AC09AC", Offset = "0x1AC09AC", VA = "0x1AC09AC", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1AC0EF8", Offset = "0x1AC0EF8", VA = "0x1AC0EF8")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1AC08B0", Offset = "0x1AC08B0", VA = "0x1AC08B0")]
		public void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1AC11FC", Offset = "0x1AC11FC", VA = "0x1AC11FC")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1AC1080", Offset = "0x1AC1080", VA = "0x1AC1080")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1AC13D4", Offset = "0x1AC13D4", VA = "0x1AC13D4")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1AC04F8", Offset = "0x1AC04F8", VA = "0x1AC04F8")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1AC1118", Offset = "0x1AC1118", VA = "0x1AC1118")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1AC14F4", Offset = "0x1AC14F4", VA = "0x1AC14F4")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1ABF824", Offset = "0x1ABF824", VA = "0x1ABF824")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1ABE9A0", Offset = "0x1ABE9A0", VA = "0x1ABE9A0")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1AC15F4", Offset = "0x1AC15F4", VA = "0x1AC15F4")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1ABDFAC", Offset = "0x1ABDFAC", VA = "0x1ABDFAC")]
		public void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1AC1684", Offset = "0x1AC1684", VA = "0x1AC1684", Slot = "11")]
		public override void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1AC168C", Offset = "0x1AC168C", VA = "0x1AC168C", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1AC172C", Offset = "0x1AC172C", VA = "0x1AC172C")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FF038", Offset = "0x9FF038")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x40002DE")]
		private const string typeSpring = "BehaviourTemplate";

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1AC1844", Offset = "0x1AC1844", VA = "0x1AC1844", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1AC1888", Offset = "0x1AC1888", VA = "0x1AC1888", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1AC18AC", Offset = "0x1AC18AC", VA = "0x1AC18AC", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1AC18B0", Offset = "0x1AC18B0", VA = "0x1AC18B0", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1AC18B4", Offset = "0x1AC18B4", VA = "0x1AC18B4", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1AC18B8", Offset = "0x1AC18B8", VA = "0x1AC18B8", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1AC18F4", Offset = "0x1AC18F4", VA = "0x1AC18F4", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1AC18F8", Offset = "0x1AC18F8", VA = "0x1AC18F8", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1AC1900", Offset = "0x1AC1900", VA = "0x1AC1900", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1AC1908", Offset = "0x1AC1908", VA = "0x1AC1908")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Settings
		{
			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08134", Offset = "0xA08134")]
			public float damperForSpring;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0816C", Offset = "0xA0816C")]
			public float maxForceMlp;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA081A4", Offset = "0xA081A4")]
			public float IMlp;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA081DC", Offset = "0xA081DC")]
			public float velocityF;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08214", Offset = "0xA08214")]
			public Vector3 copOffset;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0824C", Offset = "0xA0824C")]
			public float torqueMlp;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08284", Offset = "0xA08284")]
			public float maxTorqueMag;

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1C5F218", Offset = "0x1C5F218", VA = "0x1C5F218")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA080D4", Offset = "0xA080D4")]
		private ConfigurableJoint <joint>k__BackingField;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA080E4", Offset = "0xA080E4")]
		private Vector3 <dir>k__BackingField;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA080F4", Offset = "0xA080F4")]
		private Vector3 <dirVel>k__BackingField;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08104", Offset = "0xA08104")]
		private Vector3 <cop>k__BackingField;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08114", Offset = "0xA08114")]
		private Vector3 <com>k__BackingField;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08124", Offset = "0xA08124")]
		private Vector3 <comV>k__BackingField;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000054")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x138A2B0", Offset = "0x138A2B0", VA = "0x138A2B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C2F8", Offset = "0xA0C2F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x138A2B8", Offset = "0x138A2B8", VA = "0x138A2B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C308", Offset = "0xA0C308")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Vector3 dir
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x138A2C0", Offset = "0x138A2C0", VA = "0x138A2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C318", Offset = "0xA0C318")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x138A2CC", Offset = "0x138A2CC", VA = "0x138A2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C328", Offset = "0xA0C328")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public Vector3 dirVel
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x138A2D8", Offset = "0x138A2D8", VA = "0x138A2D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C338", Offset = "0xA0C338")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x138A2E4", Offset = "0x138A2E4", VA = "0x138A2E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C348", Offset = "0xA0C348")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public Vector3 cop
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x138A2F0", Offset = "0x138A2F0", VA = "0x138A2F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C358", Offset = "0xA0C358")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x138A2FC", Offset = "0x138A2FC", VA = "0x138A2FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C368", Offset = "0xA0C368")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public Vector3 com
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x138A308", Offset = "0x138A308", VA = "0x138A308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C378", Offset = "0xA0C378")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x138A314", Offset = "0x138A314", VA = "0x138A314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C388", Offset = "0xA0C388")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Vector3 comV
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x138A320", Offset = "0x138A320", VA = "0x138A320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C398", Offset = "0xA0C398")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x138A32C", Offset = "0x138A32C", VA = "0x138A32C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C3A8", Offset = "0xA0C3A8")]
			private set
			{
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x138A338", Offset = "0x138A338", VA = "0x138A338")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x138A4D8", Offset = "0x138A4D8", VA = "0x138A4D8")]
		private void Solve(float deltaTime)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x138A8FC", Offset = "0x138A8FC", VA = "0x138A8FC")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x138A9AC", Offset = "0x138A9AC", VA = "0x138A9AC")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x138A9B4", Offset = "0x138A9B4", VA = "0x138A9B4")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x138A9C0", Offset = "0x138A9C0", VA = "0x138A9C0")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x138A9C8", Offset = "0x138A9C8", VA = "0x138A9C8")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x138A9A4", Offset = "0x138A9A4", VA = "0x138A9A4")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public enum Mode
		{
			[Token(Token = "0x400030B")]
			FeetCentroid,
			[Token(Token = "0x400030C")]
			CenterOfPressure
		}

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA082BC", Offset = "0xA082BC")]
		private Vector3 <position>k__BackingField;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA082CC", Offset = "0xA082CC")]
		private Vector3 <direction>k__BackingField;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA082DC", Offset = "0xA082DC")]
		private float <angle>k__BackingField;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA082EC", Offset = "0xA082EC")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA082FC", Offset = "0xA082FC")]
		private Vector3 <centerOfPressure>k__BackingField;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0830C", Offset = "0xA0830C")]
		private Quaternion <rotation>k__BackingField;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0831C", Offset = "0xA0831C")]
		private Quaternion <inverseRotation>k__BackingField;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0832C", Offset = "0xA0832C")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0833C", Offset = "0xA0833C")]
		private float <lastGroundedTime>k__BackingField;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x1700005A")]
		public Vector3 position
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x138A9D0", Offset = "0x138A9D0", VA = "0x138A9D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C3B8", Offset = "0xA0C3B8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x138A9DC", Offset = "0x138A9DC", VA = "0x138A9DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C3C8", Offset = "0xA0C3C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public Vector3 direction
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x138A9E8", Offset = "0x138A9E8", VA = "0x138A9E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C3D8", Offset = "0xA0C3D8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x138A9F4", Offset = "0x138A9F4", VA = "0x138A9F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C3E8", Offset = "0xA0C3E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float angle
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x138AA00", Offset = "0x138AA00", VA = "0x138AA00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C3F8", Offset = "0xA0C3F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x138AA08", Offset = "0x138AA08", VA = "0x138AA08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C408", Offset = "0xA0C408")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public Vector3 velocity
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x138AA10", Offset = "0x138AA10", VA = "0x138AA10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C418", Offset = "0xA0C418")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x138AA1C", Offset = "0x138AA1C", VA = "0x138AA1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C428", Offset = "0xA0C428")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x138AA28", Offset = "0x138AA28", VA = "0x138AA28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C438", Offset = "0xA0C438")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x138AA34", Offset = "0x138AA34", VA = "0x138AA34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C448", Offset = "0xA0C448")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Quaternion rotation
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x138AA40", Offset = "0x138AA40", VA = "0x138AA40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C458", Offset = "0xA0C458")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x138AA4C", Offset = "0x138AA4C", VA = "0x138AA4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C468", Offset = "0xA0C468")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x138AA58", Offset = "0x138AA58", VA = "0x138AA58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C478", Offset = "0xA0C478")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x138AA64", Offset = "0x138AA64", VA = "0x138AA64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C488", Offset = "0xA0C488")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool isGrounded
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x138AA70", Offset = "0x138AA70", VA = "0x138AA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C498", Offset = "0xA0C498")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x138AA78", Offset = "0x138AA78", VA = "0x138AA78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C4A8", Offset = "0xA0C4A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public float lastGroundedTime
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x138AA84", Offset = "0x138AA84", VA = "0x138AA84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C4B8", Offset = "0xA0C4B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x138AA8C", Offset = "0x138AA8C", VA = "0x138AA8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C4C8", Offset = "0xA0C4C8")]
			private set
			{
			}
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x138AA94", Offset = "0x138AA94", VA = "0x138AA94")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x138AEDC", Offset = "0x138AEDC", VA = "0x138AEDC")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x138AF84", Offset = "0x138AF84", VA = "0x138AF84")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x138B160", Offset = "0x138B160", VA = "0x138B160")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x138B220", Offset = "0x138B220", VA = "0x138B220")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x138B4CC", Offset = "0x138B4CC", VA = "0x138B4CC")]
		private void OnPreLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x138B9E0", Offset = "0x138B9E0", VA = "0x138B9E0")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x138B07C", Offset = "0x138B07C", VA = "0x138B07C")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x138B728", Offset = "0x138B728", VA = "0x138B728")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x138B2C0", Offset = "0x138B2C0", VA = "0x138B2C0")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x138B854", Offset = "0x138B854", VA = "0x138B854")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x138BA0C", Offset = "0x138BA0C", VA = "0x138BA0C")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x138B78C", Offset = "0x138B78C", VA = "0x138B78C")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x138B3E4", Offset = "0x138B3E4", VA = "0x138B3E4")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x138BB30", Offset = "0x138BB30", VA = "0x138BB30")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class Booster
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0836C", Offset = "0xA0836C")]
		public bool fullBody;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA083A4", Offset = "0xA083A4")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA083DC", Offset = "0xA083DC")]
		public Muscle.Group[] groups;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08414", Offset = "0xA08414")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA08414", Offset = "0xA08414")]
		public float immunity;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08468", Offset = "0xA08468")]
		public float impulseMlp;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA084A0", Offset = "0xA084A0")]
		public float boostParents;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA084D8", Offset = "0xA084D8")]
		public float boostChildren;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08510", Offset = "0xA08510")]
		public float delay;

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x15A53C0", Offset = "0x15A53C0", VA = "0x15A53C0")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x15A55D4", Offset = "0x15A55D4", VA = "0x15A55D4")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x193ED84", Offset = "0x193ED84", VA = "0x193ED84")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x193EE08", Offset = "0x193EE08", VA = "0x193EE08")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public enum Group
		{
			[Token(Token = "0x4000365")]
			Hips,
			[Token(Token = "0x4000366")]
			Spine,
			[Token(Token = "0x4000367")]
			Head,
			[Token(Token = "0x4000368")]
			Arm,
			[Token(Token = "0x4000369")]
			Hand,
			[Token(Token = "0x400036A")]
			Leg,
			[Token(Token = "0x400036B")]
			Foot,
			[Token(Token = "0x400036C")]
			Tail,
			[Token(Token = "0x400036D")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		public class InternalCollisionIgnoreSettings
		{
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08778", Offset = "0xA08778")]
			public bool ignoreAll;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA087B0", Offset = "0xA087B0")]
			public ConfigurableJoint[] muscles;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA087E8", Offset = "0xA087E8")]
			public Group[] groups;

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x1C5C678", Offset = "0x1C5C678", VA = "0x1C5C678")]
			public InternalCollisionIgnoreSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B0")]
		public class Props
		{
			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08820", Offset = "0xA08820")]
			public Group group;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA08858", Offset = "0xA08858")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08858", Offset = "0xA08858")]
			public float mappingWeight;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA088AC", Offset = "0xA088AC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA088AC", Offset = "0xA088AC")]
			public float pinWeight;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08900", Offset = "0xA08900")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA08900", Offset = "0xA08900")]
			public float muscleWeight;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08954", Offset = "0xA08954")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA08954", Offset = "0xA08954")]
			public float muscleDamper;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA089A8", Offset = "0xA089A8")]
			public InternalCollisionIgnoreSettings internalCollisionIgnores;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA089E0", Offset = "0xA089E0")]
			public Transform[] animatedTargetChildren;

			[Token(Token = "0x17000075")]
			public bool mapPosition
			{
				[Token(Token = "0x6000510")]
				[Address(RVA = "0x1C5C710", Offset = "0x1C5C710", VA = "0x1C5C710")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000511")]
				[Address(RVA = "0x1C5C718", Offset = "0x1C5C718", VA = "0x1C5C718")]
				set
				{
				}
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x1C5C78C", Offset = "0x1C5C78C", VA = "0x1C5C78C")]
			public Props()
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1C5C848", Offset = "0x1C5C848", VA = "0x1C5C848")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1C5C928", Offset = "0x1C5C928", VA = "0x1C5C928")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x20000B1")]
		public struct State
		{
			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isDisconnected;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool resetFlag;

			[Token(Token = "0x17000076")]
			public static State Default
			{
				[Token(Token = "0x6000515")]
				[Address(RVA = "0x1C5C9BC", Offset = "0x1C5C9BC", VA = "0x1C5C9BC")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1C5C9DC", Offset = "0x1C5C9DC", VA = "0x1C5C9DC")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x20000B2")]
		public class TargetChild
		{
			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1C5CA84", Offset = "0x1C5CA84", VA = "0x1C5CA84")]
			public TargetChild(Transform t)
			{
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1C5CB00", Offset = "0x1C5CB00", VA = "0x1C5CB00")]
			public void Map()
			{
			}
		}

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA085E8", Offset = "0xA085E8")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA085F8", Offset = "0xA085F8")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08608", Offset = "0xA08608")]
		private Transform <connectedBodyTarget>k__BackingField;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08618", Offset = "0xA08618")]
		private Vector3 <targetAnimatedPosition>k__BackingField;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08628", Offset = "0xA08628")]
		private Quaternion <targetAnimatedWorldRotation>k__BackingField;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08638", Offset = "0xA08638")]
		private Vector3 <targetVelocity>k__BackingField;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08648", Offset = "0xA08648")]
		private Rigidbody <additionalRigidbody>k__BackingField;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[HideInInspector]
		public Transform additionalPinTarget;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public float additionalPinWeight;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[HideInInspector]
		public Vector3 mappedVelocity;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[HideInInspector]
		public Vector3 mappedAngularVelocity;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[HideInInspector]
		public bool isPropMuscle;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[HideInInspector]
		public int index;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA086C8", Offset = "0xA086C8")]
		private Quaternion <targetRotationRelative>k__BackingField;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA086D8", Offset = "0xA086D8")]
		private Rigidbody <rebuildConnectedBody>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA086E8", Offset = "0xA086E8")]
		private Transform <rebuildTargetParent>k__BackingField;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA086F8", Offset = "0xA086F8")]
		private Vector3 <defaultTargetPosRelToMuscle>k__BackingField;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08708", Offset = "0xA08708")]
		private Quaternion <defaultTargetRotRelToMuscle>k__BackingField;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08718", Offset = "0xA08718")]
		private Quaternion <defaultMuscleRotRelToTarget>k__BackingField;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Transform rebuildParent;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 rebuildPosition;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion rebuildRotation;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 rebuildTargetPosition;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion rebuildTargetRotation;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ConfigurableJointMotion rebuildAngularXMotion;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private ConfigurableJointMotion rebuildAngularYMotion;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private ConfigurableJointMotion rebuildAngularZMotion;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[HideInInspector]
		public bool ignoreTargetVelocity;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[HideInInspector]
		public Vector3 targetMappedPosition;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		[HideInInspector]
		public Quaternion targetMappedRotation;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		[HideInInspector]
		public Vector3 targetSampledPosition;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[HideInInspector]
		public Quaternion targetSampledRotation;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private float lastRotationDamper;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Quaternion toParentSpace;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private Transform targetParent;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		private bool directTargetParent;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FD")]
		private bool initiated;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private Collider[] _colliders;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private float lastReadTime;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private float lastWriteTime;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private bool[] disabledColliders;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private TargetChild[] targetChildren;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private Vector3 additionalTargetVelocity;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private Vector3 targetAnimatedCenterOfMass;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private Vector3 additionalPinTargetAnimatedCenterOfMass;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		private Quaternion defaultTargetRotRelToMuscleInverse;

		[Token(Token = "0x17000063")]
		public Transform transform
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x156F1EC", Offset = "0x156F1EC", VA = "0x156F1EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C4D8", Offset = "0xA0C4D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x156F1F4", Offset = "0x156F1F4", VA = "0x156F1F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C4E8", Offset = "0xA0C4E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x156F1FC", Offset = "0x156F1FC", VA = "0x156F1FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C4F8", Offset = "0xA0C4F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x156F204", Offset = "0x156F204", VA = "0x156F204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C508", Offset = "0xA0C508")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x156F20C", Offset = "0x156F20C", VA = "0x156F20C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C518", Offset = "0xA0C518")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x156F214", Offset = "0x156F214", VA = "0x156F214")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C528", Offset = "0xA0C528")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x156F21C", Offset = "0x156F21C", VA = "0x156F21C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C538", Offset = "0xA0C538")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x156F228", Offset = "0x156F228", VA = "0x156F228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C548", Offset = "0xA0C548")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public Quaternion targetAnimatedWorldRotation
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x156F234", Offset = "0x156F234", VA = "0x156F234")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C558", Offset = "0xA0C558")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x156F240", Offset = "0x156F240", VA = "0x156F240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C568", Offset = "0xA0C568")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Collider[] colliders
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x156F24C", Offset = "0x156F24C", VA = "0x156F24C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x156F254", Offset = "0x156F254", VA = "0x156F254")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x156F264", Offset = "0x156F264", VA = "0x156F264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C578", Offset = "0xA0C578")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x156F270", Offset = "0x156F270", VA = "0x156F270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C588", Offset = "0xA0C588")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public Rigidbody additionalRigidbody
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x156F27C", Offset = "0x156F27C", VA = "0x156F27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C598", Offset = "0xA0C598")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x156F284", Offset = "0x156F284", VA = "0x156F284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C5A8", Offset = "0xA0C5A8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x156F28C", Offset = "0x156F28C", VA = "0x156F28C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C5B8", Offset = "0xA0C5B8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x156F2A0", Offset = "0x156F2A0", VA = "0x156F2A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C5C8", Offset = "0xA0C5C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public Rigidbody rebuildConnectedBody
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x156F4D0", Offset = "0x156F4D0", VA = "0x156F4D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C5D8", Offset = "0xA0C5D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x156F4D8", Offset = "0x156F4D8", VA = "0x156F4D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C5E8", Offset = "0xA0C5E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Transform rebuildTargetParent
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x156F4E8", Offset = "0x156F4E8", VA = "0x156F4E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C5F8", Offset = "0xA0C5F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x156F4F0", Offset = "0x156F4F0", VA = "0x156F4F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C608", Offset = "0xA0C608")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Vector3 defaultTargetPosRelToMuscle
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x156F500", Offset = "0x156F500", VA = "0x156F500")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C618", Offset = "0xA0C618")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x156F510", Offset = "0x156F510", VA = "0x156F510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C628", Offset = "0xA0C628")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Quaternion defaultTargetRotRelToMuscle
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x156F520", Offset = "0x156F520", VA = "0x156F520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C638", Offset = "0xA0C638")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x156F534", Offset = "0x156F534", VA = "0x156F534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C648", Offset = "0xA0C648")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Quaternion defaultMuscleRotRelToTarget
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x156F548", Offset = "0x156F548", VA = "0x156F548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C658", Offset = "0xA0C658")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x156F55C", Offset = "0x156F55C", VA = "0x156F55C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C668", Offset = "0xA0C668")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1570ADC", Offset = "0x1570ADC", VA = "0x1570ADC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000072")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x1570BF0", Offset = "0x1570BF0", VA = "0x1570BF0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000073")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x1570B5C", Offset = "0x1570B5C", VA = "0x1570B5C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000074")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1570D1C", Offset = "0x1570D1C", VA = "0x1570D1C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x156F2B4", Offset = "0x156F2B4", VA = "0x156F2B4")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x156F570", Offset = "0x156F570", VA = "0x156F570")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x156F6D4", Offset = "0x156F6D4", VA = "0x156F6D4", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1570744", Offset = "0x1570744", VA = "0x1570744")]
		public void InitiateAdditionalPin()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x157097C", Offset = "0x157097C", VA = "0x157097C")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x15713B4", Offset = "0x15713B4", VA = "0x15713B4")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x15714BC", Offset = "0x15714BC", VA = "0x15714BC")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x157103C", Offset = "0x157103C", VA = "0x157103C")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x15712A4", Offset = "0x15712A4", VA = "0x15712A4")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1571568", Offset = "0x1571568", VA = "0x1571568")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x157173C", Offset = "0x157173C", VA = "0x157173C")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1571938", Offset = "0x1571938", VA = "0x1571938")]
		private bool ForceIgnore(Muscle otherMuscle)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1571BA0", Offset = "0x1571BA0", VA = "0x1571BA0")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1571C40", Offset = "0x1571C40", VA = "0x1571C40")]
		public void ResetTargetLocalPosition()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1571C6C", Offset = "0x1571C6C", VA = "0x1571C6C")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1571CD8", Offset = "0x1571CD8", VA = "0x1571CD8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1571E90", Offset = "0x1571E90", VA = "0x1571E90")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x15708AC", Offset = "0x15708AC", VA = "0x15708AC")]
		public void SetKinematic(bool to)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1570DB4", Offset = "0x1570DB4", VA = "0x1570DB4")]
		public void Read()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1572054", Offset = "0x1572054", VA = "0x1572054")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x15721DC", Offset = "0x15721DC", VA = "0x15721DC")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1572444", Offset = "0x1572444", VA = "0x1572444", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x15729C4", Offset = "0x15729C4", VA = "0x15729C4")]
		public void StoreTargetMappedPosition()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1572A00", Offset = "0x1572A00", VA = "0x1572A00")]
		public void StoreTargetMappedRotation()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1572A40", Offset = "0x1572A40", VA = "0x1572A40")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1572EE0", Offset = "0x1572EE0", VA = "0x1572EE0")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x157314C", Offset = "0x157314C", VA = "0x157314C")]
		public void MapDisconnected()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x157256C", Offset = "0x157256C", VA = "0x157256C")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1573238", Offset = "0x1573238", VA = "0x1573238")]
		private void Pin(Rigidbody r, Vector3 posOffset, Vector3 targetVel, float w, float pinDistanceFalloff, float deltaTime)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1572804", Offset = "0x1572804", VA = "0x1572804")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x157364C", Offset = "0x157364C", VA = "0x157364C")]
		public void SetMuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x15735CC", Offset = "0x15735CC", VA = "0x15735CC")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x15723E0", Offset = "0x15723E0", VA = "0x15723E0")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x15737B8", Offset = "0x15737B8", VA = "0x15737B8")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public struct MuscleCollision
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1573A18", Offset = "0x1573A18", VA = "0x1573A18")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public struct MuscleHit
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1573B3C", Offset = "0x1573B3C", VA = "0x1573B3C")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FF070", Offset = "0x9FF070")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x4000390")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x4000391")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x4000392")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1573A50", Offset = "0x1573A50", VA = "0x1573A50")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1573B54", Offset = "0x1573B54", VA = "0x1573B54")]
		private bool IsSelf(Collider c)
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1573BAC", Offset = "0x1573BAC", VA = "0x1573BAC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1573D34", Offset = "0x1573D34", VA = "0x1573D34")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1573F70", Offset = "0x1573F70", VA = "0x1573F70")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x15741A0", Offset = "0x15741A0", VA = "0x15741A0")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class ParticleCollisionHandler : MonoBehaviour
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08A38", Offset = "0xA08A38")]
		public LayerMask ragdollLayers;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08A70", Offset = "0xA08A70")]
		public float unpin;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem p;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ParticleCollisionEvent> particleCollisionEvents;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1576550", Offset = "0x1576550", VA = "0x1576550")]
		private void Start()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x157670C", Offset = "0x157670C", VA = "0x157670C")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x15769E4", Offset = "0x15769E4", VA = "0x15769E4")]
		public ParticleCollisionHandler()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public static class PhysXTools
	{
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1576A74", Offset = "0x1576A74", VA = "0x1576A74")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1576B10", Offset = "0x1576B10", VA = "0x1576B10")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1576C10", Offset = "0x1576C10", VA = "0x1576C10")]
		public static void Predict(ref Vector3 position, ref Quaternion rotation, ref Vector3 velocity, ref Vector3 angularVelocity, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1576DA4", Offset = "0x1576DA4", VA = "0x1576DA4")]
		public static Vector3 GetCenterOfMass(PuppetMaster puppet)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1576F34", Offset = "0x1576F34", VA = "0x1576F34")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1577080", Offset = "0x1577080", VA = "0x1577080")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x15771CC", Offset = "0x15771CC", VA = "0x15771CC")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1577278", Offset = "0x1577278", VA = "0x1577278")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1573018", Offset = "0x1573018", VA = "0x1573018")]
		public static Vector3 GetAngularVelocity(Quaternion lastRotation, Quaternion rotation, float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1577314", Offset = "0x1577314", VA = "0x1577314")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x157338C", Offset = "0x157338C", VA = "0x157338C")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x15773E0", Offset = "0x15773E0", VA = "0x15773E0")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x15775C4", Offset = "0x15775C4", VA = "0x15775C4")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1577780", Offset = "0x1577780", VA = "0x1577780")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x15778F0", Offset = "0x15778F0", VA = "0x15778F0")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1577934", Offset = "0x1577934", VA = "0x1577934")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1570AA8", Offset = "0x1570AA8", VA = "0x1570AA8")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1577268", Offset = "0x1577268", VA = "0x1577268")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x15779FC", Offset = "0x15779FC", VA = "0x15779FC")]
		public static bool RayCapsuleIntersectUnscaled(Vector3 origin, Vector3 direction, CapsuleCollider capsule)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1577CE0", Offset = "0x1577CE0", VA = "0x1577CE0")]
		public static bool RayCapsuleIntersect(Vector3 origin, Vector3 direction, CapsuleCollider capsule, float uniformScale)
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1577B4C", Offset = "0x1577B4C", VA = "0x1577B4C")]
		public static bool RayCapsuleIntersect(Vector3 origin, Vector3 direction, Vector3 capsuleTransformPos, Quaternion capsuleTransformRot, Vector3 capsuleCenter, float capsuleRadius, float capsuleHeight, int capsuleDir, float scale)
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1577E34", Offset = "0x1577E34", VA = "0x1577E34")]
		public static bool RayCapsuleIntersect(Vector3 rayOrigin, Vector3 rayDir, Vector3 c1, Vector3 c2, float cRadius)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B8")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08AA8", Offset = "0xA08AA8")]
		private Vector3 <center>k__BackingField;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08AB8", Offset = "0xA08AB8")]
		private bool <inContact>k__BackingField;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08AC8", Offset = "0xA08AC8")]
		private Vector3 <bottom>k__BackingField;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08AD8", Offset = "0xA08AD8")]
		private Rigidbody <r>k__BackingField;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x17000077")]
		public Vector3 center
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1578404", Offset = "0x1578404", VA = "0x1578404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C678", Offset = "0xA0C678")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1578410", Offset = "0x1578410", VA = "0x1578410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C688", Offset = "0xA0C688")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool inContact
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x157841C", Offset = "0x157841C", VA = "0x157841C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C698", Offset = "0xA0C698")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x1578424", Offset = "0x1578424", VA = "0x1578424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C6A8", Offset = "0xA0C6A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public Vector3 bottom
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x1578430", Offset = "0x1578430", VA = "0x1578430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C6B8", Offset = "0xA0C6B8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x157843C", Offset = "0x157843C", VA = "0x157843C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C6C8", Offset = "0xA0C6C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public Rigidbody r
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1578448", Offset = "0x1578448", VA = "0x1578448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C6D8", Offset = "0xA0C6D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x1578450", Offset = "0x1578450", VA = "0x1578450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C6E8", Offset = "0xA0C6E8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1578458", Offset = "0x1578458", VA = "0x1578458")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x15784DC", Offset = "0x15784DC", VA = "0x15784DC")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1578644", Offset = "0x1578644", VA = "0x1578644")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1578648", Offset = "0x1578648", VA = "0x1578648")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1578650", Offset = "0x1578650", VA = "0x1578650")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x15786A0", Offset = "0x15786A0", VA = "0x15786A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x15784E0", Offset = "0x15784E0", VA = "0x15784E0")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x15786E0", Offset = "0x15786E0", VA = "0x15786E0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1578704", Offset = "0x1578704", VA = "0x1578704")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08AE8", Offset = "0xA08AE8")]
		public int propType;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08B20", Offset = "0xA08B20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA08B20", Offset = "0xA08B20")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08B80", Offset = "0xA08B80")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08BB8", Offset = "0xA08BB8")]
		public bool forceLayers;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08BF0", Offset = "0xA08BF0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA08BF0", Offset = "0xA08BF0")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08C50", Offset = "0xA08C50")]
		public Transform additionalPinTarget;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA08C88", Offset = "0xA08C88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08C88", Offset = "0xA08C88")]
		public float additionalPinWeight;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08CDC", Offset = "0xA08CDC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA08CDC", Offset = "0xA08CDC")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08D3C", Offset = "0xA08D3C")]
		public PhysicMaterial droppedMaterial;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08D74", Offset = "0xA08D74")]
		private PropRoot <propRoot>k__BackingField;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08D84", Offset = "0xA08D84")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] colliders;

		[Token(Token = "0x1700007B")]
		public bool isPickedUp
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x157870C", Offset = "0x157870C", VA = "0x157870C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public PropRoot propRoot
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1578778", Offset = "0x1578778", VA = "0x1578778")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C6F8", Offset = "0xA0C6F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x1578780", Offset = "0x1578780", VA = "0x1578780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C708", Offset = "0xA0C708")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public bool initiated
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x1578A64", Offset = "0x1578A64", VA = "0x1578A64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C718", Offset = "0xA0C718")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x1578A6C", Offset = "0x1578A6C", VA = "0x1578A6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C728", Offset = "0xA0C728")]
			private set
			{
			}
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1578788", Offset = "0x1578788", VA = "0x1578788")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1578A1C", Offset = "0x1578A1C", VA = "0x1578A1C")]
		public void Drop()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1578A5C", Offset = "0x1578A5C", VA = "0x1578A5C")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1578A78", Offset = "0x1578A78", VA = "0x1578A78", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1578A7C", Offset = "0x1578A7C", VA = "0x1578A7C", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1578A80", Offset = "0x1578A80", VA = "0x1578A80", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1578A84", Offset = "0x1578A84", VA = "0x1578A84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1578CD8", Offset = "0x1578CD8", VA = "0x1578CD8")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1578948", Offset = "0x1578948", VA = "0x1578948")]
		private void SetMaterial(PhysicMaterial material)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1578DE0", Offset = "0x1578DE0", VA = "0x1578DE0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1578F8C", Offset = "0x1578F8C", VA = "0x1578F8C")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class PropMuscle : MonoBehaviour
	{
		[Token(Token = "0x20000BB")]
		public delegate void PropDelegate(PuppetMasterProp prop);

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08DA4", Offset = "0xA08DA4")]
		public PuppetMasterProp currentProp;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA08DDC", Offset = "0xA08DDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08DDC", Offset = "0xA08DDC")]
		public Vector3 additionalPinOffset;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08E3C", Offset = "0xA08E3C")]
		private PuppetMasterProp <activeProp>k__BackingField;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PropDelegate OnPickUpProp;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PropDelegate OnDropProp;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Muscle _muscle;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PuppetMasterProp lastProp;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastAdditionalPinOffset;

		[Token(Token = "0x1700007E")]
		public Muscle muscle
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1579420", Offset = "0x1579420", VA = "0x1579420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public PuppetMasterProp activeProp
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x157950C", Offset = "0x157950C", VA = "0x157950C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C738", Offset = "0xA0C738")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x1579514", Offset = "0x1579514", VA = "0x1579514")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C748", Offset = "0xA0C748")]
			private set
			{
			}
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x157951C", Offset = "0x157951C", VA = "0x157951C")]
		public bool AddAdditionalPin()
		{
			return default(bool);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x15799A4", Offset = "0x15799A4", VA = "0x15799A4")]
		public bool RemoveAdditionalPin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1579B58", Offset = "0x1579B58", VA = "0x1579B58")]
		public void OnInitiate()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1579DB8", Offset = "0x1579DB8", VA = "0x1579DB8")]
		public void TakeOver()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1579E28", Offset = "0x1579E28", VA = "0x1579E28")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x157A698", Offset = "0x157A698", VA = "0x157A698")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x157A928", Offset = "0x157A928", VA = "0x157A928")]
		public PropMuscle()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9FF0A8", Offset = "0x9FF0A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FF0A8", Offset = "0x9FF0A8")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08E4C", Offset = "0xA08E4C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08E84", Offset = "0xA08E84")]
		public Rigidbody connectTo;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08EBC", Offset = "0xA08EBC")]
		public Prop currentProp;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x157AB10", Offset = "0x157AB10", VA = "0x157AB10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C758", Offset = "0xA0C758")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x157AB58", Offset = "0x157AB58", VA = "0x157AB58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C790", Offset = "0xA0C790")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x157ABA0", Offset = "0x157ABA0", VA = "0x157ABA0")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x157B9C4", Offset = "0x157B9C4", VA = "0x157B9C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x157BABC", Offset = "0x157BABC", VA = "0x157BABC")]
		private void Update()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x157BC0C", Offset = "0x157BC0C", VA = "0x157BC0C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x157BE2C", Offset = "0x157BE2C", VA = "0x157BE2C")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x157CAAC", Offset = "0x157CAAC", VA = "0x157CAAC")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9FF108", Offset = "0x9FF108")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FF108", Offset = "0x9FF108")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x157CAB4", Offset = "0x157CAB4", VA = "0x157CAB4", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x157CAB8", Offset = "0x157CAB8", VA = "0x157CAB8", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x157CABC", Offset = "0x157CABC", VA = "0x157CABC", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x157CAC0", Offset = "0x157CAC0", VA = "0x157CAC0")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FF168", Offset = "0x9FF168")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9FF168", Offset = "0x9FF168")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public enum Mode
		{
			[Token(Token = "0x4000417")]
			Active,
			[Token(Token = "0x4000418")]
			Kinematic,
			[Token(Token = "0x4000419")]
			Disabled
		}

		[Token(Token = "0x20000C0")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000C1")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum UpdateMode
		{
			[Token(Token = "0x400041B")]
			Normal,
			[Token(Token = "0x400041C")]
			AnimatePhysics,
			[Token(Token = "0x400041D")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public enum State
		{
			[Token(Token = "0x400041F")]
			Alive,
			[Token(Token = "0x4000420")]
			Dead,
			[Token(Token = "0x4000421")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public struct StateSettings
		{
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA095AC", Offset = "0xA095AC")]
			public float killDuration;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA095E4", Offset = "0xA095E4")]
			public float deadMuscleWeight;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0961C", Offset = "0xA0961C")]
			public float deadMuscleDamper;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09654", Offset = "0xA09654")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0968C", Offset = "0xA0968C")]
			public bool freezePermanently;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA096C4", Offset = "0xA096C4")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA096FC", Offset = "0xA096FC")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x1700008E")]
			public static StateSettings Default
			{
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x1C5E834", Offset = "0x1C5E834", VA = "0x1C5E834")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1C5E810", Offset = "0x1C5E810", VA = "0x1C5E810")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF1C8", Offset = "0x9FF1C8")]
		private sealed class <DisabledToActive>d__171 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x1C5E1A4", Offset = "0x1C5E1A4", VA = "0x1C5E1A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x1C5E1EC", Offset = "0x1C5E1EC", VA = "0x1C5E1EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1C5DF18", Offset = "0x1C5DF18", VA = "0x1C5DF18")]
			[DebuggerHidden]
			public <DisabledToActive>d__171(int <>1__state)
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x1C5DF44", Offset = "0x1C5DF44", VA = "0x1C5DF44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x1C5DF48", Offset = "0x1C5DF48", VA = "0x1C5DF48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1C5E1AC", Offset = "0x1C5E1AC", VA = "0x1C5E1AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF1D8", Offset = "0x9FF1D8")]
		private sealed class <KinematicToActive>d__173 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x1C5E408", Offset = "0x1C5E408", VA = "0x1C5E408", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x1C5E450", Offset = "0x1C5E450", VA = "0x1C5E450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1C5E1F4", Offset = "0x1C5E1F4", VA = "0x1C5E1F4")]
			[DebuggerHidden]
			public <KinematicToActive>d__173(int <>1__state)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1C5E220", Offset = "0x1C5E220", VA = "0x1C5E220", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1C5E224", Offset = "0x1C5E224", VA = "0x1C5E224", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1C5E410", Offset = "0x1C5E410", VA = "0x1C5E410", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF1E8", Offset = "0x9FF1E8")]
		private sealed class <ActiveToDisabled>d__174 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x1C5D6F0", Offset = "0x1C5D6F0", VA = "0x1C5D6F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x1C5D738", Offset = "0x1C5D738", VA = "0x1C5D738", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1C5D57C", Offset = "0x1C5D57C", VA = "0x1C5D57C")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__174(int <>1__state)
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1C5D5A8", Offset = "0x1C5D5A8", VA = "0x1C5D5A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1C5D5AC", Offset = "0x1C5D5AC", VA = "0x1C5D5AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x1C5D6F8", Offset = "0x1C5D6F8", VA = "0x1C5D6F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF1F8", Offset = "0x9FF1F8")]
		private sealed class <ActiveToKinematic>d__175 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x1C5D8EC", Offset = "0x1C5D8EC", VA = "0x1C5D8EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x1C5D934", Offset = "0x1C5D934", VA = "0x1C5D934", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1C5D740", Offset = "0x1C5D740", VA = "0x1C5D740")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__175(int <>1__state)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1C5D76C", Offset = "0x1C5D76C", VA = "0x1C5D76C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1C5D770", Offset = "0x1C5D770", VA = "0x1C5D770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1C5D8F4", Offset = "0x1C5D8F4", VA = "0x1C5D8F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF208", Offset = "0x9FF208")]
		private sealed class <AliveToDead>d__226 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x1C5DEC8", Offset = "0x1C5DEC8", VA = "0x1C5DEC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x1C5DF10", Offset = "0x1C5DF10", VA = "0x1C5DF10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1C5D93C", Offset = "0x1C5D93C", VA = "0x1C5D93C")]
			[DebuggerHidden]
			public <AliveToDead>d__226(int <>1__state)
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1C5D968", Offset = "0x1C5D968", VA = "0x1C5D968", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1C5D96C", Offset = "0x1C5D96C", VA = "0x1C5D96C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1C5DED0", Offset = "0x1C5DED0", VA = "0x1C5DED0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08EF4", Offset = "0xA08EF4")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08F2C", Offset = "0xA08F2C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA08F2C", Offset = "0xA08F2C")]
		public State state;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xA08F8C", Offset = "0xA08F8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA08F8C", Offset = "0xA08F8C")]
		public StateSettings stateSettings;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09008", Offset = "0xA09008")]
		public Mode mode;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09040", Offset = "0xA09040")]
		public float blendTime;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09078", Offset = "0xA09078")]
		public bool fixTargetTransforms;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA090B0", Offset = "0xA090B0")]
		public int solverIterationCount;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA090E8", Offset = "0xA090E8")]
		public bool visualizeTargetPose;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA09120", Offset = "0xA09120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09120", Offset = "0xA09120")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09120", Offset = "0xA09120")]
		public float mappingWeight;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09198", Offset = "0xA09198")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09198", Offset = "0xA09198")]
		public float pinWeight;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA091EC", Offset = "0xA091EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA091EC", Offset = "0xA091EC")]
		public float muscleWeight;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09240", Offset = "0xA09240")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA09240", Offset = "0xA09240")]
		public float muscleSpring;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA092A0", Offset = "0xA092A0")]
		public float muscleDamper;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA092D8", Offset = "0xA092D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA092D8", Offset = "0xA092D8")]
		public float pinPow;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0932C", Offset = "0xA0932C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0932C", Offset = "0xA0932C")]
		public float pinDistanceFalloff;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09384", Offset = "0xA09384")]
		public bool angularPinning;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA093BC", Offset = "0xA093BC")]
		public bool updateJointAnchors;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA093F4", Offset = "0xA093F4")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0942C", Offset = "0xA0942C")]
		public bool angularLimits;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09464", Offset = "0xA09464")]
		public bool internalCollisions;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0949C", Offset = "0xA0949C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA0949C", Offset = "0xA0949C")]
		public Muscle[] muscles;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public PropMuscle[] propMuscles;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public MuscleDelegate OnMuscleDisconnected;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public MuscleDelegate OnMuscleReconnected;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Animator _targetAnimator;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0950C", Offset = "0xA0950C")]
		private Animation <targetAnimation>k__BackingField;

		[NonSerialized]
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[HideInInspector]
		public BehaviourBase[] behaviours;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0952C", Offset = "0xA0952C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[NonSerialized]
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public bool manualInternalCollisionControl;

		[NonSerialized]
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[HideInInspector]
		public bool manualAngularLimitControl;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[HideInInspector]
		public bool mapDisconnectedMuscles;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private bool fixedFrame;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int lastSolverIterationCount;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool isLegacy;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool animatorDisabled;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool awakeFailed;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		private bool interpolated;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool freezeFlag;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool hasBeenDisabled;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
		private bool teleport;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 teleportPosition;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion teleportRotation;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool rebuildFlag;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		private bool onPostRebuildFlag;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool[] disconnectMuscleFlags;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private MuscleDisconnectMode[] muscleDisconnectModes;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool[] disconnectDeactivateFlags;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool[] reconnectMuscleFlags;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Muscle[] defaultMuscles;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 rebuildPelvisPos;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion rebuildPelvisRot;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float simulationDeltaTime;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool readInFixedUpdate;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0957C", Offset = "0xA0957C")]
		private bool <isSwitchingMode>k__BackingField;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Mode activeMode;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Mode lastMode;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private float mappingBlend;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0958C", Offset = "0xA0958C")]
		private bool <isKilling>k__BackingField;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private State activeState;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private State lastState;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool targetMappedStateStored;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		private bool hasProp;

		[Token(Token = "0x17000080")]
		public Animator targetAnimator
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x157D31C", Offset = "0x157D31C", VA = "0x157D31C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x157D480", Offset = "0x157D480", VA = "0x157D480")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public Animation targetAnimation
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x157D488", Offset = "0x157D488", VA = "0x157D488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C918", Offset = "0xA0C918")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x157D490", Offset = "0x157D490", VA = "0x157D490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C928", Offset = "0xA0C928")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isActive
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x157D498", Offset = "0x157D498", VA = "0x157D498")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public bool initiated
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x157D52C", Offset = "0x157D52C", VA = "0x157D52C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C938", Offset = "0xA0C938")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x157D534", Offset = "0x157D534", VA = "0x157D534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C948", Offset = "0xA0C948")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x157D540", Offset = "0x157D540", VA = "0x157D540")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x17000085")]
		public bool controlsAnimator
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x157D678", Offset = "0x157D678", VA = "0x157D678")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public bool isBlending
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x157D508", Offset = "0x157D508", VA = "0x157D508")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		private bool autoSimulate
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x157E004", Offset = "0x157E004", VA = "0x157E004")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x157D580", Offset = "0x157D580", VA = "0x157D580")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x17000089")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x1585140", Offset = "0x1585140", VA = "0x1585140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CA38", Offset = "0xA0CA38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1585148", Offset = "0x1585148", VA = "0x1585148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CA48", Offset = "0xA0CA48")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool isSwitchingState
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x157D6D8", Offset = "0x157D6D8", VA = "0x157D6D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public bool isKilling
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1588A90", Offset = "0x1588A90", VA = "0x1588A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CBD8", Offset = "0xA0CBD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1588A98", Offset = "0x1588A98", VA = "0x1588A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CBE8", Offset = "0xA0CBE8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool isAlive
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x15823D4", Offset = "0x15823D4", VA = "0x15823D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		public bool isFrozen
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x1581054", Offset = "0x1581054", VA = "0x1581054")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x157D11C", Offset = "0x157D11C", VA = "0x157D11C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C7C8", Offset = "0xA0C7C8")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x157D164", Offset = "0x157D164", VA = "0x157D164")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C800", Offset = "0xA0C800")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x157D1AC", Offset = "0x157D1AC", VA = "0x157D1AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C838", Offset = "0xA0C838")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x157D1F4", Offset = "0x157D1F4", VA = "0x157D1F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C870", Offset = "0xA0C870")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x157D23C", Offset = "0x157D23C", VA = "0x157D23C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C8A8", Offset = "0xA0C8A8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x157D284", Offset = "0x157D284", VA = "0x157D284")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C8E0", Offset = "0xA0C8E0")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x157D2CC", Offset = "0x157D2CC", VA = "0x157D2CC")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x157D6EC", Offset = "0x157D6EC", VA = "0x157D6EC")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x157DE9C", Offset = "0x157DE9C", VA = "0x157DE9C")]
		public void SetInternalCollisionsManual(bool collide, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x157DF80", Offset = "0x157DF80", VA = "0x157DF80")]
		public void SetAngularLimitsManual(bool limited)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x157E00C", Offset = "0x157E00C", VA = "0x157E00C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x157E0B4", Offset = "0x157E0B4", VA = "0x157E0B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x157E7DC", Offset = "0x157E7DC", VA = "0x157E7DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x157F328", Offset = "0x157F328", VA = "0x157F328")]
		public void Start()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x157F3D8", Offset = "0x157F3D8", VA = "0x157F3D8")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x157E820", Offset = "0x157E820", VA = "0x157E820")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x158028C", Offset = "0x158028C", VA = "0x158028C")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1580384", Offset = "0x1580384", VA = "0x1580384")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x158048C", Offset = "0x158048C", VA = "0x158048C")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1580518", Offset = "0x1580518", VA = "0x1580518")]
		private void OnRebuild()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x158084C", Offset = "0x158084C", VA = "0x158084C")]
		public void OnPreSimulate(float deltaTime)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1581148", Offset = "0x1581148", VA = "0x1581148")]
		public void OnPostSimulate()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x15818A4", Offset = "0x15818A4", VA = "0x15818A4", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1581E44", Offset = "0x1581E44", VA = "0x1581E44", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1581F34", Offset = "0x1581F34", VA = "0x1581F34", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x15820C4", Offset = "0x15820C4", VA = "0x15820C4", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1581478", Offset = "0x1581478", VA = "0x1581478")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x157D72C", Offset = "0x157D72C", VA = "0x157D72C")]
		private void Read()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1580F14", Offset = "0x1580F14", VA = "0x1580F14")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x15823E4", Offset = "0x15823E4", VA = "0x15823E4")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1582694", Offset = "0x1582694", VA = "0x1582694")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x15801A0", Offset = "0x15801A0", VA = "0x15801A0")]
		public void FlagInternalCollisionsForUpdate()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1581064", Offset = "0x1581064", VA = "0x1581064")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x15829C0", Offset = "0x15829C0", VA = "0x15829C0")]
		public void UpdateInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x15828EC", Offset = "0x15828EC", VA = "0x15828EC")]
		private void IgnoreInternalCollisions()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1582A70", Offset = "0x1582A70", VA = "0x1582A70")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1582810", Offset = "0x1582810", VA = "0x1582810")]
		private void ResetInternalCollisions()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1582AFC", Offset = "0x1582AFC", VA = "0x1582AFC")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x15801BC", Offset = "0x15801BC", VA = "0x15801BC")]
		public void FlagAngularLimitsForUpdate()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x158109C", Offset = "0x158109C", VA = "0x158109C")]
		private void UpdateAngularLimits()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1582B98", Offset = "0x1582B98", VA = "0x1582B98")]
		public bool AddPropMuscle(ConfigurableJoint addPropMuscleTo, Vector3 position, Quaternion rotation, Vector3 additionalPinOffset, [Optional] Transform targetParent, [Optional] PuppetMasterProp initiateWithProp)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x157A410", Offset = "0x157A410", VA = "0x157A410")]
		public bool IsDisconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x157A44C", Offset = "0x157A44C", VA = "0x157A44C")]
		public bool IsReconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1579C50", Offset = "0x1579C50", VA = "0x1579C50")]
		public void DisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x157A488", Offset = "0x157A488", VA = "0x157A488")]
		public void ReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x157C07C", Offset = "0x157C07C", VA = "0x157C07C")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x15837C8", Offset = "0x15837C8", VA = "0x15837C8")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x157AC80", Offset = "0x157AC80", VA = "0x157AC80")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1583B18", Offset = "0x1583B18", VA = "0x1583B18")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1583BC0", Offset = "0x1583BC0", VA = "0x1583BC0")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1583C68", Offset = "0x1583C68", VA = "0x1583C68")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1583D10", Offset = "0x1583D10", VA = "0x1583D10")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1583DB8", Offset = "0x1583DB8", VA = "0x1583DB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C958", Offset = "0xA0C958")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1583EC4", Offset = "0x1583EC4", VA = "0x1583EC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C990", Offset = "0xA0C990")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1584034", Offset = "0x1584034", VA = "0x1584034")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0C9C8", Offset = "0xA0C9C8")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x158416C", Offset = "0x158416C", VA = "0x158416C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0CA00", Offset = "0xA0CA00")]
		public void FixMusclePositionsAndRotations()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1580094", Offset = "0x1580094", VA = "0x1580094")]
		public bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x15832D4", Offset = "0x15832D4", VA = "0x15832D4")]
		private int GetHighestDisconnectedParentIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1580D70", Offset = "0x1580D70", VA = "0x1580D70")]
		private void ProcessDisconnects()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1580E6C", Offset = "0x1580E6C", VA = "0x1580E6C")]
		private void ProcessReconnects()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x15842DC", Offset = "0x15842DC", VA = "0x15842DC")]
		private void OnDisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x158473C", Offset = "0x158473C", VA = "0x158473C")]
		private void DisconnectMuscle(Muscle m, bool sever, bool deactivate)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x15845A0", Offset = "0x15845A0", VA = "0x15845A0")]
		private void OnReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1584BE0", Offset = "0x1584BE0", VA = "0x1584BE0")]
		private void ReconnectMuscle(Muscle m)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1584FB4", Offset = "0x1584FB4", VA = "0x1584FB4")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x15839CC", Offset = "0x15839CC", VA = "0x15839CC")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1583A94", Offset = "0x1583A94", VA = "0x1583A94")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1585120", Offset = "0x1585120", VA = "0x1585120")]
		public void SwitchToActiveMode()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1585128", Offset = "0x1585128", VA = "0x1585128")]
		public void SwitchToKinematicMode()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1585134", Offset = "0x1585134", VA = "0x1585134")]
		public void SwitchToDisabledMode()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1585154", Offset = "0x1585154", VA = "0x1585154")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x15851F4", Offset = "0x15851F4", VA = "0x15851F4", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1585358", Offset = "0x1585358", VA = "0x1585358")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x15854AC", Offset = "0x15854AC", VA = "0x15854AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0CA58", Offset = "0xA0CA58")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1585524", Offset = "0x1585524", VA = "0x1585524")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x15855C8", Offset = "0x15855C8", VA = "0x15855C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0CAB8", Offset = "0xA0CAB8")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1585640", Offset = "0x1585640", VA = "0x1585640")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0CB18", Offset = "0xA0CB18")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x15856B8", Offset = "0x15856B8", VA = "0x15856B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0CB78", Offset = "0xA0CB78")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1585730", Offset = "0x1585730", VA = "0x1585730")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1585800", Offset = "0x1585800", VA = "0x1585800")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1585C6C", Offset = "0x1585C6C", VA = "0x1585C6C")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1585F7C", Offset = "0x1585F7C", VA = "0x1585F7C")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x15860AC", Offset = "0x15860AC", VA = "0x15860AC")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1586198", Offset = "0x1586198", VA = "0x1586198")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1585A8C", Offset = "0x1585A8C", VA = "0x1585A8C")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1586220", Offset = "0x1586220", VA = "0x1586220")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x15833FC", Offset = "0x15833FC", VA = "0x15833FC")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x15794B0", Offset = "0x15794B0", VA = "0x15794B0")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1580760", Offset = "0x1580760", VA = "0x1580760")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1585CF4", Offset = "0x1585CF4", VA = "0x1585CF4")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1585888", Offset = "0x1585888", VA = "0x1585888")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x158627C", Offset = "0x158627C", VA = "0x158627C")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x15837D4", Offset = "0x15837D4", VA = "0x15837D4")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1586480", Offset = "0x1586480", VA = "0x1586480")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x15871A4", Offset = "0x15871A4", VA = "0x15871A4")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x158657C", Offset = "0x158657C", VA = "0x158657C")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1587318", Offset = "0x1587318", VA = "0x1587318")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1587BC4", Offset = "0x1587BC4", VA = "0x1587BC4")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x15885EC", Offset = "0x15885EC", VA = "0x15885EC")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1587784", Offset = "0x1587784", VA = "0x1587784")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x15882DC", Offset = "0x15882DC", VA = "0x15882DC")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1588AA4", Offset = "0x1588AA4", VA = "0x1588AA4")]
		public void Kill()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1588AB0", Offset = "0x1588AB0", VA = "0x1588AB0")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1588ACC", Offset = "0x1588ACC", VA = "0x1588ACC")]
		public void Freeze()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1588AD8", Offset = "0x1588AD8", VA = "0x1588AD8")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1588AF4", Offset = "0x1588AF4", VA = "0x1588AF4")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1588AFC", Offset = "0x1588AFC", VA = "0x1588AFC", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1588BFC", Offset = "0x1588BFC", VA = "0x1588BFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0CBF8", Offset = "0xA0CBF8")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1581624", Offset = "0x1581624", VA = "0x1581624")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1588C88", Offset = "0x1588C88", VA = "0x1588C88")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x157E54C", Offset = "0x157E54C", VA = "0x157E54C")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1588D98", Offset = "0x1588D98", VA = "0x1588D98")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1588DA4", Offset = "0x1588DA4", VA = "0x1588DA4")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1588FC0", Offset = "0x1588FC0", VA = "0x1588FC0")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x157E648", Offset = "0x157E648", VA = "0x157E648")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1589094", Offset = "0x1589094", VA = "0x1589094")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1589150", Offset = "0x1589150", VA = "0x1589150")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x158921C", Offset = "0x158921C", VA = "0x158921C")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x15801D8", Offset = "0x15801D8", VA = "0x15801D8")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x157FDEC", Offset = "0x157FDEC", VA = "0x157FDEC")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x15899F0", Offset = "0x15899F0", VA = "0x15899F0")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1589888", Offset = "0x1589888", VA = "0x1589888")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1589438", Offset = "0x1589438", VA = "0x1589438")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1589A68", Offset = "0x1589A68", VA = "0x1589A68")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1589BE4", Offset = "0x1589BE4", VA = "0x1589BE4")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1589774", Offset = "0x1589774", VA = "0x1589774")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1589ED4", Offset = "0x1589ED4", VA = "0x1589ED4")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x158A034", Offset = "0x158A034", VA = "0x158A034")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1589DFC", Offset = "0x1589DFC", VA = "0x1589DFC")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x157F76C", Offset = "0x157F76C", VA = "0x157F76C")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1583458", Offset = "0x1583458", VA = "0x1583458")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1583364", Offset = "0x1583364", VA = "0x1583364")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x158A294", Offset = "0x158A294", VA = "0x158A294")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CA")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x400043C")]
		Sever,
		[Token(Token = "0x400043D")]
		Explode,
		[Token(Token = "0x400043E")]
		Numb
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public enum MuscleDisconnectMode
	{
		[Token(Token = "0x4000440")]
		Sever,
		[Token(Token = "0x4000441")]
		Explode
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9FF218", Offset = "0x9FF218")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x1C5E8A8", Offset = "0x1C5E8A8", VA = "0x1C5E8A8")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA09734", Offset = "0xA09734")]
		public PuppetMaster.State state;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA0976C", Offset = "0xA0976C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0976C", Offset = "0xA0976C")]
		public float mappingWeight;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA097C0", Offset = "0xA097C0")]
		public float pinWeight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA097D8", Offset = "0xA097D8")]
		public float muscleWeight;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA097F0", Offset = "0xA097F0")]
		public float muscleSpring;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09828", Offset = "0xA09828")]
		public float pinPow;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09840", Offset = "0xA09840")]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool angularPinning;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool angularLimits;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool internalCollisions;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA0985C", Offset = "0xA0985C")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1380C40", Offset = "0x1380C40", VA = "0x1380C40")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1381018", Offset = "0x1381018", VA = "0x1381018")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1381158", Offset = "0x1381158", VA = "0x1381158")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public interface ICollisionEventListener
	{
		[Token(Token = "0x6000639")]
		void OnCollisionEnterEvent(Collision collision, CollisionEventBroadcaster broadcaster);

		[Token(Token = "0x600063A")]
		void OnCollisionStayEvent(Collision collision, CollisionEventBroadcaster broadcaster);

		[Token(Token = "0x600063B")]
		void OnCollisionExitEvent(Collision collision, CollisionEventBroadcaster broadcaster);
	}
	[Token(Token = "0x20000CF")]
	public class CollisionEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ICollisionEventListener listener;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MuscleLite muscle;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x15AA058", Offset = "0x15AA058", VA = "0x15AA058")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x15AA124", Offset = "0x15AA124", VA = "0x15AA124")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x15AA1F4", Offset = "0x15AA1F4", VA = "0x15AA1F4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x15AA2C4", Offset = "0x15AA2C4", VA = "0x15AA2C4")]
		public CollisionEventBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public class MuscleLite
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float pinWeightMlp;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float muscleWeightMlp;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float muscleDamperMlp;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float mappingWeightMlp;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA098B4", Offset = "0xA098B4")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA098C4", Offset = "0xA098C4")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA098D4", Offset = "0xA098D4")]
		private Vector3 <positionOffset>k__BackingField;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA098E4", Offset = "0xA098E4")]
		private int <index>k__BackingField;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Quaternion toParentSpace;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float lastRotationDamper;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool initiated;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Transform connectedBodyTarget;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform targetParent;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool directTargetParent;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 targetVelocity;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 targetAnimatedCenterOfMass;

		[Token(Token = "0x17000099")]
		public Transform transform
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x15741A8", Offset = "0x15741A8", VA = "0x15741A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CDE8", Offset = "0xA0CDE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x15741B0", Offset = "0x15741B0", VA = "0x15741B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CDF8", Offset = "0xA0CDF8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x15741B8", Offset = "0x15741B8", VA = "0x15741B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE08", Offset = "0xA0CE08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x15741C0", Offset = "0x15741C0", VA = "0x15741C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE18", Offset = "0xA0CE18")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public Vector3 positionOffset
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x15741C8", Offset = "0x15741C8", VA = "0x15741C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE28", Offset = "0xA0CE28")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x15741D4", Offset = "0x15741D4", VA = "0x15741D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE38", Offset = "0xA0CE38")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public int index
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x15741E0", Offset = "0x15741E0", VA = "0x15741E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE48", Offset = "0xA0CE48")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x15741E8", Offset = "0x15741E8", VA = "0x15741E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE58", Offset = "0xA0CE58")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x1574A58", Offset = "0x1574A58", VA = "0x1574A58")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700009E")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1574FA4", Offset = "0x1574FA4", VA = "0x1574FA4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700009F")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x157492C", Offset = "0x157492C", VA = "0x157492C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000A0")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x1574898", Offset = "0x1574898", VA = "0x1574898")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x15741F0", Offset = "0x15741F0", VA = "0x15741F0")]
		public void Initiate(MuscleLite[] colleagues)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1574C18", Offset = "0x1574C18", VA = "0x1574C18")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1574C78", Offset = "0x1574C78", VA = "0x1574C78")]
		public void Reset()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1574E10", Offset = "0x1574E10", VA = "0x1574E10")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1574F0C", Offset = "0x1574F0C", VA = "0x1574F0C")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1574AD8", Offset = "0x1574AD8", VA = "0x1574AD8")]
		public void Read()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1575034", Offset = "0x1575034", VA = "0x1575034")]
		public void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, bool angularPinning)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x157508C", Offset = "0x157508C", VA = "0x157508C")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1575280", Offset = "0x1575280", VA = "0x1575280")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1575474", Offset = "0x1575474", VA = "0x1575474")]
		public void Map(float masterWeight)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1575764", Offset = "0x1575764", VA = "0x1575764")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1575404", Offset = "0x1575404", VA = "0x1575404")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1575958", Offset = "0x1575958", VA = "0x1575958")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x15759BC", Offset = "0x15759BC", VA = "0x15759BC")]
		public MuscleLite()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class PuppetControllerLite : MonoBehaviour, ICollisionEventListener
	{
		[Serializable]
		[Token(Token = "0x20000D2")]
		public class Group
		{
			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0992C", Offset = "0xA0992C")]
			public int[] indices;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09964", Offset = "0xA09964")]
			public float pinWeightMlp;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0997C", Offset = "0xA0997C")]
			public float muscleWeightMlp;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09994", Offset = "0xA09994")]
			public float drag;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA099CC", Offset = "0xA099CC")]
			public float blendInTime;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09A04", Offset = "0xA09A04")]
			public float blendOutTime;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09A3C", Offset = "0xA09A3C")]
			private bool <enabled>k__BackingField;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09A4C", Offset = "0xA09A4C")]
			private float <mappingWeight>k__BackingField;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float dam;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float damTime;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float damV;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float map;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float mapV;

			[Token(Token = "0x170000A1")]
			public bool enabled
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x1C5D1BC", Offset = "0x1C5D1BC", VA = "0x1C5D1BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE68", Offset = "0xA0CE68")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x1C5D1C4", Offset = "0x1C5D1C4", VA = "0x1C5D1C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE78", Offset = "0xA0CE78")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			public float mappingWeight
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x1C5D1D0", Offset = "0x1C5D1D0", VA = "0x1C5D1D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE88", Offset = "0xA0CE88")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000665")]
				[Address(RVA = "0x1C5D1D8", Offset = "0x1C5D1D8", VA = "0x1C5D1D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0CE98", Offset = "0xA0CE98")]
				private set
				{
				}
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1C5D1E0", Offset = "0x1C5D1E0", VA = "0x1C5D1E0")]
			public void TryDamage(Collision collision, CollisionEventBroadcaster broadcaster)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1C5D270", Offset = "0x1C5D270", VA = "0x1C5D270")]
			public void Update(PuppetMasterLite puppetMaster)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1C5D4F8", Offset = "0x1C5D4F8", VA = "0x1C5D4F8")]
			public Group()
			{
			}
		}

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMasterLite puppetMaster;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask collisionLayers;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA098F4", Offset = "0xA098F4")]
		public Group[] groups;

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x157CCFC", Offset = "0x157CCFC", VA = "0x157CCFC")]
		private void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x157CDE4", Offset = "0x157CDE4", VA = "0x157CDE4")]
		private bool NeedToUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x157CE50", Offset = "0x157CE50", VA = "0x157CE50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x157CF48", Offset = "0x157CF48", VA = "0x157CF48", Slot = "4")]
		public void OnCollisionEnterEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x157D0AC", Offset = "0x157D0AC", VA = "0x157D0AC", Slot = "5")]
		public void OnCollisionStayEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x157CF4C", Offset = "0x157CF4C", VA = "0x157CF4C")]
		private void ProcessCollisionEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x157D0B0", Offset = "0x157D0B0", VA = "0x157D0B0", Slot = "6")]
		public void OnCollisionExitEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x157D0B4", Offset = "0x157D0B4", VA = "0x157D0B4")]
		public PuppetControllerLite()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class PuppetMasterLite : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		public delegate void PuppetMasterLiteDelegate();

		[Token(Token = "0x20000D5")]
		public enum UpdateMode
		{
			[Token(Token = "0x400049D")]
			Normal,
			[Token(Token = "0x400049E")]
			Fixed
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF284", Offset = "0x9FF284")]
		private sealed class <Activation>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterLite <>4__this;

			[Token(Token = "0x170000A3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x1C5E9A8", Offset = "0x1C5E9A8", VA = "0x1C5E9A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000680")]
				[Address(RVA = "0x1C5E9F0", Offset = "0x1C5E9F0", VA = "0x1C5E9F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1C5E8B0", Offset = "0x1C5E8B0", VA = "0x1C5E8B0")]
			[DebuggerHidden]
			public <Activation>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x1C5E8DC", Offset = "0x1C5E8DC", VA = "0x1C5E8DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x1C5E8E0", Offset = "0x1C5E8E0", VA = "0x1C5E8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1C5E9B0", Offset = "0x1C5E9B0", VA = "0x1C5E9B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF294", Offset = "0x9FF294")]
		private sealed class <Deactivation>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterLite <>4__this;

			[Token(Token = "0x170000A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x1C5EB20", Offset = "0x1C5EB20", VA = "0x1C5EB20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x1C5EB68", Offset = "0x1C5EB68", VA = "0x1C5EB68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1C5E9F8", Offset = "0x1C5E9F8", VA = "0x1C5E9F8")]
			[DebuggerHidden]
			public <Deactivation>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1C5EA24", Offset = "0x1C5EA24", VA = "0x1C5EA24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1C5EA28", Offset = "0x1C5EA28", VA = "0x1C5EA28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x1C5EB28", Offset = "0x1C5EB28", VA = "0x1C5EB28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetRoot;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool fixTargetTransforms;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blendTime;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09A5C", Offset = "0xA09A5C")]
		public float mappingWeight;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09A74", Offset = "0xA09A74")]
		public float pinWeight;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09A8C", Offset = "0xA09A8C")]
		public float muscleWeight;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float muscleSpring;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float muscleDamper;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool angularPinning;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA09AA4", Offset = "0xA09AA4")]
		public MuscleLite[] muscles;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PuppetMasterLiteDelegate OnRead;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PuppetMasterLiteDelegate OnWrite;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator targetAnimator;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool animatorDisabled;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool fixedFrame;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private UpdateMode updateMode;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1381234", Offset = "0x1381234", VA = "0x1381234")]
		private void Start()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1381408", Offset = "0x1381408", VA = "0x1381408")]
		public void Activate()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x138162C", Offset = "0x138162C", VA = "0x138162C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0CEA8", Offset = "0xA0CEA8")]
		private IEnumerator Activation()
		{
			return null;
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x13816A4", Offset = "0x13816A4", VA = "0x13816A4")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1381708", Offset = "0x1381708", VA = "0x1381708")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0CF08", Offset = "0xA0CF08")]
		private IEnumerator Deactivation()
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1381238", Offset = "0x1381238", VA = "0x1381238")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1381780", Offset = "0x1381780", VA = "0x1381780")]
		private void Update()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x138182C", Offset = "0x138182C", VA = "0x138182C")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x13818A0", Offset = "0x13818A0", VA = "0x13818A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x13819CC", Offset = "0x13819CC", VA = "0x13819CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1381554", Offset = "0x1381554", VA = "0x1381554")]
		private void Read()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1381A48", Offset = "0x1381A48", VA = "0x1381A48")]
		private void Write()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1381AE0", Offset = "0x1381AE0", VA = "0x1381AE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1381C8C", Offset = "0x1381C8C", VA = "0x1381C8C")]
		public PuppetMasterLite()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class PuppetMasterProp : MonoBehaviour
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09ADC", Offset = "0xA09ADC")]
		public Transform meshRoot;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09B14", Offset = "0xA09B14")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09B4C", Offset = "0xA09B4C")]
		public bool forceLayers;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09B84", Offset = "0xA09B84")]
		public float mass;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09BBC", Offset = "0xA09BBC")]
		public int propType;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09BF4", Offset = "0xA09BF4")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA09BF4", Offset = "0xA09BF4")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA09C54", Offset = "0xA09C54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09C54", Offset = "0xA09C54")]
		public Vector3 additionalPinOffsetAdd;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09CB4", Offset = "0xA09CB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09CB4", Offset = "0xA09CB4")]
		public float additionalPinWeight;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09D08", Offset = "0xA09D08")]
		public float additionalPinMass;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09D40", Offset = "0xA09D40")]
		private bool <isPickedUp>k__BackingField;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09D50", Offset = "0xA09D50")]
		private Vector3 <inertiaTensor>k__BackingField;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09D60", Offset = "0xA09D60")]
		private Vector3 <localCenterOfMass>k__BackingField;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09D70", Offset = "0xA09D70")]
		private Muscle <propMuscle>k__BackingField;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int defaultLayer;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform defaultParent;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] colliders;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PhysicMaterial[] droppedMaterials;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Rigidbody r;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _mass;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _drag;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _angularDrag;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool _useGravity;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool _isKinematic;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RigidbodyInterpolation _interpolation;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private CollisionDetectionMode _collisionDetectionMode;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RigidbodyConstraints _constraints;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Collider[] emptyColliders;

		[Token(Token = "0x170000A7")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1381D18", Offset = "0x1381D18", VA = "0x1381D18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D008", Offset = "0xA0D008")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1381D20", Offset = "0x1381D20", VA = "0x1381D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D018", Offset = "0xA0D018")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public Vector3 inertiaTensor
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1381DD0", Offset = "0x1381DD0", VA = "0x1381DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D028", Offset = "0xA0D028")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1381DDC", Offset = "0x1381DDC", VA = "0x1381DDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D038", Offset = "0xA0D038")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public Vector3 localCenterOfMass
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x1381DE8", Offset = "0x1381DE8", VA = "0x1381DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D048", Offset = "0xA0D048")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1381DF4", Offset = "0x1381DF4", VA = "0x1381DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D058", Offset = "0xA0D058")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		protected Muscle propMuscle
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1381E08", Offset = "0x1381E08", VA = "0x1381E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D068", Offset = "0xA0D068")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1381E10", Offset = "0x1381E10", VA = "0x1381E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D078", Offset = "0xA0D078")]
			private set
			{
			}
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1381D2C", Offset = "0x1381D2C", VA = "0x1381D2C")]
		public Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1381E00", Offset = "0x1381E00", VA = "0x1381E00", Slot = "4")]
		protected virtual void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1381E04", Offset = "0x1381E04", VA = "0x1381E04", Slot = "5")]
		protected virtual void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1381E18", Offset = "0x1381E18", VA = "0x1381E18")]
		public void PickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1382374", Offset = "0x1382374", VA = "0x1382374")]
		public void Drop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x13828C8", Offset = "0x13828C8", VA = "0x13828C8", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1382A68", Offset = "0x1382A68", VA = "0x1382A68", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1382C9C", Offset = "0x1382C9C", VA = "0x1382C9C", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x13821D8", Offset = "0x13821D8", VA = "0x13821D8")]
		private void RemoveRigidbody()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x138275C", Offset = "0x138275C", VA = "0x138275C")]
		private void ReattachRigidbody()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1382D18", Offset = "0x1382D18", VA = "0x1382D18")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1382E80", Offset = "0x1382E80", VA = "0x1382E80")]
		public PuppetMasterProp()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FF2A4", Offset = "0x9FF2A4")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09DE8", Offset = "0xA09DE8")]
			public int puppetsPerFrame;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x1C5EF5C", Offset = "0x1C5EF5C", VA = "0x1C5EF5C")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x1C5EF88", Offset = "0x1C5EF88", VA = "0x1C5EF88")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1C5EFA4", Offset = "0x1C5EFA4", VA = "0x1C5EFA4")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA09D80", Offset = "0xA09D80")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09DB8", Offset = "0xA09DB8")]
		private int <currentlyActivePuppets>k__BackingField;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09DC8", Offset = "0xA09DC8")]
		private int <currentlyKinematicPuppets>k__BackingField;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09DD8", Offset = "0xA09DD8")]
		private int <currentlyDisabledPuppets>k__BackingField;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x170000AB")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x13831A4", Offset = "0x13831A4", VA = "0x13831A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D088", Offset = "0xA0D088")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x13831AC", Offset = "0x13831AC", VA = "0x13831AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D098", Offset = "0xA0D098")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x13831B4", Offset = "0x13831B4", VA = "0x13831B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D0A8", Offset = "0xA0D0A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x13831BC", Offset = "0x13831BC", VA = "0x13831BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D0B8", Offset = "0xA0D0B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x13831C4", Offset = "0x13831C4", VA = "0x13831C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D0C8", Offset = "0xA0D0C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x13831CC", Offset = "0x13831CC", VA = "0x13831CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D0D8", Offset = "0xA0D0D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x13831D4", Offset = "0x13831D4", VA = "0x13831D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x13831DC", Offset = "0x13831DC", VA = "0x13831DC")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x138327C", Offset = "0x138327C", VA = "0x138327C")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x13832E0", Offset = "0x13832E0", VA = "0x13832E0")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1383308", Offset = "0x1383308", VA = "0x1383308")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1383330", Offset = "0x1383330", VA = "0x1383330")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1383358", Offset = "0x1383358", VA = "0x1383358")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1383554", Offset = "0x1383554", VA = "0x1383554")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x13835AC", Offset = "0x13835AC", VA = "0x13835AC")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1383704", Offset = "0x1383704", VA = "0x1383704")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1383CC4", Offset = "0x1383CC4", VA = "0x1383CC4")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x13845B0", Offset = "0x13845B0", VA = "0x13845B0")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x13845D4", Offset = "0x13845D4", VA = "0x13845D4")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000DC")]
	public class RigidbodyController : MonoBehaviour
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09E04", Offset = "0xA09E04")]
		public float forceWeight;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA09E1C", Offset = "0xA09E1C")]
		public float torqueWeight;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useTargetVelocity;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 lastTargetPos;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastTargetRot;

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x138773C", Offset = "0x138773C", VA = "0x138773C")]
		public void OnTargetTeleported()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x138778C", Offset = "0x138778C", VA = "0x138778C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x13877F0", Offset = "0x13877F0", VA = "0x13877F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1387B18", Offset = "0x1387B18", VA = "0x1387B18")]
		public RigidbodyController()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DD")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public enum Mode
		{
			[Token(Token = "0x40004D8")]
			Float,
			[Token(Token = "0x40004D9")]
			Curve
		}

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x138DA18", Offset = "0x138DA18", VA = "0x138DA18")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x138DA88", Offset = "0x138DA88", VA = "0x138DA88")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x138DB14", Offset = "0x138DB14", VA = "0x138DB14")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000DF")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x193E018", Offset = "0x193E018", VA = "0x193E018")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x193E07C", Offset = "0x193E07C", VA = "0x193E07C")]
		public InitialVelocity()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FF2DC", Offset = "0x9FF2DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9FF2DC", Offset = "0x9FF2DC")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public struct Options
		{
			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA09E34", Offset = "0xA09E34")]
			public bool spine;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA09E6C", Offset = "0xA09E6C")]
			public JointType joints;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA09EA4", Offset = "0xA09EA4")]
			public float colliderLengthOverlap;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x170000AF")]
			public static Options Default
			{
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x138F7F0", Offset = "0x138F7F0", VA = "0x138F7F0")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1AC5918", Offset = "0x1AC5918", VA = "0x1AC5918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0D0E8", Offset = "0xA0D0E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1AC5960", Offset = "0x1AC5960", VA = "0x1AC5960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0D120", Offset = "0xA0D120")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1AC59A8", Offset = "0x1AC59A8", VA = "0x1AC59A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0D158", Offset = "0xA0D158")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1AC59F0", Offset = "0x1AC59F0", VA = "0x1AC59F0")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1AC5C98", Offset = "0x1AC5C98", VA = "0x1AC5C98")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1AC6674", Offset = "0x1AC6674", VA = "0x1AC6674")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1AC7E60", Offset = "0x1AC7E60", VA = "0x1AC7E60")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1AC808C", Offset = "0x1AC808C", VA = "0x1AC808C")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1AC8480", Offset = "0x1AC8480", VA = "0x1AC8480")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1AC7150", Offset = "0x1AC7150", VA = "0x1AC7150")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1AC75BC", Offset = "0x1AC75BC", VA = "0x1AC75BC")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1AC8560", Offset = "0x1AC8560", VA = "0x1AC8560")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1AC8B10", Offset = "0x1AC8B10", VA = "0x1AC8B10")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1AC8F84", Offset = "0x1AC8F84", VA = "0x1AC8F84")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1AC7DB0", Offset = "0x1AC7DB0", VA = "0x1AC7DB0")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1AC5BF8", Offset = "0x1AC5BF8", VA = "0x1AC5BF8")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1AC9088", Offset = "0x1AC9088", VA = "0x1AC9088")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E2")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1AC5DE8", Offset = "0x1AC5DE8", VA = "0x1AC5DE8")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1AC90E8", Offset = "0x1AC90E8", VA = "0x1AC90E8")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1AC91E4", Offset = "0x1AC91E4", VA = "0x1AC91E4")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1AC957C", Offset = "0x1AC957C", VA = "0x1AC957C")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1AC8B88", Offset = "0x1AC8B88", VA = "0x1AC8B88")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1AC9918", Offset = "0x1AC9918", VA = "0x1AC9918")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1AC9BA0", Offset = "0x1AC9BA0", VA = "0x1AC9BA0")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x20000E3")]
	public static class JointConverter
	{
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x193EE10", Offset = "0x193EE10", VA = "0x193EE10")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x193F344", Offset = "0x193F344", VA = "0x193F344")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x193F618", Offset = "0x193F618", VA = "0x193F618")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x193F74C", Offset = "0x193F74C", VA = "0x193F74C")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x193F0FC", Offset = "0x193F0FC", VA = "0x193F0FC")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x193F8FC", Offset = "0x193F8FC", VA = "0x193F8FC")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x193FA34", Offset = "0x193FA34", VA = "0x193FA34")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x193FAF0", Offset = "0x193FAF0", VA = "0x193FAF0")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x193FA98", Offset = "0x193FA98", VA = "0x193FA98")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x193FB54", Offset = "0x193FB54", VA = "0x193FB54")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x193FBB4", Offset = "0x193FBB4", VA = "0x193FBB4")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x20000E4")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public enum ColliderType
		{
			[Token(Token = "0x40004FE")]
			Box,
			[Token(Token = "0x40004FF")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public enum JointType
		{
			[Token(Token = "0x4000501")]
			Configurable,
			[Token(Token = "0x4000502")]
			Character
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public enum Direction
		{
			[Token(Token = "0x4000504")]
			X,
			[Token(Token = "0x4000505")]
			Y,
			[Token(Token = "0x4000506")]
			Z
		}

		[Token(Token = "0x20000E8")]
		public struct CreateJointParams
		{
			[Token(Token = "0x20000E9")]
			public struct Limits
			{
				[Token(Token = "0x400050D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x400050E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x400050F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x4000510")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x1C5F920", Offset = "0x1C5F920", VA = "0x1C5F920")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1C5F0D0", Offset = "0x1C5F0D0", VA = "0x1C5F0D0")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1385B48", Offset = "0x1385B48", VA = "0x1385B48")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1385D5C", Offset = "0x1385D5C", VA = "0x1385D5C")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1385FB0", Offset = "0x1385FB0", VA = "0x1385FB0")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1386398", Offset = "0x1386398", VA = "0x1386398")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x13862AC", Offset = "0x13862AC", VA = "0x13862AC")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x13866BC", Offset = "0x13866BC", VA = "0x13866BC")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x13866CC", Offset = "0x13866CC", VA = "0x13866CC")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x13866E8", Offset = "0x13866E8", VA = "0x13866E8")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x138670C", Offset = "0x138670C", VA = "0x138670C")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x13862DC", Offset = "0x13862DC", VA = "0x13862DC")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1386730", Offset = "0x1386730", VA = "0x1386730")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x13868D0", Offset = "0x13868D0", VA = "0x13868D0")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1386A80", Offset = "0x1386A80", VA = "0x1386A80")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x138700C", Offset = "0x138700C", VA = "0x138700C")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1387040", Offset = "0x1387040", VA = "0x1387040")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9FF33C", Offset = "0x9FF33C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FF33C", Offset = "0x9FF33C")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EB")]
		public enum Mode
		{
			[Token(Token = "0x4000516")]
			Colliders,
			[Token(Token = "0x4000517")]
			Joints
		}

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1387048", Offset = "0x1387048", VA = "0x1387048")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0D190", Offset = "0xA0D190")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1387090", Offset = "0x1387090", VA = "0x1387090")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0D1C8", Offset = "0xA0D1C8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x13870D8", Offset = "0x13870D8", VA = "0x13870D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xA0D200", Offset = "0xA0D200")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1387120", Offset = "0x1387120", VA = "0x1387120")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000EC")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		public class Offset
		{
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1C5C4FC", Offset = "0x1C5C4FC", VA = "0x1C5C4FC")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x1C5C670", Offset = "0x1C5C670", VA = "0x1C5C670")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x193AFE4", Offset = "0x193AFE4", VA = "0x193AFE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x193B040", Offset = "0x193B040", VA = "0x193B040")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x193B0BC", Offset = "0x193B0BC", VA = "0x193B0BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x193B1A0", Offset = "0x193B1A0", VA = "0x193B1A0")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF39C", Offset = "0x9FF39C")]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1AB7DB4", Offset = "0x1AB7DB4", VA = "0x1AB7DB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1AB7E10", Offset = "0x1AB7E10", VA = "0x1AB7E10")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1AB7E6C", Offset = "0x1AB7E6C", VA = "0x1AB7E6C")]
		public AnimatorIKDemo()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1ABC45C", Offset = "0x1ABC45C", VA = "0x1ABC45C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1ABC684", Offset = "0x1ABC684", VA = "0x1ABC684")]
		public BallShooter()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class BoardController : MonoBehaviour
	{
		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int groundLayer;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationTarget;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float torque;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float skidDrag;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float turnSensitivity;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody r;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isGrounded;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x15A4E98", Offset = "0x15A4E98", VA = "0x15A4E98")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x15A4EF4", Offset = "0x15A4EF4", VA = "0x15A4EF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x15A504C", Offset = "0x15A504C", VA = "0x15A504C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x15A528C", Offset = "0x15A528C", VA = "0x15A528C")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x15A52E8", Offset = "0x15A52E8", VA = "0x15A52E8")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x15A5344", Offset = "0x15A5344", VA = "0x15A5344")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x15A539C", Offset = "0x15A539C", VA = "0x15A539C")]
		public BoardController()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x170000B0")]
		private CharacterMeleeDemo melee
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x15A6738", Offset = "0x15A6738", VA = "0x15A6738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x15A67B8", Offset = "0x15A67B8", VA = "0x15A67B8", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x15A6CE0", Offset = "0x15A6CE0", VA = "0x15A6CE0")]
		public CharacterAnimationMeleeDemo()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x20000F4")]
			public class Anim
			{
				[Token(Token = "0x4000537")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x4000538")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x4000539")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x400053A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x600070E")]
				[Address(RVA = "0x1C5F5EC", Offset = "0x1C5F5EC", VA = "0x1C5F5EC")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x138F844", Offset = "0x138F844", VA = "0x138F844")]
			public Action()
			{
			}
		}

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA09F2C", Offset = "0xA09F2C")]
		public Action[] actions;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[HideInInspector]
		public int currentActionIndex;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[HideInInspector]
		public float lastActionTime;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private float lastActionMoveMag;

		[Token(Token = "0x170000B1")]
		public Action currentAction
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x15A6C94", Offset = "0x15A6C94", VA = "0x15A6C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x15A7B0C", Offset = "0x15A7B0C", VA = "0x15A7B0C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x15A7B98", Offset = "0x15A7B98", VA = "0x15A7B98", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x15A7DB8", Offset = "0x15A7DB8", VA = "0x15A7DB8")]
		private bool StartAction(Action action)
		{
			return default(bool);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x15A7FD8", Offset = "0x15A7FD8", VA = "0x15A7FD8")]
		public CharacterMeleeDemo()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA09F84", Offset = "0xA09F84")]
		public PropMuscle propMuscle;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA09FBC", Offset = "0xA09FBC")]
		private BehaviourPuppet <puppet>k__BackingField;

		[Token(Token = "0x170000B2")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x15A7FE8", Offset = "0x15A7FE8", VA = "0x15A7FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D238", Offset = "0xA0D238")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x15A7FF0", Offset = "0x15A7FF0", VA = "0x15A7FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D248", Offset = "0xA0D248")]
			private set
			{
			}
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x15A7B18", Offset = "0x15A7B18", VA = "0x15A7B18", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x15A8168", Offset = "0x15A8168", VA = "0x15A8168", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x15A8280", Offset = "0x15A8280", VA = "0x15A8280", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x15A8774", Offset = "0x15A8774", VA = "0x15A8774", Slot = "10")]
		protected override bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x15A7FE4", Offset = "0x15A7FE4", VA = "0x15A7FE4")]
		public CharacterPuppet()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA09FCC", Offset = "0xA09FCC")]
		public Transform ragdollPrefab;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A004", Offset = "0xA0A004")]
		public string instanceName;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A03C", Offset = "0xA0A03C")]
		public int characterControllerLayer;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A074", Offset = "0xA0A074")]
		public int ragdollLayer;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x15AA5D8", Offset = "0x15AA5D8", VA = "0x15AA5D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x15AA750", Offset = "0x15AA750", VA = "0x15AA750")]
		public CreatePuppetInRuntime()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A0AC", Offset = "0xA0A0AC")]
		public GameObject prefab;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x15AA7AC", Offset = "0x15AA7AC", VA = "0x15AA7AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x15AA950", Offset = "0x15AA950", VA = "0x15AA950")]
		private void Update()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x15AA954", Offset = "0x15AA954", VA = "0x15AA954")]
		public CreateRagdollInRuntime()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class DeathBaker : MonoBehaviour
	{
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF3FC", Offset = "0x9FF3FC")]
		private sealed class <Bake>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000724")]
				[Address(RVA = "0x1390A78", Offset = "0x1390A78", VA = "0x1390A78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000726")]
				[Address(RVA = "0x1390AC0", Offset = "0x1390AC0", VA = "0x1390AC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1390970", Offset = "0x1390970", VA = "0x1390970")]
			[DebuggerHidden]
			public <Bake>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x139099C", Offset = "0x139099C", VA = "0x139099C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x13909A0", Offset = "0x13909A0", VA = "0x13909A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1390A80", Offset = "0x1390A80", VA = "0x1390A80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF40C", Offset = "0x9FF40C")]
		private sealed class <FadeOutPinWeight>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072A")]
				[Address(RVA = "0x1390CC4", Offset = "0x1390CC4", VA = "0x1390CC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0x1390D0C", Offset = "0x1390D0C", VA = "0x1390D0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1390BF0", Offset = "0x1390BF0", VA = "0x1390BF0")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1390C1C", Offset = "0x1390C1C", VA = "0x1390C1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1390C20", Offset = "0x1390C20", VA = "0x1390C20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1390CCC", Offset = "0x1390CCC", VA = "0x1390CCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF41C", Offset = "0x9FF41C")]
		private sealed class <FadeOutMuscleWeight>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000730")]
				[Address(RVA = "0x1390BA0", Offset = "0x1390BA0", VA = "0x1390BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0x1390BE8", Offset = "0x1390BE8", VA = "0x1390BE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1390AC8", Offset = "0x1390AC8", VA = "0x1390AC8")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1390AF4", Offset = "0x1390AF4", VA = "0x1390AF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1390AF8", Offset = "0x1390AF8", VA = "0x1390AF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1390BA8", Offset = "0x1390BA8", VA = "0x1390BA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A0E4", Offset = "0xA0A0E4")]
		public HumanoidBaker baker;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A11C", Offset = "0xA0A11C")]
		public float bakeTime;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A154", Offset = "0xA0A154")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A18C", Offset = "0xA0A18C")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A1C4", Offset = "0xA0A1C4")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A1FC", Offset = "0xA0A1FC")]
		public float deadMuscleWeight;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool isDead;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x15AA964", Offset = "0x15AA964", VA = "0x15AA964")]
		private void Start()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x15AAA08", Offset = "0x15AAA08", VA = "0x15AAA08")]
		private void Update()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x15AAD18", Offset = "0x15AAD18", VA = "0x15AAD18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D258", Offset = "0xA0D258")]
		private IEnumerator Bake()
		{
			return null;
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x15AAC28", Offset = "0x15AAC28", VA = "0x15AAC28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D2B8", Offset = "0xA0D2B8")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x15AACA0", Offset = "0x15AACA0", VA = "0x15AACA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D318", Offset = "0xA0D318")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x15AAD90", Offset = "0x15AAD90", VA = "0x15AAD90")]
		public DeathBaker()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF42C", Offset = "0x9FF42C")]
		private sealed class <Destruct>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Destructor <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000739")]
				[Address(RVA = "0x1390E44", Offset = "0x1390E44", VA = "0x1390E44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600073B")]
				[Address(RVA = "0x1390E8C", Offset = "0x1390E8C", VA = "0x1390E8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1390D14", Offset = "0x1390D14", VA = "0x1390D14")]
			[DebuggerHidden]
			public <Destruct>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1390D40", Offset = "0x1390D40", VA = "0x1390D40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x1390D44", Offset = "0x1390D44", VA = "0x1390D44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1390E4C", Offset = "0x1390E4C", VA = "0x1390E4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x15AAF5C", Offset = "0x15AAF5C", VA = "0x15AAF5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x15AAF88", Offset = "0x15AAF88", VA = "0x15AAF88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D468", Offset = "0xA0D468")]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x15AB000", Offset = "0x15AB000", VA = "0x15AB000")]
		public Destructor()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF43C", Offset = "0x9FF43C")]
		private sealed class <FadeOutPinWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000744")]
				[Address(RVA = "0x1391090", Offset = "0x1391090", VA = "0x1391090", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000746")]
				[Address(RVA = "0x13910D8", Offset = "0x13910D8", VA = "0x13910D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1390FBC", Offset = "0x1390FBC", VA = "0x1390FBC")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x1390FE8", Offset = "0x1390FE8", VA = "0x1390FE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x1390FEC", Offset = "0x1390FEC", VA = "0x1390FEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1391098", Offset = "0x1391098", VA = "0x1391098", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF44C", Offset = "0x9FF44C")]
		private sealed class <FadeOutMuscleWeight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0x1390F6C", Offset = "0x1390F6C", VA = "0x1390F6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0x1390FB4", Offset = "0x1390FB4", VA = "0x1390FB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x1390E94", Offset = "0x1390E94", VA = "0x1390E94")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x1390EC0", Offset = "0x1390EC0", VA = "0x1390EC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1390EC4", Offset = "0x1390EC4", VA = "0x1390EC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1390F74", Offset = "0x1390F74", VA = "0x1390F74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A234", Offset = "0xA0A234")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A26C", Offset = "0xA0A26C")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A2A4", Offset = "0xA0A2A4")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A2DC", Offset = "0xA0A2DC")]
		public float deadMuscleWeight;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x15AB020", Offset = "0x15AB020", VA = "0x15AB020")]
		private void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x15AB0C4", Offset = "0x15AB0C4", VA = "0x15AB0C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x15AB2B4", Offset = "0x15AB2B4", VA = "0x15AB2B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D518", Offset = "0xA0D518")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x15AB32C", Offset = "0x15AB32C", VA = "0x15AB32C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D578", Offset = "0xA0D578")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x15AB3A4", Offset = "0x15AB3A4", VA = "0x15AB3A4")]
		public Dying()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF45C", Offset = "0x9FF45C")]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x193B1A8", Offset = "0x193B1A8", VA = "0x193B1A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x193B2A8", Offset = "0x193B2A8", VA = "0x193B2A8")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x193B514", Offset = "0x193B514", VA = "0x193B514")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x193B63C", Offset = "0x193B63C", VA = "0x193B63C")]
		public FXCollisionBlood()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A314", Offset = "0xA0A314")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A34C", Offset = "0xA0A34C")]
		public UserControlMelee userControl;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A384", Offset = "0xA0A384")]
		public int grabLayer;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x4000577")]
		private const float massMlp = 5f;

		[Token(Token = "0x4000578")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x193BD5C", Offset = "0x193BD5C", VA = "0x193BD5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x193BDE8", Offset = "0x193BDE8", VA = "0x193BDE8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x193C1E0", Offset = "0x193C1E0", VA = "0x193C1E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x193C324", Offset = "0x193C324", VA = "0x193C324")]
		public Grab()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A3BC", Offset = "0xA0A3BC")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A3F4", Offset = "0xA0A3F4")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x193FC08", Offset = "0x193FC08", VA = "0x193FC08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x193FCD8", Offset = "0x193FCD8", VA = "0x193FCD8")]
		public Killing()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0A42C", Offset = "0xA0A42C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A42C", Offset = "0xA0A42C")]
		public Transform characterController;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A48C", Offset = "0xA0A48C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0A48C", Offset = "0xA0A48C")]
		public int characterControllerLayer;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A4EC", Offset = "0xA0A4EC")]
		public int ragdollLayer;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A524", Offset = "0xA0A524")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A55C", Offset = "0xA0A55C")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x19403B0", Offset = "0x19403B0", VA = "0x19403B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x19405BC", Offset = "0x19405BC", VA = "0x19405BC")]
		public LayerSetup()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class NavMeshPuppet : MonoBehaviour
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NavMeshAgent agent;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1575A68", Offset = "0x1575A68", VA = "0x1575A68")]
		private void Update()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1575B60", Offset = "0x1575B60", VA = "0x1575B60")]
		public NavMeshPuppet()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1578024", Offset = "0x1578024", VA = "0x1578024")]
		private void Awake()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1578128", Offset = "0x1578128", VA = "0x1578128")]
		public Planet()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class PlanetaryGravity : MonoBehaviour
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Planet planet;

		[Token(Token = "0x4000587")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody _r;

		[Token(Token = "0x170000BF")]
		private Rigidbody r
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1578138", Offset = "0x1578138", VA = "0x1578138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x15781EC", Offset = "0x15781EC", VA = "0x15781EC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x15782C8", Offset = "0x15782C8", VA = "0x15782C8")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x15783FC", Offset = "0x15783FC", VA = "0x15783FC")]
		public PlanetaryGravity()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A594", Offset = "0xA0A594")]
		public PuppetMasterProp prop;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A5CC", Offset = "0xA0A5CC")]
		public PropMuscle propMuscleLeft;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A604", Offset = "0xA0A604")]
		public PropMuscle propMuscleRight;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A63C", Offset = "0xA0A63C")]
		public bool pickUpOnAwake;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x170000C0")]
		private PropMuscle connectTo
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1579080", Offset = "0x1579080", VA = "0x1579080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x157903C", Offset = "0x157903C", VA = "0x157903C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x157909C", Offset = "0x157909C", VA = "0x157909C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1579174", Offset = "0x1579174", VA = "0x1579174")]
		public PropDemo()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF4BC", Offset = "0x9FF4BC")]
		private sealed class <Action>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropMelee <>4__this;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <additionalPinMuscleIndex>5__2;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600076E")]
				[Address(RVA = "0x1C5CDB4", Offset = "0x1C5CDB4", VA = "0x1C5CDB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000770")]
				[Address(RVA = "0x1C5CDFC", Offset = "0x1C5CDFC", VA = "0x1C5CDFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1C5CB4C", Offset = "0x1C5CB4C", VA = "0x1C5CB4C")]
			[DebuggerHidden]
			public <Action>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x1C5CB78", Offset = "0x1C5CB78", VA = "0x1C5CB78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1C5CB7C", Offset = "0x1C5CB7C", VA = "0x1C5CB7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1C5CDBC", Offset = "0x1C5CDBC", VA = "0x1C5CDBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A674", Offset = "0xA0A674")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA0A674", Offset = "0xA0A674")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A6D4", Offset = "0xA0A6D4")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A70C", Offset = "0xA0A70C")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A744", Offset = "0xA0A744")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0A744", Offset = "0xA0A744")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0A798", Offset = "0xA0A798")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A798", Offset = "0xA0A798")]
		public float actionMassMlp;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A7F0", Offset = "0xA0A7F0")]
		public Vector3 COMOffset;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float defaultMass;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float defaultAddMass;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Rigidbody r;

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1579184", Offset = "0x1579184", VA = "0x1579184")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x15791CC", Offset = "0x15791CC", VA = "0x15791CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D678", Offset = "0xA0D678")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1579254", Offset = "0x1579254", VA = "0x1579254", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x157931C", Offset = "0x157931C", VA = "0x157931C", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1579394", Offset = "0x1579394", VA = "0x1579394", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x157940C", Offset = "0x157940C", VA = "0x157940C")]
		public PropMelee()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMasterProp prop;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x157A95C", Offset = "0x157A95C", VA = "0x157A95C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x157AB08", Offset = "0x157AB08", VA = "0x157AB08")]
		public PropPickUpTrigger()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A828", Offset = "0xA0A828")]
		public Rigidbody target;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A860", Offset = "0xA0A860")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A898", Offset = "0xA0A898")]
		public Transform bodyTarget;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x157CAC4", Offset = "0x157CAC4", VA = "0x157CAC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x157CB74", Offset = "0x157CB74", VA = "0x157CB74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x157CCF4", Offset = "0x157CCF4", VA = "0x157CCF4")]
		public PuppetBoard()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class PuppetMasterPropMelee : PuppetMasterProp
	{
		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF4CC", Offset = "0x9FF4CC")]
		private sealed class <Action>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterPropMelee <>4__this;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600077F")]
				[Address(RVA = "0x1C5EF0C", Offset = "0x1C5EF0C", VA = "0x1C5EF0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000781")]
				[Address(RVA = "0x1C5EF54", Offset = "0x1C5EF54", VA = "0x1C5EF54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1C5EDC8", Offset = "0x1C5EDC8", VA = "0x1C5EDC8")]
			[DebuggerHidden]
			public <Action>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1C5EDF4", Offset = "0x1C5EDF4", VA = "0x1C5EDF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1C5EDF8", Offset = "0x1C5EDF8", VA = "0x1C5EDF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1C5EF14", Offset = "0x1C5EF14", VA = "0x1C5EF14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xA0A8D0", Offset = "0xA0A8D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A8D0", Offset = "0xA0A8D0")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A930", Offset = "0xA0A930")]
		public BoxCollider boxCollider;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A968", Offset = "0xA0A968")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A9A0", Offset = "0xA0A9A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0A9A0", Offset = "0xA0A9A0")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0A9F4", Offset = "0xA0A9F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0A9F4", Offset = "0xA0A9F4")]
		public float actionMassMlp;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AA48", Offset = "0xA0AA48")]
		public Vector3 COMOffset;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float defaultColliderRadius;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float defaultMass;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float defaultAdditionalPinWeight;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1382F4C", Offset = "0x1382F4C", VA = "0x1382F4C")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1382F94", Offset = "0x1382F94", VA = "0x1382F94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D728", Offset = "0xA0D728")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x138301C", Offset = "0x138301C", VA = "0x138301C", Slot = "7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1383084", Offset = "0x1383084", VA = "0x1383084", Slot = "4")]
		protected override void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x138312C", Offset = "0x138312C", VA = "0x138312C", Slot = "5")]
		protected override void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1383190", Offset = "0x1383190", VA = "0x1383190")]
		public PuppetMasterPropMelee()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0AA80", Offset = "0xA0AA80")]
		public float masterScale;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0AA9C", Offset = "0xA0AA9C")]
		public float muscleScale;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1384690", Offset = "0x1384690", VA = "0x1384690")]
		private void Start()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x13846D0", Offset = "0x13846D0", VA = "0x13846D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x13849E4", Offset = "0x13849E4", VA = "0x13849E4")]
		public PuppetScaling()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1387130", Offset = "0x1387130", VA = "0x1387130")]
		private void Update()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1387390", Offset = "0x1387390", VA = "0x1387390")]
		public RaycastShooter()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AAB8", Offset = "0xA0AAB8")]
		public Transform pool;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AAF0", Offset = "0xA0AAF0")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AB28", Offset = "0xA0AB28")]
		public string idleAnimation;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x170000C5")]
		private bool isPooled
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x13873B0", Offset = "0x13873B0", VA = "0x13873B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1387444", Offset = "0x1387444", VA = "0x1387444")]
		private void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x13874AC", Offset = "0x13874AC", VA = "0x13874AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x13875E0", Offset = "0x13875E0", VA = "0x13875E0")]
		private void Pool()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1387604", Offset = "0x1387604", VA = "0x1387604")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1387734", Offset = "0x1387734", VA = "0x1387734")]
		public Respawning()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1387B5C", Offset = "0x1387B5C", VA = "0x1387B5C")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1387BF4", Offset = "0x1387BF4", VA = "0x1387BF4")]
		public RotateShoulderToTarget()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class SkeletonDisconnector : MonoBehaviour
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuscleDisconnectMode disconnectMuscleMode;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PropMuscle propMuscle;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PuppetMasterProp prop;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x13889D0", Offset = "0x13889D0", VA = "0x13889D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1388DA4", Offset = "0x1388DA4", VA = "0x1388DA4")]
		public SkeletonDisconnector()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1388DB4", Offset = "0x1388DB4", VA = "0x1388DB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1389100", Offset = "0x1389100", VA = "0x1389100")]
		public SkeletonShooter()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x170000C6")]
		private Transform moveTarget
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x138C20C", Offset = "0x138C20C", VA = "0x138C20C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x138C260", Offset = "0x138C260", VA = "0x138C260", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x138C410", Offset = "0x138C410", VA = "0x138C410")]
		private bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x138C52C", Offset = "0x138C52C", VA = "0x138C52C")]
		public UserControlAIMelee()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x138C548", Offset = "0x138C548", VA = "0x138C548", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x138C818", Offset = "0x138C818", VA = "0x138C818")]
		public UserControlMelee()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000C7")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x15A62E8", Offset = "0x15A62E8", VA = "0x15A62E8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x15A62C4", Offset = "0x15A62C4", VA = "0x15A62C4", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x15A62F0", Offset = "0x15A62F0", VA = "0x15A62F0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x15A6354", Offset = "0x15A6354", VA = "0x15A6354", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x15A64EC", Offset = "0x15A64EC", VA = "0x15A64EC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x15A6710", Offset = "0x15A6710", VA = "0x15A6710", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x15A64FC", Offset = "0x15A64FC", VA = "0x15A64FC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x15A6720", Offset = "0x15A6720", VA = "0x15A6720")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x15A6D28", Offset = "0x15A6D28", VA = "0x15A6D28", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x15A6D8C", Offset = "0x15A6D8C", VA = "0x15A6D8C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x15A6E28", Offset = "0x15A6E28", VA = "0x15A6E28")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x15A6F40", Offset = "0x15A6F40", VA = "0x15A6F40")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0AB90", Offset = "0xA0AB90")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40005E8")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40005E9")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000C8")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x15A7000", Offset = "0x15A7000", VA = "0x15A7000", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x15A6F58", Offset = "0x15A6F58", VA = "0x15A6F58", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x15A6FE4", Offset = "0x15A6FE4", VA = "0x15A6FE4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x15A68B0", Offset = "0x15A68B0", VA = "0x15A68B0", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x15A70F8", Offset = "0x15A70F8", VA = "0x15A70F8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x15A6D04", Offset = "0x15A6D04", VA = "0x15A6D04")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0ABD4", Offset = "0xA0ABD4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0ABD4", Offset = "0xA0ABD4")]
		public Transform gravityTarget;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AC34", Offset = "0xA0AC34")]
		public float gravityMultiplier;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40005F7")]
		protected const float half = 0.5f;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60007AB")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x15A72D4", Offset = "0x15A72D4", VA = "0x15A72D4")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x15A7404", Offset = "0x15A7404", VA = "0x15A7404", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x15A75EC", Offset = "0x15A75EC", VA = "0x15A75EC", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x15A779C", Offset = "0x15A779C", VA = "0x15A779C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x15A7800", Offset = "0x15A7800", VA = "0x15A7800")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x15A7920", Offset = "0x15A7920", VA = "0x15A7920")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x15A7A44", Offset = "0x15A7A44", VA = "0x15A7A44")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x15A7A68", Offset = "0x15A7A68", VA = "0x15A7A68")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x15A7A8C", Offset = "0x15A7A8C", VA = "0x15A7A8C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x15A7AEC", Offset = "0x15A7AEC", VA = "0x15A7AEC")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public enum MoveMode
		{
			[Token(Token = "0x4000636")]
			Directional,
			[Token(Token = "0x4000637")]
			Strafe
		}

		[Token(Token = "0x200011D")]
		public struct AnimState
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF4DC", Offset = "0x9FF4DC")]
		private sealed class <JumpSmooth>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000CB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0x138F984", Offset = "0x138F984", VA = "0x138F984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x138F9CC", Offset = "0x138F9CC", VA = "0x138F9CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x138F854", Offset = "0x138F854", VA = "0x138F854")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x138F880", Offset = "0x138F880", VA = "0x138F880", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x138F884", Offset = "0x138F884", VA = "0x138F884", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x138F98C", Offset = "0x138F98C", VA = "0x138F98C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0AC6C", Offset = "0xA0AC6C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0ACA4", Offset = "0xA0ACA4")]
		public MoveMode moveMode;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0ACDC", Offset = "0xA0ACDC")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0AD14", Offset = "0xA0AD14")]
		public bool smoothJump;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0AD4C", Offset = "0xA0AD4C")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0AD84", Offset = "0xA0AD84")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0ADBC", Offset = "0xA0ADBC")]
		private bool <fullRootMotion>k__BackingField;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0ADCC", Offset = "0xA0ADCC")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000C9")]
		public bool fullRootMotion
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x15A89CC", Offset = "0x15A89CC", VA = "0x15A89CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D7D8", Offset = "0xA0D7D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x15A89D4", Offset = "0x15A89D4", VA = "0x15A89D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D7E8", Offset = "0xA0D7E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public bool onGround
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x15A89E0", Offset = "0x15A89E0", VA = "0x15A89E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D7F8", Offset = "0xA0D7F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x15A89E8", Offset = "0x15A89E8", VA = "0x15A89E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D808", Offset = "0xA0D808")]
			private set
			{
			}
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x15A8000", Offset = "0x15A8000", VA = "0x15A8000", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x15A89F4", Offset = "0x15A89F4", VA = "0x15A89F4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x15A81B8", Offset = "0x15A81B8", VA = "0x15A81B8", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x15A8A84", Offset = "0x15A8A84", VA = "0x15A8A84")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x15A7F50", Offset = "0x15A7F50", VA = "0x15A7F50", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x15A98A0", Offset = "0x15A98A0", VA = "0x15A98A0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x15A8F98", Offset = "0x15A8F98", VA = "0x15A8F98")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x15A997C", Offset = "0x15A997C", VA = "0x15A997C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x15A9E24", Offset = "0x15A9E24", VA = "0x15A9E24")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x15A96D0", Offset = "0x15A96D0", VA = "0x15A96D0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x15A8438", Offset = "0x15A8438", VA = "0x15A8438", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x15A9ECC", Offset = "0x15A9ECC", VA = "0x15A9ECC")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x15A879C", Offset = "0x15A879C", VA = "0x15A879C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x15A9FBC", Offset = "0x15A9FBC", VA = "0x15A9FBC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D818", Offset = "0xA0D818")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x15A931C", Offset = "0x15A931C", VA = "0x15A931C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x15A88FC", Offset = "0x15A88FC", VA = "0x15A88FC")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		public enum RotationMode
		{
			[Token(Token = "0x4000653")]
			Smooth,
			[Token(Token = "0x4000654")]
			Linear
		}

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0ADDC", Offset = "0xA0ADDC")]
		public CameraController cameraController;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AE14", Offset = "0xA0AE14")]
		public float accelerationTime;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AE4C", Offset = "0xA0AE4C")]
		public float turnTime;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AE84", Offset = "0xA0AE84")]
		public bool walkByDefault;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AEBC", Offset = "0xA0AEBC")]
		public RotationMode rotationMode;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AEF4", Offset = "0xA0AEF4")]
		public float moveSpeed;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0AF2C", Offset = "0xA0AF2C")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000CD")]
		public bool isGrounded
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1387EC0", Offset = "0x1387EC0", VA = "0x1387EC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D8C8", Offset = "0xA0D8C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1387EC8", Offset = "0x1387EC8", VA = "0x1387EC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D8D8", Offset = "0xA0D8D8")]
			private set
			{
			}
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1387ED4", Offset = "0x1387ED4", VA = "0x1387ED4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1387F78", Offset = "0x1387F78", VA = "0x1387F78")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1388438", Offset = "0x1388438", VA = "0x1388438")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1387FCC", Offset = "0x1387FCC", VA = "0x1387FCC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x138824C", Offset = "0x138824C", VA = "0x138824C")]
		private void Move()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1388474", Offset = "0x1388474", VA = "0x1388474")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1388510", Offset = "0x1388510", VA = "0x1388510")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1388594", Offset = "0x1388594", VA = "0x1388594")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x138BF70", Offset = "0x138BF70", VA = "0x138BF70", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x138BFF4", Offset = "0x138BFF4", VA = "0x138BFF4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x138C1B8", Offset = "0x138C1B8", VA = "0x138C1B8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x138C1E0", Offset = "0x138C1E0", VA = "0x138C1E0")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000123")]
		public struct State
		{
			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x138BFB4", Offset = "0x138BFB4", VA = "0x138BFB4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x138C57C", Offset = "0x138C57C", VA = "0x138C57C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x138C1FC", Offset = "0x138C1FC", VA = "0x138C1FC")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1AB7E74", Offset = "0x1AB7E74", VA = "0x1AB7E74")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1AB7EB0", Offset = "0x1AB7EB0", VA = "0x1AB7EB0")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1389110", Offset = "0x1389110", VA = "0x1389110")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1389144", Offset = "0x1389144", VA = "0x1389144")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x13891F4", Offset = "0x13891F4", VA = "0x13891F4")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000126")]
	public class Navigator
	{
		[Token(Token = "0x2000127")]
		public enum State
		{
			[Token(Token = "0x4000676")]
			Idle,
			[Token(Token = "0x4000677")]
			Seeking,
			[Token(Token = "0x4000678")]
			OnPath
		}

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AF3C", Offset = "0xA0AF3C")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AF74", Offset = "0xA0AF74")]
		public float cornerRadius;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AFAC", Offset = "0xA0AFAC")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AFE4", Offset = "0xA0AFE4")]
		public float maxSampleDistance;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B01C", Offset = "0xA0B01C")]
		public float nextPathInterval;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0B054", Offset = "0xA0B054")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0B064", Offset = "0xA0B064")]
		private State <state>k__BackingField;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000CE")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1575B68", Offset = "0x1575B68", VA = "0x1575B68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D8E8", Offset = "0xA0D8E8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1575B74", Offset = "0x1575B74", VA = "0x1575B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D8F8", Offset = "0xA0D8F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public State state
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1575B80", Offset = "0x1575B80", VA = "0x1575B80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D908", Offset = "0xA0D908")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1575B88", Offset = "0x1575B88", VA = "0x1575B88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D918", Offset = "0xA0D918")]
			private set
			{
			}
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1575B90", Offset = "0x1575B90", VA = "0x1575B90")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1575C64", Offset = "0x1575C64", VA = "0x1575C64")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1576064", Offset = "0x1576064", VA = "0x1576064")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x15760E0", Offset = "0x15760E0", VA = "0x15760E0")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1576020", Offset = "0x1576020", VA = "0x1576020")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1576050", Offset = "0x1576050", VA = "0x1576050")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x157622C", Offset = "0x157622C", VA = "0x157622C")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x15763DC", Offset = "0x15763DC", VA = "0x15763DC")]
		public Navigator()
		{
		}
	}
}
namespace MonsterLove.StateMachine
{
	[Token(Token = "0x2000128")]
	public class StateDriverRunner
	{
		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateEvent FixedUpdate;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StateEvent Update;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StateEvent LateUpdate;

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x138985C", Offset = "0x138985C", VA = "0x138985C")]
		public StateDriverRunner()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class StateDriverUnity
	{
		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateEvent Awake;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StateEvent LateUpdate;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StateEvent<int> OnAnimatorIK;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StateEvent OnAnimatorMove;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public StateEvent<bool> OnApplicationFocus;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public StateEvent OnApplicationPause;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public StateEvent OnApplicationQuit;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public StateEvent<float[], int> OnAudioFilterRead;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public StateEvent OnBecameInvisible;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public StateEvent OnBecameVisible;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public StateEvent<Collider> OnCollisionEnter;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public StateEvent<Collision2D> OnCollisionEnter2D;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public StateEvent<Collider> OnCollisionExit;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public StateEvent<Collider2D> OnCollisionExit2D;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public StateEvent<Collision> OnCollisionStay;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public StateEvent<Collision2D> OnCollisionStay2D;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public StateEvent OnConnectedToServer;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public StateEvent<ControllerColliderHit> OnControllerColliderHit;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public StateEvent OnDestroy;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public StateEvent OnDisable;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public StateEvent OnDrawGizmos;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public StateEvent OnDrawGizmosSelected;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public StateEvent OnEnable;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public StateEvent OnGUI;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public StateEvent<float> OnJointBreak;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public StateEvent<Joint2D> OnJointBreak2D;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public StateEvent OnMouseDown;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public StateEvent OnMouseDrag;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public StateEvent OnMouseEnter;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public StateEvent OnMouseExit;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public StateEvent OnMouseOver;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public StateEvent OnMouseUp;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public StateEvent OnMouseUpAsButton;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public StateEvent<GameObject> OnParticleCollision;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public StateEvent OnParticleSystemStopped;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public StateEvent OnParticleTrigger;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public StateEvent OnPostRender;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public StateEvent OnPreCull;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public StateEvent<RenderTexture, RenderTexture> OnRenderImage;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public StateEvent OnRenderObject;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public StateEvent OnTransformChildrenChanged;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public StateEvent OnTransformParentChanged;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public StateEvent<Collider> OnTriggerEnter;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public StateEvent<Collider2D> OnTriggerEnter2D;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public StateEvent<Collider> OnTriggerExit;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public StateEvent<Collider2D> OnTriggerExit2D;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public StateEvent<Collider> OnTriggerStay;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public StateEvent<Collider2D> OnTriggerStay2D;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public StateEvent OnValidate;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public StateEvent OnWillRenderOjbect;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public StateEvent Reset;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public StateEvent Start;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public StateEvent Update;

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1389864", Offset = "0x1389864", VA = "0x1389864")]
		public StateDriverUnity()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class StateEvent
	{
		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Func<int> getStateInt;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Func<bool> isInvokeAllowed;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action[] routingTable;

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x138986C", Offset = "0x138986C", VA = "0x138986C")]
		public StateEvent(Func<bool> isInvokeAllowed, Func<int> stateProvider, int capacity)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1389910", Offset = "0x1389910", VA = "0x1389910")]
		internal void AddListener(int stateInt, Action listener)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x138998C", Offset = "0x138998C", VA = "0x138998C")]
		public void Invoke()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class StateEvent<T>
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<int> getStateInt;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<bool> isInvokeAllowed;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T>[] routingTable;

		[Token(Token = "0x60007F7")]
		public StateEvent(Func<bool> isInvokeAllowed, Func<int> stateProvider, int capacity)
		{
		}

		[Token(Token = "0x60007F8")]
		internal void AddListener(int stateInt, Action<T> listener)
		{
		}

		[Token(Token = "0x60007F9")]
		public void Invoke(T param)
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class StateEvent<T1, T2>
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<int> getStateInt;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<bool> isInvokeAllowed;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T1, T2>[] routingTable;

		[Token(Token = "0x60007FA")]
		public StateEvent(Func<bool> isInvokeAllowed, Func<int> stateProvider, int capacity)
		{
		}

		[Token(Token = "0x60007FB")]
		internal void AddListener(int stateInt, Action<T1, T2> listener)
		{
		}

		[Token(Token = "0x60007FC")]
		public void Invoke(T1 param1, T2 param2)
		{
		}
	}
	[Token(Token = "0x200012D")]
	public enum StateTransition
	{
		[Token(Token = "0x40006BB")]
		Safe,
		[Token(Token = "0x40006BC")]
		Overwrite
	}
	[Token(Token = "0x200012E")]
	public interface IStateMachine<TDriver>
	{
		[Token(Token = "0x170000D0")]
		MonoBehaviour Component
		{
			[Token(Token = "0x60007FD")]
			get;
		}

		[Token(Token = "0x170000D1")]
		TDriver Driver
		{
			[Token(Token = "0x60007FE")]
			get;
		}

		[Token(Token = "0x170000D2")]
		bool IsInTransition
		{
			[Token(Token = "0x60007FF")]
			get;
		}
	}
	[Token(Token = "0x200012F")]
	public class StateMachine<TState> : StateMachine<TState, StateDriverRunner> where TState : struct, IConvertible, IComparable
	{
		[Token(Token = "0x6000800")]
		public StateMachine(MonoBehaviour component)
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class StateMachine<TState, TDriver> : IStateMachine<TDriver> where TState : struct, IConvertible, IComparable where TDriver : class, new()
	{
		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF4EC", Offset = "0x9FF4EC")]
		private sealed class <ChangeToNewStateRoutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StateMachine<TState, TDriver> <>4__this;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StateMapping<TState, TDriver> newState;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StateTransition transition;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000822")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000824")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600081F")]
			[DebuggerHidden]
			public <ChangeToNewStateRoutine>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000820")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000821")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000823")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF4FC", Offset = "0x9FF4FC")]
		private sealed class <WaitForPreviousTransition>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StateMachine<TState, TDriver> <>4__this;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StateMapping<TState, TDriver> nextState;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000828")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600082A")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000825")]
			[DebuggerHidden]
			public <WaitForPreviousTransition>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x6000826")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000827")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000829")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool reenter;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MonoBehaviour component;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private StateMapping<TState, TDriver> lastState;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private StateMapping<TState, TDriver> currentState;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private StateMapping<TState, TDriver> destinationState;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private StateMapping<TState, TDriver> queuedState;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TDriver rootDriver;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<object, StateMapping<TState, TDriver>> stateLookup;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<TState, int> enumConverter;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isInTransition;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator currentTransition;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator exitRoutine;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator enterRoutine;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator queuedChange;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BindingFlags bindingFlags;

		[Token(Token = "0x170000D3")]
		public bool LastStateExists
		{
			[Token(Token = "0x6000811")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D4")]
		public TState LastState
		{
			[Token(Token = "0x6000812")]
			get
			{
				return (TState)null;
			}
		}

		[Token(Token = "0x170000D5")]
		public TState NextState
		{
			[Token(Token = "0x6000813")]
			get
			{
				return (TState)null;
			}
		}

		[Token(Token = "0x170000D6")]
		public TState State
		{
			[Token(Token = "0x6000814")]
			get
			{
				return (TState)null;
			}
		}

		[Token(Token = "0x170000D7")]
		public bool IsInTransition
		{
			[Token(Token = "0x6000815")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D8")]
		public TDriver Driver
		{
			[Token(Token = "0x6000816")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public MonoBehaviour Component
		{
			[Token(Token = "0x6000817")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<TState> Changed
		{
			[Token(Token = "0x6000801")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D928", Offset = "0xA0D928")]
			add
			{
			}
			[Token(Token = "0x6000802")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0D938", Offset = "0xA0D938")]
			remove
			{
			}
		}

		[Token(Token = "0x6000803")]
		public StateMachine(MonoBehaviour component)
		{
		}

		[Token(Token = "0x6000804")]
		private static List<FieldInfo> GetFilteredFields(Type type, string searchTerm)
		{
			return null;
		}

		[Token(Token = "0x6000805")]
		private static Dictionary<string, FieldInfo> CreateFieldsLookup(List<FieldInfo> fields)
		{
			return null;
		}

		[Token(Token = "0x6000806")]
		private static Dictionary<object, StateMapping<TState, TDriver>> CreateStateLookup(StateMachine<TState, TDriver> fsm, Array values)
		{
			return null;
		}

		[Token(Token = "0x6000807")]
		private static TDriver CreateDriver(Func<bool> isInvokeAllowedCallback, Func<int> getStateIntCallback, int capacity, List<FieldInfo> fieldInfos)
		{
			return null;
		}

		[Token(Token = "0x6000808")]
		private static bool ParseName(MethodInfo methodInfo, out TState state, out string eventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000809")]
		private static void BindEvents(TDriver driver, Component component, TState state, int stateInt, MethodInfo stateTargetDef, FieldInfo driverEvtDef)
		{
		}

		[Token(Token = "0x600080A")]
		private static void BindEventsInternal(StateMapping<TState, TDriver> targetState, Component component, MethodInfo method, string evtName)
		{
		}

		[Token(Token = "0x600080B")]
		private static V CreateDelegate<V>(MethodInfo method, object target) where V : class
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		private static Type GetActionType(Type[] genericArgs)
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		public void ChangeState(TState newState)
		{
		}

		[Token(Token = "0x600080E")]
		public void ChangeState(TState newState, StateTransition transition)
		{
		}

		[Token(Token = "0x600080F")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D948", Offset = "0xA0D948")]
		private IEnumerator ChangeToNewStateRoutine(StateMapping<TState, TDriver> newState, StateTransition transition)
		{
			return null;
		}

		[Token(Token = "0x6000810")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0D9A8", Offset = "0xA0D9A8")]
		private IEnumerator WaitForPreviousTransition(StateMapping<TState, TDriver> nextState)
		{
			return null;
		}

		[Token(Token = "0x6000818")]
		private TState GetState()
		{
			return (TState)null;
		}

		[Token(Token = "0x6000819")]
		private int GetStateInt()
		{
			return default(int);
		}

		[Token(Token = "0x600081A")]
		private static int Identity(int x)
		{
			return default(int);
		}

		[Token(Token = "0x600081B")]
		private bool IsDispatchAllowed()
		{
			return default(bool);
		}

		[Token(Token = "0x600081C")]
		public static StateMachine<TState> Initialize(MonoBehaviour component)
		{
			return null;
		}

		[Token(Token = "0x600081D")]
		public static StateMachine<TState> Initialize(MonoBehaviour component, TState startState)
		{
			return null;
		}
	}
	[Token(Token = "0x2000133")]
	public class StateMachineRunner : MonoBehaviour
	{
		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF50C", Offset = "0x9FF50C")]
		private sealed class <DoNothingCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000836")]
				[Address(RVA = "0x1C5F1C0", Offset = "0x1C5F1C0", VA = "0x1C5F1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000838")]
				[Address(RVA = "0x1C5F208", Offset = "0x1C5F208", VA = "0x1C5F208", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x1C5F178", Offset = "0x1C5F178", VA = "0x1C5F178")]
			[DebuggerHidden]
			public <DoNothingCoroutine>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0x1C5F1A4", Offset = "0x1C5F1A4", VA = "0x1C5F1A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x1C5F1A8", Offset = "0x1C5F1A8", VA = "0x1C5F1A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x1C5F1C8", Offset = "0x1C5F1C8", VA = "0x1C5F1C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IStateMachine<StateDriverRunner>> stateMachineList;

		[Token(Token = "0x600082B")]
		public StateMachine<TState> Initialize<TState>(MonoBehaviour component) where TState : struct, IConvertible, IComparable
		{
			return null;
		}

		[Token(Token = "0x600082C")]
		public StateMachine<TState> Initialize<TState>(MonoBehaviour component, TState startState) where TState : struct, IConvertible, IComparable
		{
			return null;
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1389A48", Offset = "0x1389A48", VA = "0x1389A48")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1389C40", Offset = "0x1389C40", VA = "0x1389C40")]
		private void Update()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x1389E38", Offset = "0x1389E38", VA = "0x1389E38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x138A030", Offset = "0x138A030", VA = "0x138A030")]
		public static void DoNothing()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x138A034", Offset = "0x138A034", VA = "0x138A034")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0DAA8", Offset = "0xA0DAA8")]
		public static IEnumerator DoNothingCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x138A090", Offset = "0x138A090", VA = "0x138A090")]
		public StateMachineRunner()
		{
		}
	}
	[Token(Token = "0x2000135")]
	internal class StateMapping<TState, TDriver> where TState : struct, IConvertible, IComparable where TDriver : class, new()
	{
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TState state;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool hasEnterRoutine;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action EnterCall;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<IEnumerator> EnterRoutine;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool hasExitRoutine;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action ExitCall;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<IEnumerator> ExitRoutine;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action Finally;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<TState> stateProviderCallback;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private StateMachine<TState, TDriver> fsm;

		[Token(Token = "0x6000839")]
		public StateMapping(StateMachine<TState, TDriver> fsm, TState state, Func<TState> stateProvider)
		{
		}
	}
}
namespace ES3Types
{
	[Token(Token = "0x2000136")]
	[Preserve]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1C12188", Offset = "0x1C12188", VA = "0x1C12188")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x1C12254", Offset = "0x1C12254", VA = "0x1C12254", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600083C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000137")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x1C1225C", Offset = "0x1C1225C", VA = "0x1C1225C")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1C12328", Offset = "0x1C12328", VA = "0x1C12328", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000840")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000841")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x15B17B0", Offset = "0x15B17B0", VA = "0x15B17B0")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x15B18C0", Offset = "0x15B18C0", VA = "0x15B18C0", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x6000845")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x15B1ADC", Offset = "0x15B1ADC", VA = "0x15B1ADC", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000847")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x15B1D54", Offset = "0x15B1D54", VA = "0x15B1D54", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x15B2024", Offset = "0x15B2024", VA = "0x15B2024")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x15B2028", Offset = "0x15B2028", VA = "0x15B2028", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600084B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x15B22DC", Offset = "0x15B22DC", VA = "0x15B22DC", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x15B2630", Offset = "0x15B2630", VA = "0x15B2630", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200013A")]
	[Preserve]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x15B29A0", Offset = "0x15B29A0", VA = "0x15B29A0")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x15B29A4", Offset = "0x15B29A4", VA = "0x15B29A4")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x15B2A24", Offset = "0x15B2A24", VA = "0x15B2A24", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x15B2BA8", Offset = "0x15B2BA8", VA = "0x15B2BA8", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000853")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x15B2DDC", Offset = "0x15B2DDC", VA = "0x15B2DDC", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200013B")]
	[Preserve]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type elementType;

		[Token(Token = "0x6000856")]
		public abstract object Read(ES3Reader reader);

		[Token(Token = "0x6000857")]
		public abstract void ReadInto(ES3Reader reader, object obj);

		[Token(Token = "0x6000858")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x15B17B4", Offset = "0x15B17B4", VA = "0x15B17B4")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x15B29E4", Offset = "0x15B29E4", VA = "0x15B29E4")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x15B7A70", Offset = "0x15B7A70", VA = "0x15B7A70", Slot = "4")]
		[Preserve]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600085C")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x600085D")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x15B7A80", Offset = "0x15B7A80", VA = "0x15B7A80", Slot = "12")]
		[Preserve]
		protected virtual void ReadICollectionInto(ES3Reader reader, ICollection collection, ES3Type elementType)
		{
		}
	}
	[Token(Token = "0x200013C")]
	[Preserve]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type keyType;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ES3Type valueType;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x15B8824", Offset = "0x15B8824", VA = "0x15B8824")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x15B8968", Offset = "0x15B8968", VA = "0x15B8968")]
		public ES3DictionaryType(Type type, ES3Type keyType, ES3Type valueType)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x15B89D4", Offset = "0x15B89D4", VA = "0x15B89D4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x15B89F8", Offset = "0x15B89F8", VA = "0x15B89F8")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000863")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x15B8E08", Offset = "0x15B8E08", VA = "0x15B8E08")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x15B9054", Offset = "0x15B9054", VA = "0x15B9054")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200013D")]
	[Preserve]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x185479C", Offset = "0x185479C", VA = "0x185479C")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x18547A4", Offset = "0x18547A4", VA = "0x18547A4", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000869")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x1854D84", Offset = "0x1854D84", VA = "0x1854D84", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x1855498", Offset = "0x1855498", VA = "0x1855498", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200013E")]
	[Preserve]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x185A324", Offset = "0x185A324", VA = "0x185A324")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x185A32C", Offset = "0x185A32C", VA = "0x185A32C")]
		public ES3ListType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x185A334", Offset = "0x185A334", VA = "0x185A334", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000870")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x185A718", Offset = "0x185A718", VA = "0x185A718", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x185A900", Offset = "0x185A900", VA = "0x185A900", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200013F")]
	[Preserve]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x185C878", Offset = "0x185C878", VA = "0x185C878")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x185C880", Offset = "0x185C880", VA = "0x185C880", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000876")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x185CC50", Offset = "0x185CC50", VA = "0x185CC50", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x185CF48", Offset = "0x185CF48", VA = "0x185CF48", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000140")]
	[Preserve]
	public class ES3StackType : ES3CollectionType
	{
		[Serializable]
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF59C", Offset = "0x9FF59C")]
		private sealed class <>c
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MethodInfo, bool> <>9__4_0;

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x1C5C060", Offset = "0x1C5C060", VA = "0x1C5C060")]
			public <>c()
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x1C5C068", Offset = "0x1C5C068", VA = "0x1C5C068")]
			internal bool <Read>b__4_0(MethodInfo t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x18671C0", Offset = "0x18671C0", VA = "0x18671C0")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x18671C8", Offset = "0x18671C8", VA = "0x18671C8", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600087C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x1867598", Offset = "0x1867598", VA = "0x1867598", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x1867A00", Offset = "0x1867A00", VA = "0x1867A00", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000142")]
	[Preserve]
	public abstract class ES3ComponentType : ES3UnityObjectType
	{
		[Token(Token = "0x40006EC")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x15B7FB0", Offset = "0x15B7FB0", VA = "0x15B7FB0")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x6000884")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x6000885")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x15B7FB8", Offset = "0x15B7FB8", VA = "0x15B7FB8", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000887")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000888")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000889")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x15B8270", Offset = "0x15B8270", VA = "0x15B8270")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x15B832C", Offset = "0x15B832C", VA = "0x15B832C")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000143")]
	[Preserve]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x185AF78", Offset = "0x185AF78", VA = "0x185AF78")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x600088D")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x600088E")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x600088F")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x185B054", Offset = "0x185B054", VA = "0x185B054", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000891")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000892")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000144")]
	[Preserve]
	public abstract class ES3ScriptableObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1861088", Offset = "0x1861088", VA = "0x1861088")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000894")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000895")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1864D10", Offset = "0x1864D10", VA = "0x1864D10", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000897")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000898")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000899")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000145")]
	[Preserve]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FF5DC", Offset = "0x9FF5DC")]
	public abstract class ES3Type
	{
		[Token(Token = "0x40006ED")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isEnum;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isReflectedType;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUnsupported;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int priority;

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x185AF7C", Offset = "0x185AF7C", VA = "0x185AF7C")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x600089B")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x600089C")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x600089D")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x185B228", Offset = "0x185B228", VA = "0x185B228")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x600089F")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x186814C", Offset = "0x186814C", VA = "0x186814C")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x1860ED4", Offset = "0x1860ED4", VA = "0x1860ED4")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x18681A8", Offset = "0x18681A8", VA = "0x18681A8")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x1860EC4", Offset = "0x1860EC4", VA = "0x1860EC4")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x18610F4", Offset = "0x18610F4", VA = "0x18610F4")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9FF618", Offset = "0x9FF618")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x185C844", Offset = "0x185C844", VA = "0x185C844")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x2000147")]
	[Preserve]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x192E03C", Offset = "0x192E03C", VA = "0x192E03C")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60008A7")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x60008A8")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60008A9")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x19364D8", Offset = "0x19364D8", VA = "0x19364D8", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x19364EC", Offset = "0x19364EC", VA = "0x19364EC", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x60008AC")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60008AD")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x1936764", Offset = "0x1936764", VA = "0x1936764")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FF63C", Offset = "0x9FF63C")]
	[Preserve]
	public class ES3Type_Random : ES3ObjectType
	{
		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1C81768", Offset = "0x1C81768", VA = "0x1C81768")]
		public ES3Type_Random()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x1C81834", Offset = "0x1C81834", VA = "0x1C81834", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008B1")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60008B2")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000149")]
	public class ES3Type_RandomArray : ES3ArrayType
	{
		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1C8193C", Offset = "0x1C8193C", VA = "0x1C8193C")]
		public ES3Type_RandomArray()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[Preserve]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1C11E84", Offset = "0x1C11E84", VA = "0x1C11E84")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1C11F50", Offset = "0x1C11F50", VA = "0x1C11F50", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008B7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200014B")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1C1208C", Offset = "0x1C1208C", VA = "0x1C1208C")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[Preserve]
	public class ES3Type_ES3Ref : ES3Type
	{
		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1C124CC", Offset = "0x1C124CC", VA = "0x1C124CC")]
		public ES3Type_ES3Ref()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1C125A0", Offset = "0x1C125A0", VA = "0x1C125A0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008BC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200014D")]
	public class ES3Type_ES3RefArray : ES3ArrayType
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1C126B0", Offset = "0x1C126B0", VA = "0x1C126B0")]
		public ES3Type_ES3RefArray()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class ES3Type_ES3RefDictionary : ES3DictionaryType
	{
		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1C12824", Offset = "0x1C12824", VA = "0x1C12824")]
		public ES3Type_ES3RefDictionary()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[Preserve]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x1931DFC", Offset = "0x1931DFC", VA = "0x1931DFC")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1931ED0", Offset = "0x1931ED0", VA = "0x1931ED0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008C4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000150")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1931F68", Offset = "0x1931F68", VA = "0x1931F68")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[Preserve]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x19337F8", Offset = "0x19337F8", VA = "0x19337F8")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x19338CC", Offset = "0x19338CC", VA = "0x19338CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008C9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000152")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1933964", Offset = "0x1933964", VA = "0x1933964")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x2000153")]
	[Preserve]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1933A60", Offset = "0x1933A60", VA = "0x1933A60")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1933B34", Offset = "0x1933B34", VA = "0x1933B34", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008CE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000154")]
	[Preserve]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x1933BCC", Offset = "0x1933BCC", VA = "0x1933BCC")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x1933CA0", Offset = "0x1933CA0", VA = "0x1933CA0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008D2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000155")]
	[Preserve]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x1933D38", Offset = "0x1933D38", VA = "0x1933D38")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x1933E0C", Offset = "0x1933E0C", VA = "0x1933E0C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008D6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000156")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1933EA4", Offset = "0x1933EA4", VA = "0x1933EA4")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[Preserve]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1933FA0", Offset = "0x1933FA0", VA = "0x1933FA0")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x1934074", Offset = "0x1934074", VA = "0x1934074", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008DB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000158")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x193410C", Offset = "0x193410C", VA = "0x193410C")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x2000159")]
	[Preserve]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1934208", Offset = "0x1934208", VA = "0x1934208")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x19342DC", Offset = "0x19342DC", VA = "0x19342DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008E0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200015A")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1934374", Offset = "0x1934374", VA = "0x1934374")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x200015B")]
	[Preserve]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type underlyingType;

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1934470", Offset = "0x1934470", VA = "0x1934470")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x193454C", Offset = "0x193454C", VA = "0x193454C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008E5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200015C")]
	[Preserve]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1935038", Offset = "0x1935038", VA = "0x1935038")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x193510C", Offset = "0x193510C", VA = "0x193510C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008E9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200015D")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x19351A4", Offset = "0x19351A4", VA = "0x19351A4")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[Preserve]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x19352A0", Offset = "0x19352A0", VA = "0x19352A0")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1935374", Offset = "0x1935374", VA = "0x1935374", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008EE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200015F")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x193540C", Offset = "0x193540C", VA = "0x193540C")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[Preserve]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x1C16BE4", Offset = "0x1C16BE4", VA = "0x1C16BE4")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x1C16CB8", Offset = "0x1C16CB8", VA = "0x1C16CB8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008F3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000161")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1C16D5C", Offset = "0x1C16D5C", VA = "0x1C16D5C")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000162")]
	[Preserve]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x1935508", Offset = "0x1935508", VA = "0x1935508")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x19355DC", Offset = "0x19355DC", VA = "0x19355DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008F8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000163")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x1935674", Offset = "0x1935674", VA = "0x1935674")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[Preserve]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x1935770", Offset = "0x1935770", VA = "0x1935770")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x1935844", Offset = "0x1935844", VA = "0x1935844", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008FD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000165")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x19358DC", Offset = "0x19358DC", VA = "0x19358DC")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[Preserve]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x19359D8", Offset = "0x19359D8", VA = "0x19359D8")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x1935AAC", Offset = "0x1935AAC", VA = "0x1935AAC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000902")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000167")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1935B44", Offset = "0x1935B44", VA = "0x1935B44")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x2000168")]
	[Preserve]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1935C40", Offset = "0x1935C40", VA = "0x1935C40")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1935D14", Offset = "0x1935D14", VA = "0x1935D14", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000907")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000169")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x192EF60", Offset = "0x192EF60", VA = "0x192EF60")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[Preserve]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x1935DA0", Offset = "0x1935DA0", VA = "0x1935DA0")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1935E74", Offset = "0x1935E74", VA = "0x1935E74", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600090C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200016B")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x1935F0C", Offset = "0x1935F0C", VA = "0x1935F0C")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x200016C")]
	[Preserve]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x1936008", Offset = "0x1936008", VA = "0x1936008")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x19360DC", Offset = "0x19360DC", VA = "0x19360DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000911")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200016D")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x1936174", Offset = "0x1936174", VA = "0x1936174")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x200016E")]
	[Preserve]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x1936270", Offset = "0x1936270", VA = "0x1936270")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1936344", Offset = "0x1936344", VA = "0x1936344", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000916")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200016F")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x19363DC", Offset = "0x19363DC", VA = "0x19363DC")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x2000170")]
	[Preserve]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x1860E8C", Offset = "0x1860E8C", VA = "0x1860E8C")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x1860ED0", Offset = "0x1860ED0", VA = "0x1860ED0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600091B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000171")]
	[Preserve]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x1861018", Offset = "0x1861018", VA = "0x1861018")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x186104C", Offset = "0x186104C", VA = "0x186104C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600091E")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000172")]
	[Preserve]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1861050", Offset = "0x1861050", VA = "0x1861050")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x1861090", Offset = "0x1861090", VA = "0x1861090", Slot = "14")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000922")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000173")]
	[Preserve]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1861094", Offset = "0x1861094", VA = "0x1861094")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x18610BC", Offset = "0x18610BC", VA = "0x18610BC")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x18612A0", Offset = "0x18612A0", VA = "0x18612A0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000926")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000174")]
	[Preserve]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x186168C", Offset = "0x186168C", VA = "0x186168C")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x18616C4", Offset = "0x18616C4", VA = "0x18616C4", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600092A")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000175")]
	[Preserve]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x18616C8", Offset = "0x18616C8", VA = "0x18616C8")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x18616FC", Offset = "0x18616FC", VA = "0x18616FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600092E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600092F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000176")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FF8A4", Offset = "0x9FF8A4")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x186BAAC", Offset = "0x186BAAC", VA = "0x186BAAC")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x186BB78", Offset = "0x186BB78", VA = "0x186BB78", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000932")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FF9C0", Offset = "0x9FF9C0")]
	[Preserve]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x186BE20", Offset = "0x186BE20", VA = "0x186BE20")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x186BEEC", Offset = "0x186BEEC", VA = "0x186BEEC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000936")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000178")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FFAF8", Offset = "0x9FFAF8")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x186C234", Offset = "0x186C234", VA = "0x186C234")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x186C300", Offset = "0x186C300", VA = "0x186C300", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600093A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FFF08", Offset = "0x9FFF08")]
	[Preserve]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1C10308", Offset = "0x1C10308", VA = "0x1C10308")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1C103D4", Offset = "0x1C103D4", VA = "0x1C103D4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600093E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200017A")]
	[Preserve]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x1C12DCC", Offset = "0x1C12DCC", VA = "0x1C12DCC")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x1C12E98", Offset = "0x1C12E98", VA = "0x1C12E98", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000942")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA0006C", Offset = "0xA0006C")]
	[Preserve]
	public class ES3Type_Image : ES3ComponentType
	{
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1C15D98", Offset = "0x1C15D98", VA = "0x1C15D98")]
		public ES3Type_Image()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x1C15E70", Offset = "0x1C15E70", VA = "0x1C15E70", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000946")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class ES3Type_ImageArray : ES3ArrayType
	{
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1C16728", Offset = "0x1C16728", VA = "0x1C16728")]
		public ES3Type_ImageArray()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA0032C", Offset = "0xA0032C")]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1C7D220", Offset = "0x1C7D220", VA = "0x1C7D220")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1C7D2EC", Offset = "0x1C7D2EC", VA = "0x1C7D2EC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600094B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1C7D610", Offset = "0x1C7D610", VA = "0x1C7D610")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA00480", Offset = "0xA00480")]
	[Preserve]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1C7D70C", Offset = "0x1C7D70C", VA = "0x1C7D70C")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1C7D7D8", Offset = "0x1C7D7D8", VA = "0x1C7D7D8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000950")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1C7D884", Offset = "0x1C7D884", VA = "0x1C7D884")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000181")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA00510", Offset = "0xA00510")]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1C7D980", Offset = "0x1C7D980", VA = "0x1C7D980")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x1C7DA4C", Offset = "0x1C7DA4C", VA = "0x1C7DA4C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000955")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x1C7E258", Offset = "0x1C7E258", VA = "0x1C7E258")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA00760", Offset = "0xA00760")]
	[Preserve]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1C7F8E4", Offset = "0x1C7F8E4", VA = "0x1C7F8E4")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1C7F9B0", Offset = "0x1C7F9B0", VA = "0x1C7F9B0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600095A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000184")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA00AC8", Offset = "0xA00AC8")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1C80C34", Offset = "0x1C80C34", VA = "0x1C80C34")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1C80D00", Offset = "0x1C80D00", VA = "0x1C80D00", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600095E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x1C81288", Offset = "0x1C81288", VA = "0x1C81288")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x2000186")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA00C38", Offset = "0xA00C38")]
	public class ES3Type_RawImage : ES3ComponentType
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x1C81A38", Offset = "0x1C81A38", VA = "0x1C81A38")]
		public ES3Type_RawImage()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x1C81B10", Offset = "0x1C81B10", VA = "0x1C81B10", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000963")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class ES3Type_RawImageArray : ES3ArrayType
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x1C8206C", Offset = "0x1C8206C", VA = "0x1C8206C")]
		public ES3Type_RawImageArray()
		{
		}
	}
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA00DE0", Offset = "0xA00DE0")]
	[Preserve]
	public class ES3Type_Rigidbody : ES3ComponentType
	{
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x1C833C0", Offset = "0x1C833C0", VA = "0x1C833C0")]
		public ES3Type_Rigidbody()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x1C83498", Offset = "0x1C83498", VA = "0x1C83498", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000968")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class ES3UserType_RigidbodyArray : ES3ArrayType
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1936978", Offset = "0x1936978", VA = "0x1936978")]
		public ES3UserType_RigidbodyArray()
		{
		}
	}
	[Token(Token = "0x200018A")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA010BC", Offset = "0xA010BC")]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x192DB0C", Offset = "0x192DB0C", VA = "0x192DB0C")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x192DBD8", Offset = "0x192DBD8", VA = "0x192DBD8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600096D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200018B")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA011D8", Offset = "0xA011D8")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x192F3E8", Offset = "0x192F3E8", VA = "0x192F3E8")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x192F4B4", Offset = "0x192F4B4", VA = "0x192F4B4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000971")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200018C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA014D0", Offset = "0xA014D0")]
	[Preserve]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int countRead;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ES3Type Instance;

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x19316D8", Offset = "0x19316D8", VA = "0x19316D8")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x19317A4", Offset = "0x19317A4", VA = "0x19317A4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000975")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200018D")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA015D0", Offset = "0xA015D0")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x186AB08", Offset = "0x186AB08", VA = "0x186AB08")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x186ABD0", Offset = "0x186ABD0", VA = "0x186ABD0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000979")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600097A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA01698", Offset = "0xA01698")]
	[Preserve]
	public class ES3Type_AudioClip : ES3UnityObjectType
	{
		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x186AD74", Offset = "0x186AD74", VA = "0x186AD74")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x186AE40", Offset = "0x186AE40", VA = "0x186AE40", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600097E")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600097F")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200018F")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x186B088", Offset = "0x186B088", VA = "0x186B088")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA01798", Offset = "0xA01798")]
	[Preserve]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x186B184", Offset = "0x186B184", VA = "0x186B184")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x186B24C", Offset = "0x186B24C", VA = "0x186B24C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000984")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000191")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x186B648", Offset = "0x186B648", VA = "0x186B648")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x2000192")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA018EC", Offset = "0xA018EC")]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x186B744", Offset = "0x186B744", VA = "0x186B744")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x186B80C", Offset = "0x186B80C", VA = "0x186B80C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000989")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000193")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x186B9B0", Offset = "0x186B9B0", VA = "0x186B9B0")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x2000194")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA01998", Offset = "0xA01998")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1C1085C", Offset = "0x1C1085C", VA = "0x1C1085C")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1C10928", Offset = "0x1C10928", VA = "0x1C10928", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600098E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600098F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000195")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA01C04", Offset = "0xA01C04")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1C11028", Offset = "0x1C11028", VA = "0x1C11028")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x1C110F4", Offset = "0x1C110F4", VA = "0x1C110F4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000993")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000196")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x1C11738", Offset = "0x1C11738", VA = "0x1C11738")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x2000197")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA01CE8", Offset = "0xA01CE8")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x1C11310", Offset = "0x1C11310", VA = "0x1C11310")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1C113DC", Offset = "0x1C113DC", VA = "0x1C113DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000998")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x1C115F4", Offset = "0x1C115F4", VA = "0x1C115F4")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000198")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x1C1163C", Offset = "0x1C1163C", VA = "0x1C1163C")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA01DCC", Offset = "0xA01DCC")]
	[Preserve]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x1C11834", Offset = "0x1C11834", VA = "0x1C11834")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x1C11900", Offset = "0x1C11900", VA = "0x1C11900", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600099E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600099F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200019A")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA01E94", Offset = "0xA01E94")]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x1C11BAC", Offset = "0x1C11BAC", VA = "0x1C11BAC")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1C11C78", Offset = "0x1C11C78", VA = "0x1C11C78", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009A3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009A4")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA01F40", Offset = "0xA01F40")]
	[Preserve]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x1C1299C", Offset = "0x1C1299C", VA = "0x1C1299C")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x1C12A68", Offset = "0x1C12A68", VA = "0x1C12A68", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009A8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200019C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02040", Offset = "0xA02040")]
	[Preserve]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x1C12EA0", Offset = "0x1C12EA0", VA = "0x1C12EA0")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x1C12F6C", Offset = "0x1C12F6C", VA = "0x1C12F6C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009AD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009AE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200019D")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA020EC", Offset = "0xA020EC")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x1C1314C", Offset = "0x1C1314C", VA = "0x1C1314C")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x1C13218", Offset = "0x1C13218", VA = "0x1C13218", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009B2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009B3")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200019E")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1C132F0", Offset = "0x1C132F0", VA = "0x1C132F0")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x200019F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA0217C", Offset = "0xA0217C")]
	[Preserve]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x1C133EC", Offset = "0x1C133EC", VA = "0x1C133EC")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x1C134B8", Offset = "0x1C134B8", VA = "0x1C134B8", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009B8")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60009B9")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A0")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x1C135E4", Offset = "0x1C135E4", VA = "0x1C135E4")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02228", Offset = "0xA02228")]
	[Preserve]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1C136E0", Offset = "0x1C136E0", VA = "0x1C136E0")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x1C137AC", Offset = "0x1C137AC", VA = "0x1C137AC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009BE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009BF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02398", Offset = "0xA02398")]
	[Preserve]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x20001A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA024D0", Offset = "0xA024D0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Predicate<Component> <>9__0;

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x1C5C094", Offset = "0x1C5C094", VA = "0x1C5C094")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x1C5C09C", Offset = "0x1C5C09C", VA = "0x1C5C09C")]
			internal bool <ReadComponents>b__0(Component x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000750")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x4000751")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool saveChildren;

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x1C13C9C", Offset = "0x1C13C9C", VA = "0x1C13C9C")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x1C13D68", Offset = "0x1C13D68", VA = "0x1C13D68", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x60009C3")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x1C14960", Offset = "0x1C14960", VA = "0x1C14960")]
		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1C14FEC", Offset = "0x1C14FEC", VA = "0x1C14FEC")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1C14644", Offset = "0x1C14644", VA = "0x1C14644")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x1C15080", Offset = "0x1C15080", VA = "0x1C15080", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009C9")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60009CA")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A4")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x1C15088", Offset = "0x1C15088", VA = "0x1C15088")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA024E0", Offset = "0xA024E0")]
	[Preserve]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x1C15184", Offset = "0x1C15184", VA = "0x1C15184")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1C15250", Offset = "0x1C15250", VA = "0x1C15250", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009D1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA025A8", Offset = "0xA025A8")]
	[Preserve]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x1C15400", Offset = "0x1C15400", VA = "0x1C15400")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x1C154CC", Offset = "0x1C154CC", VA = "0x1C154CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009D6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A7")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x1C1563C", Offset = "0x1C1563C", VA = "0x1C1563C")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02654", Offset = "0xA02654")]
	[Preserve]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x1C15738", Offset = "0x1C15738", VA = "0x1C15738")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x1C15804", Offset = "0x1C15804", VA = "0x1C15804", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009DB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A9")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x1C159C0", Offset = "0x1C159C0", VA = "0x1C159C0")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02700", Offset = "0xA02700")]
	public class ES3Type_Guid : ES3Type
	{
		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x1C15ABC", Offset = "0x1C15ABC", VA = "0x1C15ABC")]
		public ES3Type_Guid()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1C15B88", Offset = "0x1C15B88", VA = "0x1C15B88", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009E0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AB")]
	public class ES3Type_GuidArray : ES3ArrayType
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x1C15C9C", Offset = "0x1C15C9C", VA = "0x1C15C9C")]
		public ES3Type_GuidArray()
		{
		}
	}
	[Token(Token = "0x20001AC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02790", Offset = "0xA02790")]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x1C16824", Offset = "0x1C16824", VA = "0x1C16824")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x1C168F0", Offset = "0x1C168F0", VA = "0x1C168F0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009E5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001AD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02874", Offset = "0xA02874")]
	[Preserve]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1C16E58", Offset = "0x1C16E58", VA = "0x1C16E58")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1C16F24", Offset = "0x1C16F24", VA = "0x1C16F24", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009EA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AE")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1C17174", Offset = "0x1C17174", VA = "0x1C17174")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02958", Offset = "0xA02958")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1C17270", Offset = "0x1C17270", VA = "0x1C17270")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1C1733C", Offset = "0x1C1733C", VA = "0x1C1733C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009EF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02A20", Offset = "0xA02A20")]
	[Preserve]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1C17470", Offset = "0x1C17470", VA = "0x1C17470")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x1C1753C", Offset = "0x1C1753C", VA = "0x1C1753C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009F3")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001B1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02CFC", Offset = "0xA02CFC")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1C17E34", Offset = "0x1C17E34", VA = "0x1C17E34")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x1C17F00", Offset = "0x1C17F00", VA = "0x1C17F00", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009F7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001B2")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA02EC0", Offset = "0xA02EC0")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1C18524", Offset = "0x1C18524", VA = "0x1C18524")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x1C185F0", Offset = "0x1C185F0", VA = "0x1C185F0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009FC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001B3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA03084", Offset = "0xA03084")]
	[Preserve]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1C18BF4", Offset = "0x1C18BF4", VA = "0x1C18BF4")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1C18CC0", Offset = "0x1C18CC0", VA = "0x1C18CC0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A01")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001B4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA03504", Offset = "0xA03504")]
	[Preserve]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x1C19CA8", Offset = "0x1C19CA8", VA = "0x1C19CA8")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x1C19D74", Offset = "0x1C19D74", VA = "0x1C19D74", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A06")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1C7C5A8", Offset = "0x1C7C5A8", VA = "0x1C7C5A8")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA03604", Offset = "0xA03604")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1C7C6A4", Offset = "0x1C7C6A4", VA = "0x1C7C6A4")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x1C7C770", Offset = "0x1C7C770", VA = "0x1C7C770", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A0C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B7")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x1C7C9E4", Offset = "0x1C7C9E4", VA = "0x1C7C9E4")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA036E8", Offset = "0xA036E8")]
	[Preserve]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x1C7CAE0", Offset = "0x1C7CAE0", VA = "0x1C7CAE0")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1C7CBAC", Offset = "0x1C7CBAC", VA = "0x1C7CBAC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A11")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A12")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001B9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA038E4", Offset = "0xA038E4")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x1C7E354", Offset = "0x1C7E354", VA = "0x1C7E354")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x1C7E420", Offset = "0x1C7E420", VA = "0x1C7E420", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A16")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A17")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001BA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA03A38", Offset = "0xA03A38")]
	[Preserve]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x1C7E7DC", Offset = "0x1C7E7DC", VA = "0x1C7E7DC")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x1C7E8A8", Offset = "0x1C7E8A8", VA = "0x1C7E8A8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A1B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001BB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA03B70", Offset = "0xA03B70")]
	[Preserve]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x1C7EC34", Offset = "0x1C7EC34", VA = "0x1C7EC34")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x1C7ED00", Offset = "0x1C7ED00", VA = "0x1C7ED00", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A1F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A20")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001BC")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA03ED8", Offset = "0xA03ED8")]
	[Preserve]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1C80484", Offset = "0x1C80484", VA = "0x1C80484")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1C80550", Offset = "0x1C80550", VA = "0x1C80550", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A24")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000A25")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001BD")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1C807F8", Offset = "0x1C807F8", VA = "0x1C807F8")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA03FD8", Offset = "0xA03FD8")]
	[Preserve]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x1C808F4", Offset = "0x1C808F4", VA = "0x1C808F4")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1C809C0", Offset = "0x1C809C0", VA = "0x1C809C0", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A2A")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000A2B")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001BF")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x1C80B38", Offset = "0x1C80B38", VA = "0x1C80B38")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04084", Offset = "0xA04084")]
	[Preserve]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x1C81384", Offset = "0x1C81384", VA = "0x1C81384")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x1C81450", Offset = "0x1C81450", VA = "0x1C81450", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A30")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001C1")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1C8166C", Offset = "0x1C8166C", VA = "0x1C8166C")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04168", Offset = "0xA04168")]
	[Preserve]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1C82168", Offset = "0x1C82168", VA = "0x1C82168")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1C82234", Offset = "0x1C82234", VA = "0x1C82234", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A35")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001C3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA0424C", Offset = "0xA0424C")]
	[Preserve]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1C82474", Offset = "0x1C82474", VA = "0x1C82474")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1C82540", Offset = "0x1C82540", VA = "0x1C82540", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A39")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001C4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04410", Offset = "0xA04410")]
	[Preserve]
	public class ES3Type_RenderTexture : ES3ObjectType
	{
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1C82AC0", Offset = "0x1C82AC0", VA = "0x1C82AC0")]
		public ES3Type_RenderTexture()
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1C82B8C", Offset = "0x1C82B8C", VA = "0x1C82B8C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A3D")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000A3E")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001C5")]
	public class ES3Type_RenderTextureArray : ES3ArrayType
	{
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1C832C4", Offset = "0x1C832C4", VA = "0x1C832C4")]
		public ES3Type_RenderTextureArray()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04804", Offset = "0xA04804")]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1C83EC8", Offset = "0x1C83EC8", VA = "0x1C83EC8")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1C83F94", Offset = "0x1C83F94", VA = "0x1C83F94", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A43")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A44")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001C7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04974", Offset = "0xA04974")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x1C844BC", Offset = "0x1C844BC", VA = "0x1C844BC")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x1C84588", Offset = "0x1C84588", VA = "0x1C84588", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A48")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A49")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001C8")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04AC8", Offset = "0xA04AC8")]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x1C84A1C", Offset = "0x1C84A1C", VA = "0x1C84A1C")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1C84AE8", Offset = "0x1C84AE8", VA = "0x1C84AE8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A4D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A4E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x1C84C88", Offset = "0x1C84C88", VA = "0x1C84C88")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04B74", Offset = "0xA04B74")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x1C84D84", Offset = "0x1C84D84", VA = "0x1C84D84")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x1C84E50", Offset = "0x1C84E50", VA = "0x1C84E50", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A53")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001CB")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04DFC", Offset = "0xA04DFC")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1C85634", Offset = "0x1C85634", VA = "0x1C85634")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1C85700", Offset = "0x1C85700", VA = "0x1C85700", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A58")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A59")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001CC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA04FA4", Offset = "0xA04FA4")]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x1C85CE8", Offset = "0x1C85CE8", VA = "0x1C85CE8")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x1C85DB4", Offset = "0x1C85DB4", VA = "0x1C85DB4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A5D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A5E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001CD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05130", Offset = "0xA05130")]
	[Preserve]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x1C86308", Offset = "0x1C86308", VA = "0x1C86308")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x1C863D4", Offset = "0x1C863D4", VA = "0x1C863D4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A62")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x192DA10", Offset = "0x192DA10", VA = "0x192DA10")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20001CF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05428", Offset = "0xA05428")]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x192DF64", Offset = "0x192DF64", VA = "0x192DF64")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x192E06C", Offset = "0x192E06C", VA = "0x192E06C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A67")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000A68")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001D0")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05528", Offset = "0xA05528")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x192E460", Offset = "0x192E460", VA = "0x192E460")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x192E52C", Offset = "0x192E52C", VA = "0x192E52C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A6C")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x192EE64", Offset = "0x192EE64", VA = "0x192EE64")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA057CC", Offset = "0xA057CC")]
	[Preserve]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x192F05C", Offset = "0x192F05C", VA = "0x192F05C")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x192F128", Offset = "0x192F128", VA = "0x192F128", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A71")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A72")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001D3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05894", Offset = "0xA05894")]
	[Preserve]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x192FC88", Offset = "0x192FC88", VA = "0x192FC88")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x192FD54", Offset = "0x192FD54", VA = "0x192FD54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A76")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000A77")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001D4")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x193064C", Offset = "0x193064C", VA = "0x193064C")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05994", Offset = "0xA05994")]
	[Preserve]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x192FF08", Offset = "0x192FF08", VA = "0x192FF08")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x192FFE0", Offset = "0x192FFE0", VA = "0x192FFE0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A7C")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000A7D")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x19304B8", Offset = "0x19304B8", VA = "0x19304B8")]
		protected bool IsReadable(Texture2D instance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001D6")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x1930550", Offset = "0x1930550", VA = "0x1930550")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x20001D7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05A94", Offset = "0xA05A94")]
	[Preserve]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1930748", Offset = "0x1930748", VA = "0x1930748")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x1930814", Offset = "0x1930814", VA = "0x1930814", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A83")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A84")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001D8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05C90", Offset = "0xA05C90")]
	[Preserve]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x1930E60", Offset = "0x1930E60", VA = "0x1930E60")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x1930F2C", Offset = "0x1930F2C", VA = "0x1930F2C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A88")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A89")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001D9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05EA8", Offset = "0xA05EA8")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x19319FC", Offset = "0x19319FC", VA = "0x19319FC")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1931AC8", Offset = "0x1931AC8", VA = "0x1931AC8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A8D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A8E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20001DA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA05FC4", Offset = "0xA05FC4")]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x1932064", Offset = "0x1932064", VA = "0x1932064")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x1932130", Offset = "0x1932130", VA = "0x1932130", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A92")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001DB")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x19322A0", Offset = "0x19322A0", VA = "0x19322A0")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA06070", Offset = "0xA06070")]
	[Preserve]
	public class ES3Type_Vector2Int : ES3Type
	{
		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x193239C", Offset = "0x193239C", VA = "0x193239C")]
		public ES3Type_Vector2Int()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x1932468", Offset = "0x1932468", VA = "0x1932468", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A97")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001DD")]
	public class ES3Type_Vector2IntArray : ES3ArrayType
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x19325DC", Offset = "0x19325DC", VA = "0x19325DC")]
		public ES3Type_Vector2IntArray()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA0611C", Offset = "0xA0611C")]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x19326D8", Offset = "0x19326D8", VA = "0x19326D8")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x19327A4", Offset = "0x19327A4", VA = "0x19327A4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000A9C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001DF")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x193296C", Offset = "0x193296C", VA = "0x193296C")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x20001E0")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA061E4", Offset = "0xA061E4")]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x1932A68", Offset = "0x1932A68", VA = "0x1932A68")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x1932B34", Offset = "0x1932B34", VA = "0x1932B34", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000AA1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001E1")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x1932D34", Offset = "0x1932D34", VA = "0x1932D34")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x20001E2")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA062AC", Offset = "0xA062AC")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1932E30", Offset = "0x1932E30", VA = "0x1932E30")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x1932EFC", Offset = "0x1932EFC", VA = "0x1932EFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000AA6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x1933114", Offset = "0x1933114", VA = "0x1933114")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001E3")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x19331B4", Offset = "0x19331B4", VA = "0x19331B4")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xA06390", Offset = "0xA06390")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x19332B0", Offset = "0x19332B0", VA = "0x19332B0")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x193337C", Offset = "0x193337C", VA = "0x193337C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000AAC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000AAD")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x20001E5")]
	internal static class ES3Debug
	{
		[Token(Token = "0x4000797")]
		private const string disableInfoMsg = "\n<i>To disable these messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Info'</i>";

		[Token(Token = "0x4000798")]
		private const string disableWarningMsg = "\n<i>To disable warnings from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Warnings'</i>";

		[Token(Token = "0x4000799")]
		private const string disableErrorMsg = "\n<i>To disable these error messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Errors'</i>";

		[Token(Token = "0x400079A")]
		private const char indentChar = '-';

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x15B8544", Offset = "0x15B8544", VA = "0x15B8544")]
		public static void Log(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x15B33D4", Offset = "0x15B33D4", VA = "0x15B33D4")]
		public static void LogWarning(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x15B4F0C", Offset = "0x15B4F0C", VA = "0x15B4F0C")]
		public static void LogError(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x15B8730", Offset = "0x15B8730", VA = "0x15B8730")]
		private static string Indent(int size)
		{
			return null;
		}
	}
	[Token(Token = "0x20001E6")]
	public static class ES3Hash
	{
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x18545D0", Offset = "0x18545D0", VA = "0x18545D0")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x20001E7")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x6000AB4")]
		public abstract byte[] Encrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000AB5")]
		public abstract byte[] Decrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x6000AB6")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000AB7")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x1939510", Offset = "0x1939510", VA = "0x1939510")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x19395F4", Offset = "0x19395F4", VA = "0x19395F4")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20001E8")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x400079B")]
		private const int ivSize = 16;

		[Token(Token = "0x400079C")]
		private const int keySize = 16;

		[Token(Token = "0x400079D")]
		private const int pwIterations = 100;

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x1AB6B1C", Offset = "0x1AB6B1C", VA = "0x1AB6B1C", Slot = "4")]
		public override byte[] Encrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x1AB6D8C", Offset = "0x1AB6D8C", VA = "0x1AB6D8C", Slot = "5")]
		public override byte[] Decrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x1AB6FFC", Offset = "0x1AB6FFC", VA = "0x1AB6FFC", Slot = "6")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x1AB7450", Offset = "0x1AB7450", VA = "0x1AB7450", Slot = "7")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x1AB788C", Offset = "0x1AB788C", VA = "0x1AB788C")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20001E9")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool disposed;

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x138BE04", Offset = "0x138BE04", VA = "0x138BE04")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x138BED0", Offset = "0x138BED0", VA = "0x138BED0", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20001EA")]
	public struct ES3Data
	{
		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x15B8434", Offset = "0x15B8434", VA = "0x15B8434")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x15B8510", Offset = "0x15B8510", VA = "0x15B8510")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x20001EB")]
	public static class ES3IO
	{
		[Token(Token = "0x20001EC")]
		public enum ES3FileMode
		{
			[Token(Token = "0x40007AA")]
			Read,
			[Token(Token = "0x40007AB")]
			Write,
			[Token(Token = "0x40007AC")]
			Append
		}

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly string persistentDataPath;

		[Token(Token = "0x40007A7")]
		internal const string backupFileSuffix = ".bac";

		[Token(Token = "0x40007A8")]
		internal const string temporaryFileSuffix = ".tmp";

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x18554EC", Offset = "0x18554EC", VA = "0x18554EC")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x18555C8", Offset = "0x18555C8", VA = "0x18555C8")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x185562C", Offset = "0x185562C", VA = "0x185562C")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x18555C0", Offset = "0x18555C0", VA = "0x18555C0")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x18556AC", Offset = "0x18556AC", VA = "0x18556AC")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x18556B4", Offset = "0x18556B4", VA = "0x18556B4")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x18556BC", Offset = "0x18556BC", VA = "0x18556BC")]
		public static void MoveDirectory(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x1854584", Offset = "0x1854584", VA = "0x1854584")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x18556C4", Offset = "0x18556C4", VA = "0x18556C4")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1854474", Offset = "0x1854474", VA = "0x1854474")]
		public static string GetDirectoryPath(string path, char seperator = '/')
		{
			return null;
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x18556CC", Offset = "0x18556CC", VA = "0x18556CC")]
		public static bool UsesForwardSlash(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x1855724", Offset = "0x1855724", VA = "0x1855724")]
		public static string CombinePathAndFilename(string directoryPath, string fileOrDirectoryName)
		{
			return null;
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x18557DC", Offset = "0x18557DC", VA = "0x18557DC")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x1855950", Offset = "0x1855950", VA = "0x1855950")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x18559D4", Offset = "0x18559D4", VA = "0x18559D4")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x1855AFC", Offset = "0x1855AFC", VA = "0x1855AFC")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x1855B04", Offset = "0x1855B04", VA = "0x1855B04")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x1855B0C", Offset = "0x1855B0C", VA = "0x1855B0C")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x20001ED")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x185B9FC", Offset = "0x185B9FC", VA = "0x185B9FC")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x185BD94", Offset = "0x185BD94", VA = "0x185BD94")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x185BE10", Offset = "0x185BE10", VA = "0x185BE10")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x185BF48", Offset = "0x185BF48", VA = "0x185BF48")]
		public Dictionary<string, string> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x185C1B0", Offset = "0x185C1B0", VA = "0x185C1B0")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x185BEF0", Offset = "0x185BEF0", VA = "0x185BEF0")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x185C784", Offset = "0x185C784", VA = "0x185C784")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001EE")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x20001EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA064F4", Offset = "0xA064F4")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Object obj;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__0;

			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x1C5B710", Offset = "0x1C5B710", VA = "0x1C5B710")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x1C5B718", Offset = "0x1C5B718", VA = "0x1C5B718")]
			internal bool <Remove>b__0(KeyValuePair<long, UnityEngine.Object> kvp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06504", Offset = "0xA06504")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long referenceID;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<UnityEngine.Object, long>, bool> <>9__0;

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x1C5B79C", Offset = "0x1C5B79C", VA = "0x1C5B79C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x1C5B7A4", Offset = "0x1C5B7A4", VA = "0x1C5B7A4")]
			internal bool <Remove>b__0(KeyValuePair<UnityEngine.Object, long> kvp)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20001F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06514", Offset = "0xA06514")]
		private sealed class <>c
		{
			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__31_0;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, long> <>9__31_1;

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x1C5B604", Offset = "0x1C5B604", VA = "0x1C5B604")]
			public <>c()
			{
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x1C5B60C", Offset = "0x1C5B60C", VA = "0x1C5B60C")]
			internal bool <RemoveNullOrInvalidValues>b__31_0(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x1C5B6D0", Offset = "0x1C5B6D0", VA = "0x1C5B6D0")]
			internal long <RemoveNullOrInvalidValues>b__31_1(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(long);
			}
		}

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _lock;

		[Token(Token = "0x40007B0")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HashSet<ES3ReferenceMgrBase> mgrs;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Random rng;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ES3RefIdDictionary _refId;

		[Token(Token = "0x170000E0")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x1858CF8", Offset = "0x1858CF8", VA = "0x1858CF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		public bool IsInitialised
		{
			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x185E4B0", Offset = "0x185E4B0", VA = "0x185E4B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E2")]
		public ES3RefIdDictionary refId
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x185E510", Offset = "0x185E510", VA = "0x185E510")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x185E704", Offset = "0x185E704", VA = "0x185E704")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public ES3GlobalReferences GlobalReferences
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x185E70C", Offset = "0x185E70C", VA = "0x185E70C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x185E714", Offset = "0x185E714", VA = "0x185E714")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x185EB04", Offset = "0x185EB04", VA = "0x185EB04")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x185E9C8", Offset = "0x185E9C8", VA = "0x185E9C8")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x185EB90", Offset = "0x185EB90", VA = "0x185EB90")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x185EDDC", Offset = "0x185EDDC", VA = "0x185EDDC")]
		internal UnityEngine.Object Get(long id, Type type, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x185F380", Offset = "0x185F380", VA = "0x185F380")]
		public UnityEngine.Object Get(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x185F38C", Offset = "0x185F38C", VA = "0x185F38C")]
		public ES3Prefab GetPrefab(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x185F78C", Offset = "0x185F78C", VA = "0x185F78C")]
		public long GetPrefab(ES3Prefab prefabToFind, bool suppressWarnings = false)
		{
			return default(long);
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x185BBE0", Offset = "0x185BBE0", VA = "0x185BBE0")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x185C3E8", Offset = "0x185C3E8", VA = "0x185C3E8")]
		public long Add(UnityEngine.Object obj, long id)
		{
			return default(long);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x185FB9C", Offset = "0x185FB9C", VA = "0x185FB9C")]
		public bool AddPrefab(ES3Prefab prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x185FC3C", Offset = "0x185FC3C", VA = "0x185FC3C")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x1860158", Offset = "0x1860158", VA = "0x1860158")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x1860680", Offset = "0x1860680", VA = "0x1860680")]
		public void RemoveNullOrInvalidValues()
		{
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x18609FC", Offset = "0x18609FC", VA = "0x18609FC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x1860B28", Offset = "0x1860B28", VA = "0x1860B28")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x1860B90", Offset = "0x1860B90", VA = "0x1860B90")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x1860BF4", Offset = "0x1860BF4", VA = "0x1860BF4")]
		public void ChangeId(long oldId, long newId)
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x185C5D4", Offset = "0x185C5D4", VA = "0x185C5D4")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x185BEE8", Offset = "0x185BEE8", VA = "0x185BEE8")]
		internal static bool CanBeSaved(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x185E3C0", Offset = "0x185E3C0", VA = "0x185E3C0")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F2")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x1856348", Offset = "0x1856348", VA = "0x1856348", Slot = "47")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x1856354", Offset = "0x1856354", VA = "0x1856354", Slot = "48")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x18563C8", Offset = "0x18563C8", VA = "0x18563C8")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA06524", Offset = "0xA06524")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x185E2E0", Offset = "0x185E2E0", VA = "0x185E2E0", Slot = "47")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x185E354", Offset = "0x185E354", VA = "0x185E354", Slot = "48")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x185C7F8", Offset = "0x185C7F8", VA = "0x185C7F8")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x20001F4")]
	public static class ES3Reflection
	{
		[Token(Token = "0x20001F5")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x170000E5")]
			public bool IsNull
			{
				[Token(Token = "0x6000B30")]
				[Address(RVA = "0x1C5BA34", Offset = "0x1C5BA34", VA = "0x1C5BA34")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E6")]
			public string Name
			{
				[Token(Token = "0x6000B31")]
				[Address(RVA = "0x1C5BA80", Offset = "0x1C5BA80", VA = "0x1C5BA80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			public Type MemberType
			{
				[Token(Token = "0x6000B32")]
				[Address(RVA = "0x1C5BAB4", Offset = "0x1C5BAB4", VA = "0x1C5BAB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			public bool IsPublic
			{
				[Token(Token = "0x6000B33")]
				[Address(RVA = "0x1C5BB00", Offset = "0x1C5BB00", VA = "0x1C5BB00")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E9")]
			public bool IsProtected
			{
				[Token(Token = "0x6000B34")]
				[Address(RVA = "0x1C5BBA0", Offset = "0x1C5BBA0", VA = "0x1C5BBA0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EA")]
			public bool IsStatic
			{
				[Token(Token = "0x6000B35")]
				[Address(RVA = "0x1C5BBF4", Offset = "0x1C5BBF4", VA = "0x1C5BBF4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x1C5BC48", Offset = "0x1C5BC48", VA = "0x1C5BC48")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x1C5BE28", Offset = "0x1C5BE28", VA = "0x1C5BE28")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x1C5BE70", Offset = "0x1C5BE70", VA = "0x1C5BE70")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x20001F6")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x1C5BEC0", Offset = "0x1C5BEC0", VA = "0x1C5BEC0")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x1C5BF44", Offset = "0x1C5BF44", VA = "0x1C5BF44")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes, BindingFlags bindingAttr)
			{
			}

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x1C5BFD8", Offset = "0x1C5BFD8", VA = "0x1C5BFD8")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x20001F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06538", Offset = "0xA06538")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x1C5B954", Offset = "0x1C5B954", VA = "0x1C5B954")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x1C5B95C", Offset = "0x1C5B95C", VA = "0x1C5B95C")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20001F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06548", Offset = "0xA06548")]
		private sealed class <>c
		{
			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__27_0;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, <>f__AnonymousType0<Assembly, Type>> <>9__27_1;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType0<Assembly, Type>, Type> <>9__27_3;

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x1C5B85C", Offset = "0x1C5B85C", VA = "0x1C5B85C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x1C5B864", Offset = "0x1C5B864", VA = "0x1C5B864")]
			internal IEnumerable<Type> <GetDerivedTypes>b__27_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x1C5B888", Offset = "0x1C5B888", VA = "0x1C5B888")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__27_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x1C5B90C", Offset = "0x1C5B90C", VA = "0x1C5B90C")]
			internal Type <GetDerivedTypes>b__27_3(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x20001F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06558", Offset = "0xA06558")]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string methodName;

			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x1C5B9EC", Offset = "0x1C5B9EC", VA = "0x1C5B9EC")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x1C5B9F4", Offset = "0x1C5B9F4", VA = "0x1C5B9F4")]
			internal bool <GetMethods>b__0(MethodInfo t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40007BF")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x40007C0")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x40007C1")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] excludedPropertyNames;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Type es3SerializableAttributeType;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Type es3NonSerializableAttributeType;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x170000E4")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x1861700", Offset = "0x1861700", VA = "0x1861700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x18619E4", Offset = "0x18619E4", VA = "0x18619E4")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x1861B9C", Offset = "0x1861B9C", VA = "0x1861B9C")]
		public static List<FieldInfo> GetSerializableFields(Type type, [Optional] List<FieldInfo> serializableFields, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x1862578", Offset = "0x1862578", VA = "0x1862578")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, [Optional] List<PropertyInfo> serializableProperties, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x18621F4", Offset = "0x18621F4", VA = "0x18621F4")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x1855164", Offset = "0x1855164", VA = "0x1855164")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x18552F4", Offset = "0x18552F4", VA = "0x18552F4")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x1862E64", Offset = "0x1862E64", VA = "0x1862E64")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x1862EEC", Offset = "0x1862EEC", VA = "0x1862EEC")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x185509C", Offset = "0x185509C", VA = "0x185509C")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x1862EF4", Offset = "0x1862EF4", VA = "0x1862EF4")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x185D8F0", Offset = "0x185D8F0", VA = "0x185D8F0")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x185DB18", Offset = "0x185DB18", VA = "0x185DB18")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x6000B13")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x18634F4", Offset = "0x18634F4", VA = "0x18634F4")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x186166C", Offset = "0x186166C", VA = "0x186166C")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x18638DC", Offset = "0x18638DC", VA = "0x18638DC")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x185507C", Offset = "0x185507C", VA = "0x185507C")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x18638FC", Offset = "0x18638FC", VA = "0x18638FC")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x186391C", Offset = "0x186391C", VA = "0x186391C")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x186393C", Offset = "0x186393C", VA = "0x186393C")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x1862D44", Offset = "0x1862D44", VA = "0x1862D44")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x1861B7C", Offset = "0x1861B7C", VA = "0x1861B7C")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x18639C4", Offset = "0x18639C4", VA = "0x18639C4")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x18639DC", Offset = "0x18639DC", VA = "0x18639DC")]
		public static bool IsInterface(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x1861B5C", Offset = "0x1861B5C", VA = "0x1861B5C")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x1862D2C", Offset = "0x1862D2C", VA = "0x1862D2C")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x18639F4", Offset = "0x18639F4", VA = "0x18639F4")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x1862D5C", Offset = "0x1862D5C", VA = "0x1862D5C")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x1863A14", Offset = "0x1863A14", VA = "0x1863A14")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x1863A8C", Offset = "0x1863A8C", VA = "0x1863A8C")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x1863234", Offset = "0x1863234", VA = "0x1863234")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x1863390", Offset = "0x1863390", VA = "0x1863390")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x1863B78", Offset = "0x1863B78", VA = "0x1863B78")]
		public static MethodInfo[] GetMethods(Type type, string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x1862C1C", Offset = "0x1862C1C", VA = "0x1862C1C")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x18621E8", Offset = "0x18621E8", VA = "0x18621E8")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x1862BF8", Offset = "0x1862BF8", VA = "0x1862BF8")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x1863CA0", Offset = "0x1863CA0", VA = "0x1863CA0")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x185B338", Offset = "0x185B338", VA = "0x185B338")]
		public static Type BaseType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x1856D9C", Offset = "0x1856D9C", VA = "0x1856D9C")]
		public static Type GetType(string typeString)
		{
			return null;
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x1863D48", Offset = "0x1863D48", VA = "0x1863D48")]
		public static string GetTypeString(Type type)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20001FA")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x20001FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06568", Offset = "0xA06568")]
		private sealed class <>c
		{
			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, bool> <>9__6_0;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, TKey> <>9__6_1;

			[Token(Token = "0x6000B4D")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B4E")]
			internal bool <RemoveNullValues>b__6_0(KeyValuePair<TKey, TVal> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B4F")]
			internal TKey <RemoveNullValues>b__6_1(KeyValuePair<TKey, TVal> pair)
			{
				return (TKey)null;
			}
		}

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x6000B45")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x6000B46")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x6000B47")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000B48")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000B49")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x6000B4A")]
		public bool ChangeKey(TKey oldKey, TKey newKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B4B")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x20001FC")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x40007DA")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamReader baseReader;

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x185641C", Offset = "0x185641C", VA = "0x185641C")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x1856680", Offset = "0x1856680", VA = "0x1856680", Slot = "21")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x1856BFC", Offset = "0x1856BFC", VA = "0x1856BFC", Slot = "22")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x1857840", Offset = "0x1857840", VA = "0x1857840", Slot = "23")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x1857850", Offset = "0x1857850", VA = "0x1857850", Slot = "27")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x1857B58", Offset = "0x1857B58", VA = "0x1857B58", Slot = "28")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x1857B98", Offset = "0x1857B98", VA = "0x1857B98", Slot = "29")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x1857BA8", Offset = "0x1857BA8", VA = "0x1857BA8", Slot = "30")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x1857BAC", Offset = "0x1857BAC", VA = "0x1857BAC", Slot = "31")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x1857BF0", Offset = "0x1857BF0", VA = "0x1857BF0", Slot = "32")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x1857BF8", Offset = "0x1857BF8", VA = "0x1857BF8", Slot = "33")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x1857BFC", Offset = "0x1857BFC", VA = "0x1857BFC", Slot = "34")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x1857CC4", Offset = "0x1857CC4", VA = "0x1857CC4", Slot = "35")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x1857CCC", Offset = "0x1857CCC", VA = "0x1857CCC", Slot = "36")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x1857CD0", Offset = "0x1857CD0", VA = "0x1857CD0", Slot = "37")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x1857D14", Offset = "0x1857D14", VA = "0x1857D14", Slot = "38")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x1857DDC", Offset = "0x1857DDC", VA = "0x1857DDC")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x1857F1C", Offset = "0x1857F1C", VA = "0x1857F1C", Slot = "24")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x1857EB4", Offset = "0x1857EB4", VA = "0x1857EB4")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x18568E4", Offset = "0x18568E4", VA = "0x18568E4")]
		private char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
		{
			return default(char);
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x1857878", Offset = "0x1857878", VA = "0x1857878")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x18569F0", Offset = "0x18569F0", VA = "0x18569F0")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x1858498", Offset = "0x1858498", VA = "0x1858498")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x1858680", Offset = "0x1858680", VA = "0x1858680")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x1856850", Offset = "0x1856850", VA = "0x1856850")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x1858888", Offset = "0x1858888", VA = "0x1858888")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x18565CC", Offset = "0x18565CC", VA = "0x18565CC")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x1858460", Offset = "0x1858460", VA = "0x1858460")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x18583DC", Offset = "0x18583DC", VA = "0x18583DC")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x18583F0", Offset = "0x18583F0", VA = "0x18583F0")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x18568D0", Offset = "0x18568D0", VA = "0x18568D0")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x18569C4", Offset = "0x18569C4", VA = "0x18569C4")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x1858908", Offset = "0x1858908", VA = "0x1858908")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x1858918", Offset = "0x1858918", VA = "0x1858918")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x18589F0", Offset = "0x18589F0", VA = "0x18589F0", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x1858BB4", Offset = "0x1858BB4", VA = "0x1858BB4", Slot = "20")]
		internal override long Read_ref()
		{
			return default(long);
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x185900C", Offset = "0x185900C", VA = "0x185900C", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x185908C", Offset = "0x185908C", VA = "0x185908C", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x185910C", Offset = "0x185910C", VA = "0x185910C", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x1859124", Offset = "0x1859124", VA = "0x1859124", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x1859198", Offset = "0x1859198", VA = "0x1859198", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x185924C", Offset = "0x185924C", VA = "0x185924C", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x1859300", Offset = "0x1859300", VA = "0x1859300", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x1859318", Offset = "0x1859318", VA = "0x1859318", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x1859330", Offset = "0x1859330", VA = "0x1859330", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x1859348", Offset = "0x1859348", VA = "0x1859348", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x1859364", Offset = "0x1859364", VA = "0x1859364", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x1859380", Offset = "0x1859380", VA = "0x1859380", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x185939C", Offset = "0x185939C", VA = "0x185939C", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x18593B8", Offset = "0x18593B8", VA = "0x18593B8", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x1859438", Offset = "0x1859438", VA = "0x1859438", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20001FD")]
	public class ES3GlobalReferences : ScriptableObject
	{
		[Token(Token = "0x170000EB")]
		public static ES3GlobalReferences Instance
		{
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x18545AC", Offset = "0x18545AC", VA = "0x18545AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x18545B4", Offset = "0x18545B4", VA = "0x18545B4")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x18545BC", Offset = "0x18545BC", VA = "0x18545BC")]
		public long GetOrAdd(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x18545C4", Offset = "0x18545C4", VA = "0x18545C4")]
		public void RemoveInvalidKeys()
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x18545C8", Offset = "0x18545C8", VA = "0x18545C8")]
		public ES3GlobalReferences()
		{
		}
	}
	[Token(Token = "0x20001FE")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoUpdateReferences;

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x15B8798", Offset = "0x15B8798", VA = "0x15B8798")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x20001FF")]
	public enum ES3FileMode
	{
		[Token(Token = "0x40007DF")]
		Read,
		[Token(Token = "0x40007E0")]
		Write,
		[Token(Token = "0x40007E1")]
		Append
	}
	[Token(Token = "0x2000200")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x1854268", Offset = "0x1854268", VA = "0x1854268")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x1854338", Offset = "0x1854338", VA = "0x1854338")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x1854444", Offset = "0x1854444", VA = "0x1854444")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x1854464", Offset = "0x1854464", VA = "0x1854464")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x185458C", Offset = "0x185458C", VA = "0x185458C", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000201")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x185B5B4", Offset = "0x185B5B4", VA = "0x185B5B4")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x185B6F8", Offset = "0x185B6F8", VA = "0x185B6F8")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x185B604", Offset = "0x185B604", VA = "0x185B604")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x185B750", Offset = "0x185B750", VA = "0x185B750", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000202")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x170000EC")]
		public bool Exists
		{
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x1864BB0", Offset = "0x1864BB0", VA = "0x1864BB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x1864BD4", Offset = "0x1864BD4", VA = "0x1864BD4")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x1864C04", Offset = "0x1864C04", VA = "0x1864C04")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x1864D04", Offset = "0x1864D04", VA = "0x1864D04", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000203")]
	public static class ES3Stream
	{
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x185DCC8", Offset = "0x185DCC8", VA = "0x185DCC8")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x1852A34", Offset = "0x1852A34", VA = "0x1852A34")]
		public static Stream CreateStream(Stream stream, ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x1867F58", Offset = "0x1867F58", VA = "0x1867F58")]
		public static void CopyTo(Stream source, Stream destination)
		{
		}
	}
	[Token(Token = "0x2000204")]
	public class ES3Member
	{
		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x185AE7C", Offset = "0x185AE7C", VA = "0x185AE7C")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x185AEDC", Offset = "0x185AEDC", VA = "0x185AEDC")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x2000205")]
	[Preserve]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0B0D4", Offset = "0xA0B0D4")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ES3Type lastAccessedType;

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x185B358", Offset = "0x185B358", VA = "0x185B358")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x186A964", Offset = "0x186A964", VA = "0x186A964")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x1867F70", Offset = "0x1867F70", VA = "0x1867F70")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x1869F30", Offset = "0x1869F30", VA = "0x1869F30")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x1869CC0", Offset = "0x1869CC0", VA = "0x1869CC0")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x2000206")]
	public class ES3WebClass
	{
		[Token(Token = "0x2000207")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06588", Offset = "0xA06588")]
		private sealed class <SendWebRequest>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3WebClass <>4__this;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x170000F0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BAF")]
				[Address(RVA = "0x1C5C1E4", Offset = "0x1C5C1E4", VA = "0x1C5C1E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BB1")]
				[Address(RVA = "0x1C5C22C", Offset = "0x1C5C22C", VA = "0x1C5C22C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x1C5C130", Offset = "0x1C5C130", VA = "0x1C5C130")]
			[DebuggerHidden]
			public <SendWebRequest>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x1C5C15C", Offset = "0x1C5C15C", VA = "0x1C5C15C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x1C5C160", Offset = "0x1C5C160", VA = "0x1C5C160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x1C5C1EC", Offset = "0x1C5C1EC", VA = "0x1C5C1EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityWebRequest _webRequest;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isDone;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string error;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long errorCode;

		[Token(Token = "0x170000ED")]
		public float uploadProgress
		{
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x1936A74", Offset = "0x1936A74", VA = "0x1936A74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000EE")]
		public float downloadProgress
		{
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x1936A8C", Offset = "0x1936A8C", VA = "0x1936A8C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000EF")]
		public bool isError
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x1936AA4", Offset = "0x1936AA4", VA = "0x1936AA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x1936AE4", Offset = "0x1936AE4", VA = "0x1936AE4")]
		public static bool IsNetworkError(UnityWebRequest www)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x1936B0C", Offset = "0x1936B0C", VA = "0x1936B0C")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x1936BC0", Offset = "0x1936BC0", VA = "0x1936BC0")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x1936C64", Offset = "0x1936C64", VA = "0x1936C64")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x1936D04", Offset = "0x1936D04", VA = "0x1936D04")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x1936E64", Offset = "0x1936E64", VA = "0x1936E64")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x1937058", Offset = "0x1937058", VA = "0x1937058")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0DB98", Offset = "0xA0DB98")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x19370EC", Offset = "0x19370EC", VA = "0x19370EC", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x2000208")]
	internal enum ES3SpecialByte : byte
	{
		[Token(Token = "0x40007FB")]
		Null = 0,
		[Token(Token = "0x40007FC")]
		Bool = 1,
		[Token(Token = "0x40007FD")]
		Byte = 2,
		[Token(Token = "0x40007FE")]
		Sbyte = 3,
		[Token(Token = "0x40007FF")]
		Char = 4,
		[Token(Token = "0x4000800")]
		Decimal = 5,
		[Token(Token = "0x4000801")]
		Double = 6,
		[Token(Token = "0x4000802")]
		Float = 7,
		[Token(Token = "0x4000803")]
		Int = 8,
		[Token(Token = "0x4000804")]
		Uint = 9,
		[Token(Token = "0x4000805")]
		Long = 10,
		[Token(Token = "0x4000806")]
		Ulong = 11,
		[Token(Token = "0x4000807")]
		Short = 12,
		[Token(Token = "0x4000808")]
		Ushort = 13,
		[Token(Token = "0x4000809")]
		String = 14,
		[Token(Token = "0x400080A")]
		ByteArray = 15,
		[Token(Token = "0x400080B")]
		Collection = 128,
		[Token(Token = "0x400080C")]
		Dictionary = 129,
		[Token(Token = "0x400080D")]
		CollectionItem = 130,
		[Token(Token = "0x400080E")]
		Object = 254,
		[Token(Token = "0x400080F")]
		Terminator = byte.MaxValue
	}
	[Token(Token = "0x2000209")]
	internal static class ES3Binary
	{
		[Token(Token = "0x4000810")]
		internal const string ObjectTerminator = ".";

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<ES3SpecialByte, Type> IdToType;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<Type, ES3SpecialByte> TypeToId;

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x15B456C", Offset = "0x15B456C", VA = "0x15B456C")]
		internal static ES3SpecialByte TypeToByte(Type type)
		{
			return default(ES3SpecialByte);
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x15B461C", Offset = "0x15B461C", VA = "0x15B461C")]
		internal static Type ByteToType(ES3SpecialByte b)
		{
			return null;
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x15B467C", Offset = "0x15B467C", VA = "0x15B467C")]
		internal static Type ByteToType(byte b)
		{
			return null;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x15B4778", Offset = "0x15B4778", VA = "0x15B4778")]
		internal static bool IsPrimitive(ES3SpecialByte b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200020A")]
	internal class ES3CacheWriter : ES3Writer
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ES3File es3File;

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x15B4E24", Offset = "0x15B4E24", VA = "0x15B4E24")]
		internal ES3CacheWriter(ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000BB8")]
		public override void Write<T>(string key, object value)
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x15B4EC0", Offset = "0x15B4EC0", VA = "0x15B4EC0", Slot = "39")]
		internal override void Write(string key, Type type, byte[] value)
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x15B50F0", Offset = "0x15B50F0", VA = "0x15B50F0", Slot = "41")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xA0DC48", Offset = "0xA0DC48")]
		public override void Write(Type type, string key, object value)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x15B515C", Offset = "0x15B515C", VA = "0x15B515C", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x15B5160", Offset = "0x15B5160", VA = "0x15B5160", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x15B5164", Offset = "0x15B5164", VA = "0x15B5164", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x15B5168", Offset = "0x15B5168", VA = "0x15B5168", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x15B516C", Offset = "0x15B516C", VA = "0x15B516C", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x15B5170", Offset = "0x15B5170", VA = "0x15B5170", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x15B5174", Offset = "0x15B5174", VA = "0x15B5174", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x15B5178", Offset = "0x15B5178", VA = "0x15B5178", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x15B517C", Offset = "0x15B517C", VA = "0x15B517C", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x15B5180", Offset = "0x15B5180", VA = "0x15B5180", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x15B5184", Offset = "0x15B5184", VA = "0x15B5184", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x15B5188", Offset = "0x15B5188", VA = "0x15B5188", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x15B518C", Offset = "0x15B518C", VA = "0x15B518C", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x15B5190", Offset = "0x15B5190", VA = "0x15B5190", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x15B5194", Offset = "0x15B5194", VA = "0x15B5194", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x15B5198", Offset = "0x15B5198", VA = "0x15B5198", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x15B519C", Offset = "0x15B519C", VA = "0x15B519C")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x15B51A4", Offset = "0x15B51A4", VA = "0x15B51A4")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x15B51A8", Offset = "0x15B51A8", VA = "0x15B51A8", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x15B51AC", Offset = "0x15B51AC", VA = "0x15B51AC", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x15B51B0", Offset = "0x15B51B0", VA = "0x15B51B0", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x15B51B4", Offset = "0x15B51B4", VA = "0x15B51B4", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x15B51BC", Offset = "0x15B51BC", VA = "0x15B51BC", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x15B51C0", Offset = "0x15B51C0", VA = "0x15B51C0", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x15B51C4", Offset = "0x15B51C4", VA = "0x15B51C4", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x15B51C8", Offset = "0x15B51C8", VA = "0x15B51C8", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x15B51CC", Offset = "0x15B51CC", VA = "0x15B51CC", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x15B51D0", Offset = "0x15B51D0", VA = "0x15B51D0", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x15B51D4", Offset = "0x15B51D4", VA = "0x15B51D4", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x15B51D8", Offset = "0x15B51D8", VA = "0x15B51D8", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x15B51DC", Offset = "0x15B51DC", VA = "0x15B51DC", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x15B51E0", Offset = "0x15B51E0", VA = "0x15B51E0", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x15B51E4", Offset = "0x15B51E4", VA = "0x15B51E4", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x15B51E8", Offset = "0x15B51E8", VA = "0x15B51E8", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x15B51EC", Offset = "0x15B51EC", VA = "0x15B51EC", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x15B51F0", Offset = "0x15B51F0", VA = "0x15B51F0", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200020B")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x1859454", Offset = "0x1859454", VA = "0x1859454")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x1859460", Offset = "0x1859460", VA = "0x1859460")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x1859518", Offset = "0x1859518", VA = "0x1859518", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x185953C", Offset = "0x185953C", VA = "0x185953C", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x18595F8", Offset = "0x18595F8", VA = "0x18595F8", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x1859680", Offset = "0x1859680", VA = "0x1859680", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x1859724", Offset = "0x1859724", VA = "0x1859724", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x18597E0", Offset = "0x18597E0", VA = "0x18597E0", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x1859804", Offset = "0x1859804", VA = "0x1859804", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x1859828", Offset = "0x1859828", VA = "0x1859828", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x185984C", Offset = "0x185984C", VA = "0x185984C", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x18598E0", Offset = "0x18598E0", VA = "0x18598E0", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x1859974", Offset = "0x1859974", VA = "0x1859974", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x1859A08", Offset = "0x1859A08", VA = "0x1859A08", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x1859A9C", Offset = "0x1859A9C", VA = "0x1859A9C", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x1859AE0", Offset = "0x1859AE0", VA = "0x1859AE0", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x1859B68", Offset = "0x1859B68", VA = "0x1859B68", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x1859DA0", Offset = "0x1859DA0", VA = "0x1859DA0", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x1859E00", Offset = "0x1859E00", VA = "0x1859E00")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x1859E34", Offset = "0x1859E34", VA = "0x1859E34")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x1859F18", Offset = "0x1859F18", VA = "0x1859F18", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x1859FB4", Offset = "0x1859FB4", VA = "0x1859FB4", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x185A000", Offset = "0x185A000", VA = "0x185A000", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x185A05C", Offset = "0x185A05C", VA = "0x185A05C", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x185A128", Offset = "0x185A128", VA = "0x185A128", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x185A130", Offset = "0x185A130", VA = "0x185A130", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x185A178", Offset = "0x185A178", VA = "0x185A178", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x185A1C4", Offset = "0x185A1C4", VA = "0x185A1C4", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x185A20C", Offset = "0x185A20C", VA = "0x185A20C", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x185A254", Offset = "0x185A254", VA = "0x185A254", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x185A284", Offset = "0x185A284", VA = "0x185A284", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x185A288", Offset = "0x185A288", VA = "0x185A288", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x185A298", Offset = "0x185A298", VA = "0x185A298", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x185A2A8", Offset = "0x185A2A8", VA = "0x185A2A8", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x185A2D8", Offset = "0x185A2D8", VA = "0x185A2D8", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x185A300", Offset = "0x185A300", VA = "0x185A300", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x185A304", Offset = "0x185A304", VA = "0x185A304", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x185A308", Offset = "0x185A308", VA = "0x185A308", Slot = "22")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x1859E84", Offset = "0x1859E84", VA = "0x1859E84")]
		public void WriteNewlineAndTabs()
		{
		}
	}
}
