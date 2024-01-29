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
using Oculus.Platform;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
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
[Token(Token = "0x2000003")]
public class CloudSave_Controller : MonoBehaviour, CloudSave_CoroutineCallback
{
	[Token(Token = "0x4000008")]
	public const string prefsKeyEmail = "CloudSave_email";

	[Token(Token = "0x4000009")]
	public const string prefsKeyPassword = "CloudSave_password";

	[Token(Token = "0x400000A")]
	public const string prefsKeyNoAutologinNextTime = "CloudSave_noAutoLoginNextTime";

	[Token(Token = "0x400000B")]
	public const string prefsKeyFirstTime = "CloudSave_FirstTime";

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static CloudSave_Controller instance;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CloudSave_Screen_CloudInfo cloudInfoScreen;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CloudSave_Screen_CloudInfo cloudInfoScreenLogin;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CloudSave_Screen_Login loginScreen;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CloudSave_Screen_Login autoLoginScreen;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CloudSave_Screen_Menu menuScreen;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CloudSave_Screen_ChangePassword changePasswordScreen;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CloudSave_Screen_ResetPassword resetPasswordScreen;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public CloudSave_Screen_Message messageScreen;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public CloudSave_Screen_Settings settingsScreen;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CloudSave_Screen_DeleteAccount deleteAccountScreen;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public CloudSave_Screen_RedeemCode redeemCodeScreen;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public CloudSave_Screen_TermsOfUse termsOfUseScreen;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static bool firstRun;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected CloudSave_ServerCoroutine_Login backgroundLoginCoroutine;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected float backgroundLoginStartTime;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected CloudSave_ServerCoroutine_StoreGameSave backgroundStoreCoroutine;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected float backgroundStoreStartTime;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected string lastStoredLocalSave;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected bool destroyingUnwantedThis;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	protected bool startFirtScreen;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	protected bool manualFirstLoginScreen;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	protected bool showConflictMessageAfterLoadLevel;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected CloudSave_Screen currentScreen;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected GameObject statusLineObject;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected DateTime lastStoreTime;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected bool lastStoreTimeValid;

	[Token(Token = "0x17000001")]
	public static CloudSave_Controller Instance
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1A60864", Offset = "0x1A60864", VA = "0x1A60864")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1A60948", Offset = "0x1A60948", VA = "0x1A60948")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1A60A60", Offset = "0x1A60A60", VA = "0x1A60A60")]
	public static void ResetLastSendTime()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1A60B34", Offset = "0x1A60B34", VA = "0x1A60B34")]
	public void SetLastStoreTime()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1A60BA4", Offset = "0x1A60BA4", VA = "0x1A60BA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1A61638", Offset = "0x1A61638", VA = "0x1A61638")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1A617A0", Offset = "0x1A617A0", VA = "0x1A617A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1A61BE0", Offset = "0x1A61BE0", VA = "0x1A61BE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1A61BE4", Offset = "0x1A61BE4", VA = "0x1A61BE4")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1A62224", Offset = "0x1A62224", VA = "0x1A62224")]
	public static bool WillOpenCloudStorageScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1A60EB4", Offset = "0x1A60EB4", VA = "0x1A60EB4")]
	private void StartFirstScreen()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1A625F4", Offset = "0x1A625F4", VA = "0x1A625F4", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1A625F8", Offset = "0x1A625F8", VA = "0x1A625F8", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1A61A28", Offset = "0x1A61A28", VA = "0x1A61A28", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1A61DD4", Offset = "0x1A61DD4", VA = "0x1A61DD4", Slot = "7")]
	public void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1A628A0", Offset = "0x1A628A0", VA = "0x1A628A0")]
	public void OnReceivedCloudSave(CloudSave_Screen onScreen, CloudSave_Saves cloudSaves, bool compareAndImport)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1A62BC0", Offset = "0x1A62BC0", VA = "0x1A62BC0")]
	public void OnSendSaveToCloud(CloudSave_Screen onScreen, CloudSave_Saves localSaves)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1A61F0C", Offset = "0x1A61F0C", VA = "0x1A61F0C")]
	public void TrySendChangedLocalSave()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1A636FC", Offset = "0x1A636FC", VA = "0x1A636FC")]
	public void TrySendDeletedSave()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1A619B0", Offset = "0x1A619B0", VA = "0x1A619B0")]
	protected void ShowConflictMessage()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1A63854", Offset = "0x1A63854", VA = "0x1A63854")]
	protected void ClearConflictMessage()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1A638CC", Offset = "0x1A638CC", VA = "0x1A638CC")]
	public bool IsLoggingIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1A624EC", Offset = "0x1A624EC", VA = "0x1A624EC")]
	protected void ShowScreen(CloudSave_Screen screen)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1A63938", Offset = "0x1A63938", VA = "0x1A63938")]
	public void On_CloudInfo_Yes()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1A63940", Offset = "0x1A63940", VA = "0x1A63940")]
	public void On_CloudInfo_No()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1A63944", Offset = "0x1A63944", VA = "0x1A63944")]
	public void On_CloudInfo_Back()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1A63A20", Offset = "0x1A63A20", VA = "0x1A63A20")]
	public void On_CloudInfo_CloseToLogin()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1A625D4", Offset = "0x1A625D4", VA = "0x1A625D4")]
	protected void ShowLoginScreen(bool autoLogin, bool manualFirstLogin)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1A63A28", Offset = "0x1A63A28", VA = "0x1A63A28")]
	public void On_LoginScreen_Back()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1A63AA4", Offset = "0x1A63AA4", VA = "0x1A63AA4")]
	public void On_LoginScreen_ShowInfo()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1A63AAC", Offset = "0x1A63AAC", VA = "0x1A63AAC")]
	public void On_LoginScreen_FailedAutoLogin()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1A63C28", Offset = "0x1A63C28", VA = "0x1A63C28")]
	public void OnSelectScreen_ShowLogin(bool showRegister)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1A63D88", Offset = "0x1A63D88", VA = "0x1A63D88")]
	public void On_LoginScreen_LoggedIn()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1A63EA0", Offset = "0x1A63EA0", VA = "0x1A63EA0")]
	public void On_LoginScreen_ResetPassword()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1A63ED4", Offset = "0x1A63ED4", VA = "0x1A63ED4")]
	public void On_MenuScreen_Back()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1A63F48", Offset = "0x1A63F48", VA = "0x1A63F48")]
	public void On_MenuScreen_Settings()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1A63F50", Offset = "0x1A63F50", VA = "0x1A63F50")]
	public void On_MenuScreen_SetPassword()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1A63F58", Offset = "0x1A63F58", VA = "0x1A63F58")]
	public void On_MenuScreen_Logout()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1A64038", Offset = "0x1A64038", VA = "0x1A64038")]
	public void On_ChangePasswordScreen_Back()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1A64040", Offset = "0x1A64040", VA = "0x1A64040")]
	public void On_ResetPasswordScreen_Back(bool backToSettings)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1A64054", Offset = "0x1A64054", VA = "0x1A64054")]
	public void ShowMessageScreen(string text, bool warning, CloudSave_Screen backToScreen, Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1A64128", Offset = "0x1A64128", VA = "0x1A64128")]
	public void On_MessageScreen_Closed(CloudSave_Screen backToScreen, Action<bool> resultCallback, bool result)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1A641B8", Offset = "0x1A641B8", VA = "0x1A641B8")]
	public void On_SettingsScreen_Back()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1A641C0", Offset = "0x1A641C0", VA = "0x1A641C0")]
	public void On_SettingsScreen_ChangePassword()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1A641C8", Offset = "0x1A641C8", VA = "0x1A641C8")]
	public void On_SettingsScreen_ResetPassword()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1A64200", Offset = "0x1A64200", VA = "0x1A64200")]
	public void On_SettingsScreen_DeleteAccount()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1A64208", Offset = "0x1A64208", VA = "0x1A64208")]
	public void On_DeleteAccountScreen_Back()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1A64210", Offset = "0x1A64210", VA = "0x1A64210")]
	public void On_DeleteAccountScreen_Deleted()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1A643FC", Offset = "0x1A643FC", VA = "0x1A643FC")]
	public void On_SettingsScreen_RedeemCode()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1A64404", Offset = "0x1A64404", VA = "0x1A64404")]
	public void On_RedeemCodeScreen_Back()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1A6440C", Offset = "0x1A6440C", VA = "0x1A6440C")]
	public void ShowTermsOfUseScreen(string email, string password, bool newsletter)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1A64464", Offset = "0x1A64464", VA = "0x1A64464")]
	public void On_TermsOfUseScreen_No()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1A6446C", Offset = "0x1A6446C", VA = "0x1A6446C")]
	public void On_TermsOfUseScreen_Completed()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1A64474", Offset = "0x1A64474", VA = "0x1A64474")]
	public CloudSave_Controller()
	{
	}
}
[Token(Token = "0x2000004")]
public static class CloudSave_Config
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string gameHashCode;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string URLtoServer;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool useEncryption;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string md5salt;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static int minPasswordLength;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int backgroundLoginTimeout;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static int backgroundStoreTimeout;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string cloudSaveSceneName;
}
[Token(Token = "0x2000005")]
public static class CloudSave_Debug
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool debugLog;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool testDeleteCloudPlayerPrefs;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool testEditorDontAutoLoginToMainMenu;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int testMinDelayBetweenSaves;
}
[Token(Token = "0x2000006")]
public interface CloudSave_CoroutineCallback
{
	[Token(Token = "0x600003A")]
	void OnStartCoroutine(CloudSave_ServerCoroutine coroutine);

	[Token(Token = "0x600003B")]
	void OnEndCoroutine(CloudSave_ServerCoroutine coroutine);

	[Token(Token = "0x600003C")]
	void InfoMessage(string strMsg, bool warning);

	[Token(Token = "0x600003D")]
	void InfoMessage(string strMsg1, string strMsg2, bool warning);
}
[Token(Token = "0x2000007")]
public class CloudSave_CoroutineCallback_InfoOnly : CloudSave_CoroutineCallback
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected CloudSave_CoroutineCallback baseCallback;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1A64518", Offset = "0x1A64518", VA = "0x1A64518")]
	public CloudSave_CoroutineCallback_InfoOnly(CloudSave_CoroutineCallback _baseCallback)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1A64544", Offset = "0x1A64544", VA = "0x1A64544", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1A64548", Offset = "0x1A64548", VA = "0x1A64548", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1A6454C", Offset = "0x1A6454C", VA = "0x1A6454C", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1A64620", Offset = "0x1A64620", VA = "0x1A64620", Slot = "7")]
	public void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}
}
[Token(Token = "0x2000008")]
public class CloudSave_GameInterface : MonoBehaviour
{
	[Token(Token = "0x2000094")]
	public enum CompareSaveResult
	{
		[Token(Token = "0x40003F0")]
		Equal,
		[Token(Token = "0x40003F1")]
		Better,
		[Token(Token = "0x40003F2")]
		Worse,
		[Token(Token = "0x40003F3")]
		Conflict
	}

