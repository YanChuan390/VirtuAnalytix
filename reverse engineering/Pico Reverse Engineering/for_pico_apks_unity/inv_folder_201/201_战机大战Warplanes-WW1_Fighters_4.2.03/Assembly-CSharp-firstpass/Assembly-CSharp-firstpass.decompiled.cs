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
		[Address(RVA = "0x1621618", Offset = "0x1621618", VA = "0x1621618")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x16216FC", Offset = "0x16216FC", VA = "0x16216FC")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1621814", Offset = "0x1621814", VA = "0x1621814")]
	public static void ResetLastSendTime()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x16218E8", Offset = "0x16218E8", VA = "0x16218E8")]
	public void SetLastStoreTime()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1621958", Offset = "0x1621958", VA = "0x1621958")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x16223EC", Offset = "0x16223EC", VA = "0x16223EC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1622554", Offset = "0x1622554", VA = "0x1622554")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1622994", Offset = "0x1622994", VA = "0x1622994")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1622998", Offset = "0x1622998", VA = "0x1622998")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1622FD8", Offset = "0x1622FD8", VA = "0x1622FD8")]
	public static bool WillOpenCloudStorageScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1621C68", Offset = "0x1621C68", VA = "0x1621C68")]
	private void StartFirstScreen()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x16233A8", Offset = "0x16233A8", VA = "0x16233A8", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x16233AC", Offset = "0x16233AC", VA = "0x16233AC", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x16227DC", Offset = "0x16227DC", VA = "0x16227DC", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1622B88", Offset = "0x1622B88", VA = "0x1622B88", Slot = "7")]
	public void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1623654", Offset = "0x1623654", VA = "0x1623654")]
	public void OnReceivedCloudSave(CloudSave_Screen onScreen, CloudSave_Saves cloudSaves, bool compareAndImport)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1623974", Offset = "0x1623974", VA = "0x1623974")]
	public void OnSendSaveToCloud(CloudSave_Screen onScreen, CloudSave_Saves localSaves)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1622CC0", Offset = "0x1622CC0", VA = "0x1622CC0")]
	public void TrySendChangedLocalSave()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x16244B0", Offset = "0x16244B0", VA = "0x16244B0")]
	public void TrySendDeletedSave()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1622764", Offset = "0x1622764", VA = "0x1622764")]
	protected void ShowConflictMessage()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1624608", Offset = "0x1624608", VA = "0x1624608")]
	protected void ClearConflictMessage()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1624680", Offset = "0x1624680", VA = "0x1624680")]
	public bool IsLoggingIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x16232A0", Offset = "0x16232A0", VA = "0x16232A0")]
	protected void ShowScreen(CloudSave_Screen screen)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x16246EC", Offset = "0x16246EC", VA = "0x16246EC")]
	public void On_CloudInfo_Yes()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x16246F4", Offset = "0x16246F4", VA = "0x16246F4")]
	public void On_CloudInfo_No()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x16246F8", Offset = "0x16246F8", VA = "0x16246F8")]
	public void On_CloudInfo_Back()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x16247D4", Offset = "0x16247D4", VA = "0x16247D4")]
	public void On_CloudInfo_CloseToLogin()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1623388", Offset = "0x1623388", VA = "0x1623388")]
	protected void ShowLoginScreen(bool autoLogin, bool manualFirstLogin)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x16247DC", Offset = "0x16247DC", VA = "0x16247DC")]
	public void On_LoginScreen_Back()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1624858", Offset = "0x1624858", VA = "0x1624858")]
	public void On_LoginScreen_ShowInfo()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1624860", Offset = "0x1624860", VA = "0x1624860")]
	public void On_LoginScreen_FailedAutoLogin()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x16249DC", Offset = "0x16249DC", VA = "0x16249DC")]
	public void OnSelectScreen_ShowLogin(bool showRegister)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1624B3C", Offset = "0x1624B3C", VA = "0x1624B3C")]
	public void On_LoginScreen_LoggedIn()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1624C54", Offset = "0x1624C54", VA = "0x1624C54")]
	public void On_LoginScreen_ResetPassword()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1624C88", Offset = "0x1624C88", VA = "0x1624C88")]
	public void On_MenuScreen_Back()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1624CFC", Offset = "0x1624CFC", VA = "0x1624CFC")]
	public void On_MenuScreen_Settings()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1624D04", Offset = "0x1624D04", VA = "0x1624D04")]
	public void On_MenuScreen_SetPassword()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1624D0C", Offset = "0x1624D0C", VA = "0x1624D0C")]
	public void On_MenuScreen_Logout()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1624DEC", Offset = "0x1624DEC", VA = "0x1624DEC")]
	public void On_ChangePasswordScreen_Back()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1624DF4", Offset = "0x1624DF4", VA = "0x1624DF4")]
	public void On_ResetPasswordScreen_Back(bool backToSettings)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1624E08", Offset = "0x1624E08", VA = "0x1624E08")]
	public void ShowMessageScreen(string text, bool warning, CloudSave_Screen backToScreen, Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1624EDC", Offset = "0x1624EDC", VA = "0x1624EDC")]
	public void On_MessageScreen_Closed(CloudSave_Screen backToScreen, Action<bool> resultCallback, bool result)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1624F6C", Offset = "0x1624F6C", VA = "0x1624F6C")]
	public void On_SettingsScreen_Back()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1624F74", Offset = "0x1624F74", VA = "0x1624F74")]
	public void On_SettingsScreen_ChangePassword()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1624F7C", Offset = "0x1624F7C", VA = "0x1624F7C")]
	public void On_SettingsScreen_ResetPassword()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1624FB4", Offset = "0x1624FB4", VA = "0x1624FB4")]
	public void On_SettingsScreen_DeleteAccount()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1624FBC", Offset = "0x1624FBC", VA = "0x1624FBC")]
	public void On_DeleteAccountScreen_Back()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1624FC4", Offset = "0x1624FC4", VA = "0x1624FC4")]
	public void On_DeleteAccountScreen_Deleted()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x16251B0", Offset = "0x16251B0", VA = "0x16251B0")]
	public void On_SettingsScreen_RedeemCode()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x16251B8", Offset = "0x16251B8", VA = "0x16251B8")]
	public void On_RedeemCodeScreen_Back()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x16251C0", Offset = "0x16251C0", VA = "0x16251C0")]
	public void ShowTermsOfUseScreen(string email, string password, bool newsletter)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1625218", Offset = "0x1625218", VA = "0x1625218")]
	public void On_TermsOfUseScreen_No()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1625220", Offset = "0x1625220", VA = "0x1625220")]
	public void On_TermsOfUseScreen_Completed()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1625228", Offset = "0x1625228", VA = "0x1625228")]
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
	[Address(RVA = "0x16252CC", Offset = "0x16252CC", VA = "0x16252CC")]
	public CloudSave_CoroutineCallback_InfoOnly(CloudSave_CoroutineCallback _baseCallback)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x16252F8", Offset = "0x16252F8", VA = "0x16252F8", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x16252FC", Offset = "0x16252FC", VA = "0x16252FC", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1625300", Offset = "0x1625300", VA = "0x1625300", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x16253D4", Offset = "0x16253D4", VA = "0x16253D4", Slot = "7")]
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
		[Token(Token = "0x40003F2")]
		Equal,
		[Token(Token = "0x40003F3")]
		Better,
		[Token(Token = "0x40003F4")]
		Worse,
		[Token(Token = "0x40003F5")]
		Conflict
	}

	[Token(Token = "0x2000095")]
	public enum SoundType
	{
		[Token(Token = "0x40003F7")]
		ClickButton
	}

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CloudSave_GameInterface instance;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool destroyingUnwantedThis;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1625530", Offset = "0x1625530", VA = "0x1625530")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1625688", Offset = "0x1625688", VA = "0x1625688", Slot = "4")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1625760", Offset = "0x1625760", VA = "0x1625760", Slot = "5")]
	public virtual string GetTextsLanguageID()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x16257F0", Offset = "0x16257F0", VA = "0x16257F0", Slot = "6")]
	public virtual string TranslateText(string trl)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1625880", Offset = "0x1625880", VA = "0x1625880", Slot = "7")]
	public virtual string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1625910", Offset = "0x1625910", VA = "0x1625910", Slot = "8")]
	public virtual string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x16259A0", Offset = "0x16259A0", VA = "0x16259A0", Slot = "9")]
	public virtual void BackToMainMenuScene()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1625A14", Offset = "0x1625A14", VA = "0x1625A14", Slot = "10")]
	public virtual uint GetSaveCloudUserId()
	{
		return default(uint);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1625A90", Offset = "0x1625A90", VA = "0x1625A90", Slot = "11")]
	public virtual CloudSave_Saves ExportGameSaves()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1625B30", Offset = "0x1625B30", VA = "0x1625B30", Slot = "12")]
	public virtual void ImportGameSave(CloudSave_Saves cloudSaves)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1625BA4", Offset = "0x1625BA4", VA = "0x1625BA4", Slot = "13")]
	public virtual void DeleteLocalSaveOnRegister()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1625C18", Offset = "0x1625C18", VA = "0x1625C18", Slot = "14")]
	public virtual string GetSavePreviewLabels()
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1625CA8", Offset = "0x1625CA8", VA = "0x1625CA8", Slot = "15")]
	public virtual string GetSavePreview(CloudSave_Saves save)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1625D38", Offset = "0x1625D38", VA = "0x1625D38", Slot = "16")]
	public virtual CompareSaveResult CompareSave(CloudSave_Saves save1, CloudSave_Saves save2)
	{
		return default(CompareSaveResult);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1625DB4", Offset = "0x1625DB4", VA = "0x1625DB4", Slot = "17")]
	public virtual bool CanSendChangedLocalSaveInCurrentLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1625E30", Offset = "0x1625E30", VA = "0x1625E30", Slot = "18")]
	public virtual GameObject GetCloudStatusLineObject()
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1625EAC", Offset = "0x1625EAC", VA = "0x1625EAC", Slot = "19")]
	public virtual bool ShowCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1625F28", Offset = "0x1625F28", VA = "0x1625F28", Slot = "20")]
	public virtual bool ClearCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1625FA4", Offset = "0x1625FA4", VA = "0x1625FA4", Slot = "21")]
	public virtual void PlaySound(SoundType sndType)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1626018", Offset = "0x1626018", VA = "0x1626018", Slot = "22")]
	public virtual void OnShowCloudScreens()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x162608C", Offset = "0x162608C", VA = "0x162608C", Slot = "23")]
	public virtual bool HaveSaveForPromoCode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1626108", Offset = "0x1626108", VA = "0x1626108", Slot = "24")]
	public virtual string GetPromoCodeSkuName(string sku)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1626198", Offset = "0x1626198", VA = "0x1626198", Slot = "25")]
	public virtual void OnUsePromoCode(string sku)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x162620C", Offset = "0x162620C", VA = "0x162620C")]
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
	[Address(RVA = "0x1626EA4", Offset = "0x1626EA4", VA = "0x1626EA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1626F68", Offset = "0x1626F68", VA = "0x1626F68", Slot = "8")]
	public virtual void ActivateScreen()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1626F6C", Offset = "0x1626F6C", VA = "0x1626F6C", Slot = "9")]
	public virtual void DeactivateScreen()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1626F70", Offset = "0x1626F70", VA = "0x1626F70", Slot = "10")]
	public virtual void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1626F74", Offset = "0x1626F74", VA = "0x1626F74", Slot = "11")]
	public virtual void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1626F78", Offset = "0x1626F78", VA = "0x1626F78", Slot = "12")]
	public virtual void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1626FB8", Offset = "0x1626FB8", VA = "0x1626FB8", Slot = "13")]
	public virtual void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1627058", Offset = "0x1627058", VA = "0x1627058")]
	public void ClearInfoMessage()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x16270B4", Offset = "0x16270B4", VA = "0x16270B4", Slot = "14")]
	public virtual void SetInfoMessageText(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x162715C", Offset = "0x162715C", VA = "0x162715C")]
	protected string TranslateText(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1623C2C", Offset = "0x1623C2C", VA = "0x1623C2C")]
	public static string TranslateTextWithErrorParse(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x16271D8", Offset = "0x16271D8", VA = "0x16271D8")]
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
		[Token(Token = "0x40003F9")]
		ChangePassword,
		[Token(Token = "0x40003FA")]
		LoadGameSave,
		[Token(Token = "0x40003FB")]
		Login,
		[Token(Token = "0x40003FC")]
		OpenSSLSession,
		[Token(Token = "0x40003FD")]
		SendResetPassword,
		[Token(Token = "0x40003FE")]
		StoreGameSave,
		[Token(Token = "0x40003FF")]
		SetNewsletter,
		[Token(Token = "0x4000400")]
		DeleteAccount,
		[Token(Token = "0x4000401")]
		RedeemCode
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368BC", Offset = "0x8368BC")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x212B5D0", Offset = "0x212B5D0", VA = "0x212B5D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x212B618", Offset = "0x212B618", VA = "0x212B618", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x212B510", Offset = "0x212B510", VA = "0x212B510")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x212B53C", Offset = "0x212B53C", VA = "0x212B53C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x212B540", Offset = "0x212B540", VA = "0x212B540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x212B5D8", Offset = "0x212B5D8", VA = "0x212B5D8", Slot = "8")]
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
	[Address(RVA = "0x16E9270", Offset = "0x16E9270", VA = "0x16E9270")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x16EC838", Offset = "0x16EC838", VA = "0x16EC838")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback, bool dontDestroyOnLoad)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x16ECB28", Offset = "0x16ECB28", VA = "0x16ECB28", Slot = "4")]
	public virtual CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x16ECBA4", Offset = "0x16ECBA4", VA = "0x16ECBA4", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838340", Offset = "0x838340")]
	public virtual IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x16ECC00", Offset = "0x16ECC00", VA = "0x16ECC00", Slot = "6")]
	public virtual bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x16E9314", Offset = "0x16E9314", VA = "0x16E9314")]
	public void Destroy()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x16ECC7C", Offset = "0x16ECC7C", VA = "0x16ECC7C")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x16ECC84", Offset = "0x16ECC84", VA = "0x16ECC84")]
	protected void CallOnStart()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x16ECD44", Offset = "0x16ECD44", VA = "0x16ECD44")]
	protected void CallOnEnd()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x16ECE04", Offset = "0x16ECE04", VA = "0x16ECE04")]
	protected void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x16ECED8", Offset = "0x16ECED8", VA = "0x16ECED8")]
	protected void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x16ECFC0", Offset = "0x16ECFC0", VA = "0x16ECFC0")]
	protected string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x16ED034", Offset = "0x16ED034", VA = "0x16ED034")]
	protected string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x16ED0A8", Offset = "0x16ED0A8", VA = "0x16ED0A8")]
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
	[Address(RVA = "0x16EB080", Offset = "0x16EB080", VA = "0x16EB080")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x16EB134", Offset = "0x16EB134", VA = "0x16EB134")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x16EE150", Offset = "0x16EE150", VA = "0x16EE150")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x16EE21C", Offset = "0x16EE21C", VA = "0x16EE21C")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x16EE2D0", Offset = "0x16EE2D0", VA = "0x16EE2D0")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x16EE39C", Offset = "0x16EE39C", VA = "0x16EE39C")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x16EE450", Offset = "0x16EE450", VA = "0x16EE450")]
	public static void Save()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x16EE4F8", Offset = "0x16EE4F8", VA = "0x16EE4F8")]
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
	[Address(RVA = "0x16EE550", Offset = "0x16EE550", VA = "0x16EE550")]
	public void Start()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x16EE724", Offset = "0x16EE724", VA = "0x16EE724")]
	public bool IsTranslated()
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x16EE554", Offset = "0x16EE554", VA = "0x16EE554")]
	public void TranslateText()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x16EE72C", Offset = "0x16EE72C", VA = "0x16EE72C")]
	public void TranslateFromStart()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x16EE794", Offset = "0x16EE794", VA = "0x16EE794")]
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
	[Address(RVA = "0x1626454", Offset = "0x1626454", VA = "0x1626454")]
	public CloudSave_Save()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x16264CC", Offset = "0x16264CC", VA = "0x16264CC")]
	public CloudSave_Save(string _save)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1626558", Offset = "0x1626558", VA = "0x1626558")]
	public CloudSave_Save(string _save, List<KeyValuePair<string, string>> _properties)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1626730", Offset = "0x1626730", VA = "0x1626730")]
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
	[Address(RVA = "0x1623ECC", Offset = "0x1623ECC", VA = "0x1623ECC")]
	public CloudSave_Saves()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x162679C", Offset = "0x162679C", VA = "0x162679C")]
	public CloudSave_Saves(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1623D40", Offset = "0x1623D40", VA = "0x1623D40")]
	public void Copy(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x162682C", Offset = "0x162682C", VA = "0x162682C")]
	public void AddSave(string name, string save)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x16269EC", Offset = "0x16269EC", VA = "0x16269EC")]
	public void AddSave(string name, string save, List<KeyValuePair<string, string>> properties)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1626BC0", Offset = "0x1626BC0", VA = "0x1626BC0")]
	public void Clear()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1624464", Offset = "0x1624464", VA = "0x1624464")]
	public int GetSavesCount()
	{
		return default(int);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1623F44", Offset = "0x1623F44", VA = "0x1623F44")]
	public string GetSaveName(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1626C14", Offset = "0x1626C14", VA = "0x1626C14")]
	public string GetSave(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1624180", Offset = "0x1624180", VA = "0x1624180")]
	public List<KeyValuePair<string, string>> GetSaveProperties(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x16240AC", Offset = "0x16240AC", VA = "0x16240AC")]
	public bool HaveSave(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1626D84", Offset = "0x1626D84", VA = "0x1626D84")]
	public string GetSave(string name)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1624318", Offset = "0x1624318", VA = "0x1624318")]
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
	[Address(RVA = "0x16EDBB4", Offset = "0x16EDBB4", VA = "0x16EDBB4")]
	public static bool IsEncryptionEstablished()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x16EE7E8", Offset = "0x16EE7E8", VA = "0x16EE7E8")]
	public static bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x16EE8BC", Offset = "0x16EE8BC", VA = "0x16EE8BC")]
	public static void clearUser()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x16EE9BC", Offset = "0x16EE9BC", VA = "0x16EE9BC")]
	public static void clearUserAndSession()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x16EEA5C", Offset = "0x16EEA5C", VA = "0x16EEA5C")]
	public static uint GetAccountIDChecksum(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x16EEB30", Offset = "0x16EEB30", VA = "0x16EEB30")]
	public static uint GetUIDFromAccountID(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x16E9B30", Offset = "0x16E9B30", VA = "0x16E9B30")]
	public static string GetStringUIDFromAccountID(uint id)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x16EEBA4", Offset = "0x16EEBA4", VA = "0x16EEBA4")]
	public static bool GetAccountIDFromStringUID(string suid, out uint id)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000010")]
public static class CloudSave_Utils
{
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x16EEF04", Offset = "0x16EEF04", VA = "0x16EEF04")]
	public static string RSA_encrypt(string toBeEncrypted)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x16EEF08", Offset = "0x16EEF08", VA = "0x16EEF08")]
	public static void generateAESkeyAndIV()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x16EEF0C", Offset = "0x16EEF0C", VA = "0x16EEF0C")]
	public static string AES_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x16EEF14", Offset = "0x16EEF14", VA = "0x16EEF14")]
	public static string AES_encrypt(string input, bool MD5)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x16ED730", Offset = "0x16ED730", VA = "0x16ED730")]
	public static string AES_decrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x16EF0E4", Offset = "0x16EF0E4", VA = "0x16EF0E4")]
	private static string GetMd5Hash(MD5 md5Hash, string input)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x16EEF90", Offset = "0x16EEF90", VA = "0x16EEF90")]
	public static string MD5_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x16ED814", Offset = "0x16ED814", VA = "0x16ED814")]
	public static string MD5_encryptWithSalt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x16EF218", Offset = "0x16EF218", VA = "0x16EF218")]
	public static string convertBytesToString(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x16EF260", Offset = "0x16EF260", VA = "0x16EF260")]
	public static byte[] convertStringToBytes(string s)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x16EB6C0", Offset = "0x16EB6C0", VA = "0x16EB6C0")]
	public static bool TestValidEmailFormat(string email)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x16EF29C", Offset = "0x16EF29C", VA = "0x16EF29C")]
	public static bool GetValueInsideTag(string text, string tag, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x16EF468", Offset = "0x16EF468", VA = "0x16EF468")]
	public static string[] GetValuesInsideTags(string text, string tag)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x16EF6B0", Offset = "0x16EF6B0", VA = "0x16EF6B0")]
	public static Dictionary<string, string> ParseKeysAssignedValues(string text, char delimeter)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x16EF8A4", Offset = "0x16EF8A4", VA = "0x16EF8A4")]
	public static bool GetValueOfTag(string text, string valTag, out string outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x16EF964", Offset = "0x16EF964", VA = "0x16EF964")]
	public static Dictionary<string, string> GetTagsAndValues(string text)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x16EFB04", Offset = "0x16EFB04", VA = "0x16EFB04")]
	public static bool GetIntValueOfTag(string text, string valTag, out int outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x16EFBAC", Offset = "0x16EFBAC", VA = "0x16EFBAC")]
	public static bool ParseErrorCode(string text, out string errorText, out string errorExtCode)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x16EFD08", Offset = "0x16EFD08", VA = "0x16EFD08")]
	public static string GetUrlWithSecureProtocol(string url)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x16EFDD4", Offset = "0x16EFDD4", VA = "0x16EFDD4")]
	public static string GetWebGLUrlProxy(string url)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x16EFDD8", Offset = "0x16EFDD8", VA = "0x16EFDD8")]
	public static string GenRandomString(int len)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x16EFEA4", Offset = "0x16EFEA4", VA = "0x16EFEA4")]
	public static string EncodeBase64(string plain)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x16EFF34", Offset = "0x16EFF34", VA = "0x16EFF34")]
	public static string DecodeBase64(string encoded)
	{
		return null;
	}
}
[Token(Token = "0x2000011")]
public class CloudSave_ServerCoroutine_ChangePassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368CC", Offset = "0x8368CC")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_ChangePassword <>4__this;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000065")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x212BCF4", Offset = "0x212BCF4", VA = "0x212BCF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x212BD3C", Offset = "0x212BD3C", VA = "0x212BD3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x212B620", Offset = "0x212B620", VA = "0x212B620")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x212B64C", Offset = "0x212B64C", VA = "0x212B64C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x212B650", Offset = "0x212B650", VA = "0x212B650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x212BCFC", Offset = "0x212BCFC", VA = "0x212BCFC", Slot = "8")]
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
	[Address(RVA = "0x16ED0B0", Offset = "0x16ED0B0", VA = "0x16ED0B0")]
	public void InitParams(string _oldPassword, string _newPassword)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x16ED0B8", Offset = "0x16ED0B8", VA = "0x16ED0B8", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x16ED0C0", Offset = "0x16ED0C0", VA = "0x16ED0C0", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x16ED0C8", Offset = "0x16ED0C8", VA = "0x16ED0C8", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8383A0", Offset = "0x8383A0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x16ED134", Offset = "0x16ED134", VA = "0x16ED134")]
	public CloudSave_ServerCoroutine_ChangePassword()
	{
	}
}
[Token(Token = "0x2000012")]
public class CloudSave_ServerCoroutine_DeleteAccount : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368DC", Offset = "0x8368DC")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_DeleteAccount <>4__this;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000067")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x212C39C", Offset = "0x212C39C", VA = "0x212C39C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x212C3E4", Offset = "0x212C3E4", VA = "0x212C3E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x212BD44", Offset = "0x212BD44", VA = "0x212BD44")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x212BD70", Offset = "0x212BD70", VA = "0x212BD70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x212BD74", Offset = "0x212BD74", VA = "0x212BD74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x212C3A4", Offset = "0x212C3A4", VA = "0x212C3A4", Slot = "8")]
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
	[Address(RVA = "0x16ED188", Offset = "0x16ED188", VA = "0x16ED188")]
	public void InitParams(string _password)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x16ED190", Offset = "0x16ED190", VA = "0x16ED190", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x16ED198", Offset = "0x16ED198", VA = "0x16ED198", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x16ED1A0", Offset = "0x16ED1A0", VA = "0x16ED1A0", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838400", Offset = "0x838400")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x16ED20C", Offset = "0x16ED20C", VA = "0x16ED20C")]
	public CloudSave_ServerCoroutine_DeleteAccount()
	{
	}
}
[Token(Token = "0x2000013")]
public class CloudSave_ServerCoroutine_LoadGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368EC", Offset = "0x8368EC")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_LoadGameSave <>4__this;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000069")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x212CA44", Offset = "0x212CA44", VA = "0x212CA44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x212CA8C", Offset = "0x212CA8C", VA = "0x212CA8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x212C3EC", Offset = "0x212C3EC", VA = "0x212C3EC")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x212C418", Offset = "0x212C418", VA = "0x212C418", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x212C41C", Offset = "0x212C41C", VA = "0x212C41C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x212CA4C", Offset = "0x212CA4C", VA = "0x212CA4C", Slot = "8")]
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
	[Address(RVA = "0x16ED260", Offset = "0x16ED260", VA = "0x16ED260", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x16ED268", Offset = "0x16ED268", VA = "0x16ED268", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x16E9AA8", Offset = "0x16E9AA8", VA = "0x16E9AA8")]
	public CloudSave_Saves GetResultLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x16ED270", Offset = "0x16ED270", VA = "0x16ED270")]
	public static bool ParseSavesFromServer(string text, CloudSave_Saves localSaves, out CloudSave_Saves outSaves)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x16ED888", Offset = "0x16ED888", VA = "0x16ED888", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838460", Offset = "0x838460")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x16ED8F4", Offset = "0x16ED8F4", VA = "0x16ED8F4")]
	public CloudSave_ServerCoroutine_LoadGameSave()
	{
	}
}
[Token(Token = "0x2000014")]
public class CloudSave_ServerCoroutine_Login : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368FC", Offset = "0x8368FC")]
	private sealed class <Run>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_Login <>4__this;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x1700006B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x212D8B0", Offset = "0x212D8B0", VA = "0x212D8B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x212D8F8", Offset = "0x212D8F8", VA = "0x212D8F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x212CA94", Offset = "0x212CA94", VA = "0x212CA94")]
		[DebuggerHidden]
		public <Run>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x212CAC0", Offset = "0x212CAC0", VA = "0x212CAC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x212CAC4", Offset = "0x212CAC4", VA = "0x212CAC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x212D8B8", Offset = "0x212D8B8", VA = "0x212D8B8", Slot = "8")]
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
	[Address(RVA = "0x16EC714", Offset = "0x16EC714", VA = "0x16EC714")]
	public void InitParams(bool _register, string _email, string _password, bool _newsletter, CloudSave_Saves _localSavesToCompare)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x16ED958", Offset = "0x16ED958", VA = "0x16ED958", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x16ED960", Offset = "0x16ED960", VA = "0x16ED960", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x16ED968", Offset = "0x16ED968", VA = "0x16ED968")]
	public bool GetLoadSaveResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x16ED970", Offset = "0x16ED970", VA = "0x16ED970")]
	public CloudSave_Saves GetLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x16ED9F8", Offset = "0x16ED9F8", VA = "0x16ED9F8", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8384C0", Offset = "0x8384C0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x16EDA64", Offset = "0x16EDA64", VA = "0x16EDA64")]
	public CloudSave_ServerCoroutine_Login()
	{
	}
}
[Token(Token = "0x2000015")]
public class CloudSave_ServerCoroutine_OpenSSLSession : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83690C", Offset = "0x83690C")]
	private sealed class <Run>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_OpenSSLSession <>4__this;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWWwrapper <w>5__2;

		[Token(Token = "0x1700006D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x212E6B0", Offset = "0x212E6B0", VA = "0x212E6B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x212E6F8", Offset = "0x212E6F8", VA = "0x212E6F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x212DFC0", Offset = "0x212DFC0", VA = "0x212DFC0")]
		[DebuggerHidden]
		public <Run>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x212DFEC", Offset = "0x212DFEC", VA = "0x212DFEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x212DFF0", Offset = "0x212DFF0", VA = "0x212DFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x212E6B8", Offset = "0x212E6B8", VA = "0x212E6B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83691C", Offset = "0x83691C")]
	private sealed class <EstablishAESSecurity>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_OpenSSLSession <>4__this;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWWwrapper <w>5__2;

		[Token(Token = "0x1700006F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x212DF70", Offset = "0x212DF70", VA = "0x212DF70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x212DFB8", Offset = "0x212DFB8", VA = "0x212DFB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x212D900", Offset = "0x212D900", VA = "0x212D900")]
		[DebuggerHidden]
		public <EstablishAESSecurity>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x212D92C", Offset = "0x212D92C", VA = "0x212D92C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x212D930", Offset = "0x212D930", VA = "0x212D930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x212DF78", Offset = "0x212DF78", VA = "0x212DF78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int aesTry;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x16EDB54", Offset = "0x16EDB54", VA = "0x16EDB54", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x16EDB5C", Offset = "0x16EDB5C", VA = "0x16EDB5C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x16EDD3C", Offset = "0x16EDD3C", VA = "0x16EDD3C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838520", Offset = "0x838520")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x16EDDA8", Offset = "0x16EDDA8", VA = "0x16EDDA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838580", Offset = "0x838580")]
	protected IEnumerator EstablishAESSecurity()
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x16EDE14", Offset = "0x16EDE14", VA = "0x16EDE14")]
	public CloudSave_ServerCoroutine_OpenSSLSession()
	{
	}
}
[Token(Token = "0x2000016")]
public class CloudSave_ServerCoroutine_RedeemCode : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83692C", Offset = "0x83692C")]
	private sealed class <Run>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_RedeemCode <>4__this;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000071")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x212EDB8", Offset = "0x212EDB8", VA = "0x212EDB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x212EE00", Offset = "0x212EE00", VA = "0x212EE00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x212E700", Offset = "0x212E700", VA = "0x212E700")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x212E72C", Offset = "0x212E72C", VA = "0x212E72C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x212E730", Offset = "0x212E730", VA = "0x212E730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x212EDC0", Offset = "0x212EDC0", VA = "0x212EDC0", Slot = "8")]
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
	[Address(RVA = "0x16EDE1C", Offset = "0x16EDE1C", VA = "0x16EDE1C")]
	public void InitParams(string _code)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x16EDE24", Offset = "0x16EDE24", VA = "0x16EDE24", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x16EDE2C", Offset = "0x16EDE2C", VA = "0x16EDE2C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x16EDE34", Offset = "0x16EDE34", VA = "0x16EDE34")]
	public string GetResultSku()
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x16EDE3C", Offset = "0x16EDE3C", VA = "0x16EDE3C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8385E0", Offset = "0x8385E0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x16EDEA8", Offset = "0x16EDEA8", VA = "0x16EDEA8")]
	public CloudSave_ServerCoroutine_RedeemCode()
	{
	}
}
[Token(Token = "0x2000017")]
public class CloudSave_ServerCoroutine_SendResetPassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83693C", Offset = "0x83693C")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_SendResetPassword <>4__this;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x204E910", Offset = "0x204E910", VA = "0x204E910", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x204E958", Offset = "0x204E958", VA = "0x204E958", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x204E270", Offset = "0x204E270", VA = "0x204E270")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x204E29C", Offset = "0x204E29C", VA = "0x204E29C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x204E2A0", Offset = "0x204E2A0", VA = "0x204E2A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x204E918", Offset = "0x204E918", VA = "0x204E918", Slot = "8")]
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
	[Address(RVA = "0x16EDF00", Offset = "0x16EDF00", VA = "0x16EDF00")]
	public void InitParams(string _email)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x16EDF08", Offset = "0x16EDF08", VA = "0x16EDF08", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x16EDF10", Offset = "0x16EDF10", VA = "0x16EDF10", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x16EDF18", Offset = "0x16EDF18", VA = "0x16EDF18", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838640", Offset = "0x838640")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x16EDF84", Offset = "0x16EDF84", VA = "0x16EDF84")]
	public CloudSave_ServerCoroutine_SendResetPassword()
	{
	}
}
[Token(Token = "0x2000018")]
public class CloudSave_ServerCoroutine_SetNewsletter : CloudSave_ServerCoroutine
{
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83694C", Offset = "0x83694C")]
	private sealed class <Run>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_SetNewsletter <>4__this;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x204F030", Offset = "0x204F030", VA = "0x204F030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x204F078", Offset = "0x204F078", VA = "0x204F078", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x204E960", Offset = "0x204E960", VA = "0x204E960")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x204E98C", Offset = "0x204E98C", VA = "0x204E98C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x204E990", Offset = "0x204E990", VA = "0x204E990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x204F038", Offset = "0x204F038", VA = "0x204F038", Slot = "8")]
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
	[Address(RVA = "0x16EDFD8", Offset = "0x16EDFD8", VA = "0x16EDFD8")]
	public void InitParams(bool _signed)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x16EDFE4", Offset = "0x16EDFE4", VA = "0x16EDFE4", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x16EDFEC", Offset = "0x16EDFEC", VA = "0x16EDFEC", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x16EDFF4", Offset = "0x16EDFF4", VA = "0x16EDFF4", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8386A0", Offset = "0x8386A0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x16EE060", Offset = "0x16EE060", VA = "0x16EE060")]
	public CloudSave_ServerCoroutine_SetNewsletter()
	{
	}
}
[Token(Token = "0x2000019")]
public class CloudSave_ServerCoroutine_StoreGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83695C", Offset = "0x83695C")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_ServerCoroutine_StoreGameSave <>4__this;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSave_ServerCoroutine <openSLL>5__2;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWWwrapper <w>5__3;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x205022C", Offset = "0x205022C", VA = "0x205022C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x2050274", Offset = "0x2050274", VA = "0x2050274", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x204F080", Offset = "0x204F080", VA = "0x204F080")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x204F0AC", Offset = "0x204F0AC", VA = "0x204F0AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x204F0B0", Offset = "0x204F0B0", VA = "0x204F0B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x2050234", Offset = "0x2050234", VA = "0x2050234", Slot = "8")]
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
	[Address(RVA = "0x16EA49C", Offset = "0x16EA49C", VA = "0x16EA49C")]
	public void InitParams(CloudSave_Saves _storeSaves)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x16EE068", Offset = "0x16EE068", VA = "0x16EE068", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x16EE070", Offset = "0x16EE070", VA = "0x16EE070", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x16EE078", Offset = "0x16EE078", VA = "0x16EE078")]
	public CloudSave_Saves GetStoringSaves()
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x16EE080", Offset = "0x16EE080", VA = "0x16EE080", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838700", Offset = "0x838700")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x16EE0EC", Offset = "0x16EE0EC", VA = "0x16EE0EC")]
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
	[Address(RVA = "0x16271E0", Offset = "0x16271E0", VA = "0x16271E0", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1627428", Offset = "0x1627428", VA = "0x1627428", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x16274CC", Offset = "0x16274CC", VA = "0x16274CC", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x16275A8", Offset = "0x16275A8", VA = "0x16275A8", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x16277BC", Offset = "0x16277BC", VA = "0x16277BC")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1627824", Offset = "0x1627824", VA = "0x1627824")]
	public void OnSwitchShowOldPassword(bool on)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x16278E4", Offset = "0x16278E4", VA = "0x16278E4")]
	public void OnSwitchShowNewPassword(bool on)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x16278EC", Offset = "0x16278EC", VA = "0x16278EC")]
	public void OnSwitchShowRepeatPassword(bool on)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x162782C", Offset = "0x162782C", VA = "0x162782C")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x16278F4", Offset = "0x16278F4", VA = "0x16278F4")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1627C04", Offset = "0x1627C04", VA = "0x1627C04")]
	public CloudSave_Screen_ChangePassword()
	{
	}
}
[Token(Token = "0x200001B")]
public class CloudSave_Screen_CloudInfo : CloudSave_Screen
{
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83696C", Offset = "0x83696C")]
	private sealed class <AnimDotsCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_Screen_CloudInfo <>4__this;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <idx>5__2;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <startTime>5__3;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 <scaleFrom>5__4;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 <scaleTo>5__5;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x212B4C0", Offset = "0x212B4C0", VA = "0x212B4C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x212B508", Offset = "0x212B508", VA = "0x212B508", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x212B174", Offset = "0x212B174", VA = "0x212B174")]
		[DebuggerHidden]
		public <AnimDotsCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x212B1A0", Offset = "0x212B1A0", VA = "0x212B1A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x212B1A4", Offset = "0x212B1A4", VA = "0x212B1A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x212B4C8", Offset = "0x212B4C8", VA = "0x212B4C8", Slot = "8")]
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
	[Address(RVA = "0x1627C58", Offset = "0x1627C58", VA = "0x1627C58")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1627D54", Offset = "0x1627D54", VA = "0x1627D54")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1627D58", Offset = "0x1627D58", VA = "0x1627D58")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1627DF0", Offset = "0x1627DF0", VA = "0x1627DF0", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1627E18", Offset = "0x1627E18", VA = "0x1627E18", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1627E40", Offset = "0x1627E40", VA = "0x1627E40")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1627EA8", Offset = "0x1627EA8", VA = "0x1627EA8")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1627F0C", Offset = "0x1627F0C", VA = "0x1627F0C")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1627F70", Offset = "0x1627F70", VA = "0x1627F70")]
	public void OnClickCloseToLogin()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1627D84", Offset = "0x1627D84", VA = "0x1627D84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838760", Offset = "0x838760")]
	protected IEnumerator AnimDotsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1627FD8", Offset = "0x1627FD8", VA = "0x1627FD8")]
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
	[Address(RVA = "0x1627FE8", Offset = "0x1627FE8", VA = "0x1627FE8", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x16280D4", Offset = "0x16280D4", VA = "0x16280D4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1628178", Offset = "0x1628178", VA = "0x1628178", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1628254", Offset = "0x1628254", VA = "0x1628254", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x16283D4", Offset = "0x16283D4", VA = "0x16283D4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x162843C", Offset = "0x162843C", VA = "0x162843C")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1628494", Offset = "0x1628494", VA = "0x1628494")]
	public void OnClickDelete()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x16285E8", Offset = "0x16285E8", VA = "0x16285E8")]
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
		[Token(Token = "0x400043C")]
		Register,
		[Token(Token = "0x400043D")]
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
	[Address(RVA = "0x16285F0", Offset = "0x16285F0", VA = "0x16285F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1628668", Offset = "0x1628668", VA = "0x1628668")]
	private void Start()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x162866C", Offset = "0x162866C", VA = "0x162866C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1628D78", Offset = "0x1628D78", VA = "0x1628D78", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1628E1C", Offset = "0x1628E1C", VA = "0x1628E1C")]
	public void OnBackFromTermsOfUse(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1628FB0", Offset = "0x1628FB0", VA = "0x1628FB0")]
	public void OnBackFromTermsOfUseLogin(string _email, string _password, bool _newsletter, CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x16294D4", Offset = "0x16294D4", VA = "0x16294D4", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x16295B0", Offset = "0x16295B0", VA = "0x16295B0", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1628FE4", Offset = "0x1628FE4", VA = "0x1628FE4")]
	protected void OnEndCoroutine(CloudSave_ServerCoroutine coroutine, bool fromTermsOfUse)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1628AF8", Offset = "0x1628AF8", VA = "0x1628AF8")]
	private void UpdateModeFields()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1628970", Offset = "0x1628970", VA = "0x1628970")]
	private void LoadFromPlayerPrefs()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x162969C", Offset = "0x162969C", VA = "0x162969C")]
	private void OnLogin(bool confirmDeleteSaveOnRegister)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1629CD0", Offset = "0x1629CD0", VA = "0x1629CD0")]
	private void DeleteSaveOnRegisterCallback(bool result)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1629DEC", Offset = "0x1629DEC", VA = "0x1629DEC")]
	private void DeleteSaveOnLoginToEmptyCallback(bool result)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1629F10", Offset = "0x1629F10", VA = "0x1629F10")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1629F74", Offset = "0x1629F74", VA = "0x1629F74")]
	public void OnClickShowInfo()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1624AB0", Offset = "0x1624AB0", VA = "0x1624AB0")]
	public void OnClickSwitchLogin(bool switched)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1624A28", Offset = "0x1624A28", VA = "0x1624A28")]
	public void OnClickSwitchRegister(bool switched)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1628D70", Offset = "0x1628D70", VA = "0x1628D70")]
	public void OnClickLogin()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1629FDC", Offset = "0x1629FDC", VA = "0x1629FDC")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x162A094", Offset = "0x162A094", VA = "0x162A094")]
	public void OnSwitchShowPassword1(bool on)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x162A128", Offset = "0x162A128", VA = "0x162A128")]
	public void OnSwitchShowPassword2(bool on)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x162A09C", Offset = "0x162A09C", VA = "0x162A09C")]
	public void OnSwitchShowPassword(int num, bool on)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x162A130", Offset = "0x162A130", VA = "0x162A130")]
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
	[Address(RVA = "0x16E899C", Offset = "0x16E899C", VA = "0x16E899C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x16E9278", Offset = "0x16E9278", VA = "0x16E9278", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x16E938C", Offset = "0x16E938C", VA = "0x16E938C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x16E94BC", Offset = "0x16E94BC", VA = "0x16E94BC", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x16E9638", Offset = "0x16E9638", VA = "0x16E9638", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x16E97E0", Offset = "0x16E97E0", VA = "0x16E97E0")]
	protected void OnEndCoroutineLoad()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x16E9910", Offset = "0x16E9910", VA = "0x16E9910")]
	protected void OnEndCoroutineStore()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x16E8EC8", Offset = "0x16E8EC8", VA = "0x16E8EC8")]
	protected void EnableImportExportButtons(bool import, bool export)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x16E8CB4", Offset = "0x16E8CB4", VA = "0x16E8CB4")]
	protected void FillLoginInfo()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x16E8FD4", Offset = "0x16E8FD4", VA = "0x16E8FD4")]
	protected void UpdateAfterReceivedCloudSave()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x16E9F88", Offset = "0x16E9F88", VA = "0x16E9F88")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x16E9FF4", Offset = "0x16E9FF4", VA = "0x16E9FF4")]
	public void OnClickSettings()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x16EA060", Offset = "0x16EA060", VA = "0x16EA060")]
	public void OnSwitchShowEmail(bool on)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x16EA064", Offset = "0x16EA064", VA = "0x16EA064")]
	public void OnClickSetPassword()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x16EA124", Offset = "0x16EA124", VA = "0x16EA124")]
	public void OnClickLogout()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x16EA1E4", Offset = "0x16EA1E4", VA = "0x16EA1E4")]
	public void OnClickImport()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x16E9D2C", Offset = "0x16E9D2C", VA = "0x16E9D2C")]
	public void OnClickExport()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x16EA4B8", Offset = "0x16EA4B8", VA = "0x16EA4B8")]
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
	[Address(RVA = "0x16EA51C", Offset = "0x16EA51C", VA = "0x16EA51C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x16EA544", Offset = "0x16EA544", VA = "0x16EA544", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x16EA56C", Offset = "0x16EA56C", VA = "0x16EA56C")]
	public void Init(string text, bool okcancel, bool warning, CloudSave_Screen _backToScreen, Action<bool> _resultCallback)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x16EA6B4", Offset = "0x16EA6B4", VA = "0x16EA6B4")]
	public void OnClickOK()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x16EA72C", Offset = "0x16EA72C", VA = "0x16EA72C")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x16EA7A4", Offset = "0x16EA7A4", VA = "0x16EA7A4")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x16EA81C", Offset = "0x16EA81C", VA = "0x16EA81C")]
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
	[Address(RVA = "0x16EA824", Offset = "0x16EA824", VA = "0x16EA824", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x16EA8A4", Offset = "0x16EA8A4", VA = "0x16EA8A4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x16EA944", Offset = "0x16EA944", VA = "0x16EA944", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x16EAA24", Offset = "0x16EAA24", VA = "0x16EAA24", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x16EACCC", Offset = "0x16EACCC", VA = "0x16EACCC")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x16EAD38", Offset = "0x16EAD38", VA = "0x16EAD38")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x16EAF18", Offset = "0x16EAF18", VA = "0x16EAF18")]
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
	[Address(RVA = "0x16EAF6C", Offset = "0x16EAF6C", VA = "0x16EAF6C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x16EB1E8", Offset = "0x16EB1E8", VA = "0x16EB1E8", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x16EB288", Offset = "0x16EB288", VA = "0x16EB288")]
	public void Init(bool _backToSettings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x16EB294", Offset = "0x16EB294", VA = "0x16EB294", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x16EB374", Offset = "0x16EB374", VA = "0x16EB374", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x16EB4EC", Offset = "0x16EB4EC", VA = "0x16EB4EC")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x16EB560", Offset = "0x16EB560", VA = "0x16EB560")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x16EB828", Offset = "0x16EB828", VA = "0x16EB828")]
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
	[Address(RVA = "0x16EB87C", Offset = "0x16EB87C", VA = "0x16EB87C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x16EB970", Offset = "0x16EB970", VA = "0x16EB970", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x16EBA10", Offset = "0x16EBA10", VA = "0x16EBA10", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x16EBAF0", Offset = "0x16EBAF0", VA = "0x16EBAF0", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x16EBC08", Offset = "0x16EBC08", VA = "0x16EBC08")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x16EBDC4", Offset = "0x16EBDC4", VA = "0x16EBDC4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x16EBE30", Offset = "0x16EBE30", VA = "0x16EBE30")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x16EBE9C", Offset = "0x16EBE9C", VA = "0x16EBE9C")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x16EBF08", Offset = "0x16EBF08", VA = "0x16EBF08")]
	public void OnClickDeleteAccount()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x16EBF74", Offset = "0x16EBF74", VA = "0x16EBF74")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x16EBFE0", Offset = "0x16EBFE0", VA = "0x16EBFE0")]
	public void OnSwitchNewsletter(bool signed)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x16EC170", Offset = "0x16EC170", VA = "0x16EC170")]
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
	[Address(RVA = "0x16EC178", Offset = "0x16EC178", VA = "0x16EC178", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x16EC1A0", Offset = "0x16EC1A0", VA = "0x16EC1A0", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x16EC240", Offset = "0x16EC240", VA = "0x16EC240")]
	public void Init(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x16EC250", Offset = "0x16EC250", VA = "0x16EC250", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x16EC330", Offset = "0x16EC330", VA = "0x16EC330", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x16EC584", Offset = "0x16EC584", VA = "0x16EC584", Slot = "12")]
	public override void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x16EC5EC", Offset = "0x16EC5EC", VA = "0x16EC5EC", Slot = "13")]
	public override void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x16EC5FC", Offset = "0x16EC5FC", VA = "0x16EC5FC")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x16EC74C", Offset = "0x16EC74C", VA = "0x16EC74C")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x16EC7E0", Offset = "0x16EC7E0", VA = "0x16EC7E0")]
	public CloudSave_Screen_TermsOfUse()
	{
	}
}
[Token(Token = "0x2000024")]
public class CloudSave_AdjustIconToText : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83697C", Offset = "0x83697C")]
	private sealed class <AdjustToTextCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CloudSave_AdjustIconToText <>4__this;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x212B124", Offset = "0x212B124", VA = "0x212B124", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x212B16C", Offset = "0x212B16C", VA = "0x212B16C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x212AB94", Offset = "0x212AB94", VA = "0x212AB94")]
		[DebuggerHidden]
		public <AdjustToTextCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x212ABC0", Offset = "0x212ABC0", VA = "0x212ABC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x212ABC4", Offset = "0x212ABC4", VA = "0x212ABC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x212B12C", Offset = "0x212B12C", VA = "0x212B12C", Slot = "8")]
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
	[Address(RVA = "0x1621018", Offset = "0x1621018", VA = "0x1621018")]
	public void Start()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1621044", Offset = "0x1621044", VA = "0x1621044")]
	private void AdjustToText()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1621070", Offset = "0x1621070", VA = "0x1621070")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8387C0", Offset = "0x8387C0")]
	public IEnumerator AdjustToTextCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x16210DC", Offset = "0x16210DC", VA = "0x16210DC")]
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
		[Address(RVA = "0x16210E4", Offset = "0x16210E4", VA = "0x16210E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x16210EC", Offset = "0x16210EC", VA = "0x16210EC")]
		set
		{
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1621238", Offset = "0x1621238", VA = "0x1621238")]
	private void Start()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x16210F8", Offset = "0x16210F8", VA = "0x16210F8")]
	private void changeMaterial()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x16212A0", Offset = "0x16212A0", VA = "0x16212A0")]
	public void changeOtherMaterial(Material m)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x16213A0", Offset = "0x16213A0", VA = "0x16213A0")]
	private void Click()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x16214A8", Offset = "0x16214A8", VA = "0x16214A8")]
	public void SetChecked(bool on)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x16214B4", Offset = "0x16214B4", VA = "0x16214B4")]
	public void SetCallbackWithObject(bool on)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x16214C0", Offset = "0x16214C0", VA = "0x16214C0")]
	public void SetCustomParam(string param)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x16214C8", Offset = "0x16214C8", VA = "0x16214C8")]
	public string GetCustomParam()
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x16214D0", Offset = "0x16214D0", VA = "0x16214D0")]
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

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1626218", Offset = "0x1626218", VA = "0x1626218")]
	public void ShowText(string txt, bool warning)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x16249C0", Offset = "0x16249C0", VA = "0x16249C0")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x16263BC", Offset = "0x16263BC", VA = "0x16263BC")]
	public bool IsWarning()
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x16263C4", Offset = "0x16263C4", VA = "0x16263C4")]
	public CloudSave_InfoMessage()
	{
	}
}
[Token(Token = "0x2000027")]
public interface IMUIHoverable
{
	[Token(Token = "0x600016F")]
	void OnHover(Vector3 point);

