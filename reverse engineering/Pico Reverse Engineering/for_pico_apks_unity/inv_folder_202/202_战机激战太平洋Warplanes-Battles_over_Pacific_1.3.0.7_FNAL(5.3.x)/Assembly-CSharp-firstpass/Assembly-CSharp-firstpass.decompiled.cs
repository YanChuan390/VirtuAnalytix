using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using JSONplugin;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA324C0", Offset = "0xA324C0")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1BF36E4", Offset = "0x1BF36E4", VA = "0x1BF36E4")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA324F8", Offset = "0xA324F8")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1BF5D98", Offset = "0x1BF5D98", VA = "0x1BF5D98")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
[Flags]
public enum ManagerMask
{
	[Token(Token = "0x4000002")]
	None = 0,
	[Token(Token = "0x4000003")]
	All = 1,
	[Token(Token = "0x4000004")]
	BadWord = 2,
	[Token(Token = "0x4000005")]
	Domain = 4,
	[Token(Token = "0x4000006")]
	Capitalization = 8,
	[Token(Token = "0x4000007")]
	Punctuation = 0x10
}
[Token(Token = "0x2000005")]
public class CloudSave_Controller : MonoBehaviour, CloudSave_CoroutineCallback
{
	[Token(Token = "0x4000008")]
	public const string prefsKeyEmail = "CloudSave_email";

	[Token(Token = "0x4000009")]
	public const string prefsKeyPassword = "CloudSave_password";

	[Token(Token = "0x400000A")]
	public const string prefsKeyIsAutoAccount = "CloudSave_autoAccount";

	[Token(Token = "0x400000B")]
	public const string prefsKeyNoAutologinNextTime = "CloudSave_noAutoLoginNextTime";

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static CloudSave_Controller instance;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CloudSave_Screen_SelectMode selectModeScreen;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CloudSave_Screen_CloudInfo cloudInfoScreen;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CloudSave_Screen_CloudInfo cloudInfoScreenLogin;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CloudSave_Screen_Login loginScreen;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CloudSave_Screen_Login autoLoginScreen;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CloudSave_Screen_Menu menuScreen;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CloudSave_Screen_ChangePassword changePasswordScreen;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public CloudSave_Screen_ResetPassword resetPasswordScreen;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public CloudSave_Screen_Message messageScreen;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CloudSave_Screen_Settings settingsScreen;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public CloudSave_Screen_DeleteAccount deleteAccountScreen;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public CloudSave_Screen_RedeemCode redeemCodeScreen;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CloudSave_Screen_TermsOfUse termsOfUseScreen;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static bool firstRun;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected CloudSave_ServerCoroutine_Login backgroundLoginCoroutine;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected float backgroundLoginStartTime;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected CloudSave_ServerCoroutine_StoreGameSave backgroundStoreCoroutine;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected float backgroundStoreStartTime;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected string lastStoredLocalSave;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected bool destroyingUnwantedThis;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	protected bool startFirtScreen;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	protected bool manualFirstLoginScreen;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
	protected bool showConflictMessageAfterLoadLevel;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected CloudSave_Screen currentScreen;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected GameObject statusLineObject;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected DateTime lastStoreTime;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected bool lastStoreTimeValid;

	[Token(Token = "0x17000001")]
	public static CloudSave_Controller Instance
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1E22E80", Offset = "0x1E22E80", VA = "0x1E22E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1E22F64", Offset = "0x1E22F64", VA = "0x1E22F64")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1E2307C", Offset = "0x1E2307C", VA = "0x1E2307C")]
	public static void ResetLastSendTime()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1E23150", Offset = "0x1E23150", VA = "0x1E23150")]
	public void SetLastStoreTime()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1E231C0", Offset = "0x1E231C0", VA = "0x1E231C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1E23BA0", Offset = "0x1E23BA0", VA = "0x1E23BA0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1E23D08", Offset = "0x1E23D08", VA = "0x1E23D08")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1E2414C", Offset = "0x1E2414C", VA = "0x1E2414C")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1E24150", Offset = "0x1E24150", VA = "0x1E24150")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1E234E4", Offset = "0x1E234E4", VA = "0x1E234E4")]
	private void StartFirstScreen()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1E248A0", Offset = "0x1E248A0", VA = "0x1E248A0", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1E248A4", Offset = "0x1E248A4", VA = "0x1E248A4", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1E23F90", Offset = "0x1E23F90", VA = "0x1E23F90", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1E24340", Offset = "0x1E24340", VA = "0x1E24340", Slot = "7")]
	public void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1E24AEC", Offset = "0x1E24AEC", VA = "0x1E24AEC")]
	public void OnReceivedCloudSave(CloudSave_Screen onScreen, CloudSave_Saves cloudSaves, bool compareAndImport)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1E24E0C", Offset = "0x1E24E0C", VA = "0x1E24E0C")]
	public void OnSendSaveToCloud(CloudSave_Screen onScreen, CloudSave_Saves localSaves)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1E24480", Offset = "0x1E24480", VA = "0x1E24480")]
	public void TrySendChangedLocalSave()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1E25834", Offset = "0x1E25834", VA = "0x1E25834")]
	public void TrySendDeletedSave()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1E23F18", Offset = "0x1E23F18", VA = "0x1E23F18")]
	protected void ShowConflictMessage()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1E2598C", Offset = "0x1E2598C", VA = "0x1E2598C")]
	protected void ClearConflictMessage()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1E25A04", Offset = "0x1E25A04", VA = "0x1E25A04")]
	public bool IsLoggingIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1E24798", Offset = "0x1E24798", VA = "0x1E24798")]
	protected void ShowScreen(CloudSave_Screen screen)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1E25A70", Offset = "0x1E25A70", VA = "0x1E25A70")]
	public void On_SelectMode_Email()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1E25A78", Offset = "0x1E25A78", VA = "0x1E25A78")]
	public void On_SelectMode_Auto()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1E25B80", Offset = "0x1E25B80", VA = "0x1E25B80")]
	public void On_SelectMode_Back()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1E25BFC", Offset = "0x1E25BFC", VA = "0x1E25BFC")]
	public void On_CloudInfo_Yes()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1E25C04", Offset = "0x1E25C04", VA = "0x1E25C04")]
	public void On_CloudInfo_No()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1E25C08", Offset = "0x1E25C08", VA = "0x1E25C08")]
	public void On_CloudInfo_Back()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1E25C84", Offset = "0x1E25C84", VA = "0x1E25C84")]
	public void On_CloudInfo_CloseToLogin()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1E24880", Offset = "0x1E24880", VA = "0x1E24880")]
	protected void ShowLoginScreen(bool autoLogin, bool manualFirstLogin)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1E25C8C", Offset = "0x1E25C8C", VA = "0x1E25C8C")]
	public void On_LoginScreen_Back()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1E25D08", Offset = "0x1E25D08", VA = "0x1E25D08")]
	public void On_LoginScreen_ShowInfo()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1E25D10", Offset = "0x1E25D10", VA = "0x1E25D10")]
	public void On_LoginScreen_FailedAutoLogin()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1E25E8C", Offset = "0x1E25E8C", VA = "0x1E25E8C")]
	public void OnSelectScreen_ShowLogin(bool showRegister)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1E25EDC", Offset = "0x1E25EDC", VA = "0x1E25EDC")]
	public void On_LoginScreen_LoggedIn()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1E25FF4", Offset = "0x1E25FF4", VA = "0x1E25FF4")]
	public void On_LoginScreen_ResetPassword()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1E26028", Offset = "0x1E26028", VA = "0x1E26028")]
	public void On_MenuScreen_Back()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1E2609C", Offset = "0x1E2609C", VA = "0x1E2609C")]
	public void On_MenuScreen_Settings()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1E260A4", Offset = "0x1E260A4", VA = "0x1E260A4")]
	public void On_MenuScreen_SetPassword()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1E260AC", Offset = "0x1E260AC", VA = "0x1E260AC")]
	public void On_MenuScreen_Logout()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1E26248", Offset = "0x1E26248", VA = "0x1E26248")]
	public void On_ChangePasswordScreen_Back()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1E26250", Offset = "0x1E26250", VA = "0x1E26250")]
	public void On_ResetPasswordScreen_Back(bool backToSettings)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1E26264", Offset = "0x1E26264", VA = "0x1E26264")]
	public void ShowMessageScreen(string text, bool warning, CloudSave_Screen backToScreen, Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1E26338", Offset = "0x1E26338", VA = "0x1E26338")]
	public void On_MessageScreen_Closed(CloudSave_Screen backToScreen, Action<bool> resultCallback, bool result)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1E263C8", Offset = "0x1E263C8", VA = "0x1E263C8")]
	public void On_SettingsScreen_Back()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1E263D0", Offset = "0x1E263D0", VA = "0x1E263D0")]
	public void On_SettingsScreen_ChangePassword()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1E263D8", Offset = "0x1E263D8", VA = "0x1E263D8")]
	public void On_SettingsScreen_ResetPassword()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1E26410", Offset = "0x1E26410", VA = "0x1E26410")]
	public void On_SettingsScreen_DeleteAccount()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1E26418", Offset = "0x1E26418", VA = "0x1E26418")]
	public void On_DeleteAccountScreen_Back()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1E26420", Offset = "0x1E26420", VA = "0x1E26420")]
	public void On_DeleteAccountScreen_Deleted()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1E2664C", Offset = "0x1E2664C", VA = "0x1E2664C")]
	public void On_SettingsScreen_RedeemCode()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1E26654", Offset = "0x1E26654", VA = "0x1E26654")]
	public void On_RedeemCodeScreen_Back()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1E25B18", Offset = "0x1E25B18", VA = "0x1E25B18")]
	public void ShowTermsOfUseScreen(bool autoAccount, string email, string password, bool newsletter)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1E2665C", Offset = "0x1E2665C", VA = "0x1E2665C")]
	public void On_TermsOfUseScreen_No(bool autoAccount)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1E26670", Offset = "0x1E26670", VA = "0x1E26670")]
	public void On_TermsOfUseScreen_Completed(bool autoAccount)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1E266BC", Offset = "0x1E266BC", VA = "0x1E266BC")]
	public CloudSave_Controller()
	{
	}
}
[Token(Token = "0x2000006")]
public static class CloudSave_Config
{
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string gameHashCode;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string URLtoServer;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool useEncryption;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string md5salt;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static int minPasswordLength;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int backgroundLoginTimeout;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static int backgroundStoreTimeout;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string cloudSaveSceneName;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string autoAccountDomain;
}
[Token(Token = "0x2000007")]
public static class CloudSave_Debug
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool debugLog;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool testDeleteCloudPlayerPrefs;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int testMinDelayBetweenSaves;
}
[Token(Token = "0x2000008")]
public interface CloudSave_CoroutineCallback
{
	[Token(Token = "0x600003E")]
	void OnStartCoroutine(CloudSave_ServerCoroutine coroutine);

	[Token(Token = "0x600003F")]
	void OnEndCoroutine(CloudSave_ServerCoroutine coroutine);

	[Token(Token = "0x6000040")]
	void InfoMessage(string strMsg, bool warning);