	[Token(Token = "0x2000095")]
	public enum SoundType
	{
		[Token(Token = "0x40003F5")]
		ClickButton
	}

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CloudSave_GameInterface instance;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool destroyingUnwantedThis;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1A6477C", Offset = "0x1A6477C", VA = "0x1A6477C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1A648D4", Offset = "0x1A648D4", VA = "0x1A648D4", Slot = "4")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1A649AC", Offset = "0x1A649AC", VA = "0x1A649AC", Slot = "5")]
	public virtual string GetTextsLanguageID()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1A64A3C", Offset = "0x1A64A3C", VA = "0x1A64A3C", Slot = "6")]
	public virtual string TranslateText(string trl)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1A64ACC", Offset = "0x1A64ACC", VA = "0x1A64ACC", Slot = "7")]
	public virtual string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1A64B5C", Offset = "0x1A64B5C", VA = "0x1A64B5C", Slot = "8")]
	public virtual string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1A64BEC", Offset = "0x1A64BEC", VA = "0x1A64BEC", Slot = "9")]
	public virtual void BackToMainMenuScene()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1A64C60", Offset = "0x1A64C60", VA = "0x1A64C60", Slot = "10")]
	public virtual uint GetSaveCloudUserId()
	{
		return default(uint);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1A64CDC", Offset = "0x1A64CDC", VA = "0x1A64CDC", Slot = "11")]
	public virtual CloudSave_Saves ExportGameSaves()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1A64D7C", Offset = "0x1A64D7C", VA = "0x1A64D7C", Slot = "12")]
	public virtual void ImportGameSave(CloudSave_Saves cloudSaves)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1A64DF0", Offset = "0x1A64DF0", VA = "0x1A64DF0", Slot = "13")]
	public virtual void DeleteLocalSaveOnRegister()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1A64E64", Offset = "0x1A64E64", VA = "0x1A64E64", Slot = "14")]
	public virtual string GetSavePreviewLabels()
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1A64EF4", Offset = "0x1A64EF4", VA = "0x1A64EF4", Slot = "15")]
	public virtual string GetSavePreview(CloudSave_Saves save)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1A64F84", Offset = "0x1A64F84", VA = "0x1A64F84", Slot = "16")]
	public virtual CompareSaveResult CompareSave(CloudSave_Saves save1, CloudSave_Saves save2)
	{
		return default(CompareSaveResult);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1A65000", Offset = "0x1A65000", VA = "0x1A65000", Slot = "17")]
	public virtual bool CanSendChangedLocalSaveInCurrentLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1A6507C", Offset = "0x1A6507C", VA = "0x1A6507C", Slot = "18")]
	public virtual GameObject GetCloudStatusLineObject()
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1A650F8", Offset = "0x1A650F8", VA = "0x1A650F8", Slot = "19")]
	public virtual bool ShowCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1A65174", Offset = "0x1A65174", VA = "0x1A65174", Slot = "20")]
	public virtual bool ClearCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1A651F0", Offset = "0x1A651F0", VA = "0x1A651F0", Slot = "21")]
	public virtual void PlaySound(SoundType sndType)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1A65264", Offset = "0x1A65264", VA = "0x1A65264", Slot = "22")]
	public virtual void OnShowCloudScreens()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1A652D8", Offset = "0x1A652D8", VA = "0x1A652D8", Slot = "23")]
	public virtual bool HaveSaveForPromoCode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1A65354", Offset = "0x1A65354", VA = "0x1A65354", Slot = "24")]
	public virtual string GetPromoCodeSkuName(string sku)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1A653E4", Offset = "0x1A653E4", VA = "0x1A653E4", Slot = "25")]
	public virtual void OnUsePromoCode(string sku)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1A65458", Offset = "0x1A65458", VA = "0x1A65458")]
	public CloudSave_GameInterface()
	{
	}
}
[Token(Token = "0x2000009")]
public class CloudSave_Screen : MonoBehaviour, CloudSave_CoroutineCallback
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CloudSave_InfoMessage infoMessage;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1A660F0", Offset = "0x1A660F0", VA = "0x1A660F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1A661B4", Offset = "0x1A661B4", VA = "0x1A661B4", Slot = "8")]
	public virtual void ActivateScreen()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1A661B8", Offset = "0x1A661B8", VA = "0x1A661B8", Slot = "9")]
	public virtual void DeactivateScreen()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1A661BC", Offset = "0x1A661BC", VA = "0x1A661BC", Slot = "10")]
	public virtual void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1A661C0", Offset = "0x1A661C0", VA = "0x1A661C0", Slot = "11")]
	public virtual void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1A661C4", Offset = "0x1A661C4", VA = "0x1A661C4", Slot = "12")]
	public virtual void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1A66204", Offset = "0x1A66204", VA = "0x1A66204", Slot = "13")]
	public virtual void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1A662A4", Offset = "0x1A662A4", VA = "0x1A662A4")]
	public void ClearInfoMessage()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1A66300", Offset = "0x1A66300", VA = "0x1A66300", Slot = "14")]
	public virtual void SetInfoMessageText(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1A663A8", Offset = "0x1A663A8", VA = "0x1A663A8")]
	protected string TranslateText(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1A62E78", Offset = "0x1A62E78", VA = "0x1A62E78")]
	public static string TranslateTextWithErrorParse(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1A66424", Offset = "0x1A66424", VA = "0x1A66424")]
	public CloudSave_Screen()
	{
	}
}
[Token(Token = "0x200000A")]
public class CloudSave_ServerCoroutine : MonoBehaviour
{
	[Token(Token = "0x2000096")]
	public enum CoroutineType
	{
		[Token(Token = "0x40003F7")]
		ChangePassword,
		[Token(Token = "0x40003F8")]
		LoadGameSave,
		[Token(Token = "0x40003F9")]
		Login,
		[Token(Token = "0x40003FA")]
		OpenSSLSession,
		[Token(Token = "0x40003FB")]
		SendResetPassword,
		[Token(Token = "0x40003FC")]
		StoreGameSave,
		[Token(Token = "0x40003FD")]
		SetNewsletter,
		[Token(Token = "0x40003FE")]
		DeleteAccount,
		[Token(Token = "0x40003FF")]
		RedeemCode
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBA4C", Offset = "0x8EBA4C")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1CB3D1C", Offset = "0x1CB3D1C", VA = "0x1CB3D1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1CB3D64", Offset = "0x1CB3D64", VA = "0x1CB3D64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1CB3C5C", Offset = "0x1CB3C5C", VA = "0x1CB3C5C")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1CB3C88", Offset = "0x1CB3C88", VA = "0x1CB3C88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1CB3C8C", Offset = "0x1CB3C8C", VA = "0x1CB3C8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1CB3D24", Offset = "0x1CB3D24", VA = "0x1CB3D24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected CloudSave_CoroutineCallback callback;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected bool isRunning;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1AB9B8C", Offset = "0x1AB9B8C", VA = "0x1AB9B8C")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1ABD15C", Offset = "0x1ABD15C", VA = "0x1ABD15C")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback, bool dontDestroyOnLoad)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1ABD44C", Offset = "0x1ABD44C", VA = "0x1ABD44C", Slot = "4")]
	public virtual CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1ABD4C8", Offset = "0x1ABD4C8", VA = "0x1ABD4C8", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED4D0", Offset = "0x8ED4D0")]
	public virtual IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1ABD524", Offset = "0x1ABD524", VA = "0x1ABD524", Slot = "6")]
	public virtual bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1AB9C30", Offset = "0x1AB9C30", VA = "0x1AB9C30")]
	public void Destroy()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1ABD5A0", Offset = "0x1ABD5A0", VA = "0x1ABD5A0")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1ABD5A8", Offset = "0x1ABD5A8", VA = "0x1ABD5A8")]
	protected void CallOnStart()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1ABD668", Offset = "0x1ABD668", VA = "0x1ABD668")]
	protected void CallOnEnd()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1ABD728", Offset = "0x1ABD728", VA = "0x1ABD728")]
	protected void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1ABD7FC", Offset = "0x1ABD7FC", VA = "0x1ABD7FC")]
	protected void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1ABD8E4", Offset = "0x1ABD8E4", VA = "0x1ABD8E4")]
	protected string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1ABD958", Offset = "0x1ABD958", VA = "0x1ABD958")]
	protected string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1ABD9CC", Offset = "0x1ABD9CC", VA = "0x1ABD9CC")]
	public CloudSave_ServerCoroutine()
	{
	}
}
[Token(Token = "0x200000B")]
public class CloudSave_StoreLogin
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool useObscured;

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1ABB99C", Offset = "0x1ABB99C", VA = "0x1ABB99C")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1ABBA50", Offset = "0x1ABBA50", VA = "0x1ABBA50")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1ABEA74", Offset = "0x1ABEA74", VA = "0x1ABEA74")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1ABEB40", Offset = "0x1ABEB40", VA = "0x1ABEB40")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1ABEBF4", Offset = "0x1ABEBF4", VA = "0x1ABEBF4")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1ABECC0", Offset = "0x1ABECC0", VA = "0x1ABECC0")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1ABED74", Offset = "0x1ABED74", VA = "0x1ABED74")]
	public static void Save()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1ABEE1C", Offset = "0x1ABEE1C", VA = "0x1ABEE1C")]
	public CloudSave_StoreLogin()
	{
	}
}
[Token(Token = "0x200000C")]
public class CloudSave_Translate : MonoBehaviour
{
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string oryginalText;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool translated;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1ABEE74", Offset = "0x1ABEE74", VA = "0x1ABEE74")]
	public void Start()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1ABF048", Offset = "0x1ABF048", VA = "0x1ABF048")]
	public bool IsTranslated()
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1ABEE78", Offset = "0x1ABEE78", VA = "0x1ABEE78")]
	public void TranslateText()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1ABF050", Offset = "0x1ABF050", VA = "0x1ABF050")]
	public void TranslateFromStart()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1ABF0B8", Offset = "0x1ABF0B8", VA = "0x1ABF0B8")]
	public CloudSave_Translate()
	{
	}
}
[Token(Token = "0x200000D")]
public class CloudSave_Save
{
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string save;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<KeyValuePair<string, string>> properties;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1A656A0", Offset = "0x1A656A0", VA = "0x1A656A0")]
	public CloudSave_Save()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1A65718", Offset = "0x1A65718", VA = "0x1A65718")]
	public CloudSave_Save(string _save)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1A657A4", Offset = "0x1A657A4", VA = "0x1A657A4")]
	public CloudSave_Save(string _save, List<KeyValuePair<string, string>> _properties)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1A6597C", Offset = "0x1A6597C", VA = "0x1A6597C")]
	public CloudSave_Save Clone()
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
public class CloudSave_Saves
{
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected List<KeyValuePair<string, CloudSave_Save>> saves;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1A63118", Offset = "0x1A63118", VA = "0x1A63118")]
	public CloudSave_Saves()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1A659E8", Offset = "0x1A659E8", VA = "0x1A659E8")]
	public CloudSave_Saves(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1A62F8C", Offset = "0x1A62F8C", VA = "0x1A62F8C")]
	public void Copy(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1A65A78", Offset = "0x1A65A78", VA = "0x1A65A78")]
	public void AddSave(string name, string save)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1A65C38", Offset = "0x1A65C38", VA = "0x1A65C38")]
	public void AddSave(string name, string save, List<KeyValuePair<string, string>> properties)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1A65E0C", Offset = "0x1A65E0C", VA = "0x1A65E0C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1A636B0", Offset = "0x1A636B0", VA = "0x1A636B0")]
	public int GetSavesCount()
	{
		return default(int);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1A63190", Offset = "0x1A63190", VA = "0x1A63190")]
	public string GetSaveName(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1A65E60", Offset = "0x1A65E60", VA = "0x1A65E60")]
	public string GetSave(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1A633CC", Offset = "0x1A633CC", VA = "0x1A633CC")]
	public List<KeyValuePair<string, string>> GetSaveProperties(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1A632F8", Offset = "0x1A632F8", VA = "0x1A632F8")]
	public bool HaveSave(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1A65FD0", Offset = "0x1A65FD0", VA = "0x1A65FD0")]
	public string GetSave(string name)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1A63564", Offset = "0x1A63564", VA = "0x1A63564")]
	public List<KeyValuePair<string, string>> GetSaveProperties(string name)
	{
		return null;
	}
}
[Token(Token = "0x200000F")]
public static class CloudSave_UserSession
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string logged_email;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string logged_password;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static uint logged_account_id;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string logged_player_name;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static uint logged_clan_id;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string logged_clan_tag;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static bool newsletter_agree;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string logged_ban_info;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string add_sku_items;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string add_player_gifts;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string active_tournament_info;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string active_tournament_info_saved;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string active_challangesOfTheDay_info;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static bool cloudSaveReceived;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static CloudSave_Saves cloudSaves;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static int minimumDelayBetweenSavesInMinutes;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public static bool everyCloudEnterLoginsToServer;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string session_id;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string publicModulus;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string publicExponent;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static string AES_Key;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static string AES_IV;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static string uidAlphabet;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static int uidLength;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1ABE4D8", Offset = "0x1ABE4D8", VA = "0x1ABE4D8")]
	public static bool IsEncryptionEstablished()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1ABF10C", Offset = "0x1ABF10C", VA = "0x1ABF10C")]
	public static bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1ABF1E0", Offset = "0x1ABF1E0", VA = "0x1ABF1E0")]
	public static void clearUser()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1ABF2E0", Offset = "0x1ABF2E0", VA = "0x1ABF2E0")]
	public static void clearUserAndSession()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1ABF380", Offset = "0x1ABF380", VA = "0x1ABF380")]
	public static uint GetAccountIDChecksum(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1ABF454", Offset = "0x1ABF454", VA = "0x1ABF454")]
	public static uint GetUIDFromAccountID(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1ABA44C", Offset = "0x1ABA44C", VA = "0x1ABA44C")]
	public static string GetStringUIDFromAccountID(uint id)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1ABF4C8", Offset = "0x1ABF4C8", VA = "0x1ABF4C8")]
	public static bool GetAccountIDFromStringUID(string suid, out uint id)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000010")]
public static class CloudSave_Utils
{
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1ABF828", Offset = "0x1ABF828", VA = "0x1ABF828")]
	public static string RSA_encrypt(string toBeEncrypted)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1ABF82C", Offset = "0x1ABF82C", VA = "0x1ABF82C")]
	public static void generateAESkeyAndIV()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1ABF830", Offset = "0x1ABF830", VA = "0x1ABF830")]
	public static string AES_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1ABF838", Offset = "0x1ABF838", VA = "0x1ABF838")]
	public static string AES_encrypt(string input, bool MD5)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1ABE054", Offset = "0x1ABE054", VA = "0x1ABE054")]
	public static string AES_decrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1ABFA08", Offset = "0x1ABFA08", VA = "0x1ABFA08")]
	private static string GetMd5Hash(MD5 md5Hash, string input)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1ABF8B4", Offset = "0x1ABF8B4", VA = "0x1ABF8B4")]
	public static string MD5_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1ABE138", Offset = "0x1ABE138", VA = "0x1ABE138")]
	public static string MD5_encryptWithSalt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1ABFB3C", Offset = "0x1ABFB3C", VA = "0x1ABFB3C")]
	public static string convertBytesToString(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1ABFB84", Offset = "0x1ABFB84", VA = "0x1ABFB84")]
	public static byte[] convertStringToBytes(string s)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1ABBFDC", Offset = "0x1ABBFDC", VA = "0x1ABBFDC")]
	public static bool TestValidEmailFormat(string email)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1ABFBC0", Offset = "0x1ABFBC0", VA = "0x1ABFBC0")]
	public static bool GetValueInsideTag(string text, string tag, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1ABFD8C", Offset = "0x1ABFD8C", VA = "0x1ABFD8C")]
	public static string[] GetValuesInsideTags(string text, string tag)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1ABFFD4", Offset = "0x1ABFFD4", VA = "0x1ABFFD4")]
	public static Dictionary<string, string> ParseKeysAssignedValues(string text, char delimeter)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1AC01C8", Offset = "0x1AC01C8", VA = "0x1AC01C8")]
	public static bool GetValueOfTag(string text, string valTag, out string outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1AC0288", Offset = "0x1AC0288", VA = "0x1AC0288")]
	public static Dictionary<string, string> GetTagsAndValues(string text)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1AC0428", Offset = "0x1AC0428", VA = "0x1AC0428")]
	public static bool GetIntValueOfTag(string text, string valTag, out int outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1AC04D0", Offset = "0x1AC04D0", VA = "0x1AC04D0")]
	public static bool ParseErrorCode(string text, out string errorText, out string errorExtCode)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1AC062C", Offset = "0x1AC062C", VA = "0x1AC062C")]
	public static string GetUrlWithSecureProtocol(string url)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1AC06F8", Offset = "0x1AC06F8", VA = "0x1AC06F8")]
	public static string GetWebGLUrlProxy(string url)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1AC06FC", Offset = "0x1AC06FC", VA = "0x1AC06FC")]
	public static string GenRandomString(int len)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1AC07C8", Offset = "0x1AC07C8", VA = "0x1AC07C8")]
	public static string EncodeBase64(string plain)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1AC0858", Offset = "0x1AC0858", VA = "0x1AC0858")]
	public static string DecodeBase64(string encoded)
	{
		return null;
	}
}
[Token(Token = "0x2000011")]
public class CloudSave_ServerCoroutine_ChangePassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBA5C", Offset = "0x8EBA5C")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_ChangePassword <>4__this;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1CB4440", Offset = "0x1CB4440", VA = "0x1CB4440", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1CB4488", Offset = "0x1CB4488", VA = "0x1CB4488", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1CB3D6C", Offset = "0x1CB3D6C", VA = "0x1CB3D6C")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1CB3D98", Offset = "0x1CB3D98", VA = "0x1CB3D98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1CB3D9C", Offset = "0x1CB3D9C", VA = "0x1CB3D9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1CB4448", Offset = "0x1CB4448", VA = "0x1CB4448", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string oldPassword;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected string newPassword;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected bool changePasswordResult;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1ABD9D4", Offset = "0x1ABD9D4", VA = "0x1ABD9D4")]
	public void InitParams(string _oldPassword, string _newPassword)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1ABD9DC", Offset = "0x1ABD9DC", VA = "0x1ABD9DC", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1ABD9E4", Offset = "0x1ABD9E4", VA = "0x1ABD9E4", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1ABD9EC", Offset = "0x1ABD9EC", VA = "0x1ABD9EC", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED530", Offset = "0x8ED530")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1ABDA58", Offset = "0x1ABDA58", VA = "0x1ABDA58")]
	public CloudSave_ServerCoroutine_ChangePassword()
	{
	}
}
[Token(Token = "0x2000012")]
public class CloudSave_ServerCoroutine_DeleteAccount : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBA6C", Offset = "0x8EBA6C")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_DeleteAccount <>4__this;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1CB4AE8", Offset = "0x1CB4AE8", VA = "0x1CB4AE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1CB4B30", Offset = "0x1CB4B30", VA = "0x1CB4B30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1CB4490", Offset = "0x1CB4490", VA = "0x1CB4490")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1CB44BC", Offset = "0x1CB44BC", VA = "0x1CB44BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1CB44C0", Offset = "0x1CB44C0", VA = "0x1CB44C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1CB4AF0", Offset = "0x1CB4AF0", VA = "0x1CB4AF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string password;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool result;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1ABDAAC", Offset = "0x1ABDAAC", VA = "0x1ABDAAC")]
	public void InitParams(string _password)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1ABDAB4", Offset = "0x1ABDAB4", VA = "0x1ABDAB4", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1ABDABC", Offset = "0x1ABDABC", VA = "0x1ABDABC", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1ABDAC4", Offset = "0x1ABDAC4", VA = "0x1ABDAC4", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED590", Offset = "0x8ED590")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1ABDB30", Offset = "0x1ABDB30", VA = "0x1ABDB30")]
	public CloudSave_ServerCoroutine_DeleteAccount()
	{
	}
}
[Token(Token = "0x2000013")]
public class CloudSave_ServerCoroutine_LoadGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBA7C", Offset = "0x8EBA7C")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_LoadGameSave <>4__this;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1CB5190", Offset = "0x1CB5190", VA = "0x1CB5190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1CB51D8", Offset = "0x1CB51D8", VA = "0x1CB51D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1CB4B38", Offset = "0x1CB4B38", VA = "0x1CB4B38")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1CB4B64", Offset = "0x1CB4B64", VA = "0x1CB4B64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1CB4B68", Offset = "0x1CB4B68", VA = "0x1CB4B68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1CB5198", Offset = "0x1CB5198", VA = "0x1CB5198", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected CloudSave_Saves loadedSaves;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool loadSaveResult;

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1ABDB84", Offset = "0x1ABDB84", VA = "0x1ABDB84", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1ABDB8C", Offset = "0x1ABDB8C", VA = "0x1ABDB8C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1ABA3C4", Offset = "0x1ABA3C4", VA = "0x1ABA3C4")]
	public CloudSave_Saves GetResultLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1ABDB94", Offset = "0x1ABDB94", VA = "0x1ABDB94")]
	public static bool ParseSavesFromServer(string text, CloudSave_Saves localSaves, out CloudSave_Saves outSaves)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1ABE1AC", Offset = "0x1ABE1AC", VA = "0x1ABE1AC", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED5F0", Offset = "0x8ED5F0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1ABE218", Offset = "0x1ABE218", VA = "0x1ABE218")]
	public CloudSave_ServerCoroutine_LoadGameSave()
	{
	}
}
[Token(Token = "0x2000014")]
public class CloudSave_ServerCoroutine_Login : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBA8C", Offset = "0x8EBA8C")]
	private sealed class <Run>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_Login <>4__this;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1CB5FFC", Offset = "0x1CB5FFC", VA = "0x1CB5FFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1CB6044", Offset = "0x1CB6044", VA = "0x1CB6044", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1CB51E0", Offset = "0x1CB51E0", VA = "0x1CB51E0")]
		[DebuggerHidden]
		public <Run>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1CB520C", Offset = "0x1CB520C", VA = "0x1CB520C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1CB5210", Offset = "0x1CB5210", VA = "0x1CB5210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1CB6004", Offset = "0x1CB6004", VA = "0x1CB6004", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	protected bool register;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string email;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected string password;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected bool newsletter;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected CloudSave_Saves localSavesToCompare;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool loginResult;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	protected bool loadSaveResult;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected CloudSave_Saves loadedSaves;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static bool firstLogin;

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1ABD038", Offset = "0x1ABD038", VA = "0x1ABD038")]
	public void InitParams(bool _register, string _email, string _password, bool _newsletter, CloudSave_Saves _localSavesToCompare)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1ABE27C", Offset = "0x1ABE27C", VA = "0x1ABE27C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1ABE284", Offset = "0x1ABE284", VA = "0x1ABE284", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1ABE28C", Offset = "0x1ABE28C", VA = "0x1ABE28C")]
	public bool GetLoadSaveResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1ABE294", Offset = "0x1ABE294", VA = "0x1ABE294")]
	public CloudSave_Saves GetLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1ABE31C", Offset = "0x1ABE31C", VA = "0x1ABE31C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED650", Offset = "0x8ED650")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1ABE388", Offset = "0x1ABE388", VA = "0x1ABE388")]
	public CloudSave_ServerCoroutine_Login()
	{
	}
}
[Token(Token = "0x2000015")]
public class CloudSave_ServerCoroutine_OpenSSLSession : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBA9C", Offset = "0x8EBA9C")]
	private sealed class <Run>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_OpenSSLSession <>4__this;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWWwrapper <w>5__2;

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1CB6DFC", Offset = "0x1CB6DFC", VA = "0x1CB6DFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1CB6E44", Offset = "0x1CB6E44", VA = "0x1CB6E44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1CB670C", Offset = "0x1CB670C", VA = "0x1CB670C")]
		[DebuggerHidden]
		public <Run>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1CB6738", Offset = "0x1CB6738", VA = "0x1CB6738", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1CB673C", Offset = "0x1CB673C", VA = "0x1CB673C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1CB6E04", Offset = "0x1CB6E04", VA = "0x1CB6E04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBAAC", Offset = "0x8EBAAC")]
	private sealed class <EstablishAESSecurity>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_OpenSSLSession <>4__this;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWWwrapper <w>5__2;

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1CB66BC", Offset = "0x1CB66BC", VA = "0x1CB66BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x1CB6704", Offset = "0x1CB6704", VA = "0x1CB6704", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1CB604C", Offset = "0x1CB604C", VA = "0x1CB604C")]
		[DebuggerHidden]
		public <EstablishAESSecurity>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1CB6078", Offset = "0x1CB6078", VA = "0x1CB6078", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1CB607C", Offset = "0x1CB607C", VA = "0x1CB607C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1CB66C4", Offset = "0x1CB66C4", VA = "0x1CB66C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int aesTry;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1ABE478", Offset = "0x1ABE478", VA = "0x1ABE478", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1ABE480", Offset = "0x1ABE480", VA = "0x1ABE480", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1ABE660", Offset = "0x1ABE660", VA = "0x1ABE660", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED6B0", Offset = "0x8ED6B0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1ABE6CC", Offset = "0x1ABE6CC", VA = "0x1ABE6CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED710", Offset = "0x8ED710")]
	protected IEnumerator EstablishAESSecurity()
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1ABE738", Offset = "0x1ABE738", VA = "0x1ABE738")]
	public CloudSave_ServerCoroutine_OpenSSLSession()
	{
	}
}
[Token(Token = "0x2000016")]
public class CloudSave_ServerCoroutine_RedeemCode : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBABC", Offset = "0x8EBABC")]
	private sealed class <Run>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_RedeemCode <>4__this;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x1CB7504", Offset = "0x1CB7504", VA = "0x1CB7504", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1CB754C", Offset = "0x1CB754C", VA = "0x1CB754C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1CB6E4C", Offset = "0x1CB6E4C", VA = "0x1CB6E4C")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1CB6E78", Offset = "0x1CB6E78", VA = "0x1CB6E78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1CB6E7C", Offset = "0x1CB6E7C", VA = "0x1CB6E7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1CB750C", Offset = "0x1CB750C", VA = "0x1CB750C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string code;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool result;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected string resultSku;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1ABE740", Offset = "0x1ABE740", VA = "0x1ABE740")]
	public void InitParams(string _code)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1ABE748", Offset = "0x1ABE748", VA = "0x1ABE748", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1ABE750", Offset = "0x1ABE750", VA = "0x1ABE750", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1ABE758", Offset = "0x1ABE758", VA = "0x1ABE758")]
	public string GetResultSku()
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1ABE760", Offset = "0x1ABE760", VA = "0x1ABE760", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED770", Offset = "0x8ED770")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1ABE7CC", Offset = "0x1ABE7CC", VA = "0x1ABE7CC")]
	public CloudSave_ServerCoroutine_RedeemCode()
	{
	}
}
[Token(Token = "0x2000017")]
public class CloudSave_ServerCoroutine_SendResetPassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBACC", Offset = "0x8EBACC")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_SendResetPassword <>4__this;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x20AE328", Offset = "0x20AE328", VA = "0x20AE328", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x20AE370", Offset = "0x20AE370", VA = "0x20AE370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x20ADC88", Offset = "0x20ADC88", VA = "0x20ADC88")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x20ADCB4", Offset = "0x20ADCB4", VA = "0x20ADCB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x20ADCB8", Offset = "0x20ADCB8", VA = "0x20ADCB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x20AE330", Offset = "0x20AE330", VA = "0x20AE330", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string email;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool sendResetResult;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1ABE824", Offset = "0x1ABE824", VA = "0x1ABE824")]
	public void InitParams(string _email)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1ABE82C", Offset = "0x1ABE82C", VA = "0x1ABE82C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1ABE834", Offset = "0x1ABE834", VA = "0x1ABE834", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1ABE83C", Offset = "0x1ABE83C", VA = "0x1ABE83C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED7D0", Offset = "0x8ED7D0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1ABE8A8", Offset = "0x1ABE8A8", VA = "0x1ABE8A8")]
	public CloudSave_ServerCoroutine_SendResetPassword()
	{
	}
}
[Token(Token = "0x2000018")]
public class CloudSave_ServerCoroutine_SetNewsletter : CloudSave_ServerCoroutine
{
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBADC", Offset = "0x8EBADC")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_SetNewsletter <>4__this;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x20AEA48", Offset = "0x20AEA48", VA = "0x20AEA48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x20AEA90", Offset = "0x20AEA90", VA = "0x20AEA90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x20AE378", Offset = "0x20AE378", VA = "0x20AE378")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x20AE3A4", Offset = "0x20AE3A4", VA = "0x20AE3A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x20AE3A8", Offset = "0x20AE3A8", VA = "0x20AE3A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x20AEA50", Offset = "0x20AEA50", VA = "0x20AEA50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	protected bool signed;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	protected bool result;

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1ABE8FC", Offset = "0x1ABE8FC", VA = "0x1ABE8FC")]
	public void InitParams(bool _signed)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1ABE908", Offset = "0x1ABE908", VA = "0x1ABE908", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1ABE910", Offset = "0x1ABE910", VA = "0x1ABE910", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1ABE918", Offset = "0x1ABE918", VA = "0x1ABE918", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED830", Offset = "0x8ED830")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1ABE984", Offset = "0x1ABE984", VA = "0x1ABE984")]
	public CloudSave_ServerCoroutine_SetNewsletter()
	{
	}
}
[Token(Token = "0x2000019")]
public class CloudSave_ServerCoroutine_StoreGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBAEC", Offset = "0x8EBAEC")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_StoreGameSave <>4__this;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x20AFC44", Offset = "0x20AFC44", VA = "0x20AFC44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x20AFC8C", Offset = "0x20AFC8C", VA = "0x20AFC8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x20AEA98", Offset = "0x20AEA98", VA = "0x20AEA98")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x20AEAC4", Offset = "0x20AEAC4", VA = "0x20AEAC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x20AEAC8", Offset = "0x20AEAC8", VA = "0x20AEAC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x20AFC4C", Offset = "0x20AFC4C", VA = "0x20AFC4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected CloudSave_Saves storeSaves;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool storeGameResult;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1ABADB8", Offset = "0x1ABADB8", VA = "0x1ABADB8")]
	public void InitParams(CloudSave_Saves _storeSaves)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1ABE98C", Offset = "0x1ABE98C", VA = "0x1ABE98C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1ABE994", Offset = "0x1ABE994", VA = "0x1ABE994", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1ABE99C", Offset = "0x1ABE99C", VA = "0x1ABE99C")]
	public CloudSave_Saves GetStoringSaves()
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1ABE9A4", Offset = "0x1ABE9A4", VA = "0x1ABE9A4", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED890", Offset = "0x8ED890")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1ABEA10", Offset = "0x1ABEA10", VA = "0x1ABEA10")]
	public CloudSave_ServerCoroutine_StoreGameSave()
	{
	}
}
[Token(Token = "0x200001A")]
public class CloudSave_Screen_ChangePassword : CloudSave_Screen
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh emailText;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MUI_InputText oldPasswordField;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MUI_InputText newPasswordField;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MUI_InputText repeatNewPasswordField;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CloudSave_Checkbox toggleShowOldPassword;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CloudSave_Checkbox toggleShowNewPassword;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public CloudSave_Checkbox toggleShowRepeatPassword;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CloudSave_ServerCoroutine_ChangePassword runningCoroutine;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string newPassword;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool passwordChanged;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1A6642C", Offset = "0x1A6642C", VA = "0x1A6642C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1A66674", Offset = "0x1A66674", VA = "0x1A66674", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1A66718", Offset = "0x1A66718", VA = "0x1A66718", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1A667F4", Offset = "0x1A667F4", VA = "0x1A667F4", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1A66A08", Offset = "0x1A66A08", VA = "0x1A66A08")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1A66A70", Offset = "0x1A66A70", VA = "0x1A66A70")]
	public void OnSwitchShowOldPassword(bool on)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1A66B30", Offset = "0x1A66B30", VA = "0x1A66B30")]
	public void OnSwitchShowNewPassword(bool on)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1A66B38", Offset = "0x1A66B38", VA = "0x1A66B38")]
	public void OnSwitchShowRepeatPassword(bool on)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1A66A78", Offset = "0x1A66A78", VA = "0x1A66A78")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1A66B40", Offset = "0x1A66B40", VA = "0x1A66B40")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1A66E50", Offset = "0x1A66E50", VA = "0x1A66E50")]
	public CloudSave_Screen_ChangePassword()
	{
	}
}
[Token(Token = "0x200001B")]
public class CloudSave_Screen_CloudInfo : CloudSave_Screen
{
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBAFC", Offset = "0x8EBAFC")]
	private sealed class <AnimDotsCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_Screen_CloudInfo <>4__this;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <idx>5__2;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <startTime>5__3;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 <scaleFrom>5__4;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 <scaleTo>5__5;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1CB3C0C", Offset = "0x1CB3C0C", VA = "0x1CB3C0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1CB3C54", Offset = "0x1CB3C54", VA = "0x1CB3C54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1CB38C0", Offset = "0x1CB38C0", VA = "0x1CB38C0")]
		[DebuggerHidden]
		public <AnimDotsCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1CB38EC", Offset = "0x1CB38EC", VA = "0x1CB38EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1CB38F0", Offset = "0x1CB38F0", VA = "0x1CB38F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1CB3C14", Offset = "0x1CB3C14", VA = "0x1CB3C14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] animDots;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject animDotBig;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float animSpeed;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected Vector3 scaleDot;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Vector3 scaleDotBig;

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1A66EA4", Offset = "0x1A66EA4", VA = "0x1A66EA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1A66FA0", Offset = "0x1A66FA0", VA = "0x1A66FA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1A66FA4", Offset = "0x1A66FA4", VA = "0x1A66FA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1A6703C", Offset = "0x1A6703C", VA = "0x1A6703C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1A67064", Offset = "0x1A67064", VA = "0x1A67064", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1A6708C", Offset = "0x1A6708C", VA = "0x1A6708C")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1A670F4", Offset = "0x1A670F4", VA = "0x1A670F4")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1A67158", Offset = "0x1A67158", VA = "0x1A67158")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1A671BC", Offset = "0x1A671BC", VA = "0x1A671BC")]
	public void OnClickCloseToLogin()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1A66FD0", Offset = "0x1A66FD0", VA = "0x1A66FD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED8F0", Offset = "0x8ED8F0")]
	protected IEnumerator AnimDotsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1A67224", Offset = "0x1A67224", VA = "0x1A67224")]
	public CloudSave_Screen_CloudInfo()
	{
	}
}
[Token(Token = "0x200001C")]
public class CloudSave_Screen_DeleteAccount : CloudSave_Screen
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText passwordField;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CloudSave_Checkbox toggleShowPassword;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CloudSave_ServerCoroutine_DeleteAccount runningCoroutine;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1A67234", Offset = "0x1A67234", VA = "0x1A67234", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1A67320", Offset = "0x1A67320", VA = "0x1A67320", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1A673C4", Offset = "0x1A673C4", VA = "0x1A673C4", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1A674A0", Offset = "0x1A674A0", VA = "0x1A674A0", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1A67620", Offset = "0x1A67620", VA = "0x1A67620")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1A67688", Offset = "0x1A67688", VA = "0x1A67688")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1A676E0", Offset = "0x1A676E0", VA = "0x1A676E0")]
	public void OnClickDelete()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1A67834", Offset = "0x1A67834", VA = "0x1A67834")]
	public CloudSave_Screen_DeleteAccount()
	{
	}
}
[Token(Token = "0x200001D")]
public class CloudSave_Screen_Login : CloudSave_Screen
{
	[Token(Token = "0x20000A3")]
	private enum Mode
	{
		[Token(Token = "0x400043A")]
		Register,
		[Token(Token = "0x400043B")]
		Login
	}

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CloudSave_Checkbox switchLoginButtonCheckbox;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CloudSave_Checkbox switchRegisterButtonCheckbox;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMesh loginButtonText;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MUI_InputText emailField;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MUI_InputText passwordField;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MUI_InputText repeatPasswordField;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public CloudSave_Checkbox toggleShowPassword1;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public CloudSave_Checkbox toggleShowPassword2;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CloudSave_Checkbox newsletterToggle;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject newsletterText;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject newsletterInfoButton;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool isAutoLogin;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float switchSelectedSizeMul;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private CloudSave_ServerCoroutine_Login runningCoroutine;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Mode mode;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string email;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string password;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string confirmRegisterEmail;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string confirmRegisterPassword;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool confirmNewsletter;

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1A6783C", Offset = "0x1A6783C", VA = "0x1A6783C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1A678B4", Offset = "0x1A678B4", VA = "0x1A678B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1A678B8", Offset = "0x1A678B8", VA = "0x1A678B8", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1A67FC4", Offset = "0x1A67FC4", VA = "0x1A67FC4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1A68068", Offset = "0x1A68068", VA = "0x1A68068")]
	public void OnBackFromTermsOfUse(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1A681FC", Offset = "0x1A681FC", VA = "0x1A681FC")]
	public void OnBackFromTermsOfUseLogin(string _email, string _password, bool _newsletter, CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1A68720", Offset = "0x1A68720", VA = "0x1A68720", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1A687FC", Offset = "0x1A687FC", VA = "0x1A687FC", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1A68230", Offset = "0x1A68230", VA = "0x1A68230")]
	protected void OnEndCoroutine(CloudSave_ServerCoroutine coroutine, bool fromTermsOfUse)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1A67D44", Offset = "0x1A67D44", VA = "0x1A67D44")]
	private void UpdateModeFields()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1A67BBC", Offset = "0x1A67BBC", VA = "0x1A67BBC")]
	private void LoadFromPlayerPrefs()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1A688E8", Offset = "0x1A688E8", VA = "0x1A688E8")]
	private void OnLogin(bool confirmDeleteSaveOnRegister)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1A68F20", Offset = "0x1A68F20", VA = "0x1A68F20")]
	private void DeleteSaveOnRegisterCallback(bool result)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1A6903C", Offset = "0x1A6903C", VA = "0x1A6903C")]
	private void DeleteSaveOnLoginToEmptyCallback(bool result)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1A69160", Offset = "0x1A69160", VA = "0x1A69160")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1A691C4", Offset = "0x1A691C4", VA = "0x1A691C4")]
	public void OnClickShowInfo()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1A63CFC", Offset = "0x1A63CFC", VA = "0x1A63CFC")]
	public void OnClickSwitchLogin(bool switched)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1A63C74", Offset = "0x1A63C74", VA = "0x1A63C74")]
	public void OnClickSwitchRegister(bool switched)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1A67FBC", Offset = "0x1A67FBC", VA = "0x1A67FBC")]
	public void OnClickLogin()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1A6922C", Offset = "0x1A6922C", VA = "0x1A6922C")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1A692E4", Offset = "0x1A692E4", VA = "0x1A692E4")]
	public void OnSwitchShowPassword1(bool on)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1A69378", Offset = "0x1A69378", VA = "0x1A69378")]
	public void OnSwitchShowPassword2(bool on)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1A692EC", Offset = "0x1A692EC", VA = "0x1A692EC")]
	public void OnSwitchShowPassword(int num, bool on)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1A69380", Offset = "0x1A69380", VA = "0x1A69380")]
	public CloudSave_Screen_Login()
	{
	}
}
[Token(Token = "0x200001E")]
public class CloudSave_Screen_Menu : CloudSave_Screen
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh loginInfoText;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMesh loginInfoText2;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMesh[] previewLabelsText;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMesh localSavePreviewText;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMesh cloudSavePreviewText;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject importButton;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject importButtonDisabled;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject exportButton;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject exportButtonDisabled;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public CloudSave_Checkbox checkboxShowEmail;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private CloudSave_ServerCoroutine runningCoroutine;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private CloudSave_Saves localSaves;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float confirmImportOlderTime;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float confirmExportOlderTime;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int adjustCheckboxShowEmail;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1AB92B8", Offset = "0x1AB92B8", VA = "0x1AB92B8", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1AB9B94", Offset = "0x1AB9B94", VA = "0x1AB9B94", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1AB9CA8", Offset = "0x1AB9CA8", VA = "0x1AB9CA8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1AB9DD8", Offset = "0x1AB9DD8", VA = "0x1AB9DD8", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1AB9F54", Offset = "0x1AB9F54", VA = "0x1AB9F54", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1ABA0FC", Offset = "0x1ABA0FC", VA = "0x1ABA0FC")]
	protected void OnEndCoroutineLoad()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1ABA22C", Offset = "0x1ABA22C", VA = "0x1ABA22C")]
	protected void OnEndCoroutineStore()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1AB97E4", Offset = "0x1AB97E4", VA = "0x1AB97E4")]
	protected void EnableImportExportButtons(bool import, bool export)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1AB95D0", Offset = "0x1AB95D0", VA = "0x1AB95D0")]
	protected void FillLoginInfo()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1AB98F0", Offset = "0x1AB98F0", VA = "0x1AB98F0")]
	protected void UpdateAfterReceivedCloudSave()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1ABA8A4", Offset = "0x1ABA8A4", VA = "0x1ABA8A4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1ABA910", Offset = "0x1ABA910", VA = "0x1ABA910")]
	public void OnClickSettings()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1ABA97C", Offset = "0x1ABA97C", VA = "0x1ABA97C")]
	public void OnSwitchShowEmail(bool on)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1ABA980", Offset = "0x1ABA980", VA = "0x1ABA980")]
	public void OnClickSetPassword()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1ABAA40", Offset = "0x1ABAA40", VA = "0x1ABAA40")]
	public void OnClickLogout()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1ABAB00", Offset = "0x1ABAB00", VA = "0x1ABAB00")]
	public void OnClickImport()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1ABA648", Offset = "0x1ABA648", VA = "0x1ABA648")]
	public void OnClickExport()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1ABADD4", Offset = "0x1ABADD4", VA = "0x1ABADD4")]
	public CloudSave_Screen_Menu()
	{
	}
}
[Token(Token = "0x200001F")]
public class CloudSave_Screen_Message : CloudSave_Screen
{
	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh messageText;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject textWarning;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject buttonOK;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject buttonCancel;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject buttonClose;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected CloudSave_Screen backToScreen;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Action<bool> resultCallback;

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1ABAE38", Offset = "0x1ABAE38", VA = "0x1ABAE38", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1ABAE60", Offset = "0x1ABAE60", VA = "0x1ABAE60", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1ABAE88", Offset = "0x1ABAE88", VA = "0x1ABAE88")]
	public void Init(string text, bool okcancel, bool warning, CloudSave_Screen _backToScreen, Action<bool> _resultCallback)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1ABAFD0", Offset = "0x1ABAFD0", VA = "0x1ABAFD0")]
	public void OnClickOK()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1ABB048", Offset = "0x1ABB048", VA = "0x1ABB048")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1ABB0C0", Offset = "0x1ABB0C0", VA = "0x1ABB0C0")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1ABB138", Offset = "0x1ABB138", VA = "0x1ABB138")]
	public CloudSave_Screen_Message()
	{
	}
}
[Token(Token = "0x2000020")]
public class CloudSave_Screen_RedeemCode : CloudSave_Screen
{
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText codeField;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject messageWnd;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMesh messageText;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CloudSave_ServerCoroutine_RedeemCode runningCoroutine;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool result;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string resultSku;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1ABB140", Offset = "0x1ABB140", VA = "0x1ABB140", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1ABB1C0", Offset = "0x1ABB1C0", VA = "0x1ABB1C0", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1ABB260", Offset = "0x1ABB260", VA = "0x1ABB260", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1ABB340", Offset = "0x1ABB340", VA = "0x1ABB340", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1ABB5E8", Offset = "0x1ABB5E8", VA = "0x1ABB5E8")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1ABB654", Offset = "0x1ABB654", VA = "0x1ABB654")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1ABB834", Offset = "0x1ABB834", VA = "0x1ABB834")]
	public CloudSave_Screen_RedeemCode()
	{
	}
}
[Token(Token = "0x2000021")]
public class CloudSave_Screen_ResetPassword : CloudSave_Screen
{
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText emailField;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CloudSave_ServerCoroutine_SendResetPassword runningCoroutine;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string email;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool passwordSend;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool backToSettings;

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1ABB888", Offset = "0x1ABB888", VA = "0x1ABB888", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1ABBB04", Offset = "0x1ABBB04", VA = "0x1ABBB04", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1ABBBA4", Offset = "0x1ABBBA4", VA = "0x1ABBBA4")]
	public void Init(bool _backToSettings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1ABBBB0", Offset = "0x1ABBBB0", VA = "0x1ABBBB0", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1ABBC90", Offset = "0x1ABBC90", VA = "0x1ABBC90", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1ABBE08", Offset = "0x1ABBE08", VA = "0x1ABBE08")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1ABBE7C", Offset = "0x1ABBE7C", VA = "0x1ABBE7C")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1ABC144", Offset = "0x1ABC144", VA = "0x1ABC144")]
	public CloudSave_Screen_ResetPassword()
	{
	}
}
[Token(Token = "0x2000022")]
public class CloudSave_Screen_Settings : CloudSave_Screen
{
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CloudSave_Checkbox newsletterToggle;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject buttonSupport;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject buttonDeleteAccount;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject buttonPrivacyPolicy;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CloudSave_ServerCoroutine_SetNewsletter runningCoroutine;

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1ABC198", Offset = "0x1ABC198", VA = "0x1ABC198", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1ABC28C", Offset = "0x1ABC28C", VA = "0x1ABC28C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1ABC32C", Offset = "0x1ABC32C", VA = "0x1ABC32C", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1ABC40C", Offset = "0x1ABC40C", VA = "0x1ABC40C", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1ABC524", Offset = "0x1ABC524", VA = "0x1ABC524")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1ABC6E8", Offset = "0x1ABC6E8", VA = "0x1ABC6E8")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1ABC754", Offset = "0x1ABC754", VA = "0x1ABC754")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1ABC7C0", Offset = "0x1ABC7C0", VA = "0x1ABC7C0")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1ABC82C", Offset = "0x1ABC82C", VA = "0x1ABC82C")]
	public void OnClickDeleteAccount()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1ABC898", Offset = "0x1ABC898", VA = "0x1ABC898")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1ABC904", Offset = "0x1ABC904", VA = "0x1ABC904")]
	public void OnSwitchNewsletter(bool signed)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1ABCA94", Offset = "0x1ABCA94", VA = "0x1ABCA94")]
	public CloudSave_Screen_Settings()
	{
	}
}
[Token(Token = "0x2000023")]
public class CloudSave_Screen_TermsOfUse : CloudSave_Screen
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected string email;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string password;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool newsletter;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected string infoMsg1;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected string infoMsg2;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool infoMsgWarning;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private CloudSave_ServerCoroutine_Login runningCoroutine;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1ABCA9C", Offset = "0x1ABCA9C", VA = "0x1ABCA9C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1ABCAC4", Offset = "0x1ABCAC4", VA = "0x1ABCAC4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1ABCB64", Offset = "0x1ABCB64", VA = "0x1ABCB64")]
	public void Init(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1ABCB74", Offset = "0x1ABCB74", VA = "0x1ABCB74", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1ABCC54", Offset = "0x1ABCC54", VA = "0x1ABCC54", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1ABCEA8", Offset = "0x1ABCEA8", VA = "0x1ABCEA8", Slot = "12")]
	public override void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1ABCF10", Offset = "0x1ABCF10", VA = "0x1ABCF10", Slot = "13")]
	public override void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1ABCF20", Offset = "0x1ABCF20", VA = "0x1ABCF20")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1ABD070", Offset = "0x1ABD070", VA = "0x1ABD070")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1ABD104", Offset = "0x1ABD104", VA = "0x1ABD104")]
	public CloudSave_Screen_TermsOfUse()
	{
	}
}
[Token(Token = "0x2000024")]
public class CloudSave_AdjustIconToText : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB0C", Offset = "0x8EBB0C")]
	private sealed class <AdjustToTextCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_AdjustIconToText <>4__this;

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x1CB3870", Offset = "0x1CB3870", VA = "0x1CB3870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1CB38B8", Offset = "0x1CB38B8", VA = "0x1CB38B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1CB32E0", Offset = "0x1CB32E0", VA = "0x1CB32E0")]
		[DebuggerHidden]
		public <AdjustToTextCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1CB330C", Offset = "0x1CB330C", VA = "0x1CB330C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1CB3310", Offset = "0x1CB3310", VA = "0x1CB3310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1CB3878", Offset = "0x1CB3878", VA = "0x1CB3878", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject textObject;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool toRight;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float margin;

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1A60364", Offset = "0x1A60364", VA = "0x1A60364")]
	public void Start()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1A60390", Offset = "0x1A60390", VA = "0x1A60390")]
	private void AdjustToText()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1A603BC", Offset = "0x1A603BC", VA = "0x1A603BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED950", Offset = "0x8ED950")]
	public IEnumerator AdjustToTextCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1A60428", Offset = "0x1A60428", VA = "0x1A60428")]
	public CloudSave_AdjustIconToText()
	{
	}
}
[Token(Token = "0x2000025")]
public class CloudSave_Checkbox : MonoBehaviour
{
	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isCheckedVal;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objectToCall;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string functionToCall;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material materialOff;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material materialOn;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool callbackWithObject;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string customParamStr;

	[Token(Token = "0x17000002")]
	public bool isChecked
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1A60430", Offset = "0x1A60430", VA = "0x1A60430")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1A60438", Offset = "0x1A60438", VA = "0x1A60438")]
		set
		{
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1A60584", Offset = "0x1A60584", VA = "0x1A60584")]
	private void Start()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1A60444", Offset = "0x1A60444", VA = "0x1A60444")]
	private void changeMaterial()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1A605EC", Offset = "0x1A605EC", VA = "0x1A605EC")]
	private void Click()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1A606F4", Offset = "0x1A606F4", VA = "0x1A606F4")]
	public void SetChecked(bool on)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1A60700", Offset = "0x1A60700", VA = "0x1A60700")]
	public void SetCallbackWithObject(bool on)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1A6070C", Offset = "0x1A6070C", VA = "0x1A6070C")]
	public void SetCustomParam(string param)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1A60714", Offset = "0x1A60714", VA = "0x1A60714")]
	public string GetCustomParam()
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1A6071C", Offset = "0x1A6071C", VA = "0x1A6071C")]
	public CloudSave_Checkbox()
	{
	}
}
[Token(Token = "0x2000026")]
public class CloudSave_InfoMessage : MonoBehaviour
{
	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh text;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color textColorInfo;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color textColorWarning;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject warningIcon;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isWarning;

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1A65464", Offset = "0x1A65464", VA = "0x1A65464")]
	public void ShowText(string txt, bool warning)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1A63C0C", Offset = "0x1A63C0C", VA = "0x1A63C0C")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1A65608", Offset = "0x1A65608", VA = "0x1A65608")]
	public bool IsWarning()
	{
		return default(bool);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1A65610", Offset = "0x1A65610", VA = "0x1A65610")]
	public CloudSave_InfoMessage()
	{
	}
}
[Token(Token = "0x2000027")]
public interface IMUIHoverable
{
	[Token(Token = "0x600016E")]
	void OnHover();

