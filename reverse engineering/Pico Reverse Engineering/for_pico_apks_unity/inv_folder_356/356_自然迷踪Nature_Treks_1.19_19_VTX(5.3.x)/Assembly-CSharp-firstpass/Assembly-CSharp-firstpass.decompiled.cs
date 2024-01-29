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
using FreakLib.Music;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("1.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8BCFEC", Offset = "0x8BCFEC")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8C3C0C", Offset = "0x8C3C0C")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8C3C20", Offset = "0x8C3C20")]
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
[Serializable]
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class ES2AutoSave : MonoBehaviour, IES2Selectable
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ES2AutoSaveVariableInfo> variableCache;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<ES2AutoSaveComponentInfo> components;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public ES2AutoSaveVariableInfo activeSelfVariable;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public ES2AutoSaveVariableInfo nameVariable;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ES2AutoSaveVariableInfo tagVariable;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public ES2AutoSaveVariableInfo layerVariable;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ES2AutoSaveVariableInfo parentVariable;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public string id;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public string prefabID;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public bool isInitialised;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	[SerializeField]
	public bool _selected;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3CE4", Offset = "0x8C3CE4")]
	private bool <selectionChanged>k__BackingField;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	public bool saveButtonSelected;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3D04", Offset = "0x8C3D04")]
	private bool <buttonSelectionChanged>k__BackingField;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Color color;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public new Transform transform;

	[Token(Token = "0x17000003")]
	public UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x135FCC0", Offset = "0x135FCC0", VA = "0x135FCC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public bool selected
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x135FCC4", Offset = "0x135FCC4", VA = "0x135FCC4", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x135FCCC", Offset = "0x135FCCC", VA = "0x135FCCC", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool selectionChanged
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x135FCEC", Offset = "0x135FCEC", VA = "0x135FCEC", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C4720", Offset = "0x8C4720")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x135FCE0", Offset = "0x135FCE0", VA = "0x135FCE0", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C4730", Offset = "0x8C4730")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public bool buttonSelected
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x135FCF4", Offset = "0x135FCF4", VA = "0x135FCF4", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x135FCFC", Offset = "0x135FCFC", VA = "0x135FCFC", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x135FD1C", Offset = "0x135FD1C", VA = "0x135FD1C", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C4740", Offset = "0x8C4740")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x135FD10", Offset = "0x135FD10", VA = "0x135FD10", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C4750", Offset = "0x8C4750")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool hasButtonSelectedComponents
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x135FD24", Offset = "0x135FD24", VA = "0x135FD24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public bool isPrefab
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x135FE84", Offset = "0x135FE84", VA = "0x135FE84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x135FEA8", Offset = "0x135FEA8", VA = "0x135FEA8")]
	public ES2AutoSaveVariableInfo GetCachedVariableInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x135FFC8", Offset = "0x135FFC8", VA = "0x135FFC8")]
	public ES2AutoSaveVariableInfo CacheVariableInfo(ES2AutoSaveVariableInfo variable)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1360040", Offset = "0x1360040", VA = "0x1360040")]
	public void RemoveCachedVariableInfo(string id)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1360198", Offset = "0x1360198", VA = "0x1360198")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1360704", Offset = "0x1360704", VA = "0x1360704")]
	public ES2AutoSaveComponentInfo GetComponentInfo(Component c)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1360838", Offset = "0x1360838", VA = "0x1360838")]
	public ES2AutoSaveComponentInfo GetComponentInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1360954", Offset = "0x1360954", VA = "0x1360954")]
	public ES2AutoSaveComponentInfo AddComponentInfo(ES2AutoSaveComponentInfo info)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x13609CC", Offset = "0x13609CC", VA = "0x13609CC")]
	public static ES2AutoSave AddAutoSave(GameObject go, Color color, bool hide, bool generateID, string id)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1360D7C", Offset = "0x1360D7C", VA = "0x1360D7C")]
	public static ES2AutoSave GetAutoSave(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x13604EC", Offset = "0x13604EC", VA = "0x13604EC")]
	public static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1360DD8", Offset = "0x1360DD8", VA = "0x1360DD8")]
	public ES2AutoSave()
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class ES2AutoSaveComponentInfo : ES2AutoSaveVariableInfo
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public Component component;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1360E90", Offset = "0x1360E90", VA = "0x1360E90")]
	public ES2AutoSaveComponentInfo()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1360F14", Offset = "0x1360F14", VA = "0x1360F14")]
	public ES2AutoSaveComponentInfo(Component c, ES2AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x13610E4", Offset = "0x13610E4", VA = "0x13610E4")]
	public ES2AutoSaveComponentInfo(string name, Type type, ES2AutoSave autoSave)
	{
	}
}
[Serializable]
[Token(Token = "0x2000005")]
public class ES2AutoSaveVariableInfo : IES2Selectable
{
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string name;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string id;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string previousID;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool isComponent;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool _selected;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3D94", Offset = "0x8C3D94")]
	private bool <selectionChanged>k__BackingField;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	[SerializeField]
	private bool saveButtonSelected;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public bool isProperty;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3DC4", Offset = "0x8C3DC4")]
	private bool <buttonSelectionChanged>k__BackingField;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string assemblyQualifiedTypeName;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<string> variableIDs;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject gameObject;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ES2AutoSave _autoSave;

	[Token(Token = "0x1700000A")]
	public bool selected
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1366F30", Offset = "0x1366F30", VA = "0x1366F30", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1366F38", Offset = "0x1366F38", VA = "0x1366F38", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	[SerializeField]
	public bool selectionChanged
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1366F58", Offset = "0x1366F58", VA = "0x1366F58", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C4760", Offset = "0x8C4760")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1366F4C", Offset = "0x1366F4C", VA = "0x1366F4C", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C4770", Offset = "0x8C4770")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool buttonSelected
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x135FE7C", Offset = "0x135FE7C", VA = "0x135FE7C", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1366F60", Offset = "0x1366F60", VA = "0x1366F60", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1366F80", Offset = "0x1366F80", VA = "0x1366F80", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C4780", Offset = "0x8C4780")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1366F74", Offset = "0x1366F74", VA = "0x1366F74", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C4790", Offset = "0x8C4790")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public ES2AutoSave autoSave
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1366F88", Offset = "0x1366F88", VA = "0x1366F88")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x13610A4", Offset = "0x13610A4", VA = "0x13610A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1367030", Offset = "0x1367030", VA = "0x1367030", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public Type type
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1361010", Offset = "0x1361010", VA = "0x1361010")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1360FCC", Offset = "0x1360FCC", VA = "0x1360FCC")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool HasButtonSelectedVariables
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1367034", Offset = "0x1367034", VA = "0x1367034")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1360E94", Offset = "0x1360E94", VA = "0x1360E94")]
	public ES2AutoSaveVariableInfo()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1360C7C", Offset = "0x1360C7C", VA = "0x1360C7C")]
	public ES2AutoSaveVariableInfo(string name, Type type, bool isProperty, ES2AutoSave autoSave, ES2AutoSaveVariableInfo previous)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1367168", Offset = "0x1367168", VA = "0x1367168")]
	public ES2AutoSaveVariableInfo GetVariableInfo(string name)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1367270", Offset = "0x1367270", VA = "0x1367270")]
	public ES2AutoSaveVariableInfo AddVariableInfo(string name, Type type, bool isProperty, [Optional] ES2AutoSave autoSave, [Optional] ES2AutoSaveVariableInfo previous)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x13673B0", Offset = "0x13673B0", VA = "0x13673B0")]
	public void DeleteVariableInfo(string id)
	{
	}
}
[Token(Token = "0x2000006")]
public interface IES2Selectable
{
	[Token(Token = "0x17000012")]
	bool selected
	{
		[Token(Token = "0x6000033")]
		get;
		[Token(Token = "0x6000034")]
		set;
	}

	[Token(Token = "0x17000013")]
	bool selectionChanged
	{
		[Token(Token = "0x6000035")]
		get;
		[Token(Token = "0x6000036")]
		set;
	}

	[Token(Token = "0x17000014")]
	bool buttonSelected
	{
		[Token(Token = "0x6000037")]
		get;
		[Token(Token = "0x6000038")]
		set;
	}

	[Token(Token = "0x17000015")]
	bool buttonSelectionChanged
	{
		[Token(Token = "0x6000039")]
		get;
		[Token(Token = "0x600003A")]
		set;
	}

	[Token(Token = "0x17000016")]
	UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x600003B")]
		get;
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class ES2AutoSaveGlobalManager : MonoBehaviour
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2AutoSave[] prefabArray;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HashSet<string> ids;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1361164", Offset = "0x1361164", VA = "0x1361164")]
	public ES2AutoSaveGlobalManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class ES2AutoSaveManager : MonoBehaviour
{
	[Token(Token = "0x200014F")]
	public enum LoadEvent
	{
		[Token(Token = "0x40003B5")]
		Start,
		[Token(Token = "0x40003B6")]
		OnApplicationUnPause,
		[Token(Token = "0x40003B7")]
		None
	}

	[Token(Token = "0x2000150")]
	public enum SaveEvent
	{
		[Token(Token = "0x40003B9")]
		OnApplicationQuit,
		[Token(Token = "0x40003BA")]
		OnApplicationPause,
		[Token(Token = "0x40003BB")]
		OnDisable,
		[Token(Token = "0x40003BC")]
		None
	}

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LoadEvent loadEvent;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SaveEvent saveEvent;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string filePath;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public new string tag;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool encrypt;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string encryptionPassword;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ES2Settings.EncryptionType encryptionType;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool deletePrefabsOnLoad;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool convertPrefabsToSceneObjectsOnImport;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ES2AutoSave[] sceneObjects;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Dictionary<string, ES2AutoSave> autoSaves;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Dictionary<Transform, ES2AutoSave> transforms;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public ES2AutoSaveGlobalManager globalManager;

	[NonSerialized]
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public HashSet<string> ids;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES2AutoSaveManager _instance;

	[Token(Token = "0x17000017")]
	public static ES2AutoSaveManager Instance
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x13603CC", Offset = "0x13603CC", VA = "0x13603CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x13611D4", Offset = "0x13611D4", VA = "0x13611D4")]
	public void SetFilePath(string filePath)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x13611DC", Offset = "0x13611DC", VA = "0x13611DC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1360650", Offset = "0x1360650", VA = "0x1360650")]
	public void AddAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1361360", Offset = "0x1361360", VA = "0x1361360")]
	public ES2AutoSave GetAutoSave(string id)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x13613E8", Offset = "0x13613E8", VA = "0x13613E8")]
	public void AddChildAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x136146C", Offset = "0x136146C", VA = "0x136146C")]
	public void Save()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1361760", Offset = "0x1361760", VA = "0x1361760")]
	public void Load()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1361CA8", Offset = "0x1361CA8", VA = "0x1361CA8")]
	public void WriteAutoSaves(ES2Writer writer)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1361F38", Offset = "0x1361F38", VA = "0x1361F38")]
	private void WriteAutoSaveRecursive(Transform transform, ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1362488", Offset = "0x1362488", VA = "0x1362488")]
	private void WriteAutoSave(ES2AutoSave autoSave, Transform transform, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x136312C", Offset = "0x136312C", VA = "0x136312C")]
	private void WriteVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Writer writer, object obj)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1364D38", Offset = "0x1364D38", VA = "0x1364D38")]
	public void ReadAutoSaves(ES2Reader reader)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1364D6C", Offset = "0x1364D6C", VA = "0x1364D6C")]
	private bool ReadAutoSave(ES2Reader reader, [Optional] ES2AutoSave autoSave)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1365A58", Offset = "0x1365A58", VA = "0x1365A58")]
	private void ReadComponent(ES2AutoSave autoSave, ES2Reader reader)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x13660E0", Offset = "0x13660E0", VA = "0x13660E0")]
	private void ReadVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Reader reader, object obj)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1363978", Offset = "0x1363978", VA = "0x1363978")]
	protected void WriteAllComponents(ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1366D58", Offset = "0x1366D58", VA = "0x1366D58")]
	public void Start()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1366D68", Offset = "0x1366D68", VA = "0x1366D68")]
	public void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1366DC0", Offset = "0x1366DC0", VA = "0x1366DC0")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1366DD0", Offset = "0x1366DD0", VA = "0x1366DD0")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1366DE4", Offset = "0x1366DE4", VA = "0x1366DE4")]
	public ES2AutoSaveManager()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD00C", Offset = "0x8BD00C")]
public static class ES2DirectoryUtility
{
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1368990", Offset = "0x1368990", VA = "0x1368990")]
	public static void Delete(string path, bool recursive)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x136899C", Offset = "0x136899C", VA = "0x136899C")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x13689A4", Offset = "0x13689A4", VA = "0x13689A4")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x13689AC", Offset = "0x13689AC", VA = "0x13689AC")]
	public static void CreateDirectory(string path)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x13689B4", Offset = "0x13689B4", VA = "0x13689B4")]
	public static string[] GetDirectories(string path)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x13689BC", Offset = "0x13689BC", VA = "0x13689BC")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD020", Offset = "0x8BD020")]
