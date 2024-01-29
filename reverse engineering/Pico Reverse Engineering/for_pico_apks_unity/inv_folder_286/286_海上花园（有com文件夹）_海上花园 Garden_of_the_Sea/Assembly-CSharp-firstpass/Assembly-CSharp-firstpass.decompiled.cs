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
	[Address(RVA = "0x1E25F88", Offset = "0x1E25F88", VA = "0x1E25F88")]
	public static void SetSetting_String(string key, string value)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1E26040", Offset = "0x1E26040", VA = "0x1E26040")]
	public static string GetSetting_String(string key, string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1E260F8", Offset = "0x1E260F8", VA = "0x1E260F8")]
	public static void DeleteSetting(string key)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1E261A8", Offset = "0x1E261A8", VA = "0x1E261A8")]
	public static bool HasSetting(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1E26258", Offset = "0x1E26258", VA = "0x1E26258")]
	public static void ForceSaveSettings()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1E262F8", Offset = "0x1E262F8", VA = "0x1E262F8")]
	public static bool CanAccessFiles()
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1E26398", Offset = "0x1E26398", VA = "0x1E26398")]
	public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1E26468", Offset = "0x1E26468", VA = "0x1E26468")]
	public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1E26530", Offset = "0x1E26530", VA = "0x1E26530")]
	public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1E265F8", Offset = "0x1E265F8", VA = "0x1E265F8")]
	public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000004")]
public abstract class I2BasePersistentStorage
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1EAF75C", Offset = "0x1EAF75C", VA = "0x1EAF75C", Slot = "4")]
	public virtual void SetSetting_String(string key, string value)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1EAFA1C", Offset = "0x1EAFA1C", VA = "0x1EAFA1C", Slot = "5")]
	public virtual string GetSetting_String(string key, string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1EAFC8C", Offset = "0x1EAFC8C", VA = "0x1EAFC8C", Slot = "6")]
	public virtual void DeleteSetting(string key)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1EAFEC4", Offset = "0x1EAFEC4", VA = "0x1EAFEC4", Slot = "7")]
	public virtual void ForceSaveSettings()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1EAFECC", Offset = "0x1EAFECC", VA = "0x1EAFECC", Slot = "8")]
	public virtual bool HasSetting(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1EAFED8", Offset = "0x1EAFED8", VA = "0x1EAFED8", Slot = "9")]
	public virtual bool CanAccessFiles()
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1EAFEE0", Offset = "0x1EAFEE0", VA = "0x1EAFEE0")]
	private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1EAFF8C", Offset = "0x1EAFF8C", VA = "0x1EAFF8C", Slot = "10")]
	public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1EB0228", Offset = "0x1EB0228", VA = "0x1EB0228", Slot = "11")]
	public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1EB04B4", Offset = "0x1EB04B4", VA = "0x1EB04B4", Slot = "12")]
	public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1EB0730", Offset = "0x1EB0730", VA = "0x1EB0730", Slot = "13")]
	public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1EB09AC", Offset = "0x1EB09AC", VA = "0x1EB09AC")]
	protected I2BasePersistentStorage()
	{
	}
}
[Token(Token = "0x2000005")]
public class I2CustomPersistentStorage : I2BasePersistentStorage
{
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1EB09B4", Offset = "0x1EB09B4", VA = "0x1EB09B4")]
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
	[Address(RVA = "0x1EA7454", Offset = "0x1EA7454", VA = "0x1EA7454", Slot = "4")]
	public virtual void InitializeSpecializations()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1EA7978", Offset = "0x1EA7978", VA = "0x1EA7978", Slot = "5")]
	public virtual string GetCurrentSpecialization()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1EA79DC", Offset = "0x1EA79DC", VA = "0x1EA79DC", Slot = "6")]
	public virtual string GetFallbackSpecialization(string specialization)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1EA7A80", Offset = "0x1EA7A80", VA = "0x1EA7A80")]
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
	[Address(RVA = "0x1E296B0", Offset = "0x1E296B0", VA = "0x1E296B0")]
	private SpecializationManager()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1E296E0", Offset = "0x1E296E0", VA = "0x1E296E0")]
	public static string GetSpecializedText(string text, [Optional] string specialization)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1E298D4", Offset = "0x1E298D4", VA = "0x1E298D4")]
	public static string SetSpecializedText(string text, string newText, string specialization)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1E29C2C", Offset = "0x1E29C2C", VA = "0x1E29C2C")]
	public static string SetSpecializedText(Dictionary<string, string> specializations)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1E299E0", Offset = "0x1E299E0", VA = "0x1E299E0")]
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
	[Address(RVA = "0x1EA807C", Offset = "0x1EA807C", VA = "0x1EA807C")]
	public void Execute([Optional] UnityEngine.Object Sender)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1EA80E4", Offset = "0x1EA80E4", VA = "0x1EA80E4")]
	public bool HasCallback()
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1EA8178", Offset = "0x1EA8178", VA = "0x1EA8178")]
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
	[Address(RVA = "0x1EA81E0", Offset = "0x1EA81E0", VA = "0x1EA81E0")]
	public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1EA8424", Offset = "0x1EA8424", VA = "0x1EA8424")]
	private static bool LanguageMatchesFilter(string Language, string[] Filters)
	{
		return default(bool);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1EA8580", Offset = "0x1EA8580", VA = "0x1EA8580")]
	public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1EA86F8", Offset = "0x1EA86F8", VA = "0x1EA86F8")]
	public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1EA897C", Offset = "0x1EA897C", VA = "0x1EA897C")]
	public static bool LanguageCode_HasJoinedWord(string languageCode)
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1EA8AE8", Offset = "0x1EA8AE8", VA = "0x1EA8AE8")]
	private static int GetPluralRule(string langCode)
	{
		return default(int);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1EA8C6C", Offset = "0x1EA8C6C", VA = "0x1EA8C6C")]
	public static ePluralType GetPluralType(string langCode, int n)
	{
		return default(ePluralType);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1EA936C", Offset = "0x1EA936C", VA = "0x1EA936C")]
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
	[Address(RVA = "0x1EAF02C", Offset = "0x1EAF02C", VA = "0x1EAF02C")]
	public static string UppercaseFirst(string s)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1EAF120", Offset = "0x1EAF120", VA = "0x1EAF120")]
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
	[Address(RVA = "0x1EB1244", Offset = "0x1EB1244", VA = "0x1EB1244")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1EB1254", Offset = "0x1EB1254", VA = "0x1EB1254")]
	public bool IsLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1EB1264", Offset = "0x1EB1264", VA = "0x1EB1264")]
	public bool CanBeUnloaded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1EB1274", Offset = "0x1EB1274", VA = "0x1EB1274")]
	public void SetLoaded(bool loaded)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1EB1290", Offset = "0x1EB1290", VA = "0x1EB1290")]
	public LanguageData()
	{
	}
}
[Token(Token = "0x200000F")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F9B94", Offset = "0x9F9B94")]
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
		[Address(RVA = "0x1EB1298", Offset = "0x1EB1298", VA = "0x1EB1298", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1EB12A0", Offset = "0x1EB12A0", VA = "0x1EB12A0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1EB12A8", Offset = "0x1EB12A8", VA = "0x1EB12A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9E94", Offset = "0x9F9E94")]
		add
		{
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1EB134C", Offset = "0x1EB134C", VA = "0x1EB134C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9EA4", Offset = "0x9F9EA4")]
		remove
		{
		}
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1EB13F0", Offset = "0x1EB13F0", VA = "0x1EB13F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1EB14AC", Offset = "0x1EB14AC", VA = "0x1EB14AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1EB1530", Offset = "0x1EB1530", VA = "0x1EB1530")]
	public string GetSourceName()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1EB1624", Offset = "0x1EB1624", VA = "0x1EB1624", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1EB1630", Offset = "0x1EB1630", VA = "0x1EB1630", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1EB1C58", Offset = "0x1EB1C58", VA = "0x1EB1C58")]
	public LanguageSource()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9F9BE0", Offset = "0x9F9BE0")]
public class LanguageSourceAsset : ScriptableObject, ILanguageSource
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LanguageSourceData mSource;

	[Token(Token = "0x17000002")]
	public LanguageSourceData SourceData
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1EB2298", Offset = "0x1EB2298", VA = "0x1EB2298", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1EB22A0", Offset = "0x1EB22A0", VA = "0x1EB22A0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1EB22A8", Offset = "0x1EB22A8", VA = "0x1EB22A8")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9C5C", Offset = "0x9F9C5C")]
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
		[Address(RVA = "0x1EB7010", Offset = "0x1EB7010", VA = "0x1EB7010")]
		public <>c()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1EB7018", Offset = "0x1EB7018", VA = "0x1EB7018")]
		internal bool <UpdateAssetDictionary>b__39_0(UnityEngine.Object x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1EB7084", Offset = "0x1EB7084", VA = "0x1EB7084")]
		internal string <UpdateAssetDictionary>b__39_1(UnityEngine.Object o)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1EB70A0", Offset = "0x1EB70A0", VA = "0x1EB70A0")]
		internal string <UpdateAssetDictionary>b__39_2(IGrouping<string, UnityEngine.Object> g)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1EB714C", Offset = "0x1EB714C", VA = "0x1EB714C")]
		internal UnityEngine.Object <UpdateAssetDictionary>b__39_3(IGrouping<string, UnityEngine.Object> g)
		{
			return null;
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9C6C", Offset = "0x9F9C6C")]
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
			[Address(RVA = "0x1EB7468", Offset = "0x1EB7468", VA = "0x1EB7468", Slot = "4")]
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
			[Address(RVA = "0x1EB74D0", Offset = "0x1EB74D0", VA = "0x1EB74D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1EB5C14", Offset = "0x1EB5C14", VA = "0x1EB5C14")]
		[DebuggerHidden]
		public <Import_Google_Coroutine>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1EB719C", Offset = "0x1EB719C", VA = "0x1EB719C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1EB71A0", Offset = "0x1EB71A0", VA = "0x1EB71A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1EB7470", Offset = "0x1EB7470", VA = "0x1EB7470", Slot = "8")]
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
		[Address(RVA = "0x1EB1BB4", Offset = "0x1EB1BB4", VA = "0x1EB1BB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9EB4", Offset = "0x9F9EB4")]
		add
		{
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1EB2318", Offset = "0x1EB2318", VA = "0x1EB2318")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9EC4", Offset = "0x9F9EC4")]
		remove
		{
		}
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1EB142C", Offset = "0x1EB142C", VA = "0x1EB142C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1EB14CC", Offset = "0x1EB14CC", VA = "0x1EB14CC")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1EB2E28", Offset = "0x1EB2E28", VA = "0x1EB2E28")]
	public void ClearAllData()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1EB2EC8", Offset = "0x1EB2EC8", VA = "0x1EB2EC8")]
	public void Editor_SetDirty()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1EB28A4", Offset = "0x1EB28A4", VA = "0x1EB28A4")]
	public void UpdateAssetDictionary()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1EB2ECC", Offset = "0x1EB2ECC", VA = "0x1EB2ECC")]
	public UnityEngine.Object FindAsset(string Name)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1EB2F90", Offset = "0x1EB2F90", VA = "0x1EB2F90")]
	private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1EB3514", Offset = "0x1EB3514", VA = "0x1EB3514")]
	public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1EB371C", Offset = "0x1EB371C", VA = "0x1EB371C")]
	public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1EB4224", Offset = "0x1EB4224", VA = "0x1EB4224")]
	private bool ArrayContains(string MainText, params string[] texts)
	{
		return default(bool);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1EB4A18", Offset = "0x1EB4A18", VA = "0x1EB4A18")]
	public static eTermType GetTermType(string type)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1EB4CAC", Offset = "0x1EB4CAC", VA = "0x1EB4CAC")]
	private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1EB4EE0", Offset = "0x1EB4EE0", VA = "0x1EB4EE0")]
	public void Import_Google_FromCache()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1EB52D8", Offset = "0x1EB52D8", VA = "0x1EB52D8")]
	private bool IsNewerVersion(string currentVersion, string newVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1EB5904", Offset = "0x1EB5904", VA = "0x1EB5904")]
	public void Import_Google(bool ForceUpdate, bool justCheck)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1EB5128", Offset = "0x1EB5128", VA = "0x1EB5128")]
	private string GetSourcePlayerPrefName()
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1EB5B84", Offset = "0x1EB5B84", VA = "0x1EB5B84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F9ED4", Offset = "0x9F9ED4")]
	private IEnumerator Import_Google_Coroutine(bool JustCheck)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1EB5C40", Offset = "0x1EB5C40", VA = "0x1EB5C40")]
	private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1EB5CE4", Offset = "0x1EB5CE4", VA = "0x1EB5CE4")]
	public void ApplyDownloadedDataFromGoogle()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1EB5E28", Offset = "0x1EB5E28", VA = "0x1EB5E28")]
	public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1EB5F80", Offset = "0x1EB5F80", VA = "0x1EB5F80")]
	public bool HasGoogleSpreadsheet()
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1EB5368", Offset = "0x1EB5368", VA = "0x1EB5368")]
	public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1EB4488", Offset = "0x1EB4488", VA = "0x1EB4488")]
	public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1EB63C8", Offset = "0x1EB63C8", VA = "0x1EB63C8")]
	public bool IsCurrentLanguage(int languageIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1EB42C8", Offset = "0x1EB42C8", VA = "0x1EB42C8")]
	public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1EB61F0", Offset = "0x1EB61F0", VA = "0x1EB61F0")]
	public static int GetCommonWordInLanguageNames(string Language1, string Language2)
	{
		return default(int);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1EB64E4", Offset = "0x1EB64E4", VA = "0x1EB64E4")]
	public List<string> GetLanguages(bool skipDisabled = true)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1EB6610", Offset = "0x1EB6610", VA = "0x1EB6610")]
	public bool AllowUnloadingLanguages()
	{
		return default(bool);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1EB6620", Offset = "0x1EB6620", VA = "0x1EB6620")]
	private string GetSavedLanguageFileName(int languageIndex)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1EB6830", Offset = "0x1EB6830", VA = "0x1EB6830")]
	public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1EB69B8", Offset = "0x1EB69B8", VA = "0x1EB69B8")]
	public void UnloadLanguage(int languageIndex)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1EB4B8C", Offset = "0x1EB4B8C", VA = "0x1EB4B8C")]
	public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1EB4AE8", Offset = "0x1EB4AE8", VA = "0x1EB4AE8")]
	public bool HasUnloadedLanguages()
	{
		return default(bool);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1EB6BE4", Offset = "0x1EB6BE4", VA = "0x1EB6BE4")]
	public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1EB25B4", Offset = "0x1EB25B4", VA = "0x1EB25B4")]
	public void UpdateDictionary(bool force = false)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1EB6CC8", Offset = "0x1EB6CC8", VA = "0x1EB6CC8")]
	public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1EB3220", Offset = "0x1EB3220", VA = "0x1EB3220")]
	private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1EB4844", Offset = "0x1EB4844", VA = "0x1EB4844")]
	public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1EB4674", Offset = "0x1EB4674", VA = "0x1EB4674")]
	public static void ValidateFullTerm(ref string Term)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1EB1984", Offset = "0x1EB1984", VA = "0x1EB1984")]
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
	[Address(RVA = "0x1EB3558", Offset = "0x1EB3558", VA = "0x1EB3558")]
	public static List<string[]> ReadI2CSV(string Text)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F9C7C", Offset = "0x9F9C7C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9CB4", Offset = "0x9F9CB4")]
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
		[Address(RVA = "0x1EBE0A4", Offset = "0x1EBE0A4", VA = "0x1EBE0A4")]
		public <>c()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1EBE0AC", Offset = "0x1EBE0AC", VA = "0x1EBE0AC")]
		internal bool <UpdateAssetDictionary>b__50_0(UnityEngine.Object x)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1EBE118", Offset = "0x1EBE118", VA = "0x1EBE118")]
		internal string <UpdateAssetDictionary>b__50_1(UnityEngine.Object o)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1EBE134", Offset = "0x1EBE134", VA = "0x1EBE134")]
		internal string <UpdateAssetDictionary>b__50_2(IGrouping<string, UnityEngine.Object> g)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1EBE1E0", Offset = "0x1EBE1E0", VA = "0x1EBE1E0")]
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
		[Address(RVA = "0x1EBCF18", Offset = "0x1EBCF18", VA = "0x1EBCF18")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1EBCF20", Offset = "0x1EBCF20", VA = "0x1EBCF20")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public string SecondaryTerm
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1EBCF7C", Offset = "0x1EBCF7C", VA = "0x1EBCF7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1EBCF84", Offset = "0x1EBCF84", VA = "0x1EBCF84")]
		set
		{
		}
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1EBD014", Offset = "0x1EBD014", VA = "0x1EBD014")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1EBD884", Offset = "0x1EBD884", VA = "0x1EBD884")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1EBD88C", Offset = "0x1EBD88C", VA = "0x1EBD88C")]
	public bool HasCallback()
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1EBB360", Offset = "0x1EBB360", VA = "0x1EBB360")]
	public void OnLocalize(bool Force = false)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1EBD388", Offset = "0x1EBD388", VA = "0x1EBD388")]
	public bool FindTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1EBD8DC", Offset = "0x1EBD8DC", VA = "0x1EBD8DC")]
	public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1EBDA88", Offset = "0x1EBDA88", VA = "0x1EBDA88")]
	public string GetMainTargetsText()
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1EBDB60", Offset = "0x1EBDB60", VA = "0x1EBDB60")]
	public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1EBCF24", Offset = "0x1EBCF24", VA = "0x1EBCF24")]
	public void SetTerm(string primary)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1EBCF90", Offset = "0x1EBCF90", VA = "0x1EBCF90")]
	public void SetTerm(string primary, string secondary)
	{
	}

	[Token(Token = "0x600008D")]
	internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1EBD058", Offset = "0x1EBD058", VA = "0x1EBD058")]
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
	[Address(RVA = "0x1EBDBB8", Offset = "0x1EBDBB8", VA = "0x1EBDBB8")]
	private void DeserializeTranslation(string translation, out string value, out string secondary)
	{
	}

	[Token(Token = "0x6000092")]
	public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1EBDCD0", Offset = "0x1EBDCD0", VA = "0x1EBDCD0")]
	public bool HasTranslatedObject(UnityEngine.Object Obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1EBDD68", Offset = "0x1EBDD68", VA = "0x1EBDD68")]
	public void AddTranslatedObject(UnityEngine.Object Obj)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1EBDE08", Offset = "0x1EBDE08", VA = "0x1EBDE08")]
	public void SetGlobalLanguage(string Language)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1EBDE6C", Offset = "0x1EBDE6C", VA = "0x1EBDE6C")]
	public Localize()
	{
	}
}
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F9CC4", Offset = "0x9F9CC4")]
public class LocalizeDropdown : MonoBehaviour
{
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> _Terms;

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1EBE230", Offset = "0x1EBE230", VA = "0x1EBE230")]
	public void Start()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1EBE3CC", Offset = "0x1EBE3CC", VA = "0x1EBE3CC")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1EBE468", Offset = "0x1EBE468", VA = "0x1EBE468")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1EBE2D4", Offset = "0x1EBE2D4", VA = "0x1EBE2D4")]
	public void OnLocalize()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1EBE4C8", Offset = "0x1EBE4C8", VA = "0x1EBE4C8")]
	private void FillValues()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1EBE658", Offset = "0x1EBE658", VA = "0x1EBE658")]
	public void UpdateLocalization()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1EBEA00", Offset = "0x1EBEA00", VA = "0x1EBEA00")]
	public void UpdateLocalizationTMPro()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1EBE888", Offset = "0x1EBE888", VA = "0x1EBE888")]
	private void FillValuesTMPro()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1EBEC24", Offset = "0x1EBEC24", VA = "0x1EBEC24")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9CFC", Offset = "0x9F9CFC")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> Languages;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<string, bool> <>9__0;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1EB8D78", Offset = "0x1EB8D78", VA = "0x1EB8D78")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1EBC5FC", Offset = "0x1EBC5FC", VA = "0x1EBC5FC")]
		internal bool <GetAllLanguages>b__0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D0C", Offset = "0x9F9D0C")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject root;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1EB8FB4", Offset = "0x1EB8FB4", VA = "0x1EB8FB4")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1EBC670", Offset = "0x1EBC670", VA = "0x1EBC670")]
		internal object <ApplyLocalizationParams>b__0(string p)
		{
			return null;
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D1C", Offset = "0x9F9D1C")]
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
			[Address(RVA = "0x1EBC938", Offset = "0x1EBC938", VA = "0x1EBC938", Slot = "4")]
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
			[Address(RVA = "0x1EBC9A0", Offset = "0x1EBC9A0", VA = "0x1EBC9A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1EBA5E4", Offset = "0x1EBA5E4", VA = "0x1EBA5E4")]
		[DebuggerHidden]
		public <Delayed_Import_Google>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1EBC874", Offset = "0x1EBC874", VA = "0x1EBC874", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1EBC878", Offset = "0x1EBC878", VA = "0x1EBC878", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1EBC940", Offset = "0x1EBC940", VA = "0x1EBC940", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D2C", Offset = "0x9F9D2C")]
	private sealed class <>c__DisplayClass71_0
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILocalizeTargetDescriptor desc;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1EBAE60", Offset = "0x1EBAE60", VA = "0x1EBAE60")]
		public <>c__DisplayClass71_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1EBC6E8", Offset = "0x1EBC6E8", VA = "0x1EBC6E8")]
		internal bool <RegisterTarget>b__0(ILocalizeTargetDescriptor x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D3C", Offset = "0x9F9D3C")]
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
			[Address(RVA = "0x1EBC804", Offset = "0x1EBC804", VA = "0x1EBC804", Slot = "4")]
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
			[Address(RVA = "0x1EBC86C", Offset = "0x1EBC86C", VA = "0x1EBC86C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1EBB334", Offset = "0x1EBB334", VA = "0x1EBB334")]
		[DebuggerHidden]
		public <Coroutine_LocalizeAll>d__86(int <>1__state)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1EBC714", Offset = "0x1EBC714", VA = "0x1EBC714", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1EBC718", Offset = "0x1EBC718", VA = "0x1EBC718", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1EBC80C", Offset = "0x1EBC80C", VA = "0x1EBC80C", Slot = "8")]
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
		[Address(RVA = "0x1EB6478", Offset = "0x1EB6478", VA = "0x1EB6478")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1EB7C58", Offset = "0x1EB7C58", VA = "0x1EB7C58")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public static string CurrentLanguageCode
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1EB85B4", Offset = "0x1EB85B4", VA = "0x1EB85B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000003")]
	public static event OnLocalizeCallback OnLocalizeEvent
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1EA7E60", Offset = "0x1EA7E60", VA = "0x1EA7E60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9FEC", Offset = "0x9F9FEC")]
		add
		{
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1EA7D70", Offset = "0x1EA7D70", VA = "0x1EA7D70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9FFC", Offset = "0x9F9FFC")]
		remove
		{
		}
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1EB74D8", Offset = "0x1EB74D8", VA = "0x1EB74D8")]
	public static void InitializeIfNeeded()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1EB61E8", Offset = "0x1EB61E8", VA = "0x1EB61E8")]
	public static int GetRequiredWebServiceVersion()
	{
		return default(int);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1EB6020", Offset = "0x1EB6020", VA = "0x1EB6020")]
	public static string GetWebServiceURL([Optional] LanguageSourceData source)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1EB83A0", Offset = "0x1EB83A0", VA = "0x1EB83A0")]
	public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1EB8620", Offset = "0x1EB8620", VA = "0x1EB8620")]
	private static CultureInfo CreateCultureForCode(string code)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1EA7398", Offset = "0x1EA7398", VA = "0x1EA7398")]
	public static void EnableChangingCultureInfo(bool bEnable)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1EB8724", Offset = "0x1EB8724", VA = "0x1EB8724")]
	private static void SetCurrentCultureInfo()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1EB77C0", Offset = "0x1EB77C0", VA = "0x1EB77C0")]
	private static void SelectStartupLanguage()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1EB8900", Offset = "0x1EB8900", VA = "0x1EB8900")]
	public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1EB7D48", Offset = "0x1EB7D48", VA = "0x1EB7D48")]
	public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1EB81BC", Offset = "0x1EB81BC", VA = "0x1EB81BC")]
	public static string GetLanguageCode(string Language)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1EB8B0C", Offset = "0x1EB8B0C", VA = "0x1EB8B0C")]
	public static List<string> GetAllLanguages(bool SkipDisabled = true)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1EB8D80", Offset = "0x1EB8D80", VA = "0x1EB8D80")]
	private static void LoadCurrentLanguage()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1EB75B0", Offset = "0x1EB75B0", VA = "0x1EB75B0")]
	public static void AutoLoadGlobalParamManagers()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1EB8ECC", Offset = "0x1EB8ECC", VA = "0x1EB8ECC")]
	public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1EB8FD0", Offset = "0x1EB8FD0", VA = "0x1EB8FD0")]
	public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1EB9904", Offset = "0x1EB9904", VA = "0x1EB9904")]
	internal static string GetLocalizationParam(string ParamName, GameObject root)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1EB9BB0", Offset = "0x1EB9BB0", VA = "0x1EB9BB0")]
	public static string ApplyRTLfix(string line)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1EB9C1C", Offset = "0x1EB9C1C", VA = "0x1EB9C1C")]
	public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1EB87AC", Offset = "0x1EB87AC", VA = "0x1EB87AC")]
	public static bool IsRTL(string Code)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1EB7738", Offset = "0x1EB7738", VA = "0x1EB7738")]
	public static bool UpdateSources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1EBA004", Offset = "0x1EBA004", VA = "0x1EBA004")]
	private static void UnregisterDeletededSources()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1EBA2FC", Offset = "0x1EBA2FC", VA = "0x1EBA2FC")]
	private static void RegisterSceneSources()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1EBA140", Offset = "0x1EBA140", VA = "0x1EBA140")]
	private static void RegisterSourceInResources()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1EBA488", Offset = "0x1EBA488", VA = "0x1EBA488")]
	private static bool AllowSyncFromGoogle(LanguageSourceData Source)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1EB23BC", Offset = "0x1EB23BC", VA = "0x1EB23BC")]
	internal static void AddSource(LanguageSourceData Source)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1EBA544", Offset = "0x1EBA544", VA = "0x1EBA544")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F9F88", Offset = "0x9F9F88")]
	private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1EB2DA4", Offset = "0x1EB2DA4", VA = "0x1EB2DA4")]
	internal static void RemoveSource(LanguageSourceData Source)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1EBA610", Offset = "0x1EBA610", VA = "0x1EBA610")]
	public static UnityEngine.Object FindAsset(string value)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1EB8834", Offset = "0x1EB8834", VA = "0x1EB8834")]
	public static string GetCurrentDeviceLanguage(bool force = false)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1EBA750", Offset = "0x1EBA750", VA = "0x1EBA750")]
	private static void DetectDeviceLanguage()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1EBAC1C", Offset = "0x1EBAC1C", VA = "0x1EBAC1C")]
	public static void RegisterTarget(ILocalizeTargetDescriptor desc)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1EBAE68", Offset = "0x1EBAE68", VA = "0x1EBAE68")]
	public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1EBAF3C", Offset = "0x1EBAF3C", VA = "0x1EBAF3C")]
	public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1EB2CA0", Offset = "0x1EB2CA0", VA = "0x1EB2CA0")]
	public static void LocalizeAll(bool Force = false)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1EBB2D4", Offset = "0x1EBB2D4", VA = "0x1EBB2D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FA00C", Offset = "0x9FA00C")]
	private static IEnumerator Coroutine_LocalizeAll()
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1EBB160", Offset = "0x1EBB160", VA = "0x1EBB160")]
	private static void DoLocalizeAll(bool Force = false)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1EB9780", Offset = "0x1EB9780", VA = "0x1EB9780")]
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
	[Address(RVA = "0x1EB1234", Offset = "0x1EB1234", VA = "0x1EB1234")]
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
	[Address(RVA = "0x1EB123C", Offset = "0x1EB123C", VA = "0x1EB123C")]
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
	[Address(RVA = "0x1EBED80", Offset = "0x1EBED80", VA = "0x1EBED80")]
	static LocalizeTarget_TextMeshPro_Label()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1EBED84", Offset = "0x1EBED84", VA = "0x1EBED84")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA110", Offset = "0x9FA110")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1EBEE34", Offset = "0x1EBEE34", VA = "0x1EBEE34", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1EBEE3C", Offset = "0x1EBEE3C", VA = "0x1EBEE3C", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1EBEE44", Offset = "0x1EBEE44", VA = "0x1EBEE44", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1EBEE4C", Offset = "0x1EBEE4C", VA = "0x1EBEE4C", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1EBEE54", Offset = "0x1EBEE54", VA = "0x1EBEE54", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1EBEE5C", Offset = "0x1EBEE5C", VA = "0x1EBEE5C", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1EBEF80", Offset = "0x1EBEF80", VA = "0x1EBEF80", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1EBF594", Offset = "0x1EBF594", VA = "0x1EBF594")]
	internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1EBF824", Offset = "0x1EBF824", VA = "0x1EBF824")]
	internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1EBF48C", Offset = "0x1EBF48C", VA = "0x1EBF48C")]
	internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1EBF6FC", Offset = "0x1EBF6FC", VA = "0x1EBF6FC")]
	internal static void SetMaterial(TMP_Text label, Material newMat)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1EBFA38", Offset = "0x1EBFA38", VA = "0x1EBFA38")]
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
	[Address(RVA = "0x1EBFA9C", Offset = "0x1EBFA9C", VA = "0x1EBFA9C")]
	static LocalizeTarget_TextMeshPro_UGUI()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1EBFAA0", Offset = "0x1EBFAA0", VA = "0x1EBFAA0")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA124", Offset = "0x9FA124")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1EBFB50", Offset = "0x1EBFB50", VA = "0x1EBFB50", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1EBFB58", Offset = "0x1EBFB58", VA = "0x1EBFB58", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1EBFB60", Offset = "0x1EBFB60", VA = "0x1EBFB60", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1EBFB68", Offset = "0x1EBFB68", VA = "0x1EBFB68", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1EBFB70", Offset = "0x1EBFB70", VA = "0x1EBFB70", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1EBFB78", Offset = "0x1EBFB78", VA = "0x1EBFB78", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1EBFC9C", Offset = "0x1EBFC9C", VA = "0x1EBFC9C", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1EC01A8", Offset = "0x1EC01A8", VA = "0x1EC01A8")]
	public LocalizeTarget_TextMeshPro_UGUI()
	{
	}
}
[Token(Token = "0x200002F")]
public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
{
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1EC020C", Offset = "0x1EC020C", VA = "0x1EC020C")]
	static LocalizeTarget_UnityStandard_AudioSource()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1EC0210", Offset = "0x1EC0210", VA = "0x1EC0210")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA138", Offset = "0x9FA138")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1EC02C0", Offset = "0x1EC02C0", VA = "0x1EC02C0", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1EC02C8", Offset = "0x1EC02C8", VA = "0x1EC02C8", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1EC02D0", Offset = "0x1EC02D0", VA = "0x1EC02D0", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1EC02D8", Offset = "0x1EC02D8", VA = "0x1EC02D8", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1EC02E0", Offset = "0x1EC02E0", VA = "0x1EC02E0", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1EC02E8", Offset = "0x1EC02E8", VA = "0x1EC02E8", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1EC03C8", Offset = "0x1EC03C8", VA = "0x1EC03C8", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1EC0544", Offset = "0x1EC0544", VA = "0x1EC0544")]
	public LocalizeTarget_UnityStandard_AudioSource()
	{
	}
}
[Token(Token = "0x2000030")]
public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
{
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1EBECA0", Offset = "0x1EBECA0", VA = "0x1EBECA0", Slot = "4")]
	public override bool CanLocalize(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1EBECD8", Offset = "0x1EBECD8", VA = "0x1EBECD8")]
	public LocalizeTargetDesc_Child()
	{
	}
}
[Token(Token = "0x2000031")]
public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
{
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1EC0594", Offset = "0x1EC0594", VA = "0x1EC0594")]
	static LocalizeTarget_UnityStandard_Child()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1EC0598", Offset = "0x1EC0598", VA = "0x1EC0598")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA14C", Offset = "0x9FA14C")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1EC063C", Offset = "0x1EC063C", VA = "0x1EC063C", Slot = "4")]
	public override bool IsValid(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1EC0674", Offset = "0x1EC0674", VA = "0x1EC0674", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1EC067C", Offset = "0x1EC067C", VA = "0x1EC067C", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1EC0684", Offset = "0x1EC0684", VA = "0x1EC0684", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1EC068C", Offset = "0x1EC068C", VA = "0x1EC068C", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1EC0694", Offset = "0x1EC0694", VA = "0x1EC0694", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1EC069C", Offset = "0x1EC069C", VA = "0x1EC069C", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1EC06EC", Offset = "0x1EC06EC", VA = "0x1EC06EC", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1EC0844", Offset = "0x1EC0844", VA = "0x1EC0844")]
	public LocalizeTarget_UnityStandard_Child()
	{
	}
}
[Token(Token = "0x2000032")]
public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
{
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1EC0894", Offset = "0x1EC0894", VA = "0x1EC0894")]
	static LocalizeTarget_UnityStandard_MeshRenderer()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1EC0898", Offset = "0x1EC0898", VA = "0x1EC0898")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA160", Offset = "0x9FA160")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1EC0948", Offset = "0x1EC0948", VA = "0x1EC0948", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1EC0950", Offset = "0x1EC0950", VA = "0x1EC0950", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1EC0958", Offset = "0x1EC0958", VA = "0x1EC0958", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1EC0960", Offset = "0x1EC0960", VA = "0x1EC0960", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1EC0968", Offset = "0x1EC0968", VA = "0x1EC0968", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1EC0970", Offset = "0x1EC0970", VA = "0x1EC0970", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1EC0B8C", Offset = "0x1EC0B8C", VA = "0x1EC0B8C", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1EC0D64", Offset = "0x1EC0D64", VA = "0x1EC0D64")]
	public LocalizeTarget_UnityStandard_MeshRenderer()
	{
	}
}
[Token(Token = "0x2000033")]
public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
{
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1EBED28", Offset = "0x1EBED28", VA = "0x1EBED28", Slot = "4")]
	public override bool CanLocalize(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1EBED30", Offset = "0x1EBED30", VA = "0x1EBED30")]
	public LocalizeTargetDesc_Prefab()
	{
	}
}
[Token(Token = "0x2000034")]
public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
{
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1EC0DB4", Offset = "0x1EC0DB4", VA = "0x1EC0DB4")]
	static LocalizeTarget_UnityStandard_Prefab()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1EC0DB8", Offset = "0x1EC0DB8", VA = "0x1EC0DB8")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA174", Offset = "0x9FA174")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1EC0E5C", Offset = "0x1EC0E5C", VA = "0x1EC0E5C", Slot = "4")]
	public override bool IsValid(Localize cmp)
	{
		return default(bool);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1EC0E64", Offset = "0x1EC0E64", VA = "0x1EC0E64", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1EC0E6C", Offset = "0x1EC0E6C", VA = "0x1EC0E6C", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1EC0E74", Offset = "0x1EC0E74", VA = "0x1EC0E74", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1EC0E7C", Offset = "0x1EC0E7C", VA = "0x1EC0E7C", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1EC0E84", Offset = "0x1EC0E84", VA = "0x1EC0E84", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1EC0E8C", Offset = "0x1EC0E8C", VA = "0x1EC0E8C", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1EC0EDC", Offset = "0x1EC0EDC", VA = "0x1EC0EDC", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1EC1104", Offset = "0x1EC1104", VA = "0x1EC1104")]
	private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1EC12C0", Offset = "0x1EC12C0", VA = "0x1EC12C0")]
	public LocalizeTarget_UnityStandard_Prefab()
	{
	}
}
[Token(Token = "0x2000035")]
public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
{
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1E2469C", Offset = "0x1E2469C", VA = "0x1E2469C")]
	static LocalizeTarget_UnityStandard_SpriteRenderer()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1E246A0", Offset = "0x1E246A0", VA = "0x1E246A0")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA188", Offset = "0x9FA188")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1E24754", Offset = "0x1E24754", VA = "0x1E24754", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1E2475C", Offset = "0x1E2475C", VA = "0x1E2475C", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1E24764", Offset = "0x1E24764", VA = "0x1E24764", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1E2476C", Offset = "0x1E2476C", VA = "0x1E2476C", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1E24774", Offset = "0x1E24774", VA = "0x1E24774", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1E2477C", Offset = "0x1E2477C", VA = "0x1E2477C", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1E24860", Offset = "0x1E24860", VA = "0x1E24860", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1E24960", Offset = "0x1E24960", VA = "0x1E24960")]
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
	[Address(RVA = "0x1E249B0", Offset = "0x1E249B0", VA = "0x1E249B0")]
	static LocalizeTarget_UnityStandard_TextMesh()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1E249B4", Offset = "0x1E249B4", VA = "0x1E249B4")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA19C", Offset = "0x9FA19C")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1E24A68", Offset = "0x1E24A68", VA = "0x1E24A68", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1E24A70", Offset = "0x1E24A70", VA = "0x1E24A70", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1E24A78", Offset = "0x1E24A78", VA = "0x1E24A78", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1E24A80", Offset = "0x1E24A80", VA = "0x1E24A80", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1E24A88", Offset = "0x1E24A88", VA = "0x1E24A88", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1E24A90", Offset = "0x1E24A90", VA = "0x1E24A90", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1E24BCC", Offset = "0x1E24BCC", VA = "0x1E24BCC", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1E24E88", Offset = "0x1E24E88", VA = "0x1E24E88")]
	public LocalizeTarget_UnityStandard_TextMesh()
	{
	}
}
[Token(Token = "0x2000037")]
public class LocalizeTarget_UnityStandard_VideoPlayer : LocalizeTarget<VideoPlayer>
{
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1E24EE8", Offset = "0x1E24EE8", VA = "0x1E24EE8")]
	static LocalizeTarget_UnityStandard_VideoPlayer()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1E24EEC", Offset = "0x1E24EEC", VA = "0x1E24EEC")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA1B0", Offset = "0x9FA1B0")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1E24FA0", Offset = "0x1E24FA0", VA = "0x1E24FA0", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1E24FA8", Offset = "0x1E24FA8", VA = "0x1E24FA8", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1E24FB0", Offset = "0x1E24FB0", VA = "0x1E24FB0", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1E24FB8", Offset = "0x1E24FB8", VA = "0x1E24FB8", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1E24FC0", Offset = "0x1E24FC0", VA = "0x1E24FC0", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1E24FC8", Offset = "0x1E24FC8", VA = "0x1E24FC8", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1E250AC", Offset = "0x1E250AC", VA = "0x1E250AC", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1E251AC", Offset = "0x1E251AC", VA = "0x1E251AC")]
	public LocalizeTarget_UnityStandard_VideoPlayer()
	{
	}
}
[Token(Token = "0x2000038")]
public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
{
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1E251FC", Offset = "0x1E251FC", VA = "0x1E251FC")]
	static LocalizeTarget_UnityUI_Image()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1E25200", Offset = "0x1E25200", VA = "0x1E25200")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA1C4", Offset = "0x9FA1C4")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1E252B4", Offset = "0x1E252B4", VA = "0x1E252B4", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1E252BC", Offset = "0x1E252BC", VA = "0x1E252BC", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1E252C4", Offset = "0x1E252C4", VA = "0x1E252C4", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1E252CC", Offset = "0x1E252CC", VA = "0x1E252CC", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1E2535C", Offset = "0x1E2535C", VA = "0x1E2535C", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1E25364", Offset = "0x1E25364", VA = "0x1E25364", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1E25508", Offset = "0x1E25508", VA = "0x1E25508", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1E255FC", Offset = "0x1E255FC", VA = "0x1E255FC")]
	public LocalizeTarget_UnityUI_Image()
	{
	}
}
[Token(Token = "0x2000039")]
public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
{
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1E2564C", Offset = "0x1E2564C", VA = "0x1E2564C")]
	static LocalizeTarget_UnityUI_RawImage()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1E25650", Offset = "0x1E25650", VA = "0x1E25650")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA1D8", Offset = "0x9FA1D8")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1E25704", Offset = "0x1E25704", VA = "0x1E25704", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1E2570C", Offset = "0x1E2570C", VA = "0x1E2570C", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1E25714", Offset = "0x1E25714", VA = "0x1E25714", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1E2571C", Offset = "0x1E2571C", VA = "0x1E2571C", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1E25724", Offset = "0x1E25724", VA = "0x1E25724", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1E2572C", Offset = "0x1E2572C", VA = "0x1E2572C", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1E25820", Offset = "0x1E25820", VA = "0x1E25820", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1E25914", Offset = "0x1E25914", VA = "0x1E25914")]
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
	[Address(RVA = "0x1E25964", Offset = "0x1E25964", VA = "0x1E25964")]
	static LocalizeTarget_UnityUI_Text()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1E25968", Offset = "0x1E25968", VA = "0x1E25968")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9FA1EC", Offset = "0x9FA1EC")]
	private static void AutoRegister()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1E25A1C", Offset = "0x1E25A1C", VA = "0x1E25A1C", Slot = "10")]
	public override eTermType GetPrimaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1E25A24", Offset = "0x1E25A24", VA = "0x1E25A24", Slot = "11")]
	public override eTermType GetSecondaryTermType(Localize cmp)
	{
		return default(eTermType);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1E25A2C", Offset = "0x1E25A2C", VA = "0x1E25A2C", Slot = "7")]
	public override bool CanUseSecondaryTerm()
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1E25A34", Offset = "0x1E25A34", VA = "0x1E25A34", Slot = "8")]
	public override bool AllowMainTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1E25A3C", Offset = "0x1E25A3C", VA = "0x1E25A3C", Slot = "9")]
	public override bool AllowSecondTermToBeRTL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1E25A44", Offset = "0x1E25A44", VA = "0x1E25A44", Slot = "5")]
	public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1E25B84", Offset = "0x1E25B84", VA = "0x1E25B84", Slot = "6")]
	public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1E25E68", Offset = "0x1E25E68", VA = "0x1E25E68")]
	private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1E25F28", Offset = "0x1E25F28", VA = "0x1E25F28")]
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
	[Address(RVA = "0x1E2A564", Offset = "0x1E2A564", VA = "0x1E2A564")]
	public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1E2A674", Offset = "0x1E2A674", VA = "0x1E2A674")]
	public void SetTranslation(int idx, string translation, [Optional] string specialization)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1E2A76C", Offset = "0x1E2A76C", VA = "0x1E2A76C")]
	public void Validate()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1E2A9BC", Offset = "0x1E2A9BC", VA = "0x1E2A9BC")]
	public bool IsTerm(string name, bool allowCategoryMistmatch)
	{
		return default(bool);
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1E2AA54", Offset = "0x1E2AA54", VA = "0x1E2AA54")]
	public TermData()
	{
	}
}
[Token(Token = "0x200003D")]
public class AutoChangeCultureInfo : MonoBehaviour
{
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1EA7338", Offset = "0x1EA7338", VA = "0x1EA7338")]
	public void Start()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1EA744C", Offset = "0x1EA744C", VA = "0x1EA744C")]
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
		[Address(RVA = "0x1EA7A88", Offset = "0x1EA7A88", VA = "0x1EA7A88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1EA7BBC", Offset = "0x1EA7BBC", VA = "0x1EA7BBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1EA7C50", Offset = "0x1EA7C50", VA = "0x1EA7C50")]
	public static Coroutine Start(IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1EA7C80", Offset = "0x1EA7C80", VA = "0x1EA7C80")]
	public CoroutineManager()
	{
	}
}
[Token(Token = "0x200003F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F9D4C", Offset = "0x9F9D4C")]
public class CustomLocalizeCallback : MonoBehaviour
{
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent _OnLocalize;

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1EA7C88", Offset = "0x1EA7C88", VA = "0x1EA7C88")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1EA7F50", Offset = "0x1EA7F50", VA = "0x1EA7F50")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1EA7FEC", Offset = "0x1EA7FEC", VA = "0x1EA7FEC")]
	public void OnLocalize()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1EA8008", Offset = "0x1EA8008", VA = "0x1EA8008")]
	public CustomLocalizeCallback()
	{
	}
}
[Token(Token = "0x2000040")]
public class HindiFixer
{
	[Serializable]
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D84", Offset = "0x9F9D84")]
	private sealed class <>c
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<char, bool> <>9__0_0;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1EAF748", Offset = "0x1EAF748", VA = "0x1EAF748")]
		public <>c()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1EAF750", Offset = "0x1EAF750", VA = "0x1EAF750")]
		internal bool <Fix>b__0_0(char x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1EAF288", Offset = "0x1EAF288", VA = "0x1EAF288")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9DA4", Offset = "0x9F9DA4")]
	private sealed class <>c
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<char, bool> <>9__6_0;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1EB1220", Offset = "0x1EB1220", VA = "0x1EB1220")]
		public <>c()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1EB1228", Offset = "0x1EB1228", VA = "0x1EB1228")]
		internal bool <SplitLine>b__6_0(char c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1EB09BC", Offset = "0x1EB09BC", VA = "0x1EB09BC")]
	public static string ReverseText(string source)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1EB0A94", Offset = "0x1EB0A94", VA = "0x1EB0A94")]
	public static string RemoveNonASCII(string text, bool allowCategory = false)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1EB0CBC", Offset = "0x1EB0CBC", VA = "0x1EB0CBC")]
	public static string GetValidTermName(string text, bool allowCategory = false)
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1EB0D68", Offset = "0x1EB0D68", VA = "0x1EB0D68")]
	public static string SplitLine(string line, int maxCharacters)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1EB1010", Offset = "0x1EB1010", VA = "0x1EB1010")]
	public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
	{
		return default(bool);
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1EB0CE8", Offset = "0x1EB0CE8", VA = "0x1EB0CE8")]
	public static string RemoveTags(string text)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1EB1198", Offset = "0x1EB1198", VA = "0x1EB1198")]
	public static bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1EB11A0", Offset = "0x1EB11A0", VA = "0x1EB11A0")]
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
	[Address(RVA = "0x1EBCA10", Offset = "0x1EBCA10", VA = "0x1EBCA10", Slot = "4")]
	public string GetParameterValue(string ParamName)
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1EBCAFC", Offset = "0x1EBCAFC", VA = "0x1EBCAFC")]
	public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1EBCC84", Offset = "0x1EBCC84", VA = "0x1EBCC84")]
	public void OnLocalize()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1EBCD30", Offset = "0x1EBCD30", VA = "0x1EBCD30", Slot = "5")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1EBCD40", Offset = "0x1EBCD40", VA = "0x1EBCD40")]
	public void DoAutoRegister()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1EBCE18", Offset = "0x1EBCE18", VA = "0x1EBCE18")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1EBCE9C", Offset = "0x1EBCE9C", VA = "0x1EBCE9C")]
	public LocalizationParamsManager()
	{
	}
}
[Token(Token = "0x2000047")]
public class RTLFixer
{
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1E266C4", Offset = "0x1E266C4", VA = "0x1E266C4")]
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
	[Address(RVA = "0x1EA6684", Offset = "0x1EA6684", VA = "0x1EA6684")]
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
		[Address(RVA = "0x1EA71A8", Offset = "0x1EA71A8", VA = "0x1EA71A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1EA66BC", Offset = "0x1EA66BC", VA = "0x1EA66BC")]
	private ArabicTable()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1EA722C", Offset = "0x1EA722C", VA = "0x1EA722C")]
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
	[Address(RVA = "0x1E27C18", Offset = "0x1E27C18", VA = "0x1E27C18")]
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
	[Address(RVA = "0x1E27670", Offset = "0x1E27670", VA = "0x1E27670")]
	internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1E27C54", Offset = "0x1E27C54", VA = "0x1E27C54")]
	internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1E26964", Offset = "0x1E26964", VA = "0x1E26964")]
	internal static string FixLine(string str)
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1E27E50", Offset = "0x1E27E50", VA = "0x1E27E50")]
	internal static bool IsIgnoredCharacter(char ch)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1E284B0", Offset = "0x1E284B0", VA = "0x1E284B0")]
	internal static bool IsLeadingLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1E2834C", Offset = "0x1E2834C", VA = "0x1E2834C")]
	internal static bool IsFinishingLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1E27FCC", Offset = "0x1E27FCC", VA = "0x1E27FCC")]
	internal static bool IsMiddleLetter(char[] letters, int index)
	{
		return default(bool);
	}
}
[Token(Token = "0x200004C")]
public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
{
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1E28840", Offset = "0x1E28840", VA = "0x1E28840")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1E288E8", Offset = "0x1E288E8", VA = "0x1E288E8")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1E28990", Offset = "0x1E28990", VA = "0x1E28990")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1E289FC", Offset = "0x1E289FC", VA = "0x1E289FC", Slot = "4")]
	public virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1E28A04", Offset = "0x1E28A04", VA = "0x1E28A04")]
	public RegisterCallback_AllowSyncFromGoogle()
	{
	}
}
[Token(Token = "0x200004D")]
public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
{
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1E28A0C", Offset = "0x1E28A0C", VA = "0x1E28A0C", Slot = "5")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1E28AE8", Offset = "0x1E28AE8", VA = "0x1E28AE8", Slot = "6")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1E28B6C", Offset = "0x1E28B6C", VA = "0x1E28B6C", Slot = "7")]
	public virtual string GetParameterValue(string ParamName)
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1E28B74", Offset = "0x1E28B74", VA = "0x1E28B74")]
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
		[Address(RVA = "0x1E28B7C", Offset = "0x1E28B7C", VA = "0x1E28B7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1E28F00", Offset = "0x1E28F00", VA = "0x1E28F00")]
	public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60001C5")]
	public T GetAsset<T>(string Name) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1E28FF0", Offset = "0x1E28FF0", VA = "0x1E28FF0")]
	private UnityEngine.Object FindAsset(string Name)
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1E29130", Offset = "0x1E29130", VA = "0x1E29130")]
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
	[Address(RVA = "0x1E28F74", Offset = "0x1E28F74", VA = "0x1E28F74")]
	public void CleanResourceCache(bool unloadResources = false)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1E291A0", Offset = "0x1E291A0", VA = "0x1E291A0")]
	public ResourceManager()
	{
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F9DB4", Offset = "0x9F9DB4")]
public class SetLanguage : MonoBehaviour
{
	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string _Language;

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1E292C4", Offset = "0x1E292C4", VA = "0x1E292C4")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1E292C8", Offset = "0x1E292C8", VA = "0x1E292C8")]
	public void ApplyLanguage()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1E29384", Offset = "0x1E29384", VA = "0x1E29384")]
	public SetLanguage()
	{
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9F9DEC", Offset = "0x9F9DEC")]
public class SetLanguageDropdown : MonoBehaviour
{
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1E2938C", Offset = "0x1E2938C", VA = "0x1E2938C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1E295B8", Offset = "0x1E295B8", VA = "0x1E295B8")]
	private void OnValueChanged(int index)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1E296A8", Offset = "0x1E296A8", VA = "0x1E296A8")]
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
	[Address(RVA = "0x1E2A02C", Offset = "0x1E2A02C", VA = "0x1E2A02C")]
	public static string Encode(string NormalString)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1E2A36C", Offset = "0x1E2A36C", VA = "0x1E2A36C")]
	public static string Decode(string ObfucatedString)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1E2A2D8", Offset = "0x1E2A2D8", VA = "0x1E2A2D8")]
	private static string ToBase64(string regularString)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1E2A454", Offset = "0x1E2A454", VA = "0x1E2A454")]
	private static string FromBase64(string base64string)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1E2A114", Offset = "0x1E2A114", VA = "0x1E2A114")]
	private static string XoREncode(string NormalString)
	{
		return null;
	}
}