	[Token(Token = "0x6000041")]
	void InfoMessage(string strMsg1, string strMsg2, bool warning);
}
[Token(Token = "0x2000009")]
public class CloudSave_CoroutineCallback_InfoOnly : CloudSave_CoroutineCallback
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected CloudSave_CoroutineCallback baseCallback;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1E26760", Offset = "0x1E26760", VA = "0x1E26760")]
	public CloudSave_CoroutineCallback_InfoOnly(CloudSave_CoroutineCallback _baseCallback)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1E2678C", Offset = "0x1E2678C", VA = "0x1E2678C", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1E26790", Offset = "0x1E26790", VA = "0x1E26790", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1E26794", Offset = "0x1E26794", VA = "0x1E26794", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1E26868", Offset = "0x1E26868", VA = "0x1E26868", Slot = "7")]
	public void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}
}
[Token(Token = "0x200000A")]
public class CloudSave_GameInterface : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	public enum CompareSaveResult
	{
		[Token(Token = "0x4000038")]
		Equal,
		[Token(Token = "0x4000039")]
		Better,
		[Token(Token = "0x400003A")]
		Worse,
		[Token(Token = "0x400003B")]
		Conflict
	}

	[Token(Token = "0x200000C")]
	public enum SoundType
	{
		[Token(Token = "0x400003D")]
		ClickButton
	}

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CloudSave_GameInterface instance;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool destroyingUnwantedThis;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1E269B8", Offset = "0x1E269B8", VA = "0x1E269B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1E26B10", Offset = "0x1E26B10", VA = "0x1E26B10", Slot = "4")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1E26BE8", Offset = "0x1E26BE8", VA = "0x1E26BE8", Slot = "5")]
	public virtual string GetTextsLanguageID()
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1E26C78", Offset = "0x1E26C78", VA = "0x1E26C78", Slot = "6")]
	public virtual string TranslateText(string trl)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1E26D08", Offset = "0x1E26D08", VA = "0x1E26D08", Slot = "7")]
	public virtual string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1E26D98", Offset = "0x1E26D98", VA = "0x1E26D98", Slot = "8")]
	public virtual string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1E26E28", Offset = "0x1E26E28", VA = "0x1E26E28", Slot = "9")]
	public virtual void BackToMainMenuScene()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1E26E9C", Offset = "0x1E26E9C", VA = "0x1E26E9C", Slot = "10")]
	public virtual uint GetSaveCloudUserId()
	{
		return default(uint);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1E26F18", Offset = "0x1E26F18", VA = "0x1E26F18", Slot = "11")]
	public virtual CloudSave_Saves ExportGameSaves()
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1E26FB8", Offset = "0x1E26FB8", VA = "0x1E26FB8", Slot = "12")]
	public virtual void ImportGameSave(CloudSave_Saves cloudSaves)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1E2702C", Offset = "0x1E2702C", VA = "0x1E2702C", Slot = "13")]
	public virtual void DeleteLocalSaveOnRegister()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1E270A0", Offset = "0x1E270A0", VA = "0x1E270A0", Slot = "14")]
	public virtual string GetSavePreviewLabels()
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1E27130", Offset = "0x1E27130", VA = "0x1E27130", Slot = "15")]
	public virtual string GetSavePreview(CloudSave_Saves save)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1E271C0", Offset = "0x1E271C0", VA = "0x1E271C0", Slot = "16")]
	public virtual CompareSaveResult CompareSave(CloudSave_Saves save1, CloudSave_Saves save2)
	{
		return default(CompareSaveResult);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1E2723C", Offset = "0x1E2723C", VA = "0x1E2723C", Slot = "17")]
	public virtual bool CanSendChangedLocalSaveInCurrentLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1E272B8", Offset = "0x1E272B8", VA = "0x1E272B8", Slot = "18")]
	public virtual GameObject GetCloudStatusLineObject()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1E27334", Offset = "0x1E27334", VA = "0x1E27334", Slot = "19")]
	public virtual bool ShowCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1E273B0", Offset = "0x1E273B0", VA = "0x1E273B0", Slot = "20")]
	public virtual bool ClearCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1E2742C", Offset = "0x1E2742C", VA = "0x1E2742C", Slot = "21")]
	public virtual void PlaySound(SoundType sndType)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1E274A0", Offset = "0x1E274A0", VA = "0x1E274A0", Slot = "22")]
	public virtual void OnShowCloudScreens()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1E27514", Offset = "0x1E27514", VA = "0x1E27514", Slot = "23")]
	public virtual bool HaveSaveForPromoCode()
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1E27590", Offset = "0x1E27590", VA = "0x1E27590", Slot = "24")]
	public virtual string GetPromoCodeSkuName(string sku)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1E27620", Offset = "0x1E27620", VA = "0x1E27620", Slot = "25")]
	public virtual void OnUsePromoCode(string sku)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1E27694", Offset = "0x1E27694", VA = "0x1E27694")]
	public CloudSave_GameInterface()
	{
	}
}
[Token(Token = "0x200000D")]
public class CloudSave_Screen : MonoBehaviour, CloudSave_CoroutineCallback
{
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CloudSave_InfoMessage infoMessage;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1BDF09C", Offset = "0x1BDF09C", VA = "0x1BDF09C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1BDF160", Offset = "0x1BDF160", VA = "0x1BDF160", Slot = "8")]
	public virtual void ActivateScreen()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1BDF164", Offset = "0x1BDF164", VA = "0x1BDF164", Slot = "9")]
	public virtual void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1BDF168", Offset = "0x1BDF168", VA = "0x1BDF168", Slot = "10")]
	public virtual void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1BDF16C", Offset = "0x1BDF16C", VA = "0x1BDF16C", Slot = "11")]
	public virtual void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1BDF170", Offset = "0x1BDF170", VA = "0x1BDF170", Slot = "12")]
	public virtual void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1BDF2C0", Offset = "0x1BDF2C0", VA = "0x1BDF2C0", Slot = "13")]
	public virtual void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1BDF360", Offset = "0x1BDF360", VA = "0x1BDF360")]
	public void ClearInfoMessage()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1BDF3BC", Offset = "0x1BDF3BC", VA = "0x1BDF3BC", Slot = "14")]
	public virtual void SetInfoMessageText(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1BDF468", Offset = "0x1BDF468", VA = "0x1BDF468")]
	protected string TranslateText(string msg)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1BDF1B0", Offset = "0x1BDF1B0", VA = "0x1BDF1B0")]
	public static string TranslateTextWithErrorParse(string msg)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1BDF640", Offset = "0x1BDF640", VA = "0x1BDF640")]
	public CloudSave_Screen()
	{
	}
}
[Token(Token = "0x200000E")]
public class CloudSave_ServerCoroutine : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	public enum CoroutineType
	{
		[Token(Token = "0x4000042")]
		ChangePassword,
		[Token(Token = "0x4000043")]
		LoadGameSave,
		[Token(Token = "0x4000044")]
		Login,
		[Token(Token = "0x4000045")]
		OpenSSLSession,
		[Token(Token = "0x4000046")]
		SendResetPassword,
		[Token(Token = "0x4000047")]
		StoreGameSave,
		[Token(Token = "0x4000048")]
		SetNewsletter,
		[Token(Token = "0x4000049")]
		DeleteAccount,
		[Token(Token = "0x400004A")]
		RedeemCode
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32540", Offset = "0xA32540")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x27AAF50", Offset = "0x27AAF50", VA = "0x27AAF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x27AAF98", Offset = "0x27AAF98", VA = "0x27AAF98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x27AAE90", Offset = "0x27AAE90", VA = "0x27AAE90")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x27AAEBC", Offset = "0x27AAEBC", VA = "0x27AAEBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x27AAEC0", Offset = "0x27AAEC0", VA = "0x27AAEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x27AAF58", Offset = "0x27AAF58", VA = "0x27AAF58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected CloudSave_CoroutineCallback callback;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected bool isRunning;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1BE0254", Offset = "0x1BE0254", VA = "0x1BE0254")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1BE71EC", Offset = "0x1BE71EC", VA = "0x1BE71EC")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback, bool dontDestroyOnLoad)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1BE74DC", Offset = "0x1BE74DC", VA = "0x1BE74DC", Slot = "4")]
	public virtual CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1BE7558", Offset = "0x1BE7558", VA = "0x1BE7558", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA342DC", Offset = "0xA342DC")]
	public virtual IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1BE75B4", Offset = "0x1BE75B4", VA = "0x1BE75B4", Slot = "6")]
	public virtual bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1BDF93C", Offset = "0x1BDF93C", VA = "0x1BDF93C")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1BE7630", Offset = "0x1BE7630", VA = "0x1BE7630")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1BE7638", Offset = "0x1BE7638", VA = "0x1BE7638")]
	protected void CallOnStart()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1BE76F8", Offset = "0x1BE76F8", VA = "0x1BE76F8")]
	protected void CallOnEnd()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1BE77B8", Offset = "0x1BE77B8", VA = "0x1BE77B8")]
	protected void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1BE788C", Offset = "0x1BE788C", VA = "0x1BE788C")]
	protected void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1BE7974", Offset = "0x1BE7974", VA = "0x1BE7974")]
	protected string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1BE79E8", Offset = "0x1BE79E8", VA = "0x1BE79E8")]
	protected string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1BE7A5C", Offset = "0x1BE7A5C", VA = "0x1BE7A5C")]
	public CloudSave_ServerCoroutine()
	{
	}
}
[Token(Token = "0x2000011")]
public class CloudSave_StoreLogin
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool useObscured;

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1BE243C", Offset = "0x1BE243C", VA = "0x1BE243C")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1BE24F0", Offset = "0x1BE24F0", VA = "0x1BE24F0")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1BDFC98", Offset = "0x1BDFC98", VA = "0x1BDFC98")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1BE8A84", Offset = "0x1BE8A84", VA = "0x1BE8A84")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1BE2370", Offset = "0x1BE2370", VA = "0x1BE2370")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1BE22BC", Offset = "0x1BE22BC", VA = "0x1BE22BC")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1BDFD64", Offset = "0x1BDFD64", VA = "0x1BDFD64")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1BE8B38", Offset = "0x1BE8B38", VA = "0x1BE8B38")]
	public CloudSave_StoreLogin()
	{
	}
}
[Token(Token = "0x2000012")]
public class CloudSave_Translate : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string oryginalText;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool translated;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1BE8B90", Offset = "0x1BE8B90", VA = "0x1BE8B90")]
	public void Start()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1BE8D64", Offset = "0x1BE8D64", VA = "0x1BE8D64")]
	public bool IsTranslated()
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1BE8B94", Offset = "0x1BE8B94", VA = "0x1BE8B94")]
	public void TranslateText()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1BE8D6C", Offset = "0x1BE8D6C", VA = "0x1BE8D6C")]
	public void TranslateFromStart()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1BE8DD4", Offset = "0x1BE8DD4", VA = "0x1BE8DD4")]
	public CloudSave_Translate()
	{
	}
}
[Token(Token = "0x2000013")]
public class CloudSave_Save
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string save;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<KeyValuePair<string, string>> properties;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1E278DC", Offset = "0x1E278DC", VA = "0x1E278DC")]
	public CloudSave_Save()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1E27954", Offset = "0x1E27954", VA = "0x1E27954")]
	public CloudSave_Save(string _save)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1E279E0", Offset = "0x1E279E0", VA = "0x1E279E0")]
	public CloudSave_Save(string _save, List<KeyValuePair<string, string>> _properties)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1E27BB8", Offset = "0x1E27BB8", VA = "0x1E27BB8")]
	public CloudSave_Save Clone()
	{
		return null;
	}
}
[Token(Token = "0x2000014")]
public class CloudSave_Saves
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected List<KeyValuePair<string, CloudSave_Save>> saves;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1E25250", Offset = "0x1E25250", VA = "0x1E25250")]
	public CloudSave_Saves()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1E27C24", Offset = "0x1E27C24", VA = "0x1E27C24")]
	public CloudSave_Saves(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1E250C4", Offset = "0x1E250C4", VA = "0x1E250C4")]
	public void Copy(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1E27CB4", Offset = "0x1E27CB4", VA = "0x1E27CB4")]
	public void AddSave(string name, string save)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1E27E74", Offset = "0x1E27E74", VA = "0x1E27E74")]
	public void AddSave(string name, string save, List<KeyValuePair<string, string>> properties)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1E28048", Offset = "0x1E28048", VA = "0x1E28048")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1E257E8", Offset = "0x1E257E8", VA = "0x1E257E8")]
	public int GetSavesCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1E252C8", Offset = "0x1E252C8", VA = "0x1E252C8")]
	public string GetSaveName(int idx)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1E2809C", Offset = "0x1E2809C", VA = "0x1E2809C")]
	public string GetSave(int idx)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1E25504", Offset = "0x1E25504", VA = "0x1E25504")]
	public List<KeyValuePair<string, string>> GetSaveProperties(int idx)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1E25430", Offset = "0x1E25430", VA = "0x1E25430")]
	public bool HaveSave(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1E2820C", Offset = "0x1E2820C", VA = "0x1E2820C")]
	public string GetSave(string name)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1E2569C", Offset = "0x1E2569C", VA = "0x1E2569C")]
	public List<KeyValuePair<string, string>> GetSaveProperties(string name)
	{
		return null;
	}
}
[Token(Token = "0x2000015")]
public static class CloudSave_UserSession
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string autoAccountID;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string logged_email;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string logged_password;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static uint logged_account_id;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string logged_player_name;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static uint logged_clan_id;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string logged_clan_tag;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static bool newsletter_agree;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string logged_ban_info;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string add_sku_items;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string add_player_gifts;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string active_tournament_info;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string active_tournament_info_saved;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string active_challangesOfTheDay_info;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static bool cloudSaveReceived;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static CloudSave_Saves cloudSaves;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static int minimumDelayBetweenSavesInMinutes;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public static bool everyCloudEnterLoginsToServer;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string session_id;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string publicModulus;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static string publicExponent;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static string AES_Key;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static string AES_IV;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static string uidAlphabet;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static int uidLength;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1BE84E8", Offset = "0x1BE84E8", VA = "0x1BE84E8")]
	public static bool IsEncryptionEstablished()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1BE136C", Offset = "0x1BE136C", VA = "0x1BE136C")]
	public static bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1BE0840", Offset = "0x1BE0840", VA = "0x1BE0840")]
	public static bool IsLoggedInAutoAccount()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1BE1440", Offset = "0x1BE1440", VA = "0x1BE1440")]
	public static void clearUser()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1BE8E28", Offset = "0x1BE8E28", VA = "0x1BE8E28")]
	public static void clearUserAndSession()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1BE8EC8", Offset = "0x1BE8EC8", VA = "0x1BE8EC8")]
	public static uint GetAccountIDChecksum(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1BE8F9C", Offset = "0x1BE8F9C", VA = "0x1BE8F9C")]
	public static uint GetUIDFromAccountID(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1BE4594", Offset = "0x1BE4594", VA = "0x1BE4594")]
	public static string GetStringUIDFromAccountID(uint id)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1BE9010", Offset = "0x1BE9010", VA = "0x1BE9010")]
	public static bool GetAccountIDFromStringUID(string suid, out uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1BE91F4", Offset = "0x1BE91F4", VA = "0x1BE91F4")]
	public static bool GetAutoAccountLogin(out string email, out string password)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1BE2244", Offset = "0x1BE2244", VA = "0x1BE2244")]
	public static bool IsAutoAccountEmail(string email)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000016")]
public static class CloudSave_Utils
{
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1BE9564", Offset = "0x1BE9564", VA = "0x1BE9564")]
	public static string RSA_encrypt(string toBeEncrypted)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1BE9568", Offset = "0x1BE9568", VA = "0x1BE9568")]
	public static void generateAESkeyAndIV()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1BE956C", Offset = "0x1BE956C", VA = "0x1BE956C")]
	public static string AES_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1BE9574", Offset = "0x1BE9574", VA = "0x1BE9574")]
	public static string AES_encrypt(string input, bool MD5)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1BE80DC", Offset = "0x1BE80DC", VA = "0x1BE80DC")]
	public static string AES_decrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1BE9744", Offset = "0x1BE9744", VA = "0x1BE9744")]
	private static string GetMd5Hash(MD5 md5Hash, string input)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1BE95F0", Offset = "0x1BE95F0", VA = "0x1BE95F0")]
	public static string MD5_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1BE81C0", Offset = "0x1BE81C0", VA = "0x1BE81C0")]
	public static string MD5_encryptWithSalt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1BE9878", Offset = "0x1BE9878", VA = "0x1BE9878")]
	public static string Sha256_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1BE936C", Offset = "0x1BE936C", VA = "0x1BE936C")]
	public static string Sha256_encryptWithSalt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1BE9AF4", Offset = "0x1BE9AF4", VA = "0x1BE9AF4")]
	public static string convertBytesToString(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1BE9B3C", Offset = "0x1BE9B3C", VA = "0x1BE9B3C")]
	public static byte[] convertStringToBytes(string s)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1BE2BE4", Offset = "0x1BE2BE4", VA = "0x1BE2BE4")]
	public static bool TestValidEmailFormat(string email)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1BE9B78", Offset = "0x1BE9B78", VA = "0x1BE9B78")]
	public static bool GetValueInsideTag(string text, string tag, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1BE9D44", Offset = "0x1BE9D44", VA = "0x1BE9D44")]
	public static string[] GetValuesInsideTags(string text, string tag)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1BE9F8C", Offset = "0x1BE9F8C", VA = "0x1BE9F8C")]
	public static Dictionary<string, string> ParseKeysAssignedValues(string text, char delimeter)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1BEA180", Offset = "0x1BEA180", VA = "0x1BEA180")]
	public static bool GetValueOfTag(string text, string valTag, out string outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1BEA240", Offset = "0x1BEA240", VA = "0x1BEA240")]
	public static Dictionary<string, string> GetTagsAndValues(string text)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1BEA3E0", Offset = "0x1BEA3E0", VA = "0x1BEA3E0")]
	public static bool GetIntValueOfTag(string text, string valTag, out int outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1BDF4E4", Offset = "0x1BDF4E4", VA = "0x1BDF4E4")]
	public static bool ParseErrorCode(string text, out string errorText, out string errorExtCode)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1BEA488", Offset = "0x1BEA488", VA = "0x1BEA488")]
	public static string GetUrlWithSecureProtocol(string url)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1BEA554", Offset = "0x1BEA554", VA = "0x1BEA554")]
	public static string GetWebGLUrlProxy(string url)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1BEA558", Offset = "0x1BEA558", VA = "0x1BEA558")]
	public static string GenRandomString(int len)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1BEA624", Offset = "0x1BEA624", VA = "0x1BEA624")]
	public static string EncodeBase64(string plain)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1BEA6B4", Offset = "0x1BEA6B4", VA = "0x1BEA6B4")]
	public static string DecodeBase64(string encoded)
	{
		return null;
	}
}
[Token(Token = "0x2000017")]
public class CloudSave_ServerCoroutine_ChangePassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32550", Offset = "0xA32550")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_ChangePassword <>4__this;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x27AB674", Offset = "0x27AB674", VA = "0x27AB674", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x27AB6BC", Offset = "0x27AB6BC", VA = "0x27AB6BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x27AAFA0", Offset = "0x27AAFA0", VA = "0x27AAFA0")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x27AAFCC", Offset = "0x27AAFCC", VA = "0x27AAFCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x27AAFD0", Offset = "0x27AAFD0", VA = "0x27AAFD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x27AB67C", Offset = "0x27AB67C", VA = "0x27AB67C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string oldPassword;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected string newPassword;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected bool changePasswordResult;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1BE025C", Offset = "0x1BE025C", VA = "0x1BE025C")]
	public void InitParams(string _oldPassword, string _newPassword)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1BE7A64", Offset = "0x1BE7A64", VA = "0x1BE7A64", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1BE7A6C", Offset = "0x1BE7A6C", VA = "0x1BE7A6C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1BE7A74", Offset = "0x1BE7A74", VA = "0x1BE7A74", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3438C", Offset = "0xA3438C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1BE7AE0", Offset = "0x1BE7AE0", VA = "0x1BE7AE0")]
	public CloudSave_ServerCoroutine_ChangePassword()
	{
	}
}
[Token(Token = "0x2000019")]
public class CloudSave_ServerCoroutine_DeleteAccount : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32560", Offset = "0xA32560")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_DeleteAccount <>4__this;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x27ABD1C", Offset = "0x27ABD1C", VA = "0x27ABD1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x27ABD64", Offset = "0x27ABD64", VA = "0x27ABD64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x27AB6C4", Offset = "0x27AB6C4", VA = "0x27AB6C4")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x27AB6F0", Offset = "0x27AB6F0", VA = "0x27AB6F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x27AB6F4", Offset = "0x27AB6F4", VA = "0x27AB6F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x27ABD24", Offset = "0x27ABD24", VA = "0x27ABD24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string password;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool result;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1BE7B34", Offset = "0x1BE7B34", VA = "0x1BE7B34")]
	public void InitParams(string _password)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1BE7B3C", Offset = "0x1BE7B3C", VA = "0x1BE7B3C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1BE7B44", Offset = "0x1BE7B44", VA = "0x1BE7B44", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1BE7B4C", Offset = "0x1BE7B4C", VA = "0x1BE7B4C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3443C", Offset = "0xA3443C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1BE7BB8", Offset = "0x1BE7BB8", VA = "0x1BE7BB8")]
	public CloudSave_ServerCoroutine_DeleteAccount()
	{
	}
}
[Token(Token = "0x200001B")]
public class CloudSave_ServerCoroutine_LoadGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32570", Offset = "0xA32570")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_LoadGameSave <>4__this;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000008")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x26AD7C4", Offset = "0x26AD7C4", VA = "0x26AD7C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x26AD80C", Offset = "0x26AD80C", VA = "0x26AD80C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x26AD158", Offset = "0x26AD158", VA = "0x26AD158")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x26AD184", Offset = "0x26AD184", VA = "0x26AD184", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x26AD188", Offset = "0x26AD188", VA = "0x26AD188", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x26AD7CC", Offset = "0x26AD7CC", VA = "0x26AD7CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected CloudSave_Saves loadedSaves;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool loadSaveResult;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1BE7C0C", Offset = "0x1BE7C0C", VA = "0x1BE7C0C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1BE7C14", Offset = "0x1BE7C14", VA = "0x1BE7C14", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1BE450C", Offset = "0x1BE450C", VA = "0x1BE450C")]
	public CloudSave_Saves GetResultLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1BE7C1C", Offset = "0x1BE7C1C", VA = "0x1BE7C1C")]
	public static bool ParseSavesFromServer(string text, CloudSave_Saves localSaves, out CloudSave_Saves outSaves)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1BE8234", Offset = "0x1BE8234", VA = "0x1BE8234", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA344EC", Offset = "0xA344EC")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1BE82A0", Offset = "0x1BE82A0", VA = "0x1BE82A0")]
	public CloudSave_ServerCoroutine_LoadGameSave()
	{
	}
}
[Token(Token = "0x200001D")]
public class CloudSave_ServerCoroutine_Login : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32580", Offset = "0xA32580")]
	private sealed class <Run>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_Login <>4__this;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x26AE6BC", Offset = "0x26AE6BC", VA = "0x26AE6BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x26AE704", Offset = "0x26AE704", VA = "0x26AE704", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x26AD814", Offset = "0x26AD814", VA = "0x26AD814")]
		[DebuggerHidden]
		public <Run>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x26AD840", Offset = "0x26AD840", VA = "0x26AD840", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x26AD844", Offset = "0x26AD844", VA = "0x26AD844", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x26AE6C4", Offset = "0x26AE6C4", VA = "0x26AE6C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	protected bool register;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string email;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected string password;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected bool newsletter;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected CloudSave_Saves localSavesToCompare;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool loginResult;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	protected bool loadSaveResult;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected CloudSave_Saves loadedSaves;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static bool firstLogin;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1BE2D4C", Offset = "0x1BE2D4C", VA = "0x1BE2D4C")]
	public void InitParams(bool _register, string _email, string _password, bool _newsletter, CloudSave_Saves _localSavesToCompare)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1BE8304", Offset = "0x1BE8304", VA = "0x1BE8304", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1BE830C", Offset = "0x1BE830C", VA = "0x1BE830C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1BE8314", Offset = "0x1BE8314", VA = "0x1BE8314")]
	public string GetEmail()
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1BE831C", Offset = "0x1BE831C", VA = "0x1BE831C")]
	public string GetPassword()
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1BE8324", Offset = "0x1BE8324", VA = "0x1BE8324")]
	public bool GetLoadSaveResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1BE21BC", Offset = "0x1BE21BC", VA = "0x1BE21BC")]
	public CloudSave_Saves GetLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1BE832C", Offset = "0x1BE832C", VA = "0x1BE832C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3459C", Offset = "0xA3459C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1BE8398", Offset = "0x1BE8398", VA = "0x1BE8398")]
	public CloudSave_ServerCoroutine_Login()
	{
	}
}
[Token(Token = "0x200001F")]
public class CloudSave_ServerCoroutine_OpenSSLSession : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32590", Offset = "0xA32590")]
	private sealed class <Run>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_OpenSSLSession <>4__this;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWWwrapper <w>5__2;

		[Token(Token = "0x1700000C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x26AF4E0", Offset = "0x26AF4E0", VA = "0x26AF4E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x26AF528", Offset = "0x26AF528", VA = "0x26AF528", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x26AEDDC", Offset = "0x26AEDDC", VA = "0x26AEDDC")]
		[DebuggerHidden]
		public <Run>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x26AEE08", Offset = "0x26AEE08", VA = "0x26AEE08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x26AEE0C", Offset = "0x26AEE0C", VA = "0x26AEE0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x26AF4E8", Offset = "0x26AF4E8", VA = "0x26AF4E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA325A0", Offset = "0xA325A0")]
	private sealed class <EstablishAESSecurity>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_OpenSSLSession <>4__this;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWWwrapper <w>5__2;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x26AED8C", Offset = "0x26AED8C", VA = "0x26AED8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x26AEDD4", Offset = "0x26AEDD4", VA = "0x26AEDD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x26AE70C", Offset = "0x26AE70C", VA = "0x26AE70C")]
		[DebuggerHidden]
		public <EstablishAESSecurity>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x26AE738", Offset = "0x26AE738", VA = "0x26AE738", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x26AE73C", Offset = "0x26AE73C", VA = "0x26AE73C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x26AED94", Offset = "0x26AED94", VA = "0x26AED94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int aesTry;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1BE8488", Offset = "0x1BE8488", VA = "0x1BE8488", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1BE8490", Offset = "0x1BE8490", VA = "0x1BE8490", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1BE8670", Offset = "0x1BE8670", VA = "0x1BE8670", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3464C", Offset = "0xA3464C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1BE86DC", Offset = "0x1BE86DC", VA = "0x1BE86DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA346AC", Offset = "0xA346AC")]
	protected IEnumerator EstablishAESSecurity()
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1BE8748", Offset = "0x1BE8748", VA = "0x1BE8748")]
	public CloudSave_ServerCoroutine_OpenSSLSession()
	{
	}
}
[Token(Token = "0x2000022")]
public class CloudSave_ServerCoroutine_RedeemCode : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA325B0", Offset = "0xA325B0")]
	private sealed class <Run>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_RedeemCode <>4__this;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x26AFC00", Offset = "0x26AFC00", VA = "0x26AFC00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x26AFC48", Offset = "0x26AFC48", VA = "0x26AFC48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x26AF530", Offset = "0x26AF530", VA = "0x26AF530")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x26AF55C", Offset = "0x26AF55C", VA = "0x26AF55C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x26AF560", Offset = "0x26AF560", VA = "0x26AF560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x26AFC08", Offset = "0x26AFC08", VA = "0x26AFC08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string code;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool result;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected string resultSku;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1BE8750", Offset = "0x1BE8750", VA = "0x1BE8750")]
	public void InitParams(string _code)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1BE8758", Offset = "0x1BE8758", VA = "0x1BE8758", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1BE8760", Offset = "0x1BE8760", VA = "0x1BE8760", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1BE8768", Offset = "0x1BE8768", VA = "0x1BE8768")]
	public string GetResultSku()
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1BE8770", Offset = "0x1BE8770", VA = "0x1BE8770", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA347AC", Offset = "0xA347AC")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1BE87DC", Offset = "0x1BE87DC", VA = "0x1BE87DC")]
	public CloudSave_ServerCoroutine_RedeemCode()
	{
	}
}
[Token(Token = "0x2000024")]
public class CloudSave_ServerCoroutine_SendResetPassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA325C0", Offset = "0xA325C0")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_SendResetPassword <>4__this;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x26B02F0", Offset = "0x26B02F0", VA = "0x26B02F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x26B0338", Offset = "0x26B0338", VA = "0x26B0338", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x26AFC50", Offset = "0x26AFC50", VA = "0x26AFC50")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x26AFC7C", Offset = "0x26AFC7C", VA = "0x26AFC7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x26AFC80", Offset = "0x26AFC80", VA = "0x26AFC80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x26B02F8", Offset = "0x26B02F8", VA = "0x26B02F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string email;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool sendResetResult;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1BE8834", Offset = "0x1BE8834", VA = "0x1BE8834")]
	public void InitParams(string _email)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1BE883C", Offset = "0x1BE883C", VA = "0x1BE883C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1BE8844", Offset = "0x1BE8844", VA = "0x1BE8844", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1BE884C", Offset = "0x1BE884C", VA = "0x1BE884C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3485C", Offset = "0xA3485C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1BE88B8", Offset = "0x1BE88B8", VA = "0x1BE88B8")]
	public CloudSave_ServerCoroutine_SendResetPassword()
	{
	}
}
[Token(Token = "0x2000026")]
public class CloudSave_ServerCoroutine_SetNewsletter : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA325D0", Offset = "0xA325D0")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_SetNewsletter <>4__this;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x26B0A10", Offset = "0x26B0A10", VA = "0x26B0A10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x26B0A58", Offset = "0x26B0A58", VA = "0x26B0A58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x26B0340", Offset = "0x26B0340", VA = "0x26B0340")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x26B036C", Offset = "0x26B036C", VA = "0x26B036C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x26B0370", Offset = "0x26B0370", VA = "0x26B0370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x26B0A18", Offset = "0x26B0A18", VA = "0x26B0A18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	protected bool signed;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	protected bool result;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1BE890C", Offset = "0x1BE890C", VA = "0x1BE890C")]
	public void InitParams(bool _signed)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1BE8918", Offset = "0x1BE8918", VA = "0x1BE8918", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1BE8920", Offset = "0x1BE8920", VA = "0x1BE8920", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1BE8928", Offset = "0x1BE8928", VA = "0x1BE8928", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3490C", Offset = "0xA3490C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1BE8994", Offset = "0x1BE8994", VA = "0x1BE8994")]
	public CloudSave_ServerCoroutine_SetNewsletter()
	{
	}
}
[Token(Token = "0x2000028")]
public class CloudSave_ServerCoroutine_StoreGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA325E0", Offset = "0xA325E0")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_StoreGameSave <>4__this;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x26B1C0C", Offset = "0x26B1C0C", VA = "0x26B1C0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x26B1C54", Offset = "0x26B1C54", VA = "0x26B1C54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x26B0A60", Offset = "0x26B0A60", VA = "0x26B0A60")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x26B0A8C", Offset = "0x26B0A8C", VA = "0x26B0A8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x26B0A90", Offset = "0x26B0A90", VA = "0x26B0A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x26B1C14", Offset = "0x26B1C14", VA = "0x26B1C14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected CloudSave_Saves storeSaves;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool storeGameResult;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1BE4EF4", Offset = "0x1BE4EF4", VA = "0x1BE4EF4")]
	public void InitParams(CloudSave_Saves _storeSaves)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1BE899C", Offset = "0x1BE899C", VA = "0x1BE899C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1BE89A4", Offset = "0x1BE89A4", VA = "0x1BE89A4", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1BE89AC", Offset = "0x1BE89AC", VA = "0x1BE89AC")]
	public CloudSave_Saves GetStoringSaves()
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1BE89B4", Offset = "0x1BE89B4", VA = "0x1BE89B4", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA349BC", Offset = "0xA349BC")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1BE8A20", Offset = "0x1BE8A20", VA = "0x1BE8A20")]
	public CloudSave_ServerCoroutine_StoreGameSave()
	{
	}
}
[Token(Token = "0x200002A")]
public class CloudSave_Screen_ChangePassword : CloudSave_Screen
{
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh emailText;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MUI_InputText oldPasswordField;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MUI_InputText newPasswordField;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MUI_InputText repeatNewPasswordField;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CloudSave_Checkbox toggleShowOldPassword;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CloudSave_Checkbox toggleShowNewPassword;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public CloudSave_Checkbox toggleShowRepeatPassword;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CloudSave_ServerCoroutine_ChangePassword runningCoroutine;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string newPassword;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool passwordChanged;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1BDF648", Offset = "0x1BDF648", VA = "0x1BDF648", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1BDF89C", Offset = "0x1BDF89C", VA = "0x1BDF89C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1BDF9B4", Offset = "0x1BDF9B4", VA = "0x1BDF9B4", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1BDFA90", Offset = "0x1BDFA90", VA = "0x1BDFA90", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1BDFE0C", Offset = "0x1BDFE0C", VA = "0x1BDFE0C")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1BDFE78", Offset = "0x1BDFE78", VA = "0x1BDFE78")]
	public void OnSwitchShowOldPassword(bool on)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1BDFF44", Offset = "0x1BDFF44", VA = "0x1BDFF44")]
	public void OnSwitchShowNewPassword(bool on)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1BDFF4C", Offset = "0x1BDFF4C", VA = "0x1BDFF4C")]
	public void OnSwitchShowRepeatPassword(bool on)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1BDFE80", Offset = "0x1BDFE80", VA = "0x1BDFE80")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1BDFF54", Offset = "0x1BDFF54", VA = "0x1BDFF54")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1BE0264", Offset = "0x1BE0264", VA = "0x1BE0264")]
	public CloudSave_Screen_ChangePassword()
	{
	}
}
[Token(Token = "0x200002B")]
public class CloudSave_Screen_CloudInfo : CloudSave_Screen
{
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA325F0", Offset = "0xA325F0")]
	private sealed class <AnimDotsCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_Screen_CloudInfo <>4__this;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <idx>5__2;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <startTime>5__3;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 <scaleFrom>5__4;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 <scaleTo>5__5;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x27AAE40", Offset = "0x27AAE40", VA = "0x27AAE40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x27AAE88", Offset = "0x27AAE88", VA = "0x27AAE88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x27AAAF4", Offset = "0x27AAAF4", VA = "0x27AAAF4")]
		[DebuggerHidden]
		public <AnimDotsCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x27AAB20", Offset = "0x27AAB20", VA = "0x27AAB20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x27AAB24", Offset = "0x27AAB24", VA = "0x27AAB24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x27AAE48", Offset = "0x27AAE48", VA = "0x27AAE48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] animDots;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject animDotBig;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float animSpeed;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected Vector3 scaleDot;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Vector3 scaleDotBig;

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1BE02B8", Offset = "0x1BE02B8", VA = "0x1BE02B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1BE03B4", Offset = "0x1BE03B4", VA = "0x1BE03B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1BE03B8", Offset = "0x1BE03B8", VA = "0x1BE03B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1BE0450", Offset = "0x1BE0450", VA = "0x1BE0450", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1BE0478", Offset = "0x1BE0478", VA = "0x1BE0478", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1BE04A0", Offset = "0x1BE04A0", VA = "0x1BE04A0")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1BE050C", Offset = "0x1BE050C", VA = "0x1BE050C")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1BE0578", Offset = "0x1BE0578", VA = "0x1BE0578")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1BE05E4", Offset = "0x1BE05E4", VA = "0x1BE05E4")]
	public void OnClickCloseToLogin()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1BE03E4", Offset = "0x1BE03E4", VA = "0x1BE03E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA34A6C", Offset = "0xA34A6C")]
	protected IEnumerator AnimDotsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1BE0650", Offset = "0x1BE0650", VA = "0x1BE0650")]
	public CloudSave_Screen_CloudInfo()
	{
	}
}
[Token(Token = "0x200002D")]
public class CloudSave_Screen_DeleteAccount : CloudSave_Screen
{
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh message;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject passwordGroup;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MUI_InputText passwordField;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CloudSave_Checkbox toggleShowPassword;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CloudSave_ServerCoroutine_DeleteAccount runningCoroutine;

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1BE0660", Offset = "0x1BE0660", VA = "0x1BE0660", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1BE08A4", Offset = "0x1BE08A4", VA = "0x1BE08A4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1BE0944", Offset = "0x1BE0944", VA = "0x1BE0944", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1BE0A20", Offset = "0x1BE0A20", VA = "0x1BE0A20", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1BE0BA4", Offset = "0x1BE0BA4", VA = "0x1BE0BA4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1BE0C10", Offset = "0x1BE0C10", VA = "0x1BE0C10")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1BE0C68", Offset = "0x1BE0C68", VA = "0x1BE0C68")]
	public void OnClickDelete()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1BE0E18", Offset = "0x1BE0E18", VA = "0x1BE0E18")]
	public CloudSave_Screen_DeleteAccount()
	{
	}
}
[Token(Token = "0x200002E")]
public class CloudSave_Screen_Login : CloudSave_Screen
{
	[Token(Token = "0x200002F")]
	private enum Mode
	{
		[Token(Token = "0x40000E7")]
		Register,
		[Token(Token = "0x40000E8")]
		Login
	}

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CloudSave_Checkbox switchLoginButtonCheckbox;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CloudSave_Checkbox switchRegisterButtonCheckbox;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMesh loginButtonText;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MUI_InputText emailField;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MUI_InputText passwordField;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MUI_InputText repeatPasswordField;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public CloudSave_Checkbox toggleShowPassword1;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public CloudSave_Checkbox toggleShowPassword2;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CloudSave_Checkbox newsletterToggle;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject newsletterText;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject newsletterInfoButton;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool isAutoLogin;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float switchSelectedSizeMul;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private CloudSave_ServerCoroutine_Login runningCoroutine;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Mode mode;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string email;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string password;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string confirmRegisterEmail;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string confirmRegisterPassword;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool confirmNewsletter;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	private bool backFromTermsOfUseCompleted;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1BE0E20", Offset = "0x1BE0E20", VA = "0x1BE0E20")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1BE0E98", Offset = "0x1BE0E98", VA = "0x1BE0E98")]
	private void Start()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1BE0E9C", Offset = "0x1BE0E9C", VA = "0x1BE0E9C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1BE17B8", Offset = "0x1BE17B8", VA = "0x1BE17B8", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1BE1858", Offset = "0x1BE1858", VA = "0x1BE1858")]
	public void WillBackFromTermsOfUseCompleted()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1BE1864", Offset = "0x1BE1864", VA = "0x1BE1864")]
	public void OnBackFromTermsOfUse(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1BE19F8", Offset = "0x1BE19F8", VA = "0x1BE19F8")]
	public void OnBackFromTermsOfUseLogin(string _email, string _password, bool _newsletter, CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1BE1FF4", Offset = "0x1BE1FF4", VA = "0x1BE1FF4", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1BE20D0", Offset = "0x1BE20D0", VA = "0x1BE20D0", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1BE1A2C", Offset = "0x1BE1A2C", VA = "0x1BE1A2C")]
	protected void OnEndCoroutine(CloudSave_ServerCoroutine coroutine, bool fromTermsOfUse)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1BE1538", Offset = "0x1BE1538", VA = "0x1BE1538")]
	private void UpdateModeFields()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1BE11F4", Offset = "0x1BE11F4", VA = "0x1BE11F4")]
	private void LoadFromPlayerPrefs()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1BE25A4", Offset = "0x1BE25A4", VA = "0x1BE25A4")]
	private void OnLogin(bool confirmDeleteSaveOnRegister)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1BE2D84", Offset = "0x1BE2D84", VA = "0x1BE2D84")]
	private void DeleteSaveOnRegisterCallback(bool result)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1BE2EA0", Offset = "0x1BE2EA0", VA = "0x1BE2EA0")]
	private void DeleteSaveOnLoginToEmptyCallback(bool result)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1BE2FD0", Offset = "0x1BE2FD0", VA = "0x1BE2FD0")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1BE303C", Offset = "0x1BE303C", VA = "0x1BE303C")]
	public void OnClickShowInfo()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1BE30A8", Offset = "0x1BE30A8", VA = "0x1BE30A8")]
	public void OnClickSwitchLogin(bool switched)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1BE3134", Offset = "0x1BE3134", VA = "0x1BE3134")]
	public void OnClickSwitchRegister(bool switched)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1BE17B0", Offset = "0x1BE17B0", VA = "0x1BE17B0")]
	public void OnClickLogin()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1BE31BC", Offset = "0x1BE31BC", VA = "0x1BE31BC")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1BE327C", Offset = "0x1BE327C", VA = "0x1BE327C")]
	public void OnSwitchShowPassword1(bool on)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1BE3318", Offset = "0x1BE3318", VA = "0x1BE3318")]
	public void OnSwitchShowPassword2(bool on)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1BE3284", Offset = "0x1BE3284", VA = "0x1BE3284")]
	public void OnSwitchShowPassword(int num, bool on)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1BE3320", Offset = "0x1BE3320", VA = "0x1BE3320")]
	public CloudSave_Screen_Login()
	{
	}
}
[Token(Token = "0x2000030")]
public class CloudSave_Screen_Menu : CloudSave_Screen
{
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject loginInfoGroup;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMesh loginInfoText;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject loginInfoGroup2;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loginInfoGroup2_posAuto;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMesh loginInfoText2;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh[] previewLabelsText;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMesh localSavePreviewText;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMesh cloudSavePreviewText;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject importButton;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject importButtonDisabled;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject exportButton;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject exportButtonDisabled;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CloudSave_Checkbox checkboxShowEmail;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private CloudSave_ServerCoroutine runningCoroutine;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private CloudSave_Saves localSaves;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float confirmImportOlderTime;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float confirmExportOlderTime;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int adjustCheckboxShowEmail;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 loginInfoGroup2_pos;

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1BE3384", Offset = "0x1BE3384", VA = "0x1BE3384", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1BE3D70", Offset = "0x1BE3D70", VA = "0x1BE3D70", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1BE3E0C", Offset = "0x1BE3E0C", VA = "0x1BE3E0C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1BE3F34", Offset = "0x1BE3F34", VA = "0x1BE3F34", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1BE40A4", Offset = "0x1BE40A4", VA = "0x1BE40A4", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1BE424C", Offset = "0x1BE424C", VA = "0x1BE424C")]
	protected void OnEndCoroutineLoad()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1BE4378", Offset = "0x1BE4378", VA = "0x1BE4378")]
	protected void OnEndCoroutineStore()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1BE39C8", Offset = "0x1BE39C8", VA = "0x1BE39C8")]
	protected void EnableImportExportButtons(bool import, bool export)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1BE3698", Offset = "0x1BE3698", VA = "0x1BE3698")]
	protected void FillLoginInfo()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1BE3AD4", Offset = "0x1BE3AD4", VA = "0x1BE3AD4")]
	protected void UpdateAfterReceivedCloudSave()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1BE49E8", Offset = "0x1BE49E8", VA = "0x1BE49E8")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1BE4A54", Offset = "0x1BE4A54", VA = "0x1BE4A54")]
	public void OnClickSettings()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1BE4AC0", Offset = "0x1BE4AC0", VA = "0x1BE4AC0")]
	public void OnSwitchShowEmail(bool on)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1BE4AC4", Offset = "0x1BE4AC4", VA = "0x1BE4AC4")]
	public void OnClickSetPassword()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1BE4B84", Offset = "0x1BE4B84", VA = "0x1BE4B84")]
	public void OnClickLogout()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1BE4C44", Offset = "0x1BE4C44", VA = "0x1BE4C44")]
	public void OnClickImport()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1BE4790", Offset = "0x1BE4790", VA = "0x1BE4790")]
	public void OnClickExport()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1BE4F10", Offset = "0x1BE4F10", VA = "0x1BE4F10")]
	public CloudSave_Screen_Menu()
	{
	}
}
[Token(Token = "0x2000031")]
public class CloudSave_Screen_Message : CloudSave_Screen
{
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh messageText;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject textWarning;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject buttonOK;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject buttonCancel;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject buttonClose;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected CloudSave_Screen backToScreen;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Action<bool> resultCallback;

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1BE4F74", Offset = "0x1BE4F74", VA = "0x1BE4F74", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1BE4F9C", Offset = "0x1BE4F9C", VA = "0x1BE4F9C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1BE4FC4", Offset = "0x1BE4FC4", VA = "0x1BE4FC4")]
	public void Init(string text, bool okcancel, bool warning, CloudSave_Screen _backToScreen, Action<bool> _resultCallback)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1BE510C", Offset = "0x1BE510C", VA = "0x1BE510C")]
	public void OnClickOK()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1BE5184", Offset = "0x1BE5184", VA = "0x1BE5184")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1BE51FC", Offset = "0x1BE51FC", VA = "0x1BE51FC")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1BE5274", Offset = "0x1BE5274", VA = "0x1BE5274")]
	public CloudSave_Screen_Message()
	{
	}
}
[Token(Token = "0x2000032")]
public class CloudSave_Screen_RedeemCode : CloudSave_Screen
{
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText codeField;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject messageWnd;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMesh messageText;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CloudSave_ServerCoroutine_RedeemCode runningCoroutine;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool result;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string resultSku;

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1BE527C", Offset = "0x1BE527C", VA = "0x1BE527C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1BE52F8", Offset = "0x1BE52F8", VA = "0x1BE52F8", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1BE5398", Offset = "0x1BE5398", VA = "0x1BE5398", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1BE5474", Offset = "0x1BE5474", VA = "0x1BE5474", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1BE5710", Offset = "0x1BE5710", VA = "0x1BE5710")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1BE577C", Offset = "0x1BE577C", VA = "0x1BE577C")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1BE595C", Offset = "0x1BE595C", VA = "0x1BE595C")]
	public CloudSave_Screen_RedeemCode()
	{
	}
}
[Token(Token = "0x2000033")]
public class CloudSave_Screen_ResetPassword : CloudSave_Screen
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText emailField;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CloudSave_ServerCoroutine_SendResetPassword runningCoroutine;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string email;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool passwordSend;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool backToSettings;

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1BE59B0", Offset = "0x1BE59B0", VA = "0x1BE59B0", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1BE5AC0", Offset = "0x1BE5AC0", VA = "0x1BE5AC0", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1BE5B60", Offset = "0x1BE5B60", VA = "0x1BE5B60")]
	public void Init(bool _backToSettings)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1BE5B6C", Offset = "0x1BE5B6C", VA = "0x1BE5B6C", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1BE5C48", Offset = "0x1BE5C48", VA = "0x1BE5C48", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1BE5DC0", Offset = "0x1BE5DC0", VA = "0x1BE5DC0")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1BE5E34", Offset = "0x1BE5E34", VA = "0x1BE5E34")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1BE5F94", Offset = "0x1BE5F94", VA = "0x1BE5F94")]
	public CloudSave_Screen_ResetPassword()
	{
	}
}
[Token(Token = "0x2000034")]
public class CloudSave_Screen_SelectMode : CloudSave_Screen_CloudInfo
{
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1BE5FE8", Offset = "0x1BE5FE8", VA = "0x1BE5FE8", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1BE6010", Offset = "0x1BE6010", VA = "0x1BE6010", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1BE6038", Offset = "0x1BE6038", VA = "0x1BE6038")]
	public void OnClickModeEmail()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1BE60A4", Offset = "0x1BE60A4", VA = "0x1BE60A4")]
	public void OnClickModeAuto()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1BE6110", Offset = "0x1BE6110", VA = "0x1BE6110")]
	public new void OnClickBack()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1BE617C", Offset = "0x1BE617C", VA = "0x1BE617C")]
	public CloudSave_Screen_SelectMode()
	{
	}
}
[Token(Token = "0x2000035")]
public class CloudSave_Screen_Settings : CloudSave_Screen
{
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CloudSave_Checkbox newsletterToggle;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject groupEmail;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject groupAutoAccount;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject buttonSupport;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject buttonDeleteAccount;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject buttonPrivacyPolicy;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private CloudSave_ServerCoroutine_SetNewsletter runningCoroutine;

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1BE618C", Offset = "0x1BE618C", VA = "0x1BE618C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1BE6470", Offset = "0x1BE6470", VA = "0x1BE6470", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1BE6510", Offset = "0x1BE6510", VA = "0x1BE6510", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1BE65EC", Offset = "0x1BE65EC", VA = "0x1BE65EC", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1BE6704", Offset = "0x1BE6704", VA = "0x1BE6704")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1BE6770", Offset = "0x1BE6770", VA = "0x1BE6770")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1BE67DC", Offset = "0x1BE67DC", VA = "0x1BE67DC")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1BE6848", Offset = "0x1BE6848", VA = "0x1BE6848")]
	public void OnClickDeleteAccount()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1BE68B4", Offset = "0x1BE68B4", VA = "0x1BE68B4")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1BE6920", Offset = "0x1BE6920", VA = "0x1BE6920")]
	public void OnSwitchNewsletter(bool signed)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1BE6AB0", Offset = "0x1BE6AB0", VA = "0x1BE6AB0")]
	public CloudSave_Screen_Settings()
	{
	}
}
[Token(Token = "0x2000036")]
public class CloudSave_Screen_TermsOfUse : CloudSave_Screen
{
	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected bool autoAccount;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string email;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected string password;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected bool newsletter;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected string infoMsg1;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected string infoMsg2;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected bool infoMsgWarning;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CloudSave_ServerCoroutine_Login runningCoroutine;

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1BE6AB8", Offset = "0x1BE6AB8", VA = "0x1BE6AB8", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1BE6AE0", Offset = "0x1BE6AE0", VA = "0x1BE6AE0", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1BE6B80", Offset = "0x1BE6B80", VA = "0x1BE6B80")]
	public void Init(bool _autoAccount, string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1BE6B98", Offset = "0x1BE6B98", VA = "0x1BE6B98", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1BE6C74", Offset = "0x1BE6C74", VA = "0x1BE6C74", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1BE6ED0", Offset = "0x1BE6ED0", VA = "0x1BE6ED0", Slot = "12")]
	public override void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1BE6F38", Offset = "0x1BE6F38", VA = "0x1BE6F38", Slot = "13")]
	public override void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1BE6F48", Offset = "0x1BE6F48", VA = "0x1BE6F48")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1BE70D4", Offset = "0x1BE70D4", VA = "0x1BE70D4")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1BE7194", Offset = "0x1BE7194", VA = "0x1BE7194")]
	public CloudSave_Screen_TermsOfUse()
	{
	}
}
[Token(Token = "0x2000037")]
public class CloudSave_AdjustIconToText : MonoBehaviour
{
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32600", Offset = "0xA32600")]
	private sealed class <AdjustToTextCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_AdjustIconToText <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x27AAAA4", Offset = "0x27AAAA4", VA = "0x27AAAA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x27AAAEC", Offset = "0x27AAAEC", VA = "0x27AAAEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x27AA514", Offset = "0x27AA514", VA = "0x27AA514")]
		[DebuggerHidden]
		public <AdjustToTextCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x27AA540", Offset = "0x27AA540", VA = "0x27AA540", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x27AA544", Offset = "0x27AA544", VA = "0x27AA544", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x27AAAAC", Offset = "0x27AAAAC", VA = "0x27AAAAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject textObject;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool toRight;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float margin;

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1E22860", Offset = "0x1E22860", VA = "0x1E22860")]
	public void Start()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1E2288C", Offset = "0x1E2288C", VA = "0x1E2288C")]
	private void AdjustToText()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1E228B8", Offset = "0x1E228B8", VA = "0x1E228B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA34B1C", Offset = "0xA34B1C")]
	public IEnumerator AdjustToTextCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1E22924", Offset = "0x1E22924", VA = "0x1E22924")]
	public CloudSave_AdjustIconToText()
	{
	}
}
[Token(Token = "0x2000039")]
public class CloudSave_Checkbox : MonoBehaviour
{
	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isCheckedVal;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objectToCall;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string functionToCall;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material materialOff;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material materialOn;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool callbackWithObject;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string customParamStr;

	[Token(Token = "0x1700001C")]
	public bool isChecked
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1E2292C", Offset = "0x1E2292C", VA = "0x1E2292C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1E22934", Offset = "0x1E22934", VA = "0x1E22934")]
		set
		{
		}
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1E22A80", Offset = "0x1E22A80", VA = "0x1E22A80")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1E22940", Offset = "0x1E22940", VA = "0x1E22940")]
	private void changeMaterial()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x1E22AE8", Offset = "0x1E22AE8", VA = "0x1E22AE8")]
	public void changeOtherMaterial(Material m)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1E22BE8", Offset = "0x1E22BE8", VA = "0x1E22BE8")]
	private void Click()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1E22CF0", Offset = "0x1E22CF0", VA = "0x1E22CF0")]
	public void SetChecked(bool on)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1E22CFC", Offset = "0x1E22CFC", VA = "0x1E22CFC")]
	public void SetCallbackWithObject(bool on)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1E22D08", Offset = "0x1E22D08", VA = "0x1E22D08")]
	public void SetCustomParam(string param)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1E22D10", Offset = "0x1E22D10", VA = "0x1E22D10")]
	public string GetCustomParam()
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1E22D18", Offset = "0x1E22D18", VA = "0x1E22D18")]
	public CloudSave_Checkbox()
	{
	}
}
[Token(Token = "0x200003A")]
public class CloudSave_InfoMessage : MonoBehaviour
{
	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh text;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color textColorInfo;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color textColorWarning;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject warningIcon;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isWarning;

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1E276A0", Offset = "0x1E276A0", VA = "0x1E276A0")]
	public void ShowText(string txt, bool warning)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1E25E70", Offset = "0x1E25E70", VA = "0x1E25E70")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1E27844", Offset = "0x1E27844", VA = "0x1E27844")]
	public bool IsWarning()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1E2784C", Offset = "0x1E2784C", VA = "0x1E2784C")]
	public CloudSave_InfoMessage()
	{
	}
}
[Token(Token = "0x200003B")]
public interface IMUIHoverable
{
	[Token(Token = "0x60001CE")]
	void OnHover(Vector3 worldPos);

	[Token(Token = "0x60001CF")]
	void OnMove(Vector3 worldPos);