public static class ES2Dispose
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x13689C4", Offset = "0x13689C4", VA = "0x13689C4")]
	public static void Dispose(BinaryReader reader)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x13689F4", Offset = "0x13689F4", VA = "0x13689F4")]
	public static void Dispose(BinaryWriter writer)
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD034", Offset = "0x8BD034")]
public static class ES2FileUtility
{
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1368BA4", Offset = "0x1368BA4", VA = "0x1368BA4")]
	public static void Delete(string path)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1368B9C", Offset = "0x1368B9C", VA = "0x1368B9C")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x13693E8", Offset = "0x13693E8", VA = "0x13693E8")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1369C10", Offset = "0x1369C10", VA = "0x1369C10")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1369B54", Offset = "0x1369B54", VA = "0x1369B54")]
	public static Stream CreateFileStream(string path, ES2Settings.ES2FileMode filemode, int bufferSize)
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD048", Offset = "0x8BD048")]
public static class ES2TypeUtility
{
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x13719FC", Offset = "0x13719FC", VA = "0x13719FC")]
	public static bool IsEnum(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000D")]
public static class ES2
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool initialised;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1359A3C", Offset = "0x1359A3C", VA = "0x1359A3C")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000063")]
	public static void Save<T>(T param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000064")]
	public static void Save<T>(T param, string identifier)
	{
	}

	[Token(Token = "0x6000065")]
	public static void Save<T>(T[] param, string identifier)
	{
	}

	[Token(Token = "0x6000066")]
	public static void Save<T>(T[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000067")]
	public static void Save<T>(T[,] param, string identifier)
	{
	}

	[Token(Token = "0x6000068")]
	public static void Save<T>(T[,] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000069")]
	public static void Save2DArray<T>(T[,] param, string identifier)
	{
	}

	[Token(Token = "0x600006A")]
	public static void Save2DArray<T>(T[,] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600006B")]
	public static void Save<T>(T[,,] param, string identifier)
	{
	}

	[Token(Token = "0x600006C")]
	public static void Save<T>(T[,,] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600006D")]
	public static void Save3DArray<T>(T[,,] param, string identifier)
	{
	}

	[Token(Token = "0x600006E")]
	public static void Save3DArray<T>(T[,,] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600006F")]
	public static void Save<TKey, TValue>(Dictionary<TKey, TValue> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000070")]
	public static void Save<TKey, TValue>(Dictionary<TKey, TValue> param, string identifier)
	{
	}

	[Token(Token = "0x6000071")]
	public static void Save<T>(List<T> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000072")]
	public static void Save<T>(HashSet<T> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000073")]
	public static void Save<T>(Queue<T> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000074")]
	public static void Save<T>(Stack<T> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000075")]
	public static void Save<T>(List<T> param, string identifier)
	{
	}

	[Token(Token = "0x6000076")]
	public static void Save<T>(HashSet<T> param, string identifier)
	{
	}

	[Token(Token = "0x6000077")]
	public static void Save<T>(Queue<T> param, string identifier)
	{
	}

	[Token(Token = "0x6000078")]
	public static void Save<T>(Stack<T> param, string identifier)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1359ABC", Offset = "0x1359ABC", VA = "0x1359ABC")]
	public static void SaveRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1359CD8", Offset = "0x1359CD8", VA = "0x1359CD8")]
	public static void SaveRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1359B64", Offset = "0x1359B64", VA = "0x1359B64")]
	public static void SaveRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1359D88", Offset = "0x1359D88", VA = "0x1359D88")]
	public static void SaveRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x135A20C", Offset = "0x135A20C", VA = "0x135A20C")]
	public static void SaveRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x135A3A4", Offset = "0x135A3A4", VA = "0x135A3A4")]
	public static void SaveRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x135A538", Offset = "0x135A538", VA = "0x135A538")]
	public static void AppendRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x135A768", Offset = "0x135A768", VA = "0x135A768")]
	public static void AppendRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x135A5E0", Offset = "0x135A5E0", VA = "0x135A5E0")]
	public static void AppendRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x135A818", Offset = "0x135A818", VA = "0x135A818")]
	public static void AppendRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x135A9A0", Offset = "0x135A9A0", VA = "0x135A9A0")]
	public static void AppendRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x135AB4C", Offset = "0x135AB4C", VA = "0x135AB4C")]
	public static void AppendRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x135ACF8", Offset = "0x135ACF8", VA = "0x135ACF8")]
	public static void SaveImage(Texture2D tex, string identifier)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x135AEF8", Offset = "0x135AEF8", VA = "0x135AEF8")]
	public static byte[] LoadRaw(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x135B0E8", Offset = "0x135B0E8", VA = "0x135B0E8")]
	public static byte[] LoadRaw(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x135B224", Offset = "0x135B224", VA = "0x135B224")]
	public static object LoadObject(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x135B3D8", Offset = "0x135B3D8", VA = "0x135B3D8")]
	public static object LoadObject(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	public static T Load<T>(string identifier, ES2Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600008B")]
	public static T Load<T>(string identifier)
	{
		return (T)null;
	}

	[Token(Token = "0x600008C")]
	public static void Load<T>(string identifier, T c) where T : class
	{
	}

	[Token(Token = "0x600008D")]
	public static void Load<T>(string identifier, T c, ES2Settings settings) where T : class
	{
	}

	[Token(Token = "0x600008E")]
	public static T[] LoadArray<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	public static T[] LoadArray<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	public static void LoadArray<T>(string identifier, T[] c) where T : class
	{
	}

	[Token(Token = "0x6000091")]
	public static void LoadArray<T>(string identifier, T[] c, ES2Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000092")]
	public static T[,] Load2DArray<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	public static T[,] Load2DArray<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	public static T[,,] Load3DArray<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	public static T[,,] Load3DArray<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	public static Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	public static Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	public static List<T> LoadList<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	public static List<T> LoadList<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	public static void LoadList<T>(string identifier, List<T> c) where T : class
	{
	}

	[Token(Token = "0x600009B")]
	public static void LoadList<T>(string identifier, List<T> c, ES2Settings settings) where T : class
	{
	}

	[Token(Token = "0x600009C")]
	public static HashSet<T> LoadHashSet<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	public static HashSet<T> LoadHashSet<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	public static Queue<T> LoadQueue<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	public static Queue<T> LoadQueue<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	public static Stack<T> LoadStack<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	public static Stack<T> LoadStack<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x135B534", Offset = "0x135B534", VA = "0x135B534")]
	public static ES2Data LoadAll(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x135B758", Offset = "0x135B758", VA = "0x135B758")]
	public static ES2Data LoadAll(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x135B894", Offset = "0x135B894", VA = "0x135B894")]
	public static Texture2D LoadImage(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x135BB68", Offset = "0x135BB68", VA = "0x135BB68")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x135BBE0", Offset = "0x135BBE0", VA = "0x135BBE0")]
	public static AudioClip LoadAudio(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x135C098", Offset = "0x135C098", VA = "0x135C098")]
	public static void CacheFile(string identifier)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x135C2EC", Offset = "0x135C2EC", VA = "0x135C2EC")]
	public static bool Exists(string identifier)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x135C814", Offset = "0x135C814", VA = "0x135C814")]
	public static bool Exists(string identifier, ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x135C84C", Offset = "0x135C84C", VA = "0x135C84C")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x135CB08", Offset = "0x135CB08", VA = "0x135CB08")]
	public static void Delete(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x135CB40", Offset = "0x135CB40", VA = "0x135CB40")]
	public static void DeleteDefaultFolder()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x135CE7C", Offset = "0x135CE7C", VA = "0x135CE7C")]
	public static void Rename(string identifier, string newIdentifier)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x135D194", Offset = "0x135D194", VA = "0x135D194")]
	public static void Rename(string identifier, string newIdentifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x135D20C", Offset = "0x135D20C", VA = "0x135D20C")]
	public static string[] GetFiles(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x135D2BC", Offset = "0x135D2BC", VA = "0x135D2BC")]
	public static string[] GetFiles(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x135D2F4", Offset = "0x135D2F4", VA = "0x135D2F4")]
	public static string[] GetFiles(string identifier, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x135D5C8", Offset = "0x135D5C8", VA = "0x135D5C8")]
	public static string[] GetFolders(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x135D884", Offset = "0x135D884", VA = "0x135D884")]
	public static string[] GetFolders(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x135D8BC", Offset = "0x135D8BC", VA = "0x135D8BC")]
	public static string[] GetTags(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x135DA40", Offset = "0x135DA40", VA = "0x135DA40")]
	public static string[] GetTags(string identifier, ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
public class ES2Auto : MonoBehaviour
{
	[Token(Token = "0x2000151")]
	public enum SaveEvent
	{
		[Token(Token = "0x40003BE")]
		OnDisable,
		[Token(Token = "0x40003BF")]
		OnInterval
	}

	[Token(Token = "0x2000152")]
	public enum LoadEvent
	{
		[Token(Token = "0x40003C1")]
		OnAwake,
		[Token(Token = "0x40003C2")]
		OnStart,
		[Token(Token = "0x40003C3")]
		OnEnable
	}

	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C39C4", Offset = "0x8C39C4")]
	private sealed class <SaveRoutine>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Auto <>4__this;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x135FC48", Offset = "0x135FC48", VA = "0x135FC48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x135FCB8", Offset = "0x135FCB8", VA = "0x135FCB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x135F8A0", Offset = "0x135F8A0", VA = "0x135F8A0")]
		[DebuggerHidden]
		public <SaveRoutine>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x135FB70", Offset = "0x135FB70", VA = "0x135FB70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x135FB74", Offset = "0x135FB74", VA = "0x135FB74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x135FC50", Offset = "0x135FC50", VA = "0x135FC50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool saveOnDisable;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	public bool saveOnInterval;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float saveInterval;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool loadOnEnable;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[SerializeField]
	public bool loadOnAwake;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	[SerializeField]
	public bool loadOnStart;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	[SerializeField]
	public bool isPlayMaker;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string uniqueTag;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool savePosition;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[SerializeField]
	public bool saveRotation;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	[SerializeField]
	public bool saveScale;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	[SerializeField]
	public bool saveMesh;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public bool saveSphereCollider;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	[SerializeField]
	public bool saveBoxCollider;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	[SerializeField]
	public bool saveCapsuleCollider;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	[SerializeField]
	public bool saveMeshCollider;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string saveFile;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public ES2Settings.SaveLocation saveLocation;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	public bool encrypt;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public string encryptionPassword;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public string webUsername;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public string webPassword;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isQuitting;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ES2Settings settings;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x135DA7C", Offset = "0x135DA7C", VA = "0x135DA7C")]
	private void SavePosition()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x135DC10", Offset = "0x135DC10", VA = "0x135DC10")]
	private void LoadPosition()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x135DD60", Offset = "0x135DD60", VA = "0x135DD60")]
	private void SaveRotation()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x135DE48", Offset = "0x135DE48", VA = "0x135DE48")]
	private void LoadRotation()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x135DFA0", Offset = "0x135DFA0", VA = "0x135DFA0")]
	private void SaveScale()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x135E080", Offset = "0x135E080", VA = "0x135E080")]
	private void LoadScale()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x135E1D0", Offset = "0x135E1D0", VA = "0x135E1D0")]
	private void SaveMesh()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x135E3AC", Offset = "0x135E3AC", VA = "0x135E3AC")]
	private void LoadMesh()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x135E6B4", Offset = "0x135E6B4", VA = "0x135E6B4")]
	private void SaveSphereCollider()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x135E844", Offset = "0x135E844", VA = "0x135E844")]
	private void LoadSphereCollider()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x135EAC0", Offset = "0x135EAC0", VA = "0x135EAC0")]
	private void SaveCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x135EC50", Offset = "0x135EC50", VA = "0x135EC50")]
	private void LoadCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x135EECC", Offset = "0x135EECC", VA = "0x135EECC")]
	private void SaveBoxCollider()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x135F05C", Offset = "0x135F05C", VA = "0x135F05C")]
	private void LoadBoxCollider()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x135F2D8", Offset = "0x135F2D8", VA = "0x135F2D8")]
	private void SaveMeshCollider()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x135F468", Offset = "0x135F468", VA = "0x135F468")]
	private void LoadMeshCollider()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x135F6E4", Offset = "0x135F6E4", VA = "0x135F6E4")]
	public void Save()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x135F788", Offset = "0x135F788", VA = "0x135F788")]
	public void Load()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x135F82C", Offset = "0x135F82C", VA = "0x135F82C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C47A0", Offset = "0x8C47A0")]
	private IEnumerator SaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x135F8CC", Offset = "0x135F8CC", VA = "0x135F8CC")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x135F8E4", Offset = "0x135F8E4", VA = "0x135F8E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x135F904", Offset = "0x135F904", VA = "0x135F904")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x135FA74", Offset = "0x135FA74", VA = "0x135FA74")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x135FA8C", Offset = "0x135FA8C", VA = "0x135FA8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x135DB5C", Offset = "0x135DB5C", VA = "0x135DB5C")]
	private string GetFullFilename(string tagExtension)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x135F964", Offset = "0x135F964", VA = "0x135F964")]
	private void InitializeSettings()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x135FAA4", Offset = "0x135FAA4", VA = "0x135FAA4")]
	public ES2Auto()
	{
	}
}
[Token(Token = "0x200000F")]
public static class ES2Cache
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, ES2CachedFile> fileCaches;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1367440", Offset = "0x1367440", VA = "0x1367440")]
	public static ES2CachedFile AddNewCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1367568", Offset = "0x1367568", VA = "0x1367568")]
	public static bool DeleteCachedFile(string absolutePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x13675F4", Offset = "0x13675F4", VA = "0x13675F4")]
	public static ES2CachedFile GetOrCreateCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x13676C0", Offset = "0x13676C0", VA = "0x13676C0")]
	public static ES2CachedFile GetCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x136776C", Offset = "0x136776C", VA = "0x136776C")]
	public new static string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000010")]
public class ES2CachedFile
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, ES2Tag> tagCache;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1367BD8", Offset = "0x1367BD8", VA = "0x1367BD8")]
	public void AddTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1367C20", Offset = "0x1367C20", VA = "0x1367C20")]
	public void AddTag(ES2Tag tag)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1367CCC", Offset = "0x1367CCC", VA = "0x1367CCC")]
	public ES2Tag AddOrUpdateTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1367E30", Offset = "0x1367E30", VA = "0x1367E30")]
	public ES2Tag GetTag(string tag)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1367F94", Offset = "0x1367F94", VA = "0x1367F94")]
	public bool RemoveTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1368004", Offset = "0x1368004", VA = "0x1368004")]
	public void RenameTag(string oldTag, string newTag)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x13680D0", Offset = "0x13680D0", VA = "0x13680D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x13674F8", Offset = "0x13674F8", VA = "0x13674F8")]
	public ES2CachedFile()
	{
	}
}
[Token(Token = "0x2000011")]
public struct ES2Tag
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string tag;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public long position;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long settingsPosition;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public long nextTagPosition;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isNull;

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x9ACBFC", Offset = "0x9ACBFC", VA = "0x9ACBFC")]
	public ES2Tag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x9ACC0C", Offset = "0x9ACC0C", VA = "0x9ACC0C")]
	public ES2Tag(bool isNull)
	{
	}
}
[Token(Token = "0x2000012")]
public class ES2Data
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<string, object> loadedData;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x136864C", Offset = "0x136864C", VA = "0x136864C")]
	public void Add(string tag, object value)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x13686C4", Offset = "0x13686C4", VA = "0x13686C4")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1368734", Offset = "0x1368734", VA = "0x1368734")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	public T Load<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x60000E6")]
	public T[] LoadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	public T[,] Load2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	public T[,,] Load3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	public Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	public List<T> LoadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	public HashSet<T> LoadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	public Queue<T> LoadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	public Stack<T> LoadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1368920", Offset = "0x1368920", VA = "0x1368920")]
	public ES2Data()
	{
	}
}
[Token(Token = "0x2000013")]
public class ES2EditorWindowStyle : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GUIStyle hierarchyLabelStyle;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GUIStyle hierarchyLabelHighlightedStyle;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GUIStyle saveButtonStyle;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GUIStyle saveButtonSelectedStyle;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GUIStyle menuStyle;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GUIStyle menuMainButtonStyle;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GUIStyle menuSubButtonStyle;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GUIStyle inputLabelStyle;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GUIStyle textInputStyle;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle textAreaStyle;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GUIStyle toggleInputStyle;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GUIStyle windowContentStyle;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GUIStyle sectionStyle;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GUIStyle indentStyle;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GUIStyle columnStyle;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GUIStyle titleStyle;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GUIStyle subHeadingStyle;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GUIStyle contentButtonStyle;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GUIStyle contentTextStyle;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Texture2D windowIcon;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Texture2D windowBackground;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D whiteBackground;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Texture2D lightGreyBackground;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Texture2D toggleSelectedBackground;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Texture2D subMenuBackground;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Font bebas;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Font robotoSlab;

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1368A24", Offset = "0x1368A24", VA = "0x1368A24")]
	public ES2EditorWindowStyle()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD05C", Offset = "0x8BD05C")]
public static class ES2File
{
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x135C8AC", Offset = "0x135C8AC", VA = "0x135C8AC")]
	public static void Delete(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1368A70", Offset = "0x1368A70", VA = "0x1368A70")]
	public static void DeleteFile(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1368BAC", Offset = "0x1368BAC", VA = "0x1368BAC")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x135C34C", Offset = "0x135C34C", VA = "0x135C34C")]
	public static bool Exists(ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1368CF0", Offset = "0x1368CF0", VA = "0x1368CF0")]
	private static bool CheckForTagInBytes(string tag, byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1369164", Offset = "0x1369164", VA = "0x1369164")]
	public static void CreateFolder(string identifier)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x135CF00", Offset = "0x135CF00", VA = "0x135CF00")]
	public static void Rename(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x136916C", Offset = "0x136916C", VA = "0x136916C")]
	public static void MoveFile(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x135D628", Offset = "0x135D628", VA = "0x135D628")]
	public static string[] GetFolders(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x135D26C", Offset = "0x135D26C", VA = "0x135D26C")]
	public static string[] GetFiles(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x135D364", Offset = "0x135D364", VA = "0x135D364")]
	public static string[] GetFiles(ES2Settings settings, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x135D91C", Offset = "0x135D91C", VA = "0x135D91C")]
	public static string[] GetTags(ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x2000015")]
public static class ES2Reflection
{
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x13665B0", Offset = "0x13665B0", VA = "0x13665B0")]
	public static bool SetValue(object obj, string name, object value, bool isProperty = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x136410C", Offset = "0x136410C", VA = "0x136410C")]
	public static object GetValue(object obj, string name, bool isProperty = false)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x136BDC4", Offset = "0x136BDC4", VA = "0x136BDC4")]
	public static bool IsAssignableFrom(Type a, Type b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x136BE00", Offset = "0x136BE00", VA = "0x136BE00")]
	public static bool IsGenericType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x13640D8", Offset = "0x13640D8", VA = "0x13640D8")]
	public static Type[] GetGenericArguments(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x136CE1C", Offset = "0x136CE1C", VA = "0x136CE1C")]
	public static object CreateGenericInstance(Type type, Type genericType)
	{
		return null;
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x136D040", Offset = "0x136D040", VA = "0x136D040")]
	public static object CreateGenericInstance(Type type, Type genericType, Type genericType2)
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x136FC60", Offset = "0x136FC60", VA = "0x136FC60")]
	public static bool IsCollectionType(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8BD070", Offset = "0x8BD070")]
public class ES2Spreadsheet
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<ES2SpreadsheetRow> sheet;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool append;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static byte[] comma;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static byte[] newline;

	[Token(Token = "0x17000018")]
	public string Item
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x137107C", Offset = "0x137107C", VA = "0x137107C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1371080", Offset = "0x1371080", VA = "0x1371080")]
		set
		{
		}
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1370720", Offset = "0x1370720", VA = "0x1370720")]
	public ES2Spreadsheet()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x13708C0", Offset = "0x13708C0", VA = "0x13708C0")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1370BB8", Offset = "0x1370BB8", VA = "0x1370BB8")]
	public string GetCell(int col, int row)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x13709FC", Offset = "0x13709FC", VA = "0x13709FC")]
	private void SizeSpreadsheetToFitRow(int row)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1370CB0", Offset = "0x1370CB0", VA = "0x1370CB0")]
	public void Save(string path)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1370D20", Offset = "0x1370D20", VA = "0x1370D20")]
	public void Save(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x13707B4", Offset = "0x13707B4", VA = "0x13707B4")]
	private static void GetCharacterConstants()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1371084", Offset = "0x1371084", VA = "0x1371084", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8BD0A8", Offset = "0x8BD0A8")]
public class ES2SpreadsheetRow
{
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<string> cells;

	[Token(Token = "0x17000019")]
	public int cellCount
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x137101C", Offset = "0x137101C", VA = "0x137101C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001A")]
	public string Item
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1370CAC", Offset = "0x1370CAC", VA = "0x1370CAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x13714B4", Offset = "0x13714B4", VA = "0x13714B4")]
		set
		{
		}
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1370B34", Offset = "0x1370B34", VA = "0x1370B34")]
	public void SetCell(int col, string value)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x137127C", Offset = "0x137127C", VA = "0x137127C")]
	public string GetCell(int col)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1371004", Offset = "0x1371004", VA = "0x1371004")]
	public byte[] GetCellBytes(int col)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x13711B4", Offset = "0x13711B4", VA = "0x13711B4")]
	private void SizeRowToFitColumn(int col)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x137134C", Offset = "0x137134C", VA = "0x137134C")]
	private byte[] GetBytes(string data)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x13714B8", Offset = "0x13714B8", VA = "0x13714B8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1370AC4", Offset = "0x1370AC4", VA = "0x1370AC4")]
	public ES2SpreadsheetRow()
	{
	}
}
[Token(Token = "0x2000018")]
public class ES2Web
{
	[Token(Token = "0x2000154")]
	public enum HashType
	{
		[Token(Token = "0x40003C8")]
		MD5,
		[Token(Token = "0x40003C9")]
		None
	}

	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C39D4", Offset = "0x8C39D4")]
	private sealed class <Upload>d__18<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T param;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008F5")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008F7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F1")]
		[DebuggerHidden]
		public <Upload>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60008F2")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008F3")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60008F6")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C39E4", Offset = "0x8C39E4")]
	private sealed class <Upload>d__19<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] param;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008FC")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008FE")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F8")]
		[DebuggerHidden]
		public <Upload>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60008F9")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008FA")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008FB")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60008FD")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C39F4", Offset = "0x8C39F4")]
	private sealed class <Upload>d__20<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[,] param;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000903")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000905")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008FF")]
		[DebuggerHidden]
		public <Upload>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000900")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000901")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000902")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000904")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A04", Offset = "0x8C3A04")]
	private sealed class <Upload>d__21<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[,,] param;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600090A")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600090C")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000906")]
		[DebuggerHidden]
		public <Upload>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000907")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000908")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000909")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600090B")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A14", Offset = "0x8C3A14")]
	private sealed class <Upload>d__22<TKey, TValue> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<TKey, TValue> param;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000911")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000913")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600090D")]
		[DebuggerHidden]
		public <Upload>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600090E")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600090F")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000910")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000912")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A24", Offset = "0x8C3A24")]
	private sealed class <Upload>d__23<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> param;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000918")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600091A")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000914")]
		[DebuggerHidden]
		public <Upload>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000915")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000916")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000917")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000919")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A34", Offset = "0x8C3A34")]
	private sealed class <Upload>d__24<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HashSet<T> param;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600091F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000921")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600091B")]
		[DebuggerHidden]
		public <Upload>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600091C")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600091D")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600091E")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000920")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A44", Offset = "0x8C3A44")]
	private sealed class <Upload>d__25<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Queue<T> param;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000926")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000928")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000922")]
		[DebuggerHidden]
		public <Upload>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000923")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000924")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000925")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000927")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A54", Offset = "0x8C3A54")]
	private sealed class <Upload>d__26<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Stack<T> param;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600092D")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600092F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000929")]
		[DebuggerHidden]
		public <Upload>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600092A")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600092B")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600092C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600092E")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A64", Offset = "0x8C3A64")]
	private sealed class <UploadRaw>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] data;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x137379C", Offset = "0x137379C", VA = "0x137379C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x137380C", Offset = "0x137380C", VA = "0x137380C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1371E04", Offset = "0x1371E04", VA = "0x1371E04")]
		[DebuggerHidden]
		public <UploadRaw>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1373660", Offset = "0x1373660", VA = "0x1373660", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1373664", Offset = "0x1373664", VA = "0x1373664", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x13737A4", Offset = "0x13737A4", VA = "0x13737A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A74", Offset = "0x8C3A74")]
	private sealed class <UploadImage>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D tex;

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x13735E8", Offset = "0x13735E8", VA = "0x13735E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x1373658", Offset = "0x1373658", VA = "0x1373658", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x1371EC8", Offset = "0x1371EC8", VA = "0x1371EC8")]
		[DebuggerHidden]
		public <UploadImage>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x13734A0", Offset = "0x13734A0", VA = "0x13734A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x13734A4", Offset = "0x13734A4", VA = "0x13734A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x13735F0", Offset = "0x13735F0", VA = "0x13735F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A84", Offset = "0x8C3A84")]
	private sealed class <UploadFile>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string file;

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x1373428", Offset = "0x1373428", VA = "0x1373428", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x1373498", Offset = "0x1373498", VA = "0x1373498", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1371F8C", Offset = "0x1371F8C", VA = "0x1371F8C")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x13732C0", Offset = "0x13732C0", VA = "0x13732C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x13732C4", Offset = "0x13732C4", VA = "0x13732C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x1373430", Offset = "0x1373430", VA = "0x1373430", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3A94", Offset = "0x8C3A94")]
	private sealed class <DownloadFilenames>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x1373248", Offset = "0x1373248", VA = "0x1373248", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x13732B8", Offset = "0x13732B8", VA = "0x13732B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x1372458", Offset = "0x1372458", VA = "0x1372458")]
		[DebuggerHidden]
		public <DownloadFilenames>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x1373110", Offset = "0x1373110", VA = "0x1373110", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1373114", Offset = "0x1373114", VA = "0x1373114", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1373250", Offset = "0x1373250", VA = "0x1373250", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3AA4", Offset = "0x8C3AA4")]
	private sealed class <Download>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x1373098", Offset = "0x1373098", VA = "0x1373098", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x1373108", Offset = "0x1373108", VA = "0x1373108", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x13725B8", Offset = "0x13725B8", VA = "0x13725B8")]
		[DebuggerHidden]
		public <Download>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1372F60", Offset = "0x1372F60", VA = "0x1372F60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1372F64", Offset = "0x1372F64", VA = "0x1372F64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x13730A0", Offset = "0x13730A0", VA = "0x13730A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3AB4", Offset = "0x8C3AB4")]
	private sealed class <Delete>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x1372EE8", Offset = "0x1372EE8", VA = "0x1372EE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x1372F58", Offset = "0x1372F58", VA = "0x1372F58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1372658", Offset = "0x1372658", VA = "0x1372658")]
		[DebuggerHidden]
		public <Delete>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1372D1C", Offset = "0x1372D1C", VA = "0x1372D1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1372D20", Offset = "0x1372D20", VA = "0x1372D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1372EF0", Offset = "0x1372EF0", VA = "0x1372EF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool isDone;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool isError;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string error;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string errorCode;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HashType hashType;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES2Settings settings;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WWW www;

	[Token(Token = "0x1700001B")]
	public byte[] data
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1371B40", Offset = "0x1371B40", VA = "0x1371B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public string text
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1371B70", Offset = "0x1371B70", VA = "0x1371B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001D")]
	public float progress
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1371BA0", Offset = "0x1371BA0", VA = "0x1371BA0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700001E")]
	public float uploadProgress
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1371BD0", Offset = "0x1371BD0", VA = "0x1371BD0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1371C00", Offset = "0x1371C00", VA = "0x1371C00")]
	public ES2Web(string identifier)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1371C88", Offset = "0x1371C88", VA = "0x1371C88")]
	public ES2Web(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600011F")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4804", Offset = "0x8C4804")]
	public IEnumerator Upload<T>(T param)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4868", Offset = "0x8C4868")]
	public IEnumerator Upload<T>(T[] param)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C48CC", Offset = "0x8C48CC")]
	public IEnumerator Upload<T>(T[,] param)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4930", Offset = "0x8C4930")]
	public IEnumerator Upload<T>(T[,,] param)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4994", Offset = "0x8C4994")]
	public IEnumerator Upload<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C49F8", Offset = "0x8C49F8")]
	public IEnumerator Upload<T>(List<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4A5C", Offset = "0x8C4A5C")]
	public IEnumerator Upload<T>(HashSet<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4AC0", Offset = "0x8C4AC0")]
	public IEnumerator Upload<T>(Queue<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4B24", Offset = "0x8C4B24")]
	public IEnumerator Upload<T>(Stack<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1371D10", Offset = "0x1371D10", VA = "0x1371D10")]
	public IEnumerator UploadRaw(string data)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1371D6C", Offset = "0x1371D6C", VA = "0x1371D6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4B88", Offset = "0x8C4B88")]
	public IEnumerator UploadRaw(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1371E30", Offset = "0x1371E30", VA = "0x1371E30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4BEC", Offset = "0x8C4BEC")]
	public IEnumerator UploadImage(Texture2D tex)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1371EF4", Offset = "0x1371EF4", VA = "0x1371EF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4C50", Offset = "0x8C4C50")]
	public IEnumerator UploadFile(string file)
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1371FB8", Offset = "0x1371FB8", VA = "0x1371FB8")]
	public Texture2D LoadImage()
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1372164", Offset = "0x1372164", VA = "0x1372164")]
	public byte[] LoadRaw()
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	public T Load<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x600012F")]
	public void Load<T>(string tag, T c) where T : class
	{
	}

	[Token(Token = "0x6000130")]
	public T[] LoadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	public void LoadArray<T>(string tag, T[] c) where T : class
	{
	}

	[Token(Token = "0x6000132")]
	public T[,] Load2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	public T[,,] Load3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	public Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000135")]
	public List<T> LoadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	public HashSet<T> LoadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	public Queue<T> LoadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	public Stack<T> LoadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1372190", Offset = "0x1372190", VA = "0x1372190")]
	public void SaveToFile(string identifier)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1372210", Offset = "0x1372210", VA = "0x1372210")]
	public void SaveToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x13722B8", Offset = "0x13722B8", VA = "0x13722B8")]
	public void AppendToFile(string identifier)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x137233C", Offset = "0x137233C", VA = "0x137233C")]
	public void AppendToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x13723E4", Offset = "0x13723E4", VA = "0x13723E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4CB4", Offset = "0x8C4CB4")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1372484", Offset = "0x1372484", VA = "0x1372484")]
	public string[] GetFilenames()
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1372544", Offset = "0x1372544", VA = "0x1372544")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4D18", Offset = "0x8C4D18")]
	public IEnumerator Download()
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x13725E4", Offset = "0x13725E4", VA = "0x13725E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C4D7C", Offset = "0x8C4D7C")]
	public IEnumerator Delete()
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1372684", Offset = "0x1372684", VA = "0x1372684")]
	private WWWForm CreateUploadForm(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x13728CC", Offset = "0x13728CC", VA = "0x13728CC")]
	private WWWForm CreateDownloadForm()
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x13729A8", Offset = "0x13729A8", VA = "0x13729A8")]
	private WWWForm CreateGetFilesForm()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x137203C", Offset = "0x137203C", VA = "0x137203C")]
	private void CheckWWWUsage()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x13720CC", Offset = "0x13720CC", VA = "0x13720CC")]
	private void CheckDownloadUsage()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1372A24", Offset = "0x1372A24", VA = "0x1372A24")]
	private bool getError()
	{
		return default(bool);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1372758", Offset = "0x1372758", VA = "0x1372758")]
	private WWWForm CreateForm()
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1372C60", Offset = "0x1372C60", VA = "0x1372C60")]
	private static string StringToMD5(string str)
	{
		return null;
	}
}
[Token(Token = "0x2000019")]
public struct ES2Header
{
	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ES2Keys.Key collectionType;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int keyType;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int valueType;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x9ACB24", Offset = "0x9ACB24", VA = "0x9ACB24")]
	public ES2Header(ES2Keys.Key collectionType, int keyType, int valueType, ES2Settings settings)
	{
	}
}
[Token(Token = "0x200001A")]
public class ES2Reader : IDisposable
{
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3F44", Offset = "0x8C3F44")]
	public ES2Stream stream;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings settings;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3F58", Offset = "0x8C3F58")]
	private ES2CachedFile cachedFile;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3F6C", Offset = "0x8C3F6C")]
	public ES2Tag currentTag;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BinaryReader reader;

	[Token(Token = "0x1700001F")]
	public int Length
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x136E9E0", Offset = "0x136E9E0", VA = "0x136E9E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600014A")]
	public T Read<T>(ES2Type es2type)
	{
		return (T)null;
	}

	[Token(Token = "0x600014B")]
	public void Read<T>(ES2Type es2type, T c) where T : class
	{
	}

	[Token(Token = "0x600014C")]
	public T[] ReadArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	public void ReadArray<T>(ES2Type type, T[] c) where T : class
	{
	}

	[Token(Token = "0x600014E")]
	public T[,] Read2DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	public T[,,] Read3DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>(ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	public List<T> ReadList<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	public void ReadList<T>(ES2Type type, List<T> c) where T : class
	{
	}

	[Token(Token = "0x6000153")]
	public HashSet<T> ReadHashSet<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	public Queue<T> ReadQueue<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	public Stack<T> ReadStack<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x13666B4", Offset = "0x13666B4", VA = "0x13666B4")]
	public Array ReadSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x13668A0", Offset = "0x13668A0", VA = "0x13668A0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4DE0", Offset = "0x8C4DE0")]
	public ICollection ReadICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1366ACC", Offset = "0x1366ACC", VA = "0x1366ACC")]
	public IDictionary ReadIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	private T ReadEncrypted<T>(ES2Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600015A")]
	private void ReadEncrypted<T>(ES2Type type, T c) where T : class
	{
	}

	[Token(Token = "0x600015B")]
	private T[] ReadEncryptedArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	private void ReadEncryptedArray<T>(ES2Type type, T[] c) where T : class
	{
	}

	[Token(Token = "0x600015D")]
	private T[,] ReadEncrypted2DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	private T[,,] ReadEncrypted3DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	private Dictionary<TKey, TValue> ReadEncryptedDictionary<TKey, TValue>(ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	private List<T> ReadEncryptedList<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	private void ReadEncryptedList<T>(ES2Type type, List<T> c) where T : class
	{
	}

	[Token(Token = "0x6000162")]
	private HashSet<T> ReadEncryptedHashSet<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	private Queue<T> ReadEncryptedQueue<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	private Stack<T> ReadEncryptedStack<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x136C9F8", Offset = "0x136C9F8", VA = "0x136C9F8")]
	private Array ReadEncryptedSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x136CCE8", Offset = "0x136CCE8", VA = "0x136CCE8")]
	private ICollection ReadEncryptedICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x136CEFC", Offset = "0x136CEFC", VA = "0x136CEFC")]
	private IDictionary ReadEncryptedIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x136D200", Offset = "0x136D200", VA = "0x136D200")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey, string tag)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x136D850", Offset = "0x136D850", VA = "0x136D850")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x136D544", Offset = "0x136D544", VA = "0x136D544")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4DF4", Offset = "0x8C4DF4")]
	public ES2Header ReadHeader()
	{
		return default(ES2Header);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x136DB48", Offset = "0x136DB48", VA = "0x136DB48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4E08", Offset = "0x8C4E08")]
	public bool Next()
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x136DD9C", Offset = "0x136DD9C", VA = "0x136DD9C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4E1C", Offset = "0x8C4E1C")]
	public void Skip()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x136DDEC", Offset = "0x136DDEC", VA = "0x136DDEC")]
	protected bool WriteBytesBeforeTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x136DF20", Offset = "0x136DF20", VA = "0x136DF20")]
	protected bool WriteRemainingBytes(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x136E094", Offset = "0x136E094", VA = "0x136E094")]
	protected bool WriteBytesBeforeTagLowMemory(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x136E2EC", Offset = "0x136E2EC", VA = "0x136E2EC")]
	protected bool WriteRemainingBytesLowMemory(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x136E548", Offset = "0x136E548", VA = "0x136E548")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4E30", Offset = "0x8C4E30")]
	public bool RenameTag(string oldTag, string newTag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x136E8F8", Offset = "0x136E8F8", VA = "0x136E8F8")]
	protected bool DeleteTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x136EAE8", Offset = "0x136EAE8", VA = "0x136EAE8")]
	protected void WriteCurrentTag(ES2Writer writer)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x136EB9C", Offset = "0x136EB9C", VA = "0x136EB9C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4E44", Offset = "0x8C4E44")]
	public bool DeleteTags(ICollection<string> tags, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x13693F0", Offset = "0x13693F0", VA = "0x13693F0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4E58", Offset = "0x8C4E58")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x136EF70", Offset = "0x136EF70", VA = "0x136EF70")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4E6C", Offset = "0x8C4E6C")]
	public byte[] ReadMeshSettings()
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x136EFCC", Offset = "0x136EFCC", VA = "0x136EFCC")]
	private byte[] GetDecryptedBytes()
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x136D16C", Offset = "0x136D16C", VA = "0x136D16C")]
	private ES2Reader GetEncryptedReader()
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x136EA28", Offset = "0x136EA28", VA = "0x136EA28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4E80", Offset = "0x8C4E80")]
	public void Reset()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x136F1B8", Offset = "0x136F1B8", VA = "0x136F1B8", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x135C1D8", Offset = "0x135C1D8", VA = "0x135C1D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4E94", Offset = "0x8C4E94")]
	public void CacheFile()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x136D420", Offset = "0x136D420", VA = "0x136D420")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4EA8", Offset = "0x8C4EA8")]
	public bool ScanToTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x136F1EC", Offset = "0x136F1EC", VA = "0x136F1EC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4EBC", Offset = "0x8C4EBC")]
	public bool ScanToTag()
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1369134", Offset = "0x1369134", VA = "0x1369134")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1368E58", Offset = "0x1368E58", VA = "0x1368E58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4ED0", Offset = "0x8C4ED0")]
	public bool TagExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x135B098", Offset = "0x135B098", VA = "0x135B098")]
	public byte[] ReadRaw()
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	public T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000183")]
	public void Read<T>(T c) where T : class
	{
	}

	[Token(Token = "0x6000184")]
	public T[] ReadArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	public void ReadArray<T>(T[] c) where T : class
	{
	}

	[Token(Token = "0x6000186")]
	public T[,] Read2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	public T[,,] Read3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	public List<T> ReadList<T>()
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	public void ReadList<T>(List<T> c) where T : class
	{
	}

	[Token(Token = "0x600018B")]
	public HashSet<T> ReadHashSet<T>()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	public Queue<T> ReadQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	public Stack<T> ReadStack<T>()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	public T Read<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x600018F")]
	public void Read<T>(string tag, T c) where T : class
	{
	}

	[Token(Token = "0x6000190")]
	public T[] ReadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	public void ReadArray<T>(string tag, T[] c) where T : class
	{
	}

	[Token(Token = "0x6000192")]
	public T[,] Read2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	public T[,,] Read3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	public List<T> ReadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	public void ReadList<T>(string tag, List<T> c) where T : class
	{
	}

	[Token(Token = "0x6000197")]
	public HashSet<T> ReadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	public Queue<T> ReadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	public Stack<T> ReadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x135B674", Offset = "0x135B674", VA = "0x135B674")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4EE4", Offset = "0x8C4EE4")]
	public ES2Data ReadAll()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x136F220", Offset = "0x136F220", VA = "0x136F220")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4EF8", Offset = "0x8C4EF8")]
	public object ReadObject()
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x136F51C", Offset = "0x136F51C", VA = "0x136F51C")]
	public void ReadObject(object obj)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x135B380", Offset = "0x135B380", VA = "0x135B380")]
	public object ReadObject(string tag)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x136F608", Offset = "0x136F608", VA = "0x136F608")]
	public void ReadObject(string tag, object obj)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x136F670", Offset = "0x136F670", VA = "0x136F670")]
	public void ReadComponent(GameObject go)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x136F7F0", Offset = "0x136F7F0", VA = "0x136F7F0")]
	public void ReadComponent(string tag, GameObject go)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x136F858", Offset = "0x136F858", VA = "0x136F858")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4F0C", Offset = "0x8C4F0C")]
	public Dictionary<string, ES2Header> ReadAllHeaders()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4F20", Offset = "0x8C4F20")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x60001A3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4F34", Offset = "0x8C4F34")]
	public T ReadProperty<T>(T obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4F48", Offset = "0x8C4F48")]
	public T[] ReadPropertyArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4F5C", Offset = "0x8C4F5C")]
	public T[] ReadPropertyArray<T>(T[] obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4F70", Offset = "0x8C4F70")]
	public T[,] ReadProperty2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4F84", Offset = "0x8C4F84")]
	public T[,,] ReadProperty3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4F98", Offset = "0x8C4F98")]
	public List<T> ReadPropertyList<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4FAC", Offset = "0x8C4FAC")]
	public Queue<T> ReadPropertyQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4FC0", Offset = "0x8C4FC0")]
	public Stack<T> ReadPropertyStack<T>()
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4FD4", Offset = "0x8C4FD4")]
	public Dictionary<TKey, TValue> ReadPropertyDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x136CB24", Offset = "0x136CB24", VA = "0x136CB24")]
	private static int[] GetMultidimensionalIndices(Array a, int idx)
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x136F948", Offset = "0x136F948", VA = "0x136F948")]
	public static ES2Reader Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1361C70", Offset = "0x1361C70", VA = "0x1361C70")]
	public static ES2Reader Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x135B038", Offset = "0x135B038", VA = "0x135B038")]
	public static ES2Reader Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x136F148", Offset = "0x136F148", VA = "0x136F148")]
	public static ES2Reader Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x136F9A8", Offset = "0x136F9A8", VA = "0x136F9A8")]
	public ES2Reader(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1369070", Offset = "0x1369070", VA = "0x1369070")]
	public ES2Reader(byte[] bytes, ES2Settings settings)
	{
	}
}
[Token(Token = "0x200001B")]
public class ES2InvalidDataException : Exception
{
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x136B5FC", Offset = "0x136B5FC", VA = "0x136B5FC")]
	public ES2InvalidDataException()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD0E0", Offset = "0x8BD0E0")]
public struct ES2FilenameData
{
	[Token(Token = "0x2000164")]
	public enum PathType
	{
		[Token(Token = "0x400040D")]
		File,
		[Token(Token = "0x400040E")]
		Folder,
		[Token(Token = "0x400040F")]
		URL
	}

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string fullString;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string persistentPath;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string userFolder;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filename;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string extension;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string tag;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string playerPrefsPath;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string filePath;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public PathType pathType;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool isAbsolute;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string persistentDataPath;

	[Token(Token = "0x17000020")]
	public string directoryPath
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x9ACAC8", Offset = "0x9ACAC8", VA = "0x9ACAC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	public string resourcesPath
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x9ACAD0", Offset = "0x9ACAD0", VA = "0x9ACAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x9ACA3C", Offset = "0x9ACA3C", VA = "0x9ACA3C")]
	public ES2FilenameData(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x9ACA48", Offset = "0x9ACA48", VA = "0x9ACA48")]
	public ES2FilenameData(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x9ACA50", Offset = "0x9ACA50", VA = "0x9ACA50")]
	public void Init(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x9ACA5C", Offset = "0x9ACA5C", VA = "0x9ACA5C")]
	private void ProcessParameter(string name, string value, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x136A5D4", Offset = "0x136A5D4", VA = "0x136A5D4")]
	private static PathType GetPathType(string path)
	{
		return default(PathType);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x136AF98", Offset = "0x136AF98", VA = "0x136AF98")]
	private static bool PathIsURL(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x136A4C8", Offset = "0x136A4C8", VA = "0x136A4C8")]
	private static bool PathIsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x136B1DC", Offset = "0x136B1DC", VA = "0x136B1DC")]
	private static bool PathIsFolder(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x9ACA64", Offset = "0x9ACA64", VA = "0x9ACA64")]
	public bool HasTag()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x135CC98", Offset = "0x135CC98", VA = "0x135CC98")]
	public static string GetPersistentPath()
	{
		return null;
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x9ACA88", Offset = "0x9ACA88", VA = "0x9ACA88")]
	public bool IsURL()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x9ACA98", Offset = "0x9ACA98", VA = "0x9ACA98")]
	public bool IsFolder()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x9ACAA8", Offset = "0x9ACAA8", VA = "0x9ACAA8")]
	public bool IsFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x9ACAB8", Offset = "0x9ACAB8", VA = "0x9ACAB8")]
	public bool IsAbsolute()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x9ACAC0", Offset = "0x9ACAC0", VA = "0x9ACAC0")]
	public string GetSavePath(ES2Settings.SaveLocation saveLocation)
	{
		return null;
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD0F4", Offset = "0x8BD0F4")]
public sealed class ES2GlobalSettings : MonoBehaviour
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool hasInitialized;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static ES2Settings.SaveLocation _defaultSaveLocation;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static ES2Settings.OptimizeMode defaultOptimizeMode;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static ES2Settings.Format defaultFormat;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string defaultPCDataPath;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string defaultMacDataPath;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static bool defaultEncrypt;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string defaultEncryptionPassword;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static ES2Settings.EncryptionType defaultEncryptionType;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string defaultWebUsername;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string defaultWebPassword;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string defaultWebFilename;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static int defaultBufferSize;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings.SaveLocation saveLocation;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ES2Settings.OptimizeMode optimizeMode;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string PCDataPath;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string MacDataPath;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool encrypt;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string encryptionPassword;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ES2Settings.EncryptionType encryptionType;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string webUsername;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string webPassword;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int bufferSize;

	[Token(Token = "0x17000022")]
	public static ES2Settings.SaveLocation defaultSaveLocation
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x135CC18", Offset = "0x135CC18", VA = "0x135CC18")]
		get
		{
			return default(ES2Settings.SaveLocation);
		}
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x136B340", Offset = "0x136B340", VA = "0x136B340")]
		set
		{
		}
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x136B3AC", Offset = "0x136B3AC", VA = "0x136B3AC")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x136B4E0", Offset = "0x136B4E0", VA = "0x136B4E0")]
	public ES2GlobalSettings()
	{
	}
}
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD108", Offset = "0x8BD108")]
public static class ES2Keys
{
	[Token(Token = "0x2000165")]
	public enum Key : byte
	{
		[Token(Token = "0x4000411")]
		_NativeArray = 81,
		[Token(Token = "0x4000412")]
		_Dictionary = 82,
		[Token(Token = "0x4000413")]
		_List = 83,
		[Token(Token = "0x4000414")]
		_HashSet = 84,
		[Token(Token = "0x4000415")]
		_Queue = 85,
		[Token(Token = "0x4000416")]
		_Stack = 86,
		[Token(Token = "0x4000417")]
		_Obfuscate = 121,
		[Token(Token = "0x4000418")]
		_Size = 122,
		[Token(Token = "0x4000419")]
		_Terminator = 123,
		[Token(Token = "0x400041A")]
		_Null = 124,
		[Token(Token = "0x400041B")]
		_Settings = 125,
		[Token(Token = "0x400041C")]
		_Tag = 126,
		[Token(Token = "0x400041D")]
		_Encrypt = 127
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x136B670", Offset = "0x136B670", VA = "0x136B670")]
	public static string TypeFromKeys(Key collection, Key value, Key key)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x136BC78", Offset = "0x136BC78", VA = "0x136BC78")]
	public static Key[] KeysFromType(Key collectionType, Key valueType, Key keyType)
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x136BD48", Offset = "0x136BD48", VA = "0x136BD48")]
	public static Key KeyFromES2Type(ES2Type type)
	{
		return default(Key);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x136BD5C", Offset = "0x136BD5C", VA = "0x136BD5C")]
	public static Key[] KeysFromES2Type(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x136BD78", Offset = "0x136BD78", VA = "0x136BD78")]
	public static Key[] KeysFromES2Type(ES2Type type, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x136BD98", Offset = "0x136BD98", VA = "0x136BD98")]
	public static Key[] KeysFromES2Type(ES2Type keyType, ES2Type valueType, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1363C28", Offset = "0x1363C28", VA = "0x1363C28")]
	public static Key GetCollectionType(Type type)
	{
		return default(Key);
	}
}
[Token(Token = "0x200001F")]
public sealed class ES2Settings
{
	[Token(Token = "0x2000166")]
	public enum OptimizeMode
	{
		[Token(Token = "0x400041F")]
		Fast,
		[Token(Token = "0x4000420")]
		LowMemory
	}

	[Token(Token = "0x2000167")]
	public enum SaveLocation
	{
		[Token(Token = "0x4000422")]
		PlayerPrefs,
		[Token(Token = "0x4000423")]
		File,
		[Token(Token = "0x4000424")]
		Resources,
		[Token(Token = "0x4000425")]
		Memory
	}

	[Token(Token = "0x2000168")]
	public enum Format
	{
		[Token(Token = "0x4000427")]
		Binary
	}

	[Token(Token = "0x2000169")]
	public enum EncryptionType
	{
		[Token(Token = "0x4000429")]
		AES128,
		[Token(Token = "0x400042A")]
		Obfuscate
	}

	[Token(Token = "0x200016A")]
	public enum ES2FileMode
	{
		[Token(Token = "0x400042C")]
		Create,
		[Token(Token = "0x400042D")]
		Append,
		[Token(Token = "0x400042E")]
		Open
	}

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3F80", Offset = "0x8C3F80")]
	public ES2FilenameData filenameData;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public SaveLocation saveLocation;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public OptimizeMode optimizeMode;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Format format;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool encrypt;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string encryptionPassword;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public EncryptionType encryptionType;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string webUsername;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string webPassword;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string webFilename;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool saveNormals;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool saveUV;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	public bool saveUV2;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	public bool saveTangents;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool saveSubmeshes;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool saveSkinning;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool saveColors;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x97")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3F94", Offset = "0x8C3F94")]
	public byte meshSettingsCount;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string name;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3FA8", Offset = "0x8C3FA8")]
	public ES2FileMode fileMode;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int bufferSize;

	[Token(Token = "0x17000023")]
	public string tag
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1368B1C", Offset = "0x1368B1C", VA = "0x1368B1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1370718", Offset = "0x1370718", VA = "0x1370718")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C6284", Offset = "0x8C6284")]
	public bool IsImageFile
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x135BA94", Offset = "0x135BA94", VA = "0x135BA94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x136FFFC", Offset = "0x136FFFC", VA = "0x136FFFC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4FE8", Offset = "0x8C4FE8")]
	public void Init()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1370110", Offset = "0x1370110", VA = "0x1370110")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4FFC", Offset = "0x8C4FFC")]
	public ES2Settings Clone()
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x135A19C", Offset = "0x135A19C", VA = "0x135A19C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5010", Offset = "0x8C5010")]
	public ES2Settings Clone(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1370388", Offset = "0x1370388", VA = "0x1370388")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5024", Offset = "0x8C5024")]
	public byte[] MeshSettingsToByteArray()
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x137051C", Offset = "0x137051C", VA = "0x137051C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5038", Offset = "0x8C5038")]
	public void MeshSettingsFromByteArray(byte[] bytes)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1359EF8", Offset = "0x1359EF8", VA = "0x1359EF8")]
	public ES2Settings(string identifier)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1368F44", Offset = "0x1368F44", VA = "0x1368F44")]
	public ES2Settings(SaveLocation saveLocation)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1361610", Offset = "0x1361610", VA = "0x1361610")]
	public ES2Settings()
	{
	}
}
[Token(Token = "0x2000020")]
internal sealed class ES2FileStream : ES2Stream
{
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x13694C8", Offset = "0x13694C8", VA = "0x13694C8")]
	public ES2FileStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1369714", Offset = "0x1369714", VA = "0x1369714", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x13698F0", Offset = "0x13698F0", VA = "0x13698F0")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1369604", Offset = "0x1369604", VA = "0x1369604")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1369520", Offset = "0x1369520", VA = "0x1369520")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x1369C18", Offset = "0x1369C18", VA = "0x1369C18", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000021")]
internal sealed class ES2MemoryStream : ES2Stream
{
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public byte[] storedBytes;

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x136BE34", Offset = "0x136BE34", VA = "0x136BE34")]
	public ES2MemoryStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x136BEB0", Offset = "0x136BEB0", VA = "0x136BEB0")]
	public ES2MemoryStream(byte[] bytes, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x136BF2C", Offset = "0x136BF2C", VA = "0x136BF2C")]
	public ES2MemoryStream()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x136BFB4", Offset = "0x136BFB4", VA = "0x136BFB4", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x136C158", Offset = "0x136C158", VA = "0x136C158", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x136C160", Offset = "0x136C160", VA = "0x136C160", Slot = "6")]
	public override byte[] ReadAllBytes()
	{
		return null;
	}
}
[Token(Token = "0x2000022")]
internal sealed class ES2PlayerPrefsStream : ES2Stream
{
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x136C25C", Offset = "0x136C25C", VA = "0x136C25C")]
	public ES2PlayerPrefsStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x136C428", Offset = "0x136C428", VA = "0x136C428", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x136C8CC", Offset = "0x136C8CC", VA = "0x136C8CC")]
	private void StoreRaw()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x136C834", Offset = "0x136C834", VA = "0x136C834")]
	private void StoreRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x136C990", Offset = "0x136C990", VA = "0x136C990")]
	private void StoreRaw(string bytes)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x136C748", Offset = "0x136C748", VA = "0x136C748")]
	private void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x136C6EC", Offset = "0x136C6EC", VA = "0x136C6EC")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x136C2AC", Offset = "0x136C2AC", VA = "0x136C2AC")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x136C3CC", Offset = "0x136C3CC", VA = "0x136C3CC")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x136C9C8", Offset = "0x136C9C8", VA = "0x136C9C8", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000023")]
internal sealed class ES2ResourcesStream : ES2Stream
{
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x136FD64", Offset = "0x136FD64", VA = "0x136FD64")]
	public ES2ResourcesStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x136FF1C", Offset = "0x136FF1C", VA = "0x136FF1C", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x136FF88", Offset = "0x136FF88", VA = "0x136FF88", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000024")]
public abstract class ES2Stream
{
	[Token(Token = "0x200016B")]
	public enum Operation
	{
		[Token(Token = "0x4000430")]
		Read,
		[Token(Token = "0x4000431")]
		Write
	}

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Stream stream;

	[Token(Token = "0x17000025")]
	public long Length
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x136DD68", Offset = "0x136DD68", VA = "0x136DD68")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x13715D4", Offset = "0x13715D4", VA = "0x13715D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public long Position
	{
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1365A24", Offset = "0x1365A24", VA = "0x1365A24")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x13660A0", Offset = "0x13660A0", VA = "0x13660A0")]
		set
		{
		}
	}

	[Token(Token = "0x60001F6")]
	public abstract void Store();

	[Token(Token = "0x60001F7")]
	public abstract bool MayRequireOverwrite();

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x136DFFC", Offset = "0x136DFFC", VA = "0x136DFFC")]
	public byte[] ReadBytes(int count)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x136C174", Offset = "0x136C174", VA = "0x136C174", Slot = "6")]
	public virtual byte[] ReadAllBytes()
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x13699AC", Offset = "0x13699AC", VA = "0x13699AC")]
	protected void WriteToStreamFast(Stream writableStream)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1369A34", Offset = "0x1369A34", VA = "0x1369A34")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C504C", Offset = "0x8C504C")]
	protected void WriteToStreamLowMemory(Stream writableStream)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x136FC00", Offset = "0x136FC00", VA = "0x136FC00")]
	public static ES2Stream Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x136FAA8", Offset = "0x136FAA8", VA = "0x136FAA8")]
	public static ES2Stream Create(ES2Settings settings, Operation operation)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1369518", Offset = "0x1369518", VA = "0x1369518")]
	protected ES2Stream()
	{
	}
}
[Token(Token = "0x2000025")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD11C", Offset = "0x8BD11C")]
public sealed class ES2_BoneWeight : ES2Type
{
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x13749C4", Offset = "0x13749C4", VA = "0x13749C4")]
	public ES2_BoneWeight()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1374A6C", Offset = "0x1374A6C", VA = "0x1374A6C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1374C64", Offset = "0x1374C64", VA = "0x1374C64", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD130", Offset = "0x8BD130")]
public sealed class ES2_Bounds : ES2Type
{
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1374E6C", Offset = "0x1374E6C", VA = "0x1374E6C")]
	public ES2_Bounds()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1374F14", Offset = "0x1374F14", VA = "0x1374F14", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1375024", Offset = "0x1375024", VA = "0x1375024", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD144", Offset = "0x8BD144")]
public sealed class ES2_Color : ES2Type
{
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1375C64", Offset = "0x1375C64", VA = "0x1375C64")]
	public ES2_Color()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1375D0C", Offset = "0x1375D0C", VA = "0x1375D0C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1375E30", Offset = "0x1375E30", VA = "0x1375E30", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000028")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD158", Offset = "0x8BD158")]
public sealed class ES2_Color32 : ES2Type
{
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1375F6C", Offset = "0x1375F6C", VA = "0x1375F6C")]
	public ES2_Color32()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1376014", Offset = "0x1376014", VA = "0x1376014", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x1376100", Offset = "0x1376100", VA = "0x1376100", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000029")]
public class ES2_DateTime : ES2Type
{
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1376224", Offset = "0x1376224", VA = "0x1376224", Slot = "4")]
	public override void Write(object obj, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x13762C4", Offset = "0x13762C4", VA = "0x13762C4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x137635C", Offset = "0x137635C", VA = "0x137635C")]
	public ES2_DateTime()
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD16C", Offset = "0x8BD16C")]
public sealed class ES2_Enum : ES2Type
{
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1371A30", Offset = "0x1371A30", VA = "0x1371A30")]
	public ES2_Enum()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1376788", Offset = "0x1376788", VA = "0x1376788", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1376818", Offset = "0x1376818", VA = "0x1376818", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD180", Offset = "0x8BD180")]
public sealed class ES2_ES2AutoSaveManager : ES2Type
{
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x13763FC", Offset = "0x13763FC", VA = "0x13763FC")]
	public ES2_ES2AutoSaveManager()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x137649C", Offset = "0x137649C", VA = "0x137649C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x13765F4", Offset = "0x13765F4", VA = "0x13765F4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1376628", Offset = "0x1376628", VA = "0x1376628", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200002C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD194", Offset = "0x8BD194")]
public sealed class ES2_Gradient : ES2Type
{
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x13768AC", Offset = "0x13768AC", VA = "0x13768AC")]
	public ES2_Gradient()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x137694C", Offset = "0x137694C", VA = "0x137694C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1376AA8", Offset = "0x1376AA8", VA = "0x1376AA8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD1A8", Offset = "0x8BD1A8")]
public sealed class ES2_GradientAlphaKey : ES2Type
{
	[Token(Token = "0x600021C")]
	[Address(RVA = "0xF89220", Offset = "0xF89220", VA = "0xF89220")]
	public ES2_GradientAlphaKey()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xF892A4", Offset = "0xF892A4", VA = "0xF892A4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xF89370", Offset = "0xF89370", VA = "0xF89370", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD1BC", Offset = "0x8BD1BC")]
public sealed class ES2_GradientColorKey : ES2Type
{
	[Token(Token = "0x600021F")]
	[Address(RVA = "0xF8944C", Offset = "0xF8944C", VA = "0xF8944C")]
	public ES2_GradientColorKey()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xF894D0", Offset = "0xF894D0", VA = "0xF894D0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xF89638", Offset = "0xF89638", VA = "0xF89638", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD1D0", Offset = "0x8BD1D0")]
public sealed class ES2_Material : ES2Type
{
	[Token(Token = "0x6000222")]
	[Address(RVA = "0xF8973C", Offset = "0xF8973C", VA = "0xF8973C")]
	public ES2_Material()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xF897CC", Offset = "0xF897CC", VA = "0xF897CC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xF8AA4C", Offset = "0xF8AA4C", VA = "0xF8AA4C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xF8AAF0", Offset = "0xF8AAF0", VA = "0xF8AAF0", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD1E4", Offset = "0x8BD1E4")]
public sealed class ES2_Matrix4x4 : ES2Type
{
	[Token(Token = "0x6000226")]
	[Address(RVA = "0xF8B0EC", Offset = "0xF8B0EC", VA = "0xF8B0EC")]
	public ES2_Matrix4x4()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xF8B17C", Offset = "0xF8B17C", VA = "0xF8B17C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xF8B348", Offset = "0xF8B348", VA = "0xF8B348", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD1F8", Offset = "0x8BD1F8")]
public sealed class ES2_Mesh : ES2Type
{
	[Token(Token = "0x6000229")]
	[Address(RVA = "0xF8B488", Offset = "0xF8B488", VA = "0xF8B488")]
	public ES2_Mesh()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xF8B518", Offset = "0xF8B518", VA = "0xF8B518", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xF8B978", Offset = "0xF8B978", VA = "0xF8B978", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xF8B9FC", Offset = "0xF8B9FC", VA = "0xF8B9FC", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD20C", Offset = "0x8BD20C")]
public sealed class ES2_Quaternion : ES2Type
{
	[Token(Token = "0x600022D")]
	[Address(RVA = "0xF8CCFC", Offset = "0xF8CCFC", VA = "0xF8CCFC")]
	public ES2_Quaternion()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xF8CD8C", Offset = "0xF8CD8C", VA = "0xF8CD8C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xF8CEAC", Offset = "0xF8CEAC", VA = "0xF8CEAC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD220", Offset = "0x8BD220")]
public sealed class ES2_Rect : ES2Type
{
	[Token(Token = "0x6000230")]
	[Address(RVA = "0xF8CFE8", Offset = "0xF8CFE8", VA = "0xF8CFE8")]
	public ES2_Rect()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xF8D078", Offset = "0xF8D078", VA = "0xF8D078", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xF8D1AC", Offset = "0xF8D1AC", VA = "0xF8D1AC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD234", Offset = "0x8BD234")]
public sealed class ES2_Sprite : ES2Type
{
	[Token(Token = "0x6000233")]
	[Address(RVA = "0xF8DF08", Offset = "0xF8DF08", VA = "0xF8DF08")]
	public ES2_Sprite()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xF8DF98", Offset = "0xF8DF98", VA = "0xF8DF98", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xF8E320", Offset = "0xF8E320", VA = "0xF8E320", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000035")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD248", Offset = "0x8BD248")]