	[Token(Token = "0x600016F")]
	void OnLeave();
}
[Token(Token = "0x2000028")]
public class MUI_Button : MonoBehaviour
{
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x200DF28", Offset = "0x200DF28", VA = "0x200DF28")]
	private void Update()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x200E000", Offset = "0x200E000", VA = "0x200E000")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x200E298", Offset = "0x200E298", VA = "0x200E298")]
	public MUI_Button()
	{
	}
}
[Token(Token = "0x2000029")]
public class MUI_ClippedScroll : MonoBehaviour
{
	[Token(Token = "0x20000A5")]
	protected class BoxColliderInfo
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BoxCollider box;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 center;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 size;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Bounds bounds;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x20B356C", Offset = "0x20B356C", VA = "0x20B356C")]
		public BoxColliderInfo()
		{
		}
	}

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 scrollSize;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool useBoundary;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject container;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject scrollbarVert;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject scrollbarHorz;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject clipBkgToScreen;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool resetScrollPositionOnEnable;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool autoAdjustToContents;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float clipScreenBottomMargin;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] ignoreCollidersOfSubobjects;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject dragArea;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected bool changedContents;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected Bounds clipArea;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Bounds scrollMargin;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	protected Vector3 scrollbarVert_scale;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Vector3 scrollbarHorz_scale;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected List<BoxColliderInfo> boxCollidersOrgSize;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected List<GameObject> clippedOutColChilds;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected List<GameObject> clippedOutRendChilds;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected List<GameObject> ignoredNotClippedChilds;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected bool scrollbarVertDown;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	protected bool scrollbarHorzDown;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
	protected bool dragScrollbarVert;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD3")]
	protected bool dragScrollbarHorz;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	protected bool dragging;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	protected bool keepMinOrgScrollSize;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected Vector2 scrollSizeOrg;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected float clipBkgOrgSizeY;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	protected bool doClipBkgToScreen;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	protected int lastScreenSizeChecksum;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	protected bool autoAdjustToContentsAfterChanges;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
	protected bool setAutoAdjustToContents;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
	protected bool keepProportionalContainerSizeAfterChanges;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
	protected bool resetScrollPos;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected bool freezeScroll;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	protected Vector2 scrollToAfterContentsChanged;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	protected bool extendHorzSizeToScreen;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected GameObject zoomRootObject;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected float zoomMin;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	protected float zoomMax;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected float zoomSpeed;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static List<MUI_ClippedScroll> enabledScrolls;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static MUI_ClippedScroll_Materials clippedMaterials;

	[Token(Token = "0x40000FE")]
	private const float minScrollbarSize = 0.2f;

	[Token(Token = "0x40000FF")]
	private const float mouseWheelSpeed = 2f;

	[Token(Token = "0x4000100")]
	private const float boundsMarginX = 0.1f;

	[Token(Token = "0x4000101")]
	private const float boundsMarginY = 0.1f;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x200E2A0", Offset = "0x200E2A0", VA = "0x200E2A0")]
	public static void UpdateMaterialsForObjectsWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x200E670", Offset = "0x200E670", VA = "0x200E670")]
	public static void UpdateMaterialForObjectWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x200E8F4", Offset = "0x200E8F4", VA = "0x200E8F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x200EE60", Offset = "0x200EE60", VA = "0x200EE60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x200EF00", Offset = "0x200EF00", VA = "0x200EF00")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x200F08C", Offset = "0x200F08C", VA = "0x200F08C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x200F108", Offset = "0x200F108", VA = "0x200F108")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x200F278", Offset = "0x200F278", VA = "0x200F278")]
	private Vector2 Scale()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x200F2F0", Offset = "0x200F2F0", VA = "0x200F2F0")]
	public static Vector2 Scale(GameObject go, bool inclSelfScale)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x200F3E4", Offset = "0x200F3E4", VA = "0x200F3E4")]
	public void ContentsChanged()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x200F3FC", Offset = "0x200F3FC", VA = "0x200F3FC")]
	public void SetKeepMinOrgScrollSize(bool s)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x200EE4C", Offset = "0x200EE4C", VA = "0x200EE4C")]
	public void AutoAdjustToContents(bool adjustAfterChanges = true)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x200F408", Offset = "0x200F408", VA = "0x200F408")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x200F818", Offset = "0x200F818", VA = "0x200F818")]
	public void FreezeScroll(bool freeze)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x200F824", Offset = "0x200F824", VA = "0x200F824")]
	public bool HaveClippedContents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x200F880", Offset = "0x200F880", VA = "0x200F880")]
	public bool HaveClippedContentsX()
	{
		return default(bool);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x200F8AC", Offset = "0x200F8AC", VA = "0x200F8AC")]
	public bool HaveClippedContentsY()
	{
		return default(bool);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x200F8D8", Offset = "0x200F8D8", VA = "0x200F8D8")]
	public bool IsScreenPointInBounds(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x200FA74", Offset = "0x200FA74", VA = "0x200FA74")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x200FB78", Offset = "0x200FB78", VA = "0x200FB78")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x200FC28", Offset = "0x200FC28", VA = "0x200FC28")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x200FC84", Offset = "0x200FC84", VA = "0x200FC84")]
	public void ScrollToTop()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x200FCE4", Offset = "0x200FCE4", VA = "0x200FCE4")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x200FD44", Offset = "0x200FD44", VA = "0x200FD44")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x200FDAC", Offset = "0x200FDAC", VA = "0x200FDAC")]
	public bool IsScrolledToY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x200FE20", Offset = "0x200FE20", VA = "0x200FE20")]
	public bool IsInsideClipAreaY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x200FE88", Offset = "0x200FE88", VA = "0x200FE88")]
	public bool IsDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x200FE90", Offset = "0x200FE90", VA = "0x200FE90")]
	public void EnsureVisible(Vector3 pos)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x2010078", Offset = "0x2010078", VA = "0x2010078")]
	public bool IsClippedOutColChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x2010180", Offset = "0x2010180", VA = "0x2010180")]
	public bool IsClippedOutRendChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x2010288", Offset = "0x2010288", VA = "0x2010288")]
	public void AddIgnoredNotClippedChild(GameObject go)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x20102EC", Offset = "0x20102EC", VA = "0x20102EC")]
	private bool IsIgnoredNotClippedChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x20103DC", Offset = "0x20103DC", VA = "0x20103DC")]
	public void SetExtendHorzSizeToScreen()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x20103E8", Offset = "0x20103E8", VA = "0x20103E8")]
	public void SetZoomContents(GameObject rootObj, float min, float max, float speed)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x20103FC", Offset = "0x20103FC", VA = "0x20103FC")]
	public bool HaveZoomContents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x2010468", Offset = "0x2010468", VA = "0x2010468")]
	public static MUI_ClippedScroll GetActiveScroll(Vector2 atPoint)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x201062C", Offset = "0x201062C", VA = "0x201062C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x201177C", Offset = "0x201177C", VA = "0x201177C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x2011E38", Offset = "0x2011E38", VA = "0x2011E38")]
	private void ClipBkgToScreen()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x20109EC", Offset = "0x20109EC", VA = "0x20109EC")]
	private void AdjustHorzSizeToScreen()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x2011A48", Offset = "0x2011A48", VA = "0x2011A48")]
	private void AdjustScrollSizeToContents()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x2012BC4", Offset = "0x2012BC4", VA = "0x2012BC4")]
	private void UpdateMaterials(GameObject go, ref Bounds mergedBounds)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x201388C", Offset = "0x201388C", VA = "0x201388C")]
	private BoxColliderInfo GetBoxColliderOrgSize(BoxCollider box, Vector2 scale)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x2013B04", Offset = "0x2013B04", VA = "0x2013B04")]
	private void UpdateBounds(GameObject go)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x2010094", Offset = "0x2010094", VA = "0x2010094")]
	private int GetClippedOutColChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x201019C", Offset = "0x201019C", VA = "0x201019C")]
	private int GetClippedOutRendChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x2012494", Offset = "0x2012494", VA = "0x2012494")]
	private void UpdateAfterChanged()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x200F4A8", Offset = "0x200F4A8", VA = "0x200F4A8")]
	private void UpdateScroll()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x200FA78", Offset = "0x200FA78", VA = "0x200FA78")]
	private void Scroll(float x, float y)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x20147C8", Offset = "0x20147C8", VA = "0x20147C8")]
	private Vector2 ScreenPointToWorldPos(Vector2 p)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x200F908", Offset = "0x200F908", VA = "0x200F908")]
	private bool IsScreenPointInClipArea(Vector3 p)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x2014A3C", Offset = "0x2014A3C", VA = "0x2014A3C")]
	public void OnScrollBarDown(MUI_ClippedScroll_Bar bar, bool down)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x2010D20", Offset = "0x2010D20", VA = "0x2010D20")]
	private void StepDrag()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x2011400", Offset = "0x2011400", VA = "0x2011400")]
	private void StepScrollMouseWheel()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x201159C", Offset = "0x201159C", VA = "0x201159C")]
	private void StepZoom()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x2014B94", Offset = "0x2014B94", VA = "0x2014B94")]
	public MUI_ClippedScroll()
	{
	}
}
[Token(Token = "0x200002A")]
public class MUI_ClippedScroll_Bar : MonoBehaviour
{
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected MUI_ClippedScroll scroller;

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x2014D28", Offset = "0x2014D28", VA = "0x2014D28")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x2014D8C", Offset = "0x2014D8C", VA = "0x2014D8C")]
	public void Down()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x2014E1C", Offset = "0x2014E1C", VA = "0x2014E1C")]
	public void Up()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x2014EAC", Offset = "0x2014EAC", VA = "0x2014EAC")]
	public void Click()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x2014F3C", Offset = "0x2014F3C", VA = "0x2014F3C")]
	public MUI_ClippedScroll_Bar()
	{
	}
}
[Serializable]
[Token(Token = "0x200002B")]
public class ClippedMaterialPair
{
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material materialOrg;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material materialClipped;

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1A6035C", Offset = "0x1A6035C", VA = "0x1A6035C")]
	public ClippedMaterialPair()
	{
	}
}
[Serializable]
[Token(Token = "0x200002C")]
public class ClippedFontMaterialPair
{
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Font font;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material materialClipped;

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1A60354", Offset = "0x1A60354", VA = "0x1A60354")]
	public ClippedFontMaterialPair()
	{
	}
}
[Token(Token = "0x200002D")]
public class MUI_ClippedScroll_Materials : MonoBehaviour
{
	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ClippedMaterialPair[] materials;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ClippedFontMaterialPair[] fonts;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x2014F44", Offset = "0x2014F44", VA = "0x2014F44")]
	public MUI_ClippedScroll_Materials()
	{
	}
}
[Token(Token = "0x200002E")]
public class MUI_Continous : MonoBehaviour
{
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x2014F4C", Offset = "0x2014F4C", VA = "0x2014F4C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x2015014", Offset = "0x2015014", VA = "0x2015014")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x20152AC", Offset = "0x20152AC", VA = "0x20152AC")]
	public MUI_Continous()
	{
	}
}
[Token(Token = "0x200002F")]
public class BoolRef
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool val;

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1A5E3D0", Offset = "0x1A5E3D0", VA = "0x1A5E3D0")]
	public BoolRef()
	{
	}
}
[Token(Token = "0x2000030")]
public class MUI_Input : MonoBehaviour
{
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static KeyCode backKeyCode;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static MUI_Input instance;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool drag;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static Vector2 dragStart;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static Vector2 vDrag;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static bool zoom;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Vector2 zoomCenter;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static float zoomVal;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static Vector3 hitPointMUI;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static float lastMUIClickTimeUnscaled;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public static Vector3 hitPoint;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static GameObject hitObject;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static LayerMask layerMask;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Camera pCamera;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static bool lastUpdateClickDown;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public static bool moveSlider;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	private static bool moveScrollbar;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private static LayerMask MUIlayerMask;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 tapPos;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static GameObject MUIObject;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool tap;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static int blockZoom;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int dragTreshold;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string[] initLayers;

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x20152B4", Offset = "0x20152B4", VA = "0x20152B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x201531C", Offset = "0x201531C", VA = "0x201531C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x2015684", Offset = "0x2015684", VA = "0x2015684")]
	public static LayerMask GetMUIlayerMask()
	{
		return default(LayerMask);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x20156E8", Offset = "0x20156E8", VA = "0x20156E8")]
	public static Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x201574C", Offset = "0x201574C", VA = "0x201574C")]
	public static void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x20157B4", Offset = "0x20157B4", VA = "0x20157B4")]
	public static void ClearLayerMask()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x201582C", Offset = "0x201582C", VA = "0x201582C")]
	public static bool WasNowClickDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2015578", Offset = "0x2015578", VA = "0x2015578")]
	public static void AddLayer(string layer)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2015890", Offset = "0x2015890", VA = "0x2015890")]
	public static void RemoveLayer(string layer)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2015A00", Offset = "0x2015A00", VA = "0x2015A00")]
	public static bool IsDraggingItem()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x2015B64", Offset = "0x2015B64", VA = "0x2015B64")]
	private void Zoom()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x20160F0", Offset = "0x20160F0", VA = "0x20160F0")]
	private void Drag()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x20169C0", Offset = "0x20169C0", VA = "0x20169C0")]
	private bool IsChildOfActiveScroll(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2016AB4", Offset = "0x2016AB4", VA = "0x2016AB4")]
	private bool FingerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2016BB0", Offset = "0x2016BB0", VA = "0x2016BB0")]
	private bool FingerUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2016C98", Offset = "0x2016C98", VA = "0x2016C98")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2016F40", Offset = "0x2016F40", VA = "0x2016F40")]
	private void CastRay(bool down, bool up, bool move)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x2017680", Offset = "0x2017680", VA = "0x2017680")]
	public MUI_Input()
	{
	}
}
[Token(Token = "0x2000031")]
public class ClipboardHelper
{
	[Token(Token = "0x17000003")]
	public static string clipBoard
	{
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1A6033C", Offset = "0x1A6033C", VA = "0x1A6033C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1A60344", Offset = "0x1A60344", VA = "0x1A60344")]
		set
		{
		}
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1A6034C", Offset = "0x1A6034C", VA = "0x1A6034C")]
	public ClipboardHelper()
	{
	}
}
[Token(Token = "0x2000032")]
public class MUI_InputText : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB1C", Offset = "0x8EBB1C")]
	private sealed class <ReadKbdInputCoroutine>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MUI_InputText <>4__this;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int initCursorPos;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <oldText>5__2;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <stop>5__3;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool <touchKbdEnter>5__4;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <prevBefore>5__5;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <prevAfter>5__6;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MUI_InputText <nextInput>5__7;

		[Token(Token = "0x1700007C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x20B4710", Offset = "0x20B4710", VA = "0x20B4710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x20B4758", Offset = "0x20B4758", VA = "0x20B4758", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x20B3574", Offset = "0x20B3574", VA = "0x20B3574")]
		[DebuggerHidden]
		public <ReadKbdInputCoroutine>d__74(int <>1__state)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x20B35A0", Offset = "0x20B35A0", VA = "0x20B35A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x20B35A4", Offset = "0x20B35A4", VA = "0x20B35A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x20B4718", Offset = "0x20B4718", VA = "0x20B4718", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Func<string, string> Trl_Translate;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh textMesh;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh emptyTextTip;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool onlySoftwareKeyboard;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool emailInput;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool passwordInput;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool hideTouchScreenKbdInput;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string touchScreenKbdPlaceholderText;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Renderer tmr;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected MUI_ScreenKeyboard screenKeyboardOwner;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool allowInputInScreenKeyboard;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected string screenKeyboardInput;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected float cursorBlinkOnTime;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected float cursorBlinkOffTime;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected float scrollSpeed;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected string textVal;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected string textBeforeCursor;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected string textAfterCursor;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected bool initialized;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected int initializeDelay;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected bool selected;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	protected int updatesSinceClick;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected TouchScreenKeyboard touchKeyboard;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected bool sysKeyboardShowEvent;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	protected float textMeshFieldWidth;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected TextMesh textMeshCursor;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected float cursorSize;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected Hashtable dictCharWidth;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected float cursorSetBlinkTime;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	protected float lastScrollKeyTime;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected int firstVisibleTextIndex;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	protected float setClickCursorPos;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected float showTime;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	protected bool isDisabling;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected static MUI_InputText currentInputOwner;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static bool isOpenedSystemKeyboard;

	[Token(Token = "0x17000004")]
	public string text
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2017B3C", Offset = "0x2017B3C", VA = "0x2017B3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2017B44", Offset = "0x2017B44", VA = "0x2017B44")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action SystemKeyboardShow
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x201775C", Offset = "0x201775C", VA = "0x201775C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8ED9B0", Offset = "0x8ED9B0")]
		add
		{
		}
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2017854", Offset = "0x2017854", VA = "0x2017854")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8ED9C0", Offset = "0x8ED9C0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event Action SystemKeyboardHide
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x201794C", Offset = "0x201794C", VA = "0x201794C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8ED9D0", Offset = "0x8ED9D0")]
		add
		{
		}
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2017A44", Offset = "0x2017A44", VA = "0x2017A44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8ED9E0", Offset = "0x8ED9E0")]
		remove
		{
		}
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x201812C", Offset = "0x201812C", VA = "0x201812C")]
	public static bool IsOpenedSystemKeyboard()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2018190", Offset = "0x2018190", VA = "0x2018190")]
	public static bool IsCurrentInputActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2018230", Offset = "0x2018230", VA = "0x2018230")]
	public void SetIsInputOfScreenKeyboard(MUI_ScreenKeyboard owner)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2018238", Offset = "0x2018238", VA = "0x2018238")]
	public void SetAllowInputInScreenKeyboard()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2018244", Offset = "0x2018244", VA = "0x2018244")]
	public void AddScreenKeyboardInput(char c)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2018334", Offset = "0x2018334", VA = "0x2018334")]
	public void SetKeyboardInputActive(bool active)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x20184C8", Offset = "0x20184C8", VA = "0x20184C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x201863C", Offset = "0x201863C", VA = "0x201863C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x20186E0", Offset = "0x20186E0", VA = "0x20186E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x2018708", Offset = "0x2018708", VA = "0x2018708")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x2018954", Offset = "0x2018954", VA = "0x2018954")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x2018B14", Offset = "0x2018B14", VA = "0x2018B14")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2018B40", Offset = "0x2018B40", VA = "0x2018B40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x2018B44", Offset = "0x2018B44", VA = "0x2018B44")]
	private void Down()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x2018B4C", Offset = "0x2018B4C", VA = "0x2018B4C")]
	protected MUI_Show_ScreenKeyboard GetShowKbdComponent(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2018E78", Offset = "0x2018E78", VA = "0x2018E78")]
	private void ControllerClick()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2018350", Offset = "0x2018350", VA = "0x2018350")]
	private void Click()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2018E80", Offset = "0x2018E80", VA = "0x2018E80")]
	private void DoClick(bool fromController)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2018358", Offset = "0x2018358", VA = "0x2018358")]
	protected void CloseKeyboard()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2019374", Offset = "0x2019374", VA = "0x2019374")]
	protected string GetPastedClipboardText()
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x20193D8", Offset = "0x20193D8", VA = "0x20193D8")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x20193E0", Offset = "0x20193E0", VA = "0x20193E0")]
	public void UpdateText()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2017B5C", Offset = "0x2017B5C", VA = "0x2017B5C")]
	public void SetText(string _t, int cursorPos)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x20197E0", Offset = "0x20197E0", VA = "0x20197E0")]
	private void SetTextMesh(string txt)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x2019424", Offset = "0x2019424", VA = "0x2019424")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x2019730", Offset = "0x2019730", VA = "0x2019730")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x20198B0", Offset = "0x20198B0", VA = "0x20198B0")]
	protected void CreateCursor()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x20192B4", Offset = "0x20192B4", VA = "0x20192B4")]
	protected void DestroyCursor()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x2019BE4", Offset = "0x2019BE4", VA = "0x2019BE4")]
	private bool IsTouchKeyboardActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x2019238", Offset = "0x2019238", VA = "0x2019238")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8ED9F0", Offset = "0x8ED9F0")]
	private IEnumerator ReadKbdInputCoroutine(int initCursorPos)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x2019BF8", Offset = "0x2019BF8", VA = "0x2019BF8")]
	protected MUI_InputText FindNextInputText()
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x2019F4C", Offset = "0x2019F4C", VA = "0x2019F4C")]
	public MUI_InputText()
	{
	}
}
[Token(Token = "0x2000033")]
public class MUI_Screen
{
	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static bool wasLandscape;

	[Token(Token = "0x17000005")]
	public static int width
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x201078C", Offset = "0x201078C", VA = "0x201078C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public static int height
	{
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x20108BC", Offset = "0x20108BC", VA = "0x20108BC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x201A00C", Offset = "0x201A00C", VA = "0x201A00C")]
	public MUI_Screen()
	{
	}
}
[Token(Token = "0x2000034")]
public class MUI_ScreenKeyboard : MonoBehaviour
{
	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static char[] baseKeys;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static char[] shiftKeys;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static char[] sym1Keys;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected static char[] sym2Keys;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh inputLabel;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText inputText;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] hideShowWindows;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool errorMissingButtons;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MUI_InputText fillInput;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected GameObject hideScreen;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool shiftMode;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected int symMode;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected TextMesh[] textKeys;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected TextMesh textSHIFT;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject iconSHIFT;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected TextMesh textSYMBOLS;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected bool initialized;

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x201A018", Offset = "0x201A018", VA = "0x201A018", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x201A01C", Offset = "0x201A01C", VA = "0x201A01C", Slot = "5")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x201A020", Offset = "0x201A020", VA = "0x201A020")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x201AC04", Offset = "0x201AC04", VA = "0x201AC04", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x201AC08", Offset = "0x201AC08", VA = "0x201AC08")]
	public void Show(MUI_InputText _fillInput, string label, GameObject _hideScreen)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x201ADB8", Offset = "0x201ADB8", VA = "0x201ADB8")]
	public void CancelKeyboard()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x201AE14", Offset = "0x201AE14", VA = "0x201AE14", Slot = "7")]
	public virtual void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x201B02C", Offset = "0x201B02C", VA = "0x201B02C", Slot = "8")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x201B0D8", Offset = "0x201B0D8", VA = "0x201B0D8", Slot = "9")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x201B1C4", Offset = "0x201B1C4", VA = "0x201B1C4", Slot = "10")]
	public virtual void OnInputEnter()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x201B210", Offset = "0x201B210", VA = "0x201B210")]
	public void OnKeyPressed(string skey)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x201B6BC", Offset = "0x201B6BC", VA = "0x201B6BC")]
	protected GameObject FindObject(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x201B474", Offset = "0x201B474", VA = "0x201B474")]
	protected int FindKeyIndex(string skey)
	{
		return default(int);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x201A118", Offset = "0x201A118", VA = "0x201A118")]
	protected void InitTextKeys()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x201B57C", Offset = "0x201B57C", VA = "0x201B57C")]
	protected char GetCurrentKey(int i)
	{
		return default(char);
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x201A8B8", Offset = "0x201A8B8", VA = "0x201A8B8")]
	protected void FillTextKeys()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x201AF40", Offset = "0x201AF40", VA = "0x201AF40")]
	protected string TrimEndLineCharacters(string text)
	{
		return null;
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x201BA28", Offset = "0x201BA28", VA = "0x201BA28")]
	public MUI_ScreenKeyboard()
	{
	}
}
[Token(Token = "0x2000035")]
public class MUI_Scroll : MonoBehaviour
{
	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 size;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 startOffset;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autoCalcSize;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool resetOnDisable;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool scaleSpeed;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool useBoundary;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector4 boundary;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject titleBarOver;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject excludeFromAutoCalcSize;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 orgPos;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 orgSize;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 center;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 pos;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector2 sizeMin;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2 sizeMax;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool initialized;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	private bool started;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	private bool thisScrollingInBoundary;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
	private bool doAutoCalcSize;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int lastAutoCalcChecksum;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool activeScrollSet;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int activeScrollsCnt;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static bool scrollingInBoundary;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x201BB84", Offset = "0x201BB84", VA = "0x201BB84")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x201BB88", Offset = "0x201BB88", VA = "0x201BB88")]
	private void DoInit()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x201BC08", Offset = "0x201BC08", VA = "0x201BC08")]
	private void Start()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x201BCF4", Offset = "0x201BCF4", VA = "0x201BCF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x201BD8C", Offset = "0x201BD8C", VA = "0x201BD8C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x2016954", Offset = "0x2016954", VA = "0x2016954")]
	public static bool IsAnyScrollActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x201BECC", Offset = "0x201BECC", VA = "0x201BECC")]
	public static bool IsAnyScrollingInBoundary()
	{
		return default(bool);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x201BF30", Offset = "0x201BF30", VA = "0x201BF30")]
	public void ResetOrgPos(Vector3 org)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x201BF3C", Offset = "0x201BF3C", VA = "0x201BF3C")]
	public void SetSizeMinY(float y)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x201BF44", Offset = "0x201BF44", VA = "0x201BF44")]
	public void SetSize(Vector2 _size)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x201BF90", Offset = "0x201BF90", VA = "0x201BF90")]
	public void SetOffset(Vector2 _offset)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x201BC4C", Offset = "0x201BC4C", VA = "0x201BC4C")]
	public void ResetScroll()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x201C0D4", Offset = "0x201C0D4", VA = "0x201C0D4")]
	public void AutoCalculateSize()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x201C99C", Offset = "0x201C99C", VA = "0x201C99C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x201CA08", Offset = "0x201CA08", VA = "0x201CA08")]
	private void Update()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x201CF14", Offset = "0x201CF14", VA = "0x201CF14")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x201CF40", Offset = "0x201CF40", VA = "0x201CF40")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x201CFB8", Offset = "0x201CFB8", VA = "0x201CFB8")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x201D030", Offset = "0x201D030", VA = "0x201D030")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x201D0D8", Offset = "0x201D0D8", VA = "0x201D0D8")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x201D138", Offset = "0x201D138", VA = "0x201D138")]
	public bool IsAllOnScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x201BFD0", Offset = "0x201BFD0", VA = "0x201BFD0")]
	public void Clamp()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x201D168", Offset = "0x201D168", VA = "0x201D168")]
	public void UpdateZoom()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x201C8A4", Offset = "0x201C8A4", VA = "0x201C8A4")]
	public static Vector2 GetFrustrumSizeAt(Camera cam)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x201D1C8", Offset = "0x201D1C8", VA = "0x201D1C8")]
	public void EnsureVisible(Vector3 point)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x201D5D4", Offset = "0x201D5D4", VA = "0x201D5D4")]
	public MUI_Scroll()
	{
	}
}
[Token(Token = "0x2000036")]
public class MUI_Show_ScreenKeyboard : MonoBehaviour
{
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MUI_ScreenKeyboard keyboard;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MUI_InputText inputField;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string inputLabel;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject hideScreen;

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x20190C0", Offset = "0x20190C0", VA = "0x20190C0")]
	public void Click()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x201D644", Offset = "0x201D644", VA = "0x201D644")]
	public MUI_Show_ScreenKeyboard()
	{
	}
}
[Token(Token = "0x2000037")]
public class MUI_Slider : MonoBehaviour
{
	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform square;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public eSlider val;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float margin;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected bool isCustom;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected float customVal;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Action<MUI_Slider, float> valChangedCallback;

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x201D698", Offset = "0x201D698", VA = "0x201D698")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x201D6C0", Offset = "0x201D6C0", VA = "0x201D6C0")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x201D7B8", Offset = "0x201D7B8", VA = "0x201D7B8")]
	public void SetValChangedCallback(Action<MUI_Slider, float> callback)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x201D7C0", Offset = "0x201D7C0", VA = "0x201D7C0")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x201D7C8", Offset = "0x201D7C8", VA = "0x201D7C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x201D80C", Offset = "0x201D80C", VA = "0x201D80C")]
	public float GetVal()
	{
		return default(float);
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x201D88C", Offset = "0x201D88C", VA = "0x201D88C")]
	public void SetVal(float v)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x201D6D0", Offset = "0x201D6D0", VA = "0x201D6D0")]
	private void UpdateSquarePos()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x201D93C", Offset = "0x201D93C", VA = "0x201D93C")]
	private void Down()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x201DACC", Offset = "0x201DACC", VA = "0x201DACC")]
	private void Click()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x201DAD0", Offset = "0x201DAD0", VA = "0x201DAD0")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x201D940", Offset = "0x201D940", VA = "0x201D940")]
	private void Process()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x201DAD4", Offset = "0x201DAD4", VA = "0x201DAD4")]
	public MUI_Slider()
	{
	}
}
[Token(Token = "0x2000038")]
public class MUI_SliderVertical : MonoBehaviour
{
	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform square;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public eSlider val;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float margin;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject objectToCall;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string functionToCall;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool update;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	protected bool isCustom;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected float customVal;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Action<MUI_SliderVertical, float, float> valChangedCallback;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float newVal;

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x201DAE8", Offset = "0x201DAE8", VA = "0x201DAE8")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x201DBE0", Offset = "0x201DBE0", VA = "0x201DBE0")]
	public void SetValChangedCallback(Action<MUI_SliderVertical, float, float> callback)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x201DBE8", Offset = "0x201DBE8", VA = "0x201DBE8")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x201DBF0", Offset = "0x201DBF0", VA = "0x201DBF0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x201DC34", Offset = "0x201DC34", VA = "0x201DC34")]
	private void Update()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x201DAF8", Offset = "0x201DAF8", VA = "0x201DAF8")]
	public void UpdateSquarePos()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x201DF24", Offset = "0x201DF24", VA = "0x201DF24")]
	private void Down()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x201DF28", Offset = "0x201DF28", VA = "0x201DF28")]
	private void Click()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x201DF2C", Offset = "0x201DF2C", VA = "0x201DF2C")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x201DCC4", Offset = "0x201DCC4", VA = "0x201DCC4")]
	private void Process()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x201DF30", Offset = "0x201DF30", VA = "0x201DF30")]
	public MUI_SliderVertical()
	{
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8EB6E4", Offset = "0x8EB6E4")]
public class MUI_Sound : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class SoundParameters
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioClip clip;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float pitch;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x20B4760", Offset = "0x20B4760", VA = "0x20B4760")]
		public SoundParameters()
		{
		}
	}

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SoundParameters[] soundParam;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int clipToPlay;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource audios;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MUI_Sound instance;

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x201DF44", Offset = "0x201DF44", VA = "0x201DF44")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x201E0B4", Offset = "0x201E0B4", VA = "0x201E0B4")]
	private static void FindInstance()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x201E244", Offset = "0x201E244", VA = "0x201E244")]
	public static void Play(int num)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x201E388", Offset = "0x201E388", VA = "0x201E388")]
	private void Play()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x201E4E0", Offset = "0x201E4E0", VA = "0x201E4E0")]
	public MUI_Sound()
	{
	}
}
[Token(Token = "0x200003A")]
public class MUI_click_Effect : MonoBehaviour
{
	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 offset;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 offset2;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 scaleMul;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material material;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material materialDisabled;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int SoundNumDown;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int SoundNumUp;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int SoundNumClick;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 orgPos;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 orgScale;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Material orgMaterial;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool down;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool disabled;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Renderer r;

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x201E4F4", Offset = "0x201E4F4", VA = "0x201E4F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x201E6E0", Offset = "0x201E6E0", VA = "0x201E6E0")]
	private void Down()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x201E968", Offset = "0x201E968", VA = "0x201E968")]
	private void Up()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x201EB1C", Offset = "0x201EB1C", VA = "0x201EB1C")]
	private void Click()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x201EB90", Offset = "0x201EB90", VA = "0x201EB90")]
	private void IsDown(BoolRef isDown)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x201EBAC", Offset = "0x201EBAC", VA = "0x201EBAC")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x201EBBC", Offset = "0x201EBBC", VA = "0x201EBBC")]
	public bool IsDisabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x201EBC4", Offset = "0x201EBC4", VA = "0x201EBC4")]
	public void Disable()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x201EDF0", Offset = "0x201EDF0", VA = "0x201EDF0")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x201EFF0", Offset = "0x201EFF0", VA = "0x201EFF0")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x201EFFC", Offset = "0x201EFFC", VA = "0x201EFFC")]
	public void SetDisabled(bool disabled)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x201F008", Offset = "0x201F008", VA = "0x201F008")]
	public MUI_click_Effect()
	{
	}
}
[Token(Token = "0x200003B")]
public class MUI_cut_TextArea : MonoBehaviour
{
	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float W;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string cutSuffix;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected TextMesh textMesh;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Hashtable dictCharWidth;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 scaleOrg;

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x201F040", Offset = "0x201F040", VA = "0x201F040")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x201F0B8", Offset = "0x201F0B8", VA = "0x201F0B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x201F498", Offset = "0x201F498", VA = "0x201F498")]
	private void Update()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x201F49C", Offset = "0x201F49C", VA = "0x201F49C")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x201F0BC", Offset = "0x201F0BC", VA = "0x201F0BC")]
	public void Calculate()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x201F8F0", Offset = "0x201F8F0", VA = "0x201F8F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x201F5C4", Offset = "0x201F5C4", VA = "0x201F5C4")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x201F4A0", Offset = "0x201F4A0", VA = "0x201F4A0")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x201FBF0", Offset = "0x201FBF0", VA = "0x201FBF0")]
	public MUI_cut_TextArea()
	{
	}
}
[Token(Token = "0x200003C")]
public enum eCheck
{
	[Token(Token = "0x400019E")]
	flyPlane,
	[Token(Token = "0x400019F")]
	friendsOnRadar,
	[Token(Token = "0x40001A0")]
	useJoystickVibration,
	[Token(Token = "0x40001A1")]
	unused_nationVoiceovers,
	[Token(Token = "0x40001A2")]
	translateCommunityTexts,
	[Token(Token = "0x40001A3")]
	steeringRightHand,
	[Token(Token = "0x40001A4")]
	unused,
	[Token(Token = "0x40001A5")]
	switchThumbsticks,
	[Token(Token = "0x40001A6")]
	showPlayerNames,
	[Token(Token = "0x40001A7")]
	netUseVoiceTransmission,
	[Token(Token = "0x40001A8")]
	stickyGrip,
	[Token(Token = "0x40001A9")]
	bhaptics,
	[Token(Token = "0x40001AA")]
	num
}
[Token(Token = "0x200003D")]
public enum eSlider
{
	[Token(Token = "0x40001AC")]
	volumeInterface,
	[Token(Token = "0x40001AD")]
	volumeBattle,
	[Token(Token = "0x40001AE")]
	volumeMusic,
	[Token(Token = "0x40001AF")]
	volumeEditorMusic,
	[Token(Token = "0x40001B0")]
	comfortMode,
	[Token(Token = "0x40001B1")]
	playerNameSize,
	[Token(Token = "0x40001B2")]
	dynamicComfortMode,
	[Token(Token = "0x40001B3")]
	volumeMultiplayerVoice,
	[Token(Token = "0x40001B4")]
	seatHeight,
	[Token(Token = "0x40001B5")]
	seatArmLength,
	[Token(Token = "0x40001B6")]
	num
}
[Token(Token = "0x200003E")]
public enum eCheckNotSaved
{
	[Token(Token = "0x40001B8")]
	none,
	[Token(Token = "0x40001B9")]
	freeCamera,
	[Token(Token = "0x40001BA")]
	num
}
[Token(Token = "0x200003F")]
public class MUI_data : MonoBehaviour
{
	[Token(Token = "0x20000A8")]
	public delegate void Loaded();

	[Token(Token = "0x20000A9")]
	public delegate void StateChanged(eCheck state, bool val);

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Loaded OnLoaded;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static StateChanged OnStateChange;

	[Token(Token = "0x40001BD")]
	private const int countB = 12;

	[Token(Token = "0x40001BE")]
	private const int countF = 10;

	[Token(Token = "0x40001BF")]
	private const string saveKey = "MUI_data1";

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool[] statesB;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static bool[] hadState;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static float[] statesF;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static float scale;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static bool lineBreakCH;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public static bool ready;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public static bool defaultStickyGrip;

