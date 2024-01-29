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
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E240", Offset = "0xB9E240")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xBA4B8C", Offset = "0xBA4B8C")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xBA4BA0", Offset = "0xBA4BA0")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4C64", Offset = "0xBA4C64")]
	private bool <selectionChanged>k__BackingField;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	public bool saveButtonSelected;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4C84", Offset = "0xBA4C84")]
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
		[Address(RVA = "0x22E18D0", Offset = "0x22E18D0", VA = "0x22E18D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public bool selected
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x22E18D4", Offset = "0x22E18D4", VA = "0x22E18D4", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x22E18DC", Offset = "0x22E18DC", VA = "0x22E18DC", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool selectionChanged
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x22E18F0", Offset = "0x22E18F0", VA = "0x22E18F0", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5A58", Offset = "0xBA5A58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x22E18F8", Offset = "0x22E18F8", VA = "0x22E18F8", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5A68", Offset = "0xBA5A68")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public bool buttonSelected
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x22E1904", Offset = "0x22E1904", VA = "0x22E1904", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x22E190C", Offset = "0x22E190C", VA = "0x22E190C", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x22E1920", Offset = "0x22E1920", VA = "0x22E1920", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5A78", Offset = "0xBA5A78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x22E1928", Offset = "0x22E1928", VA = "0x22E1928", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5A88", Offset = "0xBA5A88")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool hasButtonSelectedComponents
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x22E1934", Offset = "0x22E1934", VA = "0x22E1934")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public bool isPrefab
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x22E1A30", Offset = "0x22E1A30", VA = "0x22E1A30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x22E1A54", Offset = "0x22E1A54", VA = "0x22E1A54")]
	public ES2AutoSaveVariableInfo GetCachedVariableInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x22E1B6C", Offset = "0x22E1B6C", VA = "0x22E1B6C")]
	public ES2AutoSaveVariableInfo CacheVariableInfo(ES2AutoSaveVariableInfo variable)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x22E1BD8", Offset = "0x22E1BD8", VA = "0x22E1BD8")]
	public void RemoveCachedVariableInfo(string id)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x22E1D2C", Offset = "0x22E1D2C", VA = "0x22E1D2C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x22E22D4", Offset = "0x22E22D4", VA = "0x22E22D4")]
	public ES2AutoSaveComponentInfo GetComponentInfo(Component c)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x22E23F8", Offset = "0x22E23F8", VA = "0x22E23F8")]
	public ES2AutoSaveComponentInfo GetComponentInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x22E24FC", Offset = "0x22E24FC", VA = "0x22E24FC")]
	public ES2AutoSaveComponentInfo AddComponentInfo(ES2AutoSaveComponentInfo info)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x22E2568", Offset = "0x22E2568", VA = "0x22E2568")]
	public static ES2AutoSave AddAutoSave(GameObject go, Color color, bool hide, bool generateID, string id)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x22E2A30", Offset = "0x22E2A30", VA = "0x22E2A30")]
	public static ES2AutoSave GetAutoSave(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x22E20B0", Offset = "0x22E20B0", VA = "0x22E20B0")]
	public static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x22E2A84", Offset = "0x22E2A84", VA = "0x22E2A84")]
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
	[Address(RVA = "0x22E2B98", Offset = "0x22E2B98", VA = "0x22E2B98")]
	public ES2AutoSaveComponentInfo()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x22E2C44", Offset = "0x22E2C44", VA = "0x22E2C44")]
	public ES2AutoSaveComponentInfo(Component c, ES2AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x22E2E1C", Offset = "0x22E2E1C", VA = "0x22E2E1C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4D14", Offset = "0xBA4D14")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4D44", Offset = "0xBA4D44")]
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
		[Address(RVA = "0x22E6660", Offset = "0x22E6660", VA = "0x22E6660", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x22E6668", Offset = "0x22E6668", VA = "0x22E6668", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	[SerializeField]
	public bool selectionChanged
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x22E667C", Offset = "0x22E667C", VA = "0x22E667C", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5A98", Offset = "0xBA5A98")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x22E6684", Offset = "0x22E6684", VA = "0x22E6684", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5AA8", Offset = "0xBA5AA8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool buttonSelected
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x22E6690", Offset = "0x22E6690", VA = "0x22E6690", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x22E6698", Offset = "0x22E6698", VA = "0x22E6698", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x22E66AC", Offset = "0x22E66AC", VA = "0x22E66AC", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5AB8", Offset = "0xBA5AB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x22E66B4", Offset = "0x22E66B4", VA = "0x22E66B4", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5AC8", Offset = "0xBA5AC8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public ES2AutoSave autoSave
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x22E66C0", Offset = "0x22E66C0", VA = "0x22E66C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x22E2DD4", Offset = "0x22E2DD4", VA = "0x22E2DD4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x22E677C", Offset = "0x22E677C", VA = "0x22E677C", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public Type type
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x22E2D40", Offset = "0x22E2D40", VA = "0x22E2D40")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x22E2CF8", Offset = "0x22E2CF8", VA = "0x22E2CF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool HasButtonSelectedVariables
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x22E6780", Offset = "0x22E6780", VA = "0x22E6780")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x22E2B9C", Offset = "0x22E2B9C", VA = "0x22E2B9C")]
	public ES2AutoSaveVariableInfo()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x22E28E8", Offset = "0x22E28E8", VA = "0x22E28E8")]
	public ES2AutoSaveVariableInfo(string name, Type type, bool isProperty, ES2AutoSave autoSave, ES2AutoSaveVariableInfo previous)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x22E68BC", Offset = "0x22E68BC", VA = "0x22E68BC")]
	public ES2AutoSaveVariableInfo GetVariableInfo(string name)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x22E69A4", Offset = "0x22E69A4", VA = "0x22E69A4")]
	public ES2AutoSaveVariableInfo AddVariableInfo(string name, Type type, bool isProperty, [Optional] ES2AutoSave autoSave, [Optional] ES2AutoSaveVariableInfo previous)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x22E6AD4", Offset = "0x22E6AD4", VA = "0x22E6AD4")]
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
	[Address(RVA = "0x22E2EA8", Offset = "0x22E2EA8", VA = "0x22E2EA8")]
	public ES2AutoSaveGlobalManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class ES2AutoSaveManager : MonoBehaviour
{
	[Token(Token = "0x2000009")]
	public enum LoadEvent
	{
		[Token(Token = "0x4000033")]
		Start,
		[Token(Token = "0x4000034")]
		OnApplicationUnPause,
		[Token(Token = "0x4000035")]
		None
	}

	[Token(Token = "0x200000A")]
	public enum SaveEvent
	{
		[Token(Token = "0x4000037")]
		OnApplicationQuit,
		[Token(Token = "0x4000038")]
		OnApplicationPause,
		[Token(Token = "0x4000039")]
		OnDisable,
		[Token(Token = "0x400003A")]
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
		[Address(RVA = "0x22E1F74", Offset = "0x22E1F74", VA = "0x22E1F74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x22E2F2C", Offset = "0x22E2F2C", VA = "0x22E2F2C")]
	public void SetFilePath(string filePath)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x22E2F34", Offset = "0x22E2F34", VA = "0x22E2F34")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x22E2238", Offset = "0x22E2238", VA = "0x22E2238")]
	public void AddAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x22E3094", Offset = "0x22E3094", VA = "0x22E3094")]
	public ES2AutoSave GetAutoSave(string id)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x22E3110", Offset = "0x22E3110", VA = "0x22E3110")]
	public void AddChildAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x22E317C", Offset = "0x22E317C", VA = "0x22E317C")]
	public void Save()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x22E3330", Offset = "0x22E3330", VA = "0x22E3330")]
	public void Load()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x22E382C", Offset = "0x22E382C", VA = "0x22E382C")]
	public void WriteAutoSaves(ES2Writer writer)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x22E3A90", Offset = "0x22E3A90", VA = "0x22E3A90")]
	private void WriteAutoSaveRecursive(Transform transform, ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x22E3FC4", Offset = "0x22E3FC4", VA = "0x22E3FC4")]
	private void WriteAutoSave(ES2AutoSave autoSave, Transform transform, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x22E49EC", Offset = "0x22E49EC", VA = "0x22E49EC")]
	private void WriteVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Writer writer, object obj)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x22E5174", Offset = "0x22E5174", VA = "0x22E5174")]
	public void ReadAutoSaves(ES2Reader reader)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x22E51A8", Offset = "0x22E51A8", VA = "0x22E51A8")]
	private bool ReadAutoSave(ES2Reader reader, [Optional] ES2AutoSave autoSave)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x22E5C1C", Offset = "0x22E5C1C", VA = "0x22E5C1C")]
	private void ReadComponent(ES2AutoSave autoSave, ES2Reader reader)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x22E5F38", Offset = "0x22E5F38", VA = "0x22E5F38")]
	private void ReadVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Reader reader, object obj)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x22E4FB8", Offset = "0x22E4FB8", VA = "0x22E4FB8")]
	protected void WriteAllComponents(ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x22E63D0", Offset = "0x22E63D0", VA = "0x22E63D0")]
	public void Start()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x22E63E0", Offset = "0x22E63E0", VA = "0x22E63E0")]
	public void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x22E6438", Offset = "0x22E6438", VA = "0x22E6438")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x22E6448", Offset = "0x22E6448", VA = "0x22E6448")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x22E645C", Offset = "0x22E645C", VA = "0x22E645C")]
	public ES2AutoSaveManager()
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E260", Offset = "0xB9E260")]
public static class ES2DirectoryUtility
{
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x22E80E0", Offset = "0x22E80E0", VA = "0x22E80E0")]
	public static void Delete(string path, bool recursive)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x22E80EC", Offset = "0x22E80EC", VA = "0x22E80EC")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x22E80F4", Offset = "0x22E80F4", VA = "0x22E80F4")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x22E80FC", Offset = "0x22E80FC", VA = "0x22E80FC")]
	public static void CreateDirectory(string path)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x22E8104", Offset = "0x22E8104", VA = "0x22E8104")]
	public static string[] GetDirectories(string path)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x22E810C", Offset = "0x22E810C", VA = "0x22E810C")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E274", Offset = "0xB9E274")]
public static class ES2Dispose
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x22E8114", Offset = "0x22E8114", VA = "0x22E8114")]
	public static void Dispose(BinaryReader reader)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x22E8130", Offset = "0x22E8130", VA = "0x22E8130")]
	public static void Dispose(BinaryWriter writer)
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E288", Offset = "0xB9E288")]
public static class ES2FileUtility
{
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x22E8220", Offset = "0x22E8220", VA = "0x22E8220")]
	public static void Delete(string path)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x22E8218", Offset = "0x22E8218", VA = "0x22E8218")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x22E86B4", Offset = "0x22E86B4", VA = "0x22E86B4")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x22E8B74", Offset = "0x22E8B74", VA = "0x22E8B74")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x22E8AC0", Offset = "0x22E8AC0", VA = "0x22E8AC0")]
	public static Stream CreateFileStream(string path, ES2Settings.ES2FileMode filemode, int bufferSize)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E29C", Offset = "0xB9E29C")]
