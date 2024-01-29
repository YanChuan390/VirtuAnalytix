using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
namespace I2.Loc;

[Token(Token = "0x2000002")]
public static class PersistentStorage
{
	[Token(Token = "0x2000003")]
	public enum eFileType
	{
		[Token(Token = "0x4000003")]
		Raw,
		[Token(Token = "0x4000004")]
		Persistent,
		[Token(Token = "0x4000005")]
		Temporal,
		[Token(Token = "0x4000006")]
		Streaming
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static I2CustomPersistentStorage mStorage;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1AF205C", Offset = "0x1AF205C", VA = "0x1AF205C")]
	public static void SetSetting_String(string key, string value)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1AF2114", Offset = "0x1AF2114", VA = "0x1AF2114")]
	public static string GetSetting_String(string key, string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1AF21CC", Offset = "0x1AF21CC", VA = "0x1AF21CC")]
	public static void DeleteSetting(string key)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1AF227C", Offset = "0x1AF227C", VA = "0x1AF227C")]
	public static bool HasSetting(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1AF232C", Offset = "0x1AF232C", VA = "0x1AF232C")]
	public static void ForceSaveSettings()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1AF23CC", Offset = "0x1AF23CC", VA = "0x1AF23CC")]
	public static bool CanAccessFiles()
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1AF246C", Offset = "0x1AF246C", VA = "0x1AF246C")]
	public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1AF253C", Offset = "0x1AF253C", VA = "0x1AF253C")]
	public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1AF2604", Offset = "0x1AF2604", VA = "0x1AF2604")]
	public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1AF26CC", Offset = "0x1AF26CC", VA = "0x1AF26CC")]
	public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000004")]
public abstract class I2BasePersistentStorage
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x157560C", Offset = "0x157560C", VA = "0x157560C", Slot = "4")]
	public virtual void SetSetting_String(string key, string value)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x15758CC", Offset = "0x15758CC", VA = "0x15758CC", Slot = "5")]
	public virtual string GetSetting_String(string key, string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1575B3C", Offset = "0x1575B3C", VA = "0x1575B3C", Slot = "6")]
	public virtual void DeleteSetting(string key)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1575D74", Offset = "0x1575D74", VA = "0x1575D74", Slot = "7")]
	public virtual void ForceSaveSettings()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1575D7C", Offset = "0x1575D7C", VA = "0x1575D7C", Slot = "8")]
	public virtual bool HasSetting(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1575D88", Offset = "0x1575D88", VA = "0x1575D88", Slot = "9")]
	public virtual bool CanAccessFiles()
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1575D90", Offset = "0x1575D90", VA = "0x1575D90")]
	private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1575E3C", Offset = "0x1575E3C", VA = "0x1575E3C", Slot = "10")]
	public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x15760D8", Offset = "0x15760D8", VA = "0x15760D8", Slot = "11")]
	public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1576364", Offset = "0x1576364", VA = "0x1576364", Slot = "12")]
	public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x15765E0", Offset = "0x15765E0", VA = "0x15765E0", Slot = "13")]
	public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x157685C", Offset = "0x157685C", VA = "0x157685C")]
	protected I2BasePersistentStorage()
	{
	}
}
[Token(Token = "0x2000005")]
public class I2CustomPersistentStorage : I2BasePersistentStorage
{
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1576864", Offset = "0x1576864", VA = "0x1576864")]
	public I2CustomPersistentStorage()
	{
	}
}
[Token(Token = "0x2000006")]
public class BaseSpecializationManager
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string[] mSpecializations;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<string, string> mSpecializationsFallbacks;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x156D304", Offset = "0x156D304", VA = "0x156D304", Slot = "4")]
	public virtual void InitializeSpecializations()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x156D828", Offset = "0x156D828", VA = "0x156D828", Slot = "5")]
	public virtual string GetCurrentSpecialization()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x156D88C", Offset = "0x156D88C", VA = "0x156D88C", Slot = "6")]
	public virtual string GetFallbackSpecialization(string specialization)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x156D930", Offset = "0x156D930", VA = "0x156D930")]
	public BaseSpecializationManager()
	{
	}
}
[Token(Token = "0x2000007")]
public class SpecializationManager : BaseSpecializationManager
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static SpecializationManager Singleton;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1AF5784", Offset = "0x1AF5784", VA = "0x1AF5784")]
	private SpecializationManager()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1AF57B4", Offset = "0x1AF57B4", VA = "0x1AF57B4")]
	public static string GetSpecializedText(string text, [Optional] string specialization)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1AF59A8", Offset = "0x1AF59A8", VA = "0x1AF59A8")]
	public static string SetSpecializedText(string text, string newText, string specialization)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1AF5D00", Offset = "0x1AF5D00", VA = "0x1AF5D00")]
	public static string SetSpecializedText(Dictionary<string, string> specializations)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1AF5AB4", Offset = "0x1AF5AB4", VA = "0x1AF5AB4")]
	public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class EventCallback
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MonoBehaviour Target;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string MethodName;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x156DF2C", Offset = "0x156DF2C", VA = "0x156DF2C")]
	public void Execute([Optional] UnityEngine.Object Sender)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x156DF94", Offset = "0x156DF94", VA = "0x156DF94")]
	public bool HasCallback()
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x156E028", Offset = "0x156E028", VA = "0x156E028")]
	public EventCallback()
	{
	}
}
[Token(Token = "0x2000009")]
public enum ePluralType
{
	[Token(Token = "0x400000D")]
	Zero,
	[Token(Token = "0x400000E")]
	One,
	[Token(Token = "0x400000F")]
	Two,
	[Token(Token = "0x4000010")]
	Few,
	[Token(Token = "0x4000011")]
	Many,
	[Token(Token = "0x4000012")]
	Plural
}
[Token(Token = "0x200000A")]
public static class GoogleLanguages
{
	[Token(Token = "0x200000B")]
	public struct LanguageCodeDef
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Code;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string GoogleCode;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool HasJoinedWords;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int PluralRule;
	}

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<string, LanguageCodeDef> mLanguageDef;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x156E090", Offset = "0x156E090", VA = "0x156E090")]
	public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x156E2D4", Offset = "0x156E2D4", VA = "0x156E2D4")]
	private static bool LanguageMatchesFilter(string Language, string[] Filters)
	{
		return default(bool);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x156E430", Offset = "0x156E430", VA = "0x156E430")]
	public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x156E5A8", Offset = "0x156E5A8", VA = "0x156E5A8")]
	public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x156E82C", Offset = "0x156E82C", VA = "0x156E82C")]
	public static bool LanguageCode_HasJoinedWord(string languageCode)
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x156E998", Offset = "0x156E998", VA = "0x156E998")]
	private static int GetPluralRule(string langCode)
	{
		return default(int);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x156EB1C", Offset = "0x156EB1C", VA = "0x156EB1C")]
	public static ePluralType GetPluralType(string langCode, int n)
	{
		return default(ePluralType);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x156F21C", Offset = "0x156F21C", VA = "0x156F21C")]
	private static bool inRange(int amount, int min, int max)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000C")]
public static class GoogleTranslation
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<UnityWebRequest> mCurrentTranslations;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<TranslationJob> mTranslationJobs;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1574EDC", Offset = "0x1574EDC", VA = "0x1574EDC")]
	public static string UppercaseFirst(string s)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1574FD0", Offset = "0x1574FD0", VA = "0x1574FD0")]
	public static string TitleCase(string s)
	{
		return null;
	}
}
[Token(Token = "0x200000D")]
public class TranslationJob
{
}
[Serializable]
[Token(Token = "0x200000E")]
public class LanguageData
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Code;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public byte Flags;

	[NonSerialized]
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool Compressed;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x15770F4", Offset = "0x15770F4", VA = "0x15770F4")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1577104", Offset = "0x1577104", VA = "0x1577104")]
	public bool IsLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1577114", Offset = "0x1577114", VA = "0x1577114")]
	public bool CanBeUnloaded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1577124", Offset = "0x1577124", VA = "0x1577124")]
	public void SetLoaded(bool loaded)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1577140", Offset = "0x1577140", VA = "0x1577140")]
	public LanguageData()
	{
	}
}
[Token(Token = "0x200000F")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x970AA8", Offset = "0x970AA8")]
public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
{
	[Token(Token = "0x2000010")]
	public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LanguageSourceData mSource;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int version;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool NeverDestroy;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool UserAgreesToHaveItOnTheScene;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool UserAgreesToHaveItInsideThePluginsFolder;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool GoogleLiveSyncIsUptoDate;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<UnityEngine.Object> Assets;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string Google_WebServiceURL;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string Google_SpreadsheetKey;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string Google_SpreadsheetName;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string Google_LastUpdatedVersion;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float GoogleUpdateDelay;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<LanguageData> mLanguages;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool IgnoreDeviceLanguage;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<TermData> mTerms;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool CaseInsensitiveTerms;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string mTerm_AppName;

	[Token(Token = "0x17000001")]
	public LanguageSourceData SourceData
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1577148", Offset = "0x1577148", VA = "0x1577148", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1577150", Offset = "0x1577150", VA = "0x1577150", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1577158", Offset = "0x1577158", VA = "0x1577158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970DA8", Offset = "0x970DA8")]
		add
		{
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x15771FC", Offset = "0x15771FC", VA = "0x15771FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970DB8", Offset = "0x970DB8")]
		remove
		{
		}
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x15772A0", Offset = "0x15772A0", VA = "0x15772A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x157735C", Offset = "0x157735C", VA = "0x157735C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x15773E0", Offset = "0x15773E0", VA = "0x15773E0")]
	public string GetSourceName()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x15774D4", Offset = "0x15774D4", VA = "0x15774D4", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x15774E0", Offset = "0x15774E0", VA = "0x15774E0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1577B08", Offset = "0x1577B08", VA = "0x1577B08")]
	public LanguageSource()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x970AF4", Offset = "0x970AF4")]
public class LanguageSourceAsset : ScriptableObject, ILanguageSource
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LanguageSourceData mSource;

	[Token(Token = "0x17000002")]
	public LanguageSourceData SourceData
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1578148", Offset = "0x1578148", VA = "0x1578148", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1578150", Offset = "0x1578150", VA = "0x1578150", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1578158", Offset = "0x1578158", VA = "0x1578158")]
	public LanguageSourceAsset()
	{
	}
}
[Token(Token = "0x2000012")]
public interface ILanguageSource
{
}
[Serializable]
[Token(Token = "0x2000013")]
[ExecuteInEditMode]
public class LanguageSourceData
{
	[Token(Token = "0x2000014")]
	public enum MissingTranslationAction
	{
		[Token(Token = "0x4000050")]
		Empty,
		[Token(Token = "0x4000051")]
		Fallback,
		[Token(Token = "0x4000052")]
		ShowWarning,
		[Token(Token = "0x4000053")]
		ShowTerm
	}