public sealed class ES2_Texture : ES2Type
{
	[Token(Token = "0x6000236")]
	[Address(RVA = "0xF8E49C", Offset = "0xF8E49C", VA = "0xF8E49C")]
	public ES2_Texture()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xF8E520", Offset = "0xF8E520", VA = "0xF8E520", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xF8E6A8", Offset = "0xF8E6A8", VA = "0xF8E6A8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xF8E800", Offset = "0xF8E800", VA = "0xF8E800", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD25C", Offset = "0x8BD25C")]
public sealed class ES2_Texture2D : ES2Type
{
	[Token(Token = "0x600023A")]
	[Address(RVA = "0xF8E958", Offset = "0xF8E958", VA = "0xF8E958")]
	public ES2_Texture2D()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xF8E9E8", Offset = "0xF8E9E8", VA = "0xF8E9E8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xF8EC4C", Offset = "0xF8EC4C", VA = "0xF8EC4C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xF8ECD8", Offset = "0xF8ECD8", VA = "0xF8ECD8", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000037")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD270", Offset = "0x8BD270")]
public sealed class ES2_Vector2 : ES2Type
{
	[Token(Token = "0x600023E")]
	[Address(RVA = "0xF8C118", Offset = "0xF8C118", VA = "0xF8C118")]
	public ES2_Vector2()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xF8F534", Offset = "0xF8F534", VA = "0xF8F534", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xF8F600", Offset = "0xF8F600", VA = "0xF8F600", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000038")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD284", Offset = "0x8BD284")]
public sealed class ES2_Vector3 : ES2Type
{
	[Token(Token = "0x6000241")]
	[Address(RVA = "0xF8BFF8", Offset = "0xF8BFF8", VA = "0xF8BFF8")]
	public ES2_Vector3()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xF8F6DC", Offset = "0xF8F6DC", VA = "0xF8F6DC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xF8F7D4", Offset = "0xF8F7D4", VA = "0xF8F7D4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD298", Offset = "0x8BD298")]
public sealed class ES2_Vector4 : ES2Type
{
	[Token(Token = "0x6000244")]
	[Address(RVA = "0xF8C1A8", Offset = "0xF8C1A8", VA = "0xF8C1A8")]
	public ES2_Vector4()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xF8F8E8", Offset = "0xF8F8E8", VA = "0xF8F8E8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xF8FA08", Offset = "0xF8FA08", VA = "0xF8FA08", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200003A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD2AC", Offset = "0x8BD2AC")]
public sealed class ES2_BoxCollider : ES2Type
{
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1375110", Offset = "0x1375110", VA = "0x1375110")]
	public ES2_BoxCollider()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x13751B8", Offset = "0x13751B8", VA = "0x13751B8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x137536C", Offset = "0x137536C", VA = "0x137536C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x13753E8", Offset = "0x13753E8", VA = "0x13753E8", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD2C0", Offset = "0x8BD2C0")]
public sealed class ES2_CapsuleCollider : ES2Type
{
	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1375610", Offset = "0x1375610", VA = "0x1375610")]
	public ES2_CapsuleCollider()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x13756B8", Offset = "0x13756B8", VA = "0x13756B8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x13758F4", Offset = "0x13758F4", VA = "0x13758F4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1375970", Offset = "0x1375970", VA = "0x1375970", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD2D4", Offset = "0x8BD2D4")]
public sealed class ES2_MeshCollider : ES2Type
{
	[Token(Token = "0x600024F")]
	[Address(RVA = "0xF8C238", Offset = "0xF8C238", VA = "0xF8C238")]
	public ES2_MeshCollider()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xF8C2C8", Offset = "0xF8C2C8", VA = "0xF8C2C8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xF8C4B4", Offset = "0xF8C4B4", VA = "0xF8C4B4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xF8C530", Offset = "0xF8C530", VA = "0xF8C530", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD2E8", Offset = "0x8BD2E8")]
public sealed class ES2_PolygonCollider2D : ES2Type
{
	[Token(Token = "0x6000253")]
	[Address(RVA = "0xF8C79C", Offset = "0xF8C79C", VA = "0xF8C79C")]
	public ES2_PolygonCollider2D()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xF8C82C", Offset = "0xF8C82C", VA = "0xF8C82C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xF8CA58", Offset = "0xF8CA58", VA = "0xF8CA58", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xF8CAD4", Offset = "0xF8CAD4", VA = "0xF8CAD4", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD2FC", Offset = "0x8BD2FC")]
public sealed class ES2_SkinnedMeshRenderer : ES2Type
{
	[Token(Token = "0x6000257")]
	[Address(RVA = "0xF8D2E8", Offset = "0xF8D2E8", VA = "0xF8D2E8")]
	public ES2_SkinnedMeshRenderer()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xF8D378", Offset = "0xF8D378", VA = "0xF8D378", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xF8D630", Offset = "0xF8D630", VA = "0xF8D630", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xF8D6AC", Offset = "0xF8D6AC", VA = "0xF8D6AC", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD310", Offset = "0x8BD310")]
public sealed class ES2_SphereCollider : ES2Type
{
	[Token(Token = "0x600025B")]
	[Address(RVA = "0xF8DA10", Offset = "0xF8DA10", VA = "0xF8DA10")]
	public ES2_SphereCollider()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xF8DAA0", Offset = "0xF8DAA0", VA = "0xF8DAA0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xF8DC5C", Offset = "0xF8DC5C", VA = "0xF8DC5C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xF8DCD8", Offset = "0xF8DCD8", VA = "0xF8DCD8", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000040")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD324", Offset = "0x8BD324")]
public sealed class ES2_Transform : ES2Type
{
	[Token(Token = "0x600025F")]
	[Address(RVA = "0xF8EFA0", Offset = "0xF8EFA0", VA = "0xF8EFA0")]
	public ES2_Transform()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xF8F030", Offset = "0xF8F030", VA = "0xF8F030", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xF8F214", Offset = "0xF8F214", VA = "0xF8F214", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xF8F290", Offset = "0xF8F290", VA = "0xF8F290", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000041")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD338", Offset = "0x8BD338")]
public abstract class ES2Type
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public byte key;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int hash;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Type type;

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1371614", Offset = "0x1371614", VA = "0x1371614")]
	public ES2Type(Type type)
	{
	}

	[Token(Token = "0x6000264")]
	public abstract void Write(object data, ES2Writer writer);

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1371688", Offset = "0x1371688", VA = "0x1371688", Slot = "5")]
	public virtual object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1371748", Offset = "0x1371748", VA = "0x1371748", Slot = "6")]
	public virtual void Read(ES2Reader reader, object c)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1371800", Offset = "0x1371800", VA = "0x1371800", Slot = "7")]
	public virtual void Read(ES2Reader reader, Component c)
	{
	}

	[Token(Token = "0x6000268")]
	public static T GetOrCreate<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1371654", Offset = "0x1371654", VA = "0x1371654")]
	public static int GetHash(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x137180C", Offset = "0x137180C", VA = "0x137180C")]
	public static int GetHash(string value)
	{
		return default(int);
	}
}
[Token(Token = "0x2000042")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD34C", Offset = "0x8BD34C")]
public static class ES2TypeManager
{
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<Type, ES2Type> types;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES2Type cachedType;

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1371954", Offset = "0x1371954", VA = "0x1371954")]
	public static void AddES2Type(ES2Type es2Type)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1363EBC", Offset = "0x1363EBC", VA = "0x1363EBC")]
	public static ES2Type GetES2Type(Type type)
	{
		return null;
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x136D8AC", Offset = "0x136D8AC", VA = "0x136D8AC")]
	public static ES2Type GetES2Type(byte key)
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1371AD8", Offset = "0x1371AD8", VA = "0x1371AD8")]
	public static ES2Type GetES2Type(ES2Keys.Key key)
	{
		return null;
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1365E04", Offset = "0x1365E04", VA = "0x1365E04")]
	public static ES2Type GetES2Type(int hash)
	{
		return null;
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD360", Offset = "0x8BD360")]
public sealed class ES2_bool : ES2Type
{
	[Token(Token = "0x6000271")]
	[Address(RVA = "0xF8FB44", Offset = "0xF8FB44", VA = "0xF8FB44")]
	public ES2_bool()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xF8FBD4", Offset = "0xF8FBD4", VA = "0xF8FBD4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xF8FC60", Offset = "0xF8FC60", VA = "0xF8FC60", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD374", Offset = "0x8BD374")]
public sealed class ES2_byte : ES2Type
{
	[Token(Token = "0x6000274")]
	[Address(RVA = "0xF8FCF4", Offset = "0xF8FCF4", VA = "0xF8FCF4")]
	public ES2_byte()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xF8FD80", Offset = "0xF8FD80", VA = "0xF8FD80", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xF8FE0C", Offset = "0xF8FE0C", VA = "0xF8FE0C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD388", Offset = "0x8BD388")]
public sealed class ES2_char : ES2Type
{
	[Token(Token = "0x6000277")]
	[Address(RVA = "0xF8FE9C", Offset = "0xF8FE9C", VA = "0xF8FE9C")]
	public ES2_char()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xF8FF2C", Offset = "0xF8FF2C", VA = "0xF8FF2C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xF8FFBC", Offset = "0xF8FFBC", VA = "0xF8FFBC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000046")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD39C", Offset = "0x8BD39C")]
public sealed class ES2_decimal : ES2Type
{
	[Token(Token = "0x600027A")]
	[Address(RVA = "0xF9004C", Offset = "0xF9004C", VA = "0xF9004C")]
	public ES2_decimal()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xF900DC", Offset = "0xF900DC", VA = "0xF900DC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xF9016C", Offset = "0xF9016C", VA = "0xF9016C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000047")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD3B0", Offset = "0x8BD3B0")]
public sealed class ES2_double : ES2Type
{
	[Token(Token = "0x600027D")]
	[Address(RVA = "0xF90200", Offset = "0xF90200", VA = "0xF90200")]
	public ES2_double()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xF90290", Offset = "0xF90290", VA = "0xF90290", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xF90320", Offset = "0xF90320", VA = "0xF90320", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD3C4", Offset = "0x8BD3C4")]
public sealed class ES2_float : ES2Type
{
	[Token(Token = "0x6000280")]
	[Address(RVA = "0xF903B0", Offset = "0xF903B0", VA = "0xF903B0")]
	public ES2_float()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xF90440", Offset = "0xF90440", VA = "0xF90440", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xF904D0", Offset = "0xF904D0", VA = "0xF904D0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000049")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD3D8", Offset = "0x8BD3D8")]
public sealed class ES2_int : ES2Type
{
	[Token(Token = "0x6000283")]
	[Address(RVA = "0xF8C088", Offset = "0xF8C088", VA = "0xF8C088")]
	public ES2_int()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xF90560", Offset = "0xF90560", VA = "0xF90560", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xF905F0", Offset = "0xF905F0", VA = "0xF905F0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD3EC", Offset = "0x8BD3EC")]
public sealed class ES2_long : ES2Type
{
	[Token(Token = "0x6000286")]
	[Address(RVA = "0xF90684", Offset = "0xF90684", VA = "0xF90684")]
	public ES2_long()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xF90714", Offset = "0xF90714", VA = "0xF90714", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xF907A4", Offset = "0xF907A4", VA = "0xF907A4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD400", Offset = "0x8BD400")]
public sealed class ES2_object : ES2Type
{
	[Token(Token = "0x6000289")]
	[Address(RVA = "0xF90838", Offset = "0xF90838", VA = "0xF90838")]
	public ES2_object()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xF908BC", Offset = "0xF908BC", VA = "0xF908BC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xF90A24", Offset = "0xF90A24", VA = "0xF90A24", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD414", Offset = "0x8BD414")]
public sealed class ES2_sbyte : ES2Type
{
	[Token(Token = "0x600028C")]
	[Address(RVA = "0xF90B24", Offset = "0xF90B24", VA = "0xF90B24")]
	public ES2_sbyte()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xF90BB4", Offset = "0xF90BB4", VA = "0xF90BB4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xF90C40", Offset = "0xF90C40", VA = "0xF90C40", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD428", Offset = "0x8BD428")]
public sealed class ES2_short : ES2Type
{
	[Token(Token = "0x600028F")]
	[Address(RVA = "0xF90CD0", Offset = "0xF90CD0", VA = "0xF90CD0")]
	public ES2_short()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xF90D60", Offset = "0xF90D60", VA = "0xF90D60", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xF90DF0", Offset = "0xF90DF0", VA = "0xF90DF0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD43C", Offset = "0x8BD43C")]
public sealed class ES2_string : ES2Type
{
	[Token(Token = "0x6000292")]
	[Address(RVA = "0xF90E84", Offset = "0xF90E84", VA = "0xF90E84")]
	public ES2_string()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xF90F14", Offset = "0xF90F14", VA = "0xF90F14", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xF91000", Offset = "0xF91000", VA = "0xF91000", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD450", Offset = "0x8BD450")]
public sealed class ES2_uint : ES2Type
{
	[Token(Token = "0x6000295")]
	[Address(RVA = "0xF91048", Offset = "0xF91048", VA = "0xF91048")]
	public ES2_uint()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xF910D8", Offset = "0xF910D8", VA = "0xF910D8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xF91168", Offset = "0xF91168", VA = "0xF91168", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD464", Offset = "0x8BD464")]
