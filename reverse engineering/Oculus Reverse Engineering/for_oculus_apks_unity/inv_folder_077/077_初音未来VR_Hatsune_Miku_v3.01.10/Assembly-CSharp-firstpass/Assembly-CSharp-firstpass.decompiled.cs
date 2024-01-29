using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("1.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class ES2AutoSave : MonoBehaviour, IES2Selectable
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ES2AutoSaveVariableInfo> variableCache;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<ES2AutoSaveComponentInfo> components;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public ES2AutoSaveVariableInfo activeSelfVariable;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public ES2AutoSaveVariableInfo nameVariable;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ES2AutoSaveVariableInfo tagVariable;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public ES2AutoSaveVariableInfo layerVariable;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ES2AutoSaveVariableInfo parentVariable;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public string id;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public string prefabID;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public bool isInitialised;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	[SerializeField]
	public bool _selected;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0090", Offset = "0x5B0090")]
	private bool <selectionChanged>k__BackingField;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	public bool saveButtonSelected;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B00B0", Offset = "0x5B00B0")]
	private bool <buttonSelectionChanged>k__BackingField;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Color color;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public new Transform transform;

	[Token(Token = "0x17000001")]
	public UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xCF95AC", Offset = "0xCF95AC", VA = "0xCF95AC", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public bool selected
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xCF95B0", Offset = "0xCF95B0", VA = "0xCF95B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xCF95B8", Offset = "0xCF95B8", VA = "0xCF95B8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool selectionChanged
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xCF95CC", Offset = "0xCF95CC", VA = "0xCF95CC", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0658", Offset = "0x5B0658")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xCF95D4", Offset = "0xCF95D4", VA = "0xCF95D4", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0668", Offset = "0x5B0668")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public bool buttonSelected
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xCF95E0", Offset = "0xCF95E0", VA = "0xCF95E0", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0xCF95E8", Offset = "0xCF95E8", VA = "0xCF95E8", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xCF95FC", Offset = "0xCF95FC", VA = "0xCF95FC", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0678", Offset = "0x5B0678")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xCF9604", Offset = "0xCF9604", VA = "0xCF9604", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0688", Offset = "0x5B0688")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public bool hasButtonSelectedComponents
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xCF9610", Offset = "0xCF9610", VA = "0xCF9610")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public bool isPrefab
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xCF9704", Offset = "0xCF9704", VA = "0xCF9704")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xCF9728", Offset = "0xCF9728", VA = "0xCF9728")]
	public ES2AutoSaveVariableInfo GetCachedVariableInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xCF9838", Offset = "0xCF9838", VA = "0xCF9838")]
	public ES2AutoSaveVariableInfo CacheVariableInfo(ES2AutoSaveVariableInfo variable)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xCF98A8", Offset = "0xCF98A8", VA = "0xCF98A8")]
	public void RemoveCachedVariableInfo(string id)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xCF99D0", Offset = "0xCF99D0", VA = "0xCF99D0")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xCF9EC0", Offset = "0xCF9EC0", VA = "0xCF9EC0")]
	public ES2AutoSaveComponentInfo GetComponentInfo(Component c)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xCF9FD0", Offset = "0xCF9FD0", VA = "0xCF9FD0")]
	public ES2AutoSaveComponentInfo GetComponentInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xCFA0C0", Offset = "0xCFA0C0", VA = "0xCFA0C0")]
	public ES2AutoSaveComponentInfo AddComponentInfo(ES2AutoSaveComponentInfo info)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xCFA130", Offset = "0xCFA130", VA = "0xCFA130")]
	public static ES2AutoSave AddAutoSave(GameObject go, Color color, bool hide, bool generateID, string id)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xCFA4D4", Offset = "0xCFA4D4", VA = "0xCFA4D4")]
	public static ES2AutoSave GetAutoSave(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xCF9CF4", Offset = "0xCF9CF4", VA = "0xCF9CF4")]
	public static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xCFA52C", Offset = "0xCFA52C", VA = "0xCFA52C")]
	public ES2AutoSave()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class ES2AutoSaveComponentInfo : ES2AutoSaveVariableInfo
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public Component component;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xCFA5E4", Offset = "0xCFA5E4", VA = "0xCFA5E4")]
	public ES2AutoSaveComponentInfo()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xCFA668", Offset = "0xCFA668", VA = "0xCFA668")]
	public ES2AutoSaveComponentInfo(Component c, ES2AutoSave autoSave)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xCFA810", Offset = "0xCFA810", VA = "0xCFA810")]
	public ES2AutoSaveComponentInfo(string name, Type type, ES2AutoSave autoSave)
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class ES2AutoSaveVariableInfo : IES2Selectable
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string name;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string id;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string previousID;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool isComponent;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool _selected;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0140", Offset = "0x5B0140")]
	private bool <selectionChanged>k__BackingField;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	[SerializeField]
	private bool saveButtonSelected;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public bool isProperty;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0170", Offset = "0x5B0170")]
	private bool <buttonSelectionChanged>k__BackingField;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string assemblyQualifiedTypeName;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<string> variableIDs;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject gameObject;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ES2AutoSave _autoSave;

	[Token(Token = "0x17000008")]
	public bool selected
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xCFF490", Offset = "0xCFF490", VA = "0xCFF490", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xCFF498", Offset = "0xCFF498", VA = "0xCFF498", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	[SerializeField]
	public bool selectionChanged
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xCFF4AC", Offset = "0xCFF4AC", VA = "0xCFF4AC", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B0698", Offset = "0x5B0698")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xCFF4B4", Offset = "0xCFF4B4", VA = "0xCFF4B4", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B06A8", Offset = "0x5B06A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public bool buttonSelected
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xCFF4C0", Offset = "0xCFF4C0", VA = "0xCFF4C0", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xCFF4C8", Offset = "0xCFF4C8", VA = "0xCFF4C8", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xCFF4DC", Offset = "0xCFF4DC", VA = "0xCFF4DC", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B06B8", Offset = "0x5B06B8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0xCFF4E4", Offset = "0xCFF4E4", VA = "0xCFF4E4", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B06C8", Offset = "0x5B06C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public ES2AutoSave autoSave
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xCFF4F0", Offset = "0xCFF4F0", VA = "0xCFF4F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xCFA7D8", Offset = "0xCFA7D8", VA = "0xCFA7D8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xCFF590", Offset = "0xCFF590", VA = "0xCFF590", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public Type type
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xCFA74C", Offset = "0xCFA74C", VA = "0xCFA74C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xCFA70C", Offset = "0xCFA70C", VA = "0xCFA70C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public bool HasButtonSelectedVariables
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xCFF594", Offset = "0xCFF594", VA = "0xCFF594")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xCFA5E8", Offset = "0xCFA5E8", VA = "0xCFA5E8")]
	public ES2AutoSaveVariableInfo()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xCFA3CC", Offset = "0xCFA3CC", VA = "0xCFA3CC")]
	public ES2AutoSaveVariableInfo(string name, Type type, bool isProperty, ES2AutoSave autoSave, ES2AutoSaveVariableInfo previous)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xCFF698", Offset = "0xCFF698", VA = "0xCFF698")]
	public ES2AutoSaveVariableInfo GetVariableInfo(string name)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xCFF778", Offset = "0xCFF778", VA = "0xCFF778")]
	public ES2AutoSaveVariableInfo AddVariableInfo(string name, Type type, bool isProperty, [Optional] ES2AutoSave autoSave, [Optional] ES2AutoSaveVariableInfo previous)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xCFF894", Offset = "0xCFF894", VA = "0xCFF894")]
	public void DeleteVariableInfo(string id)
	{
	}
}
[Token(Token = "0x2000005")]
public interface IES2Selectable
{
	[Token(Token = "0x17000010")]
	bool selected
	{
		[Token(Token = "0x600002D")]
		get;
		[Token(Token = "0x600002E")]
		set;
	}

	[Token(Token = "0x17000011")]
	bool selectionChanged
	{
		[Token(Token = "0x600002F")]
		get;
		[Token(Token = "0x6000030")]
		set;
	}

	[Token(Token = "0x17000012")]
	bool buttonSelected
	{
		[Token(Token = "0x6000031")]
		get;
		[Token(Token = "0x6000032")]
		set;
	}

	[Token(Token = "0x17000013")]
	bool buttonSelectionChanged
	{
		[Token(Token = "0x6000033")]
		get;
		[Token(Token = "0x6000034")]
		set;
	}

