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
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class TestDiskUtils : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4071C", Offset = "0xB4071C")]
	private sealed class <Tests>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TestDiskUtils <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1286A2C", Offset = "0x1286A2C", VA = "0x1286A2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1286A74", Offset = "0x1286A74", VA = "0x1286A74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x127EFBC", Offset = "0x127EFBC", VA = "0x127EFBC")]
		[DebuggerHidden]
		public <Tests>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1286840", Offset = "0x1286840", VA = "0x1286840", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1286844", Offset = "0x1286844", VA = "0x1286844", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1286A34", Offset = "0x1286A34", VA = "0x1286A34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMesh text;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string obj;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x127EC38", Offset = "0x127EC38", VA = "0x127EC38")]
	private void PrintDebug(string str)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x127ED20", Offset = "0x127ED20", VA = "0x127ED20")]
	private void PrintDebugLn(string str = "")
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x127ED88", Offset = "0x127ED88", VA = "0x127ED88")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x127EE74", Offset = "0x127EE74", VA = "0x127EE74")]
	private void PrintStorageStats()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x127EE08", Offset = "0x127EE08", VA = "0x127EE08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB4111C", Offset = "0xB4111C")]
	private IEnumerator Tests()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x127EFE8", Offset = "0x127EFE8", VA = "0x127EFE8")]
	public TestDiskUtils()
	{
	}
}
[Token(Token = "0x2000004")]
public class TextMover : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x127F03C", Offset = "0x127F03C", VA = "0x127F03C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x127F10C", Offset = "0x127F10C", VA = "0x127F10C")]
	private void GetMobile(out float h, out float v)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x127F1C8", Offset = "0x127F1C8", VA = "0x127F1C8")]
	private void GetDesktop(out float h, out float v)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x127F24C", Offset = "0x127F24C", VA = "0x127F24C")]
	public TextMover()
	{
	}
}
[Token(Token = "0x2000005")]
public static class iOSCameraPermission
{
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1280D8C", Offset = "0x1280D8C", VA = "0x1280D8C")]
	public static void VerifyPermission(string gameObjectName, string callbackName)
	{
	}
}
namespace SimpleDiskUtils
{
	[Token(Token = "0x2000006")]
	public class DiskUtils
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x187E0A0", Offset = "0x187E0A0", VA = "0x187E0A0")]
		public static int CheckAvailableSpace(bool isExternalStorage = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x187E1E8", Offset = "0x187E1E8", VA = "0x187E1E8")]
		public static int CheckTotalSpace(bool isExternalStorage = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x187E330", Offset = "0x187E330", VA = "0x187E330")]
		public static int CheckBusySpace(bool isExternalStorage = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x187E478", Offset = "0x187E478", VA = "0x187E478")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x187E4B4", Offset = "0x187E4B4", VA = "0x187E4B4")]
		public static void SaveFile(object obj, string filePath)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x187E600", Offset = "0x187E600", VA = "0x187E600")]
		public static void SaveFile(object obj, string dirPath, string fileName)
		{
		}

		[Token(Token = "0x6000018")]
		public static T LoadFile<T>(string filePath)
		{
			return (T)null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x187E9A0", Offset = "0x187E9A0", VA = "0x187E9A0")]
		public static void SaveTextFile(string str, string filePath)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x187EA68", Offset = "0x187EA68", VA = "0x187EA68")]
		public static void SaveTextFile(string str, string dirPath, string fileName)
		{
		}

		[Token(Token = "0x600001B")]
		public static string LoadTextFile<T>(string filePath)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x187E778", Offset = "0x187E778", VA = "0x187E778")]
		public static byte[] ObjectToByteArray(object obj)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		public static T ByteArrayToObject<T>(byte[] bytes)
		{
			return (T)null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x187EB9C", Offset = "0x187EB9C", VA = "0x187EB9C")]
		public DiskUtils()
		{
		}
	}
}
namespace nTools.PrefabPainter
{
	[Token(Token = "0x2000007")]
	public class PrefabPainterSceneSettings : MonoBehaviour
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject parentForPrefabs;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1278FFC", Offset = "0x1278FFC", VA = "0x1278FFC")]
		public PrefabPainterSceneSettings()
		{
		}
	}
}
namespace I2.Loc
{
	[Token(Token = "0x2000008")]
	public static class PersistentStorage
	{
		[Token(Token = "0x2000009")]
		public enum eFileType
		{
			[Token(Token = "0x400000A")]
			Raw,
			[Token(Token = "0x400000B")]
			Persistent,
			[Token(Token = "0x400000C")]
			Temporal,
			[Token(Token = "0x400000D")]
			Streaming
		}

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x12788C0", Offset = "0x12788C0", VA = "0x12788C0")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1278978", Offset = "0x1278978", VA = "0x1278978")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1278A30", Offset = "0x1278A30", VA = "0x1278A30")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1278AE0", Offset = "0x1278AE0", VA = "0x1278AE0")]
		public static bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1278B90", Offset = "0x1278B90", VA = "0x1278B90")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1278C30", Offset = "0x1278C30", VA = "0x1278C30")]
		public static bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1278CD0", Offset = "0x1278CD0", VA = "0x1278CD0")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1278DA0", Offset = "0x1278DA0", VA = "0x1278DA0")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1278E68", Offset = "0x1278E68", VA = "0x1278E68")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1278F30", Offset = "0x1278F30", VA = "0x1278F30")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000A")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1DCCAB0", Offset = "0x1DCCAB0", VA = "0x1DCCAB0", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1DCCD3C", Offset = "0x1DCCD3C", VA = "0x1DCCD3C", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1DCCFEC", Offset = "0x1DCCFEC", VA = "0x1DCCFEC", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1DCD258", Offset = "0x1DCD258", VA = "0x1DCD258", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1DCD260", Offset = "0x1DCD260", VA = "0x1DCD260", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1DCD26C", Offset = "0x1DCD26C", VA = "0x1DCD26C", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1DCD274", Offset = "0x1DCD274", VA = "0x1DCD274")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1DCD31C", Offset = "0x1DCD31C", VA = "0x1DCD31C", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1DCD4D4", Offset = "0x1DCD4D4", VA = "0x1DCD4D4", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1DCD680", Offset = "0x1DCD680", VA = "0x1DCD680", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1DCD820", Offset = "0x1DCD820", VA = "0x1DCD820", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1DCD9C0", Offset = "0x1DCD9C0", VA = "0x1DCD9C0")]
		protected I2BasePersistentStorage()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class I2CustomPersistentStorage : I2BasePersistentStorage
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1DCD9C8", Offset = "0x1DCD9C8", VA = "0x1DCD9C8")]
		public I2CustomPersistentStorage()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1872330", Offset = "0x1872330", VA = "0x1872330", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1872844", Offset = "0x1872844", VA = "0x1872844", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x18728A4", Offset = "0x18728A4", VA = "0x18728A4", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1872950", Offset = "0x1872950", VA = "0x1872950")]
		public BaseSpecializationManager()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x127D0A0", Offset = "0x127D0A0", VA = "0x127D0A0")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x127D0D0", Offset = "0x127D0D0", VA = "0x127D0D0")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x127D2E4", Offset = "0x127D2E4", VA = "0x127D2E4")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x127D6A8", Offset = "0x127D6A8", VA = "0x127D6A8")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x127D410", Offset = "0x127D410", VA = "0x127D410")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x127DA6C", Offset = "0x127DA6C", VA = "0x127DA6C")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class EventCallback
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x187EBA4", Offset = "0x187EBA4", VA = "0x187EBA4")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x187EC0C", Offset = "0x187EC0C", VA = "0x187EC0C")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x187EC9C", Offset = "0x187EC9C", VA = "0x187EC9C")]
		public EventCallback()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public enum ePluralType
	{
		[Token(Token = "0x4000014")]
		Zero,
		[Token(Token = "0x4000015")]
		One,
		[Token(Token = "0x4000016")]
		Two,
		[Token(Token = "0x4000017")]
		Few,
		[Token(Token = "0x4000018")]
		Many,
		[Token(Token = "0x4000019")]
		Plural
	}
	[Token(Token = "0x2000010")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x2000011")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x187ECF8", Offset = "0x187ECF8", VA = "0x187ECF8")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x187F114", Offset = "0x187F114", VA = "0x187F114")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x187EFBC", Offset = "0x187EFBC", VA = "0x187EFBC")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x187F694", Offset = "0x187F694", VA = "0x187F694")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x187F7F0", Offset = "0x187F7F0", VA = "0x187F7F0")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x187F8CC", Offset = "0x187F8CC", VA = "0x187F8CC")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x187FA34", Offset = "0x187FA34", VA = "0x187FA34")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x187FC00", Offset = "0x187FC00", VA = "0x187FC00")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x187FEEC", Offset = "0x187FEEC", VA = "0x187FEEC")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1880160", Offset = "0x1880160", VA = "0x1880160")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1880308", Offset = "0x1880308", VA = "0x1880308")]
		private static int GetPluralRule(string langCode)
		{
			return default(int);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x18804D4", Offset = "0x18804D4", VA = "0x18804D4")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x188069C", Offset = "0x188069C", VA = "0x188069C")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default(ePluralType);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1880DB0", Offset = "0x1880DB0", VA = "0x1880DB0")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return default(int);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1880D98", Offset = "0x1880D98", VA = "0x1880D98")]
		private static bool inRange(int amount, int min, int max)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000012")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x2000013")]
		public delegate void fnOnTranslated(string Translation, string Error);

		[Token(Token = "0x2000014")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4072C", Offset = "0xB4072C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public fnOnTranslated OnTranslationReady;

			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, TranslationQuery> queries;

			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string LanguageCodeTo;

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1282CB0", Offset = "0x1282CB0", VA = "0x1282CB0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1282CB8", Offset = "0x1282CB8", VA = "0x1282CB8")]
			internal void <Translate>b__0(Dictionary<string, TranslationQuery> results, string error)
			{
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4073C", Offset = "0xB4073C")]
		private sealed class <WaitForTranslations>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600007E")]
				[Address(RVA = "0x1283310", Offset = "0x1283310", VA = "0x1283310", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000080")]
				[Address(RVA = "0x1283358", Offset = "0x1283358", VA = "0x1283358", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1283138", Offset = "0x1283138", VA = "0x1283138")]
			[DebuggerHidden]
			public <WaitForTranslations>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0x1283164", Offset = "0x1283164", VA = "0x1283164", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x1283168", Offset = "0x1283168", VA = "0x1283168", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x1283318", Offset = "0x1283318", VA = "0x1283318", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1DC90BC", Offset = "0x1DC90BC", VA = "0x1DC90BC")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1DC935C", Offset = "0x1DC935C", VA = "0x1DC935C")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, fnOnTranslated OnTranslationReady)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1DC99AC", Offset = "0x1DC99AC", VA = "0x1DC99AC")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1DC9910", Offset = "0x1DC9910", VA = "0x1DC9910")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1DCA050", Offset = "0x1DCA050", VA = "0x1DCA050")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1DCA0D4", Offset = "0x1DCA0D4", VA = "0x1DCA0D4")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1DC9F70", Offset = "0x1DC9F70", VA = "0x1DC9F70")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1DCA67C", Offset = "0x1DCA67C", VA = "0x1DCA67C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB411CC", Offset = "0xB411CC")]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1DCA6D8", Offset = "0x1DCA6D8", VA = "0x1DCA6D8")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1DCAE28", Offset = "0x1DCAE28", VA = "0x1DCAE28")]
		public static bool IsTranslating()
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1DCAEF0", Offset = "0x1DCAEF0", VA = "0x1DCAEF0")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1DC9700", Offset = "0x1DC9700", VA = "0x1DC9700")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1DCB0AC", Offset = "0x1DCB0AC", VA = "0x1DCB0AC")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1DC9B88", Offset = "0x1DC9B88", VA = "0x1DC9B88")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1DCBAF8", Offset = "0x1DCBAF8", VA = "0x1DCBAF8")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1DCABB8", Offset = "0x1DCABB8", VA = "0x1DCABB8")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default(TranslationQuery);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1DCB34C", Offset = "0x1DCB34C", VA = "0x1DCB34C")]
		public static bool HasParameters(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1DCB528", Offset = "0x1DCB528", VA = "0x1DCB528")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1DCB3EC", Offset = "0x1DCB3EC", VA = "0x1DCB3EC")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1DCBC04", Offset = "0x1DCBC04", VA = "0x1DCBC04")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1DCAD74", Offset = "0x1DCAD74", VA = "0x1DCAD74")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1DCB62C", Offset = "0x1DCB62C", VA = "0x1DCB62C")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1DC9E4C", Offset = "0x1DC9E4C", VA = "0x1DC9E4C")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1DCBD80", Offset = "0x1DCBD80", VA = "0x1DCBD80")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1DCC0B8", Offset = "0x1DCC0B8", VA = "0x1DCC0B8")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1DCC448", Offset = "0x1DCC448", VA = "0x1DCC448")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1DCA5BC", Offset = "0x1DCA5BC", VA = "0x1DCA5BC")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	public struct TranslationQuery
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OrigText;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string LanguageCode;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] Results;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Tags;
	}
	[Token(Token = "0x2000018")]
	public class TranslationJob : IDisposable
	{
		[Token(Token = "0x2000019")]
		public enum eJobState
		{
			[Token(Token = "0x400002F")]
			Running,
			[Token(Token = "0x4000030")]
			Succeeded,
			[Token(Token = "0x4000031")]
			Failed
		}

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public eJobState mJobState;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x127F25C", Offset = "0x127F25C", VA = "0x127F25C", Slot = "5")]
		public virtual eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x127F264", Offset = "0x127F264", VA = "0x127F264", Slot = "6")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x127F268", Offset = "0x127F268", VA = "0x127F268")]
		public TranslationJob()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class TranslationJob_WWW : TranslationJob
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest www;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1280D5C", Offset = "0x1280D5C", VA = "0x1280D5C", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x127F30C", Offset = "0x127F30C", VA = "0x127F30C")]
		public TranslationJob_WWW()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> mQueries;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mErrorMessage;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x127F270", Offset = "0x127F270", VA = "0x127F270")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x127F314", Offset = "0x127F314", VA = "0x127F314")]
		private void ExecuteNextQuery()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x127F41C", Offset = "0x127F41C", VA = "0x127F41C", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x127F4C0", Offset = "0x127F4C0", VA = "0x127F4C0")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class TranslationJob_Main : TranslationJob
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TranslationJob_WEB mWeb;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TranslationJob_POST mPost;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TranslationJob_GET mGet;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mErrorMessage;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x127F958", Offset = "0x127F958", VA = "0x127F958")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x127FB70", Offset = "0x127FB70", VA = "0x127FB70", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x127FD20", Offset = "0x127FD20", VA = "0x127FD20", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x127F9D8", Offset = "0x127F9D8", VA = "0x127F9D8")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x127FD6C", Offset = "0x127FD6C", VA = "0x127FD6C", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x127FDFC", Offset = "0x127FDFC", VA = "0x127FDFC")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		[Serializable]
		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4074C", Offset = "0xB4074C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<KeyValuePair<string, string>> <>9__8_0;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static MatchEvaluator <>9__12_0;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static MatchEvaluator <>9__12_1;

			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1286ADC", Offset = "0x1286ADC", VA = "0x1286ADC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1286AE4", Offset = "0x1286AE4", VA = "0x1286AE4")]
			internal int <FindAllQueries>b__8_0(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
			{
				return default(int);
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x1286B40", Offset = "0x1286B40", VA = "0x1286B40")]
			internal string <ParseTranslationResult>b__12_0(Match match)
			{
				return null;
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1286BEC", Offset = "0x1286BEC", VA = "0x1286BEC")]
			internal string <ParseTranslationResult>b__12_1(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mErrorMessage;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string mCurrentBatch_ToLanguageCode;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mCurrentBatch_FromLanguageCode;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> mCurrentBatch_Text;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<KeyValuePair<string, string>> mQueries;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x127FEEC", Offset = "0x127FEEC", VA = "0x127FEEC")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x127FF30", Offset = "0x127FF30", VA = "0x127FF30")]
		private void FindAllQueries()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x128028C", Offset = "0x128028C", VA = "0x128028C")]
		private void ExecuteNextBatch()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1280650", Offset = "0x1280650", VA = "0x1280650", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x12806F4", Offset = "0x12806F4", VA = "0x12806F4")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1280810", Offset = "0x1280810", VA = "0x1280810")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public enum eLanguageDataFlags
	{
		[Token(Token = "0x400004B")]
		DISABLED = 1,
		[Token(Token = "0x400004C")]
		KEEP_LOADED = 2,
		[Token(Token = "0x400004D")]
		NOT_LOADED = 4
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public class LanguageData
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1DD3488", Offset = "0x1DD3488", VA = "0x1DD3488")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1DD3498", Offset = "0x1DD3498", VA = "0x1DD3498")]
		public void SetEnabled(bool bEnabled)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1DD34B4", Offset = "0x1DD34B4", VA = "0x1DD34B4")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1DD34C4", Offset = "0x1DD34C4", VA = "0x1DD34C4")]
		public bool CanBeUnloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1DD34D4", Offset = "0x1DD34D4", VA = "0x1DD34D4")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1DD34F0", Offset = "0x1DD34F0", VA = "0x1DD34F0")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1DD350C", Offset = "0x1DD350C", VA = "0x1DD350C")]
		public LanguageData()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB4075C", Offset = "0xB4075C")]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x2000023")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool NeverDestroy;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UnityEngine.Object> Assets;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<TermData> mTerms;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string mTerm_AppName;

		[Token(Token = "0x17000005")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x1DD3514", Offset = "0x1DD3514", VA = "0x1DD3514", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1DD351C", Offset = "0x1DD351C", VA = "0x1DD351C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x1DD3524", Offset = "0x1DD3524", VA = "0x1DD3524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4127C", Offset = "0xB4127C")]
			add
			{
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1DD35C4", Offset = "0x1DD35C4", VA = "0x1DD35C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4128C", Offset = "0xB4128C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1DD3664", Offset = "0x1DD3664", VA = "0x1DD3664")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1DD3708", Offset = "0x1DD3708", VA = "0x1DD3708")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1DD3788", Offset = "0x1DD3788", VA = "0x1DD3788")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1DD3884", Offset = "0x1DD3884", VA = "0x1DD3884", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1DD3890", Offset = "0x1DD3890", VA = "0x1DD3890", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1DD3EFC", Offset = "0x1DD3EFC", VA = "0x1DD3EFC")]
		public LanguageSource()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xB407A8", Offset = "0xB407A8")]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x17000006")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1DD403C", Offset = "0x1DD403C", VA = "0x1DD403C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1DD4044", Offset = "0x1DD4044", VA = "0x1DD4044", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1DD404C", Offset = "0x1DD404C", VA = "0x1DD404C")]
		public LanguageSourceAsset()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public interface ILanguageSource
	{
		[Token(Token = "0x17000007")]
		LanguageSourceData SourceData
		{
			[Token(Token = "0x60000B3")]
			get;
			[Token(Token = "0x60000B4")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x2000027")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x4000084")]
			Empty,
			[Token(Token = "0x4000085")]
			Fallback,
			[Token(Token = "0x4000086")]
			ShowWarning,
			[Token(Token = "0x4000087")]
			ShowTerm
		}

		[Token(Token = "0x2000028")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x4000089")]
			Never,
			[Token(Token = "0x400008A")]
			OnlyInDevice,
			[Token(Token = "0x400008B")]
			EditorAndDevice
		}

		[Token(Token = "0x2000029")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x400008D")]
			Always,
			[Token(Token = "0x400008E")]
			Never,
			[Token(Token = "0x400008F")]
			Daily,
			[Token(Token = "0x4000090")]
			Weekly,
			[Token(Token = "0x4000091")]
			Monthly,
			[Token(Token = "0x4000092")]
			OnlyOnce,
			[Token(Token = "0x4000093")]
			EveryOtherDay
		}

		[Token(Token = "0x200002A")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x4000095")]
			Manual,
			[Token(Token = "0x4000096")]
			OnSceneLoaded,
			[Token(Token = "0x4000097")]
			AsSoonAsDownloaded
		}

		[Serializable]
		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4080C", Offset = "0xB4080C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> <>9__39_0;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> <>9__39_1;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__39_2;

			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__39_3;

			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Comparison<TermData> <>9__43_0;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Comparison<TermData> <>9__47_0;

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x1284EE8", Offset = "0x1284EE8", VA = "0x1284EE8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1284EF0", Offset = "0x1284EF0", VA = "0x1284EF0")]
			internal bool <UpdateAssetDictionary>b__39_0(UnityEngine.Object x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1284F58", Offset = "0x1284F58", VA = "0x1284F58")]
			internal string <UpdateAssetDictionary>b__39_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1284F74", Offset = "0x1284F74", VA = "0x1284F74")]
			internal string <UpdateAssetDictionary>b__39_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x128501C", Offset = "0x128501C", VA = "0x128501C")]
			internal UnityEngine.Object <UpdateAssetDictionary>b__39_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1285068", Offset = "0x1285068", VA = "0x1285068")]
			internal int <Export_I2CSV>b__43_0(TermData a, TermData b)
			{
				return default(int);
			}

			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1285090", Offset = "0x1285090", VA = "0x1285090")]
			internal int <Export_CSV>b__47_0(TermData a, TermData b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4081C", Offset = "0xB4081C")]
		private sealed class <Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData <>4__this;

			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool JustCheck;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600010F")]
				[Address(RVA = "0x12853DC", Offset = "0x12853DC", VA = "0x12853DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000111")]
				[Address(RVA = "0x1285424", Offset = "0x1285424", VA = "0x1285424", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x12850B8", Offset = "0x12850B8", VA = "0x12850B8")]
			[DebuggerHidden]
			public <Import_Google_Coroutine>d__65(int <>1__state)
			{
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x12850E4", Offset = "0x12850E4", VA = "0x12850E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x12850E8", Offset = "0x12850E8", VA = "0x12850E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x12853E4", Offset = "0x12853E4", VA = "0x12853E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x17000008")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x1DD40AC", Offset = "0x1DD40AC", VA = "0x1DD40AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1DD3E5C", Offset = "0x1DD3E5C", VA = "0x1DD3E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4129C", Offset = "0xB4129C")]
			add
			{
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x1DD412C", Offset = "0x1DD412C", VA = "0x1DD412C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB412AC", Offset = "0xB412AC")]
			remove
			{
			}
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1DD368C", Offset = "0x1DD368C", VA = "0x1DD368C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1DD3728", Offset = "0x1DD3728", VA = "0x1DD3728")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1DD4D60", Offset = "0x1DD4D60", VA = "0x1DD4D60")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1DD5314", Offset = "0x1DD5314", VA = "0x1DD5314")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1DD543C", Offset = "0x1DD543C", VA = "0x1DD543C")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1DD54FC", Offset = "0x1DD54FC", VA = "0x1DD54FC")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1DD5504", Offset = "0x1DD5504", VA = "0x1DD5504")]
		public void Editor_SetDirty()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1DD4740", Offset = "0x1DD4740", VA = "0x1DD4740")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1DD5508", Offset = "0x1DD5508", VA = "0x1DD5508")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1DD55E0", Offset = "0x1DD55E0", VA = "0x1DD55E0")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1DD5644", Offset = "0x1DD5644", VA = "0x1DD5644")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1DD56EC", Offset = "0x1DD56EC", VA = "0x1DD56EC")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1DD5E3C", Offset = "0x1DD5E3C", VA = "0x1DD5E3C")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1DD60C4", Offset = "0x1DD60C4", VA = "0x1DD60C4")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1DD61A8", Offset = "0x1DD61A8", VA = "0x1DD61A8")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1DD6754", Offset = "0x1DD6754", VA = "0x1DD6754")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1DD70F4", Offset = "0x1DD70F4", VA = "0x1DD70F4")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1DD6F8C", Offset = "0x1DD6F8C", VA = "0x1DD6F8C")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1DD7384", Offset = "0x1DD7384", VA = "0x1DD7384")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1DD750C", Offset = "0x1DD750C", VA = "0x1DD750C")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1DD76E0", Offset = "0x1DD76E0", VA = "0x1DD76E0")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1DD7B48", Offset = "0x1DD7B48", VA = "0x1DD7B48")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1DD8710", Offset = "0x1DD8710", VA = "0x1DD8710")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1DD7B94", Offset = "0x1DD7B94", VA = "0x1DD7B94")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1DD8758", Offset = "0x1DD8758", VA = "0x1DD8758")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1DD8B60", Offset = "0x1DD8B60", VA = "0x1DD8B60")]
		public static eTermType GetTermType(string type)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1DD8DF4", Offset = "0x1DD8DF4", VA = "0x1DD8DF4")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1DD9040", Offset = "0x1DD9040", VA = "0x1DD9040")]
		public static void FreeUnusedLanguages()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1DD9208", Offset = "0x1DD9208", VA = "0x1DD9208")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1DD9654", Offset = "0x1DD9654", VA = "0x1DD9654")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1DD9D50", Offset = "0x1DD9D50", VA = "0x1DD9D50")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1DD9478", Offset = "0x1DD9478", VA = "0x1DD9478")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1DD9FE8", Offset = "0x1DD9FE8", VA = "0x1DD9FE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB412BC", Offset = "0xB412BC")]
		private IEnumerator Import_Google_Coroutine(bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1DDA068", Offset = "0x1DDA068", VA = "0x1DDA068")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1DDA12C", Offset = "0x1DDA12C", VA = "0x1DDA12C")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1DDA2A4", Offset = "0x1DDA2A4", VA = "0x1DDA2A4")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1DDA41C", Offset = "0x1DDA41C", VA = "0x1DDA41C")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1DD96E4", Offset = "0x1DD96E4", VA = "0x1DD96E4")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1DD4EE0", Offset = "0x1DD4EE0", VA = "0x1DD4EE0")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default(int);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1DDA6A0", Offset = "0x1DDA6A0", VA = "0x1DDA6A0")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1DDA73C", Offset = "0x1DDA73C", VA = "0x1DDA73C")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1DD87FC", Offset = "0x1DD87FC", VA = "0x1DD87FC")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1DDA4C0", Offset = "0x1DDA4C0", VA = "0x1DDA4C0")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default(int);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1DDA7F4", Offset = "0x1DDA7F4", VA = "0x1DDA7F4")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1DDA88C", Offset = "0x1DDA88C", VA = "0x1DDA88C")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1DDA928", Offset = "0x1DDA928", VA = "0x1DDA928")]
		public void AddLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1DDA9AC", Offset = "0x1DDA9AC", VA = "0x1DDA9AC")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1DDAB68", Offset = "0x1DDAB68", VA = "0x1DDAB68")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1DDAE90", Offset = "0x1DDAE90", VA = "0x1DDAE90")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1DDAFE8", Offset = "0x1DDAFE8", VA = "0x1DDAFE8")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1DDB1B4", Offset = "0x1DDB1B4", VA = "0x1DDB1B4")]
		public bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1DDB25C", Offset = "0x1DDB25C", VA = "0x1DDB25C")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1DDB30C", Offset = "0x1DDB30C", VA = "0x1DDB30C")]
		public bool AllowUnloadingLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1DDB31C", Offset = "0x1DDB31C", VA = "0x1DDB31C")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1DDB510", Offset = "0x1DDB510", VA = "0x1DDB510")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1DDB8FC", Offset = "0x1DDB8FC", VA = "0x1DDB8FC")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1DDB6A0", Offset = "0x1DDB6A0", VA = "0x1DDB6A0")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1DD8CD8", Offset = "0x1DD8CD8", VA = "0x1DD8CD8")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1DD8C2C", Offset = "0x1DD8C2C", VA = "0x1DD8C2C")]
		public bool HasUnloadedLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1DD78F8", Offset = "0x1DD78F8", VA = "0x1DD78F8")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1DDBA90", Offset = "0x1DDBA90", VA = "0x1DDBA90")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1DDB98C", Offset = "0x1DDB98C", VA = "0x1DDB98C")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1DDBB70", Offset = "0x1DDBB70", VA = "0x1DDBB70")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1DD4400", Offset = "0x1DD4400", VA = "0x1DD4400")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1DDBCA0", Offset = "0x1DDBCA0", VA = "0x1DDBCA0")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1DDBD48", Offset = "0x1DDBD48", VA = "0x1DDBD48")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1DD6478", Offset = "0x1DD6478", VA = "0x1DD6478")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1DDBFC0", Offset = "0x1DDBFC0", VA = "0x1DDBFC0")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1DD50E0", Offset = "0x1DD50E0", VA = "0x1DD50E0")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1DDC1B4", Offset = "0x1DDC1B4", VA = "0x1DDC1B4")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1DDC1D4", Offset = "0x1DDC1D4", VA = "0x1DDC1D4")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1DDBFCC", Offset = "0x1DDBFCC", VA = "0x1DDBFCC")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1DDC3EC", Offset = "0x1DDC3EC", VA = "0x1DDC3EC")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1DD89C4", Offset = "0x1DD89C4", VA = "0x1DD89C4")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1DD3C00", Offset = "0x1DD3C00", VA = "0x1DD3C00")]
		public LanguageSourceData()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public enum eSpreadsheetUpdateMode
	{
		[Token(Token = "0x40000A5")]
		None,
		[Token(Token = "0x40000A6")]
		Replace,
		[Token(Token = "0x40000A7")]
		Merge,
		[Token(Token = "0x40000A8")]
		AddNewTerms
	}
	[Token(Token = "0x200002E")]
	public class LocalizationReader
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1270C78", Offset = "0x1270C78", VA = "0x1270C78")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1270F14", Offset = "0x1270F14", VA = "0x1270F14")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1271300", Offset = "0x1271300", VA = "0x1271300")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x12714FC", Offset = "0x12714FC", VA = "0x12714FC")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x12715E4", Offset = "0x12715E4", VA = "0x12715E4")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x12717D8", Offset = "0x12717D8", VA = "0x12717D8")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1271914", Offset = "0x1271914", VA = "0x1271914")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1271270", Offset = "0x1271270", VA = "0x1271270")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1271AF0", Offset = "0x1271AF0", VA = "0x1271AF0")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x12711C4", Offset = "0x12711C4", VA = "0x12711C4")]
		public static string DecodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1271BEC", Offset = "0x1271BEC", VA = "0x1271BEC")]
		public LocalizationReader()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB4082C", Offset = "0xB4082C")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x2000030")]
		public enum TermModification
		{
			[Token(Token = "0x40000CA")]
			DontModify,
			[Token(Token = "0x40000CB")]
			ToUpper,
			[Token(Token = "0x40000CC")]
			ToLower,
			[Token(Token = "0x40000CD")]
			ToUpperFirst,
			[Token(Token = "0x40000CE")]
			ToTitle
		}

		[Serializable]
		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40864", Offset = "0xB40864")]
		private sealed class <>c
		{
			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> <>9__50_0;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> <>9__50_1;

			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__50_2;

			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__50_3;

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1286414", Offset = "0x1286414", VA = "0x1286414")]
			public <>c()
			{
			}

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x128641C", Offset = "0x128641C", VA = "0x128641C")]
			internal bool <UpdateAssetDictionary>b__50_0(UnityEngine.Object x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1286484", Offset = "0x1286484", VA = "0x1286484")]
			internal string <UpdateAssetDictionary>b__50_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x6000139")]
			[Address(RVA = "0x12864A0", Offset = "0x12864A0", VA = "0x12864A0")]
			internal string <UpdateAssetDictionary>b__50_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1286548", Offset = "0x1286548", VA = "0x1286548")]
			internal UnityEngine.Object <UpdateAssetDictionary>b__50_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}
		}

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mTerm;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string TermPrefix;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string TermSuffix;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IgnoreRTL;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool AllowParameters;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string mLocalizeTargetName;

		[Token(Token = "0x1700000B")]
		public string Term
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1271BF4", Offset = "0x1271BF4", VA = "0x1271BF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1271BFC", Offset = "0x1271BFC", VA = "0x1271BFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public string SecondaryTerm
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1271C40", Offset = "0x1271C40", VA = "0x1271C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1271C48", Offset = "0x1271C48", VA = "0x1271C48")]
			set
			{
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1271CA8", Offset = "0x1271CA8", VA = "0x1271CA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1272EFC", Offset = "0x1272EFC", VA = "0x1272EFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1272F04", Offset = "0x1272F04", VA = "0x1272F04")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x12725F4", Offset = "0x12725F4", VA = "0x12725F4")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x12720AC", Offset = "0x12720AC", VA = "0x12720AC")]
		public bool FindTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1272F58", Offset = "0x1272F58", VA = "0x1272F58")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x12730C0", Offset = "0x12730C0", VA = "0x12730C0")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1273194", Offset = "0x1273194", VA = "0x1273194")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1271C00", Offset = "0x1271C00", VA = "0x1271C00")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1271C54", Offset = "0x1271C54", VA = "0x1271C54")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x600012B")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1271CEC", Offset = "0x1271CEC", VA = "0x1271CEC")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x600012D")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x12731DC", Offset = "0x12731DC", VA = "0x12731DC")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		}

		[Token(Token = "0x6000130")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x12732CC", Offset = "0x12732CC", VA = "0x12732CC")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x127379C", Offset = "0x127379C", VA = "0x127379C")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1273844", Offset = "0x1273844", VA = "0x1273844")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x12738A8", Offset = "0x12738A8", VA = "0x12738A8")]
		public Localize()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB40874", Offset = "0xB40874")]
	public class LocalizeDropdown : MonoBehaviour
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> _Terms;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1273A80", Offset = "0x1273A80", VA = "0x1273A80")]
		public void Start()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1273C90", Offset = "0x1273C90", VA = "0x1273C90")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1273D34", Offset = "0x1273D34", VA = "0x1273D34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1273B8C", Offset = "0x1273B8C", VA = "0x1273B8C")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1273D90", Offset = "0x1273D90", VA = "0x1273D90")]
		private void FillValues()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1273F64", Offset = "0x1273F64", VA = "0x1273F64")]
		public void UpdateLocalization()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x12743BC", Offset = "0x12743BC", VA = "0x12743BC")]
		public void UpdateLocalizationTMPro()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1274200", Offset = "0x1274200", VA = "0x1274200")]
		private void FillValuesTMPro()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x127464C", Offset = "0x127464C", VA = "0x127464C")]
		public LocalizeDropdown()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class LocalizationManager
	{
		[Token(Token = "0x2000034")]
		public delegate bool FnCustomApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters);

		[Token(Token = "0x2000035")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x2000036")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB408AC", Offset = "0xB408AC")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x12854FC", Offset = "0x12854FC", VA = "0x12854FC")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1285504", Offset = "0x1285504", VA = "0x1285504")]
			internal bool <GetAllLanguages>b__0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB408BC", Offset = "0xB408BC")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1285574", Offset = "0x1285574", VA = "0x1285574")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0x128557C", Offset = "0x128557C", VA = "0x128557C")]
			internal bool <GetAllLanguagesCode>b__0(string x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB408CC", Offset = "0xB408CC")]
		private sealed class <>c
		{
			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static _GetParam <>9__43_0;

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x128548C", Offset = "0x128548C", VA = "0x128548C")]
			public <>c()
			{
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x1285494", Offset = "0x1285494", VA = "0x1285494")]
			internal object <ApplyLocalizationParams>b__43_0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB408DC", Offset = "0xB408DC")]
		private sealed class <>c__DisplayClass44_0
		{
			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject root;

			[Token(Token = "0x600019C")]
			[Address(RVA = "0x12855EC", Offset = "0x12855EC", VA = "0x12855EC")]
			public <>c__DisplayClass44_0()
			{
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x12855F4", Offset = "0x12855F4", VA = "0x12855F4")]
			internal object <ApplyLocalizationParams>b__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB408EC", Offset = "0xB408EC")]
		private sealed class <>c__DisplayClass45_0
		{
			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, object> parameters;

			[Token(Token = "0x600019E")]
			[Address(RVA = "0x128566C", Offset = "0x128566C", VA = "0x128566C")]
			public <>c__DisplayClass45_0()
			{
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1285674", Offset = "0x1285674", VA = "0x1285674")]
			internal object <ApplyLocalizationParams>b__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB408FC", Offset = "0xB408FC")]
		private sealed class <Delayed_Import_Google>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0x1285964", Offset = "0x1285964", VA = "0x1285964", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001A5")]
				[Address(RVA = "0x12859AC", Offset = "0x12859AC", VA = "0x12859AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1285880", Offset = "0x1285880", VA = "0x1285880")]
			[DebuggerHidden]
			public <Delayed_Import_Google>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x12858AC", Offset = "0x12858AC", VA = "0x12858AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x12858B0", Offset = "0x12858B0", VA = "0x12858B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x128596C", Offset = "0x128596C", VA = "0x128596C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4090C", Offset = "0xB4090C")]
		private sealed class <>c__DisplayClass73_0
		{
			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ILocalizeTargetDescriptor desc;

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x12856F0", Offset = "0x12856F0", VA = "0x12856F0")]
			public <>c__DisplayClass73_0()
			{
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x12856F8", Offset = "0x12856F8", VA = "0x12856F8")]
			internal bool <RegisterTarget>b__0(ILocalizeTargetDescriptor x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4091C", Offset = "0xB4091C")]
		private sealed class <Coroutine_LocalizeAll>d__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000014")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001AB")]
				[Address(RVA = "0x1285830", Offset = "0x1285830", VA = "0x1285830", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000015")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001AD")]
				[Address(RVA = "0x1285878", Offset = "0x1285878", VA = "0x1285878", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x1285724", Offset = "0x1285724", VA = "0x1285724")]
			[DebuggerHidden]
			public <Coroutine_LocalizeAll>d__88(int <>1__state)
			{
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x1285750", Offset = "0x1285750", VA = "0x1285750", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1285754", Offset = "0x1285754", VA = "0x1285754", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1285838", Offset = "0x1285838", VA = "0x1285838", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mLanguageCode;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool IsRight2Left;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool HasJoinedWords;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static FnCustomApplyLocalizationParams CustomApplyLocalizationParams;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] GlobalSources;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x1700000D")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1DD91A0", Offset = "0x1DD91A0", VA = "0x1DD91A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1DDCD14", Offset = "0x1DDCD14", VA = "0x1DDCD14")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1DDD6D4", Offset = "0x1DDD6D4", VA = "0x1DDD6D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1DDD73C", Offset = "0x1DDD73C", VA = "0x1DDD73C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public static string CurrentRegion
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1DDDA4C", Offset = "0x1DDDA4C", VA = "0x1DDDA4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1DDDBCC", Offset = "0x1DDDBCC", VA = "0x1DDDBCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1DDDD98", Offset = "0x1DDDD98", VA = "0x1DDDD98")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1DDDE74", Offset = "0x1DDDE74", VA = "0x1DDDE74")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1DDDF8C", Offset = "0x1DDDF8C", VA = "0x1DDDF8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000003")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1DE1478", Offset = "0x1DE1478", VA = "0x1DE1478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB413CC", Offset = "0xB413CC")]
			add
			{
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1DE1570", Offset = "0x1DE1570", VA = "0x1DE1570")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB413DC", Offset = "0xB413DC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1DC9620", Offset = "0x1DC9620", VA = "0x1DC9620")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1DDCCD0", Offset = "0x1DDCCD0", VA = "0x1DDCCD0")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1DDA4B8", Offset = "0x1DDA4B8", VA = "0x1DDA4B8")]
		public static int GetRequiredWebServiceVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1DC9174", Offset = "0x1DC9174", VA = "0x1DC9174")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1DDD4C0", Offset = "0x1DDD4C0", VA = "0x1DDD4C0")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1DDDFF0", Offset = "0x1DDDFF0", VA = "0x1DDDFF0")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1DDE224", Offset = "0x1DDE224", VA = "0x1DDE224")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1DDE110", Offset = "0x1DDE110", VA = "0x1DDE110")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1DDC7FC", Offset = "0x1DDC7FC", VA = "0x1DDC7FC")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1DDE39C", Offset = "0x1DDE39C", VA = "0x1DDE39C")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1DDCE00", Offset = "0x1DDCE00", VA = "0x1DDCE00")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1DDD2B0", Offset = "0x1DDD2B0", VA = "0x1DDD2B0")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1DDD82C", Offset = "0x1DDD82C", VA = "0x1DDD82C")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1DDE5BC", Offset = "0x1DDE5BC", VA = "0x1DDE5BC")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1DDE854", Offset = "0x1DDE854", VA = "0x1DDE854")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1DDEAC8", Offset = "0x1DDEAC8", VA = "0x1DDEAC8")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1DDEBE8", Offset = "0x1DDEBE8", VA = "0x1DDEBE8")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1DDED48", Offset = "0x1DDED48", VA = "0x1DDED48")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1DDC5AC", Offset = "0x1DDC5AC", VA = "0x1DDC5AC")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1DDEE38", Offset = "0x1DDEE38", VA = "0x1DDEE38")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1DDF424", Offset = "0x1DDF424", VA = "0x1DDF424")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1DDF514", Offset = "0x1DDF514", VA = "0x1DDF514")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1DDEF60", Offset = "0x1DDEF60", VA = "0x1DDEF60")]
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1DDF788", Offset = "0x1DDF788", VA = "0x1DDF788")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1DDFA6C", Offset = "0x1DDFA6C", VA = "0x1DDFA6C")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1DDFC50", Offset = "0x1DDFC50", VA = "0x1DDFC50")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1DDFCB8", Offset = "0x1DDFCB8", VA = "0x1DDFCB8")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1DE00F4", Offset = "0x1DE00F4", VA = "0x1DE00F4")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1DDE194", Offset = "0x1DDE194", VA = "0x1DDE194")]
		public static bool IsRTL(string Code)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1DDC76C", Offset = "0x1DDC76C", VA = "0x1DDC76C")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1DE01A4", Offset = "0x1DE01A4", VA = "0x1DE01A4")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1DE04C8", Offset = "0x1DE04C8", VA = "0x1DE04C8")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1DE02F4", Offset = "0x1DE02F4", VA = "0x1DE02F4")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1DE0674", Offset = "0x1DE0674", VA = "0x1DE0674")]
		private static bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1DD41CC", Offset = "0x1DD41CC", VA = "0x1DD41CC")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1DE0738", Offset = "0x1DE0738", VA = "0x1DE0738")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB4136C", Offset = "0xB4136C")]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1DD4CD4", Offset = "0x1DD4CD4", VA = "0x1DD4CD4")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1DE07C8", Offset = "0x1DE07C8", VA = "0x1DE07C8")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1DE0858", Offset = "0x1DE0858", VA = "0x1DE0858")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1DE0A58", Offset = "0x1DE0A58", VA = "0x1DE0A58")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1DE0BB8", Offset = "0x1DE0BB8", VA = "0x1DE0BB8")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1DDE2D4", Offset = "0x1DDE2D4", VA = "0x1DDE2D4")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1DE0CB8", Offset = "0x1DE0CB8", VA = "0x1DE0CB8")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1DE11EC", Offset = "0x1DE11EC", VA = "0x1DE11EC")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1DE1668", Offset = "0x1DE1668", VA = "0x1DE1668")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1DE1958", Offset = "0x1DE1958", VA = "0x1DE1958")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1DE1738", Offset = "0x1DE1738", VA = "0x1DE1738")]
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1DE1A10", Offset = "0x1DE1A10", VA = "0x1DE1A10")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1DD4BD0", Offset = "0x1DD4BD0", VA = "0x1DD4BD0")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1DE1E10", Offset = "0x1DE1E10", VA = "0x1DE1E10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB413EC", Offset = "0xB413EC")]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1DE1C74", Offset = "0x1DE1C74", VA = "0x1DE1C74")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1DE1E6C", Offset = "0x1DE1E6C", VA = "0x1DE1E6C")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1DE1FBC", Offset = "0x1DE1FBC", VA = "0x1DE1FBC")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1DE2254", Offset = "0x1DE2254", VA = "0x1DE2254")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1DDF604", Offset = "0x1DDF604", VA = "0x1DDF604")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x60001AE")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x60001AF")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x60001B0")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x60001B1")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x60001B2")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x60001B3")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x60001B4")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x60001B5")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1DCE9C8", Offset = "0x1DCE9C8", VA = "0x1DCE9C8")]
		protected ILocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x60001B7")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		protected LocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x60001B9")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x60001BA")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x60001BB")]
		public abstract Type GetTargetType();

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1DCE9D0", Offset = "0x1DCE9D0", VA = "0x1DCE9D0")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x60001BD")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		protected LocalizeTargetDesc()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x60001C0")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x127479C", Offset = "0x127479C", VA = "0x127479C")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x12747A0", Offset = "0x12747A0", VA = "0x12747A0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB414EC", Offset = "0xB414EC")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1274868", Offset = "0x1274868", VA = "0x1274868", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1274870", Offset = "0x1274870", VA = "0x1274870", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1274878", Offset = "0x1274878", VA = "0x1274878", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1274880", Offset = "0x1274880", VA = "0x1274880", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1274888", Offset = "0x1274888", VA = "0x1274888", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1274890", Offset = "0x1274890", VA = "0x1274890", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x12749B8", Offset = "0x12749B8", VA = "0x12749B8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1275024", Offset = "0x1275024", VA = "0x1275024")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x12752C4", Offset = "0x12752C4", VA = "0x12752C4")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1274F20", Offset = "0x1274F20", VA = "0x1274F20")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x12751A0", Offset = "0x12751A0", VA = "0x12751A0")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x12754D8", Offset = "0x12754D8", VA = "0x12754D8")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1275538", Offset = "0x1275538", VA = "0x1275538")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x127553C", Offset = "0x127553C", VA = "0x127553C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB41500", Offset = "0xB41500")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1275604", Offset = "0x1275604", VA = "0x1275604", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x127560C", Offset = "0x127560C", VA = "0x127560C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1275614", Offset = "0x1275614", VA = "0x1275614", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x127561C", Offset = "0x127561C", VA = "0x127561C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1275624", Offset = "0x1275624", VA = "0x1275624", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x127562C", Offset = "0x127562C", VA = "0x127562C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1275754", Offset = "0x1275754", VA = "0x1275754", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1275CBC", Offset = "0x1275CBC", VA = "0x1275CBC")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1275D1C", Offset = "0x1275D1C", VA = "0x1275D1C")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1275D20", Offset = "0x1275D20", VA = "0x1275D20")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB41514", Offset = "0xB41514")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1275DE8", Offset = "0x1275DE8", VA = "0x1275DE8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1275DF0", Offset = "0x1275DF0", VA = "0x1275DF0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1275DF8", Offset = "0x1275DF8", VA = "0x1275DF8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1275E00", Offset = "0x1275E00", VA = "0x1275E00", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1275E08", Offset = "0x1275E08", VA = "0x1275E08", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1275E10", Offset = "0x1275E10", VA = "0x1275E10", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1275EE4", Offset = "0x1275EE4", VA = "0x1275EE4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1276068", Offset = "0x1276068", VA = "0x1276068")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x12746C4", Offset = "0x12746C4", VA = "0x12746C4", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x12746FC", Offset = "0x12746FC", VA = "0x12746FC")]
		public LocalizeTargetDesc_Child()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x12760B4", Offset = "0x12760B4", VA = "0x12760B4")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x12760B8", Offset = "0x12760B8", VA = "0x12760B8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB41528", Offset = "0xB41528")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1276168", Offset = "0x1276168", VA = "0x1276168", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x12761A0", Offset = "0x12761A0", VA = "0x12761A0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x12761A8", Offset = "0x12761A8", VA = "0x12761A8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x12761B0", Offset = "0x12761B0", VA = "0x12761B0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x12761B8", Offset = "0x12761B8", VA = "0x12761B8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x12761C0", Offset = "0x12761C0", VA = "0x12761C0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x12761C8", Offset = "0x12761C8", VA = "0x12761C8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1276204", Offset = "0x1276204", VA = "0x1276204", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1276358", Offset = "0x1276358", VA = "0x1276358")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x12763A4", Offset = "0x12763A4", VA = "0x12763A4")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x12763A8", Offset = "0x12763A8", VA = "0x12763A8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB4153C", Offset = "0xB4153C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1276470", Offset = "0x1276470", VA = "0x1276470", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1276478", Offset = "0x1276478", VA = "0x1276478", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1276480", Offset = "0x1276480", VA = "0x1276480", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1276488", Offset = "0x1276488", VA = "0x1276488", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1276490", Offset = "0x1276490", VA = "0x1276490", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1276498", Offset = "0x1276498", VA = "0x1276498", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x12766A0", Offset = "0x12766A0", VA = "0x12766A0", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1276898", Offset = "0x1276898", VA = "0x1276898")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1274748", Offset = "0x1274748", VA = "0x1274748", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1274750", Offset = "0x1274750", VA = "0x1274750")]
		public LocalizeTargetDesc_Prefab()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x12768E4", Offset = "0x12768E4", VA = "0x12768E4")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x12768E8", Offset = "0x12768E8", VA = "0x12768E8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB41550", Offset = "0xB41550")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1276998", Offset = "0x1276998", VA = "0x1276998", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x12769A0", Offset = "0x12769A0", VA = "0x12769A0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x12769A8", Offset = "0x12769A8", VA = "0x12769A8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x12769B0", Offset = "0x12769B0", VA = "0x12769B0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x12769B8", Offset = "0x12769B8", VA = "0x12769B8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x12769C0", Offset = "0x12769C0", VA = "0x12769C0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x12769C8", Offset = "0x12769C8", VA = "0x12769C8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1276A04", Offset = "0x1276A04", VA = "0x1276A04", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1276C34", Offset = "0x1276C34", VA = "0x1276C34")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1276DF4", Offset = "0x1276DF4", VA = "0x1276DF4")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1276E40", Offset = "0x1276E40", VA = "0x1276E40")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1276E44", Offset = "0x1276E44", VA = "0x1276E44")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB41564", Offset = "0xB41564")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1276F0C", Offset = "0x1276F0C", VA = "0x1276F0C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1276F14", Offset = "0x1276F14", VA = "0x1276F14", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1276F1C", Offset = "0x1276F1C", VA = "0x1276F1C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1276F24", Offset = "0x1276F24", VA = "0x1276F24", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1276F2C", Offset = "0x1276F2C", VA = "0x1276F2C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1276F34", Offset = "0x1276F34", VA = "0x1276F34", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x127700C", Offset = "0x127700C", VA = "0x127700C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1277114", Offset = "0x1277114", VA = "0x1277114")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1277160", Offset = "0x1277160", VA = "0x1277160")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1277164", Offset = "0x1277164", VA = "0x1277164")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB41578", Offset = "0xB41578")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x127722C", Offset = "0x127722C", VA = "0x127722C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1277234", Offset = "0x1277234", VA = "0x1277234", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x127723C", Offset = "0x127723C", VA = "0x127723C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1277244", Offset = "0x1277244", VA = "0x1277244", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x127724C", Offset = "0x127724C", VA = "0x127724C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1277254", Offset = "0x1277254", VA = "0x1277254", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1277384", Offset = "0x1277384", VA = "0x1277384", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1277660", Offset = "0x1277660", VA = "0x1277660")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class LocalizeTarget_UnityStandard_VideoPlayer : LocalizeTarget<VideoPlayer>
	{
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x12776BC", Offset = "0x12776BC", VA = "0x12776BC")]
		static LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x12776C0", Offset = "0x12776C0", VA = "0x12776C0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB4158C", Offset = "0xB4158C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1277788", Offset = "0x1277788", VA = "0x1277788", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1277790", Offset = "0x1277790", VA = "0x1277790", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1277798", Offset = "0x1277798", VA = "0x1277798", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x12777A0", Offset = "0x12777A0", VA = "0x12777A0", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x12777A8", Offset = "0x12777A8", VA = "0x12777A8", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x12777B0", Offset = "0x12777B0", VA = "0x12777B0", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1277888", Offset = "0x1277888", VA = "0x1277888", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1277990", Offset = "0x1277990", VA = "0x1277990")]
		public LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x12779DC", Offset = "0x12779DC", VA = "0x12779DC")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x12779E0", Offset = "0x12779E0", VA = "0x12779E0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB415A0", Offset = "0xB415A0")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1277AA8", Offset = "0x1277AA8", VA = "0x1277AA8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1277AB0", Offset = "0x1277AB0", VA = "0x1277AB0", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1277AB8", Offset = "0x1277AB8", VA = "0x1277AB8", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1277AC0", Offset = "0x1277AC0", VA = "0x1277AC0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1277B4C", Offset = "0x1277B4C", VA = "0x1277B4C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1277B54", Offset = "0x1277B54", VA = "0x1277B54", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1277CEC", Offset = "0x1277CEC", VA = "0x1277CEC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1277DE8", Offset = "0x1277DE8", VA = "0x1277DE8")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1277E34", Offset = "0x1277E34", VA = "0x1277E34")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1277E38", Offset = "0x1277E38", VA = "0x1277E38")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB415B4", Offset = "0xB415B4")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1277F00", Offset = "0x1277F00", VA = "0x1277F00", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1277F08", Offset = "0x1277F08", VA = "0x1277F08", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1277F10", Offset = "0x1277F10", VA = "0x1277F10", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1277F18", Offset = "0x1277F18", VA = "0x1277F18", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1277F20", Offset = "0x1277F20", VA = "0x1277F20", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1277F28", Offset = "0x1277F28", VA = "0x1277F28", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1278010", Offset = "0x1278010", VA = "0x1278010", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x127810C", Offset = "0x127810C", VA = "0x127810C")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1278158", Offset = "0x1278158", VA = "0x1278158")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x127815C", Offset = "0x127815C", VA = "0x127815C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB415C8", Offset = "0xB415C8")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1278224", Offset = "0x1278224", VA = "0x1278224", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x127822C", Offset = "0x127822C", VA = "0x127822C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1278234", Offset = "0x1278234", VA = "0x1278234", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x127823C", Offset = "0x127823C", VA = "0x127823C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1278244", Offset = "0x1278244", VA = "0x1278244", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x127824C", Offset = "0x127824C", VA = "0x127824C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1278384", Offset = "0x1278384", VA = "0x1278384", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x127867C", Offset = "0x127867C", VA = "0x127867C")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x127873C", Offset = "0x127873C", VA = "0x127873C")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public enum eTermType
	{
		[Token(Token = "0x400010B")]
		Text,
		[Token(Token = "0x400010C")]
		Font,
		[Token(Token = "0x400010D")]
		Texture,
		[Token(Token = "0x400010E")]
		AudioClip,
		[Token(Token = "0x400010F")]
		GameObject,
		[Token(Token = "0x4000110")]
		Sprite,
		[Token(Token = "0x4000111")]
		Material,
		[Token(Token = "0x4000112")]
		Child,
		[Token(Token = "0x4000113")]
		Mesh,
		[Token(Token = "0x4000114")]
		TextMeshPFont,
		[Token(Token = "0x4000115")]
		Object,
		[Token(Token = "0x4000116")]
		Video
	}
	[Token(Token = "0x2000053")]
	public enum TranslationFlag : byte
	{
		[Token(Token = "0x4000118")]
		Normal = 1,
		[Token(Token = "0x4000119")]
		AutoTranslated
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class TermData
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[NonSerialized]
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

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x127E1C0", Offset = "0x127E1C0", VA = "0x127E1C0")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x127E2F0", Offset = "0x127E2F0", VA = "0x127E2F0")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x127E3DC", Offset = "0x127E3DC", VA = "0x127E3DC")]
		public void RemoveSpecialization(string specialization)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x127E43C", Offset = "0x127E43C", VA = "0x127E43C")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x127E5DC", Offset = "0x127E5DC", VA = "0x127E5DC")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x127E61C", Offset = "0x127E61C", VA = "0x127E61C")]
		public void Validate()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x127E7FC", Offset = "0x127E7FC", VA = "0x127E7FC")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x127E890", Offset = "0x127E890", VA = "0x127E890")]
		public bool HasSpecializations()
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x127E964", Offset = "0x127E964", VA = "0x127E964")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x127EA60", Offset = "0x127EA60", VA = "0x127EA60")]
		public TermData()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class TermsPopup : PropertyAttribute
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB410EC", Offset = "0xB410EC")]
		private string <Filter>k__BackingField;

		[Token(Token = "0x17000016")]
		public string Filter
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x127EC28", Offset = "0x127EC28", VA = "0x127EC28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB415DC", Offset = "0xB415DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x127EC30", Offset = "0x127EC30", VA = "0x127EC30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB415EC", Offset = "0xB415EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x127EBFC", Offset = "0x127EBFC", VA = "0x127EBFC")]
		public TermsPopup(string filter = "")
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x18722C8", Offset = "0x18722C8", VA = "0x18722C8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1872328", Offset = "0x1872328", VA = "0x1872328")]
		public AutoChangeCultureInfo()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x17000017")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x1872958", Offset = "0x1872958", VA = "0x1872958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1872AAC", Offset = "0x1872AAC", VA = "0x1872AAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1872B3C", Offset = "0x1872B3C", VA = "0x1872B3C")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1872B6C", Offset = "0x1872B6C", VA = "0x1872B6C")]
		public CoroutineManager()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB4092C", Offset = "0xB4092C")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1872B74", Offset = "0x1872B74", VA = "0x1872B74")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1872C4C", Offset = "0x1872C4C", VA = "0x1872C4C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1872CF4", Offset = "0x1872CF4", VA = "0x1872CF4")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1872D10", Offset = "0x1872D10", VA = "0x1872D10")]
		public CustomLocalizeCallback()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class HindiFixer
	{
		[Serializable]
		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40964", Offset = "0xB40964")]
		private sealed class <>c
		{
			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__0_0;

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x12834F8", Offset = "0x12834F8", VA = "0x12834F8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x1283500", Offset = "0x1283500", VA = "0x1283500")]
			internal bool <Fix>b__0_0(char x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1DCC614", Offset = "0x1DCC614", VA = "0x1DCC614")]
		internal static string Fix(string text)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1DCCAA8", Offset = "0x1DCCAA8", VA = "0x1DCCAA8")]
		public HindiFixer()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public static class I2Utils
	{
		[StructLayout(3)]
		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40984", Offset = "0xB40984")]
		private struct <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public char[] output;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string source;
		}

		[Serializable]
		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40994", Offset = "0xB40994")]
		private sealed class <>c
		{
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__6_0;

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x128356C", Offset = "0x128356C", VA = "0x128356C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x1283574", Offset = "0x1283574", VA = "0x1283574")]
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
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1DCD9D0", Offset = "0x1DCD9D0", VA = "0x1DCD9D0")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1DCDBF4", Offset = "0x1DCDBF4", VA = "0x1DCDBF4")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1DCDE30", Offset = "0x1DCDE30", VA = "0x1DCDE30")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1DCDEF0", Offset = "0x1DCDEF0", VA = "0x1DCDEF0")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1DCE1D4", Offset = "0x1DCE1D4", VA = "0x1DCE1D4")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1DCDE5C", Offset = "0x1DCDE5C", VA = "0x1DCDE5C")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1DCE35C", Offset = "0x1DCE35C", VA = "0x1DCE35C")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1DCE5E0", Offset = "0x1DCE5E0", VA = "0x1DCE5E0")]
		public static bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1DCE5E8", Offset = "0x1DCE5E8", VA = "0x1DCE5E8")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1DCE6C4", Offset = "0x1DCE6C4", VA = "0x1DCE6C4")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1DCE730", Offset = "0x1DCE730", VA = "0x1DCE730")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1DCE87C", Offset = "0x1DCE87C", VA = "0x1DCE87C")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1DCBCD0", Offset = "0x1DCBCD0", VA = "0x1DCBCD0")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1DCE9B0", Offset = "0x1DCE9B0", VA = "0x1DCE9B0")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1DCDB64", Offset = "0x1DCDB64", VA = "0x1DCDB64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4160C", Offset = "0xB4160C")]
		internal static void <ReverseText>g__Reverse|3_0(int start, int end, ref <>c__DisplayClass3_0 P_2)
		{
		}
	}
	[Token(Token = "0x200005E")]
	public interface ILocalizationParamsManager
	{
		[Token(Token = "0x6000276")]
		string GetParameterValue(string Param);
	}
	[Token(Token = "0x200005F")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x2000060")]
		public struct ParamValue
		{
			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _IsGlobalManager;

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1DE2ADC", Offset = "0x1DE2ADC", VA = "0x1DE2ADC", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1DE2BD0", Offset = "0x1DE2BD0", VA = "0x1DE2BD0")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1DE2D50", Offset = "0x1DE2D50", VA = "0x1DE2D50")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1DE2E08", Offset = "0x1DE2E08", VA = "0x1DE2E08", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1DE2E18", Offset = "0x1DE2E18", VA = "0x1DE2E18")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1DE2F04", Offset = "0x1DE2F04", VA = "0x1DE2F04")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1DE2F90", Offset = "0x1DE2F90", VA = "0x1DE2F90")]
		public LocalizationParamsManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public struct LocalizedString
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string mTerm;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool mRTL_IgnoreArabicFix;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mRTL_MaxLineLength;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool mRTL_ConvertNumbers;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_DontLocalizeParameters;

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1278798", Offset = "0x1278798", VA = "0x1278798")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1278870", Offset = "0x1278870", VA = "0x1278870")]
		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x127887C", Offset = "0x127887C", VA = "0x127887C")]
		public LocalizedString(LocalizedString str)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x127879C", Offset = "0x127879C", VA = "0x127879C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000062")]
	public class RTLFixer
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1279004", Offset = "0x1279004", VA = "0x1279004")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x12792B8", Offset = "0x12792B8", VA = "0x12792B8")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1279010", Offset = "0x1279010", VA = "0x1279010")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x127A298", Offset = "0x127A298", VA = "0x127A298")]
		public RTLFixer()
		{
		}
	}
	[Token(Token = "0x2000063")]
	internal enum IsolatedArabicLetters
	{
		[Token(Token = "0x4000136")]
		Hamza = 65152,
		[Token(Token = "0x4000137")]
		Alef = 65165,
		[Token(Token = "0x4000138")]
		AlefHamza = 65155,
		[Token(Token = "0x4000139")]
		WawHamza = 65157,
		[Token(Token = "0x400013A")]
		AlefMaksoor = 65159,
		[Token(Token = "0x400013B")]
		AlefMaksora = 64508,
		[Token(Token = "0x400013C")]
		HamzaNabera = 65161,
		[Token(Token = "0x400013D")]
		Ba = 65167,
		[Token(Token = "0x400013E")]
		Ta = 65173,
		[Token(Token = "0x400013F")]
		Tha2 = 65177,
		[Token(Token = "0x4000140")]
		Jeem = 65181,
		[Token(Token = "0x4000141")]
		H7aa = 65185,
		[Token(Token = "0x4000142")]
		Khaa2 = 65189,
		[Token(Token = "0x4000143")]
		Dal = 65193,
		[Token(Token = "0x4000144")]
		Thal = 65195,
		[Token(Token = "0x4000145")]
		Ra2 = 65197,
		[Token(Token = "0x4000146")]
		Zeen = 65199,
		[Token(Token = "0x4000147")]
		Seen = 65201,
		[Token(Token = "0x4000148")]
		Sheen = 65205,
		[Token(Token = "0x4000149")]
		S9a = 65209,
		[Token(Token = "0x400014A")]
		Dha = 65213,
		[Token(Token = "0x400014B")]
		T6a = 65217,
		[Token(Token = "0x400014C")]
		T6ha = 65221,
		[Token(Token = "0x400014D")]
		Ain = 65225,
		[Token(Token = "0x400014E")]
		Gain = 65229,
		[Token(Token = "0x400014F")]
		Fa = 65233,
		[Token(Token = "0x4000150")]
		Gaf = 65237,
		[Token(Token = "0x4000151")]
		Kaf = 65241,
		[Token(Token = "0x4000152")]
		Lam = 65245,
		[Token(Token = "0x4000153")]
		Meem = 65249,
		[Token(Token = "0x4000154")]
		Noon = 65253,
		[Token(Token = "0x4000155")]
		Ha = 65257,
		[Token(Token = "0x4000156")]
		Waw = 65261,
		[Token(Token = "0x4000157")]
		Ya = 65265,
		[Token(Token = "0x4000158")]
		AlefMad = 65153,
		[Token(Token = "0x4000159")]
		TaMarboota = 65171,
		[Token(Token = "0x400015A")]
		PersianPe = 64342,
		[Token(Token = "0x400015B")]
		PersianChe = 64378,
		[Token(Token = "0x400015C")]
		PersianZe = 64394,
		[Token(Token = "0x400015D")]
		PersianGaf = 64402,
		[Token(Token = "0x400015E")]
		PersianGaf2 = 64398
	}
	[Token(Token = "0x2000064")]
	internal enum GeneralArabicLetters
	{
		[Token(Token = "0x4000160")]
		Hamza = 1569,
		[Token(Token = "0x4000161")]
		Alef = 1575,
		[Token(Token = "0x4000162")]
		AlefHamza = 1571,
		[Token(Token = "0x4000163")]
		WawHamza = 1572,
		[Token(Token = "0x4000164")]
		AlefMaksoor = 1573,
		[Token(Token = "0x4000165")]
		AlefMagsora = 1609,
		[Token(Token = "0x4000166")]
		HamzaNabera = 1574,
		[Token(Token = "0x4000167")]
		Ba = 1576,
		[Token(Token = "0x4000168")]
		Ta = 1578,
		[Token(Token = "0x4000169")]
		Tha2 = 1579,
		[Token(Token = "0x400016A")]
		Jeem = 1580,
		[Token(Token = "0x400016B")]
		H7aa = 1581,
		[Token(Token = "0x400016C")]
		Khaa2 = 1582,
		[Token(Token = "0x400016D")]
		Dal = 1583,
		[Token(Token = "0x400016E")]
		Thal = 1584,
		[Token(Token = "0x400016F")]
		Ra2 = 1585,
		[Token(Token = "0x4000170")]
		Zeen = 1586,
		[Token(Token = "0x4000171")]
		Seen = 1587,
		[Token(Token = "0x4000172")]
		Sheen = 1588,
		[Token(Token = "0x4000173")]
		S9a = 1589,
		[Token(Token = "0x4000174")]
		Dha = 1590,
		[Token(Token = "0x4000175")]
		T6a = 1591,
		[Token(Token = "0x4000176")]
		T6ha = 1592,
		[Token(Token = "0x4000177")]
		Ain = 1593,
		[Token(Token = "0x4000178")]
		Gain = 1594,
		[Token(Token = "0x4000179")]
		Fa = 1601,
		[Token(Token = "0x400017A")]
		Gaf = 1602,
		[Token(Token = "0x400017B")]
		Kaf = 1603,
		[Token(Token = "0x400017C")]
		Lam = 1604,
		[Token(Token = "0x400017D")]
		Meem = 1605,
		[Token(Token = "0x400017E")]
		Noon = 1606,
		[Token(Token = "0x400017F")]
		Ha = 1607,
		[Token(Token = "0x4000180")]
		Waw = 1608,
		[Token(Token = "0x4000181")]
		Ya = 1610,
		[Token(Token = "0x4000182")]
		AlefMad = 1570,
		[Token(Token = "0x4000183")]
		TaMarboota = 1577,
		[Token(Token = "0x4000184")]
		PersianPe = 1662,
		[Token(Token = "0x4000185")]
		PersianChe = 1670,
		[Token(Token = "0x4000186")]
		PersianZe = 1688,
		[Token(Token = "0x4000187")]
		PersianGaf = 1711,
		[Token(Token = "0x4000188")]
		PersianGaf2 = 1705
	}
	[Token(Token = "0x2000065")]
	internal class ArabicMapping
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int from;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int to;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x18715B0", Offset = "0x18715B0", VA = "0x18715B0")]
		public ArabicMapping(int from, int to)
		{
		}
	}
	[Token(Token = "0x2000066")]
	internal class ArabicTable
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x17000018")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x18720F8", Offset = "0x18720F8", VA = "0x18720F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x18715E8", Offset = "0x18715E8", VA = "0x18715E8")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x187216C", Offset = "0x187216C", VA = "0x187216C")]
		internal int Convert(int toBeConverted)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000067")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x127A88C", Offset = "0x127A88C", VA = "0x127A88C")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
	[Token(Token = "0x2000068")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x127A2A0", Offset = "0x127A2A0", VA = "0x127A2A0")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x127A8C8", Offset = "0x127A8C8", VA = "0x127A8C8")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x127950C", Offset = "0x127950C", VA = "0x127950C")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x127AB1C", Offset = "0x127AB1C", VA = "0x127AB1C")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x127B170", Offset = "0x127B170", VA = "0x127B170")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x127B010", Offset = "0x127B010", VA = "0x127B010")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x127AC94", Offset = "0x127AC94", VA = "0x127AC94")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x127B4A8", Offset = "0x127B4A8", VA = "0x127B4A8")]
		public RTLFixerTool()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
	{
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x127B500", Offset = "0x127B500", VA = "0x127B500")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x127B5B8", Offset = "0x127B5B8", VA = "0x127B5B8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x127B670", Offset = "0x127B670", VA = "0x127B670")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x127B6D4", Offset = "0x127B6D4", VA = "0x127B6D4", Slot = "4")]
		public virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x127B6DC", Offset = "0x127B6DC", VA = "0x127B6DC")]
		public RegisterCallback_AllowSyncFromGoogle()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x127B6E4", Offset = "0x127B6E4", VA = "0x127B6E4", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x127B7D4", Offset = "0x127B7D4", VA = "0x127B7D4", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x127B860", Offset = "0x127B860", VA = "0x127B860", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x127B868", Offset = "0x127B868", VA = "0x127B868")]
		public RegisterGlobalParameters()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public interface IResourceManager_Bundles
	{
		[Token(Token = "0x600029D")]
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}
	[Token(Token = "0x200006C")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object[] Assets;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;

		[Token(Token = "0x17000019")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x1273358", Offset = "0x1273358", VA = "0x1273358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x127B870", Offset = "0x127B870", VA = "0x127B870")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60002A0")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x127B958", Offset = "0x127B958", VA = "0x127B958")]
		private UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1273730", Offset = "0x1273730", VA = "0x1273730")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x127B8E0", Offset = "0x127B8E0", VA = "0x127B8E0")]
		public void CleanResourceCache(bool unloadResources = false)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x127BA94", Offset = "0x127BA94", VA = "0x127BA94")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB409A4", Offset = "0xB409A4")]
	public class SetLanguage : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _Language;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x127BBC8", Offset = "0x127BBC8", VA = "0x127BBC8")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x127BBCC", Offset = "0x127BBCC", VA = "0x127BBCC")]
		public void ApplyLanguage()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x127BC84", Offset = "0x127BC84", VA = "0x127BC84")]
		public SetLanguage()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB409DC", Offset = "0xB409DC")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x127BC8C", Offset = "0x127BC8C", VA = "0x127BC8C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x127BF20", Offset = "0x127BF20", VA = "0x127BF20")]
		private void OnValueChanged(int index)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x127C024", Offset = "0x127C024", VA = "0x127C024")]
		public SetLanguageDropdown()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class StringObfucator
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x127DC94", Offset = "0x127DC94", VA = "0x127DC94")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x127DFC8", Offset = "0x127DFC8", VA = "0x127DFC8")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x127DF38", Offset = "0x127DF38", VA = "0x127DF38")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x127E0AC", Offset = "0x127E0AC", VA = "0x127E0AC")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x127DD78", Offset = "0x127DD78", VA = "0x127DD78")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x127E144", Offset = "0x127E144", VA = "0x127E144")]
		public StringObfucator()
		{
		}
	}
}
namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000070")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x4000198")]
		Array = 1,
		[Token(Token = "0x4000199")]
		Class,
		[Token(Token = "0x400019A")]
		Value,
		[Token(Token = "0x400019B")]
		IntValue,
		[Token(Token = "0x400019C")]
		DoubleValue,
		[Token(Token = "0x400019D")]
		BoolValue,
		[Token(Token = "0x400019E")]
		FloatValue
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB40A14", Offset = "0xB40A14")]
	public class JSONNode
	{
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40A4C", Offset = "0xB40A4C")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
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

			[Token(Token = "0x17000026")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002E8")]
				[Address(RVA = "0x1284168", Offset = "0x1284168", VA = "0x1284168", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002EA")]
				[Address(RVA = "0x12841B0", Offset = "0x12841B0", VA = "0x12841B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x1284114", Offset = "0x1284114", VA = "0x1284114")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x128414C", Offset = "0x128414C", VA = "0x128414C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x1284150", Offset = "0x1284150", VA = "0x1284150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x1284170", Offset = "0x1284170", VA = "0x1284170", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x12841B8", Offset = "0x12841B8", VA = "0x12841B8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x128424C", Offset = "0x128424C", VA = "0x128424C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40A5C", Offset = "0xB40A5C")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000028")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002F2")]
				[Address(RVA = "0x12848C8", Offset = "0x12848C8", VA = "0x12848C8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002F4")]
				[Address(RVA = "0x1284910", Offset = "0x1284910", VA = "0x1284910", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x1284250", Offset = "0x1284250", VA = "0x1284250")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x1284288", Offset = "0x1284288", VA = "0x1284288", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x1284490", Offset = "0x1284490", VA = "0x1284490", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x12843D4", Offset = "0x12843D4", VA = "0x12843D4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x1284318", Offset = "0x1284318", VA = "0x1284318")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x12848D0", Offset = "0x12848D0", VA = "0x12848D0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x1284918", Offset = "0x1284918", VA = "0x1284918", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x12849C0", Offset = "0x12849C0", VA = "0x12849C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1DD2014", Offset = "0x1DD2014", VA = "0x1DD2014", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x1DD201C", Offset = "0x1DD201C", VA = "0x1DD201C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x1DD2020", Offset = "0x1DD2020", VA = "0x1DD2020", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x1DD2028", Offset = "0x1DD2028", VA = "0x1DD2028", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public virtual string Value
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x1DD202C", Offset = "0x1DD202C", VA = "0x1DD202C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1DD2070", Offset = "0x1DD2070", VA = "0x1DD2070", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public virtual int Count
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x1DD2074", Offset = "0x1DD2074", VA = "0x1DD2074", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001E")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1DD20F8", Offset = "0x1DD20F8", VA = "0x1DD20F8", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB4161C", Offset = "0xB4161C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1DD2154", Offset = "0x1DD2154", VA = "0x1DD2154")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB4167C", Offset = "0xB4167C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public virtual int AsInt
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1DD2248", Offset = "0x1DD2248", VA = "0x1DD2248", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1DD2288", Offset = "0x1DD2288", VA = "0x1DD2288", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public virtual float AsFloat
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1DD22C8", Offset = "0x1DD22C8", VA = "0x1DD22C8", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1DD230C", Offset = "0x1DD230C", VA = "0x1DD230C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public virtual double AsDouble
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1DD234C", Offset = "0x1DD234C", VA = "0x1DD234C", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1DD23EC", Offset = "0x1DD23EC", VA = "0x1DD23EC", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public virtual bool AsBool
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1DD242C", Offset = "0x1DD242C", VA = "0x1DD242C", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1DD24F0", Offset = "0x1DD24F0", VA = "0x1DD24F0", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1DD2574", Offset = "0x1DD2574", VA = "0x1DD2574", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1DD25F0", Offset = "0x1DD25F0", VA = "0x1DD25F0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1DD2010", Offset = "0x1DD2010", VA = "0x1DD2010", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1DD207C", Offset = "0x1DD207C", VA = "0x1DD207C", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1DD20E0", Offset = "0x1DD20E0", VA = "0x1DD20E0", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1DD20E8", Offset = "0x1DD20E8", VA = "0x1DD20E8", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1DD20F0", Offset = "0x1DD20F0", VA = "0x1DD20F0", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1DD21C0", Offset = "0x1DD21C0", VA = "0x1DD21C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1DD2204", Offset = "0x1DD2204", VA = "0x1DD2204", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1DD266C", Offset = "0x1DD266C", VA = "0x1DD266C")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1DD0AC0", Offset = "0x1DD0AC0", VA = "0x1DD0AC0")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1DD26CC", Offset = "0x1DD26CC", VA = "0x1DD26CC")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1DD2760", Offset = "0x1DD2760", VA = "0x1DD2760")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1DD277C", Offset = "0x1DD277C", VA = "0x1DD277C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1DD1AA8", Offset = "0x1DD1AA8", VA = "0x1DD1AA8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1DD08F4", Offset = "0x1DD08F4", VA = "0x1DD08F4")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1DCE9DC", Offset = "0x1DCE9DC", VA = "0x1DCE9DC")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1DD2788", Offset = "0x1DD2788", VA = "0x1DD2788", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1DD278C", Offset = "0x1DD278C", VA = "0x1DD278C")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1DD2808", Offset = "0x1DD2808", VA = "0x1DD2808")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1DD285C", Offset = "0x1DD285C", VA = "0x1DD285C")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1DD28B0", Offset = "0x1DD28B0", VA = "0x1DD28B0")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1DD2904", Offset = "0x1DD2904", VA = "0x1DD2904")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1DD2A94", Offset = "0x1DD2A94", VA = "0x1DD2A94")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1DD2C68", Offset = "0x1DD2C68", VA = "0x1DD2C68")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1DD3030", Offset = "0x1DD3030", VA = "0x1DD3030")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1DD3084", Offset = "0x1DD3084", VA = "0x1DD3084")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1DD30D8", Offset = "0x1DD30D8", VA = "0x1DD30D8")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1DD312C", Offset = "0x1DD312C", VA = "0x1DD312C")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1DD328C", Offset = "0x1DD328C", VA = "0x1DD328C")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1DD33CC", Offset = "0x1DD33CC", VA = "0x1DD33CC")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1DCFBB8", Offset = "0x1DCFBB8", VA = "0x1DCFBB8")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB40A6C", Offset = "0xB40A6C")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40AA4", Offset = "0xB40AA4")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700002E")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000309")]
				[Address(RVA = "0x12839FC", Offset = "0x12839FC", VA = "0x12839FC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0x1283A44", Offset = "0x1283A44", VA = "0x1283A44", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x12837E0", Offset = "0x12837E0", VA = "0x12837E0")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x1283818", Offset = "0x1283818", VA = "0x1283818", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1283888", Offset = "0x1283888", VA = "0x1283888", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1283834", Offset = "0x1283834", VA = "0x1283834")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x1283A04", Offset = "0x1283A04", VA = "0x1283A04", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1283A4C", Offset = "0x1283A4C", VA = "0x1283A4C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1283AF4", Offset = "0x1283AF4", VA = "0x1283AF4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40AB4", Offset = "0xB40AB4")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000312")]
				[Address(RVA = "0x1283790", Offset = "0x1283790", VA = "0x1283790", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000314")]
				[Address(RVA = "0x12837D8", Offset = "0x12837D8", VA = "0x12837D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x1283580", Offset = "0x1283580", VA = "0x1283580")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x12835AC", Offset = "0x12835AC", VA = "0x12835AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x128361C", Offset = "0x128361C", VA = "0x128361C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x12835C8", Offset = "0x12835C8", VA = "0x12835C8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1283798", Offset = "0x1283798", VA = "0x1283798", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x1700002A")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x1DCF10C", Offset = "0x1DCF10C", VA = "0x1DCF10C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x1DCF1F4", Offset = "0x1DCF1F4", VA = "0x1DCF1F4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x1DCF2AC", Offset = "0x1DCF2AC", VA = "0x1DCF2AC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x1DCF30C", Offset = "0x1DCF30C", VA = "0x1DCF30C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public override int Count
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x1DCF370", Offset = "0x1DCF370", VA = "0x1DCF370", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002D")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x1DCF54C", Offset = "0x1DCF54C", VA = "0x1DCF54C", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB417BC", Offset = "0xB417BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1DCF3BC", Offset = "0x1DCF3BC", VA = "0x1DCF3BC", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1DCF420", Offset = "0x1DCF420", VA = "0x1DCF420", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1DCF4E0", Offset = "0x1DCF4E0", VA = "0x1DCF4E0", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1DCF5B8", Offset = "0x1DCF5B8", VA = "0x1DCF5B8", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB4181C", Offset = "0xB4181C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1DCF624", Offset = "0x1DCF624", VA = "0x1DCF624", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1DCF800", Offset = "0x1DCF800", VA = "0x1DCF800", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1DCFA58", Offset = "0x1DCFA58", VA = "0x1DCFA58", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1DCFB40", Offset = "0x1DCFB40", VA = "0x1DCFB40")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB40AC4", Offset = "0xB40AC4")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40AFC", Offset = "0xB40AFC")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1283AF8", Offset = "0x1283AF8", VA = "0x1283AF8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1283B00", Offset = "0x1283B00", VA = "0x1283B00")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40B0C", Offset = "0xB40B0C")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000036")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600032A")]
				[Address(RVA = "0x1284018", Offset = "0x1284018", VA = "0x1284018", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600032C")]
				[Address(RVA = "0x1284060", Offset = "0x1284060", VA = "0x1284060", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1283DE8", Offset = "0x1283DE8", VA = "0x1283DE8")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1283E20", Offset = "0x1283E20", VA = "0x1283E20", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x1283E90", Offset = "0x1283E90", VA = "0x1283E90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1283E3C", Offset = "0x1283E3C", VA = "0x1283E3C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1284020", Offset = "0x1284020", VA = "0x1284020", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1284068", Offset = "0x1284068", VA = "0x1284068", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1284110", Offset = "0x1284110", VA = "0x1284110", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40B1C", Offset = "0xB40B1C")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0x1283D98", Offset = "0x1283D98", VA = "0x1283D98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000335")]
				[Address(RVA = "0x1283DE0", Offset = "0x1283DE0", VA = "0x1283DE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1283B54", Offset = "0x1283B54", VA = "0x1283B54")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1283B80", Offset = "0x1283B80", VA = "0x1283B80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1283BF0", Offset = "0x1283BF0", VA = "0x1283BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1283B9C", Offset = "0x1283B9C", VA = "0x1283B9C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1283DA0", Offset = "0x1283DA0", VA = "0x1283DA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000032")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1DCFBC0", Offset = "0x1DCFBC0", VA = "0x1DCFBC0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1DCFCC8", Offset = "0x1DCFCC8", VA = "0x1DCFCC8", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x1DCFD98", Offset = "0x1DCFD98", VA = "0x1DCFD98", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x1DCFE44", Offset = "0x1DCFE44", VA = "0x1DCFE44", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public override int Count
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1DCFF24", Offset = "0x1DCFF24", VA = "0x1DCFF24", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000035")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1DD0448", Offset = "0x1DD0448", VA = "0x1DD0448", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB4193C", Offset = "0xB4193C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1DCFF78", Offset = "0x1DCFF78", VA = "0x1DCFF78", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1DD00C4", Offset = "0x1DD00C4", VA = "0x1DD00C4", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1DD0194", Offset = "0x1DD0194", VA = "0x1DD0194", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1DD027C", Offset = "0x1DD027C", VA = "0x1DD027C", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1DD04B4", Offset = "0x1DD04B4", VA = "0x1DD04B4", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB4199C", Offset = "0xB4199C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1DD0520", Offset = "0x1DD0520", VA = "0x1DD0520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1DD0B0C", Offset = "0x1DD0B0C", VA = "0x1DD0B0C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1DD0F64", Offset = "0x1DD0F64", VA = "0x1DD0F64", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1DD1160", Offset = "0x1DD1160", VA = "0x1DD1160")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x1700003A")]
		public override string Value
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1DD1254", Offset = "0x1DD1254", VA = "0x1DD1254", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1DD125C", Offset = "0x1DD125C", VA = "0x1DD125C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1DD1264", Offset = "0x1DD1264", VA = "0x1DD1264")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1DD1290", Offset = "0x1DD1290", VA = "0x1DD1290")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1DD12D4", Offset = "0x1DD12D4", VA = "0x1DD12D4")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1DD1318", Offset = "0x1DD1318", VA = "0x1DD1318")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1DD1354", Offset = "0x1DD1354", VA = "0x1DD1354")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1DD1390", Offset = "0x1DD1390", VA = "0x1DD1390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1DD13EC", Offset = "0x1DD13EC", VA = "0x1DD13EC", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1DD1448", Offset = "0x1DD1448", VA = "0x1DD1448", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB40B2C", Offset = "0xB40B2C")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x1700003B")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1DD176C", Offset = "0x1DD176C", VA = "0x1DD176C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1DD17CC", Offset = "0x1DD17CC", VA = "0x1DD17CC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x1DD1850", Offset = "0x1DD1850", VA = "0x1DD1850", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x1DD18BC", Offset = "0x1DD18BC", VA = "0x1DD18BC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public override int AsInt
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1DD1B38", Offset = "0x1DD1B38", VA = "0x1DD1B38", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1DD1BB8", Offset = "0x1DD1BB8", VA = "0x1DD1BB8", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override float AsFloat
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1DD1C3C", Offset = "0x1DD1C3C", VA = "0x1DD1C3C", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x1DD1CBC", Offset = "0x1DD1CBC", VA = "0x1DD1CBC", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override double AsDouble
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1DD1D40", Offset = "0x1DD1D40", VA = "0x1DD1D40", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1DD1DC0", Offset = "0x1DD1DC0", VA = "0x1DD1DC0", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public override bool AsBool
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1DD1E44", Offset = "0x1DD1E44", VA = "0x1DD1E44", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1DD1EC4", Offset = "0x1DD1EC4", VA = "0x1DD1EC4", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1DD1F48", Offset = "0x1DD1F48", VA = "0x1DD1F48", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1DD1FAC", Offset = "0x1DD1FAC", VA = "0x1DD1FAC", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1DCF1C8", Offset = "0x1DCF1C8", VA = "0x1DCF1C8")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1DCFC90", Offset = "0x1DCFC90", VA = "0x1DCFC90")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1DD170C", Offset = "0x1DD170C", VA = "0x1DD170C")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1DD1948", Offset = "0x1DD1948", VA = "0x1DD1948", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1DD19CC", Offset = "0x1DD19CC", VA = "0x1DD19CC", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1DD1A58", Offset = "0x1DD1A58", VA = "0x1DD1A58")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1DD1A70", Offset = "0x1DD1A70", VA = "0x1DD1A70")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1DD1A88", Offset = "0x1DD1A88", VA = "0x1DD1A88", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1DD1AA0", Offset = "0x1DD1AA0", VA = "0x1DD1AA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1DD1AB0", Offset = "0x1DD1AB0", VA = "0x1DD1AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1DD1AF4", Offset = "0x1DD1AF4", VA = "0x1DD1AF4", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x200007D")]
	public static class JSON
	{
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1DCE9D8", Offset = "0x1DCE9D8", VA = "0x1DCE9D8")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200007E")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40B74", Offset = "0xB40B74")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1281050", Offset = "0x1281050", VA = "0x1281050")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1281058", Offset = "0x1281058", VA = "0x1281058")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1281074", Offset = "0x1281074", VA = "0x1281074")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40B84", Offset = "0xB40B84")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x1281090", Offset = "0x1281090", VA = "0x1281090")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1281098", Offset = "0x1281098", VA = "0x1281098")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x12810B4", Offset = "0x12810B4", VA = "0x12810B4")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40B94", Offset = "0xB40B94")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x12810D0", Offset = "0x12810D0", VA = "0x12810D0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x12810D8", Offset = "0x12810D8", VA = "0x12810D8")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x1281118", Offset = "0x1281118", VA = "0x1281118")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1877240", Offset = "0x1877240", VA = "0x1877240")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1877400", Offset = "0x1877400", VA = "0x1877400")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1877598", Offset = "0x1877598", VA = "0x1877598")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1877734", Offset = "0x1877734", VA = "0x1877734")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x18777A8", Offset = "0x18777A8", VA = "0x18777A8")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x187781C", Offset = "0x187781C", VA = "0x187781C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1877880", Offset = "0x1877880", VA = "0x1877880")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1877904", Offset = "0x1877904", VA = "0x1877904")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1877968", Offset = "0x1877968", VA = "0x1877968")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x18779CC", Offset = "0x18779CC", VA = "0x18779CC")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1877A30", Offset = "0x1877A30", VA = "0x1877A30")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1877A94", Offset = "0x1877A94", VA = "0x1877A94")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1877B00", Offset = "0x1877B00", VA = "0x1877B00")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1877B68", Offset = "0x1877B68", VA = "0x1877B68")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1877BCC", Offset = "0x1877BCC", VA = "0x1877BCC")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000082")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40BB4", Offset = "0xB40BB4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x128113C", Offset = "0x128113C", VA = "0x128113C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x1281144", Offset = "0x1281144", VA = "0x1281144")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40BC4", Offset = "0xB40BC4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1281284", Offset = "0x1281284", VA = "0x1281284")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x128128C", Offset = "0x128128C", VA = "0x128128C")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40BD4", Offset = "0xB40BD4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x12812A8", Offset = "0x12812A8", VA = "0x12812A8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0x12812B0", Offset = "0x12812B0", VA = "0x12812B0")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40BE4", Offset = "0xB40BE4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x12812CC", Offset = "0x12812CC", VA = "0x12812CC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x12812D4", Offset = "0x12812D4", VA = "0x12812D4")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40BF4", Offset = "0xB40BF4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x12812F0", Offset = "0x12812F0", VA = "0x12812F0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x12812F8", Offset = "0x12812F8", VA = "0x12812F8")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C04", Offset = "0xB40C04")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x1281314", Offset = "0x1281314", VA = "0x1281314")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x128131C", Offset = "0x128131C", VA = "0x128131C")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C14", Offset = "0xB40C14")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1281338", Offset = "0x1281338", VA = "0x1281338")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x1281340", Offset = "0x1281340", VA = "0x1281340")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x128135C", Offset = "0x128135C", VA = "0x128135C")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1281390", Offset = "0x1281390", VA = "0x1281390")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x12813AC", Offset = "0x12813AC", VA = "0x12813AC")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x12813C8", Offset = "0x12813C8", VA = "0x12813C8")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C24", Offset = "0xB40C24")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x1281488", Offset = "0x1281488", VA = "0x1281488")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1281490", Offset = "0x1281490", VA = "0x1281490")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C34", Offset = "0xB40C34")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x12814AC", Offset = "0x12814AC", VA = "0x12814AC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x12814B4", Offset = "0x12814B4", VA = "0x12814B4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x12814D0", Offset = "0x12814D0", VA = "0x12814D0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C44", Offset = "0xB40C44")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x12815D0", Offset = "0x12815D0", VA = "0x12815D0")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x12815D8", Offset = "0x12815D8", VA = "0x12815D8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C54", Offset = "0xB40C54")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1281160", Offset = "0x1281160", VA = "0x1281160")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1281168", Offset = "0x1281168", VA = "0x1281168")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1281184", Offset = "0x1281184", VA = "0x1281184")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1874A3C", Offset = "0x1874A3C", VA = "0x1874A3C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1877C30", Offset = "0x1877C30", VA = "0x1877C30")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1877DF0", Offset = "0x1877DF0", VA = "0x1877DF0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1877FB0", Offset = "0x1877FB0", VA = "0x1877FB0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1874C08", Offset = "0x1874C08", VA = "0x1874C08")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1878170", Offset = "0x1878170", VA = "0x1878170")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x18783B4", Offset = "0x18783B4", VA = "0x18783B4")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x18788AC", Offset = "0x18788AC", VA = "0x18788AC")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1878B18", Offset = "0x1878B18", VA = "0x1878B18")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1878D98", Offset = "0x1878D98", VA = "0x1878D98")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1878F78", Offset = "0x1878F78", VA = "0x1878F78")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C74", Offset = "0xB40C74")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x12815F4", Offset = "0x12815F4", VA = "0x12815F4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0x12815FC", Offset = "0x12815FC", VA = "0x12815FC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600039F")]
			[Address(RVA = "0x1281618", Offset = "0x1281618", VA = "0x1281618")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C84", Offset = "0xB40C84")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x1281634", Offset = "0x1281634", VA = "0x1281634")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x128163C", Offset = "0x128163C", VA = "0x128163C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x1281658", Offset = "0x1281658", VA = "0x1281658")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40C94", Offset = "0xB40C94")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x1281674", Offset = "0x1281674", VA = "0x1281674")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x128167C", Offset = "0x128167C", VA = "0x128167C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1281688", Offset = "0x1281688", VA = "0x1281688")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1874F88", Offset = "0x1874F88", VA = "0x1874F88")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x18754C8", Offset = "0x18754C8", VA = "0x18754C8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1879164", Offset = "0x1879164", VA = "0x1879164")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x187932C", Offset = "0x187932C", VA = "0x187932C")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000092")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000093")]
		public static class Utils
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1282670", Offset = "0x1282670", VA = "0x1282670")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40CB4", Offset = "0xB40CB4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1281734", Offset = "0x1281734", VA = "0x1281734")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x128173C", Offset = "0x128173C", VA = "0x128173C")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1281758", Offset = "0x1281758", VA = "0x1281758")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40CC4", Offset = "0xB40CC4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x12819FC", Offset = "0x12819FC", VA = "0x12819FC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1281A04", Offset = "0x1281A04", VA = "0x1281A04")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1281A28", Offset = "0x1281A28", VA = "0x1281A28")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40CD4", Offset = "0xB40CD4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1281E10", Offset = "0x1281E10", VA = "0x1281E10")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1281E18", Offset = "0x1281E18", VA = "0x1281E18")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1281E3C", Offset = "0x1281E3C", VA = "0x1281E3C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40CE4", Offset = "0xB40CE4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x1282338", Offset = "0x1282338", VA = "0x1282338")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1282340", Offset = "0x1282340", VA = "0x1282340")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1282364", Offset = "0x1282364", VA = "0x1282364")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40CF4", Offset = "0xB40CF4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1282388", Offset = "0x1282388", VA = "0x1282388")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1282390", Offset = "0x1282390", VA = "0x1282390")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x12823B4", Offset = "0x12823B4", VA = "0x12823B4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D04", Offset = "0xB40D04")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x12823D8", Offset = "0x12823D8", VA = "0x12823D8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x12823E0", Offset = "0x12823E0", VA = "0x12823E0")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x12823FC", Offset = "0x12823FC", VA = "0x12823FC")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D14", Offset = "0xB40D14")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1282418", Offset = "0x1282418", VA = "0x1282418")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1282420", Offset = "0x1282420", VA = "0x1282420")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1282484", Offset = "0x1282484", VA = "0x1282484")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D24", Offset = "0xB40D24")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x12824E0", Offset = "0x12824E0", VA = "0x12824E0")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x12824E8", Offset = "0x12824E8", VA = "0x12824E8")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x128254C", Offset = "0x128254C", VA = "0x128254C")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D34", Offset = "0xB40D34")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x12825A8", Offset = "0x12825A8", VA = "0x12825A8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x12825B0", Offset = "0x12825B0", VA = "0x12825B0")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1282614", Offset = "0x1282614", VA = "0x1282614")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D44", Offset = "0xB40D44")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1281774", Offset = "0x1281774", VA = "0x1281774")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x128177C", Offset = "0x128177C", VA = "0x128177C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x128179C", Offset = "0x128179C", VA = "0x128179C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D54", Offset = "0xB40D54")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x12817B8", Offset = "0x12817B8", VA = "0x12817B8")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x12817C0", Offset = "0x12817C0", VA = "0x12817C0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x12817E0", Offset = "0x12817E0", VA = "0x12817E0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D64", Offset = "0xB40D64")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x12817FC", Offset = "0x12817FC", VA = "0x12817FC")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1281804", Offset = "0x1281804", VA = "0x1281804")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x1281820", Offset = "0x1281820", VA = "0x1281820")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D74", Offset = "0xB40D74")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x128183C", Offset = "0x128183C", VA = "0x128183C")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1281844", Offset = "0x1281844", VA = "0x1281844")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1281860", Offset = "0x1281860", VA = "0x1281860")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D84", Offset = "0xB40D84")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x128187C", Offset = "0x128187C", VA = "0x128187C")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1281884", Offset = "0x1281884", VA = "0x1281884")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x12818A0", Offset = "0x12818A0", VA = "0x12818A0")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40D94", Offset = "0xB40D94")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x12818BC", Offset = "0x12818BC", VA = "0x12818BC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x12818C4", Offset = "0x12818C4", VA = "0x12818C4")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x12818E0", Offset = "0x12818E0", VA = "0x12818E0")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40DA4", Offset = "0xB40DA4")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x12818FC", Offset = "0x12818FC", VA = "0x12818FC")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x1281904", Offset = "0x1281904", VA = "0x1281904")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x1281920", Offset = "0x1281920", VA = "0x1281920")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40DB4", Offset = "0xB40DB4")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x128193C", Offset = "0x128193C", VA = "0x128193C")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x1281944", Offset = "0x1281944", VA = "0x1281944")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x1281960", Offset = "0x1281960", VA = "0x1281960")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40DC4", Offset = "0xB40DC4")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x128197C", Offset = "0x128197C", VA = "0x128197C")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1281984", Offset = "0x1281984", VA = "0x1281984")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x12819A0", Offset = "0x12819A0", VA = "0x12819A0")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40DD4", Offset = "0xB40DD4")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x12819BC", Offset = "0x12819BC", VA = "0x12819BC")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x12819C4", Offset = "0x12819C4", VA = "0x12819C4")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x12819E0", Offset = "0x12819E0", VA = "0x12819E0")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40DE4", Offset = "0xB40DE4")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1281A4C", Offset = "0x1281A4C", VA = "0x1281A4C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x1281A54", Offset = "0x1281A54", VA = "0x1281A54")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x1281A70", Offset = "0x1281A70", VA = "0x1281A70")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40DF4", Offset = "0xB40DF4")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x1281A8C", Offset = "0x1281A8C", VA = "0x1281A8C")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1281A94", Offset = "0x1281A94", VA = "0x1281A94")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1281AB0", Offset = "0x1281AB0", VA = "0x1281AB0")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E04", Offset = "0xB40E04")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1281ACC", Offset = "0x1281ACC", VA = "0x1281ACC")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x1281AD4", Offset = "0x1281AD4", VA = "0x1281AD4")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1281AF0", Offset = "0x1281AF0", VA = "0x1281AF0")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E14", Offset = "0xB40E14")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1281B0C", Offset = "0x1281B0C", VA = "0x1281B0C")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1281B14", Offset = "0x1281B14", VA = "0x1281B14")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1281B30", Offset = "0x1281B30", VA = "0x1281B30")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E24", Offset = "0xB40E24")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1281B4C", Offset = "0x1281B4C", VA = "0x1281B4C")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1281B54", Offset = "0x1281B54", VA = "0x1281B54")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1281B70", Offset = "0x1281B70", VA = "0x1281B70")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E34", Offset = "0xB40E34")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1281B8C", Offset = "0x1281B8C", VA = "0x1281B8C")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1281B94", Offset = "0x1281B94", VA = "0x1281B94")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1281BB0", Offset = "0x1281BB0", VA = "0x1281BB0")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E44", Offset = "0xB40E44")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1281BCC", Offset = "0x1281BCC", VA = "0x1281BCC")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1281BD4", Offset = "0x1281BD4", VA = "0x1281BD4")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1281BFC", Offset = "0x1281BFC", VA = "0x1281BFC")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E54", Offset = "0xB40E54")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x1281C18", Offset = "0x1281C18", VA = "0x1281C18")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1281C20", Offset = "0x1281C20", VA = "0x1281C20")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1281C48", Offset = "0x1281C48", VA = "0x1281C48")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E64", Offset = "0xB40E64")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1281C64", Offset = "0x1281C64", VA = "0x1281C64")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1281C6C", Offset = "0x1281C6C", VA = "0x1281C6C")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1281C94", Offset = "0x1281C94", VA = "0x1281C94")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E74", Offset = "0xB40E74")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x1281CB0", Offset = "0x1281CB0", VA = "0x1281CB0")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1281CB8", Offset = "0x1281CB8", VA = "0x1281CB8")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1281CD4", Offset = "0x1281CD4", VA = "0x1281CD4")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1281CF0", Offset = "0x1281CF0", VA = "0x1281CF0")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1281D24", Offset = "0x1281D24", VA = "0x1281D24")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1281D40", Offset = "0x1281D40", VA = "0x1281D40")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x1281D5C", Offset = "0x1281D5C", VA = "0x1281D5C")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E84", Offset = "0xB40E84")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x1281E60", Offset = "0x1281E60", VA = "0x1281E60")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x1281E68", Offset = "0x1281E68", VA = "0x1281E68")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1281EBC", Offset = "0x1281EBC", VA = "0x1281EBC")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40E94", Offset = "0xB40E94")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x1281F08", Offset = "0x1281F08", VA = "0x1281F08")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x1281F10", Offset = "0x1281F10", VA = "0x1281F10")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0x1281F2C", Offset = "0x1281F2C", VA = "0x1281F2C")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40EA4", Offset = "0xB40EA4")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1281F48", Offset = "0x1281F48", VA = "0x1281F48")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x1281F50", Offset = "0x1281F50", VA = "0x1281F50")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x1281F6C", Offset = "0x1281F6C", VA = "0x1281F6C")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40EB4", Offset = "0xB40EB4")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1281F88", Offset = "0x1281F88", VA = "0x1281F88")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x1281F90", Offset = "0x1281F90", VA = "0x1281F90")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x1281FB4", Offset = "0x1281FB4", VA = "0x1281FB4")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40EC4", Offset = "0xB40EC4")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1281FD8", Offset = "0x1281FD8", VA = "0x1281FD8")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1281FE0", Offset = "0x1281FE0", VA = "0x1281FE0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1282004", Offset = "0x1282004", VA = "0x1282004")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40ED4", Offset = "0xB40ED4")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1282028", Offset = "0x1282028", VA = "0x1282028")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1282030", Offset = "0x1282030", VA = "0x1282030")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1282054", Offset = "0x1282054", VA = "0x1282054")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40EE4", Offset = "0xB40EE4")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1282078", Offset = "0x1282078", VA = "0x1282078")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1282080", Offset = "0x1282080", VA = "0x1282080")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x12820A4", Offset = "0x12820A4", VA = "0x12820A4")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40EF4", Offset = "0xB40EF4")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x12820C8", Offset = "0x12820C8", VA = "0x12820C8")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x12820D0", Offset = "0x12820D0", VA = "0x12820D0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x12820DC", Offset = "0x12820DC", VA = "0x12820DC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40F04", Offset = "0xB40F04")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1282198", Offset = "0x1282198", VA = "0x1282198")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x12821A0", Offset = "0x12821A0", VA = "0x12821A0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x12821AC", Offset = "0x12821AC", VA = "0x12821AC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40F14", Offset = "0xB40F14")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1282268", Offset = "0x1282268", VA = "0x1282268")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1282270", Offset = "0x1282270", VA = "0x1282270")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x128227C", Offset = "0x128227C", VA = "0x128227C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1875990", Offset = "0x1875990", VA = "0x1875990")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1875148", Offset = "0x1875148", VA = "0x1875148")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1875660", Offset = "0x1875660", VA = "0x1875660")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1879578", Offset = "0x1879578", VA = "0x1879578")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1879738", Offset = "0x1879738", VA = "0x1879738")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x18798D0", Offset = "0x18798D0", VA = "0x18798D0")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1879A8C", Offset = "0x1879A8C", VA = "0x1879A8C")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1879C5C", Offset = "0x1879C5C", VA = "0x1879C5C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1879E14", Offset = "0x1879E14", VA = "0x1879E14")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1879FCC", Offset = "0x1879FCC", VA = "0x1879FCC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x187A184", Offset = "0x187A184", VA = "0x187A184")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x187A344", Offset = "0x187A344", VA = "0x187A344")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x187A4DC", Offset = "0x187A4DC", VA = "0x187A4DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x187A684", Offset = "0x187A684", VA = "0x187A684")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x187A83C", Offset = "0x187A83C", VA = "0x187A83C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x187A9EC", Offset = "0x187A9EC", VA = "0x187A9EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x187487C", Offset = "0x187487C", VA = "0x187487C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x187AB9C", Offset = "0x187AB9C", VA = "0x187AB9C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x187AD50", Offset = "0x187AD50", VA = "0x187AD50")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x187AF04", Offset = "0x187AF04", VA = "0x187AF04")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x187B0B8", Offset = "0x187B0B8", VA = "0x187B0B8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x187B270", Offset = "0x187B270", VA = "0x187B270")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x187B428", Offset = "0x187B428", VA = "0x187B428")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x187B5D0", Offset = "0x187B5D0", VA = "0x187B5D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x187B77C", Offset = "0x187B77C", VA = "0x187B77C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1874DD0", Offset = "0x1874DD0", VA = "0x1874DD0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1875CF0", Offset = "0x1875CF0", VA = "0x1875CF0")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x187B928", Offset = "0x187B928", VA = "0x187B928")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1875EB8", Offset = "0x1875EB8", VA = "0x1875EB8")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x187BB10", Offset = "0x187BB10", VA = "0x187BB10")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x187BF3C", Offset = "0x187BF3C", VA = "0x187BF3C")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x187C0E8", Offset = "0x187C0E8", VA = "0x187C0E8")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x187C284", Offset = "0x187C284", VA = "0x187C284")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x187C420", Offset = "0x187C420", VA = "0x187C420")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1875308", Offset = "0x1875308", VA = "0x1875308")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x18757F8", Offset = "0x18757F8", VA = "0x18757F8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1875B28", Offset = "0x1875B28", VA = "0x1875B28")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x187C5C8", Offset = "0x187C5C8", VA = "0x187C5C8")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x187C81C", Offset = "0x187C81C", VA = "0x187C81C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x187CA70", Offset = "0x187CA70", VA = "0x187CA70")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BB")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40F34", Offset = "0xB40F34")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x12828B4", Offset = "0x12828B4", VA = "0x12828B4")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x12828BC", Offset = "0x12828BC", VA = "0x12828BC")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x12828E0", Offset = "0x12828E0", VA = "0x12828E0")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40F44", Offset = "0xB40F44")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1282904", Offset = "0x1282904", VA = "0x1282904")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x128290C", Offset = "0x128290C", VA = "0x128290C")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1282930", Offset = "0x1282930", VA = "0x1282930")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x187CCC4", Offset = "0x187CCC4", VA = "0x187CCC4")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x187CE90", Offset = "0x187CE90", VA = "0x187CE90")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x187D070", Offset = "0x187D070", VA = "0x187D070")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x187D11C", Offset = "0x187D11C", VA = "0x187D11C")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x187D1C8", Offset = "0x187D1C8", VA = "0x187D1C8")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x187D274", Offset = "0x187D274", VA = "0x187D274")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x187D330", Offset = "0x187D330", VA = "0x187D330")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x187D3EC", Offset = "0x187D3EC", VA = "0x187D3EC")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x187D498", Offset = "0x187D498", VA = "0x187D498")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x187D69C", Offset = "0x187D69C", VA = "0x187D69C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BE")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x20000BF")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000043")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x1280D90", Offset = "0x1280D90", VA = "0x1280D90", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1280DC4", Offset = "0x1280DC4", VA = "0x1280DC4")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000C0")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000044")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x1280F60", Offset = "0x1280F60", VA = "0x1280F60", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x1280FC4", Offset = "0x1280FC4", VA = "0x1280FC4")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000C1")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000045")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x1280E78", Offset = "0x1280E78", VA = "0x1280E78", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1280E94", Offset = "0x1280E94", VA = "0x1280E94")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000C2")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000046")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x1280DF0", Offset = "0x1280DF0", VA = "0x1280DF0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x1280E3C", Offset = "0x1280E3C", VA = "0x1280E3C")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x20000C3")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000047")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x1280EC0", Offset = "0x1280EC0", VA = "0x1280EC0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1280F24", Offset = "0x1280F24", VA = "0x1280F24")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x20000C4")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000048")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x1280FF0", Offset = "0x1280FF0", VA = "0x1280FF0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1281024", Offset = "0x1281024", VA = "0x1281024")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x20000C5")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20000C6")]
		public static class Physics
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x1282954", Offset = "0x1282954", VA = "0x1282954")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1282A58", Offset = "0x1282A58", VA = "0x1282A58")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x1282A60", Offset = "0x1282A60", VA = "0x1282A60")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1282AF8", Offset = "0x1282AF8", VA = "0x1282AF8")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x187D8A0", Offset = "0x187D8A0", VA = "0x187D8A0")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x187D964", Offset = "0x187D964", VA = "0x187D964")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB40F54", Offset = "0xB40F54")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DOTweenAnimationType animationType;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000004")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1872D74", Offset = "0x1872D74", VA = "0x1872D74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB41FFC", Offset = "0xB41FFC")]
			add
			{
			}
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x1872E30", Offset = "0x1872E30", VA = "0x1872E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4200C", Offset = "0xB4200C")]
			remove
			{
			}
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1872EEC", Offset = "0x1872EEC", VA = "0x1872EEC")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1872F68", Offset = "0x1872F68", VA = "0x1872F68")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x18745D4", Offset = "0x18745D4", VA = "0x18745D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1874618", Offset = "0x1874618", VA = "0x1874618")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x187461C", Offset = "0x187461C", VA = "0x187461C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1872FB8", Offset = "0x1872FB8", VA = "0x1872FB8")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x18760A8", Offset = "0x18760A8", VA = "0x18760A8", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1876120", Offset = "0x1876120", VA = "0x1876120", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1876198", Offset = "0x1876198", VA = "0x1876198", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1876210", Offset = "0x1876210", VA = "0x1876210", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1876288", Offset = "0x1876288", VA = "0x1876288", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1876300", Offset = "0x1876300", VA = "0x1876300", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x18763F8", Offset = "0x18763F8", VA = "0x18763F8", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1876408", Offset = "0x1876408", VA = "0x1876408", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1876770", Offset = "0x1876770", VA = "0x1876770", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x18767EC", Offset = "0x18767EC", VA = "0x18767EC", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1876870", Offset = "0x1876870", VA = "0x1876870")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x18768F8", Offset = "0x18768F8", VA = "0x18768F8")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x187695C", Offset = "0x187695C", VA = "0x187695C")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x18769C0", Offset = "0x18769C0", VA = "0x18769C0")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1876A48", Offset = "0x1876A48", VA = "0x1876A48")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1876AAC", Offset = "0x1876AAC", VA = "0x1876AAC")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1876B34", Offset = "0x1876B34", VA = "0x1876B34")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1876B98", Offset = "0x1876B98", VA = "0x1876B98")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1876CE0", Offset = "0x1876CE0", VA = "0x1876CE0")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1876D6C", Offset = "0x1876D6C", VA = "0x1876D6C")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1876DE8", Offset = "0x1876DE8", VA = "0x1876DE8")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1876E80", Offset = "0x1876E80", VA = "0x1876E80")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1876F00", Offset = "0x1876F00", VA = "0x1876F00")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1874678", Offset = "0x1874678", VA = "0x1874678")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x187700C", Offset = "0x187700C", VA = "0x187700C")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1874660", Offset = "0x1874660", VA = "0x1874660")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1876508", Offset = "0x1876508", VA = "0x1876508")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1877048", Offset = "0x1877048", VA = "0x1877048")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1877238", Offset = "0x1877238", VA = "0x1877238")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4201C", Offset = "0xB4201C")]
		private void <CreateTween>b__45_0()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x600048F")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C9")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40FAC", Offset = "0xB40FAC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1282C4C", Offset = "0x1282C4C", VA = "0x1282C4C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1282C54", Offset = "0x1282C54", VA = "0x1282C54")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1282C70", Offset = "0x1282C70", VA = "0x1282C70")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40FBC", Offset = "0xB40FBC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1282C8C", Offset = "0x1282C8C", VA = "0x1282C8C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1282C94", Offset = "0x1282C94", VA = "0x1282C94")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x187DA18", Offset = "0x187DA18", VA = "0x187DA18")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x187DA64", Offset = "0x187DA64", VA = "0x187DA64")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x187DD7C", Offset = "0x187DD7C", VA = "0x187DD7C")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CC")]
	public static class ShortcutExtensionsTMPText
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40FDC", Offset = "0xB40FDC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x127C1EC", Offset = "0x127C1EC", VA = "0x127C1EC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1286594", Offset = "0x1286594", VA = "0x1286594")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x12865B8", Offset = "0x12865B8", VA = "0x12865B8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40FEC", Offset = "0xB40FEC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x127C3C4", Offset = "0x127C3C4", VA = "0x127C3C4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x12865DC", Offset = "0x12865DC", VA = "0x12865DC")]
			internal Color <DOFaceColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1286608", Offset = "0x1286608", VA = "0x1286608")]
			internal void <DOFaceColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB40FFC", Offset = "0xB40FFC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x127C59C", Offset = "0x127C59C", VA = "0x127C59C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1286640", Offset = "0x1286640", VA = "0x1286640")]
			internal Color <DOOutlineColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x128666C", Offset = "0x128666C", VA = "0x128666C")]
			internal void <DOOutlineColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4100C", Offset = "0xB4100C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x127C830", Offset = "0x127C830", VA = "0x127C830")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x12866A4", Offset = "0x12866A4", VA = "0x12866A4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x12866C8", Offset = "0x12866C8", VA = "0x12866C8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4101C", Offset = "0xB4101C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x127C9D0", Offset = "0x127C9D0", VA = "0x127C9D0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x12866EC", Offset = "0x12866EC", VA = "0x12866EC")]
			internal Color <DOFaceFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1286718", Offset = "0x1286718", VA = "0x1286718")]
			internal void <DOFaceFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4102C", Offset = "0xB4102C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x127CB88", Offset = "0x127CB88", VA = "0x127CB88")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1286750", Offset = "0x1286750", VA = "0x1286750")]
			internal Vector3 <DOScale>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x128676C", Offset = "0x128676C", VA = "0x128676C")]
			internal void <DOScale>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4103C", Offset = "0xB4103C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x127CD28", Offset = "0x127CD28", VA = "0x127CD28")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1286788", Offset = "0x1286788", VA = "0x1286788")]
			internal float <DOFontSize>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x12867A4", Offset = "0x12867A4", VA = "0x12867A4")]
			internal void <DOFontSize>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4104C", Offset = "0xB4104C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x127CEC8", Offset = "0x127CEC8", VA = "0x127CEC8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x12867C0", Offset = "0x12867C0", VA = "0x12867C0")]
			internal int <DOMaxVisibleCharacters>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x12867DC", Offset = "0x12867DC", VA = "0x12867DC")]
			internal void <DOMaxVisibleCharacters>b__1(int x)
			{
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB4105C", Offset = "0xB4105C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x127D098", Offset = "0x127D098", VA = "0x127D098")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x12867F8", Offset = "0x12867F8", VA = "0x12867F8")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x128681C", Offset = "0x128681C", VA = "0x128681C")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x127C02C", Offset = "0x127C02C", VA = "0x127C02C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this TMP_Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x127C1F4", Offset = "0x127C1F4", VA = "0x127C1F4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x127C3CC", Offset = "0x127C3CC", VA = "0x127C3CC")]
		public static TweenerCore<Color, Color, ColorOptions> DOOutlineColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x127C5A4", Offset = "0x127C5A4", VA = "0x127C5A4")]
		public static TweenerCore<Color, Color, ColorOptions> DOGlowColor(this TMP_Text target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x127C698", Offset = "0x127C698", VA = "0x127C698")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x127C838", Offset = "0x127C838", VA = "0x127C838")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x127C9D8", Offset = "0x127C9D8", VA = "0x127C9D8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x127CB90", Offset = "0x127CB90", VA = "0x127CB90")]
		public static TweenerCore<float, float, FloatOptions> DOFontSize(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x127CD30", Offset = "0x127CD30", VA = "0x127CD30")]
		public static TweenerCore<int, int, NoOptions> DOMaxVisibleCharacters(this TMP_Text target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x127CED0", Offset = "0x127CED0", VA = "0x127CED0")]
		public static TweenerCore<string, string, StringOptions> DOText(this TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
}
