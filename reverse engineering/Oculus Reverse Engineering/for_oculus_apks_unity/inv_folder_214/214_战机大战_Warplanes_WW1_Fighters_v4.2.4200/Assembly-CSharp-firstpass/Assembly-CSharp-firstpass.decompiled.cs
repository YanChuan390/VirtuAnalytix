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
		[Address(RVA = "0x152D6C4", Offset = "0x152D6C4", VA = "0x152D6C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x152D7A8", Offset = "0x152D7A8", VA = "0x152D7A8")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x152D8C0", Offset = "0x152D8C0", VA = "0x152D8C0")]
	public static void ResetLastSendTime()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x152D994", Offset = "0x152D994", VA = "0x152D994")]
	public void SetLastStoreTime()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x152DA04", Offset = "0x152DA04", VA = "0x152DA04")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x152E498", Offset = "0x152E498", VA = "0x152E498")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x152E600", Offset = "0x152E600", VA = "0x152E600")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x152EA40", Offset = "0x152EA40", VA = "0x152EA40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x152EA44", Offset = "0x152EA44", VA = "0x152EA44")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x152F084", Offset = "0x152F084", VA = "0x152F084")]
	public static bool WillOpenCloudStorageScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x152DD14", Offset = "0x152DD14", VA = "0x152DD14")]
	private void StartFirstScreen()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x152F454", Offset = "0x152F454", VA = "0x152F454", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x152F458", Offset = "0x152F458", VA = "0x152F458", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x152E888", Offset = "0x152E888", VA = "0x152E888", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x152EC34", Offset = "0x152EC34", VA = "0x152EC34", Slot = "7")]
	public void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x152F700", Offset = "0x152F700", VA = "0x152F700")]
	public void OnReceivedCloudSave(CloudSave_Screen onScreen, CloudSave_Saves cloudSaves, bool compareAndImport)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x152FA20", Offset = "0x152FA20", VA = "0x152FA20")]
	public void OnSendSaveToCloud(CloudSave_Screen onScreen, CloudSave_Saves localSaves)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x152ED6C", Offset = "0x152ED6C", VA = "0x152ED6C")]
	public void TrySendChangedLocalSave()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x153055C", Offset = "0x153055C", VA = "0x153055C")]
	public void TrySendDeletedSave()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x152E810", Offset = "0x152E810", VA = "0x152E810")]
	protected void ShowConflictMessage()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x15306B4", Offset = "0x15306B4", VA = "0x15306B4")]
	protected void ClearConflictMessage()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x153072C", Offset = "0x153072C", VA = "0x153072C")]
	public bool IsLoggingIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x152F34C", Offset = "0x152F34C", VA = "0x152F34C")]
	protected void ShowScreen(CloudSave_Screen screen)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1530798", Offset = "0x1530798", VA = "0x1530798")]
	public void On_CloudInfo_Yes()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x15307A0", Offset = "0x15307A0", VA = "0x15307A0")]
	public void On_CloudInfo_No()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x15307A4", Offset = "0x15307A4", VA = "0x15307A4")]
	public void On_CloudInfo_Back()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1530880", Offset = "0x1530880", VA = "0x1530880")]
	public void On_CloudInfo_CloseToLogin()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x152F434", Offset = "0x152F434", VA = "0x152F434")]
	protected void ShowLoginScreen(bool autoLogin, bool manualFirstLogin)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1530888", Offset = "0x1530888", VA = "0x1530888")]
	public void On_LoginScreen_Back()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1530904", Offset = "0x1530904", VA = "0x1530904")]
	public void On_LoginScreen_ShowInfo()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x153090C", Offset = "0x153090C", VA = "0x153090C")]
	public void On_LoginScreen_FailedAutoLogin()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1530A88", Offset = "0x1530A88", VA = "0x1530A88")]
	public void OnSelectScreen_ShowLogin(bool showRegister)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1530BE8", Offset = "0x1530BE8", VA = "0x1530BE8")]
	public void On_LoginScreen_LoggedIn()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1530D00", Offset = "0x1530D00", VA = "0x1530D00")]
	public void On_LoginScreen_ResetPassword()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1530D34", Offset = "0x1530D34", VA = "0x1530D34")]
	public void On_MenuScreen_Back()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1530DA8", Offset = "0x1530DA8", VA = "0x1530DA8")]
	public void On_MenuScreen_Settings()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1530DB0", Offset = "0x1530DB0", VA = "0x1530DB0")]
	public void On_MenuScreen_SetPassword()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1530DB8", Offset = "0x1530DB8", VA = "0x1530DB8")]
	public void On_MenuScreen_Logout()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1530E98", Offset = "0x1530E98", VA = "0x1530E98")]
	public void On_ChangePasswordScreen_Back()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1530EA0", Offset = "0x1530EA0", VA = "0x1530EA0")]
	public void On_ResetPasswordScreen_Back(bool backToSettings)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1530EB4", Offset = "0x1530EB4", VA = "0x1530EB4")]
	public void ShowMessageScreen(string text, bool warning, CloudSave_Screen backToScreen, Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1530F88", Offset = "0x1530F88", VA = "0x1530F88")]
	public void On_MessageScreen_Closed(CloudSave_Screen backToScreen, Action<bool> resultCallback, bool result)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1531018", Offset = "0x1531018", VA = "0x1531018")]
	public void On_SettingsScreen_Back()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1531020", Offset = "0x1531020", VA = "0x1531020")]
	public void On_SettingsScreen_ChangePassword()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1531028", Offset = "0x1531028", VA = "0x1531028")]
	public void On_SettingsScreen_ResetPassword()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1531060", Offset = "0x1531060", VA = "0x1531060")]
	public void On_SettingsScreen_DeleteAccount()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1531068", Offset = "0x1531068", VA = "0x1531068")]
	public void On_DeleteAccountScreen_Back()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1531070", Offset = "0x1531070", VA = "0x1531070")]
	public void On_DeleteAccountScreen_Deleted()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x153125C", Offset = "0x153125C", VA = "0x153125C")]
	public void On_SettingsScreen_RedeemCode()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1531264", Offset = "0x1531264", VA = "0x1531264")]
	public void On_RedeemCodeScreen_Back()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x153126C", Offset = "0x153126C", VA = "0x153126C")]
	public void ShowTermsOfUseScreen(string email, string password, bool newsletter)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x15312C4", Offset = "0x15312C4", VA = "0x15312C4")]
	public void On_TermsOfUseScreen_No()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x15312CC", Offset = "0x15312CC", VA = "0x15312CC")]
	public void On_TermsOfUseScreen_Completed()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x15312D4", Offset = "0x15312D4", VA = "0x15312D4")]
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
	[Address(RVA = "0x1531378", Offset = "0x1531378", VA = "0x1531378")]
	public CloudSave_CoroutineCallback_InfoOnly(CloudSave_CoroutineCallback _baseCallback)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x15313A4", Offset = "0x15313A4", VA = "0x15313A4", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x15313A8", Offset = "0x15313A8", VA = "0x15313A8", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x15313AC", Offset = "0x15313AC", VA = "0x15313AC", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1531480", Offset = "0x1531480", VA = "0x1531480", Slot = "7")]
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
	[Address(RVA = "0x15315DC", Offset = "0x15315DC", VA = "0x15315DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1531734", Offset = "0x1531734", VA = "0x1531734", Slot = "4")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x153180C", Offset = "0x153180C", VA = "0x153180C", Slot = "5")]
	public virtual string GetTextsLanguageID()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x153189C", Offset = "0x153189C", VA = "0x153189C", Slot = "6")]
	public virtual string TranslateText(string trl)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x153192C", Offset = "0x153192C", VA = "0x153192C", Slot = "7")]
	public virtual string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x15319BC", Offset = "0x15319BC", VA = "0x15319BC", Slot = "8")]
	public virtual string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1531A4C", Offset = "0x1531A4C", VA = "0x1531A4C", Slot = "9")]
	public virtual void BackToMainMenuScene()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1531AC0", Offset = "0x1531AC0", VA = "0x1531AC0", Slot = "10")]
	public virtual uint GetSaveCloudUserId()
	{
		return default(uint);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1531B3C", Offset = "0x1531B3C", VA = "0x1531B3C", Slot = "11")]
	public virtual CloudSave_Saves ExportGameSaves()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1531BDC", Offset = "0x1531BDC", VA = "0x1531BDC", Slot = "12")]
	public virtual void ImportGameSave(CloudSave_Saves cloudSaves)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1531C50", Offset = "0x1531C50", VA = "0x1531C50", Slot = "13")]
	public virtual void DeleteLocalSaveOnRegister()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1531CC4", Offset = "0x1531CC4", VA = "0x1531CC4", Slot = "14")]
	public virtual string GetSavePreviewLabels()
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1531D54", Offset = "0x1531D54", VA = "0x1531D54", Slot = "15")]
	public virtual string GetSavePreview(CloudSave_Saves save)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1531DE4", Offset = "0x1531DE4", VA = "0x1531DE4", Slot = "16")]
	public virtual CompareSaveResult CompareSave(CloudSave_Saves save1, CloudSave_Saves save2)
	{
		return default(CompareSaveResult);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1531E60", Offset = "0x1531E60", VA = "0x1531E60", Slot = "17")]
	public virtual bool CanSendChangedLocalSaveInCurrentLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1531EDC", Offset = "0x1531EDC", VA = "0x1531EDC", Slot = "18")]
	public virtual GameObject GetCloudStatusLineObject()
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1531F58", Offset = "0x1531F58", VA = "0x1531F58", Slot = "19")]
	public virtual bool ShowCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1531FD4", Offset = "0x1531FD4", VA = "0x1531FD4", Slot = "20")]
	public virtual bool ClearCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1532050", Offset = "0x1532050", VA = "0x1532050", Slot = "21")]
	public virtual void PlaySound(SoundType sndType)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x15320C4", Offset = "0x15320C4", VA = "0x15320C4", Slot = "22")]
	public virtual void OnShowCloudScreens()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1532138", Offset = "0x1532138", VA = "0x1532138", Slot = "23")]
	public virtual bool HaveSaveForPromoCode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x15321B4", Offset = "0x15321B4", VA = "0x15321B4", Slot = "24")]
	public virtual string GetPromoCodeSkuName(string sku)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1532244", Offset = "0x1532244", VA = "0x1532244", Slot = "25")]
	public virtual void OnUsePromoCode(string sku)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x15322B8", Offset = "0x15322B8", VA = "0x15322B8")]
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
	[Address(RVA = "0x1532F50", Offset = "0x1532F50", VA = "0x1532F50")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1533014", Offset = "0x1533014", VA = "0x1533014", Slot = "8")]
	public virtual void ActivateScreen()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1533018", Offset = "0x1533018", VA = "0x1533018", Slot = "9")]
	public virtual void DeactivateScreen()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x153301C", Offset = "0x153301C", VA = "0x153301C", Slot = "10")]
	public virtual void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1533020", Offset = "0x1533020", VA = "0x1533020", Slot = "11")]
	public virtual void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1533024", Offset = "0x1533024", VA = "0x1533024", Slot = "12")]
	public virtual void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1533064", Offset = "0x1533064", VA = "0x1533064", Slot = "13")]
	public virtual void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1533104", Offset = "0x1533104", VA = "0x1533104")]
	public void ClearInfoMessage()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1533160", Offset = "0x1533160", VA = "0x1533160", Slot = "14")]
	public virtual void SetInfoMessageText(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1533208", Offset = "0x1533208", VA = "0x1533208")]
	protected string TranslateText(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x152FCD8", Offset = "0x152FCD8", VA = "0x152FCD8")]
	public static string TranslateTextWithErrorParse(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1533284", Offset = "0x1533284", VA = "0x1533284")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC248", Offset = "0x7FC248")]
	private sealed class <Run>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x18BE254", Offset = "0x18BE254", VA = "0x18BE254", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x18BE29C", Offset = "0x18BE29C", VA = "0x18BE29C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x18BE194", Offset = "0x18BE194", VA = "0x18BE194")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x18BE1C0", Offset = "0x18BE1C0", VA = "0x18BE1C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x18BE1C4", Offset = "0x18BE1C4", VA = "0x18BE1C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x18BE25C", Offset = "0x18BE25C", VA = "0x18BE25C", Slot = "8")]
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
	[Address(RVA = "0x15EF648", Offset = "0x15EF648", VA = "0x15EF648")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x15F2C18", Offset = "0x15F2C18", VA = "0x15F2C18")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback, bool dontDestroyOnLoad)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x15F2F08", Offset = "0x15F2F08", VA = "0x15F2F08", Slot = "4")]
	public virtual CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x15F2F84", Offset = "0x15F2F84", VA = "0x15F2F84", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDCCC", Offset = "0x7FDCCC")]
	public virtual IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x15F2FE0", Offset = "0x15F2FE0", VA = "0x15F2FE0", Slot = "6")]
	public virtual bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x15EF6EC", Offset = "0x15EF6EC", VA = "0x15EF6EC")]
	public void Destroy()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x15F305C", Offset = "0x15F305C", VA = "0x15F305C")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x15F3064", Offset = "0x15F3064", VA = "0x15F3064")]
	protected void CallOnStart()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x15F3124", Offset = "0x15F3124", VA = "0x15F3124")]
	protected void CallOnEnd()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x15F31E4", Offset = "0x15F31E4", VA = "0x15F31E4")]
	protected void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x15F32B8", Offset = "0x15F32B8", VA = "0x15F32B8")]
	protected void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x15F33A0", Offset = "0x15F33A0", VA = "0x15F33A0")]
	protected string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x15F3414", Offset = "0x15F3414", VA = "0x15F3414")]
	protected string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x15F3488", Offset = "0x15F3488", VA = "0x15F3488")]
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
	[Address(RVA = "0x15F1458", Offset = "0x15F1458", VA = "0x15F1458")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x15F150C", Offset = "0x15F150C", VA = "0x15F150C")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x15F4530", Offset = "0x15F4530", VA = "0x15F4530")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x15F45FC", Offset = "0x15F45FC", VA = "0x15F45FC")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x15F46B0", Offset = "0x15F46B0", VA = "0x15F46B0")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x15F477C", Offset = "0x15F477C", VA = "0x15F477C")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x15F4830", Offset = "0x15F4830", VA = "0x15F4830")]
	public static void Save()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x15F48D8", Offset = "0x15F48D8", VA = "0x15F48D8")]
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
	[Address(RVA = "0x15F4930", Offset = "0x15F4930", VA = "0x15F4930")]
	public void Start()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x15F4B04", Offset = "0x15F4B04", VA = "0x15F4B04")]
	public bool IsTranslated()
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x15F4934", Offset = "0x15F4934", VA = "0x15F4934")]
	public void TranslateText()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x15F4B0C", Offset = "0x15F4B0C", VA = "0x15F4B0C")]
	public void TranslateFromStart()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x15F4B74", Offset = "0x15F4B74", VA = "0x15F4B74")]
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
	[Address(RVA = "0x1532500", Offset = "0x1532500", VA = "0x1532500")]
	public CloudSave_Save()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1532578", Offset = "0x1532578", VA = "0x1532578")]
	public CloudSave_Save(string _save)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1532604", Offset = "0x1532604", VA = "0x1532604")]
	public CloudSave_Save(string _save, List<KeyValuePair<string, string>> _properties)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x15327DC", Offset = "0x15327DC", VA = "0x15327DC")]
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
	[Address(RVA = "0x152FF78", Offset = "0x152FF78", VA = "0x152FF78")]
	public CloudSave_Saves()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1532848", Offset = "0x1532848", VA = "0x1532848")]
	public CloudSave_Saves(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x152FDEC", Offset = "0x152FDEC", VA = "0x152FDEC")]
	public void Copy(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x15328D8", Offset = "0x15328D8", VA = "0x15328D8")]
	public void AddSave(string name, string save)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1532A98", Offset = "0x1532A98", VA = "0x1532A98")]
	public void AddSave(string name, string save, List<KeyValuePair<string, string>> properties)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1532C6C", Offset = "0x1532C6C", VA = "0x1532C6C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1530510", Offset = "0x1530510", VA = "0x1530510")]
	public int GetSavesCount()
	{
		return default(int);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x152FFF0", Offset = "0x152FFF0", VA = "0x152FFF0")]
	public string GetSaveName(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1532CC0", Offset = "0x1532CC0", VA = "0x1532CC0")]
	public string GetSave(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x153022C", Offset = "0x153022C", VA = "0x153022C")]
	public List<KeyValuePair<string, string>> GetSaveProperties(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1530158", Offset = "0x1530158", VA = "0x1530158")]
	public bool HaveSave(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1532E30", Offset = "0x1532E30", VA = "0x1532E30")]
	public string GetSave(string name)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x15303C4", Offset = "0x15303C4", VA = "0x15303C4")]
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
	[Address(RVA = "0x15F3F94", Offset = "0x15F3F94", VA = "0x15F3F94")]
	public static bool IsEncryptionEstablished()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x15F4BC8", Offset = "0x15F4BC8", VA = "0x15F4BC8")]
	public static bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x15F4C9C", Offset = "0x15F4C9C", VA = "0x15F4C9C")]
	public static void clearUser()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x15F4D9C", Offset = "0x15F4D9C", VA = "0x15F4D9C")]
	public static void clearUserAndSession()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x15F4E3C", Offset = "0x15F4E3C", VA = "0x15F4E3C")]
	public static uint GetAccountIDChecksum(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x15F4F10", Offset = "0x15F4F10", VA = "0x15F4F10")]
	public static uint GetUIDFromAccountID(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x15EFF08", Offset = "0x15EFF08", VA = "0x15EFF08")]
	public static string GetStringUIDFromAccountID(uint id)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x15F4F84", Offset = "0x15F4F84", VA = "0x15F4F84")]
	public static bool GetAccountIDFromStringUID(string suid, out uint id)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000010")]
public static class CloudSave_Utils
{
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x15F52E4", Offset = "0x15F52E4", VA = "0x15F52E4")]
	public static string RSA_encrypt(string toBeEncrypted)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x15F52E8", Offset = "0x15F52E8", VA = "0x15F52E8")]
	public static void generateAESkeyAndIV()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x15F52EC", Offset = "0x15F52EC", VA = "0x15F52EC")]
	public static string AES_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x15F52F4", Offset = "0x15F52F4", VA = "0x15F52F4")]
	public static string AES_encrypt(string input, bool MD5)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x15F3B10", Offset = "0x15F3B10", VA = "0x15F3B10")]
	public static string AES_decrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x15F54C4", Offset = "0x15F54C4", VA = "0x15F54C4")]
	private static string GetMd5Hash(MD5 md5Hash, string input)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x15F5370", Offset = "0x15F5370", VA = "0x15F5370")]
	public static string MD5_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x15F3BF4", Offset = "0x15F3BF4", VA = "0x15F3BF4")]
	public static string MD5_encryptWithSalt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x15F55F8", Offset = "0x15F55F8", VA = "0x15F55F8")]
	public static string convertBytesToString(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x15F5640", Offset = "0x15F5640", VA = "0x15F5640")]
	public static byte[] convertStringToBytes(string s)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x15F1A98", Offset = "0x15F1A98", VA = "0x15F1A98")]
	public static bool TestValidEmailFormat(string email)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x15F567C", Offset = "0x15F567C", VA = "0x15F567C")]
	public static bool GetValueInsideTag(string text, string tag, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x15F5848", Offset = "0x15F5848", VA = "0x15F5848")]
	public static string[] GetValuesInsideTags(string text, string tag)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x15F5A90", Offset = "0x15F5A90", VA = "0x15F5A90")]
	public static Dictionary<string, string> ParseKeysAssignedValues(string text, char delimeter)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x15F5C84", Offset = "0x15F5C84", VA = "0x15F5C84")]
	public static bool GetValueOfTag(string text, string valTag, out string outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x15F5D44", Offset = "0x15F5D44", VA = "0x15F5D44")]
	public static Dictionary<string, string> GetTagsAndValues(string text)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x15F5EE4", Offset = "0x15F5EE4", VA = "0x15F5EE4")]
	public static bool GetIntValueOfTag(string text, string valTag, out int outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x15F5F8C", Offset = "0x15F5F8C", VA = "0x15F5F8C")]
	public static bool ParseErrorCode(string text, out string errorText, out string errorExtCode)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x15F60E8", Offset = "0x15F60E8", VA = "0x15F60E8")]
	public static string GetUrlWithSecureProtocol(string url)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x15F61B4", Offset = "0x15F61B4", VA = "0x15F61B4")]
	public static string GetWebGLUrlProxy(string url)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x15F61B8", Offset = "0x15F61B8", VA = "0x15F61B8")]
	public static string GenRandomString(int len)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x15F6284", Offset = "0x15F6284", VA = "0x15F6284")]
	public static string EncodeBase64(string plain)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x15F6314", Offset = "0x15F6314", VA = "0x15F6314")]
	public static string DecodeBase64(string encoded)
	{
		return null;
	}
}
[Token(Token = "0x2000011")]
public class CloudSave_ServerCoroutine_ChangePassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC258", Offset = "0x7FC258")]
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

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x18BE978", Offset = "0x18BE978", VA = "0x18BE978", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x18BE9C0", Offset = "0x18BE9C0", VA = "0x18BE9C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x18BE2A4", Offset = "0x18BE2A4", VA = "0x18BE2A4")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x18BE2D0", Offset = "0x18BE2D0", VA = "0x18BE2D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x18BE2D4", Offset = "0x18BE2D4", VA = "0x18BE2D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x18BE980", Offset = "0x18BE980", VA = "0x18BE980", Slot = "8")]
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
	[Address(RVA = "0x15F3490", Offset = "0x15F3490", VA = "0x15F3490")]
	public void InitParams(string _oldPassword, string _newPassword)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x15F3498", Offset = "0x15F3498", VA = "0x15F3498", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x15F34A0", Offset = "0x15F34A0", VA = "0x15F34A0", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x15F34A8", Offset = "0x15F34A8", VA = "0x15F34A8", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDD2C", Offset = "0x7FDD2C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x15F3514", Offset = "0x15F3514", VA = "0x15F3514")]
	public CloudSave_ServerCoroutine_ChangePassword()
	{
	}
}
[Token(Token = "0x2000012")]
public class CloudSave_ServerCoroutine_DeleteAccount : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC268", Offset = "0x7FC268")]
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

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x18BF020", Offset = "0x18BF020", VA = "0x18BF020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x18BF068", Offset = "0x18BF068", VA = "0x18BF068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x18BE9C8", Offset = "0x18BE9C8", VA = "0x18BE9C8")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x18BE9F4", Offset = "0x18BE9F4", VA = "0x18BE9F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x18BE9F8", Offset = "0x18BE9F8", VA = "0x18BE9F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x18BF028", Offset = "0x18BF028", VA = "0x18BF028", Slot = "8")]
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
	[Address(RVA = "0x15F3568", Offset = "0x15F3568", VA = "0x15F3568")]
	public void InitParams(string _password)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x15F3570", Offset = "0x15F3570", VA = "0x15F3570", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x15F3578", Offset = "0x15F3578", VA = "0x15F3578", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x15F3580", Offset = "0x15F3580", VA = "0x15F3580", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDD8C", Offset = "0x7FDD8C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x15F35EC", Offset = "0x15F35EC", VA = "0x15F35EC")]
	public CloudSave_ServerCoroutine_DeleteAccount()
	{
	}
}
[Token(Token = "0x2000013")]
public class CloudSave_ServerCoroutine_LoadGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC278", Offset = "0x7FC278")]
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

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x18BF6C8", Offset = "0x18BF6C8", VA = "0x18BF6C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x18BF710", Offset = "0x18BF710", VA = "0x18BF710", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x18BF070", Offset = "0x18BF070", VA = "0x18BF070")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x18BF09C", Offset = "0x18BF09C", VA = "0x18BF09C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x18BF0A0", Offset = "0x18BF0A0", VA = "0x18BF0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x18BF6D0", Offset = "0x18BF6D0", VA = "0x18BF6D0", Slot = "8")]
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
	[Address(RVA = "0x15F3640", Offset = "0x15F3640", VA = "0x15F3640", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x15F3648", Offset = "0x15F3648", VA = "0x15F3648", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x15EFE80", Offset = "0x15EFE80", VA = "0x15EFE80")]
	public CloudSave_Saves GetResultLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x15F3650", Offset = "0x15F3650", VA = "0x15F3650")]
	public static bool ParseSavesFromServer(string text, CloudSave_Saves localSaves, out CloudSave_Saves outSaves)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x15F3C68", Offset = "0x15F3C68", VA = "0x15F3C68", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDDEC", Offset = "0x7FDDEC")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x15F3CD4", Offset = "0x15F3CD4", VA = "0x15F3CD4")]
	public CloudSave_ServerCoroutine_LoadGameSave()
	{
	}
}
[Token(Token = "0x2000014")]
public class CloudSave_ServerCoroutine_Login : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC288", Offset = "0x7FC288")]
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

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x18C0534", Offset = "0x18C0534", VA = "0x18C0534", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x18C057C", Offset = "0x18C057C", VA = "0x18C057C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x18BF718", Offset = "0x18BF718", VA = "0x18BF718")]
		[DebuggerHidden]
		public <Run>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x18BF744", Offset = "0x18BF744", VA = "0x18BF744", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x18BF748", Offset = "0x18BF748", VA = "0x18BF748", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x18C053C", Offset = "0x18C053C", VA = "0x18C053C", Slot = "8")]
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
	[Address(RVA = "0x15F2AF4", Offset = "0x15F2AF4", VA = "0x15F2AF4")]
	public void InitParams(bool _register, string _email, string _password, bool _newsletter, CloudSave_Saves _localSavesToCompare)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x15F3D38", Offset = "0x15F3D38", VA = "0x15F3D38", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x15F3D40", Offset = "0x15F3D40", VA = "0x15F3D40", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x15F3D48", Offset = "0x15F3D48", VA = "0x15F3D48")]
	public bool GetLoadSaveResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x15F3D50", Offset = "0x15F3D50", VA = "0x15F3D50")]
	public CloudSave_Saves GetLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x15F3DD8", Offset = "0x15F3DD8", VA = "0x15F3DD8", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDE4C", Offset = "0x7FDE4C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x15F3E44", Offset = "0x15F3E44", VA = "0x15F3E44")]
	public CloudSave_ServerCoroutine_Login()
	{
	}
}
[Token(Token = "0x2000015")]
public class CloudSave_ServerCoroutine_OpenSSLSession : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC298", Offset = "0x7FC298")]
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

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x18C1334", Offset = "0x18C1334", VA = "0x18C1334", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x18C137C", Offset = "0x18C137C", VA = "0x18C137C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x18C0C44", Offset = "0x18C0C44", VA = "0x18C0C44")]
		[DebuggerHidden]
		public <Run>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x18C0C70", Offset = "0x18C0C70", VA = "0x18C0C70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x18C0C74", Offset = "0x18C0C74", VA = "0x18C0C74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x18C133C", Offset = "0x18C133C", VA = "0x18C133C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC2A8", Offset = "0x7FC2A8")]
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

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x18C0BF4", Offset = "0x18C0BF4", VA = "0x18C0BF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x18C0C3C", Offset = "0x18C0C3C", VA = "0x18C0C3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x18C0584", Offset = "0x18C0584", VA = "0x18C0584")]
		[DebuggerHidden]
		public <EstablishAESSecurity>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x18C05B0", Offset = "0x18C05B0", VA = "0x18C05B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x18C05B4", Offset = "0x18C05B4", VA = "0x18C05B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x18C0BFC", Offset = "0x18C0BFC", VA = "0x18C0BFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int aesTry;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x15F3F34", Offset = "0x15F3F34", VA = "0x15F3F34", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x15F3F3C", Offset = "0x15F3F3C", VA = "0x15F3F3C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x15F411C", Offset = "0x15F411C", VA = "0x15F411C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDEAC", Offset = "0x7FDEAC")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x15F4188", Offset = "0x15F4188", VA = "0x15F4188")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDF0C", Offset = "0x7FDF0C")]
	protected IEnumerator EstablishAESSecurity()
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x15F41F4", Offset = "0x15F41F4", VA = "0x15F41F4")]
	public CloudSave_ServerCoroutine_OpenSSLSession()
	{
	}
}
[Token(Token = "0x2000016")]
public class CloudSave_ServerCoroutine_RedeemCode : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC2B8", Offset = "0x7FC2B8")]
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

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x18C1A3C", Offset = "0x18C1A3C", VA = "0x18C1A3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x18C1A84", Offset = "0x18C1A84", VA = "0x18C1A84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x18C1384", Offset = "0x18C1384", VA = "0x18C1384")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x18C13B0", Offset = "0x18C13B0", VA = "0x18C13B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x18C13B4", Offset = "0x18C13B4", VA = "0x18C13B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x18C1A44", Offset = "0x18C1A44", VA = "0x18C1A44", Slot = "8")]
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
	[Address(RVA = "0x15F41FC", Offset = "0x15F41FC", VA = "0x15F41FC")]
	public void InitParams(string _code)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x15F4204", Offset = "0x15F4204", VA = "0x15F4204", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x15F420C", Offset = "0x15F420C", VA = "0x15F420C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x15F4214", Offset = "0x15F4214", VA = "0x15F4214")]
	public string GetResultSku()
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x15F421C", Offset = "0x15F421C", VA = "0x15F421C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDF6C", Offset = "0x7FDF6C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x15F4288", Offset = "0x15F4288", VA = "0x15F4288")]
	public CloudSave_ServerCoroutine_RedeemCode()
	{
	}
}
[Token(Token = "0x2000017")]
public class CloudSave_ServerCoroutine_SendResetPassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC2C8", Offset = "0x7FC2C8")]
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

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1F524E4", Offset = "0x1F524E4", VA = "0x1F524E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x1F5252C", Offset = "0x1F5252C", VA = "0x1F5252C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1F51E44", Offset = "0x1F51E44", VA = "0x1F51E44")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1F51E70", Offset = "0x1F51E70", VA = "0x1F51E70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1F51E74", Offset = "0x1F51E74", VA = "0x1F51E74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1F524EC", Offset = "0x1F524EC", VA = "0x1F524EC", Slot = "8")]
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
	[Address(RVA = "0x15F42E0", Offset = "0x15F42E0", VA = "0x15F42E0")]
	public void InitParams(string _email)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x15F42E8", Offset = "0x15F42E8", VA = "0x15F42E8", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x15F42F0", Offset = "0x15F42F0", VA = "0x15F42F0", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x15F42F8", Offset = "0x15F42F8", VA = "0x15F42F8", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FDFCC", Offset = "0x7FDFCC")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x15F4364", Offset = "0x15F4364", VA = "0x15F4364")]
	public CloudSave_ServerCoroutine_SendResetPassword()
	{
	}
}
[Token(Token = "0x2000018")]
public class CloudSave_ServerCoroutine_SetNewsletter : CloudSave_ServerCoroutine
{
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC2D8", Offset = "0x7FC2D8")]
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

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1F52C04", Offset = "0x1F52C04", VA = "0x1F52C04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1F52C4C", Offset = "0x1F52C4C", VA = "0x1F52C4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1F52534", Offset = "0x1F52534", VA = "0x1F52534")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1F52560", Offset = "0x1F52560", VA = "0x1F52560", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1F52564", Offset = "0x1F52564", VA = "0x1F52564", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1F52C0C", Offset = "0x1F52C0C", VA = "0x1F52C0C", Slot = "8")]
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
	[Address(RVA = "0x15F43B8", Offset = "0x15F43B8", VA = "0x15F43B8")]
	public void InitParams(bool _signed)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x15F43C4", Offset = "0x15F43C4", VA = "0x15F43C4", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x15F43CC", Offset = "0x15F43CC", VA = "0x15F43CC", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x15F43D4", Offset = "0x15F43D4", VA = "0x15F43D4", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF02C", Offset = "0x7FF02C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x15F4440", Offset = "0x15F4440", VA = "0x15F4440")]
	public CloudSave_ServerCoroutine_SetNewsletter()
	{
	}
}
[Token(Token = "0x2000019")]
public class CloudSave_ServerCoroutine_StoreGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC2E8", Offset = "0x7FC2E8")]
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

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1F53E00", Offset = "0x1F53E00", VA = "0x1F53E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1F53E48", Offset = "0x1F53E48", VA = "0x1F53E48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1F52C54", Offset = "0x1F52C54", VA = "0x1F52C54")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1F52C80", Offset = "0x1F52C80", VA = "0x1F52C80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1F52C84", Offset = "0x1F52C84", VA = "0x1F52C84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1F53E08", Offset = "0x1F53E08", VA = "0x1F53E08", Slot = "8")]
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
	[Address(RVA = "0x15F0874", Offset = "0x15F0874", VA = "0x15F0874")]
	public void InitParams(CloudSave_Saves _storeSaves)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x15F4448", Offset = "0x15F4448", VA = "0x15F4448", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x15F4450", Offset = "0x15F4450", VA = "0x15F4450", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x15F4458", Offset = "0x15F4458", VA = "0x15F4458")]
	public CloudSave_Saves GetStoringSaves()
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x15F4460", Offset = "0x15F4460", VA = "0x15F4460", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF08C", Offset = "0x7FF08C")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x15F44CC", Offset = "0x15F44CC", VA = "0x15F44CC")]
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
	[Address(RVA = "0x153328C", Offset = "0x153328C", VA = "0x153328C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x15334D4", Offset = "0x15334D4", VA = "0x15334D4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1533578", Offset = "0x1533578", VA = "0x1533578", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1533654", Offset = "0x1533654", VA = "0x1533654", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1533868", Offset = "0x1533868", VA = "0x1533868")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x15338D0", Offset = "0x15338D0", VA = "0x15338D0")]
	public void OnSwitchShowOldPassword(bool on)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1533990", Offset = "0x1533990", VA = "0x1533990")]
	public void OnSwitchShowNewPassword(bool on)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1533998", Offset = "0x1533998", VA = "0x1533998")]
	public void OnSwitchShowRepeatPassword(bool on)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x15338D8", Offset = "0x15338D8", VA = "0x15338D8")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x15339A0", Offset = "0x15339A0", VA = "0x15339A0")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1533CB0", Offset = "0x1533CB0", VA = "0x1533CB0")]
	public CloudSave_Screen_ChangePassword()
	{
	}
}
[Token(Token = "0x200001B")]
public class CloudSave_Screen_CloudInfo : CloudSave_Screen
{
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC2F8", Offset = "0x7FC2F8")]
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

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x18BE144", Offset = "0x18BE144", VA = "0x18BE144", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x18BE18C", Offset = "0x18BE18C", VA = "0x18BE18C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x18BDDF8", Offset = "0x18BDDF8", VA = "0x18BDDF8")]
		[DebuggerHidden]
		public <AnimDotsCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x18BDE24", Offset = "0x18BDE24", VA = "0x18BDE24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x18BDE28", Offset = "0x18BDE28", VA = "0x18BDE28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x18BE14C", Offset = "0x18BE14C", VA = "0x18BE14C", Slot = "8")]
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
	[Address(RVA = "0x1533D04", Offset = "0x1533D04", VA = "0x1533D04")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1533E00", Offset = "0x1533E00", VA = "0x1533E00")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1533E04", Offset = "0x1533E04", VA = "0x1533E04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1533E9C", Offset = "0x1533E9C", VA = "0x1533E9C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1533EC4", Offset = "0x1533EC4", VA = "0x1533EC4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1533EEC", Offset = "0x1533EEC", VA = "0x1533EEC")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1533F54", Offset = "0x1533F54", VA = "0x1533F54")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1533FB8", Offset = "0x1533FB8", VA = "0x1533FB8")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x153401C", Offset = "0x153401C", VA = "0x153401C")]
	public void OnClickCloseToLogin()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1533E30", Offset = "0x1533E30", VA = "0x1533E30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF0EC", Offset = "0x7FF0EC")]
	protected IEnumerator AnimDotsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1534084", Offset = "0x1534084", VA = "0x1534084")]
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
	[Address(RVA = "0x1534094", Offset = "0x1534094", VA = "0x1534094", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1534180", Offset = "0x1534180", VA = "0x1534180", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1534224", Offset = "0x1534224", VA = "0x1534224", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1534300", Offset = "0x1534300", VA = "0x1534300", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1534480", Offset = "0x1534480", VA = "0x1534480")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x15344E8", Offset = "0x15344E8", VA = "0x15344E8")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1534540", Offset = "0x1534540", VA = "0x1534540")]
	public void OnClickDelete()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1534694", Offset = "0x1534694", VA = "0x1534694")]
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
	[Address(RVA = "0x153469C", Offset = "0x153469C", VA = "0x153469C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1534714", Offset = "0x1534714", VA = "0x1534714")]
	private void Start()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1534718", Offset = "0x1534718", VA = "0x1534718", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1534E24", Offset = "0x1534E24", VA = "0x1534E24", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1534EC8", Offset = "0x1534EC8", VA = "0x1534EC8")]
	public void OnBackFromTermsOfUse(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x153505C", Offset = "0x153505C", VA = "0x153505C")]
	public void OnBackFromTermsOfUseLogin(string _email, string _password, bool _newsletter, CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1535580", Offset = "0x1535580", VA = "0x1535580", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x153565C", Offset = "0x153565C", VA = "0x153565C", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1535090", Offset = "0x1535090", VA = "0x1535090")]
	protected void OnEndCoroutine(CloudSave_ServerCoroutine coroutine, bool fromTermsOfUse)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1534BA4", Offset = "0x1534BA4", VA = "0x1534BA4")]
	private void UpdateModeFields()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1534A1C", Offset = "0x1534A1C", VA = "0x1534A1C")]
	private void LoadFromPlayerPrefs()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1535748", Offset = "0x1535748", VA = "0x1535748")]
	private void OnLogin(bool confirmDeleteSaveOnRegister)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1535D80", Offset = "0x1535D80", VA = "0x1535D80")]
	private void DeleteSaveOnRegisterCallback(bool result)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1535E9C", Offset = "0x1535E9C", VA = "0x1535E9C")]
	private void DeleteSaveOnLoginToEmptyCallback(bool result)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1535FC0", Offset = "0x1535FC0", VA = "0x1535FC0")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1536024", Offset = "0x1536024", VA = "0x1536024")]
	public void OnClickShowInfo()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1530B5C", Offset = "0x1530B5C", VA = "0x1530B5C")]
	public void OnClickSwitchLogin(bool switched)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1530AD4", Offset = "0x1530AD4", VA = "0x1530AD4")]
	public void OnClickSwitchRegister(bool switched)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1534E1C", Offset = "0x1534E1C", VA = "0x1534E1C")]
	public void OnClickLogin()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x153608C", Offset = "0x153608C", VA = "0x153608C")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1536144", Offset = "0x1536144", VA = "0x1536144")]
	public void OnSwitchShowPassword1(bool on)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x15361D8", Offset = "0x15361D8", VA = "0x15361D8")]
	public void OnSwitchShowPassword2(bool on)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x153614C", Offset = "0x153614C", VA = "0x153614C")]
	public void OnSwitchShowPassword(int num, bool on)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x15361E0", Offset = "0x15361E0", VA = "0x15361E0")]
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
	[Address(RVA = "0x15EED74", Offset = "0x15EED74", VA = "0x15EED74", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x15EF650", Offset = "0x15EF650", VA = "0x15EF650", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x15EF764", Offset = "0x15EF764", VA = "0x15EF764")]
	public void Update()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x15EF894", Offset = "0x15EF894", VA = "0x15EF894", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x15EFA10", Offset = "0x15EFA10", VA = "0x15EFA10", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x15EFBB8", Offset = "0x15EFBB8", VA = "0x15EFBB8")]
	protected void OnEndCoroutineLoad()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x15EFCE8", Offset = "0x15EFCE8", VA = "0x15EFCE8")]
	protected void OnEndCoroutineStore()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x15EF2A0", Offset = "0x15EF2A0", VA = "0x15EF2A0")]
	protected void EnableImportExportButtons(bool import, bool export)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x15EF08C", Offset = "0x15EF08C", VA = "0x15EF08C")]
	protected void FillLoginInfo()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x15EF3AC", Offset = "0x15EF3AC", VA = "0x15EF3AC")]
	protected void UpdateAfterReceivedCloudSave()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x15F0360", Offset = "0x15F0360", VA = "0x15F0360")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x15F03CC", Offset = "0x15F03CC", VA = "0x15F03CC")]
	public void OnClickSettings()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x15F0438", Offset = "0x15F0438", VA = "0x15F0438")]
	public void OnSwitchShowEmail(bool on)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x15F043C", Offset = "0x15F043C", VA = "0x15F043C")]
	public void OnClickSetPassword()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x15F04FC", Offset = "0x15F04FC", VA = "0x15F04FC")]
	public void OnClickLogout()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x15F05BC", Offset = "0x15F05BC", VA = "0x15F05BC")]
	public void OnClickImport()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x15F0104", Offset = "0x15F0104", VA = "0x15F0104")]
	public void OnClickExport()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x15F0890", Offset = "0x15F0890", VA = "0x15F0890")]
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
	[Address(RVA = "0x15F08F4", Offset = "0x15F08F4", VA = "0x15F08F4", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x15F091C", Offset = "0x15F091C", VA = "0x15F091C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x15F0944", Offset = "0x15F0944", VA = "0x15F0944")]
	public void Init(string text, bool okcancel, bool warning, CloudSave_Screen _backToScreen, Action<bool> _resultCallback)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x15F0A8C", Offset = "0x15F0A8C", VA = "0x15F0A8C")]
	public void OnClickOK()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x15F0B04", Offset = "0x15F0B04", VA = "0x15F0B04")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x15F0B7C", Offset = "0x15F0B7C", VA = "0x15F0B7C")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x15F0BF4", Offset = "0x15F0BF4", VA = "0x15F0BF4")]
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
	[Address(RVA = "0x15F0BFC", Offset = "0x15F0BFC", VA = "0x15F0BFC", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x15F0C7C", Offset = "0x15F0C7C", VA = "0x15F0C7C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x15F0D1C", Offset = "0x15F0D1C", VA = "0x15F0D1C", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x15F0DFC", Offset = "0x15F0DFC", VA = "0x15F0DFC", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x15F10A4", Offset = "0x15F10A4", VA = "0x15F10A4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x15F1110", Offset = "0x15F1110", VA = "0x15F1110")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x15F12F0", Offset = "0x15F12F0", VA = "0x15F12F0")]
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
	[Address(RVA = "0x15F1344", Offset = "0x15F1344", VA = "0x15F1344", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x15F15C0", Offset = "0x15F15C0", VA = "0x15F15C0", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x15F1660", Offset = "0x15F1660", VA = "0x15F1660")]
	public void Init(bool _backToSettings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x15F166C", Offset = "0x15F166C", VA = "0x15F166C", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x15F174C", Offset = "0x15F174C", VA = "0x15F174C", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x15F18C4", Offset = "0x15F18C4", VA = "0x15F18C4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x15F1938", Offset = "0x15F1938", VA = "0x15F1938")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x15F1C00", Offset = "0x15F1C00", VA = "0x15F1C00")]
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
	[Address(RVA = "0x15F1C54", Offset = "0x15F1C54", VA = "0x15F1C54", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x15F1D48", Offset = "0x15F1D48", VA = "0x15F1D48", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x15F1DE8", Offset = "0x15F1DE8", VA = "0x15F1DE8", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x15F1EC8", Offset = "0x15F1EC8", VA = "0x15F1EC8", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x15F1FE0", Offset = "0x15F1FE0", VA = "0x15F1FE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x15F21A4", Offset = "0x15F21A4", VA = "0x15F21A4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x15F2210", Offset = "0x15F2210", VA = "0x15F2210")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x15F227C", Offset = "0x15F227C", VA = "0x15F227C")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x15F22E8", Offset = "0x15F22E8", VA = "0x15F22E8")]
	public void OnClickDeleteAccount()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x15F2354", Offset = "0x15F2354", VA = "0x15F2354")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x15F23C0", Offset = "0x15F23C0", VA = "0x15F23C0")]
	public void OnSwitchNewsletter(bool signed)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x15F2550", Offset = "0x15F2550", VA = "0x15F2550")]
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
	[Address(RVA = "0x15F2558", Offset = "0x15F2558", VA = "0x15F2558", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x15F2580", Offset = "0x15F2580", VA = "0x15F2580", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x15F2620", Offset = "0x15F2620", VA = "0x15F2620")]
	public void Init(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x15F2630", Offset = "0x15F2630", VA = "0x15F2630", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x15F2710", Offset = "0x15F2710", VA = "0x15F2710", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x15F2964", Offset = "0x15F2964", VA = "0x15F2964", Slot = "12")]
	public override void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x15F29CC", Offset = "0x15F29CC", VA = "0x15F29CC", Slot = "13")]
	public override void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x15F29DC", Offset = "0x15F29DC", VA = "0x15F29DC")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x15F2B2C", Offset = "0x15F2B2C", VA = "0x15F2B2C")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x15F2BC0", Offset = "0x15F2BC0", VA = "0x15F2BC0")]
	public CloudSave_Screen_TermsOfUse()
	{
	}
}
[Token(Token = "0x2000024")]
public class CloudSave_AdjustIconToText : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC308", Offset = "0x7FC308")]
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

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x18BDDA8", Offset = "0x18BDDA8", VA = "0x18BDDA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x18BDDF0", Offset = "0x18BDDF0", VA = "0x18BDDF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x18BD818", Offset = "0x18BD818", VA = "0x18BD818")]
		[DebuggerHidden]
		public <AdjustToTextCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x18BD844", Offset = "0x18BD844", VA = "0x18BD844", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x18BD848", Offset = "0x18BD848", VA = "0x18BD848", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x18BDDB0", Offset = "0x18BDDB0", VA = "0x18BDDB0", Slot = "8")]
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
	[Address(RVA = "0x152D0C4", Offset = "0x152D0C4", VA = "0x152D0C4")]
	public void Start()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x152D0F0", Offset = "0x152D0F0", VA = "0x152D0F0")]
	private void AdjustToText()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x152D11C", Offset = "0x152D11C", VA = "0x152D11C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF14C", Offset = "0x7FF14C")]
	public IEnumerator AdjustToTextCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x152D188", Offset = "0x152D188", VA = "0x152D188")]
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
		[Address(RVA = "0x152D190", Offset = "0x152D190", VA = "0x152D190")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x152D198", Offset = "0x152D198", VA = "0x152D198")]
		set
		{
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x152D2E4", Offset = "0x152D2E4", VA = "0x152D2E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x152D1A4", Offset = "0x152D1A4", VA = "0x152D1A4")]
	private void changeMaterial()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x152D34C", Offset = "0x152D34C", VA = "0x152D34C")]
	public void changeOtherMaterial(Material m)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x152D44C", Offset = "0x152D44C", VA = "0x152D44C")]
	private void Click()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x152D554", Offset = "0x152D554", VA = "0x152D554")]
	public void SetChecked(bool on)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x152D560", Offset = "0x152D560", VA = "0x152D560")]
	public void SetCallbackWithObject(bool on)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x152D56C", Offset = "0x152D56C", VA = "0x152D56C")]
	public void SetCustomParam(string param)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x152D574", Offset = "0x152D574", VA = "0x152D574")]
	public string GetCustomParam()
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x152D57C", Offset = "0x152D57C", VA = "0x152D57C")]
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
	[Address(RVA = "0x15322C4", Offset = "0x15322C4", VA = "0x15322C4")]
	public void ShowText(string txt, bool warning)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1530A6C", Offset = "0x1530A6C", VA = "0x1530A6C")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1532468", Offset = "0x1532468", VA = "0x1532468")]
	public bool IsWarning()
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1532470", Offset = "0x1532470", VA = "0x1532470")]
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
	[Address(RVA = "0x1EAC9C0", Offset = "0x1EAC9C0", VA = "0x1EAC9C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1EACA98", Offset = "0x1EACA98", VA = "0x1EACA98")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1EACD30", Offset = "0x1EACD30", VA = "0x1EACD30")]
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

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1F57728", Offset = "0x1F57728", VA = "0x1F57728")]
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
	[Address(RVA = "0x1EACD38", Offset = "0x1EACD38", VA = "0x1EACD38")]
	public static void UpdateMaterialsForObjectsWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1EAD108", Offset = "0x1EAD108", VA = "0x1EAD108")]
	public static void UpdateMaterialForObjectWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1EAD38C", Offset = "0x1EAD38C", VA = "0x1EAD38C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1EAD8F8", Offset = "0x1EAD8F8", VA = "0x1EAD8F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1EAD998", Offset = "0x1EAD998", VA = "0x1EAD998")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1EADB24", Offset = "0x1EADB24", VA = "0x1EADB24")]
	private void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1EADBA0", Offset = "0x1EADBA0", VA = "0x1EADBA0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1EADD10", Offset = "0x1EADD10", VA = "0x1EADD10")]
	private Vector2 Scale()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1EADD88", Offset = "0x1EADD88", VA = "0x1EADD88")]
	public static Vector2 Scale(GameObject go, bool inclSelfScale)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1EADE7C", Offset = "0x1EADE7C", VA = "0x1EADE7C")]
	public void ContentsChanged()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1EADE94", Offset = "0x1EADE94", VA = "0x1EADE94")]
	public void SetKeepMinOrgScrollSize(bool s)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1EAD8E4", Offset = "0x1EAD8E4", VA = "0x1EAD8E4")]
	public void AutoAdjustToContents(bool adjustAfterChanges = true)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1EADEA0", Offset = "0x1EADEA0", VA = "0x1EADEA0")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1EAE2B0", Offset = "0x1EAE2B0", VA = "0x1EAE2B0")]
	public void FreezeScroll(bool freeze)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1EAE2BC", Offset = "0x1EAE2BC", VA = "0x1EAE2BC")]
	public bool HaveClippedContents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1EAE318", Offset = "0x1EAE318", VA = "0x1EAE318")]
	public bool HaveClippedContentsX()
	{
		return default(bool);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1EAE344", Offset = "0x1EAE344", VA = "0x1EAE344")]
	public bool HaveClippedContentsY()
	{
		return default(bool);
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1EAE370", Offset = "0x1EAE370", VA = "0x1EAE370")]
	public bool IsScreenPointInBounds(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1EAE50C", Offset = "0x1EAE50C", VA = "0x1EAE50C")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1EAE610", Offset = "0x1EAE610", VA = "0x1EAE610")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1EAE6C0", Offset = "0x1EAE6C0", VA = "0x1EAE6C0")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1EAE71C", Offset = "0x1EAE71C", VA = "0x1EAE71C")]
	public void ScrollToTop()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1EAE77C", Offset = "0x1EAE77C", VA = "0x1EAE77C")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1EAE7DC", Offset = "0x1EAE7DC", VA = "0x1EAE7DC")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1EAE844", Offset = "0x1EAE844", VA = "0x1EAE844")]
	public bool IsScrolledToY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1EAE8B8", Offset = "0x1EAE8B8", VA = "0x1EAE8B8")]
	public bool IsInsideClipAreaY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1EAE920", Offset = "0x1EAE920", VA = "0x1EAE920")]
	public bool IsDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1EAE928", Offset = "0x1EAE928", VA = "0x1EAE928")]
	public void EnsureVisible(Vector3 pos)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1EAEB10", Offset = "0x1EAEB10", VA = "0x1EAEB10")]
	public bool IsClippedOutColChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1EAEC18", Offset = "0x1EAEC18", VA = "0x1EAEC18")]
	public bool IsClippedOutRendChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1EAED20", Offset = "0x1EAED20", VA = "0x1EAED20")]
	public void AddIgnoredNotClippedChild(GameObject go)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1EAED84", Offset = "0x1EAED84", VA = "0x1EAED84")]
	private bool IsIgnoredNotClippedChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1EAEE74", Offset = "0x1EAEE74", VA = "0x1EAEE74")]
	public void SetExtendHorzSizeToScreen()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1EAEE80", Offset = "0x1EAEE80", VA = "0x1EAEE80")]
	public void SetZoomContents(GameObject rootObj, float min, float max, float speed)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1EAEE94", Offset = "0x1EAEE94", VA = "0x1EAEE94")]
	public bool HaveZoomContents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1EAEF00", Offset = "0x1EAEF00", VA = "0x1EAEF00")]
	public static MUI_ClippedScroll GetActiveScroll(Vector2 atPoint)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1EAF0C4", Offset = "0x1EAF0C4", VA = "0x1EAF0C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1EB0214", Offset = "0x1EB0214", VA = "0x1EB0214")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1EB08D0", Offset = "0x1EB08D0", VA = "0x1EB08D0")]
	private void ClipBkgToScreen()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1EAF484", Offset = "0x1EAF484", VA = "0x1EAF484")]
	private void AdjustHorzSizeToScreen()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1EB04E0", Offset = "0x1EB04E0", VA = "0x1EB04E0")]
	private void AdjustScrollSizeToContents()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1EB165C", Offset = "0x1EB165C", VA = "0x1EB165C")]
	private void UpdateMaterials(GameObject go, ref Bounds mergedBounds)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1EB2324", Offset = "0x1EB2324", VA = "0x1EB2324")]
	private BoxColliderInfo GetBoxColliderOrgSize(BoxCollider box, Vector2 scale)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1EB259C", Offset = "0x1EB259C", VA = "0x1EB259C")]
	private void UpdateBounds(GameObject go)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1EAEB2C", Offset = "0x1EAEB2C", VA = "0x1EAEB2C")]
	private int GetClippedOutColChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1EAEC34", Offset = "0x1EAEC34", VA = "0x1EAEC34")]
	private int GetClippedOutRendChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1EB0F2C", Offset = "0x1EB0F2C", VA = "0x1EB0F2C")]
	private void UpdateAfterChanged()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1EADF40", Offset = "0x1EADF40", VA = "0x1EADF40")]
	private void UpdateScroll()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1EAE510", Offset = "0x1EAE510", VA = "0x1EAE510")]
	private void Scroll(float x, float y)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1EB3260", Offset = "0x1EB3260", VA = "0x1EB3260")]
	private Vector2 ScreenPointToWorldPos(Vector2 p)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1EAE3A0", Offset = "0x1EAE3A0", VA = "0x1EAE3A0")]
	private bool IsScreenPointInClipArea(Vector3 p)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1EB34D4", Offset = "0x1EB34D4", VA = "0x1EB34D4")]
	public void OnScrollBarDown(MUI_ClippedScroll_Bar bar, bool down)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1EAF7B8", Offset = "0x1EAF7B8", VA = "0x1EAF7B8")]
	private void StepDrag()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1EAFE98", Offset = "0x1EAFE98", VA = "0x1EAFE98")]
	private void StepScrollMouseWheel()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1EB0034", Offset = "0x1EB0034", VA = "0x1EB0034")]
	private void StepZoom()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1EB362C", Offset = "0x1EB362C", VA = "0x1EB362C")]
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
	[Address(RVA = "0x1EB37C0", Offset = "0x1EB37C0", VA = "0x1EB37C0")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1EB3824", Offset = "0x1EB3824", VA = "0x1EB3824")]
	public void Down()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1EB38B4", Offset = "0x1EB38B4", VA = "0x1EB38B4")]
	public void Up()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1EB3944", Offset = "0x1EB3944", VA = "0x1EB3944")]
	public void Click()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1EB39D4", Offset = "0x1EB39D4", VA = "0x1EB39D4")]
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
	[Address(RVA = "0x152D0BC", Offset = "0x152D0BC", VA = "0x152D0BC")]
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
	[Address(RVA = "0x152D0B4", Offset = "0x152D0B4", VA = "0x152D0B4")]
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
	[Address(RVA = "0x1EB39DC", Offset = "0x1EB39DC", VA = "0x1EB39DC")]
	public MUI_ClippedScroll_Materials()
	{
	}
}
[Token(Token = "0x200002E")]
public class MUI_Continous : MonoBehaviour
{
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1EB39E4", Offset = "0x1EB39E4", VA = "0x1EB39E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1EB3AAC", Offset = "0x1EB3AAC", VA = "0x1EB3AAC")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1EB3D44", Offset = "0x1EB3D44", VA = "0x1EB3D44")]
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
	[Address(RVA = "0x152B130", Offset = "0x152B130", VA = "0x152B130")]
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
	[Address(RVA = "0x1EB3D4C", Offset = "0x1EB3D4C", VA = "0x1EB3D4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1EB3DB4", Offset = "0x1EB3DB4", VA = "0x1EB3DB4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1EB411C", Offset = "0x1EB411C", VA = "0x1EB411C")]
	public static LayerMask GetMUIlayerMask()
	{
		return default(LayerMask);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1EB4180", Offset = "0x1EB4180", VA = "0x1EB4180")]
	public static Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1EB41E4", Offset = "0x1EB41E4", VA = "0x1EB41E4")]
	public static void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1EB424C", Offset = "0x1EB424C", VA = "0x1EB424C")]
	public static void ClearLayerMask()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1EB42C4", Offset = "0x1EB42C4", VA = "0x1EB42C4")]
	public static bool WasNowClickDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1EB4010", Offset = "0x1EB4010", VA = "0x1EB4010")]
	public static void AddLayer(string layer)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x1EB4328", Offset = "0x1EB4328", VA = "0x1EB4328")]
	public static void RemoveLayer(string layer)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1EB4498", Offset = "0x1EB4498", VA = "0x1EB4498")]
	public static bool IsDraggingItem()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1EB45FC", Offset = "0x1EB45FC", VA = "0x1EB45FC")]
	private void Zoom()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1EB4B88", Offset = "0x1EB4B88", VA = "0x1EB4B88")]
	private void Drag()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1EB5458", Offset = "0x1EB5458", VA = "0x1EB5458")]
	private bool IsChildOfActiveScroll(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1EB554C", Offset = "0x1EB554C", VA = "0x1EB554C")]
	private bool FingerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1EB5648", Offset = "0x1EB5648", VA = "0x1EB5648")]
	private bool FingerUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1EB5730", Offset = "0x1EB5730", VA = "0x1EB5730")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1EB59D8", Offset = "0x1EB59D8", VA = "0x1EB59D8")]
	private void CastRay(bool down, bool up, bool move)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1EB6118", Offset = "0x1EB6118", VA = "0x1EB6118")]
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
		[Address(RVA = "0x152D09C", Offset = "0x152D09C", VA = "0x152D09C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x152D0A4", Offset = "0x152D0A4", VA = "0x152D0A4")]
		set
		{
		}
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x152D0AC", Offset = "0x152D0AC", VA = "0x152D0AC")]
	public ClipboardHelper()
	{
	}
}
[Token(Token = "0x2000032")]
public class MUI_InputText : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC318", Offset = "0x7FC318")]
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

		[Token(Token = "0x1700007C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1F588F8", Offset = "0x1F588F8", VA = "0x1F588F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1F58940", Offset = "0x1F58940", VA = "0x1F58940", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1F57730", Offset = "0x1F57730", VA = "0x1F57730")]
		[DebuggerHidden]
		public <ReadKbdInputCoroutine>d__74(int <>1__state)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1F5775C", Offset = "0x1F5775C", VA = "0x1F5775C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1F57760", Offset = "0x1F57760", VA = "0x1F57760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1F58900", Offset = "0x1F58900", VA = "0x1F58900", Slot = "8")]
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
		[Address(RVA = "0x1EB65D4", Offset = "0x1EB65D4", VA = "0x1EB65D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1EB65DC", Offset = "0x1EB65DC", VA = "0x1EB65DC")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action SystemKeyboardShow
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1EB61F4", Offset = "0x1EB61F4", VA = "0x1EB61F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF1AC", Offset = "0x7FF1AC")]
		add
		{
		}
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1EB62EC", Offset = "0x1EB62EC", VA = "0x1EB62EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF1BC", Offset = "0x7FF1BC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event Action SystemKeyboardHide
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1EB63E4", Offset = "0x1EB63E4", VA = "0x1EB63E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF1CC", Offset = "0x7FF1CC")]
		add
		{
		}
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1EB64DC", Offset = "0x1EB64DC", VA = "0x1EB64DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF1DC", Offset = "0x7FF1DC")]
		remove
		{
		}
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1EB6BC4", Offset = "0x1EB6BC4", VA = "0x1EB6BC4")]
	public static bool IsOpenedSystemKeyboard()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1EB6C28", Offset = "0x1EB6C28", VA = "0x1EB6C28")]
	public static bool IsCurrentInputActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1EB6CC8", Offset = "0x1EB6CC8", VA = "0x1EB6CC8")]
	public void SetIsInputOfScreenKeyboard(MUI_ScreenKeyboard owner)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1EB6CD0", Offset = "0x1EB6CD0", VA = "0x1EB6CD0")]
	public void SetAllowInputInScreenKeyboard()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1EB6CDC", Offset = "0x1EB6CDC", VA = "0x1EB6CDC")]
	public void AddScreenKeyboardInput(char c)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1EB6DCC", Offset = "0x1EB6DCC", VA = "0x1EB6DCC")]
	public void SetKeyboardInputActive(bool active)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1EB6F60", Offset = "0x1EB6F60", VA = "0x1EB6F60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1EB70CC", Offset = "0x1EB70CC", VA = "0x1EB70CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1EB7170", Offset = "0x1EB7170", VA = "0x1EB7170")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1EB7198", Offset = "0x1EB7198", VA = "0x1EB7198")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1EB73E4", Offset = "0x1EB73E4", VA = "0x1EB73E4")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x1EB75A4", Offset = "0x1EB75A4", VA = "0x1EB75A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1EB75D0", Offset = "0x1EB75D0", VA = "0x1EB75D0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1EB75D4", Offset = "0x1EB75D4", VA = "0x1EB75D4")]
	private void Down()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1EB75DC", Offset = "0x1EB75DC", VA = "0x1EB75DC")]
	protected MUI_Show_ScreenKeyboard GetShowKbdComponent(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1EB7908", Offset = "0x1EB7908", VA = "0x1EB7908")]
	private void ControllerClick()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1EB6DE8", Offset = "0x1EB6DE8", VA = "0x1EB6DE8")]
	private void Click()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1EB7910", Offset = "0x1EB7910", VA = "0x1EB7910")]
	private void DoClick(bool fromController)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1EB6DF0", Offset = "0x1EB6DF0", VA = "0x1EB6DF0")]
	protected void CloseKeyboard()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1EB7E04", Offset = "0x1EB7E04", VA = "0x1EB7E04")]
	protected string GetPastedClipboardText()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1EB7E68", Offset = "0x1EB7E68", VA = "0x1EB7E68")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1EB7E70", Offset = "0x1EB7E70", VA = "0x1EB7E70")]
	public void UpdateText()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1EB65F4", Offset = "0x1EB65F4", VA = "0x1EB65F4")]
	public void SetText(string _t, int cursorPos)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1EB8270", Offset = "0x1EB8270", VA = "0x1EB8270")]
	private void SetTextMesh(string txt)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1EB7EB4", Offset = "0x1EB7EB4", VA = "0x1EB7EB4")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1EB81C0", Offset = "0x1EB81C0", VA = "0x1EB81C0")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1EB8340", Offset = "0x1EB8340", VA = "0x1EB8340")]
	protected void CreateCursor()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1EB7D44", Offset = "0x1EB7D44", VA = "0x1EB7D44")]
	protected void DestroyCursor()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1EB8674", Offset = "0x1EB8674", VA = "0x1EB8674")]
	private bool IsTouchKeyboardActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1EB7CC8", Offset = "0x1EB7CC8", VA = "0x1EB7CC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF1EC", Offset = "0x7FF1EC")]
	private IEnumerator ReadKbdInputCoroutine(int initCursorPos)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1EB8688", Offset = "0x1EB8688", VA = "0x1EB8688")]
	protected MUI_InputText FindNextInputText()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1EB89DC", Offset = "0x1EB89DC", VA = "0x1EB89DC")]
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
		[Address(RVA = "0x1EAF224", Offset = "0x1EAF224", VA = "0x1EAF224")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public static int height
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1EAF354", Offset = "0x1EAF354", VA = "0x1EAF354")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1EB8A9C", Offset = "0x1EB8A9C", VA = "0x1EB8A9C")]
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
	[Address(RVA = "0x1EB8AA8", Offset = "0x1EB8AA8", VA = "0x1EB8AA8", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1EB8AAC", Offset = "0x1EB8AAC", VA = "0x1EB8AAC", Slot = "5")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1EB8AB0", Offset = "0x1EB8AB0", VA = "0x1EB8AB0")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1EB9694", Offset = "0x1EB9694", VA = "0x1EB9694", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1EB9698", Offset = "0x1EB9698", VA = "0x1EB9698")]
	public void Show(MUI_InputText _fillInput, string label, GameObject _hideScreen)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1EB9848", Offset = "0x1EB9848", VA = "0x1EB9848")]
	public void CancelKeyboard()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1EB98A4", Offset = "0x1EB98A4", VA = "0x1EB98A4", Slot = "7")]
	public virtual void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1EB9ABC", Offset = "0x1EB9ABC", VA = "0x1EB9ABC", Slot = "8")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1EB9B68", Offset = "0x1EB9B68", VA = "0x1EB9B68", Slot = "9")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1EB9C54", Offset = "0x1EB9C54", VA = "0x1EB9C54", Slot = "10")]
	public virtual void OnInputEnter()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1EB9CA0", Offset = "0x1EB9CA0", VA = "0x1EB9CA0")]
	public void OnKeyPressed(string skey)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1EBA14C", Offset = "0x1EBA14C", VA = "0x1EBA14C")]
	protected GameObject FindObject(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1EB9F04", Offset = "0x1EB9F04", VA = "0x1EB9F04")]
	protected int FindKeyIndex(string skey)
	{
		return default(int);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1EB8BA8", Offset = "0x1EB8BA8", VA = "0x1EB8BA8")]
	protected void InitTextKeys()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1EBA00C", Offset = "0x1EBA00C", VA = "0x1EBA00C")]
	protected char GetCurrentKey(int i)
	{
		return default(char);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1EB9348", Offset = "0x1EB9348", VA = "0x1EB9348")]
	protected void FillTextKeys()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1EB99D0", Offset = "0x1EB99D0", VA = "0x1EB99D0")]
	protected string TrimEndLineCharacters(string text)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1EBA4B8", Offset = "0x1EBA4B8", VA = "0x1EBA4B8")]
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
	[Address(RVA = "0x1EBA614", Offset = "0x1EBA614", VA = "0x1EBA614")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1EBA618", Offset = "0x1EBA618", VA = "0x1EBA618")]
	private void DoInit()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1EBA698", Offset = "0x1EBA698", VA = "0x1EBA698")]
	private void Start()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1EBA784", Offset = "0x1EBA784", VA = "0x1EBA784")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1EBA81C", Offset = "0x1EBA81C", VA = "0x1EBA81C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1EB53EC", Offset = "0x1EB53EC", VA = "0x1EB53EC")]
	public static bool IsAnyScrollActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1EBA95C", Offset = "0x1EBA95C", VA = "0x1EBA95C")]
	public static bool IsAnyScrollingInBoundary()
	{
		return default(bool);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1EBA9C0", Offset = "0x1EBA9C0", VA = "0x1EBA9C0")]
	public void ResetOrgPos(Vector3 org)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1EBA9CC", Offset = "0x1EBA9CC", VA = "0x1EBA9CC")]
	public void SetSizeMinY(float y)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1EBA9D4", Offset = "0x1EBA9D4", VA = "0x1EBA9D4")]
	public void SetSize(Vector2 _size)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1EBAA20", Offset = "0x1EBAA20", VA = "0x1EBAA20")]
	public void SetOffset(Vector2 _offset)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1EBA6DC", Offset = "0x1EBA6DC", VA = "0x1EBA6DC")]
	public void ResetScroll()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1EBAB64", Offset = "0x1EBAB64", VA = "0x1EBAB64")]
	public void AutoCalculateSize()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1EBB42C", Offset = "0x1EBB42C", VA = "0x1EBB42C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x1EBB498", Offset = "0x1EBB498", VA = "0x1EBB498")]
	private void Update()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1EBB9A4", Offset = "0x1EBB9A4", VA = "0x1EBB9A4")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1EBB9D0", Offset = "0x1EBB9D0", VA = "0x1EBB9D0")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1EBBA48", Offset = "0x1EBBA48", VA = "0x1EBBA48")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1EBBAC0", Offset = "0x1EBBAC0", VA = "0x1EBBAC0")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1EBBB68", Offset = "0x1EBBB68", VA = "0x1EBBB68")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1EBBBC8", Offset = "0x1EBBBC8", VA = "0x1EBBBC8")]
	public bool IsAllOnScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1EBAA60", Offset = "0x1EBAA60", VA = "0x1EBAA60")]
	public void Clamp()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1EBBBF8", Offset = "0x1EBBBF8", VA = "0x1EBBBF8")]
	public void UpdateZoom()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1EBB334", Offset = "0x1EBB334", VA = "0x1EBB334")]
	public static Vector2 GetFrustrumSizeAt(Camera cam)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x1EBBC58", Offset = "0x1EBBC58", VA = "0x1EBBC58")]
	public void EnsureVisible(Vector3 point)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1EBC064", Offset = "0x1EBC064", VA = "0x1EBC064")]
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
	[Address(RVA = "0x1EB7B50", Offset = "0x1EB7B50", VA = "0x1EB7B50")]
	public void Click()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x1EBC0D4", Offset = "0x1EBC0D4", VA = "0x1EBC0D4")]
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
	[Address(RVA = "0x1EBC128", Offset = "0x1EBC128", VA = "0x1EBC128")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1EBC150", Offset = "0x1EBC150", VA = "0x1EBC150")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1EBC248", Offset = "0x1EBC248", VA = "0x1EBC248")]
	public void SetValChangedCallback(Action<MUI_Slider, float> callback)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1EBC250", Offset = "0x1EBC250", VA = "0x1EBC250")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1EBC258", Offset = "0x1EBC258", VA = "0x1EBC258")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1EBC29C", Offset = "0x1EBC29C", VA = "0x1EBC29C")]
	public float GetVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1EBC31C", Offset = "0x1EBC31C", VA = "0x1EBC31C")]
	public void SetVal(float v)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1EBC160", Offset = "0x1EBC160", VA = "0x1EBC160")]
	private void UpdateSquarePos()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1EBC3CC", Offset = "0x1EBC3CC", VA = "0x1EBC3CC")]
	private void Down()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1EBC55C", Offset = "0x1EBC55C", VA = "0x1EBC55C")]
	private void Click()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1EBC560", Offset = "0x1EBC560", VA = "0x1EBC560")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1EBC3D0", Offset = "0x1EBC3D0", VA = "0x1EBC3D0")]
	private void Process()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1EBC564", Offset = "0x1EBC564", VA = "0x1EBC564")]
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
	[Address(RVA = "0x1EBC578", Offset = "0x1EBC578", VA = "0x1EBC578")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1EBC670", Offset = "0x1EBC670", VA = "0x1EBC670")]
	public void SetValChangedCallback(Action<MUI_SliderVertical, float, float> callback)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x1EBC678", Offset = "0x1EBC678", VA = "0x1EBC678")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1EBC680", Offset = "0x1EBC680", VA = "0x1EBC680")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x1EBC6C4", Offset = "0x1EBC6C4", VA = "0x1EBC6C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x1EBC588", Offset = "0x1EBC588", VA = "0x1EBC588")]
	public void UpdateSquarePos()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1EBC9B4", Offset = "0x1EBC9B4", VA = "0x1EBC9B4")]
	private void Down()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x1EBC9B8", Offset = "0x1EBC9B8", VA = "0x1EBC9B8")]
	private void Click()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1EBC9BC", Offset = "0x1EBC9BC", VA = "0x1EBC9BC")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1EBC754", Offset = "0x1EBC754", VA = "0x1EBC754")]
	private void Process()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1EBC9C0", Offset = "0x1EBC9C0", VA = "0x1EBC9C0")]
	public MUI_SliderVertical()
	{
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7FBEE0", Offset = "0x7FBEE0")]
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

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1F58948", Offset = "0x1F58948", VA = "0x1F58948")]
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
	[Address(RVA = "0x1EBC9D4", Offset = "0x1EBC9D4", VA = "0x1EBC9D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1EBCB44", Offset = "0x1EBCB44", VA = "0x1EBCB44")]
	private static void FindInstance()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x1EBCCD4", Offset = "0x1EBCCD4", VA = "0x1EBCCD4")]
	public static void Play(int num)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1EBCE18", Offset = "0x1EBCE18", VA = "0x1EBCE18")]
	private void Play()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1EBCF70", Offset = "0x1EBCF70", VA = "0x1EBCF70")]
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
	[Address(RVA = "0x1EBCF84", Offset = "0x1EBCF84", VA = "0x1EBCF84")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1EBD170", Offset = "0x1EBD170", VA = "0x1EBD170")]
	private void Down()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1EBD3F8", Offset = "0x1EBD3F8", VA = "0x1EBD3F8")]
	private void Up()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1EBD5AC", Offset = "0x1EBD5AC", VA = "0x1EBD5AC")]
	private void Click()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1EBD620", Offset = "0x1EBD620", VA = "0x1EBD620")]
	private void IsDown(BoolRef isDown)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1EBD63C", Offset = "0x1EBD63C", VA = "0x1EBD63C")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1EBD64C", Offset = "0x1EBD64C", VA = "0x1EBD64C")]
	public bool IsDisabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1EBD654", Offset = "0x1EBD654", VA = "0x1EBD654")]
	public void Disable()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1EBD880", Offset = "0x1EBD880", VA = "0x1EBD880")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1EBDA80", Offset = "0x1EBDA80", VA = "0x1EBDA80")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x1EBDA8C", Offset = "0x1EBDA8C", VA = "0x1EBDA8C")]
	public void SetDisabled(bool disabled)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1EBDA98", Offset = "0x1EBDA98", VA = "0x1EBDA98")]
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
	[Address(RVA = "0x1EBDAD0", Offset = "0x1EBDAD0", VA = "0x1EBDAD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1EBDB48", Offset = "0x1EBDB48", VA = "0x1EBDB48")]
	private void Start()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1EBDFA4", Offset = "0x1EBDFA4", VA = "0x1EBDFA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1EBDFA8", Offset = "0x1EBDFA8", VA = "0x1EBDFA8")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x1EBDB4C", Offset = "0x1EBDB4C", VA = "0x1EBDB4C")]
	public void Calculate()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1EBE3FC", Offset = "0x1EBE3FC", VA = "0x1EBE3FC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1EBE0D0", Offset = "0x1EBE0D0", VA = "0x1EBE0D0")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1EBDFAC", Offset = "0x1EBDFAC", VA = "0x1EBDFAC")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1EBE6FC", Offset = "0x1EBE6FC", VA = "0x1EBE6FC")]
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
	[Address(RVA = "0x1924374", Offset = "0x1924374", VA = "0x1924374")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x19243E0", Offset = "0x19243E0", VA = "0x19243E0")]
	public static void InitDefaults()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1924BDC", Offset = "0x1924BDC", VA = "0x1924BDC")]
	public static bool HadSet(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1924CAC", Offset = "0x1924CAC", VA = "0x1924CAC")]
	public static bool Get(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1924D7C", Offset = "0x1924D7C", VA = "0x1924D7C")]
	public static void Set(eCheck e, bool v)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x1924DEC", Offset = "0x1924DEC", VA = "0x1924DEC")]
	public static void Set(int i, bool v)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1924F04", Offset = "0x1924F04", VA = "0x1924F04")]
	public static void Switch(eCheck i)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x192504C", Offset = "0x192504C", VA = "0x192504C")]
	public static float GetFloat(eSlider i)
	{
		return default(float);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x19250DC", Offset = "0x19250DC", VA = "0x19250DC")]
	public static void SetFloat(eSlider i, float v)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1925190", Offset = "0x1925190", VA = "0x1925190")]
	public static bool GetNS(eCheckNotSaved i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1925220", Offset = "0x1925220", VA = "0x1925220")]
	public static void SetNS(int i, bool v)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x19252C8", Offset = "0x19252C8", VA = "0x19252C8")]
	public static void SwitchNS(eCheckNotSaved i)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1925360", Offset = "0x1925360", VA = "0x1925360")]
	public static void Save()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x192557C", Offset = "0x192557C", VA = "0x192557C")]
	public static bool CanLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x19247CC", Offset = "0x19247CC", VA = "0x19247CC")]
	public static void Load()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1925610", Offset = "0x1925610", VA = "0x1925610")]
	private void Click()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1925668", Offset = "0x1925668", VA = "0x1925668")]
	public MUI_data()
	{
	}
}
[Token(Token = "0x2000040")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7FBF40", Offset = "0x7FBF40")]
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
	[Address(RVA = "0x192575C", Offset = "0x192575C", VA = "0x192575C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1925864", Offset = "0x1925864", VA = "0x1925864")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1925B68", Offset = "0x1925B68", VA = "0x1925B68")]
	private void SetWidth(float w)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1925B70", Offset = "0x1925B70", VA = "0x1925B70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1925DB8", Offset = "0x1925DB8", VA = "0x1925DB8")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1925B80", Offset = "0x1925B80", VA = "0x1925B80")]
	private void BreakNow()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1925DBC", Offset = "0x1925DBC", VA = "0x1925DBC")]
	public static int IndexOfNth(string str, char c, int nth, int startPosition = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1925E74", Offset = "0x1925E74", VA = "0x1925E74")]
	public void BreakLinesFromLine(int line, float width)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1926074", Offset = "0x1926074", VA = "0x1926074")]
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
	[Address(RVA = "0x18B5B60", Offset = "0x18B5B60", VA = "0x18B5B60")]
	public StringBufferWrapper(int capacity)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x18B5C14", Offset = "0x18B5C14", VA = "0x18B5C14")]
	public StringBufferWrapper()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x18B5C7C", Offset = "0x18B5C7C", VA = "0x18B5C7C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x18B5CB8", Offset = "0x18B5CB8", VA = "0x18B5CB8")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x18B5CF0", Offset = "0x18B5CF0", VA = "0x18B5CF0")]
	public unsafe void Append(char* str, int startIdx, int count)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x18B5D38", Offset = "0x18B5D38", VA = "0x18B5D38")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x18B5D9C", Offset = "0x18B5D9C", VA = "0x18B5D9C")]
	public void Append(StringBufferWrapper sb)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x18B5DE4", Offset = "0x18B5DE4", VA = "0x18B5DE4")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x18B5E4C", Offset = "0x18B5E4C", VA = "0x18B5E4C")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x18B5EB8", Offset = "0x18B5EB8", VA = "0x18B5EB8")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x18B5F44", Offset = "0x18B5F44", VA = "0x18B5F44", Slot = "3")]
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
		[Address(RVA = "0x18B5F78", Offset = "0x18B5F78", VA = "0x18B5F78")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000008")]
	public float height
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x18B6160", Offset = "0x18B6160", VA = "0x18B6160")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x18B61B8", Offset = "0x18B61B8", VA = "0x18B61B8")]
	public TextSize(TextMesh tm, int textCapacity = -1, int wordCapacity = -1)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x18B62C4", Offset = "0x18B62C4", VA = "0x18B62C4")]
	private void getSpace()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x18B5FB0", Offset = "0x18B5FB0", VA = "0x18B5FB0")]
	private float GetTextWidth(string s)
	{
		return default(float);
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x18B646C", Offset = "0x18B646C", VA = "0x18B646C")]
	private string RemoveLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x18B6590", Offset = "0x18B6590", VA = "0x18B6590")]
	private string RemoveSingleLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x18B672C", Offset = "0x18B672C", VA = "0x18B672C")]
	public void FitToWidth(float wantedWidth, bool removeLineBreaks, bool removeSingleLineBreaks, int leaveFirstNbreaks, bool justifyLines, bool resetDictionary, int maxLines)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x18B6EF8", Offset = "0x18B6EF8", VA = "0x18B6EF8")]
	private bool IsCHchar(char c)
	{
		return default(bool);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x18B6A0C", Offset = "0x18B6A0C", VA = "0x18B6A0C")]
	private unsafe bool WrapLine(char* s, int startIdx, int endIdx, float w, bool justifyLine)
	{
		return default(bool);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x18B6F08", Offset = "0x18B6F08", VA = "0x18B6F08")]
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
	[Address(RVA = "0x19260A0", Offset = "0x19260A0", VA = "0x19260A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x192615C", Offset = "0x192615C", VA = "0x192615C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1926168", Offset = "0x1926168", VA = "0x1926168")]
	private void Update()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x19264A4", Offset = "0x19264A4", VA = "0x19264A4")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x19261A0", Offset = "0x19261A0", VA = "0x19261A0")]
	public void Calculate()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x19264B0", Offset = "0x19264B0", VA = "0x19264B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x19267B4", Offset = "0x19267B4", VA = "0x19267B4")]
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
	[Address(RVA = "0x18B57C8", Offset = "0x18B57C8", VA = "0x18B57C8")]
	public StringBuffer(int capacity)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x18B583C", Offset = "0x18B583C", VA = "0x18B583C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x18B5844", Offset = "0x18B5844", VA = "0x18B5844")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x18B58D0", Offset = "0x18B58D0", VA = "0x18B58D0")]
	public unsafe void Append(char* str, int count)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x18B5940", Offset = "0x18B5940", VA = "0x18B5940")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x18B5970", Offset = "0x18B5970", VA = "0x18B5970")]
	public void Append(StringBuffer sb)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x18B5A00", Offset = "0x18B5A00", VA = "0x18B5A00")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x18B5A34", Offset = "0x18B5A34", VA = "0x18B5A34")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x18B5A8C", Offset = "0x18B5A8C", VA = "0x18B5A8C")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x18B5AA0", Offset = "0x18B5AA0", VA = "0x18B5AA0", Slot = "3")]
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
	[Address(RVA = "0x1926840", Offset = "0x1926840", VA = "0x1926840")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1926850", Offset = "0x1926850", VA = "0x1926850")]
	public void MergeMeshNow()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1926F58", Offset = "0x1926F58", VA = "0x1926F58")]
	public void AddTR(Transform t0)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x1927578", Offset = "0x1927578", VA = "0x1927578")]
	public void CountData(Mesh m, Vector3[] mvertices, Renderer r)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x1928210", Offset = "0x1928210", VA = "0x1928210")]
	public void AddMaterial(Material m)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x192831C", Offset = "0x192831C", VA = "0x192831C")]
	public int GetMaterialIndex(Material m)
	{
		return default(int);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1927674", Offset = "0x1927674", VA = "0x1927674")]
	private void BuildMesh(Transform t, Mesh m, Vector3[] mvertices)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1927E14", Offset = "0x1927E14", VA = "0x1927E14")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1928434", Offset = "0x1928434", VA = "0x1928434")]
	public MergeMesh()
	{
	}
}
[Token(Token = "0x2000046")]
public class OpenUrl
{
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x18AE2BC", Offset = "0x18AE2BC", VA = "0x18AE2BC")]
	public static void Open(string url)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x18AE2FC", Offset = "0x18AE2FC", VA = "0x18AE2FC")]
	public static void Open(string url, string steamBundleID)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x18AE368", Offset = "0x18AE368", VA = "0x18AE368")]
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
		[Address(RVA = "0x18AE370", Offset = "0x18AE370", VA = "0x18AE370")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	public static bool sidequestStore
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x18AE378", Offset = "0x18AE378", VA = "0x18AE378")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	public static bool oculusStore
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x18AE3E4", Offset = "0x18AE3E4", VA = "0x18AE3E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public static bool steamStore
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x18AE450", Offset = "0x18AE450", VA = "0x18AE450")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public static bool viveStore
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x18AE4BC", Offset = "0x18AE4BC", VA = "0x18AE4BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public static bool microsoftStore
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x18AE528", Offset = "0x18AE528", VA = "0x18AE528")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public static bool noloStore
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x18AE594", Offset = "0x18AE594", VA = "0x18AE594")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public static bool picoStore
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x18AE600", Offset = "0x18AE600", VA = "0x18AE600")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public static bool yvrStore
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x18AE66C", Offset = "0x18AE66C", VA = "0x18AE66C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public static bool qiyuStore
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x18AE6D8", Offset = "0x18AE6D8", VA = "0x18AE6D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public static bool standaloneOVRStore
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x18AE744", Offset = "0x18AE744", VA = "0x18AE744")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public static bool oculusVR
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x18AE7B0", Offset = "0x18AE7B0", VA = "0x18AE7B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public static bool steamVR
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x18AE81C", Offset = "0x18AE81C", VA = "0x18AE81C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000016")]
	public static bool noloVR
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x18AE888", Offset = "0x18AE888", VA = "0x18AE888")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public static bool waveVR
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x18AE8F4", Offset = "0x18AE8F4", VA = "0x18AE8F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public static bool picoVR
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x18AE960", Offset = "0x18AE960", VA = "0x18AE960")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000019")]
	public static bool yvrVR
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x18AE9CC", Offset = "0x18AE9CC", VA = "0x18AE9CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001A")]
	public static bool qiyuVR
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x18AEA38", Offset = "0x18AEA38", VA = "0x18AEA38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001B")]
	public static bool android
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x18AEAA4", Offset = "0x18AEAA4", VA = "0x18AEAA4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001C")]
	public static bool winStore
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x18AEAAC", Offset = "0x18AEAAC", VA = "0x18AEAAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001D")]
	public static bool winStandalone
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x18AEAB4", Offset = "0x18AEAB4", VA = "0x18AEAB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public static bool iOS
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x18AEABC", Offset = "0x18AEABC", VA = "0x18AEABC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public static bool macOsStandalone
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x18AEAC4", Offset = "0x18AEAC4", VA = "0x18AEAC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public static bool standalone
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x18AEACC", Offset = "0x18AEACC", VA = "0x18AEACC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public static bool linuxStandalone
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x18AEAD4", Offset = "0x18AEAD4", VA = "0x18AEAD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public static bool mobile
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x18AEADC", Offset = "0x18AEADC", VA = "0x18AEADC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000023")]
	public static bool PC
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x18AEB38", Offset = "0x18AEB38", VA = "0x18AEB38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000024")]
	public static string str0xA0
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x18AEBAC", Offset = "0x18AEBAC", VA = "0x18AEBAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x18AEBF0", Offset = "0x18AEBF0", VA = "0x18AEBF0")]
	public static void CheckDevMode()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x18AEE54", Offset = "0x18AEE54", VA = "0x18AEE54")]
	public static int GetQuestSystemVersion()
	{
		return default(int);
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x18AF6A8", Offset = "0x18AF6A8", VA = "0x18AF6A8")]
	public static bool IsMinRequiredQuestSystemVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x18AF734", Offset = "0x18AF734", VA = "0x18AF734")]
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

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x15F63AC", Offset = "0x15F63AC", VA = "0x15F63AC")]
	public void ComputeConvolution(Cubemap originalCubeMap)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x15F69D0", Offset = "0x15F69D0", VA = "0x15F69D0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x15F6628", Offset = "0x15F6628", VA = "0x15F6628")]
	private Cubemap computeFilteredCubeMap(Cubemap originalCubeMap)
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x15F6BF4", Offset = "0x15F6BF4", VA = "0x15F6BF4")]
	private void setFaceAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x15F6D24", Offset = "0x15F6D24", VA = "0x15F6D24")]
	private void setCornerAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f, int g, int h, int i)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x15F6A80", Offset = "0x15F6A80", VA = "0x15F6A80")]
	private Vector3 getDirection(int face, int i, int j, int size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x15F6EE8", Offset = "0x15F6EE8", VA = "0x15F6EE8")]
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

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x15FF344", Offset = "0x15FF344", VA = "0x15FF344")]
	public static implicit operator EncodedInt(int value)
	{
		return default(EncodedInt);
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x15FF360", Offset = "0x15FF360", VA = "0x15FF360")]
	public static bool operator ==(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x15FF3F4", Offset = "0x15FF3F4", VA = "0x15FF3F4")]
	public static bool operator !=(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x15FF41C", Offset = "0x15FF41C", VA = "0x15FF41C")]
	public static bool operator ==(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x15FF448", Offset = "0x15FF448", VA = "0x15FF448")]
	public static bool operator !=(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x15FF474", Offset = "0x15FF474", VA = "0x15FF474")]
	public void setValue(int val)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x15FF388", Offset = "0x15FF388", VA = "0x15FF388")]
	public int getValue()
	{
		return default(int);
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x15FF350", Offset = "0x15FF350", VA = "0x15FF350")]
	private EncodedInt(int val)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x15FF518", Offset = "0x15FF518", VA = "0x15FF518")]
	private void Init(int val)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x15FF570", Offset = "0x15FF570", VA = "0x15FF570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x15FF59C", Offset = "0x15FF59C", VA = "0x15FF59C")]
	public string ToString(string format)
	{
		return null;
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x15FF5D0", Offset = "0x15FF5D0", VA = "0x15FF5D0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x15FF690", Offset = "0x15FF690", VA = "0x15FF690")]
	public bool Equals(EncodedInt p)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x15FF6C4", Offset = "0x15FF6C4", VA = "0x15FF6C4", Slot = "2")]
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

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x18B8548", Offset = "0x18B8548", VA = "0x18B8548")]
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

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x18B1A9C", Offset = "0x18B1A9C", VA = "0x18B1A9C")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x18B21A0", Offset = "0x18B21A0", VA = "0x18B21A0")]
	public static float GetFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x18B2208", Offset = "0x18B2208", VA = "0x18B2208")]
	public static float GetFloat(string key, float defval)
	{
		return default(float);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x18B2310", Offset = "0x18B2310", VA = "0x18B2310")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x18B2378", Offset = "0x18B2378", VA = "0x18B2378")]
	public static int GetInt(string key, int defval)
	{
		return default(int);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x18B2480", Offset = "0x18B2480", VA = "0x18B2480")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x18B24FC", Offset = "0x18B24FC", VA = "0x18B24FC")]
	public static string GetString(string key, string defval)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x18B2618", Offset = "0x18B2618", VA = "0x18B2618")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x18B26F8", Offset = "0x18B26F8", VA = "0x18B26F8")]
	public static void Save()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x18B29C4", Offset = "0x18B29C4", VA = "0x18B29C4")]
	public static void SetFloat(string key, float val)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x18B2B5C", Offset = "0x18B2B5C", VA = "0x18B2B5C")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x18B2CF4", Offset = "0x18B2CF4", VA = "0x18B2CF4")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x18B1BE0", Offset = "0x18B1BE0", VA = "0x18B1BE0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x18B2EA0", Offset = "0x18B2EA0", VA = "0x18B2EA0")]
	public static void InitQUIYU(string prefix)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x18B2EA4", Offset = "0x18B2EA4", VA = "0x18B2EA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x18B34DC", Offset = "0x18B34DC", VA = "0x18B34DC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x18B3430", Offset = "0x18B3430", VA = "0x18B3430")]
	private string GetHardcodedOculusCloudSaveDirectory()
	{
		return null;
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x18B3598", Offset = "0x18B3598", VA = "0x18B3598")]
	private void OnCompleteGetUserDirectoryPath(Message msg)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x18B3924", Offset = "0x18B3924", VA = "0x18B3924")]
	public static bool IsInitializing()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x18B3A34", Offset = "0x18B3A34", VA = "0x18B3A34")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x18B3C74", Offset = "0x18B3C74", VA = "0x18B3C74")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x18B3D1C", Offset = "0x18B3D1C", VA = "0x18B3D1C")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x18B1D54", Offset = "0x18B1D54", VA = "0x18B1D54")]
	public static bool IsUseWrapper()
	{
		return default(bool);
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x18B1E44", Offset = "0x18B1E44", VA = "0x18B1E44")]
	protected static void LoadWrapper()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x18B27EC", Offset = "0x18B27EC", VA = "0x18B27EC")]
	protected static void StoreWrapper()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x18B3DC4", Offset = "0x18B3DC4", VA = "0x18B3DC4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC328", Offset = "0x7FC328")]
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

		[Token(Token = "0x1700007E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1F59084", Offset = "0x1F59084", VA = "0x1F59084", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1F590CC", Offset = "0x1F590CC", VA = "0x1F590CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1F58FE4", Offset = "0x1F58FE4", VA = "0x1F58FE4")]
		[DebuggerHidden]
		public <RunCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1F59010", Offset = "0x1F59010", VA = "0x1F59010", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1F59014", Offset = "0x1F59014", VA = "0x1F59014", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1F5908C", Offset = "0x1F5908C", VA = "0x1F5908C", Slot = "8")]
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

	[Token(Token = "0x17000025")]
	public static bool Initialized
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x18B5124", Offset = "0x18B5124", VA = "0x18B5124")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000026")]
	private static SteamManager Instance
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x18B5210", Offset = "0x18B5210", VA = "0x18B5210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000003")]
	public static event BoolEvent overlayActivated
	{
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x18B5544", Offset = "0x18B5544", VA = "0x18B5544")]
		add
		{
		}
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x18B5660", Offset = "0x18B5660", VA = "0x18B5660")]
		remove
		{
		}
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x18B525C", Offset = "0x18B525C", VA = "0x18B525C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x18B538C", Offset = "0x18B538C", VA = "0x18B538C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x18B5430", Offset = "0x18B5430", VA = "0x18B5430")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x18B54D4", Offset = "0x18B54D4", VA = "0x18B54D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x18B54D8", Offset = "0x18B54D8", VA = "0x18B54D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF24C", Offset = "0x7FF24C")]
	private IEnumerator RunCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x18B577C", Offset = "0x18B577C", VA = "0x18B577C")]
	public static string GetPlayerName()
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x18B57C0", Offset = "0x18B57C0", VA = "0x18B57C0")]
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

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1F593A8", Offset = "0x1F593A8", VA = "0x1F593A8")]
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

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x18B71E4", Offset = "0x18B71E4", VA = "0x18B71E4")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x18B71E8", Offset = "0x18B71E8", VA = "0x18B71E8")]
	public static void LogError(string text)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x18B7278", Offset = "0x18B7278", VA = "0x18B7278")]
	private void Awake()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x18B7380", Offset = "0x18B7380", VA = "0x18B7380")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x18B7424", Offset = "0x18B7424", VA = "0x18B7424")]
	private void Update()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x18B7D44", Offset = "0x18B7D44", VA = "0x18B7D44")]
	public static DownloadedTexture GetTexture(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x18B7D90", Offset = "0x18B7D90", VA = "0x18B7D90")]
	public static DownloadedTexture GetTexture(string filePath, string resourcesFolder)
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x18B8480", Offset = "0x18B8480", VA = "0x18B8480")]
	protected static string GetFileName(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x18B7428", Offset = "0x18B7428", VA = "0x18B7428")]
	private void StepDownloadingTextures()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x18B84D0", Offset = "0x18B84D0", VA = "0x18B84D0")]
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

	[Token(Token = "0x17000027")]
	public override bool keepWaiting
	{
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x18B866C", Offset = "0x18B866C", VA = "0x18B866C", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000028")]
	public string error
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x18B8698", Offset = "0x18B8698", VA = "0x18B8698")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public string text
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x18B8740", Offset = "0x18B8740", VA = "0x18B8740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public byte[] data
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x18B876C", Offset = "0x18B876C", VA = "0x18B876C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	public string data2string
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x18B8798", Offset = "0x18B8798", VA = "0x18B8798")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public bool isDone
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x18B88AC", Offset = "0x18B88AC", VA = "0x18B88AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x18B88C8", Offset = "0x18B88C8", VA = "0x18B88C8")]
	public WWWwrapper(string url, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x18B8A40", Offset = "0x18B8A40", VA = "0x18B8A40")]
	public WWWwrapper(string url, WWWForm form, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x18B8BD8", Offset = "0x18B8BD8", VA = "0x18B8BD8")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x18B8BF4", Offset = "0x18B8BF4", VA = "0x18B8BF4")]
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
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x151D604", Offset = "0x151D604", VA = "0x151D604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF2AC", Offset = "0x7FF2AC")]
		add
		{
		}
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x151D6A4", Offset = "0x151D6A4", VA = "0x151D6A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF2BC", Offset = "0x7FF2BC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	private event Action<string> OnPermissionDeniedAction
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x151D744", Offset = "0x151D744", VA = "0x151D744")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF2CC", Offset = "0x7FF2CC")]
		add
		{
		}
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x151D7E4", Offset = "0x151D7E4", VA = "0x151D7E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF2DC", Offset = "0x7FF2DC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	private event Action<string> OnPermissionDeniedAndDontAskAgainAction
	{
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x151D884", Offset = "0x151D884", VA = "0x151D884")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF2EC", Offset = "0x7FF2EC")]
		add
		{
		}
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x151D924", Offset = "0x151D924", VA = "0x151D924")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF2FC", Offset = "0x7FF2FC")]
		remove
		{
		}
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x151D9C4", Offset = "0x151D9C4", VA = "0x151D9C4")]
	public AndroidPermissionCallback(Action<string> onGrantedCallback, Action<string> onDeniedCallback, Action<string> onDeniedAndDontAskAgainCallback)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x151DAA0", Offset = "0x151DAA0", VA = "0x151DAA0", Slot = "9")]
	public virtual void OnPermissionGranted(string permissionName)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x151DB10", Offset = "0x151DB10", VA = "0x151DB10", Slot = "10")]
	public virtual void OnPermissionDenied(string permissionName)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x151DB80", Offset = "0x151DB80", VA = "0x151DB80", Slot = "11")]
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

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x151DBF8", Offset = "0x151DBF8", VA = "0x151DBF8")]
	private static AndroidJavaObject GetActivity()
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x151DCE0", Offset = "0x151DCE0", VA = "0x151DCE0")]
	private static AndroidJavaObject GetPermissionsService()
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x151DE24", Offset = "0x151DE24", VA = "0x151DE24")]
	public static bool IsPermissionGranted(string permissionName)
	{
		return default(bool);
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x151DF3C", Offset = "0x151DF3C", VA = "0x151DF3C")]
	public static void RequestPermission(string permissionName, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x151DFE8", Offset = "0x151DFE8", VA = "0x151DFE8")]
	public static void RequestPermission(string[] permissionNames, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x151E120", Offset = "0x151E120", VA = "0x151E120")]
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

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x18BBF48", Offset = "0x18BBF48", VA = "0x18BBF48")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x18BBF9C", Offset = "0x18BBF9C", VA = "0x18BBF9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x18BC304", Offset = "0x18BC304", VA = "0x18BC304")]
	public WaterSimple()
	{
	}
}
namespace JSONplugin
{
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7FBFC0", Offset = "0x7FBFC0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC338", Offset = "0x7FC338")]
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

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000792")]
				[Address(RVA = "0x1F55258", Offset = "0x1F55258", VA = "0x1F55258", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000794")]
				[Address(RVA = "0x1F552A0", Offset = "0x1F552A0", VA = "0x1F552A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x1F54E6C", Offset = "0x1F54E6C", VA = "0x1F54E6C")]
			[DebuggerHidden]
			public <BakeAsync>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1F54EA4", Offset = "0x1F54EA4", VA = "0x1F54EA4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1F54F7C", Offset = "0x1F54F7C", VA = "0x1F54F7C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1F54EC0", Offset = "0x1F54EC0", VA = "0x1F54EC0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1F55260", Offset = "0x1F55260", VA = "0x1F55260", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1F552A8", Offset = "0x1F552A8", VA = "0x1F552A8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1F55350", Offset = "0x1F55350", VA = "0x1F55350", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC348", Offset = "0x7FC348")]
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

			[Token(Token = "0x17000082")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0x1F557DC", Offset = "0x1F557DC", VA = "0x1F557DC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0x1F55824", Offset = "0x1F55824", VA = "0x1F55824", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1F55354", Offset = "0x1F55354", VA = "0x1F55354")]
			[DebuggerHidden]
			public <PrintAsync>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x1F5538C", Offset = "0x1F5538C", VA = "0x1F5538C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1F55470", Offset = "0x1F55470", VA = "0x1F55470", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1F553A8", Offset = "0x1F553A8", VA = "0x1F553A8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1F557E4", Offset = "0x1F557E4", VA = "0x1F557E4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x1F5582C", Offset = "0x1F5582C", VA = "0x1F5582C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x1F558DC", Offset = "0x1F558DC", VA = "0x1F558DC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC358", Offset = "0x7FC358")]
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

			[Token(Token = "0x17000084")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x1F56AF8", Offset = "0x1F56AF8", VA = "0x1F56AF8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A7")]
				[Address(RVA = "0x1F56B40", Offset = "0x1F56B40", VA = "0x1F56B40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1F558E0", Offset = "0x1F558E0", VA = "0x1F558E0")]
			[DebuggerHidden]
			public <StringifyAsync>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1F55918", Offset = "0x1F55918", VA = "0x1F55918", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1F55B44", Offset = "0x1F55B44", VA = "0x1F55B44", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1F559B4", Offset = "0x1F559B4", VA = "0x1F559B4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1F55A7C", Offset = "0x1F55A7C", VA = "0x1F55A7C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1F56B00", Offset = "0x1F56B00", VA = "0x1F56B00", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x1F56B48", Offset = "0x1F56B48", VA = "0x1F56B48", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1F56C08", Offset = "0x1F56C08", VA = "0x1F56C08", Slot = "5")]
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

		[Token(Token = "0x1700002D")]
		public bool isContainer
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x16019F0", Offset = "0x16019F0", VA = "0x16019F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		public int Count
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1601A04", Offset = "0x1601A04", VA = "0x1601A04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		public float f
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1601A54", Offset = "0x1601A54", VA = "0x1601A54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000030")]
		public static JSONObject nullJO
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x1601A5C", Offset = "0x1601A5C", VA = "0x1601A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public static JSONObject obj
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1601BE8", Offset = "0x1601BE8", VA = "0x1601BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public static JSONObject arr
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1601C44", Offset = "0x1601C44", VA = "0x1601C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public bool IsNumber
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1603740", Offset = "0x1603740", VA = "0x1603740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		public bool IsNull
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1603750", Offset = "0x1603750", VA = "0x1603750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool IsString
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1603760", Offset = "0x1603760", VA = "0x1603760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public bool IsBool
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x1603770", Offset = "0x1603770", VA = "0x1603770")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public bool IsArray
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1603780", Offset = "0x1603780", VA = "0x1603780")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public bool IsObject
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1603790", Offset = "0x1603790", VA = "0x1603790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public JSONObject Item
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x16056FC", Offset = "0x16056FC", VA = "0x16056FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x1605788", Offset = "0x1605788", VA = "0x1605788")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public JSONObject Item
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x160463C", Offset = "0x160463C", VA = "0x160463C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x16061A8", Offset = "0x16061A8", VA = "0x16061A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1601CA0", Offset = "0x1601CA0", VA = "0x1601CA0")]
		public JSONObject(Type t)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1601DA8", Offset = "0x1601DA8", VA = "0x1601DA8")]
		public JSONObject(bool b)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1601DE0", Offset = "0x1601DE0", VA = "0x1601DE0")]
		public JSONObject(float f)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1601E1C", Offset = "0x1601E1C", VA = "0x1601E1C")]
		public JSONObject(int i)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1601E64", Offset = "0x1601E64", VA = "0x1601E64")]
		public JSONObject(long l)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1601EA8", Offset = "0x1601EA8", VA = "0x1601EA8")]
		public JSONObject(Dictionary<string, string> dic)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x160219C", Offset = "0x160219C", VA = "0x160219C")]
		public JSONObject(Dictionary<string, JSONObject> dic)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x16023C8", Offset = "0x16023C8", VA = "0x16023C8")]
		public JSONObject(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1602404", Offset = "0x1602404", VA = "0x1602404")]
		public JSONObject(JSONObject[] objs)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1602498", Offset = "0x1602498", VA = "0x1602498")]
		public static JSONObject StringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x16024F8", Offset = "0x16024F8", VA = "0x16024F8")]
		public void Absorb(JSONObject obj)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x16025BC", Offset = "0x16025BC", VA = "0x16025BC")]
		public static JSONObject Create()
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1601AB8", Offset = "0x1601AB8", VA = "0x1601AB8")]
		public static JSONObject Create(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x160261C", Offset = "0x160261C", VA = "0x160261C")]
		public static JSONObject Create(bool val)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1602694", Offset = "0x1602694", VA = "0x1602694")]
		public static JSONObject Create(float val)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1602710", Offset = "0x1602710", VA = "0x1602710")]
		public static JSONObject Create(int val)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1602798", Offset = "0x1602798", VA = "0x1602798")]
		public static JSONObject Create(uint val)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1602824", Offset = "0x1602824", VA = "0x1602824")]
		public static JSONObject Create(long val)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x16028A8", Offset = "0x16028A8", VA = "0x16028A8")]
		public static JSONObject Create(ulong val)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1602128", Offset = "0x1602128", VA = "0x1602128")]
		public static JSONObject CreateStringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1602930", Offset = "0x1602930", VA = "0x1602930")]
		public static JSONObject CreateBakedObject(string val)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x16029A4", Offset = "0x16029A4", VA = "0x16029A4")]
		public static JSONObject Create(string val, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1603300", Offset = "0x1603300", VA = "0x1603300")]
		public static JSONObject Create(AddJSONContents content)
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1603380", Offset = "0x1603380", VA = "0x1603380")]
		public static JSONObject Create(Dictionary<string, string> dic)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1602614", Offset = "0x1602614", VA = "0x1602614")]
		public JSONObject()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1603618", Offset = "0x1603618", VA = "0x1603618")]
		public JSONObject(string str)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1603654", Offset = "0x1603654", VA = "0x1603654")]
		public JSONObject(string str, int maxDepth)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x160369C", Offset = "0x160369C", VA = "0x160369C")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x16036E8", Offset = "0x16036E8", VA = "0x16036E8")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels, bool strict)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1602A44", Offset = "0x1602A44", VA = "0x1602A44")]
		private void Parse(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x16037AC", Offset = "0x16037AC", VA = "0x16037AC")]
		public void Add(bool val)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1603934", Offset = "0x1603934", VA = "0x1603934")]
		public void Add(float val)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x16039AC", Offset = "0x16039AC", VA = "0x16039AC")]
		public void Add(int val)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1603A24", Offset = "0x1603A24", VA = "0x1603A24")]
		public void Add(uint val)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1603A9C", Offset = "0x1603A9C", VA = "0x1603A9C")]
		public void Add(long val)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1603B14", Offset = "0x1603B14", VA = "0x1603B14")]
		public void Add(ulong val)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1603B8C", Offset = "0x1603B8C", VA = "0x1603B8C")]
		public void Add(string str)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1603C04", Offset = "0x1603C04", VA = "0x1603C04")]
		public void Add(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1603824", Offset = "0x1603824", VA = "0x1603824")]
		public void Add(JSONObject obj)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1603C88", Offset = "0x1603C88", VA = "0x1603C88")]
		public void AddField(string name, bool val)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1603F20", Offset = "0x1603F20", VA = "0x1603F20")]
		public void AddField(string name, float val)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1603FA8", Offset = "0x1603FA8", VA = "0x1603FA8")]
		public void AddField(string name, int val)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1604028", Offset = "0x1604028", VA = "0x1604028")]
		public void AddField(string name, uint val)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x16040A8", Offset = "0x16040A8", VA = "0x16040A8")]
		public void AddField(string name, long val)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1604128", Offset = "0x1604128", VA = "0x1604128")]
		public void AddField(string name, ulong val)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x16041A8", Offset = "0x16041A8", VA = "0x16041A8")]
		public void AddField(string name, AddJSONContents content)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1604228", Offset = "0x1604228", VA = "0x1604228")]
		public void AddField(string name, string val)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1603D08", Offset = "0x1603D08", VA = "0x1603D08")]
		public void AddField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x16042A8", Offset = "0x16042A8", VA = "0x16042A8")]
		public void SetField(string name, string val)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x16043E8", Offset = "0x16043E8", VA = "0x16043E8")]
		public void SetField(string name, bool val)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1604468", Offset = "0x1604468", VA = "0x1604468")]
		public void SetField(string name, float val)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x16044F0", Offset = "0x16044F0", VA = "0x16044F0")]
		public void SetField(string name, int val)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1604328", Offset = "0x1604328", VA = "0x1604328")]
		public void SetField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1604640", Offset = "0x1604640", VA = "0x1604640")]
		public void RemoveField(string name)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1604720", Offset = "0x1604720", VA = "0x1604720")]
		public bool GetField(out bool field, string name, bool fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1604730", Offset = "0x1604730", VA = "0x1604730")]
		public bool GetField(ref bool field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1604738", Offset = "0x1604738", VA = "0x1604738")]
		public bool GetField(ref bool field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1604824", Offset = "0x1604824", VA = "0x1604824")]
		public bool GetField(out float field, string name, float fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1604830", Offset = "0x1604830", VA = "0x1604830")]
		public bool GetField(ref float field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1604838", Offset = "0x1604838", VA = "0x1604838")]
		public bool GetField(ref float field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1604924", Offset = "0x1604924", VA = "0x1604924")]
		public bool GetField(out int field, string name, int fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1604930", Offset = "0x1604930", VA = "0x1604930")]
		public bool GetField(ref int field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1604938", Offset = "0x1604938", VA = "0x1604938")]
		public bool GetField(ref int field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1604A70", Offset = "0x1604A70", VA = "0x1604A70")]
		public bool GetField(out long field, string name, long fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1604A7C", Offset = "0x1604A7C", VA = "0x1604A7C")]
		public bool GetField(ref long field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1604A84", Offset = "0x1604A84", VA = "0x1604A84")]
		public bool GetField(ref long field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1604BBC", Offset = "0x1604BBC", VA = "0x1604BBC")]
		public bool GetField(out uint field, string name, uint fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1604BC8", Offset = "0x1604BC8", VA = "0x1604BC8")]
		public bool GetField(ref uint field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1604BD0", Offset = "0x1604BD0", VA = "0x1604BD0")]
		public bool GetField(ref uint field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1604D14", Offset = "0x1604D14", VA = "0x1604D14")]
		public bool GetField(out ulong field, string name, ulong fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1604D20", Offset = "0x1604D20", VA = "0x1604D20")]
		public bool GetField(ref ulong field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1604D28", Offset = "0x1604D28", VA = "0x1604D28")]
		public bool GetField(ref ulong field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1604E6C", Offset = "0x1604E6C", VA = "0x1604E6C")]
		public bool GetField(out string field, string name, string fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1604E78", Offset = "0x1604E78", VA = "0x1604E78")]
		public bool GetField(ref string field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1604E80", Offset = "0x1604E80", VA = "0x1604E80")]
		public bool GetField(ref string field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1604F74", Offset = "0x1604F74", VA = "0x1604F74")]
		public void GetField(string name, GetFieldResponse response, [Optional] FieldNotFound fail)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1605080", Offset = "0x1605080", VA = "0x1605080")]
		public JSONObject GetField(string name)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x160517C", Offset = "0x160517C", VA = "0x160517C")]
		public bool HasFields(string[] names)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1604570", Offset = "0x1604570", VA = "0x1604570")]
		public bool HasField(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1605250", Offset = "0x1605250", VA = "0x1605250")]
		public void Clear()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x16052F8", Offset = "0x16052F8", VA = "0x16052F8")]
		public JSONObject Copy()
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1605380", Offset = "0x1605380", VA = "0x1605380")]
		public void Merge(JSONObject obj)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x16053F0", Offset = "0x16053F0", VA = "0x16053F0")]
		private static void MergeRecur(JSONObject left, JSONObject right)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x160581C", Offset = "0x160581C", VA = "0x160581C")]
		public void Bake()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1605858", Offset = "0x1605858", VA = "0x1605858")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF30C", Offset = "0x7FF30C")]
		public IEnumerable BakeAsync()
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1605378", Offset = "0x1605378", VA = "0x1605378")]
		public string Print()
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x16058C4", Offset = "0x16058C4", VA = "0x16058C4")]
		public string Print(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1606090", Offset = "0x1606090", VA = "0x1606090")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF36C", Offset = "0x7FF36C")]
		public IEnumerable<string> PrintAsync(bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1606110", Offset = "0x1606110", VA = "0x1606110")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF3CC", Offset = "0x7FF3CC")]
		private IEnumerable StringifyAsync(int depth, StringBuilder builder, bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1605950", Offset = "0x1605950", VA = "0x1605950")]
		private void Stringify(int depth, StringBuilder builder, bool pretty = false)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x16061AC", Offset = "0x16061AC", VA = "0x16061AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x16061B4", Offset = "0x16061B4", VA = "0x16061B4")]
		public string ToString(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x16061BC", Offset = "0x16061BC", VA = "0x16061BC")]
		public Dictionary<string, string> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1603C7C", Offset = "0x1603C7C", VA = "0x1603C7C")]
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

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x16064A4", Offset = "0x16064A4", VA = "0x16064A4")]
		public static JSONObject TOJSON(object obj)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1607110", Offset = "0x1607110", VA = "0x1607110")]
		public static Vector2 ToVector2(JSONObject obj)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1607238", Offset = "0x1607238", VA = "0x1607238")]
		public static JSONObject FromVector2(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1607310", Offset = "0x1607310", VA = "0x1607310")]
		public static JSONObject FromVector3(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1607424", Offset = "0x1607424", VA = "0x1607424")]
		public static Vector3 ToVector3(JSONObject obj)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x16075B4", Offset = "0x16075B4", VA = "0x16075B4")]
		public static JSONObject FromVector4(Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x16076FC", Offset = "0x16076FC", VA = "0x16076FC")]
		public static Vector4 ToVector4(JSONObject obj)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x160791C", Offset = "0x160791C", VA = "0x160791C")]
		public static JSONObject FromMatrix4x4(Matrix4x4 m)
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1607C88", Offset = "0x1607C88", VA = "0x1607C88")]
		public static Matrix4x4 ToMatrix4x4(JSONObject obj)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x16083AC", Offset = "0x16083AC", VA = "0x16083AC")]
		public static JSONObject FromQuaternion(Quaternion q)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x16084F4", Offset = "0x16084F4", VA = "0x16084F4")]
		public static Quaternion ToQuaternion(JSONObject obj)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1608714", Offset = "0x1608714", VA = "0x1608714")]
		public static JSONObject FromColor(Color c)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x160885C", Offset = "0x160885C", VA = "0x160885C")]
		public static Color ToColor(JSONObject obj)
		{
			return default(Color);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1608A64", Offset = "0x1608A64", VA = "0x1608A64")]
		public static JSONObject FromLayerMask(LayerMask l)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1608B04", Offset = "0x1608B04", VA = "0x1608B04")]
		public static LayerMask ToLayerMask(JSONObject obj)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1608B84", Offset = "0x1608B84", VA = "0x1608B84")]
		public static JSONObject FromRect(Rect r)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1608D0C", Offset = "0x1608D0C", VA = "0x1608D0C")]
		public static Rect ToRect(JSONObject obj)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1608F28", Offset = "0x1608F28", VA = "0x1608F28")]
		public static JSONObject FromRectOffset(RectOffset r)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x16090A8", Offset = "0x16090A8", VA = "0x16090A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC368", Offset = "0x7FC368")]
		private sealed class <>c
		{
			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__21_0;

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x18BC908", Offset = "0x18BC908", VA = "0x18BC908")]
			public <>c()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x18BC910", Offset = "0x18BC910", VA = "0x18BC910")]
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

		[Token(Token = "0x1700003B")]
		public List<BadWordProvider> BadWordProviderLTR
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x151E18C", Offset = "0x151E18C", VA = "0x151E18C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x151E194", Offset = "0x151E194", VA = "0x151E194")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x151E570", Offset = "0x151E570", VA = "0x151E570")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x151E578", Offset = "0x151E578", VA = "0x151E578")]
			set
			{
			}
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x151E954", Offset = "0x151E954", VA = "0x151E954")]
		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters, bool fuzzy, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x151EA8C", Offset = "0x151EA8C", VA = "0x151EA8C", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x151F21C", Offset = "0x151F21C", VA = "0x151F21C", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1520898", Offset = "0x1520898", VA = "0x1520898", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x15248F4", Offset = "0x15248F4", VA = "0x15248F4", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1528BDC", Offset = "0x1528BDC", VA = "0x1528BDC", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC378", Offset = "0x7FC378")]
		private sealed class <>c
		{
			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x18BD808", Offset = "0x18BD808", VA = "0x18BD808")]
			public <>c()
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x18BD810", Offset = "0x18BD810", VA = "0x18BD810")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC4F8", Offset = "0x7FC4F8")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x1700003D")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x152B138", Offset = "0x152B138", VA = "0x152B138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF42C", Offset = "0x7FF42C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x152B140", Offset = "0x152B140", VA = "0x152B140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF43C", Offset = "0x7FF43C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int CharacterNumber
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x152B148", Offset = "0x152B148", VA = "0x152B148")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x152B150", Offset = "0x152B150", VA = "0x152B150")]
			set
			{
			}
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x152B218", Offset = "0x152B218", VA = "0x152B218")]
		public CapitalizationFilter(int capitalizationCharsNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x152B260", Offset = "0x152B260", VA = "0x152B260", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x152B268", Offset = "0x152B268", VA = "0x152B268", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x152B2D4", Offset = "0x152B2D4", VA = "0x152B2D4", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x152BA38", Offset = "0x152BA38", VA = "0x152BA38", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x152C060", Offset = "0x152C060", VA = "0x152C060", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC388", Offset = "0x7FC388")]
		private sealed class <>c
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__13_0;

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x1F53EB0", Offset = "0x1F53EB0", VA = "0x1F53EB0")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x1F53EB8", Offset = "0x1F53EB8", VA = "0x1F53EB8")]
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

		[Token(Token = "0x1700003F")]
		public List<DomainProvider> DomainProvider
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x15F7138", Offset = "0x15F7138", VA = "0x15F7138")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x15F7140", Offset = "0x15F7140", VA = "0x15F7140")]
			set
			{
			}
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x15F74A4", Offset = "0x15F74A4", VA = "0x15F74A4")]
		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x15F7634", Offset = "0x15F7634", VA = "0x15F7634", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x15F7A9C", Offset = "0x15F7A9C", VA = "0x15F7A9C", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x15F87FC", Offset = "0x15F87FC", VA = "0x15F87FC", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x15FAAB8", Offset = "0x15FAAB8", VA = "0x15FAAB8", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x15FCF90", Offset = "0x15FCF90", VA = "0x15FCF90", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC398", Offset = "0x7FC398")]
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

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x1F54DAC", Offset = "0x1F54DAC", VA = "0x1F54DAC")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x1F54DB4", Offset = "0x1F54DB4", VA = "0x1F54DB4")]
			internal string <Sources>b__8_0(KeyValuePair<string, Source> x)
			{
				return null;
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1F54DF4", Offset = "0x1F54DF4", VA = "0x1F54DF4")]
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

		[Token(Token = "0x60003D1")]
		public abstract bool Ready();

		[Token(Token = "0x60003D2")]
		public abstract bool Contains(string testString, params string[] sources);

		[Token(Token = "0x60003D3")]
		public abstract List<string> GetAll(string testString, params string[] sources);

		[Token(Token = "0x60003D4")]
		public abstract string ReplaceAll(string testString, params string[] sources);

		[Token(Token = "0x60003D5")]
		public abstract string Replace(string text, List<string> badWords);

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x15FF6C8", Offset = "0x15FF6C8", VA = "0x15FF6C8", Slot = "9")]
		public virtual List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x15FF940", Offset = "0x15FF940", VA = "0x15FF940", Slot = "10")]
		public virtual string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x15FFB50", Offset = "0x15FFB50", VA = "0x15FFB50", Slot = "11")]
		public virtual string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x15F8788", Offset = "0x15F8788", VA = "0x15F8788")]
		protected void logFilterNotReady()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x15F8784", Offset = "0x15F8784", VA = "0x15F8784")]
		protected void logResourceNotFound(string res)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x15F8780", Offset = "0x15F8780", VA = "0x15F8780")]
		protected void logContains()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x15FAAB4", Offset = "0x15FAAB4", VA = "0x15FAAB4")]
		protected void logGetAll()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x15FCDF4", Offset = "0x15FCDF4", VA = "0x15FCDF4")]
		protected void logReplaceAll()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x15F7584", Offset = "0x15F7584", VA = "0x15F7584")]
		protected Filter()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class PunctuationFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC3A8", Offset = "0x7FC3A8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x1F58FD4", Offset = "0x1F58FD4", VA = "0x1F58FD4")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1F58FDC", Offset = "0x1F58FDC", VA = "0x1F58FDC")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC508", Offset = "0x7FC508")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000040")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x18AFB30", Offset = "0x18AFB30", VA = "0x18AFB30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF44C", Offset = "0x7FF44C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x18AFB38", Offset = "0x18AFB38", VA = "0x18AFB38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF45C", Offset = "0x7FF45C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int CharacterNumber
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x18AFB40", Offset = "0x18AFB40", VA = "0x18AFB40")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x18AFB48", Offset = "0x18AFB48", VA = "0x18AFB48")]
			set
			{
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x18AFC10", Offset = "0x18AFC10", VA = "0x18AFC10")]
		public PunctuationFilter(int punctuationCharacterNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x18AFC58", Offset = "0x18AFC58", VA = "0x18AFC58", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x18AFC60", Offset = "0x18AFC60", VA = "0x18AFC60", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x18AFCCC", Offset = "0x18AFCCC", VA = "0x18AFCCC", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x18B0430", Offset = "0x18B0430", VA = "0x18B0430", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x18B0A50", Offset = "0x18B0A50", VA = "0x18B0A50", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class BadWordManager : Manager
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC3B8", Offset = "0x7FC3B8")]
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

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007BD")]
				[Address(RVA = "0x18BCB6C", Offset = "0x18BCB6C", VA = "0x18BCB6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x18BCBB4", Offset = "0x18BCBB4", VA = "0x18BCBB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x18BC918", Offset = "0x18BC918", VA = "0x18BC918")]
			[DebuggerHidden]
			public <initalize>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x18BC944", Offset = "0x18BC944", VA = "0x18BC944", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x18BC948", Offset = "0x18BC948", VA = "0x18BC948", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x18BCB74", Offset = "0x18BCB74", VA = "0x18BCB74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC518", Offset = "0x7FC518")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC518", Offset = "0x7FC518")]
		public List<BadWordProvider> BadWordProviderLTR;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC578", Offset = "0x7FC578")]
		public List<BadWordProvider> BadWordProviderRTL;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC5B0", Offset = "0x7FC5B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC5B0", Offset = "0x7FC5B0")]
		public string ReplaceChars;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC610", Offset = "0x7FC610")]
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

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1528ED0", Offset = "0x1528ED0", VA = "0x1528ED0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x15290A8", Offset = "0x15290A8", VA = "0x15290A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF46C", Offset = "0x7FF46C")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1529114", Offset = "0x1529114", VA = "0x1529114")]
		public static BadWordFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1529178", Offset = "0x1529178", VA = "0x1529178")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x15294A0", Offset = "0x15294A0", VA = "0x15294A0")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x15295C0", Offset = "0x15295C0", VA = "0x15295C0")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x15296C0", Offset = "0x15296C0", VA = "0x15296C0")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x15297FC", Offset = "0x15297FC", VA = "0x15297FC")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x15298FC", Offset = "0x15298FC", VA = "0x15298FC")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x15299FC", Offset = "0x15299FC", VA = "0x15299FC")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1529B18", Offset = "0x1529B18", VA = "0x1529B18")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x152925C", Offset = "0x152925C", VA = "0x152925C")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1529C20", Offset = "0x1529C20", VA = "0x1529C20")]
		public BadWordManager()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class CapitalizationManager : Manager
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC648", Offset = "0x7FC648")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC648", Offset = "0x7FC648")]
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

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x152C304", Offset = "0x152C304", VA = "0x152C304")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x152C5EC", Offset = "0x152C5EC", VA = "0x152C5EC")]
		public static CapitalizationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x152C650", Offset = "0x152C650", VA = "0x152C650")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x152C6C4", Offset = "0x152C6C4", VA = "0x152C6C4")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x152CA28", Offset = "0x152CA28", VA = "0x152CA28")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x152CB28", Offset = "0x152CB28", VA = "0x152CB28")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x152CC64", Offset = "0x152CC64", VA = "0x152CC64")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x152CD64", Offset = "0x152CD64", VA = "0x152CD64")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x152CE64", Offset = "0x152CE64", VA = "0x152CE64")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x152CF80", Offset = "0x152CF80", VA = "0x152CF80")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x152C7E4", Offset = "0x152C7E4", VA = "0x152C7E4")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x152D088", Offset = "0x152D088", VA = "0x152D088")]
		public CapitalizationManager()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class DomainManager : Manager
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC3C8", Offset = "0x7FC3C8")]
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

			[Token(Token = "0x17000088")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C3")]
				[Address(RVA = "0x1F540FC", Offset = "0x1F540FC", VA = "0x1F540FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0x1F54144", Offset = "0x1F54144", VA = "0x1F54144", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1F53EC0", Offset = "0x1F53EC0", VA = "0x1F53EC0")]
			[DebuggerHidden]
			public <initalize>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1F53EEC", Offset = "0x1F53EEC", VA = "0x1F53EEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1F53EF0", Offset = "0x1F53EF0", VA = "0x1F53EF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1F54104", Offset = "0x1F54104", VA = "0x1F54104", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC6A8", Offset = "0x7FC6A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC6A8", Offset = "0x7FC6A8")]
		public List<DomainProvider> DomainProvider;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC708", Offset = "0x7FC708")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC708", Offset = "0x7FC708")]
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

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x15FD280", Offset = "0x15FD280", VA = "0x15FD280")]
		private void Start()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x15FD458", Offset = "0x15FD458", VA = "0x15FD458")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF4CC", Offset = "0x7FF4CC")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x15FD4C4", Offset = "0x15FD4C4", VA = "0x15FD4C4")]
		public static DomainFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x15FD528", Offset = "0x15FD528", VA = "0x15FD528")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x15FD850", Offset = "0x15FD850", VA = "0x15FD850")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x15FD970", Offset = "0x15FD970", VA = "0x15FD970")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x15FDA70", Offset = "0x15FDA70", VA = "0x15FDA70")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x15FDBAC", Offset = "0x15FDBAC", VA = "0x15FDBAC")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x15FDCAC", Offset = "0x15FDCAC", VA = "0x15FDCAC")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x15FDDAC", Offset = "0x15FDDAC", VA = "0x15FDDAC")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x15FDEC8", Offset = "0x15FDEC8", VA = "0x15FDEC8")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x15FD60C", Offset = "0x15FD60C", VA = "0x15FD60C")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x15FDFD0", Offset = "0x15FDFD0", VA = "0x15FDFD0")]
		public DomainManager()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public abstract class Manager : MonoBehaviour
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC768", Offset = "0x7FC768")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC768", Offset = "0x7FC768")]
		public string MarkPrefix;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC7C8", Offset = "0x7FC7C8")]
		public string MarkPostfix;

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x19267D0", Offset = "0x19267D0", VA = "0x19267D0")]
		protected Manager()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class PunctuationManager : Manager
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC800", Offset = "0x7FC800")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC800", Offset = "0x7FC800")]
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

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x18B0D04", Offset = "0x18B0D04", VA = "0x18B0D04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x18B0FEC", Offset = "0x18B0FEC", VA = "0x18B0FEC")]
		public static PunctuationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x18B1050", Offset = "0x18B1050", VA = "0x18B1050")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x18B10C4", Offset = "0x18B10C4", VA = "0x18B10C4")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x18B1428", Offset = "0x18B1428", VA = "0x18B1428")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x18B1528", Offset = "0x18B1528", VA = "0x18B1528")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x18B1664", Offset = "0x18B1664", VA = "0x18B1664")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x18B1764", Offset = "0x18B1764", VA = "0x18B1764")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x18B1864", Offset = "0x18B1864", VA = "0x18B1864")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x18B1980", Offset = "0x18B1980", VA = "0x18B1980")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x18B11E4", Offset = "0x18B11E4", VA = "0x18B11E4")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x18B1A88", Offset = "0x18B1A88", VA = "0x18B1A88")]
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

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x152AF3C", Offset = "0x152AF3C", VA = "0x152AF3C")]
		public BadWords(Source source, List<string> badWordList)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x152AF74", Offset = "0x152AF74", VA = "0x152AF74", Slot = "3")]
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

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x15FF150", Offset = "0x15FF150", VA = "0x15FF150")]
		public Domains(Source source, List<string> domainList)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x15FF188", Offset = "0x15FF188", VA = "0x15FF188", Slot = "3")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC860", Offset = "0x7FC860")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC860", Offset = "0x7FC860")]
		public string Name;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC8C0", Offset = "0x7FC8C0")]
		public string Description;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC8F8", Offset = "0x7FC8F8")]
		public Sprite Icon;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x18B3F88", Offset = "0x18B3F88", VA = "0x18B3F88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x18B415C", Offset = "0x18B415C", VA = "0x18B415C")]
		protected Source()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public static class MultiManager
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC3D8", Offset = "0x7FC3D8")]
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

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1F58F4C", Offset = "0x1F58F4C", VA = "0x1F58F4C")]
			public <>c()
			{
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1F58F54", Offset = "0x1F58F54", VA = "0x1F58F54")]
			internal string <Sources>b__2_0(Source x)
			{
				return null;
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1F58F6C", Offset = "0x1F58F6C", VA = "0x1F58F6C")]
			internal string <GetAll>b__4_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1928444", Offset = "0x1928444", VA = "0x1928444")]
		public static Filter Filter(ManagerMask mask = ManagerMask.BadWord)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1928648", Offset = "0x1928648", VA = "0x1928648")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x192875C", Offset = "0x192875C", VA = "0x192875C")]
		public static List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1928A48", Offset = "0x1928A48", VA = "0x1928A48")]
		public static bool Contains(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1928CEC", Offset = "0x1928CEC", VA = "0x1928CEC")]
		public static List<string> GetAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x192902C", Offset = "0x192902C", VA = "0x192902C")]
		public static string ReplaceAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x19291C8", Offset = "0x19291C8", VA = "0x19291C8")]
		public static string Replace(string text, List<string> badWords, ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1929364", Offset = "0x1929364", VA = "0x1929364")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1929414", Offset = "0x1929414", VA = "0x1929414")]
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

		[Token(Token = "0x17000042")]
		public Dictionary<string, Regex> ExactBadwordsRegex
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x1529C78", Offset = "0x1529C78", VA = "0x1529C78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1529C80", Offset = "0x1529C80", VA = "0x1529C80")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public Dictionary<string, Regex> FuzzyBadwordsRegex
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x1529C88", Offset = "0x1529C88", VA = "0x1529C88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x1529C90", Offset = "0x1529C90", VA = "0x1529C90")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1529C98", Offset = "0x1529C98", VA = "0x1529C98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x1529CA0", Offset = "0x1529CA0", VA = "0x1529CA0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public Dictionary<string, List<Regex>> DebugFuzzyBadwordsRegex
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x1529CA8", Offset = "0x1529CA8", VA = "0x1529CA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1529CB0", Offset = "0x1529CB0", VA = "0x1529CB0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1529CB8", Offset = "0x1529CB8", VA = "0x1529CB8", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x152A8A4", Offset = "0x152A8A4", VA = "0x152A8A4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FC930", Offset = "0x7FC930")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC930", Offset = "0x7FC930")]
		public string File;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC990", Offset = "0x7FC990")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FC9C8", Offset = "0x7FC9C8")]
		public int SkipFooterLines;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCA00", Offset = "0x7FCA00")]
		public char SplitChar;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x151E128", Offset = "0x151E128", VA = "0x151E128")]
		public BadWordFile()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class BadWordProviderFile : BadWordProvider
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC3E8", Offset = "0x7FC3E8")]
		private sealed class <loadFile>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0x18BCC20", Offset = "0x18BCC20", VA = "0x18BCC20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x18BCC68", Offset = "0x18BCC68", VA = "0x18BCC68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x18BCBBC", Offset = "0x18BCBBC", VA = "0x18BCBBC")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x18BCBE8", Offset = "0x18BCBE8", VA = "0x18BCBE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x18BCBEC", Offset = "0x18BCBEC", VA = "0x18BCBEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x18BCC28", Offset = "0x18BCC28", VA = "0x18BCC28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FCA38", Offset = "0x7FCA38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCA38", Offset = "0x7FCA38")]
		public string FilePathWindows;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCA98", Offset = "0x7FCA98")]
		public string FilePathOSX;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCAD0", Offset = "0x7FCAD0")]
		public string FilePathLinux;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCB08", Offset = "0x7FCB08")]
		public BadWordFile[] Resources;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x152AA00", Offset = "0x152AA00", VA = "0x152AA00", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x152AB14", Offset = "0x152AB14", VA = "0x152AB14", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x152AB88", Offset = "0x152AB88", VA = "0x152AB88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF52C", Offset = "0x7FF52C")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x152ABE4", Offset = "0x152ABE4", VA = "0x152ABE4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FCB40", Offset = "0x7FCB40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCB40", Offset = "0x7FCB40")]
		public TextAsset Resource;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCBA0", Offset = "0x7FCBA0")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCBD8", Offset = "0x7FCBD8")]
		public int SkipFooterLines;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCC10", Offset = "0x7FCC10")]
		public char SplitChar;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x152AEC8", Offset = "0x152AEC8", VA = "0x152AEC8")]
		public BadWordResource()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class BadWordProviderResource : BadWordProvider
	{
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC3F8", Offset = "0x7FC3F8")]
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

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x18BD000", Offset = "0x18BD000", VA = "0x18BD000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x18BD048", Offset = "0x18BD048", VA = "0x18BD048", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x18BCC70", Offset = "0x18BCC70", VA = "0x18BCC70")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x18BCC9C", Offset = "0x18BCC9C", VA = "0x18BCC9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x18BCCA0", Offset = "0x18BCCA0", VA = "0x18BCCA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x18BD008", Offset = "0x18BD008", VA = "0x18BD008", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FCC48", Offset = "0x7FCC48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCC48", Offset = "0x7FCC48")]
		public BadWordResource[] Resources;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x152AC54", Offset = "0x152AC54", VA = "0x152AC54", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x152ACEC", Offset = "0x152ACEC", VA = "0x152ACEC", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x152AC80", Offset = "0x152AC80", VA = "0x152AC80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF58C", Offset = "0x7FF58C")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x152AD60", Offset = "0x152AD60", VA = "0x152AD60")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FCCA8", Offset = "0x7FCCA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCCA8", Offset = "0x7FCCA8")]
		public string URL;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCD08", Offset = "0x7FCD08")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCD40", Offset = "0x7FCD40")]
		public int SkipFooterLines;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCD78", Offset = "0x7FCD78")]
		public char SplitChar;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x152AED8", Offset = "0x152AED8", VA = "0x152AED8")]
		public BadWordWeb()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class BadWordProviderWeb : BadWordProvider
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC408", Offset = "0x7FC408")]
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

			[Token(Token = "0x1700008E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D9")]
				[Address(RVA = "0x18BD758", Offset = "0x18BD758", VA = "0x18BD758", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x18BD7A0", Offset = "0x18BD7A0", VA = "0x18BD7A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x18BD050", Offset = "0x18BD050", VA = "0x18BD050")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x18BD07C", Offset = "0x18BD07C", VA = "0x18BD07C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x18BD080", Offset = "0x18BD080", VA = "0x18BD080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x18BD760", Offset = "0x18BD760", VA = "0x18BD760", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FCDB0", Offset = "0x7FCDB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCDB0", Offset = "0x7FCDB0")]
		public string MainURL;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCE10", Offset = "0x7FCE10")]
		public BadWordWeb[] Resources;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x152AD64", Offset = "0x152AD64", VA = "0x152AD64", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x152ADFC", Offset = "0x152ADFC", VA = "0x152ADFC", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x152AD90", Offset = "0x152AD90", VA = "0x152AD90")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF5EC", Offset = "0x7FF5EC")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x152AE70", Offset = "0x152AE70", VA = "0x152AE70")]
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

		[Token(Token = "0x17000046")]
		public Dictionary<string, Regex> DomainsRegex
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x15FE028", Offset = "0x15FE028", VA = "0x15FE028")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x15FE030", Offset = "0x15FE030", VA = "0x15FE030")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x15FE038", Offset = "0x15FE038", VA = "0x15FE038")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x15FE040", Offset = "0x15FE040", VA = "0x15FE040")]
			protected set
			{
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x15FE048", Offset = "0x15FE048", VA = "0x15FE048", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x15FEA44", Offset = "0x15FEA44", VA = "0x15FEA44")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FCE48", Offset = "0x7FCE48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCE48", Offset = "0x7FCE48")]
		public string File;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCEA8", Offset = "0x7FCEA8")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCEE0", Offset = "0x7FCEE0")]
		public int SkipFooterLines;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCF18", Offset = "0x7FCF18")]
		public char SplitChar;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x15F70D4", Offset = "0x15F70D4", VA = "0x15F70D4")]
		public DomainFile()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class DomainProviderFile : DomainProvider
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC418", Offset = "0x7FC418")]
		private sealed class <loadFile>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x1F541B0", Offset = "0x1F541B0", VA = "0x1F541B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x1F541F8", Offset = "0x1F541F8", VA = "0x1F541F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1F5414C", Offset = "0x1F5414C", VA = "0x1F5414C")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1F54178", Offset = "0x1F54178", VA = "0x1F54178", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1F5417C", Offset = "0x1F5417C", VA = "0x1F5417C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1F541B8", Offset = "0x1F541B8", VA = "0x1F541B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FCF50", Offset = "0x7FCF50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCF50", Offset = "0x7FCF50")]
		public string FilePathWindows;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCFB0", Offset = "0x7FCFB0")]
		public string FilePathOSX;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FCFE8", Offset = "0x7FCFE8")]
		public string FilePathLinux;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD020", Offset = "0x7FD020")]
		public DomainFile[] Resources;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x15FEB68", Offset = "0x15FEB68", VA = "0x15FEB68", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x15FED28", Offset = "0x15FED28", VA = "0x15FED28", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x15FED9C", Offset = "0x15FED9C", VA = "0x15FED9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF64C", Offset = "0x7FF64C")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x15FEDF8", Offset = "0x15FEDF8", VA = "0x15FEDF8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FD058", Offset = "0x7FD058")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD058", Offset = "0x7FD058")]
		public TextAsset Resource;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD0B8", Offset = "0x7FD0B8")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD0F0", Offset = "0x7FD0F0")]
		public int SkipFooterLines;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD128", Offset = "0x7FD128")]
		public char SplitChar;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x15FF0DC", Offset = "0x15FF0DC", VA = "0x15FF0DC")]
		public DomainResource()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class DomainProviderResource : DomainProvider
	{
		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC428", Offset = "0x7FC428")]
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

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x1F54594", Offset = "0x1F54594", VA = "0x1F54594", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E7")]
				[Address(RVA = "0x1F545DC", Offset = "0x1F545DC", VA = "0x1F545DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1F54200", Offset = "0x1F54200", VA = "0x1F54200")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1F5422C", Offset = "0x1F5422C", VA = "0x1F5422C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1F54230", Offset = "0x1F54230", VA = "0x1F54230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1F5459C", Offset = "0x1F5459C", VA = "0x1F5459C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FD160", Offset = "0x7FD160")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD160", Offset = "0x7FD160")]
		public DomainResource[] Resources;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x15FEE68", Offset = "0x15FEE68", VA = "0x15FEE68", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x15FEF00", Offset = "0x15FEF00", VA = "0x15FEF00", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x15FEE94", Offset = "0x15FEE94", VA = "0x15FEE94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF6AC", Offset = "0x7FF6AC")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x15FEF74", Offset = "0x15FEF74", VA = "0x15FEF74")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FD1C0", Offset = "0x7FD1C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD1C0", Offset = "0x7FD1C0")]
		public string URL;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD220", Offset = "0x7FD220")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD258", Offset = "0x7FD258")]
		public int SkipFooterLines;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD290", Offset = "0x7FD290")]
		public char SplitChar;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x15FF0EC", Offset = "0x15FF0EC", VA = "0x15FF0EC")]
		public DomainWeb()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class DomainProviderWeb : DomainProvider
	{
		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC438", Offset = "0x7FC438")]
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

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x1F54CFC", Offset = "0x1F54CFC", VA = "0x1F54CFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x1F54D44", Offset = "0x1F54D44", VA = "0x1F54D44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1F545E4", Offset = "0x1F545E4", VA = "0x1F545E4")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1F54610", Offset = "0x1F54610", VA = "0x1F54610", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x1F54614", Offset = "0x1F54614", VA = "0x1F54614", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x1F54D04", Offset = "0x1F54D04", VA = "0x1F54D04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FD2C8", Offset = "0x7FD2C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD2C8", Offset = "0x7FD2C8")]
		public string MainURL;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD328", Offset = "0x7FD328")]
		public DomainWeb[] Resources;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x15FEF78", Offset = "0x15FEF78", VA = "0x15FEF78", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x15FF010", Offset = "0x15FF010", VA = "0x15FF010", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x15FEFA4", Offset = "0x15FEFA4", VA = "0x15FEFA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF70C", Offset = "0x7FF70C")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x15FF084", Offset = "0x15FF084", VA = "0x15FF084")]
		public DomainProviderWeb()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class Provider : MonoBehaviour
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD360", Offset = "0x7FD360")]
		public string Name;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FD398", Offset = "0x7FD398")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD398", Offset = "0x7FD398")]
		public RegexOptions RegexOption1;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD3F8", Offset = "0x7FD3F8")]
		public RegexOptions RegexOption2;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD430", Offset = "0x7FD430")]
		public RegexOptions RegexOption3;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD468", Offset = "0x7FD468")]
		public RegexOptions RegexOption4;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD4A0", Offset = "0x7FD4A0")]
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

		[Token(Token = "0x17000048")]
		public bool Ready
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x18AF868", Offset = "0x18AF868", VA = "0x18AF868")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x18AF870", Offset = "0x18AF870", VA = "0x18AF870")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public List<Source> Sources
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x18AF87C", Offset = "0x18AF87C", VA = "0x18AF87C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x18AF884", Offset = "0x18AF884", VA = "0x18AF884")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000461")]
		public abstract void Load();

		[Token(Token = "0x6000462")]
		public abstract void Save();

		[Token(Token = "0x6000463")]
		protected abstract void init();

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x18AF88C", Offset = "0x18AF88C", VA = "0x18AF88C")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x18AF898", Offset = "0x18AF898", VA = "0x18AF898")]
		protected void logNoResourcesAdded()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x18AFA84", Offset = "0x18AFA84", VA = "0x18AFA84")]
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

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x15FFC7C", Offset = "0x15FFC7C", VA = "0x15FFC7C")]
		public static bool WindowsPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x15FFCB4", Offset = "0x15FFCB4", VA = "0x15FFCB4")]
		public static bool OSXPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x15FFCE4", Offset = "0x15FFCE4", VA = "0x15FFCE4")]
		public static bool LinuxPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x15FEC78", Offset = "0x15FEC78", VA = "0x15FEC78")]
		public static bool SupportedPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x15FFD04", Offset = "0x15FFD04", VA = "0x15FFD04")]
		public static string ValidatePath(string path)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x15FFDA8", Offset = "0x15FFDA8", VA = "0x15FFDA8")]
		public static List<string> SplitStringToLines(string text, int skipHeaderLines = 0, int skipFooterLines = 0, char splitChar = '#')
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x15FCDF8", Offset = "0x15FCDF8", VA = "0x15FCDF8")]
		public static string CreateReplaceString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		public static void AddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1600060", Offset = "0x1600060", VA = "0x1600060")]
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

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x18BC30C", Offset = "0x18BC30C", VA = "0x18BC30C")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return default(uint);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x18BC6CC", Offset = "0x18BC6CC", VA = "0x18BC6CC")]
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

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x19294B4", Offset = "0x19294B4", VA = "0x19294B4")]
		private ObscuredBool(int value)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x192953C", Offset = "0x192953C", VA = "0x192953C")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x19295A4", Offset = "0x19295A4", VA = "0x19295A4")]
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1929608", Offset = "0x1929608", VA = "0x1929608")]
		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x192969C", Offset = "0x192969C", VA = "0x192969C")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1929700", Offset = "0x1929700", VA = "0x1929700")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x192978C", Offset = "0x192978C", VA = "0x192978C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1929974", Offset = "0x1929974", VA = "0x1929974")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1929A0C", Offset = "0x1929A0C", VA = "0x1929A0C")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1929A30", Offset = "0x1929A30", VA = "0x1929A30")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1929858", Offset = "0x1929858", VA = "0x1929858")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1929AD8", Offset = "0x1929AD8", VA = "0x1929AD8")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1929B80", Offset = "0x1929B80", VA = "0x1929B80")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1929BAC", Offset = "0x1929BAC", VA = "0x1929BAC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1929C38", Offset = "0x1929C38", VA = "0x1929C38", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1929CE8", Offset = "0x1929CE8", VA = "0x1929CE8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1929D18", Offset = "0x1929D18", VA = "0x1929D18", Slot = "3")]
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

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1929D98", Offset = "0x1929D98", VA = "0x1929D98")]
		private ObscuredByte(byte value)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1929E1C", Offset = "0x1929E1C", VA = "0x1929E1C")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1929E84", Offset = "0x1929E84", VA = "0x1929E84")]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1929EE8", Offset = "0x1929EE8", VA = "0x1929EE8")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1929F68", Offset = "0x1929F68", VA = "0x1929F68")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x192A16C", Offset = "0x192A16C", VA = "0x192A16C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x192A204", Offset = "0x192A204", VA = "0x192A204")]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x192A228", Offset = "0x192A228", VA = "0x192A228")]
		public void SetEncrypted(byte encrypted)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x192A034", Offset = "0x192A034", VA = "0x192A034")]
		private byte InternalDecrypt()
		{
			return default(byte);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x192A264", Offset = "0x192A264", VA = "0x192A264")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x192A2F0", Offset = "0x192A2F0", VA = "0x192A2F0")]
		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x192A314", Offset = "0x192A314", VA = "0x192A314")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x192A3AC", Offset = "0x192A3AC", VA = "0x192A3AC")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x192A444", Offset = "0x192A444", VA = "0x192A444", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x192A4CC", Offset = "0x192A4CC", VA = "0x192A4CC", Slot = "4")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x192A578", Offset = "0x192A578", VA = "0x192A578", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x192A5A4", Offset = "0x192A5A4", VA = "0x192A5A4")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x192A5D8", Offset = "0x192A5D8", VA = "0x192A5D8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x192A604", Offset = "0x192A604", VA = "0x192A604")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x192A638", Offset = "0x192A638", VA = "0x192A638", Slot = "5")]
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

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x192A6CC", Offset = "0x192A6CC", VA = "0x192A6CC")]
		private ObscuredChar(char value)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x192A754", Offset = "0x192A754", VA = "0x192A754")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x192A7BC", Offset = "0x192A7BC", VA = "0x192A7BC")]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x192A820", Offset = "0x192A820", VA = "0x192A820")]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x192A8A0", Offset = "0x192A8A0", VA = "0x192A8A0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x192AAA8", Offset = "0x192AAA8", VA = "0x192AAA8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x192AB40", Offset = "0x192AB40", VA = "0x192AB40")]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x192AB64", Offset = "0x192AB64", VA = "0x192AB64")]
		public void SetEncrypted(char encrypted)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x192A96C", Offset = "0x192A96C", VA = "0x192A96C")]
		private char InternalDecrypt()
		{
			return default(char);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x192ABA0", Offset = "0x192ABA0", VA = "0x192ABA0")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x192AC2C", Offset = "0x192AC2C", VA = "0x192AC2C")]
		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x192AC50", Offset = "0x192AC50", VA = "0x192AC50")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x192ACE8", Offset = "0x192ACE8", VA = "0x192ACE8")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x192AD80", Offset = "0x192AD80", VA = "0x192AD80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x192AE08", Offset = "0x192AE08", VA = "0x192AE08", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x192AEB0", Offset = "0x192AEB0", VA = "0x192AEB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x192AEDC", Offset = "0x192AEDC", VA = "0x192AEDC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x192AF10", Offset = "0x192AF10", VA = "0x192AF10", Slot = "2")]
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

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x192BB78", Offset = "0x192BB78", VA = "0x192BB78")]
		private ObscuredDecimal(byte[] value)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x192BBFC", Offset = "0x192BBFC", VA = "0x192BBFC")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x192BC64", Offset = "0x192BC64", VA = "0x192BC64")]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x192BCE0", Offset = "0x192BCE0", VA = "0x192BCE0")]
		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x192BCEC", Offset = "0x192BCEC", VA = "0x192BCEC")]
		private static byte[] InternalEncrypt(decimal value)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x192BD60", Offset = "0x192BD60", VA = "0x192BD60")]
		private static byte[] InternalEncrypt(decimal value, long key)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x192BF10", Offset = "0x192BF10", VA = "0x192BF10")]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x192BF8C", Offset = "0x192BF8C", VA = "0x192BF8C")]
		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x192BF98", Offset = "0x192BF98", VA = "0x192BF98")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x192C2F4", Offset = "0x192C2F4", VA = "0x192C2F4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x192C394", Offset = "0x192C394", VA = "0x192C394")]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x192C48C", Offset = "0x192C48C", VA = "0x192C48C")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x192C068", Offset = "0x192C068", VA = "0x192C068")]
		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x192C618", Offset = "0x192C618", VA = "0x192C618")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x192C6D4", Offset = "0x192C6D4", VA = "0x192C6D4")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x192C6D8", Offset = "0x192C6D8", VA = "0x192C6D8")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x192C810", Offset = "0x192C810", VA = "0x192C810")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x192C914", Offset = "0x192C914", VA = "0x192C914")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x192CA18", Offset = "0x192CA18", VA = "0x192CA18", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x192CA44", Offset = "0x192CA44", VA = "0x192CA44")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x192CA80", Offset = "0x192CA80", VA = "0x192CA80")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x192CABC", Offset = "0x192CABC", VA = "0x192CABC", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x192CB00", Offset = "0x192CB00", VA = "0x192CB00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x192CB9C", Offset = "0x192CB9C", VA = "0x192CB9C", Slot = "4")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x192CBF4", Offset = "0x192CBF4", VA = "0x192CBF4", Slot = "2")]
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

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x192CC74", Offset = "0x192CC74", VA = "0x192CC74")]
		private ObscuredDouble(byte[] value)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x192CCF8", Offset = "0x192CCF8", VA = "0x192CCF8")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x192CD60", Offset = "0x192CD60", VA = "0x192CD60")]
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x192CDD8", Offset = "0x192CDD8", VA = "0x192CDD8")]
		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x192CDE4", Offset = "0x192CDE4", VA = "0x192CDE4")]
		private static byte[] InternalEncrypt(double value)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x192CE50", Offset = "0x192CE50", VA = "0x192CE50")]
		private static byte[] InternalEncrypt(double value, long key)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x192CF80", Offset = "0x192CF80", VA = "0x192CF80")]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x192CFF0", Offset = "0x192CFF0", VA = "0x192CFF0")]
		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x192CFFC", Offset = "0x192CFFC", VA = "0x192CFFC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x192D2A0", Offset = "0x192D2A0", VA = "0x192D2A0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x192D338", Offset = "0x192D338", VA = "0x192D338")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x192D3EC", Offset = "0x192D3EC", VA = "0x192D3EC")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x192D0CC", Offset = "0x192D0CC", VA = "0x192D0CC")]
		private double InternalDecrypt()
		{
			return default(double);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x192D4F8", Offset = "0x192D4F8", VA = "0x192D4F8")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x192D598", Offset = "0x192D598", VA = "0x192D598")]
		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x192D59C", Offset = "0x192D59C", VA = "0x192D59C")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x192D644", Offset = "0x192D644", VA = "0x192D644")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x192D6EC", Offset = "0x192D6EC", VA = "0x192D6EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x192D718", Offset = "0x192D718", VA = "0x192D718")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x192D74C", Offset = "0x192D74C", VA = "0x192D74C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x192D780", Offset = "0x192D780", VA = "0x192D780", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x192D7C4", Offset = "0x192D7C4", VA = "0x192D7C4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x192D858", Offset = "0x192D858", VA = "0x192D858", Slot = "4")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x192D898", Offset = "0x192D898", VA = "0x192D898", Slot = "2")]
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

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x192D918", Offset = "0x192D918", VA = "0x192D918")]
		private ObscuredFloat(byte[] value)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x192D9A0", Offset = "0x192D9A0", VA = "0x192D9A0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x192DA08", Offset = "0x192DA08", VA = "0x192DA08")]
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x192DA80", Offset = "0x192DA80", VA = "0x192DA80")]
		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x192DA8C", Offset = "0x192DA8C", VA = "0x192DA8C")]
		private static byte[] InternalEncrypt(float value)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x192DAF8", Offset = "0x192DAF8", VA = "0x192DAF8")]
		private static byte[] InternalEncrypt(float value, int key)
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x192DBE8", Offset = "0x192DBE8", VA = "0x192DBE8")]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x192DC58", Offset = "0x192DC58", VA = "0x192DC58")]
		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x192DC64", Offset = "0x192DC64", VA = "0x192DC64")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x192DEC8", Offset = "0x192DEC8", VA = "0x192DEC8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x192DF60", Offset = "0x192DF60", VA = "0x192DF60")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x192DFD4", Offset = "0x192DFD4", VA = "0x192DFD4")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x192DD34", Offset = "0x192DD34", VA = "0x192DD34")]
		private float InternalDecrypt()
		{
			return default(float);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x192E0A0", Offset = "0x192E0A0", VA = "0x192E0A0")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x192C80C", Offset = "0x192C80C", VA = "0x192C80C")]
		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x192E148", Offset = "0x192E148", VA = "0x192E148")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x192E1F8", Offset = "0x192E1F8", VA = "0x192E1F8")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x192E2A8", Offset = "0x192E2A8", VA = "0x192E2A8")]
		public float getValue()
		{
			return default(float);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x192E2AC", Offset = "0x192E2AC", VA = "0x192E2AC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x192E348", Offset = "0x192E348", VA = "0x192E348", Slot = "4")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x192E390", Offset = "0x192E390", VA = "0x192E390", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x192E3BC", Offset = "0x192E3BC", VA = "0x192E3BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x192E3E8", Offset = "0x192E3E8", VA = "0x192E3E8")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x192E41C", Offset = "0x192E41C", VA = "0x192E41C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x192E450", Offset = "0x192E450", VA = "0x192E450", Slot = "5")]
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

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x192E4E8", Offset = "0x192E4E8", VA = "0x192E4E8")]
		private ObscuredInt(int value)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x192E56C", Offset = "0x192E56C", VA = "0x192E56C")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x192E5D4", Offset = "0x192E5D4", VA = "0x192E5D4")]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x192E638", Offset = "0x192E638", VA = "0x192E638")]
		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x192E6B4", Offset = "0x192E6B4", VA = "0x192E6B4")]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x192E718", Offset = "0x192E718", VA = "0x192E718")]
		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x192E794", Offset = "0x192E794", VA = "0x192E794")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x192E994", Offset = "0x192E994", VA = "0x192E994")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x192EA30", Offset = "0x192EA30", VA = "0x192EA30")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x192EA54", Offset = "0x192EA54", VA = "0x192EA54")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x192E860", Offset = "0x192E860", VA = "0x192E860")]
		private int InternalDecrypt()
		{
			return default(int);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x192EA90", Offset = "0x192EA90", VA = "0x192EA90")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x192EB1C", Offset = "0x192EB1C", VA = "0x192EB1C")]
		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x192EB40", Offset = "0x192EB40", VA = "0x192EB40")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x192EC44", Offset = "0x192EC44", VA = "0x192EC44")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x192ECDC", Offset = "0x192ECDC", VA = "0x192ECDC")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x192ED74", Offset = "0x192ED74", VA = "0x192ED74")]
		public int getValue()
		{
			return default(int);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x192ED78", Offset = "0x192ED78", VA = "0x192ED78", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x192EE00", Offset = "0x192EE00", VA = "0x192EE00", Slot = "4")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x192EEA8", Offset = "0x192EEA8", VA = "0x192EEA8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x192EED4", Offset = "0x192EED4", VA = "0x192EED4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x192EF00", Offset = "0x192EF00", VA = "0x192EF00")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x192EF34", Offset = "0x192EF34", VA = "0x192EF34")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x192EF68", Offset = "0x192EF68", VA = "0x192EF68", Slot = "5")]
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

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x192F000", Offset = "0x192F000", VA = "0x192F000")]
		private ObscuredLong(long value)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x192F084", Offset = "0x192F084", VA = "0x192F084")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x192F0EC", Offset = "0x192F0EC", VA = "0x192F0EC")]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x192F1CC", Offset = "0x192F1CC", VA = "0x192F1CC")]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x192F150", Offset = "0x192F150", VA = "0x192F150")]
		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x192F230", Offset = "0x192F230", VA = "0x192F230")]
		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x192F2AC", Offset = "0x192F2AC", VA = "0x192F2AC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x192F4AC", Offset = "0x192F4AC", VA = "0x192F4AC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x192F544", Offset = "0x192F544", VA = "0x192F544")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x192F568", Offset = "0x192F568", VA = "0x192F568")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x192F378", Offset = "0x192F378", VA = "0x192F378")]
		private long InternalDecrypt()
		{
			return default(long);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x192F5A4", Offset = "0x192F5A4", VA = "0x192F5A4")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x192F644", Offset = "0x192F644", VA = "0x192F644")]
		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x192F648", Offset = "0x192F648", VA = "0x192F648")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x192F6E8", Offset = "0x192F6E8", VA = "0x192F6E8")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x192F788", Offset = "0x192F788", VA = "0x192F788", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x192F81C", Offset = "0x192F81C", VA = "0x192F81C", Slot = "4")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x192F8C4", Offset = "0x192F8C4", VA = "0x192F8C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x192F8F0", Offset = "0x192F8F0", VA = "0x192F8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x192F91C", Offset = "0x192F91C", VA = "0x192F91C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x192F950", Offset = "0x192F950", VA = "0x192F950")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x192F984", Offset = "0x192F984", VA = "0x192F984", Slot = "5")]
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

		[Token(Token = "0x1700004A")]
		public static string DeviceId
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x1932E1C", Offset = "0x1932E1C", VA = "0x1932E1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1932F44", Offset = "0x1932F44", VA = "0x1932F44")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8003DC", Offset = "0x8003DC")]
		internal static string DeviceID
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1933080", Offset = "0x1933080", VA = "0x1933080")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1933140", Offset = "0x1933140", VA = "0x1933140")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x19331C0", Offset = "0x19331C0", VA = "0x19331C0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700004D")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x1938138", Offset = "0x1938138", VA = "0x1938138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x193327C", Offset = "0x193327C", VA = "0x193327C")]
		public static void ForceLockToDeviceInit()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1933380", Offset = "0x1933380", VA = "0x1933380")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1932670", Offset = "0x1932670", VA = "0x1932670")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x19335C0", Offset = "0x19335C0", VA = "0x19335C0")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1932814", Offset = "0x1932814", VA = "0x1932814")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x193350C", Offset = "0x193350C", VA = "0x193350C")]
		private static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1933728", Offset = "0x1933728", VA = "0x1933728")]
		private static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x193450C", Offset = "0x193450C", VA = "0x193450C")]
		public static void SetUInt(string key, uint value)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x193464C", Offset = "0x193464C", VA = "0x193464C")]
		public static uint GetUInt(string key)
		{
			return default(uint);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x19346B0", Offset = "0x19346B0", VA = "0x19346B0")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1934598", Offset = "0x1934598", VA = "0x1934598")]
		private static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x193478C", Offset = "0x193478C", VA = "0x193478C")]
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1932788", Offset = "0x1932788", VA = "0x1932788")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1934A34", Offset = "0x1934A34", VA = "0x1934A34")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1932B28", Offset = "0x1932B28", VA = "0x1932B28")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1934900", Offset = "0x1934900", VA = "0x1934900")]
		public static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1934AAC", Offset = "0x1934AAC", VA = "0x1934AAC")]
		public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x19326FC", Offset = "0x19326FC", VA = "0x19326FC")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1934D3C", Offset = "0x1934D3C", VA = "0x1934D3C")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x193299C", Offset = "0x193299C", VA = "0x193299C")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1934C88", Offset = "0x1934C88", VA = "0x1934C88")]
		private static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1934DA0", Offset = "0x1934DA0", VA = "0x1934DA0")]
		private static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1934F1C", Offset = "0x1934F1C", VA = "0x1934F1C")]
		public static void SetDouble(string key, double value)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x193505C", Offset = "0x193505C", VA = "0x193505C")]
		public static double GetDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x19350C0", Offset = "0x19350C0", VA = "0x19350C0")]
		public static double GetDouble(string key, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1934FA8", Offset = "0x1934FA8", VA = "0x1934FA8")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x19351A8", Offset = "0x19351A8", VA = "0x19351A8")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1935350", Offset = "0x1935350", VA = "0x1935350")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1935490", Offset = "0x1935490", VA = "0x1935490")]
		public static long GetLong(string key)
		{
			return default(long);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x19354F4", Offset = "0x19354F4", VA = "0x19354F4")]
		public static long GetLong(string key, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x19353DC", Offset = "0x19353DC", VA = "0x19353DC")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x19355D0", Offset = "0x19355D0", VA = "0x19355D0")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1935744", Offset = "0x1935744", VA = "0x1935744")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1935884", Offset = "0x1935884", VA = "0x1935884")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x19358E8", Offset = "0x19358E8", VA = "0x19358E8")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x19357D0", Offset = "0x19357D0", VA = "0x19357D0")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x19359C4", Offset = "0x19359C4", VA = "0x19359C4")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1935B44", Offset = "0x1935B44", VA = "0x1935B44")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1935C44", Offset = "0x1935C44", VA = "0x1935C44")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1935CAC", Offset = "0x1935CAC", VA = "0x1935CAC")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1935BD0", Offset = "0x1935BD0", VA = "0x1935BD0")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1935E58", Offset = "0x1935E58", VA = "0x1935E58")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1935DB8", Offset = "0x1935DB8", VA = "0x1935DB8")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1935FD0", Offset = "0x1935FD0", VA = "0x1935FD0")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1936178", Offset = "0x1936178", VA = "0x1936178")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x19361F8", Offset = "0x19361F8", VA = "0x19361F8")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1936064", Offset = "0x1936064", VA = "0x1936064")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x19362E4", Offset = "0x19362E4", VA = "0x19362E4")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1936528", Offset = "0x1936528", VA = "0x1936528")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1936710", Offset = "0x1936710", VA = "0x1936710")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x19367A0", Offset = "0x19367A0", VA = "0x19367A0")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x19365CC", Offset = "0x19365CC", VA = "0x19365CC")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x19368A4", Offset = "0x19368A4", VA = "0x19368A4")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1936B34", Offset = "0x1936B34", VA = "0x1936B34")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1936D4C", Offset = "0x1936D4C", VA = "0x1936D4C")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1936DE4", Offset = "0x1936DE4", VA = "0x1936DE4")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1936BE0", Offset = "0x1936BE0", VA = "0x1936BE0")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1936EF8", Offset = "0x1936EF8", VA = "0x1936EF8")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x19371E0", Offset = "0x19371E0", VA = "0x19371E0")]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x193732C", Offset = "0x193732C", VA = "0x193732C")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x19373C0", Offset = "0x19373C0", VA = "0x19373C0")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1937278", Offset = "0x1937278", VA = "0x1937278")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x19374C4", Offset = "0x19374C4", VA = "0x19374C4")]
		public static void SetRect(string key, Rect value)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x19376FC", Offset = "0x19376FC", VA = "0x19376FC")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1937790", Offset = "0x1937790", VA = "0x1937790")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1937570", Offset = "0x1937570", VA = "0x1937570")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x19378A4", Offset = "0x19378A4", VA = "0x19378A4")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1937BBC", Offset = "0x1937BBC", VA = "0x1937BBC")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1937C34", Offset = "0x1937C34", VA = "0x1937C34")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1937C9C", Offset = "0x1937C9C", VA = "0x1937C9C")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1932CB0", Offset = "0x1932CB0", VA = "0x1932CB0")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1937D24", Offset = "0x1937D24", VA = "0x1937D24")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1937D2C", Offset = "0x1937D2C", VA = "0x1937D2C")]
		public static void Save()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1933624", Offset = "0x1933624", VA = "0x1933624")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1933404", Offset = "0x1933404", VA = "0x1933404")]
		private static string EncryptKey(string key)
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x193389C", Offset = "0x193389C", VA = "0x193389C")]
		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1934064", Offset = "0x1934064", VA = "0x1934064")]
		private static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1932FC4", Offset = "0x1932FC4", VA = "0x1932FC4")]
		private static uint CalculateChecksum(string input)
		{
			return default(uint);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1937FB4", Offset = "0x1937FB4", VA = "0x1937FB4")]
		private static void SavesTampered()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x193805C", Offset = "0x193805C", VA = "0x193805C")]
		private static void PossibleForeignSavesDetected()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1932EDC", Offset = "0x1932EDC", VA = "0x1932EDC")]
		private static string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1937EB8", Offset = "0x1937EB8", VA = "0x1937EB8")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1933B84", Offset = "0x1933B84", VA = "0x1933B84")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x19381FC", Offset = "0x19381FC", VA = "0x19381FC")]
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

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x19383E4", Offset = "0x19383E4", VA = "0x19383E4")]
		private ObscuredQuaternion(RawEncryptedQuaternion value)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1938480", Offset = "0x1938480", VA = "0x1938480")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x19384E8", Offset = "0x19384E8", VA = "0x19384E8")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1938574", Offset = "0x1938574", VA = "0x1938574")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1938654", Offset = "0x1938654", VA = "0x1938654")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x19386C8", Offset = "0x19386C8", VA = "0x19386C8")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1938798", Offset = "0x1938798", VA = "0x1938798")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1938A84", Offset = "0x1938A84", VA = "0x1938A84")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1938B40", Offset = "0x1938B40", VA = "0x1938B40")]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1938B68", Offset = "0x1938B68", VA = "0x1938B68")]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x193888C", Offset = "0x193888C", VA = "0x193888C")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1938BAC", Offset = "0x1938BAC", VA = "0x1938BAC")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1938D08", Offset = "0x1938D08", VA = "0x1938D08")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1938DEC", Offset = "0x1938DEC", VA = "0x1938DEC")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1938DF0", Offset = "0x1938DF0", VA = "0x1938DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1938E20", Offset = "0x1938E20", VA = "0x1938E20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1938E50", Offset = "0x1938E50", VA = "0x1938E50")]
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

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1938EFC", Offset = "0x1938EFC", VA = "0x1938EFC")]
		private ObscuredSByte(sbyte value)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1938F80", Offset = "0x1938F80", VA = "0x1938F80")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1938FE8", Offset = "0x1938FE8", VA = "0x1938FE8")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x193904C", Offset = "0x193904C", VA = "0x193904C")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x19390CC", Offset = "0x19390CC", VA = "0x19390CC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x19392D0", Offset = "0x19392D0", VA = "0x19392D0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1939368", Offset = "0x1939368", VA = "0x1939368")]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x193938C", Offset = "0x193938C", VA = "0x193938C")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1939198", Offset = "0x1939198", VA = "0x1939198")]
		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x19393C8", Offset = "0x19393C8", VA = "0x19393C8")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1939454", Offset = "0x1939454", VA = "0x1939454")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1939478", Offset = "0x1939478", VA = "0x1939478")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1939510", Offset = "0x1939510", VA = "0x1939510")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x19395A8", Offset = "0x19395A8", VA = "0x19395A8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1939630", Offset = "0x1939630", VA = "0x1939630", Slot = "4")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x19396DC", Offset = "0x19396DC", VA = "0x19396DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1939708", Offset = "0x1939708", VA = "0x1939708")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x193973C", Offset = "0x193973C", VA = "0x193973C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1939768", Offset = "0x1939768", VA = "0x1939768")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x193979C", Offset = "0x193979C", VA = "0x193979C", Slot = "5")]
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

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1939830", Offset = "0x1939830", VA = "0x1939830")]
		private ObscuredShort(short value)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x19398B8", Offset = "0x19398B8", VA = "0x19398B8")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1939920", Offset = "0x1939920", VA = "0x1939920")]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1939984", Offset = "0x1939984", VA = "0x1939984")]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1939A04", Offset = "0x1939A04", VA = "0x1939A04")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1939C0C", Offset = "0x1939C0C", VA = "0x1939C0C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1939CA4", Offset = "0x1939CA4", VA = "0x1939CA4")]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1939CC8", Offset = "0x1939CC8", VA = "0x1939CC8")]
		public void SetEncrypted(short encrypted)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1939AD0", Offset = "0x1939AD0", VA = "0x1939AD0")]
		private short InternalDecrypt()
		{
			return default(short);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x19323E0", Offset = "0x19323E0", VA = "0x19323E0")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x193246C", Offset = "0x193246C", VA = "0x193246C")]
		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1939D04", Offset = "0x1939D04", VA = "0x1939D04")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1939D8C", Offset = "0x1939D8C", VA = "0x1939D8C")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1939E14", Offset = "0x1939E14", VA = "0x1939E14", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1939E9C", Offset = "0x1939E9C", VA = "0x1939E9C", Slot = "4")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1939F44", Offset = "0x1939F44", VA = "0x1939F44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1939F70", Offset = "0x1939F70", VA = "0x1939F70")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1939FA4", Offset = "0x1939FA4", VA = "0x1939FA4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1939FD0", Offset = "0x1939FD0", VA = "0x1939FD0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x193A004", Offset = "0x193A004", VA = "0x193A004", Slot = "5")]
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

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x193A098", Offset = "0x193A098", VA = "0x193A098")]
		private ObscuredString()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x193A0A0", Offset = "0x193A0A0", VA = "0x193A0A0")]
		private ObscuredString(byte[] value)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x193A130", Offset = "0x193A130", VA = "0x193A130")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x193A198", Offset = "0x193A198", VA = "0x193A198")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1937D34", Offset = "0x1937D34", VA = "0x1937D34")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x193A210", Offset = "0x193A210", VA = "0x193A210")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x193A4E4", Offset = "0x193A4E4", VA = "0x193A4E4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x193A600", Offset = "0x193A600", VA = "0x193A600")]
		public string GetEncrypted()
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x193A6FC", Offset = "0x193A6FC", VA = "0x193A6FC")]
		public void SetEncrypted(string encrypted)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x193A478", Offset = "0x193A478", VA = "0x193A478")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x193A58C", Offset = "0x193A58C", VA = "0x193A58C")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x193A2D8", Offset = "0x193A2D8", VA = "0x193A2D8")]
		private string InternalDecrypt()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1932490", Offset = "0x1932490", VA = "0x1932490")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x193253C", Offset = "0x193253C", VA = "0x193253C")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x193A8FC", Offset = "0x193A8FC", VA = "0x193A8FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x193A818", Offset = "0x193A818", VA = "0x193A818")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x19325D0", Offset = "0x19325D0", VA = "0x19325D0")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x193A984", Offset = "0x193A984", VA = "0x193A984", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x193AA04", Offset = "0x193AA04", VA = "0x193AA04")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x193AB10", Offset = "0x193AB10", VA = "0x193AB10")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x193ABD8", Offset = "0x193ABD8", VA = "0x193ABD8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x193A78C", Offset = "0x193A78C", VA = "0x193A78C")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x193A66C", Offset = "0x193A66C", VA = "0x193A66C")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x193A900", Offset = "0x193A900", VA = "0x193A900")]
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

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x193AC60", Offset = "0x193AC60", VA = "0x193AC60")]
		private ObscuredUInt(uint value)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x193ACE4", Offset = "0x193ACE4", VA = "0x193ACE4")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x193AD4C", Offset = "0x193AD4C", VA = "0x193AD4C")]
		public static uint Encrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x193AE2C", Offset = "0x193AE2C", VA = "0x193AE2C")]
		public static uint Decrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x193ADB0", Offset = "0x193ADB0", VA = "0x193ADB0")]
		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x193AE90", Offset = "0x193AE90", VA = "0x193AE90")]
		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x193AF0C", Offset = "0x193AF0C", VA = "0x193AF0C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x193B10C", Offset = "0x193B10C", VA = "0x193B10C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x193B1A4", Offset = "0x193B1A4", VA = "0x193B1A4")]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x193B1C8", Offset = "0x193B1C8", VA = "0x193B1C8")]
		public void SetEncrypted(uint encrypted)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x193AFD8", Offset = "0x193AFD8", VA = "0x193AFD8")]
		private uint InternalDecrypt()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x192EBB8", Offset = "0x192EBB8", VA = "0x192EBB8")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x193264C", Offset = "0x193264C", VA = "0x193264C")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x193B204", Offset = "0x193B204", VA = "0x193B204")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x193B27C", Offset = "0x193B27C", VA = "0x193B27C")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x193B314", Offset = "0x193B314", VA = "0x193B314")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x193B3AC", Offset = "0x193B3AC", VA = "0x193B3AC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x193B434", Offset = "0x193B434", VA = "0x193B434", Slot = "4")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x193B4DC", Offset = "0x193B4DC", VA = "0x193B4DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x193B508", Offset = "0x193B508", VA = "0x193B508")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x193B53C", Offset = "0x193B53C", VA = "0x193B53C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x193B568", Offset = "0x193B568", VA = "0x193B568")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x193B59C", Offset = "0x193B59C", VA = "0x193B59C", Slot = "5")]
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

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x193B634", Offset = "0x193B634", VA = "0x193B634")]
		private ObscuredULong(ulong value)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x193B6B8", Offset = "0x193B6B8", VA = "0x193B6B8")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x193B720", Offset = "0x193B720", VA = "0x193B720")]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x193B800", Offset = "0x193B800", VA = "0x193B800")]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x193B784", Offset = "0x193B784", VA = "0x193B784")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x193B864", Offset = "0x193B864", VA = "0x193B864")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x193B8E0", Offset = "0x193B8E0", VA = "0x193B8E0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x193BAE0", Offset = "0x193BAE0", VA = "0x193BAE0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x193BB78", Offset = "0x193BB78", VA = "0x193BB78")]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x193BB9C", Offset = "0x193BB9C", VA = "0x193BB9C")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x193B9AC", Offset = "0x193B9AC", VA = "0x193B9AC")]
		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x193BBD8", Offset = "0x193BBD8", VA = "0x193BBD8")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x193BC78", Offset = "0x193BC78", VA = "0x193BC78")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x193BC7C", Offset = "0x193BC7C", VA = "0x193BC7C")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x193BD1C", Offset = "0x193BD1C", VA = "0x193BD1C")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x193BDBC", Offset = "0x193BDBC", VA = "0x193BDBC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x193BE50", Offset = "0x193BE50", VA = "0x193BE50", Slot = "4")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x193BEF8", Offset = "0x193BEF8", VA = "0x193BEF8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x193BF24", Offset = "0x193BF24", VA = "0x193BF24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x193BF50", Offset = "0x193BF50", VA = "0x193BF50")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x193BF84", Offset = "0x193BF84", VA = "0x193BF84")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x193BFB8", Offset = "0x193BFB8", VA = "0x193BFB8", Slot = "5")]
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

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x18AAF70", Offset = "0x18AAF70", VA = "0x18AAF70")]
		private ObscuredUShort(ushort value)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x18AAFF8", Offset = "0x18AAFF8", VA = "0x18AAFF8")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x18AB060", Offset = "0x18AB060", VA = "0x18AB060")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x18AB0C4", Offset = "0x18AB0C4", VA = "0x18AB0C4")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x18AB144", Offset = "0x18AB144", VA = "0x18AB144")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x18AB350", Offset = "0x18AB350", VA = "0x18AB350")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x18AB3E8", Offset = "0x18AB3E8", VA = "0x18AB3E8")]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x18AB40C", Offset = "0x18AB40C", VA = "0x18AB40C")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x18AB210", Offset = "0x18AB210", VA = "0x18AB210")]
		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x18AB44C", Offset = "0x18AB44C", VA = "0x18AB44C")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x18AB4DC", Offset = "0x18AB4DC", VA = "0x18AB4DC")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x18AB500", Offset = "0x18AB500", VA = "0x18AB500")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x18AB59C", Offset = "0x18AB59C", VA = "0x18AB59C")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x18AB638", Offset = "0x18AB638", VA = "0x18AB638", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x18AB6C0", Offset = "0x18AB6C0", VA = "0x18AB6C0", Slot = "4")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x18AB768", Offset = "0x18AB768", VA = "0x18AB768", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x18AB794", Offset = "0x18AB794", VA = "0x18AB794")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x18AB7C8", Offset = "0x18AB7C8", VA = "0x18AB7C8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x18AB7F4", Offset = "0x18AB7F4", VA = "0x18AB7F4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x18AB828", Offset = "0x18AB828", VA = "0x18AB828", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7FC008", Offset = "0x7FC008")]
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

		[Token(Token = "0x1700004E")]
		public float x
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x18AB950", Offset = "0x18AB950", VA = "0x18AB950")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x18ABB24", Offset = "0x18ABB24", VA = "0x18ABB24")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public float y
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x18ABC10", Offset = "0x18ABC10", VA = "0x18ABC10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x18ABD48", Offset = "0x18ABD48", VA = "0x18ABD48")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float Item
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x18ABD88", Offset = "0x18ABD88", VA = "0x18ABD88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x18ABDF0", Offset = "0x18ABDF0", VA = "0x18ABDF0")]
			set
			{
			}
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x18AB8BC", Offset = "0x18AB8BC", VA = "0x18AB8BC")]
		private ObscuredVector2(RawEncryptedVector2 value)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x18ABE58", Offset = "0x18ABE58", VA = "0x18ABE58")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x18ABEC0", Offset = "0x18ABEC0", VA = "0x18ABEC0")]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x18ABF34", Offset = "0x18ABF34", VA = "0x18ABF34")]
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x18AC00C", Offset = "0x18AC00C", VA = "0x18AC00C")]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x18AC070", Offset = "0x18AC070", VA = "0x18AC070")]
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x18AC14C", Offset = "0x18AC14C", VA = "0x18AC14C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x18AC3F4", Offset = "0x18AC3F4", VA = "0x18AC3F4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x18AC494", Offset = "0x18AC494", VA = "0x18AC494")]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x18AC4B8", Offset = "0x18AC4B8", VA = "0x18AC4B8")]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x18AC224", Offset = "0x18AC224", VA = "0x18AC224")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x18AC4F8", Offset = "0x18AC4F8", VA = "0x18AC4F8")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x18ABA80", Offset = "0x18ABA80", VA = "0x18ABA80")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x18ABB64", Offset = "0x18ABB64", VA = "0x18ABB64")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x18AC5F0", Offset = "0x18AC5F0", VA = "0x18AC5F0")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x18AC6A4", Offset = "0x18AC6A4", VA = "0x18AC6A4")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x18AC6A8", Offset = "0x18AC6A8", VA = "0x18AC6A8")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x18AC6C0", Offset = "0x18AC6C0", VA = "0x18AC6C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x18AC6EC", Offset = "0x18AC6EC", VA = "0x18AC6EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x18AC718", Offset = "0x18AC718", VA = "0x18AC718")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7FC040", Offset = "0x7FC040")]
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

		[Token(Token = "0x17000051")]
		public float x
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x18ACA38", Offset = "0x18ACA38", VA = "0x18ACA38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x18ACC0C", Offset = "0x18ACC0C", VA = "0x18ACC0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public float y
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x18ACCF8", Offset = "0x18ACCF8", VA = "0x18ACCF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x18ACE30", Offset = "0x18ACE30", VA = "0x18ACE30")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float z
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x18ACE70", Offset = "0x18ACE70", VA = "0x18ACE70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x18ACFA8", Offset = "0x18ACFA8", VA = "0x18ACFA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float Item
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x18ACFE8", Offset = "0x18ACFE8", VA = "0x18ACFE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x18AD05C", Offset = "0x18AD05C", VA = "0x18AD05C")]
			set
			{
			}
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x18AC7B4", Offset = "0x18AC7B4", VA = "0x18AC7B4")]
		private ObscuredVector3(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x18AC858", Offset = "0x18AC858", VA = "0x18AC858")]
		public Vector3 getValue()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x18AD0D0", Offset = "0x18AD0D0", VA = "0x18AD0D0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x18AD138", Offset = "0x18AD138", VA = "0x18AD138")]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x18AD1C4", Offset = "0x18AD1C4", VA = "0x18AD1C4")]
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x18AD2C8", Offset = "0x18AD2C8", VA = "0x18AD2C8")]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x18AD33C", Offset = "0x18AD33C", VA = "0x18AD33C")]
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x18AD434", Offset = "0x18AD434", VA = "0x18AD434")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x18AD520", Offset = "0x18AD520", VA = "0x18AD520")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x18AD5D4", Offset = "0x18AD5D4", VA = "0x18AD5D4")]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x18AD5FC", Offset = "0x18AD5FC", VA = "0x18AD5FC")]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x18AC85C", Offset = "0x18AC85C", VA = "0x18AC85C")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x18AD644", Offset = "0x18AD644", VA = "0x18AD644")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x18ACB68", Offset = "0x18ACB68", VA = "0x18ACB68")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x18ACC4C", Offset = "0x18ACC4C", VA = "0x18ACC4C")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x18AD770", Offset = "0x18AD770", VA = "0x18AD770")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x18AD844", Offset = "0x18AD844", VA = "0x18AD844")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x18AD848", Offset = "0x18AD848", VA = "0x18AD848")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x18AD910", Offset = "0x18AD910", VA = "0x18AD910")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x18AD9CC", Offset = "0x18AD9CC", VA = "0x18AD9CC")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x18ADA88", Offset = "0x18ADA88", VA = "0x18ADA88")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x18ADB50", Offset = "0x18ADB50", VA = "0x18ADB50")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x18ADC0C", Offset = "0x18ADC0C", VA = "0x18ADC0C")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x18ADCC8", Offset = "0x18ADCC8", VA = "0x18ADCC8")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x18ADD78", Offset = "0x18ADD78", VA = "0x18ADD78")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x18ADE2C", Offset = "0x18ADE2C", VA = "0x18ADE2C")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x18ADEE0", Offset = "0x18ADEE0", VA = "0x18ADEE0")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x18ADF94", Offset = "0x18ADF94", VA = "0x18ADF94")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x18ADFF4", Offset = "0x18ADFF4", VA = "0x18ADFF4")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x18AE040", Offset = "0x18AE040", VA = "0x18AE040")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x18AE080", Offset = "0x18AE080", VA = "0x18AE080")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x18AE0E0", Offset = "0x18AE0E0", VA = "0x18AE0E0")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x18AE12C", Offset = "0x18AE12C", VA = "0x18AE12C")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x18AE16C", Offset = "0x18AE16C", VA = "0x18AE16C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x18AE1B0", Offset = "0x18AE1B0", VA = "0x18AE1B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x18AE1E0", Offset = "0x18AE1E0", VA = "0x18AE1E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x18AE210", Offset = "0x18AE210", VA = "0x18AE210")]
		public string ToString(string format)
		{
			return null;
		}
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7FC078", Offset = "0x7FC078")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD728", Offset = "0x7FD728")]
		public bool autoStart;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD760", Offset = "0x7FD760")]
		public bool keepAlive;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD798", Offset = "0x7FD798")]
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

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1513F24", Offset = "0x1513F24", VA = "0x1513F24")]
		private void Start()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1514040", Offset = "0x1514040", VA = "0x1514040")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1514068", Offset = "0x1514068", VA = "0x1514068")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1514080", Offset = "0x1514080", VA = "0x1514080")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x151408C", Offset = "0x151408C", VA = "0x151408C", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x15141D0", Offset = "0x15141D0", VA = "0x15141D0", Slot = "5")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1514390", Offset = "0x1514390", VA = "0x1514390", Slot = "6")]
		protected virtual void DisposeInternal()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x15143F4", Offset = "0x15143F4", VA = "0x15143F4", Slot = "7")]
		internal virtual void OnCheatingDetected()
		{
		}

		[Token(Token = "0x6000671")]
		protected abstract void StartDetectionAutomatically();

		[Token(Token = "0x6000672")]
		protected abstract void StopDetectionInternal();

		[Token(Token = "0x6000673")]
		protected abstract void PauseDetector();

		[Token(Token = "0x6000674")]
		protected abstract void ResumeDetector();

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1514458", Offset = "0x1514458", VA = "0x1514458")]
		protected ActDetectorBase()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7FC0B0", Offset = "0x7FC0B0")]
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

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x1F54E34", Offset = "0x1F54E34", VA = "0x1F54E34")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FD7F0", Offset = "0x7FD7F0")]
		private static InjectionDetector <Instance>k__BackingField;

		[Token(Token = "0x17000055")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1600A04", Offset = "0x1600A04", VA = "0x1600A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF77C", Offset = "0x7FF77C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1600A50", Offset = "0x1600A50", VA = "0x1600A50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF78C", Offset = "0x7FF78C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		private static InjectionDetector GetOrCreateInstance
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x1600654", Offset = "0x1600654", VA = "0x1600654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x16002A0", Offset = "0x16002A0", VA = "0x16002A0")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1600628", Offset = "0x1600628", VA = "0x1600628")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1600824", Offset = "0x1600824", VA = "0x1600824")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1600914", Offset = "0x1600914", VA = "0x1600914")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1600AA0", Offset = "0x1600AA0", VA = "0x1600AA0")]
		private InjectionDetector()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1600AA8", Offset = "0x1600AA8", VA = "0x1600AA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1600C1C", Offset = "0x1600C1C", VA = "0x1600C1C", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1600D10", Offset = "0x1600D10", VA = "0x1600D10")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x16003D4", Offset = "0x16003D4", VA = "0x16003D4")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1601400", Offset = "0x1601400", VA = "0x1601400", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1601408", Offset = "0x1601408", VA = "0x1601408", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x16014AC", Offset = "0x16014AC", VA = "0x16014AC", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1601574", Offset = "0x1601574", VA = "0x1601574", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1601628", Offset = "0x1601628", VA = "0x1601628", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x160170C", Offset = "0x160170C", VA = "0x160170C")]
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1601364", Offset = "0x1601364", VA = "0x1601364")]
		private bool FindInjectionInCurrentAssemblies()
		{
			return default(bool);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1601754", Offset = "0x1601754", VA = "0x1601754")]
		private bool AssemblyAllowed(Assembly ass)
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1600E04", Offset = "0x1600E04", VA = "0x1600E04")]
		private void LoadAndParseAllowedAssemblies()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x160185C", Offset = "0x160185C", VA = "0x160185C")]
		private int GetAssemblyHash(Assembly ass)
		{
			return default(int);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1601938", Offset = "0x1601938", VA = "0x1601938")]
		private string PublicKeyTokenToString(byte[] bytes)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7FC0E8", Offset = "0x7FC0E8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD800", Offset = "0x7FD800")]
		public float floatEpsilon;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD838", Offset = "0x7FD838")]
		public float vector2Epsilon;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD870", Offset = "0x7FD870")]
		public float vector3Epsilon;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD8A8", Offset = "0x7FD8A8")]
		public float quaternionEpsilon;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FD8E0", Offset = "0x7FD8E0")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;

		[Token(Token = "0x17000057")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x192B648", Offset = "0x192B648", VA = "0x192B648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF79C", Offset = "0x7FF79C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x192B694", Offset = "0x192B694", VA = "0x192B694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF7AC", Offset = "0x7FF7AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x192B298", Offset = "0x192B298", VA = "0x192B298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		internal static bool IsRunning
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1929A74", Offset = "0x1929A74", VA = "0x1929A74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x192AF8C", Offset = "0x192AF8C", VA = "0x192AF8C")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x192B26C", Offset = "0x192B26C", VA = "0x192B26C")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x192B468", Offset = "0x192B468", VA = "0x192B468")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x192B558", Offset = "0x192B558", VA = "0x192B558")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x192B6E4", Offset = "0x192B6E4", VA = "0x192B6E4")]
		private ObscuredCheatingDetector()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x192B6F8", Offset = "0x192B6F8", VA = "0x192B6F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x192B86C", Offset = "0x192B86C", VA = "0x192B86C", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x192B960", Offset = "0x192B960", VA = "0x192B960")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x192B0C0", Offset = "0x192B0C0", VA = "0x192B0C0")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x192BA54", Offset = "0x192BA54", VA = "0x192BA54", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x192BA5C", Offset = "0x192BA5C", VA = "0x192BA5C", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x192BA64", Offset = "0x192BA64", VA = "0x192BA64", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x192BA80", Offset = "0x192BA80", VA = "0x192BA80", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x192BA94", Offset = "0x192BA94", VA = "0x192BA94", Slot = "6")]
		protected override void DisposeInternal()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7FC120", Offset = "0x7FC120")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD8F0", Offset = "0x7FD8F0")]
		public float interval;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD928", Offset = "0x7FD928")]
		public byte maxFalsePositives;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD960", Offset = "0x7FD960")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FD998", Offset = "0x7FD998")]
		private static SpeedHackDetector <Instance>k__BackingField;

		[Token(Token = "0x1700005A")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x18B49B4", Offset = "0x18B49B4", VA = "0x18B49B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF7BC", Offset = "0x7FF7BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x18B4A00", Offset = "0x18B4A00", VA = "0x18B4A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF7CC", Offset = "0x7FF7CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x18B4528", Offset = "0x18B4528", VA = "0x18B4528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x18B41C4", Offset = "0x18B41C4", VA = "0x18B41C4")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x18B44F8", Offset = "0x18B44F8", VA = "0x18B44F8")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x18B46F8", Offset = "0x18B46F8", VA = "0x18B46F8")]
		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x18B4738", Offset = "0x18B4738", VA = "0x18B4738")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x18B4780", Offset = "0x18B4780", VA = "0x18B4780")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x18B47D4", Offset = "0x18B47D4", VA = "0x18B47D4")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x18B48C4", Offset = "0x18B48C4", VA = "0x18B48C4")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x18B4A50", Offset = "0x18B4A50", VA = "0x18B4A50")]
		private SpeedHackDetector()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x18B4A70", Offset = "0x18B4A70", VA = "0x18B4A70")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x18B4BE4", Offset = "0x18B4BE4", VA = "0x18B4BE4", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x18B4CD8", Offset = "0x18B4CD8", VA = "0x18B4CD8")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x18B4DCC", Offset = "0x18B4DCC", VA = "0x18B4DCC")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x18B4E78", Offset = "0x18B4E78", VA = "0x18B4E78")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x18B4304", Offset = "0x18B4304", VA = "0x18B4304")]
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x18B4FF4", Offset = "0x18B4FF4", VA = "0x18B4FF4", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x18B5008", Offset = "0x18B5008", VA = "0x18B5008", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x18B5010", Offset = "0x18B5010", VA = "0x18B5010", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x18B502C", Offset = "0x18B502C", VA = "0x18B502C", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x18B5040", Offset = "0x18B5040", VA = "0x18B5040", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x18B4DD8", Offset = "0x18B4DD8", VA = "0x18B4DD8")]
		private void ResetStartTicks()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7FC158", Offset = "0x7FC158")]
	public class WallHackDetector : ActDetectorBase
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC448", Offset = "0x7FC448")]
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

			[Token(Token = "0x17000096")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F2")]
				[Address(RVA = "0x1F59944", Offset = "0x1F59944", VA = "0x1F59944", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x1F5998C", Offset = "0x1F5998C", VA = "0x1F5998C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1F59854", Offset = "0x1F59854", VA = "0x1F59854")]
			[DebuggerHidden]
			public <InitDetector>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x1F59880", Offset = "0x1F59880", VA = "0x1F59880", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1F59884", Offset = "0x1F59884", VA = "0x1F59884", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1F5994C", Offset = "0x1F5994C", VA = "0x1F5994C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC458", Offset = "0x7FC458")]
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

			[Token(Token = "0x17000098")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x1F59804", Offset = "0x1F59804", VA = "0x1F59804", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x1F5984C", Offset = "0x1F5984C", VA = "0x1F5984C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x1F593FC", Offset = "0x1F593FC", VA = "0x1F593FC")]
			[DebuggerHidden]
			public <CaptureFrame>d__82(int <>1__state)
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1F59428", Offset = "0x1F59428", VA = "0x1F59428", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x1F5942C", Offset = "0x1F5942C", VA = "0x1F5942C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1F5980C", Offset = "0x1F5980C", VA = "0x1F5980C", Slot = "8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD9A8", Offset = "0x7FD9A8")]
		private bool checkRigidbody;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FD9F4", Offset = "0x7FD9F4")]
		private bool checkController;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDA40", Offset = "0x7FDA40")]
		private bool checkWireframe;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDA8C", Offset = "0x7FDA8C")]
		private bool checkRaycast;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDAD8", Offset = "0x7FDAD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FDAD8", Offset = "0x7FDAD8")]
		public int wireframeDelay;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDB30", Offset = "0x7FDB30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FDB30", Offset = "0x7FDB30")]
		public int raycastDelay;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDB88", Offset = "0x7FDB88")]
		public Vector3 spawnPosition;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7FDBC0", Offset = "0x7FDBC0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FDBF8", Offset = "0x7FDBF8")]
		private static WallHackDetector <Instance>k__BackingField;

		[Token(Token = "0x1700005C")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x18B8BFC", Offset = "0x18B8BFC", VA = "0x18B8BFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x18B8C04", Offset = "0x18B8C04", VA = "0x18B8C04")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool CheckController
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x18B9FF8", Offset = "0x18B9FF8", VA = "0x18B9FF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x18BA000", Offset = "0x18BA000", VA = "0x18BA000")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool CheckWireframe
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x18BA274", Offset = "0x18BA274", VA = "0x18BA274")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x18BA27C", Offset = "0x18BA27C", VA = "0x18BA27C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public bool CheckRaycast
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x18BA408", Offset = "0x18BA408", VA = "0x18BA408")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x18BA410", Offset = "0x18BA410", VA = "0x18BA410")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x18BAD64", Offset = "0x18BAD64", VA = "0x18BAD64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF7DC", Offset = "0x7FF7DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x18BADB0", Offset = "0x18BADB0", VA = "0x18BADB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FF7EC", Offset = "0x7FF7EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x18BA900", Offset = "0x18BA900", VA = "0x18BA900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x18BA588", Offset = "0x18BA588", VA = "0x18BA588")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x18BA8CC", Offset = "0x18BA8CC", VA = "0x18BA8CC")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x18BAAD0", Offset = "0x18BAAD0", VA = "0x18BAAD0")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x18BAB28", Offset = "0x18BAB28", VA = "0x18BAB28")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x18BAB84", Offset = "0x18BAB84", VA = "0x18BAB84")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x18BAC74", Offset = "0x18BAC74", VA = "0x18BAC74")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x18BAE00", Offset = "0x18BAE00", VA = "0x18BAE00")]
		private WallHackDetector()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x18BAEB4", Offset = "0x18BAEB4", VA = "0x18BAEB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x18BB028", Offset = "0x18BB028", VA = "0x18BB028", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x18BB228", Offset = "0x18BB228", VA = "0x18BB228")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x18BB31C", Offset = "0x18BB31C", VA = "0x18BB31C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x18BB458", Offset = "0x18BB458", VA = "0x18BB458")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x18BA6C8", Offset = "0x18BA6C8", VA = "0x18BA6C8")]
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x18BB5E4", Offset = "0x18BB5E4", VA = "0x18BB5E4", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x18BB5F8", Offset = "0x18BB5F8", VA = "0x18BB5F8", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x18BB63C", Offset = "0x18BB63C", VA = "0x18BB63C", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x18BB6B8", Offset = "0x18BB6B8", VA = "0x18BB6B8", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x18BB6F0", Offset = "0x18BB6F0", VA = "0x18BB6F0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x18B8CB4", Offset = "0x18B8CB4", VA = "0x18B8CB4")]
		private void UpdateServiceContainer()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x18BB578", Offset = "0x18BB578", VA = "0x18BB578")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF7FC", Offset = "0x7FF7FC")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x18B9DD4", Offset = "0x18B9DD4", VA = "0x18B9DD4")]
		private void StartRigidModule()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x18BA0B0", Offset = "0x18BA0B0", VA = "0x18BA0B0")]
		private void StartControllerModule()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x18BA32C", Offset = "0x18BA32C", VA = "0x18BA32C")]
		private void StartWireframeModule()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x18BBD48", Offset = "0x18BBD48", VA = "0x18BBD48")]
		private void ShootWireframeModule()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x18BBDB8", Offset = "0x18BBDB8", VA = "0x18BBDB8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7FF85C", Offset = "0x7FF85C")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x18BA4C0", Offset = "0x18BA4C0", VA = "0x18BA4C0")]
		private void StartRaycastModule()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x18BBE24", Offset = "0x18BBE24", VA = "0x18BBE24")]
		private void ShootRaycastModule()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x18B9F48", Offset = "0x18B9F48", VA = "0x18B9F48")]
		private void StopRigidModule()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x18BA1E0", Offset = "0x18BA1E0", VA = "0x18BA1E0")]
		private void StopControllerModule()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x18BA3B8", Offset = "0x18BA3B8", VA = "0x18BA3B8")]
		private void StopWireframeModule()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x18BA538", Offset = "0x18BA538", VA = "0x18BA538")]
		private void StopRaycastModule()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x18BBA00", Offset = "0x18BBA00", VA = "0x18BBA00")]
		private void InitRigidModule()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x18BBC08", Offset = "0x18BBC08", VA = "0x18BBC08")]
		private void InitControllerModule()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x18BB944", Offset = "0x18BB944", VA = "0x18BB944")]
		private void UninitRigidModule()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x18BBB4C", Offset = "0x18BBB4C", VA = "0x18BBB4C")]
		private void UninitControllerModule()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x18BB3FC", Offset = "0x18BB3FC", VA = "0x18BB3FC")]
		private bool Detect()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x18BB7D4", Offset = "0x18BB7D4", VA = "0x18BB7D4")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x18BB850", Offset = "0x18BB850", VA = "0x18BB850")]
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

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x15F6EF0", Offset = "0x15F6EF0", VA = "0x15F6EF0")]
		public Constants()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Examples
{
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7FC190", Offset = "0x7FC190")]
	public class ActRotatorExample : MonoBehaviour
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7FDC08", Offset = "0x7FDC08")]
		public float speed;

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1514470", Offset = "0x1514470", VA = "0x1514470")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x15144C8", Offset = "0x15144C8", VA = "0x15144C8")]
		public ActRotatorExample()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7FC1C8", Offset = "0x7FC1C8")]
	public class ActTesterGui : MonoBehaviour
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC468", Offset = "0x7FC468")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string types;

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x18BC7F8", Offset = "0x18BC7F8", VA = "0x18BC7F8")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x18BC800", Offset = "0x18BC800", VA = "0x18BC800")]
			internal void <GetAllSimpleObscuredTypes>b__1(Type t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FC478", Offset = "0x7FC478")]
		private sealed class <>c
		{
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> <>9__61_0;

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x18BC734", Offset = "0x18BC734", VA = "0x18BC734")]
			public <>c()
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x18BC73C", Offset = "0x18BC73C", VA = "0x18BC73C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FDC24", Offset = "0x7FDC24")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FDC5C", Offset = "0x7FDC5C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7FDC94", Offset = "0x7FDC94")]
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

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x15144D8", Offset = "0x15144D8", VA = "0x15144D8")]
		public void OnSpeedHackDetected()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1514558", Offset = "0x1514558", VA = "0x1514558")]
		public void OnInjectionDetected()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x15145D8", Offset = "0x15145D8", VA = "0x15145D8")]
		public void OnObscuredTypeCheatingDetected()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1514658", Offset = "0x1514658", VA = "0x1514658")]
		public void OnWallHackDetected()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x15146D8", Offset = "0x15146D8", VA = "0x15146D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x15147D8", Offset = "0x15147D8", VA = "0x15147D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1515708", Offset = "0x1515708", VA = "0x1515708")]
		private void RandomizeObscuredVars()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1514858", Offset = "0x1514858", VA = "0x1514858")]
		private void ObscuredStringExample()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1514A3C", Offset = "0x1514A3C", VA = "0x1514A3C")]
		private void ObscuredIntExample()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1514F08", Offset = "0x1514F08", VA = "0x1514F08")]
		private void ObscuredFloatExample()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1515318", Offset = "0x1515318", VA = "0x1515318")]
		private void ObscuredVector3Example()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x15157A0", Offset = "0x15157A0", VA = "0x15157A0")]
		private void SavesAlterationDetected()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x15157AC", Offset = "0x15157AC", VA = "0x15157AC")]
		private void ForeignSavesDetected()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x15157B8", Offset = "0x15157B8", VA = "0x15157B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x151BCDC", Offset = "0x151BCDC", VA = "0x151BCDC")]
		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x151BF80", Offset = "0x151BF80", VA = "0x151BF80")]
		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x151BFC4", Offset = "0x151BFC4", VA = "0x151BFC4")]
		private void LoadRegularPrefs()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x151C144", Offset = "0x151C144", VA = "0x151C144")]
		private void SaveRegularPrefs()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x151C1F8", Offset = "0x151C1F8", VA = "0x151C1F8")]
		private void DeleteRegularPrefs()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x151C288", Offset = "0x151C288", VA = "0x151C288")]
		private void LoadObscuredPrefs()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x151CB40", Offset = "0x151CB40", VA = "0x151CB40")]
		private void SaveObscuredPrefs()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x151CE48", Offset = "0x151CE48", VA = "0x151CE48")]
		private void DeleteObscuredPrefs()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x151D044", Offset = "0x151D044", VA = "0x151D044")]
		private void PlaceUrlButton(string url)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x151D140", Offset = "0x151D140", VA = "0x151D140")]
		private void PlaceUrlButton(string url, int width)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x151D04C", Offset = "0x151D04C", VA = "0x151D04C")]
		private void PlaceUrlButton(string url, string buttonName, int width)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x151D19C", Offset = "0x151D19C", VA = "0x151D19C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x151D1B0", Offset = "0x151D1B0", VA = "0x151D1B0")]
		public ActTesterGui()
		{
		}
	}
	[Token(Token = "0x2000090")]
	internal class HorizontalLayout : IDisposable
	{
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x160026C", Offset = "0x160026C", VA = "0x160026C")]
		public HorizontalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1600298", Offset = "0x1600298", VA = "0x1600298", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000091")]
	internal class VerticalLayout : IDisposable
	{
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x18B8550", Offset = "0x18B8550", VA = "0x18B8550")]
		public VerticalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x18B857C", Offset = "0x18B857C", VA = "0x18B857C")]
		public VerticalLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x18B8664", Offset = "0x18B8664", VA = "0x18B8664", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7FC200", Offset = "0x7FC200")]
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

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x192FA1C", Offset = "0x192FA1C", VA = "0x192FA1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x192FA70", Offset = "0x192FA70", VA = "0x192FA70")]
		private void StartTests()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x192FBD8", Offset = "0x192FBD8", VA = "0x192FBD8")]
		private void TestBool()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x192FEEC", Offset = "0x192FEEC", VA = "0x192FEEC")]
		private void TestByte()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x19301EC", Offset = "0x19301EC", VA = "0x19301EC")]
		private void TestShort()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x19304EC", Offset = "0x19304EC", VA = "0x19304EC")]
		private void TestUShort()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1931468", Offset = "0x1931468", VA = "0x1931468")]
		private void TestDouble()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1931114", Offset = "0x1931114", VA = "0x1931114")]
		private void TestFloat()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x19307E8", Offset = "0x19307E8", VA = "0x19307E8")]
		private void TestInt()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1930DF8", Offset = "0x1930DF8", VA = "0x1930DF8")]
		private void TestLong()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1931790", Offset = "0x1931790", VA = "0x1931790")]
		private void TestString()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1930AF0", Offset = "0x1930AF0", VA = "0x1930AF0")]
		private void TestUInt()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1931B1C", Offset = "0x1931B1C", VA = "0x1931B1C")]
		private void TestVector3()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1931F80", Offset = "0x1931F80", VA = "0x1931F80")]
		private void TestPrefs()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1932D40", Offset = "0x1932D40", VA = "0x1932D40")]
		public ObscuredPerformanceTests()
		{
		}
	}
}
