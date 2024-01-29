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
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9ADF4", Offset = "0xB9ADF4")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xBA1740", Offset = "0xBA1740")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xBA1754", Offset = "0xBA1754")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1818", Offset = "0xBA1818")]
	private bool <selectionChanged>k__BackingField;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	public bool saveButtonSelected;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1838", Offset = "0xBA1838")]
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
		[Address(RVA = "0x22CB688", Offset = "0x22CB688", VA = "0x22CB688", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public bool selected
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x22CB68C", Offset = "0x22CB68C", VA = "0x22CB68C", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x22CB694", Offset = "0x22CB694", VA = "0x22CB694", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool selectionChanged
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x22CB6A8", Offset = "0x22CB6A8", VA = "0x22CB6A8", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA260C", Offset = "0xBA260C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x22CB6B0", Offset = "0x22CB6B0", VA = "0x22CB6B0", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA261C", Offset = "0xBA261C")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public bool buttonSelected
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x22CB6BC", Offset = "0x22CB6BC", VA = "0x22CB6BC", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x22CB6C4", Offset = "0x22CB6C4", VA = "0x22CB6C4", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x22CB6D8", Offset = "0x22CB6D8", VA = "0x22CB6D8", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA262C", Offset = "0xBA262C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x22CB6E0", Offset = "0x22CB6E0", VA = "0x22CB6E0", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA263C", Offset = "0xBA263C")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool hasButtonSelectedComponents
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x22CB6EC", Offset = "0x22CB6EC", VA = "0x22CB6EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public bool isPrefab
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x22CB7E8", Offset = "0x22CB7E8", VA = "0x22CB7E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x22CB80C", Offset = "0x22CB80C", VA = "0x22CB80C")]
	public ES2AutoSaveVariableInfo GetCachedVariableInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x22CB924", Offset = "0x22CB924", VA = "0x22CB924")]
	public ES2AutoSaveVariableInfo CacheVariableInfo(ES2AutoSaveVariableInfo variable)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x22CB990", Offset = "0x22CB990", VA = "0x22CB990")]
	public void RemoveCachedVariableInfo(string id)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x22CBAE4", Offset = "0x22CBAE4", VA = "0x22CBAE4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x22CC08C", Offset = "0x22CC08C", VA = "0x22CC08C")]
	public ES2AutoSaveComponentInfo GetComponentInfo(Component c)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x22CC1B0", Offset = "0x22CC1B0", VA = "0x22CC1B0")]
	public ES2AutoSaveComponentInfo GetComponentInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x22CC2B4", Offset = "0x22CC2B4", VA = "0x22CC2B4")]
	public ES2AutoSaveComponentInfo AddComponentInfo(ES2AutoSaveComponentInfo info)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x22CC320", Offset = "0x22CC320", VA = "0x22CC320")]
	public static ES2AutoSave AddAutoSave(GameObject go, Color color, bool hide, bool generateID, string id)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x22CC7E8", Offset = "0x22CC7E8", VA = "0x22CC7E8")]
	public static ES2AutoSave GetAutoSave(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x22CBE68", Offset = "0x22CBE68", VA = "0x22CBE68")]
	public static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x22CC83C", Offset = "0x22CC83C", VA = "0x22CC83C")]
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
	[Address(RVA = "0x22CC950", Offset = "0x22CC950", VA = "0x22CC950")]
	public ES2AutoSaveComponentInfo()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x22CC9FC", Offset = "0x22CC9FC", VA = "0x22CC9FC")]
	public ES2AutoSaveComponentInfo(Component c, ES2AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x22CCBD4", Offset = "0x22CCBD4", VA = "0x22CCBD4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA18C8", Offset = "0xBA18C8")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA18F8", Offset = "0xBA18F8")]
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
		[Address(RVA = "0x22D0418", Offset = "0x22D0418", VA = "0x22D0418", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x22D0420", Offset = "0x22D0420", VA = "0x22D0420", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	[SerializeField]
	public bool selectionChanged
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x22D0434", Offset = "0x22D0434", VA = "0x22D0434", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA264C", Offset = "0xBA264C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x22D043C", Offset = "0x22D043C", VA = "0x22D043C", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA265C", Offset = "0xBA265C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool buttonSelected
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x22D0448", Offset = "0x22D0448", VA = "0x22D0448", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x22D0450", Offset = "0x22D0450", VA = "0x22D0450", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x22D0464", Offset = "0x22D0464", VA = "0x22D0464", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA266C", Offset = "0xBA266C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x22D046C", Offset = "0x22D046C", VA = "0x22D046C", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA267C", Offset = "0xBA267C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public ES2AutoSave autoSave
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x22D0478", Offset = "0x22D0478", VA = "0x22D0478")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x22CCB8C", Offset = "0x22CCB8C", VA = "0x22CCB8C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x22D0534", Offset = "0x22D0534", VA = "0x22D0534", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public Type type
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x22CCAF8", Offset = "0x22CCAF8", VA = "0x22CCAF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x22CCAB0", Offset = "0x22CCAB0", VA = "0x22CCAB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool HasButtonSelectedVariables
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x22D0538", Offset = "0x22D0538", VA = "0x22D0538")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x22CC954", Offset = "0x22CC954", VA = "0x22CC954")]
	public ES2AutoSaveVariableInfo()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x22CC6A0", Offset = "0x22CC6A0", VA = "0x22CC6A0")]
	public ES2AutoSaveVariableInfo(string name, Type type, bool isProperty, ES2AutoSave autoSave, ES2AutoSaveVariableInfo previous)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x22D0674", Offset = "0x22D0674", VA = "0x22D0674")]
	public ES2AutoSaveVariableInfo GetVariableInfo(string name)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x22D075C", Offset = "0x22D075C", VA = "0x22D075C")]
	public ES2AutoSaveVariableInfo AddVariableInfo(string name, Type type, bool isProperty, [Optional] ES2AutoSave autoSave, [Optional] ES2AutoSaveVariableInfo previous)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x22D088C", Offset = "0x22D088C", VA = "0x22D088C")]
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
	[Address(RVA = "0x22CCC60", Offset = "0x22CCC60", VA = "0x22CCC60")]
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
		[Address(RVA = "0x22CBD2C", Offset = "0x22CBD2C", VA = "0x22CBD2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x22CCCE4", Offset = "0x22CCCE4", VA = "0x22CCCE4")]
	public void SetFilePath(string filePath)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x22CCCEC", Offset = "0x22CCCEC", VA = "0x22CCCEC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x22CBFF0", Offset = "0x22CBFF0", VA = "0x22CBFF0")]
	public void AddAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x22CCE4C", Offset = "0x22CCE4C", VA = "0x22CCE4C")]
	public ES2AutoSave GetAutoSave(string id)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x22CCEC8", Offset = "0x22CCEC8", VA = "0x22CCEC8")]
	public void AddChildAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x22CCF34", Offset = "0x22CCF34", VA = "0x22CCF34")]
	public void Save()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x22CD0E8", Offset = "0x22CD0E8", VA = "0x22CD0E8")]
	public void Load()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x22CD5E4", Offset = "0x22CD5E4", VA = "0x22CD5E4")]
	public void WriteAutoSaves(ES2Writer writer)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x22CD848", Offset = "0x22CD848", VA = "0x22CD848")]
	private void WriteAutoSaveRecursive(Transform transform, ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x22CDD7C", Offset = "0x22CDD7C", VA = "0x22CDD7C")]
	private void WriteAutoSave(ES2AutoSave autoSave, Transform transform, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x22CE7A4", Offset = "0x22CE7A4", VA = "0x22CE7A4")]
	private void WriteVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Writer writer, object obj)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x22CEF2C", Offset = "0x22CEF2C", VA = "0x22CEF2C")]
	public void ReadAutoSaves(ES2Reader reader)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x22CEF60", Offset = "0x22CEF60", VA = "0x22CEF60")]
	private bool ReadAutoSave(ES2Reader reader, [Optional] ES2AutoSave autoSave)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x22CF9D4", Offset = "0x22CF9D4", VA = "0x22CF9D4")]
	private void ReadComponent(ES2AutoSave autoSave, ES2Reader reader)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x22CFCF0", Offset = "0x22CFCF0", VA = "0x22CFCF0")]
	private void ReadVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Reader reader, object obj)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x22CED70", Offset = "0x22CED70", VA = "0x22CED70")]
	protected void WriteAllComponents(ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x22D0188", Offset = "0x22D0188", VA = "0x22D0188")]
	public void Start()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x22D0198", Offset = "0x22D0198", VA = "0x22D0198")]
	public void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x22D01F0", Offset = "0x22D01F0", VA = "0x22D01F0")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x22D0200", Offset = "0x22D0200", VA = "0x22D0200")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x22D0214", Offset = "0x22D0214", VA = "0x22D0214")]
	public ES2AutoSaveManager()
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9AE14", Offset = "0xB9AE14")]
public static class ES2DirectoryUtility
{
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x22D1E98", Offset = "0x22D1E98", VA = "0x22D1E98")]
	public static void Delete(string path, bool recursive)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x22D1EA4", Offset = "0x22D1EA4", VA = "0x22D1EA4")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x22D1EAC", Offset = "0x22D1EAC", VA = "0x22D1EAC")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x22D1EB4", Offset = "0x22D1EB4", VA = "0x22D1EB4")]
	public static void CreateDirectory(string path)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x22D1EBC", Offset = "0x22D1EBC", VA = "0x22D1EBC")]
	public static string[] GetDirectories(string path)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x22D1EC4", Offset = "0x22D1EC4", VA = "0x22D1EC4")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9AE28", Offset = "0xB9AE28")]
public static class ES2Dispose
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x22D1ECC", Offset = "0x22D1ECC", VA = "0x22D1ECC")]
	public static void Dispose(BinaryReader reader)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x22D1EE8", Offset = "0x22D1EE8", VA = "0x22D1EE8")]
	public static void Dispose(BinaryWriter writer)
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9AE3C", Offset = "0xB9AE3C")]
public static class ES2FileUtility
{
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x22D1FD8", Offset = "0x22D1FD8", VA = "0x22D1FD8")]
	public static void Delete(string path)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x22D1FD0", Offset = "0x22D1FD0", VA = "0x22D1FD0")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x22D246C", Offset = "0x22D246C", VA = "0x22D246C")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x22D292C", Offset = "0x22D292C", VA = "0x22D292C")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x22D2878", Offset = "0x22D2878", VA = "0x22D2878")]
	public static Stream CreateFileStream(string path, ES2Settings.ES2FileMode filemode, int bufferSize)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9AE50", Offset = "0xB9AE50")]