	[Token(Token = "0x17000014")]
	UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x6000035")]
		get;
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class ES2AutoSaveGlobalManager : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2AutoSave[] prefabArray;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HashSet<string> ids;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xCFA898", Offset = "0xCFA898", VA = "0xCFA898")]
	public ES2AutoSaveGlobalManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class ES2AutoSaveManager : MonoBehaviour
{
	[Token(Token = "0x2000084")]
	public enum LoadEvent
	{
		[Token(Token = "0x4000282")]
		Start,
		[Token(Token = "0x4000283")]
		OnApplicationUnPause,
		[Token(Token = "0x4000284")]
		None
	}

	[Token(Token = "0x2000085")]
	public enum SaveEvent
	{
		[Token(Token = "0x4000286")]
		OnApplicationQuit,
		[Token(Token = "0x4000287")]
		OnApplicationPause,
		[Token(Token = "0x4000288")]
		OnDisable,
		[Token(Token = "0x4000289")]
		None
	}

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LoadEvent loadEvent;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SaveEvent saveEvent;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string filePath;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public new string tag;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool encrypt;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string encryptionPassword;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ES2Settings.EncryptionType encryptionType;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool deletePrefabsOnLoad;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool convertPrefabsToSceneObjectsOnImport;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ES2AutoSave[] sceneObjects;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Dictionary<string, ES2AutoSave> autoSaves;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Dictionary<Transform, ES2AutoSave> transforms;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public ES2AutoSaveGlobalManager globalManager;

	[NonSerialized]
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public HashSet<string> ids;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES2AutoSaveManager _instance;

	[Token(Token = "0x17000015")]
	public static ES2AutoSaveManager Instance
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0xCF9BD4", Offset = "0xCF9BD4", VA = "0xCF9BD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xCFA908", Offset = "0xCFA908", VA = "0xCFA908")]
	public void SetFilePath(string filePath)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xCFA910", Offset = "0xCFA910", VA = "0xCFA910")]
	public void Awake()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xCF9E2C", Offset = "0xCF9E2C", VA = "0xCF9E2C")]
	public void AddAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xCFAA48", Offset = "0xCFAA48", VA = "0xCFAA48")]
	public ES2AutoSave GetAutoSave(string id)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xCFAAC8", Offset = "0xCFAAC8", VA = "0xCFAAC8")]
	public void AddChildAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xCFAB38", Offset = "0xCFAB38", VA = "0xCFAB38")]
	public void Save()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xCFADC8", Offset = "0xCFADC8", VA = "0xCFADC8")]
	public void Load()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xCFB1F4", Offset = "0xCFB1F4", VA = "0xCFB1F4")]
	public void WriteAutoSaves(ES2Writer writer)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xCFB408", Offset = "0xCFB408", VA = "0xCFB408")]
	private void WriteAutoSaveRecursive(Transform transform, ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xCFB898", Offset = "0xCFB898", VA = "0xCFB898")]
	private void WriteAutoSave(ES2AutoSave autoSave, Transform transform, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xCFC234", Offset = "0xCFC234", VA = "0xCFC234")]
	private void WriteVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Writer writer, object obj)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xCFD908", Offset = "0xCFD908", VA = "0xCFD908")]
	public void ReadAutoSaves(ES2Reader reader)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xCFD93C", Offset = "0xCFD93C", VA = "0xCFD93C")]
	private bool ReadAutoSave(ES2Reader reader, [Optional] ES2AutoSave autoSave)
	{
		return default(bool);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xCFE320", Offset = "0xCFE320", VA = "0xCFE320")]
	private void ReadComponent(ES2AutoSave autoSave, ES2Reader reader)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xCFE86C", Offset = "0xCFE86C", VA = "0xCFE86C")]
	private void ReadVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Reader reader, object obj)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xCFC758", Offset = "0xCFC758", VA = "0xCFC758")]
	protected void WriteAllComponents(ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xCFF2B8", Offset = "0xCFF2B8", VA = "0xCFF2B8")]
	public void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xCFF2C8", Offset = "0xCFF2C8", VA = "0xCFF2C8")]
	public void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xCFF320", Offset = "0xCFF320", VA = "0xCFF320")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xCFF330", Offset = "0xCFF330", VA = "0xCFF330")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xCFF344", Offset = "0xCFF344", VA = "0xCFF344")]
	public ES2AutoSaveManager()
	{
	}
}
[Token(Token = "0x2000008")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE864", Offset = "0x5AE864")]
public static class ES2DirectoryUtility
{
	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD00C54", Offset = "0xD00C54", VA = "0xD00C54")]
	public static void Delete(string path, bool recursive)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD00C60", Offset = "0xD00C60", VA = "0xD00C60")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD00C68", Offset = "0xD00C68", VA = "0xD00C68")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD00C70", Offset = "0xD00C70", VA = "0xD00C70")]
	public static void CreateDirectory(string path)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD00C78", Offset = "0xD00C78", VA = "0xD00C78")]
	public static string[] GetDirectories(string path)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD00C80", Offset = "0xD00C80", VA = "0xD00C80")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE878", Offset = "0x5AE878")]
public static class ES2Dispose
{
	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD00C88", Offset = "0xD00C88", VA = "0xD00C88")]
	public static void Dispose(BinaryReader reader)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD00CA4", Offset = "0xD00CA4", VA = "0xD00CA4")]
	public static void Dispose(BinaryWriter writer)
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE88C", Offset = "0x5AE88C")]
public static class ES2FileUtility
{
	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD00E0C", Offset = "0xD00E0C", VA = "0xD00E0C")]
	public static void Delete(string path)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD00E04", Offset = "0xD00E04", VA = "0xD00E04")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD015B8", Offset = "0xD015B8", VA = "0xD015B8")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD01C70", Offset = "0xD01C70", VA = "0xD01C70")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD01BB8", Offset = "0xD01BB8", VA = "0xD01BB8")]
	public static Stream CreateFileStream(string path, ES2Settings.ES2FileMode filemode, int bufferSize)
	{
		return null;
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE8A0", Offset = "0x5AE8A0")]
public static class ES2TypeUtility
{
	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD087FC", Offset = "0xD087FC", VA = "0xD087FC")]
	public static bool IsEnum(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000C")]
public static class ES2
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool initialised;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xCF3ADC", Offset = "0xCF3ADC", VA = "0xCF3ADC")]
	public static void Init()
	{
	}

	[Token(Token = "0x600005D")]
	public static void Save<T>(T param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600005E")]
	public static void Save<T>(T param, string identifier)
	{
	}

	[Token(Token = "0x600005F")]
	public static void Save<T>(T[] param, string identifier)
	{
	}

	[Token(Token = "0x6000060")]
	public static void Save<T>(T[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000061")]
	public static void Save<T>(T[,] param, string identifier)
	{
	}

	[Token(Token = "0x6000062")]
	public static void Save<T>(T[,] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000063")]
	public static void Save2DArray<T>(T[,] param, string identifier)
	{
	}

	[Token(Token = "0x6000064")]
	public static void Save2DArray<T>(T[,] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000065")]
	public static void Save<T>(T[,,] param, string identifier)
	{
	}

	[Token(Token = "0x6000066")]
	public static void Save<T>(T[,,] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000067")]
	public static void Save3DArray<T>(T[,,] param, string identifier)
	{
	}

	[Token(Token = "0x6000068")]
	public static void Save3DArray<T>(T[,,] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000069")]
	public static void Save<TKey, TValue>(Dictionary<TKey, TValue> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600006A")]
	public static void Save<TKey, TValue>(Dictionary<TKey, TValue> param, string identifier)
	{
	}

	[Token(Token = "0x600006B")]
	public static void Save<T>(List<T> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600006C")]
	public static void Save<T>(HashSet<T> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600006D")]
	public static void Save<T>(Queue<T> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600006E")]
	public static void Save<T>(Stack<T> param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600006F")]
	public static void Save<T>(List<T> param, string identifier)
	{
	}

	[Token(Token = "0x6000070")]
	public static void Save<T>(HashSet<T> param, string identifier)
	{
	}

	[Token(Token = "0x6000071")]
	public static void Save<T>(Queue<T> param, string identifier)
	{
	}

	[Token(Token = "0x6000072")]
	public static void Save<T>(Stack<T> param, string identifier)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xCF3B5C", Offset = "0xCF3B5C", VA = "0xCF3B5C")]
	public static void SaveRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xCF3D4C", Offset = "0xCF3D4C", VA = "0xCF3D4C")]
	public static void SaveRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xCF3BFC", Offset = "0xCF3BFC", VA = "0xCF3BFC")]
	public static void SaveRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xCF3DF4", Offset = "0xCF3DF4", VA = "0xCF3DF4")]
	public static void SaveRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xCF420C", Offset = "0xCF420C", VA = "0xCF420C")]
	public static void SaveRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xCF4374", Offset = "0xCF4374", VA = "0xCF4374")]
	public static void SaveRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xCF44D4", Offset = "0xCF44D4", VA = "0xCF44D4")]
	public static void AppendRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xCF46D4", Offset = "0xCF46D4", VA = "0xCF46D4")]
	public static void AppendRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xCF4574", Offset = "0xCF4574", VA = "0xCF4574")]
	public static void AppendRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xCF477C", Offset = "0xCF477C", VA = "0xCF477C")]
	public static void AppendRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xCF48D0", Offset = "0xCF48D0", VA = "0xCF48D0")]
	public static void AppendRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xCF4A48", Offset = "0xCF4A48", VA = "0xCF4A48")]
	public static void AppendRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xCF4BB4", Offset = "0xCF4BB4", VA = "0xCF4BB4")]
	public static void SaveImage(Texture2D tex, string identifier)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xCF4D74", Offset = "0xCF4D74", VA = "0xCF4D74")]
	public static byte[] LoadRaw(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xCF4F50", Offset = "0xCF4F50", VA = "0xCF4F50")]
	public static byte[] LoadRaw(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xCF5084", Offset = "0xCF5084", VA = "0xCF5084")]
	public static object LoadObject(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xCF5228", Offset = "0xCF5228", VA = "0xCF5228")]
	public static object LoadObject(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	public static T Load<T>(string identifier, ES2Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x6000085")]
	public static T Load<T>(string identifier)
	{
		return (T)null;
	}

	[Token(Token = "0x6000086")]
	public static void Load<T>(string identifier, T c) where T : class
	{
	}

	[Token(Token = "0x6000087")]
	public static void Load<T>(string identifier, T c, ES2Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000088")]
	public static T[] LoadArray<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	public static T[] LoadArray<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	public static void LoadArray<T>(string identifier, T[] c) where T : class
	{
	}

	[Token(Token = "0x600008B")]
	public static void LoadArray<T>(string identifier, T[] c, ES2Settings settings) where T : class
	{
	}

	[Token(Token = "0x600008C")]
	public static T[,] Load2DArray<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	public static T[,] Load2DArray<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	public static T[,,] Load3DArray<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	public static T[,,] Load3DArray<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	public static Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	public static Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	public static List<T> LoadList<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	public static List<T> LoadList<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	public static void LoadList<T>(string identifier, List<T> c) where T : class
	{
	}

	[Token(Token = "0x6000095")]
	public static void LoadList<T>(string identifier, List<T> c, ES2Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000096")]
	public static HashSet<T> LoadHashSet<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	public static HashSet<T> LoadHashSet<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	public static Queue<T> LoadQueue<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	public static Queue<T> LoadQueue<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	public static Stack<T> LoadStack<T>(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	public static Stack<T> LoadStack<T>(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xCF5370", Offset = "0xCF5370", VA = "0xCF5370")]
	public static ES2Data LoadAll(string path)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xCF5580", Offset = "0xCF5580", VA = "0xCF5580")]
	public static ES2Data LoadAll(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xCF56B4", Offset = "0xCF56B4", VA = "0xCF56B4")]
	public static Texture2D LoadImage(string path)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xCF5978", Offset = "0xCF5978", VA = "0xCF5978")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xCF59F0", Offset = "0xCF59F0", VA = "0xCF59F0")]
	public static AudioClip LoadAudio(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xCF5DDC", Offset = "0xCF5DDC", VA = "0xCF5DDC")]
	public static void CacheFile(string identifier)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xCF5FF4", Offset = "0xCF5FF4", VA = "0xCF5FF4")]
	public static bool Exists(string identifier)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xCF6484", Offset = "0xCF6484", VA = "0xCF6484")]
	public static bool Exists(string identifier, ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xCF64AC", Offset = "0xCF64AC", VA = "0xCF64AC")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xCF6740", Offset = "0xCF6740", VA = "0xCF6740")]
	public static void Delete(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xCF6768", Offset = "0xCF6768", VA = "0xCF6768")]
	public static void DeleteDefaultFolder()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xCF6AE0", Offset = "0xCF6AE0", VA = "0xCF6AE0")]
	public static void Rename(string identifier, string newIdentifier)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xCF6DB8", Offset = "0xCF6DB8", VA = "0xCF6DB8")]
	public static void Rename(string identifier, string newIdentifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xCF6E0C", Offset = "0xCF6E0C", VA = "0xCF6E0C")]
	public static string[] GetFiles(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xCF6EBC", Offset = "0xCF6EBC", VA = "0xCF6EBC")]
	public static string[] GetFiles(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xCF6EE4", Offset = "0xCF6EE4", VA = "0xCF6EE4")]
	public static string[] GetFiles(string identifier, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xCF7138", Offset = "0xCF7138", VA = "0xCF7138")]
	public static string[] GetFolders(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xCF7374", Offset = "0xCF7374", VA = "0xCF7374")]
	public static string[] GetFolders(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xCF739C", Offset = "0xCF739C", VA = "0xCF739C")]
	public static string[] GetTags(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xCF751C", Offset = "0xCF751C", VA = "0xCF751C")]
	public static string[] GetTags(string identifier, ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x200000D")]
public class ES2Auto : MonoBehaviour
{
	[Token(Token = "0x2000086")]
	public enum SaveEvent
	{
		[Token(Token = "0x400028B")]
		OnDisable,
		[Token(Token = "0x400028C")]
		OnInterval
	}

	[Token(Token = "0x2000087")]
	public enum LoadEvent
	{
		[Token(Token = "0x400028E")]
		OnAwake,
		[Token(Token = "0x400028F")]
		OnStart,
		[Token(Token = "0x4000290")]
		OnEnable
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFEE0", Offset = "0x5AFEE0")]
	private sealed class <SaveRoutine>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Auto <>4__this;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xCF953C", Offset = "0xCF953C", VA = "0xCF953C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xCF95A4", Offset = "0xCF95A4", VA = "0xCF95A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xCF91CC", Offset = "0xCF91CC", VA = "0xCF91CC")]
		[DebuggerHidden]
		public <SaveRoutine>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xCF9474", Offset = "0xCF9474", VA = "0xCF9474", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xCF9478", Offset = "0xCF9478", VA = "0xCF9478", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xCF9544", Offset = "0xCF9544", VA = "0xCF9544", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool saveOnDisable;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	public bool saveOnInterval;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float saveInterval;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool loadOnEnable;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[SerializeField]
	public bool loadOnAwake;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	[SerializeField]
	public bool loadOnStart;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	[SerializeField]
	public bool isPlayMaker;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string uniqueTag;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool savePosition;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[SerializeField]
	public bool saveRotation;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	[SerializeField]
	public bool saveScale;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	[SerializeField]
	public bool saveMesh;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public bool saveSphereCollider;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	[SerializeField]
	public bool saveBoxCollider;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	[SerializeField]
	public bool saveCapsuleCollider;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	[SerializeField]
	public bool saveMeshCollider;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string saveFile;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public ES2Settings.SaveLocation saveLocation;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	public bool encrypt;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public string encryptionPassword;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public string webUsername;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public string webPassword;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isQuitting;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ES2Settings settings;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xCF7548", Offset = "0xCF7548", VA = "0xCF7548")]
	private void SavePosition()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xCF76CC", Offset = "0xCF76CC", VA = "0xCF76CC")]
	private void LoadPosition()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xCF77E8", Offset = "0xCF77E8", VA = "0xCF77E8")]
	private void SaveRotation()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xCF78C8", Offset = "0xCF78C8", VA = "0xCF78C8")]
	private void LoadRotation()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xCF79E4", Offset = "0xCF79E4", VA = "0xCF79E4")]
	private void SaveScale()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xCF7ABC", Offset = "0xCF7ABC", VA = "0xCF7ABC")]
	private void LoadScale()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xCF7BD8", Offset = "0xCF7BD8", VA = "0xCF7BD8")]
	private void SaveMesh()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xCF7D98", Offset = "0xCF7D98", VA = "0xCF7D98")]
	private void LoadMesh()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xCF8054", Offset = "0xCF8054", VA = "0xCF8054")]
	private void SaveSphereCollider()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xCF81DC", Offset = "0xCF81DC", VA = "0xCF81DC")]
	private void LoadSphereCollider()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xCF8444", Offset = "0xCF8444", VA = "0xCF8444")]
	private void SaveCapsuleCollider()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xCF85CC", Offset = "0xCF85CC", VA = "0xCF85CC")]
	private void LoadCapsuleCollider()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xCF8834", Offset = "0xCF8834", VA = "0xCF8834")]
	private void SaveBoxCollider()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xCF89BC", Offset = "0xCF89BC", VA = "0xCF89BC")]
	private void LoadBoxCollider()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xCF8C24", Offset = "0xCF8C24", VA = "0xCF8C24")]
	private void SaveMeshCollider()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xCF8DAC", Offset = "0xCF8DAC", VA = "0xCF8DAC")]
	private void LoadMeshCollider()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xCF9014", Offset = "0xCF9014", VA = "0xCF9014")]
	public void Save()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xCF90B8", Offset = "0xCF90B8", VA = "0xCF90B8")]
	public void Load()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xCF915C", Offset = "0xCF915C", VA = "0xCF915C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B06D8", Offset = "0x5B06D8")]
	private IEnumerator SaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xCF91F8", Offset = "0xCF91F8", VA = "0xCF91F8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xCF9210", Offset = "0xCF9210", VA = "0xCF9210")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xCF9230", Offset = "0xCF9230", VA = "0xCF9230")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xCF9378", Offset = "0xCF9378", VA = "0xCF9378")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xCF9390", Offset = "0xCF9390", VA = "0xCF9390")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xCF7620", Offset = "0xCF7620", VA = "0xCF7620")]
	private string GetFullFilename(string tagExtension)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xCF9290", Offset = "0xCF9290", VA = "0xCF9290")]
	private void InitializeSettings()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xCF93A8", Offset = "0xCF93A8", VA = "0xCF93A8")]
	public ES2Auto()
	{
	}
}
[Token(Token = "0x200000E")]
public static class ES2Cache
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, ES2CachedFile> fileCaches;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xCFF910", Offset = "0xCFF910", VA = "0xCFF910")]
	public static ES2CachedFile AddNewCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xCFFA34", Offset = "0xCFFA34", VA = "0xCFFA34")]
	public static bool DeleteCachedFile(string absolutePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xCFFAB8", Offset = "0xCFFAB8", VA = "0xCFFAB8")]
	public static ES2CachedFile GetOrCreateCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xCFFB7C", Offset = "0xCFFB7C", VA = "0xCFFB7C")]
	public static ES2CachedFile GetCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xCFFC20", Offset = "0xCFFC20", VA = "0xCFFC20")]
	public new static string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200000F")]
public class ES2CachedFile
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, ES2Tag> tagCache;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xD0000C", Offset = "0xD0000C", VA = "0xD0000C")]
	public void AddTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xD00054", Offset = "0xD00054", VA = "0xD00054")]
	public void AddTag(ES2Tag tag)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xD000EC", Offset = "0xD000EC", VA = "0xD000EC")]
	public ES2Tag AddOrUpdateTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xD0023C", Offset = "0xD0023C", VA = "0xD0023C")]
	public ES2Tag GetTag(string tag)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xD00398", Offset = "0xD00398", VA = "0xD00398")]
	public bool RemoveTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xD00400", Offset = "0xD00400", VA = "0xD00400")]
	public void RenameTag(string oldTag, string newTag)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xD004BC", Offset = "0xD004BC", VA = "0xD004BC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xCFF9C4", Offset = "0xCFF9C4", VA = "0xCFF9C4")]
	public ES2CachedFile()
	{
	}
}
[Token(Token = "0x2000010")]
public struct ES2Tag
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string tag;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public long position;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long settingsPosition;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public long nextTagPosition;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isNull;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x631CC8", Offset = "0x631CC8", VA = "0x631CC8")]
	public ES2Tag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x631CD8", Offset = "0x631CD8", VA = "0x631CD8")]
	public ES2Tag(bool isNull)
	{
	}
}
[Token(Token = "0x2000011")]
public class ES2Data
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<string, object> loadedData;

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xD00984", Offset = "0xD00984", VA = "0xD00984")]
	public void Add(string tag, object value)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xD009F4", Offset = "0xD009F4", VA = "0xD009F4")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xD00A5C", Offset = "0xD00A5C", VA = "0xD00A5C")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	public T Load<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x60000E0")]
	public T[] LoadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	public T[,] Load2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	public T[,,] Load3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	public Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	public List<T> LoadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	public HashSet<T> LoadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	public Queue<T> LoadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	public Stack<T> LoadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xD00BE4", Offset = "0xD00BE4", VA = "0xD00BE4")]
	public ES2Data()
	{
	}
}
[Token(Token = "0x2000012")]
public class ES2EditorWindowStyle : MonoBehaviour
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GUIStyle hierarchyLabelStyle;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GUIStyle hierarchyLabelHighlightedStyle;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GUIStyle saveButtonStyle;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GUIStyle saveButtonSelectedStyle;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GUIStyle menuStyle;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GUIStyle menuMainButtonStyle;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GUIStyle menuSubButtonStyle;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GUIStyle inputLabelStyle;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GUIStyle textInputStyle;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle textAreaStyle;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GUIStyle toggleInputStyle;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GUIStyle windowContentStyle;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GUIStyle sectionStyle;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GUIStyle indentStyle;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GUIStyle columnStyle;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GUIStyle titleStyle;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GUIStyle subHeadingStyle;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GUIStyle contentButtonStyle;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GUIStyle contentTextStyle;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Texture2D windowIcon;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Texture2D windowBackground;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D whiteBackground;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Texture2D lightGreyBackground;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Texture2D toggleSelectedBackground;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Texture2D subMenuBackground;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Font bebas;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Font robotoSlab;

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xD00CC0", Offset = "0xD00CC0", VA = "0xD00CC0")]
	public ES2EditorWindowStyle()
	{
	}
}
[Token(Token = "0x2000013")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE8B4", Offset = "0x5AE8B4")]
public static class ES2File
{
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xCF650C", Offset = "0xCF650C", VA = "0xCF650C")]
	public static void Delete(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xD00D0C", Offset = "0xD00D0C", VA = "0xD00D0C")]
	public static void DeleteFile(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xD00E14", Offset = "0xD00E14", VA = "0xD00E14")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xCF6054", Offset = "0xCF6054", VA = "0xCF6054")]
	public static bool Exists(ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xD00F48", Offset = "0xD00F48", VA = "0xD00F48")]
	private static bool CheckForTagInBytes(string tag, byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xD01390", Offset = "0xD01390", VA = "0xD01390")]
	public static void CreateFolder(string identifier)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xCF6B64", Offset = "0xCF6B64", VA = "0xCF6B64")]
	public static void Rename(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xD01398", Offset = "0xD01398", VA = "0xD01398")]
	public static void MoveFile(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xCF7198", Offset = "0xCF7198", VA = "0xCF7198")]
	public static string[] GetFolders(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xCF6E6C", Offset = "0xCF6E6C", VA = "0xCF6E6C")]
	public static string[] GetFiles(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xCF6F54", Offset = "0xCF6F54", VA = "0xCF6F54")]
	public static string[] GetFiles(ES2Settings settings, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xCF73FC", Offset = "0xCF73FC", VA = "0xCF73FC")]
	public static string[] GetTags(ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x2000014")]
public static class ES2Reflection
{
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xCFECA4", Offset = "0xCFECA4", VA = "0xCFECA4")]
	public static bool SetValue(object obj, string name, object value, bool isProperty = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xCFCE08", Offset = "0xCFCE08", VA = "0xCFCE08")]
	public static object GetValue(object obj, string name, bool isProperty = false)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xD039A0", Offset = "0xD039A0", VA = "0xD039A0")]
	public static bool IsAssignableFrom(Type a, Type b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xD039C0", Offset = "0xD039C0", VA = "0xD039C0")]
	public static bool IsGenericType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xCFCDE8", Offset = "0xCFCDE8", VA = "0xCFCDE8")]
	public static Type[] GetGenericArguments(Type type)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xD047F4", Offset = "0xD047F4", VA = "0xD047F4")]
	public static object CreateGenericInstance(Type type, Type genericType)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xD049FC", Offset = "0xD049FC", VA = "0xD049FC")]
	public static object CreateGenericInstance(Type type, Type genericType, Type genericType2)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xD06EFC", Offset = "0xD06EFC", VA = "0xD06EFC")]
	public static bool IsCollectionType(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x5AE8C8", Offset = "0x5AE8C8")]
public class ES2Spreadsheet
{
	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<ES2SpreadsheetRow> sheet;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool append;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static byte[] comma;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static byte[] newline;

	[Token(Token = "0x17000016")]
	public string Item
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD07FA8", Offset = "0xD07FA8", VA = "0xD07FA8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD07FAC", Offset = "0xD07FAC", VA = "0xD07FAC")]
		set
		{
		}
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xD07740", Offset = "0xD07740", VA = "0xD07740")]
	public ES2Spreadsheet()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xD078CC", Offset = "0xD078CC", VA = "0xD078CC")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xD07B7C", Offset = "0xD07B7C", VA = "0xD07B7C")]
	public string GetCell(int col, int row)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xD079F0", Offset = "0xD079F0", VA = "0xD079F0")]
	private void SizeSpreadsheetToFitRow(int row)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xD07C54", Offset = "0xD07C54", VA = "0xD07C54")]
	public void Save(string path)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xD07CC4", Offset = "0xD07CC4", VA = "0xD07CC4")]
	public void Save(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xD077D4", Offset = "0xD077D4", VA = "0xD077D4")]
	private static void GetCharacterConstants()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xD07FB0", Offset = "0xD07FB0", VA = "0xD07FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x5AE900", Offset = "0x5AE900")]
public class ES2SpreadsheetRow
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<string> cells;

	[Token(Token = "0x17000017")]
	public int cellCount
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD07F58", Offset = "0xD07F58", VA = "0xD07F58")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000018")]
	public string Item
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD07C50", Offset = "0xD07C50", VA = "0xD07C50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD08380", Offset = "0xD08380", VA = "0xD08380")]
		set
		{
		}
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xD07B00", Offset = "0xD07B00", VA = "0xD07B00")]
	public void SetCell(int col, string value)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xD08168", Offset = "0xD08168", VA = "0xD08168")]
	public string GetCell(int col)
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xD07F40", Offset = "0xD07F40", VA = "0xD07F40")]
	public byte[] GetCellBytes(int col)
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xD080C8", Offset = "0xD080C8", VA = "0xD080C8")]
	private void SizeRowToFitColumn(int col)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xD08224", Offset = "0xD08224", VA = "0xD08224")]
	private byte[] GetBytes(string data)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xD08384", Offset = "0xD08384", VA = "0xD08384", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xD07A90", Offset = "0xD07A90", VA = "0xD07A90")]
	public ES2SpreadsheetRow()
	{
	}
}
[Token(Token = "0x2000017")]
public class ES2Web
{
	[Token(Token = "0x2000089")]
	public enum HashType
	{
		[Token(Token = "0x4000295")]
		MD5,
		[Token(Token = "0x4000296")]
		None
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFEF0", Offset = "0x5AFEF0")]
	private sealed class <Upload>d__18<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T param;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EA")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003EC")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E6")]
		[DebuggerHidden]
		public <Upload>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60003E7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60003EB")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF00", Offset = "0x5AFF00")]
	private sealed class <Upload>d__19<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] param;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F1")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F3")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003ED")]
		[DebuggerHidden]
		public <Upload>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60003EE")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EF")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60003F2")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF10", Offset = "0x5AFF10")]
	private sealed class <Upload>d__20<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[,] param;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FA")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F4")]
		[DebuggerHidden]
		public <Upload>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60003F5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60003F9")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF20", Offset = "0x5AFF20")]
	private sealed class <Upload>d__21<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[,,] param;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FF")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000401")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FB")]
		[DebuggerHidden]
		public <Upload>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60003FC")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003FD")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000400")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF30", Offset = "0x5AFF30")]
	private sealed class <Upload>d__22<TKey, TValue> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<TKey, TValue> param;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000406")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000408")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000402")]
		[DebuggerHidden]
		public <Upload>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000403")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000404")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000405")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000407")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF40", Offset = "0x5AFF40")]
	private sealed class <Upload>d__23<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> param;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600040D")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600040F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000409")]
		[DebuggerHidden]
		public <Upload>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600040A")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040B")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600040E")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF50", Offset = "0x5AFF50")]
	private sealed class <Upload>d__24<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HashSet<T> param;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000414")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000416")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000410")]
		[DebuggerHidden]
		public <Upload>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000411")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000412")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000415")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF60", Offset = "0x5AFF60")]
	private sealed class <Upload>d__25<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Queue<T> param;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600041B")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600041D")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000417")]
		[DebuggerHidden]
		public <Upload>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000418")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000419")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600041C")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF70", Offset = "0x5AFF70")]
	private sealed class <Upload>d__26<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Stack<T> param;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000422")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000424")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041E")]
		[DebuggerHidden]
		public <Upload>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600041F")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000420")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000423")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF80", Offset = "0x5AFF80")]
	private sealed class <UploadRaw>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] data;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0xD0A220", Offset = "0xD0A220", VA = "0xD0A220", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0xD0A288", Offset = "0xD0A288", VA = "0xD0A288", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xD08B70", Offset = "0xD08B70", VA = "0xD08B70")]
		[DebuggerHidden]
		public <UploadRaw>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xD0A120", Offset = "0xD0A120", VA = "0xD0A120", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xD0A124", Offset = "0xD0A124", VA = "0xD0A124", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xD0A228", Offset = "0xD0A228", VA = "0xD0A228", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFF90", Offset = "0x5AFF90")]
	private sealed class <UploadImage>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D tex;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xD0A0B0", Offset = "0xD0A0B0", VA = "0xD0A0B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xD0A118", Offset = "0xD0A118", VA = "0xD0A118", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xD08C18", Offset = "0xD08C18", VA = "0xD08C18")]
		[DebuggerHidden]
		public <UploadImage>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xD09FA4", Offset = "0xD09FA4", VA = "0xD09FA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xD09FA8", Offset = "0xD09FA8", VA = "0xD09FA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xD0A0B8", Offset = "0xD0A0B8", VA = "0xD0A0B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFFA0", Offset = "0x5AFFA0")]
	private sealed class <UploadFile>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string file;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0xD09F34", Offset = "0xD09F34", VA = "0xD09F34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xD09F9C", Offset = "0xD09F9C", VA = "0xD09F9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xD08CC0", Offset = "0xD08CC0", VA = "0xD08CC0")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xD09E08", Offset = "0xD09E08", VA = "0xD09E08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xD09E0C", Offset = "0xD09E0C", VA = "0xD09E0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xD09F3C", Offset = "0xD09F3C", VA = "0xD09F3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFFB0", Offset = "0x5AFFB0")]
	private sealed class <DownloadFilenames>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0xD09D98", Offset = "0xD09D98", VA = "0xD09D98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0xD09E00", Offset = "0xD09E00", VA = "0xD09E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xD091C4", Offset = "0xD091C4", VA = "0xD091C4")]
		[DebuggerHidden]
		public <DownloadFilenames>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xD09C9C", Offset = "0xD09C9C", VA = "0xD09C9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xD09CA0", Offset = "0xD09CA0", VA = "0xD09CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xD09DA0", Offset = "0xD09DA0", VA = "0xD09DA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFFC0", Offset = "0x5AFFC0")]
	private sealed class <Download>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xD09C2C", Offset = "0xD09C2C", VA = "0xD09C2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xD09C94", Offset = "0xD09C94", VA = "0xD09C94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xD09304", Offset = "0xD09304", VA = "0xD09304")]
		[DebuggerHidden]
		public <Download>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xD09B30", Offset = "0xD09B30", VA = "0xD09B30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xD09B34", Offset = "0xD09B34", VA = "0xD09B34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xD09C34", Offset = "0xD09C34", VA = "0xD09C34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AFFD0", Offset = "0x5AFFD0")]
	private sealed class <Delete>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xD09AC0", Offset = "0xD09AC0", VA = "0xD09AC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xD09B28", Offset = "0xD09B28", VA = "0xD09B28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xD093A0", Offset = "0xD093A0", VA = "0xD093A0")]
		[DebuggerHidden]
		public <Delete>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xD0995C", Offset = "0xD0995C", VA = "0xD0995C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xD09960", Offset = "0xD09960", VA = "0xD09960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xD09AC8", Offset = "0xD09AC8", VA = "0xD09AC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool isDone;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool isError;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string error;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string errorCode;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HashType hashType;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES2Settings settings;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WWW www;

	[Token(Token = "0x17000019")]
	public byte[] data
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD0892C", Offset = "0xD0892C", VA = "0xD0892C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public string text
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD08948", Offset = "0xD08948", VA = "0xD08948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001B")]
	public float progress
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD08964", Offset = "0xD08964", VA = "0xD08964")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700001C")]
	public float uploadProgress
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD08980", Offset = "0xD08980", VA = "0xD08980")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xD0899C", Offset = "0xD0899C", VA = "0xD0899C")]
	public ES2Web(string identifier)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xD08A24", Offset = "0xD08A24", VA = "0xD08A24")]
	public ES2Web(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000119")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B073C", Offset = "0x5B073C")]
	public IEnumerator Upload<T>(T param)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B07A0", Offset = "0x5B07A0")]
	public IEnumerator Upload<T>(T[] param)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0804", Offset = "0x5B0804")]
	public IEnumerator Upload<T>(T[,] param)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0868", Offset = "0x5B0868")]
	public IEnumerator Upload<T>(T[,,] param)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B08CC", Offset = "0x5B08CC")]
	public IEnumerator Upload<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0930", Offset = "0x5B0930")]
	public IEnumerator Upload<T>(List<T> param)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0994", Offset = "0x5B0994")]
	public IEnumerator Upload<T>(HashSet<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B09F8", Offset = "0x5B09F8")]
	public IEnumerator Upload<T>(Queue<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0A5C", Offset = "0x5B0A5C")]
	public IEnumerator Upload<T>(Stack<T> param)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xD08AA8", Offset = "0xD08AA8", VA = "0xD08AA8")]
	public IEnumerator UploadRaw(string data)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xD08AF4", Offset = "0xD08AF4", VA = "0xD08AF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0AC0", Offset = "0x5B0AC0")]
	public IEnumerator UploadRaw(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xD08B9C", Offset = "0xD08B9C", VA = "0xD08B9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0B24", Offset = "0x5B0B24")]
	public IEnumerator UploadImage(Texture2D tex)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xD08C44", Offset = "0xD08C44", VA = "0xD08C44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0B88", Offset = "0x5B0B88")]
	public IEnumerator UploadFile(string file)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xD08CEC", Offset = "0xD08CEC", VA = "0xD08CEC")]
	public Texture2D LoadImage()
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xD08EA8", Offset = "0xD08EA8", VA = "0xD08EA8")]
	public byte[] LoadRaw()
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	public T Load<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x6000129")]
	public void Load<T>(string tag, T c) where T : class
	{
	}

	[Token(Token = "0x600012A")]
	public T[] LoadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	public void LoadArray<T>(string tag, T[] c) where T : class
	{
	}

	[Token(Token = "0x600012C")]
	public T[,] Load2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	public T[,,] Load3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	public Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	public List<T> LoadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	public HashSet<T> LoadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	public Queue<T> LoadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	public Stack<T> LoadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xD08EE0", Offset = "0xD08EE0", VA = "0xD08EE0")]
	public void SaveToFile(string identifier)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xD08F6C", Offset = "0xD08F6C", VA = "0xD08F6C")]
	public void SaveToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xD09018", Offset = "0xD09018", VA = "0xD09018")]
	public void AppendToFile(string identifier)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xD090A8", Offset = "0xD090A8", VA = "0xD090A8")]
	public void AppendToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xD09154", Offset = "0xD09154", VA = "0xD09154")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0BEC", Offset = "0x5B0BEC")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xD091F0", Offset = "0xD091F0", VA = "0xD091F0")]
	public string[] GetFilenames()
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xD09294", Offset = "0xD09294", VA = "0xD09294")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0C50", Offset = "0x5B0C50")]
	public IEnumerator Download()
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xD09330", Offset = "0xD09330", VA = "0xD09330")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5B0CB4", Offset = "0x5B0CB4")]
	public IEnumerator Delete()
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xD093CC", Offset = "0xD093CC", VA = "0xD093CC")]
	private WWWForm CreateUploadForm(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xD09584", Offset = "0xD09584", VA = "0xD09584")]
	private WWWForm CreateDownloadForm()
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xD09644", Offset = "0xD09644", VA = "0xD09644")]
	private WWWForm CreateGetFilesForm()
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xD08D7C", Offset = "0xD08D7C", VA = "0xD08D7C")]
	private void CheckWWWUsage()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xD08E0C", Offset = "0xD08E0C", VA = "0xD08E0C")]
	private void CheckDownloadUsage()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xD096BC", Offset = "0xD096BC", VA = "0xD096BC")]
	private bool getError()
	{
		return default(bool);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xD0946C", Offset = "0xD0946C", VA = "0xD0946C")]
	private WWWForm CreateForm()
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xD098BC", Offset = "0xD098BC", VA = "0xD098BC")]
	private static string StringToMD5(string str)
	{
		return null;
	}
}
[Token(Token = "0x2000018")]
public struct ES2Header
{
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ES2Keys.Key collectionType;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int keyType;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int valueType;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x631BF0", Offset = "0x631BF0", VA = "0x631BF0")]
	public ES2Header(ES2Keys.Key collectionType, int keyType, int valueType, ES2Settings settings)
	{
	}
}
[Token(Token = "0x2000019")]
public class ES2Reader : IDisposable
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B02F0", Offset = "0x5B02F0")]
	public ES2Stream stream;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings settings;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0304", Offset = "0x5B0304")]
	private ES2CachedFile cachedFile;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0318", Offset = "0x5B0318")]
	public ES2Tag currentTag;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BinaryReader reader;

	[Token(Token = "0x1700001D")]
	public int Length
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0xD05DF4", Offset = "0xD05DF4", VA = "0xD05DF4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000144")]
	public T Read<T>(ES2Type es2type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000145")]
	public void Read<T>(ES2Type es2type, T c) where T : class
	{
	}

	[Token(Token = "0x6000146")]
	public T[] ReadArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	public void ReadArray<T>(ES2Type type, T[] c) where T : class
	{
	}

	[Token(Token = "0x6000148")]
	public T[,] Read2DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	public T[,,] Read3DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>(ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	public List<T> ReadList<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	public void ReadList<T>(ES2Type type, List<T> c) where T : class
	{
	}

	[Token(Token = "0x600014D")]
	public HashSet<T> ReadHashSet<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	public Queue<T> ReadQueue<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	public Stack<T> ReadStack<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xCFED70", Offset = "0xCFED70", VA = "0xCFED70")]
	public Array ReadSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xCFEF10", Offset = "0xCFEF10", VA = "0xCFEF10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0D18", Offset = "0x5B0D18")]
	public ICollection ReadICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xCFF0C0", Offset = "0xCFF0C0", VA = "0xCFF0C0")]
	public IDictionary ReadIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	private T ReadEncrypted<T>(ES2Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000154")]
	private void ReadEncrypted<T>(ES2Type type, T c) where T : class
	{
	}

	[Token(Token = "0x6000155")]
	private T[] ReadEncryptedArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	private void ReadEncryptedArray<T>(ES2Type type, T[] c) where T : class
	{
	}

	[Token(Token = "0x6000157")]
	private T[,] ReadEncrypted2DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	private T[,,] ReadEncrypted3DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	private Dictionary<TKey, TValue> ReadEncryptedDictionary<TKey, TValue>(ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	private List<T> ReadEncryptedList<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	private void ReadEncryptedList<T>(ES2Type type, List<T> c) where T : class
	{
	}

	[Token(Token = "0x600015C")]
	private HashSet<T> ReadEncryptedHashSet<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	private Queue<T> ReadEncryptedQueue<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	private Stack<T> ReadEncryptedStack<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xD04438", Offset = "0xD04438", VA = "0xD04438")]
	private Array ReadEncryptedSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xD046C4", Offset = "0xD046C4", VA = "0xD046C4")]
	private ICollection ReadEncryptedICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xD048BC", Offset = "0xD048BC", VA = "0xD048BC")]
	private IDictionary ReadEncryptedIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xD04B68", Offset = "0xD04B68", VA = "0xD04B68")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey, string tag)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xD050F8", Offset = "0xD050F8", VA = "0xD050F8")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xD04E80", Offset = "0xD04E80", VA = "0xD04E80")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0D2C", Offset = "0x5B0D2C")]
	public ES2Header ReadHeader()
	{
		return default(ES2Header);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xD05340", Offset = "0xD05340", VA = "0xD05340")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0D40", Offset = "0x5B0D40")]
	public bool Next()
	{
		return default(bool);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xD054EC", Offset = "0xD054EC", VA = "0xD054EC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0D54", Offset = "0x5B0D54")]
	public void Skip()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xD05520", Offset = "0xD05520", VA = "0xD05520")]
	protected bool WriteBytesBeforeTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xD055EC", Offset = "0xD055EC", VA = "0xD055EC")]
	protected bool WriteRemainingBytes(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xD0571C", Offset = "0xD0571C", VA = "0xD0571C")]
	protected bool WriteBytesBeforeTagLowMemory(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xD058E0", Offset = "0xD058E0", VA = "0xD058E0")]
	protected bool WriteRemainingBytesLowMemory(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xD05AB0", Offset = "0xD05AB0", VA = "0xD05AB0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0D68", Offset = "0x5B0D68")]
	public bool RenameTag(string oldTag, string newTag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xD05D14", Offset = "0xD05D14", VA = "0xD05D14")]
	protected bool DeleteTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xD05ED0", Offset = "0xD05ED0", VA = "0xD05ED0")]
	protected void WriteCurrentTag(ES2Writer writer)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xD05F4C", Offset = "0xD05F4C", VA = "0xD05F4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0D7C", Offset = "0x5B0D7C")]
	public bool DeleteTags(ICollection<string> tags, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xD015C0", Offset = "0xD015C0", VA = "0xD015C0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0D90", Offset = "0x5B0D90")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xD062F4", Offset = "0xD062F4", VA = "0xD062F4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0DA4", Offset = "0x5B0DA4")]
	public byte[] ReadMeshSettings()
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xD0633C", Offset = "0xD0633C", VA = "0xD0633C")]
	private byte[] GetDecryptedBytes()
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xD04AF0", Offset = "0xD04AF0", VA = "0xD04AF0")]
	private ES2Reader GetEncryptedReader()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xD05E24", Offset = "0xD05E24", VA = "0xD05E24")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0DB8", Offset = "0x5B0DB8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xD064C8", Offset = "0xD064C8", VA = "0xD064C8", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xCF5F08", Offset = "0xCF5F08", VA = "0xCF5F08")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0DCC", Offset = "0x5B0DCC")]
	public void CacheFile()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xD04D7C", Offset = "0xD04D7C", VA = "0xD04D7C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0DE0", Offset = "0x5B0DE0")]
	public bool ScanToTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xD064E8", Offset = "0xD064E8", VA = "0xD064E8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0DF4", Offset = "0x5B0DF4")]
	public bool ScanToTag()
	{
		return default(bool);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xD01360", Offset = "0xD01360", VA = "0xD01360")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xD010A8", Offset = "0xD010A8", VA = "0xD010A8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0E08", Offset = "0x5B0E08")]
	public bool TagExists()
	{
		return default(bool);
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xCF4F10", Offset = "0xCF4F10", VA = "0xCF4F10")]
	public byte[] ReadRaw()
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	public T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600017D")]
	public void Read<T>(T c) where T : class
	{
	}

	[Token(Token = "0x600017E")]
	public T[] ReadArray<T>()
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	public void ReadArray<T>(T[] c) where T : class
	{
	}

	[Token(Token = "0x6000180")]
	public T[,] Read2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	public T[,,] Read3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	public List<T> ReadList<T>()
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	public void ReadList<T>(List<T> c) where T : class
	{
	}

	[Token(Token = "0x6000185")]
	public HashSet<T> ReadHashSet<T>()
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	public Queue<T> ReadQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	public Stack<T> ReadStack<T>()
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	public T Read<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x6000189")]
	public void Read<T>(string tag, T c) where T : class
	{
	}

	[Token(Token = "0x600018A")]
	public T[] ReadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	public void ReadArray<T>(string tag, T[] c) where T : class
	{
	}

	[Token(Token = "0x600018C")]
	public T[,] Read2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	public T[,,] Read3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	public List<T> ReadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	public void ReadList<T>(string tag, List<T> c) where T : class
	{
	}

	[Token(Token = "0x6000191")]
	public HashSet<T> ReadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	public Queue<T> ReadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	public Stack<T> ReadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xCF54AC", Offset = "0xCF54AC", VA = "0xCF54AC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0E1C", Offset = "0x5B0E1C")]
	public ES2Data ReadAll()
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xD06504", Offset = "0xD06504", VA = "0xD06504")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0E30", Offset = "0x5B0E30")]
	public object ReadObject()
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xD067FC", Offset = "0xD067FC", VA = "0xD067FC")]
	public void ReadObject(object obj)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xCF51D0", Offset = "0xCF51D0", VA = "0xCF51D0")]
	public object ReadObject(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xD068DC", Offset = "0xD068DC", VA = "0xD068DC")]
	public void ReadObject(string tag, object obj)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xD06944", Offset = "0xD06944", VA = "0xD06944")]
	public void ReadComponent(GameObject go)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xD06AA0", Offset = "0xD06AA0", VA = "0xD06AA0")]
	public void ReadComponent(string tag, GameObject go)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xD06B08", Offset = "0xD06B08", VA = "0xD06B08")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0E44", Offset = "0x5B0E44")]
	public Dictionary<string, ES2Header> ReadAllHeaders()
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0E58", Offset = "0x5B0E58")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600019D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0E6C", Offset = "0x5B0E6C")]
	public T ReadProperty<T>(T obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0E80", Offset = "0x5B0E80")]
	public T[] ReadPropertyArray<T>()
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0E94", Offset = "0x5B0E94")]
	public T[] ReadPropertyArray<T>(T[] obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0EA8", Offset = "0x5B0EA8")]
	public T[,] ReadProperty2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0EBC", Offset = "0x5B0EBC")]
	public T[,,] ReadProperty3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0ED0", Offset = "0x5B0ED0")]
	public List<T> ReadPropertyList<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0EE4", Offset = "0x5B0EE4")]
	public Queue<T> ReadPropertyQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0EF8", Offset = "0x5B0EF8")]
	public Stack<T> ReadPropertyStack<T>()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0F0C", Offset = "0x5B0F0C")]
	public Dictionary<TKey, TValue> ReadPropertyDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xD04560", Offset = "0xD04560", VA = "0xD04560")]
	private static int[] GetMultidimensionalIndices(Array a, int idx)
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xD06BF4", Offset = "0xD06BF4", VA = "0xD06BF4")]
	public static ES2Reader Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xCFB1CC", Offset = "0xCFB1CC", VA = "0xCFB1CC")]
	public static ES2Reader Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xCF4EB0", Offset = "0xCF4EB0", VA = "0xCF4EB0")]
	public static ES2Reader Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xD06458", Offset = "0xD06458", VA = "0xD06458")]
	public static ES2Reader Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xD06C54", Offset = "0xD06C54", VA = "0xD06C54")]
	public ES2Reader(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xD012A0", Offset = "0xD012A0", VA = "0xD012A0")]
	public ES2Reader(byte[] bytes, ES2Settings settings)
	{
	}
}
[Token(Token = "0x200001A")]
public class ES2InvalidDataException : Exception
{
	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xD033C4", Offset = "0xD033C4", VA = "0xD033C4")]
	public ES2InvalidDataException()
	{
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE938", Offset = "0x5AE938")]
public struct ES2FilenameData
{
	[Token(Token = "0x2000099")]
	public enum PathType
	{
		[Token(Token = "0x40002DA")]
		File,
		[Token(Token = "0x40002DB")]
		Folder,
		[Token(Token = "0x40002DC")]
		URL
	}

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string fullString;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string persistentPath;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string userFolder;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filename;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string extension;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string tag;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string playerPrefsPath;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string filePath;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public PathType pathType;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool isAbsolute;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string persistentDataPath;

	[Token(Token = "0x1700001E")]
	public string directoryPath
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x631BA4", Offset = "0x631BA4", VA = "0x631BA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public string resourcesPath
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x631BAC", Offset = "0x631BAC", VA = "0x631BAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x631B18", Offset = "0x631B18", VA = "0x631B18")]
	public ES2FilenameData(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x631B24", Offset = "0x631B24", VA = "0x631B24")]
	public ES2FilenameData(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x631B2C", Offset = "0x631B2C", VA = "0x631B2C")]
	public void Init(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x631B38", Offset = "0x631B38", VA = "0x631B38")]
	private void ProcessParameter(string name, string value, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xD0249C", Offset = "0xD0249C", VA = "0xD0249C")]
	private static PathType GetPathType(string path)
	{
		return default(PathType);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xD02DBC", Offset = "0xD02DBC", VA = "0xD02DBC")]
	private static bool PathIsURL(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xD023D8", Offset = "0xD023D8", VA = "0xD023D8")]
	private static bool PathIsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xD02F54", Offset = "0xD02F54", VA = "0xD02F54")]
	private static bool PathIsFolder(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x631B40", Offset = "0x631B40", VA = "0x631B40")]
	public bool HasTag()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xCF68C0", Offset = "0xCF68C0", VA = "0xCF68C0")]
	public static string GetPersistentPath()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x631B64", Offset = "0x631B64", VA = "0x631B64")]
	public bool IsURL()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x631B74", Offset = "0x631B74", VA = "0x631B74")]
	public bool IsFolder()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x631B84", Offset = "0x631B84", VA = "0x631B84")]
	public bool IsFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x631B94", Offset = "0x631B94", VA = "0x631B94")]
	public bool IsAbsolute()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x631B9C", Offset = "0x631B9C", VA = "0x631B9C")]
	public string GetSavePath(ES2Settings.SaveLocation saveLocation)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE94C", Offset = "0x5AE94C")]
public sealed class ES2GlobalSettings : MonoBehaviour
{
	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool hasInitialized;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static ES2Settings.SaveLocation _defaultSaveLocation;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static ES2Settings.OptimizeMode defaultOptimizeMode;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static ES2Settings.Format defaultFormat;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string defaultPCDataPath;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string defaultMacDataPath;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static bool defaultEncrypt;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string defaultEncryptionPassword;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static ES2Settings.EncryptionType defaultEncryptionType;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string defaultWebUsername;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string defaultWebPassword;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string defaultWebFilename;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static int defaultBufferSize;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings.SaveLocation saveLocation;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ES2Settings.OptimizeMode optimizeMode;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string PCDataPath;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string MacDataPath;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool encrypt;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string encryptionPassword;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ES2Settings.EncryptionType encryptionType;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string webUsername;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string webPassword;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int bufferSize;

	[Token(Token = "0x17000020")]
	public static ES2Settings.SaveLocation defaultSaveLocation
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xCF6840", Offset = "0xCF6840", VA = "0xCF6840")]
		get
		{
			return default(ES2Settings.SaveLocation);
		}
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD03080", Offset = "0xD03080", VA = "0xD03080")]
		set
		{
		}
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xD030EC", Offset = "0xD030EC", VA = "0xD030EC")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xD032A8", Offset = "0xD032A8", VA = "0xD032A8")]
	public ES2GlobalSettings()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE960", Offset = "0x5AE960")]
public static class ES2Keys
{
	[Token(Token = "0x200009A")]
	public enum Key : byte
	{
		[Token(Token = "0x40002DE")]
		_NativeArray = 81,
		[Token(Token = "0x40002DF")]
		_Dictionary = 82,
		[Token(Token = "0x40002E0")]
		_List = 83,
		[Token(Token = "0x40002E1")]
		_HashSet = 84,
		[Token(Token = "0x40002E2")]
		_Queue = 85,
		[Token(Token = "0x40002E3")]
		_Stack = 86,
		[Token(Token = "0x40002E4")]
		_Obfuscate = 121,
		[Token(Token = "0x40002E5")]
		_Size = 122,
		[Token(Token = "0x40002E6")]
		_Terminator = 123,
		[Token(Token = "0x40002E7")]
		_Null = 124,
		[Token(Token = "0x40002E8")]
		_Settings = 125,
		[Token(Token = "0x40002E9")]
		_Tag = 126,
		[Token(Token = "0x40002EA")]
		_Encrypt = 127
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xD03438", Offset = "0xD03438", VA = "0xD03438")]
	public static string TypeFromKeys(Key collection, Key value, Key key)
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xD03888", Offset = "0xD03888", VA = "0xD03888")]
	public static Key[] KeysFromType(Key collectionType, Key valueType, Key keyType)
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xD03924", Offset = "0xD03924", VA = "0xD03924")]
	public static Key KeyFromES2Type(ES2Type type)
	{
		return default(Key);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xD03938", Offset = "0xD03938", VA = "0xD03938")]
	public static Key[] KeysFromES2Type(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xD03954", Offset = "0xD03954", VA = "0xD03954")]
	public static Key[] KeysFromES2Type(ES2Type type, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xD03974", Offset = "0xD03974", VA = "0xD03974")]
	public static Key[] KeysFromES2Type(ES2Type keyType, ES2Type valueType, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xCFC98C", Offset = "0xCFC98C", VA = "0xCFC98C")]
	public static Key GetCollectionType(Type type)
	{
		return default(Key);
	}
}
[Token(Token = "0x200001E")]
public sealed class ES2Settings
{
	[Token(Token = "0x200009B")]
	public enum OptimizeMode
	{
		[Token(Token = "0x40002EC")]
		Fast,
		[Token(Token = "0x40002ED")]
		LowMemory
	}

	[Token(Token = "0x200009C")]
	public enum SaveLocation
	{
		[Token(Token = "0x40002EF")]
		PlayerPrefs,
		[Token(Token = "0x40002F0")]
		File,
		[Token(Token = "0x40002F1")]
		Resources,
		[Token(Token = "0x40002F2")]
		Memory
	}

	[Token(Token = "0x200009D")]
	public enum Format
	{
		[Token(Token = "0x40002F4")]
		Binary
	}

	[Token(Token = "0x200009E")]
	public enum EncryptionType
	{
		[Token(Token = "0x40002F6")]
		AES128,
		[Token(Token = "0x40002F7")]
		Obfuscate
	}

	[Token(Token = "0x200009F")]
	public enum ES2FileMode
	{
		[Token(Token = "0x40002F9")]
		Create,
		[Token(Token = "0x40002FA")]
		Append,
		[Token(Token = "0x40002FB")]
		Open
	}

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B032C", Offset = "0x5B032C")]
	public ES2FilenameData filenameData;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public SaveLocation saveLocation;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public OptimizeMode optimizeMode;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Format format;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool encrypt;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string encryptionPassword;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public EncryptionType encryptionType;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string webUsername;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string webPassword;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string webFilename;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool saveNormals;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool saveUV;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	public bool saveUV2;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	public bool saveTangents;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool saveSubmeshes;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool saveSkinning;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool saveColors;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x97")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0340", Offset = "0x5B0340")]
	public byte meshSettingsCount;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string name;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0354", Offset = "0x5B0354")]
	public ES2FileMode fileMode;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int bufferSize;

	[Token(Token = "0x17000021")]
	public string tag
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD00D8C", Offset = "0xD00D8C", VA = "0xD00D8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xD07738", Offset = "0xD07738", VA = "0xD07738")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1810", Offset = "0x5B1810")]
	public bool IsImageFile
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xCF58AC", Offset = "0xCF58AC", VA = "0xCF58AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xD07268", Offset = "0xD07268", VA = "0xD07268")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0F20", Offset = "0x5B0F20")]
	public void Init()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xD0737C", Offset = "0xD0737C", VA = "0xD0737C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0F34", Offset = "0x5B0F34")]
	public ES2Settings Clone()
	{
		return null;
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xCF41A0", Offset = "0xCF41A0", VA = "0xCF41A0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0F48", Offset = "0x5B0F48")]
	public ES2Settings Clone(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xD07498", Offset = "0xD07498", VA = "0xD07498")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0F5C", Offset = "0x5B0F5C")]
	public byte[] MeshSettingsToByteArray()
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xD0758C", Offset = "0xD0758C", VA = "0xD0758C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0F70", Offset = "0x5B0F70")]
	public void MeshSettingsFromByteArray(byte[] bytes)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xCF3F3C", Offset = "0xCF3F3C", VA = "0xCF3F3C")]
	public ES2Settings(string identifier)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xD0118C", Offset = "0xD0118C", VA = "0xD0118C")]
	public ES2Settings(SaveLocation saveLocation)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xCFACA0", Offset = "0xCFACA0", VA = "0xCFACA0")]
	public ES2Settings()
	{
	}
}
[Token(Token = "0x200001F")]
internal sealed class ES2FileStream : ES2Stream
{
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xD01688", Offset = "0xD01688", VA = "0xD01688")]
	public ES2FileStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xD0185C", Offset = "0xD0185C", VA = "0xD0185C", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xD01A04", Offset = "0xD01A04", VA = "0xD01A04")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xD01780", Offset = "0xD01780", VA = "0xD01780")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xD016E0", Offset = "0xD016E0", VA = "0xD016E0")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xD01C78", Offset = "0xD01C78", VA = "0xD01C78", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000020")]
internal sealed class ES2MemoryStream : ES2Stream
{
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public byte[] storedBytes;

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xD039E0", Offset = "0xD039E0", VA = "0xD039E0")]
	public ES2MemoryStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xD03A5C", Offset = "0xD03A5C", VA = "0xD03A5C")]
	public ES2MemoryStream(byte[] bytes, ES2Settings settings)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xD03AD8", Offset = "0xD03AD8", VA = "0xD03AD8")]
	public ES2MemoryStream()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xD03B60", Offset = "0xD03B60", VA = "0xD03B60", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xD03CD8", Offset = "0xD03CD8", VA = "0xD03CD8", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xD03CE0", Offset = "0xD03CE0", VA = "0xD03CE0", Slot = "6")]
	public override byte[] ReadAllBytes()
	{
		return null;
	}
}
[Token(Token = "0x2000021")]
internal sealed class ES2PlayerPrefsStream : ES2Stream
{
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xD03DAC", Offset = "0xD03DAC", VA = "0xD03DAC")]
	public ES2PlayerPrefsStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xD03F60", Offset = "0xD03F60", VA = "0xD03F60", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xD04364", Offset = "0xD04364", VA = "0xD04364")]
	private void StoreRaw()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xD042D0", Offset = "0xD042D0", VA = "0xD042D0")]
	private void StoreRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xD043F8", Offset = "0xD043F8", VA = "0xD043F8")]
	private void StoreRaw(string bytes)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xD041F0", Offset = "0xD041F0", VA = "0xD041F0")]
	private void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xD04194", Offset = "0xD04194", VA = "0xD04194")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xD03DFC", Offset = "0xD03DFC", VA = "0xD03DFC")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xD03F04", Offset = "0xD03F04", VA = "0xD03F04")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xD04418", Offset = "0xD04418", VA = "0xD04418", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000022")]
internal sealed class ES2ResourcesStream : ES2Stream
{
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xD06FDC", Offset = "0xD06FDC", VA = "0xD06FDC")]
	public ES2ResourcesStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xD07188", Offset = "0xD07188", VA = "0xD07188", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xD071F4", Offset = "0xD071F4", VA = "0xD071F4", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000023")]
public abstract class ES2Stream
{
	[Token(Token = "0x20000A0")]
	public enum Operation
	{
		[Token(Token = "0x40002FD")]
		Read,
		[Token(Token = "0x40002FE")]
		Write
	}

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Stream stream;

	[Token(Token = "0x17000023")]
	public long Length
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xD054CC", Offset = "0xD054CC", VA = "0xD054CC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xD08484", Offset = "0xD08484", VA = "0xD08484")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public long Position
	{
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xCFE300", Offset = "0xCFE300", VA = "0xCFE300")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xCFE84C", Offset = "0xCFE84C", VA = "0xCFE84C")]
		set
		{
		}
	}

	[Token(Token = "0x60001F0")]
	public abstract void Store();

	[Token(Token = "0x60001F1")]
	public abstract bool MayRequireOverwrite();

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xD05688", Offset = "0xD05688", VA = "0xD05688")]
	public byte[] ReadBytes(int count)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xD03CF4", Offset = "0xD03CF4", VA = "0xD03CF4", Slot = "6")]
	public virtual byte[] ReadAllBytes()
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xD01A68", Offset = "0xD01A68", VA = "0xD01A68")]
	protected void WriteToStreamFast(Stream writableStream)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xD01AD8", Offset = "0xD01AD8", VA = "0xD01AD8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0F84", Offset = "0x5B0F84")]
	protected void WriteToStreamLowMemory(Stream writableStream)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xD06E9C", Offset = "0xD06E9C", VA = "0xD06E9C")]
	public static ES2Stream Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xD06D48", Offset = "0xD06D48", VA = "0xD06D48")]
	public static ES2Stream Create(ES2Settings settings, Operation operation)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xD016D8", Offset = "0xD016D8", VA = "0xD016D8")]
	protected ES2Stream()
	{
	}
}
[Token(Token = "0x2000024")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE974", Offset = "0x5AE974")]
public sealed class ES2_BoneWeight : ES2Type
{
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xD0B150", Offset = "0xD0B150", VA = "0xD0B150")]
	public ES2_BoneWeight()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xD0B1F8", Offset = "0xD0B1F8", VA = "0xD0B1F8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xD0B374", Offset = "0xD0B374", VA = "0xD0B374", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000025")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE988", Offset = "0x5AE988")]
public sealed class ES2_Bounds : ES2Type
{
	[Token(Token = "0x6000200")]
	[Address(RVA = "0xD0B518", Offset = "0xD0B518", VA = "0xD0B518")]
	public ES2_Bounds()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xD0B5C0", Offset = "0xD0B5C0", VA = "0xD0B5C0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xD0B69C", Offset = "0xD0B69C", VA = "0xD0B69C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE99C", Offset = "0x5AE99C")]
public sealed class ES2_Color : ES2Type
{
	[Token(Token = "0x6000203")]
	[Address(RVA = "0xD0BF50", Offset = "0xD0BF50", VA = "0xD0BF50")]
	public ES2_Color()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xD0BFF8", Offset = "0xD0BFF8", VA = "0xD0BFF8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xD0C0D4", Offset = "0xD0C0D4", VA = "0xD0C0D4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE9B0", Offset = "0x5AE9B0")]
public sealed class ES2_Color32 : ES2Type
{
	[Token(Token = "0x6000206")]
	[Address(RVA = "0xD0C1DC", Offset = "0xD0C1DC", VA = "0xD0C1DC")]
	public ES2_Color32()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xD0C284", Offset = "0xD0C284", VA = "0xD0C284", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xD0C364", Offset = "0xD0C364", VA = "0xD0C364", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000028")]
public class ES2_DateTime : ES2Type
{
	[Token(Token = "0x6000209")]
	[Address(RVA = "0xD0C460", Offset = "0xD0C460", VA = "0xD0C460", Slot = "4")]
	public override void Write(object obj, ES2Writer writer)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xD0C514", Offset = "0xD0C514", VA = "0xD0C514", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xD0C5A8", Offset = "0xD0C5A8", VA = "0xD0C5A8")]
	public ES2_DateTime()
	{
	}
}
[Token(Token = "0x2000029")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE9C4", Offset = "0x5AE9C4")]
public sealed class ES2_ES2AutoSaveManager : ES2Type
{
	[Token(Token = "0x600020C")]
	[Address(RVA = "0xD0C648", Offset = "0xD0C648", VA = "0xD0C648")]
	public ES2_ES2AutoSaveManager()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xD0C6E8", Offset = "0xD0C6E8", VA = "0xD0C6E8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xD0C780", Offset = "0xD0C780", VA = "0xD0C780", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xD0C7A4", Offset = "0xD0C7A4", VA = "0xD0C7A4", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE9D8", Offset = "0x5AE9D8")]
public sealed class ES2_Enum : ES2Type
{
	[Token(Token = "0x6000210")]
	[Address(RVA = "0xD0881C", Offset = "0xD0881C", VA = "0xD0881C")]
	public ES2_Enum()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xD0C848", Offset = "0xD0C848", VA = "0xD0C848", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xD0C8E8", Offset = "0xD0C8E8", VA = "0xD0C8E8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AE9EC", Offset = "0x5AE9EC")]
public sealed class ES2_Gradient : ES2Type
{
	[Token(Token = "0x6000213")]
	[Address(RVA = "0xD0C96C", Offset = "0xD0C96C", VA = "0xD0C96C")]
	public ES2_Gradient()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xD0CA0C", Offset = "0xD0CA0C", VA = "0xD0CA0C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xD0CAE4", Offset = "0xD0CAE4", VA = "0xD0CAE4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEA00", Offset = "0x5AEA00")]
public sealed class ES2_GradientAlphaKey : ES2Type
{
	[Token(Token = "0x6000216")]
	[Address(RVA = "0xDAA500", Offset = "0xDAA500", VA = "0xDAA500")]
	public ES2_GradientAlphaKey()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xDAA584", Offset = "0xDAA584", VA = "0xDAA584", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xDAA634", Offset = "0xDAA634", VA = "0xDAA634", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEA14", Offset = "0x5AEA14")]
public sealed class ES2_GradientColorKey : ES2Type
{
	[Token(Token = "0x6000219")]
	[Address(RVA = "0xDAA6F4", Offset = "0xDAA6F4", VA = "0xDAA6F4")]
	public ES2_GradientColorKey()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xDAA778", Offset = "0xDAA778", VA = "0xDAA778", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xDAA8A0", Offset = "0xDAA8A0", VA = "0xDAA8A0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200002E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEA28", Offset = "0x5AEA28")]
public sealed class ES2_Material : ES2Type
{
	[Token(Token = "0x600021C")]
	[Address(RVA = "0xDAA988", Offset = "0xDAA988", VA = "0xDAA988")]
	public ES2_Material()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xDAAA18", Offset = "0xDAAA18", VA = "0xDAAA18", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xDAB574", Offset = "0xDAB574", VA = "0xDAB574", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xDAB618", Offset = "0xDAB618", VA = "0xDAB618", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEA3C", Offset = "0x5AEA3C")]
public sealed class ES2_Matrix4x4 : ES2Type
{
	[Token(Token = "0x6000220")]
	[Address(RVA = "0xDAB9AC", Offset = "0xDAB9AC", VA = "0xDAB9AC")]
	public ES2_Matrix4x4()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xDABA3C", Offset = "0xDABA3C", VA = "0xDABA3C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xDABB5C", Offset = "0xDABB5C", VA = "0xDABB5C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEA50", Offset = "0x5AEA50")]
public sealed class ES2_Mesh : ES2Type
{
	[Token(Token = "0x6000223")]
	[Address(RVA = "0xDABC54", Offset = "0xDABC54", VA = "0xDABC54")]
	public ES2_Mesh()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xDABCE4", Offset = "0xDABCE4", VA = "0xDABCE4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xDABFC4", Offset = "0xDABFC4", VA = "0xDABFC4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xDAC048", Offset = "0xDAC048", VA = "0xDAC048", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEA64", Offset = "0x5AEA64")]
public sealed class ES2_Quaternion : ES2Type
{
	[Token(Token = "0x6000227")]
	[Address(RVA = "0xDACE30", Offset = "0xDACE30", VA = "0xDACE30")]
	public ES2_Quaternion()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xDACEC0", Offset = "0xDACEC0", VA = "0xDACEC0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xDACFC8", Offset = "0xDACFC8", VA = "0xDACFC8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEA78", Offset = "0x5AEA78")]
public sealed class ES2_Rect : ES2Type
{
	[Token(Token = "0x600022A")]
	[Address(RVA = "0xDAD0D0", Offset = "0xDAD0D0", VA = "0xDAD0D0")]
	public ES2_Rect()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xDAD160", Offset = "0xDAD160", VA = "0xDAD160", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xDAD260", Offset = "0xDAD260", VA = "0xDAD260", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEA8C", Offset = "0x5AEA8C")]
public sealed class ES2_Sprite : ES2Type
{
	[Token(Token = "0x600022D")]
	[Address(RVA = "0xDADBEC", Offset = "0xDADBEC", VA = "0xDADBEC")]
	public ES2_Sprite()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xDADC7C", Offset = "0xDADC7C", VA = "0xDADC7C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xDADEE8", Offset = "0xDADEE8", VA = "0xDADEE8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEAA0", Offset = "0x5AEAA0")]
public sealed class ES2_Texture : ES2Type
{
	[Token(Token = "0x6000230")]
	[Address(RVA = "0xDAE00C", Offset = "0xDAE00C", VA = "0xDAE00C")]
	public ES2_Texture()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xDAE090", Offset = "0xDAE090", VA = "0xDAE090", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xDAE1DC", Offset = "0xDAE1DC", VA = "0xDAE1DC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xDAE314", Offset = "0xDAE314", VA = "0xDAE314", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000035")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEAB4", Offset = "0x5AEAB4")]
public sealed class ES2_Texture2D : ES2Type
{
	[Token(Token = "0x6000234")]
	[Address(RVA = "0xDAE44C", Offset = "0xDAE44C", VA = "0xDAE44C")]
	public ES2_Texture2D()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xDAE4DC", Offset = "0xDAE4DC", VA = "0xDAE4DC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xDAE660", Offset = "0xDAE660", VA = "0xDAE660", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xDAE6EC", Offset = "0xDAE6EC", VA = "0xDAE6EC", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEAC8", Offset = "0x5AEAC8")]
public sealed class ES2_Vector2 : ES2Type
{
	[Token(Token = "0x6000238")]
	[Address(RVA = "0xDAC534", Offset = "0xDAC534", VA = "0xDAC534")]
	public ES2_Vector2()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xDAEC98", Offset = "0xDAEC98", VA = "0xDAEC98", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xDAED58", Offset = "0xDAED58", VA = "0xDAED58", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000037")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEADC", Offset = "0x5AEADC")]
public sealed class ES2_Vector3 : ES2Type
{
	[Token(Token = "0x600023B")]
	[Address(RVA = "0xDAC414", Offset = "0xDAC414", VA = "0xDAC414")]
	public ES2_Vector3()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xDAEE18", Offset = "0xDAEE18", VA = "0xDAEE18", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xDAEEFC", Offset = "0xDAEEFC", VA = "0xDAEEFC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000038")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEAF0", Offset = "0x5AEAF0")]
public sealed class ES2_Vector4 : ES2Type
{
	[Token(Token = "0x600023E")]
	[Address(RVA = "0xDAC5C4", Offset = "0xDAC5C4", VA = "0xDAC5C4")]
	public ES2_Vector4()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xDAEFE8", Offset = "0xDAEFE8", VA = "0xDAEFE8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xDAF0F0", Offset = "0xDAF0F0", VA = "0xDAF0F0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEB04", Offset = "0x5AEB04")]
public sealed class ES2_BoxCollider : ES2Type
{
	[Token(Token = "0x6000241")]
	[Address(RVA = "0xD0B778", Offset = "0xD0B778", VA = "0xD0B778")]
	public ES2_BoxCollider()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xD0B820", Offset = "0xD0B820", VA = "0xD0B820", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xD0B92C", Offset = "0xD0B92C", VA = "0xD0B92C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xD0B9A8", Offset = "0xD0B9A8", VA = "0xD0B9A8", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEB18", Offset = "0x5AEB18")]
public sealed class ES2_CapsuleCollider : ES2Type
{
	[Token(Token = "0x6000245")]
	[Address(RVA = "0xD0BAF8", Offset = "0xD0BAF8", VA = "0xD0BAF8")]
	public ES2_CapsuleCollider()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xD0BBA0", Offset = "0xD0BBA0", VA = "0xD0BBA0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xD0BD10", Offset = "0xD0BD10", VA = "0xD0BD10", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xD0BD8C", Offset = "0xD0BD8C", VA = "0xD0BD8C", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEB2C", Offset = "0x5AEB2C")]
public sealed class ES2_MeshCollider : ES2Type
{
	[Token(Token = "0x6000249")]
	[Address(RVA = "0xDAC654", Offset = "0xDAC654", VA = "0xDAC654")]
	public ES2_MeshCollider()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xDAC6E4", Offset = "0xDAC6E4", VA = "0xDAC6E4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xDAC828", Offset = "0xDAC828", VA = "0xDAC828", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xDAC8A4", Offset = "0xDAC8A4", VA = "0xDAC8A4", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEB40", Offset = "0x5AEB40")]
public sealed class ES2_PolygonCollider2D : ES2Type
{
	[Token(Token = "0x600024D")]
	[Address(RVA = "0xDACA38", Offset = "0xDACA38", VA = "0xDACA38")]
	public ES2_PolygonCollider2D()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xDACAC8", Offset = "0xDACAC8", VA = "0xDACAC8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xDACC38", Offset = "0xDACC38", VA = "0xDACC38", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xDACCB4", Offset = "0xDACCB4", VA = "0xDACCB4", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEB54", Offset = "0x5AEB54")]
public sealed class ES2_SkinnedMeshRenderer : ES2Type
{
	[Token(Token = "0x6000251")]
	[Address(RVA = "0xDAD368", Offset = "0xDAD368", VA = "0xDAD368")]
	public ES2_SkinnedMeshRenderer()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xDAD3F8", Offset = "0xDAD3F8", VA = "0xDAD3F8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xDAD5B0", Offset = "0xDAD5B0", VA = "0xDAD5B0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xDAD62C", Offset = "0xDAD62C", VA = "0xDAD62C", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEB68", Offset = "0x5AEB68")]
public sealed class ES2_SphereCollider : ES2Type
{
	[Token(Token = "0x6000255")]
	[Address(RVA = "0xDAD868", Offset = "0xDAD868", VA = "0xDAD868")]
	public ES2_SphereCollider()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xDAD8F8", Offset = "0xDAD8F8", VA = "0xDAD8F8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xDADA14", Offset = "0xDADA14", VA = "0xDADA14", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xDADA90", Offset = "0xDADA90", VA = "0xDADA90", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200003F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEB7C", Offset = "0x5AEB7C")]
public sealed class ES2_Transform : ES2Type
{
	[Token(Token = "0x6000259")]
	[Address(RVA = "0xDAE8CC", Offset = "0xDAE8CC", VA = "0xDAE8CC")]
	public ES2_Transform()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xDAE95C", Offset = "0xDAE95C", VA = "0xDAE95C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xDAEA8C", Offset = "0xDAEA8C", VA = "0xDAEA8C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xDAEB08", Offset = "0xDAEB08", VA = "0xDAEB08", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000040")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEB90", Offset = "0x5AEB90")]
public abstract class ES2Type
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public byte key;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int hash;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Type type;

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xD084A8", Offset = "0xD084A8", VA = "0xD084A8")]
	public ES2Type(Type type)
	{
	}

	[Token(Token = "0x600025E")]
	public abstract void Write(object data, ES2Writer writer);

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xD0850C", Offset = "0xD0850C", VA = "0xD0850C", Slot = "5")]
	public virtual object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xD085C4", Offset = "0xD085C4", VA = "0xD085C4", Slot = "6")]
	public virtual void Read(ES2Reader reader, object c)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xD08674", Offset = "0xD08674", VA = "0xD08674", Slot = "7")]
	public virtual void Read(ES2Reader reader, Component c)
	{
	}

	[Token(Token = "0x6000262")]
	public static T GetOrCreate<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xD084E8", Offset = "0xD084E8", VA = "0xD084E8")]
	public static int GetHash(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xD08680", Offset = "0xD08680", VA = "0xD08680")]
	public static int GetHash(string value)
	{
		return default(int);
	}
}
[Token(Token = "0x2000041")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEBA4", Offset = "0x5AEBA4")]
public static class ES2TypeManager
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<Type, ES2Type> types;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES2Type cachedType;

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xD08770", Offset = "0xD08770", VA = "0xD08770")]
	public static void AddES2Type(ES2Type es2Type)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xCFCC04", Offset = "0xCFCC04", VA = "0xCFCC04")]
	public static ES2Type GetES2Type(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xD05114", Offset = "0xD05114", VA = "0xD05114")]
	public static ES2Type GetES2Type(byte key)
	{
		return null;
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xD088C4", Offset = "0xD088C4", VA = "0xD088C4")]
	public static ES2Type GetES2Type(ES2Keys.Key key)
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xCFE620", Offset = "0xCFE620", VA = "0xCFE620")]
	public static ES2Type GetES2Type(int hash)
	{
		return null;
	}
}
[Token(Token = "0x2000042")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEBB8", Offset = "0x5AEBB8")]
public sealed class ES2_bool : ES2Type
{
	[Token(Token = "0x600026B")]
	[Address(RVA = "0xDAF1F8", Offset = "0xDAF1F8", VA = "0xDAF1F8")]
	public ES2_bool()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xDAF288", Offset = "0xDAF288", VA = "0xDAF288", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xDAF324", Offset = "0xDAF324", VA = "0xDAF324", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEBCC", Offset = "0x5AEBCC")]
public sealed class ES2_byte : ES2Type
{
	[Token(Token = "0x600026E")]
	[Address(RVA = "0xDAF3A8", Offset = "0xDAF3A8", VA = "0xDAF3A8")]
	public ES2_byte()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xDAF434", Offset = "0xDAF434", VA = "0xDAF434", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xDAF4D0", Offset = "0xDAF4D0", VA = "0xDAF4D0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEBE0", Offset = "0x5AEBE0")]
public sealed class ES2_char : ES2Type
{
	[Token(Token = "0x6000271")]
	[Address(RVA = "0xDAF550", Offset = "0xDAF550", VA = "0xDAF550")]
	public ES2_char()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xDAF5E0", Offset = "0xDAF5E0", VA = "0xDAF5E0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xDAF680", Offset = "0xDAF680", VA = "0xDAF680", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEBF4", Offset = "0x5AEBF4")]
public sealed class ES2_decimal : ES2Type
{
	[Token(Token = "0x6000274")]
	[Address(RVA = "0xDAF700", Offset = "0xDAF700", VA = "0xDAF700")]
	public ES2_decimal()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xDAF790", Offset = "0xDAF790", VA = "0xDAF790", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xDAF830", Offset = "0xDAF830", VA = "0xDAF830", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000046")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEC08", Offset = "0x5AEC08")]
public sealed class ES2_double : ES2Type
{
	[Token(Token = "0x6000277")]
	[Address(RVA = "0xDAF8B4", Offset = "0xDAF8B4", VA = "0xDAF8B4")]
	public ES2_double()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xDAF944", Offset = "0xDAF944", VA = "0xDAF944", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xDAF9E4", Offset = "0xDAF9E4", VA = "0xDAF9E4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000047")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEC1C", Offset = "0x5AEC1C")]
public sealed class ES2_float : ES2Type
{
	[Token(Token = "0x600027A")]
	[Address(RVA = "0xDAFA64", Offset = "0xDAFA64", VA = "0xDAFA64")]
	public ES2_float()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xDAFAF4", Offset = "0xDAFAF4", VA = "0xDAFAF4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xDAFB94", Offset = "0xDAFB94", VA = "0xDAFB94", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEC30", Offset = "0x5AEC30")]
public sealed class ES2_int : ES2Type
{
	[Token(Token = "0x600027D")]
	[Address(RVA = "0xDAC4A4", Offset = "0xDAC4A4", VA = "0xDAC4A4")]
	public ES2_int()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xDAFC14", Offset = "0xDAFC14", VA = "0xDAFC14", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xDAFCB4", Offset = "0xDAFCB4", VA = "0xDAFCB4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000049")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEC44", Offset = "0x5AEC44")]
public sealed class ES2_long : ES2Type
{
	[Token(Token = "0x6000280")]
	[Address(RVA = "0xDAFD38", Offset = "0xDAFD38", VA = "0xDAFD38")]
	public ES2_long()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xDAFDC8", Offset = "0xDAFDC8", VA = "0xDAFDC8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xDAFE68", Offset = "0xDAFE68", VA = "0xDAFE68", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEC58", Offset = "0x5AEC58")]
public sealed class ES2_object : ES2Type
{
	[Token(Token = "0x6000283")]
	[Address(RVA = "0xDAFEEC", Offset = "0xDAFEEC", VA = "0xDAFEEC")]
	public ES2_object()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xDAFF70", Offset = "0xDAFF70", VA = "0xDAFF70", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xDB00A4", Offset = "0xDB00A4", VA = "0xDB00A4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEC6C", Offset = "0x5AEC6C")]
public sealed class ES2_sbyte : ES2Type
{
	[Token(Token = "0x6000286")]
	[Address(RVA = "0xDB0190", Offset = "0xDB0190", VA = "0xDB0190")]
	public ES2_sbyte()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xDB0220", Offset = "0xDB0220", VA = "0xDB0220", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xDB02BC", Offset = "0xDB02BC", VA = "0xDB02BC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEC80", Offset = "0x5AEC80")]
public sealed class ES2_short : ES2Type
{
	[Token(Token = "0x6000289")]
	[Address(RVA = "0xDB033C", Offset = "0xDB033C", VA = "0xDB033C")]
	public ES2_short()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xDB03CC", Offset = "0xDB03CC", VA = "0xDB03CC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xDB046C", Offset = "0xDB046C", VA = "0xDB046C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AEC94", Offset = "0x5AEC94")]
public sealed class ES2_string : ES2Type
{
	[Token(Token = "0x600028C")]
	[Address(RVA = "0xDB04F0", Offset = "0xDB04F0", VA = "0xDB04F0")]
	public ES2_string()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xDB0580", Offset = "0xDB0580", VA = "0xDB0580", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xDB0610", Offset = "0xDB0610", VA = "0xDB0610", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AECA8", Offset = "0x5AECA8")]
public sealed class ES2_uint : ES2Type
{
	[Token(Token = "0x600028F")]
	[Address(RVA = "0xDB063C", Offset = "0xDB063C", VA = "0xDB063C")]
	public ES2_uint()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xDB06CC", Offset = "0xDB06CC", VA = "0xDB06CC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xDB076C", Offset = "0xDB076C", VA = "0xDB076C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AECBC", Offset = "0x5AECBC")]
public sealed class ES2_ulong : ES2Type
{
	[Token(Token = "0x6000292")]
	[Address(RVA = "0xDB07F0", Offset = "0xDB07F0", VA = "0xDB07F0")]
	public ES2_ulong()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xDB0880", Offset = "0xDB0880", VA = "0xDB0880", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xDB0920", Offset = "0xDB0920", VA = "0xDB0920", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5AECD0", Offset = "0x5AECD0")]
public sealed class ES2_ushort : ES2Type
{
	[Token(Token = "0x6000295")]
	[Address(RVA = "0xDB09A4", Offset = "0xDB09A4", VA = "0xDB09A4")]
	public ES2_ushort()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xDB0A34", Offset = "0xDB0A34", VA = "0xDB0A34", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xDB0AD4", Offset = "0xDB0AD4", VA = "0xDB0AD4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000051")]
public class ES2Writer : IDisposable
{
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0368", Offset = "0x5B0368")]
	public ES2Stream stream;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B037C", Offset = "0x5B037C")]
	public HashSet<string> tagsToDelete;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0390", Offset = "0x5B0390")]
	public BinaryWriter writer;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B03A4", Offset = "0x5B03A4")]
	private long lengthPosition;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xCF40E4", Offset = "0xCF40E4", VA = "0xCF40E4")]
	public void WriteRaw(byte[] param)
	{
	}

	[Token(Token = "0x6000299")]
	public void Write<T>(T param)
	{
	}

	[Token(Token = "0x600029A")]
	public void Write<T>(T[] param)
	{
	}

	[Token(Token = "0x600029B")]
	public void Write<T>(T[,] param)
	{
	}

	[Token(Token = "0x600029C")]
	public void Write<T>(T[,,] param)
	{
	}

	[Token(Token = "0x600029D")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
	}

	[Token(Token = "0x600029E")]
	public void Write<T>(List<T> param)
	{
	}

	[Token(Token = "0x600029F")]
	public void Write<T>(HashSet<T> param)
	{
	}

	[Token(Token = "0x60002A0")]
	public void Write<T>(Queue<T> param)
	{
	}

	[Token(Token = "0x60002A1")]
	public void Write<T>(Stack<T> param)
	{
	}

	[Token(Token = "0x60002A2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0F98", Offset = "0x5B0F98")]
	public void Write<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x60002A3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0FAC", Offset = "0x5B0FAC")]
	public void Write<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0FC0", Offset = "0x5B0FC0")]
	public void Write<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002A5")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0FD4", Offset = "0x5B0FD4")]
	public void Write<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002A6")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0FE8", Offset = "0x5B0FE8")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002A7")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B0FFC", Offset = "0x5B0FFC")]
	public void Write<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002A8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1010", Offset = "0x5B1010")]
	public void Write<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002A9")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1024", Offset = "0x5B1024")]
	public void Write<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AA")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1038", Offset = "0x5B1038")]
	public void Write<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xCFCEE0", Offset = "0xCFCEE0", VA = "0xCFCEE0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B104C", Offset = "0x5B104C")]
	public void WriteSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xCFD1CC", Offset = "0xCFD1CC", VA = "0xCFD1CC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1060", Offset = "0x5B1060")]
	public void WriteICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xCFD52C", Offset = "0xCFD52C", VA = "0xCFD52C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1074", Offset = "0x5B1074")]
	public void WriteIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002AE")]
	private void WriteEncrypted<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x60002AF")]
	private void WriteEncrypted<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B0")]
	private void WriteEncrypted<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B1")]
	private void WriteEncrypted<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B2")]
	private void WriteEncrypted<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002B3")]
	private void WriteEncrypted<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B4")]
	private void WriteEncrypted<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B5")]
	private void WriteEncrypted<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B6")]
	private void WriteEncrypted<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xD0A290", Offset = "0xD0A290", VA = "0xD0A290")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1088", Offset = "0x5B1088")]
	private void WriteEncryptedSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xD0A420", Offset = "0xD0A420", VA = "0xD0A420")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B109C", Offset = "0x5B109C")]
	private void WriteEncryptedICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xD0A5B0", Offset = "0xD0A5B0", VA = "0xD0A5B0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B10B0", Offset = "0x5B10B0")]
	private void WriteEncryptedIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xD0A948", Offset = "0xD0A948", VA = "0xD0A948")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B10C4", Offset = "0x5B10C4")]
	public void WriteHeader(ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xD0A970", Offset = "0xD0A970", VA = "0xD0A970")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B10D8", Offset = "0x5B10D8")]
	public void WriteHeader(string tag, ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xD0AB58", Offset = "0xD0AB58", VA = "0xD0AB58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B10EC", Offset = "0x5B10EC")]
	public void WriteLength()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xD0AC1C", Offset = "0xD0AC1C", VA = "0xD0AC1C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1100", Offset = "0x5B1100")]
	public void WriteTerminator()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xD0A750", Offset = "0xD0A750", VA = "0xD0A750")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1114", Offset = "0x5B1114")]
	public ES2Writer CreateEncryptedWriter()
	{
		return null;
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xD0A7EC", Offset = "0xD0A7EC", VA = "0xD0A7EC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1128", Offset = "0x5B1128")]
	public byte[] GetEncryptedBytes(string password)
	{
		return null;
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xD0AD04", Offset = "0xD0AD04", VA = "0xD0AD04", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xD0AD24", Offset = "0xD0AD24", VA = "0xD0AD24")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B113C", Offset = "0x5B113C")]
	public bool Rename(string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C2")]
	public void Write<T>(T param, string tag)
	{
	}

	[Token(Token = "0x60002C3")]
	public void Write<T>(T[] param, string tag)
	{
	}

	[Token(Token = "0x60002C4")]
	public void Write<T>(T[,] param, string tag)
	{
	}

	[Token(Token = "0x60002C5")]
	public void Write<T>(T[,,] param, string tag)
	{
	}

	[Token(Token = "0x60002C6")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag)
	{
	}

	[Token(Token = "0x60002C7")]
	public void Write<T>(List<T> param, string tag)
	{
	}

	[Token(Token = "0x60002C8")]
	public void Write<T>(HashSet<T> param, string tag)
	{
	}

	[Token(Token = "0x60002C9")]
	public void Write<T>(Queue<T> param, string tag)
	{
	}

	[Token(Token = "0x60002CA")]
	public void Write<T>(Stack<T> param, string tag)
	{
	}

	[Token(Token = "0x60002CB")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1150", Offset = "0x5B1150")]
	public void Write<T>(T param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002CC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1164", Offset = "0x5B1164")]
	public void Write<T>(T[] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002CD")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1178", Offset = "0x5B1178")]
	public void Write<T>(T[,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002CE")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B118C", Offset = "0x5B118C")]
	public void Write<T>(T[,,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002CF")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B11A0", Offset = "0x5B11A0")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x60002D0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B11B4", Offset = "0x5B11B4")]
	public void Write<T>(List<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D1")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B11C8", Offset = "0x5B11C8")]
	public void Write<T>(HashSet<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D2")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B11DC", Offset = "0x5B11DC")]
	public void Write<T>(Queue<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D3")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B11F0", Offset = "0x5B11F0")]
	public void Write<T>(Stack<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x60002D4")]
	public void WriteProperty<T>(T property)
	{
	}

	[Token(Token = "0x60002D5")]
	public void WriteProperty<T>(T[] property)
	{
	}

	[Token(Token = "0x60002D6")]
	public void WriteProperty<T>(T[,] property)
	{
	}

	[Token(Token = "0x60002D7")]
	public void WriteProperty<T>(T[,,] property)
	{
	}

	[Token(Token = "0x60002D8")]
	public void WriteProperty<T>(List<T> property)
	{
	}

	[Token(Token = "0x60002D9")]
	public void WriteProperty<T>(Queue<T> property)
	{
	}

	[Token(Token = "0x60002DA")]
	public void WriteProperty<T>(Stack<T> property)
	{
	}

	[Token(Token = "0x60002DB")]
	public void WriteProperty<TKey, TValue>(Dictionary<TKey, TValue> property)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xCFC1D0", Offset = "0xCFC1D0", VA = "0xCFC1D0")]
	public int WritePropertyPrefix()
	{
		return default(int);
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xCFC8E8", Offset = "0xCFC8E8", VA = "0xCFC8E8")]
	public void WritePropertyLength(int startPosition)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xD00DFC", Offset = "0xD00DFC", VA = "0xD00DFC")]
	public void Save()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xCF414C", Offset = "0xCF414C", VA = "0xCF414C")]
	public void Save(bool checkForOverwrite)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xD0AF8C", Offset = "0xD0AF8C", VA = "0xD0AF8C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1204", Offset = "0x5B1204")]
	public void Save(byte[] bytes)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xD01484", Offset = "0xD01484", VA = "0xD01484")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B1218", Offset = "0x5B1218")]
	public bool Rename(string oldTag, string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xD00D94", Offset = "0xD00D94", VA = "0xD00D94")]
	public void Delete(string tag)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xD0AE64", Offset = "0xD0AE64", VA = "0xD0AE64")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x5B122C", Offset = "0x5B122C")]
	public bool Delete()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xD0AFC0", Offset = "0xD0AFC0", VA = "0xD0AFC0")]
	private bool Delete(byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xD0B0F0", Offset = "0xD0B0F0", VA = "0xD0B0F0")]
	public static ES2Writer Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xCFADA0", Offset = "0xCFADA0", VA = "0xCFADA0")]
	public static ES2Writer Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xCF4084", Offset = "0xCF4084", VA = "0xCF4084")]
	public static ES2Writer Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xD0AC40", Offset = "0xD0AC40", VA = "0xD0AC40")]
	public ES2Writer(ES2Settings settings)
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000052")]
	public enum AAMode
	{
		[Token(Token = "0x40000C6")]
		FXAA2,
		[Token(Token = "0x40000C7")]
		FXAA3Console,
		[Token(Token = "0x40000C8")]
		FXAA1PresetA,
		[Token(Token = "0x40000C9")]
		FXAA1PresetB,
		[Token(Token = "0x40000CA")]
		NFAA,
		[Token(Token = "0x40000CB")]
		SSAA,
		[Token(Token = "0x40000CC")]
		DLAA
	}
	[Token(Token = "0x2000053")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AECE4", Offset = "0x5AECE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AECE4", Offset = "0x5AECE4")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AAMode mode;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showGeneratedNormals;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float offsetScale;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float blurRadius;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeThresholdMin;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float edgeThreshold;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float edgeSharpness;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool dlaaSharp;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader ssaaShader;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material ssaa;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader dlaaShader;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material dlaa;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader nfaaShader;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material nfaa;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Shader shaderFXAAII;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Material materialFXAAII;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material materialFXAAIII;

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xDB290C", Offset = "0xDB290C", VA = "0xDB290C")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xDB2970", Offset = "0xDB2970", VA = "0xDB2970", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xDB2E24", Offset = "0xDB2E24", VA = "0xDB2E24")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xDB336C", Offset = "0xDB336C", VA = "0xDB336C")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AED7C", Offset = "0x5AED7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AED7C", Offset = "0x5AED7C")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x20000A1")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x4000300")]
			Ghosting,
			[Token(Token = "0x4000301")]
			Anamorphic,
			[Token(Token = "0x4000302")]
			Combined
		}

		[Token(Token = "0x20000A2")]
		public enum TweakMode
		{
			[Token(Token = "0x4000304")]
			Basic,
			[Token(Token = "0x4000305")]
			Complex
		}

		[Token(Token = "0x20000A3")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000307")]
			Auto,
			[Token(Token = "0x4000308")]
			On,
			[Token(Token = "0x4000309")]
			Off
		}

		[Token(Token = "0x20000A4")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x400030B")]
			Screen,
			[Token(Token = "0x400030C")]
			Add
		}

		[Token(Token = "0x20000A5")]
		public enum BloomQuality
		{
			[Token(Token = "0x400030E")]
			Cheap,
			[Token(Token = "0x400030F")]
			High
		}

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode tweakMode;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BloomQuality quality;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color bloomThresholdColor;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int bloomBlurIterations;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float flareRotation;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float hollyStretchWidth;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareIntensity;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float lensflareThreshold;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float lensFlareSaturation;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color flareColorA;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color flareColorB;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color flareColorC;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color flareColorD;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Shader lensFlareShader;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader screenBlendShader;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material screenBlend;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xDB33AC", Offset = "0xDB33AC", VA = "0xDB33AC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xDB37C8", Offset = "0xDB37C8", VA = "0xDB37C8")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xDB4B84", Offset = "0xDB4B84", VA = "0xDB4B84")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xDB4984", Offset = "0xDB4984", VA = "0xDB4984")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xDB468C", Offset = "0xDB468C", VA = "0xDB468C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xDB45A8", Offset = "0xDB45A8", VA = "0xDB45A8")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xDB4778", Offset = "0xDB4778", VA = "0xDB4778")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xDB4C4C", Offset = "0xDB4C4C", VA = "0xDB4C4C")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000102")]
		Ghosting,
		[Token(Token = "0x4000103")]
		Anamorphic,
		[Token(Token = "0x4000104")]
		Combined
	}
	[Token(Token = "0x2000056")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000106")]
		Basic,
		[Token(Token = "0x4000107")]
		Complex
	}
	[Token(Token = "0x2000057")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000109")]
		Auto,
		[Token(Token = "0x400010A")]
		On,
		[Token(Token = "0x400010B")]
		Off
	}
	[Token(Token = "0x2000058")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x400010D")]
		Screen,
		[Token(Token = "0x400010E")]
		Add
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AEE14", Offset = "0x5AEE14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AEE14", Offset = "0x5AEE14")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool lensflares;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float hollyStretchWidth;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float lensflareIntensity;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float lensflareThreshold;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color flareColorA;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color flareColorB;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorC;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorD;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material screenBlend;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xDB4D94", Offset = "0xDB4D94", VA = "0xDB4D94", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xDB4E4C", Offset = "0xDB4E4C", VA = "0xDB4E4C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xDB5D98", Offset = "0xDB5D98", VA = "0xDB5D98")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xDB5BA8", Offset = "0xDB5BA8", VA = "0xDB5BA8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xDB592C", Offset = "0xDB592C", VA = "0xDB592C")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xDB5A54", Offset = "0xDB5A54", VA = "0xDB5A54")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xDB5E4C", Offset = "0xDB5E4C", VA = "0xDB5E4C")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AEEAC", Offset = "0x5AEEAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AEEAC", Offset = "0x5AEEAC")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x20000A6")]
		public enum Resolution
		{
			[Token(Token = "0x4000311")]
			Low,
			[Token(Token = "0x4000312")]
			High
		}

		[Token(Token = "0x20000A7")]
		public enum BlurType
		{
			[Token(Token = "0x4000314")]
			Standard,
			[Token(Token = "0x4000315")]
			Sgx
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B03B8", Offset = "0x5B03B8")]
		public float threshold;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B03D0", Offset = "0x5B03D0")]
		public float intensity;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B03E8", Offset = "0x5B03E8")]
		public float blurSize;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Resolution resolution;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0400", Offset = "0x5B0400")]
		public int blurIterations;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BlurType blurType;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fastBloomMaterial;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xDB5F88", Offset = "0xDB5F88", VA = "0xDB5F88", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xDB5FE0", Offset = "0xDB5FE0", VA = "0xDB5FE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xDB6090", Offset = "0xDB6090", VA = "0xDB6090")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xDB645C", Offset = "0xDB645C", VA = "0xDB645C")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AEF44", Offset = "0x5AEF44")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int iterations;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blurSpread;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000025")]
		protected Material material
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xDB6488", Offset = "0xDB6488", VA = "0xDB6488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xDB65C0", Offset = "0xDB65C0", VA = "0xDB65C0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xDB66BC", Offset = "0xDB66BC", VA = "0xDB66BC")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xDB677C", Offset = "0xDB677C", VA = "0xDB677C")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xDB6920", Offset = "0xDB6920", VA = "0xDB6920")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xDB6A98", Offset = "0xDB6A98", VA = "0xDB6A98")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xDB6C04", Offset = "0xDB6C04", VA = "0xDB6C04")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AEF90", Offset = "0x5AEF90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AEF90", Offset = "0x5AEF90")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x20000A8")]
		public enum BlurType
		{
			[Token(Token = "0x4000317")]
			StandardGauss,
			[Token(Token = "0x4000318")]
			SgxGauss
		}

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0418", Offset = "0x5B0418")]
		public int downsample;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0430", Offset = "0x5B0430")]
		public float blurSize;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0448", Offset = "0x5B0448")]
		public int blurIterations;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlurType blurType;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader blurShader;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material blurMaterial;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xDB6C20", Offset = "0xDB6C20", VA = "0xDB6C20", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xDB6C78", Offset = "0xDB6C78", VA = "0xDB6C78")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xDB6D28", Offset = "0xDB6D28", VA = "0xDB6D28")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xDB70CC", Offset = "0xDB70CC", VA = "0xDB70CC")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF028", Offset = "0x5AF028")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF028", Offset = "0x5AF028")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x20000A9")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x400031A")]
			CameraMotion,
			[Token(Token = "0x400031B")]
			LocalBlur,
			[Token(Token = "0x400031C")]
			Reconstruction,
			[Token(Token = "0x400031D")]
			ReconstructionDX11,
			[Token(Token = "0x400031E")]
			ReconstructionDisc
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool preview;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 previewScale;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float movementScale;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationScale;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxVelocity;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float minVelocity;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float velocityScale;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float softZDistance;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int velocityDownsample;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LayerMask excludeLayers;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject tmpCam;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shader;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader replacementClear;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material motionBlurMaterial;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float jitter;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool showVelocity;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float showVelocityScale;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private int prevFrameCount;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool wasActive;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 prevFramePos;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Camera _camera;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xDB70F4", Offset = "0xDB70F4", VA = "0xDB70F4")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xDB7240", Offset = "0xDB7240", VA = "0xDB7240")]
		private new void Start()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xDB73C4", Offset = "0xDB73C4", VA = "0xDB73C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xDB7484", Offset = "0xDB7484", VA = "0xDB7484")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xDB75E8", Offset = "0xDB75E8", VA = "0xDB75E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xDB76CC", Offset = "0xDB76CC", VA = "0xDB76CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xDB7318", Offset = "0xDB7318", VA = "0xDB7318")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xDB8CF4", Offset = "0xDB8CF4", VA = "0xDB8CF4")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xDB8C08", Offset = "0xDB8C08", VA = "0xDB8C08")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xDB8CE4", Offset = "0xDB8CE4", VA = "0xDB8CE4")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xDB9030", Offset = "0xDB9030", VA = "0xDB9030")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF0C0", Offset = "0x5AF0C0")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x20000AA")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000320")]
			Simple,
			[Token(Token = "0x4000321")]
			Advanced
		}

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve redChannel;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useDepthCorrection;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve zCurve;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material ccMaterial;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccDepthMaterial;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D zCurveTex;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float saturation;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool selectiveCc;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color selectiveFromColor;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color selectiveToColor;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool updateTextures;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xDB918C", Offset = "0xDB918C", VA = "0xDB918C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xDB91C8", Offset = "0xDB91C8", VA = "0xDB91C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xDB91CC", Offset = "0xDB91CC", VA = "0xDB91CC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xDB942C", Offset = "0xDB942C", VA = "0xDB942C")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xDB9820", Offset = "0xDB9820", VA = "0xDB9820")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xDB9824", Offset = "0xDB9824", VA = "0xDB9824")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xDB9B20", Offset = "0xDB9B20", VA = "0xDB9B20")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF10C", Offset = "0x5AF10C")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader shader;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture3D converted3DLut;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string basedOnTempTex;

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xDBA15C", Offset = "0xDBA15C", VA = "0xDBA15C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xDBA1B0", Offset = "0xDBA1B0", VA = "0xDBA1B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xDBA258", Offset = "0xDBA258", VA = "0xDBA258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xDBA300", Offset = "0xDBA300", VA = "0xDBA300")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xDBA4FC", Offset = "0xDBA4FC", VA = "0xDBA4FC")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xDBA5F0", Offset = "0xDBA5F0", VA = "0xDBA5F0")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xDBA8FC", Offset = "0xDBA8FC", VA = "0xDBA8FC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xDBAAE8", Offset = "0xDBAAE8", VA = "0xDBAAE8")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF158", Offset = "0x5AF158")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xDBAB4C", Offset = "0xDBAB4C", VA = "0xDBAB4C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xDBACC8", Offset = "0xDBACC8", VA = "0xDBACC8")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF1A4", Offset = "0x5AF1A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF1A4", Offset = "0x5AF1A4")]
	internal class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float threshold;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blurSpread;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xDBACD8", Offset = "0xDBACD8", VA = "0xDBACD8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xDBAD48", Offset = "0xDBAD48", VA = "0xDBAD48")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xDBB0B0", Offset = "0xDBB0B0", VA = "0xDBB0B0")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF23C", Offset = "0x5AF23C")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float adaptationSpeed;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float limitMinimum;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float limitMaximum;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000026")]
		protected Material materialLum
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xDBB0D4", Offset = "0xDBB0D4", VA = "0xDBB0D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		protected Material materialReduce
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0xDBB198", Offset = "0xDBB198", VA = "0xDBB198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		protected Material materialAdapt
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0xDBB25C", Offset = "0xDBB25C", VA = "0xDBB25C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		protected Material materialApply
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0xDBB320", Offset = "0xDBB320", VA = "0xDBB320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xDBB3E4", Offset = "0xDBB3E4", VA = "0xDBB3E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xDBB478", Offset = "0xDBB478", VA = "0xDBB478")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xDBB5C8", Offset = "0xDBB5C8", VA = "0xDBB5C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xDBB7F0", Offset = "0xDBB7F0", VA = "0xDBB7F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xDBBA4C", Offset = "0xDBBA4C", VA = "0xDBBA4C")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xDBBC5C", Offset = "0xDBBC5C", VA = "0xDBBC5C")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF288", Offset = "0x5AF288")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF288", Offset = "0x5AF288")]
	internal class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int softness;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spread;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader blurShader;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material blurMaterial;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader creaseApplyShader;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xDBBCD4", Offset = "0xDBBCD4", VA = "0xDBBCD4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xDBBD4C", Offset = "0xDBBD4C", VA = "0xDBBD4C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xDBC0F4", Offset = "0xDBC0F4", VA = "0xDBC0F4")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF320", Offset = "0x5AF320")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF320", Offset = "0x5AF320")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x20000AB")]
		public enum BlurType
		{
			[Token(Token = "0x4000323")]
			DiscBlur,
			[Token(Token = "0x4000324")]
			DX11
		}

		[Token(Token = "0x20000AC")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000326")]
			Low,
			[Token(Token = "0x4000327")]
			Medium,
			[Token(Token = "0x4000328")]
			High
		}

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool visualizeFocus;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float focalLength;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float focalSize;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float aperture;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform focalTransform;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxBlurSize;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool highResolution;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BlurType blurType;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool nearBlur;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float foregroundOverlap;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader dofHdrShader;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material dofHdrMaterial;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dx11BokehShader;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float dx11BokehThreshold;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehScale;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float focalDistance01;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float internalBlurWidth;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xDBC11C", Offset = "0xDBC11C", VA = "0xDBC11C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xDBC2BC", Offset = "0xDBC2BC", VA = "0xDBC2BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xDBC330", Offset = "0xDBC330", VA = "0xDBC330")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xDBC438", Offset = "0xDBC438", VA = "0xDBC438")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xDBC1A0", Offset = "0xDBC1A0", VA = "0xDBC1A0")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xDBC47C", Offset = "0xDBC47C", VA = "0xDBC47C")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xDBC620", Offset = "0xDBC620", VA = "0xDBC620")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xDBC940", Offset = "0xDBC940", VA = "0xDBC940")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xDBDFB0", Offset = "0xDBDFB0", VA = "0xDBDFB0")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF3B8", Offset = "0x5AF3B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF3B8", Offset = "0x5AF3B8")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x20000AD")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x400032A")]
			OnlyBackground = 1,
			[Token(Token = "0x400032B")]
			BackgroundAndForeground
		}

		[Token(Token = "0x20000AE")]
		public enum DofResolution
		{
			[Token(Token = "0x400032D")]
			High = 2,
			[Token(Token = "0x400032E")]
			Medium,
			[Token(Token = "0x400032F")]
			Low
		}

		[Token(Token = "0x20000AF")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000331")]
			Low = 1,
			[Token(Token = "0x4000332")]
			High = 2,
			[Token(Token = "0x4000333")]
			VeryHigh = 4
		}

		[Token(Token = "0x20000B0")]
		public enum BokehDestination
		{
			[Token(Token = "0x4000335")]
			Background = 1,
			[Token(Token = "0x4000336")]
			Foreground,
			[Token(Token = "0x4000337")]
			BackgroundAndForeground
		}

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DofResolution resolution;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool simpleTweakMode;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float focalPoint;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float smoothness;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalZDistance;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalZStartCurve;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float focalZEndCurve;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float focalStartCurve;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float focalEndCurve;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float focalDistance01;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform objectFocus;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float focalSize;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public DofBlurriness bluriness;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxBlurSpread;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dofBlurShader;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material dofBlurMaterial;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofShader;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofMaterial;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool visualize;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float widthOverHeight;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float oneOverBaseSize;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool bokeh;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool bokehSupport;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader bokehShader;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float bokehScale;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float bokehIntensity;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int bokehDownsample;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material bokehMaterial;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Camera _camera;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture bokehSource;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xDBE014", Offset = "0xDBE014", VA = "0xDBE014")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xDBE0E8", Offset = "0xDBE0E8", VA = "0xDBE0E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xDBE1EC", Offset = "0xDBE1EC", VA = "0xDBE1EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xDBE24C", Offset = "0xDBE24C", VA = "0xDBE24C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xDBE2C4", Offset = "0xDBE2C4", VA = "0xDBE2C4")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xDBE420", Offset = "0xDBE420", VA = "0xDBE420")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xDBE444", Offset = "0xDBE444", VA = "0xDBE444")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xDBE468", Offset = "0xDBE468", VA = "0xDBE468")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xDBF24C", Offset = "0xDBF24C", VA = "0xDBF24C")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xDBF904", Offset = "0xDBF904", VA = "0xDBF904")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xDBFD6C", Offset = "0xDBFD6C", VA = "0xDBFD6C")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xDBF100", Offset = "0xDBF100", VA = "0xDBF100")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xDBF4E8", Offset = "0xDBF4E8", VA = "0xDBF4E8")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xDBFBC0", Offset = "0xDBFBC0", VA = "0xDBFBC0")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xDBEDCC", Offset = "0xDBEDCC", VA = "0xDBEDCC")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xDBFF94", Offset = "0xDBFF94", VA = "0xDBFF94")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF450", Offset = "0x5AF450")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF450", Offset = "0x5AF450")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x20000B1")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x4000339")]
			TriangleDepthNormals,
			[Token(Token = "0x400033A")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x400033B")]
			SobelDepth,
			[Token(Token = "0x400033C")]
			SobelDepthThin,
			[Token(Token = "0x400033D")]
			TriangleLuminance
		}

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivityDepth;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sensitivityNormals;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lumThreshold;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeExp;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sampleDist;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float edgesOnly;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xDC0078", Offset = "0xDC0078", VA = "0xDC0078", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xDC01B0", Offset = "0xDC01B0", VA = "0xDC01B0")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xDC00F0", Offset = "0xDC00F0", VA = "0xDC00F0")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xDC01BC", Offset = "0xDC01BC", VA = "0xDC01BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xDC01C0", Offset = "0xDC01C0", VA = "0xDC01C0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xDC03AC", Offset = "0xDC03AC", VA = "0xDC03AC")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF4E8", Offset = "0x5AF4E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF4E8", Offset = "0x5AF4E8")]
	internal class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float strengthX;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float strengthY;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader fishEyeShader;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xDC040C", Offset = "0xDC040C", VA = "0xDC040C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xDC0464", Offset = "0xDC0464", VA = "0xDC0464")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xDC05D4", Offset = "0xDC05D4", VA = "0xDC05D4")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF580", Offset = "0x5AF580")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF580", Offset = "0x5AF580")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B0460", Offset = "0x5B0460")]
		public bool distanceFog;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B0498", Offset = "0x5B0498")]
		public bool useRadialDistance;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B04D0", Offset = "0x5B04D0")]
		public bool heightFog;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B0508", Offset = "0x5B0508")]
		public float height;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0540", Offset = "0x5B0540")]
		public float heightDensity;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B055C", Offset = "0x5B055C")]
		public float startDistance;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xDC05F8", Offset = "0xDC05F8", VA = "0xDC05F8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xDC0650", Offset = "0xDC0650", VA = "0xDC0650")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xDC0E6C", Offset = "0xDC0E6C", VA = "0xDC0E6C")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xDC0FDC", Offset = "0xDC0FDC", VA = "0xDC0FDC")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF618", Offset = "0x5AF618")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float rampOffset;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xDC1004", Offset = "0xDC1004", VA = "0xDC1004")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xDC10E0", Offset = "0xDC10E0", VA = "0xDC10E0")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF664", Offset = "0x5AF664")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF664", Offset = "0x5AF664")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700002A")]
		protected Material material
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0xDBAC04", Offset = "0xDBAC04", VA = "0xDBAC04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xDC10E8", Offset = "0xDC10E8", VA = "0xDC10E8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xDC1198", Offset = "0xDC1198", VA = "0xDC1198", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xDBACD0", Offset = "0xDBACD0", VA = "0xDBACD0")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF6EC", Offset = "0x5AF6EC")]
	public class ImageEffects
	{
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xDC1248", Offset = "0xDC1248", VA = "0xDC1248")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xDC14C4", Offset = "0xDC14C4", VA = "0xDC14C4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5B1260", Offset = "0x5B1260")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xDC153C", Offset = "0xDC153C", VA = "0xDC153C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5B1298", Offset = "0x5B1298")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xDC15BC", Offset = "0xDC15BC", VA = "0xDC15BC")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF724", Offset = "0x5AF724")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF724", Offset = "0x5AF724")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float blurAmount;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xDC15C4", Offset = "0xDC15C4", VA = "0xDC15C4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xDC1608", Offset = "0xDC1608", VA = "0xDC1608", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xDC167C", Offset = "0xDC167C", VA = "0xDC167C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xDC1A00", Offset = "0xDC1A00", VA = "0xDC1A00")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF7BC", Offset = "0x5AF7BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF7BC", Offset = "0x5AF7BC")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensityMultiplier;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float generalIntensity;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blackIntensity;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float whiteIntensity;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float midGrey;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool dx11Grain;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float softness;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool monochrome;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 intensities;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 tiling;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float monochromeTiling;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FilterMode filterMode;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader noiseShader;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material noiseMaterial;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xDC1A14", Offset = "0xDC1A14", VA = "0xDC1A14", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xDC1A8C", Offset = "0xDC1A8C", VA = "0xDC1A8C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xDC23AC", Offset = "0xDC23AC", VA = "0xDC23AC")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xDC2728", Offset = "0xDC2728", VA = "0xDC2728")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF854", Offset = "0x5AF854")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF854", Offset = "0x5AF854")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float grainIntensityMin;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float grainIntensityMax;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float grainSize;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float scratchIntensityMin;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float scratchFPS;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float scratchJitter;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x1700002B")]
		protected Material material
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xDC2980", Offset = "0xDC2980", VA = "0xDC2980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xDC2840", Offset = "0xDC2840", VA = "0xDC2840")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xDC2ADC", Offset = "0xDC2ADC", VA = "0xDC2ADC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xDC2BE0", Offset = "0xDC2BE0", VA = "0xDC2BE0")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xDC2D1C", Offset = "0xDC2D1C", VA = "0xDC2D1C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xDC3064", Offset = "0xDC3064", VA = "0xDC3064")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF8EC", Offset = "0x5AF8EC")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xDB3434", Offset = "0xDB3434", VA = "0xDB3434")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xDB2B60", Offset = "0xDB2B60", VA = "0xDB2B60")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xDC3098", Offset = "0xDC3098", VA = "0xDC3098")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xDC30A4", Offset = "0xDC30A4", VA = "0xDC30A4")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xDC30AC", Offset = "0xDC30AC", VA = "0xDC30AC", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xDB91BC", Offset = "0xDB91BC", VA = "0xDB91BC")]
		protected void Start()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xDB2A4C", Offset = "0xDB2A4C", VA = "0xDB2A4C")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xDB7670", Offset = "0xDB7670", VA = "0xDB7670")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xDC315C", Offset = "0xDC315C", VA = "0xDC315C")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xDB2D7C", Offset = "0xDB2D7C", VA = "0xDB2D7C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xDC3164", Offset = "0xDC3164", VA = "0xDC3164")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xDB2D50", Offset = "0xDB2D50", VA = "0xDB2D50")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xDC3364", Offset = "0xDC3364", VA = "0xDC3364")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xDB3398", Offset = "0xDB3398", VA = "0xDB3398")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF960", Offset = "0x5AF960")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000387")]
		[Address(RVA = "0xDC36E0", Offset = "0xDC36E0", VA = "0xDC36E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xDC374C", Offset = "0xDC374C", VA = "0xDC374C")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xDC39C8", Offset = "0xDC39C8", VA = "0xDC39C8")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xDC3D40", Offset = "0xDC3D40", VA = "0xDC3D40")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xDC3EEC", Offset = "0xDC3EEC", VA = "0xDC3EEC")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000071")]
	internal class Quads
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x119C1D4", Offset = "0x119C1D4", VA = "0x119C1D4")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x119C2F8", Offset = "0x119C2F8", VA = "0x119C2F8")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x119C4C8", Offset = "0x119C4C8", VA = "0x119C4C8")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x119C788", Offset = "0x119C788", VA = "0x119C788")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x119CCBC", Offset = "0x119CCBC", VA = "0x119CCBC")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AF9D4", Offset = "0x5AF9D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AF9D4", Offset = "0x5AF9D4")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x20000B2")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x400033F")]
			Additive,
			[Token(Token = "0x4000340")]
			ScreenBlend,
			[Token(Token = "0x4000341")]
			Multiply,
			[Token(Token = "0x4000342")]
			Overlay,
			[Token(Token = "0x4000343")]
			AlphaBlend
		}

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader overlayShader;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material overlayMaterial;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x119CCC8", Offset = "0x119CCC8", VA = "0x119CCC8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x119CD2C", Offset = "0x119CD2C", VA = "0x119CD2C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x119CE94", Offset = "0x119CE94", VA = "0x119CE94")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AFA6C", Offset = "0x5AFA6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFA6C", Offset = "0x5AFA6C")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0594", Offset = "0x5B0594")]
		public float intensity;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B05AC", Offset = "0x5B05AC")]
		public float radius;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B05C8", Offset = "0x5B05C8")]
		public int blurIterations;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B05E0", Offset = "0x5B05E0")]
		public float blurFilterDistance;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B05F8", Offset = "0x5B05F8")]
		public int downsample;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D rand;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader aoShader;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material aoMaterial;

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x119CEA8", Offset = "0x119CEA8", VA = "0x119CEA8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x119CF0C", Offset = "0x119CF0C", VA = "0x119CF0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x119CFB4", Offset = "0x119CFB4", VA = "0x119CFB4")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x119D588", Offset = "0x119D588", VA = "0x119D588")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AFB04", Offset = "0x5AFB04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFB04", Offset = "0x5AFB04")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20000B3")]
		public enum SSAOSamples
		{
			[Token(Token = "0x4000345")]
			Low,
			[Token(Token = "0x4000346")]
			Medium,
			[Token(Token = "0x4000347")]
			High
		}

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_Radius;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int m_Blur;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int m_Downsampling;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_MinZ;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x119D5A8", Offset = "0x119D5A8", VA = "0x119D5A8")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x119D658", Offset = "0x119D658", VA = "0x119D658")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x119D6F4", Offset = "0x119D6F4", VA = "0x119D6F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x119D6FC", Offset = "0x119D6FC", VA = "0x119D6FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x119D890", Offset = "0x119D890", VA = "0x119D890")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x119D7D4", Offset = "0x119D7D4", VA = "0x119D7D4")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x119D904", Offset = "0x119D904", VA = "0x119D904")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x119DFC0", Offset = "0x119DFC0", VA = "0x119DFC0")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFB9C", Offset = "0x5AFB9C")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x119DFF4", Offset = "0x119DFF4", VA = "0x119DFF4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x119E088", Offset = "0x119E088", VA = "0x119E088")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AFBE8", Offset = "0x5AFBE8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFBE8", Offset = "0x5AFBE8")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x20000B4")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000349")]
			Low,
			[Token(Token = "0x400034A")]
			Normal,
			[Token(Token = "0x400034B")]
			High
		}

		[Token(Token = "0x20000B5")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x400034D")]
			Screen,
			[Token(Token = "0x400034E")]
			Add
		}

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform sunTransform;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int radialBlurIterations;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color sunColor;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color sunThreshold;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float maxRadius;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useDepthTexture;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader simpleClearShader;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x119E090", Offset = "0x119E090", VA = "0x119E090", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x119E108", Offset = "0x119E108", VA = "0x119E108")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x119E8FC", Offset = "0x119E8FC", VA = "0x119E8FC")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AFC80", Offset = "0x5AFC80")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFC80", Offset = "0x5AFC80")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x20000B6")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000350")]
			TiltShiftMode,
			[Token(Token = "0x4000351")]
			IrisMode
		}

		[Token(Token = "0x20000B7")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000353")]
			Preview,
			[Token(Token = "0x4000354")]
			Normal,
			[Token(Token = "0x4000355")]
			High
		}

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TiltShiftMode mode;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TiltShiftQuality quality;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0610", Offset = "0x5B0610")]
		public float blurArea;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0628", Offset = "0x5B0628")]
		public float maxBlurSize;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B0640", Offset = "0x5B0640")]
		public int downsample;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x119E994", Offset = "0x119E994", VA = "0x119E994", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x119E9F8", Offset = "0x119E9F8", VA = "0x119E9F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x119EC88", Offset = "0x119EC88", VA = "0x119EC88")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AFD08", Offset = "0x5AFD08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFD08", Offset = "0x5AFD08")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x20000B8")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000357")]
			SimpleReinhard,
			[Token(Token = "0x4000358")]
			UserCurve,
			[Token(Token = "0x4000359")]
			Hable,
			[Token(Token = "0x400035A")]
			Photographic,
			[Token(Token = "0x400035B")]
			OptimizedHejiDawson,
			[Token(Token = "0x400035C")]
			AdaptiveReinhard,
			[Token(Token = "0x400035D")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x20000B9")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x400035F")]
			Square16 = 0x10,
			[Token(Token = "0x4000360")]
			Square32 = 0x20,
			[Token(Token = "0x4000361")]
			Square64 = 0x40,
			[Token(Token = "0x4000362")]
			Square128 = 0x80,
			[Token(Token = "0x4000363")]
			Square256 = 0x100,
			[Token(Token = "0x4000364")]
			Square512 = 0x200,
			[Token(Token = "0x4000365")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TonemapperType type;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Texture2D curveTex;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exposureAdjustment;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float middleGrey;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float white;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float adaptionSpeed;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader tonemapper;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material tonemapMaterial;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture rt;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x119ECA4", Offset = "0x119ECA4", VA = "0x119ECA4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x119EDEC", Offset = "0x119EDEC", VA = "0x119EDEC")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x119F094", Offset = "0x119F094", VA = "0x119F094")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x119F1EC", Offset = "0x119F1EC", VA = "0x119F1EC")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x119F2DC", Offset = "0x119F2DC", VA = "0x119F2DC")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x119FAE8", Offset = "0x119FAE8", VA = "0x119FAE8")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000079")]
	internal class Triangles
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x119FB18", Offset = "0x119FB18", VA = "0x119FB18")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x119FC54", Offset = "0x119FC54", VA = "0x119FC54")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x119FE24", Offset = "0x119FE24", VA = "0x119FE24")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x11A00E4", Offset = "0x11A00E4", VA = "0x11A00E4")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x11A0514", Offset = "0x11A0514", VA = "0x11A0514")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFDA0", Offset = "0x5AFDA0")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x11A0520", Offset = "0x11A0520", VA = "0x11A0520")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x11A056C", Offset = "0x11A056C", VA = "0x11A056C")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5AFDEC", Offset = "0x5AFDEC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFDEC", Offset = "0x5AFDEC")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x20000BA")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000367")]
			Simple,
			[Token(Token = "0x4000368")]
			Advanced
		}

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AberrationMode mode;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float chromaticAberration;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float axialAberration;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float blur;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blurSpread;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float luminanceDependency;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blurDistance;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader vignetteShader;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader chromAberrationShader;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x11A05E8", Offset = "0x11A05E8", VA = "0x11A05E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x11A0680", Offset = "0x11A0680", VA = "0x11A0680")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x11A0C8C", Offset = "0x11A0C8C", VA = "0x11A0C8C")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5AFE84", Offset = "0x5AFE84")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x11A0CBC", Offset = "0x11A0CBC", VA = "0x11A0CBC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x11A0D08", Offset = "0x11A0D08", VA = "0x11A0D08")]
		public Vortex()
		{
		}
	}
}
namespace MoodkieSecurity
{
	[Token(Token = "0x200007D")]
	public enum AESBits
	{
		[Token(Token = "0x4000276")]
		BITS128,
		[Token(Token = "0x4000277")]
		BITS192,
		[Token(Token = "0x4000278")]
		BITS256
	}
	[Token(Token = "0x200007E")]
	public class AESEncryptor
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string fPassword;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AESBits fEncryptionBits;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] fSalt;

		[Token(Token = "0x1700002C")]
		public string Password
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xDB1440", Offset = "0xDB1440", VA = "0xDB1440")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xDB1448", Offset = "0xDB1448", VA = "0xDB1448")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public AESBits EncryptionBits
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xDB1450", Offset = "0xDB1450", VA = "0xDB1450")]
			get
			{
				return default(AESBits);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xDB1458", Offset = "0xDB1458", VA = "0xDB1458")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public byte[] Salt
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xDB1460", Offset = "0xDB1460", VA = "0xDB1460")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xDB1468", Offset = "0xDB1468", VA = "0xDB1468")]
			set
			{
			}
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xDB0B58", Offset = "0xDB0B58", VA = "0xDB0B58")]
		public AESEncryptor(string password, AESBits encryptionBits)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xDB0BEC", Offset = "0xDB0BEC", VA = "0xDB0BEC")]
		public AESEncryptor(string password, AESBits encryptionBits, byte[] salt)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xDB0C90", Offset = "0xDB0C90", VA = "0xDB0C90")]
		private byte[] iEncrypt(byte[] data, byte[] key, byte[] iV)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xDB0DE0", Offset = "0xDB0DE0", VA = "0xDB0DE0")]
		public string Encrypt(string data)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xDB0F50", Offset = "0xDB0F50", VA = "0xDB0F50")]
		public byte[] Encrypt(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xDB1064", Offset = "0xDB1064", VA = "0xDB1064")]
		private byte[] iDecrypt(byte[] data, byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xDB11B4", Offset = "0xDB11B4", VA = "0xDB11B4")]
		public string Decrypt(string data)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xDB132C", Offset = "0xDB132C", VA = "0xDB132C")]
		public byte[] Decrypt(byte[] data)
		{
			return null;
		}
	}
	[Token(Token = "0x200007F")]
	internal struct ABCDStruct
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint A;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint B;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint C;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint D;
	}
	[Token(Token = "0x2000080")]
	public sealed class MD5Core
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xDB1470", Offset = "0xDB1470", VA = "0xDB1470")]
		private MD5Core()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xDB1478", Offset = "0xDB1478", VA = "0xDB1478")]
		public static byte[] GetHash(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xDB1648", Offset = "0xDB1648", VA = "0xDB1648")]
		public static byte[] GetHash(string input)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xDB16AC", Offset = "0xDB16AC", VA = "0xDB16AC")]
		public static string GetHashString(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xDB1798", Offset = "0xDB1798", VA = "0xDB1798")]
		public static string GetHashString(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xDB1870", Offset = "0xDB1870", VA = "0xDB1870")]
		public static string GetHashString(string input)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xDB1550", Offset = "0xDB1550", VA = "0xDB1550")]
		public static byte[] GetHash(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xDB2368", Offset = "0xDB2368", VA = "0xDB2368")]
		internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ABCDStruct ABCD, long len)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xDB18D4", Offset = "0xDB18D4", VA = "0xDB18D4")]
		internal static void GetHashBlock(byte[] input, ref ABCDStruct ABCDValue, int ibStart)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xDB2720", Offset = "0xDB2720", VA = "0xDB2720")]
		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xDB2748", Offset = "0xDB2748", VA = "0xDB2748")]
		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xDB2770", Offset = "0xDB2770", VA = "0xDB2770")]
		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xDB2794", Offset = "0xDB2794", VA = "0xDB2794")]
		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xDB27B8", Offset = "0xDB27B8", VA = "0xDB27B8")]
		private static uint LSR(uint i, int s)
		{
			return default(uint);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xDB25AC", Offset = "0xDB25AC", VA = "0xDB25AC")]
		private static uint[] Converter(byte[] input, int ibStart)
		{
			return null;
		}
	}
	[Token(Token = "0x2000081")]
	public class MD5Encryptor
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xDB27C4", Offset = "0xDB27C4", VA = "0xDB27C4")]
		public MD5Encryptor()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xDB27CC", Offset = "0xDB27CC", VA = "0xDB27CC")]
		public string GetMD5(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xDB27D4", Offset = "0xDB27D4", VA = "0xDB27D4")]
		public string GetMD5(string data)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	public class Obfuscator
	{
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xDB27DC", Offset = "0xDB27DC", VA = "0xDB27DC")]
		public static byte[] Obfuscate(byte[] data, string key)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xDB2874", Offset = "0xDB2874", VA = "0xDB2874")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xDB2904", Offset = "0xDB2904", VA = "0xDB2904")]
		public Obfuscator()
		{
		}
	}
}
