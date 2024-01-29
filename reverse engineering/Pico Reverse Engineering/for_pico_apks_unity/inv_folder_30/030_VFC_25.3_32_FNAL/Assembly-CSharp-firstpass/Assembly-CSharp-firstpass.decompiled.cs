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
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93EB48", Offset = "0x93EB48")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x945494", Offset = "0x945494")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9454A8", Offset = "0x9454A8")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x94556C", Offset = "0x94556C")]
	private bool <selectionChanged>k__BackingField;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	public bool saveButtonSelected;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x94558C", Offset = "0x94558C")]
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
		[Address(RVA = "0x1906C20", Offset = "0x1906C20", VA = "0x1906C20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public bool selected
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1906C24", Offset = "0x1906C24", VA = "0x1906C24", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1906C2C", Offset = "0x1906C2C", VA = "0x1906C2C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool selectionChanged
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1906C40", Offset = "0x1906C40", VA = "0x1906C40", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x946360", Offset = "0x946360")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1906C48", Offset = "0x1906C48", VA = "0x1906C48", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x946370", Offset = "0x946370")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public bool buttonSelected
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1906C54", Offset = "0x1906C54", VA = "0x1906C54", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1906C5C", Offset = "0x1906C5C", VA = "0x1906C5C", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1906C70", Offset = "0x1906C70", VA = "0x1906C70", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x946380", Offset = "0x946380")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1906C78", Offset = "0x1906C78", VA = "0x1906C78", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x946390", Offset = "0x946390")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool hasButtonSelectedComponents
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1906C84", Offset = "0x1906C84", VA = "0x1906C84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public bool isPrefab
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1906D80", Offset = "0x1906D80", VA = "0x1906D80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1906DA4", Offset = "0x1906DA4", VA = "0x1906DA4")]
	public ES2AutoSaveVariableInfo GetCachedVariableInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1906EBC", Offset = "0x1906EBC", VA = "0x1906EBC")]
	public ES2AutoSaveVariableInfo CacheVariableInfo(ES2AutoSaveVariableInfo variable)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1906F28", Offset = "0x1906F28", VA = "0x1906F28")]
	public void RemoveCachedVariableInfo(string id)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x190707C", Offset = "0x190707C", VA = "0x190707C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1907624", Offset = "0x1907624", VA = "0x1907624")]
	public ES2AutoSaveComponentInfo GetComponentInfo(Component c)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1907748", Offset = "0x1907748", VA = "0x1907748")]
	public ES2AutoSaveComponentInfo GetComponentInfo(string id)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x190784C", Offset = "0x190784C", VA = "0x190784C")]
	public ES2AutoSaveComponentInfo AddComponentInfo(ES2AutoSaveComponentInfo info)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x19078B8", Offset = "0x19078B8", VA = "0x19078B8")]
	public static ES2AutoSave AddAutoSave(GameObject go, Color color, bool hide, bool generateID, string id)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1907D80", Offset = "0x1907D80", VA = "0x1907D80")]
	public static ES2AutoSave GetAutoSave(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1907400", Offset = "0x1907400", VA = "0x1907400")]
	public static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1907DD4", Offset = "0x1907DD4", VA = "0x1907DD4")]
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
	[Address(RVA = "0x1907EE8", Offset = "0x1907EE8", VA = "0x1907EE8")]
	public ES2AutoSaveComponentInfo()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1907F94", Offset = "0x1907F94", VA = "0x1907F94")]
	public ES2AutoSaveComponentInfo(Component c, ES2AutoSave autoSave)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x190816C", Offset = "0x190816C", VA = "0x190816C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x94561C", Offset = "0x94561C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x94564C", Offset = "0x94564C")]
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
		[Address(RVA = "0x190B9B0", Offset = "0x190B9B0", VA = "0x190B9B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x190B9B8", Offset = "0x190B9B8", VA = "0x190B9B8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	[SerializeField]
	public bool selectionChanged
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x190B9CC", Offset = "0x190B9CC", VA = "0x190B9CC", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9463A0", Offset = "0x9463A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x190B9D4", Offset = "0x190B9D4", VA = "0x190B9D4", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9463B0", Offset = "0x9463B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool buttonSelected
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x190B9E0", Offset = "0x190B9E0", VA = "0x190B9E0", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x190B9E8", Offset = "0x190B9E8", VA = "0x190B9E8", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool buttonSelectionChanged
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x190B9FC", Offset = "0x190B9FC", VA = "0x190B9FC", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9463C0", Offset = "0x9463C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x190BA04", Offset = "0x190BA04", VA = "0x190BA04", Slot = "11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9463D0", Offset = "0x9463D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public ES2AutoSave autoSave
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x190BA10", Offset = "0x190BA10", VA = "0x190BA10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1908124", Offset = "0x1908124", VA = "0x1908124")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public UnityEngine.Object undoRecordObject
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x190BACC", Offset = "0x190BACC", VA = "0x190BACC", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public Type type
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1908090", Offset = "0x1908090", VA = "0x1908090")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1908048", Offset = "0x1908048", VA = "0x1908048")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool HasButtonSelectedVariables
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x190BAD0", Offset = "0x190BAD0", VA = "0x190BAD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1907EEC", Offset = "0x1907EEC", VA = "0x1907EEC")]
	public ES2AutoSaveVariableInfo()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1907C38", Offset = "0x1907C38", VA = "0x1907C38")]
	public ES2AutoSaveVariableInfo(string name, Type type, bool isProperty, ES2AutoSave autoSave, ES2AutoSaveVariableInfo previous)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x190BC0C", Offset = "0x190BC0C", VA = "0x190BC0C")]
	public ES2AutoSaveVariableInfo GetVariableInfo(string name)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x190BCF4", Offset = "0x190BCF4", VA = "0x190BCF4")]
	public ES2AutoSaveVariableInfo AddVariableInfo(string name, Type type, bool isProperty, [Optional] ES2AutoSave autoSave, [Optional] ES2AutoSaveVariableInfo previous)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x190BE24", Offset = "0x190BE24", VA = "0x190BE24")]
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
	[Address(RVA = "0x19081F8", Offset = "0x19081F8", VA = "0x19081F8")]
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
		[Address(RVA = "0x19072C4", Offset = "0x19072C4", VA = "0x19072C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x190827C", Offset = "0x190827C", VA = "0x190827C")]
	public void SetFilePath(string filePath)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1908284", Offset = "0x1908284", VA = "0x1908284")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1907588", Offset = "0x1907588", VA = "0x1907588")]
	public void AddAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x19083E4", Offset = "0x19083E4", VA = "0x19083E4")]
	public ES2AutoSave GetAutoSave(string id)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1908460", Offset = "0x1908460", VA = "0x1908460")]
	public void AddChildAutoSave(ES2AutoSave autoSave, string id)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x19084CC", Offset = "0x19084CC", VA = "0x19084CC")]
	public void Save()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1908680", Offset = "0x1908680", VA = "0x1908680")]
	public void Load()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1908B7C", Offset = "0x1908B7C", VA = "0x1908B7C")]
	public void WriteAutoSaves(ES2Writer writer)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1908DE0", Offset = "0x1908DE0", VA = "0x1908DE0")]
	private void WriteAutoSaveRecursive(Transform transform, ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1909314", Offset = "0x1909314", VA = "0x1909314")]
	private void WriteAutoSave(ES2AutoSave autoSave, Transform transform, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1909D3C", Offset = "0x1909D3C", VA = "0x1909D3C")]
	private void WriteVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Writer writer, object obj)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x190A4C4", Offset = "0x190A4C4", VA = "0x190A4C4")]
	public void ReadAutoSaves(ES2Reader reader)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x190A4F8", Offset = "0x190A4F8", VA = "0x190A4F8")]
	private bool ReadAutoSave(ES2Reader reader, [Optional] ES2AutoSave autoSave)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x190AF6C", Offset = "0x190AF6C", VA = "0x190AF6C")]
	private void ReadComponent(ES2AutoSave autoSave, ES2Reader reader)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x190B288", Offset = "0x190B288", VA = "0x190B288")]
	private void ReadVariableRecursive(ES2AutoSave autoSave, ES2AutoSaveVariableInfo variable, ES2Reader reader, object obj)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x190A308", Offset = "0x190A308", VA = "0x190A308")]
	protected void WriteAllComponents(ES2AutoSave autoSave, ES2Writer writer)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x190B720", Offset = "0x190B720", VA = "0x190B720")]
	public void Start()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x190B730", Offset = "0x190B730", VA = "0x190B730")]
	public void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x190B788", Offset = "0x190B788", VA = "0x190B788")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x190B798", Offset = "0x190B798", VA = "0x190B798")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x190B7AC", Offset = "0x190B7AC", VA = "0x190B7AC")]
	public ES2AutoSaveManager()
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EB68", Offset = "0x93EB68")]
public static class ES2DirectoryUtility
{
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x190D430", Offset = "0x190D430", VA = "0x190D430")]
	public static void Delete(string path, bool recursive)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x190D43C", Offset = "0x190D43C", VA = "0x190D43C")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x190D444", Offset = "0x190D444", VA = "0x190D444")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x190D44C", Offset = "0x190D44C", VA = "0x190D44C")]
	public static void CreateDirectory(string path)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x190D454", Offset = "0x190D454", VA = "0x190D454")]
	public static string[] GetDirectories(string path)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x190D45C", Offset = "0x190D45C", VA = "0x190D45C")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EB7C", Offset = "0x93EB7C")]
public static class ES2Dispose
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x190D464", Offset = "0x190D464", VA = "0x190D464")]
	public static void Dispose(BinaryReader reader)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x190D480", Offset = "0x190D480", VA = "0x190D480")]
	public static void Dispose(BinaryWriter writer)
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EB90", Offset = "0x93EB90")]
public static class ES2FileUtility
{
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x190D570", Offset = "0x190D570", VA = "0x190D570")]
	public static void Delete(string path)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x190D568", Offset = "0x190D568", VA = "0x190D568")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x190DA04", Offset = "0x190DA04", VA = "0x190DA04")]
	public static void Move(string from, string to)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x190DEC4", Offset = "0x190DEC4", VA = "0x190DEC4")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x190DE10", Offset = "0x190DE10", VA = "0x190DE10")]
	public static Stream CreateFileStream(string path, ES2Settings.ES2FileMode filemode, int bufferSize)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EBA4", Offset = "0x93EBA4")]