	[Token(Token = "0x2000015")]
	public enum eAllowUnloadLanguages
	{
		[Token(Token = "0x4000055")]
		Never,
		[Token(Token = "0x4000056")]
		OnlyInDevice,
		[Token(Token = "0x4000057")]
		EditorAndDevice
	}

	[Token(Token = "0x2000016")]
	public enum eGoogleUpdateFrequency
	{
		[Token(Token = "0x4000059")]
		Always,
		[Token(Token = "0x400005A")]
		Never,
		[Token(Token = "0x400005B")]
		Daily,
		[Token(Token = "0x400005C")]
		Weekly,
		[Token(Token = "0x400005D")]
		Monthly,
		[Token(Token = "0x400005E")]
		OnlyOnce,
		[Token(Token = "0x400005F")]
		EveryOtherDay
	}

	[Token(Token = "0x2000017")]
	public enum eGoogleUpdateSynchronization
	{
		[Token(Token = "0x4000061")]
		Manual,
		[Token(Token = "0x4000062")]
		OnSceneLoaded,
		[Token(Token = "0x4000063")]
		AsSoonAsDownloaded
	}

	[Serializable]
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970B70", Offset = "0x970B70")]
	private sealed class <>c
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<UnityEngine.Object> <>9__39_0;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<UnityEngine.Object, string> <>9__39_1;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__39_2;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__39_3;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x157CEC0", Offset = "0x157CEC0", VA = "0x157CEC0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x157CEC8", Offset = "0x157CEC8", VA = "0x157CEC8")]
		internal bool <UpdateAssetDictionary>b__39_0(UnityEngine.Object x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x157CF34", Offset = "0x157CF34", VA = "0x157CF34")]
		internal string <UpdateAssetDictionary>b__39_1(UnityEngine.Object o)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x157CF50", Offset = "0x157CF50", VA = "0x157CF50")]
		internal string <UpdateAssetDictionary>b__39_2(IGrouping<string, UnityEngine.Object> g)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x157CFFC", Offset = "0x157CFFC", VA = "0x157CFFC")]
		internal UnityEngine.Object <UpdateAssetDictionary>b__39_3(IGrouping<string, UnityEngine.Object> g)
		{
			return null;
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970B80", Offset = "0x970B80")]
	private sealed class <Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LanguageSourceData <>4__this;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool JustCheck;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x157D318", Offset = "0x157D318", VA = "0x157D318", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x157D380", Offset = "0x157D380", VA = "0x157D380", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x157BAC4", Offset = "0x157BAC4", VA = "0x157BAC4")]
		[DebuggerHidden]
		public <Import_Google_Coroutine>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x157D04C", Offset = "0x157D04C", VA = "0x157D04C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x157D050", Offset = "0x157D050", VA = "0x157D050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x157D320", Offset = "0x157D320", VA = "0x157D320", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ILanguageSource owner;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool UserAgreesToHaveItOnTheScene;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool UserAgreesToHaveItInsideThePluginsFolder;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool GoogleLiveSyncIsUptoDate;

	[NonSerialized]
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool mIsGlobalSource;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<TermData> mTerms;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool CaseInsensitiveTerms;

	[NonSerialized]
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Dictionary<string, TermData> mDictionary;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MissingTranslationAction OnMissingTranslation;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string mTerm_AppName;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<LanguageData> mLanguages;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool IgnoreDeviceLanguage;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public eAllowUnloadLanguages _AllowUnloadingLanguages;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string Google_WebServiceURL;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string Google_SpreadsheetKey;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string Google_SpreadsheetName;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string Google_LastUpdatedVersion;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public eGoogleUpdateFrequency GoogleUpdateFrequency;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float GoogleUpdateDelay;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<UnityEngine.Object> Assets;

	[NonSerialized]
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Dictionary<string, UnityEngine.Object> mAssetDictionary;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string mDelayedGoogleData;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string EmptyCategory;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static char[] CategorySeparators;

	[Token(Token = "0x14000002")]
	public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1577A64", Offset = "0x1577A64", VA = "0x1577A64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970DC8", Offset = "0x970DC8")]
		add
		{
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x15781C8", Offset = "0x15781C8", VA = "0x15781C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970DD8", Offset = "0x970DD8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x15772DC", Offset = "0x15772DC", VA = "0x15772DC")]
	public void Awake()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x157737C", Offset = "0x157737C", VA = "0x157737C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1578CD8", Offset = "0x1578CD8", VA = "0x1578CD8")]
	public void ClearAllData()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1578D78", Offset = "0x1578D78", VA = "0x1578D78")]
	public void Editor_SetDirty()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1578754", Offset = "0x1578754", VA = "0x1578754")]
	public void UpdateAssetDictionary()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1578D7C", Offset = "0x1578D7C", VA = "0x1578D7C")]
	public UnityEngine.Object FindAsset(string Name)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1578E40", Offset = "0x1578E40", VA = "0x1578E40")]
	private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x15793C4", Offset = "0x15793C4", VA = "0x15793C4")]
	public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x15795CC", Offset = "0x15795CC", VA = "0x15795CC")]
	public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x157A0D4", Offset = "0x157A0D4", VA = "0x157A0D4")]
	private bool ArrayContains(string MainText, params string[] texts)
	{
		return default(bool);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x157A8C8", Offset = "0x157A8C8", VA = "0x157A8C8")]
	public static eTermType GetTermType(string type)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x157AB5C", Offset = "0x157AB5C", VA = "0x157AB5C")]
	private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x157AD90", Offset = "0x157AD90", VA = "0x157AD90")]
	public void Import_Google_FromCache()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x157B188", Offset = "0x157B188", VA = "0x157B188")]
	private bool IsNewerVersion(string currentVersion, string newVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x157B7B4", Offset = "0x157B7B4", VA = "0x157B7B4")]
	public void Import_Google(bool ForceUpdate, bool justCheck)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x157AFD8", Offset = "0x157AFD8", VA = "0x157AFD8")]
	private string GetSourcePlayerPrefName()
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x157BA34", Offset = "0x157BA34", VA = "0x157BA34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x970DE8", Offset = "0x970DE8")]
	private IEnumerator Import_Google_Coroutine(bool JustCheck)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x157BAF0", Offset = "0x157BAF0", VA = "0x157BAF0")]
	private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x157BB94", Offset = "0x157BB94", VA = "0x157BB94")]
	public void ApplyDownloadedDataFromGoogle()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x157BCD8", Offset = "0x157BCD8", VA = "0x157BCD8")]
	public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x157BE30", Offset = "0x157BE30", VA = "0x157BE30")]
	public bool HasGoogleSpreadsheet()
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x157B218", Offset = "0x157B218", VA = "0x157B218")]
	public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x157A338", Offset = "0x157A338", VA = "0x157A338")]
	public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x157C278", Offset = "0x157C278", VA = "0x157C278")]
	public bool IsCurrentLanguage(int languageIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x157A178", Offset = "0x157A178", VA = "0x157A178")]
	public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x157C0A0", Offset = "0x157C0A0", VA = "0x157C0A0")]
	public static int GetCommonWordInLanguageNames(string Language1, string Language2)
	{
		return default(int);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x157C394", Offset = "0x157C394", VA = "0x157C394")]
	public List<string> GetLanguages(bool skipDisabled = true)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x157C4C0", Offset = "0x157C4C0", VA = "0x157C4C0")]
	public bool AllowUnloadingLanguages()
	{
		return default(bool);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x157C4D0", Offset = "0x157C4D0", VA = "0x157C4D0")]
	private string GetSavedLanguageFileName(int languageIndex)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x157C6E0", Offset = "0x157C6E0", VA = "0x157C6E0")]
	public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x157C868", Offset = "0x157C868", VA = "0x157C868")]
	public void UnloadLanguage(int languageIndex)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x157AA3C", Offset = "0x157AA3C", VA = "0x157AA3C")]
	public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x157A998", Offset = "0x157A998", VA = "0x157A998")]
	public bool HasUnloadedLanguages()
	{
		return default(bool);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x157CA94", Offset = "0x157CA94", VA = "0x157CA94")]
	public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1578464", Offset = "0x1578464", VA = "0x1578464")]
	public void UpdateDictionary(bool force = false)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x157CB78", Offset = "0x157CB78", VA = "0x157CB78")]
	public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x15790D0", Offset = "0x15790D0", VA = "0x15790D0")]
	private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x157A6F4", Offset = "0x157A6F4", VA = "0x157A6F4")]
	public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x157A524", Offset = "0x157A524", VA = "0x157A524")]
	public static void ValidateFullTerm(ref string Term)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1577834", Offset = "0x1577834", VA = "0x1577834")]
	public LanguageSourceData()
	{
	}
}
[Token(Token = "0x200001A")]
public enum eSpreadsheetUpdateMode
{
	[Token(Token = "0x400006F")]
	None,
	[Token(Token = "0x4000070")]
	Replace,
	[Token(Token = "0x4000071")]
	Merge,
	[Token(Token = "0x4000072")]
	AddNewTerms
}
[Token(Token = "0x200001B")]
public class LocalizationReader
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1579408", Offset = "0x1579408", VA = "0x1579408")]
	public static List<string[]> ReadI2CSV(string Text)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x970B90", Offset = "0x970B90")]
public class Localize : MonoBehaviour
{
	[Token(Token = "0x200001D")]
	public enum TermModification
	{
		[Token(Token = "0x4000094")]
		DontModify,
		[Token(Token = "0x4000095")]
		ToUpper,
		[Token(Token = "0x4000096")]
		ToLower,
		[Token(Token = "0x4000097")]
		ToUpperFirst,
		[Token(Token = "0x4000098")]
		ToTitle
	}

	[Serializable]
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970BC8", Offset = "0x970BC8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<UnityEngine.Object> <>9__50_0;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<UnityEngine.Object, string> <>9__50_1;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__50_2;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__50_3;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1583F4C", Offset = "0x1583F4C", VA = "0x1583F4C")]
		public <>c()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1583F54", Offset = "0x1583F54", VA = "0x1583F54")]
		internal bool <UpdateAssetDictionary>b__50_0(UnityEngine.Object x)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1583FC0", Offset = "0x1583FC0", VA = "0x1583FC0")]
		internal string <UpdateAssetDictionary>b__50_1(UnityEngine.Object o)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1583FDC", Offset = "0x1583FDC", VA = "0x1583FDC")]
		internal string <UpdateAssetDictionary>b__50_2(IGrouping<string, UnityEngine.Object> g)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1584088", Offset = "0x1584088", VA = "0x1584088")]
		internal UnityEngine.Object <UpdateAssetDictionary>b__50_3(IGrouping<string, UnityEngine.Object> g)
		{
			return null;
		}
	}

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string mTerm;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string mTermSecondary;

	[NonSerialized]
	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string FinalTerm;

	[NonSerialized]
	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string FinalSecondaryTerm;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TermModification PrimaryTermModifier;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public TermModification SecondaryTermModifier;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string TermPrefix;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string TermSuffix;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool LocalizeOnAwake;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string LastLocalizedLanguage;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool IgnoreRTL;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int MaxCharactersInRTL;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool IgnoreNumbersInRTL;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool CorrectAlignmentForRTL;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool AddSpacesToJoinedLanguages;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
	public bool AllowLocalizedParameters;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool AllowParameters;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<UnityEngine.Object> TranslatedObjects;

	[NonSerialized]
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Dictionary<string, UnityEngine.Object> mAssetDictionary;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UnityEvent LocalizeEvent;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string MainTranslation;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string SecondaryTranslation;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string CallBackTerm;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string CallBackSecondaryTerm;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Localize CurrentLocalizeComponent;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool AlwaysForceLocalize;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public EventCallback LocalizeCallBack;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool mGUI_ShowReferences;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool mGUI_ShowTems;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	public bool mGUI_ShowCallback;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ILocalizeTarget mLocalizeTarget;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string mLocalizeTargetName;

	[Token(Token = "0x17000005")]
	public string Term
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1582DC0", Offset = "0x1582DC0", VA = "0x1582DC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1582DC8", Offset = "0x1582DC8", VA = "0x1582DC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public string SecondaryTerm
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1582E24", Offset = "0x1582E24", VA = "0x1582E24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1582E2C", Offset = "0x1582E2C", VA = "0x1582E2C")]
		set
		{
		}
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1582EBC", Offset = "0x1582EBC", VA = "0x1582EBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x158372C", Offset = "0x158372C", VA = "0x158372C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1583734", Offset = "0x1583734", VA = "0x1583734")]
	public bool HasCallback()
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1581208", Offset = "0x1581208", VA = "0x1581208")]
	public void OnLocalize(bool Force = false)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1583230", Offset = "0x1583230", VA = "0x1583230")]
	public bool FindTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1583784", Offset = "0x1583784", VA = "0x1583784")]
	public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1583930", Offset = "0x1583930", VA = "0x1583930")]
	public string GetMainTargetsText()
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1583A08", Offset = "0x1583A08", VA = "0x1583A08")]
	public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1582DCC", Offset = "0x1582DCC", VA = "0x1582DCC")]
	public void SetTerm(string primary)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1582E38", Offset = "0x1582E38", VA = "0x1582E38")]
	public void SetTerm(string primary, string secondary)
	{
	}

	[Token(Token = "0x600008D")]
	internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1582F00", Offset = "0x1582F00", VA = "0x1582F00")]
	public void UpdateAssetDictionary()
	{
	}

	[Token(Token = "0x600008F")]
	internal T GetObject<T>(string Translation) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1583A60", Offset = "0x1583A60", VA = "0x1583A60")]
	private void DeserializeTranslation(string translation, out string value, out string secondary)
	{
	}

	[Token(Token = "0x6000092")]
	public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1583B78", Offset = "0x1583B78", VA = "0x1583B78")]
	public bool HasTranslatedObject(UnityEngine.Object Obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1583C10", Offset = "0x1583C10", VA = "0x1583C10")]
	public void AddTranslatedObject(UnityEngine.Object Obj)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1583CB0", Offset = "0x1583CB0", VA = "0x1583CB0")]
	public void SetGlobalLanguage(string Language)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1583D14", Offset = "0x1583D14", VA = "0x1583D14")]
	public Localize()
	{
	}
}
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x970BD8", Offset = "0x970BD8")]
public class LocalizeDropdown : MonoBehaviour
{
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> _Terms;

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x15840D8", Offset = "0x15840D8", VA = "0x15840D8")]
	public void Start()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1584274", Offset = "0x1584274", VA = "0x1584274")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1584310", Offset = "0x1584310", VA = "0x1584310")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x158417C", Offset = "0x158417C", VA = "0x158417C")]
	public void OnLocalize()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1584370", Offset = "0x1584370", VA = "0x1584370")]
	private void FillValues()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1584500", Offset = "0x1584500", VA = "0x1584500")]
	public void UpdateLocalization()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x15848A8", Offset = "0x15848A8", VA = "0x15848A8")]
	public void UpdateLocalizationTMPro()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1584730", Offset = "0x1584730", VA = "0x1584730")]
	private void FillValuesTMPro()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1584ACC", Offset = "0x1584ACC", VA = "0x1584ACC")]
	public LocalizeDropdown()
	{
	}
}
[Token(Token = "0x2000020")]
public static class LocalizationManager
{
	[Token(Token = "0x2000021")]
	public delegate object _GetParam(string param);

	[Token(Token = "0x2000022")]
	public delegate void OnLocalizeCallback();

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970C10", Offset = "0x970C10")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> Languages;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<string, bool> <>9__0;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x157EC20", Offset = "0x157EC20", VA = "0x157EC20")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x15824A4", Offset = "0x15824A4", VA = "0x15824A4")]
		internal bool <GetAllLanguages>b__0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970C20", Offset = "0x970C20")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject root;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x157EE5C", Offset = "0x157EE5C", VA = "0x157EE5C")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1582518", Offset = "0x1582518", VA = "0x1582518")]
		internal object <ApplyLocalizationParams>b__0(string p)
		{
			return null;
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970C30", Offset = "0x970C30")]
	private sealed class <Delayed_Import_Google>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LanguageSourceData source;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool justCheck;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x15827E0", Offset = "0x15827E0", VA = "0x15827E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x1582848", Offset = "0x1582848", VA = "0x1582848", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x158048C", Offset = "0x158048C", VA = "0x158048C")]
		[DebuggerHidden]
		public <Delayed_Import_Google>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x158271C", Offset = "0x158271C", VA = "0x158271C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1582720", Offset = "0x1582720", VA = "0x1582720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x15827E8", Offset = "0x15827E8", VA = "0x15827E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970C40", Offset = "0x970C40")]
	private sealed class <>c__DisplayClass71_0
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILocalizeTargetDescriptor desc;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1580D08", Offset = "0x1580D08", VA = "0x1580D08")]
		public <>c__DisplayClass71_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1582590", Offset = "0x1582590", VA = "0x1582590")]
		internal bool <RegisterTarget>b__0(ILocalizeTargetDescriptor x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970C50", Offset = "0x970C50")]
	private sealed class <Coroutine_LocalizeAll>d__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x15826AC", Offset = "0x15826AC", VA = "0x15826AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1582714", Offset = "0x1582714", VA = "0x1582714", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x15811DC", Offset = "0x15811DC", VA = "0x15811DC")]
		[DebuggerHidden]
		public <Coroutine_LocalizeAll>d__86(int <>1__state)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x15825BC", Offset = "0x15825BC", VA = "0x15825BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x15825C0", Offset = "0x15825C0", VA = "0x15825C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x15826B4", Offset = "0x15826B4", VA = "0x15826B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string mCurrentLanguage;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string mLanguageCode;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static CultureInfo mCurrentCulture;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static bool mChangeCultureInfo;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public static bool IsRight2Left;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public static bool HasJoinedWords;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static List<ILocalizationParamsManager> ParamManagers;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[] LanguagesRTL;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static List<LanguageSourceData> Sources;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string[] GlobalSources;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string mCurrentDeviceLanguage;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static bool mLocalizeIsScheduled;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private static bool mLocalizeIsScheduledWithForcedValue;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public static bool HighlightLocalizedTargets;

	[Token(Token = "0x17000007")]
	public static string CurrentLanguage
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x157C328", Offset = "0x157C328", VA = "0x157C328")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x157DB00", Offset = "0x157DB00", VA = "0x157DB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public static string CurrentLanguageCode
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x157E45C", Offset = "0x157E45C", VA = "0x157E45C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000003")]
	public static event OnLocalizeCallback OnLocalizeEvent
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x156DD10", Offset = "0x156DD10", VA = "0x156DD10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970F00", Offset = "0x970F00")]
		add
		{
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x156DC20", Offset = "0x156DC20", VA = "0x156DC20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970F10", Offset = "0x970F10")]
		remove
		{
		}
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x157D388", Offset = "0x157D388", VA = "0x157D388")]
	public static void InitializeIfNeeded()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x157C098", Offset = "0x157C098", VA = "0x157C098")]
	public static int GetRequiredWebServiceVersion()
	{
		return default(int);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x157BED0", Offset = "0x157BED0", VA = "0x157BED0")]
	public static string GetWebServiceURL([Optional] LanguageSourceData source)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x157E248", Offset = "0x157E248", VA = "0x157E248")]
	public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x157E4C8", Offset = "0x157E4C8", VA = "0x157E4C8")]
	private static CultureInfo CreateCultureForCode(string code)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x156D248", Offset = "0x156D248", VA = "0x156D248")]
	public static void EnableChangingCultureInfo(bool bEnable)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x157E5CC", Offset = "0x157E5CC", VA = "0x157E5CC")]
	private static void SetCurrentCultureInfo()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x157D670", Offset = "0x157D670", VA = "0x157D670")]
	private static void SelectStartupLanguage()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x157E7A8", Offset = "0x157E7A8", VA = "0x157E7A8")]
	public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x157DBF0", Offset = "0x157DBF0", VA = "0x157DBF0")]
	public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x157E064", Offset = "0x157E064", VA = "0x157E064")]
	public static string GetLanguageCode(string Language)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x157E9B4", Offset = "0x157E9B4", VA = "0x157E9B4")]
	public static List<string> GetAllLanguages(bool SkipDisabled = true)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x157EC28", Offset = "0x157EC28", VA = "0x157EC28")]
	private static void LoadCurrentLanguage()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x157D460", Offset = "0x157D460", VA = "0x157D460")]
	public static void AutoLoadGlobalParamManagers()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x157ED74", Offset = "0x157ED74", VA = "0x157ED74")]
	public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x157EE78", Offset = "0x157EE78", VA = "0x157EE78")]
	public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x157F7AC", Offset = "0x157F7AC", VA = "0x157F7AC")]
	internal static string GetLocalizationParam(string ParamName, GameObject root)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x157FA58", Offset = "0x157FA58", VA = "0x157FA58")]
	public static string ApplyRTLfix(string line)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x157FAC4", Offset = "0x157FAC4", VA = "0x157FAC4")]
	public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x157E654", Offset = "0x157E654", VA = "0x157E654")]
	public static bool IsRTL(string Code)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x157D5E8", Offset = "0x157D5E8", VA = "0x157D5E8")]
	public static bool UpdateSources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x157FEAC", Offset = "0x157FEAC", VA = "0x157FEAC")]
	private static void UnregisterDeletededSources()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x15801A4", Offset = "0x15801A4", VA = "0x15801A4")]
	private static void RegisterSceneSources()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x157FFE8", Offset = "0x157FFE8", VA = "0x157FFE8")]
	private static void RegisterSourceInResources()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1580330", Offset = "0x1580330", VA = "0x1580330")]
	private static bool AllowSyncFromGoogle(LanguageSourceData Source)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x157826C", Offset = "0x157826C", VA = "0x157826C")]
	internal static void AddSource(LanguageSourceData Source)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x15803EC", Offset = "0x15803EC", VA = "0x15803EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x970E9C", Offset = "0x970E9C")]
	private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1578C54", Offset = "0x1578C54", VA = "0x1578C54")]
	internal static void RemoveSource(LanguageSourceData Source)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x15804B8", Offset = "0x15804B8", VA = "0x15804B8")]
	public static UnityEngine.Object FindAsset(string value)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x157E6DC", Offset = "0x157E6DC", VA = "0x157E6DC")]
	public static string GetCurrentDeviceLanguage(bool force = false)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x15805F8", Offset = "0x15805F8", VA = "0x15805F8")]
	private static void DetectDeviceLanguage()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1580AC4", Offset = "0x1580AC4", VA = "0x1580AC4")]
	public static void RegisterTarget(ILocalizeTargetDescriptor desc)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1580D10", Offset = "0x1580D10", VA = "0x1580D10")]
	public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1580DE4", Offset = "0x1580DE4", VA = "0x1580DE4")]
	public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1578B50", Offset = "0x1578B50", VA = "0x1578B50")]
	public static void LocalizeAll(bool Force = false)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x158117C", Offset = "0x158117C", VA = "0x158117C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x970F20", Offset = "0x970F20")]
	private static IEnumerator Coroutine_LocalizeAll()
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1581008", Offset = "0x1581008", VA = "0x1581008")]
	private static void DoLocalizeAll(bool Force = false)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x157F628", Offset = "0x157F628", VA = "0x157F628")]
	public static TermData GetTermData(string term, out LanguageSourceData source)
	{
		return null;
	}
}
[Token(Token = "0x2000028")]
public abstract class ILocalizeTarget : ScriptableObject
{
	[Token(Token = "0x60000EC")]
	public abstract bool IsValid(Localize cmp);

	[Token(Token = "0x60000ED")]
	public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

	[Token(Token = "0x60000EE")]
	public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

	[Token(Token = "0x60000EF")]
	public abstract bool CanUseSecondaryTerm();

	[Token(Token = "0x60000F0")]
	public abstract bool AllowMainTermToBeRTL();

	[Token(Token = "0x60000F1")]
	public abstract bool AllowSecondTermToBeRTL();

	[Token(Token = "0x60000F2")]
	public abstract eTermType GetPrimaryTermType(Localize cmp);

	[Token(Token = "0x60000F3")]
	public abstract eTermType GetSecondaryTermType(Localize cmp);

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x15770E4", Offset = "0x15770E4", VA = "0x15770E4")]
	protected ILocalizeTarget()
	{
	}
}
[Token(Token = "0x2000029")]
public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T mTarget;

	[Token(Token = "0x60000F5")]
	public override bool IsValid(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F6")]
	protected LocalizeTarget()
	{
	}
}
[Token(Token = "0x200002A")]
public abstract class ILocalizeTargetDescriptor
{
	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int Priority;

	[Token(Token = "0x60000F7")]
	public abstract bool CanLocalize(Localize cmp);

	[Token(Token = "0x60000F8")]
	public abstract ILocalizeTarget CreateTarget(Localize cmp);

	[Token(Token = "0x60000F9")]
	public abstract Type GetTargetType();

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x15770EC", Offset = "0x15770EC", VA = "0x15770EC")]
	protected ILocalizeTargetDescriptor()
	{
	}
}
[Token(Token = "0x200002B")]
public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
{
	[Token(Token = "0x60000FB")]
	public override ILocalizeTarget CreateTarget(Localize cmp)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	public override Type GetTargetType()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	protected LocalizeTargetDesc()
	{
	}
}
[Token(Token = "0x200002C")]
public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
{
	[Token(Token = "0x60000FE")]
	public override bool CanLocalize(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FF")]
	public override ILocalizeTarget CreateTarget(Localize cmp)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	public LocalizeTargetDesc_Type()
	{
	}
}
[Token(Token = "0x200002D")]
public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextAlignmentOptions mAlignment_RTL;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private TextAlignmentOptions mAlignment_LTR;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool mAlignmentWasRTL;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool mInitializeAlignment;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1AEE1C0", Offset = "0x1AEE1C0", VA = "0x1AEE1C0")]
	static LocalizeTarget_TextMeshPro_Label()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1AEE1C4", Offset = "0x1AEE1C4", VA = "0x1AEE1C4")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x971024", Offset = "0x971024")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1AEE278", Offset = "0x1AEE278", VA = "0x1AEE278", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1AEE280", Offset = "0x1AEE280", VA = "0x1AEE280", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1AEE288", Offset = "0x1AEE288", VA = "0x1AEE288", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1AEE290", Offset = "0x1AEE290", VA = "0x1AEE290", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1AEE298", Offset = "0x1AEE298", VA = "0x1AEE298", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1AEE2A0", Offset = "0x1AEE2A0", VA = "0x1AEE2A0", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1AEE3C4", Offset = "0x1AEE3C4", VA = "0x1AEE3C4", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1AEE9DC", Offset = "0x1AEE9DC", VA = "0x1AEE9DC")]
	internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1AEEC6C", Offset = "0x1AEEC6C", VA = "0x1AEEC6C")]
	internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1AEE8D4", Offset = "0x1AEE8D4", VA = "0x1AEE8D4")]
	internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1AEEB44", Offset = "0x1AEEB44", VA = "0x1AEEB44")]
	internal static void SetMaterial(TMP_Text label, Material newMat)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1AEEE80", Offset = "0x1AEEE80", VA = "0x1AEEE80")]
	public LocalizeTarget_TextMeshPro_Label()
	{
	}
}
[Token(Token = "0x200002E")]
public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextAlignmentOptions mAlignment_RTL;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public TextAlignmentOptions mAlignment_LTR;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool mAlignmentWasRTL;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool mInitializeAlignment;

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1AEEEE4", Offset = "0x1AEEEE4", VA = "0x1AEEEE4")]
	static LocalizeTarget_TextMeshPro_UGUI()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1AEEEE8", Offset = "0x1AEEEE8", VA = "0x1AEEEE8")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x971038", Offset = "0x971038")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1AEEF9C", Offset = "0x1AEEF9C", VA = "0x1AEEF9C", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1AEEFA4", Offset = "0x1AEEFA4", VA = "0x1AEEFA4", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1AEEFAC", Offset = "0x1AEEFAC", VA = "0x1AEEFAC", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1AEEFB4", Offset = "0x1AEEFB4", VA = "0x1AEEFB4", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1AEEFBC", Offset = "0x1AEEFBC", VA = "0x1AEEFBC", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1AEEFC4", Offset = "0x1AEEFC4", VA = "0x1AEEFC4", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1AEF0E8", Offset = "0x1AEF0E8", VA = "0x1AEF0E8", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1AEF5F8", Offset = "0x1AEF5F8", VA = "0x1AEF5F8")]
	public LocalizeTarget_TextMeshPro_UGUI()
	{
	}
}
[Token(Token = "0x200002F")]
public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
{
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1AEF65C", Offset = "0x1AEF65C", VA = "0x1AEF65C")]
	static LocalizeTarget_UnityStandard_AudioSource()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1AEF660", Offset = "0x1AEF660", VA = "0x1AEF660")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x97104C", Offset = "0x97104C")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1AEF714", Offset = "0x1AEF714", VA = "0x1AEF714", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1AEF71C", Offset = "0x1AEF71C", VA = "0x1AEF71C", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1AEF724", Offset = "0x1AEF724", VA = "0x1AEF724", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1AEF72C", Offset = "0x1AEF72C", VA = "0x1AEF72C", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1AEF734", Offset = "0x1AEF734", VA = "0x1AEF734", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1AEF73C", Offset = "0x1AEF73C", VA = "0x1AEF73C", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1AEF81C", Offset = "0x1AEF81C", VA = "0x1AEF81C", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1AEF998", Offset = "0x1AEF998", VA = "0x1AEF998")]
	public LocalizeTarget_UnityStandard_AudioSource()
	{
	}
}
[Token(Token = "0x2000030")]
public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
{
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1AEE0E0", Offset = "0x1AEE0E0", VA = "0x1AEE0E0", Slot = "4")]
	public override bool CanLocalize(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1AEE118", Offset = "0x1AEE118", VA = "0x1AEE118")]
	public LocalizeTargetDesc_Child()
	{
	}
}
[Token(Token = "0x2000031")]
public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
{
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1AEF9E8", Offset = "0x1AEF9E8", VA = "0x1AEF9E8")]
	static LocalizeTarget_UnityStandard_Child()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1AEF9EC", Offset = "0x1AEF9EC", VA = "0x1AEF9EC")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x971060", Offset = "0x971060")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1AEFA94", Offset = "0x1AEFA94", VA = "0x1AEFA94", Slot = "4")]
	public override bool IsValid(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1AEFACC", Offset = "0x1AEFACC", VA = "0x1AEFACC", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1AEFAD4", Offset = "0x1AEFAD4", VA = "0x1AEFAD4", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1AEFADC", Offset = "0x1AEFADC", VA = "0x1AEFADC", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1AEFAE4", Offset = "0x1AEFAE4", VA = "0x1AEFAE4", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1AEFAEC", Offset = "0x1AEFAEC", VA = "0x1AEFAEC", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1AEFAF4", Offset = "0x1AEFAF4", VA = "0x1AEFAF4", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1AEFB44", Offset = "0x1AEFB44", VA = "0x1AEFB44", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1AEFC9C", Offset = "0x1AEFC9C", VA = "0x1AEFC9C")]
	public LocalizeTarget_UnityStandard_Child()
	{
	}
}
[Token(Token = "0x2000032")]
public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
{
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1AEFCEC", Offset = "0x1AEFCEC", VA = "0x1AEFCEC")]
	static LocalizeTarget_UnityStandard_MeshRenderer()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1AEFCF0", Offset = "0x1AEFCF0", VA = "0x1AEFCF0")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x971074", Offset = "0x971074")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1AEFDA4", Offset = "0x1AEFDA4", VA = "0x1AEFDA4", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1AEFDAC", Offset = "0x1AEFDAC", VA = "0x1AEFDAC", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1AEFDB4", Offset = "0x1AEFDB4", VA = "0x1AEFDB4", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1AEFDBC", Offset = "0x1AEFDBC", VA = "0x1AEFDBC", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1AEFDC4", Offset = "0x1AEFDC4", VA = "0x1AEFDC4", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1AEFDCC", Offset = "0x1AEFDCC", VA = "0x1AEFDCC", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1AEFFE8", Offset = "0x1AEFFE8", VA = "0x1AEFFE8", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1AF01C0", Offset = "0x1AF01C0", VA = "0x1AF01C0")]
	public LocalizeTarget_UnityStandard_MeshRenderer()
	{
	}
}
[Token(Token = "0x2000033")]
public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
{
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1AEE168", Offset = "0x1AEE168", VA = "0x1AEE168", Slot = "4")]
	public override bool CanLocalize(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1AEE170", Offset = "0x1AEE170", VA = "0x1AEE170")]
	public LocalizeTargetDesc_Prefab()
	{
	}
}
[Token(Token = "0x2000034")]
public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
{
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1AF0210", Offset = "0x1AF0210", VA = "0x1AF0210")]
	static LocalizeTarget_UnityStandard_Prefab()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1AF0214", Offset = "0x1AF0214", VA = "0x1AF0214")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x971088", Offset = "0x971088")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1AF02BC", Offset = "0x1AF02BC", VA = "0x1AF02BC", Slot = "4")]
	public override bool IsValid(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1AF02C4", Offset = "0x1AF02C4", VA = "0x1AF02C4", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1AF02CC", Offset = "0x1AF02CC", VA = "0x1AF02CC", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1AF02D4", Offset = "0x1AF02D4", VA = "0x1AF02D4", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1AF02DC", Offset = "0x1AF02DC", VA = "0x1AF02DC", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1AF02E4", Offset = "0x1AF02E4", VA = "0x1AF02E4", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1AF02EC", Offset = "0x1AF02EC", VA = "0x1AF02EC", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1AF033C", Offset = "0x1AF033C", VA = "0x1AF033C", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1AF0564", Offset = "0x1AF0564", VA = "0x1AF0564")]
	private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1AF0720", Offset = "0x1AF0720", VA = "0x1AF0720")]
	public LocalizeTarget_UnityStandard_Prefab()
	{
	}
}
[Token(Token = "0x2000035")]
public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
{
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1AF0770", Offset = "0x1AF0770", VA = "0x1AF0770")]
	static LocalizeTarget_UnityStandard_SpriteRenderer()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1AF0774", Offset = "0x1AF0774", VA = "0x1AF0774")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x97109C", Offset = "0x97109C")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1AF0828", Offset = "0x1AF0828", VA = "0x1AF0828", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1AF0830", Offset = "0x1AF0830", VA = "0x1AF0830", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1AF0838", Offset = "0x1AF0838", VA = "0x1AF0838", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1AF0840", Offset = "0x1AF0840", VA = "0x1AF0840", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1AF0848", Offset = "0x1AF0848", VA = "0x1AF0848", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1AF0850", Offset = "0x1AF0850", VA = "0x1AF0850", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1AF0934", Offset = "0x1AF0934", VA = "0x1AF0934", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1AF0A34", Offset = "0x1AF0A34", VA = "0x1AF0A34")]
	public LocalizeTarget_UnityStandard_SpriteRenderer()
	{
	}
}
[Token(Token = "0x2000036")]
public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
{
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextAlignment mAlignment_RTL;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private TextAlignment mAlignment_LTR;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool mAlignmentWasRTL;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool mInitializeAlignment;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1AF0A84", Offset = "0x1AF0A84", VA = "0x1AF0A84")]
	static LocalizeTarget_UnityStandard_TextMesh()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1AF0A88", Offset = "0x1AF0A88", VA = "0x1AF0A88")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9710B0", Offset = "0x9710B0")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1AF0B3C", Offset = "0x1AF0B3C", VA = "0x1AF0B3C", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1AF0B44", Offset = "0x1AF0B44", VA = "0x1AF0B44", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1AF0B4C", Offset = "0x1AF0B4C", VA = "0x1AF0B4C", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1AF0B54", Offset = "0x1AF0B54", VA = "0x1AF0B54", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1AF0B5C", Offset = "0x1AF0B5C", VA = "0x1AF0B5C", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1AF0B64", Offset = "0x1AF0B64", VA = "0x1AF0B64", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1AF0CA0", Offset = "0x1AF0CA0", VA = "0x1AF0CA0", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1AF0F5C", Offset = "0x1AF0F5C", VA = "0x1AF0F5C")]
	public LocalizeTarget_UnityStandard_TextMesh()
	{
	}
}
[Token(Token = "0x2000037")]
public class LocalizeTarget_UnityStandard_VideoPlayer : LocalizeTarget<VideoPlayer>
{
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1AF0FBC", Offset = "0x1AF0FBC", VA = "0x1AF0FBC")]
	static LocalizeTarget_UnityStandard_VideoPlayer()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1AF0FC0", Offset = "0x1AF0FC0", VA = "0x1AF0FC0")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9710C4", Offset = "0x9710C4")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1AF1074", Offset = "0x1AF1074", VA = "0x1AF1074", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1AF107C", Offset = "0x1AF107C", VA = "0x1AF107C", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1AF1084", Offset = "0x1AF1084", VA = "0x1AF1084", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1AF108C", Offset = "0x1AF108C", VA = "0x1AF108C", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1AF1094", Offset = "0x1AF1094", VA = "0x1AF1094", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1AF109C", Offset = "0x1AF109C", VA = "0x1AF109C", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1AF1180", Offset = "0x1AF1180", VA = "0x1AF1180", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1AF1280", Offset = "0x1AF1280", VA = "0x1AF1280")]
	public LocalizeTarget_UnityStandard_VideoPlayer()
	{
	}
}
[Token(Token = "0x2000038")]
public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
{
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1AF12D0", Offset = "0x1AF12D0", VA = "0x1AF12D0")]
	static LocalizeTarget_UnityUI_Image()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1AF12D4", Offset = "0x1AF12D4", VA = "0x1AF12D4")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9710D8", Offset = "0x9710D8")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1AF1388", Offset = "0x1AF1388", VA = "0x1AF1388", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1AF1390", Offset = "0x1AF1390", VA = "0x1AF1390", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1AF1398", Offset = "0x1AF1398", VA = "0x1AF1398", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1AF13A0", Offset = "0x1AF13A0", VA = "0x1AF13A0", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1AF1430", Offset = "0x1AF1430", VA = "0x1AF1430", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1AF1438", Offset = "0x1AF1438", VA = "0x1AF1438", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1AF15DC", Offset = "0x1AF15DC", VA = "0x1AF15DC", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1AF16D0", Offset = "0x1AF16D0", VA = "0x1AF16D0")]
	public LocalizeTarget_UnityUI_Image()
	{
	}
}
[Token(Token = "0x2000039")]
public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
{
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1AF1720", Offset = "0x1AF1720", VA = "0x1AF1720")]
	static LocalizeTarget_UnityUI_RawImage()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1AF1724", Offset = "0x1AF1724", VA = "0x1AF1724")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9710EC", Offset = "0x9710EC")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1AF17D8", Offset = "0x1AF17D8", VA = "0x1AF17D8", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1AF17E0", Offset = "0x1AF17E0", VA = "0x1AF17E0", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1AF17E8", Offset = "0x1AF17E8", VA = "0x1AF17E8", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1AF17F0", Offset = "0x1AF17F0", VA = "0x1AF17F0", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1AF17F8", Offset = "0x1AF17F8", VA = "0x1AF17F8", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1AF1800", Offset = "0x1AF1800", VA = "0x1AF1800", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1AF18F4", Offset = "0x1AF18F4", VA = "0x1AF18F4", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1AF19E8", Offset = "0x1AF19E8", VA = "0x1AF19E8")]
	public LocalizeTarget_UnityUI_RawImage()
	{
	}
}
[Token(Token = "0x200003A")]
public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
{
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextAnchor mAlignment_RTL;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private TextAnchor mAlignment_LTR;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool mAlignmentWasRTL;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool mInitializeAlignment;

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1AF1A38", Offset = "0x1AF1A38", VA = "0x1AF1A38")]
	static LocalizeTarget_UnityUI_Text()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1AF1A3C", Offset = "0x1AF1A3C", VA = "0x1AF1A3C")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x971100", Offset = "0x971100")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1AF1AF0", Offset = "0x1AF1AF0", VA = "0x1AF1AF0", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1AF1AF8", Offset = "0x1AF1AF8", VA = "0x1AF1AF8", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1AF1B00", Offset = "0x1AF1B00", VA = "0x1AF1B00", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1AF1B08", Offset = "0x1AF1B08", VA = "0x1AF1B08", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1AF1B10", Offset = "0x1AF1B10", VA = "0x1AF1B10", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1AF1B18", Offset = "0x1AF1B18", VA = "0x1AF1B18", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1AF1C58", Offset = "0x1AF1C58", VA = "0x1AF1C58", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1AF1F3C", Offset = "0x1AF1F3C", VA = "0x1AF1F3C")]
	private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1AF1FFC", Offset = "0x1AF1FFC", VA = "0x1AF1FFC")]
	public LocalizeTarget_UnityUI_Text()
	{
	}
}
[Token(Token = "0x200003B")]
public enum eTermType
{
	[Token(Token = "0x40000CF")]
	Text,
	[Token(Token = "0x40000D0")]
	Font,
	[Token(Token = "0x40000D1")]
	Texture,
	[Token(Token = "0x40000D2")]
	AudioClip,
	[Token(Token = "0x40000D3")]
	GameObject,
	[Token(Token = "0x40000D4")]
	Sprite,
	[Token(Token = "0x40000D5")]
	Material,
	[Token(Token = "0x40000D6")]
	Child,
	[Token(Token = "0x40000D7")]
	Mesh,
	[Token(Token = "0x40000D8")]
	TextMeshPFont,
	[Token(Token = "0x40000D9")]
	Object,
	[Token(Token = "0x40000DA")]
	Video
}
[Serializable]
[Token(Token = "0x200003C")]
public class TermData
{
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string Term;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public eTermType TermType;