public static class ES2TypeUtility
{
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x277B278", Offset = "0x277B278", VA = "0x277B278")]
	public static bool IsEnum(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000F")]
public static class ES2
{
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool initialised;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x22DBC8C", Offset = "0x22DBC8C", VA = "0x22DBC8C")]
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
	[Address(RVA = "0x22DBD14", Offset = "0x22DBD14", VA = "0x22DBD14")]
	public static void SaveRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x22DBF30", Offset = "0x22DBF30", VA = "0x22DBF30")]
	public static void SaveRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x22DBDB0", Offset = "0x22DBDB0", VA = "0x22DBDB0")]
	public static void SaveRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x22DBFD4", Offset = "0x22DBFD4", VA = "0x22DBFD4")]
	public static void SaveRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x22DC148", Offset = "0x22DC148", VA = "0x22DC148")]
	public static void SaveRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x22DC2E0", Offset = "0x22DC2E0", VA = "0x22DC2E0")]
	public static void SaveRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x22DC46C", Offset = "0x22DC46C", VA = "0x22DC46C")]
	public static void AppendRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x22DC698", Offset = "0x22DC698", VA = "0x22DC698")]
	public static void AppendRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x22DC508", Offset = "0x22DC508", VA = "0x22DC508")]
	public static void AppendRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x22DC73C", Offset = "0x22DC73C", VA = "0x22DC73C")]
	public static void AppendRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x22DC8BC", Offset = "0x22DC8BC", VA = "0x22DC8BC")]
	public static void AppendRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x22DCA64", Offset = "0x22DCA64", VA = "0x22DCA64")]
	public static void AppendRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x22DCBFC", Offset = "0x22DCBFC", VA = "0x22DCBFC")]
	public static void SaveImage(Texture2D tex, string identifier)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x22DCE10", Offset = "0x22DCE10", VA = "0x22DCE10")]
	public static byte[] LoadRaw(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x22DCF8C", Offset = "0x22DCF8C", VA = "0x22DCF8C")]
	public static byte[] LoadRaw(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x22DD0F4", Offset = "0x22DD0F4", VA = "0x22DD0F4")]
	public static object LoadObject(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x22DD280", Offset = "0x22DD280", VA = "0x22DD280")]
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
	[Address(RVA = "0x22DD3FC", Offset = "0x22DD3FC", VA = "0x22DD3FC")]
	public static ES2Data LoadAll(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x22DD578", Offset = "0x22DD578", VA = "0x22DD578")]
	public static ES2Data LoadAll(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x22DD6E0", Offset = "0x22DD6E0", VA = "0x22DD6E0")]
	public static Texture2D LoadImage(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x22DD94C", Offset = "0x22DD94C", VA = "0x22DD94C")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x22DD9C0", Offset = "0x22DD9C0", VA = "0x22DD9C0")]
	public static AudioClip LoadAudio(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x22DDE80", Offset = "0x22DDE80", VA = "0x22DDE80")]
	public static void CacheFile(string identifier)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x22DDFE4", Offset = "0x22DDFE4", VA = "0x22DDFE4")]
	public static bool Exists(string identifier)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x22DE4A0", Offset = "0x22DE4A0", VA = "0x22DE4A0")]
	public static bool Exists(string identifier, ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x22DE4CC", Offset = "0x22DE4CC", VA = "0x22DE4CC")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x22DE7AC", Offset = "0x22DE7AC", VA = "0x22DE7AC")]
	public static void Delete(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x22DE7D8", Offset = "0x22DE7D8", VA = "0x22DE7D8")]
	public static void DeleteDefaultFolder()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x22DEAD4", Offset = "0x22DEAD4", VA = "0x22DEAD4")]
	public static void Rename(string identifier, string newIdentifier)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x22DEE00", Offset = "0x22DEE00", VA = "0x22DEE00")]
	public static void Rename(string identifier, string newIdentifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x22DEE5C", Offset = "0x22DEE5C", VA = "0x22DEE5C")]
	public static string[] GetFiles(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x22DEF08", Offset = "0x22DEF08", VA = "0x22DEF08")]
	public static string[] GetFiles(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x22DEF34", Offset = "0x22DEF34", VA = "0x22DEF34")]
	public static string[] GetFiles(string identifier, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x22DF1B4", Offset = "0x22DF1B4", VA = "0x22DF1B4")]
	public static string[] GetFolders(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x22DF41C", Offset = "0x22DF41C", VA = "0x22DF41C")]
	public static string[] GetFolders(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x22DF448", Offset = "0x22DF448", VA = "0x22DF448")]
	public static string[] GetTags(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x22DF5F8", Offset = "0x22DF5F8", VA = "0x22DF5F8")]
	public static string[] GetTags(string identifier, ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x2000010")]
public class ES2Auto : MonoBehaviour
{
	[Token(Token = "0x2000011")]
	public enum SaveEvent
	{
		[Token(Token = "0x4000055")]
		OnDisable,
		[Token(Token = "0x4000056")]
		OnInterval
	}

	[Token(Token = "0x2000012")]
	public enum LoadEvent
	{
		[Token(Token = "0x4000058")]
		OnAwake,
		[Token(Token = "0x4000059")]
		OnStart,
		[Token(Token = "0x400005A")]
		OnEnable
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E2B0", Offset = "0xB9E2B0")]
	private sealed class <SaveRoutine>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Auto <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x301155C", Offset = "0x301155C", VA = "0x301155C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x30115A4", Offset = "0x30115A4", VA = "0x30115A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x301145C", Offset = "0x301145C", VA = "0x301145C")]
		[DebuggerHidden]
		public <SaveRoutine>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3011488", Offset = "0x3011488", VA = "0x3011488", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x301148C", Offset = "0x301148C", VA = "0x301148C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x3011564", Offset = "0x3011564", VA = "0x3011564", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool saveOnDisable;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	public bool saveOnInterval;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float saveInterval;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool loadOnEnable;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[SerializeField]
	public bool loadOnAwake;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	[SerializeField]
	public bool loadOnStart;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	[SerializeField]
	public bool isPlayMaker;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string uniqueTag;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool savePosition;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[SerializeField]
	public bool saveRotation;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	[SerializeField]
	public bool saveScale;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	[SerializeField]
	public bool saveMesh;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public bool saveSphereCollider;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	[SerializeField]
	public bool saveBoxCollider;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	[SerializeField]
	public bool saveCapsuleCollider;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	[SerializeField]
	public bool saveMeshCollider;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string saveFile;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public ES2Settings.SaveLocation saveLocation;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	public bool encrypt;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public string encryptionPassword;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public string webUsername;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public string webPassword;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isQuitting;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ES2Settings settings;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x22DF628", Offset = "0x22DF628", VA = "0x22DF628")]
	private void SavePosition()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x22DF7D0", Offset = "0x22DF7D0", VA = "0x22DF7D0")]
	private void LoadPosition()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x22DF900", Offset = "0x22DF900", VA = "0x22DF900")]
	private void SaveRotation()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x22DF9F4", Offset = "0x22DF9F4", VA = "0x22DF9F4")]
	private void LoadRotation()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x22DFB24", Offset = "0x22DFB24", VA = "0x22DFB24")]
	private void SaveScale()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x22DFC10", Offset = "0x22DFC10", VA = "0x22DFC10")]
	private void LoadScale()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x22DFD40", Offset = "0x22DFD40", VA = "0x22DFD40")]
	private void SaveMesh()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x22DFF44", Offset = "0x22DFF44", VA = "0x22DFF44")]
	private void LoadMesh()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x22E0244", Offset = "0x22E0244", VA = "0x22E0244")]
	private void SaveSphereCollider()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x22E0410", Offset = "0x22E0410", VA = "0x22E0410")]
	private void LoadSphereCollider()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x22E06BC", Offset = "0x22E06BC", VA = "0x22E06BC")]
	private void SaveCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x22E0888", Offset = "0x22E0888", VA = "0x22E0888")]
	private void LoadCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x22E0B34", Offset = "0x22E0B34", VA = "0x22E0B34")]
	private void SaveBoxCollider()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x22E0D00", Offset = "0x22E0D00", VA = "0x22E0D00")]
	private void LoadBoxCollider()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x22E0FAC", Offset = "0x22E0FAC", VA = "0x22E0FAC")]
	private void SaveMeshCollider()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x22E1178", Offset = "0x22E1178", VA = "0x22E1178")]
	private void LoadMeshCollider()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x22E1424", Offset = "0x22E1424", VA = "0x22E1424")]
	public void Save()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x22E14C8", Offset = "0x22E14C8", VA = "0x22E14C8")]
	public void Load()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x22E156C", Offset = "0x22E156C", VA = "0x22E156C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5AD8", Offset = "0xBA5AD8")]
	private IEnumerator SaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x22E15E4", Offset = "0x22E15E4", VA = "0x22E15E4")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x22E15FC", Offset = "0x22E15FC", VA = "0x22E15FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x22E161C", Offset = "0x22E161C", VA = "0x22E161C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x22E1790", Offset = "0x22E1790", VA = "0x22E1790")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x22E17A8", Offset = "0x22E17A8", VA = "0x22E17A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x22DF714", Offset = "0x22DF714", VA = "0x22DF714")]
	private string GetFullFilename(string tagExtension)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x22E167C", Offset = "0x22E167C", VA = "0x22E167C")]
	private void InitializeSettings()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x22E17C0", Offset = "0x22E17C0", VA = "0x22E17C0")]
	public ES2Auto()
	{
	}
}
[Token(Token = "0x2000014")]
public static class ES2Cache
{
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, ES2CachedFile> fileCaches;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x22E6B4C", Offset = "0x22E6B4C", VA = "0x22E6B4C")]
	public static ES2CachedFile AddNewCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x22E6C98", Offset = "0x22E6C98", VA = "0x22E6C98")]
	public static bool DeleteCachedFile(string absolutePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x22E6D24", Offset = "0x22E6D24", VA = "0x22E6D24")]
	public static ES2CachedFile GetOrCreateCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x22E6DF0", Offset = "0x22E6DF0", VA = "0x22E6DF0")]
	public static ES2CachedFile GetCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x22E6E9C", Offset = "0x22E6E9C", VA = "0x22E6E9C")]
	public new static string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000015")]
public class ES2CachedFile
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, ES2Tag> tagCache;

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x22E7374", Offset = "0x22E7374", VA = "0x22E7374")]
	public void AddTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x22E73D0", Offset = "0x22E73D0", VA = "0x22E73D0")]
	public void AddTag(ES2Tag tag)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x22E7464", Offset = "0x22E7464", VA = "0x22E7464")]
	public ES2Tag AddOrUpdateTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x22E75A8", Offset = "0x22E75A8", VA = "0x22E75A8")]
	public ES2Tag GetTag(string tag)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x22E7668", Offset = "0x22E7668", VA = "0x22E7668")]
	public bool RemoveTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x22E76CC", Offset = "0x22E76CC", VA = "0x22E76CC")]
	public void RenameTag(string oldTag, string newTag)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x22E7798", Offset = "0x22E7798", VA = "0x22E7798", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x22E6C14", Offset = "0x22E6C14", VA = "0x22E6C14")]
	public ES2CachedFile()
	{
	}
}
[Token(Token = "0x2000016")]
public struct ES2Tag
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string tag;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public long position;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long settingsPosition;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public long nextTagPosition;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isNull;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x2778DEC", Offset = "0x2778DEC", VA = "0x2778DEC")]
	public ES2Tag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x2777ABC", Offset = "0x2777ABC", VA = "0x2777ABC")]
	public ES2Tag(bool isNull)
	{
	}
}
[Token(Token = "0x2000017")]
public class ES2Data
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<string, object> loadedData;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x22E7DB8", Offset = "0x22E7DB8", VA = "0x22E7DB8")]
	public void Add(string tag, object value)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x22E7E24", Offset = "0x22E7E24", VA = "0x22E7E24")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x22E7E88", Offset = "0x22E7E88", VA = "0x22E7E88")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	public T Load<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x60000EC")]
	public T[] LoadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	public T[,] Load2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	public T[,,] Load3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	public Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	public List<T> LoadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	public HashSet<T> LoadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000F2")]
	public Queue<T> LoadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	public Stack<T> LoadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x22E805C", Offset = "0x22E805C", VA = "0x22E805C")]
	public ES2Data()
	{
	}
}
[Token(Token = "0x2000018")]
public class ES2EditorWindowStyle : MonoBehaviour
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GUIStyle hierarchyLabelStyle;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GUIStyle hierarchyLabelHighlightedStyle;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GUIStyle saveButtonStyle;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GUIStyle saveButtonSelectedStyle;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GUIStyle menuStyle;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GUIStyle menuMainButtonStyle;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GUIStyle menuSubButtonStyle;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GUIStyle inputLabelStyle;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GUIStyle textInputStyle;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle textAreaStyle;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GUIStyle toggleInputStyle;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GUIStyle windowContentStyle;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GUIStyle sectionStyle;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GUIStyle indentStyle;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GUIStyle columnStyle;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GUIStyle titleStyle;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GUIStyle subHeadingStyle;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GUIStyle contentButtonStyle;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GUIStyle contentTextStyle;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Texture2D windowIcon;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Texture2D windowBackground;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D whiteBackground;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Texture2D lightGreyBackground;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Texture2D toggleSelectedBackground;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Texture2D subMenuBackground;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Font bebas;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Font robotoSlab;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x22E814C", Offset = "0x22E814C", VA = "0x22E814C")]
	public ES2EditorWindowStyle()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E2C0", Offset = "0xB9E2C0")]
public static class ES2File
{
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x22DE52C", Offset = "0x22DE52C", VA = "0x22DE52C")]
	public static void Delete(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x22E8198", Offset = "0x22E8198", VA = "0x22E8198")]
	public static void DeleteFile(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x22E8228", Offset = "0x22E8228", VA = "0x22E8228")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x22DE044", Offset = "0x22DE044", VA = "0x22DE044")]
	public static bool Exists(ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x22E8370", Offset = "0x22E8370", VA = "0x22E8370")]
	private static bool CheckForTagInBytes(string tag, byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x22E85C0", Offset = "0x22E85C0", VA = "0x22E85C0")]
	public static void CreateFolder(string identifier)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x22DEB5C", Offset = "0x22DEB5C", VA = "0x22DEB5C")]
	public static void Rename(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x22E85C8", Offset = "0x22E85C8", VA = "0x22E85C8")]
	public static void MoveFile(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x22DF214", Offset = "0x22DF214", VA = "0x22DF214")]
	public static string[] GetFolders(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x22DEEBC", Offset = "0x22DEEBC", VA = "0x22DEEBC")]
	public static string[] GetFiles(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x22DEFA4", Offset = "0x22DEFA4", VA = "0x22DEFA4")]
	public static string[] GetFiles(ES2Settings settings, string extension)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x22DF4A8", Offset = "0x22DF4A8", VA = "0x22DF4A8")]
	public static string[] GetTags(ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class ES2Reflection
{
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2779020", Offset = "0x2779020", VA = "0x2779020")]
	public static bool SetValue(object obj, string name, object value, bool isProperty = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x27790EC", Offset = "0x27790EC", VA = "0x27790EC")]
	public static object GetValue(object obj, string name, bool isProperty = false)
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2774364", Offset = "0x2774364", VA = "0x2774364")]
	public static bool IsAssignableFrom(Type a, Type b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2774384", Offset = "0x2774384", VA = "0x2774384")]
	public static bool IsGenericType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x27791C4", Offset = "0x27791C4", VA = "0x27791C4")]
	public static Type[] GetGenericArguments(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x27758A0", Offset = "0x27758A0", VA = "0x27758A0")]
	public static object CreateGenericInstance(Type type, Type genericType)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2775CD0", Offset = "0x2775CD0", VA = "0x2775CD0")]
	public static object CreateGenericInstance(Type type, Type genericType, Type genericType2)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x27791E4", Offset = "0x27791E4", VA = "0x27791E4")]
	public static bool IsCollectionType(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB9E2D4", Offset = "0xB9E2D4")]
public class ES2Spreadsheet
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<ES2SpreadsheetRow> sheet;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool append;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static byte[] comma;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static byte[] newline;

	[Token(Token = "0x1700001A")]
	public string Item
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x277A71C", Offset = "0x277A71C", VA = "0x277A71C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x277A720", Offset = "0x277A720", VA = "0x277A720")]
		set
		{
		}
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2779D64", Offset = "0x2779D64", VA = "0x2779D64")]
	public ES2Spreadsheet()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x2779F40", Offset = "0x2779F40", VA = "0x2779F40")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x277A228", Offset = "0x277A228", VA = "0x277A228")]
	public string GetCell(int col, int row)
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x277A078", Offset = "0x277A078", VA = "0x277A078")]
	private void SizeSpreadsheetToFitRow(int row)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x277A308", Offset = "0x277A308", VA = "0x277A308")]
	public void Save(string path)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x277A374", Offset = "0x277A374", VA = "0x277A374")]
	public void Save(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2779E18", Offset = "0x2779E18", VA = "0x2779E18")]
	private static void GetCharacterConstants()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x277A724", Offset = "0x277A724", VA = "0x277A724", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB9E30C", Offset = "0xB9E30C")]
public class ES2SpreadsheetRow
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<string> cells;

	[Token(Token = "0x1700001B")]
	public int cellCount
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x277A67C", Offset = "0x277A67C", VA = "0x277A67C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001C")]
	public string Item
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x277A304", Offset = "0x277A304", VA = "0x277A304")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x277AB80", Offset = "0x277AB80", VA = "0x277AB80")]
		set
		{
		}
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x277A1B0", Offset = "0x277A1B0", VA = "0x277A1B0")]
	public void SetCell(int col, string value)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x277A928", Offset = "0x277A928", VA = "0x277A928")]
	public string GetCell(int col)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x277A664", Offset = "0x277A664", VA = "0x277A664")]
	public byte[] GetCellBytes(int col)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x277A874", Offset = "0x277A874", VA = "0x277A874")]
	private void SizeRowToFitColumn(int col)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x277A9EC", Offset = "0x277A9EC", VA = "0x277A9EC")]
	private byte[] GetBytes(string data)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x277AB84", Offset = "0x277AB84", VA = "0x277AB84", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x277A12C", Offset = "0x277A12C", VA = "0x277A12C")]
	public ES2SpreadsheetRow()
	{
	}
}
[Token(Token = "0x200001D")]
public class ES2Web
{
	[Token(Token = "0x200001E")]
	public enum HashType
	{
		[Token(Token = "0x400008E")]
		MD5,
		[Token(Token = "0x400008F")]
		None
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E344", Offset = "0xB9E344")]
	private sealed class <Upload>d__18<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T param;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000153")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000155")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014F")]
		[DebuggerHidden]
		public <Upload>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000150")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000151")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000152")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000154")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E354", Offset = "0xB9E354")]
	private sealed class <Upload>d__19<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] param;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015A")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015C")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000156")]
		[DebuggerHidden]
		public <Upload>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000157")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000158")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600015B")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E364", Offset = "0xB9E364")]
	private sealed class <Upload>d__20<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[,] param;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000161")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000163")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015D")]
		[DebuggerHidden]
		public <Upload>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600015E")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015F")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000162")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E374", Offset = "0xB9E374")]
	private sealed class <Upload>d__21<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[,,] param;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000168")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016A")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000164")]
		[DebuggerHidden]
		public <Upload>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000165")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000166")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000169")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E384", Offset = "0xB9E384")]
	private sealed class <Upload>d__22<TKey, TValue> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<TKey, TValue> param;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000171")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016B")]
		[DebuggerHidden]
		public <Upload>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600016C")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016D")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000170")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E394", Offset = "0xB9E394")]
	private sealed class <Upload>d__23<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> param;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000176")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000178")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000172")]
		[DebuggerHidden]
		public <Upload>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000173")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000174")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000177")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E3A4", Offset = "0xB9E3A4")]
	private sealed class <Upload>d__24<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HashSet<T> param;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600017D")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000179")]
		[DebuggerHidden]
		public <Upload>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600017A")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017B")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600017E")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E3B4", Offset = "0xB9E3B4")]
	private sealed class <Upload>d__25<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Queue<T> param;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000184")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000186")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000180")]
		[DebuggerHidden]
		public <Upload>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000181")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000182")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000185")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E3C4", Offset = "0xB9E3C4")]
	private sealed class <Upload>d__26<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Stack<T> param;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ES2Writer <writer>5__2;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018B")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018D")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[DebuggerHidden]
		public <Upload>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000188")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000189")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600018C")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E3D4", Offset = "0xB9E3D4")]
	private sealed class <UploadRaw>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] data;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x3011FE4", Offset = "0x3011FE4", VA = "0x3011FE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x301202C", Offset = "0x301202C", VA = "0x301202C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x3011E98", Offset = "0x3011E98", VA = "0x3011E98")]
		[DebuggerHidden]
		public <UploadRaw>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x3011EC4", Offset = "0x3011EC4", VA = "0x3011EC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3011EC8", Offset = "0x3011EC8", VA = "0x3011EC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x3011FEC", Offset = "0x3011FEC", VA = "0x3011FEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E3E4", Offset = "0xB9E3E4")]
	private sealed class <UploadImage>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D tex;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x3011E48", Offset = "0x3011E48", VA = "0x3011E48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x3011E90", Offset = "0x3011E90", VA = "0x3011E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x3011CF0", Offset = "0x3011CF0", VA = "0x3011CF0")]
		[DebuggerHidden]
		public <UploadImage>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x3011D1C", Offset = "0x3011D1C", VA = "0x3011D1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x3011D20", Offset = "0x3011D20", VA = "0x3011D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x3011E50", Offset = "0x3011E50", VA = "0x3011E50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E3F4", Offset = "0xB9E3F4")]
	private sealed class <UploadFile>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string file;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x3011CA0", Offset = "0x3011CA0", VA = "0x3011CA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x3011CE8", Offset = "0x3011CE8", VA = "0x3011CE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x3011B18", Offset = "0x3011B18", VA = "0x3011B18")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x3011B44", Offset = "0x3011B44", VA = "0x3011B44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x3011B48", Offset = "0x3011B48", VA = "0x3011B48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x3011CA8", Offset = "0x3011CA8", VA = "0x3011CA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E404", Offset = "0xB9E404")]
	private sealed class <DownloadFilenames>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x3011AC8", Offset = "0x3011AC8", VA = "0x3011AC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x3011B10", Offset = "0x3011B10", VA = "0x3011B10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x3011980", Offset = "0x3011980", VA = "0x3011980")]
		[DebuggerHidden]
		public <DownloadFilenames>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x30119AC", Offset = "0x30119AC", VA = "0x30119AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x30119B0", Offset = "0x30119B0", VA = "0x30119B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x3011AD0", Offset = "0x3011AD0", VA = "0x3011AD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E414", Offset = "0xB9E414")]
	private sealed class <Download>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x3011930", Offset = "0x3011930", VA = "0x3011930", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x3011978", Offset = "0x3011978", VA = "0x3011978", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x30117E8", Offset = "0x30117E8", VA = "0x30117E8")]
		[DebuggerHidden]
		public <Download>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3011814", Offset = "0x3011814", VA = "0x3011814", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x3011818", Offset = "0x3011818", VA = "0x3011818", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x3011938", Offset = "0x3011938", VA = "0x3011938", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E424", Offset = "0xB9E424")]
	private sealed class <Delete>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES2Web <>4__this;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x3011798", Offset = "0x3011798", VA = "0x3011798", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x30117E0", Offset = "0x30117E0", VA = "0x30117E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x30115AC", Offset = "0x30115AC", VA = "0x30115AC")]
		[DebuggerHidden]
		public <Delete>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x30115D8", Offset = "0x30115D8", VA = "0x30115D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x30115DC", Offset = "0x30115DC", VA = "0x30115DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x30117A0", Offset = "0x30117A0", VA = "0x30117A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool isDone;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool isError;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string error;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string errorCode;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HashType hashType;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES2Settings settings;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WWW www;

	[Token(Token = "0x1700001D")]
	public byte[] data
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x277B390", Offset = "0x277B390", VA = "0x277B390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public string text
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x277B3AC", Offset = "0x277B3AC", VA = "0x277B3AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public float progress
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x277B3C8", Offset = "0x277B3C8", VA = "0x277B3C8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000020")]
	public float uploadProgress
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x277B3E4", Offset = "0x277B3E4", VA = "0x277B3E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x277B400", Offset = "0x277B400", VA = "0x277B400")]
	public ES2Web(string identifier)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x277B4B0", Offset = "0x277B4B0", VA = "0x277B4B0")]
	public ES2Web(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000125")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5B88", Offset = "0xBA5B88")]
	public IEnumerator Upload<T>(T param)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5BE8", Offset = "0xBA5BE8")]
	public IEnumerator Upload<T>(T[] param)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5C48", Offset = "0xBA5C48")]
	public IEnumerator Upload<T>(T[,] param)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5CA8", Offset = "0xBA5CA8")]
	public IEnumerator Upload<T>(T[,,] param)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5D08", Offset = "0xBA5D08")]
	public IEnumerator Upload<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5D68", Offset = "0xBA5D68")]
	public IEnumerator Upload<T>(List<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5DC8", Offset = "0xBA5DC8")]
	public IEnumerator Upload<T>(HashSet<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5E28", Offset = "0xBA5E28")]
	public IEnumerator Upload<T>(Queue<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5E88", Offset = "0xBA5E88")]
	public IEnumerator Upload<T>(Stack<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x277B550", Offset = "0x277B550", VA = "0x277B550")]
	public IEnumerator UploadRaw(string data)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x277B59C", Offset = "0x277B59C", VA = "0x277B59C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5EE8", Offset = "0xBA5EE8")]
	public IEnumerator UploadRaw(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x277B630", Offset = "0x277B630", VA = "0x277B630")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5F48", Offset = "0xBA5F48")]
	public IEnumerator UploadImage(Texture2D tex)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x277B6C4", Offset = "0x277B6C4", VA = "0x277B6C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA5FA8", Offset = "0xBA5FA8")]
	public IEnumerator UploadFile(string file)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x277B758", Offset = "0x277B758", VA = "0x277B758")]
	public Texture2D LoadImage()
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x277B924", Offset = "0x277B924", VA = "0x277B924")]
	public byte[] LoadRaw()
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	public T Load<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x6000135")]
	public void Load<T>(string tag, T c) where T : class
	{
	}

	[Token(Token = "0x6000136")]
	public T[] LoadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	public void LoadArray<T>(string tag, T[] c) where T : class
	{
	}

	[Token(Token = "0x6000138")]
	public T[,] Load2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	public T[,,] Load3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	public Dictionary<TKey, TValue> LoadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	public List<T> LoadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	public HashSet<T> LoadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	public Queue<T> LoadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	public Stack<T> LoadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x277B95C", Offset = "0x277B95C", VA = "0x277B95C")]
	public void SaveToFile(string identifier)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x277B9EC", Offset = "0x277B9EC", VA = "0x277B9EC")]
	public void SaveToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x277BA9C", Offset = "0x277BA9C", VA = "0x277BA9C")]
	public void AppendToFile(string identifier)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x277BB2C", Offset = "0x277BB2C", VA = "0x277BB2C")]
	public void AppendToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x277BBD8", Offset = "0x277BBD8", VA = "0x277BBD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6008", Offset = "0xBA6008")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x277BC50", Offset = "0x277BC50", VA = "0x277BC50")]
	public string[] GetFilenames()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x277BCF0", Offset = "0x277BCF0", VA = "0x277BCF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6068", Offset = "0xBA6068")]
	public IEnumerator Download()
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x277BD68", Offset = "0x277BD68", VA = "0x277BD68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA60C8", Offset = "0xBA60C8")]
	public IEnumerator Delete()
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x277BDE0", Offset = "0x277BDE0", VA = "0x277BDE0")]
	private WWWForm CreateUploadForm(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x277BFD8", Offset = "0x277BFD8", VA = "0x277BFD8")]
	private WWWForm CreateDownloadForm()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x277C0C4", Offset = "0x277C0C4", VA = "0x277C0C4")]
	private WWWForm CreateGetFilesForm()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x277B7E8", Offset = "0x277B7E8", VA = "0x277B7E8")]
	private void CheckWWWUsage()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x277B880", Offset = "0x277B880", VA = "0x277B880")]
	private void CheckDownloadUsage()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x277C144", Offset = "0x277C144", VA = "0x277C144")]
	private bool getError()
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x277BE94", Offset = "0x277BE94", VA = "0x277BE94")]
	private WWWForm CreateForm()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x277C448", Offset = "0x277C448", VA = "0x277C448")]
	private static string StringToMD5(string str)
	{
		return null;
	}
}
[Token(Token = "0x200002E")]
public struct ES2Header
{
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ES2Keys.Key collectionType;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int keyType;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int valueType;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x2773A68", Offset = "0x2773A68", VA = "0x2773A68")]
	public ES2Header(ES2Keys.Key collectionType, int keyType, int valueType, ES2Settings settings)
	{
	}
}
[Token(Token = "0x200002F")]
public class ES2Reader : IDisposable
{
	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4EC4", Offset = "0xBA4EC4")]
	public ES2Stream stream;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings settings;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4ED8", Offset = "0xBA4ED8")]
	private ES2CachedFile cachedFile;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4EEC", Offset = "0xBA4EEC")]
	public ES2Tag currentTag;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BinaryReader reader;

	[Token(Token = "0x1700003F")]
	public int Length
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x27772C8", Offset = "0x27772C8", VA = "0x27772C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001B3")]
	public T Read<T>(ES2Type es2type)
	{
		return (T)null;
	}

	[Token(Token = "0x60001B4")]
	public void Read<T>(ES2Type es2type, T c) where T : class
	{
	}

	[Token(Token = "0x60001B5")]
	public T[] ReadArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001B6")]
	public void ReadArray<T>(ES2Type type, T[] c) where T : class
	{
	}

	[Token(Token = "0x60001B7")]
	public T[,] Read2DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	public T[,,] Read3DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>(ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	public List<T> ReadList<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	public void ReadList<T>(ES2Type type, List<T> c) where T : class
	{
	}

	[Token(Token = "0x60001BC")]
	public HashSet<T> ReadHashSet<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	public Queue<T> ReadQueue<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001BE")]
	public Stack<T> ReadStack<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2775138", Offset = "0x2775138", VA = "0x2775138")]
	public Array ReadSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2775590", Offset = "0x2775590", VA = "0x2775590")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA65D8", Offset = "0xBA65D8")]
	public ICollection ReadICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2775970", Offset = "0x2775970", VA = "0x2775970")]
	public IDictionary ReadIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	private T ReadEncrypted<T>(ES2Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x60001C3")]
	private void ReadEncrypted<T>(ES2Type type, T c) where T : class
	{
	}

	[Token(Token = "0x60001C4")]
	private T[] ReadEncryptedArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	private void ReadEncryptedArray<T>(ES2Type type, T[] c) where T : class
	{
	}

	[Token(Token = "0x60001C6")]
	private T[,] ReadEncrypted2DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	private T[,,] ReadEncrypted3DArray<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	private Dictionary<TKey, TValue> ReadEncryptedDictionary<TKey, TValue>(ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	private List<T> ReadEncryptedList<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	private void ReadEncryptedList<T>(ES2Type type, List<T> c) where T : class
	{
	}

	[Token(Token = "0x60001CB")]
	private HashSet<T> ReadEncryptedHashSet<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	private Queue<T> ReadEncryptedQueue<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	private Stack<T> ReadEncryptedStack<T>(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x27752E0", Offset = "0x27752E0", VA = "0x27752E0")]
	private Array ReadEncryptedSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x2775748", Offset = "0x2775748", VA = "0x2775748")]
	private ICollection ReadEncryptedICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x2775B70", Offset = "0x2775B70", VA = "0x2775B70")]
	private IDictionary ReadEncryptedIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x2775E4C", Offset = "0x2775E4C", VA = "0x2775E4C")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey, string tag)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x2776464", Offset = "0x2776464", VA = "0x2776464")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x27761C8", Offset = "0x27761C8", VA = "0x27761C8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA65EC", Offset = "0xBA65EC")]
	public ES2Header ReadHeader()
	{
		return default(ES2Header);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x277670C", Offset = "0x277670C", VA = "0x277670C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6600", Offset = "0xBA6600")]
	public bool Next()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x27768FC", Offset = "0x27768FC", VA = "0x27768FC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6614", Offset = "0xBA6614")]
	public void Skip()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2776934", Offset = "0x2776934", VA = "0x2776934")]
	protected bool WriteBytesBeforeTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2776A74", Offset = "0x2776A74", VA = "0x2776A74")]
	protected bool WriteRemainingBytes(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2776BA4", Offset = "0x2776BA4", VA = "0x2776BA4")]
	protected bool WriteBytesBeforeTagLowMemory(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2776D7C", Offset = "0x2776D7C", VA = "0x2776D7C")]
	protected bool WriteRemainingBytesLowMemory(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2776F5C", Offset = "0x2776F5C", VA = "0x2776F5C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6628", Offset = "0xBA6628")]
	public bool RenameTag(string oldTag, string newTag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x27771E0", Offset = "0x27771E0", VA = "0x27771E0")]
	protected bool DeleteTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x2777384", Offset = "0x2777384", VA = "0x2777384")]
	protected void WriteCurrentTag(ES2Writer writer)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x2777404", Offset = "0x2777404", VA = "0x2777404")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA663C", Offset = "0xBA663C")]
	public bool DeleteTags(ICollection<string> tags, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x2777808", Offset = "0x2777808", VA = "0x2777808")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6650", Offset = "0xBA6650")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x27778F0", Offset = "0x27778F0", VA = "0x27778F0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6664", Offset = "0xBA6664")]
	public byte[] ReadMeshSettings()
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2777938", Offset = "0x2777938", VA = "0x2777938")]
	private byte[] GetDecryptedBytes()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x2775DD8", Offset = "0x2775DD8", VA = "0x2775DD8")]
	private ES2Reader GetEncryptedReader()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x27772F8", Offset = "0x27772F8", VA = "0x27772F8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6678", Offset = "0xBA6678")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2777B2C", Offset = "0x2777B2C", VA = "0x2777B2C", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2777B38", Offset = "0x2777B38", VA = "0x2777B38")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA668C", Offset = "0xBA668C")]
	public void CacheFile()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x27760A4", Offset = "0x27760A4", VA = "0x27760A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA66A0", Offset = "0xBA66A0")]
	public bool ScanToTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2777C04", Offset = "0x2777C04", VA = "0x2777C04")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA66B4", Offset = "0xBA66B4")]
	public bool ScanToTag()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2777C20", Offset = "0x2777C20", VA = "0x2777C20")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2777C50", Offset = "0x2777C50", VA = "0x2777C50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA66C8", Offset = "0xBA66C8")]
	public bool TagExists()
	{
		return default(bool);
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2777C90", Offset = "0x2777C90", VA = "0x2777C90")]
	public byte[] ReadRaw()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	public T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x60001EC")]
	public void Read<T>(T c) where T : class
	{
	}

	[Token(Token = "0x60001ED")]
	public T[] ReadArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	public void ReadArray<T>(T[] c) where T : class
	{
	}

	[Token(Token = "0x60001EF")]
	public T[,] Read2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	public T[,,] Read3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	public List<T> ReadList<T>()
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	public void ReadList<T>(List<T> c) where T : class
	{
	}

	[Token(Token = "0x60001F4")]
	public HashSet<T> ReadHashSet<T>()
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	public Queue<T> ReadQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	public Stack<T> ReadStack<T>()
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	public T Read<T>(string tag)
	{
		return (T)null;
	}

	[Token(Token = "0x60001F8")]
	public void Read<T>(string tag, T c) where T : class
	{
	}

	[Token(Token = "0x60001F9")]
	public T[] ReadArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	public void ReadArray<T>(string tag, T[] c) where T : class
	{
	}

	[Token(Token = "0x60001FB")]
	public T[,] Read2DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	public T[,,] Read3DArray<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	public List<T> ReadList<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	public void ReadList<T>(string tag, List<T> c) where T : class
	{
	}

	[Token(Token = "0x6000200")]
	public HashSet<T> ReadHashSet<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	public Queue<T> ReadQueue<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	public Stack<T> ReadStack<T>(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x2777CD0", Offset = "0x2777CD0", VA = "0x2777CD0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA66DC", Offset = "0xBA66DC")]
	public ES2Data ReadAll()
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x2777DB0", Offset = "0x2777DB0", VA = "0x2777DB0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA66F0", Offset = "0xBA66F0")]
	public object ReadObject()
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x27783B8", Offset = "0x27783B8", VA = "0x27783B8")]
	public void ReadObject(object obj)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x27784A4", Offset = "0x27784A4", VA = "0x27784A4")]
	public object ReadObject(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x27784FC", Offset = "0x27784FC", VA = "0x27784FC")]
	public void ReadObject(string tag, object obj)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x2778564", Offset = "0x2778564", VA = "0x2778564")]
	public void ReadComponent(GameObject go)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x27786D4", Offset = "0x27786D4", VA = "0x27786D4")]
	public void ReadComponent(string tag, GameObject go)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x277873C", Offset = "0x277873C", VA = "0x277873C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6704", Offset = "0xBA6704")]
	public Dictionary<string, ES2Header> ReadAllHeaders()
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6718", Offset = "0xBA6718")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600020C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA672C", Offset = "0xBA672C")]
	public T ReadProperty<T>(T obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6740", Offset = "0xBA6740")]
	public T[] ReadPropertyArray<T>()
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6754", Offset = "0xBA6754")]
	public T[] ReadPropertyArray<T>(T[] obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6768", Offset = "0xBA6768")]
	public T[,] ReadProperty2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA677C", Offset = "0xBA677C")]
	public T[,,] ReadProperty3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6790", Offset = "0xBA6790")]
	public List<T> ReadPropertyList<T>()
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA67A4", Offset = "0xBA67A4")]
	public Queue<T> ReadPropertyQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA67B8", Offset = "0xBA67B8")]
	public Stack<T> ReadPropertyStack<T>()
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA67CC", Offset = "0xBA67CC")]
	public Dictionary<TKey, TValue> ReadPropertyDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2775430", Offset = "0x2775430", VA = "0x2775430")]
	private static int[] GetMultidimensionalIndices(Array a, int idx)
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x277884C", Offset = "0x277884C", VA = "0x277884C")]
	public static ES2Reader Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2778AA4", Offset = "0x2778AA4", VA = "0x2778AA4")]
	public static ES2Reader Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2778A48", Offset = "0x2778A48", VA = "0x2778A48")]
	public static ES2Reader Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2777A50", Offset = "0x2777A50", VA = "0x2777A50")]
	public static ES2Reader Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2778B4C", Offset = "0x2778B4C", VA = "0x2778B4C")]
	public ES2Reader(ES2Settings settings)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2778CC4", Offset = "0x2778CC4", VA = "0x2778CC4")]
	public ES2Reader(byte[] bytes, ES2Settings settings)
	{
	}
}
[Token(Token = "0x2000030")]
public class ES2InvalidDataException : Exception
{
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x2773A7C", Offset = "0x2773A7C", VA = "0x2773A7C")]
	public ES2InvalidDataException()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E434", Offset = "0xB9E434")]
public struct ES2FilenameData
{
	[Token(Token = "0x2000032")]
	public enum PathType
	{
		[Token(Token = "0x40000E7")]
		File,
		[Token(Token = "0x40000E8")]
		Folder,
		[Token(Token = "0x40000E9")]
		URL
	}

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string fullString;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string persistentPath;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string userFolder;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filename;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string extension;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string tag;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string playerPrefsPath;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string filePath;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public PathType pathType;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool isAbsolute;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string persistentDataPath;

	[Token(Token = "0x17000040")]
	public string directoryPath
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x22E8524", Offset = "0x22E8524", VA = "0x22E8524")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public string resourcesPath
	{
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x22E8288", Offset = "0x22E8288", VA = "0x22E8288")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x22E8B9C", Offset = "0x22E8B9C", VA = "0x22E8B9C")]
	public ES2FilenameData(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x22E9368", Offset = "0x22E9368", VA = "0x22E9368")]
	public ES2FilenameData(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x22E8CCC", Offset = "0x22E8CCC", VA = "0x22E8CCC")]
	public void Init(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x22E95EC", Offset = "0x22E95EC", VA = "0x22E95EC")]
	private void ProcessParameter(string name, string value, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x22E9558", Offset = "0x22E9558", VA = "0x22E9558")]
	private static PathType GetPathType(string path)
	{
		return default(PathType);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x22EA080", Offset = "0x22EA080", VA = "0x22EA080")]
	private static bool PathIsURL(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x22E9494", Offset = "0x22E9494", VA = "0x22E9494")]
	private static bool PathIsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x22EA218", Offset = "0x22EA218", VA = "0x22EA218")]
	private static bool PathIsFolder(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x22E8154", Offset = "0x22E8154", VA = "0x22E8154")]
	public bool HasTag()
	{
		return default(bool);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x22DE8D4", Offset = "0x22DE8D4", VA = "0x22DE8D4")]
	public static string GetPersistentPath()
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x22E8514", Offset = "0x22E8514", VA = "0x22E8514")]
	public bool IsURL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x22E8188", Offset = "0x22E8188", VA = "0x22E8188")]
	public bool IsFolder()
	{
		return default(bool);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x22E8178", Offset = "0x22E8178", VA = "0x22E8178")]
	public bool IsFile()
	{
		return default(bool);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x22EA260", Offset = "0x22EA260", VA = "0x22EA260")]
	public bool IsAbsolute()
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x22EA268", Offset = "0x22EA268", VA = "0x22EA268")]
	public string GetSavePath(ES2Settings.SaveLocation saveLocation)
	{
		return null;
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E448", Offset = "0xB9E448")]
public sealed class ES2GlobalSettings : MonoBehaviour
{
	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool hasInitialized;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static ES2Settings.SaveLocation _defaultSaveLocation;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static ES2Settings.OptimizeMode defaultOptimizeMode;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static ES2Settings.Format defaultFormat;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string defaultPCDataPath;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string defaultMacDataPath;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static bool defaultEncrypt;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string defaultEncryptionPassword;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static ES2Settings.EncryptionType defaultEncryptionType;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string defaultWebUsername;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string defaultWebPassword;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string defaultWebFilename;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static int defaultBufferSize;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings.SaveLocation saveLocation;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ES2Settings.OptimizeMode optimizeMode;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string PCDataPath;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string MacDataPath;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool encrypt;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string encryptionPassword;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ES2Settings.EncryptionType encryptionType;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string webUsername;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string webPassword;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int bufferSize;

	[Token(Token = "0x17000042")]
	public static ES2Settings.SaveLocation defaultSaveLocation
	{
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x277363C", Offset = "0x277363C", VA = "0x277363C")]
		get
		{
			return default(ES2Settings.SaveLocation);
		}
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x27736B8", Offset = "0x27736B8", VA = "0x27736B8")]
		set
		{
		}
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x2773720", Offset = "0x2773720", VA = "0x2773720")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x27738F0", Offset = "0x27738F0", VA = "0x27738F0")]
	public ES2GlobalSettings()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E45C", Offset = "0xB9E45C")]
public static class ES2Keys
{
	[Token(Token = "0x2000035")]
	public enum Key : byte
	{
		[Token(Token = "0x4000102")]
		_NativeArray = 81,
		[Token(Token = "0x4000103")]
		_Dictionary = 82,
		[Token(Token = "0x4000104")]
		_List = 83,
		[Token(Token = "0x4000105")]
		_HashSet = 84,
		[Token(Token = "0x4000106")]
		_Queue = 85,
		[Token(Token = "0x4000107")]
		_Stack = 86,
		[Token(Token = "0x4000108")]
		_Obfuscate = 121,
		[Token(Token = "0x4000109")]
		_Size = 122,
		[Token(Token = "0x400010A")]
		_Terminator = 123,
		[Token(Token = "0x400010B")]
		_Null = 124,
		[Token(Token = "0x400010C")]
		_Settings = 125,
		[Token(Token = "0x400010D")]
		_Tag = 126,
		[Token(Token = "0x400010E")]
		_Encrypt = 127
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x2773AF8", Offset = "0x2773AF8", VA = "0x2773AF8")]
	public static string TypeFromKeys(Key collection, Key value, Key key)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x2773F94", Offset = "0x2773F94", VA = "0x2773F94")]
	public static Key[] KeysFromType(Key collectionType, Key valueType, Key keyType)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x277402C", Offset = "0x277402C", VA = "0x277402C")]
	public static Key KeyFromES2Type(ES2Type type)
	{
		return default(Key);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x2774040", Offset = "0x2774040", VA = "0x2774040")]
	public static Key[] KeysFromES2Type(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x277405C", Offset = "0x277405C", VA = "0x277405C")]
	public static Key[] KeysFromES2Type(ES2Type type, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x277407C", Offset = "0x277407C", VA = "0x277407C")]
	public static Key[] KeysFromES2Type(ES2Type keyType, ES2Type valueType, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x27740A8", Offset = "0x27740A8", VA = "0x27740A8")]
	public static Key GetCollectionType(Type type)
	{
		return default(Key);
	}
}
[Token(Token = "0x2000036")]
public sealed class ES2Settings
{
	[Token(Token = "0x2000037")]
	public enum OptimizeMode
	{
		[Token(Token = "0x4000125")]
		Fast,
		[Token(Token = "0x4000126")]
		LowMemory
	}

	[Token(Token = "0x2000038")]
	public enum SaveLocation
	{
		[Token(Token = "0x4000128")]
		PlayerPrefs,
		[Token(Token = "0x4000129")]
		File,
		[Token(Token = "0x400012A")]
		Resources,
		[Token(Token = "0x400012B")]
		Memory
	}

	[Token(Token = "0x2000039")]
	public enum Format
	{
		[Token(Token = "0x400012D")]
		Binary
	}

	[Token(Token = "0x200003A")]
	public enum EncryptionType
	{
		[Token(Token = "0x400012F")]
		AES128,
		[Token(Token = "0x4000130")]
		Obfuscate
	}

	[Token(Token = "0x200003B")]
	public enum ES2FileMode
	{
		[Token(Token = "0x4000132")]
		Create,
		[Token(Token = "0x4000133")]
		Append,
		[Token(Token = "0x4000134")]
		Open
	}

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4F00", Offset = "0xBA4F00")]
	public ES2FilenameData filenameData;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public SaveLocation saveLocation;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public OptimizeMode optimizeMode;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Format format;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool encrypt;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string encryptionPassword;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public EncryptionType encryptionType;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string webUsername;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string webPassword;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string webFilename;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool saveNormals;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool saveUV;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	public bool saveUV2;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	public bool saveTangents;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool saveSubmeshes;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool saveSkinning;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool saveColors;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x97")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4F14", Offset = "0xBA4F14")]
	public byte meshSettingsCount;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string name;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4F28", Offset = "0xBA4F28")]
	public ES2FileMode fileMode;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int bufferSize;

	[Token(Token = "0x17000043")]
	public string tag
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2779C68", Offset = "0x2779C68", VA = "0x2779C68")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2779C70", Offset = "0x2779C70", VA = "0x2779C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA7C98", Offset = "0xBA7C98")]
	public bool IsImageFile
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2779C78", Offset = "0x2779C78", VA = "0x2779C78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x27795C4", Offset = "0x27795C4", VA = "0x27795C4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA67E0", Offset = "0xBA67E0")]
	public void Init()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x277970C", Offset = "0x277970C", VA = "0x277970C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA67F4", Offset = "0xBA67F4")]
	public ES2Settings Clone()
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x2778ACC", Offset = "0x2778ACC", VA = "0x2778ACC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6808", Offset = "0xBA6808")]
	public ES2Settings Clone(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x2779864", Offset = "0x2779864", VA = "0x2779864")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA681C", Offset = "0xBA681C")]
	public byte[] MeshSettingsToByteArray()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x2779954", Offset = "0x2779954", VA = "0x2779954")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6830", Offset = "0xBA6830")]
	public void MeshSettingsFromByteArray(byte[] bytes)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x27788A8", Offset = "0x27788A8", VA = "0x27788A8")]
	public ES2Settings(string identifier)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x2779B10", Offset = "0x2779B10", VA = "0x2779B10")]
	public ES2Settings(SaveLocation saveLocation)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x277455C", Offset = "0x277455C", VA = "0x277455C")]
	public ES2Settings()
	{
	}
}
[Token(Token = "0x200003C")]
internal sealed class ES2FileStream : ES2Stream
{
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x22E86BC", Offset = "0x22E86BC", VA = "0x22E86BC")]
	public ES2FileStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x22E88A0", Offset = "0x22E88A0", VA = "0x22E88A0", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x22E8A5C", Offset = "0x22E8A5C", VA = "0x22E8A5C")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x22E87BC", Offset = "0x22E87BC", VA = "0x22E87BC")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x22E8720", Offset = "0x22E8720", VA = "0x22E8720")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x22E8B7C", Offset = "0x22E8B7C", VA = "0x22E8B7C", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x200003D")]
internal sealed class ES2MemoryStream : ES2Stream
{
	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public byte[] storedBytes;

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x27743A4", Offset = "0x27743A4", VA = "0x27743A4")]
	public ES2MemoryStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x2774438", Offset = "0x2774438", VA = "0x2774438")]
	public ES2MemoryStream(byte[] bytes, ES2Settings settings)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x27744B8", Offset = "0x27744B8", VA = "0x27744B8")]
	public ES2MemoryStream()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x27746A0", Offset = "0x27746A0", VA = "0x27746A0", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x27749A4", Offset = "0x27749A4", VA = "0x27749A4", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x27749AC", Offset = "0x27749AC", VA = "0x27749AC", Slot = "6")]
	public override byte[] ReadAllBytes()
	{
		return null;
	}
}
[Token(Token = "0x200003E")]
internal sealed class ES2PlayerPrefsStream : ES2Stream
{
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x2774A84", Offset = "0x2774A84", VA = "0x2774A84")]
	public ES2PlayerPrefsStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x2774C60", Offset = "0x2774C60", VA = "0x2774C60", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x2775068", Offset = "0x2775068", VA = "0x2775068")]
	private void StoreRaw()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x2774FD8", Offset = "0x2774FD8", VA = "0x2774FD8")]
	private void StoreRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x27750F8", Offset = "0x27750F8", VA = "0x27750F8")]
	private void StoreRaw(string bytes)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x2774EFC", Offset = "0x2774EFC", VA = "0x2774EFC")]
	private void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x2774EA4", Offset = "0x2774EA4", VA = "0x2774EA4")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x2774AF4", Offset = "0x2774AF4", VA = "0x2774AF4")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x2774C08", Offset = "0x2774C08", VA = "0x2774C08")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x2775118", Offset = "0x2775118", VA = "0x2775118", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x200003F")]
internal sealed class ES2ResourcesStream : ES2Stream
{
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x27792CC", Offset = "0x27792CC", VA = "0x27792CC")]
	public ES2ResourcesStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x27794D4", Offset = "0x27794D4", VA = "0x27794D4", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x2779548", Offset = "0x2779548", VA = "0x2779548", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000040")]
public abstract class ES2Stream
{
	[Token(Token = "0x2000041")]
	public enum Operation
	{
		[Token(Token = "0x4000139")]
		Read,
		[Token(Token = "0x400013A")]
		Write
	}

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Stream stream;

	[Token(Token = "0x17000045")]
	public long Length
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2776894", Offset = "0x2776894", VA = "0x2776894")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x277ACBC", Offset = "0x277ACBC", VA = "0x277ACBC")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public long Position
	{
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x27768D8", Offset = "0x27768D8", VA = "0x27768D8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x27768B4", Offset = "0x27768B4", VA = "0x27768B4")]
		set
		{
		}
	}

	[Token(Token = "0x600025F")]
	public abstract void Store();

	[Token(Token = "0x6000260")]
	public abstract bool MayRequireOverwrite();

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x2776B14", Offset = "0x2776B14", VA = "0x2776B14")]
	public byte[] ReadBytes(int count)
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x27749C0", Offset = "0x27749C0", VA = "0x27749C0", Slot = "6")]
	public virtual byte[] ReadAllBytes()
	{
		return null;
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x2774850", Offset = "0x2774850", VA = "0x2774850")]
	protected void WriteToStreamFast(Stream writableStream)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x27748C4", Offset = "0x27748C4", VA = "0x27748C4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6844", Offset = "0xBA6844")]
	protected void WriteToStreamLowMemory(Stream writableStream)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x2778FC4", Offset = "0x2778FC4", VA = "0x2778FC4")]
	public static ES2Stream Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x2778E30", Offset = "0x2778E30", VA = "0x2778E30")]
	public static ES2Stream Create(ES2Settings settings, Operation operation)
	{
		return null;
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x2774430", Offset = "0x2774430", VA = "0x2774430")]
	protected ES2Stream()
	{
	}
}
[Token(Token = "0x2000042")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E470", Offset = "0xB9E470")]
public sealed class ES2_BoneWeight : ES2Type
{
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x277E330", Offset = "0x277E330", VA = "0x277E330")]
	public ES2_BoneWeight()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x277E3C4", Offset = "0x277E3C4", VA = "0x277E3C4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x277E554", Offset = "0x277E554", VA = "0x277E554", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E484", Offset = "0xB9E484")]
public sealed class ES2_Bounds : ES2Type
{
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x277E6F4", Offset = "0x277E6F4", VA = "0x277E6F4")]
	public ES2_Bounds()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x277E788", Offset = "0x277E788", VA = "0x277E788", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x277E86C", Offset = "0x277E86C", VA = "0x277E86C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E498", Offset = "0xB9E498")]
public sealed class ES2_Color : ES2Type
{
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x277F118", Offset = "0x277F118", VA = "0x277F118")]
	public ES2_Color()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x277F1AC", Offset = "0x277F1AC", VA = "0x277F1AC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x277F290", Offset = "0x277F290", VA = "0x277F290", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E4AC", Offset = "0xB9E4AC")]
public sealed class ES2_Color32 : ES2Type
{
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x277F394", Offset = "0x277F394", VA = "0x277F394")]
	public ES2_Color32()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x277F428", Offset = "0x277F428", VA = "0x277F428", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x277F510", Offset = "0x277F510", VA = "0x277F510", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000046")]
public class ES2_DateTime : ES2Type
{
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x277F608", Offset = "0x277F608", VA = "0x277F608", Slot = "4")]
	public override void Write(object obj, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x277F6C4", Offset = "0x277F6C4", VA = "0x277F6C4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x277F760", Offset = "0x277F760", VA = "0x277F760")]
	public ES2_DateTime()
	{
	}
}
[Token(Token = "0x2000047")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E4C0", Offset = "0xB9E4C0")]
public sealed class ES2_ES2AutoSaveManager : ES2Type
{
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x277F7E8", Offset = "0x277F7E8", VA = "0x277F7E8")]
	public ES2_ES2AutoSaveManager()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x277F870", Offset = "0x277F870", VA = "0x277F870", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x277F908", Offset = "0x277F908", VA = "0x277F908", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x277F92C", Offset = "0x277F92C", VA = "0x277F92C", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000048")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E4D4", Offset = "0xB9E4D4")]
public sealed class ES2_Enum : ES2Type
{
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x277B298", Offset = "0x277B298", VA = "0x277B298")]
	public ES2_Enum()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x277F9C4", Offset = "0x277F9C4", VA = "0x277F9C4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x277FA60", Offset = "0x277FA60", VA = "0x277FA60", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000049")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E4E8", Offset = "0xB9E4E8")]
public sealed class ES2_Gradient : ES2Type
{
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x277FAE0", Offset = "0x277FAE0", VA = "0x277FAE0")]
	public ES2_Gradient()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x277FB68", Offset = "0x277FB68", VA = "0x277FB68", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x277FC54", Offset = "0x277FC54", VA = "0x277FC54", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E4FC", Offset = "0xB9E4FC")]
public sealed class ES2_GradientAlphaKey : ES2Type
{
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x277FDF8", Offset = "0x277FDF8", VA = "0x277FDF8")]
	public ES2_GradientAlphaKey()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x277FE80", Offset = "0x277FE80", VA = "0x277FE80", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x277FF38", Offset = "0x277FF38", VA = "0x277FF38", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E510", Offset = "0xB9E510")]
public sealed class ES2_GradientColorKey : ES2Type
{
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x277FD70", Offset = "0x277FD70", VA = "0x277FD70")]
	public ES2_GradientColorKey()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x277FFF4", Offset = "0x277FFF4", VA = "0x277FFF4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x278013C", Offset = "0x278013C", VA = "0x278013C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E524", Offset = "0xB9E524")]
public sealed class ES2_Material : ES2Type
{
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x278022C", Offset = "0x278022C", VA = "0x278022C")]
	public ES2_Material()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x27802C0", Offset = "0x27802C0", VA = "0x27802C0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x2781248", Offset = "0x2781248", VA = "0x2781248", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x27812F4", Offset = "0x27812F4", VA = "0x27812F4", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200004D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E538", Offset = "0xB9E538")]
public sealed class ES2_Matrix4x4 : ES2Type
{
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x27816FC", Offset = "0x27816FC", VA = "0x27816FC")]
	public ES2_Matrix4x4()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x2781790", Offset = "0x2781790", VA = "0x2781790", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x27818B8", Offset = "0x27818B8", VA = "0x27818B8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E54C", Offset = "0xB9E54C")]
public sealed class ES2_Mesh : ES2Type
{
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x27819B8", Offset = "0x27819B8", VA = "0x27819B8")]
	public ES2_Mesh()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x2781A4C", Offset = "0x2781A4C", VA = "0x2781A4C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x2781D88", Offset = "0x2781D88", VA = "0x2781D88", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x2781E08", Offset = "0x2781E08", VA = "0x2781E08", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E560", Offset = "0xB9E560")]
public sealed class ES2_Quaternion : ES2Type
{
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x2782CF4", Offset = "0x2782CF4", VA = "0x2782CF4")]
	public ES2_Quaternion()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x2782D88", Offset = "0x2782D88", VA = "0x2782D88", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x2782E8C", Offset = "0x2782E8C", VA = "0x2782E8C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E574", Offset = "0xB9E574")]
public sealed class ES2_Rect : ES2Type
{
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2782F90", Offset = "0x2782F90", VA = "0x2782F90")]
	public ES2_Rect()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2783024", Offset = "0x2783024", VA = "0x2783024", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x278312C", Offset = "0x278312C", VA = "0x278312C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E588", Offset = "0xB9E588")]
public sealed class ES2_Sprite : ES2Type
{
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2783B28", Offset = "0x2783B28", VA = "0x2783B28")]
	public ES2_Sprite()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x2783BBC", Offset = "0x2783BBC", VA = "0x2783BBC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x2783E4C", Offset = "0x2783E4C", VA = "0x2783E4C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000052")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E59C", Offset = "0xB9E59C")]
public sealed class ES2_Texture : ES2Type
{
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x2783F9C", Offset = "0x2783F9C", VA = "0x2783F9C")]
	public ES2_Texture()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x2784024", Offset = "0x2784024", VA = "0x2784024", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x27841A4", Offset = "0x27841A4", VA = "0x27841A4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x2784310", Offset = "0x2784310", VA = "0x2784310", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000053")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E5B0", Offset = "0xB9E5B0")]
public sealed class ES2_Texture2D : ES2Type
{
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x278447C", Offset = "0x278447C", VA = "0x278447C")]
	public ES2_Texture2D()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x2784510", Offset = "0x2784510", VA = "0x2784510", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2784694", Offset = "0x2784694", VA = "0x2784694", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x278471C", Offset = "0x278471C", VA = "0x278471C", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000054")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E5C4", Offset = "0xB9E5C4")]
public sealed class ES2_Vector2 : ES2Type
{
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x278237C", Offset = "0x278237C", VA = "0x278237C")]
	public ES2_Vector2()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x2784CEC", Offset = "0x2784CEC", VA = "0x2784CEC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x2784DA8", Offset = "0x2784DA8", VA = "0x2784DA8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000055")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E5D8", Offset = "0xB9E5D8")]
public sealed class ES2_Vector3 : ES2Type
{
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x2782254", Offset = "0x2782254", VA = "0x2782254")]
	public ES2_Vector3()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x2784E40", Offset = "0x2784E40", VA = "0x2784E40", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x2784F20", Offset = "0x2784F20", VA = "0x2784F20", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000056")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E5EC", Offset = "0xB9E5EC")]
public sealed class ES2_Vector4 : ES2Type
{
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x2782410", Offset = "0x2782410", VA = "0x2782410")]
	public ES2_Vector4()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x2784FE0", Offset = "0x2784FE0", VA = "0x2784FE0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x27850E4", Offset = "0x27850E4", VA = "0x27850E4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000057")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E600", Offset = "0xB9E600")]
public sealed class ES2_BoxCollider : ES2Type
{
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x277E950", Offset = "0x277E950", VA = "0x277E950")]
	public ES2_BoxCollider()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x277E9E4", Offset = "0x277E9E4", VA = "0x277E9E4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x277EAF8", Offset = "0x277EAF8", VA = "0x277EAF8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x277EB70", Offset = "0x277EB70", VA = "0x277EB70", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000058")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E614", Offset = "0xB9E614")]
public sealed class ES2_CapsuleCollider : ES2Type
{
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x277ECC8", Offset = "0x277ECC8", VA = "0x277ECC8")]
	public ES2_CapsuleCollider()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x277ED5C", Offset = "0x277ED5C", VA = "0x277ED5C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x277EED4", Offset = "0x277EED4", VA = "0x277EED4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x277EF4C", Offset = "0x277EF4C", VA = "0x277EF4C", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000059")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E628", Offset = "0xB9E628")]
public sealed class ES2_MeshCollider : ES2Type
{
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x27824A4", Offset = "0x27824A4", VA = "0x27824A4")]
	public ES2_MeshCollider()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x2782538", Offset = "0x2782538", VA = "0x2782538", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x2782684", Offset = "0x2782684", VA = "0x2782684", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x27826FC", Offset = "0x27826FC", VA = "0x27826FC", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E63C", Offset = "0xB9E63C")]
public sealed class ES2_PolygonCollider2D : ES2Type
{
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x2782898", Offset = "0x2782898", VA = "0x2782898")]
	public ES2_PolygonCollider2D()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x278292C", Offset = "0x278292C", VA = "0x278292C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x2782AC8", Offset = "0x2782AC8", VA = "0x2782AC8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x2782B40", Offset = "0x2782B40", VA = "0x2782B40", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E650", Offset = "0xB9E650")]
public sealed class ES2_SkinnedMeshRenderer : ES2Type
{
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x2783230", Offset = "0x2783230", VA = "0x2783230")]
	public ES2_SkinnedMeshRenderer()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x27832C4", Offset = "0x27832C4", VA = "0x27832C4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x27834C0", Offset = "0x27834C0", VA = "0x27834C0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x2783538", Offset = "0x2783538", VA = "0x2783538", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E664", Offset = "0xB9E664")]
public sealed class ES2_SphereCollider : ES2Type
{
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x2783794", Offset = "0x2783794", VA = "0x2783794")]
	public ES2_SphereCollider()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x2783828", Offset = "0x2783828", VA = "0x2783828", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x278394C", Offset = "0x278394C", VA = "0x278394C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x27839C4", Offset = "0x27839C4", VA = "0x27839C4", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E678", Offset = "0xB9E678")]
public sealed class ES2_Transform : ES2Type
{
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x27848F8", Offset = "0x27848F8", VA = "0x27848F8")]
	public ES2_Transform()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x278498C", Offset = "0x278498C", VA = "0x278498C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x2784AD0", Offset = "0x2784AD0", VA = "0x2784AD0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x2784B48", Offset = "0x2784B48", VA = "0x2784B48", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E68C", Offset = "0xB9E68C")]
public abstract class ES2Type
{
	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public byte key;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int hash;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Type type;

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x277ACE0", Offset = "0x277ACE0", VA = "0x277ACE0")]
	public ES2Type(Type type)
	{
	}

	[Token(Token = "0x60002CD")]
	public abstract void Write(object data, ES2Writer writer);

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x277AD50", Offset = "0x277AD50", VA = "0x277AD50", Slot = "5")]
	public virtual object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x277AE1C", Offset = "0x277AE1C", VA = "0x277AE1C", Slot = "6")]
	public virtual void Read(ES2Reader reader, object c)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x277AEE0", Offset = "0x277AEE0", VA = "0x277AEE0", Slot = "7")]
	public virtual void Read(ES2Reader reader, Component c)
	{
	}

	[Token(Token = "0x60002D1")]
	public static T GetOrCreate<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x277AD2C", Offset = "0x277AD2C", VA = "0x277AD2C")]
	public static int GetHash(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x277AEEC", Offset = "0x277AEEC", VA = "0x277AEEC")]
	public static int GetHash(string value)
	{
		return default(int);
	}
}
[Token(Token = "0x200005F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E6A0", Offset = "0xB9E6A0")]
public static class ES2TypeManager
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<Type, ES2Type> types;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES2Type cachedType;

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x277AFDC", Offset = "0x277AFDC", VA = "0x277AFDC")]
	public static void AddES2Type(ES2Type es2Type)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x277B070", Offset = "0x277B070", VA = "0x277B070")]
	public static ES2Type GetES2Type(Type type)
	{
		return null;
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x2776480", Offset = "0x2776480", VA = "0x2776480")]
	public static ES2Type GetES2Type(byte key)
	{
		return null;
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x277B32C", Offset = "0x277B32C", VA = "0x277B32C")]
	public static ES2Type GetES2Type(ES2Keys.Key key)
	{
		return null;
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x277812C", Offset = "0x277812C", VA = "0x277812C")]
	public static ES2Type GetES2Type(int hash)
	{
		return null;
	}
}
[Token(Token = "0x2000060")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E6B4", Offset = "0xB9E6B4")]
public sealed class ES2_bool : ES2Type
{
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x27851E8", Offset = "0x27851E8", VA = "0x27851E8")]
	public ES2_bool()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x278527C", Offset = "0x278527C", VA = "0x278527C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x2785314", Offset = "0x2785314", VA = "0x2785314", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000061")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E6C8", Offset = "0xB9E6C8")]
public sealed class ES2_byte : ES2Type
{
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x2785394", Offset = "0x2785394", VA = "0x2785394")]
	public ES2_byte()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x2785424", Offset = "0x2785424", VA = "0x2785424", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x27854BC", Offset = "0x27854BC", VA = "0x27854BC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000062")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E6DC", Offset = "0xB9E6DC")]
public sealed class ES2_char : ES2Type
{
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x2785538", Offset = "0x2785538", VA = "0x2785538")]
	public ES2_char()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x27855CC", Offset = "0x27855CC", VA = "0x27855CC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x2785668", Offset = "0x2785668", VA = "0x2785668", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000063")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E6F0", Offset = "0xB9E6F0")]
public sealed class ES2_decimal : ES2Type
{
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x27856E8", Offset = "0x27856E8", VA = "0x27856E8")]
	public ES2_decimal()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x278577C", Offset = "0x278577C", VA = "0x278577C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x2785818", Offset = "0x2785818", VA = "0x2785818", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000064")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E704", Offset = "0xB9E704")]
public sealed class ES2_double : ES2Type
{
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x2785898", Offset = "0x2785898", VA = "0x2785898")]
	public ES2_double()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x278592C", Offset = "0x278592C", VA = "0x278592C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x27859C8", Offset = "0x27859C8", VA = "0x27859C8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000065")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E718", Offset = "0xB9E718")]
public sealed class ES2_float : ES2Type
{
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x2785A44", Offset = "0x2785A44", VA = "0x2785A44")]
	public ES2_float()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x2785AD8", Offset = "0x2785AD8", VA = "0x2785AD8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x2785B74", Offset = "0x2785B74", VA = "0x2785B74", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000066")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E72C", Offset = "0xB9E72C")]
public sealed class ES2_int : ES2Type
{
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x27822E8", Offset = "0x27822E8", VA = "0x27822E8")]
	public ES2_int()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x2785BF0", Offset = "0x2785BF0", VA = "0x2785BF0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x2785C8C", Offset = "0x2785C8C", VA = "0x2785C8C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000067")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E740", Offset = "0xB9E740")]
public sealed class ES2_long : ES2Type
{
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x2785D0C", Offset = "0x2785D0C", VA = "0x2785D0C")]
	public ES2_long()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x2785DA0", Offset = "0x2785DA0", VA = "0x2785DA0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x2785E3C", Offset = "0x2785E3C", VA = "0x2785E3C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000068")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E754", Offset = "0xB9E754")]
public sealed class ES2_object : ES2Type
{
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2785EBC", Offset = "0x2785EBC", VA = "0x2785EBC")]
	public ES2_object()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x2785F44", Offset = "0x2785F44", VA = "0x2785F44", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x27860CC", Offset = "0x27860CC", VA = "0x27860CC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000069")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E768", Offset = "0xB9E768")]
public sealed class ES2_sbyte : ES2Type
{
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x27861E0", Offset = "0x27861E0", VA = "0x27861E0")]
	public ES2_sbyte()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x2786274", Offset = "0x2786274", VA = "0x2786274", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x278630C", Offset = "0x278630C", VA = "0x278630C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E77C", Offset = "0xB9E77C")]
public sealed class ES2_short : ES2Type
{
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2786388", Offset = "0x2786388", VA = "0x2786388")]
	public ES2_short()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x278641C", Offset = "0x278641C", VA = "0x278641C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x27864B8", Offset = "0x27864B8", VA = "0x27864B8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E790", Offset = "0xB9E790")]
public sealed class ES2_string : ES2Type
{
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x2786538", Offset = "0x2786538", VA = "0x2786538")]
	public ES2_string()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x27865CC", Offset = "0x27865CC", VA = "0x27865CC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x2786658", Offset = "0x2786658", VA = "0x2786658", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E7A4", Offset = "0xB9E7A4")]
public sealed class ES2_uint : ES2Type
{
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2786684", Offset = "0x2786684", VA = "0x2786684")]
	public ES2_uint()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2786718", Offset = "0x2786718", VA = "0x2786718", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x27867B4", Offset = "0x27867B4", VA = "0x27867B4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E7B8", Offset = "0xB9E7B8")]
public sealed class ES2_ulong : ES2Type
{
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x2786834", Offset = "0x2786834", VA = "0x2786834")]
	public ES2_ulong()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x27868C8", Offset = "0x27868C8", VA = "0x27868C8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x2786964", Offset = "0x2786964", VA = "0x2786964", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E7CC", Offset = "0xB9E7CC")]
public sealed class ES2_ushort : ES2Type
{
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x27869E4", Offset = "0x27869E4", VA = "0x27869E4")]
	public ES2_ushort()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x2786A78", Offset = "0x2786A78", VA = "0x2786A78", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x2786B14", Offset = "0x2786B14", VA = "0x2786B14", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006F")]
public class ES2Writer : IDisposable
{
	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES2Settings settings;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4F3C", Offset = "0xBA4F3C")]
	public ES2Stream stream;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4F50", Offset = "0xBA4F50")]
	public HashSet<string> tagsToDelete;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4F64", Offset = "0xBA4F64")]
	public BinaryWriter writer;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4F78", Offset = "0xBA4F78")]
	private long lengthPosition;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x2776A0C", Offset = "0x2776A0C", VA = "0x2776A0C")]
	public void WriteRaw(byte[] param)
	{
	}

	[Token(Token = "0x6000308")]
	public void Write<T>(T param)
	{
	}

	[Token(Token = "0x6000309")]
	public void Write<T>(T[] param)
	{
	}

	[Token(Token = "0x600030A")]
	public void Write<T>(T[,] param)
	{
	}

	[Token(Token = "0x600030B")]
	public void Write<T>(T[,,] param)
	{
	}

	[Token(Token = "0x600030C")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
	}

	[Token(Token = "0x600030D")]
	public void Write<T>(List<T> param)
	{
	}

	[Token(Token = "0x600030E")]
	public void Write<T>(HashSet<T> param)
	{
	}

	[Token(Token = "0x600030F")]
	public void Write<T>(Queue<T> param)
	{
	}

	[Token(Token = "0x6000310")]
	public void Write<T>(Stack<T> param)
	{
	}

	[Token(Token = "0x6000311")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6858", Offset = "0xBA6858")]
	public void Write<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x6000312")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA686C", Offset = "0xBA686C")]
	public void Write<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000313")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6880", Offset = "0xBA6880")]
	public void Write<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000314")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6894", Offset = "0xBA6894")]
	public void Write<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000315")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA68A8", Offset = "0xBA68A8")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x6000316")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA68BC", Offset = "0xBA68BC")]
	public void Write<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000317")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA68D0", Offset = "0xBA68D0")]
	public void Write<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000318")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA68E4", Offset = "0xBA68E4")]
	public void Write<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000319")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA68F8", Offset = "0xBA68F8")]
	public void Write<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x277C4FC", Offset = "0x277C4FC", VA = "0x277C4FC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA690C", Offset = "0xBA690C")]
	public void WriteSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x277C9D0", Offset = "0x277C9D0", VA = "0x277C9D0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6920", Offset = "0xBA6920")]
	public void WriteICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x277CF30", Offset = "0x277CF30", VA = "0x277CF30")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6934", Offset = "0xBA6934")]
	public void WriteIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x600031D")]
	private void WriteEncrypted<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x600031E")]
	private void WriteEncrypted<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x600031F")]
	private void WriteEncrypted<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000320")]
	private void WriteEncrypted<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000321")]
	private void WriteEncrypted<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x6000322")]
	private void WriteEncrypted<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000323")]
	private void WriteEncrypted<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000324")]
	private void WriteEncrypted<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000325")]
	private void WriteEncrypted<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x277C814", Offset = "0x277C814", VA = "0x277C814")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6948", Offset = "0xBA6948")]
	private void WriteEncryptedSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x277CD74", Offset = "0x277CD74", VA = "0x277CD74")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA695C", Offset = "0xBA695C")]
	private void WriteEncryptedICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x277D360", Offset = "0x277D360", VA = "0x277D360")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6970", Offset = "0xBA6970")]
	private void WriteEncryptedIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x277D72C", Offset = "0x277D72C", VA = "0x277D72C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6984", Offset = "0xBA6984")]
	public void WriteHeader(ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x277D754", Offset = "0x277D754", VA = "0x277D754")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6998", Offset = "0xBA6998")]
	public void WriteHeader(string tag, ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x277D948", Offset = "0x277D948", VA = "0x277D948")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA69AC", Offset = "0xBA69AC")]
	public void WriteLength()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x277DA18", Offset = "0x277DA18", VA = "0x277DA18")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA69C0", Offset = "0xBA69C0")]
	public void WriteTerminator()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x277D524", Offset = "0x277D524", VA = "0x277D524")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA69D4", Offset = "0xBA69D4")]
	public ES2Writer CreateEncryptedWriter()
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x277D5C8", Offset = "0x277D5C8", VA = "0x277D5C8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA69E8", Offset = "0xBA69E8")]
	public byte[] GetEncryptedBytes(string password)
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x277DB48", Offset = "0x277DB48", VA = "0x277DB48", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x277DB54", Offset = "0x277DB54", VA = "0x277DB54")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA69FC", Offset = "0xBA69FC")]
	public bool Rename(string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000331")]
	public void Write<T>(T param, string tag)
	{
	}

	[Token(Token = "0x6000332")]
	public void Write<T>(T[] param, string tag)
	{
	}

	[Token(Token = "0x6000333")]
	public void Write<T>(T[,] param, string tag)
	{
	}

	[Token(Token = "0x6000334")]
	public void Write<T>(T[,,] param, string tag)
	{
	}

	[Token(Token = "0x6000335")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag)
	{
	}

	[Token(Token = "0x6000336")]
	public void Write<T>(List<T> param, string tag)
	{
	}

	[Token(Token = "0x6000337")]
	public void Write<T>(HashSet<T> param, string tag)
	{
	}

	[Token(Token = "0x6000338")]
	public void Write<T>(Queue<T> param, string tag)
	{
	}

	[Token(Token = "0x6000339")]
	public void Write<T>(Stack<T> param, string tag)
	{
	}

	[Token(Token = "0x600033A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6A10", Offset = "0xBA6A10")]
	public void Write<T>(T param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6A24", Offset = "0xBA6A24")]
	public void Write<T>(T[] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6A38", Offset = "0xBA6A38")]
	public void Write<T>(T[,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6A4C", Offset = "0xBA6A4C")]
	public void Write<T>(T[,,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033E")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6A60", Offset = "0xBA6A60")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x600033F")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6A74", Offset = "0xBA6A74")]
	public void Write<T>(List<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000340")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6A88", Offset = "0xBA6A88")]
	public void Write<T>(HashSet<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000341")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6A9C", Offset = "0xBA6A9C")]
	public void Write<T>(Queue<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000342")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6AB0", Offset = "0xBA6AB0")]
	public void Write<T>(Stack<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000343")]
	public void WriteProperty<T>(T property)
	{
	}

	[Token(Token = "0x6000344")]
	public void WriteProperty<T>(T[] property)
	{
	}

	[Token(Token = "0x6000345")]
	public void WriteProperty<T>(T[,] property)
	{
	}

	[Token(Token = "0x6000346")]
	public void WriteProperty<T>(T[,,] property)
	{
	}

	[Token(Token = "0x6000347")]
	public void WriteProperty<T>(List<T> property)
	{
	}

	[Token(Token = "0x6000348")]
	public void WriteProperty<T>(Queue<T> property)
	{
	}

	[Token(Token = "0x6000349")]
	public void WriteProperty<T>(Stack<T> property)
	{
	}

	[Token(Token = "0x600034A")]
	public void WriteProperty<TKey, TValue>(Dictionary<TKey, TValue> property)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x277DCBC", Offset = "0x277DCBC", VA = "0x277DCBC")]
	public int WritePropertyPrefix()
	{
		return default(int);
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x277DD24", Offset = "0x277DD24", VA = "0x277DD24")]
	public void WritePropertyLength(int startPosition)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x277DDD4", Offset = "0x277DDD4", VA = "0x277DDD4")]
	public void Save()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x277A6C8", Offset = "0x277A6C8", VA = "0x277A6C8")]
	public void Save(bool checkForOverwrite)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x277DF2C", Offset = "0x277DF2C", VA = "0x277DF2C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6AC4", Offset = "0xBA6AC4")]
	public void Save(byte[] bytes)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x277E0B8", Offset = "0x277E0B8", VA = "0x277E0B8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6AD8", Offset = "0xBA6AD8")]
	public bool Rename(string oldTag, string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x277E214", Offset = "0x277E214", VA = "0x277E214")]
	public void Delete(string tag)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x277DDDC", Offset = "0x277DDDC", VA = "0x277DDDC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6AEC", Offset = "0xBA6AEC")]
	public bool Delete()
	{
		return default(bool);
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x277DF60", Offset = "0x277DF60", VA = "0x277DF60")]
	private bool Delete(byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x277E278", Offset = "0x277E278", VA = "0x277E278")]
	public static ES2Writer Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x277A63C", Offset = "0x277A63C", VA = "0x277A63C")]
	public static ES2Writer Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x277E2D4", Offset = "0x277E2D4", VA = "0x277E2D4")]
	public static ES2Writer Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x277DA3C", Offset = "0x277DA3C", VA = "0x277DA3C")]
	public ES2Writer(ES2Settings settings)
	{
	}
}
[Token(Token = "0x2000070")]
public class ES3AutoSave : MonoBehaviour
{
	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool saveChildren;

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x253D7E8", Offset = "0x253D7E8", VA = "0x253D7E8")]
	public ES3AutoSave()
	{
	}
}
[Token(Token = "0x2000071")]
public class ES3AutoSaveMgr : MonoBehaviour, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000072")]
	public enum LoadEvent
	{
		[Token(Token = "0x400014C")]
		None,
		[Token(Token = "0x400014D")]
		Awake,
		[Token(Token = "0x400014E")]
		Start
	}

	[Token(Token = "0x2000073")]
	public enum SaveEvent
	{
		[Token(Token = "0x4000150")]
		None,
		[Token(Token = "0x4000151")]
		OnApplicationQuit
	}

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveEvent saveEvent;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LoadEvent loadEvent;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ES3SerializableSettings settings;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES3AutoSave[] autoSaves;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x253D7F0", Offset = "0x253D7F0", VA = "0x253D7F0")]
	public void Save()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x253D970", Offset = "0x253D970", VA = "0x253D970")]
	public void Load()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x253DA48", Offset = "0x253DA48", VA = "0x253DA48")]
	private void Start()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x253DA5C", Offset = "0x253DA5C", VA = "0x253DA5C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x253DA70", Offset = "0x253DA70", VA = "0x253DA70")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x253DA84", Offset = "0x253DA84", VA = "0x253DA84")]
	public void UpdateAutoSaves()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x253DADC", Offset = "0x253DADC", VA = "0x253DADC", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x253DAE0", Offset = "0x253DAE0", VA = "0x253DAE0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x253DAE4", Offset = "0x253DAE4", VA = "0x253DAE4")]
	public ES3AutoSaveMgr()
	{
	}
}
[Token(Token = "0x2000074")]
public static class ES3
{
	[Token(Token = "0x2000075")]
	public enum Location
	{
		[Token(Token = "0x4000155")]
		File,
		[Token(Token = "0x4000156")]
		PlayerPrefs,
		[Token(Token = "0x4000157")]
		Memory,
		[Token(Token = "0x4000158")]
		Resources
	}

