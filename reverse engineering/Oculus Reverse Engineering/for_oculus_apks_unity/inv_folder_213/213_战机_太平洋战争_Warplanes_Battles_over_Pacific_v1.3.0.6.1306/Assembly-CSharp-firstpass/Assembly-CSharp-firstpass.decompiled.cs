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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9C88", Offset = "0x9F9C88")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1B1EBF0", Offset = "0x1B1EBF0", VA = "0x1B1EBF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9CC0", Offset = "0x9F9CC0")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1B212A4", Offset = "0x1B212A4", VA = "0x1B212A4")]
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
		[Address(RVA = "0x1D4197C", Offset = "0x1D4197C", VA = "0x1D4197C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1D41A60", Offset = "0x1D41A60", VA = "0x1D41A60")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1D41B78", Offset = "0x1D41B78", VA = "0x1D41B78")]
	public static void ResetLastSendTime()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1D41C4C", Offset = "0x1D41C4C", VA = "0x1D41C4C")]
	public void SetLastStoreTime()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1D41CBC", Offset = "0x1D41CBC", VA = "0x1D41CBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1D4269C", Offset = "0x1D4269C", VA = "0x1D4269C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1D42804", Offset = "0x1D42804", VA = "0x1D42804")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1D42C48", Offset = "0x1D42C48", VA = "0x1D42C48")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1D42C4C", Offset = "0x1D42C4C", VA = "0x1D42C4C")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1D41FE0", Offset = "0x1D41FE0", VA = "0x1D41FE0")]
	private void StartFirstScreen()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1D4339C", Offset = "0x1D4339C", VA = "0x1D4339C", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1D433A0", Offset = "0x1D433A0", VA = "0x1D433A0", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1D42A8C", Offset = "0x1D42A8C", VA = "0x1D42A8C", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1D42E3C", Offset = "0x1D42E3C", VA = "0x1D42E3C", Slot = "7")]
	public void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1D435E8", Offset = "0x1D435E8", VA = "0x1D435E8")]
	public void OnReceivedCloudSave(CloudSave_Screen onScreen, CloudSave_Saves cloudSaves, bool compareAndImport)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1D43908", Offset = "0x1D43908", VA = "0x1D43908")]
	public void OnSendSaveToCloud(CloudSave_Screen onScreen, CloudSave_Saves localSaves)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1D42F7C", Offset = "0x1D42F7C", VA = "0x1D42F7C")]
	public void TrySendChangedLocalSave()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1D44330", Offset = "0x1D44330", VA = "0x1D44330")]
	public void TrySendDeletedSave()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1D42A14", Offset = "0x1D42A14", VA = "0x1D42A14")]
	protected void ShowConflictMessage()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1D44488", Offset = "0x1D44488", VA = "0x1D44488")]
	protected void ClearConflictMessage()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1D44500", Offset = "0x1D44500", VA = "0x1D44500")]
	public bool IsLoggingIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1D43294", Offset = "0x1D43294", VA = "0x1D43294")]
	protected void ShowScreen(CloudSave_Screen screen)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1D4456C", Offset = "0x1D4456C", VA = "0x1D4456C")]
	public void On_SelectMode_Email()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1D44574", Offset = "0x1D44574", VA = "0x1D44574")]
	public void On_SelectMode_Auto()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1D4467C", Offset = "0x1D4467C", VA = "0x1D4467C")]
	public void On_SelectMode_Back()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1D446F8", Offset = "0x1D446F8", VA = "0x1D446F8")]
	public void On_CloudInfo_Yes()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1D44700", Offset = "0x1D44700", VA = "0x1D44700")]
	public void On_CloudInfo_No()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1D44704", Offset = "0x1D44704", VA = "0x1D44704")]
	public void On_CloudInfo_Back()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1D44780", Offset = "0x1D44780", VA = "0x1D44780")]
	public void On_CloudInfo_CloseToLogin()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1D4337C", Offset = "0x1D4337C", VA = "0x1D4337C")]
	protected void ShowLoginScreen(bool autoLogin, bool manualFirstLogin)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1D44788", Offset = "0x1D44788", VA = "0x1D44788")]
	public void On_LoginScreen_Back()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1D44804", Offset = "0x1D44804", VA = "0x1D44804")]
	public void On_LoginScreen_ShowInfo()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1D4480C", Offset = "0x1D4480C", VA = "0x1D4480C")]
	public void On_LoginScreen_FailedAutoLogin()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1D44988", Offset = "0x1D44988", VA = "0x1D44988")]
	public void OnSelectScreen_ShowLogin(bool showRegister)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1D449D8", Offset = "0x1D449D8", VA = "0x1D449D8")]
	public void On_LoginScreen_LoggedIn()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1D44AF0", Offset = "0x1D44AF0", VA = "0x1D44AF0")]
	public void On_LoginScreen_ResetPassword()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1D44B24", Offset = "0x1D44B24", VA = "0x1D44B24")]
	public void On_MenuScreen_Back()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1D44B98", Offset = "0x1D44B98", VA = "0x1D44B98")]
	public void On_MenuScreen_Settings()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1D44BA0", Offset = "0x1D44BA0", VA = "0x1D44BA0")]
	public void On_MenuScreen_SetPassword()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1D44BA8", Offset = "0x1D44BA8", VA = "0x1D44BA8")]
	public void On_MenuScreen_Logout()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1D44D44", Offset = "0x1D44D44", VA = "0x1D44D44")]
	public void On_ChangePasswordScreen_Back()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1D44D4C", Offset = "0x1D44D4C", VA = "0x1D44D4C")]
	public void On_ResetPasswordScreen_Back(bool backToSettings)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1D44D60", Offset = "0x1D44D60", VA = "0x1D44D60")]
	public void ShowMessageScreen(string text, bool warning, CloudSave_Screen backToScreen, Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1D44E34", Offset = "0x1D44E34", VA = "0x1D44E34")]
	public void On_MessageScreen_Closed(CloudSave_Screen backToScreen, Action<bool> resultCallback, bool result)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1D44EC4", Offset = "0x1D44EC4", VA = "0x1D44EC4")]
	public void On_SettingsScreen_Back()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1D44ECC", Offset = "0x1D44ECC", VA = "0x1D44ECC")]
	public void On_SettingsScreen_ChangePassword()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1D44ED4", Offset = "0x1D44ED4", VA = "0x1D44ED4")]
	public void On_SettingsScreen_ResetPassword()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1D44F0C", Offset = "0x1D44F0C", VA = "0x1D44F0C")]
	public void On_SettingsScreen_DeleteAccount()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1D44F14", Offset = "0x1D44F14", VA = "0x1D44F14")]
	public void On_DeleteAccountScreen_Back()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1D44F1C", Offset = "0x1D44F1C", VA = "0x1D44F1C")]
	public void On_DeleteAccountScreen_Deleted()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1D45148", Offset = "0x1D45148", VA = "0x1D45148")]
	public void On_SettingsScreen_RedeemCode()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1D45150", Offset = "0x1D45150", VA = "0x1D45150")]
	public void On_RedeemCodeScreen_Back()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1D44614", Offset = "0x1D44614", VA = "0x1D44614")]
	public void ShowTermsOfUseScreen(bool autoAccount, string email, string password, bool newsletter)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1D45158", Offset = "0x1D45158", VA = "0x1D45158")]
	public void On_TermsOfUseScreen_No(bool autoAccount)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1D4516C", Offset = "0x1D4516C", VA = "0x1D4516C")]
	public void On_TermsOfUseScreen_Completed(bool autoAccount)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1D451B8", Offset = "0x1D451B8", VA = "0x1D451B8")]
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
	[Address(RVA = "0x1D4525C", Offset = "0x1D4525C", VA = "0x1D4525C")]
	public CloudSave_CoroutineCallback_InfoOnly(CloudSave_CoroutineCallback _baseCallback)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1D45288", Offset = "0x1D45288", VA = "0x1D45288", Slot = "4")]
	public void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1D4528C", Offset = "0x1D4528C", VA = "0x1D4528C", Slot = "5")]
	public void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1D45290", Offset = "0x1D45290", VA = "0x1D45290", Slot = "6")]
	public void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1D45364", Offset = "0x1D45364", VA = "0x1D45364", Slot = "7")]
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
	[Address(RVA = "0x1D454B4", Offset = "0x1D454B4", VA = "0x1D454B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1D4560C", Offset = "0x1D4560C", VA = "0x1D4560C", Slot = "4")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1D456E4", Offset = "0x1D456E4", VA = "0x1D456E4", Slot = "5")]
	public virtual string GetTextsLanguageID()
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1D45774", Offset = "0x1D45774", VA = "0x1D45774", Slot = "6")]
	public virtual string TranslateText(string trl)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1D45804", Offset = "0x1D45804", VA = "0x1D45804", Slot = "7")]
	public virtual string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1D45894", Offset = "0x1D45894", VA = "0x1D45894", Slot = "8")]
	public virtual string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1D45924", Offset = "0x1D45924", VA = "0x1D45924", Slot = "9")]
	public virtual void BackToMainMenuScene()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1D45998", Offset = "0x1D45998", VA = "0x1D45998", Slot = "10")]
	public virtual uint GetSaveCloudUserId()
	{
		return default(uint);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1D45A14", Offset = "0x1D45A14", VA = "0x1D45A14", Slot = "11")]
	public virtual CloudSave_Saves ExportGameSaves()
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1D45AB4", Offset = "0x1D45AB4", VA = "0x1D45AB4", Slot = "12")]
	public virtual void ImportGameSave(CloudSave_Saves cloudSaves)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1D45B28", Offset = "0x1D45B28", VA = "0x1D45B28", Slot = "13")]
	public virtual void DeleteLocalSaveOnRegister()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1D45B9C", Offset = "0x1D45B9C", VA = "0x1D45B9C", Slot = "14")]
	public virtual string GetSavePreviewLabels()
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1D45C2C", Offset = "0x1D45C2C", VA = "0x1D45C2C", Slot = "15")]
	public virtual string GetSavePreview(CloudSave_Saves save)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1D45CBC", Offset = "0x1D45CBC", VA = "0x1D45CBC", Slot = "16")]
	public virtual CompareSaveResult CompareSave(CloudSave_Saves save1, CloudSave_Saves save2)
	{
		return default(CompareSaveResult);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1D45D38", Offset = "0x1D45D38", VA = "0x1D45D38", Slot = "17")]
	public virtual bool CanSendChangedLocalSaveInCurrentLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1D45DB4", Offset = "0x1D45DB4", VA = "0x1D45DB4", Slot = "18")]
	public virtual GameObject GetCloudStatusLineObject()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1D45E30", Offset = "0x1D45E30", VA = "0x1D45E30", Slot = "19")]
	public virtual bool ShowCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1D45EAC", Offset = "0x1D45EAC", VA = "0x1D45EAC", Slot = "20")]
	public virtual bool ClearCloudSavesConflictMessageBox()
	{
		return default(bool);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1D45F28", Offset = "0x1D45F28", VA = "0x1D45F28", Slot = "21")]
	public virtual void PlaySound(SoundType sndType)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1D45F9C", Offset = "0x1D45F9C", VA = "0x1D45F9C", Slot = "22")]
	public virtual void OnShowCloudScreens()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1D46010", Offset = "0x1D46010", VA = "0x1D46010", Slot = "23")]
	public virtual bool HaveSaveForPromoCode()
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1D4608C", Offset = "0x1D4608C", VA = "0x1D4608C", Slot = "24")]
	public virtual string GetPromoCodeSkuName(string sku)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1D4611C", Offset = "0x1D4611C", VA = "0x1D4611C", Slot = "25")]
	public virtual void OnUsePromoCode(string sku)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1D46190", Offset = "0x1D46190", VA = "0x1D46190")]
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
	[Address(RVA = "0x1B0A5A8", Offset = "0x1B0A5A8", VA = "0x1B0A5A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1B0A66C", Offset = "0x1B0A66C", VA = "0x1B0A66C", Slot = "8")]
	public virtual void ActivateScreen()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1B0A670", Offset = "0x1B0A670", VA = "0x1B0A670", Slot = "9")]
	public virtual void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1B0A674", Offset = "0x1B0A674", VA = "0x1B0A674", Slot = "10")]
	public virtual void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1B0A678", Offset = "0x1B0A678", VA = "0x1B0A678", Slot = "11")]
	public virtual void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1B0A67C", Offset = "0x1B0A67C", VA = "0x1B0A67C", Slot = "12")]
	public virtual void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1B0A7CC", Offset = "0x1B0A7CC", VA = "0x1B0A7CC", Slot = "13")]
	public virtual void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1B0A86C", Offset = "0x1B0A86C", VA = "0x1B0A86C")]
	public void ClearInfoMessage()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1B0A8C8", Offset = "0x1B0A8C8", VA = "0x1B0A8C8", Slot = "14")]
	public virtual void SetInfoMessageText(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1B0A974", Offset = "0x1B0A974", VA = "0x1B0A974")]
	protected string TranslateText(string msg)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1B0A6BC", Offset = "0x1B0A6BC", VA = "0x1B0A6BC")]
	public static string TranslateTextWithErrorParse(string msg)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1B0AB4C", Offset = "0x1B0AB4C", VA = "0x1B0AB4C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D08", Offset = "0x9F9D08")]
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
			[Address(RVA = "0x1F0D640", Offset = "0x1F0D640", VA = "0x1F0D640", Slot = "4")]
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
			[Address(RVA = "0x1F0D688", Offset = "0x1F0D688", VA = "0x1F0D688", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1F0D580", Offset = "0x1F0D580", VA = "0x1F0D580")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1F0D5AC", Offset = "0x1F0D5AC", VA = "0x1F0D5AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1F0D5B0", Offset = "0x1F0D5B0", VA = "0x1F0D5B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1F0D648", Offset = "0x1F0D648", VA = "0x1F0D648", Slot = "8")]
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
	[Address(RVA = "0x1B0B760", Offset = "0x1B0B760", VA = "0x1B0B760")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1B126F8", Offset = "0x1B126F8", VA = "0x1B126F8")]
	public static CloudSave_ServerCoroutine Instantiate(CoroutineType type, CloudSave_CoroutineCallback callback, bool dontDestroyOnLoad)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1B129E8", Offset = "0x1B129E8", VA = "0x1B129E8", Slot = "4")]
	public virtual CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1B12A64", Offset = "0x1B12A64", VA = "0x1B12A64", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FBAA4", Offset = "0x9FBAA4")]
	public virtual IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1B12AC0", Offset = "0x1B12AC0", VA = "0x1B12AC0", Slot = "6")]
	public virtual bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1B0AE48", Offset = "0x1B0AE48", VA = "0x1B0AE48")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1B12B3C", Offset = "0x1B12B3C", VA = "0x1B12B3C")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1B12B44", Offset = "0x1B12B44", VA = "0x1B12B44")]
	protected void CallOnStart()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1B12C04", Offset = "0x1B12C04", VA = "0x1B12C04")]
	protected void CallOnEnd()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1B12CC4", Offset = "0x1B12CC4", VA = "0x1B12CC4")]
	protected void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1B12D98", Offset = "0x1B12D98", VA = "0x1B12D98")]
	protected void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1B12E80", Offset = "0x1B12E80", VA = "0x1B12E80")]
	protected string GetGameID()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1B12EF4", Offset = "0x1B12EF4", VA = "0x1B12EF4")]
	protected string GetGameVersion()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1B12F68", Offset = "0x1B12F68", VA = "0x1B12F68")]
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
	[Address(RVA = "0x1B0D948", Offset = "0x1B0D948", VA = "0x1B0D948")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1B0D9FC", Offset = "0x1B0D9FC", VA = "0x1B0D9FC")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1B0B1A4", Offset = "0x1B0B1A4", VA = "0x1B0B1A4")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1B13F90", Offset = "0x1B13F90", VA = "0x1B13F90")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1B0D87C", Offset = "0x1B0D87C", VA = "0x1B0D87C")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1B0D7C8", Offset = "0x1B0D7C8", VA = "0x1B0D7C8")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1B0B270", Offset = "0x1B0B270", VA = "0x1B0B270")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1B14044", Offset = "0x1B14044", VA = "0x1B14044")]
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
	[Address(RVA = "0x1B1409C", Offset = "0x1B1409C", VA = "0x1B1409C")]
	public void Start()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1B14270", Offset = "0x1B14270", VA = "0x1B14270")]
	public bool IsTranslated()
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1B140A0", Offset = "0x1B140A0", VA = "0x1B140A0")]
	public void TranslateText()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1B14278", Offset = "0x1B14278", VA = "0x1B14278")]
	public void TranslateFromStart()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1B142E0", Offset = "0x1B142E0", VA = "0x1B142E0")]
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
	[Address(RVA = "0x1D463D8", Offset = "0x1D463D8", VA = "0x1D463D8")]
	public CloudSave_Save()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1D46450", Offset = "0x1D46450", VA = "0x1D46450")]
	public CloudSave_Save(string _save)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1D464DC", Offset = "0x1D464DC", VA = "0x1D464DC")]
	public CloudSave_Save(string _save, List<KeyValuePair<string, string>> _properties)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1D466B4", Offset = "0x1D466B4", VA = "0x1D466B4")]
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
	[Address(RVA = "0x1D43D4C", Offset = "0x1D43D4C", VA = "0x1D43D4C")]
	public CloudSave_Saves()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1D46720", Offset = "0x1D46720", VA = "0x1D46720")]
	public CloudSave_Saves(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1D43BC0", Offset = "0x1D43BC0", VA = "0x1D43BC0")]
	public void Copy(CloudSave_Saves fromSaves)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1D467B0", Offset = "0x1D467B0", VA = "0x1D467B0")]
	public void AddSave(string name, string save)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1D46970", Offset = "0x1D46970", VA = "0x1D46970")]
	public void AddSave(string name, string save, List<KeyValuePair<string, string>> properties)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1D46B44", Offset = "0x1D46B44", VA = "0x1D46B44")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1D442E4", Offset = "0x1D442E4", VA = "0x1D442E4")]
	public int GetSavesCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1D43DC4", Offset = "0x1D43DC4", VA = "0x1D43DC4")]
	public string GetSaveName(int idx)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1D46B98", Offset = "0x1D46B98", VA = "0x1D46B98")]
	public string GetSave(int idx)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1D44000", Offset = "0x1D44000", VA = "0x1D44000")]
	public List<KeyValuePair<string, string>> GetSaveProperties(int idx)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1D43F2C", Offset = "0x1D43F2C", VA = "0x1D43F2C")]
	public bool HaveSave(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1D46D08", Offset = "0x1D46D08", VA = "0x1D46D08")]
	public string GetSave(string name)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1D44198", Offset = "0x1D44198", VA = "0x1D44198")]
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
	[Address(RVA = "0x1B139F4", Offset = "0x1B139F4", VA = "0x1B139F4")]
	public static bool IsEncryptionEstablished()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1B0C878", Offset = "0x1B0C878", VA = "0x1B0C878")]
	public static bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1B0BD4C", Offset = "0x1B0BD4C", VA = "0x1B0BD4C")]
	public static bool IsLoggedInAutoAccount()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1B0C94C", Offset = "0x1B0C94C", VA = "0x1B0C94C")]
	public static void clearUser()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1B14334", Offset = "0x1B14334", VA = "0x1B14334")]
	public static void clearUserAndSession()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1B143D4", Offset = "0x1B143D4", VA = "0x1B143D4")]
	public static uint GetAccountIDChecksum(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1B144A8", Offset = "0x1B144A8", VA = "0x1B144A8")]
	public static uint GetUIDFromAccountID(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1B0FAA0", Offset = "0x1B0FAA0", VA = "0x1B0FAA0")]
	public static string GetStringUIDFromAccountID(uint id)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1B1451C", Offset = "0x1B1451C", VA = "0x1B1451C")]
	public static bool GetAccountIDFromStringUID(string suid, out uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1B14700", Offset = "0x1B14700", VA = "0x1B14700")]
	public static bool GetAutoAccountLogin(out string email, out string password)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1B0D750", Offset = "0x1B0D750", VA = "0x1B0D750")]
	public static bool IsAutoAccountEmail(string email)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000016")]
public static class CloudSave_Utils
{
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1B14A70", Offset = "0x1B14A70", VA = "0x1B14A70")]
	public static string RSA_encrypt(string toBeEncrypted)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1B14A74", Offset = "0x1B14A74", VA = "0x1B14A74")]
	public static void generateAESkeyAndIV()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1B14A78", Offset = "0x1B14A78", VA = "0x1B14A78")]
	public static string AES_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1B14A80", Offset = "0x1B14A80", VA = "0x1B14A80")]
	public static string AES_encrypt(string input, bool MD5)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1B135E8", Offset = "0x1B135E8", VA = "0x1B135E8")]
	public static string AES_decrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1B14C50", Offset = "0x1B14C50", VA = "0x1B14C50")]
	private static string GetMd5Hash(MD5 md5Hash, string input)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1B14AFC", Offset = "0x1B14AFC", VA = "0x1B14AFC")]
	public static string MD5_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1B136CC", Offset = "0x1B136CC", VA = "0x1B136CC")]
	public static string MD5_encryptWithSalt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1B14D84", Offset = "0x1B14D84", VA = "0x1B14D84")]
	public static string Sha256_encrypt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1B14878", Offset = "0x1B14878", VA = "0x1B14878")]
	public static string Sha256_encryptWithSalt(string input)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1B15000", Offset = "0x1B15000", VA = "0x1B15000")]
	public static string convertBytesToString(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1B15048", Offset = "0x1B15048", VA = "0x1B15048")]
	public static byte[] convertStringToBytes(string s)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1B0E0F0", Offset = "0x1B0E0F0", VA = "0x1B0E0F0")]
	public static bool TestValidEmailFormat(string email)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1B15084", Offset = "0x1B15084", VA = "0x1B15084")]
	public static bool GetValueInsideTag(string text, string tag, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1B15250", Offset = "0x1B15250", VA = "0x1B15250")]
	public static string[] GetValuesInsideTags(string text, string tag)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1B15498", Offset = "0x1B15498", VA = "0x1B15498")]
	public static Dictionary<string, string> ParseKeysAssignedValues(string text, char delimeter)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1B1568C", Offset = "0x1B1568C", VA = "0x1B1568C")]
	public static bool GetValueOfTag(string text, string valTag, out string outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1B1574C", Offset = "0x1B1574C", VA = "0x1B1574C")]
	public static Dictionary<string, string> GetTagsAndValues(string text)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1B158EC", Offset = "0x1B158EC", VA = "0x1B158EC")]
	public static bool GetIntValueOfTag(string text, string valTag, out int outval)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1B0A9F0", Offset = "0x1B0A9F0", VA = "0x1B0A9F0")]
	public static bool ParseErrorCode(string text, out string errorText, out string errorExtCode)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1B15994", Offset = "0x1B15994", VA = "0x1B15994")]
	public static string GetUrlWithSecureProtocol(string url)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1B15A60", Offset = "0x1B15A60", VA = "0x1B15A60")]
	public static string GetWebGLUrlProxy(string url)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1B15A64", Offset = "0x1B15A64", VA = "0x1B15A64")]
	public static string GenRandomString(int len)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1B15B30", Offset = "0x1B15B30", VA = "0x1B15B30")]
	public static string EncodeBase64(string plain)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1B15BC0", Offset = "0x1B15BC0", VA = "0x1B15BC0")]
	public static string DecodeBase64(string encoded)
	{
		return null;
	}
}
[Token(Token = "0x2000017")]
public class CloudSave_ServerCoroutine_ChangePassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D18", Offset = "0x9F9D18")]
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
			[Address(RVA = "0x1F0DD64", Offset = "0x1F0DD64", VA = "0x1F0DD64", Slot = "4")]
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
			[Address(RVA = "0x1F0DDAC", Offset = "0x1F0DDAC", VA = "0x1F0DDAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1F0D690", Offset = "0x1F0D690", VA = "0x1F0D690")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1F0D6BC", Offset = "0x1F0D6BC", VA = "0x1F0D6BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1F0D6C0", Offset = "0x1F0D6C0", VA = "0x1F0D6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1F0DD6C", Offset = "0x1F0DD6C", VA = "0x1F0DD6C", Slot = "8")]
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
	[Address(RVA = "0x1B0B768", Offset = "0x1B0B768", VA = "0x1B0B768")]
	public void InitParams(string _oldPassword, string _newPassword)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1B12F70", Offset = "0x1B12F70", VA = "0x1B12F70", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1B12F78", Offset = "0x1B12F78", VA = "0x1B12F78", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1B12F80", Offset = "0x1B12F80", VA = "0x1B12F80", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FBB54", Offset = "0x9FBB54")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1B12FEC", Offset = "0x1B12FEC", VA = "0x1B12FEC")]
	public CloudSave_ServerCoroutine_ChangePassword()
	{
	}
}
[Token(Token = "0x2000019")]
public class CloudSave_ServerCoroutine_DeleteAccount : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D28", Offset = "0x9F9D28")]
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
			[Address(RVA = "0x1F0E40C", Offset = "0x1F0E40C", VA = "0x1F0E40C", Slot = "4")]
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
			[Address(RVA = "0x1F0E454", Offset = "0x1F0E454", VA = "0x1F0E454", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1F0DDB4", Offset = "0x1F0DDB4", VA = "0x1F0DDB4")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1F0DDE0", Offset = "0x1F0DDE0", VA = "0x1F0DDE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1F0DDE4", Offset = "0x1F0DDE4", VA = "0x1F0DDE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1F0E414", Offset = "0x1F0E414", VA = "0x1F0E414", Slot = "8")]
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
	[Address(RVA = "0x1B13040", Offset = "0x1B13040", VA = "0x1B13040")]
	public void InitParams(string _password)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1B13048", Offset = "0x1B13048", VA = "0x1B13048", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1B13050", Offset = "0x1B13050", VA = "0x1B13050", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1B13058", Offset = "0x1B13058", VA = "0x1B13058", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FBC04", Offset = "0x9FBC04")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1B130C4", Offset = "0x1B130C4", VA = "0x1B130C4")]
	public CloudSave_ServerCoroutine_DeleteAccount()
	{
	}
}
[Token(Token = "0x200001B")]
public class CloudSave_ServerCoroutine_LoadGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D38", Offset = "0x9F9D38")]
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
			[Address(RVA = "0x25D2838", Offset = "0x25D2838", VA = "0x25D2838", Slot = "4")]
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
			[Address(RVA = "0x25D2880", Offset = "0x25D2880", VA = "0x25D2880", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x25D21CC", Offset = "0x25D21CC", VA = "0x25D21CC")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x25D21F8", Offset = "0x25D21F8", VA = "0x25D21F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x25D21FC", Offset = "0x25D21FC", VA = "0x25D21FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x25D2840", Offset = "0x25D2840", VA = "0x25D2840", Slot = "8")]
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
	[Address(RVA = "0x1B13118", Offset = "0x1B13118", VA = "0x1B13118", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1B13120", Offset = "0x1B13120", VA = "0x1B13120", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1B0FA18", Offset = "0x1B0FA18", VA = "0x1B0FA18")]
	public CloudSave_Saves GetResultLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1B13128", Offset = "0x1B13128", VA = "0x1B13128")]
	public static bool ParseSavesFromServer(string text, CloudSave_Saves localSaves, out CloudSave_Saves outSaves)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1B13740", Offset = "0x1B13740", VA = "0x1B13740", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FBCB4", Offset = "0x9FBCB4")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1B137AC", Offset = "0x1B137AC", VA = "0x1B137AC")]
	public CloudSave_ServerCoroutine_LoadGameSave()
	{
	}
}
[Token(Token = "0x200001D")]
public class CloudSave_ServerCoroutine_Login : CloudSave_ServerCoroutine
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D48", Offset = "0x9F9D48")]
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
			[Address(RVA = "0x25D3730", Offset = "0x25D3730", VA = "0x25D3730", Slot = "4")]
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
			[Address(RVA = "0x25D3778", Offset = "0x25D3778", VA = "0x25D3778", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x25D2888", Offset = "0x25D2888", VA = "0x25D2888")]
		[DebuggerHidden]
		public <Run>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x25D28B4", Offset = "0x25D28B4", VA = "0x25D28B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x25D28B8", Offset = "0x25D28B8", VA = "0x25D28B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x25D3738", Offset = "0x25D3738", VA = "0x25D3738", Slot = "8")]
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
	[Address(RVA = "0x1B0E258", Offset = "0x1B0E258", VA = "0x1B0E258")]
	public void InitParams(bool _register, string _email, string _password, bool _newsletter, CloudSave_Saves _localSavesToCompare)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1B13810", Offset = "0x1B13810", VA = "0x1B13810", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1B13818", Offset = "0x1B13818", VA = "0x1B13818", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1B13820", Offset = "0x1B13820", VA = "0x1B13820")]
	public string GetEmail()
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1B13828", Offset = "0x1B13828", VA = "0x1B13828")]
	public string GetPassword()
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1B13830", Offset = "0x1B13830", VA = "0x1B13830")]
	public bool GetLoadSaveResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1B0D6C8", Offset = "0x1B0D6C8", VA = "0x1B0D6C8")]
	public CloudSave_Saves GetLoadedSaves()
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1B13838", Offset = "0x1B13838", VA = "0x1B13838", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FBD64", Offset = "0x9FBD64")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1B138A4", Offset = "0x1B138A4", VA = "0x1B138A4")]
	public CloudSave_ServerCoroutine_Login()
	{
	}
}
[Token(Token = "0x200001F")]
public class CloudSave_ServerCoroutine_OpenSSLSession : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D58", Offset = "0x9F9D58")]
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
			[Address(RVA = "0x25D4554", Offset = "0x25D4554", VA = "0x25D4554", Slot = "4")]
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
			[Address(RVA = "0x25D459C", Offset = "0x25D459C", VA = "0x25D459C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x25D3E50", Offset = "0x25D3E50", VA = "0x25D3E50")]
		[DebuggerHidden]
		public <Run>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x25D3E7C", Offset = "0x25D3E7C", VA = "0x25D3E7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x25D3E80", Offset = "0x25D3E80", VA = "0x25D3E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x25D455C", Offset = "0x25D455C", VA = "0x25D455C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D68", Offset = "0x9F9D68")]
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
			[Address(RVA = "0x25D3E00", Offset = "0x25D3E00", VA = "0x25D3E00", Slot = "4")]
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
			[Address(RVA = "0x25D3E48", Offset = "0x25D3E48", VA = "0x25D3E48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x25D3780", Offset = "0x25D3780", VA = "0x25D3780")]
		[DebuggerHidden]
		public <EstablishAESSecurity>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x25D37AC", Offset = "0x25D37AC", VA = "0x25D37AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x25D37B0", Offset = "0x25D37B0", VA = "0x25D37B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x25D3E08", Offset = "0x25D3E08", VA = "0x25D3E08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int aesTry;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1B13994", Offset = "0x1B13994", VA = "0x1B13994", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1B1399C", Offset = "0x1B1399C", VA = "0x1B1399C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1B13B7C", Offset = "0x1B13B7C", VA = "0x1B13B7C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FBE14", Offset = "0x9FBE14")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1B13BE8", Offset = "0x1B13BE8", VA = "0x1B13BE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FBE74", Offset = "0x9FBE74")]
	protected IEnumerator EstablishAESSecurity()
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1B13C54", Offset = "0x1B13C54", VA = "0x1B13C54")]
	public CloudSave_ServerCoroutine_OpenSSLSession()
	{
	}
}
[Token(Token = "0x2000022")]
public class CloudSave_ServerCoroutine_RedeemCode : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D78", Offset = "0x9F9D78")]
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
			[Address(RVA = "0x25D4C74", Offset = "0x25D4C74", VA = "0x25D4C74", Slot = "4")]
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
			[Address(RVA = "0x25D4CBC", Offset = "0x25D4CBC", VA = "0x25D4CBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x25D45A4", Offset = "0x25D45A4", VA = "0x25D45A4")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x25D45D0", Offset = "0x25D45D0", VA = "0x25D45D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x25D45D4", Offset = "0x25D45D4", VA = "0x25D45D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x25D4C7C", Offset = "0x25D4C7C", VA = "0x25D4C7C", Slot = "8")]
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
	[Address(RVA = "0x1B13C5C", Offset = "0x1B13C5C", VA = "0x1B13C5C")]
	public void InitParams(string _code)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1B13C64", Offset = "0x1B13C64", VA = "0x1B13C64", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1B13C6C", Offset = "0x1B13C6C", VA = "0x1B13C6C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1B13C74", Offset = "0x1B13C74", VA = "0x1B13C74")]
	public string GetResultSku()
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1B13C7C", Offset = "0x1B13C7C", VA = "0x1B13C7C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FBF74", Offset = "0x9FBF74")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1B13CE8", Offset = "0x1B13CE8", VA = "0x1B13CE8")]
	public CloudSave_ServerCoroutine_RedeemCode()
	{
	}
}
[Token(Token = "0x2000024")]
public class CloudSave_ServerCoroutine_SendResetPassword : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D88", Offset = "0x9F9D88")]
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
			[Address(RVA = "0x25D5364", Offset = "0x25D5364", VA = "0x25D5364", Slot = "4")]
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
			[Address(RVA = "0x25D53AC", Offset = "0x25D53AC", VA = "0x25D53AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x25D4CC4", Offset = "0x25D4CC4", VA = "0x25D4CC4")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x25D4CF0", Offset = "0x25D4CF0", VA = "0x25D4CF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x25D4CF4", Offset = "0x25D4CF4", VA = "0x25D4CF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x25D536C", Offset = "0x25D536C", VA = "0x25D536C", Slot = "8")]
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
	[Address(RVA = "0x1B13D40", Offset = "0x1B13D40", VA = "0x1B13D40")]
	public void InitParams(string _email)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1B13D48", Offset = "0x1B13D48", VA = "0x1B13D48", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1B13D50", Offset = "0x1B13D50", VA = "0x1B13D50", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1B13D58", Offset = "0x1B13D58", VA = "0x1B13D58", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC024", Offset = "0x9FC024")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1B13DC4", Offset = "0x1B13DC4", VA = "0x1B13DC4")]
	public CloudSave_ServerCoroutine_SendResetPassword()
	{
	}
}
[Token(Token = "0x2000026")]
public class CloudSave_ServerCoroutine_SetNewsletter : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D98", Offset = "0x9F9D98")]
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
			[Address(RVA = "0x25D5A84", Offset = "0x25D5A84", VA = "0x25D5A84", Slot = "4")]
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
			[Address(RVA = "0x25D5ACC", Offset = "0x25D5ACC", VA = "0x25D5ACC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x25D53B4", Offset = "0x25D53B4", VA = "0x25D53B4")]
		[DebuggerHidden]
		public <Run>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x25D53E0", Offset = "0x25D53E0", VA = "0x25D53E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x25D53E4", Offset = "0x25D53E4", VA = "0x25D53E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x25D5A8C", Offset = "0x25D5A8C", VA = "0x25D5A8C", Slot = "8")]
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
	[Address(RVA = "0x1B13E18", Offset = "0x1B13E18", VA = "0x1B13E18")]
	public void InitParams(bool _signed)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1B13E24", Offset = "0x1B13E24", VA = "0x1B13E24", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1B13E2C", Offset = "0x1B13E2C", VA = "0x1B13E2C", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1B13E34", Offset = "0x1B13E34", VA = "0x1B13E34", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC0D4", Offset = "0x9FC0D4")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1B13EA0", Offset = "0x1B13EA0", VA = "0x1B13EA0")]
	public CloudSave_ServerCoroutine_SetNewsletter()
	{
	}
}
[Token(Token = "0x2000028")]
public class CloudSave_ServerCoroutine_StoreGameSave : CloudSave_ServerCoroutine
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9DA8", Offset = "0x9F9DA8")]
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
			[Address(RVA = "0x25D6C80", Offset = "0x25D6C80", VA = "0x25D6C80", Slot = "4")]
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
			[Address(RVA = "0x25D6CC8", Offset = "0x25D6CC8", VA = "0x25D6CC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x25D5AD4", Offset = "0x25D5AD4", VA = "0x25D5AD4")]
		[DebuggerHidden]
		public <Run>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x25D5B00", Offset = "0x25D5B00", VA = "0x25D5B00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x25D5B04", Offset = "0x25D5B04", VA = "0x25D5B04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x25D6C88", Offset = "0x25D6C88", VA = "0x25D6C88", Slot = "8")]
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
	[Address(RVA = "0x1B10400", Offset = "0x1B10400", VA = "0x1B10400")]
	public void InitParams(CloudSave_Saves _storeSaves)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1B13EA8", Offset = "0x1B13EA8", VA = "0x1B13EA8", Slot = "4")]
	public override CoroutineType GetCoroutineType()
	{
		return default(CoroutineType);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1B13EB0", Offset = "0x1B13EB0", VA = "0x1B13EB0", Slot = "6")]
	public override bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1B13EB8", Offset = "0x1B13EB8", VA = "0x1B13EB8")]
	public CloudSave_Saves GetStoringSaves()
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1B13EC0", Offset = "0x1B13EC0", VA = "0x1B13EC0", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC184", Offset = "0x9FC184")]
	public override IEnumerator Run()
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1B13F2C", Offset = "0x1B13F2C", VA = "0x1B13F2C")]
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
	[Address(RVA = "0x1B0AB54", Offset = "0x1B0AB54", VA = "0x1B0AB54", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1B0ADA8", Offset = "0x1B0ADA8", VA = "0x1B0ADA8", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1B0AEC0", Offset = "0x1B0AEC0", VA = "0x1B0AEC0", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1B0AF9C", Offset = "0x1B0AF9C", VA = "0x1B0AF9C", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1B0B318", Offset = "0x1B0B318", VA = "0x1B0B318")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1B0B384", Offset = "0x1B0B384", VA = "0x1B0B384")]
	public void OnSwitchShowOldPassword(bool on)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1B0B450", Offset = "0x1B0B450", VA = "0x1B0B450")]
	public void OnSwitchShowNewPassword(bool on)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1B0B458", Offset = "0x1B0B458", VA = "0x1B0B458")]
	public void OnSwitchShowRepeatPassword(bool on)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1B0B38C", Offset = "0x1B0B38C", VA = "0x1B0B38C")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1B0B460", Offset = "0x1B0B460", VA = "0x1B0B460")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1B0B770", Offset = "0x1B0B770", VA = "0x1B0B770")]
	public CloudSave_Screen_ChangePassword()
	{
	}
}
[Token(Token = "0x200002B")]
public class CloudSave_Screen_CloudInfo : CloudSave_Screen
{
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9DB8", Offset = "0x9F9DB8")]
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
			[Address(RVA = "0x1F0D530", Offset = "0x1F0D530", VA = "0x1F0D530", Slot = "4")]
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
			[Address(RVA = "0x1F0D578", Offset = "0x1F0D578", VA = "0x1F0D578", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1F0D1E4", Offset = "0x1F0D1E4", VA = "0x1F0D1E4")]
		[DebuggerHidden]
		public <AnimDotsCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1F0D210", Offset = "0x1F0D210", VA = "0x1F0D210", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1F0D214", Offset = "0x1F0D214", VA = "0x1F0D214", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1F0D538", Offset = "0x1F0D538", VA = "0x1F0D538", Slot = "8")]
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
	[Address(RVA = "0x1B0B7C4", Offset = "0x1B0B7C4", VA = "0x1B0B7C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1B0B8C0", Offset = "0x1B0B8C0", VA = "0x1B0B8C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1B0B8C4", Offset = "0x1B0B8C4", VA = "0x1B0B8C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1B0B95C", Offset = "0x1B0B95C", VA = "0x1B0B95C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1B0B984", Offset = "0x1B0B984", VA = "0x1B0B984", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1B0B9AC", Offset = "0x1B0B9AC", VA = "0x1B0B9AC")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1B0BA18", Offset = "0x1B0BA18", VA = "0x1B0BA18")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1B0BA84", Offset = "0x1B0BA84", VA = "0x1B0BA84")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1B0BAF0", Offset = "0x1B0BAF0", VA = "0x1B0BAF0")]
	public void OnClickCloseToLogin()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1B0B8F0", Offset = "0x1B0B8F0", VA = "0x1B0B8F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC234", Offset = "0x9FC234")]
	protected IEnumerator AnimDotsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1B0BB5C", Offset = "0x1B0BB5C", VA = "0x1B0BB5C")]
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
	[Address(RVA = "0x1B0BB6C", Offset = "0x1B0BB6C", VA = "0x1B0BB6C", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1B0BDB0", Offset = "0x1B0BDB0", VA = "0x1B0BDB0", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1B0BE50", Offset = "0x1B0BE50", VA = "0x1B0BE50", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1B0BF2C", Offset = "0x1B0BF2C", VA = "0x1B0BF2C", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1B0C0B0", Offset = "0x1B0C0B0", VA = "0x1B0C0B0")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1B0C11C", Offset = "0x1B0C11C", VA = "0x1B0C11C")]
	public void OnSwitchShowPassword(bool on)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1B0C174", Offset = "0x1B0C174", VA = "0x1B0C174")]
	public void OnClickDelete()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1B0C324", Offset = "0x1B0C324", VA = "0x1B0C324")]
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
	[Address(RVA = "0x1B0C32C", Offset = "0x1B0C32C", VA = "0x1B0C32C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1B0C3A4", Offset = "0x1B0C3A4", VA = "0x1B0C3A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1B0C3A8", Offset = "0x1B0C3A8", VA = "0x1B0C3A8", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1B0CCC4", Offset = "0x1B0CCC4", VA = "0x1B0CCC4", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1B0CD64", Offset = "0x1B0CD64", VA = "0x1B0CD64")]
	public void WillBackFromTermsOfUseCompleted()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1B0CD70", Offset = "0x1B0CD70", VA = "0x1B0CD70")]
	public void OnBackFromTermsOfUse(string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1B0CF04", Offset = "0x1B0CF04", VA = "0x1B0CF04")]
	public void OnBackFromTermsOfUseLogin(string _email, string _password, bool _newsletter, CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1B0D500", Offset = "0x1B0D500", VA = "0x1B0D500", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1B0D5DC", Offset = "0x1B0D5DC", VA = "0x1B0D5DC", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1B0CF38", Offset = "0x1B0CF38", VA = "0x1B0CF38")]
	protected void OnEndCoroutine(CloudSave_ServerCoroutine coroutine, bool fromTermsOfUse)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1B0CA44", Offset = "0x1B0CA44", VA = "0x1B0CA44")]
	private void UpdateModeFields()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1B0C700", Offset = "0x1B0C700", VA = "0x1B0C700")]
	private void LoadFromPlayerPrefs()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1B0DAB0", Offset = "0x1B0DAB0", VA = "0x1B0DAB0")]
	private void OnLogin(bool confirmDeleteSaveOnRegister)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1B0E290", Offset = "0x1B0E290", VA = "0x1B0E290")]
	private void DeleteSaveOnRegisterCallback(bool result)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1B0E3AC", Offset = "0x1B0E3AC", VA = "0x1B0E3AC")]
	private void DeleteSaveOnLoginToEmptyCallback(bool result)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1B0E4DC", Offset = "0x1B0E4DC", VA = "0x1B0E4DC")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1B0E548", Offset = "0x1B0E548", VA = "0x1B0E548")]
	public void OnClickShowInfo()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1B0E5B4", Offset = "0x1B0E5B4", VA = "0x1B0E5B4")]
	public void OnClickSwitchLogin(bool switched)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1B0E640", Offset = "0x1B0E640", VA = "0x1B0E640")]
	public void OnClickSwitchRegister(bool switched)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1B0CCBC", Offset = "0x1B0CCBC", VA = "0x1B0CCBC")]
	public void OnClickLogin()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1B0E6C8", Offset = "0x1B0E6C8", VA = "0x1B0E6C8")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1B0E788", Offset = "0x1B0E788", VA = "0x1B0E788")]
	public void OnSwitchShowPassword1(bool on)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1B0E824", Offset = "0x1B0E824", VA = "0x1B0E824")]
	public void OnSwitchShowPassword2(bool on)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1B0E790", Offset = "0x1B0E790", VA = "0x1B0E790")]
	public void OnSwitchShowPassword(int num, bool on)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1B0E82C", Offset = "0x1B0E82C", VA = "0x1B0E82C")]
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
	[Address(RVA = "0x1B0E890", Offset = "0x1B0E890", VA = "0x1B0E890", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1B0F27C", Offset = "0x1B0F27C", VA = "0x1B0F27C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1B0F318", Offset = "0x1B0F318", VA = "0x1B0F318")]
	public void Update()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1B0F440", Offset = "0x1B0F440", VA = "0x1B0F440", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1B0F5B0", Offset = "0x1B0F5B0", VA = "0x1B0F5B0", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1B0F758", Offset = "0x1B0F758", VA = "0x1B0F758")]
	protected void OnEndCoroutineLoad()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1B0F884", Offset = "0x1B0F884", VA = "0x1B0F884")]
	protected void OnEndCoroutineStore()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1B0EED4", Offset = "0x1B0EED4", VA = "0x1B0EED4")]
	protected void EnableImportExportButtons(bool import, bool export)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1B0EBA4", Offset = "0x1B0EBA4", VA = "0x1B0EBA4")]
	protected void FillLoginInfo()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1B0EFE0", Offset = "0x1B0EFE0", VA = "0x1B0EFE0")]
	protected void UpdateAfterReceivedCloudSave()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1B0FEF4", Offset = "0x1B0FEF4", VA = "0x1B0FEF4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1B0FF60", Offset = "0x1B0FF60", VA = "0x1B0FF60")]
	public void OnClickSettings()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1B0FFCC", Offset = "0x1B0FFCC", VA = "0x1B0FFCC")]
	public void OnSwitchShowEmail(bool on)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1B0FFD0", Offset = "0x1B0FFD0", VA = "0x1B0FFD0")]
	public void OnClickSetPassword()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1B10090", Offset = "0x1B10090", VA = "0x1B10090")]
	public void OnClickLogout()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1B10150", Offset = "0x1B10150", VA = "0x1B10150")]
	public void OnClickImport()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1B0FC9C", Offset = "0x1B0FC9C", VA = "0x1B0FC9C")]
	public void OnClickExport()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1B1041C", Offset = "0x1B1041C", VA = "0x1B1041C")]
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
	[Address(RVA = "0x1B10480", Offset = "0x1B10480", VA = "0x1B10480", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1B104A8", Offset = "0x1B104A8", VA = "0x1B104A8", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1B104D0", Offset = "0x1B104D0", VA = "0x1B104D0")]
	public void Init(string text, bool okcancel, bool warning, CloudSave_Screen _backToScreen, Action<bool> _resultCallback)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1B10618", Offset = "0x1B10618", VA = "0x1B10618")]
	public void OnClickOK()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1B10690", Offset = "0x1B10690", VA = "0x1B10690")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1B10708", Offset = "0x1B10708", VA = "0x1B10708")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1B10780", Offset = "0x1B10780", VA = "0x1B10780")]
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
	[Address(RVA = "0x1B10788", Offset = "0x1B10788", VA = "0x1B10788", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1B10804", Offset = "0x1B10804", VA = "0x1B10804", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1B108A4", Offset = "0x1B108A4", VA = "0x1B108A4", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1B10980", Offset = "0x1B10980", VA = "0x1B10980", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1B10C1C", Offset = "0x1B10C1C", VA = "0x1B10C1C")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1B10C88", Offset = "0x1B10C88", VA = "0x1B10C88")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1B10E68", Offset = "0x1B10E68", VA = "0x1B10E68")]
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
	[Address(RVA = "0x1B10EBC", Offset = "0x1B10EBC", VA = "0x1B10EBC", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1B10FCC", Offset = "0x1B10FCC", VA = "0x1B10FCC", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1B1106C", Offset = "0x1B1106C", VA = "0x1B1106C")]
	public void Init(bool _backToSettings)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1B11078", Offset = "0x1B11078", VA = "0x1B11078", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1B11154", Offset = "0x1B11154", VA = "0x1B11154", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1B112CC", Offset = "0x1B112CC", VA = "0x1B112CC")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1B11340", Offset = "0x1B11340", VA = "0x1B11340")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1B114A0", Offset = "0x1B114A0", VA = "0x1B114A0")]
	public CloudSave_Screen_ResetPassword()
	{
	}
}
[Token(Token = "0x2000034")]
public class CloudSave_Screen_SelectMode : CloudSave_Screen_CloudInfo
{
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1B114F4", Offset = "0x1B114F4", VA = "0x1B114F4", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1B1151C", Offset = "0x1B1151C", VA = "0x1B1151C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1B11544", Offset = "0x1B11544", VA = "0x1B11544")]
	public void OnClickModeEmail()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1B115B0", Offset = "0x1B115B0", VA = "0x1B115B0")]
	public void OnClickModeAuto()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1B1161C", Offset = "0x1B1161C", VA = "0x1B1161C")]
	public new void OnClickBack()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1B11688", Offset = "0x1B11688", VA = "0x1B11688")]
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
	[Address(RVA = "0x1B11698", Offset = "0x1B11698", VA = "0x1B11698", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1B1197C", Offset = "0x1B1197C", VA = "0x1B1197C", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1B11A1C", Offset = "0x1B11A1C", VA = "0x1B11A1C", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1B11AF8", Offset = "0x1B11AF8", VA = "0x1B11AF8", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1B11C10", Offset = "0x1B11C10", VA = "0x1B11C10")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1B11C7C", Offset = "0x1B11C7C", VA = "0x1B11C7C")]
	public void OnClickChangePassword()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1B11CE8", Offset = "0x1B11CE8", VA = "0x1B11CE8")]
	public void OnClickResetPassword()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1B11D54", Offset = "0x1B11D54", VA = "0x1B11D54")]
	public void OnClickDeleteAccount()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1B11DC0", Offset = "0x1B11DC0", VA = "0x1B11DC0")]
	public void OnClickRedeemCode()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1B11E2C", Offset = "0x1B11E2C", VA = "0x1B11E2C")]
	public void OnSwitchNewsletter(bool signed)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1B11FBC", Offset = "0x1B11FBC", VA = "0x1B11FBC")]
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
	[Address(RVA = "0x1B11FC4", Offset = "0x1B11FC4", VA = "0x1B11FC4", Slot = "8")]
	public override void ActivateScreen()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1B11FEC", Offset = "0x1B11FEC", VA = "0x1B11FEC", Slot = "9")]
	public override void DeactivateScreen()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1B1208C", Offset = "0x1B1208C", VA = "0x1B1208C")]
	public void Init(bool _autoAccount, string _email, string _password, bool _newsletter)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1B120A4", Offset = "0x1B120A4", VA = "0x1B120A4", Slot = "10")]
	public override void OnStartCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1B12180", Offset = "0x1B12180", VA = "0x1B12180", Slot = "11")]
	public override void OnEndCoroutine(CloudSave_ServerCoroutine coroutine)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1B123DC", Offset = "0x1B123DC", VA = "0x1B123DC", Slot = "12")]
	public override void InfoMessage(string strMsg, bool warning)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1B12444", Offset = "0x1B12444", VA = "0x1B12444", Slot = "13")]
	public override void InfoMessage(string strMsg1, string strMsg2, bool warning)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1B12454", Offset = "0x1B12454", VA = "0x1B12454")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1B125E0", Offset = "0x1B125E0", VA = "0x1B125E0")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1B126A0", Offset = "0x1B126A0", VA = "0x1B126A0")]
	public CloudSave_Screen_TermsOfUse()
	{
	}
}
[Token(Token = "0x2000037")]
public class CloudSave_AdjustIconToText : MonoBehaviour
{
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9DC8", Offset = "0x9F9DC8")]
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
			[Address(RVA = "0x1F0D194", Offset = "0x1F0D194", VA = "0x1F0D194", Slot = "4")]
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
			[Address(RVA = "0x1F0D1DC", Offset = "0x1F0D1DC", VA = "0x1F0D1DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1F0CC04", Offset = "0x1F0CC04", VA = "0x1F0CC04")]
		[DebuggerHidden]
		public <AdjustToTextCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1F0CC30", Offset = "0x1F0CC30", VA = "0x1F0CC30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1F0CC34", Offset = "0x1F0CC34", VA = "0x1F0CC34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1F0D19C", Offset = "0x1F0D19C", VA = "0x1F0D19C", Slot = "8")]
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
	[Address(RVA = "0x1D4135C", Offset = "0x1D4135C", VA = "0x1D4135C")]
	public void Start()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1D41388", Offset = "0x1D41388", VA = "0x1D41388")]
	private void AdjustToText()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1D413B4", Offset = "0x1D413B4", VA = "0x1D413B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC2E4", Offset = "0x9FC2E4")]
	public IEnumerator AdjustToTextCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1D41420", Offset = "0x1D41420", VA = "0x1D41420")]
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
		[Address(RVA = "0x1D41428", Offset = "0x1D41428", VA = "0x1D41428")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1D41430", Offset = "0x1D41430", VA = "0x1D41430")]
		set
		{
		}
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1D4157C", Offset = "0x1D4157C", VA = "0x1D4157C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1D4143C", Offset = "0x1D4143C", VA = "0x1D4143C")]
	private void changeMaterial()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x1D415E4", Offset = "0x1D415E4", VA = "0x1D415E4")]
	public void changeOtherMaterial(Material m)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1D416E4", Offset = "0x1D416E4", VA = "0x1D416E4")]
	private void Click()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1D417EC", Offset = "0x1D417EC", VA = "0x1D417EC")]
	public void SetChecked(bool on)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1D417F8", Offset = "0x1D417F8", VA = "0x1D417F8")]
	public void SetCallbackWithObject(bool on)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1D41804", Offset = "0x1D41804", VA = "0x1D41804")]
	public void SetCustomParam(string param)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1D4180C", Offset = "0x1D4180C", VA = "0x1D4180C")]
	public string GetCustomParam()
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1D41814", Offset = "0x1D41814", VA = "0x1D41814")]
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
	[Address(RVA = "0x1D4619C", Offset = "0x1D4619C", VA = "0x1D4619C")]
	public void ShowText(string txt, bool warning)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1D4496C", Offset = "0x1D4496C", VA = "0x1D4496C")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1D46340", Offset = "0x1D46340", VA = "0x1D46340")]
	public bool IsWarning()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1D46348", Offset = "0x1D46348", VA = "0x1D46348")]
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
	[Address(RVA = "0x2469704", Offset = "0x2469704", VA = "0x2469704")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x24697DC", Offset = "0x24697DC", VA = "0x24697DC")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x2469A74", Offset = "0x2469A74", VA = "0x2469A74")]
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
		[Address(RVA = "0x25DA5A8", Offset = "0x25DA5A8", VA = "0x25DA5A8")]
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
	[Address(RVA = "0x2469A7C", Offset = "0x2469A7C", VA = "0x2469A7C")]
	public static void UpdateMaterialsForObjectsWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2469E4C", Offset = "0x2469E4C", VA = "0x2469E4C")]
	public static void UpdateMaterialForObjectWithoutClippedScroll(GameObject go)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x246A0D0", Offset = "0x246A0D0", VA = "0x246A0D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x246A63C", Offset = "0x246A63C", VA = "0x246A63C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x246A6DC", Offset = "0x246A6DC", VA = "0x246A6DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x246A868", Offset = "0x246A868", VA = "0x246A868")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x246A8E4", Offset = "0x246A8E4", VA = "0x246A8E4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x246AA54", Offset = "0x246AA54", VA = "0x246AA54")]
	private Vector2 Scale()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x246AACC", Offset = "0x246AACC", VA = "0x246AACC")]
	public static Vector2 Scale(GameObject go, bool inclSelfScale)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x246ABC0", Offset = "0x246ABC0", VA = "0x246ABC0")]
	public void ContentsChanged()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x246ABD8", Offset = "0x246ABD8", VA = "0x246ABD8")]
	public void SetKeepMinOrgScrollSize(bool s)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x246A628", Offset = "0x246A628", VA = "0x246A628")]
	public void AutoAdjustToContents(bool adjustAfterChanges = true)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x246ABE4", Offset = "0x246ABE4", VA = "0x246ABE4")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x246AFF4", Offset = "0x246AFF4", VA = "0x246AFF4")]
	public void FreezeScroll(bool freeze)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x246B000", Offset = "0x246B000", VA = "0x246B000")]
	public bool HaveClippedContents()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x246B05C", Offset = "0x246B05C", VA = "0x246B05C")]
	public bool HaveClippedContentsX()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x246B088", Offset = "0x246B088", VA = "0x246B088")]
	public bool HaveClippedContentsY()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x246B0B4", Offset = "0x246B0B4", VA = "0x246B0B4")]
	public bool IsScreenPointInBounds(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x246B250", Offset = "0x246B250", VA = "0x246B250")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x246B354", Offset = "0x246B354", VA = "0x246B354")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x246B404", Offset = "0x246B404", VA = "0x246B404")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x246B460", Offset = "0x246B460", VA = "0x246B460")]
	public void ScrollToTop()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x246B4C0", Offset = "0x246B4C0", VA = "0x246B4C0")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x246B520", Offset = "0x246B520", VA = "0x246B520")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x246B588", Offset = "0x246B588", VA = "0x246B588")]
	public bool IsScrolledToY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x246B5FC", Offset = "0x246B5FC", VA = "0x246B5FC")]
	public bool IsInsideClipAreaY(float y, float margin = 0.1f)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x246B664", Offset = "0x246B664", VA = "0x246B664")]
	public bool IsDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x246B66C", Offset = "0x246B66C", VA = "0x246B66C")]
	public void EnsureVisible(Vector3 pos)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x246B854", Offset = "0x246B854", VA = "0x246B854")]
	public bool IsClippedOutColChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x246B95C", Offset = "0x246B95C", VA = "0x246B95C")]
	public bool IsClippedOutRendChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x246BA64", Offset = "0x246BA64", VA = "0x246BA64")]
	public void AddIgnoredNotClippedChild(GameObject go)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x246BAC8", Offset = "0x246BAC8", VA = "0x246BAC8")]
	private bool IsIgnoredNotClippedChild(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x246BBB8", Offset = "0x246BBB8", VA = "0x246BBB8")]
	public void SetExtendHorzSizeToScreen()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x246BBC4", Offset = "0x246BBC4", VA = "0x246BBC4")]
	public void SetZoomContents(GameObject rootObj, float min, float max, float speed)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x246BBD8", Offset = "0x246BBD8", VA = "0x246BBD8")]
	public bool HaveZoomContents()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x246BC44", Offset = "0x246BC44", VA = "0x246BC44")]
	public static MUI_ClippedScroll GetActiveScroll(Vector2 atPoint)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x246BE08", Offset = "0x246BE08", VA = "0x246BE08")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x246D00C", Offset = "0x246D00C", VA = "0x246D00C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x246D6C8", Offset = "0x246D6C8", VA = "0x246D6C8")]
	private void ClipBkgToScreen()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x246C1C8", Offset = "0x246C1C8", VA = "0x246C1C8")]
	private void AdjustHorzSizeToScreen()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x246D2D8", Offset = "0x246D2D8", VA = "0x246D2D8")]
	private void AdjustScrollSizeToContents()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x246E454", Offset = "0x246E454", VA = "0x246E454")]
	private void UpdateMaterials(GameObject go, ref Bounds mergedBounds)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x246F11C", Offset = "0x246F11C", VA = "0x246F11C")]
	private BoxColliderInfo GetBoxColliderOrgSize(BoxCollider box, Vector2 scale)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x246F43C", Offset = "0x246F43C", VA = "0x246F43C")]
	private void UpdateBounds(GameObject go)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x246B870", Offset = "0x246B870", VA = "0x246B870")]
	private int GetClippedOutColChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x246B978", Offset = "0x246B978", VA = "0x246B978")]
	private int GetClippedOutRendChildIdx(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x246DD24", Offset = "0x246DD24", VA = "0x246DD24")]
	private void UpdateAfterChanged()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x246AC84", Offset = "0x246AC84", VA = "0x246AC84")]
	private void UpdateScroll()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x246B254", Offset = "0x246B254", VA = "0x246B254")]
	private void Scroll(float x, float y)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x2470100", Offset = "0x2470100", VA = "0x2470100")]
	private Vector2 ScreenPointToWorldPos(Vector2 p)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x246B0E4", Offset = "0x246B0E4", VA = "0x246B0E4")]
	private bool IsScreenPointInClipArea(Vector3 p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x2470374", Offset = "0x2470374", VA = "0x2470374")]
	public void OnScrollBarDown(MUI_ClippedScroll_Bar bar, bool down)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x246C4FC", Offset = "0x246C4FC", VA = "0x246C4FC")]
	private void StepDrag()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x246CBE8", Offset = "0x246CBE8", VA = "0x246CBE8")]
	private void StepScrollMouseWheel()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x246CE20", Offset = "0x246CE20", VA = "0x246CE20")]
	private void StepZoom()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x24704CC", Offset = "0x24704CC", VA = "0x24704CC")]
	public bool HaveOpenComboBoxChild()
	{
		return default(bool);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x24705B4", Offset = "0x24705B4", VA = "0x24705B4")]
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
	[Address(RVA = "0x2470748", Offset = "0x2470748", VA = "0x2470748")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x24707AC", Offset = "0x24707AC", VA = "0x24707AC")]
	public void Down()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x247083C", Offset = "0x247083C", VA = "0x247083C")]
	public void Up()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x24708CC", Offset = "0x24708CC", VA = "0x24708CC")]
	public void Click()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x247095C", Offset = "0x247095C", VA = "0x247095C")]
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
	[Address(RVA = "0x1D41354", Offset = "0x1D41354", VA = "0x1D41354")]
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
	[Address(RVA = "0x1D4134C", Offset = "0x1D4134C", VA = "0x1D4134C")]
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
	[Address(RVA = "0x2470964", Offset = "0x2470964", VA = "0x2470964")]
	public MUI_ClippedScroll_Materials()
	{
	}
}
[Token(Token = "0x2000043")]
public class MUI_Continous : MonoBehaviour
{
	[Token(Token = "0x6000217")]
	[Address(RVA = "0x247096C", Offset = "0x247096C", VA = "0x247096C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2470A34", Offset = "0x2470A34", VA = "0x2470A34")]
	private bool CastRay(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2470CCC", Offset = "0x2470CCC", VA = "0x2470CCC")]
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
	[Address(RVA = "0x1D3F3C8", Offset = "0x1D3F3C8", VA = "0x1D3F3C8")]
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
	[Address(RVA = "0x2470CD4", Offset = "0x2470CD4", VA = "0x2470CD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x2470D3C", Offset = "0x2470D3C", VA = "0x2470D3C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x2470E14", Offset = "0x2470E14", VA = "0x2470E14")]
	private void Start()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x247117C", Offset = "0x247117C", VA = "0x247117C")]
	public static LayerMask GetMUIlayerMask()
	{
		return default(LayerMask);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x24711E0", Offset = "0x24711E0", VA = "0x24711E0")]
	public static Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x2471244", Offset = "0x2471244", VA = "0x2471244")]
	public static void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x24712AC", Offset = "0x24712AC", VA = "0x24712AC")]
	public static void ClearLayerMask()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x2471324", Offset = "0x2471324", VA = "0x2471324")]
	public static bool WasNowClickDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x2471070", Offset = "0x2471070", VA = "0x2471070")]
	public static void AddLayer(string layer)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x2471388", Offset = "0x2471388", VA = "0x2471388")]
	public static void RemoveLayer(string layer)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x24714F8", Offset = "0x24714F8", VA = "0x24714F8")]
	public static bool IsDraggingItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x247165C", Offset = "0x247165C", VA = "0x247165C")]
	private void Zoom()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x2471BE8", Offset = "0x2471BE8", VA = "0x2471BE8")]
	private void Drag()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x24724B8", Offset = "0x24724B8", VA = "0x24724B8")]
	private bool IsChildOfActiveScroll(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x24725AC", Offset = "0x24725AC", VA = "0x24725AC")]
	private bool FingerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x24726A8", Offset = "0x24726A8", VA = "0x24726A8")]
	private bool FingerUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x2472790", Offset = "0x2472790", VA = "0x2472790")]
	private void Update()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x2472A38", Offset = "0x2472A38", VA = "0x2472A38")]
	private void CastRay(bool down, bool up, bool move)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x2473178", Offset = "0x2473178", VA = "0x2473178")]
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
		[Address(RVA = "0x1D41334", Offset = "0x1D41334", VA = "0x1D41334")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1D4133C", Offset = "0x1D4133C", VA = "0x1D4133C")]
		set
		{
		}
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1D41344", Offset = "0x1D41344", VA = "0x1D41344")]
	public ClipboardHelper()
	{
	}
}
[Token(Token = "0x2000047")]
public class MUI_InputText : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9DD8", Offset = "0x9F9DD8")]
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
			[Address(RVA = "0x25DB638", Offset = "0x25DB638", VA = "0x25DB638", Slot = "4")]
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
			[Address(RVA = "0x25DB680", Offset = "0x25DB680", VA = "0x25DB680", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x25DA5B0", Offset = "0x25DA5B0", VA = "0x25DA5B0")]
		[DebuggerHidden]
		public <ReadKbdInputCoroutine>d__66(int <>1__state)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x25DA5DC", Offset = "0x25DA5DC", VA = "0x25DA5DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x25DA5E0", Offset = "0x25DA5E0", VA = "0x25DA5E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x25DB640", Offset = "0x25DB640", VA = "0x25DB640", Slot = "8")]
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
		[Address(RVA = "0x2473254", Offset = "0x2473254", VA = "0x2473254")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x247325C", Offset = "0x247325C", VA = "0x247325C")]
		set
		{
		}
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x2473844", Offset = "0x2473844", VA = "0x2473844")]
	public static bool IsOpenedSystemKeyboard()
	{
		return default(bool);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x24738A8", Offset = "0x24738A8", VA = "0x24738A8")]
	public static bool IsCurrentInputActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x2473948", Offset = "0x2473948", VA = "0x2473948")]
	public void SetIsInputOfScreenKeyboard(MUI_ScreenKeyboard owner)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x2473950", Offset = "0x2473950", VA = "0x2473950")]
	public void SetAllowInputInScreenKeyboard()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x247395C", Offset = "0x247395C", VA = "0x247395C")]
	public void AddScreenKeyboardInput(char c)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x2473A4C", Offset = "0x2473A4C", VA = "0x2473A4C")]
	public void SetKeyboardInputActive(bool active)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x2473B98", Offset = "0x2473B98", VA = "0x2473B98")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x2473D44", Offset = "0x2473D44", VA = "0x2473D44")]
	private void Start()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x2473DE8", Offset = "0x2473DE8", VA = "0x2473DE8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x2473E10", Offset = "0x2473E10", VA = "0x2473E10")]
	private void Update()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x247405C", Offset = "0x247405C", VA = "0x247405C")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x247421C", Offset = "0x247421C", VA = "0x247421C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x2474248", Offset = "0x2474248", VA = "0x2474248")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x247424C", Offset = "0x247424C", VA = "0x247424C")]
	private void Down()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x2474254", Offset = "0x2474254", VA = "0x2474254")]
	protected MUI_Show_ScreenKeyboard GetShowKbdComponent(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x2474580", Offset = "0x2474580", VA = "0x2474580")]
	private void ControllerClick()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x2473A68", Offset = "0x2473A68", VA = "0x2473A68")]
	private void Click()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x2474588", Offset = "0x2474588", VA = "0x2474588")]
	private void DoClick(bool fromController)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x2473A70", Offset = "0x2473A70", VA = "0x2473A70")]
	protected void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x2474908", Offset = "0x2474908", VA = "0x2474908")]
	protected string GetPastedClipboardText()
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x247496C", Offset = "0x247496C", VA = "0x247496C")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x2474974", Offset = "0x2474974", VA = "0x2474974")]
	public void UpdateText()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x2473274", Offset = "0x2473274", VA = "0x2473274")]
	public void SetText(string _t, int cursorPos)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x2474D74", Offset = "0x2474D74", VA = "0x2474D74")]
	private void SetTextMesh(string txt)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x24749B8", Offset = "0x24749B8", VA = "0x24749B8")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x2474CC4", Offset = "0x2474CC4", VA = "0x2474CC4")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x2474E44", Offset = "0x2474E44", VA = "0x2474E44")]
	protected void CreateCursor()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x2474848", Offset = "0x2474848", VA = "0x2474848")]
	protected void DestroyCursor()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x24747CC", Offset = "0x24747CC", VA = "0x24747CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC394", Offset = "0x9FC394")]
	private IEnumerator ReadKbdInputCoroutine(int initCursorPos)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x2475178", Offset = "0x2475178", VA = "0x2475178")]
	protected MUI_InputText FindNextInputText()
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x24754CC", Offset = "0x24754CC", VA = "0x24754CC")]
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
		[Address(RVA = "0x246BF68", Offset = "0x246BF68", VA = "0x246BF68")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000022")]
	public static int height
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x246C098", Offset = "0x246C098", VA = "0x246C098")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x247558C", Offset = "0x247558C", VA = "0x247558C")]
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
	[Address(RVA = "0x2475598", Offset = "0x2475598", VA = "0x2475598", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x247559C", Offset = "0x247559C", VA = "0x247559C", Slot = "5")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x24755A0", Offset = "0x24755A0", VA = "0x24755A0")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x2476184", Offset = "0x2476184", VA = "0x2476184", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x2476188", Offset = "0x2476188", VA = "0x2476188")]
	public void Show(MUI_InputText _fillInput, string label, GameObject _hideScreen)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x2476338", Offset = "0x2476338", VA = "0x2476338")]
	public void CancelKeyboard()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x2476394", Offset = "0x2476394", VA = "0x2476394", Slot = "7")]
	public virtual void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x24765AC", Offset = "0x24765AC", VA = "0x24765AC", Slot = "8")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x2476658", Offset = "0x2476658", VA = "0x2476658", Slot = "9")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x2476744", Offset = "0x2476744", VA = "0x2476744", Slot = "10")]
	public virtual void OnInputEnter()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x2476790", Offset = "0x2476790", VA = "0x2476790")]
	public void OnKeyPressed(string skey)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x2476C3C", Offset = "0x2476C3C", VA = "0x2476C3C")]
	protected GameObject FindObject(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x24769F4", Offset = "0x24769F4", VA = "0x24769F4")]
	protected int FindKeyIndex(string skey)
	{
		return default(int);
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x2475698", Offset = "0x2475698", VA = "0x2475698")]
	protected void InitTextKeys()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x2476AFC", Offset = "0x2476AFC", VA = "0x2476AFC")]
	protected char GetCurrentKey(int i)
	{
		return default(char);
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x2475E38", Offset = "0x2475E38", VA = "0x2475E38")]
	protected void FillTextKeys()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x24764C0", Offset = "0x24764C0", VA = "0x24764C0")]
	protected string TrimEndLineCharacters(string text)
	{
		return null;
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x2476FA8", Offset = "0x2476FA8", VA = "0x2476FA8")]
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
	[Address(RVA = "0x2477104", Offset = "0x2477104", VA = "0x2477104")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x2477108", Offset = "0x2477108", VA = "0x2477108")]
	private void DoInit()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x2477188", Offset = "0x2477188", VA = "0x2477188")]
	private void Start()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x2477274", Offset = "0x2477274", VA = "0x2477274")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x247730C", Offset = "0x247730C", VA = "0x247730C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x247244C", Offset = "0x247244C", VA = "0x247244C")]
	public static bool IsAnyScrollActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x247744C", Offset = "0x247744C", VA = "0x247744C")]
	public static bool IsAnyScrollingInBoundary()
	{
		return default(bool);
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x24774B0", Offset = "0x24774B0", VA = "0x24774B0")]
	public void ResetOrgPos(Vector3 org)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x24774BC", Offset = "0x24774BC", VA = "0x24774BC")]
	public void SetSizeMinY(float y)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x24774C4", Offset = "0x24774C4", VA = "0x24774C4")]
	public void SetSize(Vector2 _size)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x2477510", Offset = "0x2477510", VA = "0x2477510")]
	public void SetOffset(Vector2 _offset)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x24771CC", Offset = "0x24771CC", VA = "0x24771CC")]
	public void ResetScroll()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2477654", Offset = "0x2477654", VA = "0x2477654")]
	public void AutoCalculateSize()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2477EC0", Offset = "0x2477EC0", VA = "0x2477EC0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x2477F2C", Offset = "0x2477F2C", VA = "0x2477F2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x2478438", Offset = "0x2478438", VA = "0x2478438")]
	public float GetScrollPosY()
	{
		return default(float);
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2478464", Offset = "0x2478464", VA = "0x2478464")]
	public void ScrollTo(float x, float y)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x24784DC", Offset = "0x24784DC", VA = "0x24784DC")]
	public void ScrollOffset(float x, float y)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x2478554", Offset = "0x2478554", VA = "0x2478554")]
	public void ScrollToBottom()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x24785FC", Offset = "0x24785FC", VA = "0x24785FC")]
	public bool IsScrolledToBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x247865C", Offset = "0x247865C", VA = "0x247865C")]
	public bool IsAllOnScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x2477550", Offset = "0x2477550", VA = "0x2477550")]
	public void Clamp()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x247868C", Offset = "0x247868C", VA = "0x247868C")]
	public void UpdateZoom()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2477E24", Offset = "0x2477E24", VA = "0x2477E24")]
	public static Vector2 GetFrustrumSizeAt(Camera cam)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x24786EC", Offset = "0x24786EC", VA = "0x24786EC")]
	public void EnsureVisible(Vector3 point)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x2478AF8", Offset = "0x2478AF8", VA = "0x2478AF8")]
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
	[Address(RVA = "0x2066748", Offset = "0x2066748", VA = "0x2066748")]
	public void Click()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x2066930", Offset = "0x2066930", VA = "0x2066930")]
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
	[Address(RVA = "0x2066984", Offset = "0x2066984", VA = "0x2066984")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x20669AC", Offset = "0x20669AC", VA = "0x20669AC")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x2066A3C", Offset = "0x2066A3C", VA = "0x2066A3C")]
	public void SetValChangedCallback(Action<MUI_Slider, float> callback)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x2066A44", Offset = "0x2066A44", VA = "0x2066A44")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x2066A4C", Offset = "0x2066A4C", VA = "0x2066A4C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x2066A90", Offset = "0x2066A90", VA = "0x2066A90")]
	public float GetVal()
	{
		return default(float);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x2066C18", Offset = "0x2066C18", VA = "0x2066C18")]
	public void SetVal(float v)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x2066D78", Offset = "0x2066D78", VA = "0x2066D78")]
	public void SetGraphVal(float v)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x20669BC", Offset = "0x20669BC", VA = "0x20669BC")]
	private void UpdateSquarePos()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x2066DCC", Offset = "0x2066DCC", VA = "0x2066DCC")]
	private void UpdateSquarePos(float v)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x2066E38", Offset = "0x2066E38", VA = "0x2066E38")]
	private void Down()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2066FC4", Offset = "0x2066FC4", VA = "0x2066FC4")]
	private void Click()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2066FC8", Offset = "0x2066FC8", VA = "0x2066FC8")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x2066E3C", Offset = "0x2066E3C", VA = "0x2066E3C")]
	private void Process()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2066FCC", Offset = "0x2066FCC", VA = "0x2066FCC")]
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
	[Address(RVA = "0x2066FE0", Offset = "0x2066FE0", VA = "0x2066FE0")]
	public void SetCustomVal(float v)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x20670D8", Offset = "0x20670D8", VA = "0x20670D8")]
	public void SetValChangedCallback(Action<MUI_SliderVertical, float, float> callback)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x20670E0", Offset = "0x20670E0", VA = "0x20670E0")]
	public float GetCustomVal()
	{
		return default(float);
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x20670E8", Offset = "0x20670E8", VA = "0x20670E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x206712C", Offset = "0x206712C", VA = "0x206712C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x2066FF0", Offset = "0x2066FF0", VA = "0x2066FF0")]
	public void UpdateSquarePos()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x2067418", Offset = "0x2067418", VA = "0x2067418")]
	private void Down()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x206741C", Offset = "0x206741C", VA = "0x206741C")]
	private void Click()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2067420", Offset = "0x2067420", VA = "0x2067420")]
	private void MoveSlider()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x20671BC", Offset = "0x20671BC", VA = "0x20671BC")]
	private void Process()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x2067424", Offset = "0x2067424", VA = "0x2067424")]
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
		[Address(RVA = "0x25DB688", Offset = "0x25DB688", VA = "0x25DB688")]
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
	[Address(RVA = "0x2067438", Offset = "0x2067438", VA = "0x2067438")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x2067818", Offset = "0x2067818", VA = "0x2067818")]
	private static void FindInstance()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x2067910", Offset = "0x2067910", VA = "0x2067910")]
	public static void Play(UISfx sfx, [Optional] GameObject at)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x2067C94", Offset = "0x2067C94", VA = "0x2067C94")]
	public AudioSource FindFreeSource()
	{
		return null;
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x2067A08", Offset = "0x2067A08", VA = "0x2067A08")]
	private void PlayClip(UISfx sfx, GameObject at)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x2067E40", Offset = "0x2067E40", VA = "0x2067E40")]
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
	[Address(RVA = "0x2067E4C", Offset = "0x2067E4C", VA = "0x2067E4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x2068038", Offset = "0x2068038", VA = "0x2068038")]
	private void Down()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x20682D4", Offset = "0x20682D4", VA = "0x20682D4")]
	private void Up()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x206849C", Offset = "0x206849C", VA = "0x206849C")]
	private void Click()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x2068518", Offset = "0x2068518", VA = "0x2068518")]
	private void IsDown(BoolRef isDown)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x2068534", Offset = "0x2068534", VA = "0x2068534")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x2068544", Offset = "0x2068544", VA = "0x2068544")]
	public bool IsDisabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x206854C", Offset = "0x206854C", VA = "0x206854C")]
	public void Disable()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x2068778", Offset = "0x2068778", VA = "0x2068778")]
	public void Enable()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x2068978", Offset = "0x2068978", VA = "0x2068978")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x2068984", Offset = "0x2068984", VA = "0x2068984")]
	public void SetDisabled(bool disabled)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x2068990", Offset = "0x2068990", VA = "0x2068990")]
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
	[Address(RVA = "0x20689C8", Offset = "0x20689C8", VA = "0x20689C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x2068A40", Offset = "0x2068A40", VA = "0x2068A40")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x2068D78", Offset = "0x2068D78", VA = "0x2068D78")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x2068D7C", Offset = "0x2068D7C", VA = "0x2068D7C")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x2068A44", Offset = "0x2068A44", VA = "0x2068A44")]
	public void Calculate()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x20691D0", Offset = "0x20691D0", VA = "0x20691D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x2068EA4", Offset = "0x2068EA4", VA = "0x2068EA4")]
	protected float GetCharWidth(char c, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x2068D80", Offset = "0x2068D80", VA = "0x2068D80")]
	protected float GetTextWidth(string txt, bool restoreOldText)
	{
		return default(float);
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x20694D0", Offset = "0x20694D0", VA = "0x20694D0")]
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
	[Address(RVA = "0x206955C", Offset = "0x206955C", VA = "0x206955C")]
	public static void Init()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x20695C8", Offset = "0x20695C8", VA = "0x20695C8")]
	public static void InitDefaults()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x2069DC4", Offset = "0x2069DC4", VA = "0x2069DC4")]
	public static bool HadSet(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x2069E94", Offset = "0x2069E94", VA = "0x2069E94")]
	public static bool Get(eCheck i)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x2069F64", Offset = "0x2069F64", VA = "0x2069F64")]
	public static void Set(eCheck e, bool v)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x2069FD4", Offset = "0x2069FD4", VA = "0x2069FD4")]
	public static void Set(int i, bool v)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x206A0EC", Offset = "0x206A0EC", VA = "0x206A0EC")]
	public static void Switch(eCheck i)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x2066B10", Offset = "0x2066B10", VA = "0x2066B10")]
	public static float GetFloat(eSlider i, bool forSettings = false)
	{
		return default(float);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x2066CC4", Offset = "0x2066CC4", VA = "0x2066CC4")]
	public static void SetFloat(eSlider i, float v)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x206A234", Offset = "0x206A234", VA = "0x206A234")]
	public static bool GetNS(eCheckNotSaved i)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x206A2C4", Offset = "0x206A2C4", VA = "0x206A2C4")]
	public static void SetNS(int i, bool v)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x206A36C", Offset = "0x206A36C", VA = "0x206A36C")]
	public static void SwitchNS(eCheckNotSaved i)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x206A404", Offset = "0x206A404", VA = "0x206A404")]
	public static void Save()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x206A620", Offset = "0x206A620", VA = "0x206A620")]
	public static bool CanLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x20699B4", Offset = "0x20699B4", VA = "0x20699B4")]
	public static void Load()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x206A6B4", Offset = "0x206A6B4", VA = "0x206A6B4")]
	private void Click()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x206A70C", Offset = "0x206A70C", VA = "0x206A70C")]
	public MUI_data()
	{
	}
}
[Token(Token = "0x200005A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9F9DE8", Offset = "0x9F9DE8")]
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
	[Address(RVA = "0x206A800", Offset = "0x206A800", VA = "0x206A800")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x206A908", Offset = "0x206A908", VA = "0x206A908")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x206AC0C", Offset = "0x206AC0C", VA = "0x206AC0C")]
	private void SetWidth(float w)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x206AC14", Offset = "0x206AC14", VA = "0x206AC14")]
	public void SetCutOffLongLines()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x206AC20", Offset = "0x206AC20", VA = "0x206AC20")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x206AE78", Offset = "0x206AE78", VA = "0x206AE78")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x206AC30", Offset = "0x206AC30", VA = "0x206AC30")]
	private void BreakNow()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x206AE7C", Offset = "0x206AE7C", VA = "0x206AE7C")]
	public static int IndexOfNth(string str, char c, int nth, int startPosition = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x206AF34", Offset = "0x206AF34", VA = "0x206AF34")]
	public void BreakLinesFromLine(int line, float width)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x206B134", Offset = "0x206B134", VA = "0x206B134")]
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
	[Address(RVA = "0x1F052CC", Offset = "0x1F052CC", VA = "0x1F052CC")]
	public StringBufferWrapper(int capacity)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1F05380", Offset = "0x1F05380", VA = "0x1F05380")]
	public StringBufferWrapper()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x1F053E8", Offset = "0x1F053E8", VA = "0x1F053E8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x1F05424", Offset = "0x1F05424", VA = "0x1F05424")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1F0545C", Offset = "0x1F0545C", VA = "0x1F0545C")]
	public unsafe void Append(char* str, int startIdx, int count)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x1F054A4", Offset = "0x1F054A4", VA = "0x1F054A4")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x1F05508", Offset = "0x1F05508", VA = "0x1F05508")]
	public void Append(StringBufferWrapper sb)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1F05550", Offset = "0x1F05550", VA = "0x1F05550")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1F055B8", Offset = "0x1F055B8", VA = "0x1F055B8")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x1F05624", Offset = "0x1F05624", VA = "0x1F05624")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x1F056B0", Offset = "0x1F056B0", VA = "0x1F056B0", Slot = "3")]
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
		[Address(RVA = "0x1F056E4", Offset = "0x1F056E4", VA = "0x1F056E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000024")]
	public float height
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1F058CC", Offset = "0x1F058CC", VA = "0x1F058CC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x1F05924", Offset = "0x1F05924", VA = "0x1F05924")]
	public TextSize(TextMesh tm, int textCapacity = -1, int wordCapacity = -1)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x1F05A30", Offset = "0x1F05A30", VA = "0x1F05A30")]
	private void getSpace()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x1F0571C", Offset = "0x1F0571C", VA = "0x1F0571C")]
	private float GetTextWidth(string s)
	{
		return default(float);
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x1F05BD8", Offset = "0x1F05BD8", VA = "0x1F05BD8")]
	private string RemoveLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x1F05CFC", Offset = "0x1F05CFC", VA = "0x1F05CFC")]
	private string RemoveSingleLineBreaks(string a, int leaveFirstNbreaks)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x1F05E98", Offset = "0x1F05E98", VA = "0x1F05E98")]
	public void FitToWidth(float wantedWidth, bool removeLineBreaks, bool removeSingleLineBreaks, int leaveFirstNbreaks, bool justifyLines, bool resetDictionary, int maxLines, bool cutOffLongLines)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x1F06690", Offset = "0x1F06690", VA = "0x1F06690")]
	private bool IsCHchar(char c)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x1F06190", Offset = "0x1F06190", VA = "0x1F06190")]
	private unsafe bool WrapLine(char* s, int startIdx, int endIdx, float w, bool justifyLine, bool cutOffLongLines)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x1F066A0", Offset = "0x1F066A0", VA = "0x1F066A0")]
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
	[Address(RVA = "0x206B160", Offset = "0x206B160", VA = "0x206B160")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x206B1D8", Offset = "0x206B1D8", VA = "0x206B1D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x206B1E4", Offset = "0x206B1E4", VA = "0x206B1E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x206B478", Offset = "0x206B478", VA = "0x206B478")]
	public void TextChanged()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x206B21C", Offset = "0x206B21C", VA = "0x206B21C")]
	public void Calculate()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x206B484", Offset = "0x206B484", VA = "0x206B484")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x206B788", Offset = "0x206B788", VA = "0x206B788")]
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
	[Address(RVA = "0x1F04F34", Offset = "0x1F04F34", VA = "0x1F04F34")]
	public StringBuffer(int capacity)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x1F04FA8", Offset = "0x1F04FA8", VA = "0x1F04FA8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x1F04FB0", Offset = "0x1F04FB0", VA = "0x1F04FB0")]
	public void Append(string str)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x1F0503C", Offset = "0x1F0503C", VA = "0x1F0503C")]
	public unsafe void Append(char* str, int count)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x1F050AC", Offset = "0x1F050AC", VA = "0x1F050AC")]
	public void Append(char c)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x1F050DC", Offset = "0x1F050DC", VA = "0x1F050DC")]
	public void Append(StringBuffer sb)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x1F0516C", Offset = "0x1F0516C", VA = "0x1F0516C")]
	public void AppendLine()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x1F051A0", Offset = "0x1F051A0", VA = "0x1F051A0")]
	public void Replace(char from, char to)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x1F051F8", Offset = "0x1F051F8", VA = "0x1F051F8")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x1F0520C", Offset = "0x1F0520C", VA = "0x1F0520C", Slot = "3")]
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
		[Address(RVA = "0x25DBC2C", Offset = "0x25DBC2C", VA = "0x25DBC2C")]
		public ColorInterpolator(Color clr)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x25DBC38", Offset = "0x25DBC38", VA = "0x25DBC38", Slot = "4")]
		public ColorInterpolator Add(ColorInterpolator y)
		{
			return default(ColorInterpolator);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x25DBC88", Offset = "0x25DBC88", VA = "0x25DBC88", Slot = "5")]
		public ColorInterpolator Multiply(float y)
		{
			return default(ColorInterpolator);
		}
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x206B814", Offset = "0x206B814", VA = "0x206B814")]
	public static Quaternion ShortestRotation(Quaternion a, Quaternion b)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x206B914", Offset = "0x206B914", VA = "0x206B914")]
	public static Quaternion Multiply(this Quaternion input, float scalar)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x206B8D4", Offset = "0x206B8D4", VA = "0x206B8D4")]
	public static Quaternion Negate(this Quaternion input)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000314")]
	public static void Shuffle<T>(T[] array, int startIndex = 0, int endIndex = -1)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x206B954", Offset = "0x206B954", VA = "0x206B954")]
	private static int LevenshteinDistance(string source, string target)
	{
		return default(int);
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x206BBD4", Offset = "0x206BBD4", VA = "0x206BBD4")]
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
	[Address(RVA = "0x206BC5C", Offset = "0x206BC5C", VA = "0x206BC5C")]
	private void Start()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x206BC6C", Offset = "0x206BC6C", VA = "0x206BC6C")]
	public void MergeMeshNow()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x206C374", Offset = "0x206C374", VA = "0x206C374")]
	public void AddTR(Transform t0)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x206C994", Offset = "0x206C994", VA = "0x206C994")]
	public void CountData(Mesh m, Vector3[] mvertices, Renderer r)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x206D62C", Offset = "0x206D62C", VA = "0x206D62C")]
	public void AddMaterial(Material m)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x206D7A8", Offset = "0x206D7A8", VA = "0x206D7A8")]
	public int GetMaterialIndex(Material m)
	{
		return default(int);
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x206CA90", Offset = "0x206CA90", VA = "0x206CA90")]
	private void BuildMesh(Transform t, Mesh m, Vector3[] mvertices)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x206D230", Offset = "0x206D230", VA = "0x206D230")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x206D924", Offset = "0x206D924", VA = "0x206D924")]
	public MergeMesh()
	{
	}
}
[Token(Token = "0x2000063")]
public class OpenUrl
{
	[Token(Token = "0x6000326")]
	[Address(RVA = "0x1EFF0C0", Offset = "0x1EFF0C0", VA = "0x1EFF0C0")]
	public static void Open(string url)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x1EFF100", Offset = "0x1EFF100", VA = "0x1EFF100")]
	public static void Open(string url, string steamBundleID)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x1EFF16C", Offset = "0x1EFF16C", VA = "0x1EFF16C")]
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
		[Address(RVA = "0x1EFF174", Offset = "0x1EFF174", VA = "0x1EFF174")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000026")]
	public static bool sidequestStore
	{
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1EFF17C", Offset = "0x1EFF17C", VA = "0x1EFF17C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000027")]
	public static bool oculusStore
	{
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1EFF1E8", Offset = "0x1EFF1E8", VA = "0x1EFF1E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000028")]
	public static bool steamStore
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1EFF254", Offset = "0x1EFF254", VA = "0x1EFF254")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000029")]
	public static bool viveStore
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1EFF2C0", Offset = "0x1EFF2C0", VA = "0x1EFF2C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002A")]
	public static bool microsoftStore
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1EFF32C", Offset = "0x1EFF32C", VA = "0x1EFF32C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002B")]
	public static bool noloStore
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1EFF398", Offset = "0x1EFF398", VA = "0x1EFF398")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002C")]
	public static bool picoStore
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1EFF404", Offset = "0x1EFF404", VA = "0x1EFF404")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002D")]
	public static bool standaloneOVRStore
	{
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1EFF470", Offset = "0x1EFF470", VA = "0x1EFF470")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002E")]
	public static bool oculusVR
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1EFF4DC", Offset = "0x1EFF4DC", VA = "0x1EFF4DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002F")]
	public static bool steamVR
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1EFF548", Offset = "0x1EFF548", VA = "0x1EFF548")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000030")]
	public static bool noloVR
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1EFF5B4", Offset = "0x1EFF5B4", VA = "0x1EFF5B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000031")]
	public static bool waveVR
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1EFF620", Offset = "0x1EFF620", VA = "0x1EFF620")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000032")]
	public static bool picoVR
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1EFF68C", Offset = "0x1EFF68C", VA = "0x1EFF68C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000033")]
	public static bool android
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1EFF6F8", Offset = "0x1EFF6F8", VA = "0x1EFF6F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000034")]
	public static bool winStore
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1EFF700", Offset = "0x1EFF700", VA = "0x1EFF700")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000035")]
	public static bool winStandalone
	{
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1EFF708", Offset = "0x1EFF708", VA = "0x1EFF708")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000036")]
	public static bool iOS
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1EFF710", Offset = "0x1EFF710", VA = "0x1EFF710")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000037")]
	public static bool macOsStandalone
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1EFF718", Offset = "0x1EFF718", VA = "0x1EFF718")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000038")]
	public static bool standalone
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1EFF720", Offset = "0x1EFF720", VA = "0x1EFF720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000039")]
	public static bool linuxStandalone
	{
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1EFF728", Offset = "0x1EFF728", VA = "0x1EFF728")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003A")]
	public static bool onlySoftwareKeyboard
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1EFF730", Offset = "0x1EFF730", VA = "0x1EFF730")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003B")]
	public static bool mobile
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1EFF738", Offset = "0x1EFF738", VA = "0x1EFF738")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public static bool PC
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1EFF794", Offset = "0x1EFF794", VA = "0x1EFF794")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	public static string str0xA0
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1EFF808", Offset = "0x1EFF808", VA = "0x1EFF808")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x1EFF84C", Offset = "0x1EFF84C", VA = "0x1EFF84C")]
	public static void CheckDevMode()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x1EFFAB0", Offset = "0x1EFFAB0", VA = "0x1EFFAB0")]
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
	[Address(RVA = "0x1B15C58", Offset = "0x1B15C58", VA = "0x1B15C58")]
	public void ComputeConvolution(Cubemap originalCubeMap)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x1B1627C", Offset = "0x1B1627C", VA = "0x1B1627C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1B15ED4", Offset = "0x1B15ED4", VA = "0x1B15ED4")]
	private Cubemap computeFilteredCubeMap(Cubemap originalCubeMap)
	{
		return null;
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x1B164A0", Offset = "0x1B164A0", VA = "0x1B164A0")]
	private void setFaceAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x1B165D0", Offset = "0x1B165D0", VA = "0x1B165D0")]
	private void setCornerAverage(ref Cubemap filteredCubeMap, int a, int b, int c, int d, int e, int f, int g, int h, int i)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x1B1632C", Offset = "0x1B1632C", VA = "0x1B1632C")]
	private Vector3 getDirection(int face, int i, int j, int size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x1B16794", Offset = "0x1B16794", VA = "0x1B16794")]
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
	[Address(RVA = "0x1B1EBF8", Offset = "0x1B1EBF8", VA = "0x1B1EBF8")]
	public static implicit operator EncodedInt(int value)
	{
		return default(EncodedInt);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1B1EC14", Offset = "0x1B1EC14", VA = "0x1B1EC14")]
	public static bool operator ==(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x1B1ECA8", Offset = "0x1B1ECA8", VA = "0x1B1ECA8")]
	public static bool operator !=(EncodedInt v1, int v2)
	{
		return default(bool);
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x1B1ECD0", Offset = "0x1B1ECD0", VA = "0x1B1ECD0")]
	public static bool operator ==(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x1B1ECFC", Offset = "0x1B1ECFC", VA = "0x1B1ECFC")]
	public static bool operator !=(int v1, EncodedInt v2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1B1ED28", Offset = "0x1B1ED28", VA = "0x1B1ED28")]
	public void setValue(int val)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x1B1EC3C", Offset = "0x1B1EC3C", VA = "0x1B1EC3C")]
	public int getValue()
	{
		return default(int);
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1B1EC04", Offset = "0x1B1EC04", VA = "0x1B1EC04")]
	private EncodedInt(int val)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1B1EDCC", Offset = "0x1B1EDCC", VA = "0x1B1EDCC")]
	private void Init(int val)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x1B1EE24", Offset = "0x1B1EE24", VA = "0x1B1EE24", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1B1EE50", Offset = "0x1B1EE50", VA = "0x1B1EE50")]
	public string ToString(string format)
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1B1EE84", Offset = "0x1B1EE84", VA = "0x1B1EE84", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x1B1EF44", Offset = "0x1B1EF44", VA = "0x1B1EF44")]
	public bool Equals(EncodedInt p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x1B1EF78", Offset = "0x1B1EF78", VA = "0x1B1EF78", Slot = "2")]
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
	[Address(RVA = "0x1F07CF8", Offset = "0x1F07CF8", VA = "0x1F07CF8")]
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
	[Address(RVA = "0x1F01E14", Offset = "0x1F01E14", VA = "0x1F01E14")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x1F02418", Offset = "0x1F02418", VA = "0x1F02418")]
	public static float GetFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x1F02480", Offset = "0x1F02480", VA = "0x1F02480")]
	public static float GetFloat(string key, float defval)
	{
		return default(float);
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x1F02588", Offset = "0x1F02588", VA = "0x1F02588")]
	public static int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x1F025F0", Offset = "0x1F025F0", VA = "0x1F025F0")]
	public static int GetInt(string key, int defval)
	{
		return default(int);
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x1F026F8", Offset = "0x1F026F8", VA = "0x1F026F8")]
	public static string GetString(string key)
	{
		return null;
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x1F02774", Offset = "0x1F02774", VA = "0x1F02774")]
	public static string GetString(string key, string defval)
	{
		return null;
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x1F02890", Offset = "0x1F02890", VA = "0x1F02890")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x1F02970", Offset = "0x1F02970", VA = "0x1F02970")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x1F02D44", Offset = "0x1F02D44", VA = "0x1F02D44")]
	public static void SetFloat(string key, float val)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x1F02EDC", Offset = "0x1F02EDC", VA = "0x1F02EDC")]
	public static void SetInt(string key, int val)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x1F03074", Offset = "0x1F03074", VA = "0x1F03074")]
	public static void SetString(string key, string val)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x1F01F58", Offset = "0x1F01F58", VA = "0x1F01F58")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x1F03220", Offset = "0x1F03220", VA = "0x1F03220")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x1F034B8", Offset = "0x1F034B8", VA = "0x1F034B8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x1F03574", Offset = "0x1F03574", VA = "0x1F03574")]
	public static bool IsInitializing()
	{
		return default(bool);
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x1F03684", Offset = "0x1F03684", VA = "0x1F03684")]
	private void Update()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x1F03848", Offset = "0x1F03848", VA = "0x1F03848")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x1F038F0", Offset = "0x1F038F0", VA = "0x1F038F0")]
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x1F020CC", Offset = "0x1F020CC", VA = "0x1F020CC")]
	public static bool IsUseWrapper()
	{
		return default(bool);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x1F021BC", Offset = "0x1F021BC", VA = "0x1F021BC")]
	protected static void LoadWrapper()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x1F02A64", Offset = "0x1F02A64", VA = "0x1F02A64")]
	protected static void StoreWrapper()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x1F03998", Offset = "0x1F03998", VA = "0x1F03998")]
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
		[Address(RVA = "0x25DC518", Offset = "0x25DC518", VA = "0x25DC518")]
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
	[Address(RVA = "0x1F06994", Offset = "0x1F06994", VA = "0x1F06994")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x1F06998", Offset = "0x1F06998", VA = "0x1F06998")]
	public static void LogError(string text)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x1F06A28", Offset = "0x1F06A28", VA = "0x1F06A28")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x1F06B30", Offset = "0x1F06B30", VA = "0x1F06B30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x1F06BD4", Offset = "0x1F06BD4", VA = "0x1F06BD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x1F074F4", Offset = "0x1F074F4", VA = "0x1F074F4")]
	public static DownloadedTexture GetTexture(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x1F07540", Offset = "0x1F07540", VA = "0x1F07540")]
	public static DownloadedTexture GetTexture(string filePath, string resourcesFolder)
	{
		return null;
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x1F07C30", Offset = "0x1F07C30", VA = "0x1F07C30")]
	protected static string GetFileName(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x1F06BD8", Offset = "0x1F06BD8", VA = "0x1F06BD8")]
	private void StepDownloadingTextures()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x1F07C80", Offset = "0x1F07C80", VA = "0x1F07C80")]
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
		[Address(RVA = "0x1F07E1C", Offset = "0x1F07E1C", VA = "0x1F07E1C", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003F")]
	public string error
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1F07E48", Offset = "0x1F07E48", VA = "0x1F07E48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000040")]
	public string text
	{
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1F07EF0", Offset = "0x1F07EF0", VA = "0x1F07EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public byte[] data
	{
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1F07F1C", Offset = "0x1F07F1C", VA = "0x1F07F1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	public string data2string
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1F07F48", Offset = "0x1F07F48", VA = "0x1F07F48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000043")]
	public bool isDone
	{
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1F0805C", Offset = "0x1F0805C", VA = "0x1F0805C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x1F08078", Offset = "0x1F08078", VA = "0x1F08078")]
	public WWWwrapper(string url, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x1F081F0", Offset = "0x1F081F0", VA = "0x1F081F0")]
	public WWWwrapper(string url, WWWForm form, [Optional] Dictionary<string, string> headers)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x1F08388", Offset = "0x1F08388", VA = "0x1F08388")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x1F083A4", Offset = "0x1F083A4", VA = "0x1F083A4")]
	public static string EscapeURL(string url)
	{
		return null;
	}
}
[Token(Token = "0x200006E")]
public static class Bezier
{
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x1D3D1D4", Offset = "0x1D3D1D4", VA = "0x1D3D1D4")]
	public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1D3D294", Offset = "0x1D3D294", VA = "0x1D3D294")]
	public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x1D3D2F0", Offset = "0x1D3D2F0", VA = "0x1D3D2F0")]
	public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x1D3D3F0", Offset = "0x1D3D3F0", VA = "0x1D3D3F0")]
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
	[Address(RVA = "0x1D3D8A4", Offset = "0x1D3D8A4", VA = "0x1D3D8A4")]
	public void Reset()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x1D3D974", Offset = "0x1D3D974", VA = "0x1D3D974")]
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
	[Address(RVA = "0x1D3D500", Offset = "0x1D3D500", VA = "0x1D3D500")]
	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x1D3D5A0", Offset = "0x1D3D5A0", VA = "0x1D3D5A0")]
	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x1D3D680", Offset = "0x1D3D680", VA = "0x1D3D680")]
	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1D3D6B0", Offset = "0x1D3D6B0", VA = "0x1D3D6B0")]
	public void CalculateArcLength()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1D3D7D4", Offset = "0x1D3D7D4", VA = "0x1D3D7D4")]
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
		[Address(RVA = "0x1D3D97C", Offset = "0x1D3D97C", VA = "0x1D3D97C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1D3D984", Offset = "0x1D3D984", VA = "0x1D3D984")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public float MaximumVelocity
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1D3DC40", Offset = "0x1D3DC40", VA = "0x1D3DC40")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000046")]
	public float ArcLength
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1D3DC48", Offset = "0x1D3DC48", VA = "0x1D3DC48")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000047")]
	public int ControlPointCount
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1D3DC50", Offset = "0x1D3DC50", VA = "0x1D3DC50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000048")]
	public int CurveCount
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1D3DFC0", Offset = "0x1D3DFC0", VA = "0x1D3DFC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x1D3DC6C", Offset = "0x1D3DC6C", VA = "0x1D3DC6C")]
	public Vector3 GetControlPoint(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x1D3D9F8", Offset = "0x1D3D9F8", VA = "0x1D3D9F8")]
	public void SetControlPoint(int index, Vector3 point)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x1D3DEC0", Offset = "0x1D3DEC0", VA = "0x1D3DEC0")]
	public BezierControlPointMode GetControlPointMode(int index)
	{
		return default(BezierControlPointMode);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x1D3DF18", Offset = "0x1D3DF18", VA = "0x1D3DF18")]
	public void SetControlPointMode(int index, BezierControlPointMode mode)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x1D3DCB4", Offset = "0x1D3DCB4", VA = "0x1D3DCB4")]
	private void EnforceMode(int index)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x1D3DFF8", Offset = "0x1D3DFF8", VA = "0x1D3DFF8")]
	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x1D3E220", Offset = "0x1D3E220", VA = "0x1D3E220")]
	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x1D3E47C", Offset = "0x1D3E47C", VA = "0x1D3E47C")]
	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x1D3E4AC", Offset = "0x1D3E4AC", VA = "0x1D3E4AC")]
	public void AddCurve()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x1D3E6F0", Offset = "0x1D3E6F0", VA = "0x1D3E6F0")]
	public void Reset()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x1D3E7DC", Offset = "0x1D3E7DC", VA = "0x1D3E7DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x1D3E904", Offset = "0x1D3E904", VA = "0x1D3E904")]
	public void SetPoints(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1D3E7E0", Offset = "0x1D3E7E0", VA = "0x1D3E7E0")]
	private void CalculateArcLength()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x1D3E9A0", Offset = "0x1D3E9A0", VA = "0x1D3E9A0")]
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
		[Address(RVA = "0x1D3E9A8", Offset = "0x1D3E9A8", VA = "0x1D3E9A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004A")]
	private int CurveCount
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1D3E9C4", Offset = "0x1D3E9C4", VA = "0x1D3E9C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004B")]
	public float TotalLength
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1D3EA08", Offset = "0x1D3EA08", VA = "0x1D3EA08")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x1D3EA10", Offset = "0x1D3EA10", VA = "0x1D3EA10")]
	public BezierSplineLinear(BezierSpline spline)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x1D3EA40", Offset = "0x1D3EA40", VA = "0x1D3EA40")]
	private void Calculate()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x1D3EDE0", Offset = "0x1D3EDE0", VA = "0x1D3EDE0")]
	private float map(int c, float u)
	{
		return default(float);
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x1D3EEF4", Offset = "0x1D3EEF4", VA = "0x1D3EEF4")]
	private void LinearT(ref float t, out int p)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x1D3EFD8", Offset = "0x1D3EFD8", VA = "0x1D3EFD8")]
	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x1D3F1A0", Offset = "0x1D3F1A0", VA = "0x1D3F1A0")]
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
	[Address(RVA = "0x1F04BE8", Offset = "0x1F04BE8", VA = "0x1F04BE8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x1F04C64", Offset = "0x1F04C64", VA = "0x1F04C64")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x1F04DE0", Offset = "0x1F04DE0", VA = "0x1F04DE0")]
	private PathData GetNodeData(float t)
	{
		return default(PathData);
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x1F04C3C", Offset = "0x1F04C3C", VA = "0x1F04C3C")]
	private float InitializeSpeed(float speed)
	{
		return default(float);
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x1F04ED0", Offset = "0x1F04ED0", VA = "0x1F04ED0")]
	public void Finish()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1F04F14", Offset = "0x1F04F14", VA = "0x1F04F14")]
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
		[Address(RVA = "0x1F04F24", Offset = "0x1F04F24", VA = "0x1F04F24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x1F04F2C", Offset = "0x1F04F2C", VA = "0x1F04F2C")]
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
		[Address(RVA = "0x1D2F6A8", Offset = "0x1D2F6A8", VA = "0x1D2F6A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC464", Offset = "0x9FC464")]
		add
		{
		}
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1D2F748", Offset = "0x1D2F748", VA = "0x1D2F748")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC474", Offset = "0x9FC474")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	private event Action<string> OnPermissionDeniedAction
	{
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1D2F7E8", Offset = "0x1D2F7E8", VA = "0x1D2F7E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC484", Offset = "0x9FC484")]
		add
		{
		}
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1D2F888", Offset = "0x1D2F888", VA = "0x1D2F888")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC494", Offset = "0x9FC494")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	private event Action<string> OnPermissionDeniedAndDontAskAgainAction
	{
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1D2F928", Offset = "0x1D2F928", VA = "0x1D2F928")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC4A4", Offset = "0x9FC4A4")]
		add
		{
		}
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1D2F9C8", Offset = "0x1D2F9C8", VA = "0x1D2F9C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC4B4", Offset = "0x9FC4B4")]
		remove
		{
		}
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x1D2FA68", Offset = "0x1D2FA68", VA = "0x1D2FA68")]
	public AndroidPermissionCallback(Action<string> onGrantedCallback, Action<string> onDeniedCallback, Action<string> onDeniedAndDontAskAgainCallback)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x1D2FB44", Offset = "0x1D2FB44", VA = "0x1D2FB44", Slot = "9")]
	public virtual void OnPermissionGranted(string permissionName)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1D2FBB4", Offset = "0x1D2FBB4", VA = "0x1D2FBB4", Slot = "10")]
	public virtual void OnPermissionDenied(string permissionName)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x1D2FC24", Offset = "0x1D2FC24", VA = "0x1D2FC24", Slot = "11")]
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
	[Address(RVA = "0x1D2FC9C", Offset = "0x1D2FC9C", VA = "0x1D2FC9C")]
	private static AndroidJavaObject GetActivity()
	{
		return null;
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x1D2FD84", Offset = "0x1D2FD84", VA = "0x1D2FD84")]
	private static AndroidJavaObject GetPermissionsService()
	{
		return null;
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x1D2FEC8", Offset = "0x1D2FEC8", VA = "0x1D2FEC8")]
	public static bool IsPermissionGranted(string permissionName)
	{
		return default(bool);
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x1D2FFE0", Offset = "0x1D2FFE0", VA = "0x1D2FFE0")]
	public static void RequestPermission(string permissionName, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1D3008C", Offset = "0x1D3008C", VA = "0x1D3008C")]
	public static void RequestPermission(string[] permissionNames, AndroidPermissionCallback callback)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1D301C4", Offset = "0x1D301C4", VA = "0x1D301C4")]
	public AndroidPermissionsManager()
	{
	}
}
namespace JSONplugin
{
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9F9E68", Offset = "0x9F9E68")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9EA0", Offset = "0x9F9EA0")]
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
				[Address(RVA = "0x25D80D8", Offset = "0x25D80D8", VA = "0x25D80D8", Slot = "6")]
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
				[Address(RVA = "0x25D8120", Offset = "0x25D8120", VA = "0x25D8120", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x25D7CEC", Offset = "0x25D7CEC", VA = "0x25D7CEC")]
			[DebuggerHidden]
			public <BakeAsync>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x25D7D24", Offset = "0x25D7D24", VA = "0x25D7D24", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x25D7DFC", Offset = "0x25D7DFC", VA = "0x25D7DFC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x25D7D40", Offset = "0x25D7D40", VA = "0x25D7D40")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x25D80E0", Offset = "0x25D80E0", VA = "0x25D80E0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x25D8128", Offset = "0x25D8128", VA = "0x25D8128", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x25D81D0", Offset = "0x25D81D0", VA = "0x25D81D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9EB0", Offset = "0x9F9EB0")]
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
				[Address(RVA = "0x25D865C", Offset = "0x25D865C", VA = "0x25D865C", Slot = "6")]
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
				[Address(RVA = "0x25D86A4", Offset = "0x25D86A4", VA = "0x25D86A4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x25D81D4", Offset = "0x25D81D4", VA = "0x25D81D4")]
			[DebuggerHidden]
			public <PrintAsync>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x25D820C", Offset = "0x25D820C", VA = "0x25D820C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x25D82F0", Offset = "0x25D82F0", VA = "0x25D82F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x25D8228", Offset = "0x25D8228", VA = "0x25D8228")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x25D8664", Offset = "0x25D8664", VA = "0x25D8664", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x25D86AC", Offset = "0x25D86AC", VA = "0x25D86AC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x25D875C", Offset = "0x25D875C", VA = "0x25D875C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000082")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9EC0", Offset = "0x9F9EC0")]
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
				[Address(RVA = "0x25D9978", Offset = "0x25D9978", VA = "0x25D9978", Slot = "6")]
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
				[Address(RVA = "0x25D99C0", Offset = "0x25D99C0", VA = "0x25D99C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x25D8760", Offset = "0x25D8760", VA = "0x25D8760")]
			[DebuggerHidden]
			public <StringifyAsync>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x25D8798", Offset = "0x25D8798", VA = "0x25D8798", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x25D89C4", Offset = "0x25D89C4", VA = "0x25D89C4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x25D8834", Offset = "0x25D8834", VA = "0x25D8834")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x25D88FC", Offset = "0x25D88FC", VA = "0x25D88FC")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x25D9980", Offset = "0x25D9980", VA = "0x25D9980", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x25D99C8", Offset = "0x25D99C8", VA = "0x25D99C8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x25D9A88", Offset = "0x25D9A88", VA = "0x25D9A88", Slot = "5")]
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
			[Address(RVA = "0x1B212AC", Offset = "0x1B212AC", VA = "0x1B212AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public int Count
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1B212C0", Offset = "0x1B212C0", VA = "0x1B212C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004F")]
		public float f
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1B21310", Offset = "0x1B21310", VA = "0x1B21310")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000050")]
		public static JSONObject nullJO
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1B21318", Offset = "0x1B21318", VA = "0x1B21318")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public static JSONObject obj
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1B214A4", Offset = "0x1B214A4", VA = "0x1B214A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public static JSONObject arr
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1B21500", Offset = "0x1B21500", VA = "0x1B21500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public bool IsNumber
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1B22FFC", Offset = "0x1B22FFC", VA = "0x1B22FFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public bool IsNull
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1B2300C", Offset = "0x1B2300C", VA = "0x1B2300C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsString
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1B2301C", Offset = "0x1B2301C", VA = "0x1B2301C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public bool IsBool
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1B2302C", Offset = "0x1B2302C", VA = "0x1B2302C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		public bool IsArray
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1B2303C", Offset = "0x1B2303C", VA = "0x1B2303C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public bool IsObject
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1B2304C", Offset = "0x1B2304C", VA = "0x1B2304C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public JSONObject Item
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1B24FE8", Offset = "0x1B24FE8", VA = "0x1B24FE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1B25074", Offset = "0x1B25074", VA = "0x1B25074")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public JSONObject Item
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1B23EF8", Offset = "0x1B23EF8", VA = "0x1B23EF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1B25A94", Offset = "0x1B25A94", VA = "0x1B25A94")]
			set
			{
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1B2155C", Offset = "0x1B2155C", VA = "0x1B2155C")]
		public JSONObject(Type t)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1B21664", Offset = "0x1B21664", VA = "0x1B21664")]
		public JSONObject(bool b)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1B2169C", Offset = "0x1B2169C", VA = "0x1B2169C")]
		public JSONObject(float f)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1B216D8", Offset = "0x1B216D8", VA = "0x1B216D8")]
		public JSONObject(int i)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1B21720", Offset = "0x1B21720", VA = "0x1B21720")]
		public JSONObject(long l)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1B21764", Offset = "0x1B21764", VA = "0x1B21764")]
		public JSONObject(Dictionary<string, string> dic)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1B21A58", Offset = "0x1B21A58", VA = "0x1B21A58")]
		public JSONObject(Dictionary<string, JSONObject> dic)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1B21C84", Offset = "0x1B21C84", VA = "0x1B21C84")]
		public JSONObject(AddJSONContents content)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1B21CC0", Offset = "0x1B21CC0", VA = "0x1B21CC0")]
		public JSONObject(JSONObject[] objs)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1B21D54", Offset = "0x1B21D54", VA = "0x1B21D54")]
		public static JSONObject StringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1B21DB4", Offset = "0x1B21DB4", VA = "0x1B21DB4")]
		public void Absorb(JSONObject obj)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1B21E78", Offset = "0x1B21E78", VA = "0x1B21E78")]
		public static JSONObject Create()
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1B21374", Offset = "0x1B21374", VA = "0x1B21374")]
		public static JSONObject Create(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1B21ED8", Offset = "0x1B21ED8", VA = "0x1B21ED8")]
		public static JSONObject Create(bool val)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1B21F50", Offset = "0x1B21F50", VA = "0x1B21F50")]
		public static JSONObject Create(float val)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1B21FCC", Offset = "0x1B21FCC", VA = "0x1B21FCC")]
		public static JSONObject Create(int val)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1B22054", Offset = "0x1B22054", VA = "0x1B22054")]
		public static JSONObject Create(uint val)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1B220E0", Offset = "0x1B220E0", VA = "0x1B220E0")]
		public static JSONObject Create(long val)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1B22164", Offset = "0x1B22164", VA = "0x1B22164")]
		public static JSONObject Create(ulong val)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1B219E4", Offset = "0x1B219E4", VA = "0x1B219E4")]
		public static JSONObject CreateStringObject(string val)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1B221EC", Offset = "0x1B221EC", VA = "0x1B221EC")]
		public static JSONObject CreateBakedObject(string val)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1B22260", Offset = "0x1B22260", VA = "0x1B22260")]
		public static JSONObject Create(string val, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1B22BBC", Offset = "0x1B22BBC", VA = "0x1B22BBC")]
		public static JSONObject Create(AddJSONContents content)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1B22C3C", Offset = "0x1B22C3C", VA = "0x1B22C3C")]
		public static JSONObject Create(Dictionary<string, string> dic)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1B21ED0", Offset = "0x1B21ED0", VA = "0x1B21ED0")]
		public JSONObject()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1B22ED4", Offset = "0x1B22ED4", VA = "0x1B22ED4")]
		public JSONObject(string str)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1B22F10", Offset = "0x1B22F10", VA = "0x1B22F10")]
		public JSONObject(string str, int maxDepth)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1B22F58", Offset = "0x1B22F58", VA = "0x1B22F58")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1B22FA4", Offset = "0x1B22FA4", VA = "0x1B22FA4")]
		public JSONObject(string str, int maxDepth, bool storeExcessLevels, bool strict)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1B22300", Offset = "0x1B22300", VA = "0x1B22300")]
		private void Parse(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1B23068", Offset = "0x1B23068", VA = "0x1B23068")]
		public void Add(bool val)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1B231F0", Offset = "0x1B231F0", VA = "0x1B231F0")]
		public void Add(float val)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1B23268", Offset = "0x1B23268", VA = "0x1B23268")]
		public void Add(int val)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1B232E0", Offset = "0x1B232E0", VA = "0x1B232E0")]
		public void Add(uint val)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1B23358", Offset = "0x1B23358", VA = "0x1B23358")]
		public void Add(long val)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1B233D0", Offset = "0x1B233D0", VA = "0x1B233D0")]
		public void Add(ulong val)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1B23448", Offset = "0x1B23448", VA = "0x1B23448")]
		public void Add(string str)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1B234C0", Offset = "0x1B234C0", VA = "0x1B234C0")]
		public void Add(AddJSONContents content)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1B230E0", Offset = "0x1B230E0", VA = "0x1B230E0")]
		public void Add(JSONObject obj)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1B23544", Offset = "0x1B23544", VA = "0x1B23544")]
		public void AddField(string name, bool val)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1B237DC", Offset = "0x1B237DC", VA = "0x1B237DC")]
		public void AddField(string name, float val)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1B23864", Offset = "0x1B23864", VA = "0x1B23864")]
		public void AddField(string name, int val)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1B238E4", Offset = "0x1B238E4", VA = "0x1B238E4")]
		public void AddField(string name, uint val)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1B23964", Offset = "0x1B23964", VA = "0x1B23964")]
		public void AddField(string name, long val)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1B239E4", Offset = "0x1B239E4", VA = "0x1B239E4")]
		public void AddField(string name, ulong val)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1B23A64", Offset = "0x1B23A64", VA = "0x1B23A64")]
		public void AddField(string name, AddJSONContents content)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1B23AE4", Offset = "0x1B23AE4", VA = "0x1B23AE4")]
		public void AddField(string name, string val)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1B235C4", Offset = "0x1B235C4", VA = "0x1B235C4")]
		public void AddField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1B23B64", Offset = "0x1B23B64", VA = "0x1B23B64")]
		public void SetField(string name, string val)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1B23CA4", Offset = "0x1B23CA4", VA = "0x1B23CA4")]
		public void SetField(string name, bool val)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1B23D24", Offset = "0x1B23D24", VA = "0x1B23D24")]
		public void SetField(string name, float val)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1B23DAC", Offset = "0x1B23DAC", VA = "0x1B23DAC")]
		public void SetField(string name, int val)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1B23BE4", Offset = "0x1B23BE4", VA = "0x1B23BE4")]
		public void SetField(string name, JSONObject obj)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1B23EFC", Offset = "0x1B23EFC", VA = "0x1B23EFC")]
		public void RemoveField(string name)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1B23FDC", Offset = "0x1B23FDC", VA = "0x1B23FDC")]
		public bool GetField(out bool field, string name, bool fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1B23FEC", Offset = "0x1B23FEC", VA = "0x1B23FEC")]
		public bool GetField(ref bool field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1B23FF4", Offset = "0x1B23FF4", VA = "0x1B23FF4")]
		public bool GetField(ref bool field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1B240E0", Offset = "0x1B240E0", VA = "0x1B240E0")]
		public bool GetField(out float field, string name, float fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1B240EC", Offset = "0x1B240EC", VA = "0x1B240EC")]
		public bool GetField(ref float field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1B240F4", Offset = "0x1B240F4", VA = "0x1B240F4")]
		public bool GetField(ref float field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1B241E0", Offset = "0x1B241E0", VA = "0x1B241E0")]
		public bool GetField(out int field, string name, int fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1B241EC", Offset = "0x1B241EC", VA = "0x1B241EC")]
		public bool GetField(ref int field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1B241F4", Offset = "0x1B241F4", VA = "0x1B241F4")]
		public bool GetField(ref int field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1B24344", Offset = "0x1B24344", VA = "0x1B24344")]
		public bool GetField(out long field, string name, long fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1B24350", Offset = "0x1B24350", VA = "0x1B24350")]
		public bool GetField(ref long field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1B24358", Offset = "0x1B24358", VA = "0x1B24358")]
		public bool GetField(ref long field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1B244A8", Offset = "0x1B244A8", VA = "0x1B244A8")]
		public bool GetField(out uint field, string name, uint fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1B244B4", Offset = "0x1B244B4", VA = "0x1B244B4")]
		public bool GetField(ref uint field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1B244BC", Offset = "0x1B244BC", VA = "0x1B244BC")]
		public bool GetField(ref uint field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1B24600", Offset = "0x1B24600", VA = "0x1B24600")]
		public bool GetField(out ulong field, string name, ulong fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1B2460C", Offset = "0x1B2460C", VA = "0x1B2460C")]
		public bool GetField(ref ulong field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1B24614", Offset = "0x1B24614", VA = "0x1B24614")]
		public bool GetField(ref ulong field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1B24758", Offset = "0x1B24758", VA = "0x1B24758")]
		public bool GetField(out string field, string name, string fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1B24764", Offset = "0x1B24764", VA = "0x1B24764")]
		public bool GetField(ref string field, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1B2476C", Offset = "0x1B2476C", VA = "0x1B2476C")]
		public bool GetField(ref string field, string name, FieldNotFound fail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1B24860", Offset = "0x1B24860", VA = "0x1B24860")]
		public void GetField(string name, GetFieldResponse response, [Optional] FieldNotFound fail)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1B2496C", Offset = "0x1B2496C", VA = "0x1B2496C")]
		public JSONObject GetField(string name)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1B24A68", Offset = "0x1B24A68", VA = "0x1B24A68")]
		public bool HasFields(string[] names)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1B23E2C", Offset = "0x1B23E2C", VA = "0x1B23E2C")]
		public bool HasField(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1B24B3C", Offset = "0x1B24B3C", VA = "0x1B24B3C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1B24BE4", Offset = "0x1B24BE4", VA = "0x1B24BE4")]
		public JSONObject Copy()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1B24C6C", Offset = "0x1B24C6C", VA = "0x1B24C6C")]
		public void Merge(JSONObject obj)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1B24CDC", Offset = "0x1B24CDC", VA = "0x1B24CDC")]
		private static void MergeRecur(JSONObject left, JSONObject right)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1B25108", Offset = "0x1B25108", VA = "0x1B25108")]
		public void Bake()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1B25144", Offset = "0x1B25144", VA = "0x1B25144")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC4C4", Offset = "0x9FC4C4")]
		public IEnumerable BakeAsync()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1B24C64", Offset = "0x1B24C64", VA = "0x1B24C64")]
		public string Print()
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1B251B0", Offset = "0x1B251B0", VA = "0x1B251B0")]
		public string Print(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1B2597C", Offset = "0x1B2597C", VA = "0x1B2597C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC524", Offset = "0x9FC524")]
		public IEnumerable<string> PrintAsync(bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1B259FC", Offset = "0x1B259FC", VA = "0x1B259FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC584", Offset = "0x9FC584")]
		private IEnumerable StringifyAsync(int depth, StringBuilder builder, bool pretty = false)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1B2523C", Offset = "0x1B2523C", VA = "0x1B2523C")]
		private void Stringify(int depth, StringBuilder builder, bool pretty = false)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1B25A98", Offset = "0x1B25A98", VA = "0x1B25A98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1B25AA0", Offset = "0x1B25AA0", VA = "0x1B25AA0")]
		public string ToString(bool pretty)
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1B25AA8", Offset = "0x1B25AA8", VA = "0x1B25AA8")]
		public Dictionary<string, string> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1B23538", Offset = "0x1B23538", VA = "0x1B23538")]
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
		[Address(RVA = "0x2466564", Offset = "0x2466564", VA = "0x2466564")]
		public static JSONObject TOJSON(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2467218", Offset = "0x2467218", VA = "0x2467218")]
		public static Vector2 ToVector2(JSONObject obj)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2467358", Offset = "0x2467358", VA = "0x2467358")]
		public static JSONObject FromVector2(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x246743C", Offset = "0x246743C", VA = "0x246743C")]
		public static JSONObject FromVector3(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2467560", Offset = "0x2467560", VA = "0x2467560")]
		public static Vector3 ToVector3(JSONObject obj)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x2467714", Offset = "0x2467714", VA = "0x2467714")]
		public static JSONObject FromVector4(Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x2467870", Offset = "0x2467870", VA = "0x2467870")]
		public static Vector4 ToVector4(JSONObject obj)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2467AC0", Offset = "0x2467AC0", VA = "0x2467AC0")]
		public static JSONObject FromMatrix4x4(Matrix4x4 m)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2467E70", Offset = "0x2467E70", VA = "0x2467E70")]
		public static Matrix4x4 ToMatrix4x4(JSONObject obj)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2468660", Offset = "0x2468660", VA = "0x2468660")]
		public static JSONObject FromQuaternion(Quaternion q)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x24687BC", Offset = "0x24687BC", VA = "0x24687BC")]
		public static Quaternion ToQuaternion(JSONObject obj)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2468A0C", Offset = "0x2468A0C", VA = "0x2468A0C")]
		public static JSONObject FromColor(Color c)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x2468B68", Offset = "0x2468B68", VA = "0x2468B68")]
		public static Color ToColor(JSONObject obj)
		{
			return default(Color);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2468D70", Offset = "0x2468D70", VA = "0x2468D70")]
		public static JSONObject FromLayerMask(LayerMask l)
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2468E18", Offset = "0x2468E18", VA = "0x2468E18")]
		public static LayerMask ToLayerMask(JSONObject obj)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x2468EB4", Offset = "0x2468EB4", VA = "0x2468EB4")]
		public static JSONObject FromRect(Rect r)
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2469050", Offset = "0x2469050", VA = "0x2469050")]
		public static Rect ToRect(JSONObject obj)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2469258", Offset = "0x2469258", VA = "0x2469258")]
		public static JSONObject FromRectOffset(RectOffset r)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x24693EC", Offset = "0x24693EC", VA = "0x24693EC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9ED0", Offset = "0x9F9ED0")]
		private sealed class <>c
		{
			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__21_0;

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1F0BCF4", Offset = "0x1F0BCF4", VA = "0x1F0BCF4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1F0BCFC", Offset = "0x1F0BCFC", VA = "0x1F0BCFC")]
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
			[Address(RVA = "0x1D30230", Offset = "0x1D30230", VA = "0x1D30230")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1D30238", Offset = "0x1D30238", VA = "0x1D30238")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1D30614", Offset = "0x1D30614", VA = "0x1D30614")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1D3061C", Offset = "0x1D3061C", VA = "0x1D3061C")]
			set
			{
			}
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1D309F8", Offset = "0x1D309F8", VA = "0x1D309F8")]
		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters, bool fuzzy, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1D30B30", Offset = "0x1D30B30", VA = "0x1D30B30", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1D312C0", Offset = "0x1D312C0", VA = "0x1D312C0", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1D3293C", Offset = "0x1D3293C", VA = "0x1D3293C", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1D36998", Offset = "0x1D36998", VA = "0x1D36998", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1D3AC80", Offset = "0x1D3AC80", VA = "0x1D3AC80", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9EE0", Offset = "0x9F9EE0")]
		private sealed class <>c
		{
			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1F0CBF4", Offset = "0x1F0CBF4", VA = "0x1F0CBF4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1F0CBFC", Offset = "0x1F0CBFC", VA = "0x1F0CBFC")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FA2D0", Offset = "0x9FA2D0")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000063")]
		public Regex RegularExpression
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x1D3F3D0", Offset = "0x1D3F3D0", VA = "0x1D3F3D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC734", Offset = "0x9FC734")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1D3F3D8", Offset = "0x1D3F3D8", VA = "0x1D3F3D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC744", Offset = "0x9FC744")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public int CharacterNumber
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1D3F3E0", Offset = "0x1D3F3E0", VA = "0x1D3F3E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1D3F3E8", Offset = "0x1D3F3E8", VA = "0x1D3F3E8")]
			set
			{
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1D3F4B0", Offset = "0x1D3F4B0", VA = "0x1D3F4B0")]
		public CapitalizationFilter(int capitalizationCharsNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1D3F4F8", Offset = "0x1D3F4F8", VA = "0x1D3F4F8", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1D3F500", Offset = "0x1D3F500", VA = "0x1D3F500", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1D3F56C", Offset = "0x1D3F56C", VA = "0x1D3F56C", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1D3FCD0", Offset = "0x1D3FCD0", VA = "0x1D3FCD0", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1D402F8", Offset = "0x1D402F8", VA = "0x1D402F8", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9EF0", Offset = "0x9F9EF0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__13_0;

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x25D6D30", Offset = "0x25D6D30", VA = "0x25D6D30")]
			public <>c()
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x25D6D38", Offset = "0x25D6D38", VA = "0x25D6D38")]
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
			[Address(RVA = "0x1B169E4", Offset = "0x1B169E4", VA = "0x1B169E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1B169EC", Offset = "0x1B169EC", VA = "0x1B169EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1B16D50", Offset = "0x1B16D50", VA = "0x1B16D50")]
		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1B16EE0", Offset = "0x1B16EE0", VA = "0x1B16EE0", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1B17348", Offset = "0x1B17348", VA = "0x1B17348", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1B180A8", Offset = "0x1B180A8", VA = "0x1B180A8", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1B1A364", Offset = "0x1B1A364", VA = "0x1B1A364", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1B1C83C", Offset = "0x1B1C83C", VA = "0x1B1C83C", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F00", Offset = "0x9F9F00")]
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
			[Address(RVA = "0x25D7C2C", Offset = "0x25D7C2C", VA = "0x25D7C2C")]
			public <>c()
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x25D7C34", Offset = "0x25D7C34", VA = "0x25D7C34")]
			internal string <Sources>b__8_0(KeyValuePair<string, Source> x)
			{
				return null;
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x25D7C74", Offset = "0x25D7C74", VA = "0x25D7C74")]
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
		[Address(RVA = "0x1B1EF7C", Offset = "0x1B1EF7C", VA = "0x1B1EF7C", Slot = "9")]
		public virtual List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1B1F1F4", Offset = "0x1B1F1F4", VA = "0x1B1F1F4", Slot = "10")]
		public virtual string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1B1F404", Offset = "0x1B1F404", VA = "0x1B1F404", Slot = "11")]
		public virtual string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1B18034", Offset = "0x1B18034", VA = "0x1B18034")]
		protected void logFilterNotReady()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1B18030", Offset = "0x1B18030", VA = "0x1B18030")]
		protected void logResourceNotFound(string res)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1B1802C", Offset = "0x1B1802C", VA = "0x1B1802C")]
		protected void logContains()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1B1A360", Offset = "0x1B1A360", VA = "0x1B1A360")]
		protected void logGetAll()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1B1C6A0", Offset = "0x1B1C6A0", VA = "0x1B1C6A0")]
		protected void logReplaceAll()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1B16E30", Offset = "0x1B16E30", VA = "0x1B16E30")]
		protected Filter()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class PunctuationFilter : Filter
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F10", Offset = "0x9F9F10")]
		private sealed class <>c
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__11_0;

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x25DBDA8", Offset = "0x25DBDA8", VA = "0x25DBDA8")]
			public <>c()
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x25DBDB0", Offset = "0x25DBDB0", VA = "0x25DBDB0")]
			internal string <GetAll>b__11_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FA2E0", Offset = "0x9FA2E0")]
		private Regex <RegularExpression>k__BackingField;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000066")]
		public Regex RegularExpression
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1EFFEA8", Offset = "0x1EFFEA8", VA = "0x1EFFEA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC754", Offset = "0x9FC754")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1EFFEB0", Offset = "0x1EFFEB0", VA = "0x1EFFEB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FC764", Offset = "0x9FC764")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public int CharacterNumber
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1EFFEB8", Offset = "0x1EFFEB8", VA = "0x1EFFEB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1EFFEC0", Offset = "0x1EFFEC0", VA = "0x1EFFEC0")]
			set
			{
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1EFFF88", Offset = "0x1EFFF88", VA = "0x1EFFF88")]
		public PunctuationFilter(int punctuationCharacterNumber, string markPrefix, string markPostfix)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1EFFFD0", Offset = "0x1EFFFD0", VA = "0x1EFFFD0", Slot = "4")]
		public override bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1EFFFD8", Offset = "0x1EFFFD8", VA = "0x1EFFFD8", Slot = "5")]
		public override bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1F00044", Offset = "0x1F00044", VA = "0x1F00044", Slot = "6")]
		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1F007A8", Offset = "0x1F007A8", VA = "0x1F007A8", Slot = "7")]
		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1F00DC8", Offset = "0x1F00DC8", VA = "0x1F00DC8", Slot = "8")]
		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	public class BadWordManager : Manager
	{
		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F20", Offset = "0x9F9F20")]
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
				[Address(RVA = "0x1F0BF58", Offset = "0x1F0BF58", VA = "0x1F0BF58", Slot = "4")]
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
				[Address(RVA = "0x1F0BFA0", Offset = "0x1F0BFA0", VA = "0x1F0BFA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x1F0BD04", Offset = "0x1F0BD04", VA = "0x1F0BD04")]
			[DebuggerHidden]
			public <initalize>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x1F0BD30", Offset = "0x1F0BD30", VA = "0x1F0BD30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x1F0BD34", Offset = "0x1F0BD34", VA = "0x1F0BD34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1F0BF60", Offset = "0x1F0BF60", VA = "0x1F0BF60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA2F0", Offset = "0x9FA2F0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA2F0", Offset = "0x9FA2F0")]
		public List<BadWordProvider> BadWordProviderLTR;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA350", Offset = "0x9FA350")]
		public List<BadWordProvider> BadWordProviderRTL;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA388", Offset = "0x9FA388")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA388", Offset = "0x9FA388")]
		public string ReplaceChars;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA3E8", Offset = "0x9FA3E8")]
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
		[Address(RVA = "0x1D3AF74", Offset = "0x1D3AF74", VA = "0x1D3AF74")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1D3B14C", Offset = "0x1D3B14C", VA = "0x1D3B14C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC774", Offset = "0x9FC774")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1D3B1B8", Offset = "0x1D3B1B8", VA = "0x1D3B1B8")]
		public static BadWordFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1D3B21C", Offset = "0x1D3B21C", VA = "0x1D3B21C")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1D3B544", Offset = "0x1D3B544", VA = "0x1D3B544")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1D3B664", Offset = "0x1D3B664", VA = "0x1D3B664")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1D3B764", Offset = "0x1D3B764", VA = "0x1D3B764")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1D3B8A0", Offset = "0x1D3B8A0", VA = "0x1D3B8A0")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1D3B9A0", Offset = "0x1D3B9A0", VA = "0x1D3B9A0")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1D3BAA0", Offset = "0x1D3BAA0", VA = "0x1D3BAA0")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1D3BBBC", Offset = "0x1D3BBBC", VA = "0x1D3BBBC")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1D3B300", Offset = "0x1D3B300", VA = "0x1D3B300")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1D3BCC4", Offset = "0x1D3BCC4", VA = "0x1D3BCC4")]
		public BadWordManager()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class CapitalizationManager : Manager
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA420", Offset = "0x9FA420")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA420", Offset = "0x9FA420")]
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
		[Address(RVA = "0x1D4059C", Offset = "0x1D4059C", VA = "0x1D4059C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1D40884", Offset = "0x1D40884", VA = "0x1D40884")]
		public static CapitalizationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1D408E8", Offset = "0x1D408E8", VA = "0x1D408E8")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1D4095C", Offset = "0x1D4095C", VA = "0x1D4095C")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1D40CC0", Offset = "0x1D40CC0", VA = "0x1D40CC0")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1D40DC0", Offset = "0x1D40DC0", VA = "0x1D40DC0")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1D40EFC", Offset = "0x1D40EFC", VA = "0x1D40EFC")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1D40FFC", Offset = "0x1D40FFC", VA = "0x1D40FFC")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1D410FC", Offset = "0x1D410FC", VA = "0x1D410FC")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1D41218", Offset = "0x1D41218", VA = "0x1D41218")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1D40A7C", Offset = "0x1D40A7C", VA = "0x1D40A7C")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1D41320", Offset = "0x1D41320", VA = "0x1D41320")]
		public CapitalizationManager()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class DomainManager : Manager
	{
		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F30", Offset = "0x9F9F30")]
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
				[Address(RVA = "0x25D6F7C", Offset = "0x25D6F7C", VA = "0x25D6F7C", Slot = "4")]
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
				[Address(RVA = "0x25D6FC4", Offset = "0x25D6FC4", VA = "0x25D6FC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x25D6D40", Offset = "0x25D6D40", VA = "0x25D6D40")]
			[DebuggerHidden]
			public <initalize>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x25D6D6C", Offset = "0x25D6D6C", VA = "0x25D6D6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x25D6D70", Offset = "0x25D6D70", VA = "0x25D6D70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x25D6F84", Offset = "0x25D6F84", VA = "0x25D6F84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA480", Offset = "0x9FA480")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA480", Offset = "0x9FA480")]
		public List<DomainProvider> DomainProvider;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA4E0", Offset = "0x9FA4E0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA4E0", Offset = "0x9FA4E0")]
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
		[Address(RVA = "0x1B1CB2C", Offset = "0x1B1CB2C", VA = "0x1B1CB2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1B1CD04", Offset = "0x1B1CD04", VA = "0x1B1CD04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC824", Offset = "0x9FC824")]
		private IEnumerator initalize()
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1B1CD70", Offset = "0x1B1CD70", VA = "0x1B1CD70")]
		public static DomainFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1B1CDD4", Offset = "0x1B1CDD4", VA = "0x1B1CDD4")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1B1D0FC", Offset = "0x1B1D0FC", VA = "0x1B1D0FC")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1B1D21C", Offset = "0x1B1D21C", VA = "0x1B1D21C")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1B1D31C", Offset = "0x1B1D31C", VA = "0x1B1D31C")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1B1D458", Offset = "0x1B1D458", VA = "0x1B1D458")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1B1D558", Offset = "0x1B1D558", VA = "0x1B1D558")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1B1D658", Offset = "0x1B1D658", VA = "0x1B1D658")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1B1D774", Offset = "0x1B1D774", VA = "0x1B1D774")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1B1CEB8", Offset = "0x1B1CEB8", VA = "0x1B1CEB8")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1B1D87C", Offset = "0x1B1D87C", VA = "0x1B1D87C")]
		public DomainManager()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public abstract class Manager : MonoBehaviour
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA540", Offset = "0x9FA540")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA540", Offset = "0x9FA540")]
		public string MarkPrefix;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA5A0", Offset = "0x9FA5A0")]
		public string MarkPostfix;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x206B7A4", Offset = "0x206B7A4", VA = "0x206B7A4")]
		protected Manager()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class PunctuationManager : Manager
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA5D8", Offset = "0x9FA5D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA5D8", Offset = "0x9FA5D8")]
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
		[Address(RVA = "0x1F0107C", Offset = "0x1F0107C", VA = "0x1F0107C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1F01364", Offset = "0x1F01364", VA = "0x1F01364")]
		public static PunctuationFilter Filter()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1F013C8", Offset = "0x1F013C8", VA = "0x1F013C8")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1F0143C", Offset = "0x1F0143C", VA = "0x1F0143C")]
		public static List<Source> Sources()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1F017A0", Offset = "0x1F017A0", VA = "0x1F017A0")]
		public static bool Contains(string testString, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1F018A0", Offset = "0x1F018A0", VA = "0x1F018A0")]
		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1F019DC", Offset = "0x1F019DC", VA = "0x1F019DC")]
		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1F01ADC", Offset = "0x1F01ADC", VA = "0x1F01ADC")]
		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1F01BDC", Offset = "0x1F01BDC", VA = "0x1F01BDC")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1F01CF8", Offset = "0x1F01CF8", VA = "0x1F01CF8")]
		public static string Unmark(string text, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1F0155C", Offset = "0x1F0155C", VA = "0x1F0155C")]
		private static void logFilterIsNull(string clazz)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1F01E00", Offset = "0x1F01E00", VA = "0x1F01E00")]
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
		[Address(RVA = "0x1D3CFE0", Offset = "0x1D3CFE0", VA = "0x1D3CFE0")]
		public BadWords(Source source, List<string> badWordList)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1D3D018", Offset = "0x1D3D018", VA = "0x1D3D018", Slot = "3")]
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
		[Address(RVA = "0x1B1E9FC", Offset = "0x1B1E9FC", VA = "0x1B1E9FC")]
		public Domains(Source source, List<string> domainList)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1B1EA34", Offset = "0x1B1EA34", VA = "0x1B1EA34", Slot = "3")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA638", Offset = "0x9FA638")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA638", Offset = "0x9FA638")]
		public string Name;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA698", Offset = "0x9FA698")]
		public string Description;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA6D0", Offset = "0x9FA6D0")]
		public Sprite Icon;

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1F03A34", Offset = "0x1F03A34", VA = "0x1F03A34", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1F03C08", Offset = "0x1F03C08", VA = "0x1F03C08")]
		protected Source()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public static class MultiManager
	{
		[Serializable]
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F40", Offset = "0x9F9F40")]
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
			[Address(RVA = "0x25DBD20", Offset = "0x25DBD20", VA = "0x25DBD20")]
			public <>c()
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x25DBD28", Offset = "0x25DBD28", VA = "0x25DBD28")]
			internal string <Sources>b__2_0(Source x)
			{
				return null;
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x25DBD40", Offset = "0x25DBD40", VA = "0x25DBD40")]
			internal string <GetAll>b__4_0(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x206D934", Offset = "0x206D934", VA = "0x206D934")]
		public static Filter Filter(ManagerMask mask = ManagerMask.BadWord)
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x206DB38", Offset = "0x206DB38", VA = "0x206DB38")]
		public static bool Ready()
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x206DC4C", Offset = "0x206DC4C", VA = "0x206DC4C")]
		public static List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x206DF38", Offset = "0x206DF38", VA = "0x206DF38")]
		public static bool Contains(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x206E1DC", Offset = "0x206E1DC", VA = "0x206E1DC")]
		public static List<string> GetAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x206E51C", Offset = "0x206E51C", VA = "0x206E51C")]
		public static string ReplaceAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x206E6B8", Offset = "0x206E6B8", VA = "0x206E6B8")]
		public static string Replace(string text, List<string> badWords, ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x206E854", Offset = "0x206E854", VA = "0x206E854")]
		public static string Mark(string text, List<string> badWords, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x206E904", Offset = "0x206E904", VA = "0x206E904")]
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
			[Address(RVA = "0x1D3BD1C", Offset = "0x1D3BD1C", VA = "0x1D3BD1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1D3BD24", Offset = "0x1D3BD24", VA = "0x1D3BD24")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Dictionary<string, Regex> FuzzyBadwordsRegex
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1D3BD2C", Offset = "0x1D3BD2C", VA = "0x1D3BD2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1D3BD34", Offset = "0x1D3BD34", VA = "0x1D3BD34")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1D3BD3C", Offset = "0x1D3BD3C", VA = "0x1D3BD3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x1D3BD44", Offset = "0x1D3BD44", VA = "0x1D3BD44")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Dictionary<string, List<Regex>> DebugFuzzyBadwordsRegex
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x1D3BD4C", Offset = "0x1D3BD4C", VA = "0x1D3BD4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x1D3BD54", Offset = "0x1D3BD54", VA = "0x1D3BD54")]
			protected set
			{
			}
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1D3BD5C", Offset = "0x1D3BD5C", VA = "0x1D3BD5C", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1D3C948", Offset = "0x1D3C948", VA = "0x1D3C948")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA708", Offset = "0x9FA708")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA708", Offset = "0x9FA708")]
		public string File;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA768", Offset = "0x9FA768")]
		public int SkipHeaderLines;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA7A0", Offset = "0x9FA7A0")]
		public int SkipFooterLines;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA7D8", Offset = "0x9FA7D8")]
		public char SplitChar;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1D301CC", Offset = "0x1D301CC", VA = "0x1D301CC")]
		public BadWordFile()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class BadWordProviderFile : BadWordProvider
	{
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F50", Offset = "0x9F9F50")]
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
				[Address(RVA = "0x1F0C00C", Offset = "0x1F0C00C", VA = "0x1F0C00C", Slot = "4")]
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
				[Address(RVA = "0x1F0C054", Offset = "0x1F0C054", VA = "0x1F0C054", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1F0BFA8", Offset = "0x1F0BFA8", VA = "0x1F0BFA8")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0x1F0BFD4", Offset = "0x1F0BFD4", VA = "0x1F0BFD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x1F0BFD8", Offset = "0x1F0BFD8", VA = "0x1F0BFD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x1F0C014", Offset = "0x1F0C014", VA = "0x1F0C014", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA810", Offset = "0x9FA810")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA810", Offset = "0x9FA810")]
		public string FilePathWindows;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA870", Offset = "0x9FA870")]
		public string FilePathOSX;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA8A8", Offset = "0x9FA8A8")]
		public string FilePathLinux;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA8E0", Offset = "0x9FA8E0")]
		public BadWordFile[] Resources;

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1D3CAA4", Offset = "0x1D3CAA4", VA = "0x1D3CAA4", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1D3CBB8", Offset = "0x1D3CBB8", VA = "0x1D3CBB8", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1D3CC2C", Offset = "0x1D3CC2C", VA = "0x1D3CC2C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC8D4", Offset = "0x9FC8D4")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1D3CC88", Offset = "0x1D3CC88", VA = "0x1D3CC88")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FA918", Offset = "0x9FA918")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA918", Offset = "0x9FA918")]
		public TextAsset Resource;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA978", Offset = "0x9FA978")]
		public int SkipHeaderLines;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA9B0", Offset = "0x9FA9B0")]
		public int SkipFooterLines;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FA9E8", Offset = "0x9FA9E8")]
		public char SplitChar;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1D3CF6C", Offset = "0x1D3CF6C", VA = "0x1D3CF6C")]
		public BadWordResource()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class BadWordProviderResource : BadWordProvider
	{
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F60", Offset = "0x9F9F60")]
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
				[Address(RVA = "0x1F0C3EC", Offset = "0x1F0C3EC", VA = "0x1F0C3EC", Slot = "4")]
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
				[Address(RVA = "0x1F0C434", Offset = "0x1F0C434", VA = "0x1F0C434", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1F0C05C", Offset = "0x1F0C05C", VA = "0x1F0C05C")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1F0C088", Offset = "0x1F0C088", VA = "0x1F0C088", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x1F0C08C", Offset = "0x1F0C08C", VA = "0x1F0C08C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1F0C3F4", Offset = "0x1F0C3F4", VA = "0x1F0C3F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAA20", Offset = "0x9FAA20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FAA20", Offset = "0x9FAA20")]
		public BadWordResource[] Resources;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1D3CCF8", Offset = "0x1D3CCF8", VA = "0x1D3CCF8", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1D3CD90", Offset = "0x1D3CD90", VA = "0x1D3CD90", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1D3CD24", Offset = "0x1D3CD24", VA = "0x1D3CD24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FC984", Offset = "0x9FC984")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1D3CE04", Offset = "0x1D3CE04", VA = "0x1D3CE04")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAA80", Offset = "0x9FAA80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FAA80", Offset = "0x9FAA80")]
		public string URL;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAAE0", Offset = "0x9FAAE0")]
		public int SkipHeaderLines;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAB18", Offset = "0x9FAB18")]
		public int SkipFooterLines;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAB50", Offset = "0x9FAB50")]
		public char SplitChar;

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1D3CF7C", Offset = "0x1D3CF7C", VA = "0x1D3CF7C")]
		public BadWordWeb()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class BadWordProviderWeb : BadWordProvider
	{
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F70", Offset = "0x9F9F70")]
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
				[Address(RVA = "0x1F0CB44", Offset = "0x1F0CB44", VA = "0x1F0CB44", Slot = "4")]
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
				[Address(RVA = "0x1F0CB8C", Offset = "0x1F0CB8C", VA = "0x1F0CB8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1F0C43C", Offset = "0x1F0C43C", VA = "0x1F0C43C")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1F0C468", Offset = "0x1F0C468", VA = "0x1F0C468", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0x1F0C46C", Offset = "0x1F0C46C", VA = "0x1F0C46C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0x1F0CB4C", Offset = "0x1F0CB4C", VA = "0x1F0CB4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FAB88", Offset = "0x9FAB88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAB88", Offset = "0x9FAB88")]
		public string MainURL;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FABE8", Offset = "0x9FABE8")]
		public BadWordWeb[] Resources;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1D3CE08", Offset = "0x1D3CE08", VA = "0x1D3CE08", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1D3CEA0", Offset = "0x1D3CEA0", VA = "0x1D3CEA0", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1D3CE34", Offset = "0x1D3CE34", VA = "0x1D3CE34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCA34", Offset = "0x9FCA34")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1D3CF14", Offset = "0x1D3CF14", VA = "0x1D3CF14")]
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
			[Address(RVA = "0x1B1D8D4", Offset = "0x1B1D8D4", VA = "0x1B1D8D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x1B1D8DC", Offset = "0x1B1D8DC", VA = "0x1B1D8DC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x1B1D8E4", Offset = "0x1B1D8E4", VA = "0x1B1D8E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x1B1D8EC", Offset = "0x1B1D8EC", VA = "0x1B1D8EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1B1D8F4", Offset = "0x1B1D8F4", VA = "0x1B1D8F4", Slot = "6")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1B1E2F0", Offset = "0x1B1E2F0", VA = "0x1B1E2F0")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FAC20", Offset = "0x9FAC20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAC20", Offset = "0x9FAC20")]
		public string File;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAC80", Offset = "0x9FAC80")]
		public int SkipHeaderLines;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FACB8", Offset = "0x9FACB8")]
		public int SkipFooterLines;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FACF0", Offset = "0x9FACF0")]
		public char SplitChar;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1B16980", Offset = "0x1B16980", VA = "0x1B16980")]
		public DomainFile()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class DomainProviderFile : DomainProvider
	{
		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F80", Offset = "0x9F9F80")]
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
				[Address(RVA = "0x25D7030", Offset = "0x25D7030", VA = "0x25D7030", Slot = "4")]
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
				[Address(RVA = "0x25D7078", Offset = "0x25D7078", VA = "0x25D7078", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x25D6FCC", Offset = "0x25D6FCC", VA = "0x25D6FCC")]
			[DebuggerHidden]
			public <loadFile>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x25D6FF8", Offset = "0x25D6FF8", VA = "0x25D6FF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x25D6FFC", Offset = "0x25D6FFC", VA = "0x25D6FFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x25D7038", Offset = "0x25D7038", VA = "0x25D7038", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FAD28", Offset = "0x9FAD28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAD28", Offset = "0x9FAD28")]
		public string FilePathWindows;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAD88", Offset = "0x9FAD88")]
		public string FilePathOSX;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FADC0", Offset = "0x9FADC0")]
		public string FilePathLinux;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FADF8", Offset = "0x9FADF8")]
		public DomainFile[] Resources;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1B1E414", Offset = "0x1B1E414", VA = "0x1B1E414", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1B1E5D4", Offset = "0x1B1E5D4", VA = "0x1B1E5D4", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1B1E648", Offset = "0x1B1E648", VA = "0x1B1E648")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCAE4", Offset = "0x9FCAE4")]
		private IEnumerator loadFile()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1B1E6A4", Offset = "0x1B1E6A4", VA = "0x1B1E6A4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FAE30", Offset = "0x9FAE30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAE30", Offset = "0x9FAE30")]
		public TextAsset Resource;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAE90", Offset = "0x9FAE90")]
		public int SkipHeaderLines;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAEC8", Offset = "0x9FAEC8")]
		public int SkipFooterLines;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAF00", Offset = "0x9FAF00")]
		public char SplitChar;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1B1E988", Offset = "0x1B1E988", VA = "0x1B1E988")]
		public DomainResource()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class DomainProviderResource : DomainProvider
	{
		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9F90", Offset = "0x9F9F90")]
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
				[Address(RVA = "0x25D7414", Offset = "0x25D7414", VA = "0x25D7414", Slot = "4")]
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
				[Address(RVA = "0x25D745C", Offset = "0x25D745C", VA = "0x25D745C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x25D7080", Offset = "0x25D7080", VA = "0x25D7080")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x25D70AC", Offset = "0x25D70AC", VA = "0x25D70AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0x25D70B0", Offset = "0x25D70B0", VA = "0x25D70B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x25D741C", Offset = "0x25D741C", VA = "0x25D741C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FAF38", Offset = "0x9FAF38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAF38", Offset = "0x9FAF38")]
		public DomainResource[] Resources;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1B1E714", Offset = "0x1B1E714", VA = "0x1B1E714", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1B1E7AC", Offset = "0x1B1E7AC", VA = "0x1B1E7AC", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1B1E740", Offset = "0x1B1E740", VA = "0x1B1E740")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCB94", Offset = "0x9FCB94")]
		private IEnumerator loadResource()
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1B1E820", Offset = "0x1B1E820", VA = "0x1B1E820")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FAF98", Offset = "0x9FAF98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAF98", Offset = "0x9FAF98")]
		public string URL;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FAFF8", Offset = "0x9FAFF8")]
		public int SkipHeaderLines;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB030", Offset = "0x9FB030")]
		public int SkipFooterLines;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB068", Offset = "0x9FB068")]
		public char SplitChar;

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1B1E998", Offset = "0x1B1E998", VA = "0x1B1E998")]
		public DomainWeb()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class DomainProviderWeb : DomainProvider
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9FA0", Offset = "0x9F9FA0")]
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
				[Address(RVA = "0x25D7B7C", Offset = "0x25D7B7C", VA = "0x25D7B7C", Slot = "4")]
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
				[Address(RVA = "0x25D7BC4", Offset = "0x25D7BC4", VA = "0x25D7BC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0x25D7464", Offset = "0x25D7464", VA = "0x25D7464")]
			[DebuggerHidden]
			public <loadWeb>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0x25D7490", Offset = "0x25D7490", VA = "0x25D7490", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0x25D7494", Offset = "0x25D7494", VA = "0x25D7494", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0x25D7B84", Offset = "0x25D7B84", VA = "0x25D7B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB0A0", Offset = "0x9FB0A0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FB0A0", Offset = "0x9FB0A0")]
		public string MainURL;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB100", Offset = "0x9FB100")]
		public DomainWeb[] Resources;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1B1E824", Offset = "0x1B1E824", VA = "0x1B1E824", Slot = "4")]
		public override void Load()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1B1E8BC", Offset = "0x1B1E8BC", VA = "0x1B1E8BC", Slot = "5")]
		public override void Save()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1B1E850", Offset = "0x1B1E850", VA = "0x1B1E850")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCC44", Offset = "0x9FCC44")]
		private IEnumerator loadWeb()
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1B1E930", Offset = "0x1B1E930", VA = "0x1B1E930")]
		public DomainProviderWeb()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public abstract class Provider : MonoBehaviour
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB138", Offset = "0x9FB138")]
		public string Name;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB170", Offset = "0x9FB170")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FB170", Offset = "0x9FB170")]
		public RegexOptions RegexOption1;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB1D0", Offset = "0x9FB1D0")]
		public RegexOptions RegexOption2;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB208", Offset = "0x9FB208")]
		public RegexOptions RegexOption3;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB240", Offset = "0x9FB240")]
		public RegexOptions RegexOption4;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB278", Offset = "0x9FB278")]
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
			[Address(RVA = "0x1EFFBE0", Offset = "0x1EFFBE0", VA = "0x1EFFBE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x1EFFBE8", Offset = "0x1EFFBE8", VA = "0x1EFFBE8")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public List<Source> Sources
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x1EFFBF4", Offset = "0x1EFFBF4", VA = "0x1EFFBF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x1EFFBFC", Offset = "0x1EFFBFC", VA = "0x1EFFBFC")]
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
		[Address(RVA = "0x1EFFC04", Offset = "0x1EFFC04", VA = "0x1EFFC04")]
		public void Awake()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1EFFC10", Offset = "0x1EFFC10", VA = "0x1EFFC10")]
		protected void logNoResourcesAdded()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1EFFDFC", Offset = "0x1EFFDFC", VA = "0x1EFFDFC")]
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
		[Address(RVA = "0x1B1F530", Offset = "0x1B1F530", VA = "0x1B1F530")]
		public static bool WindowsPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1B1F568", Offset = "0x1B1F568", VA = "0x1B1F568")]
		public static bool OSXPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1B1F598", Offset = "0x1B1F598", VA = "0x1B1F598")]
		public static bool LinuxPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1B1E524", Offset = "0x1B1E524", VA = "0x1B1E524")]
		public static bool SupportedPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1B1F5B8", Offset = "0x1B1F5B8", VA = "0x1B1F5B8")]
		public static string ValidatePath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1B1F65C", Offset = "0x1B1F65C", VA = "0x1B1F65C")]
		public static List<string> SplitStringToLines(string text, int skipHeaderLines = 0, int skipFooterLines = 0, char splitChar = '#')
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1B1C6A4", Offset = "0x1B1C6A4", VA = "0x1B1C6A4")]
		public static string CreateReplaceString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		public static void AddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1B1F914", Offset = "0x1B1F914", VA = "0x1B1F914")]
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
		[Address(RVA = "0x1F0B6F8", Offset = "0x1F0B6F8", VA = "0x1F0B6F8")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return default(uint);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1F0BAB8", Offset = "0x1F0BAB8", VA = "0x1F0BAB8")]
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
		[Address(RVA = "0x206E9A4", Offset = "0x206E9A4", VA = "0x206E9A4")]
		private ObscuredBool(int value)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x206EA2C", Offset = "0x206EA2C", VA = "0x206EA2C")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x206EA94", Offset = "0x206EA94", VA = "0x206EA94")]
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x206EAF8", Offset = "0x206EAF8", VA = "0x206EAF8")]
		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x206EB8C", Offset = "0x206EB8C", VA = "0x206EB8C")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x206EBF0", Offset = "0x206EBF0", VA = "0x206EBF0")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x206EC7C", Offset = "0x206EC7C", VA = "0x206EC7C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x206EE64", Offset = "0x206EE64", VA = "0x206EE64")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x206EEFC", Offset = "0x206EEFC", VA = "0x206EEFC")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x206EF20", Offset = "0x206EF20", VA = "0x206EF20")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x206ED48", Offset = "0x206ED48", VA = "0x206ED48")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x206EFC8", Offset = "0x206EFC8", VA = "0x206EFC8")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x206F070", Offset = "0x206F070", VA = "0x206F070")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x206F09C", Offset = "0x206F09C", VA = "0x206F09C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x206F128", Offset = "0x206F128", VA = "0x206F128", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x206F1D8", Offset = "0x206F1D8", VA = "0x206F1D8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x206F208", Offset = "0x206F208", VA = "0x206F208", Slot = "3")]
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
		[Address(RVA = "0x206F288", Offset = "0x206F288", VA = "0x206F288")]
		private ObscuredByte(byte value)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x206F30C", Offset = "0x206F30C", VA = "0x206F30C")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x206F374", Offset = "0x206F374", VA = "0x206F374")]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x206F3D8", Offset = "0x206F3D8", VA = "0x206F3D8")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x206F458", Offset = "0x206F458", VA = "0x206F458")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x206F65C", Offset = "0x206F65C", VA = "0x206F65C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x206F6F4", Offset = "0x206F6F4", VA = "0x206F6F4")]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x206F718", Offset = "0x206F718", VA = "0x206F718")]
		public void SetEncrypted(byte encrypted)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x206F524", Offset = "0x206F524", VA = "0x206F524")]
		private byte InternalDecrypt()
		{
			return default(byte);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x206F754", Offset = "0x206F754", VA = "0x206F754")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x206F7E0", Offset = "0x206F7E0", VA = "0x206F7E0")]
		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x206F804", Offset = "0x206F804", VA = "0x206F804")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x206F89C", Offset = "0x206F89C", VA = "0x206F89C")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x206F934", Offset = "0x206F934", VA = "0x206F934", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x206F9BC", Offset = "0x206F9BC", VA = "0x206F9BC", Slot = "4")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x206FA68", Offset = "0x206FA68", VA = "0x206FA68", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x206FA94", Offset = "0x206FA94", VA = "0x206FA94")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x206FAC8", Offset = "0x206FAC8", VA = "0x206FAC8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x206FAF4", Offset = "0x206FAF4", VA = "0x206FAF4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x206FB28", Offset = "0x206FB28", VA = "0x206FB28", Slot = "5")]
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
		[Address(RVA = "0x206FBBC", Offset = "0x206FBBC", VA = "0x206FBBC")]
		private ObscuredChar(char value)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x206FC44", Offset = "0x206FC44", VA = "0x206FC44")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x206FCAC", Offset = "0x206FCAC", VA = "0x206FCAC")]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x206FD10", Offset = "0x206FD10", VA = "0x206FD10")]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x206FD90", Offset = "0x206FD90", VA = "0x206FD90")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x206FF98", Offset = "0x206FF98", VA = "0x206FF98")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2070030", Offset = "0x2070030", VA = "0x2070030")]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2070054", Offset = "0x2070054", VA = "0x2070054")]
		public void SetEncrypted(char encrypted)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x206FE5C", Offset = "0x206FE5C", VA = "0x206FE5C")]
		private char InternalDecrypt()
		{
			return default(char);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2070090", Offset = "0x2070090", VA = "0x2070090")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x207011C", Offset = "0x207011C", VA = "0x207011C")]
		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2070140", Offset = "0x2070140", VA = "0x2070140")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x20701D8", Offset = "0x20701D8", VA = "0x20701D8")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2070270", Offset = "0x2070270", VA = "0x2070270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x20702F8", Offset = "0x20702F8", VA = "0x20702F8", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x20703A0", Offset = "0x20703A0", VA = "0x20703A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x20703CC", Offset = "0x20703CC", VA = "0x20703CC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2070400", Offset = "0x2070400", VA = "0x2070400", Slot = "2")]
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
		[Address(RVA = "0x2071068", Offset = "0x2071068", VA = "0x2071068")]
		private ObscuredDecimal(byte[] value)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x20710EC", Offset = "0x20710EC", VA = "0x20710EC")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2071154", Offset = "0x2071154", VA = "0x2071154")]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x20711D0", Offset = "0x20711D0", VA = "0x20711D0")]
		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x20711DC", Offset = "0x20711DC", VA = "0x20711DC")]
		private static byte[] InternalEncrypt(decimal value)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2071250", Offset = "0x2071250", VA = "0x2071250")]
		private static byte[] InternalEncrypt(decimal value, long key)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2071400", Offset = "0x2071400", VA = "0x2071400")]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x207147C", Offset = "0x207147C", VA = "0x207147C")]
		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2071488", Offset = "0x2071488", VA = "0x2071488")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x20717E4", Offset = "0x20717E4", VA = "0x20717E4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2071884", Offset = "0x2071884", VA = "0x2071884")]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x207197C", Offset = "0x207197C", VA = "0x207197C")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2071558", Offset = "0x2071558", VA = "0x2071558")]
		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2071B08", Offset = "0x2071B08", VA = "0x2071B08")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2071BC4", Offset = "0x2071BC4", VA = "0x2071BC4")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2071BC8", Offset = "0x2071BC8", VA = "0x2071BC8")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2071D00", Offset = "0x2071D00", VA = "0x2071D00")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2071E04", Offset = "0x2071E04", VA = "0x2071E04")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2071F08", Offset = "0x2071F08", VA = "0x2071F08", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2071F34", Offset = "0x2071F34", VA = "0x2071F34")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2071F70", Offset = "0x2071F70", VA = "0x2071F70")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2071FAC", Offset = "0x2071FAC", VA = "0x2071FAC", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2071FF0", Offset = "0x2071FF0", VA = "0x2071FF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x207208C", Offset = "0x207208C", VA = "0x207208C", Slot = "4")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x20720E4", Offset = "0x20720E4", VA = "0x20720E4", Slot = "2")]
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
		[Address(RVA = "0x2072164", Offset = "0x2072164", VA = "0x2072164")]
		private ObscuredDouble(byte[] value)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x20721E8", Offset = "0x20721E8", VA = "0x20721E8")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2072250", Offset = "0x2072250", VA = "0x2072250")]
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x20722C8", Offset = "0x20722C8", VA = "0x20722C8")]
		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x20722D4", Offset = "0x20722D4", VA = "0x20722D4")]
		private static byte[] InternalEncrypt(double value)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2072340", Offset = "0x2072340", VA = "0x2072340")]
		private static byte[] InternalEncrypt(double value, long key)
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2072470", Offset = "0x2072470", VA = "0x2072470")]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x20724E0", Offset = "0x20724E0", VA = "0x20724E0")]
		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x20724EC", Offset = "0x20724EC", VA = "0x20724EC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2072790", Offset = "0x2072790", VA = "0x2072790")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2072828", Offset = "0x2072828", VA = "0x2072828")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x20728DC", Offset = "0x20728DC", VA = "0x20728DC")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x20725BC", Offset = "0x20725BC", VA = "0x20725BC")]
		private double InternalDecrypt()
		{
			return default(double);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x20729E8", Offset = "0x20729E8", VA = "0x20729E8")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x2072A88", Offset = "0x2072A88", VA = "0x2072A88")]
		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2072A8C", Offset = "0x2072A8C", VA = "0x2072A8C")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2072B34", Offset = "0x2072B34", VA = "0x2072B34")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2072BDC", Offset = "0x2072BDC", VA = "0x2072BDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2072C08", Offset = "0x2072C08", VA = "0x2072C08")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2072C3C", Offset = "0x2072C3C", VA = "0x2072C3C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2072C70", Offset = "0x2072C70", VA = "0x2072C70", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2072CB4", Offset = "0x2072CB4", VA = "0x2072CB4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2072D48", Offset = "0x2072D48", VA = "0x2072D48", Slot = "4")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2072D88", Offset = "0x2072D88", VA = "0x2072D88", Slot = "2")]
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
		[Address(RVA = "0x2072E08", Offset = "0x2072E08", VA = "0x2072E08")]
		private ObscuredFloat(byte[] value)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2072E90", Offset = "0x2072E90", VA = "0x2072E90")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2072EF8", Offset = "0x2072EF8", VA = "0x2072EF8")]
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2072F70", Offset = "0x2072F70", VA = "0x2072F70")]
		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2072F7C", Offset = "0x2072F7C", VA = "0x2072F7C")]
		private static byte[] InternalEncrypt(float value)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2072FE8", Offset = "0x2072FE8", VA = "0x2072FE8")]
		private static byte[] InternalEncrypt(float value, int key)
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x20730D8", Offset = "0x20730D8", VA = "0x20730D8")]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2073148", Offset = "0x2073148", VA = "0x2073148")]
		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2073154", Offset = "0x2073154", VA = "0x2073154")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x20733B8", Offset = "0x20733B8", VA = "0x20733B8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2073450", Offset = "0x2073450", VA = "0x2073450")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x20734C4", Offset = "0x20734C4", VA = "0x20734C4")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2073224", Offset = "0x2073224", VA = "0x2073224")]
		private float InternalDecrypt()
		{
			return default(float);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2073590", Offset = "0x2073590", VA = "0x2073590")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2071CFC", Offset = "0x2071CFC", VA = "0x2071CFC")]
		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2073638", Offset = "0x2073638", VA = "0x2073638")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x20736E8", Offset = "0x20736E8", VA = "0x20736E8")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x2073798", Offset = "0x2073798", VA = "0x2073798")]
		public float getValue()
		{
			return default(float);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x207379C", Offset = "0x207379C", VA = "0x207379C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x2073838", Offset = "0x2073838", VA = "0x2073838", Slot = "4")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2073880", Offset = "0x2073880", VA = "0x2073880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x20738AC", Offset = "0x20738AC", VA = "0x20738AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x20738D8", Offset = "0x20738D8", VA = "0x20738D8")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x207390C", Offset = "0x207390C", VA = "0x207390C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2073940", Offset = "0x2073940", VA = "0x2073940", Slot = "5")]
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
		[Address(RVA = "0x20739D8", Offset = "0x20739D8", VA = "0x20739D8")]
		private ObscuredInt(int value)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2073A5C", Offset = "0x2073A5C", VA = "0x2073A5C")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x2073AC4", Offset = "0x2073AC4", VA = "0x2073AC4")]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2073B28", Offset = "0x2073B28", VA = "0x2073B28")]
		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2073BA4", Offset = "0x2073BA4", VA = "0x2073BA4")]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x2073C08", Offset = "0x2073C08", VA = "0x2073C08")]
		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x2073C84", Offset = "0x2073C84", VA = "0x2073C84")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x2073E84", Offset = "0x2073E84", VA = "0x2073E84")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2073F20", Offset = "0x2073F20", VA = "0x2073F20")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x2073F44", Offset = "0x2073F44", VA = "0x2073F44")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x2073D50", Offset = "0x2073D50", VA = "0x2073D50")]
		private int InternalDecrypt()
		{
			return default(int);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x2073F80", Offset = "0x2073F80", VA = "0x2073F80")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x207400C", Offset = "0x207400C", VA = "0x207400C")]
		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2074030", Offset = "0x2074030", VA = "0x2074030")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x20740AC", Offset = "0x20740AC", VA = "0x20740AC")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x2074144", Offset = "0x2074144", VA = "0x2074144")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x20741DC", Offset = "0x20741DC", VA = "0x20741DC")]
		public int getValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x20741E0", Offset = "0x20741E0", VA = "0x20741E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2074268", Offset = "0x2074268", VA = "0x2074268", Slot = "4")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2074310", Offset = "0x2074310", VA = "0x2074310", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x207433C", Offset = "0x207433C", VA = "0x207433C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2074368", Offset = "0x2074368", VA = "0x2074368")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x207439C", Offset = "0x207439C", VA = "0x207439C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x20743D0", Offset = "0x20743D0", VA = "0x20743D0", Slot = "5")]
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
		[Address(RVA = "0x2074468", Offset = "0x2074468", VA = "0x2074468")]
		private ObscuredLong(long value)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x20744EC", Offset = "0x20744EC", VA = "0x20744EC")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2074554", Offset = "0x2074554", VA = "0x2074554")]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2074634", Offset = "0x2074634", VA = "0x2074634")]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x20745B8", Offset = "0x20745B8", VA = "0x20745B8")]
		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2074698", Offset = "0x2074698", VA = "0x2074698")]
		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2074714", Offset = "0x2074714", VA = "0x2074714")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2074914", Offset = "0x2074914", VA = "0x2074914")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x20749AC", Offset = "0x20749AC", VA = "0x20749AC")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x20749D0", Offset = "0x20749D0", VA = "0x20749D0")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x20747E0", Offset = "0x20747E0", VA = "0x20747E0")]
		private long InternalDecrypt()
		{
			return default(long);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2074A0C", Offset = "0x2074A0C", VA = "0x2074A0C")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x2074AAC", Offset = "0x2074AAC", VA = "0x2074AAC")]
		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x2074AB0", Offset = "0x2074AB0", VA = "0x2074AB0")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2074B50", Offset = "0x2074B50", VA = "0x2074B50")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x2074BF0", Offset = "0x2074BF0", VA = "0x2074BF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x2074C84", Offset = "0x2074C84", VA = "0x2074C84", Slot = "4")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x2074D2C", Offset = "0x2074D2C", VA = "0x2074D2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x2074D58", Offset = "0x2074D58", VA = "0x2074D58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2074D84", Offset = "0x2074D84", VA = "0x2074D84")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2074DB8", Offset = "0x2074DB8", VA = "0x2074DB8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2074DEC", Offset = "0x2074DEC", VA = "0x2074DEC", Slot = "5")]
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
			[Address(RVA = "0x2078014", Offset = "0x2078014", VA = "0x2078014")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x207813C", Offset = "0x207813C", VA = "0x207813C")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9FD0E4", Offset = "0x9FD0E4")]
		internal static string DeviceID
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2078278", Offset = "0x2078278", VA = "0x2078278")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x2078338", Offset = "0x2078338", VA = "0x2078338")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x20783B8", Offset = "0x20783B8", VA = "0x20783B8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000083")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x207D1B4", Offset = "0x207D1B4", VA = "0x207D1B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x2078474", Offset = "0x2078474", VA = "0x2078474")]
		public static void ForceLockToDeviceInit()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x2078578", Offset = "0x2078578", VA = "0x2078578")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2077868", Offset = "0x2077868", VA = "0x2077868")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x20787BC", Offset = "0x20787BC", VA = "0x20787BC")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2077A0C", Offset = "0x2077A0C", VA = "0x2077A0C")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2078708", Offset = "0x2078708", VA = "0x2078708")]
		private static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2078924", Offset = "0x2078924", VA = "0x2078924")]
		private static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x207970C", Offset = "0x207970C", VA = "0x207970C")]
		public static void SetUInt(string key, uint value)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x207984C", Offset = "0x207984C", VA = "0x207984C")]
		public static uint GetUInt(string key)
		{
			return default(uint);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x20798B0", Offset = "0x20798B0", VA = "0x20798B0")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x2079798", Offset = "0x2079798", VA = "0x2079798")]
		private static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x207998C", Offset = "0x207998C", VA = "0x207998C")]
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2077980", Offset = "0x2077980", VA = "0x2077980")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2079C34", Offset = "0x2079C34", VA = "0x2079C34")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2077D20", Offset = "0x2077D20", VA = "0x2077D20")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2079B00", Offset = "0x2079B00", VA = "0x2079B00")]
		public static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2079CAC", Offset = "0x2079CAC", VA = "0x2079CAC")]
		public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x20778F4", Offset = "0x20778F4", VA = "0x20778F4")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2079F3C", Offset = "0x2079F3C", VA = "0x2079F3C")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2077B94", Offset = "0x2077B94", VA = "0x2077B94")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2079E88", Offset = "0x2079E88", VA = "0x2079E88")]
		private static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2079FA0", Offset = "0x2079FA0", VA = "0x2079FA0")]
		private static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x207A11C", Offset = "0x207A11C", VA = "0x207A11C")]
		public static void SetDouble(string key, double value)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x207A25C", Offset = "0x207A25C", VA = "0x207A25C")]
		public static double GetDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x207A2C0", Offset = "0x207A2C0", VA = "0x207A2C0")]
		public static double GetDouble(string key, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x207A1A8", Offset = "0x207A1A8", VA = "0x207A1A8")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x207A3A8", Offset = "0x207A3A8", VA = "0x207A3A8")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x207A550", Offset = "0x207A550", VA = "0x207A550")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x207A690", Offset = "0x207A690", VA = "0x207A690")]
		public static long GetLong(string key)
		{
			return default(long);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x207A6F4", Offset = "0x207A6F4", VA = "0x207A6F4")]
		public static long GetLong(string key, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x207A5DC", Offset = "0x207A5DC", VA = "0x207A5DC")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x207A7D0", Offset = "0x207A7D0", VA = "0x207A7D0")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x207A944", Offset = "0x207A944", VA = "0x207A944")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x207AA84", Offset = "0x207AA84", VA = "0x207AA84")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x207AAE8", Offset = "0x207AAE8", VA = "0x207AAE8")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x207A9D0", Offset = "0x207A9D0", VA = "0x207A9D0")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x207ABC4", Offset = "0x207ABC4", VA = "0x207ABC4")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x207AD44", Offset = "0x207AD44", VA = "0x207AD44")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x207AE44", Offset = "0x207AE44", VA = "0x207AE44")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x207AEAC", Offset = "0x207AEAC", VA = "0x207AEAC")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x207ADD0", Offset = "0x207ADD0", VA = "0x207ADD0")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x207B058", Offset = "0x207B058", VA = "0x207B058")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x207AFB8", Offset = "0x207AFB8", VA = "0x207AFB8")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x207B1D0", Offset = "0x207B1D0", VA = "0x207B1D0")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x207B378", Offset = "0x207B378", VA = "0x207B378")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x207B3F8", Offset = "0x207B3F8", VA = "0x207B3F8")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x207B264", Offset = "0x207B264", VA = "0x207B264")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x207B4E4", Offset = "0x207B4E4", VA = "0x207B4E4")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x207B728", Offset = "0x207B728", VA = "0x207B728")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x207B910", Offset = "0x207B910", VA = "0x207B910")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x207B9A0", Offset = "0x207B9A0", VA = "0x207B9A0")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x207B7CC", Offset = "0x207B7CC", VA = "0x207B7CC")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x207BAA4", Offset = "0x207BAA4", VA = "0x207BAA4")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x207BD34", Offset = "0x207BD34", VA = "0x207BD34")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x207BF4C", Offset = "0x207BF4C", VA = "0x207BF4C")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x207BFE4", Offset = "0x207BFE4", VA = "0x207BFE4")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x207BDE0", Offset = "0x207BDE0", VA = "0x207BDE0")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x207C0F8", Offset = "0x207C0F8", VA = "0x207C0F8")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x207C3E0", Offset = "0x207C3E0", VA = "0x207C3E0")]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x207C52C", Offset = "0x207C52C", VA = "0x207C52C")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x207C5C0", Offset = "0x207C5C0", VA = "0x207C5C0")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x207C478", Offset = "0x207C478", VA = "0x207C478")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x207C6C4", Offset = "0x207C6C4", VA = "0x207C6C4")]
		public static void SetRect(string key, Rect value)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x207C8FC", Offset = "0x207C8FC", VA = "0x207C8FC")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x207C990", Offset = "0x207C990", VA = "0x207C990")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x207C770", Offset = "0x207C770", VA = "0x207C770")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x207CAA4", Offset = "0x207CAA4", VA = "0x207CAA4")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x207CDBC", Offset = "0x207CDBC", VA = "0x207CDBC")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x207CE34", Offset = "0x207CE34", VA = "0x207CE34")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x207CE9C", Offset = "0x207CE9C", VA = "0x207CE9C")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x2077EA8", Offset = "0x2077EA8", VA = "0x2077EA8")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x207CF24", Offset = "0x207CF24", VA = "0x207CF24")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x207CF2C", Offset = "0x207CF2C", VA = "0x207CF2C")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2078820", Offset = "0x2078820", VA = "0x2078820")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x20785FC", Offset = "0x20785FC", VA = "0x20785FC")]
		private static string EncryptKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2078A98", Offset = "0x2078A98", VA = "0x2078A98")]
		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2079264", Offset = "0x2079264", VA = "0x2079264")]
		private static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x20781BC", Offset = "0x20781BC", VA = "0x20781BC")]
		private static uint CalculateChecksum(string input)
		{
			return default(uint);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x207D030", Offset = "0x207D030", VA = "0x207D030")]
		private static void SavesTampered()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x207D0D8", Offset = "0x207D0D8", VA = "0x207D0D8")]
		private static void PossibleForeignSavesDetected()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x20780D4", Offset = "0x20780D4", VA = "0x20780D4")]
		private static string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x207CF34", Offset = "0x207CF34", VA = "0x207CF34")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x2078D80", Offset = "0x2078D80", VA = "0x2078D80")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x207D278", Offset = "0x207D278", VA = "0x207D278")]
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
		[Address(RVA = "0x1EF7B60", Offset = "0x1EF7B60", VA = "0x1EF7B60")]
		private ObscuredQuaternion(RawEncryptedQuaternion value)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1EF7BFC", Offset = "0x1EF7BFC", VA = "0x1EF7BFC")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1EF7C64", Offset = "0x1EF7C64", VA = "0x1EF7C64")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1EF7CF0", Offset = "0x1EF7CF0", VA = "0x1EF7CF0")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1EF7E0C", Offset = "0x1EF7E0C", VA = "0x1EF7E0C")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1EF7E80", Offset = "0x1EF7E80", VA = "0x1EF7E80")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1EF7F98", Offset = "0x1EF7F98", VA = "0x1EF7F98")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1EF82A0", Offset = "0x1EF82A0", VA = "0x1EF82A0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1EF835C", Offset = "0x1EF835C", VA = "0x1EF835C")]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1EF8384", Offset = "0x1EF8384", VA = "0x1EF8384")]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1EF808C", Offset = "0x1EF808C", VA = "0x1EF808C")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1EF83CC", Offset = "0x1EF83CC", VA = "0x1EF83CC")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1EF8528", Offset = "0x1EF8528", VA = "0x1EF8528")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1EF8610", Offset = "0x1EF8610", VA = "0x1EF8610")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1EF8614", Offset = "0x1EF8614", VA = "0x1EF8614", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1EF8644", Offset = "0x1EF8644", VA = "0x1EF8644", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1EF8674", Offset = "0x1EF8674", VA = "0x1EF8674")]
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
		[Address(RVA = "0x1EF8720", Offset = "0x1EF8720", VA = "0x1EF8720")]
		private ObscuredSByte(sbyte value)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1EF87A4", Offset = "0x1EF87A4", VA = "0x1EF87A4")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1EF880C", Offset = "0x1EF880C", VA = "0x1EF880C")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1EF8870", Offset = "0x1EF8870", VA = "0x1EF8870")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1EF88F0", Offset = "0x1EF88F0", VA = "0x1EF88F0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1EF8AF8", Offset = "0x1EF8AF8", VA = "0x1EF8AF8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1EF8B90", Offset = "0x1EF8B90", VA = "0x1EF8B90")]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1EF8BB4", Offset = "0x1EF8BB4", VA = "0x1EF8BB4")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1EF89BC", Offset = "0x1EF89BC", VA = "0x1EF89BC")]
		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1EF8BF4", Offset = "0x1EF8BF4", VA = "0x1EF8BF4")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1EF8C84", Offset = "0x1EF8C84", VA = "0x1EF8C84")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1EF8CA8", Offset = "0x1EF8CA8", VA = "0x1EF8CA8")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1EF8D44", Offset = "0x1EF8D44", VA = "0x1EF8D44")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1EF8DE0", Offset = "0x1EF8DE0", VA = "0x1EF8DE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1EF8E68", Offset = "0x1EF8E68", VA = "0x1EF8E68", Slot = "4")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1EF8F14", Offset = "0x1EF8F14", VA = "0x1EF8F14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1EF8F40", Offset = "0x1EF8F40", VA = "0x1EF8F40")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1EF8F74", Offset = "0x1EF8F74", VA = "0x1EF8F74", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1EF8FA0", Offset = "0x1EF8FA0", VA = "0x1EF8FA0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1EF8FD4", Offset = "0x1EF8FD4", VA = "0x1EF8FD4", Slot = "5")]
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
		[Address(RVA = "0x1EF9068", Offset = "0x1EF9068", VA = "0x1EF9068")]
		private ObscuredShort(short value)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1EF90F0", Offset = "0x1EF90F0", VA = "0x1EF90F0")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1EF9158", Offset = "0x1EF9158", VA = "0x1EF9158")]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1EF91BC", Offset = "0x1EF91BC", VA = "0x1EF91BC")]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1EF923C", Offset = "0x1EF923C", VA = "0x1EF923C")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1EF9448", Offset = "0x1EF9448", VA = "0x1EF9448")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1EF94E0", Offset = "0x1EF94E0", VA = "0x1EF94E0")]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1EF9504", Offset = "0x1EF9504", VA = "0x1EF9504")]
		public void SetEncrypted(short encrypted)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1EF9308", Offset = "0x1EF9308", VA = "0x1EF9308")]
		private short InternalDecrypt()
		{
			return default(short);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1EF9544", Offset = "0x1EF9544", VA = "0x1EF9544")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1EF95D4", Offset = "0x1EF95D4", VA = "0x1EF95D4")]
		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1EF95F8", Offset = "0x1EF95F8", VA = "0x1EF95F8")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1EF9684", Offset = "0x1EF9684", VA = "0x1EF9684")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1EF9710", Offset = "0x1EF9710", VA = "0x1EF9710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1EF9798", Offset = "0x1EF9798", VA = "0x1EF9798", Slot = "4")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1EF9840", Offset = "0x1EF9840", VA = "0x1EF9840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1EF986C", Offset = "0x1EF986C", VA = "0x1EF986C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1EF98A0", Offset = "0x1EF98A0", VA = "0x1EF98A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1EF98CC", Offset = "0x1EF98CC", VA = "0x1EF98CC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1EF9900", Offset = "0x1EF9900", VA = "0x1EF9900", Slot = "5")]
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
		[Address(RVA = "0x1EF9994", Offset = "0x1EF9994", VA = "0x1EF9994")]
		private ObscuredString()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1EF999C", Offset = "0x1EF999C", VA = "0x1EF999C")]
		private ObscuredString(byte[] value)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1EF9A2C", Offset = "0x1EF9A2C", VA = "0x1EF9A2C")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1EF9A94", Offset = "0x1EF9A94", VA = "0x1EF9A94")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1EF9B0C", Offset = "0x1EF9B0C", VA = "0x1EF9B0C")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1EF9C90", Offset = "0x1EF9C90", VA = "0x1EF9C90")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1EF9F68", Offset = "0x1EF9F68", VA = "0x1EF9F68")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1EFA084", Offset = "0x1EFA084", VA = "0x1EFA084")]
		public string GetEncrypted()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1EFA180", Offset = "0x1EFA180", VA = "0x1EFA180")]
		public void SetEncrypted(string encrypted)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1EF9EFC", Offset = "0x1EF9EFC", VA = "0x1EF9EFC")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1EFA010", Offset = "0x1EFA010", VA = "0x1EFA010")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1EF9D58", Offset = "0x1EF9D58", VA = "0x1EF9D58")]
		private string InternalDecrypt()
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1EFA2A0", Offset = "0x1EFA2A0", VA = "0x1EFA2A0")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1EFA350", Offset = "0x1EFA350", VA = "0x1EFA350")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1EFA4C8", Offset = "0x1EFA4C8", VA = "0x1EFA4C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1EFA3E4", Offset = "0x1EFA3E4", VA = "0x1EFA3E4")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1EFA550", Offset = "0x1EFA550", VA = "0x1EFA550")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1EFA5CC", Offset = "0x1EFA5CC", VA = "0x1EFA5CC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1EFA64C", Offset = "0x1EFA64C", VA = "0x1EFA64C")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1EFA758", Offset = "0x1EFA758", VA = "0x1EFA758")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1EFA820", Offset = "0x1EFA820", VA = "0x1EFA820", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1EFA214", Offset = "0x1EFA214", VA = "0x1EFA214")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1EFA0F0", Offset = "0x1EFA0F0", VA = "0x1EFA0F0")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1EFA4CC", Offset = "0x1EFA4CC", VA = "0x1EFA4CC")]
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
		[Address(RVA = "0x1EFA8A8", Offset = "0x1EFA8A8", VA = "0x1EFA8A8")]
		private ObscuredUInt(uint value)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1EFA92C", Offset = "0x1EFA92C", VA = "0x1EFA92C")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1EFA994", Offset = "0x1EFA994", VA = "0x1EFA994")]
		public static uint Encrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1EFAA74", Offset = "0x1EFAA74", VA = "0x1EFAA74")]
		public static uint Decrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1EFA9F8", Offset = "0x1EFA9F8", VA = "0x1EFA9F8")]
		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1EFAAD8", Offset = "0x1EFAAD8", VA = "0x1EFAAD8")]
		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1EFAB54", Offset = "0x1EFAB54", VA = "0x1EFAB54")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1EFAD58", Offset = "0x1EFAD58", VA = "0x1EFAD58")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1EFADF0", Offset = "0x1EFADF0", VA = "0x1EFADF0")]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1EFAE14", Offset = "0x1EFAE14", VA = "0x1EFAE14")]
		public void SetEncrypted(uint encrypted)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1EFAC20", Offset = "0x1EFAC20", VA = "0x1EFAC20")]
		private uint InternalDecrypt()
		{
			return default(uint);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1EFAE54", Offset = "0x1EFAE54", VA = "0x1EFAE54")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1EFAEE4", Offset = "0x1EFAEE4", VA = "0x1EFAEE4")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1EFAF08", Offset = "0x1EFAF08", VA = "0x1EFAF08")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1EFAF84", Offset = "0x1EFAF84", VA = "0x1EFAF84")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1EFB020", Offset = "0x1EFB020", VA = "0x1EFB020")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1EFB0BC", Offset = "0x1EFB0BC", VA = "0x1EFB0BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1EFB144", Offset = "0x1EFB144", VA = "0x1EFB144", Slot = "4")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1EFB1EC", Offset = "0x1EFB1EC", VA = "0x1EFB1EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1EFB218", Offset = "0x1EFB218", VA = "0x1EFB218")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1EFB24C", Offset = "0x1EFB24C", VA = "0x1EFB24C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1EFB278", Offset = "0x1EFB278", VA = "0x1EFB278")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1EFB2AC", Offset = "0x1EFB2AC", VA = "0x1EFB2AC", Slot = "5")]
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
		[Address(RVA = "0x1EFB344", Offset = "0x1EFB344", VA = "0x1EFB344")]
		private ObscuredULong(ulong value)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1EFB3C8", Offset = "0x1EFB3C8", VA = "0x1EFB3C8")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1EFB430", Offset = "0x1EFB430", VA = "0x1EFB430")]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1EFB510", Offset = "0x1EFB510", VA = "0x1EFB510")]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1EFB494", Offset = "0x1EFB494", VA = "0x1EFB494")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1EFB574", Offset = "0x1EFB574", VA = "0x1EFB574")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1EFB5F0", Offset = "0x1EFB5F0", VA = "0x1EFB5F0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1EFB7F4", Offset = "0x1EFB7F4", VA = "0x1EFB7F4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1EFB88C", Offset = "0x1EFB88C", VA = "0x1EFB88C")]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1EFB8B0", Offset = "0x1EFB8B0", VA = "0x1EFB8B0")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1EFB6BC", Offset = "0x1EFB6BC", VA = "0x1EFB6BC")]
		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1EFB8F0", Offset = "0x1EFB8F0", VA = "0x1EFB8F0")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1EFB994", Offset = "0x1EFB994", VA = "0x1EFB994")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1EFB998", Offset = "0x1EFB998", VA = "0x1EFB998")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1EFBA3C", Offset = "0x1EFBA3C", VA = "0x1EFBA3C")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1EFBAE0", Offset = "0x1EFBAE0", VA = "0x1EFBAE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1EFBB74", Offset = "0x1EFBB74", VA = "0x1EFBB74", Slot = "4")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1EFBC1C", Offset = "0x1EFBC1C", VA = "0x1EFBC1C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1EFBC48", Offset = "0x1EFBC48", VA = "0x1EFBC48", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1EFBC74", Offset = "0x1EFBC74", VA = "0x1EFBC74")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1EFBCA8", Offset = "0x1EFBCA8", VA = "0x1EFBCA8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1EFBCDC", Offset = "0x1EFBCDC", VA = "0x1EFBCDC", Slot = "5")]
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
		[Address(RVA = "0x1EFBD74", Offset = "0x1EFBD74", VA = "0x1EFBD74")]
		private ObscuredUShort(ushort value)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1EFBDFC", Offset = "0x1EFBDFC", VA = "0x1EFBDFC")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1EFBE64", Offset = "0x1EFBE64", VA = "0x1EFBE64")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1EFBEC8", Offset = "0x1EFBEC8", VA = "0x1EFBEC8")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1EFBF48", Offset = "0x1EFBF48", VA = "0x1EFBF48")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1EFC154", Offset = "0x1EFC154", VA = "0x1EFC154")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1EFC1EC", Offset = "0x1EFC1EC", VA = "0x1EFC1EC")]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1EFC210", Offset = "0x1EFC210", VA = "0x1EFC210")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1EFC014", Offset = "0x1EFC014", VA = "0x1EFC014")]
		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1EFC250", Offset = "0x1EFC250", VA = "0x1EFC250")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1EFC2E0", Offset = "0x1EFC2E0", VA = "0x1EFC2E0")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1EFC304", Offset = "0x1EFC304", VA = "0x1EFC304")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1EFC3A0", Offset = "0x1EFC3A0", VA = "0x1EFC3A0")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1EFC43C", Offset = "0x1EFC43C", VA = "0x1EFC43C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1EFC4C4", Offset = "0x1EFC4C4", VA = "0x1EFC4C4", Slot = "4")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1EFC56C", Offset = "0x1EFC56C", VA = "0x1EFC56C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1EFC598", Offset = "0x1EFC598", VA = "0x1EFC598")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1EFC5CC", Offset = "0x1EFC5CC", VA = "0x1EFC5CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1EFC5F8", Offset = "0x1EFC5F8", VA = "0x1EFC5F8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1EFC62C", Offset = "0x1EFC62C", VA = "0x1EFC62C", Slot = "5")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9F9FC0", Offset = "0x9F9FC0")]
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
			[Address(RVA = "0x1EFC754", Offset = "0x1EFC754", VA = "0x1EFC754")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1EFC928", Offset = "0x1EFC928", VA = "0x1EFC928")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public float y
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1EFCA14", Offset = "0x1EFCA14", VA = "0x1EFCA14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1EFCB4C", Offset = "0x1EFCB4C", VA = "0x1EFCB4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public float Item
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1EFCB8C", Offset = "0x1EFCB8C", VA = "0x1EFCB8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x1EFCBF4", Offset = "0x1EFCBF4", VA = "0x1EFCBF4")]
			set
			{
			}
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1EFC6C0", Offset = "0x1EFC6C0", VA = "0x1EFC6C0")]
		private ObscuredVector2(RawEncryptedVector2 value)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1EFCC5C", Offset = "0x1EFCC5C", VA = "0x1EFCC5C")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1EFCCC4", Offset = "0x1EFCCC4", VA = "0x1EFCCC4")]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1EFCD38", Offset = "0x1EFCD38", VA = "0x1EFCD38")]
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1EFCE10", Offset = "0x1EFCE10", VA = "0x1EFCE10")]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1EFCE74", Offset = "0x1EFCE74", VA = "0x1EFCE74")]
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1EFCF50", Offset = "0x1EFCF50", VA = "0x1EFCF50")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1EFD1F8", Offset = "0x1EFD1F8", VA = "0x1EFD1F8")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1EFD298", Offset = "0x1EFD298", VA = "0x1EFD298")]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1EFD2BC", Offset = "0x1EFD2BC", VA = "0x1EFD2BC")]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1EFD028", Offset = "0x1EFD028", VA = "0x1EFD028")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1EFD2FC", Offset = "0x1EFD2FC", VA = "0x1EFD2FC")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1EFC884", Offset = "0x1EFC884", VA = "0x1EFC884")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1EFC968", Offset = "0x1EFC968", VA = "0x1EFC968")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1EFD3F4", Offset = "0x1EFD3F4", VA = "0x1EFD3F4")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1EFD4A8", Offset = "0x1EFD4A8", VA = "0x1EFD4A8")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1EFD4AC", Offset = "0x1EFD4AC", VA = "0x1EFD4AC")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1EFD4C4", Offset = "0x1EFD4C4", VA = "0x1EFD4C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1EFD4F0", Offset = "0x1EFD4F0", VA = "0x1EFD4F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1EFD51C", Offset = "0x1EFD51C", VA = "0x1EFD51C")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9F9FF8", Offset = "0x9F9FF8")]
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
			[Address(RVA = "0x1EFD83C", Offset = "0x1EFD83C", VA = "0x1EFD83C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x1EFDA10", Offset = "0x1EFDA10", VA = "0x1EFDA10")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public float y
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1EFDAFC", Offset = "0x1EFDAFC", VA = "0x1EFDAFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x1EFDC34", Offset = "0x1EFDC34", VA = "0x1EFDC34")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public float z
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1EFDC74", Offset = "0x1EFDC74", VA = "0x1EFDC74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1EFDDAC", Offset = "0x1EFDDAC", VA = "0x1EFDDAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public float Item
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x1EFDDEC", Offset = "0x1EFDDEC", VA = "0x1EFDDEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x1EFDE60", Offset = "0x1EFDE60", VA = "0x1EFDE60")]
			set
			{
			}
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1EFD5B8", Offset = "0x1EFD5B8", VA = "0x1EFD5B8")]
		private ObscuredVector3(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1EFD65C", Offset = "0x1EFD65C", VA = "0x1EFD65C")]
		public Vector3 getValue()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1EFDED4", Offset = "0x1EFDED4", VA = "0x1EFDED4")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1EFDF3C", Offset = "0x1EFDF3C", VA = "0x1EFDF3C")]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1EFDFC8", Offset = "0x1EFDFC8", VA = "0x1EFDFC8")]
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1EFE0CC", Offset = "0x1EFE0CC", VA = "0x1EFE0CC")]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1EFE140", Offset = "0x1EFE140", VA = "0x1EFE140")]
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1EFE238", Offset = "0x1EFE238", VA = "0x1EFE238")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1EFE324", Offset = "0x1EFE324", VA = "0x1EFE324")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1EFE3D8", Offset = "0x1EFE3D8", VA = "0x1EFE3D8")]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1EFE400", Offset = "0x1EFE400", VA = "0x1EFE400")]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1EFD660", Offset = "0x1EFD660", VA = "0x1EFD660")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1EFE448", Offset = "0x1EFE448", VA = "0x1EFE448")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1EFD96C", Offset = "0x1EFD96C", VA = "0x1EFD96C")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1EFDA50", Offset = "0x1EFDA50", VA = "0x1EFDA50")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1EFE574", Offset = "0x1EFE574", VA = "0x1EFE574")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1EFE648", Offset = "0x1EFE648", VA = "0x1EFE648")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1EFE64C", Offset = "0x1EFE64C", VA = "0x1EFE64C")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1EFE714", Offset = "0x1EFE714", VA = "0x1EFE714")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1EFE7D0", Offset = "0x1EFE7D0", VA = "0x1EFE7D0")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1EFE88C", Offset = "0x1EFE88C", VA = "0x1EFE88C")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1EFE954", Offset = "0x1EFE954", VA = "0x1EFE954")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1EFEA10", Offset = "0x1EFEA10", VA = "0x1EFEA10")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1EFEACC", Offset = "0x1EFEACC", VA = "0x1EFEACC")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1EFEB7C", Offset = "0x1EFEB7C", VA = "0x1EFEB7C")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1EFEC30", Offset = "0x1EFEC30", VA = "0x1EFEC30")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1EFECE4", Offset = "0x1EFECE4", VA = "0x1EFECE4")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1EFED98", Offset = "0x1EFED98", VA = "0x1EFED98")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1EFEDF8", Offset = "0x1EFEDF8", VA = "0x1EFEDF8")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1EFEE44", Offset = "0x1EFEE44", VA = "0x1EFEE44")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1EFEE84", Offset = "0x1EFEE84", VA = "0x1EFEE84")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1EFEEE4", Offset = "0x1EFEEE4", VA = "0x1EFEEE4")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1EFEF30", Offset = "0x1EFEF30", VA = "0x1EFEF30")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1EFEF70", Offset = "0x1EFEF70", VA = "0x1EFEF70", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1EFEFB4", Offset = "0x1EFEFB4", VA = "0x1EFEFB4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1EFEFE4", Offset = "0x1EFEFE4", VA = "0x1EFEFE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1EFF014", Offset = "0x1EFF014", VA = "0x1EFF014")]
		public string ToString(string format)
		{
			return null;
		}
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FA030", Offset = "0x9FA030")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB500", Offset = "0x9FB500")]
		public bool autoStart;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB538", Offset = "0x9FB538")]
		public bool keepAlive;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB570", Offset = "0x9FB570")]
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
		[Address(RVA = "0x1D25FC8", Offset = "0x1D25FC8", VA = "0x1D25FC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1D260E4", Offset = "0x1D260E4", VA = "0x1D260E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1D2610C", Offset = "0x1D2610C", VA = "0x1D2610C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1D26124", Offset = "0x1D26124", VA = "0x1D26124")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1D26130", Offset = "0x1D26130", VA = "0x1D26130", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1D26274", Offset = "0x1D26274", VA = "0x1D26274", Slot = "5")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1D26434", Offset = "0x1D26434", VA = "0x1D26434", Slot = "6")]
		protected virtual void DisposeInternal()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1D26498", Offset = "0x1D26498", VA = "0x1D26498", Slot = "7")]
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
		[Address(RVA = "0x1D264FC", Offset = "0x1D264FC", VA = "0x1D264FC")]
		protected ActDetectorBase()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FA068", Offset = "0x9FA068")]
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
			[Address(RVA = "0x25D7CB4", Offset = "0x25D7CB4", VA = "0x25D7CB4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FB5C8", Offset = "0x9FB5C8")]
		private static InjectionDetector <Instance>k__BackingField;

		[Token(Token = "0x1700008B")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1B202B8", Offset = "0x1B202B8", VA = "0x1B202B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD04", Offset = "0x9FCD04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1B20304", Offset = "0x1B20304", VA = "0x1B20304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD14", Offset = "0x9FCD14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		private static InjectionDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1B1FF08", Offset = "0x1B1FF08", VA = "0x1B1FF08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1B1FB54", Offset = "0x1B1FB54", VA = "0x1B1FB54")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1B1FEDC", Offset = "0x1B1FEDC", VA = "0x1B1FEDC")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1B200D8", Offset = "0x1B200D8", VA = "0x1B200D8")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1B201C8", Offset = "0x1B201C8", VA = "0x1B201C8")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1B20354", Offset = "0x1B20354", VA = "0x1B20354")]
		private InjectionDetector()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1B2035C", Offset = "0x1B2035C", VA = "0x1B2035C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1B204D0", Offset = "0x1B204D0", VA = "0x1B204D0", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1B205C4", Offset = "0x1B205C4", VA = "0x1B205C4")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1B1FC88", Offset = "0x1B1FC88", VA = "0x1B1FC88")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1B20CB4", Offset = "0x1B20CB4", VA = "0x1B20CB4", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1B20CBC", Offset = "0x1B20CBC", VA = "0x1B20CBC", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1B20D60", Offset = "0x1B20D60", VA = "0x1B20D60", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1B20E28", Offset = "0x1B20E28", VA = "0x1B20E28", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1B20EDC", Offset = "0x1B20EDC", VA = "0x1B20EDC", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1B20FC0", Offset = "0x1B20FC0", VA = "0x1B20FC0")]
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1B20C18", Offset = "0x1B20C18", VA = "0x1B20C18")]
		private bool FindInjectionInCurrentAssemblies()
		{
			return default(bool);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1B21008", Offset = "0x1B21008", VA = "0x1B21008")]
		private bool AssemblyAllowed(Assembly ass)
		{
			return default(bool);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1B206B8", Offset = "0x1B206B8", VA = "0x1B206B8")]
		private void LoadAndParseAllowedAssemblies()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1B21110", Offset = "0x1B21110", VA = "0x1B21110")]
		private int GetAssemblyHash(Assembly ass)
		{
			return default(int);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1B211EC", Offset = "0x1B211EC", VA = "0x1B211EC")]
		private string PublicKeyTokenToString(byte[] bytes)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FA0A0", Offset = "0x9FA0A0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB5D8", Offset = "0x9FB5D8")]
		public float floatEpsilon;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB610", Offset = "0x9FB610")]
		public float vector2Epsilon;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB648", Offset = "0x9FB648")]
		public float vector3Epsilon;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB680", Offset = "0x9FB680")]
		public float quaternionEpsilon;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FB6B8", Offset = "0x9FB6B8")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;

		[Token(Token = "0x1700008D")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x2070B38", Offset = "0x2070B38", VA = "0x2070B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD24", Offset = "0x9FCD24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x2070B84", Offset = "0x2070B84", VA = "0x2070B84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD34", Offset = "0x9FCD34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x2070788", Offset = "0x2070788", VA = "0x2070788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		internal static bool IsRunning
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x206EF64", Offset = "0x206EF64", VA = "0x206EF64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x207047C", Offset = "0x207047C", VA = "0x207047C")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x207075C", Offset = "0x207075C", VA = "0x207075C")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x2070958", Offset = "0x2070958", VA = "0x2070958")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2070A48", Offset = "0x2070A48", VA = "0x2070A48")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x2070BD4", Offset = "0x2070BD4", VA = "0x2070BD4")]
		private ObscuredCheatingDetector()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x2070BE8", Offset = "0x2070BE8", VA = "0x2070BE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2070D5C", Offset = "0x2070D5C", VA = "0x2070D5C", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x2070E50", Offset = "0x2070E50", VA = "0x2070E50")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x20705B0", Offset = "0x20705B0", VA = "0x20705B0")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2070F44", Offset = "0x2070F44", VA = "0x2070F44", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x2070F4C", Offset = "0x2070F4C", VA = "0x2070F4C", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2070F54", Offset = "0x2070F54", VA = "0x2070F54", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2070F70", Offset = "0x2070F70", VA = "0x2070F70", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2070F84", Offset = "0x2070F84", VA = "0x2070F84", Slot = "6")]
		protected override void DisposeInternal()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FA0D8", Offset = "0x9FA0D8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB6C8", Offset = "0x9FB6C8")]
		public float interval;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB700", Offset = "0x9FB700")]
		public byte maxFalsePositives;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB738", Offset = "0x9FB738")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FB770", Offset = "0x9FB770")]
		private static SpeedHackDetector <Instance>k__BackingField;

		[Token(Token = "0x17000090")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x1F04460", Offset = "0x1F04460", VA = "0x1F04460")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD44", Offset = "0x9FCD44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x1F044AC", Offset = "0x1F044AC", VA = "0x1F044AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD54", Offset = "0x9FCD54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x1F03FD4", Offset = "0x1F03FD4", VA = "0x1F03FD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1F03C70", Offset = "0x1F03C70", VA = "0x1F03C70")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1F03FA4", Offset = "0x1F03FA4", VA = "0x1F03FA4")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1F041A4", Offset = "0x1F041A4", VA = "0x1F041A4")]
		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1F041E4", Offset = "0x1F041E4", VA = "0x1F041E4")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1F0422C", Offset = "0x1F0422C", VA = "0x1F0422C")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1F04280", Offset = "0x1F04280", VA = "0x1F04280")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1F04370", Offset = "0x1F04370", VA = "0x1F04370")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1F044FC", Offset = "0x1F044FC", VA = "0x1F044FC")]
		private SpeedHackDetector()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1F0451C", Offset = "0x1F0451C", VA = "0x1F0451C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1F04690", Offset = "0x1F04690", VA = "0x1F04690", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1F04784", Offset = "0x1F04784", VA = "0x1F04784")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1F04878", Offset = "0x1F04878", VA = "0x1F04878")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1F04924", Offset = "0x1F04924", VA = "0x1F04924")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1F03DB0", Offset = "0x1F03DB0", VA = "0x1F03DB0")]
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1F04AB8", Offset = "0x1F04AB8", VA = "0x1F04AB8", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1F04ACC", Offset = "0x1F04ACC", VA = "0x1F04ACC", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1F04AD4", Offset = "0x1F04AD4", VA = "0x1F04AD4", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1F04AF0", Offset = "0x1F04AF0", VA = "0x1F04AF0", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1F04B04", Offset = "0x1F04B04", VA = "0x1F04B04", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1F04884", Offset = "0x1F04884", VA = "0x1F04884")]
		private void ResetStartTicks()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FA110", Offset = "0x9FA110")]
	public class WallHackDetector : ActDetectorBase
	{
		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FA148", Offset = "0x9FA148")]
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
				[Address(RVA = "0x25DCAB4", Offset = "0x25DCAB4", VA = "0x25DCAB4", Slot = "4")]
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
				[Address(RVA = "0x25DCAFC", Offset = "0x25DCAFC", VA = "0x25DCAFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x25DC9C4", Offset = "0x25DC9C4", VA = "0x25DC9C4")]
			[DebuggerHidden]
			public <InitDetector>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x25DC9F0", Offset = "0x25DC9F0", VA = "0x25DC9F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x25DC9F4", Offset = "0x25DC9F4", VA = "0x25DC9F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x25DCABC", Offset = "0x25DCABC", VA = "0x25DCABC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FA158", Offset = "0x9FA158")]
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
				[Address(RVA = "0x25DC974", Offset = "0x25DC974", VA = "0x25DC974", Slot = "4")]
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
				[Address(RVA = "0x25DC9BC", Offset = "0x25DC9BC", VA = "0x25DC9BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x25DC56C", Offset = "0x25DC56C", VA = "0x25DC56C")]
			[DebuggerHidden]
			public <CaptureFrame>d__82(int <>1__state)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x25DC598", Offset = "0x25DC598", VA = "0x25DC598", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x25DC59C", Offset = "0x25DC59C", VA = "0x25DC59C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x25DC97C", Offset = "0x25DC97C", VA = "0x25DC97C", Slot = "8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB780", Offset = "0x9FB780")]
		private bool checkRigidbody;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB7CC", Offset = "0x9FB7CC")]
		[SerializeField]
		private bool checkController;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB818", Offset = "0x9FB818")]
		private bool checkWireframe;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB864", Offset = "0x9FB864")]
		[SerializeField]
		private bool checkRaycast;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB8B0", Offset = "0x9FB8B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FB8B0", Offset = "0x9FB8B0")]
		public int wireframeDelay;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FB908", Offset = "0x9FB908")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB908", Offset = "0x9FB908")]
		public int raycastDelay;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB960", Offset = "0x9FB960")]
		public Vector3 spawnPosition;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9FB998", Offset = "0x9FB998")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FB9D0", Offset = "0x9FB9D0")]
		private static WallHackDetector <Instance>k__BackingField;

		[Token(Token = "0x17000092")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1F083AC", Offset = "0x1F083AC", VA = "0x1F083AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1F083B4", Offset = "0x1F083B4", VA = "0x1F083B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool CheckController
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1F097A8", Offset = "0x1F097A8", VA = "0x1F097A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1F097B0", Offset = "0x1F097B0", VA = "0x1F097B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool CheckWireframe
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1F09A24", Offset = "0x1F09A24", VA = "0x1F09A24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1F09A2C", Offset = "0x1F09A2C", VA = "0x1F09A2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool CheckRaycast
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1F09BB8", Offset = "0x1F09BB8", VA = "0x1F09BB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1F09BC0", Offset = "0x1F09BC0", VA = "0x1F09BC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x1F0A514", Offset = "0x1F0A514", VA = "0x1F0A514")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD64", Offset = "0x9FCD64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1F0A560", Offset = "0x1F0A560", VA = "0x1F0A560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FCD74", Offset = "0x9FCD74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1F0A0B0", Offset = "0x1F0A0B0", VA = "0x1F0A0B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1F09D38", Offset = "0x1F09D38", VA = "0x1F09D38")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1F0A07C", Offset = "0x1F0A07C", VA = "0x1F0A07C")]
		public static void StartDetection(UnityAction callback)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1F0A280", Offset = "0x1F0A280", VA = "0x1F0A280")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1F0A2D8", Offset = "0x1F0A2D8", VA = "0x1F0A2D8")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1F0A334", Offset = "0x1F0A334", VA = "0x1F0A334")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1F0A424", Offset = "0x1F0A424", VA = "0x1F0A424")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1F0A5B0", Offset = "0x1F0A5B0", VA = "0x1F0A5B0")]
		private WallHackDetector()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1F0A664", Offset = "0x1F0A664", VA = "0x1F0A664")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1F0A7D8", Offset = "0x1F0A7D8", VA = "0x1F0A7D8", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1F0A9D8", Offset = "0x1F0A9D8", VA = "0x1F0A9D8")]
		private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x1F0AACC", Offset = "0x1F0AACC", VA = "0x1F0AACC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1F0AC08", Offset = "0x1F0AC08", VA = "0x1F0AC08")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1F09E78", Offset = "0x1F09E78", VA = "0x1F09E78")]
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1F0AD94", Offset = "0x1F0AD94", VA = "0x1F0AD94", Slot = "8")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1F0ADA8", Offset = "0x1F0ADA8", VA = "0x1F0ADA8", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1F0ADEC", Offset = "0x1F0ADEC", VA = "0x1F0ADEC", Slot = "11")]
		protected override void ResumeDetector()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1F0AE68", Offset = "0x1F0AE68", VA = "0x1F0AE68", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1F0AEA0", Offset = "0x1F0AEA0", VA = "0x1F0AEA0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1F08464", Offset = "0x1F08464", VA = "0x1F08464")]
		private void UpdateServiceContainer()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1F0AD28", Offset = "0x1F0AD28", VA = "0x1F0AD28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCD84", Offset = "0x9FCD84")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1F09584", Offset = "0x1F09584", VA = "0x1F09584")]
		private void StartRigidModule()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1F09860", Offset = "0x1F09860", VA = "0x1F09860")]
		private void StartControllerModule()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1F09ADC", Offset = "0x1F09ADC", VA = "0x1F09ADC")]
		private void StartWireframeModule()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1F0B4F8", Offset = "0x1F0B4F8", VA = "0x1F0B4F8")]
		private void ShootWireframeModule()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1F0B568", Offset = "0x1F0B568", VA = "0x1F0B568")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9FCDE4", Offset = "0x9FCDE4")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1F09C70", Offset = "0x1F09C70", VA = "0x1F09C70")]
		private void StartRaycastModule()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1F0B5D4", Offset = "0x1F0B5D4", VA = "0x1F0B5D4")]
		private void ShootRaycastModule()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1F096F8", Offset = "0x1F096F8", VA = "0x1F096F8")]
		private void StopRigidModule()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1F09990", Offset = "0x1F09990", VA = "0x1F09990")]
		private void StopControllerModule()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1F09B68", Offset = "0x1F09B68", VA = "0x1F09B68")]
		private void StopWireframeModule()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1F09CE8", Offset = "0x1F09CE8", VA = "0x1F09CE8")]
		private void StopRaycastModule()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1F0B1B0", Offset = "0x1F0B1B0", VA = "0x1F0B1B0")]
		private void InitRigidModule()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1F0B3B8", Offset = "0x1F0B3B8", VA = "0x1F0B3B8")]
		private void InitControllerModule()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1F0B0F4", Offset = "0x1F0B0F4", VA = "0x1F0B0F4")]
		private void UninitRigidModule()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1F0B2FC", Offset = "0x1F0B2FC", VA = "0x1F0B2FC")]
		private void UninitControllerModule()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1F0ABAC", Offset = "0x1F0ABAC", VA = "0x1F0ABAC")]
		private bool Detect()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1F0AF84", Offset = "0x1F0AF84", VA = "0x1F0AF84")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1F0B000", Offset = "0x1F0B000", VA = "0x1F0B000")]
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
		[Address(RVA = "0x1B1679C", Offset = "0x1B1679C", VA = "0x1B1679C")]
		public Constants()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Examples
{
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FA168", Offset = "0x9FA168")]
	public class ActRotatorExample : MonoBehaviour
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9FB9E0", Offset = "0x9FB9E0")]
		public float speed;

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1D26514", Offset = "0x1D26514", VA = "0x1D26514")]
		private void Update()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1D2656C", Offset = "0x1D2656C", VA = "0x1D2656C")]
		public ActRotatorExample()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FA1A0", Offset = "0x9FA1A0")]
	public class ActTesterGui : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FA1D8", Offset = "0x9FA1D8")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string types;

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x1F0BBE4", Offset = "0x1F0BBE4", VA = "0x1F0BBE4")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x1F0BBEC", Offset = "0x1F0BBEC", VA = "0x1F0BBEC")]
			internal void <GetAllSimpleObscuredTypes>b__1(Type t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FA1E8", Offset = "0x9FA1E8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> <>9__61_0;

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x1F0BB20", Offset = "0x1F0BB20", VA = "0x1F0BB20")]
			public <>c()
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1F0BB28", Offset = "0x1F0BB28", VA = "0x1F0BB28")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FB9FC", Offset = "0x9FB9FC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FBA34", Offset = "0x9FBA34")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9FBA6C", Offset = "0x9FBA6C")]
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
		[Address(RVA = "0x1D2657C", Offset = "0x1D2657C", VA = "0x1D2657C")]
		public void OnSpeedHackDetected()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1D265FC", Offset = "0x1D265FC", VA = "0x1D265FC")]
		public void OnInjectionDetected()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1D2667C", Offset = "0x1D2667C", VA = "0x1D2667C")]
		public void OnObscuredTypeCheatingDetected()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1D266FC", Offset = "0x1D266FC", VA = "0x1D266FC")]
		public void OnWallHackDetected()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1D2677C", Offset = "0x1D2677C", VA = "0x1D2677C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1D2687C", Offset = "0x1D2687C", VA = "0x1D2687C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1D277AC", Offset = "0x1D277AC", VA = "0x1D277AC")]
		private void RandomizeObscuredVars()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1D268FC", Offset = "0x1D268FC", VA = "0x1D268FC")]
		private void ObscuredStringExample()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1D26AE0", Offset = "0x1D26AE0", VA = "0x1D26AE0")]
		private void ObscuredIntExample()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1D26FAC", Offset = "0x1D26FAC", VA = "0x1D26FAC")]
		private void ObscuredFloatExample()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1D273BC", Offset = "0x1D273BC", VA = "0x1D273BC")]
		private void ObscuredVector3Example()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1D27844", Offset = "0x1D27844", VA = "0x1D27844")]
		private void SavesAlterationDetected()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1D27850", Offset = "0x1D27850", VA = "0x1D27850")]
		private void ForeignSavesDetected()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1D2785C", Offset = "0x1D2785C", VA = "0x1D2785C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1D2DD80", Offset = "0x1D2DD80", VA = "0x1D2DD80")]
		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1D2E024", Offset = "0x1D2E024", VA = "0x1D2E024")]
		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1D2E068", Offset = "0x1D2E068", VA = "0x1D2E068")]
		private void LoadRegularPrefs()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1D2E1E8", Offset = "0x1D2E1E8", VA = "0x1D2E1E8")]
		private void SaveRegularPrefs()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1D2E29C", Offset = "0x1D2E29C", VA = "0x1D2E29C")]
		private void DeleteRegularPrefs()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1D2E32C", Offset = "0x1D2E32C", VA = "0x1D2E32C")]
		private void LoadObscuredPrefs()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1D2EBE4", Offset = "0x1D2EBE4", VA = "0x1D2EBE4")]
		private void SaveObscuredPrefs()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1D2EEEC", Offset = "0x1D2EEEC", VA = "0x1D2EEEC")]
		private void DeleteObscuredPrefs()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1D2F0E8", Offset = "0x1D2F0E8", VA = "0x1D2F0E8")]
		private void PlaceUrlButton(string url)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1D2F1E4", Offset = "0x1D2F1E4", VA = "0x1D2F1E4")]
		private void PlaceUrlButton(string url, int width)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1D2F0F0", Offset = "0x1D2F0F0", VA = "0x1D2F0F0")]
		private void PlaceUrlButton(string url, string buttonName, int width)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1D2F240", Offset = "0x1D2F240", VA = "0x1D2F240")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1D2F254", Offset = "0x1D2F254", VA = "0x1D2F254")]
		public ActTesterGui()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	internal class HorizontalLayout : IDisposable
	{
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1B1FB20", Offset = "0x1B1FB20", VA = "0x1B1FB20")]
		public HorizontalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1B1FB4C", Offset = "0x1B1FB4C", VA = "0x1B1FB4C", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	internal class VerticalLayout : IDisposable
	{
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1F07D00", Offset = "0x1F07D00", VA = "0x1F07D00")]
		public VerticalLayout(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x1F07D2C", Offset = "0x1F07D2C", VA = "0x1F07D2C")]
		public VerticalLayout(GUIStyle style)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1F07E14", Offset = "0x1F07E14", VA = "0x1F07E14", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FA1F8", Offset = "0x9FA1F8")]
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
		[Address(RVA = "0x2074E84", Offset = "0x2074E84", VA = "0x2074E84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x2074ED8", Offset = "0x2074ED8", VA = "0x2074ED8")]
		private void StartTests()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2075040", Offset = "0x2075040", VA = "0x2075040")]
		private void TestBool()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2075354", Offset = "0x2075354", VA = "0x2075354")]
		private void TestByte()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2075654", Offset = "0x2075654", VA = "0x2075654")]
		private void TestShort()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2075950", Offset = "0x2075950", VA = "0x2075950")]
		private void TestUShort()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x20768D8", Offset = "0x20768D8", VA = "0x20768D8")]
		private void TestDouble()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2076584", Offset = "0x2076584", VA = "0x2076584")]
		private void TestFloat()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x2075C4C", Offset = "0x2075C4C", VA = "0x2075C4C")]
		private void TestInt()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2076268", Offset = "0x2076268", VA = "0x2076268")]
		private void TestLong()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2076C00", Offset = "0x2076C00", VA = "0x2076C00")]
		private void TestString()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2075F54", Offset = "0x2075F54", VA = "0x2075F54")]
		private void TestUInt()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2076FA4", Offset = "0x2076FA4", VA = "0x2076FA4")]
		private void TestVector3()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2077408", Offset = "0x2077408", VA = "0x2077408")]
		private void TestPrefs()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2077F38", Offset = "0x2077F38", VA = "0x2077F38")]
		public ObscuredPerformanceTests()
		{
		}
	}
}