	[NonSerialized]
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Description;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string[] Languages;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] Flags;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string[] Languages_Touch;

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1AF6638", Offset = "0x1AF6638", VA = "0x1AF6638")]
	public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1AF6748", Offset = "0x1AF6748", VA = "0x1AF6748")]
	public void SetTranslation(int idx, string translation, [Optional] string specialization)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1AF6840", Offset = "0x1AF6840", VA = "0x1AF6840")]
	public void Validate()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1AF6A90", Offset = "0x1AF6A90", VA = "0x1AF6A90")]
	public bool IsTerm(string name, bool allowCategoryMistmatch)
	{
		return default(bool);
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1AF6B28", Offset = "0x1AF6B28", VA = "0x1AF6B28")]
	public TermData()
	{
	}
}
[Token(Token = "0x200003D")]
public class AutoChangeCultureInfo : MonoBehaviour
{
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x156D1E8", Offset = "0x156D1E8", VA = "0x156D1E8")]
	public void Start()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x156D2FC", Offset = "0x156D2FC", VA = "0x156D2FC")]
	public AutoChangeCultureInfo()
	{
	}
}
[Token(Token = "0x200003E")]
public class CoroutineManager : MonoBehaviour
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CoroutineManager mInstance;

	[Token(Token = "0x1700000D")]
	private static CoroutineManager pInstance
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x156D938", Offset = "0x156D938", VA = "0x156D938")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x156DA6C", Offset = "0x156DA6C", VA = "0x156DA6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x156DB00", Offset = "0x156DB00", VA = "0x156DB00")]
	public static Coroutine Start(IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x156DB30", Offset = "0x156DB30", VA = "0x156DB30")]
	public CoroutineManager()
	{
	}
}
[Token(Token = "0x200003F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x970C60", Offset = "0x970C60")]
public class CustomLocalizeCallback : MonoBehaviour
{
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent _OnLocalize;

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x156DB38", Offset = "0x156DB38", VA = "0x156DB38")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x156DE00", Offset = "0x156DE00", VA = "0x156DE00")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x156DE9C", Offset = "0x156DE9C", VA = "0x156DE9C")]
	public void OnLocalize()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x156DEB8", Offset = "0x156DEB8", VA = "0x156DEB8")]
	public CustomLocalizeCallback()
	{
	}
}
[Token(Token = "0x2000040")]
public class HindiFixer
{
	[Serializable]
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970C98", Offset = "0x970C98")]
	private sealed class <>c
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<char, bool> <>9__0_0;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x15755F8", Offset = "0x15755F8", VA = "0x15755F8")]
		public <>c()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1575600", Offset = "0x1575600", VA = "0x1575600")]
		internal bool <Fix>b__0_0(char x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1575138", Offset = "0x1575138", VA = "0x1575138")]
	internal static string Fix(string text)
	{
		return null;
	}
}
[Token(Token = "0x2000042")]
public static class I2Utils
{
	[Serializable]
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x970CB8", Offset = "0x970CB8")]
	private sealed class <>c
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<char, bool> <>9__6_0;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x15770D0", Offset = "0x15770D0", VA = "0x15770D0")]
		public <>c()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x15770D8", Offset = "0x15770D8", VA = "0x15770D8")]
		internal bool <SplitLine>b__6_0(char c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x157686C", Offset = "0x157686C", VA = "0x157686C")]
	public static string ReverseText(string source)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1576944", Offset = "0x1576944", VA = "0x1576944")]
	public static string RemoveNonASCII(string text, bool allowCategory = false)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1576B6C", Offset = "0x1576B6C", VA = "0x1576B6C")]
	public static string GetValidTermName(string text, bool allowCategory = false)
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1576C18", Offset = "0x1576C18", VA = "0x1576C18")]
	public static string SplitLine(string line, int maxCharacters)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1576EC0", Offset = "0x1576EC0", VA = "0x1576EC0")]
	public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
	{
		return default(bool);
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1576B98", Offset = "0x1576B98", VA = "0x1576B98")]
	public static string RemoveTags(string text)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1577048", Offset = "0x1577048", VA = "0x1577048")]
	public static bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1577050", Offset = "0x1577050", VA = "0x1577050")]
	public static void SendWebRequest(UnityWebRequest www)
	{
	}
}
[Token(Token = "0x2000044")]
public interface ILocalizationParamsManager
{
	[Token(Token = "0x60001A3")]
	string GetParameterValue(string Param);
}
[Token(Token = "0x2000045")]
public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
{
	[Serializable]
	[Token(Token = "0x2000046")]
	public struct ParamValue
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Name;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Value;
	}

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ParamValue> _Params;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool _IsGlobalManager;

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x15828B8", Offset = "0x15828B8", VA = "0x15828B8", Slot = "4")]
	public string GetParameterValue(string ParamName)
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x15829A4", Offset = "0x15829A4", VA = "0x15829A4")]
	public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1582B2C", Offset = "0x1582B2C", VA = "0x1582B2C")]
	public void OnLocalize()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1582BD8", Offset = "0x1582BD8", VA = "0x1582BD8", Slot = "5")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1582BE8", Offset = "0x1582BE8", VA = "0x1582BE8")]
	public void DoAutoRegister()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1582CC0", Offset = "0x1582CC0", VA = "0x1582CC0")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1582D44", Offset = "0x1582D44", VA = "0x1582D44")]
	public LocalizationParamsManager()
	{
	}
}
[Token(Token = "0x2000047")]
public class RTLFixer
{
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1AF2798", Offset = "0x1AF2798", VA = "0x1AF2798")]
	public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
internal class ArabicMapping
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int from;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int to;

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x156C534", Offset = "0x156C534", VA = "0x156C534")]
	public ArabicMapping(int from, int to)
	{
	}
}
[Token(Token = "0x2000049")]
internal class ArabicTable
{
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<ArabicMapping> mapList;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ArabicTable arabicMapper;