	[Token(Token = "0x60001D0")]
	void OnLeave();
}
[Token(Token = "0x200003C")]
public class MUI_Button : MonoBehaviour
{
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x2543420", Offset = "0x2543420", VA = "0x2543420")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x25434F8", Offset = "0x25434F8", VA = "0x25434F8")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x2543790", Offset = "0x2543790", VA = "0x2543790")]
	public MUI_Button()
	{
	}
}
[Token(Token = "0x200003D")]
public class MUI_ClippedScroll : MonoBehaviour
{
	[Token(Token = "0x200003E")]
	protected class BoxColliderInfo
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BoxCollider box;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 center;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 size;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Bounds bounds;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x26B5534", Offset = "0x26B5534", VA = "0x26B5534")]
		public BoxColliderInfo()
		{
		}
	}

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 scrollSize;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool useBoundary;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject container;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject scrollbarVert;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject scrollbarHorz;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject clipBkgToScreen;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool resetScrollPositionOnEnable;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool autoAdjustToContents;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float clipScreenBottomMargin;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] ignoreCollidersOfSubobjects;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject dragArea;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected bool changedContents;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected Bounds clipArea;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Bounds scrollMargin;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	protected Vector3 scrollbarVert_scale;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Vector3 scrollbarHorz_scale;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected List<BoxColliderInfo> boxCollidersOrgSize;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected List<GameObject> clippedOutColChilds;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected List<GameObject> clippedOutRendChilds;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected List<GameObject> ignoredNotClippedChilds;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected bool scrollbarVertDown;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	protected bool scrollbarHorzDown;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
	protected bool dragScrollbarVert;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD3")]
	protected bool dragScrollbarHorz;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	protected bool dragging;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	protected bool keepMinOrgScrollSize;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected Vector2 scrollSizeOrg;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected float clipBkgOrgSizeY;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	protected bool doClipBkgToScreen;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	protected int lastScreenSizeChecksum;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	protected bool autoAdjustToContentsAfterChanges;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
	protected bool setAutoAdjustToContents;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
	protected bool keepProportionalContainerSizeAfterChanges;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
	protected bool resetScrollPos;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected bool freezeScroll;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	protected Vector2 scrollToAfterContentsChanged;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	protected bool extendHorzSizeToScreen;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected GameObject zoomRootObject;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected float zoomMin;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	protected float zoomMax;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected float zoomSpeed;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static List<MUI_ClippedScroll> enabledScrolls;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static MUI_ClippedScroll_Materials clippedMaterials;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Func<GameObject, bool> callbackHaveOpenComboBoxChild;

	[Token(Token = "0x400015B")]
	private const float minScrollbarSize = 0.2f;

	[Token(Token = "0x400015C")]
	private const float mouseWheelSpeed = 2f;

	[Token(Token = "0x400015D")]
	private const float boundsMarginX = 0.1f;

	[Token(Token = "0x400015E")]
	private const float boundsMarginY = 0.1f;

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x2543798", Offset = "0x2543798", VA = "0x2543798")]
	public static void UpdateMaterialsForObjectsWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2543B68", Offset = "0x2543B68", VA = "0x2543B68")]
	public static void UpdateMaterialForObjectWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2543DEC", Offset = "0x2543DEC", VA = "0x2543DEC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2544358", Offset = "0x2544358", VA = "0x2544358")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x25443F8", Offset = "0x25443F8", VA = "0x25443F8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2544584", Offset = "0x2544584", VA = "0x2544584")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2544600", Offset = "0x2544600", VA = "0x2544600")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2544770", Offset = "0x2544770", VA = "0x2544770")]
	private Vector2 Scale()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x25447E8", Offset = "0x25447E8", VA = "0x25447E8")]
	public static Vector2 Scale(GameObject go, bool inclSelfScale)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x25448DC", Offset = "0x25448DC", VA = "0x25448DC")]
	public void ContentsChanged()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x25448F4", Offset = "0x25448F4", VA = "0x25448F4")]
	public void SetKeepMinOrgScrollSize(bool s)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x2544344", Offset = "0x2544344", VA = "0x2544344")]
	public void AutoAdjustToContents(bool adjustAfterChanges = true)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2544900", Offset = "0x2544900", VA = "0x2544900")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x2544D10", Offset = "0x2544D10", VA = "0x2544D10")]
	public void FreezeScroll(bool freeze)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x2544D1C", Offset = "0x2544D1C", VA = "0x2544D1C")]
	public bool HaveClippedContents()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2544D78", Offset = "0x2544D78", VA = "0x2544D78")]
	public bool HaveClippedContentsX()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2544DA4", Offset = "0x2544DA4", VA = "0x2544DA4")]
	public bool HaveClippedContentsY()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2544DD0", Offset = "0x2544DD0", VA = "0x2544DD0")]
	public bool IsScreenPointInBounds(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2544F6C", Offset = "0x2544F6C", VA = "0x2544F6C")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2545070", Offset = "0x2545070", VA = "0x2545070")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2545120", Offset = "0x2545120", VA = "0x2545120")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x254517C", Offset = "0x254517C", VA = "0x254517C")]
	public void ScrollToTop()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x25451DC", Offset = "0x25451DC", VA = "0x25451DC")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x254523C", Offset = "0x254523C", VA = "0x254523C")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x25452A4", Offset = "0x25452A4", VA = "0x25452A4")]
	public bool IsScrolledToY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x2545318", Offset = "0x2545318", VA = "0x2545318")]
	public bool IsInsideClipAreaY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x2545380", Offset = "0x2545380", VA = "0x2545380")]
	public bool IsDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x2545388", Offset = "0x2545388", VA = "0x2545388")]
	public void EnsureVisible(Vector3 pos)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x2545570", Offset = "0x2545570", VA = "0x2545570")]
	public bool IsClippedOutColChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x2545678", Offset = "0x2545678", VA = "0x2545678")]
	public bool IsClippedOutRendChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x2545780", Offset = "0x2545780", VA = "0x2545780")]
	public void AddIgnoredNotClippedChild(GameObject go)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x25457E4", Offset = "0x25457E4", VA = "0x25457E4")]
	private bool IsIgnoredNotClippedChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x25458D4", Offset = "0x25458D4", VA = "0x25458D4")]
	public void SetExtendHorzSizeToScreen()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x25458E0", Offset = "0x25458E0", VA = "0x25458E0")]
	public void SetZoomContents(GameObject rootObj, float min, float max, float speed)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x25458F4", Offset = "0x25458F4", VA = "0x25458F4")]
	public bool HaveZoomContents()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x2545960", Offset = "0x2545960", VA = "0x2545960")]
	public static MUI_ClippedScroll GetActiveScroll(Vector2 atPoint)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x2545B24", Offset = "0x2545B24", VA = "0x2545B24")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x2546D28", Offset = "0x2546D28", VA = "0x2546D28")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x25473E4", Offset = "0x25473E4", VA = "0x25473E4")]
	private void ClipBkgToScreen()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x2545EE4", Offset = "0x2545EE4", VA = "0x2545EE4")]
	private void AdjustHorzSizeToScreen()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x2546FF4", Offset = "0x2546FF4", VA = "0x2546FF4")]
	private void AdjustScrollSizeToContents()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x2548170", Offset = "0x2548170", VA = "0x2548170")]
	private void UpdateMaterials(GameObject go, ref Bounds mergedBounds)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x2548E38", Offset = "0x2548E38", VA = "0x2548E38")]
	private BoxColliderInfo GetBoxColliderOrgSize(BoxCollider box, Vector2 scale)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x2549158", Offset = "0x2549158", VA = "0x2549158")]
	private void UpdateBounds(GameObject go)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x254558C", Offset = "0x254558C", VA = "0x254558C")]
	private int GetClippedOutColChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x2545694", Offset = "0x2545694", VA = "0x2545694")]
	private int GetClippedOutRendChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x2547A40", Offset = "0x2547A40", VA = "0x2547A40")]
	private void UpdateAfterChanged()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x25449A0", Offset = "0x25449A0", VA = "0x25449A0")]
	private void UpdateScroll()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x2544F70", Offset = "0x2544F70", VA = "0x2544F70")]
	private void Scroll(float x, float y)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x2549E1C", Offset = "0x2549E1C", VA = "0x2549E1C")]
	private Vector2 ScreenPointToWorldPos(Vector2 p)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x2544E00", Offset = "0x2544E00", VA = "0x2544E00")]
	private bool IsScreenPointInClipArea(Vector3 p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x254A090", Offset = "0x254A090", VA = "0x254A090")]
	public void OnScrollBarDown(MUI_ClippedScroll_Bar bar, bool down)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x2546218", Offset = "0x2546218", VA = "0x2546218")]
	private void StepDrag()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x2546904", Offset = "0x2546904", VA = "0x2546904")]
	private void StepScrollMouseWheel()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x2546B3C", Offset = "0x2546B3C", VA = "0x2546B3C")]
	private void StepZoom()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x254A1E8", Offset = "0x254A1E8", VA = "0x254A1E8")]
	public bool HaveOpenComboBoxChild()
	{
		return default(bool);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x254A2D0", Offset = "0x254A2D0", VA = "0x254A2D0")]
	public MUI_ClippedScroll()
	{
	}
}
[Token(Token = "0x200003F")]
public class MUI_ClippedScroll_Bar : MonoBehaviour
{
	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected MUI_ClippedScroll scroller;

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x254A464", Offset = "0x254A464", VA = "0x254A464")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x254A4C8", Offset = "0x254A4C8", VA = "0x254A4C8")]
	public void Down()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x254A558", Offset = "0x254A558", VA = "0x254A558")]
	public void Up()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x254A5E8", Offset = "0x254A5E8", VA = "0x254A5E8")]
	public void Click()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x254A678", Offset = "0x254A678", VA = "0x254A678")]
	public MUI_ClippedScroll_Bar()
	{
	}
}
[Serializable]
[Token(Token = "0x2000040")]
public class ClippedMaterialPair
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material materialOrg;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material materialClipped;

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1E22858", Offset = "0x1E22858", VA = "0x1E22858")]
	public ClippedMaterialPair()
	{
	}
}
[Serializable]
[Token(Token = "0x2000041")]
public class ClippedFontMaterialPair
{
	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Font font;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material materialClipped;

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1E22850", Offset = "0x1E22850", VA = "0x1E22850")]
	public ClippedFontMaterialPair()
	{
	}
}
[Token(Token = "0x2000042")]
public class MUI_ClippedScroll_Materials : MonoBehaviour
{
	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ClippedMaterialPair[] materials;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ClippedFontMaterialPair[] fonts;

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x254A680", Offset = "0x254A680", VA = "0x254A680")]
	public MUI_ClippedScroll_Materials()
	{
	}
}
[Token(Token = "0x2000043")]
public class MUI_Continous : MonoBehaviour
{
	[Token(Token = "0x6000217")]
	[Address(RVA = "0x254A688", Offset = "0x254A688", VA = "0x254A688")]
	private void Update()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x254A750", Offset = "0x254A750", VA = "0x254A750")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x254A9E8", Offset = "0x254A9E8", VA = "0x254A9E8")]
	public MUI_Continous()
	{
	}
}
[Token(Token = "0x2000044")]
public class BoolRef
{
	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool val;

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1E208CC", Offset = "0x1E208CC", VA = "0x1E208CC")]
	public BoolRef()
	{
	}
}
[Token(Token = "0x2000045")]
public class MUI_Input : MonoBehaviour
{
	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static KeyCode backKeyCode;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static MUI_Input instance;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool drag;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static Vector2 dragStart;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static Vector2 vDrag;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static bool zoom;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Vector2 zoomCenter;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static float zoomVal;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static Vector3 hitPointMUI;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static float lastMUIClickTimeUnscaled;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public static Vector3 hitPoint;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static GameObject hitObject;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static LayerMask layerMask;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Camera pCamera;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static bool lastUpdateClickDown;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public static bool moveSlider;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	private static bool moveScrollbar;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private static LayerMask MUIlayerMask;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 tapPos;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static GameObject MUIObject;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool tap;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static int blockZoom;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int dragTreshold;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string[] initLayers;

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x254A9F0", Offset = "0x254A9F0", VA = "0x254A9F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x254AA58", Offset = "0x254AA58", VA = "0x254AA58")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x254AB30", Offset = "0x254AB30", VA = "0x254AB30")]
	private void Start()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x254AE98", Offset = "0x254AE98", VA = "0x254AE98")]
	public static LayerMask GetMUIlayerMask()
	{
		return default(LayerMask);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x254AEFC", Offset = "0x254AEFC", VA = "0x254AEFC")]
	public static Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x254AF60", Offset = "0x254AF60", VA = "0x254AF60")]
	public static void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x254AFC8", Offset = "0x254AFC8", VA = "0x254AFC8")]
	public static void ClearLayerMask()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x254B040", Offset = "0x254B040", VA = "0x254B040")]
	public static bool WasNowClickDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x254AD8C", Offset = "0x254AD8C", VA = "0x254AD8C")]
	public static void AddLayer(string layer)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x254B0A4", Offset = "0x254B0A4", VA = "0x254B0A4")]
	public static void RemoveLayer(string layer)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x254B214", Offset = "0x254B214", VA = "0x254B214")]
	public static bool IsDraggingItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x254B378", Offset = "0x254B378", VA = "0x254B378")]
	private void Zoom()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x254B904", Offset = "0x254B904", VA = "0x254B904")]
	private void Drag()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x254C1D4", Offset = "0x254C1D4", VA = "0x254C1D4")]
	private bool IsChildOfActiveScroll(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x254C2C8", Offset = "0x254C2C8", VA = "0x254C2C8")]
	private bool FingerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x254C3C4", Offset = "0x254C3C4", VA = "0x254C3C4")]
	private bool FingerUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x254C4AC", Offset = "0x254C4AC", VA = "0x254C4AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x254C754", Offset = "0x254C754", VA = "0x254C754")]
	private void CastRay(bool down, bool up, bool move)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x254CE94", Offset = "0x254CE94", VA = "0x254CE94")]
	public MUI_Input()
	{
	}
}
[Token(Token = "0x2000046")]
public class ClipboardHelper
{
	[Token(Token = "0x1700001D")]
	public static string clipBoard
	{
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1E22838", Offset = "0x1E22838", VA = "0x1E22838")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1E22840", Offset = "0x1E22840", VA = "0x1E22840")]
		set
		{
		}
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1E22848", Offset = "0x1E22848", VA = "0x1E22848")]
	public ClipboardHelper()
	{
	}
}
[Token(Token = "0x2000047")]
public class MUI_InputText : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32610", Offset = "0xA32610")]
	private sealed class <ReadKbdInputCoroutine>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MUI_InputText <>4__this;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int initCursorPos;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <oldText>5__2;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <stop>5__3;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <prevBefore>5__4;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <prevAfter>5__5;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MUI_InputText <nextInput>5__6;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x26B65C4", Offset = "0x26B65C4", VA = "0x26B65C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x26B660C", Offset = "0x26B660C", VA = "0x26B660C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x26B553C", Offset = "0x26B553C", VA = "0x26B553C")]
		[DebuggerHidden]
		public <ReadKbdInputCoroutine>d__66(int <>1__state)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x26B5568", Offset = "0x26B5568", VA = "0x26B5568", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x26B556C", Offset = "0x26B556C", VA = "0x26B556C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x26B65CC", Offset = "0x26B65CC", VA = "0x26B65CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Func<string, string> Trl_Translate;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh textMesh;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh emptyTextTip;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool onlySoftwareKeyboard;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool emailInput;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool passwordInput;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool hideTouchScreenKbdInput;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string touchScreenKbdPlaceholderText;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Renderer tmr;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected MUI_ScreenKeyboard screenKeyboardOwner;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool allowInputInScreenKeyboard;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected string screenKeyboardInput;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected float cursorBlinkOnTime;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected float cursorBlinkOffTime;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected float scrollSpeed;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected string textVal;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected string textBeforeCursor;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected string textAfterCursor;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected bool initialized;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected int initializeDelay;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected bool selected;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	protected int updatesSinceClick;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected TouchScreenKeyboard touchKeyboard;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected float textMeshFieldWidth;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected TextMesh textMeshCursor;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected float cursorSize;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected Hashtable dictCharWidth;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected float cursorSetBlinkTime;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	protected float lastScrollKeyTime;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected int firstVisibleTextIndex;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	protected float setClickCursorPos;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected float showTime;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	protected bool isDisabling;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static MUI_InputText currentInputOwner;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool isOpenedSystemKeyboard;

	[Token(Token = "0x1700001E")]
	public string text
	{
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x254CF70", Offset = "0x254CF70", VA = "0x254CF70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x254CF78", Offset = "0x254CF78", VA = "0x254CF78")]
		set
		{
		}
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x254D560", Offset = "0x254D560", VA = "0x254D560")]
	public static bool IsOpenedSystemKeyboard()
	{
		return default(bool);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x254D5C4", Offset = "0x254D5C4", VA = "0x254D5C4")]
	public static bool IsCurrentInputActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x254D664", Offset = "0x254D664", VA = "0x254D664")]
	public void SetIsInputOfScreenKeyboard(MUI_ScreenKeyboard owner)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x254D66C", Offset = "0x254D66C", VA = "0x254D66C")]
	public void SetAllowInputInScreenKeyboard()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x254D678", Offset = "0x254D678", VA = "0x254D678")]
	public void AddScreenKeyboardInput(char c)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x254D768", Offset = "0x254D768", VA = "0x254D768")]
	public void SetKeyboardInputActive(bool active)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x254D8B4", Offset = "0x254D8B4", VA = "0x254D8B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x254DA60", Offset = "0x254DA60", VA = "0x254DA60")]
	private void Start()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x254DB04", Offset = "0x254DB04", VA = "0x254DB04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x254DB2C", Offset = "0x254DB2C", VA = "0x254DB2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x254DD78", Offset = "0x254DD78", VA = "0x254DD78")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x254DF38", Offset = "0x254DF38", VA = "0x254DF38")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x254DF64", Offset = "0x254DF64", VA = "0x254DF64")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x254DF68", Offset = "0x254DF68", VA = "0x254DF68")]
	private void Down()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x254DF70", Offset = "0x254DF70", VA = "0x254DF70")]
	protected MUI_Show_ScreenKeyboard GetShowKbdComponent(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x254E29C", Offset = "0x254E29C", VA = "0x254E29C")]
	private void ControllerClick()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x254D784", Offset = "0x254D784", VA = "0x254D784")]
	private void Click()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x254E2A4", Offset = "0x254E2A4", VA = "0x254E2A4")]
	private void DoClick(bool fromController)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x254D78C", Offset = "0x254D78C", VA = "0x254D78C")]
	protected void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x254E624", Offset = "0x254E624", VA = "0x254E624")]
	protected string GetPastedClipboardText()
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x254E688", Offset = "0x254E688", VA = "0x254E688")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x254E690", Offset = "0x254E690", VA = "0x254E690")]
	public void UpdateText()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x254CF90", Offset = "0x254CF90", VA = "0x254CF90")]
	public void SetText(string _t, int cursorPos)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x254EA90", Offset = "0x254EA90", VA = "0x254EA90")]
	private void SetTextMesh(string txt)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x254E6D4", Offset = "0x254E6D4", VA = "0x254E6D4")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x254E9E0", Offset = "0x254E9E0", VA = "0x254E9E0")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x254EB60", Offset = "0x254EB60", VA = "0x254EB60")]
	protected void CreateCursor()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x254E564", Offset = "0x254E564", VA = "0x254E564")]
	protected void DestroyCursor()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x254E4E8", Offset = "0x254E4E8", VA = "0x254E4E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA34BCC", Offset = "0xA34BCC")]
	private IEnumerator ReadKbdInputCoroutine(int initCursorPos)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x254EE94", Offset = "0x254EE94", VA = "0x254EE94")]
	protected MUI_InputText FindNextInputText()
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x254F1E8", Offset = "0x254F1E8", VA = "0x254F1E8")]
	public MUI_InputText()
	{
	}
}
[Token(Token = "0x2000049")]
public class MUI_Screen
{
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static bool wasLandscape;

	[Token(Token = "0x17000021")]
	public static int width
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2545C84", Offset = "0x2545C84", VA = "0x2545C84")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000022")]
	public static int height
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2545DB4", Offset = "0x2545DB4", VA = "0x2545DB4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x254F2A8", Offset = "0x254F2A8", VA = "0x254F2A8")]
	public MUI_Screen()
	{
	}
}
[Token(Token = "0x200004A")]
public class MUI_ScreenKeyboard : MonoBehaviour
{
	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static char[] baseKeys;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static char[] shiftKeys;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static char[] sym1Keys;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected static char[] sym2Keys;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh inputLabel;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText inputText;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] hideShowWindows;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool errorMissingButtons;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MUI_InputText fillInput;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected GameObject hideScreen;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool shiftMode;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected int symMode;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected TextMesh[] textKeys;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected TextMesh textSHIFT;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject iconSHIFT;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected TextMesh textSYMBOLS;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected bool initialized;

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x254F2B4", Offset = "0x254F2B4", VA = "0x254F2B4", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x254F2B8", Offset = "0x254F2B8", VA = "0x254F2B8", Slot = "5")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x254F2BC", Offset = "0x254F2BC", VA = "0x254F2BC")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x254FEA0", Offset = "0x254FEA0", VA = "0x254FEA0", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x254FEA4", Offset = "0x254FEA4", VA = "0x254FEA4")]
	public void Show(MUI_InputText _fillInput, string label, GameObject _hideScreen)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x2550054", Offset = "0x2550054", VA = "0x2550054")]
	public void CancelKeyboard()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x25500B0", Offset = "0x25500B0", VA = "0x25500B0", Slot = "7")]
	public virtual void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x25502C8", Offset = "0x25502C8", VA = "0x25502C8", Slot = "8")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x2550374", Offset = "0x2550374", VA = "0x2550374", Slot = "9")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x2550460", Offset = "0x2550460", VA = "0x2550460", Slot = "10")]
	public virtual void OnInputEnter()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x25504AC", Offset = "0x25504AC", VA = "0x25504AC")]
	public void OnKeyPressed(string skey)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x2550958", Offset = "0x2550958", VA = "0x2550958")]
	protected GameObject FindObject(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x2550710", Offset = "0x2550710", VA = "0x2550710")]
	protected int FindKeyIndex(string skey)
	{
		return default(int);
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x254F3B4", Offset = "0x254F3B4", VA = "0x254F3B4")]
	protected void InitTextKeys()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x2550818", Offset = "0x2550818", VA = "0x2550818")]
	protected char GetCurrentKey(int i)
	{
		return default(char);
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x254FB54", Offset = "0x254FB54", VA = "0x254FB54")]
	protected void FillTextKeys()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x25501DC", Offset = "0x25501DC", VA = "0x25501DC")]
	protected string TrimEndLineCharacters(string text)
	{
		return null;
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x2550CC4", Offset = "0x2550CC4", VA = "0x2550CC4")]
	public MUI_ScreenKeyboard()
	{
	}
}
[Token(Token = "0x200004B")]
public class MUI_Scroll : MonoBehaviour
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 size;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 startOffset;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autoCalcSize;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool resetOnDisable;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool scaleSpeed;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool useBoundary;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector4 boundary;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject titleBarOver;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject excludeFromAutoCalcSize;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 orgPos;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 orgSize;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 center;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 pos;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector2 sizeMin;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2 sizeMax;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool initialized;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	private bool started;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	private bool thisScrollingInBoundary;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
	private bool doAutoCalcSize;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int lastAutoCalcChecksum;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool activeScrollSet;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int activeScrollsCnt;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static bool scrollingInBoundary;

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x2550E20", Offset = "0x2550E20", VA = "0x2550E20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x2550E24", Offset = "0x2550E24", VA = "0x2550E24")]
	private void DoInit()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x2550EA4", Offset = "0x2550EA4", VA = "0x2550EA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x2550F90", Offset = "0x2550F90", VA = "0x2550F90")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x2551028", Offset = "0x2551028", VA = "0x2551028")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x254C168", Offset = "0x254C168", VA = "0x254C168")]
	public static bool IsAnyScrollActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x2551168", Offset = "0x2551168", VA = "0x2551168")]
	public static bool IsAnyScrollingInBoundary()
	{
		return default(bool);
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x25511CC", Offset = "0x25511CC", VA = "0x25511CC")]
	public void ResetOrgPos(Vector3 org)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x25511D8", Offset = "0x25511D8", VA = "0x25511D8")]
	public void SetSizeMinY(float y)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x25511E0", Offset = "0x25511E0", VA = "0x25511E0")]
	public void SetSize(Vector2 _size)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x255122C", Offset = "0x255122C", VA = "0x255122C")]
	public void SetOffset(Vector2 _offset)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2550EE8", Offset = "0x2550EE8", VA = "0x2550EE8")]
	public void ResetScroll()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2551370", Offset = "0x2551370", VA = "0x2551370")]
	public void AutoCalculateSize()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2551BDC", Offset = "0x2551BDC", VA = "0x2551BDC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x2551C48", Offset = "0x2551C48", VA = "0x2551C48")]
	private void Update()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x2552154", Offset = "0x2552154", VA = "0x2552154")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2552180", Offset = "0x2552180", VA = "0x2552180")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x25521F8", Offset = "0x25521F8", VA = "0x25521F8")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x2552270", Offset = "0x2552270", VA = "0x2552270")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2552318", Offset = "0x2552318", VA = "0x2552318")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x2552378", Offset = "0x2552378", VA = "0x2552378")]
	public bool IsAllOnScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x255126C", Offset = "0x255126C", VA = "0x255126C")]
	public void Clamp()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x25523A8", Offset = "0x25523A8", VA = "0x25523A8")]
	public void UpdateZoom()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2551B40", Offset = "0x2551B40", VA = "0x2551B40")]
	public static Vector2 GetFrustrumSizeAt(Camera cam)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x2552408", Offset = "0x2552408", VA = "0x2552408")]
	public void EnsureVisible(Vector3 point)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x2552814", Offset = "0x2552814", VA = "0x2552814")]
	public MUI_Scroll()
	{
	}
}
[Token(Token = "0x200004C")]
public class MUI_Show_ScreenKeyboard : MonoBehaviour
{
	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MUI_ScreenKeyboard keyboard;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText inputField;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string inputLabel;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject hideScreen;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject clickCallbackObject;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string clickCallbackFunc;

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x211603C", Offset = "0x211603C", VA = "0x211603C")]
	public void Click()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x2116224", Offset = "0x2116224", VA = "0x2116224")]
	public MUI_Show_ScreenKeyboard()
	{
	}
}
[Token(Token = "0x200004D")]
public class MUI_Slider : MonoBehaviour
{
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform square;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public eSlider val;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float margin;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected bool isCustom;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected float customVal;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Action<MUI_Slider, float> valChangedCallback;

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x2116278", Offset = "0x2116278", VA = "0x2116278")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x21162A0", Offset = "0x21162A0", VA = "0x21162A0")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x2116330", Offset = "0x2116330", VA = "0x2116330")]
	public void SetValChangedCallback(Action<MUI_Slider, float> callback)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x2116338", Offset = "0x2116338", VA = "0x2116338")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x2116340", Offset = "0x2116340", VA = "0x2116340")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x2116384", Offset = "0x2116384", VA = "0x2116384")]
	public float GetVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x211650C", Offset = "0x211650C", VA = "0x211650C")]
	public void SetVal(float v)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x211666C", Offset = "0x211666C", VA = "0x211666C")]
	public void SetGraphVal(float v)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x21162B0", Offset = "0x21162B0", VA = "0x21162B0")]
	private void UpdateSquarePos()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x21166C0", Offset = "0x21166C0", VA = "0x21166C0")]
	private void UpdateSquarePos(float v)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x211672C", Offset = "0x211672C", VA = "0x211672C")]
	private void Down()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x21168B8", Offset = "0x21168B8", VA = "0x21168B8")]
	private void Click()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x21168BC", Offset = "0x21168BC", VA = "0x21168BC")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x2116730", Offset = "0x2116730", VA = "0x2116730")]
	private void Process()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x21168C0", Offset = "0x21168C0", VA = "0x21168C0")]
	public MUI_Slider()
	{
	}
}
[Token(Token = "0x200004E")]
public class MUI_SliderVertical : MonoBehaviour
{
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform square;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public eSlider val;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float margin;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject objectToCall;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string functionToCall;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool update;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	protected bool isCustom;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected float customVal;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Action<MUI_SliderVertical, float, float> valChangedCallback;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float newVal;

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x21168D4", Offset = "0x21168D4", VA = "0x21168D4")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x21169CC", Offset = "0x21169CC", VA = "0x21169CC")]
	public void SetValChangedCallback(Action<MUI_SliderVertical, float, float> callback)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x21169D4", Offset = "0x21169D4", VA = "0x21169D4")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x21169DC", Offset = "0x21169DC", VA = "0x21169DC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2116A20", Offset = "0x2116A20", VA = "0x2116A20")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x21168E4", Offset = "0x21168E4", VA = "0x21168E4")]
	public void UpdateSquarePos()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x2116D0C", Offset = "0x2116D0C", VA = "0x2116D0C")]
	private void Down()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x2116D10", Offset = "0x2116D10", VA = "0x2116D10")]
	private void Click()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2116D14", Offset = "0x2116D14", VA = "0x2116D14")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x2116AB0", Offset = "0x2116AB0", VA = "0x2116AB0")]
	private void Process()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x2116D18", Offset = "0x2116D18", VA = "0x2116D18")]
	public MUI_SliderVertical()
	{
	}
}
[Token(Token = "0x200004F")]
public class MUI_Sound : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000050")]
	public class SoundParameters
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UISfx sfx;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float volume;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float pitch;

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x26B6614", Offset = "0x26B6614", VA = "0x26B6614")]
		public SoundParameters()
		{
		}
	}

	[Token(Token = "0x2000051")]
	public enum UISfx
	{
		[Token(Token = "0x40001F7")]
		None = -1,
		[Token(Token = "0x40001F8")]
		DefaultClick,
		[Token(Token = "0x40001F9")]
		PlaneUpgrade,
		[Token(Token = "0x40001FA")]
		Victory_unused,
		[Token(Token = "0x40001FB")]
		PlanePurchase,
		[Token(Token = "0x40001FC")]
		CloudClick,
		[Token(Token = "0x40001FD")]
		MenuCursorHover,
		[Token(Token = "0x40001FE")]
		MenuClick,
		[Token(Token = "0x40001FF")]
		MenuAnimation,
		[Token(Token = "0x4000200")]
		UnlockedRankPopup
	}

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SoundParameters[] soundParam;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource[] sources;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MUI_Sound instance;

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x2116D2C", Offset = "0x2116D2C", VA = "0x2116D2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x211710C", Offset = "0x211710C", VA = "0x211710C")]
	private static void FindInstance()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x2117204", Offset = "0x2117204", VA = "0x2117204")]
	public static void Play(UISfx sfx, [Optional] GameObject at)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x2117588", Offset = "0x2117588", VA = "0x2117588")]
	public AudioSource FindFreeSource()
	{
		return null;
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x21172FC", Offset = "0x21172FC", VA = "0x21172FC")]
	private void PlayClip(UISfx sfx, GameObject at)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x2117734", Offset = "0x2117734", VA = "0x2117734")]
	public MUI_Sound()
	{
	}
}
[Token(Token = "0x2000052")]
public class MUI_click_Effect : MonoBehaviour
{
	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 offset;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 offset2;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 scaleMul;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material material;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material materialDisabled;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MUI_Sound.UISfx SoundNumDown;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public MUI_Sound.UISfx SoundNumUp;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MUI_Sound.UISfx SoundNumClick;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 orgPos;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 orgScale;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Material orgMaterial;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool down;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool disabled;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Renderer r;

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x2117740", Offset = "0x2117740", VA = "0x2117740")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x211792C", Offset = "0x211792C", VA = "0x211792C")]
	private void Down()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x2117BC8", Offset = "0x2117BC8", VA = "0x2117BC8")]
	private void Up()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x2117D90", Offset = "0x2117D90", VA = "0x2117D90")]
	private void Click()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x2117E0C", Offset = "0x2117E0C", VA = "0x2117E0C")]
	private void IsDown(BoolRef isDown)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x2117E28", Offset = "0x2117E28", VA = "0x2117E28")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x2117E38", Offset = "0x2117E38", VA = "0x2117E38")]
	public bool IsDisabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x2117E40", Offset = "0x2117E40", VA = "0x2117E40")]
	public void Disable()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x211806C", Offset = "0x211806C", VA = "0x211806C")]
	public void Enable()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x211826C", Offset = "0x211826C", VA = "0x211826C")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x2118278", Offset = "0x2118278", VA = "0x2118278")]
	public void SetDisabled(bool disabled)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x2118284", Offset = "0x2118284", VA = "0x2118284")]
	public MUI_click_Effect()
	{
	}
}
[Token(Token = "0x2000053")]
public class MUI_cut_TextArea : MonoBehaviour
{
	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float W;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string cutSuffix;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected TextMesh textMesh;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Hashtable dictCharWidth;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 scaleOrg;

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x21182BC", Offset = "0x21182BC", VA = "0x21182BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x2118334", Offset = "0x2118334", VA = "0x2118334")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x211866C", Offset = "0x211866C", VA = "0x211866C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x2118670", Offset = "0x2118670", VA = "0x2118670")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x2118338", Offset = "0x2118338", VA = "0x2118338")]
	public void Calculate()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x2118AC4", Offset = "0x2118AC4", VA = "0x2118AC4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x2118798", Offset = "0x2118798", VA = "0x2118798")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x2118674", Offset = "0x2118674", VA = "0x2118674")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x2118DC4", Offset = "0x2118DC4", VA = "0x2118DC4")]
	public MUI_cut_TextArea()
	{
	}
}
[Token(Token = "0x2000054")]
public enum eCheck
{
	[Token(Token = "0x4000215")]
	unused1,
	[Token(Token = "0x4000216")]
	friendsOnRadar,
	[Token(Token = "0x4000217")]
	useJoystickVibration,
	[Token(Token = "0x4000218")]
	unused2,
	[Token(Token = "0x4000219")]
	translateCommunityTexts,
	[Token(Token = "0x400021A")]
	steeringRightHand,
	[Token(Token = "0x400021B")]
	unused3,
	[Token(Token = "0x400021C")]
	switchThumbsticks,
	[Token(Token = "0x400021D")]
	showPlayerNames,
	[Token(Token = "0x400021E")]
	netUseVoiceTransmission,
	[Token(Token = "0x400021F")]
	stickyGrip,
	[Token(Token = "0x4000220")]
	bhaptics,
	[Token(Token = "0x4000221")]
	num
}
[Token(Token = "0x2000055")]
public enum eSlider
{
	[Token(Token = "0x4000223")]
	volumeRadio,
	[Token(Token = "0x4000224")]
	volumeBattle,
	[Token(Token = "0x4000225")]
	volumeMusic,
	[Token(Token = "0x4000226")]
	volumeInterface,
	[Token(Token = "0x4000227")]
	comfortMode,
	[Token(Token = "0x4000228")]
	playerNameSize,
	[Token(Token = "0x4000229")]
	dynamicComfortMode,
	[Token(Token = "0x400022A")]
	volumeMultiplayerVoice,
	[Token(Token = "0x400022B")]
	seatHeight,
	[Token(Token = "0x400022C")]
	seatArmLength,
	[Token(Token = "0x400022D")]
	num
}
[Token(Token = "0x2000056")]
public enum eCheckNotSaved
{
	[Token(Token = "0x400022F")]
	none,
	[Token(Token = "0x4000230")]
	freeCamera,
	[Token(Token = "0x4000231")]
	num
}
[Token(Token = "0x2000057")]
public class MUI_data : MonoBehaviour
{
	[Token(Token = "0x2000058")]
	public delegate void Loaded();

