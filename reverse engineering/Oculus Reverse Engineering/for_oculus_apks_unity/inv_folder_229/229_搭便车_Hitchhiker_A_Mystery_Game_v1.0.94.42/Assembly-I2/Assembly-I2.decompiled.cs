using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace I2.Loc
{
	[Token(Token = "0x2000002")]
	public class CallbackNotification : MonoBehaviour
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x22E6970", Offset = "0x22E6970", VA = "0x22E6970")]
		public void OnModifyLocalization()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x22E6A88", Offset = "0x22E6A88", VA = "0x22E6A88")]
		public CallbackNotification()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class Example_ChangeLanguage : MonoBehaviour
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x22E7020", Offset = "0x22E7020", VA = "0x22E7020")]
		public void SetLanguage_English()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x22E7108", Offset = "0x22E7108", VA = "0x22E7108")]
		public void SetLanguage_French()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x22E714C", Offset = "0x22E714C", VA = "0x22E714C")]
		public void SetLanguage_Spanish()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x22E7064", Offset = "0x22E7064", VA = "0x22E7064")]
		public void SetLanguage(string LangName)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x22E7190", Offset = "0x22E7190", VA = "0x22E7190")]
		public Example_ChangeLanguage()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class Example_LocalizedString : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocalizedString _MyLocalizedString;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string _NormalString;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TermsPopup", RVA = "0xA6DF0C", Offset = "0xA6DF0C")]
		public string _StringWithTermPopup;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x22E7198", Offset = "0x22E7198", VA = "0x22E7198")]
		public void Start()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x22E74CC", Offset = "0x22E74CC", VA = "0x22E74CC")]
		public Example_LocalizedString()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class GlobalParametersExample : RegisterGlobalParameters
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x22E74D4", Offset = "0x22E74D4", VA = "0x22E74D4", Slot = "7")]
		public override string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x22E7598", Offset = "0x22E7598", VA = "0x22E7598")]
		public GlobalParametersExample()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class RealTimeTranslation : MonoBehaviour
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string OriginalText;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string TranslatedText;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool IsTranslating;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x265F310", Offset = "0x265F310", VA = "0x265F310")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x265F9CC", Offset = "0x265F9CC", VA = "0x265F9CC")]
		public void StartTranslating(string fromCode, string toCode)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x265FC90", Offset = "0x265FC90", VA = "0x265FC90")]
		private void OnTranslationReady(string Translation, string errorMsg)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x265FD28", Offset = "0x265FD28", VA = "0x265FD28")]
		public void ExampleMultiTranslations_Blocking()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x265FAB8", Offset = "0x265FAB8", VA = "0x265FAB8")]
		public void ExampleMultiTranslations_Async()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x265FFC0", Offset = "0x265FFC0", VA = "0x265FFC0")]
		private void OnMultitranslationReady(Dictionary<string, TranslationQuery> dict, string errorMsg)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x266024C", Offset = "0x266024C", VA = "0x266024C")]
		public bool IsWaitingForTranslation()
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2660254", Offset = "0x2660254", VA = "0x2660254")]
		public string GetTranslatedText()
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x266025C", Offset = "0x266025C", VA = "0x266025C")]
		public void SetOriginalText(string text)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2660264", Offset = "0x2660264", VA = "0x2660264")]
		public RealTimeTranslation()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class RegisterBundlesManager : MonoBehaviour, IResourceManager_Bundles
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x26602EC", Offset = "0x26602EC", VA = "0x26602EC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2660790", Offset = "0x2660790", VA = "0x2660790")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x26607F0", Offset = "0x26607F0", VA = "0x26607F0", Slot = "5")]
		public virtual UnityEngine.Object LoadFromBundle(string path, Type assetType)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x26607F8", Offset = "0x26607F8", VA = "0x26607F8")]
		public RegisterBundlesManager()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class ToggleLanguage : MonoBehaviour
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2662CD4", Offset = "0x2662CD4", VA = "0x2662CD4")]
		private void Start()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2662D28", Offset = "0x2662D28", VA = "0x2662D28")]
		private void test()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2662DF8", Offset = "0x2662DF8", VA = "0x2662DF8")]
		public ToggleLanguage()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public static class PersistentStorage
	{
		[Token(Token = "0x200000A")]
		public enum eFileType
		{
			[Token(Token = "0x4000009")]
			Raw,
			[Token(Token = "0x400000A")]
			Persistent,
			[Token(Token = "0x400000B")]
			Temporal,
			[Token(Token = "0x400000C")]
			Streaming
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1494BE4", Offset = "0x1494BE4", VA = "0x1494BE4")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1494028", Offset = "0x1494028", VA = "0x1494028")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1494248", Offset = "0x1494248", VA = "0x1494248")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1493F70", Offset = "0x1493F70", VA = "0x1493F70")]
		public static bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1495280", Offset = "0x1495280", VA = "0x1495280")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x149656C", Offset = "0x149656C", VA = "0x149656C")]
		public static bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x14951A8", Offset = "0x14951A8", VA = "0x14951A8")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1493EA0", Offset = "0x1493EA0", VA = "0x1493EA0")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1494178", Offset = "0x1494178", VA = "0x1494178")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1496904", Offset = "0x1496904", VA = "0x1496904")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000B")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x22F4410", Offset = "0x22F4410", VA = "0x22F4410", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x22F469C", Offset = "0x22F469C", VA = "0x22F469C", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x22F4904", Offset = "0x22F4904", VA = "0x22F4904", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x22F4B28", Offset = "0x22F4B28", VA = "0x22F4B28", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x22F4B30", Offset = "0x22F4B30", VA = "0x22F4B30", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x22F4B3C", Offset = "0x22F4B3C", VA = "0x22F4B3C", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x22F4B44", Offset = "0x22F4B44", VA = "0x22F4B44")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x22F4BEC", Offset = "0x22F4BEC", VA = "0x22F4BEC", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x22F4DA4", Offset = "0x22F4DA4", VA = "0x22F4DA4", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x22F4F50", Offset = "0x22F4F50", VA = "0x22F4F50", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x22F50F0", Offset = "0x22F50F0", VA = "0x22F50F0", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x22F5290", Offset = "0x22F5290", VA = "0x22F5290")]
		protected I2BasePersistentStorage()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class I2CustomPersistentStorage : I2BasePersistentStorage
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x22F5298", Offset = "0x22F5298", VA = "0x22F5298")]
		public I2CustomPersistentStorage()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x22E6300", Offset = "0x22E6300", VA = "0x22E6300", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x22E685C", Offset = "0x22E685C", VA = "0x22E685C", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x22E68BC", Offset = "0x22E68BC", VA = "0x22E68BC", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x22E6968", Offset = "0x22E6968", VA = "0x22E6968")]
		public BaseSpecializationManager()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x26611B8", Offset = "0x26611B8", VA = "0x26611B8")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x26611E8", Offset = "0x26611E8", VA = "0x26611E8")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x26613F0", Offset = "0x26613F0", VA = "0x26613F0")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2661738", Offset = "0x2661738", VA = "0x2661738")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x266151C", Offset = "0x266151C", VA = "0x266151C")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2661B40", Offset = "0x2661B40", VA = "0x2661B40")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class EventCallback
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x22E6EC4", Offset = "0x22E6EC4", VA = "0x22E6EC4")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x22E6F2C", Offset = "0x22E6F2C", VA = "0x22E6F2C")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x22E6FBC", Offset = "0x22E6FBC", VA = "0x22E6FBC")]
		public EventCallback()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public enum ePluralType
	{
		[Token(Token = "0x4000013")]
		Zero,
		[Token(Token = "0x4000014")]
		One,
		[Token(Token = "0x4000015")]
		Two,
		[Token(Token = "0x4000016")]
		Few,
		[Token(Token = "0x4000017")]
		Many,
		[Token(Token = "0x4000018")]
		Plural
	}
	[Token(Token = "0x2000011")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x2000012")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x22E75A0", Offset = "0x22E75A0", VA = "0x22E75A0")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x22E79A0", Offset = "0x22E79A0", VA = "0x22E79A0")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x22E784C", Offset = "0x22E784C", VA = "0x22E784C")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x22E7F28", Offset = "0x22E7F28", VA = "0x22E7F28")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x22E8080", Offset = "0x22E8080", VA = "0x22E8080")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x22E815C", Offset = "0x22E815C", VA = "0x22E815C")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x22E82EC", Offset = "0x22E82EC", VA = "0x22E82EC")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x22E84B8", Offset = "0x22E84B8", VA = "0x22E84B8")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x22E87A0", Offset = "0x22E87A0", VA = "0x22E87A0")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x22E89A0", Offset = "0x22E89A0", VA = "0x22E89A0")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x22E8B48", Offset = "0x22E8B48", VA = "0x22E8B48")]
		private static int GetPluralRule(string langCode)
		{
			return default(int);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x22E8D14", Offset = "0x22E8D14", VA = "0x22E8D14")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x22E8EDC", Offset = "0x22E8EDC", VA = "0x22E8EDC")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default(ePluralType);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x22E95F0", Offset = "0x22E95F0", VA = "0x22E95F0")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return default(int);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x22E95D8", Offset = "0x22E95D8", VA = "0x22E95D8")]
		private static bool inRange(int amount, int min, int max)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000013")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DABC", Offset = "0xA6DABC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<string, string> OnTranslationReady;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, TranslationQuery> queries;

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string LanguageCodeTo;

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x26647EC", Offset = "0x26647EC", VA = "0x26647EC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x26647F4", Offset = "0x26647F4", VA = "0x26647F4")]
			internal void <Translate>b__0(Dictionary<string, TranslationQuery> results, string error)
			{
			}
		}

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DACC", Offset = "0xA6DACC")]
		private sealed class <WaitForTranslations>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000001")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000073")]
				[Address(RVA = "0x2664AE8", Offset = "0x2664AE8", VA = "0x2664AE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000002")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000075")]
				[Address(RVA = "0x2664B30", Offset = "0x2664B30", VA = "0x2664B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2664904", Offset = "0x2664904", VA = "0x2664904")]
			[DebuggerHidden]
			public <WaitForTranslations>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2664930", Offset = "0x2664930", VA = "0x2664930", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2664934", Offset = "0x2664934", VA = "0x2664934", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2664AF0", Offset = "0x2664AF0", VA = "0x2664AF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x22F0CF4", Offset = "0x22F0CF4", VA = "0x22F0CF4")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x22F0DB0", Offset = "0x22F0DB0", VA = "0x22F0DB0")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, Action<string, string> OnTranslationReady)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x22F1344", Offset = "0x22F1344", VA = "0x22F1344")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x22F12A8", Offset = "0x22F12A8", VA = "0x22F12A8")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, Action<Dictionary<string, TranslationQuery>, string> OnTranslationReady, bool usePOST = true)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x22F19E0", Offset = "0x22F19E0", VA = "0x22F19E0")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x22F1A64", Offset = "0x22F1A64", VA = "0x22F1A64")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x22F1904", Offset = "0x22F1904", VA = "0x22F1904")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x22F2004", Offset = "0x22F2004", VA = "0x22F2004")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6DFB4", Offset = "0xA6DFB4")]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x22F2060", Offset = "0x22F2060", VA = "0x22F2060")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x22F27D4", Offset = "0x22F27D4", VA = "0x22F27D4")]
		public static bool IsTranslating()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x22F289C", Offset = "0x22F289C", VA = "0x22F289C")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x22F1098", Offset = "0x22F1098", VA = "0x22F1098")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x22F2A58", Offset = "0x22F2A58", VA = "0x22F2A58")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x22F14AC", Offset = "0x22F14AC", VA = "0x22F14AC")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x22F34C4", Offset = "0x22F34C4", VA = "0x22F34C4")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x22F2564", Offset = "0x22F2564", VA = "0x22F2564")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default(TranslationQuery);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x22F2CF0", Offset = "0x22F2CF0", VA = "0x22F2CF0")]
		public static bool HasParameters(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x22F2EB4", Offset = "0x22F2EB4", VA = "0x22F2EB4")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x22F2D88", Offset = "0x22F2D88", VA = "0x22F2D88")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x22F35D0", Offset = "0x22F35D0", VA = "0x22F35D0")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x22F2720", Offset = "0x22F2720", VA = "0x22F2720")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x22F2FAC", Offset = "0x22F2FAC", VA = "0x22F2FAC")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x22F17E0", Offset = "0x22F17E0", VA = "0x22F17E0")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x22F3748", Offset = "0x22F3748", VA = "0x22F3748")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x22F3A0C", Offset = "0x22F3A0C", VA = "0x22F3A0C")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x22F3D94", Offset = "0x22F3D94", VA = "0x22F3D94")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x22F1F44", Offset = "0x22F1F44", VA = "0x22F1F44")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
	[Token(Token = "0x2000016")]
	public struct TranslationQuery
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OrigText;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string LanguageCode;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] Results;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Tags;
	}
	[Token(Token = "0x2000017")]
	public class TranslationJob : IDisposable
	{
		[Token(Token = "0x2000018")]
		public enum eJobState
		{
			[Token(Token = "0x400002E")]
			Running,
			[Token(Token = "0x400002F")]
			Succeeded,
			[Token(Token = "0x4000030")]
			Failed
		}

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public eJobState mJobState;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2662E00", Offset = "0x2662E00", VA = "0x2662E00", Slot = "5")]
		public virtual eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2662E08", Offset = "0x2662E08", VA = "0x2662E08", Slot = "6")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2662E0C", Offset = "0x2662E0C", VA = "0x2662E0C")]
		public TranslationJob()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class TranslationJob_WWW : TranslationJob
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest www;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x26647B4", Offset = "0x26647B4", VA = "0x26647B4", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2662ED8", Offset = "0x2662ED8", VA = "0x2662ED8")]
		public TranslationJob_WWW()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<Dictionary<string, TranslationQuery>, string> _OnTranslationReady;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> mQueries;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mErrorMessage;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2662E14", Offset = "0x2662E14", VA = "0x2662E14")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, Action<Dictionary<string, TranslationQuery>, string> OnTranslationReady)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2662EE0", Offset = "0x2662EE0", VA = "0x2662EE0")]
		private void ExecuteNextQuery()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2663000", Offset = "0x2663000", VA = "0x2663000", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x26630B8", Offset = "0x26630B8", VA = "0x26630B8")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class TranslationJob_Main : TranslationJob
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TranslationJob_WEB mWeb;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TranslationJob_POST mPost;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TranslationJob_GET mGet;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action<Dictionary<string, TranslationQuery>, string> _OnTranslationReady;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mErrorMessage;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x26631EC", Offset = "0x26631EC", VA = "0x26631EC")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, Action<Dictionary<string, TranslationQuery>, string> OnTranslationReady)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2663454", Offset = "0x2663454", VA = "0x2663454", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2663670", Offset = "0x2663670", VA = "0x2663670", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<Dictionary<string, TranslationQuery>, string> _OnTranslationReady;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2663290", Offset = "0x2663290", VA = "0x2663290")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, Action<Dictionary<string, TranslationQuery>, string> OnTranslationReady)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x26636D4", Offset = "0x26636D4", VA = "0x26636D4", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x266377C", Offset = "0x266377C", VA = "0x266377C")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		[Serializable]
		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DADC", Offset = "0xA6DADC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<KeyValuePair<string, string>> <>9__8_0;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static MatchEvaluator <>9__12_0;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static MatchEvaluator <>9__12_1;

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2667528", Offset = "0x2667528", VA = "0x2667528")]
			public <>c()
			{
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2667530", Offset = "0x2667530", VA = "0x2667530")]
			internal int <FindAllQueries>b__8_0(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
			{
				return default(int);
			}

			[Token(Token = "0x600008E")]
			[Address(RVA = "0x266758C", Offset = "0x266758C", VA = "0x266758C")]
			internal string <ParseTranslationResult>b__12_0(Match match)
			{
				return null;
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2667638", Offset = "0x2667638", VA = "0x2667638")]
			internal string <ParseTranslationResult>b__12_1(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<Dictionary<string, TranslationQuery>, string> _OnTranslationReady;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mErrorMessage;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string mCurrentBatch_ToLanguageCode;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mCurrentBatch_FromLanguageCode;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> mCurrentBatch_Text;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<KeyValuePair<string, string>> mQueries;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2663884", Offset = "0x2663884", VA = "0x2663884")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, Action<Dictionary<string, TranslationQuery>, string> OnTranslationReady)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x26638E4", Offset = "0x26638E4", VA = "0x26638E4")]
		private void FindAllQueries()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2663C54", Offset = "0x2663C54", VA = "0x2663C54")]
		private void ExecuteNextBatch()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2664054", Offset = "0x2664054", VA = "0x2664054", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x266410C", Offset = "0x266410C", VA = "0x266410C")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2664258", Offset = "0x2664258", VA = "0x2664258")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public enum eLanguageDataFlags
	{
		[Token(Token = "0x400004A")]
		DISABLED = 1,
		[Token(Token = "0x400004B")]
		KEEP_LOADED = 2,
		[Token(Token = "0x400004C")]
		NOT_LOADED = 4
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class LanguageData
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x148D6C8", Offset = "0x148D6C8", VA = "0x148D6C8")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x148D6D8", Offset = "0x148D6D8", VA = "0x148D6D8")]
		public void SetEnabled(bool bEnabled)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x148D6F4", Offset = "0x148D6F4", VA = "0x148D6F4")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x148D704", Offset = "0x148D704", VA = "0x148D704")]
		public bool CanBeUnloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x148D714", Offset = "0x148D714", VA = "0x148D714")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x148D730", Offset = "0x148D730", VA = "0x148D730")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x148D74C", Offset = "0x148D74C", VA = "0x148D74C")]
		public LanguageData()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6DAEC", Offset = "0xA6DAEC")]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool NeverDestroy;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UnityEngine.Object> Assets;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<TermData> mTerms;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string mTerm_AppName;

		[Token(Token = "0x17000003")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x148D754", Offset = "0x148D754", VA = "0x148D754", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x148D75C", Offset = "0x148D75C", VA = "0x148D75C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<LanguageSourceData, bool, string> Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x148D764", Offset = "0x148D764", VA = "0x148D764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E064", Offset = "0xA6E064")]
			add
			{
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x148D804", Offset = "0x148D804", VA = "0x148D804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E074", Offset = "0xA6E074")]
			remove
			{
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x148D8A4", Offset = "0x148D8A4", VA = "0x148D8A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x148D95C", Offset = "0x148D95C", VA = "0x148D95C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x148D9DC", Offset = "0x148D9DC", VA = "0x148D9DC")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x148DAD8", Offset = "0x148DAD8", VA = "0x148DAD8", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x148DAE4", Offset = "0x148DAE4", VA = "0x148DAE4", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x148E1E8", Offset = "0x148E1E8", VA = "0x148E1E8")]
		public LanguageSource()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xA6DB38", Offset = "0xA6DB38")]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x17000004")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x148E358", Offset = "0x148E358", VA = "0x148E358", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x148E360", Offset = "0x148E360", VA = "0x148E360", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x148E368", Offset = "0x148E368", VA = "0x148E368")]
		public LanguageSourceAsset()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public interface ILanguageSource
	{
		[Token(Token = "0x17000005")]
		LanguageSourceData SourceData
		{
			[Token(Token = "0x60000A4")]
			get;
			[Token(Token = "0x60000A5")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x2000025")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x4000083")]
			Empty,
			[Token(Token = "0x4000084")]
			Fallback,
			[Token(Token = "0x4000085")]
			ShowWarning,
			[Token(Token = "0x4000086")]
			ShowTerm
		}

		[Token(Token = "0x2000026")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x4000088")]
			Never,
			[Token(Token = "0x4000089")]
			OnlyInDevice,
			[Token(Token = "0x400008A")]
			EditorAndDevice
		}

		[Token(Token = "0x2000027")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x400008C")]
			Always,
			[Token(Token = "0x400008D")]
			Never,
			[Token(Token = "0x400008E")]
			Daily,
			[Token(Token = "0x400008F")]
			Weekly,
			[Token(Token = "0x4000090")]
			Monthly,
			[Token(Token = "0x4000091")]
			OnlyOnce
		}

		[Token(Token = "0x2000028")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x4000093")]
			Manual,
			[Token(Token = "0x4000094")]
			OnSceneLoaded,
			[Token(Token = "0x4000095")]
			AsSoonAsDownloaded
		}

		[Serializable]
		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DBB4", Offset = "0xA6DBB4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> <>9__38_0;

			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> <>9__38_1;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__38_2;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__38_3;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Comparison<TermData> <>9__42_0;

			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Comparison<TermData> <>9__46_0;

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x266617C", Offset = "0x266617C", VA = "0x266617C")]
			public <>c()
			{
			}

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2666184", Offset = "0x2666184", VA = "0x2666184")]
			internal bool <UpdateAssetDictionary>b__38_0(UnityEngine.Object x)
			{
				return default(bool);
			}

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x26661EC", Offset = "0x26661EC", VA = "0x26661EC")]
			internal string <UpdateAssetDictionary>b__38_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x2666208", Offset = "0x2666208", VA = "0x2666208")]
			internal string <UpdateAssetDictionary>b__38_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x26662B0", Offset = "0x26662B0", VA = "0x26662B0")]
			internal UnityEngine.Object <UpdateAssetDictionary>b__38_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x26662FC", Offset = "0x26662FC", VA = "0x26662FC")]
			internal int <Export_I2CSV>b__42_0(TermData a, TermData b)
			{
				return default(int);
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2666324", Offset = "0x2666324", VA = "0x2666324")]
			internal int <Export_CSV>b__46_0(TermData a, TermData b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DBC4", Offset = "0xA6DBC4")]
		private sealed class <Import_Google_Coroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData <>4__this;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool JustCheck;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000FF")]
				[Address(RVA = "0x26666B4", Offset = "0x26666B4", VA = "0x26666B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000101")]
				[Address(RVA = "0x26666FC", Offset = "0x26666FC", VA = "0x26666FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x266634C", Offset = "0x266634C", VA = "0x266634C")]
			[DebuggerHidden]
			public <Import_Google_Coroutine>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2666378", Offset = "0x2666378", VA = "0x2666378", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x266637C", Offset = "0x266637C", VA = "0x266637C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x26666BC", Offset = "0x26666BC", VA = "0x26666BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x17000006")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x148E3D4", Offset = "0x148E3D4", VA = "0x148E3D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<LanguageSourceData, bool, string> Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x148E148", Offset = "0x148E148", VA = "0x148E148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E084", Offset = "0xA6E084")]
			add
			{
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x148E454", Offset = "0x148E454", VA = "0x148E454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E094", Offset = "0xA6E094")]
			remove
			{
			}
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x148D8E0", Offset = "0x148D8E0", VA = "0x148D8E0")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x148D97C", Offset = "0x148D97C", VA = "0x148D97C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x148EFEC", Offset = "0x148EFEC", VA = "0x148EFEC")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x148F5A0", Offset = "0x148F5A0", VA = "0x148F5A0")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x148F6C8", Offset = "0x148F6C8", VA = "0x148F6C8")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x148F788", Offset = "0x148F788", VA = "0x148F788")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x148EA70", Offset = "0x148EA70", VA = "0x148EA70")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x148F790", Offset = "0x148F790", VA = "0x148F790")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x148F868", Offset = "0x148F868", VA = "0x148F868")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x148F8CC", Offset = "0x148F8CC", VA = "0x148F8CC")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x148F974", Offset = "0x148F974", VA = "0x148F974")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x14900C8", Offset = "0x14900C8", VA = "0x14900C8")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1490350", Offset = "0x1490350", VA = "0x1490350")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x149042C", Offset = "0x149042C", VA = "0x149042C")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1490A00", Offset = "0x1490A00", VA = "0x1490A00")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x14913A4", Offset = "0x14913A4", VA = "0x14913A4")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x149123C", Offset = "0x149123C", VA = "0x149123C")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1491634", Offset = "0x1491634", VA = "0x1491634")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x14917BC", Offset = "0x14917BC", VA = "0x14917BC")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x149198C", Offset = "0x149198C", VA = "0x149198C")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1491FDC", Offset = "0x1491FDC", VA = "0x1491FDC")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1492D28", Offset = "0x1492D28", VA = "0x1492D28")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x149210C", Offset = "0x149210C", VA = "0x149210C")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1492F68", Offset = "0x1492F68", VA = "0x1492F68")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x14933A4", Offset = "0x14933A4", VA = "0x14933A4")]
		public static eTermType GetTermType(string type)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1493630", Offset = "0x1493630", VA = "0x1493630")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1493878", Offset = "0x1493878", VA = "0x1493878")]
		public static void FreeUnusedLanguages()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1493A58", Offset = "0x1493A58", VA = "0x1493A58")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x14940E8", Offset = "0x14940E8", VA = "0x14940E8")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x149495C", Offset = "0x149495C", VA = "0x149495C")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1493CC4", Offset = "0x1493CC4", VA = "0x1493CC4")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1494CA4", Offset = "0x1494CA4", VA = "0x1494CA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E0A4", Offset = "0xA6E0A4")]
		private IEnumerator Import_Google_Coroutine(bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1494D30", Offset = "0x1494D30", VA = "0x1494D30")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1494DF4", Offset = "0x1494DF4", VA = "0x1494DF4")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1494F88", Offset = "0x1494F88", VA = "0x1494F88")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1495104", Offset = "0x1495104", VA = "0x1495104")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1494300", Offset = "0x1494300", VA = "0x1494300")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x148F16C", Offset = "0x148F16C", VA = "0x148F16C")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default(int);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1495508", Offset = "0x1495508", VA = "0x1495508")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x14955A4", Offset = "0x14955A4", VA = "0x14955A4")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x149300C", Offset = "0x149300C", VA = "0x149300C")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1495328", Offset = "0x1495328", VA = "0x1495328")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default(int);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x149565C", Offset = "0x149565C", VA = "0x149565C")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x14956F4", Offset = "0x14956F4", VA = "0x14956F4")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1495790", Offset = "0x1495790", VA = "0x1495790")]
		public void AddLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1495814", Offset = "0x1495814", VA = "0x1495814")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x14959EC", Offset = "0x14959EC", VA = "0x14959EC")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1495D1C", Offset = "0x1495D1C", VA = "0x1495D1C")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1495E74", Offset = "0x1495E74", VA = "0x1495E74")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1496040", Offset = "0x1496040", VA = "0x1496040")]
		public bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x14960E8", Offset = "0x14960E8", VA = "0x14960E8")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1496198", Offset = "0x1496198", VA = "0x1496198")]
		public bool AllowUnloadingLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x14961A8", Offset = "0x14961A8", VA = "0x14961A8")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x14963E4", Offset = "0x14963E4", VA = "0x14963E4")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1496874", Offset = "0x1496874", VA = "0x1496874")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1496614", Offset = "0x1496614", VA = "0x1496614")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x149351C", Offset = "0x149351C", VA = "0x149351C")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1493470", Offset = "0x1493470", VA = "0x1493470")]
		public bool HasUnloadedLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1491D8C", Offset = "0x1491D8C", VA = "0x1491D8C")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1496ADC", Offset = "0x1496ADC", VA = "0x1496ADC")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x14969D8", Offset = "0x14969D8", VA = "0x14969D8")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1496BBC", Offset = "0x1496BBC", VA = "0x1496BBC")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x148E720", Offset = "0x148E720", VA = "0x148E720")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1496D10", Offset = "0x1496D10", VA = "0x1496D10")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1496DB8", Offset = "0x1496DB8", VA = "0x1496DB8")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1490700", Offset = "0x1490700", VA = "0x1490700")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1497028", Offset = "0x1497028", VA = "0x1497028")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x148F36C", Offset = "0x148F36C", VA = "0x148F36C")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1497244", Offset = "0x1497244", VA = "0x1497244")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1497264", Offset = "0x1497264", VA = "0x1497264")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1497034", Offset = "0x1497034", VA = "0x1497034")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x149747C", Offset = "0x149747C", VA = "0x149747C")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x14931D4", Offset = "0x14931D4", VA = "0x14931D4")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x148DEAC", Offset = "0x148DEAC", VA = "0x148DEAC")]
		public LanguageSourceData()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public enum eSpreadsheetUpdateMode
	{
		[Token(Token = "0x40000A3")]
		None,
		[Token(Token = "0x40000A4")]
		Replace,
		[Token(Token = "0x40000A5")]
		Merge,
		[Token(Token = "0x40000A6")]
		AddNewTerms
	}
	[Token(Token = "0x200002C")]
	public class LocalizationReader
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x149F1CC", Offset = "0x149F1CC", VA = "0x149F1CC")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x149F458", Offset = "0x149F458", VA = "0x149F458")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x149F8EC", Offset = "0x149F8EC", VA = "0x149F8EC")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1492024", Offset = "0x1492024", VA = "0x1492024")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x149FAE8", Offset = "0x149FAE8", VA = "0x149FAE8")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x149FCDC", Offset = "0x149FCDC", VA = "0x149FCDC")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1492D6C", Offset = "0x1492D6C", VA = "0x1492D6C")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x149F840", Offset = "0x149F840", VA = "0x149F840")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x149FE18", Offset = "0x149FE18", VA = "0x149FE18")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x149F794", Offset = "0x149F794", VA = "0x149F794")]
		public static string DecodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x149FF14", Offset = "0x149FF14", VA = "0x149FF14")]
		public LocalizationReader()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6DBD4", Offset = "0xA6DBD4")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x200002E")]
		public enum TermModification
		{
			[Token(Token = "0x40000C7")]
			DontModify,
			[Token(Token = "0x40000C8")]
			ToUpper,
			[Token(Token = "0x40000C9")]
			ToLower,
			[Token(Token = "0x40000CA")]
			ToUpperFirst,
			[Token(Token = "0x40000CB")]
			ToTitle
		}

		[Serializable]
		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DC0C", Offset = "0xA6DC0C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> <>9__49_0;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> <>9__49_1;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<UnityEngine.Object, string> <>9__49_2;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__49_3;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__49_4;

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2667328", Offset = "0x2667328", VA = "0x2667328")]
			public <>c()
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2667330", Offset = "0x2667330", VA = "0x2667330")]
			internal bool <UpdateAssetDictionary>b__49_0(UnityEngine.Object x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x2667398", Offset = "0x2667398", VA = "0x2667398")]
			internal string <UpdateAssetDictionary>b__49_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x26673B4", Offset = "0x26673B4", VA = "0x26673B4")]
			internal string <UpdateAssetDictionary>b__49_2(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x26673D0", Offset = "0x26673D0", VA = "0x26673D0")]
			internal string <UpdateAssetDictionary>b__49_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2667478", Offset = "0x2667478", VA = "0x2667478")]
			internal UnityEngine.Object <UpdateAssetDictionary>b__49_4(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}
		}

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mTerm;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string TermPrefix;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string TermSuffix;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IgnoreRTL;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string mLocalizeTargetName;

		[Token(Token = "0x17000009")]
		public string Term
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x149FF1C", Offset = "0x149FF1C", VA = "0x149FF1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x149FF24", Offset = "0x149FF24", VA = "0x149FF24")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public string SecondaryTerm
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x149FF80", Offset = "0x149FF80", VA = "0x149FF80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x149FF88", Offset = "0x149FF88", VA = "0x149FF88")]
			set
			{
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x14A0018", Offset = "0x14A0018", VA = "0x14A0018")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x14A0AAC", Offset = "0x14A0AAC", VA = "0x14A0AAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x14A0AB4", Offset = "0x14A0AB4", VA = "0x14A0AB4")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x149D564", Offset = "0x149D564", VA = "0x149D564")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x14A0530", Offset = "0x14A0530", VA = "0x14A0530")]
		public bool FindTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x14A0B08", Offset = "0x14A0B08", VA = "0x14A0B08")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x14A0CC0", Offset = "0x14A0CC0", VA = "0x14A0CC0")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x14A0D94", Offset = "0x14A0D94", VA = "0x14A0D94")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x149FF28", Offset = "0x149FF28", VA = "0x149FF28")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x149FF94", Offset = "0x149FF94", VA = "0x149FF94")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x600011B")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x14A005C", Offset = "0x14A005C", VA = "0x14A005C")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x600011D")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x14A0DF0", Offset = "0x14A0DF0", VA = "0x14A0DF0")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		}

		[Token(Token = "0x6000120")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x14A0F04", Offset = "0x14A0F04", VA = "0x14A0F04")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x14A0F98", Offset = "0x14A0F98", VA = "0x14A0F98")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x14A1040", Offset = "0x14A1040", VA = "0x14A1040")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x14A10A0", Offset = "0x14A10A0", VA = "0x14A10A0")]
		public Localize()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6DC1C", Offset = "0xA6DC1C")]
	public class LocalizeDropdown : MonoBehaviour
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> _Terms;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x14A12C0", Offset = "0x14A12C0", VA = "0x14A12C0")]
		public void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x14A146C", Offset = "0x14A146C", VA = "0x14A146C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x14A1510", Offset = "0x14A1510", VA = "0x14A1510")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x14A136C", Offset = "0x14A136C", VA = "0x14A136C")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x14A156C", Offset = "0x14A156C", VA = "0x14A156C")]
		private void FillValues()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x14A1740", Offset = "0x14A1740", VA = "0x14A1740")]
		public void UpdateLocalization()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x14A1B90", Offset = "0x14A1B90", VA = "0x14A1B90")]
		public void UpdateLocalizationTMPro()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x14A19D4", Offset = "0x14A19D4", VA = "0x14A19D4")]
		private void FillValuesTMPro()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x14A1E18", Offset = "0x14A1E18", VA = "0x14A1E18")]
		public LocalizeDropdown()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public static class LocalizationManager
	{
		[Token(Token = "0x2000032")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x2000033")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DC54", Offset = "0xA6DC54")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x26667D8", Offset = "0x26667D8", VA = "0x26667D8")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x26667E0", Offset = "0x26667E0", VA = "0x26667E0")]
			internal bool <GetAllLanguages>b__0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DC64", Offset = "0xA6DC64")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;

			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2666850", Offset = "0x2666850", VA = "0x2666850")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2666858", Offset = "0x2666858", VA = "0x2666858")]
			internal bool <GetAllLanguagesCode>b__0(string x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DC74", Offset = "0xA6DC74")]
		private sealed class <>c
		{
			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static _GetParam <>9__41_0;

			[Token(Token = "0x6000184")]
			[Address(RVA = "0x2666768", Offset = "0x2666768", VA = "0x2666768")]
			public <>c()
			{
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2666770", Offset = "0x2666770", VA = "0x2666770")]
			internal object <ApplyLocalizationParams>b__41_0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DC84", Offset = "0xA6DC84")]
		private sealed class <>c__DisplayClass42_0
		{
			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject root;

			[Token(Token = "0x6000186")]
			[Address(RVA = "0x26668C8", Offset = "0x26668C8", VA = "0x26668C8")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x26668D0", Offset = "0x26668D0", VA = "0x26668D0")]
			internal object <ApplyLocalizationParams>b__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DC94", Offset = "0xA6DC94")]
		private sealed class <>c__DisplayClass43_0
		{
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, object> parameters;

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x2666948", Offset = "0x2666948", VA = "0x2666948")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2666950", Offset = "0x2666950", VA = "0x2666950")]
			internal object <ApplyLocalizationParams>b__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DCA4", Offset = "0xA6DCA4")]
		private sealed class <Delayed_Import_Google>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x17000010")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600018D")]
				[Address(RVA = "0x2666C5C", Offset = "0x2666C5C", VA = "0x2666C5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0x2666CA4", Offset = "0x2666CA4", VA = "0x2666CA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2666B6C", Offset = "0x2666B6C", VA = "0x2666B6C")]
			[DebuggerHidden]
			public <Delayed_Import_Google>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2666B98", Offset = "0x2666B98", VA = "0x2666B98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2666B9C", Offset = "0x2666B9C", VA = "0x2666B9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x2666C64", Offset = "0x2666C64", VA = "0x2666C64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DCB4", Offset = "0xA6DCB4")]
		private sealed class <>c__DisplayClass69_0
		{
			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ILocalizeTargetDescriptor desc;

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x26669CC", Offset = "0x26669CC", VA = "0x26669CC")]
			public <>c__DisplayClass69_0()
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x26669D4", Offset = "0x26669D4", VA = "0x26669D4")]
			internal bool <RegisterTarget>b__0(ILocalizeTargetDescriptor x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DCC4", Offset = "0xA6DCC4")]
		private sealed class <Coroutine_LocalizeAll>d__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000195")]
				[Address(RVA = "0x2666B1C", Offset = "0x2666B1C", VA = "0x2666B1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000197")]
				[Address(RVA = "0x2666B64", Offset = "0x2666B64", VA = "0x2666B64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2666A00", Offset = "0x2666A00", VA = "0x2666A00")]
			[DebuggerHidden]
			public <Coroutine_LocalizeAll>d__87(int <>1__state)
			{
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2666A2C", Offset = "0x2666A2C", VA = "0x2666A2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2666A30", Offset = "0x2666A30", VA = "0x2666A30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2666B24", Offset = "0x2666B24", VA = "0x2666B24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool allowRememberLanguage;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mCurrentLanguage;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string mLanguageCode;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public static bool IsRight2Left;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public static bool HasJoinedWords;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] GlobalSources;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public static bool showKeys;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static bool showKeysOnError;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public static bool showValuesTwice;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string platform;

		[Token(Token = "0x1700000B")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x14939F0", Offset = "0x14939F0", VA = "0x14939F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1497D88", Offset = "0x1497D88", VA = "0x1497D88")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1498964", Offset = "0x1498964", VA = "0x1498964")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x14989CC", Offset = "0x14989CC", VA = "0x14989CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public static string CurrentRegion
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x1498CDC", Offset = "0x1498CDC", VA = "0x1498CDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1498E5C", Offset = "0x1498E5C", VA = "0x1498E5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1499028", Offset = "0x1499028", VA = "0x1499028")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1499104", Offset = "0x1499104", VA = "0x1499104")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x149921C", Offset = "0x149921C", VA = "0x149921C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000003")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x149C9AC", Offset = "0x149C9AC", VA = "0x149C9AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E1B4", Offset = "0xA6E1B4")]
			add
			{
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x149CAA4", Offset = "0x149CAA4", VA = "0x149CAA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E1C4", Offset = "0xA6E1C4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1497648", Offset = "0x1497648", VA = "0x1497648")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1497D44", Offset = "0x1497D44", VA = "0x1497D44")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x14951A0", Offset = "0x14951A0", VA = "0x14951A0")]
		public static int GetRequiredWebServiceVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1491BA4", Offset = "0x1491BA4", VA = "0x1491BA4")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1498534", Offset = "0x1498534", VA = "0x1498534")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1499280", Offset = "0x1499280", VA = "0x1499280")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x14994B4", Offset = "0x14994B4", VA = "0x14994B4")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x14993A0", Offset = "0x14993A0", VA = "0x14993A0")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x14977B4", Offset = "0x14977B4", VA = "0x14977B4")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1499564", Offset = "0x1499564", VA = "0x1499564")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1497E74", Offset = "0x1497E74", VA = "0x1497E74")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1498324", Offset = "0x1498324", VA = "0x1498324")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1498ABC", Offset = "0x1498ABC", VA = "0x1498ABC")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x149984C", Offset = "0x149984C", VA = "0x149984C")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1499B2C", Offset = "0x1499B2C", VA = "0x1499B2C")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1499DC0", Offset = "0x1499DC0", VA = "0x1499DC0")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1499EE0", Offset = "0x1499EE0", VA = "0x1499EE0")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x149A040", Offset = "0x149A040", VA = "0x149A040")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x149A148", Offset = "0x149A148", VA = "0x149A148")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x149A6C8", Offset = "0x149A6C8", VA = "0x149A6C8")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x149A7C4", Offset = "0x149A7C4", VA = "0x149A7C4")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x149A278", Offset = "0x149A278", VA = "0x149A278")]
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x149AA58", Offset = "0x149AA58", VA = "0x149AA58")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x149AD3C", Offset = "0x149AD3C", VA = "0x149AD3C")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x149AF20", Offset = "0x149AF20", VA = "0x149AF20")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x149AF88", Offset = "0x149AF88", VA = "0x149AF88")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x149B678", Offset = "0x149B678", VA = "0x149B678")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1499424", Offset = "0x1499424", VA = "0x1499424")]
		public static bool IsRTL(string Code)
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1497724", Offset = "0x1497724", VA = "0x1497724")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x149B728", Offset = "0x149B728", VA = "0x149B728")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x149BA54", Offset = "0x149BA54", VA = "0x149BA54")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x149B878", Offset = "0x149B878", VA = "0x149B878")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x148E4F4", Offset = "0x148E4F4", VA = "0x148E4F4")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x149BC0C", Offset = "0x149BC0C", VA = "0x149BC0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E154", Offset = "0xA6E154")]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x148EF60", Offset = "0x148EF60", VA = "0x148EF60")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x149BCA8", Offset = "0x149BCA8", VA = "0x149BCA8")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x149BD38", Offset = "0x149BD38", VA = "0x149BD38")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x149BF38", Offset = "0x149BF38", VA = "0x149BF38")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x149C098", Offset = "0x149C098", VA = "0x149C098")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1499784", Offset = "0x1499784", VA = "0x1499784")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x149C198", Offset = "0x149C198", VA = "0x149C198")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x149C700", Offset = "0x149C700", VA = "0x149C700")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x149CB9C", Offset = "0x149CB9C", VA = "0x149CB9C")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x149D064", Offset = "0x149D064", VA = "0x149D064")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x149CC5C", Offset = "0x149CC5C", VA = "0x149CC5C")]
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		public static T GetTranslatedObject<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x149D10C", Offset = "0x149D10C", VA = "0x149D10C")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x148EE5C", Offset = "0x148EE5C", VA = "0x148EE5C")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x149D508", Offset = "0x149D508", VA = "0x149D508")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E1D4", Offset = "0xA6E1D4")]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x149D370", Offset = "0x149D370", VA = "0x149D370")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x149DECC", Offset = "0x149DECC", VA = "0x149DECC")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x149E01C", Offset = "0x149E01C", VA = "0x149E01C")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x149E2B4", Offset = "0x149E2B4", VA = "0x149E2B4")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x149A8C0", Offset = "0x149A8C0", VA = "0x149A8C0")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x6000198")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x6000199")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x600019A")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x600019B")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x600019C")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x600019D")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x600019E")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x600019F")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x22F6134", Offset = "0x22F6134", VA = "0x22F6134")]
		protected ILocalizeTarget()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x60001A1")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		protected LocalizeTarget()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x60001A3")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x60001A4")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x60001A5")]
		public abstract Type GetTargetType();

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x22F613C", Offset = "0x22F613C", VA = "0x22F613C")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x60001A7")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		protected LocalizeTargetDesc()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x60001AA")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x14A1F74", Offset = "0x14A1F74", VA = "0x14A1F74")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x14A1F78", Offset = "0x14A1F78", VA = "0x14A1F78")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E2D4", Offset = "0xA6E2D4")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x14A2048", Offset = "0x14A2048", VA = "0x14A2048", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x14A2050", Offset = "0x14A2050", VA = "0x14A2050", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x14A2058", Offset = "0x14A2058", VA = "0x14A2058", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x14A2060", Offset = "0x14A2060", VA = "0x14A2060", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x14A2068", Offset = "0x14A2068", VA = "0x14A2068", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x14A2070", Offset = "0x14A2070", VA = "0x14A2070", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x14A21A8", Offset = "0x14A21A8", VA = "0x14A21A8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x14A2814", Offset = "0x14A2814", VA = "0x14A2814")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x14A2AB4", Offset = "0x14A2AB4", VA = "0x14A2AB4")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x14A2710", Offset = "0x14A2710", VA = "0x14A2710")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x14A2990", Offset = "0x14A2990", VA = "0x14A2990")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x14A2CC8", Offset = "0x14A2CC8", VA = "0x14A2CC8")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x14A2D28", Offset = "0x14A2D28", VA = "0x14A2D28")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x14A2D2C", Offset = "0x14A2D2C", VA = "0x14A2D2C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E2E8", Offset = "0xA6E2E8")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x14A2DFC", Offset = "0x14A2DFC", VA = "0x14A2DFC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x14A2E04", Offset = "0x14A2E04", VA = "0x14A2E04", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x14A2E0C", Offset = "0x14A2E0C", VA = "0x14A2E0C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x14A2E14", Offset = "0x14A2E14", VA = "0x14A2E14", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x14A2E1C", Offset = "0x14A2E1C", VA = "0x14A2E1C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x14A2E24", Offset = "0x14A2E24", VA = "0x14A2E24", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x14A2F5C", Offset = "0x14A2F5C", VA = "0x14A2F5C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x14A34C4", Offset = "0x14A34C4", VA = "0x14A34C4")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x14A3524", Offset = "0x14A3524", VA = "0x14A3524")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x14A3528", Offset = "0x14A3528", VA = "0x14A3528")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E2FC", Offset = "0xA6E2FC")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x14A35F8", Offset = "0x14A35F8", VA = "0x14A35F8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x14A3600", Offset = "0x14A3600", VA = "0x14A3600", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x14A3608", Offset = "0x14A3608", VA = "0x14A3608", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x14A3610", Offset = "0x14A3610", VA = "0x14A3610", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x14A3618", Offset = "0x14A3618", VA = "0x14A3618", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x14A3620", Offset = "0x14A3620", VA = "0x14A3620", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x14A3714", Offset = "0x14A3714", VA = "0x14A3714", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x14A3898", Offset = "0x14A3898", VA = "0x14A3898")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x14A1E9C", Offset = "0x14A1E9C", VA = "0x14A1E9C", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x14A1ED4", Offset = "0x14A1ED4", VA = "0x14A1ED4")]
		public LocalizeTargetDesc_Child()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x14A38E4", Offset = "0x14A38E4", VA = "0x14A38E4")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x14A38E8", Offset = "0x14A38E8", VA = "0x14A38E8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E310", Offset = "0xA6E310")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x14A39A0", Offset = "0x14A39A0", VA = "0x14A39A0", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x14A39D8", Offset = "0x14A39D8", VA = "0x14A39D8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x14A39E0", Offset = "0x14A39E0", VA = "0x14A39E0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x14A39E8", Offset = "0x14A39E8", VA = "0x14A39E8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x14A39F0", Offset = "0x14A39F0", VA = "0x14A39F0", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x14A39F8", Offset = "0x14A39F8", VA = "0x14A39F8", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x14A3A00", Offset = "0x14A3A00", VA = "0x14A3A00", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x14A3A50", Offset = "0x14A3A50", VA = "0x14A3A50", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x14A3BA4", Offset = "0x14A3BA4", VA = "0x14A3BA4")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x14A3BF0", Offset = "0x14A3BF0", VA = "0x14A3BF0")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x14A3BF4", Offset = "0x14A3BF4", VA = "0x14A3BF4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E324", Offset = "0xA6E324")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x14A3CC4", Offset = "0x14A3CC4", VA = "0x14A3CC4", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x14A3CCC", Offset = "0x14A3CCC", VA = "0x14A3CCC", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x14A3CD4", Offset = "0x14A3CD4", VA = "0x14A3CD4", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x14A3CDC", Offset = "0x14A3CDC", VA = "0x14A3CDC", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x14A3CE4", Offset = "0x14A3CE4", VA = "0x14A3CE4", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x14A3CEC", Offset = "0x14A3CEC", VA = "0x14A3CEC", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x14A3F10", Offset = "0x14A3F10", VA = "0x14A3F10", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x14A4108", Offset = "0x14A4108", VA = "0x14A4108")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x14A1F20", Offset = "0x14A1F20", VA = "0x14A1F20", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x14A1F28", Offset = "0x14A1F28", VA = "0x14A1F28")]
		public LocalizeTargetDesc_Prefab()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x14A4154", Offset = "0x14A4154", VA = "0x14A4154")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x14A4158", Offset = "0x14A4158", VA = "0x14A4158")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E338", Offset = "0xA6E338")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x14A4210", Offset = "0x14A4210", VA = "0x14A4210", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x14A4218", Offset = "0x14A4218", VA = "0x14A4218", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x14A4220", Offset = "0x14A4220", VA = "0x14A4220", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x14A4228", Offset = "0x14A4228", VA = "0x14A4228", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x14A4230", Offset = "0x14A4230", VA = "0x14A4230", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x14A4238", Offset = "0x14A4238", VA = "0x14A4238", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x14A4240", Offset = "0x14A4240", VA = "0x14A4240", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x14A4290", Offset = "0x14A4290", VA = "0x14A4290", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x14A44C0", Offset = "0x14A44C0", VA = "0x14A44C0")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x14A4690", Offset = "0x14A4690", VA = "0x14A4690")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x14A46DC", Offset = "0x14A46DC", VA = "0x14A46DC")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x14A46E0", Offset = "0x14A46E0", VA = "0x14A46E0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E34C", Offset = "0xA6E34C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x14A47B0", Offset = "0x14A47B0", VA = "0x14A47B0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x14A47B8", Offset = "0x14A47B8", VA = "0x14A47B8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x14A47C0", Offset = "0x14A47C0", VA = "0x14A47C0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x14A47C8", Offset = "0x14A47C8", VA = "0x14A47C8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x14A47D0", Offset = "0x14A47D0", VA = "0x14A47D0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x14A47D8", Offset = "0x14A47D8", VA = "0x14A47D8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x14A48D0", Offset = "0x14A48D0", VA = "0x14A48D0", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x14A49D8", Offset = "0x14A49D8", VA = "0x14A49D8")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x14A4A24", Offset = "0x14A4A24", VA = "0x14A4A24")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x14A4A28", Offset = "0x14A4A28", VA = "0x14A4A28")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E360", Offset = "0xA6E360")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x14A4AF8", Offset = "0x14A4AF8", VA = "0x14A4AF8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x14A4B00", Offset = "0x14A4B00", VA = "0x14A4B00", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x14A4B08", Offset = "0x14A4B08", VA = "0x14A4B08", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x14A4B10", Offset = "0x14A4B10", VA = "0x14A4B10", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x14A4B18", Offset = "0x14A4B18", VA = "0x14A4B18", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x14A4B20", Offset = "0x14A4B20", VA = "0x14A4B20", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x14A4C58", Offset = "0x14A4C58", VA = "0x14A4C58", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x14A4EE8", Offset = "0x14A4EE8", VA = "0x14A4EE8")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x14A4F44", Offset = "0x14A4F44", VA = "0x14A4F44")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x14A4F48", Offset = "0x14A4F48", VA = "0x14A4F48")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E374", Offset = "0xA6E374")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x14A5018", Offset = "0x14A5018", VA = "0x14A5018", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x14A5020", Offset = "0x14A5020", VA = "0x14A5020", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x14A5028", Offset = "0x14A5028", VA = "0x14A5028", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x14A5030", Offset = "0x14A5030", VA = "0x14A5030", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x14A50BC", Offset = "0x14A50BC", VA = "0x14A50BC", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x14A50C4", Offset = "0x14A50C4", VA = "0x14A50C4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x14A527C", Offset = "0x14A527C", VA = "0x14A527C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x14A5378", Offset = "0x14A5378", VA = "0x14A5378")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x14A53C4", Offset = "0x14A53C4", VA = "0x14A53C4")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x14A53C8", Offset = "0x14A53C8", VA = "0x14A53C8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E388", Offset = "0xA6E388")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x14A5498", Offset = "0x14A5498", VA = "0x14A5498", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x14A54A0", Offset = "0x14A54A0", VA = "0x14A54A0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x14A54A8", Offset = "0x14A54A8", VA = "0x14A54A8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x14A54B0", Offset = "0x14A54B0", VA = "0x14A54B0", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x14A54B8", Offset = "0x14A54B8", VA = "0x14A54B8", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x14A54C0", Offset = "0x14A54C0", VA = "0x14A54C0", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x14A55BC", Offset = "0x14A55BC", VA = "0x14A55BC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x14A56B8", Offset = "0x14A56B8", VA = "0x14A56B8")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x14A5704", Offset = "0x14A5704", VA = "0x14A5704")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x14A5708", Offset = "0x14A5708", VA = "0x14A5708")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA6E39C", Offset = "0xA6E39C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x14A57D8", Offset = "0x14A57D8", VA = "0x14A57D8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x14A57E0", Offset = "0x14A57E0", VA = "0x14A57E0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x14A57E8", Offset = "0x14A57E8", VA = "0x14A57E8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x14A57F0", Offset = "0x14A57F0", VA = "0x14A57F0", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x14A57F8", Offset = "0x14A57F8", VA = "0x14A57F8", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x14A5800", Offset = "0x14A5800", VA = "0x14A5800", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x14A5948", Offset = "0x14A5948", VA = "0x14A5948", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x14A5C40", Offset = "0x14A5C40", VA = "0x14A5C40")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x14A5D00", Offset = "0x14A5D00", VA = "0x14A5D00")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public enum eTermType
	{
		[Token(Token = "0x400010C")]
		Text,
		[Token(Token = "0x400010D")]
		Font,
		[Token(Token = "0x400010E")]
		Texture,
		[Token(Token = "0x400010F")]
		AudioClip,
		[Token(Token = "0x4000110")]
		GameObject,
		[Token(Token = "0x4000111")]
		Sprite,
		[Token(Token = "0x4000112")]
		Material,
		[Token(Token = "0x4000113")]
		Child,
		[Token(Token = "0x4000114")]
		Mesh,
		[Token(Token = "0x4000115")]
		TextMeshPFont,
		[Token(Token = "0x4000116")]
		Object
	}
	[Token(Token = "0x200004F")]
	public enum TranslationFlag : byte
	{
		[Token(Token = "0x4000118")]
		Normal = 1,
		[Token(Token = "0x4000119")]
		AutoTranslated
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class TermData
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Languages;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Flags;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] Languages_Touch;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x26622D8", Offset = "0x26622D8", VA = "0x26622D8")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2662408", Offset = "0x2662408", VA = "0x2662408")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x26624FC", Offset = "0x26624FC", VA = "0x26624FC")]
		public void RemoveSpecialization(string specialization)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x266255C", Offset = "0x266255C", VA = "0x266255C")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2662714", Offset = "0x2662714", VA = "0x2662714")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2662754", Offset = "0x2662754", VA = "0x2662754")]
		public void Validate()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2662968", Offset = "0x2662968", VA = "0x2662968")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x26629FC", Offset = "0x26629FC", VA = "0x26629FC")]
		public bool HasSpecializations()
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2662AD0", Offset = "0x2662AD0", VA = "0x2662AD0")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2662BCC", Offset = "0x2662BCC", VA = "0x2662BCC")]
		public TermData()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class TermsPopup : PropertyAttribute
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DF94", Offset = "0xA6DF94")]
		private string <Filter>k__BackingField;

		[Token(Token = "0x17000014")]
		public string Filter
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2662CC4", Offset = "0x2662CC4", VA = "0x2662CC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E3B0", Offset = "0xA6E3B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2662CCC", Offset = "0x2662CCC", VA = "0x2662CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E3C0", Offset = "0xA6E3C0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2662C90", Offset = "0x2662C90", VA = "0x2662C90")]
		public TermsPopup(string filter = "")
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x22E6298", Offset = "0x22E6298", VA = "0x22E6298")]
		public void Start()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x22E62F8", Offset = "0x22E62F8", VA = "0x22E62F8")]
		public AutoChangeCultureInfo()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x17000015")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x22E6A90", Offset = "0x22E6A90", VA = "0x22E6A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x22E6BF0", Offset = "0x22E6BF0", VA = "0x22E6BF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x22E6C80", Offset = "0x22E6C80", VA = "0x22E6C80")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x22E6CB0", Offset = "0x22E6CB0", VA = "0x22E6CB0")]
		public CoroutineManager()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6DCD4", Offset = "0xA6DCD4")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x22E6CB8", Offset = "0x22E6CB8", VA = "0x22E6CB8")]
		public void Enable()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x22E6D90", Offset = "0x22E6D90", VA = "0x22E6D90")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x22E6E38", Offset = "0x22E6E38", VA = "0x22E6E38")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x22E6E54", Offset = "0x22E6E54", VA = "0x22E6E54")]
		public CustomLocalizeCallback()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class HindiFixer
	{
		[Serializable]
		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DD0C", Offset = "0xA6DD0C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__0_0;

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x2664B9C", Offset = "0x2664B9C", VA = "0x2664B9C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2664BA4", Offset = "0x2664BA4", VA = "0x2664BA4")]
			internal bool <Fix>b__0_0(char x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x22F3F6C", Offset = "0x22F3F6C", VA = "0x22F3F6C")]
		internal static string Fix(string text)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x22F4408", Offset = "0x22F4408", VA = "0x22F4408")]
		public HindiFixer()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public static class I2Utils
	{
		[Serializable]
		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DD2C", Offset = "0xA6DD2C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__6_0;

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2664C14", Offset = "0x2664C14", VA = "0x2664C14")]
			public <>c()
			{
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2664C1C", Offset = "0x2664C1C", VA = "0x2664C1C")]
			internal bool <SplitLine>b__6_0(char c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000125")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		[Token(Token = "0x4000126")]
		public const string NumberChars = "0123456789";

		[Token(Token = "0x4000127")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:";

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x22F52A0", Offset = "0x22F52A0", VA = "0x22F52A0")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x22F5374", Offset = "0x22F5374", VA = "0x22F5374")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x22F55B8", Offset = "0x22F55B8", VA = "0x22F55B8")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x22F5678", Offset = "0x22F5678", VA = "0x22F5678")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x22F5964", Offset = "0x22F5964", VA = "0x22F5964")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x22F55E4", Offset = "0x22F55E4", VA = "0x22F55E4")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x22F5AB4", Offset = "0x22F5AB4", VA = "0x22F5AB4")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x22F5D54", Offset = "0x22F5D54", VA = "0x22F5D54")]
		public static bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x22F5D5C", Offset = "0x22F5D5C", VA = "0x22F5D5C")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x22F5E38", Offset = "0x22F5E38", VA = "0x22F5E38")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x22F5EA4", Offset = "0x22F5EA4", VA = "0x22F5EA4")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x22F5FEC", Offset = "0x22F5FEC", VA = "0x22F5FEC")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x22F3698", Offset = "0x22F3698", VA = "0x22F3698")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x22F611C", Offset = "0x22F611C", VA = "0x22F611C")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}
	}
	[Token(Token = "0x2000059")]
	public interface ILocalizationParamsManager
	{
		[Token(Token = "0x6000255")]
		string GetParameterValue(string Param);
	}
	[Token(Token = "0x200005A")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public struct ParamValue
		{
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x149EC7C", Offset = "0x149EC7C", VA = "0x149EC7C", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x149ED70", Offset = "0x149ED70", VA = "0x149ED70")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x149EF18", Offset = "0x149EF18", VA = "0x149EF18")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x149EFCC", Offset = "0x149EFCC", VA = "0x149EFCC", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x149EFD0", Offset = "0x149EFD0", VA = "0x149EFD0")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x149F0BC", Offset = "0x149F0BC", VA = "0x149F0BC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x149F148", Offset = "0x149F148", VA = "0x149F148")]
		public LocalizationParamsManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public struct LocalizedString
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string mTerm;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool mRTL_IgnoreArabicFix;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mRTL_MaxLineLength;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool mRTL_ConvertNumbers;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_DontLocalizeParameters;

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x14A5D5C", Offset = "0x14A5D5C", VA = "0x14A5D5C")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x14A5E24", Offset = "0x14A5E24", VA = "0x14A5E24")]
		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x14A5E68", Offset = "0x14A5E68", VA = "0x14A5E68")]
		public LocalizedString(LocalizedString str)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x14A5D60", Offset = "0x14A5D60", VA = "0x14A5D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200005D")]
	public class RTLFixer
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x14A5ECC", Offset = "0x14A5ECC", VA = "0x14A5ECC")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x14A5ED8", Offset = "0x14A5ED8", VA = "0x14A5ED8")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x149B3C4", Offset = "0x149B3C4", VA = "0x149B3C4")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x14A6EB8", Offset = "0x14A6EB8", VA = "0x14A6EB8")]
		public RTLFixer()
		{
		}
	}
	[Token(Token = "0x200005E")]
	internal enum IsolatedArabicLetters
	{
		[Token(Token = "0x4000133")]
		Hamza = 65152,
		[Token(Token = "0x4000134")]
		Alef = 65165,
		[Token(Token = "0x4000135")]
		AlefHamza = 65155,
		[Token(Token = "0x4000136")]
		WawHamza = 65157,
		[Token(Token = "0x4000137")]
		AlefMaksoor = 65159,
		[Token(Token = "0x4000138")]
		AlefMaksora = 64508,
		[Token(Token = "0x4000139")]
		HamzaNabera = 65161,
		[Token(Token = "0x400013A")]
		Ba = 65167,
		[Token(Token = "0x400013B")]
		Ta = 65173,
		[Token(Token = "0x400013C")]
		Tha2 = 65177,
		[Token(Token = "0x400013D")]
		Jeem = 65181,
		[Token(Token = "0x400013E")]
		H7aa = 65185,
		[Token(Token = "0x400013F")]
		Khaa2 = 65189,
		[Token(Token = "0x4000140")]
		Dal = 65193,
		[Token(Token = "0x4000141")]
		Thal = 65195,
		[Token(Token = "0x4000142")]
		Ra2 = 65197,
		[Token(Token = "0x4000143")]
		Zeen = 65199,
		[Token(Token = "0x4000144")]
		Seen = 65201,
		[Token(Token = "0x4000145")]
		Sheen = 65205,
		[Token(Token = "0x4000146")]
		S9a = 65209,
		[Token(Token = "0x4000147")]
		Dha = 65213,
		[Token(Token = "0x4000148")]
		T6a = 65217,
		[Token(Token = "0x4000149")]
		T6ha = 65221,
		[Token(Token = "0x400014A")]
		Ain = 65225,
		[Token(Token = "0x400014B")]
		Gain = 65229,
		[Token(Token = "0x400014C")]
		Fa = 65233,
		[Token(Token = "0x400014D")]
		Gaf = 65237,
		[Token(Token = "0x400014E")]
		Kaf = 65241,
		[Token(Token = "0x400014F")]
		Lam = 65245,
		[Token(Token = "0x4000150")]
		Meem = 65249,
		[Token(Token = "0x4000151")]
		Noon = 65253,
		[Token(Token = "0x4000152")]
		Ha = 65257,
		[Token(Token = "0x4000153")]
		Waw = 65261,
		[Token(Token = "0x4000154")]
		Ya = 65265,
		[Token(Token = "0x4000155")]
		AlefMad = 65153,
		[Token(Token = "0x4000156")]
		TaMarboota = 65171,
		[Token(Token = "0x4000157")]
		PersianPe = 64342,
		[Token(Token = "0x4000158")]
		PersianChe = 64378,
		[Token(Token = "0x4000159")]
		PersianZe = 64394,
		[Token(Token = "0x400015A")]
		PersianGaf = 64402,
		[Token(Token = "0x400015B")]
		PersianGaf2 = 64398
	}
	[Token(Token = "0x200005F")]
	internal enum GeneralArabicLetters
	{
		[Token(Token = "0x400015D")]
		Hamza = 1569,
		[Token(Token = "0x400015E")]
		Alef = 1575,
		[Token(Token = "0x400015F")]
		AlefHamza = 1571,
		[Token(Token = "0x4000160")]
		WawHamza = 1572,
		[Token(Token = "0x4000161")]
		AlefMaksoor = 1573,
		[Token(Token = "0x4000162")]
		AlefMagsora = 1609,
		[Token(Token = "0x4000163")]
		HamzaNabera = 1574,
		[Token(Token = "0x4000164")]
		Ba = 1576,
		[Token(Token = "0x4000165")]
		Ta = 1578,
		[Token(Token = "0x4000166")]
		Tha2 = 1579,
		[Token(Token = "0x4000167")]
		Jeem = 1580,
		[Token(Token = "0x4000168")]
		H7aa = 1581,
		[Token(Token = "0x4000169")]
		Khaa2 = 1582,
		[Token(Token = "0x400016A")]
		Dal = 1583,
		[Token(Token = "0x400016B")]
		Thal = 1584,
		[Token(Token = "0x400016C")]
		Ra2 = 1585,
		[Token(Token = "0x400016D")]
		Zeen = 1586,
		[Token(Token = "0x400016E")]
		Seen = 1587,
		[Token(Token = "0x400016F")]
		Sheen = 1588,
		[Token(Token = "0x4000170")]
		S9a = 1589,
		[Token(Token = "0x4000171")]
		Dha = 1590,
		[Token(Token = "0x4000172")]
		T6a = 1591,
		[Token(Token = "0x4000173")]
		T6ha = 1592,
		[Token(Token = "0x4000174")]
		Ain = 1593,
		[Token(Token = "0x4000175")]
		Gain = 1594,
		[Token(Token = "0x4000176")]
		Fa = 1601,
		[Token(Token = "0x4000177")]
		Gaf = 1602,
		[Token(Token = "0x4000178")]
		Kaf = 1603,
		[Token(Token = "0x4000179")]
		Lam = 1604,
		[Token(Token = "0x400017A")]
		Meem = 1605,
		[Token(Token = "0x400017B")]
		Noon = 1606,
		[Token(Token = "0x400017C")]
		Ha = 1607,
		[Token(Token = "0x400017D")]
		Waw = 1608,
		[Token(Token = "0x400017E")]
		Ya = 1610,
		[Token(Token = "0x400017F")]
		AlefMad = 1570,
		[Token(Token = "0x4000180")]
		TaMarboota = 1577,
		[Token(Token = "0x4000181")]
		PersianPe = 1662,
		[Token(Token = "0x4000182")]
		PersianChe = 1670,
		[Token(Token = "0x4000183")]
		PersianZe = 1688,
		[Token(Token = "0x4000184")]
		PersianGaf = 1711,
		[Token(Token = "0x4000185")]
		PersianGaf2 = 1705
	}
	[Token(Token = "0x2000060")]
	internal class ArabicMapping
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int from;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int to;

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x22E556C", Offset = "0x22E556C", VA = "0x22E556C")]
		public ArabicMapping(int from, int to)
		{
		}
	}
	[Token(Token = "0x2000061")]
	internal class ArabicTable
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x17000016")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x22E60BC", Offset = "0x22E60BC", VA = "0x22E60BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x22E55A4", Offset = "0x22E55A4", VA = "0x22E55A4")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x22E613C", Offset = "0x22E613C", VA = "0x22E613C")]
		internal int Convert(int toBeConverted)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000062")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x266229C", Offset = "0x266229C", VA = "0x266229C")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
	[Token(Token = "0x2000063")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x14A6EC0", Offset = "0x14A6EC0", VA = "0x14A6EC0")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x14A7474", Offset = "0x14A7474", VA = "0x14A7474")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x14A612C", Offset = "0x14A612C", VA = "0x14A612C")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x14A76C8", Offset = "0x14A76C8", VA = "0x14A76C8")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x14A7D1C", Offset = "0x14A7D1C", VA = "0x14A7D1C")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x14A7BBC", Offset = "0x14A7BBC", VA = "0x14A7BBC")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x14A7840", Offset = "0x14A7840", VA = "0x14A7840")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x14A8054", Offset = "0x14A8054", VA = "0x14A8054")]
		public RTLFixerTool()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2660800", Offset = "0x2660800", VA = "0x2660800", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x26608F0", Offset = "0x26608F0", VA = "0x26608F0", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x266097C", Offset = "0x266097C", VA = "0x266097C", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2660984", Offset = "0x2660984", VA = "0x2660984")]
		public RegisterGlobalParameters()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public interface IResourceManager_Bundles
	{
		[Token(Token = "0x6000277")]
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}
	[Token(Token = "0x2000066")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object[] Assets;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;

		[Token(Token = "0x17000017")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x266038C", Offset = "0x266038C", VA = "0x266038C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x266098C", Offset = "0x266098C", VA = "0x266098C")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600027A")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2660A60", Offset = "0x2660A60", VA = "0x2660A60")]
		private UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2660B9C", Offset = "0x2660B9C", VA = "0x2660B9C")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x26609F8", Offset = "0x26609F8", VA = "0x26609F8")]
		public void CleanResourceCache()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2660C08", Offset = "0x2660C08", VA = "0x2660C08")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6DD3C", Offset = "0xA6DD3C")]
	public class SetLanguage : MonoBehaviour
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _Language;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2660D54", Offset = "0x2660D54", VA = "0x2660D54")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2660D58", Offset = "0x2660D58", VA = "0x2660D58")]
		public void ApplyLanguage()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2660E10", Offset = "0x2660E10", VA = "0x2660E10")]
		public SetLanguage()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6DD74", Offset = "0xA6DD74")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2660E18", Offset = "0x2660E18", VA = "0x2660E18")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x26610AC", Offset = "0x26610AC", VA = "0x26610AC")]
		private void OnValueChanged(int index)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x26611B0", Offset = "0x26611B0", VA = "0x26611B0")]
		public SetLanguageDropdown()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class StringObfucator
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2661D68", Offset = "0x2661D68", VA = "0x2661D68")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x266209C", Offset = "0x266209C", VA = "0x266209C")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x266200C", Offset = "0x266200C", VA = "0x266200C")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2662180", Offset = "0x2662180", VA = "0x2662180")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2661E4C", Offset = "0x2661E4C", VA = "0x2661E4C")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2662218", Offset = "0x2662218", VA = "0x2662218")]
		public StringObfucator()
		{
		}
	}
}
namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x200006A")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x4000195")]
		Array = 1,
		[Token(Token = "0x4000196")]
		Class,
		[Token(Token = "0x4000197")]
		Value,
		[Token(Token = "0x4000198")]
		IntValue,
		[Token(Token = "0x4000199")]
		DoubleValue,
		[Token(Token = "0x400019A")]
		BoolValue,
		[Token(Token = "0x400019B")]
		FloatValue
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA6DDAC", Offset = "0xA6DDAC")]
	public class JSONNode
	{
		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DDE4", Offset = "0xA6DDE4")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000024")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002C2")]
				[Address(RVA = "0x2665880", Offset = "0x2665880", VA = "0x2665880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x26658C8", Offset = "0x26658C8", VA = "0x26658C8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x266582C", Offset = "0x266582C", VA = "0x266582C")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x2665864", Offset = "0x2665864", VA = "0x2665864", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2665868", Offset = "0x2665868", VA = "0x2665868", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x2665888", Offset = "0x2665888", VA = "0x2665888", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x26658D0", Offset = "0x26658D0", VA = "0x26658D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x2665964", Offset = "0x2665964", VA = "0x2665964", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DDF4", Offset = "0xA6DDF4")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000026")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0x2666014", Offset = "0x2666014", VA = "0x2666014", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0x266605C", Offset = "0x266605C", VA = "0x266605C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x2665968", Offset = "0x2665968", VA = "0x2665968")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x26659A0", Offset = "0x26659A0", VA = "0x26659A0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2665BA8", Offset = "0x2665BA8", VA = "0x2665BA8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x2665AEC", Offset = "0x2665AEC", VA = "0x2665AEC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x2665A30", Offset = "0x2665A30", VA = "0x2665A30")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x266601C", Offset = "0x266601C", VA = "0x266601C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x2666064", Offset = "0x2666064", VA = "0x2666064", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x2666114", Offset = "0x2666114", VA = "0x2666114", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x22F9874", Offset = "0x22F9874", VA = "0x22F9874", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x22F987C", Offset = "0x22F987C", VA = "0x22F987C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x22F9880", Offset = "0x22F9880", VA = "0x22F9880", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x22F9888", Offset = "0x22F9888", VA = "0x22F9888", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public virtual string Value
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x22F988C", Offset = "0x22F988C", VA = "0x22F988C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x22F98D0", Offset = "0x22F98D0", VA = "0x22F98D0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public virtual int Count
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x22F98D4", Offset = "0x22F98D4", VA = "0x22F98D4", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001C")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x22F9958", Offset = "0x22F9958", VA = "0x22F9958", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E3E0", Offset = "0xA6E3E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x22F99B4", Offset = "0x22F99B4", VA = "0x22F99B4")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E440", Offset = "0xA6E440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public virtual int AsInt
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x22F9AB4", Offset = "0x22F9AB4", VA = "0x22F9AB4", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x22F9AF4", Offset = "0x22F9AF4", VA = "0x22F9AF4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public virtual float AsFloat
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x22F9B34", Offset = "0x22F9B34", VA = "0x22F9B34", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x22F9B78", Offset = "0x22F9B78", VA = "0x22F9B78", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public virtual double AsDouble
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x22F9BB8", Offset = "0x22F9BB8", VA = "0x22F9BB8", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x22F9C58", Offset = "0x22F9C58", VA = "0x22F9C58", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public virtual bool AsBool
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x22F9C98", Offset = "0x22F9C98", VA = "0x22F9C98", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x22F9D5C", Offset = "0x22F9D5C", VA = "0x22F9D5C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x22F9DE0", Offset = "0x22F9DE0", VA = "0x22F9DE0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x22F9E5C", Offset = "0x22F9E5C", VA = "0x22F9E5C", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x22F9870", Offset = "0x22F9870", VA = "0x22F9870", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x22F98DC", Offset = "0x22F98DC", VA = "0x22F98DC", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x22F9940", Offset = "0x22F9940", VA = "0x22F9940", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x22F9948", Offset = "0x22F9948", VA = "0x22F9948", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x22F9950", Offset = "0x22F9950", VA = "0x22F9950", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x22F9A2C", Offset = "0x22F9A2C", VA = "0x22F9A2C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x22F9A70", Offset = "0x22F9A70", VA = "0x22F9A70", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x22F9ED8", Offset = "0x22F9ED8", VA = "0x22F9ED8")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x22F9F44", Offset = "0x22F9F44", VA = "0x22F9F44")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x22F9F90", Offset = "0x22F9F90", VA = "0x22F9F90")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x22FA024", Offset = "0x22FA024", VA = "0x22FA024")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x22FA040", Offset = "0x22FA040", VA = "0x22FA040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x22F9308", Offset = "0x22F9308", VA = "0x22F9308", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x22F8134", Offset = "0x22F8134", VA = "0x22F8134")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x22F6148", Offset = "0x22F6148", VA = "0x22F6148")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x22FA04C", Offset = "0x22FA04C", VA = "0x22FA04C", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x22FA050", Offset = "0x22FA050", VA = "0x22FA050")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x22FA0CC", Offset = "0x22FA0CC", VA = "0x22FA0CC")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x22FA120", Offset = "0x22FA120", VA = "0x22FA120")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x22FA174", Offset = "0x22FA174", VA = "0x22FA174")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x22FA1C8", Offset = "0x22FA1C8", VA = "0x22FA1C8")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x22FA358", Offset = "0x22FA358", VA = "0x22FA358")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x22FA52C", Offset = "0x22FA52C", VA = "0x22FA52C")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x22FA900", Offset = "0x22FA900", VA = "0x22FA900")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x22FA954", Offset = "0x22FA954", VA = "0x22FA954")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x22FA9A8", Offset = "0x22FA9A8", VA = "0x22FA9A8")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x22FA9FC", Offset = "0x22FA9FC", VA = "0x22FA9FC")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x22FAB5C", Offset = "0x22FAB5C", VA = "0x22FAB5C")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x22FAC9C", Offset = "0x22FAC9C", VA = "0x22FAC9C")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x22F7358", Offset = "0x22F7358", VA = "0x22F7358")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA6DE04", Offset = "0xA6DE04")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DE3C", Offset = "0xA6DE3C")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700002C")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002E3")]
				[Address(RVA = "0x26650D4", Offset = "0x26650D4", VA = "0x26650D4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002E5")]
				[Address(RVA = "0x266511C", Offset = "0x266511C", VA = "0x266511C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x2664EA0", Offset = "0x2664EA0", VA = "0x2664EA0")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x2664ED8", Offset = "0x2664ED8", VA = "0x2664ED8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x2664F48", Offset = "0x2664F48", VA = "0x2664F48", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x2664EF4", Offset = "0x2664EF4", VA = "0x2664EF4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x26650DC", Offset = "0x26650DC", VA = "0x26650DC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x2665124", Offset = "0x2665124", VA = "0x2665124", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x26651D4", Offset = "0x26651D4", VA = "0x26651D4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DE4C", Offset = "0xA6DE4C")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002EC")]
				[Address(RVA = "0x2664E50", Offset = "0x2664E50", VA = "0x2664E50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002EE")]
				[Address(RVA = "0x2664E98", Offset = "0x2664E98", VA = "0x2664E98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x2664C28", Offset = "0x2664C28", VA = "0x2664C28")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x2664C54", Offset = "0x2664C54", VA = "0x2664C54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x2664CC4", Offset = "0x2664CC4", VA = "0x2664CC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x2664C70", Offset = "0x2664C70", VA = "0x2664C70")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x2664E58", Offset = "0x2664E58", VA = "0x2664E58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x17000028")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x22F6878", Offset = "0x22F6878", VA = "0x22F6878", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x22F6974", Offset = "0x22F6974", VA = "0x22F6974", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x22F6A2C", Offset = "0x22F6A2C", VA = "0x22F6A2C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x22F6A88", Offset = "0x22F6A88", VA = "0x22F6A88", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public override int Count
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x22F6AEC", Offset = "0x22F6AEC", VA = "0x22F6AEC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x22F6CC8", Offset = "0x22F6CC8", VA = "0x22F6CC8", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E580", Offset = "0xA6E580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x22F6B38", Offset = "0x22F6B38", VA = "0x22F6B38", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x22F6B9C", Offset = "0x22F6B9C", VA = "0x22F6B9C", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x22F6C5C", Offset = "0x22F6C5C", VA = "0x22F6C5C", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x22F6D40", Offset = "0x22F6D40", VA = "0x22F6D40", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E5E0", Offset = "0xA6E5E0")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x22F6DB8", Offset = "0x22F6DB8", VA = "0x22F6DB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x22F6F94", Offset = "0x22F6F94", VA = "0x22F6F94", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x22F71EC", Offset = "0x22F71EC", VA = "0x22F71EC", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x22F72D4", Offset = "0x22F72D4", VA = "0x22F72D4")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA6DE5C", Offset = "0xA6DE5C")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DE94", Offset = "0xA6DE94")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x26651D8", Offset = "0x26651D8", VA = "0x26651D8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x26651E0", Offset = "0x26651E0", VA = "0x26651E0")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DEA4", Offset = "0xA6DEA4")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000034")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x2665728", Offset = "0x2665728", VA = "0x2665728", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000306")]
				[Address(RVA = "0x2665770", Offset = "0x2665770", VA = "0x2665770", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x26654E0", Offset = "0x26654E0", VA = "0x26654E0")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x2665518", Offset = "0x2665518", VA = "0x2665518", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x2665588", Offset = "0x2665588", VA = "0x2665588", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x2665534", Offset = "0x2665534", VA = "0x2665534")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x2665730", Offset = "0x2665730", VA = "0x2665730", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x2665778", Offset = "0x2665778", VA = "0x2665778", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2665828", Offset = "0x2665828", VA = "0x2665828", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6DEB4", Offset = "0xA6DEB4")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600030D")]
				[Address(RVA = "0x2665490", Offset = "0x2665490", VA = "0x2665490", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600030F")]
				[Address(RVA = "0x26654D8", Offset = "0x26654D8", VA = "0x26654D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2665234", Offset = "0x2665234", VA = "0x2665234")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x2665260", Offset = "0x2665260", VA = "0x2665260", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x26652D0", Offset = "0x26652D0", VA = "0x26652D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x266527C", Offset = "0x266527C", VA = "0x266527C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x2665498", Offset = "0x2665498", VA = "0x2665498", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000030")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x22F7360", Offset = "0x22F7360", VA = "0x22F7360", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x22F7480", Offset = "0x22F7480", VA = "0x22F7480", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x22F7550", Offset = "0x22F7550", VA = "0x22F7550", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x22F75FC", Offset = "0x22F75FC", VA = "0x22F75FC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public override int Count
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x22F76DC", Offset = "0x22F76DC", VA = "0x22F76DC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000033")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x22F7C18", Offset = "0x22F7C18", VA = "0x22F7C18", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E700", Offset = "0xA6E700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x22F7730", Offset = "0x22F7730", VA = "0x22F7730", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x22F787C", Offset = "0x22F787C", VA = "0x22F787C", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x22F794C", Offset = "0x22F794C", VA = "0x22F794C", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x22F7A34", Offset = "0x22F7A34", VA = "0x22F7A34", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x22F7C90", Offset = "0x22F7C90", VA = "0x22F7C90", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6E760", Offset = "0xA6E760")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x22F7D08", Offset = "0x22F7D08", VA = "0x22F7D08", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x22F8300", Offset = "0x22F8300", VA = "0x22F8300", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x22F879C", Offset = "0x22F879C", VA = "0x22F879C", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x22F8998", Offset = "0x22F8998", VA = "0x22F8998")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000038")]
		public override string Value
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x22F8A98", Offset = "0x22F8A98", VA = "0x22F8A98", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x22F8AA0", Offset = "0x22F8AA0", VA = "0x22F8AA0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x22F8AA8", Offset = "0x22F8AA8", VA = "0x22F8AA8")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x22F8ADC", Offset = "0x22F8ADC", VA = "0x22F8ADC")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x22F8B20", Offset = "0x22F8B20", VA = "0x22F8B20")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x22F8B64", Offset = "0x22F8B64", VA = "0x22F8B64")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x22F8BA0", Offset = "0x22F8BA0", VA = "0x22F8BA0")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x22F8BDC", Offset = "0x22F8BDC", VA = "0x22F8BDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x22F8C38", Offset = "0x22F8C38", VA = "0x22F8C38", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x22F8C94", Offset = "0x22F8C94", VA = "0x22F8C94", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA6DEC4", Offset = "0xA6DEC4")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000039")]
		public override JSONNode Item
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x22F8FD0", Offset = "0x22F8FD0", VA = "0x22F8FD0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x22F902C", Offset = "0x22F902C", VA = "0x22F902C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public override JSONNode Item
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x22F90B0", Offset = "0x22F90B0", VA = "0x22F90B0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x22F911C", Offset = "0x22F911C", VA = "0x22F911C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public override int AsInt
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x22F9398", Offset = "0x22F9398", VA = "0x22F9398", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x22F9418", Offset = "0x22F9418", VA = "0x22F9418", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public override float AsFloat
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x22F949C", Offset = "0x22F949C", VA = "0x22F949C", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x22F951C", Offset = "0x22F951C", VA = "0x22F951C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public override double AsDouble
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x22F95A0", Offset = "0x22F95A0", VA = "0x22F95A0", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x22F9620", Offset = "0x22F9620", VA = "0x22F9620", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override bool AsBool
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x22F96A4", Offset = "0x22F96A4", VA = "0x22F96A4", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x22F9724", Offset = "0x22F9724", VA = "0x22F9724", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x22F97A8", Offset = "0x22F97A8", VA = "0x22F97A8", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x22F980C", Offset = "0x22F980C", VA = "0x22F980C", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x22F6930", Offset = "0x22F6930", VA = "0x22F6930")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x22F7430", Offset = "0x22F7430", VA = "0x22F7430")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x22F8F64", Offset = "0x22F8F64", VA = "0x22F8F64")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x22F91A8", Offset = "0x22F91A8", VA = "0x22F91A8", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x22F922C", Offset = "0x22F922C", VA = "0x22F922C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x22F92B8", Offset = "0x22F92B8", VA = "0x22F92B8")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x22F92D0", Offset = "0x22F92D0", VA = "0x22F92D0")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x22F92E8", Offset = "0x22F92E8", VA = "0x22F92E8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x22F9300", Offset = "0x22F9300", VA = "0x22F9300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x22F9310", Offset = "0x22F9310", VA = "0x22F9310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x22F9354", Offset = "0x22F9354", VA = "0x22F9354", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	public static class JSON
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x22F6144", Offset = "0x22F6144", VA = "0x22F6144")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
