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
using UnityEngine.UI;

[assembly: AssemblyVersion("3.7.1.6")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F6560", Offset = "0x9F6560")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9FC190", Offset = "0x9FC190")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9FC1A4", Offset = "0x9FC1A4")]
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
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6570", Offset = "0x9F6570")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC268", Offset = "0x9FC268")]
	private bool <selectionChanged>k__BackingField;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	public bool saveButtonSelected;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC288", Offset = "0x9FC288")]
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
		[Address(RVA = "0x13E9DB8", Offset = "0x13E9DB8", VA = "0x13E9DB8", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public bool selected
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x13E9DBC", Offset = "0x13E9DBC", VA = "0x13E9DBC", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x13E9DC4", Offset = "0x13E9DC4", VA = "0x13E9DC4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool selectionChanged
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x13E9DD8", Offset = "0x13E9DD8", VA = "0x13E9DD8", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD3C", Offset = "0x9FCD3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x13E9DE0", Offset = "0x13E9DE0", VA = "0x13E9DE0", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD4C", Offset = "0x9FCD4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public bool buttonSelected
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x13E9DEC", Offset = "0x13E9DEC", VA = "0x13E9DEC", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x13E9DF4", Offset = "0x13E9DF4", VA = "0x13E9DF4", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x13E9E08", Offset = "0x13E9E08", VA = "0x13E9E08", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD5C", Offset = "0x9FCD5C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x13E9E10", Offset = "0x13E9E10", VA = "0x13E9E10", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD6C", Offset = "0x9FCD6C")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool hasButtonSelectedComponents
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x13E9E1C", Offset = "0x13E9E1C", VA = "0x13E9E1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public bool isPrefab
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x13E9F10", Offset = "0x13E9F10", VA = "0x13E9F10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x13E9F34", Offset = "0x13E9F34", VA = "0x13E9F34")]
	public ES2AutoSaveVariableInfo GetCachedVariableInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x13EA044", Offset = "0x13EA044", VA = "0x13EA044")]
	public ES2AutoSaveVariableInfo CacheVariableInfo(ES2AutoSaveVariableInfo variable)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x13EA0B4", Offset = "0x13EA0B4", VA = "0x13EA0B4")]
	public void RemoveCachedVariableInfo(string id)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x13EA1DC", Offset = "0x13EA1DC", VA = "0x13EA1DC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x13EA6CC", Offset = "0x13EA6CC", VA = "0x13EA6CC")]
	public ES2AutoSaveComponentInfo GetComponentInfo(Component c)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x13EA7DC", Offset = "0x13EA7DC", VA = "0x13EA7DC")]
	public ES2AutoSaveComponentInfo GetComponentInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x13EA8CC", Offset = "0x13EA8CC", VA = "0x13EA8CC")]
	public ES2AutoSaveComponentInfo AddComponentInfo(ES2AutoSaveComponentInfo info)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x13EA93C", Offset = "0x13EA93C", VA = "0x13EA93C")]
	public static ES2AutoSave AddAutoSave(GameObject go, Color color, bool hide, bool generateID, string id)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x13EACE0", Offset = "0x13EACE0", VA = "0x13EACE0")]
	public static ES2AutoSave GetAutoSave(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x13EA500", Offset = "0x13EA500", VA = "0x13EA500")]
	public static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x13EAD38", Offset = "0x13EAD38", VA = "0x13EAD38")]
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
	[Address(RVA = "0x13EADF0", Offset = "0x13EADF0", VA = "0x13EADF0")]
	public ES2AutoSaveComponentInfo()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x13EAE74", Offset = "0x13EAE74", VA = "0x13EAE74")]
	public ES2AutoSaveComponentInfo(Component c, ES2AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x13EB028", Offset = "0x13EB028", VA = "0x13EB028")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC318", Offset = "0x9FC318")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC348", Offset = "0x9FC348")]
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
		[Address(RVA = "0x13EFC7C", Offset = "0x13EFC7C", VA = "0x13EFC7C", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x13EFC84", Offset = "0x13EFC84", VA = "0x13EFC84", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	[SerializeField]
	public bool selectionChanged
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x13EFC98", Offset = "0x13EFC98", VA = "0x13EFC98", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD7C", Offset = "0x9FCD7C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x13EFCA0", Offset = "0x13EFCA0", VA = "0x13EFCA0", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD8C", Offset = "0x9FCD8C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool buttonSelected
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x13EFCAC", Offset = "0x13EFCAC", VA = "0x13EFCAC", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x13EFCB4", Offset = "0x13EFCB4", VA = "0x13EFCB4", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x13EFCC8", Offset = "0x13EFCC8", VA = "0x13EFCC8", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD9C", Offset = "0x9FCD9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x13EFCD0", Offset = "0x13EFCD0", VA = "0x13EFCD0", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCDAC", Offset = "0x9FCDAC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public ES2AutoSave autoSave
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x13EFCDC", Offset = "0x13EFCDC", VA = "0x13EFCDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x13EAFF0", Offset = "0x13EAFF0", VA = "0x13EAFF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x13EFD7C", Offset = "0x13EFD7C", VA = "0x13EFD7C", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public Type type
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x13EAF5C", Offset = "0x13EAF5C", VA = "0x13EAF5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x13EAF1C", Offset = "0x13EAF1C", VA = "0x13EAF1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool HasButtonSelectedVariables
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x13EFD80", Offset = "0x13EFD80", VA = "0x13EFD80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x13EADF4", Offset = "0x13EADF4", VA = "0x13EADF4")]
	public ES2AutoSaveVariableInfo()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x13EABD8", Offset = "0x13EABD8", VA = "0x13EABD8")]
	public ES2AutoSaveVariableInfo(string name, Type type, bool isProperty, ES2AutoSave autoSave, ES2AutoSaveVariableInfo previous)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x13EFE84", Offset = "0x13EFE84", VA = "0x13EFE84")]
	public ES2AutoSaveVariableInfo GetVariableInfo(string name)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x13EFF64", Offset = "0x13EFF64", VA = "0x13EFF64")]
	public ES2AutoSaveVariableInfo AddVariableInfo(string name, Type type, bool isProperty, [Optional] ES2AutoSave autoSave, [Optional] ES2AutoSaveVariableInfo previous)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x13F0080", Offset = "0x13F0080", VA = "0x13F0080")]
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
	[Address(RVA = "0x13EB0B0", Offset = "0x13EB0B0", VA = "0x13EB0B0")]
	public ES2AutoSaveGlobalManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class ES2AutoSaveManager : MonoBehaviour
{
	[Token(Token = "0x2000150")]
	public enum LoadEvent
	{
		[Token(Token = "0x40003BC")]
		Start,
		[Token(Token = "0x40003BD")]
		OnApplicationUnPause,
		[Token(Token = "0x40003BE")]
		None
	}

	[Token(Token = "0x2000151")]
	public enum SaveEvent
	{
		[Token(Token = "0x40003C0")]
		OnApplicationQuit,
		[Token(Token = "0x40003C1")]
		OnApplicationPause,
		[Token(Token = "0x40003C2")]
		OnDisable,
		[Token(Token = "0x40003C3")]
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
		[Address(RVA = "0x13EA3E0", Offset = "0x13EA3E0", VA = "0x13EA3E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x13EB120", Offset = "0x13EB120", VA = "0x13EB120")]
	public void SetFilePath(string filePath)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x13EB128", Offset = "0x13EB128", VA = "0x13EB128")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x13EA638", Offset = "0x13EA638", VA = "0x13EA638")]
	public void AddAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x13EB260", Offset = "0x13EB260", VA = "0x13EB260")]
	public ES2AutoSave GetAutoSave(string id)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x13EB2E0", Offset = "0x13EB2E0", VA = "0x13EB2E0")]
	public void AddChildAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x13EB350", Offset = "0x13EB350", VA = "0x13EB350")]
	public void Save()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x13EB5C8", Offset = "0x13EB5C8", VA = "0x13EB5C8")]
	public void Load()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x13EB9BC", Offset = "0x13EB9BC", VA = "0x13EB9BC")]
	public void WriteAutoSaves(ES2Writer writer)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x13EBBD0", Offset = "0x13EBBD0", VA = "0x13EBBD0")]
	private void WriteAutoSaveRecursive(Transform transform, ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x13EC070", Offset = "0x13EC070", VA = "0x13EC070")]
	private void WriteAutoSave(ES2AutoSave autoSave, Transform transform, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x13ECA0C", Offset = "0x13ECA0C", VA = "0x13ECA0C")]
	private void WriteVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Writer writer, object obj)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x13EE0C0", Offset = "0x13EE0C0", VA = "0x13EE0C0")]
	public void ReadAutoSaves(ES2Reader reader)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x13EE0F4", Offset = "0x13EE0F4", VA = "0x13EE0F4")]
	private bool ReadAutoSave(ES2Reader reader, [Optional] ES2AutoSave autoSave)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x13EEAF0", Offset = "0x13EEAF0", VA = "0x13EEAF0")]
	private void ReadComponent(ES2AutoSave autoSave, ES2Reader reader)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x13EF04C", Offset = "0x13EF04C", VA = "0x13EF04C")]
	private void ReadVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Reader reader, object obj)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x13ECF30", Offset = "0x13ECF30", VA = "0x13ECF30")]
	protected void WriteAllComponents(ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x13EFAA4", Offset = "0x13EFAA4", VA = "0x13EFAA4")]
	public void Start()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x13EFAB4", Offset = "0x13EFAB4", VA = "0x13EFAB4")]
	public void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x13EFB0C", Offset = "0x13EFB0C", VA = "0x13EFB0C")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x13EFB1C", Offset = "0x13EFB1C", VA = "0x13EFB1C")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x13EFB30", Offset = "0x13EFB30", VA = "0x13EFB30")]
	public ES2AutoSaveManager()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6580", Offset = "0x9F6580")]
public static class ES2DirectoryUtility
{
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x13F1440", Offset = "0x13F1440", VA = "0x13F1440")]
	public static void Delete(string path, bool recursive)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x13F144C", Offset = "0x13F144C", VA = "0x13F144C")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x13F1454", Offset = "0x13F1454", VA = "0x13F1454")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x13F145C", Offset = "0x13F145C", VA = "0x13F145C")]
	public static void CreateDirectory(string path)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x13F1464", Offset = "0x13F1464", VA = "0x13F1464")]
	public static string[] GetDirectories(string path)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x13F146C", Offset = "0x13F146C", VA = "0x13F146C")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6594", Offset = "0x9F6594")]
public static class ES2Dispose
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x13F1474", Offset = "0x13F1474", VA = "0x13F1474")]
	public static void Dispose(BinaryReader reader)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x13F1490", Offset = "0x13F1490", VA = "0x13F1490")]
	public static void Dispose(BinaryWriter writer)
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F65A8", Offset = "0x9F65A8")]
public static class ES2FileUtility
{
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x13F15F8", Offset = "0x13F15F8", VA = "0x13F15F8")]
	public static void Delete(string path)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x13F15F0", Offset = "0x13F15F0", VA = "0x13F15F0")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x13F1D84", Offset = "0x13F1D84", VA = "0x13F1D84")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x13F2408", Offset = "0x13F2408", VA = "0x13F2408")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x13F2350", Offset = "0x13F2350", VA = "0x13F2350")]
	public static Stream CreateFileStream(string path, ES2Settings.ES2FileMode filemode, int bufferSize)
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F65BC", Offset = "0x9F65BC")]
public static class ES2TypeUtility
{
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x13F8F18", Offset = "0x13F8F18", VA = "0x13F8F18")]
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
	[Address(RVA = "0x13E4484", Offset = "0x13E4484", VA = "0x13E4484")]
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
	[Address(RVA = "0x13E4504", Offset = "0x13E4504", VA = "0x13E4504")]
	public static void SaveRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x13E46E4", Offset = "0x13E46E4", VA = "0x13E46E4")]
	public static void SaveRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x13E45A4", Offset = "0x13E45A4", VA = "0x13E45A4")]
	public static void SaveRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x13E478C", Offset = "0x13E478C", VA = "0x13E478C")]
	public static void SaveRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x13E4B94", Offset = "0x13E4B94", VA = "0x13E4B94")]
	public static void SaveRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x13E4CEC", Offset = "0x13E4CEC", VA = "0x13E4CEC")]
	public static void SaveRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x13E4E3C", Offset = "0x13E4E3C", VA = "0x13E4E3C")]
	public static void AppendRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x13E502C", Offset = "0x13E502C", VA = "0x13E502C")]
	public static void AppendRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x13E4EDC", Offset = "0x13E4EDC", VA = "0x13E4EDC")]
	public static void AppendRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x13E50D4", Offset = "0x13E50D4", VA = "0x13E50D4")]
	public static void AppendRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x13E5218", Offset = "0x13E5218", VA = "0x13E5218")]
	public static void AppendRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x13E5380", Offset = "0x13E5380", VA = "0x13E5380")]
	public static void AppendRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x13E54DC", Offset = "0x13E54DC", VA = "0x13E54DC")]
	public static void SaveImage(Texture2D tex, string identifier)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x13E568C", Offset = "0x13E568C", VA = "0x13E568C")]
	public static byte[] LoadRaw(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x13E5858", Offset = "0x13E5858", VA = "0x13E5858")]
	public static byte[] LoadRaw(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x13E597C", Offset = "0x13E597C", VA = "0x13E597C")]
	public static object LoadObject(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x13E5B10", Offset = "0x13E5B10", VA = "0x13E5B10")]
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
	[Address(RVA = "0x13E5C48", Offset = "0x13E5C48", VA = "0x13E5C48")]
	public static ES2Data LoadAll(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x13E5E48", Offset = "0x13E5E48", VA = "0x13E5E48")]
	public static ES2Data LoadAll(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x13E5F6C", Offset = "0x13E5F6C", VA = "0x13E5F6C")]
	public static Texture2D LoadImage(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x13E6220", Offset = "0x13E6220", VA = "0x13E6220")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x13E6298", Offset = "0x13E6298", VA = "0x13E6298")]
	public static AudioClip LoadAudio(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x13E668C", Offset = "0x13E668C", VA = "0x13E668C")]
	public static void CacheFile(string identifier)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x13E688C", Offset = "0x13E688C", VA = "0x13E688C")]
	public static bool Exists(string identifier)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x13E6D10", Offset = "0x13E6D10", VA = "0x13E6D10")]
	public static bool Exists(string identifier, ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x13E6D38", Offset = "0x13E6D38", VA = "0x13E6D38")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x13E6FA8", Offset = "0x13E6FA8", VA = "0x13E6FA8")]
	public static void Delete(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x13E6FD0", Offset = "0x13E6FD0", VA = "0x13E6FD0")]
	public static void DeleteDefaultFolder()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x13E730C", Offset = "0x13E730C", VA = "0x13E730C")]
	public static void Rename(string identifier, string newIdentifier)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x13E75D4", Offset = "0x13E75D4", VA = "0x13E75D4")]
	public static void Rename(string identifier, string newIdentifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x13E7628", Offset = "0x13E7628", VA = "0x13E7628")]
	public static string[] GetFiles(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x13E76D8", Offset = "0x13E76D8", VA = "0x13E76D8")]
	public static string[] GetFiles(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x13E7700", Offset = "0x13E7700", VA = "0x13E7700")]
	public static string[] GetFiles(string identifier, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x13E7954", Offset = "0x13E7954", VA = "0x13E7954")]
	public static string[] GetFolders(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x13E7B90", Offset = "0x13E7B90", VA = "0x13E7B90")]
	public static string[] GetFolders(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x13E7BB8", Offset = "0x13E7BB8", VA = "0x13E7BB8")]
	public static string[] GetTags(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x13E7D28", Offset = "0x13E7D28", VA = "0x13E7D28")]
	public static string[] GetTags(string identifier, ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
public class ES2Auto : MonoBehaviour
{
	[Token(Token = "0x2000152")]
	public enum SaveEvent
	{
		[Token(Token = "0x40003C5")]
		OnDisable,
		[Token(Token = "0x40003C6")]
		OnInterval
	}

	[Token(Token = "0x2000153")]
	public enum LoadEvent
	{
		[Token(Token = "0x40003C8")]
		OnAwake,
		[Token(Token = "0x40003C9")]
		OnStart,
		[Token(Token = "0x40003CA")]
		OnEnable
	}

	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBF48", Offset = "0x9FBF48")]
	private sealed class <SaveRoutine>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Auto <>4__this;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x13E9D48", Offset = "0x13E9D48", VA = "0x13E9D48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x13E9DB0", Offset = "0x13E9DB0", VA = "0x13E9DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x13E99D8", Offset = "0x13E99D8", VA = "0x13E99D8")]
		[DebuggerHidden]
		public <SaveRoutine>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x13E9C80", Offset = "0x13E9C80", VA = "0x13E9C80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x13E9C84", Offset = "0x13E9C84", VA = "0x13E9C84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x13E9D50", Offset = "0x13E9D50", VA = "0x13E9D50", Slot = "8")]
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
	[Address(RVA = "0x13E7D54", Offset = "0x13E7D54", VA = "0x13E7D54")]
	private void SavePosition()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x13E7ED8", Offset = "0x13E7ED8", VA = "0x13E7ED8")]
	private void LoadPosition()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x13E7FF4", Offset = "0x13E7FF4", VA = "0x13E7FF4")]
	private void SaveRotation()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x13E80D4", Offset = "0x13E80D4", VA = "0x13E80D4")]
	private void LoadRotation()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x13E81F0", Offset = "0x13E81F0", VA = "0x13E81F0")]
	private void SaveScale()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x13E82C8", Offset = "0x13E82C8", VA = "0x13E82C8")]
	private void LoadScale()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x13E83E4", Offset = "0x13E83E4", VA = "0x13E83E4")]
	private void SaveMesh()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x13E85A4", Offset = "0x13E85A4", VA = "0x13E85A4")]
	private void LoadMesh()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x13E8860", Offset = "0x13E8860", VA = "0x13E8860")]
	private void SaveSphereCollider()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x13E89E8", Offset = "0x13E89E8", VA = "0x13E89E8")]
	private void LoadSphereCollider()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x13E8C50", Offset = "0x13E8C50", VA = "0x13E8C50")]
	private void SaveCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x13E8DD8", Offset = "0x13E8DD8", VA = "0x13E8DD8")]
	private void LoadCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x13E9040", Offset = "0x13E9040", VA = "0x13E9040")]
	private void SaveBoxCollider()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x13E91C8", Offset = "0x13E91C8", VA = "0x13E91C8")]
	private void LoadBoxCollider()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x13E9430", Offset = "0x13E9430", VA = "0x13E9430")]
	private void SaveMeshCollider()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x13E95B8", Offset = "0x13E95B8", VA = "0x13E95B8")]
	private void LoadMeshCollider()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x13E9820", Offset = "0x13E9820", VA = "0x13E9820")]
	public void Save()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x13E98C4", Offset = "0x13E98C4", VA = "0x13E98C4")]
	public void Load()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x13E9968", Offset = "0x13E9968", VA = "0x13E9968")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCDBC", Offset = "0x9FCDBC")]
	private IEnumerator SaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x13E9A04", Offset = "0x13E9A04", VA = "0x13E9A04")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x13E9A1C", Offset = "0x13E9A1C", VA = "0x13E9A1C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x13E9A3C", Offset = "0x13E9A3C", VA = "0x13E9A3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x13E9B84", Offset = "0x13E9B84", VA = "0x13E9B84")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x13E9B9C", Offset = "0x13E9B9C", VA = "0x13E9B9C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x13E7E2C", Offset = "0x13E7E2C", VA = "0x13E7E2C")]
	private string GetFullFilename(string tagExtension)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x13E9A9C", Offset = "0x13E9A9C", VA = "0x13E9A9C")]
	private void InitializeSettings()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x13E9BB4", Offset = "0x13E9BB4", VA = "0x13E9BB4")]
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
	[Address(RVA = "0x13F00FC", Offset = "0x13F00FC", VA = "0x13F00FC")]
	public static ES2CachedFile AddNewCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x13F0220", Offset = "0x13F0220", VA = "0x13F0220")]
	public static bool DeleteCachedFile(string absolutePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x13F02A4", Offset = "0x13F02A4", VA = "0x13F02A4")]
	public static ES2CachedFile GetOrCreateCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x13F0368", Offset = "0x13F0368", VA = "0x13F0368")]
	public static ES2CachedFile GetCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x13F040C", Offset = "0x13F040C", VA = "0x13F040C")]
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
	[Address(RVA = "0x13F07F8", Offset = "0x13F07F8", VA = "0x13F07F8")]
	public void AddTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x13F0840", Offset = "0x13F0840", VA = "0x13F0840")]
	public void AddTag(ES2Tag tag)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x13F08D8", Offset = "0x13F08D8", VA = "0x13F08D8")]
	public ES2Tag AddOrUpdateTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x13F0A28", Offset = "0x13F0A28", VA = "0x13F0A28")]
	public ES2Tag GetTag(string tag)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x13F0B84", Offset = "0x13F0B84", VA = "0x13F0B84")]
	public bool RemoveTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x13F0BEC", Offset = "0x13F0BEC", VA = "0x13F0BEC")]
	public void RenameTag(string oldTag, string newTag)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x13F0CA8", Offset = "0x13F0CA8", VA = "0x13F0CA8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x13F01B0", Offset = "0x13F01B0", VA = "0x13F01B0")]
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
	[Address(RVA = "0xAEE434", Offset = "0xAEE434", VA = "0xAEE434")]
	public ES2Tag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xAEE444", Offset = "0xAEE444", VA = "0xAEE444")]
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
	[Address(RVA = "0x13F1170", Offset = "0x13F1170", VA = "0x13F1170")]
	public void Add(string tag, object value)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x13F11E0", Offset = "0x13F11E0", VA = "0x13F11E0")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x13F1248", Offset = "0x13F1248", VA = "0x13F1248")]
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
	[Address(RVA = "0x13F13D0", Offset = "0x13F13D0", VA = "0x13F13D0")]
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
	[Address(RVA = "0x13F14AC", Offset = "0x13F14AC", VA = "0x13F14AC")]
	public ES2EditorWindowStyle()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F65D0", Offset = "0x9F65D0")]
public static class ES2File
{
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x13E6D98", Offset = "0x13E6D98", VA = "0x13E6D98")]
	public static void Delete(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x13F14F8", Offset = "0x13F14F8", VA = "0x13F14F8")]
	public static void DeleteFile(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x13F1600", Offset = "0x13F1600", VA = "0x13F1600")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x13E68EC", Offset = "0x13E68EC", VA = "0x13E68EC")]
	public static bool Exists(ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x13F1734", Offset = "0x13F1734", VA = "0x13F1734")]
	private static bool CheckForTagInBytes(string tag, byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x13F1B6C", Offset = "0x13F1B6C", VA = "0x13F1B6C")]
	public static void CreateFolder(string identifier)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x13E7390", Offset = "0x13E7390", VA = "0x13E7390")]
	public static void Rename(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x13F1B74", Offset = "0x13F1B74", VA = "0x13F1B74")]
	public static void MoveFile(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x13E79B4", Offset = "0x13E79B4", VA = "0x13E79B4")]
	public static string[] GetFolders(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x13E7688", Offset = "0x13E7688", VA = "0x13E7688")]
	public static string[] GetFiles(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x13E7770", Offset = "0x13E7770", VA = "0x13E7770")]
	public static string[] GetFiles(ES2Settings settings, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x13E7C18", Offset = "0x13E7C18", VA = "0x13E7C18")]
	public static string[] GetTags(ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x2000015")]
public static class ES2Reflection
{
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x13EF490", Offset = "0x13EF490", VA = "0x13EF490")]
	public static bool SetValue(object obj, string name, object value, bool isProperty = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x13ED5F0", Offset = "0x13ED5F0", VA = "0x13ED5F0")]
	public static object GetValue(object obj, string name, bool isProperty = false)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x13F40EC", Offset = "0x13F40EC", VA = "0x13F40EC")]
	public static bool IsAssignableFrom(Type a, Type b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x13F410C", Offset = "0x13F410C", VA = "0x13F410C")]
	public static bool IsGenericType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x13ED5D0", Offset = "0x13ED5D0", VA = "0x13ED5D0")]
	public static Type[] GetGenericArguments(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x13F4EDC", Offset = "0x13F4EDC", VA = "0x13F4EDC")]
	public static object CreateGenericInstance(Type type, Type genericType)
	{
		return null;
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x13F50D4", Offset = "0x13F50D4", VA = "0x13F50D4")]
	public static object CreateGenericInstance(Type type, Type genericType, Type genericType2)
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x13F7628", Offset = "0x13F7628", VA = "0x13F7628")]
	public static bool IsCollectionType(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9F65E4", Offset = "0x9F65E4")]
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
		[Address(RVA = "0x13F86C4", Offset = "0x13F86C4", VA = "0x13F86C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x13F86C8", Offset = "0x13F86C8", VA = "0x13F86C8")]
		set
		{
		}
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x13F7E6C", Offset = "0x13F7E6C", VA = "0x13F7E6C")]
	public ES2Spreadsheet()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x13F7FF8", Offset = "0x13F7FF8", VA = "0x13F7FF8")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x13F82A8", Offset = "0x13F82A8", VA = "0x13F82A8")]
	public string GetCell(int col, int row)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x13F811C", Offset = "0x13F811C", VA = "0x13F811C")]
	private void SizeSpreadsheetToFitRow(int row)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x13F8380", Offset = "0x13F8380", VA = "0x13F8380")]
	public void Save(string path)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x13F83F0", Offset = "0x13F83F0", VA = "0x13F83F0")]
	public void Save(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x13F7F00", Offset = "0x13F7F00", VA = "0x13F7F00")]
	private static void GetCharacterConstants()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x13F86CC", Offset = "0x13F86CC", VA = "0x13F86CC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9F661C", Offset = "0x9F661C")]
public class ES2SpreadsheetRow
{
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<string> cells;

	[Token(Token = "0x17000019")]
	public int cellCount
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x13F8674", Offset = "0x13F8674", VA = "0x13F8674")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001A")]
	public string Item
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x13F837C", Offset = "0x13F837C", VA = "0x13F837C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x13F8A9C", Offset = "0x13F8A9C", VA = "0x13F8A9C")]
		set
		{
		}
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x13F822C", Offset = "0x13F822C", VA = "0x13F822C")]
	public void SetCell(int col, string value)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x13F8884", Offset = "0x13F8884", VA = "0x13F8884")]
	public string GetCell(int col)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x13F865C", Offset = "0x13F865C", VA = "0x13F865C")]
	public byte[] GetCellBytes(int col)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x13F87E4", Offset = "0x13F87E4", VA = "0x13F87E4")]
	private void SizeRowToFitColumn(int col)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x13F8940", Offset = "0x13F8940", VA = "0x13F8940")]
	private byte[] GetBytes(string data)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x13F8AA0", Offset = "0x13F8AA0", VA = "0x13F8AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x13F81BC", Offset = "0x13F81BC", VA = "0x13F81BC")]
	public ES2SpreadsheetRow()
	{
	}
}
[Token(Token = "0x2000018")]
public class ES2Web
{
	[Token(Token = "0x2000155")]
	public enum HashType
	{
		[Token(Token = "0x40003CF")]
		MD5,
		[Token(Token = "0x40003D0")]
		None
	}

	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBF58", Offset = "0x9FBF58")]
	private sealed class <Upload>d__18<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T param;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008FC")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
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
		public <Upload>d__18(int <>1__state)
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBF68", Offset = "0x9FBF68")]
	private sealed class <Upload>d__19<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] param;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000903")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
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
		public <Upload>d__19(int <>1__state)
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBF78", Offset = "0x9FBF78")]
	private sealed class <Upload>d__20<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[,] param;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600090A")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
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
		public <Upload>d__20(int <>1__state)
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBF88", Offset = "0x9FBF88")]
	private sealed class <Upload>d__21<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[,,] param;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000911")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
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
		public <Upload>d__21(int <>1__state)
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBF98", Offset = "0x9FBF98")]
	private sealed class <Upload>d__22<TKey, TValue> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<TKey, TValue> param;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000918")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
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
		public <Upload>d__22(int <>1__state)
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBFA8", Offset = "0x9FBFA8")]
	private sealed class <Upload>d__23<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> param;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600091F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
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
		public <Upload>d__23(int <>1__state)
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBFB8", Offset = "0x9FBFB8")]
	private sealed class <Upload>d__24<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HashSet<T> param;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000926")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
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
		public <Upload>d__24(int <>1__state)
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBFC8", Offset = "0x9FBFC8")]
	private sealed class <Upload>d__25<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Queue<T> param;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600092D")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
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
		public <Upload>d__25(int <>1__state)
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBFD8", Offset = "0x9FBFD8")]
	private sealed class <Upload>d__26<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Stack<T> param;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000934")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000936")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000930")]
		[DebuggerHidden]
		public <Upload>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000931")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000932")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000933")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000935")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBFE8", Offset = "0x9FBFE8")]
	private sealed class <UploadRaw>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] data;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x13FA894", Offset = "0x13FA894", VA = "0x13FA894", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x13FA8FC", Offset = "0x13FA8FC", VA = "0x13FA8FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x13F91E4", Offset = "0x13F91E4", VA = "0x13F91E4")]
		[DebuggerHidden]
		public <UploadRaw>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x13FA794", Offset = "0x13FA794", VA = "0x13FA794", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x13FA798", Offset = "0x13FA798", VA = "0x13FA798", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x13FA89C", Offset = "0x13FA89C", VA = "0x13FA89C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FBFF8", Offset = "0x9FBFF8")]
	private sealed class <UploadImage>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D tex;

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x13FA724", Offset = "0x13FA724", VA = "0x13FA724", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x13FA78C", Offset = "0x13FA78C", VA = "0x13FA78C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x13F928C", Offset = "0x13F928C", VA = "0x13F928C")]
		[DebuggerHidden]
		public <UploadImage>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x13FA618", Offset = "0x13FA618", VA = "0x13FA618", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x13FA61C", Offset = "0x13FA61C", VA = "0x13FA61C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x13FA72C", Offset = "0x13FA72C", VA = "0x13FA72C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC008", Offset = "0x9FC008")]
	private sealed class <UploadFile>d__30 : IEnumerator<object>, IEnumerator, IDisposable
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

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string file;

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x13FA5A8", Offset = "0x13FA5A8", VA = "0x13FA5A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x13FA610", Offset = "0x13FA610", VA = "0x13FA610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x13F9334", Offset = "0x13F9334", VA = "0x13F9334")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x13FA47C", Offset = "0x13FA47C", VA = "0x13FA47C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x13FA480", Offset = "0x13FA480", VA = "0x13FA480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x13FA5B0", Offset = "0x13FA5B0", VA = "0x13FA5B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC018", Offset = "0x9FC018")]
	private sealed class <DownloadFilenames>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x13FA40C", Offset = "0x13FA40C", VA = "0x13FA40C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x13FA474", Offset = "0x13FA474", VA = "0x13FA474", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x13F9838", Offset = "0x13F9838", VA = "0x13F9838")]
		[DebuggerHidden]
		public <DownloadFilenames>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x13FA310", Offset = "0x13FA310", VA = "0x13FA310", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x13FA314", Offset = "0x13FA314", VA = "0x13FA314", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x13FA414", Offset = "0x13FA414", VA = "0x13FA414", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC028", Offset = "0x9FC028")]
	private sealed class <Download>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x13FA2A0", Offset = "0x13FA2A0", VA = "0x13FA2A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x13FA308", Offset = "0x13FA308", VA = "0x13FA308", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x13F9978", Offset = "0x13F9978", VA = "0x13F9978")]
		[DebuggerHidden]
		public <Download>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x13FA1A4", Offset = "0x13FA1A4", VA = "0x13FA1A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x13FA1A8", Offset = "0x13FA1A8", VA = "0x13FA1A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x13FA2A8", Offset = "0x13FA2A8", VA = "0x13FA2A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC038", Offset = "0x9FC038")]
	private sealed class <Delete>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x13FA134", Offset = "0x13FA134", VA = "0x13FA134", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x13FA19C", Offset = "0x13FA19C", VA = "0x13FA19C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x13F9A14", Offset = "0x13F9A14", VA = "0x13F9A14")]
		[DebuggerHidden]
		public <Delete>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x13F9FD0", Offset = "0x13F9FD0", VA = "0x13F9FD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x13F9FD4", Offset = "0x13F9FD4", VA = "0x13F9FD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x13FA13C", Offset = "0x13FA13C", VA = "0x13FA13C", Slot = "8")]
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
		[Address(RVA = "0x13F8FA0", Offset = "0x13F8FA0", VA = "0x13F8FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public string text
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x13F8FBC", Offset = "0x13F8FBC", VA = "0x13F8FBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001D")]
	public float progress
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x13F8FD8", Offset = "0x13F8FD8", VA = "0x13F8FD8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700001E")]
	public float uploadProgress
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x13F8FF4", Offset = "0x13F8FF4", VA = "0x13F8FF4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x13F9010", Offset = "0x13F9010", VA = "0x13F9010")]
	public ES2Web(string identifier)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x13F9098", Offset = "0x13F9098", VA = "0x13F9098")]
	public ES2Web(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600011F")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCE20", Offset = "0x9FCE20")]
	public IEnumerator Upload<T>(T param)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCE84", Offset = "0x9FCE84")]
	public IEnumerator Upload<T>(T[] param)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCEE8", Offset = "0x9FCEE8")]
	public IEnumerator Upload<T>(T[,] param)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCF4C", Offset = "0x9FCF4C")]
	public IEnumerator Upload<T>(T[,,] param)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCFB0", Offset = "0x9FCFB0")]
	public IEnumerator Upload<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD014", Offset = "0x9FD014")]
	public IEnumerator Upload<T>(List<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD078", Offset = "0x9FD078")]
	public IEnumerator Upload<T>(HashSet<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD0DC", Offset = "0x9FD0DC")]
	public IEnumerator Upload<T>(Queue<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD140", Offset = "0x9FD140")]
	public IEnumerator Upload<T>(Stack<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x13F911C", Offset = "0x13F911C", VA = "0x13F911C")]
	public IEnumerator UploadRaw(string data)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x13F9168", Offset = "0x13F9168", VA = "0x13F9168")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD1A4", Offset = "0x9FD1A4")]
	public IEnumerator UploadRaw(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x13F9210", Offset = "0x13F9210", VA = "0x13F9210")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD208", Offset = "0x9FD208")]
	public IEnumerator UploadImage(Texture2D tex)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x13F92B8", Offset = "0x13F92B8", VA = "0x13F92B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD26C", Offset = "0x9FD26C")]
	public IEnumerator UploadFile(string file)
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x13F9360", Offset = "0x13F9360", VA = "0x13F9360")]
	public Texture2D LoadImage()
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x13F951C", Offset = "0x13F951C", VA = "0x13F951C")]
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
	[Address(RVA = "0x13F9554", Offset = "0x13F9554", VA = "0x13F9554")]
	public void SaveToFile(string identifier)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x13F95E0", Offset = "0x13F95E0", VA = "0x13F95E0")]
	public void SaveToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x13F968C", Offset = "0x13F968C", VA = "0x13F968C")]
	public void AppendToFile(string identifier)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x13F971C", Offset = "0x13F971C", VA = "0x13F971C")]
	public void AppendToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x13F97C8", Offset = "0x13F97C8", VA = "0x13F97C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD2D0", Offset = "0x9FD2D0")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x13F9864", Offset = "0x13F9864", VA = "0x13F9864")]
	public string[] GetFilenames()
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x13F9908", Offset = "0x13F9908", VA = "0x13F9908")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD334", Offset = "0x9FD334")]
	public IEnumerator Download()
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x13F99A4", Offset = "0x13F99A4", VA = "0x13F99A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD398", Offset = "0x9FD398")]
	public IEnumerator Delete()
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x13F9A40", Offset = "0x13F9A40", VA = "0x13F9A40")]
	private WWWForm CreateUploadForm(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x13F9BF8", Offset = "0x13F9BF8", VA = "0x13F9BF8")]
	private WWWForm CreateDownloadForm()
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x13F9CB8", Offset = "0x13F9CB8", VA = "0x13F9CB8")]
	private WWWForm CreateGetFilesForm()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x13F93F0", Offset = "0x13F93F0", VA = "0x13F93F0")]
	private void CheckWWWUsage()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x13F9480", Offset = "0x13F9480", VA = "0x13F9480")]
	private void CheckDownloadUsage()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x13F9D30", Offset = "0x13F9D30", VA = "0x13F9D30")]
	private bool getError()
	{
		return default(bool);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x13F9AE0", Offset = "0x13F9AE0", VA = "0x13F9AE0")]
	private WWWForm CreateForm()
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x13F9F30", Offset = "0x13F9F30", VA = "0x13F9F30")]
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
	[Address(RVA = "0xAEE35C", Offset = "0xAEE35C", VA = "0xAEE35C")]
	public ES2Header(ES2Keys.Key collectionType, int keyType, int valueType, ES2Settings settings)
	{
	}
}
[Token(Token = "0x200001A")]
public class ES2Reader : IDisposable
{
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC4C8", Offset = "0x9FC4C8")]
	public ES2Stream stream;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings settings;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC4DC", Offset = "0x9FC4DC")]
	private ES2CachedFile cachedFile;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC4F0", Offset = "0x9FC4F0")]
	public ES2Tag currentTag;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BinaryReader reader;

	[Token(Token = "0x1700001F")]
	public int Length
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x13F6528", Offset = "0x13F6528", VA = "0x13F6528")]
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
	[Address(RVA = "0x13EF55C", Offset = "0x13EF55C", VA = "0x13EF55C")]
	public Array ReadSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x13EF6FC", Offset = "0x13EF6FC", VA = "0x13EF6FC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD3FC", Offset = "0x9FD3FC")]
	public ICollection ReadICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x13EF8AC", Offset = "0x13EF8AC", VA = "0x13EF8AC")]
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
	[Address(RVA = "0x13F4B40", Offset = "0x13F4B40", VA = "0x13F4B40")]
	private Array ReadEncryptedSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x13F4DBC", Offset = "0x13F4DBC", VA = "0x13F4DBC")]
	private ICollection ReadEncryptedICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x13F4FA4", Offset = "0x13F4FA4", VA = "0x13F4FA4")]
	private IDictionary ReadEncryptedIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x13F5240", Offset = "0x13F5240", VA = "0x13F5240")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey, string tag)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x13F57D4", Offset = "0x13F57D4", VA = "0x13F57D4")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x13F555C", Offset = "0x13F555C", VA = "0x13F555C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD410", Offset = "0x9FD410")]
	public ES2Header ReadHeader()
	{
		return default(ES2Header);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x13F5A1C", Offset = "0x13F5A1C", VA = "0x13F5A1C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD424", Offset = "0x9FD424")]
	public bool Next()
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x13F5BD8", Offset = "0x13F5BD8", VA = "0x13F5BD8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD438", Offset = "0x9FD438")]
	public void Skip()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x13F5C10", Offset = "0x13F5C10", VA = "0x13F5C10")]
	protected bool WriteBytesBeforeTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x13F5CE8", Offset = "0x13F5CE8", VA = "0x13F5CE8")]
	protected bool WriteRemainingBytes(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x13F5E1C", Offset = "0x13F5E1C", VA = "0x13F5E1C")]
	protected bool WriteBytesBeforeTagLowMemory(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x13F5FF8", Offset = "0x13F5FF8", VA = "0x13F5FF8")]
	protected bool WriteRemainingBytesLowMemory(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x13F61DC", Offset = "0x13F61DC", VA = "0x13F61DC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD44C", Offset = "0x9FD44C")]
	public bool RenameTag(string oldTag, string newTag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x13F6448", Offset = "0x13F6448", VA = "0x13F6448")]
	protected bool DeleteTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x13F6608", Offset = "0x13F6608", VA = "0x13F6608")]
	protected void WriteCurrentTag(ES2Writer writer)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x13F6688", Offset = "0x13F6688", VA = "0x13F6688")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD460", Offset = "0x9FD460")]
	public bool DeleteTags(ICollection<string> tags, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x13F1D8C", Offset = "0x13F1D8C", VA = "0x13F1D8C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD474", Offset = "0x9FD474")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x13F6A20", Offset = "0x13F6A20", VA = "0x13F6A20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD488", Offset = "0x9FD488")]
	public byte[] ReadMeshSettings()
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x13F6A68", Offset = "0x13F6A68", VA = "0x13F6A68")]
	private byte[] GetDecryptedBytes()
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x13F51C8", Offset = "0x13F51C8", VA = "0x13F51C8")]
	private ES2Reader GetEncryptedReader()
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x13F6558", Offset = "0x13F6558", VA = "0x13F6558")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD49C", Offset = "0x9FD49C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x13F6BF4", Offset = "0x13F6BF4", VA = "0x13F6BF4", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x13E67A0", Offset = "0x13E67A0", VA = "0x13E67A0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD4B0", Offset = "0x9FD4B0")]
	public void CacheFile()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x13F5454", Offset = "0x13F5454", VA = "0x13F5454")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD4C4", Offset = "0x9FD4C4")]
	public bool ScanToTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x13F6C14", Offset = "0x13F6C14", VA = "0x13F6C14")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD4D8", Offset = "0x9FD4D8")]
	public bool ScanToTag()
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x13F1B3C", Offset = "0x13F1B3C", VA = "0x13F1B3C")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x13F1884", Offset = "0x13F1884", VA = "0x13F1884")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD4EC", Offset = "0x9FD4EC")]
	public bool TagExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x13E5818", Offset = "0x13E5818", VA = "0x13E5818")]
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
	[Address(RVA = "0x13E5D74", Offset = "0x13E5D74", VA = "0x13E5D74")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD500", Offset = "0x9FD500")]
	public ES2Data ReadAll()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x13F6C30", Offset = "0x13F6C30", VA = "0x13F6C30")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD514", Offset = "0x9FD514")]
	public object ReadObject()
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x13F6F28", Offset = "0x13F6F28", VA = "0x13F6F28")]
	public void ReadObject(object obj)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x13E5AB8", Offset = "0x13E5AB8", VA = "0x13E5AB8")]
	public object ReadObject(string tag)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x13F7008", Offset = "0x13F7008", VA = "0x13F7008")]
	public void ReadObject(string tag, object obj)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x13F7070", Offset = "0x13F7070", VA = "0x13F7070")]
	public void ReadComponent(GameObject go)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x13F71CC", Offset = "0x13F71CC", VA = "0x13F71CC")]
	public void ReadComponent(string tag, GameObject go)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x13F7234", Offset = "0x13F7234", VA = "0x13F7234")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD528", Offset = "0x9FD528")]
	public Dictionary<string, ES2Header> ReadAllHeaders()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD53C", Offset = "0x9FD53C")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x60001A3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD550", Offset = "0x9FD550")]
	public T ReadProperty<T>(T obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD564", Offset = "0x9FD564")]
	public T[] ReadPropertyArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD578", Offset = "0x9FD578")]
	public T[] ReadPropertyArray<T>(T[] obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD58C", Offset = "0x9FD58C")]
	public T[,] ReadProperty2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD5A0", Offset = "0x9FD5A0")]
	public T[,,] ReadProperty3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD5B4", Offset = "0x9FD5B4")]
	public List<T> ReadPropertyList<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD5C8", Offset = "0x9FD5C8")]
	public Queue<T> ReadPropertyQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD5DC", Offset = "0x9FD5DC")]
	public Stack<T> ReadPropertyStack<T>()
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD5F0", Offset = "0x9FD5F0")]
	public Dictionary<TKey, TValue> ReadPropertyDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x13F4C58", Offset = "0x13F4C58", VA = "0x13F4C58")]
	private static int[] GetMultidimensionalIndices(Array a, int idx)
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x13F7320", Offset = "0x13F7320", VA = "0x13F7320")]
	public static ES2Reader Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x13EB994", Offset = "0x13EB994", VA = "0x13EB994")]
	public static ES2Reader Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x13E57B8", Offset = "0x13E57B8", VA = "0x13E57B8")]
	public static ES2Reader Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x13F6B84", Offset = "0x13F6B84", VA = "0x13F6B84")]
	public static ES2Reader Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x13F7380", Offset = "0x13F7380", VA = "0x13F7380")]
	public ES2Reader(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x13F1A7C", Offset = "0x13F1A7C", VA = "0x13F1A7C")]
	public ES2Reader(byte[] bytes, ES2Settings settings)
	{
	}
}
[Token(Token = "0x200001B")]
public class ES2InvalidDataException : Exception
{
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x13F3B10", Offset = "0x13F3B10", VA = "0x13F3B10")]
	public ES2InvalidDataException()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6654", Offset = "0x9F6654")]
public struct ES2FilenameData
{
	[Token(Token = "0x2000165")]
	public enum PathType
	{
		[Token(Token = "0x4000414")]
		File,
		[Token(Token = "0x4000415")]
		Folder,
		[Token(Token = "0x4000416")]
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
		[Address(RVA = "0xAEE310", Offset = "0xAEE310", VA = "0xAEE310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	public string resourcesPath
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xAEE318", Offset = "0xAEE318", VA = "0xAEE318")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xAEE284", Offset = "0xAEE284", VA = "0xAEE284")]
	public ES2FilenameData(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xAEE290", Offset = "0xAEE290", VA = "0xAEE290")]
	public ES2FilenameData(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xAEE298", Offset = "0xAEE298", VA = "0xAEE298")]
	public void Init(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xAEE2A4", Offset = "0xAEE2A4", VA = "0xAEE2A4")]
	private void ProcessParameter(string name, string value, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x13F2BE8", Offset = "0x13F2BE8", VA = "0x13F2BE8")]
	private static PathType GetPathType(string path)
	{
		return default(PathType);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x13F3508", Offset = "0x13F3508", VA = "0x13F3508")]
	private static bool PathIsURL(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x13F2B24", Offset = "0x13F2B24", VA = "0x13F2B24")]
	private static bool PathIsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x13F36A0", Offset = "0x13F36A0", VA = "0x13F36A0")]
	private static bool PathIsFolder(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xAEE2AC", Offset = "0xAEE2AC", VA = "0xAEE2AC")]
	public bool HasTag()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x13E7128", Offset = "0x13E7128", VA = "0x13E7128")]
	public static string GetPersistentPath()
	{
		return null;
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xAEE2D0", Offset = "0xAEE2D0", VA = "0xAEE2D0")]
	public bool IsURL()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xAEE2E0", Offset = "0xAEE2E0", VA = "0xAEE2E0")]
	public bool IsFolder()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xAEE2F0", Offset = "0xAEE2F0", VA = "0xAEE2F0")]
	public bool IsFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xAEE300", Offset = "0xAEE300", VA = "0xAEE300")]
	public bool IsAbsolute()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xAEE308", Offset = "0xAEE308", VA = "0xAEE308")]
	public string GetSavePath(ES2Settings.SaveLocation saveLocation)
	{
		return null;
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6668", Offset = "0x9F6668")]
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
		[Address(RVA = "0x13E70A8", Offset = "0x13E70A8", VA = "0x13E70A8")]
		get
		{
			return default(ES2Settings.SaveLocation);
		}
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x13F37CC", Offset = "0x13F37CC", VA = "0x13F37CC")]
		set
		{
		}
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x13F3838", Offset = "0x13F3838", VA = "0x13F3838")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x13F39F4", Offset = "0x13F39F4", VA = "0x13F39F4")]
	public ES2GlobalSettings()
	{
	}
}
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F667C", Offset = "0x9F667C")]
public static class ES2Keys
{
	[Token(Token = "0x2000166")]
	public enum Key : byte
	{
		[Token(Token = "0x4000418")]
		_NativeArray = 81,
		[Token(Token = "0x4000419")]
		_Dictionary = 82,
		[Token(Token = "0x400041A")]
		_List = 83,
		[Token(Token = "0x400041B")]
		_HashSet = 84,
		[Token(Token = "0x400041C")]
		_Queue = 85,
		[Token(Token = "0x400041D")]
		_Stack = 86,
		[Token(Token = "0x400041E")]
		_Obfuscate = 121,
		[Token(Token = "0x400041F")]
		_Size = 122,
		[Token(Token = "0x4000420")]
		_Terminator = 123,
		[Token(Token = "0x4000421")]
		_Null = 124,
		[Token(Token = "0x4000422")]
		_Settings = 125,
		[Token(Token = "0x4000423")]
		_Tag = 126,
		[Token(Token = "0x4000424")]
		_Encrypt = 127
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x13F3B84", Offset = "0x13F3B84", VA = "0x13F3B84")]
	public static string TypeFromKeys(Key collection, Key value, Key key)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x13F3FD4", Offset = "0x13F3FD4", VA = "0x13F3FD4")]
	public static Key[] KeysFromType(Key collectionType, Key valueType, Key keyType)
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x13F4070", Offset = "0x13F4070", VA = "0x13F4070")]
	public static Key KeyFromES2Type(ES2Type type)
	{
		return default(Key);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x13F4084", Offset = "0x13F4084", VA = "0x13F4084")]
	public static Key[] KeysFromES2Type(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x13F40A0", Offset = "0x13F40A0", VA = "0x13F40A0")]
	public static Key[] KeysFromES2Type(ES2Type type, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x13F40C0", Offset = "0x13F40C0", VA = "0x13F40C0")]
	public static Key[] KeysFromES2Type(ES2Type keyType, ES2Type valueType, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x13ED170", Offset = "0x13ED170", VA = "0x13ED170")]
	public static Key GetCollectionType(Type type)
	{
		return default(Key);
	}
}
[Token(Token = "0x200001F")]
public sealed class ES2Settings
{
	[Token(Token = "0x2000167")]
	public enum OptimizeMode
	{
		[Token(Token = "0x4000426")]
		Fast,
		[Token(Token = "0x4000427")]
		LowMemory
	}

	[Token(Token = "0x2000168")]
	public enum SaveLocation
	{
		[Token(Token = "0x4000429")]
		PlayerPrefs,
		[Token(Token = "0x400042A")]
		File,
		[Token(Token = "0x400042B")]
		Resources,
		[Token(Token = "0x400042C")]
		Memory
	}

	[Token(Token = "0x2000169")]
	public enum Format
	{
		[Token(Token = "0x400042E")]
		Binary
	}

	[Token(Token = "0x200016A")]
	public enum EncryptionType
	{
		[Token(Token = "0x4000430")]
		AES128,
		[Token(Token = "0x4000431")]
		Obfuscate
	}

	[Token(Token = "0x200016B")]
	public enum ES2FileMode
	{
		[Token(Token = "0x4000433")]
		Create,
		[Token(Token = "0x4000434")]
		Append,
		[Token(Token = "0x4000435")]
		Open
	}

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC504", Offset = "0x9FC504")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC518", Offset = "0x9FC518")]
	public byte meshSettingsCount;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string name;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC52C", Offset = "0x9FC52C")]
	public ES2FileMode fileMode;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int bufferSize;

	[Token(Token = "0x17000023")]
	public string tag
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x13F1578", Offset = "0x13F1578", VA = "0x13F1578")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x13F7E64", Offset = "0x13F7E64", VA = "0x13F7E64")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FE8A0", Offset = "0x9FE8A0")]
	public bool IsImageFile
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x13E6154", Offset = "0x13E6154", VA = "0x13E6154")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x13F7994", Offset = "0x13F7994", VA = "0x13F7994")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD604", Offset = "0x9FD604")]
	public void Init()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x13F7AA8", Offset = "0x13F7AA8", VA = "0x13F7AA8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD618", Offset = "0x9FD618")]
	public ES2Settings Clone()
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x13E4B28", Offset = "0x13E4B28", VA = "0x13E4B28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD62C", Offset = "0x9FD62C")]
	public ES2Settings Clone(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x13F7BC4", Offset = "0x13F7BC4", VA = "0x13F7BC4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD640", Offset = "0x9FD640")]
	public byte[] MeshSettingsToByteArray()
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x13F7CB8", Offset = "0x13F7CB8", VA = "0x13F7CB8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD654", Offset = "0x9FD654")]
	public void MeshSettingsFromByteArray(byte[] bytes)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x13E48C4", Offset = "0x13E48C4", VA = "0x13E48C4")]
	public ES2Settings(string identifier)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x13F1968", Offset = "0x13F1968", VA = "0x13F1968")]
	public ES2Settings(SaveLocation saveLocation)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x13EB4A0", Offset = "0x13EB4A0", VA = "0x13EB4A0")]
	public ES2Settings()
	{
	}
}
[Token(Token = "0x2000020")]
internal sealed class ES2FileStream : ES2Stream
{
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x13F1E54", Offset = "0x13F1E54", VA = "0x13F1E54")]
	public ES2FileStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x13F2028", Offset = "0x13F2028", VA = "0x13F2028", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x13F2194", Offset = "0x13F2194", VA = "0x13F2194")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x13F1F4C", Offset = "0x13F1F4C", VA = "0x13F1F4C")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x13F1EAC", Offset = "0x13F1EAC", VA = "0x13F1EAC")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x13F2410", Offset = "0x13F2410", VA = "0x13F2410", Slot = "5")]
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
	[Address(RVA = "0x13F412C", Offset = "0x13F412C", VA = "0x13F412C")]
	public ES2MemoryStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x13F41A8", Offset = "0x13F41A8", VA = "0x13F41A8")]
	public ES2MemoryStream(byte[] bytes, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x13F4224", Offset = "0x13F4224", VA = "0x13F4224")]
	public ES2MemoryStream()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x13F42AC", Offset = "0x13F42AC", VA = "0x13F42AC", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x13F4414", Offset = "0x13F4414", VA = "0x13F4414", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x13F441C", Offset = "0x13F441C", VA = "0x13F441C", Slot = "6")]
	public override byte[] ReadAllBytes()
	{
		return null;
	}
}
[Token(Token = "0x2000022")]
internal sealed class ES2PlayerPrefsStream : ES2Stream
{
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x13F44EC", Offset = "0x13F44EC", VA = "0x13F44EC")]
	public ES2PlayerPrefsStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x13F46A4", Offset = "0x13F46A4", VA = "0x13F46A4", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x13F4A6C", Offset = "0x13F4A6C", VA = "0x13F4A6C")]
	private void StoreRaw()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x13F49D8", Offset = "0x13F49D8", VA = "0x13F49D8")]
	private void StoreRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x13F4B00", Offset = "0x13F4B00", VA = "0x13F4B00")]
	private void StoreRaw(string bytes)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x13F48F8", Offset = "0x13F48F8", VA = "0x13F48F8")]
	private void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x13F489C", Offset = "0x13F489C", VA = "0x13F489C")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x13F453C", Offset = "0x13F453C", VA = "0x13F453C")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x13F4648", Offset = "0x13F4648", VA = "0x13F4648")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x13F4B20", Offset = "0x13F4B20", VA = "0x13F4B20", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000023")]
internal sealed class ES2ResourcesStream : ES2Stream
{
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x13F7708", Offset = "0x13F7708", VA = "0x13F7708")]
	public ES2ResourcesStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x13F78B4", Offset = "0x13F78B4", VA = "0x13F78B4", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x13F7920", Offset = "0x13F7920", VA = "0x13F7920", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000024")]
public abstract class ES2Stream
{
	[Token(Token = "0x200016C")]
	public enum Operation
	{
		[Token(Token = "0x4000437")]
		Read,
		[Token(Token = "0x4000438")]
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
		[Address(RVA = "0x13F5BB8", Offset = "0x13F5BB8", VA = "0x13F5BB8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x13F8BA0", Offset = "0x13F8BA0", VA = "0x13F8BA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public long Position
	{
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x13EEACC", Offset = "0x13EEACC", VA = "0x13EEACC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x13EF028", Offset = "0x13EF028", VA = "0x13EF028")]
		set
		{
		}
	}

	[Token(Token = "0x60001F6")]
	public abstract void Store();

	[Token(Token = "0x60001F7")]
	public abstract bool MayRequireOverwrite();

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x13F5D88", Offset = "0x13F5D88", VA = "0x13F5D88")]
	public byte[] ReadBytes(int count)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x13F4430", Offset = "0x13F4430", VA = "0x13F4430", Slot = "6")]
	public virtual byte[] ReadAllBytes()
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x13F21F8", Offset = "0x13F21F8", VA = "0x13F21F8")]
	protected void WriteToStreamFast(Stream writableStream)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x13F226C", Offset = "0x13F226C", VA = "0x13F226C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD668", Offset = "0x9FD668")]
	protected void WriteToStreamLowMemory(Stream writableStream)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x13F75C8", Offset = "0x13F75C8", VA = "0x13F75C8")]
	public static ES2Stream Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x13F7474", Offset = "0x13F7474", VA = "0x13F7474")]
	public static ES2Stream Create(ES2Settings settings, Operation operation)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x13F1EA4", Offset = "0x13F1EA4", VA = "0x13F1EA4")]
	protected ES2Stream()
	{
	}
}
[Token(Token = "0x2000025")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6690", Offset = "0x9F6690")]
public sealed class ES2_BoneWeight : ES2Type
{
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x107964C", Offset = "0x107964C", VA = "0x107964C")]
	public ES2_BoneWeight()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x10796DC", Offset = "0x10796DC", VA = "0x10796DC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1079858", Offset = "0x1079858", VA = "0x1079858", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F66A4", Offset = "0x9F66A4")]
public sealed class ES2_Bounds : ES2Type
{
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x10799FC", Offset = "0x10799FC", VA = "0x10799FC")]
	public ES2_Bounds()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1079A8C", Offset = "0x1079A8C", VA = "0x1079A8C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1079B68", Offset = "0x1079B68", VA = "0x1079B68", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F66B8", Offset = "0x9F66B8")]
public sealed class ES2_Color : ES2Type
{
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x107A3EC", Offset = "0x107A3EC", VA = "0x107A3EC")]
	public ES2_Color()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x107A47C", Offset = "0x107A47C", VA = "0x107A47C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x107A558", Offset = "0x107A558", VA = "0x107A558", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000028")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F66CC", Offset = "0x9F66CC")]
public sealed class ES2_Color32 : ES2Type
{
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x107A660", Offset = "0x107A660", VA = "0x107A660")]
	public ES2_Color32()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x107A6F0", Offset = "0x107A6F0", VA = "0x107A6F0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x107A7D0", Offset = "0x107A7D0", VA = "0x107A7D0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000029")]
public class ES2_DateTime : ES2Type
{
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x107A8CC", Offset = "0x107A8CC", VA = "0x107A8CC", Slot = "4")]
	public override void Write(object obj, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x107A980", Offset = "0x107A980", VA = "0x107A980", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x107AA14", Offset = "0x107AA14", VA = "0x107AA14")]
	public ES2_DateTime()
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F66E0", Offset = "0x9F66E0")]
public sealed class ES2_ES2AutoSaveManager : ES2Type
{
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x107AA98", Offset = "0x107AA98", VA = "0x107AA98")]
	public ES2_ES2AutoSaveManager()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x107AB1C", Offset = "0x107AB1C", VA = "0x107AB1C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x107ABB8", Offset = "0x107ABB8", VA = "0x107ABB8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x107ABE0", Offset = "0x107ABE0", VA = "0x107ABE0", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200002B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F66F4", Offset = "0x9F66F4")]
public sealed class ES2_Enum : ES2Type
{
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x107AC7C", Offset = "0x107AC7C", VA = "0x107AC7C")]
	public ES2_Enum()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x107AD0C", Offset = "0x107AD0C", VA = "0x107AD0C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x107ADAC", Offset = "0x107ADAC", VA = "0x107ADAC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6708", Offset = "0x9F6708")]
public sealed class ES2_Gradient : ES2Type
{
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x107AE30", Offset = "0x107AE30", VA = "0x107AE30")]
	public ES2_Gradient()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x107AEB4", Offset = "0x107AEB4", VA = "0x107AEB4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x107AF8C", Offset = "0x107AF8C", VA = "0x107AF8C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F671C", Offset = "0x9F671C")]
public sealed class ES2_GradientAlphaKey : ES2Type
{
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x107B100", Offset = "0x107B100", VA = "0x107B100")]
	public ES2_GradientAlphaKey()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x107B184", Offset = "0x107B184", VA = "0x107B184", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x107B234", Offset = "0x107B234", VA = "0x107B234", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6730", Offset = "0x9F6730")]
public sealed class ES2_GradientColorKey : ES2Type
{
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x107B07C", Offset = "0x107B07C", VA = "0x107B07C")]
	public ES2_GradientColorKey()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x107B2F4", Offset = "0x107B2F4", VA = "0x107B2F4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x107B41C", Offset = "0x107B41C", VA = "0x107B41C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6744", Offset = "0x9F6744")]
public sealed class ES2_Material : ES2Type
{
	[Token(Token = "0x6000222")]
	[Address(RVA = "0x107B504", Offset = "0x107B504", VA = "0x107B504")]
	public ES2_Material()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x107B594", Offset = "0x107B594", VA = "0x107B594", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x107C0F0", Offset = "0x107C0F0", VA = "0x107C0F0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x107C194", Offset = "0x107C194", VA = "0x107C194", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6758", Offset = "0x9F6758")]
public sealed class ES2_Matrix4x4 : ES2Type
{
	[Token(Token = "0x6000226")]
	[Address(RVA = "0x107C528", Offset = "0x107C528", VA = "0x107C528")]
	public ES2_Matrix4x4()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x107C5B8", Offset = "0x107C5B8", VA = "0x107C5B8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x107C6D8", Offset = "0x107C6D8", VA = "0x107C6D8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F676C", Offset = "0x9F676C")]
public sealed class ES2_Mesh : ES2Type
{
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x107C7D0", Offset = "0x107C7D0", VA = "0x107C7D0")]
	public ES2_Mesh()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x107C860", Offset = "0x107C860", VA = "0x107C860", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x107CB44", Offset = "0x107CB44", VA = "0x107CB44", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x107CBC8", Offset = "0x107CBC8", VA = "0x107CBC8", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6780", Offset = "0x9F6780")]
public sealed class ES2_Quaternion : ES2Type
{
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x107D9AC", Offset = "0x107D9AC", VA = "0x107D9AC")]
	public ES2_Quaternion()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x107DA3C", Offset = "0x107DA3C", VA = "0x107DA3C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x107DB44", Offset = "0x107DB44", VA = "0x107DB44", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6794", Offset = "0x9F6794")]
public sealed class ES2_Rect : ES2Type
{
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x107DC4C", Offset = "0x107DC4C", VA = "0x107DC4C")]
	public ES2_Rect()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x107DCDC", Offset = "0x107DCDC", VA = "0x107DCDC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x107DDDC", Offset = "0x107DDDC", VA = "0x107DDDC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F67A8", Offset = "0x9F67A8")]
public sealed class ES2_Sprite : ES2Type
{
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x107E768", Offset = "0x107E768", VA = "0x107E768")]
	public ES2_Sprite()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x107E7F8", Offset = "0x107E7F8", VA = "0x107E7F8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x107EA64", Offset = "0x107EA64", VA = "0x107EA64", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000035")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F67BC", Offset = "0x9F67BC")]
public sealed class ES2_Texture : ES2Type
{
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x107EB88", Offset = "0x107EB88", VA = "0x107EB88")]
	public ES2_Texture()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x107EC0C", Offset = "0x107EC0C", VA = "0x107EC0C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x107ED58", Offset = "0x107ED58", VA = "0x107ED58", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x107EE90", Offset = "0x107EE90", VA = "0x107EE90", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F67D0", Offset = "0x9F67D0")]
public sealed class ES2_Texture2D : ES2Type
{
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x107EFC8", Offset = "0x107EFC8", VA = "0x107EFC8")]
	public ES2_Texture2D()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x107F058", Offset = "0x107F058", VA = "0x107F058", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x107F1E0", Offset = "0x107F1E0", VA = "0x107F1E0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x107F26C", Offset = "0x107F26C", VA = "0x107F26C", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000037")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F67E4", Offset = "0x9F67E4")]
public sealed class ES2_Vector2 : ES2Type
{
	[Token(Token = "0x600023E")]
	[Address(RVA = "0x107D0B0", Offset = "0x107D0B0", VA = "0x107D0B0")]
	public ES2_Vector2()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x107F818", Offset = "0x107F818", VA = "0x107F818", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x107F8D8", Offset = "0x107F8D8", VA = "0x107F8D8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000038")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F67F8", Offset = "0x9F67F8")]
public sealed class ES2_Vector3 : ES2Type
{
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x107CF90", Offset = "0x107CF90", VA = "0x107CF90")]
	public ES2_Vector3()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x107F998", Offset = "0x107F998", VA = "0x107F998", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x107FA7C", Offset = "0x107FA7C", VA = "0x107FA7C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F680C", Offset = "0x9F680C")]
public sealed class ES2_Vector4 : ES2Type
{
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x107D140", Offset = "0x107D140", VA = "0x107D140")]
	public ES2_Vector4()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x107FB68", Offset = "0x107FB68", VA = "0x107FB68", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x107FC70", Offset = "0x107FC70", VA = "0x107FC70", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200003A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6820", Offset = "0x9F6820")]
public sealed class ES2_BoxCollider : ES2Type
{
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1079C44", Offset = "0x1079C44", VA = "0x1079C44")]
	public ES2_BoxCollider()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1079CD4", Offset = "0x1079CD4", VA = "0x1079CD4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x1079DE0", Offset = "0x1079DE0", VA = "0x1079DE0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x1079E5C", Offset = "0x1079E5C", VA = "0x1079E5C", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6834", Offset = "0x9F6834")]
public sealed class ES2_CapsuleCollider : ES2Type
{
	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1079FAC", Offset = "0x1079FAC", VA = "0x1079FAC")]
	public ES2_CapsuleCollider()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x107A03C", Offset = "0x107A03C", VA = "0x107A03C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x107A1AC", Offset = "0x107A1AC", VA = "0x107A1AC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x107A228", Offset = "0x107A228", VA = "0x107A228", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6848", Offset = "0x9F6848")]
public sealed class ES2_MeshCollider : ES2Type
{
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x107D1D0", Offset = "0x107D1D0", VA = "0x107D1D0")]
	public ES2_MeshCollider()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x107D260", Offset = "0x107D260", VA = "0x107D260", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x107D3A4", Offset = "0x107D3A4", VA = "0x107D3A4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x107D420", Offset = "0x107D420", VA = "0x107D420", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F685C", Offset = "0x9F685C")]
public sealed class ES2_PolygonCollider2D : ES2Type
{
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x107D5B4", Offset = "0x107D5B4", VA = "0x107D5B4")]
	public ES2_PolygonCollider2D()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x107D644", Offset = "0x107D644", VA = "0x107D644", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x107D7B4", Offset = "0x107D7B4", VA = "0x107D7B4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x107D830", Offset = "0x107D830", VA = "0x107D830", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6870", Offset = "0x9F6870")]
public sealed class ES2_SkinnedMeshRenderer : ES2Type
{
	[Token(Token = "0x6000257")]
	[Address(RVA = "0x107DEE4", Offset = "0x107DEE4", VA = "0x107DEE4")]
	public ES2_SkinnedMeshRenderer()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x107DF74", Offset = "0x107DF74", VA = "0x107DF74", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x107E12C", Offset = "0x107E12C", VA = "0x107E12C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x107E1A8", Offset = "0x107E1A8", VA = "0x107E1A8", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6884", Offset = "0x9F6884")]
public sealed class ES2_SphereCollider : ES2Type
{
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x107E3E4", Offset = "0x107E3E4", VA = "0x107E3E4")]
	public ES2_SphereCollider()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x107E474", Offset = "0x107E474", VA = "0x107E474", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x107E590", Offset = "0x107E590", VA = "0x107E590", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x107E60C", Offset = "0x107E60C", VA = "0x107E60C", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000040")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6898", Offset = "0x9F6898")]
public sealed class ES2_Transform : ES2Type
{
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x107F44C", Offset = "0x107F44C", VA = "0x107F44C")]
	public ES2_Transform()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x107F4DC", Offset = "0x107F4DC", VA = "0x107F4DC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x107F60C", Offset = "0x107F60C", VA = "0x107F60C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x107F688", Offset = "0x107F688", VA = "0x107F688", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000041")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F68AC", Offset = "0x9F68AC")]
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
	[Address(RVA = "0x13F8BC4", Offset = "0x13F8BC4", VA = "0x13F8BC4")]
	public ES2Type(Type type)
	{
	}

	[Token(Token = "0x6000264")]
	public abstract void Write(object data, ES2Writer writer);

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x13F8C28", Offset = "0x13F8C28", VA = "0x13F8C28", Slot = "5")]
	public virtual object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x13F8CE0", Offset = "0x13F8CE0", VA = "0x13F8CE0", Slot = "6")]
	public virtual void Read(ES2Reader reader, object c)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x13F8D90", Offset = "0x13F8D90", VA = "0x13F8D90", Slot = "7")]
	public virtual void Read(ES2Reader reader, Component c)
	{
	}

	[Token(Token = "0x6000268")]
	public static T GetOrCreate<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x13F8C04", Offset = "0x13F8C04", VA = "0x13F8C04")]
	public static int GetHash(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x13F8D9C", Offset = "0x13F8D9C", VA = "0x13F8D9C")]
	public static int GetHash(string value)
	{
		return default(int);
	}
}
[Token(Token = "0x2000042")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F68C0", Offset = "0x9F68C0")]
public static class ES2TypeManager
{
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<Type, ES2Type> types;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES2Type cachedType;

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x13F8E8C", Offset = "0x13F8E8C", VA = "0x13F8E8C")]
	public static void AddES2Type(ES2Type es2Type)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x13ED3E8", Offset = "0x13ED3E8", VA = "0x13ED3E8")]
	public static ES2Type GetES2Type(Type type)
	{
		return null;
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x13F57F0", Offset = "0x13F57F0", VA = "0x13F57F0")]
	public static ES2Type GetES2Type(byte key)
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x13F8F38", Offset = "0x13F8F38", VA = "0x13F8F38")]
	public static ES2Type GetES2Type(ES2Keys.Key key)
	{
		return null;
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x13EEDFC", Offset = "0x13EEDFC", VA = "0x13EEDFC")]
	public static ES2Type GetES2Type(int hash)
	{
		return null;
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F68D4", Offset = "0x9F68D4")]
public sealed class ES2_bool : ES2Type
{
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x107FD78", Offset = "0x107FD78", VA = "0x107FD78")]
	public ES2_bool()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x107FE08", Offset = "0x107FE08", VA = "0x107FE08", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x107FEA4", Offset = "0x107FEA4", VA = "0x107FEA4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F68E8", Offset = "0x9F68E8")]
public sealed class ES2_byte : ES2Type
{
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x107FF28", Offset = "0x107FF28", VA = "0x107FF28")]
	public ES2_byte()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x107FFB4", Offset = "0x107FFB4", VA = "0x107FFB4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1080050", Offset = "0x1080050", VA = "0x1080050", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F68FC", Offset = "0x9F68FC")]
public sealed class ES2_char : ES2Type
{
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x10800D0", Offset = "0x10800D0", VA = "0x10800D0")]
	public ES2_char()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1080160", Offset = "0x1080160", VA = "0x1080160", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1080200", Offset = "0x1080200", VA = "0x1080200", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000046")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6910", Offset = "0x9F6910")]
public sealed class ES2_decimal : ES2Type
{
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x1080284", Offset = "0x1080284", VA = "0x1080284")]
	public ES2_decimal()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x1080314", Offset = "0x1080314", VA = "0x1080314", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x10803B4", Offset = "0x10803B4", VA = "0x10803B4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000047")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6924", Offset = "0x9F6924")]
public sealed class ES2_double : ES2Type
{
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x1080438", Offset = "0x1080438", VA = "0x1080438")]
	public ES2_double()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x10804C8", Offset = "0x10804C8", VA = "0x10804C8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1080568", Offset = "0x1080568", VA = "0x1080568", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6938", Offset = "0x9F6938")]
public sealed class ES2_float : ES2Type
{
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x10805E8", Offset = "0x10805E8", VA = "0x10805E8")]
	public ES2_float()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1080678", Offset = "0x1080678", VA = "0x1080678", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1080718", Offset = "0x1080718", VA = "0x1080718", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000049")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F694C", Offset = "0x9F694C")]
public sealed class ES2_int : ES2Type
{
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x107D020", Offset = "0x107D020", VA = "0x107D020")]
	public ES2_int()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x1080798", Offset = "0x1080798", VA = "0x1080798", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1080838", Offset = "0x1080838", VA = "0x1080838", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6960", Offset = "0x9F6960")]
public sealed class ES2_long : ES2Type
{
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x10808BC", Offset = "0x10808BC", VA = "0x10808BC")]
	public ES2_long()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x108094C", Offset = "0x108094C", VA = "0x108094C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x10809EC", Offset = "0x10809EC", VA = "0x10809EC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6974", Offset = "0x9F6974")]
public sealed class ES2_object : ES2Type
{
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1080A70", Offset = "0x1080A70", VA = "0x1080A70")]
	public ES2_object()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1080AF4", Offset = "0x1080AF4", VA = "0x1080AF4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1080C28", Offset = "0x1080C28", VA = "0x1080C28", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6988", Offset = "0x9F6988")]
public sealed class ES2_sbyte : ES2Type
{
	[Token(Token = "0x600028C")]
	[Address(RVA = "0x1080D14", Offset = "0x1080D14", VA = "0x1080D14")]
	public ES2_sbyte()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1080DA4", Offset = "0x1080DA4", VA = "0x1080DA4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1080E40", Offset = "0x1080E40", VA = "0x1080E40", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F699C", Offset = "0x9F699C")]
public sealed class ES2_short : ES2Type
{
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1080EC0", Offset = "0x1080EC0", VA = "0x1080EC0")]
	public ES2_short()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1080F50", Offset = "0x1080F50", VA = "0x1080F50", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1080FF0", Offset = "0x1080FF0", VA = "0x1080FF0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F69B0", Offset = "0x9F69B0")]
public sealed class ES2_string : ES2Type
{
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1081074", Offset = "0x1081074", VA = "0x1081074")]
	public ES2_string()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1081104", Offset = "0x1081104", VA = "0x1081104", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1081194", Offset = "0x1081194", VA = "0x1081194", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F69C4", Offset = "0x9F69C4")]
public sealed class ES2_uint : ES2Type
{
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x10811C0", Offset = "0x10811C0", VA = "0x10811C0")]
	public ES2_uint()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1081250", Offset = "0x1081250", VA = "0x1081250", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x10812F0", Offset = "0x10812F0", VA = "0x10812F0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F69D8", Offset = "0x9F69D8")]
public sealed class ES2_ulong : ES2Type
{
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x1081374", Offset = "0x1081374", VA = "0x1081374")]
	public ES2_ulong()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x1081404", Offset = "0x1081404", VA = "0x1081404", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x10814A4", Offset = "0x10814A4", VA = "0x10814A4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F69EC", Offset = "0x9F69EC")]
public sealed class ES2_ushort : ES2Type
{
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1081528", Offset = "0x1081528", VA = "0x1081528")]
	public ES2_ushort()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x10815B8", Offset = "0x10815B8", VA = "0x10815B8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x1081658", Offset = "0x1081658", VA = "0x1081658", Slot = "5")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC540", Offset = "0x9FC540")]
	public ES2Stream stream;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC554", Offset = "0x9FC554")]
	public HashSet<string> tagsToDelete;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC568", Offset = "0x9FC568")]
	public BinaryWriter writer;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC57C", Offset = "0x9FC57C")]
	private long lengthPosition;

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x13E4A6C", Offset = "0x13E4A6C", VA = "0x13E4A6C")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD67C", Offset = "0x9FD67C")]
	public void Write<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x60002A9")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD690", Offset = "0x9FD690")]
	public void Write<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AA")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD6A4", Offset = "0x9FD6A4")]
	public void Write<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AB")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD6B8", Offset = "0x9FD6B8")]
	public void Write<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD6CC", Offset = "0x9FD6CC")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002AD")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD6E0", Offset = "0x9FD6E0")]
	public void Write<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AE")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD6F4", Offset = "0x9FD6F4")]
	public void Write<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AF")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD708", Offset = "0x9FD708")]
	public void Write<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD71C", Offset = "0x9FD71C")]
	public void Write<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x13ED6C8", Offset = "0x13ED6C8", VA = "0x13ED6C8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD730", Offset = "0x9FD730")]
	public void WriteSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x13ED9A4", Offset = "0x13ED9A4", VA = "0x13ED9A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD744", Offset = "0x9FD744")]
	public void WriteICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x13EDCF4", Offset = "0x13EDCF4", VA = "0x13EDCF4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD758", Offset = "0x9FD758")]
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
	[Address(RVA = "0x13FA904", Offset = "0x13FA904", VA = "0x13FA904")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD76C", Offset = "0x9FD76C")]
	private void WriteEncryptedSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x13FAA88", Offset = "0x13FAA88", VA = "0x13FAA88")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD780", Offset = "0x9FD780")]
	private void WriteEncryptedICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x13FAC0C", Offset = "0x13FAC0C", VA = "0x13FAC0C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD794", Offset = "0x9FD794")]
	private void WriteEncryptedIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x13FAF98", Offset = "0x13FAF98", VA = "0x13FAF98")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD7A8", Offset = "0x9FD7A8")]
	public void WriteHeader(ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x13FAFC0", Offset = "0x13FAFC0", VA = "0x13FAFC0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD7BC", Offset = "0x9FD7BC")]
	public void WriteHeader(string tag, ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x13FB1AC", Offset = "0x13FB1AC", VA = "0x13FB1AC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD7D0", Offset = "0x9FD7D0")]
	public void WriteLength()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x13FB27C", Offset = "0x13FB27C", VA = "0x13FB27C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD7E4", Offset = "0x9FD7E4")]
	public void WriteTerminator()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x13FADA0", Offset = "0x13FADA0", VA = "0x13FADA0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD7F8", Offset = "0x9FD7F8")]
	public ES2Writer CreateEncryptedWriter()
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x13FAE3C", Offset = "0x13FAE3C", VA = "0x13FAE3C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD80C", Offset = "0x9FD80C")]
	public byte[] GetEncryptedBytes(string password)
	{
		return null;
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x13FB364", Offset = "0x13FB364", VA = "0x13FB364", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x13FB384", Offset = "0x13FB384", VA = "0x13FB384")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD820", Offset = "0x9FD820")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD834", Offset = "0x9FD834")]
	public void Write<T>(T param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD848", Offset = "0x9FD848")]
	public void Write<T>(T[] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD85C", Offset = "0x9FD85C")]
	public void Write<T>(T[,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD870", Offset = "0x9FD870")]
	public void Write<T>(T[,,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D5")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD884", Offset = "0x9FD884")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002D6")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD898", Offset = "0x9FD898")]
	public void Write<T>(List<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D7")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD8AC", Offset = "0x9FD8AC")]
	public void Write<T>(HashSet<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD8C0", Offset = "0x9FD8C0")]
	public void Write<T>(Queue<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D9")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD8D4", Offset = "0x9FD8D4")]
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
	[Address(RVA = "0x13EC9A4", Offset = "0x13EC9A4", VA = "0x13EC9A4")]
	public int WritePropertyPrefix()
	{
		return default(int);
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x13ED0C0", Offset = "0x13ED0C0", VA = "0x13ED0C0")]
	public void WritePropertyLength(int startPosition)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x13F15E8", Offset = "0x13F15E8", VA = "0x13F15E8")]
	public void Save()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x13E4AD4", Offset = "0x13E4AD4", VA = "0x13E4AD4")]
	public void Save(bool checkForOverwrite)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x13FB5CC", Offset = "0x13FB5CC", VA = "0x13FB5CC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD8E8", Offset = "0x9FD8E8")]
	public void Save(byte[] bytes)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x13F1C60", Offset = "0x13F1C60", VA = "0x13F1C60")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD8FC", Offset = "0x9FD8FC")]
	public bool Rename(string oldTag, string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x13F1580", Offset = "0x13F1580", VA = "0x13F1580")]
	public void Delete(string tag)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x13FB4B4", Offset = "0x13FB4B4", VA = "0x13FB4B4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD910", Offset = "0x9FD910")]
	public bool Delete()
	{
		return default(bool);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x13FB600", Offset = "0x13FB600", VA = "0x13FB600")]
	private bool Delete(byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x13FB720", Offset = "0x13FB720", VA = "0x13FB720")]
	public static ES2Writer Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x13EB5A0", Offset = "0x13EB5A0", VA = "0x13EB5A0")]
	public static ES2Writer Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x13E4A0C", Offset = "0x13E4A0C", VA = "0x13E4A0C")]
	public static ES2Writer Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x13FB2A0", Offset = "0x13FB2A0", VA = "0x13FB2A0")]
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
	[Address(RVA = "0x1085A84", Offset = "0x1085A84", VA = "0x1085A84")]
	public void Awake()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x1085BDC", Offset = "0x1085BDC", VA = "0x1085BDC")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1085BE8", Offset = "0x1085BE8", VA = "0x1085BE8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1085D54", Offset = "0x1085D54", VA = "0x1085D54")]
	public ES3AutoSave()
	{
	}
}
[Token(Token = "0x2000054")]
public class ES3AutoSaveMgr : MonoBehaviour, ISerializationCallbackReceiver
{
	[Token(Token = "0x200016D")]
	public enum LoadEvent
	{
		[Token(Token = "0x400043A")]
		None,
		[Token(Token = "0x400043B")]
		Awake,
		[Token(Token = "0x400043C")]
		Start
	}

	[Token(Token = "0x200016E")]
	public enum SaveEvent
	{
		[Token(Token = "0x400043E")]
		None,
		[Token(Token = "0x400043F")]
		OnApplicationQuit,
		[Token(Token = "0x4000440")]
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
		[Address(RVA = "0x1085D5C", Offset = "0x1085D5C", VA = "0x1085D5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x1085E84", Offset = "0x1085E84", VA = "0x1085E84")]
	public void Save()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x1085FE4", Offset = "0x1085FE4", VA = "0x1085FE4")]
	public void Load()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x1086088", Offset = "0x1086088", VA = "0x1086088")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x108609C", Offset = "0x108609C", VA = "0x108609C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x1086124", Offset = "0x1086124", VA = "0x1086124")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x1086138", Offset = "0x1086138", VA = "0x1086138")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x1085AE8", Offset = "0x1085AE8", VA = "0x1085AE8")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x1085C60", Offset = "0x1085C60", VA = "0x1085C60")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x10861A4", Offset = "0x10861A4", VA = "0x10861A4", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x10861A8", Offset = "0x10861A8", VA = "0x10861A8", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x10861AC", Offset = "0x10861AC", VA = "0x10861AC")]
	public ES3AutoSaveMgr()
	{
	}
}
[Token(Token = "0x2000055")]
public static class ES3
{
	[Token(Token = "0x200016F")]
	public enum Location
	{
		[Token(Token = "0x4000442")]
		File,
		[Token(Token = "0x4000443")]
		PlayerPrefs,
		[Token(Token = "0x4000444")]
		Memory,
		[Token(Token = "0x4000445")]
		Resources
	}