	[Token(Token = "0x40001C7")]
	private const int countNS = 2;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static bool[] statesNS;

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1D2F180", Offset = "0x1D2F180", VA = "0x1D2F180")]
	public static void Init()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1D2F1EC", Offset = "0x1D2F1EC", VA = "0x1D2F1EC")]
	public static void InitDefaults()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1D2F9E8", Offset = "0x1D2F9E8", VA = "0x1D2F9E8")]
	public static bool HadSet(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x1D2FAB8", Offset = "0x1D2FAB8", VA = "0x1D2FAB8")]
	public static bool Get(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x1D2FB88", Offset = "0x1D2FB88", VA = "0x1D2FB88")]
	public static void Set(eCheck e, bool v)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1D2FBF8", Offset = "0x1D2FBF8", VA = "0x1D2FBF8")]
	public static void Set(int i, bool v)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1D2FD10", Offset = "0x1D2FD10", VA = "0x1D2FD10")]
	public static void Switch(eCheck i)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1D2FE58", Offset = "0x1D2FE58", VA = "0x1D2FE58")]
	public static float GetFloat(eSlider i)
	{
		return default(float);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x1D2FEE8", Offset = "0x1D2FEE8", VA = "0x1D2FEE8")]
	public static void SetFloat(eSlider i, float v)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1D2FF9C", Offset = "0x1D2FF9C", VA = "0x1D2FF9C")]
	public static bool GetNS(eCheckNotSaved i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1D3002C", Offset = "0x1D3002C", VA = "0x1D3002C")]
	public static void SetNS(int i, bool v)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1D300D4", Offset = "0x1D300D4", VA = "0x1D300D4")]
	public static void SwitchNS(eCheckNotSaved i)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1D3016C", Offset = "0x1D3016C", VA = "0x1D3016C")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1D30388", Offset = "0x1D30388", VA = "0x1D30388")]
	public static bool CanLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1D2F5D8", Offset = "0x1D2F5D8", VA = "0x1D2F5D8")]
	public static void Load()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1D3041C", Offset = "0x1D3041C", VA = "0x1D3041C")]
	private void Click()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1D30474", Offset = "0x1D30474", VA = "0x1D30474")]
	public MUI_data()
	{
	}
}
[Token(Token = "0x2000040")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8EB744", Offset = "0x8EB744")]
public class MUI_setup_LineBreak : MonoBehaviour
{
	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float wantedWidth;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool removeLineBreaks;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool removeSingleLineBreaks;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int leaveFirstNbreaks;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool justifyLines;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int maxLines;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int textCapacity;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int wordCapacity;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool dontRemoveLineBreaks;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float lastScale;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TextSize ts;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool breakLine;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Renderer r;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 scaleOrg;

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1D30568", Offset = "0x1D30568", VA = "0x1D30568")]
	private void Awake()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1D30670", Offset = "0x1D30670", VA = "0x1D30670")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x1D30974", Offset = "0x1D30974", VA = "0x1D30974")]
	private void SetWidth(float w)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1D3097C", Offset = "0x1D3097C", VA = "0x1D3097C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1D30BC4", Offset = "0x1D30BC4", VA = "0x1D30BC4")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1D3098C", Offset = "0x1D3098C", VA = "0x1D3098C")]
	private void BreakNow()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1D30BC8", Offset = "0x1D30BC8", VA = "0x1D30BC8")]
	public static int IndexOfNth(string str, char c, int nth, int startPosition = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1D30C80", Offset = "0x1D30C80", VA = "0x1D30C80")]
	public void BreakLinesFromLine(int line, float width)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1D30E80", Offset = "0x1D30E80", VA = "0x1D30E80")]
	public MUI_setup_LineBreak()
	{
	}
}
[Token(Token = "0x2000041")]
internal class StringBufferWrapper
{
	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly StringBuilder y;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly StringBuffer x;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly bool ub;

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1CAB628", Offset = "0x1CAB628", VA = "0x1CAB628")]
	public StringBufferWrapper(int capacity)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1CAB6DC", Offset = "0x1CAB6DC", VA = "0x1CAB6DC")]
	public StringBufferWrapper()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x1CAB744", Offset = "0x1CAB744", VA = "0x1CAB744")]
	public void Clear()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x1CAB780", Offset = "0x1CAB780", VA = "0x1CAB780")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x1CAB7B8", Offset = "0x1CAB7B8", VA = "0x1CAB7B8")]
	public unsafe void Append(char* str, int startIdx, int count)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x1CAB800", Offset = "0x1CAB800", VA = "0x1CAB800")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x1CAB864", Offset = "0x1CAB864", VA = "0x1CAB864")]
	public void Append(StringBufferWrapper sb)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1CAB8AC", Offset = "0x1CAB8AC", VA = "0x1CAB8AC")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x1CAB914", Offset = "0x1CAB914", VA = "0x1CAB914")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1CAB980", Offset = "0x1CAB980", VA = "0x1CAB980")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1CABA0C", Offset = "0x1CABA0C", VA = "0x1CABA0C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000042")]
public class TextSize
{
	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<char, float> dict;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMesh textMesh;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer renderer;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private StringBufferWrapper cachedString;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StringBufferWrapper cachedWord;

	[Token(Token = "0x17000007")]
	public float width
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1CABA40", Offset = "0x1CABA40", VA = "0x1CABA40")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000008")]
	public float height
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1CABC28", Offset = "0x1CABC28", VA = "0x1CABC28")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1CABC80", Offset = "0x1CABC80", VA = "0x1CABC80")]
	public TextSize(TextMesh tm, int textCapacity = -1, int wordCapacity = -1)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1CABD8C", Offset = "0x1CABD8C", VA = "0x1CABD8C")]
	private void getSpace()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1CABA78", Offset = "0x1CABA78", VA = "0x1CABA78")]
	private float GetTextWidth(string s)
	{
		return default(float);
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1CABF34", Offset = "0x1CABF34", VA = "0x1CABF34")]
	private string RemoveLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1CAC058", Offset = "0x1CAC058", VA = "0x1CAC058")]
	private string RemoveSingleLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1CAC1F4", Offset = "0x1CAC1F4", VA = "0x1CAC1F4")]
	public void FitToWidth(float wantedWidth, bool removeLineBreaks, bool removeSingleLineBreaks, int leaveFirstNbreaks, bool justifyLines, bool resetDictionary, int maxLines)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1CAC9C0", Offset = "0x1CAC9C0", VA = "0x1CAC9C0")]
	private bool IsCHchar(char c)
	{
		return default(bool);
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x1CAC4D4", Offset = "0x1CAC4D4", VA = "0x1CAC4D4")]
	private unsafe bool WrapLine(char* s, int startIdx, int endIdx, float w, bool justifyLine)
	{
		return default(bool);
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1CAC9D0", Offset = "0x1CAC9D0", VA = "0x1CAC9D0")]
	private string JustifyLine(List<string> words, float wordsWidth, float w)
	{
		return null;
	}
}
[Token(Token = "0x2000043")]
public class MUI_setup_TextArea : MonoBehaviour
{
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float W;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float H;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 scaleOrg;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int delay;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Renderer r;

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1D30EAC", Offset = "0x1D30EAC", VA = "0x1D30EAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1D30F24", Offset = "0x1D30F24", VA = "0x1D30F24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1D30F30", Offset = "0x1D30F30", VA = "0x1D30F30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1D311C4", Offset = "0x1D311C4", VA = "0x1D311C4")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1D30F68", Offset = "0x1D30F68", VA = "0x1D30F68")]
	public void Calculate()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1D311D0", Offset = "0x1D311D0", VA = "0x1D311D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1D314D4", Offset = "0x1D314D4", VA = "0x1D314D4")]
	public MUI_setup_TextArea()
	{
	}
}
[Token(Token = "0x2000044")]
public class StringBuffer
{
	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly char[] data;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly int capacity;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int idx;

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x1CAB290", Offset = "0x1CAB290", VA = "0x1CAB290")]
	public StringBuffer(int capacity)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1CAB304", Offset = "0x1CAB304", VA = "0x1CAB304")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1CAB30C", Offset = "0x1CAB30C", VA = "0x1CAB30C")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x1CAB398", Offset = "0x1CAB398", VA = "0x1CAB398")]
	public unsafe void Append(char* str, int count)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x1CAB408", Offset = "0x1CAB408", VA = "0x1CAB408")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x1CAB438", Offset = "0x1CAB438", VA = "0x1CAB438")]
	public void Append(StringBuffer sb)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1CAB4C8", Offset = "0x1CAB4C8", VA = "0x1CAB4C8")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x1CAB4FC", Offset = "0x1CAB4FC", VA = "0x1CAB4FC")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x1CAB554", Offset = "0x1CAB554", VA = "0x1CAB554")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x1CAB568", Offset = "0x1CAB568", VA = "0x1CAB568", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
public class MergeMesh : MonoBehaviour
{
	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool mergeOnStart;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool createTangent;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useUV2;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool vertexColors;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool useRenderer;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool checkOnlyActiveInHierarchy;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] predefinedList;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int indexV;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] indexT;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int indexO;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int indexM;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform[] tr;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material[] materials;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Mesh[] meshes;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[][] meshVertices;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] vertices;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector4[] tangents;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2[] uv;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Color32[] colors;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector2[] uv2;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int[][] triangles;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Mesh mesh;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool usePredefined;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int verticesCnt;

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x1D31560", Offset = "0x1D31560", VA = "0x1D31560")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1D31570", Offset = "0x1D31570", VA = "0x1D31570")]
	public void MergeMeshNow()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1D31C78", Offset = "0x1D31C78", VA = "0x1D31C78")]
	public void AddTR(Transform t0)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x1D32298", Offset = "0x1D32298", VA = "0x1D32298")]
	public void CountData(Mesh m, Vector3[] mvertices, Renderer r)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1D32F30", Offset = "0x1D32F30", VA = "0x1D32F30")]
	public void AddMaterial(Material m)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1D3303C", Offset = "0x1D3303C", VA = "0x1D3303C")]
	public int GetMaterialIndex(Material m)
	{
		return default(int);
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x1D32394", Offset = "0x1D32394", VA = "0x1D32394")]
	private void BuildMesh(Transform t, Mesh m, Vector3[] mvertices)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x1D32B34", Offset = "0x1D32B34", VA = "0x1D32B34")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x1D33154", Offset = "0x1D33154", VA = "0x1D33154")]
	public MergeMesh()
	{
	}
}
[Token(Token = "0x2000046")]
public class OpenUrl
{
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1CA3E40", Offset = "0x1CA3E40", VA = "0x1CA3E40")]
	public static void Open(string url)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1CA3E80", Offset = "0x1CA3E80", VA = "0x1CA3E80")]
	public static void Open(string url, string steamBundleID)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1CA3EEC", Offset = "0x1CA3EEC", VA = "0x1CA3EEC")]
	public OpenUrl()
	{
	}
}
[Token(Token = "0x2000047")]
public enum TargetStore
{
	[Token(Token = "0x4000201")]
	Sidequest,
	[Token(Token = "0x4000202")]
	Oculus,
	[Token(Token = "0x4000203")]
	Steam,
	[Token(Token = "0x4000204")]
	Vive,
	[Token(Token = "0x4000205")]
	Microsoft,
	[Token(Token = "0x4000206")]
	Nolo,
	[Token(Token = "0x4000207")]
	StandaloneOVR,
	[Token(Token = "0x4000208")]
	Pico,
	[Token(Token = "0x4000209")]
	YVR,
	[Token(Token = "0x400020A")]
	QIYU
}
[Token(Token = "0x2000048")]
public enum VRSDK
{
	[Token(Token = "0x400020C")]
	Oculus,
	[Token(Token = "0x400020D")]
	Steam,
	[Token(Token = "0x400020E")]
	Nolo,
	[Token(Token = "0x400020F")]
	Wave,
	[Token(Token = "0x4000210")]
	Pico,
	[Token(Token = "0x4000211")]
	YVR,
	[Token(Token = "0x4000212")]
	QIYU
}
[Token(Token = "0x2000049")]
public class Platform : UnityEngine.Object
{
	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static TargetStore targetStore;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool demo;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public static bool mission_editor;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static VRSDK vrSDK;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static bool pico_china;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public static bool pico_global;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public static bool dev_mode;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
	public static bool test_build;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool mousekbd_input;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	private static bool devModeChecked;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static int oculusShellEnvVersionCached;

	[Token(Token = "0x400021E")]
	public const int minRequiredQuestSystemVersion = 29;