	[Token(Token = "0x2000059")]
	public delegate void StateChanged(eCheck state, bool val);

	[Token(Token = "0x4000232")]
	public const float volumeRadioMultiplier = 1f;

	[Token(Token = "0x4000233")]
	public const float volumeBattleMultiplier = 1f;

	[Token(Token = "0x4000234")]
	public const float volumeMusicMultiplier = 1f;

	[Token(Token = "0x4000235")]
	public const float volumeInterfaceMultiplier = 1f;

	[Token(Token = "0x4000236")]
	public const float volumeMultiplayerVoiceDefault = 0.5f;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Loaded OnLoaded;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static StateChanged OnStateChange;

	[Token(Token = "0x4000239")]
	private const int countB = 12;

	[Token(Token = "0x400023A")]
	private const int countF = 10;

	[Token(Token = "0x400023B")]
	private const string saveKey = "MUI_data_2";

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool[] statesB;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static bool[] hadState;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static float[] statesF;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static float scale;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static bool lineBreakCH;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public static bool ready;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public static bool defaultStickyGrip;

	[Token(Token = "0x4000243")]
	private const int countNS = 2;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static bool[] statesNS;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x2118E50", Offset = "0x2118E50", VA = "0x2118E50")]
	public static void Init()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x2118EBC", Offset = "0x2118EBC", VA = "0x2118EBC")]
	public static void InitDefaults()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x21196B8", Offset = "0x21196B8", VA = "0x21196B8")]
	public static bool HadSet(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x2119788", Offset = "0x2119788", VA = "0x2119788")]
	public static bool Get(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x2119858", Offset = "0x2119858", VA = "0x2119858")]
	public static void Set(eCheck e, bool v)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x21198C8", Offset = "0x21198C8", VA = "0x21198C8")]
	public static void Set(int i, bool v)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x21199E0", Offset = "0x21199E0", VA = "0x21199E0")]
	public static void Switch(eCheck i)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x2116404", Offset = "0x2116404", VA = "0x2116404")]
	public static float GetFloat(eSlider i, bool forSettings = false)
	{
		return default(float);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x21165B8", Offset = "0x21165B8", VA = "0x21165B8")]
	public static void SetFloat(eSlider i, float v)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x2119B28", Offset = "0x2119B28", VA = "0x2119B28")]
	public static bool GetNS(eCheckNotSaved i)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x2119BB8", Offset = "0x2119BB8", VA = "0x2119BB8")]
	public static void SetNS(int i, bool v)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x2119C60", Offset = "0x2119C60", VA = "0x2119C60")]
	public static void SwitchNS(eCheckNotSaved i)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x2119CF8", Offset = "0x2119CF8", VA = "0x2119CF8")]
	public static void Save()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x2119F14", Offset = "0x2119F14", VA = "0x2119F14")]
	public static bool CanLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x21192A8", Offset = "0x21192A8", VA = "0x21192A8")]
	public static void Load()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x2119FA8", Offset = "0x2119FA8", VA = "0x2119FA8")]
	private void Click()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x211A000", Offset = "0x211A000", VA = "0x211A000")]
	public MUI_data()
	{
	}
}
[Token(Token = "0x200005A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA32620", Offset = "0xA32620")]
public class MUI_setup_LineBreak : MonoBehaviour
{
	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float wantedWidth;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool removeLineBreaks;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool removeSingleLineBreaks;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int leaveFirstNbreaks;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool justifyLines;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int maxLines;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int textCapacity;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int wordCapacity;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool dontRemoveLineBreaks;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool cutOffLongLines;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float lastScale;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextSize ts;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool breakLine;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Renderer r;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 scaleOrg;

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x211A0F4", Offset = "0x211A0F4", VA = "0x211A0F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x211A1FC", Offset = "0x211A1FC", VA = "0x211A1FC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x211A500", Offset = "0x211A500", VA = "0x211A500")]
	private void SetWidth(float w)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x211A508", Offset = "0x211A508", VA = "0x211A508")]
	public void SetCutOffLongLines()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x211A514", Offset = "0x211A514", VA = "0x211A514")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x211A76C", Offset = "0x211A76C", VA = "0x211A76C")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x211A524", Offset = "0x211A524", VA = "0x211A524")]
	private void BreakNow()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x211A770", Offset = "0x211A770", VA = "0x211A770")]
	public static int IndexOfNth(string str, char c, int nth, int startPosition = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x211A828", Offset = "0x211A828", VA = "0x211A828")]
	public void BreakLinesFromLine(int line, float width)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x211AA28", Offset = "0x211AA28", VA = "0x211AA28")]
	public MUI_setup_LineBreak()
	{
	}
}
[Token(Token = "0x200005B")]
internal class StringBufferWrapper
{
	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly StringBuilder y;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly StringBuffer x;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly bool ub;

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x27A2BDC", Offset = "0x27A2BDC", VA = "0x27A2BDC")]
	public StringBufferWrapper(int capacity)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x27A2C90", Offset = "0x27A2C90", VA = "0x27A2C90")]
	public StringBufferWrapper()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x27A2CF8", Offset = "0x27A2CF8", VA = "0x27A2CF8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x27A2D34", Offset = "0x27A2D34", VA = "0x27A2D34")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x27A2D6C", Offset = "0x27A2D6C", VA = "0x27A2D6C")]
	public unsafe void Append(char* str, int startIdx, int count)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x27A2DB4", Offset = "0x27A2DB4", VA = "0x27A2DB4")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x27A2E18", Offset = "0x27A2E18", VA = "0x27A2E18")]
	public void Append(StringBufferWrapper sb)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x27A2E60", Offset = "0x27A2E60", VA = "0x27A2E60")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x27A2EC8", Offset = "0x27A2EC8", VA = "0x27A2EC8")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x27A2F34", Offset = "0x27A2F34", VA = "0x27A2F34")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x27A2FC0", Offset = "0x27A2FC0", VA = "0x27A2FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200005C")]
public class TextSize
{
	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<char, float> dict;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMesh textMesh;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer renderer;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private StringBufferWrapper cachedString;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StringBufferWrapper cachedWord;

	[Token(Token = "0x17000023")]
	public float width
	{
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x27A2FF4", Offset = "0x27A2FF4", VA = "0x27A2FF4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000024")]
	public float height
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x27A31DC", Offset = "0x27A31DC", VA = "0x27A31DC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x27A3234", Offset = "0x27A3234", VA = "0x27A3234")]
	public TextSize(TextMesh tm, int textCapacity = -1, int wordCapacity = -1)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x27A3340", Offset = "0x27A3340", VA = "0x27A3340")]
	private void getSpace()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x27A302C", Offset = "0x27A302C", VA = "0x27A302C")]
	private float GetTextWidth(string s)
	{
		return default(float);
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x27A34E8", Offset = "0x27A34E8", VA = "0x27A34E8")]
	private string RemoveLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x27A360C", Offset = "0x27A360C", VA = "0x27A360C")]
	private string RemoveSingleLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x27A37A8", Offset = "0x27A37A8", VA = "0x27A37A8")]
	public void FitToWidth(float wantedWidth, bool removeLineBreaks, bool removeSingleLineBreaks, int leaveFirstNbreaks, bool justifyLines, bool resetDictionary, int maxLines, bool cutOffLongLines)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x27A3FA0", Offset = "0x27A3FA0", VA = "0x27A3FA0")]
	private bool IsCHchar(char c)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x27A3AA0", Offset = "0x27A3AA0", VA = "0x27A3AA0")]
	private unsafe bool WrapLine(char* s, int startIdx, int endIdx, float w, bool justifyLine, bool cutOffLongLines)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x27A3FB0", Offset = "0x27A3FB0", VA = "0x27A3FB0")]
	private string JustifyLine(List<string> words, float wordsWidth, float w)
	{
		return null;
	}
}
[Token(Token = "0x200005D")]
public class MUI_setup_TextArea : MonoBehaviour
{
	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float W;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float H;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 scaleOrg;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int delay;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Renderer r;

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x211AA54", Offset = "0x211AA54", VA = "0x211AA54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x211AACC", Offset = "0x211AACC", VA = "0x211AACC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x211AAD8", Offset = "0x211AAD8", VA = "0x211AAD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x211AD6C", Offset = "0x211AD6C", VA = "0x211AD6C")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x211AB10", Offset = "0x211AB10", VA = "0x211AB10")]
	public void Calculate()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x211AD78", Offset = "0x211AD78", VA = "0x211AD78")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x211B07C", Offset = "0x211B07C", VA = "0x211B07C")]
	public MUI_setup_TextArea()
	{
	}
}
[Token(Token = "0x200005E")]
public class StringBuffer
{
	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly char[] data;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly int capacity;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int idx;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x27A2844", Offset = "0x27A2844", VA = "0x27A2844")]
	public StringBuffer(int capacity)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x27A28B8", Offset = "0x27A28B8", VA = "0x27A28B8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x27A28C0", Offset = "0x27A28C0", VA = "0x27A28C0")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x27A294C", Offset = "0x27A294C", VA = "0x27A294C")]
	public unsafe void Append(char* str, int count)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x27A29BC", Offset = "0x27A29BC", VA = "0x27A29BC")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x27A29EC", Offset = "0x27A29EC", VA = "0x27A29EC")]
	public void Append(StringBuffer sb)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x27A2A7C", Offset = "0x27A2A7C", VA = "0x27A2A7C")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x27A2AB0", Offset = "0x27A2AB0", VA = "0x27A2AB0")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x27A2B08", Offset = "0x27A2B08", VA = "0x27A2B08")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x27A2B1C", Offset = "0x27A2B1C", VA = "0x27A2B1C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200005F")]
public static class MathHelper
{
	[Token(Token = "0x2000060")]
	public interface InterpolationGenericMath<T>
	{
		[Token(Token = "0x6000318")]
		T Add(T y);

		[Token(Token = "0x6000319")]
		T Multiply(float y);
	}

	[StructLayout(2)]
	[Token(Token = "0x2000061")]
	public struct ColorInterpolator : InterpolationGenericMath<ColorInterpolator>
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color color;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x26B6BB8", Offset = "0x26B6BB8", VA = "0x26B6BB8")]
		public ColorInterpolator(Color clr)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x26B6BC4", Offset = "0x26B6BC4", VA = "0x26B6BC4", Slot = "4")]
		public ColorInterpolator Add(ColorInterpolator y)
		{
			return default(ColorInterpolator);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x26B6C14", Offset = "0x26B6C14", VA = "0x26B6C14", Slot = "5")]
		public ColorInterpolator Multiply(float y)
		{
			return default(ColorInterpolator);
		}
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x211B108", Offset = "0x211B108", VA = "0x211B108")]
	public static Quaternion ShortestRotation(Quaternion a, Quaternion b)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x211B208", Offset = "0x211B208", VA = "0x211B208")]
	public static Quaternion Multiply(this Quaternion input, float scalar)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x211B1C8", Offset = "0x211B1C8", VA = "0x211B1C8")]
	public static Quaternion Negate(this Quaternion input)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000314")]
	public static void Shuffle<T>(T[] array, int startIndex = 0, int endIndex = -1)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x211B248", Offset = "0x211B248", VA = "0x211B248")]
	private static int LevenshteinDistance(string source, string target)
	{
		return default(int);
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x211B4C8", Offset = "0x211B4C8", VA = "0x211B4C8")]
	public static float CalculateSimilarity(string source, string target)
	{
		return default(float);
	}

	[Token(Token = "0x6000317")]
	public unsafe static T InterpolateTriangle<T>(T* data, int* ptrTr, Vector3* ptrVr, int t0, int t1, int t2, Vector3 f) where T : struct, InterpolationGenericMath<T>
	{
		return (T)null;
	}
}
[Token(Token = "0x2000062")]
public class MergeMesh : MonoBehaviour
{
	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool mergeOnStart;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool createTangent;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useUV2;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool vertexColors;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool useRenderer;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool checkOnlyActiveInHierarchy;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] predefinedList;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int indexV;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] indexT;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int indexO;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int indexM;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform[] tr;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material[] materials;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Mesh[] meshes;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[][] meshVertices;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] vertices;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector4[] tangents;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2[] uv;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Color32[] colors;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector2[] uv2;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int[][] triangles;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Mesh mesh;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool usePredefined;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int verticesCnt;

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x211B550", Offset = "0x211B550", VA = "0x211B550")]
	private void Start()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x211B560", Offset = "0x211B560", VA = "0x211B560")]
	public void MergeMeshNow()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x211BC68", Offset = "0x211BC68", VA = "0x211BC68")]
	public void AddTR(Transform t0)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x211C288", Offset = "0x211C288", VA = "0x211C288")]
	public void CountData(Mesh m, Vector3[] mvertices, Renderer r)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x211CF20", Offset = "0x211CF20", VA = "0x211CF20")]
	public void AddMaterial(Material m)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x211D09C", Offset = "0x211D09C", VA = "0x211D09C")]
	public int GetMaterialIndex(Material m)
	{
		return default(int);
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x211C384", Offset = "0x211C384", VA = "0x211C384")]
	private void BuildMesh(Transform t, Mesh m, Vector3[] mvertices)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x211CB24", Offset = "0x211CB24", VA = "0x211CB24")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x211D218", Offset = "0x211D218", VA = "0x211D218")]
	public MergeMesh()
	{
	}
}
[Token(Token = "0x2000063")]
public class OpenUrl
{
	[Token(Token = "0x6000326")]
	[Address(RVA = "0x279C9C8", Offset = "0x279C9C8", VA = "0x279C9C8")]
	public static void Open(string url)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x279CA08", Offset = "0x279CA08", VA = "0x279CA08")]
	public static void Open(string url, string steamBundleID)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x279CA74", Offset = "0x279CA74", VA = "0x279CA74")]
	public OpenUrl()
	{
	}
}
[Token(Token = "0x2000064")]
public enum TargetStore
{
	[Token(Token = "0x400027F")]
	Sidequest,
	[Token(Token = "0x4000280")]
	Oculus,
	[Token(Token = "0x4000281")]
	Steam,
	[Token(Token = "0x4000282")]
	Vive,
	[Token(Token = "0x4000283")]
	Microsoft,
	[Token(Token = "0x4000284")]
	Nolo,
	[Token(Token = "0x4000285")]
	StandaloneOVR,
	[Token(Token = "0x4000286")]
	Pico
}
[Token(Token = "0x2000065")]
public enum VRSDK
{
	[Token(Token = "0x4000288")]
	Oculus,
	[Token(Token = "0x4000289")]
	Steam,
	[Token(Token = "0x400028A")]
	Nolo,
	[Token(Token = "0x400028B")]
	Wave,
	[Token(Token = "0x400028C")]
	Pico
}
[Token(Token = "0x2000066")]
public class Platform : UnityEngine.Object
{
	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static TargetStore targetStore;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool demo;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public static bool mission_editor;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static VRSDK vrSDK;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static bool pico_china;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public static bool pico_global;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public static bool dev_mode;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string dev_mode_contents;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static bool test_build;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public static bool mrc_build;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public static bool mousekbd_input;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	private static bool devModeChecked;

	[Token(Token = "0x17000025")]
	public static bool editor
	{
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x279CA7C", Offset = "0x279CA7C", VA = "0x279CA7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000026")]
	public static bool sidequestStore
	{
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x279CA84", Offset = "0x279CA84", VA = "0x279CA84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000027")]
	public static bool oculusStore
	{
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x279CAF0", Offset = "0x279CAF0", VA = "0x279CAF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000028")]
	public static bool steamStore
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x279CB5C", Offset = "0x279CB5C", VA = "0x279CB5C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000029")]
	public static bool viveStore
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x279CBC8", Offset = "0x279CBC8", VA = "0x279CBC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002A")]
	public static bool microsoftStore
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x279CC34", Offset = "0x279CC34", VA = "0x279CC34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002B")]
	public static bool noloStore
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x279CCA0", Offset = "0x279CCA0", VA = "0x279CCA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002C")]
	public static bool picoStore
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x279CD0C", Offset = "0x279CD0C", VA = "0x279CD0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002D")]
	public static bool standaloneOVRStore
	{
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x279CD78", Offset = "0x279CD78", VA = "0x279CD78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002E")]
	public static bool oculusVR
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x279CDE4", Offset = "0x279CDE4", VA = "0x279CDE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002F")]
	public static bool steamVR
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x279CE50", Offset = "0x279CE50", VA = "0x279CE50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000030")]
	public static bool noloVR
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x279CEBC", Offset = "0x279CEBC", VA = "0x279CEBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000031")]
	public static bool waveVR
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x279CF28", Offset = "0x279CF28", VA = "0x279CF28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000032")]
	public static bool picoVR
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x279CF94", Offset = "0x279CF94", VA = "0x279CF94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000033")]
	public static bool android
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x279D000", Offset = "0x279D000", VA = "0x279D000")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000034")]
	public static bool winStore
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x279D008", Offset = "0x279D008", VA = "0x279D008")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000035")]
	public static bool winStandalone
	{
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x279D010", Offset = "0x279D010", VA = "0x279D010")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000036")]
	public static bool iOS
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x279D018", Offset = "0x279D018", VA = "0x279D018")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000037")]
	public static bool macOsStandalone
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x279D020", Offset = "0x279D020", VA = "0x279D020")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000038")]
	public static bool standalone
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x279D028", Offset = "0x279D028", VA = "0x279D028")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000039")]
	public static bool linuxStandalone
	{
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x279D030", Offset = "0x279D030", VA = "0x279D030")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003A")]
	public static bool onlySoftwareKeyboard
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x279D038", Offset = "0x279D038", VA = "0x279D038")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003B")]
	public static bool mobile
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x279D040", Offset = "0x279D040", VA = "0x279D040")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public static bool PC
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x279D09C", Offset = "0x279D09C", VA = "0x279D09C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	public static string str0xA0
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x279D110", Offset = "0x279D110", VA = "0x279D110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x279D154", Offset = "0x279D154", VA = "0x279D154")]
	public static void CheckDevMode()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x279D3B8", Offset = "0x279D3B8", VA = "0x279D3B8")]
	public Platform()
	{
	}
}
[Token(Token = "0x2000067")]
public class ComputeDiffuseEnvironmentMap : MonoBehaviour
{
	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] mat;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Cubemap filteredCubeMap;

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x1BEA74C", Offset = "0x1BEA74C", VA = "0x1BEA74C")]
	public void ComputeConvolution(Cubemap originalCubeMap)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x1BEAD70", Offset = "0x1BEAD70", VA = "0x1BEAD70")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1BEA9C8", Offset = "0x1BEA9C8", VA = "0x1BEA9C8")]
	private Cubemap computeFilteredCubeMap(Cubemap originalCubeMap)
	{
		return null;
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x1BEAF94", Offset = "0x1BEAF94", VA = "0x1BEAF94")]
	private void setFaceAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x1BEB0C4", Offset = "0x1BEB0C4", VA = "0x1BEB0C4")]
	private void setCornerAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f, int g, int h, int i)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x1BEAE20", Offset = "0x1BEAE20", VA = "0x1BEAE20")]
	private Vector3 getDirection(int face, int i, int j, int size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x1BEB288", Offset = "0x1BEB288", VA = "0x1BEB288")]
	public ComputeDiffuseEnvironmentMap()
	{
	}
}
[Token(Token = "0x2000068")]
public struct EncodedInt
{
	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int xorHash;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private int encValue;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private int fakeValue;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private int plainValue;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool inited;

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1BF36EC", Offset = "0x1BF36EC", VA = "0x1BF36EC")]
	public static implicit operator EncodedInt(int value)
	{
		return default(EncodedInt);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1BF3708", Offset = "0x1BF3708", VA = "0x1BF3708")]
	public static bool operator ==(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x1BF379C", Offset = "0x1BF379C", VA = "0x1BF379C")]
	public static bool operator !=(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x1BF37C4", Offset = "0x1BF37C4", VA = "0x1BF37C4")]
	public static bool operator ==(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x1BF37F0", Offset = "0x1BF37F0", VA = "0x1BF37F0")]
	public static bool operator !=(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1BF381C", Offset = "0x1BF381C", VA = "0x1BF381C")]
	public void setValue(int val)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x1BF3730", Offset = "0x1BF3730", VA = "0x1BF3730")]
	public int getValue()
	{
		return default(int);
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1BF36F8", Offset = "0x1BF36F8", VA = "0x1BF36F8")]
	private EncodedInt(int val)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1BF38C0", Offset = "0x1BF38C0", VA = "0x1BF38C0")]
	private void Init(int val)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x1BF3918", Offset = "0x1BF3918", VA = "0x1BF3918", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1BF3944", Offset = "0x1BF3944", VA = "0x1BF3944")]
	public string ToString(string format)
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1BF3978", Offset = "0x1BF3978", VA = "0x1BF3978", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x1BF3A38", Offset = "0x1BF3A38", VA = "0x1BF3A38")]
	public bool Equals(EncodedInt p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x1BF3A6C", Offset = "0x1BF3A6C", VA = "0x1BF3A6C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000069")]
public struct Vector2Int
{
	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int x;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int y;

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x27A5608", Offset = "0x27A5608", VA = "0x27A5608")]
	public Vector2Int(int _x, int _y)
	{
	}
}
[Token(Token = "0x200006A")]
public class SaveWrapper : MonoBehaviour
{
	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static JSONObject jsonSave;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static bool saveChanged;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	protected static float saveChangedTime;

	[Token(Token = "0x40002A5")]
	public const string wrapperSaveName = "saveGame";

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static SaveWrapper instance;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected static string oculusSaveWrapperFile;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected static bool steamInitialized;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private static bool waitingForInitialize;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initializing;

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x279F724", Offset = "0x279F724", VA = "0x279F724")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x279FD28", Offset = "0x279FD28", VA = "0x279FD28")]
	public static float GetFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x279FD90", Offset = "0x279FD90", VA = "0x279FD90")]
	public static float GetFloat(string key, float defval)
	{
		return default(float);
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x279FE98", Offset = "0x279FE98", VA = "0x279FE98")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x279FF00", Offset = "0x279FF00", VA = "0x279FF00")]
	public static int GetInt(string key, int defval)
	{
		return default(int);
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x27A0008", Offset = "0x27A0008", VA = "0x27A0008")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x27A0084", Offset = "0x27A0084", VA = "0x27A0084")]
	public static string GetString(string key, string defval)
	{
		return null;
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x27A01A0", Offset = "0x27A01A0", VA = "0x27A01A0")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x27A0280", Offset = "0x27A0280", VA = "0x27A0280")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x27A0654", Offset = "0x27A0654", VA = "0x27A0654")]
	public static void SetFloat(string key, float val)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x27A07EC", Offset = "0x27A07EC", VA = "0x27A07EC")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x27A0984", Offset = "0x27A0984", VA = "0x27A0984")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x279F868", Offset = "0x279F868", VA = "0x279F868")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x27A0B30", Offset = "0x27A0B30", VA = "0x27A0B30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x27A0DC8", Offset = "0x27A0DC8", VA = "0x27A0DC8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x27A0E84", Offset = "0x27A0E84", VA = "0x27A0E84")]
	public static bool IsInitializing()
	{
		return default(bool);
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x27A0F94", Offset = "0x27A0F94", VA = "0x27A0F94")]
	private void Update()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x27A1158", Offset = "0x27A1158", VA = "0x27A1158")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x27A1200", Offset = "0x27A1200", VA = "0x27A1200")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x279F9DC", Offset = "0x279F9DC", VA = "0x279F9DC")]
	public static bool IsUseWrapper()
	{
		return default(bool);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x279FACC", Offset = "0x279FACC", VA = "0x279FACC")]
	protected static void LoadWrapper()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x27A0374", Offset = "0x27A0374", VA = "0x27A0374")]
	protected static void StoreWrapper()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x27A12A8", Offset = "0x27A12A8", VA = "0x27A12A8")]
	public SaveWrapper()
	{
	}
}
[Token(Token = "0x200006B")]
public class TextureWWWDownloader : MonoBehaviour
{
	[Token(Token = "0x200006C")]
	public class DownloadedTexture
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string filePath;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest request;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool done;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture texture;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x26B74A4", Offset = "0x26B74A4", VA = "0x26B74A4")]
		public DownloadedTexture()
		{
		}
	}

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static TextureWWWDownloader instance;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected List<DownloadedTexture> textures;

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x27A42A4", Offset = "0x27A42A4", VA = "0x27A42A4")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x27A42A8", Offset = "0x27A42A8", VA = "0x27A42A8")]
	public static void LogError(string text)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x27A4338", Offset = "0x27A4338", VA = "0x27A4338")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x27A4440", Offset = "0x27A4440", VA = "0x27A4440")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x27A44E4", Offset = "0x27A44E4", VA = "0x27A44E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x27A4E04", Offset = "0x27A4E04", VA = "0x27A4E04")]
	public static DownloadedTexture GetTexture(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x27A4E50", Offset = "0x27A4E50", VA = "0x27A4E50")]
	public static DownloadedTexture GetTexture(string filePath, string resourcesFolder)
	{
		return null;
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x27A5540", Offset = "0x27A5540", VA = "0x27A5540")]
	protected static string GetFileName(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x27A44E8", Offset = "0x27A44E8", VA = "0x27A44E8")]
	private void StepDownloadingTextures()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x27A5590", Offset = "0x27A5590", VA = "0x27A5590")]
	public TextureWWWDownloader()
	{
	}
}
[Token(Token = "0x200006D")]
public class WWWwrapper : CustomYieldInstruction
{
	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected UnityWebRequest request;

	[Token(Token = "0x1700003E")]
	public override bool keepWaiting
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x27A572C", Offset = "0x27A572C", VA = "0x27A572C", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003F")]
	public string error
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x27A5758", Offset = "0x27A5758", VA = "0x27A5758")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000040")]
	public string text
	{
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x27A5800", Offset = "0x27A5800", VA = "0x27A5800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public byte[] data
	{
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x27A582C", Offset = "0x27A582C", VA = "0x27A582C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	public string data2string
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x27A5858", Offset = "0x27A5858", VA = "0x27A5858")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000043")]
	public bool isDone
	{
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x27A596C", Offset = "0x27A596C", VA = "0x27A596C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x27A5988", Offset = "0x27A5988", VA = "0x27A5988")]
	public WWWwrapper(string url, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x27A5B00", Offset = "0x27A5B00", VA = "0x27A5B00")]
	public WWWwrapper(string url, WWWForm form, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x27A5C98", Offset = "0x27A5C98", VA = "0x27A5C98")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x27A5CB4", Offset = "0x27A5CB4", VA = "0x27A5CB4")]
	public static string EscapeURL(string url)
	{
		return null;
	}
}
[Token(Token = "0x200006E")]
public static class Bezier
{
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x1E1E6D8", Offset = "0x1E1E6D8", VA = "0x1E1E6D8")]
	public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1E1E798", Offset = "0x1E1E798", VA = "0x1E1E798")]
	public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x1E1E7F4", Offset = "0x1E1E7F4", VA = "0x1E1E7F4")]
	public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x1E1E8F4", Offset = "0x1E1E8F4", VA = "0x1E1E8F4")]
	public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200006F")]
public enum BezierControlPointMode
{
	[Token(Token = "0x40002B3")]
	Free,
	[Token(Token = "0x40002B4")]
	Aligned,
	[Token(Token = "0x40002B5")]
	Mirrored
}
[Token(Token = "0x2000070")]
public class BezierCurveMono : MonoBehaviour
{
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BezierCurve curve;

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x1E1EDA8", Offset = "0x1E1EDA8", VA = "0x1E1EDA8")]
	public void Reset()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x1E1EE78", Offset = "0x1E1EE78", VA = "0x1E1EE78")]
	public BezierCurveMono()
	{
	}
}
[Serializable]
[Token(Token = "0x2000071")]
public class BezierCurve
{
	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform transform;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] points;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float arcLength;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float maximumVelocity;

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x1E1EA04", Offset = "0x1E1EA04", VA = "0x1E1EA04")]
	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x1E1EAA4", Offset = "0x1E1EAA4", VA = "0x1E1EAA4")]
	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x1E1EB84", Offset = "0x1E1EB84", VA = "0x1E1EB84")]
	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1E1EBB4", Offset = "0x1E1EBB4", VA = "0x1E1EBB4")]
	public void CalculateArcLength()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1E1ECD8", Offset = "0x1E1ECD8", VA = "0x1E1ECD8")]
	public BezierCurve()
	{
	}
}
[Token(Token = "0x2000072")]
public class BezierSpline : MonoBehaviour
{
	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Vector3[] points;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BezierControlPointMode[] modes;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool loop;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[SerializeField]
	public bool worldSpace;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float maximumVelocity;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float arcLength;