	[Token(Token = "0x2000076")]
	public enum Directory
	{
		[Token(Token = "0x400015A")]
		PersistentDataPath,
		[Token(Token = "0x400015B")]
		DataPath
	}

	[Token(Token = "0x2000077")]
	public enum EncryptionType
	{
		[Token(Token = "0x400015D")]
		None,
		[Token(Token = "0x400015E")]
		AES
	}

	[Token(Token = "0x2000078")]
	public enum Format
	{
		[Token(Token = "0x4000160")]
		JSON
	}

	[Token(Token = "0x2000079")]
	public enum ReferenceMode
	{
		[Token(Token = "0x4000162")]
		ByRef,
		[Token(Token = "0x4000163")]
		ByValue,
		[Token(Token = "0x4000164")]
		ByRefAndValue
	}

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string backupFileSuffix;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string temporaryFileSuffix;

	[Token(Token = "0x6000362")]
	public static void Save<T>(string key, object value)
	{
	}

	[Token(Token = "0x6000363")]
	public static void Save<T>(string key, object value, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000364")]
	public static void Save<T>(string key, object value, string filePath)
	{
	}

	[Token(Token = "0x6000365")]
	public static void Save<T>(string key, object value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x2786B94", Offset = "0x2786B94", VA = "0x2786B94")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x2786D90", Offset = "0x2786D90", VA = "0x2786D90")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x2786E2C", Offset = "0x2786E2C", VA = "0x2786E2C")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x2786C20", Offset = "0x2786C20", VA = "0x2786C20")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x2786ED0", Offset = "0x2786ED0", VA = "0x2786ED0")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x2786FF8", Offset = "0x2786FF8", VA = "0x2786FF8")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x2787094", Offset = "0x2787094", VA = "0x2787094")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x2786F5C", Offset = "0x2786F5C", VA = "0x2786F5C")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x2787138", Offset = "0x2787138", VA = "0x2787138")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x278736C", Offset = "0x278736C", VA = "0x278736C")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x27871C4", Offset = "0x27871C4", VA = "0x27871C4")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x2787410", Offset = "0x2787410", VA = "0x2787410")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x2787668", Offset = "0x2787668", VA = "0x2787668")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x278749C", Offset = "0x278749C", VA = "0x278749C")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x278770C", Offset = "0x278770C", VA = "0x278770C")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x2787948", Offset = "0x2787948", VA = "0x2787948")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x27877A8", Offset = "0x27877A8", VA = "0x27877A8")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000377")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000378")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x6000379")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600037A")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600037B")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600037C")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x600037D")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600037E")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x600037F")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000380")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x6000381")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000382")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x27879EC", Offset = "0x27879EC", VA = "0x27879EC")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x2787C28", Offset = "0x2787C28", VA = "0x2787C28")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x2787CB4", Offset = "0x2787CB4", VA = "0x2787CB4")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x2787A70", Offset = "0x2787A70", VA = "0x2787A70")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x2787D50", Offset = "0x2787D50", VA = "0x2787D50")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x2787E64", Offset = "0x2787E64", VA = "0x2787E64")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x2787EF0", Offset = "0x2787EF0", VA = "0x2787EF0")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x2787DD4", Offset = "0x2787DD4", VA = "0x2787DD4")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x2787F8C", Offset = "0x2787F8C", VA = "0x2787F8C")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x278807C", Offset = "0x278807C", VA = "0x278807C")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x2788018", Offset = "0x2788018", VA = "0x2788018")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x2788118", Offset = "0x2788118", VA = "0x2788118")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x278818C", Offset = "0x278818C", VA = "0x278818C")]
	public static AudioClip LoadAudio(string audioFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x2788218", Offset = "0x2788218", VA = "0x2788218")]
	public static AudioClip LoadAudio(string audioFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x27884F0", Offset = "0x27884F0", VA = "0x27884F0")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x278864C", Offset = "0x278864C", VA = "0x278864C")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x27886D8", Offset = "0x27886D8", VA = "0x27886D8")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x2788574", Offset = "0x2788574", VA = "0x2788574")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x2788774", Offset = "0x2788774", VA = "0x2788774")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x2788970", Offset = "0x2788970", VA = "0x2788970")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x2788828", Offset = "0x2788828", VA = "0x2788828")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x2788A3C", Offset = "0x2788A3C", VA = "0x2788A3C")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x2788C4C", Offset = "0x2788C4C", VA = "0x2788C4C")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x2788AF0", Offset = "0x2788AF0", VA = "0x2788AF0")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x2788D18", Offset = "0x2788D18", VA = "0x2788D18")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x2788E80", Offset = "0x2788E80", VA = "0x2788E80")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x2788DA4", Offset = "0x2788DA4", VA = "0x2788DA4")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x2788F1C", Offset = "0x2788F1C", VA = "0x2788F1C")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x27891A4", Offset = "0x27891A4", VA = "0x27891A4")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x2789240", Offset = "0x2789240", VA = "0x2789240")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x2788FA8", Offset = "0x2788FA8", VA = "0x2788FA8")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x27893F0", Offset = "0x27893F0", VA = "0x27893F0")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x27895E4", Offset = "0x27895E4", VA = "0x27895E4")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x2789680", Offset = "0x2789680", VA = "0x2789680")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x278947C", Offset = "0x278947C", VA = "0x278947C")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x2789724", Offset = "0x2789724", VA = "0x2789724")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x27897A8", Offset = "0x27897A8", VA = "0x27897A8")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x2789834", Offset = "0x2789834", VA = "0x2789834")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x27892E4", Offset = "0x27892E4", VA = "0x27892E4")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x27898D0", Offset = "0x27898D0", VA = "0x27898D0")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x2789A3C", Offset = "0x2789A3C", VA = "0x2789A3C")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x278995C", Offset = "0x278995C", VA = "0x278995C")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x2789AD8", Offset = "0x2789AD8", VA = "0x2789AD8")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x2789F60", Offset = "0x2789F60", VA = "0x2789F60")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x2789FEC", Offset = "0x2789FEC", VA = "0x2789FEC")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x2789B5C", Offset = "0x2789B5C", VA = "0x2789B5C")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x278A088", Offset = "0x278A088", VA = "0x278A088")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x278A198", Offset = "0x278A198", VA = "0x278A198")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x278A224", Offset = "0x278A224", VA = "0x278A224")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x278A10C", Offset = "0x278A10C", VA = "0x278A10C")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x278A2C0", Offset = "0x278A2C0", VA = "0x278A2C0")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x278A3D0", Offset = "0x278A3D0", VA = "0x278A3D0")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x278A45C", Offset = "0x278A45C", VA = "0x278A45C")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x278A344", Offset = "0x278A344", VA = "0x278A344")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x278A4F8", Offset = "0x278A4F8", VA = "0x278A4F8")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x278A644", Offset = "0x278A644", VA = "0x278A644")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x278A6D0", Offset = "0x278A6D0", VA = "0x278A6D0")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x278A57C", Offset = "0x278A57C", VA = "0x278A57C")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x278A76C", Offset = "0x278A76C", VA = "0x278A76C")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x278A8F4", Offset = "0x278A8F4", VA = "0x278A8F4")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x278A7F8", Offset = "0x278A7F8", VA = "0x278A7F8")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x278A990", Offset = "0x278A990", VA = "0x278A990")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x278AB44", Offset = "0x278AB44", VA = "0x278AB44")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x278ABD0", Offset = "0x278ABD0", VA = "0x278ABD0")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x278AA14", Offset = "0x278AA14", VA = "0x278AA14")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x278AC6C", Offset = "0x278AC6C", VA = "0x278AC6C")]
	public static void Init()
	{
	}
}
[Token(Token = "0x200007A")]
public class ES3File
{
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, ES3Data> cache;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool syncWithFile;

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x254286C", Offset = "0x254286C", VA = "0x254286C")]
	public ES3File()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x2542D50", Offset = "0x2542D50", VA = "0x2542D50")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x2542DCC", Offset = "0x2542DCC", VA = "0x2542DCC")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x2542E44", Offset = "0x2542E44", VA = "0x2542E44")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x2542E4C", Offset = "0x2542E4C", VA = "0x2542E4C")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x2542EB8", Offset = "0x2542EB8", VA = "0x2542EB8")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x2542F38", Offset = "0x2542F38", VA = "0x2542F38")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x25428CC", Offset = "0x25428CC", VA = "0x25428CC")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x25430B8", Offset = "0x25430B8", VA = "0x25430B8")]
	public ES3File(byte[] bytes)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x2543124", Offset = "0x2543124", VA = "0x2543124")]
	public ES3File(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x25435F4", Offset = "0x25435F4", VA = "0x25435F4")]
	public void Sync()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x2543988", Offset = "0x2543988", VA = "0x2543988")]
	public void Sync(string filePath)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x2543A00", Offset = "0x2543A00", VA = "0x2543A00")]
	public void Sync(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x25435FC", Offset = "0x25435FC", VA = "0x25435FC")]
	public void Sync(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x2543A74", Offset = "0x2543A74", VA = "0x2543A74")]
	public void Clear()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x2543AC8", Offset = "0x2543AC8", VA = "0x2543AC8")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	public void Save<T>(string key, object value)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x2543B98", Offset = "0x2543B98", VA = "0x2543B98")]
	public void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x25431D8", Offset = "0x25431D8", VA = "0x25431D8")]
	public void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D9")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60003DA")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60003DB")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x253E900", Offset = "0x253E900", VA = "0x253E900")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x2543C58", Offset = "0x2543C58", VA = "0x2543C58")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x2543D04", Offset = "0x2543D04", VA = "0x2543D04")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x2543D68", Offset = "0x2543D68", VA = "0x2543D68")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x2543DCC", Offset = "0x2543DCC", VA = "0x2543DCC")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x2543EF8", Offset = "0x2543EF8", VA = "0x2543EF8")]
	public Type GetKeyType(string key)
	{
		return null;
	}
}
[Token(Token = "0x200007B")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x2545338", Offset = "0x2545338", VA = "0x2545338")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x200007C")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase, ISerializationCallbackReceiver
{
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x254BB80", Offset = "0x254BB80", VA = "0x254BB80", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x254BB84", Offset = "0x254BB84", VA = "0x254BB84", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x254BB88", Offset = "0x254BB88", VA = "0x254BB88")]
	public ES3ReferenceMgr()
	{
	}
}
[Token(Token = "0x200007D")]
public class ES3Spreadsheet
{
	[Token(Token = "0x200007E")]
	protected struct Index
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int col;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int row;

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x3014778", Offset = "0x3014778", VA = "0x3014778")]
		public Index(int col, int row)
		{
		}
	}

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int cols;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int rows;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Index, string> cells;

	[Token(Token = "0x400016B")]
	private const string QUOTE = "\"";

	[Token(Token = "0x400016C")]
	private const char QUOTE_CHAR = '"';

	[Token(Token = "0x400016D")]
	private const char COMMA_CHAR = ',';

	[Token(Token = "0x400016E")]
	private const char NEWLINE_CHAR = '\n';

	[Token(Token = "0x400016F")]
	private const string ESCAPED_QUOTE = "\"\"";

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static char[] CHARS_TO_ESCAPE;

	[Token(Token = "0x17000047")]
	public int ColumnCount
	{
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x254F644", Offset = "0x254F644", VA = "0x254F644")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000048")]
	public int RowCount
	{
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x254F64C", Offset = "0x254F64C", VA = "0x254F64C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60003E8")]
	public void SetCell<T>(int col, int row, object value)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x254F654", Offset = "0x254F654", VA = "0x254F654")]
	private void SetCell(int col, int row, string value)
	{
	}

	[Token(Token = "0x60003EA")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x254F714", Offset = "0x254F714", VA = "0x254F714")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x254FA54", Offset = "0x254FA54", VA = "0x254FA54")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x254F78C", Offset = "0x254F78C", VA = "0x254F78C")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x254FAC8", Offset = "0x254FAC8", VA = "0x254FAC8")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x254FE98", Offset = "0x254FE98", VA = "0x254FE98")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x254FF10", Offset = "0x254FF10", VA = "0x254FF10")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x254FF18", Offset = "0x254FF18", VA = "0x254FF18")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x254FF98", Offset = "0x254FF98", VA = "0x254FF98")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x254FB44", Offset = "0x254FB44", VA = "0x254FB44")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x25501D8", Offset = "0x25501D8", VA = "0x25501D8")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x25502F4", Offset = "0x25502F4", VA = "0x25502F4")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x255001C", Offset = "0x255001C", VA = "0x255001C")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x25503D8", Offset = "0x25503D8", VA = "0x25503D8")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x200007F")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E7E0", Offset = "0xB9E7E0")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E7F4", Offset = "0xB9E7F4")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderPropertyEnumerator <>4__this;

			[Token(Token = "0x1700004B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600043B")]
				[Address(RVA = "0x301679C", Offset = "0x301679C", VA = "0x301679C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600043D")]
				[Address(RVA = "0x30167E4", Offset = "0x30167E4", VA = "0x30167E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x3013FA4", Offset = "0x3013FA4", VA = "0x3013FA4")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x30166E4", Offset = "0x30166E4", VA = "0x30166E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x30166E8", Offset = "0x30166E8", VA = "0x30166E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x30167A4", Offset = "0x30167A4", VA = "0x30167A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x3013EF8", Offset = "0x3013EF8", VA = "0x3013EF8")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x3013F2C", Offset = "0x3013F2C", VA = "0x3013F2C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6B78", Offset = "0xBA6B78")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E804", Offset = "0xB9E804")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E818", Offset = "0xB9E818")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderRawEnumerator <>4__this;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x3016968", Offset = "0x3016968", VA = "0x3016968", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x30169B0", Offset = "0x30169B0", VA = "0x30169B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x301407C", Offset = "0x301407C", VA = "0x301407C")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x30167EC", Offset = "0x30167EC", VA = "0x30167EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x30167F0", Offset = "0x30167F0", VA = "0x30167F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x3016970", Offset = "0x3016970", VA = "0x3016970", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x3013FD0", Offset = "0x3013FD0", VA = "0x3013FD0")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x3014004", Offset = "0x3014004", VA = "0x3014004")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6C28", Offset = "0xBA6C28")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal string overridePropertiesName;

	[Token(Token = "0x17000049")]
	public virtual ES3ReaderPropertyEnumerator Properties
	{
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x254AE74", Offset = "0x254AE74", VA = "0x254AE74", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004A")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x254AED4", Offset = "0x254AED4", VA = "0x254AED4", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003FA")]
	internal abstract int Read_int();

	[Token(Token = "0x60003FB")]
	internal abstract float Read_float();

	[Token(Token = "0x60003FC")]
	internal abstract bool Read_bool();

	[Token(Token = "0x60003FD")]
	internal abstract char Read_char();

	[Token(Token = "0x60003FE")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x60003FF")]
	internal abstract double Read_double();

	[Token(Token = "0x6000400")]
	internal abstract long Read_long();

	[Token(Token = "0x6000401")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x6000402")]
	internal abstract byte Read_byte();

	[Token(Token = "0x6000403")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x6000404")]
	internal abstract short Read_short();

	[Token(Token = "0x6000405")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x6000406")]
	internal abstract uint Read_uint();

	[Token(Token = "0x6000407")]
	internal abstract string Read_string();

	[Token(Token = "0x6000408")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x6000409")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6B00", Offset = "0xBA6B00")]
	public abstract string ReadPropertyName();

	[Token(Token = "0x600040A")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x600040B")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x600040C")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x600040D")]
	internal abstract bool Goto(string key);

	[Token(Token = "0x600040E")]
	public abstract void Dispose();

	[Token(Token = "0x600040F")]
	internal abstract bool StartReadObject();

	[Token(Token = "0x6000410")]
	internal abstract void EndReadObject();

	[Token(Token = "0x6000411")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x6000412")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x6000413")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x6000414")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x6000415")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x6000416")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x6000417")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x6000418")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x6000419")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x600041A")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x2545490", Offset = "0x2545490", VA = "0x2545490")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x254AF34", Offset = "0x254AF34", VA = "0x254AF34", Slot = "40")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6B14", Offset = "0xBA6B14")]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x600041F")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000420")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x6000421")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6B28", Offset = "0xBA6B28")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000422")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6B3C", Offset = "0xBA6B3C")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x254AF48", Offset = "0x254AF48", VA = "0x254AF48")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x254B058", Offset = "0x254B058", VA = "0x254B058")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x254B290", Offset = "0x254B290", VA = "0x254B290")]
	public void SetPrivateField(string name, object value, object objectContainingField)
	{
	}

	[Token(Token = "0x6000426")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000427")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000428")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000429")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x600042A")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600042B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6B50", Offset = "0xBA6B50")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600042C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6B64", Offset = "0xBA6B64")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x600042D")]
	private Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x254B4D0", Offset = "0x254B4D0", VA = "0x254B4D0")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x254B524", Offset = "0x254B524", VA = "0x254B524")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x254B58C", Offset = "0x254B58C", VA = "0x254B58C")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x2543020", Offset = "0x2543020", VA = "0x2543020")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x254B990", Offset = "0x254B990", VA = "0x254B990")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x2543BA0", Offset = "0x2543BA0", VA = "0x2543BA0")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x254B9EC", Offset = "0x254B9EC", VA = "0x254B9EC")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x254BA74", Offset = "0x254BA74", VA = "0x254BA74")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x2000084")]