	[Token(Token = "0x6000170")]
	void OnMove(Vector3 point);

	[Token(Token = "0x6000171")]
	void OnClick(Vector3 point);

	[Token(Token = "0x6000172")]
	void OnLeave();
}
[Token(Token = "0x2000028")]
public class MUI_Button : MonoBehaviour
{
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1F85990", Offset = "0x1F85990", VA = "0x1F85990")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1F85A68", Offset = "0x1F85A68", VA = "0x1F85A68")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1F85D00", Offset = "0x1F85D00", VA = "0x1F85D00")]
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
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BoxCollider box;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 center;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 size;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Bounds bounds;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2053B54", Offset = "0x2053B54", VA = "0x2053B54")]
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

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1F85D08", Offset = "0x1F85D08", VA = "0x1F85D08")]
	public static void UpdateMaterialsForObjectsWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1F860D8", Offset = "0x1F860D8", VA = "0x1F860D8")]
	public static void UpdateMaterialForObjectWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1F8635C", Offset = "0x1F8635C", VA = "0x1F8635C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1F868C8", Offset = "0x1F868C8", VA = "0x1F868C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1F86968", Offset = "0x1F86968", VA = "0x1F86968")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1F86AF4", Offset = "0x1F86AF4", VA = "0x1F86AF4")]
	private void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1F86B70", Offset = "0x1F86B70", VA = "0x1F86B70")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1F86CE0", Offset = "0x1F86CE0", VA = "0x1F86CE0")]
	private Vector2 Scale()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1F86D58", Offset = "0x1F86D58", VA = "0x1F86D58")]
	public static Vector2 Scale(GameObject go, bool inclSelfScale)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1F86E4C", Offset = "0x1F86E4C", VA = "0x1F86E4C")]
	public void ContentsChanged()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1F86E64", Offset = "0x1F86E64", VA = "0x1F86E64")]
	public void SetKeepMinOrgScrollSize(bool s)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1F868B4", Offset = "0x1F868B4", VA = "0x1F868B4")]
	public void AutoAdjustToContents(bool adjustAfterChanges = true)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1F86E70", Offset = "0x1F86E70", VA = "0x1F86E70")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1F87280", Offset = "0x1F87280", VA = "0x1F87280")]
	public void FreezeScroll(bool freeze)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1F8728C", Offset = "0x1F8728C", VA = "0x1F8728C")]
	public bool HaveClippedContents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1F872E8", Offset = "0x1F872E8", VA = "0x1F872E8")]
	public bool HaveClippedContentsX()
	{
		return default(bool);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1F87314", Offset = "0x1F87314", VA = "0x1F87314")]
	public bool HaveClippedContentsY()
	{
		return default(bool);
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1F87340", Offset = "0x1F87340", VA = "0x1F87340")]
	public bool IsScreenPointInBounds(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1F874DC", Offset = "0x1F874DC", VA = "0x1F874DC")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1F875E0", Offset = "0x1F875E0", VA = "0x1F875E0")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1F87690", Offset = "0x1F87690", VA = "0x1F87690")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1F876EC", Offset = "0x1F876EC", VA = "0x1F876EC")]
	public void ScrollToTop()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1F8774C", Offset = "0x1F8774C", VA = "0x1F8774C")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1F877AC", Offset = "0x1F877AC", VA = "0x1F877AC")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1F87814", Offset = "0x1F87814", VA = "0x1F87814")]
	public bool IsScrolledToY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1F87888", Offset = "0x1F87888", VA = "0x1F87888")]
	public bool IsInsideClipAreaY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1F878F0", Offset = "0x1F878F0", VA = "0x1F878F0")]
	public bool IsDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1F878F8", Offset = "0x1F878F8", VA = "0x1F878F8")]
	public void EnsureVisible(Vector3 pos)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1F87AE0", Offset = "0x1F87AE0", VA = "0x1F87AE0")]
	public bool IsClippedOutColChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1F87BE8", Offset = "0x1F87BE8", VA = "0x1F87BE8")]
	public bool IsClippedOutRendChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1F87CF0", Offset = "0x1F87CF0", VA = "0x1F87CF0")]
	public void AddIgnoredNotClippedChild(GameObject go)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1F87D54", Offset = "0x1F87D54", VA = "0x1F87D54")]
	private bool IsIgnoredNotClippedChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1F87E44", Offset = "0x1F87E44", VA = "0x1F87E44")]
	public void SetExtendHorzSizeToScreen()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1F87E50", Offset = "0x1F87E50", VA = "0x1F87E50")]
	public void SetZoomContents(GameObject rootObj, float min, float max, float speed)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1F87E64", Offset = "0x1F87E64", VA = "0x1F87E64")]
	public bool HaveZoomContents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1F87ED0", Offset = "0x1F87ED0", VA = "0x1F87ED0")]
	public static MUI_ClippedScroll GetActiveScroll(Vector2 atPoint)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1F88094", Offset = "0x1F88094", VA = "0x1F88094")]
	private void Update()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1F891E4", Offset = "0x1F891E4", VA = "0x1F891E4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1F898A0", Offset = "0x1F898A0", VA = "0x1F898A0")]
	private void ClipBkgToScreen()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1F88454", Offset = "0x1F88454", VA = "0x1F88454")]
	private void AdjustHorzSizeToScreen()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1F894B0", Offset = "0x1F894B0", VA = "0x1F894B0")]
	private void AdjustScrollSizeToContents()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1F8A62C", Offset = "0x1F8A62C", VA = "0x1F8A62C")]
	private void UpdateMaterials(GameObject go, ref Bounds mergedBounds)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1F8B2F4", Offset = "0x1F8B2F4", VA = "0x1F8B2F4")]
	private BoxColliderInfo GetBoxColliderOrgSize(BoxCollider box, Vector2 scale)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1F8B56C", Offset = "0x1F8B56C", VA = "0x1F8B56C")]
	private void UpdateBounds(GameObject go)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1F87AFC", Offset = "0x1F87AFC", VA = "0x1F87AFC")]
	private int GetClippedOutColChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1F87C04", Offset = "0x1F87C04", VA = "0x1F87C04")]
	private int GetClippedOutRendChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1F89EFC", Offset = "0x1F89EFC", VA = "0x1F89EFC")]
	private void UpdateAfterChanged()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1F86F10", Offset = "0x1F86F10", VA = "0x1F86F10")]
	private void UpdateScroll()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1F874E0", Offset = "0x1F874E0", VA = "0x1F874E0")]
	private void Scroll(float x, float y)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1F8C230", Offset = "0x1F8C230", VA = "0x1F8C230")]
	private Vector2 ScreenPointToWorldPos(Vector2 p)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1F87370", Offset = "0x1F87370", VA = "0x1F87370")]
	private bool IsScreenPointInClipArea(Vector3 p)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1F8C4A4", Offset = "0x1F8C4A4", VA = "0x1F8C4A4")]
	public void OnScrollBarDown(MUI_ClippedScroll_Bar bar, bool down)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1F88788", Offset = "0x1F88788", VA = "0x1F88788")]
	private void StepDrag()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1F88E68", Offset = "0x1F88E68", VA = "0x1F88E68")]
	private void StepScrollMouseWheel()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1F89004", Offset = "0x1F89004", VA = "0x1F89004")]
	private void StepZoom()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1F8C5FC", Offset = "0x1F8C5FC", VA = "0x1F8C5FC")]
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

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1F8C790", Offset = "0x1F8C790", VA = "0x1F8C790")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1F8C7F4", Offset = "0x1F8C7F4", VA = "0x1F8C7F4")]
	public void Down()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1F8C884", Offset = "0x1F8C884", VA = "0x1F8C884")]
	public void Up()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1F8C914", Offset = "0x1F8C914", VA = "0x1F8C914")]
	public void Click()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1F8C9A4", Offset = "0x1F8C9A4", VA = "0x1F8C9A4")]
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

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1621010", Offset = "0x1621010", VA = "0x1621010")]
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

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1621008", Offset = "0x1621008", VA = "0x1621008")]
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

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1F8C9AC", Offset = "0x1F8C9AC", VA = "0x1F8C9AC")]
	public MUI_ClippedScroll_Materials()
	{
	}
}
[Token(Token = "0x200002E")]
public class MUI_Continous : MonoBehaviour
{
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1F8C9B4", Offset = "0x1F8C9B4", VA = "0x1F8C9B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1F8CA7C", Offset = "0x1F8CA7C", VA = "0x1F8CA7C")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1F8CD14", Offset = "0x1F8CD14", VA = "0x1F8CD14")]
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

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x161F084", Offset = "0x161F084", VA = "0x161F084")]
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

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1F8CD1C", Offset = "0x1F8CD1C", VA = "0x1F8CD1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1F8CD84", Offset = "0x1F8CD84", VA = "0x1F8CD84")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1F8D0EC", Offset = "0x1F8D0EC", VA = "0x1F8D0EC")]
	public static LayerMask GetMUIlayerMask()
	{
		return default(LayerMask);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1F8D150", Offset = "0x1F8D150", VA = "0x1F8D150")]
	public static Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1F8D1B4", Offset = "0x1F8D1B4", VA = "0x1F8D1B4")]
	public static void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1F8D21C", Offset = "0x1F8D21C", VA = "0x1F8D21C")]
	public static void ClearLayerMask()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1F8D294", Offset = "0x1F8D294", VA = "0x1F8D294")]
	public static bool WasNowClickDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1F8CFE0", Offset = "0x1F8CFE0", VA = "0x1F8CFE0")]
	public static void AddLayer(string layer)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x1F8D2F8", Offset = "0x1F8D2F8", VA = "0x1F8D2F8")]
	public static void RemoveLayer(string layer)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1F8D468", Offset = "0x1F8D468", VA = "0x1F8D468")]
	public static bool IsDraggingItem()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1F8D5CC", Offset = "0x1F8D5CC", VA = "0x1F8D5CC")]
	private void Zoom()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1F8DB58", Offset = "0x1F8DB58", VA = "0x1F8DB58")]
	private void Drag()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1F8E428", Offset = "0x1F8E428", VA = "0x1F8E428")]
	private bool IsChildOfActiveScroll(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1F8E51C", Offset = "0x1F8E51C", VA = "0x1F8E51C")]
	private bool FingerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1F8E618", Offset = "0x1F8E618", VA = "0x1F8E618")]
	private bool FingerUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1F8E700", Offset = "0x1F8E700", VA = "0x1F8E700")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1F8E9A8", Offset = "0x1F8E9A8", VA = "0x1F8E9A8")]
	private void CastRay(bool down, bool up, bool move)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1F8F0E8", Offset = "0x1F8F0E8", VA = "0x1F8F0E8")]
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
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1620FF0", Offset = "0x1620FF0", VA = "0x1620FF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1620FF8", Offset = "0x1620FF8", VA = "0x1620FF8")]
		set
		{
		}
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1621000", Offset = "0x1621000", VA = "0x1621000")]
	public ClipboardHelper()
	{
	}
}
[Token(Token = "0x2000032")]
public class MUI_InputText : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83698C", Offset = "0x83698C")]
	private sealed class <ReadKbdInputCoroutine>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MUI_InputText <>4__this;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int initCursorPos;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <oldText>5__2;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <stop>5__3;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool <touchKbdEnter>5__4;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <prevBefore>5__5;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <prevAfter>5__6;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MUI_InputText <nextInput>5__7;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x2054D24", Offset = "0x2054D24", VA = "0x2054D24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x2054D6C", Offset = "0x2054D6C", VA = "0x2054D6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2053B5C", Offset = "0x2053B5C", VA = "0x2053B5C")]
		[DebuggerHidden]
		public <ReadKbdInputCoroutine>d__74(int <>1__state)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2053B88", Offset = "0x2053B88", VA = "0x2053B88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2053B8C", Offset = "0x2053B8C", VA = "0x2053B8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2054D2C", Offset = "0x2054D2C", VA = "0x2054D2C", Slot = "8")]
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
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1F8F5A4", Offset = "0x1F8F5A4", VA = "0x1F8F5A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1F8F5AC", Offset = "0x1F8F5AC", VA = "0x1F8F5AC")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action SystemKeyboardShow
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1F8F1C4", Offset = "0x1F8F1C4", VA = "0x1F8F1C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838820", Offset = "0x838820")]
		add
		{
		}
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1F8F2BC", Offset = "0x1F8F2BC", VA = "0x1F8F2BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838830", Offset = "0x838830")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event Action SystemKeyboardHide
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1F8F3B4", Offset = "0x1F8F3B4", VA = "0x1F8F3B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838840", Offset = "0x838840")]
		add
		{
		}
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1F8F4AC", Offset = "0x1F8F4AC", VA = "0x1F8F4AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838850", Offset = "0x838850")]
		remove
		{
		}
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1F8FB94", Offset = "0x1F8FB94", VA = "0x1F8FB94")]
	public static bool IsOpenedSystemKeyboard()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1F8FBF8", Offset = "0x1F8FBF8", VA = "0x1F8FBF8")]
	public static bool IsCurrentInputActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1F8FC98", Offset = "0x1F8FC98", VA = "0x1F8FC98")]
	public void SetIsInputOfScreenKeyboard(MUI_ScreenKeyboard owner)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1F8FCA0", Offset = "0x1F8FCA0", VA = "0x1F8FCA0")]
	public void SetAllowInputInScreenKeyboard()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1F8FCAC", Offset = "0x1F8FCAC", VA = "0x1F8FCAC")]
	public void AddScreenKeyboardInput(char c)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1F8FD9C", Offset = "0x1F8FD9C", VA = "0x1F8FD9C")]
	public void SetKeyboardInputActive(bool active)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1F8FF30", Offset = "0x1F8FF30", VA = "0x1F8FF30")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1F900A4", Offset = "0x1F900A4", VA = "0x1F900A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1F90148", Offset = "0x1F90148", VA = "0x1F90148")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1F90170", Offset = "0x1F90170", VA = "0x1F90170")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1F903BC", Offset = "0x1F903BC", VA = "0x1F903BC")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x1F9057C", Offset = "0x1F9057C", VA = "0x1F9057C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1F905A8", Offset = "0x1F905A8", VA = "0x1F905A8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1F905AC", Offset = "0x1F905AC", VA = "0x1F905AC")]
	private void Down()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1F905B4", Offset = "0x1F905B4", VA = "0x1F905B4")]
	protected MUI_Show_ScreenKeyboard GetShowKbdComponent(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1F908E0", Offset = "0x1F908E0", VA = "0x1F908E0")]
	private void ControllerClick()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1F8FDB8", Offset = "0x1F8FDB8", VA = "0x1F8FDB8")]
	private void Click()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1F908E8", Offset = "0x1F908E8", VA = "0x1F908E8")]
	private void DoClick(bool fromController)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1F8FDC0", Offset = "0x1F8FDC0", VA = "0x1F8FDC0")]
	protected void CloseKeyboard()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1F90DDC", Offset = "0x1F90DDC", VA = "0x1F90DDC")]
	protected string GetPastedClipboardText()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1F90E40", Offset = "0x1F90E40", VA = "0x1F90E40")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1F90E48", Offset = "0x1F90E48", VA = "0x1F90E48")]
	public void UpdateText()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1F8F5C4", Offset = "0x1F8F5C4", VA = "0x1F8F5C4")]
	public void SetText(string _t, int cursorPos)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1F91248", Offset = "0x1F91248", VA = "0x1F91248")]
	private void SetTextMesh(string txt)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1F90E8C", Offset = "0x1F90E8C", VA = "0x1F90E8C")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1F91198", Offset = "0x1F91198", VA = "0x1F91198")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1F91318", Offset = "0x1F91318", VA = "0x1F91318")]
	protected void CreateCursor()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1F90D1C", Offset = "0x1F90D1C", VA = "0x1F90D1C")]
	protected void DestroyCursor()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1F9164C", Offset = "0x1F9164C", VA = "0x1F9164C")]
	private bool IsTouchKeyboardActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1F90CA0", Offset = "0x1F90CA0", VA = "0x1F90CA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838860", Offset = "0x838860")]
	private IEnumerator ReadKbdInputCoroutine(int initCursorPos)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1F91660", Offset = "0x1F91660", VA = "0x1F91660")]
	protected MUI_InputText FindNextInputText()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1F919B4", Offset = "0x1F919B4", VA = "0x1F919B4")]
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
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1F881F4", Offset = "0x1F881F4", VA = "0x1F881F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public static int height
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1F88324", Offset = "0x1F88324", VA = "0x1F88324")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1F91A74", Offset = "0x1F91A74", VA = "0x1F91A74")]
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

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1F91A80", Offset = "0x1F91A80", VA = "0x1F91A80", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1F91A84", Offset = "0x1F91A84", VA = "0x1F91A84", Slot = "5")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1F91A88", Offset = "0x1F91A88", VA = "0x1F91A88")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1F9266C", Offset = "0x1F9266C", VA = "0x1F9266C", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1F92670", Offset = "0x1F92670", VA = "0x1F92670")]
	public void Show(MUI_InputText _fillInput, string label, GameObject _hideScreen)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1F92820", Offset = "0x1F92820", VA = "0x1F92820")]
	public void CancelKeyboard()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1F9287C", Offset = "0x1F9287C", VA = "0x1F9287C", Slot = "7")]
	public virtual void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1F92A94", Offset = "0x1F92A94", VA = "0x1F92A94", Slot = "8")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1F92B40", Offset = "0x1F92B40", VA = "0x1F92B40", Slot = "9")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1F92C2C", Offset = "0x1F92C2C", VA = "0x1F92C2C", Slot = "10")]
	public virtual void OnInputEnter()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1F92C78", Offset = "0x1F92C78", VA = "0x1F92C78")]
	public void OnKeyPressed(string skey)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1F93124", Offset = "0x1F93124", VA = "0x1F93124")]
	protected GameObject FindObject(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1F92EDC", Offset = "0x1F92EDC", VA = "0x1F92EDC")]
	protected int FindKeyIndex(string skey)
	{
		return default(int);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1F91B80", Offset = "0x1F91B80", VA = "0x1F91B80")]
	protected void InitTextKeys()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1F92FE4", Offset = "0x1F92FE4", VA = "0x1F92FE4")]
	protected char GetCurrentKey(int i)
	{
		return default(char);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1F92320", Offset = "0x1F92320", VA = "0x1F92320")]
	protected void FillTextKeys()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1F929A8", Offset = "0x1F929A8", VA = "0x1F929A8")]
	protected string TrimEndLineCharacters(string text)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1F93490", Offset = "0x1F93490", VA = "0x1F93490")]
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

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1F935EC", Offset = "0x1F935EC", VA = "0x1F935EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1F935F0", Offset = "0x1F935F0", VA = "0x1F935F0")]
	private void DoInit()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1F93670", Offset = "0x1F93670", VA = "0x1F93670")]
	private void Start()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1F9375C", Offset = "0x1F9375C", VA = "0x1F9375C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1F937F4", Offset = "0x1F937F4", VA = "0x1F937F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1F8E3BC", Offset = "0x1F8E3BC", VA = "0x1F8E3BC")]
	public static bool IsAnyScrollActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1F93934", Offset = "0x1F93934", VA = "0x1F93934")]
	public static bool IsAnyScrollingInBoundary()
	{
		return default(bool);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1F93998", Offset = "0x1F93998", VA = "0x1F93998")]
	public void ResetOrgPos(Vector3 org)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1F939A4", Offset = "0x1F939A4", VA = "0x1F939A4")]
	public void SetSizeMinY(float y)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1F939AC", Offset = "0x1F939AC", VA = "0x1F939AC")]
	public void SetSize(Vector2 _size)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1F939F8", Offset = "0x1F939F8", VA = "0x1F939F8")]
	public void SetOffset(Vector2 _offset)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1F936B4", Offset = "0x1F936B4", VA = "0x1F936B4")]
	public void ResetScroll()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1F93B3C", Offset = "0x1F93B3C", VA = "0x1F93B3C")]
	public void AutoCalculateSize()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1F94404", Offset = "0x1F94404", VA = "0x1F94404")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x1F94470", Offset = "0x1F94470", VA = "0x1F94470")]
	private void Update()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1F9497C", Offset = "0x1F9497C", VA = "0x1F9497C")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1F949A8", Offset = "0x1F949A8", VA = "0x1F949A8")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1F94A20", Offset = "0x1F94A20", VA = "0x1F94A20")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1F94A98", Offset = "0x1F94A98", VA = "0x1F94A98")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1F94B40", Offset = "0x1F94B40", VA = "0x1F94B40")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1F94BA0", Offset = "0x1F94BA0", VA = "0x1F94BA0")]
	public bool IsAllOnScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1F93A38", Offset = "0x1F93A38", VA = "0x1F93A38")]
	public void Clamp()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1F94BD0", Offset = "0x1F94BD0", VA = "0x1F94BD0")]
	public void UpdateZoom()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1F9430C", Offset = "0x1F9430C", VA = "0x1F9430C")]
	public static Vector2 GetFrustrumSizeAt(Camera cam)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x1F94C30", Offset = "0x1F94C30", VA = "0x1F94C30")]
	public void EnsureVisible(Vector3 point)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1F9503C", Offset = "0x1F9503C", VA = "0x1F9503C")]
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

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1F90B28", Offset = "0x1F90B28", VA = "0x1F90B28")]
	public void Click()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x1F950AC", Offset = "0x1F950AC", VA = "0x1F950AC")]
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

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x1F95100", Offset = "0x1F95100", VA = "0x1F95100")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1F95128", Offset = "0x1F95128", VA = "0x1F95128")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1F95220", Offset = "0x1F95220", VA = "0x1F95220")]
	public void SetValChangedCallback(Action<MUI_Slider, float> callback)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1F95228", Offset = "0x1F95228", VA = "0x1F95228")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1F95230", Offset = "0x1F95230", VA = "0x1F95230")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1F95274", Offset = "0x1F95274", VA = "0x1F95274")]
	public float GetVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1F952F4", Offset = "0x1F952F4", VA = "0x1F952F4")]
	public void SetVal(float v)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1F95138", Offset = "0x1F95138", VA = "0x1F95138")]
	private void UpdateSquarePos()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1F953A4", Offset = "0x1F953A4", VA = "0x1F953A4")]
	private void Down()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1F95534", Offset = "0x1F95534", VA = "0x1F95534")]
	private void Click()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1F95538", Offset = "0x1F95538", VA = "0x1F95538")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1F953A8", Offset = "0x1F953A8", VA = "0x1F953A8")]
	private void Process()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1F9553C", Offset = "0x1F9553C", VA = "0x1F9553C")]
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

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x1F95550", Offset = "0x1F95550", VA = "0x1F95550")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1F95648", Offset = "0x1F95648", VA = "0x1F95648")]
	public void SetValChangedCallback(Action<MUI_SliderVertical, float, float> callback)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x1F95650", Offset = "0x1F95650", VA = "0x1F95650")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1F95658", Offset = "0x1F95658", VA = "0x1F95658")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x1F9569C", Offset = "0x1F9569C", VA = "0x1F9569C")]
	private void Update()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x1F95560", Offset = "0x1F95560", VA = "0x1F95560")]
	public void UpdateSquarePos()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1F9598C", Offset = "0x1F9598C", VA = "0x1F9598C")]
	private void Down()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x1F95990", Offset = "0x1F95990", VA = "0x1F95990")]
	private void Click()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1F95994", Offset = "0x1F95994", VA = "0x1F95994")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1F9572C", Offset = "0x1F9572C", VA = "0x1F9572C")]
	private void Process()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1F95998", Offset = "0x1F95998", VA = "0x1F95998")]
	public MUI_SliderVertical()
	{
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x836554", Offset = "0x836554")]
public class MUI_Sound : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class SoundParameters
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioClip clip;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float pitch;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x2054D74", Offset = "0x2054D74", VA = "0x2054D74")]
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

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x1F959AC", Offset = "0x1F959AC", VA = "0x1F959AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1F95B1C", Offset = "0x1F95B1C", VA = "0x1F95B1C")]
	private static void FindInstance()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x1F95CAC", Offset = "0x1F95CAC", VA = "0x1F95CAC")]
	public static void Play(int num)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1F95DF0", Offset = "0x1F95DF0", VA = "0x1F95DF0")]
	private void Play()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1F95F48", Offset = "0x1F95F48", VA = "0x1F95F48")]
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

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x1F95F5C", Offset = "0x1F95F5C", VA = "0x1F95F5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1F96148", Offset = "0x1F96148", VA = "0x1F96148")]
	private void Down()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1F963D0", Offset = "0x1F963D0", VA = "0x1F963D0")]
	private void Up()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1F96584", Offset = "0x1F96584", VA = "0x1F96584")]
	private void Click()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1F965F8", Offset = "0x1F965F8", VA = "0x1F965F8")]
	private void IsDown(BoolRef isDown)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1F96614", Offset = "0x1F96614", VA = "0x1F96614")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1F96624", Offset = "0x1F96624", VA = "0x1F96624")]
	public bool IsDisabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1F9662C", Offset = "0x1F9662C", VA = "0x1F9662C")]
	public void Disable()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1F96858", Offset = "0x1F96858", VA = "0x1F96858")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1F96A58", Offset = "0x1F96A58", VA = "0x1F96A58")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x1F96A64", Offset = "0x1F96A64", VA = "0x1F96A64")]
	public void SetDisabled(bool disabled)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1F96A70", Offset = "0x1F96A70", VA = "0x1F96A70")]
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

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x1F96AA8", Offset = "0x1F96AA8", VA = "0x1F96AA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1F96B20", Offset = "0x1F96B20", VA = "0x1F96B20")]
	private void Start()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1F96F7C", Offset = "0x1F96F7C", VA = "0x1F96F7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1F96F80", Offset = "0x1F96F80", VA = "0x1F96F80")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x1F96B24", Offset = "0x1F96B24", VA = "0x1F96B24")]
	public void Calculate()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1F973D4", Offset = "0x1F973D4", VA = "0x1F973D4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1F970A8", Offset = "0x1F970A8", VA = "0x1F970A8")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1F96F84", Offset = "0x1F96F84", VA = "0x1F96F84")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1F976D4", Offset = "0x1F976D4", VA = "0x1F976D4")]
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

	[Token(Token = "0x40001C9")]
	public const float volumeMultiplayerVoiceDefault = 0.5f;

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x1A32C8C", Offset = "0x1A32C8C", VA = "0x1A32C8C")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x1A32CF8", Offset = "0x1A32CF8", VA = "0x1A32CF8")]
	public static void InitDefaults()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1A334F4", Offset = "0x1A334F4", VA = "0x1A334F4")]
	public static bool HadSet(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1A335C4", Offset = "0x1A335C4", VA = "0x1A335C4")]
	public static bool Get(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1A33694", Offset = "0x1A33694", VA = "0x1A33694")]
	public static void Set(eCheck e, bool v)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x1A33704", Offset = "0x1A33704", VA = "0x1A33704")]
	public static void Set(int i, bool v)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1A3381C", Offset = "0x1A3381C", VA = "0x1A3381C")]
	public static void Switch(eCheck i)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1A33964", Offset = "0x1A33964", VA = "0x1A33964")]
	public static float GetFloat(eSlider i)
	{
		return default(float);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1A339F4", Offset = "0x1A339F4", VA = "0x1A339F4")]
	public static void SetFloat(eSlider i, float v)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1A33AA8", Offset = "0x1A33AA8", VA = "0x1A33AA8")]
	public static bool GetNS(eCheckNotSaved i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1A33B38", Offset = "0x1A33B38", VA = "0x1A33B38")]
	public static void SetNS(int i, bool v)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1A33BE0", Offset = "0x1A33BE0", VA = "0x1A33BE0")]
	public static void SwitchNS(eCheckNotSaved i)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1A33C78", Offset = "0x1A33C78", VA = "0x1A33C78")]
	public static void Save()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1A33E94", Offset = "0x1A33E94", VA = "0x1A33E94")]
	public static bool CanLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x1A330E4", Offset = "0x1A330E4", VA = "0x1A330E4")]
	public static void Load()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1A33F28", Offset = "0x1A33F28", VA = "0x1A33F28")]
	private void Click()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1A33F80", Offset = "0x1A33F80", VA = "0x1A33F80")]
	public MUI_data()
	{
	}
}
[Token(Token = "0x2000040")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8365B4", Offset = "0x8365B4")]
public class MUI_setup_LineBreak : MonoBehaviour
{
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float wantedWidth;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool removeLineBreaks;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool removeSingleLineBreaks;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int leaveFirstNbreaks;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool justifyLines;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int maxLines;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int textCapacity;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int wordCapacity;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool dontRemoveLineBreaks;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float lastScale;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TextSize ts;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool breakLine;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Renderer r;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 scaleOrg;

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1A34074", Offset = "0x1A34074", VA = "0x1A34074")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1A3417C", Offset = "0x1A3417C", VA = "0x1A3417C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1A34480", Offset = "0x1A34480", VA = "0x1A34480")]
	private void SetWidth(float w)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1A34488", Offset = "0x1A34488", VA = "0x1A34488")]
	private void Update()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1A346D0", Offset = "0x1A346D0", VA = "0x1A346D0")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1A34498", Offset = "0x1A34498", VA = "0x1A34498")]
	private void BreakNow()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1A346D4", Offset = "0x1A346D4", VA = "0x1A346D4")]
	public static int IndexOfNth(string str, char c, int nth, int startPosition = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1A3478C", Offset = "0x1A3478C", VA = "0x1A3478C")]
	public void BreakLinesFromLine(int line, float width)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1A3498C", Offset = "0x1A3498C", VA = "0x1A3498C")]
	public MUI_setup_LineBreak()
	{
	}
}
[Token(Token = "0x2000041")]
internal class StringBufferWrapper
{
	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly StringBuilder y;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly StringBuffer x;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly bool ub;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x2122EDC", Offset = "0x2122EDC", VA = "0x2122EDC")]
	public StringBufferWrapper(int capacity)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2122F90", Offset = "0x2122F90", VA = "0x2122F90")]
	public StringBufferWrapper()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2122FF8", Offset = "0x2122FF8", VA = "0x2122FF8")]
	public void Clear()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2123034", Offset = "0x2123034", VA = "0x2123034")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x212306C", Offset = "0x212306C", VA = "0x212306C")]
	public unsafe void Append(char* str, int startIdx, int count)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x21230B4", Offset = "0x21230B4", VA = "0x21230B4")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2123118", Offset = "0x2123118", VA = "0x2123118")]
	public void Append(StringBufferWrapper sb)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x2123160", Offset = "0x2123160", VA = "0x2123160")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x21231C8", Offset = "0x21231C8", VA = "0x21231C8")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2123234", Offset = "0x2123234", VA = "0x2123234")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x21232C0", Offset = "0x21232C0", VA = "0x21232C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000042")]