	[Token(Token = "0x17000009")]
	public static bool editor
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1CA3EF4", Offset = "0x1CA3EF4", VA = "0x1CA3EF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	public static bool sidequestStore
	{
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1CA3EFC", Offset = "0x1CA3EFC", VA = "0x1CA3EFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	public static bool oculusStore
	{
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1CA3F68", Offset = "0x1CA3F68", VA = "0x1CA3F68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public static bool steamStore
	{
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1CA3FD4", Offset = "0x1CA3FD4", VA = "0x1CA3FD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public static bool viveStore
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1CA4040", Offset = "0x1CA4040", VA = "0x1CA4040")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public static bool microsoftStore
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1CA40AC", Offset = "0x1CA40AC", VA = "0x1CA40AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public static bool noloStore
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1CA4118", Offset = "0x1CA4118", VA = "0x1CA4118")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public static bool picoStore
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1CA4184", Offset = "0x1CA4184", VA = "0x1CA4184")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public static bool yvrStore
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1CA41F0", Offset = "0x1CA41F0", VA = "0x1CA41F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public static bool qiyuStore
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1CA425C", Offset = "0x1CA425C", VA = "0x1CA425C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public static bool standaloneOVRStore
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1CA42C8", Offset = "0x1CA42C8", VA = "0x1CA42C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public static bool oculusVR
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1CA4334", Offset = "0x1CA4334", VA = "0x1CA4334")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public static bool steamVR
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1CA43A0", Offset = "0x1CA43A0", VA = "0x1CA43A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000016")]
	public static bool noloVR
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1CA440C", Offset = "0x1CA440C", VA = "0x1CA440C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public static bool waveVR
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1CA4478", Offset = "0x1CA4478", VA = "0x1CA4478")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public static bool picoVR
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1CA44E4", Offset = "0x1CA44E4", VA = "0x1CA44E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000019")]
	public static bool yvrVR
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1CA4550", Offset = "0x1CA4550", VA = "0x1CA4550")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001A")]
	public static bool qiyuVR
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1CA45BC", Offset = "0x1CA45BC", VA = "0x1CA45BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001B")]
	public static bool android
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1CA4628", Offset = "0x1CA4628", VA = "0x1CA4628")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001C")]
	public static bool winStore
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1CA4630", Offset = "0x1CA4630", VA = "0x1CA4630")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001D")]
	public static bool winStandalone
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1CA4638", Offset = "0x1CA4638", VA = "0x1CA4638")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public static bool iOS
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1CA4640", Offset = "0x1CA4640", VA = "0x1CA4640")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public static bool macOsStandalone
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1CA4648", Offset = "0x1CA4648", VA = "0x1CA4648")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public static bool standalone
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1CA4650", Offset = "0x1CA4650", VA = "0x1CA4650")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public static bool linuxStandalone
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1CA4658", Offset = "0x1CA4658", VA = "0x1CA4658")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public static bool mobile
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1CA4660", Offset = "0x1CA4660", VA = "0x1CA4660")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000023")]
	public static bool PC
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1CA46BC", Offset = "0x1CA46BC", VA = "0x1CA46BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000024")]
	public static string str0xA0
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1CA4730", Offset = "0x1CA4730", VA = "0x1CA4730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x1CA4774", Offset = "0x1CA4774", VA = "0x1CA4774")]
	public static void CheckDevMode()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x1CA4934", Offset = "0x1CA4934", VA = "0x1CA4934")]
	public static int GetQuestSystemVersion()
	{
		return default(int);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x1CA5188", Offset = "0x1CA5188", VA = "0x1CA5188")]
	public static bool IsMinRequiredQuestSystemVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x1CA5214", Offset = "0x1CA5214", VA = "0x1CA5214")]
	public Platform()
	{
	}
}
[Token(Token = "0x200004A")]
public class ComputeDiffuseEnvironmentMap : MonoBehaviour
{
	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] mat;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Cubemap filteredCubeMap;

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x1AC08F0", Offset = "0x1AC08F0", VA = "0x1AC08F0")]
	public void ComputeConvolution(Cubemap originalCubeMap)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x1AC0F14", Offset = "0x1AC0F14", VA = "0x1AC0F14")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x1AC0B6C", Offset = "0x1AC0B6C", VA = "0x1AC0B6C")]
	private Cubemap computeFilteredCubeMap(Cubemap originalCubeMap)
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x1AC1138", Offset = "0x1AC1138", VA = "0x1AC1138")]
	private void setFaceAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x1AC1268", Offset = "0x1AC1268", VA = "0x1AC1268")]
	private void setCornerAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f, int g, int h, int i)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x1AC0FC4", Offset = "0x1AC0FC4", VA = "0x1AC0FC4")]
	private Vector3 getDirection(int face, int i, int j, int size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x1AC142C", Offset = "0x1AC142C", VA = "0x1AC142C")]
	public ComputeDiffuseEnvironmentMap()
	{
	}
}
[Token(Token = "0x200004B")]
public struct EncodedInt
{
	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int xorHash;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private int encValue;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private int fakeValue;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private int plainValue;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool inited;

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x1AC9888", Offset = "0x1AC9888", VA = "0x1AC9888")]
	public static implicit operator EncodedInt(int value)
	{
		return default(EncodedInt);
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x1AC98A4", Offset = "0x1AC98A4", VA = "0x1AC98A4")]
	public static bool operator ==(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x1AC9938", Offset = "0x1AC9938", VA = "0x1AC9938")]
	public static bool operator !=(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x1AC9960", Offset = "0x1AC9960", VA = "0x1AC9960")]
	public static bool operator ==(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x1AC998C", Offset = "0x1AC998C", VA = "0x1AC998C")]
	public static bool operator !=(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x1AC99B8", Offset = "0x1AC99B8", VA = "0x1AC99B8")]
	public void setValue(int val)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x1AC98CC", Offset = "0x1AC98CC", VA = "0x1AC98CC")]
	public int getValue()
	{
		return default(int);
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x1AC9894", Offset = "0x1AC9894", VA = "0x1AC9894")]
	private EncodedInt(int val)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x1AC9A5C", Offset = "0x1AC9A5C", VA = "0x1AC9A5C")]
	private void Init(int val)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x1AC9AB4", Offset = "0x1AC9AB4", VA = "0x1AC9AB4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x1AC9AE0", Offset = "0x1AC9AE0", VA = "0x1AC9AE0")]
	public string ToString(string format)
	{
		return null;
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x1AC9B14", Offset = "0x1AC9B14", VA = "0x1AC9B14", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x1AC9BD4", Offset = "0x1AC9BD4", VA = "0x1AC9BD4")]
	public bool Equals(EncodedInt p)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x1AC9C08", Offset = "0x1AC9C08", VA = "0x1AC9C08", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200004C")]
public struct Vector2Int
{
	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int x;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int y;

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x1CAE010", Offset = "0x1CAE010", VA = "0x1CAE010")]
	public Vector2Int(int _x, int _y)
	{
	}
}
[Token(Token = "0x200004D")]
public class SaveWrapper : MonoBehaviour
{
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string qiyu_prefix;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static JSONObject jsonSave;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static bool saveChanged;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	protected static float saveChangedTime;

	[Token(Token = "0x400022C")]
	public const string wrapperSaveName = "saveGame";

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string[] saveKeys;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected static SaveWrapper instance;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected static string oculusSaveWrapperFile;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected static bool steamInitialized;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	protected static bool qiyuInitialized;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private static bool waitingForInitialize;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initializing;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float initializeStartTime;

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x1CA7564", Offset = "0x1CA7564", VA = "0x1CA7564")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1CA7C68", Offset = "0x1CA7C68", VA = "0x1CA7C68")]
	public static float GetFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x1CA7CD0", Offset = "0x1CA7CD0", VA = "0x1CA7CD0")]
	public static float GetFloat(string key, float defval)
	{
		return default(float);
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x1CA7DD8", Offset = "0x1CA7DD8", VA = "0x1CA7DD8")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x1CA7E40", Offset = "0x1CA7E40", VA = "0x1CA7E40")]
	public static int GetInt(string key, int defval)
	{
		return default(int);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x1CA7F48", Offset = "0x1CA7F48", VA = "0x1CA7F48")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x1CA7FC4", Offset = "0x1CA7FC4", VA = "0x1CA7FC4")]
	public static string GetString(string key, string defval)
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x1CA80E0", Offset = "0x1CA80E0", VA = "0x1CA80E0")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x1CA81C0", Offset = "0x1CA81C0", VA = "0x1CA81C0")]
	public static void Save()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1CA848C", Offset = "0x1CA848C", VA = "0x1CA848C")]
	public static void SetFloat(string key, float val)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x1CA8624", Offset = "0x1CA8624", VA = "0x1CA8624")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x1CA87BC", Offset = "0x1CA87BC", VA = "0x1CA87BC")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1CA76A8", Offset = "0x1CA76A8", VA = "0x1CA76A8")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x1CA8968", Offset = "0x1CA8968", VA = "0x1CA8968")]
	public static void InitQUIYU(string prefix)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x1CA896C", Offset = "0x1CA896C", VA = "0x1CA896C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1CA8FA4", Offset = "0x1CA8FA4", VA = "0x1CA8FA4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1CA8EF8", Offset = "0x1CA8EF8", VA = "0x1CA8EF8")]
	private string GetHardcodedOculusCloudSaveDirectory()
	{
		return null;
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x1CA9060", Offset = "0x1CA9060", VA = "0x1CA9060")]
	private void OnCompleteGetUserDirectoryPath(Message msg)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x1CA93EC", Offset = "0x1CA93EC", VA = "0x1CA93EC")]
	public static bool IsInitializing()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x1CA94FC", Offset = "0x1CA94FC", VA = "0x1CA94FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x1CA973C", Offset = "0x1CA973C", VA = "0x1CA973C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x1CA97E4", Offset = "0x1CA97E4", VA = "0x1CA97E4")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x1CA781C", Offset = "0x1CA781C", VA = "0x1CA781C")]
	public static bool IsUseWrapper()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x1CA790C", Offset = "0x1CA790C", VA = "0x1CA790C")]
	protected static void LoadWrapper()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x1CA82B4", Offset = "0x1CA82B4", VA = "0x1CA82B4")]
	protected static void StoreWrapper()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x1CA988C", Offset = "0x1CA988C", VA = "0x1CA988C")]
	public SaveWrapper()
	{
	}
}
[Token(Token = "0x200004E")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x20000AA")]
	public delegate void BoolEvent(bool arg);

	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB2C", Offset = "0x8EBB2C")]
	private sealed class <RunCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SteamManager <>4__this;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <counter>5__2;

		[Token(Token = "0x1700007E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x20B4E9C", Offset = "0x20B4E9C", VA = "0x20B4E9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x20B4EE4", Offset = "0x20B4EE4", VA = "0x20B4EE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x20B4DFC", Offset = "0x20B4DFC", VA = "0x20B4DFC")]
		[DebuggerHidden]
		public <RunCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x20B4E28", Offset = "0x20B4E28", VA = "0x20B4E28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x20B4E2C", Offset = "0x20B4E2C", VA = "0x20B4E2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x20B4EA4", Offset = "0x20B4EA4", VA = "0x20B4EA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int gameAppId;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int gameAppIdDemo;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SteamManager s_instance;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool s_EverInialized;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_bInitialized;

	[Token(Token = "0x17000025")]
	public static bool Initialized
	{
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1CAABEC", Offset = "0x1CAABEC", VA = "0x1CAABEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000026")]
	private static SteamManager Instance
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1CAACD8", Offset = "0x1CAACD8", VA = "0x1CAACD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000003")]
	public static event BoolEvent overlayActivated
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1CAB00C", Offset = "0x1CAB00C", VA = "0x1CAB00C")]
		add
		{
		}
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1CAB128", Offset = "0x1CAB128", VA = "0x1CAB128")]
		remove
		{
		}
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x1CAAD24", Offset = "0x1CAAD24", VA = "0x1CAAD24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x1CAAE54", Offset = "0x1CAAE54", VA = "0x1CAAE54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x1CAAEF8", Offset = "0x1CAAEF8", VA = "0x1CAAEF8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x1CAAF9C", Offset = "0x1CAAF9C", VA = "0x1CAAF9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x1CAAFA0", Offset = "0x1CAAFA0", VA = "0x1CAAFA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDA50", Offset = "0x8EDA50")]
	private IEnumerator RunCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x1CAB244", Offset = "0x1CAB244", VA = "0x1CAB244")]
	public static string GetPlayerName()
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x1CAB288", Offset = "0x1CAB288", VA = "0x1CAB288")]
	public SteamManager()
	{
	}
}
[Token(Token = "0x200004F")]
public class TextureWWWDownloader : MonoBehaviour
{
	[Token(Token = "0x20000AC")]
	public class DownloadedTexture
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string filePath;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest request;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool done;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture texture;

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x20B51C0", Offset = "0x20B51C0", VA = "0x20B51C0")]
		public DownloadedTexture()
		{
		}
	}

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static TextureWWWDownloader instance;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected List<DownloadedTexture> textures;

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x1CACCAC", Offset = "0x1CACCAC", VA = "0x1CACCAC")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x1CACCB0", Offset = "0x1CACCB0", VA = "0x1CACCB0")]
	public static void LogError(string text)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x1CACD40", Offset = "0x1CACD40", VA = "0x1CACD40")]
	private void Awake()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x1CACE48", Offset = "0x1CACE48", VA = "0x1CACE48")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x1CACEEC", Offset = "0x1CACEEC", VA = "0x1CACEEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x1CAD80C", Offset = "0x1CAD80C", VA = "0x1CAD80C")]
	public static DownloadedTexture GetTexture(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x1CAD858", Offset = "0x1CAD858", VA = "0x1CAD858")]
	public static DownloadedTexture GetTexture(string filePath, string resourcesFolder)
	{
		return null;
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x1CADF48", Offset = "0x1CADF48", VA = "0x1CADF48")]
	protected static string GetFileName(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x1CACEF0", Offset = "0x1CACEF0", VA = "0x1CACEF0")]
	private void StepDownloadingTextures()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x1CADF98", Offset = "0x1CADF98", VA = "0x1CADF98")]
	public TextureWWWDownloader()
	{
	}
}
[Token(Token = "0x2000050")]
public class WWWwrapper : CustomYieldInstruction
{
	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected UnityWebRequest request;

	[Token(Token = "0x17000027")]
	public override bool keepWaiting
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1CAE134", Offset = "0x1CAE134", VA = "0x1CAE134", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000028")]
	public string error
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1CAE160", Offset = "0x1CAE160", VA = "0x1CAE160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public string text
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1CAE208", Offset = "0x1CAE208", VA = "0x1CAE208")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public byte[] data
	{
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1CAE234", Offset = "0x1CAE234", VA = "0x1CAE234")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	public string data2string
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1CAE260", Offset = "0x1CAE260", VA = "0x1CAE260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public bool isDone
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1CAE374", Offset = "0x1CAE374", VA = "0x1CAE374")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x1CAE390", Offset = "0x1CAE390", VA = "0x1CAE390")]
	public WWWwrapper(string url, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x1CAE508", Offset = "0x1CAE508", VA = "0x1CAE508")]
	public WWWwrapper(string url, WWWForm form, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x1CAE6A0", Offset = "0x1CAE6A0", VA = "0x1CAE6A0")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x1CAE6BC", Offset = "0x1CAE6BC", VA = "0x1CAE6BC")]
	public static string EscapeURL(string url)
	{
		return null;
	}
}
[Token(Token = "0x2000051")]
public class AndroidPermissionCallback : AndroidJavaProxy
{
	[Token(Token = "0x14000004")]
	private event Action<string> OnPermissionGrantedAction
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1A508A4", Offset = "0x1A508A4", VA = "0x1A508A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDAB0", Offset = "0x8EDAB0")]
		add
		{
		}
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1A50944", Offset = "0x1A50944", VA = "0x1A50944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDAC0", Offset = "0x8EDAC0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	private event Action<string> OnPermissionDeniedAction
	{
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1A509E4", Offset = "0x1A509E4", VA = "0x1A509E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDAD0", Offset = "0x8EDAD0")]
		add
		{
		}
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1A50A84", Offset = "0x1A50A84", VA = "0x1A50A84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDAE0", Offset = "0x8EDAE0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	private event Action<string> OnPermissionDeniedAndDontAskAgainAction
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1A50B24", Offset = "0x1A50B24", VA = "0x1A50B24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDAF0", Offset = "0x8EDAF0")]
		add
		{
		}
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1A50BC4", Offset = "0x1A50BC4", VA = "0x1A50BC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDB00", Offset = "0x8EDB00")]
		remove
		{
		}
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x1A50C64", Offset = "0x1A50C64", VA = "0x1A50C64")]
	public AndroidPermissionCallback(Action<string> onGrantedCallback, Action<string> onDeniedCallback, Action<string> onDeniedAndDontAskAgainCallback)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x1A50D40", Offset = "0x1A50D40", VA = "0x1A50D40", Slot = "9")]
	public virtual void OnPermissionGranted(string permissionName)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x1A50DB0", Offset = "0x1A50DB0", VA = "0x1A50DB0", Slot = "10")]
	public virtual void OnPermissionDenied(string permissionName)
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x1A50E20", Offset = "0x1A50E20", VA = "0x1A50E20", Slot = "11")]
	public virtual void OnPermissionDeniedAndDontAskAgain(string permissionName)
	{
	}
}
[Token(Token = "0x2000052")]
public class AndroidPermissionsManager
{
	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject m_Activity;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject m_PermissionService;

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x1A50E98", Offset = "0x1A50E98", VA = "0x1A50E98")]
	private static AndroidJavaObject GetActivity()
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x1A50F80", Offset = "0x1A50F80", VA = "0x1A50F80")]
	private static AndroidJavaObject GetPermissionsService()
	{
		return null;
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x1A510C4", Offset = "0x1A510C4", VA = "0x1A510C4")]
	public static bool IsPermissionGranted(string permissionName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x1A511DC", Offset = "0x1A511DC", VA = "0x1A511DC")]
	public static void RequestPermission(string permissionName, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x1A51288", Offset = "0x1A51288", VA = "0x1A51288")]
	public static void RequestPermission(string[] permissionNames, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x1A513C0", Offset = "0x1A513C0", VA = "0x1A513C0")]
	public AndroidPermissionsManager()
	{
	}
}
[Token(Token = "0x2000053")]
[ExecuteInEditMode]
public class WaterSimple : MonoBehaviour
{
	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Renderer r;

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x1CB1A10", Offset = "0x1CB1A10", VA = "0x1CB1A10")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x1CB1A64", Offset = "0x1CB1A64", VA = "0x1CB1A64")]
	private void Update()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x1CB1DCC", Offset = "0x1CB1DCC", VA = "0x1CB1DCC")]
	public WaterSimple()
	{
	}
}
namespace JSONplugin
{
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8EB7C4", Offset = "0x8EB7C4")]
	public class JSONObject
	{
		[Token(Token = "0x20000AD")]
		public enum Type
		{
			[Token(Token = "0x4000459")]
			NULL,
			[Token(Token = "0x400045A")]
			STRING,
			[Token(Token = "0x400045B")]
			NUMBER,
			[Token(Token = "0x400045C")]
			OBJECT,
			[Token(Token = "0x400045D")]
			ARRAY,
			[Token(Token = "0x400045E")]
			BOOL,
			[Token(Token = "0x400045F")]
			BAKED
		}

		[Token(Token = "0x20000AE")]
		public delegate void AddJSONContents(JSONObject self);

		[Token(Token = "0x20000AF")]
		public delegate void FieldNotFound(string name);

		[Token(Token = "0x20000B0")]
		public delegate void GetFieldResponse(JSONObject obj);

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB3C", Offset = "0x8EBB3C")]
		private sealed class <BakeAsync>d__125 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<string> <>7__wrap1;

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600078F")]
				[Address(RVA = "0x20B109C", Offset = "0x20B109C", VA = "0x20B109C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000791")]
				[Address(RVA = "0x20B10E4", Offset = "0x20B10E4", VA = "0x20B10E4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x20B0CB0", Offset = "0x20B0CB0", VA = "0x20B0CB0")]
			[DebuggerHidden]
			public <BakeAsync>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x20B0CE8", Offset = "0x20B0CE8", VA = "0x20B0CE8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x20B0DC0", Offset = "0x20B0DC0", VA = "0x20B0DC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x20B0D04", Offset = "0x20B0D04", VA = "0x20B0D04")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x20B10A4", Offset = "0x20B10A4", VA = "0x20B10A4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x20B10EC", Offset = "0x20B10EC", VA = "0x20B10EC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x20B1194", Offset = "0x20B1194", VA = "0x20B1194", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB4C", Offset = "0x8EBB4C")]
		private sealed class <PrintAsync>d__128 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool pretty;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool <>3__pretty;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StringBuilder <builder>5__2;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator <>7__wrap2;

			[Token(Token = "0x17000082")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x6000798")]
				[Address(RVA = "0x20B1620", Offset = "0x20B1620", VA = "0x20B1620", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079A")]
				[Address(RVA = "0x20B1668", Offset = "0x20B1668", VA = "0x20B1668", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x20B1198", Offset = "0x20B1198", VA = "0x20B1198")]
			[DebuggerHidden]
			public <PrintAsync>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x20B11D0", Offset = "0x20B11D0", VA = "0x20B11D0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x20B12B4", Offset = "0x20B12B4", VA = "0x20B12B4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x20B11EC", Offset = "0x20B11EC", VA = "0x20B11EC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x20B1628", Offset = "0x20B1628", VA = "0x20B1628", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x20B1670", Offset = "0x20B1670", VA = "0x20B1670", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x20B1720", Offset = "0x20B1720", VA = "0x20B1720", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB5C", Offset = "0x8EBB5C")]
		private sealed class <StringifyAsync>d__131 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int depth;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int <>3__depth;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StringBuilder builder;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public StringBuilder <>3__builder;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool pretty;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool <>3__pretty;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <i>5__2;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private IEnumerator <>7__wrap2;

			[Token(Token = "0x17000084")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A2")]
				[Address(RVA = "0x20B293C", Offset = "0x20B293C", VA = "0x20B293C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A4")]
				[Address(RVA = "0x20B2984", Offset = "0x20B2984", VA = "0x20B2984", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x20B1724", Offset = "0x20B1724", VA = "0x20B1724")]
			[DebuggerHidden]
			public <StringifyAsync>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x20B175C", Offset = "0x20B175C", VA = "0x20B175C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x20B1988", Offset = "0x20B1988", VA = "0x20B1988", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x20B17F8", Offset = "0x20B17F8", VA = "0x20B17F8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x20B18C0", Offset = "0x20B18C0", VA = "0x20B18C0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x20B2944", Offset = "0x20B2944", VA = "0x20B2944", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x20B298C", Offset = "0x20B298C", VA = "0x20B298C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x20B2A4C", Offset = "0x20B2A4C", VA = "0x20B2A4C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000244")]
		private const int MAX_DEPTH = 100;

		[Token(Token = "0x4000245")]
		private const string INFINITY = "\"INFINITY\"";

		[Token(Token = "0x4000246")]
		private const string NEGINFINITY = "\"NEGINFINITY\"";

		[Token(Token = "0x4000247")]
		private const string NaN = "\"NaN\"";

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly char[] WHITESPACE;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<JSONObject> list;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> keys;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string str;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float n;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useInt;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long i;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool b;

		[Token(Token = "0x4000251")]
		private const float maxFrameTime = 0.008f;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Stopwatch printWatch;

		[Token(Token = "0x1700002D")]
		public bool isContainer
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1ACBF34", Offset = "0x1ACBF34", VA = "0x1ACBF34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		public int Count
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1ACBF48", Offset = "0x1ACBF48", VA = "0x1ACBF48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		public float f
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1ACBF98", Offset = "0x1ACBF98", VA = "0x1ACBF98")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000030")]
		public static JSONObject nullJO
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1ACBFA0", Offset = "0x1ACBFA0", VA = "0x1ACBFA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public static JSONObject obj
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1ACC12C", Offset = "0x1ACC12C", VA = "0x1ACC12C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public static JSONObject arr
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1ACC188", Offset = "0x1ACC188", VA = "0x1ACC188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public bool IsNumber
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1ACDC84", Offset = "0x1ACDC84", VA = "0x1ACDC84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		public bool IsNull
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1ACDC94", Offset = "0x1ACDC94", VA = "0x1ACDC94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool IsString
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1ACDCA4", Offset = "0x1ACDCA4", VA = "0x1ACDCA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public bool IsBool
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1ACDCB4", Offset = "0x1ACDCB4", VA = "0x1ACDCB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public bool IsArray
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1ACDCC4", Offset = "0x1ACDCC4", VA = "0x1ACDCC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public bool IsObject
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1ACDCD4", Offset = "0x1ACDCD4", VA = "0x1ACDCD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public JSONObject Item
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x1ACFC40", Offset = "0x1ACFC40", VA = "0x1ACFC40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1ACFCCC", Offset = "0x1ACFCCC", VA = "0x1ACFCCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public JSONObject Item
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1ACEB80", Offset = "0x1ACEB80", VA = "0x1ACEB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1AD06EC", Offset = "0x1AD06EC", VA = "0x1AD06EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1ACC1E4", Offset = "0x1ACC1E4", VA = "0x1ACC1E4")]
		public JSONObject(Type t)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1ACC2EC", Offset = "0x1ACC2EC", VA = "0x1ACC2EC")]
		public JSONObject(bool b)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1ACC324", Offset = "0x1ACC324", VA = "0x1ACC324")]
		public JSONObject(float f)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1ACC360", Offset = "0x1ACC360", VA = "0x1ACC360")]
		public JSONObject(int i)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1ACC3A8", Offset = "0x1ACC3A8", VA = "0x1ACC3A8")]
		public JSONObject(long l)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1ACC3EC", Offset = "0x1ACC3EC", VA = "0x1ACC3EC")]
		public JSONObject(Dictionary<string, string> dic)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1ACC6E0", Offset = "0x1ACC6E0", VA = "0x1ACC6E0")]
		public JSONObject(Dictionary<string, JSONObject> dic)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1ACC90C", Offset = "0x1ACC90C", VA = "0x1ACC90C")]
		public JSONObject(AddJSONContents content)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1ACC948", Offset = "0x1ACC948", VA = "0x1ACC948")]
		public JSONObject(JSONObject[] objs)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1ACC9DC", Offset = "0x1ACC9DC", VA = "0x1ACC9DC")]
		public static JSONObject StringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1ACCA3C", Offset = "0x1ACCA3C", VA = "0x1ACCA3C")]
		public void Absorb(JSONObject obj)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1ACCB00", Offset = "0x1ACCB00", VA = "0x1ACCB00")]
		public static JSONObject Create()
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1ACBFFC", Offset = "0x1ACBFFC", VA = "0x1ACBFFC")]
		public static JSONObject Create(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1ACCB60", Offset = "0x1ACCB60", VA = "0x1ACCB60")]
		public static JSONObject Create(bool val)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1ACCBD8", Offset = "0x1ACCBD8", VA = "0x1ACCBD8")]
		public static JSONObject Create(float val)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1ACCC54", Offset = "0x1ACCC54", VA = "0x1ACCC54")]
		public static JSONObject Create(int val)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1ACCCDC", Offset = "0x1ACCCDC", VA = "0x1ACCCDC")]
		public static JSONObject Create(uint val)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1ACCD68", Offset = "0x1ACCD68", VA = "0x1ACCD68")]
		public static JSONObject Create(long val)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1ACCDEC", Offset = "0x1ACCDEC", VA = "0x1ACCDEC")]
		public static JSONObject Create(ulong val)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1ACC66C", Offset = "0x1ACC66C", VA = "0x1ACC66C")]
		public static JSONObject CreateStringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1ACCE74", Offset = "0x1ACCE74", VA = "0x1ACCE74")]
		public static JSONObject CreateBakedObject(string val)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1ACCEE8", Offset = "0x1ACCEE8", VA = "0x1ACCEE8")]
		public static JSONObject Create(string val, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1ACD844", Offset = "0x1ACD844", VA = "0x1ACD844")]
		public static JSONObject Create(AddJSONContents content)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1ACD8C4", Offset = "0x1ACD8C4", VA = "0x1ACD8C4")]
		public static JSONObject Create(Dictionary<string, string> dic)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1ACCB58", Offset = "0x1ACCB58", VA = "0x1ACCB58")]
		public JSONObject()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1ACDB5C", Offset = "0x1ACDB5C", VA = "0x1ACDB5C")]
		public JSONObject(string str)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1ACDB98", Offset = "0x1ACDB98", VA = "0x1ACDB98")]
		public JSONObject(string str, int maxDepth)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1ACDBE0", Offset = "0x1ACDBE0", VA = "0x1ACDBE0")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1ACDC2C", Offset = "0x1ACDC2C", VA = "0x1ACDC2C")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels, bool strict)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1ACCF88", Offset = "0x1ACCF88", VA = "0x1ACCF88")]
		private void Parse(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1ACDCF0", Offset = "0x1ACDCF0", VA = "0x1ACDCF0")]
		public void Add(bool val)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1ACDE78", Offset = "0x1ACDE78", VA = "0x1ACDE78")]
		public void Add(float val)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1ACDEF0", Offset = "0x1ACDEF0", VA = "0x1ACDEF0")]
		public void Add(int val)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1ACDF68", Offset = "0x1ACDF68", VA = "0x1ACDF68")]
		public void Add(uint val)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1ACDFE0", Offset = "0x1ACDFE0", VA = "0x1ACDFE0")]
		public void Add(long val)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1ACE058", Offset = "0x1ACE058", VA = "0x1ACE058")]
		public void Add(ulong val)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1ACE0D0", Offset = "0x1ACE0D0", VA = "0x1ACE0D0")]
		public void Add(string str)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1ACE148", Offset = "0x1ACE148", VA = "0x1ACE148")]
		public void Add(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1ACDD68", Offset = "0x1ACDD68", VA = "0x1ACDD68")]
		public void Add(JSONObject obj)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1ACE1CC", Offset = "0x1ACE1CC", VA = "0x1ACE1CC")]
		public void AddField(string name, bool val)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1ACE464", Offset = "0x1ACE464", VA = "0x1ACE464")]
		public void AddField(string name, float val)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1ACE4EC", Offset = "0x1ACE4EC", VA = "0x1ACE4EC")]
		public void AddField(string name, int val)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1ACE56C", Offset = "0x1ACE56C", VA = "0x1ACE56C")]
		public void AddField(string name, uint val)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1ACE5EC", Offset = "0x1ACE5EC", VA = "0x1ACE5EC")]
		public void AddField(string name, long val)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1ACE66C", Offset = "0x1ACE66C", VA = "0x1ACE66C")]
		public void AddField(string name, ulong val)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1ACE6EC", Offset = "0x1ACE6EC", VA = "0x1ACE6EC")]
		public void AddField(string name, AddJSONContents content)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1ACE76C", Offset = "0x1ACE76C", VA = "0x1ACE76C")]
		public void AddField(string name, string val)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1ACE24C", Offset = "0x1ACE24C", VA = "0x1ACE24C")]
		public void AddField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1ACE7EC", Offset = "0x1ACE7EC", VA = "0x1ACE7EC")]
		public void SetField(string name, string val)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1ACE92C", Offset = "0x1ACE92C", VA = "0x1ACE92C")]
		public void SetField(string name, bool val)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1ACE9AC", Offset = "0x1ACE9AC", VA = "0x1ACE9AC")]
		public void SetField(string name, float val)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1ACEA34", Offset = "0x1ACEA34", VA = "0x1ACEA34")]
		public void SetField(string name, int val)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1ACE86C", Offset = "0x1ACE86C", VA = "0x1ACE86C")]
		public void SetField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1ACEB84", Offset = "0x1ACEB84", VA = "0x1ACEB84")]
		public void RemoveField(string name)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1ACEC64", Offset = "0x1ACEC64", VA = "0x1ACEC64")]
		public bool GetField(out bool field, string name, bool fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1ACEC74", Offset = "0x1ACEC74", VA = "0x1ACEC74")]
		public bool GetField(ref bool field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1ACEC7C", Offset = "0x1ACEC7C", VA = "0x1ACEC7C")]
		public bool GetField(ref bool field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1ACED68", Offset = "0x1ACED68", VA = "0x1ACED68")]
		public bool GetField(out float field, string name, float fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1ACED74", Offset = "0x1ACED74", VA = "0x1ACED74")]
		public bool GetField(ref float field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1ACED7C", Offset = "0x1ACED7C", VA = "0x1ACED7C")]
		public bool GetField(ref float field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1ACEE68", Offset = "0x1ACEE68", VA = "0x1ACEE68")]
		public bool GetField(out int field, string name, int fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1ACEE74", Offset = "0x1ACEE74", VA = "0x1ACEE74")]
		public bool GetField(ref int field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1ACEE7C", Offset = "0x1ACEE7C", VA = "0x1ACEE7C")]
		public bool GetField(ref int field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1ACEFB4", Offset = "0x1ACEFB4", VA = "0x1ACEFB4")]
		public bool GetField(out long field, string name, long fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1ACEFC0", Offset = "0x1ACEFC0", VA = "0x1ACEFC0")]
		public bool GetField(ref long field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1ACEFC8", Offset = "0x1ACEFC8", VA = "0x1ACEFC8")]
		public bool GetField(ref long field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1ACF100", Offset = "0x1ACF100", VA = "0x1ACF100")]
		public bool GetField(out uint field, string name, uint fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1ACF10C", Offset = "0x1ACF10C", VA = "0x1ACF10C")]
		public bool GetField(ref uint field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1ACF114", Offset = "0x1ACF114", VA = "0x1ACF114")]
		public bool GetField(ref uint field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1ACF258", Offset = "0x1ACF258", VA = "0x1ACF258")]
		public bool GetField(out ulong field, string name, ulong fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1ACF264", Offset = "0x1ACF264", VA = "0x1ACF264")]
		public bool GetField(ref ulong field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1ACF26C", Offset = "0x1ACF26C", VA = "0x1ACF26C")]
		public bool GetField(ref ulong field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1ACF3B0", Offset = "0x1ACF3B0", VA = "0x1ACF3B0")]
		public bool GetField(out string field, string name, string fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1ACF3BC", Offset = "0x1ACF3BC", VA = "0x1ACF3BC")]
		public bool GetField(ref string field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1ACF3C4", Offset = "0x1ACF3C4", VA = "0x1ACF3C4")]
		public bool GetField(ref string field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1ACF4B8", Offset = "0x1ACF4B8", VA = "0x1ACF4B8")]
		public void GetField(string name, GetFieldResponse response, [Optional] FieldNotFound fail)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1ACF5C4", Offset = "0x1ACF5C4", VA = "0x1ACF5C4")]
		public JSONObject GetField(string name)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1ACF6C0", Offset = "0x1ACF6C0", VA = "0x1ACF6C0")]
		public bool HasFields(string[] names)
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1ACEAB4", Offset = "0x1ACEAB4", VA = "0x1ACEAB4")]
		public bool HasField(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1ACF794", Offset = "0x1ACF794", VA = "0x1ACF794")]
		public void Clear()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1ACF83C", Offset = "0x1ACF83C", VA = "0x1ACF83C")]
		public JSONObject Copy()
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1ACF8C4", Offset = "0x1ACF8C4", VA = "0x1ACF8C4")]
		public void Merge(JSONObject obj)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1ACF934", Offset = "0x1ACF934", VA = "0x1ACF934")]
		private static void MergeRecur(JSONObject left, JSONObject right)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1ACFD60", Offset = "0x1ACFD60", VA = "0x1ACFD60")]
		public void Bake()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1ACFD9C", Offset = "0x1ACFD9C", VA = "0x1ACFD9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDB10", Offset = "0x8EDB10")]
		public IEnumerable BakeAsync()
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1ACF8BC", Offset = "0x1ACF8BC", VA = "0x1ACF8BC")]
		public string Print()
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1ACFE08", Offset = "0x1ACFE08", VA = "0x1ACFE08")]
		public string Print(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1AD05D4", Offset = "0x1AD05D4", VA = "0x1AD05D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDB70", Offset = "0x8EDB70")]
		public IEnumerable<string> PrintAsync(bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1AD0654", Offset = "0x1AD0654", VA = "0x1AD0654")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDBD0", Offset = "0x8EDBD0")]
		private IEnumerable StringifyAsync(int depth, StringBuilder builder, bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1ACFE94", Offset = "0x1ACFE94", VA = "0x1ACFE94")]
		private void Stringify(int depth, StringBuilder builder, bool pretty = false)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1AD06F0", Offset = "0x1AD06F0", VA = "0x1AD06F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1AD06F8", Offset = "0x1AD06F8", VA = "0x1AD06F8")]
		public string ToString(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1AD0700", Offset = "0x1AD0700", VA = "0x1AD0700")]
		public Dictionary<string, string> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1ACE1C0", Offset = "0x1ACE1C0", VA = "0x1ACE1C0")]
		public static implicit operator bool(JSONObject o)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000055")]
	public static class JSONTemplates
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly HashSet<object> touched;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1AD09E8", Offset = "0x1AD09E8", VA = "0x1AD09E8")]
		public static JSONObject TOJSON(object obj)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1AD1654", Offset = "0x1AD1654", VA = "0x1AD1654")]
		public static Vector2 ToVector2(JSONObject obj)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1AD177C", Offset = "0x1AD177C", VA = "0x1AD177C")]
		public static JSONObject FromVector2(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1AD1854", Offset = "0x1AD1854", VA = "0x1AD1854")]
		public static JSONObject FromVector3(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1AD1968", Offset = "0x1AD1968", VA = "0x1AD1968")]
		public static Vector3 ToVector3(JSONObject obj)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1AD1AF8", Offset = "0x1AD1AF8", VA = "0x1AD1AF8")]
		public static JSONObject FromVector4(Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1AD1C40", Offset = "0x1AD1C40", VA = "0x1AD1C40")]
		public static Vector4 ToVector4(JSONObject obj)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1AD1E60", Offset = "0x1AD1E60", VA = "0x1AD1E60")]
		public static JSONObject FromMatrix4x4(Matrix4x4 m)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1AD21CC", Offset = "0x1AD21CC", VA = "0x1AD21CC")]
		public static Matrix4x4 ToMatrix4x4(JSONObject obj)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1AD28F0", Offset = "0x1AD28F0", VA = "0x1AD28F0")]
		public static JSONObject FromQuaternion(Quaternion q)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1AD2A38", Offset = "0x1AD2A38", VA = "0x1AD2A38")]
		public static Quaternion ToQuaternion(JSONObject obj)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1AD2C58", Offset = "0x1AD2C58", VA = "0x1AD2C58")]
		public static JSONObject FromColor(Color c)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1AD2DA0", Offset = "0x1AD2DA0", VA = "0x1AD2DA0")]
		public static Color ToColor(JSONObject obj)
		{
			return default(Color);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1AD2FA8", Offset = "0x1AD2FA8", VA = "0x1AD2FA8")]
		public static JSONObject FromLayerMask(LayerMask l)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1AD3048", Offset = "0x1AD3048", VA = "0x1AD3048")]
		public static LayerMask ToLayerMask(JSONObject obj)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1AD30C8", Offset = "0x1AD30C8", VA = "0x1AD30C8")]
		public static JSONObject FromRect(Rect r)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1AD3250", Offset = "0x1AD3250", VA = "0x1AD3250")]
		public static Rect ToRect(JSONObject obj)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1AD346C", Offset = "0x1AD346C", VA = "0x1AD346C")]
		public static JSONObject FromRectOffset(RectOffset r)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1AD35EC", Offset = "0x1AD35EC", VA = "0x1AD35EC")]
		public static RectOffset ToRectOffset(JSONObject obj)
		{
			return null;
		}
	}
}
namespace Crosstales.BadWord
{
	[Token(Token = "0x2000056")]
	public class BadWordFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB6C", Offset = "0x8EBB6C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__21_0;

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x1CB23D0", Offset = "0x1CB23D0", VA = "0x1CB23D0")]
			public <>c()
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1CB23D8", Offset = "0x1CB23D8", VA = "0x1CB23D8")]
			internal string <GetAll>b__21_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<BadWordProvider> badWordProviderLTR;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<BadWordProvider> badWordProviderRTL;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string ReplaceCharacters;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool Fuzzy;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<BadWordProvider> tempBadWordProviderLTR;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<BadWordProvider> tempBadWordProviderRTL;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, Regex> exactBadwordsRegex;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, Regex> fuzzyBadwordsRegex;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, List<Regex>> debugFuzzyBadwordsRegex;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool isReady;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool isReadyFirstime;

		[Token(Token = "0x1700003B")]
		public List<BadWordProvider> BadWordProviderLTR
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1A5142C", Offset = "0x1A5142C", VA = "0x1A5142C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1A51434", Offset = "0x1A51434", VA = "0x1A51434")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1A51810", Offset = "0x1A51810", VA = "0x1A51810")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1A51818", Offset = "0x1A51818", VA = "0x1A51818")]
			set
			{
			}
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1A51BF4", Offset = "0x1A51BF4", VA = "0x1A51BF4")]
		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters, bool fuzzy, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1A51D2C", Offset = "0x1A51D2C", VA = "0x1A51D2C", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1A524BC", Offset = "0x1A524BC", VA = "0x1A524BC", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1A53B38", Offset = "0x1A53B38", VA = "0x1A53B38", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1A57B94", Offset = "0x1A57B94", VA = "0x1A57B94", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1A5BE7C", Offset = "0x1A5BE7C", VA = "0x1A5BE7C", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	public class CapitalizationFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB7C", Offset = "0x8EBB7C")]
		private sealed class <>c
		{
			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x1CB32D0", Offset = "0x1CB32D0", VA = "0x1CB32D0")]
			public <>c()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x1CB32D8", Offset = "0x1CB32D8", VA = "0x1CB32D8")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBCFC", Offset = "0x8EBCFC")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x1700003D")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1A5E3D8", Offset = "0x1A5E3D8", VA = "0x1A5E3D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDC30", Offset = "0x8EDC30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1A5E3E0", Offset = "0x1A5E3E0", VA = "0x1A5E3E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDC40", Offset = "0x8EDC40")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int CharacterNumber
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1A5E3E8", Offset = "0x1A5E3E8", VA = "0x1A5E3E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1A5E3F0", Offset = "0x1A5E3F0", VA = "0x1A5E3F0")]
			set
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1A5E4B8", Offset = "0x1A5E4B8", VA = "0x1A5E4B8")]
		public CapitalizationFilter(int capitalizationCharsNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1A5E500", Offset = "0x1A5E500", VA = "0x1A5E500", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1A5E508", Offset = "0x1A5E508", VA = "0x1A5E508", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1A5E574", Offset = "0x1A5E574", VA = "0x1A5E574", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1A5ECD8", Offset = "0x1A5ECD8", VA = "0x1A5ECD8", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1A5F300", Offset = "0x1A5F300", VA = "0x1A5F300", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public class DomainFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB8C", Offset = "0x8EBB8C")]
		private sealed class <>c
		{
			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__13_0;

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x20AFCF4", Offset = "0x20AFCF4", VA = "0x20AFCF4")]
			public <>c()
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x20AFCFC", Offset = "0x20AFCFC", VA = "0x20AFCFC")]
			internal string <GetAll>b__13_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<DomainProvider> domainProvider;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string ReplaceCharacters;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<DomainProvider> tempDomainProvider;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> domainsRegex;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, List<Regex>> debugDomainsRegex;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isReady;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool isReadyFirstime;

		[Token(Token = "0x1700003F")]
		public List<DomainProvider> DomainProvider
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1AC167C", Offset = "0x1AC167C", VA = "0x1AC167C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x1AC1684", Offset = "0x1AC1684", VA = "0x1AC1684")]
			set
			{
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1AC19E8", Offset = "0x1AC19E8", VA = "0x1AC19E8")]
		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1AC1B78", Offset = "0x1AC1B78", VA = "0x1AC1B78", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1AC1FE0", Offset = "0x1AC1FE0", VA = "0x1AC1FE0", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1AC2D40", Offset = "0x1AC2D40", VA = "0x1AC2D40", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1AC4FFC", Offset = "0x1AC4FFC", VA = "0x1AC4FFC", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1AC74D4", Offset = "0x1AC74D4", VA = "0x1AC74D4", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	public abstract class Filter
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBB9C", Offset = "0x8EBB9C")]
		private sealed class <>c
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, Source>, string> <>9__8_0;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, Source>, Source> <>9__8_1;

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x20B0BF0", Offset = "0x20B0BF0", VA = "0x20B0BF0")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x20B0BF8", Offset = "0x20B0BF8", VA = "0x20B0BF8")]
			internal string <Sources>b__8_0(KeyValuePair<string, Source> x)
			{
				return null;
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x20B0C38", Offset = "0x20B0C38", VA = "0x20B0C38")]
			internal Source <Sources>b__8_1(KeyValuePair<string, Source> y)
			{
				return null;
			}
		}

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string MarkPrefix;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MarkPostfix;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, Source> sources;

		[Token(Token = "0x60003CE")]
		public abstract bool Ready();

		[Token(Token = "0x60003CF")]
		public abstract bool Contains(string testString, params string[] sources);

		[Token(Token = "0x60003D0")]
		public abstract List<string> GetAll(string testString, params string[] sources);

		[Token(Token = "0x60003D1")]
		public abstract string ReplaceAll(string testString, params string[] sources);

		[Token(Token = "0x60003D2")]
		public abstract string Replace(string text, List<string> badWords);

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1AC9C0C", Offset = "0x1AC9C0C", VA = "0x1AC9C0C", Slot = "9")]
		public virtual List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1AC9E84", Offset = "0x1AC9E84", VA = "0x1AC9E84", Slot = "10")]
		public virtual string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1ACA094", Offset = "0x1ACA094", VA = "0x1ACA094", Slot = "11")]
		public virtual string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1AC2CCC", Offset = "0x1AC2CCC", VA = "0x1AC2CCC")]
		protected void logFilterNotReady()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1AC2CC8", Offset = "0x1AC2CC8", VA = "0x1AC2CC8")]
		protected void logResourceNotFound(string res)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1AC2CC4", Offset = "0x1AC2CC4", VA = "0x1AC2CC4")]
		protected void logContains()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1AC4FF8", Offset = "0x1AC4FF8", VA = "0x1AC4FF8")]
		protected void logGetAll()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1AC7338", Offset = "0x1AC7338", VA = "0x1AC7338")]
		protected void logReplaceAll()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1AC1AC8", Offset = "0x1AC1AC8", VA = "0x1AC1AC8")]
		protected Filter()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class PunctuationFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBBAC", Offset = "0x8EBBAC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x20B4DEC", Offset = "0x20B4DEC", VA = "0x20B4DEC")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x20B4DF4", Offset = "0x20B4DF4", VA = "0x20B4DF4")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBD0C", Offset = "0x8EBD0C")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000040")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1CA55F8", Offset = "0x1CA55F8", VA = "0x1CA55F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDC50", Offset = "0x8EDC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1CA5600", Offset = "0x1CA5600", VA = "0x1CA5600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDC60", Offset = "0x8EDC60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int CharacterNumber
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1CA5608", Offset = "0x1CA5608", VA = "0x1CA5608")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1CA5610", Offset = "0x1CA5610", VA = "0x1CA5610")]
			set
			{
			}
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1CA56D8", Offset = "0x1CA56D8", VA = "0x1CA56D8")]
		public PunctuationFilter(int punctuationCharacterNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1CA5720", Offset = "0x1CA5720", VA = "0x1CA5720", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1CA5728", Offset = "0x1CA5728", VA = "0x1CA5728", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1CA5794", Offset = "0x1CA5794", VA = "0x1CA5794", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1CA5EF8", Offset = "0x1CA5EF8", VA = "0x1CA5EF8", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1CA6518", Offset = "0x1CA6518", VA = "0x1CA6518", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class BadWordManager : Manager
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBBBC", Offset = "0x8EBBBC")]
		private sealed class <initalize>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordManager <>4__this;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007BA")]
				[Address(RVA = "0x1CB2634", Offset = "0x1CB2634", VA = "0x1CB2634", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007BC")]
				[Address(RVA = "0x1CB267C", Offset = "0x1CB267C", VA = "0x1CB267C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1CB23E0", Offset = "0x1CB23E0", VA = "0x1CB23E0")]
			[DebuggerHidden]
			public <initalize>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x1CB240C", Offset = "0x1CB240C", VA = "0x1CB240C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1CB2410", Offset = "0x1CB2410", VA = "0x1CB2410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x1CB263C", Offset = "0x1CB263C", VA = "0x1CB263C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EBD1C", Offset = "0x8EBD1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBD1C", Offset = "0x8EBD1C")]
		public List<BadWordProvider> BadWordProviderLTR;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBD7C", Offset = "0x8EBD7C")]
		public List<BadWordProvider> BadWordProviderRTL;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EBDB4", Offset = "0x8EBDB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBDB4", Offset = "0x8EBDB4")]
		public string ReplaceChars;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBE14", Offset = "0x8EBE14")]
		public bool Fuzzy;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BadWordFilter filter;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000274")]
		private const string clazz = "BadWordManager";

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1A5C170", Offset = "0x1A5C170", VA = "0x1A5C170")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1A5C348", Offset = "0x1A5C348", VA = "0x1A5C348")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDC70", Offset = "0x8EDC70")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1A5C3B4", Offset = "0x1A5C3B4", VA = "0x1A5C3B4")]
		public static BadWordFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1A5C418", Offset = "0x1A5C418", VA = "0x1A5C418")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1A5C740", Offset = "0x1A5C740", VA = "0x1A5C740")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1A5C860", Offset = "0x1A5C860", VA = "0x1A5C860")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1A5C960", Offset = "0x1A5C960", VA = "0x1A5C960")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1A5CA9C", Offset = "0x1A5CA9C", VA = "0x1A5CA9C")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1A5CB9C", Offset = "0x1A5CB9C", VA = "0x1A5CB9C")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1A5CC9C", Offset = "0x1A5CC9C", VA = "0x1A5CC9C")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1A5CDB8", Offset = "0x1A5CDB8", VA = "0x1A5CDB8")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1A5C4FC", Offset = "0x1A5C4FC", VA = "0x1A5C4FC")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1A5CEC0", Offset = "0x1A5CEC0", VA = "0x1A5CEC0")]
		public BadWordManager()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class CapitalizationManager : Manager
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EBE4C", Offset = "0x8EBE4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBE4C", Offset = "0x8EBE4C")]
		public int CapitalizationCharsNumber;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CapitalizationFilter filter;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x400027A")]
		private const string clazz = "CapitalizationManager";

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1A5F5A4", Offset = "0x1A5F5A4", VA = "0x1A5F5A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1A5F88C", Offset = "0x1A5F88C", VA = "0x1A5F88C")]
		public static CapitalizationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1A5F8F0", Offset = "0x1A5F8F0", VA = "0x1A5F8F0")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1A5F964", Offset = "0x1A5F964", VA = "0x1A5F964")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1A5FCC8", Offset = "0x1A5FCC8", VA = "0x1A5FCC8")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1A5FDC8", Offset = "0x1A5FDC8", VA = "0x1A5FDC8")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1A5FF04", Offset = "0x1A5FF04", VA = "0x1A5FF04")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1A60004", Offset = "0x1A60004", VA = "0x1A60004")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1A60104", Offset = "0x1A60104", VA = "0x1A60104")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1A60220", Offset = "0x1A60220", VA = "0x1A60220")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1A5FA84", Offset = "0x1A5FA84", VA = "0x1A5FA84")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1A60328", Offset = "0x1A60328", VA = "0x1A60328")]
		public CapitalizationManager()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class DomainManager : Manager
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBBCC", Offset = "0x8EBBCC")]
		private sealed class <initalize>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainManager <>4__this;

			[Token(Token = "0x17000088")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x20AFF40", Offset = "0x20AFF40", VA = "0x20AFF40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C2")]
				[Address(RVA = "0x20AFF88", Offset = "0x20AFF88", VA = "0x20AFF88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x20AFD04", Offset = "0x20AFD04", VA = "0x20AFD04")]
			[DebuggerHidden]
			public <initalize>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x20AFD30", Offset = "0x20AFD30", VA = "0x20AFD30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x20AFD34", Offset = "0x20AFD34", VA = "0x20AFD34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x20AFF48", Offset = "0x20AFF48", VA = "0x20AFF48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EBEAC", Offset = "0x8EBEAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBEAC", Offset = "0x8EBEAC")]
		public List<DomainProvider> DomainProvider;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EBF0C", Offset = "0x8EBF0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBF0C", Offset = "0x8EBF0C")]
		public string ReplaceChars;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DomainFilter filter;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000281")]
		private const string clazz = "DomainManager";

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1AC77C4", Offset = "0x1AC77C4", VA = "0x1AC77C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1AC799C", Offset = "0x1AC799C", VA = "0x1AC799C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDCD0", Offset = "0x8EDCD0")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1AC7A08", Offset = "0x1AC7A08", VA = "0x1AC7A08")]
		public static DomainFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1AC7A6C", Offset = "0x1AC7A6C", VA = "0x1AC7A6C")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1AC7D94", Offset = "0x1AC7D94", VA = "0x1AC7D94")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1AC7EB4", Offset = "0x1AC7EB4", VA = "0x1AC7EB4")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1AC7FB4", Offset = "0x1AC7FB4", VA = "0x1AC7FB4")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1AC80F0", Offset = "0x1AC80F0", VA = "0x1AC80F0")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1AC81F0", Offset = "0x1AC81F0", VA = "0x1AC81F0")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1AC82F0", Offset = "0x1AC82F0", VA = "0x1AC82F0")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1AC840C", Offset = "0x1AC840C", VA = "0x1AC840C")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1AC7B50", Offset = "0x1AC7B50", VA = "0x1AC7B50")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1AC8514", Offset = "0x1AC8514", VA = "0x1AC8514")]
		public DomainManager()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public abstract class Manager : MonoBehaviour
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EBF6C", Offset = "0x8EBF6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBF6C", Offset = "0x8EBF6C")]
		public string MarkPrefix;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EBFCC", Offset = "0x8EBFCC")]
		public string MarkPostfix;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1D314F0", Offset = "0x1D314F0", VA = "0x1D314F0")]
		protected Manager()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class PunctuationManager : Manager
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC004", Offset = "0x8EC004")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC004", Offset = "0x8EC004")]
		public int PunctuationCharsNumber;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PunctuationFilter filter;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000289")]
		private const string clazz = "PunctuationManager";

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1CA67CC", Offset = "0x1CA67CC", VA = "0x1CA67CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1CA6AB4", Offset = "0x1CA6AB4", VA = "0x1CA6AB4")]
		public static PunctuationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1CA6B18", Offset = "0x1CA6B18", VA = "0x1CA6B18")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1CA6B8C", Offset = "0x1CA6B8C", VA = "0x1CA6B8C")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1CA6EF0", Offset = "0x1CA6EF0", VA = "0x1CA6EF0")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1CA6FF0", Offset = "0x1CA6FF0", VA = "0x1CA6FF0")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1CA712C", Offset = "0x1CA712C", VA = "0x1CA712C")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1CA722C", Offset = "0x1CA722C", VA = "0x1CA722C")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1CA732C", Offset = "0x1CA732C", VA = "0x1CA732C")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1CA7448", Offset = "0x1CA7448", VA = "0x1CA7448")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1CA6CAC", Offset = "0x1CA6CAC", VA = "0x1CA6CAC")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1CA7550", Offset = "0x1CA7550", VA = "0x1CA7550")]
		public PunctuationManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class BadWords
	{
		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Source Source;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> BadWordList;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1A5E1DC", Offset = "0x1A5E1DC", VA = "0x1A5E1DC")]
		public BadWords(Source source, List<string> badWordList)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1A5E214", Offset = "0x1A5E214", VA = "0x1A5E214", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class Domains
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Source Source;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> DomainList;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1AC9694", Offset = "0x1AC9694", VA = "0x1AC9694")]
		public Domains(Source source, List<string> domainList)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1AC96CC", Offset = "0x1AC96CC", VA = "0x1AC96CC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public abstract class Source
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC064", Offset = "0x8EC064")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC064", Offset = "0x8EC064")]
		public string Name;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC0C4", Offset = "0x8EC0C4")]
		public string Description;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC0FC", Offset = "0x8EC0FC")]
		public Sprite Icon;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1CA9A50", Offset = "0x1CA9A50", VA = "0x1CA9A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1CA9C24", Offset = "0x1CA9C24", VA = "0x1CA9C24")]
		protected Source()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public static class MultiManager
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBBDC", Offset = "0x8EBBDC")]
		private sealed class <>c
		{
			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Source, string> <>9__2_0;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, string> <>9__4_0;

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x20B4D64", Offset = "0x20B4D64", VA = "0x20B4D64")]
			public <>c()
			{
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x20B4D6C", Offset = "0x20B4D6C", VA = "0x20B4D6C")]
			internal string <Sources>b__2_0(Source x)
			{
				return null;
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x20B4D84", Offset = "0x20B4D84", VA = "0x20B4D84")]
			internal string <GetAll>b__4_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1D33164", Offset = "0x1D33164", VA = "0x1D33164")]
		public static Filter Filter(ManagerMask mask = ManagerMask.BadWord)
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1D33368", Offset = "0x1D33368", VA = "0x1D33368")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1D3347C", Offset = "0x1D3347C", VA = "0x1D3347C")]
		public static List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1D33768", Offset = "0x1D33768", VA = "0x1D33768")]
		public static bool Contains(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1D33A0C", Offset = "0x1D33A0C", VA = "0x1D33A0C")]
		public static List<string> GetAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1D33D4C", Offset = "0x1D33D4C", VA = "0x1D33D4C")]
		public static string ReplaceAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1D33EE8", Offset = "0x1D33EE8", VA = "0x1D33EE8")]
		public static string Replace(string text, List<string> badWords, ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1D34084", Offset = "0x1D34084", VA = "0x1D34084")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1D34134", Offset = "0x1D34134", VA = "0x1D34134")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	public abstract class BadWordProvider : Provider
	{
		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> exactBadwordsRegex;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, Regex> fuzzyBadwordsRegex;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, List<Regex>> debugFuzzyBadwordsRegex;

		[Token(Token = "0x4000297")]
		protected const string exactRegexStart = "(?<![\\w\\d])";

		[Token(Token = "0x4000298")]
		protected const string exactRegexEnd = "s?(?![\\w\\d])";

		[Token(Token = "0x4000299")]
		protected const string fuzzyRegexStart = "\\b\\w*";

		[Token(Token = "0x400029A")]
		protected const string fuzzyRegexEnd = "\\w*\\b";

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<BadWords> badwords;

		[Token(Token = "0x17000042")]
		public Dictionary<string, Regex> ExactBadwordsRegex
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1A5CF18", Offset = "0x1A5CF18", VA = "0x1A5CF18")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x1A5CF20", Offset = "0x1A5CF20", VA = "0x1A5CF20")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public Dictionary<string, Regex> FuzzyBadwordsRegex
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x1A5CF28", Offset = "0x1A5CF28", VA = "0x1A5CF28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x1A5CF30", Offset = "0x1A5CF30", VA = "0x1A5CF30")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1A5CF38", Offset = "0x1A5CF38", VA = "0x1A5CF38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x1A5CF40", Offset = "0x1A5CF40", VA = "0x1A5CF40")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public Dictionary<string, List<Regex>> DebugFuzzyBadwordsRegex
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x1A5CF48", Offset = "0x1A5CF48", VA = "0x1A5CF48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1A5CF50", Offset = "0x1A5CF50", VA = "0x1A5CF50")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1A5CF58", Offset = "0x1A5CF58", VA = "0x1A5CF58", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1A5DB44", Offset = "0x1A5DB44", VA = "0x1A5DB44")]
		protected BadWordProvider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class BadWordFile : Source
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC134", Offset = "0x8EC134")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC134", Offset = "0x8EC134")]
		public string File;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC194", Offset = "0x8EC194")]
		public int SkipHeaderLines;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC1CC", Offset = "0x8EC1CC")]
		public int SkipFooterLines;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC204", Offset = "0x8EC204")]
		public char SplitChar;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1A513C8", Offset = "0x1A513C8", VA = "0x1A513C8")]
		public BadWordFile()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class BadWordProviderFile : BadWordProvider
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBBEC", Offset = "0x8EBBEC")]
		private sealed class <loadFile>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x1CB26E8", Offset = "0x1CB26E8", VA = "0x1CB26E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CC")]
				[Address(RVA = "0x1CB2730", Offset = "0x1CB2730", VA = "0x1CB2730", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1CB2684", Offset = "0x1CB2684", VA = "0x1CB2684")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1CB26B0", Offset = "0x1CB26B0", VA = "0x1CB26B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1CB26B4", Offset = "0x1CB26B4", VA = "0x1CB26B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x1CB26F0", Offset = "0x1CB26F0", VA = "0x1CB26F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC23C", Offset = "0x8EC23C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC23C", Offset = "0x8EC23C")]
		public string FilePathWindows;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC29C", Offset = "0x8EC29C")]
		public string FilePathOSX;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC2D4", Offset = "0x8EC2D4")]
		public string FilePathLinux;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC30C", Offset = "0x8EC30C")]
		public BadWordFile[] Resources;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1A5DCA0", Offset = "0x1A5DCA0", VA = "0x1A5DCA0", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1A5DDB4", Offset = "0x1A5DDB4", VA = "0x1A5DDB4", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1A5DE28", Offset = "0x1A5DE28", VA = "0x1A5DE28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDD30", Offset = "0x8EDD30")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1A5DE84", Offset = "0x1A5DE84", VA = "0x1A5DE84")]
		public BadWordProviderFile()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class BadWordResource : Source
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC344", Offset = "0x8EC344")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC344", Offset = "0x8EC344")]
		public TextAsset Resource;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC3A4", Offset = "0x8EC3A4")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC3DC", Offset = "0x8EC3DC")]
		public int SkipFooterLines;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC414", Offset = "0x8EC414")]
		public char SplitChar;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1A5E168", Offset = "0x1A5E168", VA = "0x1A5E168")]
		public BadWordResource()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class BadWordProviderResource : BadWordProvider
	{
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBBFC", Offset = "0x8EBBFC")]
		private sealed class <loadResource>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordProviderResource <>4__this;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BadWordResource[] <>7__wrap1;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D0")]
				[Address(RVA = "0x1CB2AC8", Offset = "0x1CB2AC8", VA = "0x1CB2AC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D2")]
				[Address(RVA = "0x1CB2B10", Offset = "0x1CB2B10", VA = "0x1CB2B10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x1CB2738", Offset = "0x1CB2738", VA = "0x1CB2738")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x1CB2764", Offset = "0x1CB2764", VA = "0x1CB2764", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x1CB2768", Offset = "0x1CB2768", VA = "0x1CB2768", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1CB2AD0", Offset = "0x1CB2AD0", VA = "0x1CB2AD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC44C", Offset = "0x8EC44C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC44C", Offset = "0x8EC44C")]
		public BadWordResource[] Resources;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1A5DEF4", Offset = "0x1A5DEF4", VA = "0x1A5DEF4", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1A5DF8C", Offset = "0x1A5DF8C", VA = "0x1A5DF8C", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1A5DF20", Offset = "0x1A5DF20", VA = "0x1A5DF20")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDD90", Offset = "0x8EDD90")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1A5E000", Offset = "0x1A5E000", VA = "0x1A5E000")]
		public BadWordProviderResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class BadWordWeb : Source
	{
		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC4AC", Offset = "0x8EC4AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC4AC", Offset = "0x8EC4AC")]
		public string URL;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC50C", Offset = "0x8EC50C")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC544", Offset = "0x8EC544")]
		public int SkipFooterLines;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC57C", Offset = "0x8EC57C")]
		public char SplitChar;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1A5E178", Offset = "0x1A5E178", VA = "0x1A5E178")]
		public BadWordWeb()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class BadWordProviderWeb : BadWordProvider
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBC0C", Offset = "0x8EBC0C")]
		private sealed class <loadWeb>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordProviderWeb <>4__this;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BadWordWeb[] <>7__wrap1;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private BadWordWeb <res>5__4;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWWwrapper <www>5__5;

			[Token(Token = "0x1700008E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0x1CB3220", Offset = "0x1CB3220", VA = "0x1CB3220", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x1CB3268", Offset = "0x1CB3268", VA = "0x1CB3268", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x1CB2B18", Offset = "0x1CB2B18", VA = "0x1CB2B18")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1CB2B44", Offset = "0x1CB2B44", VA = "0x1CB2B44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1CB2B48", Offset = "0x1CB2B48", VA = "0x1CB2B48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1CB3228", Offset = "0x1CB3228", VA = "0x1CB3228", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC5B4", Offset = "0x8EC5B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC5B4", Offset = "0x8EC5B4")]
		public string MainURL;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC614", Offset = "0x8EC614")]
		public BadWordWeb[] Resources;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1A5E004", Offset = "0x1A5E004", VA = "0x1A5E004", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1A5E09C", Offset = "0x1A5E09C", VA = "0x1A5E09C", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1A5E030", Offset = "0x1A5E030", VA = "0x1A5E030")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDDF0", Offset = "0x8EDDF0")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1A5E110", Offset = "0x1A5E110", VA = "0x1A5E110")]
		public BadWordProviderWeb()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public abstract class DomainProvider : Provider
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> domainsRegex;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, List<Regex>> debugDomainsRegex;

		[Token(Token = "0x40002B1")]
		private const string domainRegexStart = "\\b{0,1}((ht|f)tp(s?)\\:\\/\\/)?[\\w\\-\\.\\@]*[\\.]";

		[Token(Token = "0x40002B2")]
		private const string domainRegexEnd = "(:(0-9)*)?(\\/|\\b)([a-zA-Z0-9\\-\\.\\?\\!\\,\\=\\'\\/\\&\\%#_]*)?\\b";

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected List<Domains> domains;

		[Token(Token = "0x17000046")]
		public Dictionary<string, Regex> DomainsRegex
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1AC856C", Offset = "0x1AC856C", VA = "0x1AC856C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1AC8574", Offset = "0x1AC8574", VA = "0x1AC8574")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1AC857C", Offset = "0x1AC857C", VA = "0x1AC857C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x1AC8584", Offset = "0x1AC8584", VA = "0x1AC8584")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1AC858C", Offset = "0x1AC858C", VA = "0x1AC858C", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1AC8F88", Offset = "0x1AC8F88", VA = "0x1AC8F88")]
		protected DomainProvider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class DomainFile : Source
	{
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC64C", Offset = "0x8EC64C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC64C", Offset = "0x8EC64C")]
		public string File;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC6AC", Offset = "0x8EC6AC")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC6E4", Offset = "0x8EC6E4")]
		public int SkipFooterLines;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC71C", Offset = "0x8EC71C")]
		public char SplitChar;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1AC1618", Offset = "0x1AC1618", VA = "0x1AC1618")]
		public DomainFile()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class DomainProviderFile : DomainProvider
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBC1C", Offset = "0x8EBC1C")]
		private sealed class <loadFile>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DC")]
				[Address(RVA = "0x20AFFF4", Offset = "0x20AFFF4", VA = "0x20AFFF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DE")]
				[Address(RVA = "0x20B003C", Offset = "0x20B003C", VA = "0x20B003C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x20AFF90", Offset = "0x20AFF90", VA = "0x20AFF90")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x20AFFBC", Offset = "0x20AFFBC", VA = "0x20AFFBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x20AFFC0", Offset = "0x20AFFC0", VA = "0x20AFFC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x20AFFFC", Offset = "0x20AFFFC", VA = "0x20AFFFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC754", Offset = "0x8EC754")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC754", Offset = "0x8EC754")]
		public string FilePathWindows;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC7B4", Offset = "0x8EC7B4")]
		public string FilePathOSX;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC7EC", Offset = "0x8EC7EC")]
		public string FilePathLinux;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC824", Offset = "0x8EC824")]
		public DomainFile[] Resources;

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1AC90AC", Offset = "0x1AC90AC", VA = "0x1AC90AC", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1AC926C", Offset = "0x1AC926C", VA = "0x1AC926C", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1AC92E0", Offset = "0x1AC92E0", VA = "0x1AC92E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDE50", Offset = "0x8EDE50")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1AC933C", Offset = "0x1AC933C", VA = "0x1AC933C")]
		public DomainProviderFile()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class DomainResource : Source
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC85C", Offset = "0x8EC85C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC85C", Offset = "0x8EC85C")]
		public TextAsset Resource;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC8BC", Offset = "0x8EC8BC")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC8F4", Offset = "0x8EC8F4")]
		public int SkipFooterLines;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC92C", Offset = "0x8EC92C")]
		public char SplitChar;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1AC9620", Offset = "0x1AC9620", VA = "0x1AC9620")]
		public DomainResource()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class DomainProviderResource : DomainProvider
	{
		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBC2C", Offset = "0x8EBC2C")]
		private sealed class <loadResource>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainProviderResource <>4__this;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DomainResource[] <>7__wrap1;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x20B03D8", Offset = "0x20B03D8", VA = "0x20B03D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x20B0420", Offset = "0x20B0420", VA = "0x20B0420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x20B0044", Offset = "0x20B0044", VA = "0x20B0044")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x20B0070", Offset = "0x20B0070", VA = "0x20B0070", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x20B0074", Offset = "0x20B0074", VA = "0x20B0074", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x20B03E0", Offset = "0x20B03E0", VA = "0x20B03E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC964", Offset = "0x8EC964")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC964", Offset = "0x8EC964")]
		public DomainResource[] Resources;

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1AC93AC", Offset = "0x1AC93AC", VA = "0x1AC93AC", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1AC9444", Offset = "0x1AC9444", VA = "0x1AC9444", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1AC93D8", Offset = "0x1AC93D8", VA = "0x1AC93D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDEB0", Offset = "0x8EDEB0")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1AC94B8", Offset = "0x1AC94B8", VA = "0x1AC94B8")]
		public DomainProviderResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class DomainWeb : Source
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8EC9C4", Offset = "0x8EC9C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8EC9C4", Offset = "0x8EC9C4")]
		public string URL;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECA24", Offset = "0x8ECA24")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECA5C", Offset = "0x8ECA5C")]
		public int SkipFooterLines;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECA94", Offset = "0x8ECA94")]
		public char SplitChar;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1AC9630", Offset = "0x1AC9630", VA = "0x1AC9630")]
		public DomainWeb()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class DomainProviderWeb : DomainProvider
	{
		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBC3C", Offset = "0x8EBC3C")]
		private sealed class <loadWeb>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainProviderWeb <>4__this;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DomainWeb[] <>7__wrap1;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private DomainWeb <res>5__4;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWWwrapper <www>5__5;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E8")]
				[Address(RVA = "0x20B0B40", Offset = "0x20B0B40", VA = "0x20B0B40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x20B0B88", Offset = "0x20B0B88", VA = "0x20B0B88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x20B0428", Offset = "0x20B0428", VA = "0x20B0428")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x20B0454", Offset = "0x20B0454", VA = "0x20B0454", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x20B0458", Offset = "0x20B0458", VA = "0x20B0458", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x20B0B48", Offset = "0x20B0B48", VA = "0x20B0B48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8ECACC", Offset = "0x8ECACC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECACC", Offset = "0x8ECACC")]
		public string MainURL;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECB2C", Offset = "0x8ECB2C")]
		public DomainWeb[] Resources;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1AC94BC", Offset = "0x1AC94BC", VA = "0x1AC94BC", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1AC9554", Offset = "0x1AC9554", VA = "0x1AC9554", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1AC94E8", Offset = "0x1AC94E8", VA = "0x1AC94E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EDF10", Offset = "0x8EDF10")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1AC95C8", Offset = "0x1AC95C8", VA = "0x1AC95C8")]
		public DomainProviderWeb()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class Provider : MonoBehaviour
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECB64", Offset = "0x8ECB64")]
		public string Name;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8ECB9C", Offset = "0x8ECB9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECB9C", Offset = "0x8ECB9C")]
		public RegexOptions RegexOption1;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECBFC", Offset = "0x8ECBFC")]
		public RegexOptions RegexOption2;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECC34", Offset = "0x8ECC34")]
		public RegexOptions RegexOption3;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECC6C", Offset = "0x8ECC6C")]
		public RegexOptions RegexOption4;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECCA4", Offset = "0x8ECCA4")]
		public RegexOptions RegexOption5;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool ready;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static bool loggedUnsupportedPlatform;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Source> sources;

		[Token(Token = "0x17000048")]
		public bool Ready
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1CA5330", Offset = "0x1CA5330", VA = "0x1CA5330")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x1CA5338", Offset = "0x1CA5338", VA = "0x1CA5338")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public List<Source> Sources
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1CA5344", Offset = "0x1CA5344", VA = "0x1CA5344")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1CA534C", Offset = "0x1CA534C", VA = "0x1CA534C")]
			protected set
			{
			}
		}

		[Token(Token = "0x600045E")]
		public abstract void Load();

		[Token(Token = "0x600045F")]
		public abstract void Save();

		[Token(Token = "0x6000460")]
		protected abstract void init();

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1CA5354", Offset = "0x1CA5354", VA = "0x1CA5354")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1CA5360", Offset = "0x1CA5360", VA = "0x1CA5360")]
		protected void logNoResourcesAdded()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1CA554C", Offset = "0x1CA554C", VA = "0x1CA554C")]
		protected Provider()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public static class Constants
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string ASSET_NAME;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string ASSET_VERSION;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ASSET_BUILD;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly string ASSET_AUTHOR;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly string ASSET_AUTHOR_URL;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly string ASSET_URL;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly string ASSET_CONTACT;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly Guid ASSET_UID;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly string PREFAB_PATH;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly bool DEBUG_BADWORDS;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public static readonly bool DEBUG_DOMAINS;
	}
	[Token(Token = "0x2000074")]
	public static class Helper
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex lineEndingsRegex;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Random rd;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1ACA1C0", Offset = "0x1ACA1C0", VA = "0x1ACA1C0")]
		public static bool WindowsPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1ACA1F8", Offset = "0x1ACA1F8", VA = "0x1ACA1F8")]
		public static bool OSXPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1ACA228", Offset = "0x1ACA228", VA = "0x1ACA228")]
		public static bool LinuxPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1AC91BC", Offset = "0x1AC91BC", VA = "0x1AC91BC")]
		public static bool SupportedPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1ACA248", Offset = "0x1ACA248", VA = "0x1ACA248")]
		public static string ValidatePath(string path)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1ACA2EC", Offset = "0x1ACA2EC", VA = "0x1ACA2EC")]
		public static List<string> SplitStringToLines(string text, int skipHeaderLines = 0, int skipFooterLines = 0, char splitChar = '#')
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1AC733C", Offset = "0x1AC733C", VA = "0x1AC733C")]
		public static string CreateReplaceString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		public static void AddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1ACA5A4", Offset = "0x1ACA5A4", VA = "0x1ACA5A4")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}
	}
}
namespace CodeStage.AntiCheat.Utils
{
	[Token(Token = "0x2000075")]
	internal class xxHash
	{
		[Token(Token = "0x40002DF")]
		private const uint PRIME32_1 = 2654435761u;