public class ES3Settings : ICloneable
{
	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES3Settings _defaults;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private ES3.Location _location;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ES3.EncryptionType encryptionType;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string encryptionPassword;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES3.Directory directory;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ES3.Format format;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int bufferSize;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4F9C", Offset = "0xBA4F9C")]
	public bool typeChecking;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4FB0", Offset = "0xBA4FB0")]
	public bool safeReflection;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4FC4", Offset = "0xBA4FC4")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4FD8", Offset = "0xBA4FD8")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4FEC", Offset = "0xBA4FEC")]
	public string[] assemblyNames;

	[Token(Token = "0x1700004F")]
	public ES3.Location location
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2544FA8", Offset = "0x2544FA8", VA = "0x2544FA8")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x254F1AC", Offset = "0x254F1AC", VA = "0x254F1AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public string FullPath
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2544FE8", Offset = "0x2544FE8", VA = "0x2544FE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x254F1B4", Offset = "0x254F1B4", VA = "0x254F1B4")]
	private void CopyInto(ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x253DEE0", Offset = "0x253DEE0", VA = "0x253DEE0")]
	public ES3Settings()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x253E084", Offset = "0x253E084", VA = "0x253E084")]
	public ES3Settings(string path)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x253E26C", Offset = "0x253E26C", VA = "0x253E26C")]
	public ES3Settings(string path, ES3Settings settings)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x254F30C", Offset = "0x254F30C", VA = "0x254F30C")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x254F34C", Offset = "0x254F34C", VA = "0x254F34C")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x254F3A0", Offset = "0x254F3A0", VA = "0x254F3A0")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, ES3Settings settings)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x254F0DC", Offset = "0x254F0DC", VA = "0x254F0DC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6CD8", Offset = "0xBA6CD8")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x254F258", Offset = "0x254F258", VA = "0x254F258")]
	protected void ApplyDefaults()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x254F3E4", Offset = "0x254F3E4", VA = "0x254F3E4")]
	internal static void LoadDefaults()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x254F5B8", Offset = "0x254F5B8", VA = "0x254F5B8")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x2542FBC", Offset = "0x2542FBC", VA = "0x2542FBC", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA6CEC", Offset = "0xBA6CEC")]
	public object Clone()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000085")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9E828", Offset = "0xB9E828")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x6000456")]
	[Address(RVA = "0x254F078", Offset = "0x254F078", VA = "0x254F078")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x254F13C", Offset = "0x254F13C", VA = "0x254F13C")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}
}
[Token(Token = "0x2000086")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E83C", Offset = "0xB9E83C")]
	private sealed class <Sync>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x3013A30", Offset = "0x3013A30", VA = "0x3013A30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x3013A78", Offset = "0x3013A78", VA = "0x3013A78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x3013878", Offset = "0x3013878", VA = "0x3013878")]
		[DebuggerHidden]
		public <Sync>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x30138A4", Offset = "0x30138A4", VA = "0x30138A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x30138A8", Offset = "0x30138A8", VA = "0x30138A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x3013A38", Offset = "0x3013A38", VA = "0x3013A38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E84C", Offset = "0xB9E84C")]
	private sealed class <UploadFile>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte[] bytes;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x3013EA8", Offset = "0x3013EA8", VA = "0x3013EA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x3013EF0", Offset = "0x3013EF0", VA = "0x3013EF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x3013A80", Offset = "0x3013A80", VA = "0x3013A80")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x3013AAC", Offset = "0x3013AAC", VA = "0x3013AAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x3013B84", Offset = "0x3013B84", VA = "0x3013B84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x3013AC8", Offset = "0x3013AC8", VA = "0x3013AC8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x3013EB0", Offset = "0x3013EB0", VA = "0x3013EB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E85C", Offset = "0xB9E85C")]
	private sealed class <DownloadFile>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3File es3File;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000059")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x3012824", Offset = "0x3012824", VA = "0x3012824", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x301286C", Offset = "0x301286C", VA = "0x301286C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x30123B0", Offset = "0x30123B0", VA = "0x30123B0")]
		[DebuggerHidden]
		public <DownloadFile>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x30123DC", Offset = "0x30123DC", VA = "0x30123DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x30124B4", Offset = "0x30124B4", VA = "0x30124B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x30123F8", Offset = "0x30123F8", VA = "0x30123F8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x301282C", Offset = "0x301282C", VA = "0x301282C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E86C", Offset = "0xB9E86C")]
	private sealed class <DownloadFile>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x3012CE4", Offset = "0x3012CE4", VA = "0x3012CE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x3012D2C", Offset = "0x3012D2C", VA = "0x3012D2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x3012874", Offset = "0x3012874", VA = "0x3012874")]
		[DebuggerHidden]
		public <DownloadFile>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x30128A0", Offset = "0x30128A0", VA = "0x30128A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x3012978", Offset = "0x3012978", VA = "0x3012978", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x30128BC", Offset = "0x30128BC", VA = "0x30128BC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x3012CEC", Offset = "0x3012CEC", VA = "0x3012CEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E87C", Offset = "0xB9E87C")]
	private sealed class <DeleteFile>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700005D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x3012360", Offset = "0x3012360", VA = "0x3012360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x30123A8", Offset = "0x30123A8", VA = "0x30123A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x3012034", Offset = "0x3012034", VA = "0x3012034")]
		[DebuggerHidden]
		public <DeleteFile>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x3012060", Offset = "0x3012060", VA = "0x3012060", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x3012138", Offset = "0x3012138", VA = "0x3012138", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x301207C", Offset = "0x301207C", VA = "0x301207C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x3012368", Offset = "0x3012368", VA = "0x3012368", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E88C", Offset = "0xB9E88C")]
	private sealed class <RenameFile>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Settings newSettings;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700005F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x3013828", Offset = "0x3013828", VA = "0x3013828", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x3013870", Offset = "0x3013870", VA = "0x3013870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x30134C0", Offset = "0x30134C0", VA = "0x30134C0")]
		[DebuggerHidden]
		public <RenameFile>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x30134EC", Offset = "0x30134EC", VA = "0x30134EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x30135C4", Offset = "0x30135C4", VA = "0x30135C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x3013508", Offset = "0x3013508", VA = "0x3013508")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x3013830", Offset = "0x3013830", VA = "0x3013830", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E89C", Offset = "0xB9E89C")]
	private sealed class <DownloadFilenames>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000061")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x30130AC", Offset = "0x30130AC", VA = "0x30130AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x30130F4", Offset = "0x30130F4", VA = "0x30130F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x3012D34", Offset = "0x3012D34", VA = "0x3012D34")]
		[DebuggerHidden]
		public <DownloadFilenames>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x3012D60", Offset = "0x3012D60", VA = "0x3012D60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x3012E38", Offset = "0x3012E38", VA = "0x3012E38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x3012D7C", Offset = "0x3012D7C", VA = "0x3012D7C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x30130B4", Offset = "0x30130B4", VA = "0x30130B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E8AC", Offset = "0xB9E8AC")]
	private sealed class <DownloadTimestamp>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x3013470", Offset = "0x3013470", VA = "0x3013470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x30134B8", Offset = "0x30134B8", VA = "0x30134B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x30130FC", Offset = "0x30130FC", VA = "0x30130FC")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x3013128", Offset = "0x3013128", VA = "0x3013128", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x3013200", Offset = "0x3013200", VA = "0x3013200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x3013144", Offset = "0x3013144", VA = "0x3013144")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x3013478", Offset = "0x3013478", VA = "0x3013478", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private byte[] _data;

	[Token(Token = "0x17000051")]
	public byte[] data
	{
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x253DBDC", Offset = "0x253DBDC", VA = "0x253DBDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000052")]
	public string text
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x253DBE4", Offset = "0x253DBE4", VA = "0x253DBE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public string[] filenames
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x253DC18", Offset = "0x253DC18", VA = "0x253DC18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000054")]
	public DateTime timestamp
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x253DCE4", Offset = "0x253DCE4", VA = "0x253DCE4")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x253DB88", Offset = "0x253DB88", VA = "0x253DB88")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x253DE68", Offset = "0x253DE68", VA = "0x253DE68")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x253DFF0", Offset = "0x253DFF0", VA = "0x253DFF0")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x253E0B4", Offset = "0x253E0B4", VA = "0x253E0B4")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x253E14C", Offset = "0x253E14C", VA = "0x253E14C")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x253E1DC", Offset = "0x253E1DC", VA = "0x253E1DC")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x253E2E0", Offset = "0x253E2E0", VA = "0x253E2E0")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x253E37C", Offset = "0x253E37C", VA = "0x253E37C")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x253DF2C", Offset = "0x253DF2C", VA = "0x253DF2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6D00", Offset = "0xBA6D00")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x253E408", Offset = "0x253E408", VA = "0x253E408")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x253E518", Offset = "0x253E518", VA = "0x253E518")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x253E5AC", Offset = "0x253E5AC", VA = "0x253E5AC")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x253E644", Offset = "0x253E644", VA = "0x253E644")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x253E6D4", Offset = "0x253E6D4", VA = "0x253E6D4")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x253E764", Offset = "0x253E764", VA = "0x253E764")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x253E800", Offset = "0x253E800", VA = "0x253E800")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x253E88C", Offset = "0x253E88C", VA = "0x253E88C")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x253EEB0", Offset = "0x253EEB0", VA = "0x253EEB0")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x253EF28", Offset = "0x253EF28", VA = "0x253EF28")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x253E480", Offset = "0x253E480", VA = "0x253E480")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x253EDD8", Offset = "0x253EDD8", VA = "0x253EDD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6D60", Offset = "0xBA6D60")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x253EF7C", Offset = "0x253EF7C", VA = "0x253EF7C")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x253F0C4", Offset = "0x253F0C4", VA = "0x253F0C4")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x253F15C", Offset = "0x253F15C", VA = "0x253F15C")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x253F1F8", Offset = "0x253F1F8", VA = "0x253F1F8")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x253F28C", Offset = "0x253F28C", VA = "0x253F28C")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x253F320", Offset = "0x253F320", VA = "0x253F320")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x253F3C0", Offset = "0x253F3C0", VA = "0x253F3C0")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x253F450", Offset = "0x253F450", VA = "0x253F450")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x253F580", Offset = "0x253F580", VA = "0x253F580")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x253F5E8", Offset = "0x253F5E8", VA = "0x253F5E8")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x253F4B4", Offset = "0x253F4B4", VA = "0x253F4B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6DC0", Offset = "0xBA6DC0")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x253EFF8", Offset = "0x253EFF8", VA = "0x253EFF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6E20", Offset = "0xBA6E20")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x253F5F0", Offset = "0x253F5F0", VA = "0x253F5F0")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x253F72C", Offset = "0x253F72C", VA = "0x253F72C")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x253F7C0", Offset = "0x253F7C0", VA = "0x253F7C0")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x253F858", Offset = "0x253F858", VA = "0x253F858")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x253F8E8", Offset = "0x253F8E8", VA = "0x253F8E8")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x253F978", Offset = "0x253F978", VA = "0x253F978")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x253FA14", Offset = "0x253FA14", VA = "0x253FA14")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x253F668", Offset = "0x253F668", VA = "0x253F668")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6E80", Offset = "0xBA6E80")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x253FAA0", Offset = "0x253FAA0", VA = "0x253FAA0")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x253FC3C", Offset = "0x253FC3C", VA = "0x253FC3C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x253FD04", Offset = "0x253FD04", VA = "0x253FD04")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x253FDC4", Offset = "0x253FDC4", VA = "0x253FDC4")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x253FE7C", Offset = "0x253FE7C", VA = "0x253FE7C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x253FF40", Offset = "0x253FF40", VA = "0x253FF40")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x253FB64", Offset = "0x253FB64", VA = "0x253FB64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6EE0", Offset = "0xBA6EE0")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x253FFF4", Offset = "0x253FFF4", VA = "0x253FFF4")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x25400EC", Offset = "0x25400EC", VA = "0x25400EC")]
	public IEnumerator DownloadFilenames(string user)
	{
		return null;
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x2540044", Offset = "0x2540044", VA = "0x2540044")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6F40", Offset = "0xBA6F40")]
	public IEnumerator DownloadFilenames(string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x2540148", Offset = "0x2540148", VA = "0x2540148")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x2540284", Offset = "0x2540284", VA = "0x2540284")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x2540318", Offset = "0x2540318", VA = "0x2540318")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x25403B0", Offset = "0x25403B0", VA = "0x25403B0")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x2540440", Offset = "0x2540440", VA = "0x2540440")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x25404D0", Offset = "0x25404D0", VA = "0x25404D0")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x254056C", Offset = "0x254056C", VA = "0x254056C")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x25401C0", Offset = "0x25401C0", VA = "0x25401C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA6FA0", Offset = "0xBA6FA0")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x25405F8", Offset = "0x25405F8", VA = "0x25405F8")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x2540708", Offset = "0x2540708", VA = "0x2540708")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x2540774", Offset = "0x2540774", VA = "0x2540774", Slot = "4")]
	protected override void Reset()
	{
	}
}
[Token(Token = "0x200008F")]
public abstract class ES3Writer : IDisposable
{
	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HashSet<string> keysToDelete;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool writeHeaderAndFooter;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	internal bool overwriteKeys;

	[Token(Token = "0x60004D1")]
	internal abstract void WriteNull();

	[Token(Token = "0x60004D2")]
	internal abstract void StartWriteFile();

	[Token(Token = "0x60004D3")]
	internal abstract void EndWriteFile();

	[Token(Token = "0x60004D4")]
	internal abstract void StartWriteObject(string name);

	[Token(Token = "0x60004D5")]
	internal abstract void EndWriteObject(string name);

	[Token(Token = "0x60004D6")]
	internal abstract void StartWriteProperty(string name);

	[Token(Token = "0x60004D7")]
	internal abstract void EndWriteProperty(string name);

	[Token(Token = "0x60004D8")]
	internal abstract void StartWriteCollection(int length);

	[Token(Token = "0x60004D9")]
	internal abstract void EndWriteCollection();

	[Token(Token = "0x60004DA")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x60004DB")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x60004DC")]
	internal abstract void StartWriteDictionary(int length);

	[Token(Token = "0x60004DD")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x60004DE")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x60004DF")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x60004E0")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x60004E1")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x60004E2")]
	public abstract void Dispose();

	[Token(Token = "0x60004E3")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x60004E4")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x60004E5")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x60004E6")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x60004E7")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x60004E8")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x60004E9")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x60004EA")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x60004EB")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x60004EC")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x60004ED")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x60004EE")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x60004EF")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x60004F0")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x60004F1")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x60004F2")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x2588248", Offset = "0x2588248", VA = "0x2588248")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x60004F4")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x2588318", Offset = "0x2588318", VA = "0x2588318", Slot = "40")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x2588478", Offset = "0x2588478", VA = "0x2588478", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA7280", Offset = "0xBA7280")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x25885A0", Offset = "0x25885A0", VA = "0x25885A0", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA7294", Offset = "0xBA7294")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x258866C", Offset = "0x258866C", VA = "0x258866C", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA72A8", Offset = "0xBA72A8")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x25888DC", Offset = "0x25888DC", VA = "0x25888DC", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x2588A60", Offset = "0x2588A60", VA = "0x2588A60", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x2588AB0", Offset = "0x2588AB0", VA = "0x2588AB0", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x2588B00", Offset = "0x2588B00", VA = "0x2588B00", Slot = "47")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA72BC", Offset = "0xBA72BC")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x2588B60", Offset = "0x2588B60", VA = "0x2588B60", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA72D0", Offset = "0xBA72D0")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60004FE")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x2583BF4", Offset = "0x2583BF4", VA = "0x2583BF4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA72E4", Offset = "0xBA72E4")]
	public void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x2588BB8", Offset = "0x2588BB8", VA = "0x2588BB8")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x2588DC8", Offset = "0x2588DC8", VA = "0x2588DC8")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x2588FD8", Offset = "0x2588FD8", VA = "0x2588FD8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA72F8", Offset = "0xBA72F8")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x25891A0", Offset = "0x25891A0", VA = "0x25891A0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA730C", Offset = "0xBA730C")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x2589368", Offset = "0x2589368", VA = "0x2589368")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA7320", Offset = "0xBA7320")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x2589560", Offset = "0x2589560", VA = "0x2589560")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA7334", Offset = "0xBA7334")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x25883D8", Offset = "0x25883D8", VA = "0x25883D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA7348", Offset = "0xBA7348")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x2589758", Offset = "0x2589758", VA = "0x2589758")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x25897D4", Offset = "0x25897D4", VA = "0x25897D4")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x25897E4", Offset = "0x25897E4", VA = "0x25897E4")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x2589844", Offset = "0x2589844", VA = "0x2589844")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x25899C8", Offset = "0x25899C8", VA = "0x25899C8", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA735C", Offset = "0xBA735C")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x2589A2C", Offset = "0x2589A2C", VA = "0x2589A2C")]
	protected void Merge()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x2589B78", Offset = "0x2589B78", VA = "0x2589B78")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x2589EA0", Offset = "0x2589EA0", VA = "0x2589EA0", Slot = "51")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x2589EB4", Offset = "0x2589EB4", VA = "0x2589EB4", Slot = "52")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x2000090")]