	[Token(Token = "0x17000044")]
	public bool Loop
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1E1EE80", Offset = "0x1E1EE80", VA = "0x1E1EE80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1E1EE88", Offset = "0x1E1EE88", VA = "0x1E1EE88")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public float MaximumVelocity
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1E1F144", Offset = "0x1E1F144", VA = "0x1E1F144")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000046")]
	public float ArcLength
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1E1F14C", Offset = "0x1E1F14C", VA = "0x1E1F14C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000047")]
	public int ControlPointCount
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1E1F154", Offset = "0x1E1F154", VA = "0x1E1F154")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000048")]
	public int CurveCount
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1E1F4C4", Offset = "0x1E1F4C4", VA = "0x1E1F4C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x1E1F170", Offset = "0x1E1F170", VA = "0x1E1F170")]
	public Vector3 GetControlPoint(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x1E1EEFC", Offset = "0x1E1EEFC", VA = "0x1E1EEFC")]
	public void SetControlPoint(int index, Vector3 point)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x1E1F3C4", Offset = "0x1E1F3C4", VA = "0x1E1F3C4")]
	public BezierControlPointMode GetControlPointMode(int index)
	{
		return default(BezierControlPointMode);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x1E1F41C", Offset = "0x1E1F41C", VA = "0x1E1F41C")]
	public void SetControlPointMode(int index, BezierControlPointMode mode)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x1E1F1B8", Offset = "0x1E1F1B8", VA = "0x1E1F1B8")]
	private void EnforceMode(int index)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x1E1F4FC", Offset = "0x1E1F4FC", VA = "0x1E1F4FC")]
	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x1E1F724", Offset = "0x1E1F724", VA = "0x1E1F724")]
	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x1E1F980", Offset = "0x1E1F980", VA = "0x1E1F980")]
	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x1E1F9B0", Offset = "0x1E1F9B0", VA = "0x1E1F9B0")]
	public void AddCurve()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x1E1FBF4", Offset = "0x1E1FBF4", VA = "0x1E1FBF4")]
	public void Reset()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x1E1FCE0", Offset = "0x1E1FCE0", VA = "0x1E1FCE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x1E1FE08", Offset = "0x1E1FE08", VA = "0x1E1FE08")]
	public void SetPoints(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1E1FCE4", Offset = "0x1E1FCE4", VA = "0x1E1FCE4")]
	private void CalculateArcLength()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x1E1FEA4", Offset = "0x1E1FEA4", VA = "0x1E1FEA4")]
	public BezierSpline()
	{
	}
}
[Token(Token = "0x2000073")]
public class BezierSplineLinear
{
	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private BezierSpline spline;

	[Token(Token = "0x40002C2")]
	private const float precision = 0.02f;

	[Token(Token = "0x40002C3")]
	private const float len = 50f;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float[][] arcLengths;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[] lengthRatio;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float totalLength;

	[Token(Token = "0x17000049")]
	private Vector3[] points
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1E1FEAC", Offset = "0x1E1FEAC", VA = "0x1E1FEAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004A")]
	private int CurveCount
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1E1FEC8", Offset = "0x1E1FEC8", VA = "0x1E1FEC8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004B")]
	public float TotalLength
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1E1FF0C", Offset = "0x1E1FF0C", VA = "0x1E1FF0C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x1E1FF14", Offset = "0x1E1FF14", VA = "0x1E1FF14")]
	public BezierSplineLinear(BezierSpline spline)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x1E1FF44", Offset = "0x1E1FF44", VA = "0x1E1FF44")]
	private void Calculate()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x1E202E4", Offset = "0x1E202E4", VA = "0x1E202E4")]
	private float map(int c, float u)
	{
		return default(float);
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x1E203F8", Offset = "0x1E203F8", VA = "0x1E203F8")]
	private void LinearT(ref float t, out int p)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x1E204DC", Offset = "0x1E204DC", VA = "0x1E204DC")]
	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x1E206A4", Offset = "0x1E206A4", VA = "0x1E206A4")]
	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000074")]
public class SplineWalker : MonoBehaviour
{
	[Token(Token = "0x2000075")]
	public delegate void SplineWalkerStep(PathData data);

	[Token(Token = "0x2000076")]
	public delegate void SplineWalkerFinish(PathData data);

	[Token(Token = "0x2000077")]
	public struct PathData
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 direction;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 velocity;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMagnitude;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedFactor;
	}

	[Token(Token = "0x40002C7")]
	private const float MaximumVelocity = 5000f;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BezierSpline spline;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve speedFactor;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float moveStep;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float moveProgress;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float stepFactor;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private PathData lastData;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public SplineWalkerStep OnMove;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public SplineWalkerFinish OnFinish;

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x27A24F8", Offset = "0x27A24F8", VA = "0x27A24F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x27A2574", Offset = "0x27A2574", VA = "0x27A2574")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x27A26F0", Offset = "0x27A26F0", VA = "0x27A26F0")]
	private PathData GetNodeData(float t)
	{
		return default(PathData);
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x27A254C", Offset = "0x27A254C", VA = "0x27A254C")]
	private float InitializeSpeed(float speed)
	{
		return default(float);
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x27A27E0", Offset = "0x27A27E0", VA = "0x27A27E0")]
	public void Finish()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x27A2824", Offset = "0x27A2824", VA = "0x27A2824")]
	public SplineWalker()
	{
	}
}
[Token(Token = "0x2000078")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int gameAppId;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int gameAppIdDemo;

	[Token(Token = "0x1700004C")]
	public static bool Initialized
	{
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x27A2834", Offset = "0x27A2834", VA = "0x27A2834")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x27A283C", Offset = "0x27A283C", VA = "0x27A283C")]
	public SteamManager()
	{
	}
}
[Token(Token = "0x2000079")]
public class AndroidPermissionCallback : AndroidJavaProxy
{
	[Token(Token = "0x14000001")]
	private event Action<string> OnPermissionGrantedAction
	{
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1E10BAC", Offset = "0x1E10BAC", VA = "0x1E10BAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34C9C", Offset = "0xA34C9C")]
		add
		{
		}
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1E10C4C", Offset = "0x1E10C4C", VA = "0x1E10C4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34CAC", Offset = "0xA34CAC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	private event Action<string> OnPermissionDeniedAction
	{
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1E10CEC", Offset = "0x1E10CEC", VA = "0x1E10CEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34CBC", Offset = "0xA34CBC")]
		add
		{
		}
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1E10D8C", Offset = "0x1E10D8C", VA = "0x1E10D8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34CCC", Offset = "0xA34CCC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	private event Action<string> OnPermissionDeniedAndDontAskAgainAction
	{
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1E10E2C", Offset = "0x1E10E2C", VA = "0x1E10E2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34CDC", Offset = "0xA34CDC")]
		add
		{
		}
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1E10ECC", Offset = "0x1E10ECC", VA = "0x1E10ECC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34CEC", Offset = "0xA34CEC")]
		remove
		{
		}
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x1E10F6C", Offset = "0x1E10F6C", VA = "0x1E10F6C")]
	public AndroidPermissionCallback(Action<string> onGrantedCallback, Action<string> onDeniedCallback, Action<string> onDeniedAndDontAskAgainCallback)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x1E11048", Offset = "0x1E11048", VA = "0x1E11048", Slot = "9")]
	public virtual void OnPermissionGranted(string permissionName)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1E110B8", Offset = "0x1E110B8", VA = "0x1E110B8", Slot = "10")]
	public virtual void OnPermissionDenied(string permissionName)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x1E11128", Offset = "0x1E11128", VA = "0x1E11128", Slot = "11")]
	public virtual void OnPermissionDeniedAndDontAskAgain(string permissionName)
	{
	}
}
[Token(Token = "0x200007A")]
public class AndroidPermissionsManager
{
	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject m_Activity;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject m_PermissionService;

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x1E111A0", Offset = "0x1E111A0", VA = "0x1E111A0")]
	private static AndroidJavaObject GetActivity()
	{
		return null;
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x1E11288", Offset = "0x1E11288", VA = "0x1E11288")]
	private static AndroidJavaObject GetPermissionsService()
	{
		return null;
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x1E113CC", Offset = "0x1E113CC", VA = "0x1E113CC")]
	public static bool IsPermissionGranted(string permissionName)
	{
		return default(bool);
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x1E114E4", Offset = "0x1E114E4", VA = "0x1E114E4")]
	public static void RequestPermission(string permissionName, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1E11590", Offset = "0x1E11590", VA = "0x1E11590")]
	public static void RequestPermission(string[] permissionNames, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1E116C8", Offset = "0x1E116C8", VA = "0x1E116C8")]
	public AndroidPermissionsManager()
	{
	}
}
namespace JSONplugin
{
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA326A0", Offset = "0xA326A0")]
	public class JSONObject
	{
		[Token(Token = "0x200007C")]
		public enum Type
		{
			[Token(Token = "0x40002ED")]
			NULL,
			[Token(Token = "0x40002EE")]
			STRING,
			[Token(Token = "0x40002EF")]
			NUMBER,
			[Token(Token = "0x40002F0")]
			OBJECT,
			[Token(Token = "0x40002F1")]
			ARRAY,
			[Token(Token = "0x40002F2")]
			BOOL,
			[Token(Token = "0x40002F3")]
			BAKED
		}

		[Token(Token = "0x200007D")]
		public delegate void AddJSONContents(JSONObject self);

		[Token(Token = "0x200007E")]
		public delegate void FieldNotFound(string name);

		[Token(Token = "0x200007F")]
		public delegate void GetFieldResponse(JSONObject obj);

		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA326D8", Offset = "0xA326D8")]
		private sealed class <BakeAsync>d__125 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<string> <>7__wrap1;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x26B3064", Offset = "0x26B3064", VA = "0x26B3064", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x26B30AC", Offset = "0x26B30AC", VA = "0x26B30AC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x26B2C78", Offset = "0x26B2C78", VA = "0x26B2C78")]
			[DebuggerHidden]
			public <BakeAsync>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x26B2CB0", Offset = "0x26B2CB0", VA = "0x26B2CB0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x26B2D88", Offset = "0x26B2D88", VA = "0x26B2D88", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x26B2CCC", Offset = "0x26B2CCC", VA = "0x26B2CCC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x26B306C", Offset = "0x26B306C", VA = "0x26B306C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x26B30B4", Offset = "0x26B30B4", VA = "0x26B30B4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x26B315C", Offset = "0x26B315C", VA = "0x26B315C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA326E8", Offset = "0xA326E8")]
		private sealed class <PrintAsync>d__128 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool pretty;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool <>3__pretty;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StringBuilder <builder>5__2;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator <>7__wrap2;

			[Token(Token = "0x1700005D")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x26B35E8", Offset = "0x26B35E8", VA = "0x26B35E8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x26B3630", Offset = "0x26B3630", VA = "0x26B3630", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x26B3160", Offset = "0x26B3160", VA = "0x26B3160")]
			[DebuggerHidden]
			public <PrintAsync>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x26B3198", Offset = "0x26B3198", VA = "0x26B3198", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x26B327C", Offset = "0x26B327C", VA = "0x26B327C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x26B31B4", Offset = "0x26B31B4", VA = "0x26B31B4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x26B35F0", Offset = "0x26B35F0", VA = "0x26B35F0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x26B3638", Offset = "0x26B3638", VA = "0x26B3638", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x26B36E8", Offset = "0x26B36E8", VA = "0x26B36E8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000082")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA326F8", Offset = "0xA326F8")]
		private sealed class <StringifyAsync>d__131 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int depth;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int <>3__depth;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StringBuilder builder;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public StringBuilder <>3__builder;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool pretty;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool <>3__pretty;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <i>5__2;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private IEnumerator <>7__wrap2;

			[Token(Token = "0x1700005F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x26B4904", Offset = "0x26B4904", VA = "0x26B4904", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000060")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x26B494C", Offset = "0x26B494C", VA = "0x26B494C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x26B36EC", Offset = "0x26B36EC", VA = "0x26B36EC")]
			[DebuggerHidden]
			public <StringifyAsync>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x26B3724", Offset = "0x26B3724", VA = "0x26B3724", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x26B3950", Offset = "0x26B3950", VA = "0x26B3950", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x26B37C0", Offset = "0x26B37C0", VA = "0x26B37C0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x26B3888", Offset = "0x26B3888", VA = "0x26B3888")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x26B490C", Offset = "0x26B490C", VA = "0x26B490C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x26B4954", Offset = "0x26B4954", VA = "0x26B4954", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x26B4A14", Offset = "0x26B4A14", VA = "0x26B4A14", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40002DD")]
		private const int MAX_DEPTH = 100;

		[Token(Token = "0x40002DE")]
		private const string INFINITY = "\"INFINITY\"";

		[Token(Token = "0x40002DF")]
		private const string NEGINFINITY = "\"NEGINFINITY\"";

		[Token(Token = "0x40002E0")]
		private const string NaN = "\"NaN\"";

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly char[] WHITESPACE;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<JSONObject> list;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> keys;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string str;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float n;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useInt;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long i;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool b;

		[Token(Token = "0x40002EA")]
		private const float maxFrameTime = 0.008f;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Stopwatch printWatch;

		[Token(Token = "0x1700004D")]
		public bool isContainer
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1BF5DA0", Offset = "0x1BF5DA0", VA = "0x1BF5DA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public int Count
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1BF5DB4", Offset = "0x1BF5DB4", VA = "0x1BF5DB4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004F")]
		public float f
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1BF5E04", Offset = "0x1BF5E04", VA = "0x1BF5E04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000050")]
		public static JSONObject nullJO
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1BF5E0C", Offset = "0x1BF5E0C", VA = "0x1BF5E0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public static JSONObject obj
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1BF5F98", Offset = "0x1BF5F98", VA = "0x1BF5F98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public static JSONObject arr
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1BF5FF4", Offset = "0x1BF5FF4", VA = "0x1BF5FF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public bool IsNumber
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1BF7AF0", Offset = "0x1BF7AF0", VA = "0x1BF7AF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public bool IsNull
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1BF7B00", Offset = "0x1BF7B00", VA = "0x1BF7B00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsString
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1BF7B10", Offset = "0x1BF7B10", VA = "0x1BF7B10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public bool IsBool
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1BF7B20", Offset = "0x1BF7B20", VA = "0x1BF7B20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		public bool IsArray
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1BF7B30", Offset = "0x1BF7B30", VA = "0x1BF7B30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public bool IsObject
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1BF7B40", Offset = "0x1BF7B40", VA = "0x1BF7B40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public JSONObject Item
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1BF9ADC", Offset = "0x1BF9ADC", VA = "0x1BF9ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1BF9B68", Offset = "0x1BF9B68", VA = "0x1BF9B68")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public JSONObject Item
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1BF89EC", Offset = "0x1BF89EC", VA = "0x1BF89EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1BFA588", Offset = "0x1BFA588", VA = "0x1BFA588")]
			set
			{
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1BF6050", Offset = "0x1BF6050", VA = "0x1BF6050")]
		public JSONObject(Type t)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1BF6158", Offset = "0x1BF6158", VA = "0x1BF6158")]
		public JSONObject(bool b)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1BF6190", Offset = "0x1BF6190", VA = "0x1BF6190")]
		public JSONObject(float f)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1BF61CC", Offset = "0x1BF61CC", VA = "0x1BF61CC")]
		public JSONObject(int i)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1BF6214", Offset = "0x1BF6214", VA = "0x1BF6214")]
		public JSONObject(long l)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1BF6258", Offset = "0x1BF6258", VA = "0x1BF6258")]
		public JSONObject(Dictionary<string, string> dic)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1BF654C", Offset = "0x1BF654C", VA = "0x1BF654C")]
		public JSONObject(Dictionary<string, JSONObject> dic)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1BF6778", Offset = "0x1BF6778", VA = "0x1BF6778")]
		public JSONObject(AddJSONContents content)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1BF67B4", Offset = "0x1BF67B4", VA = "0x1BF67B4")]
		public JSONObject(JSONObject[] objs)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1BF6848", Offset = "0x1BF6848", VA = "0x1BF6848")]
		public static JSONObject StringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1BF68A8", Offset = "0x1BF68A8", VA = "0x1BF68A8")]
		public void Absorb(JSONObject obj)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1BF696C", Offset = "0x1BF696C", VA = "0x1BF696C")]
		public static JSONObject Create()
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1BF5E68", Offset = "0x1BF5E68", VA = "0x1BF5E68")]
		public static JSONObject Create(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1BF69CC", Offset = "0x1BF69CC", VA = "0x1BF69CC")]
		public static JSONObject Create(bool val)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1BF6A44", Offset = "0x1BF6A44", VA = "0x1BF6A44")]
		public static JSONObject Create(float val)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1BF6AC0", Offset = "0x1BF6AC0", VA = "0x1BF6AC0")]
		public static JSONObject Create(int val)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1BF6B48", Offset = "0x1BF6B48", VA = "0x1BF6B48")]
		public static JSONObject Create(uint val)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1BF6BD4", Offset = "0x1BF6BD4", VA = "0x1BF6BD4")]
		public static JSONObject Create(long val)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1BF6C58", Offset = "0x1BF6C58", VA = "0x1BF6C58")]
		public static JSONObject Create(ulong val)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1BF64D8", Offset = "0x1BF64D8", VA = "0x1BF64D8")]
		public static JSONObject CreateStringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1BF6CE0", Offset = "0x1BF6CE0", VA = "0x1BF6CE0")]
		public static JSONObject CreateBakedObject(string val)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1BF6D54", Offset = "0x1BF6D54", VA = "0x1BF6D54")]
		public static JSONObject Create(string val, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1BF76B0", Offset = "0x1BF76B0", VA = "0x1BF76B0")]
		public static JSONObject Create(AddJSONContents content)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1BF7730", Offset = "0x1BF7730", VA = "0x1BF7730")]
		public static JSONObject Create(Dictionary<string, string> dic)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1BF69C4", Offset = "0x1BF69C4", VA = "0x1BF69C4")]
		public JSONObject()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1BF79C8", Offset = "0x1BF79C8", VA = "0x1BF79C8")]
		public JSONObject(string str)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1BF7A04", Offset = "0x1BF7A04", VA = "0x1BF7A04")]
		public JSONObject(string str, int maxDepth)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1BF7A4C", Offset = "0x1BF7A4C", VA = "0x1BF7A4C")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1BF7A98", Offset = "0x1BF7A98", VA = "0x1BF7A98")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels, bool strict)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1BF6DF4", Offset = "0x1BF6DF4", VA = "0x1BF6DF4")]
		private void Parse(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1BF7B5C", Offset = "0x1BF7B5C", VA = "0x1BF7B5C")]
		public void Add(bool val)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1BF7CE4", Offset = "0x1BF7CE4", VA = "0x1BF7CE4")]
		public void Add(float val)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1BF7D5C", Offset = "0x1BF7D5C", VA = "0x1BF7D5C")]
		public void Add(int val)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1BF7DD4", Offset = "0x1BF7DD4", VA = "0x1BF7DD4")]
		public void Add(uint val)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1BF7E4C", Offset = "0x1BF7E4C", VA = "0x1BF7E4C")]
		public void Add(long val)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1BF7EC4", Offset = "0x1BF7EC4", VA = "0x1BF7EC4")]
		public void Add(ulong val)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1BF7F3C", Offset = "0x1BF7F3C", VA = "0x1BF7F3C")]
		public void Add(string str)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1BF7FB4", Offset = "0x1BF7FB4", VA = "0x1BF7FB4")]
		public void Add(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1BF7BD4", Offset = "0x1BF7BD4", VA = "0x1BF7BD4")]
		public void Add(JSONObject obj)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1BF8038", Offset = "0x1BF8038", VA = "0x1BF8038")]
		public void AddField(string name, bool val)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1BF82D0", Offset = "0x1BF82D0", VA = "0x1BF82D0")]
		public void AddField(string name, float val)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1BF8358", Offset = "0x1BF8358", VA = "0x1BF8358")]
		public void AddField(string name, int val)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1BF83D8", Offset = "0x1BF83D8", VA = "0x1BF83D8")]
		public void AddField(string name, uint val)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1BF8458", Offset = "0x1BF8458", VA = "0x1BF8458")]
		public void AddField(string name, long val)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1BF84D8", Offset = "0x1BF84D8", VA = "0x1BF84D8")]
		public void AddField(string name, ulong val)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1BF8558", Offset = "0x1BF8558", VA = "0x1BF8558")]
		public void AddField(string name, AddJSONContents content)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1BF85D8", Offset = "0x1BF85D8", VA = "0x1BF85D8")]
		public void AddField(string name, string val)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1BF80B8", Offset = "0x1BF80B8", VA = "0x1BF80B8")]
		public void AddField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1BF8658", Offset = "0x1BF8658", VA = "0x1BF8658")]
		public void SetField(string name, string val)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1BF8798", Offset = "0x1BF8798", VA = "0x1BF8798")]
		public void SetField(string name, bool val)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1BF8818", Offset = "0x1BF8818", VA = "0x1BF8818")]
		public void SetField(string name, float val)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1BF88A0", Offset = "0x1BF88A0", VA = "0x1BF88A0")]
		public void SetField(string name, int val)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1BF86D8", Offset = "0x1BF86D8", VA = "0x1BF86D8")]
		public void SetField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1BF89F0", Offset = "0x1BF89F0", VA = "0x1BF89F0")]
		public void RemoveField(string name)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1BF8AD0", Offset = "0x1BF8AD0", VA = "0x1BF8AD0")]
		public bool GetField(out bool field, string name, bool fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1BF8AE0", Offset = "0x1BF8AE0", VA = "0x1BF8AE0")]
		public bool GetField(ref bool field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1BF8AE8", Offset = "0x1BF8AE8", VA = "0x1BF8AE8")]
		public bool GetField(ref bool field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1BF8BD4", Offset = "0x1BF8BD4", VA = "0x1BF8BD4")]
		public bool GetField(out float field, string name, float fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1BF8BE0", Offset = "0x1BF8BE0", VA = "0x1BF8BE0")]
		public bool GetField(ref float field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1BF8BE8", Offset = "0x1BF8BE8", VA = "0x1BF8BE8")]
		public bool GetField(ref float field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1BF8CD4", Offset = "0x1BF8CD4", VA = "0x1BF8CD4")]
		public bool GetField(out int field, string name, int fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1BF8CE0", Offset = "0x1BF8CE0", VA = "0x1BF8CE0")]
		public bool GetField(ref int field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1BF8CE8", Offset = "0x1BF8CE8", VA = "0x1BF8CE8")]
		public bool GetField(ref int field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1BF8E38", Offset = "0x1BF8E38", VA = "0x1BF8E38")]
		public bool GetField(out long field, string name, long fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1BF8E44", Offset = "0x1BF8E44", VA = "0x1BF8E44")]
		public bool GetField(ref long field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1BF8E4C", Offset = "0x1BF8E4C", VA = "0x1BF8E4C")]
		public bool GetField(ref long field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1BF8F9C", Offset = "0x1BF8F9C", VA = "0x1BF8F9C")]
		public bool GetField(out uint field, string name, uint fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1BF8FA8", Offset = "0x1BF8FA8", VA = "0x1BF8FA8")]
		public bool GetField(ref uint field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1BF8FB0", Offset = "0x1BF8FB0", VA = "0x1BF8FB0")]
		public bool GetField(ref uint field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1BF90F4", Offset = "0x1BF90F4", VA = "0x1BF90F4")]
		public bool GetField(out ulong field, string name, ulong fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1BF9100", Offset = "0x1BF9100", VA = "0x1BF9100")]
		public bool GetField(ref ulong field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1BF9108", Offset = "0x1BF9108", VA = "0x1BF9108")]
		public bool GetField(ref ulong field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1BF924C", Offset = "0x1BF924C", VA = "0x1BF924C")]
		public bool GetField(out string field, string name, string fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1BF9258", Offset = "0x1BF9258", VA = "0x1BF9258")]
		public bool GetField(ref string field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1BF9260", Offset = "0x1BF9260", VA = "0x1BF9260")]
		public bool GetField(ref string field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1BF9354", Offset = "0x1BF9354", VA = "0x1BF9354")]
		public void GetField(string name, GetFieldResponse response, [Optional] FieldNotFound fail)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1BF9460", Offset = "0x1BF9460", VA = "0x1BF9460")]
		public JSONObject GetField(string name)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1BF955C", Offset = "0x1BF955C", VA = "0x1BF955C")]
		public bool HasFields(string[] names)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1BF8920", Offset = "0x1BF8920", VA = "0x1BF8920")]
		public bool HasField(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1BF9630", Offset = "0x1BF9630", VA = "0x1BF9630")]
		public void Clear()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1BF96D8", Offset = "0x1BF96D8", VA = "0x1BF96D8")]
		public JSONObject Copy()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1BF9760", Offset = "0x1BF9760", VA = "0x1BF9760")]
		public void Merge(JSONObject obj)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1BF97D0", Offset = "0x1BF97D0", VA = "0x1BF97D0")]
		private static void MergeRecur(JSONObject left, JSONObject right)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1BF9BFC", Offset = "0x1BF9BFC", VA = "0x1BF9BFC")]
		public void Bake()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1BF9C38", Offset = "0x1BF9C38", VA = "0x1BF9C38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA34CFC", Offset = "0xA34CFC")]
		public IEnumerable BakeAsync()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1BF9758", Offset = "0x1BF9758", VA = "0x1BF9758")]
		public string Print()
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1BF9CA4", Offset = "0x1BF9CA4", VA = "0x1BF9CA4")]
		public string Print(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1BFA470", Offset = "0x1BFA470", VA = "0x1BFA470")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA34D5C", Offset = "0xA34D5C")]
		public IEnumerable<string> PrintAsync(bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1BFA4F0", Offset = "0x1BFA4F0", VA = "0x1BFA4F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA34DBC", Offset = "0xA34DBC")]
		private IEnumerable StringifyAsync(int depth, StringBuilder builder, bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1BF9D30", Offset = "0x1BF9D30", VA = "0x1BF9D30")]
		private void Stringify(int depth, StringBuilder builder, bool pretty = false)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1BFA58C", Offset = "0x1BFA58C", VA = "0x1BFA58C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1BFA594", Offset = "0x1BFA594", VA = "0x1BFA594")]
		public string ToString(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1BFA59C", Offset = "0x1BFA59C", VA = "0x1BFA59C")]
		public Dictionary<string, string> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1BF802C", Offset = "0x1BF802C", VA = "0x1BF802C")]
		public static implicit operator bool(JSONObject o)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000083")]
	public static class JSONTemplates
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly HashSet<object> touched;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2540280", Offset = "0x2540280", VA = "0x2540280")]
		public static JSONObject TOJSON(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2540F34", Offset = "0x2540F34", VA = "0x2540F34")]
		public static Vector2 ToVector2(JSONObject obj)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2541074", Offset = "0x2541074", VA = "0x2541074")]
		public static JSONObject FromVector2(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2541158", Offset = "0x2541158", VA = "0x2541158")]
		public static JSONObject FromVector3(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x254127C", Offset = "0x254127C", VA = "0x254127C")]
		public static Vector3 ToVector3(JSONObject obj)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x2541430", Offset = "0x2541430", VA = "0x2541430")]
		public static JSONObject FromVector4(Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x254158C", Offset = "0x254158C", VA = "0x254158C")]
		public static Vector4 ToVector4(JSONObject obj)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x25417DC", Offset = "0x25417DC", VA = "0x25417DC")]
		public static JSONObject FromMatrix4x4(Matrix4x4 m)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2541B8C", Offset = "0x2541B8C", VA = "0x2541B8C")]
		public static Matrix4x4 ToMatrix4x4(JSONObject obj)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x254237C", Offset = "0x254237C", VA = "0x254237C")]
		public static JSONObject FromQuaternion(Quaternion q)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x25424D8", Offset = "0x25424D8", VA = "0x25424D8")]
		public static Quaternion ToQuaternion(JSONObject obj)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2542728", Offset = "0x2542728", VA = "0x2542728")]
		public static JSONObject FromColor(Color c)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x2542884", Offset = "0x2542884", VA = "0x2542884")]
		public static Color ToColor(JSONObject obj)
		{
			return default(Color);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2542A8C", Offset = "0x2542A8C", VA = "0x2542A8C")]
		public static JSONObject FromLayerMask(LayerMask l)
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2542B34", Offset = "0x2542B34", VA = "0x2542B34")]
		public static LayerMask ToLayerMask(JSONObject obj)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x2542BD0", Offset = "0x2542BD0", VA = "0x2542BD0")]
		public static JSONObject FromRect(Rect r)
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2542D6C", Offset = "0x2542D6C", VA = "0x2542D6C")]
		public static Rect ToRect(JSONObject obj)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2542F74", Offset = "0x2542F74", VA = "0x2542F74")]
		public static JSONObject FromRectOffset(RectOffset r)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2543108", Offset = "0x2543108", VA = "0x2543108")]
		public static RectOffset ToRectOffset(JSONObject obj)
		{
			return null;
		}
	}
}
namespace Crosstales.BadWord
{
	[Token(Token = "0x2000084")]
	public class BadWordFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32708", Offset = "0xA32708")]
		private sealed class <>c
		{
			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__21_0;

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x27A9604", Offset = "0x27A9604", VA = "0x27A9604")]
			public <>c()
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x27A960C", Offset = "0x27A960C", VA = "0x27A960C")]
			internal string <GetAll>b__21_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<BadWordProvider> badWordProviderLTR;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<BadWordProvider> badWordProviderRTL;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string ReplaceCharacters;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool Fuzzy;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<BadWordProvider> tempBadWordProviderLTR;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<BadWordProvider> tempBadWordProviderRTL;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, Regex> exactBadwordsRegex;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, Regex> fuzzyBadwordsRegex;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, List<Regex>> debugFuzzyBadwordsRegex;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool isReady;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool isReadyFirstime;

		[Token(Token = "0x17000061")]
		public List<BadWordProvider> BadWordProviderLTR
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x1E11734", Offset = "0x1E11734", VA = "0x1E11734")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1E1173C", Offset = "0x1E1173C", VA = "0x1E1173C")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1E11B18", Offset = "0x1E11B18", VA = "0x1E11B18")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1E11B20", Offset = "0x1E11B20", VA = "0x1E11B20")]
			set
			{
			}
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1E11EFC", Offset = "0x1E11EFC", VA = "0x1E11EFC")]
		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters, bool fuzzy, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1E12034", Offset = "0x1E12034", VA = "0x1E12034", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1E127C4", Offset = "0x1E127C4", VA = "0x1E127C4", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1E13E40", Offset = "0x1E13E40", VA = "0x1E13E40", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1E17E9C", Offset = "0x1E17E9C", VA = "0x1E17E9C", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1E1C184", Offset = "0x1E1C184", VA = "0x1E1C184", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x2000086")]
	public class CapitalizationFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32718", Offset = "0xA32718")]
		private sealed class <>c
		{
			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x27AA504", Offset = "0x27AA504", VA = "0x27AA504")]
			public <>c()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x27AA50C", Offset = "0x27AA50C", VA = "0x27AA50C")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32B08", Offset = "0xA32B08")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000063")]
		public Regex RegularExpression
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x1E208D4", Offset = "0x1E208D4", VA = "0x1E208D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34F6C", Offset = "0xA34F6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1E208DC", Offset = "0x1E208DC", VA = "0x1E208DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34F7C", Offset = "0xA34F7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public int CharacterNumber
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1E208E4", Offset = "0x1E208E4", VA = "0x1E208E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1E208EC", Offset = "0x1E208EC", VA = "0x1E208EC")]
			set
			{
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1E209B4", Offset = "0x1E209B4", VA = "0x1E209B4")]
		public CapitalizationFilter(int capitalizationCharsNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1E209FC", Offset = "0x1E209FC", VA = "0x1E209FC", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1E20A04", Offset = "0x1E20A04", VA = "0x1E20A04", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1E20A70", Offset = "0x1E20A70", VA = "0x1E20A70", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1E211D4", Offset = "0x1E211D4", VA = "0x1E211D4", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1E217FC", Offset = "0x1E217FC", VA = "0x1E217FC", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	public class DomainFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32728", Offset = "0xA32728")]
		private sealed class <>c
		{
			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__13_0;

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x26B1CBC", Offset = "0x26B1CBC", VA = "0x26B1CBC")]
			public <>c()
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x26B1CC4", Offset = "0x26B1CC4", VA = "0x26B1CC4")]
			internal string <GetAll>b__13_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<DomainProvider> domainProvider;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string ReplaceCharacters;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<DomainProvider> tempDomainProvider;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> domainsRegex;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, List<Regex>> debugDomainsRegex;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isReady;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool isReadyFirstime;

		[Token(Token = "0x17000065")]
		public List<DomainProvider> DomainProvider
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1BEB4D8", Offset = "0x1BEB4D8", VA = "0x1BEB4D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1BEB4E0", Offset = "0x1BEB4E0", VA = "0x1BEB4E0")]
			set
			{
			}
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1BEB844", Offset = "0x1BEB844", VA = "0x1BEB844")]
		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1BEB9D4", Offset = "0x1BEB9D4", VA = "0x1BEB9D4", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1BEBE3C", Offset = "0x1BEBE3C", VA = "0x1BEBE3C", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1BECB9C", Offset = "0x1BECB9C", VA = "0x1BECB9C", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1BEEE58", Offset = "0x1BEEE58", VA = "0x1BEEE58", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1BF1330", Offset = "0x1BF1330", VA = "0x1BF1330", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	public abstract class Filter
	{
		[Serializable]
		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32738", Offset = "0xA32738")]
		private sealed class <>c
		{
			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, Source>, string> <>9__8_0;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, Source>, Source> <>9__8_1;

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x26B2BB8", Offset = "0x26B2BB8", VA = "0x26B2BB8")]
			public <>c()
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x26B2BC0", Offset = "0x26B2BC0", VA = "0x26B2BC0")]
			internal string <Sources>b__8_0(KeyValuePair<string, Source> x)
			{
				return null;
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x26B2C00", Offset = "0x26B2C00", VA = "0x26B2C00")]
			internal Source <Sources>b__8_1(KeyValuePair<string, Source> y)
			{
				return null;
			}
		}

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string MarkPrefix;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MarkPostfix;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, Source> sources;

		[Token(Token = "0x60004A0")]
		public abstract bool Ready();

		[Token(Token = "0x60004A1")]
		public abstract bool Contains(string testString, params string[] sources);

		[Token(Token = "0x60004A2")]
		public abstract List<string> GetAll(string testString, params string[] sources);

		[Token(Token = "0x60004A3")]
		public abstract string ReplaceAll(string testString, params string[] sources);

		[Token(Token = "0x60004A4")]
		public abstract string Replace(string text, List<string> badWords);

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1BF3A70", Offset = "0x1BF3A70", VA = "0x1BF3A70", Slot = "9")]
		public virtual List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1BF3CE8", Offset = "0x1BF3CE8", VA = "0x1BF3CE8", Slot = "10")]
		public virtual string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1BF3EF8", Offset = "0x1BF3EF8", VA = "0x1BF3EF8", Slot = "11")]
		public virtual string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1BECB28", Offset = "0x1BECB28", VA = "0x1BECB28")]
		protected void logFilterNotReady()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1BECB24", Offset = "0x1BECB24", VA = "0x1BECB24")]
		protected void logResourceNotFound(string res)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1BECB20", Offset = "0x1BECB20", VA = "0x1BECB20")]
		protected void logContains()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1BEEE54", Offset = "0x1BEEE54", VA = "0x1BEEE54")]
		protected void logGetAll()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1BF1194", Offset = "0x1BF1194", VA = "0x1BF1194")]
		protected void logReplaceAll()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1BEB924", Offset = "0x1BEB924", VA = "0x1BEB924")]
		protected Filter()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class PunctuationFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32748", Offset = "0xA32748")]
		private sealed class <>c
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x26B6D34", Offset = "0x26B6D34", VA = "0x26B6D34")]
			public <>c()
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x26B6D3C", Offset = "0x26B6D3C", VA = "0x26B6D3C")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32B18", Offset = "0xA32B18")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000066")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x279D7B8", Offset = "0x279D7B8", VA = "0x279D7B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34F8C", Offset = "0xA34F8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x279D7C0", Offset = "0x279D7C0", VA = "0x279D7C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34F9C", Offset = "0xA34F9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public int CharacterNumber
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x279D7C8", Offset = "0x279D7C8", VA = "0x279D7C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x279D7D0", Offset = "0x279D7D0", VA = "0x279D7D0")]
			set
			{
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x279D898", Offset = "0x279D898", VA = "0x279D898")]
		public PunctuationFilter(int punctuationCharacterNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x279D8E0", Offset = "0x279D8E0", VA = "0x279D8E0", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x279D8E8", Offset = "0x279D8E8", VA = "0x279D8E8", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x279D954", Offset = "0x279D954", VA = "0x279D954", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x279E0B8", Offset = "0x279E0B8", VA = "0x279E0B8", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x279E6D8", Offset = "0x279E6D8", VA = "0x279E6D8", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	public class BadWordManager : Manager
	{
		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32758", Offset = "0xA32758")]
		private sealed class <initalize>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordManager <>4__this;

			[Token(Token = "0x17000068")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D0")]
				[Address(RVA = "0x27A9868", Offset = "0x27A9868", VA = "0x27A9868", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000069")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D2")]
				[Address(RVA = "0x27A98B0", Offset = "0x27A98B0", VA = "0x27A98B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x27A9614", Offset = "0x27A9614", VA = "0x27A9614")]
			[DebuggerHidden]
			public <initalize>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x27A9640", Offset = "0x27A9640", VA = "0x27A9640", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x27A9644", Offset = "0x27A9644", VA = "0x27A9644", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x27A9870", Offset = "0x27A9870", VA = "0x27A9870", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32B28", Offset = "0xA32B28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32B28", Offset = "0xA32B28")]
		public List<BadWordProvider> BadWordProviderLTR;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32B88", Offset = "0xA32B88")]
		public List<BadWordProvider> BadWordProviderRTL;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32BC0", Offset = "0xA32BC0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32BC0", Offset = "0xA32BC0")]
		public string ReplaceChars;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32C20", Offset = "0xA32C20")]
		public bool Fuzzy;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BadWordFilter filter;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000339")]
		private const string clazz = "BadWordManager";

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1E1C478", Offset = "0x1E1C478", VA = "0x1E1C478")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1E1C650", Offset = "0x1E1C650", VA = "0x1E1C650")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA34FAC", Offset = "0xA34FAC")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1E1C6BC", Offset = "0x1E1C6BC", VA = "0x1E1C6BC")]
		public static BadWordFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1E1C720", Offset = "0x1E1C720", VA = "0x1E1C720")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1E1CA48", Offset = "0x1E1CA48", VA = "0x1E1CA48")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1E1CB68", Offset = "0x1E1CB68", VA = "0x1E1CB68")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1E1CC68", Offset = "0x1E1CC68", VA = "0x1E1CC68")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1E1CDA4", Offset = "0x1E1CDA4", VA = "0x1E1CDA4")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1E1CEA4", Offset = "0x1E1CEA4", VA = "0x1E1CEA4")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1E1CFA4", Offset = "0x1E1CFA4", VA = "0x1E1CFA4")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1E1D0C0", Offset = "0x1E1D0C0", VA = "0x1E1D0C0")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1E1C804", Offset = "0x1E1C804", VA = "0x1E1C804")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1E1D1C8", Offset = "0x1E1D1C8", VA = "0x1E1D1C8")]
		public BadWordManager()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class CapitalizationManager : Manager
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32C58", Offset = "0xA32C58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32C58", Offset = "0xA32C58")]
		public int CapitalizationCharsNumber;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CapitalizationFilter filter;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000342")]
		private const string clazz = "CapitalizationManager";

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1E21AA0", Offset = "0x1E21AA0", VA = "0x1E21AA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1E21D88", Offset = "0x1E21D88", VA = "0x1E21D88")]
		public static CapitalizationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1E21DEC", Offset = "0x1E21DEC", VA = "0x1E21DEC")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1E21E60", Offset = "0x1E21E60", VA = "0x1E21E60")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1E221C4", Offset = "0x1E221C4", VA = "0x1E221C4")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1E222C4", Offset = "0x1E222C4", VA = "0x1E222C4")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1E22400", Offset = "0x1E22400", VA = "0x1E22400")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1E22500", Offset = "0x1E22500", VA = "0x1E22500")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1E22600", Offset = "0x1E22600", VA = "0x1E22600")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1E2271C", Offset = "0x1E2271C", VA = "0x1E2271C")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1E21F80", Offset = "0x1E21F80", VA = "0x1E21F80")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1E22824", Offset = "0x1E22824", VA = "0x1E22824")]
		public CapitalizationManager()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class DomainManager : Manager
	{
		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32768", Offset = "0xA32768")]
		private sealed class <initalize>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainManager <>4__this;

			[Token(Token = "0x1700006A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004F1")]
				[Address(RVA = "0x26B1F08", Offset = "0x26B1F08", VA = "0x26B1F08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004F3")]
				[Address(RVA = "0x26B1F50", Offset = "0x26B1F50", VA = "0x26B1F50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x26B1CCC", Offset = "0x26B1CCC", VA = "0x26B1CCC")]
			[DebuggerHidden]
			public <initalize>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x26B1CF8", Offset = "0x26B1CF8", VA = "0x26B1CF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x26B1CFC", Offset = "0x26B1CFC", VA = "0x26B1CFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x26B1F10", Offset = "0x26B1F10", VA = "0x26B1F10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32CB8", Offset = "0xA32CB8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32CB8", Offset = "0xA32CB8")]
		public List<DomainProvider> DomainProvider;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32D18", Offset = "0xA32D18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32D18", Offset = "0xA32D18")]
		public string ReplaceChars;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DomainFilter filter;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000349")]
		private const string clazz = "DomainManager";

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1BF1620", Offset = "0x1BF1620", VA = "0x1BF1620")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1BF17F8", Offset = "0x1BF17F8", VA = "0x1BF17F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3505C", Offset = "0xA3505C")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1BF1864", Offset = "0x1BF1864", VA = "0x1BF1864")]
		public static DomainFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1BF18C8", Offset = "0x1BF18C8", VA = "0x1BF18C8")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1BF1BF0", Offset = "0x1BF1BF0", VA = "0x1BF1BF0")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1BF1D10", Offset = "0x1BF1D10", VA = "0x1BF1D10")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1BF1E10", Offset = "0x1BF1E10", VA = "0x1BF1E10")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1BF1F4C", Offset = "0x1BF1F4C", VA = "0x1BF1F4C")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1BF204C", Offset = "0x1BF204C", VA = "0x1BF204C")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1BF214C", Offset = "0x1BF214C", VA = "0x1BF214C")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1BF2268", Offset = "0x1BF2268", VA = "0x1BF2268")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1BF19AC", Offset = "0x1BF19AC", VA = "0x1BF19AC")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1BF2370", Offset = "0x1BF2370", VA = "0x1BF2370")]
		public DomainManager()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public abstract class Manager : MonoBehaviour
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32D78", Offset = "0xA32D78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32D78", Offset = "0xA32D78")]
		public string MarkPrefix;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32DD8", Offset = "0xA32DD8")]
		public string MarkPostfix;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x211B098", Offset = "0x211B098", VA = "0x211B098")]
		protected Manager()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class PunctuationManager : Manager
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32E10", Offset = "0xA32E10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32E10", Offset = "0xA32E10")]
		public int PunctuationCharsNumber;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PunctuationFilter filter;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000354")]
		private const string clazz = "PunctuationManager";

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x279E98C", Offset = "0x279E98C", VA = "0x279E98C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x279EC74", Offset = "0x279EC74", VA = "0x279EC74")]
		public static PunctuationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x279ECD8", Offset = "0x279ECD8", VA = "0x279ECD8")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x279ED4C", Offset = "0x279ED4C", VA = "0x279ED4C")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x279F0B0", Offset = "0x279F0B0", VA = "0x279F0B0")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x279F1B0", Offset = "0x279F1B0", VA = "0x279F1B0")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x279F2EC", Offset = "0x279F2EC", VA = "0x279F2EC")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x279F3EC", Offset = "0x279F3EC", VA = "0x279F3EC")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x279F4EC", Offset = "0x279F4EC", VA = "0x279F4EC")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x279F608", Offset = "0x279F608", VA = "0x279F608")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x279EE6C", Offset = "0x279EE6C", VA = "0x279EE6C")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x279F710", Offset = "0x279F710", VA = "0x279F710")]
		public PunctuationManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class BadWords
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Source Source;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> BadWordList;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1E1E4E4", Offset = "0x1E1E4E4", VA = "0x1E1E4E4")]
		public BadWords(Source source, List<string> badWordList)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1E1E51C", Offset = "0x1E1E51C", VA = "0x1E1E51C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class Domains
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Source Source;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> DomainList;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1BF34F0", Offset = "0x1BF34F0", VA = "0x1BF34F0")]
		public Domains(Source source, List<string> domainList)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1BF3528", Offset = "0x1BF3528", VA = "0x1BF3528", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public abstract class Source
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32E70", Offset = "0xA32E70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32E70", Offset = "0xA32E70")]
		public string Name;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32ED0", Offset = "0xA32ED0")]
		public string Description;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32F08", Offset = "0xA32F08")]
		public Sprite Icon;

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x27A1344", Offset = "0x27A1344", VA = "0x27A1344", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x27A1518", Offset = "0x27A1518", VA = "0x27A1518")]
		protected Source()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public static class MultiManager
	{
		[Serializable]
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32778", Offset = "0xA32778")]
		private sealed class <>c
		{
			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Source, string> <>9__2_0;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, string> <>9__4_0;

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x26B6CAC", Offset = "0x26B6CAC", VA = "0x26B6CAC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x26B6CB4", Offset = "0x26B6CB4", VA = "0x26B6CB4")]
			internal string <Sources>b__2_0(Source x)
			{
				return null;
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x26B6CCC", Offset = "0x26B6CCC", VA = "0x26B6CCC")]
			internal string <GetAll>b__4_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x211D228", Offset = "0x211D228", VA = "0x211D228")]
		public static Filter Filter(ManagerMask mask = ManagerMask.BadWord)
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x211D42C", Offset = "0x211D42C", VA = "0x211D42C")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x211D540", Offset = "0x211D540", VA = "0x211D540")]
		public static List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x211D82C", Offset = "0x211D82C", VA = "0x211D82C")]
		public static bool Contains(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x211DAD0", Offset = "0x211DAD0", VA = "0x211DAD0")]
		public static List<string> GetAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x211DE10", Offset = "0x211DE10", VA = "0x211DE10")]
		public static string ReplaceAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x211DFAC", Offset = "0x211DFAC", VA = "0x211DFAC")]
		public static string Replace(string text, List<string> badWords, ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x211E148", Offset = "0x211E148", VA = "0x211E148")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x211E1F8", Offset = "0x211E1F8", VA = "0x211E1F8")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class BadWordProvider : Provider
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> exactBadwordsRegex;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, Regex> fuzzyBadwordsRegex;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, List<Regex>> debugFuzzyBadwordsRegex;

		[Token(Token = "0x4000365")]
		protected const string exactRegexStart = "(?<![\\w\\d])";

		[Token(Token = "0x4000366")]
		protected const string exactRegexEnd = "s?(?![\\w\\d])";

		[Token(Token = "0x4000367")]
		protected const string fuzzyRegexStart = "\\b\\w*";

		[Token(Token = "0x4000368")]
		protected const string fuzzyRegexEnd = "\\w*\\b";

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<BadWords> badwords;

		[Token(Token = "0x1700006C")]
		public Dictionary<string, Regex> ExactBadwordsRegex
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1E1D220", Offset = "0x1E1D220", VA = "0x1E1D220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1E1D228", Offset = "0x1E1D228", VA = "0x1E1D228")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Dictionary<string, Regex> FuzzyBadwordsRegex
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1E1D230", Offset = "0x1E1D230", VA = "0x1E1D230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1E1D238", Offset = "0x1E1D238", VA = "0x1E1D238")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1E1D240", Offset = "0x1E1D240", VA = "0x1E1D240")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x1E1D248", Offset = "0x1E1D248", VA = "0x1E1D248")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Dictionary<string, List<Regex>> DebugFuzzyBadwordsRegex
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x1E1D250", Offset = "0x1E1D250", VA = "0x1E1D250")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x1E1D258", Offset = "0x1E1D258", VA = "0x1E1D258")]
			protected set
			{
			}
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1E1D260", Offset = "0x1E1D260", VA = "0x1E1D260", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1E1DE4C", Offset = "0x1E1DE4C", VA = "0x1E1DE4C")]
		protected BadWordProvider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class BadWordFile : Source
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32F40", Offset = "0xA32F40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA32F40", Offset = "0xA32F40")]
		public string File;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32FA0", Offset = "0xA32FA0")]
		public int SkipHeaderLines;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA32FD8", Offset = "0xA32FD8")]
		public int SkipFooterLines;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33010", Offset = "0xA33010")]
		public char SplitChar;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1E116D0", Offset = "0x1E116D0", VA = "0x1E116D0")]
		public BadWordFile()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class BadWordProviderFile : BadWordProvider
	{
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32788", Offset = "0xA32788")]
		private sealed class <loadFile>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000527")]
				[Address(RVA = "0x27A991C", Offset = "0x27A991C", VA = "0x27A991C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000529")]
				[Address(RVA = "0x27A9964", Offset = "0x27A9964", VA = "0x27A9964", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x27A98B8", Offset = "0x27A98B8", VA = "0x27A98B8")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0x27A98E4", Offset = "0x27A98E4", VA = "0x27A98E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x27A98E8", Offset = "0x27A98E8", VA = "0x27A98E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x27A9924", Offset = "0x27A9924", VA = "0x27A9924", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA33048", Offset = "0xA33048")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33048", Offset = "0xA33048")]
		public string FilePathWindows;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA330A8", Offset = "0xA330A8")]
		public string FilePathOSX;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA330E0", Offset = "0xA330E0")]
		public string FilePathLinux;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33118", Offset = "0xA33118")]
		public BadWordFile[] Resources;

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1E1DFA8", Offset = "0x1E1DFA8", VA = "0x1E1DFA8", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1E1E0BC", Offset = "0x1E1E0BC", VA = "0x1E1E0BC", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1E1E130", Offset = "0x1E1E130", VA = "0x1E1E130")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3510C", Offset = "0xA3510C")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1E1E18C", Offset = "0x1E1E18C", VA = "0x1E1E18C")]
		public BadWordProviderFile()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class BadWordResource : Source
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA33150", Offset = "0xA33150")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33150", Offset = "0xA33150")]
		public TextAsset Resource;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA331B0", Offset = "0xA331B0")]
		public int SkipHeaderLines;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA331E8", Offset = "0xA331E8")]
		public int SkipFooterLines;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33220", Offset = "0xA33220")]
		public char SplitChar;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1E1E470", Offset = "0x1E1E470", VA = "0x1E1E470")]
		public BadWordResource()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class BadWordProviderResource : BadWordProvider
	{
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32798", Offset = "0xA32798")]
		private sealed class <loadResource>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordProviderResource <>4__this;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BadWordResource[] <>7__wrap1;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x17000072")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x27A9CFC", Offset = "0x27A9CFC", VA = "0x27A9CFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000534")]
				[Address(RVA = "0x27A9D44", Offset = "0x27A9D44", VA = "0x27A9D44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x27A996C", Offset = "0x27A996C", VA = "0x27A996C")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x27A9998", Offset = "0x27A9998", VA = "0x27A9998", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x27A999C", Offset = "0x27A999C", VA = "0x27A999C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x27A9D04", Offset = "0x27A9D04", VA = "0x27A9D04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33258", Offset = "0xA33258")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA33258", Offset = "0xA33258")]
		public BadWordResource[] Resources;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1E1E1FC", Offset = "0x1E1E1FC", VA = "0x1E1E1FC", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1E1E294", Offset = "0x1E1E294", VA = "0x1E1E294", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1E1E228", Offset = "0x1E1E228", VA = "0x1E1E228")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA351BC", Offset = "0xA351BC")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1E1E308", Offset = "0x1E1E308", VA = "0x1E1E308")]
		public BadWordProviderResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class BadWordWeb : Source
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA332B8", Offset = "0xA332B8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA332B8", Offset = "0xA332B8")]
		public string URL;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33318", Offset = "0xA33318")]
		public int SkipHeaderLines;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33350", Offset = "0xA33350")]
		public int SkipFooterLines;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33388", Offset = "0xA33388")]
		public char SplitChar;

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1E1E480", Offset = "0x1E1E480", VA = "0x1E1E480")]
		public BadWordWeb()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class BadWordProviderWeb : BadWordProvider
	{
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA327A8", Offset = "0xA327A8")]
		private sealed class <loadWeb>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordProviderWeb <>4__this;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BadWordWeb[] <>7__wrap1;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private BadWordWeb <res>5__4;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWWwrapper <www>5__5;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600053D")]
				[Address(RVA = "0x27AA454", Offset = "0x27AA454", VA = "0x27AA454", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600053F")]
				[Address(RVA = "0x27AA49C", Offset = "0x27AA49C", VA = "0x27AA49C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x27A9D4C", Offset = "0x27A9D4C", VA = "0x27A9D4C")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x27A9D78", Offset = "0x27A9D78", VA = "0x27A9D78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0x27A9D7C", Offset = "0x27A9D7C", VA = "0x27A9D7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0x27AA45C", Offset = "0x27AA45C", VA = "0x27AA45C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA333C0", Offset = "0xA333C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA333C0", Offset = "0xA333C0")]
		public string MainURL;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33420", Offset = "0xA33420")]
		public BadWordWeb[] Resources;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1E1E30C", Offset = "0x1E1E30C", VA = "0x1E1E30C", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1E1E3A4", Offset = "0x1E1E3A4", VA = "0x1E1E3A4", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1E1E338", Offset = "0x1E1E338", VA = "0x1E1E338")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3526C", Offset = "0xA3526C")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1E1E418", Offset = "0x1E1E418", VA = "0x1E1E418")]
		public BadWordProviderWeb()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public abstract class DomainProvider : Provider
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> domainsRegex;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, List<Regex>> debugDomainsRegex;

		[Token(Token = "0x400038D")]
		private const string domainRegexStart = "\\b{0,1}((ht|f)tp(s?)\\:\\/\\/)?[\\w\\-\\.\\@]*[\\.]";

		[Token(Token = "0x400038E")]
		private const string domainRegexEnd = "(:(0-9)*)?(\\/|\\b)([a-zA-Z0-9\\-\\.\\?\\!\\,\\=\\'\\/\\&\\%#_]*)?\\b";

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected List<Domains> domains;

		[Token(Token = "0x17000076")]
		public Dictionary<string, Regex> DomainsRegex
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1BF23C8", Offset = "0x1BF23C8", VA = "0x1BF23C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x1BF23D0", Offset = "0x1BF23D0", VA = "0x1BF23D0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x1BF23D8", Offset = "0x1BF23D8", VA = "0x1BF23D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x1BF23E0", Offset = "0x1BF23E0", VA = "0x1BF23E0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1BF23E8", Offset = "0x1BF23E8", VA = "0x1BF23E8", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1BF2DE4", Offset = "0x1BF2DE4", VA = "0x1BF2DE4")]
		protected DomainProvider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class DomainFile : Source
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA33458", Offset = "0xA33458")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33458", Offset = "0xA33458")]
		public string File;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA334B8", Offset = "0xA334B8")]
		public int SkipHeaderLines;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA334F0", Offset = "0xA334F0")]
		public int SkipFooterLines;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33528", Offset = "0xA33528")]
		public char SplitChar;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1BEB474", Offset = "0x1BEB474", VA = "0x1BEB474")]
		public DomainFile()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class DomainProviderFile : DomainProvider
	{
		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA327B8", Offset = "0xA327B8")]
		private sealed class <loadFile>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0x26B1FBC", Offset = "0x26B1FBC", VA = "0x26B1FBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000550")]
				[Address(RVA = "0x26B2004", Offset = "0x26B2004", VA = "0x26B2004", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x26B1F58", Offset = "0x26B1F58", VA = "0x26B1F58")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x26B1F84", Offset = "0x26B1F84", VA = "0x26B1F84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x26B1F88", Offset = "0x26B1F88", VA = "0x26B1F88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x26B1FC4", Offset = "0x26B1FC4", VA = "0x26B1FC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA33560", Offset = "0xA33560")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33560", Offset = "0xA33560")]
		public string FilePathWindows;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA335C0", Offset = "0xA335C0")]
		public string FilePathOSX;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA335F8", Offset = "0xA335F8")]
		public string FilePathLinux;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33630", Offset = "0xA33630")]
		public DomainFile[] Resources;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1BF2F08", Offset = "0x1BF2F08", VA = "0x1BF2F08", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1BF30C8", Offset = "0x1BF30C8", VA = "0x1BF30C8", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1BF313C", Offset = "0x1BF313C", VA = "0x1BF313C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3531C", Offset = "0xA3531C")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1BF3198", Offset = "0x1BF3198", VA = "0x1BF3198")]
		public DomainProviderFile()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class DomainResource : Source
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA33668", Offset = "0xA33668")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33668", Offset = "0xA33668")]
		public TextAsset Resource;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA336C8", Offset = "0xA336C8")]
		public int SkipHeaderLines;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33700", Offset = "0xA33700")]
		public int SkipFooterLines;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33738", Offset = "0xA33738")]
		public char SplitChar;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1BF347C", Offset = "0x1BF347C", VA = "0x1BF347C")]
		public DomainResource()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class DomainProviderResource : DomainProvider
	{
		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA327C8", Offset = "0xA327C8")]
		private sealed class <loadResource>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainProviderResource <>4__this;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DomainResource[] <>7__wrap1;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000559")]
				[Address(RVA = "0x26B23A0", Offset = "0x26B23A0", VA = "0x26B23A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055B")]
				[Address(RVA = "0x26B23E8", Offset = "0x26B23E8", VA = "0x26B23E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x26B200C", Offset = "0x26B200C", VA = "0x26B200C")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x26B2038", Offset = "0x26B2038", VA = "0x26B2038", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0x26B203C", Offset = "0x26B203C", VA = "0x26B203C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x26B23A8", Offset = "0x26B23A8", VA = "0x26B23A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA33770", Offset = "0xA33770")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33770", Offset = "0xA33770")]
		public DomainResource[] Resources;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1BF3208", Offset = "0x1BF3208", VA = "0x1BF3208", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1BF32A0", Offset = "0x1BF32A0", VA = "0x1BF32A0", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1BF3234", Offset = "0x1BF3234", VA = "0x1BF3234")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA353CC", Offset = "0xA353CC")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1BF3314", Offset = "0x1BF3314", VA = "0x1BF3314")]
		public DomainProviderResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class DomainWeb : Source
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA337D0", Offset = "0xA337D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA337D0", Offset = "0xA337D0")]
		public string URL;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33830", Offset = "0xA33830")]
		public int SkipHeaderLines;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33868", Offset = "0xA33868")]
		public int SkipFooterLines;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA338A0", Offset = "0xA338A0")]
		public char SplitChar;

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1BF348C", Offset = "0x1BF348C", VA = "0x1BF348C")]
		public DomainWeb()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class DomainProviderWeb : DomainProvider
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA327D8", Offset = "0xA327D8")]
		private sealed class <loadWeb>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainProviderWeb <>4__this;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DomainWeb[] <>7__wrap1;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private DomainWeb <res>5__4;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWWwrapper <www>5__5;

			[Token(Token = "0x1700007C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000564")]
				[Address(RVA = "0x26B2B08", Offset = "0x26B2B08", VA = "0x26B2B08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000566")]
				[Address(RVA = "0x26B2B50", Offset = "0x26B2B50", VA = "0x26B2B50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0x26B23F0", Offset = "0x26B23F0", VA = "0x26B23F0")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0x26B241C", Offset = "0x26B241C", VA = "0x26B241C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0x26B2420", Offset = "0x26B2420", VA = "0x26B2420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0x26B2B10", Offset = "0x26B2B10", VA = "0x26B2B10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA338D8", Offset = "0xA338D8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA338D8", Offset = "0xA338D8")]
		public string MainURL;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33938", Offset = "0xA33938")]
		public DomainWeb[] Resources;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1BF3318", Offset = "0x1BF3318", VA = "0x1BF3318", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1BF33B0", Offset = "0x1BF33B0", VA = "0x1BF33B0", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1BF3344", Offset = "0x1BF3344", VA = "0x1BF3344")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3547C", Offset = "0xA3547C")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1BF3424", Offset = "0x1BF3424", VA = "0x1BF3424")]
		public DomainProviderWeb()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public abstract class Provider : MonoBehaviour
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33970", Offset = "0xA33970")]
		public string Name;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA339A8", Offset = "0xA339A8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA339A8", Offset = "0xA339A8")]
		public RegexOptions RegexOption1;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33A08", Offset = "0xA33A08")]
		public RegexOptions RegexOption2;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33A40", Offset = "0xA33A40")]
		public RegexOptions RegexOption3;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33A78", Offset = "0xA33A78")]
		public RegexOptions RegexOption4;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33AB0", Offset = "0xA33AB0")]
		public RegexOptions RegexOption5;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool ready;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static bool loggedUnsupportedPlatform;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Source> sources;

		[Token(Token = "0x1700007E")]
		public bool Ready
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x279D4F0", Offset = "0x279D4F0", VA = "0x279D4F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x279D4F8", Offset = "0x279D4F8", VA = "0x279D4F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public List<Source> Sources
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x279D504", Offset = "0x279D504", VA = "0x279D504")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x279D50C", Offset = "0x279D50C", VA = "0x279D50C")]
			protected set
			{
			}
		}

		[Token(Token = "0x600056B")]
		public abstract void Load();

		[Token(Token = "0x600056C")]
		public abstract void Save();

		[Token(Token = "0x600056D")]
		protected abstract void init();

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x279D514", Offset = "0x279D514", VA = "0x279D514")]
		public void Awake()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x279D520", Offset = "0x279D520", VA = "0x279D520")]
		protected void logNoResourcesAdded()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x279D70C", Offset = "0x279D70C", VA = "0x279D70C")]
		protected Provider()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public static class Constants
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string ASSET_NAME;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string ASSET_VERSION;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ASSET_BUILD;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly string ASSET_AUTHOR;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly string ASSET_AUTHOR_URL;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly string ASSET_URL;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly string ASSET_CONTACT;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly Guid ASSET_UID;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly string PREFAB_PATH;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly bool DEBUG_BADWORDS;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public static readonly bool DEBUG_DOMAINS;
	}
	[Token(Token = "0x20000B0")]
	public static class Helper
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex lineEndingsRegex;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Random rd;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1BF4024", Offset = "0x1BF4024", VA = "0x1BF4024")]
		public static bool WindowsPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1BF405C", Offset = "0x1BF405C", VA = "0x1BF405C")]
		public static bool OSXPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1BF408C", Offset = "0x1BF408C", VA = "0x1BF408C")]
		public static bool LinuxPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1BF3018", Offset = "0x1BF3018", VA = "0x1BF3018")]
		public static bool SupportedPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1BF40AC", Offset = "0x1BF40AC", VA = "0x1BF40AC")]
		public static string ValidatePath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1BF4150", Offset = "0x1BF4150", VA = "0x1BF4150")]
		public static List<string> SplitStringToLines(string text, int skipHeaderLines = 0, int skipFooterLines = 0, char splitChar = '#')
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1BF1198", Offset = "0x1BF1198", VA = "0x1BF1198")]
		public static string CreateReplaceString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		public static void AddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1BF4408", Offset = "0x1BF4408", VA = "0x1BF4408")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}
	}
}
namespace CodeStage.AntiCheat.Utils
{
	[Token(Token = "0x20000B1")]
	internal class xxHash
	{
		[Token(Token = "0x40003C9")]
		private const uint PRIME32_1 = 2654435761u;