	[Token(Token = "0x1700000E")]
	internal static ArabicTable ArabicMapper
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x156D058", Offset = "0x156D058", VA = "0x156D058")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x156C56C", Offset = "0x156C56C", VA = "0x156C56C")]
	private ArabicTable()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x156D0DC", Offset = "0x156D0DC", VA = "0x156D0DC")]
	internal int Convert(int toBeConverted)
	{
		return default(int);
	}
}
[Token(Token = "0x200004A")]
internal class TashkeelLocation
{
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public char tashkeel;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int position;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1AF3CEC", Offset = "0x1AF3CEC", VA = "0x1AF3CEC")]
	public TashkeelLocation(char tashkeel, int position)
	{
	}
}
[Token(Token = "0x200004B")]
internal class RTLFixerTool
{
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static bool showTashkeel;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	internal static bool useHinduNumbers;

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1AF3744", Offset = "0x1AF3744", VA = "0x1AF3744")]
	internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1AF3D28", Offset = "0x1AF3D28", VA = "0x1AF3D28")]
	internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1AF2A38", Offset = "0x1AF2A38", VA = "0x1AF2A38")]
	internal static string FixLine(string str)
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1AF3F24", Offset = "0x1AF3F24", VA = "0x1AF3F24")]
	internal static bool IsIgnoredCharacter(char ch)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1AF4584", Offset = "0x1AF4584", VA = "0x1AF4584")]
	internal static bool IsLeadingLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1AF4420", Offset = "0x1AF4420", VA = "0x1AF4420")]
	internal static bool IsFinishingLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1AF40A0", Offset = "0x1AF40A0", VA = "0x1AF40A0")]
	internal static bool IsMiddleLetter(char[] letters, int index)
	{
		return default(bool);
	}
}
[Token(Token = "0x200004C")]
public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
{
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1AF4914", Offset = "0x1AF4914", VA = "0x1AF4914")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1AF49BC", Offset = "0x1AF49BC", VA = "0x1AF49BC")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1AF4A64", Offset = "0x1AF4A64", VA = "0x1AF4A64")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1AF4AD0", Offset = "0x1AF4AD0", VA = "0x1AF4AD0", Slot = "4")]
	public virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1AF4AD8", Offset = "0x1AF4AD8", VA = "0x1AF4AD8")]
	public RegisterCallback_AllowSyncFromGoogle()
	{
	}
}
[Token(Token = "0x200004D")]
public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
{
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1AF4AE0", Offset = "0x1AF4AE0", VA = "0x1AF4AE0", Slot = "5")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1AF4BBC", Offset = "0x1AF4BBC", VA = "0x1AF4BBC", Slot = "6")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1AF4C40", Offset = "0x1AF4C40", VA = "0x1AF4C40", Slot = "7")]
	public virtual string GetParameterValue(string ParamName)
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1AF4C48", Offset = "0x1AF4C48", VA = "0x1AF4C48")]
	public RegisterGlobalParameters()
	{
	}
}
[Token(Token = "0x200004E")]
public interface IResourceManager_Bundles
{
	[Token(Token = "0x60001C2")]
	UnityEngine.Object LoadFromBundle(string path, Type assetType);
}
[Token(Token = "0x200004F")]
public class ResourceManager : MonoBehaviour
{
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ResourceManager mInstance;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<IResourceManager_Bundles> mBundleManagers;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEngine.Object[] Assets;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;