public sealed class ES2_ulong : ES2Type
{
	[Token(Token = "0x6000298")]
	[Address(RVA = "0xF911FC", Offset = "0xF911FC", VA = "0xF911FC")]
	public ES2_ulong()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xF9128C", Offset = "0xF9128C", VA = "0xF9128C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xF9131C", Offset = "0xF9131C", VA = "0xF9131C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD478", Offset = "0x8BD478")]
public sealed class ES2_ushort : ES2Type
{
	[Token(Token = "0x600029B")]
	[Address(RVA = "0xF913B0", Offset = "0xF913B0", VA = "0xF913B0")]
	public ES2_ushort()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xF91440", Offset = "0xF91440", VA = "0xF91440", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xF914D0", Offset = "0xF914D0", VA = "0xF914D0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000052")]
public class ES2Writer : IDisposable
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3FBC", Offset = "0x8C3FBC")]
	public ES2Stream stream;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3FD0", Offset = "0x8C3FD0")]
	public HashSet<string> tagsToDelete;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3FE4", Offset = "0x8C3FE4")]
	public BinaryWriter writer;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3FF8", Offset = "0x8C3FF8")]
	private long lengthPosition;

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x135A0B8", Offset = "0x135A0B8", VA = "0x135A0B8")]
	public void WriteRaw(byte[] param)
	{
	}

	[Token(Token = "0x600029F")]
	public void Write<T>(T param)
	{
	}

	[Token(Token = "0x60002A0")]
	public void Write<T>(T[] param)
	{
	}

	[Token(Token = "0x60002A1")]
	public void Write<T>(T[,] param)
	{
	}

	[Token(Token = "0x60002A2")]
	public void Write<T>(T[,,] param)
	{
	}

	[Token(Token = "0x60002A3")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
	}

	[Token(Token = "0x60002A4")]
	public void Write<T>(List<T> param)
	{
	}

	[Token(Token = "0x60002A5")]
	public void Write<T>(HashSet<T> param)
	{
	}

	[Token(Token = "0x60002A6")]
	public void Write<T>(Queue<T> param)
	{
	}

	[Token(Token = "0x60002A7")]
	public void Write<T>(Stack<T> param)
	{
	}

	[Token(Token = "0x60002A8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5060", Offset = "0x8C5060")]
	public void Write<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x60002A9")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5074", Offset = "0x8C5074")]
	public void Write<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AA")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5088", Offset = "0x8C5088")]
	public void Write<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AB")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C509C", Offset = "0x8C509C")]
	public void Write<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C50B0", Offset = "0x8C50B0")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002AD")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C50C4", Offset = "0x8C50C4")]
	public void Write<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AE")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C50D8", Offset = "0x8C50D8")]
	public void Write<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AF")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C50EC", Offset = "0x8C50EC")]
	public void Write<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5100", Offset = "0x8C5100")]
	public void Write<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x1364220", Offset = "0x1364220", VA = "0x1364220")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5114", Offset = "0x8C5114")]
	public void WriteSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1364564", Offset = "0x1364564", VA = "0x1364564")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5128", Offset = "0x8C5128")]
	public void WriteICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1364914", Offset = "0x1364914", VA = "0x1364914")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C513C", Offset = "0x8C513C")]
	public void WriteIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002B4")]
	private void WriteEncrypted<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B5")]
	private void WriteEncrypted<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B6")]
	private void WriteEncrypted<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B7")]
	private void WriteEncrypted<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B8")]
	private void WriteEncrypted<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002B9")]
	private void WriteEncrypted<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002BA")]
	private void WriteEncrypted<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002BB")]
	private void WriteEncrypted<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002BC")]
	private void WriteEncrypted<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x1373814", Offset = "0x1373814", VA = "0x1373814")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5150", Offset = "0x8C5150")]
	private void WriteEncryptedSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x13739E0", Offset = "0x13739E0", VA = "0x13739E0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5164", Offset = "0x8C5164")]
	private void WriteEncryptedICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x1373BAC", Offset = "0x1373BAC", VA = "0x1373BAC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5178", Offset = "0x8C5178")]
	private void WriteEncryptedIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x1374048", Offset = "0x1374048", VA = "0x1374048")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C518C", Offset = "0x8C518C")]
	public void WriteHeader(ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x13740A4", Offset = "0x13740A4", VA = "0x13740A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C51A0", Offset = "0x8C51A0")]
	public void WriteHeader(string tag, ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x137431C", Offset = "0x137431C", VA = "0x137431C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C51B4", Offset = "0x8C51B4")]
	public void WriteLength()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x137443C", Offset = "0x137443C", VA = "0x137443C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C51C8", Offset = "0x8C51C8")]
	public void WriteTerminator()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x1373D8C", Offset = "0x1373D8C", VA = "0x1373D8C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C51DC", Offset = "0x8C51DC")]
	public ES2Writer CreateEncryptedWriter()
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x1373E4C", Offset = "0x1373E4C", VA = "0x1373E4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C51F0", Offset = "0x8C51F0")]
	public byte[] GetEncryptedBytes(string password)
	{
		return null;
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x137453C", Offset = "0x137453C", VA = "0x137453C", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x1374570", Offset = "0x1374570", VA = "0x1374570")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5204", Offset = "0x8C5204")]
	public bool Rename(string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C8")]
	public void Write<T>(T param, string tag)
	{
	}

	[Token(Token = "0x60002C9")]
	public void Write<T>(T[] param, string tag)
	{
	}

	[Token(Token = "0x60002CA")]
	public void Write<T>(T[,] param, string tag)
	{
	}

	[Token(Token = "0x60002CB")]
	public void Write<T>(T[,,] param, string tag)
	{
	}

	[Token(Token = "0x60002CC")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag)
	{
	}

	[Token(Token = "0x60002CD")]
	public void Write<T>(List<T> param, string tag)
	{
	}

	[Token(Token = "0x60002CE")]
	public void Write<T>(HashSet<T> param, string tag)
	{
	}

	[Token(Token = "0x60002CF")]
	public void Write<T>(Queue<T> param, string tag)
	{
	}

	[Token(Token = "0x60002D0")]
	public void Write<T>(Stack<T> param, string tag)
	{
	}

	[Token(Token = "0x60002D1")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5218", Offset = "0x8C5218")]
	public void Write<T>(T param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C522C", Offset = "0x8C522C")]
	public void Write<T>(T[] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5240", Offset = "0x8C5240")]
	public void Write<T>(T[,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5254", Offset = "0x8C5254")]
	public void Write<T>(T[,,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D5")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5268", Offset = "0x8C5268")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002D6")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C527C", Offset = "0x8C527C")]
	public void Write<T>(List<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D7")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5290", Offset = "0x8C5290")]
	public void Write<T>(HashSet<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C52A4", Offset = "0x8C52A4")]
	public void Write<T>(Queue<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D9")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C52B8", Offset = "0x8C52B8")]
	public void Write<T>(Stack<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002DA")]
	public void WriteProperty<T>(T property)
	{
	}

	[Token(Token = "0x60002DB")]
	public void WriteProperty<T>(T[] property)
	{
	}

	[Token(Token = "0x60002DC")]
	public void WriteProperty<T>(T[,] property)
	{
	}

	[Token(Token = "0x60002DD")]
	public void WriteProperty<T>(T[,,] property)
	{
	}

	[Token(Token = "0x60002DE")]
	public void WriteProperty<T>(List<T> property)
	{
	}

	[Token(Token = "0x60002DF")]
	public void WriteProperty<T>(Queue<T> property)
	{
	}

	[Token(Token = "0x60002E0")]
	public void WriteProperty<T>(Stack<T> property)
	{
	}

	[Token(Token = "0x60002E1")]
	public void WriteProperty<TKey, TValue>(Dictionary<TKey, TValue> property)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x13630B0", Offset = "0x13630B0", VA = "0x13630B0")]
	public int WritePropertyPrefix()
	{
		return default(int);
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1363B24", Offset = "0x1363B24", VA = "0x1363B24")]
	public void WritePropertyLength(int startPosition)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x1368B94", Offset = "0x1368B94", VA = "0x1368B94")]
	public void Save()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x135A134", Offset = "0x135A134", VA = "0x135A134")]
	public void Save(bool checkForOverwrite)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x13747F0", Offset = "0x13747F0", VA = "0x13747F0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C52CC", Offset = "0x8C52CC")]
	public void Save(byte[] bytes)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x13692B0", Offset = "0x13692B0", VA = "0x13692B0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C52E0", Offset = "0x8C52E0")]
	public bool Rename(string oldTag, string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x1368B24", Offset = "0x1368B24", VA = "0x1368B24")]
	public void Delete(string tag)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x13746C0", Offset = "0x13746C0", VA = "0x13746C0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C52F4", Offset = "0x8C52F4")]
	public bool Delete()
	{
		return default(bool);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x137482C", Offset = "0x137482C", VA = "0x137482C")]
	private bool Delete(byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1374964", Offset = "0x1374964", VA = "0x1374964")]
	public static ES2Writer Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x1361728", Offset = "0x1361728", VA = "0x1361728")]
	public static ES2Writer Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x135A058", Offset = "0x135A058", VA = "0x135A058")]
	public static ES2Writer Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1374474", Offset = "0x1374474", VA = "0x1374474")]
	public ES2Writer(ES2Settings settings)
	{
	}
}
[Token(Token = "0x2000053")]
public class ES3AutoSave : MonoBehaviour
{
	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool saveChildren;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool isQuitting;

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xF963AC", Offset = "0xF963AC", VA = "0xF963AC")]
	public void Awake()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xF96514", Offset = "0xF96514", VA = "0xF96514")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xF96520", Offset = "0xF96520", VA = "0xF96520")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xF9669C", Offset = "0xF9669C", VA = "0xF9669C")]
	public ES3AutoSave()
	{
	}
}
[Token(Token = "0x2000054")]
public class ES3AutoSaveMgr : MonoBehaviour, ISerializationCallbackReceiver
{
	[Token(Token = "0x200016C")]
	public enum LoadEvent
	{
		[Token(Token = "0x4000433")]
		None,
		[Token(Token = "0x4000434")]
		Awake,
		[Token(Token = "0x4000435")]
		Start
	}

	[Token(Token = "0x200016D")]
	public enum SaveEvent
	{
		[Token(Token = "0x4000437")]
		None,
		[Token(Token = "0x4000438")]
		OnApplicationQuit,
		[Token(Token = "0x4000439")]
		OnApplicationPause
	}

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ES3AutoSaveMgr _instance;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveEvent saveEvent;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LoadEvent loadEvent;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ES3SerializableSettings settings;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<ES3AutoSave> autoSaves;

	[Token(Token = "0x17000027")]
	public static ES3AutoSaveMgr Instance
	{
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xF966A4", Offset = "0xF966A4", VA = "0xF966A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xF967CC", Offset = "0xF967CC", VA = "0xF967CC")]
	public void Save()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xF969A8", Offset = "0xF969A8", VA = "0xF969A8")]
	public void Load()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xF96A4C", Offset = "0xF96A4C", VA = "0xF96A4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xF96A60", Offset = "0xF96A60", VA = "0xF96A60")]
	public void Awake()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xF96AE8", Offset = "0xF96AE8", VA = "0xF96AE8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xF96AFC", Offset = "0xF96AFC", VA = "0xF96AFC")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xF96410", Offset = "0xF96410", VA = "0xF96410")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xF96598", Offset = "0xF96598", VA = "0xF96598")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xF96B68", Offset = "0xF96B68", VA = "0xF96B68", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xF96B6C", Offset = "0xF96B6C", VA = "0xF96B6C", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xF96B70", Offset = "0xF96B70", VA = "0xF96B70")]
	public ES3AutoSaveMgr()
	{
	}
}
[Token(Token = "0x2000055")]
public static class ES3
{
	[Token(Token = "0x200016E")]
	public enum Location
	{
		[Token(Token = "0x400043B")]
		File,
		[Token(Token = "0x400043C")]
		PlayerPrefs,
		[Token(Token = "0x400043D")]
		Memory,
		[Token(Token = "0x400043E")]
		Resources
	}

	[Token(Token = "0x200016F")]
	public enum Directory
	{
		[Token(Token = "0x4000440")]
		PersistentDataPath,
		[Token(Token = "0x4000441")]
		DataPath
	}

	[Token(Token = "0x2000170")]
	public enum EncryptionType
	{
		[Token(Token = "0x4000443")]
		None,
		[Token(Token = "0x4000444")]
		AES
	}

	[Token(Token = "0x2000171")]
	public enum Format
	{
		[Token(Token = "0x4000446")]
		JSON
	}

	[Token(Token = "0x2000172")]
	public enum ReferenceMode
	{
		[Token(Token = "0x4000448")]
		ByRef,
		[Token(Token = "0x4000449")]
		ByValue,
		[Token(Token = "0x400044A")]
		ByRefAndValue
	}

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string backupFileSuffix;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string temporaryFileSuffix;

	[Token(Token = "0x6000300")]
	public static void Save<T>(string key, object value)
	{
	}

	[Token(Token = "0x6000301")]
	public static void Save<T>(string key, object value, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000302")]
	public static void Save<T>(string key, object value, string filePath)
	{
	}

	[Token(Token = "0x6000303")]
	public static void Save<T>(string key, object value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xF91564", Offset = "0xF91564", VA = "0xF91564")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xF91730", Offset = "0xF91730", VA = "0xF91730")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xF917C4", Offset = "0xF917C4", VA = "0xF917C4")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xF915E8", Offset = "0xF915E8", VA = "0xF915E8")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xF91E94", Offset = "0xF91E94", VA = "0xF91E94")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xF91FC8", Offset = "0xF91FC8", VA = "0xF91FC8")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xF9205C", Offset = "0xF9205C", VA = "0xF9205C")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xF91F18", Offset = "0xF91F18", VA = "0xF91F18")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xF920F8", Offset = "0xF920F8", VA = "0xF920F8")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xF92310", Offset = "0xF92310", VA = "0xF92310")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xF9217C", Offset = "0xF9217C", VA = "0xF9217C")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xF923AC", Offset = "0xF923AC", VA = "0xF923AC")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xF925F4", Offset = "0xF925F4", VA = "0xF925F4")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xF92430", Offset = "0xF92430", VA = "0xF92430")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xF92690", Offset = "0xF92690", VA = "0xF92690")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xF928A8", Offset = "0xF928A8", VA = "0xF928A8")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xF92724", Offset = "0xF92724", VA = "0xF92724")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000315")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000316")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x6000317")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000318")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000319")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600031A")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600031B")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600031C")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600031D")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x600031E")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x600031F")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000320")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xF929AC", Offset = "0xF929AC", VA = "0xF929AC")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xF92BA0", Offset = "0xF92BA0", VA = "0xF92BA0")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xF92C24", Offset = "0xF92C24", VA = "0xF92C24")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xF92A28", Offset = "0xF92A28", VA = "0xF92A28")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xF92CB8", Offset = "0xF92CB8", VA = "0xF92CB8")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xF92DEC", Offset = "0xF92DEC", VA = "0xF92DEC")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xF92E70", Offset = "0xF92E70", VA = "0xF92E70")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xF92D34", Offset = "0xF92D34", VA = "0xF92D34")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xF92F04", Offset = "0xF92F04", VA = "0xF92F04")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xF92FF0", Offset = "0xF92FF0", VA = "0xF92FF0")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xF92F88", Offset = "0xF92F88", VA = "0xF92F88")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xF93084", Offset = "0xF93084", VA = "0xF93084")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xF930FC", Offset = "0xF930FC", VA = "0xF930FC")]
	public static AudioClip LoadAudio(string audioFilePath)
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xF93180", Offset = "0xF93180", VA = "0xF93180")]
	public static AudioClip LoadAudio(string audioFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xF9341C", Offset = "0xF9341C", VA = "0xF9341C")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xF935E8", Offset = "0xF935E8", VA = "0xF935E8")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xF9366C", Offset = "0xF9366C", VA = "0xF9366C")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xF93498", Offset = "0xF93498", VA = "0xF93498")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xF9373C", Offset = "0xF9373C", VA = "0xF9373C")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xF939D8", Offset = "0xF939D8", VA = "0xF939D8")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xF937E8", Offset = "0xF937E8", VA = "0xF937E8")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xF93AAC", Offset = "0xF93AAC", VA = "0xF93AAC")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xF93D8C", Offset = "0xF93D8C", VA = "0xF93D8C")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xF93B58", Offset = "0xF93B58", VA = "0xF93B58")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xF93E58", Offset = "0xF93E58", VA = "0xF93E58")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xF94000", Offset = "0xF94000", VA = "0xF94000")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xF93EDC", Offset = "0xF93EDC", VA = "0xF93EDC")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xF940D4", Offset = "0xF940D4", VA = "0xF940D4")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xF94338", Offset = "0xF94338", VA = "0xF94338")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xF943CC", Offset = "0xF943CC", VA = "0xF943CC")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xF94158", Offset = "0xF94158", VA = "0xF94158")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xF945C4", Offset = "0xF945C4", VA = "0xF945C4")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xF947B0", Offset = "0xF947B0", VA = "0xF947B0")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xF94844", Offset = "0xF94844", VA = "0xF94844")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xF94648", Offset = "0xF94648", VA = "0xF94648")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xF948E0", Offset = "0xF948E0", VA = "0xF948E0")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xF9495C", Offset = "0xF9495C", VA = "0xF9495C")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xF949E0", Offset = "0xF949E0", VA = "0xF949E0")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xF94468", Offset = "0xF94468", VA = "0xF94468")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xF94A74", Offset = "0xF94A74", VA = "0xF94A74")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xF94C24", Offset = "0xF94C24", VA = "0xF94C24")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xF94AF8", Offset = "0xF94AF8", VA = "0xF94AF8")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xF94CC0", Offset = "0xF94CC0", VA = "0xF94CC0")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xF95178", Offset = "0xF95178", VA = "0xF95178")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xF951FC", Offset = "0xF951FC", VA = "0xF951FC")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xF94D3C", Offset = "0xF94D3C", VA = "0xF94D3C")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xF95290", Offset = "0xF95290", VA = "0xF95290")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xF953C8", Offset = "0xF953C8", VA = "0xF953C8")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xF9544C", Offset = "0xF9544C", VA = "0xF9544C")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xF9530C", Offset = "0xF9530C", VA = "0xF9530C")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xF9560C", Offset = "0xF9560C", VA = "0xF9560C")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xF95744", Offset = "0xF95744", VA = "0xF95744")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xF957C8", Offset = "0xF957C8", VA = "0xF957C8")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xF95688", Offset = "0xF95688", VA = "0xF95688")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xF95988", Offset = "0xF95988", VA = "0xF95988")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xF95AC8", Offset = "0xF95AC8", VA = "0xF95AC8")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xF95B4C", Offset = "0xF95B4C", VA = "0xF95B4C")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xF95A04", Offset = "0xF95A04", VA = "0xF95A04")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xF95BE0", Offset = "0xF95BE0", VA = "0xF95BE0")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xF95D5C", Offset = "0xF95D5C", VA = "0xF95D5C")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xF95C64", Offset = "0xF95C64", VA = "0xF95C64")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xF95DF0", Offset = "0xF95DF0", VA = "0xF95DF0")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xF95FBC", Offset = "0xF95FBC", VA = "0xF95FBC")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xF96040", Offset = "0xF96040", VA = "0xF96040")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xF95E6C", Offset = "0xF95E6C", VA = "0xF95E6C")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xF96160", Offset = "0xF96160", VA = "0xF96160")]
	public static void Init()
	{
	}
}
[Token(Token = "0x2000056")]
public class ES3File
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, ES3Data> cache;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool syncWithFile;

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xF9BDF8", Offset = "0xF9BDF8", VA = "0xF9BDF8")]
	public ES3File()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xF9C364", Offset = "0xF9C364", VA = "0xF9C364")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xF9C3DC", Offset = "0xF9C3DC", VA = "0xF9C3DC")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xF9C45C", Offset = "0xF9C45C", VA = "0xF9C45C")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xF9C464", Offset = "0xF9C464", VA = "0xF9C464")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xF9C4D8", Offset = "0xF9C4D8", VA = "0xF9C4D8")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xF9C554", Offset = "0xF9C554", VA = "0xF9C554")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xF9BE60", Offset = "0xF9BE60", VA = "0xF9BE60")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xF9C5E0", Offset = "0xF9C5E0", VA = "0xF9C5E0")]
	public ES3File(byte[] bytes)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xF9C654", Offset = "0xF9C654", VA = "0xF9C654")]
	public ES3File(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xF9CBC8", Offset = "0xF9CBC8", VA = "0xF9CBC8")]
	public void Sync()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xF9CF84", Offset = "0xF9CF84", VA = "0xF9CF84")]
	public void Sync(string filePath)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xF9CFF8", Offset = "0xF9CFF8", VA = "0xF9CFF8")]
	public void Sync(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xF9CBD0", Offset = "0xF9CBD0", VA = "0xF9CBD0")]
	public void Sync(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xF9A690", Offset = "0xF9A690", VA = "0xF9A690")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xF9D074", Offset = "0xF9D074", VA = "0xF9D074")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x6000374")]
	public void Save<T>(string key, object value)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xF9A6F0", Offset = "0xF9A6F0", VA = "0xF9A6F0")]
	public void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xF9C6E8", Offset = "0xF9C6E8", VA = "0xF9C6E8")]
	public void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000377")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000378")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000379")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xF97948", Offset = "0xF97948", VA = "0xF97948")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xF9D140", Offset = "0xF9D140", VA = "0xF9D140")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xF9D200", Offset = "0xF9D200", VA = "0xF9D200")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xF9D270", Offset = "0xF9D270", VA = "0xF9D270")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xF9D2E0", Offset = "0xF9D2E0", VA = "0xF9D2E0")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xF9D44C", Offset = "0xF9D44C", VA = "0xF9D44C")]
	public Type GetKeyType(string key)
	{
		return null;
	}
}
[Token(Token = "0x2000057")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x6000380")]
	[Address(RVA = "0xF9D550", Offset = "0xF9D550", VA = "0xF9D550")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000058")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase, ISerializationCallbackReceiver
{
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x143266C", Offset = "0x143266C", VA = "0x143266C", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x1432670", Offset = "0x1432670", VA = "0x1432670", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x1432674", Offset = "0x1432674", VA = "0x1432674")]
	public ES3ReferenceMgr()
	{
	}
}
[Token(Token = "0x2000059")]
public class ES3Spreadsheet
{
	[Token(Token = "0x2000173")]
	protected struct Index
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int col;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int row;

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x9AECCC", Offset = "0x9AECCC", VA = "0x9AECCC")]
		public Index(int col, int row)
		{
		}
	}

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int cols;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int rows;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Index, string> cells;

	[Token(Token = "0x40000D7")]
	private const string QUOTE = "\"";

	[Token(Token = "0x40000D8")]
	private const char QUOTE_CHAR = '"';

	[Token(Token = "0x40000D9")]
	private const char COMMA_CHAR = ',';

	[Token(Token = "0x40000DA")]
	private const char NEWLINE_CHAR = '\n';

	[Token(Token = "0x40000DB")]
	private const string ESCAPED_QUOTE = "\"\"";

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static char[] CHARS_TO_ESCAPE;

	[Token(Token = "0x17000028")]
	public int ColumnCount
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1433058", Offset = "0x1433058", VA = "0x1433058")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000029")]
	public int RowCount
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1433060", Offset = "0x1433060", VA = "0x1433060")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000386")]
	public void SetCell<T>(int col, int row, object value)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x1433068", Offset = "0x1433068", VA = "0x1433068")]
	private void SetCell(int col, int row, string value)
	{
	}

	[Token(Token = "0x6000388")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1433124", Offset = "0x1433124", VA = "0x1433124")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x14331D8", Offset = "0x14331D8", VA = "0x14331D8")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x14331A4", Offset = "0x14331A4", VA = "0x14331A4")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x14334E0", Offset = "0x14334E0", VA = "0x14334E0")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x14335B4", Offset = "0x14335B4", VA = "0x14335B4")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x1433260", Offset = "0x1433260", VA = "0x1433260")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x1433668", Offset = "0x1433668", VA = "0x1433668")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x1433A24", Offset = "0x1433A24", VA = "0x1433A24")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1433AA0", Offset = "0x1433AA0", VA = "0x1433AA0")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1433AA8", Offset = "0x1433AA8", VA = "0x1433AA8")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x1433B20", Offset = "0x1433B20", VA = "0x1433B20")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x14336DC", Offset = "0x14336DC", VA = "0x14336DC")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x1433DBC", Offset = "0x1433DBC", VA = "0x1433DBC")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x1433EE0", Offset = "0x1433EE0", VA = "0x1433EE0")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x1433BA8", Offset = "0x1433BA8", VA = "0x1433BA8")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x1434014", Offset = "0x1434014", VA = "0x1434014")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x200005A")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000174")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3AC4", Offset = "0x8C3AC4")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x20001A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3BEC", Offset = "0x8C3BEC")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderPropertyEnumerator <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C0")]
				[Address(RVA = "0x1432340", Offset = "0x1432340", VA = "0x1432340", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C2")]
				[Address(RVA = "0x14323B0", Offset = "0x14323B0", VA = "0x14323B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x143223C", Offset = "0x143223C", VA = "0x143223C")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x1432268", Offset = "0x1432268", VA = "0x1432268", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x143226C", Offset = "0x143226C", VA = "0x143226C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x1432348", Offset = "0x1432348", VA = "0x1432348", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x14316F0", Offset = "0x14316F0", VA = "0x14316F0")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x14321C8", Offset = "0x14321C8", VA = "0x14321C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C5E1C", Offset = "0x8C5E1C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3AD8", Offset = "0x8C3AD8")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3BFC", Offset = "0x8C3BFC")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderRawEnumerator <>4__this;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C6")]
				[Address(RVA = "0x14325F4", Offset = "0x14325F4", VA = "0x14325F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C8")]
				[Address(RVA = "0x1432664", Offset = "0x1432664", VA = "0x1432664", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x143242C", Offset = "0x143242C", VA = "0x143242C")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x1432458", Offset = "0x1432458", VA = "0x1432458", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x143245C", Offset = "0x143245C", VA = "0x143245C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x14325FC", Offset = "0x14325FC", VA = "0x14325FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x1431780", Offset = "0x1431780", VA = "0x1431780")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x14323B8", Offset = "0x14323B8", VA = "0x14323B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C5E80", Offset = "0x8C5E80")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal string overridePropertiesName;

	[Token(Token = "0x1700002A")]
	public virtual ES3ReaderPropertyEnumerator Properties
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x143168C", Offset = "0x143168C", VA = "0x143168C", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x143171C", Offset = "0x143171C", VA = "0x143171C", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600039A")]
	internal abstract int Read_int();

	[Token(Token = "0x600039B")]
	internal abstract float Read_float();

	[Token(Token = "0x600039C")]
	internal abstract bool Read_bool();

	[Token(Token = "0x600039D")]
	internal abstract char Read_char();

	[Token(Token = "0x600039E")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x600039F")]
	internal abstract double Read_double();

	[Token(Token = "0x60003A0")]
	internal abstract long Read_long();

	[Token(Token = "0x60003A1")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x60003A2")]
	internal abstract byte Read_byte();

	[Token(Token = "0x60003A3")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x60003A4")]
	internal abstract short Read_short();

	[Token(Token = "0x60003A5")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x60003A6")]
	internal abstract uint Read_uint();

	[Token(Token = "0x60003A7")]
	internal abstract string Read_string();

	[Token(Token = "0x60003A8")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x60003A9")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5308", Offset = "0x8C5308")]
	public abstract string ReadPropertyName();

	[Token(Token = "0x60003AA")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x60003AB")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x60003AC")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x60003AD")]
	internal abstract bool Goto(string key);

	[Token(Token = "0x60003AE")]
	public abstract void Dispose();

	[Token(Token = "0x60003AF")]
	internal abstract bool StartReadObject();

	[Token(Token = "0x60003B0")]
	internal abstract void EndReadObject();

	[Token(Token = "0x60003B1")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x60003B2")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x60003B3")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x60003B4")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x60003B5")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x60003B6")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x60003B7")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x60003B8")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x60003B9")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x60003BA")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x1431660", Offset = "0x1431660", VA = "0x1431660")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x14317AC", Offset = "0x14317AC", VA = "0x14317AC", Slot = "40")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C531C", Offset = "0x8C531C")]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x60003BF")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x60003C0")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x60003C1")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5330", Offset = "0x8C5330")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x60003C2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5344", Offset = "0x8C5344")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x14317C0", Offset = "0x14317C0", VA = "0x14317C0")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x14318BC", Offset = "0x14318BC", VA = "0x14318BC")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x1431AD4", Offset = "0x1431AD4", VA = "0x1431AD4")]
	public void SetPrivateField(string name, object value, object objectContainingField)
	{
	}

	[Token(Token = "0x60003C6")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60003C7")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60003C8")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60003C9")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x60003CA")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x60003CB")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5358", Offset = "0x8C5358")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x60003CC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C536C", Offset = "0x8C536C")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x60003CD")]
	private Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1431CEC", Offset = "0x1431CEC", VA = "0x1431CEC")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1431E2C", Offset = "0x1431E2C", VA = "0x1431E2C")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x1431EB4", Offset = "0x1431EB4", VA = "0x1431EB4")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x1431D84", Offset = "0x1431D84", VA = "0x1431D84")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x1431F84", Offset = "0x1431F84", VA = "0x1431F84")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x1431FE4", Offset = "0x1431FE4", VA = "0x1431FE4")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x143209C", Offset = "0x143209C", VA = "0x143209C")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x1432130", Offset = "0x1432130", VA = "0x1432130")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x200005B")]