	[Token(Token = "0x2000170")]
	public enum Directory
	{
		[Token(Token = "0x4000447")]
		PersistentDataPath,
		[Token(Token = "0x4000448")]
		DataPath
	}

	[Token(Token = "0x2000171")]
	public enum EncryptionType
	{
		[Token(Token = "0x400044A")]
		None,
		[Token(Token = "0x400044B")]
		AES
	}

	[Token(Token = "0x2000172")]
	public enum Format
	{
		[Token(Token = "0x400044D")]
		JSON
	}

	[Token(Token = "0x2000173")]
	public enum ReferenceMode
	{
		[Token(Token = "0x400044F")]
		ByRef,
		[Token(Token = "0x4000450")]
		ByValue,
		[Token(Token = "0x4000451")]
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
	[Address(RVA = "0x10816DC", Offset = "0x10816DC", VA = "0x10816DC")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x1081890", Offset = "0x1081890", VA = "0x1081890")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x1081924", Offset = "0x1081924", VA = "0x1081924")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x1081760", Offset = "0x1081760", VA = "0x1081760")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x1081B84", Offset = "0x1081B84", VA = "0x1081B84")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x1081CA8", Offset = "0x1081CA8", VA = "0x1081CA8")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x1081D3C", Offset = "0x1081D3C", VA = "0x1081D3C")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x1081C08", Offset = "0x1081C08", VA = "0x1081C08")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x1081DD8", Offset = "0x1081DD8", VA = "0x1081DD8")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x1081FC0", Offset = "0x1081FC0", VA = "0x1081FC0")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x1081E5C", Offset = "0x1081E5C", VA = "0x1081E5C")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x108205C", Offset = "0x108205C", VA = "0x108205C")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x1082268", Offset = "0x1082268", VA = "0x1082268")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x10820E0", Offset = "0x10820E0", VA = "0x10820E0")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x1082304", Offset = "0x1082304", VA = "0x1082304")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x1082504", Offset = "0x1082504", VA = "0x1082504")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x1082398", Offset = "0x1082398", VA = "0x1082398")]
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
	[Address(RVA = "0x1082608", Offset = "0x1082608", VA = "0x1082608")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x10827E8", Offset = "0x10827E8", VA = "0x10827E8")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x108286C", Offset = "0x108286C", VA = "0x108286C")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x1082684", Offset = "0x1082684", VA = "0x1082684")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x1082900", Offset = "0x1082900", VA = "0x1082900")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x1082A10", Offset = "0x1082A10", VA = "0x1082A10")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x1082A94", Offset = "0x1082A94", VA = "0x1082A94")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x108297C", Offset = "0x108297C", VA = "0x108297C")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x1082B28", Offset = "0x1082B28", VA = "0x1082B28")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x1082C14", Offset = "0x1082C14", VA = "0x1082C14")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x1082BAC", Offset = "0x1082BAC", VA = "0x1082BAC")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x1082CA8", Offset = "0x1082CA8", VA = "0x1082CA8")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x1082D20", Offset = "0x1082D20", VA = "0x1082D20")]
	public static AudioClip LoadAudio(string audioFilePath)
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x1082DA4", Offset = "0x1082DA4", VA = "0x1082DA4")]
	public static AudioClip LoadAudio(string audioFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x1083008", Offset = "0x1083008", VA = "0x1083008")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x108318C", Offset = "0x108318C", VA = "0x108318C")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x1083210", Offset = "0x1083210", VA = "0x1083210")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x1083084", Offset = "0x1083084", VA = "0x1083084")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x10832E0", Offset = "0x10832E0", VA = "0x10832E0")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x1083514", Offset = "0x1083514", VA = "0x1083514")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x108338C", Offset = "0x108338C", VA = "0x108338C")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x10835E8", Offset = "0x10835E8", VA = "0x10835E8")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x1083830", Offset = "0x1083830", VA = "0x1083830")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x1083694", Offset = "0x1083694", VA = "0x1083694")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x10838FC", Offset = "0x10838FC", VA = "0x10838FC")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x1083A70", Offset = "0x1083A70", VA = "0x1083A70")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x1083980", Offset = "0x1083980", VA = "0x1083980")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x1083B44", Offset = "0x1083B44", VA = "0x1083B44")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x1083D7C", Offset = "0x1083D7C", VA = "0x1083D7C")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x1083E10", Offset = "0x1083E10", VA = "0x1083E10")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x1083BC8", Offset = "0x1083BC8", VA = "0x1083BC8")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x1083FBC", Offset = "0x1083FBC", VA = "0x1083FBC")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x1084160", Offset = "0x1084160", VA = "0x1084160")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x10841F4", Offset = "0x10841F4", VA = "0x10841F4")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x1084040", Offset = "0x1084040", VA = "0x1084040")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x1084290", Offset = "0x1084290", VA = "0x1084290")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x108430C", Offset = "0x108430C", VA = "0x108430C")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x1084390", Offset = "0x1084390", VA = "0x1084390")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1083EAC", Offset = "0x1083EAC", VA = "0x1083EAC")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x1084424", Offset = "0x1084424", VA = "0x1084424")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x10845A0", Offset = "0x10845A0", VA = "0x10845A0")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x10844A8", Offset = "0x10844A8", VA = "0x10844A8")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x108463C", Offset = "0x108463C", VA = "0x108463C")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1084A34", Offset = "0x1084A34", VA = "0x1084A34")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1084AB8", Offset = "0x1084AB8", VA = "0x1084AB8")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x10846B8", Offset = "0x10846B8", VA = "0x10846B8")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x1084B4C", Offset = "0x1084B4C", VA = "0x1084B4C")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x1084C6C", Offset = "0x1084C6C", VA = "0x1084C6C")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1084CF0", Offset = "0x1084CF0", VA = "0x1084CF0")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x1084BC8", Offset = "0x1084BC8", VA = "0x1084BC8")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1084E98", Offset = "0x1084E98", VA = "0x1084E98")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1084FB8", Offset = "0x1084FB8", VA = "0x1084FB8")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x108503C", Offset = "0x108503C", VA = "0x108503C")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1084F14", Offset = "0x1084F14", VA = "0x1084F14")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x10851E4", Offset = "0x10851E4", VA = "0x10851E4")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x1085320", Offset = "0x1085320", VA = "0x1085320")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x10853A4", Offset = "0x10853A4", VA = "0x10853A4")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x1085260", Offset = "0x1085260", VA = "0x1085260")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x1085438", Offset = "0x1085438", VA = "0x1085438")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x10855B0", Offset = "0x10855B0", VA = "0x10855B0")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x10854BC", Offset = "0x10854BC", VA = "0x10854BC")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x1085644", Offset = "0x1085644", VA = "0x1085644")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x10857E4", Offset = "0x10857E4", VA = "0x10857E4")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x1085868", Offset = "0x1085868", VA = "0x1085868")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x10856C0", Offset = "0x10856C0", VA = "0x10856C0")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x1085988", Offset = "0x1085988", VA = "0x1085988")]
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
	[Address(RVA = "0x108A79C", Offset = "0x108A79C", VA = "0x108A79C")]
	public ES3File()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x108ABC8", Offset = "0x108ABC8", VA = "0x108ABC8")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x108AC40", Offset = "0x108AC40", VA = "0x108AC40")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x108ACC0", Offset = "0x108ACC0", VA = "0x108ACC0")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x108ACC8", Offset = "0x108ACC8", VA = "0x108ACC8")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x108AD3C", Offset = "0x108AD3C", VA = "0x108AD3C")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x108ADB8", Offset = "0x108ADB8", VA = "0x108ADB8")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x108A804", Offset = "0x108A804", VA = "0x108A804")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x108AE44", Offset = "0x108AE44", VA = "0x108AE44")]
	public ES3File(byte[] bytes)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x108AEB8", Offset = "0x108AEB8", VA = "0x108AEB8")]
	public ES3File(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x108B2DC", Offset = "0x108B2DC", VA = "0x108B2DC")]
	public void Sync()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x108B5CC", Offset = "0x108B5CC", VA = "0x108B5CC")]
	public void Sync(string filePath)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x108B640", Offset = "0x108B640", VA = "0x108B640")]
	public void Sync(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x108B2E4", Offset = "0x108B2E4", VA = "0x108B2E4")]
	public void Sync(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x1089290", Offset = "0x1089290", VA = "0x1089290")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x108B6BC", Offset = "0x108B6BC", VA = "0x108B6BC")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x6000374")]
	public void Save<T>(string key, object value)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x10892E8", Offset = "0x10892E8", VA = "0x10892E8")]
	public void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x108AF4C", Offset = "0x108AF4C", VA = "0x108AF4C")]
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
	[Address(RVA = "0x1086E70", Offset = "0x1086E70", VA = "0x1086E70")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x108B76C", Offset = "0x108B76C", VA = "0x108B76C")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x108B810", Offset = "0x108B810", VA = "0x108B810")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x108B878", Offset = "0x108B878", VA = "0x108B878")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x108B8E0", Offset = "0x108B8E0", VA = "0x108B8E0")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x108B9E0", Offset = "0x108B9E0", VA = "0x108B9E0")]
	public Type GetKeyType(string key)
	{
		return null;
	}
}
[Token(Token = "0x2000057")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x6000380")]
	[Address(RVA = "0x108BACC", Offset = "0x108BACC", VA = "0x108BACC")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000058")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase, ISerializationCallbackReceiver
{
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x146E390", Offset = "0x146E390", VA = "0x146E390", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x146E394", Offset = "0x146E394", VA = "0x146E394", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x146E398", Offset = "0x146E398", VA = "0x146E398")]
	public ES3ReferenceMgr()
	{
	}
}
[Token(Token = "0x2000059")]
public class ES3Spreadsheet
{
	[Token(Token = "0x2000174")]
	protected struct Index
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int col;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int row;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xAF036C", Offset = "0xAF036C", VA = "0xAF036C")]
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
		[Address(RVA = "0x146E9BC", Offset = "0x146E9BC", VA = "0x146E9BC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000029")]
	public int RowCount
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x146E9C4", Offset = "0x146E9C4", VA = "0x146E9C4")]
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
	[Address(RVA = "0x146E9CC", Offset = "0x146E9CC", VA = "0x146E9CC")]
	private void SetCell(int col, int row, string value)
	{
	}

	[Token(Token = "0x6000388")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x146EA80", Offset = "0x146EA80", VA = "0x146EA80")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x146EB2C", Offset = "0x146EB2C", VA = "0x146EB2C")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x146EAFC", Offset = "0x146EAFC", VA = "0x146EAFC")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x146EE1C", Offset = "0x146EE1C", VA = "0x146EE1C")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x146EEE0", Offset = "0x146EEE0", VA = "0x146EEE0")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x146EBB0", Offset = "0x146EBB0", VA = "0x146EBB0")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x146EF84", Offset = "0x146EF84", VA = "0x146EF84")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x146F314", Offset = "0x146F314", VA = "0x146F314")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x146F390", Offset = "0x146F390", VA = "0x146F390")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x146F398", Offset = "0x146F398", VA = "0x146F398")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x146F410", Offset = "0x146F410", VA = "0x146F410")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x146EFF8", Offset = "0x146EFF8", VA = "0x146EFF8")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x146F608", Offset = "0x146F608", VA = "0x146F608")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x146F710", Offset = "0x146F710", VA = "0x146F710")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x146F498", Offset = "0x146F498", VA = "0x146F498")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x146F7EC", Offset = "0x146F7EC", VA = "0x146F7EC")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x200005A")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC048", Offset = "0x9FC048")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC170", Offset = "0x9FC170")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderPropertyEnumerator <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C7")]
				[Address(RVA = "0x146E0AC", Offset = "0x146E0AC", VA = "0x146E0AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C9")]
				[Address(RVA = "0x146E114", Offset = "0x146E114", VA = "0x146E114", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x146DFF0", Offset = "0x146DFF0", VA = "0x146DFF0")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x146E01C", Offset = "0x146E01C", VA = "0x146E01C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x146E020", Offset = "0x146E020", VA = "0x146E020", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x146E0B4", Offset = "0x146E0B4", VA = "0x146E0B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x146D510", Offset = "0x146D510", VA = "0x146D510")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x146DF80", Offset = "0x146DF80", VA = "0x146DF80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FE438", Offset = "0x9FE438")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC05C", Offset = "0x9FC05C")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x20001A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC180", Offset = "0x9FC180")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderRawEnumerator <>4__this;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0x146E320", Offset = "0x146E320", VA = "0x146E320", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CF")]
				[Address(RVA = "0x146E388", Offset = "0x146E388", VA = "0x146E388", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x146E18C", Offset = "0x146E18C", VA = "0x146E18C")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x146E1B8", Offset = "0x146E1B8", VA = "0x146E1B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x146E1BC", Offset = "0x146E1BC", VA = "0x146E1BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x146E328", Offset = "0x146E328", VA = "0x146E328", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x146D5A0", Offset = "0x146D5A0", VA = "0x146D5A0")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x146E11C", Offset = "0x146E11C", VA = "0x146E11C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FE49C", Offset = "0x9FE49C")]
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
		[Address(RVA = "0x146D4AC", Offset = "0x146D4AC", VA = "0x146D4AC", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x146D53C", Offset = "0x146D53C", VA = "0x146D53C", Slot = "39")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD924", Offset = "0x9FD924")]
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
	[Address(RVA = "0x146D480", Offset = "0x146D480", VA = "0x146D480")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x146D5CC", Offset = "0x146D5CC", VA = "0x146D5CC", Slot = "40")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD938", Offset = "0x9FD938")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD94C", Offset = "0x9FD94C")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x60003C2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD960", Offset = "0x9FD960")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x146D5E0", Offset = "0x146D5E0", VA = "0x146D5E0")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x146D6D8", Offset = "0x146D6D8", VA = "0x146D6D8")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x146D8C8", Offset = "0x146D8C8", VA = "0x146D8C8")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD974", Offset = "0x9FD974")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x60003CC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD988", Offset = "0x9FD988")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x60003CD")]
	private Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x146DAB8", Offset = "0x146DAB8", VA = "0x146DAB8")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x146DBF0", Offset = "0x146DBF0", VA = "0x146DBF0")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x146DC78", Offset = "0x146DC78", VA = "0x146DC78")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x146DB50", Offset = "0x146DB50", VA = "0x146DB50")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x146DD48", Offset = "0x146DD48", VA = "0x146DD48")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x146DDA8", Offset = "0x146DDA8", VA = "0x146DDA8")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x146DE5C", Offset = "0x146DE5C", VA = "0x146DE5C")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x146DEEC", Offset = "0x146DEEC", VA = "0x146DEEC")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC5A0", Offset = "0x9FC5A0")]
	public bool typeChecking;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC5B4", Offset = "0x9FC5B4")]
	public bool safeReflection;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC5C8", Offset = "0x9FC5C8")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC5DC", Offset = "0x9FC5DC")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FC5F0", Offset = "0x9FC5F0")]
	public string[] assemblyNames;

	[Token(Token = "0x1700002C")]
	public ES3.Location location
	{
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x146B0F4", Offset = "0x146B0F4", VA = "0x146B0F4")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x146E544", Offset = "0x146E544", VA = "0x146E544")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public string FullPath
	{
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x146B134", Offset = "0x146B134", VA = "0x146B134")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x146E54C", Offset = "0x146E54C", VA = "0x146E54C")]
	private void CopyInto(ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x146DB10", Offset = "0x146DB10", VA = "0x146DB10")]
	public ES3Settings()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x146DC50", Offset = "0x146DC50", VA = "0x146DC50")]
	public ES3Settings(string path)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x146DCE8", Offset = "0x146DCE8", VA = "0x146DCE8")]
	public ES3Settings(string path, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x146E678", Offset = "0x146E678", VA = "0x146E678")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x146E6B0", Offset = "0x146E6B0", VA = "0x146E6B0")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x146E6F0", Offset = "0x146E6F0", VA = "0x146E6F0")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x146E47C", Offset = "0x146E47C", VA = "0x146E47C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD99C", Offset = "0x9FD99C")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x146E5C0", Offset = "0x146E5C0", VA = "0x146E5C0")]
	protected void ApplyDefaults()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x146E72C", Offset = "0x146E72C", VA = "0x146E72C")]
	internal static void LoadDefaults()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x146E8AC", Offset = "0x146E8AC", VA = "0x146E8AC")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x146E950", Offset = "0x146E950", VA = "0x146E950", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FD9B0", Offset = "0x9FD9B0")]
	public object Clone()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200005C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F6A00", Offset = "0x9F6A00")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x146E400", Offset = "0x146E400", VA = "0x146E400")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x146E4D0", Offset = "0x146E4D0", VA = "0x146E4D0")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}
}
[Token(Token = "0x200005D")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC070", Offset = "0x9FC070")]
	private sealed class <Sync>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x108A344", Offset = "0x108A344", VA = "0x108A344", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x108A3AC", Offset = "0x108A3AC", VA = "0x108A3AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x1086970", Offset = "0x1086970", VA = "0x1086970")]
		[DebuggerHidden]
		public <Sync>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x108A1E0", Offset = "0x108A1E0", VA = "0x108A1E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x108A1E4", Offset = "0x108A1E4", VA = "0x108A1E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x108A34C", Offset = "0x108A34C", VA = "0x108A34C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC080", Offset = "0x9FC080")]
	private sealed class <UploadFile>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte[] bytes;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x108A72C", Offset = "0x108A72C", VA = "0x108A72C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x108A794", Offset = "0x108A794", VA = "0x108A794", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x1087414", Offset = "0x1087414", VA = "0x1087414")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x108A3B4", Offset = "0x108A3B4", VA = "0x108A3B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x108A490", Offset = "0x108A490", VA = "0x108A490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x108A3D0", Offset = "0x108A3D0", VA = "0x108A3D0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x108A734", Offset = "0x108A734", VA = "0x108A734", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC090", Offset = "0x9FC090")]
	private sealed class <DownloadFile>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3File es3File;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x10892F0", Offset = "0x10892F0", VA = "0x10892F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x1089358", Offset = "0x1089358", VA = "0x1089358", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1087A2C", Offset = "0x1087A2C", VA = "0x1087A2C")]
		[DebuggerHidden]
		public <DownloadFile>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1088EAC", Offset = "0x1088EAC", VA = "0x1088EAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1088F88", Offset = "0x1088F88", VA = "0x1088F88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1088EC8", Offset = "0x1088EC8", VA = "0x1088EC8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x10892F8", Offset = "0x10892F8", VA = "0x10892F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC0A0", Offset = "0x9FC0A0")]
	private sealed class <DownloadFile>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x108972C", Offset = "0x108972C", VA = "0x108972C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x1089794", Offset = "0x1089794", VA = "0x1089794", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1087A58", Offset = "0x1087A58", VA = "0x1087A58")]
		[DebuggerHidden]
		public <DownloadFile>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1089360", Offset = "0x1089360", VA = "0x1089360", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x108943C", Offset = "0x108943C", VA = "0x108943C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x108937C", Offset = "0x108937C", VA = "0x108937C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1089734", Offset = "0x1089734", VA = "0x1089734", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC0B0", Offset = "0x9FC0B0")]
	private sealed class <DeleteFile>d__50 : IEnumerator<object>, IEnumerator, IDisposable
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
		public string user;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700007C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x1088E3C", Offset = "0x1088E3C", VA = "0x1088E3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1088EA4", Offset = "0x1088EA4", VA = "0x1088EA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1087ED8", Offset = "0x1087ED8", VA = "0x1087ED8")]
		[DebuggerHidden]
		public <DeleteFile>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1088B78", Offset = "0x1088B78", VA = "0x1088B78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1088C54", Offset = "0x1088C54", VA = "0x1088C54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1088B94", Offset = "0x1088B94", VA = "0x1088B94")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1088E44", Offset = "0x1088E44", VA = "0x1088E44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC0C0", Offset = "0x9FC0C0")]
	private sealed class <RenameFile>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Settings newSettings;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700007E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x108A170", Offset = "0x108A170", VA = "0x108A170", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x108A1D8", Offset = "0x108A1D8", VA = "0x108A1D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x10883E8", Offset = "0x10883E8", VA = "0x10883E8")]
		[DebuggerHidden]
		public <RenameFile>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1089E7C", Offset = "0x1089E7C", VA = "0x1089E7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1089F58", Offset = "0x1089F58", VA = "0x1089F58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x1089E98", Offset = "0x1089E98", VA = "0x1089E98")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x108A178", Offset = "0x108A178", VA = "0x108A178", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC0D0", Offset = "0x9FC0D0")]
	private sealed class <DownloadFilenames>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000080")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x1089A98", Offset = "0x1089A98", VA = "0x1089A98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x1089B00", Offset = "0x1089B00", VA = "0x1089B00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x108854C", Offset = "0x108854C", VA = "0x108854C")]
		[DebuggerHidden]
		public <DownloadFilenames>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x108979C", Offset = "0x108979C", VA = "0x108979C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1089878", Offset = "0x1089878", VA = "0x1089878", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x10897B8", Offset = "0x10897B8", VA = "0x10897B8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1089AA0", Offset = "0x1089AA0", VA = "0x1089AA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC0E0", Offset = "0x9FC0E0")]
	private sealed class <DownloadTimestamp>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000082")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x1089E0C", Offset = "0x1089E0C", VA = "0x1089E0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x1089E74", Offset = "0x1089E74", VA = "0x1089E74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x10889CC", Offset = "0x10889CC", VA = "0x10889CC")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1089B08", Offset = "0x1089B08", VA = "0x1089B08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x1089BE4", Offset = "0x1089BE4", VA = "0x1089BE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x1089B24", Offset = "0x1089B24", VA = "0x1089B24")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x1089E14", Offset = "0x1089E14", VA = "0x1089E14", Slot = "8")]
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
		[Address(RVA = "0x1086294", Offset = "0x1086294", VA = "0x1086294")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002F")]
	public string text
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x108629C", Offset = "0x108629C", VA = "0x108629C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	public string[] filenames
	{
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x10862D0", Offset = "0x10862D0", VA = "0x10862D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000031")]
	public DateTime timestamp
	{
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1086394", Offset = "0x1086394", VA = "0x1086394")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x108624C", Offset = "0x108624C", VA = "0x108624C")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x108651C", Offset = "0x108651C", VA = "0x108651C")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x1086620", Offset = "0x1086620", VA = "0x1086620")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x10866A4", Offset = "0x10866A4", VA = "0x10866A4")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x108672C", Offset = "0x108672C", VA = "0x108672C")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x10867B8", Offset = "0x10867B8", VA = "0x10867B8")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x1086844", Offset = "0x1086844", VA = "0x1086844")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x10868DC", Offset = "0x10868DC", VA = "0x10868DC")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x1086590", Offset = "0x1086590", VA = "0x1086590")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FD9C4", Offset = "0x9FD9C4")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x108699C", Offset = "0x108699C", VA = "0x108699C")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x1086AA8", Offset = "0x1086AA8", VA = "0x1086AA8")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x1086B2C", Offset = "0x1086B2C", VA = "0x1086B2C")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x1086BB4", Offset = "0x1086BB4", VA = "0x1086BB4")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x1086C40", Offset = "0x1086C40", VA = "0x1086C40")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x1086CCC", Offset = "0x1086CCC", VA = "0x1086CCC")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x1086D64", Offset = "0x1086D64", VA = "0x1086D64")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x1086DF8", Offset = "0x1086DF8", VA = "0x1086DF8")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x1087344", Offset = "0x1087344", VA = "0x1087344")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x10873C0", Offset = "0x10873C0", VA = "0x10873C0")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x1086A10", Offset = "0x1086A10", VA = "0x1086A10")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x10872AC", Offset = "0x10872AC", VA = "0x10872AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FDA28", Offset = "0x9FDA28")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x1087440", Offset = "0x1087440", VA = "0x1087440")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x1087550", Offset = "0x1087550", VA = "0x1087550")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x10875D8", Offset = "0x10875D8", VA = "0x10875D8")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x1087664", Offset = "0x1087664", VA = "0x1087664")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x10876F4", Offset = "0x10876F4", VA = "0x10876F4")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x1087784", Offset = "0x1087784", VA = "0x1087784")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x1087820", Offset = "0x1087820", VA = "0x1087820")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x10878B8", Offset = "0x10878B8", VA = "0x10878B8")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x10879B8", Offset = "0x10879B8", VA = "0x10879B8")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x1087A24", Offset = "0x1087A24", VA = "0x1087A24")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x1087920", Offset = "0x1087920", VA = "0x1087920")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FDA8C", Offset = "0x9FDA8C")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x10874B8", Offset = "0x10874B8", VA = "0x10874B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FDAF0", Offset = "0x9FDAF0")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x1087A84", Offset = "0x1087A84", VA = "0x1087A84")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x1087B88", Offset = "0x1087B88", VA = "0x1087B88")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x1087C0C", Offset = "0x1087C0C", VA = "0x1087C0C")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x1087C94", Offset = "0x1087C94", VA = "0x1087C94")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x1087D20", Offset = "0x1087D20", VA = "0x1087D20")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x1087DAC", Offset = "0x1087DAC", VA = "0x1087DAC")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x1087E44", Offset = "0x1087E44", VA = "0x1087E44")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x1087AF8", Offset = "0x1087AF8", VA = "0x1087AF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FDB54", Offset = "0x9FDB54")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x1087F04", Offset = "0x1087F04", VA = "0x1087F04")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x1088048", Offset = "0x1088048", VA = "0x1088048")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x10880F8", Offset = "0x10880F8", VA = "0x10880F8")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x10881AC", Offset = "0x10881AC", VA = "0x10881AC")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x1088264", Offset = "0x1088264", VA = "0x1088264")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x1088328", Offset = "0x1088328", VA = "0x1088328")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x1087FB0", Offset = "0x1087FB0", VA = "0x1087FB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FDBB8", Offset = "0x9FDBB8")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x1088414", Offset = "0x1088414", VA = "0x1088414")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x10884EC", Offset = "0x10884EC", VA = "0x10884EC")]
	public IEnumerator DownloadFilenames(string user)
	{
		return null;
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x1088468", Offset = "0x1088468", VA = "0x1088468")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FDC1C", Offset = "0x9FDC1C")]
	public IEnumerator DownloadFilenames(string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x1088578", Offset = "0x1088578", VA = "0x1088578")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x108867C", Offset = "0x108867C", VA = "0x108867C")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x1088700", Offset = "0x1088700", VA = "0x1088700")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x1088788", Offset = "0x1088788", VA = "0x1088788")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x1088814", Offset = "0x1088814", VA = "0x1088814")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x10888A0", Offset = "0x10888A0", VA = "0x10888A0")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x1088938", Offset = "0x1088938", VA = "0x1088938")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x10885EC", Offset = "0x10885EC", VA = "0x10885EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FDC80", Offset = "0x9FDC80")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x10889F8", Offset = "0x10889F8", VA = "0x10889F8")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x1088B00", Offset = "0x1088B00", VA = "0x1088B00")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x1088B6C", Offset = "0x1088B6C", VA = "0x1088B6C", Slot = "4")]
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
	[Address(RVA = "0x1246B58", Offset = "0x1246B58", VA = "0x1246B58")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x600044D")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x1246C04", Offset = "0x1246C04", VA = "0x1246C04", Slot = "40")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x1246D60", Offset = "0x1246D60", VA = "0x1246D60", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDCE4", Offset = "0x9FDCE4")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x1246E80", Offset = "0x1246E80", VA = "0x1246E80", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDCF8", Offset = "0x9FDCF8")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x1246F50", Offset = "0x1246F50", VA = "0x1246F50", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDD0C", Offset = "0x9FDD0C")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x124724C", Offset = "0x124724C", VA = "0x124724C", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x12473B0", Offset = "0x12473B0", VA = "0x12473B0", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x1247400", Offset = "0x1247400", VA = "0x1247400", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x1247450", Offset = "0x1247450", VA = "0x1247450", Slot = "47")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDD20", Offset = "0x9FDD20")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x12474B0", Offset = "0x12474B0", VA = "0x12474B0", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDD34", Offset = "0x9FDD34")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000457")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x123E928", Offset = "0x123E928", VA = "0x123E928")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDD48", Offset = "0x9FDD48")]
	public void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x1247508", Offset = "0x1247508", VA = "0x1247508")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x1247764", Offset = "0x1247764", VA = "0x1247764")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x12479C0", Offset = "0x12479C0", VA = "0x12479C0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDD5C", Offset = "0x9FDD5C")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x1247BE0", Offset = "0x1247BE0", VA = "0x1247BE0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDD70", Offset = "0x9FDD70")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x1247E00", Offset = "0x1247E00", VA = "0x1247E00")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDD84", Offset = "0x9FDD84")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x1248044", Offset = "0x1248044", VA = "0x1248044")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDD98", Offset = "0x9FDD98")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x1246CC8", Offset = "0x1246CC8", VA = "0x1246CC8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDDAC", Offset = "0x9FDDAC")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x1248288", Offset = "0x1248288", VA = "0x1248288")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x1248308", Offset = "0x1248308", VA = "0x1248308")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1248318", Offset = "0x1248318", VA = "0x1248318")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1248378", Offset = "0x1248378", VA = "0x1248378")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x12484DC", Offset = "0x12484DC", VA = "0x12484DC", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FDDC0", Offset = "0x9FDDC0")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x1248544", Offset = "0x1248544", VA = "0x1248544")]
	protected void Merge()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x124863C", Offset = "0x124863C", VA = "0x124863C")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x12488F0", Offset = "0x12488F0", VA = "0x12488F0", Slot = "51")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x1248904", Offset = "0x1248904", VA = "0x1248904", Slot = "52")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200005F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6A14", Offset = "0x9F6A14")]