	[Token(Token = "0x1700000F")]
	public static ResourceManager pInstance
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1AF4C50", Offset = "0x1AF4C50", VA = "0x1AF4C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1AF4FD4", Offset = "0x1AF4FD4", VA = "0x1AF4FD4")]
	public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60001C5")]
	public T GetAsset<T>(string Name) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1AF50C4", Offset = "0x1AF50C4", VA = "0x1AF50C4")]
	private UnityEngine.Object FindAsset(string Name)
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1AF5204", Offset = "0x1AF5204", VA = "0x1AF5204")]
	public bool HasAsset(UnityEngine.Object Obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C8")]
	public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1AF5048", Offset = "0x1AF5048", VA = "0x1AF5048")]
	public void CleanResourceCache(bool unloadResources = false)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1AF5274", Offset = "0x1AF5274", VA = "0x1AF5274")]
	public ResourceManager()
	{
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x970CC8", Offset = "0x970CC8")]
public class SetLanguage : MonoBehaviour
{
	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string _Language;

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1AF5398", Offset = "0x1AF5398", VA = "0x1AF5398")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1AF539C", Offset = "0x1AF539C", VA = "0x1AF539C")]
	public void ApplyLanguage()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1AF5458", Offset = "0x1AF5458", VA = "0x1AF5458")]
	public SetLanguage()
	{
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x970D00", Offset = "0x970D00")]
public class SetLanguageDropdown : MonoBehaviour
{
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1AF5460", Offset = "0x1AF5460", VA = "0x1AF5460")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1AF568C", Offset = "0x1AF568C", VA = "0x1AF568C")]
	private void OnValueChanged(int index)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1AF577C", Offset = "0x1AF577C", VA = "0x1AF577C")]
	public SetLanguageDropdown()
	{
	}
}
[Token(Token = "0x2000052")]
public class StringObfucator
{
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static char[] StringObfuscatorPassword;

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x1AF6100", Offset = "0x1AF6100", VA = "0x1AF6100")]
	public static string Encode(string NormalString)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1AF6440", Offset = "0x1AF6440", VA = "0x1AF6440")]
	public static string Decode(string ObfucatedString)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1AF63AC", Offset = "0x1AF63AC", VA = "0x1AF63AC")]
	private static string ToBase64(string regularString)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1AF6528", Offset = "0x1AF6528", VA = "0x1AF6528")]
	private static string FromBase64(string base64string)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1AF61E8", Offset = "0x1AF61E8", VA = "0x1AF61E8")]
	private static string XoREncode(string NormalString)
	{
		return null;
	}
}