public class ES3Settings : ICloneable
{
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES3Settings _defaults;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private ES3.Location _location;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ES3.EncryptionType encryptionType;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string encryptionPassword;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES3.Directory directory;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ES3.Format format;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int bufferSize;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C401C", Offset = "0x8C401C")]
	public bool typeChecking;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4030", Offset = "0x8C4030")]
	public bool safeReflection;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4044", Offset = "0x8C4044")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C4058", Offset = "0x8C4058")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C406C", Offset = "0x8C406C")]
	public string[] assemblyNames;

	[Token(Token = "0x1700002C")]
	public ES3.Location location
	{
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1432820", Offset = "0x1432820", VA = "0x1432820")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1432860", Offset = "0x1432860", VA = "0x1432860")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public string FullPath
	{
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1432CDC", Offset = "0x1432CDC", VA = "0x1432CDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x1432868", Offset = "0x1432868", VA = "0x1432868")]
	private void CopyInto(ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x1431D44", Offset = "0x1431D44", VA = "0x1431D44")]
	public ES3Settings()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x1431E8C", Offset = "0x1431E8C", VA = "0x1431E8C")]
	public ES3Settings(string path)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x1431F24", Offset = "0x1431F24", VA = "0x1431F24")]
	public ES3Settings(string path, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x1432A9C", Offset = "0x1432A9C", VA = "0x1432A9C")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x1432AD4", Offset = "0x1432AD4", VA = "0x1432AD4")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x1432B14", Offset = "0x1432B14", VA = "0x1432B14")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x1432758", Offset = "0x1432758", VA = "0x1432758")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5380", Offset = "0x8C5380")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x14329DC", Offset = "0x14329DC", VA = "0x14329DC")]
	protected void ApplyDefaults()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x1432B50", Offset = "0x1432B50", VA = "0x1432B50")]
	internal static void LoadDefaults()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x1432F08", Offset = "0x1432F08", VA = "0x1432F08")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x1432FEC", Offset = "0x1432FEC", VA = "0x1432FEC", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5394", Offset = "0x8C5394")]
	public object Clone()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200005C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BD48C", Offset = "0x8BD48C")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x14326DC", Offset = "0x14326DC", VA = "0x14326DC")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x14327AC", Offset = "0x14327AC", VA = "0x14327AC")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}
}
[Token(Token = "0x200005D")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3AEC", Offset = "0x8C3AEC")]
	private sealed class <Sync>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0xF9B938", Offset = "0xF9B938", VA = "0xF9B938", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0xF9B9A8", Offset = "0xF9B9A8", VA = "0xF9B9A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xF97428", Offset = "0xF97428", VA = "0xF97428")]
		[DebuggerHidden]
		public <Sync>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xF9B794", Offset = "0xF9B794", VA = "0xF9B794", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xF9B798", Offset = "0xF9B798", VA = "0xF9B798", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xF9B940", Offset = "0xF9B940", VA = "0xF9B940", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3AFC", Offset = "0x8C3AFC")]
	private sealed class <UploadFile>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte[] bytes;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0xF9BD80", Offset = "0xF9BD80", VA = "0xF9BD80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0xF9BDF0", Offset = "0xF9BDF0", VA = "0xF9BDF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xF980C0", Offset = "0xF980C0", VA = "0xF980C0")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xF9B9B0", Offset = "0xF9B9B0", VA = "0xF9B9B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xF9BA8C", Offset = "0xF9BA8C", VA = "0xF9BA8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xF9B9CC", Offset = "0xF9B9CC", VA = "0xF9B9CC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xF9BD88", Offset = "0xF9BD88", VA = "0xF9BD88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B0C", Offset = "0x8C3B0C")]
	private sealed class <DownloadFile>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3File es3File;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0xF9A6F8", Offset = "0xF9A6F8", VA = "0xF9A6F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0xF9A768", Offset = "0xF9A768", VA = "0xF9A768", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xF98768", Offset = "0xF98768", VA = "0xF98768")]
		[DebuggerHidden]
		public <DownloadFile>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xF9A204", Offset = "0xF9A204", VA = "0xF9A204", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xF9A2E0", Offset = "0xF9A2E0", VA = "0xF9A2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xF9A220", Offset = "0xF9A220", VA = "0xF9A220")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xF9A700", Offset = "0xF9A700", VA = "0xF9A700", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B1C", Offset = "0x8C3B1C")]
	private sealed class <DownloadFile>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0xF9ABCC", Offset = "0xF9ABCC", VA = "0xF9ABCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0xF9AC3C", Offset = "0xF9AC3C", VA = "0xF9AC3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xF98794", Offset = "0xF98794", VA = "0xF98794")]
		[DebuggerHidden]
		public <DownloadFile>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xF9A770", Offset = "0xF9A770", VA = "0xF9A770", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xF9A84C", Offset = "0xF9A84C", VA = "0xF9A84C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xF9A78C", Offset = "0xF9A78C", VA = "0xF9A78C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xF9ABD4", Offset = "0xF9ABD4", VA = "0xF9ABD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B2C", Offset = "0x8C3B2C")]
	private sealed class <DeleteFile>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700007C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0xF9A18C", Offset = "0xF9A18C", VA = "0xF9A18C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0xF9A1FC", Offset = "0xF9A1FC", VA = "0xF9A1FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xF98C50", Offset = "0xF98C50", VA = "0xF98C50")]
		[DebuggerHidden]
		public <DeleteFile>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xF999AC", Offset = "0xF999AC", VA = "0xF999AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xF99A88", Offset = "0xF99A88", VA = "0xF99A88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xF999C8", Offset = "0xF999C8", VA = "0xF999C8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xF9A194", Offset = "0xF9A194", VA = "0xF9A194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B3C", Offset = "0x8C3B3C")]
	private sealed class <RenameFile>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Settings newSettings;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700007E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0xF9B71C", Offset = "0xF9B71C", VA = "0xF9B71C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0xF9B78C", Offset = "0xF9B78C", VA = "0xF9B78C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xF991A8", Offset = "0xF991A8", VA = "0xF991A8")]
		[DebuggerHidden]
		public <RenameFile>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xF9B3DC", Offset = "0xF9B3DC", VA = "0xF9B3DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xF9B4B8", Offset = "0xF9B4B8", VA = "0xF9B4B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xF9B3F8", Offset = "0xF9B3F8", VA = "0xF9B3F8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xF9B724", Offset = "0xF9B724", VA = "0xF9B724", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B4C", Offset = "0x8C3B4C")]
	private sealed class <DownloadFilenames>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000080")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0xF9AF90", Offset = "0xF9AF90", VA = "0xF9AF90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0xF9B000", Offset = "0xF9B000", VA = "0xF9B000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xF99334", Offset = "0xF99334", VA = "0xF99334")]
		[DebuggerHidden]
		public <DownloadFilenames>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xF9AC44", Offset = "0xF9AC44", VA = "0xF9AC44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xF9AD20", Offset = "0xF9AD20", VA = "0xF9AD20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xF9AC60", Offset = "0xF9AC60", VA = "0xF9AC60")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xF9AF98", Offset = "0xF9AF98", VA = "0xF9AF98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B5C", Offset = "0x8C3B5C")]
	private sealed class <DownloadTimestamp>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000082")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0xF9B364", Offset = "0xF9B364", VA = "0xF9B364", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0xF9B3D4", Offset = "0xF9B3D4", VA = "0xF9B3D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xF997F0", Offset = "0xF997F0", VA = "0xF997F0")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xF9B008", Offset = "0xF9B008", VA = "0xF9B008", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xF9B0E4", Offset = "0xF9B0E4", VA = "0xF9B0E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xF9B024", Offset = "0xF9B024", VA = "0xF9B024")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xF9B36C", Offset = "0xF9B36C", VA = "0xF9B36C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private byte[] _data;

	[Token(Token = "0x1700002E")]
	public byte[] data
	{
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xF96CD8", Offset = "0xF96CD8", VA = "0xF96CD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002F")]
	public string text
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xF96CE0", Offset = "0xF96CE0", VA = "0xF96CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	public string[] filenames
	{
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xF96D34", Offset = "0xF96D34", VA = "0xF96D34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000031")]
	public DateTime timestamp
	{
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xF96E08", Offset = "0xF96E08", VA = "0xF96E08")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xF96C0C", Offset = "0xF96C0C", VA = "0xF96C0C")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xF96F98", Offset = "0xF96F98", VA = "0xF96F98")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xF970D8", Offset = "0xF970D8", VA = "0xF970D8")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xF9715C", Offset = "0xF9715C", VA = "0xF9715C")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xF971E4", Offset = "0xF971E4", VA = "0xF971E4")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xF97270", Offset = "0xF97270", VA = "0xF97270")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xF972FC", Offset = "0xF972FC", VA = "0xF972FC")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xF97394", Offset = "0xF97394", VA = "0xF97394")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xF9700C", Offset = "0xF9700C", VA = "0xF9700C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C53A8", Offset = "0x8C53A8")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xF97454", Offset = "0xF97454", VA = "0xF97454")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xF97560", Offset = "0xF97560", VA = "0xF97560")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xF975E4", Offset = "0xF975E4", VA = "0xF975E4")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xF9766C", Offset = "0xF9766C", VA = "0xF9766C")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xF976F8", Offset = "0xF976F8", VA = "0xF976F8")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xF97784", Offset = "0xF97784", VA = "0xF97784")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xF9781C", Offset = "0xF9781C", VA = "0xF9781C")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xF978B0", Offset = "0xF978B0", VA = "0xF978B0")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xF97FA8", Offset = "0xF97FA8", VA = "0xF97FA8")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xF98044", Offset = "0xF98044", VA = "0xF98044")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xF974C8", Offset = "0xF974C8", VA = "0xF974C8")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xF97EC4", Offset = "0xF97EC4", VA = "0xF97EC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C540C", Offset = "0x8C540C")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xF980EC", Offset = "0xF980EC", VA = "0xF980EC")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xF98244", Offset = "0xF98244", VA = "0xF98244")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xF982CC", Offset = "0xF982CC", VA = "0xF982CC")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xF98358", Offset = "0xF98358", VA = "0xF98358")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xF983E8", Offset = "0xF983E8", VA = "0xF983E8")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xF98478", Offset = "0xF98478", VA = "0xF98478")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xF98514", Offset = "0xF98514", VA = "0xF98514")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xF985AC", Offset = "0xF985AC", VA = "0xF985AC")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xF986F4", Offset = "0xF986F4", VA = "0xF986F4")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xF98760", Offset = "0xF98760", VA = "0xF98760")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xF98614", Offset = "0xF98614", VA = "0xF98614")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C5470", Offset = "0x8C5470")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xF98164", Offset = "0xF98164", VA = "0xF98164")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C54D4", Offset = "0x8C54D4")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xF987C0", Offset = "0xF987C0", VA = "0xF987C0")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xF98900", Offset = "0xF98900", VA = "0xF98900")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xF98984", Offset = "0xF98984", VA = "0xF98984")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xF98A0C", Offset = "0xF98A0C", VA = "0xF98A0C")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xF98A98", Offset = "0xF98A98", VA = "0xF98A98")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xF98B24", Offset = "0xF98B24", VA = "0xF98B24")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xF98BBC", Offset = "0xF98BBC", VA = "0xF98BBC")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xF98834", Offset = "0xF98834", VA = "0xF98834")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C5538", Offset = "0x8C5538")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xF98C7C", Offset = "0xF98C7C", VA = "0xF98C7C")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xF98E08", Offset = "0xF98E08", VA = "0xF98E08")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xF98EB8", Offset = "0xF98EB8", VA = "0xF98EB8")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xF98F6C", Offset = "0xF98F6C", VA = "0xF98F6C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xF99024", Offset = "0xF99024", VA = "0xF99024")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xF990E8", Offset = "0xF990E8", VA = "0xF990E8")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xF98D28", Offset = "0xF98D28", VA = "0xF98D28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C559C", Offset = "0x8C559C")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xF991D4", Offset = "0xF991D4", VA = "0xF991D4")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xF992D4", Offset = "0xF992D4", VA = "0xF992D4")]
	public IEnumerator DownloadFilenames(string user)
	{
		return null;
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0xF99228", Offset = "0xF99228", VA = "0xF99228")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C5600", Offset = "0x8C5600")]
	public IEnumerator DownloadFilenames(string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0xF99360", Offset = "0xF99360", VA = "0xF99360")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0xF994A0", Offset = "0xF994A0", VA = "0xF994A0")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xF99524", Offset = "0xF99524", VA = "0xF99524")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xF995AC", Offset = "0xF995AC", VA = "0xF995AC")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xF99638", Offset = "0xF99638", VA = "0xF99638")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xF996C4", Offset = "0xF996C4", VA = "0xF996C4")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0xF9975C", Offset = "0xF9975C", VA = "0xF9975C")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0xF993D4", Offset = "0xF993D4", VA = "0xF993D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C5664", Offset = "0x8C5664")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xF9981C", Offset = "0xF9981C", VA = "0xF9981C")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xF99924", Offset = "0xF99924", VA = "0xF99924")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xF99990", Offset = "0xF99990", VA = "0xF99990", Slot = "4")]
	protected override void Reset()
	{
	}
}
[Token(Token = "0x200005E")]
public abstract class ES3Writer : IDisposable
{
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HashSet<string> keysToDelete;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool writeHeaderAndFooter;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	internal bool overwriteKeys;

	[Token(Token = "0x600042A")]
	internal abstract void WriteNull();

	[Token(Token = "0x600042B")]
	internal abstract void StartWriteFile();

	[Token(Token = "0x600042C")]
	internal abstract void EndWriteFile();

	[Token(Token = "0x600042D")]
	internal abstract void StartWriteObject(string name);

	[Token(Token = "0x600042E")]
	internal abstract void EndWriteObject(string name);

	[Token(Token = "0x600042F")]
	internal abstract void StartWriteProperty(string name);

	[Token(Token = "0x6000430")]
	internal abstract void EndWriteProperty(string name);

	[Token(Token = "0x6000431")]
	internal abstract void StartWriteCollection(int length);

	[Token(Token = "0x6000432")]
	internal abstract void EndWriteCollection();

	[Token(Token = "0x6000433")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x6000434")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x6000435")]
	internal abstract void StartWriteDictionary(int length);

	[Token(Token = "0x6000436")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x6000437")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x6000438")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x6000439")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x600043A")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x600043B")]
	public abstract void Dispose();

	[Token(Token = "0x600043C")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x600043D")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x600043E")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x600043F")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x6000440")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x6000441")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x6000442")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x6000443")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x6000444")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x6000445")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x6000446")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x6000447")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x6000448")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x6000449")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x600044A")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x600044B")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x600044C")]
	[Address(RVA = "0xFCF078", Offset = "0xFCF078", VA = "0xFCF078")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x600044D")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0xFCF124", Offset = "0xFCF124", VA = "0xFCF124", Slot = "40")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0xFCF280", Offset = "0xFCF280", VA = "0xFCF280", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C56C8", Offset = "0x8C56C8")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0xFCF3A8", Offset = "0xFCF3A8", VA = "0xFCF3A8", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C56DC", Offset = "0x8C56DC")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0xFCF478", Offset = "0xFCF478", VA = "0xFCF478", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C56F0", Offset = "0x8C56F0")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0xFCF9C8", Offset = "0xFCF9C8", VA = "0xFCF9C8", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0xFCFB40", Offset = "0xFCFB40", VA = "0xFCFB40", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0xFCFB9C", Offset = "0xFCFB9C", VA = "0xFCFB9C", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xFCFBEC", Offset = "0xFCFBEC", VA = "0xFCFBEC", Slot = "47")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5704", Offset = "0x8C5704")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xFCFC50", Offset = "0xFCFC50", VA = "0xFCFC50", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5718", Offset = "0x8C5718")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000457")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xFC6628", Offset = "0xFC6628", VA = "0xFC6628")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C572C", Offset = "0x8C572C")]
	public void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xFCFCA8", Offset = "0xFCFCA8", VA = "0xFCFCA8")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xFCFF24", Offset = "0xFCFF24", VA = "0xFCFF24")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0xFD01A0", Offset = "0xFD01A0", VA = "0xFD01A0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5740", Offset = "0x8C5740")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0xFD03E0", Offset = "0xFD03E0", VA = "0xFD03E0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5754", Offset = "0x8C5754")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0xFD0620", Offset = "0xFD0620", VA = "0xFD0620")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5768", Offset = "0x8C5768")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0xFD08C8", Offset = "0xFD08C8", VA = "0xFD08C8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C577C", Offset = "0x8C577C")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0xFCF1E8", Offset = "0xFCF1E8", VA = "0xFCF1E8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C5790", Offset = "0x8C5790")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0xFD0B70", Offset = "0xFD0B70", VA = "0xFD0B70")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0xFD0BF0", Offset = "0xFD0BF0", VA = "0xFD0BF0")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0xFD0C00", Offset = "0xFD0C00", VA = "0xFD0C00")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0xFD0C60", Offset = "0xFD0C60", VA = "0xFD0C60")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0xFD0E30", Offset = "0xFD0E30", VA = "0xFD0E30", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C57A4", Offset = "0x8C57A4")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0xFD0EA0", Offset = "0xFD0EA0", VA = "0xFD0EA0")]
	protected void Merge()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xFD0FF0", Offset = "0xFD0FF0", VA = "0xFD0FF0")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xFD1338", Offset = "0xFD1338", VA = "0xFD1338", Slot = "51")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xFD134C", Offset = "0xFD134C", VA = "0xFD134C", Slot = "52")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200005F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD4A0", Offset = "0x8BD4A0")]