public static class ES2TypeUtility
{
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x27643E0", Offset = "0x27643E0", VA = "0x27643E0")]
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
	[Address(RVA = "0x22C5A44", Offset = "0x22C5A44", VA = "0x22C5A44")]
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
	[Address(RVA = "0x22C5ACC", Offset = "0x22C5ACC", VA = "0x22C5ACC")]
	public static void SaveRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x22C5CE8", Offset = "0x22C5CE8", VA = "0x22C5CE8")]
	public static void SaveRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x22C5B68", Offset = "0x22C5B68", VA = "0x22C5B68")]
	public static void SaveRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x22C5D8C", Offset = "0x22C5D8C", VA = "0x22C5D8C")]
	public static void SaveRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x22C5F00", Offset = "0x22C5F00", VA = "0x22C5F00")]
	public static void SaveRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x22C6098", Offset = "0x22C6098", VA = "0x22C6098")]
	public static void SaveRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x22C6224", Offset = "0x22C6224", VA = "0x22C6224")]
	public static void AppendRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x22C6450", Offset = "0x22C6450", VA = "0x22C6450")]
	public static void AppendRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x22C62C0", Offset = "0x22C62C0", VA = "0x22C62C0")]
	public static void AppendRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x22C64F4", Offset = "0x22C64F4", VA = "0x22C64F4")]
	public static void AppendRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x22C6674", Offset = "0x22C6674", VA = "0x22C6674")]
	public static void AppendRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x22C681C", Offset = "0x22C681C", VA = "0x22C681C")]
	public static void AppendRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x22C69B4", Offset = "0x22C69B4", VA = "0x22C69B4")]
	public static void SaveImage(Texture2D tex, string identifier)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x22C6BC8", Offset = "0x22C6BC8", VA = "0x22C6BC8")]
	public static byte[] LoadRaw(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x22C6D44", Offset = "0x22C6D44", VA = "0x22C6D44")]
	public static byte[] LoadRaw(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x22C6EAC", Offset = "0x22C6EAC", VA = "0x22C6EAC")]
	public static object LoadObject(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x22C7038", Offset = "0x22C7038", VA = "0x22C7038")]
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
	[Address(RVA = "0x22C71B4", Offset = "0x22C71B4", VA = "0x22C71B4")]
	public static ES2Data LoadAll(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x22C7330", Offset = "0x22C7330", VA = "0x22C7330")]
	public static ES2Data LoadAll(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x22C7498", Offset = "0x22C7498", VA = "0x22C7498")]
	public static Texture2D LoadImage(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x22C7704", Offset = "0x22C7704", VA = "0x22C7704")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x22C7778", Offset = "0x22C7778", VA = "0x22C7778")]
	public static AudioClip LoadAudio(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x22C7C38", Offset = "0x22C7C38", VA = "0x22C7C38")]
	public static void CacheFile(string identifier)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x22C7D9C", Offset = "0x22C7D9C", VA = "0x22C7D9C")]
	public static bool Exists(string identifier)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x22C8258", Offset = "0x22C8258", VA = "0x22C8258")]
	public static bool Exists(string identifier, ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x22C8284", Offset = "0x22C8284", VA = "0x22C8284")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x22C8564", Offset = "0x22C8564", VA = "0x22C8564")]
	public static void Delete(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x22C8590", Offset = "0x22C8590", VA = "0x22C8590")]
	public static void DeleteDefaultFolder()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x22C888C", Offset = "0x22C888C", VA = "0x22C888C")]
	public static void Rename(string identifier, string newIdentifier)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x22C8BB8", Offset = "0x22C8BB8", VA = "0x22C8BB8")]
	public static void Rename(string identifier, string newIdentifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x22C8C14", Offset = "0x22C8C14", VA = "0x22C8C14")]
	public static string[] GetFiles(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x22C8CC0", Offset = "0x22C8CC0", VA = "0x22C8CC0")]
	public static string[] GetFiles(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x22C8CEC", Offset = "0x22C8CEC", VA = "0x22C8CEC")]
	public static string[] GetFiles(string identifier, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x22C8F6C", Offset = "0x22C8F6C", VA = "0x22C8F6C")]
	public static string[] GetFolders(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x22C91D4", Offset = "0x22C91D4", VA = "0x22C91D4")]
	public static string[] GetFolders(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x22C9200", Offset = "0x22C9200", VA = "0x22C9200")]
	public static string[] GetTags(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x22C93B0", Offset = "0x22C93B0", VA = "0x22C93B0")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AE64", Offset = "0xB9AE64")]
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
			[Address(RVA = "0x2FF6EFC", Offset = "0x2FF6EFC", VA = "0x2FF6EFC", Slot = "4")]
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
			[Address(RVA = "0x2FF6F44", Offset = "0x2FF6F44", VA = "0x2FF6F44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2FF6DFC", Offset = "0x2FF6DFC", VA = "0x2FF6DFC")]
		[DebuggerHidden]
		public <SaveRoutine>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2FF6E28", Offset = "0x2FF6E28", VA = "0x2FF6E28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2FF6E2C", Offset = "0x2FF6E2C", VA = "0x2FF6E2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2FF6F04", Offset = "0x2FF6F04", VA = "0x2FF6F04", Slot = "8")]
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
	[Address(RVA = "0x22C93E0", Offset = "0x22C93E0", VA = "0x22C93E0")]
	private void SavePosition()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x22C9588", Offset = "0x22C9588", VA = "0x22C9588")]
	private void LoadPosition()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x22C96B8", Offset = "0x22C96B8", VA = "0x22C96B8")]
	private void SaveRotation()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x22C97AC", Offset = "0x22C97AC", VA = "0x22C97AC")]
	private void LoadRotation()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x22C98DC", Offset = "0x22C98DC", VA = "0x22C98DC")]
	private void SaveScale()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x22C99C8", Offset = "0x22C99C8", VA = "0x22C99C8")]
	private void LoadScale()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x22C9AF8", Offset = "0x22C9AF8", VA = "0x22C9AF8")]
	private void SaveMesh()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x22C9CFC", Offset = "0x22C9CFC", VA = "0x22C9CFC")]
	private void LoadMesh()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x22C9FFC", Offset = "0x22C9FFC", VA = "0x22C9FFC")]
	private void SaveSphereCollider()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x22CA1C8", Offset = "0x22CA1C8", VA = "0x22CA1C8")]
	private void LoadSphereCollider()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x22CA474", Offset = "0x22CA474", VA = "0x22CA474")]
	private void SaveCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x22CA640", Offset = "0x22CA640", VA = "0x22CA640")]
	private void LoadCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x22CA8EC", Offset = "0x22CA8EC", VA = "0x22CA8EC")]
	private void SaveBoxCollider()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x22CAAB8", Offset = "0x22CAAB8", VA = "0x22CAAB8")]
	private void LoadBoxCollider()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x22CAD64", Offset = "0x22CAD64", VA = "0x22CAD64")]
	private void SaveMeshCollider()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x22CAF30", Offset = "0x22CAF30", VA = "0x22CAF30")]
	private void LoadMeshCollider()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x22CB1DC", Offset = "0x22CB1DC", VA = "0x22CB1DC")]
	public void Save()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x22CB280", Offset = "0x22CB280", VA = "0x22CB280")]
	public void Load()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x22CB324", Offset = "0x22CB324", VA = "0x22CB324")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA268C", Offset = "0xBA268C")]
	private IEnumerator SaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x22CB39C", Offset = "0x22CB39C", VA = "0x22CB39C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x22CB3B4", Offset = "0x22CB3B4", VA = "0x22CB3B4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x22CB3D4", Offset = "0x22CB3D4", VA = "0x22CB3D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x22CB548", Offset = "0x22CB548", VA = "0x22CB548")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x22CB560", Offset = "0x22CB560", VA = "0x22CB560")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x22C94CC", Offset = "0x22C94CC", VA = "0x22C94CC")]
	private string GetFullFilename(string tagExtension)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x22CB434", Offset = "0x22CB434", VA = "0x22CB434")]
	private void InitializeSettings()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x22CB578", Offset = "0x22CB578", VA = "0x22CB578")]
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
	[Address(RVA = "0x22D0904", Offset = "0x22D0904", VA = "0x22D0904")]
	public static ES2CachedFile AddNewCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x22D0A50", Offset = "0x22D0A50", VA = "0x22D0A50")]
	public static bool DeleteCachedFile(string absolutePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x22D0ADC", Offset = "0x22D0ADC", VA = "0x22D0ADC")]
	public static ES2CachedFile GetOrCreateCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x22D0BA8", Offset = "0x22D0BA8", VA = "0x22D0BA8")]
	public static ES2CachedFile GetCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x22D0C54", Offset = "0x22D0C54", VA = "0x22D0C54")]
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
	[Address(RVA = "0x22D112C", Offset = "0x22D112C", VA = "0x22D112C")]
	public void AddTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x22D1188", Offset = "0x22D1188", VA = "0x22D1188")]
	public void AddTag(ES2Tag tag)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x22D121C", Offset = "0x22D121C", VA = "0x22D121C")]
	public ES2Tag AddOrUpdateTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x22D1360", Offset = "0x22D1360", VA = "0x22D1360")]
	public ES2Tag GetTag(string tag)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x22D1420", Offset = "0x22D1420", VA = "0x22D1420")]
	public bool RemoveTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x22D1484", Offset = "0x22D1484", VA = "0x22D1484")]
	public void RenameTag(string oldTag, string newTag)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x22D1550", Offset = "0x22D1550", VA = "0x22D1550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x22D09CC", Offset = "0x22D09CC", VA = "0x22D09CC")]
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
	[Address(RVA = "0x2761F54", Offset = "0x2761F54", VA = "0x2761F54")]
	public ES2Tag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x2760C24", Offset = "0x2760C24", VA = "0x2760C24")]
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
	[Address(RVA = "0x22D1B70", Offset = "0x22D1B70", VA = "0x22D1B70")]
	public void Add(string tag, object value)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x22D1BDC", Offset = "0x22D1BDC", VA = "0x22D1BDC")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x22D1C40", Offset = "0x22D1C40", VA = "0x22D1C40")]
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
	[Address(RVA = "0x22D1E14", Offset = "0x22D1E14", VA = "0x22D1E14")]
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
	[Address(RVA = "0x22D1F04", Offset = "0x22D1F04", VA = "0x22D1F04")]
	public ES2EditorWindowStyle()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9AE74", Offset = "0xB9AE74")]
public static class ES2File
{
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x22C82E4", Offset = "0x22C82E4", VA = "0x22C82E4")]
	public static void Delete(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x22D1F50", Offset = "0x22D1F50", VA = "0x22D1F50")]
	public static void DeleteFile(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x22D1FE0", Offset = "0x22D1FE0", VA = "0x22D1FE0")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x22C7DFC", Offset = "0x22C7DFC", VA = "0x22C7DFC")]
	public static bool Exists(ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x22D2128", Offset = "0x22D2128", VA = "0x22D2128")]
	private static bool CheckForTagInBytes(string tag, byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x22D2378", Offset = "0x22D2378", VA = "0x22D2378")]
	public static void CreateFolder(string identifier)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x22C8914", Offset = "0x22C8914", VA = "0x22C8914")]
	public static void Rename(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x22D2380", Offset = "0x22D2380", VA = "0x22D2380")]
	public static void MoveFile(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x22C8FCC", Offset = "0x22C8FCC", VA = "0x22C8FCC")]
	public static string[] GetFolders(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x22C8C74", Offset = "0x22C8C74", VA = "0x22C8C74")]
	public static string[] GetFiles(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x22C8D5C", Offset = "0x22C8D5C", VA = "0x22C8D5C")]
	public static string[] GetFiles(ES2Settings settings, string extension)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x22C9260", Offset = "0x22C9260", VA = "0x22C9260")]
	public static string[] GetTags(ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class ES2Reflection
{
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2762188", Offset = "0x2762188", VA = "0x2762188")]
	public static bool SetValue(object obj, string name, object value, bool isProperty = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2762254", Offset = "0x2762254", VA = "0x2762254")]
	public static object GetValue(object obj, string name, bool isProperty = false)
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x275D4CC", Offset = "0x275D4CC", VA = "0x275D4CC")]
	public static bool IsAssignableFrom(Type a, Type b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x275D4EC", Offset = "0x275D4EC", VA = "0x275D4EC")]
	public static bool IsGenericType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x276232C", Offset = "0x276232C", VA = "0x276232C")]
	public static Type[] GetGenericArguments(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x275EA08", Offset = "0x275EA08", VA = "0x275EA08")]
	public static object CreateGenericInstance(Type type, Type genericType)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x275EE38", Offset = "0x275EE38", VA = "0x275EE38")]
	public static object CreateGenericInstance(Type type, Type genericType, Type genericType2)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x276234C", Offset = "0x276234C", VA = "0x276234C")]
	public static bool IsCollectionType(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB9AE88", Offset = "0xB9AE88")]
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
		[Address(RVA = "0x2763884", Offset = "0x2763884", VA = "0x2763884")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2763888", Offset = "0x2763888", VA = "0x2763888")]
		set
		{
		}
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2762ECC", Offset = "0x2762ECC", VA = "0x2762ECC")]
	public ES2Spreadsheet()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x27630A8", Offset = "0x27630A8", VA = "0x27630A8")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2763390", Offset = "0x2763390", VA = "0x2763390")]
	public string GetCell(int col, int row)
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x27631E0", Offset = "0x27631E0", VA = "0x27631E0")]
	private void SizeSpreadsheetToFitRow(int row)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2763470", Offset = "0x2763470", VA = "0x2763470")]
	public void Save(string path)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x27634DC", Offset = "0x27634DC", VA = "0x27634DC")]
	public void Save(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2762F80", Offset = "0x2762F80", VA = "0x2762F80")]
	private static void GetCharacterConstants()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x276388C", Offset = "0x276388C", VA = "0x276388C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB9AEC0", Offset = "0xB9AEC0")]
public class ES2SpreadsheetRow
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<string> cells;

	[Token(Token = "0x1700001B")]
	public int cellCount
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x27637E4", Offset = "0x27637E4", VA = "0x27637E4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001C")]
	public string Item
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x276346C", Offset = "0x276346C", VA = "0x276346C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2763CE8", Offset = "0x2763CE8", VA = "0x2763CE8")]
		set
		{
		}
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x2763318", Offset = "0x2763318", VA = "0x2763318")]
	public void SetCell(int col, string value)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2763A90", Offset = "0x2763A90", VA = "0x2763A90")]
	public string GetCell(int col)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x27637CC", Offset = "0x27637CC", VA = "0x27637CC")]
	public byte[] GetCellBytes(int col)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x27639DC", Offset = "0x27639DC", VA = "0x27639DC")]
	private void SizeRowToFitColumn(int col)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2763B54", Offset = "0x2763B54", VA = "0x2763B54")]
	private byte[] GetBytes(string data)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2763CEC", Offset = "0x2763CEC", VA = "0x2763CEC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2763294", Offset = "0x2763294", VA = "0x2763294")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AEF8", Offset = "0xB9AEF8")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF08", Offset = "0xB9AF08")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF18", Offset = "0xB9AF18")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF28", Offset = "0xB9AF28")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF38", Offset = "0xB9AF38")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF48", Offset = "0xB9AF48")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF58", Offset = "0xB9AF58")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF68", Offset = "0xB9AF68")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF78", Offset = "0xB9AF78")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF88", Offset = "0xB9AF88")]
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
			[Address(RVA = "0x2FF7984", Offset = "0x2FF7984", VA = "0x2FF7984", Slot = "4")]
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
			[Address(RVA = "0x2FF79CC", Offset = "0x2FF79CC", VA = "0x2FF79CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2FF7838", Offset = "0x2FF7838", VA = "0x2FF7838")]
		[DebuggerHidden]
		public <UploadRaw>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2FF7864", Offset = "0x2FF7864", VA = "0x2FF7864", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2FF7868", Offset = "0x2FF7868", VA = "0x2FF7868", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2FF798C", Offset = "0x2FF798C", VA = "0x2FF798C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AF98", Offset = "0xB9AF98")]
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
			[Address(RVA = "0x2FF77E8", Offset = "0x2FF77E8", VA = "0x2FF77E8", Slot = "4")]
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
			[Address(RVA = "0x2FF7830", Offset = "0x2FF7830", VA = "0x2FF7830", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2FF7690", Offset = "0x2FF7690", VA = "0x2FF7690")]
		[DebuggerHidden]
		public <UploadImage>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2FF76BC", Offset = "0x2FF76BC", VA = "0x2FF76BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2FF76C0", Offset = "0x2FF76C0", VA = "0x2FF76C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2FF77F0", Offset = "0x2FF77F0", VA = "0x2FF77F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AFA8", Offset = "0xB9AFA8")]
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
			[Address(RVA = "0x2FF7640", Offset = "0x2FF7640", VA = "0x2FF7640", Slot = "4")]
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
			[Address(RVA = "0x2FF7688", Offset = "0x2FF7688", VA = "0x2FF7688", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2FF74B8", Offset = "0x2FF74B8", VA = "0x2FF74B8")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2FF74E4", Offset = "0x2FF74E4", VA = "0x2FF74E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2FF74E8", Offset = "0x2FF74E8", VA = "0x2FF74E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2FF7648", Offset = "0x2FF7648", VA = "0x2FF7648", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AFB8", Offset = "0xB9AFB8")]
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
			[Address(RVA = "0x2FF7468", Offset = "0x2FF7468", VA = "0x2FF7468", Slot = "4")]
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
			[Address(RVA = "0x2FF74B0", Offset = "0x2FF74B0", VA = "0x2FF74B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2FF7320", Offset = "0x2FF7320", VA = "0x2FF7320")]
		[DebuggerHidden]
		public <DownloadFilenames>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2FF734C", Offset = "0x2FF734C", VA = "0x2FF734C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2FF7350", Offset = "0x2FF7350", VA = "0x2FF7350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2FF7470", Offset = "0x2FF7470", VA = "0x2FF7470", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AFC8", Offset = "0xB9AFC8")]
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
			[Address(RVA = "0x2FF72D0", Offset = "0x2FF72D0", VA = "0x2FF72D0", Slot = "4")]
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
			[Address(RVA = "0x2FF7318", Offset = "0x2FF7318", VA = "0x2FF7318", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2FF7188", Offset = "0x2FF7188", VA = "0x2FF7188")]
		[DebuggerHidden]
		public <Download>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2FF71B4", Offset = "0x2FF71B4", VA = "0x2FF71B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2FF71B8", Offset = "0x2FF71B8", VA = "0x2FF71B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2FF72D8", Offset = "0x2FF72D8", VA = "0x2FF72D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9AFD8", Offset = "0xB9AFD8")]
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
			[Address(RVA = "0x2FF7138", Offset = "0x2FF7138", VA = "0x2FF7138", Slot = "4")]
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
			[Address(RVA = "0x2FF7180", Offset = "0x2FF7180", VA = "0x2FF7180", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2FF6F4C", Offset = "0x2FF6F4C", VA = "0x2FF6F4C")]
		[DebuggerHidden]
		public <Delete>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2FF6F78", Offset = "0x2FF6F78", VA = "0x2FF6F78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2FF6F7C", Offset = "0x2FF6F7C", VA = "0x2FF6F7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2FF7140", Offset = "0x2FF7140", VA = "0x2FF7140", Slot = "8")]
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
		[Address(RVA = "0x27644F8", Offset = "0x27644F8", VA = "0x27644F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public string text
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2764514", Offset = "0x2764514", VA = "0x2764514")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public float progress
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2764530", Offset = "0x2764530", VA = "0x2764530")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000020")]
	public float uploadProgress
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x276454C", Offset = "0x276454C", VA = "0x276454C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2764568", Offset = "0x2764568", VA = "0x2764568")]
	public ES2Web(string identifier)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x2764618", Offset = "0x2764618", VA = "0x2764618")]
	public ES2Web(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000125")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA273C", Offset = "0xBA273C")]
	public IEnumerator Upload<T>(T param)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA279C", Offset = "0xBA279C")]
	public IEnumerator Upload<T>(T[] param)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA27FC", Offset = "0xBA27FC")]
	public IEnumerator Upload<T>(T[,] param)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA285C", Offset = "0xBA285C")]
	public IEnumerator Upload<T>(T[,,] param)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA28BC", Offset = "0xBA28BC")]
	public IEnumerator Upload<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA291C", Offset = "0xBA291C")]
	public IEnumerator Upload<T>(List<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA297C", Offset = "0xBA297C")]
	public IEnumerator Upload<T>(HashSet<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA29DC", Offset = "0xBA29DC")]
	public IEnumerator Upload<T>(Queue<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA2A3C", Offset = "0xBA2A3C")]
	public IEnumerator Upload<T>(Stack<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x27646B8", Offset = "0x27646B8", VA = "0x27646B8")]
	public IEnumerator UploadRaw(string data)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x2764704", Offset = "0x2764704", VA = "0x2764704")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA2A9C", Offset = "0xBA2A9C")]
	public IEnumerator UploadRaw(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x2764798", Offset = "0x2764798", VA = "0x2764798")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA2AFC", Offset = "0xBA2AFC")]
	public IEnumerator UploadImage(Texture2D tex)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x276482C", Offset = "0x276482C", VA = "0x276482C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA2B5C", Offset = "0xBA2B5C")]
	public IEnumerator UploadFile(string file)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x27648C0", Offset = "0x27648C0", VA = "0x27648C0")]
	public Texture2D LoadImage()
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x2764A8C", Offset = "0x2764A8C", VA = "0x2764A8C")]
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
	[Address(RVA = "0x2764AC4", Offset = "0x2764AC4", VA = "0x2764AC4")]
	public void SaveToFile(string identifier)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x2764B54", Offset = "0x2764B54", VA = "0x2764B54")]
	public void SaveToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2764C04", Offset = "0x2764C04", VA = "0x2764C04")]
	public void AppendToFile(string identifier)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2764C94", Offset = "0x2764C94", VA = "0x2764C94")]
	public void AppendToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2764D40", Offset = "0x2764D40", VA = "0x2764D40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA2BBC", Offset = "0xBA2BBC")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x2764DB8", Offset = "0x2764DB8", VA = "0x2764DB8")]
	public string[] GetFilenames()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x2764E58", Offset = "0x2764E58", VA = "0x2764E58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA2C1C", Offset = "0xBA2C1C")]
	public IEnumerator Download()
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x2764ED0", Offset = "0x2764ED0", VA = "0x2764ED0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA2C7C", Offset = "0xBA2C7C")]
	public IEnumerator Delete()
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x2764F48", Offset = "0x2764F48", VA = "0x2764F48")]
	private WWWForm CreateUploadForm(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x2765140", Offset = "0x2765140", VA = "0x2765140")]
	private WWWForm CreateDownloadForm()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x276522C", Offset = "0x276522C", VA = "0x276522C")]
	private WWWForm CreateGetFilesForm()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2764950", Offset = "0x2764950", VA = "0x2764950")]
	private void CheckWWWUsage()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x27649E8", Offset = "0x27649E8", VA = "0x27649E8")]
	private void CheckDownloadUsage()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x27652AC", Offset = "0x27652AC", VA = "0x27652AC")]
	private bool getError()
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2764FFC", Offset = "0x2764FFC", VA = "0x2764FFC")]
	private WWWForm CreateForm()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x27655B0", Offset = "0x27655B0", VA = "0x27655B0")]
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
	[Address(RVA = "0x275CBD0", Offset = "0x275CBD0", VA = "0x275CBD0")]
	public ES2Header(ES2Keys.Key collectionType, int keyType, int valueType, ES2Settings settings)
	{
	}
}
[Token(Token = "0x200002F")]
public class ES2Reader : IDisposable
{
	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1A78", Offset = "0xBA1A78")]
	public ES2Stream stream;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings settings;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1A8C", Offset = "0xBA1A8C")]
	private ES2CachedFile cachedFile;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1AA0", Offset = "0xBA1AA0")]
	public ES2Tag currentTag;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BinaryReader reader;

	[Token(Token = "0x1700003F")]
	public int Length
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2760430", Offset = "0x2760430", VA = "0x2760430")]
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
	[Address(RVA = "0x275E2A0", Offset = "0x275E2A0", VA = "0x275E2A0")]
	public Array ReadSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x275E6F8", Offset = "0x275E6F8", VA = "0x275E6F8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA318C", Offset = "0xBA318C")]
	public ICollection ReadICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x275EAD8", Offset = "0x275EAD8", VA = "0x275EAD8")]
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
	[Address(RVA = "0x275E448", Offset = "0x275E448", VA = "0x275E448")]
	private Array ReadEncryptedSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x275E8B0", Offset = "0x275E8B0", VA = "0x275E8B0")]
	private ICollection ReadEncryptedICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x275ECD8", Offset = "0x275ECD8", VA = "0x275ECD8")]
	private IDictionary ReadEncryptedIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x275EFB4", Offset = "0x275EFB4", VA = "0x275EFB4")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey, string tag)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x275F5CC", Offset = "0x275F5CC", VA = "0x275F5CC")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x275F330", Offset = "0x275F330", VA = "0x275F330")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA31A0", Offset = "0xBA31A0")]
	public ES2Header ReadHeader()
	{
		return default(ES2Header);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x275F874", Offset = "0x275F874", VA = "0x275F874")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA31B4", Offset = "0xBA31B4")]
	public bool Next()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x275FA64", Offset = "0x275FA64", VA = "0x275FA64")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA31C8", Offset = "0xBA31C8")]
	public void Skip()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x275FA9C", Offset = "0x275FA9C", VA = "0x275FA9C")]
	protected bool WriteBytesBeforeTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x275FBDC", Offset = "0x275FBDC", VA = "0x275FBDC")]
	protected bool WriteRemainingBytes(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x275FD0C", Offset = "0x275FD0C", VA = "0x275FD0C")]
	protected bool WriteBytesBeforeTagLowMemory(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x275FEE4", Offset = "0x275FEE4", VA = "0x275FEE4")]
	protected bool WriteRemainingBytesLowMemory(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x27600C4", Offset = "0x27600C4", VA = "0x27600C4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA31DC", Offset = "0xBA31DC")]
	public bool RenameTag(string oldTag, string newTag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2760348", Offset = "0x2760348", VA = "0x2760348")]
	protected bool DeleteTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x27604EC", Offset = "0x27604EC", VA = "0x27604EC")]
	protected void WriteCurrentTag(ES2Writer writer)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x276056C", Offset = "0x276056C", VA = "0x276056C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA31F0", Offset = "0xBA31F0")]
	public bool DeleteTags(ICollection<string> tags, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x2760970", Offset = "0x2760970", VA = "0x2760970")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3204", Offset = "0xBA3204")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x2760A58", Offset = "0x2760A58", VA = "0x2760A58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3218", Offset = "0xBA3218")]
	public byte[] ReadMeshSettings()
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2760AA0", Offset = "0x2760AA0", VA = "0x2760AA0")]
	private byte[] GetDecryptedBytes()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x275EF40", Offset = "0x275EF40", VA = "0x275EF40")]
	private ES2Reader GetEncryptedReader()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2760460", Offset = "0x2760460", VA = "0x2760460")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA322C", Offset = "0xBA322C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2760C94", Offset = "0x2760C94", VA = "0x2760C94", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2760CA0", Offset = "0x2760CA0", VA = "0x2760CA0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3240", Offset = "0xBA3240")]
	public void CacheFile()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x275F20C", Offset = "0x275F20C", VA = "0x275F20C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3254", Offset = "0xBA3254")]
	public bool ScanToTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2760D6C", Offset = "0x2760D6C", VA = "0x2760D6C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3268", Offset = "0xBA3268")]
	public bool ScanToTag()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2760D88", Offset = "0x2760D88", VA = "0x2760D88")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2760DB8", Offset = "0x2760DB8", VA = "0x2760DB8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA327C", Offset = "0xBA327C")]
	public bool TagExists()
	{
		return default(bool);
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2760DF8", Offset = "0x2760DF8", VA = "0x2760DF8")]
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
	[Address(RVA = "0x2760E38", Offset = "0x2760E38", VA = "0x2760E38")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3290", Offset = "0xBA3290")]
	public ES2Data ReadAll()
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x2760F18", Offset = "0x2760F18", VA = "0x2760F18")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA32A4", Offset = "0xBA32A4")]
	public object ReadObject()
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x2761520", Offset = "0x2761520", VA = "0x2761520")]
	public void ReadObject(object obj)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x276160C", Offset = "0x276160C", VA = "0x276160C")]
	public object ReadObject(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x2761664", Offset = "0x2761664", VA = "0x2761664")]
	public void ReadObject(string tag, object obj)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x27616CC", Offset = "0x27616CC", VA = "0x27616CC")]
	public void ReadComponent(GameObject go)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x276183C", Offset = "0x276183C", VA = "0x276183C")]
	public void ReadComponent(string tag, GameObject go)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x27618A4", Offset = "0x27618A4", VA = "0x27618A4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA32B8", Offset = "0xBA32B8")]
	public Dictionary<string, ES2Header> ReadAllHeaders()
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA32CC", Offset = "0xBA32CC")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600020C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA32E0", Offset = "0xBA32E0")]
	public T ReadProperty<T>(T obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA32F4", Offset = "0xBA32F4")]
	public T[] ReadPropertyArray<T>()
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3308", Offset = "0xBA3308")]
	public T[] ReadPropertyArray<T>(T[] obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA331C", Offset = "0xBA331C")]
	public T[,] ReadProperty2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3330", Offset = "0xBA3330")]
	public T[,,] ReadProperty3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3344", Offset = "0xBA3344")]
	public List<T> ReadPropertyList<T>()
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3358", Offset = "0xBA3358")]
	public Queue<T> ReadPropertyQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA336C", Offset = "0xBA336C")]
	public Stack<T> ReadPropertyStack<T>()
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3380", Offset = "0xBA3380")]
	public Dictionary<TKey, TValue> ReadPropertyDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x275E598", Offset = "0x275E598", VA = "0x275E598")]
	private static int[] GetMultidimensionalIndices(Array a, int idx)
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x27619B4", Offset = "0x27619B4", VA = "0x27619B4")]
	public static ES2Reader Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2761C0C", Offset = "0x2761C0C", VA = "0x2761C0C")]
	public static ES2Reader Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2761BB0", Offset = "0x2761BB0", VA = "0x2761BB0")]
	public static ES2Reader Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2760BB8", Offset = "0x2760BB8", VA = "0x2760BB8")]
	public static ES2Reader Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2761CB4", Offset = "0x2761CB4", VA = "0x2761CB4")]
	public ES2Reader(ES2Settings settings)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2761E2C", Offset = "0x2761E2C", VA = "0x2761E2C")]
	public ES2Reader(byte[] bytes, ES2Settings settings)
	{
	}
}
[Token(Token = "0x2000030")]
public class ES2InvalidDataException : Exception
{
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x275CBE4", Offset = "0x275CBE4", VA = "0x275CBE4")]
	public ES2InvalidDataException()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9AFE8", Offset = "0xB9AFE8")]
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
		[Address(RVA = "0x22D22DC", Offset = "0x22D22DC", VA = "0x22D22DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public string resourcesPath
	{
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x22D2040", Offset = "0x22D2040", VA = "0x22D2040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x22D2954", Offset = "0x22D2954", VA = "0x22D2954")]
	public ES2FilenameData(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x22D3120", Offset = "0x22D3120", VA = "0x22D3120")]
	public ES2FilenameData(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x22D2A84", Offset = "0x22D2A84", VA = "0x22D2A84")]
	public void Init(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x22D33A4", Offset = "0x22D33A4", VA = "0x22D33A4")]
	private void ProcessParameter(string name, string value, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x22D3310", Offset = "0x22D3310", VA = "0x22D3310")]
	private static PathType GetPathType(string path)
	{
		return default(PathType);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x22D3E38", Offset = "0x22D3E38", VA = "0x22D3E38")]
	private static bool PathIsURL(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x22D324C", Offset = "0x22D324C", VA = "0x22D324C")]
	private static bool PathIsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x22D3FD0", Offset = "0x22D3FD0", VA = "0x22D3FD0")]
	private static bool PathIsFolder(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x22D1F0C", Offset = "0x22D1F0C", VA = "0x22D1F0C")]
	public bool HasTag()
	{
		return default(bool);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x22C868C", Offset = "0x22C868C", VA = "0x22C868C")]
	public static string GetPersistentPath()
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x22D22CC", Offset = "0x22D22CC", VA = "0x22D22CC")]
	public bool IsURL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x22D1F40", Offset = "0x22D1F40", VA = "0x22D1F40")]
	public bool IsFolder()
	{
		return default(bool);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x22D1F30", Offset = "0x22D1F30", VA = "0x22D1F30")]
	public bool IsFile()
	{
		return default(bool);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x22D4018", Offset = "0x22D4018", VA = "0x22D4018")]
	public bool IsAbsolute()
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x22D4020", Offset = "0x22D4020", VA = "0x22D4020")]
	public string GetSavePath(ES2Settings.SaveLocation saveLocation)
	{
		return null;
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9AFFC", Offset = "0xB9AFFC")]
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
		[Address(RVA = "0x275C7A4", Offset = "0x275C7A4", VA = "0x275C7A4")]
		get
		{
			return default(ES2Settings.SaveLocation);
		}
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x275C820", Offset = "0x275C820", VA = "0x275C820")]
		set
		{
		}
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x275C888", Offset = "0x275C888", VA = "0x275C888")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x275CA58", Offset = "0x275CA58", VA = "0x275CA58")]
	public ES2GlobalSettings()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B010", Offset = "0xB9B010")]
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
	[Address(RVA = "0x275CC60", Offset = "0x275CC60", VA = "0x275CC60")]
	public static string TypeFromKeys(Key collection, Key value, Key key)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x275D0FC", Offset = "0x275D0FC", VA = "0x275D0FC")]
	public static Key[] KeysFromType(Key collectionType, Key valueType, Key keyType)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x275D194", Offset = "0x275D194", VA = "0x275D194")]
	public static Key KeyFromES2Type(ES2Type type)
	{
		return default(Key);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x275D1A8", Offset = "0x275D1A8", VA = "0x275D1A8")]
	public static Key[] KeysFromES2Type(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x275D1C4", Offset = "0x275D1C4", VA = "0x275D1C4")]
	public static Key[] KeysFromES2Type(ES2Type type, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x275D1E4", Offset = "0x275D1E4", VA = "0x275D1E4")]
	public static Key[] KeysFromES2Type(ES2Type keyType, ES2Type valueType, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x275D210", Offset = "0x275D210", VA = "0x275D210")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1AB4", Offset = "0xBA1AB4")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1AC8", Offset = "0xBA1AC8")]
	public byte meshSettingsCount;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string name;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1ADC", Offset = "0xBA1ADC")]
	public ES2FileMode fileMode;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int bufferSize;

	[Token(Token = "0x17000043")]
	public string tag
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2762DD0", Offset = "0x2762DD0", VA = "0x2762DD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2762DD8", Offset = "0x2762DD8", VA = "0x2762DD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA484C", Offset = "0xBA484C")]
	public bool IsImageFile
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2762DE0", Offset = "0x2762DE0", VA = "0x2762DE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x276272C", Offset = "0x276272C", VA = "0x276272C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3394", Offset = "0xBA3394")]
	public void Init()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x2762874", Offset = "0x2762874", VA = "0x2762874")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA33A8", Offset = "0xBA33A8")]
	public ES2Settings Clone()
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x2761C34", Offset = "0x2761C34", VA = "0x2761C34")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA33BC", Offset = "0xBA33BC")]
	public ES2Settings Clone(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x27629CC", Offset = "0x27629CC", VA = "0x27629CC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA33D0", Offset = "0xBA33D0")]
	public byte[] MeshSettingsToByteArray()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x2762ABC", Offset = "0x2762ABC", VA = "0x2762ABC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA33E4", Offset = "0xBA33E4")]
	public void MeshSettingsFromByteArray(byte[] bytes)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x2761A10", Offset = "0x2761A10", VA = "0x2761A10")]
	public ES2Settings(string identifier)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x2762C78", Offset = "0x2762C78", VA = "0x2762C78")]
	public ES2Settings(SaveLocation saveLocation)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x275D6C4", Offset = "0x275D6C4", VA = "0x275D6C4")]
	public ES2Settings()
	{
	}
}
[Token(Token = "0x200003C")]
internal sealed class ES2FileStream : ES2Stream
{
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x22D2474", Offset = "0x22D2474", VA = "0x22D2474")]
	public ES2FileStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x22D2658", Offset = "0x22D2658", VA = "0x22D2658", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x22D2814", Offset = "0x22D2814", VA = "0x22D2814")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x22D2574", Offset = "0x22D2574", VA = "0x22D2574")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x22D24D8", Offset = "0x22D24D8", VA = "0x22D24D8")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x22D2934", Offset = "0x22D2934", VA = "0x22D2934", Slot = "5")]
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
	[Address(RVA = "0x275D50C", Offset = "0x275D50C", VA = "0x275D50C")]
	public ES2MemoryStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x275D5A0", Offset = "0x275D5A0", VA = "0x275D5A0")]
	public ES2MemoryStream(byte[] bytes, ES2Settings settings)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x275D620", Offset = "0x275D620", VA = "0x275D620")]
	public ES2MemoryStream()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x275D808", Offset = "0x275D808", VA = "0x275D808", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x275DB0C", Offset = "0x275DB0C", VA = "0x275DB0C", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x275DB14", Offset = "0x275DB14", VA = "0x275DB14", Slot = "6")]
	public override byte[] ReadAllBytes()
	{
		return null;
	}
}
[Token(Token = "0x200003E")]
internal sealed class ES2PlayerPrefsStream : ES2Stream
{
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x275DBEC", Offset = "0x275DBEC", VA = "0x275DBEC")]
	public ES2PlayerPrefsStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x275DDC8", Offset = "0x275DDC8", VA = "0x275DDC8", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x275E1D0", Offset = "0x275E1D0", VA = "0x275E1D0")]
	private void StoreRaw()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x275E140", Offset = "0x275E140", VA = "0x275E140")]
	private void StoreRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x275E260", Offset = "0x275E260", VA = "0x275E260")]
	private void StoreRaw(string bytes)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x275E064", Offset = "0x275E064", VA = "0x275E064")]
	private void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x275E00C", Offset = "0x275E00C", VA = "0x275E00C")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x275DC5C", Offset = "0x275DC5C", VA = "0x275DC5C")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x275DD70", Offset = "0x275DD70", VA = "0x275DD70")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x275E280", Offset = "0x275E280", VA = "0x275E280", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x200003F")]
internal sealed class ES2ResourcesStream : ES2Stream
{
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x2762434", Offset = "0x2762434", VA = "0x2762434")]
	public ES2ResourcesStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x276263C", Offset = "0x276263C", VA = "0x276263C", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x27626B0", Offset = "0x27626B0", VA = "0x27626B0", Slot = "5")]
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
		[Address(RVA = "0x275F9FC", Offset = "0x275F9FC", VA = "0x275F9FC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2763E24", Offset = "0x2763E24", VA = "0x2763E24")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public long Position
	{
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x275FA40", Offset = "0x275FA40", VA = "0x275FA40")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x275FA1C", Offset = "0x275FA1C", VA = "0x275FA1C")]
		set
		{
		}
	}

	[Token(Token = "0x600025F")]
	public abstract void Store();

	[Token(Token = "0x6000260")]
	public abstract bool MayRequireOverwrite();

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x275FC7C", Offset = "0x275FC7C", VA = "0x275FC7C")]
	public byte[] ReadBytes(int count)
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x275DB28", Offset = "0x275DB28", VA = "0x275DB28", Slot = "6")]
	public virtual byte[] ReadAllBytes()
	{
		return null;
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x275D9B8", Offset = "0x275D9B8", VA = "0x275D9B8")]
	protected void WriteToStreamFast(Stream writableStream)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x275DA2C", Offset = "0x275DA2C", VA = "0x275DA2C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA33F8", Offset = "0xBA33F8")]
	protected void WriteToStreamLowMemory(Stream writableStream)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x276212C", Offset = "0x276212C", VA = "0x276212C")]
	public static ES2Stream Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x2761F98", Offset = "0x2761F98", VA = "0x2761F98")]
	public static ES2Stream Create(ES2Settings settings, Operation operation)
	{
		return null;
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x275D598", Offset = "0x275D598", VA = "0x275D598")]
	protected ES2Stream()
	{
	}
}
[Token(Token = "0x2000042")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B024", Offset = "0xB9B024")]
public sealed class ES2_BoneWeight : ES2Type
{
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x2767498", Offset = "0x2767498", VA = "0x2767498")]
	public ES2_BoneWeight()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x276752C", Offset = "0x276752C", VA = "0x276752C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x27676BC", Offset = "0x27676BC", VA = "0x27676BC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B038", Offset = "0xB9B038")]
public sealed class ES2_Bounds : ES2Type
{
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x276785C", Offset = "0x276785C", VA = "0x276785C")]
	public ES2_Bounds()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x27678F0", Offset = "0x27678F0", VA = "0x27678F0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x27679D4", Offset = "0x27679D4", VA = "0x27679D4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B04C", Offset = "0xB9B04C")]
public sealed class ES2_Color : ES2Type
{
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x2768280", Offset = "0x2768280", VA = "0x2768280")]
	public ES2_Color()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x2768314", Offset = "0x2768314", VA = "0x2768314", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x27683F8", Offset = "0x27683F8", VA = "0x27683F8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B060", Offset = "0xB9B060")]
public sealed class ES2_Color32 : ES2Type
{
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x27684FC", Offset = "0x27684FC", VA = "0x27684FC")]
	public ES2_Color32()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x2768590", Offset = "0x2768590", VA = "0x2768590", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x2768678", Offset = "0x2768678", VA = "0x2768678", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000046")]
public class ES2_DateTime : ES2Type
{
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x2768770", Offset = "0x2768770", VA = "0x2768770", Slot = "4")]
	public override void Write(object obj, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x276882C", Offset = "0x276882C", VA = "0x276882C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x27688C8", Offset = "0x27688C8", VA = "0x27688C8")]
	public ES2_DateTime()
	{
	}
}
[Token(Token = "0x2000047")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B074", Offset = "0xB9B074")]
public sealed class ES2_ES2AutoSaveManager : ES2Type
{
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x2768950", Offset = "0x2768950", VA = "0x2768950")]
	public ES2_ES2AutoSaveManager()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x27689D8", Offset = "0x27689D8", VA = "0x27689D8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2768A70", Offset = "0x2768A70", VA = "0x2768A70", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2768A94", Offset = "0x2768A94", VA = "0x2768A94", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000048")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B088", Offset = "0xB9B088")]
public sealed class ES2_Enum : ES2Type
{
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x2764400", Offset = "0x2764400", VA = "0x2764400")]
	public ES2_Enum()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x2768B2C", Offset = "0x2768B2C", VA = "0x2768B2C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2768BC8", Offset = "0x2768BC8", VA = "0x2768BC8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000049")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B09C", Offset = "0xB9B09C")]
public sealed class ES2_Gradient : ES2Type
{
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x2768C48", Offset = "0x2768C48", VA = "0x2768C48")]
	public ES2_Gradient()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x2768CD0", Offset = "0x2768CD0", VA = "0x2768CD0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2768DBC", Offset = "0x2768DBC", VA = "0x2768DBC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B0B0", Offset = "0xB9B0B0")]
public sealed class ES2_GradientAlphaKey : ES2Type
{
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x2768F60", Offset = "0x2768F60", VA = "0x2768F60")]
	public ES2_GradientAlphaKey()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x2768FE8", Offset = "0x2768FE8", VA = "0x2768FE8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x27690A0", Offset = "0x27690A0", VA = "0x27690A0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B0C4", Offset = "0xB9B0C4")]
public sealed class ES2_GradientColorKey : ES2Type
{
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2768ED8", Offset = "0x2768ED8", VA = "0x2768ED8")]
	public ES2_GradientColorKey()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x276915C", Offset = "0x276915C", VA = "0x276915C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x27692A4", Offset = "0x27692A4", VA = "0x27692A4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B0D8", Offset = "0xB9B0D8")]
public sealed class ES2_Material : ES2Type
{
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x2769394", Offset = "0x2769394", VA = "0x2769394")]
	public ES2_Material()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x2769428", Offset = "0x2769428", VA = "0x2769428", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x276A3B0", Offset = "0x276A3B0", VA = "0x276A3B0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x276A45C", Offset = "0x276A45C", VA = "0x276A45C", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200004D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B0EC", Offset = "0xB9B0EC")]
public sealed class ES2_Matrix4x4 : ES2Type
{
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x276A864", Offset = "0x276A864", VA = "0x276A864")]
	public ES2_Matrix4x4()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x276A8F8", Offset = "0x276A8F8", VA = "0x276A8F8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x276AA20", Offset = "0x276AA20", VA = "0x276AA20", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B100", Offset = "0xB9B100")]
public sealed class ES2_Mesh : ES2Type
{
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x276AB20", Offset = "0x276AB20", VA = "0x276AB20")]
	public ES2_Mesh()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x276ABB4", Offset = "0x276ABB4", VA = "0x276ABB4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x276AEF0", Offset = "0x276AEF0", VA = "0x276AEF0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x276AF70", Offset = "0x276AF70", VA = "0x276AF70", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B114", Offset = "0xB9B114")]
public sealed class ES2_Quaternion : ES2Type
{
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x276BE5C", Offset = "0x276BE5C", VA = "0x276BE5C")]
	public ES2_Quaternion()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x276BEF0", Offset = "0x276BEF0", VA = "0x276BEF0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x276BFF4", Offset = "0x276BFF4", VA = "0x276BFF4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B128", Offset = "0xB9B128")]
public sealed class ES2_Rect : ES2Type
{
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x276C0F8", Offset = "0x276C0F8", VA = "0x276C0F8")]
	public ES2_Rect()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x276C18C", Offset = "0x276C18C", VA = "0x276C18C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x276C294", Offset = "0x276C294", VA = "0x276C294", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B13C", Offset = "0xB9B13C")]
public sealed class ES2_Sprite : ES2Type
{
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x276CC90", Offset = "0x276CC90", VA = "0x276CC90")]
	public ES2_Sprite()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x276CD24", Offset = "0x276CD24", VA = "0x276CD24", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x276CFB4", Offset = "0x276CFB4", VA = "0x276CFB4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000052")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B150", Offset = "0xB9B150")]
public sealed class ES2_Texture : ES2Type
{
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x276D104", Offset = "0x276D104", VA = "0x276D104")]
	public ES2_Texture()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x276D18C", Offset = "0x276D18C", VA = "0x276D18C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x276D30C", Offset = "0x276D30C", VA = "0x276D30C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x276D478", Offset = "0x276D478", VA = "0x276D478", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000053")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B164", Offset = "0xB9B164")]
public sealed class ES2_Texture2D : ES2Type
{
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x276D5E4", Offset = "0x276D5E4", VA = "0x276D5E4")]
	public ES2_Texture2D()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x276D678", Offset = "0x276D678", VA = "0x276D678", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x276D7FC", Offset = "0x276D7FC", VA = "0x276D7FC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x276D884", Offset = "0x276D884", VA = "0x276D884", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000054")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B178", Offset = "0xB9B178")]
public sealed class ES2_Vector2 : ES2Type
{
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x276B4E4", Offset = "0x276B4E4", VA = "0x276B4E4")]
	public ES2_Vector2()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x276DE54", Offset = "0x276DE54", VA = "0x276DE54", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x276DF10", Offset = "0x276DF10", VA = "0x276DF10", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000055")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B18C", Offset = "0xB9B18C")]
public sealed class ES2_Vector3 : ES2Type
{
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x276B3BC", Offset = "0x276B3BC", VA = "0x276B3BC")]
	public ES2_Vector3()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x276DFA8", Offset = "0x276DFA8", VA = "0x276DFA8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x276E088", Offset = "0x276E088", VA = "0x276E088", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000056")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B1A0", Offset = "0xB9B1A0")]
public sealed class ES2_Vector4 : ES2Type
{
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x276B578", Offset = "0x276B578", VA = "0x276B578")]
	public ES2_Vector4()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x276E148", Offset = "0x276E148", VA = "0x276E148", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x276E24C", Offset = "0x276E24C", VA = "0x276E24C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000057")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B1B4", Offset = "0xB9B1B4")]
public sealed class ES2_BoxCollider : ES2Type
{
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x2767AB8", Offset = "0x2767AB8", VA = "0x2767AB8")]
	public ES2_BoxCollider()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x2767B4C", Offset = "0x2767B4C", VA = "0x2767B4C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x2767C60", Offset = "0x2767C60", VA = "0x2767C60", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x2767CD8", Offset = "0x2767CD8", VA = "0x2767CD8", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000058")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B1C8", Offset = "0xB9B1C8")]
public sealed class ES2_CapsuleCollider : ES2Type
{
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x2767E30", Offset = "0x2767E30", VA = "0x2767E30")]
	public ES2_CapsuleCollider()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x2767EC4", Offset = "0x2767EC4", VA = "0x2767EC4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x276803C", Offset = "0x276803C", VA = "0x276803C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x27680B4", Offset = "0x27680B4", VA = "0x27680B4", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000059")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B1DC", Offset = "0xB9B1DC")]
public sealed class ES2_MeshCollider : ES2Type
{
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x276B60C", Offset = "0x276B60C", VA = "0x276B60C")]
	public ES2_MeshCollider()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x276B6A0", Offset = "0x276B6A0", VA = "0x276B6A0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x276B7EC", Offset = "0x276B7EC", VA = "0x276B7EC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x276B864", Offset = "0x276B864", VA = "0x276B864", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B1F0", Offset = "0xB9B1F0")]
public sealed class ES2_PolygonCollider2D : ES2Type
{
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x276BA00", Offset = "0x276BA00", VA = "0x276BA00")]
	public ES2_PolygonCollider2D()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x276BA94", Offset = "0x276BA94", VA = "0x276BA94", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x276BC30", Offset = "0x276BC30", VA = "0x276BC30", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x276BCA8", Offset = "0x276BCA8", VA = "0x276BCA8", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B204", Offset = "0xB9B204")]
public sealed class ES2_SkinnedMeshRenderer : ES2Type
{
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x276C398", Offset = "0x276C398", VA = "0x276C398")]
	public ES2_SkinnedMeshRenderer()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x276C42C", Offset = "0x276C42C", VA = "0x276C42C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x276C628", Offset = "0x276C628", VA = "0x276C628", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x276C6A0", Offset = "0x276C6A0", VA = "0x276C6A0", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B218", Offset = "0xB9B218")]
public sealed class ES2_SphereCollider : ES2Type
{
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x276C8FC", Offset = "0x276C8FC", VA = "0x276C8FC")]
	public ES2_SphereCollider()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x276C990", Offset = "0x276C990", VA = "0x276C990", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x276CAB4", Offset = "0x276CAB4", VA = "0x276CAB4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x276CB2C", Offset = "0x276CB2C", VA = "0x276CB2C", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B22C", Offset = "0xB9B22C")]
public sealed class ES2_Transform : ES2Type
{
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x276DA60", Offset = "0x276DA60", VA = "0x276DA60")]
	public ES2_Transform()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x276DAF4", Offset = "0x276DAF4", VA = "0x276DAF4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x276DC38", Offset = "0x276DC38", VA = "0x276DC38", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x276DCB0", Offset = "0x276DCB0", VA = "0x276DCB0", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B240", Offset = "0xB9B240")]
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
	[Address(RVA = "0x2763E48", Offset = "0x2763E48", VA = "0x2763E48")]
	public ES2Type(Type type)
	{
	}

	[Token(Token = "0x60002CD")]
	public abstract void Write(object data, ES2Writer writer);

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x2763EB8", Offset = "0x2763EB8", VA = "0x2763EB8", Slot = "5")]
	public virtual object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x2763F84", Offset = "0x2763F84", VA = "0x2763F84", Slot = "6")]
	public virtual void Read(ES2Reader reader, object c)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x2764048", Offset = "0x2764048", VA = "0x2764048", Slot = "7")]
	public virtual void Read(ES2Reader reader, Component c)
	{
	}

	[Token(Token = "0x60002D1")]
	public static T GetOrCreate<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x2763E94", Offset = "0x2763E94", VA = "0x2763E94")]
	public static int GetHash(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x2764054", Offset = "0x2764054", VA = "0x2764054")]
	public static int GetHash(string value)
	{
		return default(int);
	}
}
[Token(Token = "0x200005F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B254", Offset = "0xB9B254")]
public static class ES2TypeManager
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<Type, ES2Type> types;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES2Type cachedType;

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x2764144", Offset = "0x2764144", VA = "0x2764144")]
	public static void AddES2Type(ES2Type es2Type)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x27641D8", Offset = "0x27641D8", VA = "0x27641D8")]
	public static ES2Type GetES2Type(Type type)
	{
		return null;
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x275F5E8", Offset = "0x275F5E8", VA = "0x275F5E8")]
	public static ES2Type GetES2Type(byte key)
	{
		return null;
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x2764494", Offset = "0x2764494", VA = "0x2764494")]
	public static ES2Type GetES2Type(ES2Keys.Key key)
	{
		return null;
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x2761294", Offset = "0x2761294", VA = "0x2761294")]
	public static ES2Type GetES2Type(int hash)
	{
		return null;
	}
}
[Token(Token = "0x2000060")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B268", Offset = "0xB9B268")]
public sealed class ES2_bool : ES2Type
{
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x276E350", Offset = "0x276E350", VA = "0x276E350")]
	public ES2_bool()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x276E3E4", Offset = "0x276E3E4", VA = "0x276E3E4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x276E47C", Offset = "0x276E47C", VA = "0x276E47C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000061")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B27C", Offset = "0xB9B27C")]
public sealed class ES2_byte : ES2Type
{
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x276E4FC", Offset = "0x276E4FC", VA = "0x276E4FC")]
	public ES2_byte()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x276E58C", Offset = "0x276E58C", VA = "0x276E58C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x276E624", Offset = "0x276E624", VA = "0x276E624", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000062")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B290", Offset = "0xB9B290")]
public sealed class ES2_char : ES2Type
{
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x276E6A0", Offset = "0x276E6A0", VA = "0x276E6A0")]
	public ES2_char()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x276E734", Offset = "0x276E734", VA = "0x276E734", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x276E7D0", Offset = "0x276E7D0", VA = "0x276E7D0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000063")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B2A4", Offset = "0xB9B2A4")]
public sealed class ES2_decimal : ES2Type
{
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x276E850", Offset = "0x276E850", VA = "0x276E850")]
	public ES2_decimal()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x276E8E4", Offset = "0x276E8E4", VA = "0x276E8E4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x276E980", Offset = "0x276E980", VA = "0x276E980", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000064")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B2B8", Offset = "0xB9B2B8")]
public sealed class ES2_double : ES2Type
{
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x276EA00", Offset = "0x276EA00", VA = "0x276EA00")]
	public ES2_double()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x276EA94", Offset = "0x276EA94", VA = "0x276EA94", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x276EB30", Offset = "0x276EB30", VA = "0x276EB30", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000065")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B2CC", Offset = "0xB9B2CC")]
public sealed class ES2_float : ES2Type
{
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x276EBAC", Offset = "0x276EBAC", VA = "0x276EBAC")]
	public ES2_float()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x276EC40", Offset = "0x276EC40", VA = "0x276EC40", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x276ECDC", Offset = "0x276ECDC", VA = "0x276ECDC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000066")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B2E0", Offset = "0xB9B2E0")]
public sealed class ES2_int : ES2Type
{
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x276B450", Offset = "0x276B450", VA = "0x276B450")]
	public ES2_int()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x276ED58", Offset = "0x276ED58", VA = "0x276ED58", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x276EDF4", Offset = "0x276EDF4", VA = "0x276EDF4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000067")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B2F4", Offset = "0xB9B2F4")]
public sealed class ES2_long : ES2Type
{
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x276EE74", Offset = "0x276EE74", VA = "0x276EE74")]
	public ES2_long()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x276EF08", Offset = "0x276EF08", VA = "0x276EF08", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x276EFA4", Offset = "0x276EFA4", VA = "0x276EFA4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000068")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B308", Offset = "0xB9B308")]
public sealed class ES2_object : ES2Type
{
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x276F024", Offset = "0x276F024", VA = "0x276F024")]
	public ES2_object()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x276F0AC", Offset = "0x276F0AC", VA = "0x276F0AC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x276F234", Offset = "0x276F234", VA = "0x276F234", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000069")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B31C", Offset = "0xB9B31C")]
public sealed class ES2_sbyte : ES2Type
{
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x276F348", Offset = "0x276F348", VA = "0x276F348")]
	public ES2_sbyte()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x276F3DC", Offset = "0x276F3DC", VA = "0x276F3DC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x276F474", Offset = "0x276F474", VA = "0x276F474", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B330", Offset = "0xB9B330")]
public sealed class ES2_short : ES2Type
{
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x276F4F0", Offset = "0x276F4F0", VA = "0x276F4F0")]
	public ES2_short()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x276F584", Offset = "0x276F584", VA = "0x276F584", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x276F620", Offset = "0x276F620", VA = "0x276F620", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B344", Offset = "0xB9B344")]
public sealed class ES2_string : ES2Type
{
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x276F6A0", Offset = "0x276F6A0", VA = "0x276F6A0")]
	public ES2_string()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x276F734", Offset = "0x276F734", VA = "0x276F734", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x276F7C0", Offset = "0x276F7C0", VA = "0x276F7C0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B358", Offset = "0xB9B358")]
public sealed class ES2_uint : ES2Type
{
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x276F7EC", Offset = "0x276F7EC", VA = "0x276F7EC")]
	public ES2_uint()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x276F880", Offset = "0x276F880", VA = "0x276F880", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x276F91C", Offset = "0x276F91C", VA = "0x276F91C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B36C", Offset = "0xB9B36C")]
public sealed class ES2_ulong : ES2Type
{
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x276F99C", Offset = "0x276F99C", VA = "0x276F99C")]
	public ES2_ulong()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x276FA30", Offset = "0x276FA30", VA = "0x276FA30", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x276FACC", Offset = "0x276FACC", VA = "0x276FACC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B380", Offset = "0xB9B380")]
public sealed class ES2_ushort : ES2Type
{
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x276FB4C", Offset = "0x276FB4C", VA = "0x276FB4C")]
	public ES2_ushort()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x276FBE0", Offset = "0x276FBE0", VA = "0x276FBE0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x276FC7C", Offset = "0x276FC7C", VA = "0x276FC7C", Slot = "5")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1AF0", Offset = "0xBA1AF0")]
	public ES2Stream stream;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1B04", Offset = "0xBA1B04")]
	public HashSet<string> tagsToDelete;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1B18", Offset = "0xBA1B18")]
	public BinaryWriter writer;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1B2C", Offset = "0xBA1B2C")]
	private long lengthPosition;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x275FB74", Offset = "0x275FB74", VA = "0x275FB74")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA340C", Offset = "0xBA340C")]
	public void Write<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x6000312")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3420", Offset = "0xBA3420")]
	public void Write<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000313")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3434", Offset = "0xBA3434")]
	public void Write<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000314")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3448", Offset = "0xBA3448")]
	public void Write<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000315")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA345C", Offset = "0xBA345C")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x6000316")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3470", Offset = "0xBA3470")]
	public void Write<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000317")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3484", Offset = "0xBA3484")]
	public void Write<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000318")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3498", Offset = "0xBA3498")]
	public void Write<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000319")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA34AC", Offset = "0xBA34AC")]
	public void Write<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x2765664", Offset = "0x2765664", VA = "0x2765664")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA34C0", Offset = "0xBA34C0")]
	public void WriteSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x2765B38", Offset = "0x2765B38", VA = "0x2765B38")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA34D4", Offset = "0xBA34D4")]
	public void WriteICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x2766098", Offset = "0x2766098", VA = "0x2766098")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA34E8", Offset = "0xBA34E8")]
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
	[Address(RVA = "0x276597C", Offset = "0x276597C", VA = "0x276597C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA34FC", Offset = "0xBA34FC")]
	private void WriteEncryptedSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x2765EDC", Offset = "0x2765EDC", VA = "0x2765EDC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3510", Offset = "0xBA3510")]
	private void WriteEncryptedICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x27664C8", Offset = "0x27664C8", VA = "0x27664C8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3524", Offset = "0xBA3524")]
	private void WriteEncryptedIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x2766894", Offset = "0x2766894", VA = "0x2766894")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3538", Offset = "0xBA3538")]
	public void WriteHeader(ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x27668BC", Offset = "0x27668BC", VA = "0x27668BC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA354C", Offset = "0xBA354C")]
	public void WriteHeader(string tag, ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x2766AB0", Offset = "0x2766AB0", VA = "0x2766AB0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3560", Offset = "0xBA3560")]
	public void WriteLength()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x2766B80", Offset = "0x2766B80", VA = "0x2766B80")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3574", Offset = "0xBA3574")]
	public void WriteTerminator()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x276668C", Offset = "0x276668C", VA = "0x276668C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3588", Offset = "0xBA3588")]
	public ES2Writer CreateEncryptedWriter()
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x2766730", Offset = "0x2766730", VA = "0x2766730")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA359C", Offset = "0xBA359C")]
	public byte[] GetEncryptedBytes(string password)
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x2766CB0", Offset = "0x2766CB0", VA = "0x2766CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x2766CBC", Offset = "0x2766CBC", VA = "0x2766CBC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA35B0", Offset = "0xBA35B0")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA35C4", Offset = "0xBA35C4")]
	public void Write<T>(T param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA35D8", Offset = "0xBA35D8")]
	public void Write<T>(T[] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA35EC", Offset = "0xBA35EC")]
	public void Write<T>(T[,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3600", Offset = "0xBA3600")]
	public void Write<T>(T[,,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033E")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3614", Offset = "0xBA3614")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x600033F")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3628", Offset = "0xBA3628")]
	public void Write<T>(List<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000340")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA363C", Offset = "0xBA363C")]
	public void Write<T>(HashSet<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000341")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3650", Offset = "0xBA3650")]
	public void Write<T>(Queue<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000342")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3664", Offset = "0xBA3664")]
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
	[Address(RVA = "0x2766E24", Offset = "0x2766E24", VA = "0x2766E24")]
	public int WritePropertyPrefix()
	{
		return default(int);
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x2766E8C", Offset = "0x2766E8C", VA = "0x2766E8C")]
	public void WritePropertyLength(int startPosition)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x2766F3C", Offset = "0x2766F3C", VA = "0x2766F3C")]
	public void Save()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x2763830", Offset = "0x2763830", VA = "0x2763830")]
	public void Save(bool checkForOverwrite)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x2767094", Offset = "0x2767094", VA = "0x2767094")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3678", Offset = "0xBA3678")]
	public void Save(byte[] bytes)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x2767220", Offset = "0x2767220", VA = "0x2767220")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA368C", Offset = "0xBA368C")]
	public bool Rename(string oldTag, string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x276737C", Offset = "0x276737C", VA = "0x276737C")]
	public void Delete(string tag)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x2766F44", Offset = "0x2766F44", VA = "0x2766F44")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA36A0", Offset = "0xBA36A0")]
	public bool Delete()
	{
		return default(bool);
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x27670C8", Offset = "0x27670C8", VA = "0x27670C8")]
	private bool Delete(byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x27673E0", Offset = "0x27673E0", VA = "0x27673E0")]
	public static ES2Writer Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x27637A4", Offset = "0x27637A4", VA = "0x27637A4")]
	public static ES2Writer Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x276743C", Offset = "0x276743C", VA = "0x276743C")]
	public static ES2Writer Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x2766BA4", Offset = "0x2766BA4", VA = "0x2766BA4")]
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
	[Address(RVA = "0x2526950", Offset = "0x2526950", VA = "0x2526950")]
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
	[Address(RVA = "0x2526958", Offset = "0x2526958", VA = "0x2526958")]
	public void Save()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x2526AD8", Offset = "0x2526AD8", VA = "0x2526AD8")]
	public void Load()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x2526BB0", Offset = "0x2526BB0", VA = "0x2526BB0")]
	private void Start()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x2526BC4", Offset = "0x2526BC4", VA = "0x2526BC4")]
	public void Awake()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x2526BD8", Offset = "0x2526BD8", VA = "0x2526BD8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x2526BEC", Offset = "0x2526BEC", VA = "0x2526BEC")]
	public void UpdateAutoSaves()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x2526C44", Offset = "0x2526C44", VA = "0x2526C44", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x2526C48", Offset = "0x2526C48", VA = "0x2526C48", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x2526C4C", Offset = "0x2526C4C", VA = "0x2526C4C")]
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
	[Address(RVA = "0x276FCFC", Offset = "0x276FCFC", VA = "0x276FCFC")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x276FEF8", Offset = "0x276FEF8", VA = "0x276FEF8")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x276FF94", Offset = "0x276FF94", VA = "0x276FF94")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x276FD88", Offset = "0x276FD88", VA = "0x276FD88")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x2770038", Offset = "0x2770038", VA = "0x2770038")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x2770160", Offset = "0x2770160", VA = "0x2770160")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x27701FC", Offset = "0x27701FC", VA = "0x27701FC")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x27700C4", Offset = "0x27700C4", VA = "0x27700C4")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x27702A0", Offset = "0x27702A0", VA = "0x27702A0")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x27704D4", Offset = "0x27704D4", VA = "0x27704D4")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x277032C", Offset = "0x277032C", VA = "0x277032C")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x2770578", Offset = "0x2770578", VA = "0x2770578")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x27707D0", Offset = "0x27707D0", VA = "0x27707D0")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x2770604", Offset = "0x2770604", VA = "0x2770604")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x2770874", Offset = "0x2770874", VA = "0x2770874")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x2770AB0", Offset = "0x2770AB0", VA = "0x2770AB0")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x2770910", Offset = "0x2770910", VA = "0x2770910")]
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
	[Address(RVA = "0x2770B54", Offset = "0x2770B54", VA = "0x2770B54")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x2770D90", Offset = "0x2770D90", VA = "0x2770D90")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x2770E1C", Offset = "0x2770E1C", VA = "0x2770E1C")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x2770BD8", Offset = "0x2770BD8", VA = "0x2770BD8")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x2770EB8", Offset = "0x2770EB8", VA = "0x2770EB8")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x2770FCC", Offset = "0x2770FCC", VA = "0x2770FCC")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x2771058", Offset = "0x2771058", VA = "0x2771058")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x2770F3C", Offset = "0x2770F3C", VA = "0x2770F3C")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x27710F4", Offset = "0x27710F4", VA = "0x27710F4")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x27711E4", Offset = "0x27711E4", VA = "0x27711E4")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x2771180", Offset = "0x2771180", VA = "0x2771180")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x2771280", Offset = "0x2771280", VA = "0x2771280")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x27712F4", Offset = "0x27712F4", VA = "0x27712F4")]
	public static AudioClip LoadAudio(string audioFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x2771380", Offset = "0x2771380", VA = "0x2771380")]
	public static AudioClip LoadAudio(string audioFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x2771658", Offset = "0x2771658", VA = "0x2771658")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x27717B4", Offset = "0x27717B4", VA = "0x27717B4")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x2771840", Offset = "0x2771840", VA = "0x2771840")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x27716DC", Offset = "0x27716DC", VA = "0x27716DC")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x27718DC", Offset = "0x27718DC", VA = "0x27718DC")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x2771AD8", Offset = "0x2771AD8", VA = "0x2771AD8")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x2771990", Offset = "0x2771990", VA = "0x2771990")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x2771BA4", Offset = "0x2771BA4", VA = "0x2771BA4")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x2771DB4", Offset = "0x2771DB4", VA = "0x2771DB4")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x2771C58", Offset = "0x2771C58", VA = "0x2771C58")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x2771E80", Offset = "0x2771E80", VA = "0x2771E80")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x2771FE8", Offset = "0x2771FE8", VA = "0x2771FE8")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x2771F0C", Offset = "0x2771F0C", VA = "0x2771F0C")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x2772084", Offset = "0x2772084", VA = "0x2772084")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x277230C", Offset = "0x277230C", VA = "0x277230C")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x27723A8", Offset = "0x27723A8", VA = "0x27723A8")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x2772110", Offset = "0x2772110", VA = "0x2772110")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x2772558", Offset = "0x2772558", VA = "0x2772558")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x277274C", Offset = "0x277274C", VA = "0x277274C")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x27727E8", Offset = "0x27727E8", VA = "0x27727E8")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x27725E4", Offset = "0x27725E4", VA = "0x27725E4")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x277288C", Offset = "0x277288C", VA = "0x277288C")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x2772910", Offset = "0x2772910", VA = "0x2772910")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x277299C", Offset = "0x277299C", VA = "0x277299C")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x277244C", Offset = "0x277244C", VA = "0x277244C")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x2772A38", Offset = "0x2772A38", VA = "0x2772A38")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x2772BA4", Offset = "0x2772BA4", VA = "0x2772BA4")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x2772AC4", Offset = "0x2772AC4", VA = "0x2772AC4")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x2772C40", Offset = "0x2772C40", VA = "0x2772C40")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x27730C8", Offset = "0x27730C8", VA = "0x27730C8")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x2773154", Offset = "0x2773154", VA = "0x2773154")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x2772CC4", Offset = "0x2772CC4", VA = "0x2772CC4")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x27731F0", Offset = "0x27731F0", VA = "0x27731F0")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x2773300", Offset = "0x2773300", VA = "0x2773300")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x277338C", Offset = "0x277338C", VA = "0x277338C")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x2773274", Offset = "0x2773274", VA = "0x2773274")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x2773428", Offset = "0x2773428", VA = "0x2773428")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x2773538", Offset = "0x2773538", VA = "0x2773538")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x27735C4", Offset = "0x27735C4", VA = "0x27735C4")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x27734AC", Offset = "0x27734AC", VA = "0x27734AC")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x2773660", Offset = "0x2773660", VA = "0x2773660")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x27737AC", Offset = "0x27737AC", VA = "0x27737AC")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x2773838", Offset = "0x2773838", VA = "0x2773838")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x27736E4", Offset = "0x27736E4", VA = "0x27736E4")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x27738D4", Offset = "0x27738D4", VA = "0x27738D4")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x2773A5C", Offset = "0x2773A5C", VA = "0x2773A5C")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x2773960", Offset = "0x2773960", VA = "0x2773960")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x2773AF8", Offset = "0x2773AF8", VA = "0x2773AF8")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x2773CAC", Offset = "0x2773CAC", VA = "0x2773CAC")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x2773D38", Offset = "0x2773D38", VA = "0x2773D38")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x2773B7C", Offset = "0x2773B7C", VA = "0x2773B7C")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x2773DD4", Offset = "0x2773DD4", VA = "0x2773DD4")]
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
	[Address(RVA = "0x252B9D4", Offset = "0x252B9D4", VA = "0x252B9D4")]
	public ES3File()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x252BEB8", Offset = "0x252BEB8", VA = "0x252BEB8")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x252BF34", Offset = "0x252BF34", VA = "0x252BF34")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x252BFAC", Offset = "0x252BFAC", VA = "0x252BFAC")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x252BFB4", Offset = "0x252BFB4", VA = "0x252BFB4")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x252C020", Offset = "0x252C020", VA = "0x252C020")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x252C0A0", Offset = "0x252C0A0", VA = "0x252C0A0")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x252BA34", Offset = "0x252BA34", VA = "0x252BA34")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x252C220", Offset = "0x252C220", VA = "0x252C220")]
	public ES3File(byte[] bytes)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x252C28C", Offset = "0x252C28C", VA = "0x252C28C")]
	public ES3File(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x252C75C", Offset = "0x252C75C", VA = "0x252C75C")]
	public void Sync()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x252CAF0", Offset = "0x252CAF0", VA = "0x252CAF0")]
	public void Sync(string filePath)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x252CB68", Offset = "0x252CB68", VA = "0x252CB68")]
	public void Sync(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x252C764", Offset = "0x252C764", VA = "0x252C764")]
	public void Sync(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x252CBDC", Offset = "0x252CBDC", VA = "0x252CBDC")]
	public void Clear()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x252CC30", Offset = "0x252CC30", VA = "0x252CC30")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	public void Save<T>(string key, object value)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x252CD00", Offset = "0x252CD00", VA = "0x252CD00")]
	public void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x252C340", Offset = "0x252C340", VA = "0x252C340")]
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
	[Address(RVA = "0x2527A68", Offset = "0x2527A68", VA = "0x2527A68")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x252CDC0", Offset = "0x252CDC0", VA = "0x252CDC0")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x252CE6C", Offset = "0x252CE6C", VA = "0x252CE6C")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x252CED0", Offset = "0x252CED0", VA = "0x252CED0")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x252CF34", Offset = "0x252CF34", VA = "0x252CF34")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x252D060", Offset = "0x252D060", VA = "0x252D060")]
	public Type GetKeyType(string key)
	{
		return null;
	}
}
[Token(Token = "0x200007B")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x252E4A0", Offset = "0x252E4A0", VA = "0x252E4A0")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x200007C")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase, ISerializationCallbackReceiver
{
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x2534CE8", Offset = "0x2534CE8", VA = "0x2534CE8", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x2534CEC", Offset = "0x2534CEC", VA = "0x2534CEC", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x2534CF0", Offset = "0x2534CF0", VA = "0x2534CF0")]
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
		[Address(RVA = "0x2FFA118", Offset = "0x2FFA118", VA = "0x2FFA118")]
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
		[Address(RVA = "0x25387AC", Offset = "0x25387AC", VA = "0x25387AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000048")]
	public int RowCount
	{
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x25387B4", Offset = "0x25387B4", VA = "0x25387B4")]
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
	[Address(RVA = "0x25387BC", Offset = "0x25387BC", VA = "0x25387BC")]
	private void SetCell(int col, int row, string value)
	{
	}

	[Token(Token = "0x60003EA")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x253887C", Offset = "0x253887C", VA = "0x253887C")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x2538BBC", Offset = "0x2538BBC", VA = "0x2538BBC")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x25388F4", Offset = "0x25388F4", VA = "0x25388F4")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x2538C30", Offset = "0x2538C30", VA = "0x2538C30")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x2539000", Offset = "0x2539000", VA = "0x2539000")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x2539078", Offset = "0x2539078", VA = "0x2539078")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x2539080", Offset = "0x2539080", VA = "0x2539080")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x2539100", Offset = "0x2539100", VA = "0x2539100")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x2538CAC", Offset = "0x2538CAC", VA = "0x2538CAC")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x2539340", Offset = "0x2539340", VA = "0x2539340")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x253945C", Offset = "0x253945C", VA = "0x253945C")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x2539184", Offset = "0x2539184", VA = "0x2539184")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x2539540", Offset = "0x2539540", VA = "0x2539540")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x200007F")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B394", Offset = "0xB9B394")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B3A8", Offset = "0xB9B3A8")]
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
				[Address(RVA = "0x2FFC13C", Offset = "0x2FFC13C", VA = "0x2FFC13C", Slot = "4")]
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
				[Address(RVA = "0x2FFC184", Offset = "0x2FFC184", VA = "0x2FFC184", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2FF9944", Offset = "0x2FF9944", VA = "0x2FF9944")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2FFC084", Offset = "0x2FFC084", VA = "0x2FFC084", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x2FFC088", Offset = "0x2FFC088", VA = "0x2FFC088", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x2FFC144", Offset = "0x2FFC144", VA = "0x2FFC144", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2FF9898", Offset = "0x2FF9898", VA = "0x2FF9898")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2FF98CC", Offset = "0x2FF98CC", VA = "0x2FF98CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA372C", Offset = "0xBA372C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B3B8", Offset = "0xB9B3B8")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B3CC", Offset = "0xB9B3CC")]
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
				[Address(RVA = "0x2FFC308", Offset = "0x2FFC308", VA = "0x2FFC308", Slot = "4")]
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
				[Address(RVA = "0x2FFC350", Offset = "0x2FFC350", VA = "0x2FFC350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x2FF9A1C", Offset = "0x2FF9A1C", VA = "0x2FF9A1C")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x2FFC18C", Offset = "0x2FFC18C", VA = "0x2FFC18C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2FFC190", Offset = "0x2FFC190", VA = "0x2FFC190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x2FFC310", Offset = "0x2FFC310", VA = "0x2FFC310", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2FF9970", Offset = "0x2FF9970", VA = "0x2FF9970")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2FF99A4", Offset = "0x2FF99A4", VA = "0x2FF99A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA37DC", Offset = "0xBA37DC")]
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
		[Address(RVA = "0x2533FDC", Offset = "0x2533FDC", VA = "0x2533FDC", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004A")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x253403C", Offset = "0x253403C", VA = "0x253403C", Slot = "39")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA36B4", Offset = "0xBA36B4")]
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
	[Address(RVA = "0x252E5F8", Offset = "0x252E5F8", VA = "0x252E5F8")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x253409C", Offset = "0x253409C", VA = "0x253409C", Slot = "40")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA36C8", Offset = "0xBA36C8")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA36DC", Offset = "0xBA36DC")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000422")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA36F0", Offset = "0xBA36F0")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x25340B0", Offset = "0x25340B0", VA = "0x25340B0")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x25341C0", Offset = "0x25341C0", VA = "0x25341C0")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x25343F8", Offset = "0x25343F8", VA = "0x25343F8")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3704", Offset = "0xBA3704")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600042C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3718", Offset = "0xBA3718")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x600042D")]
	private Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x2534638", Offset = "0x2534638", VA = "0x2534638")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x253468C", Offset = "0x253468C", VA = "0x253468C")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x25346F4", Offset = "0x25346F4", VA = "0x25346F4")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x252C188", Offset = "0x252C188", VA = "0x252C188")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x2534AF8", Offset = "0x2534AF8", VA = "0x2534AF8")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x252CD08", Offset = "0x252CD08", VA = "0x252CD08")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x2534B54", Offset = "0x2534B54", VA = "0x2534B54")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x2534BDC", Offset = "0x2534BDC", VA = "0x2534BDC")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1B50", Offset = "0xBA1B50")]
	public bool typeChecking;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1B64", Offset = "0xBA1B64")]
	public bool safeReflection;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1B78", Offset = "0xBA1B78")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1B8C", Offset = "0xBA1B8C")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA1BA0", Offset = "0xBA1BA0")]
	public string[] assemblyNames;

	[Token(Token = "0x1700004F")]
	public ES3.Location location
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x252E110", Offset = "0x252E110", VA = "0x252E110")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2538314", Offset = "0x2538314", VA = "0x2538314")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public string FullPath
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x252E150", Offset = "0x252E150", VA = "0x252E150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x253831C", Offset = "0x253831C", VA = "0x253831C")]
	private void CopyInto(ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x2527048", Offset = "0x2527048", VA = "0x2527048")]
	public ES3Settings()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x25271EC", Offset = "0x25271EC", VA = "0x25271EC")]
	public ES3Settings(string path)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x25273D4", Offset = "0x25273D4", VA = "0x25273D4")]
	public ES3Settings(string path, ES3Settings settings)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x2538474", Offset = "0x2538474", VA = "0x2538474")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x25384B4", Offset = "0x25384B4", VA = "0x25384B4")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x2538508", Offset = "0x2538508", VA = "0x2538508")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, ES3Settings settings)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x2538244", Offset = "0x2538244", VA = "0x2538244")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA388C", Offset = "0xBA388C")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x25383C0", Offset = "0x25383C0", VA = "0x25383C0")]
	protected void ApplyDefaults()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x253854C", Offset = "0x253854C", VA = "0x253854C")]
	internal static void LoadDefaults()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x2538720", Offset = "0x2538720", VA = "0x2538720")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x252C124", Offset = "0x252C124", VA = "0x252C124", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA38A0", Offset = "0xBA38A0")]
	public object Clone()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000085")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9B3DC", Offset = "0xB9B3DC")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x6000456")]
	[Address(RVA = "0x25381E0", Offset = "0x25381E0", VA = "0x25381E0")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x25382A4", Offset = "0x25382A4", VA = "0x25382A4")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}
}
[Token(Token = "0x2000086")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B3F0", Offset = "0xB9B3F0")]
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
			[Address(RVA = "0x2FF93D0", Offset = "0x2FF93D0", VA = "0x2FF93D0", Slot = "4")]
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
			[Address(RVA = "0x2FF9418", Offset = "0x2FF9418", VA = "0x2FF9418", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2FF9218", Offset = "0x2FF9218", VA = "0x2FF9218")]
		[DebuggerHidden]
		public <Sync>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2FF9244", Offset = "0x2FF9244", VA = "0x2FF9244", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2FF9248", Offset = "0x2FF9248", VA = "0x2FF9248", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2FF93D8", Offset = "0x2FF93D8", VA = "0x2FF93D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B400", Offset = "0xB9B400")]
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
			[Address(RVA = "0x2FF9848", Offset = "0x2FF9848", VA = "0x2FF9848", Slot = "4")]
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
			[Address(RVA = "0x2FF9890", Offset = "0x2FF9890", VA = "0x2FF9890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2FF9420", Offset = "0x2FF9420", VA = "0x2FF9420")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2FF944C", Offset = "0x2FF944C", VA = "0x2FF944C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2FF9524", Offset = "0x2FF9524", VA = "0x2FF9524", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2FF9468", Offset = "0x2FF9468", VA = "0x2FF9468")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2FF9850", Offset = "0x2FF9850", VA = "0x2FF9850", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B410", Offset = "0xB9B410")]
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
			[Address(RVA = "0x2FF81C4", Offset = "0x2FF81C4", VA = "0x2FF81C4", Slot = "4")]
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
			[Address(RVA = "0x2FF820C", Offset = "0x2FF820C", VA = "0x2FF820C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2FF7D50", Offset = "0x2FF7D50", VA = "0x2FF7D50")]
		[DebuggerHidden]
		public <DownloadFile>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2FF7D7C", Offset = "0x2FF7D7C", VA = "0x2FF7D7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2FF7E54", Offset = "0x2FF7E54", VA = "0x2FF7E54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2FF7D98", Offset = "0x2FF7D98", VA = "0x2FF7D98")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2FF81CC", Offset = "0x2FF81CC", VA = "0x2FF81CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B420", Offset = "0xB9B420")]
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
			[Address(RVA = "0x2FF8684", Offset = "0x2FF8684", VA = "0x2FF8684", Slot = "4")]
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
			[Address(RVA = "0x2FF86CC", Offset = "0x2FF86CC", VA = "0x2FF86CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2FF8214", Offset = "0x2FF8214", VA = "0x2FF8214")]
		[DebuggerHidden]
		public <DownloadFile>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2FF8240", Offset = "0x2FF8240", VA = "0x2FF8240", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2FF8318", Offset = "0x2FF8318", VA = "0x2FF8318", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2FF825C", Offset = "0x2FF825C", VA = "0x2FF825C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2FF868C", Offset = "0x2FF868C", VA = "0x2FF868C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B430", Offset = "0xB9B430")]
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
			[Address(RVA = "0x2FF7D00", Offset = "0x2FF7D00", VA = "0x2FF7D00", Slot = "4")]
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
			[Address(RVA = "0x2FF7D48", Offset = "0x2FF7D48", VA = "0x2FF7D48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2FF79D4", Offset = "0x2FF79D4", VA = "0x2FF79D4")]
		[DebuggerHidden]
		public <DeleteFile>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2FF7A00", Offset = "0x2FF7A00", VA = "0x2FF7A00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2FF7AD8", Offset = "0x2FF7AD8", VA = "0x2FF7AD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2FF7A1C", Offset = "0x2FF7A1C", VA = "0x2FF7A1C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2FF7D08", Offset = "0x2FF7D08", VA = "0x2FF7D08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B440", Offset = "0xB9B440")]
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
			[Address(RVA = "0x2FF91C8", Offset = "0x2FF91C8", VA = "0x2FF91C8", Slot = "4")]
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
			[Address(RVA = "0x2FF9210", Offset = "0x2FF9210", VA = "0x2FF9210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2FF8E60", Offset = "0x2FF8E60", VA = "0x2FF8E60")]
		[DebuggerHidden]
		public <RenameFile>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2FF8E8C", Offset = "0x2FF8E8C", VA = "0x2FF8E8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2FF8F64", Offset = "0x2FF8F64", VA = "0x2FF8F64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2FF8EA8", Offset = "0x2FF8EA8", VA = "0x2FF8EA8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2FF91D0", Offset = "0x2FF91D0", VA = "0x2FF91D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B450", Offset = "0xB9B450")]
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
			[Address(RVA = "0x2FF8A4C", Offset = "0x2FF8A4C", VA = "0x2FF8A4C", Slot = "4")]
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
			[Address(RVA = "0x2FF8A94", Offset = "0x2FF8A94", VA = "0x2FF8A94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2FF86D4", Offset = "0x2FF86D4", VA = "0x2FF86D4")]
		[DebuggerHidden]
		public <DownloadFilenames>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2FF8700", Offset = "0x2FF8700", VA = "0x2FF8700", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2FF87D8", Offset = "0x2FF87D8", VA = "0x2FF87D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2FF871C", Offset = "0x2FF871C", VA = "0x2FF871C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2FF8A54", Offset = "0x2FF8A54", VA = "0x2FF8A54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B460", Offset = "0xB9B460")]
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
			[Address(RVA = "0x2FF8E10", Offset = "0x2FF8E10", VA = "0x2FF8E10", Slot = "4")]
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
			[Address(RVA = "0x2FF8E58", Offset = "0x2FF8E58", VA = "0x2FF8E58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2FF8A9C", Offset = "0x2FF8A9C", VA = "0x2FF8A9C")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2FF8AC8", Offset = "0x2FF8AC8", VA = "0x2FF8AC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2FF8BA0", Offset = "0x2FF8BA0", VA = "0x2FF8BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2FF8AE4", Offset = "0x2FF8AE4", VA = "0x2FF8AE4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2FF8E18", Offset = "0x2FF8E18", VA = "0x2FF8E18", Slot = "8")]
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
		[Address(RVA = "0x2526D44", Offset = "0x2526D44", VA = "0x2526D44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000052")]
	public string text
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2526D4C", Offset = "0x2526D4C", VA = "0x2526D4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public string[] filenames
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2526D80", Offset = "0x2526D80", VA = "0x2526D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000054")]
	public DateTime timestamp
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2526E4C", Offset = "0x2526E4C", VA = "0x2526E4C")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x2526CF0", Offset = "0x2526CF0", VA = "0x2526CF0")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x2526FD0", Offset = "0x2526FD0", VA = "0x2526FD0")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x2527158", Offset = "0x2527158", VA = "0x2527158")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x252721C", Offset = "0x252721C", VA = "0x252721C")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x25272B4", Offset = "0x25272B4", VA = "0x25272B4")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x2527344", Offset = "0x2527344", VA = "0x2527344")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x2527448", Offset = "0x2527448", VA = "0x2527448")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x25274E4", Offset = "0x25274E4", VA = "0x25274E4")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x2527094", Offset = "0x2527094", VA = "0x2527094")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA38B4", Offset = "0xBA38B4")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x2527570", Offset = "0x2527570", VA = "0x2527570")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x2527680", Offset = "0x2527680", VA = "0x2527680")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x2527714", Offset = "0x2527714", VA = "0x2527714")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x25277AC", Offset = "0x25277AC", VA = "0x25277AC")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x252783C", Offset = "0x252783C", VA = "0x252783C")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x25278CC", Offset = "0x25278CC", VA = "0x25278CC")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x2527968", Offset = "0x2527968", VA = "0x2527968")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x25279F4", Offset = "0x25279F4", VA = "0x25279F4")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x2528018", Offset = "0x2528018", VA = "0x2528018")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x2528090", Offset = "0x2528090", VA = "0x2528090")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x25275E8", Offset = "0x25275E8", VA = "0x25275E8")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x2527F40", Offset = "0x2527F40", VA = "0x2527F40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA3914", Offset = "0xBA3914")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x25280E4", Offset = "0x25280E4", VA = "0x25280E4")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x252822C", Offset = "0x252822C", VA = "0x252822C")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x25282C4", Offset = "0x25282C4", VA = "0x25282C4")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x2528360", Offset = "0x2528360", VA = "0x2528360")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x25283F4", Offset = "0x25283F4", VA = "0x25283F4")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x2528488", Offset = "0x2528488", VA = "0x2528488")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x2528528", Offset = "0x2528528", VA = "0x2528528")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x25285B8", Offset = "0x25285B8", VA = "0x25285B8")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x25286E8", Offset = "0x25286E8", VA = "0x25286E8")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x2528750", Offset = "0x2528750", VA = "0x2528750")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x252861C", Offset = "0x252861C", VA = "0x252861C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA3974", Offset = "0xBA3974")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x2528160", Offset = "0x2528160", VA = "0x2528160")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA39D4", Offset = "0xBA39D4")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x2528758", Offset = "0x2528758", VA = "0x2528758")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x2528894", Offset = "0x2528894", VA = "0x2528894")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x2528928", Offset = "0x2528928", VA = "0x2528928")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x25289C0", Offset = "0x25289C0", VA = "0x25289C0")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x2528A50", Offset = "0x2528A50", VA = "0x2528A50")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x2528AE0", Offset = "0x2528AE0", VA = "0x2528AE0")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x2528B7C", Offset = "0x2528B7C", VA = "0x2528B7C")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x25287D0", Offset = "0x25287D0", VA = "0x25287D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA3A34", Offset = "0xBA3A34")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x2528C08", Offset = "0x2528C08", VA = "0x2528C08")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x2528DA4", Offset = "0x2528DA4", VA = "0x2528DA4")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x2528E6C", Offset = "0x2528E6C", VA = "0x2528E6C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x2528F2C", Offset = "0x2528F2C", VA = "0x2528F2C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x2528FE4", Offset = "0x2528FE4", VA = "0x2528FE4")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x25290A8", Offset = "0x25290A8", VA = "0x25290A8")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x2528CCC", Offset = "0x2528CCC", VA = "0x2528CCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA3A94", Offset = "0xBA3A94")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x252915C", Offset = "0x252915C", VA = "0x252915C")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x2529254", Offset = "0x2529254", VA = "0x2529254")]
	public IEnumerator DownloadFilenames(string user)
	{
		return null;
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x25291AC", Offset = "0x25291AC", VA = "0x25291AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA3AF4", Offset = "0xBA3AF4")]
	public IEnumerator DownloadFilenames(string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x25292B0", Offset = "0x25292B0", VA = "0x25292B0")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x25293EC", Offset = "0x25293EC", VA = "0x25293EC")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x2529480", Offset = "0x2529480", VA = "0x2529480")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x2529518", Offset = "0x2529518", VA = "0x2529518")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x25295A8", Offset = "0x25295A8", VA = "0x25295A8")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x2529638", Offset = "0x2529638", VA = "0x2529638")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x25296D4", Offset = "0x25296D4", VA = "0x25296D4")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x2529328", Offset = "0x2529328", VA = "0x2529328")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA3B54", Offset = "0xBA3B54")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x2529760", Offset = "0x2529760", VA = "0x2529760")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x2529870", Offset = "0x2529870", VA = "0x2529870")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x25298DC", Offset = "0x25298DC", VA = "0x25298DC", Slot = "4")]
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
	[Address(RVA = "0x25723B0", Offset = "0x25723B0", VA = "0x25723B0")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x60004F4")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x2572480", Offset = "0x2572480", VA = "0x2572480", Slot = "40")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x25725E0", Offset = "0x25725E0", VA = "0x25725E0", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3E34", Offset = "0xBA3E34")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x2572708", Offset = "0x2572708", VA = "0x2572708", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3E48", Offset = "0xBA3E48")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x25727D4", Offset = "0x25727D4", VA = "0x25727D4", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3E5C", Offset = "0xBA3E5C")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x2572A44", Offset = "0x2572A44", VA = "0x2572A44", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x2572BC8", Offset = "0x2572BC8", VA = "0x2572BC8", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x2572C18", Offset = "0x2572C18", VA = "0x2572C18", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x2572C68", Offset = "0x2572C68", VA = "0x2572C68", Slot = "47")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3E70", Offset = "0xBA3E70")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x2572CC8", Offset = "0x2572CC8", VA = "0x2572CC8", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3E84", Offset = "0xBA3E84")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60004FE")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x256DD5C", Offset = "0x256DD5C", VA = "0x256DD5C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3E98", Offset = "0xBA3E98")]
	public void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x2572D20", Offset = "0x2572D20", VA = "0x2572D20")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x2572F30", Offset = "0x2572F30", VA = "0x2572F30")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x2573140", Offset = "0x2573140", VA = "0x2573140")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3EAC", Offset = "0xBA3EAC")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x2573308", Offset = "0x2573308", VA = "0x2573308")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3EC0", Offset = "0xBA3EC0")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x25734D0", Offset = "0x25734D0", VA = "0x25734D0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3ED4", Offset = "0xBA3ED4")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x25736C8", Offset = "0x25736C8", VA = "0x25736C8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3EE8", Offset = "0xBA3EE8")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x2572540", Offset = "0x2572540", VA = "0x2572540")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3EFC", Offset = "0xBA3EFC")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x25738C0", Offset = "0x25738C0", VA = "0x25738C0")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x257393C", Offset = "0x257393C", VA = "0x257393C")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x257394C", Offset = "0x257394C", VA = "0x257394C")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x25739AC", Offset = "0x25739AC", VA = "0x25739AC")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x2573B30", Offset = "0x2573B30", VA = "0x2573B30", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA3F10", Offset = "0xBA3F10")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x2573B94", Offset = "0x2573B94", VA = "0x2573B94")]
	protected void Merge()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x2573CE0", Offset = "0x2573CE0", VA = "0x2573CE0")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x2574008", Offset = "0x2574008", VA = "0x2574008", Slot = "51")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x257401C", Offset = "0x257401C", VA = "0x257401C", Slot = "52")]
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
			[Address(RVA = "0x22BE9C8", Offset = "0x22BE9C8", VA = "0x22BE9C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x22BEB14", Offset = "0x22BEB14", VA = "0x22BEB14")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x22BEB2C", Offset = "0x22BEB2C", VA = "0x22BEB2C")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x22BEB48", Offset = "0x22BEB48", VA = "0x22BEB48")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x22BF198", Offset = "0x22BF198", VA = "0x22BF198")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x22BF34C", Offset = "0x22BF34C", VA = "0x22BF34C")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B470", Offset = "0xB9B470")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB9B470", Offset = "0xB9B470")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B4E0", Offset = "0xB9B4E0")]
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
				[Address(RVA = "0x257FD94", Offset = "0x257FD94", VA = "0x257FD94", Slot = "4")]
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
				[Address(RVA = "0x257FDDC", Offset = "0x257FDDC", VA = "0x257FDDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x257FCBC", Offset = "0x257FCBC", VA = "0x257FCBC")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x257FCE8", Offset = "0x257FCE8", VA = "0x257FCE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x257FCEC", Offset = "0x257FCEC", VA = "0x257FCEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x257FD9C", Offset = "0x257FD9C", VA = "0x257FD9C", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1BB4", Offset = "0xBA1BB4")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1BC4", Offset = "0xBA1BC4")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1BD4", Offset = "0xBA1BD4")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000066")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x22BF418", Offset = "0x22BF418", VA = "0x22BF418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA3F24", Offset = "0xBA3F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x22BF420", Offset = "0x22BF420", VA = "0x22BF420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA3F34", Offset = "0xBA3F34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x22BF428", Offset = "0x22BF428", VA = "0x22BF428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA3F44", Offset = "0xBA3F44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x22BF430", Offset = "0x22BF430", VA = "0x22BF430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA3F54", Offset = "0xBA3F54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x22BF438", Offset = "0x22BF438", VA = "0x22BF438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA3F64", Offset = "0xBA3F64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x22BF440", Offset = "0x22BF440", VA = "0x22BF440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA3F74", Offset = "0xBA3F74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool visible
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x22BF448", Offset = "0x22BF448", VA = "0x22BF448")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x22BF464", Offset = "0x22BF464", VA = "0x22BF464")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int sortingLayerID
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x22BF484", Offset = "0x22BF484", VA = "0x22BF484")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x22BF4A0", Offset = "0x22BF4A0", VA = "0x22BF4A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public int sortingOrder
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x22BF4BC", Offset = "0x22BF4BC", VA = "0x22BF4BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x22BF4D8", Offset = "0x22BF4D8", VA = "0x22BF4D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x22BF4F4", Offset = "0x22BF4F4", VA = "0x22BF4F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x22BFE38", Offset = "0x22BFE38", VA = "0x22BFE38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x22BFE40", Offset = "0x22BFE40", VA = "0x22BFE40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x22C1168", Offset = "0x22C1168", VA = "0x22C1168")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x22C1204", Offset = "0x22C1204", VA = "0x22C1204")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x22BF504", Offset = "0x22BF504", VA = "0x22BF504")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x22BF5F0", Offset = "0x22BF5F0", VA = "0x22BF5F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA3F84", Offset = "0xBA3F84")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x22BF668", Offset = "0x22BF668", VA = "0x22BF668")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x22BF7B0", Offset = "0x22BF7B0", VA = "0x22BF7B0")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x22BFB08", Offset = "0x22BFB08", VA = "0x22BFB08")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x22BFBF4", Offset = "0x22BFBF4", VA = "0x22BFBF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x22BFCB0", Offset = "0x22BFCB0", VA = "0x22BFCB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x22BFD6C", Offset = "0x22BFD6C", VA = "0x22BFD6C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x22BFED4", Offset = "0x22BFED4", VA = "0x22BFED4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x22BFF98", Offset = "0x22BFF98", VA = "0x22BFF98")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x22C04AC", Offset = "0x22C04AC", VA = "0x22C04AC")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x22C1090", Offset = "0x22C1090", VA = "0x22C1090")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x22C1248", Offset = "0x22C1248", VA = "0x22C1248")]
		private MaterialManager.StaticProperties ComputeMaterialStaticProperties()
		{
			return default(MaterialManager.StaticProperties);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x22C0364", Offset = "0x22C0364", VA = "0x22C0364")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x22BF940", Offset = "0x22BF940", VA = "0x22BF940", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x22C1394", Offset = "0x22C1394", VA = "0x22C1394", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x22C14C0", Offset = "0x22C14C0", VA = "0x22C14C0", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x22C15EC", Offset = "0x22C15EC", VA = "0x22C15EC", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x22C1720", Offset = "0x22C1720", VA = "0x22C1720", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x22BF874", Offset = "0x22BF874", VA = "0x22BF874")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x22BFA3C", Offset = "0x22BFA3C", VA = "0x22BFA3C")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x22C1810", Offset = "0x22C1810", VA = "0x22C1810")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x22C0810", Offset = "0x22C0810", VA = "0x22C0810")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x22C1928", Offset = "0x22C1928", VA = "0x22C1928")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x22C1AA0", Offset = "0x22C1AA0", VA = "0x22C1AA0")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x22C1AAC", Offset = "0x22C1AAC", VA = "0x22C1AAC")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x22C1B2C", Offset = "0x22C1B2C", VA = "0x22C1B2C")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x22C1C14", Offset = "0x22C1C14", VA = "0x22C1C14")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x22C1ECC", Offset = "0x22C1ECC", VA = "0x22C1ECC")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B4F0", Offset = "0xB9B4F0")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA1BE4", Offset = "0xBA1BE4")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA1C30", Offset = "0xBA1C30")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA1C7C", Offset = "0xBA1C7C")]
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
			[Address(RVA = "0x22C23A0", Offset = "0x22C23A0", VA = "0x22C23A0")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x22C23A8", Offset = "0x22C23A8", VA = "0x22C23A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x22C241C", Offset = "0x22C241C", VA = "0x22C241C")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x22C2424", Offset = "0x22C2424", VA = "0x22C2424")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x22BEAC8", Offset = "0x22BEAC8", VA = "0x22BEAC8")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000076")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x22C2520", Offset = "0x22C2520", VA = "0x22C2520")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x22C07F4", Offset = "0x22C07F4", VA = "0x22C07F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public Shader beamShader
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x22C253C", Offset = "0x22C253C", VA = "0x22C253C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x22BF730", Offset = "0x22BF730", VA = "0x22BF730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public bool isHDRPExposureWeightSupported
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x22C1920", Offset = "0x22C1920", VA = "0x22C1920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x22C25F0", Offset = "0x22C25F0", VA = "0x22C25F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public static Config Instance
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x22BEA6C", Offset = "0x22BEA6C", VA = "0x22BEA6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x22C2498", Offset = "0x22C2498", VA = "0x22C2498")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x22C2544", Offset = "0x22C2544", VA = "0x22C2544")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x22C266C", Offset = "0x22C266C", VA = "0x22C266C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xBA4034", Offset = "0xBA4034")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x22C284C", Offset = "0x22C284C", VA = "0x22C284C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x22C2774", Offset = "0x22C2774", VA = "0x22C2774")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x22C2960", Offset = "0x22C2960", VA = "0x22C2960")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x22C2B20", Offset = "0x22C2B20", VA = "0x22C2B20")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x22C2CF0", Offset = "0x22C2CF0", VA = "0x22C2CF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x22C2CFC", Offset = "0x22C2CFC", VA = "0x22C2CFC")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x22C2D00", Offset = "0x22C2D00", VA = "0x22C2D00")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x22C2ECC", Offset = "0x22C2ECC", VA = "0x22C2ECC")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B528", Offset = "0xB9B528")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x40001F5")]
		public new const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x22C2FE8", Offset = "0x22C2FE8", VA = "0x22C2FE8")]
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
				[Address(RVA = "0x257692C", Offset = "0x257692C", VA = "0x257692C")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB9B560", Offset = "0xB9B560")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9B560", Offset = "0xB9B560")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA1CE8", Offset = "0xBA1CE8")]
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
			[Address(RVA = "0x22C33BC", Offset = "0x22C33BC", VA = "0x22C33BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x22C327C", Offset = "0x22C327C", VA = "0x22C327C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4044", Offset = "0xBA4044")]
			add
			{
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x22C331C", Offset = "0x22C331C", VA = "0x22C331C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4054", Offset = "0xBA4054")]
			remove
			{
			}
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x22C3048", Offset = "0x22C3048", VA = "0x22C3048")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x22C3050", Offset = "0x22C3050", VA = "0x22C3050")]
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
		[Address(RVA = "0x22C33C4", Offset = "0x22C33C4", VA = "0x22C33C4", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x22C33F8", Offset = "0x22C33F8", VA = "0x22C33F8", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x22C3478", Offset = "0x22C3478", VA = "0x22C3478", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x22C34D4", Offset = "0x22C34D4", VA = "0x22C34D4", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x22C3688", Offset = "0x22C3688", VA = "0x22C3688", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x22C3724", Offset = "0x22C3724", VA = "0x22C3724")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x22C3494", Offset = "0x22C3494", VA = "0x22C3494")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x22C38B4", Offset = "0x22C38B4", VA = "0x22C38B4")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x22C3920", Offset = "0x22C3920", VA = "0x22C3920")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4064", Offset = "0xBA4064")]
		private void <OnEnable>b__24_0()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B5F4", Offset = "0xB9B5F4")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B640", Offset = "0xB9B640")]
		private sealed class <>c
		{
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Camera> <>9__15_0;

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x2580078", Offset = "0x2580078", VA = "0x2580078")]
			public <>c()
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x2580080", Offset = "0x2580080", VA = "0x2580080")]
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
		[Address(RVA = "0x22C3928", Offset = "0x22C3928", VA = "0x22C3928", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x22C396C", Offset = "0x22C396C", VA = "0x22C396C", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x22C3974", Offset = "0x22C3974", VA = "0x22C3974")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x22C3C04", Offset = "0x22C3C04", VA = "0x22C3C04", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x22C3C94", Offset = "0x22C3C94", VA = "0x22C3C94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x22C39A4", Offset = "0x22C39A4", VA = "0x22C39A4")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x22C3D4C", Offset = "0x22C3D4C", VA = "0x22C3D4C")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x22C3E04", Offset = "0x22C3E04", VA = "0x22C3E04", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x22C3E70", Offset = "0x22C3E70", VA = "0x22C3E70")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x22C4294", Offset = "0x22C4294", VA = "0x22C4294", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x22C4298", Offset = "0x22C4298", VA = "0x22C4298", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x22C433C", Offset = "0x22C433C", VA = "0x22C433C", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x22C4340", Offset = "0x22C4340", VA = "0x22C4340", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x22C4364", Offset = "0x22C4364", VA = "0x22C4364")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x22C44E4", Offset = "0x22C44E4", VA = "0x22C44E4", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x22C46F4", Offset = "0x22C46F4", VA = "0x22C46F4")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B650", Offset = "0xB9B650")]
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
				[Address(RVA = "0x2580200", Offset = "0x2580200", VA = "0x2580200")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000084")]
			public string name
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x25802B0", Offset = "0x25802B0", VA = "0x25802B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			public Bounds bounds
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x2580394", Offset = "0x2580394", VA = "0x2580394")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x2580100", Offset = "0x2580100", VA = "0x2580100")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x2580180", Offset = "0x2580180", VA = "0x2580180")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x2580490", Offset = "0x2580490", VA = "0x2580490")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA1D30", Offset = "0xBA1D30")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HitResult m_CurrentHit;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float m_RangeMultiplier;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1D68", Offset = "0xBA1D68")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700007F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA4860", Offset = "0xBA4860")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x22C47BC", Offset = "0x22C47BC", VA = "0x22C47BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x22C47C4", Offset = "0x22C47C4", VA = "0x22C47C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x22C4818", Offset = "0x22C4818", VA = "0x22C4818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4074", Offset = "0xBA4074")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x22C4824", Offset = "0x22C4824", VA = "0x22C4824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4084", Offset = "0xBA4084")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x22C4A58", Offset = "0x22C4A58", VA = "0x22C4A58")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000082")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x22C4A6C", Offset = "0x22C4A6C", VA = "0x22C4A6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x22C2268", Offset = "0x22C2268", VA = "0x22C2268")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x22C47CC", Offset = "0x22C47CC", VA = "0x22C47CC", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x22C4810", Offset = "0x22C4810", VA = "0x22C4810", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x22C4830", Offset = "0x22C4830", VA = "0x22C4830", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x22C4890", Offset = "0x22C4890", VA = "0x22C4890", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x22C489C", Offset = "0x22C489C", VA = "0x22C489C", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x22C48F4", Offset = "0x22C48F4", VA = "0x22C48F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x22C49B0", Offset = "0x22C49B0", VA = "0x22C49B0")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x22C4AC4", Offset = "0x22C4AC4", VA = "0x22C4AC4")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x22C4B14", Offset = "0x22C4B14", VA = "0x22C4B14")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x22C4DD0", Offset = "0x22C4DD0", VA = "0x22C4DD0")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x22C50CC", Offset = "0x22C50CC", VA = "0x22C50CC")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x22C50E4", Offset = "0x22C50E4", VA = "0x22C50E4")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x22C517C", Offset = "0x22C517C", VA = "0x22C517C")]
		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x22C51F8", Offset = "0x22C51F8", VA = "0x22C51F8", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x22C551C", Offset = "0x22C551C", VA = "0x22C551C")]
		private void SetHit(ref HitResult hit)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x22C48CC", Offset = "0x22C48CC", VA = "0x22C48CC")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x22C5758", Offset = "0x22C5758", VA = "0x22C5758", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x22C55F4", Offset = "0x22C55F4", VA = "0x22C55F4")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x22C5710", Offset = "0x22C5710", VA = "0x22C5710")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x22C5964", Offset = "0x22C5964", VA = "0x22C5964")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x22C5970", Offset = "0x22C5970", VA = "0x22C5970")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB9B69C", Offset = "0xB9B69C")]
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
		[Address(RVA = "0x2574BF0", Offset = "0x2574BF0", VA = "0x2574BF0")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2574E74", Offset = "0x2574E74", VA = "0x2574E74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2575028", Offset = "0x2575028", VA = "0x2575028", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2575030", Offset = "0x2575030", VA = "0x2575030")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2575070", Offset = "0x2575070", VA = "0x2575070")]
		public EffectAbstractBase()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B6F8", Offset = "0xB9B6F8")]
	public class EffectFlicker : EffectAbstractBase
	{
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B730", Offset = "0xB9B730")]
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
				[Address(RVA = "0x2FFA5D0", Offset = "0x2FFA5D0", VA = "0x2FFA5D0", Slot = "4")]
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
				[Address(RVA = "0x2FFA618", Offset = "0x2FFA618", VA = "0x2FFA618", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x2FFA4B4", Offset = "0x2FFA4B4", VA = "0x2FFA4B4")]
			[DebuggerHidden]
			public <CoUpdate>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x2FFA4E0", Offset = "0x2FFA4E0", VA = "0x2FFA4E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2FFA4E4", Offset = "0x2FFA4E4", VA = "0x2FFA4E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x2FFA5D8", Offset = "0x2FFA5D8", VA = "0x2FFA5D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B740", Offset = "0xB9B740")]
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
				[Address(RVA = "0x2FFA464", Offset = "0x2FFA464", VA = "0x2FFA464", Slot = "4")]
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
				[Address(RVA = "0x2FFA4AC", Offset = "0x2FFA4AC", VA = "0x2FFA4AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x2FFA354", Offset = "0x2FFA354", VA = "0x2FFA354")]
			[DebuggerHidden]
			public <CoFlicker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x2FFA380", Offset = "0x2FFA380", VA = "0x2FFA380", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x2FFA384", Offset = "0x2FFA384", VA = "0x2FFA384", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x2FFA46C", Offset = "0x2FFA46C", VA = "0x2FFA46C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B750", Offset = "0xB9B750")]
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
				[Address(RVA = "0x2FFA304", Offset = "0x2FFA304", VA = "0x2FFA304", Slot = "4")]
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
				[Address(RVA = "0x2FFA34C", Offset = "0x2FFA34C", VA = "0x2FFA34C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2FFA210", Offset = "0x2FFA210", VA = "0x2FFA210")]
			[DebuggerHidden]
			public <CoChangeIntensity>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x2FFA23C", Offset = "0x2FFA23C", VA = "0x2FFA23C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x2FFA240", Offset = "0x2FFA240", VA = "0x2FFA240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x2FFA30C", Offset = "0x2FFA30C", VA = "0x2FFA30C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A7")]
		public new const string ClassName = "EffectFlicker";

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA1D78", Offset = "0xBA1D78")]
		public float frequency;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool performPauses;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA1D94", Offset = "0xBA1D94")]
		public MinMaxRangeFloat flickeringDuration;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA1DAC", Offset = "0xBA1DAC")]
		public MinMaxRangeFloat pauseDuration;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA1DC4", Offset = "0xBA1DC4")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA1DDC", Offset = "0xBA1DDC")]
		public float smoothing;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_CurrentAdditiveIntensity;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2575088", Offset = "0x2575088", VA = "0x2575088", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x25750C0", Offset = "0x25750C0", VA = "0x25750C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA4094", Offset = "0xBA4094")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2575138", Offset = "0x2575138", VA = "0x2575138")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA40F4", Offset = "0xBA40F4")]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x25751B0", Offset = "0x25751B0", VA = "0x25751B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA4154", Offset = "0xBA4154")]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x257523C", Offset = "0x257523C", VA = "0x257523C")]
		public EffectFlicker()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B760", Offset = "0xB9B760")]
	public class EffectPulse : EffectAbstractBase
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B798", Offset = "0xB9B798")]
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
				[Address(RVA = "0x2FFA714", Offset = "0x2FFA714", VA = "0x2FFA714", Slot = "4")]
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
				[Address(RVA = "0x2FFA75C", Offset = "0x2FFA75C", VA = "0x2FFA75C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x2FFA620", Offset = "0x2FFA620", VA = "0x2FFA620")]
			[DebuggerHidden]
			public <CoUpdate>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x2FFA64C", Offset = "0x2FFA64C", VA = "0x2FFA64C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x2FFA650", Offset = "0x2FFA650", VA = "0x2FFA650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x2FFA71C", Offset = "0x2FFA71C", VA = "0x2FFA71C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BF")]
		public new const string ClassName = "EffectPulse";

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA1DF4", Offset = "0xBA1DF4")]
		public float frequency;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA1E14", Offset = "0xBA1E14")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x25752EC", Offset = "0x25752EC", VA = "0x25752EC", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2575324", Offset = "0x2575324", VA = "0x2575324")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA42A4", Offset = "0xBA42A4")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x257539C", Offset = "0x257539C", VA = "0x257539C")]
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
		[Address(RVA = "0x2575DD0", Offset = "0x2575DD0", VA = "0x2575DD0")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x257600C", Offset = "0x257600C", VA = "0x257600C")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x25769A0", Offset = "0x25769A0", VA = "0x25769A0")]
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
				[Address(RVA = "0x2FFA7CC", Offset = "0x2FFA7CC", VA = "0x2FFA7CC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700008F")]
			private int noise3DID
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x2FFA7D4", Offset = "0x2FFA7D4", VA = "0x2FFA7D4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000090")]
			private int depthBlendID
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x2FFA854", Offset = "0x2FFA854", VA = "0x2FFA854")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000091")]
			private int colorGradientID
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x2FFA8D4", Offset = "0x2FFA8D4", VA = "0x2FFA8D4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000092")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x2FFA954", Offset = "0x2FFA954", VA = "0x2FFA954")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000093")]
			private int meshSkewingID
			{
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0x2FFA9D4", Offset = "0x2FFA9D4", VA = "0x2FFA9D4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000094")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0x2FFAA54", Offset = "0x2FFAA54", VA = "0x2FFAA54")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000095")]
			public int materialID
			{
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0x2FFAAD4", Offset = "0x2FFAAD4", VA = "0x2FFAAD4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x2FFAB6C", Offset = "0x2FFAB6C", VA = "0x2FFAB6C")]
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
			[Address(RVA = "0x2FFA764", Offset = "0x2FFA764", VA = "0x2FFA764")]
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
		[Address(RVA = "0x257844C", Offset = "0x257844C", VA = "0x257844C")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x25785C0", Offset = "0x25785C0", VA = "0x25785C0")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x25786CC", Offset = "0x25786CC", VA = "0x25786CC")]
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
		[Address(RVA = "0x2578B38", Offset = "0x2578B38", VA = "0x2578B38")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2578B50", Offset = "0x2578B50", VA = "0x2578B50")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2578BC4", Offset = "0x2578BC4", VA = "0x2578BC4")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2576128", Offset = "0x2576128", VA = "0x2576128")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2578C34", Offset = "0x2578C34", VA = "0x2578C34")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2578C98", Offset = "0x2578C98", VA = "0x2578C98")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2578CB4", Offset = "0x2578CB4", VA = "0x2578CB4")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2578CDC", Offset = "0x2578CDC", VA = "0x2578CDC")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2578D80", Offset = "0x2578D80", VA = "0x2578D80")]
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
			[Address(RVA = "0x2578E80", Offset = "0x2578E80", VA = "0x2578E80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000097")]
		public float maxValue
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x2578E88", Offset = "0x2578E88", VA = "0x2578E88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		public float randomValue
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x2578E90", Offset = "0x2578E90", VA = "0x2578E90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000099")]
		public Vector2 asVector2
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x2578E9C", Offset = "0x2578E9C", VA = "0x2578E9C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x2578EA4", Offset = "0x2578EA4", VA = "0x2578EA4")]
		public float GetLerpedValue(float lerp01)
		{
			return default(float);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2578EBC", Offset = "0x2578EBC", VA = "0x2578EBC")]
		public MinMaxRangeFloat(float min, float max)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class MinMaxRangeAttribute : Attribute
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1E4C", Offset = "0xBA1E4C")]
		private float <minValue>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1E5C", Offset = "0xBA1E5C")]
		private float <maxValue>k__BackingField;

		[Token(Token = "0x1700009A")]
		public float minValue
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x2578E28", Offset = "0x2578E28", VA = "0x2578E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4354", Offset = "0xBA4354")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x2578E30", Offset = "0x2578E30", VA = "0x2578E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4364", Offset = "0xBA4364")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public float maxValue
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x2578E38", Offset = "0x2578E38", VA = "0x2578E38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4374", Offset = "0xBA4374")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x2578E40", Offset = "0x2578E40", VA = "0x2578E40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4384", Offset = "0xBA4384")]
			private set
			{
			}
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x2578E48", Offset = "0x2578E48", VA = "0x2578E48")]
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
			[Address(RVA = "0x25755D8", Offset = "0x25755D8", VA = "0x25755D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x2578EC4", Offset = "0x2578EC4", VA = "0x2578EC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x2575730", Offset = "0x2575730", VA = "0x2575730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2578F64", Offset = "0x2578F64", VA = "0x2578F64")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xBA4394", Offset = "0xBA4394")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2578FBC", Offset = "0x2578FBC", VA = "0x2578FBC")]
		public static void LoadIfNeeded()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class PlatformHelper
	{
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x2579290", Offset = "0x2579290", VA = "0x2579290")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x25792A8", Offset = "0x25792A8", VA = "0x25792A8")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2579328", Offset = "0x2579328", VA = "0x2579328")]
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
			[Address(RVA = "0x2FFB248", Offset = "0x2FFB248", VA = "0x2FFB248")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x2FFB264", Offset = "0x2FFB264", VA = "0x2FFB264")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x2FFB290", Offset = "0x2FFB290", VA = "0x2FFB290")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x2FFB388", Offset = "0x2FFB388", VA = "0x2FFB388")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x2FFB3AC", Offset = "0x2FFB3AC", VA = "0x2FFB3AC")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x2FFB40C", Offset = "0x2FFB40C", VA = "0x2FFB40C")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x2FFB41C", Offset = "0x2FFB41C", VA = "0x2FFB41C")]
			public void Flip()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x2FFB438", Offset = "0x2FFB438", VA = "0x2FFB438")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x2FFB624", Offset = "0x2FFB624", VA = "0x2FFB624", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x2579330", Offset = "0x2579330", VA = "0x2579330")]
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
			[Address(RVA = "0x2579440", Offset = "0x2579440", VA = "0x2579440")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x25794F0", Offset = "0x25794F0", VA = "0x25794F0")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2579624", Offset = "0x2579624", VA = "0x2579624")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x257971C", Offset = "0x257971C", VA = "0x257971C")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x25797CC", Offset = "0x25797CC", VA = "0x25797CC")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B7B8", Offset = "0xB9B7B8")]
	[ExecuteInEditMode]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B804", Offset = "0xB9B804")]
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
				[Address(RVA = "0x2FFB794", Offset = "0x2FFB794", VA = "0x2FFB794", Slot = "4")]
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
				[Address(RVA = "0x2FFB7DC", Offset = "0x2FFB7DC", VA = "0x2FFB7DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x2FFB6EC", Offset = "0x2FFB6EC", VA = "0x2FFB6EC")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x2FFB718", Offset = "0x2FFB718", VA = "0x2FFB718", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x2FFB71C", Offset = "0x2FFB71C", VA = "0x2FFB71C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x2FFB79C", Offset = "0x2FFB79C", VA = "0x2FFB79C", Slot = "8")]
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
		[Address(RVA = "0x2579F10", Offset = "0x2579F10", VA = "0x2579F10")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2579FF0", Offset = "0x2579FF0", VA = "0x2579FF0")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x257A094", Offset = "0x257A094", VA = "0x257A094")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x257A0D8", Offset = "0x257A0D8", VA = "0x257A0D8")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x257A0EC", Offset = "0x257A0EC", VA = "0x257A0EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x257A18C", Offset = "0x257A18C", VA = "0x257A18C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x257A1E8", Offset = "0x257A1E8", VA = "0x257A1E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA43A4", Offset = "0xBA43A4")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x257A120", Offset = "0x257A120", VA = "0x257A120")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x257A260", Offset = "0x257A260", VA = "0x257A260")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public static class SpotLightHelper
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x257A268", Offset = "0x257A268", VA = "0x257A268")]
		public static float GetIntensity(Light light)
		{
			return default(float);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x257A2F8", Offset = "0x257A2F8", VA = "0x257A2F8")]
		public static float GetSpotAngle(Light light)
		{
			return default(float);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x257A388", Offset = "0x257A388", VA = "0x257A388")]
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
			[Address(RVA = "0x2FFB7E4", Offset = "0x2FFB7E4", VA = "0x2FFB7E4")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x257A418", Offset = "0x257A418", VA = "0x257A418")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
	[Token(Token = "0x20000DB")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9B824", Offset = "0xB9B824")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B824", Offset = "0xB9B824")]
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
			[Address(RVA = "0x257A4B0", Offset = "0x257A4B0", VA = "0x257A4B0")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x257A540", Offset = "0x257A540", VA = "0x257A540")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x257ACBC", Offset = "0x257ACBC", VA = "0x257ACBC")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x257A6C0", Offset = "0x257A6C0", VA = "0x257A6C0")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x257AEC8", Offset = "0x257AEC8", VA = "0x257AEC8")]
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
		[Address(RVA = "0x257B02C", Offset = "0x257B02C", VA = "0x257B02C")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x257B064", Offset = "0x257B064", VA = "0x257B064")]
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			return default(float);
		}

		[Token(Token = "0x600063B")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x257B094", Offset = "0x257B094", VA = "0x257B094")]
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
		[Address(RVA = "0x257B1CC", Offset = "0x257B1CC", VA = "0x257B1CC")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x257B2AC", Offset = "0x257B2AC", VA = "0x257B2AC")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x257B2B0", Offset = "0x257B2B0", VA = "0x257B2B0")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x257B2B8", Offset = "0x257B2B8", VA = "0x257B2B8")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x257B2C4", Offset = "0x257B2C4", VA = "0x257B2C4")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x257B2D4", Offset = "0x257B2D4", VA = "0x257B2D4")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x257B2E0", Offset = "0x257B2E0", VA = "0x257B2E0")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x257B2E8", Offset = "0x257B2E8", VA = "0x257B2E8")]
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x257B2F8", Offset = "0x257B2F8", VA = "0x257B2F8")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x257B32C", Offset = "0x257B32C", VA = "0x257B32C")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x257B358", Offset = "0x257B358", VA = "0x257B358")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x257B3B4", Offset = "0x257B3B4", VA = "0x257B3B4")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x257B3E4", Offset = "0x257B3E4", VA = "0x257B3E4")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x257B490", Offset = "0x257B490", VA = "0x257B490")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x257B4E4", Offset = "0x257B4E4", VA = "0x257B4E4")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x257B584", Offset = "0x257B584", VA = "0x257B584")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x257B5B8", Offset = "0x257B5B8", VA = "0x257B5B8")]
		public static Color ComputeComplementaryColor(this Color self, bool blackAndWhite)
		{
			return default(Color);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x257B660", Offset = "0x257B660", VA = "0x257B660")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x257AE4C", Offset = "0x257AE4C", VA = "0x257AE4C")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x257AE34", Offset = "0x257AE34", VA = "0x257AE34")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x257ADE8", Offset = "0x257ADE8", VA = "0x257ADE8")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x257B708", Offset = "0x257B708", VA = "0x257B708")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x257B72C", Offset = "0x257B72C", VA = "0x257B72C")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x257B740", Offset = "0x257B740", VA = "0x257B740")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x257B95C", Offset = "0x257B95C", VA = "0x257B95C")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x257BA40", Offset = "0x257BA40", VA = "0x257BA40")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x257B864", Offset = "0x257B864", VA = "0x257B864")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x257BA80", Offset = "0x257BA80", VA = "0x257BA80")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x257BB4C", Offset = "0x257BB4C", VA = "0x257BB4C")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x257BB50", Offset = "0x257BB50", VA = "0x257BB50")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B8C8", Offset = "0xB9B8C8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9B8C8", Offset = "0xB9B8C8")]
	[DisallowMultipleComponent]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B96C", Offset = "0xB9B96C")]
		private sealed class <>c
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<ParticleSystem> <>9__37_0;

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x2FFB8D8", Offset = "0x2FFB8D8", VA = "0x2FFB8D8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x2FFB8E0", Offset = "0x2FFB8E0", VA = "0x2FFB8E0")]
			internal void <InstantiateParticleSystem>b__37_0(ParticleSystem ps)
			{
			}
		}

		[Token(Token = "0x4000389")]
		public const string ClassName = "VolumetricDustParticles";

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA1E6C", Offset = "0xBA1E6C")]
		public float alpha;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA1E84", Offset = "0xBA1E84")]
		public float size;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA1EA4", Offset = "0xBA1EA4")]
		public float speed;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0xBA1EDC", Offset = "0xBA1EDC")]
		public MinMaxRangeFloat spawnDistanceRange;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA1EF4", Offset = "0xBA1EF4")]
		public float spawnMinDistance;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA1F2C", Offset = "0xBA1F2C")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool cullingEnabled;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1F64", Offset = "0xBA1F64")]
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
			[Address(RVA = "0x257BB58", Offset = "0x257BB58", VA = "0x257BB58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4604", Offset = "0xBA4604")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x257BB60", Offset = "0x257BB60", VA = "0x257BB60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4614", Offset = "0xBA4614")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x257BB6C", Offset = "0x257BB6C", VA = "0x257BB6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x2574E58", Offset = "0x2574E58", VA = "0x2574E58")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x257BB74", Offset = "0x257BB74", VA = "0x257BB74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x257BBDC", Offset = "0x257BBDC", VA = "0x257BBDC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x257BC6C", Offset = "0x257BC6C", VA = "0x257BC6C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A8")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x257BD14", Offset = "0x257BD14", VA = "0x257BD14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x257BFA4", Offset = "0x257BFA4", VA = "0x257BFA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x257C0FC", Offset = "0x257C0FC", VA = "0x257C0FC")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x257C4B4", Offset = "0x257C4B4", VA = "0x257C4B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x257C4DC", Offset = "0x257C4DC", VA = "0x257C4DC")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x257C424", Offset = "0x257C424", VA = "0x257C424")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x257C588", Offset = "0x257C588", VA = "0x257C588")]
		private void Play()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x257CCD4", Offset = "0x257CCD4", VA = "0x257CCD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x257CCDC", Offset = "0x257CCDC", VA = "0x257CCDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x257CE18", Offset = "0x257CE18", VA = "0x257CE18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x257C634", Offset = "0x257C634", VA = "0x257C634")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x257C03C", Offset = "0x257C03C", VA = "0x257C03C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x257CF44", Offset = "0x257CF44", VA = "0x257CF44")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x257D3DC", Offset = "0x257D3DC", VA = "0x257D3DC")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[ExecuteInEditMode]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB9B97C", Offset = "0xB9B97C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB9B9E8", Offset = "0xB9B9E8")]
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
				[Address(RVA = "0x2FFBA24", Offset = "0x2FFBA24", VA = "0x2FFBA24", Slot = "4")]
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
				[Address(RVA = "0x2FFBA6C", Offset = "0x2FFBA6C", VA = "0x2FFBA6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x2FFB960", Offset = "0x2FFB960", VA = "0x2FFB960")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__209(int <>1__state)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x2FFB98C", Offset = "0x2FFB98C", VA = "0x2FFB98C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x2FFB990", Offset = "0x2FFB990", VA = "0x2FFB990", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x2FFBA2C", Offset = "0x2FFBA2C", VA = "0x2FFBA2C", Slot = "8")]
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
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xBA1F84", Offset = "0xBA1F84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA1F84", Offset = "0xBA1F84")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA1FD8", Offset = "0xBA1FD8")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA1FD8", Offset = "0xBA1FD8")]
		public float intensityInside;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA2028", Offset = "0xBA2028")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA2028", Offset = "0xBA2028")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA2028", Offset = "0xBA2028")]
		public float intensityOutside;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA209C", Offset = "0xBA209C")]
		public float intensityMultiplier;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA20B0", Offset = "0xBA20B0")]
		public float hdrpExposureWeight;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA20C8", Offset = "0xBA20C8")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA2100", Offset = "0xBA2100")]
		public float spotAngle;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA2120", Offset = "0xBA2120")]
		public float spotAngleMultiplier;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA2134", Offset = "0xBA2134")]
		public float coneRadiusStart;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public MeshType geomMeshType;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA216C", Offset = "0xBA216C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA21A4", Offset = "0xBA21A4")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA21BC", Offset = "0xBA21BC")]
		public float fallOffStart;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA21F4", Offset = "0xBA21F4")]
		public float fallOffEnd;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA222C", Offset = "0xBA222C")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xBA2264", Offset = "0xBA2264")]
		public float fallOffEndMultiplier;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float depthBlendDistance;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float cameraClippingDistance;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA2278", Offset = "0xBA2278")]
		public float glareFrontal;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA2290", Offset = "0xBA2290")]
		public float glareBehind;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA22A8", Offset = "0xBA22A8")]
		public float fresnelPow;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA22E0", Offset = "0xBA22E0")]
		public float noiseIntensity;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA22F8", Offset = "0xBA22F8")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA2334", Offset = "0xBA2334")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA23A0", Offset = "0xBA23A0")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA23EC", Offset = "0xBA23EC")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA2438", Offset = "0xBA2438")]
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
			[Address(RVA = "0x257D138", Offset = "0x257D138", VA = "0x257D138")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x170000AA")]
		private bool useColorFromAttachedLightSpot
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x257D4DC", Offset = "0x257D4DC", VA = "0x257D4DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		private bool useColorTemperatureFromAttachedLightSpot
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x257D560", Offset = "0x257D560", VA = "0x257D560")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA4898", Offset = "0xBA4898")]
		public float alphaInside
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x257D600", Offset = "0x257D600", VA = "0x257D600")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x257D608", Offset = "0x257D608", VA = "0x257D608")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA48D0", Offset = "0xBA48D0")]
		public float alphaOutside
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x257D610", Offset = "0x257D610", VA = "0x257D610")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x257D618", Offset = "0x257D618", VA = "0x257D618")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x257D620", Offset = "0x257D620", VA = "0x257D620")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x257D628", Offset = "0x257D628", VA = "0x257D628")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool useIntensityFromAttachedLightSpot
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x257D630", Offset = "0x257D630", VA = "0x257D630")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		public bool useSpotAngleFromAttachedLightSpot
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x257D6E0", Offset = "0x257D6E0", VA = "0x257D6E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public float coneAngle
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x257D1B8", Offset = "0x257D1B8", VA = "0x257D1B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B2")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x257ACC0", Offset = "0x257ACC0", VA = "0x257ACC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x257D798", Offset = "0x257D798", VA = "0x257D798")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public float coneVolume
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x257D83C", Offset = "0x257D83C", VA = "0x257D83C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B4")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x257D890", Offset = "0x257D890", VA = "0x257D890")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B5")]
		public Vector3 coneApexPositionLocal
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x257D908", Offset = "0x257D908", VA = "0x257D908")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B6")]
		public Vector3 coneApexPositionGlobal
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x257D928", Offset = "0x257D928", VA = "0x257D928")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B7")]
		public int geomSides
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x257AD60", Offset = "0x257AD60", VA = "0x257AD60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x257D9A4", Offset = "0x257D9A4", VA = "0x257D9A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public int geomSegments
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x257DA2C", Offset = "0x257DA2C", VA = "0x257DA2C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x257DAB4", Offset = "0x257DAB4", VA = "0x257DAB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x257DB3C", Offset = "0x257DB3C", VA = "0x257DB3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BA")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x257A084", Offset = "0x257A084", VA = "0x257A084")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x257DC6C", Offset = "0x257DC6C", VA = "0x257DC6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BC")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x257DD48", Offset = "0x257DD48", VA = "0x257DD48")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170000BD")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x257DE70", Offset = "0x257DE70", VA = "0x257DE70")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA4908", Offset = "0xBA4908")]
		public float fadeStart
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x257DE98", Offset = "0x257DE98", VA = "0x257DE98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x257DEA0", Offset = "0x257DEA0", VA = "0x257DEA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA4940", Offset = "0xBA4940")]
		public float fadeEnd
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x257DEA8", Offset = "0x257DEA8", VA = "0x257DEA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x257DEB0", Offset = "0x257DEB0", VA = "0x257DEB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA4978", Offset = "0xBA4978")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x257DEB8", Offset = "0x257DEB8", VA = "0x257DEB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x257DEC0", Offset = "0x257DEC0", VA = "0x257DEC0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public bool useFallOffEndFromAttachedLightSpot
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x257DECC", Offset = "0x257DECC", VA = "0x257DECC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x257D764", Offset = "0x257D764", VA = "0x257D764")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C3")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x257DF50", Offset = "0x257DF50", VA = "0x257DF50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA49B0", Offset = "0xBA49B0")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x257DF60", Offset = "0x257DF60", VA = "0x257DF60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x257DF70", Offset = "0x257DF70", VA = "0x257DF70")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public float fadeOutBegin
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x257DF8C", Offset = "0x257DF8C", VA = "0x257DF8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x257DF94", Offset = "0x257DF94", VA = "0x257DF94")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public float fadeOutEnd
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x257DFF0", Offset = "0x257DFF0", VA = "0x257DFF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x257DFF8", Offset = "0x257DFF8", VA = "0x257DFF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x257D224", Offset = "0x257D224", VA = "0x257D224")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C8")]
		public bool isTilted
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x257E000", Offset = "0x257E000", VA = "0x257E000")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		public int sortingLayerID
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x257E0A0", Offset = "0x257E0A0", VA = "0x257E0A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x257E0A8", Offset = "0x257E0A8", VA = "0x257E0A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public string sortingLayerName
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x257E14C", Offset = "0x257E14C", VA = "0x257E14C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x257E158", Offset = "0x257E158", VA = "0x257E158")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public int sortingOrder
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x257E188", Offset = "0x257E188", VA = "0x257E188")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x257E190", Offset = "0x257E190", VA = "0x257E190")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x257E234", Offset = "0x257E234", VA = "0x257E234")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x257E23C", Offset = "0x257E23C", VA = "0x257E23C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x257E2B4", Offset = "0x257E2B4", VA = "0x257E2B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public bool hasGeometry
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x257D248", Offset = "0x257D248", VA = "0x257D248")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public Bounds bounds
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x257D2B4", Offset = "0x257D2B4", VA = "0x257D2B4")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000D0")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x257E2C4", Offset = "0x257E2C4", VA = "0x257E2C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D1")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x257C44C", Offset = "0x257C44C", VA = "0x257C44C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000D2")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x257E3A8", Offset = "0x257E3A8", VA = "0x257E3A8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D3")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x257E3C0", Offset = "0x257E3C0", VA = "0x257E3C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D4")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x257E430", Offset = "0x257E430", VA = "0x257E430")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D5")]
		public float raycastDistance
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x257E4C8", Offset = "0x257E4C8", VA = "0x257E4C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D6")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x257E558", Offset = "0x257E558", VA = "0x257E558")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D7")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x257E600", Offset = "0x257E600", VA = "0x257E600")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D8")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x257E67C", Offset = "0x257E67C", VA = "0x257E67C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D9")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x257E6F8", Offset = "0x257E6F8", VA = "0x257E6F8")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x257E778", Offset = "0x257E778", VA = "0x257E778")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x257E780", Offset = "0x257E780", VA = "0x257E780")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x170000DB")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x257EAC8", Offset = "0x257EAC8", VA = "0x257EAC8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DC")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x257EB74", Offset = "0x257EB74", VA = "0x257EB74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4644", Offset = "0xBA4644")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x257EB7C", Offset = "0x257EB7C", VA = "0x257EB7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4654", Offset = "0xBA4654")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public string meshStats
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x257EB84", Offset = "0x257EB84", VA = "0x257EB84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x257ED38", Offset = "0x257ED38", VA = "0x257ED38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DF")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x257EE10", Offset = "0x257EE10", VA = "0x257EE10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public Light lightSpotAttached
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x257F00C", Offset = "0x257F00C", VA = "0x257F00C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x257E848", Offset = "0x257E848", VA = "0x257E848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4624", Offset = "0xBA4624")]
			add
			{
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x257E8E8", Offset = "0x257E8E8", VA = "0x257E8E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA4634", Offset = "0xBA4634")]
			remove
			{
			}
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x257D6B4", Offset = "0x257D6B4", VA = "0x257D6B4")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x257E794", Offset = "0x257E794", VA = "0x257E794")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x257E988", Offset = "0x257E988", VA = "0x257E988")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x257E99C", Offset = "0x257E99C", VA = "0x257E99C")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x257EA84", Offset = "0x257EA84", VA = "0x257EA84")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x257DF9C", Offset = "0x257DF9C", VA = "0x257DF9C")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x257EAD0", Offset = "0x257EAD0", VA = "0x257EAD0")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x257EF00", Offset = "0x257EF00", VA = "0x257EF00")]
		public Light GetLightSpotAttachedSlow(out AttachedLightType lightType)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x257EFD4", Offset = "0x257EFD4", VA = "0x257EFD4")]
		private void InitLightSpotAttachedCached()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x257F014", Offset = "0x257F014", VA = "0x257F014")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x257F074", Offset = "0x257F074", VA = "0x257F074")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x257F1EC", Offset = "0x257F1EC", VA = "0x257F1EC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBA4664", Offset = "0xBA4664")]
		public void Generate()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x257F1F8", Offset = "0x257F1F8", VA = "0x257F1F8", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x257F484", Offset = "0x257F484", VA = "0x257F484", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x257F520", Offset = "0x257F520", VA = "0x257F520")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x257F564", Offset = "0x257F564", VA = "0x257F564")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x257F5F0", Offset = "0x257F5F0", VA = "0x257F5F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x257E248", Offset = "0x257E248", VA = "0x257E248")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x257F684", Offset = "0x257F684", VA = "0x257F684")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA469C", Offset = "0xBA469C")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x257F6FC", Offset = "0x257F6FC", VA = "0x257F6FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x257F700", Offset = "0x257F700", VA = "0x257F700")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x257F7C8", Offset = "0x257F7C8", VA = "0x257F7C8")]
		private void AssignPropertiesFromAttachedSpotLight()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x257F974", Offset = "0x257F974", VA = "0x257F974")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x257F460", Offset = "0x257F460", VA = "0x257F460")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x257F360", Offset = "0x257F360", VA = "0x257F360")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x257FB70", Offset = "0x257FB70", VA = "0x257FB70")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9B9F8", Offset = "0xB9B9F8")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x22C1ED4", Offset = "0x22C1ED4", VA = "0x22C1ED4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x22C1FD0", Offset = "0x22C1FD0", VA = "0x22C1FD0")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB9BA58", Offset = "0xB9BA58")]
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
		[Address(RVA = "0x22C1FE0", Offset = "0x22C1FE0", VA = "0x22C1FE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x22C20D0", Offset = "0x22C20D0", VA = "0x22C20D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x22C2194", Offset = "0x22C2194", VA = "0x22C2194")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x22C219C", Offset = "0x22C219C", VA = "0x22C219C")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x22C2398", Offset = "0x22C2398", VA = "0x22C2398")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2575514", Offset = "0x2575514", VA = "0x2575514")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x25757D8", Offset = "0x25757D8", VA = "0x25757D8")]
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
			[Address(RVA = "0x25757E0", Offset = "0x25757E0", VA = "0x25757E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x25757E8", Offset = "0x25757E8", VA = "0x25757E8")]
			set
			{
			}
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2575824", Offset = "0x2575824", VA = "0x2575824")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x25758BC", Offset = "0x25758BC", VA = "0x25758BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2575DAC", Offset = "0x2575DAC", VA = "0x2575DAC")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA2458", Offset = "0xBA2458")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBA249C", Offset = "0xBA249C")]
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
		[Address(RVA = "0x25769A8", Offset = "0x25769A8", VA = "0x25769A8")]
		public void Generate()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x25770BC", Offset = "0x25770BC", VA = "0x25770BC")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBA2520", Offset = "0xBA2520")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x2579338", Offset = "0x2579338", VA = "0x2579338")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x257940C", Offset = "0x257940C", VA = "0x257940C")]
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
		[Address(RVA = "0x2F87638", Offset = "0x2F87638", VA = "0x2F87638")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2F87704", Offset = "0x2F87704", VA = "0x2F87704", Slot = "4")]
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
		[Address(RVA = "0x2F8770C", Offset = "0x2F8770C", VA = "0x2F8770C")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2F877D8", Offset = "0x2F877D8", VA = "0x2F877D8", Slot = "4")]
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
		[Address(RVA = "0x2525210", Offset = "0x2525210", VA = "0x2525210")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x252532C", Offset = "0x252532C", VA = "0x252532C", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x6000709")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x2525588", Offset = "0x2525588", VA = "0x2525588", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F0")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x2525808", Offset = "0x2525808", VA = "0x2525808")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x252580C", Offset = "0x252580C", VA = "0x252580C", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600070D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x2525B10", Offset = "0x2525B10", VA = "0x2525B10", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F1")]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2525E64", Offset = "0x2525E64", VA = "0x2525E64")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2525E68", Offset = "0x2525E68", VA = "0x2525E68")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2525EE0", Offset = "0x2525EE0", VA = "0x2525EE0", Slot = "7")]
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
		[Address(RVA = "0x2526094", Offset = "0x2526094", VA = "0x2526094", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x25263D4", Offset = "0x25263D4", VA = "0x25263D4", Slot = "11")]
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
		[Address(RVA = "0x2525214", Offset = "0x2525214", VA = "0x2525214")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x2525EA4", Offset = "0x2525EA4", VA = "0x2525EA4")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2529C38", Offset = "0x2529C38", VA = "0x2529C38", Slot = "4")]
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
		[Address(RVA = "0x2529C48", Offset = "0x2529C48", VA = "0x2529C48", Slot = "10")]
		public virtual object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2529F2C", Offset = "0x2529F2C", VA = "0x2529F2C", Slot = "11")]
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
		[Address(RVA = "0x252AC98", Offset = "0x252AC98", VA = "0x252AC98")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x252ADD4", Offset = "0x252ADD4", VA = "0x252ADD4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x252ADF8", Offset = "0x252ADF8", VA = "0x252ADF8")]
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
		[Address(RVA = "0x252B284", Offset = "0x252B284", VA = "0x252B284")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x252B658", Offset = "0x252B658", VA = "0x252B658")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x252D554", Offset = "0x252D554", VA = "0x252D554")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x252D558", Offset = "0x252D558", VA = "0x252D558", Slot = "7")]
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
		[Address(RVA = "0x2531360", Offset = "0x2531360", VA = "0x2531360")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2531364", Offset = "0x2531364", VA = "0x2531364", Slot = "7")]
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
		[Address(RVA = "0x25317B8", Offset = "0x25317B8", VA = "0x25317B8", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x25319A0", Offset = "0x25319A0", VA = "0x25319A0", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x25330E8", Offset = "0x25330E8", VA = "0x25330E8")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x25330EC", Offset = "0x25330EC", VA = "0x25330EC", Slot = "7")]
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
		[Address(RVA = "0x2533524", Offset = "0x2533524", VA = "0x2533524", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2533A84", Offset = "0x2533A84", VA = "0x2533A84", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2539658", Offset = "0x2539658", VA = "0x2539658")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x253965C", Offset = "0x253965C", VA = "0x253965C", Slot = "7")]
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
		[Address(RVA = "0x2539A94", Offset = "0x2539A94", VA = "0x2539A94", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2539D8C", Offset = "0x2539D8C", VA = "0x2539D8C", Slot = "11")]
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
		[Address(RVA = "0x252A218", Offset = "0x252A218", VA = "0x252A218")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x600073E")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x600073F")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x252A220", Offset = "0x252A220", VA = "0x252A220", Slot = "7")]
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
		[Address(RVA = "0x252A76C", Offset = "0x252A76C", VA = "0x252A76C")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x252A9B4", Offset = "0x252A9B4", VA = "0x252A9B4")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x252A8F8", Offset = "0x252A8F8", VA = "0x252A8F8")]
		public static Component GetOrCreateComponentIfNotExists(GameObject go, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F9")]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x252A21C", Offset = "0x252A21C", VA = "0x252A21C")]
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
		[Address(RVA = "0x2532010", Offset = "0x2532010", VA = "0x2532010", Slot = "4")]
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
		[Address(RVA = "0x2535AA0", Offset = "0x2535AA0", VA = "0x2535AA0")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x600074E")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x600074F")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2537FD8", Offset = "0x2537FD8", VA = "0x2537FD8", Slot = "7")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xB9BB10", Offset = "0xB9BB10")]
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
		[Address(RVA = "0x2535B50", Offset = "0x2535B50", VA = "0x2535B50")]
		protected ES3Type()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x252990C", Offset = "0x252990C", VA = "0x252990C")]
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
		[Address(RVA = "0x2532068", Offset = "0x2532068", VA = "0x2532068")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x253A2E4", Offset = "0x253A2E4", VA = "0x253A2E4")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x25358C0", Offset = "0x25358C0", VA = "0x25358C0")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x253A340", Offset = "0x253A340", VA = "0x253A340")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x25358B0", Offset = "0x25358B0", VA = "0x25358B0")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x2535C28", Offset = "0x2535C28", VA = "0x2535C28")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB9BB24", Offset = "0xB9BB24")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x25330B4", Offset = "0x25330B4", VA = "0x25330B4")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x256C3B4", Offset = "0x256C3B4", VA = "0x256C3B4")]
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
		[Address(RVA = "0x2571B5C", Offset = "0x2571B5C", VA = "0x2571B5C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2571B64", Offset = "0x2571B64", VA = "0x2571B64")]
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
		[Address(RVA = "0x2F87334", Offset = "0x2F87334", VA = "0x2F87334")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2F87400", Offset = "0x2F87400", VA = "0x2F87400", Slot = "4")]
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
		[Address(RVA = "0x2F8753C", Offset = "0x2F8753C", VA = "0x2F8753C")]
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
		[Address(RVA = "0x256E25C", Offset = "0x256E25C", VA = "0x256E25C")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x256E330", Offset = "0x256E330", VA = "0x256E330", Slot = "4")]
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
		[Address(RVA = "0x256E3C8", Offset = "0x256E3C8", VA = "0x256E3C8")]
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
		[Address(RVA = "0x256F91C", Offset = "0x256F91C", VA = "0x256F91C")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x256F9F0", Offset = "0x256F9F0", VA = "0x256F9F0", Slot = "4")]
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
		[Address(RVA = "0x256FA88", Offset = "0x256FA88", VA = "0x256FA88")]
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
		[Address(RVA = "0x256FB84", Offset = "0x256FB84", VA = "0x256FB84")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x256FC58", Offset = "0x256FC58", VA = "0x256FC58", Slot = "4")]
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
		[Address(RVA = "0x256FCF0", Offset = "0x256FCF0", VA = "0x256FCF0")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x256FDC4", Offset = "0x256FDC4", VA = "0x256FDC4", Slot = "4")]
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
		[Address(RVA = "0x256FE5C", Offset = "0x256FE5C", VA = "0x256FE5C")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x256FF30", Offset = "0x256FF30", VA = "0x256FF30", Slot = "4")]
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
		[Address(RVA = "0x256FFC8", Offset = "0x256FFC8", VA = "0x256FFC8")]
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
		[Address(RVA = "0x25700C4", Offset = "0x25700C4", VA = "0x25700C4")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2570198", Offset = "0x2570198", VA = "0x2570198", Slot = "4")]
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
		[Address(RVA = "0x2570230", Offset = "0x2570230", VA = "0x2570230")]
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
		[Address(RVA = "0x257032C", Offset = "0x257032C", VA = "0x257032C")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2570400", Offset = "0x2570400", VA = "0x2570400", Slot = "4")]
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
		[Address(RVA = "0x2570498", Offset = "0x2570498", VA = "0x2570498")]
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
		[Address(RVA = "0x2570594", Offset = "0x2570594", VA = "0x2570594")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x2570624", Offset = "0x2570624", VA = "0x2570624", Slot = "4")]
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
		[Address(RVA = "0x25706BC", Offset = "0x25706BC", VA = "0x25706BC")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2570790", Offset = "0x2570790", VA = "0x2570790", Slot = "4")]
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
		[Address(RVA = "0x2570828", Offset = "0x2570828", VA = "0x2570828")]
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
		[Address(RVA = "0x2570924", Offset = "0x2570924", VA = "0x2570924")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x25709F8", Offset = "0x25709F8", VA = "0x25709F8", Slot = "4")]
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
		[Address(RVA = "0x2570A90", Offset = "0x2570A90", VA = "0x2570A90")]
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
		[Address(RVA = "0x2F8A574", Offset = "0x2F8A574", VA = "0x2F8A574")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2F8A648", Offset = "0x2F8A648", VA = "0x2F8A648", Slot = "4")]
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
		[Address(RVA = "0x2F8A6EC", Offset = "0x2F8A6EC", VA = "0x2F8A6EC")]
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
		[Address(RVA = "0x2570B8C", Offset = "0x2570B8C", VA = "0x2570B8C")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2570C60", Offset = "0x2570C60", VA = "0x2570C60", Slot = "4")]
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
		[Address(RVA = "0x2570CF8", Offset = "0x2570CF8", VA = "0x2570CF8")]
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
		[Address(RVA = "0x2570DF4", Offset = "0x2570DF4", VA = "0x2570DF4")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2570EC8", Offset = "0x2570EC8", VA = "0x2570EC8", Slot = "4")]
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
		[Address(RVA = "0x2570F60", Offset = "0x2570F60", VA = "0x2570F60")]
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
		[Address(RVA = "0x257105C", Offset = "0x257105C", VA = "0x257105C")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2571130", Offset = "0x2571130", VA = "0x2571130", Slot = "4")]
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
		[Address(RVA = "0x25711C8", Offset = "0x25711C8", VA = "0x25711C8")]
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
		[Address(RVA = "0x25712C4", Offset = "0x25712C4", VA = "0x25712C4")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2571398", Offset = "0x2571398", VA = "0x2571398", Slot = "4")]
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
		[Address(RVA = "0x2FE9570", Offset = "0x2FE9570", VA = "0x2FE9570")]
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
		[Address(RVA = "0x2571424", Offset = "0x2571424", VA = "0x2571424")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x25714F8", Offset = "0x25714F8", VA = "0x25714F8", Slot = "4")]
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
		[Address(RVA = "0x2571590", Offset = "0x2571590", VA = "0x2571590")]
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
		[Address(RVA = "0x257168C", Offset = "0x257168C", VA = "0x257168C")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2571760", Offset = "0x2571760", VA = "0x2571760", Slot = "4")]
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
		[Address(RVA = "0x25717F8", Offset = "0x25717F8", VA = "0x25717F8")]
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
		[Address(RVA = "0x25718F4", Offset = "0x25718F4", VA = "0x25718F4")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x25719C8", Offset = "0x25719C8", VA = "0x25719C8", Slot = "4")]
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
		[Address(RVA = "0x2571A60", Offset = "0x2571A60", VA = "0x2571A60")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x2000121")]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2535864", Offset = "0x2535864", VA = "0x2535864")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x25358BC", Offset = "0x25358BC", VA = "0x25358BC", Slot = "10")]
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
		[Address(RVA = "0x2535A04", Offset = "0x2535A04", VA = "0x2535A04")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2535A50", Offset = "0x2535A50", VA = "0x2535A50", Slot = "7")]
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
		[Address(RVA = "0x2535A54", Offset = "0x2535A54", VA = "0x2535A54")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2535AA4", Offset = "0x2535AA4", VA = "0x2535AA4", Slot = "10")]
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
		[Address(RVA = "0x2535AA8", Offset = "0x2535AA8", VA = "0x2535AA8")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x2535B70", Offset = "0x2535B70", VA = "0x2535B70")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2535DD4", Offset = "0x2535DD4", VA = "0x2535DD4", Slot = "4")]
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
		[Address(RVA = "0x25361B8", Offset = "0x25361B8", VA = "0x25361B8")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x25361F0", Offset = "0x25361F0", VA = "0x25361F0", Slot = "10")]
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
		[Address(RVA = "0x25361F4", Offset = "0x25361F4", VA = "0x25361F4")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x2536240", Offset = "0x2536240", VA = "0x2536240", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9BB38", Offset = "0xB9BB38")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x253C918", Offset = "0x253C918", VA = "0x253C918")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x253C9E0", Offset = "0x253C9E0", VA = "0x253C9E0", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007DD")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9BC44", Offset = "0xB9BC44")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x253CC80", Offset = "0x253CC80", VA = "0x253CC80")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x253CD48", Offset = "0x253CD48", VA = "0x253CD48", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007E1")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9BD6C", Offset = "0xB9BD6C")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x253D088", Offset = "0x253D088", VA = "0x253D088")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x253D150", Offset = "0x253D150", VA = "0x253D150", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007E5")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9C16C", Offset = "0xB9C16C")]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x2F857C0", Offset = "0x2F857C0", VA = "0x2F857C0")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x2F8588C", Offset = "0x2F8588C", VA = "0x2F8588C", Slot = "10")]
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
		[Address(RVA = "0x2F87D78", Offset = "0x2F87D78", VA = "0x2F87D78")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2F87E44", Offset = "0x2F87E44", VA = "0x2F87E44", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007ED")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9C2B0", Offset = "0xB9C2B0")]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x2FE0234", Offset = "0x2FE0234", VA = "0x2FE0234")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x2FE0300", Offset = "0x2FE0300", VA = "0x2FE0300", Slot = "10")]
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
		[Address(RVA = "0x2FE06E4", Offset = "0x2FE06E4", VA = "0x2FE06E4")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9C3F4", Offset = "0xB9C3F4")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2FE07E0", Offset = "0x2FE07E0", VA = "0x2FE07E0")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2FE08AC", Offset = "0x2FE08AC", VA = "0x2FE08AC", Slot = "10")]
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
		[Address(RVA = "0x2FE0998", Offset = "0x2FE0998", VA = "0x2FE0998")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9C474", Offset = "0xB9C474")]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2FE0A94", Offset = "0x2FE0A94", VA = "0x2FE0A94")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x2FE0B60", Offset = "0x2FE0B60", VA = "0x2FE0B60", Slot = "10")]
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
		[Address(RVA = "0x2FE136C", Offset = "0x2FE136C", VA = "0x2FE136C")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9C6B4", Offset = "0xB9C6B4")]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2FE29F8", Offset = "0x2FE29F8", VA = "0x2FE29F8")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2FE2AC4", Offset = "0x2FE2AC4", VA = "0x2FE2AC4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000800")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9CA0C", Offset = "0xB9CA0C")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2FE3D48", Offset = "0x2FE3D48", VA = "0x2FE3D48")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2FE3E14", Offset = "0x2FE3E14", VA = "0x2FE3E14", Slot = "10")]
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
		[Address(RVA = "0x2FE439C", Offset = "0x2FE439C", VA = "0x2FE439C")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9CB6C", Offset = "0xB9CB6C")]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x2FE81C8", Offset = "0x2FE81C8", VA = "0x2FE81C8")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x2FE8294", Offset = "0x2FE8294", VA = "0x2FE8294", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000809")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9CC78", Offset = "0xB9CC78")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x2FE99F8", Offset = "0x2FE99F8", VA = "0x2FE99F8")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2FE9AC4", Offset = "0x2FE9AC4", VA = "0x2FE9AC4", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600080D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9CF7C", Offset = "0xB9CF7C")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x256DAAC", Offset = "0x256DAAC", VA = "0x256DAAC")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x256DB78", Offset = "0x256DB78", VA = "0x256DB78", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000811")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D050", Offset = "0xB9D050")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x253B93C", Offset = "0x253B93C", VA = "0x253B93C")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x253BA04", Offset = "0x253BA04", VA = "0x253BA04", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D108", Offset = "0xB9D108")]
	public class ES3Type_AudioClip : ES3ObjectType
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x253BBA8", Offset = "0x253BBA8", VA = "0x253BBA8")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x253BC70", Offset = "0x253BC70", VA = "0x253BC70", Slot = "7")]
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
		[Address(RVA = "0x253BEB8", Offset = "0x253BEB8", VA = "0x253BEB8")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D1F8", Offset = "0xB9D1F8")]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x253BFC8", Offset = "0x253BFC8", VA = "0x253BFC8")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x253C090", Offset = "0x253C090", VA = "0x253C090", Slot = "4")]
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
		[Address(RVA = "0x253C48C", Offset = "0x253C48C", VA = "0x253C48C")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D33C", Offset = "0xB9D33C")]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x253C59C", Offset = "0x253C59C", VA = "0x253C59C")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x253C664", Offset = "0x253C664", VA = "0x253C664", Slot = "4")]
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
		[Address(RVA = "0x253C808", Offset = "0x253C808", VA = "0x253C808")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D3D8", Offset = "0xB9D3D8")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x2F85D0C", Offset = "0x2F85D0C", VA = "0x2F85D0C")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2F85DD8", Offset = "0x2F85DD8", VA = "0x2F85DD8", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D634", Offset = "0xB9D634")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2F864D8", Offset = "0x2F864D8", VA = "0x2F864D8")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2F865A4", Offset = "0x2F865A4", VA = "0x2F865A4", Slot = "4")]
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
		[Address(RVA = "0x2F86BE8", Offset = "0x2F86BE8", VA = "0x2F86BE8")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D708", Offset = "0xB9D708")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2F867C0", Offset = "0x2F867C0", VA = "0x2F867C0")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2F8688C", Offset = "0x2F8688C", VA = "0x2F8688C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000833")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2F86AA4", Offset = "0x2F86AA4", VA = "0x2F86AA4")]
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
		[Address(RVA = "0x2F86AEC", Offset = "0x2F86AEC", VA = "0x2F86AEC")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D7DC", Offset = "0xB9D7DC")]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2F86CE4", Offset = "0x2F86CE4", VA = "0x2F86CE4")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2F86DB0", Offset = "0x2F86DB0", VA = "0x2F86DB0", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D894", Offset = "0xB9D894")]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2F8705C", Offset = "0x2F8705C", VA = "0x2F8705C")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2F87128", Offset = "0x2F87128", VA = "0x2F87128", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9D930", Offset = "0xB9D930")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x2F87948", Offset = "0x2F87948", VA = "0x2F87948")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x2F87A14", Offset = "0x2F87A14", VA = "0x2F87A14", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9DA20", Offset = "0xB9DA20")]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2F87E4C", Offset = "0x2F87E4C", VA = "0x2F87E4C")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2F87F18", Offset = "0x2F87F18", VA = "0x2F87F18", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9DABC", Offset = "0xB9DABC")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2F880F8", Offset = "0x2F880F8", VA = "0x2F880F8")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2F881C4", Offset = "0x2F881C4", VA = "0x2F881C4", Slot = "4")]
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
		[Address(RVA = "0x2F8829C", Offset = "0x2F8829C", VA = "0x2F8829C")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9DB3C", Offset = "0xB9DB3C")]
	public class ES3Type_Font : ES3Type
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2F88398", Offset = "0x2F88398", VA = "0x2F88398")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x2F88464", Offset = "0x2F88464", VA = "0x2F88464", Slot = "4")]
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
		[Address(RVA = "0x2F885D0", Offset = "0x2F885D0", VA = "0x2F885D0")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9DBD8", Offset = "0xB9DBD8")]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x2F886CC", Offset = "0x2F886CC", VA = "0x2F886CC")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x2F88798", Offset = "0x2F88798", VA = "0x2F88798", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9DD38", Offset = "0xB9DD38")]
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
		[Address(RVA = "0x2F88C88", Offset = "0x2F88C88", VA = "0x2F88C88")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x2F88D54", Offset = "0x2F88D54", VA = "0x2F88D54", Slot = "4")]
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
		[Address(RVA = "0x2F893D8", Offset = "0x2F893D8", VA = "0x2F893D8")]
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
		[Address(RVA = "0x2F89780", Offset = "0x2F89780", VA = "0x2F89780")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9DE60", Offset = "0xB9DE60")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2F8987C", Offset = "0x2F8987C", VA = "0x2F8987C")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x2F89948", Offset = "0x2F89948", VA = "0x2F89948", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9DF18", Offset = "0xB9DF18")]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x2F89AF8", Offset = "0x2F89AF8", VA = "0x2F89AF8")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x2F89BC4", Offset = "0x2F89BC4", VA = "0x2F89BC4", Slot = "4")]
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
		[Address(RVA = "0x2F89D34", Offset = "0x2F89D34", VA = "0x2F89D34")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9DFB4", Offset = "0xB9DFB4")]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2F89E30", Offset = "0x2F89E30", VA = "0x2F89E30")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2F89EFC", Offset = "0x2F89EFC", VA = "0x2F89EFC", Slot = "4")]
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
		[Address(RVA = "0x2F8A0B8", Offset = "0x2F8A0B8", VA = "0x2F8A0B8")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9E050", Offset = "0xB9E050")]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2F8A1B4", Offset = "0x2F8A1B4", VA = "0x2F8A1B4")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2F8A280", Offset = "0x2F8A280", VA = "0x2F8A280", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9E124", Offset = "0xB9E124")]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2F8A7E8", Offset = "0x2F8A7E8", VA = "0x2F8A7E8")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2F8A8B4", Offset = "0x2F8A8B4", VA = "0x2F8A8B4", Slot = "4")]
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
		[Address(RVA = "0x2F8AB04", Offset = "0x2F8AB04", VA = "0x2F8AB04")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9E1F8", Offset = "0xB9E1F8")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2F8AC00", Offset = "0x2F8AC00", VA = "0x2F8AC00")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2F8ACCC", Offset = "0x2F8ACCC", VA = "0x2F8ACCC", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9E2B0", Offset = "0xB9E2B0")]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2F8AE00", Offset = "0x2F8AE00", VA = "0x2F8AE00")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x2F8AECC", Offset = "0x2F8AECC", VA = "0x2F8AECC", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000884")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9E57C", Offset = "0xB9E57C")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x2F8B7C4", Offset = "0x2F8B7C4", VA = "0x2F8B7C4")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x2F8B890", Offset = "0x2F8B890", VA = "0x2F8B890", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9E730", Offset = "0xB9E730")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x2F8BEAC", Offset = "0x2F8BEAC", VA = "0x2F8BEAC")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x2F8BF78", Offset = "0x2F8BF78", VA = "0x2F8BF78", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9E8E4", Offset = "0xB9E8E4")]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x2F8C57C", Offset = "0x2F8C57C", VA = "0x2F8C57C")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x2F8C648", Offset = "0x2F8C648", VA = "0x2F8C648", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9ED54", Offset = "0xB9ED54")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x2F8D628", Offset = "0x2F8D628", VA = "0x2F8D628")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x2F8D6F4", Offset = "0x2F8D6F4", VA = "0x2F8D6F4", Slot = "10")]
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
		[Address(RVA = "0x2FDF5F8", Offset = "0x2FDF5F8", VA = "0x2FDF5F8")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9EE44", Offset = "0xB9EE44")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x2FDF6F4", Offset = "0x2FDF6F4", VA = "0x2FDF6F4")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x2FDF7C0", Offset = "0x2FDF7C0", VA = "0x2FDF7C0", Slot = "4")]
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
		[Address(RVA = "0x2FDFA34", Offset = "0x2FDFA34", VA = "0x2FDFA34")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9EF18", Offset = "0xB9EF18")]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x2FDFB30", Offset = "0x2FDFB30", VA = "0x2FDFB30")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x2FDFBFC", Offset = "0x2FDFBFC", VA = "0x2FDFBFC", Slot = "10")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F104", Offset = "0xB9F104")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2FE1468", Offset = "0x2FE1468", VA = "0x2FE1468")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x2FE1534", Offset = "0x2FE1534", VA = "0x2FE1534", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F248", Offset = "0xB9F248")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x2FE18F0", Offset = "0x2FE18F0", VA = "0x2FE18F0")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2FE19BC", Offset = "0x2FE19BC", VA = "0x2FE19BC", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F370", Offset = "0xB9F370")]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2FE1D48", Offset = "0x2FE1D48", VA = "0x2FE1D48")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2FE1E14", Offset = "0x2FE1E14", VA = "0x2FE1E14", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F6C8", Offset = "0xB9F6C8")]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x2FE3598", Offset = "0x2FE3598", VA = "0x2FE3598")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x2FE3664", Offset = "0x2FE3664", VA = "0x2FE3664", Slot = "7")]
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
		[Address(RVA = "0x2FE390C", Offset = "0x2FE390C", VA = "0x2FE390C")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F7B8", Offset = "0xB9F7B8")]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x2FE3A08", Offset = "0x2FE3A08", VA = "0x2FE3A08")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x2FE3AD4", Offset = "0x2FE3AD4", VA = "0x2FE3AD4", Slot = "7")]
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
		[Address(RVA = "0x2FE3C4C", Offset = "0x2FE3C4C", VA = "0x2FE3C4C")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F854", Offset = "0xB9F854")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x2FE4498", Offset = "0x2FE4498", VA = "0x2FE4498")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x2FE4564", Offset = "0x2FE4564", VA = "0x2FE4564", Slot = "4")]
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
		[Address(RVA = "0x2FE4780", Offset = "0x2FE4780", VA = "0x2FE4780")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F928", Offset = "0xB9F928")]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x2FE487C", Offset = "0x2FE487C", VA = "0x2FE487C")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x2FE4948", Offset = "0x2FE4948", VA = "0x2FE4948", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9F9FC", Offset = "0xB9F9FC")]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x2FE4B88", Offset = "0x2FE4B88", VA = "0x2FE4B88")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x2FE4C54", Offset = "0x2FE4C54", VA = "0x2FE4C54", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008CA")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9FBB0", Offset = "0xB9FBB0")]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x2FE5214", Offset = "0x2FE5214", VA = "0x2FE5214")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x2FE52E0", Offset = "0x2FE52E0", VA = "0x2FE52E0", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9FD10", Offset = "0xB9FD10")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x2FE5808", Offset = "0x2FE5808", VA = "0x2FE5808")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x2FE58D4", Offset = "0x2FE58D4", VA = "0x2FE58D4", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9FE54", Offset = "0xB9FE54")]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x2FE5D68", Offset = "0x2FE5D68", VA = "0x2FE5D68")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x2FE5E34", Offset = "0x2FE5E34", VA = "0x2FE5E34", Slot = "4")]
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
		[Address(RVA = "0x2FE5FD4", Offset = "0x2FE5FD4", VA = "0x2FE5FD4")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xB9FEF0", Offset = "0xB9FEF0")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x2FE60D0", Offset = "0x2FE60D0", VA = "0x2FE60D0")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x2FE619C", Offset = "0x2FE619C", VA = "0x2FE619C", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0168", Offset = "0xBA0168")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x2FE6968", Offset = "0x2FE6968", VA = "0x2FE6968")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x2FE6A34", Offset = "0x2FE6A34", VA = "0x2FE6A34", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0300", Offset = "0xBA0300")]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x2FE701C", Offset = "0x2FE701C", VA = "0x2FE701C")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x2FE70E8", Offset = "0x2FE70E8", VA = "0x2FE70E8", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA047C", Offset = "0xBA047C")]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2FE763C", Offset = "0x2FE763C", VA = "0x2FE763C")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x2FE7708", Offset = "0x2FE7708", VA = "0x2FE7708", Slot = "10")]
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
		[Address(RVA = "0x2FE80CC", Offset = "0x2FE80CC", VA = "0x2FE80CC")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0764", Offset = "0xBA0764")]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x2FE8618", Offset = "0x2FE8618", VA = "0x2FE8618")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x2FE86E4", Offset = "0x2FE86E4", VA = "0x2FE86E4", Slot = "10")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0854", Offset = "0xBA0854")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x2FE8A70", Offset = "0x2FE8A70", VA = "0x2FE8A70")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x2FE8B3C", Offset = "0x2FE8B3C", VA = "0x2FE8B3C", Slot = "10")]
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
		[Address(RVA = "0x2FE9474", Offset = "0x2FE9474", VA = "0x2FE9474")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0AE8", Offset = "0xBA0AE8")]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x2FE966C", Offset = "0x2FE966C", VA = "0x2FE966C")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x2FE9738", Offset = "0x2FE9738", VA = "0x2FE9738", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0BA0", Offset = "0xBA0BA0")]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x256C05C", Offset = "0x256C05C", VA = "0x256C05C")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x256C128", Offset = "0x256C128", VA = "0x256C128", Slot = "4")]
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
		[Address(RVA = "0x256C970", Offset = "0x256C970", VA = "0x256C970")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0C90", Offset = "0xBA0C90")]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x256C2DC", Offset = "0x256C2DC", VA = "0x256C2DC")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x256C3E4", Offset = "0x256C3E4", VA = "0x256C3E4", Slot = "10")]
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
		[Address(RVA = "0x256C874", Offset = "0x256C874", VA = "0x256C874")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0D80", Offset = "0xBA0D80")]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x256CA6C", Offset = "0x256CA6C", VA = "0x256CA6C")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x256CB38", Offset = "0x256CB38", VA = "0x256CB38", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA0F6C", Offset = "0xBA0F6C")]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x256D234", Offset = "0x256D234", VA = "0x256D234")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x256D300", Offset = "0x256D300", VA = "0x256D300", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1174", Offset = "0xBA1174")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x256DE5C", Offset = "0x256DE5C", VA = "0x256DE5C")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x256DF28", Offset = "0x256DF28", VA = "0x256DF28", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1280", Offset = "0xBA1280")]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x256E4C4", Offset = "0x256E4C4", VA = "0x256E4C4")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x256E590", Offset = "0x256E590", VA = "0x256E590", Slot = "4")]
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
		[Address(RVA = "0x256E700", Offset = "0x256E700", VA = "0x256E700")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA131C", Offset = "0xBA131C")]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x256E7FC", Offset = "0x256E7FC", VA = "0x256E7FC")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x256E8C8", Offset = "0x256E8C8", VA = "0x256E8C8", Slot = "4")]
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
		[Address(RVA = "0x256EA90", Offset = "0x256EA90", VA = "0x256EA90")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA13D4", Offset = "0xBA13D4")]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x256EB8C", Offset = "0x256EB8C", VA = "0x256EB8C")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x256EC58", Offset = "0x256EC58", VA = "0x256EC58", Slot = "4")]
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
		[Address(RVA = "0x256EE58", Offset = "0x256EE58", VA = "0x256EE58")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA148C", Offset = "0xBA148C")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x256EF54", Offset = "0x256EF54", VA = "0x256EF54")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x256F020", Offset = "0x256F020", VA = "0x256F020", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600092B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x256F238", Offset = "0x256F238", VA = "0x256F238")]
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
		[Address(RVA = "0x256F2D8", Offset = "0x256F2D8", VA = "0x256F2D8")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xBA1560", Offset = "0xBA1560")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x256F3D4", Offset = "0x256F3D4", VA = "0x256F3D4")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x256F4A0", Offset = "0x256F4A0", VA = "0x256F4A0", Slot = "4")]
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
		[Address(RVA = "0x252D388", Offset = "0x252D388", VA = "0x252D388")]
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
		[Address(RVA = "0x2575428", Offset = "0x2575428", VA = "0x2575428")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x257550C", Offset = "0x257550C", VA = "0x257550C")]
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
		[Address(RVA = "0x22BDA84", Offset = "0x22BDA84", VA = "0x22BDA84", Slot = "4")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x22BDEE0", Offset = "0x22BDEE0", VA = "0x22BDEE0", Slot = "5")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x22BE324", Offset = "0x22BE324", VA = "0x22BE324")]
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
		[Address(RVA = "0x257AEE0", Offset = "0x257AEE0", VA = "0x257AEE0")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x257AFAC", Offset = "0x257AFAC", VA = "0x257AFAC", Slot = "22")]
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
		[Address(RVA = "0x252AB7C", Offset = "0x252AB7C", VA = "0x252AB7C")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x252AC54", Offset = "0x252AC54", VA = "0x252AC54")]
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
		[Address(RVA = "0x252DB5C", Offset = "0x252DB5C", VA = "0x252DB5C")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x252DBF0", Offset = "0x252DBF0", VA = "0x252DBF0")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x252DC54", Offset = "0x252DC54", VA = "0x252DC54")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x252DBE8", Offset = "0x252DBE8", VA = "0x252DBE8")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x252DC90", Offset = "0x252DC90", VA = "0x252DC90")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x252DC98", Offset = "0x252DC98", VA = "0x252DC98")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x252D360", Offset = "0x252D360", VA = "0x252D360")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x252DCA0", Offset = "0x252DCA0", VA = "0x252DCA0")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x252D2FC", Offset = "0x252D2FC", VA = "0x252D2FC")]
		public static string GetDirectoryName(string path)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x252DCA8", Offset = "0x252DCA8", VA = "0x252DCA8")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x252DDD0", Offset = "0x252DDD0", VA = "0x252DDD0")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x252DE10", Offset = "0x252DE10", VA = "0x252DE10")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x252DF38", Offset = "0x252DF38", VA = "0x252DF38")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x252DF40", Offset = "0x252DF40", VA = "0x252DF40")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x252DF48", Offset = "0x252DF48", VA = "0x252DF48")]
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
		[Address(RVA = "0x25325E8", Offset = "0x25325E8", VA = "0x25325E8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x25327C4", Offset = "0x25327C4", VA = "0x25327C4")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x2532840", Offset = "0x2532840", VA = "0x2532840")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x2532944", Offset = "0x2532944", VA = "0x2532944")]
		public Dictionary<long, long> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x2532B74", Offset = "0x2532B74", VA = "0x2532B74")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x25328EC", Offset = "0x25328EC", VA = "0x25328EC")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x2532FF4", Offset = "0x2532FF4", VA = "0x2532FF4")]
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
			[Address(RVA = "0x252A50C", Offset = "0x252A50C", VA = "0x252A50C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public bool IsInitialised
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x2534E08", Offset = "0x2534E08", VA = "0x2534E08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x2534E68", Offset = "0x2534E68", VA = "0x2534E68")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x2535068", Offset = "0x2535068", VA = "0x2535068")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x25352BC", Offset = "0x25352BC", VA = "0x25352BC")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x2535338", Offset = "0x2535338", VA = "0x2535338")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x25353C4", Offset = "0x25353C4", VA = "0x25353C4")]
		public ES3Prefab GetPrefab(long id)
		{
			return null;
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x25354A4", Offset = "0x25354A4", VA = "0x25354A4")]
		public long GetPrefab(ES3Prefab prefab)
		{
			return default(long);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x252A6B0", Offset = "0x252A6B0", VA = "0x252A6B0")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x2532D9C", Offset = "0x2532D9C", VA = "0x2532D9C")]
		public void Add(UnityEngine.Object obj, long id)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x25355C0", Offset = "0x25355C0", VA = "0x25355C0")]
		public void AddPrefab(ES3Prefab prefab)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x2535660", Offset = "0x2535660", VA = "0x2535660")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x25356FC", Offset = "0x25356FC", VA = "0x25356FC")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x2535798", Offset = "0x2535798", VA = "0x2535798")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x25357FC", Offset = "0x25357FC", VA = "0x25357FC")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x2532E44", Offset = "0x2532E44", VA = "0x2532E44")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x2534D50", Offset = "0x2534D50", VA = "0x2534D50")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000192")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x252E3D4", Offset = "0x252E3D4", VA = "0x252E3D4", Slot = "6")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x252E3E0", Offset = "0x252E3E0", VA = "0x252E3E0", Slot = "7")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x252E454", Offset = "0x252E454", VA = "0x252E454")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA16B4", Offset = "0xBA16B4")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x2534C68", Offset = "0x2534C68", VA = "0x2534C68", Slot = "6")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x2534CDC", Offset = "0x2534CDC", VA = "0x2534CDC", Slot = "7")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x2533068", Offset = "0x2533068", VA = "0x2533068")]
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
				[Address(RVA = "0x2FF9C3C", Offset = "0x2FF9C3C", VA = "0x2FF9C3C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E8")]
			public string Name
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x2FF9C88", Offset = "0x2FF9C88", VA = "0x2FF9C88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			public Type MemberType
			{
				[Token(Token = "0x6000995")]
				[Address(RVA = "0x2FF9CC0", Offset = "0x2FF9CC0", VA = "0x2FF9CC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			public bool IsPublic
			{
				[Token(Token = "0x6000996")]
				[Address(RVA = "0x2FF9D0C", Offset = "0x2FF9D0C", VA = "0x2FF9D0C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EB")]
			public bool IsProtected
			{
				[Token(Token = "0x6000997")]
				[Address(RVA = "0x2FF9DAC", Offset = "0x2FF9DAC", VA = "0x2FF9DAC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x2FF9E00", Offset = "0x2FF9E00", VA = "0x2FF9E00")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x2FF9FE0", Offset = "0x2FF9FE0", VA = "0x2FF9FE0")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x2FFA028", Offset = "0x2FFA028", VA = "0x2FFA028")]
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
			[Address(RVA = "0x2FFA078", Offset = "0x2FFA078", VA = "0x2FFA078")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x2FFA0FC", Offset = "0x2FFA0FC", VA = "0x2FFA0FC")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x2000197")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA16C8", Offset = "0xBA16C8")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x2FF9BA4", Offset = "0x2FF9BA4", VA = "0x2FF9BA4")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x2FF9BAC", Offset = "0x2FF9BAC", VA = "0x2FF9BAC")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA16D8", Offset = "0xBA16D8")]
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
			[Address(RVA = "0x2FF9AAC", Offset = "0x2FF9AAC", VA = "0x2FF9AAC")]
			public <>c()
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x2FF9AB4", Offset = "0x2FF9AB4", VA = "0x2FF9AB4")]
			internal IEnumerable<Type> <GetDerivedTypes>b__24_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x2FF9AD8", Offset = "0x2FF9AD8", VA = "0x2FF9AD8")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__24_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x2FF9B5C", Offset = "0x2FF9B5C", VA = "0x2FF9B5C")]
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
			[Address(RVA = "0x2536244", Offset = "0x2536244", VA = "0x2536244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x25299AC", Offset = "0x25299AC", VA = "0x25299AC")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x2536620", Offset = "0x2536620", VA = "0x2536620")]
		public static List<FieldInfo> GetSerializableFields(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2536D24", Offset = "0x2536D24", VA = "0x2536D24")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x25369E8", Offset = "0x25369E8", VA = "0x25369E8")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x252B4CC", Offset = "0x252B4CC", VA = "0x252B4CC")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x25338E4", Offset = "0x25338E4", VA = "0x25338E4")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x252634C", Offset = "0x252634C", VA = "0x252634C")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x2525800", Offset = "0x2525800", VA = "0x2525800")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x253381C", Offset = "0x253381C", VA = "0x253381C")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x2537474", Offset = "0x2537474", VA = "0x2537474")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x253435C", Offset = "0x253435C", VA = "0x253435C")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x2534594", Offset = "0x2534594", VA = "0x2534594")]
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
		[Address(RVA = "0x253770C", Offset = "0x253770C", VA = "0x253770C")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2536198", Offset = "0x2536198", VA = "0x2536198")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x2537AF4", Offset = "0x2537AF4", VA = "0x2537AF4")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x25365E0", Offset = "0x25365E0", VA = "0x25365E0")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2537B14", Offset = "0x2537B14", VA = "0x2537B14")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2537B34", Offset = "0x2537B34", VA = "0x2537B34")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2529EA4", Offset = "0x2529EA4", VA = "0x2529EA4")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2537354", Offset = "0x2537354", VA = "0x2537354")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2536600", Offset = "0x2536600", VA = "0x2536600")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x2537B54", Offset = "0x2537B54", VA = "0x2537B54")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x25365C0", Offset = "0x25365C0", VA = "0x25365C0")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x2535B58", Offset = "0x2535B58", VA = "0x2535B58")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x2537B6C", Offset = "0x2537B6C", VA = "0x2537B6C")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x253736C", Offset = "0x253736C", VA = "0x253736C")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x2537B8C", Offset = "0x2537B8C", VA = "0x2537B8C")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x2537C04", Offset = "0x2537C04", VA = "0x2537C04")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x25376CC", Offset = "0x25376CC", VA = "0x25376CC")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x25376E8", Offset = "0x25376E8", VA = "0x25376E8")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x2537244", Offset = "0x2537244", VA = "0x2537244")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x25369DC", Offset = "0x25369DC", VA = "0x25369DC")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x2537CA4", Offset = "0x2537CA4", VA = "0x2537CA4")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x2537CC8", Offset = "0x2537CC8", VA = "0x2537CC8")]
		public static Type GetInterface(Type type, string interfaceName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xBA16E8", Offset = "0xBA16E8")]
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
		[Address(RVA = "0x252E4A8", Offset = "0x252E4A8", VA = "0x252E4A8")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x252E6DC", Offset = "0x252E6DC", VA = "0x252E6DC", Slot = "20")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x252EBDC", Offset = "0x252EBDC", VA = "0x252EBDC", Slot = "21")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x252EDAC", Offset = "0x252EDAC", VA = "0x252EDAC", Slot = "22")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x252EDBC", Offset = "0x252EDBC", VA = "0x252EDBC", Slot = "26")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x252F0A0", Offset = "0x252F0A0", VA = "0x252F0A0", Slot = "27")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x252F0A8", Offset = "0x252F0A8", VA = "0x252F0A8", Slot = "28")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x252F0B8", Offset = "0x252F0B8", VA = "0x252F0B8", Slot = "29")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x252F0BC", Offset = "0x252F0BC", VA = "0x252F0BC", Slot = "30")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x252F0FC", Offset = "0x252F0FC", VA = "0x252F0FC", Slot = "31")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x252F104", Offset = "0x252F104", VA = "0x252F104", Slot = "32")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x252F108", Offset = "0x252F108", VA = "0x252F108", Slot = "33")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x252F1CC", Offset = "0x252F1CC", VA = "0x252F1CC", Slot = "34")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x252F1D4", Offset = "0x252F1D4", VA = "0x252F1D4", Slot = "35")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x252F1D8", Offset = "0x252F1D8", VA = "0x252F1D8", Slot = "36")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x252F218", Offset = "0x252F218", VA = "0x252F218", Slot = "37")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x252F2DC", Offset = "0x252F2DC", VA = "0x252F2DC", Slot = "24")]
		internal override bool Goto(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x252F370", Offset = "0x252F370", VA = "0x252F370")]
		protected void Reset()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x252F410", Offset = "0x252F410", VA = "0x252F410")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x252F550", Offset = "0x252F550", VA = "0x252F550", Slot = "23")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x252F4E8", Offset = "0x252F4E8", VA = "0x252F4E8")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x252E8D8", Offset = "0x252E8D8", VA = "0x252E8D8")]
		private char ReadCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x252EDC4", Offset = "0x252EDC4", VA = "0x252EDC4")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x252E9D4", Offset = "0x252E9D4", VA = "0x252E9D4")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x252FB04", Offset = "0x252FB04", VA = "0x252FB04")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x252FCE8", Offset = "0x252FCE8", VA = "0x252FCE8")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x252E844", Offset = "0x252E844", VA = "0x252E844")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x252FEF0", Offset = "0x252FEF0", VA = "0x252FEF0")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x252E62C", Offset = "0x252E62C", VA = "0x252E62C")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x252FACC", Offset = "0x252FACC", VA = "0x252FACC")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x252FA58", Offset = "0x252FA58", VA = "0x252FA58")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x252FA6C", Offset = "0x252FA6C", VA = "0x252FA6C")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x252E8C4", Offset = "0x252E8C4", VA = "0x252E8C4")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x252E9A8", Offset = "0x252E9A8", VA = "0x252E9A8")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x252FF70", Offset = "0x252FF70", VA = "0x252FF70")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x252FF80", Offset = "0x252FF80", VA = "0x252FF80")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x25300A4", Offset = "0x25300A4", VA = "0x25300A4", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x2530268", Offset = "0x2530268", VA = "0x2530268", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x25302E8", Offset = "0x25302E8", VA = "0x25302E8", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x2530368", Offset = "0x2530368", VA = "0x2530368", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x2530380", Offset = "0x2530380", VA = "0x2530380", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x25303F4", Offset = "0x25303F4", VA = "0x25303F4", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x25304A8", Offset = "0x25304A8", VA = "0x25304A8", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x253055C", Offset = "0x253055C", VA = "0x253055C", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x2530574", Offset = "0x2530574", VA = "0x2530574", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x253058C", Offset = "0x253058C", VA = "0x253058C", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x25305A4", Offset = "0x25305A4", VA = "0x25305A4", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x25305C0", Offset = "0x25305C0", VA = "0x25305C0", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x25305DC", Offset = "0x25305DC", VA = "0x25305DC", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x25305F8", Offset = "0x25305F8", VA = "0x25305F8", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x2530614", Offset = "0x2530614", VA = "0x2530614", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x2530694", Offset = "0x2530694", VA = "0x2530694", Slot = "25")]
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
		[Address(RVA = "0x252AC88", Offset = "0x252AC88", VA = "0x252AC88")]
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
		[Address(RVA = "0x252D154", Offset = "0x252D154", VA = "0x252D154")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x252D224", Offset = "0x252D224", VA = "0x252D224")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x252D2CC", Offset = "0x252D2CC", VA = "0x252D2CC")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x252D2EC", Offset = "0x252D2EC", VA = "0x252D2EC")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x252D368", Offset = "0x252D368", VA = "0x252D368", Slot = "22")]
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
		[Address(RVA = "0x2532178", Offset = "0x2532178", VA = "0x2532178")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x25322BC", Offset = "0x25322BC", VA = "0x25322BC")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x25321C8", Offset = "0x25321C8", VA = "0x25321C8")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x2532314", Offset = "0x2532314", VA = "0x2532314", Slot = "22")]
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
			[Address(RVA = "0x2537E78", Offset = "0x2537E78", VA = "0x2537E78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x2537E9C", Offset = "0x2537E9C", VA = "0x2537E9C")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x2537ECC", Offset = "0x2537ECC", VA = "0x2537ECC")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x2537FCC", Offset = "0x2537FCC", VA = "0x2537FCC", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public static class ES3Stream
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x2534760", Offset = "0x2534760", VA = "0x2534760")]
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
		[Address(RVA = "0x2531F1C", Offset = "0x2531F1C", VA = "0x2531F1C")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x2531F7C", Offset = "0x2531F7C", VA = "0x2531F7C")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBA25B8", Offset = "0xBA25B8")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x2529B24", Offset = "0x2529B24", VA = "0x2529B24")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x253B770", Offset = "0x253B770", VA = "0x253B770")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x253B85C", Offset = "0x253B85C", VA = "0x253B85C")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x253ADC4", Offset = "0x253ADC4", VA = "0x253ADC4")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x253A9D0", Offset = "0x253A9D0", VA = "0x253A9D0")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class ES3WebClass
	{
		[Token(Token = "0x20001A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBA1720", Offset = "0xBA1720")]
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
				[Address(RVA = "0x2FFA1C0", Offset = "0x2FFA1C0", VA = "0x2FFA1C0", Slot = "4")]
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
				[Address(RVA = "0x2FFA208", Offset = "0x2FFA208", VA = "0x2FFA208", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x2FFA120", Offset = "0x2FFA120", VA = "0x2FFA120")]
			[DebuggerHidden]
			public <SendWebRequest>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x2FFA14C", Offset = "0x2FFA14C", VA = "0x2FFA14C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x2FFA150", Offset = "0x2FFA150", VA = "0x2FFA150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x2FFA1C8", Offset = "0x2FFA1C8", VA = "0x2FFA1C8", Slot = "8")]
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
			[Address(RVA = "0x2571D7C", Offset = "0x2571D7C", VA = "0x2571D7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x2571DBC", Offset = "0x2571DBC", VA = "0x2571DBC")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x2571E70", Offset = "0x2571E70", VA = "0x2571E70")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x2571F14", Offset = "0x2571F14", VA = "0x2571F14")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x2571FB4", Offset = "0x2571FB4", VA = "0x2571FB4")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x2572114", Offset = "0x2572114", VA = "0x2572114")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x2572304", Offset = "0x2572304", VA = "0x2572304")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBA476C", Offset = "0xBA476C")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x257237C", Offset = "0x257237C", VA = "0x257237C", Slot = "4")]
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
		[Address(RVA = "0x25306B0", Offset = "0x25306B0", VA = "0x25306B0")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x25306BC", Offset = "0x25306BC", VA = "0x25306BC")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x2530774", Offset = "0x2530774", VA = "0x2530774", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x2530798", Offset = "0x2530798", VA = "0x2530798", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x253083C", Offset = "0x253083C", VA = "0x253083C", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x25308C4", Offset = "0x25308C4", VA = "0x25308C4", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x2530968", Offset = "0x2530968", VA = "0x2530968", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x2530A0C", Offset = "0x2530A0C", VA = "0x2530A0C", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x2530A30", Offset = "0x2530A30", VA = "0x2530A30", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x2530A54", Offset = "0x2530A54", VA = "0x2530A54", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x2530A78", Offset = "0x2530A78", VA = "0x2530A78", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x2530B0C", Offset = "0x2530B0C", VA = "0x2530B0C", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x2530BA0", Offset = "0x2530BA0", VA = "0x2530BA0", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x2530C34", Offset = "0x2530C34", VA = "0x2530C34", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x2530CC8", Offset = "0x2530CC8", VA = "0x2530CC8", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x2530D0C", Offset = "0x2530D0C", VA = "0x2530D0C", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x2530D94", Offset = "0x2530D94", VA = "0x2530D94", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x2530FCC", Offset = "0x2530FCC", VA = "0x2530FCC", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x253102C", Offset = "0x253102C", VA = "0x253102C")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x2531060", Offset = "0x2531060", VA = "0x2531060")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x2531098", Offset = "0x2531098", VA = "0x2531098", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x2531114", Offset = "0x2531114", VA = "0x2531114", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x2531148", Offset = "0x2531148", VA = "0x2531148", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x253117C", Offset = "0x253117C", VA = "0x253117C", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x25311D8", Offset = "0x25311D8", VA = "0x25311D8", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x25311DC", Offset = "0x25311DC", VA = "0x25311DC", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x2531210", Offset = "0x2531210", VA = "0x2531210", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x2531240", Offset = "0x2531240", VA = "0x2531240", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x2531268", Offset = "0x2531268", VA = "0x2531268", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x2531290", Offset = "0x2531290", VA = "0x2531290", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x25312C0", Offset = "0x25312C0", VA = "0x25312C0", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x25312C4", Offset = "0x25312C4", VA = "0x25312C4", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x25312D4", Offset = "0x25312D4", VA = "0x25312D4", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x25312E4", Offset = "0x25312E4", VA = "0x25312E4", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x2531314", Offset = "0x2531314", VA = "0x2531314", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x253133C", Offset = "0x253133C", VA = "0x253133C", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x2531340", Offset = "0x2531340", VA = "0x2531340", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x2531344", Offset = "0x2531344", VA = "0x2531344", Slot = "22")]
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
		[Address(RVA = "0x2574070", Offset = "0x2574070", VA = "0x2574070")]
		public ES3XMLWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x257407C", Offset = "0x257407C", VA = "0x257407C")]
		internal ES3XMLWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x2574128", Offset = "0x2574128", VA = "0x2574128", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x257414C", Offset = "0x257414C", VA = "0x257414C", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x2574170", Offset = "0x2574170", VA = "0x2574170", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x2574198", Offset = "0x2574198", VA = "0x2574198", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x25741BC", Offset = "0x25741BC", VA = "0x25741BC", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x25741E0", Offset = "0x25741E0", VA = "0x25741E0", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x2574204", Offset = "0x2574204", VA = "0x2574204", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x2574228", Offset = "0x2574228", VA = "0x2574228", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x257424C", Offset = "0x257424C", VA = "0x257424C", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x2574270", Offset = "0x2574270", VA = "0x2574270", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x2574294", Offset = "0x2574294", VA = "0x2574294", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x2574328", Offset = "0x2574328", VA = "0x2574328", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x25743BC", Offset = "0x25743BC", VA = "0x25743BC", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x2574450", Offset = "0x2574450", VA = "0x2574450", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x25744E4", Offset = "0x25744E4", VA = "0x25744E4", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x257456C", Offset = "0x257456C", VA = "0x257456C", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] bytes)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x2574A18", Offset = "0x2574A18", VA = "0x2574A18", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x2574A1C", Offset = "0x2574A1C", VA = "0x2574A1C", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x2574A20", Offset = "0x2574A20", VA = "0x2574A20", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x2574A28", Offset = "0x2574A28", VA = "0x2574A28", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x2574A34", Offset = "0x2574A34", VA = "0x2574A34", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x2574604", Offset = "0x2574604", VA = "0x2574604")]
		protected void StartWriteProperty(string name, [Optional] ICollection<KeyValuePair<string, object>> attributes)
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x2574AA8", Offset = "0x2574AA8", VA = "0x2574AA8", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x2574B4C", Offset = "0x2574B4C", VA = "0x2574B4C", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x2574B50", Offset = "0x2574B50", VA = "0x2574B50", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x2574B54", Offset = "0x2574B54", VA = "0x2574B54", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x2574B58", Offset = "0x2574B58", VA = "0x2574B58", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x2574B5C", Offset = "0x2574B5C", VA = "0x2574B5C", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x2574B60", Offset = "0x2574B60", VA = "0x2574B60", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x2574B64", Offset = "0x2574B64", VA = "0x2574B64", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x2574B68", Offset = "0x2574B68", VA = "0x2574B68", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x2574B6C", Offset = "0x2574B6C", VA = "0x2574B6C", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x2574B70", Offset = "0x2574B70", VA = "0x2574B70", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x2574B74", Offset = "0x2574B74", VA = "0x2574B74", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x2574BD4", Offset = "0x2574BD4", VA = "0x2574BD4", Slot = "22")]
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
			[Address(RVA = "0x22BE998", Offset = "0x22BE998", VA = "0x22BE998")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x22BE9A0", Offset = "0x22BE9A0", VA = "0x22BE9A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public AESBits EncryptionBits
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x22BE9A8", Offset = "0x22BE9A8", VA = "0x22BE9A8")]
			get
			{
				return default(AESBits);
			}
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x22BE9B0", Offset = "0x22BE9B0", VA = "0x22BE9B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public byte[] Salt
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x22BE9B8", Offset = "0x22BE9B8", VA = "0x22BE9B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x22BE9C0", Offset = "0x22BE9C0", VA = "0x22BE9C0")]
			set
			{
			}
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x22BE32C", Offset = "0x22BE32C", VA = "0x22BE32C")]
		public AESEncryptor(string password, AESBits encryptionBits)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x22BE3E0", Offset = "0x22BE3E0", VA = "0x22BE3E0")]
		public AESEncryptor(string password, AESBits encryptionBits, byte[] salt)
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x22BE4B0", Offset = "0x22BE4B0", VA = "0x22BE4B0")]
		private byte[] Encrypt(byte[] data, byte[] key, byte[] iV)
		{
			return null;
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x22BE614", Offset = "0x22BE614", VA = "0x22BE614")]
		public byte[] Encrypt(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x22BE724", Offset = "0x22BE724", VA = "0x22BE724")]
		private byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x22BE888", Offset = "0x22BE888", VA = "0x22BE888")]
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
		[Address(RVA = "0x25770D8", Offset = "0x25770D8", VA = "0x25770D8")]
		private MD5Core()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x25770E0", Offset = "0x25770E0", VA = "0x25770E0")]
		public static byte[] GetHash(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x2577290", Offset = "0x2577290", VA = "0x2577290")]
		public static byte[] GetHash(string input)
		{
			return null;
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x25772F0", Offset = "0x25772F0", VA = "0x25772F0")]
		public static string GetHashString(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x2577404", Offset = "0x2577404", VA = "0x2577404")]
		public static string GetHashString(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x25774CC", Offset = "0x25774CC", VA = "0x25774CC")]
		public static string GetHashString(string input)
		{
			return null;
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x25771A8", Offset = "0x25771A8", VA = "0x25771A8")]
		public static byte[] GetHash(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x2577FC0", Offset = "0x2577FC0", VA = "0x2577FC0")]
		internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ABCDStruct ABCD, long len)
		{
			return null;
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x257752C", Offset = "0x257752C", VA = "0x257752C")]
		internal static void GetHashBlock(byte[] input, ref ABCDStruct ABCDValue, int ibStart)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x2578390", Offset = "0x2578390", VA = "0x2578390")]
		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x25783B8", Offset = "0x25783B8", VA = "0x25783B8")]
		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x25783E0", Offset = "0x25783E0", VA = "0x25783E0")]
		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x2578404", Offset = "0x2578404", VA = "0x2578404")]
		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x2578428", Offset = "0x2578428", VA = "0x2578428")]
		private static uint LSR(uint i, int s)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x257820C", Offset = "0x257820C", VA = "0x257820C")]
		private static uint[] Converter(byte[] input, int ibStart)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	public class MD5Encryptor
	{
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x2578434", Offset = "0x2578434", VA = "0x2578434")]
		public MD5Encryptor()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x257843C", Offset = "0x257843C", VA = "0x257843C")]
		public string GetMD5(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x2578444", Offset = "0x2578444", VA = "0x2578444")]
		public string GetMD5(string data)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AD")]
	public class Obfuscator
	{
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x2579164", Offset = "0x2579164", VA = "0x2579164")]
		public static byte[] Obfuscate(byte[] data, string key)
		{
			return null;
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x25791FC", Offset = "0x25791FC", VA = "0x25791FC")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x2579288", Offset = "0x2579288", VA = "0x2579288")]
		public Obfuscator()
		{
		}
	}
}
