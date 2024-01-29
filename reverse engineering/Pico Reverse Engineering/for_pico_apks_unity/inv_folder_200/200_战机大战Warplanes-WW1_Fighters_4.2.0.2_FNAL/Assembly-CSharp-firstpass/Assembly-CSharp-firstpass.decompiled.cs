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
		[Address(RVA = "0x20FA0B4", Offset = "0x20FA0B4", VA = "0x20FA0B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x20FA198", Offset = "0x20FA198", VA = "0x20FA198")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x20FA2B0", Offset = "0x20FA2B0", VA = "0x20FA2B0")]
	public static void ResetLastSendTime()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x20FA384", Offset = "0x20FA384", VA = "0x20FA384")]
	public void SetLastStoreTime()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x20FA3F4", Offset = "0x20FA3F4", VA = "0x20FA3F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x20FAE88", Offset = "0x20FAE88", VA = "0x20FAE88")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x20FAFF0", Offset = "0x20FAFF0", VA = "0x20FAFF0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x20FB430", Offset = "0x20FB430", VA = "0x20FB430")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x20FB434", Offset = "0x20FB434", VA = "0x20FB434")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x20FBA74", Offset = "0x20FBA74", VA = "0x20FBA74")]
	public static bool WillOpenCloudStorageScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x20FA704", Offset = "0x20FA704", VA = "0x20FA704")]
	private void StartFirstScreen()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x20FBE44", Offset = "0x20FBE44", VA = "0x20FBE44", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x20FBE48", Offset = "0x20FBE48", VA = "0x20FBE48", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x20FB278", Offset = "0x20FB278", VA = "0x20FB278", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x20FB624", Offset = "0x20FB624", VA = "0x20FB624", Slot = "7")]
	public void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x20FC0F0", Offset = "0x20FC0F0", VA = "0x20FC0F0")]
	public void OnReceivedCloudSave(CloudSave_Screen onScreen, CloudSave_Saves cloudSaves, bool compareAndImport)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x20FC410", Offset = "0x20FC410", VA = "0x20FC410")]
	public void OnSendSaveToCloud(CloudSave_Screen onScreen, CloudSave_Saves localSaves)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x20FB75C", Offset = "0x20FB75C", VA = "0x20FB75C")]
	public void TrySendChangedLocalSave()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x20FCF4C", Offset = "0x20FCF4C", VA = "0x20FCF4C")]
	public void TrySendDeletedSave()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x20FB200", Offset = "0x20FB200", VA = "0x20FB200")]
	protected void ShowConflictMessage()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x20FD0A4", Offset = "0x20FD0A4", VA = "0x20FD0A4")]
	protected void ClearConflictMessage()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x20FD11C", Offset = "0x20FD11C", VA = "0x20FD11C")]
	public bool IsLoggingIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x20FBD3C", Offset = "0x20FBD3C", VA = "0x20FBD3C")]
	protected void ShowScreen(CloudSave_Screen screen)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x20FD188", Offset = "0x20FD188", VA = "0x20FD188")]
	public void On_CloudInfo_Yes()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x20FD190", Offset = "0x20FD190", VA = "0x20FD190")]
	public void On_CloudInfo_No()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x20FD194", Offset = "0x20FD194", VA = "0x20FD194")]
	public void On_CloudInfo_Back()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x20FD270", Offset = "0x20FD270", VA = "0x20FD270")]
	public void On_CloudInfo_CloseToLogin()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x20FBE24", Offset = "0x20FBE24", VA = "0x20FBE24")]
	protected void ShowLoginScreen(bool autoLogin, bool manualFirstLogin)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x20FD278", Offset = "0x20FD278", VA = "0x20FD278")]
	public void On_LoginScreen_Back()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x20FD2F4", Offset = "0x20FD2F4", VA = "0x20FD2F4")]
	public void On_LoginScreen_ShowInfo()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x20FD2FC", Offset = "0x20FD2FC", VA = "0x20FD2FC")]
	public void On_LoginScreen_FailedAutoLogin()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x20FD478", Offset = "0x20FD478", VA = "0x20FD478")]
	public void OnSelectScreen_ShowLogin(bool showRegister)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x20FD5D8", Offset = "0x20FD5D8", VA = "0x20FD5D8")]
	public void On_LoginScreen_LoggedIn()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x20FD6F0", Offset = "0x20FD6F0", VA = "0x20FD6F0")]
	public void On_LoginScreen_ResetPassword()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x20FD724", Offset = "0x20FD724", VA = "0x20FD724")]
	public void On_MenuScreen_Back()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x20FD798", Offset = "0x20FD798", VA = "0x20FD798")]
	public void On_MenuScreen_Settings()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x20FD7A0", Offset = "0x20FD7A0", VA = "0x20FD7A0")]
	public void On_MenuScreen_SetPassword()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x20FD7A8", Offset = "0x20FD7A8", VA = "0x20FD7A8")]
	public void On_MenuScreen_Logout()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x20FD888", Offset = "0x20FD888", VA = "0x20FD888")]
	public void On_ChangePasswordScreen_Back()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x20FD890", Offset = "0x20FD890", VA = "0x20FD890")]
	public void On_ResetPasswordScreen_Back(bool backToSettings)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x20FD8A4", Offset = "0x20FD8A4", VA = "0x20FD8A4")]
	public void ShowMessageScreen(string text, bool warning, CloudSave_Screen backToScreen, Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x20FD978", Offset = "0x20FD978", VA = "0x20FD978")]
	public void On_MessageScreen_Closed(CloudSave_Screen backToScreen, Action<bool> resultCallback, bool result)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x20FDA08", Offset = "0x20FDA08", VA = "0x20FDA08")]
	public void On_SettingsScreen_Back()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x20FDA10", Offset = "0x20FDA10", VA = "0x20FDA10")]
	public void On_SettingsScreen_ChangePassword()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x20FDA18", Offset = "0x20FDA18", VA = "0x20FDA18")]
	public void On_SettingsScreen_ResetPassword()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x20FDA50", Offset = "0x20FDA50", VA = "0x20FDA50")]
	public void On_SettingsScreen_DeleteAccount()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x20FDA58", Offset = "0x20FDA58", VA = "0x20FDA58")]
	public void On_DeleteAccountScreen_Back()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x20FDA60", Offset = "0x20FDA60", VA = "0x20FDA60")]
	public void On_DeleteAccountScreen_Deleted()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x20FDC4C", Offset = "0x20FDC4C", VA = "0x20FDC4C")]
	public void On_SettingsScreen_RedeemCode()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x20FDC54", Offset = "0x20FDC54", VA = "0x20FDC54")]
	public void On_RedeemCodeScreen_Back()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x20FDC5C", Offset = "0x20FDC5C", VA = "0x20FDC5C")]
	public void ShowTermsOfUseScreen(string email, string password, bool newsletter)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x20FDCB4", Offset = "0x20FDCB4", VA = "0x20FDCB4")]
	public void On_TermsOfUseScreen_No()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x20FDCBC", Offset = "0x20FDCBC", VA = "0x20FDCBC")]
	public void On_TermsOfUseScreen_Completed()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x20FDCC4", Offset = "0x20FDCC4", VA = "0x20FDCC4")]
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
	[Address(RVA = "0x20FDD68", Offset = "0x20FDD68", VA = "0x20FDD68")]
	public CloudSave_CoroutineCallback_InfoOnly(CloudSave_CoroutineCallback _baseCallback)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x20FDD94", Offset = "0x20FDD94", VA = "0x20FDD94", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x20FDD98", Offset = "0x20FDD98", VA = "0x20FDD98", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x20FDD9C", Offset = "0x20FDD9C", VA = "0x20FDD9C", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x20FDE70", Offset = "0x20FDE70", VA = "0x20FDE70", Slot = "7")]
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
	[Address(RVA = "0x20FDFCC", Offset = "0x20FDFCC", VA = "0x20FDFCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x20FE124", Offset = "0x20FE124", VA = "0x20FE124", Slot = "4")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x20FE1FC", Offset = "0x20FE1FC", VA = "0x20FE1FC", Slot = "5")]
	public virtual string GetTextsLanguageID()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x20FE28C", Offset = "0x20FE28C", VA = "0x20FE28C", Slot = "6")]
	public virtual string TranslateText(string trl)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x20FE31C", Offset = "0x20FE31C", VA = "0x20FE31C", Slot = "7")]
	public virtual string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x20FE3AC", Offset = "0x20FE3AC", VA = "0x20FE3AC", Slot = "8")]
	public virtual string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x20FE43C", Offset = "0x20FE43C", VA = "0x20FE43C", Slot = "9")]
	public virtual void BackToMainMenuScene()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x20FE4B0", Offset = "0x20FE4B0", VA = "0x20FE4B0", Slot = "10")]
	public virtual uint GetSaveCloudUserId()
	{
		return default(uint);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x20FE52C", Offset = "0x20FE52C", VA = "0x20FE52C", Slot = "11")]
	public virtual CloudSave_Saves ExportGameSaves()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x20FE5CC", Offset = "0x20FE5CC", VA = "0x20FE5CC", Slot = "12")]
	public virtual void ImportGameSave(CloudSave_Saves cloudSaves)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x20FE640", Offset = "0x20FE640", VA = "0x20FE640", Slot = "13")]
	public virtual void DeleteLocalSaveOnRegister()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x20FE6B4", Offset = "0x20FE6B4", VA = "0x20FE6B4", Slot = "14")]
	public virtual string GetSavePreviewLabels()
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x20FE744", Offset = "0x20FE744", VA = "0x20FE744", Slot = "15")]
	public virtual string GetSavePreview(CloudSave_Saves save)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x20FE7D4", Offset = "0x20FE7D4", VA = "0x20FE7D4", Slot = "16")]
	public virtual CompareSaveResult CompareSave(CloudSave_Saves save1, CloudSave_Saves save2)
	{
		return default(CompareSaveResult);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x20FE850", Offset = "0x20FE850", VA = "0x20FE850", Slot = "17")]
	public virtual bool CanSendChangedLocalSaveInCurrentLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x20FE8CC", Offset = "0x20FE8CC", VA = "0x20FE8CC", Slot = "18")]
	public virtual GameObject GetCloudStatusLineObject()
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x20FE948", Offset = "0x20FE948", VA = "0x20FE948", Slot = "19")]
	public virtual bool ShowCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x20FE9C4", Offset = "0x20FE9C4", VA = "0x20FE9C4", Slot = "20")]
	public virtual bool ClearCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x20FEA40", Offset = "0x20FEA40", VA = "0x20FEA40", Slot = "21")]
	public virtual void PlaySound(SoundType sndType)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x20FEAB4", Offset = "0x20FEAB4", VA = "0x20FEAB4", Slot = "22")]
	public virtual void OnShowCloudScreens()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x20FEB28", Offset = "0x20FEB28", VA = "0x20FEB28", Slot = "23")]
	public virtual bool HaveSaveForPromoCode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x20FEBA4", Offset = "0x20FEBA4", VA = "0x20FEBA4", Slot = "24")]
	public virtual string GetPromoCodeSkuName(string sku)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x20FEC34", Offset = "0x20FEC34", VA = "0x20FEC34", Slot = "25")]
	public virtual void OnUsePromoCode(string sku)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x20FECA8", Offset = "0x20FECA8", VA = "0x20FECA8")]
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
	[Address(RVA = "0x20FF940", Offset = "0x20FF940", VA = "0x20FF940")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x20FFA04", Offset = "0x20FFA04", VA = "0x20FFA04", Slot = "8")]
	public virtual void ActivateScreen()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x20FFA08", Offset = "0x20FFA08", VA = "0x20FFA08", Slot = "9")]
	public virtual void DeactivateScreen()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x20FFA0C", Offset = "0x20FFA0C", VA = "0x20FFA0C", Slot = "10")]
	public virtual void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x20FFA10", Offset = "0x20FFA10", VA = "0x20FFA10", Slot = "11")]
	public virtual void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x20FFA14", Offset = "0x20FFA14", VA = "0x20FFA14", Slot = "12")]
	public virtual void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x20FFA54", Offset = "0x20FFA54", VA = "0x20FFA54", Slot = "13")]
	public virtual void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x20FFAF4", Offset = "0x20FFAF4", VA = "0x20FFAF4")]
	public void ClearInfoMessage()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x20FFB50", Offset = "0x20FFB50", VA = "0x20FFB50", Slot = "14")]
	public virtual void SetInfoMessageText(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x20FFBF8", Offset = "0x20FFBF8", VA = "0x20FFBF8")]
	protected string TranslateText(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x20FC6C8", Offset = "0x20FC6C8", VA = "0x20FC6C8")]
	public static string TranslateTextWithErrorParse(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x20FFC74", Offset = "0x20FFC74", VA = "0x20FFC74")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8366FC", Offset = "0x8366FC")]
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
			[Address(RVA = "0x21315D0", Offset = "0x21315D0", VA = "0x21315D0", Slot = "4")]
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
			[Address(RVA = "0x2131618", Offset = "0x2131618", VA = "0x2131618", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2131510", Offset = "0x2131510", VA = "0x2131510")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x213153C", Offset = "0x213153C", VA = "0x213153C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2131540", Offset = "0x2131540", VA = "0x2131540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x21315D8", Offset = "0x21315D8", VA = "0x21315D8", Slot = "8")]
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
	[Address(RVA = "0x2104504", Offset = "0x2104504", VA = "0x2104504")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2107ACC", Offset = "0x2107ACC", VA = "0x2107ACC")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback, bool dontDestroyOnLoad)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2107DBC", Offset = "0x2107DBC", VA = "0x2107DBC", Slot = "4")]
	public virtual CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2107E38", Offset = "0x2107E38", VA = "0x2107E38", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838180", Offset = "0x838180")]
	public virtual IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2107E94", Offset = "0x2107E94", VA = "0x2107E94", Slot = "6")]
	public virtual bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x21045A8", Offset = "0x21045A8", VA = "0x21045A8")]
	public void Destroy()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2107F10", Offset = "0x2107F10", VA = "0x2107F10")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2107F18", Offset = "0x2107F18", VA = "0x2107F18")]
	protected void CallOnStart()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2107FD8", Offset = "0x2107FD8", VA = "0x2107FD8")]
	protected void CallOnEnd()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2108098", Offset = "0x2108098", VA = "0x2108098")]
	protected void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x210816C", Offset = "0x210816C", VA = "0x210816C")]
	protected void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2108254", Offset = "0x2108254", VA = "0x2108254")]
	protected string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x21082C8", Offset = "0x21082C8", VA = "0x21082C8")]
	protected string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x210833C", Offset = "0x210833C", VA = "0x210833C")]
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
	[Address(RVA = "0x2106314", Offset = "0x2106314", VA = "0x2106314")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x21063C8", Offset = "0x21063C8", VA = "0x21063C8")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x21093E4", Offset = "0x21093E4", VA = "0x21093E4")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x21094B0", Offset = "0x21094B0", VA = "0x21094B0")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2109564", Offset = "0x2109564", VA = "0x2109564")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2109630", Offset = "0x2109630", VA = "0x2109630")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x21096E4", Offset = "0x21096E4", VA = "0x21096E4")]
	public static void Save()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x210978C", Offset = "0x210978C", VA = "0x210978C")]
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
	[Address(RVA = "0x21097E4", Offset = "0x21097E4", VA = "0x21097E4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x21099B8", Offset = "0x21099B8", VA = "0x21099B8")]
	public bool IsTranslated()
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x21097E8", Offset = "0x21097E8", VA = "0x21097E8")]
	public void TranslateText()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x21099C0", Offset = "0x21099C0", VA = "0x21099C0")]
	public void TranslateFromStart()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2109A28", Offset = "0x2109A28", VA = "0x2109A28")]
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
	[Address(RVA = "0x20FEEF0", Offset = "0x20FEEF0", VA = "0x20FEEF0")]
	public CloudSave_Save()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x20FEF68", Offset = "0x20FEF68", VA = "0x20FEF68")]
	public CloudSave_Save(string _save)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x20FEFF4", Offset = "0x20FEFF4", VA = "0x20FEFF4")]
	public CloudSave_Save(string _save, List<KeyValuePair<string, string>> _properties)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x20FF1CC", Offset = "0x20FF1CC", VA = "0x20FF1CC")]
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
	[Address(RVA = "0x20FC968", Offset = "0x20FC968", VA = "0x20FC968")]
	public CloudSave_Saves()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x20FF238", Offset = "0x20FF238", VA = "0x20FF238")]
	public CloudSave_Saves(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x20FC7DC", Offset = "0x20FC7DC", VA = "0x20FC7DC")]
	public void Copy(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x20FF2C8", Offset = "0x20FF2C8", VA = "0x20FF2C8")]
	public void AddSave(string name, string save)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x20FF488", Offset = "0x20FF488", VA = "0x20FF488")]
	public void AddSave(string name, string save, List<KeyValuePair<string, string>> properties)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x20FF65C", Offset = "0x20FF65C", VA = "0x20FF65C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x20FCF00", Offset = "0x20FCF00", VA = "0x20FCF00")]
	public int GetSavesCount()
	{
		return default(int);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x20FC9E0", Offset = "0x20FC9E0", VA = "0x20FC9E0")]
	public string GetSaveName(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x20FF6B0", Offset = "0x20FF6B0", VA = "0x20FF6B0")]
	public string GetSave(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x20FCC1C", Offset = "0x20FCC1C", VA = "0x20FCC1C")]
	public List<KeyValuePair<string, string>> GetSaveProperties(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x20FCB48", Offset = "0x20FCB48", VA = "0x20FCB48")]
	public bool HaveSave(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x20FF820", Offset = "0x20FF820", VA = "0x20FF820")]
	public string GetSave(string name)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x20FCDB4", Offset = "0x20FCDB4", VA = "0x20FCDB4")]
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
	[Address(RVA = "0x2108E48", Offset = "0x2108E48", VA = "0x2108E48")]
	public static bool IsEncryptionEstablished()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2109A7C", Offset = "0x2109A7C", VA = "0x2109A7C")]
	public static bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2109B50", Offset = "0x2109B50", VA = "0x2109B50")]
	public static void clearUser()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2109C50", Offset = "0x2109C50", VA = "0x2109C50")]
	public static void clearUserAndSession()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2109CF0", Offset = "0x2109CF0", VA = "0x2109CF0")]
	public static uint GetAccountIDChecksum(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2109DC4", Offset = "0x2109DC4", VA = "0x2109DC4")]
	public static uint GetUIDFromAccountID(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2104DC4", Offset = "0x2104DC4", VA = "0x2104DC4")]
	public static string GetStringUIDFromAccountID(uint id)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2109E38", Offset = "0x2109E38", VA = "0x2109E38")]
	public static bool GetAccountIDFromStringUID(string suid, out uint id)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000010")]
public static class CloudSave_Utils
{
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x210A198", Offset = "0x210A198", VA = "0x210A198")]
	public static string RSA_encrypt(string toBeEncrypted)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x210A19C", Offset = "0x210A19C", VA = "0x210A19C")]
	public static void generateAESkeyAndIV()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x210A1A0", Offset = "0x210A1A0", VA = "0x210A1A0")]
	public static string AES_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x210A1A8", Offset = "0x210A1A8", VA = "0x210A1A8")]
	public static string AES_encrypt(string input, bool MD5)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x21089C4", Offset = "0x21089C4", VA = "0x21089C4")]
	public static string AES_decrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x210A378", Offset = "0x210A378", VA = "0x210A378")]
	private static string GetMd5Hash(MD5 md5Hash, string input)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x210A224", Offset = "0x210A224", VA = "0x210A224")]
	public static string MD5_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2108AA8", Offset = "0x2108AA8", VA = "0x2108AA8")]
	public static string MD5_encryptWithSalt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x210A4AC", Offset = "0x210A4AC", VA = "0x210A4AC")]
	public static string convertBytesToString(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x210A4F4", Offset = "0x210A4F4", VA = "0x210A4F4")]
	public static byte[] convertStringToBytes(string s)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2106954", Offset = "0x2106954", VA = "0x2106954")]
	public static bool TestValidEmailFormat(string email)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x210A530", Offset = "0x210A530", VA = "0x210A530")]
	public static bool GetValueInsideTag(string text, string tag, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x210A6FC", Offset = "0x210A6FC", VA = "0x210A6FC")]
	public static string[] GetValuesInsideTags(string text, string tag)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x210A944", Offset = "0x210A944", VA = "0x210A944")]
	public static Dictionary<string, string> ParseKeysAssignedValues(string text, char delimeter)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x210AB38", Offset = "0x210AB38", VA = "0x210AB38")]
	public static bool GetValueOfTag(string text, string valTag, out string outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x210ABF8", Offset = "0x210ABF8", VA = "0x210ABF8")]
	public static Dictionary<string, string> GetTagsAndValues(string text)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x210AD98", Offset = "0x210AD98", VA = "0x210AD98")]
	public static bool GetIntValueOfTag(string text, string valTag, out int outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x210AE40", Offset = "0x210AE40", VA = "0x210AE40")]
	public static bool ParseErrorCode(string text, out string errorText, out string errorExtCode)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x210AF9C", Offset = "0x210AF9C", VA = "0x210AF9C")]
	public static string GetUrlWithSecureProtocol(string url)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x210B068", Offset = "0x210B068", VA = "0x210B068")]
	public static string GetWebGLUrlProxy(string url)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x210B06C", Offset = "0x210B06C", VA = "0x210B06C")]
	public static string GenRandomString(int len)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x210B138", Offset = "0x210B138", VA = "0x210B138")]
	public static string EncodeBase64(string plain)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x210B1C8", Offset = "0x210B1C8", VA = "0x210B1C8")]
	public static string DecodeBase64(string encoded)
	{
		return null;
	}
}
[Token(Token = "0x2000011")]
public class CloudSave_ServerCoroutine_ChangePassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83670C", Offset = "0x83670C")]
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
			[Address(RVA = "0x2131CF4", Offset = "0x2131CF4", VA = "0x2131CF4", Slot = "4")]
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
			[Address(RVA = "0x2131D3C", Offset = "0x2131D3C", VA = "0x2131D3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2131620", Offset = "0x2131620", VA = "0x2131620")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x213164C", Offset = "0x213164C", VA = "0x213164C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2131650", Offset = "0x2131650", VA = "0x2131650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2131CFC", Offset = "0x2131CFC", VA = "0x2131CFC", Slot = "8")]
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
	[Address(RVA = "0x2108344", Offset = "0x2108344", VA = "0x2108344")]
	public void InitParams(string _oldPassword, string _newPassword)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x210834C", Offset = "0x210834C", VA = "0x210834C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2108354", Offset = "0x2108354", VA = "0x2108354", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x210835C", Offset = "0x210835C", VA = "0x210835C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8381E0", Offset = "0x8381E0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x21083C8", Offset = "0x21083C8", VA = "0x21083C8")]
	public CloudSave_ServerCoroutine_ChangePassword()
	{
	}
}
[Token(Token = "0x2000012")]
public class CloudSave_ServerCoroutine_DeleteAccount : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83671C", Offset = "0x83671C")]
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
			[Address(RVA = "0x213239C", Offset = "0x213239C", VA = "0x213239C", Slot = "4")]
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
			[Address(RVA = "0x21323E4", Offset = "0x21323E4", VA = "0x21323E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2131D44", Offset = "0x2131D44", VA = "0x2131D44")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2131D70", Offset = "0x2131D70", VA = "0x2131D70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2131D74", Offset = "0x2131D74", VA = "0x2131D74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x21323A4", Offset = "0x21323A4", VA = "0x21323A4", Slot = "8")]
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
	[Address(RVA = "0x210841C", Offset = "0x210841C", VA = "0x210841C")]
	public void InitParams(string _password)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2108424", Offset = "0x2108424", VA = "0x2108424", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x210842C", Offset = "0x210842C", VA = "0x210842C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2108434", Offset = "0x2108434", VA = "0x2108434", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838240", Offset = "0x838240")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x21084A0", Offset = "0x21084A0", VA = "0x21084A0")]
	public CloudSave_ServerCoroutine_DeleteAccount()
	{
	}
}
[Token(Token = "0x2000013")]
public class CloudSave_ServerCoroutine_LoadGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83672C", Offset = "0x83672C")]
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
			[Address(RVA = "0x2132A44", Offset = "0x2132A44", VA = "0x2132A44", Slot = "4")]
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
			[Address(RVA = "0x2132A8C", Offset = "0x2132A8C", VA = "0x2132A8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x21323EC", Offset = "0x21323EC", VA = "0x21323EC")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2132418", Offset = "0x2132418", VA = "0x2132418", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x213241C", Offset = "0x213241C", VA = "0x213241C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2132A4C", Offset = "0x2132A4C", VA = "0x2132A4C", Slot = "8")]
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
	[Address(RVA = "0x21084F4", Offset = "0x21084F4", VA = "0x21084F4", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x21084FC", Offset = "0x21084FC", VA = "0x21084FC", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2104D3C", Offset = "0x2104D3C", VA = "0x2104D3C")]
	public CloudSave_Saves GetResultLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2108504", Offset = "0x2108504", VA = "0x2108504")]
	public static bool ParseSavesFromServer(string text, CloudSave_Saves localSaves, out CloudSave_Saves outSaves)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2108B1C", Offset = "0x2108B1C", VA = "0x2108B1C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8382A0", Offset = "0x8382A0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2108B88", Offset = "0x2108B88", VA = "0x2108B88")]
	public CloudSave_ServerCoroutine_LoadGameSave()
	{
	}
}
[Token(Token = "0x2000014")]
public class CloudSave_ServerCoroutine_Login : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83673C", Offset = "0x83673C")]
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
			[Address(RVA = "0x21338B0", Offset = "0x21338B0", VA = "0x21338B0", Slot = "4")]
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
			[Address(RVA = "0x21338F8", Offset = "0x21338F8", VA = "0x21338F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2132A94", Offset = "0x2132A94", VA = "0x2132A94")]
		[DebuggerHidden]
		public <Run>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2132AC0", Offset = "0x2132AC0", VA = "0x2132AC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2132AC4", Offset = "0x2132AC4", VA = "0x2132AC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x21338B8", Offset = "0x21338B8", VA = "0x21338B8", Slot = "8")]
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
	[Address(RVA = "0x21079A8", Offset = "0x21079A8", VA = "0x21079A8")]
	public void InitParams(bool _register, string _email, string _password, bool _newsletter, CloudSave_Saves _localSavesToCompare)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2108BEC", Offset = "0x2108BEC", VA = "0x2108BEC", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2108BF4", Offset = "0x2108BF4", VA = "0x2108BF4", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2108BFC", Offset = "0x2108BFC", VA = "0x2108BFC")]
	public bool GetLoadSaveResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2108C04", Offset = "0x2108C04", VA = "0x2108C04")]
	public CloudSave_Saves GetLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2108C8C", Offset = "0x2108C8C", VA = "0x2108C8C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838300", Offset = "0x838300")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2108CF8", Offset = "0x2108CF8", VA = "0x2108CF8")]
	public CloudSave_ServerCoroutine_Login()
	{
	}
}
[Token(Token = "0x2000015")]
public class CloudSave_ServerCoroutine_OpenSSLSession : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83674C", Offset = "0x83674C")]
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
			[Address(RVA = "0x21346B0", Offset = "0x21346B0", VA = "0x21346B0", Slot = "4")]
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
			[Address(RVA = "0x21346F8", Offset = "0x21346F8", VA = "0x21346F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2133FC0", Offset = "0x2133FC0", VA = "0x2133FC0")]
		[DebuggerHidden]
		public <Run>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2133FEC", Offset = "0x2133FEC", VA = "0x2133FEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2133FF0", Offset = "0x2133FF0", VA = "0x2133FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x21346B8", Offset = "0x21346B8", VA = "0x21346B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83675C", Offset = "0x83675C")]
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
			[Address(RVA = "0x2133F70", Offset = "0x2133F70", VA = "0x2133F70", Slot = "4")]
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
			[Address(RVA = "0x2133FB8", Offset = "0x2133FB8", VA = "0x2133FB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x2133900", Offset = "0x2133900", VA = "0x2133900")]
		[DebuggerHidden]
		public <EstablishAESSecurity>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x213392C", Offset = "0x213392C", VA = "0x213392C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x2133930", Offset = "0x2133930", VA = "0x2133930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x2133F78", Offset = "0x2133F78", VA = "0x2133F78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int aesTry;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2108DE8", Offset = "0x2108DE8", VA = "0x2108DE8", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2108DF0", Offset = "0x2108DF0", VA = "0x2108DF0", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2108FD0", Offset = "0x2108FD0", VA = "0x2108FD0", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838360", Offset = "0x838360")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x210903C", Offset = "0x210903C", VA = "0x210903C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8383C0", Offset = "0x8383C0")]
	protected IEnumerator EstablishAESSecurity()
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x21090A8", Offset = "0x21090A8", VA = "0x21090A8")]
	public CloudSave_ServerCoroutine_OpenSSLSession()
	{
	}
}
[Token(Token = "0x2000016")]
public class CloudSave_ServerCoroutine_RedeemCode : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83676C", Offset = "0x83676C")]
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
			[Address(RVA = "0x2134DB8", Offset = "0x2134DB8", VA = "0x2134DB8", Slot = "4")]
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
			[Address(RVA = "0x2134E00", Offset = "0x2134E00", VA = "0x2134E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x2134700", Offset = "0x2134700", VA = "0x2134700")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x213472C", Offset = "0x213472C", VA = "0x213472C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2134730", Offset = "0x2134730", VA = "0x2134730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2134DC0", Offset = "0x2134DC0", VA = "0x2134DC0", Slot = "8")]
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
	[Address(RVA = "0x21090B0", Offset = "0x21090B0", VA = "0x21090B0")]
	public void InitParams(string _code)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x21090B8", Offset = "0x21090B8", VA = "0x21090B8", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x21090C0", Offset = "0x21090C0", VA = "0x21090C0", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x21090C8", Offset = "0x21090C8", VA = "0x21090C8")]
	public string GetResultSku()
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x21090D0", Offset = "0x21090D0", VA = "0x21090D0", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838420", Offset = "0x838420")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x210913C", Offset = "0x210913C", VA = "0x210913C")]
	public CloudSave_ServerCoroutine_RedeemCode()
	{
	}
}
[Token(Token = "0x2000017")]
public class CloudSave_ServerCoroutine_SendResetPassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83677C", Offset = "0x83677C")]
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
			[Address(RVA = "0x1FAB504", Offset = "0x1FAB504", VA = "0x1FAB504", Slot = "4")]
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
			[Address(RVA = "0x1FAB54C", Offset = "0x1FAB54C", VA = "0x1FAB54C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1FAAE64", Offset = "0x1FAAE64", VA = "0x1FAAE64")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1FAAE90", Offset = "0x1FAAE90", VA = "0x1FAAE90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1FAAE94", Offset = "0x1FAAE94", VA = "0x1FAAE94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1FAB50C", Offset = "0x1FAB50C", VA = "0x1FAB50C", Slot = "8")]
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
	[Address(RVA = "0x2109194", Offset = "0x2109194", VA = "0x2109194")]
	public void InitParams(string _email)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x210919C", Offset = "0x210919C", VA = "0x210919C", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x21091A4", Offset = "0x21091A4", VA = "0x21091A4", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x21091AC", Offset = "0x21091AC", VA = "0x21091AC", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838480", Offset = "0x838480")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2109218", Offset = "0x2109218", VA = "0x2109218")]
	public CloudSave_ServerCoroutine_SendResetPassword()
	{
	}
}
[Token(Token = "0x2000018")]
public class CloudSave_ServerCoroutine_SetNewsletter : CloudSave_ServerCoroutine
{
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83678C", Offset = "0x83678C")]
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
			[Address(RVA = "0x1FABC24", Offset = "0x1FABC24", VA = "0x1FABC24", Slot = "4")]
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
			[Address(RVA = "0x1FABC6C", Offset = "0x1FABC6C", VA = "0x1FABC6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1FAB554", Offset = "0x1FAB554", VA = "0x1FAB554")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1FAB580", Offset = "0x1FAB580", VA = "0x1FAB580", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1FAB584", Offset = "0x1FAB584", VA = "0x1FAB584", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1FABC2C", Offset = "0x1FABC2C", VA = "0x1FABC2C", Slot = "8")]
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
	[Address(RVA = "0x210926C", Offset = "0x210926C", VA = "0x210926C")]
	public void InitParams(bool _signed)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x2109278", Offset = "0x2109278", VA = "0x2109278", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x2109280", Offset = "0x2109280", VA = "0x2109280", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2109288", Offset = "0x2109288", VA = "0x2109288", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8384E0", Offset = "0x8384E0")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x21092F4", Offset = "0x21092F4", VA = "0x21092F4")]
	public CloudSave_ServerCoroutine_SetNewsletter()
	{
	}
}
[Token(Token = "0x2000019")]
public class CloudSave_ServerCoroutine_StoreGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83679C", Offset = "0x83679C")]
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
			[Address(RVA = "0x1FACE20", Offset = "0x1FACE20", VA = "0x1FACE20", Slot = "4")]
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
			[Address(RVA = "0x1FACE68", Offset = "0x1FACE68", VA = "0x1FACE68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1FABC74", Offset = "0x1FABC74", VA = "0x1FABC74")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1FABCA0", Offset = "0x1FABCA0", VA = "0x1FABCA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1FABCA4", Offset = "0x1FABCA4", VA = "0x1FABCA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1FACE28", Offset = "0x1FACE28", VA = "0x1FACE28", Slot = "8")]
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
	[Address(RVA = "0x2105730", Offset = "0x2105730", VA = "0x2105730")]
	public void InitParams(CloudSave_Saves _storeSaves)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x21092FC", Offset = "0x21092FC", VA = "0x21092FC", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2109304", Offset = "0x2109304", VA = "0x2109304", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x210930C", Offset = "0x210930C", VA = "0x210930C")]
	public CloudSave_Saves GetStoringSaves()
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x2109314", Offset = "0x2109314", VA = "0x2109314", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838540", Offset = "0x838540")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x2109380", Offset = "0x2109380", VA = "0x2109380")]
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
	[Address(RVA = "0x20FFC7C", Offset = "0x20FFC7C", VA = "0x20FFC7C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x20FFEC4", Offset = "0x20FFEC4", VA = "0x20FFEC4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x20FFF68", Offset = "0x20FFF68", VA = "0x20FFF68", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2100044", Offset = "0x2100044", VA = "0x2100044", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2100258", Offset = "0x2100258", VA = "0x2100258")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x21002C0", Offset = "0x21002C0", VA = "0x21002C0")]
	public void OnSwitchShowOldPassword(bool on)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2100380", Offset = "0x2100380", VA = "0x2100380")]
	public void OnSwitchShowNewPassword(bool on)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2100388", Offset = "0x2100388", VA = "0x2100388")]
	public void OnSwitchShowRepeatPassword(bool on)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x21002C8", Offset = "0x21002C8", VA = "0x21002C8")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2100390", Offset = "0x2100390", VA = "0x2100390")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x21006A0", Offset = "0x21006A0", VA = "0x21006A0")]
	public CloudSave_Screen_ChangePassword()
	{
	}
}
[Token(Token = "0x200001B")]
public class CloudSave_Screen_CloudInfo : CloudSave_Screen
{
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8367AC", Offset = "0x8367AC")]
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
			[Address(RVA = "0x21314C0", Offset = "0x21314C0", VA = "0x21314C0", Slot = "4")]
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
			[Address(RVA = "0x2131508", Offset = "0x2131508", VA = "0x2131508", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x2131174", Offset = "0x2131174", VA = "0x2131174")]
		[DebuggerHidden]
		public <AnimDotsCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x21311A0", Offset = "0x21311A0", VA = "0x21311A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x21311A4", Offset = "0x21311A4", VA = "0x21311A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x21314C8", Offset = "0x21314C8", VA = "0x21314C8", Slot = "8")]
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
	[Address(RVA = "0x21006F4", Offset = "0x21006F4", VA = "0x21006F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x21007F0", Offset = "0x21007F0", VA = "0x21007F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x21007F4", Offset = "0x21007F4", VA = "0x21007F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x210088C", Offset = "0x210088C", VA = "0x210088C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x21008B4", Offset = "0x21008B4", VA = "0x21008B4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x21008DC", Offset = "0x21008DC", VA = "0x21008DC")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2100944", Offset = "0x2100944", VA = "0x2100944")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x21009A8", Offset = "0x21009A8", VA = "0x21009A8")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x2100A0C", Offset = "0x2100A0C", VA = "0x2100A0C")]
	public void OnClickCloseToLogin()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2100820", Offset = "0x2100820", VA = "0x2100820")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8385A0", Offset = "0x8385A0")]
	protected IEnumerator AnimDotsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x2100A74", Offset = "0x2100A74", VA = "0x2100A74")]
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
	[Address(RVA = "0x2100A84", Offset = "0x2100A84", VA = "0x2100A84", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x2100B70", Offset = "0x2100B70", VA = "0x2100B70", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2100C14", Offset = "0x2100C14", VA = "0x2100C14", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2100CF0", Offset = "0x2100CF0", VA = "0x2100CF0", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2100E70", Offset = "0x2100E70", VA = "0x2100E70")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2100ED8", Offset = "0x2100ED8", VA = "0x2100ED8")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2100F30", Offset = "0x2100F30", VA = "0x2100F30")]
	public void OnClickDelete()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2101084", Offset = "0x2101084", VA = "0x2101084")]
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
	[Address(RVA = "0x210108C", Offset = "0x210108C", VA = "0x210108C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2101104", Offset = "0x2101104", VA = "0x2101104")]
	private void Start()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2101108", Offset = "0x2101108", VA = "0x2101108", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2101814", Offset = "0x2101814", VA = "0x2101814", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x21018B8", Offset = "0x21018B8", VA = "0x21018B8")]
	public void OnBackFromTermsOfUse(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x2101A4C", Offset = "0x2101A4C", VA = "0x2101A4C")]
	public void OnBackFromTermsOfUseLogin(string _email, string _password, bool _newsletter, CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2101F70", Offset = "0x2101F70", VA = "0x2101F70", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x210204C", Offset = "0x210204C", VA = "0x210204C", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2101A80", Offset = "0x2101A80", VA = "0x2101A80")]
	protected void OnEndCoroutine(CloudSave_ServerCoroutine coroutine, bool fromTermsOfUse)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2101594", Offset = "0x2101594", VA = "0x2101594")]
	private void UpdateModeFields()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x210140C", Offset = "0x210140C", VA = "0x210140C")]
	private void LoadFromPlayerPrefs()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x2102138", Offset = "0x2102138", VA = "0x2102138")]
	private void OnLogin(bool confirmDeleteSaveOnRegister)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x210276C", Offset = "0x210276C", VA = "0x210276C")]
	private void DeleteSaveOnRegisterCallback(bool result)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x2102888", Offset = "0x2102888", VA = "0x2102888")]
	private void DeleteSaveOnLoginToEmptyCallback(bool result)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x21029AC", Offset = "0x21029AC", VA = "0x21029AC")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x2102A10", Offset = "0x2102A10", VA = "0x2102A10")]
	public void OnClickShowInfo()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x20FD54C", Offset = "0x20FD54C", VA = "0x20FD54C")]
	public void OnClickSwitchLogin(bool switched)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x20FD4C4", Offset = "0x20FD4C4", VA = "0x20FD4C4")]
	public void OnClickSwitchRegister(bool switched)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x210180C", Offset = "0x210180C", VA = "0x210180C")]
	public void OnClickLogin()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x2102A78", Offset = "0x2102A78", VA = "0x2102A78")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2102B30", Offset = "0x2102B30", VA = "0x2102B30")]
	public void OnSwitchShowPassword1(bool on)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2102BC4", Offset = "0x2102BC4", VA = "0x2102BC4")]
	public void OnSwitchShowPassword2(bool on)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x2102B38", Offset = "0x2102B38", VA = "0x2102B38")]
	public void OnSwitchShowPassword(int num, bool on)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2102BCC", Offset = "0x2102BCC", VA = "0x2102BCC")]
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
	[Address(RVA = "0x2103C30", Offset = "0x2103C30", VA = "0x2103C30", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x210450C", Offset = "0x210450C", VA = "0x210450C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x2104620", Offset = "0x2104620", VA = "0x2104620")]
	public void Update()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x2104750", Offset = "0x2104750", VA = "0x2104750", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x21048CC", Offset = "0x21048CC", VA = "0x21048CC", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2104A74", Offset = "0x2104A74", VA = "0x2104A74")]
	protected void OnEndCoroutineLoad()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x2104BA4", Offset = "0x2104BA4", VA = "0x2104BA4")]
	protected void OnEndCoroutineStore()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x210415C", Offset = "0x210415C", VA = "0x210415C")]
	protected void EnableImportExportButtons(bool import, bool export)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x2103F48", Offset = "0x2103F48", VA = "0x2103F48")]
	protected void FillLoginInfo()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x2104268", Offset = "0x2104268", VA = "0x2104268")]
	protected void UpdateAfterReceivedCloudSave()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x210521C", Offset = "0x210521C", VA = "0x210521C")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2105288", Offset = "0x2105288", VA = "0x2105288")]
	public void OnClickSettings()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x21052F4", Offset = "0x21052F4", VA = "0x21052F4")]
	public void OnSwitchShowEmail(bool on)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x21052F8", Offset = "0x21052F8", VA = "0x21052F8")]
	public void OnClickSetPassword()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x21053B8", Offset = "0x21053B8", VA = "0x21053B8")]
	public void OnClickLogout()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x2105478", Offset = "0x2105478", VA = "0x2105478")]
	public void OnClickImport()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x2104FC0", Offset = "0x2104FC0", VA = "0x2104FC0")]
	public void OnClickExport()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x210574C", Offset = "0x210574C", VA = "0x210574C")]
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
	[Address(RVA = "0x21057B0", Offset = "0x21057B0", VA = "0x21057B0", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x21057D8", Offset = "0x21057D8", VA = "0x21057D8", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x2105800", Offset = "0x2105800", VA = "0x2105800")]
	public void Init(string text, bool okcancel, bool warning, CloudSave_Screen _backToScreen, Action<bool> _resultCallback)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x2105948", Offset = "0x2105948", VA = "0x2105948")]
	public void OnClickOK()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x21059C0", Offset = "0x21059C0", VA = "0x21059C0")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x2105A38", Offset = "0x2105A38", VA = "0x2105A38")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x2105AB0", Offset = "0x2105AB0", VA = "0x2105AB0")]
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
	[Address(RVA = "0x2105AB8", Offset = "0x2105AB8", VA = "0x2105AB8", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x2105B38", Offset = "0x2105B38", VA = "0x2105B38", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x2105BD8", Offset = "0x2105BD8", VA = "0x2105BD8", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x2105CB8", Offset = "0x2105CB8", VA = "0x2105CB8", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x2105F60", Offset = "0x2105F60", VA = "0x2105F60")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x2105FCC", Offset = "0x2105FCC", VA = "0x2105FCC")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x21061AC", Offset = "0x21061AC", VA = "0x21061AC")]
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
	[Address(RVA = "0x2106200", Offset = "0x2106200", VA = "0x2106200", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x210647C", Offset = "0x210647C", VA = "0x210647C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x210651C", Offset = "0x210651C", VA = "0x210651C")]
	public void Init(bool _backToSettings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2106528", Offset = "0x2106528", VA = "0x2106528", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2106608", Offset = "0x2106608", VA = "0x2106608", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2106780", Offset = "0x2106780", VA = "0x2106780")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x21067F4", Offset = "0x21067F4", VA = "0x21067F4")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x2106ABC", Offset = "0x2106ABC", VA = "0x2106ABC")]
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
	[Address(RVA = "0x2106B10", Offset = "0x2106B10", VA = "0x2106B10", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x2106C04", Offset = "0x2106C04", VA = "0x2106C04", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x2106CA4", Offset = "0x2106CA4", VA = "0x2106CA4", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x2106D84", Offset = "0x2106D84", VA = "0x2106D84", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2106E9C", Offset = "0x2106E9C", VA = "0x2106E9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x2107058", Offset = "0x2107058", VA = "0x2107058")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x21070C4", Offset = "0x21070C4", VA = "0x21070C4")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2107130", Offset = "0x2107130", VA = "0x2107130")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x210719C", Offset = "0x210719C", VA = "0x210719C")]
	public void OnClickDeleteAccount()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x2107208", Offset = "0x2107208", VA = "0x2107208")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x2107274", Offset = "0x2107274", VA = "0x2107274")]
	public void OnSwitchNewsletter(bool signed)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x2107404", Offset = "0x2107404", VA = "0x2107404")]
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
	[Address(RVA = "0x210740C", Offset = "0x210740C", VA = "0x210740C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x2107434", Offset = "0x2107434", VA = "0x2107434", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x21074D4", Offset = "0x21074D4", VA = "0x21074D4")]
	public void Init(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x21074E4", Offset = "0x21074E4", VA = "0x21074E4", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x21075C4", Offset = "0x21075C4", VA = "0x21075C4", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2107818", Offset = "0x2107818", VA = "0x2107818", Slot = "12")]
	public override void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x2107880", Offset = "0x2107880", VA = "0x2107880", Slot = "13")]
	public override void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x2107890", Offset = "0x2107890", VA = "0x2107890")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x21079E0", Offset = "0x21079E0", VA = "0x21079E0")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x2107A74", Offset = "0x2107A74", VA = "0x2107A74")]
	public CloudSave_Screen_TermsOfUse()
	{
	}
}
[Token(Token = "0x2000024")]
public class CloudSave_AdjustIconToText : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8367BC", Offset = "0x8367BC")]
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
			[Address(RVA = "0x2131124", Offset = "0x2131124", VA = "0x2131124", Slot = "4")]
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
			[Address(RVA = "0x213116C", Offset = "0x213116C", VA = "0x213116C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2130B94", Offset = "0x2130B94", VA = "0x2130B94")]
		[DebuggerHidden]
		public <AdjustToTextCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2130BC0", Offset = "0x2130BC0", VA = "0x2130BC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2130BC4", Offset = "0x2130BC4", VA = "0x2130BC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x213112C", Offset = "0x213112C", VA = "0x213112C", Slot = "8")]
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
	[Address(RVA = "0x20F9AB4", Offset = "0x20F9AB4", VA = "0x20F9AB4")]
	public void Start()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x20F9AE0", Offset = "0x20F9AE0", VA = "0x20F9AE0")]
	private void AdjustToText()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x20F9B0C", Offset = "0x20F9B0C", VA = "0x20F9B0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838600", Offset = "0x838600")]
	public IEnumerator AdjustToTextCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x20F9B78", Offset = "0x20F9B78", VA = "0x20F9B78")]
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
		[Address(RVA = "0x20F9B80", Offset = "0x20F9B80", VA = "0x20F9B80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x20F9B88", Offset = "0x20F9B88", VA = "0x20F9B88")]
		set
		{
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x20F9CD4", Offset = "0x20F9CD4", VA = "0x20F9CD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x20F9B94", Offset = "0x20F9B94", VA = "0x20F9B94")]
	private void changeMaterial()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x20F9D3C", Offset = "0x20F9D3C", VA = "0x20F9D3C")]
	public void changeOtherMaterial(Material m)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x20F9E3C", Offset = "0x20F9E3C", VA = "0x20F9E3C")]
	private void Click()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x20F9F44", Offset = "0x20F9F44", VA = "0x20F9F44")]
	public void SetChecked(bool on)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x20F9F50", Offset = "0x20F9F50", VA = "0x20F9F50")]
	public void SetCallbackWithObject(bool on)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x20F9F5C", Offset = "0x20F9F5C", VA = "0x20F9F5C")]
	public void SetCustomParam(string param)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x20F9F64", Offset = "0x20F9F64", VA = "0x20F9F64")]
	public string GetCustomParam()
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x20F9F6C", Offset = "0x20F9F6C", VA = "0x20F9F6C")]
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
	[Address(RVA = "0x20FECB4", Offset = "0x20FECB4", VA = "0x20FECB4")]
	public void ShowText(string txt, bool warning)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x20FD45C", Offset = "0x20FD45C", VA = "0x20FD45C")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x20FEE58", Offset = "0x20FEE58", VA = "0x20FEE58")]
	public bool IsWarning()
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x20FEE60", Offset = "0x20FEE60", VA = "0x20FEE60")]
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
	[Address(RVA = "0x1EE3584", Offset = "0x1EE3584", VA = "0x1EE3584")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1EE365C", Offset = "0x1EE365C", VA = "0x1EE365C")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1EE38F4", Offset = "0x1EE38F4", VA = "0x1EE38F4")]
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
		[Address(RVA = "0x1FB0748", Offset = "0x1FB0748", VA = "0x1FB0748")]
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
	[Address(RVA = "0x1EE38FC", Offset = "0x1EE38FC", VA = "0x1EE38FC")]
	public static void UpdateMaterialsForObjectsWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1EE3CCC", Offset = "0x1EE3CCC", VA = "0x1EE3CCC")]
	public static void UpdateMaterialForObjectWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1EE3F50", Offset = "0x1EE3F50", VA = "0x1EE3F50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1EE44BC", Offset = "0x1EE44BC", VA = "0x1EE44BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1EE455C", Offset = "0x1EE455C", VA = "0x1EE455C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1EE46E8", Offset = "0x1EE46E8", VA = "0x1EE46E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1EE4764", Offset = "0x1EE4764", VA = "0x1EE4764")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1EE48D4", Offset = "0x1EE48D4", VA = "0x1EE48D4")]
	private Vector2 Scale()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1EE494C", Offset = "0x1EE494C", VA = "0x1EE494C")]
	public static Vector2 Scale(GameObject go, bool inclSelfScale)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1EE4A40", Offset = "0x1EE4A40", VA = "0x1EE4A40")]
	public void ContentsChanged()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1EE4A58", Offset = "0x1EE4A58", VA = "0x1EE4A58")]
	public void SetKeepMinOrgScrollSize(bool s)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1EE44A8", Offset = "0x1EE44A8", VA = "0x1EE44A8")]
	public void AutoAdjustToContents(bool adjustAfterChanges = true)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1EE4A64", Offset = "0x1EE4A64", VA = "0x1EE4A64")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1EE4E74", Offset = "0x1EE4E74", VA = "0x1EE4E74")]
	public void FreezeScroll(bool freeze)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1EE4E80", Offset = "0x1EE4E80", VA = "0x1EE4E80")]
	public bool HaveClippedContents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1EE4EDC", Offset = "0x1EE4EDC", VA = "0x1EE4EDC")]
	public bool HaveClippedContentsX()
	{
		return default(bool);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1EE4F08", Offset = "0x1EE4F08", VA = "0x1EE4F08")]
	public bool HaveClippedContentsY()
	{
		return default(bool);
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1EE4F34", Offset = "0x1EE4F34", VA = "0x1EE4F34")]
	public bool IsScreenPointInBounds(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1EE50D0", Offset = "0x1EE50D0", VA = "0x1EE50D0")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1EE51D4", Offset = "0x1EE51D4", VA = "0x1EE51D4")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1EE5284", Offset = "0x1EE5284", VA = "0x1EE5284")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1EE52E0", Offset = "0x1EE52E0", VA = "0x1EE52E0")]
	public void ScrollToTop()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1EE5340", Offset = "0x1EE5340", VA = "0x1EE5340")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1EE53A0", Offset = "0x1EE53A0", VA = "0x1EE53A0")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1EE5408", Offset = "0x1EE5408", VA = "0x1EE5408")]
	public bool IsScrolledToY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1EE547C", Offset = "0x1EE547C", VA = "0x1EE547C")]
	public bool IsInsideClipAreaY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1EE54E4", Offset = "0x1EE54E4", VA = "0x1EE54E4")]
	public bool IsDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1EE54EC", Offset = "0x1EE54EC", VA = "0x1EE54EC")]
	public void EnsureVisible(Vector3 pos)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1EE56D4", Offset = "0x1EE56D4", VA = "0x1EE56D4")]
	public bool IsClippedOutColChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1EE57DC", Offset = "0x1EE57DC", VA = "0x1EE57DC")]
	public bool IsClippedOutRendChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1EE58E4", Offset = "0x1EE58E4", VA = "0x1EE58E4")]
	public void AddIgnoredNotClippedChild(GameObject go)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1EE5948", Offset = "0x1EE5948", VA = "0x1EE5948")]
	private bool IsIgnoredNotClippedChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1EE5A38", Offset = "0x1EE5A38", VA = "0x1EE5A38")]
	public void SetExtendHorzSizeToScreen()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1EE5A44", Offset = "0x1EE5A44", VA = "0x1EE5A44")]
	public void SetZoomContents(GameObject rootObj, float min, float max, float speed)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1EE5A58", Offset = "0x1EE5A58", VA = "0x1EE5A58")]
	public bool HaveZoomContents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1EE5AC4", Offset = "0x1EE5AC4", VA = "0x1EE5AC4")]
	public static MUI_ClippedScroll GetActiveScroll(Vector2 atPoint)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1EE5C88", Offset = "0x1EE5C88", VA = "0x1EE5C88")]
	private void Update()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1EE6DD8", Offset = "0x1EE6DD8", VA = "0x1EE6DD8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1EE7494", Offset = "0x1EE7494", VA = "0x1EE7494")]
	private void ClipBkgToScreen()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1EE6048", Offset = "0x1EE6048", VA = "0x1EE6048")]
	private void AdjustHorzSizeToScreen()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1EE70A4", Offset = "0x1EE70A4", VA = "0x1EE70A4")]
	private void AdjustScrollSizeToContents()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1EE8220", Offset = "0x1EE8220", VA = "0x1EE8220")]
	private void UpdateMaterials(GameObject go, ref Bounds mergedBounds)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1EE8EE8", Offset = "0x1EE8EE8", VA = "0x1EE8EE8")]
	private BoxColliderInfo GetBoxColliderOrgSize(BoxCollider box, Vector2 scale)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1EE9160", Offset = "0x1EE9160", VA = "0x1EE9160")]
	private void UpdateBounds(GameObject go)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1EE56F0", Offset = "0x1EE56F0", VA = "0x1EE56F0")]
	private int GetClippedOutColChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1EE57F8", Offset = "0x1EE57F8", VA = "0x1EE57F8")]
	private int GetClippedOutRendChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1EE7AF0", Offset = "0x1EE7AF0", VA = "0x1EE7AF0")]
	private void UpdateAfterChanged()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1EE4B04", Offset = "0x1EE4B04", VA = "0x1EE4B04")]
	private void UpdateScroll()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1EE50D4", Offset = "0x1EE50D4", VA = "0x1EE50D4")]
	private void Scroll(float x, float y)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1EE9E24", Offset = "0x1EE9E24", VA = "0x1EE9E24")]
	private Vector2 ScreenPointToWorldPos(Vector2 p)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1EE4F64", Offset = "0x1EE4F64", VA = "0x1EE4F64")]
	private bool IsScreenPointInClipArea(Vector3 p)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1EEA098", Offset = "0x1EEA098", VA = "0x1EEA098")]
	public void OnScrollBarDown(MUI_ClippedScroll_Bar bar, bool down)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1EE637C", Offset = "0x1EE637C", VA = "0x1EE637C")]
	private void StepDrag()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1EE6A5C", Offset = "0x1EE6A5C", VA = "0x1EE6A5C")]
	private void StepScrollMouseWheel()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1EE6BF8", Offset = "0x1EE6BF8", VA = "0x1EE6BF8")]
	private void StepZoom()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1EEA1F0", Offset = "0x1EEA1F0", VA = "0x1EEA1F0")]
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
	[Address(RVA = "0x1EEA384", Offset = "0x1EEA384", VA = "0x1EEA384")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1EEA3E8", Offset = "0x1EEA3E8", VA = "0x1EEA3E8")]
	public void Down()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1EEA478", Offset = "0x1EEA478", VA = "0x1EEA478")]
	public void Up()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1EEA508", Offset = "0x1EEA508", VA = "0x1EEA508")]
	public void Click()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1EEA598", Offset = "0x1EEA598", VA = "0x1EEA598")]
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
	[Address(RVA = "0x20F9AAC", Offset = "0x20F9AAC", VA = "0x20F9AAC")]
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
	[Address(RVA = "0x20F9AA4", Offset = "0x20F9AA4", VA = "0x20F9AA4")]
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
	[Address(RVA = "0x1EEA5A0", Offset = "0x1EEA5A0", VA = "0x1EEA5A0")]
	public MUI_ClippedScroll_Materials()
	{
	}
}
[Token(Token = "0x200002E")]
public class MUI_Continous : MonoBehaviour
{
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1EEA5A8", Offset = "0x1EEA5A8", VA = "0x1EEA5A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1EEA670", Offset = "0x1EEA670", VA = "0x1EEA670")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1EEA908", Offset = "0x1EEA908", VA = "0x1EEA908")]
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
	[Address(RVA = "0x20F7B20", Offset = "0x20F7B20", VA = "0x20F7B20")]
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
	[Address(RVA = "0x1EEA910", Offset = "0x1EEA910", VA = "0x1EEA910")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1EEA978", Offset = "0x1EEA978", VA = "0x1EEA978")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1EEACE0", Offset = "0x1EEACE0", VA = "0x1EEACE0")]
	public static LayerMask GetMUIlayerMask()
	{
		return default(LayerMask);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1EEAD44", Offset = "0x1EEAD44", VA = "0x1EEAD44")]
	public static Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1EEADA8", Offset = "0x1EEADA8", VA = "0x1EEADA8")]
	public static void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1EEAE10", Offset = "0x1EEAE10", VA = "0x1EEAE10")]
	public static void ClearLayerMask()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1EEAE88", Offset = "0x1EEAE88", VA = "0x1EEAE88")]
	public static bool WasNowClickDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1EEABD4", Offset = "0x1EEABD4", VA = "0x1EEABD4")]
	public static void AddLayer(string layer)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x1EEAEEC", Offset = "0x1EEAEEC", VA = "0x1EEAEEC")]
	public static void RemoveLayer(string layer)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1EEB05C", Offset = "0x1EEB05C", VA = "0x1EEB05C")]
	public static bool IsDraggingItem()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1EEB1C0", Offset = "0x1EEB1C0", VA = "0x1EEB1C0")]
	private void Zoom()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1EEB74C", Offset = "0x1EEB74C", VA = "0x1EEB74C")]
	private void Drag()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1EEC01C", Offset = "0x1EEC01C", VA = "0x1EEC01C")]
	private bool IsChildOfActiveScroll(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1EEC110", Offset = "0x1EEC110", VA = "0x1EEC110")]
	private bool FingerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1EEC20C", Offset = "0x1EEC20C", VA = "0x1EEC20C")]
	private bool FingerUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1EEC2F4", Offset = "0x1EEC2F4", VA = "0x1EEC2F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1EEC59C", Offset = "0x1EEC59C", VA = "0x1EEC59C")]
	private void CastRay(bool down, bool up, bool move)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1EECCDC", Offset = "0x1EECCDC", VA = "0x1EECCDC")]
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
		[Address(RVA = "0x20F9A8C", Offset = "0x20F9A8C", VA = "0x20F9A8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x20F9A94", Offset = "0x20F9A94", VA = "0x20F9A94")]
		set
		{
		}
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x20F9A9C", Offset = "0x20F9A9C", VA = "0x20F9A9C")]
	public ClipboardHelper()
	{
	}
}
[Token(Token = "0x2000032")]
public class MUI_InputText : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8367CC", Offset = "0x8367CC")]
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
			[Address(RVA = "0x1FB1918", Offset = "0x1FB1918", VA = "0x1FB1918", Slot = "4")]
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
			[Address(RVA = "0x1FB1960", Offset = "0x1FB1960", VA = "0x1FB1960", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1FB0750", Offset = "0x1FB0750", VA = "0x1FB0750")]
		[DebuggerHidden]
		public <ReadKbdInputCoroutine>d__74(int <>1__state)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1FB077C", Offset = "0x1FB077C", VA = "0x1FB077C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1FB0780", Offset = "0x1FB0780", VA = "0x1FB0780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1FB1920", Offset = "0x1FB1920", VA = "0x1FB1920", Slot = "8")]
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
		[Address(RVA = "0x1EED198", Offset = "0x1EED198", VA = "0x1EED198")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1EED1A0", Offset = "0x1EED1A0", VA = "0x1EED1A0")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action SystemKeyboardShow
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1EECDB8", Offset = "0x1EECDB8", VA = "0x1EECDB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838660", Offset = "0x838660")]
		add
		{
		}
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1EECEB0", Offset = "0x1EECEB0", VA = "0x1EECEB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838670", Offset = "0x838670")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event Action SystemKeyboardHide
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1EECFA8", Offset = "0x1EECFA8", VA = "0x1EECFA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838680", Offset = "0x838680")]
		add
		{
		}
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1EED0A0", Offset = "0x1EED0A0", VA = "0x1EED0A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838690", Offset = "0x838690")]
		remove
		{
		}
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1EED788", Offset = "0x1EED788", VA = "0x1EED788")]
	public static bool IsOpenedSystemKeyboard()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1EED7EC", Offset = "0x1EED7EC", VA = "0x1EED7EC")]
	public static bool IsCurrentInputActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1EED88C", Offset = "0x1EED88C", VA = "0x1EED88C")]
	public void SetIsInputOfScreenKeyboard(MUI_ScreenKeyboard owner)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1EED894", Offset = "0x1EED894", VA = "0x1EED894")]
	public void SetAllowInputInScreenKeyboard()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1EED8A0", Offset = "0x1EED8A0", VA = "0x1EED8A0")]
	public void AddScreenKeyboardInput(char c)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1EED990", Offset = "0x1EED990", VA = "0x1EED990")]
	public void SetKeyboardInputActive(bool active)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1EEDB24", Offset = "0x1EEDB24", VA = "0x1EEDB24")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1EEDC98", Offset = "0x1EEDC98", VA = "0x1EEDC98")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1EEDD3C", Offset = "0x1EEDD3C", VA = "0x1EEDD3C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1EEDD64", Offset = "0x1EEDD64", VA = "0x1EEDD64")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1EEDFB0", Offset = "0x1EEDFB0", VA = "0x1EEDFB0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x1EEE170", Offset = "0x1EEE170", VA = "0x1EEE170")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1EEE19C", Offset = "0x1EEE19C", VA = "0x1EEE19C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1EEE1A0", Offset = "0x1EEE1A0", VA = "0x1EEE1A0")]
	private void Down()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1EEE1A8", Offset = "0x1EEE1A8", VA = "0x1EEE1A8")]
	protected MUI_Show_ScreenKeyboard GetShowKbdComponent(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1EEE4D4", Offset = "0x1EEE4D4", VA = "0x1EEE4D4")]
	private void ControllerClick()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1EED9AC", Offset = "0x1EED9AC", VA = "0x1EED9AC")]
	private void Click()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1EEE4DC", Offset = "0x1EEE4DC", VA = "0x1EEE4DC")]
	private void DoClick(bool fromController)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1EED9B4", Offset = "0x1EED9B4", VA = "0x1EED9B4")]
	protected void CloseKeyboard()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1EEE9D0", Offset = "0x1EEE9D0", VA = "0x1EEE9D0")]
	protected string GetPastedClipboardText()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1EEEA34", Offset = "0x1EEEA34", VA = "0x1EEEA34")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1EEEA3C", Offset = "0x1EEEA3C", VA = "0x1EEEA3C")]
	public void UpdateText()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1EED1B8", Offset = "0x1EED1B8", VA = "0x1EED1B8")]
	public void SetText(string _t, int cursorPos)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1EEEE3C", Offset = "0x1EEEE3C", VA = "0x1EEEE3C")]
	private void SetTextMesh(string txt)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1EEEA80", Offset = "0x1EEEA80", VA = "0x1EEEA80")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1EEED8C", Offset = "0x1EEED8C", VA = "0x1EEED8C")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1EEEF0C", Offset = "0x1EEEF0C", VA = "0x1EEEF0C")]
	protected void CreateCursor()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1EEE910", Offset = "0x1EEE910", VA = "0x1EEE910")]
	protected void DestroyCursor()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1EEF240", Offset = "0x1EEF240", VA = "0x1EEF240")]
	private bool IsTouchKeyboardActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1EEE894", Offset = "0x1EEE894", VA = "0x1EEE894")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8386A0", Offset = "0x8386A0")]
	private IEnumerator ReadKbdInputCoroutine(int initCursorPos)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1EEF254", Offset = "0x1EEF254", VA = "0x1EEF254")]
	protected MUI_InputText FindNextInputText()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1EEF5A8", Offset = "0x1EEF5A8", VA = "0x1EEF5A8")]
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
		[Address(RVA = "0x1EE5DE8", Offset = "0x1EE5DE8", VA = "0x1EE5DE8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public static int height
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1EE5F18", Offset = "0x1EE5F18", VA = "0x1EE5F18")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1EEF668", Offset = "0x1EEF668", VA = "0x1EEF668")]
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
	[Address(RVA = "0x1EEF674", Offset = "0x1EEF674", VA = "0x1EEF674", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1EEF678", Offset = "0x1EEF678", VA = "0x1EEF678", Slot = "5")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1EEF67C", Offset = "0x1EEF67C", VA = "0x1EEF67C")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1EF0260", Offset = "0x1EF0260", VA = "0x1EF0260", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1EF0264", Offset = "0x1EF0264", VA = "0x1EF0264")]
	public void Show(MUI_InputText _fillInput, string label, GameObject _hideScreen)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1EF0414", Offset = "0x1EF0414", VA = "0x1EF0414")]
	public void CancelKeyboard()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1EF0470", Offset = "0x1EF0470", VA = "0x1EF0470", Slot = "7")]
	public virtual void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1EF0688", Offset = "0x1EF0688", VA = "0x1EF0688", Slot = "8")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1EF0734", Offset = "0x1EF0734", VA = "0x1EF0734", Slot = "9")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1EF0820", Offset = "0x1EF0820", VA = "0x1EF0820", Slot = "10")]
	public virtual void OnInputEnter()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1EF086C", Offset = "0x1EF086C", VA = "0x1EF086C")]
	public void OnKeyPressed(string skey)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1EF0D18", Offset = "0x1EF0D18", VA = "0x1EF0D18")]
	protected GameObject FindObject(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1EF0AD0", Offset = "0x1EF0AD0", VA = "0x1EF0AD0")]
	protected int FindKeyIndex(string skey)
	{
		return default(int);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1EEF774", Offset = "0x1EEF774", VA = "0x1EEF774")]
	protected void InitTextKeys()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1EF0BD8", Offset = "0x1EF0BD8", VA = "0x1EF0BD8")]
	protected char GetCurrentKey(int i)
	{
		return default(char);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1EEFF14", Offset = "0x1EEFF14", VA = "0x1EEFF14")]
	protected void FillTextKeys()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1EF059C", Offset = "0x1EF059C", VA = "0x1EF059C")]
	protected string TrimEndLineCharacters(string text)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1EF1084", Offset = "0x1EF1084", VA = "0x1EF1084")]
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
	[Address(RVA = "0x1EF11E0", Offset = "0x1EF11E0", VA = "0x1EF11E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1EF11E4", Offset = "0x1EF11E4", VA = "0x1EF11E4")]
	private void DoInit()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1EF1264", Offset = "0x1EF1264", VA = "0x1EF1264")]
	private void Start()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1EF1350", Offset = "0x1EF1350", VA = "0x1EF1350")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1EF13E8", Offset = "0x1EF13E8", VA = "0x1EF13E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1EEBFB0", Offset = "0x1EEBFB0", VA = "0x1EEBFB0")]
	public static bool IsAnyScrollActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1EF1528", Offset = "0x1EF1528", VA = "0x1EF1528")]
	public static bool IsAnyScrollingInBoundary()
	{
		return default(bool);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1EF158C", Offset = "0x1EF158C", VA = "0x1EF158C")]
	public void ResetOrgPos(Vector3 org)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1EF1598", Offset = "0x1EF1598", VA = "0x1EF1598")]
	public void SetSizeMinY(float y)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1EF15A0", Offset = "0x1EF15A0", VA = "0x1EF15A0")]
	public void SetSize(Vector2 _size)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1EF15EC", Offset = "0x1EF15EC", VA = "0x1EF15EC")]
	public void SetOffset(Vector2 _offset)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1EF12A8", Offset = "0x1EF12A8", VA = "0x1EF12A8")]
	public void ResetScroll()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1EF1730", Offset = "0x1EF1730", VA = "0x1EF1730")]
	public void AutoCalculateSize()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1EF1FF8", Offset = "0x1EF1FF8", VA = "0x1EF1FF8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x1EF2064", Offset = "0x1EF2064", VA = "0x1EF2064")]
	private void Update()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1EF2570", Offset = "0x1EF2570", VA = "0x1EF2570")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1EF259C", Offset = "0x1EF259C", VA = "0x1EF259C")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1EF2614", Offset = "0x1EF2614", VA = "0x1EF2614")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1EF268C", Offset = "0x1EF268C", VA = "0x1EF268C")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1EF2734", Offset = "0x1EF2734", VA = "0x1EF2734")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1EF2794", Offset = "0x1EF2794", VA = "0x1EF2794")]
	public bool IsAllOnScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1EF162C", Offset = "0x1EF162C", VA = "0x1EF162C")]
	public void Clamp()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1EF27C4", Offset = "0x1EF27C4", VA = "0x1EF27C4")]
	public void UpdateZoom()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1EF1F00", Offset = "0x1EF1F00", VA = "0x1EF1F00")]
	public static Vector2 GetFrustrumSizeAt(Camera cam)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x1EF2824", Offset = "0x1EF2824", VA = "0x1EF2824")]
	public void EnsureVisible(Vector3 point)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1EF2C30", Offset = "0x1EF2C30", VA = "0x1EF2C30")]
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
	[Address(RVA = "0x1EEE71C", Offset = "0x1EEE71C", VA = "0x1EEE71C")]
	public void Click()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x1EF2CA0", Offset = "0x1EF2CA0", VA = "0x1EF2CA0")]
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
	[Address(RVA = "0x1EF2CF4", Offset = "0x1EF2CF4", VA = "0x1EF2CF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1EF2D1C", Offset = "0x1EF2D1C", VA = "0x1EF2D1C")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1EF2E14", Offset = "0x1EF2E14", VA = "0x1EF2E14")]
	public void SetValChangedCallback(Action<MUI_Slider, float> callback)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1EF2E1C", Offset = "0x1EF2E1C", VA = "0x1EF2E1C")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1EF2E24", Offset = "0x1EF2E24", VA = "0x1EF2E24")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1EF2E68", Offset = "0x1EF2E68", VA = "0x1EF2E68")]
	public float GetVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1EF2EE8", Offset = "0x1EF2EE8", VA = "0x1EF2EE8")]
	public void SetVal(float v)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1EF2D2C", Offset = "0x1EF2D2C", VA = "0x1EF2D2C")]
	private void UpdateSquarePos()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1EF2F98", Offset = "0x1EF2F98", VA = "0x1EF2F98")]
	private void Down()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1EF3128", Offset = "0x1EF3128", VA = "0x1EF3128")]
	private void Click()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1EF312C", Offset = "0x1EF312C", VA = "0x1EF312C")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1EF2F9C", Offset = "0x1EF2F9C", VA = "0x1EF2F9C")]
	private void Process()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1EF3130", Offset = "0x1EF3130", VA = "0x1EF3130")]
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
	[Address(RVA = "0x1EF3144", Offset = "0x1EF3144", VA = "0x1EF3144")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1EF323C", Offset = "0x1EF323C", VA = "0x1EF323C")]
	public void SetValChangedCallback(Action<MUI_SliderVertical, float, float> callback)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x1EF3244", Offset = "0x1EF3244", VA = "0x1EF3244")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1EF324C", Offset = "0x1EF324C", VA = "0x1EF324C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x1EF3290", Offset = "0x1EF3290", VA = "0x1EF3290")]
	private void Update()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x1EF3154", Offset = "0x1EF3154", VA = "0x1EF3154")]
	public void UpdateSquarePos()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1EF3580", Offset = "0x1EF3580", VA = "0x1EF3580")]
	private void Down()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x1EF3584", Offset = "0x1EF3584", VA = "0x1EF3584")]
	private void Click()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1EF3588", Offset = "0x1EF3588", VA = "0x1EF3588")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1EF3320", Offset = "0x1EF3320", VA = "0x1EF3320")]
	private void Process()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1EF358C", Offset = "0x1EF358C", VA = "0x1EF358C")]
	public MUI_SliderVertical()
	{
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x836394", Offset = "0x836394")]
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
		[Address(RVA = "0x1FB1968", Offset = "0x1FB1968", VA = "0x1FB1968")]
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
	[Address(RVA = "0x1EF35A0", Offset = "0x1EF35A0", VA = "0x1EF35A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1EF3710", Offset = "0x1EF3710", VA = "0x1EF3710")]
	private static void FindInstance()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x1EF38A0", Offset = "0x1EF38A0", VA = "0x1EF38A0")]
	public static void Play(int num)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1EF39E4", Offset = "0x1EF39E4", VA = "0x1EF39E4")]
	private void Play()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1EF3B3C", Offset = "0x1EF3B3C", VA = "0x1EF3B3C")]
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
	[Address(RVA = "0x1EF3B50", Offset = "0x1EF3B50", VA = "0x1EF3B50")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1EF3D3C", Offset = "0x1EF3D3C", VA = "0x1EF3D3C")]
	private void Down()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1EF3FC4", Offset = "0x1EF3FC4", VA = "0x1EF3FC4")]
	private void Up()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1EF4178", Offset = "0x1EF4178", VA = "0x1EF4178")]
	private void Click()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1EF41EC", Offset = "0x1EF41EC", VA = "0x1EF41EC")]
	private void IsDown(BoolRef isDown)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1EF4208", Offset = "0x1EF4208", VA = "0x1EF4208")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1EF4218", Offset = "0x1EF4218", VA = "0x1EF4218")]
	public bool IsDisabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1EF4220", Offset = "0x1EF4220", VA = "0x1EF4220")]
	public void Disable()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1EF444C", Offset = "0x1EF444C", VA = "0x1EF444C")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1EF464C", Offset = "0x1EF464C", VA = "0x1EF464C")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x1EF4658", Offset = "0x1EF4658", VA = "0x1EF4658")]
	public void SetDisabled(bool disabled)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1EF4664", Offset = "0x1EF4664", VA = "0x1EF4664")]
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
	[Address(RVA = "0x1EF469C", Offset = "0x1EF469C", VA = "0x1EF469C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1EF4714", Offset = "0x1EF4714", VA = "0x1EF4714")]
	private void Start()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1EF4B70", Offset = "0x1EF4B70", VA = "0x1EF4B70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1EF4B74", Offset = "0x1EF4B74", VA = "0x1EF4B74")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x1EF4718", Offset = "0x1EF4718", VA = "0x1EF4718")]
	public void Calculate()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1EF4FC8", Offset = "0x1EF4FC8", VA = "0x1EF4FC8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1EF4C9C", Offset = "0x1EF4C9C", VA = "0x1EF4C9C")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1EF4B78", Offset = "0x1EF4B78", VA = "0x1EF4B78")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1EF52C8", Offset = "0x1EF52C8", VA = "0x1EF52C8")]
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
	[Address(RVA = "0x1985880", Offset = "0x1985880", VA = "0x1985880")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x19858EC", Offset = "0x19858EC", VA = "0x19858EC")]
	public static void InitDefaults()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x19860E8", Offset = "0x19860E8", VA = "0x19860E8")]
	public static bool HadSet(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x19861B8", Offset = "0x19861B8", VA = "0x19861B8")]
	public static bool Get(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1986288", Offset = "0x1986288", VA = "0x1986288")]
	public static void Set(eCheck e, bool v)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x19862F8", Offset = "0x19862F8", VA = "0x19862F8")]
	public static void Set(int i, bool v)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1986410", Offset = "0x1986410", VA = "0x1986410")]
	public static void Switch(eCheck i)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1986558", Offset = "0x1986558", VA = "0x1986558")]
	public static float GetFloat(eSlider i)
	{
		return default(float);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x19865E8", Offset = "0x19865E8", VA = "0x19865E8")]
	public static void SetFloat(eSlider i, float v)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x198669C", Offset = "0x198669C", VA = "0x198669C")]
	public static bool GetNS(eCheckNotSaved i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x198672C", Offset = "0x198672C", VA = "0x198672C")]
	public static void SetNS(int i, bool v)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x19867D4", Offset = "0x19867D4", VA = "0x19867D4")]
	public static void SwitchNS(eCheckNotSaved i)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x198686C", Offset = "0x198686C", VA = "0x198686C")]
	public static void Save()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1986A88", Offset = "0x1986A88", VA = "0x1986A88")]
	public static bool CanLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x1985CD8", Offset = "0x1985CD8", VA = "0x1985CD8")]
	public static void Load()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1986B1C", Offset = "0x1986B1C", VA = "0x1986B1C")]
	private void Click()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1986B74", Offset = "0x1986B74", VA = "0x1986B74")]
	public MUI_data()
	{
	}
}
[Token(Token = "0x2000040")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8363F4", Offset = "0x8363F4")]
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
	[Address(RVA = "0x1986C68", Offset = "0x1986C68", VA = "0x1986C68")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1986D70", Offset = "0x1986D70", VA = "0x1986D70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1987074", Offset = "0x1987074", VA = "0x1987074")]
	private void SetWidth(float w)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x198707C", Offset = "0x198707C", VA = "0x198707C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x19872C4", Offset = "0x19872C4", VA = "0x19872C4")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x198708C", Offset = "0x198708C", VA = "0x198708C")]
	private void BreakNow()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x19872C8", Offset = "0x19872C8", VA = "0x19872C8")]
	public static int IndexOfNth(string str, char c, int nth, int startPosition = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1987380", Offset = "0x1987380", VA = "0x1987380")]
	public void BreakLinesFromLine(int line, float width)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1987580", Offset = "0x1987580", VA = "0x1987580")]
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
	[Address(RVA = "0x2128EDC", Offset = "0x2128EDC", VA = "0x2128EDC")]
	public StringBufferWrapper(int capacity)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2128F90", Offset = "0x2128F90", VA = "0x2128F90")]
	public StringBufferWrapper()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2128FF8", Offset = "0x2128FF8", VA = "0x2128FF8")]
	public void Clear()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2129034", Offset = "0x2129034", VA = "0x2129034")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x212906C", Offset = "0x212906C", VA = "0x212906C")]
	public unsafe void Append(char* str, int startIdx, int count)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x21290B4", Offset = "0x21290B4", VA = "0x21290B4")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2129118", Offset = "0x2129118", VA = "0x2129118")]
	public void Append(StringBufferWrapper sb)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x2129160", Offset = "0x2129160", VA = "0x2129160")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x21291C8", Offset = "0x21291C8", VA = "0x21291C8")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2129234", Offset = "0x2129234", VA = "0x2129234")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x21292C0", Offset = "0x21292C0", VA = "0x21292C0", Slot = "3")]
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
		[Address(RVA = "0x21292F4", Offset = "0x21292F4", VA = "0x21292F4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000008")]
	public float height
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x21294DC", Offset = "0x21294DC", VA = "0x21294DC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2129534", Offset = "0x2129534", VA = "0x2129534")]
	public TextSize(TextMesh tm, int textCapacity = -1, int wordCapacity = -1)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x2129640", Offset = "0x2129640", VA = "0x2129640")]
	private void getSpace()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x212932C", Offset = "0x212932C", VA = "0x212932C")]
	private float GetTextWidth(string s)
	{
		return default(float);
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x21297E8", Offset = "0x21297E8", VA = "0x21297E8")]
	private string RemoveLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x212990C", Offset = "0x212990C", VA = "0x212990C")]
	private string RemoveSingleLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x2129AA8", Offset = "0x2129AA8", VA = "0x2129AA8")]
	public void FitToWidth(float wantedWidth, bool removeLineBreaks, bool removeSingleLineBreaks, int leaveFirstNbreaks, bool justifyLines, bool resetDictionary, int maxLines)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x212A274", Offset = "0x212A274", VA = "0x212A274")]
	private bool IsCHchar(char c)
	{
		return default(bool);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x2129D88", Offset = "0x2129D88", VA = "0x2129D88")]
	private unsafe bool WrapLine(char* s, int startIdx, int endIdx, float w, bool justifyLine)
	{
		return default(bool);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x212A284", Offset = "0x212A284", VA = "0x212A284")]
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
	[Address(RVA = "0x19875AC", Offset = "0x19875AC", VA = "0x19875AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1987668", Offset = "0x1987668", VA = "0x1987668")]
	private void Start()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1987674", Offset = "0x1987674", VA = "0x1987674")]
	private void Update()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x19879B0", Offset = "0x19879B0", VA = "0x19879B0")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x19876AC", Offset = "0x19876AC", VA = "0x19876AC")]
	public void Calculate()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x19879BC", Offset = "0x19879BC", VA = "0x19879BC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1987CC0", Offset = "0x1987CC0", VA = "0x1987CC0")]
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
	[Address(RVA = "0x2128B44", Offset = "0x2128B44", VA = "0x2128B44")]
	public StringBuffer(int capacity)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2128BB8", Offset = "0x2128BB8", VA = "0x2128BB8")]
	public void Clear()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2128BC0", Offset = "0x2128BC0", VA = "0x2128BC0")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x2128C4C", Offset = "0x2128C4C", VA = "0x2128C4C")]
	public unsafe void Append(char* str, int count)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2128CBC", Offset = "0x2128CBC", VA = "0x2128CBC")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x2128CEC", Offset = "0x2128CEC", VA = "0x2128CEC")]
	public void Append(StringBuffer sb)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x2128D7C", Offset = "0x2128D7C", VA = "0x2128D7C")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x2128DB0", Offset = "0x2128DB0", VA = "0x2128DB0")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x2128E08", Offset = "0x2128E08", VA = "0x2128E08")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2128E1C", Offset = "0x2128E1C", VA = "0x2128E1C", Slot = "3")]
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
	[Address(RVA = "0x1987D4C", Offset = "0x1987D4C", VA = "0x1987D4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1987D5C", Offset = "0x1987D5C", VA = "0x1987D5C")]
	public void MergeMeshNow()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1988464", Offset = "0x1988464", VA = "0x1988464")]
	public void AddTR(Transform t0)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x1988A84", Offset = "0x1988A84", VA = "0x1988A84")]
	public void CountData(Mesh m, Vector3[] mvertices, Renderer r)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x198971C", Offset = "0x198971C", VA = "0x198971C")]
	public void AddMaterial(Material m)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x1989828", Offset = "0x1989828", VA = "0x1989828")]
	public int GetMaterialIndex(Material m)
	{
		return default(int);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1988B80", Offset = "0x1988B80", VA = "0x1988B80")]
	private void BuildMesh(Transform t, Mesh m, Vector3[] mvertices)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1989320", Offset = "0x1989320", VA = "0x1989320")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1989940", Offset = "0x1989940", VA = "0x1989940")]
	public MergeMesh()
	{
	}
}
[Token(Token = "0x2000046")]
public class OpenUrl
{
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x2121584", Offset = "0x2121584", VA = "0x2121584")]
	public static void Open(string url)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x21215C4", Offset = "0x21215C4", VA = "0x21215C4")]
	public static void Open(string url, string steamBundleID)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x2121630", Offset = "0x2121630", VA = "0x2121630")]
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
		[Address(RVA = "0x2121638", Offset = "0x2121638", VA = "0x2121638")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	public static bool sidequestStore
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2121640", Offset = "0x2121640", VA = "0x2121640")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	public static bool oculusStore
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x21216AC", Offset = "0x21216AC", VA = "0x21216AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public static bool steamStore
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2121718", Offset = "0x2121718", VA = "0x2121718")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public static bool viveStore
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2121784", Offset = "0x2121784", VA = "0x2121784")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public static bool microsoftStore
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x21217F0", Offset = "0x21217F0", VA = "0x21217F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public static bool noloStore
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x212185C", Offset = "0x212185C", VA = "0x212185C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public static bool picoStore
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x21218C8", Offset = "0x21218C8", VA = "0x21218C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public static bool yvrStore
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2121934", Offset = "0x2121934", VA = "0x2121934")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public static bool qiyuStore
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x21219A0", Offset = "0x21219A0", VA = "0x21219A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public static bool standaloneOVRStore
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2121A0C", Offset = "0x2121A0C", VA = "0x2121A0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public static bool oculusVR
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2121A78", Offset = "0x2121A78", VA = "0x2121A78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public static bool steamVR
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2121AE4", Offset = "0x2121AE4", VA = "0x2121AE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000016")]
	public static bool noloVR
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2121B50", Offset = "0x2121B50", VA = "0x2121B50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public static bool waveVR
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2121BBC", Offset = "0x2121BBC", VA = "0x2121BBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public static bool picoVR
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2121C28", Offset = "0x2121C28", VA = "0x2121C28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000019")]
	public static bool yvrVR
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2121C94", Offset = "0x2121C94", VA = "0x2121C94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001A")]
	public static bool qiyuVR
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2121D00", Offset = "0x2121D00", VA = "0x2121D00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001B")]
	public static bool multi_china
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2121D6C", Offset = "0x2121D6C", VA = "0x2121D6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001C")]
	public static bool android
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2121E18", Offset = "0x2121E18", VA = "0x2121E18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001D")]
	public static bool winStore
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2121E20", Offset = "0x2121E20", VA = "0x2121E20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public static bool winStandalone
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2121E28", Offset = "0x2121E28", VA = "0x2121E28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public static bool iOS
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2121E30", Offset = "0x2121E30", VA = "0x2121E30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public static bool macOsStandalone
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2121E38", Offset = "0x2121E38", VA = "0x2121E38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public static bool standalone
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2121E40", Offset = "0x2121E40", VA = "0x2121E40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public static bool linuxStandalone
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2121E48", Offset = "0x2121E48", VA = "0x2121E48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000023")]
	public static bool mobile
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2121E50", Offset = "0x2121E50", VA = "0x2121E50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000024")]
	public static bool PC
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2121EAC", Offset = "0x2121EAC", VA = "0x2121EAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000025")]
	public static string str0xA0
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2121F20", Offset = "0x2121F20", VA = "0x2121F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x2121F64", Offset = "0x2121F64", VA = "0x2121F64")]
	public static void CheckDevMode()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x21221C8", Offset = "0x21221C8", VA = "0x21221C8")]
	public static int GetQuestSystemVersion()
	{
		return default(int);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x2122A1C", Offset = "0x2122A1C", VA = "0x2122A1C")]
	public static bool IsMinRequiredQuestSystemVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x2122AA8", Offset = "0x2122AA8", VA = "0x2122AA8")]
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
	[Address(RVA = "0x210B260", Offset = "0x210B260", VA = "0x210B260")]
	public void ComputeConvolution(Cubemap originalCubeMap)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x210B884", Offset = "0x210B884", VA = "0x210B884")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x210B4DC", Offset = "0x210B4DC", VA = "0x210B4DC")]
	private Cubemap computeFilteredCubeMap(Cubemap originalCubeMap)
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x210BAA8", Offset = "0x210BAA8", VA = "0x210BAA8")]
	private void setFaceAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x210BBD8", Offset = "0x210BBD8", VA = "0x210BBD8")]
	private void setCornerAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f, int g, int h, int i)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x210B934", Offset = "0x210B934", VA = "0x210B934")]
	private Vector3 getDirection(int face, int i, int j, int size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x210BD9C", Offset = "0x210BD9C", VA = "0x210BD9C")]
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
	[Address(RVA = "0x21141F8", Offset = "0x21141F8", VA = "0x21141F8")]
	public static implicit operator EncodedInt(int value)
	{
		return default(EncodedInt);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x2114214", Offset = "0x2114214", VA = "0x2114214")]
	public static bool operator ==(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x21142A8", Offset = "0x21142A8", VA = "0x21142A8")]
	public static bool operator !=(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x21142D0", Offset = "0x21142D0", VA = "0x21142D0")]
	public static bool operator ==(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x21142FC", Offset = "0x21142FC", VA = "0x21142FC")]
	public static bool operator !=(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x2114328", Offset = "0x2114328", VA = "0x2114328")]
	public void setValue(int val)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x211423C", Offset = "0x211423C", VA = "0x211423C")]
	public int getValue()
	{
		return default(int);
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x2114204", Offset = "0x2114204", VA = "0x2114204")]
	private EncodedInt(int val)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x21143CC", Offset = "0x21143CC", VA = "0x21143CC")]
	private void Init(int val)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x2114424", Offset = "0x2114424", VA = "0x2114424", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x2114450", Offset = "0x2114450", VA = "0x2114450")]
	public string ToString(string format)
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x2114484", Offset = "0x2114484", VA = "0x2114484", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x2114544", Offset = "0x2114544", VA = "0x2114544")]
	public bool Equals(EncodedInt p)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x2114578", Offset = "0x2114578", VA = "0x2114578", Slot = "2")]
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
	[Address(RVA = "0x212B8C4", Offset = "0x212B8C4", VA = "0x212B8C4")]
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
	[Address(RVA = "0x2124E18", Offset = "0x2124E18", VA = "0x2124E18")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x212551C", Offset = "0x212551C", VA = "0x212551C")]
	public static float GetFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x2125584", Offset = "0x2125584", VA = "0x2125584")]
	public static float GetFloat(string key, float defval)
	{
		return default(float);
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x212568C", Offset = "0x212568C", VA = "0x212568C")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x21256F4", Offset = "0x21256F4", VA = "0x21256F4")]
	public static int GetInt(string key, int defval)
	{
		return default(int);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x21257FC", Offset = "0x21257FC", VA = "0x21257FC")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x2125878", Offset = "0x2125878", VA = "0x2125878")]
	public static string GetString(string key, string defval)
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x2125994", Offset = "0x2125994", VA = "0x2125994")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x2125A74", Offset = "0x2125A74", VA = "0x2125A74")]
	public static void Save()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x2125D40", Offset = "0x2125D40", VA = "0x2125D40")]
	public static void SetFloat(string key, float val)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x2125ED8", Offset = "0x2125ED8", VA = "0x2125ED8")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x2126070", Offset = "0x2126070", VA = "0x2126070")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2124F5C", Offset = "0x2124F5C", VA = "0x2124F5C")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x212621C", Offset = "0x212621C", VA = "0x212621C")]
	public static void InitQUIYU(string prefix)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x2126220", Offset = "0x2126220", VA = "0x2126220")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x2126858", Offset = "0x2126858", VA = "0x2126858")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x21267AC", Offset = "0x21267AC", VA = "0x21267AC")]
	private string GetHardcodedOculusCloudSaveDirectory()
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2126914", Offset = "0x2126914", VA = "0x2126914")]
	private void OnCompleteGetUserDirectoryPath(Message msg)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2126CA0", Offset = "0x2126CA0", VA = "0x2126CA0")]
	public static bool IsInitializing()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x2126DB0", Offset = "0x2126DB0", VA = "0x2126DB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x2126FF0", Offset = "0x2126FF0", VA = "0x2126FF0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x2127098", Offset = "0x2127098", VA = "0x2127098")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x21250D0", Offset = "0x21250D0", VA = "0x21250D0")]
	public static bool IsUseWrapper()
	{
		return default(bool);
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x21251C0", Offset = "0x21251C0", VA = "0x21251C0")]
	protected static void LoadWrapper()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2125B68", Offset = "0x2125B68", VA = "0x2125B68")]
	protected static void StoreWrapper()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2127140", Offset = "0x2127140", VA = "0x2127140")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8367DC", Offset = "0x8367DC")]
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
			[Address(RVA = "0x1FB20A4", Offset = "0x1FB20A4", VA = "0x1FB20A4", Slot = "4")]
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
			[Address(RVA = "0x1FB20EC", Offset = "0x1FB20EC", VA = "0x1FB20EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1FB2004", Offset = "0x1FB2004", VA = "0x1FB2004")]
		[DebuggerHidden]
		public <RunCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1FB2030", Offset = "0x1FB2030", VA = "0x1FB2030", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1FB2034", Offset = "0x1FB2034", VA = "0x1FB2034", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1FB20AC", Offset = "0x1FB20AC", VA = "0x1FB20AC", Slot = "8")]
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
		[Address(RVA = "0x21284A0", Offset = "0x21284A0", VA = "0x21284A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000027")]
	private static SteamManager Instance
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x212858C", Offset = "0x212858C", VA = "0x212858C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000003")]
	public static event BoolEvent overlayActivated
	{
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x21288C0", Offset = "0x21288C0", VA = "0x21288C0")]
		add
		{
		}
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x21289DC", Offset = "0x21289DC", VA = "0x21289DC")]
		remove
		{
		}
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x21285D8", Offset = "0x21285D8", VA = "0x21285D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x2128708", Offset = "0x2128708", VA = "0x2128708")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x21287AC", Offset = "0x21287AC", VA = "0x21287AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x2128850", Offset = "0x2128850", VA = "0x2128850")]
	private void Update()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x2128854", Offset = "0x2128854", VA = "0x2128854")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838700", Offset = "0x838700")]
	private IEnumerator RunCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x2128AF8", Offset = "0x2128AF8", VA = "0x2128AF8")]
	public static string GetPlayerName()
	{
		return null;
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x2128B3C", Offset = "0x2128B3C", VA = "0x2128B3C")]
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
		[Address(RVA = "0x1FB23C8", Offset = "0x1FB23C8", VA = "0x1FB23C8")]
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
	[Address(RVA = "0x212A560", Offset = "0x212A560", VA = "0x212A560")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x212A564", Offset = "0x212A564", VA = "0x212A564")]
	public static void LogError(string text)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x212A5F4", Offset = "0x212A5F4", VA = "0x212A5F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x212A6FC", Offset = "0x212A6FC", VA = "0x212A6FC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x212A7A0", Offset = "0x212A7A0", VA = "0x212A7A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x212B0C0", Offset = "0x212B0C0", VA = "0x212B0C0")]
	public static DownloadedTexture GetTexture(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x212B10C", Offset = "0x212B10C", VA = "0x212B10C")]
	public static DownloadedTexture GetTexture(string filePath, string resourcesFolder)
	{
		return null;
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x212B7FC", Offset = "0x212B7FC", VA = "0x212B7FC")]
	protected static string GetFileName(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x212A7A4", Offset = "0x212A7A4", VA = "0x212A7A4")]
	private void StepDownloadingTextures()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x212B84C", Offset = "0x212B84C", VA = "0x212B84C")]
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
		[Address(RVA = "0x212B9E8", Offset = "0x212B9E8", VA = "0x212B9E8", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000029")]
	public string error
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x212BA14", Offset = "0x212BA14", VA = "0x212BA14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public string text
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x212BABC", Offset = "0x212BABC", VA = "0x212BABC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	public byte[] data
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x212BAE8", Offset = "0x212BAE8", VA = "0x212BAE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public string data2string
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x212BB14", Offset = "0x212BB14", VA = "0x212BB14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002D")]
	public bool isDone
	{
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x212BC28", Offset = "0x212BC28", VA = "0x212BC28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x212BC44", Offset = "0x212BC44", VA = "0x212BC44")]
	public WWWwrapper(string url, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x212BDBC", Offset = "0x212BDBC", VA = "0x212BDBC")]
	public WWWwrapper(string url, WWWForm form, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x212BF54", Offset = "0x212BF54", VA = "0x212BF54")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x212BF70", Offset = "0x212BF70", VA = "0x212BF70")]
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
		[Address(RVA = "0x20E9FF4", Offset = "0x20E9FF4", VA = "0x20E9FF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838760", Offset = "0x838760")]
		add
		{
		}
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x20EA094", Offset = "0x20EA094", VA = "0x20EA094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838770", Offset = "0x838770")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	private event Action<string> OnPermissionDeniedAction
	{
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x20EA134", Offset = "0x20EA134", VA = "0x20EA134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838780", Offset = "0x838780")]
		add
		{
		}
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x20EA1D4", Offset = "0x20EA1D4", VA = "0x20EA1D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838790", Offset = "0x838790")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	private event Action<string> OnPermissionDeniedAndDontAskAgainAction
	{
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x20EA274", Offset = "0x20EA274", VA = "0x20EA274")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8387A0", Offset = "0x8387A0")]
		add
		{
		}
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x20EA314", Offset = "0x20EA314", VA = "0x20EA314")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8387B0", Offset = "0x8387B0")]
		remove
		{
		}
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x20EA3B4", Offset = "0x20EA3B4", VA = "0x20EA3B4")]
	public AndroidPermissionCallback(Action<string> onGrantedCallback, Action<string> onDeniedCallback, Action<string> onDeniedAndDontAskAgainCallback)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x20EA490", Offset = "0x20EA490", VA = "0x20EA490", Slot = "9")]
	public virtual void OnPermissionGranted(string permissionName)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x20EA500", Offset = "0x20EA500", VA = "0x20EA500", Slot = "10")]
	public virtual void OnPermissionDenied(string permissionName)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x20EA570", Offset = "0x20EA570", VA = "0x20EA570", Slot = "11")]
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
	[Address(RVA = "0x20EA5E8", Offset = "0x20EA5E8", VA = "0x20EA5E8")]
	private static AndroidJavaObject GetActivity()
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x20EA6D0", Offset = "0x20EA6D0", VA = "0x20EA6D0")]
	private static AndroidJavaObject GetPermissionsService()
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x20EA814", Offset = "0x20EA814", VA = "0x20EA814")]
	public static bool IsPermissionGranted(string permissionName)
	{
		return default(bool);
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x20EA92C", Offset = "0x20EA92C", VA = "0x20EA92C")]
	public static void RequestPermission(string permissionName, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x20EA9D8", Offset = "0x20EA9D8", VA = "0x20EA9D8")]
	public static void RequestPermission(string[] permissionNames, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x20EAB10", Offset = "0x20EAB10", VA = "0x20EAB10")]
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
	[Address(RVA = "0x212F2C4", Offset = "0x212F2C4", VA = "0x212F2C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x212F318", Offset = "0x212F318", VA = "0x212F318")]
	private void Update()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x212F680", Offset = "0x212F680", VA = "0x212F680")]
	public WaterSimple()
	{
	}
}
namespace JSONplugin
{
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x836474", Offset = "0x836474")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8367EC", Offset = "0x8367EC")]
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
				[Address(RVA = "0x1FAE278", Offset = "0x1FAE278", VA = "0x1FAE278", Slot = "6")]
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
				[Address(RVA = "0x1FAE2C0", Offset = "0x1FAE2C0", VA = "0x1FAE2C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1FADE8C", Offset = "0x1FADE8C", VA = "0x1FADE8C")]
			[DebuggerHidden]
			public <BakeAsync>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1FADEC4", Offset = "0x1FADEC4", VA = "0x1FADEC4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1FADF9C", Offset = "0x1FADF9C", VA = "0x1FADF9C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1FADEE0", Offset = "0x1FADEE0", VA = "0x1FADEE0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1FAE280", Offset = "0x1FAE280", VA = "0x1FAE280", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1FAE2C8", Offset = "0x1FAE2C8", VA = "0x1FAE2C8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1FAE370", Offset = "0x1FAE370", VA = "0x1FAE370", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8367FC", Offset = "0x8367FC")]
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
				[Address(RVA = "0x1FAE7FC", Offset = "0x1FAE7FC", VA = "0x1FAE7FC", Slot = "6")]
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
				[Address(RVA = "0x1FAE844", Offset = "0x1FAE844", VA = "0x1FAE844", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x1FAE374", Offset = "0x1FAE374", VA = "0x1FAE374")]
			[DebuggerHidden]
			public <PrintAsync>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1FAE3AC", Offset = "0x1FAE3AC", VA = "0x1FAE3AC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1FAE490", Offset = "0x1FAE490", VA = "0x1FAE490", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1FAE3C8", Offset = "0x1FAE3C8", VA = "0x1FAE3C8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x1FAE804", Offset = "0x1FAE804", VA = "0x1FAE804", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x1FAE84C", Offset = "0x1FAE84C", VA = "0x1FAE84C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1FAE8FC", Offset = "0x1FAE8FC", VA = "0x1FAE8FC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83680C", Offset = "0x83680C")]
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
				[Address(RVA = "0x1FAFB18", Offset = "0x1FAFB18", VA = "0x1FAFB18", Slot = "6")]
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
				[Address(RVA = "0x1FAFB60", Offset = "0x1FAFB60", VA = "0x1FAFB60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1FAE900", Offset = "0x1FAE900", VA = "0x1FAE900")]
			[DebuggerHidden]
			public <StringifyAsync>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1FAE938", Offset = "0x1FAE938", VA = "0x1FAE938", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1FAEB64", Offset = "0x1FAEB64", VA = "0x1FAEB64", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1FAE9D4", Offset = "0x1FAE9D4", VA = "0x1FAE9D4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x1FAEA9C", Offset = "0x1FAEA9C", VA = "0x1FAEA9C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x1FAFB20", Offset = "0x1FAFB20", VA = "0x1FAFB20", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1FAFB68", Offset = "0x1FAFB68", VA = "0x1FAFB68", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x1FAFC28", Offset = "0x1FAFC28", VA = "0x1FAFC28", Slot = "5")]
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
			[Address(RVA = "0x21168A4", Offset = "0x21168A4", VA = "0x21168A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public int Count
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x21168B8", Offset = "0x21168B8", VA = "0x21168B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		public float f
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2116908", Offset = "0x2116908", VA = "0x2116908")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000031")]
		public static JSONObject nullJO
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2116910", Offset = "0x2116910", VA = "0x2116910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public static JSONObject obj
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2116A9C", Offset = "0x2116A9C", VA = "0x2116A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public static JSONObject arr
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2116AF8", Offset = "0x2116AF8", VA = "0x2116AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public bool IsNumber
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x21185F4", Offset = "0x21185F4", VA = "0x21185F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool IsNull
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x2118604", Offset = "0x2118604", VA = "0x2118604")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public bool IsString
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x2118614", Offset = "0x2118614", VA = "0x2118614")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public bool IsBool
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x2118624", Offset = "0x2118624", VA = "0x2118624")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public bool IsArray
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x2118634", Offset = "0x2118634", VA = "0x2118634")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public bool IsObject
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x2118644", Offset = "0x2118644", VA = "0x2118644")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public JSONObject Item
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x211A5B0", Offset = "0x211A5B0", VA = "0x211A5B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x211A63C", Offset = "0x211A63C", VA = "0x211A63C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public JSONObject Item
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x21194F0", Offset = "0x21194F0", VA = "0x21194F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x211B05C", Offset = "0x211B05C", VA = "0x211B05C")]
			set
			{
			}
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2116B54", Offset = "0x2116B54", VA = "0x2116B54")]
		public JSONObject(Type t)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2116C5C", Offset = "0x2116C5C", VA = "0x2116C5C")]
		public JSONObject(bool b)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2116C94", Offset = "0x2116C94", VA = "0x2116C94")]
		public JSONObject(float f)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2116CD0", Offset = "0x2116CD0", VA = "0x2116CD0")]
		public JSONObject(int i)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2116D18", Offset = "0x2116D18", VA = "0x2116D18")]
		public JSONObject(long l)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2116D5C", Offset = "0x2116D5C", VA = "0x2116D5C")]
		public JSONObject(Dictionary<string, string> dic)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2117050", Offset = "0x2117050", VA = "0x2117050")]
		public JSONObject(Dictionary<string, JSONObject> dic)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x211727C", Offset = "0x211727C", VA = "0x211727C")]
		public JSONObject(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x21172B8", Offset = "0x21172B8", VA = "0x21172B8")]
		public JSONObject(JSONObject[] objs)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x211734C", Offset = "0x211734C", VA = "0x211734C")]
		public static JSONObject StringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x21173AC", Offset = "0x21173AC", VA = "0x21173AC")]
		public void Absorb(JSONObject obj)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2117470", Offset = "0x2117470", VA = "0x2117470")]
		public static JSONObject Create()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x211696C", Offset = "0x211696C", VA = "0x211696C")]
		public static JSONObject Create(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x21174D0", Offset = "0x21174D0", VA = "0x21174D0")]
		public static JSONObject Create(bool val)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2117548", Offset = "0x2117548", VA = "0x2117548")]
		public static JSONObject Create(float val)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x21175C4", Offset = "0x21175C4", VA = "0x21175C4")]
		public static JSONObject Create(int val)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x211764C", Offset = "0x211764C", VA = "0x211764C")]
		public static JSONObject Create(uint val)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x21176D8", Offset = "0x21176D8", VA = "0x21176D8")]
		public static JSONObject Create(long val)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x211775C", Offset = "0x211775C", VA = "0x211775C")]
		public static JSONObject Create(ulong val)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2116FDC", Offset = "0x2116FDC", VA = "0x2116FDC")]
		public static JSONObject CreateStringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x21177E4", Offset = "0x21177E4", VA = "0x21177E4")]
		public static JSONObject CreateBakedObject(string val)
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2117858", Offset = "0x2117858", VA = "0x2117858")]
		public static JSONObject Create(string val, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x21181B4", Offset = "0x21181B4", VA = "0x21181B4")]
		public static JSONObject Create(AddJSONContents content)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2118234", Offset = "0x2118234", VA = "0x2118234")]
		public static JSONObject Create(Dictionary<string, string> dic)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x21174C8", Offset = "0x21174C8", VA = "0x21174C8")]
		public JSONObject()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x21184CC", Offset = "0x21184CC", VA = "0x21184CC")]
		public JSONObject(string str)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2118508", Offset = "0x2118508", VA = "0x2118508")]
		public JSONObject(string str, int maxDepth)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2118550", Offset = "0x2118550", VA = "0x2118550")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x211859C", Offset = "0x211859C", VA = "0x211859C")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels, bool strict)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x21178F8", Offset = "0x21178F8", VA = "0x21178F8")]
		private void Parse(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2118660", Offset = "0x2118660", VA = "0x2118660")]
		public void Add(bool val)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x21187E8", Offset = "0x21187E8", VA = "0x21187E8")]
		public void Add(float val)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2118860", Offset = "0x2118860", VA = "0x2118860")]
		public void Add(int val)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x21188D8", Offset = "0x21188D8", VA = "0x21188D8")]
		public void Add(uint val)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2118950", Offset = "0x2118950", VA = "0x2118950")]
		public void Add(long val)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x21189C8", Offset = "0x21189C8", VA = "0x21189C8")]
		public void Add(ulong val)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x2118A40", Offset = "0x2118A40", VA = "0x2118A40")]
		public void Add(string str)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2118AB8", Offset = "0x2118AB8", VA = "0x2118AB8")]
		public void Add(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x21186D8", Offset = "0x21186D8", VA = "0x21186D8")]
		public void Add(JSONObject obj)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2118B3C", Offset = "0x2118B3C", VA = "0x2118B3C")]
		public void AddField(string name, bool val)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2118DD4", Offset = "0x2118DD4", VA = "0x2118DD4")]
		public void AddField(string name, float val)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2118E5C", Offset = "0x2118E5C", VA = "0x2118E5C")]
		public void AddField(string name, int val)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2118EDC", Offset = "0x2118EDC", VA = "0x2118EDC")]
		public void AddField(string name, uint val)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2118F5C", Offset = "0x2118F5C", VA = "0x2118F5C")]
		public void AddField(string name, long val)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2118FDC", Offset = "0x2118FDC", VA = "0x2118FDC")]
		public void AddField(string name, ulong val)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x211905C", Offset = "0x211905C", VA = "0x211905C")]
		public void AddField(string name, AddJSONContents content)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x21190DC", Offset = "0x21190DC", VA = "0x21190DC")]
		public void AddField(string name, string val)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2118BBC", Offset = "0x2118BBC", VA = "0x2118BBC")]
		public void AddField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x211915C", Offset = "0x211915C", VA = "0x211915C")]
		public void SetField(string name, string val)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x211929C", Offset = "0x211929C", VA = "0x211929C")]
		public void SetField(string name, bool val)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x211931C", Offset = "0x211931C", VA = "0x211931C")]
		public void SetField(string name, float val)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x21193A4", Offset = "0x21193A4", VA = "0x21193A4")]
		public void SetField(string name, int val)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x21191DC", Offset = "0x21191DC", VA = "0x21191DC")]
		public void SetField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x21194F4", Offset = "0x21194F4", VA = "0x21194F4")]
		public void RemoveField(string name)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x21195D4", Offset = "0x21195D4", VA = "0x21195D4")]
		public bool GetField(out bool field, string name, bool fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x21195E4", Offset = "0x21195E4", VA = "0x21195E4")]
		public bool GetField(ref bool field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x21195EC", Offset = "0x21195EC", VA = "0x21195EC")]
		public bool GetField(ref bool field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x21196D8", Offset = "0x21196D8", VA = "0x21196D8")]
		public bool GetField(out float field, string name, float fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x21196E4", Offset = "0x21196E4", VA = "0x21196E4")]
		public bool GetField(ref float field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x21196EC", Offset = "0x21196EC", VA = "0x21196EC")]
		public bool GetField(ref float field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x21197D8", Offset = "0x21197D8", VA = "0x21197D8")]
		public bool GetField(out int field, string name, int fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x21197E4", Offset = "0x21197E4", VA = "0x21197E4")]
		public bool GetField(ref int field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x21197EC", Offset = "0x21197EC", VA = "0x21197EC")]
		public bool GetField(ref int field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2119924", Offset = "0x2119924", VA = "0x2119924")]
		public bool GetField(out long field, string name, long fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2119930", Offset = "0x2119930", VA = "0x2119930")]
		public bool GetField(ref long field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2119938", Offset = "0x2119938", VA = "0x2119938")]
		public bool GetField(ref long field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2119A70", Offset = "0x2119A70", VA = "0x2119A70")]
		public bool GetField(out uint field, string name, uint fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2119A7C", Offset = "0x2119A7C", VA = "0x2119A7C")]
		public bool GetField(ref uint field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2119A84", Offset = "0x2119A84", VA = "0x2119A84")]
		public bool GetField(ref uint field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2119BC8", Offset = "0x2119BC8", VA = "0x2119BC8")]
		public bool GetField(out ulong field, string name, ulong fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2119BD4", Offset = "0x2119BD4", VA = "0x2119BD4")]
		public bool GetField(ref ulong field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2119BDC", Offset = "0x2119BDC", VA = "0x2119BDC")]
		public bool GetField(ref ulong field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2119D20", Offset = "0x2119D20", VA = "0x2119D20")]
		public bool GetField(out string field, string name, string fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2119D2C", Offset = "0x2119D2C", VA = "0x2119D2C")]
		public bool GetField(ref string field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2119D34", Offset = "0x2119D34", VA = "0x2119D34")]
		public bool GetField(ref string field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2119E28", Offset = "0x2119E28", VA = "0x2119E28")]
		public void GetField(string name, GetFieldResponse response, [Optional] FieldNotFound fail)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2119F34", Offset = "0x2119F34", VA = "0x2119F34")]
		public JSONObject GetField(string name)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x211A030", Offset = "0x211A030", VA = "0x211A030")]
		public bool HasFields(string[] names)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2119424", Offset = "0x2119424", VA = "0x2119424")]
		public bool HasField(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x211A104", Offset = "0x211A104", VA = "0x211A104")]
		public void Clear()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x211A1AC", Offset = "0x211A1AC", VA = "0x211A1AC")]
		public JSONObject Copy()
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x211A234", Offset = "0x211A234", VA = "0x211A234")]
		public void Merge(JSONObject obj)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x211A2A4", Offset = "0x211A2A4", VA = "0x211A2A4")]
		private static void MergeRecur(JSONObject left, JSONObject right)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x211A6D0", Offset = "0x211A6D0", VA = "0x211A6D0")]
		public void Bake()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x211A70C", Offset = "0x211A70C", VA = "0x211A70C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8387C0", Offset = "0x8387C0")]
		public IEnumerable BakeAsync()
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x211A22C", Offset = "0x211A22C", VA = "0x211A22C")]
		public string Print()
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x211A778", Offset = "0x211A778", VA = "0x211A778")]
		public string Print(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x211AF44", Offset = "0x211AF44", VA = "0x211AF44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838820", Offset = "0x838820")]
		public IEnumerable<string> PrintAsync(bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x211AFC4", Offset = "0x211AFC4", VA = "0x211AFC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838880", Offset = "0x838880")]
		private IEnumerable StringifyAsync(int depth, StringBuilder builder, bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x211A804", Offset = "0x211A804", VA = "0x211A804")]
		private void Stringify(int depth, StringBuilder builder, bool pretty = false)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x211B060", Offset = "0x211B060", VA = "0x211B060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x211B068", Offset = "0x211B068", VA = "0x211B068")]
		public string ToString(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x211B070", Offset = "0x211B070", VA = "0x211B070")]
		public Dictionary<string, string> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2118B30", Offset = "0x2118B30", VA = "0x2118B30")]
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
		[Address(RVA = "0x211B358", Offset = "0x211B358", VA = "0x211B358")]
		public static JSONObject TOJSON(object obj)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x211BFC4", Offset = "0x211BFC4", VA = "0x211BFC4")]
		public static Vector2 ToVector2(JSONObject obj)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x211C0EC", Offset = "0x211C0EC", VA = "0x211C0EC")]
		public static JSONObject FromVector2(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x211C1C4", Offset = "0x211C1C4", VA = "0x211C1C4")]
		public static JSONObject FromVector3(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x211C2D8", Offset = "0x211C2D8", VA = "0x211C2D8")]
		public static Vector3 ToVector3(JSONObject obj)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x211C468", Offset = "0x211C468", VA = "0x211C468")]
		public static JSONObject FromVector4(Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x211C5B0", Offset = "0x211C5B0", VA = "0x211C5B0")]
		public static Vector4 ToVector4(JSONObject obj)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x211C7D0", Offset = "0x211C7D0", VA = "0x211C7D0")]
		public static JSONObject FromMatrix4x4(Matrix4x4 m)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x211CB3C", Offset = "0x211CB3C", VA = "0x211CB3C")]
		public static Matrix4x4 ToMatrix4x4(JSONObject obj)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x211D260", Offset = "0x211D260", VA = "0x211D260")]
		public static JSONObject FromQuaternion(Quaternion q)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x211D3A8", Offset = "0x211D3A8", VA = "0x211D3A8")]
		public static Quaternion ToQuaternion(JSONObject obj)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x211D5C8", Offset = "0x211D5C8", VA = "0x211D5C8")]
		public static JSONObject FromColor(Color c)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x211D710", Offset = "0x211D710", VA = "0x211D710")]
		public static Color ToColor(JSONObject obj)
		{
			return default(Color);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x211D918", Offset = "0x211D918", VA = "0x211D918")]
		public static JSONObject FromLayerMask(LayerMask l)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x211D9B8", Offset = "0x211D9B8", VA = "0x211D9B8")]
		public static LayerMask ToLayerMask(JSONObject obj)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x211DA38", Offset = "0x211DA38", VA = "0x211DA38")]
		public static JSONObject FromRect(Rect r)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x211DBC0", Offset = "0x211DBC0", VA = "0x211DBC0")]
		public static Rect ToRect(JSONObject obj)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x211DDDC", Offset = "0x211DDDC", VA = "0x211DDDC")]
		public static JSONObject FromRectOffset(RectOffset r)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x211DF5C", Offset = "0x211DF5C", VA = "0x211DF5C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83681C", Offset = "0x83681C")]
		private sealed class <>c
		{
			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__21_0;

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x212FC84", Offset = "0x212FC84", VA = "0x212FC84")]
			public <>c()
			{
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x212FC8C", Offset = "0x212FC8C", VA = "0x212FC8C")]
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
			[Address(RVA = "0x20EAB7C", Offset = "0x20EAB7C", VA = "0x20EAB7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x20EAB84", Offset = "0x20EAB84", VA = "0x20EAB84")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x20EAF60", Offset = "0x20EAF60", VA = "0x20EAF60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x20EAF68", Offset = "0x20EAF68", VA = "0x20EAF68")]
			set
			{
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x20EB344", Offset = "0x20EB344", VA = "0x20EB344")]
		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters, bool fuzzy, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x20EB47C", Offset = "0x20EB47C", VA = "0x20EB47C", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x20EBC0C", Offset = "0x20EBC0C", VA = "0x20EBC0C", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x20ED288", Offset = "0x20ED288", VA = "0x20ED288", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x20F12E4", Offset = "0x20F12E4", VA = "0x20F12E4", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x20F55CC", Offset = "0x20F55CC", VA = "0x20F55CC", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83682C", Offset = "0x83682C")]
		private sealed class <>c
		{
			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x2130B84", Offset = "0x2130B84", VA = "0x2130B84")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x2130B8C", Offset = "0x2130B8C", VA = "0x2130B8C")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8369AC", Offset = "0x8369AC")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x1700003E")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x20F7B28", Offset = "0x20F7B28", VA = "0x20F7B28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8388E0", Offset = "0x8388E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x20F7B30", Offset = "0x20F7B30", VA = "0x20F7B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8388F0", Offset = "0x8388F0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public int CharacterNumber
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x20F7B38", Offset = "0x20F7B38", VA = "0x20F7B38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x20F7B40", Offset = "0x20F7B40", VA = "0x20F7B40")]
			set
			{
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x20F7C08", Offset = "0x20F7C08", VA = "0x20F7C08")]
		public CapitalizationFilter(int capitalizationCharsNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x20F7C50", Offset = "0x20F7C50", VA = "0x20F7C50", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x20F7C58", Offset = "0x20F7C58", VA = "0x20F7C58", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x20F7CC4", Offset = "0x20F7CC4", VA = "0x20F7CC4", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x20F8428", Offset = "0x20F8428", VA = "0x20F8428", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x20F8A50", Offset = "0x20F8A50", VA = "0x20F8A50", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83683C", Offset = "0x83683C")]
		private sealed class <>c
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__13_0;

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x1FACED0", Offset = "0x1FACED0", VA = "0x1FACED0")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x1FACED8", Offset = "0x1FACED8", VA = "0x1FACED8")]
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
			[Address(RVA = "0x210BFEC", Offset = "0x210BFEC", VA = "0x210BFEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x210BFF4", Offset = "0x210BFF4", VA = "0x210BFF4")]
			set
			{
			}
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x210C358", Offset = "0x210C358", VA = "0x210C358")]
		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x210C4E8", Offset = "0x210C4E8", VA = "0x210C4E8", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x210C950", Offset = "0x210C950", VA = "0x210C950", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x210D6B0", Offset = "0x210D6B0", VA = "0x210D6B0", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x210F96C", Offset = "0x210F96C", VA = "0x210F96C", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2111E44", Offset = "0x2111E44", VA = "0x2111E44", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83684C", Offset = "0x83684C")]
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
			[Address(RVA = "0x1FADDCC", Offset = "0x1FADDCC", VA = "0x1FADDCC")]
			public <>c()
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1FADDD4", Offset = "0x1FADDD4", VA = "0x1FADDD4")]
			internal string <Sources>b__8_0(KeyValuePair<string, Source> x)
			{
				return null;
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1FADE14", Offset = "0x1FADE14", VA = "0x1FADE14")]
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
		[Address(RVA = "0x211457C", Offset = "0x211457C", VA = "0x211457C", Slot = "9")]
		public virtual List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x21147F4", Offset = "0x21147F4", VA = "0x21147F4", Slot = "10")]
		public virtual string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2114A04", Offset = "0x2114A04", VA = "0x2114A04", Slot = "11")]
		public virtual string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x210D63C", Offset = "0x210D63C", VA = "0x210D63C")]
		protected void logFilterNotReady()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x210D638", Offset = "0x210D638", VA = "0x210D638")]
		protected void logResourceNotFound(string res)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x210D634", Offset = "0x210D634", VA = "0x210D634")]
		protected void logContains()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x210F968", Offset = "0x210F968", VA = "0x210F968")]
		protected void logGetAll()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2111CA8", Offset = "0x2111CA8", VA = "0x2111CA8")]
		protected void logReplaceAll()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x210C438", Offset = "0x210C438", VA = "0x210C438")]
		protected Filter()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class PunctuationFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83685C", Offset = "0x83685C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1FB1FF4", Offset = "0x1FB1FF4", VA = "0x1FB1FF4")]
			public <>c()
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x1FB1FFC", Offset = "0x1FB1FFC", VA = "0x1FB1FFC")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8369BC", Offset = "0x8369BC")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000041")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x2122EAC", Offset = "0x2122EAC", VA = "0x2122EAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838900", Offset = "0x838900")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x2122EB4", Offset = "0x2122EB4", VA = "0x2122EB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838910", Offset = "0x838910")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public int CharacterNumber
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x2122EBC", Offset = "0x2122EBC", VA = "0x2122EBC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x2122EC4", Offset = "0x2122EC4", VA = "0x2122EC4")]
			set
			{
			}
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2122F8C", Offset = "0x2122F8C", VA = "0x2122F8C")]
		public PunctuationFilter(int punctuationCharacterNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2122FD4", Offset = "0x2122FD4", VA = "0x2122FD4", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2122FDC", Offset = "0x2122FDC", VA = "0x2122FDC", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2123048", Offset = "0x2123048", VA = "0x2123048", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x21237AC", Offset = "0x21237AC", VA = "0x21237AC", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2123DCC", Offset = "0x2123DCC", VA = "0x2123DCC", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class BadWordManager : Manager
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83686C", Offset = "0x83686C")]
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
				[Address(RVA = "0x212FEE8", Offset = "0x212FEE8", VA = "0x212FEE8", Slot = "4")]
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
				[Address(RVA = "0x212FF30", Offset = "0x212FF30", VA = "0x212FF30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x212FC94", Offset = "0x212FC94", VA = "0x212FC94")]
			[DebuggerHidden]
			public <initalize>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x212FCC0", Offset = "0x212FCC0", VA = "0x212FCC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x212FCC4", Offset = "0x212FCC4", VA = "0x212FCC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x212FEF0", Offset = "0x212FEF0", VA = "0x212FEF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8369CC", Offset = "0x8369CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8369CC", Offset = "0x8369CC")]
		public List<BadWordProvider> BadWordProviderLTR;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836A2C", Offset = "0x836A2C")]
		public List<BadWordProvider> BadWordProviderRTL;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836A64", Offset = "0x836A64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836A64", Offset = "0x836A64")]
		public string ReplaceChars;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836AC4", Offset = "0x836AC4")]
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
		[Address(RVA = "0x20F58C0", Offset = "0x20F58C0", VA = "0x20F58C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x20F5A98", Offset = "0x20F5A98", VA = "0x20F5A98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838920", Offset = "0x838920")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x20F5B04", Offset = "0x20F5B04", VA = "0x20F5B04")]
		public static BadWordFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x20F5B68", Offset = "0x20F5B68", VA = "0x20F5B68")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x20F5E90", Offset = "0x20F5E90", VA = "0x20F5E90")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x20F5FB0", Offset = "0x20F5FB0", VA = "0x20F5FB0")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x20F60B0", Offset = "0x20F60B0", VA = "0x20F60B0")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x20F61EC", Offset = "0x20F61EC", VA = "0x20F61EC")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x20F62EC", Offset = "0x20F62EC", VA = "0x20F62EC")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x20F63EC", Offset = "0x20F63EC", VA = "0x20F63EC")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x20F6508", Offset = "0x20F6508", VA = "0x20F6508")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x20F5C4C", Offset = "0x20F5C4C", VA = "0x20F5C4C")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x20F6610", Offset = "0x20F6610", VA = "0x20F6610")]
		public BadWordManager()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class CapitalizationManager : Manager
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836AFC", Offset = "0x836AFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836AFC", Offset = "0x836AFC")]
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
		[Address(RVA = "0x20F8CF4", Offset = "0x20F8CF4", VA = "0x20F8CF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x20F8FDC", Offset = "0x20F8FDC", VA = "0x20F8FDC")]
		public static CapitalizationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x20F9040", Offset = "0x20F9040", VA = "0x20F9040")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x20F90B4", Offset = "0x20F90B4", VA = "0x20F90B4")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x20F9418", Offset = "0x20F9418", VA = "0x20F9418")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x20F9518", Offset = "0x20F9518", VA = "0x20F9518")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x20F9654", Offset = "0x20F9654", VA = "0x20F9654")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x20F9754", Offset = "0x20F9754", VA = "0x20F9754")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x20F9854", Offset = "0x20F9854", VA = "0x20F9854")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x20F9970", Offset = "0x20F9970", VA = "0x20F9970")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x20F91D4", Offset = "0x20F91D4", VA = "0x20F91D4")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x20F9A78", Offset = "0x20F9A78", VA = "0x20F9A78")]
		public CapitalizationManager()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class DomainManager : Manager
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83687C", Offset = "0x83687C")]
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
				[Address(RVA = "0x1FAD11C", Offset = "0x1FAD11C", VA = "0x1FAD11C", Slot = "4")]
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
				[Address(RVA = "0x1FAD164", Offset = "0x1FAD164", VA = "0x1FAD164", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1FACEE0", Offset = "0x1FACEE0", VA = "0x1FACEE0")]
			[DebuggerHidden]
			public <initalize>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1FACF0C", Offset = "0x1FACF0C", VA = "0x1FACF0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1FACF10", Offset = "0x1FACF10", VA = "0x1FACF10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1FAD124", Offset = "0x1FAD124", VA = "0x1FAD124", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836B5C", Offset = "0x836B5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836B5C", Offset = "0x836B5C")]
		public List<DomainProvider> DomainProvider;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836BBC", Offset = "0x836BBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836BBC", Offset = "0x836BBC")]
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
		[Address(RVA = "0x2112134", Offset = "0x2112134", VA = "0x2112134")]
		private void Start()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x211230C", Offset = "0x211230C", VA = "0x211230C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838980", Offset = "0x838980")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2112378", Offset = "0x2112378", VA = "0x2112378")]
		public static DomainFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x21123DC", Offset = "0x21123DC", VA = "0x21123DC")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2112704", Offset = "0x2112704", VA = "0x2112704")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2112824", Offset = "0x2112824", VA = "0x2112824")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2112924", Offset = "0x2112924", VA = "0x2112924")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2112A60", Offset = "0x2112A60", VA = "0x2112A60")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2112B60", Offset = "0x2112B60", VA = "0x2112B60")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2112C60", Offset = "0x2112C60", VA = "0x2112C60")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2112D7C", Offset = "0x2112D7C", VA = "0x2112D7C")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x21124C0", Offset = "0x21124C0", VA = "0x21124C0")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2112E84", Offset = "0x2112E84", VA = "0x2112E84")]
		public DomainManager()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public abstract class Manager : MonoBehaviour
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836C1C", Offset = "0x836C1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836C1C", Offset = "0x836C1C")]
		public string MarkPrefix;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836C7C", Offset = "0x836C7C")]
		public string MarkPostfix;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1987CDC", Offset = "0x1987CDC", VA = "0x1987CDC")]
		protected Manager()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class PunctuationManager : Manager
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836CB4", Offset = "0x836CB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836CB4", Offset = "0x836CB4")]
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
		[Address(RVA = "0x2124080", Offset = "0x2124080", VA = "0x2124080")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2124368", Offset = "0x2124368", VA = "0x2124368")]
		public static PunctuationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x21243CC", Offset = "0x21243CC", VA = "0x21243CC")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2124440", Offset = "0x2124440", VA = "0x2124440")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x21247A4", Offset = "0x21247A4", VA = "0x21247A4")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x21248A4", Offset = "0x21248A4", VA = "0x21248A4")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x21249E0", Offset = "0x21249E0", VA = "0x21249E0")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2124AE0", Offset = "0x2124AE0", VA = "0x2124AE0")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2124BE0", Offset = "0x2124BE0", VA = "0x2124BE0")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2124CFC", Offset = "0x2124CFC", VA = "0x2124CFC")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2124560", Offset = "0x2124560", VA = "0x2124560")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2124E04", Offset = "0x2124E04", VA = "0x2124E04")]
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
		[Address(RVA = "0x20F792C", Offset = "0x20F792C", VA = "0x20F792C")]
		public BadWords(Source source, List<string> badWordList)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x20F7964", Offset = "0x20F7964", VA = "0x20F7964", Slot = "3")]
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
		[Address(RVA = "0x2114004", Offset = "0x2114004", VA = "0x2114004")]
		public Domains(Source source, List<string> domainList)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x211403C", Offset = "0x211403C", VA = "0x211403C", Slot = "3")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836D14", Offset = "0x836D14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836D14", Offset = "0x836D14")]
		public string Name;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836D74", Offset = "0x836D74")]
		public string Description;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836DAC", Offset = "0x836DAC")]
		public Sprite Icon;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2127304", Offset = "0x2127304", VA = "0x2127304", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x21274D8", Offset = "0x21274D8", VA = "0x21274D8")]
		protected Source()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public static class MultiManager
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83688C", Offset = "0x83688C")]
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
			[Address(RVA = "0x1FB1F6C", Offset = "0x1FB1F6C", VA = "0x1FB1F6C")]
			public <>c()
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1FB1F74", Offset = "0x1FB1F74", VA = "0x1FB1F74")]
			internal string <Sources>b__2_0(Source x)
			{
				return null;
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x1FB1F8C", Offset = "0x1FB1F8C", VA = "0x1FB1F8C")]
			internal string <GetAll>b__4_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1989950", Offset = "0x1989950", VA = "0x1989950")]
		public static Filter Filter(ManagerMask mask = ManagerMask.BadWord)
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1989B54", Offset = "0x1989B54", VA = "0x1989B54")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1989C68", Offset = "0x1989C68", VA = "0x1989C68")]
		public static List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1989F54", Offset = "0x1989F54", VA = "0x1989F54")]
		public static bool Contains(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x198A1F8", Offset = "0x198A1F8", VA = "0x198A1F8")]
		public static List<string> GetAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x198A538", Offset = "0x198A538", VA = "0x198A538")]
		public static string ReplaceAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x198A6D4", Offset = "0x198A6D4", VA = "0x198A6D4")]
		public static string Replace(string text, List<string> badWords, ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x198A870", Offset = "0x198A870", VA = "0x198A870")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x198A920", Offset = "0x198A920", VA = "0x198A920")]
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
			[Address(RVA = "0x20F6668", Offset = "0x20F6668", VA = "0x20F6668")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x20F6670", Offset = "0x20F6670", VA = "0x20F6670")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Dictionary<string, Regex> FuzzyBadwordsRegex
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x20F6678", Offset = "0x20F6678", VA = "0x20F6678")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x20F6680", Offset = "0x20F6680", VA = "0x20F6680")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x20F6688", Offset = "0x20F6688", VA = "0x20F6688")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x20F6690", Offset = "0x20F6690", VA = "0x20F6690")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Dictionary<string, List<Regex>> DebugFuzzyBadwordsRegex
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x20F6698", Offset = "0x20F6698", VA = "0x20F6698")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x20F66A0", Offset = "0x20F66A0", VA = "0x20F66A0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x20F66A8", Offset = "0x20F66A8", VA = "0x20F66A8", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x20F7294", Offset = "0x20F7294", VA = "0x20F7294")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836DE4", Offset = "0x836DE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836DE4", Offset = "0x836DE4")]
		public string File;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836E44", Offset = "0x836E44")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836E7C", Offset = "0x836E7C")]
		public int SkipFooterLines;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836EB4", Offset = "0x836EB4")]
		public char SplitChar;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x20EAB18", Offset = "0x20EAB18", VA = "0x20EAB18")]
		public BadWordFile()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class BadWordProviderFile : BadWordProvider
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83689C", Offset = "0x83689C")]
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
				[Address(RVA = "0x212FF9C", Offset = "0x212FF9C", VA = "0x212FF9C", Slot = "4")]
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
				[Address(RVA = "0x212FFE4", Offset = "0x212FFE4", VA = "0x212FFE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x212FF38", Offset = "0x212FF38", VA = "0x212FF38")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x212FF64", Offset = "0x212FF64", VA = "0x212FF64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x212FF68", Offset = "0x212FF68", VA = "0x212FF68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x212FFA4", Offset = "0x212FFA4", VA = "0x212FFA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836EEC", Offset = "0x836EEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836EEC", Offset = "0x836EEC")]
		public string FilePathWindows;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836F4C", Offset = "0x836F4C")]
		public string FilePathOSX;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836F84", Offset = "0x836F84")]
		public string FilePathLinux;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836FBC", Offset = "0x836FBC")]
		public BadWordFile[] Resources;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x20F73F0", Offset = "0x20F73F0", VA = "0x20F73F0", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x20F7504", Offset = "0x20F7504", VA = "0x20F7504", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x20F7578", Offset = "0x20F7578", VA = "0x20F7578")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8389E0", Offset = "0x8389E0")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x20F75D4", Offset = "0x20F75D4", VA = "0x20F75D4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x836FF4", Offset = "0x836FF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x836FF4", Offset = "0x836FF4")]
		public TextAsset Resource;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837054", Offset = "0x837054")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83708C", Offset = "0x83708C")]
		public int SkipFooterLines;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8370C4", Offset = "0x8370C4")]
		public char SplitChar;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x20F78B8", Offset = "0x20F78B8", VA = "0x20F78B8")]
		public BadWordResource()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class BadWordProviderResource : BadWordProvider
	{
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368AC", Offset = "0x8368AC")]
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
				[Address(RVA = "0x213037C", Offset = "0x213037C", VA = "0x213037C", Slot = "4")]
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
				[Address(RVA = "0x21303C4", Offset = "0x21303C4", VA = "0x21303C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x212FFEC", Offset = "0x212FFEC", VA = "0x212FFEC")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x2130018", Offset = "0x2130018", VA = "0x2130018", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x213001C", Offset = "0x213001C", VA = "0x213001C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x2130384", Offset = "0x2130384", VA = "0x2130384", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8370FC", Offset = "0x8370FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8370FC", Offset = "0x8370FC")]
		public BadWordResource[] Resources;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x20F7644", Offset = "0x20F7644", VA = "0x20F7644", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x20F76DC", Offset = "0x20F76DC", VA = "0x20F76DC", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x20F7670", Offset = "0x20F7670", VA = "0x20F7670")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838A40", Offset = "0x838A40")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x20F7750", Offset = "0x20F7750", VA = "0x20F7750")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83715C", Offset = "0x83715C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83715C", Offset = "0x83715C")]
		public string URL;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8371BC", Offset = "0x8371BC")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8371F4", Offset = "0x8371F4")]
		public int SkipFooterLines;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83722C", Offset = "0x83722C")]
		public char SplitChar;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x20F78C8", Offset = "0x20F78C8", VA = "0x20F78C8")]
		public BadWordWeb()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class BadWordProviderWeb : BadWordProvider
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368BC", Offset = "0x8368BC")]
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
				[Address(RVA = "0x2130AD4", Offset = "0x2130AD4", VA = "0x2130AD4", Slot = "4")]
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
				[Address(RVA = "0x2130B1C", Offset = "0x2130B1C", VA = "0x2130B1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x21303CC", Offset = "0x21303CC", VA = "0x21303CC")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x21303F8", Offset = "0x21303F8", VA = "0x21303F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x21303FC", Offset = "0x21303FC", VA = "0x21303FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x2130ADC", Offset = "0x2130ADC", VA = "0x2130ADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x837264", Offset = "0x837264")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837264", Offset = "0x837264")]
		public string MainURL;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8372C4", Offset = "0x8372C4")]
		public BadWordWeb[] Resources;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x20F7754", Offset = "0x20F7754", VA = "0x20F7754", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x20F77EC", Offset = "0x20F77EC", VA = "0x20F77EC", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x20F7780", Offset = "0x20F7780", VA = "0x20F7780")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838AA0", Offset = "0x838AA0")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x20F7860", Offset = "0x20F7860", VA = "0x20F7860")]
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
			[Address(RVA = "0x2112EDC", Offset = "0x2112EDC", VA = "0x2112EDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2112EE4", Offset = "0x2112EE4", VA = "0x2112EE4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x2112EEC", Offset = "0x2112EEC", VA = "0x2112EEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x2112EF4", Offset = "0x2112EF4", VA = "0x2112EF4")]
			protected set
			{
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x2112EFC", Offset = "0x2112EFC", VA = "0x2112EFC", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x21138F8", Offset = "0x21138F8", VA = "0x21138F8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8372FC", Offset = "0x8372FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8372FC", Offset = "0x8372FC")]
		public string File;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83735C", Offset = "0x83735C")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837394", Offset = "0x837394")]
		public int SkipFooterLines;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8373CC", Offset = "0x8373CC")]
		public char SplitChar;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x210BF88", Offset = "0x210BF88", VA = "0x210BF88")]
		public DomainFile()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class DomainProviderFile : DomainProvider
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368CC", Offset = "0x8368CC")]
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
				[Address(RVA = "0x1FAD1D0", Offset = "0x1FAD1D0", VA = "0x1FAD1D0", Slot = "4")]
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
				[Address(RVA = "0x1FAD218", Offset = "0x1FAD218", VA = "0x1FAD218", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1FAD16C", Offset = "0x1FAD16C", VA = "0x1FAD16C")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1FAD198", Offset = "0x1FAD198", VA = "0x1FAD198", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1FAD19C", Offset = "0x1FAD19C", VA = "0x1FAD19C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1FAD1D8", Offset = "0x1FAD1D8", VA = "0x1FAD1D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x837404", Offset = "0x837404")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837404", Offset = "0x837404")]
		public string FilePathWindows;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837464", Offset = "0x837464")]
		public string FilePathOSX;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83749C", Offset = "0x83749C")]
		public string FilePathLinux;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8374D4", Offset = "0x8374D4")]
		public DomainFile[] Resources;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2113A1C", Offset = "0x2113A1C", VA = "0x2113A1C", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2113BDC", Offset = "0x2113BDC", VA = "0x2113BDC", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2113C50", Offset = "0x2113C50", VA = "0x2113C50")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838B00", Offset = "0x838B00")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2113CAC", Offset = "0x2113CAC", VA = "0x2113CAC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83750C", Offset = "0x83750C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83750C", Offset = "0x83750C")]
		public TextAsset Resource;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83756C", Offset = "0x83756C")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8375A4", Offset = "0x8375A4")]
		public int SkipFooterLines;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8375DC", Offset = "0x8375DC")]
		public char SplitChar;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2113F90", Offset = "0x2113F90", VA = "0x2113F90")]
		public DomainResource()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class DomainProviderResource : DomainProvider
	{
		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368DC", Offset = "0x8368DC")]
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
				[Address(RVA = "0x1FAD5B4", Offset = "0x1FAD5B4", VA = "0x1FAD5B4", Slot = "4")]
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
				[Address(RVA = "0x1FAD5FC", Offset = "0x1FAD5FC", VA = "0x1FAD5FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1FAD220", Offset = "0x1FAD220", VA = "0x1FAD220")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1FAD24C", Offset = "0x1FAD24C", VA = "0x1FAD24C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x1FAD250", Offset = "0x1FAD250", VA = "0x1FAD250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1FAD5BC", Offset = "0x1FAD5BC", VA = "0x1FAD5BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x837614", Offset = "0x837614")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837614", Offset = "0x837614")]
		public DomainResource[] Resources;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2113D1C", Offset = "0x2113D1C", VA = "0x2113D1C", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2113DB4", Offset = "0x2113DB4", VA = "0x2113DB4", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2113D48", Offset = "0x2113D48", VA = "0x2113D48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838B60", Offset = "0x838B60")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2113E28", Offset = "0x2113E28", VA = "0x2113E28")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x837674", Offset = "0x837674")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837674", Offset = "0x837674")]
		public string URL;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8376D4", Offset = "0x8376D4")]
		public int SkipHeaderLines;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83770C", Offset = "0x83770C")]
		public int SkipFooterLines;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837744", Offset = "0x837744")]
		public char SplitChar;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2113FA0", Offset = "0x2113FA0", VA = "0x2113FA0")]
		public DomainWeb()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class DomainProviderWeb : DomainProvider
	{
		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368EC", Offset = "0x8368EC")]
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
				[Address(RVA = "0x1FADD1C", Offset = "0x1FADD1C", VA = "0x1FADD1C", Slot = "4")]
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
				[Address(RVA = "0x1FADD64", Offset = "0x1FADD64", VA = "0x1FADD64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1FAD604", Offset = "0x1FAD604", VA = "0x1FAD604")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x1FAD630", Offset = "0x1FAD630", VA = "0x1FAD630", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x1FAD634", Offset = "0x1FAD634", VA = "0x1FAD634", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x1FADD24", Offset = "0x1FADD24", VA = "0x1FADD24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83777C", Offset = "0x83777C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83777C", Offset = "0x83777C")]
		public string MainURL;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8377DC", Offset = "0x8377DC")]
		public DomainWeb[] Resources;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2113E2C", Offset = "0x2113E2C", VA = "0x2113E2C", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2113EC4", Offset = "0x2113EC4", VA = "0x2113EC4", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2113E58", Offset = "0x2113E58", VA = "0x2113E58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838BC0", Offset = "0x838BC0")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2113F38", Offset = "0x2113F38", VA = "0x2113F38")]
		public DomainProviderWeb()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class Provider : MonoBehaviour
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837814", Offset = "0x837814")]
		public string Name;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83784C", Offset = "0x83784C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83784C", Offset = "0x83784C")]
		public RegexOptions RegexOption1;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8378AC", Offset = "0x8378AC")]
		public RegexOptions RegexOption2;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8378E4", Offset = "0x8378E4")]
		public RegexOptions RegexOption3;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83791C", Offset = "0x83791C")]
		public RegexOptions RegexOption4;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837954", Offset = "0x837954")]
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
			[Address(RVA = "0x2122BE4", Offset = "0x2122BE4", VA = "0x2122BE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x2122BEC", Offset = "0x2122BEC", VA = "0x2122BEC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public List<Source> Sources
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x2122BF8", Offset = "0x2122BF8", VA = "0x2122BF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x2122C00", Offset = "0x2122C00", VA = "0x2122C00")]
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
		[Address(RVA = "0x2122C08", Offset = "0x2122C08", VA = "0x2122C08")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x2122C14", Offset = "0x2122C14", VA = "0x2122C14")]
		protected void logNoResourcesAdded()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2122E00", Offset = "0x2122E00", VA = "0x2122E00")]
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
		[Address(RVA = "0x2114B30", Offset = "0x2114B30", VA = "0x2114B30")]
		public static bool WindowsPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2114B68", Offset = "0x2114B68", VA = "0x2114B68")]
		public static bool OSXPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x2114B98", Offset = "0x2114B98", VA = "0x2114B98")]
		public static bool LinuxPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x2113B2C", Offset = "0x2113B2C", VA = "0x2113B2C")]
		public static bool SupportedPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2114BB8", Offset = "0x2114BB8", VA = "0x2114BB8")]
		public static string ValidatePath(string path)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2114C5C", Offset = "0x2114C5C", VA = "0x2114C5C")]
		public static List<string> SplitStringToLines(string text, int skipHeaderLines = 0, int skipFooterLines = 0, char splitChar = '#')
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2111CAC", Offset = "0x2111CAC", VA = "0x2111CAC")]
		public static string CreateReplaceString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		public static void AddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2114F14", Offset = "0x2114F14", VA = "0x2114F14")]
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
		[Address(RVA = "0x212F688", Offset = "0x212F688", VA = "0x212F688")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return default(uint);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x212FA48", Offset = "0x212FA48", VA = "0x212FA48")]
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
		[Address(RVA = "0x198A9C0", Offset = "0x198A9C0", VA = "0x198A9C0")]
		private ObscuredBool(int value)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x198AA48", Offset = "0x198AA48", VA = "0x198AA48")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x198AAB0", Offset = "0x198AAB0", VA = "0x198AAB0")]
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x198AB14", Offset = "0x198AB14", VA = "0x198AB14")]
		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x198ABA8", Offset = "0x198ABA8", VA = "0x198ABA8")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x198AC0C", Offset = "0x198AC0C", VA = "0x198AC0C")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x198AC98", Offset = "0x198AC98", VA = "0x198AC98")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x198AE80", Offset = "0x198AE80", VA = "0x198AE80")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x198AF18", Offset = "0x198AF18", VA = "0x198AF18")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x198AF3C", Offset = "0x198AF3C", VA = "0x198AF3C")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x198AD64", Offset = "0x198AD64", VA = "0x198AD64")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x198AFE4", Offset = "0x198AFE4", VA = "0x198AFE4")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x198B08C", Offset = "0x198B08C", VA = "0x198B08C")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x198B0B8", Offset = "0x198B0B8", VA = "0x198B0B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x198B144", Offset = "0x198B144", VA = "0x198B144", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x198B1F4", Offset = "0x198B1F4", VA = "0x198B1F4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x198B224", Offset = "0x198B224", VA = "0x198B224", Slot = "3")]
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
		[Address(RVA = "0x198B2A4", Offset = "0x198B2A4", VA = "0x198B2A4")]
		private ObscuredByte(byte value)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x198B328", Offset = "0x198B328", VA = "0x198B328")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x198B390", Offset = "0x198B390", VA = "0x198B390")]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x198B3F4", Offset = "0x198B3F4", VA = "0x198B3F4")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x198B474", Offset = "0x198B474", VA = "0x198B474")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x198B678", Offset = "0x198B678", VA = "0x198B678")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x198B710", Offset = "0x198B710", VA = "0x198B710")]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x198B734", Offset = "0x198B734", VA = "0x198B734")]
		public void SetEncrypted(byte encrypted)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x198B540", Offset = "0x198B540", VA = "0x198B540")]
		private byte InternalDecrypt()
		{
			return default(byte);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x198B770", Offset = "0x198B770", VA = "0x198B770")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x198B7FC", Offset = "0x198B7FC", VA = "0x198B7FC")]
		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x198B820", Offset = "0x198B820", VA = "0x198B820")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x198B8B8", Offset = "0x198B8B8", VA = "0x198B8B8")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x198B950", Offset = "0x198B950", VA = "0x198B950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x198B9D8", Offset = "0x198B9D8", VA = "0x198B9D8", Slot = "4")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x198BA84", Offset = "0x198BA84", VA = "0x198BA84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x198BAB0", Offset = "0x198BAB0", VA = "0x198BAB0")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x198BAE4", Offset = "0x198BAE4", VA = "0x198BAE4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x198BB10", Offset = "0x198BB10", VA = "0x198BB10")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x198BB44", Offset = "0x198BB44", VA = "0x198BB44", Slot = "5")]
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
		[Address(RVA = "0x198BBD8", Offset = "0x198BBD8", VA = "0x198BBD8")]
		private ObscuredChar(char value)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x198BC60", Offset = "0x198BC60", VA = "0x198BC60")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x198BCC8", Offset = "0x198BCC8", VA = "0x198BCC8")]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x198BD2C", Offset = "0x198BD2C", VA = "0x198BD2C")]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x198BDAC", Offset = "0x198BDAC", VA = "0x198BDAC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x198BFB4", Offset = "0x198BFB4", VA = "0x198BFB4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x198C04C", Offset = "0x198C04C", VA = "0x198C04C")]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x198C070", Offset = "0x198C070", VA = "0x198C070")]
		public void SetEncrypted(char encrypted)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x198BE78", Offset = "0x198BE78", VA = "0x198BE78")]
		private char InternalDecrypt()
		{
			return default(char);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x198C0AC", Offset = "0x198C0AC", VA = "0x198C0AC")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x198C138", Offset = "0x198C138", VA = "0x198C138")]
		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x198C15C", Offset = "0x198C15C", VA = "0x198C15C")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x198C1F4", Offset = "0x198C1F4", VA = "0x198C1F4")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x198C28C", Offset = "0x198C28C", VA = "0x198C28C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x198C314", Offset = "0x198C314", VA = "0x198C314", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x198C3BC", Offset = "0x198C3BC", VA = "0x198C3BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x198C3E8", Offset = "0x198C3E8", VA = "0x198C3E8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x198C41C", Offset = "0x198C41C", VA = "0x198C41C", Slot = "2")]
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
		[Address(RVA = "0x198D084", Offset = "0x198D084", VA = "0x198D084")]
		private ObscuredDecimal(byte[] value)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x198D108", Offset = "0x198D108", VA = "0x198D108")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x198D170", Offset = "0x198D170", VA = "0x198D170")]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x198D1EC", Offset = "0x198D1EC", VA = "0x198D1EC")]
		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x198D1F8", Offset = "0x198D1F8", VA = "0x198D1F8")]
		private static byte[] InternalEncrypt(decimal value)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x198D26C", Offset = "0x198D26C", VA = "0x198D26C")]
		private static byte[] InternalEncrypt(decimal value, long key)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x198D41C", Offset = "0x198D41C", VA = "0x198D41C")]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x198D498", Offset = "0x198D498", VA = "0x198D498")]
		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x198D4A4", Offset = "0x198D4A4", VA = "0x198D4A4")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x198D800", Offset = "0x198D800", VA = "0x198D800")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x198D8A0", Offset = "0x198D8A0", VA = "0x198D8A0")]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x198D998", Offset = "0x198D998", VA = "0x198D998")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x198D574", Offset = "0x198D574", VA = "0x198D574")]
		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x198DB24", Offset = "0x198DB24", VA = "0x198DB24")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x198DBE0", Offset = "0x198DBE0", VA = "0x198DBE0")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x198DBE4", Offset = "0x198DBE4", VA = "0x198DBE4")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x198DD1C", Offset = "0x198DD1C", VA = "0x198DD1C")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x198DE20", Offset = "0x198DE20", VA = "0x198DE20")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x198DF24", Offset = "0x198DF24", VA = "0x198DF24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x198DF50", Offset = "0x198DF50", VA = "0x198DF50")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x198DF8C", Offset = "0x198DF8C", VA = "0x198DF8C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x198DFC8", Offset = "0x198DFC8", VA = "0x198DFC8", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x198E00C", Offset = "0x198E00C", VA = "0x198E00C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x198E0A8", Offset = "0x198E0A8", VA = "0x198E0A8", Slot = "4")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x198E100", Offset = "0x198E100", VA = "0x198E100", Slot = "2")]
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
		[Address(RVA = "0x198E180", Offset = "0x198E180", VA = "0x198E180")]
		private ObscuredDouble(byte[] value)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x198E204", Offset = "0x198E204", VA = "0x198E204")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x198E26C", Offset = "0x198E26C", VA = "0x198E26C")]
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x198E2E4", Offset = "0x198E2E4", VA = "0x198E2E4")]
		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x198E2F0", Offset = "0x198E2F0", VA = "0x198E2F0")]
		private static byte[] InternalEncrypt(double value)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x198E35C", Offset = "0x198E35C", VA = "0x198E35C")]
		private static byte[] InternalEncrypt(double value, long key)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x198E48C", Offset = "0x198E48C", VA = "0x198E48C")]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x198E4FC", Offset = "0x198E4FC", VA = "0x198E4FC")]
		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x198E508", Offset = "0x198E508", VA = "0x198E508")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x198E7AC", Offset = "0x198E7AC", VA = "0x198E7AC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x198E844", Offset = "0x198E844", VA = "0x198E844")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x198E8F8", Offset = "0x198E8F8", VA = "0x198E8F8")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x198E5D8", Offset = "0x198E5D8", VA = "0x198E5D8")]
		private double InternalDecrypt()
		{
			return default(double);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x198EA04", Offset = "0x198EA04", VA = "0x198EA04")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x198EAA4", Offset = "0x198EAA4", VA = "0x198EAA4")]
		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x198EAA8", Offset = "0x198EAA8", VA = "0x198EAA8")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x198EB50", Offset = "0x198EB50", VA = "0x198EB50")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x198EBF8", Offset = "0x198EBF8", VA = "0x198EBF8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x198EC24", Offset = "0x198EC24", VA = "0x198EC24")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x198EC58", Offset = "0x198EC58", VA = "0x198EC58")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x198EC8C", Offset = "0x198EC8C", VA = "0x198EC8C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x198ECD0", Offset = "0x198ECD0", VA = "0x198ECD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x198ED64", Offset = "0x198ED64", VA = "0x198ED64", Slot = "4")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x198EDA4", Offset = "0x198EDA4", VA = "0x198EDA4", Slot = "2")]
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
		[Address(RVA = "0x198EE24", Offset = "0x198EE24", VA = "0x198EE24")]
		private ObscuredFloat(byte[] value)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x198EEAC", Offset = "0x198EEAC", VA = "0x198EEAC")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x198EF14", Offset = "0x198EF14", VA = "0x198EF14")]
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x198EF8C", Offset = "0x198EF8C", VA = "0x198EF8C")]
		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x198EF98", Offset = "0x198EF98", VA = "0x198EF98")]
		private static byte[] InternalEncrypt(float value)
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x198F004", Offset = "0x198F004", VA = "0x198F004")]
		private static byte[] InternalEncrypt(float value, int key)
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x198F0F4", Offset = "0x198F0F4", VA = "0x198F0F4")]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x198F164", Offset = "0x198F164", VA = "0x198F164")]
		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x198F170", Offset = "0x198F170", VA = "0x198F170")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x198F3D4", Offset = "0x198F3D4", VA = "0x198F3D4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x198F46C", Offset = "0x198F46C", VA = "0x198F46C")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x198F4E0", Offset = "0x198F4E0", VA = "0x198F4E0")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x198F240", Offset = "0x198F240", VA = "0x198F240")]
		private float InternalDecrypt()
		{
			return default(float);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x198F5AC", Offset = "0x198F5AC", VA = "0x198F5AC")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x198DD18", Offset = "0x198DD18", VA = "0x198DD18")]
		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x198F654", Offset = "0x198F654", VA = "0x198F654")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x198F704", Offset = "0x198F704", VA = "0x198F704")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x198F7B4", Offset = "0x198F7B4", VA = "0x198F7B4")]
		public float getValue()
		{
			return default(float);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x198F7B8", Offset = "0x198F7B8", VA = "0x198F7B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x198F854", Offset = "0x198F854", VA = "0x198F854", Slot = "4")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x198F89C", Offset = "0x198F89C", VA = "0x198F89C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x198F8C8", Offset = "0x198F8C8", VA = "0x198F8C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x198F8F4", Offset = "0x198F8F4", VA = "0x198F8F4")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x198F928", Offset = "0x198F928", VA = "0x198F928")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x198F95C", Offset = "0x198F95C", VA = "0x198F95C", Slot = "5")]
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
		[Address(RVA = "0x198F9F4", Offset = "0x198F9F4", VA = "0x198F9F4")]
		private ObscuredInt(int value)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x198FA78", Offset = "0x198FA78", VA = "0x198FA78")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x198FAE0", Offset = "0x198FAE0", VA = "0x198FAE0")]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x198FB44", Offset = "0x198FB44", VA = "0x198FB44")]
		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x198FBC0", Offset = "0x198FBC0", VA = "0x198FBC0")]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x198FC24", Offset = "0x198FC24", VA = "0x198FC24")]
		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x198FCA0", Offset = "0x198FCA0", VA = "0x198FCA0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x198FEA0", Offset = "0x198FEA0", VA = "0x198FEA0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x198FF3C", Offset = "0x198FF3C", VA = "0x198FF3C")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x198FF60", Offset = "0x198FF60", VA = "0x198FF60")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x198FD6C", Offset = "0x198FD6C", VA = "0x198FD6C")]
		private int InternalDecrypt()
		{
			return default(int);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x198FF9C", Offset = "0x198FF9C", VA = "0x198FF9C")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1990028", Offset = "0x1990028", VA = "0x1990028")]
		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x199004C", Offset = "0x199004C", VA = "0x199004C")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1990150", Offset = "0x1990150", VA = "0x1990150")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x19901E8", Offset = "0x19901E8", VA = "0x19901E8")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1990280", Offset = "0x1990280", VA = "0x1990280")]
		public int getValue()
		{
			return default(int);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1990284", Offset = "0x1990284", VA = "0x1990284", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x199030C", Offset = "0x199030C", VA = "0x199030C", Slot = "4")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x19903B4", Offset = "0x19903B4", VA = "0x19903B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x19903E0", Offset = "0x19903E0", VA = "0x19903E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x199040C", Offset = "0x199040C", VA = "0x199040C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1990440", Offset = "0x1990440", VA = "0x1990440")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1990474", Offset = "0x1990474", VA = "0x1990474", Slot = "5")]
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
		[Address(RVA = "0x199050C", Offset = "0x199050C", VA = "0x199050C")]
		private ObscuredLong(long value)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1990590", Offset = "0x1990590", VA = "0x1990590")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x19905F8", Offset = "0x19905F8", VA = "0x19905F8")]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x19906D8", Offset = "0x19906D8", VA = "0x19906D8")]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x199065C", Offset = "0x199065C", VA = "0x199065C")]
		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x199073C", Offset = "0x199073C", VA = "0x199073C")]
		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x19907B8", Offset = "0x19907B8", VA = "0x19907B8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x19909B8", Offset = "0x19909B8", VA = "0x19909B8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1990A50", Offset = "0x1990A50", VA = "0x1990A50")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1990A74", Offset = "0x1990A74", VA = "0x1990A74")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1990884", Offset = "0x1990884", VA = "0x1990884")]
		private long InternalDecrypt()
		{
			return default(long);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1990AB0", Offset = "0x1990AB0", VA = "0x1990AB0")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1990B50", Offset = "0x1990B50", VA = "0x1990B50")]
		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1990B54", Offset = "0x1990B54", VA = "0x1990B54")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1990BF4", Offset = "0x1990BF4", VA = "0x1990BF4")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1990C94", Offset = "0x1990C94", VA = "0x1990C94", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1990D28", Offset = "0x1990D28", VA = "0x1990D28", Slot = "4")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1990DD0", Offset = "0x1990DD0", VA = "0x1990DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1990DFC", Offset = "0x1990DFC", VA = "0x1990DFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1990E28", Offset = "0x1990E28", VA = "0x1990E28")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1990E5C", Offset = "0x1990E5C", VA = "0x1990E5C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1990E90", Offset = "0x1990E90", VA = "0x1990E90", Slot = "5")]
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
			[Address(RVA = "0x1994328", Offset = "0x1994328", VA = "0x1994328")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1994450", Offset = "0x1994450", VA = "0x1994450")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x839890", Offset = "0x839890")]
		internal static string DeviceID
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x199458C", Offset = "0x199458C", VA = "0x199458C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x199464C", Offset = "0x199464C", VA = "0x199464C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x19946CC", Offset = "0x19946CC", VA = "0x19946CC")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700004E")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1999644", Offset = "0x1999644", VA = "0x1999644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1994788", Offset = "0x1994788", VA = "0x1994788")]
		public static void ForceLockToDeviceInit()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x199488C", Offset = "0x199488C", VA = "0x199488C")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1993B7C", Offset = "0x1993B7C", VA = "0x1993B7C")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1994ACC", Offset = "0x1994ACC", VA = "0x1994ACC")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1993D20", Offset = "0x1993D20", VA = "0x1993D20")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1994A18", Offset = "0x1994A18", VA = "0x1994A18")]
		private static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1994C34", Offset = "0x1994C34", VA = "0x1994C34")]
		private static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1995A18", Offset = "0x1995A18", VA = "0x1995A18")]
		public static void SetUInt(string key, uint value)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1995B58", Offset = "0x1995B58", VA = "0x1995B58")]
		public static uint GetUInt(string key)
		{
			return default(uint);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1995BBC", Offset = "0x1995BBC", VA = "0x1995BBC")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1995AA4", Offset = "0x1995AA4", VA = "0x1995AA4")]
		private static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1995C98", Offset = "0x1995C98", VA = "0x1995C98")]
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1993C94", Offset = "0x1993C94", VA = "0x1993C94")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1995F40", Offset = "0x1995F40", VA = "0x1995F40")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1994034", Offset = "0x1994034", VA = "0x1994034")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1995E0C", Offset = "0x1995E0C", VA = "0x1995E0C")]
		public static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1995FB8", Offset = "0x1995FB8", VA = "0x1995FB8")]
		public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1993C08", Offset = "0x1993C08", VA = "0x1993C08")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1996248", Offset = "0x1996248", VA = "0x1996248")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1993EA8", Offset = "0x1993EA8", VA = "0x1993EA8")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1996194", Offset = "0x1996194", VA = "0x1996194")]
		private static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x19962AC", Offset = "0x19962AC", VA = "0x19962AC")]
		private static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1996428", Offset = "0x1996428", VA = "0x1996428")]
		public static void SetDouble(string key, double value)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1996568", Offset = "0x1996568", VA = "0x1996568")]
		public static double GetDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x19965CC", Offset = "0x19965CC", VA = "0x19965CC")]
		public static double GetDouble(string key, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x19964B4", Offset = "0x19964B4", VA = "0x19964B4")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x19966B4", Offset = "0x19966B4", VA = "0x19966B4")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x199685C", Offset = "0x199685C", VA = "0x199685C")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x199699C", Offset = "0x199699C", VA = "0x199699C")]
		public static long GetLong(string key)
		{
			return default(long);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1996A00", Offset = "0x1996A00", VA = "0x1996A00")]
		public static long GetLong(string key, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x19968E8", Offset = "0x19968E8", VA = "0x19968E8")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1996ADC", Offset = "0x1996ADC", VA = "0x1996ADC")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1996C50", Offset = "0x1996C50", VA = "0x1996C50")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1996D90", Offset = "0x1996D90", VA = "0x1996D90")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1996DF4", Offset = "0x1996DF4", VA = "0x1996DF4")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1996CDC", Offset = "0x1996CDC", VA = "0x1996CDC")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1996ED0", Offset = "0x1996ED0", VA = "0x1996ED0")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1997050", Offset = "0x1997050", VA = "0x1997050")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1997150", Offset = "0x1997150", VA = "0x1997150")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x19971B8", Offset = "0x19971B8", VA = "0x19971B8")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x19970DC", Offset = "0x19970DC", VA = "0x19970DC")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1997364", Offset = "0x1997364", VA = "0x1997364")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x19972C4", Offset = "0x19972C4", VA = "0x19972C4")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x19974DC", Offset = "0x19974DC", VA = "0x19974DC")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1997684", Offset = "0x1997684", VA = "0x1997684")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1997704", Offset = "0x1997704", VA = "0x1997704")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1997570", Offset = "0x1997570", VA = "0x1997570")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x19977F0", Offset = "0x19977F0", VA = "0x19977F0")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1997A34", Offset = "0x1997A34", VA = "0x1997A34")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1997C1C", Offset = "0x1997C1C", VA = "0x1997C1C")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1997CAC", Offset = "0x1997CAC", VA = "0x1997CAC")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1997AD8", Offset = "0x1997AD8", VA = "0x1997AD8")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1997DB0", Offset = "0x1997DB0", VA = "0x1997DB0")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1998040", Offset = "0x1998040", VA = "0x1998040")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1998258", Offset = "0x1998258", VA = "0x1998258")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x19982F0", Offset = "0x19982F0", VA = "0x19982F0")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x19980EC", Offset = "0x19980EC", VA = "0x19980EC")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1998404", Offset = "0x1998404", VA = "0x1998404")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x19986EC", Offset = "0x19986EC", VA = "0x19986EC")]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1998838", Offset = "0x1998838", VA = "0x1998838")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x19988CC", Offset = "0x19988CC", VA = "0x19988CC")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1998784", Offset = "0x1998784", VA = "0x1998784")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x19989D0", Offset = "0x19989D0", VA = "0x19989D0")]
		public static void SetRect(string key, Rect value)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1998C08", Offset = "0x1998C08", VA = "0x1998C08")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1998C9C", Offset = "0x1998C9C", VA = "0x1998C9C")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1998A7C", Offset = "0x1998A7C", VA = "0x1998A7C")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1998DB0", Offset = "0x1998DB0", VA = "0x1998DB0")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x19990C8", Offset = "0x19990C8", VA = "0x19990C8")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1999140", Offset = "0x1999140", VA = "0x1999140")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x19991A8", Offset = "0x19991A8", VA = "0x19991A8")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x19941BC", Offset = "0x19941BC", VA = "0x19941BC")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1999230", Offset = "0x1999230", VA = "0x1999230")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1999238", Offset = "0x1999238", VA = "0x1999238")]
		public static void Save()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1994B30", Offset = "0x1994B30", VA = "0x1994B30")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1994910", Offset = "0x1994910", VA = "0x1994910")]
		private static string EncryptKey(string key)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1994DA8", Offset = "0x1994DA8", VA = "0x1994DA8")]
		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1995570", Offset = "0x1995570", VA = "0x1995570")]
		private static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x19944D0", Offset = "0x19944D0", VA = "0x19944D0")]
		private static uint CalculateChecksum(string input)
		{
			return default(uint);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x19994C0", Offset = "0x19994C0", VA = "0x19994C0")]
		private static void SavesTampered()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1999568", Offset = "0x1999568", VA = "0x1999568")]
		private static void PossibleForeignSavesDetected()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x19943E8", Offset = "0x19943E8", VA = "0x19943E8")]
		private static string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x19993C4", Offset = "0x19993C4", VA = "0x19993C4")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1995090", Offset = "0x1995090", VA = "0x1995090")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1999708", Offset = "0x1999708", VA = "0x1999708")]
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
		[Address(RVA = "0x19998F0", Offset = "0x19998F0", VA = "0x19998F0")]
		private ObscuredQuaternion(RawEncryptedQuaternion value)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x199998C", Offset = "0x199998C", VA = "0x199998C")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x19999F4", Offset = "0x19999F4", VA = "0x19999F4")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1999A80", Offset = "0x1999A80", VA = "0x1999A80")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1999B60", Offset = "0x1999B60", VA = "0x1999B60")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1999BD4", Offset = "0x1999BD4", VA = "0x1999BD4")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1999CA4", Offset = "0x1999CA4", VA = "0x1999CA4")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1999F90", Offset = "0x1999F90", VA = "0x1999F90")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x199A04C", Offset = "0x199A04C", VA = "0x199A04C")]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x199A074", Offset = "0x199A074", VA = "0x199A074")]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1999D98", Offset = "0x1999D98", VA = "0x1999D98")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x199A0B8", Offset = "0x199A0B8", VA = "0x199A0B8")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x199A214", Offset = "0x199A214", VA = "0x199A214")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x199A2F8", Offset = "0x199A2F8", VA = "0x199A2F8")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x199A2FC", Offset = "0x199A2FC", VA = "0x199A2FC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x199A32C", Offset = "0x199A32C", VA = "0x199A32C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x199A35C", Offset = "0x199A35C", VA = "0x199A35C")]
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
		[Address(RVA = "0x199A408", Offset = "0x199A408", VA = "0x199A408")]
		private ObscuredSByte(sbyte value)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x199A48C", Offset = "0x199A48C", VA = "0x199A48C")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x199A4F4", Offset = "0x199A4F4", VA = "0x199A4F4")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x199A558", Offset = "0x199A558", VA = "0x199A558")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x199A5D8", Offset = "0x199A5D8", VA = "0x199A5D8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x199A7DC", Offset = "0x199A7DC", VA = "0x199A7DC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x199A874", Offset = "0x199A874", VA = "0x199A874")]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x199A898", Offset = "0x199A898", VA = "0x199A898")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x199A6A4", Offset = "0x199A6A4", VA = "0x199A6A4")]
		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x199A8D4", Offset = "0x199A8D4", VA = "0x199A8D4")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x199A960", Offset = "0x199A960", VA = "0x199A960")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x199A984", Offset = "0x199A984", VA = "0x199A984")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x199AA1C", Offset = "0x199AA1C", VA = "0x199AA1C")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x199AAB4", Offset = "0x199AAB4", VA = "0x199AAB4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x199AB3C", Offset = "0x199AB3C", VA = "0x199AB3C", Slot = "4")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x199ABE8", Offset = "0x199ABE8", VA = "0x199ABE8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x199AC14", Offset = "0x199AC14", VA = "0x199AC14")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x199AC48", Offset = "0x199AC48", VA = "0x199AC48", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x199AC74", Offset = "0x199AC74", VA = "0x199AC74")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x199ACA8", Offset = "0x199ACA8", VA = "0x199ACA8", Slot = "5")]
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
		[Address(RVA = "0x199AD3C", Offset = "0x199AD3C", VA = "0x199AD3C")]
		private ObscuredShort(short value)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x199ADC4", Offset = "0x199ADC4", VA = "0x199ADC4")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x199AE2C", Offset = "0x199AE2C", VA = "0x199AE2C")]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x199AE90", Offset = "0x199AE90", VA = "0x199AE90")]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x199AF10", Offset = "0x199AF10", VA = "0x199AF10")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x199B118", Offset = "0x199B118", VA = "0x199B118")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x199B1B0", Offset = "0x199B1B0", VA = "0x199B1B0")]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x199B1D4", Offset = "0x199B1D4", VA = "0x199B1D4")]
		public void SetEncrypted(short encrypted)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x199AFDC", Offset = "0x199AFDC", VA = "0x199AFDC")]
		private short InternalDecrypt()
		{
			return default(short);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x19938EC", Offset = "0x19938EC", VA = "0x19938EC")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1993978", Offset = "0x1993978", VA = "0x1993978")]
		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x199B210", Offset = "0x199B210", VA = "0x199B210")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x199B298", Offset = "0x199B298", VA = "0x199B298")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x199B320", Offset = "0x199B320", VA = "0x199B320", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x199B3A8", Offset = "0x199B3A8", VA = "0x199B3A8", Slot = "4")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x199B450", Offset = "0x199B450", VA = "0x199B450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x199B47C", Offset = "0x199B47C", VA = "0x199B47C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x199B4B0", Offset = "0x199B4B0", VA = "0x199B4B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x199B4DC", Offset = "0x199B4DC", VA = "0x199B4DC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x199B510", Offset = "0x199B510", VA = "0x199B510", Slot = "5")]
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
		[Address(RVA = "0x199B5A4", Offset = "0x199B5A4", VA = "0x199B5A4")]
		private ObscuredString()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x199B5AC", Offset = "0x199B5AC", VA = "0x199B5AC")]
		private ObscuredString(byte[] value)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x199B63C", Offset = "0x199B63C", VA = "0x199B63C")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x199B6A4", Offset = "0x199B6A4", VA = "0x199B6A4")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1999240", Offset = "0x1999240", VA = "0x1999240")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x199B71C", Offset = "0x199B71C", VA = "0x199B71C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x199B9F0", Offset = "0x199B9F0", VA = "0x199B9F0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x199BB0C", Offset = "0x199BB0C", VA = "0x199BB0C")]
		public string GetEncrypted()
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x199BC08", Offset = "0x199BC08", VA = "0x199BC08")]
		public void SetEncrypted(string encrypted)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x199B984", Offset = "0x199B984", VA = "0x199B984")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x199BA98", Offset = "0x199BA98", VA = "0x199BA98")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x199B7E4", Offset = "0x199B7E4", VA = "0x199B7E4")]
		private string InternalDecrypt()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x199399C", Offset = "0x199399C", VA = "0x199399C")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1993A48", Offset = "0x1993A48", VA = "0x1993A48")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x199BE08", Offset = "0x199BE08", VA = "0x199BE08", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x199BD24", Offset = "0x199BD24", VA = "0x199BD24")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1993ADC", Offset = "0x1993ADC", VA = "0x1993ADC")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x199BE90", Offset = "0x199BE90", VA = "0x199BE90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x199BF10", Offset = "0x199BF10", VA = "0x199BF10")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x199C01C", Offset = "0x199C01C", VA = "0x199C01C")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x199C0E4", Offset = "0x199C0E4", VA = "0x199C0E4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x199BC98", Offset = "0x199BC98", VA = "0x199BC98")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x199BB78", Offset = "0x199BB78", VA = "0x199BB78")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x199BE0C", Offset = "0x199BE0C", VA = "0x199BE0C")]
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
		[Address(RVA = "0x199C16C", Offset = "0x199C16C", VA = "0x199C16C")]
		private ObscuredUInt(uint value)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x199C1F0", Offset = "0x199C1F0", VA = "0x199C1F0")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x199C258", Offset = "0x199C258", VA = "0x199C258")]
		public static uint Encrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x199C338", Offset = "0x199C338", VA = "0x199C338")]
		public static uint Decrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x199C2BC", Offset = "0x199C2BC", VA = "0x199C2BC")]
		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x199C39C", Offset = "0x199C39C", VA = "0x199C39C")]
		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x199C418", Offset = "0x199C418", VA = "0x199C418")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x199C618", Offset = "0x199C618", VA = "0x199C618")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x199C6B0", Offset = "0x199C6B0", VA = "0x199C6B0")]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x199C6D4", Offset = "0x199C6D4", VA = "0x199C6D4")]
		public void SetEncrypted(uint encrypted)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x199C4E4", Offset = "0x199C4E4", VA = "0x199C4E4")]
		private uint InternalDecrypt()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x19900C4", Offset = "0x19900C4", VA = "0x19900C4")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1993B58", Offset = "0x1993B58", VA = "0x1993B58")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x199C710", Offset = "0x199C710", VA = "0x199C710")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x199C788", Offset = "0x199C788", VA = "0x199C788")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x199C820", Offset = "0x199C820", VA = "0x199C820")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x199C8B8", Offset = "0x199C8B8", VA = "0x199C8B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x199C940", Offset = "0x199C940", VA = "0x199C940", Slot = "4")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x199C9E8", Offset = "0x199C9E8", VA = "0x199C9E8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x199CA14", Offset = "0x199CA14", VA = "0x199CA14")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x199CA48", Offset = "0x199CA48", VA = "0x199CA48", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x199CA74", Offset = "0x199CA74", VA = "0x199CA74")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x199CAA8", Offset = "0x199CAA8", VA = "0x199CAA8", Slot = "5")]
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
		[Address(RVA = "0x199CB40", Offset = "0x199CB40", VA = "0x199CB40")]
		private ObscuredULong(ulong value)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x199CBC4", Offset = "0x199CBC4", VA = "0x199CBC4")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x199CC2C", Offset = "0x199CC2C", VA = "0x199CC2C")]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x199CD0C", Offset = "0x199CD0C", VA = "0x199CD0C")]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x199CC90", Offset = "0x199CC90", VA = "0x199CC90")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x199CD70", Offset = "0x199CD70", VA = "0x199CD70")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x199CDEC", Offset = "0x199CDEC", VA = "0x199CDEC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x199CFEC", Offset = "0x199CFEC", VA = "0x199CFEC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x199D084", Offset = "0x199D084", VA = "0x199D084")]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x199D0A8", Offset = "0x199D0A8", VA = "0x199D0A8")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x199CEB8", Offset = "0x199CEB8", VA = "0x199CEB8")]
		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x199D0E4", Offset = "0x199D0E4", VA = "0x199D0E4")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x199D184", Offset = "0x199D184", VA = "0x199D184")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x199D188", Offset = "0x199D188", VA = "0x199D188")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x199D228", Offset = "0x199D228", VA = "0x199D228")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x199D2C8", Offset = "0x199D2C8", VA = "0x199D2C8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x199D35C", Offset = "0x199D35C", VA = "0x199D35C", Slot = "4")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x199D404", Offset = "0x199D404", VA = "0x199D404", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x199D430", Offset = "0x199D430", VA = "0x199D430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x199D45C", Offset = "0x199D45C", VA = "0x199D45C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x199D490", Offset = "0x199D490", VA = "0x199D490")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x199D4C4", Offset = "0x199D4C4", VA = "0x199D4C4", Slot = "5")]
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
		[Address(RVA = "0x211E238", Offset = "0x211E238", VA = "0x211E238")]
		private ObscuredUShort(ushort value)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x211E2C0", Offset = "0x211E2C0", VA = "0x211E2C0")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x211E328", Offset = "0x211E328", VA = "0x211E328")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x211E38C", Offset = "0x211E38C", VA = "0x211E38C")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x211E40C", Offset = "0x211E40C", VA = "0x211E40C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x211E618", Offset = "0x211E618", VA = "0x211E618")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x211E6B0", Offset = "0x211E6B0", VA = "0x211E6B0")]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x211E6D4", Offset = "0x211E6D4", VA = "0x211E6D4")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x211E4D8", Offset = "0x211E4D8", VA = "0x211E4D8")]
		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x211E714", Offset = "0x211E714", VA = "0x211E714")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x211E7A4", Offset = "0x211E7A4", VA = "0x211E7A4")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x211E7C8", Offset = "0x211E7C8", VA = "0x211E7C8")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x211E864", Offset = "0x211E864", VA = "0x211E864")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x211E900", Offset = "0x211E900", VA = "0x211E900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x211E988", Offset = "0x211E988", VA = "0x211E988", Slot = "4")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x211EA30", Offset = "0x211EA30", VA = "0x211EA30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x211EA5C", Offset = "0x211EA5C", VA = "0x211EA5C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x211EA90", Offset = "0x211EA90", VA = "0x211EA90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x211EABC", Offset = "0x211EABC", VA = "0x211EABC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x211EAF0", Offset = "0x211EAF0", VA = "0x211EAF0", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8364BC", Offset = "0x8364BC")]
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
			[Address(RVA = "0x211EC18", Offset = "0x211EC18", VA = "0x211EC18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x211EDEC", Offset = "0x211EDEC", VA = "0x211EDEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float y
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x211EED8", Offset = "0x211EED8", VA = "0x211EED8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x211F010", Offset = "0x211F010", VA = "0x211F010")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public float Item
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x211F050", Offset = "0x211F050", VA = "0x211F050")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x211F0B8", Offset = "0x211F0B8", VA = "0x211F0B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x211EB84", Offset = "0x211EB84", VA = "0x211EB84")]
		private ObscuredVector2(RawEncryptedVector2 value)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x211F120", Offset = "0x211F120", VA = "0x211F120")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x211F188", Offset = "0x211F188", VA = "0x211F188")]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x211F1FC", Offset = "0x211F1FC", VA = "0x211F1FC")]
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x211F2D4", Offset = "0x211F2D4", VA = "0x211F2D4")]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x211F338", Offset = "0x211F338", VA = "0x211F338")]
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x211F414", Offset = "0x211F414", VA = "0x211F414")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x211F6BC", Offset = "0x211F6BC", VA = "0x211F6BC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x211F75C", Offset = "0x211F75C", VA = "0x211F75C")]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x211F780", Offset = "0x211F780", VA = "0x211F780")]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x211F4EC", Offset = "0x211F4EC", VA = "0x211F4EC")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x211F7C0", Offset = "0x211F7C0", VA = "0x211F7C0")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x211ED48", Offset = "0x211ED48", VA = "0x211ED48")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x211EE2C", Offset = "0x211EE2C", VA = "0x211EE2C")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x211F8B8", Offset = "0x211F8B8", VA = "0x211F8B8")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x211F96C", Offset = "0x211F96C", VA = "0x211F96C")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x211F970", Offset = "0x211F970", VA = "0x211F970")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x211F988", Offset = "0x211F988", VA = "0x211F988", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x211F9B4", Offset = "0x211F9B4", VA = "0x211F9B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x211F9E0", Offset = "0x211F9E0", VA = "0x211F9E0")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8364F4", Offset = "0x8364F4")]
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
			[Address(RVA = "0x211FD00", Offset = "0x211FD00", VA = "0x211FD00")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x211FED4", Offset = "0x211FED4", VA = "0x211FED4")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float y
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x211FFC0", Offset = "0x211FFC0", VA = "0x211FFC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x21200F8", Offset = "0x21200F8", VA = "0x21200F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float z
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2120138", Offset = "0x2120138", VA = "0x2120138")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x2120270", Offset = "0x2120270", VA = "0x2120270")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public float Item
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x21202B0", Offset = "0x21202B0", VA = "0x21202B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x2120324", Offset = "0x2120324", VA = "0x2120324")]
			set
			{
			}
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x211FA7C", Offset = "0x211FA7C", VA = "0x211FA7C")]
		private ObscuredVector3(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x211FB20", Offset = "0x211FB20", VA = "0x211FB20")]
		public Vector3 getValue()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2120398", Offset = "0x2120398", VA = "0x2120398")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2120400", Offset = "0x2120400", VA = "0x2120400")]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x212048C", Offset = "0x212048C", VA = "0x212048C")]
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2120590", Offset = "0x2120590", VA = "0x2120590")]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2120604", Offset = "0x2120604", VA = "0x2120604")]
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x21206FC", Offset = "0x21206FC", VA = "0x21206FC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x21207E8", Offset = "0x21207E8", VA = "0x21207E8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x212089C", Offset = "0x212089C", VA = "0x212089C")]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x21208C4", Offset = "0x21208C4", VA = "0x21208C4")]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x211FB24", Offset = "0x211FB24", VA = "0x211FB24")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x212090C", Offset = "0x212090C", VA = "0x212090C")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x211FE30", Offset = "0x211FE30", VA = "0x211FE30")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x211FF14", Offset = "0x211FF14", VA = "0x211FF14")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2120A38", Offset = "0x2120A38", VA = "0x2120A38")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2120B0C", Offset = "0x2120B0C", VA = "0x2120B0C")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2120B10", Offset = "0x2120B10", VA = "0x2120B10")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2120BD8", Offset = "0x2120BD8", VA = "0x2120BD8")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2120C94", Offset = "0x2120C94", VA = "0x2120C94")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2120D50", Offset = "0x2120D50", VA = "0x2120D50")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2120E18", Offset = "0x2120E18", VA = "0x2120E18")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2120ED4", Offset = "0x2120ED4", VA = "0x2120ED4")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2120F90", Offset = "0x2120F90", VA = "0x2120F90")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2121040", Offset = "0x2121040", VA = "0x2121040")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x21210F4", Offset = "0x21210F4", VA = "0x21210F4")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x21211A8", Offset = "0x21211A8", VA = "0x21211A8")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x212125C", Offset = "0x212125C", VA = "0x212125C")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x21212BC", Offset = "0x21212BC", VA = "0x21212BC")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x2121308", Offset = "0x2121308", VA = "0x2121308")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x2121348", Offset = "0x2121348", VA = "0x2121348")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x21213A8", Offset = "0x21213A8", VA = "0x21213A8")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x21213F4", Offset = "0x21213F4", VA = "0x21213F4")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x2121434", Offset = "0x2121434", VA = "0x2121434", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x2121478", Offset = "0x2121478", VA = "0x2121478", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x21214A8", Offset = "0x21214A8", VA = "0x21214A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x21214D8", Offset = "0x21214D8", VA = "0x21214D8")]
		public string ToString(string format)
		{
			return null;
		}
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83652C", Offset = "0x83652C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837BDC", Offset = "0x837BDC")]
		public bool autoStart;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837C14", Offset = "0x837C14")]
		public bool keepAlive;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837C4C", Offset = "0x837C4C")]
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
		[Address(RVA = "0x20E0914", Offset = "0x20E0914", VA = "0x20E0914")]
		private void Start()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x20E0A30", Offset = "0x20E0A30", VA = "0x20E0A30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x20E0A58", Offset = "0x20E0A58", VA = "0x20E0A58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x20E0A70", Offset = "0x20E0A70", VA = "0x20E0A70")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x20E0A7C", Offset = "0x20E0A7C", VA = "0x20E0A7C", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x20E0BC0", Offset = "0x20E0BC0", VA = "0x20E0BC0", Slot = "5")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x20E0D80", Offset = "0x20E0D80", VA = "0x20E0D80", Slot = "6")]
		protected virtual void DisposeInternal()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x20E0DE4", Offset = "0x20E0DE4", VA = "0x20E0DE4", Slot = "7")]
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
		[Address(RVA = "0x20E0E48", Offset = "0x20E0E48", VA = "0x20E0E48")]
		protected ActDetectorBase()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x836564", Offset = "0x836564")]
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
			[Address(RVA = "0x1FADE54", Offset = "0x1FADE54", VA = "0x1FADE54")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837CA4", Offset = "0x837CA4")]
		private static InjectionDetector <Instance>k__BackingField;

		[Token(Token = "0x17000056")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x21158B8", Offset = "0x21158B8", VA = "0x21158B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838C30", Offset = "0x838C30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x2115904", Offset = "0x2115904", VA = "0x2115904")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838C40", Offset = "0x838C40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		private static InjectionDetector GetOrCreateInstance
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x2115508", Offset = "0x2115508", VA = "0x2115508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x2115154", Offset = "0x2115154", VA = "0x2115154")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x21154DC", Offset = "0x21154DC", VA = "0x21154DC")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x21156D8", Offset = "0x21156D8", VA = "0x21156D8")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x21157C8", Offset = "0x21157C8", VA = "0x21157C8")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x2115954", Offset = "0x2115954", VA = "0x2115954")]
		private InjectionDetector()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x211595C", Offset = "0x211595C", VA = "0x211595C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x2115AD0", Offset = "0x2115AD0", VA = "0x2115AD0", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x2115BC4", Offset = "0x2115BC4", VA = "0x2115BC4")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2115288", Offset = "0x2115288", VA = "0x2115288")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x21162B4", Offset = "0x21162B4", VA = "0x21162B4", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x21162BC", Offset = "0x21162BC", VA = "0x21162BC", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2116360", Offset = "0x2116360", VA = "0x2116360", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2116428", Offset = "0x2116428", VA = "0x2116428", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x21164DC", Offset = "0x21164DC", VA = "0x21164DC", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x21165C0", Offset = "0x21165C0", VA = "0x21165C0")]
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x2116218", Offset = "0x2116218", VA = "0x2116218")]
		private bool FindInjectionInCurrentAssemblies()
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x2116608", Offset = "0x2116608", VA = "0x2116608")]
		private bool AssemblyAllowed(Assembly ass)
		{
			return default(bool);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2115CB8", Offset = "0x2115CB8", VA = "0x2115CB8")]
		private void LoadAndParseAllowedAssemblies()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x2116710", Offset = "0x2116710", VA = "0x2116710")]
		private int GetAssemblyHash(Assembly ass)
		{
			return default(int);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x21167EC", Offset = "0x21167EC", VA = "0x21167EC")]
		private string PublicKeyTokenToString(byte[] bytes)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83659C", Offset = "0x83659C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837CB4", Offset = "0x837CB4")]
		public float floatEpsilon;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837CEC", Offset = "0x837CEC")]
		public float vector2Epsilon;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837D24", Offset = "0x837D24")]
		public float vector3Epsilon;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837D5C", Offset = "0x837D5C")]
		public float quaternionEpsilon;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D94", Offset = "0x837D94")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;

		[Token(Token = "0x17000058")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x198CB54", Offset = "0x198CB54", VA = "0x198CB54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838C50", Offset = "0x838C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x198CBA0", Offset = "0x198CBA0", VA = "0x198CBA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838C60", Offset = "0x838C60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x198C7A4", Offset = "0x198C7A4", VA = "0x198C7A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		internal static bool IsRunning
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x198AF80", Offset = "0x198AF80", VA = "0x198AF80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x198C498", Offset = "0x198C498", VA = "0x198C498")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x198C778", Offset = "0x198C778", VA = "0x198C778")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x198C974", Offset = "0x198C974", VA = "0x198C974")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x198CA64", Offset = "0x198CA64", VA = "0x198CA64")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x198CBF0", Offset = "0x198CBF0", VA = "0x198CBF0")]
		private ObscuredCheatingDetector()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x198CC04", Offset = "0x198CC04", VA = "0x198CC04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x198CD78", Offset = "0x198CD78", VA = "0x198CD78", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x198CE6C", Offset = "0x198CE6C", VA = "0x198CE6C")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x198C5CC", Offset = "0x198C5CC", VA = "0x198C5CC")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x198CF60", Offset = "0x198CF60", VA = "0x198CF60", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x198CF68", Offset = "0x198CF68", VA = "0x198CF68", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x198CF70", Offset = "0x198CF70", VA = "0x198CF70", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x198CF8C", Offset = "0x198CF8C", VA = "0x198CF8C", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x198CFA0", Offset = "0x198CFA0", VA = "0x198CFA0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8365D4", Offset = "0x8365D4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837DA4", Offset = "0x837DA4")]
		public float interval;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837DDC", Offset = "0x837DDC")]
		public byte maxFalsePositives;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837E14", Offset = "0x837E14")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E4C", Offset = "0x837E4C")]
		private static SpeedHackDetector <Instance>k__BackingField;

		[Token(Token = "0x1700005B")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x2127D30", Offset = "0x2127D30", VA = "0x2127D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838C70", Offset = "0x838C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x2127D7C", Offset = "0x2127D7C", VA = "0x2127D7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838C80", Offset = "0x838C80")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x21278A4", Offset = "0x21278A4", VA = "0x21278A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x2127540", Offset = "0x2127540", VA = "0x2127540")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x2127874", Offset = "0x2127874", VA = "0x2127874")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x2127A74", Offset = "0x2127A74", VA = "0x2127A74")]
		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2127AB4", Offset = "0x2127AB4", VA = "0x2127AB4")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x2127AFC", Offset = "0x2127AFC", VA = "0x2127AFC")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2127B50", Offset = "0x2127B50", VA = "0x2127B50")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2127C40", Offset = "0x2127C40", VA = "0x2127C40")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2127DCC", Offset = "0x2127DCC", VA = "0x2127DCC")]
		private SpeedHackDetector()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2127DEC", Offset = "0x2127DEC", VA = "0x2127DEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x2127F60", Offset = "0x2127F60", VA = "0x2127F60", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2128054", Offset = "0x2128054", VA = "0x2128054")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x2128148", Offset = "0x2128148", VA = "0x2128148")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x21281F4", Offset = "0x21281F4", VA = "0x21281F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x2127680", Offset = "0x2127680", VA = "0x2127680")]
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x2128370", Offset = "0x2128370", VA = "0x2128370", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2128384", Offset = "0x2128384", VA = "0x2128384", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x212838C", Offset = "0x212838C", VA = "0x212838C", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x21283A8", Offset = "0x21283A8", VA = "0x21283A8", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x21283BC", Offset = "0x21283BC", VA = "0x21283BC", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2128154", Offset = "0x2128154", VA = "0x2128154")]
		private void ResetStartTicks()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83660C", Offset = "0x83660C")]
	public class WallHackDetector : ActDetectorBase
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8368FC", Offset = "0x8368FC")]
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
				[Address(RVA = "0x1FB2964", Offset = "0x1FB2964", VA = "0x1FB2964", Slot = "4")]
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
				[Address(RVA = "0x1FB29AC", Offset = "0x1FB29AC", VA = "0x1FB29AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x1FB2874", Offset = "0x1FB2874", VA = "0x1FB2874")]
			[DebuggerHidden]
			public <InitDetector>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1FB28A0", Offset = "0x1FB28A0", VA = "0x1FB28A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1FB28A4", Offset = "0x1FB28A4", VA = "0x1FB28A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x1FB296C", Offset = "0x1FB296C", VA = "0x1FB296C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83690C", Offset = "0x83690C")]
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
				[Address(RVA = "0x1FB2824", Offset = "0x1FB2824", VA = "0x1FB2824", Slot = "4")]
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
				[Address(RVA = "0x1FB286C", Offset = "0x1FB286C", VA = "0x1FB286C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1FB241C", Offset = "0x1FB241C", VA = "0x1FB241C")]
			[DebuggerHidden]
			public <CaptureFrame>d__82(int <>1__state)
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x1FB2448", Offset = "0x1FB2448", VA = "0x1FB2448", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1FB244C", Offset = "0x1FB244C", VA = "0x1FB244C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1FB282C", Offset = "0x1FB282C", VA = "0x1FB282C", Slot = "8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837E5C", Offset = "0x837E5C")]
		private bool checkRigidbody;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837EA8", Offset = "0x837EA8")]
		private bool checkController;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837EF4", Offset = "0x837EF4")]
		private bool checkWireframe;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837F40", Offset = "0x837F40")]
		private bool checkRaycast;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837F8C", Offset = "0x837F8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x837F8C", Offset = "0x837F8C")]
		public int wireframeDelay;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x837FE4", Offset = "0x837FE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x837FE4", Offset = "0x837FE4")]
		public int raycastDelay;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x83803C", Offset = "0x83803C")]
		public Vector3 spawnPosition;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x838074", Offset = "0x838074")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380AC", Offset = "0x8380AC")]
		private static WallHackDetector <Instance>k__BackingField;

		[Token(Token = "0x1700005D")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x212BF78", Offset = "0x212BF78", VA = "0x212BF78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x212BF80", Offset = "0x212BF80", VA = "0x212BF80")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool CheckController
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x212D374", Offset = "0x212D374", VA = "0x212D374")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x212D37C", Offset = "0x212D37C", VA = "0x212D37C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public bool CheckWireframe
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x212D5F0", Offset = "0x212D5F0", VA = "0x212D5F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x212D5F8", Offset = "0x212D5F8", VA = "0x212D5F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool CheckRaycast
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x212D784", Offset = "0x212D784", VA = "0x212D784")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x212D78C", Offset = "0x212D78C", VA = "0x212D78C")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x212E0E0", Offset = "0x212E0E0", VA = "0x212E0E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838C90", Offset = "0x838C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x212E12C", Offset = "0x212E12C", VA = "0x212E12C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838CA0", Offset = "0x838CA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x212DC7C", Offset = "0x212DC7C", VA = "0x212DC7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x212D904", Offset = "0x212D904", VA = "0x212D904")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x212DC48", Offset = "0x212DC48", VA = "0x212DC48")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x212DE4C", Offset = "0x212DE4C", VA = "0x212DE4C")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x212DEA4", Offset = "0x212DEA4", VA = "0x212DEA4")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x212DF00", Offset = "0x212DF00", VA = "0x212DF00")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x212DFF0", Offset = "0x212DFF0", VA = "0x212DFF0")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x212E17C", Offset = "0x212E17C", VA = "0x212E17C")]
		private WallHackDetector()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x212E230", Offset = "0x212E230", VA = "0x212E230")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x212E3A4", Offset = "0x212E3A4", VA = "0x212E3A4", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x212E5A4", Offset = "0x212E5A4", VA = "0x212E5A4")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x212E698", Offset = "0x212E698", VA = "0x212E698")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x212E7D4", Offset = "0x212E7D4", VA = "0x212E7D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x212DA44", Offset = "0x212DA44", VA = "0x212DA44")]
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x212E960", Offset = "0x212E960", VA = "0x212E960", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x212E974", Offset = "0x212E974", VA = "0x212E974", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x212E9B8", Offset = "0x212E9B8", VA = "0x212E9B8", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x212EA34", Offset = "0x212EA34", VA = "0x212EA34", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x212EA6C", Offset = "0x212EA6C", VA = "0x212EA6C", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x212C030", Offset = "0x212C030", VA = "0x212C030")]
		private void UpdateServiceContainer()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x212E8F4", Offset = "0x212E8F4", VA = "0x212E8F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838CB0", Offset = "0x838CB0")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x212D150", Offset = "0x212D150", VA = "0x212D150")]
		private void StartRigidModule()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x212D42C", Offset = "0x212D42C", VA = "0x212D42C")]
		private void StartControllerModule()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x212D6A8", Offset = "0x212D6A8", VA = "0x212D6A8")]
		private void StartWireframeModule()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x212F0C4", Offset = "0x212F0C4", VA = "0x212F0C4")]
		private void ShootWireframeModule()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x212F134", Offset = "0x212F134", VA = "0x212F134")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838D10", Offset = "0x838D10")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x212D83C", Offset = "0x212D83C", VA = "0x212D83C")]
		private void StartRaycastModule()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x212F1A0", Offset = "0x212F1A0", VA = "0x212F1A0")]
		private void ShootRaycastModule()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x212D2C4", Offset = "0x212D2C4", VA = "0x212D2C4")]
		private void StopRigidModule()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x212D55C", Offset = "0x212D55C", VA = "0x212D55C")]
		private void StopControllerModule()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x212D734", Offset = "0x212D734", VA = "0x212D734")]
		private void StopWireframeModule()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x212D8B4", Offset = "0x212D8B4", VA = "0x212D8B4")]
		private void StopRaycastModule()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x212ED7C", Offset = "0x212ED7C", VA = "0x212ED7C")]
		private void InitRigidModule()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x212EF84", Offset = "0x212EF84", VA = "0x212EF84")]
		private void InitControllerModule()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x212ECC0", Offset = "0x212ECC0", VA = "0x212ECC0")]
		private void UninitRigidModule()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x212EEC8", Offset = "0x212EEC8", VA = "0x212EEC8")]
		private void UninitControllerModule()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x212E778", Offset = "0x212E778", VA = "0x212E778")]
		private bool Detect()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x212EB50", Offset = "0x212EB50", VA = "0x212EB50")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x212EBCC", Offset = "0x212EBCC", VA = "0x212EBCC")]
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
		[Address(RVA = "0x210BDA4", Offset = "0x210BDA4", VA = "0x210BDA4")]
		public Constants()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Examples
{
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x836644", Offset = "0x836644")]
	public class ActRotatorExample : MonoBehaviour
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8380BC", Offset = "0x8380BC")]
		public float speed;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x20E0E60", Offset = "0x20E0E60", VA = "0x20E0E60")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x20E0EB8", Offset = "0x20E0EB8", VA = "0x20E0EB8")]
		public ActRotatorExample()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83667C", Offset = "0x83667C")]
	public class ActTesterGui : MonoBehaviour
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83691C", Offset = "0x83691C")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string types;

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x212FB74", Offset = "0x212FB74", VA = "0x212FB74")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x212FB7C", Offset = "0x212FB7C", VA = "0x212FB7C")]
			internal void <GetAllSimpleObscuredTypes>b__1(Type t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83692C", Offset = "0x83692C")]
		private sealed class <>c
		{
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> <>9__61_0;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x212FAB0", Offset = "0x212FAB0", VA = "0x212FAB0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x212FAB8", Offset = "0x212FAB8", VA = "0x212FAB8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8380D8", Offset = "0x8380D8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x838110", Offset = "0x838110")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x838148", Offset = "0x838148")]
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
		[Address(RVA = "0x20E0EC8", Offset = "0x20E0EC8", VA = "0x20E0EC8")]
		public void OnSpeedHackDetected()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x20E0F48", Offset = "0x20E0F48", VA = "0x20E0F48")]
		public void OnInjectionDetected()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x20E0FC8", Offset = "0x20E0FC8", VA = "0x20E0FC8")]
		public void OnObscuredTypeCheatingDetected()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x20E1048", Offset = "0x20E1048", VA = "0x20E1048")]
		public void OnWallHackDetected()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x20E10C8", Offset = "0x20E10C8", VA = "0x20E10C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x20E11C8", Offset = "0x20E11C8", VA = "0x20E11C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x20E20F8", Offset = "0x20E20F8", VA = "0x20E20F8")]
		private void RandomizeObscuredVars()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x20E1248", Offset = "0x20E1248", VA = "0x20E1248")]
		private void ObscuredStringExample()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x20E142C", Offset = "0x20E142C", VA = "0x20E142C")]
		private void ObscuredIntExample()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x20E18F8", Offset = "0x20E18F8", VA = "0x20E18F8")]
		private void ObscuredFloatExample()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x20E1D08", Offset = "0x20E1D08", VA = "0x20E1D08")]
		private void ObscuredVector3Example()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x20E2190", Offset = "0x20E2190", VA = "0x20E2190")]
		private void SavesAlterationDetected()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x20E219C", Offset = "0x20E219C", VA = "0x20E219C")]
		private void ForeignSavesDetected()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x20E21A8", Offset = "0x20E21A8", VA = "0x20E21A8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x20E86CC", Offset = "0x20E86CC", VA = "0x20E86CC")]
		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x20E8970", Offset = "0x20E8970", VA = "0x20E8970")]
		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x20E89B4", Offset = "0x20E89B4", VA = "0x20E89B4")]
		private void LoadRegularPrefs()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x20E8B34", Offset = "0x20E8B34", VA = "0x20E8B34")]
		private void SaveRegularPrefs()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x20E8BE8", Offset = "0x20E8BE8", VA = "0x20E8BE8")]
		private void DeleteRegularPrefs()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x20E8C78", Offset = "0x20E8C78", VA = "0x20E8C78")]
		private void LoadObscuredPrefs()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x20E9530", Offset = "0x20E9530", VA = "0x20E9530")]
		private void SaveObscuredPrefs()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x20E9838", Offset = "0x20E9838", VA = "0x20E9838")]
		private void DeleteObscuredPrefs()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x20E9A34", Offset = "0x20E9A34", VA = "0x20E9A34")]
		private void PlaceUrlButton(string url)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x20E9B30", Offset = "0x20E9B30", VA = "0x20E9B30")]
		private void PlaceUrlButton(string url, int width)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x20E9A3C", Offset = "0x20E9A3C", VA = "0x20E9A3C")]
		private void PlaceUrlButton(string url, string buttonName, int width)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x20E9B8C", Offset = "0x20E9B8C", VA = "0x20E9B8C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x20E9BA0", Offset = "0x20E9BA0", VA = "0x20E9BA0")]
		public ActTesterGui()
		{
		}
	}
	[Token(Token = "0x2000090")]
	internal class HorizontalLayout : IDisposable
	{
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x2115120", Offset = "0x2115120", VA = "0x2115120")]
		public HorizontalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x211514C", Offset = "0x211514C", VA = "0x211514C", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000091")]
	internal class VerticalLayout : IDisposable
	{
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x212B8CC", Offset = "0x212B8CC", VA = "0x212B8CC")]
		public VerticalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x212B8F8", Offset = "0x212B8F8", VA = "0x212B8F8")]
		public VerticalLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x212B9E0", Offset = "0x212B9E0", VA = "0x212B9E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8366B4", Offset = "0x8366B4")]
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
		[Address(RVA = "0x1990F28", Offset = "0x1990F28", VA = "0x1990F28")]
		private void Start()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1990F7C", Offset = "0x1990F7C", VA = "0x1990F7C")]
		private void StartTests()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x19910E4", Offset = "0x19910E4", VA = "0x19910E4")]
		private void TestBool()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x19913F8", Offset = "0x19913F8", VA = "0x19913F8")]
		private void TestByte()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x19916F8", Offset = "0x19916F8", VA = "0x19916F8")]
		private void TestShort()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x19919F8", Offset = "0x19919F8", VA = "0x19919F8")]
		private void TestUShort()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1992974", Offset = "0x1992974", VA = "0x1992974")]
		private void TestDouble()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1992620", Offset = "0x1992620", VA = "0x1992620")]
		private void TestFloat()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1991CF4", Offset = "0x1991CF4", VA = "0x1991CF4")]
		private void TestInt()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1992304", Offset = "0x1992304", VA = "0x1992304")]
		private void TestLong()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1992C9C", Offset = "0x1992C9C", VA = "0x1992C9C")]
		private void TestString()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1991FFC", Offset = "0x1991FFC", VA = "0x1991FFC")]
		private void TestUInt()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1993028", Offset = "0x1993028", VA = "0x1993028")]
		private void TestVector3()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x199348C", Offset = "0x199348C", VA = "0x199348C")]
		private void TestPrefs()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x199424C", Offset = "0x199424C", VA = "0x199424C")]
		public ObscuredPerformanceTests()
		{
		}
	}
}