public class TextSize
{
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<char, float> dict;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMesh textMesh;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer renderer;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private StringBufferWrapper cachedString;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StringBufferWrapper cachedWord;

	[Token(Token = "0x17000007")]
	public float width
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x21232F4", Offset = "0x21232F4", VA = "0x21232F4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000008")]
	public float height
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x21234DC", Offset = "0x21234DC", VA = "0x21234DC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2123534", Offset = "0x2123534", VA = "0x2123534")]
	public TextSize(TextMesh tm, int textCapacity = -1, int wordCapacity = -1)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x2123640", Offset = "0x2123640", VA = "0x2123640")]
	private void getSpace()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x212332C", Offset = "0x212332C", VA = "0x212332C")]
	private float GetTextWidth(string s)
	{
		return default(float);
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x21237E8", Offset = "0x21237E8", VA = "0x21237E8")]
	private string RemoveLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x212390C", Offset = "0x212390C", VA = "0x212390C")]
	private string RemoveSingleLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x2123AA8", Offset = "0x2123AA8", VA = "0x2123AA8")]
	public void FitToWidth(float wantedWidth, bool removeLineBreaks, bool removeSingleLineBreaks, int leaveFirstNbreaks, bool justifyLines, bool resetDictionary, int maxLines)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x2124274", Offset = "0x2124274", VA = "0x2124274")]
	private bool IsCHchar(char c)
	{
		return default(bool);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x2123D88", Offset = "0x2123D88", VA = "0x2123D88")]
	private unsafe bool WrapLine(char* s, int startIdx, int endIdx, float w, bool justifyLine)
	{
		return default(bool);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x2124284", Offset = "0x2124284", VA = "0x2124284")]
	private string JustifyLine(List<string> words, float wordsWidth, float w)
	{
		return null;
	}
}
[Token(Token = "0x2000043")]
public class MUI_setup_TextArea : MonoBehaviour
{
	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float W;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float H;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 scaleOrg;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int delay;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Renderer r;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1A349B8", Offset = "0x1A349B8", VA = "0x1A349B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1A34A74", Offset = "0x1A34A74", VA = "0x1A34A74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1A34A80", Offset = "0x1A34A80", VA = "0x1A34A80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1A34DBC", Offset = "0x1A34DBC", VA = "0x1A34DBC")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x1A34AB8", Offset = "0x1A34AB8", VA = "0x1A34AB8")]
	public void Calculate()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1A34DC8", Offset = "0x1A34DC8", VA = "0x1A34DC8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1A350CC", Offset = "0x1A350CC", VA = "0x1A350CC")]
	public MUI_setup_TextArea()
	{
	}
}
[Token(Token = "0x2000044")]
public class StringBuffer
{
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly char[] data;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly int capacity;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int idx;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x2122B44", Offset = "0x2122B44", VA = "0x2122B44")]
	public StringBuffer(int capacity)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2122BB8", Offset = "0x2122BB8", VA = "0x2122BB8")]
	public void Clear()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2122BC0", Offset = "0x2122BC0", VA = "0x2122BC0")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x2122C4C", Offset = "0x2122C4C", VA = "0x2122C4C")]
	public unsafe void Append(char* str, int count)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2122CBC", Offset = "0x2122CBC", VA = "0x2122CBC")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x2122CEC", Offset = "0x2122CEC", VA = "0x2122CEC")]
	public void Append(StringBuffer sb)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x2122D7C", Offset = "0x2122D7C", VA = "0x2122D7C")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x2122DB0", Offset = "0x2122DB0", VA = "0x2122DB0")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x2122E08", Offset = "0x2122E08", VA = "0x2122E08")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2122E1C", Offset = "0x2122E1C", VA = "0x2122E1C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
public class MergeMesh : MonoBehaviour
{
	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool mergeOnStart;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool createTangent;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useUV2;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool vertexColors;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool useRenderer;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool checkOnlyActiveInHierarchy;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] predefinedList;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int indexV;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] indexT;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int indexO;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int indexM;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform[] tr;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material[] materials;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Mesh[] meshes;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[][] meshVertices;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] vertices;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector4[] tangents;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2[] uv;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Color32[] colors;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector2[] uv2;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int[][] triangles;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Mesh mesh;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool usePredefined;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int verticesCnt;

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x1A35158", Offset = "0x1A35158", VA = "0x1A35158")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1A35168", Offset = "0x1A35168", VA = "0x1A35168")]
	public void MergeMeshNow()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1A35870", Offset = "0x1A35870", VA = "0x1A35870")]
	public void AddTR(Transform t0)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x1A35E90", Offset = "0x1A35E90", VA = "0x1A35E90")]
	public void CountData(Mesh m, Vector3[] mvertices, Renderer r)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x1A36B28", Offset = "0x1A36B28", VA = "0x1A36B28")]
	public void AddMaterial(Material m)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x1A36C34", Offset = "0x1A36C34", VA = "0x1A36C34")]
	public int GetMaterialIndex(Material m)
	{
		return default(int);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1A35F8C", Offset = "0x1A35F8C", VA = "0x1A35F8C")]
	private void BuildMesh(Transform t, Mesh m, Vector3[] mvertices)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1A3672C", Offset = "0x1A3672C", VA = "0x1A3672C")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1A36D4C", Offset = "0x1A36D4C", VA = "0x1A36D4C")]
	public MergeMesh()
	{
	}
}
[Token(Token = "0x2000046")]
public class OpenUrl
{
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x211B584", Offset = "0x211B584", VA = "0x211B584")]
	public static void Open(string url)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x211B5C4", Offset = "0x211B5C4", VA = "0x211B5C4")]
	public static void Open(string url, string steamBundleID)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x211B630", Offset = "0x211B630", VA = "0x211B630")]
	public OpenUrl()
	{
	}
}
[Token(Token = "0x2000047")]
public enum TargetStore
{
	[Token(Token = "0x4000202")]
	Sidequest,
	[Token(Token = "0x4000203")]
	Oculus,
	[Token(Token = "0x4000204")]
	Steam,
	[Token(Token = "0x4000205")]
	Vive,
	[Token(Token = "0x4000206")]
	Microsoft,
	[Token(Token = "0x4000207")]
	Nolo,
	[Token(Token = "0x4000208")]
	StandaloneOVR,
	[Token(Token = "0x4000209")]
	Pico,
	[Token(Token = "0x400020A")]
	YVR,
	[Token(Token = "0x400020B")]
	QIYU
}
[Token(Token = "0x2000048")]
public enum VRSDK
{
	[Token(Token = "0x400020D")]
	Oculus,
	[Token(Token = "0x400020E")]
	Steam,
	[Token(Token = "0x400020F")]
	Nolo,
	[Token(Token = "0x4000210")]
	Wave,
	[Token(Token = "0x4000211")]
	Pico,
	[Token(Token = "0x4000212")]
	YVR,
	[Token(Token = "0x4000213")]
	QIYU
}
[Token(Token = "0x2000049")]
public class Platform : UnityEngine.Object
{
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static TargetStore targetStore;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool demo;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public static bool mission_editor;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static VRSDK vrSDK;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static bool pico_china;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public static bool pico_global;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public static bool dev_mode;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string dev_mode_contents;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static bool test_build;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public static bool mousekbd_input;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	private static bool devModeChecked;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int oculusShellEnvVersionCached;