public static class ES2TypeUtility
{
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1B241FC", Offset = "0x1B241FC", VA = "0x1B241FC")]
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
	[Address(RVA = "0x1900FDC", Offset = "0x1900FDC", VA = "0x1900FDC")]
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
	[Address(RVA = "0x1901064", Offset = "0x1901064", VA = "0x1901064")]
	public static void SaveRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1901280", Offset = "0x1901280", VA = "0x1901280")]
	public static void SaveRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1901100", Offset = "0x1901100", VA = "0x1901100")]
	public static void SaveRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1901324", Offset = "0x1901324", VA = "0x1901324")]
	public static void SaveRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1901498", Offset = "0x1901498", VA = "0x1901498")]
	public static void SaveRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1901630", Offset = "0x1901630", VA = "0x1901630")]
	public static void SaveRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x19017BC", Offset = "0x19017BC", VA = "0x19017BC")]
	public static void AppendRaw(string param, string identifier)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x19019E8", Offset = "0x19019E8", VA = "0x19019E8")]
	public static void AppendRaw(string param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1901858", Offset = "0x1901858", VA = "0x1901858")]
	public static void AppendRaw(byte[] param, string identifier)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1901A8C", Offset = "0x1901A8C", VA = "0x1901A8C")]
	public static void AppendRaw(byte[] param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1901C0C", Offset = "0x1901C0C", VA = "0x1901C0C")]
	public static void AppendRaw(TextAsset param, string identifier)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1901DB4", Offset = "0x1901DB4", VA = "0x1901DB4")]
	public static void AppendRaw(TextAsset param, string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1901F4C", Offset = "0x1901F4C", VA = "0x1901F4C")]
	public static void SaveImage(Texture2D tex, string identifier)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1902160", Offset = "0x1902160", VA = "0x1902160")]
	public static byte[] LoadRaw(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x19022DC", Offset = "0x19022DC", VA = "0x19022DC")]
	public static byte[] LoadRaw(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1902444", Offset = "0x1902444", VA = "0x1902444")]
	public static object LoadObject(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x19025D0", Offset = "0x19025D0", VA = "0x19025D0")]
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
	[Address(RVA = "0x190274C", Offset = "0x190274C", VA = "0x190274C")]
	public static ES2Data LoadAll(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x19028C8", Offset = "0x19028C8", VA = "0x19028C8")]
	public static ES2Data LoadAll(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1902A30", Offset = "0x1902A30", VA = "0x1902A30")]
	public static Texture2D LoadImage(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1902C9C", Offset = "0x1902C9C", VA = "0x1902C9C")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1902D10", Offset = "0x1902D10", VA = "0x1902D10")]
	public static AudioClip LoadAudio(string path)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x19031D0", Offset = "0x19031D0", VA = "0x19031D0")]
	public static void CacheFile(string identifier)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1903334", Offset = "0x1903334", VA = "0x1903334")]
	public static bool Exists(string identifier)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x19037F0", Offset = "0x19037F0", VA = "0x19037F0")]
	public static bool Exists(string identifier, ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x190381C", Offset = "0x190381C", VA = "0x190381C")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1903AFC", Offset = "0x1903AFC", VA = "0x1903AFC")]
	public static void Delete(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1903B28", Offset = "0x1903B28", VA = "0x1903B28")]
	public static void DeleteDefaultFolder()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1903E24", Offset = "0x1903E24", VA = "0x1903E24")]
	public static void Rename(string identifier, string newIdentifier)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1904150", Offset = "0x1904150", VA = "0x1904150")]
	public static void Rename(string identifier, string newIdentifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x19041AC", Offset = "0x19041AC", VA = "0x19041AC")]
	public static string[] GetFiles(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1904258", Offset = "0x1904258", VA = "0x1904258")]
	public static string[] GetFiles(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1904284", Offset = "0x1904284", VA = "0x1904284")]
	public static string[] GetFiles(string identifier, string extension)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1904504", Offset = "0x1904504", VA = "0x1904504")]
	public static string[] GetFolders(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x190476C", Offset = "0x190476C", VA = "0x190476C")]
	public static string[] GetFolders(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1904798", Offset = "0x1904798", VA = "0x1904798")]
	public static string[] GetTags(string identifier)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1904948", Offset = "0x1904948", VA = "0x1904948")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93EBB8", Offset = "0x93EBB8")]
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
			[Address(RVA = "0x1EB50A0", Offset = "0x1EB50A0", VA = "0x1EB50A0", Slot = "4")]
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
			[Address(RVA = "0x1EB50E8", Offset = "0x1EB50E8", VA = "0x1EB50E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1EB4FA0", Offset = "0x1EB4FA0", VA = "0x1EB4FA0")]
		[DebuggerHidden]
		public <SaveRoutine>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1EB4FCC", Offset = "0x1EB4FCC", VA = "0x1EB4FCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1EB4FD0", Offset = "0x1EB4FD0", VA = "0x1EB4FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1EB50A8", Offset = "0x1EB50A8", VA = "0x1EB50A8", Slot = "8")]
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
	[Address(RVA = "0x1904978", Offset = "0x1904978", VA = "0x1904978")]
	private void SavePosition()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1904B20", Offset = "0x1904B20", VA = "0x1904B20")]
	private void LoadPosition()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1904C50", Offset = "0x1904C50", VA = "0x1904C50")]
	private void SaveRotation()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1904D44", Offset = "0x1904D44", VA = "0x1904D44")]
	private void LoadRotation()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1904E74", Offset = "0x1904E74", VA = "0x1904E74")]
	private void SaveScale()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1904F60", Offset = "0x1904F60", VA = "0x1904F60")]
	private void LoadScale()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1905090", Offset = "0x1905090", VA = "0x1905090")]
	private void SaveMesh()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1905294", Offset = "0x1905294", VA = "0x1905294")]
	private void LoadMesh()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1905594", Offset = "0x1905594", VA = "0x1905594")]
	private void SaveSphereCollider()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1905760", Offset = "0x1905760", VA = "0x1905760")]
	private void LoadSphereCollider()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1905A0C", Offset = "0x1905A0C", VA = "0x1905A0C")]
	private void SaveCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1905BD8", Offset = "0x1905BD8", VA = "0x1905BD8")]
	private void LoadCapsuleCollider()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1905E84", Offset = "0x1905E84", VA = "0x1905E84")]
	private void SaveBoxCollider()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1906050", Offset = "0x1906050", VA = "0x1906050")]
	private void LoadBoxCollider()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x19062FC", Offset = "0x19062FC", VA = "0x19062FC")]
	private void SaveMeshCollider()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x19064C8", Offset = "0x19064C8", VA = "0x19064C8")]
	private void LoadMeshCollider()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1906774", Offset = "0x1906774", VA = "0x1906774")]
	public void Save()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1906818", Offset = "0x1906818", VA = "0x1906818")]
	public void Load()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x19068BC", Offset = "0x19068BC", VA = "0x19068BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9463E0", Offset = "0x9463E0")]
	private IEnumerator SaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1906934", Offset = "0x1906934", VA = "0x1906934")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x190694C", Offset = "0x190694C", VA = "0x190694C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x190696C", Offset = "0x190696C", VA = "0x190696C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1906AE0", Offset = "0x1906AE0", VA = "0x1906AE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1906AF8", Offset = "0x1906AF8", VA = "0x1906AF8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1904A64", Offset = "0x1904A64", VA = "0x1904A64")]
	private string GetFullFilename(string tagExtension)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x19069CC", Offset = "0x19069CC", VA = "0x19069CC")]
	private void InitializeSettings()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1906B10", Offset = "0x1906B10", VA = "0x1906B10")]
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
	[Address(RVA = "0x190BE9C", Offset = "0x190BE9C", VA = "0x190BE9C")]
	public static ES2CachedFile AddNewCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x190BFE8", Offset = "0x190BFE8", VA = "0x190BFE8")]
	public static bool DeleteCachedFile(string absolutePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x190C074", Offset = "0x190C074", VA = "0x190C074")]
	public static ES2CachedFile GetOrCreateCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x190C140", Offset = "0x190C140", VA = "0x190C140")]
	public static ES2CachedFile GetCachedFile(string absolutePath)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x190C1EC", Offset = "0x190C1EC", VA = "0x190C1EC")]
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
	[Address(RVA = "0x190C6C4", Offset = "0x190C6C4", VA = "0x190C6C4")]
	public void AddTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x190C720", Offset = "0x190C720", VA = "0x190C720")]
	public void AddTag(ES2Tag tag)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x190C7B4", Offset = "0x190C7B4", VA = "0x190C7B4")]
	public ES2Tag AddOrUpdateTag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x190C8F8", Offset = "0x190C8F8", VA = "0x190C8F8")]
	public ES2Tag GetTag(string tag)
	{
		return default(ES2Tag);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x190C9B8", Offset = "0x190C9B8", VA = "0x190C9B8")]
	public bool RemoveTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x190CA1C", Offset = "0x190CA1C", VA = "0x190CA1C")]
	public void RenameTag(string oldTag, string newTag)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x190CAE8", Offset = "0x190CAE8", VA = "0x190CAE8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x190BF64", Offset = "0x190BF64", VA = "0x190BF64")]
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
	[Address(RVA = "0x1B21D70", Offset = "0x1B21D70", VA = "0x1B21D70")]
	public ES2Tag(string tag, long position, long settingsPosition, long nextTagPosition)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1B20A40", Offset = "0x1B20A40", VA = "0x1B20A40")]
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
	[Address(RVA = "0x190D108", Offset = "0x190D108", VA = "0x190D108")]
	public void Add(string tag, object value)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x190D174", Offset = "0x190D174", VA = "0x190D174")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x190D1D8", Offset = "0x190D1D8", VA = "0x190D1D8")]
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
	[Address(RVA = "0x190D3AC", Offset = "0x190D3AC", VA = "0x190D3AC")]
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
	[Address(RVA = "0x190D49C", Offset = "0x190D49C", VA = "0x190D49C")]
	public ES2EditorWindowStyle()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EBC8", Offset = "0x93EBC8")]
public static class ES2File
{
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x190387C", Offset = "0x190387C", VA = "0x190387C")]
	public static void Delete(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x190D4E8", Offset = "0x190D4E8", VA = "0x190D4E8")]
	public static void DeleteFile(ES2Settings settings)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x190D578", Offset = "0x190D578", VA = "0x190D578")]
	public static void Delete(string identifier)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1903394", Offset = "0x1903394", VA = "0x1903394")]
	public static bool Exists(ES2Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x190D6C0", Offset = "0x190D6C0", VA = "0x190D6C0")]
	private static bool CheckForTagInBytes(string tag, byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x190D910", Offset = "0x190D910", VA = "0x190D910")]
	public static void CreateFolder(string identifier)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1903EAC", Offset = "0x1903EAC", VA = "0x1903EAC")]
	public static void Rename(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x190D918", Offset = "0x190D918", VA = "0x190D918")]
	public static void MoveFile(ES2Settings settings, ES2Settings newSettings)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1904564", Offset = "0x1904564", VA = "0x1904564")]
	public static string[] GetFolders(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x190420C", Offset = "0x190420C", VA = "0x190420C")]
	public static string[] GetFiles(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x19042F4", Offset = "0x19042F4", VA = "0x19042F4")]
	public static string[] GetFiles(ES2Settings settings, string extension)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x19047F8", Offset = "0x19047F8", VA = "0x19047F8")]
	public static string[] GetTags(ES2Settings settings)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class ES2Reflection
{
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1B21FA4", Offset = "0x1B21FA4", VA = "0x1B21FA4")]
	public static bool SetValue(object obj, string name, object value, bool isProperty = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1B22070", Offset = "0x1B22070", VA = "0x1B22070")]
	public static object GetValue(object obj, string name, bool isProperty = false)
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1B1D2E8", Offset = "0x1B1D2E8", VA = "0x1B1D2E8")]
	public static bool IsAssignableFrom(Type a, Type b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1B1D308", Offset = "0x1B1D308", VA = "0x1B1D308")]
	public static bool IsGenericType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1B22148", Offset = "0x1B22148", VA = "0x1B22148")]
	public static Type[] GetGenericArguments(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1B1E824", Offset = "0x1B1E824", VA = "0x1B1E824")]
	public static object CreateGenericInstance(Type type, Type genericType)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1B1EC54", Offset = "0x1B1EC54", VA = "0x1B1EC54")]
	public static object CreateGenericInstance(Type type, Type genericType, Type genericType2)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1B22168", Offset = "0x1B22168", VA = "0x1B22168")]
	public static bool IsCollectionType(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x93EBDC", Offset = "0x93EBDC")]
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
		[Address(RVA = "0x1B236A0", Offset = "0x1B236A0", VA = "0x1B236A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1B236A4", Offset = "0x1B236A4", VA = "0x1B236A4")]
		set
		{
		}
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1B22CE8", Offset = "0x1B22CE8", VA = "0x1B22CE8")]
	public ES2Spreadsheet()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1B22EC4", Offset = "0x1B22EC4", VA = "0x1B22EC4")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1B231AC", Offset = "0x1B231AC", VA = "0x1B231AC")]
	public string GetCell(int col, int row)
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1B22FFC", Offset = "0x1B22FFC", VA = "0x1B22FFC")]
	private void SizeSpreadsheetToFitRow(int row)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1B2328C", Offset = "0x1B2328C", VA = "0x1B2328C")]
	public void Save(string path)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1B232F8", Offset = "0x1B232F8", VA = "0x1B232F8")]
	public void Save(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1B22D9C", Offset = "0x1B22D9C", VA = "0x1B22D9C")]
	private static void GetCharacterConstants()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1B236A8", Offset = "0x1B236A8", VA = "0x1B236A8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x93EC14", Offset = "0x93EC14")]
public class ES2SpreadsheetRow
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<string> cells;

	[Token(Token = "0x1700001B")]
	public int cellCount
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1B23600", Offset = "0x1B23600", VA = "0x1B23600")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001C")]
	public string Item
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1B23288", Offset = "0x1B23288", VA = "0x1B23288")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1B23B04", Offset = "0x1B23B04", VA = "0x1B23B04")]
		set
		{
		}
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1B23134", Offset = "0x1B23134", VA = "0x1B23134")]
	public void SetCell(int col, string value)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1B238AC", Offset = "0x1B238AC", VA = "0x1B238AC")]
	public string GetCell(int col)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1B235E8", Offset = "0x1B235E8", VA = "0x1B235E8")]
	public byte[] GetCellBytes(int col)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1B237F8", Offset = "0x1B237F8", VA = "0x1B237F8")]
	private void SizeRowToFitColumn(int col)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1B23970", Offset = "0x1B23970", VA = "0x1B23970")]
	private byte[] GetBytes(string data)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1B23B08", Offset = "0x1B23B08", VA = "0x1B23B08", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1B230B0", Offset = "0x1B230B0", VA = "0x1B230B0")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93EC4C", Offset = "0x93EC4C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93EC5C", Offset = "0x93EC5C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93EC6C", Offset = "0x93EC6C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93EC7C", Offset = "0x93EC7C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93EC8C", Offset = "0x93EC8C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93EC9C", Offset = "0x93EC9C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ECAC", Offset = "0x93ECAC")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ECBC", Offset = "0x93ECBC")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ECCC", Offset = "0x93ECCC")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ECDC", Offset = "0x93ECDC")]
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
			[Address(RVA = "0x1EB5B28", Offset = "0x1EB5B28", VA = "0x1EB5B28", Slot = "4")]
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
			[Address(RVA = "0x1EB5B70", Offset = "0x1EB5B70", VA = "0x1EB5B70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1EB59DC", Offset = "0x1EB59DC", VA = "0x1EB59DC")]
		[DebuggerHidden]
		public <UploadRaw>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1EB5A08", Offset = "0x1EB5A08", VA = "0x1EB5A08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1EB5A0C", Offset = "0x1EB5A0C", VA = "0x1EB5A0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1EB5B30", Offset = "0x1EB5B30", VA = "0x1EB5B30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ECEC", Offset = "0x93ECEC")]
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
			[Address(RVA = "0x1EB598C", Offset = "0x1EB598C", VA = "0x1EB598C", Slot = "4")]
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
			[Address(RVA = "0x1EB59D4", Offset = "0x1EB59D4", VA = "0x1EB59D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1EB5834", Offset = "0x1EB5834", VA = "0x1EB5834")]
		[DebuggerHidden]
		public <UploadImage>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1EB5860", Offset = "0x1EB5860", VA = "0x1EB5860", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1EB5864", Offset = "0x1EB5864", VA = "0x1EB5864", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1EB5994", Offset = "0x1EB5994", VA = "0x1EB5994", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ECFC", Offset = "0x93ECFC")]
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
			[Address(RVA = "0x1EB57E4", Offset = "0x1EB57E4", VA = "0x1EB57E4", Slot = "4")]
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
			[Address(RVA = "0x1EB582C", Offset = "0x1EB582C", VA = "0x1EB582C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1EB565C", Offset = "0x1EB565C", VA = "0x1EB565C")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1EB5688", Offset = "0x1EB5688", VA = "0x1EB5688", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1EB568C", Offset = "0x1EB568C", VA = "0x1EB568C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1EB57EC", Offset = "0x1EB57EC", VA = "0x1EB57EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ED0C", Offset = "0x93ED0C")]
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
			[Address(RVA = "0x1EB560C", Offset = "0x1EB560C", VA = "0x1EB560C", Slot = "4")]
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
			[Address(RVA = "0x1EB5654", Offset = "0x1EB5654", VA = "0x1EB5654", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1EB54C4", Offset = "0x1EB54C4", VA = "0x1EB54C4")]
		[DebuggerHidden]
		public <DownloadFilenames>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1EB54F0", Offset = "0x1EB54F0", VA = "0x1EB54F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1EB54F4", Offset = "0x1EB54F4", VA = "0x1EB54F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1EB5614", Offset = "0x1EB5614", VA = "0x1EB5614", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ED1C", Offset = "0x93ED1C")]
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
			[Address(RVA = "0x1EB5474", Offset = "0x1EB5474", VA = "0x1EB5474", Slot = "4")]
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
			[Address(RVA = "0x1EB54BC", Offset = "0x1EB54BC", VA = "0x1EB54BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1EB532C", Offset = "0x1EB532C", VA = "0x1EB532C")]
		[DebuggerHidden]
		public <Download>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1EB5358", Offset = "0x1EB5358", VA = "0x1EB5358", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1EB535C", Offset = "0x1EB535C", VA = "0x1EB535C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1EB547C", Offset = "0x1EB547C", VA = "0x1EB547C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93ED2C", Offset = "0x93ED2C")]
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
			[Address(RVA = "0x1EB52DC", Offset = "0x1EB52DC", VA = "0x1EB52DC", Slot = "4")]
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
			[Address(RVA = "0x1EB5324", Offset = "0x1EB5324", VA = "0x1EB5324", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1EB50F0", Offset = "0x1EB50F0", VA = "0x1EB50F0")]
		[DebuggerHidden]
		public <Delete>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1EB511C", Offset = "0x1EB511C", VA = "0x1EB511C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1EB5120", Offset = "0x1EB5120", VA = "0x1EB5120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1EB52E4", Offset = "0x1EB52E4", VA = "0x1EB52E4", Slot = "8")]
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
		[Address(RVA = "0x1B24314", Offset = "0x1B24314", VA = "0x1B24314")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public string text
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1B24330", Offset = "0x1B24330", VA = "0x1B24330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public float progress
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1B2434C", Offset = "0x1B2434C", VA = "0x1B2434C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000020")]
	public float uploadProgress
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1B24368", Offset = "0x1B24368", VA = "0x1B24368")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1B24384", Offset = "0x1B24384", VA = "0x1B24384")]
	public ES2Web(string identifier)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1B24434", Offset = "0x1B24434", VA = "0x1B24434")]
	public ES2Web(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000125")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946490", Offset = "0x946490")]
	public IEnumerator Upload<T>(T param)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9464F0", Offset = "0x9464F0")]
	public IEnumerator Upload<T>(T[] param)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946550", Offset = "0x946550")]
	public IEnumerator Upload<T>(T[,] param)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9465B0", Offset = "0x9465B0")]
	public IEnumerator Upload<T>(T[,,] param)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946610", Offset = "0x946610")]
	public IEnumerator Upload<TKey, TValue>(Dictionary<TKey, TValue> param)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946670", Offset = "0x946670")]
	public IEnumerator Upload<T>(List<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9466D0", Offset = "0x9466D0")]
	public IEnumerator Upload<T>(HashSet<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946730", Offset = "0x946730")]
	public IEnumerator Upload<T>(Queue<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946790", Offset = "0x946790")]
	public IEnumerator Upload<T>(Stack<T> param)
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1B244D4", Offset = "0x1B244D4", VA = "0x1B244D4")]
	public IEnumerator UploadRaw(string data)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1B24520", Offset = "0x1B24520", VA = "0x1B24520")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9467F0", Offset = "0x9467F0")]
	public IEnumerator UploadRaw(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1B245B4", Offset = "0x1B245B4", VA = "0x1B245B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946850", Offset = "0x946850")]
	public IEnumerator UploadImage(Texture2D tex)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1B24648", Offset = "0x1B24648", VA = "0x1B24648")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9468B0", Offset = "0x9468B0")]
	public IEnumerator UploadFile(string file)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1B246DC", Offset = "0x1B246DC", VA = "0x1B246DC")]
	public Texture2D LoadImage()
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1B248A8", Offset = "0x1B248A8", VA = "0x1B248A8")]
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
	[Address(RVA = "0x1B248E0", Offset = "0x1B248E0", VA = "0x1B248E0")]
	public void SaveToFile(string identifier)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1B24970", Offset = "0x1B24970", VA = "0x1B24970")]
	public void SaveToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1B24A20", Offset = "0x1B24A20", VA = "0x1B24A20")]
	public void AppendToFile(string identifier)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1B24AB0", Offset = "0x1B24AB0", VA = "0x1B24AB0")]
	public void AppendToFile(string identifier, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1B24B5C", Offset = "0x1B24B5C", VA = "0x1B24B5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946910", Offset = "0x946910")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1B24BD4", Offset = "0x1B24BD4", VA = "0x1B24BD4")]
	public string[] GetFilenames()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1B24C74", Offset = "0x1B24C74", VA = "0x1B24C74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x946970", Offset = "0x946970")]
	public IEnumerator Download()
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1B24CEC", Offset = "0x1B24CEC", VA = "0x1B24CEC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9469D0", Offset = "0x9469D0")]
	public IEnumerator Delete()
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1B24D64", Offset = "0x1B24D64", VA = "0x1B24D64")]
	private WWWForm CreateUploadForm(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1B24F5C", Offset = "0x1B24F5C", VA = "0x1B24F5C")]
	private WWWForm CreateDownloadForm()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1B25048", Offset = "0x1B25048", VA = "0x1B25048")]
	private WWWForm CreateGetFilesForm()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1B2476C", Offset = "0x1B2476C", VA = "0x1B2476C")]
	private void CheckWWWUsage()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1B24804", Offset = "0x1B24804", VA = "0x1B24804")]
	private void CheckDownloadUsage()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1B250C8", Offset = "0x1B250C8", VA = "0x1B250C8")]
	private bool getError()
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1B24E18", Offset = "0x1B24E18", VA = "0x1B24E18")]
	private WWWForm CreateForm()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1B253CC", Offset = "0x1B253CC", VA = "0x1B253CC")]
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
	[Address(RVA = "0x1B1C9EC", Offset = "0x1B1C9EC", VA = "0x1B1C9EC")]
	public ES2Header(ES2Keys.Key collectionType, int keyType, int valueType, ES2Settings settings)
	{
	}
}
[Token(Token = "0x200002F")]
public class ES2Reader : IDisposable
{
	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9457CC", Offset = "0x9457CC")]
	public ES2Stream stream;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ES2Settings settings;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9457E0", Offset = "0x9457E0")]
	private ES2CachedFile cachedFile;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9457F4", Offset = "0x9457F4")]
	public ES2Tag currentTag;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BinaryReader reader;

	[Token(Token = "0x1700003F")]
	public int Length
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1B2024C", Offset = "0x1B2024C", VA = "0x1B2024C")]
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
	[Address(RVA = "0x1B1E0BC", Offset = "0x1B1E0BC", VA = "0x1B1E0BC")]
	public Array ReadSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1B1E514", Offset = "0x1B1E514", VA = "0x1B1E514")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946EE0", Offset = "0x946EE0")]
	public ICollection ReadICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1B1E8F4", Offset = "0x1B1E8F4", VA = "0x1B1E8F4")]
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
	[Address(RVA = "0x1B1E264", Offset = "0x1B1E264", VA = "0x1B1E264")]
	private Array ReadEncryptedSystemArray(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1B1E6CC", Offset = "0x1B1E6CC", VA = "0x1B1E6CC")]
	private ICollection ReadEncryptedICollection(Type collectionType, ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1B1EAF4", Offset = "0x1B1EAF4", VA = "0x1B1EAF4")]
	private IDictionary ReadEncryptedIDictionary(Type dictionaryType, ES2Type keyType, ES2Type valueType)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1B1EDD0", Offset = "0x1B1EDD0", VA = "0x1B1EDD0")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey, string tag)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x1B1F3E8", Offset = "0x1B1F3E8", VA = "0x1B1F3E8")]
	protected void ProcessHeader(ES2Keys.Key expectedCollectionType, ES2Type expectedValue, ES2Type expectedKey)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1B1F14C", Offset = "0x1B1F14C", VA = "0x1B1F14C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946EF4", Offset = "0x946EF4")]
	public ES2Header ReadHeader()
	{
		return default(ES2Header);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1B1F690", Offset = "0x1B1F690", VA = "0x1B1F690")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946F08", Offset = "0x946F08")]
	public bool Next()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1B1F880", Offset = "0x1B1F880", VA = "0x1B1F880")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946F1C", Offset = "0x946F1C")]
	public void Skip()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1B1F8B8", Offset = "0x1B1F8B8", VA = "0x1B1F8B8")]
	protected bool WriteBytesBeforeTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1B1F9F8", Offset = "0x1B1F9F8", VA = "0x1B1F9F8")]
	protected bool WriteRemainingBytes(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1B1FB28", Offset = "0x1B1FB28", VA = "0x1B1FB28")]
	protected bool WriteBytesBeforeTagLowMemory(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1B1FD00", Offset = "0x1B1FD00", VA = "0x1B1FD00")]
	protected bool WriteRemainingBytesLowMemory(ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1B1FEE0", Offset = "0x1B1FEE0", VA = "0x1B1FEE0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946F30", Offset = "0x946F30")]
	public bool RenameTag(string oldTag, string newTag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1B20164", Offset = "0x1B20164", VA = "0x1B20164")]
	protected bool DeleteTag(string tag, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1B20308", Offset = "0x1B20308", VA = "0x1B20308")]
	protected void WriteCurrentTag(ES2Writer writer)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1B20388", Offset = "0x1B20388", VA = "0x1B20388")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946F44", Offset = "0x946F44")]
	public bool DeleteTags(ICollection<string> tags, ES2Writer writer)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1B2078C", Offset = "0x1B2078C", VA = "0x1B2078C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946F58", Offset = "0x946F58")]
	public string[] GetTags()
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1B20874", Offset = "0x1B20874", VA = "0x1B20874")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946F6C", Offset = "0x946F6C")]
	public byte[] ReadMeshSettings()
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1B208BC", Offset = "0x1B208BC", VA = "0x1B208BC")]
	private byte[] GetDecryptedBytes()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1B1ED5C", Offset = "0x1B1ED5C", VA = "0x1B1ED5C")]
	private ES2Reader GetEncryptedReader()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1B2027C", Offset = "0x1B2027C", VA = "0x1B2027C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946F80", Offset = "0x946F80")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1B20AB0", Offset = "0x1B20AB0", VA = "0x1B20AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1B20ABC", Offset = "0x1B20ABC", VA = "0x1B20ABC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946F94", Offset = "0x946F94")]
	public void CacheFile()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1B1F028", Offset = "0x1B1F028", VA = "0x1B1F028")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946FA8", Offset = "0x946FA8")]
	public bool ScanToTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1B20B88", Offset = "0x1B20B88", VA = "0x1B20B88")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946FBC", Offset = "0x946FBC")]
	public bool ScanToTag()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1B20BA4", Offset = "0x1B20BA4", VA = "0x1B20BA4")]
	public bool TagExists(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1B20BD4", Offset = "0x1B20BD4", VA = "0x1B20BD4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946FD0", Offset = "0x946FD0")]
	public bool TagExists()
	{
		return default(bool);
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1B20C14", Offset = "0x1B20C14", VA = "0x1B20C14")]
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
	[Address(RVA = "0x1B20C54", Offset = "0x1B20C54", VA = "0x1B20C54")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946FE4", Offset = "0x946FE4")]
	public ES2Data ReadAll()
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1B20D34", Offset = "0x1B20D34", VA = "0x1B20D34")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x946FF8", Offset = "0x946FF8")]
	public object ReadObject()
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1B2133C", Offset = "0x1B2133C", VA = "0x1B2133C")]
	public void ReadObject(object obj)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1B21428", Offset = "0x1B21428", VA = "0x1B21428")]
	public object ReadObject(string tag)
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1B21480", Offset = "0x1B21480", VA = "0x1B21480")]
	public void ReadObject(string tag, object obj)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1B214E8", Offset = "0x1B214E8", VA = "0x1B214E8")]
	public void ReadComponent(GameObject go)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1B21658", Offset = "0x1B21658", VA = "0x1B21658")]
	public void ReadComponent(string tag, GameObject go)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1B216C0", Offset = "0x1B216C0", VA = "0x1B216C0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94700C", Offset = "0x94700C")]
	public Dictionary<string, ES2Header> ReadAllHeaders()
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947020", Offset = "0x947020")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600020C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947034", Offset = "0x947034")]
	public T ReadProperty<T>(T obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947048", Offset = "0x947048")]
	public T[] ReadPropertyArray<T>()
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94705C", Offset = "0x94705C")]
	public T[] ReadPropertyArray<T>(T[] obj) where T : class
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947070", Offset = "0x947070")]
	public T[,] ReadProperty2DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947084", Offset = "0x947084")]
	public T[,,] ReadProperty3DArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947098", Offset = "0x947098")]
	public List<T> ReadPropertyList<T>()
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9470AC", Offset = "0x9470AC")]
	public Queue<T> ReadPropertyQueue<T>()
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9470C0", Offset = "0x9470C0")]
	public Stack<T> ReadPropertyStack<T>()
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9470D4", Offset = "0x9470D4")]
	public Dictionary<TKey, TValue> ReadPropertyDictionary<TKey, TValue>()
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1B1E3B4", Offset = "0x1B1E3B4", VA = "0x1B1E3B4")]
	private static int[] GetMultidimensionalIndices(Array a, int idx)
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1B217D0", Offset = "0x1B217D0", VA = "0x1B217D0")]
	public static ES2Reader Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1B21A28", Offset = "0x1B21A28", VA = "0x1B21A28")]
	public static ES2Reader Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1B219CC", Offset = "0x1B219CC", VA = "0x1B219CC")]
	public static ES2Reader Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1B209D4", Offset = "0x1B209D4", VA = "0x1B209D4")]
	public static ES2Reader Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1B21AD0", Offset = "0x1B21AD0", VA = "0x1B21AD0")]
	public ES2Reader(ES2Settings settings)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1B21C48", Offset = "0x1B21C48", VA = "0x1B21C48")]
	public ES2Reader(byte[] bytes, ES2Settings settings)
	{
	}
}
[Token(Token = "0x2000030")]
public class ES2InvalidDataException : Exception
{
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1B1CA00", Offset = "0x1B1CA00", VA = "0x1B1CA00")]
	public ES2InvalidDataException()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93ED3C", Offset = "0x93ED3C")]
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
		[Address(RVA = "0x190D874", Offset = "0x190D874", VA = "0x190D874")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public string resourcesPath
	{
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x190D5D8", Offset = "0x190D5D8", VA = "0x190D5D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x190DEEC", Offset = "0x190DEEC", VA = "0x190DEEC")]
	public ES2FilenameData(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x190E6B8", Offset = "0x190E6B8", VA = "0x190E6B8")]
	public ES2FilenameData(string path, ES2Settings settings)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x190E01C", Offset = "0x190E01C", VA = "0x190E01C")]
	public void Init(string path, ES2Settings settings, bool useParameters)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x190E93C", Offset = "0x190E93C", VA = "0x190E93C")]
	private void ProcessParameter(string name, string value, ES2Settings settings)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x190E8A8", Offset = "0x190E8A8", VA = "0x190E8A8")]
	private static PathType GetPathType(string path)
	{
		return default(PathType);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x190F3D0", Offset = "0x190F3D0", VA = "0x190F3D0")]
	private static bool PathIsURL(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x190E7E4", Offset = "0x190E7E4", VA = "0x190E7E4")]
	private static bool PathIsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x190F568", Offset = "0x190F568", VA = "0x190F568")]
	private static bool PathIsFolder(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x190D4A4", Offset = "0x190D4A4", VA = "0x190D4A4")]
	public bool HasTag()
	{
		return default(bool);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1903C24", Offset = "0x1903C24", VA = "0x1903C24")]
	public static string GetPersistentPath()
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x190D864", Offset = "0x190D864", VA = "0x190D864")]
	public bool IsURL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x190D4D8", Offset = "0x190D4D8", VA = "0x190D4D8")]
	public bool IsFolder()
	{
		return default(bool);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x190D4C8", Offset = "0x190D4C8", VA = "0x190D4C8")]
	public bool IsFile()
	{
		return default(bool);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x190F5B0", Offset = "0x190F5B0", VA = "0x190F5B0")]
	public bool IsAbsolute()
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x190F5B8", Offset = "0x190F5B8", VA = "0x190F5B8")]
	public string GetSavePath(ES2Settings.SaveLocation saveLocation)
	{
		return null;
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93ED50", Offset = "0x93ED50")]
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
		[Address(RVA = "0x1B1C5C0", Offset = "0x1B1C5C0", VA = "0x1B1C5C0")]
		get
		{
			return default(ES2Settings.SaveLocation);
		}
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1B1C63C", Offset = "0x1B1C63C", VA = "0x1B1C63C")]
		set
		{
		}
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1B1C6A4", Offset = "0x1B1C6A4", VA = "0x1B1C6A4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1B1C874", Offset = "0x1B1C874", VA = "0x1B1C874")]
	public ES2GlobalSettings()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93ED64", Offset = "0x93ED64")]
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
	[Address(RVA = "0x1B1CA7C", Offset = "0x1B1CA7C", VA = "0x1B1CA7C")]
	public static string TypeFromKeys(Key collection, Key value, Key key)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1B1CF18", Offset = "0x1B1CF18", VA = "0x1B1CF18")]
	public static Key[] KeysFromType(Key collectionType, Key valueType, Key keyType)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1B1CFB0", Offset = "0x1B1CFB0", VA = "0x1B1CFB0")]
	public static Key KeyFromES2Type(ES2Type type)
	{
		return default(Key);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1B1CFC4", Offset = "0x1B1CFC4", VA = "0x1B1CFC4")]
	public static Key[] KeysFromES2Type(ES2Type type)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1B1CFE0", Offset = "0x1B1CFE0", VA = "0x1B1CFE0")]
	public static Key[] KeysFromES2Type(ES2Type type, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x1B1D000", Offset = "0x1B1D000", VA = "0x1B1D000")]
	public static Key[] KeysFromES2Type(ES2Type keyType, ES2Type valueType, Key collectionType)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1B1D02C", Offset = "0x1B1D02C", VA = "0x1B1D02C")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x945808", Offset = "0x945808")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94581C", Offset = "0x94581C")]
	public byte meshSettingsCount;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string name;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x945830", Offset = "0x945830")]
	public ES2FileMode fileMode;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int bufferSize;

	[Token(Token = "0x17000043")]
	public string tag
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1B22BEC", Offset = "0x1B22BEC", VA = "0x1B22BEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1B22BF4", Offset = "0x1B22BF4", VA = "0x1B22BF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9485A0", Offset = "0x9485A0")]
	public bool IsImageFile
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1B22BFC", Offset = "0x1B22BFC", VA = "0x1B22BFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x1B22548", Offset = "0x1B22548", VA = "0x1B22548")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9470E8", Offset = "0x9470E8")]
	public void Init()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1B22690", Offset = "0x1B22690", VA = "0x1B22690")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9470FC", Offset = "0x9470FC")]
	public ES2Settings Clone()
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x1B21A50", Offset = "0x1B21A50", VA = "0x1B21A50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947110", Offset = "0x947110")]
	public ES2Settings Clone(string identifier)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x1B227E8", Offset = "0x1B227E8", VA = "0x1B227E8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947124", Offset = "0x947124")]
	public byte[] MeshSettingsToByteArray()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1B228D8", Offset = "0x1B228D8", VA = "0x1B228D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947138", Offset = "0x947138")]
	public void MeshSettingsFromByteArray(byte[] bytes)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x1B2182C", Offset = "0x1B2182C", VA = "0x1B2182C")]
	public ES2Settings(string identifier)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1B22A94", Offset = "0x1B22A94", VA = "0x1B22A94")]
	public ES2Settings(SaveLocation saveLocation)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1B1D4E0", Offset = "0x1B1D4E0", VA = "0x1B1D4E0")]
	public ES2Settings()
	{
	}
}
[Token(Token = "0x200003C")]
internal sealed class ES2FileStream : ES2Stream
{
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x190DA0C", Offset = "0x190DA0C", VA = "0x190DA0C")]
	public ES2FileStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x190DBF0", Offset = "0x190DBF0", VA = "0x190DBF0", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x190DDAC", Offset = "0x190DDAC", VA = "0x190DDAC")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x190DB0C", Offset = "0x190DB0C", VA = "0x190DB0C")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x190DA70", Offset = "0x190DA70", VA = "0x190DA70")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x190DECC", Offset = "0x190DECC", VA = "0x190DECC", Slot = "5")]
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
	[Address(RVA = "0x1B1D328", Offset = "0x1B1D328", VA = "0x1B1D328")]
	public ES2MemoryStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1B1D3BC", Offset = "0x1B1D3BC", VA = "0x1B1D3BC")]
	public ES2MemoryStream(byte[] bytes, ES2Settings settings)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1B1D43C", Offset = "0x1B1D43C", VA = "0x1B1D43C")]
	public ES2MemoryStream()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1B1D624", Offset = "0x1B1D624", VA = "0x1B1D624", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1B1D928", Offset = "0x1B1D928", VA = "0x1B1D928", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1B1D930", Offset = "0x1B1D930", VA = "0x1B1D930", Slot = "6")]
	public override byte[] ReadAllBytes()
	{
		return null;
	}
}
[Token(Token = "0x200003E")]
internal sealed class ES2PlayerPrefsStream : ES2Stream
{
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1B1DA08", Offset = "0x1B1DA08", VA = "0x1B1DA08")]
	public ES2PlayerPrefsStream(ES2Settings settings, Operation operation)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1B1DBE4", Offset = "0x1B1DBE4", VA = "0x1B1DBE4", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x1B1DFEC", Offset = "0x1B1DFEC", VA = "0x1B1DFEC")]
	private void StoreRaw()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1B1DF5C", Offset = "0x1B1DF5C", VA = "0x1B1DF5C")]
	private void StoreRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x1B1E07C", Offset = "0x1B1E07C", VA = "0x1B1E07C")]
	private void StoreRaw(string bytes)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1B1DE80", Offset = "0x1B1DE80", VA = "0x1B1DE80")]
	private void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1B1DE28", Offset = "0x1B1DE28", VA = "0x1B1DE28")]
	private Stream CreateStorageStream()
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1B1DA78", Offset = "0x1B1DA78", VA = "0x1B1DA78")]
	private Stream CreateReadStream()
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x1B1DB8C", Offset = "0x1B1DB8C", VA = "0x1B1DB8C")]
	private Stream CreateWriteStream()
	{
		return null;
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1B1E09C", Offset = "0x1B1E09C", VA = "0x1B1E09C", Slot = "5")]
	public override bool MayRequireOverwrite()
	{
		return default(bool);
	}
}
[Token(Token = "0x200003F")]
internal sealed class ES2ResourcesStream : ES2Stream
{
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1B22250", Offset = "0x1B22250", VA = "0x1B22250")]
	public ES2ResourcesStream(ES2Settings settings)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1B22458", Offset = "0x1B22458", VA = "0x1B22458", Slot = "4")]
	public override void Store()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1B224CC", Offset = "0x1B224CC", VA = "0x1B224CC", Slot = "5")]
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
		[Address(RVA = "0x1B1F818", Offset = "0x1B1F818", VA = "0x1B1F818")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1B23C40", Offset = "0x1B23C40", VA = "0x1B23C40")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public long Position
	{
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1B1F85C", Offset = "0x1B1F85C", VA = "0x1B1F85C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1B1F838", Offset = "0x1B1F838", VA = "0x1B1F838")]
		set
		{
		}
	}

	[Token(Token = "0x600025F")]
	public abstract void Store();

	[Token(Token = "0x6000260")]
	public abstract bool MayRequireOverwrite();

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1B1FA98", Offset = "0x1B1FA98", VA = "0x1B1FA98")]
	public byte[] ReadBytes(int count)
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1B1D944", Offset = "0x1B1D944", VA = "0x1B1D944", Slot = "6")]
	public virtual byte[] ReadAllBytes()
	{
		return null;
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1B1D7D4", Offset = "0x1B1D7D4", VA = "0x1B1D7D4")]
	protected void WriteToStreamFast(Stream writableStream)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1B1D848", Offset = "0x1B1D848", VA = "0x1B1D848")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94714C", Offset = "0x94714C")]
	protected void WriteToStreamLowMemory(Stream writableStream)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1B21F48", Offset = "0x1B21F48", VA = "0x1B21F48")]
	public static ES2Stream Create(byte[] bytes, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1B21DB4", Offset = "0x1B21DB4", VA = "0x1B21DB4")]
	public static ES2Stream Create(ES2Settings settings, Operation operation)
	{
		return null;
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1B1D3B4", Offset = "0x1B1D3B4", VA = "0x1B1D3B4")]
	protected ES2Stream()
	{
	}
}
[Token(Token = "0x2000042")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93ED78", Offset = "0x93ED78")]
public sealed class ES2_BoneWeight : ES2Type
{
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1B272B4", Offset = "0x1B272B4", VA = "0x1B272B4")]
	public ES2_BoneWeight()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x1B27348", Offset = "0x1B27348", VA = "0x1B27348", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1B274D8", Offset = "0x1B274D8", VA = "0x1B274D8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93ED8C", Offset = "0x93ED8C")]
public sealed class ES2_Bounds : ES2Type
{
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1B27678", Offset = "0x1B27678", VA = "0x1B27678")]
	public ES2_Bounds()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x1B2770C", Offset = "0x1B2770C", VA = "0x1B2770C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1B277F0", Offset = "0x1B277F0", VA = "0x1B277F0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EDA0", Offset = "0x93EDA0")]
public sealed class ES2_Color : ES2Type
{
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1B2809C", Offset = "0x1B2809C", VA = "0x1B2809C")]
	public ES2_Color()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1B28130", Offset = "0x1B28130", VA = "0x1B28130", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1B28214", Offset = "0x1B28214", VA = "0x1B28214", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EDB4", Offset = "0x93EDB4")]
public sealed class ES2_Color32 : ES2Type
{
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1B28318", Offset = "0x1B28318", VA = "0x1B28318")]
	public ES2_Color32()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1B283AC", Offset = "0x1B283AC", VA = "0x1B283AC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1B28494", Offset = "0x1B28494", VA = "0x1B28494", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000046")]
public class ES2_DateTime : ES2Type
{
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1B2858C", Offset = "0x1B2858C", VA = "0x1B2858C", Slot = "4")]
	public override void Write(object obj, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1B28648", Offset = "0x1B28648", VA = "0x1B28648", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x1B286E4", Offset = "0x1B286E4", VA = "0x1B286E4")]
	public ES2_DateTime()
	{
	}
}
[Token(Token = "0x2000047")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EDC8", Offset = "0x93EDC8")]
public sealed class ES2_ES2AutoSaveManager : ES2Type
{
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x1B2876C", Offset = "0x1B2876C", VA = "0x1B2876C")]
	public ES2_ES2AutoSaveManager()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x1B287F4", Offset = "0x1B287F4", VA = "0x1B287F4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x1B2888C", Offset = "0x1B2888C", VA = "0x1B2888C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x1B288B0", Offset = "0x1B288B0", VA = "0x1B288B0", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000048")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EDDC", Offset = "0x93EDDC")]
public sealed class ES2_Enum : ES2Type
{
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1B2421C", Offset = "0x1B2421C", VA = "0x1B2421C")]
	public ES2_Enum()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x1B28948", Offset = "0x1B28948", VA = "0x1B28948", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1B289E4", Offset = "0x1B289E4", VA = "0x1B289E4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000049")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EDF0", Offset = "0x93EDF0")]
public sealed class ES2_Gradient : ES2Type
{
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1B28A64", Offset = "0x1B28A64", VA = "0x1B28A64")]
	public ES2_Gradient()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x1B28AEC", Offset = "0x1B28AEC", VA = "0x1B28AEC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x1B28BD8", Offset = "0x1B28BD8", VA = "0x1B28BD8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EE04", Offset = "0x93EE04")]
public sealed class ES2_GradientAlphaKey : ES2Type
{
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1B28D7C", Offset = "0x1B28D7C", VA = "0x1B28D7C")]
	public ES2_GradientAlphaKey()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1B28E04", Offset = "0x1B28E04", VA = "0x1B28E04", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1B28EBC", Offset = "0x1B28EBC", VA = "0x1B28EBC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EE18", Offset = "0x93EE18")]
public sealed class ES2_GradientColorKey : ES2Type
{
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1B28CF4", Offset = "0x1B28CF4", VA = "0x1B28CF4")]
	public ES2_GradientColorKey()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1B28F78", Offset = "0x1B28F78", VA = "0x1B28F78", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1B290C0", Offset = "0x1B290C0", VA = "0x1B290C0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EE2C", Offset = "0x93EE2C")]
public sealed class ES2_Material : ES2Type
{
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1B291B0", Offset = "0x1B291B0", VA = "0x1B291B0")]
	public ES2_Material()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x1B29244", Offset = "0x1B29244", VA = "0x1B29244", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1B2A1CC", Offset = "0x1B2A1CC", VA = "0x1B2A1CC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1B2A278", Offset = "0x1B2A278", VA = "0x1B2A278", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200004D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EE40", Offset = "0x93EE40")]
public sealed class ES2_Matrix4x4 : ES2Type
{
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1B2A680", Offset = "0x1B2A680", VA = "0x1B2A680")]
	public ES2_Matrix4x4()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1B2A714", Offset = "0x1B2A714", VA = "0x1B2A714", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1B2A83C", Offset = "0x1B2A83C", VA = "0x1B2A83C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200004E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EE54", Offset = "0x93EE54")]
public sealed class ES2_Mesh : ES2Type
{
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1B2A93C", Offset = "0x1B2A93C", VA = "0x1B2A93C")]
	public ES2_Mesh()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1B2A9D0", Offset = "0x1B2A9D0", VA = "0x1B2A9D0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1B2AD0C", Offset = "0x1B2AD0C", VA = "0x1B2AD0C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x1B2AD8C", Offset = "0x1B2AD8C", VA = "0x1B2AD8C", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EE68", Offset = "0x93EE68")]
public sealed class ES2_Quaternion : ES2Type
{
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1B2BC78", Offset = "0x1B2BC78", VA = "0x1B2BC78")]
	public ES2_Quaternion()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1B2BD0C", Offset = "0x1B2BD0C", VA = "0x1B2BD0C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x1B2BE10", Offset = "0x1B2BE10", VA = "0x1B2BE10", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EE7C", Offset = "0x93EE7C")]
public sealed class ES2_Rect : ES2Type
{
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x1B2BF14", Offset = "0x1B2BF14", VA = "0x1B2BF14")]
	public ES2_Rect()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x1B2BFA8", Offset = "0x1B2BFA8", VA = "0x1B2BFA8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1B2C0B0", Offset = "0x1B2C0B0", VA = "0x1B2C0B0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EE90", Offset = "0x93EE90")]
public sealed class ES2_Sprite : ES2Type
{
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x1B2CAAC", Offset = "0x1B2CAAC", VA = "0x1B2CAAC")]
	public ES2_Sprite()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x1B2CB40", Offset = "0x1B2CB40", VA = "0x1B2CB40", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x1B2CDD0", Offset = "0x1B2CDD0", VA = "0x1B2CDD0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000052")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EEA4", Offset = "0x93EEA4")]
public sealed class ES2_Texture : ES2Type
{
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x1B2CF20", Offset = "0x1B2CF20", VA = "0x1B2CF20")]
	public ES2_Texture()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1B2CFA8", Offset = "0x1B2CFA8", VA = "0x1B2CFA8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1B2D128", Offset = "0x1B2D128", VA = "0x1B2D128", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x1B2D294", Offset = "0x1B2D294", VA = "0x1B2D294", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000053")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EEB8", Offset = "0x93EEB8")]
public sealed class ES2_Texture2D : ES2Type
{
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1B2D400", Offset = "0x1B2D400", VA = "0x1B2D400")]
	public ES2_Texture2D()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1B2D494", Offset = "0x1B2D494", VA = "0x1B2D494", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x1B2D618", Offset = "0x1B2D618", VA = "0x1B2D618", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x1B2D6A0", Offset = "0x1B2D6A0", VA = "0x1B2D6A0", Slot = "6")]
	public override void Read(ES2Reader reader, object obj)
	{
	}
}
[Token(Token = "0x2000054")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EECC", Offset = "0x93EECC")]
public sealed class ES2_Vector2 : ES2Type
{
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x1B2B300", Offset = "0x1B2B300", VA = "0x1B2B300")]
	public ES2_Vector2()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1B2DC70", Offset = "0x1B2DC70", VA = "0x1B2DC70", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1B2DD2C", Offset = "0x1B2DD2C", VA = "0x1B2DD2C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000055")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EEE0", Offset = "0x93EEE0")]
public sealed class ES2_Vector3 : ES2Type
{
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1B2B1D8", Offset = "0x1B2B1D8", VA = "0x1B2B1D8")]
	public ES2_Vector3()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x1B2DDC4", Offset = "0x1B2DDC4", VA = "0x1B2DDC4", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x1B2DEA4", Offset = "0x1B2DEA4", VA = "0x1B2DEA4", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000056")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EEF4", Offset = "0x93EEF4")]
public sealed class ES2_Vector4 : ES2Type
{
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x1B2B394", Offset = "0x1B2B394", VA = "0x1B2B394")]
	public ES2_Vector4()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x1B2DF64", Offset = "0x1B2DF64", VA = "0x1B2DF64", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x1B2E068", Offset = "0x1B2E068", VA = "0x1B2E068", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000057")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EF08", Offset = "0x93EF08")]
public sealed class ES2_BoxCollider : ES2Type
{
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x1B278D4", Offset = "0x1B278D4", VA = "0x1B278D4")]
	public ES2_BoxCollider()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x1B27968", Offset = "0x1B27968", VA = "0x1B27968", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1B27A7C", Offset = "0x1B27A7C", VA = "0x1B27A7C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1B27AF4", Offset = "0x1B27AF4", VA = "0x1B27AF4", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000058")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EF1C", Offset = "0x93EF1C")]
public sealed class ES2_CapsuleCollider : ES2Type
{
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x1B27C4C", Offset = "0x1B27C4C", VA = "0x1B27C4C")]
	public ES2_CapsuleCollider()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x1B27CE0", Offset = "0x1B27CE0", VA = "0x1B27CE0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x1B27E58", Offset = "0x1B27E58", VA = "0x1B27E58", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x1B27ED0", Offset = "0x1B27ED0", VA = "0x1B27ED0", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x2000059")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EF30", Offset = "0x93EF30")]
public sealed class ES2_MeshCollider : ES2Type
{
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x1B2B428", Offset = "0x1B2B428", VA = "0x1B2B428")]
	public ES2_MeshCollider()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1B2B4BC", Offset = "0x1B2B4BC", VA = "0x1B2B4BC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x1B2B608", Offset = "0x1B2B608", VA = "0x1B2B608", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x1B2B680", Offset = "0x1B2B680", VA = "0x1B2B680", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EF44", Offset = "0x93EF44")]
public sealed class ES2_PolygonCollider2D : ES2Type
{
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x1B2B81C", Offset = "0x1B2B81C", VA = "0x1B2B81C")]
	public ES2_PolygonCollider2D()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x1B2B8B0", Offset = "0x1B2B8B0", VA = "0x1B2B8B0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x1B2BA4C", Offset = "0x1B2BA4C", VA = "0x1B2BA4C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x1B2BAC4", Offset = "0x1B2BAC4", VA = "0x1B2BAC4", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EF58", Offset = "0x93EF58")]
public sealed class ES2_SkinnedMeshRenderer : ES2Type
{
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x1B2C1B4", Offset = "0x1B2C1B4", VA = "0x1B2C1B4")]
	public ES2_SkinnedMeshRenderer()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x1B2C248", Offset = "0x1B2C248", VA = "0x1B2C248", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x1B2C444", Offset = "0x1B2C444", VA = "0x1B2C444", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x1B2C4BC", Offset = "0x1B2C4BC", VA = "0x1B2C4BC", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EF6C", Offset = "0x93EF6C")]