public class CurrentTime : MonoBehaviour
{
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MusicPlayer musicPlayer;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text m_Text;

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x1359848", Offset = "0x1359848", VA = "0x1359848")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x13598A0", Offset = "0x13598A0", VA = "0x13598A0")]
	private void Update()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x1359A34", Offset = "0x1359A34", VA = "0x1359A34")]
	public CurrentTime()
	{
	}
}
[Token(Token = "0x2000060")]
public class MusicVolumeControl : MonoBehaviour
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MusicPlayer m_MusicPlayer;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioMixer m_MasterMixer;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_MusicVolumeParameter;

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xFD553C", Offset = "0xFD553C", VA = "0xFD553C")]
	public void SetMusicVolume(float attenuation)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xFD5580", Offset = "0xFD5580", VA = "0xFD5580")]
	public MusicVolumeControl()
	{
	}
}
[Token(Token = "0x2000061")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD504", Offset = "0x8BD504")]
public class NowPlaying : MonoBehaviour
{
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Text;

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xFD55D8", Offset = "0xFD55D8", VA = "0xFD55D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xFD5630", Offset = "0xFD5630", VA = "0xFD5630")]
	public void OnPlay(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xFD5688", Offset = "0xFD5688", VA = "0xFD5688")]
	public void OnStop(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xFD56F4", Offset = "0xFD56F4", VA = "0xFD56F4")]
	public void OnPause(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xFD5760", Offset = "0xFD5760", VA = "0xFD5760")]
	public void OnUnPause(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xFD57B8", Offset = "0xFD57B8", VA = "0xFD57B8")]
	public void OnTrackChange(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xFD5810", Offset = "0xFD5810", VA = "0xFD5810")]
	public NowPlaying()
	{
	}
}
[Token(Token = "0x2000062")]
public class PlaylistList : MonoBehaviour
{
	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B6C", Offset = "0x8C3B6C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Playlist p2;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlaylistList <>4__this;

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xFD5CB0", Offset = "0xFD5CB0", VA = "0xFD5CB0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xFD5CC0", Offset = "0xFD5CC0", VA = "0xFD5CC0")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MusicPlayer musicPlayer;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject playlist;

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xFD5818", Offset = "0xFD5818", VA = "0xFD5818")]
	private void Start()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xFD5CB8", Offset = "0xFD5CB8", VA = "0xFD5CB8")]
	public PlaylistList()
	{
	}
}
[Token(Token = "0x2000063")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD568", Offset = "0x8BD568")]
public class Seek : MonoBehaviour
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MusicPlayer musicPlayer;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Slider m_Slider;

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xFD5D0C", Offset = "0xFD5D0C", VA = "0xFD5D0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xFD5D64", Offset = "0xFD5D64", VA = "0xFD5D64")]
	private void Update()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xFD5DFC", Offset = "0xFD5DFC", VA = "0xFD5DFC")]
	public void OnEndDrag(BaseEventData eventData)
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xFD5E58", Offset = "0xFD5E58", VA = "0xFD5E58")]
	public Seek()
	{
	}
}
[Token(Token = "0x2000064")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD5CC", Offset = "0x8BD5CC")]
public class TrackLength : MonoBehaviour
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text m_Text;

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xFD5E60", Offset = "0xFD5E60", VA = "0xFD5E60")]
	private void Awake()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xFD5EE0", Offset = "0xFD5EE0", VA = "0xFD5EE0")]
	public void OnTrackChange(MusicPlayer player)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xFD606C", Offset = "0xFD606C", VA = "0xFD606C")]
	public TrackLength()
	{
	}
}
[Token(Token = "0x2000065")]
public class TrackList : MonoBehaviour
{
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B7C", Offset = "0x8C3B7C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Playlist currentPlaylist;

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xFD6744", Offset = "0xFD6744", VA = "0xFD6744")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xFD675C", Offset = "0xFD675C", VA = "0xFD675C")]
		internal void <PlaylistChange>b__0(bool on)
		{
		}
	}

	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B8C", Offset = "0x8C3B8C")]
	private sealed class <>c__DisplayClass3_1
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Track t2;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject to;

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xFD674C", Offset = "0xFD674C", VA = "0xFD674C")]
		public <>c__DisplayClass3_1()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xFD6790", Offset = "0xFD6790", VA = "0xFD6790")]
		internal void <PlaylistChange>b__1(bool on)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xFD67C4", Offset = "0xFD67C4", VA = "0xFD67C4")]
		internal void <PlaylistChange>b__2(MusicPlayer <p0>)
		{
		}
	}

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text title;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject track;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Toggle shuffle;

	[Token(Token = "0x600047E")]
	[Address(RVA = "0xFD6074", Offset = "0xFD6074", VA = "0xFD6074")]
	public void PlaylistChange(MusicPlayer player)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0xFD6754", Offset = "0xFD6754", VA = "0xFD6754")]
	public TrackList()
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000066")]
	public enum AAMode
	{
		[Token(Token = "0x4000102")]
		FXAA2,
		[Token(Token = "0x4000103")]
		FXAA3Console,
		[Token(Token = "0x4000104")]
		FXAA1PresetA,
		[Token(Token = "0x4000105")]
		FXAA1PresetB,
		[Token(Token = "0x4000106")]
		NFAA,
		[Token(Token = "0x4000107")]
		SSAA,
		[Token(Token = "0x4000108")]
		DLAA
	}
	[Token(Token = "0x2000067")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD630", Offset = "0x8BD630")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BD630", Offset = "0x8BD630")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xFD6830", Offset = "0xFD6830", VA = "0xFD6830")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xFD6894", Offset = "0xFD6894", VA = "0xFD6894", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xFD6984", Offset = "0xFD6984", VA = "0xFD6984")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xFD6F84", Offset = "0xFD6F84", VA = "0xFD6F84")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD6C8", Offset = "0x8BD6C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BD6C8", Offset = "0x8BD6C8")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000181")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x400048F")]
			Ghosting,
			[Token(Token = "0x4000490")]
			Anamorphic,
			[Token(Token = "0x4000491")]
			Combined
		}

		[Token(Token = "0x2000182")]
		public enum TweakMode
		{
			[Token(Token = "0x4000493")]
			Basic,
			[Token(Token = "0x4000494")]
			Complex
		}

		[Token(Token = "0x2000183")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000496")]
			Auto,
			[Token(Token = "0x4000497")]
			On,
			[Token(Token = "0x4000498")]
			Off
		}

		[Token(Token = "0x2000184")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x400049A")]
			Screen,
			[Token(Token = "0x400049B")]
			Add
		}

		[Token(Token = "0x2000185")]
		public enum BloomQuality
		{
			[Token(Token = "0x400049D")]
			Cheap,
			[Token(Token = "0x400049E")]
			High
		}

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xFD6FA8", Offset = "0xFD6FA8", VA = "0xFD6FA8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xFD7048", Offset = "0xFD7048", VA = "0xFD7048")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xFD8678", Offset = "0xFD8678", VA = "0xFD8678")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xFD83CC", Offset = "0xFD83CC", VA = "0xFD83CC")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xFD80BC", Offset = "0xFD80BC", VA = "0xFD80BC")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xFD7FB4", Offset = "0xFD7FB4", VA = "0xFD7FB4")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xFD81AC", Offset = "0xFD81AC", VA = "0xFD81AC")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xFD8750", Offset = "0xFD8750", VA = "0xFD8750")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x400013E")]
		Ghosting,
		[Token(Token = "0x400013F")]
		Anamorphic,
		[Token(Token = "0x4000140")]
		Combined
	}
	[Token(Token = "0x200006A")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000142")]
		Basic,
		[Token(Token = "0x4000143")]
		Complex
	}
	[Token(Token = "0x200006B")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000145")]
		Auto,
		[Token(Token = "0x4000146")]
		On,
		[Token(Token = "0x4000147")]
		Off
	}
	[Token(Token = "0x200006C")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000149")]
		Screen,
		[Token(Token = "0x400014A")]
		Add
	}
	[Token(Token = "0x200006D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD760", Offset = "0x8BD760")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BD760", Offset = "0x8BD760")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xFD88D0", Offset = "0xFD88D0", VA = "0xFD88D0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xFD89AC", Offset = "0xFD89AC", VA = "0xFD89AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xFD9BA4", Offset = "0xFD9BA4", VA = "0xFD9BA4")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xFD9910", Offset = "0xFD9910", VA = "0xFD9910")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xFD9660", Offset = "0xFD9660", VA = "0xFD9660")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xFD9798", Offset = "0xFD9798", VA = "0xFD9798")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xFD9C60", Offset = "0xFD9C60", VA = "0xFD9C60")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD7F8", Offset = "0x8BD7F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BD7F8", Offset = "0x8BD7F8")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000186")]
		public enum Resolution
		{
			[Token(Token = "0x40004A0")]
			Low,
			[Token(Token = "0x40004A1")]
			High
		}

		[Token(Token = "0x2000187")]
		public enum BlurType
		{
			[Token(Token = "0x40004A3")]
			Standard,
			[Token(Token = "0x40004A4")]
			Sgx
		}

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C40B0", Offset = "0x8C40B0")]
		public float threshold;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C40C8", Offset = "0x8C40C8")]
		public float intensity;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C40E0", Offset = "0x8C40E0")]
		public float blurSize;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C40F8", Offset = "0x8C40F8")]
		public int blurIterations;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xFD9DCC", Offset = "0xFD9DCC", VA = "0xFD9DCC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xFD9E30", Offset = "0xFD9E30", VA = "0xFD9E30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xFD9EE0", Offset = "0xFD9EE0", VA = "0xFD9EE0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xFDA33C", Offset = "0xFDA33C", VA = "0xFDA33C")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BD890", Offset = "0x8BD890")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4110", Offset = "0x8C4110")]
		public int iterations;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4128", Offset = "0x8C4128")]
		public float blurSpread;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000032")]
		protected Material material
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xFDA360", Offset = "0xFDA360", VA = "0xFDA360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xFDA4A0", Offset = "0xFDA4A0", VA = "0xFDA4A0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xFDA59C", Offset = "0xFDA59C", VA = "0xFDA59C")]
		protected void Start()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xFDA670", Offset = "0xFDA670", VA = "0xFDA670")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xFDA84C", Offset = "0xFDA84C", VA = "0xFDA84C")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xFDAA04", Offset = "0xFDAA04", VA = "0xFDAA04")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xFDAB80", Offset = "0xFDAB80", VA = "0xFDAB80")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD8DC", Offset = "0x8BD8DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BD8DC", Offset = "0x8BD8DC")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000188")]
		public enum BlurType
		{
			[Token(Token = "0x40004A6")]
			StandardGauss,
			[Token(Token = "0x40004A7")]
			SgxGauss
		}

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4140", Offset = "0x8C4140")]
		public int downsample;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4158", Offset = "0x8C4158")]
		public float blurSize;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4170", Offset = "0x8C4170")]
		public int blurIterations;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xFDAB9C", Offset = "0xFDAB9C", VA = "0xFDAB9C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xFDAC00", Offset = "0xFDAC00", VA = "0xFDAC00")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xFDACB0", Offset = "0xFDACB0", VA = "0xFDACB0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xFDB0E0", Offset = "0xFDB0E0", VA = "0xFDB0E0")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BD974", Offset = "0x8BD974")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BD974", Offset = "0x8BD974")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000189")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40004A9")]
			CameraMotion,
			[Token(Token = "0x40004AA")]
			LocalBlur,
			[Token(Token = "0x40004AB")]
			Reconstruction,
			[Token(Token = "0x40004AC")]
			ReconstructionDX11,
			[Token(Token = "0x40004AD")]
			ReconstructionDisc
		}

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xFDB0FC", Offset = "0xFDB0FC", VA = "0xFDB0FC")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xFDB40C", Offset = "0xFDB40C", VA = "0xFDB40C")]
		private new void Start()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xFDB72C", Offset = "0xFDB72C", VA = "0xFDB72C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xFDB80C", Offset = "0xFDB80C", VA = "0xFDB80C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xFDB970", Offset = "0xFDB970", VA = "0xFDB970", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xFDBA08", Offset = "0xFDBA08", VA = "0xFDBA08")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xFDB514", Offset = "0xFDB514", VA = "0xFDB514")]
		private void Remember()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xFDD814", Offset = "0xFDD814", VA = "0xFDD814")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xFDD720", Offset = "0xFDD720", VA = "0xFDD720")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xFDD804", Offset = "0xFDD804", VA = "0xFDD804")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xFDDCB8", Offset = "0xFDDCB8", VA = "0xFDDCB8")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDA0C", Offset = "0x8BDA0C")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200018A")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40004AF")]
			Simple,
			[Token(Token = "0x40004B0")]
			Advanced
		}

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xFDDE08", Offset = "0xFDDE08", VA = "0xFDDE08")]
		private new void Start()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xFDDE34", Offset = "0xFDDE34", VA = "0xFDDE34")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xFDDE38", Offset = "0xFDDE38", VA = "0xFDDE38", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xFDE0F0", Offset = "0xFDE0F0", VA = "0xFDE0F0")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xFDE594", Offset = "0xFDE594", VA = "0xFDE594")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xFDE598", Offset = "0xFDE598", VA = "0xFDE598")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xFDE984", Offset = "0xFDE984", VA = "0xFDE984")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDA58", Offset = "0x8BDA58")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xFDF0C0", Offset = "0xFDF0C0", VA = "0xFDF0C0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xFDF120", Offset = "0xFDF120", VA = "0xFDF120")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xFDF1C8", Offset = "0xFDF1C8", VA = "0xFDF1C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xFDF270", Offset = "0xFDF270", VA = "0xFDF270")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xFDF4B8", Offset = "0xFDF4B8", VA = "0xFDF4B8")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xFDF5BC", Offset = "0xFDF5BC", VA = "0xFDF5BC")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xFDF9BC", Offset = "0xFDF9BC", VA = "0xFDF9BC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xFDFBE8", Offset = "0xFDFBE8", VA = "0xFDFBE8")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDAA4", Offset = "0x8BDAA4")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xFDFC40", Offset = "0xFDFC40", VA = "0xFDFC40")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xFDFD14", Offset = "0xFDFD14", VA = "0xFDFD14")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BDAF0", Offset = "0x8BDAF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDAF0", Offset = "0x8BDAF0")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4188", Offset = "0x8C4188")]
		public float intensity;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C41A0", Offset = "0x8C41A0")]
		public float threshold;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C41BC", Offset = "0x8C41BC")]
		public float blurSpread;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xFDFD1C", Offset = "0xFDFD1C", VA = "0xFDFD1C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xFDFD9C", Offset = "0xFDFD9C", VA = "0xFDFD9C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xFE0158", Offset = "0xFE0158", VA = "0xFE0158")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDB88", Offset = "0x8BDB88")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C41D4", Offset = "0x8C41D4")]
		public float adaptationSpeed;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C41F0", Offset = "0x8C41F0")]
		public float limitMinimum;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4208", Offset = "0x8C4208")]
		public float limitMaximum;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000033")]
		protected Material materialLum
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xFE0170", Offset = "0xFE0170", VA = "0xFE0170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		protected Material materialReduce
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xFE0238", Offset = "0xFE0238", VA = "0xFE0238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xFE0300", Offset = "0xFE0300", VA = "0xFE0300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		protected Material materialApply
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xFE03C8", Offset = "0xFE03C8", VA = "0xFE03C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xFE0490", Offset = "0xFE0490", VA = "0xFE0490")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xFE0550", Offset = "0xFE0550", VA = "0xFE0550")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xFE06F0", Offset = "0xFE06F0", VA = "0xFE06F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xFE0940", Offset = "0xFE0940", VA = "0xFE0940")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xFE0BD4", Offset = "0xFE0BD4", VA = "0xFE0BD4")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xFE0E40", Offset = "0xFE0E40", VA = "0xFE0E40")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BDBD4", Offset = "0x8BDBD4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDBD4", Offset = "0x8BDBD4")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xFE0EC0", Offset = "0xFE0EC0", VA = "0xFE0EC0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xFE0F4C", Offset = "0xFE0F4C", VA = "0xFE0F4C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xFE133C", Offset = "0xFE133C", VA = "0xFE133C")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BDC6C", Offset = "0x8BDC6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDC6C", Offset = "0x8BDC6C")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x200018B")]
		public enum BlurType
		{
			[Token(Token = "0x40004B2")]
			DiscBlur,
			[Token(Token = "0x40004B3")]
			DX11
		}

		[Token(Token = "0x200018C")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40004B5")]
			Low,
			[Token(Token = "0x40004B6")]
			Medium,
			[Token(Token = "0x40004B7")]
			High
		}

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xFE1358", Offset = "0xFE1358", VA = "0xFE1358", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xFE1560", Offset = "0xFE1560", VA = "0xFE1560")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xFE15FC", Offset = "0xFE15FC", VA = "0xFE15FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xFE1704", Offset = "0xFE1704", VA = "0xFE1704")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xFE13EC", Offset = "0xFE13EC", VA = "0xFE13EC")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xFE1748", Offset = "0xFE1748", VA = "0xFE1748")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xFE191C", Offset = "0xFE191C", VA = "0xFE191C")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xFE1CB0", Offset = "0xFE1CB0", VA = "0xFE1CB0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xFE370C", Offset = "0xFE370C", VA = "0xFE370C")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BDD04", Offset = "0x8BDD04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDD04", Offset = "0x8BDD04")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x200018D")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40004B9")]
			OnlyBackground = 1,
			[Token(Token = "0x40004BA")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200018E")]
		public enum DofResolution
		{
			[Token(Token = "0x40004BC")]
			High = 2,
			[Token(Token = "0x40004BD")]
			Medium,
			[Token(Token = "0x40004BE")]
			Low
		}

		[Token(Token = "0x200018F")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40004C0")]
			Low = 1,
			[Token(Token = "0x40004C1")]
			High = 2,
			[Token(Token = "0x40004C2")]
			VeryHigh = 4
		}

		[Token(Token = "0x2000190")]
		public enum BokehDestination
		{
			[Token(Token = "0x40004C4")]
			Background = 1,
			[Token(Token = "0x40004C5")]
			Foreground,
			[Token(Token = "0x40004C6")]
			BackgroundAndForeground
		}

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x200DED0", Offset = "0x200DED0", VA = "0x200DED0")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x200E3E8", Offset = "0x200E3E8", VA = "0x200E3E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x200E6C4", Offset = "0x200E6C4", VA = "0x200E6C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x200E940", Offset = "0x200E940", VA = "0x200E940")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x200E9DC", Offset = "0x200E9DC", VA = "0x200E9DC")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x200EBB0", Offset = "0x200EBB0", VA = "0x200EBB0")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x200EBD4", Offset = "0x200EBD4", VA = "0x200EBD4")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x200EBF8", Offset = "0x200EBF8", VA = "0x200EBF8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x200FBD0", Offset = "0x200FBD0", VA = "0x200FBD0")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x201034C", Offset = "0x201034C", VA = "0x201034C")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x20107F0", Offset = "0x20107F0", VA = "0x20107F0")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x200FA6C", Offset = "0x200FA6C", VA = "0x200FA6C")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x200FE9C", Offset = "0x200FE9C", VA = "0x200FE9C")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2010644", Offset = "0x2010644", VA = "0x2010644")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x200F68C", Offset = "0x200F68C", VA = "0x200F68C")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2010D0C", Offset = "0x2010D0C", VA = "0x2010D0C")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BDD9C", Offset = "0x8BDD9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDD9C", Offset = "0x8BDD9C")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000191")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40004C8")]
			TriangleDepthNormals,
			[Token(Token = "0x40004C9")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40004CA")]
			SobelDepth,
			[Token(Token = "0x40004CB")]
			SobelDepthThin,
			[Token(Token = "0x40004CC")]
			TriangleLuminance
		}

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2010E64", Offset = "0x2010E64", VA = "0x2010E64", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2010FE8", Offset = "0x2010FE8", VA = "0x2010FE8")]
		private new void Start()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2010EDC", Offset = "0x2010EDC", VA = "0x2010EDC")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2010FF4", Offset = "0x2010FF4", VA = "0x2010FF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2010FF8", Offset = "0x2010FF8", VA = "0x2010FF8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2011260", Offset = "0x2011260", VA = "0x2011260")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BDE34", Offset = "0x8BDE34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDE34", Offset = "0x8BDE34")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4220", Offset = "0x8C4220")]
		public float strengthX;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4238", Offset = "0x8C4238")]
		public float strengthY;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x20112B0", Offset = "0x20112B0", VA = "0x20112B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2011308", Offset = "0x2011308", VA = "0x2011308")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2011490", Offset = "0x2011490", VA = "0x2011490")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BDECC", Offset = "0x8BDECC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDECC", Offset = "0x8BDECC")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8C4250", Offset = "0x8C4250")]
		public bool distanceFog;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8C4288", Offset = "0x8C4288")]
		public bool excludeFarPixels;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8C42C0", Offset = "0x8C42C0")]
		public bool useRadialDistance;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8C42F8", Offset = "0x8C42F8")]
		public bool heightFog;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8C4330", Offset = "0x8C4330")]
		public float height;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4368", Offset = "0x8C4368")]
		public float heightDensity;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8C4384", Offset = "0x8C4384")]
		public float startDistance;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x20114A8", Offset = "0x20114A8", VA = "0x20114A8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2011500", Offset = "0x2011500", VA = "0x2011500")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2011C8C", Offset = "0x2011C8C", VA = "0x2011C8C")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDF64", Offset = "0x8BDF64")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C43BC", Offset = "0x8C43BC")]
		public float rampOffset;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2011CAC", Offset = "0x2011CAC", VA = "0x2011CAC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2011E7C", Offset = "0x2011E7C", VA = "0x2011E7C")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BDFB0", Offset = "0x8BDFB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BDFB0", Offset = "0x8BDFB0")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000037")]
		protected Material material
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x2011DB4", Offset = "0x2011DB4", VA = "0x2011DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2011E8C", Offset = "0x2011E8C", VA = "0x2011E8C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2011F44", Offset = "0x2011F44", VA = "0x2011F44", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2011E84", Offset = "0x2011E84", VA = "0x2011E84")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE038", Offset = "0x8BE038")]
	public class ImageEffects
	{
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2011FF4", Offset = "0x2011FF4", VA = "0x2011FF4")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2012284", Offset = "0x2012284", VA = "0x2012284")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C57D8", Offset = "0x8C57D8")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x20122FC", Offset = "0x20122FC", VA = "0x20122FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C5810", Offset = "0x8C5810")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x201237C", Offset = "0x201237C", VA = "0x201237C")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE070", Offset = "0x8BE070")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE070", Offset = "0x8BE070")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C43D4", Offset = "0x8C43D4")]
		public float blurAmount;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2012384", Offset = "0x2012384", VA = "0x2012384", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2012388", Offset = "0x2012388", VA = "0x2012388", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x20123FC", Offset = "0x20123FC", VA = "0x20123FC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x20127E8", Offset = "0x20127E8", VA = "0x20127E8")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE108", Offset = "0x8BE108")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE108", Offset = "0x8BE108")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x20127FC", Offset = "0x20127FC", VA = "0x20127FC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2012874", Offset = "0x2012874", VA = "0x2012874")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x201333C", Offset = "0x201333C", VA = "0x201333C")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x20136DC", Offset = "0x20136DC", VA = "0x20136DC")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE1A0", Offset = "0x8BE1A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE1A0", Offset = "0x8BE1A0")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C43F0", Offset = "0x8C43F0")]
		public float grainIntensityMin;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4408", Offset = "0x8C4408")]
		public float grainIntensityMax;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4420", Offset = "0x8C4420")]
		public float grainSize;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4440", Offset = "0x8C4440")]
		public float scratchIntensityMin;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4458", Offset = "0x8C4458")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4470", Offset = "0x8C4470")]
		public float scratchFPS;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4488", Offset = "0x8C4488")]
		public float scratchJitter;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000038")]
		protected Material material
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x2013938", Offset = "0x2013938", VA = "0x2013938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x20137E4", Offset = "0x20137E4", VA = "0x20137E4")]
		protected void Start()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2013AA0", Offset = "0x2013AA0", VA = "0x2013AA0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2013BA4", Offset = "0x2013BA4", VA = "0x2013BA4")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2013CE0", Offset = "0x2013CE0", VA = "0x2013CE0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2014084", Offset = "0x2014084", VA = "0x2014084")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE238", Offset = "0x8BE238")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x200DFA8", Offset = "0x200DFA8", VA = "0x200DFA8")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x20140E4", Offset = "0x20140E4", VA = "0x20140E4")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x20142E4", Offset = "0x20142E4", VA = "0x20142E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x20142F0", Offset = "0x20142F0", VA = "0x20142F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x20142F4", Offset = "0x20142F4", VA = "0x20142F4")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x20143EC", Offset = "0x20143EC", VA = "0x20143EC")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x20143F4", Offset = "0x20143F4", VA = "0x20143F4", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x20144A4", Offset = "0x20144A4", VA = "0x20144A4")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x200E4F0", Offset = "0x200E4F0", VA = "0x200E4F0")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x20144B0", Offset = "0x20144B0", VA = "0x20144B0")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x201450C", Offset = "0x201450C", VA = "0x201450C")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x200E61C", Offset = "0x200E61C", VA = "0x200E61C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2014514", Offset = "0x2014514", VA = "0x2014514")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x20140B8", Offset = "0x20140B8", VA = "0x20140B8")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x20147A4", Offset = "0x20147A4", VA = "0x20147A4")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2010D84", Offset = "0x2010D84", VA = "0x2010D84")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE2AC", Offset = "0x8BE2AC")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2014B4C", Offset = "0x2014B4C", VA = "0x2014B4C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2014BB8", Offset = "0x2014BB8", VA = "0x2014BB8")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2014E50", Offset = "0x2014E50", VA = "0x2014E50")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x20151F4", Offset = "0x20151F4", VA = "0x20151F4")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x20153AC", Offset = "0x20153AC", VA = "0x20153AC")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000085")]
	internal class Quads
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x20153B4", Offset = "0x20153B4", VA = "0x20153B4")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x200E720", Offset = "0x200E720", VA = "0x200E720")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2010A34", Offset = "0x2010A34", VA = "0x2010A34")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x20154CC", Offset = "0x20154CC", VA = "0x20154CC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2015BE0", Offset = "0x2015BE0", VA = "0x2015BE0")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE320", Offset = "0x8BE320")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE320", Offset = "0x8BE320")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x2000192")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40004CE")]
			Additive,
			[Token(Token = "0x40004CF")]
			ScreenBlend,
			[Token(Token = "0x40004D0")]
			Multiply,
			[Token(Token = "0x40004D1")]
			Overlay,
			[Token(Token = "0x40004D2")]
			AlphaBlend
		}

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2015BEC", Offset = "0x2015BEC", VA = "0x2015BEC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2015C44", Offset = "0x2015C44", VA = "0x2015C44")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2015DFC", Offset = "0x2015DFC", VA = "0x2015DFC")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE3B8", Offset = "0x8BE3B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE3B8", Offset = "0x8BE3B8")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C44A0", Offset = "0x8C44A0")]
		public float intensity;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C44B8", Offset = "0x8C44B8")]
		public float radius;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C44D4", Offset = "0x8C44D4")]
		public int blurIterations;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C44EC", Offset = "0x8C44EC")]
		public float blurFilterDistance;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4504", Offset = "0x8C4504")]
		public int downsample;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2015E0C", Offset = "0x2015E0C", VA = "0x2015E0C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2015E64", Offset = "0x2015E64", VA = "0x2015E64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2015F0C", Offset = "0x2015F0C", VA = "0x2015F0C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2016864", Offset = "0x2016864", VA = "0x2016864")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE450", Offset = "0x8BE450")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE450", Offset = "0x8BE450")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000193")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40004D4")]
			Low,
			[Token(Token = "0x40004D5")]
			Medium,
			[Token(Token = "0x40004D6")]
			High
		}

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C451C", Offset = "0x8C451C")]
		public float m_Radius;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4538", Offset = "0x8C4538")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4550", Offset = "0x8C4550")]
		public int m_Blur;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4568", Offset = "0x8C4568")]
		public int m_Downsampling;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4580", Offset = "0x8C4580")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C459C", Offset = "0x8C459C")]
		public float m_MinZ;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2016880", Offset = "0x2016880", VA = "0x2016880")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2016934", Offset = "0x2016934", VA = "0x2016934")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x20169D0", Offset = "0x20169D0", VA = "0x20169D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x20169D8", Offset = "0x20169D8", VA = "0x20169D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2016B98", Offset = "0x2016B98", VA = "0x2016B98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2016AB8", Offset = "0x2016AB8", VA = "0x2016AB8")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2016C30", Offset = "0x2016C30", VA = "0x2016C30")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x20173E8", Offset = "0x20173E8", VA = "0x20173E8")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE4E8", Offset = "0x8BE4E8")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2017420", Offset = "0x2017420", VA = "0x2017420")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x20174B0", Offset = "0x20174B0", VA = "0x20174B0")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE534", Offset = "0x8BE534")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE534", Offset = "0x8BE534")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000194")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40004D8")]
			Low,
			[Token(Token = "0x40004D9")]
			Normal,
			[Token(Token = "0x40004DA")]
			High
		}

		[Token(Token = "0x2000195")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40004DC")]
			Screen,
			[Token(Token = "0x40004DD")]
			Add
		}

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x20174B8", Offset = "0x20174B8", VA = "0x20174B8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2017520", Offset = "0x2017520", VA = "0x2017520")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2017E34", Offset = "0x2017E34", VA = "0x2017E34")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE5CC", Offset = "0x8BE5CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE5CC", Offset = "0x8BE5CC")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000196")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x40004DF")]
			TiltShiftMode,
			[Token(Token = "0x40004E0")]
			IrisMode
		}

		[Token(Token = "0x2000197")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x40004E2")]
			Preview,
			[Token(Token = "0x40004E3")]
			Low,
			[Token(Token = "0x40004E4")]
			Normal,
			[Token(Token = "0x40004E5")]
			High
		}

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C45B8", Offset = "0x8C45B8")]
		public float blurArea;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C45D0", Offset = "0x8C45D0")]
		public float maxBlurSize;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C45E8", Offset = "0x8C45E8")]
		public int downsample;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2017EDC", Offset = "0x2017EDC", VA = "0x2017EDC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2017F34", Offset = "0x2017F34", VA = "0x2017F34")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x201823C", Offset = "0x201823C", VA = "0x201823C")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE654", Offset = "0x8BE654")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE654", Offset = "0x8BE654")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000198")]
		public enum TonemapperType
		{
			[Token(Token = "0x40004E7")]
			SimpleReinhard,
			[Token(Token = "0x40004E8")]
			UserCurve,
			[Token(Token = "0x40004E9")]
			Hable,
			[Token(Token = "0x40004EA")]
			Photographic,
			[Token(Token = "0x40004EB")]
			OptimizedHejiDawson,
			[Token(Token = "0x40004EC")]
			AdaptiveReinhard,
			[Token(Token = "0x40004ED")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000199")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x40004EF")]
			Square16 = 0x10,
			[Token(Token = "0x40004F0")]
			Square32 = 0x20,
			[Token(Token = "0x40004F1")]
			Square64 = 0x40,
			[Token(Token = "0x40004F2")]
			Square128 = 0x80,
			[Token(Token = "0x40004F3")]
			Square256 = 0x100,
			[Token(Token = "0x40004F4")]
			Square512 = 0x200,
			[Token(Token = "0x40004F5")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2018254", Offset = "0x2018254", VA = "0x2018254", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x20183AC", Offset = "0x20183AC", VA = "0x20183AC")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x20186CC", Offset = "0x20186CC", VA = "0x20186CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2018824", Offset = "0x2018824", VA = "0x2018824")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2018918", Offset = "0x2018918", VA = "0x2018918")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x2019268", Offset = "0x2019268", VA = "0x2019268")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200008D")]
	internal class Triangles
	{
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2019294", Offset = "0x2019294", VA = "0x2019294")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x20193F0", Offset = "0x20193F0", VA = "0x20193F0")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2019610", Offset = "0x2019610", VA = "0x2019610")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x20198E8", Offset = "0x20198E8", VA = "0x20198E8")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2019E70", Offset = "0x2019E70", VA = "0x2019E70")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE6EC", Offset = "0x8BE6EC")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C4600", Offset = "0x8C4600")]
		public float angle;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x2019E7C", Offset = "0x2019E7C", VA = "0x2019E7C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2019EC0", Offset = "0x2019EC0", VA = "0x2019EC0")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE738", Offset = "0x8BE738")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE738", Offset = "0x8BE738")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200019A")]
		public enum AberrationMode
		{
			[Token(Token = "0x40004F7")]
			Simple,
			[Token(Token = "0x40004F8")]
			Advanced
		}

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x2019F3C", Offset = "0x2019F3C", VA = "0x2019F3C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x2019FC0", Offset = "0x2019FC0", VA = "0x2019FC0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x201A6B8", Offset = "0x201A6B8", VA = "0x201A6B8")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BE7D0", Offset = "0x8BE7D0")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x201A6EC", Offset = "0x201A6EC", VA = "0x201A6EC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x201A730", Offset = "0x201A730", VA = "0x201A730")]
		public Vortex()
		{
		}
	}
}
namespace FreakLib.Music
{
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BE81C", Offset = "0x8BE81C")]
	public class MusicPlayer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019B")]
		public class MusicPlayerEvent : UnityEvent<MusicPlayer>
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0xFD2D68", Offset = "0xFD2D68", VA = "0xFD2D68")]
			public MusicPlayerEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3B9C", Offset = "0x8C3B9C")]
		private sealed class <>c
		{
			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Converter<Playlist, string> <>9__31_0;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<Track> <>9__57_0;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Track> <>9__57_1;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Comparison<Track> <>9__57_2;