	[Token(Token = "0x4000220")]
	public const int minRequiredQuestSystemVersion = 29;

	[Token(Token = "0x17000009")]
	public static bool editor
	{
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x211B638", Offset = "0x211B638", VA = "0x211B638")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	public static bool sidequestStore
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x211B640", Offset = "0x211B640", VA = "0x211B640")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	public static bool oculusStore
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x211B6AC", Offset = "0x211B6AC", VA = "0x211B6AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public static bool steamStore
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x211B718", Offset = "0x211B718", VA = "0x211B718")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public static bool viveStore
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x211B784", Offset = "0x211B784", VA = "0x211B784")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public static bool microsoftStore
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x211B7F0", Offset = "0x211B7F0", VA = "0x211B7F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public static bool noloStore
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x211B85C", Offset = "0x211B85C", VA = "0x211B85C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public static bool picoStore
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x211B8C8", Offset = "0x211B8C8", VA = "0x211B8C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public static bool yvrStore
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x211B934", Offset = "0x211B934", VA = "0x211B934")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public static bool qiyuStore
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x211B9A0", Offset = "0x211B9A0", VA = "0x211B9A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public static bool standaloneOVRStore
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x211BA0C", Offset = "0x211BA0C", VA = "0x211BA0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public static bool oculusVR
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x211BA78", Offset = "0x211BA78", VA = "0x211BA78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public static bool steamVR
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x211BAE4", Offset = "0x211BAE4", VA = "0x211BAE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000016")]
	public static bool noloVR
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x211BB50", Offset = "0x211BB50", VA = "0x211BB50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public static bool waveVR
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x211BBBC", Offset = "0x211BBBC", VA = "0x211BBBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public static bool picoVR
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x211BC28", Offset = "0x211BC28", VA = "0x211BC28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000019")]
	public static bool yvrVR
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x211BC94", Offset = "0x211BC94", VA = "0x211BC94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001A")]
	public static bool qiyuVR
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x211BD00", Offset = "0x211BD00", VA = "0x211BD00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001B")]
	public static bool multi_china
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x211BD6C", Offset = "0x211BD6C", VA = "0x211BD6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001C")]
	public static bool android
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x211BE18", Offset = "0x211BE18", VA = "0x211BE18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001D")]
	public static bool winStore
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x211BE20", Offset = "0x211BE20", VA = "0x211BE20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public static bool winStandalone
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x211BE28", Offset = "0x211BE28", VA = "0x211BE28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public static bool iOS
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x211BE30", Offset = "0x211BE30", VA = "0x211BE30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public static bool macOsStandalone
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x211BE38", Offset = "0x211BE38", VA = "0x211BE38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public static bool standalone
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x211BE40", Offset = "0x211BE40", VA = "0x211BE40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public static bool linuxStandalone
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x211BE48", Offset = "0x211BE48", VA = "0x211BE48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000023")]
	public static bool mobile
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x211BE50", Offset = "0x211BE50", VA = "0x211BE50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000024")]
	public static bool PC
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x211BEAC", Offset = "0x211BEAC", VA = "0x211BEAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000025")]
	public static string str0xA0
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x211BF20", Offset = "0x211BF20", VA = "0x211BF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x211BF64", Offset = "0x211BF64", VA = "0x211BF64")]
	public static void CheckDevMode()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x211C1C8", Offset = "0x211C1C8", VA = "0x211C1C8")]
	public static int GetQuestSystemVersion()
	{
		return default(int);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x211CA1C", Offset = "0x211CA1C", VA = "0x211CA1C")]
	public static bool IsMinRequiredQuestSystemVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x211CAA8", Offset = "0x211CAA8", VA = "0x211CAA8")]
	public Platform()
	{
	}
}
[Token(Token = "0x200004A")]
public class ComputeDiffuseEnvironmentMap : MonoBehaviour
{
	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] mat;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Cubemap filteredCubeMap;

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x16EFFCC", Offset = "0x16EFFCC", VA = "0x16EFFCC")]
	public void ComputeConvolution(Cubemap originalCubeMap)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x16F05F0", Offset = "0x16F05F0", VA = "0x16F05F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x16F0248", Offset = "0x16F0248", VA = "0x16F0248")]
	private Cubemap computeFilteredCubeMap(Cubemap originalCubeMap)
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x16F0814", Offset = "0x16F0814", VA = "0x16F0814")]
	private void setFaceAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x16F0944", Offset = "0x16F0944", VA = "0x16F0944")]
	private void setCornerAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f, int g, int h, int i)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x16F06A0", Offset = "0x16F06A0", VA = "0x16F06A0")]
	private Vector3 getDirection(int face, int i, int j, int size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x16F0B08", Offset = "0x16F0B08", VA = "0x16F0B08")]
	public ComputeDiffuseEnvironmentMap()
	{
	}
}
[Token(Token = "0x200004B")]
public struct EncodedInt
{
	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int xorHash;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private int encValue;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private int fakeValue;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private int plainValue;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool inited;

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x16F8F64", Offset = "0x16F8F64", VA = "0x16F8F64")]
	public static implicit operator EncodedInt(int value)
	{
		return default(EncodedInt);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x16F8F80", Offset = "0x16F8F80", VA = "0x16F8F80")]
	public static bool operator ==(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x16F9014", Offset = "0x16F9014", VA = "0x16F9014")]
	public static bool operator !=(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x16F903C", Offset = "0x16F903C", VA = "0x16F903C")]
	public static bool operator ==(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x16F9068", Offset = "0x16F9068", VA = "0x16F9068")]
	public static bool operator !=(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x16F9094", Offset = "0x16F9094", VA = "0x16F9094")]
	public void setValue(int val)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x16F8FA8", Offset = "0x16F8FA8", VA = "0x16F8FA8")]
	public int getValue()
	{
		return default(int);
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x16F8F70", Offset = "0x16F8F70", VA = "0x16F8F70")]
	private EncodedInt(int val)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x16F9138", Offset = "0x16F9138", VA = "0x16F9138")]
	private void Init(int val)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x16F9190", Offset = "0x16F9190", VA = "0x16F9190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x16F91BC", Offset = "0x16F91BC", VA = "0x16F91BC")]
	public string ToString(string format)
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x16F91F0", Offset = "0x16F91F0", VA = "0x16F91F0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x16F92B0", Offset = "0x16F92B0", VA = "0x16F92B0")]
	public bool Equals(EncodedInt p)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x16F92E4", Offset = "0x16F92E4", VA = "0x16F92E4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200004C")]
public struct Vector2Int
{
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int x;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int y;

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x21258C4", Offset = "0x21258C4", VA = "0x21258C4")]
	public Vector2Int(int _x, int _y)
	{
	}
}
[Token(Token = "0x200004D")]
public class SaveWrapper : MonoBehaviour
{
	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string qiyu_prefix;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static JSONObject jsonSave;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static bool saveChanged;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	protected static float saveChangedTime;

	[Token(Token = "0x400022E")]
	public const string wrapperSaveName = "saveGame";

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string[] saveKeys;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected static SaveWrapper instance;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected static string oculusSaveWrapperFile;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected static bool steamInitialized;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	protected static bool qiyuInitialized;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private static bool waitingForInitialize;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initializing;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float initializeStartTime;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x211EE18", Offset = "0x211EE18", VA = "0x211EE18")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x211F51C", Offset = "0x211F51C", VA = "0x211F51C")]
	public static float GetFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x211F584", Offset = "0x211F584", VA = "0x211F584")]
	public static float GetFloat(string key, float defval)
	{
		return default(float);
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x211F68C", Offset = "0x211F68C", VA = "0x211F68C")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x211F6F4", Offset = "0x211F6F4", VA = "0x211F6F4")]
	public static int GetInt(string key, int defval)
	{
		return default(int);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x211F7FC", Offset = "0x211F7FC", VA = "0x211F7FC")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x211F878", Offset = "0x211F878", VA = "0x211F878")]
	public static string GetString(string key, string defval)
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x211F994", Offset = "0x211F994", VA = "0x211F994")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x211FA74", Offset = "0x211FA74", VA = "0x211FA74")]
	public static void Save()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x211FD40", Offset = "0x211FD40", VA = "0x211FD40")]
	public static void SetFloat(string key, float val)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x211FED8", Offset = "0x211FED8", VA = "0x211FED8")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x2120070", Offset = "0x2120070", VA = "0x2120070")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x211EF5C", Offset = "0x211EF5C", VA = "0x211EF5C")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x212021C", Offset = "0x212021C", VA = "0x212021C")]
	public static void InitQUIYU(string prefix)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x2120220", Offset = "0x2120220", VA = "0x2120220")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x2120858", Offset = "0x2120858", VA = "0x2120858")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x21207AC", Offset = "0x21207AC", VA = "0x21207AC")]
	private string GetHardcodedOculusCloudSaveDirectory()
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2120914", Offset = "0x2120914", VA = "0x2120914")]
	private void OnCompleteGetUserDirectoryPath(Message msg)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2120CA0", Offset = "0x2120CA0", VA = "0x2120CA0")]
	public static bool IsInitializing()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x2120DB0", Offset = "0x2120DB0", VA = "0x2120DB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x2120FF0", Offset = "0x2120FF0", VA = "0x2120FF0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x2121098", Offset = "0x2121098", VA = "0x2121098")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x211F0D0", Offset = "0x211F0D0", VA = "0x211F0D0")]
	public static bool IsUseWrapper()
	{
		return default(bool);
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x211F1C0", Offset = "0x211F1C0", VA = "0x211F1C0")]
	protected static void LoadWrapper()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x211FB68", Offset = "0x211FB68", VA = "0x211FB68")]
	protected static void StoreWrapper()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2121140", Offset = "0x2121140", VA = "0x2121140")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83699C", Offset = "0x83699C")]
	private sealed class <RunCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SteamManager <>4__this;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <counter>5__2;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x20554B0", Offset = "0x20554B0", VA = "0x20554B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x20554F8", Offset = "0x20554F8", VA = "0x20554F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2055410", Offset = "0x2055410", VA = "0x2055410")]
		[DebuggerHidden]
		public <RunCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x205543C", Offset = "0x205543C", VA = "0x205543C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2055440", Offset = "0x2055440", VA = "0x2055440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x20554B8", Offset = "0x20554B8", VA = "0x20554B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int gameAppId;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int gameAppIdDemo;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SteamManager s_instance;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool s_EverInialized;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_bInitialized;

	[Token(Token = "0x17000026")]
	public static bool Initialized
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x21224A0", Offset = "0x21224A0", VA = "0x21224A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000027")]
	private static SteamManager Instance
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x212258C", Offset = "0x212258C", VA = "0x212258C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000003")]
	public static event BoolEvent overlayActivated
	{
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x21228C0", Offset = "0x21228C0", VA = "0x21228C0")]
		add
		{
		}
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x21229DC", Offset = "0x21229DC", VA = "0x21229DC")]
		remove
		{
		}
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x21225D8", Offset = "0x21225D8", VA = "0x21225D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x2122708", Offset = "0x2122708", VA = "0x2122708")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x21227AC", Offset = "0x21227AC", VA = "0x21227AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x2122850", Offset = "0x2122850", VA = "0x2122850")]
	private void Update()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x2122854", Offset = "0x2122854", VA = "0x2122854")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8388C0", Offset = "0x8388C0")]
	private IEnumerator RunCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x2122AF8", Offset = "0x2122AF8", VA = "0x2122AF8")]
	public static string GetPlayerName()
	{
		return null;
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x2122B3C", Offset = "0x2122B3C", VA = "0x2122B3C")]
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
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string filePath;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest request;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool done;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture texture;

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x20557D4", Offset = "0x20557D4", VA = "0x20557D4")]
		public DownloadedTexture()
		{
		}
	}

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static TextureWWWDownloader instance;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected List<DownloadedTexture> textures;

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x2124560", Offset = "0x2124560", VA = "0x2124560")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x2124564", Offset = "0x2124564", VA = "0x2124564")]
	public static void LogError(string text)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x21245F4", Offset = "0x21245F4", VA = "0x21245F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x21246FC", Offset = "0x21246FC", VA = "0x21246FC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x21247A0", Offset = "0x21247A0", VA = "0x21247A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x21250C0", Offset = "0x21250C0", VA = "0x21250C0")]
	public static DownloadedTexture GetTexture(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x212510C", Offset = "0x212510C", VA = "0x212510C")]
	public static DownloadedTexture GetTexture(string filePath, string resourcesFolder)
	{
		return null;
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x21257FC", Offset = "0x21257FC", VA = "0x21257FC")]
	protected static string GetFileName(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x21247A4", Offset = "0x21247A4", VA = "0x21247A4")]
	private void StepDownloadingTextures()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x212584C", Offset = "0x212584C", VA = "0x212584C")]
	public TextureWWWDownloader()
	{
	}
}
[Token(Token = "0x2000050")]
public class WWWwrapper : CustomYieldInstruction
{
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected UnityWebRequest request;

	[Token(Token = "0x17000028")]
	public override bool keepWaiting
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x21259E8", Offset = "0x21259E8", VA = "0x21259E8", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000029")]
	public string error
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2125A14", Offset = "0x2125A14", VA = "0x2125A14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public string text
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2125ABC", Offset = "0x2125ABC", VA = "0x2125ABC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	public byte[] data
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2125AE8", Offset = "0x2125AE8", VA = "0x2125AE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public string data2string
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2125B14", Offset = "0x2125B14", VA = "0x2125B14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002D")]
	public bool isDone
	{
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2125C28", Offset = "0x2125C28", VA = "0x2125C28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x2125C44", Offset = "0x2125C44", VA = "0x2125C44")]
	public WWWwrapper(string url, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x2125DBC", Offset = "0x2125DBC", VA = "0x2125DBC")]
	public WWWwrapper(string url, WWWForm form, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x2125F54", Offset = "0x2125F54", VA = "0x2125F54")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x2125F70", Offset = "0x2125F70", VA = "0x2125F70")]
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
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1611558", Offset = "0x1611558", VA = "0x1611558")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838920", Offset = "0x838920")]
		add
		{
		}
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x16115F8", Offset = "0x16115F8", VA = "0x16115F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838930", Offset = "0x838930")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	private event Action<string> OnPermissionDeniedAction
	{
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1611698", Offset = "0x1611698", VA = "0x1611698")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838940", Offset = "0x838940")]
		add
		{
		}
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1611738", Offset = "0x1611738", VA = "0x1611738")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838950", Offset = "0x838950")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	private event Action<string> OnPermissionDeniedAndDontAskAgainAction
	{
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x16117D8", Offset = "0x16117D8", VA = "0x16117D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838960", Offset = "0x838960")]
		add
		{
		}
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1611878", Offset = "0x1611878", VA = "0x1611878")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838970", Offset = "0x838970")]
		remove
		{
		}
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x1611918", Offset = "0x1611918", VA = "0x1611918")]
	public AndroidPermissionCallback(Action<string> onGrantedCallback, Action<string> onDeniedCallback, Action<string> onDeniedAndDontAskAgainCallback)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x16119F4", Offset = "0x16119F4", VA = "0x16119F4", Slot = "9")]
	public virtual void OnPermissionGranted(string permissionName)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x1611A64", Offset = "0x1611A64", VA = "0x1611A64", Slot = "10")]
	public virtual void OnPermissionDenied(string permissionName)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x1611AD4", Offset = "0x1611AD4", VA = "0x1611AD4", Slot = "11")]
	public virtual void OnPermissionDeniedAndDontAskAgain(string permissionName)
	{
	}
}
[Token(Token = "0x2000052")]
public class AndroidPermissionsManager
{
	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject m_Activity;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject m_PermissionService;

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x1611B4C", Offset = "0x1611B4C", VA = "0x1611B4C")]
	private static AndroidJavaObject GetActivity()
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x1611C34", Offset = "0x1611C34", VA = "0x1611C34")]
	private static AndroidJavaObject GetPermissionsService()
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x1611D78", Offset = "0x1611D78", VA = "0x1611D78")]
	public static bool IsPermissionGranted(string permissionName)
	{
		return default(bool);
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x1611E90", Offset = "0x1611E90", VA = "0x1611E90")]
	public static void RequestPermission(string permissionName, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x1611F3C", Offset = "0x1611F3C", VA = "0x1611F3C")]
	public static void RequestPermission(string[] permissionNames, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x1612074", Offset = "0x1612074", VA = "0x1612074")]
	public AndroidPermissionsManager()
	{
	}
}
[Token(Token = "0x2000053")]
[ExecuteInEditMode]
public class WaterSimple : MonoBehaviour
{
	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Renderer r;

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x21292C4", Offset = "0x21292C4", VA = "0x21292C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x2129318", Offset = "0x2129318", VA = "0x2129318")]
	private void Update()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x2129680", Offset = "0x2129680", VA = "0x2129680")]
	public WaterSimple()
	{
	}
}
namespace JSONplugin
{
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x836634", Offset = "0x836634")]
	public class JSONObject
	{
		[Token(Token = "0x20000AD")]
		public enum Type
		{
			[Token(Token = "0x400045B")]
			NULL,
			[Token(Token = "0x400045C")]
			STRING,
			[Token(Token = "0x400045D")]
			NUMBER,
			[Token(Token = "0x400045E")]
			OBJECT,
			[Token(Token = "0x400045F")]
			ARRAY,
			[Token(Token = "0x4000460")]
			BOOL,
			[Token(Token = "0x4000461")]
			BAKED
		}

		[Token(Token = "0x20000AE")]
		public delegate void AddJSONContents(JSONObject self);

		[Token(Token = "0x20000AF")]
		public delegate void FieldNotFound(string name);

		[Token(Token = "0x20000B0")]
		public delegate void GetFieldResponse(JSONObject obj);

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8369AC", Offset = "0x8369AC")]
		private sealed class <BakeAsync>d__125 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<string> <>7__wrap1;

			[Token(Token = "0x17000081")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000793")]
				[Address(RVA = "0x2051684", Offset = "0x2051684", VA = "0x2051684", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0x20516CC", Offset = "0x20516CC", VA = "0x20516CC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x2051298", Offset = "0x2051298", VA = "0x2051298")]
			[DebuggerHidden]
			public <BakeAsync>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x20512D0", Offset = "0x20512D0", VA = "0x20512D0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x20513A8", Offset = "0x20513A8", VA = "0x20513A8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x20512EC", Offset = "0x20512EC", VA = "0x20512EC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x205168C", Offset = "0x205168C", VA = "0x205168C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x20516D4", Offset = "0x20516D4", VA = "0x20516D4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x205177C", Offset = "0x205177C", VA = "0x205177C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8369BC", Offset = "0x8369BC")]
		private sealed class <PrintAsync>d__128 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool pretty;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool <>3__pretty;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StringBuilder <builder>5__2;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator <>7__wrap2;

			[Token(Token = "0x17000083")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x600079C")]
				[Address(RVA = "0x2051C08", Offset = "0x2051C08", VA = "0x2051C08", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079E")]
				[Address(RVA = "0x2051C50", Offset = "0x2051C50", VA = "0x2051C50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x2051780", Offset = "0x2051780", VA = "0x2051780")]
			[DebuggerHidden]
			public <PrintAsync>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x20517B8", Offset = "0x20517B8", VA = "0x20517B8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x205189C", Offset = "0x205189C", VA = "0x205189C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x20517D4", Offset = "0x20517D4", VA = "0x20517D4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x2051C10", Offset = "0x2051C10", VA = "0x2051C10", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x2051C58", Offset = "0x2051C58", VA = "0x2051C58", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x2051D08", Offset = "0x2051D08", VA = "0x2051D08", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8369CC", Offset = "0x8369CC")]
		private sealed class <StringifyAsync>d__131 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int depth;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int <>3__depth;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StringBuilder builder;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public StringBuilder <>3__builder;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool pretty;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool <>3__pretty;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <i>5__2;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private IEnumerator <>7__wrap2;

			[Token(Token = "0x17000085")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x2052F24", Offset = "0x2052F24", VA = "0x2052F24", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A8")]
				[Address(RVA = "0x2052F6C", Offset = "0x2052F6C", VA = "0x2052F6C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x2051D0C", Offset = "0x2051D0C", VA = "0x2051D0C")]
			[DebuggerHidden]
			public <StringifyAsync>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x2051D44", Offset = "0x2051D44", VA = "0x2051D44", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x2051F70", Offset = "0x2051F70", VA = "0x2051F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x2051DE0", Offset = "0x2051DE0", VA = "0x2051DE0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x2051EA8", Offset = "0x2051EA8", VA = "0x2051EA8")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x2052F2C", Offset = "0x2052F2C", VA = "0x2052F2C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x2052F74", Offset = "0x2052F74", VA = "0x2052F74", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x2053034", Offset = "0x2053034", VA = "0x2053034", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000246")]
		private const int MAX_DEPTH = 100;

		[Token(Token = "0x4000247")]
		private const string INFINITY = "\"INFINITY\"";

		[Token(Token = "0x4000248")]
		private const string NEGINFINITY = "\"NEGINFINITY\"";

		[Token(Token = "0x4000249")]
		private const string NaN = "\"NaN\"";

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly char[] WHITESPACE;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<JSONObject> list;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> keys;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string str;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float n;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useInt;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long i;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool b;

		[Token(Token = "0x4000253")]
		private const float maxFrameTime = 0.008f;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Stopwatch printWatch;

		[Token(Token = "0x1700002E")]
		public bool isContainer
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x16FB610", Offset = "0x16FB610", VA = "0x16FB610")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public int Count
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x16FB624", Offset = "0x16FB624", VA = "0x16FB624")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		public float f
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x16FB674", Offset = "0x16FB674", VA = "0x16FB674")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000031")]
		public static JSONObject nullJO
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x16FB67C", Offset = "0x16FB67C", VA = "0x16FB67C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public static JSONObject obj
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x16FB808", Offset = "0x16FB808", VA = "0x16FB808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public static JSONObject arr
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x16FB864", Offset = "0x16FB864", VA = "0x16FB864")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public bool IsNumber
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x16FD360", Offset = "0x16FD360", VA = "0x16FD360")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool IsNull
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x16FD370", Offset = "0x16FD370", VA = "0x16FD370")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public bool IsString
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x16FD380", Offset = "0x16FD380", VA = "0x16FD380")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public bool IsBool
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x16FD390", Offset = "0x16FD390", VA = "0x16FD390")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public bool IsArray
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x16FD3A0", Offset = "0x16FD3A0", VA = "0x16FD3A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public bool IsObject
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x16FD3B0", Offset = "0x16FD3B0", VA = "0x16FD3B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public JSONObject Item
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x16FF31C", Offset = "0x16FF31C", VA = "0x16FF31C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x16FF3A8", Offset = "0x16FF3A8", VA = "0x16FF3A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public JSONObject Item
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x16FE25C", Offset = "0x16FE25C", VA = "0x16FE25C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x16FFDC8", Offset = "0x16FFDC8", VA = "0x16FFDC8")]
			set
			{
			}
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x16FB8C0", Offset = "0x16FB8C0", VA = "0x16FB8C0")]
		public JSONObject(Type t)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x16FB9C8", Offset = "0x16FB9C8", VA = "0x16FB9C8")]
		public JSONObject(bool b)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x16FBA00", Offset = "0x16FBA00", VA = "0x16FBA00")]
		public JSONObject(float f)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x16FBA3C", Offset = "0x16FBA3C", VA = "0x16FBA3C")]
		public JSONObject(int i)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x16FBA84", Offset = "0x16FBA84", VA = "0x16FBA84")]
		public JSONObject(long l)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x16FBAC8", Offset = "0x16FBAC8", VA = "0x16FBAC8")]
		public JSONObject(Dictionary<string, string> dic)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x16FBDBC", Offset = "0x16FBDBC", VA = "0x16FBDBC")]
		public JSONObject(Dictionary<string, JSONObject> dic)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x16FBFE8", Offset = "0x16FBFE8", VA = "0x16FBFE8")]
		public JSONObject(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x16FC024", Offset = "0x16FC024", VA = "0x16FC024")]
		public JSONObject(JSONObject[] objs)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x16FC0B8", Offset = "0x16FC0B8", VA = "0x16FC0B8")]
		public static JSONObject StringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x16FC118", Offset = "0x16FC118", VA = "0x16FC118")]
		public void Absorb(JSONObject obj)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x16FC1DC", Offset = "0x16FC1DC", VA = "0x16FC1DC")]
		public static JSONObject Create()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x16FB6D8", Offset = "0x16FB6D8", VA = "0x16FB6D8")]
		public static JSONObject Create(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x16FC23C", Offset = "0x16FC23C", VA = "0x16FC23C")]
		public static JSONObject Create(bool val)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x16FC2B4", Offset = "0x16FC2B4", VA = "0x16FC2B4")]
		public static JSONObject Create(float val)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x16FC330", Offset = "0x16FC330", VA = "0x16FC330")]
		public static JSONObject Create(int val)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x16FC3B8", Offset = "0x16FC3B8", VA = "0x16FC3B8")]
		public static JSONObject Create(uint val)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x16FC444", Offset = "0x16FC444", VA = "0x16FC444")]
		public static JSONObject Create(long val)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x16FC4C8", Offset = "0x16FC4C8", VA = "0x16FC4C8")]
		public static JSONObject Create(ulong val)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x16FBD48", Offset = "0x16FBD48", VA = "0x16FBD48")]
		public static JSONObject CreateStringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x16FC550", Offset = "0x16FC550", VA = "0x16FC550")]
		public static JSONObject CreateBakedObject(string val)
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x16FC5C4", Offset = "0x16FC5C4", VA = "0x16FC5C4")]
		public static JSONObject Create(string val, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x16FCF20", Offset = "0x16FCF20", VA = "0x16FCF20")]
		public static JSONObject Create(AddJSONContents content)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x16FCFA0", Offset = "0x16FCFA0", VA = "0x16FCFA0")]
		public static JSONObject Create(Dictionary<string, string> dic)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x16FC234", Offset = "0x16FC234", VA = "0x16FC234")]
		public JSONObject()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x16FD238", Offset = "0x16FD238", VA = "0x16FD238")]
		public JSONObject(string str)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x16FD274", Offset = "0x16FD274", VA = "0x16FD274")]
		public JSONObject(string str, int maxDepth)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x16FD2BC", Offset = "0x16FD2BC", VA = "0x16FD2BC")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x16FD308", Offset = "0x16FD308", VA = "0x16FD308")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels, bool strict)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x16FC664", Offset = "0x16FC664", VA = "0x16FC664")]
		private void Parse(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x16FD3CC", Offset = "0x16FD3CC", VA = "0x16FD3CC")]
		public void Add(bool val)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x16FD554", Offset = "0x16FD554", VA = "0x16FD554")]
		public void Add(float val)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x16FD5CC", Offset = "0x16FD5CC", VA = "0x16FD5CC")]
		public void Add(int val)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x16FD644", Offset = "0x16FD644", VA = "0x16FD644")]
		public void Add(uint val)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x16FD6BC", Offset = "0x16FD6BC", VA = "0x16FD6BC")]
		public void Add(long val)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x16FD734", Offset = "0x16FD734", VA = "0x16FD734")]
		public void Add(ulong val)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x16FD7AC", Offset = "0x16FD7AC", VA = "0x16FD7AC")]
		public void Add(string str)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x16FD824", Offset = "0x16FD824", VA = "0x16FD824")]
		public void Add(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x16FD444", Offset = "0x16FD444", VA = "0x16FD444")]
		public void Add(JSONObject obj)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x16FD8A8", Offset = "0x16FD8A8", VA = "0x16FD8A8")]
		public void AddField(string name, bool val)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x16FDB40", Offset = "0x16FDB40", VA = "0x16FDB40")]
		public void AddField(string name, float val)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x16FDBC8", Offset = "0x16FDBC8", VA = "0x16FDBC8")]
		public void AddField(string name, int val)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x16FDC48", Offset = "0x16FDC48", VA = "0x16FDC48")]
		public void AddField(string name, uint val)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x16FDCC8", Offset = "0x16FDCC8", VA = "0x16FDCC8")]
		public void AddField(string name, long val)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x16FDD48", Offset = "0x16FDD48", VA = "0x16FDD48")]
		public void AddField(string name, ulong val)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x16FDDC8", Offset = "0x16FDDC8", VA = "0x16FDDC8")]
		public void AddField(string name, AddJSONContents content)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x16FDE48", Offset = "0x16FDE48", VA = "0x16FDE48")]
		public void AddField(string name, string val)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x16FD928", Offset = "0x16FD928", VA = "0x16FD928")]
		public void AddField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x16FDEC8", Offset = "0x16FDEC8", VA = "0x16FDEC8")]
		public void SetField(string name, string val)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x16FE008", Offset = "0x16FE008", VA = "0x16FE008")]
		public void SetField(string name, bool val)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x16FE088", Offset = "0x16FE088", VA = "0x16FE088")]
		public void SetField(string name, float val)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x16FE110", Offset = "0x16FE110", VA = "0x16FE110")]
		public void SetField(string name, int val)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x16FDF48", Offset = "0x16FDF48", VA = "0x16FDF48")]
		public void SetField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x16FE260", Offset = "0x16FE260", VA = "0x16FE260")]
		public void RemoveField(string name)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x16FE340", Offset = "0x16FE340", VA = "0x16FE340")]
		public bool GetField(out bool field, string name, bool fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x16FE350", Offset = "0x16FE350", VA = "0x16FE350")]
		public bool GetField(ref bool field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x16FE358", Offset = "0x16FE358", VA = "0x16FE358")]
		public bool GetField(ref bool field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x16FE444", Offset = "0x16FE444", VA = "0x16FE444")]
		public bool GetField(out float field, string name, float fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x16FE450", Offset = "0x16FE450", VA = "0x16FE450")]
		public bool GetField(ref float field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x16FE458", Offset = "0x16FE458", VA = "0x16FE458")]
		public bool GetField(ref float field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x16FE544", Offset = "0x16FE544", VA = "0x16FE544")]
		public bool GetField(out int field, string name, int fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x16FE550", Offset = "0x16FE550", VA = "0x16FE550")]
		public bool GetField(ref int field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x16FE558", Offset = "0x16FE558", VA = "0x16FE558")]
		public bool GetField(ref int field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x16FE690", Offset = "0x16FE690", VA = "0x16FE690")]
		public bool GetField(out long field, string name, long fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x16FE69C", Offset = "0x16FE69C", VA = "0x16FE69C")]
		public bool GetField(ref long field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x16FE6A4", Offset = "0x16FE6A4", VA = "0x16FE6A4")]
		public bool GetField(ref long field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x16FE7DC", Offset = "0x16FE7DC", VA = "0x16FE7DC")]
		public bool GetField(out uint field, string name, uint fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x16FE7E8", Offset = "0x16FE7E8", VA = "0x16FE7E8")]
		public bool GetField(ref uint field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x16FE7F0", Offset = "0x16FE7F0", VA = "0x16FE7F0")]
		public bool GetField(ref uint field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x16FE934", Offset = "0x16FE934", VA = "0x16FE934")]
		public bool GetField(out ulong field, string name, ulong fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x16FE940", Offset = "0x16FE940", VA = "0x16FE940")]
		public bool GetField(ref ulong field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x16FE948", Offset = "0x16FE948", VA = "0x16FE948")]
		public bool GetField(ref ulong field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x16FEA8C", Offset = "0x16FEA8C", VA = "0x16FEA8C")]
		public bool GetField(out string field, string name, string fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x16FEA98", Offset = "0x16FEA98", VA = "0x16FEA98")]
		public bool GetField(ref string field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x16FEAA0", Offset = "0x16FEAA0", VA = "0x16FEAA0")]
		public bool GetField(ref string field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x16FEB94", Offset = "0x16FEB94", VA = "0x16FEB94")]
		public void GetField(string name, GetFieldResponse response, [Optional] FieldNotFound fail)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x16FECA0", Offset = "0x16FECA0", VA = "0x16FECA0")]
		public JSONObject GetField(string name)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x16FED9C", Offset = "0x16FED9C", VA = "0x16FED9C")]
		public bool HasFields(string[] names)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x16FE190", Offset = "0x16FE190", VA = "0x16FE190")]
		public bool HasField(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x16FEE70", Offset = "0x16FEE70", VA = "0x16FEE70")]
		public void Clear()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x16FEF18", Offset = "0x16FEF18", VA = "0x16FEF18")]
		public JSONObject Copy()
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x16FEFA0", Offset = "0x16FEFA0", VA = "0x16FEFA0")]
		public void Merge(JSONObject obj)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x16FF010", Offset = "0x16FF010", VA = "0x16FF010")]
		private static void MergeRecur(JSONObject left, JSONObject right)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x16FF43C", Offset = "0x16FF43C", VA = "0x16FF43C")]
		public void Bake()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x16FF478", Offset = "0x16FF478", VA = "0x16FF478")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838980", Offset = "0x838980")]
		public IEnumerable BakeAsync()
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x16FEF98", Offset = "0x16FEF98", VA = "0x16FEF98")]
		public string Print()
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x16FF4E4", Offset = "0x16FF4E4", VA = "0x16FF4E4")]
		public string Print(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x16FFCB0", Offset = "0x16FFCB0", VA = "0x16FFCB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8389E0", Offset = "0x8389E0")]
		public IEnumerable<string> PrintAsync(bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x16FFD30", Offset = "0x16FFD30", VA = "0x16FFD30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838A40", Offset = "0x838A40")]
		private IEnumerable StringifyAsync(int depth, StringBuilder builder, bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x16FF570", Offset = "0x16FF570", VA = "0x16FF570")]
		private void Stringify(int depth, StringBuilder builder, bool pretty = false)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x16FFDCC", Offset = "0x16FFDCC", VA = "0x16FFDCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x16FFDD4", Offset = "0x16FFDD4", VA = "0x16FFDD4")]
		public string ToString(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x16FFDDC", Offset = "0x16FFDDC", VA = "0x16FFDDC")]
		public Dictionary<string, string> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x16FD89C", Offset = "0x16FD89C", VA = "0x16FD89C")]
		public static implicit operator bool(JSONObject o)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000055")]
	public static class JSONTemplates
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly HashSet<object> touched;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x17000C4", Offset = "0x17000C4", VA = "0x17000C4")]
		public static JSONObject TOJSON(object obj)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1700D30", Offset = "0x1700D30", VA = "0x1700D30")]
		public static Vector2 ToVector2(JSONObject obj)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1700E58", Offset = "0x1700E58", VA = "0x1700E58")]
		public static JSONObject FromVector2(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1700F30", Offset = "0x1700F30", VA = "0x1700F30")]
		public static JSONObject FromVector3(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1701044", Offset = "0x1701044", VA = "0x1701044")]
		public static Vector3 ToVector3(JSONObject obj)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x17011D4", Offset = "0x17011D4", VA = "0x17011D4")]
		public static JSONObject FromVector4(Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x170131C", Offset = "0x170131C", VA = "0x170131C")]
		public static Vector4 ToVector4(JSONObject obj)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x170153C", Offset = "0x170153C", VA = "0x170153C")]
		public static JSONObject FromMatrix4x4(Matrix4x4 m)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x17018A8", Offset = "0x17018A8", VA = "0x17018A8")]
		public static Matrix4x4 ToMatrix4x4(JSONObject obj)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1701FCC", Offset = "0x1701FCC", VA = "0x1701FCC")]
		public static JSONObject FromQuaternion(Quaternion q)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1702114", Offset = "0x1702114", VA = "0x1702114")]
		public static Quaternion ToQuaternion(JSONObject obj)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1702334", Offset = "0x1702334", VA = "0x1702334")]
		public static JSONObject FromColor(Color c)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x170247C", Offset = "0x170247C", VA = "0x170247C")]
		public static Color ToColor(JSONObject obj)
		{
			return default(Color);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1702684", Offset = "0x1702684", VA = "0x1702684")]
		public static JSONObject FromLayerMask(LayerMask l)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1702724", Offset = "0x1702724", VA = "0x1702724")]
		public static LayerMask ToLayerMask(JSONObject obj)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x17027A4", Offset = "0x17027A4", VA = "0x17027A4")]
		public static JSONObject FromRect(Rect r)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x170292C", Offset = "0x170292C", VA = "0x170292C")]
		public static Rect ToRect(JSONObject obj)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1702B48", Offset = "0x1702B48", VA = "0x1702B48")]
		public static JSONObject FromRectOffset(RectOffset r)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1702CC8", Offset = "0x1702CC8", VA = "0x1702CC8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8369DC", Offset = "0x8369DC")]
		private sealed class <>c
		{
			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__21_0;

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x2129C84", Offset = "0x2129C84", VA = "0x2129C84")]
			public <>c()
			{
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x2129C8C", Offset = "0x2129C8C", VA = "0x2129C8C")]
			internal string <GetAll>b__21_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<BadWordProvider> badWordProviderLTR;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<BadWordProvider> badWordProviderRTL;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string ReplaceCharacters;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool Fuzzy;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<BadWordProvider> tempBadWordProviderLTR;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<BadWordProvider> tempBadWordProviderRTL;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, Regex> exactBadwordsRegex;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, Regex> fuzzyBadwordsRegex;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, List<Regex>> debugFuzzyBadwordsRegex;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool isReady;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool isReadyFirstime;

		[Token(Token = "0x1700003C")]
		public List<BadWordProvider> BadWordProviderLTR
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x16120E0", Offset = "0x16120E0", VA = "0x16120E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x16120E8", Offset = "0x16120E8", VA = "0x16120E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x16124C4", Offset = "0x16124C4", VA = "0x16124C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x16124CC", Offset = "0x16124CC", VA = "0x16124CC")]
			set
			{
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x16128A8", Offset = "0x16128A8", VA = "0x16128A8")]
		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters, bool fuzzy, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x16129E0", Offset = "0x16129E0", VA = "0x16129E0", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1613170", Offset = "0x1613170", VA = "0x1613170", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x16147EC", Offset = "0x16147EC", VA = "0x16147EC", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1618848", Offset = "0x1618848", VA = "0x1618848", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x161CB30", Offset = "0x161CB30", VA = "0x161CB30", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8369EC", Offset = "0x8369EC")]
		private sealed class <>c
		{
			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x212AB84", Offset = "0x212AB84", VA = "0x212AB84")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x212AB8C", Offset = "0x212AB8C", VA = "0x212AB8C")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836B6C", Offset = "0x836B6C")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x1700003E")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x161F08C", Offset = "0x161F08C", VA = "0x161F08C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838AA0", Offset = "0x838AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x161F094", Offset = "0x161F094", VA = "0x161F094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838AB0", Offset = "0x838AB0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public int CharacterNumber
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x161F09C", Offset = "0x161F09C", VA = "0x161F09C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x161F0A4", Offset = "0x161F0A4", VA = "0x161F0A4")]
			set
			{
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x161F16C", Offset = "0x161F16C", VA = "0x161F16C")]
		public CapitalizationFilter(int capitalizationCharsNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x161F1B4", Offset = "0x161F1B4", VA = "0x161F1B4", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x161F1BC", Offset = "0x161F1BC", VA = "0x161F1BC", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x161F228", Offset = "0x161F228", VA = "0x161F228", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x161F98C", Offset = "0x161F98C", VA = "0x161F98C", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x161FFB4", Offset = "0x161FFB4", VA = "0x161FFB4", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8369FC", Offset = "0x8369FC")]
		private sealed class <>c
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__13_0;

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x20502DC", Offset = "0x20502DC", VA = "0x20502DC")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x20502E4", Offset = "0x20502E4", VA = "0x20502E4")]
			internal string <GetAll>b__13_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<DomainProvider> domainProvider;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string ReplaceCharacters;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<DomainProvider> tempDomainProvider;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> domainsRegex;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, List<Regex>> debugDomainsRegex;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isReady;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool isReadyFirstime;

		[Token(Token = "0x17000040")]
		public List<DomainProvider> DomainProvider
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x16F0D58", Offset = "0x16F0D58", VA = "0x16F0D58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x16F0D60", Offset = "0x16F0D60", VA = "0x16F0D60")]
			set
			{
			}
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x16F10C4", Offset = "0x16F10C4", VA = "0x16F10C4")]
		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x16F1254", Offset = "0x16F1254", VA = "0x16F1254", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x16F16BC", Offset = "0x16F16BC", VA = "0x16F16BC", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x16F241C", Offset = "0x16F241C", VA = "0x16F241C", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x16F46D8", Offset = "0x16F46D8", VA = "0x16F46D8", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x16F6BB0", Offset = "0x16F6BB0", VA = "0x16F6BB0", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A0C", Offset = "0x836A0C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, Source>, string> <>9__8_0;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, Source>, Source> <>9__8_1;

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x20511D8", Offset = "0x20511D8", VA = "0x20511D8")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x20511E0", Offset = "0x20511E0", VA = "0x20511E0")]
			internal string <Sources>b__8_0(KeyValuePair<string, Source> x)
			{
				return null;
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x2051220", Offset = "0x2051220", VA = "0x2051220")]
			internal Source <Sources>b__8_1(KeyValuePair<string, Source> y)
			{
				return null;
			}
		}

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string MarkPrefix;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MarkPostfix;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, Source> sources;

		[Token(Token = "0x60003D2")]
		public abstract bool Ready();

		[Token(Token = "0x60003D3")]
		public abstract bool Contains(string testString, params string[] sources);

		[Token(Token = "0x60003D4")]
		public abstract List<string> GetAll(string testString, params string[] sources);

		[Token(Token = "0x60003D5")]
		public abstract string ReplaceAll(string testString, params string[] sources);

		[Token(Token = "0x60003D6")]
		public abstract string Replace(string text, List<string> badWords);

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x16F92E8", Offset = "0x16F92E8", VA = "0x16F92E8", Slot = "9")]
		public virtual List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x16F9560", Offset = "0x16F9560", VA = "0x16F9560", Slot = "10")]
		public virtual string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x16F9770", Offset = "0x16F9770", VA = "0x16F9770", Slot = "11")]
		public virtual string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x16F23A8", Offset = "0x16F23A8", VA = "0x16F23A8")]
		protected void logFilterNotReady()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x16F23A4", Offset = "0x16F23A4", VA = "0x16F23A4")]
		protected void logResourceNotFound(string res)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x16F23A0", Offset = "0x16F23A0", VA = "0x16F23A0")]
		protected void logContains()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x16F46D4", Offset = "0x16F46D4", VA = "0x16F46D4")]
		protected void logGetAll()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x16F6A14", Offset = "0x16F6A14", VA = "0x16F6A14")]
		protected void logReplaceAll()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x16F11A4", Offset = "0x16F11A4", VA = "0x16F11A4")]
		protected Filter()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class PunctuationFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A1C", Offset = "0x836A1C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x2055400", Offset = "0x2055400", VA = "0x2055400")]
			public <>c()
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x2055408", Offset = "0x2055408", VA = "0x2055408")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836B7C", Offset = "0x836B7C")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000041")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x211CEAC", Offset = "0x211CEAC", VA = "0x211CEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838AC0", Offset = "0x838AC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x211CEB4", Offset = "0x211CEB4", VA = "0x211CEB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838AD0", Offset = "0x838AD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public int CharacterNumber
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x211CEBC", Offset = "0x211CEBC", VA = "0x211CEBC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x211CEC4", Offset = "0x211CEC4", VA = "0x211CEC4")]
			set
			{
			}
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x211CF8C", Offset = "0x211CF8C", VA = "0x211CF8C")]
		public PunctuationFilter(int punctuationCharacterNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x211CFD4", Offset = "0x211CFD4", VA = "0x211CFD4", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x211CFDC", Offset = "0x211CFDC", VA = "0x211CFDC", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x211D048", Offset = "0x211D048", VA = "0x211D048", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x211D7AC", Offset = "0x211D7AC", VA = "0x211D7AC", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x211DDCC", Offset = "0x211DDCC", VA = "0x211DDCC", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class BadWordManager : Manager
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A2C", Offset = "0x836A2C")]
		private sealed class <initalize>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordManager <>4__this;

			[Token(Token = "0x17000087")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007BE")]
				[Address(RVA = "0x2129EE8", Offset = "0x2129EE8", VA = "0x2129EE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x2129F30", Offset = "0x2129F30", VA = "0x2129F30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x2129C94", Offset = "0x2129C94", VA = "0x2129C94")]
			[DebuggerHidden]
			public <initalize>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x2129CC0", Offset = "0x2129CC0", VA = "0x2129CC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x2129CC4", Offset = "0x2129CC4", VA = "0x2129CC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x2129EF0", Offset = "0x2129EF0", VA = "0x2129EF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836B8C", Offset = "0x836B8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836B8C", Offset = "0x836B8C")]
		public List<BadWordProvider> BadWordProviderLTR;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836BEC", Offset = "0x836BEC")]
		public List<BadWordProvider> BadWordProviderRTL;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836C24", Offset = "0x836C24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836C24", Offset = "0x836C24")]
		public string ReplaceChars;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836C84", Offset = "0x836C84")]
		public bool Fuzzy;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BadWordFilter filter;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000276")]
		private const string clazz = "BadWordManager";

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x161CE24", Offset = "0x161CE24", VA = "0x161CE24")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x161CFFC", Offset = "0x161CFFC", VA = "0x161CFFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838AE0", Offset = "0x838AE0")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x161D068", Offset = "0x161D068", VA = "0x161D068")]
		public static BadWordFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x161D0CC", Offset = "0x161D0CC", VA = "0x161D0CC")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x161D3F4", Offset = "0x161D3F4", VA = "0x161D3F4")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x161D514", Offset = "0x161D514", VA = "0x161D514")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x161D614", Offset = "0x161D614", VA = "0x161D614")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x161D750", Offset = "0x161D750", VA = "0x161D750")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x161D850", Offset = "0x161D850", VA = "0x161D850")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x161D950", Offset = "0x161D950", VA = "0x161D950")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x161DA6C", Offset = "0x161DA6C", VA = "0x161DA6C")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x161D1B0", Offset = "0x161D1B0", VA = "0x161D1B0")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x161DB74", Offset = "0x161DB74", VA = "0x161DB74")]
		public BadWordManager()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class CapitalizationManager : Manager
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836CBC", Offset = "0x836CBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836CBC", Offset = "0x836CBC")]
		public int CapitalizationCharsNumber;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CapitalizationFilter filter;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x400027C")]
		private const string clazz = "CapitalizationManager";

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1620258", Offset = "0x1620258", VA = "0x1620258")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1620540", Offset = "0x1620540", VA = "0x1620540")]
		public static CapitalizationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x16205A4", Offset = "0x16205A4", VA = "0x16205A4")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1620618", Offset = "0x1620618", VA = "0x1620618")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x162097C", Offset = "0x162097C", VA = "0x162097C")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1620A7C", Offset = "0x1620A7C", VA = "0x1620A7C")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1620BB8", Offset = "0x1620BB8", VA = "0x1620BB8")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1620CB8", Offset = "0x1620CB8", VA = "0x1620CB8")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1620DB8", Offset = "0x1620DB8", VA = "0x1620DB8")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1620ED4", Offset = "0x1620ED4", VA = "0x1620ED4")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1620738", Offset = "0x1620738", VA = "0x1620738")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1620FDC", Offset = "0x1620FDC", VA = "0x1620FDC")]
		public CapitalizationManager()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class DomainManager : Manager
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A3C", Offset = "0x836A3C")]
		private sealed class <initalize>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainManager <>4__this;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C4")]
				[Address(RVA = "0x2050528", Offset = "0x2050528", VA = "0x2050528", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C6")]
				[Address(RVA = "0x2050570", Offset = "0x2050570", VA = "0x2050570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x20502EC", Offset = "0x20502EC", VA = "0x20502EC")]
			[DebuggerHidden]
			public <initalize>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x2050318", Offset = "0x2050318", VA = "0x2050318", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x205031C", Offset = "0x205031C", VA = "0x205031C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x2050530", Offset = "0x2050530", VA = "0x2050530", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836D1C", Offset = "0x836D1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836D1C", Offset = "0x836D1C")]
		public List<DomainProvider> DomainProvider;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836D7C", Offset = "0x836D7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836D7C", Offset = "0x836D7C")]
		public string ReplaceChars;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DomainFilter filter;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000283")]
		private const string clazz = "DomainManager";

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x16F6EA0", Offset = "0x16F6EA0", VA = "0x16F6EA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x16F7078", Offset = "0x16F7078", VA = "0x16F7078")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838B40", Offset = "0x838B40")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x16F70E4", Offset = "0x16F70E4", VA = "0x16F70E4")]
		public static DomainFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x16F7148", Offset = "0x16F7148", VA = "0x16F7148")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x16F7470", Offset = "0x16F7470", VA = "0x16F7470")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x16F7590", Offset = "0x16F7590", VA = "0x16F7590")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x16F7690", Offset = "0x16F7690", VA = "0x16F7690")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x16F77CC", Offset = "0x16F77CC", VA = "0x16F77CC")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x16F78CC", Offset = "0x16F78CC", VA = "0x16F78CC")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x16F79CC", Offset = "0x16F79CC", VA = "0x16F79CC")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x16F7AE8", Offset = "0x16F7AE8", VA = "0x16F7AE8")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x16F722C", Offset = "0x16F722C", VA = "0x16F722C")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x16F7BF0", Offset = "0x16F7BF0", VA = "0x16F7BF0")]
		public DomainManager()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public abstract class Manager : MonoBehaviour
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836DDC", Offset = "0x836DDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836DDC", Offset = "0x836DDC")]
		public string MarkPrefix;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836E3C", Offset = "0x836E3C")]
		public string MarkPostfix;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1A350E8", Offset = "0x1A350E8", VA = "0x1A350E8")]
		protected Manager()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class PunctuationManager : Manager
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836E74", Offset = "0x836E74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836E74", Offset = "0x836E74")]
		public int PunctuationCharsNumber;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PunctuationFilter filter;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x400028B")]
		private const string clazz = "PunctuationManager";

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool loggedFilterIsNull;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x211E080", Offset = "0x211E080", VA = "0x211E080")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x211E368", Offset = "0x211E368", VA = "0x211E368")]
		public static PunctuationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x211E3CC", Offset = "0x211E3CC", VA = "0x211E3CC")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x211E440", Offset = "0x211E440", VA = "0x211E440")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x211E7A4", Offset = "0x211E7A4", VA = "0x211E7A4")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x211E8A4", Offset = "0x211E8A4", VA = "0x211E8A4")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x211E9E0", Offset = "0x211E9E0", VA = "0x211E9E0")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x211EAE0", Offset = "0x211EAE0", VA = "0x211EAE0")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x211EBE0", Offset = "0x211EBE0", VA = "0x211EBE0")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x211ECFC", Offset = "0x211ECFC", VA = "0x211ECFC")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x211E560", Offset = "0x211E560", VA = "0x211E560")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x211EE04", Offset = "0x211EE04", VA = "0x211EE04")]
		public PunctuationManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class BadWords
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Source Source;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> BadWordList;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x161EE90", Offset = "0x161EE90", VA = "0x161EE90")]
		public BadWords(Source source, List<string> badWordList)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x161EEC8", Offset = "0x161EEC8", VA = "0x161EEC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class Domains
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Source Source;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> DomainList;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x16F8D70", Offset = "0x16F8D70", VA = "0x16F8D70")]
		public Domains(Source source, List<string> domainList)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x16F8DA8", Offset = "0x16F8DA8", VA = "0x16F8DA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public abstract class Source
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836ED4", Offset = "0x836ED4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836ED4", Offset = "0x836ED4")]
		public string Name;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836F34", Offset = "0x836F34")]
		public string Description;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836F6C", Offset = "0x836F6C")]
		public Sprite Icon;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2121304", Offset = "0x2121304", VA = "0x2121304", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x21214D8", Offset = "0x21214D8", VA = "0x21214D8")]
		protected Source()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public static class MultiManager
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A4C", Offset = "0x836A4C")]
		private sealed class <>c
		{
			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Source, string> <>9__2_0;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, string> <>9__4_0;

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x2055378", Offset = "0x2055378", VA = "0x2055378")]
			public <>c()
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x2055380", Offset = "0x2055380", VA = "0x2055380")]
			internal string <Sources>b__2_0(Source x)
			{
				return null;
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x2055398", Offset = "0x2055398", VA = "0x2055398")]
			internal string <GetAll>b__4_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1A36D5C", Offset = "0x1A36D5C", VA = "0x1A36D5C")]
		public static Filter Filter(ManagerMask mask = ManagerMask.BadWord)
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1A36F60", Offset = "0x1A36F60", VA = "0x1A36F60")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1A37074", Offset = "0x1A37074", VA = "0x1A37074")]
		public static List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1A37360", Offset = "0x1A37360", VA = "0x1A37360")]
		public static bool Contains(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1A37604", Offset = "0x1A37604", VA = "0x1A37604")]
		public static List<string> GetAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1A37944", Offset = "0x1A37944", VA = "0x1A37944")]
		public static string ReplaceAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1A37AE0", Offset = "0x1A37AE0", VA = "0x1A37AE0")]
		public static string Replace(string text, List<string> badWords, ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1A37C7C", Offset = "0x1A37C7C", VA = "0x1A37C7C")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1A37D2C", Offset = "0x1A37D2C", VA = "0x1A37D2C")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	public abstract class BadWordProvider : Provider
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> exactBadwordsRegex;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, Regex> fuzzyBadwordsRegex;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, List<Regex>> debugFuzzyBadwordsRegex;

		[Token(Token = "0x4000299")]
		protected const string exactRegexStart = "(?<![\\w\\d])";

		[Token(Token = "0x400029A")]
		protected const string exactRegexEnd = "s?(?![\\w\\d])";

		[Token(Token = "0x400029B")]
		protected const string fuzzyRegexStart = "\\b\\w*";

		[Token(Token = "0x400029C")]
		protected const string fuzzyRegexEnd = "\\w*\\b";

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<BadWords> badwords;

		[Token(Token = "0x17000043")]
		public Dictionary<string, Regex> ExactBadwordsRegex
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x161DBCC", Offset = "0x161DBCC", VA = "0x161DBCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x161DBD4", Offset = "0x161DBD4", VA = "0x161DBD4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Dictionary<string, Regex> FuzzyBadwordsRegex
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x161DBDC", Offset = "0x161DBDC", VA = "0x161DBDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x161DBE4", Offset = "0x161DBE4", VA = "0x161DBE4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x161DBEC", Offset = "0x161DBEC", VA = "0x161DBEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x161DBF4", Offset = "0x161DBF4", VA = "0x161DBF4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Dictionary<string, List<Regex>> DebugFuzzyBadwordsRegex
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x161DBFC", Offset = "0x161DBFC", VA = "0x161DBFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x161DC04", Offset = "0x161DC04", VA = "0x161DC04")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x161DC0C", Offset = "0x161DC0C", VA = "0x161DC0C", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x161E7F8", Offset = "0x161E7F8", VA = "0x161E7F8")]
		protected BadWordProvider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class BadWordFile : Source
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836FA4", Offset = "0x836FA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836FA4", Offset = "0x836FA4")]
		public string File;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837004", Offset = "0x837004")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83703C", Offset = "0x83703C")]
		public int SkipFooterLines;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837074", Offset = "0x837074")]
		public char SplitChar;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x161207C", Offset = "0x161207C", VA = "0x161207C")]
		public BadWordFile()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class BadWordProviderFile : BadWordProvider
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A5C", Offset = "0x836A5C")]
		private sealed class <loadFile>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CE")]
				[Address(RVA = "0x2129F9C", Offset = "0x2129F9C", VA = "0x2129F9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D0")]
				[Address(RVA = "0x2129FE4", Offset = "0x2129FE4", VA = "0x2129FE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x2129F38", Offset = "0x2129F38", VA = "0x2129F38")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x2129F64", Offset = "0x2129F64", VA = "0x2129F64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x2129F68", Offset = "0x2129F68", VA = "0x2129F68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x2129FA4", Offset = "0x2129FA4", VA = "0x2129FA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8370AC", Offset = "0x8370AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8370AC", Offset = "0x8370AC")]
		public string FilePathWindows;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83710C", Offset = "0x83710C")]
		public string FilePathOSX;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837144", Offset = "0x837144")]
		public string FilePathLinux;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83717C", Offset = "0x83717C")]
		public BadWordFile[] Resources;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x161E954", Offset = "0x161E954", VA = "0x161E954", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x161EA68", Offset = "0x161EA68", VA = "0x161EA68", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x161EADC", Offset = "0x161EADC", VA = "0x161EADC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838BA0", Offset = "0x838BA0")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x161EB38", Offset = "0x161EB38", VA = "0x161EB38")]
		public BadWordProviderFile()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class BadWordResource : Source
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8371B4", Offset = "0x8371B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8371B4", Offset = "0x8371B4")]
		public TextAsset Resource;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837214", Offset = "0x837214")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83724C", Offset = "0x83724C")]
		public int SkipFooterLines;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837284", Offset = "0x837284")]
		public char SplitChar;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x161EE1C", Offset = "0x161EE1C", VA = "0x161EE1C")]
		public BadWordResource()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class BadWordProviderResource : BadWordProvider
	{
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A6C", Offset = "0x836A6C")]
		private sealed class <loadResource>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordProviderResource <>4__this;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BadWordResource[] <>7__wrap1;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D4")]
				[Address(RVA = "0x212A37C", Offset = "0x212A37C", VA = "0x212A37C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0x212A3C4", Offset = "0x212A3C4", VA = "0x212A3C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x2129FEC", Offset = "0x2129FEC", VA = "0x2129FEC")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x212A018", Offset = "0x212A018", VA = "0x212A018", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x212A01C", Offset = "0x212A01C", VA = "0x212A01C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x212A384", Offset = "0x212A384", VA = "0x212A384", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8372BC", Offset = "0x8372BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8372BC", Offset = "0x8372BC")]
		public BadWordResource[] Resources;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x161EBA8", Offset = "0x161EBA8", VA = "0x161EBA8", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x161EC40", Offset = "0x161EC40", VA = "0x161EC40", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x161EBD4", Offset = "0x161EBD4", VA = "0x161EBD4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838C00", Offset = "0x838C00")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x161ECB4", Offset = "0x161ECB4", VA = "0x161ECB4")]
		public BadWordProviderResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class BadWordWeb : Source
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83731C", Offset = "0x83731C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83731C", Offset = "0x83731C")]
		public string URL;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83737C", Offset = "0x83737C")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8373B4", Offset = "0x8373B4")]
		public int SkipFooterLines;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8373EC", Offset = "0x8373EC")]
		public char SplitChar;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x161EE2C", Offset = "0x161EE2C", VA = "0x161EE2C")]
		public BadWordWeb()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class BadWordProviderWeb : BadWordProvider
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A7C", Offset = "0x836A7C")]
		private sealed class <loadWeb>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordProviderWeb <>4__this;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BadWordWeb[] <>7__wrap1;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private BadWordWeb <res>5__4;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWWwrapper <www>5__5;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0x212AAD4", Offset = "0x212AAD4", VA = "0x212AAD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DC")]
				[Address(RVA = "0x212AB1C", Offset = "0x212AB1C", VA = "0x212AB1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x212A3CC", Offset = "0x212A3CC", VA = "0x212A3CC")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x212A3F8", Offset = "0x212A3F8", VA = "0x212A3F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x212A3FC", Offset = "0x212A3FC", VA = "0x212A3FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x212AADC", Offset = "0x212AADC", VA = "0x212AADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x837424", Offset = "0x837424")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837424", Offset = "0x837424")]
		public string MainURL;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837484", Offset = "0x837484")]
		public BadWordWeb[] Resources;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x161ECB8", Offset = "0x161ECB8", VA = "0x161ECB8", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x161ED50", Offset = "0x161ED50", VA = "0x161ED50", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x161ECE4", Offset = "0x161ECE4", VA = "0x161ECE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838C60", Offset = "0x838C60")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x161EDC4", Offset = "0x161EDC4", VA = "0x161EDC4")]
		public BadWordProviderWeb()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public abstract class DomainProvider : Provider
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Regex> domainsRegex;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, List<Regex>> debugDomainsRegex;

		[Token(Token = "0x40002B3")]
		private const string domainRegexStart = "\\b{0,1}((ht|f)tp(s?)\\:\\/\\/)?[\\w\\-\\.\\@]*[\\.]";

		[Token(Token = "0x40002B4")]
		private const string domainRegexEnd = "(:(0-9)*)?(\\/|\\b)([a-zA-Z0-9\\-\\.\\?\\!\\,\\=\\'\\/\\&\\%#_]*)?\\b";

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected List<Domains> domains;

		[Token(Token = "0x17000047")]
		public Dictionary<string, Regex> DomainsRegex
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x16F7C48", Offset = "0x16F7C48", VA = "0x16F7C48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x16F7C50", Offset = "0x16F7C50", VA = "0x16F7C50")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x16F7C58", Offset = "0x16F7C58", VA = "0x16F7C58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x16F7C60", Offset = "0x16F7C60", VA = "0x16F7C60")]
			protected set
			{
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x16F7C68", Offset = "0x16F7C68", VA = "0x16F7C68", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x16F8664", Offset = "0x16F8664", VA = "0x16F8664")]
		protected DomainProvider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class DomainFile : Source
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8374BC", Offset = "0x8374BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8374BC", Offset = "0x8374BC")]
		public string File;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83751C", Offset = "0x83751C")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837554", Offset = "0x837554")]
		public int SkipFooterLines;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83758C", Offset = "0x83758C")]
		public char SplitChar;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x16F0CF4", Offset = "0x16F0CF4", VA = "0x16F0CF4")]
		public DomainFile()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class DomainProviderFile : DomainProvider
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A8C", Offset = "0x836A8C")]
		private sealed class <loadFile>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E0")]
				[Address(RVA = "0x20505DC", Offset = "0x20505DC", VA = "0x20505DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x2050624", Offset = "0x2050624", VA = "0x2050624", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x2050578", Offset = "0x2050578", VA = "0x2050578")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x20505A4", Offset = "0x20505A4", VA = "0x20505A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x20505A8", Offset = "0x20505A8", VA = "0x20505A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x20505E4", Offset = "0x20505E4", VA = "0x20505E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8375C4", Offset = "0x8375C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8375C4", Offset = "0x8375C4")]
		public string FilePathWindows;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837624", Offset = "0x837624")]
		public string FilePathOSX;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83765C", Offset = "0x83765C")]
		public string FilePathLinux;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837694", Offset = "0x837694")]
		public DomainFile[] Resources;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x16F8788", Offset = "0x16F8788", VA = "0x16F8788", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x16F8948", Offset = "0x16F8948", VA = "0x16F8948", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x16F89BC", Offset = "0x16F89BC", VA = "0x16F89BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838CC0", Offset = "0x838CC0")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x16F8A18", Offset = "0x16F8A18", VA = "0x16F8A18")]
		public DomainProviderFile()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class DomainResource : Source
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8376CC", Offset = "0x8376CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8376CC", Offset = "0x8376CC")]
		public TextAsset Resource;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83772C", Offset = "0x83772C")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837764", Offset = "0x837764")]
		public int SkipFooterLines;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83779C", Offset = "0x83779C")]
		public char SplitChar;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x16F8CFC", Offset = "0x16F8CFC", VA = "0x16F8CFC")]
		public DomainResource()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class DomainProviderResource : DomainProvider
	{
		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836A9C", Offset = "0x836A9C")]
		private sealed class <loadResource>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainProviderResource <>4__this;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DomainResource[] <>7__wrap1;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E6")]
				[Address(RVA = "0x20509C0", Offset = "0x20509C0", VA = "0x20509C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E8")]
				[Address(RVA = "0x2050A08", Offset = "0x2050A08", VA = "0x2050A08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x205062C", Offset = "0x205062C", VA = "0x205062C")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x2050658", Offset = "0x2050658", VA = "0x2050658", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x205065C", Offset = "0x205065C", VA = "0x205065C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x20509C8", Offset = "0x20509C8", VA = "0x20509C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8377D4", Offset = "0x8377D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8377D4", Offset = "0x8377D4")]
		public DomainResource[] Resources;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x16F8A88", Offset = "0x16F8A88", VA = "0x16F8A88", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x16F8B20", Offset = "0x16F8B20", VA = "0x16F8B20", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x16F8AB4", Offset = "0x16F8AB4", VA = "0x16F8AB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838D20", Offset = "0x838D20")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x16F8B94", Offset = "0x16F8B94", VA = "0x16F8B94")]
		public DomainProviderResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class DomainWeb : Source
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x837834", Offset = "0x837834")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837834", Offset = "0x837834")]
		public string URL;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837894", Offset = "0x837894")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8378CC", Offset = "0x8378CC")]
		public int SkipFooterLines;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837904", Offset = "0x837904")]
		public char SplitChar;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x16F8D0C", Offset = "0x16F8D0C", VA = "0x16F8D0C")]
		public DomainWeb()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class DomainProviderWeb : DomainProvider
	{
		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836AAC", Offset = "0x836AAC")]
		private sealed class <loadWeb>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainProviderWeb <>4__this;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DomainWeb[] <>7__wrap1;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <>7__wrap2;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private DomainWeb <res>5__4;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWWwrapper <www>5__5;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x2051128", Offset = "0x2051128", VA = "0x2051128", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x2051170", Offset = "0x2051170", VA = "0x2051170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x2050A10", Offset = "0x2050A10", VA = "0x2050A10")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x2050A3C", Offset = "0x2050A3C", VA = "0x2050A3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x2050A40", Offset = "0x2050A40", VA = "0x2050A40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x2051130", Offset = "0x2051130", VA = "0x2051130", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83793C", Offset = "0x83793C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83793C", Offset = "0x83793C")]
		public string MainURL;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83799C", Offset = "0x83799C")]
		public DomainWeb[] Resources;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x16F8B98", Offset = "0x16F8B98", VA = "0x16F8B98", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x16F8C30", Offset = "0x16F8C30", VA = "0x16F8C30", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x16F8BC4", Offset = "0x16F8BC4", VA = "0x16F8BC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838D80", Offset = "0x838D80")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x16F8CA4", Offset = "0x16F8CA4", VA = "0x16F8CA4")]
		public DomainProviderWeb()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class Provider : MonoBehaviour
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8379D4", Offset = "0x8379D4")]
		public string Name;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x837A0C", Offset = "0x837A0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837A0C", Offset = "0x837A0C")]
		public RegexOptions RegexOption1;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837A6C", Offset = "0x837A6C")]
		public RegexOptions RegexOption2;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837AA4", Offset = "0x837AA4")]
		public RegexOptions RegexOption3;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837ADC", Offset = "0x837ADC")]
		public RegexOptions RegexOption4;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837B14", Offset = "0x837B14")]
		public RegexOptions RegexOption5;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool ready;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static bool loggedUnsupportedPlatform;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Source> sources;

		[Token(Token = "0x17000049")]
		public bool Ready
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x211CBE4", Offset = "0x211CBE4", VA = "0x211CBE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x211CBEC", Offset = "0x211CBEC", VA = "0x211CBEC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public List<Source> Sources
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x211CBF8", Offset = "0x211CBF8", VA = "0x211CBF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x211CC00", Offset = "0x211CC00", VA = "0x211CC00")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000462")]
		public abstract void Load();

		[Token(Token = "0x6000463")]
		public abstract void Save();

		[Token(Token = "0x6000464")]
		protected abstract void init();

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x211CC08", Offset = "0x211CC08", VA = "0x211CC08")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x211CC14", Offset = "0x211CC14", VA = "0x211CC14")]
		protected void logNoResourcesAdded()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x211CE00", Offset = "0x211CE00", VA = "0x211CE00")]
		protected Provider()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public static class Constants
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string ASSET_NAME;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string ASSET_VERSION;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ASSET_BUILD;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly string ASSET_AUTHOR;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly string ASSET_AUTHOR_URL;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly string ASSET_URL;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly string ASSET_CONTACT;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly Guid ASSET_UID;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly string PREFAB_PATH;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly bool DEBUG_BADWORDS;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public static readonly bool DEBUG_DOMAINS;
	}
	[Token(Token = "0x2000074")]
	public static class Helper
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex lineEndingsRegex;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Random rd;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x16F989C", Offset = "0x16F989C", VA = "0x16F989C")]
		public static bool WindowsPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x16F98D4", Offset = "0x16F98D4", VA = "0x16F98D4")]
		public static bool OSXPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x16F9904", Offset = "0x16F9904", VA = "0x16F9904")]
		public static bool LinuxPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x16F8898", Offset = "0x16F8898", VA = "0x16F8898")]
		public static bool SupportedPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x16F9924", Offset = "0x16F9924", VA = "0x16F9924")]
		public static string ValidatePath(string path)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x16F99C8", Offset = "0x16F99C8", VA = "0x16F99C8")]
		public static List<string> SplitStringToLines(string text, int skipHeaderLines = 0, int skipFooterLines = 0, char splitChar = '#')
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x16F6A18", Offset = "0x16F6A18", VA = "0x16F6A18")]
		public static string CreateReplaceString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		public static void AddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x16F9C80", Offset = "0x16F9C80", VA = "0x16F9C80")]
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
		[Token(Token = "0x40002E1")]
		private const uint PRIME32_1 = 2654435761u;

		[Token(Token = "0x40002E2")]
		private const uint PRIME32_2 = 2246822519u;

		[Token(Token = "0x40002E3")]
		private const uint PRIME32_3 = 3266489917u;

		[Token(Token = "0x40002E4")]
		private const uint PRIME32_4 = 668265263u;

		[Token(Token = "0x40002E5")]
		private const uint PRIME32_5 = 374761393u;

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2129688", Offset = "0x2129688", VA = "0x2129688")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return default(uint);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2129A48", Offset = "0x2129A48", VA = "0x2129A48")]
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
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private byte currentCryptoKey;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool fakeValue;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		[SerializeField]
		private bool fakeValueChanged;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1A37DCC", Offset = "0x1A37DCC", VA = "0x1A37DCC")]
		private ObscuredBool(int value)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1A37E54", Offset = "0x1A37E54", VA = "0x1A37E54")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1A37EBC", Offset = "0x1A37EBC", VA = "0x1A37EBC")]
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1A37F20", Offset = "0x1A37F20", VA = "0x1A37F20")]
		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1A37FB4", Offset = "0x1A37FB4", VA = "0x1A37FB4")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1A38018", Offset = "0x1A38018", VA = "0x1A38018")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1A380A4", Offset = "0x1A380A4", VA = "0x1A380A4")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1A3828C", Offset = "0x1A3828C", VA = "0x1A3828C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1A38324", Offset = "0x1A38324", VA = "0x1A38324")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1A38348", Offset = "0x1A38348", VA = "0x1A38348")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1A38170", Offset = "0x1A38170", VA = "0x1A38170")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1A383F0", Offset = "0x1A383F0", VA = "0x1A383F0")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1A38498", Offset = "0x1A38498", VA = "0x1A38498")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1A384C4", Offset = "0x1A384C4", VA = "0x1A384C4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1A38550", Offset = "0x1A38550", VA = "0x1A38550", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1A38600", Offset = "0x1A38600", VA = "0x1A38600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1A38630", Offset = "0x1A38630", VA = "0x1A38630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public struct ObscuredByte : IEquatable<ObscuredByte>, IFormattable
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte currentCryptoKey;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte hiddenValue;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private byte fakeValue;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private bool inited;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1A386B0", Offset = "0x1A386B0", VA = "0x1A386B0")]
		private ObscuredByte(byte value)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1A38734", Offset = "0x1A38734", VA = "0x1A38734")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1A3879C", Offset = "0x1A3879C", VA = "0x1A3879C")]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1A38800", Offset = "0x1A38800", VA = "0x1A38800")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1A38880", Offset = "0x1A38880", VA = "0x1A38880")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1A38A84", Offset = "0x1A38A84", VA = "0x1A38A84")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1A38B1C", Offset = "0x1A38B1C", VA = "0x1A38B1C")]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1A38B40", Offset = "0x1A38B40", VA = "0x1A38B40")]
		public void SetEncrypted(byte encrypted)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1A3894C", Offset = "0x1A3894C", VA = "0x1A3894C")]
		private byte InternalDecrypt()
		{
			return default(byte);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1A38B7C", Offset = "0x1A38B7C", VA = "0x1A38B7C")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1A38C08", Offset = "0x1A38C08", VA = "0x1A38C08")]
		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1A38C2C", Offset = "0x1A38C2C", VA = "0x1A38C2C")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1A38CC4", Offset = "0x1A38CC4", VA = "0x1A38CC4")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1A38D5C", Offset = "0x1A38D5C", VA = "0x1A38D5C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1A38DE4", Offset = "0x1A38DE4", VA = "0x1A38DE4", Slot = "4")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1A38E90", Offset = "0x1A38E90", VA = "0x1A38E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1A38EBC", Offset = "0x1A38EBC", VA = "0x1A38EBC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1A38EF0", Offset = "0x1A38EF0", VA = "0x1A38EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1A38F1C", Offset = "0x1A38F1C", VA = "0x1A38F1C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1A38F50", Offset = "0x1A38F50", VA = "0x1A38F50", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public struct ObscuredChar : IEquatable<ObscuredChar>
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static char cryptoKey;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private char currentCryptoKey;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private char hiddenValue;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private char fakeValue;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1A38FE4", Offset = "0x1A38FE4", VA = "0x1A38FE4")]
		private ObscuredChar(char value)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1A3906C", Offset = "0x1A3906C", VA = "0x1A3906C")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1A390D4", Offset = "0x1A390D4", VA = "0x1A390D4")]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1A39138", Offset = "0x1A39138", VA = "0x1A39138")]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1A391B8", Offset = "0x1A391B8", VA = "0x1A391B8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1A393C0", Offset = "0x1A393C0", VA = "0x1A393C0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1A39458", Offset = "0x1A39458", VA = "0x1A39458")]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1A3947C", Offset = "0x1A3947C", VA = "0x1A3947C")]
		public void SetEncrypted(char encrypted)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1A39284", Offset = "0x1A39284", VA = "0x1A39284")]
		private char InternalDecrypt()
		{
			return default(char);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1A394B8", Offset = "0x1A394B8", VA = "0x1A394B8")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1A39544", Offset = "0x1A39544", VA = "0x1A39544")]
		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1A39568", Offset = "0x1A39568", VA = "0x1A39568")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1A39600", Offset = "0x1A39600", VA = "0x1A39600")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1A39698", Offset = "0x1A39698", VA = "0x1A39698", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1A39720", Offset = "0x1A39720", VA = "0x1A39720", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1A397C8", Offset = "0x1A397C8", VA = "0x1A397C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1A397F4", Offset = "0x1A397F4", VA = "0x1A397F4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1A39828", Offset = "0x1A39828", VA = "0x1A39828", Slot = "2")]
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
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public decimal d;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l1;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long l2;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte b5;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte b6;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte b7;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte b8;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte b9;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte b10;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public byte b11;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			public byte b12;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public byte b13;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public byte b14;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public byte b15;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public byte b16;
		}

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long currentCryptoKey;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte[] hiddenValue;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private decimal fakeValue;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool inited;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1A3A490", Offset = "0x1A3A490", VA = "0x1A3A490")]
		private ObscuredDecimal(byte[] value)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1A3A514", Offset = "0x1A3A514", VA = "0x1A3A514")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1A3A57C", Offset = "0x1A3A57C", VA = "0x1A3A57C")]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1A3A5F8", Offset = "0x1A3A5F8", VA = "0x1A3A5F8")]
		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1A3A604", Offset = "0x1A3A604", VA = "0x1A3A604")]
		private static byte[] InternalEncrypt(decimal value)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1A3A678", Offset = "0x1A3A678", VA = "0x1A3A678")]
		private static byte[] InternalEncrypt(decimal value, long key)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1A3A828", Offset = "0x1A3A828", VA = "0x1A3A828")]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1A3A8A4", Offset = "0x1A3A8A4", VA = "0x1A3A8A4")]
		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1A3A8B0", Offset = "0x1A3A8B0", VA = "0x1A3A8B0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1A3AC0C", Offset = "0x1A3AC0C", VA = "0x1A3AC0C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1A3ACAC", Offset = "0x1A3ACAC", VA = "0x1A3ACAC")]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1A3ADA4", Offset = "0x1A3ADA4", VA = "0x1A3ADA4")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1A3A980", Offset = "0x1A3A980", VA = "0x1A3A980")]
		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1A3AF30", Offset = "0x1A3AF30", VA = "0x1A3AF30")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1A3AFEC", Offset = "0x1A3AFEC", VA = "0x1A3AFEC")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1A3AFF0", Offset = "0x1A3AFF0", VA = "0x1A3AFF0")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1A3B128", Offset = "0x1A3B128", VA = "0x1A3B128")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1A3B22C", Offset = "0x1A3B22C", VA = "0x1A3B22C")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1A3B330", Offset = "0x1A3B330", VA = "0x1A3B330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1A3B35C", Offset = "0x1A3B35C", VA = "0x1A3B35C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1A3B398", Offset = "0x1A3B398", VA = "0x1A3B398")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1A3B3D4", Offset = "0x1A3B3D4", VA = "0x1A3B3D4", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1A3B418", Offset = "0x1A3B418", VA = "0x1A3B418", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1A3B4B4", Offset = "0x1A3B4B4", VA = "0x1A3B4B4", Slot = "4")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1A3B50C", Offset = "0x1A3B50C", VA = "0x1A3B50C", Slot = "2")]
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
			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double d;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte b5;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte b6;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte b7;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte b8;
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private double fakeValue;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1A3B58C", Offset = "0x1A3B58C", VA = "0x1A3B58C")]
		private ObscuredDouble(byte[] value)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1A3B610", Offset = "0x1A3B610", VA = "0x1A3B610")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1A3B678", Offset = "0x1A3B678", VA = "0x1A3B678")]
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1A3B6F0", Offset = "0x1A3B6F0", VA = "0x1A3B6F0")]
		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1A3B6FC", Offset = "0x1A3B6FC", VA = "0x1A3B6FC")]
		private static byte[] InternalEncrypt(double value)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1A3B768", Offset = "0x1A3B768", VA = "0x1A3B768")]
		private static byte[] InternalEncrypt(double value, long key)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1A3B898", Offset = "0x1A3B898", VA = "0x1A3B898")]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1A3B908", Offset = "0x1A3B908", VA = "0x1A3B908")]
		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1A3B914", Offset = "0x1A3B914", VA = "0x1A3B914")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1A3BBB8", Offset = "0x1A3BBB8", VA = "0x1A3BBB8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1A3BC50", Offset = "0x1A3BC50", VA = "0x1A3BC50")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1A3BD04", Offset = "0x1A3BD04", VA = "0x1A3BD04")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1A3B9E4", Offset = "0x1A3B9E4", VA = "0x1A3B9E4")]
		private double InternalDecrypt()
		{
			return default(double);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1A3BE10", Offset = "0x1A3BE10", VA = "0x1A3BE10")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1A3BEB0", Offset = "0x1A3BEB0", VA = "0x1A3BEB0")]
		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1A3BEB4", Offset = "0x1A3BEB4", VA = "0x1A3BEB4")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1A3BF5C", Offset = "0x1A3BF5C", VA = "0x1A3BF5C")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1A3C004", Offset = "0x1A3C004", VA = "0x1A3C004", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1A3C030", Offset = "0x1A3C030", VA = "0x1A3C030")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1A3C064", Offset = "0x1A3C064", VA = "0x1A3C064")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1A3C098", Offset = "0x1A3C098", VA = "0x1A3C098", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1A3C0DC", Offset = "0x1A3C0DC", VA = "0x1A3C0DC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1A3C170", Offset = "0x1A3C170", VA = "0x1A3C170", Slot = "4")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1A3C1B0", Offset = "0x1A3C1B0", VA = "0x1A3C1B0", Slot = "2")]
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
			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte b1;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte b2;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte b3;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte b4;
		}

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float fakeValue;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1A3C230", Offset = "0x1A3C230", VA = "0x1A3C230")]
		private ObscuredFloat(byte[] value)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1A3C2B8", Offset = "0x1A3C2B8", VA = "0x1A3C2B8")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1A3C320", Offset = "0x1A3C320", VA = "0x1A3C320")]
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1A3C398", Offset = "0x1A3C398", VA = "0x1A3C398")]
		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1A3C3A4", Offset = "0x1A3C3A4", VA = "0x1A3C3A4")]
		private static byte[] InternalEncrypt(float value)
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1A3C410", Offset = "0x1A3C410", VA = "0x1A3C410")]
		private static byte[] InternalEncrypt(float value, int key)
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1A3C500", Offset = "0x1A3C500", VA = "0x1A3C500")]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1A3C570", Offset = "0x1A3C570", VA = "0x1A3C570")]
		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1A3C57C", Offset = "0x1A3C57C", VA = "0x1A3C57C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1A3C7E0", Offset = "0x1A3C7E0", VA = "0x1A3C7E0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1A3C878", Offset = "0x1A3C878", VA = "0x1A3C878")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1A3C8EC", Offset = "0x1A3C8EC", VA = "0x1A3C8EC")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1A3C64C", Offset = "0x1A3C64C", VA = "0x1A3C64C")]
		private float InternalDecrypt()
		{
			return default(float);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1A3C9B8", Offset = "0x1A3C9B8", VA = "0x1A3C9B8")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1A3B124", Offset = "0x1A3B124", VA = "0x1A3B124")]
		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1A3CA60", Offset = "0x1A3CA60", VA = "0x1A3CA60")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1A3CB10", Offset = "0x1A3CB10", VA = "0x1A3CB10")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1A3CBC0", Offset = "0x1A3CBC0", VA = "0x1A3CBC0")]
		public float getValue()
		{
			return default(float);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1A3CBC4", Offset = "0x1A3CBC4", VA = "0x1A3CBC4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1A3CC60", Offset = "0x1A3CC60", VA = "0x1A3CC60", Slot = "4")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1A3CCA8", Offset = "0x1A3CCA8", VA = "0x1A3CCA8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1A3CCD4", Offset = "0x1A3CCD4", VA = "0x1A3CCD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1A3CD00", Offset = "0x1A3CD00", VA = "0x1A3CD00")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1A3CD34", Offset = "0x1A3CD34", VA = "0x1A3CD34")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1A3CD68", Offset = "0x1A3CD68", VA = "0x1A3CD68", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int fakeValue;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1A3CE00", Offset = "0x1A3CE00", VA = "0x1A3CE00")]
		private ObscuredInt(int value)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1A3CE84", Offset = "0x1A3CE84", VA = "0x1A3CE84")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1A3CEEC", Offset = "0x1A3CEEC", VA = "0x1A3CEEC")]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1A3CF50", Offset = "0x1A3CF50", VA = "0x1A3CF50")]
		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1A3CFCC", Offset = "0x1A3CFCC", VA = "0x1A3CFCC")]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1A3D030", Offset = "0x1A3D030", VA = "0x1A3D030")]
		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1A3D0AC", Offset = "0x1A3D0AC", VA = "0x1A3D0AC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1A3D2AC", Offset = "0x1A3D2AC", VA = "0x1A3D2AC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1A3D348", Offset = "0x1A3D348", VA = "0x1A3D348")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1A3D36C", Offset = "0x1A3D36C", VA = "0x1A3D36C")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1A3D178", Offset = "0x1A3D178", VA = "0x1A3D178")]
		private int InternalDecrypt()
		{
			return default(int);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1A3D3A8", Offset = "0x1A3D3A8", VA = "0x1A3D3A8")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1A3D434", Offset = "0x1A3D434", VA = "0x1A3D434")]
		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1A3D458", Offset = "0x1A3D458", VA = "0x1A3D458")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1A3D55C", Offset = "0x1A3D55C", VA = "0x1A3D55C")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1A3D5F4", Offset = "0x1A3D5F4", VA = "0x1A3D5F4")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1A3D68C", Offset = "0x1A3D68C", VA = "0x1A3D68C")]
		public int getValue()
		{
			return default(int);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1A3D690", Offset = "0x1A3D690", VA = "0x1A3D690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1A3D718", Offset = "0x1A3D718", VA = "0x1A3D718", Slot = "4")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1A3D7C0", Offset = "0x1A3D7C0", VA = "0x1A3D7C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1A3D7EC", Offset = "0x1A3D7EC", VA = "0x1A3D7EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1A3D818", Offset = "0x1A3D818", VA = "0x1A3D818")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1A3D84C", Offset = "0x1A3D84C", VA = "0x1A3D84C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1A3D880", Offset = "0x1A3D880", VA = "0x1A3D880", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public struct ObscuredLong : IEquatable<ObscuredLong>, IFormattable
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private long fakeValue;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1A3D918", Offset = "0x1A3D918", VA = "0x1A3D918")]
		private ObscuredLong(long value)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1A3D99C", Offset = "0x1A3D99C", VA = "0x1A3D99C")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1A3DA04", Offset = "0x1A3DA04", VA = "0x1A3DA04")]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1A3DAE4", Offset = "0x1A3DAE4", VA = "0x1A3DAE4")]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1A3DA68", Offset = "0x1A3DA68", VA = "0x1A3DA68")]
		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1A3DB48", Offset = "0x1A3DB48", VA = "0x1A3DB48")]
		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1A3DBC4", Offset = "0x1A3DBC4", VA = "0x1A3DBC4")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1A3DDC4", Offset = "0x1A3DDC4", VA = "0x1A3DDC4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1A3DE5C", Offset = "0x1A3DE5C", VA = "0x1A3DE5C")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1A3DE80", Offset = "0x1A3DE80", VA = "0x1A3DE80")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1A3DC90", Offset = "0x1A3DC90", VA = "0x1A3DC90")]
		private long InternalDecrypt()
		{
			return default(long);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1A3DEBC", Offset = "0x1A3DEBC", VA = "0x1A3DEBC")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1A3DF5C", Offset = "0x1A3DF5C", VA = "0x1A3DF5C")]
		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1A3DF60", Offset = "0x1A3DF60", VA = "0x1A3DF60")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1A3E000", Offset = "0x1A3E000", VA = "0x1A3E000")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1A3E0A0", Offset = "0x1A3E0A0", VA = "0x1A3E0A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1A3E134", Offset = "0x1A3E134", VA = "0x1A3E134", Slot = "4")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1A3E1DC", Offset = "0x1A3E1DC", VA = "0x1A3E1DC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1A3E208", Offset = "0x1A3E208", VA = "0x1A3E208", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1A3E234", Offset = "0x1A3E234", VA = "0x1A3E234")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1A3E268", Offset = "0x1A3E268", VA = "0x1A3E268")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1A3E29C", Offset = "0x1A3E29C", VA = "0x1A3E29C", Slot = "5")]
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
			[Token(Token = "0x40004CF")]
			Int = 5,
			[Token(Token = "0x40004D0")]
			UInt = 10,
			[Token(Token = "0x40004D1")]
			String = 15,
			[Token(Token = "0x40004D2")]
			Float = 20,
			[Token(Token = "0x40004D3")]
			Double = 25,
			[Token(Token = "0x40004D4")]
			Long = 30,
			[Token(Token = "0x40004D5")]
			Bool = 35,
			[Token(Token = "0x40004D6")]
			ByteArray = 40,
			[Token(Token = "0x40004D7")]
			Vector2 = 45,
			[Token(Token = "0x40004D8")]
			Vector3 = 50,
			[Token(Token = "0x40004D9")]
			Quaternion = 55,
			[Token(Token = "0x40004DA")]
			Color = 60,
			[Token(Token = "0x40004DB")]
			Rect = 65
		}

		[Token(Token = "0x20000C6")]
		public enum DeviceLockLevel : byte
		{
			[Token(Token = "0x40004DD")]
			None,
			[Token(Token = "0x40004DE")]
			Soft,
			[Token(Token = "0x40004DF")]
			Strict
		}

		[Token(Token = "0x400030F")]
		private const byte VERSION = 2;

		[Token(Token = "0x4000310")]
		private const string RAW_NOT_FOUND = "{not_found}";

		[Token(Token = "0x4000311")]
		private const string DATA_SEPARATOR = "|";

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string encryptionKey;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool foreignSavesReported;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string deviceId;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static uint deviceIdHash;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action onAlterationDetected;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static bool preservePlayerPrefs;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action onPossibleForeignSavesDetected;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static DeviceLockLevel lockToDevice;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public static bool readForeignSaves;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public static bool emergencyMode;

		[Token(Token = "0x400031C")]
		private const char DEPRECATED_RAW_SEPARATOR = ':';

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string deprecatedDeviceId;

		[Token(Token = "0x1700004B")]
		public static string DeviceId
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1A41734", Offset = "0x1A41734", VA = "0x1A41734")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1A4185C", Offset = "0x1A4185C", VA = "0x1A4185C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x839A50", Offset = "0x839A50")]
		internal static string DeviceID
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1A41998", Offset = "0x1A41998", VA = "0x1A41998")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1A41A58", Offset = "0x1A41A58", VA = "0x1A41A58")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x1A41AD8", Offset = "0x1A41AD8", VA = "0x1A41AD8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700004E")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1A46A50", Offset = "0x1A46A50", VA = "0x1A46A50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1A41B94", Offset = "0x1A41B94", VA = "0x1A41B94")]
		public static void ForceLockToDeviceInit()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1A41C98", Offset = "0x1A41C98", VA = "0x1A41C98")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1A40F88", Offset = "0x1A40F88", VA = "0x1A40F88")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1A41ED8", Offset = "0x1A41ED8", VA = "0x1A41ED8")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1A4112C", Offset = "0x1A4112C", VA = "0x1A4112C")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1A41E24", Offset = "0x1A41E24", VA = "0x1A41E24")]
		private static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1A42040", Offset = "0x1A42040", VA = "0x1A42040")]
		private static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1A42E24", Offset = "0x1A42E24", VA = "0x1A42E24")]
		public static void SetUInt(string key, uint value)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1A42F64", Offset = "0x1A42F64", VA = "0x1A42F64")]
		public static uint GetUInt(string key)
		{
			return default(uint);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1A42FC8", Offset = "0x1A42FC8", VA = "0x1A42FC8")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1A42EB0", Offset = "0x1A42EB0", VA = "0x1A42EB0")]
		private static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1A430A4", Offset = "0x1A430A4", VA = "0x1A430A4")]
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1A410A0", Offset = "0x1A410A0", VA = "0x1A410A0")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1A4334C", Offset = "0x1A4334C", VA = "0x1A4334C")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1A41440", Offset = "0x1A41440", VA = "0x1A41440")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1A43218", Offset = "0x1A43218", VA = "0x1A43218")]
		public static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1A433C4", Offset = "0x1A433C4", VA = "0x1A433C4")]
		public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1A41014", Offset = "0x1A41014", VA = "0x1A41014")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1A43654", Offset = "0x1A43654", VA = "0x1A43654")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1A412B4", Offset = "0x1A412B4", VA = "0x1A412B4")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1A435A0", Offset = "0x1A435A0", VA = "0x1A435A0")]
		private static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1A436B8", Offset = "0x1A436B8", VA = "0x1A436B8")]
		private static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1A43834", Offset = "0x1A43834", VA = "0x1A43834")]
		public static void SetDouble(string key, double value)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1A43974", Offset = "0x1A43974", VA = "0x1A43974")]
		public static double GetDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1A439D8", Offset = "0x1A439D8", VA = "0x1A439D8")]
		public static double GetDouble(string key, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1A438C0", Offset = "0x1A438C0", VA = "0x1A438C0")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1A43AC0", Offset = "0x1A43AC0", VA = "0x1A43AC0")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1A43C68", Offset = "0x1A43C68", VA = "0x1A43C68")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1A43DA8", Offset = "0x1A43DA8", VA = "0x1A43DA8")]
		public static long GetLong(string key)
		{
			return default(long);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1A43E0C", Offset = "0x1A43E0C", VA = "0x1A43E0C")]
		public static long GetLong(string key, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1A43CF4", Offset = "0x1A43CF4", VA = "0x1A43CF4")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1A43EE8", Offset = "0x1A43EE8", VA = "0x1A43EE8")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1A4405C", Offset = "0x1A4405C", VA = "0x1A4405C")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1A4419C", Offset = "0x1A4419C", VA = "0x1A4419C")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1A44200", Offset = "0x1A44200", VA = "0x1A44200")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1A440E8", Offset = "0x1A440E8", VA = "0x1A440E8")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1A442DC", Offset = "0x1A442DC", VA = "0x1A442DC")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1A4445C", Offset = "0x1A4445C", VA = "0x1A4445C")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1A4455C", Offset = "0x1A4455C", VA = "0x1A4455C")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1A445C4", Offset = "0x1A445C4", VA = "0x1A445C4")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1A444E8", Offset = "0x1A444E8", VA = "0x1A444E8")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1A44770", Offset = "0x1A44770", VA = "0x1A44770")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1A446D0", Offset = "0x1A446D0", VA = "0x1A446D0")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1A448E8", Offset = "0x1A448E8", VA = "0x1A448E8")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1A44A90", Offset = "0x1A44A90", VA = "0x1A44A90")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1A44B10", Offset = "0x1A44B10", VA = "0x1A44B10")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1A4497C", Offset = "0x1A4497C", VA = "0x1A4497C")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1A44BFC", Offset = "0x1A44BFC", VA = "0x1A44BFC")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1A44E40", Offset = "0x1A44E40", VA = "0x1A44E40")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1A45028", Offset = "0x1A45028", VA = "0x1A45028")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1A450B8", Offset = "0x1A450B8", VA = "0x1A450B8")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1A44EE4", Offset = "0x1A44EE4", VA = "0x1A44EE4")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1A451BC", Offset = "0x1A451BC", VA = "0x1A451BC")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1A4544C", Offset = "0x1A4544C", VA = "0x1A4544C")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1A45664", Offset = "0x1A45664", VA = "0x1A45664")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1A456FC", Offset = "0x1A456FC", VA = "0x1A456FC")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1A454F8", Offset = "0x1A454F8", VA = "0x1A454F8")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1A45810", Offset = "0x1A45810", VA = "0x1A45810")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1A45AF8", Offset = "0x1A45AF8", VA = "0x1A45AF8")]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1A45C44", Offset = "0x1A45C44", VA = "0x1A45C44")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1A45CD8", Offset = "0x1A45CD8", VA = "0x1A45CD8")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1A45B90", Offset = "0x1A45B90", VA = "0x1A45B90")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1A45DDC", Offset = "0x1A45DDC", VA = "0x1A45DDC")]
		public static void SetRect(string key, Rect value)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1A46014", Offset = "0x1A46014", VA = "0x1A46014")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1A460A8", Offset = "0x1A460A8", VA = "0x1A460A8")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1A45E88", Offset = "0x1A45E88", VA = "0x1A45E88")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1A461BC", Offset = "0x1A461BC", VA = "0x1A461BC")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1A464D4", Offset = "0x1A464D4", VA = "0x1A464D4")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1A4654C", Offset = "0x1A4654C", VA = "0x1A4654C")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1A465B4", Offset = "0x1A465B4", VA = "0x1A465B4")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1A415C8", Offset = "0x1A415C8", VA = "0x1A415C8")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1A4663C", Offset = "0x1A4663C", VA = "0x1A4663C")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1A46644", Offset = "0x1A46644", VA = "0x1A46644")]
		public static void Save()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1A41F3C", Offset = "0x1A41F3C", VA = "0x1A41F3C")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1A41D1C", Offset = "0x1A41D1C", VA = "0x1A41D1C")]
		private static string EncryptKey(string key)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1A421B4", Offset = "0x1A421B4", VA = "0x1A421B4")]
		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1A4297C", Offset = "0x1A4297C", VA = "0x1A4297C")]
		private static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1A418DC", Offset = "0x1A418DC", VA = "0x1A418DC")]
		private static uint CalculateChecksum(string input)
		{
			return default(uint);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1A468CC", Offset = "0x1A468CC", VA = "0x1A468CC")]
		private static void SavesTampered()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1A46974", Offset = "0x1A46974", VA = "0x1A46974")]
		private static void PossibleForeignSavesDetected()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1A417F4", Offset = "0x1A417F4", VA = "0x1A417F4")]
		private static string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1A467D0", Offset = "0x1A467D0", VA = "0x1A467D0")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1A4249C", Offset = "0x1A4249C", VA = "0x1A4249C")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1A46B14", Offset = "0x1A46B14", VA = "0x1A46B14")]
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
			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int w;
		}

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Quaternion initialFakeValue;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Quaternion fakeValue;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1A46CFC", Offset = "0x1A46CFC", VA = "0x1A46CFC")]
		private ObscuredQuaternion(RawEncryptedQuaternion value)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1A46D98", Offset = "0x1A46D98", VA = "0x1A46D98")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1A46E00", Offset = "0x1A46E00", VA = "0x1A46E00")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1A46E8C", Offset = "0x1A46E8C", VA = "0x1A46E8C")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1A46F6C", Offset = "0x1A46F6C", VA = "0x1A46F6C")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1A46FE0", Offset = "0x1A46FE0", VA = "0x1A46FE0")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1A470B0", Offset = "0x1A470B0", VA = "0x1A470B0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1A4739C", Offset = "0x1A4739C", VA = "0x1A4739C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1A47458", Offset = "0x1A47458", VA = "0x1A47458")]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1A47480", Offset = "0x1A47480", VA = "0x1A47480")]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1A471A4", Offset = "0x1A471A4", VA = "0x1A471A4")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1A474C4", Offset = "0x1A474C4", VA = "0x1A474C4")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1A47620", Offset = "0x1A47620", VA = "0x1A47620")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1A47704", Offset = "0x1A47704", VA = "0x1A47704")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1A47708", Offset = "0x1A47708", VA = "0x1A47708", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1A47738", Offset = "0x1A47738", VA = "0x1A47738", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1A47768", Offset = "0x1A47768", VA = "0x1A47768")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static sbyte cryptoKey;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private sbyte currentCryptoKey;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private sbyte hiddenValue;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private sbyte fakeValue;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private bool inited;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1A47814", Offset = "0x1A47814", VA = "0x1A47814")]
		private ObscuredSByte(sbyte value)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1A47898", Offset = "0x1A47898", VA = "0x1A47898")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1A47900", Offset = "0x1A47900", VA = "0x1A47900")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1A47964", Offset = "0x1A47964", VA = "0x1A47964")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1A479E4", Offset = "0x1A479E4", VA = "0x1A479E4")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1A47BE8", Offset = "0x1A47BE8", VA = "0x1A47BE8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1A47C80", Offset = "0x1A47C80", VA = "0x1A47C80")]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1A47CA4", Offset = "0x1A47CA4", VA = "0x1A47CA4")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1A47AB0", Offset = "0x1A47AB0", VA = "0x1A47AB0")]
		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1A47CE0", Offset = "0x1A47CE0", VA = "0x1A47CE0")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1A47D6C", Offset = "0x1A47D6C", VA = "0x1A47D6C")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1A47D90", Offset = "0x1A47D90", VA = "0x1A47D90")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1A47E28", Offset = "0x1A47E28", VA = "0x1A47E28")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1A47EC0", Offset = "0x1A47EC0", VA = "0x1A47EC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1A47F48", Offset = "0x1A47F48", VA = "0x1A47F48", Slot = "4")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1A47FF4", Offset = "0x1A47FF4", VA = "0x1A47FF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1A48020", Offset = "0x1A48020", VA = "0x1A48020")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1A48054", Offset = "0x1A48054", VA = "0x1A48054", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1A48080", Offset = "0x1A48080", VA = "0x1A48080")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1A480B4", Offset = "0x1A480B4", VA = "0x1A480B4", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static short cryptoKey;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private short currentCryptoKey;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private short hiddenValue;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private short fakeValue;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1A48148", Offset = "0x1A48148", VA = "0x1A48148")]
		private ObscuredShort(short value)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1A481D0", Offset = "0x1A481D0", VA = "0x1A481D0")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1A48238", Offset = "0x1A48238", VA = "0x1A48238")]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1A4829C", Offset = "0x1A4829C", VA = "0x1A4829C")]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1A4831C", Offset = "0x1A4831C", VA = "0x1A4831C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1A48524", Offset = "0x1A48524", VA = "0x1A48524")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1A485BC", Offset = "0x1A485BC", VA = "0x1A485BC")]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1A485E0", Offset = "0x1A485E0", VA = "0x1A485E0")]
		public void SetEncrypted(short encrypted)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1A483E8", Offset = "0x1A483E8", VA = "0x1A483E8")]
		private short InternalDecrypt()
		{
			return default(short);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1A40CF8", Offset = "0x1A40CF8", VA = "0x1A40CF8")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1A40D84", Offset = "0x1A40D84", VA = "0x1A40D84")]
		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1A4861C", Offset = "0x1A4861C", VA = "0x1A4861C")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1A486A4", Offset = "0x1A486A4", VA = "0x1A486A4")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1A4872C", Offset = "0x1A4872C", VA = "0x1A4872C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1A487B4", Offset = "0x1A487B4", VA = "0x1A487B4", Slot = "4")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1A4885C", Offset = "0x1A4885C", VA = "0x1A4885C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1A48888", Offset = "0x1A48888", VA = "0x1A48888")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1A488BC", Offset = "0x1A488BC", VA = "0x1A488BC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1A488E8", Offset = "0x1A488E8", VA = "0x1A488E8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1A4891C", Offset = "0x1A4891C", VA = "0x1A4891C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public sealed class ObscuredString
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string cryptoKey;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string currentCryptoKey;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string fakeValue;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1A489B0", Offset = "0x1A489B0", VA = "0x1A489B0")]
		private ObscuredString()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1A489B8", Offset = "0x1A489B8", VA = "0x1A489B8")]
		private ObscuredString(byte[] value)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1A48A48", Offset = "0x1A48A48", VA = "0x1A48A48")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1A48AB0", Offset = "0x1A48AB0", VA = "0x1A48AB0")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1A4664C", Offset = "0x1A4664C", VA = "0x1A4664C")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1A48B28", Offset = "0x1A48B28", VA = "0x1A48B28")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1A48DFC", Offset = "0x1A48DFC", VA = "0x1A48DFC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1A48F18", Offset = "0x1A48F18", VA = "0x1A48F18")]
		public string GetEncrypted()
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1A49014", Offset = "0x1A49014", VA = "0x1A49014")]
		public void SetEncrypted(string encrypted)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1A48D90", Offset = "0x1A48D90", VA = "0x1A48D90")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1A48EA4", Offset = "0x1A48EA4", VA = "0x1A48EA4")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1A48BF0", Offset = "0x1A48BF0", VA = "0x1A48BF0")]
		private string InternalDecrypt()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1A40DA8", Offset = "0x1A40DA8", VA = "0x1A40DA8")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1A40E54", Offset = "0x1A40E54", VA = "0x1A40E54")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1A49214", Offset = "0x1A49214", VA = "0x1A49214", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1A49130", Offset = "0x1A49130", VA = "0x1A49130")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1A40EE8", Offset = "0x1A40EE8", VA = "0x1A40EE8")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1A4929C", Offset = "0x1A4929C", VA = "0x1A4929C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1A4931C", Offset = "0x1A4931C", VA = "0x1A4931C")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1A49428", Offset = "0x1A49428", VA = "0x1A49428")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1A494F0", Offset = "0x1A494F0", VA = "0x1A494F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1A490A4", Offset = "0x1A490A4", VA = "0x1A490A4")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1A48F84", Offset = "0x1A48F84", VA = "0x1A48F84")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1A49218", Offset = "0x1A49218", VA = "0x1A49218")]
		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public struct ObscuredUInt : IEquatable<ObscuredUInt>, IFormattable
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint cryptoKey;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint currentCryptoKey;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private uint hiddenValue;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private uint fakeValue;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool inited;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1A49578", Offset = "0x1A49578", VA = "0x1A49578")]
		private ObscuredUInt(uint value)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1A495FC", Offset = "0x1A495FC", VA = "0x1A495FC")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1A49664", Offset = "0x1A49664", VA = "0x1A49664")]
		public static uint Encrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1A49744", Offset = "0x1A49744", VA = "0x1A49744")]
		public static uint Decrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1A496C8", Offset = "0x1A496C8", VA = "0x1A496C8")]
		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1A497A8", Offset = "0x1A497A8", VA = "0x1A497A8")]
		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1A49824", Offset = "0x1A49824", VA = "0x1A49824")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1A49A24", Offset = "0x1A49A24", VA = "0x1A49A24")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1A49ABC", Offset = "0x1A49ABC", VA = "0x1A49ABC")]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1A49AE0", Offset = "0x1A49AE0", VA = "0x1A49AE0")]
		public void SetEncrypted(uint encrypted)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1A498F0", Offset = "0x1A498F0", VA = "0x1A498F0")]
		private uint InternalDecrypt()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1A3D4D0", Offset = "0x1A3D4D0", VA = "0x1A3D4D0")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1A40F64", Offset = "0x1A40F64", VA = "0x1A40F64")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1A49B1C", Offset = "0x1A49B1C", VA = "0x1A49B1C")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1A49B94", Offset = "0x1A49B94", VA = "0x1A49B94")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1A49C2C", Offset = "0x1A49C2C", VA = "0x1A49C2C")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1A49CC4", Offset = "0x1A49CC4", VA = "0x1A49CC4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1A49D4C", Offset = "0x1A49D4C", VA = "0x1A49D4C", Slot = "4")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1A49DF4", Offset = "0x1A49DF4", VA = "0x1A49DF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1A49E20", Offset = "0x1A49E20", VA = "0x1A49E20")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1A49E54", Offset = "0x1A49E54", VA = "0x1A49E54", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1A49E80", Offset = "0x1A49E80", VA = "0x1A49E80")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1A49EB4", Offset = "0x1A49EB4", VA = "0x1A49EB4", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public struct ObscuredULong : IEquatable<ObscuredULong>, IFormattable
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ulong cryptoKey;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong currentCryptoKey;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ulong hiddenValue;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong fakeValue;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inited;

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1A49F4C", Offset = "0x1A49F4C", VA = "0x1A49F4C")]
		private ObscuredULong(ulong value)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1A49FD0", Offset = "0x1A49FD0", VA = "0x1A49FD0")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1A4A038", Offset = "0x1A4A038", VA = "0x1A4A038")]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1A4A118", Offset = "0x1A4A118", VA = "0x1A4A118")]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1A4A09C", Offset = "0x1A4A09C", VA = "0x1A4A09C")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1A4A17C", Offset = "0x1A4A17C", VA = "0x1A4A17C")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1A4A1F8", Offset = "0x1A4A1F8", VA = "0x1A4A1F8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1A4A3F8", Offset = "0x1A4A3F8", VA = "0x1A4A3F8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1A4A490", Offset = "0x1A4A490", VA = "0x1A4A490")]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1A4A4B4", Offset = "0x1A4A4B4", VA = "0x1A4A4B4")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1A4A2C4", Offset = "0x1A4A2C4", VA = "0x1A4A2C4")]
		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1A4A4F0", Offset = "0x1A4A4F0", VA = "0x1A4A4F0")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1A4A590", Offset = "0x1A4A590", VA = "0x1A4A590")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1A4A594", Offset = "0x1A4A594", VA = "0x1A4A594")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1A4A634", Offset = "0x1A4A634", VA = "0x1A4A634")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1A4A6D4", Offset = "0x1A4A6D4", VA = "0x1A4A6D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1A4A768", Offset = "0x1A4A768", VA = "0x1A4A768", Slot = "4")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1A4A810", Offset = "0x1A4A810", VA = "0x1A4A810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1A4A83C", Offset = "0x1A4A83C", VA = "0x1A4A83C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1A4A868", Offset = "0x1A4A868", VA = "0x1A4A868")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1A4A89C", Offset = "0x1A4A89C", VA = "0x1A4A89C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1A4A8D0", Offset = "0x1A4A8D0", VA = "0x1A4A8D0", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ushort cryptoKey;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort currentCryptoKey;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort hiddenValue;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private ushort fakeValue;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private bool inited;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x2118238", Offset = "0x2118238", VA = "0x2118238")]
		private ObscuredUShort(ushort value)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x21182C0", Offset = "0x21182C0", VA = "0x21182C0")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2118328", Offset = "0x2118328", VA = "0x2118328")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x211838C", Offset = "0x211838C", VA = "0x211838C")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x211840C", Offset = "0x211840C", VA = "0x211840C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x2118618", Offset = "0x2118618", VA = "0x2118618")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x21186B0", Offset = "0x21186B0", VA = "0x21186B0")]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x21186D4", Offset = "0x21186D4", VA = "0x21186D4")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x21184D8", Offset = "0x21184D8", VA = "0x21184D8")]
		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x2118714", Offset = "0x2118714", VA = "0x2118714")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x21187A4", Offset = "0x21187A4", VA = "0x21187A4")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x21187C8", Offset = "0x21187C8", VA = "0x21187C8")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2118864", Offset = "0x2118864", VA = "0x2118864")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2118900", Offset = "0x2118900", VA = "0x2118900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2118988", Offset = "0x2118988", VA = "0x2118988", Slot = "4")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2118A30", Offset = "0x2118A30", VA = "0x2118A30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2118A5C", Offset = "0x2118A5C", VA = "0x2118A5C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2118A90", Offset = "0x2118A90", VA = "0x2118A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2118ABC", Offset = "0x2118ABC", VA = "0x2118ABC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x2118AF0", Offset = "0x2118AF0", VA = "0x2118AF0", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x83667C", Offset = "0x83667C")]
	public struct ObscuredVector2
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public struct RawEncryptedVector2
		{
			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;
		}

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector2 initialFakeValue;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector2 hiddenValue;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Vector2 fakeValue;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x1700004F")]
		public float x
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x2118C18", Offset = "0x2118C18", VA = "0x2118C18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x2118DEC", Offset = "0x2118DEC", VA = "0x2118DEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float y
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x2118ED8", Offset = "0x2118ED8", VA = "0x2118ED8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x2119010", Offset = "0x2119010", VA = "0x2119010")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public float Item
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x2119050", Offset = "0x2119050", VA = "0x2119050")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x21190B8", Offset = "0x21190B8", VA = "0x21190B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2118B84", Offset = "0x2118B84", VA = "0x2118B84")]
		private ObscuredVector2(RawEncryptedVector2 value)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x2119120", Offset = "0x2119120", VA = "0x2119120")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x2119188", Offset = "0x2119188", VA = "0x2119188")]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x21191FC", Offset = "0x21191FC", VA = "0x21191FC")]
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x21192D4", Offset = "0x21192D4", VA = "0x21192D4")]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x2119338", Offset = "0x2119338", VA = "0x2119338")]
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2119414", Offset = "0x2119414", VA = "0x2119414")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x21196BC", Offset = "0x21196BC", VA = "0x21196BC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x211975C", Offset = "0x211975C", VA = "0x211975C")]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x2119780", Offset = "0x2119780", VA = "0x2119780")]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x21194EC", Offset = "0x21194EC", VA = "0x21194EC")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x21197C0", Offset = "0x21197C0", VA = "0x21197C0")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2118D48", Offset = "0x2118D48", VA = "0x2118D48")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2118E2C", Offset = "0x2118E2C", VA = "0x2118E2C")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x21198B8", Offset = "0x21198B8", VA = "0x21198B8")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x211996C", Offset = "0x211996C", VA = "0x211996C")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2119970", Offset = "0x2119970", VA = "0x2119970")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2119988", Offset = "0x2119988", VA = "0x2119988", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x21199B4", Offset = "0x21199B4", VA = "0x21199B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x21199E0", Offset = "0x21199E0", VA = "0x21199E0")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8366B4", Offset = "0x8366B4")]
	public struct ObscuredVector3
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public struct RawEncryptedVector3
		{
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector3 initialFakeValue;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector3 hiddenValue;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 fakeValue;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x17000052")]
		public float x
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x2119D00", Offset = "0x2119D00", VA = "0x2119D00")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x2119ED4", Offset = "0x2119ED4", VA = "0x2119ED4")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float y
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x2119FC0", Offset = "0x2119FC0", VA = "0x2119FC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x211A0F8", Offset = "0x211A0F8", VA = "0x211A0F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float z
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x211A138", Offset = "0x211A138", VA = "0x211A138")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x211A270", Offset = "0x211A270", VA = "0x211A270")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public float Item
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x211A2B0", Offset = "0x211A2B0", VA = "0x211A2B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x211A324", Offset = "0x211A324", VA = "0x211A324")]
			set
			{
			}
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x2119A7C", Offset = "0x2119A7C", VA = "0x2119A7C")]
		private ObscuredVector3(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2119B20", Offset = "0x2119B20", VA = "0x2119B20")]
		public Vector3 getValue()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x211A398", Offset = "0x211A398", VA = "0x211A398")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x211A400", Offset = "0x211A400", VA = "0x211A400")]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x211A48C", Offset = "0x211A48C", VA = "0x211A48C")]
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x211A590", Offset = "0x211A590", VA = "0x211A590")]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x211A604", Offset = "0x211A604", VA = "0x211A604")]
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x211A6FC", Offset = "0x211A6FC", VA = "0x211A6FC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x211A7E8", Offset = "0x211A7E8", VA = "0x211A7E8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x211A89C", Offset = "0x211A89C", VA = "0x211A89C")]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x211A8C4", Offset = "0x211A8C4", VA = "0x211A8C4")]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2119B24", Offset = "0x2119B24", VA = "0x2119B24")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x211A90C", Offset = "0x211A90C", VA = "0x211A90C")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2119E30", Offset = "0x2119E30", VA = "0x2119E30")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2119F14", Offset = "0x2119F14", VA = "0x2119F14")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x211AA38", Offset = "0x211AA38", VA = "0x211AA38")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x211AB0C", Offset = "0x211AB0C", VA = "0x211AB0C")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x211AB10", Offset = "0x211AB10", VA = "0x211AB10")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x211ABD8", Offset = "0x211ABD8", VA = "0x211ABD8")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x211AC94", Offset = "0x211AC94", VA = "0x211AC94")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x211AD50", Offset = "0x211AD50", VA = "0x211AD50")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x211AE18", Offset = "0x211AE18", VA = "0x211AE18")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x211AED4", Offset = "0x211AED4", VA = "0x211AED4")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x211AF90", Offset = "0x211AF90", VA = "0x211AF90")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x211B040", Offset = "0x211B040", VA = "0x211B040")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x211B0F4", Offset = "0x211B0F4", VA = "0x211B0F4")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x211B1A8", Offset = "0x211B1A8", VA = "0x211B1A8")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x211B25C", Offset = "0x211B25C", VA = "0x211B25C")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x211B2BC", Offset = "0x211B2BC", VA = "0x211B2BC")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x211B308", Offset = "0x211B308", VA = "0x211B308")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x211B348", Offset = "0x211B348", VA = "0x211B348")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x211B3A8", Offset = "0x211B3A8", VA = "0x211B3A8")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x211B3F4", Offset = "0x211B3F4", VA = "0x211B3F4")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x211B434", Offset = "0x211B434", VA = "0x211B434", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x211B478", Offset = "0x211B478", VA = "0x211B478", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x211B4A8", Offset = "0x211B4A8", VA = "0x211B4A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x211B4D8", Offset = "0x211B4D8", VA = "0x211B4D8")]
		public string ToString(string format)
		{
			return null;
		}
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8366EC", Offset = "0x8366EC")]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		[Token(Token = "0x400034E")]
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";

		[Token(Token = "0x400034F")]
		protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x4000350")]
		protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static GameObject detectorsContainer;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837D9C", Offset = "0x837D9C")]
		public bool autoStart;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837DD4", Offset = "0x837DD4")]
		public bool keepAlive;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837E0C", Offset = "0x837E0C")]
		public bool autoDispose;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected UnityEvent detectionEvent;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityAction detectionAction;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool detectionEventHasListener;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isRunning;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool started;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1607E78", Offset = "0x1607E78", VA = "0x1607E78")]
		private void Start()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1607F94", Offset = "0x1607F94", VA = "0x1607F94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1607FBC", Offset = "0x1607FBC", VA = "0x1607FBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1607FD4", Offset = "0x1607FD4", VA = "0x1607FD4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1607FE0", Offset = "0x1607FE0", VA = "0x1607FE0", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1608124", Offset = "0x1608124", VA = "0x1608124", Slot = "5")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x16082E4", Offset = "0x16082E4", VA = "0x16082E4", Slot = "6")]
		protected virtual void DisposeInternal()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1608348", Offset = "0x1608348", VA = "0x1608348", Slot = "7")]
		internal virtual void OnCheatingDetected()
		{
		}

		[Token(Token = "0x6000672")]
		protected abstract void StartDetectionAutomatically();

		[Token(Token = "0x6000673")]
		protected abstract void StopDetectionInternal();

		[Token(Token = "0x6000674")]
		protected abstract void PauseDetector();

		[Token(Token = "0x6000675")]
		protected abstract void ResumeDetector();

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x16083AC", Offset = "0x16083AC", VA = "0x16083AC")]
		protected ActDetectorBase()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x836724", Offset = "0x836724")]
	public class InjectionDetector : ActDetectorBase
	{
		[Token(Token = "0x20000CA")]
		private class AllowedAssembly
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string name;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly int[] hashes;

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x2051260", Offset = "0x2051260", VA = "0x2051260")]
			public AllowedAssembly(string name, int[] hashes)
			{
			}
		}

		[Token(Token = "0x400035A")]
		internal const string COMPONENT_NAME = "Injection Detector";

		[Token(Token = "0x400035B")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		private bool signaturesAreNotGenuine;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AllowedAssembly[] allowedAssemblies;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string[] hexTable;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E64", Offset = "0x837E64")]
		private static InjectionDetector <Instance>k__BackingField;

		[Token(Token = "0x17000056")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x16FA624", Offset = "0x16FA624", VA = "0x16FA624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838DF0", Offset = "0x838DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x16FA670", Offset = "0x16FA670", VA = "0x16FA670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E00", Offset = "0x838E00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		private static InjectionDetector GetOrCreateInstance
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x16FA274", Offset = "0x16FA274", VA = "0x16FA274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x16F9EC0", Offset = "0x16F9EC0", VA = "0x16F9EC0")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x16FA248", Offset = "0x16FA248", VA = "0x16FA248")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x16FA444", Offset = "0x16FA444", VA = "0x16FA444")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x16FA534", Offset = "0x16FA534", VA = "0x16FA534")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x16FA6C0", Offset = "0x16FA6C0", VA = "0x16FA6C0")]
		private InjectionDetector()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x16FA6C8", Offset = "0x16FA6C8", VA = "0x16FA6C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x16FA83C", Offset = "0x16FA83C", VA = "0x16FA83C", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x16FA930", Offset = "0x16FA930", VA = "0x16FA930")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x16F9FF4", Offset = "0x16F9FF4", VA = "0x16F9FF4")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x16FB020", Offset = "0x16FB020", VA = "0x16FB020", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x16FB028", Offset = "0x16FB028", VA = "0x16FB028", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x16FB0CC", Offset = "0x16FB0CC", VA = "0x16FB0CC", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x16FB194", Offset = "0x16FB194", VA = "0x16FB194", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x16FB248", Offset = "0x16FB248", VA = "0x16FB248", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x16FB32C", Offset = "0x16FB32C", VA = "0x16FB32C")]
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x16FAF84", Offset = "0x16FAF84", VA = "0x16FAF84")]
		private bool FindInjectionInCurrentAssemblies()
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x16FB374", Offset = "0x16FB374", VA = "0x16FB374")]
		private bool AssemblyAllowed(Assembly ass)
		{
			return default(bool);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x16FAA24", Offset = "0x16FAA24", VA = "0x16FAA24")]
		private void LoadAndParseAllowedAssemblies()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x16FB47C", Offset = "0x16FB47C", VA = "0x16FB47C")]
		private int GetAssemblyHash(Assembly ass)
		{
			return default(int);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x16FB558", Offset = "0x16FB558", VA = "0x16FB558")]
		private string PublicKeyTokenToString(byte[] bytes)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83675C", Offset = "0x83675C")]
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		[Token(Token = "0x4000361")]
		internal const string COMPONENT_NAME = "Obscured Cheating Detector";

		[Token(Token = "0x4000362")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837E74", Offset = "0x837E74")]
		public float floatEpsilon;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837EAC", Offset = "0x837EAC")]
		public float vector2Epsilon;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837EE4", Offset = "0x837EE4")]
		public float vector3Epsilon;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837F1C", Offset = "0x837F1C")]
		public float quaternionEpsilon;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F54", Offset = "0x837F54")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;

		[Token(Token = "0x17000058")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1A39F60", Offset = "0x1A39F60", VA = "0x1A39F60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E10", Offset = "0x838E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1A39FAC", Offset = "0x1A39FAC", VA = "0x1A39FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E20", Offset = "0x838E20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1A39BB0", Offset = "0x1A39BB0", VA = "0x1A39BB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		internal static bool IsRunning
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1A3838C", Offset = "0x1A3838C", VA = "0x1A3838C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1A398A4", Offset = "0x1A398A4", VA = "0x1A398A4")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1A39B84", Offset = "0x1A39B84", VA = "0x1A39B84")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1A39D80", Offset = "0x1A39D80", VA = "0x1A39D80")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1A39E70", Offset = "0x1A39E70", VA = "0x1A39E70")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1A39FFC", Offset = "0x1A39FFC", VA = "0x1A39FFC")]
		private ObscuredCheatingDetector()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1A3A010", Offset = "0x1A3A010", VA = "0x1A3A010")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1A3A184", Offset = "0x1A3A184", VA = "0x1A3A184", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1A3A278", Offset = "0x1A3A278", VA = "0x1A3A278")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1A399D8", Offset = "0x1A399D8", VA = "0x1A399D8")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1A3A36C", Offset = "0x1A3A36C", VA = "0x1A3A36C", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1A3A374", Offset = "0x1A3A374", VA = "0x1A3A374", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1A3A37C", Offset = "0x1A3A37C", VA = "0x1A3A37C", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1A3A398", Offset = "0x1A3A398", VA = "0x1A3A398", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1A3A3AC", Offset = "0x1A3A3AC", VA = "0x1A3A3AC", Slot = "6")]
		protected override void DisposeInternal()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x836794", Offset = "0x836794")]
	public class SpeedHackDetector : ActDetectorBase
	{
		[Token(Token = "0x4000369")]
		internal const string COMPONENT_NAME = "Speed Hack Detector";

		[Token(Token = "0x400036A")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";

		[Token(Token = "0x400036B")]
		private const long TICKS_PER_SECOND = 10000000L;

		[Token(Token = "0x400036C")]
		private const int THRESHOLD = 5000000;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837F64", Offset = "0x837F64")]
		public float interval;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837F9C", Offset = "0x837F9C")]
		public byte maxFalsePositives;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837FD4", Offset = "0x837FD4")]
		public int coolDown;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte currentFalsePositives;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int currentCooldownShots;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long ticksOnStart;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long vulnerableTicksOnStart;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long prevTicks;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private long prevIntervalTicks;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83800C", Offset = "0x83800C")]
		private static SpeedHackDetector <Instance>k__BackingField;

		[Token(Token = "0x1700005B")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x2121D30", Offset = "0x2121D30", VA = "0x2121D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E30", Offset = "0x838E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x2121D7C", Offset = "0x2121D7C", VA = "0x2121D7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E40", Offset = "0x838E40")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x21218A4", Offset = "0x21218A4", VA = "0x21218A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x2121540", Offset = "0x2121540", VA = "0x2121540")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x2121874", Offset = "0x2121874", VA = "0x2121874")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x2121A74", Offset = "0x2121A74", VA = "0x2121A74")]
		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2121AB4", Offset = "0x2121AB4", VA = "0x2121AB4")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x2121AFC", Offset = "0x2121AFC", VA = "0x2121AFC")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2121B50", Offset = "0x2121B50", VA = "0x2121B50")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2121C40", Offset = "0x2121C40", VA = "0x2121C40")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2121DCC", Offset = "0x2121DCC", VA = "0x2121DCC")]
		private SpeedHackDetector()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2121DEC", Offset = "0x2121DEC", VA = "0x2121DEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x2121F60", Offset = "0x2121F60", VA = "0x2121F60", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2122054", Offset = "0x2122054", VA = "0x2122054")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x2122148", Offset = "0x2122148", VA = "0x2122148")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x21221F4", Offset = "0x21221F4", VA = "0x21221F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x2121680", Offset = "0x2121680", VA = "0x2121680")]
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x2122370", Offset = "0x2122370", VA = "0x2122370", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2122384", Offset = "0x2122384", VA = "0x2122384", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x212238C", Offset = "0x212238C", VA = "0x212238C", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x21223A8", Offset = "0x21223A8", VA = "0x21223A8", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x21223BC", Offset = "0x21223BC", VA = "0x21223BC", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2122154", Offset = "0x2122154", VA = "0x2122154")]
		private void ResetStartTicks()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8367CC", Offset = "0x8367CC")]
	public class WallHackDetector : ActDetectorBase
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836ABC", Offset = "0x836ABC")]
		private sealed class <InitDetector>d__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F3")]
				[Address(RVA = "0x2055D70", Offset = "0x2055D70", VA = "0x2055D70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x2055DB8", Offset = "0x2055DB8", VA = "0x2055DB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x2055C80", Offset = "0x2055C80", VA = "0x2055C80")]
			[DebuggerHidden]
			public <InitDetector>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x2055CAC", Offset = "0x2055CAC", VA = "0x2055CAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x2055CB0", Offset = "0x2055CB0", VA = "0x2055CB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x2055D78", Offset = "0x2055D78", VA = "0x2055D78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836ACC", Offset = "0x836ACC")]
		private sealed class <CaptureFrame>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RenderTexture <previousActive>5__2;

			[Token(Token = "0x17000099")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x2055C30", Offset = "0x2055C30", VA = "0x2055C30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x2055C78", Offset = "0x2055C78", VA = "0x2055C78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x2055828", Offset = "0x2055828", VA = "0x2055828")]
			[DebuggerHidden]
			public <CaptureFrame>d__82(int <>1__state)
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x2055854", Offset = "0x2055854", VA = "0x2055854", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x2055858", Offset = "0x2055858", VA = "0x2055858", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x2055C38", Offset = "0x2055C38", VA = "0x2055C38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000378")]
		internal const string COMPONENT_NAME = "WallHack Detector";

		[Token(Token = "0x4000379")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";

		[Token(Token = "0x400037A")]
		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";

		[Token(Token = "0x400037B")]
		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";

		[Token(Token = "0x400037C")]
		private const int SHADER_TEXTURE_SIZE = 4;

		[Token(Token = "0x400037D")]
		private const int RENDER_TEXTURE_SIZE = 4;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly Vector3 rigidPlayerVelocity;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForEndOfFrame waitForEndOfFrame;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83801C", Offset = "0x83801C")]
		private bool checkRigidbody;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x838068", Offset = "0x838068")]
		private bool checkController;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8380B4", Offset = "0x8380B4")]
		private bool checkWireframe;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x838100", Offset = "0x838100")]
		private bool checkRaycast;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83814C", Offset = "0x83814C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83814C", Offset = "0x83814C")]
		public int wireframeDelay;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8381A4", Offset = "0x8381A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8381A4", Offset = "0x8381A4")]
		public int raycastDelay;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8381FC", Offset = "0x8381FC")]
		public Vector3 spawnPosition;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x838234", Offset = "0x838234")]
		public byte maxFalsePositives;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject serviceContainer;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject solidWall;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject thinWall;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Camera wfCamera;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MeshRenderer foregroundRenderer;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MeshRenderer backgroundRenderer;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Color wfColor1;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Color wfColor2;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Shader wfShader;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material wfMaterial;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Texture2D shaderTexture;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Texture2D targetTexture;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture renderTexture;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int whLayer;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int raycastMask;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Rigidbody rigidPlayer;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CharacterController charControllerPlayer;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float charControllerVelocity;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private byte rigidbodyDetections;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private byte controllerDetections;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		private byte wireframeDetections;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		private byte raycastDetections;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool wireframeDetected;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83826C", Offset = "0x83826C")]
		private static WallHackDetector <Instance>k__BackingField;

		[Token(Token = "0x1700005D")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x2125F78", Offset = "0x2125F78", VA = "0x2125F78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x2125F80", Offset = "0x2125F80", VA = "0x2125F80")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool CheckController
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x2127374", Offset = "0x2127374", VA = "0x2127374")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x212737C", Offset = "0x212737C", VA = "0x212737C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public bool CheckWireframe
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x21275F0", Offset = "0x21275F0", VA = "0x21275F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x21275F8", Offset = "0x21275F8", VA = "0x21275F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool CheckRaycast
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x2127784", Offset = "0x2127784", VA = "0x2127784")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x212778C", Offset = "0x212778C", VA = "0x212778C")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x21280E0", Offset = "0x21280E0", VA = "0x21280E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E50", Offset = "0x838E50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x212812C", Offset = "0x212812C", VA = "0x212812C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838E60", Offset = "0x838E60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x2127C7C", Offset = "0x2127C7C", VA = "0x2127C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2127904", Offset = "0x2127904", VA = "0x2127904")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2127C48", Offset = "0x2127C48", VA = "0x2127C48")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2127E4C", Offset = "0x2127E4C", VA = "0x2127E4C")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2127EA4", Offset = "0x2127EA4", VA = "0x2127EA4")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2127F00", Offset = "0x2127F00", VA = "0x2127F00")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2127FF0", Offset = "0x2127FF0", VA = "0x2127FF0")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x212817C", Offset = "0x212817C", VA = "0x212817C")]
		private WallHackDetector()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2128230", Offset = "0x2128230", VA = "0x2128230")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x21283A4", Offset = "0x21283A4", VA = "0x21283A4", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x21285A4", Offset = "0x21285A4", VA = "0x21285A4")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2128698", Offset = "0x2128698", VA = "0x2128698")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x21287D4", Offset = "0x21287D4", VA = "0x21287D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x2127A44", Offset = "0x2127A44", VA = "0x2127A44")]
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x2128960", Offset = "0x2128960", VA = "0x2128960", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x2128974", Offset = "0x2128974", VA = "0x2128974", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x21289B8", Offset = "0x21289B8", VA = "0x21289B8", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2128A34", Offset = "0x2128A34", VA = "0x2128A34", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2128A6C", Offset = "0x2128A6C", VA = "0x2128A6C", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2126030", Offset = "0x2126030", VA = "0x2126030")]
		private void UpdateServiceContainer()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x21288F4", Offset = "0x21288F4", VA = "0x21288F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838E70", Offset = "0x838E70")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2127150", Offset = "0x2127150", VA = "0x2127150")]
		private void StartRigidModule()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x212742C", Offset = "0x212742C", VA = "0x212742C")]
		private void StartControllerModule()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x21276A8", Offset = "0x21276A8", VA = "0x21276A8")]
		private void StartWireframeModule()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x21290C4", Offset = "0x21290C4", VA = "0x21290C4")]
		private void ShootWireframeModule()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2129134", Offset = "0x2129134", VA = "0x2129134")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838ED0", Offset = "0x838ED0")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x212783C", Offset = "0x212783C", VA = "0x212783C")]
		private void StartRaycastModule()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x21291A0", Offset = "0x21291A0", VA = "0x21291A0")]
		private void ShootRaycastModule()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x21272C4", Offset = "0x21272C4", VA = "0x21272C4")]
		private void StopRigidModule()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x212755C", Offset = "0x212755C", VA = "0x212755C")]
		private void StopControllerModule()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x2127734", Offset = "0x2127734", VA = "0x2127734")]
		private void StopWireframeModule()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x21278B4", Offset = "0x21278B4", VA = "0x21278B4")]
		private void StopRaycastModule()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2128D7C", Offset = "0x2128D7C", VA = "0x2128D7C")]
		private void InitRigidModule()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x2128F84", Offset = "0x2128F84", VA = "0x2128F84")]
		private void InitControllerModule()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x2128CC0", Offset = "0x2128CC0", VA = "0x2128CC0")]
		private void UninitRigidModule()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2128EC8", Offset = "0x2128EC8", VA = "0x2128EC8")]
		private void UninitControllerModule()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2128778", Offset = "0x2128778", VA = "0x2128778")]
		private bool Detect()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2128B50", Offset = "0x2128B50", VA = "0x2128B50")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2128BCC", Offset = "0x2128BCC", VA = "0x2128BCC")]
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
		[Token(Token = "0x40003A1")]
		internal const string LOG_PREFIX = "[ACTk] ";

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x16F0B10", Offset = "0x16F0B10", VA = "0x16F0B10")]
		public Constants()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Examples
{
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x836804", Offset = "0x836804")]
	public class ActRotatorExample : MonoBehaviour
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x83827C", Offset = "0x83827C")]
		public float speed;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x16083C4", Offset = "0x16083C4", VA = "0x16083C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x160841C", Offset = "0x160841C", VA = "0x160841C")]
		public ActRotatorExample()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83683C", Offset = "0x83683C")]
	public class ActTesterGui : MonoBehaviour
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836ADC", Offset = "0x836ADC")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string types;

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x2129B74", Offset = "0x2129B74", VA = "0x2129B74")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x2129B7C", Offset = "0x2129B7C", VA = "0x2129B7C")]
			internal void <GetAllSimpleObscuredTypes>b__1(Type t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836AEC", Offset = "0x836AEC")]
		private sealed class <>c
		{
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> <>9__61_0;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x2129AB0", Offset = "0x2129AB0", VA = "0x2129AB0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x2129AB8", Offset = "0x2129AB8", VA = "0x2129AB8")]
			internal bool <GetAllSimpleObscuredTypes>b__61_0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003A3")]
		private const string RED_COLOR = "#FF4040";

		[Token(Token = "0x40003A4")]
		private const string GREEN_COLOR = "#02C85F";

		[Token(Token = "0x40003A5")]
		private const string PREFS_STRING = "name";

		[Token(Token = "0x40003A6")]
		private const string PREFS_INT = "money";

		[Token(Token = "0x40003A7")]
		private const string PREFS_FLOAT = "lifeBar";

		[Token(Token = "0x40003A8")]
		private const string PREFS_BOOL = "gameComplete";

		[Token(Token = "0x40003A9")]
		private const string PREFS_UINT = "demoUint";

		[Token(Token = "0x40003AA")]
		private const string PREFS_LONG = "demoLong";

		[Token(Token = "0x40003AB")]
		private const string PREFS_DOUBLE = "demoDouble";

		[Token(Token = "0x40003AC")]
		private const string PREFS_VECTOR2 = "demoVector2";

		[Token(Token = "0x40003AD")]
		private const string PREFS_VECTOR3 = "demoVector3";

		[Token(Token = "0x40003AE")]
		private const string PREFS_QUATERNION = "demoQuaternion";

		[Token(Token = "0x40003AF")]
		private const string PREFS_RECT = "demoRect";

		[Token(Token = "0x40003B0")]
		private const string PREFS_COLOR = "demoColor";

		[Token(Token = "0x40003B1")]
		private const string PREFS_BYTE_ARRAY = "demoByteArray";

		[Token(Token = "0x40003B2")]
		private const string API_URL_LOCK_TO_DEVICE = "http://j.mp/1gxg1tf";

		[Token(Token = "0x40003B3")]
		private const string API_URL_PRESERVE_PREFS = "http://j.mp/1iBK5pz";

		[Token(Token = "0x40003B4")]
		private const string API_URL_EMERGENCY_MODE = "http://j.mp/1FRAL5L";

		[Token(Token = "0x40003B5")]
		private const string API_URL_READ_FOREIGN = "http://j.mp/1LCdpDa";

		[Token(Token = "0x40003B6")]
		private const string API_URL_UNOBSCURED_MODE = "http://j.mp/1KVrpxi";

		[Token(Token = "0x40003B7")]
		private const string API_URL_PLAYER_PREFS = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x838298", Offset = "0x838298")]
		public string regularString;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int regularInt;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float regularFloat;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 regularVector3;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8382D0", Offset = "0x8382D0")]
		public ObscuredString obscuredString;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ObscuredInt obscuredInt;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ObscuredFloat obscuredFloat;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ObscuredVector3 obscuredVector3;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ObscuredBool obscuredBool;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public ObscuredLong obscuredLong;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ObscuredDouble obscuredDouble;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public ObscuredVector2 obscuredVector2;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x838308", Offset = "0x838308")]
		public string prefsEncryptionKey;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly string[] tabs;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int currentTab;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string allSimpleObscuredTypes;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string regularPrefs;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string obscuredPrefs;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int savesLock;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private bool savesAlterationDetected;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		private bool foreignSavesDetected;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		private bool injectionDetected;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		private bool speedHackDetected;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool obscuredTypeCheatDetected;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool wallHackCheatDetected;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x160842C", Offset = "0x160842C", VA = "0x160842C")]
		public void OnSpeedHackDetected()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x16084AC", Offset = "0x16084AC", VA = "0x16084AC")]
		public void OnInjectionDetected()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x160852C", Offset = "0x160852C", VA = "0x160852C")]
		public void OnObscuredTypeCheatingDetected()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x16085AC", Offset = "0x16085AC", VA = "0x16085AC")]
		public void OnWallHackDetected()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x160862C", Offset = "0x160862C", VA = "0x160862C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x160872C", Offset = "0x160872C", VA = "0x160872C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x160965C", Offset = "0x160965C", VA = "0x160965C")]
		private void RandomizeObscuredVars()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x16087AC", Offset = "0x16087AC", VA = "0x16087AC")]
		private void ObscuredStringExample()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1608990", Offset = "0x1608990", VA = "0x1608990")]
		private void ObscuredIntExample()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1608E5C", Offset = "0x1608E5C", VA = "0x1608E5C")]
		private void ObscuredFloatExample()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x160926C", Offset = "0x160926C", VA = "0x160926C")]
		private void ObscuredVector3Example()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x16096F4", Offset = "0x16096F4", VA = "0x16096F4")]
		private void SavesAlterationDetected()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1609700", Offset = "0x1609700", VA = "0x1609700")]
		private void ForeignSavesDetected()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x160970C", Offset = "0x160970C", VA = "0x160970C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x160FC30", Offset = "0x160FC30", VA = "0x160FC30")]
		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x160FED4", Offset = "0x160FED4", VA = "0x160FED4")]
		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x160FF18", Offset = "0x160FF18", VA = "0x160FF18")]
		private void LoadRegularPrefs()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1610098", Offset = "0x1610098", VA = "0x1610098")]
		private void SaveRegularPrefs()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x161014C", Offset = "0x161014C", VA = "0x161014C")]
		private void DeleteRegularPrefs()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x16101DC", Offset = "0x16101DC", VA = "0x16101DC")]
		private void LoadObscuredPrefs()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1610A94", Offset = "0x1610A94", VA = "0x1610A94")]
		private void SaveObscuredPrefs()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1610D9C", Offset = "0x1610D9C", VA = "0x1610D9C")]
		private void DeleteObscuredPrefs()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1610F98", Offset = "0x1610F98", VA = "0x1610F98")]
		private void PlaceUrlButton(string url)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1611094", Offset = "0x1611094", VA = "0x1611094")]
		private void PlaceUrlButton(string url, int width)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1610FA0", Offset = "0x1610FA0", VA = "0x1610FA0")]
		private void PlaceUrlButton(string url, string buttonName, int width)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x16110F0", Offset = "0x16110F0", VA = "0x16110F0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1611104", Offset = "0x1611104", VA = "0x1611104")]
		public ActTesterGui()
		{
		}
	}
	[Token(Token = "0x2000090")]
	internal class HorizontalLayout : IDisposable
	{
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x16F9E8C", Offset = "0x16F9E8C", VA = "0x16F9E8C")]
		public HorizontalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x16F9EB8", Offset = "0x16F9EB8", VA = "0x16F9EB8", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000091")]
	internal class VerticalLayout : IDisposable
	{
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x21258CC", Offset = "0x21258CC", VA = "0x21258CC")]
		public VerticalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x21258F8", Offset = "0x21258F8", VA = "0x21258F8")]
		public VerticalLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x21259E0", Offset = "0x21259E0", VA = "0x21259E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x836874", Offset = "0x836874")]
	public class ObscuredPerformanceTests : MonoBehaviour
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool boolTest;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int boolIterations;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool byteTest;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int byteIterations;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool shortTest;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int shortIterations;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ushortTest;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int ushortIterations;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intTest;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int intIterations;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool uintTest;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int uintIterations;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool longTest;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int longIterations;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool floatTest;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int floatIterations;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool doubleTest;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int doubleIterations;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool stringTest;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int stringIterations;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool vector3Test;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int vector3Iterations;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool prefsTest;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int prefsIterations;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1A3E334", Offset = "0x1A3E334", VA = "0x1A3E334")]
		private void Start()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1A3E388", Offset = "0x1A3E388", VA = "0x1A3E388")]
		private void StartTests()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1A3E4F0", Offset = "0x1A3E4F0", VA = "0x1A3E4F0")]
		private void TestBool()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1A3E804", Offset = "0x1A3E804", VA = "0x1A3E804")]
		private void TestByte()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1A3EB04", Offset = "0x1A3EB04", VA = "0x1A3EB04")]
		private void TestShort()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1A3EE04", Offset = "0x1A3EE04", VA = "0x1A3EE04")]
		private void TestUShort()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1A3FD80", Offset = "0x1A3FD80", VA = "0x1A3FD80")]
		private void TestDouble()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1A3FA2C", Offset = "0x1A3FA2C", VA = "0x1A3FA2C")]
		private void TestFloat()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1A3F100", Offset = "0x1A3F100", VA = "0x1A3F100")]
		private void TestInt()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1A3F710", Offset = "0x1A3F710", VA = "0x1A3F710")]
		private void TestLong()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1A400A8", Offset = "0x1A400A8", VA = "0x1A400A8")]
		private void TestString()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1A3F408", Offset = "0x1A3F408", VA = "0x1A3F408")]
		private void TestUInt()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1A40434", Offset = "0x1A40434", VA = "0x1A40434")]
		private void TestVector3()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1A40898", Offset = "0x1A40898", VA = "0x1A40898")]
		private void TestPrefs()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1A41658", Offset = "0x1A41658", VA = "0x1A41658")]
		public ObscuredPerformanceTests()
		{
		}
	}
}