public class CurrentTime : MonoBehaviour
{
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MusicPlayer musicPlayer;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text m_Text;

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x13E42C8", Offset = "0x13E42C8", VA = "0x13E42C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x13E4320", Offset = "0x13E4320", VA = "0x13E4320")]
	private void Update()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x13E447C", Offset = "0x13E447C", VA = "0x13E447C")]
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
	[Address(RVA = "0x124C084", Offset = "0x124C084", VA = "0x124C084")]
	public void SetMusicVolume(float attenuation)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x124C0A8", Offset = "0x124C0A8", VA = "0x124C0A8")]
	public MusicVolumeControl()
	{
	}
}
[Token(Token = "0x2000061")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6A78", Offset = "0x9F6A78")]
public class NowPlaying : MonoBehaviour
{
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Text;

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x124C100", Offset = "0x124C100", VA = "0x124C100")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x124C158", Offset = "0x124C158", VA = "0x124C158")]
	public void OnPlay(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x124C19C", Offset = "0x124C19C", VA = "0x124C19C")]
	public void OnStop(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x124C200", Offset = "0x124C200", VA = "0x124C200")]
	public void OnPause(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x124C264", Offset = "0x124C264", VA = "0x124C264")]
	public void OnUnPause(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x124C2A8", Offset = "0x124C2A8", VA = "0x124C2A8")]
	public void OnTrackChange(MusicPlayer mp)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x124C2EC", Offset = "0x124C2EC", VA = "0x124C2EC")]
	public NowPlaying()
	{
	}
}
[Token(Token = "0x2000062")]
public class PlaylistList : MonoBehaviour
{
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC0F0", Offset = "0x9FC0F0")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Playlist p2;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlaylistList <>4__this;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x124C6A0", Offset = "0x124C6A0", VA = "0x124C6A0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x124C6B0", Offset = "0x124C6B0", VA = "0x124C6B0")]
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
	[Address(RVA = "0x124C2F4", Offset = "0x124C2F4", VA = "0x124C2F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x124C6A8", Offset = "0x124C6A8", VA = "0x124C6A8")]
	public PlaylistList()
	{
	}
}
[Token(Token = "0x2000063")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6ADC", Offset = "0x9F6ADC")]
public class Seek : MonoBehaviour
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MusicPlayer musicPlayer;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Slider m_Slider;

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x124C6E0", Offset = "0x124C6E0", VA = "0x124C6E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x124C738", Offset = "0x124C738", VA = "0x124C738")]
	private void Update()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x124C794", Offset = "0x124C794", VA = "0x124C794")]
	public void OnEndDrag(BaseEventData eventData)
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x124C7D8", Offset = "0x124C7D8", VA = "0x124C7D8")]
	public Seek()
	{
	}
}
[Token(Token = "0x2000064")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6B40", Offset = "0x9F6B40")]
public class TrackLength : MonoBehaviour
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text m_Text;

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x124C7E0", Offset = "0x124C7E0", VA = "0x124C7E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x124C858", Offset = "0x124C858", VA = "0x124C858")]
	public void OnTrackChange(MusicPlayer player)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x124C9C8", Offset = "0x124C9C8", VA = "0x124C9C8")]
	public TrackLength()
	{
	}
}
[Token(Token = "0x2000065")]
public class TrackList : MonoBehaviour
{
	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC100", Offset = "0x9FC100")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Playlist currentPlaylist;

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x124CEF4", Offset = "0x124CEF4", VA = "0x124CEF4")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x124CF0C", Offset = "0x124CF0C", VA = "0x124CF0C")]
		internal void <PlaylistChange>b__0(bool on)
		{
		}
	}

	[Token(Token = "0x2000181")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC110", Offset = "0x9FC110")]
	private sealed class <>c__DisplayClass3_1
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Track t2;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject to;

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x124CEFC", Offset = "0x124CEFC", VA = "0x124CEFC")]
		public <>c__DisplayClass3_1()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x124CF2C", Offset = "0x124CF2C", VA = "0x124CF2C")]
		internal void <PlaylistChange>b__1(bool on)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x124CF4C", Offset = "0x124CF4C", VA = "0x124CF4C")]
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
	[Address(RVA = "0x124C9D0", Offset = "0x124C9D0", VA = "0x124C9D0")]
	public void PlaylistChange(MusicPlayer player)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x124CF04", Offset = "0x124CF04", VA = "0x124CF04")]
	public TrackList()
	{
	}
}
[Token(Token = "0x2000066")]
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6BA4", Offset = "0x9F6BA4")]
public class FastLUTPostprocess : MonoBehaviour
{
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture3D lutTexture;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FC634", Offset = "0x9FC634")]
	public bool enableBlendOfLUTIntensity;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC66C", Offset = "0x9FC66C")]
	public float blendProgress;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FC684", Offset = "0x9FC684")]
	public bool clampColorRangeTo01;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x9FC6BC", Offset = "0x9FC6BC")]
	public Shader lutShader;