public sealed class ES2_SphereCollider : ES2Type
{
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x1B2C718", Offset = "0x1B2C718", VA = "0x1B2C718")]
	public ES2_SphereCollider()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x1B2C7AC", Offset = "0x1B2C7AC", VA = "0x1B2C7AC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x1B2C8D0", Offset = "0x1B2C8D0", VA = "0x1B2C8D0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x1B2C948", Offset = "0x1B2C948", VA = "0x1B2C948", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EF80", Offset = "0x93EF80")]
public sealed class ES2_Transform : ES2Type
{
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x1B2D87C", Offset = "0x1B2D87C", VA = "0x1B2D87C")]
	public ES2_Transform()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x1B2D910", Offset = "0x1B2D910", VA = "0x1B2D910", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x1B2DA54", Offset = "0x1B2DA54", VA = "0x1B2DA54", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x1B2DACC", Offset = "0x1B2DACC", VA = "0x1B2DACC", Slot = "6")]
	public override void Read(ES2Reader reader, object c)
	{
	}
}
[Token(Token = "0x200005E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EF94", Offset = "0x93EF94")]
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
	[Address(RVA = "0x1B23C64", Offset = "0x1B23C64", VA = "0x1B23C64")]
	public ES2Type(Type type)
	{
	}

	[Token(Token = "0x60002CD")]
	public abstract void Write(object data, ES2Writer writer);

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x1B23CD4", Offset = "0x1B23CD4", VA = "0x1B23CD4", Slot = "5")]
	public virtual object Read(ES2Reader reader)
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x1B23DA0", Offset = "0x1B23DA0", VA = "0x1B23DA0", Slot = "6")]
	public virtual void Read(ES2Reader reader, object c)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x1B23E64", Offset = "0x1B23E64", VA = "0x1B23E64", Slot = "7")]
	public virtual void Read(ES2Reader reader, Component c)
	{
	}

	[Token(Token = "0x60002D1")]
	public static T GetOrCreate<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x1B23CB0", Offset = "0x1B23CB0", VA = "0x1B23CB0")]
	public static int GetHash(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x1B23E70", Offset = "0x1B23E70", VA = "0x1B23E70")]
	public static int GetHash(string value)
	{
		return default(int);
	}
}
[Token(Token = "0x200005F")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EFA8", Offset = "0x93EFA8")]
public static class ES2TypeManager
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<Type, ES2Type> types;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES2Type cachedType;

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x1B23F60", Offset = "0x1B23F60", VA = "0x1B23F60")]
	public static void AddES2Type(ES2Type es2Type)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x1B23FF4", Offset = "0x1B23FF4", VA = "0x1B23FF4")]
	public static ES2Type GetES2Type(Type type)
	{
		return null;
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x1B1F404", Offset = "0x1B1F404", VA = "0x1B1F404")]
	public static ES2Type GetES2Type(byte key)
	{
		return null;
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x1B242B0", Offset = "0x1B242B0", VA = "0x1B242B0")]
	public static ES2Type GetES2Type(ES2Keys.Key key)
	{
		return null;
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x1B210B0", Offset = "0x1B210B0", VA = "0x1B210B0")]
	public static ES2Type GetES2Type(int hash)
	{
		return null;
	}
}
[Token(Token = "0x2000060")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EFBC", Offset = "0x93EFBC")]
public sealed class ES2_bool : ES2Type
{
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x1B2E16C", Offset = "0x1B2E16C", VA = "0x1B2E16C")]
	public ES2_bool()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x1B2E200", Offset = "0x1B2E200", VA = "0x1B2E200", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x1B2E298", Offset = "0x1B2E298", VA = "0x1B2E298", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000061")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EFD0", Offset = "0x93EFD0")]
public sealed class ES2_byte : ES2Type
{
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x1B2E318", Offset = "0x1B2E318", VA = "0x1B2E318")]
	public ES2_byte()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x1B2E3A8", Offset = "0x1B2E3A8", VA = "0x1B2E3A8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x1B2E440", Offset = "0x1B2E440", VA = "0x1B2E440", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000062")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EFE4", Offset = "0x93EFE4")]
public sealed class ES2_char : ES2Type
{
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x1B2E4BC", Offset = "0x1B2E4BC", VA = "0x1B2E4BC")]
	public ES2_char()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x1B2E550", Offset = "0x1B2E550", VA = "0x1B2E550", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x1B2E5EC", Offset = "0x1B2E5EC", VA = "0x1B2E5EC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000063")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93EFF8", Offset = "0x93EFF8")]
public sealed class ES2_decimal : ES2Type
{
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1B2E66C", Offset = "0x1B2E66C", VA = "0x1B2E66C")]
	public ES2_decimal()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x1B2E700", Offset = "0x1B2E700", VA = "0x1B2E700", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x1B2E79C", Offset = "0x1B2E79C", VA = "0x1B2E79C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000064")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F00C", Offset = "0x93F00C")]
public sealed class ES2_double : ES2Type
{
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x1B2E81C", Offset = "0x1B2E81C", VA = "0x1B2E81C")]
	public ES2_double()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x1B2E8B0", Offset = "0x1B2E8B0", VA = "0x1B2E8B0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x1B2E94C", Offset = "0x1B2E94C", VA = "0x1B2E94C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000065")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F020", Offset = "0x93F020")]
public sealed class ES2_float : ES2Type
{
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x1B2E9C8", Offset = "0x1B2E9C8", VA = "0x1B2E9C8")]
	public ES2_float()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x1B2EA5C", Offset = "0x1B2EA5C", VA = "0x1B2EA5C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1B2EAF8", Offset = "0x1B2EAF8", VA = "0x1B2EAF8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000066")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F034", Offset = "0x93F034")]
public sealed class ES2_int : ES2Type
{
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x1B2B26C", Offset = "0x1B2B26C", VA = "0x1B2B26C")]
	public ES2_int()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x1B2EB74", Offset = "0x1B2EB74", VA = "0x1B2EB74", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1B2EC10", Offset = "0x1B2EC10", VA = "0x1B2EC10", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000067")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F048", Offset = "0x93F048")]
public sealed class ES2_long : ES2Type
{
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x1B2EC90", Offset = "0x1B2EC90", VA = "0x1B2EC90")]
	public ES2_long()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x1B2ED24", Offset = "0x1B2ED24", VA = "0x1B2ED24", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1B2EDC0", Offset = "0x1B2EDC0", VA = "0x1B2EDC0", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000068")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F05C", Offset = "0x93F05C")]
public sealed class ES2_object : ES2Type
{
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1B2EE40", Offset = "0x1B2EE40", VA = "0x1B2EE40")]
	public ES2_object()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x1B2EEC8", Offset = "0x1B2EEC8", VA = "0x1B2EEC8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x1B2F050", Offset = "0x1B2F050", VA = "0x1B2F050", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x2000069")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F070", Offset = "0x93F070")]
public sealed class ES2_sbyte : ES2Type
{
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x1B2F164", Offset = "0x1B2F164", VA = "0x1B2F164")]
	public ES2_sbyte()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x1B2F1F8", Offset = "0x1B2F1F8", VA = "0x1B2F1F8", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x1B2F290", Offset = "0x1B2F290", VA = "0x1B2F290", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006A")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F084", Offset = "0x93F084")]
public sealed class ES2_short : ES2Type
{
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x1B2F30C", Offset = "0x1B2F30C", VA = "0x1B2F30C")]
	public ES2_short()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x1B2F3A0", Offset = "0x1B2F3A0", VA = "0x1B2F3A0", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x1B2F43C", Offset = "0x1B2F43C", VA = "0x1B2F43C", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006B")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F098", Offset = "0x93F098")]
public sealed class ES2_string : ES2Type
{
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x1B2F4BC", Offset = "0x1B2F4BC", VA = "0x1B2F4BC")]
	public ES2_string()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x1B2F550", Offset = "0x1B2F550", VA = "0x1B2F550", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x1B2F5DC", Offset = "0x1B2F5DC", VA = "0x1B2F5DC", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006C")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F0AC", Offset = "0x93F0AC")]
public sealed class ES2_uint : ES2Type
{
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x1B2F608", Offset = "0x1B2F608", VA = "0x1B2F608")]
	public ES2_uint()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x1B2F69C", Offset = "0x1B2F69C", VA = "0x1B2F69C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x1B2F738", Offset = "0x1B2F738", VA = "0x1B2F738", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006D")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F0C0", Offset = "0x93F0C0")]
public sealed class ES2_ulong : ES2Type
{
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x1B2F7B8", Offset = "0x1B2F7B8", VA = "0x1B2F7B8")]
	public ES2_ulong()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x1B2F84C", Offset = "0x1B2F84C", VA = "0x1B2F84C", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x1B2F8E8", Offset = "0x1B2F8E8", VA = "0x1B2F8E8", Slot = "5")]
	public override object Read(ES2Reader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006E")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F0D4", Offset = "0x93F0D4")]