			[Token(Token = "0x6000999")]
			[Address(RVA = "0xFD2C58", Offset = "0xFD2C58", VA = "0xFD2C58")]
			public <>c()
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0xFD2C60", Offset = "0xFD2C60", VA = "0xFD2C60")]
			internal string <get_PlaylistNames>b__31_0(Playlist p)
			{
				return null;
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0xFD2C8C", Offset = "0xFD2C8C", VA = "0xFD2C8C")]
			internal bool <Next>b__57_0(Track t)
			{
				return default(bool);
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0xFD2CB8", Offset = "0xFD2CB8", VA = "0xFD2CB8")]
			internal int <Next>b__57_1(Track t1, Track t2)
			{
				return default(int);
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0xFD2CC8", Offset = "0xFD2CC8", VA = "0xFD2CC8")]
			internal int <Next>b__57_2(Track t1, Track t2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200019D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3BAC", Offset = "0x8C3BAC")]
		private sealed class <>c__DisplayClass59_0
		{
			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x600099E")]
			[Address(RVA = "0xFD2B48", Offset = "0xFD2B48", VA = "0xFD2B48")]
			public <>c__DisplayClass59_0()
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0xFD2D24", Offset = "0xFD2D24", VA = "0xFD2D24")]
			internal bool <GetPlaylist>b__0(Playlist p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int startingTrack;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<Playlist> m_Playlists;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_PlayOnAwake;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_Volume;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_HistoryLength;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MusicPlayerEvent OnPlay;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MusicPlayerEvent OnStop;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MusicPlayerEvent OnPause;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MusicPlayerEvent OnUnpause;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MusicPlayerEvent OnTrackChange;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MusicPlayerEvent OnPlaylistChange;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Playlist m_CurrentPlaylist;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int m_CurrentTrackIdx;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool m_IsPlaying;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		private bool m_IsPaused;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private LinkedList<int> m_History;

		[Token(Token = "0x17000039")]
		public bool PlayOnAwake
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xFD13A0", Offset = "0xFD13A0", VA = "0xFD13A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xFD13A8", Offset = "0xFD13A8", VA = "0xFD13A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float Volume
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0xFD13B4", Offset = "0xFD13B4", VA = "0xFD13B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000557")]
			[Address(RVA = "0xFD13BC", Offset = "0xFD13BC", VA = "0xFD13BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int HistoryLength
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0xFD13C4", Offset = "0xFD13C4", VA = "0xFD13C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000559")]
			[Address(RVA = "0xFD13CC", Offset = "0xFD13CC", VA = "0xFD13CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public List<Playlist> Playlists
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xFD13D4", Offset = "0xFD13D4", VA = "0xFD13D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0xFD13DC", Offset = "0xFD13DC", VA = "0xFD13DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xFD13E4", Offset = "0xFD13E4", VA = "0xFD13E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public Playlist CurrentPlaylist
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xFD14E8", Offset = "0xFD14E8", VA = "0xFD14E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public string CurrentPlaylistName
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xFD14F0", Offset = "0xFD14F0", VA = "0xFD14F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public Track CurrentTrack
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xFD151C", Offset = "0xFD151C", VA = "0xFD151C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public string CurrentTrackName
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xFD1598", Offset = "0xFD1598", VA = "0xFD1598")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xFD15CC", Offset = "0xFD15CC", VA = "0xFD15CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public float Playtime
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xFD15D4", Offset = "0xFD15D4", VA = "0xFD15D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xFD1604", Offset = "0xFD1604", VA = "0xFD1604")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public float PlaytimeNormalized
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xFD1644", Offset = "0xFD1644", VA = "0xFD1644")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xFD1740", Offset = "0xFD1740", VA = "0xFD1740")]
			set
			{
			}
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xFD181C", Offset = "0xFD181C", VA = "0xFD181C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xFD19AC", Offset = "0xFD19AC", VA = "0xFD19AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xFD1900", Offset = "0xFD1900", VA = "0xFD1900")]
		public void Play()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xFD2464", Offset = "0xFD2464", VA = "0xFD2464")]
		public void Play(string name)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xFD2094", Offset = "0xFD2094", VA = "0xFD2094")]
		public void Play(Playlist playlist, int trackOverRide = -1)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xFD2858", Offset = "0xFD2858", VA = "0xFD2858")]
		public void PauseOrResume()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xFD2900", Offset = "0xFD2900", VA = "0xFD2900")]
		public void Pause()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xFD2868", Offset = "0xFD2868", VA = "0xFD2868")]
		public void UnPause()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xFD27A0", Offset = "0xFD27A0", VA = "0xFD27A0")]
		public void Stop()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xFD1A38", Offset = "0xFD1A38", VA = "0xFD1A38")]
		public void Next()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xFD299C", Offset = "0xFD299C", VA = "0xFD299C")]
		public void Previous()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xFD252C", Offset = "0xFD252C", VA = "0xFD252C")]
		public Playlist GetPlaylist(string name)
		{
			return null;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xFD2B50", Offset = "0xFD2B50", VA = "0xFD2B50")]
		public MusicPlayer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class Playlist
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Track> tracks;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shuffle;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool foldout;

		[Token(Token = "0x17000045")]
		public List<int> EnabledTrackIndices
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xFD25FC", Offset = "0xFD25FC", VA = "0xFD25FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xFD2DB8", Offset = "0xFD2DB8", VA = "0xFD2DB8")]
		public Playlist()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xFD2E4C", Offset = "0xFD2E4C", VA = "0xFD2E4C")]
		public Playlist(string aName)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xFD2EE0", Offset = "0xFD2EE0", VA = "0xFD2EE0")]
		public Playlist(string aName, List<Track> theTracks, bool shouldShuffle = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class Track
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool enabled;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool foldout;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C465C", Offset = "0x8C465C")]
		private int <Plays>k__BackingField;

		[Token(Token = "0x17000046")]
		public float Length
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xFD16A0", Offset = "0xFD16A0", VA = "0xFD16A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000047")]
		public int Plays
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xFD2994", Offset = "0xFD2994", VA = "0xFD2994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5878", Offset = "0x8C5878")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xFD2850", Offset = "0xFD2850", VA = "0xFD2850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5888", Offset = "0x8C5888")]
			set
			{
			}
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xFD2F8C", Offset = "0xFD2F8C", VA = "0xFD2F8C")]
		public Track()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xFD3000", Offset = "0xFD3000", VA = "0xFD3000")]
		public Track(AudioClip aClip, string aName = "")
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xFD3078", Offset = "0xFD3078", VA = "0xFD3078", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace ES3Types
{
	[Token(Token = "0x2000094")]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x143F5D8", Offset = "0x143F5D8", VA = "0x143F5D8")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x143F688", Offset = "0x143F688", VA = "0x143F688", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600057F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x143F690", Offset = "0x143F690", VA = "0x143F690")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x143F740", Offset = "0x143F740", VA = "0x143F740", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000583")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000096")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1434100", Offset = "0x1434100", VA = "0x1434100")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x14341F4", Offset = "0x14341F4", VA = "0x14341F4", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x6000587")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x14344A4", Offset = "0x14344A4", VA = "0x14344A4", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000097")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1434728", Offset = "0x1434728", VA = "0x1434728")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x143472C", Offset = "0x143472C", VA = "0x143472C", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600058B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1434A78", Offset = "0x1434A78", VA = "0x1434A78", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1434DDC", Offset = "0x1434DDC", VA = "0x1434DDC")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1434DE0", Offset = "0x1434DE0", VA = "0x1434DE0")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1434E40", Offset = "0x1434E40", VA = "0x1434E40", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000590")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1435048", Offset = "0x1435048", VA = "0x1435048", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1435304", Offset = "0x1435304", VA = "0x1435304", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Type elementType;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x6000594")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1434104", Offset = "0x1434104", VA = "0x1434104")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1434E10", Offset = "0x1434E10", VA = "0x1434E10")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1435994", Offset = "0x1435994", VA = "0x1435994", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000598")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000599")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x14359A4", Offset = "0x14359A4", VA = "0x14359A4", Slot = "10")]
		public virtual object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1435BF8", Offset = "0x1435BF8", VA = "0x1435BF8", Slot = "11")]
		public virtual void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Type keyType;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type valueType;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x14365A0", Offset = "0x14365A0", VA = "0x14365A0")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x14366CC", Offset = "0x14366CC", VA = "0x14366CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1436724", Offset = "0x1436724", VA = "0x1436724")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600059F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005A1")]
		public Dictionary<TKey, TVal> ReadKVP<TKey, TVal>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		public void ReadKVP<TKey, TVal>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1436C0C", Offset = "0x1436C0C", VA = "0x1436C0C")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1436EA8", Offset = "0x1436EA8", VA = "0x1436EA8")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1437270", Offset = "0x1437270", VA = "0x1437270")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1437274", Offset = "0x1437274", VA = "0x1437274", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005A7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1437944", Offset = "0x1437944", VA = "0x1437944")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1437948", Offset = "0x1437948", VA = "0x1437948", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005AB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1437DF8", Offset = "0x1437DF8", VA = "0x1437DF8", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1438030", Offset = "0x1438030", VA = "0x1438030", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x14387A8", Offset = "0x14387A8", VA = "0x14387A8")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x14387AC", Offset = "0x14387AC", VA = "0x14387AC", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005B1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1438C24", Offset = "0x1438C24", VA = "0x1438C24", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1438F40", Offset = "0x1438F40", VA = "0x1438F40", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x143A070", Offset = "0x143A070", VA = "0x143A070")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x143A074", Offset = "0x143A074", VA = "0x143A074", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005B7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x143A4EC", Offset = "0x143A4EC", VA = "0x143A4EC", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x143A808", Offset = "0x143A808", VA = "0x143A808", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public abstract class ES3ComponentType : ES3ObjectType
	{
		[Token(Token = "0x40002D9")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1435F00", Offset = "0x1435F00", VA = "0x1435F00")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x60005BC")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x60005BD")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1435F08", Offset = "0x1435F08", VA = "0x1435F08", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005BF")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005C0")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x14361BC", Offset = "0x14361BC", VA = "0x14361BC")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1436404", Offset = "0x1436404", VA = "0x1436404")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1436334", Offset = "0x1436334", VA = "0x1436334")]
		public static Component GetOrCreateComponentIfNotExists(GameObject go, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A0")]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1435F04", Offset = "0x1435F04", VA = "0x1435F04")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x60005C5")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x60005C6")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x60005C7")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1438600", Offset = "0x1438600", VA = "0x1438600", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005C9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public abstract class ES3ScriptableObjectType : ES3ObjectType
	{
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x14397B0", Offset = "0x14397B0", VA = "0x14397B0")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60005CC")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x60005CD")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1439E98", Offset = "0x1439E98", VA = "0x1439E98", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005CF")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005D0")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8BE880", Offset = "0x8BE880")]
	public abstract class ES3Type
	{
		[Token(Token = "0x40002DA")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isReflectedType;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUnsupported;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x14358D4", Offset = "0x14358D4", VA = "0x14358D4")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x60005D2")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x60005D3")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x60005D4")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1438658", Offset = "0x1438658", VA = "0x1438658")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x143ADF4", Offset = "0x143ADF4", VA = "0x143ADF4")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1439570", Offset = "0x1439570", VA = "0x1439570")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x143AE80", Offset = "0x143AE80", VA = "0x143AE80")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1439560", Offset = "0x1439560", VA = "0x1439560")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1439818", Offset = "0x1439818", VA = "0x1439818")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x8BE894", Offset = "0x8BE894")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x143877C", Offset = "0x143877C", VA = "0x143877C")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xFC8290", Offset = "0xFC8290", VA = "0xFC8290")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60005DE")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x60005DF")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60005E0")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xFCEE78", Offset = "0xFCEE78", VA = "0xFCEE78", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xFCEE88", Offset = "0xFCEE88", VA = "0xFCEE88", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x60005E3")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005E4")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A5")]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xFCCFB8", Offset = "0xFCCFB8", VA = "0xFCCFB8")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xFCD074", Offset = "0xFCD074", VA = "0xFCD074", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005E7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A6")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xFCD0F8", Offset = "0xFCD0F8", VA = "0xFCD0F8")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xFCD1D0", Offset = "0xFCD1D0", VA = "0xFCD1D0")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xFCD28C", Offset = "0xFCD28C", VA = "0xFCD28C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005EC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A8")]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xFCD310", Offset = "0xFCD310", VA = "0xFCD310")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xFCD3CC", Offset = "0xFCD3CC", VA = "0xFCD3CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005F0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xFCD4BC", Offset = "0xFCD4BC", VA = "0xFCD4BC")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xFCD578", Offset = "0xFCD578", VA = "0xFCD578", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005F4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AA")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xFCD5FC", Offset = "0xFCD5FC", VA = "0xFCD5FC")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x143F340", Offset = "0x143F340", VA = "0x143F340")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x143F3F0", Offset = "0x143F3F0", VA = "0x143F3F0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005F9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AC")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x143F4F8", Offset = "0x143F4F8", VA = "0x143F4F8")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xFCD6D4", Offset = "0xFCD6D4", VA = "0xFCD6D4")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xFCD790", Offset = "0xFCD790", VA = "0xFCD790", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005FE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AE")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xFCD814", Offset = "0xFCD814", VA = "0xFCD814")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xFCD8EC", Offset = "0xFCD8EC", VA = "0xFCD8EC")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xFCD9A8", Offset = "0xFCD9A8", VA = "0xFCD9A8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000603")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xFCDA2C", Offset = "0xFCDA2C", VA = "0xFCDA2C")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xFCDB04", Offset = "0xFCDB04", VA = "0xFCDB04")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xFCDB94", Offset = "0xFCDB94", VA = "0xFCDB94", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000608")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B2")]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xFCDC18", Offset = "0xFCDC18", VA = "0xFCDC18")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xFCDCD4", Offset = "0xFCDCD4", VA = "0xFCDCD4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600060C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B3")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xFCDD58", Offset = "0xFCDD58", VA = "0xFCDD58")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xFCDE30", Offset = "0xFCDE30", VA = "0xFCDE30")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xFCDEEC", Offset = "0xFCDEEC", VA = "0xFCDEEC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000611")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xFCDF70", Offset = "0xFCDF70", VA = "0xFCDF70")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x14421AC", Offset = "0x14421AC", VA = "0x14421AC")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1442264", Offset = "0x1442264", VA = "0x1442264", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000616")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B7")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x14422F8", Offset = "0x14422F8", VA = "0x14422F8")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xFCE048", Offset = "0xFCE048", VA = "0xFCE048")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xFCE104", Offset = "0xFCE104", VA = "0xFCE104", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600061B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B9")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xFCE188", Offset = "0xFCE188", VA = "0xFCE188")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xFCE260", Offset = "0xFCE260", VA = "0xFCE260")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xFCE31C", Offset = "0xFCE31C", VA = "0xFCE31C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000620")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BB")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xFCE3A0", Offset = "0xFCE3A0", VA = "0xFCE3A0")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xFCE478", Offset = "0xFCE478", VA = "0xFCE478")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xFCE534", Offset = "0xFCE534", VA = "0xFCE534", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000625")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BD")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xFCE5B8", Offset = "0xFCE5B8", VA = "0xFCE5B8")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xFCE690", Offset = "0xFCE690", VA = "0xFCE690")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xFCE74C", Offset = "0xFCE74C", VA = "0xFCE74C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600062A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BF")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xFC90D8", Offset = "0xFC90D8", VA = "0xFC90D8")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xFCE830", Offset = "0xFCE830", VA = "0xFCE830")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xFCE8EC", Offset = "0xFCE8EC", VA = "0xFCE8EC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600062F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xFCE970", Offset = "0xFCE970", VA = "0xFCE970")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xFCBAF0", Offset = "0xFCBAF0", VA = "0xFCBAF0")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xFCBBAC", Offset = "0xFCBBAC", VA = "0xFCBBAC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000634")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C3")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xFCBC30", Offset = "0xFCBC30", VA = "0xFCBC30")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xFCEA48", Offset = "0xFCEA48", VA = "0xFCEA48")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xFCEB04", Offset = "0xFCEB04", VA = "0xFCEB04", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000639")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C5")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xFCEB88", Offset = "0xFCEB88", VA = "0xFCEB88")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xFCEC60", Offset = "0xFCEC60", VA = "0xFCEC60")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xFCED1C", Offset = "0xFCED1C", VA = "0xFCED1C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600063E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C7")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xFCEDA0", Offset = "0xFCEDA0", VA = "0xFCEDA0")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x143952C", Offset = "0x143952C", VA = "0x143952C")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x143956C", Offset = "0x143956C", VA = "0x143956C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000643")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1439744", Offset = "0x1439744", VA = "0x1439744")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1439778", Offset = "0x1439778", VA = "0x1439778", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000646")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x143977C", Offset = "0x143977C", VA = "0x143977C")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x14397B4", Offset = "0x14397B4", VA = "0x14397B4", Slot = "10")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600064A")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x14397B8", Offset = "0x14397B8", VA = "0x14397B8")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x14397E0", Offset = "0x14397E0", VA = "0x14397E0")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x14399CC", Offset = "0x14399CC", VA = "0x14399CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600064E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1439E24", Offset = "0x1439E24", VA = "0x1439E24")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1439E5C", Offset = "0x1439E5C", VA = "0x1439E5C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000652")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1439E60", Offset = "0x1439E60", VA = "0x1439E60")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1439E94", Offset = "0x1439E94", VA = "0x1439E94", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000656")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000657")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BE8A8", Offset = "0x8BE8A8")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x143C58C", Offset = "0x143C58C", VA = "0x143C58C")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x143C63C", Offset = "0x143C63C", VA = "0x143C63C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600065A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BE970", Offset = "0x8BE970")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x143C914", Offset = "0x143C914", VA = "0x143C914")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x143C9C4", Offset = "0x143C9C4", VA = "0x143C9C4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600065E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BEA48", Offset = "0x8BEA48")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x143CD80", Offset = "0x143CD80", VA = "0x143CD80")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x143CE30", Offset = "0x143CE30", VA = "0x143CE30", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000662")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BECC0", Offset = "0x8BECC0")]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x143DA24", Offset = "0x143DA24", VA = "0x143DA24")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x143DAD4", Offset = "0x143DAD4", VA = "0x143DAD4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000666")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x143FC50", Offset = "0x143FC50", VA = "0x143FC50")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x143FD00", Offset = "0x143FD00", VA = "0x143FD00", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600066A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BEDA8", Offset = "0x8BEDA8")]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x144C878", Offset = "0x144C878", VA = "0x144C878")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x144C928", Offset = "0x144C928", VA = "0x144C928", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600066E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x144CD30", Offset = "0x144CD30", VA = "0x144CD30")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BEE90", Offset = "0x8BEE90")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x144CE10", Offset = "0x144CE10", VA = "0x144CE10")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x144CEC0", Offset = "0x144CEC0", VA = "0x144CEC0", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000673")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x144CFF0", Offset = "0x144CFF0", VA = "0x144CFF0")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BEF08", Offset = "0x8BEF08")]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x144D0D0", Offset = "0x144D0D0", VA = "0x144D0D0")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x144D180", Offset = "0x144D180", VA = "0x144D180", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000678")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x144D96C", Offset = "0x144D96C", VA = "0x144D96C")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF080", Offset = "0x8BF080")]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x144EC90", Offset = "0x144EC90", VA = "0x144EC90")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x144ED40", Offset = "0x144ED40", VA = "0x144ED40", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600067D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF298", Offset = "0x8BF298")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x144FF28", Offset = "0x144FF28", VA = "0x144FF28")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x144FFD8", Offset = "0x144FFD8", VA = "0x144FFD8", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000681")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x14505A0", Offset = "0x14505A0", VA = "0x14505A0")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF390", Offset = "0x8BF390")]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xFC7D90", Offset = "0xFC7D90", VA = "0xFC7D90")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xFC7E44", Offset = "0xFC7E44", VA = "0xFC7E44", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000686")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF458", Offset = "0x8BF458")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xFC9540", Offset = "0xFC9540", VA = "0xFC9540")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xFC95F4", Offset = "0xFC95F4", VA = "0xFC95F4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600068A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF640", Offset = "0x8BF640")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xFCB46C", Offset = "0xFCB46C", VA = "0xFCB46C")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xFCB520", Offset = "0xFCB520", VA = "0xFCB520", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600068E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF6E8", Offset = "0x8BF6E8")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x143B64C", Offset = "0x143B64C", VA = "0x143B64C")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x143B6FC", Offset = "0x143B6FC", VA = "0x143B6FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000692")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000693")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF780", Offset = "0x8BF780")]
	public class ES3Type_AudioClip : ES3ObjectType
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x143B8F0", Offset = "0x143B8F0", VA = "0x143B8F0")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x143B9A0", Offset = "0x143B9A0", VA = "0x143B9A0", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000697")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E1")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x143BC64", Offset = "0x143BC64", VA = "0x143BC64")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF838", Offset = "0x8BF838")]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x143BD44", Offset = "0x143BD44", VA = "0x143BD44")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x143BDF4", Offset = "0x143BDF4", VA = "0x143BDF4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600069C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E3")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x143C19C", Offset = "0x143C19C", VA = "0x143C19C")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF920", Offset = "0x8BF920")]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x143C27C", Offset = "0x143C27C", VA = "0x143C27C")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x143C32C", Offset = "0x143C32C", VA = "0x143C32C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006A1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E5")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x143C4AC", Offset = "0x143C4AC", VA = "0x143C4AC")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BF9A8", Offset = "0x8BF9A8")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x143DF48", Offset = "0x143DF48", VA = "0x143DF48")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x143DFF8", Offset = "0x143DFF8", VA = "0x143DFF8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006A6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006A7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFB30", Offset = "0x8BFB30")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x143E6B8", Offset = "0x143E6B8", VA = "0x143E6B8")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x143E768", Offset = "0x143E768", VA = "0x143E768", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006AB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E8")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x143ED44", Offset = "0x143ED44", VA = "0x143ED44")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFBD8", Offset = "0x8BFBD8")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x143E968", Offset = "0x143E968", VA = "0x143E968")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x143EA18", Offset = "0x143EA18", VA = "0x143EA18", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006B0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x143EC1C", Offset = "0x143EC1C", VA = "0x143EC1C")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EA")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x143EC64", Offset = "0x143EC64", VA = "0x143EC64")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFC80", Offset = "0x8BFC80")]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x143EE24", Offset = "0x143EE24", VA = "0x143EE24")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x143EED4", Offset = "0x143EED4", VA = "0x143EED4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006B6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFD18", Offset = "0x8BFD18")]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x143F0F0", Offset = "0x143F0F0", VA = "0x143F0F0")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x143F1A0", Offset = "0x143F1A0", VA = "0x143F1A0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006BB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFDA0", Offset = "0x8BFDA0")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x143F8E0", Offset = "0x143F8E0", VA = "0x143F8E0")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x143F990", Offset = "0x143F990", VA = "0x143F990", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006C0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006C1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFE58", Offset = "0x8BFE58")]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x143FD08", Offset = "0x143FD08", VA = "0x143FD08")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x143FDB8", Offset = "0x143FDB8", VA = "0x143FDB8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006C5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFEE0", Offset = "0x8BFEE0")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x143FF40", Offset = "0x143FF40", VA = "0x143FF40")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x143FFF0", Offset = "0x143FFF0", VA = "0x143FFF0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006CA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1440110", Offset = "0x1440110", VA = "0x1440110")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFF58", Offset = "0x8BFF58")]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x14401F0", Offset = "0x14401F0", VA = "0x14401F0")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x14402A4", Offset = "0x14402A4", VA = "0x14402A4", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006D0")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60006D1")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F2")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x144041C", Offset = "0x144041C", VA = "0x144041C")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8BFFE0", Offset = "0x8BFFE0")]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x14404FC", Offset = "0x14404FC", VA = "0x14404FC")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x14405AC", Offset = "0x14405AC", VA = "0x14405AC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006D6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C10D8", Offset = "0x8C10D8")]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x400032E")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x400032F")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x14409B0", Offset = "0x14409B0", VA = "0x14409B0")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1440A64", Offset = "0x1440A64", VA = "0x1440A64", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x60006DB")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006DC")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x144148C", Offset = "0x144148C", VA = "0x144148C")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x14410C8", Offset = "0x14410C8", VA = "0x14410C8")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1441534", Offset = "0x1441534", VA = "0x1441534", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006E0")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60006E1")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F5")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x144153C", Offset = "0x144153C", VA = "0x144153C")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C11B0", Offset = "0x8C11B0")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x144161C", Offset = "0x144161C", VA = "0x144161C")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x14416CC", Offset = "0x14416CC", VA = "0x14416CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006E6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006E7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1248", Offset = "0x8C1248")]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x14418C0", Offset = "0x14418C0", VA = "0x14418C0")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1441970", Offset = "0x1441970", VA = "0x1441970", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006EB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1441ABC", Offset = "0x1441ABC", VA = "0x1441ABC")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C12D0", Offset = "0x8C12D0")]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1441B9C", Offset = "0x1441B9C", VA = "0x1441B9C")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1441C4C", Offset = "0x1441C4C", VA = "0x1441C4C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006F1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1441DB0", Offset = "0x1441DB0", VA = "0x1441DB0")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1358", Offset = "0x8C1358")]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1441E90", Offset = "0x1441E90", VA = "0x1441E90")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1441F40", Offset = "0x1441F40", VA = "0x1441F40", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006F7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006F8")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1400", Offset = "0x8C1400")]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x14423D8", Offset = "0x14423D8", VA = "0x14423D8")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1442488", Offset = "0x1442488", VA = "0x1442488", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006FC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FD")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x14426C4", Offset = "0x14426C4", VA = "0x14426C4")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C14A8", Offset = "0x8C14A8")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x14427A4", Offset = "0x14427A4", VA = "0x14427A4")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1442854", Offset = "0x1442854", VA = "0x1442854", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000701")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1540", Offset = "0x8C1540")]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1442954", Offset = "0x1442954", VA = "0x1442954")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1442A04", Offset = "0x1442A04", VA = "0x1442A04", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000705")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1708", Offset = "0x8C1708")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x14432B8", Offset = "0x14432B8", VA = "0x14432B8")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1443368", Offset = "0x1443368", VA = "0x1443368", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000709")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600070A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1830", Offset = "0x8C1830")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1443870", Offset = "0x1443870", VA = "0x1443870")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1443920", Offset = "0x1443920", VA = "0x1443920", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600070E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1958", Offset = "0x8C1958")]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1443E18", Offset = "0x1443E18", VA = "0x1443E18")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1443EC8", Offset = "0x1443EC8", VA = "0x1443EC8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000713")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1C10", Offset = "0x8C1C10")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1444C4C", Offset = "0x1444C4C", VA = "0x1444C4C")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1444D00", Offset = "0x1444D00", VA = "0x1444D00", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000718")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000719")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x144BCE8", Offset = "0x144BCE8", VA = "0x144BCE8")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1CC8", Offset = "0x8C1CC8")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x144BDC8", Offset = "0x144BDC8", VA = "0x144BDC8")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x144BE78", Offset = "0x144BE78", VA = "0x144BE78", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600071E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000106")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x144C0E8", Offset = "0x144C0E8", VA = "0x144C0E8")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1D70", Offset = "0x8C1D70")]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x144C1C8", Offset = "0x144C1C8", VA = "0x144C1C8")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x144C27C", Offset = "0x144C27C", VA = "0x144C27C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000723")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1EB8", Offset = "0x8C1EB8")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x144DA4C", Offset = "0x144DA4C", VA = "0x144DA4C")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x144DAFC", Offset = "0x144DAFC", VA = "0x144DAFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000728")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C1FA0", Offset = "0x8C1FA0")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x144DE20", Offset = "0x144DE20", VA = "0x144DE20")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x144DED0", Offset = "0x144DED0", VA = "0x144DED0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600072D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2078", Offset = "0x8C2078")]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x144E1D0", Offset = "0x144E1D0", VA = "0x144E1D0")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x144E280", Offset = "0x144E280", VA = "0x144E280", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000731")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2290", Offset = "0x8C2290")]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x144F764", Offset = "0x144F764", VA = "0x144F764")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x144F814", Offset = "0x144F814", VA = "0x144F814", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000736")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000737")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010C")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x144FAF4", Offset = "0x144FAF4", VA = "0x144FAF4")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2348", Offset = "0x8C2348")]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x144FBD4", Offset = "0x144FBD4", VA = "0x144FBD4")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x144FC84", Offset = "0x144FC84", VA = "0x144FC84", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600073C")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600073D")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010E")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x144FE48", Offset = "0x144FE48", VA = "0x144FE48")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C23D0", Offset = "0x8C23D0")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1450680", Offset = "0x1450680", VA = "0x1450680")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1450730", Offset = "0x1450730", VA = "0x1450730", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000742")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000110")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1450930", Offset = "0x1450930", VA = "0x1450930")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2478", Offset = "0x8C2478")]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1450A10", Offset = "0x1450A10", VA = "0x1450A10")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1450AC0", Offset = "0x1450AC0", VA = "0x1450AC0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000747")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2520", Offset = "0x8C2520")]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xFC4BC4", Offset = "0xFC4BC4", VA = "0xFC4BC4")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xFC4C78", Offset = "0xFC4C78", VA = "0xFC4C78", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600074B")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2648", Offset = "0x8C2648")]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xFC523C", Offset = "0xFC523C", VA = "0xFC523C")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xFC52F0", Offset = "0xFC52F0", VA = "0xFC52F0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600074F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2740", Offset = "0x8C2740")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xFC572C", Offset = "0xFC572C", VA = "0xFC572C")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xFC57E0", Offset = "0xFC57E0", VA = "0xFC57E0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000754")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2828", Offset = "0x8C2828")]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xFC5BA4", Offset = "0xFC5BA4", VA = "0xFC5BA4")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xFC5C58", Offset = "0xFC5C58", VA = "0xFC5C58", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000759")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600075A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xFC5E30", Offset = "0xFC5E30", VA = "0xFC5E30")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C28B0", Offset = "0x8C28B0")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xFC5F08", Offset = "0xFC5F08", VA = "0xFC5F08")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xFC5FBC", Offset = "0xFC5FBC", VA = "0xFC5FBC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600075F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2A48", Offset = "0x8C2A48")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xFC672C", Offset = "0xFC672C", VA = "0xFC672C")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xFC67E0", Offset = "0xFC67E0", VA = "0xFC67E0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000764")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2B60", Offset = "0x8C2B60")]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xFC6CBC", Offset = "0xFC6CBC", VA = "0xFC6CBC")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xFC6D70", Offset = "0xFC6D70", VA = "0xFC6D70", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000769")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600076A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2C68", Offset = "0x8C2C68")]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xFC71D8", Offset = "0xFC71D8", VA = "0xFC71D8")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xFC728C", Offset = "0xFC728C", VA = "0xFC728C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600076E")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xFC7CB8", Offset = "0xFC7CB8", VA = "0xFC7CB8")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2E40", Offset = "0x8C2E40")]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xFC81D0", Offset = "0xFC81D0", VA = "0xFC81D0")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xFC82C0", Offset = "0xFC82C0", VA = "0xFC82C0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000773")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000774")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C2EF8", Offset = "0x8C2EF8")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xFC863C", Offset = "0xFC863C", VA = "0xFC863C")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xFC86F0", Offset = "0xFC86F0", VA = "0xFC86F0", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000778")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xFC9000", Offset = "0xFC9000", VA = "0xFC9000")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C30A0", Offset = "0x8C30A0")]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xFC91B0", Offset = "0xFC91B0", VA = "0xFC91B0")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xFC9264", Offset = "0xFC9264", VA = "0xFC9264", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600077D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C3138", Offset = "0x8C3138")]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xFC9DB4", Offset = "0xFC9DB4", VA = "0xFC9DB4")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xFC9E68", Offset = "0xFC9E68", VA = "0xFC9E68", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000782")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000783")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000121")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xFCA624", Offset = "0xFCA624", VA = "0xFCA624")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C31F0", Offset = "0x8C31F0")]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xFC9FF4", Offset = "0xFC9FF4", VA = "0xFC9FF4")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xFCA0B4", Offset = "0xFCA0B4", VA = "0xFCA0B4", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000788")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000789")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000123")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xFCA54C", Offset = "0xFCA54C", VA = "0xFCA54C")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C32A8", Offset = "0x8C32A8")]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xFCA6FC", Offset = "0xFCA6FC", VA = "0xFCA6FC")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xFCA7B0", Offset = "0xFCA7B0", VA = "0xFCA7B0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600078E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600078F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C33F0", Offset = "0x8C33F0")]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xFCAD70", Offset = "0xFCAD70", VA = "0xFCAD70")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xFCAE24", Offset = "0xFCAE24", VA = "0xFCAE24", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000793")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000794")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C3548", Offset = "0x8C3548")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xFCB75C", Offset = "0xFCB75C", VA = "0xFCB75C")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xFCB810", Offset = "0xFCB810", VA = "0xFCB810", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000798")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C3610", Offset = "0x8C3610")]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xFCBD08", Offset = "0xFCBD08", VA = "0xFCBD08")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xFCBDBC", Offset = "0xFCBDBC", VA = "0xFCBDBC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600079D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000128")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xFCBF08", Offset = "0xFCBF08", VA = "0xFCBF08")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C3698", Offset = "0x8C3698")]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xFCBFE0", Offset = "0xFCBFE0", VA = "0xFCBFE0")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xFCC094", Offset = "0xFCC094", VA = "0xFCC094", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007A2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200012A")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xFCC240", Offset = "0xFCC240", VA = "0xFCC240")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C3730", Offset = "0x8C3730")]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xFCC318", Offset = "0xFCC318", VA = "0xFCC318")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xFCC3CC", Offset = "0xFCC3CC", VA = "0xFCC3CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007A7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200012C")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xFCC5B0", Offset = "0xFCC5B0", VA = "0xFCC5B0")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C37C8", Offset = "0x8C37C8")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xFCC688", Offset = "0xFCC688", VA = "0xFCC688")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xFCC73C", Offset = "0xFCC73C", VA = "0xFCC73C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007AC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xFCC938", Offset = "0xFCC938", VA = "0xFCC938")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012E")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xFCCA88", Offset = "0xFCCA88", VA = "0xFCCA88")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x8C3870", Offset = "0x8C3870")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xFCCB60", Offset = "0xFCCB60", VA = "0xFCCB60")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xFCCC14", Offset = "0xFCCC14", VA = "0xFCCC14", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007B2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007B3")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x2000130")]
	public static class ES3Hash
	{
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xF9E2F8", Offset = "0xF9E2F8", VA = "0xF9E2F8")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000131")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x60007B6")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x60007B7")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1431424", Offset = "0x1431424", VA = "0x1431424")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x14314FC", Offset = "0x14314FC", VA = "0x14314FC")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x400036C")]
		private const int ivSize = 16;

		[Token(Token = "0x400036D")]
		private const int keySize = 16;

		[Token(Token = "0x400036E")]
		private const int pwIterations = 100;

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xF9D558", Offset = "0xF9D558", VA = "0xF9D558", Slot = "4")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xF9DA30", Offset = "0xF9DA30", VA = "0xF9DA30", Slot = "5")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xF9DEC0", Offset = "0xF9DEC0", VA = "0xF9DEC0")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1431504", Offset = "0x1431504", VA = "0x1431504")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x14315B0", Offset = "0x14315B0", VA = "0x14315B0", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000134")]
	public struct ES3Data
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x9A4AC4", Offset = "0x9A4AC4", VA = "0x9A4AC4")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x9A4ACC", Offset = "0x9A4ACC", VA = "0x9A4ACC")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x2000135")]
	public static class ES3IO
	{
		[Token(Token = "0x200019E")]
		public enum ES3FileMode
		{
			[Token(Token = "0x4000500")]
			Read,
			[Token(Token = "0x4000501")]
			Write,
			[Token(Token = "0x4000502")]
			Append
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xF960D4", Offset = "0xF960D4", VA = "0xF960D4")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xF92944", Offset = "0xF92944", VA = "0xF92944")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xF93700", Offset = "0xF93700", VA = "0xF93700")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xF93A9C", Offset = "0xF93A9C", VA = "0xF93A9C")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xF93E50", Offset = "0xF93E50", VA = "0xF93E50")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xF93AA4", Offset = "0xF93AA4", VA = "0xF93AA4")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xF9E2D0", Offset = "0xF9E2D0", VA = "0xF9E2D0")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xF94CB8", Offset = "0xF94CB8", VA = "0xF94CB8")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xF9E268", Offset = "0xF9E268", VA = "0xF9E268")]
		public static string GetDirectoryName(string path)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xF9585C", Offset = "0xF9585C", VA = "0xF9585C")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xF94094", Offset = "0xF94094", VA = "0xF94094")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xF954E0", Offset = "0xF954E0", VA = "0xF954E0")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xF9E4B0", Offset = "0xF9E4B0", VA = "0xF9E4B0")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xF9E4B8", Offset = "0xF9E4B8", VA = "0xF9E4B8")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xF91C64", Offset = "0xF91C64", VA = "0xF91C64")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xFA1ED4", Offset = "0xFA1ED4", VA = "0xFA1ED4")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xFA2340", Offset = "0xFA2340", VA = "0xFA2340")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xFA23C8", Offset = "0xFA23C8", VA = "0xFA23C8")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xFA24E0", Offset = "0xFA24E0", VA = "0xFA24E0")]
		public Dictionary<long, long> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xFA2718", Offset = "0xFA2718", VA = "0xFA2718")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xFA2484", Offset = "0xFA2484", VA = "0xFA2484")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xFA2B88", Offset = "0xFA2B88", VA = "0xFA2B88")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000137")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x4000378")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Random rng;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool openReferences;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x17000048")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0xFA20CC", Offset = "0xFA20CC", VA = "0xFA20CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public bool IsInitialised
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xFA2CC8", Offset = "0xFA2CC8", VA = "0xFA2CC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xFA2D34", Offset = "0xFA2D34", VA = "0xFA2D34")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xFA2F3C", Offset = "0xFA2F3C", VA = "0xFA2F3C")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xFA31D8", Offset = "0xFA31D8", VA = "0xFA31D8")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xFA3260", Offset = "0xFA3260", VA = "0xFA3260")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xFA32F8", Offset = "0xFA32F8", VA = "0xFA32F8")]
		public ES3Prefab GetPrefab(long id)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xFA33EC", Offset = "0xFA33EC", VA = "0xFA33EC")]
		public long GetPrefab(ES3Prefab prefab)
		{
			return default(long);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xFA2280", Offset = "0xFA2280", VA = "0xFA2280")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xFA2958", Offset = "0xFA2958", VA = "0xFA2958")]
		public void Add(UnityEngine.Object obj, long id)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xFA351C", Offset = "0xFA351C", VA = "0xFA351C")]
		public void AddPrefab(ES3Prefab prefab)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xFA35C8", Offset = "0xFA35C8", VA = "0xFA35C8")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xFA3674", Offset = "0xFA3674", VA = "0xFA3674")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xFA371C", Offset = "0xFA371C", VA = "0xFA371C")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xFA378C", Offset = "0xFA378C", VA = "0xFA378C")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xFA2A00", Offset = "0xFA2A00", VA = "0xFA2A00")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xFA37FC", Offset = "0xFA37FC", VA = "0xFA37FC")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000138")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xF9E4C0", Offset = "0xF9E4C0", VA = "0xF9E4C0", Slot = "6")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xF9E4CC", Offset = "0xF9E4CC", VA = "0xF9E4CC", Slot = "7")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xF9E544", Offset = "0xF9E544", VA = "0xF9E544")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C3968", Offset = "0x8C3968")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xFA2C44", Offset = "0xFA2C44", VA = "0xFA2C44", Slot = "6")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xFA2CBC", Offset = "0xFA2CBC", VA = "0xFA2CBC", Slot = "7")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xFA2BF4", Offset = "0xFA2BF4", VA = "0xFA2BF4")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public static class ES3Reflection
	{
		[Token(Token = "0x200019F")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x17000084")]
			public bool IsNull
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x9A4B20", Offset = "0x9A4B20", VA = "0x9A4B20")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000085")]
			public string Name
			{
				[Token(Token = "0x60009A1")]
				[Address(RVA = "0x9A4B28", Offset = "0x9A4B28", VA = "0x9A4B28")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			public Type MemberType
			{
				[Token(Token = "0x60009A2")]
				[Address(RVA = "0x9A4B30", Offset = "0x9A4B30", VA = "0x9A4B30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			public bool IsPublic
			{
				[Token(Token = "0x60009A3")]
				[Address(RVA = "0x9A4B38", Offset = "0x9A4B38", VA = "0x9A4B38")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000088")]
			public bool IsProtected
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0x9A4B40", Offset = "0x9A4B40", VA = "0x9A4B40")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x9A4B48", Offset = "0x9A4B48", VA = "0x9A4B48")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x9A4B50", Offset = "0x9A4B50", VA = "0x9A4B50")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x9A4B58", Offset = "0x9A4B58", VA = "0x9A4B58")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x20001A0")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0xFA5B64", Offset = "0xFA5B64", VA = "0xFA5B64")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0xFA64A0", Offset = "0xFA64A0", VA = "0xFA64A0")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x20001A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3BBC", Offset = "0x8C3BBC")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xFA5A38", Offset = "0xFA5A38", VA = "0xFA5A38")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xFA6134", Offset = "0xFA6134", VA = "0xFA6134")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20001A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3BCC", Offset = "0x8C3BCC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__24_0;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, <>f__AnonymousType0<Assembly, Type>> <>9__24_1;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType0<Assembly, Type>, Type> <>9__24_3;

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xFA601C", Offset = "0xFA601C", VA = "0xFA601C")]
			public <>c()
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0xFA6024", Offset = "0xFA6024", VA = "0xFA6024")]
			internal IEnumerable<Type> <GetDerivedTypes>b__24_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0xFA605C", Offset = "0xFA605C", VA = "0xFA605C")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__24_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0xFA60D8", Offset = "0xFA60D8", VA = "0xFA60D8")]
			internal Type <GetDerivedTypes>b__24_3(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x400037F")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x4000380")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x4000381")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x1700004A")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0xFA388C", Offset = "0xFA388C", VA = "0xFA388C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xFA3B90", Offset = "0xFA3B90", VA = "0xFA3B90")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xFA3DAC", Offset = "0xFA3DAC", VA = "0xFA3DAC")]
		public static List<FieldInfo> GetSerializableFields(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xFA4524", Offset = "0xFA4524", VA = "0xFA4524")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xFA4194", Offset = "0xFA4194", VA = "0xFA4194")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xFA4C2C", Offset = "0xFA4C2C", VA = "0xFA4C2C")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xFA4DB8", Offset = "0xFA4DB8", VA = "0xFA4DB8")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xFA4F58", Offset = "0xFA4F58", VA = "0xFA4F58")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xFA4FEC", Offset = "0xFA4FEC", VA = "0xFA4FEC")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xFA4FF4", Offset = "0xFA4FF4", VA = "0xFA4FF4")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xFA50CC", Offset = "0xFA50CC", VA = "0xFA50CC")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xFA5594", Offset = "0xFA5594", VA = "0xFA5594")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xFA5658", Offset = "0xFA5658", VA = "0xFA5658")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x60007FC")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xFA5748", Offset = "0xFA5748", VA = "0xFA5748")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xFA4158", Offset = "0xFA4158", VA = "0xFA4158")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xFA5A40", Offset = "0xFA5A40", VA = "0xFA5A40")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xFA3D44", Offset = "0xFA3D44", VA = "0xFA3D44")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xFA5A74", Offset = "0xFA5A74", VA = "0xFA5A74")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xFA5AA8", Offset = "0xFA5AA8", VA = "0xFA5AA8")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xFA5ADC", Offset = "0xFA5ADC", VA = "0xFA5ADC")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xFA4AF0", Offset = "0xFA4AF0", VA = "0xFA4AF0")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xFA3D78", Offset = "0xFA3D78", VA = "0xFA3D78")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xFA5BF0", Offset = "0xFA5BF0", VA = "0xFA5BF0")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xFA3D10", Offset = "0xFA3D10", VA = "0xFA3D10")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xFA4AC4", Offset = "0xFA4AC4", VA = "0xFA4AC4")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xFA5C1C", Offset = "0xFA5C1C", VA = "0xFA5C1C")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xFA4B1C", Offset = "0xFA4B1C", VA = "0xFA4B1C")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xFA5C50", Offset = "0xFA5C50", VA = "0xFA5C50")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xFA5CD4", Offset = "0xFA5CD4", VA = "0xFA5CD4")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xFA5620", Offset = "0xFA5620", VA = "0xFA5620")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xFA5708", Offset = "0xFA5708", VA = "0xFA5708")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xFA49C4", Offset = "0xFA49C4", VA = "0xFA49C4")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xFA414C", Offset = "0xFA414C", VA = "0xFA414C")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xFA5DA8", Offset = "0xFA5DA8", VA = "0xFA5DA8")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xFA5DE8", Offset = "0xFA5DE8", VA = "0xFA5DE8")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8C397C", Offset = "0x8C397C")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : IEnumerable, IEnumerable<KeyValuePair<TKey, TVal>>
	{
		[Token(Token = "0x20001A3")]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ES3SerializableDictionary<TKey, TVal> _Dictionary;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _Index;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TVal> _Current;

			[Token(Token = "0x17000089")]
			public KeyValuePair<TKey, TVal> Current
			{
				[Token(Token = "0x60009B1")]
				get
				{
					return default(KeyValuePair<TKey, TVal>);
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B2")]
			public Enumerator(ES3SerializableDictionary<TKey, TVal> dictionary)
			{
			}

			[Token(Token = "0x60009B3")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B4")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60009B6")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x1700004B")]
		public List<TKey> Keys
		{
			[Token(Token = "0x6000816")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public List<TVal> Values
		{
			[Token(Token = "0x6000817")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public int Count
		{
			[Token(Token = "0x6000818")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004E")]
		public TVal Item
		{
			[Token(Token = "0x600081A")]
			get
			{
				return (TVal)null;
			}
			[Token(Token = "0x600081B")]
			set
			{
			}
		}

		[Token(Token = "0x6000814")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x6000815")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x6000819")]
		public void Add(TKey key, TVal value)
		{
		}

		[Token(Token = "0x600081C")]
		public bool TryGetValue(TKey key, out TVal val)
		{
			return default(bool);
		}

		[Token(Token = "0x600081D")]
		public bool TryGetKey(TVal value, out TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600081E")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		public bool ContainsValue(TVal value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000820")]
		public void Remove(TKey key)
		{
		}

		[Token(Token = "0x6000821")]
		public int RemoveNullKeys()
		{
			return default(int);
		}

		[Token(Token = "0x6000822")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x6000823")]
		public bool ChangeKey(TKey oldId, TKey newId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000824")]
		private int FindKeyIndex(TKey key)
		{
			return default(int);
		}

		[Token(Token = "0x6000825")]
		private int FindValueIndex(TVal value)
		{
			return default(int);
		}

		[Token(Token = "0x6000826")]
		private void Insert(TKey key, TVal value)
		{
		}

		[Token(Token = "0x6000827")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000828")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000829")]
		private IEnumerator<KeyValuePair<TKey, TVal>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TVal>>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600082A")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x400038A")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StreamReader baseReader;

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xF9E594", Offset = "0xF9E594", VA = "0xF9E594")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xF9E7A8", Offset = "0xF9E7A8", VA = "0xF9E7A8", Slot = "20")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xF9ECDC", Offset = "0xF9ECDC", VA = "0xF9ECDC", Slot = "21")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xF9EE88", Offset = "0xF9EE88", VA = "0xF9EE88", Slot = "22")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xF9EE98", Offset = "0xF9EE98", VA = "0xF9EE98", Slot = "26")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xF9F198", Offset = "0xF9F198", VA = "0xF9F198", Slot = "27")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xF9F1A0", Offset = "0xF9F1A0", VA = "0xF9F1A0", Slot = "28")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xF9F1B0", Offset = "0xF9F1B0", VA = "0xF9F1B0", Slot = "29")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xF9F1B4", Offset = "0xF9F1B4", VA = "0xF9F1B4", Slot = "30")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xF9F1F4", Offset = "0xF9F1F4", VA = "0xF9F1F4", Slot = "31")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xF9F1FC", Offset = "0xF9F1FC", VA = "0xF9F1FC", Slot = "32")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xF9F200", Offset = "0xF9F200", VA = "0xF9F200", Slot = "33")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xF9F2EC", Offset = "0xF9F2EC", VA = "0xF9F2EC", Slot = "34")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xF9F2F4", Offset = "0xF9F2F4", VA = "0xF9F2F4", Slot = "35")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xF9F2F8", Offset = "0xF9F2F8", VA = "0xF9F2F8", Slot = "36")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xF9F338", Offset = "0xF9F338", VA = "0xF9F338", Slot = "37")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xF9F424", Offset = "0xF9F424", VA = "0xF9F424", Slot = "24")]
		internal override bool Goto(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xF9F4BC", Offset = "0xF9F4BC", VA = "0xF9F4BC")]
		protected void Reset()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xF9F590", Offset = "0xF9F590", VA = "0xF9F590")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xF9F700", Offset = "0xF9F700", VA = "0xF9F700", Slot = "23")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xF9F688", Offset = "0xF9F688", VA = "0xF9F688")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xF9E9C4", Offset = "0xF9E9C4", VA = "0xF9E9C4")]
		private char ReadCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xF9EEA0", Offset = "0xF9EEA0", VA = "0xF9EEA0")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xF9EAC8", Offset = "0xF9EAC8", VA = "0xF9EAC8")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xF9FDF4", Offset = "0xF9FDF4", VA = "0xF9FDF4")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xFA0000", Offset = "0xFA0000", VA = "0xFA0000")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xF9E924", Offset = "0xF9E924", VA = "0xF9E924")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xFA0214", Offset = "0xFA0214", VA = "0xFA0214")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xF9E6D0", Offset = "0xF9E6D0", VA = "0xF9E6D0")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xF9FDBC", Offset = "0xF9FDBC", VA = "0xF9FDBC")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xF9FD4C", Offset = "0xF9FD4C", VA = "0xF9FD4C")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xF9FD60", Offset = "0xF9FD60", VA = "0xF9FD60")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xF9E9B0", Offset = "0xF9E9B0", VA = "0xF9E9B0")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xF9EA9C", Offset = "0xF9EA9C", VA = "0xF9EA9C")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xFA02A0", Offset = "0xFA02A0", VA = "0xFA02A0")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xFA02B0", Offset = "0xFA02B0", VA = "0xFA02B0")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xFA0400", Offset = "0xFA0400", VA = "0xFA0400", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xFA05E8", Offset = "0xFA05E8", VA = "0xFA05E8", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xFA066C", Offset = "0xFA066C", VA = "0xFA066C", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xFA06F0", Offset = "0xFA06F0", VA = "0xFA06F0", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xFA0708", Offset = "0xFA0708", VA = "0xFA0708", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xFA0780", Offset = "0xFA0780", VA = "0xFA0780", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xFA082C", Offset = "0xFA082C", VA = "0xFA082C", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xFA08D8", Offset = "0xFA08D8", VA = "0xFA08D8", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xFA08F0", Offset = "0xFA08F0", VA = "0xFA08F0", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xFA0908", Offset = "0xFA0908", VA = "0xFA0908", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xFA0920", Offset = "0xFA0920", VA = "0xFA0920", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xFA093C", Offset = "0xFA093C", VA = "0xFA093C", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xFA0958", Offset = "0xFA0958", VA = "0xFA0958", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xFA0974", Offset = "0xFA0974", VA = "0xFA0974", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xFA0990", Offset = "0xFA0990", VA = "0xFA0990", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xFA0A14", Offset = "0xFA0A14", VA = "0xFA0A14", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addMgrToSceneAutomatically;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool autoUpdateReferences;

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xF9E0A8", Offset = "0xF9E0A8", VA = "0xF9E0A8")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public enum ES3FileMode
	{
		[Token(Token = "0x4000390")]
		Read,
		[Token(Token = "0x4000391")]
		Write,
		[Token(Token = "0x4000392")]
		Append
	}
	[Token(Token = "0x200013F")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xF9E0B8", Offset = "0xF9E0B8", VA = "0xF9E0B8")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xF9E18C", Offset = "0xF9E18C", VA = "0xF9E18C")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xF9E238", Offset = "0xF9E238", VA = "0xF9E238")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xF9E258", Offset = "0xF9E258", VA = "0xF9E258")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xF9E2D8", Offset = "0xF9E2D8", VA = "0xF9E2D8", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000140")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xFA1A68", Offset = "0xFA1A68", VA = "0xFA1A68")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xFA1BA0", Offset = "0xFA1BA0", VA = "0xFA1BA0")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xFA1AAC", Offset = "0xFA1AAC", VA = "0xFA1AAC")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xFA1BEC", Offset = "0xFA1BEC", VA = "0xFA1BEC", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000141")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x1700004F")]
		public bool Exists
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xFA64E8", Offset = "0xFA64E8", VA = "0xFA64E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xFA650C", Offset = "0xFA650C", VA = "0xFA650C")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xFA653C", Offset = "0xFA653C", VA = "0xFA653C")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xFA662C", Offset = "0xFA662C", VA = "0xFA662C", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000142")]
	public static class ES3Stream
	{
		[Token(Token = "0x600086D")]
		[Address(RVA = "0xF91860", Offset = "0xF91860", VA = "0xF91860")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}
	}
	[Token(Token = "0x2000143")]
	public class ES3Member
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xFA1910", Offset = "0xFA1910", VA = "0xFA1910")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xFA1954", Offset = "0xFA1954", VA = "0xFA1954")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x2000144")]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x8C46CC", Offset = "0x8C46CC")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xF9DF84", Offset = "0xF9DF84", VA = "0xF9DF84")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xFA6F20", Offset = "0xFA6F20", VA = "0xFA6F20")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xFA700C", Offset = "0xFA700C", VA = "0xFA700C")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xFA6638", Offset = "0xFA6638", VA = "0xFA6638")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xF961E4", Offset = "0xF961E4", VA = "0xF961E4")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class ES3WebClass
	{
		[Token(Token = "0x20001A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C3BDC", Offset = "0x8C3BDC")]
		private sealed class <SendWebRequest>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009BA")]
				[Address(RVA = "0xFA7268", Offset = "0xFA7268", VA = "0xFA7268", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009BC")]
				[Address(RVA = "0xFA72D8", Offset = "0xFA72D8", VA = "0xFA72D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0xFA71CC", Offset = "0xFA71CC", VA = "0xFA71CC")]
			[DebuggerHidden]
			public <SendWebRequest>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xFA71F8", Offset = "0xFA71F8", VA = "0xFA71F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0xFA71FC", Offset = "0xFA71FC", VA = "0xFA71FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0xFA7270", Offset = "0xFA7270", VA = "0xFA7270", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isDone;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string error;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long errorCode;

		[Token(Token = "0x17000050")]
		public bool isError
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0xFA70EC", Offset = "0xFA70EC", VA = "0xFA70EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xF96C50", Offset = "0xF96C50", VA = "0xF96C50")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xFA712C", Offset = "0xFA712C", VA = "0xFA712C")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xF99E48", Offset = "0xF99E48", VA = "0xF99E48")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xF99CA8", Offset = "0xF99CA8", VA = "0xF99CA8")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xF99F5C", Offset = "0xF99F5C", VA = "0xF99F5C")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xF99EE8", Offset = "0xF99EE8", VA = "0xF99EE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C58B8", Offset = "0x8C58B8")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xF999A0", Offset = "0xF999A0", VA = "0xF999A0", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x2000146")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xFA0A44", Offset = "0xFA0A44", VA = "0xFA0A44")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xFA0A50", Offset = "0xFA0A50", VA = "0xFA0A50")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xFA0B00", Offset = "0xFA0B00", VA = "0xFA0B00", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xFA0B40", Offset = "0xFA0B40", VA = "0xFA0B40", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xFA0BF0", Offset = "0xFA0BF0", VA = "0xFA0BF0", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xFA0C7C", Offset = "0xFA0C7C", VA = "0xFA0C7C", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xFA0D2C", Offset = "0xFA0D2C", VA = "0xFA0D2C", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xFA0DDC", Offset = "0xFA0DDC", VA = "0xFA0DDC", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xFA0E1C", Offset = "0xFA0E1C", VA = "0xFA0E1C", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xFA0E5C", Offset = "0xFA0E5C", VA = "0xFA0E5C", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xFA0E9C", Offset = "0xFA0E9C", VA = "0xFA0E9C", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xFA0F3C", Offset = "0xFA0F3C", VA = "0xFA0F3C", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xFA0FDC", Offset = "0xFA0FDC", VA = "0xFA0FDC", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xFA107C", Offset = "0xFA107C", VA = "0xFA107C", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xFA111C", Offset = "0xFA111C", VA = "0xFA111C", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xFA1160", Offset = "0xFA1160", VA = "0xFA1160", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xFA11EC", Offset = "0xFA11EC", VA = "0xFA11EC", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xFA1460", Offset = "0xFA1460", VA = "0xFA1460", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xFA14CC", Offset = "0xFA14CC", VA = "0xFA14CC")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xFA1500", Offset = "0xFA1500", VA = "0xFA1500")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xFA154C", Offset = "0xFA154C", VA = "0xFA154C", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xFA15FC", Offset = "0xFA15FC", VA = "0xFA15FC", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xFA1644", Offset = "0xFA1644", VA = "0xFA1644", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xFA168C", Offset = "0xFA168C", VA = "0xFA168C", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xFA16F0", Offset = "0xFA16F0", VA = "0xFA16F0", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xFA16F4", Offset = "0xFA16F4", VA = "0xFA16F4", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xFA1738", Offset = "0xFA1738", VA = "0xFA1738", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xFA1778", Offset = "0xFA1778", VA = "0xFA1778", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xFA17B4", Offset = "0xFA17B4", VA = "0xFA17B4", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xFA17F0", Offset = "0xFA17F0", VA = "0xFA17F0", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xFA1834", Offset = "0xFA1834", VA = "0xFA1834", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xFA1838", Offset = "0xFA1838", VA = "0xFA1838", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xFA1848", Offset = "0xFA1848", VA = "0xFA1848", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xFA1858", Offset = "0xFA1858", VA = "0xFA1858", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xFA189C", Offset = "0xFA189C", VA = "0xFA189C", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xFA18D8", Offset = "0xFA18D8", VA = "0xFA18D8", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xFA18DC", Offset = "0xFA18DC", VA = "0xFA18DC", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xFA18E0", Offset = "0xFA18E0", VA = "0xFA18E0", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000147")]
	internal class ES3XMLWriter : ES3Writer
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xFA72E0", Offset = "0xFA72E0", VA = "0xFA72E0")]
		public ES3XMLWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xFA72EC", Offset = "0xFA72EC", VA = "0xFA72EC")]
		internal ES3XMLWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xFA7394", Offset = "0xFA7394", VA = "0xFA7394", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xFA73D4", Offset = "0xFA73D4", VA = "0xFA73D4", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xFA741C", Offset = "0xFA741C", VA = "0xFA741C", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xFA745C", Offset = "0xFA745C", VA = "0xFA745C", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xFA749C", Offset = "0xFA749C", VA = "0xFA749C", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xFA74EC", Offset = "0xFA74EC", VA = "0xFA74EC", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xFA7534", Offset = "0xFA7534", VA = "0xFA7534", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xFA7574", Offset = "0xFA7574", VA = "0xFA7574", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xFA75B4", Offset = "0xFA75B4", VA = "0xFA75B4", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xFA75F4", Offset = "0xFA75F4", VA = "0xFA75F4", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xFA7634", Offset = "0xFA7634", VA = "0xFA7634", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xFA76D4", Offset = "0xFA76D4", VA = "0xFA76D4", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xFA7774", Offset = "0xFA7774", VA = "0xFA7774", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xFA7814", Offset = "0xFA7814", VA = "0xFA7814", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xFA78B4", Offset = "0xFA78B4", VA = "0xFA78B4", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xFA7940", Offset = "0xFA7940", VA = "0xFA7940", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] bytes)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xFA7E4C", Offset = "0xFA7E4C", VA = "0xFA7E4C", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xFA7E50", Offset = "0xFA7E50", VA = "0xFA7E50", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xFA7E54", Offset = "0xFA7E54", VA = "0xFA7E54", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xFA7E5C", Offset = "0xFA7E5C", VA = "0xFA7E5C", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xFA7E68", Offset = "0xFA7E68", VA = "0xFA7E68", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xFA7A0C", Offset = "0xFA7A0C", VA = "0xFA7A0C")]
		protected void StartWriteProperty(string name, [Optional] ICollection<KeyValuePair<string, object>> attributes)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xFA7F04", Offset = "0xFA7F04", VA = "0xFA7F04", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xFA7FCC", Offset = "0xFA7FCC", VA = "0xFA7FCC", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xFA7FD0", Offset = "0xFA7FD0", VA = "0xFA7FD0", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xFA7FD4", Offset = "0xFA7FD4", VA = "0xFA7FD4", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xFA7FD8", Offset = "0xFA7FD8", VA = "0xFA7FD8", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xFA7FDC", Offset = "0xFA7FDC", VA = "0xFA7FDC", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xFA7FE0", Offset = "0xFA7FE0", VA = "0xFA7FE0", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xFA7FE4", Offset = "0xFA7FE4", VA = "0xFA7FE4", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xFA7FE8", Offset = "0xFA7FE8", VA = "0xFA7FE8", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xFA7FEC", Offset = "0xFA7FEC", VA = "0xFA7FEC", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xFA7FF0", Offset = "0xFA7FF0", VA = "0xFA7FF0", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xFA7FF4", Offset = "0xFA7FF4", VA = "0xFA7FF4", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xFA8060", Offset = "0xFA8060", VA = "0xFA8060", Slot = "22")]
		public override void Dispose()
		{
		}
	}
}
namespace MoodkieSecurity
{
	[Token(Token = "0x2000148")]
	public enum AESBits
	{
		[Token(Token = "0x40003A8")]
		BITS128,
		[Token(Token = "0x40003A9")]
		BITS192,
		[Token(Token = "0x40003AA")]
		BITS256
	}
	[Token(Token = "0x2000149")]
	public class AESEncryptor
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string fPassword;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AESBits fEncryptionBits;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] fSalt;

		[Token(Token = "0x17000051")]
		public string Password
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xFD3780", Offset = "0xFD3780", VA = "0xFD3780")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xFD3788", Offset = "0xFD3788", VA = "0xFD3788")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public AESBits EncryptionBits
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xFD3790", Offset = "0xFD3790", VA = "0xFD3790")]
			get
			{
				return default(AESBits);
			}
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xFD3798", Offset = "0xFD3798", VA = "0xFD3798")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public byte[] Salt
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0xFD37A0", Offset = "0xFD37A0", VA = "0xFD37A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xFD37A8", Offset = "0xFD37A8", VA = "0xFD37A8")]
			set
			{
			}
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xFD3080", Offset = "0xFD3080", VA = "0xFD3080")]
		public AESEncryptor(string password, AESBits encryptionBits)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xFD3114", Offset = "0xFD3114", VA = "0xFD3114")]
		public AESEncryptor(string password, AESBits encryptionBits, byte[] salt)
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xFD31B8", Offset = "0xFD31B8", VA = "0xFD31B8")]
		private byte[] Encrypt(byte[] data, byte[] key, byte[] iV)
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xFD3368", Offset = "0xFD3368", VA = "0xFD3368")]
		public byte[] Encrypt(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xFD349C", Offset = "0xFD349C", VA = "0xFD349C")]
		private byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xFD364C", Offset = "0xFD364C", VA = "0xFD364C")]
		public byte[] Decrypt(byte[] data)
		{
			return null;
		}
	}
	[Token(Token = "0x200014A")]
	internal struct ABCDStruct
	{
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint A;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint B;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint C;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint D;
	}
	[Token(Token = "0x200014B")]
	public sealed class MD5Core
	{
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xFD37B0", Offset = "0xFD37B0", VA = "0xFD37B0")]
		private MD5Core()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xFD37B8", Offset = "0xFD37B8", VA = "0xFD37B8")]
		public static byte[] GetHash(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xFD3990", Offset = "0xFD3990", VA = "0xFD3990")]
		public static byte[] GetHash(string input)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xFD39F4", Offset = "0xFD39F4", VA = "0xFD39F4")]
		public static string GetHashString(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xFD3AF0", Offset = "0xFD3AF0", VA = "0xFD3AF0")]
		public static string GetHashString(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xFD3BD0", Offset = "0xFD3BD0", VA = "0xFD3BD0")]
		public static string GetHashString(string input)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xFD3898", Offset = "0xFD3898", VA = "0xFD3898")]
		public static byte[] GetHash(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xFD4E20", Offset = "0xFD4E20", VA = "0xFD4E20")]
		internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ABCDStruct ABCD, long len)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xFD3C34", Offset = "0xFD3C34", VA = "0xFD3C34")]
		internal static void GetHashBlock(byte[] input, ref ABCDStruct ABCDValue, int ibStart)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xFD52BC", Offset = "0xFD52BC", VA = "0xFD52BC")]
		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xFD52E8", Offset = "0xFD52E8", VA = "0xFD52E8")]
		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xFD5314", Offset = "0xFD5314", VA = "0xFD5314")]
		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xFD533C", Offset = "0xFD533C", VA = "0xFD533C")]
		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xFD5364", Offset = "0xFD5364", VA = "0xFD5364")]
		private static uint LSR(uint i, int s)
		{
			return default(uint);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xFD5070", Offset = "0xFD5070", VA = "0xFD5070")]
		private static uint[] Converter(byte[] input, int ibStart)
		{
			return null;
		}
	}
	[Token(Token = "0x200014C")]
	public class MD5Encryptor
	{
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xFD5374", Offset = "0xFD5374", VA = "0xFD5374")]
		public MD5Encryptor()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xFD537C", Offset = "0xFD537C", VA = "0xFD537C")]
		public string GetMD5(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xFD5384", Offset = "0xFD5384", VA = "0xFD5384")]
		public string GetMD5(string data)
		{
			return null;
		}
	}
	[Token(Token = "0x200014D")]
	public class Obfuscator
	{
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xFD538C", Offset = "0xFD538C", VA = "0xFD538C")]
		public static byte[] Obfuscate(byte[] data, string key)
		{
			return null;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xFD5478", Offset = "0xFD5478", VA = "0xFD5478")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xFD5534", Offset = "0xFD5534", VA = "0xFD5534")]
		public Obfuscator()
		{
		}
	}
}