	[Token(Token = "0x4000106")]
	private const string shaderName = "Hidden/MODev/Postprocess/FastLut";

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material lutMat;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x1248958", Offset = "0x1248958", VA = "0x1248958")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x12489E8", Offset = "0x12489E8", VA = "0x12489E8")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x1248AF4", Offset = "0x1248AF4", VA = "0x1248AF4")]
	protected void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x1248AF0", Offset = "0x1248AF0", VA = "0x1248AF0")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x1248DB4", Offset = "0x1248DB4", VA = "0x1248DB4")]
	public void SetBlendProgress(float progress)
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x1248C28", Offset = "0x1248C28", VA = "0x1248C28")]
	private void InitializeLUTMat()
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x1248DCC", Offset = "0x1248DCC", VA = "0x1248DCC")]
	public FastLUTPostprocess()
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000067")]
	public enum AAMode
	{
		[Token(Token = "0x4000109")]
		FXAA2,
		[Token(Token = "0x400010A")]
		FXAA3Console,
		[Token(Token = "0x400010B")]
		FXAA1PresetA,
		[Token(Token = "0x400010C")]
		FXAA1PresetB,
		[Token(Token = "0x400010D")]
		NFAA,
		[Token(Token = "0x400010E")]
		SSAA,
		[Token(Token = "0x400010F")]
		DLAA
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6BB4", Offset = "0x9F6BB4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6BB4", Offset = "0x9F6BB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6BB4", Offset = "0x9F6BB4")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x124CFB8", Offset = "0x124CFB8", VA = "0x124CFB8")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x124D01C", Offset = "0x124D01C", VA = "0x124D01C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x124D108", Offset = "0x124D108", VA = "0x124D108")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x124D650", Offset = "0x124D650", VA = "0x124D650")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6C4C", Offset = "0x9F6C4C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6C4C", Offset = "0x9F6C4C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6C4C", Offset = "0x9F6C4C")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000182")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x4000496")]
			Ghosting,
			[Token(Token = "0x4000497")]
			Anamorphic,
			[Token(Token = "0x4000498")]
			Combined
		}

		[Token(Token = "0x2000183")]
		public enum TweakMode
		{
			[Token(Token = "0x400049A")]
			Basic,
			[Token(Token = "0x400049B")]
			Complex
		}

		[Token(Token = "0x2000184")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x400049D")]
			Auto,
			[Token(Token = "0x400049E")]
			On,
			[Token(Token = "0x400049F")]
			Off
		}

		[Token(Token = "0x2000185")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40004A1")]
			Screen,
			[Token(Token = "0x40004A2")]
			Add
		}

		[Token(Token = "0x2000186")]
		public enum BloomQuality
		{
			[Token(Token = "0x40004A4")]
			Cheap,
			[Token(Token = "0x40004A5")]
			High
		}

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x124D674", Offset = "0x124D674", VA = "0x124D674", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x124D714", Offset = "0x124D714", VA = "0x124D714")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x124EAD0", Offset = "0x124EAD0", VA = "0x124EAD0")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x124E8D0", Offset = "0x124E8D0", VA = "0x124E8D0")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x124E5D8", Offset = "0x124E5D8", VA = "0x124E5D8")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x124E4F4", Offset = "0x124E4F4", VA = "0x124E4F4")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x124E6C4", Offset = "0x124E6C4", VA = "0x124E6C4")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x124EB98", Offset = "0x124EB98", VA = "0x124EB98")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000145")]
		Ghosting,
		[Token(Token = "0x4000146")]
		Anamorphic,
		[Token(Token = "0x4000147")]
		Combined
	}
	[Token(Token = "0x200006B")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000149")]
		Basic,
		[Token(Token = "0x400014A")]
		Complex
	}
	[Token(Token = "0x200006C")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x400014C")]
		Auto,
		[Token(Token = "0x400014D")]
		On,
		[Token(Token = "0x400014E")]
		Off
	}
	[Token(Token = "0x200006D")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000150")]
		Screen,
		[Token(Token = "0x4000151")]
		Add
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6CE4", Offset = "0x9F6CE4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6CE4", Offset = "0x9F6CE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6CE4", Offset = "0x9F6CE4")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x124ECD8", Offset = "0x124ECD8", VA = "0x124ECD8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x124EDB4", Offset = "0x124EDB4", VA = "0x124EDB4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x124FD00", Offset = "0x124FD00", VA = "0x124FD00")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x124FB10", Offset = "0x124FB10", VA = "0x124FB10")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x124F894", Offset = "0x124F894", VA = "0x124F894")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x124F9BC", Offset = "0x124F9BC", VA = "0x124F9BC")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x124FDB4", Offset = "0x124FDB4", VA = "0x124FDB4")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6D7C", Offset = "0x9F6D7C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6D7C", Offset = "0x9F6D7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6D7C", Offset = "0x9F6D7C")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000187")]
		public enum Resolution
		{
			[Token(Token = "0x40004A7")]
			Low,
			[Token(Token = "0x40004A8")]
			High
		}

		[Token(Token = "0x2000188")]
		public enum BlurType
		{
			[Token(Token = "0x40004AA")]
			Standard,
			[Token(Token = "0x40004AB")]
			Sgx
		}

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC6CC", Offset = "0x9FC6CC")]
		public float threshold;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC6E4", Offset = "0x9FC6E4")]
		public float intensity;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC6FC", Offset = "0x9FC6FC")]
		public float blurSize;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC714", Offset = "0x9FC714")]
		public int blurIterations;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1C940A4", Offset = "0x1C940A4", VA = "0x1C940A4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1C94628", Offset = "0x1C94628", VA = "0x1C94628")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1C946D8", Offset = "0x1C946D8", VA = "0x1C946D8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1C94AA4", Offset = "0x1C94AA4", VA = "0x1C94AA4")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6E14", Offset = "0x9F6E14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6E14", Offset = "0x9F6E14")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC72C", Offset = "0x9FC72C")]
		public int iterations;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC744", Offset = "0x9FC744")]
		public float blurSpread;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000032")]
		protected Material material
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1C94B40", Offset = "0x1C94B40", VA = "0x1C94B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1C94C78", Offset = "0x1C94C78", VA = "0x1C94C78")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1C94D74", Offset = "0x1C94D74", VA = "0x1C94D74")]
		protected void Start()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1C94E34", Offset = "0x1C94E34", VA = "0x1C94E34")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1C94FD8", Offset = "0x1C94FD8", VA = "0x1C94FD8")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1C95150", Offset = "0x1C95150", VA = "0x1C95150")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1C952BC", Offset = "0x1C952BC", VA = "0x1C952BC")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6E60", Offset = "0x9F6E60")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6E60", Offset = "0x9F6E60")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6E60", Offset = "0x9F6E60")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000189")]
		public enum BlurType
		{
			[Token(Token = "0x40004AD")]
			StandardGauss,
			[Token(Token = "0x40004AE")]
			SgxGauss
		}

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC75C", Offset = "0x9FC75C")]
		public int downsample;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC774", Offset = "0x9FC774")]
		public float blurSize;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC78C", Offset = "0x9FC78C")]
		public int blurIterations;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1C952D8", Offset = "0x1C952D8", VA = "0x1C952D8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1C95330", Offset = "0x1C95330", VA = "0x1C95330")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1C953E0", Offset = "0x1C953E0", VA = "0x1C953E0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1C95784", Offset = "0x1C95784", VA = "0x1C95784")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6EF8", Offset = "0x9F6EF8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F6EF8", Offset = "0x9F6EF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6EF8", Offset = "0x9F6EF8")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200018A")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40004B0")]
			CameraMotion,
			[Token(Token = "0x40004B1")]
			LocalBlur,
			[Token(Token = "0x40004B2")]
			Reconstruction,
			[Token(Token = "0x40004B3")]
			ReconstructionDX11,
			[Token(Token = "0x40004B4")]
			ReconstructionDisc
		}

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1C9579C", Offset = "0x1C9579C", VA = "0x1C9579C")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1C95A38", Offset = "0x1C95A38", VA = "0x1C95A38")]
		private new void Start()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1C95C94", Offset = "0x1C95C94", VA = "0x1C95C94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1C95D54", Offset = "0x1C95D54", VA = "0x1C95D54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1C95EB8", Offset = "0x1C95EB8", VA = "0x1C95EB8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1C95F9C", Offset = "0x1C95F9C", VA = "0x1C95F9C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1C95B38", Offset = "0x1C95B38", VA = "0x1C95B38")]
		private void Remember()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1C97944", Offset = "0x1C97944", VA = "0x1C97944")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1C97858", Offset = "0x1C97858", VA = "0x1C97858")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1C97934", Offset = "0x1C97934", VA = "0x1C97934")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1C97C80", Offset = "0x1C97C80", VA = "0x1C97C80")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6F90", Offset = "0x9F6F90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6F90", Offset = "0x9F6F90")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200018B")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40004B6")]
			Simple,
			[Token(Token = "0x40004B7")]
			Advanced
		}

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1C97DCC", Offset = "0x1C97DCC", VA = "0x1C97DCC")]
		private new void Start()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1C97E08", Offset = "0x1C97E08", VA = "0x1C97E08")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1C97E0C", Offset = "0x1C97E0C", VA = "0x1C97E0C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1C9806C", Offset = "0x1C9806C", VA = "0x1C9806C")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1C98460", Offset = "0x1C98460", VA = "0x1C98460")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1C98464", Offset = "0x1C98464", VA = "0x1C98464")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1C98760", Offset = "0x1C98760", VA = "0x1C98760")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F6FDC", Offset = "0x9F6FDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F6FDC", Offset = "0x9F6FDC")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1C98D90", Offset = "0x1C98D90", VA = "0x1C98D90", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1C98DE4", Offset = "0x1C98DE4", VA = "0x1C98DE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1C98E8C", Offset = "0x1C98E8C", VA = "0x1C98E8C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1C98F34", Offset = "0x1C98F34", VA = "0x1C98F34")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1C99130", Offset = "0x1C99130", VA = "0x1C99130")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1C99224", Offset = "0x1C99224", VA = "0x1C99224")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1C99530", Offset = "0x1C99530", VA = "0x1C99530")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1C9971C", Offset = "0x1C9971C", VA = "0x1C9971C")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7028", Offset = "0x9F7028")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7028", Offset = "0x9F7028")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1C99770", Offset = "0x1C99770", VA = "0x1C99770")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1C998EC", Offset = "0x1C998EC", VA = "0x1C998EC")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7074", Offset = "0x9F7074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7074", Offset = "0x9F7074")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7074", Offset = "0x9F7074")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC7A4", Offset = "0x9FC7A4")]
		public float intensity;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC7BC", Offset = "0x9FC7BC")]
		public float threshold;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC7D8", Offset = "0x9FC7D8")]
		public float blurSpread;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1C998FC", Offset = "0x1C998FC", VA = "0x1C998FC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1C9996C", Offset = "0x1C9996C", VA = "0x1C9996C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1C99CD4", Offset = "0x1C99CD4", VA = "0x1C99CD4")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F710C", Offset = "0x9F710C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F710C", Offset = "0x9F710C")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC7F0", Offset = "0x9FC7F0")]
		public float adaptationSpeed;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC80C", Offset = "0x9FC80C")]
		public float limitMinimum;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC824", Offset = "0x9FC824")]
		public float limitMaximum;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000033")]
		protected Material materialLum
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1C99CE8", Offset = "0x1C99CE8", VA = "0x1C99CE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		protected Material materialReduce
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x1C99DAC", Offset = "0x1C99DAC", VA = "0x1C99DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1C99E70", Offset = "0x1C99E70", VA = "0x1C99E70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		protected Material materialApply
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x1C99F34", Offset = "0x1C99F34", VA = "0x1C99F34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1C99FF8", Offset = "0x1C99FF8", VA = "0x1C99FF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1C9A08C", Offset = "0x1C9A08C", VA = "0x1C9A08C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1C9A1DC", Offset = "0x1C9A1DC", VA = "0x1C9A1DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1C9A404", Offset = "0x1C9A404", VA = "0x1C9A404")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1C9A660", Offset = "0x1C9A660", VA = "0x1C9A660")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1C9A870", Offset = "0x1C9A870", VA = "0x1C9A870")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7158", Offset = "0x9F7158")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7158", Offset = "0x9F7158")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7158", Offset = "0x9F7158")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1C9A8E8", Offset = "0x1C9A8E8", VA = "0x1C9A8E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1C9A960", Offset = "0x1C9A960", VA = "0x1C9A960")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1C9AD08", Offset = "0x1C9AD08", VA = "0x1C9AD08")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F71F0", Offset = "0x9F71F0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F71F0", Offset = "0x9F71F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F71F0", Offset = "0x9F71F0")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x200018C")]
		public enum BlurType
		{
			[Token(Token = "0x40004B9")]
			DiscBlur,
			[Token(Token = "0x40004BA")]
			DX11
		}

		[Token(Token = "0x200018D")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40004BC")]
			Low,
			[Token(Token = "0x40004BD")]
			Medium,
			[Token(Token = "0x40004BE")]
			High
		}

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1C9AD20", Offset = "0x1C9AD20", VA = "0x1C9AD20", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1C9AEC0", Offset = "0x1C9AEC0", VA = "0x1C9AEC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1C9AF38", Offset = "0x1C9AF38", VA = "0x1C9AF38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1C9B040", Offset = "0x1C9B040", VA = "0x1C9B040")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1C9ADA4", Offset = "0x1C9ADA4", VA = "0x1C9ADA4")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1C9B084", Offset = "0x1C9B084", VA = "0x1C9B084")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1C9B1E0", Offset = "0x1C9B1E0", VA = "0x1C9B1E0")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1C9B500", Offset = "0x1C9B500", VA = "0x1C9B500")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1C9CB58", Offset = "0x1C9CB58", VA = "0x1C9CB58")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7288", Offset = "0x9F7288")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7288", Offset = "0x9F7288")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7288", Offset = "0x9F7288")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x200018E")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40004C0")]
			OnlyBackground = 1,
			[Token(Token = "0x40004C1")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200018F")]
		public enum DofResolution
		{
			[Token(Token = "0x40004C3")]
			High = 2,
			[Token(Token = "0x40004C4")]
			Medium,
			[Token(Token = "0x40004C5")]
			Low
		}

		[Token(Token = "0x2000190")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40004C7")]
			Low = 1,
			[Token(Token = "0x40004C8")]
			High = 2,
			[Token(Token = "0x40004C9")]
			VeryHigh = 4
		}

		[Token(Token = "0x2000191")]
		public enum BokehDestination
		{
			[Token(Token = "0x40004CB")]
			Background = 1,
			[Token(Token = "0x40004CC")]
			Foreground,
			[Token(Token = "0x40004CD")]
			BackgroundAndForeground
		}

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1C9CBAC", Offset = "0x1C9CBAC", VA = "0x1C9CBAC")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1C9CC80", Offset = "0x1C9CC80", VA = "0x1C9CC80", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1C9CD84", Offset = "0x1C9CD84", VA = "0x1C9CD84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1C9CFB0", Offset = "0x1C9CFB0", VA = "0x1C9CFB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1C9D028", Offset = "0x1C9D028", VA = "0x1C9D028")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1C9D184", Offset = "0x1C9D184", VA = "0x1C9D184")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1C9D1A8", Offset = "0x1C9D1A8", VA = "0x1C9D1A8")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1C9D1CC", Offset = "0x1C9D1CC", VA = "0x1C9D1CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1C9DFB0", Offset = "0x1C9DFB0", VA = "0x1C9DFB0")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1C9E664", Offset = "0x1C9E664", VA = "0x1C9E664")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1C9EACC", Offset = "0x1C9EACC", VA = "0x1C9EACC")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1C9DE64", Offset = "0x1C9DE64", VA = "0x1C9DE64")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1C9E24C", Offset = "0x1C9E24C", VA = "0x1C9E24C")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1C9E920", Offset = "0x1C9E920", VA = "0x1C9E920")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1C9DB30", Offset = "0x1C9DB30", VA = "0x1C9DB30")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1C9EFB4", Offset = "0x1C9EFB4", VA = "0x1C9EFB4")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7320", Offset = "0x9F7320")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7320", Offset = "0x9F7320")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7320", Offset = "0x9F7320")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000192")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40004CF")]
			TriangleDepthNormals,
			[Token(Token = "0x40004D0")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40004D1")]
			SobelDepth,
			[Token(Token = "0x40004D2")]
			SobelDepthThin,
			[Token(Token = "0x40004D3")]
			TriangleLuminance
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1C9F08C", Offset = "0x1C9F08C", VA = "0x1C9F08C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1C9F1C4", Offset = "0x1C9F1C4", VA = "0x1C9F1C4")]
		private new void Start()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1C9F104", Offset = "0x1C9F104", VA = "0x1C9F104")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1C9F1D0", Offset = "0x1C9F1D0", VA = "0x1C9F1D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1C9F1D4", Offset = "0x1C9F1D4", VA = "0x1C9F1D4")]
		[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x9FDDD4", Offset = "0x9FDDD4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1C9F3C0", Offset = "0x1C9F3C0", VA = "0x1C9F3C0")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F73B8", Offset = "0x9F73B8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F73B8", Offset = "0x9F73B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F73B8", Offset = "0x9F73B8")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC83C", Offset = "0x9FC83C")]
		public float strengthX;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC854", Offset = "0x9FC854")]
		public float strengthY;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1C9F410", Offset = "0x1C9F410", VA = "0x1C9F410", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1C9F468", Offset = "0x1C9F468", VA = "0x1C9F468")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1C9F5D8", Offset = "0x1C9F5D8", VA = "0x1C9F5D8")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7450", Offset = "0x9F7450")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7450", Offset = "0x9F7450")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7450", Offset = "0x9F7450")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FC86C", Offset = "0x9FC86C")]
		public bool distanceFog;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FC8A4", Offset = "0x9FC8A4")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FC8DC", Offset = "0x9FC8DC")]
		public bool useRadialDistance;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FC914", Offset = "0x9FC914")]
		public bool heightFog;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FC94C", Offset = "0x9FC94C")]
		public float height;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC984", Offset = "0x9FC984")]
		public float heightDensity;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FC9A0", Offset = "0x9FC9A0")]
		public float startDistance;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1C9F5EC", Offset = "0x1C9F5EC", VA = "0x1C9F5EC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1C9F644", Offset = "0x1C9F644", VA = "0x1C9F644")]
		[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x9FDDE4", Offset = "0x9FDDE4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1C9FC7C", Offset = "0x1C9FC7C", VA = "0x1C9FC7C")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F74E8", Offset = "0x9F74E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F74E8", Offset = "0x9F74E8")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC9D8", Offset = "0x9FC9D8")]
		public float rampOffset;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1C9FC9C", Offset = "0x1C9FC9C", VA = "0x1C9FC9C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1C9FD78", Offset = "0x1C9FD78", VA = "0x1C9FD78")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7534", Offset = "0x9F7534")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7534", Offset = "0x9F7534")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000037")]
		protected Material material
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x1C99828", Offset = "0x1C99828", VA = "0x1C99828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1C9FD80", Offset = "0x1C9FD80", VA = "0x1C9FD80", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1C9FE30", Offset = "0x1C9FE30", VA = "0x1C9FE30", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1C998F4", Offset = "0x1C998F4", VA = "0x1C998F4")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F75BC", Offset = "0x9F75BC")]
	public class ImageEffects
	{
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1C9FEE0", Offset = "0x1C9FEE0", VA = "0x1C9FEE0")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1CA015C", Offset = "0x1CA015C", VA = "0x1CA015C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9FDDF4", Offset = "0x9FDDF4")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1CA01D4", Offset = "0x1CA01D4", VA = "0x1CA01D4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9FDE2C", Offset = "0x9FDE2C")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1CA0254", Offset = "0x1CA0254", VA = "0x1CA0254")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F75F4", Offset = "0x9F75F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F75F4", Offset = "0x9F75F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F75F4", Offset = "0x9F75F4")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FC9F0", Offset = "0x9FC9F0")]
		public float blurAmount;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1CA025C", Offset = "0x1CA025C", VA = "0x1CA025C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1CA0260", Offset = "0x1CA0260", VA = "0x1CA0260", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1CA02D4", Offset = "0x1CA02D4", VA = "0x1CA02D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1CA0658", Offset = "0x1CA0658", VA = "0x1CA0658")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F768C", Offset = "0x9F768C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F768C", Offset = "0x9F768C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F768C", Offset = "0x9F768C")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1CA066C", Offset = "0x1CA066C", VA = "0x1CA066C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1CA06E4", Offset = "0x1CA06E4", VA = "0x1CA06E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1CA1004", Offset = "0x1CA1004", VA = "0x1CA1004")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1CA1380", Offset = "0x1CA1380", VA = "0x1CA1380")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7724", Offset = "0x9F7724")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7724", Offset = "0x9F7724")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7724", Offset = "0x9F7724")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCA0C", Offset = "0x9FCA0C")]
		public float grainIntensityMin;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCA24", Offset = "0x9FCA24")]
		public float grainIntensityMax;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCA3C", Offset = "0x9FCA3C")]
		public float grainSize;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCA5C", Offset = "0x9FCA5C")]
		public float scratchIntensityMin;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCA74", Offset = "0x9FCA74")]
		public float scratchIntensityMax;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCA8C", Offset = "0x9FCA8C")]
		public float scratchFPS;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCAA4", Offset = "0x9FCAA4")]
		public float scratchJitter;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000038")]
		protected Material material
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1CA15C8", Offset = "0x1CA15C8", VA = "0x1CA15C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1CA1488", Offset = "0x1CA1488", VA = "0x1CA1488")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1CA1724", Offset = "0x1CA1724", VA = "0x1CA1724")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1CA1828", Offset = "0x1CA1828", VA = "0x1CA1828")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1CA1964", Offset = "0x1CA1964", VA = "0x1CA1964")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1CA1CAC", Offset = "0x1CA1CAC", VA = "0x1CA1CAC")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F77BC", Offset = "0x9F77BC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F77BC", Offset = "0x9F77BC")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1C94204", Offset = "0x1C94204", VA = "0x1C94204")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1CA1D0C", Offset = "0x1CA1D0C", VA = "0x1CA1D0C")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1CA1EE8", Offset = "0x1CA1EE8", VA = "0x1CA1EE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1CA1EF4", Offset = "0x1CA1EF4", VA = "0x1CA1EF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1CA1EF8", Offset = "0x1CA1EF8", VA = "0x1CA1EF8")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1CA1FA8", Offset = "0x1CA1FA8", VA = "0x1CA1FA8")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1CA1FB0", Offset = "0x1CA1FB0", VA = "0x1CA1FB0", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1C97DFC", Offset = "0x1C97DFC", VA = "0x1C97DFC")]
		protected void Start()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1C940FC", Offset = "0x1C940FC", VA = "0x1C940FC")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1C95F40", Offset = "0x1C95F40", VA = "0x1C95F40")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1CA2060", Offset = "0x1CA2060", VA = "0x1CA2060")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1C94580", Offset = "0x1C94580", VA = "0x1C94580")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1CA2068", Offset = "0x1CA2068", VA = "0x1CA2068")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1CA1CE0", Offset = "0x1CA1CE0", VA = "0x1CA1CE0")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1CA2268", Offset = "0x1CA2268", VA = "0x1CA2268")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1C94AC4", Offset = "0x1C94AC4", VA = "0x1C94AC4")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7830", Offset = "0x9F7830")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7830", Offset = "0x9F7830")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1CA25E4", Offset = "0x1CA25E4", VA = "0x1CA25E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1CA2650", Offset = "0x1CA2650", VA = "0x1CA2650")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1CA28CC", Offset = "0x1CA28CC", VA = "0x1CA28CC")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1CA2C44", Offset = "0x1CA2C44", VA = "0x1CA2C44")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1CA2DF0", Offset = "0x1CA2DF0", VA = "0x1CA2DF0")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000086")]
	internal class Quads
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1CA2DF8", Offset = "0x1CA2DF8", VA = "0x1CA2DF8")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1C9CDE0", Offset = "0x1C9CDE0", VA = "0x1C9CDE0")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1C9ECF4", Offset = "0x1C9ECF4", VA = "0x1C9ECF4")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1CA2F1C", Offset = "0x1CA2F1C", VA = "0x1CA2F1C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1CA3450", Offset = "0x1CA3450", VA = "0x1CA3450")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F78A4", Offset = "0x9F78A4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F78A4", Offset = "0x9F78A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F78A4", Offset = "0x9F78A4")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x2000193")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40004D5")]
			Additive,
			[Token(Token = "0x40004D6")]
			ScreenBlend,
			[Token(Token = "0x40004D7")]
			Multiply,
			[Token(Token = "0x40004D8")]
			Overlay,
			[Token(Token = "0x40004D9")]
			AlphaBlend
		}

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1CA345C", Offset = "0x1CA345C", VA = "0x1CA345C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1CA34B4", Offset = "0x1CA34B4", VA = "0x1CA34B4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1CA361C", Offset = "0x1CA361C", VA = "0x1CA361C")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F793C", Offset = "0x9F793C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F793C", Offset = "0x9F793C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F793C", Offset = "0x9F793C")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCABC", Offset = "0x9FCABC")]
		public float intensity;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCAD4", Offset = "0x9FCAD4")]
		public float radius;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCAF0", Offset = "0x9FCAF0")]
		public int blurIterations;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCB08", Offset = "0x9FCB08")]
		public float blurFilterDistance;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCB20", Offset = "0x9FCB20")]
		public int downsample;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1CA362C", Offset = "0x1CA362C", VA = "0x1CA362C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1CA3684", Offset = "0x1CA3684", VA = "0x1CA3684")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1CA372C", Offset = "0x1CA372C", VA = "0x1CA372C")]
		[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x9FDE64", Offset = "0x9FDE64")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1CA3F40", Offset = "0x1CA3F40", VA = "0x1CA3F40")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F79D4", Offset = "0x9F79D4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F79D4", Offset = "0x9F79D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F79D4", Offset = "0x9F79D4")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000194")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40004DB")]
			Low,
			[Token(Token = "0x40004DC")]
			Medium,
			[Token(Token = "0x40004DD")]
			High
		}

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCB38", Offset = "0x9FCB38")]
		public float m_Radius;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCB54", Offset = "0x9FCB54")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCB6C", Offset = "0x9FCB6C")]
		public int m_Blur;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCB84", Offset = "0x9FCB84")]
		public int m_Downsampling;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCB9C", Offset = "0x9FCB9C")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCBB8", Offset = "0x9FCBB8")]
		public float m_MinZ;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1CA3F5C", Offset = "0x1CA3F5C", VA = "0x1CA3F5C")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1CA400C", Offset = "0x1CA400C", VA = "0x1CA400C")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1CA40A8", Offset = "0x1CA40A8", VA = "0x1CA40A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1CA40B0", Offset = "0x1CA40B0", VA = "0x1CA40B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1CA4244", Offset = "0x1CA4244", VA = "0x1CA4244")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1CA4188", Offset = "0x1CA4188", VA = "0x1CA4188")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1CA42B8", Offset = "0x1CA42B8", VA = "0x1CA42B8")]
		[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x9FDE74", Offset = "0x9FDE74")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1CA4974", Offset = "0x1CA4974", VA = "0x1CA4974")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7A6C", Offset = "0x9F7A6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7A6C", Offset = "0x9F7A6C")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1CA49A8", Offset = "0x1CA49A8", VA = "0x1CA49A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1CA4A38", Offset = "0x1CA4A38", VA = "0x1CA4A38")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7AB8", Offset = "0x9F7AB8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7AB8", Offset = "0x9F7AB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7AB8", Offset = "0x9F7AB8")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000195")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40004DF")]
			Low,
			[Token(Token = "0x40004E0")]
			Normal,
			[Token(Token = "0x40004E1")]
			High
		}

		[Token(Token = "0x2000196")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40004E3")]
			Screen,
			[Token(Token = "0x40004E4")]
			Add
		}

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1CA4A40", Offset = "0x1CA4A40", VA = "0x1CA4A40", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1CA4AA8", Offset = "0x1CA4AA8", VA = "0x1CA4AA8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1CA5294", Offset = "0x1CA5294", VA = "0x1CA5294")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7B50", Offset = "0x9F7B50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7B50", Offset = "0x9F7B50")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000197")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x40004E6")]
			TiltShiftMode,
			[Token(Token = "0x40004E7")]
			IrisMode
		}

		[Token(Token = "0x2000198")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x40004E9")]
			Preview,
			[Token(Token = "0x40004EA")]
			Low,
			[Token(Token = "0x40004EB")]
			Normal,
			[Token(Token = "0x40004EC")]
			High
		}

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCBD4", Offset = "0x9FCBD4")]
		public float blurArea;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCBEC", Offset = "0x9FCBEC")]
		public float maxBlurSize;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCC04", Offset = "0x9FCC04")]
		public int downsample;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1CA5328", Offset = "0x1CA5328", VA = "0x1CA5328", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1CA5380", Offset = "0x1CA5380", VA = "0x1CA5380")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1CA5610", Offset = "0x1CA5610", VA = "0x1CA5610")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7BD8", Offset = "0x9F7BD8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7BD8", Offset = "0x9F7BD8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7BD8", Offset = "0x9F7BD8")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000199")]
		public enum TonemapperType
		{
			[Token(Token = "0x40004EE")]
			SimpleReinhard,
			[Token(Token = "0x40004EF")]
			UserCurve,
			[Token(Token = "0x40004F0")]
			Hable,
			[Token(Token = "0x40004F1")]
			Photographic,
			[Token(Token = "0x40004F2")]
			OptimizedHejiDawson,
			[Token(Token = "0x40004F3")]
			AdaptiveReinhard,
			[Token(Token = "0x40004F4")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x200019A")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x40004F6")]
			Square16 = 0x10,
			[Token(Token = "0x40004F7")]
			Square32 = 0x20,
			[Token(Token = "0x40004F8")]
			Square64 = 0x40,
			[Token(Token = "0x40004F9")]
			Square128 = 0x80,
			[Token(Token = "0x40004FA")]
			Square256 = 0x100,
			[Token(Token = "0x40004FB")]
			Square512 = 0x200,
			[Token(Token = "0x40004FC")]
			Square1024 = 0x400
		}

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1CA5628", Offset = "0x1CA5628", VA = "0x1CA5628", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1CA5764", Offset = "0x1CA5764", VA = "0x1CA5764")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1CA5A0C", Offset = "0x1CA5A0C", VA = "0x1CA5A0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1CA5B64", Offset = "0x1CA5B64", VA = "0x1CA5B64")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1CA5C54", Offset = "0x1CA5C54", VA = "0x1CA5C54")]
		[AttributeAttribute(Name = "ImageEffectTransformsToLDR", RVA = "0x9FDE84", Offset = "0x9FDE84")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1CA6460", Offset = "0x1CA6460", VA = "0x1CA6460")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200008E")]
	internal class Triangles
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1CA648C", Offset = "0x1CA648C", VA = "0x1CA648C")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1CA65C8", Offset = "0x1CA65C8", VA = "0x1CA65C8")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1CA6798", Offset = "0x1CA6798", VA = "0x1CA6798")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1CA6A58", Offset = "0x1CA6A58", VA = "0x1CA6A58")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1CA6E88", Offset = "0x1CA6E88", VA = "0x1CA6E88")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7C70", Offset = "0x9F7C70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7C70", Offset = "0x9F7C70")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FCC1C", Offset = "0x9FCC1C")]
		public float angle;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1CA6E94", Offset = "0x1CA6E94", VA = "0x1CA6E94")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1CA6ED8", Offset = "0x1CA6ED8", VA = "0x1CA6ED8")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7CBC", Offset = "0x9F7CBC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7CBC", Offset = "0x9F7CBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7CBC", Offset = "0x9F7CBC")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200019B")]
		public enum AberrationMode
		{
			[Token(Token = "0x40004FE")]
			Simple,
			[Token(Token = "0x40004FF")]
			Advanced
		}

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1CA6F54", Offset = "0x1CA6F54", VA = "0x1CA6F54", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1CA6FD8", Offset = "0x1CA6FD8", VA = "0x1CA6FD8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1CA7604", Offset = "0x1CA7604", VA = "0x1CA7604")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x9F7D54", Offset = "0x9F7D54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F7D54", Offset = "0x9F7D54")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1CA7630", Offset = "0x1CA7630", VA = "0x1CA7630")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1CA7674", Offset = "0x1CA7674", VA = "0x1CA7674")]
		public Vortex()
		{
		}
	}
}
namespace FreakLib.Music
{
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F7DA0", Offset = "0x9F7DA0")]
	public class MusicPlayer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019C")]
		public class MusicPlayerEvent : UnityEvent<MusicPlayer>
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x124A290", Offset = "0x124A290", VA = "0x124A290")]
			public MusicPlayerEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC120", Offset = "0x9FC120")]
		private sealed class <>c
		{
			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Converter<Playlist, string> <>9__31_0;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<Track> <>9__57_0;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Track> <>9__57_1;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Comparison<Track> <>9__57_2;

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x124A1D4", Offset = "0x124A1D4", VA = "0x124A1D4")]
			public <>c()
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x124A1DC", Offset = "0x124A1DC", VA = "0x124A1DC")]
			internal string <get_PlaylistNames>b__31_0(Playlist p)
			{
				return null;
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x124A1F4", Offset = "0x124A1F4", VA = "0x124A1F4")]
			internal bool <Next>b__57_0(Track t)
			{
				return default(bool);
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x124A20C", Offset = "0x124A20C", VA = "0x124A20C")]
			internal int <Next>b__57_1(Track t1, Track t2)
			{
				return default(int);
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x124A21C", Offset = "0x124A21C", VA = "0x124A21C")]
			internal int <Next>b__57_2(Track t1, Track t2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200019E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC130", Offset = "0x9FC130")]
		private sealed class <>c__DisplayClass59_0
		{
			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x124A0C4", Offset = "0x124A0C4", VA = "0x124A0C4")]
			public <>c__DisplayClass59_0()
			{
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x124A25C", Offset = "0x124A25C", VA = "0x124A25C")]
			internal bool <GetPlaylist>b__0(Playlist p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int startingTrack;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<Playlist> m_Playlists;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_PlayOnAwake;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_Volume;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_HistoryLength;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MusicPlayerEvent OnPlay;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MusicPlayerEvent OnStop;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MusicPlayerEvent OnPause;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MusicPlayerEvent OnUnpause;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MusicPlayerEvent OnTrackChange;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MusicPlayerEvent OnPlaylistChange;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Playlist m_CurrentPlaylist;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int m_CurrentTrackIdx;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool m_IsPlaying;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		private bool m_IsPaused;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private LinkedList<int> m_History;

		[Token(Token = "0x17000039")]
		public bool PlayOnAwake
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1248DDC", Offset = "0x1248DDC", VA = "0x1248DDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x1248DE4", Offset = "0x1248DE4", VA = "0x1248DE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float Volume
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x1248DF0", Offset = "0x1248DF0", VA = "0x1248DF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x1248DF8", Offset = "0x1248DF8", VA = "0x1248DF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int HistoryLength
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x1248E00", Offset = "0x1248E00", VA = "0x1248E00")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x1248E08", Offset = "0x1248E08", VA = "0x1248E08")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public List<Playlist> Playlists
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x1248E10", Offset = "0x1248E10", VA = "0x1248E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1248E18", Offset = "0x1248E18", VA = "0x1248E18")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1248E20", Offset = "0x1248E20", VA = "0x1248E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public Playlist CurrentPlaylist
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x1248F18", Offset = "0x1248F18", VA = "0x1248F18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public string CurrentPlaylistName
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x1248F20", Offset = "0x1248F20", VA = "0x1248F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public Track CurrentTrack
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1248F3C", Offset = "0x1248F3C", VA = "0x1248F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public string CurrentTrackName
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x1248FBC", Offset = "0x1248FBC", VA = "0x1248FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x1248FE0", Offset = "0x1248FE0", VA = "0x1248FE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public float Playtime
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x1248FE8", Offset = "0x1248FE8", VA = "0x1248FE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x1249004", Offset = "0x1249004", VA = "0x1249004")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public float PlaytimeNormalized
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x1249020", Offset = "0x1249020", VA = "0x1249020")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x1249114", Offset = "0x1249114", VA = "0x1249114")]
			set
			{
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x12491DC", Offset = "0x12491DC", VA = "0x12491DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1249310", Offset = "0x1249310", VA = "0x1249310")]
		private void Update()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x124929C", Offset = "0x124929C", VA = "0x124929C")]
		public void Play()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1249B08", Offset = "0x1249B08", VA = "0x1249B08")]
		public void Play(string name)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1249854", Offset = "0x1249854", VA = "0x1249854")]
		public void Play(Playlist playlist, int trackOverRide = -1)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1249E74", Offset = "0x1249E74", VA = "0x1249E74")]
		public void PauseOrResume()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1249F08", Offset = "0x1249F08", VA = "0x1249F08")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1249E84", Offset = "0x1249E84", VA = "0x1249E84")]
		public void UnPause()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1249DE4", Offset = "0x1249DE4", VA = "0x1249DE4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1249378", Offset = "0x1249378", VA = "0x1249378")]
		public void Next()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1249F88", Offset = "0x1249F88", VA = "0x1249F88")]
		public void Previous()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1249BC4", Offset = "0x1249BC4", VA = "0x1249BC4")]
		public Playlist GetPlaylist(string name)
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x124A0CC", Offset = "0x124A0CC", VA = "0x124A0CC")]
		public MusicPlayer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class Playlist
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Track> tracks;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shuffle;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool foldout;

		[Token(Token = "0x17000045")]
		public List<int> EnabledTrackIndices
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1249C88", Offset = "0x1249C88", VA = "0x1249C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x124A2E0", Offset = "0x124A2E0", VA = "0x124A2E0")]
		public Playlist()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x124A374", Offset = "0x124A374", VA = "0x124A374")]
		public Playlist(string aName)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x124A408", Offset = "0x124A408", VA = "0x124A408")]
		public Playlist(string aName, List<Track> theTracks, bool shouldShuffle = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class Track
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool enabled;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool foldout;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCC78", Offset = "0x9FCC78")]
		private int <Plays>k__BackingField;

		[Token(Token = "0x17000046")]
		public float Length
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x124907C", Offset = "0x124907C", VA = "0x124907C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000047")]
		public int Plays
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x124A4B4", Offset = "0x124A4B4", VA = "0x124A4B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FDE94", Offset = "0x9FDE94")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x124A4BC", Offset = "0x124A4BC", VA = "0x124A4BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FDEA4", Offset = "0x9FDEA4")]
			set
			{
			}
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x124A4C4", Offset = "0x124A4C4", VA = "0x124A4C4")]
		public Track()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x124A538", Offset = "0x124A538", VA = "0x124A538")]
		public Track(AudioClip aClip, string aName = "")
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x124A5B0", Offset = "0x124A5B0", VA = "0x124A5B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace ES3Types
{
	[Token(Token = "0x2000095")]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x14792D8", Offset = "0x14792D8", VA = "0x14792D8")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1479388", Offset = "0x1479388", VA = "0x1479388", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000586")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000096")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1479390", Offset = "0x1479390", VA = "0x1479390")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1479440", Offset = "0x1479440", VA = "0x1479440", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600058A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000097")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x146BF9C", Offset = "0x146BF9C", VA = "0x146BF9C")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x146F9C0", Offset = "0x146F9C0", VA = "0x146F9C0", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x600058E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x146FC14", Offset = "0x146FC14", VA = "0x146FC14", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x146BFA0", Offset = "0x146BFA0", VA = "0x146BFA0")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x146FE48", Offset = "0x146FE48", VA = "0x146FE48", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000592")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1470144", Offset = "0x1470144", VA = "0x1470144", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000099")]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x146BF98", Offset = "0x146BF98", VA = "0x146BF98")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1470454", Offset = "0x1470454", VA = "0x1470454")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x14704B4", Offset = "0x14704B4", VA = "0x14704B4", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000597")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1470660", Offset = "0x1470660", VA = "0x1470660", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x14708B4", Offset = "0x14708B4", VA = "0x14708B4", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Type elementType;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x600059B")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x146F8D8", Offset = "0x146F8D8", VA = "0x146F8D8")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1470484", Offset = "0x1470484", VA = "0x1470484")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1470E54", Offset = "0x1470E54", VA = "0x1470E54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600059F")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1470E64", Offset = "0x1470E64", VA = "0x1470E64", Slot = "10")]
		public virtual object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1471054", Offset = "0x1471054", VA = "0x1471054", Slot = "11")]
		public virtual void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Type keyType;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type valueType;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x146BFA8", Offset = "0x146BFA8", VA = "0x146BFA8")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x147190C", Offset = "0x147190C", VA = "0x147190C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1471930", Offset = "0x1471930", VA = "0x1471930")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005A6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005A8")]
		public Dictionary<TKey, TVal> ReadKVP<TKey, TVal>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		public void ReadKVP<TKey, TVal>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1471D58", Offset = "0x1471D58", VA = "0x1471D58")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1471F90", Offset = "0x1471F90", VA = "0x1471F90")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x146C0C0", Offset = "0x146C0C0", VA = "0x146C0C0")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x14722B0", Offset = "0x14722B0", VA = "0x14722B0", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005AE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x146BFA4", Offset = "0x146BFA4", VA = "0x146BFA4")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1472884", Offset = "0x1472884", VA = "0x1472884", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005B2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1472C68", Offset = "0x1472C68", VA = "0x1472C68", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1472E40", Offset = "0x1472E40", VA = "0x1472E40", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x146C0B8", Offset = "0x146C0B8", VA = "0x146C0B8")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x14734B0", Offset = "0x14734B0", VA = "0x14734B0", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005B8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1473884", Offset = "0x1473884", VA = "0x1473884", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1473B44", Offset = "0x1473B44", VA = "0x1473B44", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x146C0BC", Offset = "0x146C0BC", VA = "0x146C0BC")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x14748E8", Offset = "0x14748E8", VA = "0x14748E8", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60005BE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1474CBC", Offset = "0x1474CBC", VA = "0x1474CBC", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1474F7C", Offset = "0x1474F7C", VA = "0x1474F7C", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public abstract class ES3ComponentType : ES3ObjectType
	{
		[Token(Token = "0x40002E0")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x14712B8", Offset = "0x14712B8", VA = "0x14712B8")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x60005C3")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x60005C4")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x14712C0", Offset = "0x14712C0", VA = "0x14712C0", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005C6")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005C7")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1471550", Offset = "0x1471550", VA = "0x1471550")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x147177C", Offset = "0x147177C", VA = "0x147177C")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x14716BC", Offset = "0x14716BC", VA = "0x14716BC")]
		public static Component GetOrCreateComponentIfNotExists(GameObject go, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A1")]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x14712BC", Offset = "0x14712BC", VA = "0x14712BC")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x60005CC")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x60005CD")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x60005CE")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1473324", Offset = "0x1473324", VA = "0x1473324", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005D0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public abstract class ES3ScriptableObjectType : ES3ObjectType
	{
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1474168", Offset = "0x1474168", VA = "0x1474168")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60005D3")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x60005D4")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1474720", Offset = "0x1474720", VA = "0x1474720", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005D6")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005D7")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9F7E04", Offset = "0x9F7E04")]
	public abstract class ES3Type
	{
		[Token(Token = "0x40002E1")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isReflectedType;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUnsupported;

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1470D98", Offset = "0x1470D98", VA = "0x1470D98")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x60005D9")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x60005DA")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x60005DB")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x147337C", Offset = "0x147337C", VA = "0x147337C")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DD")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1475448", Offset = "0x1475448", VA = "0x1475448")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1474020", Offset = "0x1474020", VA = "0x1474020")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1475480", Offset = "0x1475480", VA = "0x1475480")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1474010", Offset = "0x1474010", VA = "0x1474010")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x14741D0", Offset = "0x14741D0", VA = "0x14741D0")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9F7E18", Offset = "0x9F7E18")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1473484", Offset = "0x1473484", VA = "0x1473484")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1238CC0", Offset = "0x1238CC0", VA = "0x1238CC0")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60005E5")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x60005E6")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60005E7")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1246964", Offset = "0x1246964", VA = "0x1246964", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1246978", Offset = "0x1246978", VA = "0x1246978", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x60005EA")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60005EB")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A6")]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x147902C", Offset = "0x147902C", VA = "0x147902C")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x14790DC", Offset = "0x14790DC", VA = "0x14790DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005EE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A7")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x14791F8", Offset = "0x14791F8", VA = "0x14791F8")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1243570", Offset = "0x1243570", VA = "0x1243570")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x124362C", Offset = "0x124362C", VA = "0x124362C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005F3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x12436C8", Offset = "0x12436C8", VA = "0x12436C8")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x12449FC", Offset = "0x12449FC", VA = "0x12449FC")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1244AB8", Offset = "0x1244AB8", VA = "0x1244AB8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005F8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AB")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1244B54", Offset = "0x1244B54", VA = "0x1244B54")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1244C2C", Offset = "0x1244C2C", VA = "0x1244C2C")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1244CE8", Offset = "0x1244CE8", VA = "0x1244CE8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60005FD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AD")]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1244D84", Offset = "0x1244D84", VA = "0x1244D84")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1244E40", Offset = "0x1244E40", VA = "0x1244E40", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000601")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AE")]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1244EDC", Offset = "0x1244EDC", VA = "0x1244EDC")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1244F98", Offset = "0x1244F98", VA = "0x1244F98", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000605")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1245034", Offset = "0x1245034", VA = "0x1245034")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x124510C", Offset = "0x124510C", VA = "0x124510C")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x12451C8", Offset = "0x12451C8", VA = "0x12451C8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600060A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B1")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1245264", Offset = "0x1245264", VA = "0x1245264")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x124533C", Offset = "0x124533C", VA = "0x124533C")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x12453F8", Offset = "0x12453F8", VA = "0x12453F8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600060F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B3")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1245494", Offset = "0x1245494", VA = "0x1245494")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x124556C", Offset = "0x124556C", VA = "0x124556C")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x12455FC", Offset = "0x12455FC", VA = "0x12455FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000614")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1245698", Offset = "0x1245698", VA = "0x1245698")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1245754", Offset = "0x1245754", VA = "0x1245754", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000618")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B6")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x12457F0", Offset = "0x12457F0", VA = "0x12457F0")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x12458C8", Offset = "0x12458C8", VA = "0x12458C8")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1245984", Offset = "0x1245984", VA = "0x1245984", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600061D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B8")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1245A20", Offset = "0x1245A20", VA = "0x1245A20")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x147BB98", Offset = "0x147BB98", VA = "0x147BB98")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x147BC50", Offset = "0x147BC50", VA = "0x147BC50", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000622")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BA")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x147BCF8", Offset = "0x147BCF8", VA = "0x147BCF8")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1245AF8", Offset = "0x1245AF8", VA = "0x1245AF8")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1245BB4", Offset = "0x1245BB4", VA = "0x1245BB4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000627")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BC")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1245C50", Offset = "0x1245C50", VA = "0x1245C50")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1245D28", Offset = "0x1245D28", VA = "0x1245D28")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1245DE4", Offset = "0x1245DE4", VA = "0x1245DE4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600062C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BE")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1245E80", Offset = "0x1245E80", VA = "0x1245E80")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1245F58", Offset = "0x1245F58", VA = "0x1245F58")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1246014", Offset = "0x1246014", VA = "0x1246014", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000631")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C0")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x12460B0", Offset = "0x12460B0", VA = "0x12460B0")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1246188", Offset = "0x1246188", VA = "0x1246188")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1246244", Offset = "0x1246244", VA = "0x1246244", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000636")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C2")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1240F00", Offset = "0x1240F00", VA = "0x1240F00")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x12462D4", Offset = "0x12462D4", VA = "0x12462D4")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1246390", Offset = "0x1246390", VA = "0x1246390", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600063B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C4")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x124642C", Offset = "0x124642C", VA = "0x124642C")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1246504", Offset = "0x1246504", VA = "0x1246504")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x12465C0", Offset = "0x12465C0", VA = "0x12465C0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000640")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C6")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x124665C", Offset = "0x124665C", VA = "0x124665C")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1246734", Offset = "0x1246734", VA = "0x1246734")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x12467F0", Offset = "0x12467F0", VA = "0x12467F0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000645")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C8")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x124688C", Offset = "0x124688C", VA = "0x124688C")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x146C0C4", Offset = "0x146C0C4", VA = "0x146C0C4")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x147401C", Offset = "0x147401C", VA = "0x147401C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600064A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x146C160", Offset = "0x146C160", VA = "0x146C160")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1474164", Offset = "0x1474164", VA = "0x1474164", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600064D")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x146C12C", Offset = "0x146C12C", VA = "0x146C12C")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x147416C", Offset = "0x147416C", VA = "0x147416C", Slot = "10")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000651")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1474170", Offset = "0x1474170", VA = "0x1474170")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1474198", Offset = "0x1474198", VA = "0x1474198")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x147435C", Offset = "0x147435C", VA = "0x147435C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000655")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000656")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x14746E0", Offset = "0x14746E0", VA = "0x14746E0")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1474718", Offset = "0x1474718", VA = "0x1474718", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000659")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x146C0F8", Offset = "0x146C0F8", VA = "0x146C0F8")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x147471C", Offset = "0x147471C", VA = "0x147471C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600065D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F7E2C", Offset = "0x9F7E2C")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x14767DC", Offset = "0x14767DC", VA = "0x14767DC")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x147688C", Offset = "0x147688C", VA = "0x147688C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000661")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F7EF4", Offset = "0x9F7EF4")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1476AC4", Offset = "0x1476AC4", VA = "0x1476AC4")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1476B74", Offset = "0x1476B74", VA = "0x1476B74", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000665")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F7FCC", Offset = "0x9F7FCC")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1476E34", Offset = "0x1476E34", VA = "0x1476E34")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1476EE4", Offset = "0x1476EE4", VA = "0x1476EE4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000669")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8244", Offset = "0x9F8244")]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x14778F4", Offset = "0x14778F4", VA = "0x14778F4")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x14779A4", Offset = "0x14779A4", VA = "0x14779A4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600066D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1479908", Offset = "0x1479908", VA = "0x1479908")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x14799B8", Offset = "0x14799B8", VA = "0x14799B8", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000671")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F832C", Offset = "0x9F832C")]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x12391F4", Offset = "0x12391F4", VA = "0x12391F4")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x12392A8", Offset = "0x12392A8", VA = "0x12392A8", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000675")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1239600", Offset = "0x1239600", VA = "0x1239600")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8414", Offset = "0x9F8414")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x12396D8", Offset = "0x12396D8", VA = "0x12396D8")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x123978C", Offset = "0x123978C", VA = "0x123978C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600067A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1239864", Offset = "0x1239864", VA = "0x1239864")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F848C", Offset = "0x9F848C")]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x123993C", Offset = "0x123993C", VA = "0x123993C")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x12399F0", Offset = "0x12399F0", VA = "0x12399F0", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600067F")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x123A08C", Offset = "0x123A08C", VA = "0x123A08C")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8604", Offset = "0x9F8604")]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x123B3CC", Offset = "0x123B3CC", VA = "0x123B3CC")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x123B480", Offset = "0x123B480", VA = "0x123B480", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000684")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F881C", Offset = "0x9F881C")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x123C3B0", Offset = "0x123C3B0", VA = "0x123C3B0")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x123C464", Offset = "0x123C464", VA = "0x123C464", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000688")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x123C90C", Offset = "0x123C90C", VA = "0x123C90C")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8914", Offset = "0x9F8914")]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x123FE8C", Offset = "0x123FE8C", VA = "0x123FE8C")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x123FF40", Offset = "0x123FF40", VA = "0x123FF40", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600068D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F89DC", Offset = "0x9F89DC")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x12412F8", Offset = "0x12412F8", VA = "0x12412F8")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x12413AC", Offset = "0x12413AC", VA = "0x12413AC", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000691")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8BC4", Offset = "0x9F8BC4")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1242FB0", Offset = "0x1242FB0", VA = "0x1242FB0")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1243064", Offset = "0x1243064", VA = "0x1243064", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000695")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8C6C", Offset = "0x9F8C6C")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1475A30", Offset = "0x1475A30", VA = "0x1475A30")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1475AE0", Offset = "0x1475AE0", VA = "0x1475AE0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000699")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600069A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8D04", Offset = "0x9F8D04")]
	public class ES3Type_AudioClip : ES3ObjectType
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1475C4C", Offset = "0x1475C4C", VA = "0x1475C4C")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1475CFC", Offset = "0x1475CFC", VA = "0x1475CFC", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600069E")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E2")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1475EF4", Offset = "0x1475EF4", VA = "0x1475EF4")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8DBC", Offset = "0x9F8DBC")]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1475FD4", Offset = "0x1475FD4", VA = "0x1475FD4")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1476084", Offset = "0x1476084", VA = "0x1476084", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006A3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E4")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x14763F4", Offset = "0x14763F4", VA = "0x14763F4")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8EA4", Offset = "0x9F8EA4")]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x14764D4", Offset = "0x14764D4", VA = "0x14764D4")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1476584", Offset = "0x1476584", VA = "0x1476584", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006A8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E6")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x14766FC", Offset = "0x14766FC", VA = "0x14766FC")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F8F2C", Offset = "0x9F8F2C")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1477D68", Offset = "0x1477D68", VA = "0x1477D68")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1477E18", Offset = "0x1477E18", VA = "0x1477E18", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006AD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006AE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F90B4", Offset = "0x9F90B4")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x14783D4", Offset = "0x14783D4", VA = "0x14783D4")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1478484", Offset = "0x1478484", VA = "0x1478484", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006B2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E9")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1478A08", Offset = "0x1478A08", VA = "0x1478A08")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F915C", Offset = "0x9F915C")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x147865C", Offset = "0x147865C", VA = "0x147865C")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x147870C", Offset = "0x147870C", VA = "0x147870C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006B7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x14788E0", Offset = "0x14788E0", VA = "0x14788E0")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EB")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1478928", Offset = "0x1478928", VA = "0x1478928")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9204", Offset = "0x9F9204")]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1478AE8", Offset = "0x1478AE8", VA = "0x1478AE8")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1478B98", Offset = "0x1478B98", VA = "0x1478B98", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006BD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F929C", Offset = "0x9F929C")]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1478DC8", Offset = "0x1478DC8", VA = "0x1478DC8")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1478E78", Offset = "0x1478E78", VA = "0x1478E78", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006C2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9324", Offset = "0x9F9324")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1479584", Offset = "0x1479584", VA = "0x1479584")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1479634", Offset = "0x1479634", VA = "0x1479634", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006C7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F93DC", Offset = "0x9F93DC")]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x14799C0", Offset = "0x14799C0", VA = "0x14799C0")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1479A70", Offset = "0x1479A70", VA = "0x1479A70", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006CC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9464", Offset = "0x9F9464")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1479C0C", Offset = "0x1479C0C", VA = "0x1479C0C")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1479CBC", Offset = "0x1479CBC", VA = "0x1479CBC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006D1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1479D80", Offset = "0x1479D80", VA = "0x1479D80")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F94DC", Offset = "0x9F94DC")]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1479E60", Offset = "0x1479E60", VA = "0x1479E60")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1479F14", Offset = "0x1479F14", VA = "0x1479F14", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006D7")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60006D8")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F3")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x147A018", Offset = "0x147A018", VA = "0x147A018")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9564", Offset = "0x9F9564")]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x147A0F8", Offset = "0x147A0F8", VA = "0x147A0F8")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x147A1A8", Offset = "0x147A1A8", VA = "0x147A1A8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006DD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F965C", Offset = "0x9F965C")]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x4000335")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x4000336")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x147A5C0", Offset = "0x147A5C0", VA = "0x147A5C0")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x147A674", Offset = "0x147A674", VA = "0x147A674", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x60006E2")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x147AF00", Offset = "0x147AF00", VA = "0x147AF00")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x147ABE0", Offset = "0x147ABE0", VA = "0x147ABE0")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x147AF98", Offset = "0x147AF98", VA = "0x147AF98", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006E7")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60006E8")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F6")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x147AFA0", Offset = "0x147AFA0", VA = "0x147AFA0")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9734", Offset = "0x9F9734")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x147B080", Offset = "0x147B080", VA = "0x147B080")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x147B130", Offset = "0x147B130", VA = "0x147B130", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006ED")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F97CC", Offset = "0x9F97CC")]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x147B29C", Offset = "0x147B29C", VA = "0x147B29C")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x147B34C", Offset = "0x147B34C", VA = "0x147B34C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006F2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x147B490", Offset = "0x147B490", VA = "0x147B490")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9854", Offset = "0x9F9854")]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x147B570", Offset = "0x147B570", VA = "0x147B570")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x147B620", Offset = "0x147B620", VA = "0x147B620", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006F8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x147B798", Offset = "0x147B798", VA = "0x147B798")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F98DC", Offset = "0x9F98DC")]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x147B878", Offset = "0x147B878", VA = "0x147B878")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x147B928", Offset = "0x147B928", VA = "0x147B928", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60006FE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60006FF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9984", Offset = "0x9F9984")]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x147BDD8", Offset = "0x147BDD8", VA = "0x147BDD8")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x147BE88", Offset = "0x147BE88", VA = "0x147BE88", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000703")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FE")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x147C094", Offset = "0x147C094", VA = "0x147C094")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9A2C", Offset = "0x9F9A2C")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x147C174", Offset = "0x147C174", VA = "0x147C174")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x147C224", Offset = "0x147C224", VA = "0x147C224", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000708")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9AC4", Offset = "0x9F9AC4")]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x147C338", Offset = "0x147C338", VA = "0x147C338")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x147C3E8", Offset = "0x147C3E8", VA = "0x147C3E8", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600070C")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9C8C", Offset = "0x9F9C8C")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x147CB4C", Offset = "0x147CB4C", VA = "0x147CB4C")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x147CBFC", Offset = "0x147CBFC", VA = "0x147CBFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000710")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000711")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9DB4", Offset = "0x9F9DB4")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x147D118", Offset = "0x147D118", VA = "0x147D118")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x147D1C8", Offset = "0x147D1C8", VA = "0x147D1C8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000715")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9F9EDC", Offset = "0x9F9EDC")]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x147D6D4", Offset = "0x147D6D4", VA = "0x147D6D4")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x147D784", Offset = "0x147D784", VA = "0x147D784", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600071A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA194", Offset = "0x9FA194")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x147E51C", Offset = "0x147E51C", VA = "0x147E51C")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x147E5D0", Offset = "0x147E5D0", VA = "0x147E5D0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600071F")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x123876C", Offset = "0x123876C", VA = "0x123876C")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA24C", Offset = "0x9FA24C")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1238844", Offset = "0x1238844", VA = "0x1238844")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x12388F8", Offset = "0x12388F8", VA = "0x12388F8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000725")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000107")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1238B28", Offset = "0x1238B28", VA = "0x1238B28")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA2F4", Offset = "0x9FA2F4")]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1238C00", Offset = "0x1238C00", VA = "0x1238C00")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1238CF0", Offset = "0x1238CF0", VA = "0x1238CF0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600072A")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600072B")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA43C", Offset = "0x9FA43C")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x123A164", Offset = "0x123A164", VA = "0x123A164")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x123A218", Offset = "0x123A218", VA = "0x123A218", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600072F")]
		[AttributeAttribute(Name = "PreserveAttribute", RVA = "0x9FDEB4", Offset = "0x9FDEB4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000730")]
		[AttributeAttribute(Name = "PreserveAttribute", RVA = "0x9FDEC4", Offset = "0x9FDEC4")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA524", Offset = "0x9FA524")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x123A548", Offset = "0x123A548", VA = "0x123A548")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x123A5FC", Offset = "0x123A5FC", VA = "0x123A5FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000734")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA5FC", Offset = "0x9FA5FC")]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x123A908", Offset = "0x123A908", VA = "0x123A908")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x123A9BC", Offset = "0x123A9BC", VA = "0x123A9BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000738")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA814", Offset = "0x9FA814")]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x123BD00", Offset = "0x123BD00", VA = "0x123BD00")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x123BDB4", Offset = "0x123BDB4", VA = "0x123BDB4", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600073D")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600073E")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010D")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x123C000", Offset = "0x123C000", VA = "0x123C000")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA8CC", Offset = "0x9FA8CC")]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x123C0D8", Offset = "0x123C0D8", VA = "0x123C0D8")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x123C18C", Offset = "0x123C18C", VA = "0x123C18C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000743")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000744")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010F")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x123C2D8", Offset = "0x123C2D8", VA = "0x123C2D8")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA954", Offset = "0x9FA954")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x123C9E4", Offset = "0x123C9E4", VA = "0x123C9E4")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x123CA98", Offset = "0x123CA98", VA = "0x123CA98", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000749")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000111")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x123CC70", Offset = "0x123CC70", VA = "0x123CC70")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FA9FC", Offset = "0x9FA9FC")]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x123CD48", Offset = "0x123CD48", VA = "0x123CD48")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x123CDFC", Offset = "0x123CDFC", VA = "0x123CDFC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600074E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FAAA4", Offset = "0x9FAAA4")]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x123CFF8", Offset = "0x123CFF8", VA = "0x123CFF8")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x123D0AC", Offset = "0x123D0AC", VA = "0x123D0AC", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000752")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FABCC", Offset = "0x9FABCC")]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x123D580", Offset = "0x123D580", VA = "0x123D580")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x123D634", Offset = "0x123D634", VA = "0x123D634", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000756")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FACC4", Offset = "0x9FACC4")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x123DA84", Offset = "0x123DA84", VA = "0x123DA84")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x123DB38", Offset = "0x123DB38", VA = "0x123DB38", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600075B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FADAC", Offset = "0x9FADAC")]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x123DF10", Offset = "0x123DF10", VA = "0x123DF10")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x123DFC4", Offset = "0x123DFC4", VA = "0x123DFC4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000760")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x123E12C", Offset = "0x123E12C", VA = "0x123E12C")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FAE34", Offset = "0x9FAE34")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x123E204", Offset = "0x123E204", VA = "0x123E204")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x123E2B8", Offset = "0x123E2B8", VA = "0x123E2B8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000766")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FAFCC", Offset = "0x9FAFCC")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x123EA2C", Offset = "0x123EA2C", VA = "0x123EA2C")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x123EAE0", Offset = "0x123EAE0", VA = "0x123EAE0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600076B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600076C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB0E4", Offset = "0x9FB0E4")]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x123EFD0", Offset = "0x123EFD0", VA = "0x123EFD0")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x123F084", Offset = "0x123F084", VA = "0x123F084", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000770")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB1EC", Offset = "0x9FB1EC")]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x123F500", Offset = "0x123F500", VA = "0x123F500")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x123F5B4", Offset = "0x123F5B4", VA = "0x123F5B4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000775")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x123FDB4", Offset = "0x123FDB4", VA = "0x123FDB4")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB3C4", Offset = "0x9FB3C4")]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1240234", Offset = "0x1240234", VA = "0x1240234")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x12402F4", Offset = "0x12402F4", VA = "0x12402F4", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600077A")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600077B")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB47C", Offset = "0x9FB47C")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x12405DC", Offset = "0x12405DC", VA = "0x12405DC")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1240690", Offset = "0x1240690", VA = "0x1240690", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600077F")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1240E28", Offset = "0x1240E28", VA = "0x1240E28")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB624", Offset = "0x9FB624")]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1240FD8", Offset = "0x1240FD8", VA = "0x1240FD8")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x124108C", Offset = "0x124108C", VA = "0x124108C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000784")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000785")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB6BC", Offset = "0x9FB6BC")]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x12419BC", Offset = "0x12419BC", VA = "0x12419BC")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1241A70", Offset = "0x1241A70", VA = "0x1241A70", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000789")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600078A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000122")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1242140", Offset = "0x1242140", VA = "0x1242140")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB774", Offset = "0x9FB774")]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1241BE0", Offset = "0x1241BE0", VA = "0x1241BE0")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1241CA0", Offset = "0x1241CA0", VA = "0x1241CA0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600078F")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000790")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000124")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1242068", Offset = "0x1242068", VA = "0x1242068")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB82C", Offset = "0x9FB82C")]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1242218", Offset = "0x1242218", VA = "0x1242218")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x12422CC", Offset = "0x12422CC", VA = "0x12422CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000795")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000796")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FB974", Offset = "0x9FB974")]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x12428A0", Offset = "0x12428A0", VA = "0x12428A0")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1242954", Offset = "0x1242954", VA = "0x1242954", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600079A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FBACC", Offset = "0x9FBACC")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1243208", Offset = "0x1243208", VA = "0x1243208")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x12432BC", Offset = "0x12432BC", VA = "0x12432BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600079F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FBB94", Offset = "0x9FBB94")]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x12437A0", Offset = "0x12437A0", VA = "0x12437A0")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1243854", Offset = "0x1243854", VA = "0x1243854", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007A4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000129")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1243998", Offset = "0x1243998", VA = "0x1243998")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FBC1C", Offset = "0x9FBC1C")]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1243A70", Offset = "0x1243A70", VA = "0x1243A70")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1243B24", Offset = "0x1243B24", VA = "0x1243B24", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007A9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200012B")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1243CB4", Offset = "0x1243CB4", VA = "0x1243CB4")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FBCB4", Offset = "0x9FBCB4")]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1243D8C", Offset = "0x1243D8C", VA = "0x1243D8C")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1243E40", Offset = "0x1243E40", VA = "0x1243E40", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007AE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200012D")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1244008", Offset = "0x1244008", VA = "0x1244008")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FBD4C", Offset = "0x9FBD4C")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x12440E0", Offset = "0x12440E0", VA = "0x12440E0")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1244194", Offset = "0x1244194", VA = "0x1244194", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007B3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1244368", Offset = "0x1244368", VA = "0x1244368")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012F")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x12444B8", Offset = "0x12444B8", VA = "0x12444B8")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9FBDF4", Offset = "0x9FBDF4")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1244590", Offset = "0x1244590", VA = "0x1244590")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1244644", Offset = "0x1244644", VA = "0x1244644", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007B9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x2000131")]
	public static class ES3Hash
	{
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x108C5C0", Offset = "0x108C5C0", VA = "0x108C5C0")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000132")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x60007BD")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x60007BE")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x146D310", Offset = "0x146D310", VA = "0x146D310")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x146D3F8", Offset = "0x146D3F8", VA = "0x146D3F8")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x4000373")]
		private const int ivSize = 16;

		[Token(Token = "0x4000374")]
		private const int keySize = 16;

		[Token(Token = "0x4000375")]
		private const int pwIterations = 100;

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x108BAD4", Offset = "0x108BAD4", VA = "0x108BAD4", Slot = "4")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x108BED0", Offset = "0x108BED0", VA = "0x108BED0", Slot = "5")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x108C2A0", Offset = "0x108C2A0", VA = "0x108C2A0")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x146B354", Offset = "0x146B354", VA = "0x146B354")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x146D400", Offset = "0x146D400", VA = "0x146D400", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000135")]
	public struct ES3Data
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xAE8F9C", Offset = "0xAE8F9C", VA = "0xAE8F9C")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xAE8FA4", Offset = "0xAE8FA4", VA = "0xAE8FA4")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x2000136")]
	public static class ES3IO
	{
		[Token(Token = "0x200019F")]
		public enum ES3FileMode
		{
			[Token(Token = "0x4000507")]
			Read,
			[Token(Token = "0x4000508")]
			Write,
			[Token(Token = "0x4000509")]
			Append
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x10858FC", Offset = "0x10858FC", VA = "0x10858FC")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x10825A0", Offset = "0x10825A0", VA = "0x10825A0")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x10832A4", Offset = "0x10832A4", VA = "0x10832A4")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x10835D8", Offset = "0x10835D8", VA = "0x10835D8")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x10838F4", Offset = "0x10838F4", VA = "0x10838F4")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x10835E0", Offset = "0x10835E0", VA = "0x10835E0")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x108C598", Offset = "0x108C598", VA = "0x108C598")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1084634", Offset = "0x1084634", VA = "0x1084634")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x108C530", Offset = "0x108C530", VA = "0x108C530")]
		public static string GetDirectoryName(string path)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x10850D0", Offset = "0x10850D0", VA = "0x10850D0")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1083B04", Offset = "0x1083B04", VA = "0x1083B04")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1084D84", Offset = "0x1084D84", VA = "0x1084D84")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x108C748", Offset = "0x108C748", VA = "0x108C748")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x108C750", Offset = "0x108C750", VA = "0x108C750")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x10819C0", Offset = "0x10819C0", VA = "0x10819C0")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x108FAC8", Offset = "0x108FAC8", VA = "0x108FAC8")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x108FE90", Offset = "0x108FE90", VA = "0x108FE90")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x108FF10", Offset = "0x108FF10", VA = "0x108FF10")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1090010", Offset = "0x1090010", VA = "0x1090010")]
		public Dictionary<long, long> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x10901CC", Offset = "0x10901CC", VA = "0x10901CC")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x108FFB4", Offset = "0x108FFB4", VA = "0x108FFB4")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x10905AC", Offset = "0x10905AC", VA = "0x10905AC")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0x9FBEDC", Offset = "0x9FBEDC")]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x400037F")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Random rng;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x9FCC88", Offset = "0x9FCC88")]
		public bool openReferences;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x9FCC98", Offset = "0x9FCC98")]
		public bool openPrefabs;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x17000048")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x108FC60", Offset = "0x108FC60", VA = "0x108FC60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public bool IsInitialised
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x10906EC", Offset = "0x10906EC", VA = "0x10906EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1090750", Offset = "0x1090750", VA = "0x1090750")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1090938", Offset = "0x1090938", VA = "0x1090938")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1090B24", Offset = "0x1090B24", VA = "0x1090B24")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1090BA4", Offset = "0x1090BA4", VA = "0x1090BA4")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1090C34", Offset = "0x1090C34", VA = "0x1090C34")]
		public ES3Prefab GetPrefab(long id)
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1090D0C", Offset = "0x1090D0C", VA = "0x1090D0C")]
		public long GetPrefab(ES3Prefab prefab)
		{
			return default(long);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x108FDDC", Offset = "0x108FDDC", VA = "0x108FDDC")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1090390", Offset = "0x1090390", VA = "0x1090390")]
		public void Add(UnityEngine.Object obj, long id)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1090E14", Offset = "0x1090E14", VA = "0x1090E14")]
		public void AddPrefab(ES3Prefab prefab)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1090EAC", Offset = "0x1090EAC", VA = "0x1090EAC")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1090F40", Offset = "0x1090F40", VA = "0x1090F40")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1090FD4", Offset = "0x1090FD4", VA = "0x1090FD4")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x109103C", Offset = "0x109103C", VA = "0x109103C")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1090430", Offset = "0x1090430", VA = "0x1090430")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x10910A4", Offset = "0x10910A4", VA = "0x10910A4")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000139")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x108C758", Offset = "0x108C758", VA = "0x108C758", Slot = "6")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x108C764", Offset = "0x108C764", VA = "0x108C764", Slot = "7")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x108C7DC", Offset = "0x108C7DC", VA = "0x108C7DC")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FBEEC", Offset = "0x9FBEEC")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1090668", Offset = "0x1090668", VA = "0x1090668", Slot = "6")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x10906E0", Offset = "0x10906E0", VA = "0x10906E0", Slot = "7")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1090618", Offset = "0x1090618", VA = "0x1090618")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public static class ES3Reflection
	{
		[Token(Token = "0x20001A0")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x17000084")]
			public bool IsNull
			{
				[Token(Token = "0x60009A7")]
				[Address(RVA = "0xAF032C", Offset = "0xAF032C", VA = "0xAF032C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000085")]
			public string Name
			{
				[Token(Token = "0x60009A8")]
				[Address(RVA = "0xAF0334", Offset = "0xAF0334", VA = "0xAF0334")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			public Type MemberType
			{
				[Token(Token = "0x60009A9")]
				[Address(RVA = "0xAF033C", Offset = "0xAF033C", VA = "0xAF033C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			public bool IsPublic
			{
				[Token(Token = "0x60009AA")]
				[Address(RVA = "0xAF0344", Offset = "0xAF0344", VA = "0xAF0344")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000088")]
			public bool IsProtected
			{
				[Token(Token = "0x60009AB")]
				[Address(RVA = "0xAF034C", Offset = "0xAF034C", VA = "0xAF034C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xAF0354", Offset = "0xAF0354", VA = "0xAF0354")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xAF035C", Offset = "0xAF035C", VA = "0xAF035C")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0xAF0364", Offset = "0xAF0364", VA = "0xAF0364")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x20001A1")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x146ABC8", Offset = "0x146ABC8", VA = "0x146ABC8")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x146AC44", Offset = "0x146AC44", VA = "0x146AC44")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x20001A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC140", Offset = "0x9FC140")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x146A778", Offset = "0x146A778", VA = "0x146A778")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x146A780", Offset = "0x146A780", VA = "0x146A780")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20001A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC150", Offset = "0x9FC150")]
		private sealed class <>c
		{
			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__24_0;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, <>f__AnonymousType0<Assembly, Type>> <>9__24_1;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType0<Assembly, Type>, Type> <>9__24_3;

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x146A684", Offset = "0x146A684", VA = "0x146A684")]
			public <>c()
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x146A68C", Offset = "0x146A68C", VA = "0x146A68C")]
			internal IEnumerable<Type> <GetDerivedTypes>b__24_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x146A6B0", Offset = "0x146A6B0", VA = "0x146A6B0")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__24_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x146A72C", Offset = "0x146A72C", VA = "0x146A72C")]
			internal Type <GetDerivedTypes>b__24_3(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x4000386")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x4000387")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x4000388")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x1700004A")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1091134", Offset = "0x1091134", VA = "0x1091134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x109141C", Offset = "0x109141C", VA = "0x109141C")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x10915E0", Offset = "0x10915E0", VA = "0x10915E0")]
		public static List<FieldInfo> GetSerializableFields(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1091CAC", Offset = "0x1091CAC", VA = "0x1091CAC")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1091978", Offset = "0x1091978", VA = "0x1091978")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1092378", Offset = "0x1092378", VA = "0x1092378")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x10924E8", Offset = "0x10924E8", VA = "0x10924E8")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x109266C", Offset = "0x109266C", VA = "0x109266C")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x10926F8", Offset = "0x10926F8", VA = "0x10926F8")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1092700", Offset = "0x1092700", VA = "0x1092700")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x10927C0", Offset = "0x10927C0", VA = "0x10927C0")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x10929C4", Offset = "0x10929C4", VA = "0x10929C4")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1092A80", Offset = "0x1092A80", VA = "0x1092A80")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x6000803")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1092B4C", Offset = "0x1092B4C", VA = "0x1092B4C")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1091958", Offset = "0x1091958", VA = "0x1091958")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1092E38", Offset = "0x1092E38", VA = "0x1092E38")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x10915A0", Offset = "0x10915A0", VA = "0x10915A0")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1092E58", Offset = "0x1092E58", VA = "0x1092E58")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1092E78", Offset = "0x1092E78", VA = "0x1092E78")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1092E98", Offset = "0x1092E98", VA = "0x1092E98")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x109226C", Offset = "0x109226C", VA = "0x109226C")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x10915C0", Offset = "0x10915C0", VA = "0x10915C0")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1092F24", Offset = "0x1092F24", VA = "0x1092F24")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1091580", Offset = "0x1091580", VA = "0x1091580")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1092254", Offset = "0x1092254", VA = "0x1092254")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1092F3C", Offset = "0x1092F3C", VA = "0x1092F3C")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1092284", Offset = "0x1092284", VA = "0x1092284")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1092F5C", Offset = "0x1092F5C", VA = "0x1092F5C")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1092FD8", Offset = "0x1092FD8", VA = "0x1092FD8")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1092A64", Offset = "0x1092A64", VA = "0x1092A64")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1092B28", Offset = "0x1092B28", VA = "0x1092B28")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1092158", Offset = "0x1092158", VA = "0x1092158")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x109194C", Offset = "0x109194C", VA = "0x109194C")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x109307C", Offset = "0x109307C", VA = "0x109307C")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x10930A0", Offset = "0x10930A0", VA = "0x10930A0")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9FBF00", Offset = "0x9FBF00")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : IEnumerable, IEnumerable<KeyValuePair<TKey, TVal>>
	{
		[Token(Token = "0x20001A4")]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ES3SerializableDictionary<TKey, TVal> _Dictionary;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _Index;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TVal> _Current;

			[Token(Token = "0x17000089")]
			public KeyValuePair<TKey, TVal> Current
			{
				[Token(Token = "0x60009B8")]
				get
				{
					return default(KeyValuePair<TKey, TVal>);
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B9")]
			public Enumerator(ES3SerializableDictionary<TKey, TVal> dictionary)
			{
			}

			[Token(Token = "0x60009BA")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009BB")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60009BD")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x1700004B")]
		public List<TKey> Keys
		{
			[Token(Token = "0x600081D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public List<TVal> Values
		{
			[Token(Token = "0x600081E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public int Count
		{
			[Token(Token = "0x600081F")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004E")]
		public TVal Item
		{
			[Token(Token = "0x6000821")]
			get
			{
				return (TVal)null;
			}
			[Token(Token = "0x6000822")]
			set
			{
			}
		}

		[Token(Token = "0x600081B")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x600081C")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x6000820")]
		public void Add(TKey key, TVal value)
		{
		}

		[Token(Token = "0x6000823")]
		public bool TryGetValue(TKey key, out TVal val)
		{
			return default(bool);
		}

		[Token(Token = "0x6000824")]
		public bool TryGetKey(TVal value, out TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000825")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000826")]
		public bool ContainsValue(TVal value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000827")]
		public void Remove(TKey key)
		{
		}

		[Token(Token = "0x6000828")]
		public int RemoveNullKeys()
		{
			return default(int);
		}

		[Token(Token = "0x6000829")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x600082A")]
		public bool ChangeKey(TKey oldId, TKey newId)
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		private int FindKeyIndex(TKey key)
		{
			return default(int);
		}

		[Token(Token = "0x600082C")]
		private int FindValueIndex(TVal value)
		{
			return default(int);
		}

		[Token(Token = "0x600082D")]
		private void Insert(TKey key, TVal value)
		{
		}

		[Token(Token = "0x600082E")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x600082F")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000830")]
		private IEnumerator<KeyValuePair<TKey, TVal>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TVal>>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x4000391")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StreamReader baseReader;

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x108C82C", Offset = "0x108C82C", VA = "0x108C82C")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x108CA30", Offset = "0x108CA30", VA = "0x108CA30", Slot = "20")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x108CF30", Offset = "0x108CF30", VA = "0x108CF30", Slot = "21")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x108D0D4", Offset = "0x108D0D4", VA = "0x108D0D4", Slot = "22")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x108D0E4", Offset = "0x108D0E4", VA = "0x108D0E4", Slot = "26")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x108D390", Offset = "0x108D390", VA = "0x108D390", Slot = "27")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x108D398", Offset = "0x108D398", VA = "0x108D398", Slot = "28")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x108D3A8", Offset = "0x108D3A8", VA = "0x108D3A8", Slot = "29")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x108D3AC", Offset = "0x108D3AC", VA = "0x108D3AC", Slot = "30")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x108D3EC", Offset = "0x108D3EC", VA = "0x108D3EC", Slot = "31")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x108D3F4", Offset = "0x108D3F4", VA = "0x108D3F4", Slot = "32")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x108D3F8", Offset = "0x108D3F8", VA = "0x108D3F8", Slot = "33")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x108D4DC", Offset = "0x108D4DC", VA = "0x108D4DC", Slot = "34")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x108D4E4", Offset = "0x108D4E4", VA = "0x108D4E4", Slot = "35")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x108D4E8", Offset = "0x108D4E8", VA = "0x108D4E8", Slot = "36")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x108D528", Offset = "0x108D528", VA = "0x108D528", Slot = "37")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x108D60C", Offset = "0x108D60C", VA = "0x108D60C", Slot = "24")]
		internal override bool Goto(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x108D6A0", Offset = "0x108D6A0", VA = "0x108D6A0")]
		protected void Reset()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x108D740", Offset = "0x108D740", VA = "0x108D740")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x108D898", Offset = "0x108D898", VA = "0x108D898", Slot = "23")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x108D830", Offset = "0x108D830", VA = "0x108D830")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x108CC3C", Offset = "0x108CC3C", VA = "0x108CC3C")]
		private char ReadCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x108D0EC", Offset = "0x108D0EC", VA = "0x108D0EC")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x108CD38", Offset = "0x108CD38", VA = "0x108CD38")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x108DDE0", Offset = "0x108DDE0", VA = "0x108DDE0")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x108DFB0", Offset = "0x108DFB0", VA = "0x108DFB0")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x108CBA8", Offset = "0x108CBA8", VA = "0x108CBA8")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x108E1A8", Offset = "0x108E1A8", VA = "0x108E1A8")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x108C960", Offset = "0x108C960", VA = "0x108C960")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x108DDA8", Offset = "0x108DDA8", VA = "0x108DDA8")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x108DD34", Offset = "0x108DD34", VA = "0x108DD34")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x108DD48", Offset = "0x108DD48", VA = "0x108DD48")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x108CC28", Offset = "0x108CC28", VA = "0x108CC28")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x108CD0C", Offset = "0x108CD0C", VA = "0x108CD0C")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x108E228", Offset = "0x108E228", VA = "0x108E228")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x108E238", Offset = "0x108E238", VA = "0x108E238")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x108E360", Offset = "0x108E360", VA = "0x108E360", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x108E51C", Offset = "0x108E51C", VA = "0x108E51C", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x108E5A0", Offset = "0x108E5A0", VA = "0x108E5A0", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x108E624", Offset = "0x108E624", VA = "0x108E624", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x108E63C", Offset = "0x108E63C", VA = "0x108E63C", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x108E6B4", Offset = "0x108E6B4", VA = "0x108E6B4", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x108E760", Offset = "0x108E760", VA = "0x108E760", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x108E80C", Offset = "0x108E80C", VA = "0x108E80C", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x108E824", Offset = "0x108E824", VA = "0x108E824", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x108E83C", Offset = "0x108E83C", VA = "0x108E83C", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x108E854", Offset = "0x108E854", VA = "0x108E854", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x108E870", Offset = "0x108E870", VA = "0x108E870", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x108E88C", Offset = "0x108E88C", VA = "0x108E88C", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x108E8A8", Offset = "0x108E8A8", VA = "0x108E8A8", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x108E8C4", Offset = "0x108E8C4", VA = "0x108E8C4", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x108E948", Offset = "0x108E948", VA = "0x108E948", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addMgrToSceneAutomatically;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool autoUpdateReferences;

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x108C370", Offset = "0x108C370", VA = "0x108C370")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public enum ES3FileMode
	{
		[Token(Token = "0x4000397")]
		Read,
		[Token(Token = "0x4000398")]
		Write,
		[Token(Token = "0x4000399")]
		Append
	}
	[Token(Token = "0x2000140")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x108C380", Offset = "0x108C380", VA = "0x108C380")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x108C454", Offset = "0x108C454", VA = "0x108C454")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x108C500", Offset = "0x108C500", VA = "0x108C500")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x108C520", Offset = "0x108C520", VA = "0x108C520")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x108C5A0", Offset = "0x108C5A0", VA = "0x108C5A0", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000141")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x108F6A4", Offset = "0x108F6A4", VA = "0x108F6A4")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x108F7D4", Offset = "0x108F7D4", VA = "0x108F7D4")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x108F6E8", Offset = "0x108F6E8", VA = "0x108F6E8")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x108F820", Offset = "0x108F820", VA = "0x108F820", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000142")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x1700004F")]
		public bool Exists
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x146AC60", Offset = "0x146AC60", VA = "0x146AC60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x146AC84", Offset = "0x146AC84", VA = "0x146AC84")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x146ACB4", Offset = "0x146ACB4", VA = "0x146ACB4")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x146ADA0", Offset = "0x146ADA0", VA = "0x146ADA0", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000143")]
	public static class ES3Stream
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x146ADAC", Offset = "0x146ADAC", VA = "0x146ADAC")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}
	}
	[Token(Token = "0x2000144")]
	public class ES3Member
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x108F5F0", Offset = "0x108F5F0", VA = "0x108F5F0")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x108F634", Offset = "0x108F634", VA = "0x108F634")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x2000145")]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9FCCE8", Offset = "0x9FCCE8")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x146B3FC", Offset = "0x146B3FC", VA = "0x146B3FC")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x146BDE0", Offset = "0x146BDE0", VA = "0x146BDE0")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x146BEC4", Offset = "0x146BEC4", VA = "0x146BEC4")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x146B650", Offset = "0x146B650", VA = "0x146B650")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x146B508", Offset = "0x146B508", VA = "0x146B508")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class ES3WebClass
	{
		[Token(Token = "0x20001A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC160", Offset = "0x9FC160")]
		private sealed class <SendWebRequest>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C1")]
				[Address(RVA = "0x146C780", Offset = "0x146C780", VA = "0x146C780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C3")]
				[Address(RVA = "0x146C7E8", Offset = "0x146C7E8", VA = "0x146C7E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x146C6E0", Offset = "0x146C6E0", VA = "0x146C6E0")]
			[DebuggerHidden]
			public <SendWebRequest>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x146C718", Offset = "0x146C718", VA = "0x146C718", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x146C71C", Offset = "0x146C71C", VA = "0x146C71C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x146C788", Offset = "0x146C788", VA = "0x146C788", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isDone;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string error;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long errorCode;

		[Token(Token = "0x17000050")]
		public bool isError
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x146C198", Offset = "0x146C198", VA = "0x146C198")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x146C1D8", Offset = "0x146C1D8", VA = "0x146C1D8")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x146C260", Offset = "0x146C260", VA = "0x146C260")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x146C2FC", Offset = "0x146C2FC", VA = "0x146C2FC")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x146C3A0", Offset = "0x146C3A0", VA = "0x146C3A0")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x146C4BC", Offset = "0x146C4BC", VA = "0x146C4BC")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x146C670", Offset = "0x146C670", VA = "0x146C670")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FDED4", Offset = "0x9FDED4")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x146C70C", Offset = "0x146C70C", VA = "0x146C70C", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x2000147")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x108E964", Offset = "0x108E964", VA = "0x108E964")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x108E970", Offset = "0x108E970", VA = "0x108E970")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x108EA20", Offset = "0x108EA20", VA = "0x108EA20", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x108EA44", Offset = "0x108EA44", VA = "0x108EA44", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x108EAEC", Offset = "0x108EAEC", VA = "0x108EAEC", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x108EB6C", Offset = "0x108EB6C", VA = "0x108EB6C", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x108EC14", Offset = "0x108EC14", VA = "0x108EC14", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x108ECBC", Offset = "0x108ECBC", VA = "0x108ECBC", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x108ECE0", Offset = "0x108ECE0", VA = "0x108ECE0", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x108ED04", Offset = "0x108ED04", VA = "0x108ED04", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x108ED28", Offset = "0x108ED28", VA = "0x108ED28", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x108EDC0", Offset = "0x108EDC0", VA = "0x108EDC0", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x108EE58", Offset = "0x108EE58", VA = "0x108EE58", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x108EEF0", Offset = "0x108EEF0", VA = "0x108EEF0", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x108EF88", Offset = "0x108EF88", VA = "0x108EF88", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x108EFCC", Offset = "0x108EFCC", VA = "0x108EFCC", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x108F058", Offset = "0x108F058", VA = "0x108F058", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x108F258", Offset = "0x108F258", VA = "0x108F258", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x108F2BC", Offset = "0x108F2BC", VA = "0x108F2BC")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x108F2F0", Offset = "0x108F2F0", VA = "0x108F2F0")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x108F328", Offset = "0x108F328", VA = "0x108F328", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x108F3A4", Offset = "0x108F3A4", VA = "0x108F3A4", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x108F3D8", Offset = "0x108F3D8", VA = "0x108F3D8", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x108F40C", Offset = "0x108F40C", VA = "0x108F40C", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x108F468", Offset = "0x108F468", VA = "0x108F468", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x108F46C", Offset = "0x108F46C", VA = "0x108F46C", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x108F4A0", Offset = "0x108F4A0", VA = "0x108F4A0", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x108F4D0", Offset = "0x108F4D0", VA = "0x108F4D0", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x108F4F8", Offset = "0x108F4F8", VA = "0x108F4F8", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x108F520", Offset = "0x108F520", VA = "0x108F520", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x108F550", Offset = "0x108F550", VA = "0x108F550", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x108F554", Offset = "0x108F554", VA = "0x108F554", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x108F564", Offset = "0x108F564", VA = "0x108F564", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x108F574", Offset = "0x108F574", VA = "0x108F574", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x108F5A4", Offset = "0x108F5A4", VA = "0x108F5A4", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x108F5CC", Offset = "0x108F5CC", VA = "0x108F5CC", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x108F5D0", Offset = "0x108F5D0", VA = "0x108F5D0", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x108F5D4", Offset = "0x108F5D4", VA = "0x108F5D4", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000148")]
	internal class ES3XMLWriter : ES3Writer
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x146C7F0", Offset = "0x146C7F0", VA = "0x146C7F0")]
		public ES3XMLWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x146C7FC", Offset = "0x146C7FC", VA = "0x146C7FC")]
		internal ES3XMLWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x146C8A4", Offset = "0x146C8A4", VA = "0x146C8A4", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x146C8C8", Offset = "0x146C8C8", VA = "0x146C8C8", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x146C8EC", Offset = "0x146C8EC", VA = "0x146C8EC", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x146C914", Offset = "0x146C914", VA = "0x146C914", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x146C938", Offset = "0x146C938", VA = "0x146C938", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x146C95C", Offset = "0x146C95C", VA = "0x146C95C", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x146C980", Offset = "0x146C980", VA = "0x146C980", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x146C9A4", Offset = "0x146C9A4", VA = "0x146C9A4", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x146C9C8", Offset = "0x146C9C8", VA = "0x146C9C8", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x146C9EC", Offset = "0x146C9EC", VA = "0x146C9EC", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x146CA10", Offset = "0x146CA10", VA = "0x146CA10", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x146CAA8", Offset = "0x146CAA8", VA = "0x146CAA8", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x146CB40", Offset = "0x146CB40", VA = "0x146CB40", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x146CBD8", Offset = "0x146CBD8", VA = "0x146CBD8", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x146CC70", Offset = "0x146CC70", VA = "0x146CC70", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x146CCFC", Offset = "0x146CCFC", VA = "0x146CCFC", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] bytes)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x146D130", Offset = "0x146D130", VA = "0x146D130", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x146D134", Offset = "0x146D134", VA = "0x146D134", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x146D138", Offset = "0x146D138", VA = "0x146D138", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x146D140", Offset = "0x146D140", VA = "0x146D140", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x146D14C", Offset = "0x146D14C", VA = "0x146D14C", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x146CD94", Offset = "0x146CD94", VA = "0x146CD94")]
		protected void StartWriteProperty(string name, [Optional] ICollection<KeyValuePair<string, object>> attributes)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x146D1C0", Offset = "0x146D1C0", VA = "0x146D1C0", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x146D268", Offset = "0x146D268", VA = "0x146D268", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x146D26C", Offset = "0x146D26C", VA = "0x146D26C", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x146D270", Offset = "0x146D270", VA = "0x146D270", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x146D274", Offset = "0x146D274", VA = "0x146D274", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x146D278", Offset = "0x146D278", VA = "0x146D278", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x146D27C", Offset = "0x146D27C", VA = "0x146D27C", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x146D280", Offset = "0x146D280", VA = "0x146D280", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x146D284", Offset = "0x146D284", VA = "0x146D284", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x146D288", Offset = "0x146D288", VA = "0x146D288", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x146D28C", Offset = "0x146D28C", VA = "0x146D28C", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x146D290", Offset = "0x146D290", VA = "0x146D290", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x146D2F4", Offset = "0x146D2F4", VA = "0x146D2F4", Slot = "22")]
		public override void Dispose()
		{
		}
	}
}
namespace MoodkieSecurity
{
	[Token(Token = "0x2000149")]
	public enum AESBits
	{
		[Token(Token = "0x40003AF")]
		BITS128,
		[Token(Token = "0x40003B0")]
		BITS192,
		[Token(Token = "0x40003B1")]
		BITS256
	}
	[Token(Token = "0x200014A")]
	public class AESEncryptor
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string fPassword;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AESBits fEncryptionBits;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] fSalt;

		[Token(Token = "0x17000051")]
		public string Password
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x124ABB8", Offset = "0x124ABB8", VA = "0x124ABB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x124ABC0", Offset = "0x124ABC0", VA = "0x124ABC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public AESBits EncryptionBits
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x124ABC8", Offset = "0x124ABC8", VA = "0x124ABC8")]
			get
			{
				return default(AESBits);
			}
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x124ABD0", Offset = "0x124ABD0", VA = "0x124ABD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public byte[] Salt
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x124ABD8", Offset = "0x124ABD8", VA = "0x124ABD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x124ABE0", Offset = "0x124ABE0", VA = "0x124ABE0")]
			set
			{
			}
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x124A5B8", Offset = "0x124A5B8", VA = "0x124A5B8")]
		public AESEncryptor(string password, AESBits encryptionBits)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x124A64C", Offset = "0x124A64C", VA = "0x124A64C")]
		public AESEncryptor(string password, AESBits encryptionBits, byte[] salt)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x124A6F0", Offset = "0x124A6F0", VA = "0x124A6F0")]
		private byte[] Encrypt(byte[] data, byte[] key, byte[] iV)
		{
			return null;
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x124A840", Offset = "0x124A840", VA = "0x124A840")]
		public byte[] Encrypt(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x124A954", Offset = "0x124A954", VA = "0x124A954")]
		private byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x124AAA4", Offset = "0x124AAA4", VA = "0x124AAA4")]
		public byte[] Decrypt(byte[] data)
		{
			return null;
		}
	}
	[Token(Token = "0x200014B")]
	internal struct ABCDStruct
	{
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint A;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint B;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint C;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint D;
	}
	[Token(Token = "0x200014C")]
	public sealed class MD5Core
	{
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x124ABE8", Offset = "0x124ABE8", VA = "0x124ABE8")]
		private MD5Core()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x124ABF0", Offset = "0x124ABF0", VA = "0x124ABF0")]
		public static byte[] GetHash(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x124ADC0", Offset = "0x124ADC0", VA = "0x124ADC0")]
		public static byte[] GetHash(string input)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x124AE24", Offset = "0x124AE24", VA = "0x124AE24")]
		public static string GetHashString(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x124AF10", Offset = "0x124AF10", VA = "0x124AF10")]
		public static string GetHashString(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x124AFE8", Offset = "0x124AFE8", VA = "0x124AFE8")]
		public static string GetHashString(string input)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x124ACC8", Offset = "0x124ACC8", VA = "0x124ACC8")]
		public static byte[] GetHash(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x124BAE0", Offset = "0x124BAE0", VA = "0x124BAE0")]
		internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ABCDStruct ABCD, long len)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x124B04C", Offset = "0x124B04C", VA = "0x124B04C")]
		internal static void GetHashBlock(byte[] input, ref ABCDStruct ABCDValue, int ibStart)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x124BE98", Offset = "0x124BE98", VA = "0x124BE98")]
		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x124BEC0", Offset = "0x124BEC0", VA = "0x124BEC0")]
		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x124BEE8", Offset = "0x124BEE8", VA = "0x124BEE8")]
		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x124BF0C", Offset = "0x124BF0C", VA = "0x124BF0C")]
		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x124BF30", Offset = "0x124BF30", VA = "0x124BF30")]
		private static uint LSR(uint i, int s)
		{
			return default(uint);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x124BD24", Offset = "0x124BD24", VA = "0x124BD24")]
		private static uint[] Converter(byte[] input, int ibStart)
		{
			return null;
		}
	}
	[Token(Token = "0x200014D")]
	public class MD5Encryptor
	{
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x124BF3C", Offset = "0x124BF3C", VA = "0x124BF3C")]
		public MD5Encryptor()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x124BF44", Offset = "0x124BF44", VA = "0x124BF44")]
		public string GetMD5(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x124BF4C", Offset = "0x124BF4C", VA = "0x124BF4C")]
		public string GetMD5(string data)
		{
			return null;
		}
	}
	[Token(Token = "0x200014E")]
	public class Obfuscator
	{
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x124BF54", Offset = "0x124BF54", VA = "0x124BF54")]
		public static byte[] Obfuscate(byte[] data, string key)
		{
			return null;
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x124BFEC", Offset = "0x124BFEC", VA = "0x124BFEC")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x124C07C", Offset = "0x124C07C", VA = "0x124C07C")]
		public Obfuscator()
		{
		}
	}
}