public static class EditorPrefsStrings
{
}
namespace VLB
{
	[Token(Token = "0x2000091")]
	public static class BatchingHelper
	{
		[Token(Token = "0x17000065")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x22D4C10", Offset = "0x22D4C10", VA = "0x22D4C10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x22D4D5C", Offset = "0x22D4D5C", VA = "0x22D4D5C")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x22D4D74", Offset = "0x22D4D74", VA = "0x22D4D74")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x22D4D90", Offset = "0x22D4D90", VA = "0x22D4D90")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x22D53E0", Offset = "0x22D53E0", VA = "0x22D53E0")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x22D5594", Offset = "0x22D5594", VA = "0x22D5594")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9E8BC", Offset = "0xB9E8BC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB9E8BC", Offset = "0xB9E8BC")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9E92C", Offset = "0xB9E92C")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000547")]
				[Address(RVA = "0x2595C2C", Offset = "0x2595C2C", VA = "0x2595C2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0x2595C74", Offset = "0x2595C74", VA = "0x2595C74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x2595B54", Offset = "0x2595B54", VA = "0x2595B54")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x2595B80", Offset = "0x2595B80", VA = "0x2595B80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x2595B84", Offset = "0x2595B84", VA = "0x2595B84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x2595C34", Offset = "0x2595C34", VA = "0x2595C34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5000", Offset = "0xBA5000")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5010", Offset = "0xBA5010")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5020", Offset = "0xBA5020")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000066")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x22D5660", Offset = "0x22D5660", VA = "0x22D5660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7370", Offset = "0xBA7370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x22D5668", Offset = "0x22D5668", VA = "0x22D5668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7380", Offset = "0xBA7380")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x22D5670", Offset = "0x22D5670", VA = "0x22D5670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7390", Offset = "0xBA7390")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x22D5678", Offset = "0x22D5678", VA = "0x22D5678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA73A0", Offset = "0xBA73A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x22D5680", Offset = "0x22D5680", VA = "0x22D5680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA73B0", Offset = "0xBA73B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x22D5688", Offset = "0x22D5688", VA = "0x22D5688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA73C0", Offset = "0xBA73C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool visible
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x22D5690", Offset = "0x22D5690", VA = "0x22D5690")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x22D56AC", Offset = "0x22D56AC", VA = "0x22D56AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int sortingLayerID
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x22D56CC", Offset = "0x22D56CC", VA = "0x22D56CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x22D56E8", Offset = "0x22D56E8", VA = "0x22D56E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public int sortingOrder
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x22D5704", Offset = "0x22D5704", VA = "0x22D5704")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x22D5720", Offset = "0x22D5720", VA = "0x22D5720")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x22D573C", Offset = "0x22D573C", VA = "0x22D573C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x22D6080", Offset = "0x22D6080", VA = "0x22D6080")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x22D6088", Offset = "0x22D6088", VA = "0x22D6088")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x22D73B0", Offset = "0x22D73B0", VA = "0x22D73B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x22D744C", Offset = "0x22D744C", VA = "0x22D744C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x22D574C", Offset = "0x22D574C", VA = "0x22D574C")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x22D5838", Offset = "0x22D5838", VA = "0x22D5838")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA73D0", Offset = "0xBA73D0")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x22D58B0", Offset = "0x22D58B0", VA = "0x22D58B0")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x22D59F8", Offset = "0x22D59F8", VA = "0x22D59F8")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x22D5D50", Offset = "0x22D5D50", VA = "0x22D5D50")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x22D5E3C", Offset = "0x22D5E3C", VA = "0x22D5E3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x22D5EF8", Offset = "0x22D5EF8", VA = "0x22D5EF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x22D5FB4", Offset = "0x22D5FB4", VA = "0x22D5FB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x22D611C", Offset = "0x22D611C", VA = "0x22D611C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x22D61E0", Offset = "0x22D61E0", VA = "0x22D61E0")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x22D66F4", Offset = "0x22D66F4", VA = "0x22D66F4")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x22D72D8", Offset = "0x22D72D8", VA = "0x22D72D8")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x22D7490", Offset = "0x22D7490", VA = "0x22D7490")]
		private MaterialManager.StaticProperties ComputeMaterialStaticProperties()
		{
			return default(MaterialManager.StaticProperties);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x22D65AC", Offset = "0x22D65AC", VA = "0x22D65AC")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x22D5B88", Offset = "0x22D5B88", VA = "0x22D5B88", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x22D75DC", Offset = "0x22D75DC", VA = "0x22D75DC", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x22D7708", Offset = "0x22D7708", VA = "0x22D7708", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x22D7834", Offset = "0x22D7834", VA = "0x22D7834", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x22D7968", Offset = "0x22D7968", VA = "0x22D7968", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x22D5ABC", Offset = "0x22D5ABC", VA = "0x22D5ABC")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x22D5C84", Offset = "0x22D5C84", VA = "0x22D5C84")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x22D7A58", Offset = "0x22D7A58", VA = "0x22D7A58")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x22D6A58", Offset = "0x22D6A58", VA = "0x22D6A58")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x22D7B70", Offset = "0x22D7B70", VA = "0x22D7B70")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x22D7CE8", Offset = "0x22D7CE8", VA = "0x22D7CE8")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x22D7CF4", Offset = "0x22D7CF4", VA = "0x22D7CF4")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x22D7D74", Offset = "0x22D7D74", VA = "0x22D7D74")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x22D7E5C", Offset = "0x22D7E5C", VA = "0x22D7E5C")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x22D8114", Offset = "0x22D8114", VA = "0x22D8114")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9E93C", Offset = "0xB9E93C")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x40001D8")]
		public const string ClassName = "Config";

		[Token(Token = "0x40001D9")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5030", Offset = "0xBA5030")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA507C", Offset = "0xBA507C")]
		[SerializeField]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ditheringFactor;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLightColorTemperature;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int sharedMeshSides;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int sharedMeshSegments;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA50C8", Offset = "0xBA50C8")]
		public float globalNoiseScale;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string fadeOutCameraTag;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HighlightNull]
		public Texture3D noiseTexture3D;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool featureEnabledDepthBlend;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		public bool featureEnabledNoise3D;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		public bool featureEnabledDynamicOcclusion;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
		public bool featureEnabledMeshSkewing;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool featureEnabledShaderAccuracyHigh;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config ms_Instance;

		[Token(Token = "0x17000073")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x22D85E8", Offset = "0x22D85E8", VA = "0x22D85E8")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x22D85F0", Offset = "0x22D85F0", VA = "0x22D85F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x22D8664", Offset = "0x22D8664", VA = "0x22D8664")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x22D866C", Offset = "0x22D866C", VA = "0x22D866C")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x22D4D10", Offset = "0x22D4D10", VA = "0x22D4D10")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000076")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x22D8768", Offset = "0x22D8768", VA = "0x22D8768")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x22D6A3C", Offset = "0x22D6A3C", VA = "0x22D6A3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public Shader beamShader
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x22D8784", Offset = "0x22D8784", VA = "0x22D8784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x22D5978", Offset = "0x22D5978", VA = "0x22D5978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public bool isHDRPExposureWeightSupported
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x22D7B68", Offset = "0x22D7B68", VA = "0x22D7B68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x22D8838", Offset = "0x22D8838", VA = "0x22D8838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public static Config Instance
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x22D4CB4", Offset = "0x22D4CB4", VA = "0x22D4CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x22D86E0", Offset = "0x22D86E0", VA = "0x22D86E0")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x22D878C", Offset = "0x22D878C", VA = "0x22D878C")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x22D88B4", Offset = "0x22D88B4", VA = "0x22D88B4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xBA7480", Offset = "0xBA7480")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x22D8A94", Offset = "0x22D8A94", VA = "0x22D8A94")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x22D89BC", Offset = "0x22D89BC", VA = "0x22D89BC")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x22D8BA8", Offset = "0x22D8BA8", VA = "0x22D8BA8")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x22D8D68", Offset = "0x22D8D68", VA = "0x22D8D68")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x22D8F38", Offset = "0x22D8F38", VA = "0x22D8F38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x22D8F44", Offset = "0x22D8F44", VA = "0x22D8F44")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x22D8F48", Offset = "0x22D8F48", VA = "0x22D8F48")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x22D9114", Offset = "0x22D9114", VA = "0x22D9114")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9E974", Offset = "0xB9E974")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x40001F5")]
		public new const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x22D9230", Offset = "0x22D9230", VA = "0x22D9230")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public static class Consts
	{
		[Token(Token = "0x2000097")]
		public static class Help
		{
			[Token(Token = "0x40001F7")]
			private const string UrlBase = "http://saladgamer.com/vlb-doc/";

			[Token(Token = "0x40001F8")]
			private const string UrlSuffix = "/";

			[Token(Token = "0x40001F9")]
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

			[Token(Token = "0x40001FA")]
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

			[Token(Token = "0x40001FB")]
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

			[Token(Token = "0x40001FC")]
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

			[Token(Token = "0x40001FD")]
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

			[Token(Token = "0x40001FE")]
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

			[Token(Token = "0x40001FF")]
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/";

			[Token(Token = "0x4000200")]
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/";

			[Token(Token = "0x4000201")]
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/";
		}

		[Token(Token = "0x2000098")]
		public static class Internal
		{
			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly bool ProceduralObjectsVisibleInEditor;

			[Token(Token = "0x1700007D")]
			public static HideFlags ProceduralObjectsHideFlags
			{
				[Token(Token = "0x6000563")]
				[Address(RVA = "0x258C7C4", Offset = "0x258C7C4", VA = "0x258C7C4")]
				get
				{
					return default(HideFlags);
				}
			}
		}

		[Token(Token = "0x2000099")]
		public static class Beam
		{
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Color FlatColor;

			[Token(Token = "0x4000204")]
			public const ColorMode ColorModeDefault = ColorMode.Flat;

			[Token(Token = "0x4000205")]
			public const float MultiplierDefault = 1f;

			[Token(Token = "0x4000206")]
			public const float MultiplierMin = 0f;

			[Token(Token = "0x4000207")]
			public const float IntensityDefault = 1f;

			[Token(Token = "0x4000208")]
			public const float IntensityMin = 0f;

			[Token(Token = "0x4000209")]
			public const float HDRPExposureWeightDefault = 0f;

			[Token(Token = "0x400020A")]
			public const float HDRPExposureWeightMin = 0f;

			[Token(Token = "0x400020B")]
			public const float HDRPExposureWeightMax = 1f;

			[Token(Token = "0x400020C")]
			public const float SpotAngleDefault = 35f;

			[Token(Token = "0x400020D")]
			public const float SpotAngleMin = 0.1f;

			[Token(Token = "0x400020E")]
			public const float SpotAngleMax = 179.9f;

			[Token(Token = "0x400020F")]
			public const float ConeRadiusStart = 0.1f;

			[Token(Token = "0x4000210")]
			public const MeshType GeomMeshType = MeshType.Shared;

			[Token(Token = "0x4000211")]
			public const int GeomSidesDefault = 18;

			[Token(Token = "0x4000212")]
			public const int GeomSidesMin = 3;

			[Token(Token = "0x4000213")]
			public const int GeomSidesMax = 256;

			[Token(Token = "0x4000214")]
			public const int GeomSegmentsDefault = 5;

			[Token(Token = "0x4000215")]
			public const int GeomSegmentsMin = 0;

			[Token(Token = "0x4000216")]
			public const int GeomSegmentsMax = 64;

			[Token(Token = "0x4000217")]
			public const bool GeomCap = false;

			[Token(Token = "0x4000218")]
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

			[Token(Token = "0x4000219")]
			public const float AttenuationCustomBlendingDefault = 0.5f;

			[Token(Token = "0x400021A")]
			public const float AttenuationCustomBlendingMin = 0f;

			[Token(Token = "0x400021B")]
			public const float AttenuationCustomBlendingMax = 1f;

			[Token(Token = "0x400021C")]
			public const float FallOffStart = 0f;

			[Token(Token = "0x400021D")]
			public const float FallOffEnd = 3f;

			[Token(Token = "0x400021E")]
			public const float FallOffDistancesMinThreshold = 0.01f;

			[Token(Token = "0x400021F")]
			public const float DepthBlendDistance = 2f;

			[Token(Token = "0x4000220")]
			public const float CameraClippingDistance = 0.5f;

			[Token(Token = "0x4000221")]
			public const float FresnelPowMaxValue = 10f;

			[Token(Token = "0x4000222")]
			public const float FresnelPow = 8f;

			[Token(Token = "0x4000223")]
			public const float GlareFrontalDefault = 0.5f;

			[Token(Token = "0x4000224")]
			public const float GlareBehindDefault = 0.5f;

			[Token(Token = "0x4000225")]
			public const float GlareMin = 0f;

			[Token(Token = "0x4000226")]
			public const float GlareMax = 1f;

			[Token(Token = "0x4000227")]
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

			[Token(Token = "0x4000228")]
			public const float NoiseIntensityMin = 0f;

			[Token(Token = "0x4000229")]
			public const float NoiseIntensityMax = 1f;

			[Token(Token = "0x400022A")]
			public const float NoiseIntensityDefault = 0.5f;

			[Token(Token = "0x400022B")]
			public const float NoiseScaleMin = 0.01f;

			[Token(Token = "0x400022C")]
			public const float NoiseScaleMax = 2f;

			[Token(Token = "0x400022D")]
			public const float NoiseScaleDefault = 0.5f;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly Vector3 NoiseVelocityDefault;

			[Token(Token = "0x400022F")]
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

			[Token(Token = "0x4000230")]
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

			[Token(Token = "0x4000231")]
			public const float FadeOutBeginDefault = -150f;

			[Token(Token = "0x4000232")]
			public const float FadeOutEndDefault = -200f;

			[Token(Token = "0x4000233")]
			public const Dimensions DimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly Vector2 TiltDefault;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly Vector3 SkewingLocalForwardDirectionDefault;

			[Token(Token = "0x4000236")]
			public const Transform ClippingPlaneTransformDefault = null;
		}

		[Token(Token = "0x200009A")]
		public static class DustParticles
		{
			[Token(Token = "0x4000237")]
			public const float AlphaDefault = 0.5f;

			[Token(Token = "0x4000238")]
			public const float SizeDefault = 0.01f;

			[Token(Token = "0x4000239")]
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Vector3 VelocityDefault;

			[Token(Token = "0x400023B")]
			public const float DensityDefault = 5f;

			[Token(Token = "0x400023C")]
			public const float DensityMin = 0f;

			[Token(Token = "0x400023D")]
			public const float DensityMax = 1000f;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault;

			[Token(Token = "0x400023F")]
			public const bool CullingEnabledDefault = false;

			[Token(Token = "0x4000240")]
			public const float CullingMaxDistanceDefault = 10f;

			[Token(Token = "0x4000241")]
			public const float CullingMaxDistanceMin = 1f;
		}

		[Token(Token = "0x200009B")]
		public static class DynOcclusion
		{
			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly LayerMask LayerMaskDefault;

			[Token(Token = "0x4000243")]
			public const float FadeDistanceToSurfaceDefault = 0.25f;

			[Token(Token = "0x4000244")]
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

			[Token(Token = "0x4000245")]
			public const int WaitFramesCountDefault = 3;

			[Token(Token = "0x4000246")]
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000247")]
			public const bool RaycastingConsiderTriggersDefault = false;

			[Token(Token = "0x4000248")]
			public const float RaycastingMinOccluderAreaDefault = 0f;

			[Token(Token = "0x4000249")]
			public const float RaycastingMinSurfaceRatioDefault = 0.5f;

			[Token(Token = "0x400024A")]
			public const float RaycastingMinSurfaceRatioMin = 50f;

			[Token(Token = "0x400024B")]
			public const float RaycastingMinSurfaceRatioMax = 100f;

			[Token(Token = "0x400024C")]
			public const float RaycastingMaxSurfaceDotDefault = 0.25f;

			[Token(Token = "0x400024D")]
			public const float RaycastingMaxSurfaceAngleMin = 45f;

			[Token(Token = "0x400024E")]
			public const float RaycastingMaxSurfaceAngleMax = 90f;

			[Token(Token = "0x400024F")]
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

			[Token(Token = "0x4000250")]
			public const float RaycastingPlaneOffsetDefault = 0.1f;

			[Token(Token = "0x4000251")]
			public const int DepthBufferDepthMapResolutionDefault = 32;

			[Token(Token = "0x4000252")]
			public const bool DepthBufferOcclusionCullingDefault = true;
		}

		[Token(Token = "0x200009C")]
		public static class Effects
		{
			[Token(Token = "0x4000253")]
			public const EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault = (EffectAbstractBase.ComponentsToChange)2147483647;

			[Token(Token = "0x4000254")]
			public const bool RestoreBaseIntensityDefault = true;

			[Token(Token = "0x4000255")]
			public const float FrequencyDefault = 10f;

			[Token(Token = "0x4000256")]
			public const bool PerformPausesDefault = false;

			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MinMaxRangeFloat FlickeringDurationDefault;

			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly MinMaxRangeFloat PauseDurationDefault;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly MinMaxRangeFloat IntensityAmplitudeDefault;

			[Token(Token = "0x400025A")]
			public const float SmoothingDefault = 0.05f;
		}

		[Token(Token = "0x200009D")]
		public static class Config
		{
			[Token(Token = "0x400025B")]
			public const bool GeometryOverrideLayerDefault = true;

			[Token(Token = "0x400025C")]
			public const int GeometryLayerIDDefault = 1;

			[Token(Token = "0x400025D")]
			public const string GeometryTagDefault = "Untagged";

			[Token(Token = "0x400025E")]
			public const string FadeOutCameraTagDefault = "MainCamera";

			[Token(Token = "0x400025F")]
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent;

			[Token(Token = "0x4000260")]
			public const RenderPipeline GeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

			[Token(Token = "0x4000261")]
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass;

			[Token(Token = "0x4000262")]
			public const int Noise3DSizeDefault = 64;

			[Token(Token = "0x4000263")]
			public const int SharedMeshSides = 24;

			[Token(Token = "0x4000264")]
			public const int SharedMeshSegments = 5;

			[Token(Token = "0x4000265")]
			public const float DitheringFactor = 0f;

			[Token(Token = "0x4000266")]
			public const bool UseLightColorTemperatureDefault = true;

			[Token(Token = "0x4000267")]
			public const bool FeatureEnabledDefault = true;

			[Token(Token = "0x4000268")]
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;
		}

		[Token(Token = "0x40001F6")]
		public const string PluginFolder = "Plugins/VolumetricLightBeam";
	}
	[Token(Token = "0x200009E")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB9E9AC", Offset = "0xB9E9AC")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9E9AC", Offset = "0xB9E9AC")]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x20000A0")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x4000273")]
			RenderLoop,
			[Token(Token = "0x4000274")]
			OnEnable,
			[Token(Token = "0x4000275")]
			EditorUpdate,
			[Token(Token = "0x4000276")]
			User
		}

		[Token(Token = "0x4000269")]
		public const string ClassName = "DynamicOcclusionAbstractBase";

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5134", Offset = "0xBA5134")]
		public int waitXFrames;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_LastFrameRendered;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		[Token(Token = "0x1700007E")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x22D9604", Offset = "0x22D9604", VA = "0x22D9604")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x22D94C4", Offset = "0x22D94C4", VA = "0x22D94C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7490", Offset = "0xBA7490")]
			add
			{
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x22D9564", Offset = "0x22D9564", VA = "0x22D9564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA74A0", Offset = "0xBA74A0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x22D9290", Offset = "0x22D9290", VA = "0x22D9290")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x22D9298", Offset = "0x22D9298", VA = "0x22D9298")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x600056E")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x600056F")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x6000570")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x6000571")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x6000572")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x22D960C", Offset = "0x22D960C", VA = "0x22D960C", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x22D9640", Offset = "0x22D9640", VA = "0x22D9640", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x22D96C0", Offset = "0x22D96C0", VA = "0x22D96C0", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x22D971C", Offset = "0x22D971C", VA = "0x22D971C", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x22D98D0", Offset = "0x22D98D0", VA = "0x22D98D0", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x22D996C", Offset = "0x22D996C", VA = "0x22D996C")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x22D96DC", Offset = "0x22D96DC", VA = "0x22D96DC")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x22D9AFC", Offset = "0x22D9AFC", VA = "0x22D9AFC")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x22D9B68", Offset = "0x22D9B68", VA = "0x22D9B68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA74B0", Offset = "0xBA74B0")]
		private void <OnEnable>b__24_0()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9EA40", Offset = "0xB9EA40")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9EA8C", Offset = "0xB9EA8C")]
		private sealed class <>c
		{
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Camera> <>9__15_0;

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x2595F10", Offset = "0x2595F10", VA = "0x2595F10")]
			public <>c()
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x2595F18", Offset = "0x2595F18", VA = "0x2595F18")]
			internal void <InstantiateOrActivateDepthCamera>b__15_0(Camera cam)
			{
			}
		}

		[Token(Token = "0x4000277")]
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LayerMask layerMask;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useOcclusionCulling;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int depthMapResolution;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Camera m_DepthCamera;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x22D9B70", Offset = "0x22D9B70", VA = "0x22D9B70", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x22D9BB4", Offset = "0x22D9BB4", VA = "0x22D9BB4", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x22D9BBC", Offset = "0x22D9BBC", VA = "0x22D9BBC")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x22D9E4C", Offset = "0x22D9E4C", VA = "0x22D9E4C", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x22D9EDC", Offset = "0x22D9EDC", VA = "0x22D9EDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x22D9BEC", Offset = "0x22D9BEC", VA = "0x22D9BEC")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x22D9F94", Offset = "0x22D9F94", VA = "0x22D9F94")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x22DA04C", Offset = "0x22DA04C", VA = "0x22DA04C", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x22DA0B8", Offset = "0x22DA0B8", VA = "0x22DA0B8")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x22DA4DC", Offset = "0x22DA4DC", VA = "0x22DA4DC", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x22DA4E0", Offset = "0x22DA4E0", VA = "0x22DA4E0", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x22DA584", Offset = "0x22DA584", VA = "0x22DA584", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x22DA588", Offset = "0x22DA588", VA = "0x22DA588", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x22DA5AC", Offset = "0x22DA5AC", VA = "0x22DA5AC")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x22DA72C", Offset = "0x22DA72C", VA = "0x22DA72C", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x22DA93C", Offset = "0x22DA93C", VA = "0x22DA93C")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9EA9C", Offset = "0xB9EA9C")]
	[ExecuteInEditMode]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x20000A4")]
		public struct HitResult
		{
			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 point;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 normal;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float distance;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Collider2D collider2D;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Collider collider3D;

			[Token(Token = "0x17000083")]
			public bool hasCollider
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0x2596098", Offset = "0x2596098", VA = "0x2596098")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000084")]
			public string name
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x2596148", Offset = "0x2596148", VA = "0x2596148")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			public Bounds bounds
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x259622C", Offset = "0x259622C", VA = "0x259622C")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x2595F98", Offset = "0x2595F98", VA = "0x2595F98")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x2596018", Offset = "0x2596018", VA = "0x2596018")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x2596328", Offset = "0x2596328", VA = "0x2596328")]
			public void SetNull()
			{
			}
		}

		[Token(Token = "0x20000A5")]
		private enum Direction
		{
			[Token(Token = "0x4000294")]
			Up = 0,
			[Token(Token = "0x4000295")]
			Down = 1,
			[Token(Token = "0x4000296")]
			Left = 2,
			[Token(Token = "0x4000297")]
			Right = 3,
			[Token(Token = "0x4000298")]
			Max2D = 1,
			[Token(Token = "0x4000299")]
			Max3D = 3
		}

		[Token(Token = "0x4000280")]
		public new const string ClassName = "DynamicOcclusionRaycasting";

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dimensions dimensions;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LayerMask layerMask;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool considerTriggers;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float minOccluderArea;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float maxSurfaceDot;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float planeOffset;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA517C", Offset = "0xBA517C")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HitResult m_CurrentHit;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float m_RangeMultiplier;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA51B4", Offset = "0xBA51B4")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700007F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA7CAC", Offset = "0xBA7CAC")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x22DAA04", Offset = "0x22DAA04", VA = "0x22DAA04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x22DAA0C", Offset = "0x22DAA0C", VA = "0x22DAA0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x22DAA60", Offset = "0x22DAA60", VA = "0x22DAA60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA74C0", Offset = "0xBA74C0")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x22DAA6C", Offset = "0x22DAA6C", VA = "0x22DAA6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA74D0", Offset = "0xBA74D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x22DACA0", Offset = "0x22DACA0", VA = "0x22DACA0")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000082")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x22DACB4", Offset = "0x22DACB4", VA = "0x22DACB4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x22D84B0", Offset = "0x22D84B0", VA = "0x22D84B0")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x22DAA14", Offset = "0x22DAA14", VA = "0x22DAA14", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x22DAA58", Offset = "0x22DAA58", VA = "0x22DAA58", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x22DAA78", Offset = "0x22DAA78", VA = "0x22DAA78", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x22DAAD8", Offset = "0x22DAAD8", VA = "0x22DAAD8", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x22DAAE4", Offset = "0x22DAAE4", VA = "0x22DAAE4", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x22DAB3C", Offset = "0x22DAB3C", VA = "0x22DAB3C")]
		private void Start()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x22DABF8", Offset = "0x22DABF8", VA = "0x22DABF8")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x22DAD0C", Offset = "0x22DAD0C", VA = "0x22DAD0C")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x22DAD5C", Offset = "0x22DAD5C", VA = "0x22DAD5C")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x22DB018", Offset = "0x22DB018", VA = "0x22DB018")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x22DB314", Offset = "0x22DB314", VA = "0x22DB314")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x22DB32C", Offset = "0x22DB32C", VA = "0x22DB32C")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x22DB3C4", Offset = "0x22DB3C4", VA = "0x22DB3C4")]
		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x22DB440", Offset = "0x22DB440", VA = "0x22DB440", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x22DB764", Offset = "0x22DB764", VA = "0x22DB764")]
		private void SetHit(ref HitResult hit)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x22DAB14", Offset = "0x22DAB14", VA = "0x22DAB14")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x22DB9A0", Offset = "0x22DB9A0", VA = "0x22DB9A0", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x22DB83C", Offset = "0x22DB83C", VA = "0x22DB83C")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x22DB958", Offset = "0x22DB958", VA = "0x22DB958")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x22DBBAC", Offset = "0x22DBBAC", VA = "0x22DBBAC")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x22DBBB8", Offset = "0x22DBBB8", VA = "0x22DBBB8")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB9EAE8", Offset = "0xB9EAE8")]
	public class EffectAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x20000A7")]
		[Flags]
		public enum ComponentsToChange
		{
			[Token(Token = "0x40002A4")]
			UnityLight = 1,
			[Token(Token = "0x40002A5")]
			VolumetricLightBeam = 2,
			[Token(Token = "0x40002A6")]
			VolumetricDustParticles = 4
		}

		[Token(Token = "0x400029A")]
		public const string ClassName = "EffectAbstractBase";

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComponentsToChange componentsToChange;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool restoreBaseIntensity;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected VolumetricLightBeam m_Beam;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Light m_Light;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected VolumetricDustParticles m_Particles;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float m_BaseIntensityBeamInside;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float m_BaseIntensityBeamOutside;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float m_BaseIntensityLight;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x258AA88", Offset = "0x258AA88", VA = "0x258AA88")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x258AD0C", Offset = "0x258AD0C", VA = "0x258AD0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x258AEC0", Offset = "0x258AEC0", VA = "0x258AEC0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x258AEC8", Offset = "0x258AEC8", VA = "0x258AEC8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x258AF08", Offset = "0x258AF08", VA = "0x258AF08")]
		public EffectAbstractBase()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9EB44", Offset = "0xB9EB44")]
	public class EffectFlicker : EffectAbstractBase
	{
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9EB7C", Offset = "0xB9EB7C")]
		private sealed class <CoUpdate>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remaining>5__2;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x3014C30", Offset = "0x3014C30", VA = "0x3014C30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x3014C78", Offset = "0x3014C78", VA = "0x3014C78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x3014B14", Offset = "0x3014B14", VA = "0x3014B14")]
			[DebuggerHidden]
			public <CoUpdate>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x3014B40", Offset = "0x3014B40", VA = "0x3014B40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x3014B44", Offset = "0x3014B44", VA = "0x3014B44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x3014C38", Offset = "0x3014C38", VA = "0x3014C38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9EB8C", Offset = "0xB9EB8C")]
		private sealed class <CoFlicker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remainingDuration>5__2;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <freqDuration>5__3;

			[Token(Token = "0x17000088")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x3014AC4", Offset = "0x3014AC4", VA = "0x3014AC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0x3014B0C", Offset = "0x3014B0C", VA = "0x3014B0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x30149B4", Offset = "0x30149B4", VA = "0x30149B4")]
			[DebuggerHidden]
			public <CoFlicker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x30149E0", Offset = "0x30149E0", VA = "0x30149E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x30149E4", Offset = "0x30149E4", VA = "0x30149E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x3014ACC", Offset = "0x3014ACC", VA = "0x3014ACC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9EB9C", Offset = "0xB9EB9C")]
		private sealed class <CoChangeIntensity>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float nextIntensity;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float expectedDuration;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <velocity>5__2;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <t>5__3;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x3014964", Offset = "0x3014964", VA = "0x3014964", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x30149AC", Offset = "0x30149AC", VA = "0x30149AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x3014870", Offset = "0x3014870", VA = "0x3014870")]
			[DebuggerHidden]
			public <CoChangeIntensity>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x301489C", Offset = "0x301489C", VA = "0x301489C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x30148A0", Offset = "0x30148A0", VA = "0x30148A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x301496C", Offset = "0x301496C", VA = "0x301496C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A7")]
		public new const string ClassName = "EffectFlicker";

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA51C4", Offset = "0xBA51C4")]
		public float frequency;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool performPauses;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA51E0", Offset = "0xBA51E0")]
		public MinMaxRangeFloat flickeringDuration;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA51F8", Offset = "0xBA51F8")]
		public MinMaxRangeFloat pauseDuration;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA5210", Offset = "0xBA5210")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA5228", Offset = "0xBA5228")]
		public float smoothing;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_CurrentAdditiveIntensity;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x258AF20", Offset = "0x258AF20", VA = "0x258AF20", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x258AF58", Offset = "0x258AF58", VA = "0x258AF58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA74E0", Offset = "0xBA74E0")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x258AFD0", Offset = "0x258AFD0", VA = "0x258AFD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA7540", Offset = "0xBA7540")]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x258B048", Offset = "0x258B048", VA = "0x258B048")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA75A0", Offset = "0xBA75A0")]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x258B0D4", Offset = "0x258B0D4", VA = "0x258B0D4")]
		public EffectFlicker()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9EBAC", Offset = "0xB9EBAC")]
	public class EffectPulse : EffectAbstractBase
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9EBE4", Offset = "0xB9EBE4")]
		private sealed class <CoUpdate>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectPulse <>4__this;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x3014D74", Offset = "0x3014D74", VA = "0x3014D74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x3014DBC", Offset = "0x3014DBC", VA = "0x3014DBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x3014C80", Offset = "0x3014C80", VA = "0x3014C80")]
			[DebuggerHidden]
			public <CoUpdate>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x3014CAC", Offset = "0x3014CAC", VA = "0x3014CAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x3014CB0", Offset = "0x3014CB0", VA = "0x3014CB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x3014D7C", Offset = "0x3014D7C", VA = "0x3014D7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BF")]
		public new const string ClassName = "EffectPulse";

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA5240", Offset = "0xBA5240")]
		public float frequency;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA5260", Offset = "0xBA5260")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x258B184", Offset = "0x258B184", VA = "0x258B184", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x258B1BC", Offset = "0x258B1BC", VA = "0x258B1BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA76F0", Offset = "0xBA76F0")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x258B234", Offset = "0x258B234", VA = "0x258B234")]
		public EffectPulse()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public enum FeatureEnabledColorGradient
	{
		[Token(Token = "0x40002C7")]
		Off,
		[Token(Token = "0x40002C8")]
		HighOnly,
		[Token(Token = "0x40002C9")]
		HighAndLow
	}
	[Token(Token = "0x20000AF")]
	public enum ColorMode
	{
		[Token(Token = "0x40002CB")]
		Flat,
		[Token(Token = "0x40002CC")]
		Gradient
	}
	[Token(Token = "0x20000B0")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40002CE")]
		Linear,
		[Token(Token = "0x40002CF")]
		Quadratic,
		[Token(Token = "0x40002D0")]
		Blend
	}
	[Token(Token = "0x20000B1")]
	public enum BlendingMode
	{
		[Token(Token = "0x40002D2")]
		Additive,
		[Token(Token = "0x40002D3")]
		SoftAdditive,
		[Token(Token = "0x40002D4")]
		TraditionalTransparency
	}
	[Token(Token = "0x20000B2")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x40002D6")]
		Fast,
		[Token(Token = "0x40002D7")]
		High
	}
	[Token(Token = "0x20000B3")]
	public enum NoiseMode
	{
		[Token(Token = "0x40002D9")]
		Disabled,
		[Token(Token = "0x40002DA")]
		WorldSpace,
		[Token(Token = "0x40002DB")]
		LocalSpace
	}
	[Token(Token = "0x20000B4")]
	public enum MeshType
	{
		[Token(Token = "0x40002DD")]
		Shared,
		[Token(Token = "0x40002DE")]
		Custom
	}
	[Token(Token = "0x20000B5")]
	public enum RenderPipeline
	{
		[Token(Token = "0x40002E0")]
		BuiltIn,
		[Token(Token = "0x40002E1")]
		URP,
		[Token(Token = "0x40002E2")]
		HDRP
	}
	[Token(Token = "0x20000B6")]
	public enum RenderingMode
	{
		[Token(Token = "0x40002E4")]
		MultiPass,
		[Token(Token = "0x40002E5")]
		SinglePass,
		[Token(Token = "0x40002E6")]
		GPUInstancing,
		[Token(Token = "0x40002E7")]
		SRPBatcher
	}
	[Token(Token = "0x20000B7")]
	public enum RenderQueue
	{
		[Token(Token = "0x40002E9")]
		Custom = 0,
		[Token(Token = "0x40002EA")]
		Background = 1000,
		[Token(Token = "0x40002EB")]
		Geometry = 2000,
		[Token(Token = "0x40002EC")]
		AlphaTest = 2450,
		[Token(Token = "0x40002ED")]
		GeometryLast = 2500,
		[Token(Token = "0x40002EE")]
		Transparent = 3000,
		[Token(Token = "0x40002EF")]
		Overlay = 4000
	}
	[Token(Token = "0x20000B8")]
	public enum Dimensions
	{
		[Token(Token = "0x40002F1")]
		Dim3D,
		[Token(Token = "0x40002F2")]
		Dim2D
	}
	[Token(Token = "0x20000B9")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40002F4")]
		Surface,
		[Token(Token = "0x40002F5")]
		Beam
	}
	[Token(Token = "0x20000BA")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x40002F7")]
		Never = 1,
		[Token(Token = "0x40002F8")]
		OnEnable = 2,
		[Token(Token = "0x40002F9")]
		OnBeamMove = 4,
		[Token(Token = "0x40002FA")]
		EveryXFrames = 8,
		[Token(Token = "0x40002FB")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x20000BB")]
	public enum ParticlesDirection
	{
		[Token(Token = "0x40002FD")]
		Random,
		[Token(Token = "0x40002FE")]
		LocalSpace,
		[Token(Token = "0x40002FF")]
		WorldSpace
	}
	[Token(Token = "0x20000BC")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x258BC68", Offset = "0x258BC68", VA = "0x258BC68")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x258BEA4", Offset = "0x258BEA4", VA = "0x258BEA4")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x258C838", Offset = "0x258C838", VA = "0x258C838")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public static class MaterialManager
	{
		[Token(Token = "0x20000BF")]
		public enum BlendingMode
		{
			[Token(Token = "0x4000309")]
			Additive,
			[Token(Token = "0x400030A")]
			SoftAdditive,
			[Token(Token = "0x400030B")]
			TraditionalTransparency,
			[Token(Token = "0x400030C")]
			Count
		}

		[Token(Token = "0x20000C0")]
		public enum Noise3D
		{
			[Token(Token = "0x400030E")]
			Off,
			[Token(Token = "0x400030F")]
			On,
			[Token(Token = "0x4000310")]
			Count
		}

		[Token(Token = "0x20000C1")]
		public enum DepthBlend
		{
			[Token(Token = "0x4000312")]
			Off,
			[Token(Token = "0x4000313")]
			On,
			[Token(Token = "0x4000314")]
			Count
		}

		[Token(Token = "0x20000C2")]
		public enum ColorGradient
		{
			[Token(Token = "0x4000316")]
			Off,
			[Token(Token = "0x4000317")]
			MatrixLow,
			[Token(Token = "0x4000318")]
			MatrixHigh,
			[Token(Token = "0x4000319")]
			Count
		}

		[Token(Token = "0x20000C3")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x400031B")]
			Off,
			[Token(Token = "0x400031C")]
			ClippingPlane,
			[Token(Token = "0x400031D")]
			DepthTexture,
			[Token(Token = "0x400031E")]
			Count
		}

		[Token(Token = "0x20000C4")]
		public enum MeshSkewing
		{
			[Token(Token = "0x4000320")]
			Off,
			[Token(Token = "0x4000321")]
			On,
			[Token(Token = "0x4000322")]
			Count
		}

		[Token(Token = "0x20000C5")]
		public enum ShaderAccuracy
		{
			[Token(Token = "0x4000324")]
			Fast,
			[Token(Token = "0x4000325")]
			High,
			[Token(Token = "0x4000326")]
			Count
		}

		[Token(Token = "0x20000C6")]
		public struct StaticProperties
		{
			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Noise3D noise3D;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DepthBlend depthBlend;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ColorGradient colorGradient;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MeshSkewing meshSkewing;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShaderAccuracy shaderAccuracy;

			[Token(Token = "0x1700008E")]
			private int blendingModeID
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x3014E2C", Offset = "0x3014E2C", VA = "0x3014E2C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700008F")]
			private int noise3DID
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x3014E34", Offset = "0x3014E34", VA = "0x3014E34")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000090")]
			private int depthBlendID
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x3014EB4", Offset = "0x3014EB4", VA = "0x3014EB4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000091")]
			private int colorGradientID
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x3014F34", Offset = "0x3014F34", VA = "0x3014F34")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000092")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x3014FB4", Offset = "0x3014FB4", VA = "0x3014FB4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000093")]
			private int meshSkewingID
			{
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0x3015034", Offset = "0x3015034", VA = "0x3015034")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000094")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0x30150B4", Offset = "0x30150B4", VA = "0x30150B4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000095")]
			public int materialID
			{
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0x3015134", Offset = "0x3015134", VA = "0x3015134")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x30151CC", Offset = "0x30151CC", VA = "0x30151CC")]
			public void ApplyToMaterial(Material mat)
			{
			}
		}

		[Token(Token = "0x20000C7")]
		private class MaterialsGroup
		{
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x3014DC4", Offset = "0x3014DC4", VA = "0x3014DC4")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000306")]
		public const int staticPropertiesCount = 432;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x258E2E4", Offset = "0x258E2E4", VA = "0x258E2E4")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x258E458", Offset = "0x258E458", VA = "0x258E458")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x258E564", Offset = "0x258E564", VA = "0x258E564")]
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C8")]
	public static class MaterialModifier
	{
		[Token(Token = "0x20000C9")]
		public interface Interface
		{
			[Token(Token = "0x60005E9")]
			void SetMaterialProp(int nameID, float value);

			[Token(Token = "0x60005EA")]
			void SetMaterialProp(int nameID, Vector4 value);

			[Token(Token = "0x60005EB")]
			void SetMaterialProp(int nameID, Color value);

			[Token(Token = "0x60005EC")]
			void SetMaterialProp(int nameID, Matrix4x4 value);

			[Token(Token = "0x60005ED")]
			void SetMaterialProp(int nameID, Texture value);
		}

		[Token(Token = "0x20000CA")]
		public delegate void Callback(Interface owner);
	}
	[Token(Token = "0x20000CB")]
	public static class MeshGenerator
	{
		[Token(Token = "0x400032F")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x258E9D0", Offset = "0x258E9D0", VA = "0x258E9D0")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x258E9E8", Offset = "0x258E9E8", VA = "0x258E9E8")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x258EA5C", Offset = "0x258EA5C", VA = "0x258EA5C")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x258BFC0", Offset = "0x258BFC0", VA = "0x258BFC0")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x258EACC", Offset = "0x258EACC", VA = "0x258EACC")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x258EB30", Offset = "0x258EB30", VA = "0x258EB30")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x258EB4C", Offset = "0x258EB4C", VA = "0x258EB4C")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x258EB74", Offset = "0x258EB74", VA = "0x258EB74")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x258EC18", Offset = "0x258EC18", VA = "0x258EC18")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000CC")]
	public struct MinMaxRangeFloat
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_MinValue;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float m_MaxValue;

		[Token(Token = "0x17000096")]
		public float minValue
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x258ED18", Offset = "0x258ED18", VA = "0x258ED18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000097")]
		public float maxValue
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x258ED20", Offset = "0x258ED20", VA = "0x258ED20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		public float randomValue
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x258ED28", Offset = "0x258ED28", VA = "0x258ED28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000099")]
		public Vector2 asVector2
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x258ED34", Offset = "0x258ED34", VA = "0x258ED34")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x258ED3C", Offset = "0x258ED3C", VA = "0x258ED3C")]
		public float GetLerpedValue(float lerp01)
		{
			return default(float);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x258ED54", Offset = "0x258ED54", VA = "0x258ED54")]
		public MinMaxRangeFloat(float min, float max)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class MinMaxRangeAttribute : Attribute
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5298", Offset = "0xBA5298")]
		private float <minValue>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA52A8", Offset = "0xBA52A8")]
		private float <maxValue>k__BackingField;

		[Token(Token = "0x1700009A")]
		public float minValue
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x258ECC0", Offset = "0x258ECC0", VA = "0x258ECC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA77A0", Offset = "0xBA77A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x258ECC8", Offset = "0x258ECC8", VA = "0x258ECC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA77B0", Offset = "0xBA77B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public float maxValue
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x258ECD0", Offset = "0x258ECD0", VA = "0x258ECD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA77C0", Offset = "0xBA77C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x258ECD8", Offset = "0x258ECD8", VA = "0x258ECD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA77D0", Offset = "0xBA77D0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x258ECE0", Offset = "0x258ECE0", VA = "0x258ECE0")]
		public MinMaxRangeAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public static class Noise3D
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000337")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700009C")]
		public static bool isSupported
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x258B470", Offset = "0x258B470", VA = "0x258B470")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x258ED5C", Offset = "0x258ED5C", VA = "0x258ED5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x258B5C8", Offset = "0x258B5C8", VA = "0x258B5C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x258EDFC", Offset = "0x258EDFC", VA = "0x258EDFC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xBA77E0", Offset = "0xBA77E0")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x258EE54", Offset = "0x258EE54", VA = "0x258EE54")]
		public static void LoadIfNeeded()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class PlatformHelper
	{
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x258F128", Offset = "0x258F128", VA = "0x258F128")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x258F140", Offset = "0x258F140", VA = "0x258F140")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x258F1C0", Offset = "0x258F1C0", VA = "0x258F1C0")]
		public PlatformHelper()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x20000D1")]
		public struct Plane2D
		{
			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x30158A8", Offset = "0x30158A8", VA = "0x30158A8")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x30158C4", Offset = "0x30158C4", VA = "0x30158C4")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x30158F0", Offset = "0x30158F0", VA = "0x30158F0")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x30159E8", Offset = "0x30159E8", VA = "0x30159E8")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x3015A0C", Offset = "0x3015A0C", VA = "0x3015A0C")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x3015A6C", Offset = "0x3015A6C", VA = "0x3015A6C")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x3015A7C", Offset = "0x3015A7C", VA = "0x3015A7C")]
			public void Flip()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x3015A98", Offset = "0x3015A98", VA = "0x3015A98")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x3015C84", Offset = "0x3015C84", VA = "0x3015C84", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x258F1C8", Offset = "0x258F1C8", VA = "0x258F1C8")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public static class SRPHelper
	{
		[Token(Token = "0x20000D3")]
		public enum RenderPipeline
		{
			[Token(Token = "0x400033C")]
			Undefined,
			[Token(Token = "0x400033D")]
			BuiltIn,
			[Token(Token = "0x400033E")]
			URP,
			[Token(Token = "0x400033F")]
			LWRP,
			[Token(Token = "0x4000340")]
			HDRP
		}

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RenderPipeline m_RenderPipelineCached;

		[Token(Token = "0x1700009F")]
		public static RenderPipeline renderPipelineType
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x258F2D8", Offset = "0x258F2D8", VA = "0x258F2D8")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x258F388", Offset = "0x258F388", VA = "0x258F388")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x258F4BC", Offset = "0x258F4BC", VA = "0x258F4BC")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x258F5B4", Offset = "0x258F5B4", VA = "0x258F5B4")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x258F664", Offset = "0x258F664", VA = "0x258F664")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x4000341")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		[Token(Token = "0x4000342")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		[Token(Token = "0x4000343")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		[Token(Token = "0x4000344")]
		public const string DepthBlend = "VLB_DEPTH_BLEND";

		[Token(Token = "0x4000345")]
		public const string Noise3D = "VLB_NOISE_3D";

		[Token(Token = "0x4000346")]
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

		[Token(Token = "0x4000347")]
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

		[Token(Token = "0x4000348")]
		public const string MeshSkewing = "VLB_MESH_SKEWING";

		[Token(Token = "0x4000349")]
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
	}
	[Token(Token = "0x20000D5")]
	public static class ShaderProperties
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int HDRPExposureWeight;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int DistanceFallOff;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int FresnelPow;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int GlareBehind;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int DrawCap;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int NoiseVelocityAndScale;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int NoiseParam;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int CameraParams;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int LocalForwardDirection;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static readonly int TiltVector;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly int AdditionalClippingPlaneWS;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static readonly int ParticlesTintColor;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly int GlobalUsesReversedZBuffer;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly int GlobalNoiseCustomTime;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly int GlobalDitheringNoiseTex;
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9EC04", Offset = "0xB9EC04")]
	[ExecuteInEditMode]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9EC50", Offset = "0xB9EC50")]
		private sealed class <CoUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewingHandle <>4__this;

			[Token(Token = "0x170000A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x3015DF4", Offset = "0x3015DF4", VA = "0x3015DF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x3015E3C", Offset = "0x3015E3C", VA = "0x3015E3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x3015D4C", Offset = "0x3015D4C", VA = "0x3015D4C")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x3015D78", Offset = "0x3015D78", VA = "0x3015D78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x3015D7C", Offset = "0x3015D7C", VA = "0x3015D7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x3015DFC", Offset = "0x3015DFC", VA = "0x3015DFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VolumetricLightBeam volumetricLightBeam;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shouldUpdateEachFrame;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x258FDA8", Offset = "0x258FDA8", VA = "0x258FDA8")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x258FE88", Offset = "0x258FE88", VA = "0x258FE88")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x258FF2C", Offset = "0x258FF2C", VA = "0x258FF2C")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x258FF70", Offset = "0x258FF70", VA = "0x258FF70")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x258FF84", Offset = "0x258FF84", VA = "0x258FF84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2590024", Offset = "0x2590024", VA = "0x2590024")]
		private void Start()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2590080", Offset = "0x2590080", VA = "0x2590080")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA77F0", Offset = "0xBA77F0")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x258FFB8", Offset = "0x258FFB8", VA = "0x258FFB8")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x25900F8", Offset = "0x25900F8", VA = "0x25900F8")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public static class SpotLightHelper
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x2590100", Offset = "0x2590100", VA = "0x2590100")]
		public static float GetIntensity(Light light)
		{
			return default(float);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x2590190", Offset = "0x2590190", VA = "0x2590190")]
		public static float GetSpotAngle(Light light)
		{
			return default(float);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x2590220", Offset = "0x2590220", VA = "0x2590220")]
		public static float GetFallOffEnd(Light light)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000D9")]
	public static class TransformUtils
	{
		[Token(Token = "0x20000DA")]
		public struct Packed
		{
			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lossyScale;

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x3015E44", Offset = "0x3015E44", VA = "0x3015E44")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x25902B0", Offset = "0x25902B0", VA = "0x25902B0")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
	[Token(Token = "0x20000DB")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9EC70", Offset = "0xB9EC70")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9EC70", Offset = "0xB9EC70")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x20000DC")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x400037F")]
			OnEnable,
			[Token(Token = "0x4000380")]
			OnOcclusionChange
		}

		[Token(Token = "0x4000377")]
		public const string ClassName = "TriggerZone";

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x400037A")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x170000A2")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x2590348", Offset = "0x2590348", VA = "0x2590348")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x25903D8", Offset = "0x25903D8", VA = "0x25903D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x2590B54", Offset = "0x2590B54", VA = "0x2590B54")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2590558", Offset = "0x2590558", VA = "0x2590558")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2590D60", Offset = "0x2590D60", VA = "0x2590D60")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public static class Utils
	{
		[Token(Token = "0x20000DE")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000385")]
			High = 64,
			[Token(Token = "0x4000386")]
			Low = 8,
			[Token(Token = "0x4000387")]
			Undef = 0
		}

		[Token(Token = "0x4000381")]
		private const float kEpsilon = 1E-05f;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000383")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x2590EC4", Offset = "0x2590EC4", VA = "0x2590EC4")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x2590EFC", Offset = "0x2590EFC", VA = "0x2590EFC")]
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			return default(float);
		}

		[Token(Token = "0x600063B")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x2590F2C", Offset = "0x2590F2C", VA = "0x2590F2C")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600063F")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		public static void ForeachComponentsOnlyInChildren<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2591064", Offset = "0x2591064", VA = "0x2591064")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2591144", Offset = "0x2591144", VA = "0x2591144")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2591148", Offset = "0x2591148", VA = "0x2591148")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2591150", Offset = "0x2591150", VA = "0x2591150")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x259115C", Offset = "0x259115C", VA = "0x259115C")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x259116C", Offset = "0x259116C", VA = "0x259116C")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2591178", Offset = "0x2591178", VA = "0x2591178")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2591180", Offset = "0x2591180", VA = "0x2591180")]
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2591190", Offset = "0x2591190", VA = "0x2591190")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x25911C4", Offset = "0x25911C4", VA = "0x25911C4")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x25911F0", Offset = "0x25911F0", VA = "0x25911F0")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x259124C", Offset = "0x259124C", VA = "0x259124C")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x259127C", Offset = "0x259127C", VA = "0x259127C")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2591328", Offset = "0x2591328", VA = "0x2591328")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x259137C", Offset = "0x259137C", VA = "0x259137C")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x259141C", Offset = "0x259141C", VA = "0x259141C")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2591450", Offset = "0x2591450", VA = "0x2591450")]
		public static Color ComputeComplementaryColor(this Color self, bool blackAndWhite)
		{
			return default(Color);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x25914F8", Offset = "0x25914F8", VA = "0x25914F8")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2590CE4", Offset = "0x2590CE4", VA = "0x2590CE4")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2590CCC", Offset = "0x2590CCC", VA = "0x2590CCC")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2590C80", Offset = "0x2590C80", VA = "0x2590C80")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x25915A0", Offset = "0x25915A0", VA = "0x25915A0")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x25915C4", Offset = "0x25915C4", VA = "0x25915C4")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x25915D8", Offset = "0x25915D8", VA = "0x25915D8")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x25917F4", Offset = "0x25917F4", VA = "0x25917F4")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x25918D8", Offset = "0x25918D8", VA = "0x25918D8")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x25916FC", Offset = "0x25916FC", VA = "0x25916FC")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2591918", Offset = "0x2591918", VA = "0x2591918")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x25919E4", Offset = "0x25919E4", VA = "0x25919E4")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x25919E8", Offset = "0x25919E8", VA = "0x25919E8")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public static class Version
	{
		[Token(Token = "0x4000388")]
		public const int Current = 1981;
	}
	[Token(Token = "0x20000E0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9ED14", Offset = "0xB9ED14")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9ED14", Offset = "0xB9ED14")]
	[DisallowMultipleComponent]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9EDB8", Offset = "0xB9EDB8")]
		private sealed class <>c
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<ParticleSystem> <>9__37_0;

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x3015F38", Offset = "0x3015F38", VA = "0x3015F38")]
			public <>c()
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x3015F40", Offset = "0x3015F40", VA = "0x3015F40")]
			internal void <InstantiateParticleSystem>b__37_0(ParticleSystem ps)
			{
			}
		}

		[Token(Token = "0x4000389")]
		public const string ClassName = "VolumetricDustParticles";

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA52B8", Offset = "0xBA52B8")]
		public float alpha;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA52D0", Offset = "0xBA52D0")]
		public float size;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA52F0", Offset = "0xBA52F0")]
		public float speed;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA5328", Offset = "0xBA5328")]
		public MinMaxRangeFloat spawnDistanceRange;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA5340", Offset = "0xBA5340")]
		public float spawnMinDistance;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA5378", Offset = "0xBA5378")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool cullingEnabled;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA53B0", Offset = "0xBA53B0")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_AlphaAdditionalRuntime;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_Material;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Gradient m_GradientCached;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_RuntimePropertiesDirty;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x170000A3")]
		public bool isCulled
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x25919F0", Offset = "0x25919F0", VA = "0x25919F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7A50", Offset = "0xBA7A50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x25919F8", Offset = "0x25919F8", VA = "0x25919F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7A60", Offset = "0xBA7A60")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x2591A04", Offset = "0x2591A04", VA = "0x2591A04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x258ACF0", Offset = "0x258ACF0", VA = "0x258ACF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x2591A0C", Offset = "0x2591A0C", VA = "0x2591A0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x2591A74", Offset = "0x2591A74", VA = "0x2591A74")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x2591B04", Offset = "0x2591B04", VA = "0x2591B04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A8")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x2591BAC", Offset = "0x2591BAC", VA = "0x2591BAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x2591E3C", Offset = "0x2591E3C", VA = "0x2591E3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2591F94", Offset = "0x2591F94", VA = "0x2591F94")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x259234C", Offset = "0x259234C", VA = "0x259234C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2592374", Offset = "0x2592374", VA = "0x2592374")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x25922BC", Offset = "0x25922BC", VA = "0x25922BC")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x2592420", Offset = "0x2592420", VA = "0x2592420")]
		private void Play()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x2592B6C", Offset = "0x2592B6C", VA = "0x2592B6C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2592B74", Offset = "0x2592B74", VA = "0x2592B74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2592CB0", Offset = "0x2592CB0", VA = "0x2592CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x25924CC", Offset = "0x25924CC", VA = "0x25924CC")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x2591ED4", Offset = "0x2591ED4", VA = "0x2591ED4")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x2592DDC", Offset = "0x2592DDC", VA = "0x2592DDC")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x2593274", Offset = "0x2593274", VA = "0x2593274")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[ExecuteInEditMode]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9EDC8", Offset = "0xB9EDC8")]
	[DisallowMultipleComponent]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x20000E4")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x20000E5")]
		public enum AttachedLightType
		{
			[Token(Token = "0x40003DA")]
			NoLight,
			[Token(Token = "0x40003DB")]
			OtherLight,
			[Token(Token = "0x40003DC")]
			SpotLight
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9EE34", Offset = "0xB9EE34")]
		private sealed class <CoPlaytimeUpdate>d__209 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x170000E1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0x3016084", Offset = "0x3016084", VA = "0x3016084", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x30160CC", Offset = "0x30160CC", VA = "0x30160CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x3015FC0", Offset = "0x3015FC0", VA = "0x3015FC0")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__209(int <>1__state)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x3015FEC", Offset = "0x3015FEC", VA = "0x3015FEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x3015FF0", Offset = "0x3015FF0", VA = "0x3015FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x301608C", Offset = "0x301608C", VA = "0x301608C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A1")]
		public const string ClassName = "VolumetricLightBeam";

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xBA53D0", Offset = "0xBA53D0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA53D0", Offset = "0xBA53D0")]
		public Color color;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5424", Offset = "0xBA5424")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA5424", Offset = "0xBA5424")]
		public float intensityInside;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA5474", Offset = "0xBA5474")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5474", Offset = "0xBA5474")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5474", Offset = "0xBA5474")]
		public float intensityOutside;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA54E8", Offset = "0xBA54E8")]
		public float intensityMultiplier;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA54FC", Offset = "0xBA54FC")]
		public float hdrpExposureWeight;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5514", Offset = "0xBA5514")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA554C", Offset = "0xBA554C")]
		public float spotAngle;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA556C", Offset = "0xBA556C")]
		public float spotAngleMultiplier;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5580", Offset = "0xBA5580")]
		public float coneRadiusStart;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public MeshType geomMeshType;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA55B8", Offset = "0xBA55B8")]
		public int geomCustomSides;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int geomCustomSegments;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 skewingLocalForwardDirection;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform clippingPlaneTransform;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool geomCap;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA55F0", Offset = "0xBA55F0")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5608", Offset = "0xBA5608")]
		public float fallOffStart;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5640", Offset = "0xBA5640")]
		public float fallOffEnd;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5678", Offset = "0xBA5678")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA56B0", Offset = "0xBA56B0")]
		public float fallOffEndMultiplier;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float depthBlendDistance;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float cameraClippingDistance;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA56C4", Offset = "0xBA56C4")]
		public float glareFrontal;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA56DC", Offset = "0xBA56DC")]
		public float glareBehind;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA56F4", Offset = "0xBA56F4")]
		public float fresnelPow;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA572C", Offset = "0xBA572C")]
		public float noiseIntensity;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA5744", Offset = "0xBA5744")]
		public float noiseScaleLocal;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Dimensions dimensions;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Vector2 tiltFactor;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private MaterialManager.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5780", Offset = "0xBA5780")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA57EC", Offset = "0xBA57EC")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA5838", Offset = "0xBA5838")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA5884", Offset = "0xBA5884")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Light m_CachedLightSpot;

		[Token(Token = "0x170000A9")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x2592FD0", Offset = "0x2592FD0", VA = "0x2592FD0")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x170000AA")]
		private bool useColorFromAttachedLightSpot
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x2593374", Offset = "0x2593374", VA = "0x2593374")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		private bool useColorTemperatureFromAttachedLightSpot
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x25933F8", Offset = "0x25933F8", VA = "0x25933F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA7CE4", Offset = "0xBA7CE4")]
		public float alphaInside
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x2593498", Offset = "0x2593498", VA = "0x2593498")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x25934A0", Offset = "0x25934A0", VA = "0x25934A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA7D1C", Offset = "0xBA7D1C")]
		public float alphaOutside
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x25934A8", Offset = "0x25934A8", VA = "0x25934A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x25934B0", Offset = "0x25934B0", VA = "0x25934B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x25934B8", Offset = "0x25934B8", VA = "0x25934B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x25934C0", Offset = "0x25934C0", VA = "0x25934C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool useIntensityFromAttachedLightSpot
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x25934C8", Offset = "0x25934C8", VA = "0x25934C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		public bool useSpotAngleFromAttachedLightSpot
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x2593578", Offset = "0x2593578", VA = "0x2593578")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public float coneAngle
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x2593050", Offset = "0x2593050", VA = "0x2593050")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B2")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x2590B58", Offset = "0x2590B58", VA = "0x2590B58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x2593630", Offset = "0x2593630", VA = "0x2593630")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public float coneVolume
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x25936D4", Offset = "0x25936D4", VA = "0x25936D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B4")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x2593728", Offset = "0x2593728", VA = "0x2593728")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B5")]
		public Vector3 coneApexPositionLocal
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x25937A0", Offset = "0x25937A0", VA = "0x25937A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B6")]
		public Vector3 coneApexPositionGlobal
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x25937C0", Offset = "0x25937C0", VA = "0x25937C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B7")]
		public int geomSides
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x2590BF8", Offset = "0x2590BF8", VA = "0x2590BF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x259383C", Offset = "0x259383C", VA = "0x259383C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public int geomSegments
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x25938C4", Offset = "0x25938C4", VA = "0x25938C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x259394C", Offset = "0x259394C", VA = "0x259394C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x25939D4", Offset = "0x25939D4", VA = "0x25939D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BA")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x258FF1C", Offset = "0x258FF1C", VA = "0x258FF1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x2593B04", Offset = "0x2593B04", VA = "0x2593B04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BC")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x2593BE0", Offset = "0x2593BE0", VA = "0x2593BE0")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170000BD")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x2593D08", Offset = "0x2593D08", VA = "0x2593D08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA7D54", Offset = "0xBA7D54")]
		public float fadeStart
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x2593D30", Offset = "0x2593D30", VA = "0x2593D30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x2593D38", Offset = "0x2593D38", VA = "0x2593D38")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA7D8C", Offset = "0xBA7D8C")]
		public float fadeEnd
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x2593D40", Offset = "0x2593D40", VA = "0x2593D40")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x2593D48", Offset = "0x2593D48", VA = "0x2593D48")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA7DC4", Offset = "0xBA7DC4")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x2593D50", Offset = "0x2593D50", VA = "0x2593D50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x2593D58", Offset = "0x2593D58", VA = "0x2593D58")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public bool useFallOffEndFromAttachedLightSpot
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x2593D64", Offset = "0x2593D64", VA = "0x2593D64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x25935FC", Offset = "0x25935FC", VA = "0x25935FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C3")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x2593DE8", Offset = "0x2593DE8", VA = "0x2593DE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA7DFC", Offset = "0xBA7DFC")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x2593DF8", Offset = "0x2593DF8", VA = "0x2593DF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x2593E08", Offset = "0x2593E08", VA = "0x2593E08")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public float fadeOutBegin
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x2593E24", Offset = "0x2593E24", VA = "0x2593E24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x2593E2C", Offset = "0x2593E2C", VA = "0x2593E2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public float fadeOutEnd
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x2593E88", Offset = "0x2593E88", VA = "0x2593E88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x2593E90", Offset = "0x2593E90", VA = "0x2593E90")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x25930BC", Offset = "0x25930BC", VA = "0x25930BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C8")]
		public bool isTilted
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x2593E98", Offset = "0x2593E98", VA = "0x2593E98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		public int sortingLayerID
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x2593F38", Offset = "0x2593F38", VA = "0x2593F38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x2593F40", Offset = "0x2593F40", VA = "0x2593F40")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public string sortingLayerName
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x2593FE4", Offset = "0x2593FE4", VA = "0x2593FE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x2593FF0", Offset = "0x2593FF0", VA = "0x2593FF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public int sortingOrder
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x2594020", Offset = "0x2594020", VA = "0x2594020")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x2594028", Offset = "0x2594028", VA = "0x2594028")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x25940CC", Offset = "0x25940CC", VA = "0x25940CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x25940D4", Offset = "0x25940D4", VA = "0x25940D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x259414C", Offset = "0x259414C", VA = "0x259414C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public bool hasGeometry
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x25930E0", Offset = "0x25930E0", VA = "0x25930E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public Bounds bounds
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x259314C", Offset = "0x259314C", VA = "0x259314C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000D0")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x259415C", Offset = "0x259415C", VA = "0x259415C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D1")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x25922E4", Offset = "0x25922E4", VA = "0x25922E4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000D2")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x2594240", Offset = "0x2594240", VA = "0x2594240")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D3")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x2594258", Offset = "0x2594258", VA = "0x2594258")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D4")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x25942C8", Offset = "0x25942C8", VA = "0x25942C8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D5")]
		public float raycastDistance
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x2594360", Offset = "0x2594360", VA = "0x2594360")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D6")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x25943F0", Offset = "0x25943F0", VA = "0x25943F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D7")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x2594498", Offset = "0x2594498", VA = "0x2594498")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D8")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x2594514", Offset = "0x2594514", VA = "0x2594514")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D9")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x2594590", Offset = "0x2594590", VA = "0x2594590")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x2594610", Offset = "0x2594610", VA = "0x2594610")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x2594618", Offset = "0x2594618", VA = "0x2594618")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x170000DB")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x2594960", Offset = "0x2594960", VA = "0x2594960")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DC")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x2594A0C", Offset = "0x2594A0C", VA = "0x2594A0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7A90", Offset = "0xBA7A90")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x2594A14", Offset = "0x2594A14", VA = "0x2594A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7AA0", Offset = "0xBA7AA0")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public string meshStats
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x2594A1C", Offset = "0x2594A1C", VA = "0x2594A1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x2594BD0", Offset = "0x2594BD0", VA = "0x2594BD0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DF")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x2594CA8", Offset = "0x2594CA8", VA = "0x2594CA8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public Light lightSpotAttached
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x2594EA4", Offset = "0x2594EA4", VA = "0x2594EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x25946E0", Offset = "0x25946E0", VA = "0x25946E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7A70", Offset = "0xBA7A70")]
			add
			{
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x2594780", Offset = "0x2594780", VA = "0x2594780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA7A80", Offset = "0xBA7A80")]
			remove
			{
			}
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x259354C", Offset = "0x259354C", VA = "0x259354C")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x259462C", Offset = "0x259462C", VA = "0x259462C")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2594820", Offset = "0x2594820", VA = "0x2594820")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2594834", Offset = "0x2594834", VA = "0x2594834")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x259491C", Offset = "0x259491C", VA = "0x259491C")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2593E34", Offset = "0x2593E34", VA = "0x2593E34")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2594968", Offset = "0x2594968", VA = "0x2594968")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2594D98", Offset = "0x2594D98", VA = "0x2594D98")]
		public Light GetLightSpotAttachedSlow(out AttachedLightType lightType)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2594E6C", Offset = "0x2594E6C", VA = "0x2594E6C")]
		private void InitLightSpotAttachedCached()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x2594EAC", Offset = "0x2594EAC", VA = "0x2594EAC")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x2594F0C", Offset = "0x2594F0C", VA = "0x2594F0C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x2595084", Offset = "0x2595084", VA = "0x2595084")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA7AB0", Offset = "0xBA7AB0")]
		public void Generate()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x2595090", Offset = "0x2595090", VA = "0x2595090", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x259531C", Offset = "0x259531C", VA = "0x259531C", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x25953B8", Offset = "0x25953B8", VA = "0x25953B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x25953FC", Offset = "0x25953FC", VA = "0x25953FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2595488", Offset = "0x2595488", VA = "0x2595488")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x25940E0", Offset = "0x25940E0", VA = "0x25940E0")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x259551C", Offset = "0x259551C", VA = "0x259551C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA7AE8", Offset = "0xBA7AE8")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2595594", Offset = "0x2595594", VA = "0x2595594")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x2595598", Offset = "0x2595598", VA = "0x2595598")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2595660", Offset = "0x2595660", VA = "0x2595660")]
		private void AssignPropertiesFromAttachedSpotLight()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x259580C", Offset = "0x259580C", VA = "0x259580C")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x25952F8", Offset = "0x25952F8", VA = "0x25952F8")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x25951F8", Offset = "0x25951F8", VA = "0x25951F8")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x2595A08", Offset = "0x2595A08", VA = "0x2595A08")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9EE44", Offset = "0xB9EE44")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x22D811C", Offset = "0x22D811C", VA = "0x22D811C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x22D8218", Offset = "0x22D8218", VA = "0x22D8218")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9EEA4", Offset = "0xB9EEA4")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x22D8228", Offset = "0x22D8228", VA = "0x22D8228")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x22D8318", Offset = "0x22D8318", VA = "0x22D8318")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x22D83DC", Offset = "0x22D83DC", VA = "0x22D83DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x22D83E4", Offset = "0x22D83E4", VA = "0x22D83E4")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x22D85E0", Offset = "0x22D85E0", VA = "0x22D85E0")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x258B3AC", Offset = "0x258B3AC", VA = "0x258B3AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x258B670", Offset = "0x258B670", VA = "0x258B670")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x170000E3")]
		private bool useMouseView
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x258B678", Offset = "0x258B678", VA = "0x258B678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x258B680", Offset = "0x258B680", VA = "0x258B680")]
			set
			{
			}
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x258B6BC", Offset = "0x258B6BC", VA = "0x258B6BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x258B754", Offset = "0x258B754", VA = "0x258B754")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x258BC44", Offset = "0x258BC44", VA = "0x258BC44")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA58A4", Offset = "0xBA58A4")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA58E8", Offset = "0xBA58E8")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x258C840", Offset = "0x258C840", VA = "0x258C840")]
		public void Generate()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x258CF54", Offset = "0x258CF54", VA = "0x258CF54")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA596C", Offset = "0xBA596C")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x258F1D0", Offset = "0x258F1D0", VA = "0x258F1D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x258F2A4", Offset = "0x258F2A4", VA = "0x258F2A4")]
		public Rotater()
		{
		}
	}
}
namespace ES3Types
{
	[Token(Token = "0x20000ED")]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2F9DC98", Offset = "0x2F9DC98", VA = "0x2F9DC98")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2F9DD64", Offset = "0x2F9DD64", VA = "0x2F9DD64", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000701")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EE")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x2F9DD6C", Offset = "0x2F9DD6C", VA = "0x2F9DD6C")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2F9DE38", Offset = "0x2F9DE38", VA = "0x2F9DE38", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000705")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EF")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x253C0A8", Offset = "0x253C0A8", VA = "0x253C0A8")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x253C1C4", Offset = "0x253C1C4", VA = "0x253C1C4", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x6000709")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x253C420", Offset = "0x253C420", VA = "0x253C420", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F0")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x253C6A0", Offset = "0x253C6A0", VA = "0x253C6A0")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x253C6A4", Offset = "0x253C6A4", VA = "0x253C6A4", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600070D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x253C9A8", Offset = "0x253C9A8", VA = "0x253C9A8", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F1")]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x253CCFC", Offset = "0x253CCFC", VA = "0x253CCFC")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x253CD00", Offset = "0x253CD00", VA = "0x253CD00")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x253CD78", Offset = "0x253CD78", VA = "0x253CD78", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000712")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x253CF2C", Offset = "0x253CF2C", VA = "0x253CF2C", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x253D26C", Offset = "0x253D26C", VA = "0x253D26C", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Type elementType;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x6000716")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x253C0AC", Offset = "0x253C0AC", VA = "0x253C0AC")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x253CD3C", Offset = "0x253CD3C", VA = "0x253CD3C")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2540AD0", Offset = "0x2540AD0", VA = "0x2540AD0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600071A")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x600071B")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2540AE0", Offset = "0x2540AE0", VA = "0x2540AE0", Slot = "10")]
		public virtual object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2540DC4", Offset = "0x2540DC4", VA = "0x2540DC4", Slot = "11")]
		public virtual void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Type keyType;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type valueType;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2541B30", Offset = "0x2541B30", VA = "0x2541B30")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2541C6C", Offset = "0x2541C6C", VA = "0x2541C6C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2541C90", Offset = "0x2541C90", VA = "0x2541C90")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000721")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000723")]
		public Dictionary<TKey, TVal> ReadKVP<TKey, TVal>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		public void ReadKVP<TKey, TVal>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x254211C", Offset = "0x254211C", VA = "0x254211C")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x25424F0", Offset = "0x25424F0", VA = "0x25424F0")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x25443EC", Offset = "0x25443EC", VA = "0x25443EC")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x25443F0", Offset = "0x25443F0", VA = "0x25443F0", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000729")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600072A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x25481F8", Offset = "0x25481F8", VA = "0x25481F8")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x25481FC", Offset = "0x25481FC", VA = "0x25481FC", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600072D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2548650", Offset = "0x2548650", VA = "0x2548650", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2548838", Offset = "0x2548838", VA = "0x2548838", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2549F80", Offset = "0x2549F80", VA = "0x2549F80")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2549F84", Offset = "0x2549F84", VA = "0x2549F84", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000733")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000734")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x254A3BC", Offset = "0x254A3BC", VA = "0x254A3BC", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x254A91C", Offset = "0x254A91C", VA = "0x254A91C", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x25504F0", Offset = "0x25504F0", VA = "0x25504F0")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x25504F4", Offset = "0x25504F4", VA = "0x25504F4", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000739")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x255092C", Offset = "0x255092C", VA = "0x255092C", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2550C24", Offset = "0x2550C24", VA = "0x2550C24", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public abstract class ES3ComponentType : ES3ObjectType
	{
		[Token(Token = "0x40003FC")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x25410B0", Offset = "0x25410B0", VA = "0x25410B0")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x600073E")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x600073F")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x25410B8", Offset = "0x25410B8", VA = "0x25410B8", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000741")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000742")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x2541604", Offset = "0x2541604", VA = "0x2541604")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x254184C", Offset = "0x254184C", VA = "0x254184C")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x2541790", Offset = "0x2541790", VA = "0x2541790")]
		public static Component GetOrCreateComponentIfNotExists(GameObject go, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F9")]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x25410B4", Offset = "0x25410B4", VA = "0x25410B4")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x6000747")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000748")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x6000749")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2548EA8", Offset = "0x2548EA8", VA = "0x2548EA8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600074B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public abstract class ES3ScriptableObjectType : ES3ObjectType
	{
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x254C938", Offset = "0x254C938", VA = "0x254C938")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x600074E")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x600074F")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x254EE70", Offset = "0x254EE70", VA = "0x254EE70", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000751")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000752")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9EF5C", Offset = "0xB9EF5C")]
	public abstract class ES3Type
	{
		[Token(Token = "0x40003FD")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isUnityObject;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isReflectedType;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x254C9E8", Offset = "0x254C9E8", VA = "0x254C9E8")]
		protected ES3Type()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x25407A4", Offset = "0x25407A4", VA = "0x25407A4")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x6000755")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x6000756")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x6000757")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x2548F00", Offset = "0x2548F00", VA = "0x2548F00")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x255117C", Offset = "0x255117C", VA = "0x255117C")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x254C758", Offset = "0x254C758", VA = "0x254C758")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x25511D8", Offset = "0x25511D8", VA = "0x25511D8")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x254C748", Offset = "0x254C748", VA = "0x254C748")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x254CAC0", Offset = "0x254CAC0", VA = "0x254CAC0")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB9EF70", Offset = "0xB9EF70")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x2549F4C", Offset = "0x2549F4C", VA = "0x2549F4C")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x258224C", Offset = "0x258224C", VA = "0x258224C")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x6000761")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000762")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000763")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x25879F4", Offset = "0x25879F4", VA = "0x25879F4", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x25879FC", Offset = "0x25879FC", VA = "0x25879FC")]
		public void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x6000766")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000767")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FE")]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2F9D994", Offset = "0x2F9D994", VA = "0x2F9D994")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2F9DA60", Offset = "0x2F9DA60", VA = "0x2F9DA60", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600076A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FF")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2F9DB9C", Offset = "0x2F9DB9C", VA = "0x2F9DB9C")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x25840F4", Offset = "0x25840F4", VA = "0x25840F4")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x25841C8", Offset = "0x25841C8", VA = "0x25841C8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600076F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000101")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2584260", Offset = "0x2584260", VA = "0x2584260")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x25857B4", Offset = "0x25857B4", VA = "0x25857B4")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2585888", Offset = "0x2585888", VA = "0x2585888", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000774")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000103")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2585920", Offset = "0x2585920", VA = "0x2585920")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2585A1C", Offset = "0x2585A1C", VA = "0x2585A1C")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2585AF0", Offset = "0x2585AF0", VA = "0x2585AF0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000779")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000105")]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2585B88", Offset = "0x2585B88", VA = "0x2585B88")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2585C5C", Offset = "0x2585C5C", VA = "0x2585C5C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600077D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000106")]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2585CF4", Offset = "0x2585CF4", VA = "0x2585CF4")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2585DC8", Offset = "0x2585DC8", VA = "0x2585DC8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000781")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000107")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2585E60", Offset = "0x2585E60", VA = "0x2585E60")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x2585F5C", Offset = "0x2585F5C", VA = "0x2585F5C")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2586030", Offset = "0x2586030", VA = "0x2586030", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000786")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000109")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x25860C8", Offset = "0x25860C8", VA = "0x25860C8")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x25861C4", Offset = "0x25861C4", VA = "0x25861C4")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2586298", Offset = "0x2586298", VA = "0x2586298", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600078B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010B")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2586330", Offset = "0x2586330", VA = "0x2586330")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x258642C", Offset = "0x258642C", VA = "0x258642C")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x25864BC", Offset = "0x25864BC", VA = "0x25864BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000790")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010D")]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2586554", Offset = "0x2586554", VA = "0x2586554")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2586628", Offset = "0x2586628", VA = "0x2586628", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000794")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200010E")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x25866C0", Offset = "0x25866C0", VA = "0x25866C0")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x25867BC", Offset = "0x25867BC", VA = "0x25867BC")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2586890", Offset = "0x2586890", VA = "0x2586890", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000799")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000110")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2586928", Offset = "0x2586928", VA = "0x2586928")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2FA0BD4", Offset = "0x2FA0BD4", VA = "0x2FA0BD4")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2FA0CA8", Offset = "0x2FA0CA8", VA = "0x2FA0CA8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600079E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000112")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x2FA0D4C", Offset = "0x2FA0D4C", VA = "0x2FA0D4C")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x2586A24", Offset = "0x2586A24", VA = "0x2586A24")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2586AF8", Offset = "0x2586AF8", VA = "0x2586AF8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007A3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000114")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2586B90", Offset = "0x2586B90", VA = "0x2586B90")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x2586C8C", Offset = "0x2586C8C", VA = "0x2586C8C")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2586D60", Offset = "0x2586D60", VA = "0x2586D60", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007A8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000116")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2586DF8", Offset = "0x2586DF8", VA = "0x2586DF8")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2586EF4", Offset = "0x2586EF4", VA = "0x2586EF4")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2586FC8", Offset = "0x2586FC8", VA = "0x2586FC8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007AD")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000118")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2587060", Offset = "0x2587060", VA = "0x2587060")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x258715C", Offset = "0x258715C", VA = "0x258715C")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2587230", Offset = "0x2587230", VA = "0x2587230", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007B2")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200011A")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x3001BD0", Offset = "0x3001BD0", VA = "0x3001BD0")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x25872BC", Offset = "0x25872BC", VA = "0x25872BC")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2587390", Offset = "0x2587390", VA = "0x2587390", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007B7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200011C")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2587428", Offset = "0x2587428", VA = "0x2587428")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2587524", Offset = "0x2587524", VA = "0x2587524")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x25875F8", Offset = "0x25875F8", VA = "0x25875F8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007BC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2587690", Offset = "0x2587690", VA = "0x2587690")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x258778C", Offset = "0x258778C", VA = "0x258778C")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2587860", Offset = "0x2587860", VA = "0x2587860", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007C1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000120")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x25878F8", Offset = "0x25878F8", VA = "0x25878F8")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x2000121")]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x254C6FC", Offset = "0x254C6FC", VA = "0x254C6FC")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x254C754", Offset = "0x254C754", VA = "0x254C754", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007C6")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000122")]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x254C89C", Offset = "0x254C89C", VA = "0x254C89C")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x254C8E8", Offset = "0x254C8E8", VA = "0x254C8E8", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007C9")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000123")]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x254C8EC", Offset = "0x254C8EC", VA = "0x254C8EC")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x254C93C", Offset = "0x254C93C", VA = "0x254C93C", Slot = "10")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007CD")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000124")]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x254C940", Offset = "0x254C940", VA = "0x254C940")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x254CA08", Offset = "0x254CA08", VA = "0x254CA08")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x254CC6C", Offset = "0x254CC6C", VA = "0x254CC6C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007D1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000125")]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x254D050", Offset = "0x254D050", VA = "0x254D050")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x254D088", Offset = "0x254D088", VA = "0x254D088", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007D5")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000126")]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x254D08C", Offset = "0x254D08C", VA = "0x254D08C")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x254D0D8", Offset = "0x254D0D8", VA = "0x254D0D8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007D9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60007DA")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9EF84", Offset = "0xB9EF84")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x25537B0", Offset = "0x25537B0", VA = "0x25537B0")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x2553878", Offset = "0x2553878", VA = "0x2553878", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007DD")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F090", Offset = "0xB9F090")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x2553B18", Offset = "0x2553B18", VA = "0x2553B18")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x2553BE0", Offset = "0x2553BE0", VA = "0x2553BE0", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007E1")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F1B8", Offset = "0xB9F1B8")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x2553F20", Offset = "0x2553F20", VA = "0x2553F20")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2553FE8", Offset = "0x2553FE8", VA = "0x2553FE8", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007E5")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F5B8", Offset = "0xB9F5B8")]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x2F9BE20", Offset = "0x2F9BE20", VA = "0x2F9BE20")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x2F9BEEC", Offset = "0x2F9BEEC", VA = "0x2F9BEEC", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007E9")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x2F9E3D8", Offset = "0x2F9E3D8", VA = "0x2F9E3D8")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2F9E4A4", Offset = "0x2F9E4A4", VA = "0x2F9E4A4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007ED")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F6FC", Offset = "0xB9F6FC")]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x2FF8894", Offset = "0x2FF8894", VA = "0x2FF8894")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x2FF8960", Offset = "0x2FF8960", VA = "0x2FF8960", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007F1")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x2FF8D44", Offset = "0x2FF8D44", VA = "0x2FF8D44")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F840", Offset = "0xB9F840")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2FF8E40", Offset = "0x2FF8E40", VA = "0x2FF8E40")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2FF8F0C", Offset = "0x2FF8F0C", VA = "0x2FF8F0C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007F6")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x2FF8FF8", Offset = "0x2FF8FF8", VA = "0x2FF8FF8")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F8C0", Offset = "0xB9F8C0")]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2FF90F4", Offset = "0x2FF90F4", VA = "0x2FF90F4")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x2FF91C0", Offset = "0x2FF91C0", VA = "0x2FF91C0", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007FB")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x2FF99CC", Offset = "0x2FF99CC", VA = "0x2FF99CC")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9FB00", Offset = "0xB9FB00")]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2FFB058", Offset = "0x2FFB058", VA = "0x2FFB058")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2FFB124", Offset = "0x2FFB124", VA = "0x2FFB124", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000800")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9FE58", Offset = "0xB9FE58")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2FFC3A8", Offset = "0x2FFC3A8", VA = "0x2FFC3A8")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2FFC474", Offset = "0x2FFC474", VA = "0x2FFC474", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000804")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x2FFC9FC", Offset = "0x2FFC9FC", VA = "0x2FFC9FC")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9FFB8", Offset = "0xB9FFB8")]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x3000828", Offset = "0x3000828", VA = "0x3000828")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x30008F4", Offset = "0x30008F4", VA = "0x30008F4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000809")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA00C4", Offset = "0xBA00C4")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x3002058", Offset = "0x3002058", VA = "0x3002058")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x3002124", Offset = "0x3002124", VA = "0x3002124", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600080D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA03C8", Offset = "0xBA03C8")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2583944", Offset = "0x2583944", VA = "0x2583944")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x2583A10", Offset = "0x2583A10", VA = "0x2583A10", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000811")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA049C", Offset = "0xBA049C")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x25527D4", Offset = "0x25527D4", VA = "0x25527D4")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x255289C", Offset = "0x255289C", VA = "0x255289C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000815")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0554", Offset = "0xBA0554")]
	public class ES3Type_AudioClip : ES3ObjectType
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x2552A40", Offset = "0x2552A40", VA = "0x2552A40")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x2552B08", Offset = "0x2552B08", VA = "0x2552B08", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600081A")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200013A")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x2552D50", Offset = "0x2552D50", VA = "0x2552D50")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0644", Offset = "0xBA0644")]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x2552E60", Offset = "0x2552E60", VA = "0x2552E60")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x2552F28", Offset = "0x2552F28", VA = "0x2552F28", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600081F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200013C")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2553324", Offset = "0x2553324", VA = "0x2553324")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0788", Offset = "0xBA0788")]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2553434", Offset = "0x2553434", VA = "0x2553434")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x25534FC", Offset = "0x25534FC", VA = "0x25534FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000824")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200013E")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x25536A0", Offset = "0x25536A0", VA = "0x25536A0")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0824", Offset = "0xBA0824")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x2F9C36C", Offset = "0x2F9C36C", VA = "0x2F9C36C")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2F9C438", Offset = "0x2F9C438", VA = "0x2F9C438", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000829")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600082A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0A80", Offset = "0xBA0A80")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2F9CB38", Offset = "0x2F9CB38", VA = "0x2F9CB38")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2F9CC04", Offset = "0x2F9CC04", VA = "0x2F9CC04", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600082E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000141")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2F9D248", Offset = "0x2F9D248", VA = "0x2F9D248")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0B54", Offset = "0xBA0B54")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2F9CE20", Offset = "0x2F9CE20", VA = "0x2F9CE20")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2F9CEEC", Offset = "0x2F9CEEC", VA = "0x2F9CEEC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000833")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2F9D104", Offset = "0x2F9D104", VA = "0x2F9D104")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000143")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x2F9D14C", Offset = "0x2F9D14C", VA = "0x2F9D14C")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0C28", Offset = "0xBA0C28")]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2F9D344", Offset = "0x2F9D344", VA = "0x2F9D344")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2F9D410", Offset = "0x2F9D410", VA = "0x2F9D410", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000839")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0CE0", Offset = "0xBA0CE0")]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2F9D6BC", Offset = "0x2F9D6BC", VA = "0x2F9D6BC")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2F9D788", Offset = "0x2F9D788", VA = "0x2F9D788", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600083E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0D7C", Offset = "0xBA0D7C")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x2F9DFA8", Offset = "0x2F9DFA8", VA = "0x2F9DFA8")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x2F9E074", Offset = "0x2F9E074", VA = "0x2F9E074", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000843")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0E6C", Offset = "0xBA0E6C")]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2F9E4AC", Offset = "0x2F9E4AC", VA = "0x2F9E4AC")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2F9E578", Offset = "0x2F9E578", VA = "0x2F9E578", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000848")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0F08", Offset = "0xBA0F08")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2F9E758", Offset = "0x2F9E758", VA = "0x2F9E758")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2F9E824", Offset = "0x2F9E824", VA = "0x2F9E824", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600084D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600084E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2F9E8FC", Offset = "0x2F9E8FC", VA = "0x2F9E8FC")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0F88", Offset = "0xBA0F88")]
	public class ES3Type_Font : ES3Type
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2F9E9F8", Offset = "0x2F9E9F8", VA = "0x2F9E9F8")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x2F9EAC4", Offset = "0x2F9EAC4", VA = "0x2F9EAC4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000853")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000854")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200014B")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x2F9EC30", Offset = "0x2F9EC30", VA = "0x2F9EC30")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1024", Offset = "0xBA1024")]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x2F9ED2C", Offset = "0x2F9ED2C", VA = "0x2F9ED2C")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x2F9EDF8", Offset = "0x2F9EDF8", VA = "0x2F9EDF8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000859")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600085A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1184", Offset = "0xBA1184")]
	public class ES3Type_GameObject : ES3Type
	{
		[Token(Token = "0x4000450")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x4000451")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x2F9F2E8", Offset = "0x2F9F2E8", VA = "0x2F9F2E8")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x2F9F3B4", Offset = "0x2F9F3B4", VA = "0x2F9F3B4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600085E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2F9FA38", Offset = "0x2F9FA38", VA = "0x2F9FA38")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}
	}
	[Token(Token = "0x200014E")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x2F9FDE0", Offset = "0x2F9FDE0", VA = "0x2F9FDE0")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA12AC", Offset = "0xBA12AC")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2F9FEDC", Offset = "0x2F9FEDC", VA = "0x2F9FEDC")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x2F9FFA8", Offset = "0x2F9FFA8", VA = "0x2F9FFA8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000865")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1364", Offset = "0xBA1364")]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x2FA0158", Offset = "0x2FA0158", VA = "0x2FA0158")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x2FA0224", Offset = "0x2FA0224", VA = "0x2FA0224", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600086A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x2FA0394", Offset = "0x2FA0394", VA = "0x2FA0394")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1400", Offset = "0xBA1400")]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2FA0490", Offset = "0x2FA0490", VA = "0x2FA0490")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2FA055C", Offset = "0x2FA055C", VA = "0x2FA055C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
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
	}
	[Token(Token = "0x2000153")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2FA0718", Offset = "0x2FA0718", VA = "0x2FA0718")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA149C", Offset = "0xBA149C")]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2FA0814", Offset = "0x2FA0814", VA = "0x2FA0814")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2FA08E0", Offset = "0x2FA08E0", VA = "0x2FA08E0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
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
	}
	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1570", Offset = "0xBA1570")]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2FA0E48", Offset = "0x2FA0E48", VA = "0x2FA0E48")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2FA0F14", Offset = "0x2FA0F14", VA = "0x2FA0F14", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600087B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000156")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2FA1164", Offset = "0x2FA1164", VA = "0x2FA1164")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1644", Offset = "0xBA1644")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2FA1260", Offset = "0x2FA1260", VA = "0x2FA1260")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2FA132C", Offset = "0x2FA132C", VA = "0x2FA132C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000880")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA16FC", Offset = "0xBA16FC")]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2FA1460", Offset = "0x2FA1460", VA = "0x2FA1460")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x2FA152C", Offset = "0x2FA152C", VA = "0x2FA152C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000884")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA19C8", Offset = "0xBA19C8")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x2FA1E24", Offset = "0x2FA1E24", VA = "0x2FA1E24")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x2FA1EF0", Offset = "0x2FA1EF0", VA = "0x2FA1EF0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000888")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000889")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1B7C", Offset = "0xBA1B7C")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x2FA250C", Offset = "0x2FA250C", VA = "0x2FA250C")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x2FA25D8", Offset = "0x2FA25D8", VA = "0x2FA25D8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600088D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600088E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1D30", Offset = "0xBA1D30")]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x2FA2BDC", Offset = "0x2FA2BDC", VA = "0x2FA2BDC")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x2FA2CA8", Offset = "0x2FA2CA8", VA = "0x2FA2CA8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000892")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000893")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA21A0", Offset = "0xBA21A0")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x2FA3C88", Offset = "0x2FA3C88", VA = "0x2FA3C88")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x2FA3D54", Offset = "0x2FA3D54", VA = "0x2FA3D54", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000897")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x2FF7C58", Offset = "0x2FF7C58", VA = "0x2FF7C58")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2290", Offset = "0xBA2290")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x2FF7D54", Offset = "0x2FF7D54", VA = "0x2FF7D54")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x2FF7E20", Offset = "0x2FF7E20", VA = "0x2FF7E20", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600089D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200015F")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x2FF8094", Offset = "0x2FF8094", VA = "0x2FF8094")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2364", Offset = "0xBA2364")]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x2FF8190", Offset = "0x2FF8190", VA = "0x2FF8190")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x2FF825C", Offset = "0x2FF825C", VA = "0x2FF825C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008A2")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008A3")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2550", Offset = "0xBA2550")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2FF9AC8", Offset = "0x2FF9AC8", VA = "0x2FF9AC8")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x2FF9B94", Offset = "0x2FF9B94", VA = "0x2FF9B94", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008A7")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2694", Offset = "0xBA2694")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x2FF9F50", Offset = "0x2FF9F50", VA = "0x2FF9F50")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2FFA01C", Offset = "0x2FFA01C", VA = "0x2FFA01C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008AC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA27BC", Offset = "0xBA27BC")]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2FFA3A8", Offset = "0x2FFA3A8", VA = "0x2FFA3A8")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2FFA474", Offset = "0x2FFA474", VA = "0x2FFA474", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008B0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008B1")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2B14", Offset = "0xBA2B14")]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x2FFBBF8", Offset = "0x2FFBBF8", VA = "0x2FFBBF8")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x2FFBCC4", Offset = "0x2FFBCC4", VA = "0x2FFBCC4", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008B5")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60008B6")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000165")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x2FFBF6C", Offset = "0x2FFBF6C", VA = "0x2FFBF6C")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2C04", Offset = "0xBA2C04")]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x2FFC068", Offset = "0x2FFC068", VA = "0x2FFC068")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x2FFC134", Offset = "0x2FFC134", VA = "0x2FFC134", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008BB")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60008BC")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000167")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x2FFC2AC", Offset = "0x2FFC2AC", VA = "0x2FFC2AC")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2CA0", Offset = "0xBA2CA0")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x2FFCAF8", Offset = "0x2FFCAF8", VA = "0x2FFCAF8")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x2FFCBC4", Offset = "0x2FFCBC4", VA = "0x2FFCBC4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008C1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000169")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x2FFCDE0", Offset = "0x2FFCDE0", VA = "0x2FFCDE0")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2D74", Offset = "0xBA2D74")]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x2FFCEDC", Offset = "0x2FFCEDC", VA = "0x2FFCEDC")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x2FFCFA8", Offset = "0x2FFCFA8", VA = "0x2FFCFA8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008C6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2E48", Offset = "0xBA2E48")]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x2FFD1E8", Offset = "0x2FFD1E8", VA = "0x2FFD1E8")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x2FFD2B4", Offset = "0x2FFD2B4", VA = "0x2FFD2B4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008CA")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA2FFC", Offset = "0xBA2FFC")]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x2FFD874", Offset = "0x2FFD874", VA = "0x2FFD874")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x2FFD940", Offset = "0x2FFD940", VA = "0x2FFD940", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008CE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008CF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA315C", Offset = "0xBA315C")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x2FFDE68", Offset = "0x2FFDE68", VA = "0x2FFDE68")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x2FFDF34", Offset = "0x2FFDF34", VA = "0x2FFDF34", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008D3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008D4")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200016E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA32A0", Offset = "0xBA32A0")]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x2FFE3C8", Offset = "0x2FFE3C8", VA = "0x2FFE3C8")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x2FFE494", Offset = "0x2FFE494", VA = "0x2FFE494", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008D8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x2FFE634", Offset = "0x2FFE634", VA = "0x2FFE634")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA333C", Offset = "0xBA333C")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x2FFE730", Offset = "0x2FFE730", VA = "0x2FFE730")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x2FFE7FC", Offset = "0x2FFE7FC", VA = "0x2FFE7FC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008DE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA35B4", Offset = "0xBA35B4")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x2FFEFC8", Offset = "0x2FFEFC8", VA = "0x2FFEFC8")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x2FFF094", Offset = "0x2FFF094", VA = "0x2FFF094", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008E3")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000172")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA374C", Offset = "0xBA374C")]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x2FFF67C", Offset = "0x2FFF67C", VA = "0x2FFF67C")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x2FFF748", Offset = "0x2FFF748", VA = "0x2FFF748", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008E8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008E9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA38C8", Offset = "0xBA38C8")]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2FFFC9C", Offset = "0x2FFFC9C", VA = "0x2FFFC9C")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x2FFFD68", Offset = "0x2FFFD68", VA = "0x2FFFD68", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008ED")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x300072C", Offset = "0x300072C", VA = "0x300072C")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA3BB0", Offset = "0xBA3BB0")]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x3000C78", Offset = "0x3000C78", VA = "0x3000C78")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x3000D44", Offset = "0x3000D44", VA = "0x3000D44", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008F2")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60008F3")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA3CA0", Offset = "0xBA3CA0")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x30010D0", Offset = "0x30010D0", VA = "0x30010D0")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x300119C", Offset = "0x300119C", VA = "0x300119C", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008F7")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x3001AD4", Offset = "0x3001AD4", VA = "0x3001AD4")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA3F34", Offset = "0xBA3F34")]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x3001CCC", Offset = "0x3001CCC", VA = "0x3001CCC")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x3001D98", Offset = "0x3001D98", VA = "0x3001D98", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008FC")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA3FEC", Offset = "0xBA3FEC")]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x2581EF4", Offset = "0x2581EF4", VA = "0x2581EF4")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x2581FC0", Offset = "0x2581FC0", VA = "0x2581FC0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000901")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000902")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200017A")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x2582808", Offset = "0x2582808", VA = "0x2582808")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA40DC", Offset = "0xBA40DC")]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x2582174", Offset = "0x2582174", VA = "0x2582174")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x258227C", Offset = "0x258227C", VA = "0x258227C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000907")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000908")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200017C")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x258270C", Offset = "0x258270C", VA = "0x258270C")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA41CC", Offset = "0xBA41CC")]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x2582904", Offset = "0x2582904", VA = "0x2582904")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x25829D0", Offset = "0x25829D0", VA = "0x25829D0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600090D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600090E")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA43B8", Offset = "0xBA43B8")]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x25830CC", Offset = "0x25830CC", VA = "0x25830CC")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x2583198", Offset = "0x2583198", VA = "0x2583198", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000912")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA45C0", Offset = "0xBA45C0")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x2583CF4", Offset = "0x2583CF4", VA = "0x2583CF4")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x2583DC0", Offset = "0x2583DC0", VA = "0x2583DC0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000917")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000918")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA46CC", Offset = "0xBA46CC")]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x258435C", Offset = "0x258435C", VA = "0x258435C")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x2584428", Offset = "0x2584428", VA = "0x2584428", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600091C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000181")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x2584598", Offset = "0x2584598", VA = "0x2584598")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA4768", Offset = "0xBA4768")]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x2584694", Offset = "0x2584694", VA = "0x2584694")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x2584760", Offset = "0x2584760", VA = "0x2584760", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000921")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000183")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x2584928", Offset = "0x2584928", VA = "0x2584928")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA4820", Offset = "0xBA4820")]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x2584A24", Offset = "0x2584A24", VA = "0x2584A24")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x2584AF0", Offset = "0x2584AF0", VA = "0x2584AF0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000926")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000185")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x2584CF0", Offset = "0x2584CF0", VA = "0x2584CF0")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA48D8", Offset = "0xBA48D8")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x2584DEC", Offset = "0x2584DEC", VA = "0x2584DEC")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x2584EB8", Offset = "0x2584EB8", VA = "0x2584EB8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600092B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x25850D0", Offset = "0x25850D0", VA = "0x25850D0")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000187")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x2585170", Offset = "0x2585170", VA = "0x2585170")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA49AC", Offset = "0xBA49AC")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x258526C", Offset = "0x258526C", VA = "0x258526C")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x2585338", Offset = "0x2585338", VA = "0x2585338", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000931")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x2000189")]
	public static class ES3Hash
	{
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x2544220", Offset = "0x2544220", VA = "0x2544220")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x200018A")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x6000935")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000936")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x258B2C0", Offset = "0x258B2C0", VA = "0x258B2C0")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x258B3A4", Offset = "0x258B3A4", VA = "0x258B3A4")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x400048E")]
		private const int ivSize = 16;

		[Token(Token = "0x400048F")]
		private const int keySize = 16;

		[Token(Token = "0x4000490")]
		private const int pwIterations = 100;

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x22D3CCC", Offset = "0x22D3CCC", VA = "0x22D3CCC", Slot = "4")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x22D4128", Offset = "0x22D4128", VA = "0x22D4128", Slot = "5")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x22D456C", Offset = "0x22D456C", VA = "0x22D456C")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x2590D78", Offset = "0x2590D78", VA = "0x2590D78")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x2590E44", Offset = "0x2590E44", VA = "0x2590E44", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x200018D")]
	public struct ES3Data
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x2541A14", Offset = "0x2541A14", VA = "0x2541A14")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x2541AEC", Offset = "0x2541AEC", VA = "0x2541AEC")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x200018E")]
	public static class ES3IO
	{
		[Token(Token = "0x200018F")]
		public enum ES3FileMode
		{
			[Token(Token = "0x4000499")]
			Read,
			[Token(Token = "0x400049A")]
			Write,
			[Token(Token = "0x400049B")]
			Append
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x25449F4", Offset = "0x25449F4", VA = "0x25449F4")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x2544A88", Offset = "0x2544A88", VA = "0x2544A88")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x2544AEC", Offset = "0x2544AEC", VA = "0x2544AEC")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x2544A80", Offset = "0x2544A80", VA = "0x2544A80")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x2544B28", Offset = "0x2544B28", VA = "0x2544B28")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x2544B30", Offset = "0x2544B30", VA = "0x2544B30")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x25441F8", Offset = "0x25441F8", VA = "0x25441F8")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x2544B38", Offset = "0x2544B38", VA = "0x2544B38")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x2544194", Offset = "0x2544194", VA = "0x2544194")]
		public static string GetDirectoryName(string path)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x2544B40", Offset = "0x2544B40", VA = "0x2544B40")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x2544C68", Offset = "0x2544C68", VA = "0x2544C68")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x2544CA8", Offset = "0x2544CA8", VA = "0x2544CA8")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x2544DD0", Offset = "0x2544DD0", VA = "0x2544DD0")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x2544DD8", Offset = "0x2544DD8", VA = "0x2544DD8")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x2544DE0", Offset = "0x2544DE0", VA = "0x2544DE0")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x2549480", Offset = "0x2549480", VA = "0x2549480")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x254965C", Offset = "0x254965C", VA = "0x254965C")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x25496D8", Offset = "0x25496D8", VA = "0x25496D8")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x25497DC", Offset = "0x25497DC", VA = "0x25497DC")]
		public Dictionary<long, long> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x2549A0C", Offset = "0x2549A0C", VA = "0x2549A0C")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x2549784", Offset = "0x2549784", VA = "0x2549784")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x2549E8C", Offset = "0x2549E8C", VA = "0x2549E8C")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000191")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x400049E")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Random rng;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool openReferences;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x170000E4")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x25413A4", Offset = "0x25413A4", VA = "0x25413A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public bool IsInitialised
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x254BCA0", Offset = "0x254BCA0", VA = "0x254BCA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x254BD00", Offset = "0x254BD00", VA = "0x254BD00")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x254BF00", Offset = "0x254BF00", VA = "0x254BF00")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x254C154", Offset = "0x254C154", VA = "0x254C154")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x254C1D0", Offset = "0x254C1D0", VA = "0x254C1D0")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x254C25C", Offset = "0x254C25C", VA = "0x254C25C")]
		public ES3Prefab GetPrefab(long id)
		{
			return null;
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x254C33C", Offset = "0x254C33C", VA = "0x254C33C")]
		public long GetPrefab(ES3Prefab prefab)
		{
			return default(long);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x2541548", Offset = "0x2541548", VA = "0x2541548")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x2549C34", Offset = "0x2549C34", VA = "0x2549C34")]
		public void Add(UnityEngine.Object obj, long id)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x254C458", Offset = "0x254C458", VA = "0x254C458")]
		public void AddPrefab(ES3Prefab prefab)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x254C4F8", Offset = "0x254C4F8", VA = "0x254C4F8")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x254C594", Offset = "0x254C594", VA = "0x254C594")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x254C630", Offset = "0x254C630", VA = "0x254C630")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x254C694", Offset = "0x254C694", VA = "0x254C694")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x2549CDC", Offset = "0x2549CDC", VA = "0x2549CDC")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x254BBE8", Offset = "0x254BBE8", VA = "0x254BBE8")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000192")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x254526C", Offset = "0x254526C", VA = "0x254526C", Slot = "6")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x2545278", Offset = "0x2545278", VA = "0x2545278", Slot = "7")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x25452EC", Offset = "0x25452EC", VA = "0x25452EC")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA4B00", Offset = "0xBA4B00")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x254BB00", Offset = "0x254BB00", VA = "0x254BB00", Slot = "6")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x254BB74", Offset = "0x254BB74", VA = "0x254BB74", Slot = "7")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x2549F00", Offset = "0x2549F00", VA = "0x2549F00")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public static class ES3Reflection
	{
		[Token(Token = "0x2000195")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x170000E7")]
			public bool IsNull
			{
				[Token(Token = "0x6000993")]
				[Address(RVA = "0x301429C", Offset = "0x301429C", VA = "0x301429C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E8")]
			public string Name
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x30142E8", Offset = "0x30142E8", VA = "0x30142E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			public Type MemberType
			{
				[Token(Token = "0x6000995")]
				[Address(RVA = "0x3014320", Offset = "0x3014320", VA = "0x3014320")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			public bool IsPublic
			{
				[Token(Token = "0x6000996")]
				[Address(RVA = "0x301436C", Offset = "0x301436C", VA = "0x301436C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EB")]
			public bool IsProtected
			{
				[Token(Token = "0x6000997")]
				[Address(RVA = "0x301440C", Offset = "0x301440C", VA = "0x301440C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x3014460", Offset = "0x3014460", VA = "0x3014460")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x3014640", Offset = "0x3014640", VA = "0x3014640")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x3014688", Offset = "0x3014688", VA = "0x3014688")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x2000196")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x30146D8", Offset = "0x30146D8", VA = "0x30146D8")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x301475C", Offset = "0x301475C", VA = "0x301475C")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x2000197")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4B14", Offset = "0xBA4B14")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x3014204", Offset = "0x3014204", VA = "0x3014204")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x301420C", Offset = "0x301420C", VA = "0x301420C")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4B24", Offset = "0xBA4B24")]
		private sealed class <>c
		{
			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__24_0;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, <>f__AnonymousType0<Assembly, Type>> <>9__24_1;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType0<Assembly, Type>, Type> <>9__24_3;

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x301410C", Offset = "0x301410C", VA = "0x301410C")]
			public <>c()
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x3014114", Offset = "0x3014114", VA = "0x3014114")]
			internal IEnumerable<Type> <GetDerivedTypes>b__24_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x3014138", Offset = "0x3014138", VA = "0x3014138")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__24_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x30141BC", Offset = "0x30141BC", VA = "0x30141BC")]
			internal Type <GetDerivedTypes>b__24_3(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x40004A5")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x40004A6")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x40004A7")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x170000E6")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x254D0DC", Offset = "0x254D0DC", VA = "0x254D0DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x2540844", Offset = "0x2540844", VA = "0x2540844")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x254D4B8", Offset = "0x254D4B8", VA = "0x254D4B8")]
		public static List<FieldInfo> GetSerializableFields(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x254DBBC", Offset = "0x254DBBC", VA = "0x254DBBC")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x254D880", Offset = "0x254D880", VA = "0x254D880")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x2542364", Offset = "0x2542364", VA = "0x2542364")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x254A77C", Offset = "0x254A77C", VA = "0x254A77C")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x253D1E4", Offset = "0x253D1E4", VA = "0x253D1E4")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x253C698", Offset = "0x253C698", VA = "0x253C698")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x254A6B4", Offset = "0x254A6B4", VA = "0x254A6B4")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x254E30C", Offset = "0x254E30C", VA = "0x254E30C")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x254B1F4", Offset = "0x254B1F4", VA = "0x254B1F4")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x254B42C", Offset = "0x254B42C", VA = "0x254B42C")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x600097B")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x254E5A4", Offset = "0x254E5A4", VA = "0x254E5A4")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x254D030", Offset = "0x254D030", VA = "0x254D030")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x254E98C", Offset = "0x254E98C", VA = "0x254E98C")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x254D478", Offset = "0x254D478", VA = "0x254D478")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x254E9AC", Offset = "0x254E9AC", VA = "0x254E9AC")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x254E9CC", Offset = "0x254E9CC", VA = "0x254E9CC")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2540D3C", Offset = "0x2540D3C", VA = "0x2540D3C")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x254E1EC", Offset = "0x254E1EC", VA = "0x254E1EC")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x254D498", Offset = "0x254D498", VA = "0x254D498")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x254E9EC", Offset = "0x254E9EC", VA = "0x254E9EC")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x254D458", Offset = "0x254D458", VA = "0x254D458")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x254C9F0", Offset = "0x254C9F0", VA = "0x254C9F0")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x254EA04", Offset = "0x254EA04", VA = "0x254EA04")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x254E204", Offset = "0x254E204", VA = "0x254E204")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x254EA24", Offset = "0x254EA24", VA = "0x254EA24")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x254EA9C", Offset = "0x254EA9C", VA = "0x254EA9C")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x254E564", Offset = "0x254E564", VA = "0x254E564")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x254E580", Offset = "0x254E580", VA = "0x254E580")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x254E0DC", Offset = "0x254E0DC", VA = "0x254E0DC")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x254D874", Offset = "0x254D874", VA = "0x254D874")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x254EB3C", Offset = "0x254EB3C", VA = "0x254EB3C")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x254EB60", Offset = "0x254EB60", VA = "0x254EB60")]
		public static Type GetInterface(Type type, string interfaceName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xBA4B34", Offset = "0xBA4B34")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : IEnumerable, IEnumerable<KeyValuePair<TKey, TVal>>
	{
		[Token(Token = "0x200019A")]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ES3SerializableDictionary<TKey, TVal> _Dictionary;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _Index;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TVal> _Current;

			[Token(Token = "0x170000F0")]
			public KeyValuePair<TKey, TVal> Current
			{
				[Token(Token = "0x60009BB")]
				get
				{
					return default(KeyValuePair<TKey, TVal>);
				}
			}

			[Token(Token = "0x170000F1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009BF")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BC")]
			public Enumerator(ES3SerializableDictionary<TKey, TVal> dictionary)
			{
			}

			[Token(Token = "0x60009BD")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009BE")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60009C0")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x170000EC")]
		public List<TKey> Keys
		{
			[Token(Token = "0x60009A6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public List<TVal> Values
		{
			[Token(Token = "0x60009A7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		public int Count
		{
			[Token(Token = "0x60009A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EF")]
		public TVal Item
		{
			[Token(Token = "0x60009AA")]
			get
			{
				return (TVal)null;
			}
			[Token(Token = "0x60009AB")]
			set
			{
			}
		}

		[Token(Token = "0x60009A4")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x60009A5")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x60009A9")]
		public void Add(TKey key, TVal value)
		{
		}

		[Token(Token = "0x60009AC")]
		public bool TryGetValue(TKey key, out TVal val)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AD")]
		public bool TryGetKey(TVal value, out TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AE")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AF")]
		public bool ContainsValue(TVal value)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B0")]
		public void Remove(TKey key)
		{
		}

		[Token(Token = "0x60009B1")]
		public int RemoveNullKeys()
		{
			return default(int);
		}

		[Token(Token = "0x60009B2")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x60009B3")]
		public bool ChangeKey(TKey oldId, TKey newId)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B4")]
		private int FindKeyIndex(TKey key)
		{
			return default(int);
		}

		[Token(Token = "0x60009B5")]
		private int FindValueIndex(TVal value)
		{
			return default(int);
		}

		[Token(Token = "0x60009B6")]
		private void Insert(TKey key, TVal value)
		{
		}

		[Token(Token = "0x60009B7")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60009B8")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60009B9")]
		private IEnumerator<KeyValuePair<TKey, TVal>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TVal>>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60009BA")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x40004BC")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StreamReader baseReader;

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x2545340", Offset = "0x2545340", VA = "0x2545340")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x2545574", Offset = "0x2545574", VA = "0x2545574", Slot = "20")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x2545A74", Offset = "0x2545A74", VA = "0x2545A74", Slot = "21")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2545C44", Offset = "0x2545C44", VA = "0x2545C44", Slot = "22")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x2545C54", Offset = "0x2545C54", VA = "0x2545C54", Slot = "26")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x2545F38", Offset = "0x2545F38", VA = "0x2545F38", Slot = "27")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x2545F40", Offset = "0x2545F40", VA = "0x2545F40", Slot = "28")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x2545F50", Offset = "0x2545F50", VA = "0x2545F50", Slot = "29")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x2545F54", Offset = "0x2545F54", VA = "0x2545F54", Slot = "30")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x2545F94", Offset = "0x2545F94", VA = "0x2545F94", Slot = "31")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x2545F9C", Offset = "0x2545F9C", VA = "0x2545F9C", Slot = "32")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x2545FA0", Offset = "0x2545FA0", VA = "0x2545FA0", Slot = "33")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x2546064", Offset = "0x2546064", VA = "0x2546064", Slot = "34")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x254606C", Offset = "0x254606C", VA = "0x254606C", Slot = "35")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x2546070", Offset = "0x2546070", VA = "0x2546070", Slot = "36")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x25460B0", Offset = "0x25460B0", VA = "0x25460B0", Slot = "37")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x2546174", Offset = "0x2546174", VA = "0x2546174", Slot = "24")]
		internal override bool Goto(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x2546208", Offset = "0x2546208", VA = "0x2546208")]
		protected void Reset()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x25462A8", Offset = "0x25462A8", VA = "0x25462A8")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x25463E8", Offset = "0x25463E8", VA = "0x25463E8", Slot = "23")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x2546380", Offset = "0x2546380", VA = "0x2546380")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x2545770", Offset = "0x2545770", VA = "0x2545770")]
		private char ReadCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x2545C5C", Offset = "0x2545C5C", VA = "0x2545C5C")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x254586C", Offset = "0x254586C", VA = "0x254586C")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x254699C", Offset = "0x254699C", VA = "0x254699C")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x2546B80", Offset = "0x2546B80", VA = "0x2546B80")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x25456DC", Offset = "0x25456DC", VA = "0x25456DC")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x2546D88", Offset = "0x2546D88", VA = "0x2546D88")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x25454C4", Offset = "0x25454C4", VA = "0x25454C4")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x2546964", Offset = "0x2546964", VA = "0x2546964")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x25468F0", Offset = "0x25468F0", VA = "0x25468F0")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x2546904", Offset = "0x2546904", VA = "0x2546904")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x254575C", Offset = "0x254575C", VA = "0x254575C")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x2545840", Offset = "0x2545840", VA = "0x2545840")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x2546E08", Offset = "0x2546E08", VA = "0x2546E08")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x2546E18", Offset = "0x2546E18", VA = "0x2546E18")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x2546F3C", Offset = "0x2546F3C", VA = "0x2546F3C", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x2547100", Offset = "0x2547100", VA = "0x2547100", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x2547180", Offset = "0x2547180", VA = "0x2547180", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x2547200", Offset = "0x2547200", VA = "0x2547200", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x2547218", Offset = "0x2547218", VA = "0x2547218", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x254728C", Offset = "0x254728C", VA = "0x254728C", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x2547340", Offset = "0x2547340", VA = "0x2547340", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x25473F4", Offset = "0x25473F4", VA = "0x25473F4", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x254740C", Offset = "0x254740C", VA = "0x254740C", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x2547424", Offset = "0x2547424", VA = "0x2547424", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x254743C", Offset = "0x254743C", VA = "0x254743C", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x2547458", Offset = "0x2547458", VA = "0x2547458", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x2547474", Offset = "0x2547474", VA = "0x2547474", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x2547490", Offset = "0x2547490", VA = "0x2547490", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x25474AC", Offset = "0x25474AC", VA = "0x25474AC", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x254752C", Offset = "0x254752C", VA = "0x254752C", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addMgrToSceneAutomatically;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool autoUpdateReferences;

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x2541B20", Offset = "0x2541B20", VA = "0x2541B20")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public enum ES3FileMode
	{
		[Token(Token = "0x40004C2")]
		Read,
		[Token(Token = "0x40004C3")]
		Write,
		[Token(Token = "0x40004C4")]
		Append
	}
	[Token(Token = "0x200019E")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x2543FEC", Offset = "0x2543FEC", VA = "0x2543FEC")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x25440BC", Offset = "0x25440BC", VA = "0x25440BC")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x2544164", Offset = "0x2544164", VA = "0x2544164")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x2544184", Offset = "0x2544184", VA = "0x2544184")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x2544200", Offset = "0x2544200", VA = "0x2544200", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x200019F")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x2549010", Offset = "0x2549010", VA = "0x2549010")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x2549154", Offset = "0x2549154", VA = "0x2549154")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x2549060", Offset = "0x2549060", VA = "0x2549060")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x25491AC", Offset = "0x25491AC", VA = "0x25491AC", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20001A0")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x170000F2")]
		public bool Exists
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x254ED10", Offset = "0x254ED10", VA = "0x254ED10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x254ED34", Offset = "0x254ED34", VA = "0x254ED34")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x254ED64", Offset = "0x254ED64", VA = "0x254ED64")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x254EE64", Offset = "0x254EE64", VA = "0x254EE64", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public static class ES3Stream
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x254B5F8", Offset = "0x254B5F8", VA = "0x254B5F8")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A2")]
	public class ES3Member
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x2548DB4", Offset = "0x2548DB4", VA = "0x2548DB4")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x2548E14", Offset = "0x2548E14", VA = "0x2548E14")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA5A04", Offset = "0xBA5A04")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x25409BC", Offset = "0x25409BC", VA = "0x25409BC")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x2552608", Offset = "0x2552608", VA = "0x2552608")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x25526F4", Offset = "0x25526F4", VA = "0x25526F4")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x2551C5C", Offset = "0x2551C5C", VA = "0x2551C5C")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x2551868", Offset = "0x2551868", VA = "0x2551868")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class ES3WebClass
	{
		[Token(Token = "0x20001A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4B6C", Offset = "0xBA4B6C")]
		private sealed class <SendWebRequest>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x170000F4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A17")]
				[Address(RVA = "0x3014820", Offset = "0x3014820", VA = "0x3014820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A19")]
				[Address(RVA = "0x3014868", Offset = "0x3014868", VA = "0x3014868", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x3014780", Offset = "0x3014780", VA = "0x3014780")]
			[DebuggerHidden]
			public <SendWebRequest>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x30147AC", Offset = "0x30147AC", VA = "0x30147AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x30147B0", Offset = "0x30147B0", VA = "0x30147B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x3014828", Offset = "0x3014828", VA = "0x3014828", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isDone;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string error;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long errorCode;

		[Token(Token = "0x170000F3")]
		public bool isError
		{
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x2587C14", Offset = "0x2587C14", VA = "0x2587C14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x2587C54", Offset = "0x2587C54", VA = "0x2587C54")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x2587D08", Offset = "0x2587D08", VA = "0x2587D08")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x2587DAC", Offset = "0x2587DAC", VA = "0x2587DAC")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x2587E4C", Offset = "0x2587E4C", VA = "0x2587E4C")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x2587FAC", Offset = "0x2587FAC", VA = "0x2587FAC")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x258819C", Offset = "0x258819C", VA = "0x258819C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA7BB8", Offset = "0xBA7BB8")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x2588214", Offset = "0x2588214", VA = "0x2588214", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x2547548", Offset = "0x2547548", VA = "0x2547548")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x2547554", Offset = "0x2547554", VA = "0x2547554")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x254760C", Offset = "0x254760C", VA = "0x254760C", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x2547630", Offset = "0x2547630", VA = "0x2547630", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x25476D4", Offset = "0x25476D4", VA = "0x25476D4", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x254775C", Offset = "0x254775C", VA = "0x254775C", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x2547800", Offset = "0x2547800", VA = "0x2547800", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x25478A4", Offset = "0x25478A4", VA = "0x25478A4", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x25478C8", Offset = "0x25478C8", VA = "0x25478C8", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x25478EC", Offset = "0x25478EC", VA = "0x25478EC", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x2547910", Offset = "0x2547910", VA = "0x2547910", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x25479A4", Offset = "0x25479A4", VA = "0x25479A4", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x2547A38", Offset = "0x2547A38", VA = "0x2547A38", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x2547ACC", Offset = "0x2547ACC", VA = "0x2547ACC", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x2547B60", Offset = "0x2547B60", VA = "0x2547B60", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x2547BA4", Offset = "0x2547BA4", VA = "0x2547BA4", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x2547C2C", Offset = "0x2547C2C", VA = "0x2547C2C", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x2547E64", Offset = "0x2547E64", VA = "0x2547E64", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x2547EC4", Offset = "0x2547EC4", VA = "0x2547EC4")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x2547EF8", Offset = "0x2547EF8", VA = "0x2547EF8")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x2547F30", Offset = "0x2547F30", VA = "0x2547F30", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x2547FAC", Offset = "0x2547FAC", VA = "0x2547FAC", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x2547FE0", Offset = "0x2547FE0", VA = "0x2547FE0", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x2548014", Offset = "0x2548014", VA = "0x2548014", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x2548070", Offset = "0x2548070", VA = "0x2548070", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x2548074", Offset = "0x2548074", VA = "0x2548074", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x25480A8", Offset = "0x25480A8", VA = "0x25480A8", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x25480D8", Offset = "0x25480D8", VA = "0x25480D8", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x2548100", Offset = "0x2548100", VA = "0x2548100", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x2548128", Offset = "0x2548128", VA = "0x2548128", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x2548158", Offset = "0x2548158", VA = "0x2548158", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x254815C", Offset = "0x254815C", VA = "0x254815C", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x254816C", Offset = "0x254816C", VA = "0x254816C", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x254817C", Offset = "0x254817C", VA = "0x254817C", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x25481AC", Offset = "0x25481AC", VA = "0x25481AC", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x25481D4", Offset = "0x25481D4", VA = "0x25481D4", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x25481D8", Offset = "0x25481D8", VA = "0x25481D8", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x25481DC", Offset = "0x25481DC", VA = "0x25481DC", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	internal class ES3XMLWriter : ES3Writer
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x2589F08", Offset = "0x2589F08", VA = "0x2589F08")]
		public ES3XMLWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x2589F14", Offset = "0x2589F14", VA = "0x2589F14")]
		internal ES3XMLWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x2589FC0", Offset = "0x2589FC0", VA = "0x2589FC0", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x2589FE4", Offset = "0x2589FE4", VA = "0x2589FE4", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x258A008", Offset = "0x258A008", VA = "0x258A008", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x258A030", Offset = "0x258A030", VA = "0x258A030", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x258A054", Offset = "0x258A054", VA = "0x258A054", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x258A078", Offset = "0x258A078", VA = "0x258A078", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x258A09C", Offset = "0x258A09C", VA = "0x258A09C", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x258A0C0", Offset = "0x258A0C0", VA = "0x258A0C0", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x258A0E4", Offset = "0x258A0E4", VA = "0x258A0E4", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x258A108", Offset = "0x258A108", VA = "0x258A108", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x258A12C", Offset = "0x258A12C", VA = "0x258A12C", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x258A1C0", Offset = "0x258A1C0", VA = "0x258A1C0", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x258A254", Offset = "0x258A254", VA = "0x258A254", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x258A2E8", Offset = "0x258A2E8", VA = "0x258A2E8", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x258A37C", Offset = "0x258A37C", VA = "0x258A37C", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x258A404", Offset = "0x258A404", VA = "0x258A404", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] bytes)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x258A8B0", Offset = "0x258A8B0", VA = "0x258A8B0", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x258A8B4", Offset = "0x258A8B4", VA = "0x258A8B4", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x258A8B8", Offset = "0x258A8B8", VA = "0x258A8B8", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x258A8C0", Offset = "0x258A8C0", VA = "0x258A8C0", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x258A8CC", Offset = "0x258A8CC", VA = "0x258A8CC", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x258A49C", Offset = "0x258A49C", VA = "0x258A49C")]
		protected void StartWriteProperty(string name, [Optional] ICollection<KeyValuePair<string, object>> attributes)
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x258A940", Offset = "0x258A940", VA = "0x258A940", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x258A9E4", Offset = "0x258A9E4", VA = "0x258A9E4", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x258A9E8", Offset = "0x258A9E8", VA = "0x258A9E8", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x258A9EC", Offset = "0x258A9EC", VA = "0x258A9EC", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x258A9F0", Offset = "0x258A9F0", VA = "0x258A9F0", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x258A9F4", Offset = "0x258A9F4", VA = "0x258A9F4", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x258A9F8", Offset = "0x258A9F8", VA = "0x258A9F8", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x258A9FC", Offset = "0x258A9FC", VA = "0x258A9FC", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x258AA00", Offset = "0x258AA00", VA = "0x258AA00", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x258AA04", Offset = "0x258AA04", VA = "0x258AA04", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x258AA08", Offset = "0x258AA08", VA = "0x258AA08", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x258AA0C", Offset = "0x258AA0C", VA = "0x258AA0C", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x258AA6C", Offset = "0x258AA6C", VA = "0x258AA6C", Slot = "22")]
		public override void Dispose()
		{
		}
	}
}
namespace MoodkieSecurity
{
	[Token(Token = "0x20001A8")]
	public enum AESBits
	{
		[Token(Token = "0x40004DD")]
		BITS128,
		[Token(Token = "0x40004DE")]
		BITS192,
		[Token(Token = "0x40004DF")]
		BITS256
	}
	[Token(Token = "0x20001A9")]
	public class AESEncryptor
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string fPassword;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AESBits fEncryptionBits;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] fSalt;

		[Token(Token = "0x170000F6")]
		public string Password
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x22D4BE0", Offset = "0x22D4BE0", VA = "0x22D4BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x22D4BE8", Offset = "0x22D4BE8", VA = "0x22D4BE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public AESBits EncryptionBits
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x22D4BF0", Offset = "0x22D4BF0", VA = "0x22D4BF0")]
			get
			{
				return default(AESBits);
			}
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x22D4BF8", Offset = "0x22D4BF8", VA = "0x22D4BF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public byte[] Salt
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x22D4C00", Offset = "0x22D4C00", VA = "0x22D4C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x22D4C08", Offset = "0x22D4C08", VA = "0x22D4C08")]
			set
			{
			}
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x22D4574", Offset = "0x22D4574", VA = "0x22D4574")]
		public AESEncryptor(string password, AESBits encryptionBits)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x22D4628", Offset = "0x22D4628", VA = "0x22D4628")]
		public AESEncryptor(string password, AESBits encryptionBits, byte[] salt)
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x22D46F8", Offset = "0x22D46F8", VA = "0x22D46F8")]
		private byte[] Encrypt(byte[] data, byte[] key, byte[] iV)
		{
			return null;
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x22D485C", Offset = "0x22D485C", VA = "0x22D485C")]
		public byte[] Encrypt(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x22D496C", Offset = "0x22D496C", VA = "0x22D496C")]
		private byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x22D4AD0", Offset = "0x22D4AD0", VA = "0x22D4AD0")]
		public byte[] Decrypt(byte[] data)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AA")]
	internal struct ABCDStruct
	{
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint A;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint B;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint C;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint D;
	}
	[Token(Token = "0x20001AB")]
	public sealed class MD5Core
	{
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x258CF70", Offset = "0x258CF70", VA = "0x258CF70")]
		private MD5Core()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x258CF78", Offset = "0x258CF78", VA = "0x258CF78")]
		public static byte[] GetHash(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x258D128", Offset = "0x258D128", VA = "0x258D128")]
		public static byte[] GetHash(string input)
		{
			return null;
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x258D188", Offset = "0x258D188", VA = "0x258D188")]
		public static string GetHashString(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x258D29C", Offset = "0x258D29C", VA = "0x258D29C")]
		public static string GetHashString(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x258D364", Offset = "0x258D364", VA = "0x258D364")]
		public static string GetHashString(string input)
		{
			return null;
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x258D040", Offset = "0x258D040", VA = "0x258D040")]
		public static byte[] GetHash(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x258DE58", Offset = "0x258DE58", VA = "0x258DE58")]
		internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ABCDStruct ABCD, long len)
		{
			return null;
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x258D3C4", Offset = "0x258D3C4", VA = "0x258D3C4")]
		internal static void GetHashBlock(byte[] input, ref ABCDStruct ABCDValue, int ibStart)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x258E228", Offset = "0x258E228", VA = "0x258E228")]
		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x258E250", Offset = "0x258E250", VA = "0x258E250")]
		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x258E278", Offset = "0x258E278", VA = "0x258E278")]
		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x258E29C", Offset = "0x258E29C", VA = "0x258E29C")]
		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x258E2C0", Offset = "0x258E2C0", VA = "0x258E2C0")]
		private static uint LSR(uint i, int s)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x258E0A4", Offset = "0x258E0A4", VA = "0x258E0A4")]
		private static uint[] Converter(byte[] input, int ibStart)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	public class MD5Encryptor
	{
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x258E2CC", Offset = "0x258E2CC", VA = "0x258E2CC")]
		public MD5Encryptor()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x258E2D4", Offset = "0x258E2D4", VA = "0x258E2D4")]
		public string GetMD5(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x258E2DC", Offset = "0x258E2DC", VA = "0x258E2DC")]
		public string GetMD5(string data)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AD")]
	public class Obfuscator
	{
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x258EFFC", Offset = "0x258EFFC", VA = "0x258EFFC")]
		public static byte[] Obfuscate(byte[] data, string key)
		{
			return null;
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x258F094", Offset = "0x258F094", VA = "0x258F094")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x258F120", Offset = "0x258F120", VA = "0x258F120")]
		public Obfuscator()
		{
		}
	}
}