		[Token(Token = "0x40002E0")]
		private const uint PRIME32_2 = 2246822519u;

		[Token(Token = "0x40002E1")]
		private const uint PRIME32_3 = 3266489917u;

		[Token(Token = "0x40002E2")]
		private const uint PRIME32_4 = 668265263u;

		[Token(Token = "0x40002E3")]
		private const uint PRIME32_5 = 374761393u;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1CB1DD4", Offset = "0x1CB1DD4", VA = "0x1CB1DD4")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return default(uint);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1CB2194", Offset = "0x1CB2194", VA = "0x1CB2194")]
		public xxHash()
		{
		}
	}
}
namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	[Token(Token = "0x2000076")]
	public struct ObscuredBool : IEquatable<ObscuredBool>
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private byte currentCryptoKey;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool fakeValue;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		[SerializeField]
		private bool fakeValueChanged;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1D341D4", Offset = "0x1D341D4", VA = "0x1D341D4")]
		private ObscuredBool(int value)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1D3425C", Offset = "0x1D3425C", VA = "0x1D3425C")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1D342C4", Offset = "0x1D342C4", VA = "0x1D342C4")]
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1D34328", Offset = "0x1D34328", VA = "0x1D34328")]
		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1D343BC", Offset = "0x1D343BC", VA = "0x1D343BC")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1D34420", Offset = "0x1D34420", VA = "0x1D34420")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1D344AC", Offset = "0x1D344AC", VA = "0x1D344AC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1D34694", Offset = "0x1D34694", VA = "0x1D34694")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1D3472C", Offset = "0x1D3472C", VA = "0x1D3472C")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1D34750", Offset = "0x1D34750", VA = "0x1D34750")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1D34578", Offset = "0x1D34578", VA = "0x1D34578")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1D347F8", Offset = "0x1D347F8", VA = "0x1D347F8")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1D348A0", Offset = "0x1D348A0", VA = "0x1D348A0")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1D348CC", Offset = "0x1D348CC", VA = "0x1D348CC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1D34958", Offset = "0x1D34958", VA = "0x1D34958", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1D34A08", Offset = "0x1D34A08", VA = "0x1D34A08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1D34A38", Offset = "0x1D34A38", VA = "0x1D34A38", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public struct ObscuredByte : IEquatable<ObscuredByte>, IFormattable
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte currentCryptoKey;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte hiddenValue;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private byte fakeValue;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private bool inited;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1D34AB8", Offset = "0x1D34AB8", VA = "0x1D34AB8")]
		private ObscuredByte(byte value)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1D34B3C", Offset = "0x1D34B3C", VA = "0x1D34B3C")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1D34BA4", Offset = "0x1D34BA4", VA = "0x1D34BA4")]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1D34C08", Offset = "0x1D34C08", VA = "0x1D34C08")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1D34C88", Offset = "0x1D34C88", VA = "0x1D34C88")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1D34E8C", Offset = "0x1D34E8C", VA = "0x1D34E8C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1D34F24", Offset = "0x1D34F24", VA = "0x1D34F24")]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1D34F48", Offset = "0x1D34F48", VA = "0x1D34F48")]
		public void SetEncrypted(byte encrypted)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1D34D54", Offset = "0x1D34D54", VA = "0x1D34D54")]
		private byte InternalDecrypt()
		{
			return default(byte);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1D34F84", Offset = "0x1D34F84", VA = "0x1D34F84")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1D35010", Offset = "0x1D35010", VA = "0x1D35010")]
		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1D35034", Offset = "0x1D35034", VA = "0x1D35034")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1D350CC", Offset = "0x1D350CC", VA = "0x1D350CC")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1D35164", Offset = "0x1D35164", VA = "0x1D35164", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1D351EC", Offset = "0x1D351EC", VA = "0x1D351EC", Slot = "4")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1D35298", Offset = "0x1D35298", VA = "0x1D35298", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1D352C4", Offset = "0x1D352C4", VA = "0x1D352C4")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1D352F8", Offset = "0x1D352F8", VA = "0x1D352F8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1D35324", Offset = "0x1D35324", VA = "0x1D35324")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1D35358", Offset = "0x1D35358", VA = "0x1D35358", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public struct ObscuredChar : IEquatable<ObscuredChar>
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static char cryptoKey;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private char currentCryptoKey;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private char hiddenValue;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private char fakeValue;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1D353EC", Offset = "0x1D353EC", VA = "0x1D353EC")]
		private ObscuredChar(char value)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1D35474", Offset = "0x1D35474", VA = "0x1D35474")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1D354DC", Offset = "0x1D354DC", VA = "0x1D354DC")]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1D35540", Offset = "0x1D35540", VA = "0x1D35540")]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1D355C0", Offset = "0x1D355C0", VA = "0x1D355C0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1D357C8", Offset = "0x1D357C8", VA = "0x1D357C8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1D35860", Offset = "0x1D35860", VA = "0x1D35860")]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1D35884", Offset = "0x1D35884", VA = "0x1D35884")]
		public void SetEncrypted(char encrypted)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1D3568C", Offset = "0x1D3568C", VA = "0x1D3568C")]
		private char InternalDecrypt()
		{
			return default(char);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1D358C0", Offset = "0x1D358C0", VA = "0x1D358C0")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1D3594C", Offset = "0x1D3594C", VA = "0x1D3594C")]
		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1D35970", Offset = "0x1D35970", VA = "0x1D35970")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1D35A08", Offset = "0x1D35A08", VA = "0x1D35A08")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1D35AA0", Offset = "0x1D35AA0", VA = "0x1D35AA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1D35B28", Offset = "0x1D35B28", VA = "0x1D35B28", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1D35BD0", Offset = "0x1D35BD0", VA = "0x1D35BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1D35BFC", Offset = "0x1D35BFC", VA = "0x1D35BFC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1D35C30", Offset = "0x1D35C30", VA = "0x1D35C30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x20000C2")]
		private struct DecimalLongBytesUnion
		{
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public decimal d;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l1;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long l2;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte b5;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte b6;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte b7;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte b8;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte b9;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte b10;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public byte b11;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			public byte b12;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public byte b13;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public byte b14;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public byte b15;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public byte b16;
		}

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long currentCryptoKey;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte[] hiddenValue;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private decimal fakeValue;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool inited;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1D36898", Offset = "0x1D36898", VA = "0x1D36898")]
		private ObscuredDecimal(byte[] value)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1D3691C", Offset = "0x1D3691C", VA = "0x1D3691C")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1D36984", Offset = "0x1D36984", VA = "0x1D36984")]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1D36A00", Offset = "0x1D36A00", VA = "0x1D36A00")]
		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1D36A0C", Offset = "0x1D36A0C", VA = "0x1D36A0C")]
		private static byte[] InternalEncrypt(decimal value)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1D36A80", Offset = "0x1D36A80", VA = "0x1D36A80")]
		private static byte[] InternalEncrypt(decimal value, long key)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1D36C30", Offset = "0x1D36C30", VA = "0x1D36C30")]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1D36CAC", Offset = "0x1D36CAC", VA = "0x1D36CAC")]
		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1D36CB8", Offset = "0x1D36CB8", VA = "0x1D36CB8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1D37014", Offset = "0x1D37014", VA = "0x1D37014")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1D370B4", Offset = "0x1D370B4", VA = "0x1D370B4")]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1D371AC", Offset = "0x1D371AC", VA = "0x1D371AC")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1D36D88", Offset = "0x1D36D88", VA = "0x1D36D88")]
		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1D37338", Offset = "0x1D37338", VA = "0x1D37338")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1D373F4", Offset = "0x1D373F4", VA = "0x1D373F4")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1D373F8", Offset = "0x1D373F8", VA = "0x1D373F8")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1D37530", Offset = "0x1D37530", VA = "0x1D37530")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1D37634", Offset = "0x1D37634", VA = "0x1D37634")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1D37738", Offset = "0x1D37738", VA = "0x1D37738", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1D37764", Offset = "0x1D37764", VA = "0x1D37764")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1D377A0", Offset = "0x1D377A0", VA = "0x1D377A0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1D377DC", Offset = "0x1D377DC", VA = "0x1D377DC", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1D37820", Offset = "0x1D37820", VA = "0x1D37820", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1D378BC", Offset = "0x1D378BC", VA = "0x1D378BC", Slot = "4")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1D37914", Offset = "0x1D37914", VA = "0x1D37914", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x20000C3")]
		private struct DoubleLongBytesUnion
		{
			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double d;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte b5;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte b6;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte b7;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte b8;
		}

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private double fakeValue;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1D37994", Offset = "0x1D37994", VA = "0x1D37994")]
		private ObscuredDouble(byte[] value)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1D37A18", Offset = "0x1D37A18", VA = "0x1D37A18")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1D37A80", Offset = "0x1D37A80", VA = "0x1D37A80")]
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1D37AF8", Offset = "0x1D37AF8", VA = "0x1D37AF8")]
		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1D37B04", Offset = "0x1D37B04", VA = "0x1D37B04")]
		private static byte[] InternalEncrypt(double value)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1D37B70", Offset = "0x1D37B70", VA = "0x1D37B70")]
		private static byte[] InternalEncrypt(double value, long key)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1D37CA0", Offset = "0x1D37CA0", VA = "0x1D37CA0")]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1D37D10", Offset = "0x1D37D10", VA = "0x1D37D10")]
		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1D37D1C", Offset = "0x1D37D1C", VA = "0x1D37D1C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1D37FC0", Offset = "0x1D37FC0", VA = "0x1D37FC0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1D38058", Offset = "0x1D38058", VA = "0x1D38058")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1D3810C", Offset = "0x1D3810C", VA = "0x1D3810C")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1D37DEC", Offset = "0x1D37DEC", VA = "0x1D37DEC")]
		private double InternalDecrypt()
		{
			return default(double);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1D38218", Offset = "0x1D38218", VA = "0x1D38218")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1D382B8", Offset = "0x1D382B8", VA = "0x1D382B8")]
		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1D382BC", Offset = "0x1D382BC", VA = "0x1D382BC")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1D38364", Offset = "0x1D38364", VA = "0x1D38364")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1D3840C", Offset = "0x1D3840C", VA = "0x1D3840C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1D38438", Offset = "0x1D38438", VA = "0x1D38438")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1D3846C", Offset = "0x1D3846C", VA = "0x1D3846C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1D384A0", Offset = "0x1D384A0", VA = "0x1D384A0", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1D384E4", Offset = "0x1D384E4", VA = "0x1D384E4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1D38578", Offset = "0x1D38578", VA = "0x1D38578", Slot = "4")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1D385B8", Offset = "0x1D385B8", VA = "0x1D385B8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
	{
		[StructLayout(2)]
		[Token(Token = "0x20000C4")]
		private struct FloatIntBytesUnion
		{
			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;
		}

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float fakeValue;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1D38638", Offset = "0x1D38638", VA = "0x1D38638")]
		private ObscuredFloat(byte[] value)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1D386C0", Offset = "0x1D386C0", VA = "0x1D386C0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1D38728", Offset = "0x1D38728", VA = "0x1D38728")]
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1D387A0", Offset = "0x1D387A0", VA = "0x1D387A0")]
		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1D387AC", Offset = "0x1D387AC", VA = "0x1D387AC")]
		private static byte[] InternalEncrypt(float value)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1D38818", Offset = "0x1D38818", VA = "0x1D38818")]
		private static byte[] InternalEncrypt(float value, int key)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1D38908", Offset = "0x1D38908", VA = "0x1D38908")]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1D38978", Offset = "0x1D38978", VA = "0x1D38978")]
		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1D38984", Offset = "0x1D38984", VA = "0x1D38984")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1D38BE8", Offset = "0x1D38BE8", VA = "0x1D38BE8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1D38C80", Offset = "0x1D38C80", VA = "0x1D38C80")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1D38CF4", Offset = "0x1D38CF4", VA = "0x1D38CF4")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1D38A54", Offset = "0x1D38A54", VA = "0x1D38A54")]
		private float InternalDecrypt()
		{
			return default(float);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1D38DC0", Offset = "0x1D38DC0", VA = "0x1D38DC0")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1D3752C", Offset = "0x1D3752C", VA = "0x1D3752C")]
		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1D38E68", Offset = "0x1D38E68", VA = "0x1D38E68")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1D38F18", Offset = "0x1D38F18", VA = "0x1D38F18")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1D38FC8", Offset = "0x1D38FC8", VA = "0x1D38FC8")]
		public float getValue()
		{
			return default(float);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1D38FCC", Offset = "0x1D38FCC", VA = "0x1D38FCC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1D39068", Offset = "0x1D39068", VA = "0x1D39068", Slot = "4")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1D390B0", Offset = "0x1D390B0", VA = "0x1D390B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1D390DC", Offset = "0x1D390DC", VA = "0x1D390DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1D39108", Offset = "0x1D39108", VA = "0x1D39108")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1D3913C", Offset = "0x1D3913C", VA = "0x1D3913C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1D39170", Offset = "0x1D39170", VA = "0x1D39170", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int fakeValue;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1D39208", Offset = "0x1D39208", VA = "0x1D39208")]
		private ObscuredInt(int value)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1D3928C", Offset = "0x1D3928C", VA = "0x1D3928C")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1D392F4", Offset = "0x1D392F4", VA = "0x1D392F4")]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1D39358", Offset = "0x1D39358", VA = "0x1D39358")]
		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1D393D4", Offset = "0x1D393D4", VA = "0x1D393D4")]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1D39438", Offset = "0x1D39438", VA = "0x1D39438")]
		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1D394B4", Offset = "0x1D394B4", VA = "0x1D394B4")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1D396B4", Offset = "0x1D396B4", VA = "0x1D396B4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1D39750", Offset = "0x1D39750", VA = "0x1D39750")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1D39774", Offset = "0x1D39774", VA = "0x1D39774")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1D39580", Offset = "0x1D39580", VA = "0x1D39580")]
		private int InternalDecrypt()
		{
			return default(int);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1D397B0", Offset = "0x1D397B0", VA = "0x1D397B0")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1D3983C", Offset = "0x1D3983C", VA = "0x1D3983C")]
		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1D39860", Offset = "0x1D39860", VA = "0x1D39860")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1D39964", Offset = "0x1D39964", VA = "0x1D39964")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1D399FC", Offset = "0x1D399FC", VA = "0x1D399FC")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1D39A94", Offset = "0x1D39A94", VA = "0x1D39A94")]
		public int getValue()
		{
			return default(int);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1D39A98", Offset = "0x1D39A98", VA = "0x1D39A98", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1D39B20", Offset = "0x1D39B20", VA = "0x1D39B20", Slot = "4")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1D39BC8", Offset = "0x1D39BC8", VA = "0x1D39BC8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1D39BF4", Offset = "0x1D39BF4", VA = "0x1D39BF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1D39C20", Offset = "0x1D39C20", VA = "0x1D39C20")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1D39C54", Offset = "0x1D39C54", VA = "0x1D39C54")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1D39C88", Offset = "0x1D39C88", VA = "0x1D39C88", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public struct ObscuredLong : IEquatable<ObscuredLong>, IFormattable
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private long fakeValue;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1D39D20", Offset = "0x1D39D20", VA = "0x1D39D20")]
		private ObscuredLong(long value)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1D39DA4", Offset = "0x1D39DA4", VA = "0x1D39DA4")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1D39E0C", Offset = "0x1D39E0C", VA = "0x1D39E0C")]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1D39EEC", Offset = "0x1D39EEC", VA = "0x1D39EEC")]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1D39E70", Offset = "0x1D39E70", VA = "0x1D39E70")]
		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1D39F50", Offset = "0x1D39F50", VA = "0x1D39F50")]
		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1D39FCC", Offset = "0x1D39FCC", VA = "0x1D39FCC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1D3A1CC", Offset = "0x1D3A1CC", VA = "0x1D3A1CC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1D3A264", Offset = "0x1D3A264", VA = "0x1D3A264")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1D3A288", Offset = "0x1D3A288", VA = "0x1D3A288")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1D3A098", Offset = "0x1D3A098", VA = "0x1D3A098")]
		private long InternalDecrypt()
		{
			return default(long);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1D3A2C4", Offset = "0x1D3A2C4", VA = "0x1D3A2C4")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1D3A364", Offset = "0x1D3A364", VA = "0x1D3A364")]
		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1D3A368", Offset = "0x1D3A368", VA = "0x1D3A368")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1D3A408", Offset = "0x1D3A408", VA = "0x1D3A408")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1D3A4A8", Offset = "0x1D3A4A8", VA = "0x1D3A4A8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1D3A53C", Offset = "0x1D3A53C", VA = "0x1D3A53C", Slot = "4")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1D3A5E4", Offset = "0x1D3A5E4", VA = "0x1D3A5E4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1D3A610", Offset = "0x1D3A610", VA = "0x1D3A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1D3A63C", Offset = "0x1D3A63C", VA = "0x1D3A63C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1D3A670", Offset = "0x1D3A670", VA = "0x1D3A670")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1D3A6A4", Offset = "0x1D3A6A4", VA = "0x1D3A6A4", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	public static class ObscuredPrefs
	{
		[Token(Token = "0x20000C5")]
		private enum DataType : byte
		{
			[Token(Token = "0x40004CD")]
			Int = 5,
			[Token(Token = "0x40004CE")]
			UInt = 10,
			[Token(Token = "0x40004CF")]
			String = 15,
			[Token(Token = "0x40004D0")]
			Float = 20,
			[Token(Token = "0x40004D1")]
			Double = 25,
			[Token(Token = "0x40004D2")]
			Long = 30,
			[Token(Token = "0x40004D3")]
			Bool = 35,
			[Token(Token = "0x40004D4")]
			ByteArray = 40,
			[Token(Token = "0x40004D5")]
			Vector2 = 45,
			[Token(Token = "0x40004D6")]
			Vector3 = 50,
			[Token(Token = "0x40004D7")]
			Quaternion = 55,
			[Token(Token = "0x40004D8")]
			Color = 60,
			[Token(Token = "0x40004D9")]
			Rect = 65
		}

		[Token(Token = "0x20000C6")]
		public enum DeviceLockLevel : byte
		{
			[Token(Token = "0x40004DB")]
			None,
			[Token(Token = "0x40004DC")]
			Soft,
			[Token(Token = "0x40004DD")]
			Strict
		}

		[Token(Token = "0x400030D")]
		private const byte VERSION = 2;

		[Token(Token = "0x400030E")]
		private const string RAW_NOT_FOUND = "{not_found}";

		[Token(Token = "0x400030F")]
		private const string DATA_SEPARATOR = "|";

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string encryptionKey;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool foreignSavesReported;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string deviceId;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static uint deviceIdHash;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action onAlterationDetected;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static bool preservePlayerPrefs;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action onPossibleForeignSavesDetected;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static DeviceLockLevel lockToDevice;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public static bool readForeignSaves;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public static bool emergencyMode;

		[Token(Token = "0x400031A")]
		private const char DEPRECATED_RAW_SEPARATOR = ':';

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string deprecatedDeviceId;

		[Token(Token = "0x1700004A")]
		public static string DeviceId
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x1D3DB3C", Offset = "0x1D3DB3C", VA = "0x1D3DB3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x1D3DC64", Offset = "0x1D3DC64", VA = "0x1D3DC64")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8EEBE0", Offset = "0x8EEBE0")]
		internal static string DeviceID
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x1D3DDA0", Offset = "0x1D3DDA0", VA = "0x1D3DDA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x1D3DE60", Offset = "0x1D3DE60", VA = "0x1D3DE60")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1D3DEE0", Offset = "0x1D3DEE0", VA = "0x1D3DEE0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700004D")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1D42E58", Offset = "0x1D42E58", VA = "0x1D42E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1D3DF9C", Offset = "0x1D3DF9C", VA = "0x1D3DF9C")]
		public static void ForceLockToDeviceInit()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1D3E0A0", Offset = "0x1D3E0A0", VA = "0x1D3E0A0")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1D3D390", Offset = "0x1D3D390", VA = "0x1D3D390")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1D3E2E0", Offset = "0x1D3E2E0", VA = "0x1D3E2E0")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1D3D534", Offset = "0x1D3D534", VA = "0x1D3D534")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1D3E22C", Offset = "0x1D3E22C", VA = "0x1D3E22C")]
		private static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1D3E448", Offset = "0x1D3E448", VA = "0x1D3E448")]
		private static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1D3F22C", Offset = "0x1D3F22C", VA = "0x1D3F22C")]
		public static void SetUInt(string key, uint value)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1D3F36C", Offset = "0x1D3F36C", VA = "0x1D3F36C")]
		public static uint GetUInt(string key)
		{
			return default(uint);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1D3F3D0", Offset = "0x1D3F3D0", VA = "0x1D3F3D0")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1D3F2B8", Offset = "0x1D3F2B8", VA = "0x1D3F2B8")]
		private static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1D3F4AC", Offset = "0x1D3F4AC", VA = "0x1D3F4AC")]
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1D3D4A8", Offset = "0x1D3D4A8", VA = "0x1D3D4A8")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1D3F754", Offset = "0x1D3F754", VA = "0x1D3F754")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1D3D848", Offset = "0x1D3D848", VA = "0x1D3D848")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1D3F620", Offset = "0x1D3F620", VA = "0x1D3F620")]
		public static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1D3F7CC", Offset = "0x1D3F7CC", VA = "0x1D3F7CC")]
		public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1D3D41C", Offset = "0x1D3D41C", VA = "0x1D3D41C")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1D3FA5C", Offset = "0x1D3FA5C", VA = "0x1D3FA5C")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1D3D6BC", Offset = "0x1D3D6BC", VA = "0x1D3D6BC")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1D3F9A8", Offset = "0x1D3F9A8", VA = "0x1D3F9A8")]
		private static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1D3FAC0", Offset = "0x1D3FAC0", VA = "0x1D3FAC0")]
		private static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1D3FC3C", Offset = "0x1D3FC3C", VA = "0x1D3FC3C")]
		public static void SetDouble(string key, double value)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1D3FD7C", Offset = "0x1D3FD7C", VA = "0x1D3FD7C")]
		public static double GetDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1D3FDE0", Offset = "0x1D3FDE0", VA = "0x1D3FDE0")]
		public static double GetDouble(string key, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1D3FCC8", Offset = "0x1D3FCC8", VA = "0x1D3FCC8")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1D3FEC8", Offset = "0x1D3FEC8", VA = "0x1D3FEC8")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1D40070", Offset = "0x1D40070", VA = "0x1D40070")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1D401B0", Offset = "0x1D401B0", VA = "0x1D401B0")]
		public static long GetLong(string key)
		{
			return default(long);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1D40214", Offset = "0x1D40214", VA = "0x1D40214")]
		public static long GetLong(string key, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1D400FC", Offset = "0x1D400FC", VA = "0x1D400FC")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1D402F0", Offset = "0x1D402F0", VA = "0x1D402F0")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1D40464", Offset = "0x1D40464", VA = "0x1D40464")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1D405A4", Offset = "0x1D405A4", VA = "0x1D405A4")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1D40608", Offset = "0x1D40608", VA = "0x1D40608")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1D404F0", Offset = "0x1D404F0", VA = "0x1D404F0")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1D406E4", Offset = "0x1D406E4", VA = "0x1D406E4")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1D40864", Offset = "0x1D40864", VA = "0x1D40864")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1D40964", Offset = "0x1D40964", VA = "0x1D40964")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1D409CC", Offset = "0x1D409CC", VA = "0x1D409CC")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1D408F0", Offset = "0x1D408F0", VA = "0x1D408F0")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1D40B78", Offset = "0x1D40B78", VA = "0x1D40B78")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1D40AD8", Offset = "0x1D40AD8", VA = "0x1D40AD8")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1D40CF0", Offset = "0x1D40CF0", VA = "0x1D40CF0")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1D40E98", Offset = "0x1D40E98", VA = "0x1D40E98")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1D40F18", Offset = "0x1D40F18", VA = "0x1D40F18")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1D40D84", Offset = "0x1D40D84", VA = "0x1D40D84")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1D41004", Offset = "0x1D41004", VA = "0x1D41004")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1D41248", Offset = "0x1D41248", VA = "0x1D41248")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1D41430", Offset = "0x1D41430", VA = "0x1D41430")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1D414C0", Offset = "0x1D414C0", VA = "0x1D414C0")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1D412EC", Offset = "0x1D412EC", VA = "0x1D412EC")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1D415C4", Offset = "0x1D415C4", VA = "0x1D415C4")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1D41854", Offset = "0x1D41854", VA = "0x1D41854")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1D41A6C", Offset = "0x1D41A6C", VA = "0x1D41A6C")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1D41B04", Offset = "0x1D41B04", VA = "0x1D41B04")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1D41900", Offset = "0x1D41900", VA = "0x1D41900")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1D41C18", Offset = "0x1D41C18", VA = "0x1D41C18")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1D41F00", Offset = "0x1D41F00", VA = "0x1D41F00")]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1D4204C", Offset = "0x1D4204C", VA = "0x1D4204C")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1D420E0", Offset = "0x1D420E0", VA = "0x1D420E0")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1D41F98", Offset = "0x1D41F98", VA = "0x1D41F98")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1D421E4", Offset = "0x1D421E4", VA = "0x1D421E4")]
		public static void SetRect(string key, Rect value)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1D4241C", Offset = "0x1D4241C", VA = "0x1D4241C")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1D424B0", Offset = "0x1D424B0", VA = "0x1D424B0")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1D42290", Offset = "0x1D42290", VA = "0x1D42290")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1D425C4", Offset = "0x1D425C4", VA = "0x1D425C4")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1D428DC", Offset = "0x1D428DC", VA = "0x1D428DC")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1D42954", Offset = "0x1D42954", VA = "0x1D42954")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1D429BC", Offset = "0x1D429BC", VA = "0x1D429BC")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1D3D9D0", Offset = "0x1D3D9D0", VA = "0x1D3D9D0")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1D42A44", Offset = "0x1D42A44", VA = "0x1D42A44")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1D42A4C", Offset = "0x1D42A4C", VA = "0x1D42A4C")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1D3E344", Offset = "0x1D3E344", VA = "0x1D3E344")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1D3E124", Offset = "0x1D3E124", VA = "0x1D3E124")]
		private static string EncryptKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1D3E5BC", Offset = "0x1D3E5BC", VA = "0x1D3E5BC")]
		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1D3ED84", Offset = "0x1D3ED84", VA = "0x1D3ED84")]
		private static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1D3DCE4", Offset = "0x1D3DCE4", VA = "0x1D3DCE4")]
		private static uint CalculateChecksum(string input)
		{
			return default(uint);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1D42CD4", Offset = "0x1D42CD4", VA = "0x1D42CD4")]
		private static void SavesTampered()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1D42D7C", Offset = "0x1D42D7C", VA = "0x1D42D7C")]
		private static void PossibleForeignSavesDetected()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1D3DBFC", Offset = "0x1D3DBFC", VA = "0x1D3DBFC")]
		private static string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1D42BD8", Offset = "0x1D42BD8", VA = "0x1D42BD8")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1D3E8A4", Offset = "0x1D3E8A4", VA = "0x1D3E8A4")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1D42F1C", Offset = "0x1D42F1C", VA = "0x1D42F1C")]
		private static string DeprecatedCalculateChecksum(string input)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public struct ObscuredQuaternion
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public struct RawEncryptedQuaternion
		{
			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int w;
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Quaternion initialFakeValue;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Quaternion fakeValue;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1D43104", Offset = "0x1D43104", VA = "0x1D43104")]
		private ObscuredQuaternion(RawEncryptedQuaternion value)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1D431A0", Offset = "0x1D431A0", VA = "0x1D431A0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1D43208", Offset = "0x1D43208", VA = "0x1D43208")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1D43294", Offset = "0x1D43294", VA = "0x1D43294")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1D43374", Offset = "0x1D43374", VA = "0x1D43374")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1D433E8", Offset = "0x1D433E8", VA = "0x1D433E8")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1D434B8", Offset = "0x1D434B8", VA = "0x1D434B8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1D437A4", Offset = "0x1D437A4", VA = "0x1D437A4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1D43860", Offset = "0x1D43860", VA = "0x1D43860")]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1D43888", Offset = "0x1D43888", VA = "0x1D43888")]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1D435AC", Offset = "0x1D435AC", VA = "0x1D435AC")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1D438CC", Offset = "0x1D438CC", VA = "0x1D438CC")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1D43A28", Offset = "0x1D43A28", VA = "0x1D43A28")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1D43B0C", Offset = "0x1D43B0C", VA = "0x1D43B0C")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1D43B10", Offset = "0x1D43B10", VA = "0x1D43B10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1D43B40", Offset = "0x1D43B40", VA = "0x1D43B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1D43B70", Offset = "0x1D43B70", VA = "0x1D43B70")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static sbyte cryptoKey;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private sbyte currentCryptoKey;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private sbyte hiddenValue;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private sbyte fakeValue;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private bool inited;

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1D43C1C", Offset = "0x1D43C1C", VA = "0x1D43C1C")]
		private ObscuredSByte(sbyte value)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1D43CA0", Offset = "0x1D43CA0", VA = "0x1D43CA0")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1D43D08", Offset = "0x1D43D08", VA = "0x1D43D08")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1D43D6C", Offset = "0x1D43D6C", VA = "0x1D43D6C")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1D43DEC", Offset = "0x1D43DEC", VA = "0x1D43DEC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1D43FF0", Offset = "0x1D43FF0", VA = "0x1D43FF0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1D44088", Offset = "0x1D44088", VA = "0x1D44088")]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1D440AC", Offset = "0x1D440AC", VA = "0x1D440AC")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1D43EB8", Offset = "0x1D43EB8", VA = "0x1D43EB8")]
		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1D440E8", Offset = "0x1D440E8", VA = "0x1D440E8")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1D44174", Offset = "0x1D44174", VA = "0x1D44174")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1D44198", Offset = "0x1D44198", VA = "0x1D44198")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1D44230", Offset = "0x1D44230", VA = "0x1D44230")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1D442C8", Offset = "0x1D442C8", VA = "0x1D442C8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1D44350", Offset = "0x1D44350", VA = "0x1D44350", Slot = "4")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1D443FC", Offset = "0x1D443FC", VA = "0x1D443FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1D44428", Offset = "0x1D44428", VA = "0x1D44428")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1D4445C", Offset = "0x1D4445C", VA = "0x1D4445C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1D44488", Offset = "0x1D44488", VA = "0x1D44488")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1D444BC", Offset = "0x1D444BC", VA = "0x1D444BC", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static short cryptoKey;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private short currentCryptoKey;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private short hiddenValue;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private short fakeValue;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1D44550", Offset = "0x1D44550", VA = "0x1D44550")]
		private ObscuredShort(short value)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1D445D8", Offset = "0x1D445D8", VA = "0x1D445D8")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1D44640", Offset = "0x1D44640", VA = "0x1D44640")]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1D446A4", Offset = "0x1D446A4", VA = "0x1D446A4")]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1D44724", Offset = "0x1D44724", VA = "0x1D44724")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1D4492C", Offset = "0x1D4492C", VA = "0x1D4492C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1D449C4", Offset = "0x1D449C4", VA = "0x1D449C4")]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1D449E8", Offset = "0x1D449E8", VA = "0x1D449E8")]
		public void SetEncrypted(short encrypted)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1D447F0", Offset = "0x1D447F0", VA = "0x1D447F0")]
		private short InternalDecrypt()
		{
			return default(short);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1D3D100", Offset = "0x1D3D100", VA = "0x1D3D100")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1D3D18C", Offset = "0x1D3D18C", VA = "0x1D3D18C")]
		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1D44A24", Offset = "0x1D44A24", VA = "0x1D44A24")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1D44AAC", Offset = "0x1D44AAC", VA = "0x1D44AAC")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1D44B34", Offset = "0x1D44B34", VA = "0x1D44B34", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1D44BBC", Offset = "0x1D44BBC", VA = "0x1D44BBC", Slot = "4")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1D44C64", Offset = "0x1D44C64", VA = "0x1D44C64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1D44C90", Offset = "0x1D44C90", VA = "0x1D44C90")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1D44CC4", Offset = "0x1D44CC4", VA = "0x1D44CC4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1D44CF0", Offset = "0x1D44CF0", VA = "0x1D44CF0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1D44D24", Offset = "0x1D44D24", VA = "0x1D44D24", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public sealed class ObscuredString
	{
		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string cryptoKey;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string currentCryptoKey;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string fakeValue;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1D44DB8", Offset = "0x1D44DB8", VA = "0x1D44DB8")]
		private ObscuredString()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1D44DC0", Offset = "0x1D44DC0", VA = "0x1D44DC0")]
		private ObscuredString(byte[] value)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1D44E50", Offset = "0x1D44E50", VA = "0x1D44E50")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1D44EB8", Offset = "0x1D44EB8", VA = "0x1D44EB8")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1D42A54", Offset = "0x1D42A54", VA = "0x1D42A54")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1D44F30", Offset = "0x1D44F30", VA = "0x1D44F30")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1D45204", Offset = "0x1D45204", VA = "0x1D45204")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1D45320", Offset = "0x1D45320", VA = "0x1D45320")]
		public string GetEncrypted()
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1D4541C", Offset = "0x1D4541C", VA = "0x1D4541C")]
		public void SetEncrypted(string encrypted)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1D45198", Offset = "0x1D45198", VA = "0x1D45198")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1D452AC", Offset = "0x1D452AC", VA = "0x1D452AC")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1D44FF8", Offset = "0x1D44FF8", VA = "0x1D44FF8")]
		private string InternalDecrypt()
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1D3D1B0", Offset = "0x1D3D1B0", VA = "0x1D3D1B0")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1D3D25C", Offset = "0x1D3D25C", VA = "0x1D3D25C")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1D4561C", Offset = "0x1D4561C", VA = "0x1D4561C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1D45538", Offset = "0x1D45538", VA = "0x1D45538")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1D3D2F0", Offset = "0x1D3D2F0", VA = "0x1D3D2F0")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1D456A4", Offset = "0x1D456A4", VA = "0x1D456A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1D45724", Offset = "0x1D45724", VA = "0x1D45724")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1D45830", Offset = "0x1D45830", VA = "0x1D45830")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1D458F8", Offset = "0x1D458F8", VA = "0x1D458F8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1D454AC", Offset = "0x1D454AC", VA = "0x1D454AC")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1D4538C", Offset = "0x1D4538C", VA = "0x1D4538C")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1D45620", Offset = "0x1D45620", VA = "0x1D45620")]
		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public struct ObscuredUInt : IEquatable<ObscuredUInt>, IFormattable
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint cryptoKey;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint currentCryptoKey;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private uint hiddenValue;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private uint fakeValue;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool inited;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1D45980", Offset = "0x1D45980", VA = "0x1D45980")]
		private ObscuredUInt(uint value)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1D45A04", Offset = "0x1D45A04", VA = "0x1D45A04")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1D45A6C", Offset = "0x1D45A6C", VA = "0x1D45A6C")]
		public static uint Encrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1D45B4C", Offset = "0x1D45B4C", VA = "0x1D45B4C")]
		public static uint Decrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1D45AD0", Offset = "0x1D45AD0", VA = "0x1D45AD0")]
		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1D45BB0", Offset = "0x1D45BB0", VA = "0x1D45BB0")]
		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1D45C2C", Offset = "0x1D45C2C", VA = "0x1D45C2C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1D45E2C", Offset = "0x1D45E2C", VA = "0x1D45E2C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1D45EC4", Offset = "0x1D45EC4", VA = "0x1D45EC4")]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1D45EE8", Offset = "0x1D45EE8", VA = "0x1D45EE8")]
		public void SetEncrypted(uint encrypted)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1D45CF8", Offset = "0x1D45CF8", VA = "0x1D45CF8")]
		private uint InternalDecrypt()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1D398D8", Offset = "0x1D398D8", VA = "0x1D398D8")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1D3D36C", Offset = "0x1D3D36C", VA = "0x1D3D36C")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1D45F24", Offset = "0x1D45F24", VA = "0x1D45F24")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1D45F9C", Offset = "0x1D45F9C", VA = "0x1D45F9C")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1D46034", Offset = "0x1D46034", VA = "0x1D46034")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1D460CC", Offset = "0x1D460CC", VA = "0x1D460CC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1D46154", Offset = "0x1D46154", VA = "0x1D46154", Slot = "4")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1D461FC", Offset = "0x1D461FC", VA = "0x1D461FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1D46228", Offset = "0x1D46228", VA = "0x1D46228")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1D4625C", Offset = "0x1D4625C", VA = "0x1D4625C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1D46288", Offset = "0x1D46288", VA = "0x1D46288")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1D462BC", Offset = "0x1D462BC", VA = "0x1D462BC", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public struct ObscuredULong : IEquatable<ObscuredULong>, IFormattable
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ulong cryptoKey;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong currentCryptoKey;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ulong hiddenValue;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong fakeValue;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inited;

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1D46354", Offset = "0x1D46354", VA = "0x1D46354")]
		private ObscuredULong(ulong value)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1D463D8", Offset = "0x1D463D8", VA = "0x1D463D8")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1D46440", Offset = "0x1D46440", VA = "0x1D46440")]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1D46520", Offset = "0x1D46520", VA = "0x1D46520")]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1D464A4", Offset = "0x1D464A4", VA = "0x1D464A4")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1D46584", Offset = "0x1D46584", VA = "0x1D46584")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1D46600", Offset = "0x1D46600", VA = "0x1D46600")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1D46800", Offset = "0x1D46800", VA = "0x1D46800")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1D46898", Offset = "0x1D46898", VA = "0x1D46898")]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1D468BC", Offset = "0x1D468BC", VA = "0x1D468BC")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1D466CC", Offset = "0x1D466CC", VA = "0x1D466CC")]
		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1D468F8", Offset = "0x1D468F8", VA = "0x1D468F8")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1D46998", Offset = "0x1D46998", VA = "0x1D46998")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1D4699C", Offset = "0x1D4699C", VA = "0x1D4699C")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1D46A3C", Offset = "0x1D46A3C", VA = "0x1D46A3C")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1D46ADC", Offset = "0x1D46ADC", VA = "0x1D46ADC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1D46B70", Offset = "0x1D46B70", VA = "0x1D46B70", Slot = "4")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1D46C18", Offset = "0x1D46C18", VA = "0x1D46C18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1D46C44", Offset = "0x1D46C44", VA = "0x1D46C44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1D46C70", Offset = "0x1D46C70", VA = "0x1D46C70")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1D46CA4", Offset = "0x1D46CA4", VA = "0x1D46CA4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1D46CD8", Offset = "0x1D46CD8", VA = "0x1D46CD8", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ushort cryptoKey;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort currentCryptoKey;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort hiddenValue;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private ushort fakeValue;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1CA0AF4", Offset = "0x1CA0AF4", VA = "0x1CA0AF4")]
		private ObscuredUShort(ushort value)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1CA0B7C", Offset = "0x1CA0B7C", VA = "0x1CA0B7C")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1CA0BE4", Offset = "0x1CA0BE4", VA = "0x1CA0BE4")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1CA0C48", Offset = "0x1CA0C48", VA = "0x1CA0C48")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1CA0CC8", Offset = "0x1CA0CC8", VA = "0x1CA0CC8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1CA0ED4", Offset = "0x1CA0ED4", VA = "0x1CA0ED4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1CA0F6C", Offset = "0x1CA0F6C", VA = "0x1CA0F6C")]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1CA0F90", Offset = "0x1CA0F90", VA = "0x1CA0F90")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1CA0D94", Offset = "0x1CA0D94", VA = "0x1CA0D94")]
		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1CA0FD0", Offset = "0x1CA0FD0", VA = "0x1CA0FD0")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1CA1060", Offset = "0x1CA1060", VA = "0x1CA1060")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1CA1084", Offset = "0x1CA1084", VA = "0x1CA1084")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1CA1120", Offset = "0x1CA1120", VA = "0x1CA1120")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1CA11BC", Offset = "0x1CA11BC", VA = "0x1CA11BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1CA1244", Offset = "0x1CA1244", VA = "0x1CA1244", Slot = "4")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1CA12EC", Offset = "0x1CA12EC", VA = "0x1CA12EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1CA1318", Offset = "0x1CA1318", VA = "0x1CA1318")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1CA134C", Offset = "0x1CA134C", VA = "0x1CA134C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1CA1378", Offset = "0x1CA1378", VA = "0x1CA1378")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1CA13AC", Offset = "0x1CA13AC", VA = "0x1CA13AC", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8EB80C", Offset = "0x8EB80C")]
	public struct ObscuredVector2
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public struct RawEncryptedVector2
		{
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;
		}

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector2 initialFakeValue;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector2 hiddenValue;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Vector2 fakeValue;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x1700004E")]
		public float x
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1CA14D4", Offset = "0x1CA14D4", VA = "0x1CA14D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1CA16A8", Offset = "0x1CA16A8", VA = "0x1CA16A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public float y
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x1CA1794", Offset = "0x1CA1794", VA = "0x1CA1794")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1CA18CC", Offset = "0x1CA18CC", VA = "0x1CA18CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float Item
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1CA190C", Offset = "0x1CA190C", VA = "0x1CA190C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1CA1974", Offset = "0x1CA1974", VA = "0x1CA1974")]
			set
			{
			}
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1CA1440", Offset = "0x1CA1440", VA = "0x1CA1440")]
		private ObscuredVector2(RawEncryptedVector2 value)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1CA19DC", Offset = "0x1CA19DC", VA = "0x1CA19DC")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1CA1A44", Offset = "0x1CA1A44", VA = "0x1CA1A44")]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1CA1AB8", Offset = "0x1CA1AB8", VA = "0x1CA1AB8")]
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1CA1B90", Offset = "0x1CA1B90", VA = "0x1CA1B90")]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1CA1BF4", Offset = "0x1CA1BF4", VA = "0x1CA1BF4")]
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1CA1CD0", Offset = "0x1CA1CD0", VA = "0x1CA1CD0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1CA1F78", Offset = "0x1CA1F78", VA = "0x1CA1F78")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1CA2018", Offset = "0x1CA2018", VA = "0x1CA2018")]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1CA203C", Offset = "0x1CA203C", VA = "0x1CA203C")]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1CA1DA8", Offset = "0x1CA1DA8", VA = "0x1CA1DA8")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1CA207C", Offset = "0x1CA207C", VA = "0x1CA207C")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1CA1604", Offset = "0x1CA1604", VA = "0x1CA1604")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1CA16E8", Offset = "0x1CA16E8", VA = "0x1CA16E8")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1CA2174", Offset = "0x1CA2174", VA = "0x1CA2174")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1CA2228", Offset = "0x1CA2228", VA = "0x1CA2228")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1CA222C", Offset = "0x1CA222C", VA = "0x1CA222C")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1CA2244", Offset = "0x1CA2244", VA = "0x1CA2244", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1CA2270", Offset = "0x1CA2270", VA = "0x1CA2270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1CA229C", Offset = "0x1CA229C", VA = "0x1CA229C")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8EB844", Offset = "0x8EB844")]
	public struct ObscuredVector3
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public struct RawEncryptedVector3
		{
			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector3 initialFakeValue;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector3 hiddenValue;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 fakeValue;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x17000051")]
		public float x
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x1CA25BC", Offset = "0x1CA25BC", VA = "0x1CA25BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x1CA2790", Offset = "0x1CA2790", VA = "0x1CA2790")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public float y
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x1CA287C", Offset = "0x1CA287C", VA = "0x1CA287C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x1CA29B4", Offset = "0x1CA29B4", VA = "0x1CA29B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float z
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x1CA29F4", Offset = "0x1CA29F4", VA = "0x1CA29F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1CA2B2C", Offset = "0x1CA2B2C", VA = "0x1CA2B2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float Item
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1CA2B6C", Offset = "0x1CA2B6C", VA = "0x1CA2B6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x1CA2BE0", Offset = "0x1CA2BE0", VA = "0x1CA2BE0")]
			set
			{
			}
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1CA2338", Offset = "0x1CA2338", VA = "0x1CA2338")]
		private ObscuredVector3(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1CA23DC", Offset = "0x1CA23DC", VA = "0x1CA23DC")]
		public Vector3 getValue()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1CA2C54", Offset = "0x1CA2C54", VA = "0x1CA2C54")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1CA2CBC", Offset = "0x1CA2CBC", VA = "0x1CA2CBC")]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1CA2D48", Offset = "0x1CA2D48", VA = "0x1CA2D48")]
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1CA2E4C", Offset = "0x1CA2E4C", VA = "0x1CA2E4C")]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1CA2EC0", Offset = "0x1CA2EC0", VA = "0x1CA2EC0")]
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1CA2FB8", Offset = "0x1CA2FB8", VA = "0x1CA2FB8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1CA30A4", Offset = "0x1CA30A4", VA = "0x1CA30A4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1CA3158", Offset = "0x1CA3158", VA = "0x1CA3158")]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1CA3180", Offset = "0x1CA3180", VA = "0x1CA3180")]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1CA23E0", Offset = "0x1CA23E0", VA = "0x1CA23E0")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1CA31C8", Offset = "0x1CA31C8", VA = "0x1CA31C8")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1CA26EC", Offset = "0x1CA26EC", VA = "0x1CA26EC")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1CA27D0", Offset = "0x1CA27D0", VA = "0x1CA27D0")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1CA32F4", Offset = "0x1CA32F4", VA = "0x1CA32F4")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1CA33C8", Offset = "0x1CA33C8", VA = "0x1CA33C8")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1CA33CC", Offset = "0x1CA33CC", VA = "0x1CA33CC")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1CA3494", Offset = "0x1CA3494", VA = "0x1CA3494")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1CA3550", Offset = "0x1CA3550", VA = "0x1CA3550")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1CA360C", Offset = "0x1CA360C", VA = "0x1CA360C")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1CA36D4", Offset = "0x1CA36D4", VA = "0x1CA36D4")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1CA3790", Offset = "0x1CA3790", VA = "0x1CA3790")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1CA384C", Offset = "0x1CA384C", VA = "0x1CA384C")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1CA38FC", Offset = "0x1CA38FC", VA = "0x1CA38FC")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1CA39B0", Offset = "0x1CA39B0", VA = "0x1CA39B0")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1CA3A64", Offset = "0x1CA3A64", VA = "0x1CA3A64")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1CA3B18", Offset = "0x1CA3B18", VA = "0x1CA3B18")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1CA3B78", Offset = "0x1CA3B78", VA = "0x1CA3B78")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1CA3BC4", Offset = "0x1CA3BC4", VA = "0x1CA3BC4")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1CA3C04", Offset = "0x1CA3C04", VA = "0x1CA3C04")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1CA3C64", Offset = "0x1CA3C64", VA = "0x1CA3C64")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1CA3CB0", Offset = "0x1CA3CB0", VA = "0x1CA3CB0")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1CA3CF0", Offset = "0x1CA3CF0", VA = "0x1CA3CF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1CA3D34", Offset = "0x1CA3D34", VA = "0x1CA3D34", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1CA3D64", Offset = "0x1CA3D64", VA = "0x1CA3D64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1CA3D94", Offset = "0x1CA3D94", VA = "0x1CA3D94")]
		public string ToString(string format)
		{
			return null;
		}
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8EB87C", Offset = "0x8EB87C")]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		[Token(Token = "0x400034C")]
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";

		[Token(Token = "0x400034D")]
		protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x400034E")]
		protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static GameObject detectorsContainer;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECF2C", Offset = "0x8ECF2C")]
		public bool autoStart;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECF64", Offset = "0x8ECF64")]
		public bool keepAlive;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ECF9C", Offset = "0x8ECF9C")]
		public bool autoDispose;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected UnityEvent detectionEvent;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityAction detectionAction;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool detectionEventHasListener;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isRunning;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool started;

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1A471C4", Offset = "0x1A471C4", VA = "0x1A471C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1A472E0", Offset = "0x1A472E0", VA = "0x1A472E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1A47308", Offset = "0x1A47308", VA = "0x1A47308")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1A47320", Offset = "0x1A47320", VA = "0x1A47320")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1A4732C", Offset = "0x1A4732C", VA = "0x1A4732C", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1A47470", Offset = "0x1A47470", VA = "0x1A47470", Slot = "5")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1A47630", Offset = "0x1A47630", VA = "0x1A47630", Slot = "6")]
		protected virtual void DisposeInternal()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1A47694", Offset = "0x1A47694", VA = "0x1A47694", Slot = "7")]
		internal virtual void OnCheatingDetected()
		{
		}

		[Token(Token = "0x600066E")]
		protected abstract void StartDetectionAutomatically();

		[Token(Token = "0x600066F")]
		protected abstract void StopDetectionInternal();

		[Token(Token = "0x6000670")]
		protected abstract void PauseDetector();

		[Token(Token = "0x6000671")]
		protected abstract void ResumeDetector();

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1A476F8", Offset = "0x1A476F8", VA = "0x1A476F8")]
		protected ActDetectorBase()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8EB8B4", Offset = "0x8EB8B4")]
	public class InjectionDetector : ActDetectorBase
	{
		[Token(Token = "0x20000CA")]
		private class AllowedAssembly
		{
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string name;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly int[] hashes;

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x20B0C78", Offset = "0x20B0C78", VA = "0x20B0C78")]
			public AllowedAssembly(string name, int[] hashes)
			{
			}
		}

		[Token(Token = "0x4000358")]
		internal const string COMPONENT_NAME = "Injection Detector";

		[Token(Token = "0x4000359")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		private bool signaturesAreNotGenuine;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AllowedAssembly[] allowedAssemblies;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string[] hexTable;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8ECFF4", Offset = "0x8ECFF4")]
		private static InjectionDetector <Instance>k__BackingField;

		[Token(Token = "0x17000055")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1ACAF48", Offset = "0x1ACAF48", VA = "0x1ACAF48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDF80", Offset = "0x8EDF80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1ACAF94", Offset = "0x1ACAF94", VA = "0x1ACAF94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDF90", Offset = "0x8EDF90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		private static InjectionDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1ACAB98", Offset = "0x1ACAB98", VA = "0x1ACAB98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1ACA7E4", Offset = "0x1ACA7E4", VA = "0x1ACA7E4")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1ACAB6C", Offset = "0x1ACAB6C", VA = "0x1ACAB6C")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1ACAD68", Offset = "0x1ACAD68", VA = "0x1ACAD68")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1ACAE58", Offset = "0x1ACAE58", VA = "0x1ACAE58")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1ACAFE4", Offset = "0x1ACAFE4", VA = "0x1ACAFE4")]
		private InjectionDetector()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1ACAFEC", Offset = "0x1ACAFEC", VA = "0x1ACAFEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1ACB160", Offset = "0x1ACB160", VA = "0x1ACB160", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1ACB254", Offset = "0x1ACB254", VA = "0x1ACB254")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1ACA918", Offset = "0x1ACA918", VA = "0x1ACA918")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1ACB944", Offset = "0x1ACB944", VA = "0x1ACB944", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1ACB94C", Offset = "0x1ACB94C", VA = "0x1ACB94C", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1ACB9F0", Offset = "0x1ACB9F0", VA = "0x1ACB9F0", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1ACBAB8", Offset = "0x1ACBAB8", VA = "0x1ACBAB8", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1ACBB6C", Offset = "0x1ACBB6C", VA = "0x1ACBB6C", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1ACBC50", Offset = "0x1ACBC50", VA = "0x1ACBC50")]
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1ACB8A8", Offset = "0x1ACB8A8", VA = "0x1ACB8A8")]
		private bool FindInjectionInCurrentAssemblies()
		{
			return default(bool);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1ACBC98", Offset = "0x1ACBC98", VA = "0x1ACBC98")]
		private bool AssemblyAllowed(Assembly ass)
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1ACB348", Offset = "0x1ACB348", VA = "0x1ACB348")]
		private void LoadAndParseAllowedAssemblies()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1ACBDA0", Offset = "0x1ACBDA0", VA = "0x1ACBDA0")]
		private int GetAssemblyHash(Assembly ass)
		{
			return default(int);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1ACBE7C", Offset = "0x1ACBE7C", VA = "0x1ACBE7C")]
		private string PublicKeyTokenToString(byte[] bytes)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8EB8EC", Offset = "0x8EB8EC")]
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		[Token(Token = "0x400035F")]
		internal const string COMPONENT_NAME = "Obscured Cheating Detector";

		[Token(Token = "0x4000360")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED004", Offset = "0x8ED004")]
		public float floatEpsilon;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED03C", Offset = "0x8ED03C")]
		public float vector2Epsilon;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED074", Offset = "0x8ED074")]
		public float vector3Epsilon;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED0AC", Offset = "0x8ED0AC")]
		public float quaternionEpsilon;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8ED0E4", Offset = "0x8ED0E4")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;

		[Token(Token = "0x17000057")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1D36368", Offset = "0x1D36368", VA = "0x1D36368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDFA0", Offset = "0x8EDFA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1D363B4", Offset = "0x1D363B4", VA = "0x1D363B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDFB0", Offset = "0x8EDFB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1D35FB8", Offset = "0x1D35FB8", VA = "0x1D35FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		internal static bool IsRunning
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1D34794", Offset = "0x1D34794", VA = "0x1D34794")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1D35CAC", Offset = "0x1D35CAC", VA = "0x1D35CAC")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1D35F8C", Offset = "0x1D35F8C", VA = "0x1D35F8C")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1D36188", Offset = "0x1D36188", VA = "0x1D36188")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1D36278", Offset = "0x1D36278", VA = "0x1D36278")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1D36404", Offset = "0x1D36404", VA = "0x1D36404")]
		private ObscuredCheatingDetector()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1D36418", Offset = "0x1D36418", VA = "0x1D36418")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1D3658C", Offset = "0x1D3658C", VA = "0x1D3658C", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1D36680", Offset = "0x1D36680", VA = "0x1D36680")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1D35DE0", Offset = "0x1D35DE0", VA = "0x1D35DE0")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1D36774", Offset = "0x1D36774", VA = "0x1D36774", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1D3677C", Offset = "0x1D3677C", VA = "0x1D3677C", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1D36784", Offset = "0x1D36784", VA = "0x1D36784", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1D367A0", Offset = "0x1D367A0", VA = "0x1D367A0", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1D367B4", Offset = "0x1D367B4", VA = "0x1D367B4", Slot = "6")]
		protected override void DisposeInternal()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8EB924", Offset = "0x8EB924")]
	public class SpeedHackDetector : ActDetectorBase
	{
		[Token(Token = "0x4000367")]
		internal const string COMPONENT_NAME = "Speed Hack Detector";

		[Token(Token = "0x4000368")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";

		[Token(Token = "0x4000369")]
		private const long TICKS_PER_SECOND = 10000000L;

		[Token(Token = "0x400036A")]
		private const int THRESHOLD = 5000000;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED0F4", Offset = "0x8ED0F4")]
		public float interval;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED12C", Offset = "0x8ED12C")]
		public byte maxFalsePositives;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED164", Offset = "0x8ED164")]
		public int coolDown;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte currentFalsePositives;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int currentCooldownShots;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long ticksOnStart;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long vulnerableTicksOnStart;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long prevTicks;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private long prevIntervalTicks;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8ED19C", Offset = "0x8ED19C")]
		private static SpeedHackDetector <Instance>k__BackingField;

		[Token(Token = "0x1700005A")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1CAA47C", Offset = "0x1CAA47C", VA = "0x1CAA47C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDFC0", Offset = "0x8EDFC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x1CAA4C8", Offset = "0x1CAA4C8", VA = "0x1CAA4C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDFD0", Offset = "0x8EDFD0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1CA9FF0", Offset = "0x1CA9FF0", VA = "0x1CA9FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1CA9C8C", Offset = "0x1CA9C8C", VA = "0x1CA9C8C")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1CA9FC0", Offset = "0x1CA9FC0", VA = "0x1CA9FC0")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1CAA1C0", Offset = "0x1CAA1C0", VA = "0x1CAA1C0")]
		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1CAA200", Offset = "0x1CAA200", VA = "0x1CAA200")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1CAA248", Offset = "0x1CAA248", VA = "0x1CAA248")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1CAA29C", Offset = "0x1CAA29C", VA = "0x1CAA29C")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1CAA38C", Offset = "0x1CAA38C", VA = "0x1CAA38C")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1CAA518", Offset = "0x1CAA518", VA = "0x1CAA518")]
		private SpeedHackDetector()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1CAA538", Offset = "0x1CAA538", VA = "0x1CAA538")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1CAA6AC", Offset = "0x1CAA6AC", VA = "0x1CAA6AC", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1CAA7A0", Offset = "0x1CAA7A0", VA = "0x1CAA7A0")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1CAA894", Offset = "0x1CAA894", VA = "0x1CAA894")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1CAA940", Offset = "0x1CAA940", VA = "0x1CAA940")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1CA9DCC", Offset = "0x1CA9DCC", VA = "0x1CA9DCC")]
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1CAAABC", Offset = "0x1CAAABC", VA = "0x1CAAABC", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1CAAAD0", Offset = "0x1CAAAD0", VA = "0x1CAAAD0", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1CAAAD8", Offset = "0x1CAAAD8", VA = "0x1CAAAD8", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1CAAAF4", Offset = "0x1CAAAF4", VA = "0x1CAAAF4", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1CAAB08", Offset = "0x1CAAB08", VA = "0x1CAAB08", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1CAA8A0", Offset = "0x1CAA8A0", VA = "0x1CAA8A0")]
		private void ResetStartTicks()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8EB95C", Offset = "0x8EB95C")]
	public class WallHackDetector : ActDetectorBase
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBC4C", Offset = "0x8EBC4C")]
		private sealed class <InitDetector>d__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x17000096")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x20B575C", Offset = "0x20B575C", VA = "0x20B575C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x20B57A4", Offset = "0x20B57A4", VA = "0x20B57A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x20B566C", Offset = "0x20B566C", VA = "0x20B566C")]
			[DebuggerHidden]
			public <InitDetector>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x20B5698", Offset = "0x20B5698", VA = "0x20B5698", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x20B569C", Offset = "0x20B569C", VA = "0x20B569C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x20B5764", Offset = "0x20B5764", VA = "0x20B5764", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBC5C", Offset = "0x8EBC5C")]
		private sealed class <CaptureFrame>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RenderTexture <previousActive>5__2;

			[Token(Token = "0x17000098")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x20B561C", Offset = "0x20B561C", VA = "0x20B561C", Slot = "4")]
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
				[Address(RVA = "0x20B5664", Offset = "0x20B5664", VA = "0x20B5664", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x20B5214", Offset = "0x20B5214", VA = "0x20B5214")]
			[DebuggerHidden]
			public <CaptureFrame>d__82(int <>1__state)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x20B5240", Offset = "0x20B5240", VA = "0x20B5240", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x20B5244", Offset = "0x20B5244", VA = "0x20B5244", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x20B5624", Offset = "0x20B5624", VA = "0x20B5624", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000376")]
		internal const string COMPONENT_NAME = "WallHack Detector";

		[Token(Token = "0x4000377")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";

		[Token(Token = "0x4000378")]
		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";

		[Token(Token = "0x4000379")]
		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";

		[Token(Token = "0x400037A")]
		private const int SHADER_TEXTURE_SIZE = 4;

		[Token(Token = "0x400037B")]
		private const int RENDER_TEXTURE_SIZE = 4;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly Vector3 rigidPlayerVelocity;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForEndOfFrame waitForEndOfFrame;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED1AC", Offset = "0x8ED1AC")]
		private bool checkRigidbody;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED1F8", Offset = "0x8ED1F8")]
		private bool checkController;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED244", Offset = "0x8ED244")]
		private bool checkWireframe;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED290", Offset = "0x8ED290")]
		private bool checkRaycast;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED2DC", Offset = "0x8ED2DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8ED2DC", Offset = "0x8ED2DC")]
		public int wireframeDelay;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED334", Offset = "0x8ED334")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8ED334", Offset = "0x8ED334")]
		public int raycastDelay;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED38C", Offset = "0x8ED38C")]
		public Vector3 spawnPosition;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8ED3C4", Offset = "0x8ED3C4")]
		public byte maxFalsePositives;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject serviceContainer;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject solidWall;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject thinWall;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Camera wfCamera;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MeshRenderer foregroundRenderer;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MeshRenderer backgroundRenderer;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Color wfColor1;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Color wfColor2;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Shader wfShader;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material wfMaterial;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Texture2D shaderTexture;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Texture2D targetTexture;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture renderTexture;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int whLayer;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int raycastMask;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Rigidbody rigidPlayer;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CharacterController charControllerPlayer;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float charControllerVelocity;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private byte rigidbodyDetections;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private byte controllerDetections;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		private byte wireframeDetections;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		private byte raycastDetections;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool wireframeDetected;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8ED3FC", Offset = "0x8ED3FC")]
		private static WallHackDetector <Instance>k__BackingField;

		[Token(Token = "0x1700005C")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1CAE6C4", Offset = "0x1CAE6C4", VA = "0x1CAE6C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1CAE6CC", Offset = "0x1CAE6CC", VA = "0x1CAE6CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool CheckController
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1CAFAC0", Offset = "0x1CAFAC0", VA = "0x1CAFAC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1CAFAC8", Offset = "0x1CAFAC8", VA = "0x1CAFAC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool CheckWireframe
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1CAFD3C", Offset = "0x1CAFD3C", VA = "0x1CAFD3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1CAFD44", Offset = "0x1CAFD44", VA = "0x1CAFD44")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public bool CheckRaycast
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1CAFED0", Offset = "0x1CAFED0", VA = "0x1CAFED0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1CAFED8", Offset = "0x1CAFED8", VA = "0x1CAFED8")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1CB082C", Offset = "0x1CB082C", VA = "0x1CB082C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDFE0", Offset = "0x8EDFE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1CB0878", Offset = "0x1CB0878", VA = "0x1CB0878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EDFF0", Offset = "0x8EDFF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1CB03C8", Offset = "0x1CB03C8", VA = "0x1CB03C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1CB0050", Offset = "0x1CB0050", VA = "0x1CB0050")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1CB0394", Offset = "0x1CB0394", VA = "0x1CB0394")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1CB0598", Offset = "0x1CB0598", VA = "0x1CB0598")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1CB05F0", Offset = "0x1CB05F0", VA = "0x1CB05F0")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1CB064C", Offset = "0x1CB064C", VA = "0x1CB064C")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1CB073C", Offset = "0x1CB073C", VA = "0x1CB073C")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1CB08C8", Offset = "0x1CB08C8", VA = "0x1CB08C8")]
		private WallHackDetector()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1CB097C", Offset = "0x1CB097C", VA = "0x1CB097C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1CB0AF0", Offset = "0x1CB0AF0", VA = "0x1CB0AF0", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1CB0CF0", Offset = "0x1CB0CF0", VA = "0x1CB0CF0")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1CB0DE4", Offset = "0x1CB0DE4", VA = "0x1CB0DE4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1CB0F20", Offset = "0x1CB0F20", VA = "0x1CB0F20")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1CB0190", Offset = "0x1CB0190", VA = "0x1CB0190")]
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1CB10AC", Offset = "0x1CB10AC", VA = "0x1CB10AC", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1CB10C0", Offset = "0x1CB10C0", VA = "0x1CB10C0", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1CB1104", Offset = "0x1CB1104", VA = "0x1CB1104", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1CB1180", Offset = "0x1CB1180", VA = "0x1CB1180", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1CB11B8", Offset = "0x1CB11B8", VA = "0x1CB11B8", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1CAE77C", Offset = "0x1CAE77C", VA = "0x1CAE77C")]
		private void UpdateServiceContainer()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1CB1040", Offset = "0x1CB1040", VA = "0x1CB1040")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EE000", Offset = "0x8EE000")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1CAF89C", Offset = "0x1CAF89C", VA = "0x1CAF89C")]
		private void StartRigidModule()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1CAFB78", Offset = "0x1CAFB78", VA = "0x1CAFB78")]
		private void StartControllerModule()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1CAFDF4", Offset = "0x1CAFDF4", VA = "0x1CAFDF4")]
		private void StartWireframeModule()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1CB1810", Offset = "0x1CB1810", VA = "0x1CB1810")]
		private void ShootWireframeModule()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1CB1880", Offset = "0x1CB1880", VA = "0x1CB1880")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8EE060", Offset = "0x8EE060")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1CAFF88", Offset = "0x1CAFF88", VA = "0x1CAFF88")]
		private void StartRaycastModule()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1CB18EC", Offset = "0x1CB18EC", VA = "0x1CB18EC")]
		private void ShootRaycastModule()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1CAFA10", Offset = "0x1CAFA10", VA = "0x1CAFA10")]
		private void StopRigidModule()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1CAFCA8", Offset = "0x1CAFCA8", VA = "0x1CAFCA8")]
		private void StopControllerModule()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1CAFE80", Offset = "0x1CAFE80", VA = "0x1CAFE80")]
		private void StopWireframeModule()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1CB0000", Offset = "0x1CB0000", VA = "0x1CB0000")]
		private void StopRaycastModule()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1CB14C8", Offset = "0x1CB14C8", VA = "0x1CB14C8")]
		private void InitRigidModule()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1CB16D0", Offset = "0x1CB16D0", VA = "0x1CB16D0")]
		private void InitControllerModule()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1CB140C", Offset = "0x1CB140C", VA = "0x1CB140C")]
		private void UninitRigidModule()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1CB1614", Offset = "0x1CB1614", VA = "0x1CB1614")]
		private void UninitControllerModule()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1CB0EC4", Offset = "0x1CB0EC4", VA = "0x1CB0EC4")]
		private bool Detect()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1CB129C", Offset = "0x1CB129C", VA = "0x1CB129C")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1CB1318", Offset = "0x1CB1318", VA = "0x1CB1318")]
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return default(bool);
		}
	}
}
namespace CodeStage.AntiCheat.Common
{
	[Token(Token = "0x200008D")]
	internal class Constants
	{
		[Token(Token = "0x400039F")]
		internal const string LOG_PREFIX = "[ACTk] ";

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1AC1434", Offset = "0x1AC1434", VA = "0x1AC1434")]
		public Constants()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Examples
{
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8EB994", Offset = "0x8EB994")]
	public class ActRotatorExample : MonoBehaviour
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8ED40C", Offset = "0x8ED40C")]
		public float speed;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1A47710", Offset = "0x1A47710", VA = "0x1A47710")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1A47768", Offset = "0x1A47768", VA = "0x1A47768")]
		public ActRotatorExample()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8EB9CC", Offset = "0x8EB9CC")]
	public class ActTesterGui : MonoBehaviour
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBC6C", Offset = "0x8EBC6C")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string types;

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1CB22C0", Offset = "0x1CB22C0", VA = "0x1CB22C0")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1CB22C8", Offset = "0x1CB22C8", VA = "0x1CB22C8")]
			internal void <GetAllSimpleObscuredTypes>b__1(Type t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8EBC7C", Offset = "0x8EBC7C")]
		private sealed class <>c
		{
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> <>9__61_0;

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x1CB21FC", Offset = "0x1CB21FC", VA = "0x1CB21FC")]
			public <>c()
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1CB2204", Offset = "0x1CB2204", VA = "0x1CB2204")]
			internal bool <GetAllSimpleObscuredTypes>b__61_0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003A1")]
		private const string RED_COLOR = "#FF4040";

		[Token(Token = "0x40003A2")]
		private const string GREEN_COLOR = "#02C85F";

		[Token(Token = "0x40003A3")]
		private const string PREFS_STRING = "name";

		[Token(Token = "0x40003A4")]
		private const string PREFS_INT = "money";

		[Token(Token = "0x40003A5")]
		private const string PREFS_FLOAT = "lifeBar";

		[Token(Token = "0x40003A6")]
		private const string PREFS_BOOL = "gameComplete";

		[Token(Token = "0x40003A7")]
		private const string PREFS_UINT = "demoUint";

		[Token(Token = "0x40003A8")]
		private const string PREFS_LONG = "demoLong";

		[Token(Token = "0x40003A9")]
		private const string PREFS_DOUBLE = "demoDouble";

		[Token(Token = "0x40003AA")]
		private const string PREFS_VECTOR2 = "demoVector2";

		[Token(Token = "0x40003AB")]
		private const string PREFS_VECTOR3 = "demoVector3";

		[Token(Token = "0x40003AC")]
		private const string PREFS_QUATERNION = "demoQuaternion";

		[Token(Token = "0x40003AD")]
		private const string PREFS_RECT = "demoRect";

		[Token(Token = "0x40003AE")]
		private const string PREFS_COLOR = "demoColor";

		[Token(Token = "0x40003AF")]
		private const string PREFS_BYTE_ARRAY = "demoByteArray";

		[Token(Token = "0x40003B0")]
		private const string API_URL_LOCK_TO_DEVICE = "http://j.mp/1gxg1tf";

		[Token(Token = "0x40003B1")]
		private const string API_URL_PRESERVE_PREFS = "http://j.mp/1iBK5pz";

		[Token(Token = "0x40003B2")]
		private const string API_URL_EMERGENCY_MODE = "http://j.mp/1FRAL5L";

		[Token(Token = "0x40003B3")]
		private const string API_URL_READ_FOREIGN = "http://j.mp/1LCdpDa";

		[Token(Token = "0x40003B4")]
		private const string API_URL_UNOBSCURED_MODE = "http://j.mp/1KVrpxi";

		[Token(Token = "0x40003B5")]
		private const string API_URL_PLAYER_PREFS = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8ED428", Offset = "0x8ED428")]
		public string regularString;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int regularInt;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float regularFloat;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 regularVector3;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8ED460", Offset = "0x8ED460")]
		public ObscuredString obscuredString;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ObscuredInt obscuredInt;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ObscuredFloat obscuredFloat;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ObscuredVector3 obscuredVector3;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ObscuredBool obscuredBool;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public ObscuredLong obscuredLong;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ObscuredDouble obscuredDouble;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public ObscuredVector2 obscuredVector2;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8ED498", Offset = "0x8ED498")]
		public string prefsEncryptionKey;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly string[] tabs;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int currentTab;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string allSimpleObscuredTypes;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string regularPrefs;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string obscuredPrefs;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int savesLock;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private bool savesAlterationDetected;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		private bool foreignSavesDetected;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		private bool injectionDetected;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		private bool speedHackDetected;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool obscuredTypeCheatDetected;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool wallHackCheatDetected;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1A47778", Offset = "0x1A47778", VA = "0x1A47778")]
		public void OnSpeedHackDetected()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1A477F8", Offset = "0x1A477F8", VA = "0x1A477F8")]
		public void OnInjectionDetected()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1A47878", Offset = "0x1A47878", VA = "0x1A47878")]
		public void OnObscuredTypeCheatingDetected()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1A478F8", Offset = "0x1A478F8", VA = "0x1A478F8")]
		public void OnWallHackDetected()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1A47978", Offset = "0x1A47978", VA = "0x1A47978")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1A47A78", Offset = "0x1A47A78", VA = "0x1A47A78")]
		private void Start()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1A489A8", Offset = "0x1A489A8", VA = "0x1A489A8")]
		private void RandomizeObscuredVars()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1A47AF8", Offset = "0x1A47AF8", VA = "0x1A47AF8")]
		private void ObscuredStringExample()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1A47CDC", Offset = "0x1A47CDC", VA = "0x1A47CDC")]
		private void ObscuredIntExample()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1A481A8", Offset = "0x1A481A8", VA = "0x1A481A8")]
		private void ObscuredFloatExample()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1A485B8", Offset = "0x1A485B8", VA = "0x1A485B8")]
		private void ObscuredVector3Example()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1A48A40", Offset = "0x1A48A40", VA = "0x1A48A40")]
		private void SavesAlterationDetected()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1A48A4C", Offset = "0x1A48A4C", VA = "0x1A48A4C")]
		private void ForeignSavesDetected()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1A48A58", Offset = "0x1A48A58", VA = "0x1A48A58")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1A4EF7C", Offset = "0x1A4EF7C", VA = "0x1A4EF7C")]
		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1A4F220", Offset = "0x1A4F220", VA = "0x1A4F220")]
		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1A4F264", Offset = "0x1A4F264", VA = "0x1A4F264")]
		private void LoadRegularPrefs()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1A4F3E4", Offset = "0x1A4F3E4", VA = "0x1A4F3E4")]
		private void SaveRegularPrefs()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1A4F498", Offset = "0x1A4F498", VA = "0x1A4F498")]
		private void DeleteRegularPrefs()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1A4F528", Offset = "0x1A4F528", VA = "0x1A4F528")]
		private void LoadObscuredPrefs()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1A4FDE0", Offset = "0x1A4FDE0", VA = "0x1A4FDE0")]
		private void SaveObscuredPrefs()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1A500E8", Offset = "0x1A500E8", VA = "0x1A500E8")]
		private void DeleteObscuredPrefs()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1A502E4", Offset = "0x1A502E4", VA = "0x1A502E4")]
		private void PlaceUrlButton(string url)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1A503E0", Offset = "0x1A503E0", VA = "0x1A503E0")]
		private void PlaceUrlButton(string url, int width)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1A502EC", Offset = "0x1A502EC", VA = "0x1A502EC")]
		private void PlaceUrlButton(string url, string buttonName, int width)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1A5043C", Offset = "0x1A5043C", VA = "0x1A5043C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1A50450", Offset = "0x1A50450", VA = "0x1A50450")]
		public ActTesterGui()
		{
		}
	}
	[Token(Token = "0x2000090")]
	internal class HorizontalLayout : IDisposable
	{
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1ACA7B0", Offset = "0x1ACA7B0", VA = "0x1ACA7B0")]
		public HorizontalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1ACA7DC", Offset = "0x1ACA7DC", VA = "0x1ACA7DC", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000091")]
	internal class VerticalLayout : IDisposable
	{
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1CAE018", Offset = "0x1CAE018", VA = "0x1CAE018")]
		public VerticalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1CAE044", Offset = "0x1CAE044", VA = "0x1CAE044")]
		public VerticalLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1CAE12C", Offset = "0x1CAE12C", VA = "0x1CAE12C", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8EBA04", Offset = "0x8EBA04")]
	public class ObscuredPerformanceTests : MonoBehaviour
	{
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool boolTest;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int boolIterations;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool byteTest;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int byteIterations;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool shortTest;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int shortIterations;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ushortTest;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int ushortIterations;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intTest;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int intIterations;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool uintTest;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int uintIterations;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool longTest;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int longIterations;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool floatTest;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int floatIterations;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool doubleTest;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int doubleIterations;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool stringTest;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int stringIterations;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool vector3Test;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int vector3Iterations;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool prefsTest;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int prefsIterations;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1D3A73C", Offset = "0x1D3A73C", VA = "0x1D3A73C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1D3A790", Offset = "0x1D3A790", VA = "0x1D3A790")]
		private void StartTests()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1D3A8F8", Offset = "0x1D3A8F8", VA = "0x1D3A8F8")]
		private void TestBool()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1D3AC0C", Offset = "0x1D3AC0C", VA = "0x1D3AC0C")]
		private void TestByte()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1D3AF0C", Offset = "0x1D3AF0C", VA = "0x1D3AF0C")]
		private void TestShort()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1D3B20C", Offset = "0x1D3B20C", VA = "0x1D3B20C")]
		private void TestUShort()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1D3C188", Offset = "0x1D3C188", VA = "0x1D3C188")]
		private void TestDouble()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1D3BE34", Offset = "0x1D3BE34", VA = "0x1D3BE34")]
		private void TestFloat()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1D3B508", Offset = "0x1D3B508", VA = "0x1D3B508")]
		private void TestInt()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1D3BB18", Offset = "0x1D3BB18", VA = "0x1D3BB18")]
		private void TestLong()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1D3C4B0", Offset = "0x1D3C4B0", VA = "0x1D3C4B0")]
		private void TestString()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1D3B810", Offset = "0x1D3B810", VA = "0x1D3B810")]
		private void TestUInt()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1D3C83C", Offset = "0x1D3C83C", VA = "0x1D3C83C")]
		private void TestVector3()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1D3CCA0", Offset = "0x1D3CCA0", VA = "0x1D3CCA0")]
		private void TestPrefs()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1D3DA60", Offset = "0x1D3DA60", VA = "0x1D3DA60")]
		public ObscuredPerformanceTests()
		{
		}
	}
}