public sealed class ES2_ushort : ES2Type
{
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x1B2F968", Offset = "0x1B2F968", VA = "0x1B2F968")]
	public ES2_ushort()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x1B2F9FC", Offset = "0x1B2F9FC", VA = "0x1B2F9FC", Slot = "4")]
	public override void Write(object data, ES2Writer writer)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x1B2FA98", Offset = "0x1B2FA98", VA = "0x1B2FA98", Slot = "5")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x945844", Offset = "0x945844")]
	public ES2Stream stream;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x945858", Offset = "0x945858")]
	public HashSet<string> tagsToDelete;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94586C", Offset = "0x94586C")]
	public BinaryWriter writer;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x945880", Offset = "0x945880")]
	private long lengthPosition;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x1B1F990", Offset = "0x1B1F990", VA = "0x1B1F990")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947160", Offset = "0x947160")]
	public void Write<T>(T param, ES2Type type)
	{
	}

	[Token(Token = "0x6000312")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947174", Offset = "0x947174")]
	public void Write<T>(T[] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000313")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947188", Offset = "0x947188")]
	public void Write<T>(T[,] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000314")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94719C", Offset = "0x94719C")]
	public void Write<T>(T[,,] param, ES2Type type)
	{
	}

	[Token(Token = "0x6000315")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9471B0", Offset = "0x9471B0")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x6000316")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9471C4", Offset = "0x9471C4")]
	public void Write<T>(List<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000317")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9471D8", Offset = "0x9471D8")]
	public void Write<T>(HashSet<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000318")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9471EC", Offset = "0x9471EC")]
	public void Write<T>(Queue<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x6000319")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947200", Offset = "0x947200")]
	public void Write<T>(Stack<T> param, ES2Type type)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x1B25480", Offset = "0x1B25480", VA = "0x1B25480")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947214", Offset = "0x947214")]
	public void WriteSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x1B25954", Offset = "0x1B25954", VA = "0x1B25954")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947228", Offset = "0x947228")]
	public void WriteICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x1B25EB4", Offset = "0x1B25EB4", VA = "0x1B25EB4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94723C", Offset = "0x94723C")]
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
	[Address(RVA = "0x1B25798", Offset = "0x1B25798", VA = "0x1B25798")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947250", Offset = "0x947250")]
	private void WriteEncryptedSystemArray(Array param, ES2Type type)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x1B25CF8", Offset = "0x1B25CF8", VA = "0x1B25CF8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947264", Offset = "0x947264")]
	private void WriteEncryptedICollection(ICollection param, ES2Type type)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x1B262E4", Offset = "0x1B262E4", VA = "0x1B262E4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947278", Offset = "0x947278")]
	private void WriteEncryptedIDictionary(IDictionary param, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x1B266B0", Offset = "0x1B266B0", VA = "0x1B266B0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94728C", Offset = "0x94728C")]
	public void WriteHeader(ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x1B266D8", Offset = "0x1B266D8", VA = "0x1B266D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9472A0", Offset = "0x9472A0")]
	public void WriteHeader(string tag, ES2Keys.Key collectionType, ES2Type valueType, ES2Type keyType)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x1B268CC", Offset = "0x1B268CC", VA = "0x1B268CC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9472B4", Offset = "0x9472B4")]
	public void WriteLength()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x1B2699C", Offset = "0x1B2699C", VA = "0x1B2699C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9472C8", Offset = "0x9472C8")]
	public void WriteTerminator()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x1B264A8", Offset = "0x1B264A8", VA = "0x1B264A8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9472DC", Offset = "0x9472DC")]
	public ES2Writer CreateEncryptedWriter()
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x1B2654C", Offset = "0x1B2654C", VA = "0x1B2654C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9472F0", Offset = "0x9472F0")]
	public byte[] GetEncryptedBytes(string password)
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x1B26ACC", Offset = "0x1B26ACC", VA = "0x1B26ACC", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x1B26AD8", Offset = "0x1B26AD8", VA = "0x1B26AD8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947304", Offset = "0x947304")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947318", Offset = "0x947318")]
	public void Write<T>(T param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94732C", Offset = "0x94732C")]
	public void Write<T>(T[] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947340", Offset = "0x947340")]
	public void Write<T>(T[,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947354", Offset = "0x947354")]
	public void Write<T>(T[,,] param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x600033E")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947368", Offset = "0x947368")]
	public void Write<TKey, TValue>(Dictionary<TKey, TValue> param, string tag, ES2Type keyType, ES2Type valueType)
	{
	}

	[Token(Token = "0x600033F")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94737C", Offset = "0x94737C")]
	public void Write<T>(List<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000340")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947390", Offset = "0x947390")]
	public void Write<T>(HashSet<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000341")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9473A4", Offset = "0x9473A4")]
	public void Write<T>(Queue<T> param, string tag, ES2Type type)
	{
	}

	[Token(Token = "0x6000342")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9473B8", Offset = "0x9473B8")]
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
	[Address(RVA = "0x1B26C40", Offset = "0x1B26C40", VA = "0x1B26C40")]
	public int WritePropertyPrefix()
	{
		return default(int);
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1B26CA8", Offset = "0x1B26CA8", VA = "0x1B26CA8")]
	public void WritePropertyLength(int startPosition)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1B26D58", Offset = "0x1B26D58", VA = "0x1B26D58")]
	public void Save()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x1B2364C", Offset = "0x1B2364C", VA = "0x1B2364C")]
	public void Save(bool checkForOverwrite)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x1B26EB0", Offset = "0x1B26EB0", VA = "0x1B26EB0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9473CC", Offset = "0x9473CC")]
	public void Save(byte[] bytes)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x1B2703C", Offset = "0x1B2703C", VA = "0x1B2703C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9473E0", Offset = "0x9473E0")]
	public bool Rename(string oldTag, string newTag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1B27198", Offset = "0x1B27198", VA = "0x1B27198")]
	public void Delete(string tag)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x1B26D60", Offset = "0x1B26D60", VA = "0x1B26D60")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9473F4", Offset = "0x9473F4")]
	public bool Delete()
	{
		return default(bool);
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1B26EE4", Offset = "0x1B26EE4", VA = "0x1B26EE4")]
	private bool Delete(byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1B271FC", Offset = "0x1B271FC", VA = "0x1B271FC")]
	public static ES2Writer Create(string identifier)
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x1B235C0", Offset = "0x1B235C0", VA = "0x1B235C0")]
	public static ES2Writer Create(string identifier, ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1B27258", Offset = "0x1B27258", VA = "0x1B27258")]
	public static ES2Writer Create(ES2Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1B269C0", Offset = "0x1B269C0", VA = "0x1B269C0")]
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
	[Address(RVA = "0x1A1A718", Offset = "0x1A1A718", VA = "0x1A1A718")]
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
	[Address(RVA = "0x1A1A720", Offset = "0x1A1A720", VA = "0x1A1A720")]
	public void Save()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x1A1A8A0", Offset = "0x1A1A8A0", VA = "0x1A1A8A0")]
	public void Load()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x1A1A978", Offset = "0x1A1A978", VA = "0x1A1A978")]
	private void Start()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x1A1A98C", Offset = "0x1A1A98C", VA = "0x1A1A98C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x1A1A9A0", Offset = "0x1A1A9A0", VA = "0x1A1A9A0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x1A1A9B4", Offset = "0x1A1A9B4", VA = "0x1A1A9B4")]
	public void UpdateAutoSaves()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x1A1AA0C", Offset = "0x1A1AA0C", VA = "0x1A1AA0C", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x1A1AA10", Offset = "0x1A1AA10", VA = "0x1A1AA10", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x1A1AA14", Offset = "0x1A1AA14", VA = "0x1A1AA14")]
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
	[Address(RVA = "0x1B2FB18", Offset = "0x1B2FB18", VA = "0x1B2FB18")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x1B2FD14", Offset = "0x1B2FD14", VA = "0x1B2FD14")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x1B2FDB0", Offset = "0x1B2FDB0", VA = "0x1B2FDB0")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x1B2FBA4", Offset = "0x1B2FBA4", VA = "0x1B2FBA4")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x1B2FE54", Offset = "0x1B2FE54", VA = "0x1B2FE54")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x1B2FF7C", Offset = "0x1B2FF7C", VA = "0x1B2FF7C")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x1B30018", Offset = "0x1B30018", VA = "0x1B30018")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x1B2FEE0", Offset = "0x1B2FEE0", VA = "0x1B2FEE0")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x1B300BC", Offset = "0x1B300BC", VA = "0x1B300BC")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x1B302F0", Offset = "0x1B302F0", VA = "0x1B302F0")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x1B30148", Offset = "0x1B30148", VA = "0x1B30148")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x1B30394", Offset = "0x1B30394", VA = "0x1B30394")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x1B305EC", Offset = "0x1B305EC", VA = "0x1B305EC")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x1B30420", Offset = "0x1B30420", VA = "0x1B30420")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x1B30690", Offset = "0x1B30690", VA = "0x1B30690")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x1B308CC", Offset = "0x1B308CC", VA = "0x1B308CC")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x1B3072C", Offset = "0x1B3072C", VA = "0x1B3072C")]
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
	[Address(RVA = "0x1B30970", Offset = "0x1B30970", VA = "0x1B30970")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x1B30BAC", Offset = "0x1B30BAC", VA = "0x1B30BAC")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x1B30C38", Offset = "0x1B30C38", VA = "0x1B30C38")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x1B309F4", Offset = "0x1B309F4", VA = "0x1B309F4")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x1B30CD4", Offset = "0x1B30CD4", VA = "0x1B30CD4")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x1B30DE8", Offset = "0x1B30DE8", VA = "0x1B30DE8")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1B30E74", Offset = "0x1B30E74", VA = "0x1B30E74")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x1B30D58", Offset = "0x1B30D58", VA = "0x1B30D58")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x1B30F10", Offset = "0x1B30F10", VA = "0x1B30F10")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x1B31000", Offset = "0x1B31000", VA = "0x1B31000")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x1B30F9C", Offset = "0x1B30F9C", VA = "0x1B30F9C")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x1B3109C", Offset = "0x1B3109C", VA = "0x1B3109C")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x1B31110", Offset = "0x1B31110", VA = "0x1B31110")]
	public static AudioClip LoadAudio(string audioFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x1B3119C", Offset = "0x1B3119C", VA = "0x1B3119C")]
	public static AudioClip LoadAudio(string audioFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1B31474", Offset = "0x1B31474", VA = "0x1B31474")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1B315D0", Offset = "0x1B315D0", VA = "0x1B315D0")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x1B3165C", Offset = "0x1B3165C", VA = "0x1B3165C")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x1B314F8", Offset = "0x1B314F8", VA = "0x1B314F8")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x1B316F8", Offset = "0x1B316F8", VA = "0x1B316F8")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x1B318F4", Offset = "0x1B318F4", VA = "0x1B318F4")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x1B317AC", Offset = "0x1B317AC", VA = "0x1B317AC")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x1B319C0", Offset = "0x1B319C0", VA = "0x1B319C0")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x1B31BD0", Offset = "0x1B31BD0", VA = "0x1B31BD0")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x1B31A74", Offset = "0x1B31A74", VA = "0x1B31A74")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x1B31C9C", Offset = "0x1B31C9C", VA = "0x1B31C9C")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x1B31E04", Offset = "0x1B31E04", VA = "0x1B31E04")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x1B31D28", Offset = "0x1B31D28", VA = "0x1B31D28")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x1B31EA0", Offset = "0x1B31EA0", VA = "0x1B31EA0")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x1B32128", Offset = "0x1B32128", VA = "0x1B32128")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x1B321C4", Offset = "0x1B321C4", VA = "0x1B321C4")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x1B31F2C", Offset = "0x1B31F2C", VA = "0x1B31F2C")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x1B32374", Offset = "0x1B32374", VA = "0x1B32374")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x1B32568", Offset = "0x1B32568", VA = "0x1B32568")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x1B32604", Offset = "0x1B32604", VA = "0x1B32604")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1B32400", Offset = "0x1B32400", VA = "0x1B32400")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x1B326A8", Offset = "0x1B326A8", VA = "0x1B326A8")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x1B3272C", Offset = "0x1B3272C", VA = "0x1B3272C")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x1B327B8", Offset = "0x1B327B8", VA = "0x1B327B8")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x1B32268", Offset = "0x1B32268", VA = "0x1B32268")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x1B32854", Offset = "0x1B32854", VA = "0x1B32854")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x1B329C0", Offset = "0x1B329C0", VA = "0x1B329C0")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x1B328E0", Offset = "0x1B328E0", VA = "0x1B328E0")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x1B32A5C", Offset = "0x1B32A5C", VA = "0x1B32A5C")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x1B32EE4", Offset = "0x1B32EE4", VA = "0x1B32EE4")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x1B32F70", Offset = "0x1B32F70", VA = "0x1B32F70")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x1B32AE0", Offset = "0x1B32AE0", VA = "0x1B32AE0")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x1B3300C", Offset = "0x1B3300C", VA = "0x1B3300C")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x1B3311C", Offset = "0x1B3311C", VA = "0x1B3311C")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x1B331A8", Offset = "0x1B331A8", VA = "0x1B331A8")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x1B33090", Offset = "0x1B33090", VA = "0x1B33090")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1B33244", Offset = "0x1B33244", VA = "0x1B33244")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x1B33354", Offset = "0x1B33354", VA = "0x1B33354")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x1B333E0", Offset = "0x1B333E0", VA = "0x1B333E0")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x1B332C8", Offset = "0x1B332C8", VA = "0x1B332C8")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x1B3347C", Offset = "0x1B3347C", VA = "0x1B3347C")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x1B335C8", Offset = "0x1B335C8", VA = "0x1B335C8")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x1B33654", Offset = "0x1B33654", VA = "0x1B33654")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x1B33500", Offset = "0x1B33500", VA = "0x1B33500")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x1B336F0", Offset = "0x1B336F0", VA = "0x1B336F0")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x1B33878", Offset = "0x1B33878", VA = "0x1B33878")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x1B3377C", Offset = "0x1B3377C", VA = "0x1B3377C")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x1B33914", Offset = "0x1B33914", VA = "0x1B33914")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x1B33AC8", Offset = "0x1B33AC8", VA = "0x1B33AC8")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x1B33B54", Offset = "0x1B33B54", VA = "0x1B33B54")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x1B33998", Offset = "0x1B33998", VA = "0x1B33998")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x1B33BF0", Offset = "0x1B33BF0", VA = "0x1B33BF0")]
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
	[Address(RVA = "0x1A1F79C", Offset = "0x1A1F79C", VA = "0x1A1F79C")]
	public ES3File()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x1A1FC80", Offset = "0x1A1FC80", VA = "0x1A1FC80")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1A1FCFC", Offset = "0x1A1FCFC", VA = "0x1A1FCFC")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x1A1FD74", Offset = "0x1A1FD74", VA = "0x1A1FD74")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x1A1FD7C", Offset = "0x1A1FD7C", VA = "0x1A1FD7C")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x1A1FDE8", Offset = "0x1A1FDE8", VA = "0x1A1FDE8")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x1A1FE68", Offset = "0x1A1FE68", VA = "0x1A1FE68")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x1A1F7FC", Offset = "0x1A1F7FC", VA = "0x1A1F7FC")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1A1FFE8", Offset = "0x1A1FFE8", VA = "0x1A1FFE8")]
	public ES3File(byte[] bytes)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1A20054", Offset = "0x1A20054", VA = "0x1A20054")]
	public ES3File(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x1A20524", Offset = "0x1A20524", VA = "0x1A20524")]
	public void Sync()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x1A208B8", Offset = "0x1A208B8", VA = "0x1A208B8")]
	public void Sync(string filePath)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x1A20930", Offset = "0x1A20930", VA = "0x1A20930")]
	public void Sync(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x1A2052C", Offset = "0x1A2052C", VA = "0x1A2052C")]
	public void Sync(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x1A209A4", Offset = "0x1A209A4", VA = "0x1A209A4")]
	public void Clear()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x1A209F8", Offset = "0x1A209F8", VA = "0x1A209F8")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	public void Save<T>(string key, object value)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x1A20AC8", Offset = "0x1A20AC8", VA = "0x1A20AC8")]
	public void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x1A20108", Offset = "0x1A20108", VA = "0x1A20108")]
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
	[Address(RVA = "0x1A1B830", Offset = "0x1A1B830", VA = "0x1A1B830")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x1A20B88", Offset = "0x1A20B88", VA = "0x1A20B88")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x1A20C34", Offset = "0x1A20C34", VA = "0x1A20C34")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x1A20C98", Offset = "0x1A20C98", VA = "0x1A20C98")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x1A20CFC", Offset = "0x1A20CFC", VA = "0x1A20CFC")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x1A20E28", Offset = "0x1A20E28", VA = "0x1A20E28")]
	public Type GetKeyType(string key)
	{
		return null;
	}
}
[Token(Token = "0x200007B")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x1A22268", Offset = "0x1A22268", VA = "0x1A22268")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x200007C")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase, ISerializationCallbackReceiver
{
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x1A28AB0", Offset = "0x1A28AB0", VA = "0x1A28AB0", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x1A28AB4", Offset = "0x1A28AB4", VA = "0x1A28AB4", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x1A28AB8", Offset = "0x1A28AB8", VA = "0x1A28AB8")]
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
		[Address(RVA = "0x1EB82BC", Offset = "0x1EB82BC", VA = "0x1EB82BC")]
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
		[Address(RVA = "0x1A2C574", Offset = "0x1A2C574", VA = "0x1A2C574")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000048")]
	public int RowCount
	{
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1A2C57C", Offset = "0x1A2C57C", VA = "0x1A2C57C")]
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
	[Address(RVA = "0x1A2C584", Offset = "0x1A2C584", VA = "0x1A2C584")]
	private void SetCell(int col, int row, string value)
	{
	}

	[Token(Token = "0x60003EA")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x1A2C644", Offset = "0x1A2C644", VA = "0x1A2C644")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x1A2C984", Offset = "0x1A2C984", VA = "0x1A2C984")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1A2C6BC", Offset = "0x1A2C6BC", VA = "0x1A2C6BC")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x1A2C9F8", Offset = "0x1A2C9F8", VA = "0x1A2C9F8")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x1A2CDC8", Offset = "0x1A2CDC8", VA = "0x1A2CDC8")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x1A2CE40", Offset = "0x1A2CE40", VA = "0x1A2CE40")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x1A2CE48", Offset = "0x1A2CE48", VA = "0x1A2CE48")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x1A2CEC8", Offset = "0x1A2CEC8", VA = "0x1A2CEC8")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x1A2CA74", Offset = "0x1A2CA74", VA = "0x1A2CA74")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x1A2D108", Offset = "0x1A2D108", VA = "0x1A2D108")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x1A2D224", Offset = "0x1A2D224", VA = "0x1A2D224")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x1A2CF4C", Offset = "0x1A2CF4C", VA = "0x1A2CF4C")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x1A2D308", Offset = "0x1A2D308", VA = "0x1A2D308")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x200007F")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F0E8", Offset = "0x93F0E8")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F0FC", Offset = "0x93F0FC")]
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
				[Address(RVA = "0x1EBA2E0", Offset = "0x1EBA2E0", VA = "0x1EBA2E0", Slot = "4")]
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
				[Address(RVA = "0x1EBA328", Offset = "0x1EBA328", VA = "0x1EBA328", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1EB7AE8", Offset = "0x1EB7AE8", VA = "0x1EB7AE8")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1EBA228", Offset = "0x1EBA228", VA = "0x1EBA228", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1EBA22C", Offset = "0x1EBA22C", VA = "0x1EBA22C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1EBA2E8", Offset = "0x1EBA2E8", VA = "0x1EBA2E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1EB7A3C", Offset = "0x1EB7A3C", VA = "0x1EB7A3C")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1EB7A70", Offset = "0x1EB7A70", VA = "0x1EB7A70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947480", Offset = "0x947480")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F10C", Offset = "0x93F10C")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F120", Offset = "0x93F120")]
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
				[Address(RVA = "0x1EBA4AC", Offset = "0x1EBA4AC", VA = "0x1EBA4AC", Slot = "4")]
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
				[Address(RVA = "0x1EBA4F4", Offset = "0x1EBA4F4", VA = "0x1EBA4F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1EB7BC0", Offset = "0x1EB7BC0", VA = "0x1EB7BC0")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1EBA330", Offset = "0x1EBA330", VA = "0x1EBA330", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1EBA334", Offset = "0x1EBA334", VA = "0x1EBA334", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1EBA4B4", Offset = "0x1EBA4B4", VA = "0x1EBA4B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1EB7B14", Offset = "0x1EB7B14", VA = "0x1EB7B14")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1EB7B48", Offset = "0x1EB7B48", VA = "0x1EB7B48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947530", Offset = "0x947530")]
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
		[Address(RVA = "0x1A27DA4", Offset = "0x1A27DA4", VA = "0x1A27DA4", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004A")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1A27E04", Offset = "0x1A27E04", VA = "0x1A27E04", Slot = "39")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947408", Offset = "0x947408")]
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
	[Address(RVA = "0x1A223C0", Offset = "0x1A223C0", VA = "0x1A223C0")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x1A27E64", Offset = "0x1A27E64", VA = "0x1A27E64", Slot = "40")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94741C", Offset = "0x94741C")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947430", Offset = "0x947430")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000422")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947444", Offset = "0x947444")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x1A27E78", Offset = "0x1A27E78", VA = "0x1A27E78")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x1A27F88", Offset = "0x1A27F88", VA = "0x1A27F88")]
	public void SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x1A281C0", Offset = "0x1A281C0", VA = "0x1A281C0")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947458", Offset = "0x947458")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600042C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94746C", Offset = "0x94746C")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x600042D")]
	private Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x1A28400", Offset = "0x1A28400", VA = "0x1A28400")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x1A28454", Offset = "0x1A28454", VA = "0x1A28454")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x1A284BC", Offset = "0x1A284BC", VA = "0x1A284BC")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x1A1FF50", Offset = "0x1A1FF50", VA = "0x1A1FF50")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x1A288C0", Offset = "0x1A288C0", VA = "0x1A288C0")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x1A20AD0", Offset = "0x1A20AD0", VA = "0x1A20AD0")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x1A2891C", Offset = "0x1A2891C", VA = "0x1A2891C")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x1A289A4", Offset = "0x1A289A4", VA = "0x1A289A4")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9458A4", Offset = "0x9458A4")]
	public bool typeChecking;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9458B8", Offset = "0x9458B8")]
	public bool safeReflection;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9458CC", Offset = "0x9458CC")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9458E0", Offset = "0x9458E0")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9458F4", Offset = "0x9458F4")]
	public string[] assemblyNames;

	[Token(Token = "0x1700004F")]
	public ES3.Location location
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1A21ED8", Offset = "0x1A21ED8", VA = "0x1A21ED8")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1A2C0DC", Offset = "0x1A2C0DC", VA = "0x1A2C0DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public string FullPath
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1A21F18", Offset = "0x1A21F18", VA = "0x1A21F18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x1A2C0E4", Offset = "0x1A2C0E4", VA = "0x1A2C0E4")]
	private void CopyInto(ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x1A1AE10", Offset = "0x1A1AE10", VA = "0x1A1AE10")]
	public ES3Settings()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x1A1AFB4", Offset = "0x1A1AFB4", VA = "0x1A1AFB4")]
	public ES3Settings(string path)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x1A1B19C", Offset = "0x1A1B19C", VA = "0x1A1B19C")]
	public ES3Settings(string path, ES3Settings settings)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x1A2C23C", Offset = "0x1A2C23C", VA = "0x1A2C23C")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x1A2C27C", Offset = "0x1A2C27C", VA = "0x1A2C27C")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x1A2C2D0", Offset = "0x1A2C2D0", VA = "0x1A2C2D0")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, ES3Settings settings)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x1A2C00C", Offset = "0x1A2C00C", VA = "0x1A2C00C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9475E0", Offset = "0x9475E0")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x1A2C188", Offset = "0x1A2C188", VA = "0x1A2C188")]
	protected void ApplyDefaults()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x1A2C314", Offset = "0x1A2C314", VA = "0x1A2C314")]
	internal static void LoadDefaults()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x1A2C4E8", Offset = "0x1A2C4E8", VA = "0x1A2C4E8")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x1A1FEEC", Offset = "0x1A1FEEC", VA = "0x1A1FEEC", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x9475F4", Offset = "0x9475F4")]
	public object Clone()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000085")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F130", Offset = "0x93F130")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x6000456")]
	[Address(RVA = "0x1A2BFA8", Offset = "0x1A2BFA8", VA = "0x1A2BFA8")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x1A2C06C", Offset = "0x1A2C06C", VA = "0x1A2C06C")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}
}
[Token(Token = "0x2000086")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F144", Offset = "0x93F144")]
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
			[Address(RVA = "0x1EB7574", Offset = "0x1EB7574", VA = "0x1EB7574", Slot = "4")]
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
			[Address(RVA = "0x1EB75BC", Offset = "0x1EB75BC", VA = "0x1EB75BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1EB73BC", Offset = "0x1EB73BC", VA = "0x1EB73BC")]
		[DebuggerHidden]
		public <Sync>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1EB73E8", Offset = "0x1EB73E8", VA = "0x1EB73E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1EB73EC", Offset = "0x1EB73EC", VA = "0x1EB73EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1EB757C", Offset = "0x1EB757C", VA = "0x1EB757C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F154", Offset = "0x93F154")]
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
			[Address(RVA = "0x1EB79EC", Offset = "0x1EB79EC", VA = "0x1EB79EC", Slot = "4")]
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
			[Address(RVA = "0x1EB7A34", Offset = "0x1EB7A34", VA = "0x1EB7A34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1EB75C4", Offset = "0x1EB75C4", VA = "0x1EB75C4")]
		[DebuggerHidden]
		public <UploadFile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1EB75F0", Offset = "0x1EB75F0", VA = "0x1EB75F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1EB76C8", Offset = "0x1EB76C8", VA = "0x1EB76C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1EB760C", Offset = "0x1EB760C", VA = "0x1EB760C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1EB79F4", Offset = "0x1EB79F4", VA = "0x1EB79F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F164", Offset = "0x93F164")]
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
			[Address(RVA = "0x1EB6368", Offset = "0x1EB6368", VA = "0x1EB6368", Slot = "4")]
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
			[Address(RVA = "0x1EB63B0", Offset = "0x1EB63B0", VA = "0x1EB63B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1EB5EF4", Offset = "0x1EB5EF4", VA = "0x1EB5EF4")]
		[DebuggerHidden]
		public <DownloadFile>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1EB5F20", Offset = "0x1EB5F20", VA = "0x1EB5F20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1EB5FF8", Offset = "0x1EB5FF8", VA = "0x1EB5FF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1EB5F3C", Offset = "0x1EB5F3C", VA = "0x1EB5F3C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1EB6370", Offset = "0x1EB6370", VA = "0x1EB6370", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F174", Offset = "0x93F174")]
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
			[Address(RVA = "0x1EB6828", Offset = "0x1EB6828", VA = "0x1EB6828", Slot = "4")]
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
			[Address(RVA = "0x1EB6870", Offset = "0x1EB6870", VA = "0x1EB6870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1EB63B8", Offset = "0x1EB63B8", VA = "0x1EB63B8")]
		[DebuggerHidden]
		public <DownloadFile>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1EB63E4", Offset = "0x1EB63E4", VA = "0x1EB63E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1EB64BC", Offset = "0x1EB64BC", VA = "0x1EB64BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1EB6400", Offset = "0x1EB6400", VA = "0x1EB6400")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1EB6830", Offset = "0x1EB6830", VA = "0x1EB6830", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F184", Offset = "0x93F184")]
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
			[Address(RVA = "0x1EB5EA4", Offset = "0x1EB5EA4", VA = "0x1EB5EA4", Slot = "4")]
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
			[Address(RVA = "0x1EB5EEC", Offset = "0x1EB5EEC", VA = "0x1EB5EEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1EB5B78", Offset = "0x1EB5B78", VA = "0x1EB5B78")]
		[DebuggerHidden]
		public <DeleteFile>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1EB5BA4", Offset = "0x1EB5BA4", VA = "0x1EB5BA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1EB5C7C", Offset = "0x1EB5C7C", VA = "0x1EB5C7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1EB5BC0", Offset = "0x1EB5BC0", VA = "0x1EB5BC0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1EB5EAC", Offset = "0x1EB5EAC", VA = "0x1EB5EAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F194", Offset = "0x93F194")]
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
			[Address(RVA = "0x1EB736C", Offset = "0x1EB736C", VA = "0x1EB736C", Slot = "4")]
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
			[Address(RVA = "0x1EB73B4", Offset = "0x1EB73B4", VA = "0x1EB73B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1EB7004", Offset = "0x1EB7004", VA = "0x1EB7004")]
		[DebuggerHidden]
		public <RenameFile>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1EB7030", Offset = "0x1EB7030", VA = "0x1EB7030", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1EB7108", Offset = "0x1EB7108", VA = "0x1EB7108", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1EB704C", Offset = "0x1EB704C", VA = "0x1EB704C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1EB7374", Offset = "0x1EB7374", VA = "0x1EB7374", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F1A4", Offset = "0x93F1A4")]
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
			[Address(RVA = "0x1EB6BF0", Offset = "0x1EB6BF0", VA = "0x1EB6BF0", Slot = "4")]
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
			[Address(RVA = "0x1EB6C38", Offset = "0x1EB6C38", VA = "0x1EB6C38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1EB6878", Offset = "0x1EB6878", VA = "0x1EB6878")]
		[DebuggerHidden]
		public <DownloadFilenames>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1EB68A4", Offset = "0x1EB68A4", VA = "0x1EB68A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1EB697C", Offset = "0x1EB697C", VA = "0x1EB697C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1EB68C0", Offset = "0x1EB68C0", VA = "0x1EB68C0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1EB6BF8", Offset = "0x1EB6BF8", VA = "0x1EB6BF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F1B4", Offset = "0x93F1B4")]
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
			[Address(RVA = "0x1EB6FB4", Offset = "0x1EB6FB4", VA = "0x1EB6FB4", Slot = "4")]
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
			[Address(RVA = "0x1EB6FFC", Offset = "0x1EB6FFC", VA = "0x1EB6FFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1EB6C40", Offset = "0x1EB6C40", VA = "0x1EB6C40")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1EB6C6C", Offset = "0x1EB6C6C", VA = "0x1EB6C6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1EB6D44", Offset = "0x1EB6D44", VA = "0x1EB6D44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1EB6C88", Offset = "0x1EB6C88", VA = "0x1EB6C88")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1EB6FBC", Offset = "0x1EB6FBC", VA = "0x1EB6FBC", Slot = "8")]
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
		[Address(RVA = "0x1A1AB0C", Offset = "0x1A1AB0C", VA = "0x1A1AB0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000052")]
	public string text
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1A1AB14", Offset = "0x1A1AB14", VA = "0x1A1AB14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public string[] filenames
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1A1AB48", Offset = "0x1A1AB48", VA = "0x1A1AB48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000054")]
	public DateTime timestamp
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1A1AC14", Offset = "0x1A1AC14", VA = "0x1A1AC14")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x1A1AAB8", Offset = "0x1A1AAB8", VA = "0x1A1AAB8")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x1A1AD98", Offset = "0x1A1AD98", VA = "0x1A1AD98")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x1A1AF20", Offset = "0x1A1AF20", VA = "0x1A1AF20")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x1A1AFE4", Offset = "0x1A1AFE4", VA = "0x1A1AFE4")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x1A1B07C", Offset = "0x1A1B07C", VA = "0x1A1B07C")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x1A1B10C", Offset = "0x1A1B10C", VA = "0x1A1B10C")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1A1B210", Offset = "0x1A1B210", VA = "0x1A1B210")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1A1B2AC", Offset = "0x1A1B2AC", VA = "0x1A1B2AC")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x1A1AE5C", Offset = "0x1A1AE5C", VA = "0x1A1AE5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947608", Offset = "0x947608")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x1A1B338", Offset = "0x1A1B338", VA = "0x1A1B338")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x1A1B448", Offset = "0x1A1B448", VA = "0x1A1B448")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x1A1B4DC", Offset = "0x1A1B4DC", VA = "0x1A1B4DC")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x1A1B574", Offset = "0x1A1B574", VA = "0x1A1B574")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x1A1B604", Offset = "0x1A1B604", VA = "0x1A1B604")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x1A1B694", Offset = "0x1A1B694", VA = "0x1A1B694")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x1A1B730", Offset = "0x1A1B730", VA = "0x1A1B730")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x1A1B7BC", Offset = "0x1A1B7BC", VA = "0x1A1B7BC")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x1A1BDE0", Offset = "0x1A1BDE0", VA = "0x1A1BDE0")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x1A1BE58", Offset = "0x1A1BE58", VA = "0x1A1BE58")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x1A1B3B0", Offset = "0x1A1B3B0", VA = "0x1A1B3B0")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x1A1BD08", Offset = "0x1A1BD08", VA = "0x1A1BD08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947668", Offset = "0x947668")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x1A1BEAC", Offset = "0x1A1BEAC", VA = "0x1A1BEAC")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x1A1BFF4", Offset = "0x1A1BFF4", VA = "0x1A1BFF4")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x1A1C08C", Offset = "0x1A1C08C", VA = "0x1A1C08C")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x1A1C128", Offset = "0x1A1C128", VA = "0x1A1C128")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x1A1C1BC", Offset = "0x1A1C1BC", VA = "0x1A1C1BC")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x1A1C250", Offset = "0x1A1C250", VA = "0x1A1C250")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x1A1C2F0", Offset = "0x1A1C2F0", VA = "0x1A1C2F0")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x1A1C380", Offset = "0x1A1C380", VA = "0x1A1C380")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x1A1C4B0", Offset = "0x1A1C4B0", VA = "0x1A1C4B0")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x1A1C518", Offset = "0x1A1C518", VA = "0x1A1C518")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x1A1C3E4", Offset = "0x1A1C3E4", VA = "0x1A1C3E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9476C8", Offset = "0x9476C8")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x1A1BF28", Offset = "0x1A1BF28", VA = "0x1A1BF28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947728", Offset = "0x947728")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x1A1C520", Offset = "0x1A1C520", VA = "0x1A1C520")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x1A1C65C", Offset = "0x1A1C65C", VA = "0x1A1C65C")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x1A1C6F0", Offset = "0x1A1C6F0", VA = "0x1A1C6F0")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x1A1C788", Offset = "0x1A1C788", VA = "0x1A1C788")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x1A1C818", Offset = "0x1A1C818", VA = "0x1A1C818")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x1A1C8A8", Offset = "0x1A1C8A8", VA = "0x1A1C8A8")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x1A1C944", Offset = "0x1A1C944", VA = "0x1A1C944")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x1A1C598", Offset = "0x1A1C598", VA = "0x1A1C598")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947788", Offset = "0x947788")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x1A1C9D0", Offset = "0x1A1C9D0", VA = "0x1A1C9D0")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x1A1CB6C", Offset = "0x1A1CB6C", VA = "0x1A1CB6C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x1A1CC34", Offset = "0x1A1CC34", VA = "0x1A1CC34")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x1A1CCF4", Offset = "0x1A1CCF4", VA = "0x1A1CCF4")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x1A1CDAC", Offset = "0x1A1CDAC", VA = "0x1A1CDAC")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x1A1CE70", Offset = "0x1A1CE70", VA = "0x1A1CE70")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x1A1CA94", Offset = "0x1A1CA94", VA = "0x1A1CA94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9477E8", Offset = "0x9477E8")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x1A1CF24", Offset = "0x1A1CF24", VA = "0x1A1CF24")]
	public IEnumerator DownloadFilenames()
	{
		return null;
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x1A1D01C", Offset = "0x1A1D01C", VA = "0x1A1D01C")]
	public IEnumerator DownloadFilenames(string user)
	{
		return null;
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x1A1CF74", Offset = "0x1A1CF74", VA = "0x1A1CF74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947848", Offset = "0x947848")]
	public IEnumerator DownloadFilenames(string user, string password)
	{
		return null;
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x1A1D078", Offset = "0x1A1D078", VA = "0x1A1D078")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x1A1D1B4", Offset = "0x1A1D1B4", VA = "0x1A1D1B4")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x1A1D248", Offset = "0x1A1D248", VA = "0x1A1D248")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x1A1D2E0", Offset = "0x1A1D2E0", VA = "0x1A1D2E0")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x1A1D370", Offset = "0x1A1D370", VA = "0x1A1D370")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x1A1D400", Offset = "0x1A1D400", VA = "0x1A1D400")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x1A1D49C", Offset = "0x1A1D49C", VA = "0x1A1D49C")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x1A1D0F0", Offset = "0x1A1D0F0", VA = "0x1A1D0F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9478A8", Offset = "0x9478A8")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x1A1D528", Offset = "0x1A1D528", VA = "0x1A1D528")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x1A1D638", Offset = "0x1A1D638", VA = "0x1A1D638")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x1A1D6A4", Offset = "0x1A1D6A4", VA = "0x1A1D6A4", Slot = "4")]
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
	[Address(RVA = "0x1A65178", Offset = "0x1A65178", VA = "0x1A65178")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x60004F4")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x1A65248", Offset = "0x1A65248", VA = "0x1A65248", Slot = "40")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x1A653A8", Offset = "0x1A653A8", VA = "0x1A653A8", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947B88", Offset = "0x947B88")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x1A654D0", Offset = "0x1A654D0", VA = "0x1A654D0", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947B9C", Offset = "0x947B9C")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x1A6559C", Offset = "0x1A6559C", VA = "0x1A6559C", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947BB0", Offset = "0x947BB0")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x1A6580C", Offset = "0x1A6580C", VA = "0x1A6580C", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x1A65990", Offset = "0x1A65990", VA = "0x1A65990", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x1A659E0", Offset = "0x1A659E0", VA = "0x1A659E0", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x1A65A30", Offset = "0x1A65A30", VA = "0x1A65A30", Slot = "47")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947BC4", Offset = "0x947BC4")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x1A65A90", Offset = "0x1A65A90", VA = "0x1A65A90", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947BD8", Offset = "0x947BD8")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x60004FE")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x1A60B24", Offset = "0x1A60B24", VA = "0x1A60B24")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947BEC", Offset = "0x947BEC")]
	public void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x1A65AE8", Offset = "0x1A65AE8", VA = "0x1A65AE8")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x1A65CF8", Offset = "0x1A65CF8", VA = "0x1A65CF8")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x1A65F08", Offset = "0x1A65F08", VA = "0x1A65F08")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947C00", Offset = "0x947C00")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x1A660D0", Offset = "0x1A660D0", VA = "0x1A660D0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947C14", Offset = "0x947C14")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x1A66298", Offset = "0x1A66298", VA = "0x1A66298")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947C28", Offset = "0x947C28")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x1A66490", Offset = "0x1A66490", VA = "0x1A66490")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947C3C", Offset = "0x947C3C")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x1A65308", Offset = "0x1A65308", VA = "0x1A65308")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947C50", Offset = "0x947C50")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x1A66688", Offset = "0x1A66688", VA = "0x1A66688")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x1A66704", Offset = "0x1A66704", VA = "0x1A66704")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x1A66714", Offset = "0x1A66714", VA = "0x1A66714")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x1A66774", Offset = "0x1A66774", VA = "0x1A66774")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x1A668F8", Offset = "0x1A668F8", VA = "0x1A668F8", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x947C64", Offset = "0x947C64")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x1A6695C", Offset = "0x1A6695C", VA = "0x1A6695C")]
	protected void Merge()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x1A66AA8", Offset = "0x1A66AA8", VA = "0x1A66AA8")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x1A66DD0", Offset = "0x1A66DD0", VA = "0x1A66DD0", Slot = "51")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x1A66DE4", Offset = "0x1A66DE4", VA = "0x1A66DE4", Slot = "52")]
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
			[Address(RVA = "0x18F9F60", Offset = "0x18F9F60", VA = "0x18F9F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x18FA0AC", Offset = "0x18FA0AC", VA = "0x18FA0AC")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x18FA0C4", Offset = "0x18FA0C4", VA = "0x18FA0C4")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x18FA0E0", Offset = "0x18FA0E0", VA = "0x18FA0E0")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x18FA730", Offset = "0x18FA730", VA = "0x18FA730")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x18FA8E4", Offset = "0x18FA8E4", VA = "0x18FA8E4")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F1C4", Offset = "0x93F1C4")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x93F1C4", Offset = "0x93F1C4")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F234", Offset = "0x93F234")]
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
				[Address(RVA = "0x1A72B5C", Offset = "0x1A72B5C", VA = "0x1A72B5C", Slot = "4")]
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
				[Address(RVA = "0x1A72BA4", Offset = "0x1A72BA4", VA = "0x1A72BA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x1A72A84", Offset = "0x1A72A84", VA = "0x1A72A84")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x1A72AB0", Offset = "0x1A72AB0", VA = "0x1A72AB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x1A72AB4", Offset = "0x1A72AB4", VA = "0x1A72AB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1A72B64", Offset = "0x1A72B64", VA = "0x1A72B64", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x945908", Offset = "0x945908")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x945918", Offset = "0x945918")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x945928", Offset = "0x945928")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000066")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x18FA9B0", Offset = "0x18FA9B0", VA = "0x18FA9B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947C78", Offset = "0x947C78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x18FA9B8", Offset = "0x18FA9B8", VA = "0x18FA9B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947C88", Offset = "0x947C88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x18FA9C0", Offset = "0x18FA9C0", VA = "0x18FA9C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947C98", Offset = "0x947C98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x18FA9C8", Offset = "0x18FA9C8", VA = "0x18FA9C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947CA8", Offset = "0x947CA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x18FA9D0", Offset = "0x18FA9D0", VA = "0x18FA9D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947CB8", Offset = "0x947CB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x18FA9D8", Offset = "0x18FA9D8", VA = "0x18FA9D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947CC8", Offset = "0x947CC8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool visible
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x18FA9E0", Offset = "0x18FA9E0", VA = "0x18FA9E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x18FA9FC", Offset = "0x18FA9FC", VA = "0x18FA9FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int sortingLayerID
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x18FAA1C", Offset = "0x18FAA1C", VA = "0x18FAA1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x18FAA38", Offset = "0x18FAA38", VA = "0x18FAA38")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public int sortingOrder
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x18FAA54", Offset = "0x18FAA54", VA = "0x18FAA54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x18FAA70", Offset = "0x18FAA70", VA = "0x18FAA70")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x18FAA8C", Offset = "0x18FAA8C", VA = "0x18FAA8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x18FB3D0", Offset = "0x18FB3D0", VA = "0x18FB3D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x18FB3D8", Offset = "0x18FB3D8", VA = "0x18FB3D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x18FC700", Offset = "0x18FC700", VA = "0x18FC700")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x18FC79C", Offset = "0x18FC79C", VA = "0x18FC79C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x18FAA9C", Offset = "0x18FAA9C", VA = "0x18FAA9C")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x18FAB88", Offset = "0x18FAB88", VA = "0x18FAB88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947CD8", Offset = "0x947CD8")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x18FAC00", Offset = "0x18FAC00", VA = "0x18FAC00")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x18FAD48", Offset = "0x18FAD48", VA = "0x18FAD48")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x18FB0A0", Offset = "0x18FB0A0", VA = "0x18FB0A0")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x18FB18C", Offset = "0x18FB18C", VA = "0x18FB18C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x18FB248", Offset = "0x18FB248", VA = "0x18FB248")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x18FB304", Offset = "0x18FB304", VA = "0x18FB304")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x18FB46C", Offset = "0x18FB46C", VA = "0x18FB46C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x18FB530", Offset = "0x18FB530", VA = "0x18FB530")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x18FBA44", Offset = "0x18FBA44", VA = "0x18FBA44")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x18FC628", Offset = "0x18FC628", VA = "0x18FC628")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x18FC7E0", Offset = "0x18FC7E0", VA = "0x18FC7E0")]
		private MaterialManager.StaticProperties ComputeMaterialStaticProperties()
		{
			return default(MaterialManager.StaticProperties);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x18FB8FC", Offset = "0x18FB8FC", VA = "0x18FB8FC")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x18FAED8", Offset = "0x18FAED8", VA = "0x18FAED8", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x18FC92C", Offset = "0x18FC92C", VA = "0x18FC92C", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x18FCA58", Offset = "0x18FCA58", VA = "0x18FCA58", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x18FCB84", Offset = "0x18FCB84", VA = "0x18FCB84", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x18FCCB8", Offset = "0x18FCCB8", VA = "0x18FCCB8", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x18FAE0C", Offset = "0x18FAE0C", VA = "0x18FAE0C")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x18FAFD4", Offset = "0x18FAFD4", VA = "0x18FAFD4")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x18FCDA8", Offset = "0x18FCDA8", VA = "0x18FCDA8")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x18FBDA8", Offset = "0x18FBDA8", VA = "0x18FBDA8")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x18FCEC0", Offset = "0x18FCEC0", VA = "0x18FCEC0")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x18FD038", Offset = "0x18FD038", VA = "0x18FD038")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x18FD044", Offset = "0x18FD044", VA = "0x18FD044")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x18FD0C4", Offset = "0x18FD0C4", VA = "0x18FD0C4")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x18FD1AC", Offset = "0x18FD1AC", VA = "0x18FD1AC")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x18FD464", Offset = "0x18FD464", VA = "0x18FD464")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F244", Offset = "0x93F244")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945938", Offset = "0x945938")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945984", Offset = "0x945984")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9459D0", Offset = "0x9459D0")]
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
			[Address(RVA = "0x18FD938", Offset = "0x18FD938", VA = "0x18FD938")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x18FD940", Offset = "0x18FD940", VA = "0x18FD940")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x18FD9B4", Offset = "0x18FD9B4", VA = "0x18FD9B4")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x18FD9BC", Offset = "0x18FD9BC", VA = "0x18FD9BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x18FA060", Offset = "0x18FA060", VA = "0x18FA060")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000076")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x18FDAB8", Offset = "0x18FDAB8", VA = "0x18FDAB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x18FBD8C", Offset = "0x18FBD8C", VA = "0x18FBD8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public Shader beamShader
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x18FDAD4", Offset = "0x18FDAD4", VA = "0x18FDAD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x18FACC8", Offset = "0x18FACC8", VA = "0x18FACC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public bool isHDRPExposureWeightSupported
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x18FCEB8", Offset = "0x18FCEB8", VA = "0x18FCEB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x18FDB88", Offset = "0x18FDB88", VA = "0x18FDB88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public static Config Instance
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x18FA004", Offset = "0x18FA004", VA = "0x18FA004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x18FDA30", Offset = "0x18FDA30", VA = "0x18FDA30")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x18FDADC", Offset = "0x18FDADC", VA = "0x18FDADC")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x18FDC04", Offset = "0x18FDC04", VA = "0x18FDC04")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x947D88", Offset = "0x947D88")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x18FDDE4", Offset = "0x18FDDE4", VA = "0x18FDDE4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x18FDD0C", Offset = "0x18FDD0C", VA = "0x18FDD0C")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x18FDEF8", Offset = "0x18FDEF8", VA = "0x18FDEF8")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x18FE0B8", Offset = "0x18FE0B8", VA = "0x18FE0B8")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x18FE288", Offset = "0x18FE288", VA = "0x18FE288")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x18FE294", Offset = "0x18FE294", VA = "0x18FE294")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x18FE298", Offset = "0x18FE298", VA = "0x18FE298")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x18FE464", Offset = "0x18FE464", VA = "0x18FE464")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F27C", Offset = "0x93F27C")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x40001F5")]
		public new const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x18FE580", Offset = "0x18FE580", VA = "0x18FE580")]
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
				[Address(RVA = "0x1A696F4", Offset = "0x1A696F4", VA = "0x1A696F4")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x93F2B4", Offset = "0x93F2B4")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x93F2B4", Offset = "0x93F2B4")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945A3C", Offset = "0x945A3C")]
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
			[Address(RVA = "0x18FE954", Offset = "0x18FE954", VA = "0x18FE954")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x18FE814", Offset = "0x18FE814", VA = "0x18FE814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947D98", Offset = "0x947D98")]
			add
			{
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x18FE8B4", Offset = "0x18FE8B4", VA = "0x18FE8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947DA8", Offset = "0x947DA8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x18FE5E0", Offset = "0x18FE5E0", VA = "0x18FE5E0")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x18FE5E8", Offset = "0x18FE5E8", VA = "0x18FE5E8")]
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
		[Address(RVA = "0x18FE95C", Offset = "0x18FE95C", VA = "0x18FE95C", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x18FE990", Offset = "0x18FE990", VA = "0x18FE990", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x18FEA10", Offset = "0x18FEA10", VA = "0x18FEA10", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x18FEA6C", Offset = "0x18FEA6C", VA = "0x18FEA6C", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x18FEC20", Offset = "0x18FEC20", VA = "0x18FEC20", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x18FECBC", Offset = "0x18FECBC", VA = "0x18FECBC")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x18FEA2C", Offset = "0x18FEA2C", VA = "0x18FEA2C")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x18FEE4C", Offset = "0x18FEE4C", VA = "0x18FEE4C")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x18FEEB8", Offset = "0x18FEEB8", VA = "0x18FEEB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947DB8", Offset = "0x947DB8")]
		private void <OnEnable>b__24_0()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F348", Offset = "0x93F348")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F394", Offset = "0x93F394")]
		private sealed class <>c
		{
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Camera> <>9__15_0;

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1A72E40", Offset = "0x1A72E40", VA = "0x1A72E40")]
			public <>c()
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x1A72E48", Offset = "0x1A72E48", VA = "0x1A72E48")]
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
		[Address(RVA = "0x18FEEC0", Offset = "0x18FEEC0", VA = "0x18FEEC0", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x18FEF04", Offset = "0x18FEF04", VA = "0x18FEF04", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x18FEF0C", Offset = "0x18FEF0C", VA = "0x18FEF0C")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x18FF19C", Offset = "0x18FF19C", VA = "0x18FF19C", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x18FF22C", Offset = "0x18FF22C", VA = "0x18FF22C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x18FEF3C", Offset = "0x18FEF3C", VA = "0x18FEF3C")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x18FF2E4", Offset = "0x18FF2E4", VA = "0x18FF2E4")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x18FF39C", Offset = "0x18FF39C", VA = "0x18FF39C", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x18FF408", Offset = "0x18FF408", VA = "0x18FF408")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x18FF82C", Offset = "0x18FF82C", VA = "0x18FF82C", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x18FF830", Offset = "0x18FF830", VA = "0x18FF830", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x18FF8D4", Offset = "0x18FF8D4", VA = "0x18FF8D4", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x18FF8D8", Offset = "0x18FF8D8", VA = "0x18FF8D8", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x18FF8FC", Offset = "0x18FF8FC", VA = "0x18FF8FC")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x18FFA7C", Offset = "0x18FFA7C", VA = "0x18FFA7C", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x18FFC8C", Offset = "0x18FFC8C", VA = "0x18FFC8C")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F3A4", Offset = "0x93F3A4")]
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
				[Address(RVA = "0x1A72FC8", Offset = "0x1A72FC8", VA = "0x1A72FC8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000084")]
			public string name
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x1A73078", Offset = "0x1A73078", VA = "0x1A73078")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			public Bounds bounds
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x1A7315C", Offset = "0x1A7315C", VA = "0x1A7315C")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x1A72EC8", Offset = "0x1A72EC8", VA = "0x1A72EC8")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x1A72F48", Offset = "0x1A72F48", VA = "0x1A72F48")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1A73258", Offset = "0x1A73258", VA = "0x1A73258")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945A84", Offset = "0x945A84")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HitResult m_CurrentHit;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float m_RangeMultiplier;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x945ABC", Offset = "0x945ABC")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700007F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9485B4", Offset = "0x9485B4")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x18FFD54", Offset = "0x18FFD54", VA = "0x18FFD54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x18FFD5C", Offset = "0x18FFD5C", VA = "0x18FFD5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x18FFDB0", Offset = "0x18FFDB0", VA = "0x18FFDB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947DC8", Offset = "0x947DC8")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x18FFDBC", Offset = "0x18FFDBC", VA = "0x18FFDBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x947DD8", Offset = "0x947DD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x18FFFF0", Offset = "0x18FFFF0", VA = "0x18FFFF0")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000082")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x1900004", Offset = "0x1900004", VA = "0x1900004")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x18FD800", Offset = "0x18FD800", VA = "0x18FD800")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x18FFD64", Offset = "0x18FFD64", VA = "0x18FFD64", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x18FFDA8", Offset = "0x18FFDA8", VA = "0x18FFDA8", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x18FFDC8", Offset = "0x18FFDC8", VA = "0x18FFDC8", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x18FFE28", Offset = "0x18FFE28", VA = "0x18FFE28", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x18FFE34", Offset = "0x18FFE34", VA = "0x18FFE34", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x18FFE8C", Offset = "0x18FFE8C", VA = "0x18FFE8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x18FFF48", Offset = "0x18FFF48", VA = "0x18FFF48")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x190005C", Offset = "0x190005C", VA = "0x190005C")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x19000AC", Offset = "0x19000AC", VA = "0x19000AC")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1900368", Offset = "0x1900368", VA = "0x1900368")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1900664", Offset = "0x1900664", VA = "0x1900664")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x190067C", Offset = "0x190067C", VA = "0x190067C")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1900714", Offset = "0x1900714", VA = "0x1900714")]
		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1900790", Offset = "0x1900790", VA = "0x1900790", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1900AB4", Offset = "0x1900AB4", VA = "0x1900AB4")]
		private void SetHit(ref HitResult hit)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x18FFE64", Offset = "0x18FFE64", VA = "0x18FFE64")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1900CF0", Offset = "0x1900CF0", VA = "0x1900CF0", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1900B8C", Offset = "0x1900B8C", VA = "0x1900B8C")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1900CA8", Offset = "0x1900CA8", VA = "0x1900CA8")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1900EFC", Offset = "0x1900EFC", VA = "0x1900EFC")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1900F08", Offset = "0x1900F08", VA = "0x1900F08")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x93F3F0", Offset = "0x93F3F0")]
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
		[Address(RVA = "0x1A679B8", Offset = "0x1A679B8", VA = "0x1A679B8")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1A67C3C", Offset = "0x1A67C3C", VA = "0x1A67C3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1A67DF0", Offset = "0x1A67DF0", VA = "0x1A67DF0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1A67DF8", Offset = "0x1A67DF8", VA = "0x1A67DF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1A67E38", Offset = "0x1A67E38", VA = "0x1A67E38")]
		public EffectAbstractBase()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F44C", Offset = "0x93F44C")]
	public class EffectFlicker : EffectAbstractBase
	{
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F484", Offset = "0x93F484")]
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
				[Address(RVA = "0x1EB8774", Offset = "0x1EB8774", VA = "0x1EB8774", Slot = "4")]
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
				[Address(RVA = "0x1EB87BC", Offset = "0x1EB87BC", VA = "0x1EB87BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1EB8658", Offset = "0x1EB8658", VA = "0x1EB8658")]
			[DebuggerHidden]
			public <CoUpdate>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x1EB8684", Offset = "0x1EB8684", VA = "0x1EB8684", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x1EB8688", Offset = "0x1EB8688", VA = "0x1EB8688", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x1EB877C", Offset = "0x1EB877C", VA = "0x1EB877C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F494", Offset = "0x93F494")]
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
				[Address(RVA = "0x1EB8608", Offset = "0x1EB8608", VA = "0x1EB8608", Slot = "4")]
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
				[Address(RVA = "0x1EB8650", Offset = "0x1EB8650", VA = "0x1EB8650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x1EB84F8", Offset = "0x1EB84F8", VA = "0x1EB84F8")]
			[DebuggerHidden]
			public <CoFlicker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x1EB8524", Offset = "0x1EB8524", VA = "0x1EB8524", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x1EB8528", Offset = "0x1EB8528", VA = "0x1EB8528", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x1EB8610", Offset = "0x1EB8610", VA = "0x1EB8610", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F4A4", Offset = "0x93F4A4")]
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
				[Address(RVA = "0x1EB84A8", Offset = "0x1EB84A8", VA = "0x1EB84A8", Slot = "4")]
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
				[Address(RVA = "0x1EB84F0", Offset = "0x1EB84F0", VA = "0x1EB84F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1EB83B4", Offset = "0x1EB83B4", VA = "0x1EB83B4")]
			[DebuggerHidden]
			public <CoChangeIntensity>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1EB83E0", Offset = "0x1EB83E0", VA = "0x1EB83E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1EB83E4", Offset = "0x1EB83E4", VA = "0x1EB83E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1EB84B0", Offset = "0x1EB84B0", VA = "0x1EB84B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A7")]
		public new const string ClassName = "EffectFlicker";

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945ACC", Offset = "0x945ACC")]
		public float frequency;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool performPauses;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x945AE8", Offset = "0x945AE8")]
		public MinMaxRangeFloat flickeringDuration;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x945B00", Offset = "0x945B00")]
		public MinMaxRangeFloat pauseDuration;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x945B18", Offset = "0x945B18")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945B30", Offset = "0x945B30")]
		public float smoothing;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_CurrentAdditiveIntensity;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1A67E50", Offset = "0x1A67E50", VA = "0x1A67E50", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1A67E88", Offset = "0x1A67E88", VA = "0x1A67E88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947DE8", Offset = "0x947DE8")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1A67F00", Offset = "0x1A67F00", VA = "0x1A67F00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947E48", Offset = "0x947E48")]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1A67F78", Offset = "0x1A67F78", VA = "0x1A67F78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947EA8", Offset = "0x947EA8")]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1A68004", Offset = "0x1A68004", VA = "0x1A68004")]
		public EffectFlicker()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F4B4", Offset = "0x93F4B4")]
	public class EffectPulse : EffectAbstractBase
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F4EC", Offset = "0x93F4EC")]
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
				[Address(RVA = "0x1EB88B8", Offset = "0x1EB88B8", VA = "0x1EB88B8", Slot = "4")]
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
				[Address(RVA = "0x1EB8900", Offset = "0x1EB8900", VA = "0x1EB8900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1EB87C4", Offset = "0x1EB87C4", VA = "0x1EB87C4")]
			[DebuggerHidden]
			public <CoUpdate>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1EB87F0", Offset = "0x1EB87F0", VA = "0x1EB87F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1EB87F4", Offset = "0x1EB87F4", VA = "0x1EB87F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1EB88C0", Offset = "0x1EB88C0", VA = "0x1EB88C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BF")]
		public new const string ClassName = "EffectPulse";

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945B48", Offset = "0x945B48")]
		public float frequency;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x945B68", Offset = "0x945B68")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1A680B4", Offset = "0x1A680B4", VA = "0x1A680B4", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1A680EC", Offset = "0x1A680EC", VA = "0x1A680EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x947FF8", Offset = "0x947FF8")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1A68164", Offset = "0x1A68164", VA = "0x1A68164")]
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
		[Address(RVA = "0x1A68B98", Offset = "0x1A68B98", VA = "0x1A68B98")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1A68DD4", Offset = "0x1A68DD4", VA = "0x1A68DD4")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1A69768", Offset = "0x1A69768", VA = "0x1A69768")]
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
				[Address(RVA = "0x1EB8970", Offset = "0x1EB8970", VA = "0x1EB8970")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700008F")]
			private int noise3DID
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x1EB8978", Offset = "0x1EB8978", VA = "0x1EB8978")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000090")]
			private int depthBlendID
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x1EB89F8", Offset = "0x1EB89F8", VA = "0x1EB89F8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000091")]
			private int colorGradientID
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x1EB8A78", Offset = "0x1EB8A78", VA = "0x1EB8A78")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000092")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x1EB8AF8", Offset = "0x1EB8AF8", VA = "0x1EB8AF8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000093")]
			private int meshSkewingID
			{
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0x1EB8B78", Offset = "0x1EB8B78", VA = "0x1EB8B78")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000094")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0x1EB8BF8", Offset = "0x1EB8BF8", VA = "0x1EB8BF8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000095")]
			public int materialID
			{
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0x1EB8C78", Offset = "0x1EB8C78", VA = "0x1EB8C78")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x1EB8D10", Offset = "0x1EB8D10", VA = "0x1EB8D10")]
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
			[Address(RVA = "0x1EB8908", Offset = "0x1EB8908", VA = "0x1EB8908")]
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
		[Address(RVA = "0x1A6B214", Offset = "0x1A6B214", VA = "0x1A6B214")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1A6B388", Offset = "0x1A6B388", VA = "0x1A6B388")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1A6B494", Offset = "0x1A6B494", VA = "0x1A6B494")]
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
		[Address(RVA = "0x1A6B900", Offset = "0x1A6B900", VA = "0x1A6B900")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1A6B918", Offset = "0x1A6B918", VA = "0x1A6B918")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1A6B98C", Offset = "0x1A6B98C", VA = "0x1A6B98C")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1A68EF0", Offset = "0x1A68EF0", VA = "0x1A68EF0")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1A6B9FC", Offset = "0x1A6B9FC", VA = "0x1A6B9FC")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1A6BA60", Offset = "0x1A6BA60", VA = "0x1A6BA60")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1A6BA7C", Offset = "0x1A6BA7C", VA = "0x1A6BA7C")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1A6BAA4", Offset = "0x1A6BAA4", VA = "0x1A6BAA4")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1A6BB48", Offset = "0x1A6BB48", VA = "0x1A6BB48")]
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
			[Address(RVA = "0x1A6BC48", Offset = "0x1A6BC48", VA = "0x1A6BC48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000097")]
		public float maxValue
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1A6BC50", Offset = "0x1A6BC50", VA = "0x1A6BC50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		public float randomValue
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x1A6BC58", Offset = "0x1A6BC58", VA = "0x1A6BC58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000099")]
		public Vector2 asVector2
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x1A6BC64", Offset = "0x1A6BC64", VA = "0x1A6BC64")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1A6BC6C", Offset = "0x1A6BC6C", VA = "0x1A6BC6C")]
		public float GetLerpedValue(float lerp01)
		{
			return default(float);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1A6BC84", Offset = "0x1A6BC84", VA = "0x1A6BC84")]
		public MinMaxRangeFloat(float min, float max)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class MinMaxRangeAttribute : Attribute
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x945BA0", Offset = "0x945BA0")]
		private float <minValue>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x945BB0", Offset = "0x945BB0")]
		private float <maxValue>k__BackingField;

		[Token(Token = "0x1700009A")]
		public float minValue
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1A6BBF0", Offset = "0x1A6BBF0", VA = "0x1A6BBF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9480A8", Offset = "0x9480A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1A6BBF8", Offset = "0x1A6BBF8", VA = "0x1A6BBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9480B8", Offset = "0x9480B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public float maxValue
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1A6BC00", Offset = "0x1A6BC00", VA = "0x1A6BC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9480C8", Offset = "0x9480C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1A6BC08", Offset = "0x1A6BC08", VA = "0x1A6BC08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9480D8", Offset = "0x9480D8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1A6BC10", Offset = "0x1A6BC10", VA = "0x1A6BC10")]
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
			[Address(RVA = "0x1A683A0", Offset = "0x1A683A0", VA = "0x1A683A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1A6BC8C", Offset = "0x1A6BC8C", VA = "0x1A6BC8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x1A684F8", Offset = "0x1A684F8", VA = "0x1A684F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1A6BD2C", Offset = "0x1A6BD2C", VA = "0x1A6BD2C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9480E8", Offset = "0x9480E8")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1A6BD84", Offset = "0x1A6BD84", VA = "0x1A6BD84")]
		public static void LoadIfNeeded()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class PlatformHelper
	{
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1A6C058", Offset = "0x1A6C058", VA = "0x1A6C058")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1A6C070", Offset = "0x1A6C070", VA = "0x1A6C070")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1A6C0F0", Offset = "0x1A6C0F0", VA = "0x1A6C0F0")]
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
			[Address(RVA = "0x1EB93EC", Offset = "0x1EB93EC", VA = "0x1EB93EC")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1EB9408", Offset = "0x1EB9408", VA = "0x1EB9408")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1EB9434", Offset = "0x1EB9434", VA = "0x1EB9434")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1EB952C", Offset = "0x1EB952C", VA = "0x1EB952C")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1EB9550", Offset = "0x1EB9550", VA = "0x1EB9550")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1EB95B0", Offset = "0x1EB95B0", VA = "0x1EB95B0")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1EB95C0", Offset = "0x1EB95C0", VA = "0x1EB95C0")]
			public void Flip()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1EB95DC", Offset = "0x1EB95DC", VA = "0x1EB95DC")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x1EB97C8", Offset = "0x1EB97C8", VA = "0x1EB97C8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1A6C0F8", Offset = "0x1A6C0F8", VA = "0x1A6C0F8")]
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
			[Address(RVA = "0x1A6C208", Offset = "0x1A6C208", VA = "0x1A6C208")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1A6C2B8", Offset = "0x1A6C2B8", VA = "0x1A6C2B8")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1A6C3EC", Offset = "0x1A6C3EC", VA = "0x1A6C3EC")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1A6C4E4", Offset = "0x1A6C4E4", VA = "0x1A6C4E4")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1A6C594", Offset = "0x1A6C594", VA = "0x1A6C594")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F50C", Offset = "0x93F50C")]
	[ExecuteInEditMode]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F558", Offset = "0x93F558")]
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
				[Address(RVA = "0x1EB9938", Offset = "0x1EB9938", VA = "0x1EB9938", Slot = "4")]
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
				[Address(RVA = "0x1EB9980", Offset = "0x1EB9980", VA = "0x1EB9980", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1EB9890", Offset = "0x1EB9890", VA = "0x1EB9890")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1EB98BC", Offset = "0x1EB98BC", VA = "0x1EB98BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1EB98C0", Offset = "0x1EB98C0", VA = "0x1EB98C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1EB9940", Offset = "0x1EB9940", VA = "0x1EB9940", Slot = "8")]
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
		[Address(RVA = "0x1A6CCD8", Offset = "0x1A6CCD8", VA = "0x1A6CCD8")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1A6CDB8", Offset = "0x1A6CDB8", VA = "0x1A6CDB8")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1A6CE5C", Offset = "0x1A6CE5C", VA = "0x1A6CE5C")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1A6CEA0", Offset = "0x1A6CEA0", VA = "0x1A6CEA0")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1A6CEB4", Offset = "0x1A6CEB4", VA = "0x1A6CEB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1A6CF54", Offset = "0x1A6CF54", VA = "0x1A6CF54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1A6CFB0", Offset = "0x1A6CFB0", VA = "0x1A6CFB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9480F8", Offset = "0x9480F8")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1A6CEE8", Offset = "0x1A6CEE8", VA = "0x1A6CEE8")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1A6D028", Offset = "0x1A6D028", VA = "0x1A6D028")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public static class SpotLightHelper
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1A6D030", Offset = "0x1A6D030", VA = "0x1A6D030")]
		public static float GetIntensity(Light light)
		{
			return default(float);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1A6D0C0", Offset = "0x1A6D0C0", VA = "0x1A6D0C0")]
		public static float GetSpotAngle(Light light)
		{
			return default(float);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1A6D150", Offset = "0x1A6D150", VA = "0x1A6D150")]
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
			[Address(RVA = "0x1EB9988", Offset = "0x1EB9988", VA = "0x1EB9988")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1A6D1E0", Offset = "0x1A6D1E0", VA = "0x1A6D1E0")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
	[Token(Token = "0x20000DB")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x93F578", Offset = "0x93F578")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F578", Offset = "0x93F578")]
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
			[Address(RVA = "0x1A6D278", Offset = "0x1A6D278", VA = "0x1A6D278")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1A6D308", Offset = "0x1A6D308", VA = "0x1A6D308")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1A6DA84", Offset = "0x1A6DA84", VA = "0x1A6DA84")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1A6D488", Offset = "0x1A6D488", VA = "0x1A6D488")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1A6DC90", Offset = "0x1A6DC90", VA = "0x1A6DC90")]
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
		[Address(RVA = "0x1A6DDF4", Offset = "0x1A6DDF4", VA = "0x1A6DDF4")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1A6DE2C", Offset = "0x1A6DE2C", VA = "0x1A6DE2C")]
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			return default(float);
		}

		[Token(Token = "0x600063B")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1A6DE5C", Offset = "0x1A6DE5C", VA = "0x1A6DE5C")]
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
		[Address(RVA = "0x1A6DF94", Offset = "0x1A6DF94", VA = "0x1A6DF94")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1A6E074", Offset = "0x1A6E074", VA = "0x1A6E074")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1A6E078", Offset = "0x1A6E078", VA = "0x1A6E078")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1A6E080", Offset = "0x1A6E080", VA = "0x1A6E080")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1A6E08C", Offset = "0x1A6E08C", VA = "0x1A6E08C")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1A6E09C", Offset = "0x1A6E09C", VA = "0x1A6E09C")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1A6E0A8", Offset = "0x1A6E0A8", VA = "0x1A6E0A8")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1A6E0B0", Offset = "0x1A6E0B0", VA = "0x1A6E0B0")]
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1A6E0C0", Offset = "0x1A6E0C0", VA = "0x1A6E0C0")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1A6E0F4", Offset = "0x1A6E0F4", VA = "0x1A6E0F4")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1A6E120", Offset = "0x1A6E120", VA = "0x1A6E120")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1A6E17C", Offset = "0x1A6E17C", VA = "0x1A6E17C")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1A6E1AC", Offset = "0x1A6E1AC", VA = "0x1A6E1AC")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1A6E258", Offset = "0x1A6E258", VA = "0x1A6E258")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1A6E2AC", Offset = "0x1A6E2AC", VA = "0x1A6E2AC")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1A6E34C", Offset = "0x1A6E34C", VA = "0x1A6E34C")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1A6E380", Offset = "0x1A6E380", VA = "0x1A6E380")]
		public static Color ComputeComplementaryColor(this Color self, bool blackAndWhite)
		{
			return default(Color);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1A6E428", Offset = "0x1A6E428", VA = "0x1A6E428")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1A6DC14", Offset = "0x1A6DC14", VA = "0x1A6DC14")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1A6DBFC", Offset = "0x1A6DBFC", VA = "0x1A6DBFC")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1A6DBB0", Offset = "0x1A6DBB0", VA = "0x1A6DBB0")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1A6E4D0", Offset = "0x1A6E4D0", VA = "0x1A6E4D0")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1A6E4F4", Offset = "0x1A6E4F4", VA = "0x1A6E4F4")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1A6E508", Offset = "0x1A6E508", VA = "0x1A6E508")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1A6E724", Offset = "0x1A6E724", VA = "0x1A6E724")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1A6E808", Offset = "0x1A6E808", VA = "0x1A6E808")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1A6E62C", Offset = "0x1A6E62C", VA = "0x1A6E62C")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1A6E848", Offset = "0x1A6E848", VA = "0x1A6E848")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1A6E914", Offset = "0x1A6E914", VA = "0x1A6E914")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1A6E918", Offset = "0x1A6E918", VA = "0x1A6E918")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F61C", Offset = "0x93F61C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x93F61C", Offset = "0x93F61C")]
	[DisallowMultipleComponent]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F6C0", Offset = "0x93F6C0")]
		private sealed class <>c
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<ParticleSystem> <>9__37_0;

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1EB9A7C", Offset = "0x1EB9A7C", VA = "0x1EB9A7C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1EB9A84", Offset = "0x1EB9A84", VA = "0x1EB9A84")]
			internal void <InstantiateParticleSystem>b__37_0(ParticleSystem ps)
			{
			}
		}

		[Token(Token = "0x4000389")]
		public const string ClassName = "VolumetricDustParticles";

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945BC0", Offset = "0x945BC0")]
		public float alpha;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945BD8", Offset = "0x945BD8")]
		public float size;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x945BF8", Offset = "0x945BF8")]
		public float speed;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x945C30", Offset = "0x945C30")]
		public MinMaxRangeFloat spawnDistanceRange;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x945C48", Offset = "0x945C48")]
		public float spawnMinDistance;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x945C80", Offset = "0x945C80")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool cullingEnabled;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x945CB8", Offset = "0x945CB8")]
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
			[Address(RVA = "0x1A6E920", Offset = "0x1A6E920", VA = "0x1A6E920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x948358", Offset = "0x948358")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1A6E928", Offset = "0x1A6E928", VA = "0x1A6E928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x948368", Offset = "0x948368")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1A6E934", Offset = "0x1A6E934", VA = "0x1A6E934")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1A67C20", Offset = "0x1A67C20", VA = "0x1A67C20")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x1A6E93C", Offset = "0x1A6E93C", VA = "0x1A6E93C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x1A6E9A4", Offset = "0x1A6E9A4", VA = "0x1A6E9A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1A6EA34", Offset = "0x1A6EA34", VA = "0x1A6EA34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A8")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1A6EADC", Offset = "0x1A6EADC", VA = "0x1A6EADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1A6ED6C", Offset = "0x1A6ED6C", VA = "0x1A6ED6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1A6EEC4", Offset = "0x1A6EEC4", VA = "0x1A6EEC4")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1A6F27C", Offset = "0x1A6F27C", VA = "0x1A6F27C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1A6F2A4", Offset = "0x1A6F2A4", VA = "0x1A6F2A4")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1A6F1EC", Offset = "0x1A6F1EC", VA = "0x1A6F1EC")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1A6F350", Offset = "0x1A6F350", VA = "0x1A6F350")]
		private void Play()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1A6FA9C", Offset = "0x1A6FA9C", VA = "0x1A6FA9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1A6FAA4", Offset = "0x1A6FAA4", VA = "0x1A6FAA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1A6FBE0", Offset = "0x1A6FBE0", VA = "0x1A6FBE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1A6F3FC", Offset = "0x1A6F3FC", VA = "0x1A6F3FC")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1A6EE04", Offset = "0x1A6EE04", VA = "0x1A6EE04")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1A6FD0C", Offset = "0x1A6FD0C", VA = "0x1A6FD0C")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1A701A4", Offset = "0x1A701A4", VA = "0x1A701A4")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[ExecuteInEditMode]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x93F6D0", Offset = "0x93F6D0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93F73C", Offset = "0x93F73C")]
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
				[Address(RVA = "0x1EB9BC8", Offset = "0x1EB9BC8", VA = "0x1EB9BC8", Slot = "4")]
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
				[Address(RVA = "0x1EB9C10", Offset = "0x1EB9C10", VA = "0x1EB9C10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1EB9B04", Offset = "0x1EB9B04", VA = "0x1EB9B04")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__209(int <>1__state)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x1EB9B30", Offset = "0x1EB9B30", VA = "0x1EB9B30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1EB9B34", Offset = "0x1EB9B34", VA = "0x1EB9B34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x1EB9BD0", Offset = "0x1EB9BD0", VA = "0x1EB9BD0", Slot = "8")]
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
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x945CD8", Offset = "0x945CD8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945CD8", Offset = "0x945CD8")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945D2C", Offset = "0x945D2C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x945D2C", Offset = "0x945D2C")]
		public float intensityInside;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x945D7C", Offset = "0x945D7C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945D7C", Offset = "0x945D7C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945D7C", Offset = "0x945D7C")]
		public float intensityOutside;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x945DF0", Offset = "0x945DF0")]
		public float intensityMultiplier;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945E04", Offset = "0x945E04")]
		public float hdrpExposureWeight;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945E1C", Offset = "0x945E1C")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945E54", Offset = "0x945E54")]
		public float spotAngle;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x945E74", Offset = "0x945E74")]
		public float spotAngleMultiplier;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945E88", Offset = "0x945E88")]
		public float coneRadiusStart;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public MeshType geomMeshType;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945EC0", Offset = "0x945EC0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945EF8", Offset = "0x945EF8")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945F10", Offset = "0x945F10")]
		public float fallOffStart;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945F48", Offset = "0x945F48")]
		public float fallOffEnd;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945F80", Offset = "0x945F80")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x945FB8", Offset = "0x945FB8")]
		public float fallOffEndMultiplier;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float depthBlendDistance;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float cameraClippingDistance;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945FCC", Offset = "0x945FCC")]
		public float glareFrontal;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x945FE4", Offset = "0x945FE4")]
		public float glareBehind;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x945FFC", Offset = "0x945FFC")]
		public float fresnelPow;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x946034", Offset = "0x946034")]
		public float noiseIntensity;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x94604C", Offset = "0x94604C")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x946088", Offset = "0x946088")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9460F4", Offset = "0x9460F4")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x946140", Offset = "0x946140")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x94618C", Offset = "0x94618C")]
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
			[Address(RVA = "0x1A6FF00", Offset = "0x1A6FF00", VA = "0x1A6FF00")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x170000AA")]
		private bool useColorFromAttachedLightSpot
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1A702A4", Offset = "0x1A702A4", VA = "0x1A702A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		private bool useColorTemperatureFromAttachedLightSpot
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1A70328", Offset = "0x1A70328", VA = "0x1A70328")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9485EC", Offset = "0x9485EC")]
		public float alphaInside
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x1A703C8", Offset = "0x1A703C8", VA = "0x1A703C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x1A703D0", Offset = "0x1A703D0", VA = "0x1A703D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x948624", Offset = "0x948624")]
		public float alphaOutside
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x1A703D8", Offset = "0x1A703D8", VA = "0x1A703D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1A703E0", Offset = "0x1A703E0", VA = "0x1A703E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1A703E8", Offset = "0x1A703E8", VA = "0x1A703E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1A703F0", Offset = "0x1A703F0", VA = "0x1A703F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool useIntensityFromAttachedLightSpot
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1A703F8", Offset = "0x1A703F8", VA = "0x1A703F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		public bool useSpotAngleFromAttachedLightSpot
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x1A704A8", Offset = "0x1A704A8", VA = "0x1A704A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public float coneAngle
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x1A6FF80", Offset = "0x1A6FF80", VA = "0x1A6FF80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B2")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x1A6DA88", Offset = "0x1A6DA88", VA = "0x1A6DA88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1A70560", Offset = "0x1A70560", VA = "0x1A70560")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public float coneVolume
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1A70604", Offset = "0x1A70604", VA = "0x1A70604")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B4")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1A70658", Offset = "0x1A70658", VA = "0x1A70658")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B5")]
		public Vector3 coneApexPositionLocal
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1A706D0", Offset = "0x1A706D0", VA = "0x1A706D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B6")]
		public Vector3 coneApexPositionGlobal
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1A706F0", Offset = "0x1A706F0", VA = "0x1A706F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B7")]
		public int geomSides
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x1A6DB28", Offset = "0x1A6DB28", VA = "0x1A6DB28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1A7076C", Offset = "0x1A7076C", VA = "0x1A7076C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public int geomSegments
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1A707F4", Offset = "0x1A707F4", VA = "0x1A707F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1A7087C", Offset = "0x1A7087C", VA = "0x1A7087C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1A70904", Offset = "0x1A70904", VA = "0x1A70904")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BA")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1A6CE4C", Offset = "0x1A6CE4C", VA = "0x1A6CE4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1A70A34", Offset = "0x1A70A34", VA = "0x1A70A34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BC")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1A70B10", Offset = "0x1A70B10", VA = "0x1A70B10")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170000BD")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1A70C38", Offset = "0x1A70C38", VA = "0x1A70C38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x94865C", Offset = "0x94865C")]
		public float fadeStart
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1A70C60", Offset = "0x1A70C60", VA = "0x1A70C60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1A70C68", Offset = "0x1A70C68", VA = "0x1A70C68")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x948694", Offset = "0x948694")]
		public float fadeEnd
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x1A70C70", Offset = "0x1A70C70", VA = "0x1A70C70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1A70C78", Offset = "0x1A70C78", VA = "0x1A70C78")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9486CC", Offset = "0x9486CC")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1A70C80", Offset = "0x1A70C80", VA = "0x1A70C80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1A70C88", Offset = "0x1A70C88", VA = "0x1A70C88")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public bool useFallOffEndFromAttachedLightSpot
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1A70C94", Offset = "0x1A70C94", VA = "0x1A70C94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1A7052C", Offset = "0x1A7052C", VA = "0x1A7052C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C3")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1A70D18", Offset = "0x1A70D18", VA = "0x1A70D18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x948704", Offset = "0x948704")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1A70D28", Offset = "0x1A70D28", VA = "0x1A70D28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1A70D38", Offset = "0x1A70D38", VA = "0x1A70D38")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public float fadeOutBegin
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1A70D54", Offset = "0x1A70D54", VA = "0x1A70D54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1A70D5C", Offset = "0x1A70D5C", VA = "0x1A70D5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public float fadeOutEnd
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1A70DB8", Offset = "0x1A70DB8", VA = "0x1A70DB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1A70DC0", Offset = "0x1A70DC0", VA = "0x1A70DC0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x1A6FFEC", Offset = "0x1A6FFEC", VA = "0x1A6FFEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C8")]
		public bool isTilted
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1A70DC8", Offset = "0x1A70DC8", VA = "0x1A70DC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		public int sortingLayerID
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1A70E68", Offset = "0x1A70E68", VA = "0x1A70E68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1A70E70", Offset = "0x1A70E70", VA = "0x1A70E70")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public string sortingLayerName
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1A70F14", Offset = "0x1A70F14", VA = "0x1A70F14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1A70F20", Offset = "0x1A70F20", VA = "0x1A70F20")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public int sortingOrder
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x1A70F50", Offset = "0x1A70F50", VA = "0x1A70F50")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x1A70F58", Offset = "0x1A70F58", VA = "0x1A70F58")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1A70FFC", Offset = "0x1A70FFC", VA = "0x1A70FFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1A71004", Offset = "0x1A71004", VA = "0x1A71004")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1A7107C", Offset = "0x1A7107C", VA = "0x1A7107C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public bool hasGeometry
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1A70010", Offset = "0x1A70010", VA = "0x1A70010")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public Bounds bounds
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1A7007C", Offset = "0x1A7007C", VA = "0x1A7007C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000D0")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1A7108C", Offset = "0x1A7108C", VA = "0x1A7108C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D1")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x1A6F214", Offset = "0x1A6F214", VA = "0x1A6F214")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000D2")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1A71170", Offset = "0x1A71170", VA = "0x1A71170")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D3")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1A71188", Offset = "0x1A71188", VA = "0x1A71188")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D4")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1A711F8", Offset = "0x1A711F8", VA = "0x1A711F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D5")]
		public float raycastDistance
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1A71290", Offset = "0x1A71290", VA = "0x1A71290")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D6")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1A71320", Offset = "0x1A71320", VA = "0x1A71320")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D7")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1A713C8", Offset = "0x1A713C8", VA = "0x1A713C8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D8")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1A71444", Offset = "0x1A71444", VA = "0x1A71444")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D9")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1A714C0", Offset = "0x1A714C0", VA = "0x1A714C0")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1A71540", Offset = "0x1A71540", VA = "0x1A71540")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1A71548", Offset = "0x1A71548", VA = "0x1A71548")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x170000DB")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1A71890", Offset = "0x1A71890", VA = "0x1A71890")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DC")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1A7193C", Offset = "0x1A7193C", VA = "0x1A7193C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x948398", Offset = "0x948398")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1A71944", Offset = "0x1A71944", VA = "0x1A71944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9483A8", Offset = "0x9483A8")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public string meshStats
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1A7194C", Offset = "0x1A7194C", VA = "0x1A7194C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1A71B00", Offset = "0x1A71B00", VA = "0x1A71B00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DF")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1A71BD8", Offset = "0x1A71BD8", VA = "0x1A71BD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public Light lightSpotAttached
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1A71DD4", Offset = "0x1A71DD4", VA = "0x1A71DD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1A71610", Offset = "0x1A71610", VA = "0x1A71610")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x948378", Offset = "0x948378")]
			add
			{
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1A716B0", Offset = "0x1A716B0", VA = "0x1A716B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x948388", Offset = "0x948388")]
			remove
			{
			}
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1A7047C", Offset = "0x1A7047C", VA = "0x1A7047C")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1A7155C", Offset = "0x1A7155C", VA = "0x1A7155C")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1A71750", Offset = "0x1A71750", VA = "0x1A71750")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1A71764", Offset = "0x1A71764", VA = "0x1A71764")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1A7184C", Offset = "0x1A7184C", VA = "0x1A7184C")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1A70D64", Offset = "0x1A70D64", VA = "0x1A70D64")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1A71898", Offset = "0x1A71898", VA = "0x1A71898")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1A71CC8", Offset = "0x1A71CC8", VA = "0x1A71CC8")]
		public Light GetLightSpotAttachedSlow(out AttachedLightType lightType)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1A71D9C", Offset = "0x1A71D9C", VA = "0x1A71D9C")]
		private void InitLightSpotAttachedCached()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1A71DDC", Offset = "0x1A71DDC", VA = "0x1A71DDC")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1A71E3C", Offset = "0x1A71E3C", VA = "0x1A71E3C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1A71FB4", Offset = "0x1A71FB4", VA = "0x1A71FB4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9483B8", Offset = "0x9483B8")]
		public void Generate()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1A71FC0", Offset = "0x1A71FC0", VA = "0x1A71FC0", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1A7224C", Offset = "0x1A7224C", VA = "0x1A7224C", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1A722E8", Offset = "0x1A722E8", VA = "0x1A722E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1A7232C", Offset = "0x1A7232C", VA = "0x1A7232C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1A723B8", Offset = "0x1A723B8", VA = "0x1A723B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1A71010", Offset = "0x1A71010", VA = "0x1A71010")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1A7244C", Offset = "0x1A7244C", VA = "0x1A7244C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9483F0", Offset = "0x9483F0")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1A724C4", Offset = "0x1A724C4", VA = "0x1A724C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1A724C8", Offset = "0x1A724C8", VA = "0x1A724C8")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1A72590", Offset = "0x1A72590", VA = "0x1A72590")]
		private void AssignPropertiesFromAttachedSpotLight()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1A7273C", Offset = "0x1A7273C", VA = "0x1A7273C")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1A72228", Offset = "0x1A72228", VA = "0x1A72228")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1A72128", Offset = "0x1A72128", VA = "0x1A72128")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1A72938", Offset = "0x1A72938", VA = "0x1A72938")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x93F74C", Offset = "0x93F74C")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x18FD46C", Offset = "0x18FD46C", VA = "0x18FD46C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x18FD568", Offset = "0x18FD568", VA = "0x18FD568")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x93F7AC", Offset = "0x93F7AC")]
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
		[Address(RVA = "0x18FD578", Offset = "0x18FD578", VA = "0x18FD578")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x18FD668", Offset = "0x18FD668", VA = "0x18FD668")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x18FD72C", Offset = "0x18FD72C", VA = "0x18FD72C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x18FD734", Offset = "0x18FD734", VA = "0x18FD734")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x18FD930", Offset = "0x18FD930", VA = "0x18FD930")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1A682DC", Offset = "0x1A682DC", VA = "0x1A682DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1A685A0", Offset = "0x1A685A0", VA = "0x1A685A0")]
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
			[Address(RVA = "0x1A685A8", Offset = "0x1A685A8", VA = "0x1A685A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1A685B0", Offset = "0x1A685B0", VA = "0x1A685B0")]
			set
			{
			}
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1A685EC", Offset = "0x1A685EC", VA = "0x1A685EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1A68684", Offset = "0x1A68684", VA = "0x1A68684")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1A68B74", Offset = "0x1A68B74", VA = "0x1A68B74")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9461AC", Offset = "0x9461AC")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9461F0", Offset = "0x9461F0")]
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
		[Address(RVA = "0x1A69770", Offset = "0x1A69770", VA = "0x1A69770")]
		public void Generate()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1A69E84", Offset = "0x1A69E84", VA = "0x1A69E84")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x946274", Offset = "0x946274")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1A6C100", Offset = "0x1A6C100", VA = "0x1A6C100")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1A6C1D4", Offset = "0x1A6C1D4", VA = "0x1A6C1D4")]
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
		[Address(RVA = "0x1E562D0", Offset = "0x1E562D0", VA = "0x1E562D0")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1E5639C", Offset = "0x1E5639C", VA = "0x1E5639C", Slot = "4")]
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
		[Address(RVA = "0x1E563A4", Offset = "0x1E563A4", VA = "0x1E563A4")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1E56470", Offset = "0x1E56470", VA = "0x1E56470", Slot = "4")]
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
		[Address(RVA = "0x1A18FD8", Offset = "0x1A18FD8", VA = "0x1A18FD8")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1A190F4", Offset = "0x1A190F4", VA = "0x1A190F4", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x6000709")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1A19350", Offset = "0x1A19350", VA = "0x1A19350", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F0")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1A195D0", Offset = "0x1A195D0", VA = "0x1A195D0")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1A195D4", Offset = "0x1A195D4", VA = "0x1A195D4", Slot = "7")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x600070D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1A198D8", Offset = "0x1A198D8", VA = "0x1A198D8", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F1")]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1A19C2C", Offset = "0x1A19C2C", VA = "0x1A19C2C")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1A19C30", Offset = "0x1A19C30", VA = "0x1A19C30")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1A19CA8", Offset = "0x1A19CA8", VA = "0x1A19CA8", Slot = "7")]
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
		[Address(RVA = "0x1A19E5C", Offset = "0x1A19E5C", VA = "0x1A19E5C", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1A1A19C", Offset = "0x1A1A19C", VA = "0x1A1A19C", Slot = "11")]
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
		[Address(RVA = "0x1A18FDC", Offset = "0x1A18FDC", VA = "0x1A18FDC")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1A19C6C", Offset = "0x1A19C6C", VA = "0x1A19C6C")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1A1DA00", Offset = "0x1A1DA00", VA = "0x1A1DA00", Slot = "4")]
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
		[Address(RVA = "0x1A1DA10", Offset = "0x1A1DA10", VA = "0x1A1DA10", Slot = "10")]
		public virtual object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1A1DCF4", Offset = "0x1A1DCF4", VA = "0x1A1DCF4", Slot = "11")]
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
		[Address(RVA = "0x1A1EA60", Offset = "0x1A1EA60", VA = "0x1A1EA60")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1A1EB9C", Offset = "0x1A1EB9C", VA = "0x1A1EB9C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1A1EBC0", Offset = "0x1A1EBC0", VA = "0x1A1EBC0")]
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
		[Address(RVA = "0x1A1F04C", Offset = "0x1A1F04C", VA = "0x1A1F04C")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1A1F420", Offset = "0x1A1F420", VA = "0x1A1F420")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1A2131C", Offset = "0x1A2131C", VA = "0x1A2131C")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1A21320", Offset = "0x1A21320", VA = "0x1A21320", Slot = "7")]
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
		[Address(RVA = "0x1A25128", Offset = "0x1A25128", VA = "0x1A25128")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1A2512C", Offset = "0x1A2512C", VA = "0x1A2512C", Slot = "7")]
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
		[Address(RVA = "0x1A25580", Offset = "0x1A25580", VA = "0x1A25580", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1A25768", Offset = "0x1A25768", VA = "0x1A25768", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1A26EB0", Offset = "0x1A26EB0", VA = "0x1A26EB0")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1A26EB4", Offset = "0x1A26EB4", VA = "0x1A26EB4", Slot = "7")]
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
		[Address(RVA = "0x1A272EC", Offset = "0x1A272EC", VA = "0x1A272EC", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1A2784C", Offset = "0x1A2784C", VA = "0x1A2784C", Slot = "11")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class ES3StackType : ES3CollectionType
	{
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1A2D420", Offset = "0x1A2D420", VA = "0x1A2D420")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1A2D424", Offset = "0x1A2D424", VA = "0x1A2D424", Slot = "7")]
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
		[Address(RVA = "0x1A2D85C", Offset = "0x1A2D85C", VA = "0x1A2D85C", Slot = "10")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1A2DB54", Offset = "0x1A2DB54", VA = "0x1A2DB54", Slot = "11")]
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
		[Address(RVA = "0x1A1DFE0", Offset = "0x1A1DFE0", VA = "0x1A1DFE0")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x600073E")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x600073F")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1A1DFE8", Offset = "0x1A1DFE8", VA = "0x1A1DFE8", Slot = "7")]
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
		[Address(RVA = "0x1A1E534", Offset = "0x1A1E534", VA = "0x1A1E534")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1A1E77C", Offset = "0x1A1E77C", VA = "0x1A1E77C")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1A1E6C0", Offset = "0x1A1E6C0", VA = "0x1A1E6C0")]
		public static Component GetOrCreateComponentIfNotExists(GameObject go, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F9")]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1A1DFE4", Offset = "0x1A1DFE4", VA = "0x1A1DFE4")]
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
		[Address(RVA = "0x1A25DD8", Offset = "0x1A25DD8", VA = "0x1A25DD8", Slot = "4")]
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
		[Address(RVA = "0x1A29868", Offset = "0x1A29868", VA = "0x1A29868")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x600074E")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x600074F")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1A2BDA0", Offset = "0x1A2BDA0", VA = "0x1A2BDA0", Slot = "7")]
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
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x93F864", Offset = "0x93F864")]
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
		[Address(RVA = "0x1A29918", Offset = "0x1A29918", VA = "0x1A29918")]
		protected ES3Type()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1A1D6D4", Offset = "0x1A1D6D4", VA = "0x1A1D6D4")]
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
		[Address(RVA = "0x1A25E30", Offset = "0x1A25E30", VA = "0x1A25E30")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1A2E0AC", Offset = "0x1A2E0AC", VA = "0x1A2E0AC")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1A29688", Offset = "0x1A29688", VA = "0x1A29688")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1A2E108", Offset = "0x1A2E108", VA = "0x1A2E108")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1A29678", Offset = "0x1A29678", VA = "0x1A29678")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1A299F0", Offset = "0x1A299F0", VA = "0x1A299F0")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x93F878", Offset = "0x93F878")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1A26E7C", Offset = "0x1A26E7C", VA = "0x1A26E7C")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1A5F17C", Offset = "0x1A5F17C", VA = "0x1A5F17C")]
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
		[Address(RVA = "0x1A64924", Offset = "0x1A64924", VA = "0x1A64924", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1A6492C", Offset = "0x1A6492C", VA = "0x1A6492C")]
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
		[Address(RVA = "0x1E55FCC", Offset = "0x1E55FCC", VA = "0x1E55FCC")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1E56098", Offset = "0x1E56098", VA = "0x1E56098", Slot = "4")]
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
		[Address(RVA = "0x1E561D4", Offset = "0x1E561D4", VA = "0x1E561D4")]
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
		[Address(RVA = "0x1A61024", Offset = "0x1A61024", VA = "0x1A61024")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1A610F8", Offset = "0x1A610F8", VA = "0x1A610F8", Slot = "4")]
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
		[Address(RVA = "0x1A61190", Offset = "0x1A61190", VA = "0x1A61190")]
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
		[Address(RVA = "0x1A626E4", Offset = "0x1A626E4", VA = "0x1A626E4")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1A627B8", Offset = "0x1A627B8", VA = "0x1A627B8", Slot = "4")]
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
		[Address(RVA = "0x1A62850", Offset = "0x1A62850", VA = "0x1A62850")]
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
		[Address(RVA = "0x1A6294C", Offset = "0x1A6294C", VA = "0x1A6294C")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1A62A20", Offset = "0x1A62A20", VA = "0x1A62A20", Slot = "4")]
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
		[Address(RVA = "0x1A62AB8", Offset = "0x1A62AB8", VA = "0x1A62AB8")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1A62B8C", Offset = "0x1A62B8C", VA = "0x1A62B8C", Slot = "4")]
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
		[Address(RVA = "0x1A62C24", Offset = "0x1A62C24", VA = "0x1A62C24")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1A62CF8", Offset = "0x1A62CF8", VA = "0x1A62CF8", Slot = "4")]
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
		[Address(RVA = "0x1A62D90", Offset = "0x1A62D90", VA = "0x1A62D90")]
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
		[Address(RVA = "0x1A62E8C", Offset = "0x1A62E8C", VA = "0x1A62E8C")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1A62F60", Offset = "0x1A62F60", VA = "0x1A62F60", Slot = "4")]
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
		[Address(RVA = "0x1A62FF8", Offset = "0x1A62FF8", VA = "0x1A62FF8")]
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
		[Address(RVA = "0x1A630F4", Offset = "0x1A630F4", VA = "0x1A630F4")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1A631C8", Offset = "0x1A631C8", VA = "0x1A631C8", Slot = "4")]
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
		[Address(RVA = "0x1A63260", Offset = "0x1A63260", VA = "0x1A63260")]
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
		[Address(RVA = "0x1A6335C", Offset = "0x1A6335C", VA = "0x1A6335C")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1A633EC", Offset = "0x1A633EC", VA = "0x1A633EC", Slot = "4")]
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
		[Address(RVA = "0x1A63484", Offset = "0x1A63484", VA = "0x1A63484")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1A63558", Offset = "0x1A63558", VA = "0x1A63558", Slot = "4")]
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
		[Address(RVA = "0x1A635F0", Offset = "0x1A635F0", VA = "0x1A635F0")]
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
		[Address(RVA = "0x1A636EC", Offset = "0x1A636EC", VA = "0x1A636EC")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1A637C0", Offset = "0x1A637C0", VA = "0x1A637C0", Slot = "4")]
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
		[Address(RVA = "0x1A63858", Offset = "0x1A63858", VA = "0x1A63858")]
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
		[Address(RVA = "0x1E5920C", Offset = "0x1E5920C", VA = "0x1E5920C")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1E592E0", Offset = "0x1E592E0", VA = "0x1E592E0", Slot = "4")]
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
		[Address(RVA = "0x1E59384", Offset = "0x1E59384", VA = "0x1E59384")]
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
		[Address(RVA = "0x1A63954", Offset = "0x1A63954", VA = "0x1A63954")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1A63A28", Offset = "0x1A63A28", VA = "0x1A63A28", Slot = "4")]
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
		[Address(RVA = "0x1A63AC0", Offset = "0x1A63AC0", VA = "0x1A63AC0")]
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
		[Address(RVA = "0x1A63BBC", Offset = "0x1A63BBC", VA = "0x1A63BBC")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1A63C90", Offset = "0x1A63C90", VA = "0x1A63C90", Slot = "4")]
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
		[Address(RVA = "0x1A63D28", Offset = "0x1A63D28", VA = "0x1A63D28")]
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
		[Address(RVA = "0x1A63E24", Offset = "0x1A63E24", VA = "0x1A63E24")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1A63EF8", Offset = "0x1A63EF8", VA = "0x1A63EF8", Slot = "4")]
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
		[Address(RVA = "0x1A63F90", Offset = "0x1A63F90", VA = "0x1A63F90")]
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
		[Address(RVA = "0x1A6408C", Offset = "0x1A6408C", VA = "0x1A6408C")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1A64160", Offset = "0x1A64160", VA = "0x1A64160", Slot = "4")]
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
		[Address(RVA = "0x1EACCF4", Offset = "0x1EACCF4", VA = "0x1EACCF4")]
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
		[Address(RVA = "0x1A641EC", Offset = "0x1A641EC", VA = "0x1A641EC")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1A642C0", Offset = "0x1A642C0", VA = "0x1A642C0", Slot = "4")]
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
		[Address(RVA = "0x1A64358", Offset = "0x1A64358", VA = "0x1A64358")]
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
		[Address(RVA = "0x1A64454", Offset = "0x1A64454", VA = "0x1A64454")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1A64528", Offset = "0x1A64528", VA = "0x1A64528", Slot = "4")]
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
		[Address(RVA = "0x1A645C0", Offset = "0x1A645C0", VA = "0x1A645C0")]
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
		[Address(RVA = "0x1A646BC", Offset = "0x1A646BC", VA = "0x1A646BC")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1A64790", Offset = "0x1A64790", VA = "0x1A64790", Slot = "4")]
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
		[Address(RVA = "0x1A64828", Offset = "0x1A64828", VA = "0x1A64828")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x2000121")]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1A2962C", Offset = "0x1A2962C", VA = "0x1A2962C")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1A29684", Offset = "0x1A29684", VA = "0x1A29684", Slot = "10")]
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
		[Address(RVA = "0x1A297CC", Offset = "0x1A297CC", VA = "0x1A297CC")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1A29818", Offset = "0x1A29818", VA = "0x1A29818", Slot = "7")]
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
		[Address(RVA = "0x1A2981C", Offset = "0x1A2981C", VA = "0x1A2981C")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1A2986C", Offset = "0x1A2986C", VA = "0x1A2986C", Slot = "10")]
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
		[Address(RVA = "0x1A29870", Offset = "0x1A29870", VA = "0x1A29870")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1A29938", Offset = "0x1A29938", VA = "0x1A29938")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1A29B9C", Offset = "0x1A29B9C", VA = "0x1A29B9C", Slot = "4")]
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
		[Address(RVA = "0x1A29F80", Offset = "0x1A29F80", VA = "0x1A29F80")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1A29FB8", Offset = "0x1A29FB8", VA = "0x1A29FB8", Slot = "10")]
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
		[Address(RVA = "0x1A29FBC", Offset = "0x1A29FBC", VA = "0x1A29FBC")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1A2A008", Offset = "0x1A2A008", VA = "0x1A2A008", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x93F88C", Offset = "0x93F88C")]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1A306E0", Offset = "0x1A306E0", VA = "0x1A306E0")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1A307A8", Offset = "0x1A307A8", VA = "0x1A307A8", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007DD")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x93F998", Offset = "0x93F998")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1A30A48", Offset = "0x1A30A48", VA = "0x1A30A48")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1A30B10", Offset = "0x1A30B10", VA = "0x1A30B10", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007E1")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x93FAC0", Offset = "0x93FAC0")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1A30E50", Offset = "0x1A30E50", VA = "0x1A30E50")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1A30F18", Offset = "0x1A30F18", VA = "0x1A30F18", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007E5")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x93FEC0", Offset = "0x93FEC0")]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1E54458", Offset = "0x1E54458", VA = "0x1E54458")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1E54524", Offset = "0x1E54524", VA = "0x1E54524", Slot = "10")]
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
		[Address(RVA = "0x1E56A10", Offset = "0x1E56A10", VA = "0x1E56A10")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1E56ADC", Offset = "0x1E56ADC", VA = "0x1E56ADC", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60007ED")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x940004", Offset = "0x940004")]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1EA39B8", Offset = "0x1EA39B8", VA = "0x1EA39B8")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1EA3A84", Offset = "0x1EA3A84", VA = "0x1EA3A84", Slot = "10")]
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
		[Address(RVA = "0x1EA3E68", Offset = "0x1EA3E68", VA = "0x1EA3E68")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x940148", Offset = "0x940148")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1EA3F64", Offset = "0x1EA3F64", VA = "0x1EA3F64")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1EA4030", Offset = "0x1EA4030", VA = "0x1EA4030", Slot = "10")]
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
		[Address(RVA = "0x1EA411C", Offset = "0x1EA411C", VA = "0x1EA411C")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9401C8", Offset = "0x9401C8")]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1EA4218", Offset = "0x1EA4218", VA = "0x1EA4218")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1EA42E4", Offset = "0x1EA42E4", VA = "0x1EA42E4", Slot = "10")]
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
		[Address(RVA = "0x1EA4AF0", Offset = "0x1EA4AF0", VA = "0x1EA4AF0")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x940408", Offset = "0x940408")]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1EA617C", Offset = "0x1EA617C", VA = "0x1EA617C")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1EA6248", Offset = "0x1EA6248", VA = "0x1EA6248", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000800")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x940760", Offset = "0x940760")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1EA74CC", Offset = "0x1EA74CC", VA = "0x1EA74CC")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1EA7598", Offset = "0x1EA7598", VA = "0x1EA7598", Slot = "10")]
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
		[Address(RVA = "0x1EA7B20", Offset = "0x1EA7B20", VA = "0x1EA7B20")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9408C0", Offset = "0x9408C0")]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1EAB94C", Offset = "0x1EAB94C", VA = "0x1EAB94C")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1EABA18", Offset = "0x1EABA18", VA = "0x1EABA18", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000809")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9409CC", Offset = "0x9409CC")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1EAD17C", Offset = "0x1EAD17C", VA = "0x1EAD17C")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1EAD248", Offset = "0x1EAD248", VA = "0x1EAD248", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600080D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x940CD0", Offset = "0x940CD0")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1A60874", Offset = "0x1A60874", VA = "0x1A60874")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1A60940", Offset = "0x1A60940", VA = "0x1A60940", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000811")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x940DA4", Offset = "0x940DA4")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1A2F704", Offset = "0x1A2F704", VA = "0x1A2F704")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1A2F7CC", Offset = "0x1A2F7CC", VA = "0x1A2F7CC", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x940E5C", Offset = "0x940E5C")]
	public class ES3Type_AudioClip : ES3ObjectType
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1A2F970", Offset = "0x1A2F970", VA = "0x1A2F970")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1A2FA38", Offset = "0x1A2FA38", VA = "0x1A2FA38", Slot = "7")]
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
		[Address(RVA = "0x1A2FC80", Offset = "0x1A2FC80", VA = "0x1A2FC80")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x940F4C", Offset = "0x940F4C")]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1A2FD90", Offset = "0x1A2FD90", VA = "0x1A2FD90")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1A2FE58", Offset = "0x1A2FE58", VA = "0x1A2FE58", Slot = "4")]
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
		[Address(RVA = "0x1A30254", Offset = "0x1A30254", VA = "0x1A30254")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941090", Offset = "0x941090")]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1A30364", Offset = "0x1A30364", VA = "0x1A30364")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1A3042C", Offset = "0x1A3042C", VA = "0x1A3042C", Slot = "4")]
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
		[Address(RVA = "0x1A305D0", Offset = "0x1A305D0", VA = "0x1A305D0")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x94112C", Offset = "0x94112C")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1E549A4", Offset = "0x1E549A4", VA = "0x1E549A4")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1E54A70", Offset = "0x1E54A70", VA = "0x1E54A70", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941388", Offset = "0x941388")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1E55170", Offset = "0x1E55170", VA = "0x1E55170")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1E5523C", Offset = "0x1E5523C", VA = "0x1E5523C", Slot = "4")]
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
		[Address(RVA = "0x1E55880", Offset = "0x1E55880", VA = "0x1E55880")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x94145C", Offset = "0x94145C")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1E55458", Offset = "0x1E55458", VA = "0x1E55458")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x1E55524", Offset = "0x1E55524", VA = "0x1E55524", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000833")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1E5573C", Offset = "0x1E5573C", VA = "0x1E5573C")]
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
		[Address(RVA = "0x1E55784", Offset = "0x1E55784", VA = "0x1E55784")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941530", Offset = "0x941530")]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x1E5597C", Offset = "0x1E5597C", VA = "0x1E5597C")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1E55A48", Offset = "0x1E55A48", VA = "0x1E55A48", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9415E8", Offset = "0x9415E8")]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x1E55CF4", Offset = "0x1E55CF4", VA = "0x1E55CF4")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1E55DC0", Offset = "0x1E55DC0", VA = "0x1E55DC0", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941684", Offset = "0x941684")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1E565E0", Offset = "0x1E565E0", VA = "0x1E565E0")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1E566AC", Offset = "0x1E566AC", VA = "0x1E566AC", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941774", Offset = "0x941774")]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1E56AE4", Offset = "0x1E56AE4", VA = "0x1E56AE4")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1E56BB0", Offset = "0x1E56BB0", VA = "0x1E56BB0", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941810", Offset = "0x941810")]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1E56D90", Offset = "0x1E56D90", VA = "0x1E56D90")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1E56E5C", Offset = "0x1E56E5C", VA = "0x1E56E5C", Slot = "4")]
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
		[Address(RVA = "0x1E56F34", Offset = "0x1E56F34", VA = "0x1E56F34")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941890", Offset = "0x941890")]
	public class ES3Type_Font : ES3Type
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1E57030", Offset = "0x1E57030", VA = "0x1E57030")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1E570FC", Offset = "0x1E570FC", VA = "0x1E570FC", Slot = "4")]
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
		[Address(RVA = "0x1E57268", Offset = "0x1E57268", VA = "0x1E57268")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x94192C", Offset = "0x94192C")]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x1E57364", Offset = "0x1E57364", VA = "0x1E57364")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x1E57430", Offset = "0x1E57430", VA = "0x1E57430", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941A8C", Offset = "0x941A8C")]
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
		[Address(RVA = "0x1E57920", Offset = "0x1E57920", VA = "0x1E57920")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1E579EC", Offset = "0x1E579EC", VA = "0x1E579EC", Slot = "4")]
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
		[Address(RVA = "0x1E58070", Offset = "0x1E58070", VA = "0x1E58070")]
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
		[Address(RVA = "0x1E58418", Offset = "0x1E58418", VA = "0x1E58418")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941BB4", Offset = "0x941BB4")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x1E58514", Offset = "0x1E58514", VA = "0x1E58514")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x1E585E0", Offset = "0x1E585E0", VA = "0x1E585E0", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941C6C", Offset = "0x941C6C")]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1E58790", Offset = "0x1E58790", VA = "0x1E58790")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x1E5885C", Offset = "0x1E5885C", VA = "0x1E5885C", Slot = "4")]
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
		[Address(RVA = "0x1E589CC", Offset = "0x1E589CC", VA = "0x1E589CC")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941D08", Offset = "0x941D08")]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1E58AC8", Offset = "0x1E58AC8", VA = "0x1E58AC8")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x1E58B94", Offset = "0x1E58B94", VA = "0x1E58B94", Slot = "4")]
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
		[Address(RVA = "0x1E58D50", Offset = "0x1E58D50", VA = "0x1E58D50")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941DA4", Offset = "0x941DA4")]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x1E58E4C", Offset = "0x1E58E4C", VA = "0x1E58E4C")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x1E58F18", Offset = "0x1E58F18", VA = "0x1E58F18", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941E78", Offset = "0x941E78")]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1E59480", Offset = "0x1E59480", VA = "0x1E59480")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x1E5954C", Offset = "0x1E5954C", VA = "0x1E5954C", Slot = "4")]
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
		[Address(RVA = "0x1E5979C", Offset = "0x1E5979C", VA = "0x1E5979C")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x941F4C", Offset = "0x941F4C")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x1E59898", Offset = "0x1E59898", VA = "0x1E59898")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x1E59964", Offset = "0x1E59964", VA = "0x1E59964", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x942004", Offset = "0x942004")]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x1E59A98", Offset = "0x1E59A98", VA = "0x1E59A98")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x1E59B64", Offset = "0x1E59B64", VA = "0x1E59B64", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000884")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9422D0", Offset = "0x9422D0")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1E5A45C", Offset = "0x1E5A45C", VA = "0x1E5A45C")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x1E5A528", Offset = "0x1E5A528", VA = "0x1E5A528", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x942484", Offset = "0x942484")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1E5AB44", Offset = "0x1E5AB44", VA = "0x1E5AB44")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1E5AC10", Offset = "0x1E5AC10", VA = "0x1E5AC10", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x942638", Offset = "0x942638")]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1E5B214", Offset = "0x1E5B214", VA = "0x1E5B214")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1E5B2E0", Offset = "0x1E5B2E0", VA = "0x1E5B2E0", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x942AA8", Offset = "0x942AA8")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x1E5C2C0", Offset = "0x1E5C2C0", VA = "0x1E5C2C0")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1E5C38C", Offset = "0x1E5C38C", VA = "0x1E5C38C", Slot = "10")]
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
		[Address(RVA = "0x1EA2D7C", Offset = "0x1EA2D7C", VA = "0x1EA2D7C")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x942B98", Offset = "0x942B98")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x1EA2E78", Offset = "0x1EA2E78", VA = "0x1EA2E78")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x1EA2F44", Offset = "0x1EA2F44", VA = "0x1EA2F44", Slot = "4")]
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
		[Address(RVA = "0x1EA31B8", Offset = "0x1EA31B8", VA = "0x1EA31B8")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x942C6C", Offset = "0x942C6C")]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x1EA32B4", Offset = "0x1EA32B4", VA = "0x1EA32B4")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x1EA3380", Offset = "0x1EA3380", VA = "0x1EA3380", Slot = "10")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x942E58", Offset = "0x942E58")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x1EA4BEC", Offset = "0x1EA4BEC", VA = "0x1EA4BEC")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x1EA4CB8", Offset = "0x1EA4CB8", VA = "0x1EA4CB8", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x942F9C", Offset = "0x942F9C")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1EA5074", Offset = "0x1EA5074", VA = "0x1EA5074")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1EA5140", Offset = "0x1EA5140", VA = "0x1EA5140", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9430C4", Offset = "0x9430C4")]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x1EA54CC", Offset = "0x1EA54CC", VA = "0x1EA54CC")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1EA5598", Offset = "0x1EA5598", VA = "0x1EA5598", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x94341C", Offset = "0x94341C")]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x1EA6D1C", Offset = "0x1EA6D1C", VA = "0x1EA6D1C")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1EA6DE8", Offset = "0x1EA6DE8", VA = "0x1EA6DE8", Slot = "7")]
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
		[Address(RVA = "0x1EA7090", Offset = "0x1EA7090", VA = "0x1EA7090")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x94350C", Offset = "0x94350C")]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1EA718C", Offset = "0x1EA718C", VA = "0x1EA718C")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1EA7258", Offset = "0x1EA7258", VA = "0x1EA7258", Slot = "7")]
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
		[Address(RVA = "0x1EA73D0", Offset = "0x1EA73D0", VA = "0x1EA73D0")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9435A8", Offset = "0x9435A8")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1EA7C1C", Offset = "0x1EA7C1C", VA = "0x1EA7C1C")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1EA7CE8", Offset = "0x1EA7CE8", VA = "0x1EA7CE8", Slot = "4")]
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
		[Address(RVA = "0x1EA7F04", Offset = "0x1EA7F04", VA = "0x1EA7F04")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x94367C", Offset = "0x94367C")]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1EA8000", Offset = "0x1EA8000", VA = "0x1EA8000")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1EA80CC", Offset = "0x1EA80CC", VA = "0x1EA80CC", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x943750", Offset = "0x943750")]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x1EA830C", Offset = "0x1EA830C", VA = "0x1EA830C")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1EA83D8", Offset = "0x1EA83D8", VA = "0x1EA83D8", Slot = "10")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60008CA")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x943904", Offset = "0x943904")]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1EA8998", Offset = "0x1EA8998", VA = "0x1EA8998")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1EA8A64", Offset = "0x1EA8A64", VA = "0x1EA8A64", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x943A64", Offset = "0x943A64")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x1EA8F8C", Offset = "0x1EA8F8C", VA = "0x1EA8F8C")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1EA9058", Offset = "0x1EA9058", VA = "0x1EA9058", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x943BA8", Offset = "0x943BA8")]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1EA94EC", Offset = "0x1EA94EC", VA = "0x1EA94EC")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1EA95B8", Offset = "0x1EA95B8", VA = "0x1EA95B8", Slot = "4")]
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
		[Address(RVA = "0x1EA9758", Offset = "0x1EA9758", VA = "0x1EA9758")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x943C44", Offset = "0x943C44")]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1EA9854", Offset = "0x1EA9854", VA = "0x1EA9854")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x1EA9920", Offset = "0x1EA9920", VA = "0x1EA9920", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x943EBC", Offset = "0x943EBC")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1EAA0EC", Offset = "0x1EAA0EC", VA = "0x1EAA0EC")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1EAA1B8", Offset = "0x1EAA1B8", VA = "0x1EAA1B8", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x944054", Offset = "0x944054")]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1EAA7A0", Offset = "0x1EAA7A0", VA = "0x1EAA7A0")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1EAA86C", Offset = "0x1EAA86C", VA = "0x1EAA86C", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9441D0", Offset = "0x9441D0")]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x1EAADC0", Offset = "0x1EAADC0", VA = "0x1EAADC0")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1EAAE8C", Offset = "0x1EAAE8C", VA = "0x1EAAE8C", Slot = "10")]
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
		[Address(RVA = "0x1EAB850", Offset = "0x1EAB850", VA = "0x1EAB850")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9444B8", Offset = "0x9444B8")]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1EABD9C", Offset = "0x1EABD9C", VA = "0x1EABD9C")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x1EABE68", Offset = "0x1EABE68", VA = "0x1EABE68", Slot = "10")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9445A8", Offset = "0x9445A8")]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1EAC1F4", Offset = "0x1EAC1F4", VA = "0x1EAC1F4")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x1EAC2C0", Offset = "0x1EAC2C0", VA = "0x1EAC2C0", Slot = "10")]
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
		[Address(RVA = "0x1EACBF8", Offset = "0x1EACBF8", VA = "0x1EACBF8")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x94483C", Offset = "0x94483C")]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x1EACDF0", Offset = "0x1EACDF0", VA = "0x1EACDF0")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x1EACEBC", Offset = "0x1EACEBC", VA = "0x1EACEBC", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9448F4", Offset = "0x9448F4")]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x1A5EE24", Offset = "0x1A5EE24", VA = "0x1A5EE24")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x1A5EEF0", Offset = "0x1A5EEF0", VA = "0x1A5EEF0", Slot = "4")]
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
		[Address(RVA = "0x1A5F738", Offset = "0x1A5F738", VA = "0x1A5F738")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9449E4", Offset = "0x9449E4")]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1A5F0A4", Offset = "0x1A5F0A4", VA = "0x1A5F0A4")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1A5F1AC", Offset = "0x1A5F1AC", VA = "0x1A5F1AC", Slot = "10")]
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
		[Address(RVA = "0x1A5F63C", Offset = "0x1A5F63C", VA = "0x1A5F63C")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x944AD4", Offset = "0x944AD4")]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1A5F834", Offset = "0x1A5F834", VA = "0x1A5F834")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x1A5F900", Offset = "0x1A5F900", VA = "0x1A5F900", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x944CC0", Offset = "0x944CC0")]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1A5FFFC", Offset = "0x1A5FFFC", VA = "0x1A5FFFC")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1A600C8", Offset = "0x1A600C8", VA = "0x1A600C8", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x944EC8", Offset = "0x944EC8")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1A60C24", Offset = "0x1A60C24", VA = "0x1A60C24")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x1A60CF0", Offset = "0x1A60CF0", VA = "0x1A60CF0", Slot = "4")]
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
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x944FD4", Offset = "0x944FD4")]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x1A6128C", Offset = "0x1A6128C", VA = "0x1A6128C")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x1A61358", Offset = "0x1A61358", VA = "0x1A61358", Slot = "4")]
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
		[Address(RVA = "0x1A614C8", Offset = "0x1A614C8", VA = "0x1A614C8")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x945070", Offset = "0x945070")]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x1A615C4", Offset = "0x1A615C4", VA = "0x1A615C4")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1A61690", Offset = "0x1A61690", VA = "0x1A61690", Slot = "4")]
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
		[Address(RVA = "0x1A61858", Offset = "0x1A61858", VA = "0x1A61858")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x945128", Offset = "0x945128")]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x1A61954", Offset = "0x1A61954", VA = "0x1A61954")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1A61A20", Offset = "0x1A61A20", VA = "0x1A61A20", Slot = "4")]
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
		[Address(RVA = "0x1A61C20", Offset = "0x1A61C20", VA = "0x1A61C20")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9451E0", Offset = "0x9451E0")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x1A61D1C", Offset = "0x1A61D1C", VA = "0x1A61D1C")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x1A61DE8", Offset = "0x1A61DE8", VA = "0x1A61DE8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600092B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x1A62000", Offset = "0x1A62000", VA = "0x1A62000")]
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
		[Address(RVA = "0x1A620A0", Offset = "0x1A620A0", VA = "0x1A620A0")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9452B4", Offset = "0x9452B4")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x1A6219C", Offset = "0x1A6219C", VA = "0x1A6219C")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1A62268", Offset = "0x1A62268", VA = "0x1A62268", Slot = "4")]
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
		[Address(RVA = "0x1A21150", Offset = "0x1A21150", VA = "0x1A21150")]
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
		[Address(RVA = "0x1A681F0", Offset = "0x1A681F0", VA = "0x1A681F0")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1A682D4", Offset = "0x1A682D4", VA = "0x1A682D4")]
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
		[Address(RVA = "0x18F901C", Offset = "0x18F901C", VA = "0x18F901C", Slot = "4")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x18F9478", Offset = "0x18F9478", VA = "0x18F9478", Slot = "5")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x18F98BC", Offset = "0x18F98BC", VA = "0x18F98BC")]
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
		[Address(RVA = "0x1A6DCA8", Offset = "0x1A6DCA8", VA = "0x1A6DCA8")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1A6DD74", Offset = "0x1A6DD74", VA = "0x1A6DD74", Slot = "22")]
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
		[Address(RVA = "0x1A1E944", Offset = "0x1A1E944", VA = "0x1A1E944")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1A1EA1C", Offset = "0x1A1EA1C", VA = "0x1A1EA1C")]
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
		[Address(RVA = "0x1A21924", Offset = "0x1A21924", VA = "0x1A21924")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x1A219B8", Offset = "0x1A219B8", VA = "0x1A219B8")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x1A21A1C", Offset = "0x1A21A1C", VA = "0x1A21A1C")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x1A219B0", Offset = "0x1A219B0", VA = "0x1A219B0")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1A21A58", Offset = "0x1A21A58", VA = "0x1A21A58")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x1A21A60", Offset = "0x1A21A60", VA = "0x1A21A60")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1A21128", Offset = "0x1A21128", VA = "0x1A21128")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1A21A68", Offset = "0x1A21A68", VA = "0x1A21A68")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1A210C4", Offset = "0x1A210C4", VA = "0x1A210C4")]
		public static string GetDirectoryName(string path)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1A21A70", Offset = "0x1A21A70", VA = "0x1A21A70")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1A21B98", Offset = "0x1A21B98", VA = "0x1A21B98")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x1A21BD8", Offset = "0x1A21BD8", VA = "0x1A21BD8")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1A21D00", Offset = "0x1A21D00", VA = "0x1A21D00")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1A21D08", Offset = "0x1A21D08", VA = "0x1A21D08")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1A21D10", Offset = "0x1A21D10", VA = "0x1A21D10")]
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
		[Address(RVA = "0x1A263B0", Offset = "0x1A263B0", VA = "0x1A263B0")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1A2658C", Offset = "0x1A2658C", VA = "0x1A2658C")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x1A26608", Offset = "0x1A26608", VA = "0x1A26608")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1A2670C", Offset = "0x1A2670C", VA = "0x1A2670C")]
		public Dictionary<long, long> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1A2693C", Offset = "0x1A2693C", VA = "0x1A2693C")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x1A266B4", Offset = "0x1A266B4", VA = "0x1A266B4")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x1A26DBC", Offset = "0x1A26DBC", VA = "0x1A26DBC")]
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
			[Address(RVA = "0x1A1E2D4", Offset = "0x1A1E2D4", VA = "0x1A1E2D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public bool IsInitialised
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1A28BD0", Offset = "0x1A28BD0", VA = "0x1A28BD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1A28C30", Offset = "0x1A28C30", VA = "0x1A28C30")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1A28E30", Offset = "0x1A28E30", VA = "0x1A28E30")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x1A29084", Offset = "0x1A29084", VA = "0x1A29084")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x1A29100", Offset = "0x1A29100", VA = "0x1A29100")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1A2918C", Offset = "0x1A2918C", VA = "0x1A2918C")]
		public ES3Prefab GetPrefab(long id)
		{
			return null;
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1A2926C", Offset = "0x1A2926C", VA = "0x1A2926C")]
		public long GetPrefab(ES3Prefab prefab)
		{
			return default(long);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x1A1E478", Offset = "0x1A1E478", VA = "0x1A1E478")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x1A26B64", Offset = "0x1A26B64", VA = "0x1A26B64")]
		public void Add(UnityEngine.Object obj, long id)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x1A29388", Offset = "0x1A29388", VA = "0x1A29388")]
		public void AddPrefab(ES3Prefab prefab)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x1A29428", Offset = "0x1A29428", VA = "0x1A29428")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x1A294C4", Offset = "0x1A294C4", VA = "0x1A294C4")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x1A29560", Offset = "0x1A29560", VA = "0x1A29560")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x1A295C4", Offset = "0x1A295C4", VA = "0x1A295C4")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x1A26C0C", Offset = "0x1A26C0C", VA = "0x1A26C0C")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x1A28B18", Offset = "0x1A28B18", VA = "0x1A28B18")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000192")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x1A2219C", Offset = "0x1A2219C", VA = "0x1A2219C", Slot = "6")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1A221A8", Offset = "0x1A221A8", VA = "0x1A221A8", Slot = "7")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1A2221C", Offset = "0x1A2221C", VA = "0x1A2221C")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x945408", Offset = "0x945408")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x1A28A30", Offset = "0x1A28A30", VA = "0x1A28A30", Slot = "6")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1A28AA4", Offset = "0x1A28AA4", VA = "0x1A28AA4", Slot = "7")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1A26E30", Offset = "0x1A26E30", VA = "0x1A26E30")]
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
				[Address(RVA = "0x1EB7DE0", Offset = "0x1EB7DE0", VA = "0x1EB7DE0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E8")]
			public string Name
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x1EB7E2C", Offset = "0x1EB7E2C", VA = "0x1EB7E2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			public Type MemberType
			{
				[Token(Token = "0x6000995")]
				[Address(RVA = "0x1EB7E64", Offset = "0x1EB7E64", VA = "0x1EB7E64")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			public bool IsPublic
			{
				[Token(Token = "0x6000996")]
				[Address(RVA = "0x1EB7EB0", Offset = "0x1EB7EB0", VA = "0x1EB7EB0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EB")]
			public bool IsProtected
			{
				[Token(Token = "0x6000997")]
				[Address(RVA = "0x1EB7F50", Offset = "0x1EB7F50", VA = "0x1EB7F50")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x1EB7FA4", Offset = "0x1EB7FA4", VA = "0x1EB7FA4")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x1EB8184", Offset = "0x1EB8184", VA = "0x1EB8184")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x1EB81CC", Offset = "0x1EB81CC", VA = "0x1EB81CC")]
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
			[Address(RVA = "0x1EB821C", Offset = "0x1EB821C", VA = "0x1EB821C")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x1EB82A0", Offset = "0x1EB82A0", VA = "0x1EB82A0")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x2000197")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x94541C", Offset = "0x94541C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x1EB7D48", Offset = "0x1EB7D48", VA = "0x1EB7D48")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x1EB7D50", Offset = "0x1EB7D50", VA = "0x1EB7D50")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x94542C", Offset = "0x94542C")]
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
			[Address(RVA = "0x1EB7C50", Offset = "0x1EB7C50", VA = "0x1EB7C50")]
			public <>c()
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x1EB7C58", Offset = "0x1EB7C58", VA = "0x1EB7C58")]
			internal IEnumerable<Type> <GetDerivedTypes>b__24_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x1EB7C7C", Offset = "0x1EB7C7C", VA = "0x1EB7C7C")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__24_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x1EB7D00", Offset = "0x1EB7D00", VA = "0x1EB7D00")]
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
			[Address(RVA = "0x1A2A00C", Offset = "0x1A2A00C", VA = "0x1A2A00C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1A1D774", Offset = "0x1A1D774", VA = "0x1A1D774")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1A2A3E8", Offset = "0x1A2A3E8", VA = "0x1A2A3E8")]
		public static List<FieldInfo> GetSerializableFields(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x1A2AAEC", Offset = "0x1A2AAEC", VA = "0x1A2AAEC")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1A2A7B0", Offset = "0x1A2A7B0", VA = "0x1A2A7B0")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x1A1F294", Offset = "0x1A1F294", VA = "0x1A1F294")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1A276AC", Offset = "0x1A276AC", VA = "0x1A276AC")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1A1A114", Offset = "0x1A1A114", VA = "0x1A1A114")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x1A195C8", Offset = "0x1A195C8", VA = "0x1A195C8")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1A275E4", Offset = "0x1A275E4", VA = "0x1A275E4")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1A2B23C", Offset = "0x1A2B23C", VA = "0x1A2B23C")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1A28124", Offset = "0x1A28124", VA = "0x1A28124")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1A2835C", Offset = "0x1A2835C", VA = "0x1A2835C")]
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
		[Address(RVA = "0x1A2B4D4", Offset = "0x1A2B4D4", VA = "0x1A2B4D4")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1A29F60", Offset = "0x1A29F60", VA = "0x1A29F60")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1A2B8BC", Offset = "0x1A2B8BC", VA = "0x1A2B8BC")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1A2A3A8", Offset = "0x1A2A3A8", VA = "0x1A2A3A8")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1A2B8DC", Offset = "0x1A2B8DC", VA = "0x1A2B8DC")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1A2B8FC", Offset = "0x1A2B8FC", VA = "0x1A2B8FC")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1A1DC6C", Offset = "0x1A1DC6C", VA = "0x1A1DC6C")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1A2B11C", Offset = "0x1A2B11C", VA = "0x1A2B11C")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1A2A3C8", Offset = "0x1A2A3C8", VA = "0x1A2A3C8")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x1A2B91C", Offset = "0x1A2B91C", VA = "0x1A2B91C")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1A2A388", Offset = "0x1A2A388", VA = "0x1A2A388")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x1A29920", Offset = "0x1A29920", VA = "0x1A29920")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1A2B934", Offset = "0x1A2B934", VA = "0x1A2B934")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1A2B134", Offset = "0x1A2B134", VA = "0x1A2B134")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1A2B954", Offset = "0x1A2B954", VA = "0x1A2B954")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1A2B9CC", Offset = "0x1A2B9CC", VA = "0x1A2B9CC")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1A2B494", Offset = "0x1A2B494", VA = "0x1A2B494")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1A2B4B0", Offset = "0x1A2B4B0", VA = "0x1A2B4B0")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1A2B00C", Offset = "0x1A2B00C", VA = "0x1A2B00C")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x1A2A7A4", Offset = "0x1A2A7A4", VA = "0x1A2A7A4")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1A2BA6C", Offset = "0x1A2BA6C", VA = "0x1A2BA6C")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1A2BA90", Offset = "0x1A2BA90", VA = "0x1A2BA90")]
		public static Type GetInterface(Type type, string interfaceName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x94543C", Offset = "0x94543C")]
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
		[Address(RVA = "0x1A22270", Offset = "0x1A22270", VA = "0x1A22270")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x1A224A4", Offset = "0x1A224A4", VA = "0x1A224A4", Slot = "20")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x1A229A4", Offset = "0x1A229A4", VA = "0x1A229A4", Slot = "21")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x1A22B74", Offset = "0x1A22B74", VA = "0x1A22B74", Slot = "22")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x1A22B84", Offset = "0x1A22B84", VA = "0x1A22B84", Slot = "26")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1A22E68", Offset = "0x1A22E68", VA = "0x1A22E68", Slot = "27")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1A22E70", Offset = "0x1A22E70", VA = "0x1A22E70", Slot = "28")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x1A22E80", Offset = "0x1A22E80", VA = "0x1A22E80", Slot = "29")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x1A22E84", Offset = "0x1A22E84", VA = "0x1A22E84", Slot = "30")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x1A22EC4", Offset = "0x1A22EC4", VA = "0x1A22EC4", Slot = "31")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1A22ECC", Offset = "0x1A22ECC", VA = "0x1A22ECC", Slot = "32")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x1A22ED0", Offset = "0x1A22ED0", VA = "0x1A22ED0", Slot = "33")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x1A22F94", Offset = "0x1A22F94", VA = "0x1A22F94", Slot = "34")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x1A22F9C", Offset = "0x1A22F9C", VA = "0x1A22F9C", Slot = "35")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x1A22FA0", Offset = "0x1A22FA0", VA = "0x1A22FA0", Slot = "36")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1A22FE0", Offset = "0x1A22FE0", VA = "0x1A22FE0", Slot = "37")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x1A230A4", Offset = "0x1A230A4", VA = "0x1A230A4", Slot = "24")]
		internal override bool Goto(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x1A23138", Offset = "0x1A23138", VA = "0x1A23138")]
		protected void Reset()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x1A231D8", Offset = "0x1A231D8", VA = "0x1A231D8")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x1A23318", Offset = "0x1A23318", VA = "0x1A23318", Slot = "23")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x1A232B0", Offset = "0x1A232B0", VA = "0x1A232B0")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x1A226A0", Offset = "0x1A226A0", VA = "0x1A226A0")]
		private char ReadCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1A22B8C", Offset = "0x1A22B8C", VA = "0x1A22B8C")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x1A2279C", Offset = "0x1A2279C", VA = "0x1A2279C")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x1A238CC", Offset = "0x1A238CC", VA = "0x1A238CC")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x1A23AB0", Offset = "0x1A23AB0", VA = "0x1A23AB0")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x1A2260C", Offset = "0x1A2260C", VA = "0x1A2260C")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x1A23CB8", Offset = "0x1A23CB8", VA = "0x1A23CB8")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x1A223F4", Offset = "0x1A223F4", VA = "0x1A223F4")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x1A23894", Offset = "0x1A23894", VA = "0x1A23894")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1A23820", Offset = "0x1A23820", VA = "0x1A23820")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x1A23834", Offset = "0x1A23834", VA = "0x1A23834")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x1A2268C", Offset = "0x1A2268C", VA = "0x1A2268C")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x1A22770", Offset = "0x1A22770", VA = "0x1A22770")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x1A23D38", Offset = "0x1A23D38", VA = "0x1A23D38")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x1A23D48", Offset = "0x1A23D48", VA = "0x1A23D48")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x1A23E6C", Offset = "0x1A23E6C", VA = "0x1A23E6C", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x1A24030", Offset = "0x1A24030", VA = "0x1A24030", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x1A240B0", Offset = "0x1A240B0", VA = "0x1A240B0", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1A24130", Offset = "0x1A24130", VA = "0x1A24130", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1A24148", Offset = "0x1A24148", VA = "0x1A24148", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x1A241BC", Offset = "0x1A241BC", VA = "0x1A241BC", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x1A24270", Offset = "0x1A24270", VA = "0x1A24270", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1A24324", Offset = "0x1A24324", VA = "0x1A24324", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1A2433C", Offset = "0x1A2433C", VA = "0x1A2433C", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1A24354", Offset = "0x1A24354", VA = "0x1A24354", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x1A2436C", Offset = "0x1A2436C", VA = "0x1A2436C", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1A24388", Offset = "0x1A24388", VA = "0x1A24388", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1A243A4", Offset = "0x1A243A4", VA = "0x1A243A4", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x1A243C0", Offset = "0x1A243C0", VA = "0x1A243C0", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1A243DC", Offset = "0x1A243DC", VA = "0x1A243DC", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1A2445C", Offset = "0x1A2445C", VA = "0x1A2445C", Slot = "25")]
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
		[Address(RVA = "0x1A1EA50", Offset = "0x1A1EA50", VA = "0x1A1EA50")]
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
		[Address(RVA = "0x1A20F1C", Offset = "0x1A20F1C", VA = "0x1A20F1C")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1A20FEC", Offset = "0x1A20FEC", VA = "0x1A20FEC")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1A21094", Offset = "0x1A21094", VA = "0x1A21094")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x1A210B4", Offset = "0x1A210B4", VA = "0x1A210B4")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1A21130", Offset = "0x1A21130", VA = "0x1A21130", Slot = "22")]
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
		[Address(RVA = "0x1A25F40", Offset = "0x1A25F40", VA = "0x1A25F40")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1A26084", Offset = "0x1A26084", VA = "0x1A26084")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1A25F90", Offset = "0x1A25F90", VA = "0x1A25F90")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1A260DC", Offset = "0x1A260DC", VA = "0x1A260DC", Slot = "22")]
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
			[Address(RVA = "0x1A2BC40", Offset = "0x1A2BC40", VA = "0x1A2BC40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1A2BC64", Offset = "0x1A2BC64", VA = "0x1A2BC64")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x1A2BC94", Offset = "0x1A2BC94", VA = "0x1A2BC94")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x1A2BD94", Offset = "0x1A2BD94", VA = "0x1A2BD94", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public static class ES3Stream
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1A28528", Offset = "0x1A28528", VA = "0x1A28528")]
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
		[Address(RVA = "0x1A25CE4", Offset = "0x1A25CE4", VA = "0x1A25CE4")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x1A25D44", Offset = "0x1A25D44", VA = "0x1A25D44")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x94630C", Offset = "0x94630C")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x1A1D8EC", Offset = "0x1A1D8EC", VA = "0x1A1D8EC")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x1A2F538", Offset = "0x1A2F538", VA = "0x1A2F538")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1A2F624", Offset = "0x1A2F624", VA = "0x1A2F624")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1A2EB8C", Offset = "0x1A2EB8C", VA = "0x1A2EB8C")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1A2E798", Offset = "0x1A2E798", VA = "0x1A2E798")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class ES3WebClass
	{
		[Token(Token = "0x20001A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x945474", Offset = "0x945474")]
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
				[Address(RVA = "0x1EB8364", Offset = "0x1EB8364", VA = "0x1EB8364", Slot = "4")]
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
				[Address(RVA = "0x1EB83AC", Offset = "0x1EB83AC", VA = "0x1EB83AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x1EB82C4", Offset = "0x1EB82C4", VA = "0x1EB82C4")]
			[DebuggerHidden]
			public <SendWebRequest>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x1EB82F0", Offset = "0x1EB82F0", VA = "0x1EB82F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x1EB82F4", Offset = "0x1EB82F4", VA = "0x1EB82F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x1EB836C", Offset = "0x1EB836C", VA = "0x1EB836C", Slot = "8")]
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
			[Address(RVA = "0x1A64B44", Offset = "0x1A64B44", VA = "0x1A64B44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x1A64B84", Offset = "0x1A64B84", VA = "0x1A64B84")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x1A64C38", Offset = "0x1A64C38", VA = "0x1A64C38")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x1A64CDC", Offset = "0x1A64CDC", VA = "0x1A64CDC")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1A64D7C", Offset = "0x1A64D7C", VA = "0x1A64D7C")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x1A64EDC", Offset = "0x1A64EDC", VA = "0x1A64EDC")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x1A650CC", Offset = "0x1A650CC", VA = "0x1A650CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9484C0", Offset = "0x9484C0")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x1A65144", Offset = "0x1A65144", VA = "0x1A65144", Slot = "4")]
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
		[Address(RVA = "0x1A24478", Offset = "0x1A24478", VA = "0x1A24478")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x1A24484", Offset = "0x1A24484", VA = "0x1A24484")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x1A2453C", Offset = "0x1A2453C", VA = "0x1A2453C", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x1A24560", Offset = "0x1A24560", VA = "0x1A24560", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x1A24604", Offset = "0x1A24604", VA = "0x1A24604", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x1A2468C", Offset = "0x1A2468C", VA = "0x1A2468C", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1A24730", Offset = "0x1A24730", VA = "0x1A24730", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x1A247D4", Offset = "0x1A247D4", VA = "0x1A247D4", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1A247F8", Offset = "0x1A247F8", VA = "0x1A247F8", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1A2481C", Offset = "0x1A2481C", VA = "0x1A2481C", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x1A24840", Offset = "0x1A24840", VA = "0x1A24840", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x1A248D4", Offset = "0x1A248D4", VA = "0x1A248D4", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x1A24968", Offset = "0x1A24968", VA = "0x1A24968", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1A249FC", Offset = "0x1A249FC", VA = "0x1A249FC", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x1A24A90", Offset = "0x1A24A90", VA = "0x1A24A90", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1A24AD4", Offset = "0x1A24AD4", VA = "0x1A24AD4", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x1A24B5C", Offset = "0x1A24B5C", VA = "0x1A24B5C", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x1A24D94", Offset = "0x1A24D94", VA = "0x1A24D94", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x1A24DF4", Offset = "0x1A24DF4", VA = "0x1A24DF4")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x1A24E28", Offset = "0x1A24E28", VA = "0x1A24E28")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x1A24E60", Offset = "0x1A24E60", VA = "0x1A24E60", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x1A24EDC", Offset = "0x1A24EDC", VA = "0x1A24EDC", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1A24F10", Offset = "0x1A24F10", VA = "0x1A24F10", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1A24F44", Offset = "0x1A24F44", VA = "0x1A24F44", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1A24FA0", Offset = "0x1A24FA0", VA = "0x1A24FA0", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1A24FA4", Offset = "0x1A24FA4", VA = "0x1A24FA4", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1A24FD8", Offset = "0x1A24FD8", VA = "0x1A24FD8", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1A25008", Offset = "0x1A25008", VA = "0x1A25008", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1A25030", Offset = "0x1A25030", VA = "0x1A25030", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1A25058", Offset = "0x1A25058", VA = "0x1A25058", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1A25088", Offset = "0x1A25088", VA = "0x1A25088", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1A2508C", Offset = "0x1A2508C", VA = "0x1A2508C", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1A2509C", Offset = "0x1A2509C", VA = "0x1A2509C", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1A250AC", Offset = "0x1A250AC", VA = "0x1A250AC", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1A250DC", Offset = "0x1A250DC", VA = "0x1A250DC", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1A25104", Offset = "0x1A25104", VA = "0x1A25104", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1A25108", Offset = "0x1A25108", VA = "0x1A25108", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1A2510C", Offset = "0x1A2510C", VA = "0x1A2510C", Slot = "22")]
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
		[Address(RVA = "0x1A66E38", Offset = "0x1A66E38", VA = "0x1A66E38")]
		public ES3XMLWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1A66E44", Offset = "0x1A66E44", VA = "0x1A66E44")]
		internal ES3XMLWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1A66EF0", Offset = "0x1A66EF0", VA = "0x1A66EF0", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1A66F14", Offset = "0x1A66F14", VA = "0x1A66F14", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x1A66F38", Offset = "0x1A66F38", VA = "0x1A66F38", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x1A66F60", Offset = "0x1A66F60", VA = "0x1A66F60", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x1A66F84", Offset = "0x1A66F84", VA = "0x1A66F84", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x1A66FA8", Offset = "0x1A66FA8", VA = "0x1A66FA8", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x1A66FCC", Offset = "0x1A66FCC", VA = "0x1A66FCC", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x1A66FF0", Offset = "0x1A66FF0", VA = "0x1A66FF0", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x1A67014", Offset = "0x1A67014", VA = "0x1A67014", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x1A67038", Offset = "0x1A67038", VA = "0x1A67038", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1A6705C", Offset = "0x1A6705C", VA = "0x1A6705C", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x1A670F0", Offset = "0x1A670F0", VA = "0x1A670F0", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1A67184", Offset = "0x1A67184", VA = "0x1A67184", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x1A67218", Offset = "0x1A67218", VA = "0x1A67218", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x1A672AC", Offset = "0x1A672AC", VA = "0x1A672AC", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x1A67334", Offset = "0x1A67334", VA = "0x1A67334", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] bytes)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x1A677E0", Offset = "0x1A677E0", VA = "0x1A677E0", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x1A677E4", Offset = "0x1A677E4", VA = "0x1A677E4", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x1A677E8", Offset = "0x1A677E8", VA = "0x1A677E8", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x1A677F0", Offset = "0x1A677F0", VA = "0x1A677F0", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1A677FC", Offset = "0x1A677FC", VA = "0x1A677FC", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1A673CC", Offset = "0x1A673CC", VA = "0x1A673CC")]
		protected void StartWriteProperty(string name, [Optional] ICollection<KeyValuePair<string, object>> attributes)
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1A67870", Offset = "0x1A67870", VA = "0x1A67870", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x1A67914", Offset = "0x1A67914", VA = "0x1A67914", Slot = "12")]
		internal override void StartWriteCollection(int length)
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x1A67918", Offset = "0x1A67918", VA = "0x1A67918", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x1A6791C", Offset = "0x1A6791C", VA = "0x1A6791C", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x1A67920", Offset = "0x1A67920", VA = "0x1A67920", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x1A67924", Offset = "0x1A67924", VA = "0x1A67924", Slot = "16")]
		internal override void StartWriteDictionary(int length)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x1A67928", Offset = "0x1A67928", VA = "0x1A67928", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x1A6792C", Offset = "0x1A6792C", VA = "0x1A6792C", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x1A67930", Offset = "0x1A67930", VA = "0x1A67930", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x1A67934", Offset = "0x1A67934", VA = "0x1A67934", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x1A67938", Offset = "0x1A67938", VA = "0x1A67938", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1A6793C", Offset = "0x1A6793C", VA = "0x1A6793C", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x1A6799C", Offset = "0x1A6799C", VA = "0x1A6799C", Slot = "22")]
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
			[Address(RVA = "0x18F9F30", Offset = "0x18F9F30", VA = "0x18F9F30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x18F9F38", Offset = "0x18F9F38", VA = "0x18F9F38")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public AESBits EncryptionBits
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x18F9F40", Offset = "0x18F9F40", VA = "0x18F9F40")]
			get
			{
				return default(AESBits);
			}
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x18F9F48", Offset = "0x18F9F48", VA = "0x18F9F48")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public byte[] Salt
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x18F9F50", Offset = "0x18F9F50", VA = "0x18F9F50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x18F9F58", Offset = "0x18F9F58", VA = "0x18F9F58")]
			set
			{
			}
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x18F98C4", Offset = "0x18F98C4", VA = "0x18F98C4")]
		public AESEncryptor(string password, AESBits encryptionBits)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x18F9978", Offset = "0x18F9978", VA = "0x18F9978")]
		public AESEncryptor(string password, AESBits encryptionBits, byte[] salt)
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x18F9A48", Offset = "0x18F9A48", VA = "0x18F9A48")]
		private byte[] Encrypt(byte[] data, byte[] key, byte[] iV)
		{
			return null;
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x18F9BAC", Offset = "0x18F9BAC", VA = "0x18F9BAC")]
		public byte[] Encrypt(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x18F9CBC", Offset = "0x18F9CBC", VA = "0x18F9CBC")]
		private byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x18F9E20", Offset = "0x18F9E20", VA = "0x18F9E20")]
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
		[Address(RVA = "0x1A69EA0", Offset = "0x1A69EA0", VA = "0x1A69EA0")]
		private MD5Core()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x1A69EA8", Offset = "0x1A69EA8", VA = "0x1A69EA8")]
		public static byte[] GetHash(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x1A6A058", Offset = "0x1A6A058", VA = "0x1A6A058")]
		public static byte[] GetHash(string input)
		{
			return null;
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x1A6A0B8", Offset = "0x1A6A0B8", VA = "0x1A6A0B8")]
		public static string GetHashString(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x1A6A1CC", Offset = "0x1A6A1CC", VA = "0x1A6A1CC")]
		public static string GetHashString(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x1A6A294", Offset = "0x1A6A294", VA = "0x1A6A294")]
		public static string GetHashString(string input)
		{
			return null;
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x1A69F70", Offset = "0x1A69F70", VA = "0x1A69F70")]
		public static byte[] GetHash(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x1A6AD88", Offset = "0x1A6AD88", VA = "0x1A6AD88")]
		internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ABCDStruct ABCD, long len)
		{
			return null;
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x1A6A2F4", Offset = "0x1A6A2F4", VA = "0x1A6A2F4")]
		internal static void GetHashBlock(byte[] input, ref ABCDStruct ABCDValue, int ibStart)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1A6B158", Offset = "0x1A6B158", VA = "0x1A6B158")]
		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1A6B180", Offset = "0x1A6B180", VA = "0x1A6B180")]
		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x1A6B1A8", Offset = "0x1A6B1A8", VA = "0x1A6B1A8")]
		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1A6B1CC", Offset = "0x1A6B1CC", VA = "0x1A6B1CC")]
		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x1A6B1F0", Offset = "0x1A6B1F0", VA = "0x1A6B1F0")]
		private static uint LSR(uint i, int s)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x1A6AFD4", Offset = "0x1A6AFD4", VA = "0x1A6AFD4")]
		private static uint[] Converter(byte[] input, int ibStart)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	public class MD5Encryptor
	{
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x1A6B1FC", Offset = "0x1A6B1FC", VA = "0x1A6B1FC")]
		public MD5Encryptor()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1A6B204", Offset = "0x1A6B204", VA = "0x1A6B204")]
		public string GetMD5(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x1A6B20C", Offset = "0x1A6B20C", VA = "0x1A6B20C")]
		public string GetMD5(string data)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AD")]
	public class Obfuscator
	{
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x1A6BF2C", Offset = "0x1A6BF2C", VA = "0x1A6BF2C")]
		public static byte[] Obfuscate(byte[] data, string key)
		{
			return null;
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x1A6BFC4", Offset = "0x1A6BFC4", VA = "0x1A6BFC4")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x1A6C050", Offset = "0x1A6C050", VA = "0x1A6C050")]
		public Obfuscator()
		{
		}
	}
}