		[Token(Token = "0x40003CA")]
		private const uint PRIME32_2 = 2246822519u;

		[Token(Token = "0x40003CB")]
		private const uint PRIME32_3 = 3266489917u;

		[Token(Token = "0x40003CC")]
		private const uint PRIME32_4 = 668265263u;

		[Token(Token = "0x40003CD")]
		private const uint PRIME32_5 = 374761393u;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x27A9008", Offset = "0x27A9008", VA = "0x27A9008")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return default(uint);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x27A93C8", Offset = "0x27A93C8", VA = "0x27A93C8")]
		public xxHash()
		{
		}
	}
}
namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	[Token(Token = "0x20000B2")]
	public struct ObscuredBool : IEquatable<ObscuredBool>
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private byte currentCryptoKey;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool fakeValue;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		[SerializeField]
		private bool fakeValueChanged;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x211E298", Offset = "0x211E298", VA = "0x211E298")]
		private ObscuredBool(int value)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x211E320", Offset = "0x211E320", VA = "0x211E320")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x211E388", Offset = "0x211E388", VA = "0x211E388")]
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x211E3EC", Offset = "0x211E3EC", VA = "0x211E3EC")]
		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x211E480", Offset = "0x211E480", VA = "0x211E480")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x211E4E4", Offset = "0x211E4E4", VA = "0x211E4E4")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x211E570", Offset = "0x211E570", VA = "0x211E570")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x211E758", Offset = "0x211E758", VA = "0x211E758")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x211E7F0", Offset = "0x211E7F0", VA = "0x211E7F0")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x211E814", Offset = "0x211E814", VA = "0x211E814")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x211E63C", Offset = "0x211E63C", VA = "0x211E63C")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x211E8BC", Offset = "0x211E8BC", VA = "0x211E8BC")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x211E964", Offset = "0x211E964", VA = "0x211E964")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x211E990", Offset = "0x211E990", VA = "0x211E990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x211EA1C", Offset = "0x211EA1C", VA = "0x211EA1C", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x211EACC", Offset = "0x211EACC", VA = "0x211EACC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x211EAFC", Offset = "0x211EAFC", VA = "0x211EAFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public struct ObscuredByte : IEquatable<ObscuredByte>, IFormattable
	{
		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte currentCryptoKey;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte hiddenValue;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private byte fakeValue;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private bool inited;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x211EB7C", Offset = "0x211EB7C", VA = "0x211EB7C")]
		private ObscuredByte(byte value)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x211EC00", Offset = "0x211EC00", VA = "0x211EC00")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x211EC68", Offset = "0x211EC68", VA = "0x211EC68")]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x211ECCC", Offset = "0x211ECCC", VA = "0x211ECCC")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x211ED4C", Offset = "0x211ED4C", VA = "0x211ED4C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x211EF50", Offset = "0x211EF50", VA = "0x211EF50")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x211EFE8", Offset = "0x211EFE8", VA = "0x211EFE8")]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x211F00C", Offset = "0x211F00C", VA = "0x211F00C")]
		public void SetEncrypted(byte encrypted)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x211EE18", Offset = "0x211EE18", VA = "0x211EE18")]
		private byte InternalDecrypt()
		{
			return default(byte);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x211F048", Offset = "0x211F048", VA = "0x211F048")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x211F0D4", Offset = "0x211F0D4", VA = "0x211F0D4")]
		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x211F0F8", Offset = "0x211F0F8", VA = "0x211F0F8")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x211F190", Offset = "0x211F190", VA = "0x211F190")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x211F228", Offset = "0x211F228", VA = "0x211F228", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x211F2B0", Offset = "0x211F2B0", VA = "0x211F2B0", Slot = "4")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x211F35C", Offset = "0x211F35C", VA = "0x211F35C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x211F388", Offset = "0x211F388", VA = "0x211F388")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x211F3BC", Offset = "0x211F3BC", VA = "0x211F3BC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x211F3E8", Offset = "0x211F3E8", VA = "0x211F3E8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x211F41C", Offset = "0x211F41C", VA = "0x211F41C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public struct ObscuredChar : IEquatable<ObscuredChar>
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static char cryptoKey;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private char currentCryptoKey;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private char hiddenValue;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private char fakeValue;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x211F4B0", Offset = "0x211F4B0", VA = "0x211F4B0")]
		private ObscuredChar(char value)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x211F538", Offset = "0x211F538", VA = "0x211F538")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x211F5A0", Offset = "0x211F5A0", VA = "0x211F5A0")]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x211F604", Offset = "0x211F604", VA = "0x211F604")]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x211F684", Offset = "0x211F684", VA = "0x211F684")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x211F88C", Offset = "0x211F88C", VA = "0x211F88C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x211F924", Offset = "0x211F924", VA = "0x211F924")]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x211F948", Offset = "0x211F948", VA = "0x211F948")]
		public void SetEncrypted(char encrypted)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x211F750", Offset = "0x211F750", VA = "0x211F750")]
		private char InternalDecrypt()
		{
			return default(char);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x211F984", Offset = "0x211F984", VA = "0x211F984")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x211FA10", Offset = "0x211FA10", VA = "0x211FA10")]
		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x211FA34", Offset = "0x211FA34", VA = "0x211FA34")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x211FACC", Offset = "0x211FACC", VA = "0x211FACC")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x211FB64", Offset = "0x211FB64", VA = "0x211FB64", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x211FBEC", Offset = "0x211FBEC", VA = "0x211FBEC", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x211FC94", Offset = "0x211FC94", VA = "0x211FC94", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x211FCC0", Offset = "0x211FCC0", VA = "0x211FCC0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x211FCF4", Offset = "0x211FCF4", VA = "0x211FCF4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x20000B6")]
		private struct DecimalLongBytesUnion
		{
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public decimal d;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l1;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long l2;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte b5;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte b6;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte b7;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte b8;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte b9;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte b10;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public byte b11;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			public byte b12;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public byte b13;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public byte b14;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public byte b15;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public byte b16;
		}

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long currentCryptoKey;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte[] hiddenValue;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private decimal fakeValue;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool inited;

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x212095C", Offset = "0x212095C", VA = "0x212095C")]
		private ObscuredDecimal(byte[] value)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x21209E0", Offset = "0x21209E0", VA = "0x21209E0")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2120A48", Offset = "0x2120A48", VA = "0x2120A48")]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2120AC4", Offset = "0x2120AC4", VA = "0x2120AC4")]
		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2120AD0", Offset = "0x2120AD0", VA = "0x2120AD0")]
		private static byte[] InternalEncrypt(decimal value)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2120B44", Offset = "0x2120B44", VA = "0x2120B44")]
		private static byte[] InternalEncrypt(decimal value, long key)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2120CF4", Offset = "0x2120CF4", VA = "0x2120CF4")]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2120D70", Offset = "0x2120D70", VA = "0x2120D70")]
		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2120D7C", Offset = "0x2120D7C", VA = "0x2120D7C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x21210D8", Offset = "0x21210D8", VA = "0x21210D8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2121178", Offset = "0x2121178", VA = "0x2121178")]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2121270", Offset = "0x2121270", VA = "0x2121270")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2120E4C", Offset = "0x2120E4C", VA = "0x2120E4C")]
		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x21213FC", Offset = "0x21213FC", VA = "0x21213FC")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x21214B8", Offset = "0x21214B8", VA = "0x21214B8")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x21214BC", Offset = "0x21214BC", VA = "0x21214BC")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x21215F4", Offset = "0x21215F4", VA = "0x21215F4")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x21216F8", Offset = "0x21216F8", VA = "0x21216F8")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x21217FC", Offset = "0x21217FC", VA = "0x21217FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2121828", Offset = "0x2121828", VA = "0x2121828")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2121864", Offset = "0x2121864", VA = "0x2121864")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x21218A0", Offset = "0x21218A0", VA = "0x21218A0", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x21218E4", Offset = "0x21218E4", VA = "0x21218E4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2121980", Offset = "0x2121980", VA = "0x2121980", Slot = "4")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x21219D8", Offset = "0x21219D8", VA = "0x21219D8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x20000B8")]
		private struct DoubleLongBytesUnion
		{
			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double d;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte b5;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte b6;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte b7;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte b8;
		}

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private double fakeValue;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2121A58", Offset = "0x2121A58", VA = "0x2121A58")]
		private ObscuredDouble(byte[] value)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2121ADC", Offset = "0x2121ADC", VA = "0x2121ADC")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2121B44", Offset = "0x2121B44", VA = "0x2121B44")]
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2121BBC", Offset = "0x2121BBC", VA = "0x2121BBC")]
		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2121BC8", Offset = "0x2121BC8", VA = "0x2121BC8")]
		private static byte[] InternalEncrypt(double value)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2121C34", Offset = "0x2121C34", VA = "0x2121C34")]
		private static byte[] InternalEncrypt(double value, long key)
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2121D64", Offset = "0x2121D64", VA = "0x2121D64")]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2121DD4", Offset = "0x2121DD4", VA = "0x2121DD4")]
		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2121DE0", Offset = "0x2121DE0", VA = "0x2121DE0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2122084", Offset = "0x2122084", VA = "0x2122084")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x212211C", Offset = "0x212211C", VA = "0x212211C")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x21221D0", Offset = "0x21221D0", VA = "0x21221D0")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2121EB0", Offset = "0x2121EB0", VA = "0x2121EB0")]
		private double InternalDecrypt()
		{
			return default(double);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x21222DC", Offset = "0x21222DC", VA = "0x21222DC")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x212237C", Offset = "0x212237C", VA = "0x212237C")]
		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2122380", Offset = "0x2122380", VA = "0x2122380")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2122428", Offset = "0x2122428", VA = "0x2122428")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x21224D0", Offset = "0x21224D0", VA = "0x21224D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x21224FC", Offset = "0x21224FC", VA = "0x21224FC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2122530", Offset = "0x2122530", VA = "0x2122530")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2122564", Offset = "0x2122564", VA = "0x2122564", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x21225A8", Offset = "0x21225A8", VA = "0x21225A8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x212263C", Offset = "0x212263C", VA = "0x212263C", Slot = "4")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x212267C", Offset = "0x212267C", VA = "0x212267C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x20000BA")]
		private struct FloatIntBytesUnion
		{
			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;
		}

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float fakeValue;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x21226FC", Offset = "0x21226FC", VA = "0x21226FC")]
		private ObscuredFloat(byte[] value)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2122784", Offset = "0x2122784", VA = "0x2122784")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x21227EC", Offset = "0x21227EC", VA = "0x21227EC")]
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2122864", Offset = "0x2122864", VA = "0x2122864")]
		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2122870", Offset = "0x2122870", VA = "0x2122870")]
		private static byte[] InternalEncrypt(float value)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x21228DC", Offset = "0x21228DC", VA = "0x21228DC")]
		private static byte[] InternalEncrypt(float value, int key)
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x21229CC", Offset = "0x21229CC", VA = "0x21229CC")]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2122A3C", Offset = "0x2122A3C", VA = "0x2122A3C")]
		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2122A48", Offset = "0x2122A48", VA = "0x2122A48")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2122CAC", Offset = "0x2122CAC", VA = "0x2122CAC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2122D44", Offset = "0x2122D44", VA = "0x2122D44")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2122DB8", Offset = "0x2122DB8", VA = "0x2122DB8")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2122B18", Offset = "0x2122B18", VA = "0x2122B18")]
		private float InternalDecrypt()
		{
			return default(float);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2122E84", Offset = "0x2122E84", VA = "0x2122E84")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x21215F0", Offset = "0x21215F0", VA = "0x21215F0")]
		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2122F2C", Offset = "0x2122F2C", VA = "0x2122F2C")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2122FDC", Offset = "0x2122FDC", VA = "0x2122FDC")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x212308C", Offset = "0x212308C", VA = "0x212308C")]
		public float getValue()
		{
			return default(float);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x2123090", Offset = "0x2123090", VA = "0x2123090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x212312C", Offset = "0x212312C", VA = "0x212312C", Slot = "4")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2123174", Offset = "0x2123174", VA = "0x2123174", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x21231A0", Offset = "0x21231A0", VA = "0x21231A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x21231CC", Offset = "0x21231CC", VA = "0x21231CC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2123200", Offset = "0x2123200", VA = "0x2123200")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2123234", Offset = "0x2123234", VA = "0x2123234", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int fakeValue;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x21232CC", Offset = "0x21232CC", VA = "0x21232CC")]
		private ObscuredInt(int value)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2123350", Offset = "0x2123350", VA = "0x2123350")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x21233B8", Offset = "0x21233B8", VA = "0x21233B8")]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x212341C", Offset = "0x212341C", VA = "0x212341C")]
		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2123498", Offset = "0x2123498", VA = "0x2123498")]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x21234FC", Offset = "0x21234FC", VA = "0x21234FC")]
		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x2123578", Offset = "0x2123578", VA = "0x2123578")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x2123778", Offset = "0x2123778", VA = "0x2123778")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2123814", Offset = "0x2123814", VA = "0x2123814")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x2123838", Offset = "0x2123838", VA = "0x2123838")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x2123644", Offset = "0x2123644", VA = "0x2123644")]
		private int InternalDecrypt()
		{
			return default(int);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x2123874", Offset = "0x2123874", VA = "0x2123874")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x2123900", Offset = "0x2123900", VA = "0x2123900")]
		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2123924", Offset = "0x2123924", VA = "0x2123924")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x21239A0", Offset = "0x21239A0", VA = "0x21239A0")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x2123A38", Offset = "0x2123A38", VA = "0x2123A38")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x2123AD0", Offset = "0x2123AD0", VA = "0x2123AD0")]
		public int getValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x2123AD4", Offset = "0x2123AD4", VA = "0x2123AD4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2123B5C", Offset = "0x2123B5C", VA = "0x2123B5C", Slot = "4")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2123C04", Offset = "0x2123C04", VA = "0x2123C04", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2123C30", Offset = "0x2123C30", VA = "0x2123C30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2123C5C", Offset = "0x2123C5C", VA = "0x2123C5C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2123C90", Offset = "0x2123C90", VA = "0x2123C90")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2123CC4", Offset = "0x2123CC4", VA = "0x2123CC4", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public struct ObscuredLong : IEquatable<ObscuredLong>, IFormattable
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private long fakeValue;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x2123D5C", Offset = "0x2123D5C", VA = "0x2123D5C")]
		private ObscuredLong(long value)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x2123DE0", Offset = "0x2123DE0", VA = "0x2123DE0")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2123E48", Offset = "0x2123E48", VA = "0x2123E48")]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2123F28", Offset = "0x2123F28", VA = "0x2123F28")]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x2123EAC", Offset = "0x2123EAC", VA = "0x2123EAC")]
		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2123F8C", Offset = "0x2123F8C", VA = "0x2123F8C")]
		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2124008", Offset = "0x2124008", VA = "0x2124008")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2124208", Offset = "0x2124208", VA = "0x2124208")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x21242A0", Offset = "0x21242A0", VA = "0x21242A0")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x21242C4", Offset = "0x21242C4", VA = "0x21242C4")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x21240D4", Offset = "0x21240D4", VA = "0x21240D4")]
		private long InternalDecrypt()
		{
			return default(long);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2124300", Offset = "0x2124300", VA = "0x2124300")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x21243A0", Offset = "0x21243A0", VA = "0x21243A0")]
		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x21243A4", Offset = "0x21243A4", VA = "0x21243A4")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2124444", Offset = "0x2124444", VA = "0x2124444")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x21244E4", Offset = "0x21244E4", VA = "0x21244E4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x2124578", Offset = "0x2124578", VA = "0x2124578", Slot = "4")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x2124620", Offset = "0x2124620", VA = "0x2124620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x212464C", Offset = "0x212464C", VA = "0x212464C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2124678", Offset = "0x2124678", VA = "0x2124678")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x21246AC", Offset = "0x21246AC", VA = "0x21246AC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x21246E0", Offset = "0x21246E0", VA = "0x21246E0", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BD")]
	public static class ObscuredPrefs
	{
		[Token(Token = "0x20000BE")]
		private enum DataType : byte
		{
			[Token(Token = "0x400042A")]
			Int = 5,
			[Token(Token = "0x400042B")]
			UInt = 10,
			[Token(Token = "0x400042C")]
			String = 15,
			[Token(Token = "0x400042D")]
			Float = 20,
			[Token(Token = "0x400042E")]
			Double = 25,
			[Token(Token = "0x400042F")]
			Long = 30,
			[Token(Token = "0x4000430")]
			Bool = 35,
			[Token(Token = "0x4000431")]
			ByteArray = 40,
			[Token(Token = "0x4000432")]
			Vector2 = 45,
			[Token(Token = "0x4000433")]
			Vector3 = 50,
			[Token(Token = "0x4000434")]
			Quaternion = 55,
			[Token(Token = "0x4000435")]
			Color = 60,
			[Token(Token = "0x4000436")]
			Rect = 65
		}

		[Token(Token = "0x20000BF")]
		public enum DeviceLockLevel : byte
		{
			[Token(Token = "0x4000438")]
			None,
			[Token(Token = "0x4000439")]
			Soft,
			[Token(Token = "0x400043A")]
			Strict
		}

		[Token(Token = "0x400041A")]
		private const byte VERSION = 2;

		[Token(Token = "0x400041B")]
		private const string RAW_NOT_FOUND = "{not_found}";

		[Token(Token = "0x400041C")]
		private const string DATA_SEPARATOR = "|";

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string encryptionKey;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool foreignSavesReported;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string deviceId;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static uint deviceIdHash;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action onAlterationDetected;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static bool preservePlayerPrefs;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action onPossibleForeignSavesDetected;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static DeviceLockLevel lockToDevice;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public static bool readForeignSaves;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public static bool emergencyMode;

		[Token(Token = "0x4000427")]
		private const char DEPRECATED_RAW_SEPARATOR = ':';

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string deprecatedDeviceId;

		[Token(Token = "0x17000080")]
		public static string DeviceId
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x2127908", Offset = "0x2127908", VA = "0x2127908")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x2127A30", Offset = "0x2127A30", VA = "0x2127A30")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xA3591C", Offset = "0xA3591C")]
		internal static string DeviceID
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2127B6C", Offset = "0x2127B6C", VA = "0x2127B6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x2127C2C", Offset = "0x2127C2C", VA = "0x2127C2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x2127CAC", Offset = "0x2127CAC", VA = "0x2127CAC")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000083")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x212CAA8", Offset = "0x212CAA8", VA = "0x212CAA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x2127D68", Offset = "0x2127D68", VA = "0x2127D68")]
		public static void ForceLockToDeviceInit()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x2127E6C", Offset = "0x2127E6C", VA = "0x2127E6C")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x212715C", Offset = "0x212715C", VA = "0x212715C")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x21280B0", Offset = "0x21280B0", VA = "0x21280B0")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2127300", Offset = "0x2127300", VA = "0x2127300")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2127FFC", Offset = "0x2127FFC", VA = "0x2127FFC")]
		private static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2128218", Offset = "0x2128218", VA = "0x2128218")]
		private static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2129000", Offset = "0x2129000", VA = "0x2129000")]
		public static void SetUInt(string key, uint value)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2129140", Offset = "0x2129140", VA = "0x2129140")]
		public static uint GetUInt(string key)
		{
			return default(uint);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x21291A4", Offset = "0x21291A4", VA = "0x21291A4")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x212908C", Offset = "0x212908C", VA = "0x212908C")]
		private static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2129280", Offset = "0x2129280", VA = "0x2129280")]
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2127274", Offset = "0x2127274", VA = "0x2127274")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2129528", Offset = "0x2129528", VA = "0x2129528")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2127614", Offset = "0x2127614", VA = "0x2127614")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x21293F4", Offset = "0x21293F4", VA = "0x21293F4")]
		public static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x21295A0", Offset = "0x21295A0", VA = "0x21295A0")]
		public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x21271E8", Offset = "0x21271E8", VA = "0x21271E8")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2129830", Offset = "0x2129830", VA = "0x2129830")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2127488", Offset = "0x2127488", VA = "0x2127488")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x212977C", Offset = "0x212977C", VA = "0x212977C")]
		private static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2129894", Offset = "0x2129894", VA = "0x2129894")]
		private static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2129A10", Offset = "0x2129A10", VA = "0x2129A10")]
		public static void SetDouble(string key, double value)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2129B50", Offset = "0x2129B50", VA = "0x2129B50")]
		public static double GetDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2129BB4", Offset = "0x2129BB4", VA = "0x2129BB4")]
		public static double GetDouble(string key, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2129A9C", Offset = "0x2129A9C", VA = "0x2129A9C")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2129C9C", Offset = "0x2129C9C", VA = "0x2129C9C")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2129E44", Offset = "0x2129E44", VA = "0x2129E44")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2129F84", Offset = "0x2129F84", VA = "0x2129F84")]
		public static long GetLong(string key)
		{
			return default(long);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2129FE8", Offset = "0x2129FE8", VA = "0x2129FE8")]
		public static long GetLong(string key, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2129ED0", Offset = "0x2129ED0", VA = "0x2129ED0")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x212A0C4", Offset = "0x212A0C4", VA = "0x212A0C4")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x212A238", Offset = "0x212A238", VA = "0x212A238")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x212A378", Offset = "0x212A378", VA = "0x212A378")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x212A3DC", Offset = "0x212A3DC", VA = "0x212A3DC")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x212A2C4", Offset = "0x212A2C4", VA = "0x212A2C4")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x212A4B8", Offset = "0x212A4B8", VA = "0x212A4B8")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x212A638", Offset = "0x212A638", VA = "0x212A638")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x212A738", Offset = "0x212A738", VA = "0x212A738")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x212A7A0", Offset = "0x212A7A0", VA = "0x212A7A0")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x212A6C4", Offset = "0x212A6C4", VA = "0x212A6C4")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x212A94C", Offset = "0x212A94C", VA = "0x212A94C")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x212A8AC", Offset = "0x212A8AC", VA = "0x212A8AC")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x212AAC4", Offset = "0x212AAC4", VA = "0x212AAC4")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x212AC6C", Offset = "0x212AC6C", VA = "0x212AC6C")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x212ACEC", Offset = "0x212ACEC", VA = "0x212ACEC")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x212AB58", Offset = "0x212AB58", VA = "0x212AB58")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x212ADD8", Offset = "0x212ADD8", VA = "0x212ADD8")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x212B01C", Offset = "0x212B01C", VA = "0x212B01C")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x212B204", Offset = "0x212B204", VA = "0x212B204")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x212B294", Offset = "0x212B294", VA = "0x212B294")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x212B0C0", Offset = "0x212B0C0", VA = "0x212B0C0")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x212B398", Offset = "0x212B398", VA = "0x212B398")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x212B628", Offset = "0x212B628", VA = "0x212B628")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x212B840", Offset = "0x212B840", VA = "0x212B840")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x212B8D8", Offset = "0x212B8D8", VA = "0x212B8D8")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x212B6D4", Offset = "0x212B6D4", VA = "0x212B6D4")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x212B9EC", Offset = "0x212B9EC", VA = "0x212B9EC")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x212BCD4", Offset = "0x212BCD4", VA = "0x212BCD4")]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x212BE20", Offset = "0x212BE20", VA = "0x212BE20")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x212BEB4", Offset = "0x212BEB4", VA = "0x212BEB4")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x212BD6C", Offset = "0x212BD6C", VA = "0x212BD6C")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x212BFB8", Offset = "0x212BFB8", VA = "0x212BFB8")]
		public static void SetRect(string key, Rect value)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x212C1F0", Offset = "0x212C1F0", VA = "0x212C1F0")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x212C284", Offset = "0x212C284", VA = "0x212C284")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x212C064", Offset = "0x212C064", VA = "0x212C064")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x212C398", Offset = "0x212C398", VA = "0x212C398")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x212C6B0", Offset = "0x212C6B0", VA = "0x212C6B0")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x212C728", Offset = "0x212C728", VA = "0x212C728")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x212C790", Offset = "0x212C790", VA = "0x212C790")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x212779C", Offset = "0x212779C", VA = "0x212779C")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x212C818", Offset = "0x212C818", VA = "0x212C818")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x212C820", Offset = "0x212C820", VA = "0x212C820")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2128114", Offset = "0x2128114", VA = "0x2128114")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2127EF0", Offset = "0x2127EF0", VA = "0x2127EF0")]
		private static string EncryptKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x212838C", Offset = "0x212838C", VA = "0x212838C")]
		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2128B58", Offset = "0x2128B58", VA = "0x2128B58")]
		private static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2127AB0", Offset = "0x2127AB0", VA = "0x2127AB0")]
		private static uint CalculateChecksum(string input)
		{
			return default(uint);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x212C924", Offset = "0x212C924", VA = "0x212C924")]
		private static void SavesTampered()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x212C9CC", Offset = "0x212C9CC", VA = "0x212C9CC")]
		private static void PossibleForeignSavesDetected()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x21279C8", Offset = "0x21279C8", VA = "0x21279C8")]
		private static string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x212C828", Offset = "0x212C828", VA = "0x212C828")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x2128674", Offset = "0x2128674", VA = "0x2128674")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x212CB6C", Offset = "0x212CB6C", VA = "0x212CB6C")]
		private static string DeprecatedCalculateChecksum(string input)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C0")]
	public struct ObscuredQuaternion
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public struct RawEncryptedQuaternion
		{
			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int w;
		}

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Quaternion initialFakeValue;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Quaternion fakeValue;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x2795468", Offset = "0x2795468", VA = "0x2795468")]
		private ObscuredQuaternion(RawEncryptedQuaternion value)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x2795504", Offset = "0x2795504", VA = "0x2795504")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x279556C", Offset = "0x279556C", VA = "0x279556C")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x27955F8", Offset = "0x27955F8", VA = "0x27955F8")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x2795714", Offset = "0x2795714", VA = "0x2795714")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x2795788", Offset = "0x2795788", VA = "0x2795788")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x27958A0", Offset = "0x27958A0", VA = "0x27958A0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x2795BA8", Offset = "0x2795BA8", VA = "0x2795BA8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x2795C64", Offset = "0x2795C64", VA = "0x2795C64")]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x2795C8C", Offset = "0x2795C8C", VA = "0x2795C8C")]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x2795994", Offset = "0x2795994", VA = "0x2795994")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x2795CD4", Offset = "0x2795CD4", VA = "0x2795CD4")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x2795E30", Offset = "0x2795E30", VA = "0x2795E30")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x2795F18", Offset = "0x2795F18", VA = "0x2795F18")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x2795F1C", Offset = "0x2795F1C", VA = "0x2795F1C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x2795F4C", Offset = "0x2795F4C", VA = "0x2795F4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x2795F7C", Offset = "0x2795F7C", VA = "0x2795F7C")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C2")]
	public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static sbyte cryptoKey;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private sbyte currentCryptoKey;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private sbyte hiddenValue;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private sbyte fakeValue;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private bool inited;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2796028", Offset = "0x2796028", VA = "0x2796028")]
		private ObscuredSByte(sbyte value)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x27960AC", Offset = "0x27960AC", VA = "0x27960AC")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2796114", Offset = "0x2796114", VA = "0x2796114")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2796178", Offset = "0x2796178", VA = "0x2796178")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x27961F8", Offset = "0x27961F8", VA = "0x27961F8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2796400", Offset = "0x2796400", VA = "0x2796400")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2796498", Offset = "0x2796498", VA = "0x2796498")]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x27964BC", Offset = "0x27964BC", VA = "0x27964BC")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x27962C4", Offset = "0x27962C4", VA = "0x27962C4")]
		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x27964FC", Offset = "0x27964FC", VA = "0x27964FC")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x279658C", Offset = "0x279658C", VA = "0x279658C")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x27965B0", Offset = "0x27965B0", VA = "0x27965B0")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x279664C", Offset = "0x279664C", VA = "0x279664C")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x27966E8", Offset = "0x27966E8", VA = "0x27966E8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x2796770", Offset = "0x2796770", VA = "0x2796770", Slot = "4")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x279681C", Offset = "0x279681C", VA = "0x279681C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x2796848", Offset = "0x2796848", VA = "0x2796848")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x279687C", Offset = "0x279687C", VA = "0x279687C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x27968A8", Offset = "0x27968A8", VA = "0x27968A8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x27968DC", Offset = "0x27968DC", VA = "0x27968DC", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static short cryptoKey;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private short currentCryptoKey;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private short hiddenValue;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private short fakeValue;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2796970", Offset = "0x2796970", VA = "0x2796970")]
		private ObscuredShort(short value)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x27969F8", Offset = "0x27969F8", VA = "0x27969F8")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2796A60", Offset = "0x2796A60", VA = "0x2796A60")]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2796AC4", Offset = "0x2796AC4", VA = "0x2796AC4")]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2796B44", Offset = "0x2796B44", VA = "0x2796B44")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2796D50", Offset = "0x2796D50", VA = "0x2796D50")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x2796DE8", Offset = "0x2796DE8", VA = "0x2796DE8")]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2796E0C", Offset = "0x2796E0C", VA = "0x2796E0C")]
		public void SetEncrypted(short encrypted)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2796C10", Offset = "0x2796C10", VA = "0x2796C10")]
		private short InternalDecrypt()
		{
			return default(short);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2796E4C", Offset = "0x2796E4C", VA = "0x2796E4C")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2796EDC", Offset = "0x2796EDC", VA = "0x2796EDC")]
		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2796F00", Offset = "0x2796F00", VA = "0x2796F00")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2796F8C", Offset = "0x2796F8C", VA = "0x2796F8C")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2797018", Offset = "0x2797018", VA = "0x2797018", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x27970A0", Offset = "0x27970A0", VA = "0x27970A0", Slot = "4")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2797148", Offset = "0x2797148", VA = "0x2797148", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2797174", Offset = "0x2797174", VA = "0x2797174")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x27971A8", Offset = "0x27971A8", VA = "0x27971A8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x27971D4", Offset = "0x27971D4", VA = "0x27971D4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2797208", Offset = "0x2797208", VA = "0x2797208", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public sealed class ObscuredString
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string cryptoKey;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string currentCryptoKey;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string fakeValue;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x279729C", Offset = "0x279729C", VA = "0x279729C")]
		private ObscuredString()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x27972A4", Offset = "0x27972A4", VA = "0x27972A4")]
		private ObscuredString(byte[] value)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x2797334", Offset = "0x2797334", VA = "0x2797334")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x279739C", Offset = "0x279739C", VA = "0x279739C")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x2797414", Offset = "0x2797414", VA = "0x2797414")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2797598", Offset = "0x2797598", VA = "0x2797598")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2797870", Offset = "0x2797870", VA = "0x2797870")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x279798C", Offset = "0x279798C", VA = "0x279798C")]
		public string GetEncrypted()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2797A88", Offset = "0x2797A88", VA = "0x2797A88")]
		public void SetEncrypted(string encrypted)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2797804", Offset = "0x2797804", VA = "0x2797804")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2797918", Offset = "0x2797918", VA = "0x2797918")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2797660", Offset = "0x2797660", VA = "0x2797660")]
		private string InternalDecrypt()
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x2797BA8", Offset = "0x2797BA8", VA = "0x2797BA8")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2797C58", Offset = "0x2797C58", VA = "0x2797C58")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2797DD0", Offset = "0x2797DD0", VA = "0x2797DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2797CEC", Offset = "0x2797CEC", VA = "0x2797CEC")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2797E58", Offset = "0x2797E58", VA = "0x2797E58")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x2797ED4", Offset = "0x2797ED4", VA = "0x2797ED4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x2797F54", Offset = "0x2797F54", VA = "0x2797F54")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2798060", Offset = "0x2798060", VA = "0x2798060")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2798128", Offset = "0x2798128", VA = "0x2798128", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x2797B1C", Offset = "0x2797B1C", VA = "0x2797B1C")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x27979F8", Offset = "0x27979F8", VA = "0x27979F8")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2797DD4", Offset = "0x2797DD4", VA = "0x2797DD4")]
		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000C5")]
	public struct ObscuredUInt : IEquatable<ObscuredUInt>, IFormattable
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint cryptoKey;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint currentCryptoKey;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private uint hiddenValue;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private uint fakeValue;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool inited;

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x27981B0", Offset = "0x27981B0", VA = "0x27981B0")]
		private ObscuredUInt(uint value)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2798234", Offset = "0x2798234", VA = "0x2798234")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x279829C", Offset = "0x279829C", VA = "0x279829C")]
		public static uint Encrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x279837C", Offset = "0x279837C", VA = "0x279837C")]
		public static uint Decrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2798300", Offset = "0x2798300", VA = "0x2798300")]
		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x27983E0", Offset = "0x27983E0", VA = "0x27983E0")]
		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x279845C", Offset = "0x279845C", VA = "0x279845C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2798660", Offset = "0x2798660", VA = "0x2798660")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x27986F8", Offset = "0x27986F8", VA = "0x27986F8")]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x279871C", Offset = "0x279871C", VA = "0x279871C")]
		public void SetEncrypted(uint encrypted)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2798528", Offset = "0x2798528", VA = "0x2798528")]
		private uint InternalDecrypt()
		{
			return default(uint);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x279875C", Offset = "0x279875C", VA = "0x279875C")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x27987EC", Offset = "0x27987EC", VA = "0x27987EC")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2798810", Offset = "0x2798810", VA = "0x2798810")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x279888C", Offset = "0x279888C", VA = "0x279888C")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2798928", Offset = "0x2798928", VA = "0x2798928")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x27989C4", Offset = "0x27989C4", VA = "0x27989C4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x2798A4C", Offset = "0x2798A4C", VA = "0x2798A4C", Slot = "4")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2798AF4", Offset = "0x2798AF4", VA = "0x2798AF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x2798B20", Offset = "0x2798B20", VA = "0x2798B20")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2798B54", Offset = "0x2798B54", VA = "0x2798B54", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2798B80", Offset = "0x2798B80", VA = "0x2798B80")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2798BB4", Offset = "0x2798BB4", VA = "0x2798BB4", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C6")]
	public struct ObscuredULong : IEquatable<ObscuredULong>, IFormattable
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ulong cryptoKey;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong currentCryptoKey;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ulong hiddenValue;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong fakeValue;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inited;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x2798C4C", Offset = "0x2798C4C", VA = "0x2798C4C")]
		private ObscuredULong(ulong value)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2798CD0", Offset = "0x2798CD0", VA = "0x2798CD0")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2798D38", Offset = "0x2798D38", VA = "0x2798D38")]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x2798E18", Offset = "0x2798E18", VA = "0x2798E18")]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x2798D9C", Offset = "0x2798D9C", VA = "0x2798D9C")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x2798E7C", Offset = "0x2798E7C", VA = "0x2798E7C")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2798EF8", Offset = "0x2798EF8", VA = "0x2798EF8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x27990FC", Offset = "0x27990FC", VA = "0x27990FC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x2799194", Offset = "0x2799194", VA = "0x2799194")]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x27991B8", Offset = "0x27991B8", VA = "0x27991B8")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x2798FC4", Offset = "0x2798FC4", VA = "0x2798FC4")]
		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x27991F8", Offset = "0x27991F8", VA = "0x27991F8")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x279929C", Offset = "0x279929C", VA = "0x279929C")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x27992A0", Offset = "0x27992A0", VA = "0x27992A0")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x2799344", Offset = "0x2799344", VA = "0x2799344")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x27993E8", Offset = "0x27993E8", VA = "0x27993E8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x279947C", Offset = "0x279947C", VA = "0x279947C", Slot = "4")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2799524", Offset = "0x2799524", VA = "0x2799524", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2799550", Offset = "0x2799550", VA = "0x2799550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x279957C", Offset = "0x279957C", VA = "0x279957C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x27995B0", Offset = "0x27995B0", VA = "0x27995B0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x27995E4", Offset = "0x27995E4", VA = "0x27995E4", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C7")]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ushort cryptoKey;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort currentCryptoKey;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort hiddenValue;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private ushort fakeValue;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x279967C", Offset = "0x279967C", VA = "0x279967C")]
		private ObscuredUShort(ushort value)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x2799704", Offset = "0x2799704", VA = "0x2799704")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x279976C", Offset = "0x279976C", VA = "0x279976C")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x27997D0", Offset = "0x27997D0", VA = "0x27997D0")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2799850", Offset = "0x2799850", VA = "0x2799850")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2799A5C", Offset = "0x2799A5C", VA = "0x2799A5C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x2799AF4", Offset = "0x2799AF4", VA = "0x2799AF4")]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2799B18", Offset = "0x2799B18", VA = "0x2799B18")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x279991C", Offset = "0x279991C", VA = "0x279991C")]
		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2799B58", Offset = "0x2799B58", VA = "0x2799B58")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2799BE8", Offset = "0x2799BE8", VA = "0x2799BE8")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2799C0C", Offset = "0x2799C0C", VA = "0x2799C0C")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2799CA8", Offset = "0x2799CA8", VA = "0x2799CA8")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2799D44", Offset = "0x2799D44", VA = "0x2799D44", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2799DCC", Offset = "0x2799DCC", VA = "0x2799DCC", Slot = "4")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2799E74", Offset = "0x2799E74", VA = "0x2799E74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2799EA0", Offset = "0x2799EA0", VA = "0x2799EA0")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2799ED4", Offset = "0x2799ED4", VA = "0x2799ED4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2799F00", Offset = "0x2799F00", VA = "0x2799F00")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2799F34", Offset = "0x2799F34", VA = "0x2799F34", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA327F8", Offset = "0xA327F8")]
	public struct ObscuredVector2
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public struct RawEncryptedVector2
		{
			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;
		}

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector2 initialFakeValue;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector2 hiddenValue;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Vector2 fakeValue;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x17000084")]
		public float x
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x279A05C", Offset = "0x279A05C", VA = "0x279A05C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x279A230", Offset = "0x279A230", VA = "0x279A230")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public float y
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x279A31C", Offset = "0x279A31C", VA = "0x279A31C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x279A454", Offset = "0x279A454", VA = "0x279A454")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public float Item
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x279A494", Offset = "0x279A494", VA = "0x279A494")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x279A4FC", Offset = "0x279A4FC", VA = "0x279A4FC")]
			set
			{
			}
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2799FC8", Offset = "0x2799FC8", VA = "0x2799FC8")]
		private ObscuredVector2(RawEncryptedVector2 value)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x279A564", Offset = "0x279A564", VA = "0x279A564")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x279A5CC", Offset = "0x279A5CC", VA = "0x279A5CC")]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x279A640", Offset = "0x279A640", VA = "0x279A640")]
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x279A718", Offset = "0x279A718", VA = "0x279A718")]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x279A77C", Offset = "0x279A77C", VA = "0x279A77C")]
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x279A858", Offset = "0x279A858", VA = "0x279A858")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x279AB00", Offset = "0x279AB00", VA = "0x279AB00")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x279ABA0", Offset = "0x279ABA0", VA = "0x279ABA0")]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x279ABC4", Offset = "0x279ABC4", VA = "0x279ABC4")]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x279A930", Offset = "0x279A930", VA = "0x279A930")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x279AC04", Offset = "0x279AC04", VA = "0x279AC04")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x279A18C", Offset = "0x279A18C", VA = "0x279A18C")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x279A270", Offset = "0x279A270", VA = "0x279A270")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x279ACFC", Offset = "0x279ACFC", VA = "0x279ACFC")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x279ADB0", Offset = "0x279ADB0", VA = "0x279ADB0")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x279ADB4", Offset = "0x279ADB4", VA = "0x279ADB4")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x279ADCC", Offset = "0x279ADCC", VA = "0x279ADCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x279ADF8", Offset = "0x279ADF8", VA = "0x279ADF8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x279AE24", Offset = "0x279AE24", VA = "0x279AE24")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA32830", Offset = "0xA32830")]
	public struct ObscuredVector3
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public struct RawEncryptedVector3
		{
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector3 initialFakeValue;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector3 hiddenValue;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 fakeValue;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x17000087")]
		public float x
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x279B144", Offset = "0x279B144", VA = "0x279B144")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x279B318", Offset = "0x279B318", VA = "0x279B318")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public float y
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x279B404", Offset = "0x279B404", VA = "0x279B404")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x279B53C", Offset = "0x279B53C", VA = "0x279B53C")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public float z
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x279B57C", Offset = "0x279B57C", VA = "0x279B57C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x279B6B4", Offset = "0x279B6B4", VA = "0x279B6B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public float Item
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x279B6F4", Offset = "0x279B6F4", VA = "0x279B6F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x279B768", Offset = "0x279B768", VA = "0x279B768")]
			set
			{
			}
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x279AEC0", Offset = "0x279AEC0", VA = "0x279AEC0")]
		private ObscuredVector3(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x279AF64", Offset = "0x279AF64", VA = "0x279AF64")]
		public Vector3 getValue()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x279B7DC", Offset = "0x279B7DC", VA = "0x279B7DC")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x279B844", Offset = "0x279B844", VA = "0x279B844")]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x279B8D0", Offset = "0x279B8D0", VA = "0x279B8D0")]
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x279B9D4", Offset = "0x279B9D4", VA = "0x279B9D4")]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x279BA48", Offset = "0x279BA48", VA = "0x279BA48")]
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x279BB40", Offset = "0x279BB40", VA = "0x279BB40")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x279BC2C", Offset = "0x279BC2C", VA = "0x279BC2C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x279BCE0", Offset = "0x279BCE0", VA = "0x279BCE0")]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x279BD08", Offset = "0x279BD08", VA = "0x279BD08")]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x279AF68", Offset = "0x279AF68", VA = "0x279AF68")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x279BD50", Offset = "0x279BD50", VA = "0x279BD50")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x279B274", Offset = "0x279B274", VA = "0x279B274")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x279B358", Offset = "0x279B358", VA = "0x279B358")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x279BE7C", Offset = "0x279BE7C", VA = "0x279BE7C")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x279BF50", Offset = "0x279BF50", VA = "0x279BF50")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x279BF54", Offset = "0x279BF54", VA = "0x279BF54")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x279C01C", Offset = "0x279C01C", VA = "0x279C01C")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x279C0D8", Offset = "0x279C0D8", VA = "0x279C0D8")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x279C194", Offset = "0x279C194", VA = "0x279C194")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x279C25C", Offset = "0x279C25C", VA = "0x279C25C")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x279C318", Offset = "0x279C318", VA = "0x279C318")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x279C3D4", Offset = "0x279C3D4", VA = "0x279C3D4")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x279C484", Offset = "0x279C484", VA = "0x279C484")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x279C538", Offset = "0x279C538", VA = "0x279C538")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x279C5EC", Offset = "0x279C5EC", VA = "0x279C5EC")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x279C6A0", Offset = "0x279C6A0", VA = "0x279C6A0")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x279C700", Offset = "0x279C700", VA = "0x279C700")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x279C74C", Offset = "0x279C74C", VA = "0x279C74C")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x279C78C", Offset = "0x279C78C", VA = "0x279C78C")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x279C7EC", Offset = "0x279C7EC", VA = "0x279C7EC")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x279C838", Offset = "0x279C838", VA = "0x279C838")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x279C878", Offset = "0x279C878", VA = "0x279C878", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x279C8BC", Offset = "0x279C8BC", VA = "0x279C8BC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x279C8EC", Offset = "0x279C8EC", VA = "0x279C8EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x279C91C", Offset = "0x279C91C", VA = "0x279C91C")]
		public string ToString(string format)
		{
			return null;
		}
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA32868", Offset = "0xA32868")]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		[Token(Token = "0x4000474")]
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";

		[Token(Token = "0x4000475")]
		protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x4000476")]
		protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static GameObject detectorsContainer;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33D38", Offset = "0xA33D38")]
		public bool autoStart;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33D70", Offset = "0xA33D70")]
		public bool keepAlive;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33DA8", Offset = "0xA33DA8")]
		public bool autoDispose;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected UnityEvent detectionEvent;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityAction detectionAction;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool detectionEventHasListener;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isRunning;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool started;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1E074CC", Offset = "0x1E074CC", VA = "0x1E074CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1E075E8", Offset = "0x1E075E8", VA = "0x1E075E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1E07610", Offset = "0x1E07610", VA = "0x1E07610")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1E07628", Offset = "0x1E07628", VA = "0x1E07628")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1E07634", Offset = "0x1E07634", VA = "0x1E07634", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1E07778", Offset = "0x1E07778", VA = "0x1E07778", Slot = "5")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1E07938", Offset = "0x1E07938", VA = "0x1E07938", Slot = "6")]
		protected virtual void DisposeInternal()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1E0799C", Offset = "0x1E0799C", VA = "0x1E0799C", Slot = "7")]
		internal virtual void OnCheatingDetected()
		{
		}

		[Token(Token = "0x600077B")]
		protected abstract void StartDetectionAutomatically();

		[Token(Token = "0x600077C")]
		protected abstract void StopDetectionInternal();

		[Token(Token = "0x600077D")]
		protected abstract void PauseDetector();

		[Token(Token = "0x600077E")]
		protected abstract void ResumeDetector();

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1E07A00", Offset = "0x1E07A00", VA = "0x1E07A00")]
		protected ActDetectorBase()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA328A0", Offset = "0xA328A0")]
	public class InjectionDetector : ActDetectorBase
	{
		[Token(Token = "0x20000CE")]
		private class AllowedAssembly
		{
			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string name;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly int[] hashes;

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x26B2C40", Offset = "0x26B2C40", VA = "0x26B2C40")]
			public AllowedAssembly(string name, int[] hashes)
			{
			}
		}

		[Token(Token = "0x4000480")]
		internal const string COMPONENT_NAME = "Injection Detector";

		[Token(Token = "0x4000481")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		private bool signaturesAreNotGenuine;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AllowedAssembly[] allowedAssemblies;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string[] hexTable;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA33E00", Offset = "0xA33E00")]
		private static InjectionDetector <Instance>k__BackingField;

		[Token(Token = "0x1700008B")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1BF4DAC", Offset = "0x1BF4DAC", VA = "0x1BF4DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3553C", Offset = "0xA3553C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1BF4DF8", Offset = "0x1BF4DF8", VA = "0x1BF4DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3554C", Offset = "0xA3554C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		private static InjectionDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1BF49FC", Offset = "0x1BF49FC", VA = "0x1BF49FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1BF4648", Offset = "0x1BF4648", VA = "0x1BF4648")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1BF49D0", Offset = "0x1BF49D0", VA = "0x1BF49D0")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1BF4BCC", Offset = "0x1BF4BCC", VA = "0x1BF4BCC")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1BF4CBC", Offset = "0x1BF4CBC", VA = "0x1BF4CBC")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1BF4E48", Offset = "0x1BF4E48", VA = "0x1BF4E48")]
		private InjectionDetector()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1BF4E50", Offset = "0x1BF4E50", VA = "0x1BF4E50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1BF4FC4", Offset = "0x1BF4FC4", VA = "0x1BF4FC4", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1BF50B8", Offset = "0x1BF50B8", VA = "0x1BF50B8")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1BF477C", Offset = "0x1BF477C", VA = "0x1BF477C")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1BF57A8", Offset = "0x1BF57A8", VA = "0x1BF57A8", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1BF57B0", Offset = "0x1BF57B0", VA = "0x1BF57B0", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1BF5854", Offset = "0x1BF5854", VA = "0x1BF5854", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1BF591C", Offset = "0x1BF591C", VA = "0x1BF591C", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1BF59D0", Offset = "0x1BF59D0", VA = "0x1BF59D0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1BF5AB4", Offset = "0x1BF5AB4", VA = "0x1BF5AB4")]
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1BF570C", Offset = "0x1BF570C", VA = "0x1BF570C")]
		private bool FindInjectionInCurrentAssemblies()
		{
			return default(bool);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1BF5AFC", Offset = "0x1BF5AFC", VA = "0x1BF5AFC")]
		private bool AssemblyAllowed(Assembly ass)
		{
			return default(bool);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1BF51AC", Offset = "0x1BF51AC", VA = "0x1BF51AC")]
		private void LoadAndParseAllowedAssemblies()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1BF5C04", Offset = "0x1BF5C04", VA = "0x1BF5C04")]
		private int GetAssemblyHash(Assembly ass)
		{
			return default(int);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1BF5CE0", Offset = "0x1BF5CE0", VA = "0x1BF5CE0")]
		private string PublicKeyTokenToString(byte[] bytes)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA328D8", Offset = "0xA328D8")]
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		[Token(Token = "0x4000489")]
		internal const string COMPONENT_NAME = "Obscured Cheating Detector";

		[Token(Token = "0x400048A")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33E10", Offset = "0xA33E10")]
		public float floatEpsilon;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33E48", Offset = "0xA33E48")]
		public float vector2Epsilon;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33E80", Offset = "0xA33E80")]
		public float vector3Epsilon;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33EB8", Offset = "0xA33EB8")]
		public float quaternionEpsilon;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA33EF0", Offset = "0xA33EF0")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;

		[Token(Token = "0x1700008D")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x212042C", Offset = "0x212042C", VA = "0x212042C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3555C", Offset = "0xA3555C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x2120478", Offset = "0x2120478", VA = "0x2120478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3556C", Offset = "0xA3556C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x212007C", Offset = "0x212007C", VA = "0x212007C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		internal static bool IsRunning
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x211E858", Offset = "0x211E858", VA = "0x211E858")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x211FD70", Offset = "0x211FD70", VA = "0x211FD70")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2120050", Offset = "0x2120050", VA = "0x2120050")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x212024C", Offset = "0x212024C", VA = "0x212024C")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x212033C", Offset = "0x212033C", VA = "0x212033C")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x21204C8", Offset = "0x21204C8", VA = "0x21204C8")]
		private ObscuredCheatingDetector()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x21204DC", Offset = "0x21204DC", VA = "0x21204DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2120650", Offset = "0x2120650", VA = "0x2120650", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x2120744", Offset = "0x2120744", VA = "0x2120744")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x211FEA4", Offset = "0x211FEA4", VA = "0x211FEA4")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2120838", Offset = "0x2120838", VA = "0x2120838", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x2120840", Offset = "0x2120840", VA = "0x2120840", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2120848", Offset = "0x2120848", VA = "0x2120848", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2120864", Offset = "0x2120864", VA = "0x2120864", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2120878", Offset = "0x2120878", VA = "0x2120878", Slot = "6")]
		protected override void DisposeInternal()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA32910", Offset = "0xA32910")]
	public class SpeedHackDetector : ActDetectorBase
	{
		[Token(Token = "0x4000491")]
		internal const string COMPONENT_NAME = "Speed Hack Detector";

		[Token(Token = "0x4000492")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";

		[Token(Token = "0x4000493")]
		private const long TICKS_PER_SECOND = 10000000L;

		[Token(Token = "0x4000494")]
		private const int THRESHOLD = 5000000;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33F00", Offset = "0xA33F00")]
		public float interval;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33F38", Offset = "0xA33F38")]
		public byte maxFalsePositives;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33F70", Offset = "0xA33F70")]
		public int coolDown;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte currentFalsePositives;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int currentCooldownShots;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long ticksOnStart;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long vulnerableTicksOnStart;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long prevTicks;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private long prevIntervalTicks;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA33FA8", Offset = "0xA33FA8")]
		private static SpeedHackDetector <Instance>k__BackingField;

		[Token(Token = "0x17000090")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x27A1D70", Offset = "0x27A1D70", VA = "0x27A1D70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3557C", Offset = "0xA3557C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x27A1DBC", Offset = "0x27A1DBC", VA = "0x27A1DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3558C", Offset = "0xA3558C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x27A18E4", Offset = "0x27A18E4", VA = "0x27A18E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x27A1580", Offset = "0x27A1580", VA = "0x27A1580")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x27A18B4", Offset = "0x27A18B4", VA = "0x27A18B4")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x27A1AB4", Offset = "0x27A1AB4", VA = "0x27A1AB4")]
		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x27A1AF4", Offset = "0x27A1AF4", VA = "0x27A1AF4")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x27A1B3C", Offset = "0x27A1B3C", VA = "0x27A1B3C")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x27A1B90", Offset = "0x27A1B90", VA = "0x27A1B90")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x27A1C80", Offset = "0x27A1C80", VA = "0x27A1C80")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x27A1E0C", Offset = "0x27A1E0C", VA = "0x27A1E0C")]
		private SpeedHackDetector()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x27A1E2C", Offset = "0x27A1E2C", VA = "0x27A1E2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x27A1FA0", Offset = "0x27A1FA0", VA = "0x27A1FA0", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x27A2094", Offset = "0x27A2094", VA = "0x27A2094")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x27A2188", Offset = "0x27A2188", VA = "0x27A2188")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x27A2234", Offset = "0x27A2234", VA = "0x27A2234")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x27A16C0", Offset = "0x27A16C0", VA = "0x27A16C0")]
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x27A23C8", Offset = "0x27A23C8", VA = "0x27A23C8", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x27A23DC", Offset = "0x27A23DC", VA = "0x27A23DC", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x27A23E4", Offset = "0x27A23E4", VA = "0x27A23E4", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x27A2400", Offset = "0x27A2400", VA = "0x27A2400", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x27A2414", Offset = "0x27A2414", VA = "0x27A2414", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x27A2194", Offset = "0x27A2194", VA = "0x27A2194")]
		private void ResetStartTicks()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA32948", Offset = "0xA32948")]
	public class WallHackDetector : ActDetectorBase
	{
		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32980", Offset = "0xA32980")]
		private sealed class <InitDetector>d__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x17000098")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x26B7A40", Offset = "0x26B7A40", VA = "0x26B7A40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F7")]
				[Address(RVA = "0x26B7A88", Offset = "0x26B7A88", VA = "0x26B7A88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x26B7950", Offset = "0x26B7950", VA = "0x26B7950")]
			[DebuggerHidden]
			public <InitDetector>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x26B797C", Offset = "0x26B797C", VA = "0x26B797C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x26B7980", Offset = "0x26B7980", VA = "0x26B7980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x26B7A48", Offset = "0x26B7A48", VA = "0x26B7A48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32990", Offset = "0xA32990")]
		private sealed class <CaptureFrame>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RenderTexture <previousActive>5__2;

			[Token(Token = "0x1700009A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x26B7900", Offset = "0x26B7900", VA = "0x26B7900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x26B7948", Offset = "0x26B7948", VA = "0x26B7948", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x26B74F8", Offset = "0x26B74F8", VA = "0x26B74F8")]
			[DebuggerHidden]
			public <CaptureFrame>d__82(int <>1__state)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x26B7524", Offset = "0x26B7524", VA = "0x26B7524", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x26B7528", Offset = "0x26B7528", VA = "0x26B7528", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x26B7908", Offset = "0x26B7908", VA = "0x26B7908", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004A0")]
		internal const string COMPONENT_NAME = "WallHack Detector";

		[Token(Token = "0x40004A1")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";

		[Token(Token = "0x40004A2")]
		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";

		[Token(Token = "0x40004A3")]
		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";

		[Token(Token = "0x40004A4")]
		private const int SHADER_TEXTURE_SIZE = 4;

		[Token(Token = "0x40004A5")]
		private const int RENDER_TEXTURE_SIZE = 4;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly Vector3 rigidPlayerVelocity;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForEndOfFrame waitForEndOfFrame;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA33FB8", Offset = "0xA33FB8")]
		private bool checkRigidbody;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA34004", Offset = "0xA34004")]
		[SerializeField]
		private bool checkController;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA34050", Offset = "0xA34050")]
		private bool checkWireframe;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA3409C", Offset = "0xA3409C")]
		[SerializeField]
		private bool checkRaycast;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA340E8", Offset = "0xA340E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA340E8", Offset = "0xA340E8")]
		public int wireframeDelay;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA34140", Offset = "0xA34140")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA34140", Offset = "0xA34140")]
		public int raycastDelay;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA34198", Offset = "0xA34198")]
		public Vector3 spawnPosition;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA341D0", Offset = "0xA341D0")]
		public byte maxFalsePositives;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject serviceContainer;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject solidWall;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject thinWall;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Camera wfCamera;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MeshRenderer foregroundRenderer;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MeshRenderer backgroundRenderer;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Color wfColor1;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Color wfColor2;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Shader wfShader;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material wfMaterial;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Texture2D shaderTexture;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Texture2D targetTexture;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture renderTexture;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int whLayer;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int raycastMask;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Rigidbody rigidPlayer;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CharacterController charControllerPlayer;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float charControllerVelocity;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private byte rigidbodyDetections;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private byte controllerDetections;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		private byte wireframeDetections;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		private byte raycastDetections;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool wireframeDetected;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA34208", Offset = "0xA34208")]
		private static WallHackDetector <Instance>k__BackingField;

		[Token(Token = "0x17000092")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x27A5CBC", Offset = "0x27A5CBC", VA = "0x27A5CBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x27A5CC4", Offset = "0x27A5CC4", VA = "0x27A5CC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool CheckController
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x27A70B8", Offset = "0x27A70B8", VA = "0x27A70B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x27A70C0", Offset = "0x27A70C0", VA = "0x27A70C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool CheckWireframe
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x27A7334", Offset = "0x27A7334", VA = "0x27A7334")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x27A733C", Offset = "0x27A733C", VA = "0x27A733C")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool CheckRaycast
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x27A74C8", Offset = "0x27A74C8", VA = "0x27A74C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x27A74D0", Offset = "0x27A74D0", VA = "0x27A74D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x27A7E24", Offset = "0x27A7E24", VA = "0x27A7E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3559C", Offset = "0xA3559C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x27A7E70", Offset = "0x27A7E70", VA = "0x27A7E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA355AC", Offset = "0xA355AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x27A79C0", Offset = "0x27A79C0", VA = "0x27A79C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x27A7648", Offset = "0x27A7648", VA = "0x27A7648")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x27A798C", Offset = "0x27A798C", VA = "0x27A798C")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x27A7B90", Offset = "0x27A7B90", VA = "0x27A7B90")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x27A7BE8", Offset = "0x27A7BE8", VA = "0x27A7BE8")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x27A7C44", Offset = "0x27A7C44", VA = "0x27A7C44")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x27A7D34", Offset = "0x27A7D34", VA = "0x27A7D34")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x27A7EC0", Offset = "0x27A7EC0", VA = "0x27A7EC0")]
		private WallHackDetector()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x27A7F74", Offset = "0x27A7F74", VA = "0x27A7F74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x27A80E8", Offset = "0x27A80E8", VA = "0x27A80E8", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x27A82E8", Offset = "0x27A82E8", VA = "0x27A82E8")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x27A83DC", Offset = "0x27A83DC", VA = "0x27A83DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x27A8518", Offset = "0x27A8518", VA = "0x27A8518")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x27A7788", Offset = "0x27A7788", VA = "0x27A7788")]
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x27A86A4", Offset = "0x27A86A4", VA = "0x27A86A4", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x27A86B8", Offset = "0x27A86B8", VA = "0x27A86B8", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x27A86FC", Offset = "0x27A86FC", VA = "0x27A86FC", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x27A8778", Offset = "0x27A8778", VA = "0x27A8778", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x27A87B0", Offset = "0x27A87B0", VA = "0x27A87B0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x27A5D74", Offset = "0x27A5D74", VA = "0x27A5D74")]
		private void UpdateServiceContainer()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x27A8638", Offset = "0x27A8638", VA = "0x27A8638")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA355BC", Offset = "0xA355BC")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x27A6E94", Offset = "0x27A6E94", VA = "0x27A6E94")]
		private void StartRigidModule()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x27A7170", Offset = "0x27A7170", VA = "0x27A7170")]
		private void StartControllerModule()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x27A73EC", Offset = "0x27A73EC", VA = "0x27A73EC")]
		private void StartWireframeModule()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x27A8E08", Offset = "0x27A8E08", VA = "0x27A8E08")]
		private void ShootWireframeModule()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x27A8E78", Offset = "0x27A8E78", VA = "0x27A8E78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA3561C", Offset = "0xA3561C")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x27A7580", Offset = "0x27A7580", VA = "0x27A7580")]
		private void StartRaycastModule()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x27A8EE4", Offset = "0x27A8EE4", VA = "0x27A8EE4")]
		private void ShootRaycastModule()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x27A7008", Offset = "0x27A7008", VA = "0x27A7008")]
		private void StopRigidModule()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x27A72A0", Offset = "0x27A72A0", VA = "0x27A72A0")]
		private void StopControllerModule()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x27A7478", Offset = "0x27A7478", VA = "0x27A7478")]
		private void StopWireframeModule()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x27A75F8", Offset = "0x27A75F8", VA = "0x27A75F8")]
		private void StopRaycastModule()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x27A8AC0", Offset = "0x27A8AC0", VA = "0x27A8AC0")]
		private void InitRigidModule()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x27A8CC8", Offset = "0x27A8CC8", VA = "0x27A8CC8")]
		private void InitControllerModule()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x27A8A04", Offset = "0x27A8A04", VA = "0x27A8A04")]
		private void UninitRigidModule()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x27A8C0C", Offset = "0x27A8C0C", VA = "0x27A8C0C")]
		private void UninitControllerModule()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x27A84BC", Offset = "0x27A84BC", VA = "0x27A84BC")]
		private bool Detect()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x27A8894", Offset = "0x27A8894", VA = "0x27A8894")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x27A8910", Offset = "0x27A8910", VA = "0x27A8910")]
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return default(bool);
		}
	}
}
namespace CodeStage.AntiCheat.Common
{
	[Token(Token = "0x20000D4")]
	internal class Constants
	{
		[Token(Token = "0x40004D0")]
		internal const string LOG_PREFIX = "[ACTk] ";

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1BEB290", Offset = "0x1BEB290", VA = "0x1BEB290")]
		public Constants()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Examples
{
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA329A0", Offset = "0xA329A0")]
	public class ActRotatorExample : MonoBehaviour
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA34218", Offset = "0xA34218")]
		public float speed;

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1E07A18", Offset = "0x1E07A18", VA = "0x1E07A18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1E07A70", Offset = "0x1E07A70", VA = "0x1E07A70")]
		public ActRotatorExample()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA329D8", Offset = "0xA329D8")]
	public class ActTesterGui : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32A10", Offset = "0xA32A10")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string types;

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x27A94F4", Offset = "0x27A94F4", VA = "0x27A94F4")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x27A94FC", Offset = "0x27A94FC", VA = "0x27A94FC")]
			internal void <GetAllSimpleObscuredTypes>b__1(Type t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA32A20", Offset = "0xA32A20")]
		private sealed class <>c
		{
			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> <>9__61_0;

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x27A9430", Offset = "0x27A9430", VA = "0x27A9430")]
			public <>c()
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x27A9438", Offset = "0x27A9438", VA = "0x27A9438")]
			internal bool <GetAllSimpleObscuredTypes>b__61_0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004D2")]
		private const string RED_COLOR = "#FF4040";

		[Token(Token = "0x40004D3")]
		private const string GREEN_COLOR = "#02C85F";

		[Token(Token = "0x40004D4")]
		private const string PREFS_STRING = "name";

		[Token(Token = "0x40004D5")]
		private const string PREFS_INT = "money";

		[Token(Token = "0x40004D6")]
		private const string PREFS_FLOAT = "lifeBar";

		[Token(Token = "0x40004D7")]
		private const string PREFS_BOOL = "gameComplete";

		[Token(Token = "0x40004D8")]
		private const string PREFS_UINT = "demoUint";

		[Token(Token = "0x40004D9")]
		private const string PREFS_LONG = "demoLong";

		[Token(Token = "0x40004DA")]
		private const string PREFS_DOUBLE = "demoDouble";

		[Token(Token = "0x40004DB")]
		private const string PREFS_VECTOR2 = "demoVector2";

		[Token(Token = "0x40004DC")]
		private const string PREFS_VECTOR3 = "demoVector3";

		[Token(Token = "0x40004DD")]
		private const string PREFS_QUATERNION = "demoQuaternion";

		[Token(Token = "0x40004DE")]
		private const string PREFS_RECT = "demoRect";

		[Token(Token = "0x40004DF")]
		private const string PREFS_COLOR = "demoColor";

		[Token(Token = "0x40004E0")]
		private const string PREFS_BYTE_ARRAY = "demoByteArray";

		[Token(Token = "0x40004E1")]
		private const string API_URL_LOCK_TO_DEVICE = "http://j.mp/1gxg1tf";

		[Token(Token = "0x40004E2")]
		private const string API_URL_PRESERVE_PREFS = "http://j.mp/1iBK5pz";

		[Token(Token = "0x40004E3")]
		private const string API_URL_EMERGENCY_MODE = "http://j.mp/1FRAL5L";

		[Token(Token = "0x40004E4")]
		private const string API_URL_READ_FOREIGN = "http://j.mp/1LCdpDa";

		[Token(Token = "0x40004E5")]
		private const string API_URL_UNOBSCURED_MODE = "http://j.mp/1KVrpxi";

		[Token(Token = "0x40004E6")]
		private const string API_URL_PLAYER_PREFS = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA34234", Offset = "0xA34234")]
		public string regularString;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int regularInt;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float regularFloat;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 regularVector3;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA3426C", Offset = "0xA3426C")]
		public ObscuredString obscuredString;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ObscuredInt obscuredInt;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ObscuredFloat obscuredFloat;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ObscuredVector3 obscuredVector3;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ObscuredBool obscuredBool;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public ObscuredLong obscuredLong;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ObscuredDouble obscuredDouble;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public ObscuredVector2 obscuredVector2;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA342A4", Offset = "0xA342A4")]
		public string prefsEncryptionKey;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly string[] tabs;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int currentTab;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string allSimpleObscuredTypes;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string regularPrefs;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string obscuredPrefs;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int savesLock;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private bool savesAlterationDetected;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		private bool foreignSavesDetected;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		private bool injectionDetected;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		private bool speedHackDetected;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool obscuredTypeCheatDetected;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool wallHackCheatDetected;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1E07A80", Offset = "0x1E07A80", VA = "0x1E07A80")]
		public void OnSpeedHackDetected()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1E07B00", Offset = "0x1E07B00", VA = "0x1E07B00")]
		public void OnInjectionDetected()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1E07B80", Offset = "0x1E07B80", VA = "0x1E07B80")]
		public void OnObscuredTypeCheatingDetected()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1E07C00", Offset = "0x1E07C00", VA = "0x1E07C00")]
		public void OnWallHackDetected()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1E07C80", Offset = "0x1E07C80", VA = "0x1E07C80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1E07D80", Offset = "0x1E07D80", VA = "0x1E07D80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1E08CB0", Offset = "0x1E08CB0", VA = "0x1E08CB0")]
		private void RandomizeObscuredVars()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1E07E00", Offset = "0x1E07E00", VA = "0x1E07E00")]
		private void ObscuredStringExample()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1E07FE4", Offset = "0x1E07FE4", VA = "0x1E07FE4")]
		private void ObscuredIntExample()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1E084B0", Offset = "0x1E084B0", VA = "0x1E084B0")]
		private void ObscuredFloatExample()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1E088C0", Offset = "0x1E088C0", VA = "0x1E088C0")]
		private void ObscuredVector3Example()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1E08D48", Offset = "0x1E08D48", VA = "0x1E08D48")]
		private void SavesAlterationDetected()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1E08D54", Offset = "0x1E08D54", VA = "0x1E08D54")]
		private void ForeignSavesDetected()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1E08D60", Offset = "0x1E08D60", VA = "0x1E08D60")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1E0F284", Offset = "0x1E0F284", VA = "0x1E0F284")]
		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1E0F528", Offset = "0x1E0F528", VA = "0x1E0F528")]
		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1E0F56C", Offset = "0x1E0F56C", VA = "0x1E0F56C")]
		private void LoadRegularPrefs()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1E0F6EC", Offset = "0x1E0F6EC", VA = "0x1E0F6EC")]
		private void SaveRegularPrefs()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1E0F7A0", Offset = "0x1E0F7A0", VA = "0x1E0F7A0")]
		private void DeleteRegularPrefs()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1E0F830", Offset = "0x1E0F830", VA = "0x1E0F830")]
		private void LoadObscuredPrefs()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1E100E8", Offset = "0x1E100E8", VA = "0x1E100E8")]
		private void SaveObscuredPrefs()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1E103F0", Offset = "0x1E103F0", VA = "0x1E103F0")]
		private void DeleteObscuredPrefs()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1E105EC", Offset = "0x1E105EC", VA = "0x1E105EC")]
		private void PlaceUrlButton(string url)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1E106E8", Offset = "0x1E106E8", VA = "0x1E106E8")]
		private void PlaceUrlButton(string url, int width)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1E105F4", Offset = "0x1E105F4", VA = "0x1E105F4")]
		private void PlaceUrlButton(string url, string buttonName, int width)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1E10744", Offset = "0x1E10744", VA = "0x1E10744")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1E10758", Offset = "0x1E10758", VA = "0x1E10758")]
		public ActTesterGui()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	internal class HorizontalLayout : IDisposable
	{
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1BF4614", Offset = "0x1BF4614", VA = "0x1BF4614")]
		public HorizontalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1BF4640", Offset = "0x1BF4640", VA = "0x1BF4640", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	internal class VerticalLayout : IDisposable
	{
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x27A5610", Offset = "0x27A5610", VA = "0x27A5610")]
		public VerticalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x27A563C", Offset = "0x27A563C", VA = "0x27A563C")]
		public VerticalLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x27A5724", Offset = "0x27A5724", VA = "0x27A5724", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA32A30", Offset = "0xA32A30")]
	public class ObscuredPerformanceTests : MonoBehaviour
	{
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool boolTest;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int boolIterations;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool byteTest;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int byteIterations;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool shortTest;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int shortIterations;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ushortTest;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int ushortIterations;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intTest;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int intIterations;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool uintTest;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int uintIterations;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool longTest;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int longIterations;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool floatTest;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int floatIterations;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool doubleTest;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int doubleIterations;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool stringTest;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int stringIterations;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool vector3Test;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int vector3Iterations;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool prefsTest;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int prefsIterations;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x2124778", Offset = "0x2124778", VA = "0x2124778")]
		private void Start()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x21247CC", Offset = "0x21247CC", VA = "0x21247CC")]
		private void StartTests()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2124934", Offset = "0x2124934", VA = "0x2124934")]
		private void TestBool()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2124C48", Offset = "0x2124C48", VA = "0x2124C48")]
		private void TestByte()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2124F48", Offset = "0x2124F48", VA = "0x2124F48")]
		private void TestShort()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2125244", Offset = "0x2125244", VA = "0x2125244")]
		private void TestUShort()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x21261CC", Offset = "0x21261CC", VA = "0x21261CC")]
		private void TestDouble()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2125E78", Offset = "0x2125E78", VA = "0x2125E78")]
		private void TestFloat()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x2125540", Offset = "0x2125540", VA = "0x2125540")]
		private void TestInt()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2125B5C", Offset = "0x2125B5C", VA = "0x2125B5C")]
		private void TestLong()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x21264F4", Offset = "0x21264F4", VA = "0x21264F4")]
		private void TestString()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2125848", Offset = "0x2125848", VA = "0x2125848")]
		private void TestUInt()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2126898", Offset = "0x2126898", VA = "0x2126898")]
		private void TestVector3()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2126CFC", Offset = "0x2126CFC", VA = "0x2126CFC")]
		private void TestPrefs()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x212782C", Offset = "0x212782C", VA = "0x212782C")]
		public ObscuredPerformanceTests()
		{
		}
	}
}
